using System;
using SourceGrid.Cells.Virtual;

namespace SourceGrid
{
	// Token: 0x02000413 RID: 1043
	internal class ArrayColumnHeader : global::SourceGrid.Cells.Virtual.ColumnHeader
	{
		// Token: 0x06002D95 RID: 11669 RVA: 0x00099304 File Offset: 0x00097504
		public ArrayColumnHeader()
		{
			base.Model.AddModel(new global::SourceGrid.ArrayColumnHeaderModel());
			base.AutomaticSortEnabled = false;
			base.ResizeEnabled = false;
		}
	}
}
