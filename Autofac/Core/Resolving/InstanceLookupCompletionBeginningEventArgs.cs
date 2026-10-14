using System;

namespace Autofac.Core.Resolving
{
	// Token: 0x02000082 RID: 130
	public class InstanceLookupCompletionBeginningEventArgs : global::System.EventArgs
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x00009540 File Offset: 0x00007740
		public InstanceLookupCompletionBeginningEventArgs(global::Autofac.Core.Resolving.IInstanceLookup instanceLookup)
		{
			if (instanceLookup == null)
			{
				throw new global::System.ArgumentNullException("instanceLookup");
			}
			this.InstanceLookup = instanceLookup;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000955D File Offset: 0x0000775D
		public global::Autofac.Core.Resolving.IInstanceLookup InstanceLookup { get; }
	}
}
