using System;
using System.Collections.Generic;
using System.Diagnostics;
using Autofac.Core.Activators.Delegate;
using Autofac.Core.Lifetime;
using Autofac.Core.Registration;
using Autofac.Core.Resolving;
using Autofac.Util;

namespace Autofac.Core
{
	// Token: 0x02000060 RID: 96
	[global::System.Diagnostics.DebuggerDisplay("Tag = {Tag}, IsDisposed = {IsDisposed}")]
	public class Container : global::Autofac.Util.Disposable, global::Autofac.IContainer, global::Autofac.ILifetimeScope, global::Autofac.IComponentContext, global::System.IDisposable, global::System.IServiceProvider
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00008574 File Offset: 0x00006774
		internal Container(global::System.Collections.Generic.IDictionary<string, object> properties = null)
		{
			this.ComponentRegistry = new global::Autofac.Core.Registration.ComponentRegistry(properties ?? new global::System.Collections.Generic.Dictionary<string, object>());
			this.ComponentRegistry.Register(new global::Autofac.Core.Registration.ComponentRegistration(global::Autofac.Core.Lifetime.LifetimeScope.SelfRegistrationId, new global::Autofac.Core.Activators.Delegate.DelegateActivator(typeof(global::Autofac.Core.Lifetime.LifetimeScope), delegate(global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p)
			{
				throw new global::System.InvalidOperationException(global::Autofac.Core.ContainerResources.SelfRegistrationCannotBeActivated);
			}), new global::Autofac.Core.Lifetime.CurrentScopeLifetime(), global::Autofac.Core.InstanceSharing.Shared, global::Autofac.Core.InstanceOwnership.ExternallyOwned, new global::Autofac.Core.Service[]
			{
				new global::Autofac.Core.TypedService(typeof(global::Autofac.ILifetimeScope)),
				new global::Autofac.Core.TypedService(typeof(global::Autofac.IComponentContext))
			}, new global::System.Collections.Generic.Dictionary<string, object>()));
			this._rootLifetimeScope = new global::Autofac.Core.Lifetime.LifetimeScope(this.ComponentRegistry);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00008626 File Offset: 0x00006826
		public global::Autofac.ILifetimeScope BeginLifetimeScope()
		{
			return this._rootLifetimeScope.BeginLifetimeScope();
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00008633 File Offset: 0x00006833
		public global::Autofac.ILifetimeScope BeginLifetimeScope(object tag)
		{
			return this._rootLifetimeScope.BeginLifetimeScope(tag);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00008641 File Offset: 0x00006841
		public global::Autofac.ILifetimeScope BeginLifetimeScope(global::System.Action<global::Autofac.ContainerBuilder> configurationAction)
		{
			return this._rootLifetimeScope.BeginLifetimeScope(configurationAction);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000864F File Offset: 0x0000684F
		public global::Autofac.ILifetimeScope BeginLifetimeScope(object tag, global::System.Action<global::Autofac.ContainerBuilder> configurationAction)
		{
			return this._rootLifetimeScope.BeginLifetimeScope(tag, configurationAction);
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000865E File Offset: 0x0000685E
		public global::Autofac.Core.IDisposer Disposer
		{
			get
			{
				return this._rootLifetimeScope.Disposer;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000866B File Offset: 0x0000686B
		public object Tag
		{
			get
			{
				return this._rootLifetimeScope.Tag;
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000247 RID: 583 RVA: 0x00008678 File Offset: 0x00006878
		// (remove) Token: 0x06000248 RID: 584 RVA: 0x00008686 File Offset: 0x00006886
		public event global::System.EventHandler<global::Autofac.Core.Lifetime.LifetimeScopeBeginningEventArgs> ChildLifetimeScopeBeginning
		{
			add
			{
				this._rootLifetimeScope.ChildLifetimeScopeBeginning += value;
			}
			remove
			{
				this._rootLifetimeScope.ChildLifetimeScopeBeginning -= value;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000249 RID: 585 RVA: 0x00008694 File Offset: 0x00006894
		// (remove) Token: 0x0600024A RID: 586 RVA: 0x000086A2 File Offset: 0x000068A2
		public event global::System.EventHandler<global::Autofac.Core.Lifetime.LifetimeScopeEndingEventArgs> CurrentScopeEnding
		{
			add
			{
				this._rootLifetimeScope.CurrentScopeEnding += value;
			}
			remove
			{
				this._rootLifetimeScope.CurrentScopeEnding -= value;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600024B RID: 587 RVA: 0x000086B0 File Offset: 0x000068B0
		// (remove) Token: 0x0600024C RID: 588 RVA: 0x000086BE File Offset: 0x000068BE
		public event global::System.EventHandler<global::Autofac.Core.Resolving.ResolveOperationBeginningEventArgs> ResolveOperationBeginning
		{
			add
			{
				this._rootLifetimeScope.ResolveOperationBeginning += value;
			}
			remove
			{
				this._rootLifetimeScope.ResolveOperationBeginning -= value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000086CC File Offset: 0x000068CC
		public global::Autofac.Core.IComponentRegistry ComponentRegistry { get; }

		// Token: 0x0600024E RID: 590 RVA: 0x000086D4 File Offset: 0x000068D4
		public object ResolveComponent(global::Autofac.Core.IComponentRegistration registration, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			return this._rootLifetimeScope.ResolveComponent(registration, parameters);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000086E3 File Offset: 0x000068E3
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this._rootLifetimeScope.Dispose();
				this.ComponentRegistry.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00008705 File Offset: 0x00006905
		public object GetService(global::System.Type serviceType)
		{
			return ((global::System.IServiceProvider)this._rootLifetimeScope).GetService(serviceType);
		}

		// Token: 0x04000081 RID: 129
		private readonly global::Autofac.ILifetimeScope _rootLifetimeScope;
	}
}
