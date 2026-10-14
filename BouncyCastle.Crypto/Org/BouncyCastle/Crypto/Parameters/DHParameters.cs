using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003CB RID: 971
	public class DHParameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x0600271A RID: 10010 RVA: 0x000AA33F File Offset: 0x000A853F
		private static int GetDefaultMParam(int lParam)
		{
			if (lParam == 0)
			{
				return 160;
			}
			return global::System.Math.Min(lParam, 160);
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000AA355 File Offset: 0x000A8555
		public DHParameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g) : this(p, g, null, 0)
		{
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x000AA361 File Offset: 0x000A8561
		public DHParameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger q) : this(p, g, q, 0)
		{
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000AA36D File Offset: 0x000A856D
		public DHParameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger q, int l) : this(p, g, q, global::Org.BouncyCastle.Crypto.Parameters.DHParameters.GetDefaultMParam(l), l, null, null)
		{
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x000AA383 File Offset: 0x000A8583
		public DHParameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger q, int m, int l) : this(p, g, q, m, l, null, null)
		{
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x000AA394 File Offset: 0x000A8594
		public DHParameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger j, global::Org.BouncyCastle.Crypto.Parameters.DHValidationParameters validation) : this(p, g, q, 160, 0, j, validation)
		{
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000AA3AC File Offset: 0x000A85AC
		public DHParameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger q, int m, int l, global::Org.BouncyCastle.Math.BigInteger j, global::Org.BouncyCastle.Crypto.Parameters.DHValidationParameters validation)
		{
			if (p == null)
			{
				throw new global::System.ArgumentNullException("p");
			}
			if (g == null)
			{
				throw new global::System.ArgumentNullException("g");
			}
			if (!p.TestBit(0))
			{
				throw new global::System.ArgumentException("field must be an odd prime", "p");
			}
			if (g.CompareTo(global::Org.BouncyCastle.Math.BigInteger.Two) < 0 || g.CompareTo(p.Subtract(global::Org.BouncyCastle.Math.BigInteger.Two)) > 0)
			{
				throw new global::System.ArgumentException("generator must in the range [2, p - 2]", "g");
			}
			if (q != null && q.BitLength >= p.BitLength)
			{
				throw new global::System.ArgumentException("q too big to be a factor of (p-1)", "q");
			}
			if (m >= p.BitLength)
			{
				throw new global::System.ArgumentException("m value must be < bitlength of p", "m");
			}
			if (l != 0)
			{
				if (l >= p.BitLength)
				{
					throw new global::System.ArgumentException("when l value specified, it must be less than bitlength(p)", "l");
				}
				if (l < m)
				{
					throw new global::System.ArgumentException("when l value specified, it may not be less than m value", "l");
				}
			}
			if (j != null && j.CompareTo(global::Org.BouncyCastle.Math.BigInteger.Two) < 0)
			{
				throw new global::System.ArgumentException("subgroup factor must be >= 2", "j");
			}
			this.p = p;
			this.g = g;
			this.q = q;
			this.m = m;
			this.l = l;
			this.j = j;
			this.validation = validation;
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06002721 RID: 10017 RVA: 0x000AA4ED File Offset: 0x000A86ED
		public global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x000AA4F5 File Offset: 0x000A86F5
		public global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.g;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06002723 RID: 10019 RVA: 0x000AA4FD File Offset: 0x000A86FD
		public global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return this.q;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x000AA505 File Offset: 0x000A8705
		public global::Org.BouncyCastle.Math.BigInteger J
		{
			get
			{
				return this.j;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06002725 RID: 10021 RVA: 0x000AA50D File Offset: 0x000A870D
		public int M
		{
			get
			{
				return this.m;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x000AA515 File Offset: 0x000A8715
		public int L
		{
			get
			{
				return this.l;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x000AA51D File Offset: 0x000A871D
		public global::Org.BouncyCastle.Crypto.Parameters.DHValidationParameters ValidationParameters
		{
			get
			{
				return this.validation;
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x000AA528 File Offset: 0x000A8728
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.DHParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.DHParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x000AA54E File Offset: 0x000A874E
		protected virtual bool Equals(global::Org.BouncyCastle.Crypto.Parameters.DHParameters other)
		{
			return this.p.Equals(other.p) && this.g.Equals(other.g) && object.Equals(this.q, other.q);
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x000AA58C File Offset: 0x000A878C
		public override int GetHashCode()
		{
			int hc = this.p.GetHashCode() ^ this.g.GetHashCode();
			if (this.q != null)
			{
				hc ^= this.q.GetHashCode();
			}
			return hc;
		}

		// Token: 0x04000FDF RID: 4063
		private const int DefaultMinimumLength = 160;

		// Token: 0x04000FE0 RID: 4064
		private readonly global::Org.BouncyCastle.Math.BigInteger p;

		// Token: 0x04000FE1 RID: 4065
		private readonly global::Org.BouncyCastle.Math.BigInteger g;

		// Token: 0x04000FE2 RID: 4066
		private readonly global::Org.BouncyCastle.Math.BigInteger q;

		// Token: 0x04000FE3 RID: 4067
		private readonly global::Org.BouncyCastle.Math.BigInteger j;

		// Token: 0x04000FE4 RID: 4068
		private readonly int m;

		// Token: 0x04000FE5 RID: 4069
		private readonly int l;

		// Token: 0x04000FE6 RID: 4070
		private readonly global::Org.BouncyCastle.Crypto.Parameters.DHValidationParameters validation;
	}
}
