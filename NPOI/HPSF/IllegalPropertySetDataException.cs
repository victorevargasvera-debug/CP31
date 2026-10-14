using System;

namespace NPOI.HPSF
{
	// Token: 0x0200050D RID: 1293
	[global::System.Serializable]
	public class IllegalPropertySetDataException : global::NPOI.HPSF.HPSFRuntimeException
	{
		// Token: 0x06003072 RID: 12402 RVA: 0x0009255F File Offset: 0x0009075F
		public IllegalPropertySetDataException()
		{
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x00092567 File Offset: 0x00090767
		public IllegalPropertySetDataException(string msg) : base(msg)
		{
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x00092570 File Offset: 0x00090770
		public IllegalPropertySetDataException(global::System.Exception reason) : base(reason)
		{
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x00092579 File Offset: 0x00090779
		public IllegalPropertySetDataException(string msg, global::System.Exception reason) : base(msg, reason)
		{
		}
	}
}
