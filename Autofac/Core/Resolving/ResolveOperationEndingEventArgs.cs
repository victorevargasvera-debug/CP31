using System;

namespace Autofac.Core.Resolving
{
	// Token: 0x02000088 RID: 136
	public class ResolveOperationEndingEventArgs : global::System.EventArgs
	{
		// Token: 0x0600030F RID: 783 RVA: 0x0000987C File Offset: 0x00007A7C
		public ResolveOperationEndingEventArgs(global::Autofac.Core.Resolving.IResolveOperation resolveOperation, global::System.Exception exception = null)
		{
			this.ResolveOperation = resolveOperation;
			this.Exception = exception;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00009892 File Offset: 0x00007A92
		public global::System.Exception Exception { get; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0000989A File Offset: 0x00007A9A
		public global::Autofac.Core.Resolving.IResolveOperation ResolveOperation { get; }
	}
}
