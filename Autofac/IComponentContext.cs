using System;
using System.Collections.Generic;
using Autofac.Core;

namespace Autofac
{
	// Token: 0x02000007 RID: 7
	public interface IComponentContext
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000026 RID: 38
		global::Autofac.Core.IComponentRegistry ComponentRegistry { get; }

		// Token: 0x06000027 RID: 39
		object ResolveComponent(global::Autofac.Core.IComponentRegistration registration, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters);
	}
}
