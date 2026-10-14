using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000589 RID: 1417
	public class RsaSecretBcpgKey : global::Org.BouncyCastle.Bcpg.BcpgObject, global::Org.BouncyCastle.Bcpg.IBcpgKey
	{
		// Token: 0x0600359B RID: 13723 RVA: 0x000FEA34 File Offset: 0x000FCC34
		public RsaSecretBcpgKey(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.d = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
			this.p = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
			this.q = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
			this.u = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
			this.expP = this.d.Value.Remainder(this.p.Value.Subtract(global::Org.BouncyCastle.Math.BigInteger.One));
			this.expQ = this.d.Value.Remainder(this.q.Value.Subtract(global::Org.BouncyCastle.Math.BigInteger.One));
			this.crt = global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverse(this.p.Value, this.q.Value);
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x000FEAF0 File Offset: 0x000FCCF0
		public RsaSecretBcpgKey(global::Org.BouncyCastle.Math.BigInteger d, global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q)
		{
			int cmp = p.CompareTo(q);
			if (cmp >= 0)
			{
				if (cmp == 0)
				{
					throw new global::System.ArgumentException("p and q cannot be equal");
				}
				global::Org.BouncyCastle.Math.BigInteger bigInteger = p;
				p = q;
				q = bigInteger;
			}
			this.d = new global::Org.BouncyCastle.Bcpg.MPInteger(d);
			this.p = new global::Org.BouncyCastle.Bcpg.MPInteger(p);
			this.q = new global::Org.BouncyCastle.Bcpg.MPInteger(q);
			this.u = new global::Org.BouncyCastle.Bcpg.MPInteger(global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverse(q, p));
			this.expP = d.Remainder(p.Subtract(global::Org.BouncyCastle.Math.BigInteger.One));
			this.expQ = d.Remainder(q.Subtract(global::Org.BouncyCastle.Math.BigInteger.One));
			this.crt = global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverse(p, q);
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600359D RID: 13725 RVA: 0x000FEB94 File Offset: 0x000FCD94
		public global::Org.BouncyCastle.Math.BigInteger Modulus
		{
			get
			{
				return this.p.Value.Multiply(this.q.Value);
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x000FEBB1 File Offset: 0x000FCDB1
		public global::Org.BouncyCastle.Math.BigInteger PrivateExponent
		{
			get
			{
				return this.d.Value;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600359F RID: 13727 RVA: 0x000FEBBE File Offset: 0x000FCDBE
		public global::Org.BouncyCastle.Math.BigInteger PrimeP
		{
			get
			{
				return this.p.Value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060035A0 RID: 13728 RVA: 0x000FEBCB File Offset: 0x000FCDCB
		public global::Org.BouncyCastle.Math.BigInteger PrimeQ
		{
			get
			{
				return this.q.Value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060035A1 RID: 13729 RVA: 0x000FEBD8 File Offset: 0x000FCDD8
		public global::Org.BouncyCastle.Math.BigInteger PrimeExponentP
		{
			get
			{
				return this.expP;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060035A2 RID: 13730 RVA: 0x000FEBE0 File Offset: 0x000FCDE0
		public global::Org.BouncyCastle.Math.BigInteger PrimeExponentQ
		{
			get
			{
				return this.expQ;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060035A3 RID: 13731 RVA: 0x000FEBE8 File Offset: 0x000FCDE8
		public global::Org.BouncyCastle.Math.BigInteger CrtCoefficient
		{
			get
			{
				return this.crt;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x000FEBF0 File Offset: 0x000FCDF0
		public string Format
		{
			get
			{
				return "PGP";
			}
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x000FEBF8 File Offset: 0x000FCDF8
		public override byte[] GetEncoded()
		{
			byte[] result;
			try
			{
				result = base.GetEncoded();
			}
			catch (global::System.Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x000FEC24 File Offset: 0x000FCE24
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WriteObjects(new global::Org.BouncyCastle.Bcpg.BcpgObject[]
			{
				this.d,
				this.p,
				this.q,
				this.u
			});
		}

		// Token: 0x04001832 RID: 6194
		private readonly global::Org.BouncyCastle.Bcpg.MPInteger d;

		// Token: 0x04001833 RID: 6195
		private readonly global::Org.BouncyCastle.Bcpg.MPInteger p;

		// Token: 0x04001834 RID: 6196
		private readonly global::Org.BouncyCastle.Bcpg.MPInteger q;

		// Token: 0x04001835 RID: 6197
		private readonly global::Org.BouncyCastle.Bcpg.MPInteger u;

		// Token: 0x04001836 RID: 6198
		private readonly global::Org.BouncyCastle.Math.BigInteger expP;

		// Token: 0x04001837 RID: 6199
		private readonly global::Org.BouncyCastle.Math.BigInteger expQ;

		// Token: 0x04001838 RID: 6200
		private readonly global::Org.BouncyCastle.Math.BigInteger crt;
	}
}
