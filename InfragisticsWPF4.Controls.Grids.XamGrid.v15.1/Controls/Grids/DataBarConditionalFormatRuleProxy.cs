using System;
using System.Globalization;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000045 RID: 69
	public class DataBarConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.TwoInputConditionalFormatRuleProxy
	{
		// Token: 0x060002DC RID: 732 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
		protected virtual global::System.Windows.Style GenerateStyle(double percentageValue, global::Infragistics.Controls.Grids.DataBarPositiveNegative barColorationAndDirection)
		{
			global::Infragistics.Controls.Grids.DataBarConditionalFormatRule dataBarConditionalFormatRule = (global::Infragistics.Controls.Grids.DataBarConditionalFormatRule)base.Parent;
			global::System.Windows.Style style = new global::System.Windows.Style(typeof(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl));
			style.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarPositiveOrNegativeProperty, barColorationAndDirection));
			if (dataBarConditionalFormatRule.DataBrush != null)
			{
				style.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarBrushProperty, dataBarConditionalFormatRule.DataBrush));
			}
			if (dataBarConditionalFormatRule.NegativeDataBrush != null)
			{
				style.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.NegativeBarBrushProperty, dataBarConditionalFormatRule.NegativeDataBrush));
			}
			style.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarDirectionProperty, dataBarConditionalFormatRule.DataBarDirection));
			style.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarPercentageProperty, percentageValue));
			return style;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000D2B8 File Offset: 0x0000B4B8
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			if (sourceDataValue == null)
			{
				return null;
			}
			global::Infragistics.Controls.Grids.DataBarConditionalFormatRule dataBarConditionalFormatRule = (global::Infragistics.Controls.Grids.DataBarConditionalFormatRule)base.Parent;
			double? num = null;
			bool flag = false;
			switch (dataBarConditionalFormatRule.MinimumValueType)
			{
			case global::Infragistics.Controls.Grids.ValueType.GeneratedValue:
			{
				num = new double?(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				double? num2 = num;
				if (num2.GetValueOrDefault() < 0.0 && num2 != null)
				{
					flag = true;
				}
				double? num3 = num;
				double? minimumValue = base.MinimumValue;
				if (num3.GetValueOrDefault() <= minimumValue.GetValueOrDefault() && (num3 != null & minimumValue != null))
				{
					bool flag2 = dataBarConditionalFormatRule.UseNegativeDataBar && flag;
					if (flag2)
					{
						return this.GenerateStyle(100.0, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Negative);
					}
					return this.GenerateStyle(0.0, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive);
				}
				break;
			}
			case global::Infragistics.Controls.Grids.ValueType.Number:
			{
				num = new double?(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				double? num4 = num;
				if (num4.GetValueOrDefault() < 0.0 && num4 != null)
				{
					flag = true;
				}
				double? num5 = num;
				double? minimumValue2 = base.MinimumValue;
				if (num5.GetValueOrDefault() <= minimumValue2.GetValueOrDefault() && (num5 != null & minimumValue2 != null))
				{
					bool flag3 = dataBarConditionalFormatRule.UseNegativeDataBar && flag;
					if (flag3)
					{
						return this.GenerateStyle(100.0, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Negative);
					}
					return this.GenerateStyle(0.0, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive);
				}
				break;
			}
			case global::Infragistics.Controls.Grids.ValueType.Percent:
				if (base.PercentData != null && base.PercentData.Range > 0.0)
				{
					num = new double?(base.PercentData.GetPercentValue(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture)));
					double? num6 = num;
					double? minimumValue3 = base.MinimumValue;
					if (num6.GetValueOrDefault() <= minimumValue3.GetValueOrDefault() && (num6 != null & minimumValue3 != null))
					{
						return this.GenerateStyle(0.0, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive);
					}
				}
				break;
			case global::Infragistics.Controls.Grids.ValueType.Percentile:
				if (base.PercentileData != null)
				{
					num = new double?(base.PercentileData.GetPercentileValue(sourceDataValue));
					double? num7 = num;
					double? minimumValue4 = base.MinimumValue;
					if (num7.GetValueOrDefault() <= minimumValue4.GetValueOrDefault() && (num7 != null & minimumValue4 != null))
					{
						return this.GenerateStyle(0.0, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive);
					}
				}
				break;
			}
			switch (dataBarConditionalFormatRule.MaximumValueType)
			{
			case global::Infragistics.Controls.Grids.ValueType.GeneratedValue:
			{
				num = new double?(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				double? num8 = num;
				if (num8.GetValueOrDefault() < 0.0 && num8 != null)
				{
					flag = true;
				}
				double? num9 = num;
				double? maximumValue = base.MaximumValue;
				if (num9.GetValueOrDefault() >= maximumValue.GetValueOrDefault() && (num9 != null & maximumValue != null) && (!dataBarConditionalFormatRule.UseNegativeDataBar || !flag))
				{
					return this.GenerateStyle(100.0, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive);
				}
				break;
			}
			case global::Infragistics.Controls.Grids.ValueType.Number:
			{
				num = new double?(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				double? num10 = num;
				if (num10.GetValueOrDefault() < 0.0 && num10 != null)
				{
					flag = true;
				}
				double? num11 = num;
				double? maximumValue2 = base.MaximumValue;
				if (num11.GetValueOrDefault() >= maximumValue2.GetValueOrDefault() && (num11 != null & maximumValue2 != null))
				{
					bool flag4 = dataBarConditionalFormatRule.UseNegativeDataBar && flag;
					if (flag4)
					{
						return this.GenerateStyle(100.0, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Negative);
					}
					return this.GenerateStyle(100.0, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive);
				}
				break;
			}
			case global::Infragistics.Controls.Grids.ValueType.Percent:
				if (base.PercentData != null && base.PercentData.Range > 0.0)
				{
					num = new double?(base.PercentData.GetPercentValue(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture)));
					double? num12 = num;
					double? maximumValue3 = base.MaximumValue;
					if (num12.GetValueOrDefault() >= maximumValue3.GetValueOrDefault() && (num12 != null & maximumValue3 != null))
					{
						return this.GenerateStyle(100.0, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive);
					}
				}
				break;
			case global::Infragistics.Controls.Grids.ValueType.Percentile:
				if (base.PercentileData != null)
				{
					num = new double?(base.PercentileData.GetPercentileValue(sourceDataValue));
					double? num13 = num;
					double? maximumValue4 = base.MaximumValue;
					if (num13.GetValueOrDefault() >= maximumValue4.GetValueOrDefault() && (num13 != null & maximumValue4 != null))
					{
						return this.GenerateStyle(100.0, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive);
					}
				}
				break;
			}
			if ((dataBarConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Number || dataBarConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.GeneratedValue) && (dataBarConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Number || dataBarConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.GeneratedValue))
			{
				return this.GenerateStyleForDiscreetEndPointedValues(sourceDataValue, dataBarConditionalFormatRule);
			}
			if (dataBarConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Percent && dataBarConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Percent)
			{
				double num14 = base.PercentData.GetPercentValue(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				if (base.MinimumValue != null && base.MaximumValue != null)
				{
					double num15 = base.MaximumValue.Value - base.MinimumValue.Value;
					num14 -= base.MinimumValue.Value;
					num14 = num14 / num15 * 100.0;
				}
				return this.GenerateStyle(num14, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive);
			}
			if (dataBarConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Percentile && dataBarConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Percentile)
			{
				if (base.PercentileData == null)
				{
					return null;
				}
				double percentileValue = base.PercentileData.GetPercentileValue(sourceDataValue);
				double num16 = global::System.Convert.ToDouble(base.MinimumValue, global::System.Globalization.CultureInfo.InvariantCulture);
				double num17 = global::System.Convert.ToDouble(base.MaximumValue, global::System.Globalization.CultureInfo.InvariantCulture);
				return this.GenerateStyle((percentileValue - num16) / (num17 - num16) * 100.0, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive);
			}
			else
			{
				double value = double.NaN;
				double num18 = double.NaN;
				if (dataBarConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.GeneratedValue || dataBarConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Number)
				{
					value = base.MinimumValue.Value;
				}
				else if (dataBarConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Percent)
				{
					value = base.PercentData.GetRealValue(base.MinimumValue.Value);
				}
				else if (dataBarConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Percentile)
				{
					num18 = base.PercentileData.GetValueJustUnderPercentile(base.MinimumValue.Value);
				}
				if (dataBarConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.GeneratedValue || dataBarConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Number)
				{
					num18 = base.MaximumValue.Value;
				}
				else if (dataBarConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Percent)
				{
					num18 = base.PercentData.GetRealValue(base.MaximumValue.Value);
				}
				else if (dataBarConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Percentile)
				{
					num18 = base.PercentileData.GetValueJustOverPercentile(base.MaximumValue.Value);
				}
				if (flag)
				{
					global::Infragistics.Controls.Grids.RangeData rangeData = global::Infragistics.Controls.Grids.RangeData.CreateRangeData(0.0, global::System.Math.Abs(value));
					double percentValue = rangeData.GetPercentValue(global::System.Math.Abs(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture)));
					return this.GenerateStyle(percentValue, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Negative);
				}
				if (dataBarConditionalFormatRule.DataBarDirection == global::Infragistics.Controls.Grids.DataBarDirection.Bidirectional)
				{
					global::Infragistics.Controls.Grids.RangeData rangeData2 = global::Infragistics.Controls.Grids.RangeData.CreateRangeData(0.0, num18);
					double percentValue2 = rangeData2.GetPercentValue(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
					return this.GenerateStyle(percentValue2, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive);
				}
				global::Infragistics.Controls.Grids.RangeData rangeData3 = global::Infragistics.Controls.Grids.RangeData.CreateRangeData(new double?(value), new double?(num18), null, null, null);
				double percentValue3 = rangeData3.GetPercentValue(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				return this.GenerateStyle(percentValue3, global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive);
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000DA3C File Offset: 0x0000BC3C
		private global::System.Windows.Style GenerateStyleForDiscreetEndPointedValues(object sourceDataValue, global::Infragistics.Controls.Grids.DataBarConditionalFormatRule rule)
		{
			if (base.MaximumValue == null || base.MinimumValue == null)
			{
				throw new global::Infragistics.Controls.Grids.NullConditionalFormatEvaluationValueException();
			}
			double num = global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture);
			double value = base.MinimumValue.Value;
			double value2 = base.MaximumValue.Value;
			global::Infragistics.Controls.Grids.DataBarPositiveNegative barColorationAndDirection = global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive;
			global::Infragistics.Controls.Grids.RangeData rangeData;
			if (num >= 0.0)
			{
				if (rule.UseNegativeDataBar)
				{
					value = 0.0;
				}
				rangeData = global::Infragistics.Controls.Grids.RangeData.CreateRangeData(new double?(value), new double?(value2), null, null, null);
				return this.GenerateStyle(rangeData.GetPercentValue(num), barColorationAndDirection);
			}
			if (rule.UseNegativeDataBar)
			{
				value = 0.0;
				value2 = global::System.Math.Abs(base.MinimumValue.Value);
				barColorationAndDirection = global::Infragistics.Controls.Grids.DataBarPositiveNegative.Negative;
				num = global::System.Math.Abs(num);
			}
			rangeData = global::Infragistics.Controls.Grids.RangeData.CreateRangeData(new double?(value), new double?(value2), null, null, null);
			return this.GenerateStyle(rangeData.GetPercentValue(num), barColorationAndDirection);
		}
	}
}
