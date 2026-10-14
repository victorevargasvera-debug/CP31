using System;

namespace CefSharp
{
	// Token: 0x02000033 RID: 51
	[global::System.Flags]
	public enum ContextMenuType
	{
		// Token: 0x040001C0 RID: 448
		None = 0,
		// Token: 0x040001C1 RID: 449
		Page = 1,
		// Token: 0x040001C2 RID: 450
		Frame = 2,
		// Token: 0x040001C3 RID: 451
		Link = 4,
		// Token: 0x040001C4 RID: 452
		Media = 8,
		// Token: 0x040001C5 RID: 453
		Selection = 16,
		// Token: 0x040001C6 RID: 454
		Editable = 32
	}
}
