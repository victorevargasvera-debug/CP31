using System;

namespace Autofac.Core.Resolving
{
	// Token: 0x02000083 RID: 131
	public class InstanceLookupCompletionEndingEventArgs : global::System.EventArgs
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x00009565 File Offset: 0x00007765
		public InstanceLookupCompletionEndingEventArgs(global::Autofac.Core.Resolving.IInstanceLookup instanceLookup)
		{
			if (instanceLookup == null)
			{
				throw new global::System.ArgumentNullException("instanceLookup");
			}
			this.InstanceLookup = instanceLookup;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00009582 File Offset: 0x00007782
		public global::Autofac.Core.Resolving.IInstanceLookup InstanceLookup { get; }
	}
}
