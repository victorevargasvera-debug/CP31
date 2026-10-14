using System;
using System.Collections.Generic;

namespace Autofac.Core
{
	// Token: 0x0200006B RID: 107
	public interface IInstanceActivator : global::System.IDisposable
	{
		// Token: 0x0600028B RID: 651
		object ActivateInstance(global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters);

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600028C RID: 652
		global::System.Type LimitType { get; }
	}
}
