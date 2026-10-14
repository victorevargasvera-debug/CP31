using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200006D RID: 109
	public class NavigationContext
	{
		// Token: 0x06000306 RID: 774 RVA: 0x00008DBB File Offset: 0x00006FBB
		public NavigationContext(global::Microsoft.Practices.Prism.Regions.IRegionNavigationService navigationService, global::System.Uri uri)
		{
			this.NavigationService = navigationService;
			this.Uri = uri;
			this.Parameters = ((uri != null) ? global::Microsoft.Practices.Prism.UriParsingHelper.ParseQuery(uri) : null);
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00008DE9 File Offset: 0x00006FE9
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00008DF1 File Offset: 0x00006FF1
		public global::Microsoft.Practices.Prism.Regions.IRegionNavigationService NavigationService { get; private set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00008DFA File Offset: 0x00006FFA
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00008E02 File Offset: 0x00007002
		public global::System.Uri Uri { get; private set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00008E0B File Offset: 0x0000700B
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00008E13 File Offset: 0x00007013
		public global::Microsoft.Practices.Prism.UriQuery Parameters { get; private set; }
	}
}
