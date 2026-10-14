using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells
{
	// Token: 0x020003C2 RID: 962
	internal class Header : global::SourceGrid.Cells.Cell
	{
		// Token: 0x06002BFC RID: 11260 RVA: 0x000939DC File Offset: 0x00091BDC
		public Header() : this(null)
		{
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x000939E8 File Offset: 0x00091BE8
		public Header(object cellValue) : base(cellValue)
		{
			this.View = global::SourceGrid.Cells.Views.Header.Default;
			base.AddController(global::SourceGrid.Cells.Controllers.Unselectable.Default);
			base.AddController(global::SourceGrid.Cells.Controllers.MouseInvalidate.Default);
			this.ResizeEnabled = true;
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x00093A28 File Offset: 0x00091C28
		// (set) Token: 0x06002BFF RID: 11263 RVA: 0x00093A44 File Offset: 0x00091C44
		public bool ResizeEnabled
		{
			get
			{
				return base.FindController(typeof(global::SourceGrid.Cells.Controllers.Resizable)) == global::SourceGrid.Cells.Controllers.Resizable.ResizeBoth;
			}
			set
			{
				if (value == this.ResizeEnabled)
				{
					return;
				}
				if (value)
				{
					base.AddController(global::SourceGrid.Cells.Controllers.Resizable.ResizeBoth);
					return;
				}
				base.RemoveController(global::SourceGrid.Cells.Controllers.Resizable.ResizeBoth);
			}
		}
	}
}
