using System;

namespace CefSharp
{
	// Token: 0x02000088 RID: 136
	public class JavascriptException
	{
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600039D RID: 925 RVA: 0x000036D2 File Offset: 0x000018D2
		// (set) Token: 0x0600039E RID: 926 RVA: 0x000036DA File Offset: 0x000018DA
		public string Message { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600039F RID: 927 RVA: 0x000036E3 File Offset: 0x000018E3
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x000036EB File Offset: 0x000018EB
		public global::CefSharp.JavascriptStackFrame[] StackTrace { get; set; }
	}
}
