using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000063 RID: 99
	public interface IRegionBehaviorFactory : global::System.Collections.Generic.IEnumerable<string>, global::System.Collections.IEnumerable
	{
		// Token: 0x060002D2 RID: 722
		void AddIfMissing(string behaviorKey, global::System.Type behaviorType);

		// Token: 0x060002D3 RID: 723
		bool ContainsKey(string behaviorKey);

		// Token: 0x060002D4 RID: 724
		global::Microsoft.Practices.Prism.Regions.IRegionBehavior CreateFromKey(string key);
	}
}
