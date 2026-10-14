using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200021E RID: 542
	public class GroupFooterCellControl : global::Infragistics.Controls.Grids.Primitives.FooterCellControl
	{
		// Token: 0x06000F5B RID: 3931 RVA: 0x0003A9F0 File Offset: 0x00038BF0
		public GroupFooterCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.GroupFooterCellControl);
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x0003AA08 File Offset: 0x00038C08
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._panel = (base.GetTemplateChild("Panel") as global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0003AA26 File Offset: 0x00038C26
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			this._panel.InvalidateMeasure();
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0003AA3A File Offset: 0x00038C3A
		protected internal override void ManuallyInvokeMeasure(global::System.Windows.Size sizeToBeMeasured)
		{
			if (this._panel != null)
			{
				this._panel.InvalidateMeasure();
			}
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0003AA4F File Offset: 0x00038C4F
		protected internal override void OnReleased(global::Infragistics.Controls.Grids.CellBase cell)
		{
			base.OnReleased(cell);
			if (this._panel != null)
			{
				this._panel.ReleaseUsedCells();
			}
		}

		// Token: 0x040004DF RID: 1247
		private global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel _panel;
	}
}
