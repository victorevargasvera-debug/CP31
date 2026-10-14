using System;
using System.Windows;
using System.Windows.Media;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000043 RID: 67
	public class DataBarConditionalFormatRule : global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000CD49 File Offset: 0x0000AF49
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0000CD5B File Offset: 0x0000AF5B
		public global::Infragistics.Controls.Grids.DataBarDirection DataBarDirection
		{
			get
			{
				return (global::Infragistics.Controls.Grids.DataBarDirection)base.GetValue(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule.DataBarDirectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule.DataBarDirectionProperty, value);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000CD70 File Offset: 0x0000AF70
		private static void DataBarDirectionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.DataBarConditionalFormatRule dataBarConditionalFormatRule = (global::Infragistics.Controls.Grids.DataBarConditionalFormatRule)obj;
			dataBarConditionalFormatRule.OnPropertyChanged("DataBarDirection");
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000CD8F File Offset: 0x0000AF8F
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0000CDA1 File Offset: 0x0000AFA1
		public global::System.Windows.Media.Brush DataBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule.DataBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule.DataBrushProperty, value);
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		private static void DataBrushChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.DataBarConditionalFormatRule dataBarConditionalFormatRule = (global::Infragistics.Controls.Grids.DataBarConditionalFormatRule)obj;
			dataBarConditionalFormatRule.OnPropertyChanged("DataBrush");
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000CDCF File Offset: 0x0000AFCF
		// (set) Token: 0x060002CA RID: 714 RVA: 0x0000CDE1 File Offset: 0x0000AFE1
		public global::System.Windows.Media.Brush NegativeDataBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule.NegativeDataBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule.NegativeDataBrushProperty, value);
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000CDF0 File Offset: 0x0000AFF0
		private static void NegativeDataBrushChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.DataBarConditionalFormatRule dataBarConditionalFormatRule = (global::Infragistics.Controls.Grids.DataBarConditionalFormatRule)obj;
			dataBarConditionalFormatRule.OnPropertyChanged("NegativeDataBrush");
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0000CE0F File Offset: 0x0000B00F
		// (set) Token: 0x060002CD RID: 717 RVA: 0x0000CE21 File Offset: 0x0000B021
		public bool UseNegativeDataBar
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule.UseNegativeDataBarProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule.UseNegativeDataBarProperty, value);
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000CE34 File Offset: 0x0000B034
		private static void UseNegativeDataBarChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.DataBarConditionalFormatRule dataBarConditionalFormatRule = (global::Infragistics.Controls.Grids.DataBarConditionalFormatRule)obj;
			dataBarConditionalFormatRule.OnPropertyChanged("UseNegativeDataBar");
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000CE54 File Offset: 0x0000B054
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.DataBarConditionalFormatRuleProxy
			{
				MaximumValue = base.MaximumValue,
				MinimumValue = base.MinimumValue
			};
		}

		// Token: 0x040000AE RID: 174
		public static readonly global::System.Windows.DependencyProperty DataBarDirectionProperty = global::System.Windows.DependencyProperty.Register("DataBarDirection", typeof(global::Infragistics.Controls.Grids.DataBarDirection), typeof(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.DataBarDirection.UnidirectionalLeftToRight, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule.DataBarDirectionChanged)));

		// Token: 0x040000AF RID: 175
		public static readonly global::System.Windows.DependencyProperty DataBrushProperty = global::System.Windows.DependencyProperty.Register("DataBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule.DataBrushChanged)));

		// Token: 0x040000B0 RID: 176
		public static readonly global::System.Windows.DependencyProperty NegativeDataBrushProperty = global::System.Windows.DependencyProperty.Register("NegativeDataBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule.NegativeDataBrushChanged)));

		// Token: 0x040000B1 RID: 177
		public static readonly global::System.Windows.DependencyProperty UseNegativeDataBarProperty = global::System.Windows.DependencyProperty.Register("UseNegativeDataBar", typeof(bool), typeof(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.DataBarConditionalFormatRule.UseNegativeDataBarChanged)));
	}
}
