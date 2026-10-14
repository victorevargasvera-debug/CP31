using System;

namespace NPOI.HPSF
{
	// Token: 0x02000515 RID: 1301
	[global::System.Serializable]
	public class NoPropertySetStreamException : global::NPOI.HPSF.HPSFException
	{
		// Token: 0x060030B1 RID: 12465 RVA: 0x000925EC File Offset: 0x000907EC
		public NoPropertySetStreamException()
		{
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x000925F4 File Offset: 0x000907F4
		public NoPropertySetStreamException(string msg) : base(msg)
		{
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x000925FD File Offset: 0x000907FD
		public NoPropertySetStreamException(global::System.Exception reason) : base(reason)
		{
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x00092606 File Offset: 0x00090806
		public NoPropertySetStreamException(string msg, global::System.Exception reason) : base(msg, reason)
		{
		}
	}
}
