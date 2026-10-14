using System;

namespace Infragistics
{
	// Token: 0x0200003E RID: 62
	internal class ColumnReference
	{
		// Token: 0x060003A5 RID: 933 RVA: 0x0000EFE4 File Offset: 0x0000D1E4
		public ColumnReference(global::Infragistics.IFastItemColumnInternal fastItemColumn)
		{
			this.FastItemColumn = fastItemColumn;
			this.References = 0;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0000EFFA File Offset: 0x0000D1FA
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x0000F002 File Offset: 0x0000D202
		public int References { get; set; }

		// Token: 0x0400013B RID: 315
		public global::Infragistics.IFastItemColumnInternal FastItemColumn;
	}
}
