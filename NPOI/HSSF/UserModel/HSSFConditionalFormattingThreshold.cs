using System;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.CF;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000354 RID: 852
	public class HSSFConditionalFormattingThreshold : global::NPOI.SS.UserModel.IConditionalFormattingThreshold
	{
		// Token: 0x0600194B RID: 6475 RVA: 0x0004DB8E File Offset: 0x0004BD8E
		protected internal HSSFConditionalFormattingThreshold(global::NPOI.HSSF.Record.CF.Threshold threshold, global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			this.threshold = threshold;
			this.sheet = sheet;
			this.workbook = (sheet.Workbook as global::NPOI.HSSF.UserModel.HSSFWorkbook);
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x0004DBB5 File Offset: 0x0004BDB5
		protected internal global::NPOI.HSSF.Record.CF.Threshold Threshold
		{
			get
			{
				return this.threshold;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x0004DBBD File Offset: 0x0004BDBD
		// (set) Token: 0x0600194E RID: 6478 RVA: 0x0004DBCF File Offset: 0x0004BDCF
		public global::NPOI.SS.UserModel.RangeType RangeType
		{
			get
			{
				return global::NPOI.SS.UserModel.RangeType.ById((int)this.threshold.Type);
			}
			set
			{
				this.threshold.Type = (byte)value.id;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x0004DBE3 File Offset: 0x0004BDE3
		// (set) Token: 0x06001950 RID: 6480 RVA: 0x0004DBFB File Offset: 0x0004BDFB
		public string Formula
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HSSFConditionalFormattingRule.ToFormulaString(this.threshold.ParsedExpression, this.workbook);
			}
			set
			{
				this.threshold.ParsedExpression = global::NPOI.HSSF.Record.CFRuleBase.ParseFormula(value, this.sheet);
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x0004DC14 File Offset: 0x0004BE14
		// (set) Token: 0x06001952 RID: 6482 RVA: 0x0004DC21 File Offset: 0x0004BE21
		public double? Value
		{
			get
			{
				return this.threshold.Value;
			}
			set
			{
				this.threshold.Value = value;
			}
		}

		// Token: 0x04000A15 RID: 2581
		private global::NPOI.HSSF.Record.CF.Threshold threshold;

		// Token: 0x04000A16 RID: 2582
		private global::NPOI.HSSF.UserModel.HSSFSheet sheet;

		// Token: 0x04000A17 RID: 2583
		private global::NPOI.HSSF.UserModel.HSSFWorkbook workbook;
	}
}
