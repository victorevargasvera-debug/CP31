using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003CF RID: 975
	public class DsaKeyGenerationParameters : global::Org.BouncyCastle.Crypto.KeyGenerationParameters
	{
		// Token: 0x0600273F RID: 10047 RVA: 0x000AA8FF File Offset: 0x000A8AFF
		public DsaKeyGenerationParameters(global::Org.BouncyCastle.Security.SecureRandom random, global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters) : base(random, parameters.P.BitLength - 1)
		{
			this.parameters = parameters;
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x000AA91C File Offset: 0x000A8B1C
		public global::Org.BouncyCastle.Crypto.Parameters.DsaParameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x04000FEB RID: 4075
		private readonly global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters;
	}
}
