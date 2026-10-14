using System;
using SourceGrid.Cells.Virtual;

namespace SourceGrid
{
	// Token: 0x02000414 RID: 1044
	internal class ArrayRowHeader : global::SourceGrid.Cells.Virtual.RowHeader
	{
		// Token: 0x06002D96 RID: 11670 RVA: 0x0009933C File Offset: 0x0009753C
		public ArrayRowHeader()
		{
			base.Model.AddModel(new global::SourceGrid.ArrayRowHeaderModel());
			base.ResizeEnabled = false;
		}
	}
}
