using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200025F RID: 607
	public class TextColumnContentProvider : global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase
	{
		// Token: 0x06001379 RID: 4985 RVA: 0x000494F7 File Offset: 0x000476F7
		public TextColumnContentProvider()
		{
			this._tb = new global::System.Windows.Controls.TextBlock();
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0004950C File Offset: 0x0004770C
		public override global::System.Windows.FrameworkElement ResolveDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			global::Infragistics.Controls.Grids.TextColumn textColumn = (global::Infragistics.Controls.Grids.TextColumn)cell.Column;
			this._tb.TextWrapping = textColumn.TextWrapping;
			this._tb.Style = textColumn.TextBlockStyle;
			this.ApplyBindingToDisplayElement(cell, cellBinding);
			return this._tb;
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00049555 File Offset: 0x00047755
		private void ApplyBindingToDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			if (cellBinding != null)
			{
				this._tb.SetBinding(global::System.Windows.Controls.TextBlock.TextProperty, cellBinding);
				this._bindingSet = true;
				this._resetBindingSet = (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow);
			}
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00049588 File Offset: 0x00047788
		protected override global::System.Windows.FrameworkElement ResolveEditorControl(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			if (this._editor != null && cell.Control != null)
			{
				this._editor.SetBinding(global::System.Windows.FrameworkElement.FlowDirectionProperty, new global::System.Windows.Data.Binding
				{
					Source = cell.Control,
					Path = new global::System.Windows.PropertyPath("FlowDirection", new object[0])
				});
			}
			if (this._editor == null)
			{
				this._editor = new global::System.Windows.Controls.TextBox();
			}
			this._editor.TextChanged -= this.Editor_TextChanged;
			this._editor.TextChanged += this.Editor_TextChanged;
			global::Infragistics.Controls.Grids.TextColumn textColumn = (global::Infragistics.Controls.Grids.TextColumn)cell.Column;
			global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this._editor, cell.EditorStyleResolved);
			this._editor.TextWrapping = textColumn.TextWrapping;
			if (editorBinding != null)
			{
				this._editor.SetBinding(global::System.Windows.Controls.TextBox.TextProperty, editorBinding);
			}
			return this._editor;
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0004966C File Offset: 0x0004786C
		public override object ResolveValueFromEditor(global::Infragistics.Controls.Grids.Cell cell)
		{
			object result = null;
			if (this._editor != null)
			{
				result = this._editor.Text;
			}
			return result;
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00049690 File Offset: 0x00047890
		public override void EditorLoaded()
		{
			if (this._editor != null)
			{
				this._editor.SelectAll();
			}
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x000496A8 File Offset: 0x000478A8
		public override object ApplyFormatting(object value, global::Infragistics.Controls.Grids.Column column, global::System.Globalization.CultureInfo culture)
		{
			global::Infragistics.Controls.Grids.TextColumn textColumn = (global::Infragistics.Controls.Grids.TextColumn)column;
			if (!string.IsNullOrEmpty(textColumn.FormatString))
			{
				return string.Format(culture, textColumn.FormatString, new object[]
				{
					value
				});
			}
			if (!string.IsNullOrEmpty(textColumn.DataField.FormatString))
			{
				return string.Format(culture, textColumn.DataField.FormatString, new object[]
				{
					value
				});
			}
			return base.ApplyFormatting(value, column, culture);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0004971C File Offset: 0x0004791C
		public override void AdjustDisplayElement(global::Infragistics.Controls.Grids.Cell cell)
		{
			base.AdjustDisplayElement(cell);
			if (!this._bindingSet)
			{
				global::System.Windows.Data.Binding binding = this.ResolveBinding(cell);
				if (binding != null)
				{
					this._tb.SetBinding(global::System.Windows.Controls.TextBlock.TextProperty, binding);
					this._bindingSet = true;
				}
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0004975C File Offset: 0x0004795C
		public override void ResetContent()
		{
			base.ResetContent();
			if (this._resetBindingSet)
			{
				this._bindingSet = false;
			}
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00049773 File Offset: 0x00047973
		protected internal override void FocusEditor()
		{
			if (this._editor != null)
			{
				this._editor.Focus();
			}
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00049789 File Offset: 0x00047989
		public override void EditorRemoved()
		{
			if (this._editor != null && !this.IsFilterRowCellEditor())
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(this._editor, global::System.Windows.Controls.TextBox.TextProperty);
			}
			base.EditorRemoved();
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x000497B4 File Offset: 0x000479B4
		private bool IsFilterRowCellEditor()
		{
			if (this._editor == null)
			{
				return false;
			}
			global::System.Windows.Data.BindingExpression bindingExpression = this._editor.GetBindingExpression(global::System.Windows.Controls.TextBox.TextProperty);
			return bindingExpression != null && bindingExpression.DataItem != null && (bindingExpression.DataItem is global::Infragistics.Controls.Grids.Primitives.FilterRowCell || bindingExpression.DataItem is global::Infragistics.Controls.Grids.FilterColumnSettings);
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00049808 File Offset: 0x00047A08
		public override bool RemovePaddingDuringEditing
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0004980B File Offset: 0x00047A0B
		private void Editor_TextChanged(object sender, global::System.Windows.Controls.TextChangedEventArgs e)
		{
			base.NotifyEditorValueChanged(this._editor.Text);
		}

		// Token: 0x040005FB RID: 1531
		private global::System.Windows.Controls.TextBlock _tb;

		// Token: 0x040005FC RID: 1532
		private global::System.Windows.Controls.TextBox _editor;

		// Token: 0x040005FD RID: 1533
		private bool _bindingSet;

		// Token: 0x040005FE RID: 1534
		private bool _resetBindingSet;
	}
}
