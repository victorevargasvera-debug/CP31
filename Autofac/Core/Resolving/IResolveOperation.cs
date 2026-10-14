using System;
using System.Collections.Generic;

namespace Autofac.Core.Resolving
{
	// Token: 0x02000085 RID: 133
	public interface IResolveOperation
	{
		// Token: 0x060002FC RID: 764
		object GetOrCreateInstance(global::Autofac.Core.ISharingLifetimeScope currentOperationScope, global::Autofac.Core.IComponentRegistration registration, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters);

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060002FD RID: 765
		// (remove) Token: 0x060002FE RID: 766
		event global::System.EventHandler<global::Autofac.Core.Resolving.ResolveOperationEndingEventArgs> CurrentOperationEnding;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060002FF RID: 767
		// (remove) Token: 0x06000300 RID: 768
		event global::System.EventHandler<global::Autofac.Core.Resolving.InstanceLookupBeginningEventArgs> InstanceLookupBeginning;
	}
}
