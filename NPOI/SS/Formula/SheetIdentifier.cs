using System;
using System.Text;

namespace NPOI.SS.Formula
{
	// Token: 0x020000AE RID: 174
	public class SheetIdentifier
	{
		// Token: 0x06000605 RID: 1541 RVA: 0x0000DF65 File Offset: 0x0000C165
		public SheetIdentifier(string bookName, global::NPOI.SS.Formula.NameIdentifier sheetIdentifier)
		{
			this._bookName = bookName;
			this._sheetIdentifier = sheetIdentifier;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0000DF7B File Offset: 0x0000C17B
		public string BookName
		{
			get
			{
				return this._bookName;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0000DF83 File Offset: 0x0000C183
		public global::NPOI.SS.Formula.NameIdentifier SheetId
		{
			get
			{
				return this._sheetIdentifier;
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0000DF8C File Offset: 0x0000C18C
		protected virtual void AsFormulaString(global::System.Text.StringBuilder sb)
		{
			if (this._bookName != null)
			{
				sb.Append(" [").Append(this._sheetIdentifier.Name).Append("]");
			}
			if (this._sheetIdentifier.IsQuoted)
			{
				sb.Append("'").Append(this._sheetIdentifier.Name).Append("'");
				return;
			}
			sb.Append(this._sheetIdentifier.Name);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0000E010 File Offset: 0x0000C210
		public string AsFormulaString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(32);
			this.AsFormulaString(stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000E034 File Offset: 0x0000C234
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append(" [");
			this.AsFormulaString(stringBuilder);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x0400038D RID: 909
		public string _bookName;

		// Token: 0x0400038E RID: 910
		public global::NPOI.SS.Formula.NameIdentifier _sheetIdentifier;
	}
}
