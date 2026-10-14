using System;
using Autofac.Core;
using Autofac.Features.GeneratedFactories;
using Autofac.Util;

namespace Autofac.Builder
{
	// Token: 0x020000C6 RID: 198
	public static class RegistrationExtensions
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x0000D694 File Offset: 0x0000B894
		public static global::Autofac.Builder.IRegistrationBuilder<global::System.Delegate, global::Autofac.Features.GeneratedFactories.GeneratedFactoryActivatorData, global::Autofac.Builder.SingleRegistrationStyle> RegisterGeneratedFactory(this global::Autofac.ContainerBuilder builder, global::System.Type delegateType)
		{
			if (delegateType == null)
			{
				throw new global::System.ArgumentNullException("delegateType");
			}
			global::Autofac.Util.Enforce.ArgumentTypeIsFunction(delegateType);
			global::System.Type serviceType = delegateType.FunctionReturnType();
			return builder.RegisterGeneratedFactory(delegateType, new global::Autofac.Core.TypedService(serviceType));
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000D6CF File Offset: 0x0000B8CF
		public static global::Autofac.Builder.IRegistrationBuilder<global::System.Delegate, global::Autofac.Features.GeneratedFactories.GeneratedFactoryActivatorData, global::Autofac.Builder.SingleRegistrationStyle> RegisterGeneratedFactory(this global::Autofac.ContainerBuilder builder, global::System.Type delegateType, global::Autofac.Core.Service service)
		{
			return global::Autofac.Features.GeneratedFactories.GeneratedFactoryRegistrationExtensions.RegisterGeneratedFactory<global::System.Delegate>(builder, delegateType, service);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0000D6D9 File Offset: 0x0000B8D9
		public static global::Autofac.Builder.IRegistrationBuilder<TDelegate, global::Autofac.Features.GeneratedFactories.GeneratedFactoryActivatorData, global::Autofac.Builder.SingleRegistrationStyle> RegisterGeneratedFactory<TDelegate>(this global::Autofac.ContainerBuilder builder, global::Autofac.Core.Service service) where TDelegate : class
		{
			return global::Autofac.Features.GeneratedFactories.GeneratedFactoryRegistrationExtensions.RegisterGeneratedFactory<TDelegate>(builder, typeof(TDelegate), service);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0000D6EC File Offset: 0x0000B8EC
		public static global::Autofac.Builder.IRegistrationBuilder<TDelegate, global::Autofac.Features.GeneratedFactories.GeneratedFactoryActivatorData, global::Autofac.Builder.SingleRegistrationStyle> RegisterGeneratedFactory<TDelegate>(this global::Autofac.ContainerBuilder builder) where TDelegate : class
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			global::Autofac.Util.Enforce.ArgumentTypeIsFunction(typeof(TDelegate));
			global::System.Type serviceType = typeof(TDelegate).FunctionReturnType();
			return builder.RegisterGeneratedFactory(new global::Autofac.Core.TypedService(serviceType));
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0000D732 File Offset: 0x0000B932
		public static global::Autofac.Builder.IRegistrationBuilder<TDelegate, TGeneratedFactoryActivatorData, TSingleRegistrationStyle> NamedParameterMapping<TDelegate, TGeneratedFactoryActivatorData, TSingleRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TDelegate, TGeneratedFactoryActivatorData, TSingleRegistrationStyle> registration) where TGeneratedFactoryActivatorData : global::Autofac.Features.GeneratedFactories.GeneratedFactoryActivatorData where TSingleRegistrationStyle : global::Autofac.Builder.SingleRegistrationStyle
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			registration.ActivatorData.ParameterMapping = global::Autofac.Features.GeneratedFactories.ParameterMapping.ByName;
			return registration;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0000D754 File Offset: 0x0000B954
		public static global::Autofac.Builder.IRegistrationBuilder<TDelegate, TGeneratedFactoryActivatorData, TSingleRegistrationStyle> PositionalParameterMapping<TDelegate, TGeneratedFactoryActivatorData, TSingleRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TDelegate, TGeneratedFactoryActivatorData, TSingleRegistrationStyle> registration) where TGeneratedFactoryActivatorData : global::Autofac.Features.GeneratedFactories.GeneratedFactoryActivatorData where TSingleRegistrationStyle : global::Autofac.Builder.SingleRegistrationStyle
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			registration.ActivatorData.ParameterMapping = global::Autofac.Features.GeneratedFactories.ParameterMapping.ByPosition;
			return registration;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0000D776 File Offset: 0x0000B976
		public static global::Autofac.Builder.IRegistrationBuilder<TDelegate, TGeneratedFactoryActivatorData, TSingleRegistrationStyle> TypedParameterMapping<TDelegate, TGeneratedFactoryActivatorData, TSingleRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TDelegate, TGeneratedFactoryActivatorData, TSingleRegistrationStyle> registration) where TGeneratedFactoryActivatorData : global::Autofac.Features.GeneratedFactories.GeneratedFactoryActivatorData where TSingleRegistrationStyle : global::Autofac.Builder.SingleRegistrationStyle
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			registration.ActivatorData.ParameterMapping = global::Autofac.Features.GeneratedFactories.ParameterMapping.ByType;
			return registration;
		}
	}
}
