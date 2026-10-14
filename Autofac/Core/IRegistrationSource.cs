using System;
using System.Collections.Generic;

namespace Autofac.Core
{
	// Token: 0x0200006F RID: 111
	public interface IRegistrationSource
	{
		// Token: 0x0600028E RID: 654
		global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> RegistrationsFor(global::Autofac.Core.Service service, global::System.Func<global::Autofac.Core.Service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration>> registrationAccessor);

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600028F RID: 655
		bool IsAdapterForIndividualComponents { get; }
	}
}
