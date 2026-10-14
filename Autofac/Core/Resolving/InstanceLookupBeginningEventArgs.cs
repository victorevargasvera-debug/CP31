using System;

namespace Autofac.Core.Resolving
{
	// Token: 0x02000081 RID: 129
	public class InstanceLookupBeginningEventArgs : global::System.EventArgs
	{
		// Token: 0x060002F3 RID: 755 RVA: 0x0000951B File Offset: 0x0000771B
		public InstanceLookupBeginningEventArgs(global::Autofac.Core.Resolving.IInstanceLookup instanceLookup)
		{
			if (instanceLookup == null)
			{
				throw new global::System.ArgumentNullException("instanceLookup");
			}
			this.InstanceLookup = instanceLookup;
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00009538 File Offset: 0x00007738
		public global::Autofac.Core.Resolving.IInstanceLookup InstanceLookup { get; }
	}
}
