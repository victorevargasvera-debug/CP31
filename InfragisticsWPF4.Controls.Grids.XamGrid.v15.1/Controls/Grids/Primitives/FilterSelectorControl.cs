using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000E3 RID: 227
	public class FilterSelectorControl : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06000741 RID: 1857 RVA: 0x0001F0B4 File Offset: 0x0001D2B4
		static FilterSelectorControl()
		{
			global::System.Windows.Style style = new global::System.Windows.Style();
			style.Seal();
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectorControl), new global::System.Windows.FrameworkPropertyMetadata(style));
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0001F11B File Offset: 0x0001D31B
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x0001F12D File Offset: 0x0001D32D
		public global::Infragistics.Controls.Grids.CellBase Cell
		{
			get
			{
				return (global::Infragistics.Controls.Grids.CellBase)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectorControl.CellProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectorControl.CellProperty, value);
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0001F13C File Offset: 0x0001D33C
		private static void CellChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterSelectorControl filterSelectorControl = (global::Infragistics.Controls.Grids.Primitives.FilterSelectorControl)obj;
			filterSelectorControl.OnCellAssigned();
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0001F158 File Offset: 0x0001D358
		protected virtual void OnCellAssigned()
		{
			global::Infragistics.Controls.Grids.CellBase cell = this.Cell;
			if (cell != null && cell.Column != null)
			{
				if (this._filterSelectionControl != null)
				{
					if (this._filterSelectionControl.Cell != cell)
					{
						this._filterSelectionControl.Cell = null;
						this._filterSelectionControl = cell.Column.GenerateFilterSelectionControl();
					}
				}
				else
				{
					this._filterSelectionControl = cell.Column.GenerateFilterSelectionControl();
				}
				if (this._filterSelectionControl != null)
				{
					this._filterSelectionControl.Cell = cell;
				}
				base.Content = this._filterSelectionControl;
			}
		}

		// Token: 0x040001D0 RID: 464
		private global::Infragistics.Controls.Grids.Primitives.SelectionControl _filterSelectionControl;

		// Token: 0x040001D1 RID: 465
		public static readonly global::System.Windows.DependencyProperty CellProperty = global::System.Windows.DependencyProperty.Register("Cell", typeof(global::Infragistics.Controls.Grids.CellBase), typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectorControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterSelectorControl.CellChanged)));
	}
}
