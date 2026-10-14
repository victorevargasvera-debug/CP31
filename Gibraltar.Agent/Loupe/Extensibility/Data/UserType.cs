using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000091 RID: 145
	[global::System.Flags]
	internal enum UserType
	{
		// Token: 0x0400011C RID: 284
		Unknown = 0,
		// Token: 0x0400011D RID: 285
		System = 1,
		// Token: 0x0400011E RID: 286
		Virtual = 2,
		// Token: 0x0400011F RID: 287
		Reviewer = 4,
		// Token: 0x04000120 RID: 288
		Full = 8,
		// Token: 0x04000121 RID: 289
		Administrator = 16,
		// Token: 0x04000122 RID: 290
		CanLogIn = 28,
		// Token: 0x04000123 RID: 291
		FullApplicationAccess = 24
	}
}
