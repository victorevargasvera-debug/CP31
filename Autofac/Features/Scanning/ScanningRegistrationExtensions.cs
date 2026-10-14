using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Util;

namespace Autofac.Features.Scanning
{
	// Token: 0x02000029 RID: 41
	internal static class ScanningRegistrationExtensions
	{
		// Token: 0x0600014A RID: 330 RVA: 0x000054F8 File Offset: 0x000036F8
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterAssemblyTypes(global::Autofac.ContainerBuilder builder, params global::System.Reflection.Assembly[] assemblies)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (assemblies == null)
			{
				throw new global::System.ArgumentNullException("assemblies");
			}
			global::Autofac.Builder.RegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> rb = new global::Autofac.Builder.RegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle>(new global::Autofac.Core.TypedService(typeof(object)), new global::Autofac.Features.Scanning.ScanningActivatorData(), new global::Autofac.Builder.DynamicRegistrationStyle());
			rb.RegistrationData.DeferredCallback = builder.RegisterCallback(delegate(global::Autofac.Core.IComponentRegistry cr)
			{
				global::Autofac.Features.Scanning.ScanningRegistrationExtensions.ScanAssemblies(assemblies, cr, rb);
			});
			return rb;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00005580 File Offset: 0x00003780
		public static global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> RegisterTypes(global::Autofac.ContainerBuilder builder, params global::System.Type[] types)
		{
			if (builder == null)
			{
				throw new global::System.ArgumentNullException("builder");
			}
			if (types == null)
			{
				throw new global::System.ArgumentNullException("types");
			}
			global::Autofac.Builder.RegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> rb = new global::Autofac.Builder.RegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle>(new global::Autofac.Core.TypedService(typeof(object)), new global::Autofac.Features.Scanning.ScanningActivatorData(), new global::Autofac.Builder.DynamicRegistrationStyle());
			rb.RegistrationData.DeferredCallback = builder.RegisterCallback(delegate(global::Autofac.Core.IComponentRegistry cr)
			{
				global::Autofac.Features.Scanning.ScanningRegistrationExtensions.ScanTypes(types, cr, rb);
			});
			return rb;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00005607 File Offset: 0x00003807
		private static void ScanAssemblies(global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> assemblies, global::Autofac.Core.IComponentRegistry cr, global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> rb)
		{
			global::Autofac.Features.Scanning.ScanningRegistrationExtensions.ScanTypes(assemblies.SelectMany((global::System.Reflection.Assembly a) => a.GetLoadableTypes()), cr, rb);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00005638 File Offset: 0x00003838
		private static void ScanTypes(global::System.Collections.Generic.IEnumerable<global::System.Type> types, global::Autofac.Core.IComponentRegistry cr, global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Features.Scanning.ScanningActivatorData, global::Autofac.Builder.DynamicRegistrationStyle> rb)
		{
			rb.ActivatorData.Filters.Add((global::System.Type t) => rb.RegistrationData.Services.OfType<global::Autofac.Core.IServiceWithType>().All((global::Autofac.Core.IServiceWithType swt) => swt.ServiceType.GetTypeInfo().IsAssignableFrom(t.GetTypeInfo())));
			global::System.Func<global::System.Type, bool> <>9__2;
			global::System.Func<global::System.Type, bool> predicate;
			if ((predicate = <>9__2) == null)
			{
				predicate = (<>9__2 = ((global::System.Type t) => t.GetTypeInfo().IsClass && !t.GetTypeInfo().IsAbstract && !t.GetTypeInfo().IsGenericTypeDefinition && !t.IsDelegate() && !t.IsCompilerGenerated() && rb.ActivatorData.Filters.All((global::System.Func<global::System.Type, bool> p) => p(t))));
			}
			foreach (global::System.Type type in types.Where(predicate))
			{
				global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle> registrationBuilder = global::Autofac.Builder.RegistrationBuilder.ForType(type).FindConstructorsWith(rb.ActivatorData.ConstructorFinder).UsingConstructor(rb.ActivatorData.ConstructorSelector).WithParameters(rb.ActivatorData.ConfiguredParameters).WithProperties(rb.ActivatorData.ConfiguredProperties);
				registrationBuilder.RegistrationData.CopyFrom(rb.RegistrationData, false);
				foreach (global::System.Action<global::System.Type, global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>> action in rb.ActivatorData.ConfigurationActions)
				{
					action(type, registrationBuilder);
				}
				if (registrationBuilder.RegistrationData.Services.Any<global::Autofac.Core.Service>())
				{
					global::Autofac.Builder.RegistrationBuilder.RegisterSingleComponent<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>(cr, registrationBuilder);
				}
			}
			foreach (global::System.Action<global::Autofac.Core.IComponentRegistry> action2 in rb.ActivatorData.PostScanningCallbacks)
			{
				action2(cr);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000057F4 File Offset: 0x000039F4
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> AsClosedTypesOf<TLimit, TScanningActivatorData, TRegistrationStyle>(global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Type openGenericServiceType) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (openGenericServiceType == null)
			{
				throw new global::System.ArgumentNullException("openGenericServiceType");
			}
			return (from candidateType in registration
			where candidateType.IsClosedTypeOf(openGenericServiceType)
			select candidateType).As((global::System.Type candidateType) => from t in candidateType.GetTypesThatClose(openGenericServiceType)
			select new global::Autofac.Core.TypedService(t));
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000584C File Offset: 0x00003A4C
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> AsClosedTypesOf<TLimit, TScanningActivatorData, TRegistrationStyle>(global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Type openGenericServiceType, object serviceKey) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (openGenericServiceType == null)
			{
				throw new global::System.ArgumentNullException("openGenericServiceType");
			}
			if (serviceKey == null)
			{
				throw new global::System.ArgumentNullException("serviceKey");
			}
			return global::Autofac.Features.Scanning.ScanningRegistrationExtensions.AsClosedTypesOf<TLimit, TScanningActivatorData, TRegistrationStyle>(registration, openGenericServiceType, (global::System.Type t) => serviceKey);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000058A0 File Offset: 0x00003AA0
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> AsClosedTypesOf<TLimit, TScanningActivatorData, TRegistrationStyle>(global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Type openGenericServiceType, global::System.Func<global::System.Type, object> serviceKeyMapping) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (openGenericServiceType == null)
			{
				throw new global::System.ArgumentNullException("openGenericServiceType");
			}
			return (from candidateType in registration
			where candidateType.IsClosedTypeOf(openGenericServiceType)
			select candidateType).As((global::System.Type candidateType) => from t in candidateType.GetTypesThatClose(openGenericServiceType)
			select new global::Autofac.Core.KeyedService(serviceKeyMapping(candidateType), t));
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00005900 File Offset: 0x00003B00
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> AssignableTo<TLimit, TScanningActivatorData, TRegistrationStyle>(this global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Type type) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			registration.ActivatorData.Filters.Add((global::System.Type t) => type.GetTypeInfo().IsAssignableFrom(t.GetTypeInfo()));
			return registration;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000594C File Offset: 0x00003B4C
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> As<TLimit, TScanningActivatorData, TRegistrationStyle>(global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration, global::System.Func<global::System.Type, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service>> serviceMapping) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (serviceMapping == null)
			{
				throw new global::System.ArgumentNullException("serviceMapping");
			}
			registration.ActivatorData.ConfigurationActions.Add(delegate(global::System.Type t, global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle> rb)
			{
				global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> source = serviceMapping(t);
				global::System.Type impl = rb.ActivatorData.ImplementationType;
				global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> source2 = source.Where(delegate(global::Autofac.Core.Service s)
				{
					global::Autofac.Core.IServiceWithType serviceWithType = s as global::Autofac.Core.IServiceWithType;
					return (serviceWithType == null && s != null) || serviceWithType.ServiceType.GetTypeInfo().IsAssignableFrom(impl.GetTypeInfo());
				});
				rb.As(source2.ToArray<global::Autofac.Core.Service>());
			});
			return registration;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000059AC File Offset: 0x00003BAC
		public static global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> PreserveExistingDefaults<TLimit, TScanningActivatorData, TRegistrationStyle>(global::Autofac.Builder.IRegistrationBuilder<TLimit, TScanningActivatorData, TRegistrationStyle> registration) where TScanningActivatorData : global::Autofac.Features.Scanning.ScanningActivatorData
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			registration.ActivatorData.ConfigurationActions.Add(delegate(global::System.Type t, global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle> r)
			{
				r.PreserveExistingDefaults<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>();
			});
			return registration;
		}
	}
}
