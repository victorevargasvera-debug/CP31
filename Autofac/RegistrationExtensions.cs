using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Core.Activators.ProvidedInstance;
using Autofac.Core.Activators.Reflection;
using Autofac.Core.Lifetime;
using Autofac.Features.LightweightAdapters;
using Autofac.Features.OpenGenerics;
using Autofac.Features.Scanning;
using Autofac.Util;

namespace Autofac
{
	// Token: 0x02000012 RID: 18
	public static class RegistrationExtensions
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00002D04 File Offset: 0x00000F04
		public static void RegisterComponent(this global::Autofac.ContainerBuilder builder, global::Autofac.Core.IComponentRegistration registration)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			builder.RegisterCallback(delegate(global::Autofac.Core.IComponentRegistry cr)
			{
				cr.Register(registration);
			});
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002D54 File Offset: 0x00000F54
		public static void RegisterSource(this global::Autofac.ContainerBuilder builder, global::Autofac.Core.IRegistrationSource registrationSource)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (registrationSource == null)
			{
				throw new global::System.ArgumentNullException("registrationSource");
			}
			builder.RegisterCallback(delegate(global::Autofac.Core.IComponentRegistry cr)
			{
				cr.AddRegistrationSource(registrationSource);
			});
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002DA4 File Offset: 0x00000FA4
		public static global::Autofac.Builder.IRegistrationBuilder<T, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle> RegisterInstance<T>(this global::Autofac.ContainerBuilder builder, T instance) where T : class
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (instance == null)
			{
				throw new global::System.ArgumentNullException("instance");
			}
			global::Autofac.Core.Activators.ProvidedInstance.ProvidedInstanceActivator activator = new global::Autofac.Core.Activators.ProvidedInstance.ProvidedInstanceActivator(instance);
			global::Autofac.Builder.RegistrationBuilder<T, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle> rb = new global::Autofac.Builder.RegistrationBuilder<T, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>(new global::Autofac.Core.TypedService(typeof(T)), new global::Autofac.Builder.SimpleActivatorData(activator), new global::Autofac.Builder.SingleRegistrationStyle());
			rb.SingleInstance();
			rb.RegistrationData.DeferredCallback = builder.RegisterCallback(delegate(global::Autofac.Core.IComponentRegistry cr)
			{
				if (!(rb.RegistrationData.Lifetime is global::Autofac.Core.Lifetime.RootScopeLifetime) || rb.RegistrationData.Sharing != global::Autofac.Core.InstanceSharing.Shared)
				{
					throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.RegistrationExtensionsResources.InstanceRegistrationsAreSingleInstanceOnly, new object[]
					{
						instance
					}));
				}
				activator.DisposeInstance = (rb.RegistrationData.Ownership == global::Autofac.Core.InstanceOwnership.OwnedByLifetimeScope);
				global::Autofac.Builder.RegistrationBuilder.RegisterSingleComponent<T, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>(cr, rb);
			});
			return rb;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002E58 File Offset: 0x00001058
		public static global::Autofac.Builder.IRegistrationBuilder<TImplementer, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle> RegisterType<TImplementer>(this global::Autofac.ContainerBuilder builder)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			global::Autofac.Builder.IRegistrationBuilder<TImplementer, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle> rb = global::Autofac.Builder.RegistrationBuilder.ForType<TImplementer>();
			rb.RegistrationData.DeferredCallback = builder.RegisterCallback(delegate(global::Autofac.Core.IComponentRegistry cr)
			{
				global::Autofac.Builder.RegistrationBuilder.RegisterSingleComponent<TImplementer, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>(cr, rb);
			});
			return rb;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002EAC File Offset: 0x000010AC
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle> RegisterType(this global::Autofac.ContainerBuilder builder, global::System.Type implementationType)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (implementationType == null)
			{
				throw new global::System.ArgumentNullException("implementationType");
			}
			global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle> rb = global::Autofac.Builder.RegistrationBuilder.ForType(implementationType);
			rb.RegistrationData.DeferredCallback = builder.RegisterCallback(delegate(global::Autofac.Core.IComponentRegistry cr)
			{
				global::Autofac.Builder.RegistrationBuilder.RegisterSingleComponent<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>(cr, rb);
			});
			return rb;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002F18 File Offset: 0x00001118
		public static global::Autofac.Builder.IRegistrationBuilder<T, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle> Register<T>(this global::Autofac.ContainerBuilder builder, global::System.Func<global::Autofac.IComponentContext, T> @delegate)
		{
			if (@delegate == null)
			{
				throw new global::System.ArgumentNullException("delegate");
			}
			return builder.Register((global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p) => @delegate(c));
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002F58 File Offset: 0x00001158
		public static global::Autofac.Builder.IRegistrationBuilder<T, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle> Register<T>(this global::Autofac.ContainerBuilder builder, global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, T> @delegate)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (@delegate == null)
			{
				throw new global::System.ArgumentNullException("delegate");
			}
			global::Autofac.Builder.IRegistrationBuilder<T, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle> rb = global::Autofac.Builder.RegistrationBuilder.ForDelegate<T>(@delegate);
			rb.RegistrationData.DeferredCallback = builder.RegisterCallback(delegate(global::Autofac.Core.IComponentRegistry cr)
			{
				global::Autofac.Builder.RegistrationBuilder.RegisterSingleComponent<T, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>(cr, rb);
			});
			return rb;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002FBB File Offset: 0x000011BB
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ReflectionActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterGeneric(this global::Autofac.ContainerBuilder builder, global::System.Type implementer)
		{
			return global::Autofac.Features.OpenGenerics.OpenGenericRegistrationExtensions.RegisterGeneric(builder, implementer);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002FC4 File Offset: 0x000011C4
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TSingleRegistrationStyle> PreserveExistingDefaults<TLimit, TActivatorData, TSingleRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TSingleRegistrationStyle> registration) where TSingleRegistrationStyle : global::Autofac.Builder.SingleRegistrationStyle
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			registration.RegistrationStyle.PreserveDefaults = true;
			return registration;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002FE6 File Offset: 0x000011E6
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, global::Autofac.Features.Scanning.ScanningActivatorData, TRegistrationStyle> PreserveExistingDefaults<TLimit, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, global::Autofac.Features.Scanning.ScanningActivatorData, TRegistrationStyle> registration)
		{
			return global::Autofac.Features.Scanning.ScanningRegistrationExtensions.PreserveExistingDefaults<TLimit, global::Autofac.Features.Scanning.ScanningActivatorData, TRegistrationStyle>(registration);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002FEE File Offset: 0x000011EE
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterAssemblyTypes(this global::Autofac.ContainerBuilder builder, params global::System.Reflection.Assembly[] assemblies)
		{
			return global::Autofac.Features.Scanning.ScanningRegistrationExtensions.RegisterAssemblyTypes(builder, assemblies);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002FF7 File Offset: 0x000011F7
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterTypes(this global::Autofac.ContainerBuilder builder, params global::System.Type[] types)
		{
			return global::Autofac.Features.Scanning.ScanningRegistrationExtensions.RegisterTypes(builder, types);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003000 File Offset: 0x00001200
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> Where<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Func<global::System.Type, bool> predicate) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			registration.ActivatorData.Filters.Add(predicate);
			return registration;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003027 File Offset: 0x00001227
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> As<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Func<global::System.Type, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service>> serviceMapping) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (serviceMapping == null)
			{
				throw new global::System.ArgumentNullException("serviceMapping");
			}
			return global::Autofac.Features.Scanning.ScanningRegistrationExtensions.As<TLimit, TScanningActivatorData, TRegistrationStyle>(registration, serviceMapping);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000304C File Offset: 0x0000124C
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> As<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Func<global::System.Type, global::Autofac.Core.Service> serviceMapping) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			return registration.As((global::System.Type t) => new global::Autofac.Core.Service[]
			{
				serviceMapping(t)
			});
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003088 File Offset: 0x00001288
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> As<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Func<global::System.Type, global::System.Type> serviceMapping) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			return registration.As((global::System.Type t) => new global::Autofac.Core.TypedService(serviceMapping(t)));
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000030C4 File Offset: 0x000012C4
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> As<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Func<global::System.Type, global::System.Collections.Generic.IEnumerable<global::System.Type>> serviceMapping) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			return registration.As((global::System.Type t) => from s in serviceMapping(t)
			select new global::Autofac.Core.TypedService(s));
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000030FE File Offset: 0x000012FE
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> AsSelf<TLimit>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> registration)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			return registration.As((global::System.Type t) => t);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003134 File Offset: 0x00001334
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TConcreteActivatorData, global::Autofac.Builder.SingleRegistrationStyle> AsSelf<TLimit, TConcreteActivatorData>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TConcreteActivatorData, global::Autofac.Builder.SingleRegistrationStyle> registration) where TConcreteActivatorData : global::Autofac.Builder.IConcreteActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			global::System.Type[] array = new global::System.Type[1];
			int num = 0;
			TConcreteActivatorData activatorData = registration.ActivatorData;
			array[num] = activatorData.Activator.LimitType;
			return registration.As(array);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003177 File Offset: 0x00001377
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, global::Autofac.Builder.ReflectionActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> AsSelf<TLimit>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, global::Autofac.Builder.ReflectionActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> registration)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			return registration.As(new global::System.Type[]
			{
				registration.ActivatorData.ImplementationType
			});
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000031A4 File Offset: 0x000013A4
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> WithMetadata<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Func<global::System.Type, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>> metadataMapping) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			registration.ActivatorData.ConfigurationActions.Add(delegate(global::System.Type t, global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle> rb)
			{
				rb.WithMetadata(metadataMapping(t));
			});
			return registration;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000031F0 File Offset: 0x000013F0
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> WithMetadataFrom<TAttribute>(this global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> registration)
		{
			global::System.Type typeFromHandle = typeof(TAttribute);
			global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> metadataProperties = from pi in typeFromHandle.GetRuntimeProperties()
			where pi.CanRead
			select pi;
			return registration.WithMetadata(delegate(global::System.Type t)
			{
				TAttribute[] array = t.GetTypeInfo().GetCustomAttributes(true).OfType<TAttribute>().ToArray<TAttribute>();
				if (array.Length == 0)
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.RegistrationExtensionsResources.MetadataAttributeNotFound, new object[]
					{
						typeof(TAttribute),
						t
					}));
				}
				if (array.Length != 1)
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.RegistrationExtensionsResources.MultipleMetadataAttributesSameType, new object[]
					{
						typeof(TAttribute),
						t
					}));
				}
				TAttribute attr = array[0];
				return from p in metadataProperties
				select new global::System.Collections.Generic.KeyValuePair<string, object>(p.Name, p.GetValue(attr, null));
			});
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003250 File Offset: 0x00001450
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> WithMetadata<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, string metadataKey, global::System.Func<global::System.Type, object> metadataValueMapping) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			return registration.WithMetadata((global::System.Type t) => new global::System.Collections.Generic.KeyValuePair<string, object>[]
			{
				new global::System.Collections.Generic.KeyValuePair<string, object>(metadataKey, metadataValueMapping(t))
			});
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003291 File Offset: 0x00001491
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> Named<TService>(this global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> registration, global::System.Func<global::System.Type, string> serviceNameMapping)
		{
			return registration.Named(serviceNameMapping, typeof(TService));
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000032A4 File Offset: 0x000014A4
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> Named<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Func<global::System.Type, string> serviceNameMapping, global::System.Type serviceType) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (serviceNameMapping == null)
			{
				throw new global::System.ArgumentNullException("serviceNameMapping");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			return registration.As((global::System.Type t) => new global::Autofac.Core.KeyedService(serviceNameMapping(t), serviceType));
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003311 File Offset: 0x00001511
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> Keyed<TService>(this global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> registration, global::System.Func<global::System.Type, object> serviceKeyMapping)
		{
			return registration.Keyed(serviceKeyMapping, typeof(TService));
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003324 File Offset: 0x00001524
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> Keyed<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Func<global::System.Type, object> serviceKeyMapping, global::System.Type serviceType) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (serviceKeyMapping == null)
			{
				throw new global::System.ArgumentNullException("serviceKeyMapping");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			return registration.AssignableTo(serviceType).As((global::System.Type t) => new global::Autofac.Core.KeyedService(serviceKeyMapping(t), serviceType));
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000339C File Offset: 0x0000159C
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> AsImplementedInterfaces<TLimit>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> registration)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			return registration.As((global::System.Type t) => global::Autofac.RegistrationExtensions.GetImplementedInterfaces(t));
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000033D4 File Offset: 0x000015D4
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TConcreteActivatorData, global::Autofac.Builder.SingleRegistrationStyle> AsImplementedInterfaces<TLimit, TConcreteActivatorData>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TConcreteActivatorData, global::Autofac.Builder.SingleRegistrationStyle> registration) where TConcreteActivatorData : global::Autofac.Builder.IConcreteActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			TConcreteActivatorData activatorData = registration.ActivatorData;
			return registration.As(global::Autofac.RegistrationExtensions.GetImplementedInterfaces(activatorData.Activator.LimitType));
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003414 File Offset: 0x00001614
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, global::Autofac.Builder.ReflectionActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> AsImplementedInterfaces<TLimit>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, global::Autofac.Builder.ReflectionActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> registration)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			global::System.Type implementationType = registration.ActivatorData.ImplementationType;
			return registration.As(global::Autofac.RegistrationExtensions.GetImplementedInterfaces(implementationType));
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003448 File Offset: 0x00001648
		private static global::System.Type[] GetImplementedInterfaces(global::System.Type type)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Type> enumerable = from i in type.GetTypeInfo().ImplementedInterfaces
			where i != typeof(global::System.IDisposable)
			select i;
			if (!type.GetTypeInfo().IsInterface)
			{
				return enumerable.ToArray<global::System.Type>();
			}
			return enumerable.AppendItem(type).ToArray<global::System.Type>();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000034A5 File Offset: 0x000016A5
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> FindConstructorsWith<TLimit, TReflectionActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> registration, global::Autofac.Core.Activators.Reflection.IConstructorFinder constructorFinder) where TReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (constructorFinder == null)
			{
				throw new global::System.ArgumentNullException("constructorFinder");
			}
			registration.ActivatorData.ConstructorFinder = constructorFinder;
			return registration;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000034D5 File Offset: 0x000016D5
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> FindConstructorsWith<TLimit, TReflectionActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> registration, global::System.Func<global::System.Type, global::System.Reflection.ConstructorInfo[]> finder) where TReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			return registration.FindConstructorsWith(new global::Autofac.Core.Activators.Reflection.DefaultConstructorFinder(finder));
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000034F4 File Offset: 0x000016F4
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> PropertiesAutowired<TLimit, TActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> registration, global::Autofac.PropertyWiringOptions wiringFlags = global::Autofac.PropertyWiringOptions.None)
		{
			bool preserveSetValues = (wiringFlags & global::Autofac.PropertyWiringOptions.PreserveSetValues) > global::Autofac.PropertyWiringOptions.None;
			bool allowCircularDependencies = (wiringFlags & global::Autofac.PropertyWiringOptions.AllowCircularDependencies) > global::Autofac.PropertyWiringOptions.None;
			return registration.PropertiesAutowired(new global::Autofac.Core.DefaultPropertySelector(preserveSetValues), allowCircularDependencies);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000351C File Offset: 0x0000171C
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TStyle> PropertiesAutowired<TLimit, TActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TStyle> registration, global::System.Func<global::System.Reflection.PropertyInfo, object, bool> propertySelector)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			return registration.PropertiesAutowired(new global::Autofac.Core.DelegatePropertySelector(propertySelector), false);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000353C File Offset: 0x0000173C
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> UsingConstructor<TLimit, TReflectionActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> registration, params global::System.Type[] signature) where TReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (signature == null)
			{
				throw new global::System.ArgumentNullException("signature");
			}
			if (registration.ActivatorData.ImplementationType.GetMatchingConstructor(signature) == null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.RegistrationExtensionsResources.NoMatchingConstructorExists, new object[]
				{
					registration.ActivatorData.ImplementationType
				}));
			}
			return registration.UsingConstructor(new global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelector(signature));
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000035BD File Offset: 0x000017BD
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> UsingConstructor<TLimit, TReflectionActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> registration, global::Autofac.Core.Activators.Reflection.IConstructorSelector constructorSelector) where TReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (constructorSelector == null)
			{
				throw new global::System.ArgumentNullException("constructorSelector");
			}
			registration.ActivatorData.ConstructorSelector = constructorSelector;
			return registration;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000035F0 File Offset: 0x000017F0
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> UsingConstructor<TLimit, TReflectionActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> registration, global::System.Linq.Expressions.Expression<global::System.Func<TLimit>> constructorSelector) where TReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (constructorSelector == null)
			{
				throw new global::System.ArgumentNullException("constructorSelector");
			}
			global::System.Type[] signature = (from p in global::Autofac.Util.ReflectionExtensions.GetConstructor<TLimit>(constructorSelector).GetParameters()
			select p.ParameterType).ToArray<global::System.Type>();
			return registration.UsingConstructor(signature);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003655 File Offset: 0x00001855
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> WithParameter<TLimit, TReflectionActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> registration, string parameterName, object parameterValue) where TReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData
		{
			return registration.WithParameter(new global::Autofac.NamedParameter(parameterName, parameterValue));
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003664 File Offset: 0x00001864
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> WithParameter<TLimit, TReflectionActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> registration, global::Autofac.Core.Parameter parameter) where TReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (parameter == null)
			{
				throw new global::System.ArgumentNullException("parameter");
			}
			registration.ActivatorData.ConfiguredParameters.Add(parameter);
			return registration;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003699 File Offset: 0x00001899
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> WithParameter<TLimit, TReflectionActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> registration, global::System.Func<global::System.Reflection.ParameterInfo, global::Autofac.IComponentContext, bool> parameterSelector, global::System.Func<global::System.Reflection.ParameterInfo, global::Autofac.IComponentContext, object> valueProvider) where TReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData
		{
			if (parameterSelector == null)
			{
				throw new global::System.ArgumentNullException("parameterSelector");
			}
			if (valueProvider == null)
			{
				throw new global::System.ArgumentNullException("valueProvider");
			}
			return registration.WithParameter(new global::Autofac.Core.ResolvedParameter(parameterSelector, valueProvider));
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000036C4 File Offset: 0x000018C4
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> WithParameters<TLimit, TReflectionActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> registration, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters) where TReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData
		{
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			foreach (global::Autofac.Core.Parameter parameter in parameters)
			{
				registration.WithParameter(parameter);
			}
			return registration;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000371C File Offset: 0x0000191C
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> WithProperty<TLimit, TReflectionActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> registration, string propertyName, object propertyValue) where TReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData
		{
			return registration.WithProperty(new global::Autofac.Core.NamedPropertyParameter(propertyName, propertyValue));
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000372B File Offset: 0x0000192B
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> WithProperty<TLimit, TReflectionActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> registration, global::Autofac.Core.Parameter property) where TReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (property == null)
			{
				throw new global::System.ArgumentNullException("property");
			}
			registration.ActivatorData.ConfiguredProperties.Add(property);
			return registration;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003760 File Offset: 0x00001960
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> WithProperties<TLimit, TReflectionActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TReflectionActivatorData, TStyle> registration, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> properties) where TReflectionActivatorData : global::Autofac.Builder.ReflectionActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (properties == null)
			{
				throw new global::System.ArgumentNullException("properties");
			}
			foreach (global::Autofac.Core.Parameter property in properties)
			{
				registration.WithProperty(property);
			}
			return registration;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000037C8 File Offset: 0x000019C8
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TSingleRegistrationStyle> Targeting<TLimit, TActivatorData, TSingleRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TSingleRegistrationStyle> registration, global::Autofac.Core.IComponentRegistration target) where TSingleRegistrationStyle : global::Autofac.Builder.SingleRegistrationStyle
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			registration.RegistrationStyle.Target = target.Target;
			return registration;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003800 File Offset: 0x00001A00
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TSingleRegistrationStyle> OnRegistered<TLimit, TActivatorData, TSingleRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TSingleRegistrationStyle> registration, global::System.Action<global::Autofac.Core.ComponentRegisteredEventArgs> handler) where TSingleRegistrationStyle : global::Autofac.Builder.SingleRegistrationStyle
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (handler == null)
			{
				throw new global::System.ArgumentNullException("handler");
			}
			registration.RegistrationStyle.RegisteredHandlers.Add(delegate(object s, global::Autofac.Core.ComponentRegisteredEventArgs e)
			{
				handler(e);
			});
			return registration;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003860 File Offset: 0x00001A60
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, global::Autofac.Features.Scanning.ScanningActivatorData, TRegistrationStyle> OnRegistered<TLimit, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, global::Autofac.Features.Scanning.ScanningActivatorData, TRegistrationStyle> registration, global::System.Action<global::Autofac.Core.ComponentRegisteredEventArgs> handler)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (handler == null)
			{
				throw new global::System.ArgumentNullException("handler");
			}
			registration.ActivatorData.ConfigurationActions.Add(delegate(global::System.Type t, global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle> rb)
			{
				rb.OnRegistered(handler);
			});
			return registration;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000038B8 File Offset: 0x00001AB8
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> AsClosedTypesOf<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Type openGenericServiceType) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			return global::Autofac.Features.Scanning.ScanningRegistrationExtensions.AsClosedTypesOf<TLimit, TScanningActivatorData, TRegistrationStyle>(registration, openGenericServiceType);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000038C1 File Offset: 0x00001AC1
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> AsClosedTypesOf<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Type openGenericServiceType, object serviceKey) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			return global::Autofac.Features.Scanning.ScanningRegistrationExtensions.AsClosedTypesOf<TLimit, TScanningActivatorData, TRegistrationStyle>(registration, openGenericServiceType, serviceKey);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000038CB File Offset: 0x00001ACB
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> AsClosedTypesOf<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Type openGenericServiceType, global::System.Func<global::System.Type, object> serviceKeyMapping) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			return global::Autofac.Features.Scanning.ScanningRegistrationExtensions.AsClosedTypesOf<TLimit, TScanningActivatorData, TRegistrationStyle>(registration, openGenericServiceType, serviceKeyMapping);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000038D5 File Offset: 0x00001AD5
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> AssignableTo<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Type type) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			return registration.AssignableTo(type);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000038DE File Offset: 0x00001ADE
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> AssignableTo<T>(this global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> registration)
		{
			return registration.AssignableTo(typeof(T));
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000038F0 File Offset: 0x00001AF0
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> Except<T>(this global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> registration)
		{
			return from t in registration
			where t != typeof(T)
			select t;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003918 File Offset: 0x00001B18
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> Except<T>(this global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> registration, global::System.Action<global::Autofac.Builder.IRegistrationBuilder<T, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>> customizedRegistration)
		{
			global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> registrationBuilder = registration.Except<T>();
			registrationBuilder.ActivatorData.PostScanningCallbacks.Add(delegate(global::Autofac.Core.IComponentRegistry cr)
			{
				global::Autofac.Builder.IRegistrationBuilder<T, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle> registrationBuilder2 = global::Autofac.Builder.RegistrationBuilder.ForType<T>();
				customizedRegistration(registrationBuilder2);
				global::Autofac.Builder.RegistrationBuilder.RegisterSingleComponent<T, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>(cr, registrationBuilder2);
			});
			return registrationBuilder;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003954 File Offset: 0x00001B54
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> InNamespaceOf<T>(this global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> registration)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			return registration.InNamespace(typeof(T).Namespace);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000397C File Offset: 0x00001B7C
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> InNamespace<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, string ns) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (ns == null)
			{
				throw new global::System.ArgumentNullException("ns");
			}
			return from t in registration
			where t.IsInNamespace(ns)
			select t;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000039C9 File Offset: 0x00001BC9
		public static global::Autofac.Builder.IRegistrationBuilder<TTo, global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterAdapter<TFrom, TTo>(this global::Autofac.ContainerBuilder builder, global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, TFrom, TTo> adapter)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (adapter == null)
			{
				throw new global::System.ArgumentNullException("adapter");
			}
			return global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationExtensions.RegisterAdapter<TFrom, TTo>(builder, adapter);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000039F0 File Offset: 0x00001BF0
		public static global::Autofac.Builder.IRegistrationBuilder<TTo, global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterAdapter<TFrom, TTo>(this global::Autofac.ContainerBuilder builder, global::System.Func<global::Autofac.IComponentContext, TFrom, TTo> adapter)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (adapter == null)
			{
				throw new global::System.ArgumentNullException("adapter");
			}
			return builder.RegisterAdapter((global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p, TFrom f) => adapter(c, f));
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003A40 File Offset: 0x00001C40
		public static global::Autofac.Builder.IRegistrationBuilder<TTo, global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterAdapter<TFrom, TTo>(this global::Autofac.ContainerBuilder builder, global::System.Func<TFrom, TTo> adapter)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (adapter == null)
			{
				throw new global::System.ArgumentNullException("adapter");
			}
			return builder.RegisterAdapter((global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p, TFrom f) => adapter(f));
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003A90 File Offset: 0x00001C90
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterGenericDecorator(this global::Autofac.ContainerBuilder builder, global::System.Type decoratorType, global::System.Type decoratedServiceType, object fromKey, object toKey = null)
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
			return global::Autofac.Features.OpenGenerics.OpenGenericRegistrationExtensions.RegisterGenericDecorator(builder, decoratorType, decoratedServiceType, fromKey, toKey);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003ADE File Offset: 0x00001CDE
		public static global::Autofac.Builder.IRegistrationBuilder<TService, global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterDecorator<TService>(this global::Autofac.ContainerBuilder builder, global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, TService, TService> decorator, object fromKey, object toKey = null)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (decorator == null)
			{
				throw new global::System.ArgumentNullException("decorator");
			}
			return global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationExtensions.RegisterDecorator<TService>(builder, decorator, fromKey, toKey);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003B08 File Offset: 0x00001D08
		public static global::Autofac.Builder.IRegistrationBuilder<TService, global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterDecorator<TService>(this global::Autofac.ContainerBuilder builder, global::System.Func<global::Autofac.IComponentContext, TService, TService> decorator, object fromKey, object toKey = null)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (decorator == null)
			{
				throw new global::System.ArgumentNullException("decorator");
			}
			return global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationExtensions.RegisterDecorator<TService>(builder, (global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p, TService f) => decorator(c, f), fromKey, toKey);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003B58 File Offset: 0x00001D58
		public static global::Autofac.Builder.IRegistrationBuilder<TService, global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterDecorator<TService>(this global::Autofac.ContainerBuilder builder, global::System.Func<TService, TService> decorator, object fromKey, object toKey = null)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (decorator == null)
			{
				throw new global::System.ArgumentNullException("decorator");
			}
			return global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationExtensions.RegisterDecorator<TService>(builder, (global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p, TService f) => decorator(f), fromKey, toKey);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003BA8 File Offset: 0x00001DA8
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> OnRelease<TLimit, TActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> registration, global::System.Action<TLimit> releaseAction)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (releaseAction == null)
			{
				throw new global::System.ArgumentNullException("releaseAction");
			}
			registration.ExternallyOwned();
			registration.RegistrationData.ActivatingHandlers.Add(delegate(object s, global::Autofac.Core.ActivatingEventArgs<object> e)
			{
				global::Autofac.Util.ReleaseAction<TLimit> instance = new global::Autofac.Util.ReleaseAction<TLimit>(releaseAction, () => (TLimit)((object)e.Instance));
				e.Context.Resolve<global::Autofac.ILifetimeScope>().Disposer.AddInstanceForDisposal(instance);
			});
			return registration;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003C07 File Offset: 0x00001E07
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> AutoActivate<TLimit, TActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> registration)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			registration.RegistrationData.AddService(new global::Autofac.Core.AutoActivateService());
			return registration;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003C28 File Offset: 0x00001E28
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TStyle> InstancePerRequest<TLimit, TActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TStyle> registration, params object[] lifetimeScopeTags)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			object[] lifetimeScopeTag = new object[]
			{
				global::Autofac.Core.Lifetime.MatchingScopeLifetimeTags.RequestLifetimeScopeTag
			}.Concat(lifetimeScopeTags).ToArray<object>();
			return registration.InstancePerMatchingLifetimeScope(lifetimeScopeTag);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003C64 File Offset: 0x00001E64
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TStyle> OnlyIf<TLimit, TActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TStyle> registration, global::System.Predicate<global::Autofac.Core.IComponentRegistry> predicate)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (predicate == null)
			{
				throw new global::System.ArgumentNullException("predicate");
			}
			global::Autofac.Builder.DeferredCallback deferredCallback = registration.RegistrationData.DeferredCallback;
			if (deferredCallback == null)
			{
				throw new global::System.NotSupportedException(global::Autofac.RegistrationExtensionsResources.OnlyIfRequiresCallbackContainer);
			}
			global::System.Action<global::Autofac.Core.IComponentRegistry> original = deferredCallback.Callback;
			global::System.Action<global::Autofac.Core.IComponentRegistry> callback = delegate(global::Autofac.Core.IComponentRegistry registry)
			{
				if (predicate(registry))
				{
					original(registry);
				}
			};
			deferredCallback.Callback = callback;
			return registration;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TStyle> IfNotRegistered<TLimit, TActivatorData, TStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TStyle> registration, global::System.Type serviceType)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			return registration.OnlyIf((global::Autofac.Core.IComponentRegistry reg) => !reg.IsRegistered(new global::Autofac.Core.TypedService(serviceType)));
		}
	}
}
