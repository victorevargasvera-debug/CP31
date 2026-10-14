using System;
using System.Collections;

namespace NPOI.POIFS.Dev
{
	// Token: 0x0200029C RID: 668
	public interface POIFSViewable
	{
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001252 RID: 4690
		bool PreferArray { get; }

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001253 RID: 4691
		string ShortDescription { get; }

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001254 RID: 4692
		global::System.Array ViewableArray { get; }

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001255 RID: 4693
		global::System.Collections.IEnumerator ViewableIterator { get; }
	}
}
