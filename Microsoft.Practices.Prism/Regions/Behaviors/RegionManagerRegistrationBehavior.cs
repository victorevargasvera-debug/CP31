using System;
using System.ComponentModel;
using System.Windows;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Regions.Behaviors
{
	// Token: 0x02000058 RID: 88
	public class RegionManagerRegistrationBehavior : global::Microsoft.Practices.Prism.Regions.RegionBehavior, global::Microsoft.Practices.Prism.Regions.Behaviors.IHostAwareRegionBehavior, global::Microsoft.Practices.Prism.Regions.IRegionBehavior
	{
		// Token: 0x06000296 RID: 662 RVA: 0x00007DF0 File Offset: 0x00005FF0
		public RegionManagerRegistrationBehavior()
		{
			this.RegionManagerAccessor = new global::Microsoft.Practices.Prism.Regions.DefaultRegionManagerAccessor();
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00007E03 File Offset: 0x00006003
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00007E0B File Offset: 0x0000600B
		public global::Microsoft.Practices.Prism.Regions.IRegionManagerAccessor RegionManagerAccessor { get; set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00007E14 File Offset: 0x00006014
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00007E1C File Offset: 0x0000601C
		public global::System.Windows.DependencyObject HostControl
		{
			get
			{
				return this.hostControl;
			}
			set
			{
				if (base.IsAttached)
				{
					throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.Properties.Resources.HostControlCannotBeSetAfterAttach);
				}
				this.hostControl = value;
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00007E38 File Offset: 0x00006038
		protected override void OnAttach()
		{
			if (string.IsNullOrEmpty(base.Region.Name))
			{
				base.Region.PropertyChanged += this.Region_PropertyChanged;
				return;
			}
			this.StartMonitoringRegionManager();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00007E6C File Offset: 0x0000606C
		private void Region_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Name" && !string.IsNullOrEmpty(base.Region.Name))
			{
				base.Region.PropertyChanged -= this.Region_PropertyChanged;
				this.StartMonitoringRegionManager();
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00007EBA File Offset: 0x000060BA
		private void StartMonitoringRegionManager()
		{
			this.RegionManagerAccessor.UpdatingRegions += this.OnUpdatingRegions;
			this.TryRegisterRegion();
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00007EDC File Offset: 0x000060DC
		private void TryRegisterRegion()
		{
			global::System.Windows.DependencyObject dependencyObject = this.HostControl;
			if (dependencyObject.CheckAccess())
			{
				global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager = this.FindRegionManager(dependencyObject);
				global::Microsoft.Practices.Prism.Regions.IRegionManager attachedRegionManager = this.GetAttachedRegionManager();
				if (regionManager != attachedRegionManager)
				{
					if (attachedRegionManager != null)
					{
						this.attachedRegionManagerWeakReference = null;
						attachedRegionManager.Regions.Remove(base.Region.Name);
					}
					if (regionManager != null)
					{
						this.attachedRegionManagerWeakReference = new global::System.WeakReference(regionManager);
						regionManager.Regions.Add(base.Region);
					}
				}
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00007F4C File Offset: 0x0000614C
		public void OnUpdatingRegions(object sender, global::System.EventArgs e)
		{
			this.TryRegisterRegion();
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00007F54 File Offset: 0x00006154
		private global::Microsoft.Practices.Prism.Regions.IRegionManager FindRegionManager(global::System.Windows.DependencyObject dependencyObject)
		{
			global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager = this.RegionManagerAccessor.GetRegionManager(dependencyObject);
			if (regionManager != null)
			{
				return regionManager;
			}
			global::System.Windows.DependencyObject parent = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
			if (parent != null)
			{
				return this.FindRegionManager(parent);
			}
			return null;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00007F88 File Offset: 0x00006188
		private global::Microsoft.Practices.Prism.Regions.IRegionManager GetAttachedRegionManager()
		{
			if (this.attachedRegionManagerWeakReference != null)
			{
				return this.attachedRegionManagerWeakReference.Target as global::Microsoft.Practices.Prism.Regions.IRegionManager;
			}
			return null;
		}

		// Token: 0x04000098 RID: 152
		public static readonly string BehaviorKey = "RegionManagerRegistration";

		// Token: 0x04000099 RID: 153
		private global::System.WeakReference attachedRegionManagerWeakReference;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.DependencyObject hostControl;
	}
}
