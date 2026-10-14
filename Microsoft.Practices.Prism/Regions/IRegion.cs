using System;
using System.ComponentModel;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200004B RID: 75
	public interface IRegion : global::Microsoft.Practices.Prism.Regions.INavigateAsync, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000215 RID: 533
		global::Microsoft.Practices.Prism.Regions.IViewsCollection Views { get; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000216 RID: 534
		global::Microsoft.Practices.Prism.Regions.IViewsCollection ActiveViews { get; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000217 RID: 535
		// (set) Token: 0x06000218 RID: 536
		object Context { get; set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000219 RID: 537
		// (set) Token: 0x0600021A RID: 538
		string Name { get; set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600021B RID: 539
		// (set) Token: 0x0600021C RID: 540
		global::System.Comparison<object> SortComparison { get; set; }

		// Token: 0x0600021D RID: 541
		global::Microsoft.Practices.Prism.Regions.IRegionManager Add(object view);

		// Token: 0x0600021E RID: 542
		global::Microsoft.Practices.Prism.Regions.IRegionManager Add(object view, string viewName);

		// Token: 0x0600021F RID: 543
		global::Microsoft.Practices.Prism.Regions.IRegionManager Add(object view, string viewName, bool createRegionManagerScope);

		// Token: 0x06000220 RID: 544
		void Remove(object view);

		// Token: 0x06000221 RID: 545
		void Activate(object view);

		// Token: 0x06000222 RID: 546
		void Deactivate(object view);

		// Token: 0x06000223 RID: 547
		object GetView(string viewName);

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000224 RID: 548
		// (set) Token: 0x06000225 RID: 549
		global::Microsoft.Practices.Prism.Regions.IRegionManager RegionManager { get; set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000226 RID: 550
		global::Microsoft.Practices.Prism.Regions.IRegionBehaviorCollection Behaviors { get; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000227 RID: 551
		// (set) Token: 0x06000228 RID: 552
		global::Microsoft.Practices.Prism.Regions.IRegionNavigationService NavigationService { get; set; }
	}
}
