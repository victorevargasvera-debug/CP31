using System;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000F7 RID: 247
	internal class Timeout
	{
		// Token: 0x060008E2 RID: 2274 RVA: 0x00023AB7 File Offset: 0x00021CB7
		internal Timeout(long durationMillis) : this(durationMillis, global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs())
		{
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00023AC5 File Offset: 0x00021CC5
		internal Timeout(long durationMillis, long currentTimeMillis)
		{
			this.durationMillis = global::System.Math.Max(0L, durationMillis);
			this.startMillis = global::System.Math.Max(0L, currentTimeMillis);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00023AEC File Offset: 0x00021CEC
		internal long RemainingMillis(long currentTimeMillis)
		{
			long result;
			lock (this)
			{
				if (this.startMillis > currentTimeMillis)
				{
					this.startMillis = currentTimeMillis;
					result = this.durationMillis;
				}
				else
				{
					long elapsed = currentTimeMillis - this.startMillis;
					long remaining = this.durationMillis - elapsed;
					if (remaining <= 0L)
					{
						result = (this.durationMillis = 0L);
					}
					else
					{
						result = remaining;
					}
				}
			}
			return result;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00023B68 File Offset: 0x00021D68
		internal static int ConstrainWaitMillis(int waitMillis, global::Org.BouncyCastle.Tls.Timeout timeout, long currentTimeMillis)
		{
			if (waitMillis < 0)
			{
				return -1;
			}
			int timeoutMillis = global::Org.BouncyCastle.Tls.Timeout.GetWaitMillis(timeout, currentTimeMillis);
			if (timeoutMillis < 0)
			{
				return -1;
			}
			if (waitMillis == 0)
			{
				return timeoutMillis;
			}
			if (timeoutMillis == 0)
			{
				return waitMillis;
			}
			return global::System.Math.Min(waitMillis, timeoutMillis);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00023B9A File Offset: 0x00021D9A
		internal static global::Org.BouncyCastle.Tls.Timeout ForWaitMillis(int waitMillis)
		{
			return global::Org.BouncyCastle.Tls.Timeout.ForWaitMillis(waitMillis, global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs());
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00023BA7 File Offset: 0x00021DA7
		internal static global::Org.BouncyCastle.Tls.Timeout ForWaitMillis(int waitMillis, long currentTimeMillis)
		{
			if (waitMillis < 0)
			{
				throw new global::System.ArgumentException("cannot be negative", "waitMillis");
			}
			if (waitMillis > 0)
			{
				return new global::Org.BouncyCastle.Tls.Timeout((long)waitMillis, currentTimeMillis);
			}
			return null;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00023BCC File Offset: 0x00021DCC
		internal static int GetWaitMillis(global::Org.BouncyCastle.Tls.Timeout timeout, long currentTimeMillis)
		{
			if (timeout == null)
			{
				return 0;
			}
			long remainingMillis = timeout.RemainingMillis(currentTimeMillis);
			if (remainingMillis < 1L)
			{
				return -1;
			}
			if (remainingMillis > 2147483647L)
			{
				return int.MaxValue;
			}
			return (int)remainingMillis;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00023BFE File Offset: 0x00021DFE
		internal static bool HasExpired(global::Org.BouncyCastle.Tls.Timeout timeout)
		{
			return global::Org.BouncyCastle.Tls.Timeout.HasExpired(timeout, global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs());
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00023C0B File Offset: 0x00021E0B
		internal static bool HasExpired(global::Org.BouncyCastle.Tls.Timeout timeout, long currentTimeMillis)
		{
			return timeout != null && timeout.RemainingMillis(currentTimeMillis) < 1L;
		}

		// Token: 0x040006D6 RID: 1750
		private long durationMillis;

		// Token: 0x040006D7 RID: 1751
		private long startMillis;
	}
}
