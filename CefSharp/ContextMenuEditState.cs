using System;

namespace CefSharp
{
	// Token: 0x02000030 RID: 48
	[global::System.Flags]
	public enum ContextMenuEditState
	{
		// Token: 0x0400019E RID: 414
		None = 0,
		// Token: 0x0400019F RID: 415
		CanUndo = 1,
		// Token: 0x040001A0 RID: 416
		CanRedo = 2,
		// Token: 0x040001A1 RID: 417
		CanCut = 4,
		// Token: 0x040001A2 RID: 418
		CanCopy = 8,
		// Token: 0x040001A3 RID: 419
		CanPaste = 16,
		// Token: 0x040001A4 RID: 420
		CanDelete = 32,
		// Token: 0x040001A5 RID: 421
		CanSelectAll = 64,
		// Token: 0x040001A6 RID: 422
		CanTranslate = 128,
		// Token: 0x040001A7 RID: 423
		CanEditRichly = 256
	}
}
