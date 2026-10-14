using System;
using System.Collections.Generic;
using System.Linq;
using Autofac.Core.Activators.Delegate;
using Autofac.Core.Lifetime;

namespace Autofac.Core.Registration
{
	// Token: 0x02000093 RID: 147
	internal class ExternalRegistrySource : global::Autofac.Core.IRegistrationSource
	{
		// Token: 0x0600037D RID: 893 RVA: 0x0000A93B File Offset: 0x00008B3B
		public ExternalRegistrySource(global::Autofac.Core.IComponentRegistry registry)
		{
			if (registry == null)
			{
				throw new global::System.ArgumentNullException("registry");
			}
			this._registry = registry;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000A958 File Offset: 0x00008B58
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> RegistrationsFor(global::Autofac.Core.Service service, global::System.Func<global::Autofac.Core.Service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration>> registrationAccessor)
		{
			return (from r in this._registry.RegistrationsFor(service)
			where r is global::Autofac.Core.Registration.ExternalRegistrySource.ExternalComponentRegistration || !r.IsAdapting()
			select r).Select(delegate(global::Autofac.Core.IComponentRegistration r)
			{
				global::Autofac.Core.Registration.ExternalRegistrySource.ExternalComponentRegistration result;
				if ((result = (r as global::Autofac.Core.Registration.ExternalRegistrySource.ExternalComponentRegistration)) == null)
				{
					result = new global::Autofac.Core.Registration.ExternalRegistrySource.ExternalComponentRegistration(global::System.Guid.NewGuid(), new global::Autofac.Core.Activators.Delegate.DelegateActivator(r.Activator.LimitType, (global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p) => c.ResolveComponent(r, p)), new global::Autofac.Core.Lifetime.CurrentScopeLifetime(), global::Autofac.Core.InstanceSharing.None, global::Autofac.Core.InstanceOwnership.ExternallyOwned, new global::Autofac.Core.Service[]
					{
						service
					}, r.Metadata, r);
				}
				return result;
			});
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000A9B8 File Offset: 0x00008BB8
		public bool IsAdapterForIndividualComponents
		{
			get
			{
				return false;
			}
		}

		// Token: 0x040000DD RID: 221
		private readonly global::Autofac.Core.IComponentRegistry _registry;

		// Token: 0x02000158 RID: 344
		private class ExternalComponentRegistration : global::Autofac.Core.Registration.ComponentRegistration
		{
			// Token: 0x06000647 RID: 1607 RVA: 0x0001027C File Offset: 0x0000E47C
			public ExternalComponentRegistration(global::System.Guid id, global::Autofac.Core.IInstanceActivator activator, global::Autofac.Core.IComponentLifetime lifetime, global::Autofac.Core.InstanceSharing sharing, global::Autofac.Core.InstanceOwnership ownership, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> services, global::System.Collections.Generic.IDictionary<string, object> metadata, global::Autofac.Core.IComponentRegistration target) : base(id, activator, lifetime, sharing, ownership, services, metadata, target)
			{
			}
		}
	}
}
