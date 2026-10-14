using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000071 RID: 113
	public class RegionBehaviorCollection : global::Microsoft.Practices.Prism.Regions.IRegionBehaviorCollection, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::Microsoft.Practices.Prism.Regions.IRegionBehavior>>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600031B RID: 795 RVA: 0x00008F67 File Offset: 0x00007167
		public RegionBehaviorCollection(global::Microsoft.Practices.Prism.Regions.IRegion region)
		{
			this.region = region;
		}

		// Token: 0x170000BF RID: 191
		public global::Microsoft.Practices.Prism.Regions.IRegionBehavior this[string key]
		{
			get
			{
				return this.behaviors[key];
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00008F90 File Offset: 0x00007190
		public void Add(string key, global::Microsoft.Practices.Prism.Regions.IRegionBehavior regionBehavior)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			if (regionBehavior == null)
			{
				throw new global::System.ArgumentNullException("regionBehavior");
			}
			if (this.behaviors.ContainsKey(key))
			{
				throw new global::System.ArgumentException("Could not add duplicate behavior with same key.", "key");
			}
			this.behaviors.Add(key, regionBehavior);
			regionBehavior.Region = this.region;
			regionBehavior.Attach();
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00008FF6 File Offset: 0x000071F6
		public bool ContainsKey(string key)
		{
			return this.behaviors.ContainsKey(key);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00009004 File Offset: 0x00007204
		public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, global::Microsoft.Practices.Prism.Regions.IRegionBehavior>> GetEnumerator()
		{
			return this.behaviors.GetEnumerator();
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00009016 File Offset: 0x00007216
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.behaviors.GetEnumerator();
		}

		// Token: 0x040000B2 RID: 178
		private readonly global::Microsoft.Practices.Prism.Regions.IRegion region;

		// Token: 0x040000B3 RID: 179
		private readonly global::System.Collections.Generic.Dictionary<string, global::Microsoft.Practices.Prism.Regions.IRegionBehavior> behaviors = new global::System.Collections.Generic.Dictionary<string, global::Microsoft.Practices.Prism.Regions.IRegionBehavior>();
	}
}
