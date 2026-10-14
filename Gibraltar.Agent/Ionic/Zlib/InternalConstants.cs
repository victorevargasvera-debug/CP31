using System;

namespace Ionic.Zlib
{
	// Token: 0x02000439 RID: 1081
	internal static class InternalConstants
	{
		// Token: 0x0400109B RID: 4251
		internal static readonly int MAX_BITS = 15;

		// Token: 0x0400109C RID: 4252
		internal static readonly int BL_CODES = 19;

		// Token: 0x0400109D RID: 4253
		internal static readonly int D_CODES = 30;

		// Token: 0x0400109E RID: 4254
		internal static readonly int LITERALS = 256;

		// Token: 0x0400109F RID: 4255
		internal static readonly int LENGTH_CODES = 29;

		// Token: 0x040010A0 RID: 4256
		internal static readonly int L_CODES = global::Ionic.Zlib.InternalConstants.LITERALS + 1 + global::Ionic.Zlib.InternalConstants.LENGTH_CODES;

		// Token: 0x040010A1 RID: 4257
		internal static readonly int MAX_BL_BITS = 7;

		// Token: 0x040010A2 RID: 4258
		internal static readonly int REP_3_6 = 16;

		// Token: 0x040010A3 RID: 4259
		internal static readonly int REPZ_3_10 = 17;

		// Token: 0x040010A4 RID: 4260
		internal static readonly int REPZ_11_138 = 18;
	}
}
