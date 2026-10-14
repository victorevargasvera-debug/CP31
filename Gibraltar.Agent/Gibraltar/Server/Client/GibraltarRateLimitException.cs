using System;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000121 RID: 289
	[global::System.Serializable]
	internal class GibraltarRateLimitException : global::Gibraltar.GibraltarException
	{
		// Token: 0x06000BCE RID: 3022 RVA: 0x0001DE24 File Offset: 0x0001C024
		public GibraltarRateLimitException(string message, global::System.TimeSpan? delay) : base(message)
		{
			this.Timestamp = global::System.DateTimeOffset.Now;
			this.Delay = delay;
			if (delay != null)
			{
				this.RetryAfter = this.Timestamp.Add(delay.Value);
				return;
			}
			this.RetryAfter = this.Timestamp.AddSeconds(1.0);
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0001DE94 File Offset: 0x0001C094
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x0001DE9C File Offset: 0x0001C09C
		public global::System.DateTimeOffset Timestamp { get; private set; }

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0001DEA8 File Offset: 0x0001C0A8
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x0001DEB0 File Offset: 0x0001C0B0
		public global::System.DateTimeOffset RetryAfter { get; private set; }

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0001DEBC File Offset: 0x0001C0BC
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x0001DEC4 File Offset: 0x0001C0C4
		public global::System.TimeSpan? Delay { get; private set; }
	}
}
