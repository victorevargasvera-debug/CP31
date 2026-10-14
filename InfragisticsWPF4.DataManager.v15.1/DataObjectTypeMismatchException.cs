using System;

namespace Infragistics
{
	// Token: 0x0200002B RID: 43
	public class DataObjectTypeMismatchException : global::System.Exception
	{
		// Token: 0x0600022C RID: 556 RVA: 0x0000D31F File Offset: 0x0000B51F
		public DataObjectTypeMismatchException() : base(global::SR.GetString("DataObjectTypeMismatchException"))
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000D331 File Offset: 0x0000B531
		public DataObjectTypeMismatchException(string message) : base(message)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000D33A File Offset: 0x0000B53A
		public DataObjectTypeMismatchException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
