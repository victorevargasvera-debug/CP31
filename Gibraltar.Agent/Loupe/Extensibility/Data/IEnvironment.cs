using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000084 RID: 132
	internal interface IEnvironment
	{
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600061A RID: 1562
		string Name { get; }

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600061B RID: 1563
		int Sequence { get; }

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600061C RID: 1564
		string Caption { get; }

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600061D RID: 1565
		string Description { get; }
	}
}
