using System;

namespace Autofac.Core.Resolving
{
	// Token: 0x02000084 RID: 132
	public class InstanceLookupEndingEventArgs : global::System.EventArgs
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x0000958A File Offset: 0x0000778A
		public InstanceLookupEndingEventArgs(global::Autofac.Core.Resolving.IInstanceLookup instanceLookup, bool newInstanceActivated)
		{
			if (instanceLookup == null)
			{
				throw new global::System.ArgumentNullException("instanceLookup");
			}
			this.InstanceLookup = instanceLookup;
			this.NewInstanceActivated = newInstanceActivated;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002FA RID: 762 RVA: 0x000095AE File Offset: 0x000077AE
		public bool NewInstanceActivated { get; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002FB RID: 763 RVA: 0x000095B6 File Offset: 0x000077B6
		public global::Autofac.Core.Resolving.IInstanceLookup InstanceLookup { get; }
	}
}
