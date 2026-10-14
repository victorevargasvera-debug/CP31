using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006BE RID: 1726
	public class RsaPrivateKeyStructure : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F1C RID: 16156 RVA: 0x0011F5CF File Offset: 0x0011D7CF
		public static global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x0011F5DD File Offset: 0x0011D7DD
		public static global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure GetInstance(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure)obj;
			}
			return new global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x0011F600 File Offset: 0x0011D800
		public RsaPrivateKeyStructure(global::Org.BouncyCastle.Math.BigInteger modulus, global::Org.BouncyCastle.Math.BigInteger publicExponent, global::Org.BouncyCastle.Math.BigInteger privateExponent, global::Org.BouncyCastle.Math.BigInteger prime1, global::Org.BouncyCastle.Math.BigInteger prime2, global::Org.BouncyCastle.Math.BigInteger exponent1, global::Org.BouncyCastle.Math.BigInteger exponent2, global::Org.BouncyCastle.Math.BigInteger coefficient)
		{
			this.modulus = modulus;
			this.publicExponent = publicExponent;
			this.privateExponent = privateExponent;
			this.prime1 = prime1;
			this.prime2 = prime2;
			this.exponent1 = exponent1;
			this.exponent2 = exponent2;
			this.coefficient = coefficient;
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x0011F650 File Offset: 0x0011D850
		[global::System.Obsolete("Use 'GetInstance' method(s) instead")]
		public RsaPrivateKeyStructure(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (((global::Org.BouncyCastle.Asn1.DerInteger)seq[0]).Value.IntValue != 0)
			{
				throw new global::System.ArgumentException("wrong version for RSA private key");
			}
			this.modulus = ((global::Org.BouncyCastle.Asn1.DerInteger)seq[1]).Value;
			this.publicExponent = ((global::Org.BouncyCastle.Asn1.DerInteger)seq[2]).Value;
			this.privateExponent = ((global::Org.BouncyCastle.Asn1.DerInteger)seq[3]).Value;
			this.prime1 = ((global::Org.BouncyCastle.Asn1.DerInteger)seq[4]).Value;
			this.prime2 = ((global::Org.BouncyCastle.Asn1.DerInteger)seq[5]).Value;
			this.exponent1 = ((global::Org.BouncyCastle.Asn1.DerInteger)seq[6]).Value;
			this.exponent2 = ((global::Org.BouncyCastle.Asn1.DerInteger)seq[7]).Value;
			this.coefficient = ((global::Org.BouncyCastle.Asn1.DerInteger)seq[8]).Value;
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06003F20 RID: 16160 RVA: 0x0011F73E File Offset: 0x0011D93E
		public global::Org.BouncyCastle.Math.BigInteger Modulus
		{
			get
			{
				return this.modulus;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06003F21 RID: 16161 RVA: 0x0011F746 File Offset: 0x0011D946
		public global::Org.BouncyCastle.Math.BigInteger PublicExponent
		{
			get
			{
				return this.publicExponent;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06003F22 RID: 16162 RVA: 0x0011F74E File Offset: 0x0011D94E
		public global::Org.BouncyCastle.Math.BigInteger PrivateExponent
		{
			get
			{
				return this.privateExponent;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06003F23 RID: 16163 RVA: 0x0011F756 File Offset: 0x0011D956
		public global::Org.BouncyCastle.Math.BigInteger Prime1
		{
			get
			{
				return this.prime1;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06003F24 RID: 16164 RVA: 0x0011F75E File Offset: 0x0011D95E
		public global::Org.BouncyCastle.Math.BigInteger Prime2
		{
			get
			{
				return this.prime2;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06003F25 RID: 16165 RVA: 0x0011F766 File Offset: 0x0011D966
		public global::Org.BouncyCastle.Math.BigInteger Exponent1
		{
			get
			{
				return this.exponent1;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06003F26 RID: 16166 RVA: 0x0011F76E File Offset: 0x0011D96E
		public global::Org.BouncyCastle.Math.BigInteger Exponent2
		{
			get
			{
				return this.exponent2;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06003F27 RID: 16167 RVA: 0x0011F776 File Offset: 0x0011D976
		public global::Org.BouncyCastle.Math.BigInteger Coefficient
		{
			get
			{
				return this.coefficient;
			}
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x0011F780 File Offset: 0x0011D980
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.DerInteger(0),
				new global::Org.BouncyCastle.Asn1.DerInteger(this.Modulus),
				new global::Org.BouncyCastle.Asn1.DerInteger(this.PublicExponent),
				new global::Org.BouncyCastle.Asn1.DerInteger(this.PrivateExponent),
				new global::Org.BouncyCastle.Asn1.DerInteger(this.Prime1),
				new global::Org.BouncyCastle.Asn1.DerInteger(this.Prime2),
				new global::Org.BouncyCastle.Asn1.DerInteger(this.Exponent1),
				new global::Org.BouncyCastle.Asn1.DerInteger(this.Exponent2),
				new global::Org.BouncyCastle.Asn1.DerInteger(this.Coefficient)
			});
		}

		// Token: 0x04001D27 RID: 7463
		private readonly global::Org.BouncyCastle.Math.BigInteger modulus;

		// Token: 0x04001D28 RID: 7464
		private readonly global::Org.BouncyCastle.Math.BigInteger publicExponent;

		// Token: 0x04001D29 RID: 7465
		private readonly global::Org.BouncyCastle.Math.BigInteger privateExponent;

		// Token: 0x04001D2A RID: 7466
		private readonly global::Org.BouncyCastle.Math.BigInteger prime1;

		// Token: 0x04001D2B RID: 7467
		private readonly global::Org.BouncyCastle.Math.BigInteger prime2;

		// Token: 0x04001D2C RID: 7468
		private readonly global::Org.BouncyCastle.Math.BigInteger exponent1;

		// Token: 0x04001D2D RID: 7469
		private readonly global::Org.BouncyCastle.Math.BigInteger exponent2;

		// Token: 0x04001D2E RID: 7470
		private readonly global::Org.BouncyCastle.Math.BigInteger coefficient;
	}
}
