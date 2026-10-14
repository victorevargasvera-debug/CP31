using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000042 RID: 66
	public abstract class TwoInputConditionalFormatRule : global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000CB44 File Offset: 0x0000AD44
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x0000CB56 File Offset: 0x0000AD56
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.NullableDoubleConverter))]
		public double? MinimumValue
		{
			get
			{
				return (double?)base.GetValue(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule.MinimumValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule.MinimumValueProperty, value);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		private static void MinimumValueChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule twoInputConditionalFormatRule = (global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule)obj;
			twoInputConditionalFormatRule.OnPropertyChanged("MinimumValue");
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000CB8B File Offset: 0x0000AD8B
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0000CB9D File Offset: 0x0000AD9D
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.NullableDoubleConverter))]
		public double? MaximumValue
		{
			get
			{
				return (double?)base.GetValue(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule.MaximumValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule.MaximumValueProperty, value);
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000CBB0 File Offset: 0x0000ADB0
		private static void MaximumValueChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule twoInputConditionalFormatRule = (global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule)obj;
			twoInputConditionalFormatRule.OnPropertyChanged("MaximumValue");
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000CBCF File Offset: 0x0000ADCF
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0000CBE1 File Offset: 0x0000ADE1
		public global::Infragistics.Controls.Grids.ValueType MinimumValueType
		{
			get
			{
				return (global::Infragistics.Controls.Grids.ValueType)base.GetValue(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule.MinimumValueTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule.MinimumValueTypeProperty, value);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		private static void MinimumValueTypeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule twoInputConditionalFormatRule = (global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule)obj;
			twoInputConditionalFormatRule.OnPropertyChanged("MinimumValueType");
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000CC13 File Offset: 0x0000AE13
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000CC25 File Offset: 0x0000AE25
		public global::Infragistics.Controls.Grids.ValueType MaximumValueType
		{
			get
			{
				return (global::Infragistics.Controls.Grids.ValueType)base.GetValue(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule.MaximumValueTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule.MaximumValueTypeProperty, value);
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000CC38 File Offset: 0x0000AE38
		private static void MaximumValueTypeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule twoInputConditionalFormatRule = (global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule)obj;
			twoInputConditionalFormatRule.OnPropertyChanged("MaximumValueType");
		}

		// Token: 0x040000AA RID: 170
		public static readonly global::System.Windows.DependencyProperty MinimumValueProperty = global::System.Windows.DependencyProperty.Register("MinimumValue", typeof(double?), typeof(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule.MinimumValueChanged)));

		// Token: 0x040000AB RID: 171
		public static readonly global::System.Windows.DependencyProperty MaximumValueProperty = global::System.Windows.DependencyProperty.Register("MaximumValue", typeof(double?), typeof(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule.MaximumValueChanged)));

		// Token: 0x040000AC RID: 172
		public static readonly global::System.Windows.DependencyProperty MinimumValueTypeProperty = global::System.Windows.DependencyProperty.Register("MinimumValueType", typeof(global::Infragistics.Controls.Grids.ValueType), typeof(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.ValueType.GeneratedValue, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule.MinimumValueTypeChanged)));

		// Token: 0x040000AD RID: 173
		public static readonly global::System.Windows.DependencyProperty MaximumValueTypeProperty = global::System.Windows.DependencyProperty.Register("MaximumValueType", typeof(global::Infragistics.Controls.Grids.ValueType), typeof(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.ValueType.GeneratedValue, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule.MaximumValueTypeChanged)));
	}
}
