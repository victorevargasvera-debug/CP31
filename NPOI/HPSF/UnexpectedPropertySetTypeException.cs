using System;

namespace NPOI.HPSF
{
	// Token: 0x02000520 RID: 1312
	[global::System.Serializable]
	public class UnexpectedPropertySetTypeException : global::NPOI.HPSF.HPSFException
	{
		// Token: 0x06003169 RID: 12649 RVA: 0x000925EC File Offset: 0x000907EC
		public UnexpectedPropertySetTypeException()
		{
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x000925F4 File Offset: 0x000907F4
		public UnexpectedPropertySetTypeException(string msg) : base(msg)
		{
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x000925FD File Offset: 0x000907FD
		public UnexpectedPropertySetTypeException(global::System.Exception reason) : base(reason)
		{
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x00092606 File Offset: 0x00090806
		public UnexpectedPropertySetTypeException(string msg, global::System.Exception reason) : base(msg, reason)
		{
		}
	}
}
