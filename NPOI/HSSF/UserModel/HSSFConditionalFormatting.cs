using System;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.Aggregates;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200036F RID: 879
	public class HSSFConditionalFormatting : global::NPOI.SS.UserModel.IConditionalFormatting
	{
		// Token: 0x06001B83 RID: 7043 RVA: 0x00054584 File Offset: 0x00052784
		public HSSFConditionalFormatting(global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate cfAggregate)
		{
			if (sheet == null)
			{
				throw new global::System.ArgumentException("workbook must not be null");
			}
			if (cfAggregate == null)
			{
				throw new global::System.ArgumentException("cfAggregate must not be null");
			}
			this.sheet = sheet;
			this.cfAggregate = cfAggregate;
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x000545B6 File Offset: 0x000527B6
		public global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate CFRecordsAggregate
		{
			get
			{
				return this.cfAggregate;
			}
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x000545BE File Offset: 0x000527BE
		public global::NPOI.SS.Util.CellRangeAddress[] GetFormattingRanges()
		{
			return this.cfAggregate.Header.CellRanges;
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x000545D0 File Offset: 0x000527D0
		public void SetRule(int idx, global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule cfRule)
		{
			this.cfAggregate.SetRule(idx, cfRule.CfRuleRecord);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x000545E4 File Offset: 0x000527E4
		public void SetRule(int idx, global::NPOI.SS.UserModel.IConditionalFormattingRule cfRule)
		{
			this.SetRule(idx, (global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule)cfRule);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x000545F3 File Offset: 0x000527F3
		public void AddRule(global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule cfRule)
		{
			this.cfAggregate.AddRule(cfRule.CfRuleRecord);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00054606 File Offset: 0x00052806
		public void AddRule(global::NPOI.SS.UserModel.IConditionalFormattingRule cfRule)
		{
			this.AddRule((global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule)cfRule);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00054614 File Offset: 0x00052814
		public global::NPOI.SS.UserModel.IConditionalFormattingRule GetRule(int idx)
		{
			global::NPOI.HSSF.Record.CFRuleBase rule = this.cfAggregate.GetRule(idx);
			return new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule(this.sheet, rule);
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x0005463A File Offset: 0x0005283A
		public int NumberOfRules
		{
			get
			{
				return this.cfAggregate.NumberOfRules;
			}
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00054647 File Offset: 0x00052847
		public override string ToString()
		{
			return this.cfAggregate.ToString();
		}

		// Token: 0x04000B3D RID: 2877
		private global::NPOI.HSSF.UserModel.HSSFSheet sheet;

		// Token: 0x04000B3E RID: 2878
		private global::NPOI.HSSF.Record.Aggregates.CFRecordsAggregate cfAggregate;
	}
}
