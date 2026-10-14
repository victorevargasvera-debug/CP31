using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200000C RID: 12
	public enum CompressionMethod
	{
		// Token: 0x04000029 RID: 41
		Stored,
		// Token: 0x0400002A RID: 42
		Deflated = 8,
		// Token: 0x0400002B RID: 43
		Deflate64,
		// Token: 0x0400002C RID: 44
		BZip2 = 12,
		// Token: 0x0400002D RID: 45
		LZMA = 14,
		// Token: 0x0400002E RID: 46
		PPMd = 98,
		// Token: 0x0400002F RID: 47
		WinZipAES
	}
}
