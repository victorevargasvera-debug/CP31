using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Autofac.Core;
using Autofac.Core.Activators.Delegate;
using Autofac.Core.Registration;

namespace Autofac.Builder
{
	// Token: 0x020000C2 RID: 194
	public static class RegistrationBuilder
	{
		// Token: 0x06000466 RID: 1126 RVA: 0x0000CABC File Offset: 0x0000ACBC
		public static global::Autofac.Builder.IRegistrationBuilder<T, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle> ForDelegate<T>(global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, T> @delegate)
		{
			return new global::Autofac.Builder.RegistrationBuilder<T, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>(new global::Autofac.Core.TypedService(typeof(T)), new global::Autofac.Builder.SimpleActivatorData(new global::Autofac.Core.Activators.Delegate.DelegateActivator(typeof(T), (global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p) => @delegate(c, p))), new global::Autofac.Builder.SingleRegistrationStyle());
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000CB0F File Offset: 0x0000AD0F
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle> ForDelegate(global::System.Type limitType, global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, object> @delegate)
		{
			return new global::Autofac.Builder.RegistrationBuilder<object, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>(new global::Autofac.Core.TypedService(limitType), new global::Autofac.Builder.SimpleActivatorData(new global::Autofac.Core.Activators.Delegate.DelegateActivator(limitType, @delegate)), new global::Autofac.Builder.SingleRegistrationStyle());
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000CB2D File Offset: 0x0000AD2D
		public static global::Autofac.Builder.IRegistrationBuilder<TImplementer, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle> ForType<TImplementer>()
		{
			return new global::Autofac.Builder.RegistrationBuilder<TImplementer, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>(new global::Autofac.Core.TypedService(typeof(TImplementer)), new global::Autofac.Builder.ConcreteReflectionActivatorData(typeof(TImplementer)), new global::Autofac.Builder.SingleRegistrationStyle());
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000CB57 File Offset: 0x0000AD57
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle> ForType(global::System.Type implementationType)
		{
			return new global::Autofac.Builder.RegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>(new global::Autofac.Core.TypedService(implementationType), new global::Autofac.Builder.ConcreteReflectionActivatorData(implementationType), new global::Autofac.Builder.SingleRegistrationStyle());
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000CB70 File Offset: 0x0000AD70
		public static global::Autofac.Core.IComponentRegistration CreateRegistration<TLimit, TActivatorData, TSingleRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TSingleRegistrationStyle> builder) where TActivatorData : global::Autofac.Builder.IConcreteActivatorData where TSingleRegistrationStyle : global::Autofac.Builder.SingleRegistrationStyle
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			global::System.Guid id = builder.RegistrationStyle.Id;
			global::Autofac.Builder.RegistrationData registrationData = builder.RegistrationData;
			TActivatorData activatorData = builder.ActivatorData;
			return global::Autofac.Builder.RegistrationBuilder.CreateRegistration(id, registrationData, activatorData.Activator, builder.RegistrationData.Services, builder.RegistrationStyle.Target);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0000CBD5 File Offset: 0x0000ADD5
		public static global::Autofac.Core.IComponentRegistration CreateRegistration(global::System.Guid id, global::Autofac.Builder.RegistrationData data, global::Autofac.Core.IInstanceActivator activator, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> services)
		{
			return global::Autofac.Builder.RegistrationBuilder.CreateRegistration(id, data, activator, services, null);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000CBE4 File Offset: 0x0000ADE4
		public static global::Autofac.Core.IComponentRegistration CreateRegistration(global::System.Guid id, global::Autofac.Builder.RegistrationData data, global::Autofac.Core.IInstanceActivator activator, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> services, global::Autofac.Core.IComponentRegistration target)
		{
			if (activator == null)
			{
				throw new global::System.ArgumentNullException("activator");
			}
			if (data == null)
			{
				throw new global::System.ArgumentNullException("data");
			}
			global::System.Type limitType = activator.LimitType;
			if (limitType != typeof(object))
			{
				foreach (global::Autofac.Core.IServiceWithType serviceWithType in services.OfType<global::Autofac.Core.IServiceWithType>())
				{
					if (!serviceWithType.ServiceType.GetTypeInfo().IsAssignableFrom(limitType.GetTypeInfo()))
					{
						throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Builder.RegistrationBuilderResources.ComponentDoesNotSupportService, new object[]
						{
							limitType,
							serviceWithType
						}));
					}
				}
			}
			global::Autofac.Core.IComponentRegistration componentRegistration;
			if (target == null)
			{
				componentRegistration = new global::Autofac.Core.Registration.ComponentRegistration(id, activator, data.Lifetime, data.Sharing, data.Ownership, services, data.Metadata);
			}
			else
			{
				componentRegistration = new global::Autofac.Core.Registration.ComponentRegistration(id, activator, data.Lifetime, data.Sharing, data.Ownership, services, data.Metadata, target);
			}
			foreach (global::System.EventHandler<global::Autofac.Core.PreparingEventArgs> value in data.PreparingHandlers)
			{
				componentRegistration.Preparing += value;
			}
			foreach (global::System.EventHandler<global::Autofac.Core.ActivatingEventArgs<object>> value2 in data.ActivatingHandlers)
			{
				componentRegistration.Activating += value2;
			}
			foreach (global::System.EventHandler<global::Autofac.Core.ActivatedEventArgs<object>> value3 in data.ActivatedHandlers)
			{
				componentRegistration.Activated += value3;
			}
			return componentRegistration;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		public static void RegisterSingleComponent<TLimit, TActivatorData, TSingleRegistrationStyle>(global::Autofac.Core.IComponentRegistry cr, global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TSingleRegistrationStyle> builder) where TActivatorData : global::Autofac.Builder.IConcreteActivatorData where TSingleRegistrationStyle : global::Autofac.Builder.SingleRegistrationStyle
		{
			if (cr == null)
			{
				throw new global::System.ArgumentNullException("cr");
			}
			global::Autofac.Core.IComponentRegistration componentRegistration = builder.CreateRegistration<TLimit, TActivatorData, TSingleRegistrationStyle>();
			cr.Register(componentRegistration, builder.RegistrationStyle.PreserveDefaults);
			global::Autofac.Core.ComponentRegisteredEventArgs e = new global::Autofac.Core.ComponentRegisteredEventArgs(cr, componentRegistration);
			foreach (global::System.EventHandler<global::Autofac.Core.ComponentRegisteredEventArgs> eventHandler in builder.RegistrationStyle.RegisteredHandlers)
			{
				eventHandler(cr, e);
			}
		}
	}
}
