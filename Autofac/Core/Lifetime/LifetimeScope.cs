using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using Autofac.Builder;
using Autofac.Core.Registration;
using Autofac.Core.Resolving;
using Autofac.Util;

namespace Autofac.Core.Lifetime
{
	// Token: 0x0200009A RID: 154
	[global::System.Diagnostics.DebuggerDisplay("Tag = {Tag}, IsDisposed = {IsDisposed}")]
	public class LifetimeScope : global::Autofac.Util.Disposable, global::Autofac.Core.ISharingLifetimeScope, global::Autofac.ILifetimeScope, global::Autofac.IComponentContext, global::System.IDisposable, global::System.IServiceProvider
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0000AD5F File Offset: 0x00008F5F
		internal static global::System.Guid SelfRegistrationId { get; } = global::System.Guid.NewGuid();

		// Token: 0x060003A0 RID: 928 RVA: 0x0000AD66 File Offset: 0x00008F66
		private static object MakeAnonymousTag()
		{
			return new object();
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000AD6D File Offset: 0x00008F6D
		private LifetimeScope()
		{
			this._sharedInstances[global::Autofac.Core.Lifetime.LifetimeScope.SelfRegistrationId] = this;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000ADA7 File Offset: 0x00008FA7
		protected LifetimeScope(global::Autofac.Core.IComponentRegistry componentRegistry, global::Autofac.Core.Lifetime.LifetimeScope parent, object tag) : this(componentRegistry, tag)
		{
			if (parent == null)
			{
				throw new global::System.ArgumentNullException("parent");
			}
			this._parent = parent;
			this.RootLifetimeScope = this._parent.RootLifetimeScope;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000ADD7 File Offset: 0x00008FD7
		public LifetimeScope(global::Autofac.Core.IComponentRegistry componentRegistry, object tag) : this()
		{
			if (componentRegistry == null)
			{
				throw new global::System.ArgumentNullException("componentRegistry");
			}
			if (tag == null)
			{
				throw new global::System.ArgumentNullException("tag");
			}
			this.ComponentRegistry = componentRegistry;
			this.RootLifetimeScope = this;
			this.Tag = tag;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000AE10 File Offset: 0x00009010
		public LifetimeScope(global::Autofac.Core.IComponentRegistry componentRegistry) : this(componentRegistry, global::Autofac.Core.Lifetime.LifetimeScope.RootTag)
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000AE1E File Offset: 0x0000901E
		public global::Autofac.ILifetimeScope BeginLifetimeScope()
		{
			return this.BeginLifetimeScope(global::Autofac.Core.Lifetime.LifetimeScope.MakeAnonymousTag());
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000AE2C File Offset: 0x0000902C
		public global::Autofac.ILifetimeScope BeginLifetimeScope(object tag)
		{
			this.CheckNotDisposed();
			for (global::Autofac.Core.ISharingLifetimeScope sharingLifetimeScope = this; sharingLifetimeScope != this.RootLifetimeScope; sharingLifetimeScope = sharingLifetimeScope.ParentLifetimeScope)
			{
				if (sharingLifetimeScope.Tag.Equals(tag))
				{
					throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Lifetime.LifetimeScopeResources.DuplicateTagDetected, new object[]
					{
						tag
					}));
				}
			}
			global::Autofac.Core.Registration.CopyOnWriteRegistry copyOnWriteRegistry = new global::Autofac.Core.Registration.CopyOnWriteRegistry(this.ComponentRegistry, () => this.CreateScopeRestrictedRegistry(tag, global::Autofac.Core.Lifetime.LifetimeScope.NoConfiguration));
			global::Autofac.Core.Lifetime.LifetimeScope lifetimeScope = new global::Autofac.Core.Lifetime.LifetimeScope(copyOnWriteRegistry, this, tag);
			lifetimeScope.Disposer.AddInstanceForDisposal(copyOnWriteRegistry);
			this.RaiseBeginning(lifetimeScope);
			return lifetimeScope;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000AED8 File Offset: 0x000090D8
		private void RaiseBeginning(global::Autofac.ILifetimeScope scope)
		{
			global::System.EventHandler<global::Autofac.Core.Lifetime.LifetimeScopeBeginningEventArgs> childLifetimeScopeBeginning = this.ChildLifetimeScopeBeginning;
			if (childLifetimeScopeBeginning == null)
			{
				return;
			}
			childLifetimeScopeBeginning(this, new global::Autofac.Core.Lifetime.LifetimeScopeBeginningEventArgs(scope));
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000AEF1 File Offset: 0x000090F1
		public global::Autofac.ILifetimeScope BeginLifetimeScope(global::System.Action<global::Autofac.ContainerBuilder> configurationAction)
		{
			return this.BeginLifetimeScope(global::Autofac.Core.Lifetime.LifetimeScope.MakeAnonymousTag(), configurationAction);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000AF00 File Offset: 0x00009100
		public global::Autofac.ILifetimeScope BeginLifetimeScope(object tag, global::System.Action<global::Autofac.ContainerBuilder> configurationAction)
		{
			if (configurationAction == null)
			{
				throw new global::System.ArgumentNullException("configurationAction");
			}
			this.CheckNotDisposed();
			global::Autofac.Core.Registration.ScopeRestrictedRegistry scopeRestrictedRegistry = this.CreateScopeRestrictedRegistry(tag, configurationAction);
			global::Autofac.Core.Lifetime.LifetimeScope lifetimeScope = new global::Autofac.Core.Lifetime.LifetimeScope(scopeRestrictedRegistry, this, tag);
			lifetimeScope.Disposer.AddInstanceForDisposal(scopeRestrictedRegistry);
			object obj;
			if (scopeRestrictedRegistry.Properties.TryGetValue("__ContainerBuildOptions", out obj) && !((global::Autofac.Builder.ContainerBuildOptions)obj).HasFlag(global::Autofac.Builder.ContainerBuildOptions.IgnoreStartableComponents))
			{
				global::Autofac.Builder.StartableManager.StartStartableComponents(lifetimeScope);
			}
			this.RaiseBeginning(lifetimeScope);
			return lifetimeScope;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000AF7C File Offset: 0x0000917C
		private global::Autofac.Core.Registration.ScopeRestrictedRegistry CreateScopeRestrictedRegistry(object tag, global::System.Action<global::Autofac.ContainerBuilder> configurationAction)
		{
			global::Autofac.ContainerBuilder containerBuilder = new global::Autofac.ContainerBuilder(new global::Autofac.Util.FallbackDictionary<string, object>(this.ComponentRegistry.Properties));
			foreach (global::Autofac.Core.IRegistrationSource registrationSource in from src in this.ComponentRegistry.Sources
			where src.IsAdapterForIndividualComponents
			select src)
			{
				containerBuilder.RegisterSource(registrationSource);
			}
			global::Autofac.Core.Registration.ExternalRegistrySource externalRegistrySource = (from s in global::Autofac.Util.Traverse.Across<global::Autofac.Core.ISharingLifetimeScope>(this, (global::Autofac.Core.ISharingLifetimeScope s) => s.ParentLifetimeScope)
			where s.ComponentRegistry.HasLocalComponents
			select new global::Autofac.Core.Registration.ExternalRegistrySource(s.ComponentRegistry)).FirstOrDefault<global::Autofac.Core.Registration.ExternalRegistrySource>();
			if (externalRegistrySource != null)
			{
				containerBuilder.RegisterSource(externalRegistrySource);
			}
			configurationAction(containerBuilder);
			global::Autofac.Core.Registration.ScopeRestrictedRegistry scopeRestrictedRegistry = new global::Autofac.Core.Registration.ScopeRestrictedRegistry(tag, containerBuilder.Properties);
			containerBuilder.UpdateRegistry(scopeRestrictedRegistry);
			return scopeRestrictedRegistry;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000B0A4 File Offset: 0x000092A4
		public object ResolveComponent(global::Autofac.Core.IComponentRegistration registration, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			this.CheckNotDisposed();
			global::Autofac.Core.Resolving.ResolveOperation resolveOperation = new global::Autofac.Core.Resolving.ResolveOperation(this);
			global::System.EventHandler<global::Autofac.Core.Resolving.ResolveOperationBeginningEventArgs> resolveOperationBeginning = this.ResolveOperationBeginning;
			if (resolveOperationBeginning != null)
			{
				resolveOperationBeginning(this, new global::Autofac.Core.Resolving.ResolveOperationBeginningEventArgs(resolveOperation));
			}
			return resolveOperation.Execute(registration, parameters);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000B0FA File Offset: 0x000092FA
		public global::Autofac.Core.ISharingLifetimeScope ParentLifetimeScope
		{
			get
			{
				return this._parent;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0000B102 File Offset: 0x00009302
		public global::Autofac.Core.ISharingLifetimeScope RootLifetimeScope { get; }

		// Token: 0x060003AE RID: 942 RVA: 0x0000B10C File Offset: 0x0000930C
		public object GetOrCreateAndShare(global::System.Guid id, global::System.Func<object> creator)
		{
			if (creator == null)
			{
				throw new global::System.ArgumentNullException("creator");
			}
			object synchRoot = this._synchRoot;
			object result;
			lock (synchRoot)
			{
				object obj;
				if (!this._sharedInstances.TryGetValue(id, out obj))
				{
					obj = creator();
					if (this._sharedInstances.ContainsKey(id))
					{
						throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Lifetime.LifetimeScopeResources.SelfConstructingDependencyDetected, new object[]
						{
							obj.GetType().FullName
						}));
					}
					this._sharedInstances.Add(id, obj);
				}
				result = obj;
			}
			return result;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0000B1B4 File Offset: 0x000093B4
		public global::Autofac.Core.IDisposer Disposer { get; } = new global::Autofac.Core.Disposer();

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0000B1BC File Offset: 0x000093BC
		public object Tag { get; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0000B1C4 File Offset: 0x000093C4
		public global::Autofac.Core.IComponentRegistry ComponentRegistry { get; }

		// Token: 0x060003B2 RID: 946 RVA: 0x0000B1CC File Offset: 0x000093CC
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				global::System.EventHandler<global::Autofac.Core.Lifetime.LifetimeScopeEndingEventArgs> currentScopeEnding = this.CurrentScopeEnding;
				try
				{
					if (currentScopeEnding != null)
					{
						currentScopeEnding(this, new global::Autofac.Core.Lifetime.LifetimeScopeEndingEventArgs(this));
					}
				}
				finally
				{
					this.Disposer.Dispose();
				}
				this._sharedInstances.Clear();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000B228 File Offset: 0x00009428
		private void CheckNotDisposed()
		{
			if (base.IsDisposed)
			{
				throw new global::System.ObjectDisposedException(global::Autofac.Core.Lifetime.LifetimeScopeResources.ScopeIsDisposed, null);
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000B23E File Offset: 0x0000943E
		public object GetService(global::System.Type serviceType)
		{
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			return this.ResolveOptional(serviceType);
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060003B5 RID: 949 RVA: 0x0000B25C File Offset: 0x0000945C
		// (remove) Token: 0x060003B6 RID: 950 RVA: 0x0000B294 File Offset: 0x00009494
		public event global::System.EventHandler<global::Autofac.Core.Lifetime.LifetimeScopeBeginningEventArgs> ChildLifetimeScopeBeginning;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x060003B7 RID: 951 RVA: 0x0000B2CC File Offset: 0x000094CC
		// (remove) Token: 0x060003B8 RID: 952 RVA: 0x0000B304 File Offset: 0x00009504
		public event global::System.EventHandler<global::Autofac.Core.Lifetime.LifetimeScopeEndingEventArgs> CurrentScopeEnding;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x060003B9 RID: 953 RVA: 0x0000B33C File Offset: 0x0000953C
		// (remove) Token: 0x060003BA RID: 954 RVA: 0x0000B374 File Offset: 0x00009574
		public event global::System.EventHandler<global::Autofac.Core.Resolving.ResolveOperationBeginningEventArgs> ResolveOperationBeginning;

		// Token: 0x040000E9 RID: 233
		private readonly object _synchRoot = new object();

		// Token: 0x040000EA RID: 234
		private readonly global::System.Collections.Generic.IDictionary<global::System.Guid, object> _sharedInstances = new global::System.Collections.Generic.Dictionary<global::System.Guid, object>();

		// Token: 0x040000EB RID: 235
		private readonly global::Autofac.Core.ISharingLifetimeScope _parent;

		// Token: 0x040000ED RID: 237
		private static readonly global::System.Action<global::Autofac.ContainerBuilder> NoConfiguration = delegate(global::Autofac.ContainerBuilder b)
		{
		};

		// Token: 0x040000EE RID: 238
		public static readonly object RootTag = "root";
	}
}
