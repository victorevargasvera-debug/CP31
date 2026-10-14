using System;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x02000423 RID: 1059
	internal interface WrapperProvider
	{
		// Token: 0x0600290E RID: 10510
		object CreateWrapper(bool forWrapping, global::Org.BouncyCastle.Crypto.ICipherParameters parameters);
	}
}
