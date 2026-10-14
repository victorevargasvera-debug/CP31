using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200003E RID: 62
	public class BetweenXandYConditionalFormatRule : global::Infragistics.Controls.Grids.DiscreetRuleBase
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x0000C7C3 File Offset: 0x0000A9C3
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRuleProxy();
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000C7CA File Offset: 0x0000A9CA
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x0000C7DC File Offset: 0x0000A9DC
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.IComparableTypeConverter))]
		public global::System.IComparable LowerBound
		{
			get
			{
				return (global::System.IComparable)base.GetValue(global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule.LowerBoundProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule.LowerBoundProperty, value);
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		private static void LowerBoundChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule betweenXandYConditionalFormatRule = (global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule)obj;
			betweenXandYConditionalFormatRule.OnPropertyChanged("LowerBound");
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000C80C File Offset: 0x0000AA0C
		protected internal global::System.IComparable LowerBoundResolved
		{
			get
			{
				global::System.IComparable comparable = this.LowerBound;
				if (base.Column != null)
				{
					try
					{
						comparable = (base.Column.ResolveValue(comparable) as global::System.IComparable);
					}
					catch
					{
					}
				}
				return comparable;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000C850 File Offset: 0x0000AA50
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0000C862 File Offset: 0x0000AA62
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.IComparableTypeConverter))]
		public global::System.IComparable UpperBound
		{
			get
			{
				return (global::System.IComparable)base.GetValue(global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule.UpperBoundProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule.UpperBoundProperty, value);
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000C870 File Offset: 0x0000AA70
		private static void UpperBoundChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule betweenXandYConditionalFormatRule = (global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule)obj;
			betweenXandYConditionalFormatRule.OnPropertyChanged("UpperBound");
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000C890 File Offset: 0x0000AA90
		protected internal global::System.IComparable UpperBoundResolved
		{
			get
			{
				global::System.IComparable comparable = this.UpperBound;
				if (base.Column != null)
				{
					try
					{
						comparable = (base.Column.ResolveValue(comparable) as global::System.IComparable);
					}
					catch
					{
					}
				}
				return comparable;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000C8D4 File Offset: 0x0000AAD4
		// (set) Token: 0x060002AA RID: 682 RVA: 0x0000C8E6 File Offset: 0x0000AAE6
		public bool IsInclusive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule.IsInclusiveProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule.IsInclusiveProperty, value);
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		private static void IsInclusiveChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule betweenXandYConditionalFormatRule = (global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule)obj;
			betweenXandYConditionalFormatRule.OnPropertyChanged("IsInclusive");
		}

		// Token: 0x040000A7 RID: 167
		public static readonly global::System.Windows.DependencyProperty LowerBoundProperty = global::System.Windows.DependencyProperty.Register("LowerBound", typeof(global::System.IComparable), typeof(global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule.LowerBoundChanged)));

		// Token: 0x040000A8 RID: 168
		public static readonly global::System.Windows.DependencyProperty UpperBoundProperty = global::System.Windows.DependencyProperty.Register("UpperBound", typeof(global::System.IComparable), typeof(global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule.UpperBoundChanged)));

		// Token: 0x040000A9 RID: 169
		public static readonly global::System.Windows.DependencyProperty IsInclusiveProperty = global::System.Windows.DependencyProperty.Register("IsInclusive", typeof(bool), typeof(global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule.IsInclusiveChanged)));
	}
}
