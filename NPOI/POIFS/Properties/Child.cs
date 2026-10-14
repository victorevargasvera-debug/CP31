using System;

namespace NPOI.POIFS.Properties
{
	// Token: 0x020002B9 RID: 697
	public interface Child
	{
		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001337 RID: 4919
		// (set) Token: 0x06001338 RID: 4920
		global::NPOI.POIFS.Properties.Child PreviousChild { get; set; }

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001339 RID: 4921
		// (set) Token: 0x0600133A RID: 4922
		global::NPOI.POIFS.Properties.Child NextChild { get; set; }
	}
}
