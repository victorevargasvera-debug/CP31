using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media;
using Infragistics.Windows.Automation.Peers;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200019B RID: 411
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.Markup.ContentProperty("Text")]
	public class SimpleTextBlock : global::System.Windows.FrameworkElement
	{
		// Token: 0x06000DF5 RID: 3573 RVA: 0x0002E1A4 File Offset: 0x0002C3A4
		static SimpleTextBlock()
		{
			global::System.Windows.FrameworkElement.FlowDirectionProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnPropertyChanged)));
			global::System.Windows.FrameworkElement.HorizontalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnHorizontalAlignmentPropertyChanged)));
			global::System.Windows.FrameworkElement.LanguageProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnLanguagePropertyChanged)));
			global::System.Windows.Documents.Inline.TextDecorationsProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTextDecorationsPropertyChanged)));
			global::System.Windows.Media.NumberSubstitution.CultureOverrideProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnNumberSubstitutionPropertyChanged)));
			global::System.Windows.Media.NumberSubstitution.CultureSourceProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnNumberSubstitutionPropertyChanged)));
			global::System.Windows.Media.NumberSubstitution.SubstitutionProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnNumberSubstitutionPropertyChanged)));
			global::Infragistics.Windows.Controls.SimpleTextBlock.OptimizeWidthMeasurementProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnOptimizeWidthMeasurementPropertyChanged)));
			global::System.Windows.Media.TextOptions.TextFormattingModeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnPropertyChanged)));
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0002E534 File Offset: 0x0002C734
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			this._lastMeasureConstraint = constraint;
			this.SetConstraintsForMeasure(constraint);
			global::System.Windows.Media.FormattedText[] formattedTexts = this.FormattedTexts;
			if (formattedTexts.Length == 0)
			{
				global::System.Windows.Media.FormattedText formattedText = this.CreatedFormattedText("Wj", global::Infragistics.Windows.Utilities.GetLanguageCultureInfo(this));
				double width = (double.IsPositiveInfinity(constraint.Width) || this.OptimizeWidthMeasurement) ? 0.0 : constraint.Width;
				return new global::System.Windows.Size(width, global::System.Math.Min(constraint.Height, formattedText.Height));
			}
			bool flag = this.TextWrapping != global::System.Windows.TextWrapping.NoWrap;
			double? num = null;
			double num2 = 0.0;
			double num3 = 0.0;
			foreach (global::System.Windows.Media.FormattedText formattedText2 in formattedTexts)
			{
				global::System.Windows.TextAlignment textAlignment = formattedText2.TextAlignment;
				try
				{
					if (textAlignment != global::System.Windows.TextAlignment.Left)
					{
						formattedText2.TextAlignment = global::System.Windows.TextAlignment.Left;
					}
					double extent = formattedText2.Extent;
					double val = (!flag && !double.IsInfinity(constraint.Width) && this.OptimizeWidthMeasurement) ? constraint.Width : global::System.Math.Min(constraint.Width, formattedText2.WidthIncludingTrailingWhitespace);
					double num4 = formattedText2.Height;
					if (num4 == 0.0 && formattedText2.Text.Length == 0)
					{
						if (num == null)
						{
							global::System.Windows.Media.FormattedText formattedText3 = this.CreatedFormattedText("Wj", global::Infragistics.Windows.Utilities.GetLanguageCultureInfo(this));
							num = new double?(formattedText3.Height);
						}
						num4 = num.Value;
					}
					num2 = global::System.Math.Max(num2, val);
					num3 += num4;
				}
				finally
				{
					if (textAlignment != global::System.Windows.TextAlignment.Left)
					{
						formattedText2.TextAlignment = textAlignment;
					}
				}
			}
			if (base.UseLayoutRounding)
			{
				num2 = global::System.Math.Ceiling(num2);
				num3 = global::System.Math.Ceiling(num3);
			}
			return new global::System.Windows.Size(num2, num3);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0002E6F8 File Offset: 0x0002C8F8
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.SimpleTextBlockAutomationPeer(this);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0002E700 File Offset: 0x0002C900
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			this.SetConstraintsForRender();
			global::System.Windows.Media.FormattedText[] formattedTexts = this.FormattedTexts;
			global::System.Windows.Size renderSize = base.RenderSize;
			bool flag = base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft;
			double num = 0.0;
			double num2 = 0.0;
			foreach (global::System.Windows.Media.FormattedText formattedText in formattedTexts)
			{
				num = global::System.Math.Max(num, formattedText.WidthIncludingTrailingWhitespace);
				num2 = global::System.Math.Min(num2, formattedText.OverhangTrailing);
			}
			double num3;
			double num4;
			switch (base.HorizontalAlignment)
			{
			case global::System.Windows.HorizontalAlignment.Left:
				num3 = num;
				num4 = 0.0;
				goto IL_116;
			case global::System.Windows.HorizontalAlignment.Center:
				num3 = num;
				num4 = (renderSize.Width - num) / 2.0;
				goto IL_116;
			case global::System.Windows.HorizontalAlignment.Right:
				num3 = num;
				num4 = renderSize.Width - num;
				goto IL_116;
			}
			num3 = renderSize.Width;
			num4 = 0.0;
			if (num > num3)
			{
				switch (this.TextAlignment)
				{
				case global::System.Windows.TextAlignment.Right:
					num4 += num - num3;
					break;
				case global::System.Windows.TextAlignment.Center:
					num4 += (num - num3) / 2.0;
					break;
				}
			}
			IL_116:
			if (flag)
			{
				drawingContext.PushTransform(new global::System.Windows.Media.MatrixTransform(-1.0, 0.0, 0.0, 1.0, renderSize.Width, 0.0));
			}
			global::System.Windows.Size size = renderSize;
			if (num2 < 0.0)
			{
				size.Width -= num2;
			}
			drawingContext.PushClip(new global::System.Windows.Media.RectangleGeometry(new global::System.Windows.Rect(size)));
			double? num5 = null;
			global::System.Windows.Point origin = default(global::System.Windows.Point);
			foreach (global::System.Windows.Media.FormattedText formattedText2 in formattedTexts)
			{
				if (this.TextWrapping == global::System.Windows.TextWrapping.NoWrap)
				{
					switch (this.TextAlignment)
					{
					case global::System.Windows.TextAlignment.Left:
					case global::System.Windows.TextAlignment.Justify:
						origin.X = num4;
						break;
					case global::System.Windows.TextAlignment.Right:
						origin.X = num4 + (num3 - formattedText2.WidthIncludingTrailingWhitespace);
						break;
					case global::System.Windows.TextAlignment.Center:
						origin.X = num4 + (num3 - formattedText2.WidthIncludingTrailingWhitespace) / 2.0;
						break;
					}
					if (flag && this.TextTrimming == global::System.Windows.TextTrimming.None)
					{
						origin.X = renderSize.Width - origin.X;
					}
				}
				drawingContext.DrawText(formattedText2, origin);
				double num6 = formattedText2.Height;
				if (num6 == 0.0 && formattedText2.Text.Length == 0)
				{
					if (num5 == null)
					{
						global::System.Windows.Media.FormattedText formattedText3 = this.CreatedFormattedText("Wj", global::Infragistics.Windows.Utilities.GetLanguageCultureInfo(this));
						num5 = new double?(formattedText3.Height);
					}
					num6 = num5.Value;
				}
				origin.Y += num6;
			}
			drawingContext.Pop();
			if (flag)
			{
				drawingContext.Pop();
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x0002E9D4 File Offset: 0x0002CBD4
		private global::System.Windows.Media.FormattedText[] FormattedTexts
		{
			get
			{
				if (this._formattedTexts == null)
				{
					string text = this.Text ?? string.Empty;
					global::System.Globalization.CultureInfo languageCultureInfo = global::Infragistics.Windows.Utilities.GetLanguageCultureInfo(this);
					if (this.TextWrapping == global::System.Windows.TextWrapping.NoWrap && (this.TextTrimming != global::System.Windows.TextTrimming.None || this.TextAlignment != global::System.Windows.TextAlignment.Left))
					{
						global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.SimpleTextBlock.TextRangeDefinition> textLines = global::Infragistics.Windows.Controls.SimpleTextBlock.GetTextLines(text);
						this._formattedTexts = new global::System.Windows.Media.FormattedText[textLines.Count];
						for (int i = 0; i < textLines.Count; i++)
						{
							global::Infragistics.Windows.Controls.SimpleTextBlock.TextRangeDefinition textRangeDefinition = textLines[i];
							global::System.Windows.Media.FormattedText formattedText = this.CreatedFormattedText(text.Substring(textRangeDefinition.StartIndex, textRangeDefinition.Length), languageCultureInfo);
							formattedText.MaxLineCount = 1;
							this._formattedTexts[i] = formattedText;
						}
					}
					else
					{
						if (text.EndsWith("\n") || text.EndsWith("\r"))
						{
							text += "\n";
						}
						this._formattedTexts = new global::System.Windows.Media.FormattedText[]
						{
							this.CreatedFormattedText(text, languageCultureInfo)
						};
					}
				}
				return this._formattedTexts;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x0002EAC7 File Offset: 0x0002CCC7
		private global::System.Windows.Media.Typeface Typeface
		{
			get
			{
				if (this._typeface == null)
				{
					this._typeface = new global::System.Windows.Media.Typeface(this.FontFamily, this.FontStyle, this.FontWeight, this.FontStretch);
				}
				return this._typeface;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x0002EAFA File Offset: 0x0002CCFA
		// (set) Token: 0x06000DFD RID: 3581 RVA: 0x0002EB0C File Offset: 0x0002CD0C
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return (global::System.Windows.Media.FontFamily)base.GetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.FontFamilyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.FontFamilyProperty, value);
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x0002EB1A File Offset: 0x0002CD1A
		// (set) Token: 0x06000DFF RID: 3583 RVA: 0x0002EB2C File Offset: 0x0002CD2C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.FontSizeConverter))]
		public double FontSize
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.FontSizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.FontSizeProperty, value);
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x0002EB3F File Offset: 0x0002CD3F
		// (set) Token: 0x06000E01 RID: 3585 RVA: 0x0002EB51 File Offset: 0x0002CD51
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.FontStretch FontStretch
		{
			get
			{
				return (global::System.Windows.FontStretch)base.GetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.FontStretchProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.FontStretchProperty, value);
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x0002EB64 File Offset: 0x0002CD64
		// (set) Token: 0x06000E03 RID: 3587 RVA: 0x0002EB76 File Offset: 0x0002CD76
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.FontStyle FontStyle
		{
			get
			{
				return (global::System.Windows.FontStyle)base.GetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.FontStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.FontStyleProperty, value);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x0002EB89 File Offset: 0x0002CD89
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x0002EB9B File Offset: 0x0002CD9B
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.FontWeight FontWeight
		{
			get
			{
				return (global::System.Windows.FontWeight)base.GetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.FontWeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.FontWeightProperty, value);
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x0002EBAE File Offset: 0x0002CDAE
		// (set) Token: 0x06000E07 RID: 3591 RVA: 0x0002EBC0 File Offset: 0x0002CDC0
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.Brush Foreground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.ForegroundProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.ForegroundProperty, value);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x0002EBCE File Offset: 0x0002CDCE
		// (set) Token: 0x06000E09 RID: 3593 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
		[global::System.ComponentModel.Bindable(true)]
		public bool OptimizeWidthMeasurement
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.OptimizeWidthMeasurementProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.OptimizeWidthMeasurementProperty, value);
			}
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0002EBF3 File Offset: 0x0002CDF3
		public static bool GetOptimizeWidthMeasurement(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.OptimizeWidthMeasurementProperty);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0002EC05 File Offset: 0x0002CE05
		public static void SetOptimizeWidthMeasurement(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.OptimizeWidthMeasurementProperty, value);
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x0002EC18 File Offset: 0x0002CE18
		// (set) Token: 0x06000E0D RID: 3597 RVA: 0x0002EC2A File Offset: 0x0002CE2A
		[global::System.ComponentModel.Bindable(true)]
		public string Text
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.TextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.TextProperty, value);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x0002EC38 File Offset: 0x0002CE38
		// (set) Token: 0x06000E0F RID: 3599 RVA: 0x0002EC40 File Offset: 0x0002CE40
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.TextAlignment TextAlignment
		{
			get
			{
				return this._cachedTextAlignment;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.TextAlignmentProperty, value);
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0002EC53 File Offset: 0x0002CE53
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x0002EC65 File Offset: 0x0002CE65
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.TextDecorationCollection TextDecorations
		{
			get
			{
				return (global::System.Windows.TextDecorationCollection)base.GetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.TextDecorationsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.TextDecorationsProperty, value);
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x0002EC73 File Offset: 0x0002CE73
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x0002EC7B File Offset: 0x0002CE7B
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.TextTrimming TextTrimming
		{
			get
			{
				return this._cachedTextTrimming;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.TextTrimmingProperty, value);
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x0002EC8E File Offset: 0x0002CE8E
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x0002EC96 File Offset: 0x0002CE96
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.TextWrapping TextWrapping
		{
			get
			{
				return this._cachedTextWrapping;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.TextWrappingProperty, value);
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0002ECAC File Offset: 0x0002CEAC
		private global::System.Windows.Media.FormattedText CreatedFormattedText(string text, global::System.Globalization.CultureInfo cultureInfo)
		{
			global::System.Windows.Media.FormattedText formattedText = new global::System.Windows.Media.FormattedText(text, cultureInfo, base.FlowDirection, this.Typeface, this.FontSize, this.Foreground, this.GetNumberSubstitution(), global::System.Windows.Media.TextOptions.GetTextFormattingMode(this));
			formattedText.Trimming = this.TextTrimming;
			formattedText.TextAlignment = global::Infragistics.Windows.Controls.SimpleTextBlock.GetResolvedTextAlignment(this.TextWrapping, this.TextAlignment);
			formattedText.SetTextDecorations(this.TextDecorations);
			return formattedText;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0002ED15 File Offset: 0x0002CF15
		private global::System.Windows.Media.NumberSubstitution GetNumberSubstitution()
		{
			return new global::System.Windows.Media.NumberSubstitution(global::System.Windows.Media.NumberSubstitution.GetCultureSource(this), global::System.Windows.Media.NumberSubstitution.GetCultureOverride(this), global::System.Windows.Media.NumberSubstitution.GetSubstitution(this));
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0002ED30 File Offset: 0x0002CF30
		private static global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.SimpleTextBlock.TextRangeDefinition> GetTextLines(string text)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.SimpleTextBlock.TextRangeDefinition> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.SimpleTextBlock.TextRangeDefinition>();
			char[] anyOf = new char[]
			{
				'\r',
				'\n'
			};
			int num = 0;
			for (;;)
			{
				int num2 = text.IndexOfAny(anyOf, num);
				if (num2 < 0)
				{
					break;
				}
				list.Add(new global::Infragistics.Windows.Controls.SimpleTextBlock.TextRangeDefinition
				{
					StartIndex = num,
					Length = num2 - num
				});
				num = num2 + 1;
				if (num < text.Length && text[num2] == '\r' && text[num] == '\n')
				{
					num++;
				}
			}
			if (num <= text.Length)
			{
				list.Add(new global::Infragistics.Windows.Controls.SimpleTextBlock.TextRangeDefinition
				{
					StartIndex = num,
					Length = text.Length - num
				});
			}
			return list;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0002EDE5 File Offset: 0x0002CFE5
		private static global::System.Windows.TextAlignment GetResolvedTextAlignment(global::System.Windows.TextWrapping textWrapping, global::System.Windows.TextAlignment textAlignment)
		{
			if (textWrapping != global::System.Windows.TextWrapping.NoWrap)
			{
				return textAlignment;
			}
			if (textAlignment != global::System.Windows.TextAlignment.Justify)
			{
				return global::System.Windows.TextAlignment.Left;
			}
			return global::System.Windows.TextAlignment.Justify;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0002EDF4 File Offset: 0x0002CFF4
		private static void OnFontSizePropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject;
			if (simpleTextBlock._formattedTexts == null)
			{
				return;
			}
			for (int i = 0; i < simpleTextBlock._formattedTexts.Length; i++)
			{
				simpleTextBlock._formattedTexts[i].SetFontSize((double)e.NewValue);
			}
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0002EE40 File Offset: 0x0002D040
		private static void OnForegroundPropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject;
			if (simpleTextBlock._formattedTexts == null)
			{
				return;
			}
			for (int i = 0; i < simpleTextBlock._formattedTexts.Length; i++)
			{
				simpleTextBlock._formattedTexts[i].SetForegroundBrush((global::System.Windows.Media.Brush)e.NewValue);
			}
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0002EE8C File Offset: 0x0002D08C
		private static void OnHorizontalAlignmentPropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject;
			if (simpleTextBlock.TextWrapping == global::System.Windows.TextWrapping.NoWrap)
			{
				simpleTextBlock.InvalidateVisual();
			}
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0002EEB0 File Offset: 0x0002D0B0
		private static void OnLanguagePropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject;
			if (simpleTextBlock._formattedTexts == null)
			{
				return;
			}
			for (int i = 0; i < simpleTextBlock._formattedTexts.Length; i++)
			{
				simpleTextBlock._formattedTexts[i].SetCulture(global::Infragistics.Windows.Utilities.GetLanguageCultureInfo(simpleTextBlock));
			}
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0002EEF4 File Offset: 0x0002D0F4
		private static void OnNumberSubstitutionPropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject;
			if (simpleTextBlock._formattedTexts == null)
			{
				return;
			}
			for (int i = 0; i < simpleTextBlock._formattedTexts.Length; i++)
			{
				simpleTextBlock._formattedTexts[i].SetNumberSubstitution(simpleTextBlock.GetNumberSubstitution());
			}
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0002EF38 File Offset: 0x0002D138
		private static void OnOptimizeWidthMeasurementPropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = dependencyObject as global::Infragistics.Windows.Controls.SimpleTextBlock;
			if (simpleTextBlock != null)
			{
				simpleTextBlock.InvalidateMeasure();
			}
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0002EF58 File Offset: 0x0002D158
		private static void OnPropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject;
			bool flag;
			simpleTextBlock.OnTextPropertyDirtied(out flag);
			if (flag)
			{
				return;
			}
			string name;
			if ((name = e.Property.Name) != null)
			{
				if (!(name == "Text") && !(name == "TextFormattingMode"))
				{
					if (!(name == "TextWrapping"))
					{
						return;
					}
					simpleTextBlock.InvalidateMeasure();
				}
				else if (double.IsInfinity(simpleTextBlock._lastMeasureConstraint.Width) || double.IsInfinity(simpleTextBlock._lastMeasureConstraint.Height) || !simpleTextBlock.OptimizeWidthMeasurement)
				{
					simpleTextBlock.InvalidateMeasure();
					return;
				}
			}
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0002EFEC File Offset: 0x0002D1EC
		private static void OnTextAlignmentPropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject;
			simpleTextBlock._cachedTextAlignment = (global::System.Windows.TextAlignment)e.NewValue;
			if (simpleTextBlock._formattedTexts == null)
			{
				return;
			}
			if (simpleTextBlock.TextWrapping == global::System.Windows.TextWrapping.NoWrap)
			{
				simpleTextBlock._formattedTexts = null;
				return;
			}
			for (int i = 0; i < simpleTextBlock._formattedTexts.Length; i++)
			{
				simpleTextBlock._formattedTexts[i].TextAlignment = global::Infragistics.Windows.Controls.SimpleTextBlock.GetResolvedTextAlignment(simpleTextBlock.TextWrapping, simpleTextBlock.TextAlignment);
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0002F060 File Offset: 0x0002D260
		private static void OnTextDecorationsPropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject;
			if (simpleTextBlock._formattedTexts == null)
			{
				return;
			}
			for (int i = 0; i < simpleTextBlock._formattedTexts.Length; i++)
			{
				simpleTextBlock._formattedTexts[i].SetTextDecorations((global::System.Windows.TextDecorationCollection)e.NewValue);
			}
			simpleTextBlock.InvalidateVisual();
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0002F0B0 File Offset: 0x0002D2B0
		private static void OnTextTrimmingPropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject;
			simpleTextBlock._cachedTextTrimming = (global::System.Windows.TextTrimming)e.NewValue;
			if (simpleTextBlock._formattedTexts == null)
			{
				return;
			}
			if (simpleTextBlock.TextWrapping == global::System.Windows.TextWrapping.NoWrap)
			{
				simpleTextBlock._formattedTexts = null;
				return;
			}
			for (int i = 0; i < simpleTextBlock._formattedTexts.Length; i++)
			{
				simpleTextBlock._formattedTexts[i].Trimming = simpleTextBlock.TextTrimming;
			}
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0002F116 File Offset: 0x0002D316
		private void OnTextPropertyDirtied(out bool isMeasureInvalidated)
		{
			isMeasureInvalidated = false;
			this._formattedTexts = null;
			if (this.TextWrapping != global::System.Windows.TextWrapping.NoWrap)
			{
				base.InvalidateMeasure();
				isMeasureInvalidated = true;
			}
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0002F134 File Offset: 0x0002D334
		private static void OnTextWrappingPropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject)._cachedTextWrapping = (global::System.Windows.TextWrapping)e.NewValue;
			global::Infragistics.Windows.Controls.SimpleTextBlock.OnPropertyChanged(dependencyObject, e);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0002F154 File Offset: 0x0002D354
		private static void OnTypefacePropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject;
			simpleTextBlock._typeface = null;
			bool flag;
			simpleTextBlock.OnTextPropertyDirtied(out flag);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0002F178 File Offset: 0x0002D378
		private void SetConstraintsForMeasure(global::System.Windows.Size measureConstraint)
		{
			global::System.Windows.Media.FormattedText[] formattedTexts = this.FormattedTexts;
			global::System.Windows.Size renderSize = base.RenderSize;
			bool flag = this.TextWrapping != global::System.Windows.TextWrapping.NoWrap;
			if (flag)
			{
				double num = double.IsInfinity(measureConstraint.Width) ? 0.0 : measureConstraint.Width;
				if (formattedTexts[0].MaxTextWidth != num)
				{
					formattedTexts[0].MaxTextWidth = num;
				}
			}
			foreach (global::System.Windows.Media.FormattedText formattedText in formattedTexts)
			{
				if (formattedText.MaxTextHeight != 1.7976931348623157E+308)
				{
					formattedText.MaxTextHeight = double.MaxValue;
				}
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0002F210 File Offset: 0x0002D410
		private void SetConstraintsForRender()
		{
			global::System.Windows.Media.FormattedText[] formattedTexts = this.FormattedTexts;
			global::System.Windows.Size renderSize = base.RenderSize;
			bool flag = this.TextWrapping != global::System.Windows.TextWrapping.NoWrap;
			if (flag && formattedTexts[0].MaxTextWidth != renderSize.Width)
			{
				formattedTexts[0].MaxTextWidth = renderSize.Width;
			}
			if (this.TextTrimming == global::System.Windows.TextTrimming.None)
			{
				if (!flag)
				{
					foreach (global::System.Windows.Media.FormattedText formattedText in formattedTexts)
					{
						if (formattedText.MaxTextWidth != 0.0)
						{
							formattedText.MaxTextWidth = 0.0;
						}
					}
					return;
				}
			}
			else
			{
				foreach (global::System.Windows.Media.FormattedText formattedText2 in formattedTexts)
				{
					if (formattedText2.MaxTextWidth != renderSize.Width)
					{
						formattedText2.MaxTextWidth = renderSize.Width;
					}
				}
				if (flag && formattedTexts[0].MaxTextHeight != renderSize.Height)
				{
					formattedTexts[0].MaxTextHeight = renderSize.Height;
				}
			}
		}

		// Token: 0x04000715 RID: 1813
		private global::System.Windows.TextAlignment _cachedTextAlignment;

		// Token: 0x04000716 RID: 1814
		private global::System.Windows.TextTrimming _cachedTextTrimming;

		// Token: 0x04000717 RID: 1815
		private global::System.Windows.TextWrapping _cachedTextWrapping = global::System.Windows.TextWrapping.NoWrap;

		// Token: 0x04000718 RID: 1816
		private global::System.Windows.Size _lastMeasureConstraint;

		// Token: 0x04000719 RID: 1817
		private global::System.Windows.Media.FormattedText[] _formattedTexts;

		// Token: 0x0400071A RID: 1818
		private global::System.Windows.Media.Typeface _typeface;

		// Token: 0x0400071B RID: 1819
		public static readonly global::System.Windows.DependencyProperty FontFamilyProperty = global::System.Windows.Documents.TextElement.FontFamilyProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTypefacePropertyChanged)));

		// Token: 0x0400071C RID: 1820
		public static readonly global::System.Windows.DependencyProperty FontSizeProperty = global::System.Windows.Documents.TextElement.FontSizeProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnFontSizePropertyChanged)));

		// Token: 0x0400071D RID: 1821
		public static readonly global::System.Windows.DependencyProperty FontStretchProperty = global::System.Windows.Documents.TextElement.FontStretchProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTypefacePropertyChanged)));

		// Token: 0x0400071E RID: 1822
		public static readonly global::System.Windows.DependencyProperty FontStyleProperty = global::System.Windows.Documents.TextElement.FontStyleProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTypefacePropertyChanged)));

		// Token: 0x0400071F RID: 1823
		public static readonly global::System.Windows.DependencyProperty FontWeightProperty = global::System.Windows.Documents.TextElement.FontWeightProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTypefacePropertyChanged)));

		// Token: 0x04000720 RID: 1824
		public static readonly global::System.Windows.DependencyProperty ForegroundProperty = global::System.Windows.Documents.TextElement.ForegroundProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnForegroundPropertyChanged)));

		// Token: 0x04000721 RID: 1825
		public static readonly global::System.Windows.DependencyProperty OptimizeWidthMeasurementProperty = global::System.Windows.DependencyProperty.RegisterAttached("OptimizeWidthMeasurement", typeof(bool), typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x04000722 RID: 1826
		public static readonly global::System.Windows.DependencyProperty TextProperty = global::System.Windows.DependencyProperty.Register("Text", typeof(string), typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnPropertyChanged)));

		// Token: 0x04000723 RID: 1827
		public static readonly global::System.Windows.DependencyProperty TextAlignmentProperty = global::System.Windows.Documents.Block.TextAlignmentProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.TextAlignment.Left, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTextAlignmentPropertyChanged)));

		// Token: 0x04000724 RID: 1828
		public static readonly global::System.Windows.DependencyProperty TextDecorationsProperty = global::System.Windows.Documents.Inline.TextDecorationsProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock));

		// Token: 0x04000725 RID: 1829
		public static readonly global::System.Windows.DependencyProperty TextTrimmingProperty = global::System.Windows.DependencyProperty.Register("TextTrimming", typeof(global::System.Windows.TextTrimming), typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.TextTrimming.None, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTextTrimmingPropertyChanged)));

		// Token: 0x04000726 RID: 1830
		public static readonly global::System.Windows.DependencyProperty TextWrappingProperty = global::System.Windows.DependencyProperty.Register("TextWrapping", typeof(global::System.Windows.TextWrapping), typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.TextWrapping.NoWrap, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTextWrappingPropertyChanged)));

		// Token: 0x0200019C RID: 412
		private struct TextRangeDefinition
		{
			// Token: 0x04000727 RID: 1831
			public int StartIndex;

			// Token: 0x04000728 RID: 1832
			public int Length;
		}
	}
}
