using System;
using NPOI.OpenXml4Net.Exceptions;

namespace NPOI.OpenXml4Net
{
	// Token: 0x02000007 RID: 7
	public class OpenXml4NetException : global::System.Exception
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000021E5 File Offset: 0x000003E5
		public OpenXml4NetException(string msg) : base(msg)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000021EE File Offset: 0x000003EE
		public OpenXml4NetException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0400000C RID: 12
		private global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex;
	}
}
