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
	// Token: 0x020001C3 RID: 451
	[global::System.Windows.Markup.ContentProperty("Text")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SimpleTextBlock : global::System.Windows.FrameworkElement
	{
		// Token: 0x06000F4B RID: 3915 RVA: 0x00032AD0 File Offset: 0x00030CD0
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

		// Token: 0x06000F4D RID: 3917 RVA: 0x00032E6C File Offset: 0x0003106C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			this._lastMeasureConstraint = constraint;
			this.SetConstraintsForMeasure(constraint);
			global::System.Windows.Media.FormattedText[] formattedTexts = this.FormattedTexts;
			if (formattedTexts.Length == 0)
			{
				global::System.Windows.Media.FormattedText formattedText = this.CreatedFormattedText("Wj", global::Infragistics.Windows.Utilities.GetLanguageCultureInfo(this));
				double width = (double.IsPositiveInfinity(constraint.Width) || this.OptimizeWidthMeasurement) ? 0.0 : constraint.Width;
				return this.OnMeasureOverrideComplete(new global::System.Windows.Size(width, global::System.Math.Min(constraint.Height, formattedText.Height)));
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
					double val = (!flag && !double.IsInfinity(constraint.Width) && this.OptimizeWidthMeasurement) ? constraint.Width : global::System.Math.Min(constraint.Width, formattedText2.WidthIncludingTrailingWhitespace + 1E-10);
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
			num3 += 1E-10;
			return this.OnMeasureOverrideComplete(new global::System.Windows.Size(num2, num3));
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00033054 File Offset: 0x00031254
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.SimpleTextBlockAutomationPeer(this);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0003305C File Offset: 0x0003125C
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00033330 File Offset: 0x00031530
		private global::System.Windows.Media.FormattedText[] FormattedTexts
		{
			get
			{
				if (this._formattedTexts == null)
				{
					string text = this.Text ?? string.Empty;
					global::System.Globalization.CultureInfo languageCultureInfo = global::Infragistics.Windows.Utilities.GetLanguageCultureInfo(this);
					if (this.TextWrapping == global::System.Windows.TextWrapping.NoWrap && (text.Length > 9600 || this.TextTrimming != global::System.Windows.TextTrimming.None || this.TextAlignment != global::System.Windows.TextAlignment.Left))
					{
						global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.SimpleTextBlock.TextRangeDefinition> textLines = global::Infragistics.Windows.Controls.SimpleTextBlock.GetTextLines(text);
						this._formattedTexts = new global::System.Windows.Media.FormattedText[textLines.Count];
						for (int i = 0; i < textLines.Count; i++)
						{
							global::Infragistics.Windows.Controls.SimpleTextBlock.TextRangeDefinition textRangeDefinition = textLines[i];
							global::System.Windows.Media.FormattedText formattedText = this.CreatedFormattedText(text.Substring(textRangeDefinition.StartIndex, global::System.Math.Min(textRangeDefinition.Length, 9600)), languageCultureInfo);
							formattedText.MaxLineCount = 1;
							this._formattedTexts[i] = formattedText;
							if (textRangeDefinition.Length >= 9600)
							{
								break;
							}
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

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x0003344B File Offset: 0x0003164B
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

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x0003347E File Offset: 0x0003167E
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x00033490 File Offset: 0x00031690
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

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x0003349E File Offset: 0x0003169E
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x000334B0 File Offset: 0x000316B0
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.FontSizeConverter))]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x000334C3 File Offset: 0x000316C3
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x000334D5 File Offset: 0x000316D5
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

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x000334E8 File Offset: 0x000316E8
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x000334FA File Offset: 0x000316FA
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

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x0003350D File Offset: 0x0003170D
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x0003351F File Offset: 0x0003171F
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

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00033532 File Offset: 0x00031732
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x00033544 File Offset: 0x00031744
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

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00033552 File Offset: 0x00031752
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00033564 File Offset: 0x00031764
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

		// Token: 0x06000F60 RID: 3936 RVA: 0x00033577 File Offset: 0x00031777
		public static bool GetOptimizeWidthMeasurement(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.OptimizeWidthMeasurementProperty);
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00033589 File Offset: 0x00031789
		public static void SetOptimizeWidthMeasurement(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.OptimizeWidthMeasurementProperty, value);
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0003359C File Offset: 0x0003179C
		// (set) Token: 0x06000F63 RID: 3939 RVA: 0x000335AE File Offset: 0x000317AE
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

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x000335BC File Offset: 0x000317BC
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x000335C4 File Offset: 0x000317C4
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

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x000335D7 File Offset: 0x000317D7
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x000335E9 File Offset: 0x000317E9
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

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x000335F7 File Offset: 0x000317F7
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x000335FF File Offset: 0x000317FF
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

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00033612 File Offset: 0x00031812
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x0003361A File Offset: 0x0003181A
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

		// Token: 0x06000F6C RID: 3948 RVA: 0x00033630 File Offset: 0x00031830
		private global::System.Windows.Media.FormattedText CreatedFormattedText(string text, global::System.Globalization.CultureInfo cultureInfo)
		{
			global::System.Windows.Media.FormattedText formattedText = new global::System.Windows.Media.FormattedText(text, cultureInfo, base.FlowDirection, this.Typeface, this.FontSize, this.Foreground, this.GetNumberSubstitution(), global::System.Windows.Media.TextOptions.GetTextFormattingMode(this));
			formattedText.Trimming = this.TextTrimming;
			formattedText.TextAlignment = global::Infragistics.Windows.Controls.SimpleTextBlock.GetResolvedTextAlignment(this.TextWrapping, this.TextAlignment);
			formattedText.SetTextDecorations(this.TextDecorations);
			return formattedText;
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00033699 File Offset: 0x00031899
		private global::System.Windows.Media.NumberSubstitution GetNumberSubstitution()
		{
			return new global::System.Windows.Media.NumberSubstitution(global::System.Windows.Media.NumberSubstitution.GetCultureSource(this), global::System.Windows.Media.NumberSubstitution.GetCultureOverride(this), global::System.Windows.Media.NumberSubstitution.GetSubstitution(this));
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x000336B4 File Offset: 0x000318B4
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

		// Token: 0x06000F6F RID: 3951 RVA: 0x00033769 File Offset: 0x00031969
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

		// Token: 0x06000F70 RID: 3952 RVA: 0x00033778 File Offset: 0x00031978
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

		// Token: 0x06000F71 RID: 3953 RVA: 0x000337C4 File Offset: 0x000319C4
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

		// Token: 0x06000F72 RID: 3954 RVA: 0x00033810 File Offset: 0x00031A10
		private static void OnHorizontalAlignmentPropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject;
			if (simpleTextBlock.TextWrapping == global::System.Windows.TextWrapping.NoWrap)
			{
				simpleTextBlock.InvalidateVisual();
			}
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00033834 File Offset: 0x00031A34
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

		// Token: 0x06000F74 RID: 3956 RVA: 0x00033878 File Offset: 0x00031A78
		private global::System.Windows.Size OnMeasureOverrideComplete(global::System.Windows.Size desiredSize)
		{
			if (!global::Infragistics.CoreUtilities.AreClose(this._lastMeasureResult, desiredSize))
			{
				if (!this._lastMeasureResult.IsEmpty)
				{
					global::System.Windows.FrameworkElement frameworkElement = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::System.Windows.FrameworkElement;
					if (frameworkElement != null)
					{
						frameworkElement.InvalidateMeasure();
					}
				}
				this._lastMeasureResult = desiredSize;
			}
			return desiredSize;
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000338C0 File Offset: 0x00031AC0
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

		// Token: 0x06000F76 RID: 3958 RVA: 0x00033904 File Offset: 0x00031B04
		private static void OnOptimizeWidthMeasurementPropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = dependencyObject as global::Infragistics.Windows.Controls.SimpleTextBlock;
			if (simpleTextBlock != null)
			{
				simpleTextBlock.InvalidateMeasure();
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00033924 File Offset: 0x00031B24
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
				else
				{
					if (double.IsInfinity(simpleTextBlock._lastMeasureConstraint.Width) || double.IsInfinity(simpleTextBlock._lastMeasureConstraint.Height) || !simpleTextBlock.OptimizeWidthMeasurement)
					{
						simpleTextBlock.InvalidateMeasure();
					}
					if (e.Property == global::System.Windows.Media.TextOptions.TextFormattingModeProperty && (global::System.Windows.Media.TextFormattingMode)e.NewValue == global::System.Windows.Media.TextFormattingMode.Display)
					{
						simpleTextBlock.SetCurrentValue(global::System.Windows.UIElement.ClipToBoundsProperty, global::Infragistics.KnownBoxes.TrueBox);
						return;
					}
				}
			}
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x000339E8 File Offset: 0x00031BE8
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

		// Token: 0x06000F79 RID: 3961 RVA: 0x00033A5C File Offset: 0x00031C5C
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

		// Token: 0x06000F7A RID: 3962 RVA: 0x00033AAC File Offset: 0x00031CAC
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

		// Token: 0x06000F7B RID: 3963 RVA: 0x00033B12 File Offset: 0x00031D12
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

		// Token: 0x06000F7C RID: 3964 RVA: 0x00033B30 File Offset: 0x00031D30
		private static void OnTextWrappingPropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject)._cachedTextWrapping = (global::System.Windows.TextWrapping)e.NewValue;
			global::Infragistics.Windows.Controls.SimpleTextBlock.OnPropertyChanged(dependencyObject, e);
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00033B50 File Offset: 0x00031D50
		private static void OnTypefacePropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)dependencyObject;
			simpleTextBlock._typeface = null;
			bool flag;
			simpleTextBlock.OnTextPropertyDirtied(out flag);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00033B74 File Offset: 0x00031D74
		private void SetConstraintsForMeasure(global::System.Windows.Size measureConstraint)
		{
			global::System.Windows.Media.FormattedText[] formattedTexts = this.FormattedTexts;
			global::System.Windows.Size renderSize = base.RenderSize;
			bool flag = this.TextWrapping != global::System.Windows.TextWrapping.NoWrap;
			bool flag2 = this.TextTrimming != global::System.Windows.TextTrimming.None;
			if (flag || flag2)
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

		// Token: 0x06000F7F RID: 3967 RVA: 0x00033C20 File Offset: 0x00031E20
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

		// Token: 0x0400083F RID: 2111
		private const int MaxCharactersPerLine = 9600;

		// Token: 0x04000840 RID: 2112
		private global::System.Windows.TextAlignment _cachedTextAlignment;

		// Token: 0x04000841 RID: 2113
		private global::System.Windows.TextTrimming _cachedTextTrimming;

		// Token: 0x04000842 RID: 2114
		private global::System.Windows.TextWrapping _cachedTextWrapping = global::System.Windows.TextWrapping.NoWrap;

		// Token: 0x04000843 RID: 2115
		private global::System.Windows.Size _lastMeasureConstraint;

		// Token: 0x04000844 RID: 2116
		private global::System.Windows.Media.FormattedText[] _formattedTexts;

		// Token: 0x04000845 RID: 2117
		private global::System.Windows.Media.Typeface _typeface;

		// Token: 0x04000846 RID: 2118
		private global::System.Windows.Size _lastMeasureResult = global::System.Windows.Size.Empty;

		// Token: 0x04000847 RID: 2119
		public static readonly global::System.Windows.DependencyProperty FontFamilyProperty = global::System.Windows.Documents.TextElement.FontFamilyProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTypefacePropertyChanged)));

		// Token: 0x04000848 RID: 2120
		public static readonly global::System.Windows.DependencyProperty FontSizeProperty = global::System.Windows.Documents.TextElement.FontSizeProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnFontSizePropertyChanged)));

		// Token: 0x04000849 RID: 2121
		public static readonly global::System.Windows.DependencyProperty FontStretchProperty = global::System.Windows.Documents.TextElement.FontStretchProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTypefacePropertyChanged)));

		// Token: 0x0400084A RID: 2122
		public static readonly global::System.Windows.DependencyProperty FontStyleProperty = global::System.Windows.Documents.TextElement.FontStyleProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTypefacePropertyChanged)));

		// Token: 0x0400084B RID: 2123
		public static readonly global::System.Windows.DependencyProperty FontWeightProperty = global::System.Windows.Documents.TextElement.FontWeightProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTypefacePropertyChanged)));

		// Token: 0x0400084C RID: 2124
		public static readonly global::System.Windows.DependencyProperty ForegroundProperty = global::System.Windows.Documents.TextElement.ForegroundProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnForegroundPropertyChanged)));

		// Token: 0x0400084D RID: 2125
		public static readonly global::System.Windows.DependencyProperty OptimizeWidthMeasurementProperty = global::System.Windows.DependencyProperty.RegisterAttached("OptimizeWidthMeasurement", typeof(bool), typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x0400084E RID: 2126
		public static readonly global::System.Windows.DependencyProperty TextProperty = global::System.Windows.DependencyProperty.Register("Text", typeof(string), typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnPropertyChanged)));

		// Token: 0x0400084F RID: 2127
		public static readonly global::System.Windows.DependencyProperty TextAlignmentProperty = global::System.Windows.Documents.Block.TextAlignmentProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.TextAlignment.Left, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTextAlignmentPropertyChanged)));

		// Token: 0x04000850 RID: 2128
		public static readonly global::System.Windows.DependencyProperty TextDecorationsProperty = global::System.Windows.Documents.Inline.TextDecorationsProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.SimpleTextBlock));

		// Token: 0x04000851 RID: 2129
		public static readonly global::System.Windows.DependencyProperty TextTrimmingProperty = global::System.Windows.DependencyProperty.Register("TextTrimming", typeof(global::System.Windows.TextTrimming), typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.TextTrimming.None, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTextTrimmingPropertyChanged)));

		// Token: 0x04000852 RID: 2130
		public static readonly global::System.Windows.DependencyProperty TextWrappingProperty = global::System.Windows.DependencyProperty.Register("TextWrapping", typeof(global::System.Windows.TextWrapping), typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.TextWrapping.NoWrap, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SimpleTextBlock.OnTextWrappingPropertyChanged)));

		// Token: 0x020001C4 RID: 452
		private struct TextRangeDefinition
		{
			// Token: 0x04000853 RID: 2131
			public int StartIndex;

			// Token: 0x04000854 RID: 2132
			public int Length;
		}
	}
}
