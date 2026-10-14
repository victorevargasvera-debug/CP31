using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Practices.Prism.Properties;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000072 RID: 114
	public class RegionBehaviorFactory : global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory, global::System.Collections.Generic.IEnumerable<string>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000321 RID: 801 RVA: 0x00009028 File Offset: 0x00007228
		public RegionBehaviorFactory(global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator)
		{
			this.serviceLocator = serviceLocator;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00009044 File Offset: 0x00007244
		public void AddIfMissing(string behaviorKey, global::System.Type behaviorType)
		{
			if (behaviorKey == null)
			{
				throw new global::System.ArgumentNullException("behaviorKey");
			}
			if (behaviorType == null)
			{
				throw new global::System.ArgumentNullException("behaviorType");
			}
			if (!typeof(global::Microsoft.Practices.Prism.Regions.IRegionBehavior).IsAssignableFrom(behaviorType))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Threading.Thread.CurrentThread.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.CanOnlyAddTypesThatInheritIFromRegionBehavior, new object[]
				{
					behaviorType.Name
				}), "behaviorType");
			}
			if (this.registeredBehaviors.ContainsKey(behaviorKey))
			{
				return;
			}
			this.registeredBehaviors.Add(behaviorKey, behaviorType);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000090D4 File Offset: 0x000072D4
		public global::Microsoft.Practices.Prism.Regions.IRegionBehavior CreateFromKey(string key)
		{
			if (!this.ContainsKey(key))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Threading.Thread.CurrentThread.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.TypeWithKeyNotRegistered, new object[]
				{
					key
				}), "key");
			}
			return (global::Microsoft.Practices.Prism.Regions.IRegionBehavior)this.serviceLocator.GetInstance(this.registeredBehaviors[key]);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00009131 File Offset: 0x00007331
		public global::System.Collections.Generic.IEnumerator<string> GetEnumerator()
		{
			return this.registeredBehaviors.Keys.GetEnumerator();
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00009148 File Offset: 0x00007348
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00009150 File Offset: 0x00007350
		public bool ContainsKey(string behaviorKey)
		{
			return this.registeredBehaviors.ContainsKey(behaviorKey);
		}

		// Token: 0x040000B4 RID: 180
		private readonly global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator;

		// Token: 0x040000B5 RID: 181
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Type> registeredBehaviors = new global::System.Collections.Generic.Dictionary<string, global::System.Type>();
	}
}
