using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000220 RID: 544
	public class GroupHeaderCellControl : global::Infragistics.Controls.Grids.Primitives.HeaderCellControl
	{
		// Token: 0x06000F63 RID: 3939 RVA: 0x0003AAF4 File Offset: 0x00038CF4
		static GroupHeaderCellControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.GroupHeaderCellControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.GroupHeaderCellControl)));
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0003AB21 File Offset: 0x00038D21
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._panel = (base.GetTemplateChild("Panel") as global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0003AB3F File Offset: 0x00038D3F
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			this._panel.InvalidateMeasure();
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0003AB53 File Offset: 0x00038D53
		protected internal override void ManuallyInvokeMeasure(global::System.Windows.Size sizeToBeMeasured)
		{
			if (this._panel != null)
			{
				this._panel.InvalidateMeasure();
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x0003AB68 File Offset: 0x00038D68
		protected internal override void OnReleased(global::Infragistics.Controls.Grids.CellBase cell)
		{
			base.OnReleased(cell);
			if (this._panel != null)
			{
				this._panel.ReleaseUsedCells();
			}
		}

		// Token: 0x040004E0 RID: 1248
		private global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel _panel;
	}
}
