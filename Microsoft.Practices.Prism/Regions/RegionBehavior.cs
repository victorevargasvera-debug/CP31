using System;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200004F RID: 79
	public abstract class RegionBehavior : global::Microsoft.Practices.Prism.Regions.IRegionBehavior
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00007240 File Offset: 0x00005440
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00007248 File Offset: 0x00005448
		public global::Microsoft.Practices.Prism.Regions.IRegion Region
		{
			get
			{
				return this.region;
			}
			set
			{
				if (this.IsAttached)
				{
					throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.Properties.Resources.RegionBehaviorRegionCannotBeSetAfterAttach);
				}
				this.region = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00007264 File Offset: 0x00005464
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0000726C File Offset: 0x0000546C
		public bool IsAttached { get; private set; }

		// Token: 0x06000254 RID: 596 RVA: 0x00007275 File Offset: 0x00005475
		public void Attach()
		{
			if (this.region == null)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.Properties.Resources.RegionBehaviorAttachCannotBeCallWithNullRegion);
			}
			this.IsAttached = true;
			this.OnAttach();
		}

		// Token: 0x06000255 RID: 597
		protected abstract void OnAttach();

		// Token: 0x04000086 RID: 134
		private global::Microsoft.Practices.Prism.Regions.IRegion region;
	}
}
