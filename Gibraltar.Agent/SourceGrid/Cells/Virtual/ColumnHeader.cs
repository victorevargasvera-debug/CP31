using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Models;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells.Virtual
{
	// Token: 0x020003A7 RID: 935
	internal class ColumnHeader : global::SourceGrid.Cells.Virtual.CellVirtual
	{
		// Token: 0x06002B5B RID: 11099 RVA: 0x00091F84 File Offset: 0x00090184
		public ColumnHeader()
		{
			this.View = global::SourceGrid.Cells.Views.ColumnHeader.Default;
			base.Model.AddModel(new global::SourceGrid.Cells.Models.SortableHeader());
			base.AddController(global::SourceGrid.Cells.Controllers.Unselectable.Default);
			base.AddController(global::SourceGrid.Cells.Controllers.MouseInvalidate.Default);
			this.ResizeEnabled = true;
			this.AutomaticSortEnabled = true;
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002B5C RID: 11100 RVA: 0x00091FDC File Offset: 0x000901DC
		// (set) Token: 0x06002B5D RID: 11101 RVA: 0x00091FF8 File Offset: 0x000901F8
		public bool ResizeEnabled
		{
			get
			{
				return base.FindController(typeof(global::SourceGrid.Cells.Controllers.Resizable)) == global::SourceGrid.Cells.Controllers.Resizable.ResizeWidth;
			}
			set
			{
				if (value == this.ResizeEnabled)
				{
					return;
				}
				if (value)
				{
					base.AddController(global::SourceGrid.Cells.Controllers.Resizable.ResizeWidth);
					return;
				}
				base.RemoveController(global::SourceGrid.Cells.Controllers.Resizable.ResizeWidth);
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x00092024 File Offset: 0x00090224
		// (set) Token: 0x06002B5F RID: 11103 RVA: 0x00092040 File Offset: 0x00090240
		public bool AutomaticSortEnabled
		{
			get
			{
				return base.FindController(typeof(global::SourceGrid.Cells.Controllers.SortableHeader)) == global::SourceGrid.Cells.Controllers.SortableHeader.Default;
			}
			set
			{
				if (value == this.AutomaticSortEnabled)
				{
					return;
				}
				if (value)
				{
					base.AddController(global::SourceGrid.Cells.Controllers.SortableHeader.Default);
					return;
				}
				base.RemoveController(global::SourceGrid.Cells.Controllers.SortableHeader.Default);
			}
		}
	}
}
