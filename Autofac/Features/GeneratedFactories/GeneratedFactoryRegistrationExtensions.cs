using System;
using Autofac.Builder;
using Autofac.Core;

namespace Autofac.Features.GeneratedFactories
{
	// Token: 0x0200004D RID: 77
	internal static class GeneratedFactoryRegistrationExtensions
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00007C58 File Offset: 0x00005E58
		internal static global::Autofac.Builder.IRegistrationBuilder<TLimit, global::Autofac.Features.GeneratedFactories.GeneratedFactoryActivatorData, global::Autofac.Builder.SingleRegistrationStyle> RegisterGeneratedFactory<TLimit>(global::Autofac.ContainerBuilder builder, global::System.Type delegateType, global::Autofac.Core.Service service)
		{
			global::Autofac.Features.GeneratedFactories.GeneratedFactoryActivatorData activatorData = new global::Autofac.Features.GeneratedFactories.GeneratedFactoryActivatorData(delegateType, service);
			global::Autofac.Builder.RegistrationBuilder<TLimit, global::Autofac.Features.GeneratedFactories.GeneratedFactoryActivatorData, global::Autofac.Builder.SingleRegistrationStyle> rb = new global::Autofac.Builder.RegistrationBuilder<TLimit, global::Autofac.Features.GeneratedFactories.GeneratedFactoryActivatorData, global::Autofac.Builder.SingleRegistrationStyle>(new global::Autofac.Core.TypedService(delegateType), activatorData, new global::Autofac.Builder.SingleRegistrationStyle());
			rb.RegistrationData.DeferredCallback = builder.RegisterCallback(delegate(global::Autofac.Core.IComponentRegistry cr)
			{
				global::Autofac.Builder.RegistrationBuilder.RegisterSingleComponent<TLimit, global::Autofac.Features.GeneratedFactories.GeneratedFactoryActivatorData, global::Autofac.Builder.SingleRegistrationStyle>(cr, rb);
			});
			return rb.InstancePerLifetimeScope();
		}
	}
}
