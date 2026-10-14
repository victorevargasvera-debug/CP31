using System;

namespace Microsoft.Practices.Prism
{
	// Token: 0x02000007 RID: 7
	public interface IActiveAware
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000034 RID: 52
		// (set) Token: 0x06000035 RID: 53
		bool IsActive { get; set; }

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000036 RID: 54
		// (remove) Token: 0x06000037 RID: 55
		event global::System.EventHandler IsActiveChanged;
	}
}
