using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200000D RID: 13
	public enum EncryptionAlgorithm
	{
		// Token: 0x04000031 RID: 49
		None,
		// Token: 0x04000032 RID: 50
		PkzipClassic,
		// Token: 0x04000033 RID: 51
		Des = 26113,
		// Token: 0x04000034 RID: 52
		RC2,
		// Token: 0x04000035 RID: 53
		TripleDes168,
		// Token: 0x04000036 RID: 54
		TripleDes112 = 26121,
		// Token: 0x04000037 RID: 55
		Aes128 = 26126,
		// Token: 0x04000038 RID: 56
		Aes192,
		// Token: 0x04000039 RID: 57
		Aes256,
		// Token: 0x0400003A RID: 58
		RC2Corrected = 26370,
		// Token: 0x0400003B RID: 59
		Blowfish = 26400,
		// Token: 0x0400003C RID: 60
		Twofish,
		// Token: 0x0400003D RID: 61
		RC4 = 26625,
		// Token: 0x0400003E RID: 62
		Unknown = 65535
	}
}
