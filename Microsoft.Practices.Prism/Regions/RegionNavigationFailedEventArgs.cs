using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000079 RID: 121
	public class RegionNavigationFailedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000350 RID: 848 RVA: 0x00009738 File Offset: 0x00007938
		public RegionNavigationFailedEventArgs(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			if (navigationContext == null)
			{
				throw new global::System.ArgumentNullException("navigationContext");
			}
			this.NavigationContext = navigationContext;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00009755 File Offset: 0x00007955
		public RegionNavigationFailedEventArgs(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext, global::System.Exception error) : this(navigationContext)
		{
			this.Error = error;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00009765 File Offset: 0x00007965
		// (set) Token: 0x06000353 RID: 851 RVA: 0x0000976D File Offset: 0x0000796D
		public global::Microsoft.Practices.Prism.Regions.NavigationContext NavigationContext { get; private set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00009776 File Offset: 0x00007976
		// (set) Token: 0x06000355 RID: 853 RVA: 0x0000977E File Offset: 0x0000797E
		public global::System.Exception Error { get; private set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00009787 File Offset: 0x00007987
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
