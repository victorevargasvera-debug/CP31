using System;
using System.Globalization;
using System.Linq;
using Autofac.Core;

namespace Autofac.Builder
{
	// Token: 0x020000CA RID: 202
	internal static class StartableManager
	{
		// Token: 0x060004B8 RID: 1208 RVA: 0x0000D87C File Offset: 0x0000BA7C
		internal static void StartStartableComponents(global::Autofac.IComponentContext componentContext)
		{
			global::Autofac.Core.IComponentRegistry componentRegistry = componentContext.ComponentRegistry;
			try
			{
				componentRegistry.Properties["__StartOnActivate"] = true;
				foreach (global::Autofac.Core.IComponentRegistration componentRegistration in from r in componentRegistry.RegistrationsFor(new global::Autofac.Core.TypedService(typeof(global::Autofac.IStartable)))
				where !r.Metadata.ContainsKey("__AutoActivated")
				select r)
				{
					try
					{
						componentContext.ResolveComponent(componentRegistration, global::System.Linq.Enumerable.Empty<global::Autofac.Core.Parameter>());
					}
					finally
					{
						componentRegistration.Metadata["__AutoActivated"] = true;
					}
				}
				foreach (global::Autofac.Core.IComponentRegistration componentRegistration2 in from r in componentRegistry.RegistrationsFor(new global::Autofac.Core.AutoActivateService())
				where !r.Metadata.ContainsKey("__AutoActivated")
				select r)
				{
					try
					{
						componentContext.ResolveComponent(componentRegistration2, global::System.Linq.Enumerable.Empty<global::Autofac.Core.Parameter>());
					}
					catch (global::Autofac.Core.DependencyResolutionException innerException)
					{
						throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.ContainerBuilderResources.ErrorAutoActivating, new object[]
						{
							componentRegistration2
						}), innerException);
					}
					finally
					{
						componentRegistration2.Metadata["__AutoActivated"] = true;
					}
				}
			}
			finally
			{
				componentRegistry.Properties.Remove("__StartOnActivate");
			}
		}
	}
}
