using System;

namespace NPOI.HPSF
{
	// Token: 0x02000510 RID: 1296
	[global::System.Serializable]
	public class MissingSectionException : global::NPOI.HPSF.HPSFRuntimeException
	{
		// Token: 0x0600307C RID: 12412 RVA: 0x0009255F File Offset: 0x0009075F
		public MissingSectionException()
		{
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x00092567 File Offset: 0x00090767
		public MissingSectionException(string msg) : base(msg)
		{
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x00092570 File Offset: 0x00090770
		public MissingSectionException(global::System.Exception reason) : base(reason)
		{
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x00092579 File Offset: 0x00090779
		public MissingSectionException(string msg, global::System.Exception reason) : base(msg, reason)
		{
		}
	}
}
