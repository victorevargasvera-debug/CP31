using System;
using System.Linq;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000044 RID: 68
	public abstract class TwoInputConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.ConditionalFormattingRuleBaseProxy
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000CF6B File Offset: 0x0000B16B
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x0000CF73 File Offset: 0x0000B173
		protected global::Infragistics.Controls.Grids.PercentileData PercentileData { get; set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000CF7C File Offset: 0x0000B17C
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x0000CF84 File Offset: 0x0000B184
		protected global::Infragistics.Controls.Grids.PercentData PercentData { get; set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000CF8D File Offset: 0x0000B18D
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x0000CF95 File Offset: 0x0000B195
		protected internal double? MaximumValue { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000CF9E File Offset: 0x0000B19E
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0000CFA6 File Offset: 0x0000B1A6
		protected internal double? MinimumValue { get; set; }

		// Token: 0x060002DA RID: 730 RVA: 0x0000CFB0 File Offset: 0x0000B1B0
		protected override void GatherData(global::System.Linq.IQueryable query)
		{
			global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule twoInputConditionalFormatRule = (global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule)base.Parent;
			if (twoInputConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.GeneratedValue)
			{
				this.MaximumValue = new double?(global::Infragistics.Controls.Grids.AutomaticData.CreateAutomaticData(twoInputConditionalFormatRule.Column.ColumnLayout.ObjectDataTypeInfo, twoInputConditionalFormatRule.Column.Key, global::Infragistics.LinqSummaryOperator.Maximum, query));
			}
			else if (twoInputConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Number && this.MaximumValue == null)
			{
				throw new global::System.ArgumentException(global::Infragistics.SRGrid.GetString("ConditionalFormattingMaximumNotSet"));
			}
			if (twoInputConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.GeneratedValue)
			{
				this.MinimumValue = new double?(global::Infragistics.Controls.Grids.AutomaticData.CreateAutomaticData(twoInputConditionalFormatRule.Column.ColumnLayout.ObjectDataTypeInfo, twoInputConditionalFormatRule.Column.Key, global::Infragistics.LinqSummaryOperator.Minimum, query));
			}
			else if (twoInputConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Number && this.MinimumValue == null)
			{
				throw new global::System.ArgumentException(global::Infragistics.SRGrid.GetString("ConditionalFormattingMinimumNotSet"));
			}
			bool flag = twoInputConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Percentile || twoInputConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Percentile;
			bool flag2 = twoInputConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Percent || twoInputConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Percent;
			if (flag)
			{
				this.PercentileData = global::Infragistics.Controls.Grids.PercentileData.CreateGenericPercentileData(twoInputConditionalFormatRule.Column.ColumnLayout.ObjectDataTypeInfo, twoInputConditionalFormatRule.Column.Key, twoInputConditionalFormatRule.Column.DataType == typeof(global::System.DateTime), query);
				if (twoInputConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Percentile && this.MinimumValue == null)
				{
					this.MinimumValue = new double?(this.PercentileData.CalculatedMinimumPercentileValue);
				}
				if (twoInputConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Percentile && this.MaximumValue == null)
				{
					this.MaximumValue = new double?(this.PercentileData.CalculatedMaximumPercentileValue);
				}
			}
			if (flag2)
			{
				this.PercentData = global::Infragistics.Controls.Grids.PercentData.CreatePercentData(twoInputConditionalFormatRule.Column.ColumnLayout.ObjectDataTypeInfo, twoInputConditionalFormatRule.Column.Key, query);
				if (twoInputConditionalFormatRule.MinimumValueType == global::Infragistics.Controls.Grids.ValueType.Percent && this.MinimumValue == null)
				{
					this.MinimumValue = new double?(0.0);
				}
				if (twoInputConditionalFormatRule.MaximumValueType == global::Infragistics.Controls.Grids.ValueType.Percent && this.MaximumValue == null)
				{
					this.MaximumValue = new double?(100.0);
				}
			}
		}
	}
}
