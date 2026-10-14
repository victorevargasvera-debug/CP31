using System;
using System.Linq;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200007F RID: 127
	public class SingleActiveRegion : global::Microsoft.Practices.Prism.Regions.Region
	{
		// Token: 0x06000378 RID: 888 RVA: 0x00009C9C File Offset: 0x00007E9C
		public override void Activate(object view)
		{
			object obj = this.ActiveViews.FirstOrDefault<object>();
			if (obj != null && obj != view && this.Views.Contains(obj))
			{
				base.Deactivate(obj);
			}
			base.Activate(view);
		}
	}
}
