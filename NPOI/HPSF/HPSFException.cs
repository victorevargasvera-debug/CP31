using System;

namespace NPOI.HPSF
{
	// Token: 0x0200050B RID: 1291
	[global::System.Serializable]
	public class HPSFException : global::System.Exception
	{
		// Token: 0x06003069 RID: 12393 RVA: 0x00035487 File Offset: 0x00033687
		public HPSFException()
		{
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x0000E5BB File Offset: 0x0000C7BB
		public HPSFException(string msg) : base(msg)
		{
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x0003548F File Offset: 0x0003368F
		public HPSFException(global::System.Exception reason) : base("", reason)
		{
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x0003549D File Offset: 0x0003369D
		public HPSFException(string msg, global::System.Exception reason) : base(msg, reason)
		{
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x0600306D RID: 12397 RVA: 0x00092540 File Offset: 0x00090740
		public global::System.Exception Reason
		{
			get
			{
				return base.InnerException;
			}
		}
	}
}
