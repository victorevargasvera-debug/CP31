using System;
using System.Windows.Forms;

namespace Loupe.Extensibility.Client
{
	// Token: 0x0200009B RID: 155
	internal interface IRepositorySummaryView : global::Loupe.Extensibility.Client.ISessionSummaryView, global::Loupe.Extensibility.Client.IUserInterfaceView, global::System.IDisposable
	{
		// Token: 0x060006B5 RID: 1717
		void Open(object state);

		// Token: 0x060006B6 RID: 1718
		void RefreshData();

		// Token: 0x060006B7 RID: 1719
		bool Close(global::System.Windows.Forms.CloseReason closeReason);
	}
}
