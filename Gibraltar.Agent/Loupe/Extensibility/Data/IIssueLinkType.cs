using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000087 RID: 135
	internal interface IIssueLinkType
	{
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000643 RID: 1603
		string Name { get; }

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000644 RID: 1604
		int Sequence { get; }

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000645 RID: 1605
		string Caption { get; }

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000646 RID: 1606
		string Description { get; }

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000647 RID: 1607
		string UrlTemplate { get; }
	}
}
