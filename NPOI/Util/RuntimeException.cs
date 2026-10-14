using System;

namespace NPOI.Util
{
	// Token: 0x0200028D RID: 653
	[global::System.Serializable]
	public class RuntimeException : global::System.Exception
	{
		// Token: 0x060011BD RID: 4541 RVA: 0x00035487 File Offset: 0x00033687
		public RuntimeException()
		{
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0000E5BB File Offset: 0x0000C7BB
		public RuntimeException(string message) : base(message)
		{
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0003548F File Offset: 0x0003368F
		public RuntimeException(global::System.Exception e) : base("", e)
		{
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0003549D File Offset: 0x0003369D
		public RuntimeException(string exception, global::System.Exception ex) : base(exception, ex)
		{
		}
	}
}
