using System;

namespace SourceGrid
{
	// Token: 0x020003CC RID: 972
	internal class RangeFixedCols : global::SourceGrid.IRangeLoader
	{
		// Token: 0x06002C37 RID: 11319 RVA: 0x00094A00 File Offset: 0x00092C00
		public global::SourceGrid.Range GetRange(global::SourceGrid.GridVirtual p_Grid)
		{
			if (p_Grid.Columns.Count >= p_Grid.FixedColumns)
			{
				return new global::SourceGrid.Range(0, 0, p_Grid.Rows.Count - 1, p_Grid.FixedColumns);
			}
			return global::SourceGrid.Range.Empty;
		}
	}
}
