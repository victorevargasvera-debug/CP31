using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000064 RID: 100
	public interface IRegionNavigationJournal
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002D5 RID: 725
		bool CanGoBack { get; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002D6 RID: 726
		bool CanGoForward { get; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002D7 RID: 727
		global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry CurrentEntry { get; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002D8 RID: 728
		// (set) Token: 0x060002D9 RID: 729
		global::Microsoft.Practices.Prism.Regions.INavigateAsync NavigationTarget { get; set; }

		// Token: 0x060002DA RID: 730
		void GoBack();

		// Token: 0x060002DB RID: 731
		void GoForward();

		// Token: 0x060002DC RID: 732
		void RecordNavigation(global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry entry);

		// Token: 0x060002DD RID: 733
		void Clear();
	}
}
