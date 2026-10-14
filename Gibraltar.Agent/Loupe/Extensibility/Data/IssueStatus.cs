using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200008F RID: 143
	[global::System.Flags]
	internal enum IssueStatus
	{
		// Token: 0x04000114 RID: 276
		None = 0,
		// Token: 0x04000115 RID: 277
		Active = 1,
		// Token: 0x04000116 RID: 278
		New = 2,
		// Token: 0x04000117 RID: 279
		Resolved = 4,
		// Token: 0x04000118 RID: 280
		Suppressed = 8,
		// Token: 0x04000119 RID: 281
		Open = 3,
		// Token: 0x0400011A RID: 282
		Closed = 12
	}
}
