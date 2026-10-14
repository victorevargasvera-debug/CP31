using System;

namespace Ionic.Zip
{
	// Token: 0x02000462 RID: 1122
	internal static class ZipConstants
	{
		// Token: 0x040011A6 RID: 4518
		public const uint PackedToRemovableMedia = 808471376U;

		// Token: 0x040011A7 RID: 4519
		public const uint Zip64EndOfCentralDirectoryRecordSignature = 101075792U;

		// Token: 0x040011A8 RID: 4520
		public const uint Zip64EndOfCentralDirectoryLocatorSignature = 117853008U;

		// Token: 0x040011A9 RID: 4521
		public const uint EndOfCentralDirectorySignature = 101010256U;

		// Token: 0x040011AA RID: 4522
		public const int ZipEntrySignature = 67324752;

		// Token: 0x040011AB RID: 4523
		public const int ZipEntryDataDescriptorSignature = 134695760;

		// Token: 0x040011AC RID: 4524
		public const int SplitArchiveSignature = 134695760;

		// Token: 0x040011AD RID: 4525
		public const int ZipDirEntrySignature = 33639248;

		// Token: 0x040011AE RID: 4526
		public const int AesKeySize = 192;

		// Token: 0x040011AF RID: 4527
		public const int AesBlockSize = 128;

		// Token: 0x040011B0 RID: 4528
		public const ushort AesAlgId128 = 26126;

		// Token: 0x040011B1 RID: 4529
		public const ushort AesAlgId192 = 26127;

		// Token: 0x040011B2 RID: 4530
		public const ushort AesAlgId256 = 26128;
	}
}
