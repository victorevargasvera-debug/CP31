using System;

namespace Autofac.Core.Lifetime
{
	// Token: 0x0200009B RID: 155
	public class LifetimeScopeBeginningEventArgs : global::System.EventArgs
	{
		// Token: 0x060003BC RID: 956 RVA: 0x0000B3D4 File Offset: 0x000095D4
		public LifetimeScopeBeginningEventArgs(global::Autofac.ILifetimeScope lifetimeScope)
		{
			this.LifetimeScope = lifetimeScope;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000B3E3 File Offset: 0x000095E3
		public global::Autofac.ILifetimeScope LifetimeScope { get; }
	}
}
