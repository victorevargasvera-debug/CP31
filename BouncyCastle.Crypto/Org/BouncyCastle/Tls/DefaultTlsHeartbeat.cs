using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000B0 RID: 176
	public class DefaultTlsHeartbeat : global::Org.BouncyCastle.Tls.TlsHeartbeat
	{
		// Token: 0x060006A6 RID: 1702 RVA: 0x0001B53C File Offset: 0x0001973C
		public DefaultTlsHeartbeat(int idleMillis, int timeoutMillis)
		{
			if (idleMillis <= 0)
			{
				throw new global::System.ArgumentException("must be > 0", "idleMillis");
			}
			if (timeoutMillis <= 0)
			{
				throw new global::System.ArgumentException("must be > 0", "timeoutMillis");
			}
			this.idleMillis = idleMillis;
			this.timeoutMillis = timeoutMillis;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0001B57C File Offset: 0x0001977C
		public virtual byte[] GeneratePayload()
		{
			byte[] result;
			lock (this)
			{
				uint n = this.counter + 1U;
				this.counter = n;
				result = global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n);
			}
			return result;
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0001B5CC File Offset: 0x000197CC
		public virtual int IdleMillis
		{
			get
			{
				return this.idleMillis;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0001B5D4 File Offset: 0x000197D4
		public virtual int TimeoutMillis
		{
			get
			{
				return this.timeoutMillis;
			}
		}

		// Token: 0x040004CE RID: 1230
		private readonly int idleMillis;

		// Token: 0x040004CF RID: 1231
		private readonly int timeoutMillis;

		// Token: 0x040004D0 RID: 1232
		private uint counter;
	}
}
