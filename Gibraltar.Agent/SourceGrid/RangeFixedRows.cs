using System;

namespace SourceGrid
{
	// Token: 0x020003CB RID: 971
	internal class RangeFixedRows : global::SourceGrid.IRangeLoader
	{
		// Token: 0x06002C35 RID: 11317 RVA: 0x000949B0 File Offset: 0x00092BB0
		public global::SourceGrid.Range GetRange(global::SourceGrid.GridVirtual p_Grid)
		{
			if (p_Grid.Rows.Count >= p_Grid.FixedRows)
			{
				return new global::SourceGrid.Range(0, 0, p_Grid.FixedRows, p_Grid.Columns.Count - 1);
			}
			return global::SourceGrid.Range.Empty;
		}
	}
}
