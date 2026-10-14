using System;
using System.Collections.Generic;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200007C RID: 124
	public interface IRegionViewRegistry
	{
		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000367 RID: 871
		// (remove) Token: 0x06000368 RID: 872
		event global::System.EventHandler<global::Microsoft.Practices.Prism.Regions.ViewRegisteredEventArgs> ContentRegistered;

		// Token: 0x06000369 RID: 873
		global::System.Collections.Generic.IEnumerable<object> GetContents(string regionName);

		// Token: 0x0600036A RID: 874
		void RegisterViewWithRegion(string regionName, global::System.Type viewType);

		// Token: 0x0600036B RID: 875
		void RegisterViewWithRegion(string regionName, global::System.Func<object> getContentDelegate);
	}
}
