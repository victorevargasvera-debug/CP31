using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000202 RID: 514
	public class FilterRowCell : global::Infragistics.Controls.Grids.Cell
	{
		// Token: 0x06000EA8 RID: 3752 RVA: 0x00037EDE File Offset: 0x000360DE
		protected internal FilterRowCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00037EE8 File Offset: 0x000360E8
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				if (base.Column != null && base.Column.FilterColumnSettings.FilterRowCellStyle != null)
				{
					return base.Column.FilterColumnSettings.FilterRowCellStyle;
				}
				return base.Row.ColumnLayout.FilteringSettings.StyleResolved;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x00037F44 File Offset: 0x00036144
		protected internal override global::Infragistics.Controls.Grids.EditingSettingsBaseOverride EditingSettings
		{
			get
			{
				return base.Row.ColumnLayout.FilteringSettings;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00037F56 File Offset: 0x00036156
		protected internal override bool EnableCustomEditorBehaviors
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x00037F59 File Offset: 0x00036159
		public override bool IsEditable
		{
			get
			{
				return base.Column.IsFilterable;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00037F66 File Offset: 0x00036166
		public override object Value
		{
			get
			{
				return this.FilterCellValueResolved;
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00037F6E File Offset: 0x0003616E
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.FilterRowCellControl();
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00037F78 File Offset: 0x00036178
		protected internal override void EnsureCurrentState()
		{
			base.EnsureCurrentState();
			if (base.Control != null)
			{
				if (!base.Column.IsFilterable)
				{
					global::System.Windows.VisualStateManager.GoToState(base.Control, "HideFilterUI", true);
					return;
				}
				object filterCellValueResolved = this.FilterCellValueResolved;
				global::System.Windows.VisualStateManager.GoToState(base.Control, "ShowFilterCellValue", true);
				if (this.FilteringOperandResolved == null)
				{
					global::System.Windows.VisualStateManager.GoToState(base.Control, "ShowFilterUI", true);
					return;
				}
				if (this.FilteringOperandResolved.RequiresFilteringInput)
				{
					if (filterCellValueResolved == null)
					{
						global::System.Windows.VisualStateManager.GoToState(base.Control, "ShowFilterUI", true);
						return;
					}
					string value = filterCellValueResolved.ToString();
					if (string.IsNullOrEmpty(value))
					{
						global::System.Windows.VisualStateManager.GoToState(base.Control, "ShowFilterUI", true);
						return;
					}
					global::System.Windows.VisualStateManager.GoToState(base.Control, "ShowFilterUIWithCancelButton", true);
					return;
				}
				else
				{
					global::System.Windows.VisualStateManager.GoToState(base.Control, "ShowFilterUI", true);
					global::System.Windows.VisualStateManager.GoToState(base.Control, "HideFilterCellValue", true);
				}
			}
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00038068 File Offset: 0x00036268
		protected override global::System.Windows.Data.Binding CreateCellValueBinding(bool addValidation)
		{
			if (base.Column != null && base.Column is global::Infragistics.Controls.Grids.TemplateColumn)
			{
				return base.CreateCellValueBinding(addValidation);
			}
			if (base.Column != null && base.Column is global::Infragistics.Controls.Grids.UnboundColumn)
			{
				return base.CreateCellValueBinding(addValidation);
			}
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Path = new global::System.Windows.PropertyPath("FilterCellValue", new object[0]);
			if (base.Column == null || base.Column.ColumnLayout.FilteringSettings.FilteringScopeResolved == global::Infragistics.Controls.Grids.FilteringScope.ChildBand)
			{
				binding.Source = this;
			}
			else
			{
				binding.Source = base.Column.FilterColumnSettings;
			}
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.ConverterCulture = global::System.Globalization.CultureInfo.CurrentCulture;
			return binding;
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00038119 File Offset: 0x00036319
		protected override void OnElementAttached(global::Infragistics.Controls.Grids.Primitives.CellControlBase element)
		{
			base.OnElementAttached(element);
			if (base.Column != null)
			{
				base.Column.FilterColumnSettings.PropertyChanged += this.FilterColumnSettings_PropertyChanged;
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00038146 File Offset: 0x00036346
		protected override void OnElementReleased(global::Infragistics.Controls.Grids.Primitives.CellControlBase element)
		{
			base.OnElementReleased(element);
			if (base.Column != null)
			{
				base.Column.FilterColumnSettings.PropertyChanged -= this.FilterColumnSettings_PropertyChanged;
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00038173 File Offset: 0x00036373
		protected internal override global::Infragistics.Controls.Grids.DragSelectType OnCellMouseDown(global::System.Windows.Input.MouseEventArgs e)
		{
			if (((global::System.Windows.Input.MouseButtonEventArgs)e).Handled)
			{
				return global::Infragistics.Controls.Grids.DragSelectType.None;
			}
			return base.OnCellMouseDown(e);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0003818B File Offset: 0x0003638B
		protected internal override void OnCellClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (!e.Handled)
			{
				base.OnCellClick(e);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0003819C File Offset: 0x0003639C
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x000381A4 File Offset: 0x000363A4
		public global::Infragistics.Controls.Grids.FilterOperand FilteringOperand
		{
			get
			{
				return this._filteringOperand;
			}
			set
			{
				if (this._filteringOperand != value)
				{
					this._filteringOperand = value;
					global::Infragistics.Controls.Grids.Primitives.FilterRow filterRow = base.Row as global::Infragistics.Controls.Grids.Primitives.FilterRow;
					if (filterRow != null)
					{
						filterRow.BuildFilters(this, this.FilterCellValueResolved, true);
						filterRow.RaiseFilteredEvent();
					}
					this.OnPropertyChanged("FilteringOperand");
					this.OnPropertyChanged("FilteringOperandResolved");
					if (this._filteringOperand != null && !this._filteringOperand.RequiresFilteringInput)
					{
						filterRow.ColumnLayout.Grid.ExitEditModeInternal(true);
						this._filterCellValue = null;
					}
					base.Row.ColumnLayout.Grid.InvalidateScrollPanel(false);
				}
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x00038244 File Offset: 0x00036444
		public global::Infragistics.Controls.Grids.FilterOperand FilteringOperandResolved
		{
			get
			{
				if (base.Column == null)
				{
					return this.FilteringOperand;
				}
				if (this.FilteringOperand == null)
				{
					return base.Column.FilterColumnSettings.FilteringOperandResolved;
				}
				if (base.Column.ColumnLayout.FilteringSettings.FilteringScopeResolved == global::Infragistics.Controls.Grids.FilteringScope.ChildBand)
				{
					return this.FilteringOperand;
				}
				return base.Column.FilterColumnSettings.FilteringOperandResolved;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x000382A7 File Offset: 0x000364A7
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x000382B0 File Offset: 0x000364B0
		public virtual object FilterCellValue
		{
			get
			{
				return this._filterCellValue;
			}
			set
			{
				if (base.Column == null || base.Column.DataType == null)
				{
					this._filterCellValue = value;
					this.OnPropertyChanged("FilterCellValue");
					this.OnPropertyChanged("FilterCellValueResolved");
					return;
				}
				if (this._filterCellValue != value)
				{
					string text = value as string;
					if (text != null && text.Length == 0 && this._filterCellValue == null)
					{
						return;
					}
					if (!string.IsNullOrEmpty(text))
					{
						try
						{
							object obj = global::Infragistics.Controls.Grids.Primitives.FilterRow.ChangeType(value, base.Column.DataType);
							if (this._filterCellValue != obj)
							{
								this._filterCellValue = global::Infragistics.Controls.Grids.Primitives.FilterRow.ChangeType(value, base.Column.DataType);
								this.OnPropertyChanged("FilterCellValue");
								this.OnPropertyChanged("FilterCellValueResolved");
								this.InvalidateFiltering();
							}
							return;
						}
						catch (global::System.FormatException)
						{
							global::Infragistics.Controls.Grids.EditableColumn editableColumn = base.Column as global::Infragistics.Controls.Grids.EditableColumn;
							if (editableColumn != null && editableColumn.AllowEditingValidation)
							{
								throw;
							}
							return;
						}
					}
					if (this._filterCellValue != null)
					{
						if (!(base.Column.DataType == typeof(string)))
						{
							this._filterCellValue = value;
							this.OnPropertyChanged("FilterCellValue");
							this.OnPropertyChanged("FilterCellValueResolved");
							this.InvalidateFiltering(true);
							return;
						}
						if (!string.IsNullOrEmpty(this._filterCellValue as string))
						{
							this._filterCellValue = value;
							this.OnPropertyChanged("FilterCellValue");
							this.OnPropertyChanged("FilterCellValueResolved");
							this.InvalidateFiltering();
							return;
						}
					}
					else
					{
						this._filterCellValue = value;
						this.OnPropertyChanged("FilterCellValue");
						this.OnPropertyChanged("FilterCellValueResolved");
						this.InvalidateFiltering();
					}
				}
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0003844C File Offset: 0x0003664C
		public object FilterCellValueResolved
		{
			get
			{
				global::Infragistics.Controls.Grids.UnboundColumn unboundColumn = base.Column as global::Infragistics.Controls.Grids.UnboundColumn;
				global::Infragistics.Controls.Grids.TemplateColumn templateColumn = base.Column as global::Infragistics.Controls.Grids.TemplateColumn;
				if ((unboundColumn != null && unboundColumn.FilterEditorTemplate == null) || (templateColumn != null && templateColumn.FilterEditorTemplate == null))
				{
					return base.Value;
				}
				if (base.Column == null || base.Column.ColumnLayout.FilteringSettings.FilteringScopeResolved == global::Infragistics.Controls.Grids.FilteringScope.ChildBand)
				{
					return this.FilterCellValue;
				}
				return base.Column.FilterColumnSettings.FilterCellValue;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x000384C4 File Offset: 0x000366C4
		// (set) Token: 0x06000EBC RID: 3772 RVA: 0x000384CC File Offset: 0x000366CC
		protected internal bool SilentUpdate { get; set; }

		// Token: 0x06000EBD RID: 3773 RVA: 0x000384D8 File Offset: 0x000366D8
		private void InvalidateFiltering(bool forceFilteredEvent)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterRow filterRow = base.Row as global::Infragistics.Controls.Grids.Primitives.FilterRow;
			if (filterRow != null && filterRow.ColumnLayout != null)
			{
				bool flag = filterRow.BuildFilters(this, this.FilterCellValueResolved, true);
				if (flag)
				{
					filterRow.RaiseFilteredEvent();
				}
			}
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00038514 File Offset: 0x00036714
		private void InvalidateFiltering()
		{
			this.InvalidateFiltering(false);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00038520 File Offset: 0x00036720
		private void FilterColumnSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "FilterCellValue")
			{
				if (base.Column.ColumnLayout.FilteringSettings.FilteringScopeResolved == global::Infragistics.Controls.Grids.FilteringScope.ColumnLayout)
				{
					this.OnPropertyChanged("FilterCellValueResolved");
					return;
				}
			}
			else if (e.PropertyName == "FilteringOperand" && base.Column.ColumnLayout.FilteringSettings.FilteringScopeResolved == global::Infragistics.Controls.Grids.FilteringScope.ColumnLayout)
			{
				this.OnPropertyChanged("FilteringOperandResolved");
			}
		}

		// Token: 0x040004C4 RID: 1220
		private object _filterCellValue;

		// Token: 0x040004C5 RID: 1221
		private global::Infragistics.Controls.Grids.FilterOperand _filteringOperand;
	}
}
