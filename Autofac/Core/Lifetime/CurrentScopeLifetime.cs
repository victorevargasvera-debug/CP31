using System;

namespace Autofac.Core.Lifetime
{
	// Token: 0x02000099 RID: 153
	public class CurrentScopeLifetime : global::Autofac.Core.IComponentLifetime
	{
		// Token: 0x0600039D RID: 925 RVA: 0x0000AD46 File Offset: 0x00008F46
		public global::Autofac.Core.ISharingLifetimeScope FindScope(global::Autofac.Core.ISharingLifetimeScope mostNestedVisibleScope)
		{
			if (mostNestedVisibleScope == null)
			{
				throw new global::System.ArgumentNullException("mostNestedVisibleScope");
			}
			return mostNestedVisibleScope;
		}
	}
}
