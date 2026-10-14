using System;

namespace NPOI.HPSF
{
	// Token: 0x02000514 RID: 1300
	[global::System.Serializable]
	public class NoFormatIDException : global::NPOI.HPSF.HPSFRuntimeException
	{
		// Token: 0x060030AD RID: 12461 RVA: 0x0009255F File Offset: 0x0009075F
		public NoFormatIDException()
		{
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x00092567 File Offset: 0x00090767
		public NoFormatIDException(string msg) : base(msg)
		{
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x00092570 File Offset: 0x00090770
		public NoFormatIDException(global::System.Exception reason) : base(reason)
		{
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x00092579 File Offset: 0x00090779
		public NoFormatIDException(string msg, global::System.Exception reason) : base(msg, reason)
		{
		}
	}
}
