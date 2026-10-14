using System;

namespace CefSharp
{
	// Token: 0x02000048 RID: 72
	public class ConsoleMessageEventArgs : global::System.EventArgs
	{
		// Token: 0x060000DE RID: 222 RVA: 0x000030F5 File Offset: 0x000012F5
		public ConsoleMessageEventArgs(global::CefSharp.IBrowser browser, global::CefSharp.LogSeverity level, string message, string source, int line)
		{
			this.Browser = browser;
			this.Level = level;
			this.Message = message;
			this.Source = source;
			this.Line = line;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00003122 File Offset: 0x00001322
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000312A File Offset: 0x0000132A
		public global::CefSharp.IBrowser Browser { get; private set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00003133 File Offset: 0x00001333
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000313B File Offset: 0x0000133B
		public global::CefSharp.LogSeverity Level { get; private set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00003144 File Offset: 0x00001344
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000314C File Offset: 0x0000134C
		public string Message { get; private set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00003155 File Offset: 0x00001355
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000315D File Offset: 0x0000135D
		public string Source { get; private set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00003166 File Offset: 0x00001366
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x0000316E File Offset: 0x0000136E
		public int Line { get; private set; }
	}
}
