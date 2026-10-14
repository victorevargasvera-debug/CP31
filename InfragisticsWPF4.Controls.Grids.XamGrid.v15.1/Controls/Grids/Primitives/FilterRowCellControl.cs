using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000203 RID: 515
	[global::System.Windows.TemplatePart(Name = "OperatorControl", Type = typeof(global::Infragistics.Controls.Grids.Primitives.FilterControlBase))]
	[global::System.Windows.TemplateVisualState(GroupName = "AllowFiltering", Name = "ShowFilterUIWithCancelButton")]
	[global::System.Windows.TemplateVisualState(GroupName = "FilterCellValueVisibility", Name = "HideFilterCellValue")]
	[global::System.Windows.TemplateVisualState(GroupName = "AllowFiltering", Name = "ShowFilterUI")]
	[global::System.Windows.TemplateVisualState(GroupName = "AllowFiltering", Name = "HideFilterUI")]
	[global::System.Windows.TemplateVisualState(GroupName = "FilterCellValueVisibility", Name = "ShowFilterCellValue")]
	public class FilterRowCellControl : global::Infragistics.Controls.Grids.CellControl, global::Infragistics.ICommandTarget
	{
		// Token: 0x06000EC0 RID: 3776 RVA: 0x00038598 File Offset: 0x00036798
		public FilterRowCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.FilterRowCellControl);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x000385B0 File Offset: 0x000367B0
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._filterControl = (base.GetTemplateChild("OperatorControl") as global::Infragistics.Controls.Grids.Primitives.FilterControlBase);
			if (this._filterControl != null)
			{
				this._filterControl.Cell = (base.Cell as global::Infragistics.Controls.Grids.Primitives.FilterRowCell);
			}
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x000385EC File Offset: 0x000367EC
		protected internal override global::System.Windows.Data.Binding ResolveBinding()
		{
			if (!(base.Cell.Column is global::Infragistics.Controls.Grids.TemplateColumn))
			{
				global::System.Windows.Data.Binding binding = this.CreateBinding();
				binding.ConverterParameter = this;
				binding.Converter = new global::Infragistics.Controls.Grids.Cell.CellBindingConverter();
				return binding;
			}
			return base.ResolveBinding();
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0003862C File Offset: 0x0003682C
		protected internal override global::System.Windows.Data.Binding ResolveEditorBinding()
		{
			if (!(base.Cell.Column is global::Infragistics.Controls.Grids.TemplateColumn))
			{
				return this.CreateBinding();
			}
			return base.ResolveEditorBinding();
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0003864D File Offset: 0x0003684D
		protected override object ResolveEditorCellValue(object dataValue)
		{
			if (!(base.Cell.Column is global::Infragistics.Controls.Grids.TemplateColumn))
			{
				return ((global::Infragistics.Controls.Grids.Primitives.FilterRowCell)base.Cell).FilterCellValueResolved;
			}
			return base.ResolveEditorCellValue(dataValue);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0003867C File Offset: 0x0003687C
		protected internal override void AddEditorToControl()
		{
			global::Infragistics.Controls.Grids.Primitives.FilterRowCell filterRowCell = base.Cell as global::Infragistics.Controls.Grids.Primitives.FilterRowCell;
			if (filterRowCell != null && filterRowCell.FilteringOperandResolved != null && !filterRowCell.FilteringOperandResolved.RequiresFilteringInput)
			{
				return;
			}
			base.AddEditorToControl();
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000386B4 File Offset: 0x000368B4
		protected internal override void RemoveEditorFromControl()
		{
			global::Infragistics.Controls.Grids.Primitives.FilterRowCell filterRowCell = base.Cell as global::Infragistics.Controls.Grids.Primitives.FilterRowCell;
			if (filterRowCell != null && filterRowCell.FilteringOperandResolved != null && !filterRowCell.FilteringOperandResolved.RequiresFilteringInput)
			{
				return;
			}
			base.RemoveEditorFromControl();
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x000386EC File Offset: 0x000368EC
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return this.SupportsCommand(command);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x000386F5 File Offset: 0x000368F5
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x000386FE File Offset: 0x000368FE
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.Primitives.ClearFilters;
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00038709 File Offset: 0x00036909
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return base.Cell;
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x00038711 File Offset: 0x00036911
		protected internal override void EnsureContent()
		{
			if (this._filterControl != null)
			{
				this._filterControl.EnsureContent();
			}
			base.EnsureContent();
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0003872C File Offset: 0x0003692C
		private global::System.Windows.Data.Binding CreateBinding()
		{
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Path = new global::System.Windows.PropertyPath("FilterCellValue", new object[0]);
			if (base.Cell.Column == null || base.Cell.Column.ColumnLayout.FilteringSettings.FilteringScopeResolved == global::Infragistics.Controls.Grids.FilteringScope.ChildBand)
			{
				binding.Source = base.Cell;
			}
			else
			{
				binding.Source = base.Cell.Column.FilterColumnSettings;
			}
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.UpdateSourceTrigger = global::System.Windows.Data.UpdateSourceTrigger.Explicit;
			binding.ValidatesOnExceptions = true;
			binding.NotifyOnValidationError = true;
			binding.ValidatesOnDataErrors = true;
			binding.ConverterCulture = global::System.Globalization.CultureInfo.CurrentCulture;
			binding.ConverterParameter = base.Cell;
			binding.Converter = new global::Infragistics.Controls.Grids.Cell.CellEditingBindingConverter();
			return binding;
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000387E8 File Offset: 0x000369E8
		protected internal override void OnAttached(global::Infragistics.Controls.Grids.CellBase cell)
		{
			base.OnAttached(cell);
			if (this._filterControl != null)
			{
				this._filterControl.Cell = (base.Cell as global::Infragistics.Controls.Grids.Primitives.FilterRowCell);
			}
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0003880F File Offset: 0x00036A0F
		protected internal override void OnReleased(global::Infragistics.Controls.Grids.CellBase cell)
		{
			if (this._filterControl != null)
			{
				this._filterControl.Cell = null;
			}
			base.OnReleased(cell);
		}

		// Token: 0x040004C7 RID: 1223
		private global::Infragistics.Controls.Grids.Primitives.FilterControlBase _filterControl;
	}
}
