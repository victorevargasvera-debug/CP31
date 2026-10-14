using System;

namespace NLog.Common
{
	// Token: 0x0200018D RID: 397
	public struct AsyncLogEventInfo
	{
		// Token: 0x060010DB RID: 4315 RVA: 0x0002CDE8 File Offset: 0x0002AFE8
		public AsyncLogEventInfo(global::NLog.LogEventInfo logEvent, global::NLog.Common.AsyncContinuation continuation)
		{
			this.LogEvent = logEvent;
			this.Continuation = continuation;
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x0002CDF8 File Offset: 0x0002AFF8
		public global::NLog.LogEventInfo LogEvent { get; }

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x0002CE00 File Offset: 0x0002B000
		public global::NLog.Common.AsyncContinuation Continuation { get; }

		// Token: 0x060010DE RID: 4318 RVA: 0x0002CE08 File Offset: 0x0002B008
		public static bool operator ==(global::NLog.Common.AsyncLogEventInfo eventInfo1, global::NLog.Common.AsyncLogEventInfo eventInfo2)
		{
			return eventInfo1.Continuation == eventInfo2.Continuation && eventInfo1.LogEvent == eventInfo2.LogEvent;
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0002CE2C File Offset: 0x0002B02C
		public static bool operator !=(global::NLog.Common.AsyncLogEventInfo eventInfo1, global::NLog.Common.AsyncLogEventInfo eventInfo2)
		{
			return eventInfo1.Continuation != eventInfo2.Continuation || eventInfo1.LogEvent != eventInfo2.LogEvent;
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0002CE54 File Offset: 0x0002B054
		public override bool Equals(object obj)
		{
			global::NLog.Common.AsyncLogEventInfo eventInfo = (global::NLog.Common.AsyncLogEventInfo)obj;
			return this == eventInfo;
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0002CE74 File Offset: 0x0002B074
		public override int GetHashCode()
		{
			return this.LogEvent.GetHashCode() ^ this.Continuation.GetHashCode();
		}
	}
}
