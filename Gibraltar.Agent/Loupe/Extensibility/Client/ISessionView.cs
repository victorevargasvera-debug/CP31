using System;
using System.Windows.Forms;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility.Client
{
	// Token: 0x020000A0 RID: 160
	internal interface ISessionView : global::Loupe.Extensibility.Client.IUserInterfaceView, global::System.IDisposable
	{
		// Token: 0x060006CE RID: 1742
		void Initialize(global::Loupe.Extensibility.Client.ISessionContext context);

		// Token: 0x060006CF RID: 1743
		void RefreshData();

		// Token: 0x060006D0 RID: 1744
		bool Close(global::System.Windows.Forms.CloseReason closeReason);

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060006D1 RID: 1745
		// (set) Token: 0x060006D2 RID: 1746
		global::Loupe.Extensibility.Data.ISession Session { get; set; }
	}
}
