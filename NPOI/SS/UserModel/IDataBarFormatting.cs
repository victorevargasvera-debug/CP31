using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000039 RID: 57
	public interface IDataBarFormatting
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000222 RID: 546
		// (set) Token: 0x06000223 RID: 547
		bool IsLeftToRight { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000224 RID: 548
		// (set) Token: 0x06000225 RID: 549
		bool IsIconOnly { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000226 RID: 550
		// (set) Token: 0x06000227 RID: 551
		int WidthMin { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000228 RID: 552
		// (set) Token: 0x06000229 RID: 553
		int WidthMax { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600022A RID: 554
		// (set) Token: 0x0600022B RID: 555
		global::NPOI.SS.UserModel.IColor Color { get; set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600022C RID: 556
		global::NPOI.SS.UserModel.IConditionalFormattingThreshold MinThreshold { get; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600022D RID: 557
		global::NPOI.SS.UserModel.IConditionalFormattingThreshold MaxThreshold { get; }
	}
}
