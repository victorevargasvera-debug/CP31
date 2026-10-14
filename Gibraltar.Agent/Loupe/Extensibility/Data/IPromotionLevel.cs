using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200008A RID: 138
	internal interface IPromotionLevel
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000654 RID: 1620
		string Name { get; }

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000655 RID: 1621
		int Sequence { get; }

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000656 RID: 1622
		string Caption { get; }

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000657 RID: 1623
		string Description { get; }
	}
}
