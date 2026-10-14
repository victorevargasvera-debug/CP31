using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000072 RID: 114
	public class XSSFConditionalFormatting : global::NPOI.SS.UserModel.IConditionalFormatting
	{
		// Token: 0x06000599 RID: 1433 RVA: 0x00015315 File Offset: 0x00013515
		internal XSSFConditionalFormatting(global::NPOI.XSSF.UserModel.XSSFSheet sh)
		{
			this._cf = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting();
			this._sh = sh;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0001532F File Offset: 0x0001352F
		internal XSSFConditionalFormatting(global::NPOI.XSSF.UserModel.XSSFSheet sh, global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting cf)
		{
			this._cf = cf;
			this._sh = sh;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00015345 File Offset: 0x00013545
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting GetCTConditionalFormatting()
		{
			return this._cf;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00015350 File Offset: 0x00013550
		public global::NPOI.SS.Util.CellRangeAddress[] GetFormattingRanges()
		{
			global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> list = new global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress>();
			string[] array = this._cf.sqref.Split(new char[]
			{
				' '
			});
			for (int i = 0; i < array.Length; i++)
			{
				list.Add(global::NPOI.SS.Util.CellRangeAddress.ValueOf(array[i]));
			}
			return list.ToArray();
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000153A4 File Offset: 0x000135A4
		public void SetRule(int idx, global::NPOI.SS.UserModel.IConditionalFormattingRule cfRule)
		{
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule xssfconditionalFormattingRule = (global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule)cfRule;
			this._cf.GetCfRuleArray(idx).Set(xssfconditionalFormattingRule.GetCTCfRule());
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000153D0 File Offset: 0x000135D0
		public void AddRule(global::NPOI.SS.UserModel.IConditionalFormattingRule cfRule)
		{
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule xssfconditionalFormattingRule = (global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule)cfRule;
			this._cf.AddNewCfRule().Set(xssfconditionalFormattingRule.GetCTCfRule());
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000153FA File Offset: 0x000135FA
		public global::NPOI.SS.UserModel.IConditionalFormattingRule GetRule(int idx)
		{
			return new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule(this._sh, this._cf.GetCfRuleArray(idx));
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00015413 File Offset: 0x00013613
		public int NumberOfRules
		{
			get
			{
				return this._cf.sizeOfCfRuleArray();
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00015420 File Offset: 0x00013620
		public override string ToString()
		{
			return this._cf.ToString();
		}

		// Token: 0x040002B4 RID: 692
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting _cf;

		// Token: 0x040002B5 RID: 693
		private global::NPOI.XSSF.UserModel.XSSFSheet _sh;
	}
}
