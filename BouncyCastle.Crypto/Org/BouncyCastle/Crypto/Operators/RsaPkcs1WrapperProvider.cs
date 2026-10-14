using System;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x02000425 RID: 1061
	internal class RsaPkcs1WrapperProvider : global::Org.BouncyCastle.Crypto.Operators.WrapperProvider
	{
		// Token: 0x06002913 RID: 10515 RVA: 0x000AE2FA File Offset: 0x000AC4FA
		internal RsaPkcs1WrapperProvider()
		{
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000AE302 File Offset: 0x000AC502
		object global::Org.BouncyCastle.Crypto.Operators.WrapperProvider.CreateWrapper(bool forWrapping, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			return new global::Org.BouncyCastle.Crypto.Operators.RsaPkcs1Wrapper(forWrapping, parameters);
		}
	}
}
