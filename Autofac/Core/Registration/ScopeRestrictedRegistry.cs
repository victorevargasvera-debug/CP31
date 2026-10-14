using System;
using System.Collections.Generic;
using Autofac.Core.Lifetime;

namespace Autofac.Core.Registration
{
	// Token: 0x02000096 RID: 150
	internal class ScopeRestrictedRegistry : global::Autofac.Core.Registration.ComponentRegistry
	{
		// Token: 0x06000383 RID: 899 RVA: 0x0000AA02 File Offset: 0x00008C02
		internal ScopeRestrictedRegistry(object scopeTag, global::System.Collections.Generic.IDictionary<string, object> properties) : base(properties)
		{
			this._restrictedRootScopeLifetime = new global::Autofac.Core.Lifetime.MatchingScopeLifetime(new object[]
			{
				scopeTag
			});
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000AA20 File Offset: 0x00008C20
		protected override void AddRegistration(global::Autofac.Core.IComponentRegistration registration, bool preserveDefaults, bool originatedFromSource = false)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			global::Autofac.Core.IComponentRegistration registration2 = registration;
			if (registration.Lifetime is global::Autofac.Core.Lifetime.RootScopeLifetime)
			{
				registration2 = new global::Autofac.Core.Registration.ComponentRegistrationLifetimeDecorator(registration, this._restrictedRootScopeLifetime);
			}
			base.AddRegistration(registration2, preserveDefaults, originatedFromSource);
		}

		// Token: 0x040000DF RID: 223
		private readonly global::Autofac.Core.IComponentLifetime _restrictedRootScopeLifetime;
	}
}
