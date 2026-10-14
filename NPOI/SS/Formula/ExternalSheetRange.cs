using System;

namespace NPOI.SS.Formula
{
	// Token: 0x020000BE RID: 190
	public class ExternalSheetRange : global::NPOI.SS.Formula.ExternalSheet
	{
		// Token: 0x06000664 RID: 1636 RVA: 0x0000F082 File Offset: 0x0000D282
		public ExternalSheetRange(string workbookName, string firstSheetName, string lastSheetName) : base(workbookName, firstSheetName)
		{
			this._lastSheetName = lastSheetName;
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0000F093 File Offset: 0x0000D293
		public string FirstSheetName
		{
			get
			{
				return base.SheetName;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x0000F09B File Offset: 0x0000D29B
		public string LastSheetName
		{
			get
			{
				return this._lastSheetName;
			}
		}

		// Token: 0x040003A5 RID: 933
		private string _lastSheetName;
	}
}
