using System;
using System.Text;

namespace NPOI.SS.Formula
{
	// Token: 0x020000B0 RID: 176
	public class SheetRangeIdentifier : global::NPOI.SS.Formula.SheetIdentifier
	{
		// Token: 0x06000613 RID: 1555 RVA: 0x0000E22A File Offset: 0x0000C42A
		public SheetRangeIdentifier(string bookName, global::NPOI.SS.Formula.NameIdentifier firstSheetIdentifier, global::NPOI.SS.Formula.NameIdentifier lastSheetIdentifier) : base(bookName, firstSheetIdentifier)
		{
			this._lastSheetIdentifier = lastSheetIdentifier;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0000E23B File Offset: 0x0000C43B
		public global::NPOI.SS.Formula.NameIdentifier FirstSheetIdentifier
		{
			get
			{
				return base.SheetId;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0000E243 File Offset: 0x0000C443
		public global::NPOI.SS.Formula.NameIdentifier LastSheetIdentifier
		{
			get
			{
				return this._lastSheetIdentifier;
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0000E24C File Offset: 0x0000C44C
		protected override void AsFormulaString(global::System.Text.StringBuilder sb)
		{
			base.AsFormulaString(sb);
			sb.Append(':');
			if (this._lastSheetIdentifier.IsQuoted)
			{
				sb.Append("'").Append(this._lastSheetIdentifier.Name).Append("'");
				return;
			}
			sb.Append(this._lastSheetIdentifier.Name);
		}

		// Token: 0x04000392 RID: 914
		public global::NPOI.SS.Formula.NameIdentifier _lastSheetIdentifier;
	}
}
