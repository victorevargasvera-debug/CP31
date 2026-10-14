using System;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.Aggregates;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200038C RID: 908
	public class HSSFSheetConditionalFormatting : global::NPOI.SS.UserModel.ISheetConditionalFormatting
	{
		// Token: 0x06001E61 RID: 7777 RVA: 0x0005CE1E File Offset: 0x0005B01E
		public HSSFSheetConditionalFormatting(global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			this._sheet = sheet;
			this._conditionalFormattingTable = sheet.Sheet.ConditionalFormattingTable;
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x0005CE40 File Offset: 0x0005B040
		public global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.SS.UserModel.ComparisonOperator comparisonOperation, string formula1, string formula2)
		{
			global::NPOI.HSSF.Record.CFRuleRecord pRuleRecord = global::NPOI.HSSF.Record.CFRuleRecord.Create(this._sheet, (byte)comparisonOperation, formula1, formula2);
			return new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule(this._sheet, pRuleRecord);
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x0005CE68 File Offset: 0x0005B068
		public global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.SS.UserModel.ComparisonOperator comparisonOperation, string formula1)
		{
			global::NPOI.HSSF.Record.CFRuleRecord pRuleRecord = global::NPOI.HSSF.Record.CFRuleRecord.Create(this._sheet, (byte)comparisonOperation, formula1, null);
			return new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule(this._sheet, pRuleRecord);
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x0005CE90 File Offset: 0x0005B090
		public global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(string formula)
		{
			global::NPOI.HSSF.Record.CFRuleRecord pRuleRecord = global::NPOI.HSSF.Record.CFRuleRecord.Create(this._sheet, formula);
			return new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule(this._sheet, pRuleRecord);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0005CEB8 File Offset: 0x0005B0B8
		public global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.SS.UserModel.IconSet iconSet)
		{
			global::NPOI.HSSF.Record.CFRule12Record pRuleRecord = global::NPOI.HSSF.Record.CFRule12Record.Create(this._sheet, iconSet);
			return new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule(this._sheet, pRuleRecord);
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x0005CEE0 File Offset: 0x0005B0E0
		public global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.HSSF.UserModel.HSSFExtendedColor color)
		{
			global::NPOI.HSSF.Record.CFRule12Record pRuleRecord = global::NPOI.HSSF.Record.CFRule12Record.Create(this._sheet, color.ExtendedColor);
			return new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule(this._sheet, pRuleRecord);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x0005CF0B File Offset: 0x0005B10B
		public global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.SS.UserModel.ExtendedColor color)
		{
			return this.CreateConditionalFormattingRule((global::NPOI.HSSF.UserModel.HSSFExtendedColor)color);
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x0005CF1C File Offset: 0x0005B11C
		public global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingColorScaleRule()
		{
			global::NPOI.HSSF.Record.CFRule12Record pRuleRecord = global::NPOI.HSSF.Record.CFRule12Record.CreateColorScale(this._sheet);
			return new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule(this._sheet, pRuleRecord);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x0005CF44 File Offset: 0x0005B144
		public int AddConditionalFormatting(global::NPOI.HSSF.UserModel.HSSFConditionalFormatting cf)
		{
			global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate cfAggregate = cf.CFRecordsAggregate.CloneCFAggregate();
			return this._conditionalFormattingTable.Add(cfAggregate);
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0005CF69 File Offset: 0x0005B169
		public int AddConditionalFormatting(global::NPOI.SS.UserModel.IConditionalFormatting cf)
		{
			return this.AddConditionalFormatting((global::NPOI.HSSF.UserModel.HSSFConditionalFormatting)cf);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0005CF78 File Offset: 0x0005B178
		public int AddConditionalFormatting(global::NPOI.SS.Util.CellRangeAddress[] regions, global::NPOI.SS.UserModel.IConditionalFormattingRule[] cfRules)
		{
			if (regions == null)
			{
				throw new global::System.ArgumentException("regions must not be null");
			}
			if (cfRules == null)
			{
				throw new global::System.ArgumentException("cfRules must not be null");
			}
			if (cfRules.Length == 0)
			{
				throw new global::System.ArgumentException("cfRules must not be empty");
			}
			if (cfRules.Length > 3)
			{
				throw new global::System.ArgumentException("Number of rules must not exceed 3");
			}
			global::NPOI.HSSF.Record.CFRuleBase[] array = new global::NPOI.HSSF.Record.CFRuleBase[cfRules.Length];
			for (int num = 0; num != cfRules.Length; num++)
			{
				array[num] = ((global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule)cfRules[num]).CfRuleRecord;
			}
			global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate cfAggregate = new global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate(regions, array);
			return this._conditionalFormattingTable.Add(cfAggregate);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0005CFFC File Offset: 0x0005B1FC
		public int AddConditionalFormatting(global::NPOI.SS.Util.CellRangeAddress[] regions, global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule rule1)
		{
			global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule[] array;
			if (rule1 != null)
			{
				(array = new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule[1])[0] = rule1;
			}
			else
			{
				array = null;
			}
			global::NPOI.SS.UserModel.IConditionalFormattingRule[] cfRules = array;
			return this.AddConditionalFormatting(regions, cfRules);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0005D022 File Offset: 0x0005B222
		public int AddConditionalFormatting(global::NPOI.SS.Util.CellRangeAddress[] regions, global::NPOI.SS.UserModel.IConditionalFormattingRule rule1)
		{
			return this.AddConditionalFormatting(regions, (global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule)rule1);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0005D034 File Offset: 0x0005B234
		public int AddConditionalFormatting(global::NPOI.SS.Util.CellRangeAddress[] regions, global::NPOI.SS.UserModel.IConditionalFormattingRule rule1, global::NPOI.SS.UserModel.IConditionalFormattingRule rule2)
		{
			global::NPOI.SS.UserModel.IConditionalFormattingRule[] cfRules = new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule[]
			{
				(global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule)rule1,
				(global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule)rule2
			};
			return this.AddConditionalFormatting(regions, cfRules);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0005D064 File Offset: 0x0005B264
		public global::NPOI.SS.UserModel.IConditionalFormatting GetConditionalFormattingAt(int index)
		{
			global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate cfrecordsAggregate = this._conditionalFormattingTable.Get(index);
			if (cfrecordsAggregate == null)
			{
				return null;
			}
			return new global::NPOI.HSSF.UserModel.HSSFConditionalFormatting(this._sheet, cfrecordsAggregate);
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x0005D08F File Offset: 0x0005B28F
		public int NumConditionalFormattings
		{
			get
			{
				return this._conditionalFormattingTable.Count;
			}
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x0005D09C File Offset: 0x0005B29C
		public void RemoveConditionalFormatting(int index)
		{
			this._conditionalFormattingTable.Remove(index);
		}

		// Token: 0x04000BAA RID: 2986
		private global::NPOI.HSSF.UserModel.HSSFSheet _sheet;

		// Token: 0x04000BAB RID: 2987
		private global::NPOI.HSSF.Record.Aggregates.ConditionalFormattingTable _conditionalFormattingTable;
	}
}
