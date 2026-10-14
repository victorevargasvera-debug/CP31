using System;

namespace NPOI.POIFS.Common
{
	// Token: 0x020002A0 RID: 672
	public class POIFSConstants
	{
		// Token: 0x04000792 RID: 1938
		public const int SMALLER_BIG_BLOCK_SIZE = 512;

		// Token: 0x04000793 RID: 1939
		public static readonly global::NPOI.POIFS.Common.POIFSBigBlockSize SMALLER_BIG_BLOCK_SIZE_DETAILS = new global::NPOI.POIFS.Common.POIFSBigBlockSize(512, 9);

		// Token: 0x04000794 RID: 1940
		public const int LARGER_BIG_BLOCK_SIZE = 4096;

		// Token: 0x04000795 RID: 1941
		public static readonly global::NPOI.POIFS.Common.POIFSBigBlockSize LARGER_BIG_BLOCK_SIZE_DETAILS = new global::NPOI.POIFS.Common.POIFSBigBlockSize(4096, 12);

		// Token: 0x04000796 RID: 1942
		public const int BIG_BLOCK_SIZE = 512;

		// Token: 0x04000797 RID: 1943
		public const int MINI_BLOCK_SIZE = 64;

		// Token: 0x04000798 RID: 1944
		public const int SMALL_BLOCK_SIZE = 64;

		// Token: 0x04000799 RID: 1945
		public const int PROPERTY_SIZE = 128;

		// Token: 0x0400079A RID: 1946
		public const int BIG_BLOCK_MINIMUM_DOCUMENT_SIZE = 4096;

		// Token: 0x0400079B RID: 1947
		public const int LARGEST_REGULAR_SECTOR_NUMBER = -5;

		// Token: 0x0400079C RID: 1948
		public const int FAT_SECTOR_BLOCK = -3;

		// Token: 0x0400079D RID: 1949
		public const int DIFAT_SECTOR_BLOCK = -4;

		// Token: 0x0400079E RID: 1950
		public const int END_OF_CHAIN = -2;

		// Token: 0x0400079F RID: 1951
		public const int UNUSED_BLOCK = -1;

		// Token: 0x040007A0 RID: 1952
		public static readonly byte[] OOXML_FILE_HEADER = new byte[]
		{
			80,
			75,
			3,
			4
		};

		// Token: 0x040007A1 RID: 1953
		public static readonly byte[] RAW_XML_FILE_HEADER = new byte[]
		{
			60,
			63,
			120,
			109,
			108
		};
	}
}
