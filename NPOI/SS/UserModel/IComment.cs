using System;
using NPOI.SS.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000054 RID: 84
	public interface IComment
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600032C RID: 812
		// (set) Token: 0x0600032D RID: 813
		bool Visible { get; set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600032E RID: 814
		// (set) Token: 0x0600032F RID: 815
		global::NPOI.SS.Util.CellAddress Address { get; set; }

		// Token: 0x06000330 RID: 816
		void SetAddress(int row, int col);

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000331 RID: 817
		// (set) Token: 0x06000332 RID: 818
		int Row { get; set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000333 RID: 819
		// (set) Token: 0x06000334 RID: 820
		int Column { get; set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000335 RID: 821
		// (set) Token: 0x06000336 RID: 822
		string Author { get; set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000337 RID: 823
		// (set) Token: 0x06000338 RID: 824
		global::NPOI.SS.UserModel.IRichTextString String { get; set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000339 RID: 825
		global::NPOI.SS.UserModel.IClientAnchor ClientAnchor { get; }
	}
}
