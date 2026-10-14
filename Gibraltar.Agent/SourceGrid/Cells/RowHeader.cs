using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells
{
	// Token: 0x020003EC RID: 1004
	internal class RowHeader : global::SourceGrid.Cells.Cell
	{
		// Token: 0x06002CB9 RID: 11449 RVA: 0x000965BC File Offset: 0x000947BC
		public RowHeader() : this(null)
		{
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x000965C8 File Offset: 0x000947C8
		public RowHeader(object cellValue) : base(cellValue)
		{
			this.View = global::SourceGrid.Cells.Views.RowHeader.Default;
			base.AddController(global::SourceGrid.Cells.Controllers.Unselectable.Default);
			base.AddController(global::SourceGrid.Cells.Controllers.MouseInvalidate.Default);
			this.ResizeEnabled = true;
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x00096608 File Offset: 0x00094808
		// (set) Token: 0x06002CBC RID: 11452 RVA: 0x00096624 File Offset: 0x00094824
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
