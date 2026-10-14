using System;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000EE RID: 238
	public sealed class SignatureAndHashAlgorithm
	{
		// Token: 0x060008A3 RID: 2211 RVA: 0x0002302C File Offset: 0x0002122C
		public static global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm GetInstance(short hashAlgorithm, short signatureAlgorithm)
		{
			if (hashAlgorithm == 8)
			{
				return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstanceIntrinsic(signatureAlgorithm);
			}
			return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(hashAlgorithm, signatureAlgorithm);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00023040 File Offset: 0x00021240
		private static global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm GetInstanceIntrinsic(short signatureAlgorithm)
		{
			if (signatureAlgorithm <= 28)
			{
				switch (signatureAlgorithm)
				{
				case 4:
					return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_rsae_sha256;
				case 5:
					return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_rsae_sha384;
				case 6:
					return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_rsae_sha512;
				case 7:
					return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.ed25519;
				case 8:
					return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.ed448;
				case 9:
					return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_pss_sha256;
				case 10:
					return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_pss_sha384;
				case 11:
					return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_pss_sha512;
				default:
					switch (signatureAlgorithm)
					{
					case 26:
						return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.ecdsa_brainpoolP256r1tls13_sha256;
					case 27:
						return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.ecdsa_brainpoolP384r1tls13_sha384;
					case 28:
						return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.ecdsa_brainpoolP512r1tls13_sha512;
					}
					break;
				}
			}
			else
			{
				if (signatureAlgorithm == 64)
				{
					return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.gostr34102012_256;
				}
				if (signatureAlgorithm == 65)
				{
					return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.gostr34102012_512;
				}
			}
			return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(8, signatureAlgorithm);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000230F4 File Offset: 0x000212F4
		private static global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm Create(int signatureScheme)
		{
			short hashAlgorithm = global::Org.BouncyCastle.Tls.SignatureScheme.GetHashAlgorithm(signatureScheme);
			short signatureAlgorithm = global::Org.BouncyCastle.Tls.SignatureScheme.GetSignatureAlgorithm(signatureScheme);
			return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(hashAlgorithm, signatureAlgorithm);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00023114 File Offset: 0x00021314
		private static global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm Create(short hashAlgorithm, short signatureAlgorithm)
		{
			return new global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm(hashAlgorithm, signatureAlgorithm);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00023120 File Offset: 0x00021320
		public SignatureAndHashAlgorithm(short hash, short signature)
		{
			if ((hash & 255) != hash)
			{
				throw new global::System.ArgumentException("should be a uint8", "hash");
			}
			if ((signature & 255) != signature)
			{
				throw new global::System.ArgumentException("should be a uint8", "signature");
			}
			this.m_hash = hash;
			this.m_signature = signature;
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00023175 File Offset: 0x00021375
		public short Hash
		{
			get
			{
				return this.m_hash;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0002317D File Offset: 0x0002137D
		public short Signature
		{
			get
			{
				return this.m_signature;
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00023185 File Offset: 0x00021385
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(this.Hash, output);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(this.Signature, output);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000231A0 File Offset: 0x000213A0
		public static global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm Parse(global::System.IO.Stream input)
		{
			short hashAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			short signature = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(hashAlgorithm, signature);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000231C0 File Offset: 0x000213C0
		public override bool Equals(object obj)
		{
			if (!(obj is global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm))
			{
				return false;
			}
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm other = (global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm)obj;
			return other.Hash == this.Hash && other.Signature == this.Signature;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x000231FC File Offset: 0x000213FC
		public override int GetHashCode()
		{
			return (int)this.Hash << 16 | (int)this.Signature;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00023210 File Offset: 0x00021410
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"{",
				global::Org.BouncyCastle.Tls.HashAlgorithm.GetText(this.Hash),
				",",
				global::Org.BouncyCastle.Tls.SignatureAlgorithm.GetText(this.Signature),
				"}"
			});
		}

		// Token: 0x04000699 RID: 1689
		public static readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm ecdsa_brainpoolP256r1tls13_sha256 = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(2074);

		// Token: 0x0400069A RID: 1690
		public static readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm ecdsa_brainpoolP384r1tls13_sha384 = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(2075);

		// Token: 0x0400069B RID: 1691
		public static readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm ecdsa_brainpoolP512r1tls13_sha512 = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(2076);

		// Token: 0x0400069C RID: 1692
		public static readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm ed25519 = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(2055);

		// Token: 0x0400069D RID: 1693
		public static readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm ed448 = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(2056);

		// Token: 0x0400069E RID: 1694
		public static readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm gostr34102012_256 = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(8, 64);

		// Token: 0x0400069F RID: 1695
		public static readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm gostr34102012_512 = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(8, 65);

		// Token: 0x040006A0 RID: 1696
		public static readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm rsa_pss_rsae_sha256 = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(2052);

		// Token: 0x040006A1 RID: 1697
		public static readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm rsa_pss_rsae_sha384 = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(2053);

		// Token: 0x040006A2 RID: 1698
		public static readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm rsa_pss_rsae_sha512 = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(2054);

		// Token: 0x040006A3 RID: 1699
		public static readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm rsa_pss_pss_sha256 = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(2057);

		// Token: 0x040006A4 RID: 1700
		public static readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm rsa_pss_pss_sha384 = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(2058);

		// Token: 0x040006A5 RID: 1701
		public static readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm rsa_pss_pss_sha512 = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Create(2059);

		// Token: 0x040006A6 RID: 1702
		private readonly short m_hash;

		// Token: 0x040006A7 RID: 1703
		private readonly short m_signature;
	}
}
