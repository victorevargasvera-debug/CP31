using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000061 RID: 97
	public class ThreeColorScaleConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRuleProxy
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
		// (set) Token: 0x06000344 RID: 836 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		protected internal double? MedianValue { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0000F2D9 File Offset: 0x0000D4D9
		// (set) Token: 0x06000346 RID: 838 RVA: 0x0000F2E1 File Offset: 0x0000D4E1
		protected double RedSlope2 { get; set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0000F2EA File Offset: 0x0000D4EA
		// (set) Token: 0x06000348 RID: 840 RVA: 0x0000F2F2 File Offset: 0x0000D4F2
		protected double RedYIntercept2 { get; set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000349 RID: 841 RVA: 0x0000F2FB File Offset: 0x0000D4FB
		// (set) Token: 0x0600034A RID: 842 RVA: 0x0000F303 File Offset: 0x0000D503
		protected double GreenSlope2 { get; set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0000F30C File Offset: 0x0000D50C
		// (set) Token: 0x0600034C RID: 844 RVA: 0x0000F314 File Offset: 0x0000D514
		protected double GreenYIntercept2 { get; set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600034D RID: 845 RVA: 0x0000F31D File Offset: 0x0000D51D
		// (set) Token: 0x0600034E RID: 846 RVA: 0x0000F325 File Offset: 0x0000D525
		protected double BlueSlope2 { get; set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0000F32E File Offset: 0x0000D52E
		// (set) Token: 0x06000350 RID: 848 RVA: 0x0000F336 File Offset: 0x0000D536
		protected double BlueYIntercept2 { get; set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000F33F File Offset: 0x0000D53F
		// (set) Token: 0x06000352 RID: 850 RVA: 0x0000F347 File Offset: 0x0000D547
		private double MedianConvertedValue { get; set; }

		// Token: 0x06000353 RID: 851 RVA: 0x0000F350 File Offset: 0x0000D550
		protected override void GatherData(global::System.Linq.IQueryable query)
		{
			global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule threeColorScaleConditionalFormatRule = (global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule)base.Parent;
			if (threeColorScaleConditionalFormatRule.MedianValueType == global::Infragistics.Controls.Grids.ValueType.GeneratedValue)
			{
				global::Infragistics.SummaryContext summaryContext = global::Infragistics.SummaryContext.CreateGenericSummary(base.Parent.Column.ColumnLayout.ObjectDataTypeInfo, base.Parent.Column.Key, global::Infragistics.LinqSummaryOperator.Average);
				this.MedianValue = new double?(global::System.Convert.ToDouble(summaryContext.Execute(query), global::System.Globalization.CultureInfo.InvariantCulture));
			}
			base.GatherData(query);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		protected override void GenerateLineEquations()
		{
			global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule threeColorScaleConditionalFormatRule = (global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule)base.Parent;
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			switch (threeColorScaleConditionalFormatRule.MinimumValueType)
			{
			case global::Infragistics.Controls.Grids.ValueType.GeneratedValue:
				num = base.MinimumValue.Value;
				break;
			case global::Infragistics.Controls.Grids.ValueType.Number:
				num = base.MinimumValue.Value;
				break;
			case global::Infragistics.Controls.Grids.ValueType.Percent:
				if (base.PercentData != null)
				{
					num = base.PercentData.GetRealValue(base.MinimumValue.Value);
				}
				break;
			case global::Infragistics.Controls.Grids.ValueType.Percentile:
				if (base.PercentileData != null)
				{
					num = base.PercentileData.GetValueJustOverPercentile(base.MinimumValue.Value);
				}
				break;
			}
			switch (threeColorScaleConditionalFormatRule.MaximumValueType)
			{
			case global::Infragistics.Controls.Grids.ValueType.GeneratedValue:
				num2 = base.MaximumValue.Value;
				break;
			case global::Infragistics.Controls.Grids.ValueType.Number:
				num2 = base.MaximumValue.Value;
				break;
			case global::Infragistics.Controls.Grids.ValueType.Percent:
				if (base.PercentData != null)
				{
					num2 = base.PercentData.GetRealValue(base.MaximumValue.Value);
				}
				break;
			case global::Infragistics.Controls.Grids.ValueType.Percentile:
				if (base.PercentileData != null)
				{
					num2 = base.PercentileData.GetValueJustUnderPercentile(base.MaximumValue.Value);
				}
				break;
			}
			switch (threeColorScaleConditionalFormatRule.MedianValueType)
			{
			case global::Infragistics.Controls.Grids.ValueType.GeneratedValue:
				num3 = this.MedianValue.Value;
				break;
			case global::Infragistics.Controls.Grids.ValueType.Number:
				num3 = this.MedianValue.Value;
				break;
			case global::Infragistics.Controls.Grids.ValueType.Percent:
				if (base.PercentData != null)
				{
					num3 = base.PercentData.GetRealValue(this.MedianValue.Value);
				}
				break;
			case global::Infragistics.Controls.Grids.ValueType.Percentile:
				if (base.PercentileData != null)
				{
					num3 = base.PercentileData.GetValueJustUnderPercentile(this.MedianValue.Value);
				}
				break;
			}
			this.MedianConvertedValue = num3;
			double num4 = num;
			double maxValue = num3;
			global::System.Windows.Media.Color color = threeColorScaleConditionalFormatRule.MinimumColor;
			global::System.Windows.Media.Color color2 = threeColorScaleConditionalFormatRule.MedianColor;
			base.RedSlope = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateColorSlope(num4, maxValue, color.R, color2.R);
			base.RedYIntercept = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateYIntercept(base.RedSlope, num4, color.R);
			base.GreenSlope = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateColorSlope(num4, maxValue, color.G, color2.G);
			base.GreenYIntercept = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateYIntercept(base.GreenSlope, num4, color.G);
			base.BlueSlope = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateColorSlope(num4, maxValue, color.B, color2.B);
			base.BlueYIntercept = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateYIntercept(base.BlueSlope, num4, color.B);
			num4 = num3;
			maxValue = num2;
			color = threeColorScaleConditionalFormatRule.MedianColor;
			color2 = threeColorScaleConditionalFormatRule.MaximumColor;
			this.RedSlope2 = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateColorSlope(num4, maxValue, color.R, color2.R);
			this.RedYIntercept2 = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateYIntercept(this.RedSlope2, num4, color.R);
			this.GreenSlope2 = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateColorSlope(num4, maxValue, color.G, color2.G);
			this.GreenYIntercept2 = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateYIntercept(this.GreenSlope2, num4, color.G);
			this.BlueSlope2 = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateColorSlope(num4, maxValue, color.B, color2.B);
			this.BlueYIntercept2 = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateYIntercept(this.BlueSlope2, num4, color.B);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000F728 File Offset: 0x0000D928
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			if (sourceDataValue == null)
			{
				return null;
			}
			global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule threeColorScaleConditionalFormatRule = (global::Infragistics.Controls.Grids.ThreeColorScaleConditionalFormatRule)base.Parent;
			double? num = null;
			switch (threeColorScaleConditionalFormatRule.MinimumValueType)
			{
			case global::Infragistics.Controls.Grids.ValueType.GeneratedValue:
			{
				num = new double?(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				double? num2 = num;
				double? minimumValue = base.MinimumValue;
				if (num2.GetValueOrDefault() <= minimumValue.GetValueOrDefault() && (num2 != null & minimumValue != null))
				{
					return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(threeColorScaleConditionalFormatRule.MinimumColor);
				}
				double value = base.MinimumValue.Value;
				break;
			}
			case global::Infragistics.Controls.Grids.ValueType.Number:
			{
				num = new double?(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				double? num3 = num;
				double? minimumValue2 = base.MinimumValue;
				if (num3.GetValueOrDefault() <= minimumValue2.GetValueOrDefault() && (num3 != null & minimumValue2 != null))
				{
					return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(threeColorScaleConditionalFormatRule.MinimumColor);
				}
				double value2 = base.MinimumValue.Value;
				break;
			}
			case global::Infragistics.Controls.Grids.ValueType.Percent:
				if (base.PercentData != null && base.PercentData.Range > 0.0)
				{
					num = new double?(base.PercentData.GetPercentValue(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture)));
					double? num4 = num;
					double? minimumValue3 = base.MinimumValue;
					if (num4.GetValueOrDefault() <= minimumValue3.GetValueOrDefault() && (num4 != null & minimumValue3 != null))
					{
						return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(threeColorScaleConditionalFormatRule.MinimumColor);
					}
					base.PercentData.GetRealValue(base.MinimumValue.Value);
				}
				break;
			case global::Infragistics.Controls.Grids.ValueType.Percentile:
				if (base.PercentileData != null)
				{
					num = new double?(base.PercentileData.GetPercentileValue(sourceDataValue));
					double? num5 = num;
					double? minimumValue4 = base.MinimumValue;
					if (num5.GetValueOrDefault() <= minimumValue4.GetValueOrDefault() && (num5 != null & minimumValue4 != null))
					{
						return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(threeColorScaleConditionalFormatRule.MinimumColor);
					}
					base.PercentileData.GetValueJustOverPercentile(base.MinimumValue.Value);
				}
				break;
			}
			switch (threeColorScaleConditionalFormatRule.MaximumValueType)
			{
			case global::Infragistics.Controls.Grids.ValueType.GeneratedValue:
			{
				num = new double?(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				double? num6 = num;
				double? maximumValue = base.MaximumValue;
				if (num6.GetValueOrDefault() >= maximumValue.GetValueOrDefault() && (num6 != null & maximumValue != null))
				{
					return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(threeColorScaleConditionalFormatRule.MaximumColor);
				}
				double value3 = base.MaximumValue.Value;
				break;
			}
			case global::Infragistics.Controls.Grids.ValueType.Number:
			{
				num = new double?(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				double? num7 = num;
				double? maximumValue2 = base.MaximumValue;
				if (num7.GetValueOrDefault() >= maximumValue2.GetValueOrDefault() && (num7 != null & maximumValue2 != null))
				{
					return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(threeColorScaleConditionalFormatRule.MaximumColor);
				}
				double value4 = base.MaximumValue.Value;
				break;
			}
			case global::Infragistics.Controls.Grids.ValueType.Percent:
				if (base.PercentData != null && base.PercentData.Range > 0.0)
				{
					num = new double?(base.PercentData.GetPercentValue(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture)));
					double? num8 = num;
					double? maximumValue3 = base.MaximumValue;
					if (num8.GetValueOrDefault() >= maximumValue3.GetValueOrDefault() && (num8 != null & maximumValue3 != null))
					{
						return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(threeColorScaleConditionalFormatRule.MaximumColor);
					}
					base.PercentData.GetRealValue(base.MaximumValue.Value);
				}
				break;
			case global::Infragistics.Controls.Grids.ValueType.Percentile:
				if (base.PercentileData != null)
				{
					num = new double?(base.PercentileData.GetPercentileValue(sourceDataValue));
					double? num9 = num;
					double? maximumValue4 = base.MaximumValue;
					if (num9.GetValueOrDefault() >= maximumValue4.GetValueOrDefault() && (num9 != null & maximumValue4 != null))
					{
						return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(threeColorScaleConditionalFormatRule.MaximumColor);
					}
					base.PercentileData.GetValueJustUnderPercentile(base.MaximumValue.Value);
				}
				break;
			}
			switch (threeColorScaleConditionalFormatRule.MedianValueType)
			{
			case global::Infragistics.Controls.Grids.ValueType.GeneratedValue:
			{
				double value5 = this.MedianValue.Value;
				break;
			}
			case global::Infragistics.Controls.Grids.ValueType.Number:
			{
				double value6 = this.MedianValue.Value;
				break;
			}
			case global::Infragistics.Controls.Grids.ValueType.Percent:
				if (base.PercentData != null)
				{
					base.PercentData.GetRealValue(this.MedianValue.Value);
				}
				break;
			case global::Infragistics.Controls.Grids.ValueType.Percentile:
				if (base.PercentileData != null)
				{
					base.PercentileData.GetValueJustUnderPercentile(this.MedianValue.Value);
				}
				break;
			}
			double num10 = global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture);
			double value7;
			double value8;
			double value9;
			if (num10 < this.MedianConvertedValue)
			{
				value7 = base.RedSlope * num10 + base.RedYIntercept;
				value8 = base.GreenSlope * num10 + base.GreenYIntercept;
				value9 = base.BlueSlope * num10 + base.BlueYIntercept;
			}
			else
			{
				value7 = this.RedSlope2 * num10 + this.RedYIntercept2;
				value8 = this.GreenSlope2 * num10 + this.GreenYIntercept2;
				value9 = this.BlueSlope2 * num10 + this.BlueYIntercept2;
			}
			return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, this.NormalizeValue(value7), this.NormalizeValue(value8), this.NormalizeValue(value9)));
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000FC9C File Offset: 0x0000DE9C
		private byte NormalizeValue(double value)
		{
			return global::System.Convert.ToByte(global::System.Math.Max(0.0, global::System.Math.Min(255.0, value)));
		}
	}
}
