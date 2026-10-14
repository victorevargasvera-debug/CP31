using System;

namespace Autofac.Core.Lifetime
{
	// Token: 0x020000A1 RID: 161
	public class RootScopeLifetime : global::Autofac.Core.IComponentLifetime
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x0000B589 File Offset: 0x00009789
		public global::Autofac.Core.ISharingLifetimeScope FindScope(global::Autofac.Core.ISharingLifetimeScope mostNestedVisibleScope)
		{
			if (mostNestedVisibleScope == null)
			{
				throw new global::System.ArgumentNullException("mostNestedVisibleScope");
			}
			return mostNestedVisibleScope.RootLifetimeScope;
		}
	}
}
