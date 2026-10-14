using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000E3 RID: 227
	public abstract class RecordFormat
	{
		// Token: 0x0400062F RID: 1583
		public const int TypeOffset = 0;

		// Token: 0x04000630 RID: 1584
		public const int VersionOffset = 1;

		// Token: 0x04000631 RID: 1585
		public const int LengthOffset = 3;

		// Token: 0x04000632 RID: 1586
		public const int FragmentOffset = 5;
	}
}
