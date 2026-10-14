using System;
using System.Collections.Generic;

namespace Autofac.Core.Resolving
{
	// Token: 0x0200007F RID: 127
	public interface IInstanceLookup
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002D8 RID: 728
		global::Autofac.Core.IComponentRegistration ComponentRegistration { get; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002D9 RID: 729
		global::Autofac.ILifetimeScope ActivationScope { get; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002DA RID: 730
		global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> Parameters { get; }

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060002DB RID: 731
		// (remove) Token: 0x060002DC RID: 732
		event global::System.EventHandler<global::Autofac.Core.Resolving.InstanceLookupEndingEventArgs> InstanceLookupEnding;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060002DD RID: 733
		// (remove) Token: 0x060002DE RID: 734
		event global::System.EventHandler<global::Autofac.Core.Resolving.InstanceLookupCompletionBeginningEventArgs> CompletionBeginning;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060002DF RID: 735
		// (remove) Token: 0x060002E0 RID: 736
		event global::System.EventHandler<global::Autofac.Core.Resolving.InstanceLookupCompletionEndingEventArgs> CompletionEnding;
	}
}
