using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x0200040E RID: 1038
	public class X25519KeyGenerationParameters : global::Org.BouncyCastle.Crypto.KeyGenerationParameters
	{
		// Token: 0x0600289E RID: 10398 RVA: 0x000AD1A4 File Offset: 0x000AB3A4
		public X25519KeyGenerationParameters(global::Org.BouncyCastle.Security.SecureRandom random) : base(random, 255)
		{
		}
	}
}
