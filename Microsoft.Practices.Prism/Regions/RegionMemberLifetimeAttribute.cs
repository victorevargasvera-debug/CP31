using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200006B RID: 107
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public sealed class RegionMemberLifetimeAttribute : global::System.Attribute
	{
		// Token: 0x060002FE RID: 766 RVA: 0x00008BA3 File Offset: 0x00006DA3
		public RegionMemberLifetimeAttribute()
		{
			this.KeepAlive = true;
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002FF RID: 767 RVA: 0x00008BB2 File Offset: 0x00006DB2
		// (set) Token: 0x06000300 RID: 768 RVA: 0x00008BBA File Offset: 0x00006DBA
		public bool KeepAlive { get; set; }
	}
}
