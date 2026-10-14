using System;
using System.IO;
using Org.BouncyCastle.Bcpg.Sig;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005C0 RID: 1472
	public class PgpSignatureGenerator
	{
		// Token: 0x06003760 RID: 14176 RVA: 0x0010672C File Offset: 0x0010492C
		public PgpSignatureGenerator(global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm)
		{
			this.keyAlgorithm = keyAlgorithm;
			this.hashAlgorithm = hashAlgorithm;
			this.dig = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetDigestName(hashAlgorithm));
			this.sig = global::Org.BouncyCastle.Security.SignerUtilities.GetSigner(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetSignatureName(keyAlgorithm, hashAlgorithm));
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x00106786 File Offset: 0x00104986
		public void InitSign(int sigType, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey key)
		{
			this.InitSign(sigType, key, null);
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x00106794 File Offset: 0x00104994
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

		// Token: 0x06003763 RID: 14179 RVA: 0x00106804 File Offset: 0x00104A04
		public void Update(byte b)
		{
			if (this.signatureType == 1)
			{
				this.doCanonicalUpdateByte(b);
				return;
			}
			this.doUpdateByte(b);
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x0010681E File Offset: 0x00104A1E
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

		// Token: 0x06003765 RID: 14181 RVA: 0x00106852 File Offset: 0x00104A52
		private void doUpdateCRLF()
		{
			this.doUpdateByte(13);
			this.doUpdateByte(10);
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x00106864 File Offset: 0x00104A64
		private void doUpdateByte(byte b)
		{
			this.sig.Update(b);
			this.dig.Update(b);
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x0010687E File Offset: 0x00104A7E
		public void Update(params byte[] b)
		{
			this.Update(b, 0, b.Length);
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x0010688C File Offset: 0x00104A8C
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

		// Token: 0x06003769 RID: 14185 RVA: 0x001068D8 File Offset: 0x00104AD8
		public void SetHashedSubpackets(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets)
		{
			this.hashed = ((hashedPackets == null) ? global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator.EmptySignatureSubpackets : hashedPackets.ToSubpacketArray());
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x001068F0 File Offset: 0x00104AF0
		public void SetUnhashedSubpackets(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets)
		{
			this.unhashed = ((unhashedPackets == null) ? global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator.EmptySignatureSubpackets : unhashedPackets.ToSubpacketArray());
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x00106908 File Offset: 0x00104B08
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature GenerateOnePassVersion(bool isNested)
		{
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature(new global::Org.BouncyCastle.Bcpg.OnePassSignaturePacket(this.signatureType, this.hashAlgorithm, this.keyAlgorithm, this.privKey.KeyId, isNested));
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x00106934 File Offset: 0x00104B34
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature Generate()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] hPkts = this.hashed;
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] unhPkts = this.unhashed;
			if (!this.packetPresent(this.hashed, global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.CreationTime))
			{
				hPkts = this.insertSubpacket(hPkts, new global::Org.BouncyCastle.Bcpg.Sig.SignatureCreationTime(false, global::System.DateTime.UtcNow));
			}
			if (!this.packetPresent(this.hashed, global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.IssuerKeyId) && !this.packetPresent(this.unhashed, global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.IssuerKeyId))
			{
				unhPkts = this.insertSubpacket(unhPkts, new global::Org.BouncyCastle.Bcpg.Sig.IssuerKeyId(false, this.privKey.KeyId));
			}
			int version = 4;
			byte[] hData;
			try
			{
				global::System.IO.MemoryStream hOut = new global::System.IO.MemoryStream();
				for (int i = 0; i != hPkts.Length; i++)
				{
					hPkts[i].Encode(hOut);
				}
				byte[] data = hOut.ToArray();
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(data.Length + 6);
				memoryStream.WriteByte((byte)version);
				memoryStream.WriteByte((byte)this.signatureType);
				memoryStream.WriteByte((byte)this.keyAlgorithm);
				memoryStream.WriteByte((byte)this.hashAlgorithm);
				memoryStream.WriteByte((byte)(data.Length >> 8));
				memoryStream.WriteByte((byte)data.Length);
				memoryStream.Write(data, 0, data.Length);
				hData = memoryStream.ToArray();
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("exception encoding hashed data.", e);
			}
			this.sig.BlockUpdate(hData, 0, hData.Length);
			this.dig.BlockUpdate(hData, 0, hData.Length);
			hData = new byte[]
			{
				(byte)version,
				byte.MaxValue,
				(byte)(hData.Length >> 24),
				(byte)(hData.Length >> 16),
				(byte)(hData.Length >> 8),
				(byte)hData.Length
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
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature(new global::Org.BouncyCastle.Bcpg.SignaturePacket(this.signatureType, this.privKey.KeyId, this.keyAlgorithm, this.hashAlgorithm, hPkts, unhPkts, fingerPrint, sigValues));
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x00106B60 File Offset: 0x00104D60
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature GenerateCertification(string id, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			this.UpdateWithPublicKey(pubKey);
			this.UpdateWithIdData(180, global::Org.BouncyCastle.Utilities.Strings.ToUtf8ByteArray(id));
			return this.Generate();
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x00106B80 File Offset: 0x00104D80
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature GenerateCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector userAttributes, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			this.UpdateWithPublicKey(pubKey);
			try
			{
				global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
				global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket[] array = userAttributes.ToSubpacketArray();
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Encode(bOut);
				}
				this.UpdateWithIdData(209, bOut.ToArray());
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("cannot encode subpacket array", e);
			}
			return this.Generate();
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x00106BF0 File Offset: 0x00104DF0
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature GenerateCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey masterKey, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			this.UpdateWithPublicKey(masterKey);
			this.UpdateWithPublicKey(pubKey);
			return this.Generate();
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x00106C06 File Offset: 0x00104E06
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature GenerateCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			this.UpdateWithPublicKey(pubKey);
			return this.Generate();
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x00106C18 File Offset: 0x00104E18
		private byte[] GetEncodedPublicKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			byte[] encodedContents;
			try
			{
				encodedContents = pubKey.publicPk.GetEncodedContents();
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("exception preparing key.", e);
			}
			return encodedContents;
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x00106C54 File Offset: 0x00104E54
		private bool packetPresent(global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] packets, global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag type)
		{
			for (int i = 0; i != packets.Length; i++)
			{
				if (packets[i].SubpacketType == type)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x00106C80 File Offset: 0x00104E80
		private global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] insertSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] packets, global::Org.BouncyCastle.Bcpg.SignatureSubpacket subpacket)
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] tmp = new global::Org.BouncyCastle.Bcpg.SignatureSubpacket[packets.Length + 1];
			tmp[0] = subpacket;
			packets.CopyTo(tmp, 1);
			return tmp;
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x00106CA5 File Offset: 0x00104EA5
		private void UpdateWithIdData(int header, byte[] idBytes)
		{
			this.Update(new byte[]
			{
				(byte)header,
				(byte)(idBytes.Length >> 24),
				(byte)(idBytes.Length >> 16),
				(byte)(idBytes.Length >> 8),
				(byte)idBytes.Length
			});
			this.Update(idBytes);
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x00106CE4 File Offset: 0x00104EE4
		private void UpdateWithPublicKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key)
		{
			byte[] keyBytes = this.GetEncodedPublicKey(key);
			this.Update(new byte[]
			{
				153,
				(byte)(keyBytes.Length >> 8),
				(byte)keyBytes.Length
			});
			this.Update(keyBytes);
		}

		// Token: 0x04001902 RID: 6402
		private static readonly global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] EmptySignatureSubpackets = new global::Org.BouncyCastle.Bcpg.SignatureSubpacket[0];

		// Token: 0x04001903 RID: 6403
		private global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm;

		// Token: 0x04001904 RID: 6404
		private global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm;

		// Token: 0x04001905 RID: 6405
		private global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey privKey;

		// Token: 0x04001906 RID: 6406
		private global::Org.BouncyCastle.Crypto.ISigner sig;

		// Token: 0x04001907 RID: 6407
		private global::Org.BouncyCastle.Crypto.IDigest dig;

		// Token: 0x04001908 RID: 6408
		private int signatureType;

		// Token: 0x04001909 RID: 6409
		private byte lastb;

		// Token: 0x0400190A RID: 6410
		private global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] unhashed = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator.EmptySignatureSubpackets;

		// Token: 0x0400190B RID: 6411
		private global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] hashed = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator.EmptySignatureSubpackets;
	}
}
