using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Microsoft.Practices.Prism.Regions.Behaviors
{
	// Token: 0x02000050 RID: 80
	public class AutoPopulateRegionBehavior : global::Microsoft.Practices.Prism.Regions.RegionBehavior
	{
		// Token: 0x06000257 RID: 599 RVA: 0x0000729F File Offset: 0x0000549F
		public AutoPopulateRegionBehavior(global::Microsoft.Practices.Prism.Regions.IRegionViewRegistry regionViewRegistry)
		{
			this.regionViewRegistry = regionViewRegistry;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000072AE File Offset: 0x000054AE
		protected override void OnAttach()
		{
			if (string.IsNullOrEmpty(base.Region.Name))
			{
				base.Region.PropertyChanged += this.Region_PropertyChanged;
				return;
			}
			this.StartPopulatingContent();
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000072E0 File Offset: 0x000054E0
		private void StartPopulatingContent()
		{
			foreach (object viewToAdd in this.CreateViewsToAutoPopulate())
			{
				this.AddViewIntoRegion(viewToAdd);
			}
			this.regionViewRegistry.ContentRegistered += this.OnViewRegistered;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00007348 File Offset: 0x00005548
		protected virtual global::System.Collections.Generic.IEnumerable<object> CreateViewsToAutoPopulate()
		{
			return this.regionViewRegistry.GetContents(base.Region.Name);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00007360 File Offset: 0x00005560
		protected virtual void AddViewIntoRegion(object viewToAdd)
		{
			base.Region.Add(viewToAdd);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00007370 File Offset: 0x00005570
		private void Region_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Name" && !string.IsNullOrEmpty(base.Region.Name))
			{
				base.Region.PropertyChanged -= this.Region_PropertyChanged;
				this.StartPopulatingContent();
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000073BE File Offset: 0x000055BE
		public virtual void OnViewRegistered(object sender, global::Microsoft.Practices.Prism.Regions.ViewRegisteredEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			if (e.RegionName == base.Region.Name)
			{
				this.AddViewIntoRegion(e.GetView());
			}
		}

		// Token: 0x04000088 RID: 136
		public const string BehaviorKey = "AutoPopulate";

		// Token: 0x04000089 RID: 137
		private readonly global::Microsoft.Practices.Prism.Regions.IRegionViewRegistry regionViewRegistry;
	}
}
