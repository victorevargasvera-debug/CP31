using System;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001E4 RID: 484
	public abstract class OcspRespStatus
	{
		// Token: 0x040008F3 RID: 2291
		public const int Successful = 0;

		// Token: 0x040008F4 RID: 2292
		public const int MalformedRequest = 1;

		// Token: 0x040008F5 RID: 2293
		public const int InternalError = 2;

		// Token: 0x040008F6 RID: 2294
		public const int TryLater = 3;

		// Token: 0x040008F7 RID: 2295
		public const int SigRequired = 5;

		// Token: 0x040008F8 RID: 2296
		public const int Unauthorized = 6;
	}
}
