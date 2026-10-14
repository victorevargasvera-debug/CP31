using System;

namespace Autofac.Core
{
	// Token: 0x02000071 RID: 113
	public interface ISharingLifetimeScope : global::Autofac.ILifetimeScope, global::Autofac.IComponentContext, global::System.IDisposable
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000292 RID: 658
		global::Autofac.Core.ISharingLifetimeScope RootLifetimeScope { get; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000293 RID: 659
		global::Autofac.Core.ISharingLifetimeScope ParentLifetimeScope { get; }

		// Token: 0x06000294 RID: 660
		object GetOrCreateAndShare(global::System.Guid id, global::System.Func<object> creator);
	}
}
