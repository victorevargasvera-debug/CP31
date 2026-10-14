using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Agreement.JPake
{
	// Token: 0x02000501 RID: 1281
	public class JPakePrimeOrderGroup
	{
		// Token: 0x0600322C RID: 12844 RVA: 0x000F138B File Offset: 0x000EF58B
		public JPakePrimeOrderGroup(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger g) : this(p, q, g, false)
		{
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x000F1398 File Offset: 0x000EF598
		public JPakePrimeOrderGroup(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger g, bool skipChecks)
		{
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(p, "p");
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(q, "q");
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(g, "g");
			if (!skipChecks)
			{
				if (!p.Subtract(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.One).Mod(q).Equals(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.Zero))
				{
					throw new global::System.ArgumentException("p-1 must be evenly divisible by q");
				}
				if (g.CompareTo(global::Org.BouncyCastle.Math.BigInteger.Two) == -1 || g.CompareTo(p.Subtract(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.One)) == 1)
				{
					throw new global::System.ArgumentException("g must be in [2, p-1]");
				}
				if (!g.ModPow(q, p).Equals(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.One))
				{
					throw new global::System.ArgumentException("g^q mod p must equal 1");
				}
				if (!p.IsProbablePrime(20))
				{
					throw new global::System.ArgumentException("p must be prime");
				}
				if (!q.IsProbablePrime(20))
				{
					throw new global::System.ArgumentException("q must be prime");
				}
			}
			this.p = p;
			this.q = q;
			this.g = g;
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x0600322E RID: 12846 RVA: 0x000F1486 File Offset: 0x000EF686
		public virtual global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600322F RID: 12847 RVA: 0x000F148E File Offset: 0x000EF68E
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return this.q;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06003230 RID: 12848 RVA: 0x000F1496 File Offset: 0x000EF696
		public virtual global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.g;
			}
		}

		// Token: 0x0400164F RID: 5711
		private readonly global::Org.BouncyCastle.Math.BigInteger p;

		// Token: 0x04001650 RID: 5712
		private readonly global::Org.BouncyCastle.Math.BigInteger q;

		// Token: 0x04001651 RID: 5713
		private readonly global::Org.BouncyCastle.Math.BigInteger g;
	}
}
