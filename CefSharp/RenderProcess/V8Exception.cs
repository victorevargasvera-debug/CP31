using System;

namespace CefSharp.RenderProcess
{
	// Token: 0x020000B9 RID: 185
	public class V8Exception
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00008BD5 File Offset: 0x00006DD5
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00008BDD File Offset: 0x00006DDD
		public int EndColumn { get; private set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00008BE6 File Offset: 0x00006DE6
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00008BEE File Offset: 0x00006DEE
		public int EndPosition { get; private set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00008BF7 File Offset: 0x00006DF7
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00008BFF File Offset: 0x00006DFF
		public int LineNumber { get; private set; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00008C08 File Offset: 0x00006E08
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00008C10 File Offset: 0x00006E10
		public string Message { get; private set; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00008C19 File Offset: 0x00006E19
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00008C21 File Offset: 0x00006E21
		public string ScriptResourceName { get; private set; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00008C2A File Offset: 0x00006E2A
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00008C32 File Offset: 0x00006E32
		public string SourceLine { get; private set; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00008C3B File Offset: 0x00006E3B
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00008C43 File Offset: 0x00006E43
		public int StartColumn { get; private set; }

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00008C4C File Offset: 0x00006E4C
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00008C54 File Offset: 0x00006E54
		public int StartPosition { get; private set; }

		// Token: 0x060005A3 RID: 1443 RVA: 0x00008C60 File Offset: 0x00006E60
		public V8Exception(int endColumn, int endPosition, int lineNumber, string message, string scriptResourceName, string sourceLine, int startColumn, int startPosition)
		{
			this.EndColumn = endColumn;
			this.EndPosition = endPosition;
			this.LineNumber = lineNumber;
			this.Message = message;
			this.ScriptResourceName = scriptResourceName;
			this.SourceLine = sourceLine;
			this.StartColumn = startColumn;
			this.StartPosition = startPosition;
		}
	}
}
