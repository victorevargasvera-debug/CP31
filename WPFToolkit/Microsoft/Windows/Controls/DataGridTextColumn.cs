using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000078 RID: 120
	public class DataGridTextColumn : global::Microsoft.Windows.Controls.DataGridBoundColumn
	{
		// Token: 0x06000899 RID: 2201 RVA: 0x000271AC File Offset: 0x000253AC
		static DataGridTextColumn()
		{
			global::Microsoft.Windows.Controls.DataGridBoundColumn.ElementStyleProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridTextColumn), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridTextColumn.DefaultElementStyle));
			global::Microsoft.Windows.Controls.DataGridBoundColumn.EditingElementStyleProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridTextColumn), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridTextColumn.DefaultEditingElementStyle));
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x000272FC File Offset: 0x000254FC
		public static global::System.Windows.Style DefaultElementStyle
		{
			get
			{
				if (global::Microsoft.Windows.Controls.DataGridTextColumn._defaultElementStyle == null)
				{
					global::System.Windows.Style style = new global::System.Windows.Style(typeof(global::System.Windows.Controls.TextBlock));
					style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.FrameworkElement.MarginProperty, new global::System.Windows.Thickness(2.0, 0.0, 2.0, 0.0)));
					style.Seal();
					global::Microsoft.Windows.Controls.DataGridTextColumn._defaultElementStyle = style;
				}
				return global::Microsoft.Windows.Controls.DataGridTextColumn._defaultElementStyle;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x00027374 File Offset: 0x00025574
		public static global::System.Windows.Style DefaultEditingElementStyle
		{
			get
			{
				if (global::Microsoft.Windows.Controls.DataGridTextColumn._defaultEditingElementStyle == null)
				{
					global::System.Windows.Style style = new global::System.Windows.Style(typeof(global::System.Windows.Controls.TextBox));
					style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.BorderThicknessProperty, new global::System.Windows.Thickness(0.0)));
					style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.PaddingProperty, new global::System.Windows.Thickness(0.0)));
					style.Seal();
					global::Microsoft.Windows.Controls.DataGridTextColumn._defaultEditingElementStyle = style;
				}
				return global::Microsoft.Windows.Controls.DataGridTextColumn._defaultEditingElementStyle;
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x000273FC File Offset: 0x000255FC
		protected override global::System.Windows.FrameworkElement GenerateElement(global::Microsoft.Windows.Controls.DataGridCell cell, object dataItem)
		{
			global::System.Windows.Controls.TextBlock textBlock = new global::System.Windows.Controls.TextBlock();
			this.SyncProperties(textBlock);
			base.ApplyStyle(false, false, textBlock);
			base.ApplyBinding(textBlock, global::System.Windows.Controls.TextBlock.TextProperty);
			return textBlock;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0002742C File Offset: 0x0002562C
		protected override global::System.Windows.FrameworkElement GenerateEditingElement(global::Microsoft.Windows.Controls.DataGridCell cell, object dataItem)
		{
			global::System.Windows.Controls.TextBox textBox = new global::System.Windows.Controls.TextBox();
			this.SyncProperties(textBox);
			base.ApplyStyle(true, false, textBox);
			base.ApplyBinding(textBox, global::System.Windows.Controls.TextBox.TextProperty);
			return textBox;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0002745C File Offset: 0x0002565C
		private void SyncProperties(global::System.Windows.FrameworkElement e)
		{
			global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, e, global::System.Windows.Documents.TextElement.FontFamilyProperty, global::Microsoft.Windows.Controls.DataGridTextColumn.FontFamilyProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, e, global::System.Windows.Documents.TextElement.FontSizeProperty, global::Microsoft.Windows.Controls.DataGridTextColumn.FontSizeProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, e, global::System.Windows.Documents.TextElement.FontStyleProperty, global::Microsoft.Windows.Controls.DataGridTextColumn.FontStyleProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, e, global::System.Windows.Documents.TextElement.FontWeightProperty, global::Microsoft.Windows.Controls.DataGridTextColumn.FontWeightProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, e, global::System.Windows.Documents.TextElement.ForegroundProperty, global::Microsoft.Windows.Controls.DataGridTextColumn.ForegroundProperty);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x000274C0 File Offset: 0x000256C0
		protected internal override void RefreshCellContent(global::System.Windows.FrameworkElement element, string propertyName)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = element as global::Microsoft.Windows.Controls.DataGridCell;
			if (dataGridCell != null)
			{
				global::System.Windows.FrameworkElement frameworkElement = dataGridCell.Content as global::System.Windows.FrameworkElement;
				if (frameworkElement != null && propertyName != null)
				{
					if (!(propertyName == "FontFamily"))
					{
						if (!(propertyName == "FontSize"))
						{
							if (!(propertyName == "FontStyle"))
							{
								if (!(propertyName == "FontWeight"))
								{
									if (propertyName == "Foreground")
									{
										global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, frameworkElement, global::System.Windows.Documents.TextElement.ForegroundProperty, global::Microsoft.Windows.Controls.DataGridTextColumn.ForegroundProperty);
									}
								}
								else
								{
									global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, frameworkElement, global::System.Windows.Documents.TextElement.FontWeightProperty, global::Microsoft.Windows.Controls.DataGridTextColumn.FontWeightProperty);
								}
							}
							else
							{
								global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, frameworkElement, global::System.Windows.Documents.TextElement.FontStyleProperty, global::Microsoft.Windows.Controls.DataGridTextColumn.FontStyleProperty);
							}
						}
						else
						{
							global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, frameworkElement, global::System.Windows.Documents.TextElement.FontSizeProperty, global::Microsoft.Windows.Controls.DataGridTextColumn.FontSizeProperty);
						}
					}
					else
					{
						global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, frameworkElement, global::System.Windows.Documents.TextElement.FontFamilyProperty, global::Microsoft.Windows.Controls.DataGridTextColumn.FontFamilyProperty);
					}
				}
			}
			base.RefreshCellContent(element, propertyName);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0002759C File Offset: 0x0002579C
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
					global::System.Windows.Input.MouseButtonEventArgs mouseButtonEventArgs = editingEventArgs as global::System.Windows.Input.MouseButtonEventArgs;
					if (mouseButtonEventArgs == null || !global::Microsoft.Windows.Controls.DataGridTextColumn.PlaceCaretOnTextBox(textBox, global::System.Windows.Input.Mouse.GetPosition(textBox)))
					{
						textBox.SelectAll();
					}
				}
				return text;
			}
			return null;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0002760C File Offset: 0x0002580C
		private static bool PlaceCaretOnTextBox(global::System.Windows.Controls.TextBox textBox, global::System.Windows.Point position)
		{
			int characterIndexFromPoint = textBox.GetCharacterIndexFromPoint(position, false);
			if (characterIndexFromPoint >= 0)
			{
				textBox.Select(characterIndexFromPoint, 0);
				return true;
			}
			return false;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00027634 File Offset: 0x00025834
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

		// Token: 0x060008A3 RID: 2211 RVA: 0x00027664 File Offset: 0x00025864
		protected override void CancelCellEdit(global::System.Windows.FrameworkElement editingElement, object uneditedValue)
		{
			global::System.Windows.Controls.TextBox textBox = editingElement as global::System.Windows.Controls.TextBox;
			if (textBox != null)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.UpdateTarget(textBox, global::System.Windows.Controls.TextBox.TextProperty);
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00027686 File Offset: 0x00025886
		internal override void OnInput(global::System.Windows.Input.InputEventArgs e)
		{
			if (global::Microsoft.Windows.Controls.DataGridHelper.HasNonEscapeCharacters(e as global::System.Windows.Input.TextCompositionEventArgs))
			{
				base.BeginEdit(e);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x0002769C File Offset: 0x0002589C
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x000276AE File Offset: 0x000258AE
		public global::System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return (global::System.Windows.Media.FontFamily)base.GetValue(global::Microsoft.Windows.Controls.DataGridTextColumn.FontFamilyProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridTextColumn.FontFamilyProperty, value);
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x000276BC File Offset: 0x000258BC
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x000276CE File Offset: 0x000258CE
		[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.None)]
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.FontSizeConverter))]
		public double FontSize
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGridTextColumn.FontSizeProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridTextColumn.FontSizeProperty, value);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x000276E1 File Offset: 0x000258E1
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x000276F3 File Offset: 0x000258F3
		public global::System.Windows.FontStyle FontStyle
		{
			get
			{
				return (global::System.Windows.FontStyle)base.GetValue(global::Microsoft.Windows.Controls.DataGridTextColumn.FontStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridTextColumn.FontStyleProperty, value);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00027706 File Offset: 0x00025906
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00027718 File Offset: 0x00025918
		public global::System.Windows.FontWeight FontWeight
		{
			get
			{
				return (global::System.Windows.FontWeight)base.GetValue(global::Microsoft.Windows.Controls.DataGridTextColumn.FontWeightProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridTextColumn.FontWeightProperty, value);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x0002772B File Offset: 0x0002592B
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x0002773D File Offset: 0x0002593D
		public global::System.Windows.Media.Brush Foreground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Microsoft.Windows.Controls.DataGridTextColumn.ForegroundProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridTextColumn.ForegroundProperty, value);
			}
		}

		// Token: 0x040002A5 RID: 677
		public static readonly global::System.Windows.DependencyProperty FontFamilyProperty = global::System.Windows.Documents.TextElement.FontFamilyProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridTextColumn), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.SystemFonts.MessageFontFamily, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x040002A6 RID: 678
		public static readonly global::System.Windows.DependencyProperty FontSizeProperty = global::System.Windows.Documents.TextElement.FontSizeProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridTextColumn), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.SystemFonts.MessageFontSize, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x040002A7 RID: 679
		public static readonly global::System.Windows.DependencyProperty FontStyleProperty = global::System.Windows.Documents.TextElement.FontStyleProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridTextColumn), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.SystemFonts.MessageFontStyle, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x040002A8 RID: 680
		public static readonly global::System.Windows.DependencyProperty FontWeightProperty = global::System.Windows.Documents.TextElement.FontWeightProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridTextColumn), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.SystemFonts.MessageFontWeight, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x040002A9 RID: 681
		public static readonly global::System.Windows.DependencyProperty ForegroundProperty = global::System.Windows.Documents.TextElement.ForegroundProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridTextColumn), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.SystemColors.ControlTextBrush, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x040002AA RID: 682
		private static global::System.Windows.Style _defaultElementStyle;

		// Token: 0x040002AB RID: 683
		private static global::System.Windows.Style _defaultEditingElementStyle;
	}
}
