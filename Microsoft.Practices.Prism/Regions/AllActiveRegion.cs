using System;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200004D RID: 77
	public class AllActiveRegion : global::Microsoft.Practices.Prism.Regions.Region
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00007224 File Offset: 0x00005424
		public override global::Microsoft.Practices.Prism.Regions.IViewsCollection ActiveViews
		{
			get
			{
				return this.Views;
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000722C File Offset: 0x0000542C
		public override void Deactivate(object view)
		{
			throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.Properties.Resources.DeactiveNotPossibleException);
		}
	}
}
