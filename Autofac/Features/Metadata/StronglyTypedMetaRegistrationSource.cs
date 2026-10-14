using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Util;

namespace Autofac.Features.Metadata
{
	// Token: 0x02000040 RID: 64
	internal class StronglyTypedMetaRegistrationSource : global::Autofac.Core.IRegistrationSource
	{
		// Token: 0x060001BB RID: 443 RVA: 0x00006F68 File Offset: 0x00005168
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> RegistrationsFor(global::Autofac.Core.Service service, global::System.Func<global::Autofac.Core.Service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration>> registrationAccessor)
		{
			if (registrationAccessor == null)
			{
				throw new global::System.ArgumentNullException("registrationAccessor");
			}
			global::Autofac.Core.IServiceWithType serviceWithType = service as global::Autofac.Core.IServiceWithType;
			if (serviceWithType == null || !serviceWithType.ServiceType.IsGenericTypeDefinedBy(typeof(global::Autofac.Features.Metadata.Meta<, >)))
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
			global::System.Reflection.MethodInfo methodInfo = global::Autofac.Features.Metadata.StronglyTypedMetaRegistrationSource.CreateMetaRegistrationMethod.MakeGenericMethod(new global::System.Type[]
			{
				type,
				type2
			});
			global::Autofac.Features.Metadata.StronglyTypedMetaRegistrationSource.RegistrationCreator registrationCreator = (global::Autofac.Features.Metadata.StronglyTypedMetaRegistrationSource.RegistrationCreator)methodInfo.CreateDelegate(typeof(global::Autofac.Features.Metadata.StronglyTypedMetaRegistrationSource.RegistrationCreator), null);
			return from v in registrationAccessor(arg)
			select registrationCreator(service, v);
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00007044 File Offset: 0x00005244
		public bool IsAdapterForIndividualComponents
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00007047 File Offset: 0x00005247
		public override string ToString()
		{
			return global::Autofac.Features.Metadata.MetaRegistrationSourceResources.StronglyTypedMetaRegistrationSourceDescription;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00007050 File Offset: 0x00005250
		private static global::Autofac.Core.IComponentRegistration CreateMetaRegistration<T, TMetadata>(global::Autofac.Core.Service providedService, global::Autofac.Core.IComponentRegistration valueRegistration)
		{
			TMetadata metadata = global::Autofac.Features.Metadata.MetadataViewProvider.GetMetadataViewProvider<TMetadata>()(valueRegistration.Target.Metadata);
			return global::Autofac.Builder.RegistrationBuilder.ForDelegate<global::Autofac.Features.Metadata.Meta<T, TMetadata>>((global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p) => new global::Autofac.Features.Metadata.Meta<T, TMetadata>((T)((object)c.ResolveComponent(valueRegistration, p)), metadata)).As(new global::Autofac.Core.Service[]
			{
				providedService
			}).Targeting(valueRegistration).CreateRegistration<global::Autofac.Features.Metadata.Meta<T, TMetadata>, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>();
		}

		// Token: 0x04000051 RID: 81
		private static readonly global::System.Reflection.MethodInfo CreateMetaRegistrationMethod = typeof(global::Autofac.Features.Metadata.StronglyTypedMetaRegistrationSource).GetTypeInfo().GetDeclaredMethod("CreateMetaRegistration");

		// Token: 0x0200012F RID: 303
		// (Invoke) Token: 0x060005DD RID: 1501
		private delegate global::Autofac.Core.IComponentRegistration RegistrationCreator(global::Autofac.Core.Service service, global::Autofac.Core.IComponentRegistration valueRegistration);
	}
}
