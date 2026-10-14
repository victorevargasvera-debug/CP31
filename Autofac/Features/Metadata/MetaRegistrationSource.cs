using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Util;

namespace Autofac.Features.Metadata
{
	// Token: 0x0200003C RID: 60
	internal class MetaRegistrationSource : global::Autofac.Core.IRegistrationSource
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x00006D74 File Offset: 0x00004F74
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> RegistrationsFor(global::Autofac.Core.Service service, global::System.Func<global::Autofac.Core.Service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration>> registrationAccessor)
		{
			if (registrationAccessor == null)
			{
				throw new global::System.ArgumentNullException("registrationAccessor");
			}
			global::Autofac.Core.IServiceWithType serviceWithType = service as global::Autofac.Core.IServiceWithType;
			if (serviceWithType == null || !serviceWithType.ServiceType.IsGenericTypeDefinedBy(typeof(global::Autofac.Features.Metadata.Meta<>)))
			{
				return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
			}
			global::System.Type type = serviceWithType.ServiceType.GetTypeInfo().GenericTypeArguments.First<global::System.Type>();
			global::Autofac.Core.Service arg = serviceWithType.ChangeType(type);
			global::System.Reflection.MethodInfo registrationCreator = global::Autofac.Features.Metadata.MetaRegistrationSource.CreateMetaRegistrationMethod.MakeGenericMethod(new global::System.Type[]
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

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00006E1D File Offset: 0x0000501D
		public bool IsAdapterForIndividualComponents
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00006E20 File Offset: 0x00005020
		public override string ToString()
		{
			return global::Autofac.Features.Metadata.MetaRegistrationSourceResources.MetaRegistrationSourceDescription;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00006E28 File Offset: 0x00005028
		private static global::Autofac.Core.IComponentRegistration CreateMetaRegistration<T>(global::Autofac.Core.Service providedService, global::Autofac.Core.IComponentRegistration valueRegistration)
		{
			return global::Autofac.Builder.RegistrationBuilder.ForDelegate<global::Autofac.Features.Metadata.Meta<T>>((global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p) => new global::Autofac.Features.Metadata.Meta<T>((T)((object)c.ResolveComponent(valueRegistration, p)), valueRegistration.Target.Metadata)).As(new global::Autofac.Core.Service[]
			{
				providedService
			}).Targeting(valueRegistration).InheritRegistrationOrderFrom(valueRegistration).CreateRegistration<global::Autofac.Features.Metadata.Meta<T>, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>();
		}

		// Token: 0x0400004A RID: 74
		private static readonly global::System.Reflection.MethodInfo CreateMetaRegistrationMethod = typeof(global::Autofac.Features.Metadata.MetaRegistrationSource).GetTypeInfo().GetDeclaredMethod("CreateMetaRegistration");
	}
}
