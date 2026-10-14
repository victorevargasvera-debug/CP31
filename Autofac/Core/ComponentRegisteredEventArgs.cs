using System;

namespace Autofac.Core
{
	// Token: 0x0200005D RID: 93
	public class ComponentRegisteredEventArgs : global::System.EventArgs
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00008484 File Offset: 0x00006684
		public global::Autofac.Core.IComponentRegistry ComponentRegistry { get; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000848C File Offset: 0x0000668C
		public global::Autofac.Core.IComponentRegistration ComponentRegistration { get; }

		// Token: 0x0600023A RID: 570 RVA: 0x00008494 File Offset: 0x00006694
		public ComponentRegisteredEventArgs(global::Autofac.Core.IComponentRegistry registry, global::Autofac.Core.IComponentRegistration componentRegistration)
		{
			if (registry == null)
			{
				throw new global::System.ArgumentNullException("registry");
			}
			if (componentRegistration == null)
			{
				throw new global::System.ArgumentNullException("componentRegistration");
			}
			this.ComponentRegistry = registry;
			this.ComponentRegistration = componentRegistration;
		}
	}
}
