using System;

namespace SpecialFeatures.Flashport.FlashkeyLib
{
	// Token: 0x020000FC RID: 252
	internal static class Definitions
	{
		// Token: 0x0400075C RID: 1884
		internal const int FLASHCODE_LAYOUT_VERSION = 2;

		// Token: 0x0400075D RID: 1885
		internal const int LAYOUT_VERSION_NEW_MODEL = 3;

		// Token: 0x0400075E RID: 1886
		internal const int EXPANDED_FLASHCODE_STRING_VERSION = 4;

		// Token: 0x0400075F RID: 1887
		internal const byte MSB1 = 128;

		// Token: 0x04000760 RID: 1888
		internal const string REFRESHMODEL = "R00RRR0RR0RRRR0R";

		// Token: 0x04000761 RID: 1889
		internal const int FORMATTED_FLASHCODE_SIZE = 15;

		// Token: 0x04000762 RID: 1890
		internal const int FLASHCODE_MAPSIZE = 64;

		// Token: 0x04000763 RID: 1891
		internal const int KEYSERNOSIZE = 8;

		// Token: 0x04000764 RID: 1892
		internal const int MAXFKEYSIZE = 256;

		// Token: 0x04000765 RID: 1893
		internal const string FlashkeyFile = "MOTF.000";

		// Token: 0x04000766 RID: 1894
		internal const int DATA_START_PAGE = 8;

		// Token: 0x04000767 RID: 1895
		internal const short FAMILY1994 = 4;

		// Token: 0x04000768 RID: 1896
		internal const short FAMILY1963 = 24;
	}
}
