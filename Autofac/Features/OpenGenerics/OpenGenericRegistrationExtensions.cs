using System;
using System.Globalization;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;

namespace Autofac.Features.OpenGenerics
{
	// Token: 0x02000034 RID: 52
	internal static class OpenGenericRegistrationExtensions
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00006100 File Offset: 0x00004300
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ReflectionActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterGeneric(global::Autofac.ContainerBuilder builder, global::System.Type implementor)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (implementor == null)
			{
				throw new global::System.ArgumentNullException("implementor");
			}
			if (!implementor.GetTypeInfo().IsGenericTypeDefinition)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Features.OpenGenerics.OpenGenericRegistrationExtensionsResources.ImplementorMustBeOpenGenericType, new object[]
				{
					implementor
				}));
			}
			global::Autofac.Builder.RegistrationBuilder<object, global::Autofac.Builder.ReflectionActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> rb = new global::Autofac.Builder.RegistrationBuilder<object, global::Autofac.Builder.ReflectionActivatorData, global::Autofac.Builder.DynamicRegistrationStyle>(new global::Autofac.Core.TypedService(implementor), new global::Autofac.Builder.ReflectionActivatorData(implementor), new global::Autofac.Builder.DynamicRegistrationStyle());
			rb.RegistrationData.DeferredCallback = builder.RegisterCallback(delegate(global::Autofac.Core.IComponentRegistry cr)
			{
				cr.AddRegistrationSource(new global::Autofac.Features.OpenGenerics.OpenGenericRegistrationSource(rb.RegistrationData, rb.ActivatorData));
			});
			return rb;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000061A8 File Offset: 0x000043A8
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterGenericDecorator(global::Autofac.ContainerBuilder builder, global::System.Type decoratorType, global::System.Type decoratedServiceType, object fromKey, object toKey)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (decoratorType == null)
			{
				throw new global::System.ArgumentNullException("decoratorType");
			}
			if (decoratedServiceType == null)
			{
				throw new global::System.ArgumentNullException("decoratedServiceType");
			}
			global::Autofac.Builder.RegistrationBuilder<object, global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> rb = new global::Autofac.Builder.RegistrationBuilder<object, global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorData, global::Autofac.Builder.DynamicRegistrationStyle>((global::Autofac.Core.Service)global::Autofac.Features.OpenGenerics.OpenGenericRegistrationExtensions.GetServiceWithKey(decoratedServiceType, toKey), new global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorData(decoratorType, global::Autofac.Features.OpenGenerics.OpenGenericRegistrationExtensions.GetServiceWithKey(decoratedServiceType, fromKey)), new global::Autofac.Builder.DynamicRegistrationStyle());
			rb.RegistrationData.DeferredCallback = builder.RegisterCallback(delegate(global::Autofac.Core.IComponentRegistry cr)
			{
				cr.AddRegistrationSource(new global::Autofac.Features.OpenGenerics.OpenGenericDecoratorRegistrationSource(rb.RegistrationData, rb.ActivatorData));
			});
			return rb;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00006243 File Offset: 0x00004443
		private static global::Autofac.Core.IServiceWithType GetServiceWithKey(global::System.Type serviceType, object key)
		{
			if (key == null)
			{
				return new global::Autofac.Core.TypedService(serviceType);
			}
			return new global::Autofac.Core.KeyedService(key, serviceType);
		}
	}
}
