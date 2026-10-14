using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200000A RID: 10
	public class DataGridHyperlinkColumn : global::Microsoft.Windows.Controls.DataGridBoundColumn
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00004488 File Offset: 0x00002688
		static DataGridHyperlinkColumn()
		{
			global::Microsoft.Windows.Controls.DataGridBoundColumn.ElementStyleProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridHyperlinkColumn), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridHyperlinkColumn.DefaultElementStyle));
			global::Microsoft.Windows.Controls.DataGridBoundColumn.EditingElementStyleProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridHyperlinkColumn), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridHyperlinkColumn.DefaultEditingElementStyle));
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000044FC File Offset: 0x000026FC
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000450E File Offset: 0x0000270E
		public string TargetName
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Windows.Controls.DataGridHyperlinkColumn.TargetNameProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridHyperlinkColumn.TargetNameProperty, value);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000451C File Offset: 0x0000271C
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00004524 File Offset: 0x00002724
		public global::System.Windows.Data.BindingBase ContentBinding
		{
			get
			{
				return this._contentBinding;
			}
			set
			{
				if (this._contentBinding != value)
				{
					global::System.Windows.Data.BindingBase contentBinding = this._contentBinding;
					this._contentBinding = value;
					this.OnContentBindingChanged(contentBinding, value);
				}
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004550 File Offset: 0x00002750
		protected virtual void OnContentBindingChanged(global::System.Windows.Data.BindingBase oldBinding, global::System.Windows.Data.BindingBase newBinding)
		{
			base.NotifyPropertyChanged("ContentBinding");
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000455D File Offset: 0x0000275D
		private void ApplyContentBinding(global::System.Windows.DependencyObject target, global::System.Windows.DependencyProperty property)
		{
			if (this.ContentBinding != null)
			{
				global::System.Windows.Data.BindingOperations.SetBinding(target, property, this.ContentBinding);
				return;
			}
			if (this.Binding != null)
			{
				global::System.Windows.Data.BindingOperations.SetBinding(target, property, this.Binding);
				return;
			}
			global::System.Windows.Data.BindingOperations.ClearBinding(target, property);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004594 File Offset: 0x00002794
		protected internal override void RefreshCellContent(global::System.Windows.FrameworkElement element, string propertyName)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = element as global::Microsoft.Windows.Controls.DataGridCell;
			if (dataGridCell != null && !dataGridCell.IsEditing)
			{
				if (string.Compare(propertyName, "ContentBinding", global::System.StringComparison.Ordinal) == 0)
				{
					dataGridCell.BuildVisualTree();
					return;
				}
				if (string.Compare(propertyName, "TargetName", global::System.StringComparison.Ordinal) == 0)
				{
					global::System.Windows.Controls.TextBlock textBlock = dataGridCell.Content as global::System.Windows.Controls.TextBlock;
					if (textBlock != null && textBlock.Inlines.Count > 0)
					{
						global::System.Windows.Documents.Hyperlink hyperlink = textBlock.Inlines.FirstInline as global::System.Windows.Documents.Hyperlink;
						if (hyperlink != null)
						{
							hyperlink.TargetName = this.TargetName;
							return;
						}
					}
				}
			}
			else
			{
				base.RefreshCellContent(element, propertyName);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000461C File Offset: 0x0000281C
		public static global::System.Windows.Style DefaultElementStyle
		{
			get
			{
				return global::Microsoft.Windows.Controls.DataGridTextColumn.DefaultElementStyle;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00004623 File Offset: 0x00002823
		public static global::System.Windows.Style DefaultEditingElementStyle
		{
			get
			{
				return global::Microsoft.Windows.Controls.DataGridTextColumn.DefaultEditingElementStyle;
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000462C File Offset: 0x0000282C
		protected override global::System.Windows.FrameworkElement GenerateElement(global::Microsoft.Windows.Controls.DataGridCell cell, object dataItem)
		{
			global::System.Windows.Controls.TextBlock textBlock = new global::System.Windows.Controls.TextBlock();
			global::System.Windows.Documents.Hyperlink hyperlink = new global::System.Windows.Documents.Hyperlink();
			global::System.Windows.Documents.InlineUIContainer inlineUIContainer = new global::System.Windows.Documents.InlineUIContainer();
			global::System.Windows.Controls.ContentPresenter contentPresenter = new global::System.Windows.Controls.ContentPresenter();
			textBlock.Inlines.Add(hyperlink);
			hyperlink.Inlines.Add(inlineUIContainer);
			inlineUIContainer.Child = contentPresenter;
			hyperlink.TargetName = this.TargetName;
			base.ApplyStyle(false, false, textBlock);
			base.ApplyBinding(hyperlink, global::System.Windows.Documents.Hyperlink.NavigateUriProperty);
			this.ApplyContentBinding(contentPresenter, global::System.Windows.Controls.ContentPresenter.ContentProperty);
			return textBlock;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000046A0 File Offset: 0x000028A0
		protected override global::System.Windows.FrameworkElement GenerateEditingElement(global::Microsoft.Windows.Controls.DataGridCell cell, object dataItem)
		{
			global::System.Windows.Controls.TextBox textBox = new global::System.Windows.Controls.TextBox();
			base.ApplyStyle(true, false, textBox);
			base.ApplyBinding(textBox, global::System.Windows.Controls.TextBox.TextProperty);
			return textBox;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000046CC File Offset: 0x000028CC
		protected override object PrepareCellForEdit(global::System.Windows.FrameworkElement editingElement, global::System.Windows.RoutedEventArgs editingEventArgs)
		{
			global::System.Windows.Controls.TextBox textBox = editingElement as global::System.Windows.Controls.TextBox;
			if (textBox != null)
			{
				textBox.Focus();
				string text = textBox.Text;
				global::System.Windows.Input.TextCompositionEventArgs textCompositionEventArgs = editingEventArgs as global::System.Windows.Input.TextCompositionEventArgs;
				if (textCompositionEventArgs != null)
				{
					string text2 = textCompositionEventArgs.Text;
					textBox.Text = text2;
					textBox.Select(text2.Length, 0);
				}
				else
				{
					textBox.SelectAll();
				}
				return text;
			}
			return null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004724 File Offset: 0x00002924
		protected override bool CommitCellEdit(global::System.Windows.FrameworkElement editingElement)
		{
			global::System.Windows.Controls.TextBox textBox = editingElement as global::System.Windows.Controls.TextBox;
			if (textBox != null)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.UpdateSource(textBox, global::System.Windows.Controls.TextBox.TextProperty);
				return !global::System.Windows.Controls.Validation.GetHasError(textBox);
			}
			return true;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004754 File Offset: 0x00002954
		protected override void CancelCellEdit(global::System.Windows.FrameworkElement editingElement, object uneditedValue)
		{
			global::System.Windows.Controls.TextBox textBox = editingElement as global::System.Windows.Controls.TextBox;
			if (textBox != null)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.UpdateTarget(textBox, global::System.Windows.Controls.TextBox.TextProperty);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004776 File Offset: 0x00002976
		internal override void OnInput(global::System.Windows.Input.InputEventArgs e)
		{
			if (global::Microsoft.Windows.Controls.DataGridHelper.HasNonEscapeCharacters(e as global::System.Windows.Input.TextCompositionEventArgs))
			{
				base.BeginEdit(e);
			}
		}

		// Token: 0x0400002E RID: 46
		public static readonly global::System.Windows.DependencyProperty TargetNameProperty = global::System.Windows.Documents.Hyperlink.TargetNameProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridHyperlinkColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Data.BindingBase _contentBinding;
	}
}
