using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000047 RID: 71
	public interface IBorderFormatting
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600027B RID: 635
		// (set) Token: 0x0600027C RID: 636
		global::NPOI.SS.UserModel.BorderStyle BorderBottom { get; set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600027D RID: 637
		// (set) Token: 0x0600027E RID: 638
		global::NPOI.SS.UserModel.BorderStyle BorderDiagonal { get; set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600027F RID: 639
		// (set) Token: 0x06000280 RID: 640
		global::NPOI.SS.UserModel.BorderStyle BorderLeft { get; set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000281 RID: 641
		// (set) Token: 0x06000282 RID: 642
		global::NPOI.SS.UserModel.BorderStyle BorderRight { get; set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000283 RID: 643
		// (set) Token: 0x06000284 RID: 644
		global::NPOI.SS.UserModel.BorderStyle BorderTop { get; set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000285 RID: 645
		// (set) Token: 0x06000286 RID: 646
		short BottomBorderColor { get; set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000287 RID: 647
		// (set) Token: 0x06000288 RID: 648
		short DiagonalBorderColor { get; set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000289 RID: 649
		// (set) Token: 0x0600028A RID: 650
		short LeftBorderColor { get; set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600028B RID: 651
		// (set) Token: 0x0600028C RID: 652
		short RightBorderColor { get; set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600028D RID: 653
		// (set) Token: 0x0600028E RID: 654
		short TopBorderColor { get; set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600028F RID: 655
		// (set) Token: 0x06000290 RID: 656
		global::NPOI.SS.UserModel.IColor BottomBorderColorColor { get; set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000291 RID: 657
		// (set) Token: 0x06000292 RID: 658
		global::NPOI.SS.UserModel.IColor DiagonalBorderColorColor { get; set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000293 RID: 659
		// (set) Token: 0x06000294 RID: 660
		global::NPOI.SS.UserModel.IColor LeftBorderColorColor { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000295 RID: 661
		// (set) Token: 0x06000296 RID: 662
		global::NPOI.SS.UserModel.IColor RightBorderColorColor { get; set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000297 RID: 663
		// (set) Token: 0x06000298 RID: 664
		global::NPOI.SS.UserModel.IColor TopBorderColorColor { get; set; }
	}
}
