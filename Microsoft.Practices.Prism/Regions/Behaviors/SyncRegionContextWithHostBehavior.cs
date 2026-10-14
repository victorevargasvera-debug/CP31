using System;
using System.ComponentModel;
using System.Windows;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Regions.Behaviors
{
	// Token: 0x0200005A RID: 90
	public class SyncRegionContextWithHostBehavior : global::Microsoft.Practices.Prism.Regions.RegionBehavior, global::Microsoft.Practices.Prism.Regions.Behaviors.IHostAwareRegionBehavior, global::Microsoft.Practices.Prism.Regions.IRegionBehavior
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000842C File Offset: 0x0000662C
		private global::Microsoft.Practices.Prism.ObservableObject<object> HostControlRegionContext
		{
			get
			{
				return global::Microsoft.Practices.Prism.Regions.RegionContext.GetObservableContext(this.hostControl);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00008439 File Offset: 0x00006639
		// (set) Token: 0x060002AE RID: 686 RVA: 0x00008441 File Offset: 0x00006641
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

		// Token: 0x060002AF RID: 687 RVA: 0x0000845D File Offset: 0x0000665D
		protected override void OnAttach()
		{
			if (this.HostControl != null)
			{
				this.SynchronizeRegionContext();
				this.HostControlRegionContext.PropertyChanged += this.RegionContextObservableObject_PropertyChanged;
				base.Region.PropertyChanged += this.Region_PropertyChanged;
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000849C File Offset: 0x0000669C
		private void Region_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Context" && global::Microsoft.Practices.Prism.Regions.RegionManager.GetRegionContext(this.HostControl) != base.Region.Context)
			{
				global::Microsoft.Practices.Prism.Regions.RegionManager.SetRegionContext(this.hostControl, base.Region.Context);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000084E9 File Offset: 0x000066E9
		private void RegionContextObservableObject_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Value")
			{
				this.SynchronizeRegionContext();
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00008504 File Offset: 0x00006704
		private void SynchronizeRegionContext()
		{
			if (base.Region.Context != this.HostControlRegionContext.Value)
			{
				base.Region.Context = this.HostControlRegionContext.Value;
			}
			if (global::Microsoft.Practices.Prism.Regions.RegionManager.GetRegionContext(this.HostControl) != this.HostControlRegionContext.Value)
			{
				global::Microsoft.Practices.Prism.Regions.RegionManager.SetRegionContext(this.HostControl, this.HostControlRegionContext.Value);
			}
		}

		// Token: 0x0400009F RID: 159
		private const string RegionContextPropertyName = "Context";

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.DependencyObject hostControl;

		// Token: 0x040000A1 RID: 161
		public static readonly string BehaviorKey = "SyncRegionContextWithHost";
	}
}
