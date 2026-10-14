using System;

namespace Autofac.Core.Lifetime
{
	// Token: 0x0200009C RID: 156
	public class LifetimeScopeEndingEventArgs : global::System.EventArgs
	{
		// Token: 0x060003BE RID: 958 RVA: 0x0000B3EB File Offset: 0x000095EB
		public LifetimeScopeEndingEventArgs(global::Autofac.ILifetimeScope lifetimeScope)
		{
			this.LifetimeScope = lifetimeScope;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000B3FA File Offset: 0x000095FA
		public global::Autofac.ILifetimeScope LifetimeScope { get; }
	}
}
