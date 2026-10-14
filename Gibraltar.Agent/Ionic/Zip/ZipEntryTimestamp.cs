using System;

namespace Ionic.Zip
{
	// Token: 0x02000467 RID: 1127
	[global::System.Flags]
	internal enum ZipEntryTimestamp
	{
		// Token: 0x0400120F RID: 4623
		None = 0,
		// Token: 0x04001210 RID: 4624
		DOS = 1,
		// Token: 0x04001211 RID: 4625
		Windows = 2,
		// Token: 0x04001212 RID: 4626
		Unix = 4,
		// Token: 0x04001213 RID: 4627
		InfoZip1 = 8
	}
}
