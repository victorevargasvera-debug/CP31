using System;

namespace CefSharp
{
	// Token: 0x0200008B RID: 139
	public class JavascriptStackFrame
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000373F File Offset: 0x0000193F
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00003747 File Offset: 0x00001947
		public string FunctionName { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00003750 File Offset: 0x00001950
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00003758 File Offset: 0x00001958
		public int LineNumber { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00003761 File Offset: 0x00001961
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00003769 File Offset: 0x00001969
		public int ColumnNumber { get; set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00003772 File Offset: 0x00001972
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x0000377A File Offset: 0x0000197A
		public string SourceName { get; set; }
	}
}
