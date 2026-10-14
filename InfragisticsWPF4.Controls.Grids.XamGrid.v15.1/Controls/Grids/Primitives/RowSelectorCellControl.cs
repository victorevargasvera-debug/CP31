using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001EF RID: 495
	[global::System.Windows.TemplateVisualState(GroupName = "ActiveStates", Name = "Editing")]
	[global::System.Windows.TemplateVisualState(GroupName = "ActiveStates", Name = "InActive")]
	[global::System.Windows.TemplateVisualState(GroupName = "ActiveStates", Name = "Active")]
	public class RowSelectorCellControl : global::Infragistics.Controls.Grids.Primitives.CellControlBase
	{
		// Token: 0x06000DFB RID: 3579 RVA: 0x000345E8 File Offset: 0x000327E8
		public RowSelectorCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.RowSelectorCellControl);
			this._tb = new global::System.Windows.Controls.TextBlock();
			base.Content = this._tb;
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00034617 File Offset: 0x00032817
		protected override void AttachContent()
		{
			this.EnsureContent();
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0003461F File Offset: 0x0003281F
		protected override void ReleaseContent()
		{
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00034624 File Offset: 0x00032824
		protected internal override void EnsureContent()
		{
			global::Infragistics.Controls.Grids.RowBase row = base.Cell.Row;
			string text = null;
			if (row != null && row.ColumnLayout.RowSelectorSettings.EnableRowNumberingResolved)
			{
				text = (row.ColumnLayout.RowSelectorSettings.RowNumberingSeedResolved + row.Index).ToString(global::System.Globalization.CultureInfo.CurrentCulture);
			}
			if (this._tb.Text != text)
			{
				this._tb.Text = (text ?? string.Empty);
			}
		}

		// Token: 0x0400048F RID: 1167
		private global::System.Windows.Controls.TextBlock _tb;
	}
}
