using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003FB RID: 1019
	public class NaccacheSternKeyGenerationParameters : global::Org.BouncyCastle.Crypto.KeyGenerationParameters
	{
		// Token: 0x06002844 RID: 10308 RVA: 0x000AC7EF File Offset: 0x000AA9EF
		public NaccacheSternKeyGenerationParameters(global::Org.BouncyCastle.Security.SecureRandom random, int strength, int certainty, int countSmallPrimes) : base(random, strength)
		{
			if (countSmallPrimes % 2 == 1)
			{
				throw new global::System.ArgumentException("countSmallPrimes must be a multiple of 2");
			}
			if (countSmallPrimes < 30)
			{
				throw new global::System.ArgumentException("countSmallPrimes must be >= 30 for security reasons");
			}
			this.certainty = certainty;
			this.countSmallPrimes = countSmallPrimes;
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x000AC82B File Offset: 0x000AAA2B
		[global::System.Obsolete("Use version without 'debug' parameter")]
		public NaccacheSternKeyGenerationParameters(global::Org.BouncyCastle.Security.SecureRandom random, int strength, int certainty, int countSmallPrimes, bool debug) : this(random, strength, certainty, countSmallPrimes)
		{
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06002846 RID: 10310 RVA: 0x000AC838 File Offset: 0x000AAA38
		public int Certainty
		{
			get
			{
				return this.certainty;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06002847 RID: 10311 RVA: 0x000AC840 File Offset: 0x000AAA40
		public int CountSmallPrimes
		{
			get
			{
				return this.countSmallPrimes;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x000AC848 File Offset: 0x000AAA48
		[global::System.Obsolete("Remove: always false")]
		public bool IsDebug
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04001055 RID: 4181
		private readonly int certainty;

		// Token: 0x04001056 RID: 4182
		private readonly int countSmallPrimes;
	}
}
