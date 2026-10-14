using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000076 RID: 118
	public interface IRegionCollection : global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Regions.IRegion>, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged
	{
		// Token: 0x170000C2 RID: 194
		global::Microsoft.Practices.Prism.Regions.IRegion this[string regionName]
		{
			get;
		}

		// Token: 0x0600033E RID: 830
		void Add(global::Microsoft.Practices.Prism.Regions.IRegion region);

		// Token: 0x0600033F RID: 831
		bool Remove(string regionName);

		// Token: 0x06000340 RID: 832
		bool ContainsRegionWithName(string regionName);
	}
}
