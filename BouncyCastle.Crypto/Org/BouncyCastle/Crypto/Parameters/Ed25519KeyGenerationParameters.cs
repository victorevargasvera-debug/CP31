using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003DD RID: 989
	public class Ed25519KeyGenerationParameters : global::Org.BouncyCastle.Crypto.KeyGenerationParameters
	{
		// Token: 0x060027A4 RID: 10148 RVA: 0x000AB4BC File Offset: 0x000A96BC
		public Ed25519KeyGenerationParameters(global::Org.BouncyCastle.Security.SecureRandom random) : base(random, 256)
		{
		}
	}
}
