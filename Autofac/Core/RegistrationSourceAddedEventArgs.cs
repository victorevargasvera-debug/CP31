using System;

namespace Autofac.Core
{
	// Token: 0x02000076 RID: 118
	public class RegistrationSourceAddedEventArgs : global::System.EventArgs
	{
		// Token: 0x060002A7 RID: 679 RVA: 0x00008AE9 File Offset: 0x00006CE9
		public RegistrationSourceAddedEventArgs(global::Autofac.Core.IComponentRegistry componentRegistry, global::Autofac.Core.IRegistrationSource registrationSource)
		{
			if (componentRegistry == null)
			{
				throw new global::System.ArgumentNullException("componentRegistry");
			}
			if (registrationSource == null)
			{
				throw new global::System.ArgumentNullException("registrationSource");
			}
			this.ComponentRegistry = componentRegistry;
			this.RegistrationSource = registrationSource;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00008B1B File Offset: 0x00006D1B
		public global::Autofac.Core.IRegistrationSource RegistrationSource { get; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00008B23 File Offset: 0x00006D23
		public global::Autofac.Core.IComponentRegistry ComponentRegistry { get; }
	}
}
