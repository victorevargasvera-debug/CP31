using System;
using Autofac.Core;
using Autofac.Core.Lifetime;
using Autofac.Core.Resolving;

namespace Autofac
{
	// Token: 0x02000009 RID: 9
	public interface ILifetimeScope : global::Autofac.IComponentContext, global::System.IDisposable
	{
		// Token: 0x06000028 RID: 40
		global::Autofac.ILifetimeScope BeginLifetimeScope();

		// Token: 0x06000029 RID: 41
		global::Autofac.ILifetimeScope BeginLifetimeScope(object tag);

		// Token: 0x0600002A RID: 42
		global::Autofac.ILifetimeScope BeginLifetimeScope(global::System.Action<global::Autofac.ContainerBuilder> configurationAction);

		// Token: 0x0600002B RID: 43
		global::Autofac.ILifetimeScope BeginLifetimeScope(object tag, global::System.Action<global::Autofac.ContainerBuilder> configurationAction);

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002C RID: 44
		global::Autofac.Core.IDisposer Disposer { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002D RID: 45
		object Tag { get; }

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600002E RID: 46
		// (remove) Token: 0x0600002F RID: 47
		event global::System.EventHandler<global::Autofac.Core.Lifetime.LifetimeScopeBeginningEventArgs> ChildLifetimeScopeBeginning;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000030 RID: 48
		// (remove) Token: 0x06000031 RID: 49
		event global::System.EventHandler<global::Autofac.Core.Lifetime.LifetimeScopeEndingEventArgs> CurrentScopeEnding;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000032 RID: 50
		// (remove) Token: 0x06000033 RID: 51
		event global::System.EventHandler<global::Autofac.Core.Resolving.ResolveOperationBeginningEventArgs> ResolveOperationBeginning;
	}
}
