using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200024B RID: 587
	public class DateColumnContentProvider : global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase
	{
		// Token: 0x0600127A RID: 4730 RVA: 0x000454F3 File Offset: 0x000436F3
		public DateColumnContentProvider()
		{
			this._dp = new global::System.Windows.Controls.DatePicker();
			this._dpEditor = new global::System.Windows.Controls.DatePicker();
			this._tb = new global::System.Windows.Controls.TextBlock();
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0004551C File Offset: 0x0004371C
		public override global::System.Windows.FrameworkElement ResolveDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			if (this._dp != null && cell.Control != null)
			{
				this._dp.SetBinding(global::System.Windows.FrameworkElement.FlowDirectionProperty, new global::System.Windows.Data.Binding("FlowDirection")
				{
					Source = cell.Control
				});
			}
			global::Infragistics.Controls.Grids.DateColumn dateColumn = (global::Infragistics.Controls.Grids.DateColumn)cell.Column;
			if (cell.EnableCustomEditorBehaviors && dateColumn.EditorDisplayBehavior == global::Infragistics.Controls.Grids.EditorDisplayBehaviors.EditMode && cellBinding != null)
			{
				switch (dateColumn.SelectedDateFormat)
				{
				case global::System.Windows.Controls.DatePickerFormat.Long:
					cellBinding.StringFormat = global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern;
					break;
				case global::System.Windows.Controls.DatePickerFormat.Short:
					cellBinding.StringFormat = global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
					break;
				}
				this.ApplyBindingToDisplayElement(cell, cellBinding);
				return this._tb;
			}
			global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this._dp, cell.EditorStyleResolved);
			bool flag = false;
			if (cell.EnableCustomEditorBehaviors)
			{
				flag = (dateColumn.EditorDisplayBehavior == global::Infragistics.Controls.Grids.EditorDisplayBehaviors.Always);
			}
			this._dp.IsHitTestVisible = flag;
			this._dp.Focusable = flag;
			this._dp.SelectedDateFormat = dateColumn.SelectedDateFormat;
			this._dp.IsEnabled = this.IsEnabledResolved(cell, dateColumn);
			this.ApplyBindingToDisplayElement(cell, cellBinding);
			return this._dp;
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00045644 File Offset: 0x00043844
		private void ApplyBindingToDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding binding)
		{
			if (binding != null)
			{
				binding.ValidatesOnDataErrors = (binding.ValidatesOnExceptions = (binding.NotifyOnValidationError = false));
				global::Infragistics.Controls.Grids.DateColumn dateColumn = (global::Infragistics.Controls.Grids.DateColumn)cell.Column;
				if (cell.EnableCustomEditorBehaviors && dateColumn.EditorDisplayBehavior == global::Infragistics.Controls.Grids.EditorDisplayBehaviors.EditMode)
				{
					this._tb.SetBinding(global::System.Windows.Controls.TextBlock.TextProperty, binding);
					return;
				}
				this._dp.SetBinding(global::System.Windows.Controls.DatePicker.SelectedDateProperty, binding);
			}
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x000456B0 File Offset: 0x000438B0
		protected override global::System.Windows.FrameworkElement ResolveEditorControl(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			if (this._dpEditor != null && cell.Control != null)
			{
				this._dpEditor.SetBinding(global::System.Windows.FrameworkElement.FlowDirectionProperty, new global::System.Windows.Data.Binding("FlowDirection")
				{
					Source = cell.Control
				});
			}
			editorBinding.ValidatesOnDataErrors = (editorBinding.ValidatesOnExceptions = (editorBinding.NotifyOnValidationError = ((global::Infragistics.Controls.Grids.DateColumn)cell.Column).AllowEditingValidation));
			global::Infragistics.Controls.Grids.DateColumn col = (global::Infragistics.Controls.Grids.DateColumn)cell.Column;
			this._dpEditor.SetBinding(global::System.Windows.Controls.DatePicker.SelectedDateProperty, editorBinding);
			this._dpEditor.SelectedDateChanged -= this.DatePicker_SelectedDateChanged;
			this._dpEditor.SelectedDateChanged += this.DatePicker_SelectedDateChanged;
			global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this._dpEditor, cell.EditorStyleResolved);
			if (cell.IsEditing)
			{
				this._dpEditor.Focus();
			}
			this._dpEditor.SelectedDateFormat = ((global::Infragistics.Controls.Grids.DateColumn)cell.Column).SelectedDateFormat;
			this._dp.IsEnabled = this.IsEnabledResolved(cell, col);
			return this._dpEditor;
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x000457C8 File Offset: 0x000439C8
		public override object ResolveValueFromEditor(global::Infragistics.Controls.Grids.Cell cell)
		{
			global::System.Windows.Controls.Primitives.DatePickerTextBox datePickerTextBox = global::Infragistics.PlatformProxy.GetFocusedElement(this._dpEditor) as global::System.Windows.Controls.Primitives.DatePickerTextBox;
			if (datePickerTextBox != null)
			{
				global::System.Windows.DependencyObject dependencyObject = datePickerTextBox;
				while (dependencyObject != null)
				{
					dependencyObject = global::Infragistics.PlatformProxy.GetParent(dependencyObject);
					if (dependencyObject == this._dpEditor)
					{
						if (string.IsNullOrEmpty(datePickerTextBox.Text))
						{
							this._dpEditor.SelectedDate = null;
							break;
						}
						this.AdjustDatePicker_WPF(datePickerTextBox);
						break;
					}
				}
			}
			else
			{
				datePickerTextBox = this.FindDatePickerTextBox(this._dpEditor);
				if (datePickerTextBox != null)
				{
					if (string.IsNullOrEmpty(datePickerTextBox.Text))
					{
						this._dpEditor.SelectedDate = null;
					}
					else
					{
						this.AdjustDatePicker_WPF(datePickerTextBox);
					}
				}
			}
			return this._dpEditor.SelectedDate;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00045878 File Offset: 0x00043A78
		public override void AdjustDisplayElement(global::Infragistics.Controls.Grids.Cell cell)
		{
			global::Infragistics.Controls.Grids.DateColumn col = (global::Infragistics.Controls.Grids.DateColumn)cell.Column;
			if (cell.Row.Data != null && this._dp.GetBindingExpression(global::System.Windows.Controls.DatePicker.SelectedDateProperty) == null)
			{
				global::System.Windows.Data.Binding binding = this.ResolveBinding(cell);
				if (binding != null)
				{
					binding.ValidatesOnDataErrors = (binding.ValidatesOnExceptions = (binding.NotifyOnValidationError = false));
					this._dp.SetBinding(global::System.Windows.Controls.DatePicker.SelectedDateProperty, binding);
				}
			}
			if (this._dp.SelectedDate == null && !string.IsNullOrEmpty(this._dp.Text))
			{
				this._dp.OnApplyTemplate();
			}
			global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this._dp, cell.EditorStyleResolved);
			this._dp.IsEnabled = this.IsEnabledResolved(cell, col);
			base.AdjustDisplayElement(cell);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0004594F File Offset: 0x00043B4F
		public override void EditorRemoved()
		{
			base.EditorRemoved();
			if (this._dpEditor != null)
			{
				this._dpEditor.SelectedDateChanged -= this.DatePicker_SelectedDateChanged;
				this._dpEditor.ClearValue(global::System.Windows.Controls.DatePicker.SelectedDateProperty);
			}
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00045988 File Offset: 0x00043B88
		private global::System.Windows.Controls.Primitives.DatePickerTextBox FindDatePickerTextBox(global::System.Windows.DependencyObject obj)
		{
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(obj);
			for (int i = 0; i < childrenCount; i++)
			{
				global::System.Windows.DependencyObject child = global::System.Windows.Media.VisualTreeHelper.GetChild(obj, i);
				global::System.Windows.Controls.Primitives.DatePickerTextBox datePickerTextBox = child as global::System.Windows.Controls.Primitives.DatePickerTextBox;
				if (datePickerTextBox != null)
				{
					return datePickerTextBox;
				}
				datePickerTextBox = this.FindDatePickerTextBox(child);
				if (datePickerTextBox != null)
				{
					return datePickerTextBox;
				}
			}
			return null;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x000459CA File Offset: 0x00043BCA
		private bool IsEnabledResolved(global::Infragistics.Controls.Grids.Cell cell, global::Infragistics.Controls.Grids.DateColumn col)
		{
			if (col.IsReadOnly)
			{
				return false;
			}
			if (cell.EnableCustomEditorBehaviors)
			{
				return cell.IsEditable | col.EditorDisplayBehavior == global::Infragistics.Controls.Grids.EditorDisplayBehaviors.Always;
			}
			return cell.IsEditable;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x000459F8 File Offset: 0x00043BF8
		public override void EditorLoaded()
		{
			if (this._dpEditor == global::System.Windows.Input.FocusManager.GetFocusedElement(global::System.Windows.Input.FocusManager.GetFocusScope(this._dpEditor)))
			{
				global::System.Windows.Controls.Primitives.DatePickerTextBox datePickerTextBox = this.FindDatePickerTextBox(this._dpEditor);
				if (datePickerTextBox != null)
				{
					datePickerTextBox.Focus();
				}
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00045A34 File Offset: 0x00043C34
		protected internal override void FocusEditor()
		{
			if (this._dpEditor != null)
			{
				this._dpEditor.Focus();
			}
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00045A4C File Offset: 0x00043C4C
		private void AdjustDatePicker_WPF(global::System.Windows.Controls.Primitives.DatePickerTextBox dptb)
		{
			string text = dptb.Text;
			if (this._dpEditor.SelectedDate == null)
			{
				this._dpEditor.Text = string.Empty;
				this._dpEditor.Text = text;
				return;
			}
			if (string.IsNullOrEmpty(text))
			{
				this._dpEditor.SelectedDate = null;
				this._dpEditor.Text = text;
				return;
			}
			global::System.DateTime value = this._dpEditor.SelectedDate.Value;
			this._dpEditor.Text = string.Empty;
			this._dpEditor.Text = text;
			if (this._dpEditor.SelectedDate == null)
			{
				this._dpEditor.SelectedDate = new global::System.DateTime?(value);
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00045B14 File Offset: 0x00043D14
		private void DatePicker_SelectedDateChanged(object sender, global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			object value = null;
			if (e.AddedItems != null && e.AddedItems.Count > 0)
			{
				value = e.AddedItems[0];
			}
			base.NotifyEditorValueChanged(value);
		}

		// Token: 0x040005D3 RID: 1491
		private global::System.Windows.Controls.DatePicker _dp;

		// Token: 0x040005D4 RID: 1492
		private global::System.Windows.Controls.DatePicker _dpEditor;

		// Token: 0x040005D5 RID: 1493
		private global::System.Windows.Controls.TextBlock _tb;
	}
}
