using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000075 RID: 117
	public interface IHyperlink
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000417 RID: 1047
		// (set) Token: 0x06000418 RID: 1048
		string Address { get; set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000419 RID: 1049
		// (set) Token: 0x0600041A RID: 1050
		string Label { get; set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600041B RID: 1051
		global::NPOI.SS.UserModel.HyperlinkType Type { get; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600041C RID: 1052
		// (set) Token: 0x0600041D RID: 1053
		int FirstRow { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600041E RID: 1054
		// (set) Token: 0x0600041F RID: 1055
		int LastRow { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000420 RID: 1056
		// (set) Token: 0x06000421 RID: 1057
		int FirstColumn { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000422 RID: 1058
		// (set) Token: 0x06000423 RID: 1059
		int LastColumn { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000424 RID: 1060
		// (set) Token: 0x06000425 RID: 1061
		string TextMark { get; set; }
	}
}
