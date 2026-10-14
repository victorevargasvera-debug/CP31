using System;

namespace Ionic.Zip
{
	// Token: 0x0200004E RID: 78
	public enum ZipEntrySource
	{
		// Token: 0x04000295 RID: 661
		None,
		// Token: 0x04000296 RID: 662
		FileSystem,
		// Token: 0x04000297 RID: 663
		Stream,
		// Token: 0x04000298 RID: 664
		ZipFile,
		// Token: 0x04000299 RID: 665
		WriteDelegate,
		// Token: 0x0400029A RID: 666
		JitStream,
		// Token: 0x0400029B RID: 667
		ZipOutputStream
	}
}
