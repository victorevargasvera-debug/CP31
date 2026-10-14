using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells.Virtual
{
	// Token: 0x020003EB RID: 1003
	internal class RowHeader : global::SourceGrid.Cells.Virtual.CellVirtual
	{
		// Token: 0x06002CB6 RID: 11446 RVA: 0x00096534 File Offset: 0x00094734
		public RowHeader()
		{
			this.View = global::SourceGrid.Cells.Views.RowHeader.Default;
			base.AddController(global::SourceGrid.Cells.Controllers.Unselectable.Default);
			base.AddController(global::SourceGrid.Cells.Controllers.MouseInvalidate.Default);
			this.ResizeEnabled = true;
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x00096574 File Offset: 0x00094774
		// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x00096590 File Offset: 0x00094790
		public bool ResizeEnabled
		{
			get
			{
				return base.FindController(typeof(global::SourceGrid.Cells.Controllers.Resizable)) == global::SourceGrid.Cells.Controllers.Resizable.ResizeHeight;
			}
			set
			{
				if (value == this.ResizeEnabled)
				{
					return;
				}
				if (value)
				{
					base.AddController(global::SourceGrid.Cells.Controllers.Resizable.ResizeHeight);
					return;
				}
				base.RemoveController(global::SourceGrid.Cells.Controllers.Resizable.ResizeHeight);
			}
		}
	}
}
