using System;

namespace AcpCryptoLib
{
	// Token: 0x0200000B RID: 11
	internal abstract class AcpCryptoHeaderBase
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000019 RID: 25
		internal abstract byte[] Data { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001A RID: 26
		internal abstract object Key { get; }
	}
}
