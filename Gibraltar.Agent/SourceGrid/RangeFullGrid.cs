using System;

namespace SourceGrid
{
	// Token: 0x020003C8 RID: 968
	internal class RangeFullGrid : global::SourceGrid.IRangeLoader
	{
		// Token: 0x06002C2F RID: 11311 RVA: 0x000948E8 File Offset: 0x00092AE8
		public global::SourceGrid.Range GetRange(global::SourceGrid.GridVirtual p_Grid)
		{
			return p_Grid.CompleteRange;
		}
	}
}
