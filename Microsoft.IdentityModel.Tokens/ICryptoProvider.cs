using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000022 RID: 34
	public interface ICryptoProvider
	{
		// Token: 0x060000CE RID: 206
		bool IsSupportedAlgorithm(string algorithm, params object[] args);

		// Token: 0x060000CF RID: 207
		object Create(string algorithm, params object[] args);

		// Token: 0x060000D0 RID: 208
		void Release(object cryptoInstance);
	}
}
