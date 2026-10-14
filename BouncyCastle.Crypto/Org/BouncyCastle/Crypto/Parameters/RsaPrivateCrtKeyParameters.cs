using System;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x02000408 RID: 1032
	public class RsaPrivateCrtKeyParameters : global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters
	{
		// Token: 0x0600287C RID: 10364 RVA: 0x000ACD0C File Offset: 0x000AAF0C
		public RsaPrivateCrtKeyParameters(global::Org.BouncyCastle.Math.BigInteger modulus, global::Org.BouncyCastle.Math.BigInteger publicExponent, global::Org.BouncyCastle.Math.BigInteger privateExponent, global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger dP, global::Org.BouncyCastle.Math.BigInteger dQ, global::Org.BouncyCastle.Math.BigInteger qInv) : base(true, modulus, privateExponent)
		{
			global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.ValidateValue(publicExponent, "publicExponent", "exponent");
			global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.ValidateValue(p, "p", "P value");
			global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.ValidateValue(q, "q", "Q value");
			global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.ValidateValue(dP, "dP", "DP value");
			global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.ValidateValue(dQ, "dQ", "DQ value");
			global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.ValidateValue(qInv, "qInv", "InverseQ value");
			this.e = publicExponent;
			this.p = p;
			this.q = q;
			this.dP = dP;
			this.dQ = dQ;
			this.qInv = qInv;
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x000ACDB8 File Offset: 0x000AAFB8
		public RsaPrivateCrtKeyParameters(global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure rsaPrivateKey) : this(rsaPrivateKey.Modulus, rsaPrivateKey.PublicExponent, rsaPrivateKey.PrivateExponent, rsaPrivateKey.Prime1, rsaPrivateKey.Prime2, rsaPrivateKey.Exponent1, rsaPrivateKey.Exponent2, rsaPrivateKey.Coefficient)
		{
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x000ACDFB File Offset: 0x000AAFFB
		public global::Org.BouncyCastle.Math.BigInteger PublicExponent
		{
			get
			{
				return this.e;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600287F RID: 10367 RVA: 0x000ACE03 File Offset: 0x000AB003
		public global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x000ACE0B File Offset: 0x000AB00B
		public global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return this.q;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06002881 RID: 10369 RVA: 0x000ACE13 File Offset: 0x000AB013
		public global::Org.BouncyCastle.Math.BigInteger DP
		{
			get
			{
				return this.dP;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x000ACE1B File Offset: 0x000AB01B
		public global::Org.BouncyCastle.Math.BigInteger DQ
		{
			get
			{
				return this.dQ;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06002883 RID: 10371 RVA: 0x000ACE23 File Offset: 0x000AB023
		public global::Org.BouncyCastle.Math.BigInteger QInv
		{
			get
			{
				return this.qInv;
			}
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x000ACE2C File Offset: 0x000AB02C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters kp = obj as global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters;
			return kp != null && (kp.DP.Equals(this.dP) && kp.DQ.Equals(this.dQ) && kp.Exponent.Equals(base.Exponent) && kp.Modulus.Equals(base.Modulus) && kp.P.Equals(this.p) && kp.Q.Equals(this.q) && kp.PublicExponent.Equals(this.e)) && kp.QInv.Equals(this.qInv);
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x000ACEE8 File Offset: 0x000AB0E8
		public override int GetHashCode()
		{
			return this.DP.GetHashCode() ^ this.DQ.GetHashCode() ^ base.Exponent.GetHashCode() ^ base.Modulus.GetHashCode() ^ this.P.GetHashCode() ^ this.Q.GetHashCode() ^ this.PublicExponent.GetHashCode() ^ this.QInv.GetHashCode();
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x000ACF54 File Offset: 0x000AB154
		private static void ValidateValue(global::Org.BouncyCastle.Math.BigInteger x, string name, string desc)
		{
			if (x == null)
			{
				throw new global::System.ArgumentNullException(name);
			}
			if (x.SignValue <= 0)
			{
				throw new global::System.ArgumentException("Not a valid RSA " + desc, name);
			}
		}

		// Token: 0x0400106F RID: 4207
		private readonly global::Org.BouncyCastle.Math.BigInteger e;

		// Token: 0x04001070 RID: 4208
		private readonly global::Org.BouncyCastle.Math.BigInteger p;

		// Token: 0x04001071 RID: 4209
		private readonly global::Org.BouncyCastle.Math.BigInteger q;

		// Token: 0x04001072 RID: 4210
		private readonly global::Org.BouncyCastle.Math.BigInteger dP;

		// Token: 0x04001073 RID: 4211
		private readonly global::Org.BouncyCastle.Math.BigInteger dQ;

		// Token: 0x04001074 RID: 4212
		private readonly global::Org.BouncyCastle.Math.BigInteger qInv;
	}
}
