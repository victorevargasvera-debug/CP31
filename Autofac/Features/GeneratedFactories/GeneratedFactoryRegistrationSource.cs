using System;
using System.Collections.Generic;
using System.Linq;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Util;

namespace Autofac.Features.GeneratedFactories
{
	// Token: 0x0200004E RID: 78
	internal class GeneratedFactoryRegistrationSource : global::Autofac.Core.IRegistrationSource
	{
		// Token: 0x060001FC RID: 508 RVA: 0x00007CB8 File Offset: 0x00005EB8
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> RegistrationsFor(global::Autofac.Core.Service service, global::System.Func<global::Autofac.Core.Service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration>> registrationAccessor)
		{
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (registrationAccessor == null)
			{
				throw new global::System.ArgumentNullException("registrationAccessor");
			}
			global::Autofac.Core.IServiceWithType ts = service as global::Autofac.Core.IServiceWithType;
			if (ts == null || !ts.ServiceType.IsDelegate())
			{
				return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
			}
			global::System.Type newType = ts.ServiceType.FunctionReturnType();
			global::Autofac.Core.Service arg = ts.ChangeType(newType);
			return registrationAccessor(arg).Select(delegate(global::Autofac.Core.IComponentRegistration r)
			{
				global::Autofac.Features.GeneratedFactories.FactoryGenerator @object = new global::Autofac.Features.GeneratedFactories.FactoryGenerator(ts.ServiceType, r, global::Autofac.Features.GeneratedFactories.ParameterMapping.Adaptive);
				return global::Autofac.Builder.RegistrationBuilder.ForDelegate(ts.ServiceType, new global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, object>(@object.GenerateFactory)).InstancePerLifetimeScope().ExternallyOwned().As(new global::Autofac.Core.Service[]
				{
					service
				}).Targeting(r).InheritRegistrationOrderFrom(r).CreateRegistration<object, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>();
			});
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00007D60 File Offset: 0x00005F60
		public bool IsAdapterForIndividualComponents
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00007D63 File Offset: 0x00005F63
		public override string ToString()
		{
			return global::Autofac.Features.GeneratedFactories.GeneratedFactoryRegistrationSourceResources.GeneratedFactoryRegistrationSourceDescription;
		}
	}
}
