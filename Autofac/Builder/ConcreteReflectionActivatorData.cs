using System;
using Autofac.Core;
using Autofac.Core.Activators.Reflection;

namespace Autofac.Builder
{
	// Token: 0x020000B8 RID: 184
	public class ConcreteReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData, global::Autofac.Builder.IConcreteActivatorData
	{
		// Token: 0x06000430 RID: 1072 RVA: 0x0000C919 File Offset: 0x0000AB19
		public ConcreteReflectionActivatorData(global::System.Type implementer) : base(implementer)
		{
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000C922 File Offset: 0x0000AB22
		public global::Autofac.Core.IInstanceActivator Activator
		{
			get
			{
				return new global::Autofac.Core.Activators.Reflection.ReflectionActivator(base.ImplementationType, base.ConstructorFinder, base.ConstructorSelector, base.ConfiguredParameters, base.ConfiguredProperties);
			}
		}
	}
}
