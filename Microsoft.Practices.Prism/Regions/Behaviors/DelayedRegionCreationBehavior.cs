using System;
using System.Globalization;
using System.Windows;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Regions.Behaviors
{
	// Token: 0x02000053 RID: 83
	public class DelayedRegionCreationBehavior
	{
		// Token: 0x0600026F RID: 623 RVA: 0x000077B0 File Offset: 0x000059B0
		public DelayedRegionCreationBehavior(global::Microsoft.Practices.Prism.Regions.RegionAdapterMappings regionAdapterMappings)
		{
			this.regionAdapterMappings = regionAdapterMappings;
			this.RegionManagerAccessor = new global::Microsoft.Practices.Prism.Regions.DefaultRegionManagerAccessor();
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000270 RID: 624 RVA: 0x000077CA File Offset: 0x000059CA
		// (set) Token: 0x06000271 RID: 625 RVA: 0x000077D2 File Offset: 0x000059D2
		public global::Microsoft.Practices.Prism.Regions.IRegionManagerAccessor RegionManagerAccessor { get; set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000272 RID: 626 RVA: 0x000077DB File Offset: 0x000059DB
		// (set) Token: 0x06000273 RID: 627 RVA: 0x000077F7 File Offset: 0x000059F7
		public global::System.Windows.DependencyObject TargetElement
		{
			get
			{
				if (this.elementWeakReference == null)
				{
					return null;
				}
				return this.elementWeakReference.Target as global::System.Windows.DependencyObject;
			}
			set
			{
				this.elementWeakReference = new global::System.WeakReference(value);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00007805 File Offset: 0x00005A05
		public void Attach()
		{
			this.RegionManagerAccessor.UpdatingRegions += this.OnUpdatingRegions;
			this.WireUpTargetElement();
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00007824 File Offset: 0x00005A24
		public void Detach()
		{
			this.RegionManagerAccessor.UpdatingRegions -= this.OnUpdatingRegions;
			this.UnWireTargetElement();
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00007843 File Offset: 0x00005A43
		public void OnUpdatingRegions(object sender, global::System.EventArgs e)
		{
			this.TryCreateRegion();
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000784C File Offset: 0x00005A4C
		private void TryCreateRegion()
		{
			global::System.Windows.DependencyObject targetElement = this.TargetElement;
			if (targetElement == null)
			{
				this.Detach();
				return;
			}
			if (targetElement.CheckAccess())
			{
				this.Detach();
				if (!this.regionCreated)
				{
					string regionName = this.RegionManagerAccessor.GetRegionName(targetElement);
					this.CreateRegion(targetElement, regionName);
					this.regionCreated = true;
				}
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000078A0 File Offset: 0x00005AA0
		protected virtual global::Microsoft.Practices.Prism.Regions.IRegion CreateRegion(global::System.Windows.DependencyObject targetElement, string regionName)
		{
			if (targetElement == null)
			{
				throw new global::System.ArgumentNullException("targetElement");
			}
			global::Microsoft.Practices.Prism.Regions.IRegion result;
			try
			{
				global::Microsoft.Practices.Prism.Regions.IRegionAdapter mapping = this.regionAdapterMappings.GetMapping(targetElement.GetType());
				global::Microsoft.Practices.Prism.Regions.IRegion region = mapping.Initialize(targetElement, regionName);
				result = region;
			}
			catch (global::System.Exception ex)
			{
				throw new global::Microsoft.Practices.Prism.Regions.Behaviors.RegionCreationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.RegionCreationException, new object[]
				{
					regionName,
					ex
				}), ex);
			}
			return result;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00007918 File Offset: 0x00005B18
		private void ElementLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.UnWireTargetElement();
			this.TryCreateRegion();
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00007928 File Offset: 0x00005B28
		private void WireUpTargetElement()
		{
			global::System.Windows.FrameworkElement frameworkElement = this.TargetElement as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				frameworkElement.Loaded += this.ElementLoaded;
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00007958 File Offset: 0x00005B58
		private void UnWireTargetElement()
		{
			global::System.Windows.FrameworkElement frameworkElement = this.TargetElement as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				frameworkElement.Loaded -= this.ElementLoaded;
			}
		}

		// Token: 0x0400008E RID: 142
		private readonly global::Microsoft.Practices.Prism.Regions.RegionAdapterMappings regionAdapterMappings;

		// Token: 0x0400008F RID: 143
		private global::System.WeakReference elementWeakReference;

		// Token: 0x04000090 RID: 144
		private bool regionCreated;
	}
}
