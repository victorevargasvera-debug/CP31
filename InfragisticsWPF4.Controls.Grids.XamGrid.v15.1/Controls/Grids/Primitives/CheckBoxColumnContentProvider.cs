using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000238 RID: 568
	public class CheckBoxColumnContentProvider : global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase
	{
		// Token: 0x060010EB RID: 4331 RVA: 0x0003E87D File Offset: 0x0003CA7D
		public CheckBoxColumnContentProvider()
		{
			this._cb = new global::System.Windows.Controls.CheckBox();
			this._cb.ClickMode = global::System.Windows.Controls.ClickMode.Press;
			this._tb = new global::System.Windows.Controls.TextBlock();
			this._isCheckedPropertyBound = false;
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0003E8B0 File Offset: 0x0003CAB0
		public override global::System.Windows.FrameworkElement ResolveDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			this._cb.IsThreeState = (cell.Column.DataType == typeof(bool?));
			global::Infragistics.Controls.Grids.CheckBoxColumn checkBoxColumn = (global::Infragistics.Controls.Grids.CheckBoxColumn)cell.Column;
			this.ApplyBindingToDisplayElement(cell, cellBinding);
			if (cell.EnableCustomEditorBehaviors && checkBoxColumn.EditorDisplayBehavior == global::Infragistics.Controls.Grids.EditorDisplayBehaviors.EditMode)
			{
				return this._tb;
			}
			this._cb.IsEnabled = cell.IsEditable;
			global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this._cb, cell.EditorStyleResolved);
			bool flag = false;
			if (cell.EnableCustomEditorBehaviors)
			{
				flag = (checkBoxColumn.EditorDisplayBehavior == global::Infragistics.Controls.Grids.EditorDisplayBehaviors.Always);
			}
			this._cb.IsHitTestVisible = flag;
			this._cb.Focusable = flag;
			return this._cb;
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0003E964 File Offset: 0x0003CB64
		private void ApplyBindingToDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding binding)
		{
			if (binding != null)
			{
				binding.ValidatesOnDataErrors = (binding.ValidatesOnExceptions = (binding.NotifyOnValidationError = ((global::Infragistics.Controls.Grids.CheckBoxColumn)cell.Column).AllowEditingValidation));
				global::Infragistics.Controls.Grids.CheckBoxColumn checkBoxColumn = (global::Infragistics.Controls.Grids.CheckBoxColumn)cell.Column;
				if (cell.EnableCustomEditorBehaviors && checkBoxColumn.EditorDisplayBehavior == global::Infragistics.Controls.Grids.EditorDisplayBehaviors.EditMode)
				{
					this._tb.SetBinding(global::System.Windows.Controls.TextBlock.TextProperty, binding);
					return;
				}
				this._cb.SetBinding(global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, binding);
				this._isCheckedPropertyBound = true;
			}
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0003E9E8 File Offset: 0x0003CBE8
		public override void AdjustDisplayElement(global::Infragistics.Controls.Grids.Cell cell)
		{
			bool flag = cell.Row.Data == null;
			if (this._dataWasNull && !flag)
			{
				global::System.Windows.Data.Binding binding = this.ResolveBinding(cell);
				if (binding != null)
				{
					binding.ValidatesOnDataErrors = (binding.ValidatesOnExceptions = (binding.NotifyOnValidationError = ((global::Infragistics.Controls.Grids.CheckBoxColumn)cell.Column).AllowEditingValidation));
					global::Infragistics.Controls.Grids.CheckBoxColumn checkBoxColumn = (global::Infragistics.Controls.Grids.CheckBoxColumn)cell.Column;
					if (cell.EnableCustomEditorBehaviors && checkBoxColumn.EditorDisplayBehavior == global::Infragistics.Controls.Grids.EditorDisplayBehaviors.EditMode)
					{
						this._tb.SetBinding(global::System.Windows.Controls.TextBlock.TextProperty, binding);
					}
					else
					{
						this._cb.SetBinding(global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, binding);
						this._isCheckedPropertyBound = true;
					}
				}
				this._cb.IsEnabled = cell.IsEditable;
			}
			this._dataWasNull = flag;
			base.AdjustDisplayElement(cell);
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0003EAB4 File Offset: 0x0003CCB4
		protected override global::System.Windows.FrameworkElement ResolveEditorControl(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			this._cb.IsHitTestVisible = true;
			this._cb.Focusable = true;
			global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this._cb, cell.EditorStyleResolved);
			this._cb.IsThreeState = (cell.Column.DataType == typeof(bool?));
			if (this._cb.GetBindingExpression(global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty) == null && editorBinding != null)
			{
				this._cb.SetBinding(global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, editorBinding);
				this._isCheckedPropertyBound = true;
			}
			if (cell.IsEditing)
			{
				this._cb.Focus();
			}
			return this._cb;
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0003EB59 File Offset: 0x0003CD59
		public override object ResolveValueFromEditor(global::Infragistics.Controls.Grids.Cell cell)
		{
			return this._cb.IsChecked;
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0003EB6B File Offset: 0x0003CD6B
		protected internal override void FocusEditor()
		{
			if (this._cb != null)
			{
				this._cb.Focus();
			}
		}

		// Token: 0x0400054B RID: 1355
		private global::System.Windows.Controls.CheckBox _cb;

		// Token: 0x0400054C RID: 1356
		private global::System.Windows.Controls.TextBlock _tb;

		// Token: 0x0400054D RID: 1357
		private bool _isCheckedPropertyBound;

		// Token: 0x0400054E RID: 1358
		private bool _dataWasNull;
	}
}
