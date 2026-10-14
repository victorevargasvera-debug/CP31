using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200002C RID: 44
	public class ConditionalFormatIcon : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000B3E7 File Offset: 0x000095E7
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0000B3EF File Offset: 0x000095EF
		protected internal global::Infragistics.Controls.Grids.IconConditionalFormatRule Parent { get; set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000B3F8 File Offset: 0x000095F8
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0000B40A File Offset: 0x0000960A
		public global::System.Windows.DataTemplate Icon
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormatIcon.IconProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormatIcon.IconProperty, value);
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000B418 File Offset: 0x00009618
		private static void IconChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormatIcon conditionalFormatIcon = (global::Infragistics.Controls.Grids.ConditionalFormatIcon)obj;
			conditionalFormatIcon.OnPropertyChanged("Icon");
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000B437 File Offset: 0x00009637
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0000B449 File Offset: 0x00009649
		public global::Infragistics.Controls.Grids.IconGroupOperator Operator
		{
			get
			{
				return (global::Infragistics.Controls.Grids.IconGroupOperator)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormatIcon.OperatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormatIcon.OperatorProperty, value);
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000B45C File Offset: 0x0000965C
		private static void OperatorChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormatIcon conditionalFormatIcon = (global::Infragistics.Controls.Grids.ConditionalFormatIcon)obj;
			conditionalFormatIcon.OnPropertyChanged("Operator");
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000B47B File Offset: 0x0000967B
		// (set) Token: 0x06000211 RID: 529 RVA: 0x0000B48D File Offset: 0x0000968D
		public double Value
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormatIcon.ValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormatIcon.ValueProperty, value);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000B4A0 File Offset: 0x000096A0
		private static void ValueChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormatIcon conditionalFormatIcon = (global::Infragistics.Controls.Grids.ConditionalFormatIcon)obj;
			conditionalFormatIcon.OnPropertyChanged("Value");
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000B4BF File Offset: 0x000096BF
		// (set) Token: 0x06000214 RID: 532 RVA: 0x0000B4D1 File Offset: 0x000096D1
		public global::Infragistics.Controls.Grids.IconRuleValueType ValueType
		{
			get
			{
				return (global::Infragistics.Controls.Grids.IconRuleValueType)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormatIcon.ValueTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormatIcon.ValueTypeProperty, value);
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000B4E4 File Offset: 0x000096E4
		private static void ValueTypeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormatIcon conditionalFormatIcon = (global::Infragistics.Controls.Grids.ConditionalFormatIcon)obj;
			conditionalFormatIcon.OnPropertyChanged("ValueType");
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000B503 File Offset: 0x00009703
		protected internal virtual bool PassesConditions(double value)
		{
			if (this.Operator == global::Infragistics.Controls.Grids.IconGroupOperator.GreaterThan)
			{
				return this.Value < value;
			}
			return this.Value <= value;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000B524 File Offset: 0x00009724
		protected internal virtual global::System.Windows.Style GenerateStyle()
		{
			return new global::System.Windows.Style(typeof(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl))
			{
				Setters = 
				{
					new global::System.Windows.Setter(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.IconProperty, this.Icon)
				}
			};
		}

		// Token: 0x0400008B RID: 139
		public static readonly global::System.Windows.DependencyProperty IconProperty = global::System.Windows.DependencyProperty.Register("Icon", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.ConditionalFormatIcon), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormatIcon.IconChanged)));

		// Token: 0x0400008C RID: 140
		public static readonly global::System.Windows.DependencyProperty OperatorProperty = global::System.Windows.DependencyProperty.Register("Operator", typeof(global::Infragistics.Controls.Grids.IconGroupOperator), typeof(global::Infragistics.Controls.Grids.ConditionalFormatIcon), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.IconGroupOperator.GreaterThanOrEqualTo, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormatIcon.OperatorChanged)));

		// Token: 0x0400008D RID: 141
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(double), typeof(global::Infragistics.Controls.Grids.ConditionalFormatIcon), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormatIcon.ValueChanged)));

		// Token: 0x0400008E RID: 142
		public static readonly global::System.Windows.DependencyProperty ValueTypeProperty = global::System.Windows.DependencyProperty.Register("ValueType", typeof(global::Infragistics.Controls.Grids.IconRuleValueType), typeof(global::Infragistics.Controls.Grids.ConditionalFormatIcon), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.IconRuleValueType.Number, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormatIcon.ValueTypeChanged)));
	}
}
