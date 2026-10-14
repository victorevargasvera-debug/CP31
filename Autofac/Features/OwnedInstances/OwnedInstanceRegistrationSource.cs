using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Util;

namespace Autofac.Features.OwnedInstances
{
	// Token: 0x0200002E RID: 46
	internal class OwnedInstanceRegistrationSource : global::Autofac.Core.IRegistrationSource
	{
		// Token: 0x06000165 RID: 357 RVA: 0x00005C68 File Offset: 0x00003E68
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
			if (ts == null || !ts.ServiceType.IsGenericTypeDefinedBy(typeof(global::Autofac.Features.OwnedInstances.Owned<>)))
			{
				return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
			}
			global::System.Type newType = ts.ServiceType.GetTypeInfo().GenericTypeArguments.First<global::System.Type>();
			global::Autofac.Core.Service ownedInstanceService = ts.ChangeType(newType);
			return from r in registrationAccessor(ownedInstanceService)
			select global::Autofac.Builder.RegistrationBuilder.ForDelegate(ts.ServiceType, delegate(global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p)
			{
				global::Autofac.ILifetimeScope lifetimeScope = c.Resolve<global::Autofac.ILifetimeScope>().BeginLifetimeScope(ownedInstanceService);
				object result;
				try
				{
					object obj = lifetimeScope.ResolveComponent(r, p);
					result = global::System.Activator.CreateInstance(ts.ServiceType, new object[]
					{
						obj,
						lifetimeScope
					});
				}
				catch
				{
					lifetimeScope.Dispose();
					throw;
				}
				return result;
			}).ExternallyOwned().As(new global::Autofac.Core.Service[]
			{
				service
			}).Targeting(r).InheritRegistrationOrderFrom(r).CreateRegistration<object, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>();
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00005D2E File Offset: 0x00003F2E
		public bool IsAdapterForIndividualComponents
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00005D31 File Offset: 0x00003F31
		public override string ToString()
		{
			return global::Autofac.Features.OwnedInstances.OwnedInstanceRegistrationSourceResources.OwnedInstanceRegistrationSourceDescription;
		}
	}
}
