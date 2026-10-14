using System;

namespace Autofac.Core.Registration
{
	// Token: 0x02000095 RID: 149
	internal class ModuleRegistrar : global::Autofac.Core.Registration.IModuleRegistrar
	{
		// Token: 0x06000381 RID: 897 RVA: 0x0000A9BB File Offset: 0x00008BBB
		public ModuleRegistrar(global::Autofac.ContainerBuilder builder)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			this._builder = builder;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000A9D8 File Offset: 0x00008BD8
		public global::Autofac.Core.Registration.IModuleRegistrar RegisterModule(global::Autofac.Core.IModule module)
		{
			if (module == null)
			{
				throw new global::System.ArgumentNullException("module");
			}
			this._builder.RegisterCallback(new global::System.Action<global::Autofac.Core.IComponentRegistry>(module.Configure));
			return this;
		}

		// Token: 0x040000DE RID: 222
		private readonly global::Autofac.ContainerBuilder _builder;
	}
}
