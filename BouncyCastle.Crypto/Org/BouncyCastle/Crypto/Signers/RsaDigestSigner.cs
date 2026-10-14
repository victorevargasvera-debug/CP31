using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003AD RID: 941
	public class RsaDigestSigner : global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x0600264E RID: 9806 RVA: 0x000A6EAC File Offset: 0x000A50AC
		static RsaDigestSigner()
		{
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["RIPEMD128"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["RIPEMD160"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["RIPEMD256"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["SHA-1"] = global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdSha1;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["SHA-224"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["SHA-256"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["SHA-384"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["SHA-512"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["SHA-512/224"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["SHA-512/256"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["SHA3-224"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_224;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["SHA3-256"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_256;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["SHA3-384"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_384;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["SHA3-512"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_512;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["MD2"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["MD4"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4;
			global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap["MD5"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5;
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x000A7017 File Offset: 0x000A5217
		public RsaDigestSigner(global::Org.BouncyCastle.Crypto.IDigest digest) : this(digest, (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap[digest.AlgorithmName])
		{
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x000A7035 File Offset: 0x000A5235
		public RsaDigestSigner(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestOid) : this(digest, new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(digestOid, global::Org.BouncyCastle.Asn1.DerNull.Instance))
		{
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x000A7049 File Offset: 0x000A5249
		public RsaDigestSigner(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId) : this(new global::Org.BouncyCastle.Crypto.Engines.RsaCoreEngine(), digest, algId)
		{
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x000A7058 File Offset: 0x000A5258
		public RsaDigestSigner(global::Org.BouncyCastle.Crypto.IRsa rsa, global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestOid) : this(rsa, digest, new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(digestOid, global::Org.BouncyCastle.Asn1.DerNull.Instance))
		{
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x000A706D File Offset: 0x000A526D
		public RsaDigestSigner(global::Org.BouncyCastle.Crypto.IRsa rsa, global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId) : this(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(rsa), digest, algId)
		{
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x000A707D File Offset: 0x000A527D
		public RsaDigestSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher rsaEngine, global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId)
		{
			this.rsaEngine = new global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(rsaEngine);
			this.digest = digest;
			this.algId = algId;
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06002655 RID: 9813 RVA: 0x000A709F File Offset: 0x000A529F
		public virtual string AlgorithmName
		{
			get
			{
				return this.digest.AlgorithmName + "withRSA";
			}
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x000A70B8 File Offset: 0x000A52B8
		public virtual void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forSigning = forSigning;
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter i;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				i = (global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters).Parameters;
			}
			else
			{
				i = (global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)parameters;
			}
			if (forSigning && !i.IsPrivate)
			{
				throw new global::Org.BouncyCastle.Security.InvalidKeyException("Signing requires private key.");
			}
			if (!forSigning && i.IsPrivate)
			{
				throw new global::Org.BouncyCastle.Security.InvalidKeyException("Verification requires public key.");
			}
			this.Reset();
			this.rsaEngine.Init(forSigning, parameters);
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x000A712D File Offset: 0x000A532D
		public virtual void Update(byte input)
		{
			this.digest.Update(input);
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x000A713B File Offset: 0x000A533B
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
			this.digest.BlockUpdate(input, inOff, length);
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x000A714C File Offset: 0x000A534C
		public virtual byte[] GenerateSignature()
		{
			if (!this.forSigning)
			{
				throw new global::System.InvalidOperationException("RsaDigestSigner not initialised for signature generation.");
			}
			byte[] hash = new byte[this.digest.GetDigestSize()];
			this.digest.DoFinal(hash, 0);
			byte[] data = this.DerEncode(hash);
			return this.rsaEngine.ProcessBlock(data, 0, data.Length);
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x000A71A4 File Offset: 0x000A53A4
		public virtual bool VerifySignature(byte[] signature)
		{
			if (this.forSigning)
			{
				throw new global::System.InvalidOperationException("RsaDigestSigner not initialised for verification");
			}
			byte[] hash = new byte[this.digest.GetDigestSize()];
			this.digest.DoFinal(hash, 0);
			byte[] sig;
			byte[] expected;
			try
			{
				sig = this.rsaEngine.ProcessBlock(signature, 0, signature.Length);
				expected = this.DerEncode(hash);
			}
			catch (global::System.Exception)
			{
				return false;
			}
			if (sig.Length == expected.Length)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(sig, expected);
			}
			if (sig.Length == expected.Length - 2)
			{
				int sigOffset = sig.Length - hash.Length - 2;
				int expectedOffset = expected.Length - hash.Length - 2;
				byte[] array = expected;
				int num = 1;
				array[num] -= 2;
				byte[] array2 = expected;
				int num2 = 3;
				array2[num2] -= 2;
				int nonEqual = 0;
				for (int i = 0; i < hash.Length; i++)
				{
					nonEqual |= (int)(sig[sigOffset + i] ^ expected[expectedOffset + i]);
				}
				for (int j = 0; j < sigOffset; j++)
				{
					nonEqual |= (int)(sig[j] ^ expected[j]);
				}
				return nonEqual == 0;
			}
			return false;
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x000A72B4 File Offset: 0x000A54B4
		public virtual void Reset()
		{
			this.digest.Reset();
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x000A72C1 File Offset: 0x000A54C1
		private byte[] DerEncode(byte[] hash)
		{
			if (this.algId == null)
			{
				return hash;
			}
			return new global::Org.BouncyCastle.Asn1.X509.DigestInfo(this.algId, hash).GetDerEncoded();
		}

		// Token: 0x04000F6A RID: 3946
		private readonly global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher rsaEngine;

		// Token: 0x04000F6B RID: 3947
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId;

		// Token: 0x04000F6C RID: 3948
		private readonly global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04000F6D RID: 3949
		private bool forSigning;

		// Token: 0x04000F6E RID: 3950
		private static readonly global::System.Collections.IDictionary oidMap = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
