using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005C7 RID: 1479
	public class PgpV3SignatureGenerator
	{
		// Token: 0x060037CC RID: 14284 RVA: 0x00107E41 File Offset: 0x00106041
		public PgpV3SignatureGenerator(global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm)
		{
			this.keyAlgorithm = keyAlgorithm;
			this.hashAlgorithm = hashAlgorithm;
			this.dig = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetDigestName(hashAlgorithm));
			this.sig = global::Org.BouncyCastle.Security.SignerUtilities.GetSigner(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetSignatureName(keyAlgorithm, hashAlgorithm));
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x00107E7A File Offset: 0x0010607A
		public void InitSign(int sigType, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey key)
		{
			this.InitSign(sigType, key, null);
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x00107E88 File Offset: 0x00106088
		public void InitSign(int sigType, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey key, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			this.privKey = key;
			this.signatureType = sigType;
			try
			{
				global::Org.BouncyCastle.Crypto.ICipherParameters cp = key.Key;
				if (random != null)
				{
					cp = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(key.Key, random);
				}
				this.sig.Init(true, cp);
			}
			catch (global::Org.BouncyCastle.Security.InvalidKeyException e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("invalid key.", e);
			}
			this.dig.Reset();
			this.lastb = 0;
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x00107EF8 File Offset: 0x001060F8
		public void Update(byte b)
		{
			if (this.signatureType == 1)
			{
				this.doCanonicalUpdateByte(b);
				return;
			}
			this.doUpdateByte(b);
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x00107F12 File Offset: 0x00106112
		private void doCanonicalUpdateByte(byte b)
		{
			if (b == 13)
			{
				this.doUpdateCRLF();
			}
			else if (b == 10)
			{
				if (this.lastb != 13)
				{
					this.doUpdateCRLF();
				}
			}
			else
			{
				this.doUpdateByte(b);
			}
			this.lastb = b;
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x00107F46 File Offset: 0x00106146
		private void doUpdateCRLF()
		{
			this.doUpdateByte(13);
			this.doUpdateByte(10);
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x00107F58 File Offset: 0x00106158
		private void doUpdateByte(byte b)
		{
			this.sig.Update(b);
			this.dig.Update(b);
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x00107F74 File Offset: 0x00106174
		public void Update(byte[] b)
		{
			if (this.signatureType == 1)
			{
				for (int i = 0; i != b.Length; i++)
				{
					this.doCanonicalUpdateByte(b[i]);
				}
				return;
			}
			this.sig.BlockUpdate(b, 0, b.Length);
			this.dig.BlockUpdate(b, 0, b.Length);
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x00107FC4 File Offset: 0x001061C4
		public void Update(byte[] b, int off, int len)
		{
			if (this.signatureType == 1)
			{
				int finish = off + len;
				for (int i = off; i != finish; i++)
				{
					this.doCanonicalUpdateByte(b[i]);
				}
				return;
			}
			this.sig.BlockUpdate(b, off, len);
			this.dig.BlockUpdate(b, off, len);
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x00108010 File Offset: 0x00106210
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature GenerateOnePassVersion(bool isNested)
		{
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature(new global::Org.BouncyCastle.Bcpg.OnePassSignaturePacket(this.signatureType, this.hashAlgorithm, this.keyAlgorithm, this.privKey.KeyId, isNested));
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x0010803C File Offset: 0x0010623C
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature Generate()
		{
			long creationTime = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs() / 1000L;
			byte[] hData = new byte[]
			{
				(byte)this.signatureType,
				(byte)(creationTime >> 24),
				(byte)(creationTime >> 16),
				(byte)(creationTime >> 8),
				(byte)creationTime
			};
			this.sig.BlockUpdate(hData, 0, hData.Length);
			this.dig.BlockUpdate(hData, 0, hData.Length);
			byte[] sigBytes = this.sig.GenerateSignature();
			byte[] digest = global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(this.dig);
			byte[] fingerPrint = new byte[]
			{
				digest[0],
				digest[1]
			};
			global::Org.BouncyCastle.Bcpg.MPInteger[] sigValues = (this.keyAlgorithm == global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaSign || this.keyAlgorithm == global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral) ? global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.RsaSigToMpi(sigBytes) : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.DsaSigToMpi(sigBytes);
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature(new global::Org.BouncyCastle.Bcpg.SignaturePacket(3, this.signatureType, this.privKey.KeyId, this.keyAlgorithm, this.hashAlgorithm, creationTime * 1000L, fingerPrint, sigValues));
		}

		// Token: 0x04001912 RID: 6418
		private global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm;

		// Token: 0x04001913 RID: 6419
		private global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm;

		// Token: 0x04001914 RID: 6420
		private global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey privKey;

		// Token: 0x04001915 RID: 6421
		private global::Org.BouncyCastle.Crypto.ISigner sig;

		// Token: 0x04001916 RID: 6422
		private global::Org.BouncyCastle.Crypto.IDigest dig;

		// Token: 0x04001917 RID: 6423
		private int signatureType;

		// Token: 0x04001918 RID: 6424
		private byte lastb;
	}
}
