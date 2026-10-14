using System;

namespace Ionic.Zip
{
	// Token: 0x0200045C RID: 1116
	internal enum ExtractExistingFileAction
	{
		// Token: 0x0400117B RID: 4475
		Throw,
		// Token: 0x0400117C RID: 4476
		OverwriteSilently,
		// Token: 0x0400117D RID: 4477
		DoNotOverwrite,
		// Token: 0x0400117E RID: 4478
		InvokeExtractProgressEvent
	}
}
