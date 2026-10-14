using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200003F RID: 63
	public interface IIconMultiStateFormatting
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000259 RID: 601
		// (set) Token: 0x0600025A RID: 602
		global::NPOI.SS.UserModel.IconSet IconSet { get; set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600025B RID: 603
		// (set) Token: 0x0600025C RID: 604
		bool IsIconOnly { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600025D RID: 605
		// (set) Token: 0x0600025E RID: 606
		bool IsReversed { get; set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600025F RID: 607
		// (set) Token: 0x06000260 RID: 608
		global::NPOI.SS.UserModel.IConditionalFormattingThreshold[] Thresholds { get; set; }

		// Token: 0x06000261 RID: 609
		global::NPOI.SS.UserModel.IConditionalFormattingThreshold CreateThreshold();
	}
}
