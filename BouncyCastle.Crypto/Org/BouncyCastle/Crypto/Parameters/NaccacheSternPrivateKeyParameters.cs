using System;
using System.Collections;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003FD RID: 1021
	public class NaccacheSternPrivateKeyParameters : global::Org.BouncyCastle.Crypto.Parameters.NaccacheSternKeyParameters
	{
		// Token: 0x0600284D RID: 10317 RVA: 0x000AC882 File Offset: 0x000AAA82
		[global::System.Obsolete]
		public NaccacheSternPrivateKeyParameters(global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger n, int lowerSigmaBound, global::System.Collections.ArrayList smallPrimes, global::Org.BouncyCastle.Math.BigInteger phiN) : base(true, g, n, lowerSigmaBound)
		{
			this.smallPrimes = smallPrimes;
			this.phiN = phiN;
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x000AC89E File Offset: 0x000AAA9E
		public NaccacheSternPrivateKeyParameters(global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger n, int lowerSigmaBound, global::System.Collections.IList smallPrimes, global::Org.BouncyCastle.Math.BigInteger phiN) : base(true, g, n, lowerSigmaBound)
		{
			this.smallPrimes = smallPrimes;
			this.phiN = phiN;
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x000AC8BA File Offset: 0x000AAABA
		public global::Org.BouncyCastle.Math.BigInteger PhiN
		{
			get
			{
				return this.phiN;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x000AC8C2 File Offset: 0x000AAAC2
		[global::System.Obsolete("Use 'SmallPrimesList' instead")]
		public global::System.Collections.ArrayList SmallPrimes
		{
			get
			{
				return new global::System.Collections.ArrayList(this.smallPrimes);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x000AC8CF File Offset: 0x000AAACF
		public global::System.Collections.IList SmallPrimesList
		{
			get
			{
				return this.smallPrimes;
			}
		}

		// Token: 0x0400105A RID: 4186
		private readonly global::Org.BouncyCastle.Math.BigInteger phiN;

		// Token: 0x0400105B RID: 4187
		private readonly global::System.Collections.IList smallPrimes;
	}
}
