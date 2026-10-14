using System;

namespace Ionic.Zip
{
	// Token: 0x02000047 RID: 71
	internal static class ZipConstants
	{
		// Token: 0x04000220 RID: 544
		public const uint PackedToRemovableMedia = 808471376U;

		// Token: 0x04000221 RID: 545
		public const uint Zip64EndOfCentralDirectoryRecordSignature = 101075792U;

		// Token: 0x04000222 RID: 546
		public const uint Zip64EndOfCentralDirectoryLocatorSignature = 117853008U;

		// Token: 0x04000223 RID: 547
		public const uint EndOfCentralDirectorySignature = 101010256U;

		// Token: 0x04000224 RID: 548
		public const int ZipEntrySignature = 67324752;

		// Token: 0x04000225 RID: 549
		public const int ZipEntryDataDescriptorSignature = 134695760;

		// Token: 0x04000226 RID: 550
		public const int SplitArchiveSignature = 134695760;

		// Token: 0x04000227 RID: 551
		public const int ZipDirEntrySignature = 33639248;

		// Token: 0x04000228 RID: 552
		public const int AesKeySize = 192;

		// Token: 0x04000229 RID: 553
		public const int AesBlockSize = 128;

		// Token: 0x0400022A RID: 554
		public const ushort AesAlgId128 = 26126;

		// Token: 0x0400022B RID: 555
		public const ushort AesAlgId192 = 26127;

		// Token: 0x0400022C RID: 556
		public const ushort AesAlgId256 = 26128;
	}
}
