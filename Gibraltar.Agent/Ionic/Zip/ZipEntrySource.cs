using System;

namespace Ionic.Zip
{
	// Token: 0x02000469 RID: 1129
	internal enum ZipEntrySource
	{
		// Token: 0x04001219 RID: 4633
		None,
		// Token: 0x0400121A RID: 4634
		FileSystem,
		// Token: 0x0400121B RID: 4635
		Stream,
		// Token: 0x0400121C RID: 4636
		ZipFile,
		// Token: 0x0400121D RID: 4637
		WriteDelegate,
		// Token: 0x0400121E RID: 4638
		JitStream,
		// Token: 0x0400121F RID: 4639
		ZipOutputStream
	}
}
