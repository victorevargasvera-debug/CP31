using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200021A RID: 538
	public class GroupCellControl : global::Infragistics.Controls.Grids.Primitives.CellControlBase
	{
		// Token: 0x06000F47 RID: 3911 RVA: 0x0003A600 File Offset: 0x00038800
		public GroupCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.GroupCellControl);
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0003A618 File Offset: 0x00038818
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._panel = (base.GetTemplateChild("Panel") as global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0003A636 File Offset: 0x00038836
		protected internal override void ManuallyInvokeMeasure(global::System.Windows.Size sizeToBeMeasured)
		{
			if (this._panel != null)
			{
				this._panel.InvalidateMeasure();
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x0003A64B File Offset: 0x0003884B
		protected override bool ShowResizingArrow
		{
			get
			{
				return base.Cell.Column.ColumnLayout.ColumnResizingSettings.AllowCellAreaResizingResolved;
			}
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0003A667 File Offset: 0x00038867
		protected internal override void OnReleased(global::Infragistics.Controls.Grids.CellBase cell)
		{
			base.OnReleased(cell);
			if (this._panel != null)
			{
				this._panel.ReleaseUsedCells();
			}
		}

		// Token: 0x040004DD RID: 1245
		private global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel _panel;
	}
}
