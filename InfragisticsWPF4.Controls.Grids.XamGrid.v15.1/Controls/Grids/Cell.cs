using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001E0 RID: 480
	public class Cell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000D29 RID: 3369 RVA: 0x0002FFFD File Offset: 0x0002E1FD
		public Cell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00030007 File Offset: 0x0002E207
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x00030010 File Offset: 0x0002E210
		public override bool IsSelected
		{
			get
			{
				return this._isSelected;
			}
			set
			{
				if (base.Row.ColumnLayout != null && base.Column.SupportsActivationAndSelection)
				{
					bool isSelected = this._isSelected;
					if (value)
					{
						base.Row.ColumnLayout.Grid.SelectCell(this, global::Infragistics.Controls.Grids.InvokeAction.Code);
					}
					else
					{
						base.Row.ColumnLayout.Grid.UnselectCell(this);
					}
					if (isSelected != value)
					{
						this.OnPropertyChanged("IsSelected");
					}
				}
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00030080 File Offset: 0x0002E280
		public bool IsEditing
		{
			get
			{
				bool result = false;
				if (base.Row != null)
				{
					global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.Row.ColumnLayout;
					result = (columnLayout != null && columnLayout.Grid != null && columnLayout.Grid.CurrentEditCell == this);
				}
				return result;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x000300C1 File Offset: 0x0002E2C1
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x000300C9 File Offset: 0x0002E2C9
		public global::System.Windows.Style EditorStyle { get; set; }

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x000300D4 File Offset: 0x0002E2D4
		public global::System.Windows.Style EditorStyleResolved
		{
			get
			{
				if (this.EditorStyle == null)
				{
					global::Infragistics.Controls.Grids.EditableColumn editableColumn = base.Column as global::Infragistics.Controls.Grids.EditableColumn;
					if (editableColumn != null)
					{
						return editableColumn.EditorStyle;
					}
				}
				return this.EditorStyle;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x00030105 File Offset: 0x0002E305
		protected internal virtual global::Infragistics.Controls.Grids.Column ResolveColumn
		{
			get
			{
				return base.Column;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x00030110 File Offset: 0x0002E310
		internal override object RawValue
		{
			get
			{
				object result = null;
				if (base.Row.Data != null && base.Column.Key != null)
				{
					global::Infragistics.Controls.Grids.Cell.CellValueObject cellValueObject = new global::Infragistics.Controls.Grids.Cell.CellValueObject();
					global::System.Windows.Data.Binding binding = global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.ResolveBindingInternal(this);
					if (binding != null)
					{
						binding.Mode = global::System.Windows.Data.BindingMode.OneTime;
						binding.Source = base.Row.Data;
						binding.Converter = null;
						binding.ConverterParameter = null;
						cellValueObject.SetBinding(global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty, binding);
						result = cellValueObject.Value;
					}
				}
				return result;
			}
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00030184 File Offset: 0x0002E384
		internal static int ResolveRowIndex(global::Infragistics.Controls.Grids.RowBase row, bool usePartialCount)
		{
			global::Infragistics.Controls.Grids.XamGrid grid = row.ColumnLayout.Grid;
			int num = -1;
			if (grid.Panel.FixedRowsTop.IndexOf(row) == -1 && grid.Panel.FixedRowsBottom.IndexOf(row) == -1)
			{
				num = (usePartialCount ? row.Manager.ResolveIndexForRow(row) : grid.InternalRows.IndexOf(row));
			}
			if (row.Level == 0)
			{
				if (num > -1)
				{
					num += grid.Panel.FixedRowsTop.Count;
				}
				else
				{
					num = grid.Panel.FixedRowsTop.IndexOf(row);
					if (num < 0)
					{
						int num2 = grid.Panel.FixedRowsBottom.Count - 1;
						num = num2 - grid.Panel.FixedRowsBottom.IndexOf(row) + grid.Panel.FixedRowsTop.Count + (usePartialCount ? row.Manager.FullRowCount : grid.InternalRows.Count);
					}
				}
			}
			return num;
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00030274 File Offset: 0x0002E474
		internal static global::Infragistics.Controls.Grids.RowBase ResolveRow(global::Infragistics.Controls.Grids.RowBase currentRow, int index, bool increase, global::Infragistics.Controls.Grids.KeyboardNavigation navigation)
		{
			global::Infragistics.Controls.Grids.RowBase rowBase = null;
			global::Infragistics.Controls.Grids.XamGrid grid = currentRow.ColumnLayout.Grid;
			int num = 0;
			int num2 = 0;
			if (currentRow.Level == 0)
			{
				num = grid.Panel.FixedRowsTop.Count;
				num2 = grid.Panel.FixedRowsBottom.Count;
			}
			int num3;
			if (navigation == global::Infragistics.Controls.Grids.KeyboardNavigation.CurrentLayout)
			{
				num3 = currentRow.Manager.FullRowCount;
			}
			else
			{
				num3 = grid.InternalRows.Count;
			}
			if (index < num)
			{
				if (index > -1 && index < num)
				{
					rowBase = grid.Panel.FixedRowsTop[index];
					while (rowBase != null && !(rowBase is global::Infragistics.Controls.Grids.Primitives.ChildBand) && !rowBase.AllowKeyboardNavigation)
					{
						if (increase)
						{
							index++;
						}
						else
						{
							index--;
						}
						if (index > -1 && index < num)
						{
							rowBase = grid.Panel.FixedRowsTop[index];
						}
						else
						{
							currentRow = rowBase;
							rowBase = null;
						}
					}
				}
				if (rowBase == null && index >= num && increase)
				{
					rowBase = global::Infragistics.Controls.Grids.Cell.ResolveRow(currentRow, index, increase, navigation);
				}
			}
			else if (index >= num + num3)
			{
				index -= num + num3;
				if (index > -1 && index < num2)
				{
					rowBase = grid.Panel.FixedRowsBottom[num2 - 1 - index];
					while (rowBase != null && !(rowBase is global::Infragistics.Controls.Grids.Row) && !(rowBase is global::Infragistics.Controls.Grids.Primitives.ChildBand) && !rowBase.AllowKeyboardNavigation)
					{
						if (increase)
						{
							index++;
						}
						else
						{
							index--;
						}
						if (index > -1 && index < num2)
						{
							rowBase = grid.Panel.FixedRowsBottom[index];
						}
						else
						{
							rowBase = null;
						}
					}
				}
				if (rowBase == null && index < num + num3 && !increase)
				{
					rowBase = global::Infragistics.Controls.Grids.Cell.ResolveRow(currentRow, index, increase, navigation);
				}
			}
			else
			{
				index -= num;
				if (navigation == global::Infragistics.Controls.Grids.KeyboardNavigation.CurrentLayout)
				{
					rowBase = currentRow.Manager.ResolveRowForIndex(index);
				}
				else
				{
					rowBase = grid.InternalRows[index];
				}
				while (rowBase != null && ((!(rowBase is global::Infragistics.Controls.Grids.Row) && !(rowBase is global::Infragistics.Controls.Grids.Primitives.ChildBand) && (!rowBase.AllowKeyboardNavigation || rowBase.VisibleCells.Count == 0)) || (rowBase is global::Infragistics.Controls.Grids.Row && rowBase.VisibleCells.Count == 0)))
				{
					if (increase)
					{
						index++;
					}
					else
					{
						index--;
					}
					if (navigation == global::Infragistics.Controls.Grids.KeyboardNavigation.CurrentLayout)
					{
						rowBase = currentRow.Manager.ResolveRowForIndex(index);
					}
					else
					{
						rowBase = grid.InternalRows[index];
					}
				}
				if (rowBase == null)
				{
					rowBase = global::Infragistics.Controls.Grids.Cell.ResolveRow(currentRow, index + num, increase, navigation);
				}
			}
			return rowBase;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x000304A8 File Offset: 0x0002E6A8
		private global::Infragistics.Controls.Grids.RowBase ResolveEndTargetCell(global::Infragistics.Controls.Grids.RowsManager manager, global::Infragistics.Controls.Grids.RowBase row)
		{
			int count = manager.Rows.Count;
			int count2 = manager.RegisteredTopRows.Count;
			int count3 = manager.RegisteredBottomRows.Count;
			global::Infragistics.Controls.Grids.RowBase result = null;
			bool flag = true;
			if (row.RowType != global::Infragistics.Controls.Grids.RowType.ColumnLayoutTemplateRow)
			{
				int num = -1;
				int num2 = manager.Rows.IndexOf(row);
				if (num2 == count - 1 || manager.RegisteredBottomRows.IndexOf(row) > -1 || (count == 0 && manager.RegisteredTopRows.IndexOf(row) > -1))
				{
					for (int i = count3 - 1; i >= 0; i--)
					{
						global::Infragistics.Controls.Grids.RowBase rowBase = manager.RegisteredBottomRows[i];
						if (manager.RegisteredBottomRows[i].AllowKeyboardNavigation)
						{
							num = count2 + count + i;
							result = rowBase;
							break;
						}
					}
				}
				if (num == -1 && count > 0)
				{
					num = count - 1;
					result = manager.Rows[num];
					num += count2;
				}
				if (num == -1)
				{
					for (int j = count2 - 1; j >= 0; j--)
					{
						global::Infragistics.Controls.Grids.RowBase rowBase2 = manager.RegisteredTopRows[j];
						if (rowBase2.AllowKeyboardNavigation)
						{
							num = j;
							result = rowBase2;
							break;
						}
					}
				}
				int num3 = manager.RegisteredTopRows.IndexOf(row);
				if (num3 == -1)
				{
					num3 = manager.Rows.IndexOf(row);
					if (num3 == -1)
					{
						num3 = manager.RegisteredBottomRows.IndexOf(row);
						if (num3 == -1)
						{
							throw new global::Infragistics.Controls.Grids.InvalidRowIndexException();
						}
						num3 += count;
					}
					num3 += count2;
				}
				flag = (num3 == num);
			}
			if (flag && manager.Level != 0)
			{
				global::Infragistics.Controls.Grids.RowBase parentRow = manager.ParentRow;
				global::Infragistics.Controls.Grids.Row row2 = parentRow.Manager.ParentRow as global::Infragistics.Controls.Grids.Row;
				manager = (row2.Manager as global::Infragistics.Controls.Grids.RowsManager);
				result = this.ResolveEndTargetCell(manager, row2);
			}
			return result;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00030653 File Offset: 0x0002E853
		private global::Infragistics.Controls.Grids.RowBase ResolveHomeTargetCell(global::Infragistics.Controls.Grids.RowsManager manager, global::Infragistics.Controls.Grids.RowBase row)
		{
			return this.ResolveHomeTargetCell(manager, row, false);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00030660 File Offset: 0x0002E860
		private global::Infragistics.Controls.Grids.RowBase ResolveHomeTargetCell(global::Infragistics.Controls.Grids.RowsManager manager, global::Infragistics.Controls.Grids.RowBase row, bool fromLowerLevel)
		{
			int count = manager.Rows.Count;
			int count2 = manager.RegisteredTopRows.Count;
			int count3 = manager.RegisteredBottomRows.Count;
			global::Infragistics.Controls.Grids.RowBase result = null;
			bool flag = true;
			if (row.RowType != global::Infragistics.Controls.Grids.RowType.ColumnLayoutTemplateRow)
			{
				int num = -1;
				if ((manager.Rows.IndexOf(row) == 0 && !fromLowerLevel) || manager.RegisteredTopRows.IndexOf(row) > -1 || (count == 0 && manager.RegisteredBottomRows.IndexOf(row) > -1))
				{
					for (int i = 0; i < count2; i++)
					{
						global::Infragistics.Controls.Grids.RowBase rowBase = manager.RegisteredTopRows[i];
						if (rowBase.AllowKeyboardNavigation)
						{
							num = i;
							result = rowBase;
							break;
						}
					}
				}
				if (num == -1 && count > 0)
				{
					num = 0;
					result = manager.Rows[0];
					num += count2;
				}
				if (num == -1)
				{
					for (int j = 0; j < count3; j++)
					{
						global::Infragistics.Controls.Grids.RowBase rowBase2 = manager.RegisteredBottomRows[j];
						if (manager.RegisteredBottomRows[j].AllowKeyboardNavigation)
						{
							num = count2 + count + j;
							result = rowBase2;
							break;
						}
					}
				}
				int num2 = manager.RegisteredTopRows.IndexOf(row);
				if (num2 == -1)
				{
					num2 = manager.Rows.IndexOf(row);
					if (num2 == -1)
					{
						num2 = manager.RegisteredBottomRows.IndexOf(row);
						if (num2 == -1)
						{
							if (row.ColumnLayout != null && row.ColumnLayout.Grid != null && row.ColumnLayout.Grid.Panel != null)
							{
								global::Infragistics.Controls.Grids.XamGrid grid = row.ColumnLayout.Grid;
								if (grid.ActiveCell != null && grid.ActiveCell.Row != null && !grid.Panel.VisibleRows.Contains(grid.ActiveCell.Row))
								{
									num2 = base.Row.ColumnLayout.Grid.InternalRows.IndexOf(row);
								}
							}
							if (num2 == -1)
							{
								throw new global::Infragistics.Controls.Grids.InvalidRowIndexException();
							}
						}
						num2 += count;
					}
					num2 += count2;
				}
				flag = (num2 == num);
			}
			if (flag && manager.Level != 0)
			{
				global::Infragistics.Controls.Grids.RowBase parentRow = manager.ParentRow;
				global::Infragistics.Controls.Grids.Row row2 = parentRow.Manager.ParentRow as global::Infragistics.Controls.Grids.Row;
				manager = (row2.Manager as global::Infragistics.Controls.Grids.RowsManager);
				result = this.ResolveHomeTargetCell(manager, row2, true);
			}
			return result;
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0003089C File Offset: 0x0002EA9C
		protected internal virtual void EnterEditMode(bool cellIsEditing)
		{
			if (!this.IsEditable || this.IsEditing || base.Control == null)
			{
				return;
			}
			if (base.Row.ColumnLayout.Grid.ExitEditMode(false))
			{
				if (cellIsEditing)
				{
					base.Row.ColumnLayout.Grid.CurrentEditCell = this;
				}
				((global::Infragistics.Controls.Grids.CellControl)base.Control).AddEditorToControl();
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00030904 File Offset: 0x0002EB04
		protected virtual global::System.Windows.Data.Binding CreateCellValueBinding(bool addValidation)
		{
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Path = new global::System.Windows.PropertyPath(base.Column.Key, new object[0]);
			binding.Source = base.Row.Data;
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.ConverterCulture = global::System.Globalization.CultureInfo.CurrentCulture;
			global::System.Windows.Data.Binding binding2 = binding;
			global::System.Windows.Data.Binding binding3 = binding;
			binding.NotifyOnValidationError = addValidation;
			binding3.ValidatesOnExceptions = addValidation;
			binding2.ValidatesOnDataErrors = addValidation;
			return binding;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00030970 File Offset: 0x0002EB70
		protected internal virtual bool ExitEditMode(object newValue, bool editingCanceled, bool evaluateBindings)
		{
			global::Infragistics.Controls.Grids.CellControl cellControl = (global::Infragistics.Controls.Grids.CellControl)base.Control;
			if (editingCanceled || !cellControl.HasEditingBindings)
			{
				if (base.Column.ResetCellValueObjectAfterEditing)
				{
					global::Infragistics.Controls.Grids.Cell.CellValueObject cellValueObject = new global::Infragistics.Controls.Grids.Cell.CellValueObject();
					global::System.Windows.Data.Binding binding = this.CreateCellValueBinding(false);
					global::Infragistics.Controls.Grids.EditableColumn editableColumn = base.Column as global::Infragistics.Controls.Grids.EditableColumn;
					if (editableColumn != null)
					{
						binding.Converter = editableColumn.EditorValueConverter;
						binding.ConverterParameter = editableColumn.EditorValueConverterParameter;
					}
					cellValueObject.SetBinding(global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty, binding);
					cellValueObject.Value = newValue;
				}
			}
			else if (evaluateBindings && !cellControl.EvaluateEditingBindings())
			{
				return false;
			}
			cellControl.RemoveEditorFromControl();
			global::Infragistics.Controls.Grids.Column column = base.Column;
			while (column.ParentColumn != null)
			{
				column = column.ParentColumn;
			}
			global::Infragistics.Controls.Grids.CellBase cellBase = base.Row.Cells[column];
			if (base.Row.Control != null && !base.Row.Control.VisibleCells.Contains(cellBase) && !base.Row.Control.VisibleFixedLeftCells.Contains(cellBase) && !base.Row.Control.VisibleFixedRightCells.Contains(cellBase))
			{
				base.Row.Control.ReleaseCell(cellBase);
			}
			else
			{
				this.OnElementAttached(base.Control);
				this.EnsureCurrentState();
			}
			return true;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00030AAE File Offset: 0x0002ECAE
		protected internal bool ResetDataValue(object value)
		{
			return this.ResetDataValue(value, true);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00030AB8 File Offset: 0x0002ECB8
		internal bool ResetDataValue(object value, bool validateBinding)
		{
			bool addValidation = validateBinding;
			if (base.Column.UseReadOnlyFlag)
			{
				addValidation = false;
			}
			global::Infragistics.Controls.Grids.CellControl cellControl = (global::Infragistics.Controls.Grids.CellControl)base.Control;
			global::Infragistics.Controls.Grids.Cell.CellValueObject cellValueObject = new global::Infragistics.Controls.Grids.Cell.CellValueObject();
			global::System.Windows.Data.Binding binding = this.CreateCellValueBinding(addValidation);
			cellValueObject.SetBinding(global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty, binding);
			this._bindingError = false;
			global::System.Windows.Controls.Validation.AddErrorHandler(cellValueObject, new global::System.EventHandler<global::System.Windows.Controls.ValidationErrorEventArgs>(this.Element_BindingValidationError));
			global::System.Windows.Data.BindingExpression bindingExpression = cellValueObject.GetBindingExpression(global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty);
			cellValueObject.Value = value;
			if (bindingExpression != null)
			{
				bindingExpression.UpdateSource();
			}
			global::System.Windows.Controls.Validation.RemoveErrorHandler(cellValueObject, new global::System.EventHandler<global::System.Windows.Controls.ValidationErrorEventArgs>(this.Element_BindingValidationError));
			if (this._bindingError)
			{
				cellControl.EvaluateEditingBindings();
			}
			return !this._bindingError;
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00030B5F File Offset: 0x0002ED5F
		protected internal virtual global::System.Windows.Data.IValueConverter CreateCellBindingConverter()
		{
			return new global::Infragistics.Controls.Grids.Cell.CellBindingConverter();
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00030B66 File Offset: 0x0002ED66
		protected virtual bool ResolveIsCellEditable
		{
			get
			{
				return base.Column.DataField.AllowEdit;
			}
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00030B78 File Offset: 0x0002ED78
		internal object ResolveValueFromCell()
		{
			object result;
			if (base.Control != null && base.Control.ContentProvider != null)
			{
				result = base.Control.ContentProvider.ResolveValueFromEditor(this);
			}
			else
			{
				result = this.Value;
			}
			return result;
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00030BB8 File Offset: 0x0002EDB8
		internal void RaiseCellControlAttachedEvent()
		{
			if (base.Row.ColumnLayout != null)
			{
				this.IsDirty = base.Row.ColumnLayout.Grid.OnCellControlAttached(this);
			}
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00030BE3 File Offset: 0x0002EDE3
		private void Element_BindingValidationError(object sender, global::System.Windows.Controls.ValidationErrorEventArgs e)
		{
			if (e.Action == global::System.Windows.Controls.ValidationErrorEventAction.Added)
			{
				this._bindingError = true;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00030BF4 File Offset: 0x0002EDF4
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00030BF8 File Offset: 0x0002EDF8
		protected override string RecyclingIdentifier
		{
			get
			{
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.Column.ColumnLayout;
				if (columnLayout.Grid != null && columnLayout.Grid.Panel != null && ((columnLayout.Grid.CellControlGenerationModeInternal == global::Infragistics.Controls.Grids.CellControlGenerationMode.Recycle && !columnLayout.Grid.IsCellControlGenerationModeJustChanged) || (columnLayout.Grid.CellControlGenerationMode == global::Infragistics.Controls.Grids.CellControlGenerationMode.Virtualize && columnLayout.Grid.IsCellControlGenerationModeJustChanged)))
				{
					return string.Concat(new string[]
					{
						base.Row.RowType.ToString(),
						"_",
						base.Column.TypeName,
						"_",
						base.Column.ColumnLayout.Key
					});
				}
				return string.Concat(new string[]
				{
					base.Row.RowType.ToString(),
					"_",
					base.Column.Key,
					"_",
					base.Column.TypeName,
					"_",
					base.Column.ColumnLayout.Key
				});
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x00030D24 File Offset: 0x0002EF24
		public override object Value
		{
			get
			{
				object result = null;
				if (base.Row.Data != null && base.Column.Key != null)
				{
					global::Infragistics.Controls.Grids.Cell.CellValueObject cellValueObject = new global::Infragistics.Controls.Grids.Cell.CellValueObject();
					global::System.Windows.Data.Binding binding = global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.ResolveBindingInternal(this);
					if (binding != null)
					{
						binding.Mode = global::System.Windows.Data.BindingMode.OneTime;
						binding.Source = base.Row.Data;
						binding.Converter = base.Column.ValueConverter;
						binding.ConverterParameter = base.Column.ValueConverterParameter;
						cellValueObject.SetBinding(global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty, binding);
						result = cellValueObject.Value;
					}
				}
				return result;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x00030DAC File Offset: 0x0002EFAC
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				global::Infragistics.Controls.Grids.Row row = base.Row as global::Infragistics.Controls.Grids.Row;
				if (row != null && row.CellStyle != null)
				{
					return row.CellStyle;
				}
				return base.Column.CellStyleResolved;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00030DF4 File Offset: 0x0002EFF4
		public override bool IsEditable
		{
			get
			{
				global::Infragistics.Controls.Grids.Column column = base.Column;
				bool resolveIsCellEditable = this.ResolveIsCellEditable;
				if (!column.UseReadOnlyFlag)
				{
					return column.IsEditable;
				}
				if (resolveIsCellEditable && column.CachedPropertyReadOnly == null)
				{
					object data = base.Row.Data;
					if (column.Key != null && data != null)
					{
						global::System.Reflection.PropertyInfo propertyInfo = global::Infragistics.DataManagerBase.ResolvePropertyInfoFromPropertyPath(base.Column.Key, data);
						column.CachedPropertyReadOnly = new bool?(!(propertyInfo == null) && propertyInfo.GetSetMethod() == null);
					}
				}
				return resolveIsCellEditable && column.IsEditable && column.CachedPropertyReadOnly != null && !column.CachedPropertyReadOnly.Value;
			}
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00030EB0 File Offset: 0x0002F0B0
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.CellControl();
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00030EB8 File Offset: 0x0002F0B8
		protected internal override bool HandleKeyDown(global::System.Windows.Input.Key key, int platformKey)
		{
			bool result = false;
			global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase expandableRowBase = base.Row as global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase;
			global::Infragistics.Controls.Grids.XamGrid grid = base.Row.ColumnLayout.Grid;
			grid.LastKeyDown = key;
			global::Infragistics.Controls.Grids.KeyboardNavigation keyboardNavigation = grid.KeyboardNavigation;
			bool flag = false;
			int num = global::Infragistics.Controls.Grids.Cell.ResolveRowIndex(expandableRowBase, keyboardNavigation == global::Infragistics.Controls.Grids.KeyboardNavigation.CurrentLayout && (key == global::System.Windows.Input.Key.Up || key == global::System.Windows.Input.Key.Down));
			int num2 = (keyboardNavigation == global::Infragistics.Controls.Grids.KeyboardNavigation.CurrentLayout) ? expandableRowBase.Manager.FullRowCount : grid.InternalRows.Count;
			if (expandableRowBase.Level == 0)
			{
				num2 += grid.Panel.FixedRowsTop.Count + grid.Panel.FixedRowsBottom.Count;
			}
			global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells = expandableRowBase.VisibleCells;
			int num3 = visibleCells.IndexOf(this);
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allDataColumnsCache = base.Row.ColumnLayout.Columns.AllDataColumnsCache;
			int num4 = allDataColumnsCache.IndexOf(base.Column);
			if (num4 < 0)
			{
				num4 = 0;
			}
			if (platformKey == 187)
			{
				key = global::System.Windows.Input.Key.Add;
			}
			else if (platformKey == 189)
			{
				key = global::System.Windows.Input.Key.Subtract;
			}
			if (grid.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
			{
				if (key == global::System.Windows.Input.Key.Left)
				{
					key = global::System.Windows.Input.Key.Right;
				}
				else if (key == global::System.Windows.Input.Key.Right)
				{
					key = global::System.Windows.Input.Key.Left;
				}
			}
			if (global::Infragistics.PlatformProxy.GetTabNavigation(grid) != global::System.Windows.Input.KeyboardNavigationMode.Once && key == global::System.Windows.Input.Key.Tab)
			{
				global::System.Windows.Input.ModifierKeys currentModifierKeys = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
				bool flag2 = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None;
				if (flag2)
				{
					key = global::System.Windows.Input.Key.Left;
				}
				else
				{
					key = global::System.Windows.Input.Key.Right;
				}
			}
			global::Infragistics.Controls.Grids.CellBase cellBase = null;
			global::Infragistics.Controls.Grids.EditingSettingsBaseOverride editingSettings = this.EditingSettings;
			global::Infragistics.Controls.Grids.EditingType editingType = editingSettings.ResolveEditingType();
			global::Infragistics.Controls.Grids.CustomDisplayEditableColumn customDisplayEditableColumn = base.Column as global::Infragistics.Controls.Grids.CustomDisplayEditableColumn;
			global::System.Windows.Input.Key key2 = key;
			if (key2 <= global::System.Windows.Input.Key.Down)
			{
				if (key2 != global::System.Windows.Input.Key.Return)
				{
					switch (key2)
					{
					case global::System.Windows.Input.Key.Escape:
						if (this.IsEditing)
						{
							grid.ExitEditModeInternal(true, global::Infragistics.Controls.Grids.ExitEditModeBehavior.SemiForceful);
							result = true;
						}
						break;
					case global::System.Windows.Input.Key.Space:
						if (!this.IsEditing)
						{
							grid.SelectCell(this, global::Infragistics.Controls.Grids.InvokeAction.Click);
						}
						break;
					case global::System.Windows.Input.Key.End:
						if (num3 != visibleCells.Count - 1)
						{
							cellBase = visibleCells[visibleCells.Count - 1];
						}
						else
						{
							global::Infragistics.Controls.Grids.RowsManager rowsManager = expandableRowBase.Manager as global::Infragistics.Controls.Grids.RowsManager;
							if (rowsManager != null)
							{
								global::Infragistics.Controls.Grids.RowBase rowBase = this.ResolveEndTargetCell(rowsManager, expandableRowBase);
								if (rowBase != null)
								{
									global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells2 = rowBase.VisibleCells;
									if (visibleCells2.Count > 0)
									{
										cellBase = visibleCells2[visibleCells2.Count - 1];
									}
								}
							}
							else
							{
								global::Infragistics.Controls.Grids.Row row = expandableRowBase.Manager.ParentRow as global::Infragistics.Controls.Grids.Row;
								rowsManager = (row.Manager as global::Infragistics.Controls.Grids.RowsManager);
								global::Infragistics.Controls.Grids.RowBase rowBase2 = this.ResolveEndTargetCell(rowsManager, row);
								global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells3 = rowBase2.VisibleCells;
								if (visibleCells3.Count > 0)
								{
									cellBase = visibleCells3[visibleCells3.Count - 1];
								}
							}
						}
						break;
					case global::System.Windows.Input.Key.Home:
						if (num3 != 0)
						{
							cellBase = visibleCells[0];
						}
						else
						{
							global::Infragistics.Controls.Grids.RowsManager rowsManager2 = expandableRowBase.Manager as global::Infragistics.Controls.Grids.RowsManager;
							if (rowsManager2 != null)
							{
								global::Infragistics.Controls.Grids.RowBase rowBase3 = this.ResolveHomeTargetCell(rowsManager2, expandableRowBase);
								if (rowBase3 != null)
								{
									global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells4 = rowBase3.VisibleCells;
									if (visibleCells4.Count > 0)
									{
										cellBase = visibleCells4[0];
									}
								}
							}
							else
							{
								global::Infragistics.Controls.Grids.Row row2 = expandableRowBase.Manager.ParentRow as global::Infragistics.Controls.Grids.Row;
								rowsManager2 = (row2.Manager as global::Infragistics.Controls.Grids.RowsManager);
								global::Infragistics.Controls.Grids.RowBase rowBase4 = this.ResolveHomeTargetCell(rowsManager2, row2);
								global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells5 = rowBase4.VisibleCells;
								if (visibleCells5.Count > 0)
								{
									cellBase = visibleCells5[0];
								}
							}
						}
						break;
					case global::System.Windows.Input.Key.Left:
						if (num3 > 0)
						{
							cellBase = visibleCells[num3 - 1];
						}
						else if (grid.KeyboardNavigation == global::Infragistics.Controls.Grids.KeyboardNavigation.CurrentLayout)
						{
							global::Infragistics.Controls.Grids.RowBase rowBase5 = global::Infragistics.Controls.Grids.Cell.ResolveRow(base.Row, num - 1, false, global::Infragistics.Controls.Grids.KeyboardNavigation.AllLayouts);
							if (rowBase5 != null)
							{
								global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells6 = rowBase5.VisibleCells;
								cellBase = visibleCells6[visibleCells6.Count - 1];
							}
							else
							{
								flag = true;
							}
						}
						else if (num > 0)
						{
							global::Infragistics.Controls.Grids.RowBase rowBase6 = global::Infragistics.Controls.Grids.Cell.ResolveRow(base.Row, num - 1, false, keyboardNavigation);
							if (rowBase6 != null)
							{
								global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells7 = rowBase6.VisibleCells;
								cellBase = visibleCells7[visibleCells7.Count - 1];
							}
							else
							{
								flag = true;
							}
						}
						break;
					case global::System.Windows.Input.Key.Up:
						if (num > 0)
						{
							global::Infragistics.Controls.Grids.RowBase rowBase7 = global::Infragistics.Controls.Grids.Cell.ResolveRow(base.Row, num - 1, false, keyboardNavigation);
							if (rowBase7 != null)
							{
								global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells8 = rowBase7.VisibleCells;
								if (num4 >= visibleCells8.Count)
								{
									num4 = visibleCells8.Count - 1;
								}
								cellBase = visibleCells8[num4];
							}
						}
						break;
					case global::System.Windows.Input.Key.Right:
						if (num3 < visibleCells.Count - 1)
						{
							cellBase = visibleCells[num3 + 1];
						}
						else if (grid.KeyboardNavigation == global::Infragistics.Controls.Grids.KeyboardNavigation.CurrentLayout)
						{
							global::Infragistics.Controls.Grids.RowBase rowBase8 = global::Infragistics.Controls.Grids.Cell.ResolveRow(base.Row, num + 1, true, global::Infragistics.Controls.Grids.KeyboardNavigation.AllLayouts);
							if (rowBase8 != null)
							{
								cellBase = rowBase8.VisibleCells[0];
							}
							else
							{
								flag = true;
							}
						}
						else if (num < num2 - 1)
						{
							global::Infragistics.Controls.Grids.RowBase rowBase9 = global::Infragistics.Controls.Grids.Cell.ResolveRow(base.Row, num + 1, true, keyboardNavigation);
							if (rowBase9 != null)
							{
								cellBase = rowBase9.VisibleCells[0];
							}
							else
							{
								flag = true;
							}
						}
						break;
					case global::System.Windows.Input.Key.Down:
						if (num < num2 - 1)
						{
							global::Infragistics.Controls.Grids.RowBase rowBase10 = global::Infragistics.Controls.Grids.Cell.ResolveRow(base.Row, num + 1, true, keyboardNavigation);
							if (rowBase10 != null)
							{
								global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells9 = rowBase10.VisibleCells;
								if (num4 >= visibleCells9.Count)
								{
									num4 = visibleCells9.Count - 1;
								}
								cellBase = visibleCells9[num4];
							}
						}
						break;
					}
				}
				else if (this.IsEditing)
				{
					grid.ExitEditMode(false);
					result = true;
				}
				else if (!this.IsEditing && editingSettings.IsEnterKeyEditingEnabledResolved && editingType != global::Infragistics.Controls.Grids.EditingType.None && (customDisplayEditableColumn == null || customDisplayEditableColumn.EditorDisplayBehavior != global::Infragistics.Controls.Grids.EditorDisplayBehaviors.Always))
				{
					if (editingType == global::Infragistics.Controls.Grids.EditingType.Cell || (editingType == global::Infragistics.Controls.Grids.EditingType.Hover && grid.RowHover == global::Infragistics.Controls.Grids.RowHoverType.Cell))
					{
						grid.EnterEditMode(this);
					}
					else
					{
						grid.EnterEditMode((global::Infragistics.Controls.Grids.Row)base.Row, this);
					}
					result = true;
				}
			}
			else
			{
				switch (key2)
				{
				case global::System.Windows.Input.Key.Add:
					if (expandableRowBase.HasChildren && !this.IsEditing)
					{
						expandableRowBase.IsExpanded = true;
						result = true;
					}
					break;
				case global::System.Windows.Input.Key.Separator:
					break;
				case global::System.Windows.Input.Key.Subtract:
					if (expandableRowBase.HasChildren && !this.IsEditing)
					{
						result = true;
						expandableRowBase.IsExpanded = false;
					}
					break;
				default:
					if (key2 == global::System.Windows.Input.Key.F2)
					{
						if (!this.IsEditing && editingSettings.IsF2EditingEnabledResolved && editingType != global::Infragistics.Controls.Grids.EditingType.None)
						{
							if (editingType == global::Infragistics.Controls.Grids.EditingType.Cell || (editingType == global::Infragistics.Controls.Grids.EditingType.Hover && grid.RowHover == global::Infragistics.Controls.Grids.RowHoverType.Cell))
							{
								grid.EnterEditMode(this);
							}
							else
							{
								grid.EnterEditMode((global::Infragistics.Controls.Grids.Row)base.Row, this);
							}
							result = true;
						}
					}
					break;
				}
			}
			if (cellBase != null)
			{
				grid.SetActiveCell(cellBase, global::Infragistics.Controls.Grids.CellAlignment.NotSet, global::Infragistics.Controls.Grids.InvokeAction.Keyboard);
				result = true;
			}
			else if (flag && this.IsEditing)
			{
				result = grid.ExitEditMode(false);
			}
			return result;
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00031550 File Offset: 0x0002F750
		protected internal override void EnsureCurrentState()
		{
			if (base.Control != null)
			{
				global::Infragistics.Controls.Grids.Row row = base.Row as global::Infragistics.Controls.Grids.Row;
				global::Infragistics.Controls.Grids.Column column = base.Column;
				bool flag = false;
				if (row != null)
				{
					if ((column != null && column.IsSelected) || row.IsSelected)
					{
						base.Control.GoToState("NotSelected", false);
						base.Control.GoToState("InActive", false);
						base.Control.GoToState("Selected", false);
						flag = true;
					}
					else if (this.IsSelected)
					{
						base.Control.GoToState("NotSelected", false);
						base.Control.GoToState("InActive", false);
						base.Control.GoToState("Selected", false);
						flag = true;
					}
					else
					{
						base.Control.GoToState("NotSelected", false);
					}
				}
				else
				{
					base.Control.GoToState(this.NormalState, false);
				}
				if (base.Row != null)
				{
					if (base.Row.ColumnLayout == null)
					{
						return;
					}
					if (base.Row.IsMouseOverInternal && base.Row.ResolveRowHover != global::Infragistics.Controls.Grids.RowHoverType.None && (base.Row.ResolveRowHover == global::Infragistics.Controls.Grids.RowHoverType.Row || this == base.Row.ColumnLayout.Grid.MouseOverCellInternal))
					{
						base.Control.GoToState(this.MouseOverState, true);
					}
					else
					{
						base.Control.GoToState(this.NormalState, false);
					}
					if (this == base.Row.ColumnLayout.Grid.ActiveCell)
					{
						base.Control.GoToState("Active", false);
					}
					else if (!flag)
					{
						base.Control.GoToState("InActive", false);
					}
				}
				if (column != null)
				{
					if (column.IsFixed != global::Infragistics.Controls.Grids.FixedState.NotFixed)
					{
						base.Control.GoToState("Fixed", false);
					}
					else
					{
						base.Control.GoToState("Unfixed", false);
					}
				}
				global::Infragistics.Controls.Grids.XamGrid grid = base.Row.ColumnLayout.Grid;
				if (grid.CurrentEditRow == base.Row || grid.CurrentEditCell == this)
				{
					base.Control.GoToState("Editing", false);
					return;
				}
				base.Control.GoToState("NotEditing", false);
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0003177C File Offset: 0x0002F97C
		protected internal override global::Infragistics.Controls.Grids.DragSelectType OnCellMouseDown(global::System.Windows.Input.MouseEventArgs e)
		{
			bool handled = ((global::System.Windows.Input.MouseButtonEventArgs)e).Handled;
			global::Infragistics.Controls.Grids.DragSelectType? dragSelectType = this.OnCellMouseDownImpl(ref handled);
			((global::System.Windows.Input.MouseButtonEventArgs)e).Handled = handled;
			if (dragSelectType != null)
			{
				return dragSelectType.Value;
			}
			return base.OnCellMouseDown(e);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x000317C2 File Offset: 0x0002F9C2
		protected internal override void OnCellMouseUp(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnCellMouseUp(e);
			this._suppressSelection = false;
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000317D4 File Offset: 0x0002F9D4
		private global::Infragistics.Controls.Grids.DragSelectType? OnCellMouseDownImpl(ref bool handled)
		{
			if (base.Column is global::Infragistics.Controls.Grids.Primitives.FillerColumn)
			{
				return null;
			}
			global::Infragistics.Controls.Grids.XamGrid grid = base.Row.ColumnLayout.Grid;
			if (!base.Control.IsResizing)
			{
				global::Infragistics.Controls.Grids.CellBase activeCell = grid.ActiveCell;
				grid.SetActiveCell(this, global::Infragistics.Controls.Grids.CellAlignment.NotSet, global::Infragistics.Controls.Grids.InvokeAction.Click, false);
				if (!base.IsActive)
				{
					this._suppressSelection = true;
				}
				handled = true;
				if (grid.ActiveCell == activeCell && (grid.CurrentEditCell != null || grid.CurrentEditRow != null))
				{
					return new global::Infragistics.Controls.Grids.DragSelectType?(global::Infragistics.Controls.Grids.DragSelectType.None);
				}
			}
			if (!this._suppressSelection && grid.SelectCell(this, global::Infragistics.Controls.Grids.InvokeAction.Click))
			{
				return new global::Infragistics.Controls.Grids.DragSelectType?(global::Infragistics.Controls.Grids.DragSelectType.None);
			}
			return new global::Infragistics.Controls.Grids.DragSelectType?(global::Infragistics.Controls.Grids.DragSelectType.Cell);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0003187C File Offset: 0x0002FA7C
		protected internal override void OnCellDragging(global::Infragistics.Controls.Grids.DragSelectType type)
		{
			base.OnCellDragging(type);
			if (!(base.Column is global::Infragistics.Controls.Grids.Primitives.FillerColumn) && !this._suppressSelection)
			{
				if (type == global::Infragistics.Controls.Grids.DragSelectType.Row)
				{
					base.Row.ColumnLayout.Grid.SelectRow(base.Row as global::Infragistics.Controls.Grids.Row, global::Infragistics.Controls.Grids.XamGrid.GetMovedAction());
					return;
				}
				base.Row.ColumnLayout.Grid.SelectCell(this, global::Infragistics.Controls.Grids.XamGrid.GetMovedAction());
			}
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x000318EC File Offset: 0x0002FAEC
		protected internal override void OnCellClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.OnCellClickImpl();
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x000318F4 File Offset: 0x0002FAF4
		private void OnCellClickImpl()
		{
			base.Row.ColumnLayout.Grid.OnCellClicked(this);
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.Row.ColumnLayout;
			global::Infragistics.Controls.Grids.EditingSettingsBaseOverride editingSettings = this.EditingSettings;
			if (editingSettings.IsMouseActionEditingEnabledResolved == global::Infragistics.Controls.Grids.MouseEditingAction.SingleClick)
			{
				global::Infragistics.Controls.Grids.Row row = base.Row as global::Infragistics.Controls.Grids.Row;
				if (row != null)
				{
					global::Infragistics.Controls.Grids.EditingType editingType = editingSettings.ResolveEditingType();
					bool flag = false;
					global::Infragistics.Controls.Grids.CustomDisplayEditableColumn customDisplayEditableColumn = base.Column as global::Infragistics.Controls.Grids.CustomDisplayEditableColumn;
					if (customDisplayEditableColumn != null && this.EnableCustomEditorBehaviors && customDisplayEditableColumn.EditorDisplayBehavior == global::Infragistics.Controls.Grids.EditorDisplayBehaviors.Always)
					{
						flag = true;
					}
					if (!flag)
					{
						if (editingType == global::Infragistics.Controls.Grids.EditingType.Cell)
						{
							columnLayout.Grid.EnterEditMode(this);
							return;
						}
						if (editingType == global::Infragistics.Controls.Grids.EditingType.Row)
						{
							columnLayout.Grid.EnterEditMode(row, this);
						}
					}
				}
			}
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00031999 File Offset: 0x0002FB99
		protected internal override void OnCellDoubleClick()
		{
			base.Row.ColumnLayout.Grid.OnCellDoubleClicked(this);
			this.OnCellDoubleClickImpl();
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x000319B8 File Offset: 0x0002FBB8
		private void OnCellDoubleClickImpl()
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.Row.ColumnLayout;
			global::Infragistics.Controls.Grids.EditingSettingsBaseOverride editingSettings = this.EditingSettings;
			if (editingSettings.IsMouseActionEditingEnabledResolved == global::Infragistics.Controls.Grids.MouseEditingAction.DoubleClick)
			{
				global::Infragistics.Controls.Grids.Row row = base.Row as global::Infragistics.Controls.Grids.Row;
				if (row != null)
				{
					if (base.Control != null && base.Control.AllowUserResizing)
					{
						return;
					}
					global::Infragistics.Controls.Grids.EditingType editingType = editingSettings.ResolveEditingType();
					if (editingType == global::Infragistics.Controls.Grids.EditingType.Cell)
					{
						columnLayout.Grid.EnterEditMode(this);
						return;
					}
					if (editingType == global::Infragistics.Controls.Grids.EditingType.Row)
					{
						columnLayout.Grid.EnterEditMode(row, this);
					}
				}
			}
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00031A31 File Offset: 0x0002FC31
		protected internal override void SetSelected(bool isSelected)
		{
			this._isSelected = isSelected;
			if (base.Row.ColumnLayout != null)
			{
				base.Row.ColumnLayout.Grid.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00031A60 File Offset: 0x0002FC60
		protected override bool OnElementReleasing(global::Infragistics.Controls.Grids.Primitives.CellControlBase element)
		{
			return base.Row.ColumnLayout == null || base.Row.ColumnLayout.Grid == null || (!this.IsEditing && (!this.IsEditable || base.Row != base.Row.ColumnLayout.Grid.CurrentEditRow));
		}

		// Token: 0x04000463 RID: 1123
		private bool _isSelected;

		// Token: 0x04000464 RID: 1124
		private bool _bindingError;

		// Token: 0x04000465 RID: 1125
		private bool _suppressSelection;

		// Token: 0x020001E1 RID: 481
		internal class CellValueObject : global::System.Windows.FrameworkElement
		{
			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00031AC2 File Offset: 0x0002FCC2
			// (set) Token: 0x06000D54 RID: 3412 RVA: 0x00031ACF File Offset: 0x0002FCCF
			public object Value
			{
				get
				{
					return base.GetValue(global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty);
				}
				set
				{
					base.SetValue(global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty, value);
				}
			}

			// Token: 0x06000D55 RID: 3413 RVA: 0x00031ADD File Offset: 0x0002FCDD
			private static void ValueChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
			}

			// Token: 0x04000467 RID: 1127
			public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.Controls.Grids.Cell.CellValueObject), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueChanged)));
		}

		// Token: 0x020001E2 RID: 482
		internal class CellEditingBindingConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x06000D58 RID: 3416 RVA: 0x00031B20 File Offset: 0x0002FD20
			public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				global::Infragistics.Controls.Grids.Cell cell = (global::Infragistics.Controls.Grids.Cell)parameter;
				global::Infragistics.Controls.Grids.EditableColumn editableColumn = cell.ResolveColumn as global::Infragistics.Controls.Grids.EditableColumn;
				if (editableColumn != null)
				{
					if (editableColumn.EditorValueConverter != null)
					{
						return editableColumn.EditorValueConverter.Convert(value, targetType, editableColumn.EditorValueConverterParameter, culture);
					}
					if (editableColumn.DataField.ApplyFormatStringInEditMode)
					{
						return cell.Control.ContentProvider.ApplyFormatting(value, editableColumn, culture);
					}
				}
				return value;
			}

			// Token: 0x06000D59 RID: 3417 RVA: 0x00031B84 File Offset: 0x0002FD84
			public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				global::Infragistics.Controls.Grids.Cell cell = (global::Infragistics.Controls.Grids.Cell)parameter;
				global::Infragistics.Controls.Grids.EditableColumn editableColumn = cell.ResolveColumn as global::Infragistics.Controls.Grids.EditableColumn;
				if (editableColumn != null && editableColumn.EditorValueConverter != null)
				{
					value = editableColumn.EditorValueConverter.ConvertBack(value, targetType, editableColumn.EditorValueConverterParameter, culture);
				}
				bool isGenericType = targetType.IsGenericType;
				if (targetType != null && isGenericType && targetType.GetGenericTypeDefinition() == typeof(global::System.Nullable<>) && (value == null || !targetType.IsAssignableFrom(value.GetType())))
				{
					string value2 = value as string;
					if (string.IsNullOrEmpty(value2))
					{
						value = null;
					}
				}
				if (editableColumn != null && editableColumn.DataField.ConvertEmptyStringToNull)
				{
					string text = value as string;
					if (text != null && text.Length == 0)
					{
						value = null;
					}
				}
				return value;
			}
		}

		// Token: 0x020001E3 RID: 483
		internal class CellBindingConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x06000D5B RID: 3419 RVA: 0x00031C44 File Offset: 0x0002FE44
			public virtual object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				global::Infragistics.Controls.Grids.Primitives.CellControlBase cellControlBase = (global::Infragistics.Controls.Grids.Primitives.CellControlBase)parameter;
				global::Infragistics.Controls.Grids.Cell cell = (global::Infragistics.Controls.Grids.Cell)cellControlBase.Cell;
				if (cell != null)
				{
					bool flag = cell.Control == null;
					if (flag)
					{
						cell.Control = cellControlBase;
					}
					cell.RaiseCellControlAttachedEvent();
					global::Infragistics.Controls.Grids.Column resolveColumn = cell.ResolveColumn;
					if (resolveColumn.ValueConverter != null)
					{
						value = resolveColumn.ValueConverter.Convert(value, targetType, resolveColumn.ValueConverterParameter, culture);
					}
					else if (cellControlBase.ContentProvider != null)
					{
						value = cellControlBase.ContentProvider.ApplyFormatting(value, resolveColumn, culture);
					}
					if (value == null && !string.IsNullOrEmpty(resolveColumn.DataField.NullDisplayText))
					{
						value = resolveColumn.DataField.NullDisplayText;
					}
					if (flag)
					{
						cell.Control = null;
					}
				}
				return value;
			}

			// Token: 0x06000D5C RID: 3420 RVA: 0x00031CF4 File Offset: 0x0002FEF4
			public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				global::Infragistics.Controls.Grids.Primitives.CellControlBase cellControlBase = (global::Infragistics.Controls.Grids.Primitives.CellControlBase)parameter;
				global::Infragistics.Controls.Grids.Cell cell = (global::Infragistics.Controls.Grids.Cell)cellControlBase.Cell;
				if (cell != null)
				{
					global::Infragistics.Controls.Grids.Column resolveColumn = cell.ResolveColumn;
					if (resolveColumn.ValueConverter != null)
					{
						value = resolveColumn.ValueConverter.ConvertBack(value, targetType, resolveColumn.ValueConverterParameter, culture);
					}
					if (resolveColumn.DataField.ConvertEmptyStringToNull)
					{
						string text = value as string;
						if (text != null && text.Length == 0)
						{
							value = null;
						}
					}
				}
				return value;
			}
		}
	}
}
