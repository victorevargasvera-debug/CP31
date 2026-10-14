using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Util;

namespace Autofac.Features.LazyDependencies
{
	// Token: 0x02000045 RID: 69
	internal class LazyRegistrationSource : global::Autofac.Core.IRegistrationSource
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00007454 File Offset: 0x00005654
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> RegistrationsFor(global::Autofac.Core.Service service, global::System.Func<global::Autofac.Core.Service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration>> registrationAccessor)
		{
			if (registrationAccessor == null)
			{
				throw new global::System.ArgumentNullException("registrationAccessor");
			}
			global::Autofac.Core.IServiceWithType serviceWithType = service as global::Autofac.Core.IServiceWithType;
			if (serviceWithType == null || !serviceWithType.ServiceType.IsGenericTypeDefinedBy(typeof(global::System.Lazy<>)))
			{
				return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
			}
			global::System.Type type = serviceWithType.ServiceType.GetTypeInfo().GenericTypeArguments.First<global::System.Type>();
			global::Autofac.Core.Service arg = serviceWithType.ChangeType(type);
			global::System.Reflection.MethodInfo registrationCreator = global::Autofac.Features.LazyDependencies.LazyRegistrationSource.CreateLazyRegistrationMethod.MakeGenericMethod(new global::System.Type[]
			{
				type
			});
			return (from v in registrationAccessor(arg)
			select registrationCreator.Invoke(null, new object[]
			{
				service,
				v
			})).Cast<global::Autofac.Core.IComponentRegistration>();
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000074FD File Offset: 0x000056FD
		public bool IsAdapterForIndividualComponents
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00007500 File Offset: 0x00005700
		public override string ToString()
		{
			return global::Autofac.Features.LazyDependencies.LazyRegistrationSourceResources.LazyRegistrationSourceDescription;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00007508 File Offset: 0x00005708
		private static global::Autofac.Core.IComponentRegistration CreateLazyRegistration<T>(global::Autofac.Core.Service providedService, global::Autofac.Core.IComponentRegistration valueRegistration)
		{
			return global::Autofac.Builder.RegistrationBuilder.ForDelegate<global::System.Lazy<T>>(delegate(global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p)
			{
				global::Autofac.IComponentContext context = c.Resolve<global::Autofac.IComponentContext>();
				return new global::System.Lazy<T>(() => (T)((object)context.ResolveComponent(valueRegistration, p)));
			}).As(new global::Autofac.Core.Service[]
			{
				providedService
			}).Targeting(valueRegistration).InheritRegistrationOrderFrom(valueRegistration).CreateRegistration<global::System.Lazy<T>, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>();
		}

		// Token: 0x04000058 RID: 88
		private static readonly global::System.Reflection.MethodInfo CreateLazyRegistrationMethod = typeof(global::Autofac.Features.LazyDependencies.LazyRegistrationSource).GetTypeInfo().GetDeclaredMethod("CreateLazyRegistration");
	}
}
