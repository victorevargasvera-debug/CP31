using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200005F RID: 95
	public class ThreeColorScaleConditionalFormatRule : global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000E8D1 File Offset: 0x0000CAD1
		// (set) Token: 0x06000327 RID: 807 RVA: 0x0000E8E3 File Offset: 0x0000CAE3
		public global::Infragistics.Controls.Grids.ValueType MedianValueType
		{
			get
			{
				return (global::Infragistics.Controls.Grids.ValueType)base.GetValue(global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule.MedianValueTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule.MedianValueTypeProperty, value);
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		private static void MedianValueTypeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule threeColorScaleConditionalFormatRule = (global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule)obj;
			threeColorScaleConditionalFormatRule.OnPropertyChanged("MedianValueType");
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000E917 File Offset: 0x0000CB17
		// (set) Token: 0x0600032A RID: 810 RVA: 0x0000E929 File Offset: 0x0000CB29
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.NullableDoubleConverter))]
		public double? MedianValue
		{
			get
			{
				return (double?)base.GetValue(global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule.MedianValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule.MedianValueProperty, value);
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000E93C File Offset: 0x0000CB3C
		private static void MedianValueChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule threeColorScaleConditionalFormatRule = (global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule)obj;
			threeColorScaleConditionalFormatRule.OnPropertyChanged("MedianValue");
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000E95B File Offset: 0x0000CB5B
		// (set) Token: 0x0600032D RID: 813 RVA: 0x0000E96D File Offset: 0x0000CB6D
		public global::System.Windows.Media.Color MedianColor
		{
			get
			{
				return (global::System.Windows.Media.Color)base.GetValue(global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule.MedianColorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule.MedianColorProperty, value);
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000E980 File Offset: 0x0000CB80
		private static void MedianColorChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule threeColorScaleConditionalFormatRule = (global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule)obj;
			threeColorScaleConditionalFormatRule.OnPropertyChanged("MedianColor");
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRuleProxy
			{
				MedianValue = this.MedianValue,
				MaximumValue = base.MaximumValue,
				MinimumValue = base.MinimumValue
			};
		}

		// Token: 0x040000C0 RID: 192
		public static readonly global::System.Windows.DependencyProperty MedianValueTypeProperty = global::System.Windows.DependencyProperty.Register("MedianValueType", typeof(global::Infragistics.Controls.Grids.ValueType), typeof(global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.ValueType.GeneratedValue, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule.MedianValueTypeChanged)));

		// Token: 0x040000C1 RID: 193
		public static readonly global::System.Windows.DependencyProperty MedianValueProperty = global::System.Windows.DependencyProperty.Register("MedianValue", typeof(double?), typeof(global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule.MedianValueChanged)));

		// Token: 0x040000C2 RID: 194
		public static readonly global::System.Windows.DependencyProperty MedianColorProperty = global::System.Windows.DependencyProperty.Register("MedianColor", typeof(global::System.Windows.Media.Color), typeof(global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule.MedianColorChanged)));
	}
}
