using System;
using System.Collections.Generic;

namespace Autofac.Core
{
	// Token: 0x02000069 RID: 105
	public interface IComponentRegistry : global::System.IDisposable
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600027C RID: 636
		global::System.Collections.Generic.IDictionary<string, object> Properties { get; }

		// Token: 0x0600027D RID: 637
		bool TryGetRegistration(global::Autofac.Core.Service service, out global::Autofac.Core.IComponentRegistration registration);

		// Token: 0x0600027E RID: 638
		bool IsRegistered(global::Autofac.Core.Service service);

		// Token: 0x0600027F RID: 639
		void Register(global::Autofac.Core.IComponentRegistration registration);

		// Token: 0x06000280 RID: 640
		void Register(global::Autofac.Core.IComponentRegistration registration, bool preserveDefaults);

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000281 RID: 641
		global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> Registrations { get; }

		// Token: 0x06000282 RID: 642
		global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> RegistrationsFor(global::Autofac.Core.Service service);

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000283 RID: 643
		// (remove) Token: 0x06000284 RID: 644
		event global::System.EventHandler<global::Autofac.Core.ComponentRegisteredEventArgs> Registered;

		// Token: 0x06000285 RID: 645
		void AddRegistrationSource(global::Autofac.Core.IRegistrationSource source);

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000286 RID: 646
		global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IRegistrationSource> Sources { get; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000287 RID: 647
		bool HasLocalComponents { get; }

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000288 RID: 648
		// (remove) Token: 0x06000289 RID: 649
		event global::System.EventHandler<global::Autofac.Core.RegistrationSourceAddedEventArgs> RegistrationSourceAdded;
	}
}
