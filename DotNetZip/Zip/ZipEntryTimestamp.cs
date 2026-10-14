using System;

namespace Ionic.Zip
{
	// Token: 0x0200004C RID: 76
	[global::System.Flags]
	public enum ZipEntryTimestamp
	{
		// Token: 0x0400028A RID: 650
		None = 0,
		// Token: 0x0400028B RID: 651
		DOS = 1,
		// Token: 0x0400028C RID: 652
		Windows = 2,
		// Token: 0x0400028D RID: 653
		Unix = 4,
		// Token: 0x0400028E RID: 654
		InfoZip1 = 8
	}
}
