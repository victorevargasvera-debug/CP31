using System;

namespace Infragistics
{
	// Token: 0x0200002C RID: 44
	public class RequireEmptyConstructorException : global::System.Exception
	{
		// Token: 0x0600022F RID: 559 RVA: 0x0000D344 File Offset: 0x0000B544
		public RequireEmptyConstructorException() : base(global::SR.GetString("RequireEmptyConstructorException"))
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000D356 File Offset: 0x0000B556
		public RequireEmptyConstructorException(string message) : base(message)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000D35F File Offset: 0x0000B55F
		public RequireEmptyConstructorException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
