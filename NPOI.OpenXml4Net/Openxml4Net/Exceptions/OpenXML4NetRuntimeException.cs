using System;
using NPOI.Util;

namespace NPOI.OpenXml4Net.Exceptions
{
	// Token: 0x02000031 RID: 49
	public class OpenXML4NetRuntimeException : global::NPOI.Util.RuntimeException
	{
		// Token: 0x06000216 RID: 534 RVA: 0x0000A0E1 File Offset: 0x000082E1
		public OpenXML4NetRuntimeException(string msg) : base(msg)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000A0EA File Offset: 0x000082EA
		public OpenXML4NetRuntimeException(string msg, global::System.Exception reason) : base(msg, reason)
		{
		}
	}
}
