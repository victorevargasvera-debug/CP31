using System;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000354 RID: 852
	internal class Timeout
	{
		// Token: 0x060022E2 RID: 8930 RVA: 0x00098F35 File Offset: 0x00097135
		internal Timeout(long durationMillis) : this(durationMillis, global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs())
		{
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00098F43 File Offset: 0x00097143
		internal Timeout(long durationMillis, long currentTimeMillis)
		{
			this.durationMillis = global::System.Math.Max(0L, durationMillis);
			this.startMillis = global::System.Math.Max(0L, currentTimeMillis);
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x00098F68 File Offset: 0x00097168
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

		// Token: 0x060022E5 RID: 8933 RVA: 0x00098FE4 File Offset: 0x000971E4
		internal static int ConstrainWaitMillis(int waitMillis, global::Org.BouncyCastle.Crypto.Tls.Timeout timeout, long currentTimeMillis)
		{
			if (waitMillis < 0)
			{
				return -1;
			}
			int timeoutMillis = global::Org.BouncyCastle.Crypto.Tls.Timeout.GetWaitMillis(timeout, currentTimeMillis);
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

		// Token: 0x060022E6 RID: 8934 RVA: 0x00099016 File Offset: 0x00097216
		internal static global::Org.BouncyCastle.Crypto.Tls.Timeout ForWaitMillis(int waitMillis)
		{
			return global::Org.BouncyCastle.Crypto.Tls.Timeout.ForWaitMillis(waitMillis, global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs());
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x00099023 File Offset: 0x00097223
		internal static global::Org.BouncyCastle.Crypto.Tls.Timeout ForWaitMillis(int waitMillis, long currentTimeMillis)
		{
			if (waitMillis < 0)
			{
				throw new global::System.ArgumentException("cannot be negative", "waitMillis");
			}
			if (waitMillis > 0)
			{
				return new global::Org.BouncyCastle.Crypto.Tls.Timeout((long)waitMillis, currentTimeMillis);
			}
			return null;
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x00099048 File Offset: 0x00097248
		internal static int GetWaitMillis(global::Org.BouncyCastle.Crypto.Tls.Timeout timeout, long currentTimeMillis)
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

		// Token: 0x060022E9 RID: 8937 RVA: 0x0009907A File Offset: 0x0009727A
		internal static bool HasExpired(global::Org.BouncyCastle.Crypto.Tls.Timeout timeout, long currentTimeMillis)
		{
			return timeout != null && timeout.RemainingMillis(currentTimeMillis) < 1L;
		}

		// Token: 0x04000E2E RID: 3630
		private long durationMillis;

		// Token: 0x04000E2F RID: 3631
		private long startMillis;
	}
}
