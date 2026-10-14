using System;
using System.Globalization;
using System.Linq;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200004F RID: 79
	public class IconConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.ConditionalFormattingRuleBaseProxy
	{
		// Token: 0x060002FE RID: 766 RVA: 0x0000E29C File Offset: 0x0000C49C
		protected override void GatherData(global::System.Linq.IQueryable query)
		{
			global::Infragistics.Controls.Grids.IconConditionalFormatRule iconConditionalFormatRule = (global::Infragistics.Controls.Grids.IconConditionalFormatRule)base.Parent;
			bool flag = false;
			bool flag2 = false;
			foreach (global::Infragistics.Controls.Grids.ConditionalFormatIcon conditionalFormatIcon in iconConditionalFormatRule.Rules)
			{
				if (conditionalFormatIcon.ValueType == global::Infragistics.Controls.Grids.IconRuleValueType.Percent)
				{
					flag2 = true;
				}
				else if (conditionalFormatIcon.ValueType == global::Infragistics.Controls.Grids.IconRuleValueType.Percentile)
				{
					flag = true;
				}
			}
			if (flag)
			{
				this._percentileData = global::Infragistics.Controls.Grids.PercentileData.CreateGenericPercentileData(iconConditionalFormatRule.Column.ColumnLayout.ObjectDataTypeInfo, iconConditionalFormatRule.Column.Key, iconConditionalFormatRule.Column.DataType == typeof(global::System.DateTime), query);
			}
			if (flag2)
			{
				this._percentData = global::Infragistics.Controls.Grids.PercentData.CreatePercentData(iconConditionalFormatRule.Column.ColumnLayout.ObjectDataTypeInfo, iconConditionalFormatRule.Column.Key, query);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000E380 File Offset: 0x0000C580
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			if (sourceDataValue == null)
			{
				return null;
			}
			global::Infragistics.Controls.Grids.IconConditionalFormatRule iconConditionalFormatRule = (global::Infragistics.Controls.Grids.IconConditionalFormatRule)base.Parent;
			int num = iconConditionalFormatRule.Rules.Count - 1;
			foreach (global::Infragistics.Controls.Grids.ConditionalFormatIcon conditionalFormatIcon in iconConditionalFormatRule.Rules)
			{
				double? num2 = null;
				if (sourceDataValue == null)
				{
					return null;
				}
				switch (conditionalFormatIcon.ValueType)
				{
				case global::Infragistics.Controls.Grids.IconRuleValueType.Number:
					num2 = new double?(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture));
					break;
				case global::Infragistics.Controls.Grids.IconRuleValueType.Percent:
					if (this._percentData != null && this._percentData.Range > 0.0)
					{
						num2 = new double?(this._percentData.GetPercentValue(global::System.Convert.ToDouble(sourceDataValue, global::System.Globalization.CultureInfo.InvariantCulture)));
					}
					break;
				case global::Infragistics.Controls.Grids.IconRuleValueType.Percentile:
					if (this._percentileData != null)
					{
						num2 = new double?(this._percentileData.GetPercentileValue(sourceDataValue));
					}
					break;
				}
				if ((num2 != null && conditionalFormatIcon.PassesConditions(num2.Value)) || iconConditionalFormatRule.Rules.IndexOf(conditionalFormatIcon) == num)
				{
					return conditionalFormatIcon.GenerateStyle();
				}
			}
			return null;
		}

		// Token: 0x040000BC RID: 188
		private global::Infragistics.Controls.Grids.PercentileData _percentileData;

		// Token: 0x040000BD RID: 189
		private global::Infragistics.Controls.Grids.PercentData _percentData;
	}
}
