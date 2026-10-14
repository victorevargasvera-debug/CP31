using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x0200050C RID: 1292
	[global::System.Serializable]
	public class HPSFRuntimeException : global::NPOI.Util.RuntimeException
	{
		// Token: 0x0600306E RID: 12398 RVA: 0x00092548 File Offset: 0x00090748
		public HPSFRuntimeException()
		{
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x00034F50 File Offset: 0x00033150
		public HPSFRuntimeException(string msg) : base(msg)
		{
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x00092550 File Offset: 0x00090750
		public HPSFRuntimeException(global::System.Exception reason) : base(reason.Message, reason)
		{
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x00034F59 File Offset: 0x00033159
		public HPSFRuntimeException(string msg, global::System.Exception reason) : base(msg, reason)
		{
		}
	}
}
