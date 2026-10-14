using System;

namespace NPOI.SS.Formula
{
	// Token: 0x020000BD RID: 189
	public class ExternalSheet
	{
		// Token: 0x06000661 RID: 1633 RVA: 0x0000F05C File Offset: 0x0000D25C
		public ExternalSheet(string workbookName, string sheetName)
		{
			this._workbookName = workbookName;
			this._sheetName = sheetName;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0000F072 File Offset: 0x0000D272
		public string WorkbookName
		{
			get
			{
				return this._workbookName;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0000F07A File Offset: 0x0000D27A
		public string SheetName
		{
			get
			{
				return this._sheetName;
			}
		}

		// Token: 0x040003A3 RID: 931
		private string _workbookName;

		// Token: 0x040003A4 RID: 932
		private string _sheetName;
	}
}
