using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000269 RID: 617
	public class UnboundColumnContentProvider : global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase
	{
		// Token: 0x060013E2 RID: 5090 RVA: 0x0004AB50 File Offset: 0x00048D50
		public UnboundColumnContentProvider()
		{
			this._cellValueObj = new global::Infragistics.Controls.Grids.Cell.CellValueObject();
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0004AB63 File Offset: 0x00048D63
		public override bool RemovePaddingDuringEditing
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0004AB66 File Offset: 0x00048D66
		protected internal override bool CanResolveValueFromEditor
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0004AB6C File Offset: 0x00048D6C
		protected override global::System.Windows.FrameworkElement ResolveEditorControl(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			global::Infragistics.Controls.Grids.UnboundColumn unboundColumn = (global::Infragistics.Controls.Grids.UnboundColumn)cell.Column;
			bool flag = cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow;
			bool flag2 = cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow;
			if (unboundColumn.EditorTemplateDirtyFlag != this._templateFlag || this._editor == null)
			{
				if (flag && unboundColumn.FilterEditorTemplate != null && this._editor == null)
				{
					this._editor = (unboundColumn.FilterEditorTemplate.LoadContent() as global::System.Windows.FrameworkElement);
				}
				else if (flag2 && unboundColumn.AddNewRowEditorTemplate != null && this._editor == null)
				{
					this._editor = (unboundColumn.AddNewRowEditorTemplate.LoadContent() as global::System.Windows.FrameworkElement);
				}
				else if (this._editor == null && unboundColumn.EditorTemplate != null)
				{
					this._editor = (unboundColumn.EditorTemplate.LoadContent() as global::System.Windows.FrameworkElement);
				}
				else
				{
					this._editor = null;
				}
				this._templateFlag = unboundColumn.EditorTemplateDirtyFlag;
			}
			if (this._editor != null)
			{
				if (flag && unboundColumn.FilterEditorTemplate != null)
				{
					global::Infragistics.Controls.Grids.Primitives.FilterRowCell frc = (global::Infragistics.Controls.Grids.Primitives.FilterRowCell)cell;
					global::Infragistics.FilteringDataContext dataContext = new global::Infragistics.FilteringDataContext(frc);
					this._editor.DataContext = dataContext;
				}
				else
				{
					global::Infragistics.Controls.Grids.UnboundColumnDataContext unboundColumnDataContext = new global::Infragistics.Controls.Grids.UnboundColumnDataContext();
					unboundColumnDataContext.ColumnKey = cell.Column.Key;
					unboundColumnDataContext.RowData = cell.Row.Data;
					unboundColumnDataContext.Value = cell.Value;
					cell.Control.DataContext = unboundColumnDataContext;
					global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this._editor, cell.EditorStyleResolved);
				}
			}
			return this._editor;
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0004ACDA File Offset: 0x00048EDA
		public override object ResolveValueFromEditor(global::Infragistics.Controls.Grids.Cell cell)
		{
			return cell.Value;
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0004ACE4 File Offset: 0x00048EE4
		public override global::System.Windows.FrameworkElement ResolveDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			global::Infragistics.Controls.Grids.UnboundColumn unboundColumn = cell.Column as global::Infragistics.Controls.Grids.UnboundColumn;
			if (this._textBlock == null)
			{
				this._textBlock = new global::System.Windows.Controls.TextBlock();
			}
			if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow && unboundColumn.FilterItemTemplate != null && this._content == null)
			{
				this._content = (unboundColumn.FilterItemTemplate.LoadContent() as global::System.Windows.FrameworkElement);
			}
			else if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow && unboundColumn.AddNewRowItemTemplate != null && this._content == null)
			{
				this._content = (unboundColumn.AddNewRowItemTemplate.LoadContent() as global::System.Windows.FrameworkElement);
			}
			else if (unboundColumn.ItemTemplate != null && this._content == null)
			{
				this._content = (unboundColumn.ItemTemplate.LoadContent() as global::System.Windows.FrameworkElement);
			}
			if (cellBinding != null)
			{
				if (this._content != null && !base.IsToolTip)
				{
					this._cellValueObj.SetBinding(global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty, cellBinding);
				}
				else if (this._textBlock != null)
				{
					this._textBlock.SetBinding(global::System.Windows.Controls.TextBlock.TextProperty, cellBinding);
				}
			}
			if (!base.IsToolTip)
			{
				if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow)
				{
					this._isFilterRow = true;
				}
				if (this._content != null)
				{
					return this._content;
				}
			}
			else if (this._content != null)
			{
				global::Infragistics.Controls.Grids.UnboundColumnDataContext unboundColumnDataContext = new global::Infragistics.Controls.Grids.UnboundColumnDataContext();
				unboundColumnDataContext.ColumnKey = cell.Column.Key;
				unboundColumnDataContext.RowData = cell.Row.Data;
				if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow)
				{
					unboundColumnDataContext.Value = ((global::Infragistics.Controls.Grids.Primitives.FilterRowCell)cell).FilterCellValueResolved;
				}
				else
				{
					unboundColumnDataContext.Value = cell.Value;
				}
				this._content.DataContext = unboundColumnDataContext;
				return this._content;
			}
			this._textBlock.SetBinding(global::System.Windows.Controls.TextBlock.TextProperty, cellBinding);
			return this._textBlock;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0004AE98 File Offset: 0x00049098
		public override void AdjustDisplayElement(global::Infragistics.Controls.Grids.Cell cell)
		{
			global::Infragistics.Controls.Grids.Primitives.UnboundCell unboundCell = cell as global::Infragistics.Controls.Grids.Primitives.UnboundCell;
			if (unboundCell != null && this._attachedUnboundCell != null && this._attachedUnboundCell == unboundCell)
			{
				global::Infragistics.Controls.Grids.Primitives.CellControlBase control = cell.Control;
				if (control != null && (control.DataContext is global::Infragistics.Controls.Grids.UnboundColumnDataContext || control.DataContext is global::Infragistics.FilteringDataContext))
				{
					return;
				}
			}
			global::Infragistics.Controls.Grids.Primitives.FilterRowCell filterRowCell = cell as global::Infragistics.Controls.Grids.Primitives.FilterRowCell;
			global::Infragistics.Controls.Grids.UnboundColumnDataContext unboundColumnDataContext = new global::Infragistics.Controls.Grids.UnboundColumnDataContext();
			unboundColumnDataContext.ColumnKey = cell.Column.Key;
			unboundColumnDataContext.RowData = cell.Row.Data;
			if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow)
			{
				unboundColumnDataContext.Value = filterRowCell.FilterCellValueResolved;
			}
			else
			{
				unboundColumnDataContext.Value = cell.Value;
			}
			object dataContext = unboundColumnDataContext;
			this._cellValueObj.DataContext = unboundColumnDataContext;
			this._attachedUnboundCell = unboundCell;
			if (this._isFilterRow && ((global::Infragistics.Controls.Grids.UnboundColumn)cell.Column).FilterItemTemplate != null)
			{
				global::Infragistics.FilteringDataContext dataContext2 = new global::Infragistics.FilteringDataContext(filterRowCell);
				this._content.DataContext = dataContext2;
			}
			if (cell.Control != null && !cell.IsEditing)
			{
				cell.Control.DataContext = dataContext;
			}
			base.AdjustDisplayElement(cell);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0004AFB0 File Offset: 0x000491B0
		protected internal override global::System.Windows.Data.Binding ResolveBinding(global::Infragistics.Controls.Grids.Cell cell)
		{
			global::System.Windows.Data.Binding binding = null;
			if (cell.Column.Key != null && cell.Column.DataType != null)
			{
				binding = new global::System.Windows.Data.Binding();
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				if (!base.IsToolTip)
				{
					binding.Path = new global::System.Windows.PropertyPath("RowData", new object[0]);
					binding.ConverterParameter = cell.Control;
					binding.Converter = cell.CreateCellBindingConverter();
				}
				else
				{
					binding.ConverterParameter = cell.Column.ValueConverterParameter;
					binding.Converter = cell.Column.ValueConverter;
				}
			}
			return binding;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0004B047 File Offset: 0x00049247
		protected internal override global::System.Windows.Data.Binding ResolveEditorBinding(global::Infragistics.Controls.Grids.Cell cell)
		{
			return null;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0004B04A File Offset: 0x0004924A
		public override void ResetContent()
		{
			base.ResetContent();
			if (this._cellValueObj != null)
			{
				this._cellValueObj.DataContext = null;
			}
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0004B066 File Offset: 0x00049266
		protected internal override void FocusEditor()
		{
			global::Infragistics.Controls.PresentationUtilities.Focus(this._editor);
		}

		// Token: 0x04000614 RID: 1556
		private global::System.Windows.FrameworkElement _content;

		// Token: 0x04000615 RID: 1557
		private global::System.Windows.FrameworkElement _editor;

		// Token: 0x04000616 RID: 1558
		private int _templateFlag;

		// Token: 0x04000617 RID: 1559
		private global::System.Windows.Controls.TextBlock _textBlock;

		// Token: 0x04000618 RID: 1560
		private global::Infragistics.Controls.Grids.Cell.CellValueObject _cellValueObj;

		// Token: 0x04000619 RID: 1561
		private bool _isFilterRow;

		// Token: 0x0400061A RID: 1562
		private global::Infragistics.Controls.Grids.Primitives.UnboundCell _attachedUnboundCell;
	}
}
