using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000060 RID: 96
	public class TwoColorScaleConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.TwoInputConditionalFormatRuleProxy
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000EA8F File Offset: 0x0000CC8F
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0000EA97 File Offset: 0x0000CC97
		protected double RedSlope { get; set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		protected double GreenSlope { get; set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000EAB1 File Offset: 0x0000CCB1
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000EAB9 File Offset: 0x0000CCB9
		protected double BlueSlope { get; set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000EAC2 File Offset: 0x0000CCC2
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000EACA File Offset: 0x0000CCCA
		protected double RedYIntercept { get; set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000EAD3 File Offset: 0x0000CCD3
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000EADB File Offset: 0x0000CCDB
		protected double BlueYIntercept { get; set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
		// (set) Token: 0x0600033D RID: 829 RVA: 0x0000EAEC File Offset: 0x0000CCEC
		protected double GreenYIntercept { get; set; }

		// Token: 0x0600033E RID: 830 RVA: 0x0000EAF5 File Offset: 0x0000CCF5
		protected override void GatherData(global::System.Linq.IQueryable query)
		{
			base.GatherData(query);
			this.GenerateLineEquations();
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000EB04 File Offset: 0x0000CD04
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			if (sourceDataValue == null)
			{
				return null;
			}
			double? num = null;
			global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule twoColorScaleConditionalFormatRule = (global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule)base.Parent;
			switch (twoColorScaleConditionalFormatRule.MinimumValueType)
			{
			case global::Infragistics.Controls.Grids.ValueType.GeneratedValue:
			{
				num = new double?(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				double? num2 = num;
				double? minimumValue = base.MinimumValue;
				if (num2.GetValueOrDefault() <= minimumValue.GetValueOrDefault() && (num2 != null & minimumValue != null))
				{
					return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(twoColorScaleConditionalFormatRule.MinimumColor);
				}
				break;
			}
			case global::Infragistics.Controls.Grids.ValueType.Number:
			{
				num = new double?(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				double? num3 = num;
				double? minimumValue2 = base.MinimumValue;
				if (num3.GetValueOrDefault() <= minimumValue2.GetValueOrDefault() && (num3 != null & minimumValue2 != null))
				{
					return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(twoColorScaleConditionalFormatRule.MinimumColor);
				}
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
						return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(twoColorScaleConditionalFormatRule.MinimumColor);
					}
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
						return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(twoColorScaleConditionalFormatRule.MinimumColor);
					}
				}
				break;
			}
			switch (twoColorScaleConditionalFormatRule.MaximumValueType)
			{
			case global::Infragistics.Controls.Grids.ValueType.GeneratedValue:
			{
				num = new double?(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				double? num6 = num;
				double? maximumValue = base.MaximumValue;
				if (num6.GetValueOrDefault() >= maximumValue.GetValueOrDefault() && (num6 != null & maximumValue != null))
				{
					return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(twoColorScaleConditionalFormatRule.MaximumColor);
				}
				break;
			}
			case global::Infragistics.Controls.Grids.ValueType.Number:
			{
				num = new double?(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
				double? num7 = num;
				double? maximumValue2 = base.MaximumValue;
				if (num7.GetValueOrDefault() >= maximumValue2.GetValueOrDefault() && (num7 != null & maximumValue2 != null))
				{
					return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(twoColorScaleConditionalFormatRule.MaximumColor);
				}
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
						return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(twoColorScaleConditionalFormatRule.MaximumColor);
					}
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
						return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(twoColorScaleConditionalFormatRule.MaximumColor);
					}
				}
				break;
			}
			if (twoColorScaleConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Number && twoColorScaleConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Number)
			{
				if (base.MaximumValue == null || base.MinimumValue == null)
				{
					throw new global::Infragistics.Controls.Grids.NullConditionalFormatEvaluationValueException();
				}
				return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(this.CalculateColor(global::System.Convert.ToDouble(num, global::System.Globalization.CultureInfo.InvariantCulture)));
			}
			else
			{
				if (twoColorScaleConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.GeneratedValue && twoColorScaleConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.GeneratedValue)
				{
					return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(this.CalculateColor(global::System.Convert.ToDouble(num, global::System.Globalization.CultureInfo.InvariantCulture)));
				}
				if (twoColorScaleConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Percent && twoColorScaleConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Percent)
				{
					return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(this.CalculateColor(global::System.Convert.ToDouble(num, global::System.Globalization.CultureInfo.InvariantCulture)));
				}
				if (twoColorScaleConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Percentile && twoColorScaleConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Percentile)
				{
					if (base.PercentileData == null)
					{
						return null;
					}
					return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(this.CalculateColor(global::System.Convert.ToDouble(num, global::System.Globalization.CultureInfo.InvariantCulture)));
				}
				else
				{
					double num10 = double.NaN;
					double num11 = double.NaN;
					if (twoColorScaleConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.GeneratedValue || twoColorScaleConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Number)
					{
						num10 = base.MinimumValue.Value;
					}
					if (twoColorScaleConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.GeneratedValue || twoColorScaleConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Number)
					{
						num11 = base.MaximumValue.Value;
					}
					if (!double.IsNaN(num10) && !double.IsNaN(num11))
					{
						return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(this.CalculateColor(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture)));
					}
					if (twoColorScaleConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Percent)
					{
						num10 = base.PercentData.GetRealValue(base.MinimumValue.Value);
					}
					else if (twoColorScaleConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Percentile)
					{
						num11 = base.PercentileData.GetValueJustUnderPercentile(base.MinimumValue.Value);
					}
					if (twoColorScaleConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Percent)
					{
						num11 = base.PercentData.GetRealValue(base.MaximumValue.Value);
					}
					else if (twoColorScaleConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Percentile)
					{
						num11 = base.PercentileData.GetValueJustOverPercentile(base.MaximumValue.Value);
					}
					global::Infragistics.Controls.Grids.RangeData rangeData = global::Infragistics.Controls.Grids.RangeData.CreateRangeData(new double?(num10), new double?(num11), null, null, null);
					return global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CreateStyle(this.CalculateColor(rangeData.GetPercentValue(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture))));
				}
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000F098 File Offset: 0x0000D298
		protected virtual void GenerateLineEquations()
		{
			if (base.MaximumValue == null || base.MinimumValue == null)
			{
				return;
			}
			global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule twoColorScaleConditionalFormatRule = (global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule)base.Parent;
			double num = base.MinimumValue.Value;
			double maxValue = base.MaximumValue.Value;
			this.RedSlope = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateColorSlope(num, maxValue, twoColorScaleConditionalFormatRule.MinimumColor.R, twoColorScaleConditionalFormatRule.MaximumColor.R);
			this.RedYIntercept = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateYIntercept(this.RedSlope, num, twoColorScaleConditionalFormatRule.MinimumColor.R);
			this.GreenSlope = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateColorSlope(num, maxValue, twoColorScaleConditionalFormatRule.MinimumColor.G, twoColorScaleConditionalFormatRule.MaximumColor.G);
			this.GreenYIntercept = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateYIntercept(this.GreenSlope, num, twoColorScaleConditionalFormatRule.MinimumColor.G);
			this.BlueSlope = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateColorSlope(num, maxValue, twoColorScaleConditionalFormatRule.MinimumColor.B, twoColorScaleConditionalFormatRule.MaximumColor.B);
			this.BlueYIntercept = global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase.CalculateYIntercept(this.BlueSlope, num, twoColorScaleConditionalFormatRule.MinimumColor.B);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000F1DC File Offset: 0x0000D3DC
		private global::System.Windows.Media.Color CalculateColor(double value)
		{
			global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule twoColorScaleConditionalFormatRule = (global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule)base.Parent;
			double num = this.RedSlope * value + this.RedYIntercept;
			double num2 = this.GreenSlope * value + this.GreenYIntercept;
			double num3 = this.BlueSlope * value + this.BlueYIntercept;
			global::System.Windows.Media.Color transparent = global::System.Windows.Media.Colors.Transparent;
			if (num > 255.0 || num3 > 255.0 || num2 > 255.0)
			{
				return twoColorScaleConditionalFormatRule.MaximumColor;
			}
			if (num < 0.0 || num3 < 0.0 || num2 < 0.0)
			{
				return twoColorScaleConditionalFormatRule.MinimumColor;
			}
			return global::System.Windows.Media.Color.FromArgb(byte.MaxValue, global::System.Convert.ToByte(num), global::System.Convert.ToByte(num2), global::System.Convert.ToByte(num3));
		}
	}
}
