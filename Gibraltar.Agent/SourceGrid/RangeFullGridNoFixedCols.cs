using System;

namespace SourceGrid
{
	// Token: 0x020003CA RID: 970
	internal class RangeFullGridNoFixedCols : global::SourceGrid.IRangeLoader
	{
		// Token: 0x06002C33 RID: 11315 RVA: 0x00094954 File Offset: 0x00092B54
		public global::SourceGrid.Range GetRange(global::SourceGrid.GridVirtual p_Grid)
		{
			if (p_Grid.Columns.Count >= p_Grid.FixedColumns)
			{
				return new global::SourceGrid.Range(0, p_Grid.FixedColumns, p_Grid.Rows.Count - 1, p_Grid.Columns.Count - 1);
			}
			return global::SourceGrid.Range.Empty;
		}
	}
}
