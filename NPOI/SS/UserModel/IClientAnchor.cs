using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000052 RID: 82
	public interface IClientAnchor
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600031A RID: 794
		// (set) Token: 0x0600031B RID: 795
		int Col1 { get; set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600031C RID: 796
		// (set) Token: 0x0600031D RID: 797
		int Col2 { get; set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600031E RID: 798
		// (set) Token: 0x0600031F RID: 799
		int Row1 { get; set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000320 RID: 800
		// (set) Token: 0x06000321 RID: 801
		int Row2 { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000322 RID: 802
		// (set) Token: 0x06000323 RID: 803
		int Dx1 { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000324 RID: 804
		// (set) Token: 0x06000325 RID: 805
		int Dy1 { get; set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000326 RID: 806
		// (set) Token: 0x06000327 RID: 807
		int Dy2 { get; set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000328 RID: 808
		// (set) Token: 0x06000329 RID: 809
		int Dx2 { get; set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600032A RID: 810
		// (set) Token: 0x0600032B RID: 811
		global::NPOI.SS.UserModel.AnchorType AnchorType { get; set; }
	}
}
