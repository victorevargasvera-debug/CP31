using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells
{
	// Token: 0x020003A2 RID: 930
	internal class Link : global::SourceGrid.Cells.Cell
	{
		// Token: 0x06002B4A RID: 11082 RVA: 0x00091C74 File Offset: 0x0008FE74
		public Link() : this(null)
		{
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x00091C80 File Offset: 0x0008FE80
		public Link(object p_Value) : base(p_Value)
		{
			this.View = global::SourceGrid.Cells.Views.Link.Default;
			base.AddController(global::SourceGrid.Cells.Controllers.MouseCursor.Hand);
		}
	}
}
