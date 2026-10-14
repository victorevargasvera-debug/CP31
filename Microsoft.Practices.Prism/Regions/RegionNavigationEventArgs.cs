using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000078 RID: 120
	public class RegionNavigationEventArgs : global::System.EventArgs
	{
		// Token: 0x0600034C RID: 844 RVA: 0x000096F3 File Offset: 0x000078F3
		public RegionNavigationEventArgs(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			if (navigationContext == null)
			{
				throw new global::System.ArgumentNullException("navigationContext");
			}
			this.NavigationContext = navigationContext;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00009710 File Offset: 0x00007910
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00009718 File Offset: 0x00007918
		public global::Microsoft.Practices.Prism.Regions.NavigationContext NavigationContext { get; private set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00009721 File Offset: 0x00007921
		public global::System.Uri Uri
		{
			get
			{
				if (this.NavigationContext != null)
				{
					return this.NavigationContext.Uri;
				}
				return null;
			}
		}
	}
}
