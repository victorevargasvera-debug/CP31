using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000036 RID: 54
	public interface IConditionalFormattingThreshold
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000209 RID: 521
		// (set) Token: 0x0600020A RID: 522
		global::NPOI.SS.UserModel.RangeType RangeType { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600020B RID: 523
		// (set) Token: 0x0600020C RID: 524
		string Formula { get; set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600020D RID: 525
		// (set) Token: 0x0600020E RID: 526
		double? Value { get; set; }
	}
}
