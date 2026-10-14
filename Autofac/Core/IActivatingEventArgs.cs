using System;
using System.Collections.Generic;

namespace Autofac.Core
{
	// Token: 0x02000066 RID: 102
	public interface IActivatingEventArgs<out T>
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000265 RID: 613
		global::Autofac.IComponentContext Context { get; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000266 RID: 614
		global::Autofac.Core.IComponentRegistration Component { get; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000267 RID: 615
		T Instance { get; }

		// Token: 0x06000268 RID: 616
		void ReplaceInstance(object instance);

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000269 RID: 617
		global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> Parameters { get; }
	}
}
