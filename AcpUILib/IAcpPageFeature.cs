using System;
using System.Windows;

namespace AcpUILib
{
	// Token: 0x02000003 RID: 3
	public interface IAcpPageFeature
	{
		// Token: 0x06000004 RID: 4
		void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e);

		// Token: 0x06000005 RID: 5
		void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e);

		// Token: 0x06000006 RID: 6
		void SetDataContext();

		// Token: 0x06000007 RID: 7
		void RefreshComparatorOdp();

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8
		// (set) Token: 0x06000009 RID: 9
		int PageFeatureId { get; set; }
	}
}
