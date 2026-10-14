using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001E6 RID: 486
	[global::System.Windows.TemplateVisualState(GroupName = "FixedStates", Name = "Fixed")]
	[global::System.Windows.TemplateVisualState(GroupName = "EditingStates", Name = "Editing")]
	[global::System.Windows.TemplateVisualState(GroupName = "SelectedStates", Name = "Selected")]
	[global::System.Windows.TemplateVisualState(GroupName = "EditingStates", Name = "NotEditing")]
	[global::System.Windows.TemplateVisualState(GroupName = "ActiveStates", Name = "Active")]
	[global::System.Windows.TemplateVisualState(GroupName = "FixedStates", Name = "UnFixed")]
	[global::System.Windows.TemplateVisualState(GroupName = "ActiveStates", Name = "InActive")]
	[global::System.Windows.TemplateVisualState(GroupName = "SelectedStates", Name = "NotSelected")]
	public class CellControl : global::Infragistics.Controls.Grids.Primitives.CellControlBase
	{
		// Token: 0x06000DBA RID: 3514 RVA: 0x00033115 File Offset: 0x00031315
		static CellControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.CellControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.CellControl)));
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00033144 File Offset: 0x00031344
		protected override void AttachContent()
		{
			global::Infragistics.Controls.Grids.Cell cell = (global::Infragistics.Controls.Grids.Cell)base.Cell;
			if (this._content == null)
			{
				this._content = cell.Column.GenerateContentProvider();
				if (this._content != null)
				{
					this._currentConveter = cell.Column.ValueConverter;
					global::System.Windows.Data.Binding cellBinding = this._content.ResolveBinding(cell);
					base.Content = this._content.ResolveDisplayElementInternal(cell, cellBinding);
					global::System.Windows.FrameworkElement frameworkElement = base.Content as global::System.Windows.FrameworkElement;
					if (!global::Infragistics.Controls.Grids.Primitives.CellControlBase.KeepContentInLogicalTree && frameworkElement != null && global::System.Windows.Data.BindingOperations.GetBindingExpressionBase(frameworkElement, global::System.Windows.FrameworkElement.DataContextProperty) == null)
					{
						frameworkElement.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, new global::System.Windows.Data.Binding
						{
							Path = new global::System.Windows.PropertyPath("DataContext", new object[0]),
							Source = this
						});
					}
				}
			}
			else if (global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._previousColumn) != cell.Column && this._content != null)
			{
				this._currentConveter = cell.Column.ValueConverter;
				global::System.Windows.Data.Binding cellBinding2 = this._content.ResolveBinding(cell);
				base.Content = this._content.ResolveDisplayElementInternal(cell, cellBinding2);
				global::System.Windows.FrameworkElement frameworkElement2 = base.Content as global::System.Windows.FrameworkElement;
				if (!global::Infragistics.Controls.Grids.Primitives.CellControlBase.KeepContentInLogicalTree && frameworkElement2 != null && global::System.Windows.Data.BindingOperations.GetBindingExpressionBase(frameworkElement2, global::System.Windows.FrameworkElement.DataContextProperty) == null)
				{
					frameworkElement2.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, new global::System.Windows.Data.Binding
					{
						Path = new global::System.Windows.PropertyPath("DataContext", new object[0]),
						Source = this
					});
				}
			}
			this._previousColumn = new global::System.WeakReference(cell.Column);
			if (this._content != null)
			{
				if (cell.IsEditing || (cell.IsEditable && cell.Row == cell.Row.ColumnLayout.Grid.CurrentEditRow && !cell.Row.ColumnLayout.Grid.CellsThatCancelledEditMode.Contains(cell)))
				{
					this.AddEditorToControl();
				}
				if (this._currentConveter != cell.Column.ValueConverter)
				{
					this._currentConveter = cell.Column.ValueConverter;
					global::System.Windows.Data.Binding cellBinding3 = this._content.ResolveBinding(cell);
					this._content.ResolveDisplayElementInternal(cell, cellBinding3);
				}
			}
			if (cell != null && cell.IsActive)
			{
				global::System.Windows.Controls.Control control = base.Content as global::System.Windows.Controls.Control;
				if (control != null && control.IsHitTestVisible)
				{
					control.Focus();
				}
			}
			global::Infragistics.Controls.Grids.EditableColumn editableColumn = base.Cell.Column as global::Infragistics.Controls.Grids.EditableColumn;
			if (editableColumn != null)
			{
				this._colReadOnlyIsDirtyFlag = editableColumn.IsReadOnlyDirtyFlag;
			}
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x000333C4 File Offset: 0x000315C4
		protected internal override void EnsureContent()
		{
			global::Infragistics.Controls.Grids.CellBase cell = base.Cell;
			global::Infragistics.Controls.Grids.Column column = cell.Column;
			global::Infragistics.Controls.Grids.EditableColumn editableColumn = column as global::Infragistics.Controls.Grids.EditableColumn;
			if (editableColumn != null && this._content != null && this._colReadOnlyIsDirtyFlag != editableColumn.IsReadOnlyDirtyFlag)
			{
				global::Infragistics.Controls.Grids.Cell cell2 = (global::Infragistics.Controls.Grids.Cell)cell;
				global::System.Windows.Data.Binding cellBinding = this._content.ResolveBinding(cell2);
				this._content.ResolveDisplayElementInternal(cell2, cellBinding);
				this._colReadOnlyIsDirtyFlag = editableColumn.IsReadOnlyDirtyFlag;
			}
			global::Infragistics.Controls.Grids.RowBase row = cell.Row;
			global::Infragistics.Controls.Grids.XamGrid grid = row.ColumnLayout.Grid;
			if (editableColumn != null && cell.IsEditable && (grid.CurrentEditCell == cell || grid.CurrentEditRow == row))
			{
				if (row is global::Infragistics.Controls.Grids.Primitives.AddNewRow && editableColumn.AddNewRowEditorTemplate != null)
				{
					base.HorizontalContentAlignment = editableColumn.AddNewRowEditorTemplateHorizontalContentAlignment;
					base.VerticalContentAlignment = editableColumn.AddNewRowEditorTemplateVerticalContentAlignment;
				}
				else
				{
					base.HorizontalContentAlignment = editableColumn.EditorHorizontalContentAlignment;
					base.VerticalContentAlignment = editableColumn.EditorVerticalContentAlignment;
				}
			}
			else if (column != null && (grid.CurrentEditCell == cell || grid.CurrentEditRow == row) && row.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow && cell.Column.AddNewRowEditorTemplate != null)
			{
				base.HorizontalContentAlignment = column.AddNewRowEditorTemplateHorizontalContentAlignment;
				base.VerticalContentAlignment = column.AddNewRowEditorTemplateVerticalContentAlignment;
			}
			else if (column != null)
			{
				if (row is global::Infragistics.Controls.Grids.Primitives.AddNewRow && column.AddNewRowItemTemplate != null)
				{
					base.HorizontalContentAlignment = column.AddNewRowItemTemplateHorizontalContentAlignment;
					base.VerticalContentAlignment = column.AddNewRowItemTemplateVerticalContentAlignment;
				}
				else if (!(row is global::Infragistics.Controls.Grids.Primitives.SummaryRow))
				{
					base.HorizontalContentAlignment = column.HorizontalContentAlignment;
					base.VerticalContentAlignment = column.VerticalContentAlignment;
				}
			}
			if (this._content != null)
			{
				this._content.AdjustDisplayElement((global::Infragistics.Controls.Grids.Cell)cell);
			}
			if (column.ShouldAlwaysAllowToolTips(base.Cell))
			{
				this.ShowToolTip();
				return;
			}
			this.HideToolTip();
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0003357C File Offset: 0x0003177C
		protected override void OnLoaded()
		{
			base.OnLoaded();
			if (base.Cell != null)
			{
				base.Cell.EnsureCurrentState();
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x00033597 File Offset: 0x00031797
		protected override bool ShowResizingArrow
		{
			get
			{
				return base.Cell.Column.ColumnLayout.ColumnResizingSettings.AllowCellAreaResizingResolved;
			}
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x000335B3 File Offset: 0x000317B3
		protected override void ReleaseContent()
		{
			base.ReleaseContent();
			if (this._content != null)
			{
				this._content.ResetContent();
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x000335CE File Offset: 0x000317CE
		public override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase ContentProvider
		{
			get
			{
				return this._content;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x000335D6 File Offset: 0x000317D6
		protected internal bool HasEditingBindings
		{
			get
			{
				return this._editorBindings != null && this._editorBindings.Count > 0;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x000335F0 File Offset: 0x000317F0
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x000335F8 File Offset: 0x000317F8
		protected virtual bool EditorAlreadyLoaded { get; set; }

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00033601 File Offset: 0x00031801
		protected virtual object ToolTipContent
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00033604 File Offset: 0x00031804
		private bool IsEditorTemplateAddNewRowCell
		{
			get
			{
				return base.Cell != null && base.Cell is global::Infragistics.Controls.Grids.Primitives.AddNewRowCell && base.Column.AddNewRowEditorTemplate != null;
			}
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00033630 File Offset: 0x00031830
		protected virtual object ResolveEditorCellValue(object dataValue)
		{
			global::Infragistics.Controls.Grids.Cell cell = base.Cell as global::Infragistics.Controls.Grids.Cell;
			global::System.Collections.Generic.Dictionary<string, object> editCellValues = cell.Row.ColumnLayout.Grid.EditCellValues;
			object result;
			if (editCellValues != null && editCellValues.ContainsKey(cell.Column.Key))
			{
				result = editCellValues[cell.Column.Key];
			}
			else
			{
				result = dataValue;
			}
			return result;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00033690 File Offset: 0x00031890
		protected internal virtual void AddEditorToControl()
		{
			if (base.Cell.Column.WidthResolved.WidthType == global::Infragistics.Controls.Grids.ColumnWidthType.InitialAuto && !base.Cell.Column.IsInitialAutoSet)
			{
				this._wasColumnWidthSetAtEditTime = false;
			}
			else
			{
				this._wasColumnWidthSetAtEditTime = true;
			}
			this._columnActualWidth = base.Cell.Column.ActualWidth;
			this._rowActualHeight = base.Cell.Row.ActualHeight;
			this.EditorAlreadyLoaded = false;
			global::Infragistics.Controls.Grids.Cell cell = base.Cell as global::Infragistics.Controls.Grids.Cell;
			if (cell != null)
			{
				object value = base.Cell.Value;
				object obj = this.ResolveEditorCellValue(value);
				if (obj != null && !obj.Equals(value))
				{
					this.EditorAlreadyLoaded = true;
				}
				if (this.ContentProvider.RemovePaddingDuringEditing || this.IsEditorTemplateAddNewRowCell)
				{
					this._padding = base.Padding;
					base.Padding = default(global::System.Windows.Thickness);
				}
				double availableWidth = cell.Column.ActualWidth - (base.BorderThickness.Right + base.BorderThickness.Left + base.Padding.Left + base.Padding.Right);
				double num = cell.Row.ActualHeight - (base.BorderThickness.Top + base.BorderThickness.Bottom + base.Padding.Top + base.Padding.Bottom);
				if (cell.Row.ActualHeight == 0.0)
				{
					num += base.DesiredSize.Height;
				}
				if (num <= 0.0)
				{
					num = double.NaN;
				}
				global::System.Windows.FrameworkElement frameworkElement = this._content.ResolveEditor(cell, new global::System.Action<object>(this.NotifyEditorValueChanged), obj, availableWidth, num, this._content.ResolveEditorBinding(cell));
				if (frameworkElement != null)
				{
					global::System.Windows.Controls.Control control = global::Infragistics.PlatformProxy.GetFocusedElement(this) as global::System.Windows.Controls.Control;
					if (control != null)
					{
						control.ReleaseMouseCapture();
					}
					if (cell.Column is global::Infragistics.Controls.Grids.TemplateColumn && frameworkElement is global::Infragistics.Controls.Grids.Primitives.TemplateColumnEditorContentPresenter)
					{
						((global::Infragistics.Controls.Grids.Primitives.TemplateColumnEditorContentPresenter)frameworkElement).Control = this;
					}
					else
					{
						this._editorBindings = global::Infragistics.Controls.Grids.CellControl.ResolveBindingsFromChildren(frameworkElement, true);
					}
					if (base.Content != frameworkElement)
					{
						global::Infragistics.EditUtilities.SetIsInEditMode(frameworkElement, new bool?(true));
						base.Content = frameworkElement;
						frameworkElement.Loaded += this.Editor_Loaded;
					}
				}
			}
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00033900 File Offset: 0x00031B00
		protected internal virtual void RemoveEditorFromControl()
		{
			if (this._content != null)
			{
				global::Infragistics.Controls.Grids.Cell cell = (global::Infragistics.Controls.Grids.Cell)base.Cell;
				if (cell != null)
				{
					global::System.Windows.FrameworkElement frameworkElement = base.Content as global::System.Windows.FrameworkElement;
					if (frameworkElement != null)
					{
						frameworkElement.Loaded -= this.Editor_Loaded;
						if (frameworkElement is global::Infragistics.Controls.Grids.Primitives.TemplateColumnEditorContentPresenter)
						{
							((global::Infragistics.Controls.Grids.Primitives.TemplateColumnEditorContentPresenter)frameworkElement).Control = null;
						}
						global::Infragistics.EditUtilities.SetIsInEditMode(frameworkElement, new bool?(false));
					}
					this._content.EditorRemoved();
					global::System.Windows.Data.Binding cellBinding = this._content.ResolveBinding(cell);
					bool flag = global::Infragistics.Controls.Grids.CellControl.IsFocusedControlInsideEditor(frameworkElement);
					if (base.Cell == base.Cell.Row.ColumnLayout.Grid.ActiveCell)
					{
						bool flag2 = false;
						global::System.Windows.IInputElement directlyOver = global::System.Windows.Input.Mouse.DirectlyOver;
						if (directlyOver != null && directlyOver != frameworkElement)
						{
							flag2 = (directlyOver.IsMouseCaptured || directlyOver.IsKeyboardFocused);
						}
						if (global::Infragistics.Controls.Grids.CellControl.IsFocusedControlInsideEditor(frameworkElement) && !flag2)
						{
							base.Focus();
						}
						else if (flag && !base.IsFocused && !flag2)
						{
							base.Focus();
						}
					}
					base.Content = this._content.ResolveDisplayElementInternal(cell, cellBinding);
					if (this.ContentProvider.RemovePaddingDuringEditing || this.IsEditorTemplateAddNewRowCell)
					{
						base.Padding = this._padding;
					}
				}
			}
			base.Cell.Row.ActualHeight = this._rowActualHeight;
			if (this._wasColumnWidthSetAtEditTime)
			{
				base.Cell.Column.ActualWidth = this._columnActualWidth;
			}
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00033A68 File Offset: 0x00031C68
		protected virtual void OnEditorLoaded(global::System.Windows.FrameworkElement editor)
		{
			global::Infragistics.Controls.Grids.CellBase cell = base.Cell;
			if (cell != null && ((global::Infragistics.Controls.Grids.Cell)cell).IsEditing)
			{
				this.ContentProvider.FocusEditor();
				if (!global::Infragistics.Controls.PresentationUtilities.HasFocus(editor))
				{
					this.FocusOnEditorElement(editor);
				}
			}
			base.Cell.Row.Control.RenderCell(base.Cell);
			if ((editor.ActualHeight == 0.0 || editor.ActualWidth == 0.0) && double.IsNaN(editor.Height) && double.IsNaN(editor.Width))
			{
				editor.Height = 1.0;
				editor.Width = 1.0;
				editor.UpdateLayout();
				editor.Height = double.NaN;
				editor.Width = double.NaN;
			}
			if (!this.EditorAlreadyLoaded)
			{
				this._content.EditorLoaded();
			}
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00033B54 File Offset: 0x00031D54
		protected internal bool EvaluateEditingBindings()
		{
			if (this._editorBindings != null)
			{
				foreach (global::Infragistics.Controls.Grids.CellControl.BindingDataInfo bindingDataInfo in this._editorBindings)
				{
					if (bindingDataInfo.Expression.Status != global::System.Windows.Data.BindingStatus.Detached)
					{
						global::System.Windows.Controls.Validation.AddErrorHandler(bindingDataInfo.Element, new global::System.EventHandler<global::System.Windows.Controls.ValidationErrorEventArgs>(this.Element_BindingValidationError));
						bindingDataInfo.Expression.UpdateSource();
						global::System.Windows.Controls.Validation.RemoveErrorHandler(bindingDataInfo.Element, new global::System.EventHandler<global::System.Windows.Controls.ValidationErrorEventArgs>(this.Element_BindingValidationError));
					}
				}
				if (base.Cell.Row.RowType != global::Infragistics.Controls.Grids.RowType.FilterRow && this._bindingError)
				{
					this._bindingError = false;
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00033C18 File Offset: 0x00031E18
		private void NotifyEditorValueChanged(object value)
		{
			if (base.Cell != null)
			{
				base.Cell.EditorValueChanged(value);
			}
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00033C30 File Offset: 0x00031E30
		internal static global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellControl.BindingDataInfo> ResolveBindingsFromChildren(global::System.Windows.FrameworkElement element, bool forEditing)
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellControl.BindingDataInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellControl.BindingDataInfo>();
			list.AddRange(global::Infragistics.Controls.Grids.CellControl.ResovingBindingData(element, forEditing));
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(element);
			for (int i = 0; i < childrenCount; i++)
			{
				global::System.Windows.FrameworkElement frameworkElement = global::System.Windows.Media.VisualTreeHelper.GetChild(element, i) as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					list.AddRange(global::Infragistics.Controls.Grids.CellControl.ResolveBindingsFromChildren(frameworkElement, forEditing));
				}
			}
			return list;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00033C84 File Offset: 0x00031E84
		private static bool IsFocusedControlInsideEditor(global::System.Windows.FrameworkElement ctrl)
		{
			if (ctrl != null)
			{
				global::System.Windows.DependencyObject dependencyObject = global::Infragistics.PlatformProxy.GetFocusedElement(ctrl) as global::System.Windows.DependencyObject;
				while (dependencyObject != null)
				{
					if (dependencyObject == ctrl)
					{
						return true;
					}
					global::System.Windows.FrameworkElement frameworkElement = dependencyObject as global::System.Windows.FrameworkElement;
					dependencyObject = global::Infragistics.PlatformProxy.GetParent(dependencyObject);
					if (dependencyObject == null && frameworkElement != null)
					{
						dependencyObject = frameworkElement.Parent;
					}
				}
			}
			return false;
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00033CC8 File Offset: 0x00031EC8
		private bool FocusOnEditorElement(global::System.Windows.FrameworkElement editor)
		{
			global::System.Windows.Controls.Control control = editor as global::System.Windows.Controls.Control;
			if (control == null)
			{
				return global::Infragistics.Controls.PresentationUtilities.Focus(editor);
			}
			if (base.Cell != null && ((global::Infragistics.Controls.Grids.Cell)base.Cell).IsEditing && editor.IsHitTestVisible && !global::Infragistics.Controls.Grids.CellControl.IsFocusedControlInsideEditor(control))
			{
				control.Focus();
				return true;
			}
			return false;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00033D1C File Offset: 0x00031F1C
		internal void ShowToolTip()
		{
			global::Infragistics.Controls.Grids.Cell cell = (global::Infragistics.Controls.Grids.Cell)base.Cell;
			global::Infragistics.Controls.Grids.Column column = cell.Column;
			if (this._tooltip == null)
			{
				this._tooltip = new global::System.Windows.Controls.ToolTip();
			}
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (column.ColumnLayout != null) ? column.ColumnLayout.Grid : null;
			this._tooltip.Style = ((xamGrid != null) ? xamGrid.GetToolTipStyle(column) : column.ToolTipStyle);
			object toolTipContent = this.ToolTipContent;
			if (toolTipContent != null)
			{
				this._tooltip.Content = toolTipContent;
			}
			else if (column.ToolTipContentTemplate == null)
			{
				if (this._tooltipContentProvider == null)
				{
					this._tooltipContentProvider = column.GenerateContentProvider();
					this._tooltipContentProvider.IsToolTip = true;
				}
				global::Infragistics.Controls.Grids.TemplateColumn templateColumn = column as global::Infragistics.Controls.Grids.TemplateColumn;
				object value = cell.Value;
				string text = value as string;
				if (cell.Row.Data == null || value == null || (text != null && text.Length == 0))
				{
					global::Infragistics.Controls.Grids.UnboundColumn unboundColumn = column as global::Infragistics.Controls.Grids.UnboundColumn;
					if (unboundColumn != null && unboundColumn.ItemTemplate != null)
					{
						global::System.Windows.Data.Binding cellBinding = this._tooltipContentProvider.ResolveBinding(cell);
						this._tooltip.Content = this._tooltipContentProvider.ResolveDisplayElement(cell, cellBinding);
						this._tooltip.DataContext = cell.Row.Data;
					}
					else
					{
						this._tooltip.Content = null;
						this._tooltip = null;
					}
				}
				else if (templateColumn != null && templateColumn.ItemTemplate == null)
				{
					this._tooltip.Content = cell.Value;
				}
				else
				{
					global::System.Windows.Data.Binding cellBinding2 = this._tooltipContentProvider.ResolveBinding(cell);
					this._tooltip.Content = this._tooltipContentProvider.ResolveDisplayElement(cell, cellBinding2);
					this._tooltip.DataContext = cell.Row.Data;
				}
			}
			else
			{
				this._tooltip.Content = cell.Row.Data;
				this._tooltip.ContentTemplate = column.ToolTipContentTemplate;
			}
			global::System.Windows.Controls.ToolTipService.SetToolTip(this, this._tooltip);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00033F01 File Offset: 0x00032101
		internal void HideToolTip()
		{
			if (this._tooltip != null)
			{
				global::System.Windows.Controls.ToolTipService.SetToolTip(this, null);
				this._tooltip.Content = null;
				this._tooltip = null;
			}
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00033F28 File Offset: 0x00032128
		internal void RefreshEditorBindings()
		{
			global::System.Windows.FrameworkElement frameworkElement = base.Content as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				this._editorBindings = global::Infragistics.Controls.Grids.CellControl.ResolveBindingsFromChildren(frameworkElement, true);
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00033F54 File Offset: 0x00032154
		private static global::System.Collections.Generic.List<global::System.Windows.DependencyProperty> GetDependencyProperties(global::System.Windows.FrameworkElement element, bool forEditing)
		{
			global::System.Collections.Generic.List<global::System.Windows.DependencyProperty> list = new global::System.Collections.Generic.List<global::System.Windows.DependencyProperty>();
			if (!forEditing || (!(element is global::System.Windows.Controls.Panel) && !(element is global::System.Windows.Controls.Button) && !(element is global::System.Windows.Controls.Image) && !(element is global::System.Windows.Controls.ScrollViewer) && !(element is global::System.Windows.Controls.TextBlock) && !(element is global::System.Windows.Controls.Border) && !(element is global::System.Windows.Shapes.Shape) && !(element is global::System.Windows.Controls.ContentPresenter)))
			{
				global::System.Reflection.FieldInfo[] fields = element.GetType().GetFields(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.FlattenHierarchy);
				foreach (global::System.Reflection.FieldInfo fieldInfo in fields)
				{
					if (fieldInfo.FieldType == typeof(global::System.Windows.DependencyProperty))
					{
						list.Add((global::System.Windows.DependencyProperty)fieldInfo.GetValue(null));
					}
				}
			}
			return list;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00034004 File Offset: 0x00032204
		private static global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellControl.BindingDataInfo> ResovingBindingData(global::System.Windows.FrameworkElement element, bool forEditing)
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellControl.BindingDataInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellControl.BindingDataInfo>();
			global::System.Collections.Generic.List<global::System.Windows.DependencyProperty> dependencyProperties = global::Infragistics.Controls.Grids.CellControl.GetDependencyProperties(element, forEditing);
			if (dependencyProperties.Count > 0)
			{
				foreach (global::System.Windows.DependencyProperty dp in dependencyProperties)
				{
					global::System.Windows.Data.BindingExpression bindingExpression = element.GetBindingExpression(dp);
					if (bindingExpression != null)
					{
						if (bindingExpression.ParentBinding != null)
						{
							if (bindingExpression.ParentBinding.Mode == global::System.Windows.Data.BindingMode.TwoWay)
							{
								list.Add(new global::Infragistics.Controls.Grids.CellControl.BindingDataInfo
								{
									Element = element,
									Expression = bindingExpression
								});
							}
						}
						else
						{
							list.Add(new global::Infragistics.Controls.Grids.CellControl.BindingDataInfo
							{
								Element = element,
								Expression = bindingExpression
							});
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x000340C8 File Offset: 0x000322C8
		private void Editor_Loaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.OnEditorLoaded(sender as global::System.Windows.FrameworkElement);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000340D8 File Offset: 0x000322D8
		private void Element_BindingValidationError(object sender, global::System.Windows.Controls.ValidationErrorEventArgs e)
		{
			if (!base.Cell.Row.ColumnLayout.Grid.OnCellEditingValidationFailed((global::Infragistics.Controls.Grids.Cell)base.Cell, e) && !e.Handled && e.Action == global::System.Windows.Controls.ValidationErrorEventAction.Added)
			{
				this._bindingError = true;
			}
		}

		// Token: 0x0400047D RID: 1149
		private global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase _content;

		// Token: 0x0400047E RID: 1150
		private bool _bindingError;

		// Token: 0x0400047F RID: 1151
		private double _columnActualWidth;

		// Token: 0x04000480 RID: 1152
		private double _rowActualHeight;

		// Token: 0x04000481 RID: 1153
		private global::System.Windows.Thickness _padding;

		// Token: 0x04000482 RID: 1154
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellControl.BindingDataInfo> _editorBindings;

		// Token: 0x04000483 RID: 1155
		private int _colReadOnlyIsDirtyFlag;

		// Token: 0x04000484 RID: 1156
		private global::System.Windows.Data.IValueConverter _currentConveter;

		// Token: 0x04000485 RID: 1157
		private global::System.Windows.Controls.ToolTip _tooltip;

		// Token: 0x04000486 RID: 1158
		private global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase _tooltipContentProvider;

		// Token: 0x04000487 RID: 1159
		private bool _wasColumnWidthSetAtEditTime;

		// Token: 0x04000488 RID: 1160
		private global::System.WeakReference _previousColumn;

		// Token: 0x020001E7 RID: 487
		internal class BindingDataInfo
		{
			// Token: 0x17000410 RID: 1040
			// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x00034124 File Offset: 0x00032324
			// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x0003412C File Offset: 0x0003232C
			public global::System.Windows.FrameworkElement Element { get; set; }

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00034135 File Offset: 0x00032335
			// (set) Token: 0x06000DDA RID: 3546 RVA: 0x0003413D File Offset: 0x0003233D
			public global::System.Windows.Data.BindingExpression Expression { get; set; }
		}
	}
}
