using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003E0 RID: 992
	public class Ed448KeyGenerationParameters : global::Org.BouncyCastle.Crypto.KeyGenerationParameters
	{
		// Token: 0x060027B7 RID: 10167 RVA: 0x000AB7E2 File Offset: 0x000A99E2
		public Ed448KeyGenerationParameters(global::Org.BouncyCastle.Security.SecureRandom random) : base(random, 448)
		{
		}
	}
}
