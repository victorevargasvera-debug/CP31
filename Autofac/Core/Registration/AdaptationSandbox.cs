using System;
using System.Collections.Generic;
using System.Linq;
using Autofac.Util;

namespace Autofac.Core.Registration
{
	// Token: 0x0200008A RID: 138
	internal class AdaptationSandbox
	{
		// Token: 0x06000319 RID: 793 RVA: 0x0000992C File Offset: 0x00007B2C
		public AdaptationSandbox(global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IRegistrationSource> adapters, global::Autofac.Core.IComponentRegistration registration, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> adapterServices)
		{
			this._adapters = adapters;
			this._registration = registration;
			this._adapterServices = adapterServices;
			this._registrations.Add(this._registration);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000997C File Offset: 0x00007B7C
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> GetAdapters()
		{
			foreach (global::Autofac.Core.Service service in this._adapterServices)
			{
				this.GetAndInitialiseRegistrationsFor(service);
			}
			return from r in this._registrations
			where r != this._registration
			select r;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000099E4 File Offset: 0x00007BE4
		private global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> GetAndInitialiseRegistrationsFor(global::Autofac.Core.Service service)
		{
			global::System.Collections.Generic.IList<global::Autofac.Core.IRegistrationSource> list;
			if (!this._adaptersToQuery.TryGetValue(service, out list))
			{
				list = new global::System.Collections.Generic.List<global::Autofac.Core.IRegistrationSource>(this._adapters);
				this._adaptersToQuery.Add(service, list);
			}
			foreach (global::Autofac.Core.IRegistrationSource registrationSource in this._adapters)
			{
				list.Remove(registrationSource);
				global::Autofac.Core.IComponentRegistration[] items = registrationSource.RegistrationsFor(service, new global::System.Func<global::Autofac.Core.Service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration>>(this.GetAndInitialiseRegistrationsFor)).ToArray<global::Autofac.Core.IComponentRegistration>();
				this._registrations.AddRange(items);
			}
			return from r in this._registrations
			where r.Services.Contains(service)
			select r;
		}

		// Token: 0x040000BC RID: 188
		private readonly global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IRegistrationSource> _adapters;

		// Token: 0x040000BD RID: 189
		private readonly global::Autofac.Core.IComponentRegistration _registration;

		// Token: 0x040000BE RID: 190
		private readonly global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> _adapterServices;

		// Token: 0x040000BF RID: 191
		private readonly global::System.Collections.Generic.IDictionary<global::Autofac.Core.Service, global::System.Collections.Generic.IList<global::Autofac.Core.IRegistrationSource>> _adaptersToQuery = new global::System.Collections.Generic.Dictionary<global::Autofac.Core.Service, global::System.Collections.Generic.IList<global::Autofac.Core.IRegistrationSource>>();

		// Token: 0x040000C0 RID: 192
		private readonly global::System.Collections.Generic.IList<global::Autofac.Core.IComponentRegistration> _registrations = new global::System.Collections.Generic.List<global::Autofac.Core.IComponentRegistration>();
	}
}
