using System;

namespace SourceGrid
{
	// Token: 0x020003C9 RID: 969
	internal class RangeFullGridNoFixedRows : global::SourceGrid.IRangeLoader
	{
		// Token: 0x06002C31 RID: 11313 RVA: 0x000948F8 File Offset: 0x00092AF8
		public global::SourceGrid.Range GetRange(global::SourceGrid.GridVirtual p_Grid)
		{
			if (p_Grid.Rows.Count >= p_Grid.FixedRows)
			{
				return new global::SourceGrid.Range(p_Grid.FixedRows, 0, p_Grid.Rows.Count - 1, p_Grid.Columns.Count - 1);
			}
			return global::SourceGrid.Range.Empty;
		}
	}
}
