using System;

namespace NPOI.HPSF
{
	// Token: 0x0200050F RID: 1295
	[global::System.Serializable]
	public class MarkUnsupportedException : global::NPOI.HPSF.HPSFException
	{
		// Token: 0x06003078 RID: 12408 RVA: 0x000925EC File Offset: 0x000907EC
		public MarkUnsupportedException()
		{
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x000925F4 File Offset: 0x000907F4
		public MarkUnsupportedException(string msg) : base(msg)
		{
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x000925FD File Offset: 0x000907FD
		public MarkUnsupportedException(global::System.Exception reason) : base(reason)
		{
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x00092606 File Offset: 0x00090806
		public MarkUnsupportedException(string msg, global::System.Exception reason) : base(msg, reason)
		{
		}
	}
}
