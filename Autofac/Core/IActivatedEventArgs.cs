using System;
using System.Collections.Generic;

namespace Autofac.Core
{
	// Token: 0x02000065 RID: 101
	public interface IActivatedEventArgs<out T>
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000261 RID: 609
		global::Autofac.IComponentContext Context { get; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000262 RID: 610
		global::Autofac.Core.IComponentRegistration Component { get; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000263 RID: 611
		global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> Parameters { get; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000264 RID: 612
		T Instance { get; }
	}
}
