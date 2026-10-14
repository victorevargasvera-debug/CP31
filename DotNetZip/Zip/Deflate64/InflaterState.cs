using System;

namespace Ionic.Zip.Deflate64
{
	// Token: 0x0200005E RID: 94
	internal enum InflaterState
	{
		// Token: 0x04000321 RID: 801
		ReadingHeader,
		// Token: 0x04000322 RID: 802
		ReadingBFinal = 2,
		// Token: 0x04000323 RID: 803
		ReadingBType,
		// Token: 0x04000324 RID: 804
		ReadingNumLitCodes,
		// Token: 0x04000325 RID: 805
		ReadingNumDistCodes,
		// Token: 0x04000326 RID: 806
		ReadingNumCodeLengthCodes,
		// Token: 0x04000327 RID: 807
		ReadingCodeLengthCodes,
		// Token: 0x04000328 RID: 808
		ReadingTreeCodesBefore,
		// Token: 0x04000329 RID: 809
		ReadingTreeCodesAfter,
		// Token: 0x0400032A RID: 810
		DecodeTop,
		// Token: 0x0400032B RID: 811
		HaveInitialLength,
		// Token: 0x0400032C RID: 812
		HaveFullLength,
		// Token: 0x0400032D RID: 813
		HaveDistCode,
		// Token: 0x0400032E RID: 814
		UncompressedAligning = 15,
		// Token: 0x0400032F RID: 815
		UncompressedByte1,
		// Token: 0x04000330 RID: 816
		UncompressedByte2,
		// Token: 0x04000331 RID: 817
		UncompressedByte3,
		// Token: 0x04000332 RID: 818
		UncompressedByte4,
		// Token: 0x04000333 RID: 819
		DecodingUncompressed,
		// Token: 0x04000334 RID: 820
		StartReadingFooter,
		// Token: 0x04000335 RID: 821
		ReadingFooter,
		// Token: 0x04000336 RID: 822
		VerifyingFooter,
		// Token: 0x04000337 RID: 823
		Done
	}
}
