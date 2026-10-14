using System;

namespace Autofac.Core.Diagnostics
{
	// Token: 0x020000A2 RID: 162
	[global::System.Obsolete("Use the more general Autofac.IStartable interface instead. The IContainer parameter can be emulated when implementing IStartable by taking a dependency on IComponentContext or ILifetimeScope.", true)]
	public interface IContainerAwareComponent
	{
		// Token: 0x060003D2 RID: 978
		void SetContainer(global::Autofac.IContainer container);
	}
}
