using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Features.Metadata;
using Autofac.Util;

namespace Autofac.Features.LazyDependencies
{
	// Token: 0x02000047 RID: 71
	internal class LazyWithMetadataRegistrationSource : global::Autofac.Core.IRegistrationSource
	{
		// Token: 0x060001DD RID: 477 RVA: 0x000075E4 File Offset: 0x000057E4
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> RegistrationsFor(global::Autofac.Core.Service service, global::System.Func<global::Autofac.Core.Service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration>> registrationAccessor)
		{
			if (registrationAccessor == null)
			{
				throw new global::System.ArgumentNullException("registrationAccessor");
			}
			global::Autofac.Core.IServiceWithType serviceWithType = service as global::Autofac.Core.IServiceWithType;
			global::System.Type lazyType = global::Autofac.Features.LazyDependencies.LazyWithMetadataRegistrationSource.GetLazyType(serviceWithType);
			if (serviceWithType == null || lazyType == null || !serviceWithType.ServiceType.IsGenericTypeDefinedBy(lazyType))
			{
				return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
			}
			global::System.Type[] array = serviceWithType.ServiceType.GetTypeInfo().GenericTypeArguments.ToArray<global::System.Type>();
			global::System.Type type = array[0];
			global::System.Type type2 = array[1];
			if (!type2.GetTypeInfo().IsClass)
			{
				return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
			}
			global::Autofac.Core.Service arg = serviceWithType.ChangeType(type);
			global::Autofac.Features.LazyDependencies.LazyWithMetadataRegistrationSource.RegistrationCreator registrationCreator = (global::Autofac.Features.LazyDependencies.LazyWithMetadataRegistrationSource.RegistrationCreator)global::Autofac.Features.LazyDependencies.LazyWithMetadataRegistrationSource.CreateLazyRegistrationMethod.MakeGenericMethod(new global::System.Type[]
			{
				type,
				type2
			}).CreateDelegate(typeof(global::Autofac.Features.LazyDependencies.LazyWithMetadataRegistrationSource.RegistrationCreator));
			return from v in registrationAccessor(arg)
			select registrationCreator(service, v);
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001DE RID: 478 RVA: 0x000076C5 File Offset: 0x000058C5
		public bool IsAdapterForIndividualComponents
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000076C8 File Offset: 0x000058C8
		public override string ToString()
		{
			return global::Autofac.Features.LazyDependencies.LazyWithMetadataRegistrationSourceResources.LazyWithMetadataRegistrationSourceDescription;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000076D0 File Offset: 0x000058D0
		private static global::Autofac.Core.IComponentRegistration CreateLazyRegistration<T, TMeta>(global::Autofac.Core.Service providedService, global::Autofac.Core.IComponentRegistration valueRegistration)
		{
			global::System.Func<global::System.Collections.Generic.IDictionary<string, object>, TMeta> metadataViewProvider = global::Autofac.Features.Metadata.MetadataViewProvider.GetMetadataViewProvider<TMeta>();
			TMeta metadata = metadataViewProvider(valueRegistration.Target.Metadata);
			return global::Autofac.Builder.RegistrationBuilder.ForDelegate<object>(delegate(global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p)
			{
				global::Autofac.IComponentContext context = c.Resolve<global::Autofac.IComponentContext>();
				global::System.Type serviceType = ((global::Autofac.Core.IServiceWithType)providedService).ServiceType;
				global::System.Func<T> func = () => (T)((object)context.ResolveComponent(valueRegistration, p));
				return global::System.Activator.CreateInstance(serviceType, new object[]
				{
					func,
					metadata
				});
			}).As(new global::Autofac.Core.Service[]
			{
				providedService
			}).Targeting(valueRegistration).CreateRegistration<object, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00007748 File Offset: 0x00005948
		private static global::System.Type GetLazyType(global::Autofac.Core.IServiceWithType serviceWithType)
		{
			if (serviceWithType == null || !serviceWithType.ServiceType.GetTypeInfo().IsGenericType || !(serviceWithType.ServiceType.GetGenericTypeDefinition().FullName == "System.Lazy`2"))
			{
				return null;
			}
			return serviceWithType.ServiceType.GetGenericTypeDefinition();
		}

		// Token: 0x0400005B RID: 91
		private static readonly global::System.Reflection.MethodInfo CreateLazyRegistrationMethod = typeof(global::Autofac.Features.LazyDependencies.LazyWithMetadataRegistrationSource).GetTypeInfo().GetDeclaredMethod("CreateLazyRegistration");

		// Token: 0x0200013A RID: 314
		// (Invoke) Token: 0x060005F9 RID: 1529
		private delegate global::Autofac.Core.IComponentRegistration RegistrationCreator(global::Autofac.Core.Service service, global::Autofac.Core.IComponentRegistration valueRegistration);
	}
}
