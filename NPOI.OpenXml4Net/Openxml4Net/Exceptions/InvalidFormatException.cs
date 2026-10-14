using System;

namespace NPOI.OpenXml4Net.Exceptions
{
	// Token: 0x02000030 RID: 48
	public class InvalidFormatException : global::NPOI.OpenXml4Net.OpenXml4NetException
	{
		// Token: 0x06000214 RID: 532 RVA: 0x0000A0CE File Offset: 0x000082CE
		public InvalidFormatException(string message) : base(message)
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000A0D7 File Offset: 0x000082D7
		public InvalidFormatException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x040000F8 RID: 248
		private string p;

		// Token: 0x040000F9 RID: 249
		private global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex;
	}
}
