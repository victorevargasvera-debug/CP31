using System;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000075 RID: 117
	internal interface IRepositoryProduct
	{
		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000593 RID: 1427
		string Name { get; }

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000594 RID: 1428
		string Caption { get; }

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000595 RID: 1429
		global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IRepositoryApplication> Applications { get; }
	}
}
