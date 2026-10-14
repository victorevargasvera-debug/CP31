using System;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000EF RID: 239
	public interface Pxg
	{
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000809 RID: 2057
		int ExternalWorkbookNumber { get; }

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600080A RID: 2058
		// (set) Token: 0x0600080B RID: 2059
		string SheetName { get; set; }

		// Token: 0x0600080C RID: 2060
		string ToFormulaString();
	}
}
