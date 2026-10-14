using System;
using System.Collections.Generic;
using System.ComponentModel;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility.Client
{
	// Token: 0x0200009F RID: 159
	internal interface ISessionSummaryView : global::Loupe.Extensibility.Client.IUserInterfaceView, global::System.IDisposable
	{
		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060006C2 RID: 1730
		// (remove) Token: 0x060006C3 RID: 1731
		event global::System.EventHandler SelectionChanged;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x060006C4 RID: 1732
		// (remove) Token: 0x060006C5 RID: 1733
		event global::System.EventHandler SelectView;

		// Token: 0x060006C6 RID: 1734
		void Initialize(global::Loupe.Extensibility.Client.IRepositoryContext context);

		// Token: 0x060006C7 RID: 1735
		void ConfigurationChanged();

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060006C8 RID: 1736
		// (set) Token: 0x060006C9 RID: 1737
		[global::System.ComponentModel.Browsable(false)]
		global::Loupe.Extensibility.Data.ISessionSummaryCollection SessionSummaries { get; set; }

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060006CA RID: 1738
		[global::System.ComponentModel.Browsable(false)]
		global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ISessionSummary> SelectedItems { get; }

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060006CB RID: 1739
		[global::System.ComponentModel.Browsable(false)]
		string SelectedItemsLabel { get; }

		// Token: 0x060006CC RID: 1740
		void ActivateView();

		// Token: 0x060006CD RID: 1741
		void DeactivateView();
	}
}
