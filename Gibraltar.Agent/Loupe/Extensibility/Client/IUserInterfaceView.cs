using System;
using System.Drawing;

namespace Loupe.Extensibility.Client
{
	// Token: 0x020000A2 RID: 162
	internal interface IUserInterfaceView : global::System.IDisposable
	{
		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060006D7 RID: 1751
		// (remove) Token: 0x060006D8 RID: 1752
		event global::System.EventHandler TitleChanged;

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060006D9 RID: 1753
		string Title { get; }

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060006DA RID: 1754
		global::System.Drawing.Icon Icon { get; }
	}
}
