using System;

namespace NPOI.HPSF
{
	// Token: 0x02000516 RID: 1302
	[global::System.Serializable]
	public class NoSingleSectionException : global::NPOI.HPSF.HPSFRuntimeException
	{
		// Token: 0x060030B5 RID: 12469 RVA: 0x0009255F File Offset: 0x0009075F
		public NoSingleSectionException()
		{
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x00092567 File Offset: 0x00090767
		public NoSingleSectionException(string msg) : base(msg)
		{
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x00092570 File Offset: 0x00090770
		public NoSingleSectionException(global::System.Exception reason) : base(reason)
		{
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x00092579 File Offset: 0x00090779
		public NoSingleSectionException(string msg, global::System.Exception reason) : base(msg, reason)
		{
		}
	}
}
