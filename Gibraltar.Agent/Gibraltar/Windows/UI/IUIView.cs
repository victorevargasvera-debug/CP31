using System;
using System.Windows.Forms;

namespace Gibraltar.Windows.UI
{
	// Token: 0x020000C9 RID: 201
	internal interface IUIView
	{
		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000873 RID: 2163
		// (remove) Token: 0x06000874 RID: 2164
		event global::System.EventHandler ViewClosed;

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000875 RID: 2165
		// (remove) Token: 0x06000876 RID: 2166
		event global::System.Windows.Forms.FormClosingEventHandler ViewClosing;

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000877 RID: 2167
		string Text { get; }

		// Token: 0x06000878 RID: 2168
		void RefreshData();

		// Token: 0x06000879 RID: 2169
		bool Close(global::System.Windows.Forms.CloseReason closeReason);
	}
}
