using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000237 RID: 567
	public abstract class ColumnContentProviderBase
	{
		// Token: 0x060010D1 RID: 4305
		public abstract global::System.Windows.FrameworkElement ResolveDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding);

		// Token: 0x060010D2 RID: 4306 RVA: 0x0003E4CE File Offset: 0x0003C6CE
		public virtual void AdjustDisplayElement(global::Infragistics.Controls.Grids.Cell cell)
		{
		}

		// Token: 0x060010D3 RID: 4307
		public abstract object ResolveValueFromEditor(global::Infragistics.Controls.Grids.Cell cell);

		// Token: 0x060010D4 RID: 4308 RVA: 0x0003E4D0 File Offset: 0x0003C6D0
		public virtual global::System.Windows.FrameworkElement GenerateGroupByCellContent(global::Infragistics.Controls.Grids.Primitives.GroupByCell cell, global::System.Windows.Data.Binding cellBinding)
		{
			return null;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0003E4D3 File Offset: 0x0003C6D3
		public virtual void EditorLoaded()
		{
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0003E4D5 File Offset: 0x0003C6D5
		public virtual object ApplyFormatting(object value, global::Infragistics.Controls.Grids.Column column, global::System.Globalization.CultureInfo culture)
		{
			return value;
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0003E4D8 File Offset: 0x0003C6D8
		public global::System.Windows.FrameworkElement ResolveEditor(global::Infragistics.Controls.Grids.Cell cell, global::System.Action<object> valueChangedFunction, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			this._valueChangedFunction = valueChangedFunction;
			return this.ResolveEditorControlInternal(cell, editorValue, availableWidth, availableHeight, editorBinding);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0003E4EF File Offset: 0x0003C6EF
		public virtual void EditorRemoved()
		{
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0003E4F1 File Offset: 0x0003C6F1
		public virtual void ResetContent()
		{
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0003E4F3 File Offset: 0x0003C6F3
		protected void NotifyEditorValueChanged(object value)
		{
			if (this._valueChangedFunction != null)
			{
				this._valueChangedFunction(value);
			}
		}

		// Token: 0x060010DB RID: 4315
		protected abstract global::System.Windows.FrameworkElement ResolveEditorControl(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding);

		// Token: 0x060010DC RID: 4316 RVA: 0x0003E50C File Offset: 0x0003C70C
		protected internal virtual global::System.Windows.Data.Binding ResolveBinding(global::Infragistics.Controls.Grids.Cell cell)
		{
			global::System.Windows.Data.Binding binding = null;
			if (cell != null)
			{
				if (cell.Control != null)
				{
					binding = cell.Control.ResolveBinding();
				}
				if (binding == null)
				{
					binding = global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.ResolveBindingInternal(cell);
				}
			}
			return binding;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0003E540 File Offset: 0x0003C740
		protected internal virtual global::System.Windows.Data.Binding ResolveEditorBinding(global::Infragistics.Controls.Grids.Cell cell)
		{
			global::System.Windows.Data.Binding binding = null;
			if (cell.Control != null)
			{
				binding = cell.Control.ResolveEditorBinding();
			}
			if (binding == null)
			{
				object data = cell.Row.Data;
				if (cell.Column.Key != null && data != null)
				{
					binding = new global::System.Windows.Data.Binding();
					binding.Path = new global::System.Windows.PropertyPath(cell.Column.Key, new object[0]);
					binding.Source = data;
					binding.ConverterCulture = global::System.Globalization.CultureInfo.CurrentCulture;
					binding.UpdateSourceTrigger = global::System.Windows.Data.UpdateSourceTrigger.Explicit;
					binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
					binding.ConverterParameter = cell;
					binding.Converter = new global::Infragistics.Controls.Grids.Cell.CellEditingBindingConverter();
					global::Infragistics.Controls.Grids.EditableColumn editableColumn = cell.Column as global::Infragistics.Controls.Grids.EditableColumn;
					if (editableColumn != null)
					{
						binding.ValidatesOnDataErrors = (binding.ValidatesOnExceptions = (binding.NotifyOnValidationError = editableColumn.AllowEditingValidation));
					}
				}
			}
			return binding;
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0003E610 File Offset: 0x0003C810
		protected internal virtual global::System.Windows.FrameworkElement ResolveDisplayElementInternal(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow)
			{
				global::System.Windows.FrameworkElement frameworkElement = this.ApplyAddNewRowItemTemplate(cell);
				if (frameworkElement != null)
				{
					return frameworkElement;
				}
			}
			return this.ResolveDisplayElement(cell, cellBinding);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0003E640 File Offset: 0x0003C840
		protected internal virtual global::System.Windows.FrameworkElement ResolveDisplayElementInternal(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding, global::Infragistics.Controls.Grids.RowType rowType)
		{
			if (rowType == global::Infragistics.Controls.Grids.RowType.AddNewRow)
			{
				global::System.Windows.FrameworkElement frameworkElement = this.ApplyAddNewRowItemTemplate(cell);
				if (frameworkElement != null)
				{
					return frameworkElement;
				}
			}
			return this.ResolveDisplayElement(cell, cellBinding);
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0003E668 File Offset: 0x0003C868
		protected virtual global::System.Windows.FrameworkElement ApplyAddNewRowItemTemplate(global::Infragistics.Controls.Grids.Cell cell)
		{
			global::System.Windows.FrameworkElement result = null;
			global::Infragistics.Controls.Grids.Column column = cell.Column;
			if (column != null && column.AddNewRowItemTemplate != null)
			{
				result = (column.AddNewRowItemTemplate.LoadContent() as global::System.Windows.FrameworkElement);
			}
			return result;
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0003E69C File Offset: 0x0003C89C
		protected internal virtual global::System.Windows.FrameworkElement ResolveEditorControlInternal(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow)
			{
				global::System.Windows.FrameworkElement frameworkElement = this.ApplyAddNewRowEditorTemplate(cell, editorValue, availableWidth, availableHeight, editorBinding);
				if (frameworkElement != null)
				{
					if (cell.Control != null)
					{
						cell.Control.VerticalContentAlignment = global::System.Windows.VerticalAlignment.Stretch;
						cell.Control.HorizontalContentAlignment = global::System.Windows.HorizontalAlignment.Stretch;
					}
					return frameworkElement;
				}
			}
			global::Infragistics.Controls.Grids.XamGrid grid = cell.Column.ColumnLayout.Grid;
			if (grid.EditingSettings.AllowEditing == global::Infragistics.Controls.Grids.EditingType.Row && !grid.EditCellValues.ContainsKey(cell.Column.Key))
			{
				grid.EditCellValues.Add(cell.Column.Key, cell.Value);
				grid.OriginalCellValues.Add(cell.Column.Key, cell.Value);
			}
			return this.ResolveEditorControl(cell, editorValue, availableWidth, availableHeight, editorBinding);
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0003E768 File Offset: 0x0003C968
		protected virtual global::System.Windows.FrameworkElement ApplyAddNewRowEditorTemplate(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			global::System.Windows.FrameworkElement result = null;
			global::Infragistics.Controls.Grids.Column column = cell.Column;
			if (column != null && column.AddNewRowEditorTemplate != null)
			{
				result = (column.AddNewRowEditorTemplate.LoadContent() as global::System.Windows.FrameworkElement);
			}
			return result;
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0003E79B File Offset: 0x0003C99B
		protected internal virtual void FocusEditor()
		{
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0003E7A0 File Offset: 0x0003C9A0
		internal static global::System.Windows.Data.Binding ResolveBindingInternal(global::Infragistics.Controls.Grids.Cell cell)
		{
			global::System.Windows.Data.Binding binding = null;
			if (cell.Column.Key != null && cell.Column.DataType != null)
			{
				if (cell.Column is global::Infragistics.Controls.Grids.UnboundColumn)
				{
					binding = new global::System.Windows.Data.Binding();
				}
				else
				{
					binding = new global::System.Windows.Data.Binding();
					binding.Path = new global::System.Windows.PropertyPath(cell.Column.Key, new object[0]);
				}
				binding.ConverterCulture = global::System.Globalization.CultureInfo.CurrentCulture;
				binding.Mode = cell.BindingMode;
				binding.ConverterParameter = cell.Control;
				binding.Converter = cell.CreateCellBindingConverter();
			}
			return binding;
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0003E836 File Offset: 0x0003CA36
		internal static void SetControlStyle(global::System.Windows.FrameworkElement control, global::System.Windows.Style style)
		{
			if (control != null)
			{
				if (style == null)
				{
					if (control.Style != null)
					{
						control.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
						return;
					}
				}
				else
				{
					control.SetValue(global::System.Windows.FrameworkElement.StyleProperty, style);
				}
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0003E85E File Offset: 0x0003CA5E
		protected internal virtual bool CanResolveValueFromEditor
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x0003E861 File Offset: 0x0003CA61
		public virtual bool RemovePaddingDuringEditing
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x0003E864 File Offset: 0x0003CA64
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x0003E86C File Offset: 0x0003CA6C
		public bool IsToolTip { get; set; }

		// Token: 0x04000549 RID: 1353
		private global::System.Action<object> _valueChangedFunction;
	}
}
