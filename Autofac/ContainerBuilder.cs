using System;
using System.Collections.Generic;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Features.Collections;
using Autofac.Features.GeneratedFactories;
using Autofac.Features.Indexed;
using Autofac.Features.LazyDependencies;
using Autofac.Features.Metadata;
using Autofac.Features.OwnedInstances;

namespace Autofac
{
	// Token: 0x02000005 RID: 5
	public class ContainerBuilder
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000023F8 File Offset: 0x000005F8
		public ContainerBuilder() : this(new global::System.Collections.Generic.Dictionary<string, object>())
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002408 File Offset: 0x00000608
		internal ContainerBuilder(global::System.Collections.Generic.IDictionary<string, object> properties)
		{
			this.Properties = properties;
			if (!this.Properties.ContainsKey("__BuildCallbackKey"))
			{
				this.Properties.Add("__BuildCallbackKey", new global::System.Collections.Generic.List<global::System.Action<global::Autofac.IContainer>>());
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002454 File Offset: 0x00000654
		public global::System.Collections.Generic.IDictionary<string, object> Properties { get; }

		// Token: 0x06000016 RID: 22 RVA: 0x0000245C File Offset: 0x0000065C
		public virtual global::Autofac.Builder.DeferredCallback RegisterCallback(global::System.Action<global::Autofac.Core.IComponentRegistry> configurationCallback)
		{
			if (configurationCallback == null)
			{
				throw new global::System.ArgumentNullException("configurationCallback");
			}
			global::Autofac.Builder.DeferredCallback deferredCallback = new global::Autofac.Builder.DeferredCallback(configurationCallback);
			this._configurationCallbacks.Add(deferredCallback);
			return deferredCallback;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000248B File Offset: 0x0000068B
		public global::Autofac.ContainerBuilder RegisterBuildCallback(global::System.Action<global::Autofac.IContainer> buildCallback)
		{
			if (buildCallback == null)
			{
				throw new global::System.ArgumentNullException("buildCallback");
			}
			this.GetBuildCallbacks().Add(buildCallback);
			return this;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000024A8 File Offset: 0x000006A8
		public global::Autofac.IContainer Build(global::Autofac.Builder.ContainerBuildOptions options = global::Autofac.Builder.ContainerBuildOptions.None)
		{
			global::Autofac.Core.Container container = new global::Autofac.Core.Container(this.Properties);
			container.ComponentRegistry.Properties["__ContainerBuildOptions"] = options;
			this.Build(container.ComponentRegistry, (options & global::Autofac.Builder.ContainerBuildOptions.ExcludeDefaultModules) > global::Autofac.Builder.ContainerBuildOptions.None);
			if ((options & global::Autofac.Builder.ContainerBuildOptions.IgnoreStartableComponents) == global::Autofac.Builder.ContainerBuildOptions.None)
			{
				global::Autofac.Builder.StartableManager.StartStartableComponents(container);
			}
			foreach (global::System.Action<global::Autofac.IContainer> action in this.GetBuildCallbacks())
			{
				action(container);
			}
			return container;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002540 File Offset: 0x00000740
		[global::System.Obsolete("Containers should generally be considered immutable. Register all of your dependencies before building/resolving. If you need to change the contents of a container, you technically should rebuild the container. This method may be removed in a future major release.")]
		public void Update(global::Autofac.IContainer container)
		{
			this.Update(container, global::Autofac.Builder.ContainerBuildOptions.None);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000254A File Offset: 0x0000074A
		[global::System.Obsolete("Containers should generally be considered immutable. Register all of your dependencies before building/resolving. If you need to change the contents of a container, you technically should rebuild the container. This method may be removed in a future major release.")]
		public void Update(global::Autofac.IContainer container, global::Autofac.Builder.ContainerBuildOptions options)
		{
			if (container == null)
			{
				throw new global::System.ArgumentNullException("container");
			}
			this.Update(container.ComponentRegistry);
			if ((options & global::Autofac.Builder.ContainerBuildOptions.IgnoreStartableComponents) == global::Autofac.Builder.ContainerBuildOptions.None)
			{
				global::Autofac.Builder.StartableManager.StartStartableComponents(container);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002571 File Offset: 0x00000771
		[global::System.Obsolete("Containers should generally be considered immutable. Register all of your dependencies before building/resolving. If you need to change the contents of a container, you technically should rebuild the container. This method may be removed in a future major release.")]
		public void Update(global::Autofac.Core.IComponentRegistry componentRegistry)
		{
			this.UpdateRegistry(componentRegistry);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000257A File Offset: 0x0000077A
		internal void UpdateRegistry(global::Autofac.Core.IComponentRegistry componentRegistry)
		{
			if (componentRegistry == null)
			{
				throw new global::System.ArgumentNullException("componentRegistry");
			}
			this.Build(componentRegistry, true);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002594 File Offset: 0x00000794
		private void Build(global::Autofac.Core.IComponentRegistry componentRegistry, bool excludeDefaultModules)
		{
			if (componentRegistry == null)
			{
				throw new global::System.ArgumentNullException("componentRegistry");
			}
			if (this._wasBuilt)
			{
				throw new global::System.InvalidOperationException(global::Autofac.ContainerBuilderResources.BuildCanOnlyBeCalledOnce);
			}
			this._wasBuilt = true;
			if (!excludeDefaultModules)
			{
				this.RegisterDefaultAdapters(componentRegistry);
			}
			foreach (global::Autofac.Builder.DeferredCallback deferredCallback in this._configurationCallbacks)
			{
				deferredCallback.Callback(componentRegistry);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002618 File Offset: 0x00000818
		private void RegisterDefaultAdapters(global::Autofac.Core.IComponentRegistry componentRegistry)
		{
			this.RegisterGeneric(typeof(global::Autofac.Features.Indexed.KeyedServiceIndex<, >)).As(new global::System.Type[]
			{
				typeof(global::Autofac.Features.Indexed.IIndex<, >)
			}).InstancePerLifetimeScope();
			componentRegistry.AddRegistrationSource(new global::Autofac.Features.Collections.CollectionRegistrationSource());
			componentRegistry.AddRegistrationSource(new global::Autofac.Features.OwnedInstances.OwnedInstanceRegistrationSource());
			componentRegistry.AddRegistrationSource(new global::Autofac.Features.Metadata.MetaRegistrationSource());
			componentRegistry.AddRegistrationSource(new global::Autofac.Features.LazyDependencies.LazyRegistrationSource());
			componentRegistry.AddRegistrationSource(new global::Autofac.Features.LazyDependencies.LazyWithMetadataRegistrationSource());
			componentRegistry.AddRegistrationSource(new global::Autofac.Features.Metadata.StronglyTypedMetaRegistrationSource());
			componentRegistry.AddRegistrationSource(new global::Autofac.Features.GeneratedFactories.GeneratedFactoryRegistrationSource());
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000026A0 File Offset: 0x000008A0
		private global::System.Collections.Generic.List<global::System.Action<global::Autofac.IContainer>> GetBuildCallbacks()
		{
			return (global::System.Collections.Generic.List<global::System.Action<global::Autofac.IContainer>>)this.Properties["__BuildCallbackKey"];
		}

		// Token: 0x04000007 RID: 7
		private readonly global::System.Collections.Generic.IList<global::Autofac.Builder.DeferredCallback> _configurationCallbacks = new global::System.Collections.Generic.List<global::Autofac.Builder.DeferredCallback>();

		// Token: 0x04000008 RID: 8
		private bool _wasBuilt;

		// Token: 0x04000009 RID: 9
		private const string BuildCallbackPropertyKey = "__BuildCallbackKey";
	}
}
