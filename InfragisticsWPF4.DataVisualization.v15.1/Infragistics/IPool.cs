using System;

namespace Infragistics
{
	// Token: 0x020000A9 RID: 169
	public interface IPool<T>
	{
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000750 RID: 1872
		// (set) Token: 0x06000751 RID: 1873
		global::System.Func<T> Create { get; set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000752 RID: 1874
		// (set) Token: 0x06000753 RID: 1875
		global::System.Action<T> Disactivate { get; set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000754 RID: 1876
		// (set) Token: 0x06000755 RID: 1877
		global::System.Action<T> Activate { get; set; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000756 RID: 1878
		// (set) Token: 0x06000757 RID: 1879
		global::System.Action<T> Destroy { get; set; }

		// Token: 0x06000758 RID: 1880
		void Clear();
	}
}
