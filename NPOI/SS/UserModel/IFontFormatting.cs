using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200006B RID: 107
	public interface IFontFormatting
	{
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003E6 RID: 998
		// (set) Token: 0x060003E7 RID: 999
		global::NPOI.SS.UserModel.FontSuperScript EscapementType { get; set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003E8 RID: 1000
		// (set) Token: 0x060003E9 RID: 1001
		short FontColorIndex { get; set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003EA RID: 1002
		// (set) Token: 0x060003EB RID: 1003
		global::NPOI.SS.UserModel.IColor FontColor { get; set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003EC RID: 1004
		// (set) Token: 0x060003ED RID: 1005
		int FontHeight { get; set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003EE RID: 1006
		// (set) Token: 0x060003EF RID: 1007
		global::NPOI.SS.UserModel.FontUnderlineType UnderlineType { get; set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003F0 RID: 1008
		bool IsBold { get; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003F1 RID: 1009
		bool IsItalic { get; }

		// Token: 0x060003F2 RID: 1010
		void SetFontStyle(bool italic, bool bold);

		// Token: 0x060003F3 RID: 1011
		void ResetFontStyle();
	}
}
