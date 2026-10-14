using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200008B RID: 139
	internal interface IReleaseType
	{
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000658 RID: 1624
		string Name { get; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000659 RID: 1625
		int Sequence { get; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600065A RID: 1626
		string Caption { get; }

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600065B RID: 1627
		string Description { get; }
	}
}
