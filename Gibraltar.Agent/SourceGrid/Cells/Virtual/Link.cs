using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells.Virtual
{
	// Token: 0x020003A1 RID: 929
	internal abstract class Link : global::SourceGrid.Cells.Virtual.CellVirtual
	{
		// Token: 0x06002B49 RID: 11081 RVA: 0x00091C54 File Offset: 0x0008FE54
		public Link()
		{
			this.View = global::SourceGrid.Cells.Views.Link.Default;
			base.AddController(global::SourceGrid.Cells.Controllers.MouseCursor.Hand);
		}
	}
}
