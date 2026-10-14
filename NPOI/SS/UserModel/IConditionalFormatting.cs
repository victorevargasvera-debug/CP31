using System;
using NPOI.SS.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000056 RID: 86
	public interface IConditionalFormatting
	{
		// Token: 0x0600033A RID: 826
		global::NPOI.SS.Util.CellRangeAddress[] GetFormattingRanges();

		// Token: 0x0600033B RID: 827
		void SetRule(int idx, global::NPOI.SS.UserModel.IConditionalFormattingRule cfRule);

		// Token: 0x0600033C RID: 828
		void AddRule(global::NPOI.SS.UserModel.IConditionalFormattingRule cfRule);

		// Token: 0x0600033D RID: 829
		global::NPOI.SS.UserModel.IConditionalFormattingRule GetRule(int idx);

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600033E RID: 830
		int NumberOfRules { get; }
	}
}
