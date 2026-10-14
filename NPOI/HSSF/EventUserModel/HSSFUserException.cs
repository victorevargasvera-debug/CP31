using System;

namespace NPOI.HSSF.EventUserModel
{
	// Token: 0x0200034C RID: 844
	[global::System.Serializable]
	public class HSSFUserException : global::System.Exception
	{
		// Token: 0x06001929 RID: 6441 RVA: 0x00035487 File Offset: 0x00033687
		public HSSFUserException()
		{
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x0000E5BB File Offset: 0x0000C7BB
		public HSSFUserException(string msg) : base(msg)
		{
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00035487 File Offset: 0x00033687
		public HSSFUserException(global::System.Exception reason)
		{
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0003549D File Offset: 0x0003369D
		public HSSFUserException(string msg, global::System.Exception reason) : base(msg, reason)
		{
		}
	}
}
