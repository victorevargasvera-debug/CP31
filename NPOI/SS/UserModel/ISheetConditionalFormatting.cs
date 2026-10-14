using System;
using NPOI.SS.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200008A RID: 138
	public interface ISheetConditionalFormatting
	{
		// Token: 0x06000539 RID: 1337
		int AddConditionalFormatting(global::NPOI.SS.Util.CellRangeAddress[] regions, global::NPOI.SS.UserModel.IConditionalFormattingRule rule);

		// Token: 0x0600053A RID: 1338
		int AddConditionalFormatting(global::NPOI.SS.Util.CellRangeAddress[] regions, global::NPOI.SS.UserModel.IConditionalFormattingRule rule1, global::NPOI.SS.UserModel.IConditionalFormattingRule rule2);

		// Token: 0x0600053B RID: 1339
		int AddConditionalFormatting(global::NPOI.SS.Util.CellRangeAddress[] regions, global::NPOI.SS.UserModel.IConditionalFormattingRule[] cfRules);

		// Token: 0x0600053C RID: 1340
		int AddConditionalFormatting(global::NPOI.SS.UserModel.IConditionalFormatting cf);

		// Token: 0x0600053D RID: 1341
		global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.SS.UserModel.ComparisonOperator comparisonOperation, string formula1, string formula2);

		// Token: 0x0600053E RID: 1342
		global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.SS.UserModel.ComparisonOperator comparisonOperation, string formula);

		// Token: 0x0600053F RID: 1343
		global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(string formula);

		// Token: 0x06000540 RID: 1344
		global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.SS.UserModel.ExtendedColor color);

		// Token: 0x06000541 RID: 1345
		global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.SS.UserModel.IconSet iconSet);

		// Token: 0x06000542 RID: 1346
		global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingColorScaleRule();

		// Token: 0x06000543 RID: 1347
		global::NPOI.SS.UserModel.IConditionalFormatting GetConditionalFormattingAt(int index);

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000544 RID: 1348
		int NumConditionalFormattings { get; }

		// Token: 0x06000545 RID: 1349
		void RemoveConditionalFormatting(int index);
	}
}
