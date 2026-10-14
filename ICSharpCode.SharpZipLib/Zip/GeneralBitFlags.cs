using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200000E RID: 14
	[global::System.Flags]
	public enum GeneralBitFlags
	{
		// Token: 0x04000040 RID: 64
		Encrypted = 1,
		// Token: 0x04000041 RID: 65
		Method = 6,
		// Token: 0x04000042 RID: 66
		Descriptor = 8,
		// Token: 0x04000043 RID: 67
		ReservedPKware4 = 16,
		// Token: 0x04000044 RID: 68
		Patched = 32,
		// Token: 0x04000045 RID: 69
		StrongEncryption = 64,
		// Token: 0x04000046 RID: 70
		Unused7 = 128,
		// Token: 0x04000047 RID: 71
		Unused8 = 256,
		// Token: 0x04000048 RID: 72
		Unused9 = 512,
		// Token: 0x04000049 RID: 73
		Unused10 = 1024,
		// Token: 0x0400004A RID: 74
		UnicodeText = 2048,
		// Token: 0x0400004B RID: 75
		EnhancedCompress = 4096,
		// Token: 0x0400004C RID: 76
		HeaderMasked = 8192,
		// Token: 0x0400004D RID: 77
		ReservedPkware14 = 16384,
		// Token: 0x0400004E RID: 78
		ReservedPkware15 = 32768
	}
}
