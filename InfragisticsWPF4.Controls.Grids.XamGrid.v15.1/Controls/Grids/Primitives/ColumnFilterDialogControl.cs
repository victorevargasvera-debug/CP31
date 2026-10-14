using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interop;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000080 RID: 128
	[global::System.Windows.TemplatePart(Name = "And", Type = typeof(global::System.Windows.Controls.RadioButton))]
	[global::System.Windows.TemplatePart(Name = "Operand1", Type = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.Windows.TemplatePart(Name = "Operand2", Type = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.Windows.TemplatePart(Name = "Operator1", Type = typeof(global::System.Windows.Controls.ComboBox))]
	[global::System.Windows.TemplatePart(Name = "Operator2", Type = typeof(global::System.Windows.Controls.ComboBox))]
	[global::System.Windows.TemplatePart(Name = "Or", Type = typeof(global::System.Windows.Controls.RadioButton))]
	public class ColumnFilterDialogControl : global::System.Windows.Controls.Control, global::Infragistics.ICommandTarget, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x0600044A RID: 1098
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern global::System.IntPtr SetActiveWindow(global::System.IntPtr hWnd);

		// Token: 0x0600044B RID: 1099 RVA: 0x00013778 File Offset: 0x00011978
		static ColumnFilterDialogControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl)));
			global::System.Windows.Controls.Control.IsTabStopProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				try
				{
					global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), global::System.Windows.UIElement.PreviewGotKeyboardFocusEvent, new global::System.Windows.Input.KeyboardFocusChangedEventHandler(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.OnPreviewGotKeyboardFocus), true);
				}
				catch (global::System.Security.SecurityException)
				{
				}
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000138F4 File Offset: 0x00011AF4
		public ColumnFilterDialogControl()
		{
			this._dialogPopup = new global::System.Windows.Controls.Primitives.Popup();
			this._dialogPopup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Relative;
			this._dialogPopup.AllowsTransparency = true;
			this._dialogPopup.StaysOpen = false;
			this._dialogPopup.Closed += this.DialogPopup_Closed;
			this._dialogPopup.Opened += this.DialogPopup_Opened;
			this._dialogPopup.SizeChanged += this.DialogPopup_SizeChanged;
			this.CancelButtonText = global::Infragistics.SRGrid.GetString("CustomFilterDialog_CancelButtonText");
			this.OKButtonText = global::Infragistics.SRGrid.GetString("CustomFilterDialog_OKButtonText");
			this.AndRadioButtonText = global::Infragistics.SRGrid.GetString("CustomFilterDialog_AndRadioButtonText");
			this.OrRadioButtonText = global::Infragistics.SRGrid.GetString("CustomFilterDialog_OrRadioButtonText");
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000139C6 File Offset: 0x00011BC6
		private void Grid_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			this.Hide();
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000139CE File Offset: 0x00011BCE
		private void DialogPopup_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			this.AlignPopup();
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000139D6 File Offset: 0x00011BD6
		private void ColumnFilterDialogControl_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			this.AlignPopup();
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000139E0 File Offset: 0x00011BE0
		private void Operator2_SelectionChanged(object sender, global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (e.AddedItems.Count > 0)
			{
				global::Infragistics.Controls.Grids.FilterOperand filterOperand = e.AddedItems[0] as global::Infragistics.Controls.Grids.FilterOperand;
				if (filterOperand != null)
				{
					this._operand2.IsEnabled = filterOperand.RequiresFilteringInput;
					return;
				}
			}
			else
			{
				this._operand2.IsEnabled = true;
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00013A30 File Offset: 0x00011C30
		private void Operator1_SelectionChanged(object sender, global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (e.AddedItems.Count > 0)
			{
				global::Infragistics.Controls.Grids.FilterOperand filterOperand = e.AddedItems[0] as global::Infragistics.Controls.Grids.FilterOperand;
				if (filterOperand != null)
				{
					this._operand1.IsEnabled = filterOperand.RequiresFilteringInput;
					return;
				}
			}
			else
			{
				this._operand1.IsEnabled = true;
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00013A7E File Offset: 0x00011C7E
		private void MouseLeftButtonDownHandler(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00013A80 File Offset: 0x00011C80
		private void KeyDownHandler(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (!e.Handled)
			{
				if (e.Key == global::System.Windows.Input.Key.Escape)
				{
					this.Hide();
					e.Handled = true;
					return;
				}
				if (e.Key == global::System.Windows.Input.Key.Return)
				{
					this.Hide();
					if (this._contentProviderForOperand1 != null)
					{
						this._proxyValues.ProxyValue1 = this._contentProviderForOperand1.ResolveValueFromEditor(this._cellForOperand1);
					}
					if (this._contentProviderForOperand2 != null)
					{
						this._proxyValues.ProxyValue2 = this._contentProviderForOperand2.ResolveValueFromEditor(this._cellForOperand2);
					}
					this.AcceptChanges();
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00013B11 File Offset: 0x00011D11
		private void DialogPopup_Closed(object sender, global::System.EventArgs e)
		{
			this.Hide();
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00013B2F File Offset: 0x00011D2F
		private void DialogPopup_Opened(object sender, global::System.EventArgs e)
		{
			this.AlignPopup();
			base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
			{
				if (this._operator1 != null)
				{
					this._operator1.Focus();
				}
			}), new object[0]);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00013B58 File Offset: 0x00011D58
		[global::System.Security.SecuritySafeCritical]
		private static void OnPreviewGotKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.TextBoxBase textBoxBase = e.NewFocus as global::System.Windows.Controls.Primitives.TextBoxBase;
			if (textBoxBase != null)
			{
				global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.PresentationSource.FromVisual(textBoxBase) as global::System.Windows.Interop.HwndSource;
				if (hwndSource != null && global::System.Windows.Input.InputMethod.Current.ImeState == global::System.Windows.Input.InputMethodState.On)
				{
					global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.SetActiveWindow(hwndSource.Handle);
				}
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00013B9C File Offset: 0x00011D9C
		private void ResetControls()
		{
			global::Infragistics.Controls.Grids.FilterOperandCollection rowFilterOperands = this.Cell.Column.FilterColumnSettings.RowFilterOperands;
			if (this._operator1 != null)
			{
				this._operator1.ItemsSource = null;
				this._operator1.ItemsSource = rowFilterOperands;
			}
			if (this._operator2 != null)
			{
				this._operator2.ItemsSource = null;
				this._operator2.ItemsSource = rowFilterOperands;
			}
			if (this._operand1 != null)
			{
				this._proxyValues.ProxyValue1 = null;
			}
			if (this._operand2 != null)
			{
				this._proxyValues.ProxyValue2 = null;
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00013C28 File Offset: 0x00011E28
		private void AlignPopup()
		{
			if (this._dialogPopup.IsOpen)
			{
				global::Infragistics.Controls.Grids.XamGrid grid = this.Cell.Row.ColumnLayout.Grid;
				double num = grid.ActualWidth / 2.0;
				double num2 = grid.ActualHeight / 2.0;
				double num3 = this._dialogPopup.Child.DesiredSize.Width / 2.0;
				double num4 = this._dialogPopup.Child.DesiredSize.Height / 2.0;
				double num5 = num - num3;
				this._dialogPopup.HorizontalOffset = ((num5 < 0.0) ? 0.0 : num5);
				double num6 = num2 - num4;
				this._dialogPopup.VerticalOffset = ((num6 < 0.0) ? 0.0 : num6);
				global::System.Windows.UIElement rootVisual = global::Infragistics.PlatformProxy.GetRootVisual(this._dialogPopup);
				global::System.Windows.Rect rect = new global::System.Windows.Rect(0.0, 0.0, rootVisual.RenderSize.Width, rootVisual.RenderSize.Height);
				if (this._dialogPopup.HorizontalOffset > rect.Right)
				{
					this._dialogPopup.HorizontalOffset = rect.Right / 2.0 - num3;
				}
				if (this._dialogPopup.VerticalOffset > rect.Bottom)
				{
					this._dialogPopup.VerticalOffset = rect.Bottom / 2.0 - num4;
				}
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00013DC8 File Offset: 0x00011FC8
		private void SetupCurrentView()
		{
			if (this.Cell == null)
			{
				return;
			}
			global::Infragistics.Controls.Grids.RowsManager rowsManager = this.Cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
			if (rowsManager != null)
			{
				global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowsManager.RowFiltersCollectionResolved[this.Cell.Column.Key];
				if (rowsFilter == null && rowsManager.DataManager != null)
				{
					rowsFilter = new global::Infragistics.Controls.Grids.RowsFilter(rowsManager.DataManager.CachedType, this.Cell.Column);
					rowsManager.RowFiltersCollectionResolved.Add(rowsFilter);
				}
				if (rowsFilter == null)
				{
					return;
				}
				bool flag = rowsFilter.Conditions.LogicalOperator == global::Infragistics.LogicalOperator.And;
				if (this._defaultFilterOperand != null && this._defaultFilterOperand.Count > 1)
				{
					flag = true;
				}
				if (flag)
				{
					if (this._andButton != null)
					{
						this._andButton.IsChecked = new bool?(true);
					}
				}
				else if (this._orButton != null)
				{
					this._orButton.IsChecked = new bool?(true);
				}
				this.ResetControls();
				if (this._defaultFilterOperand != null && this._defaultFilterOperand.Count > 0)
				{
					if (this._operator1 != null && this._operand1 != null)
					{
						foreach (object obj in this._operator1.ItemsSource)
						{
							global::Infragistics.Controls.Grids.FilterOperand filterOperand = obj as global::Infragistics.Controls.Grids.FilterOperand;
							if (filterOperand.GetType() == this._defaultFilterOperand[0].GetType())
							{
								this._operator1.SelectedItem = obj;
								break;
							}
						}
					}
					if (this._defaultFilterOperand.Count == 2 && this._operator2 != null && this._operand2 != null)
					{
						foreach (object obj2 in this._operator2.ItemsSource)
						{
							global::Infragistics.Controls.Grids.FilterOperand filterOperand2 = obj2 as global::Infragistics.Controls.Grids.FilterOperand;
							if (filterOperand2.GetType() == this._defaultFilterOperand[1].GetType())
							{
								this._operator2.SelectedItem = obj2;
								break;
							}
						}
					}
				}
				int count = rowsFilter.Conditions.Count;
				bool flag2 = count > 0 && count < 3;
				if (flag2 && this._defaultFilterOperand != null && this._defaultFilterOperand.Count != count)
				{
					flag2 = false;
				}
				if (flag2)
				{
					global::Infragistics.ComparisonCondition comparisonCondition = rowsFilter.Conditions[0] as global::Infragistics.ComparisonCondition;
					if (comparisonCondition != null)
					{
						if (this._operator1 == null || this._operand1 == null)
						{
							goto IL_3FF;
						}
						using (global::System.Collections.IEnumerator enumerator3 = this._operator1.ItemsSource.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								object obj3 = enumerator3.Current;
								global::Infragistics.Controls.Grids.FilterOperand filterOperand3 = obj3 as global::Infragistics.Controls.Grids.FilterOperand;
								if ((this._defaultFilterOperand == null || this._defaultFilterOperand.Count <= 0 || !(filterOperand3.GetType() != this._defaultFilterOperand[0].GetType())) && filterOperand3.ComparisonOperatorValue != null && filterOperand3.ComparisonOperatorValue.Value == comparisonCondition.Operator)
								{
									this._operator1.SelectedItem = obj3;
									object filterValue = comparisonCondition.FilterValue;
									if (filterValue != null)
									{
										this._proxyValues.ProxyValue1 = filterValue;
										break;
									}
									break;
								}
							}
							goto IL_3FF;
						}
					}
					global::Infragistics.CustomComparisonCondition customComparisonCondition = rowsFilter.Conditions[0] as global::Infragistics.CustomComparisonCondition;
					if (customComparisonCondition != null && this._operand1 != null && this._operator1 != null)
					{
						foreach (object obj4 in this._operator1.ItemsSource)
						{
							if (obj4.GetType() == customComparisonCondition.FilterOperand)
							{
								this._operator1.SelectedItem = obj4;
								object filterValue2 = customComparisonCondition.FilterValue;
								if (filterValue2 != null)
								{
									this._proxyValues.ProxyValue1 = filterValue2;
									break;
								}
								break;
							}
						}
					}
					IL_3FF:
					if (count == 2)
					{
						global::Infragistics.ComparisonCondition comparisonCondition2 = rowsFilter.Conditions[1] as global::Infragistics.ComparisonCondition;
						if (comparisonCondition2 != null)
						{
							if (this._operator2 == null || this._operand2 == null)
							{
								return;
							}
							using (global::System.Collections.IEnumerator enumerator5 = this._operator2.ItemsSource.GetEnumerator())
							{
								while (enumerator5.MoveNext())
								{
									object obj5 = enumerator5.Current;
									global::Infragistics.Controls.Grids.FilterOperand filterOperand4 = obj5 as global::Infragistics.Controls.Grids.FilterOperand;
									if ((this._defaultFilterOperand == null || this._defaultFilterOperand.Count <= 1 || !(filterOperand4.GetType() != this._defaultFilterOperand[1].GetType())) && filterOperand4.ComparisonOperatorValue != null && filterOperand4.ComparisonOperatorValue.Value == comparisonCondition2.Operator)
									{
										this._operator2.SelectedItem = obj5;
										object filterValue3 = comparisonCondition2.FilterValue;
										if (filterValue3 != null)
										{
											this._proxyValues.ProxyValue2 = filterValue3;
											break;
										}
										break;
									}
								}
								return;
							}
						}
						global::Infragistics.CustomComparisonCondition customComparisonCondition2 = rowsFilter.Conditions[1] as global::Infragistics.CustomComparisonCondition;
						if (customComparisonCondition2 != null && this._operator2 != null && this._operand2 != null)
						{
							foreach (object obj6 in this._operator2.ItemsSource)
							{
								if (obj6.GetType() == customComparisonCondition2.FilterOperand)
								{
									this._operator2.SelectedItem = obj6;
									object filterValue4 = customComparisonCondition2.FilterValue;
									if (filterValue4 != null)
									{
										this._proxyValues.ProxyValue2 = filterValue4;
										break;
									}
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000143D8 File Offset: 0x000125D8
		protected internal virtual void AcceptChanges()
		{
			global::Infragistics.Controls.Grids.RowsManager rowsManager = this.Cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
			if (rowsManager != null)
			{
				global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowsManager.RowFiltersCollectionResolved[this.Cell.Column.Key];
				if (rowsFilter == null)
				{
					return;
				}
				bool flag = rowsFilter.Conditions.Count > 0;
				rowsFilter.Conditions.ClearSilently();
				if (this._cell.Column is global::Infragistics.Controls.Grids.TemplateColumn || this._cell.Column is global::Infragistics.Controls.Grids.UnboundColumn)
				{
					global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellControl.BindingDataInfo> list = global::Infragistics.Controls.Grids.CellControl.ResolveBindingsFromChildren(this._operand1, true);
					if (list != null)
					{
						foreach (global::Infragistics.Controls.Grids.CellControl.BindingDataInfo bindingDataInfo in list)
						{
							bindingDataInfo.Expression.UpdateSource();
						}
					}
					list = global::Infragistics.Controls.Grids.CellControl.ResolveBindingsFromChildren(this._operand2, true);
					if (list != null)
					{
						foreach (global::Infragistics.Controls.Grids.CellControl.BindingDataInfo bindingDataInfo2 in list)
						{
							bindingDataInfo2.Expression.UpdateSource();
						}
					}
				}
				flag |= this.ProcessOperatorOperand(this._operator1, this._operand1, this._proxyValues.ProxyValue1, rowsManager, this._contentProviderForOperand1);
				flag |= this.ProcessOperatorOperand(this._operator2, this._operand2, this._proxyValues.ProxyValue2, rowsManager, this._contentProviderForOperand2);
				if (this._andButton != null && this._andButton.IsChecked == true)
				{
					rowsFilter.Conditions.LogicalOperator = global::Infragistics.LogicalOperator.And;
				}
				else if (this._orButton != null && this._orButton.IsChecked == true)
				{
					rowsFilter.Conditions.LogicalOperator = global::Infragistics.LogicalOperator.Or;
				}
				if (flag)
				{
					rowsManager.ColumnLayout.InvalidateFiltering();
				}
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000145D8 File Offset: 0x000127D8
		public virtual void Show(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand> initialOperands)
		{
			this._defaultFilterOperand = initialOperands;
			this.Show();
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000145E8 File Offset: 0x000127E8
		public virtual void Show()
		{
			if (this._dialogPopup != null && !this._isOpen)
			{
				this._isOpen = true;
				this._dialogPopup.Child = this;
				if (!this.Cell.Row.ColumnLayout.Grid.Panel.Children.Contains(this._dialogPopup))
				{
					this.Cell.Row.ColumnLayout.Grid.Panel.Children.Add(this._dialogPopup);
				}
				global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)this._dialogPopup.Child;
				if (frameworkElement != null)
				{
					frameworkElement.SizeChanged += this.ColumnFilterDialogControl_SizeChanged;
				}
				this._dialogPopup.IsOpen = true;
				this.SetupCurrentView();
				global::Infragistics.Controls.Grids.EditableColumn editableColumn = this.Cell.Column as global::Infragistics.Controls.Grids.EditableColumn;
				if (this._operand1 != null)
				{
					this._operand1.Content = this.GetEditorForOperand("ProxyValue1", out this._contentProviderForOperand1, out this._cellForOperand1);
					if (this._operand1 != null && editableColumn != null)
					{
						this._operand1.HorizontalContentAlignment = editableColumn.EditorHorizontalContentAlignment;
					}
				}
				if (this._operand2 != null)
				{
					this._operand2.Content = this.GetEditorForOperand("ProxyValue2", out this._contentProviderForOperand2, out this._cellForOperand2);
					if (this._operand2 != null && editableColumn != null)
					{
						this._operand2.HorizontalContentAlignment = editableColumn.EditorHorizontalContentAlignment;
					}
				}
				global::Infragistics.Controls.Grids.XamGrid grid = this.Cell.Row.ColumnLayout.Grid;
				global::System.Windows.VisualStateManager.GoToState(grid, "ReadOnly", false);
				global::System.Windows.UIElement rootVisual = global::Infragistics.PlatformProxy.GetRootVisual(grid);
				this._rootVis = rootVisual;
				rootVisual.AddHandler(global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(this.KeyDownHandler), true);
				rootVisual.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.MouseLeftButtonDownHandler), true);
				grid.SizeChanged += this.Grid_SizeChanged;
				if (grid.ColumnChooserDialog.IsOpen)
				{
					grid.ColumnChooserDialog.IsOpen = false;
					this._columnChooserWasOpen = true;
				}
				base.AddHandler(global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(this.KeyDownHandler), true);
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000147F8 File Offset: 0x000129F8
		public virtual void Hide()
		{
			this._defaultFilterOperand = null;
			if (this._dialogPopup != null && this._isOpen)
			{
				this._dialogPopup.IsOpen = false;
				this._isOpen = false;
				global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)this._dialogPopup.Child;
				if (frameworkElement != null)
				{
					frameworkElement.SizeChanged -= this.ColumnFilterDialogControl_SizeChanged;
				}
				global::Infragistics.Controls.Grids.XamGrid grid = this.Cell.Row.ColumnLayout.Grid;
				if (this._rootVis != null)
				{
					this._rootVis.RemoveHandler(global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(this.KeyDownHandler));
					this._rootVis.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.MouseLeftButtonDownHandler));
				}
				base.RemoveHandler(global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(this.KeyDownHandler));
				grid.SizeChanged -= this.Grid_SizeChanged;
				this._dialogPopup.Child = null;
				if (this.Cell.Row.ColumnLayout.Grid.Panel.Children.Contains(this._dialogPopup))
				{
					this.Cell.Row.ColumnLayout.Grid.Panel.Children.Remove(this._dialogPopup);
				}
				global::System.Windows.VisualStateManager.GoToState(grid, "Active", false);
			}
			if (this._columnChooserWasOpen)
			{
				if (this.Cell != null && this.Cell.Row != null && this.Cell.Row.ColumnLayout != null)
				{
					this.Cell.Row.ColumnLayout.Grid.ColumnChooserDialog.IsOpen = true;
				}
				this._columnChooserWasOpen = false;
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0001499F File Offset: 0x00012B9F
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.AcceptCustomFilterDialogChangesCommand || command is global::Infragistics.Controls.Grids.CloseCustomFilterDialogCommand;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000149B4 File Offset: 0x00012BB4
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000149B8 File Offset: 0x00012BB8
		protected virtual bool ProcessOperatorOperand(global::System.Windows.Controls.ComboBox filterOperator, global::System.Windows.Controls.ContentControl operand, object proxyValue, global::Infragistics.Controls.Grids.RowsManager rowsManager, global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase contentProvider)
		{
			bool result = false;
			if (filterOperator != null)
			{
				global::Infragistics.Controls.Grids.FilterOperand filterOperand = filterOperator.SelectedItem as global::Infragistics.Controls.Grids.FilterOperand;
				global::Infragistics.Controls.Grids.Column column = this.Cell.Column;
				if (filterOperand != null)
				{
					object obj = null;
					bool flag = false;
					if (filterOperand.RequiresFilteringInput && operand != null)
					{
						try
						{
							global::Infragistics.Controls.Grids.Cell cell = this.Cell as global::Infragistics.Controls.Grids.Cell;
							if (cell != null)
							{
								obj = contentProvider.ResolveValueFromEditor(cell);
							}
							if (obj == null)
							{
								obj = proxyValue;
							}
							if (column.DataType != typeof(object))
							{
								obj = column.ResolveValue(obj);
							}
							flag = true;
							result = true;
							goto IL_97;
						}
						catch (global::System.FormatException)
						{
							result = true;
							goto IL_97;
						}
						catch (global::System.InvalidCastException)
						{
							result = true;
							goto IL_97;
						}
					}
					if (!filterOperand.RequiresFilteringInput)
					{
						flag = true;
						result = true;
					}
					else
					{
						result = true;
					}
					IL_97:
					if (flag)
					{
						if (column.DataType == typeof(bool?) && obj == null)
						{
							rowsManager.ColumnLayout.BuildNullableFilter(rowsManager.RowFiltersCollectionResolved, column, filterOperand, true, false, false);
						}
						else
						{
							rowsManager.ColumnLayout.BuildFilters(rowsManager.RowFiltersCollectionResolved, obj, column, filterOperand, true, false, true);
							column.ColumnLayout.Grid.OnFiltered(rowsManager.RowFiltersCollectionResolved);
						}
					}
				}
			}
			return result;
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00014AE4 File Offset: 0x00012CE4
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00014AEC File Offset: 0x00012CEC
		public global::Infragistics.Controls.Grids.CellBase Cell
		{
			get
			{
				return this._cell;
			}
			set
			{
				if (this._cell != value)
				{
					this._cell = value;
					this._defaultFilterOperand = null;
				}
				global::System.Windows.Style style = null;
				if (this._cell != null)
				{
					style = this.Cell.Column.ColumnLayout.FilteringSettings.CustomFilterDialogStyleResolved;
				}
				global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this, style);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00014B3C File Offset: 0x00012D3C
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00014B4E File Offset: 0x00012D4E
		public string CancelButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.CancelButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.CancelButtonTextProperty, value);
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00014B5C File Offset: 0x00012D5C
		private static void CancelButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl columnFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl)obj;
			columnFilterDialogControl.OnPropertyChanged("CancelButtonText");
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00014B7B File Offset: 0x00012D7B
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00014B8D File Offset: 0x00012D8D
		public string OKButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.OKButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.OKButtonTextProperty, value);
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00014B9C File Offset: 0x00012D9C
		private static void OKButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl columnFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl)obj;
			columnFilterDialogControl.OnPropertyChanged("OKButtonText");
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00014BBB File Offset: 0x00012DBB
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00014BCD File Offset: 0x00012DCD
		public string AndRadioButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.AndRadioButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.AndRadioButtonTextProperty, value);
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00014BDC File Offset: 0x00012DDC
		private static void AndRadioButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl columnFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl)obj;
			columnFilterDialogControl.OnPropertyChanged("AndRadioButtonText");
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00014BFB File Offset: 0x00012DFB
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00014C0D File Offset: 0x00012E0D
		public string OrRadioButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.OrRadioButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.OrRadioButtonTextProperty, value);
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00014C1C File Offset: 0x00012E1C
		private static void OrRadioButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl columnFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl)obj;
			columnFilterDialogControl.OnPropertyChanged("OrRadioButtonText");
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00014C3C File Offset: 0x00012E3C
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._operator1 != null)
			{
				this._operator1.SelectionChanged -= this.Operator1_SelectionChanged;
			}
			this._operator1 = (base.GetTemplateChild("Operator1") as global::System.Windows.Controls.ComboBox);
			if (this._operator1 != null)
			{
				this._operator1.SelectionChanged += this.Operator1_SelectionChanged;
			}
			if (this._operator2 != null)
			{
				this._operator2.SelectionChanged -= this.Operator2_SelectionChanged;
			}
			this._operator2 = (base.GetTemplateChild("Operator2") as global::System.Windows.Controls.ComboBox);
			if (this._operator2 != null)
			{
				this._operator2.SelectionChanged += this.Operator2_SelectionChanged;
			}
			this._andButton = (base.GetTemplateChild("And") as global::System.Windows.Controls.RadioButton);
			this._orButton = (base.GetTemplateChild("Or") as global::System.Windows.Controls.RadioButton);
			this._operand1 = (base.GetTemplateChild("Operand1") as global::System.Windows.Controls.ContentControl);
			this._operand2 = (base.GetTemplateChild("Operand2") as global::System.Windows.Controls.ContentControl);
			this.SetupCurrentView();
			if (this.Cell != null)
			{
				global::Infragistics.Controls.Grids.EditableColumn editableColumn = this.Cell.Column as global::Infragistics.Controls.Grids.EditableColumn;
				if (this._operand1 != null)
				{
					this._operand1.Content = this.GetEditorForOperand("ProxyValue1", out this._contentProviderForOperand1, out this._cellForOperand1);
					if (editableColumn != null)
					{
						this._operand1.HorizontalContentAlignment = editableColumn.EditorHorizontalContentAlignment;
					}
				}
				if (this._operand2 != null)
				{
					this._operand2.Content = this.GetEditorForOperand("ProxyValue2", out this._contentProviderForOperand2, out this._cellForOperand2);
					if (editableColumn != null)
					{
						this._operand2.HorizontalContentAlignment = editableColumn.EditorHorizontalContentAlignment;
					}
				}
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00014DF0 File Offset: 0x00012FF0
		private global::System.Windows.FrameworkElement GetEditorForOperand(string operandToLinkTo, out global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase contentProviderControl, out global::Infragistics.Controls.Grids.Cell cellOutput)
		{
			global::Infragistics.Controls.Grids.Column column = this.Cell.Column;
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = column.ColumnLayout;
			global::Infragistics.Controls.Grids.TemplateColumn templateColumn = column as global::Infragistics.Controls.Grids.TemplateColumn;
			global::Infragistics.Controls.Grids.UnboundColumn unboundColumn = column as global::Infragistics.Controls.Grids.UnboundColumn;
			global::Infragistics.Controls.Grids.RowsManager manager = new global::Infragistics.Controls.Grids.RowsManager(0, columnLayout, null);
			global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)this.Cell.Row.Manager;
			global::Infragistics.Controls.Grids.Primitives.FilterRow filterRow = new global::Infragistics.Controls.Grids.Primitives.FilterRow(manager);
			global::Infragistics.Controls.Grids.Primitives.FilterRowCell filterRowCell = new global::Infragistics.Controls.Grids.Primitives.FilterRowCell(filterRow, column);
			global::System.Windows.Data.Binding editorBinding = this.ResolveEditorBinding(filterRowCell, this._proxyValues, operandToLinkTo);
			global::Infragistics.Controls.Grids.CellControl cellControl = new global::Infragistics.Controls.Grids.CellControl();
			filterRowCell.Control = cellControl;
			cellControl.OnAttached(filterRowCell);
			filterRowCell.Control.EnsureContent();
			global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase columnContentProviderBase = this.Cell.Column.GenerateContentProvider();
			object editorValue = (operandToLinkTo == "ProxyValue1") ? this._proxyValues.ProxyValue1 : this._proxyValues.ProxyValue2;
			global::System.Windows.FrameworkElement frameworkElement = columnContentProviderBase.ResolveEditor(filterRowCell, null, editorValue, 200.0, 200.0, editorBinding);
			if (templateColumn != null)
			{
				if (templateColumn.FilterEditorTemplate == null)
				{
					throw new global::System.ArgumentNullException(global::Infragistics.SRGrid.GetString("TemplateColumn_RequireFilterEditorTemplate"));
				}
				filterRow.SetData(rowsManager.GenerateNewObject(global::Infragistics.Controls.Grids.RowType.FilterRow));
				global::Infragistics.Controls.Grids.Primitives.CustomFilterDialogFilteringDataContext dataContext = new global::Infragistics.Controls.Grids.Primitives.CustomFilterDialogFilteringDataContext(filterRowCell, this._proxyValues, operandToLinkTo);
				frameworkElement.DataContext = dataContext;
			}
			else if (unboundColumn != null)
			{
				if (unboundColumn.FilterEditorTemplate == null)
				{
					throw new global::System.ArgumentNullException(global::Infragistics.SRGrid.GetString("UnboundColumn_RequireFilterEditorTemplate"));
				}
				filterRow.SetData(rowsManager.GenerateNewObject(global::Infragistics.Controls.Grids.RowType.FilterRow));
				global::Infragistics.Controls.Grids.Primitives.CustomFilterDialogFilteringDataContext dataContext2 = new global::Infragistics.Controls.Grids.Primitives.CustomFilterDialogFilteringDataContext(filterRowCell, this._proxyValues, operandToLinkTo);
				frameworkElement.DataContext = dataContext2;
			}
			if (frameworkElement != null)
			{
				frameworkElement.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
			}
			contentProviderControl = columnContentProviderBase;
			cellOutput = filterRowCell;
			return frameworkElement;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00014F84 File Offset: 0x00013184
		protected internal virtual global::System.Windows.Data.Binding ResolveEditorBinding(global::Infragistics.Controls.Grids.CellBase cell, object data, string objectToLinkTo)
		{
			global::System.Windows.Data.Binding binding = null;
			if (cell.Control != null)
			{
				binding = cell.Control.ResolveEditorBinding();
			}
			if (binding == null && cell.Column.Key != null)
			{
				binding = new global::System.Windows.Data.Binding();
				binding.Path = new global::System.Windows.PropertyPath(objectToLinkTo, new object[0]);
				binding.Source = data;
				binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
				binding.ConverterCulture = global::System.Globalization.CultureInfo.CurrentCulture;
				binding.UpdateSourceTrigger = global::System.Windows.Data.UpdateSourceTrigger.Default;
				binding.ConverterParameter = cell;
				binding.Converter = new global::Infragistics.Controls.Grids.Cell.CellEditingBindingConverter();
				global::Infragistics.Controls.Grids.EditableColumn editableColumn = cell.Column as global::Infragistics.Controls.Grids.EditableColumn;
				if (editableColumn != null)
				{
					binding.ValidatesOnDataErrors = (binding.ValidatesOnExceptions = (binding.NotifyOnValidationError = editableColumn.AllowEditingValidation));
				}
			}
			return binding;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00015032 File Offset: 0x00013232
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.AcceptCustomFilterDialogChangesCommand || command is global::Infragistics.Controls.Grids.CloseCustomFilterDialogCommand;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00015047 File Offset: 0x00013247
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000474 RID: 1140 RVA: 0x00015050 File Offset: 0x00013250
		// (remove) Token: 0x06000475 RID: 1141 RVA: 0x00015088 File Offset: 0x00013288
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000476 RID: 1142 RVA: 0x000150BD File Offset: 0x000132BD
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x0400011A RID: 282
		private global::System.Windows.Controls.Primitives.Popup _dialogPopup;

		// Token: 0x0400011B RID: 283
		private global::Infragistics.Controls.Grids.CellBase _cell;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Controls.ComboBox _operator1;

		// Token: 0x0400011D RID: 285
		private global::System.Windows.Controls.ComboBox _operator2;

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Controls.RadioButton _andButton;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Controls.RadioButton _orButton;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Controls.ContentControl _operand1;

		// Token: 0x04000121 RID: 289
		private global::System.Windows.Controls.ContentControl _operand2;

		// Token: 0x04000122 RID: 290
		private global::Infragistics.Controls.Grids.Primitives.ProxyValueContainer _proxyValues = new global::Infragistics.Controls.Grids.Primitives.ProxyValueContainer();

		// Token: 0x04000123 RID: 291
		private global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase _contentProviderForOperand1;

		// Token: 0x04000124 RID: 292
		private global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase _contentProviderForOperand2;

		// Token: 0x04000125 RID: 293
		private global::Infragistics.Controls.Grids.Cell _cellForOperand1;

		// Token: 0x04000126 RID: 294
		private global::Infragistics.Controls.Grids.Cell _cellForOperand2;

		// Token: 0x04000127 RID: 295
		private bool _columnChooserWasOpen;

		// Token: 0x04000128 RID: 296
		private bool _isOpen;

		// Token: 0x04000129 RID: 297
		private global::System.Windows.UIElement _rootVis;

		// Token: 0x0400012A RID: 298
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand> _defaultFilterOperand;

		// Token: 0x0400012B RID: 299
		public static readonly global::System.Windows.DependencyProperty CancelButtonTextProperty = global::System.Windows.DependencyProperty.Register("CancelButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.CancelButtonTextChanged)));

		// Token: 0x0400012C RID: 300
		public static readonly global::System.Windows.DependencyProperty OKButtonTextProperty = global::System.Windows.DependencyProperty.Register("OKButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.OKButtonTextChanged)));

		// Token: 0x0400012D RID: 301
		public static readonly global::System.Windows.DependencyProperty AndRadioButtonTextProperty = global::System.Windows.DependencyProperty.Register("AndRadioButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.AndRadioButtonTextChanged)));

		// Token: 0x0400012E RID: 302
		public static readonly global::System.Windows.DependencyProperty OrRadioButtonTextProperty = global::System.Windows.DependencyProperty.Register("OrRadioButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl.OrRadioButtonTextChanged)));
	}
}
