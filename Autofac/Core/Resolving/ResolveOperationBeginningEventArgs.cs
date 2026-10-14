using System;

namespace Autofac.Core.Resolving
{
	// Token: 0x02000087 RID: 135
	public class ResolveOperationBeginningEventArgs : global::System.EventArgs
	{
		// Token: 0x0600030D RID: 781 RVA: 0x00009865 File Offset: 0x00007A65
		public ResolveOperationBeginningEventArgs(global::Autofac.Core.Resolving.IResolveOperation resolveOperation)
		{
			this.ResolveOperation = resolveOperation;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00009874 File Offset: 0x00007A74
		public global::Autofac.Core.Resolving.IResolveOperation ResolveOperation { get; }
	}
}
