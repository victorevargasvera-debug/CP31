using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.CF;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000370 RID: 880
	public class HSSFConditionalFormattingRule : global::NPOI.SS.UserModel.IConditionalFormattingRule
	{
		// Token: 0x06001B8D RID: 7053 RVA: 0x00054654 File Offset: 0x00052854
		public HSSFConditionalFormattingRule(global::NPOI.HSSF.UserModel.HSSFSheet pSheet, global::NPOI.HSSF.Record.CFRuleBase pRuleRecord)
		{
			if (pSheet == null)
			{
				throw new global::System.ArgumentException("pSheet must not be null");
			}
			if (pRuleRecord == null)
			{
				throw new global::System.ArgumentException("pRuleRecord must not be null");
			}
			this.sheet = pSheet;
			this.workbook = (pSheet.Workbook as global::NPOI.HSSF.UserModel.HSSFWorkbook);
			this.cfRuleRecord = pRuleRecord;
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001B8E RID: 7054 RVA: 0x000546A2 File Offset: 0x000528A2
		public global::NPOI.HSSF.Record.CFRuleBase CfRuleRecord
		{
			get
			{
				return this.cfRuleRecord;
			}
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x000546AA File Offset: 0x000528AA
		private global::NPOI.HSSF.Record.CFRule12Record GetCFRule12Record(bool create)
		{
			if (this.cfRuleRecord is global::NPOI.HSSF.Record.CFRule12Record)
			{
				return (global::NPOI.HSSF.Record.CFRule12Record)this.cfRuleRecord;
			}
			if (create)
			{
				throw new global::System.ArgumentException("Can't convert a CF into a CF12 record");
			}
			return null;
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x000546D4 File Offset: 0x000528D4
		private global::NPOI.HSSF.UserModel.HSSFFontFormatting GetFontFormatting(bool Create)
		{
			global::NPOI.HSSF.Record.CF.FontFormatting fontFormatting = this.cfRuleRecord.FontFormatting;
			if (fontFormatting != null)
			{
				this.cfRuleRecord.FontFormatting = fontFormatting;
				return new global::NPOI.HSSF.UserModel.HSSFFontFormatting(this.cfRuleRecord, this.workbook);
			}
			if (Create)
			{
				fontFormatting = new global::NPOI.HSSF.Record.CF.FontFormatting();
				this.cfRuleRecord.FontFormatting = fontFormatting;
				return new global::NPOI.HSSF.UserModel.HSSFFontFormatting(this.cfRuleRecord, this.workbook);
			}
			return null;
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x00054736 File Offset: 0x00052936
		public global::NPOI.SS.UserModel.IFontFormatting FontFormatting
		{
			get
			{
				return this.GetFontFormatting(false);
			}
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0005473F File Offset: 0x0005293F
		public global::NPOI.SS.UserModel.IFontFormatting CreateFontFormatting()
		{
			return this.GetFontFormatting(true);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x00054748 File Offset: 0x00052948
		private global::NPOI.HSSF.UserModel.HSSFBorderFormatting GetBorderFormatting(bool Create)
		{
			global::NPOI.HSSF.Record.CF.BorderFormatting borderFormatting = this.cfRuleRecord.BorderFormatting;
			if (borderFormatting != null)
			{
				this.cfRuleRecord.BorderFormatting = borderFormatting;
				return new global::NPOI.HSSF.UserModel.HSSFBorderFormatting(this.cfRuleRecord, this.workbook);
			}
			if (Create)
			{
				borderFormatting = new global::NPOI.HSSF.Record.CF.BorderFormatting();
				this.cfRuleRecord.BorderFormatting = borderFormatting;
				return new global::NPOI.HSSF.UserModel.HSSFBorderFormatting(this.cfRuleRecord, this.workbook);
			}
			return null;
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x000547AA File Offset: 0x000529AA
		public global::NPOI.SS.UserModel.IBorderFormatting BorderFormatting
		{
			get
			{
				return this.GetBorderFormatting(false);
			}
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x000547B3 File Offset: 0x000529B3
		public global::NPOI.SS.UserModel.IBorderFormatting CreateBorderFormatting()
		{
			return this.GetBorderFormatting(true);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x000547BC File Offset: 0x000529BC
		private global::NPOI.HSSF.UserModel.HSSFPatternFormatting GetPatternFormatting(bool Create)
		{
			global::NPOI.HSSF.Record.CF.PatternFormatting patternFormatting = this.cfRuleRecord.PatternFormatting;
			if (patternFormatting != null)
			{
				this.cfRuleRecord.PatternFormatting = patternFormatting;
				return new global::NPOI.HSSF.UserModel.HSSFPatternFormatting(this.cfRuleRecord, this.workbook);
			}
			if (Create)
			{
				patternFormatting = new global::NPOI.HSSF.Record.CF.PatternFormatting();
				this.cfRuleRecord.PatternFormatting = patternFormatting;
				return new global::NPOI.HSSF.UserModel.HSSFPatternFormatting(this.cfRuleRecord, this.workbook);
			}
			return null;
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x0005481E File Offset: 0x00052A1E
		public global::NPOI.SS.UserModel.IPatternFormatting PatternFormatting
		{
			get
			{
				return this.GetPatternFormatting(false);
			}
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00054827 File Offset: 0x00052A27
		public global::NPOI.SS.UserModel.IPatternFormatting CreatePatternFormatting()
		{
			return this.GetPatternFormatting(true);
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x00054830 File Offset: 0x00052A30
		private global::NPOI.HSSF.UserModel.HSSFDataBarFormatting GetDataBarFormatting(bool create)
		{
			global::NPOI.HSSF.Record.CFRule12Record cfrule12Record = this.GetCFRule12Record(create);
			if (cfrule12Record.DataBarFormatting != null)
			{
				return new global::NPOI.HSSF.UserModel.HSSFDataBarFormatting(cfrule12Record, this.sheet);
			}
			if (create)
			{
				cfrule12Record.CreateDataBarFormatting();
				return new global::NPOI.HSSF.UserModel.HSSFDataBarFormatting(cfrule12Record, this.sheet);
			}
			return null;
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x00054872 File Offset: 0x00052A72
		public global::NPOI.SS.UserModel.IDataBarFormatting DataBarFormatting
		{
			get
			{
				return this.GetDataBarFormatting(false);
			}
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0005487B File Offset: 0x00052A7B
		public global::NPOI.HSSF.UserModel.HSSFDataBarFormatting CreateDataBarFormatting()
		{
			return this.GetDataBarFormatting(true);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x00054884 File Offset: 0x00052A84
		private global::NPOI.HSSF.UserModel.HSSFIconMultiStateFormatting GetMultiStateFormatting(bool create)
		{
			global::NPOI.HSSF.Record.CFRule12Record cfrule12Record = this.GetCFRule12Record(create);
			if (cfrule12Record.MultiStateFormatting != null)
			{
				return new global::NPOI.HSSF.UserModel.HSSFIconMultiStateFormatting(cfrule12Record, this.sheet);
			}
			if (create)
			{
				cfrule12Record.CreateMultiStateFormatting();
				return new global::NPOI.HSSF.UserModel.HSSFIconMultiStateFormatting(cfrule12Record, this.sheet);
			}
			return null;
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x000548C6 File Offset: 0x00052AC6
		public global::NPOI.SS.UserModel.IIconMultiStateFormatting MultiStateFormatting
		{
			get
			{
				return this.GetMultiStateFormatting(false);
			}
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x000548CF File Offset: 0x00052ACF
		public global::NPOI.HSSF.UserModel.HSSFIconMultiStateFormatting CreateMultiStateFormatting()
		{
			return this.GetMultiStateFormatting(true);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x000548D8 File Offset: 0x00052AD8
		private global::NPOI.HSSF.UserModel.HSSFColorScaleFormatting GetColorScaleFormatting(bool create)
		{
			global::NPOI.HSSF.Record.CFRule12Record cfrule12Record = this.GetCFRule12Record(create);
			if (cfrule12Record.ColorGradientFormatting != null)
			{
				return new global::NPOI.HSSF.UserModel.HSSFColorScaleFormatting(cfrule12Record, this.sheet);
			}
			if (create)
			{
				cfrule12Record.CreateColorGradientFormatting();
				return new global::NPOI.HSSF.UserModel.HSSFColorScaleFormatting(cfrule12Record, this.sheet);
			}
			return null;
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0005491A File Offset: 0x00052B1A
		public global::NPOI.SS.UserModel.IColorScaleFormatting ColorScaleFormatting
		{
			get
			{
				return this.GetColorScaleFormatting(false);
			}
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x00054923 File Offset: 0x00052B23
		public global::NPOI.HSSF.UserModel.HSSFColorScaleFormatting CreateColorScaleFormatting()
		{
			return this.GetColorScaleFormatting(true);
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x0005492C File Offset: 0x00052B2C
		public global::NPOI.SS.UserModel.ConditionType ConditionType
		{
			get
			{
				return global::NPOI.SS.UserModel.ConditionType.ForId(this.cfRuleRecord.ConditionType);
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x0005493E File Offset: 0x00052B3E
		public global::NPOI.SS.UserModel.ComparisonOperator ComparisonOperation
		{
			get
			{
				return (global::NPOI.SS.UserModel.ComparisonOperator)this.cfRuleRecord.ComparisonOperation;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x0005494B File Offset: 0x00052B4B
		public string Formula1
		{
			get
			{
				return this.ToFormulaString(this.cfRuleRecord.ParsedExpression1);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x00054960 File Offset: 0x00052B60
		public string Formula2
		{
			get
			{
				if (this.cfRuleRecord.ConditionType == 1)
				{
					byte comparisonOperation = this.cfRuleRecord.ComparisonOperation;
					if (comparisonOperation - 1 <= 1)
					{
						return this.ToFormulaString(this.cfRuleRecord.ParsedExpression2);
					}
				}
				return null;
			}
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x000549A0 File Offset: 0x00052BA0
		protected internal string ToFormulaString(global::NPOI.SS.Formula.PTG.Ptg[] ParsedExpression)
		{
			if (ParsedExpression == null)
			{
				return null;
			}
			return global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule.ToFormulaString(ParsedExpression, this.workbook);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x000549B3 File Offset: 0x00052BB3
		protected internal static string ToFormulaString(global::NPOI.SS.Formula.PTG.Ptg[] parsedExpression, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			if (parsedExpression == null || parsedExpression.Length == 0)
			{
				return null;
			}
			return global::NPOI.HSSF.Model.HSSFFormulaParser.ToFormulaString(workbook, parsedExpression);
		}

		// Token: 0x04000B3F RID: 2879
		private const byte CELL_COMPARISON = 1;

		// Token: 0x04000B40 RID: 2880
		private global::NPOI.HSSF.Record.CFRuleBase cfRuleRecord;

		// Token: 0x04000B41 RID: 2881
		private global::NPOI.HSSF.UserModel.HSSFWorkbook workbook;

		// Token: 0x04000B42 RID: 2882
		private global::NPOI.HSSF.UserModel.HSSFSheet sheet;
	}
}
