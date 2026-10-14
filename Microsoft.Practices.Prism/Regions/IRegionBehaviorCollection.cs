using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000070 RID: 112
	public interface IRegionBehaviorCollection : global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::Microsoft.Practices.Prism.Regions.IRegionBehavior>>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000318 RID: 792
		void Add(string key, global::Microsoft.Practices.Prism.Regions.IRegionBehavior regionBehavior);

		// Token: 0x06000319 RID: 793
		bool ContainsKey(string key);

		// Token: 0x170000BE RID: 190
		global::Microsoft.Practices.Prism.Regions.IRegionBehavior this[string key]
		{
			get;
		}
	}
}
