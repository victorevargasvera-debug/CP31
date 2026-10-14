using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000B8 RID: 184
	[global::System.Windows.TemplatePart(Type = typeof(global::System.Windows.Controls.ComboBox), Name = "FilterOperands")]
	public class FilterControl : global::Infragistics.Controls.Grids.Primitives.FilterControlBase
	{
		// Token: 0x06000630 RID: 1584 RVA: 0x0001C3C8 File Offset: 0x0001A5C8
		static FilterControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.FilterControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.FilterControl)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.FilterControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0001C452 File Offset: 0x0001A652
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x0001C45A File Offset: 0x0001A65A
		public override global::Infragistics.Controls.Grids.Primitives.FilterRowCell Cell
		{
			get
			{
				return this._cellBase;
			}
			set
			{
				if (this._cellBase != value)
				{
					this._cellBase = value;
					if (value != null)
					{
						this.SetFilterIcon();
					}
				}
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0001C475 File Offset: 0x0001A675
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x0001C487 File Offset: 0x0001A687
		public global::System.Windows.DataTemplate SelectedItemIcon
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterControl.SelectedItemIconProperty) as global::System.Windows.DataTemplate;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterControl.SelectedItemIconProperty, value);
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0001C498 File Offset: 0x0001A698
		private static void SelectedItemIconChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterControl filterControl = (global::Infragistics.Controls.Grids.Primitives.FilterControl)obj;
			filterControl.OnPropertyChanged("SelectedItemIcon");
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0001C4B7 File Offset: 0x0001A6B7
		protected virtual void PopulateMenuItems()
		{
			if (this.Cell != null)
			{
				this._comboBox.ItemsSource = this.Cell.Column.FilterColumnSettings.RowFilterOperands;
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001C4E4 File Offset: 0x0001A6E4
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._comboBox = (base.GetTemplateChild("FilterOperands") as global::System.Windows.Controls.ComboBox);
			if (this._comboBox != null)
			{
				this._comboBox.DropDownOpened += this.ComboBox_DropDownOpened;
			}
			this.SetFilterIcon();
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001C532 File Offset: 0x0001A732
		protected internal override void EnsureContent()
		{
			this.SetFilterIcon();
			base.EnsureContent();
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0001C540 File Offset: 0x0001A740
		private void ComboBox_DropDownOpened(object sender, global::System.EventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterRowCell cell = this.Cell;
			if (cell != null && cell.Column != null)
			{
				global::Infragistics.Controls.Grids.Column column = cell.Column;
				column.ColumnLayout.Grid.ExitEditMode(false);
				column.OnShowAvailableColumnFilterOperands();
				this._comboBox.SelectionChanged -= this.ComboBox_SelectionChanged;
				this.PopulateMenuItems();
				global::Infragistics.Controls.Grids.FilterOperand filteringOperandResolved = cell.FilteringOperandResolved;
				if (filteringOperandResolved != null)
				{
					foreach (object obj in ((global::System.Collections.IEnumerable)this._comboBox.Items))
					{
						global::Infragistics.Controls.Grids.FilterOperand filterOperand = (global::Infragistics.Controls.Grids.FilterOperand)obj;
						if (filterOperand.Equals(filteringOperandResolved))
						{
							this._comboBox.SelectedItem = filterOperand;
							break;
						}
					}
				}
				this._comboBox.SelectionChanged += this.ComboBox_SelectionChanged;
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0001C62C File Offset: 0x0001A82C
		private void ComboBox_SelectionChanged(object sender, global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterRowCell cell = this.Cell;
			if (cell != null)
			{
				global::Infragistics.Controls.Grids.FilterOperand filterOperand = this._comboBox.SelectedItem as global::Infragistics.Controls.Grids.FilterOperand;
				if (filterOperand != null)
				{
					global::Infragistics.Controls.Grids.Column column = cell.Column;
					column.ColumnLayout.Grid.ExitEditMode(false);
					if (column.ColumnLayout.FilteringSettings.FilteringScopeResolved == global::Infragistics.Controls.Grids.FilteringScope.ChildBand)
					{
						cell.FilteringOperand = filterOperand;
					}
					else
					{
						column.FilterColumnSettings.FilteringOperand = filterOperand;
					}
					this.SelectedItemIcon = filterOperand.IconResolved;
				}
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0001C6A4 File Offset: 0x0001A8A4
		private void SetFilterIcon()
		{
			if (this.Cell != null && this.Cell.Row != null && this.Cell.Row.ColumnLayout != null && this.Cell.FilteringOperandResolved != null)
			{
				global::Infragistics.Controls.Grids.FilterOperand filteringOperandResolved = this.Cell.FilteringOperandResolved;
				if (filteringOperandResolved != null)
				{
					filteringOperandResolved.XamWebGrid = this.Cell.Row.ColumnLayout.Grid;
					this.SelectedItemIcon = filteringOperandResolved.IconResolved;
				}
			}
		}

		// Token: 0x04000190 RID: 400
		private global::System.Windows.Controls.ComboBox _comboBox;

		// Token: 0x04000191 RID: 401
		private global::Infragistics.Controls.Grids.Primitives.FilterRowCell _cellBase;

		// Token: 0x04000192 RID: 402
		public static readonly global::System.Windows.DependencyProperty SelectedItemIconProperty = global::System.Windows.DependencyProperty.Register("SelectedItemIcon", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.Primitives.FilterControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterControl.SelectedItemIconChanged)));
	}
}
