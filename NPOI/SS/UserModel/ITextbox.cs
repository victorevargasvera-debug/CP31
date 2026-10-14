using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200008B RID: 139
	public interface ITextbox : global::NPOI.SS.UserModel.IShape
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000546 RID: 1350
		// (set) Token: 0x06000547 RID: 1351
		global::NPOI.SS.UserModel.IRichTextString String { get; set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000548 RID: 1352
		// (set) Token: 0x06000549 RID: 1353
		int MarginLeft { get; set; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600054A RID: 1354
		// (set) Token: 0x0600054B RID: 1355
		int MarginRight { get; set; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600054C RID: 1356
		// (set) Token: 0x0600054D RID: 1357
		int MarginTop { get; set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600054E RID: 1358
		// (set) Token: 0x0600054F RID: 1359
		int MarginBottom { get; set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000550 RID: 1360
		// (set) Token: 0x06000551 RID: 1361
		short HorizontalAlignment { get; set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000552 RID: 1362
		// (set) Token: 0x06000553 RID: 1363
		short VerticalAlignment { get; set; }
	}
}
