using System;
using System.Collections.Generic;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Core.Registration;
using Autofac.Features.Scanning;

namespace Autofac
{
	// Token: 0x0200000C RID: 12
	public static class ModuleRegistrationExtensions
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000028E8 File Offset: 0x00000AE8
		public static global::Autofac.Core.Registration.IModuleRegistrar RegisterAssemblyModules(this global::Autofac.ContainerBuilder builder, params global::System.Reflection.Assembly[] assemblies)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			return new global::Autofac.Core.Registration.ModuleRegistrar(builder).RegisterAssemblyModules(assemblies);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002904 File Offset: 0x00000B04
		public static global::Autofac.Core.Registration.IModuleRegistrar RegisterAssemblyModules(this global::Autofac.Core.Registration.IModuleRegistrar registrar, params global::System.Reflection.Assembly[] assemblies)
		{
			if (registrar == null)
			{
				throw new global::System.ArgumentNullException("registrar");
			}
			return registrar.RegisterAssemblyModules(assemblies);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000291B File Offset: 0x00000B1B
		public static global::Autofac.Core.Registration.IModuleRegistrar RegisterAssemblyModules<TModule>(this global::Autofac.ContainerBuilder builder, params global::System.Reflection.Assembly[] assemblies) where TModule : global::Autofac.Core.IModule
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			return new global::Autofac.Core.Registration.ModuleRegistrar(builder).RegisterAssemblyModules(typeof(TModule), assemblies);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002941 File Offset: 0x00000B41
		public static global::Autofac.Core.Registration.IModuleRegistrar RegisterAssemblyModules<TModule>(this global::Autofac.Core.Registration.IModuleRegistrar registrar, params global::System.Reflection.Assembly[] assemblies) where TModule : global::Autofac.Core.IModule
		{
			if (registrar == null)
			{
				throw new global::System.ArgumentNullException("registrar");
			}
			return registrar.RegisterAssemblyModules(typeof(TModule), assemblies);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002962 File Offset: 0x00000B62
		public static global::Autofac.Core.Registration.IModuleRegistrar RegisterAssemblyModules(this global::Autofac.ContainerBuilder builder, global::System.Type moduleType, params global::System.Reflection.Assembly[] assemblies)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (moduleType == null)
			{
				throw new global::System.ArgumentNullException("moduleType");
			}
			return new global::Autofac.Core.Registration.ModuleRegistrar(builder).RegisterAssemblyModules(moduleType, assemblies);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002994 File Offset: 0x00000B94
		public static global::Autofac.Core.Registration.IModuleRegistrar RegisterAssemblyModules(this global::Autofac.Core.Registration.IModuleRegistrar registrar, global::System.Type moduleType, params global::System.Reflection.Assembly[] assemblies)
		{
			if (registrar == null)
			{
				throw new global::System.ArgumentNullException("registrar");
			}
			if (moduleType == null)
			{
				throw new global::System.ArgumentNullException("moduleType");
			}
			global::Autofac.ContainerBuilder containerBuilder = new global::Autofac.ContainerBuilder();
			(from t in containerBuilder.RegisterAssemblyTypes(assemblies)
			where moduleType.GetTypeInfo().IsAssignableFrom(t.GetTypeInfo())
			select t).As<global::Autofac.Core.IModule>();
			using (global::Autofac.IContainer container = containerBuilder.Build(global::Autofac.Builder.ContainerBuildOptions.None))
			{
				foreach (global::Autofac.Core.IModule module in container.Resolve<global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IModule>>())
				{
					registrar.RegisterModule(module);
				}
			}
			return registrar;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002A58 File Offset: 0x00000C58
		public static global::Autofac.Core.Registration.IModuleRegistrar RegisterModule<TModule>(this global::Autofac.ContainerBuilder builder) where TModule : global::Autofac.Core.IModule, new()
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			return new global::Autofac.Core.Registration.ModuleRegistrar(builder).RegisterModule<TModule>();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002A73 File Offset: 0x00000C73
		public static global::Autofac.Core.Registration.IModuleRegistrar RegisterModule<TModule>(this global::Autofac.Core.Registration.IModuleRegistrar registrar) where TModule : global::Autofac.Core.IModule, new()
		{
			if (registrar == null)
			{
				throw new global::System.ArgumentNullException("registrar");
			}
			return registrar.RegisterModule(global::System.Activator.CreateInstance<TModule>());
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002A93 File Offset: 0x00000C93
		public static global::Autofac.Core.Registration.IModuleRegistrar RegisterModule(this global::Autofac.ContainerBuilder builder, global::Autofac.Core.IModule module)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (module == null)
			{
				throw new global::System.ArgumentNullException("module");
			}
			return new global::Autofac.Core.Registration.ModuleRegistrar(builder).RegisterModule(module);
		}
	}
}
