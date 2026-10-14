using System;

namespace NPOI.WP.UserModel
{
	// Token: 0x0200000A RID: 10
	public interface IParagraph
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000046 RID: 70
		// (set) Token: 0x06000047 RID: 71
		int IndentFromRight { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000048 RID: 72
		// (set) Token: 0x06000049 RID: 73
		int IndentFromLeft { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004A RID: 74
		// (set) Token: 0x0600004B RID: 75
		int FirstLineIndent { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004C RID: 76
		// (set) Token: 0x0600004D RID: 77
		int FontAlignment { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004E RID: 78
		// (set) Token: 0x0600004F RID: 79
		bool IsWordWrapped { get; set; }
	}
}
