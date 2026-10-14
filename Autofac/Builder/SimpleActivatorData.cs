using System;
using Autofac.Core;

namespace Autofac.Builder
{
	// Token: 0x020000C8 RID: 200
	public class SimpleActivatorData : global::Autofac.Builder.IConcreteActivatorData
	{
		// Token: 0x060004AE RID: 1198 RVA: 0x0000D7FC File Offset: 0x0000B9FC
		public SimpleActivatorData(global::Autofac.Core.IInstanceActivator activator)
		{
			if (activator == null)
			{
				throw new global::System.ArgumentNullException("activator");
			}
			this.Activator = activator;
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x0000D819 File Offset: 0x0000BA19
		public global::Autofac.Core.IInstanceActivator Activator { get; }
	}
}
