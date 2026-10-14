using System;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005A9 RID: 1449
	public abstract class PgpKeyFlags
	{
		// Token: 0x040018B1 RID: 6321
		public const int CanCertify = 1;

		// Token: 0x040018B2 RID: 6322
		public const int CanSign = 2;

		// Token: 0x040018B3 RID: 6323
		public const int CanEncryptCommunications = 4;

		// Token: 0x040018B4 RID: 6324
		public const int CanEncryptStorage = 8;

		// Token: 0x040018B5 RID: 6325
		public const int MaybeSplit = 16;

		// Token: 0x040018B6 RID: 6326
		public const int MaybeShared = 128;
	}
}
