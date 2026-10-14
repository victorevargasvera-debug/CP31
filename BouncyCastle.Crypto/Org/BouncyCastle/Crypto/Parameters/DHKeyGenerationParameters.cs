using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003C9 RID: 969
	public class DHKeyGenerationParameters : global::Org.BouncyCastle.Crypto.KeyGenerationParameters
	{
		// Token: 0x06002710 RID: 10000 RVA: 0x000AA260 File Offset: 0x000A8460
		public DHKeyGenerationParameters(global::Org.BouncyCastle.Security.SecureRandom random, global::Org.BouncyCastle.Crypto.Parameters.DHParameters parameters) : base(random, global::Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters.GetStrength(parameters))
		{
			this.parameters = parameters;
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x000AA276 File Offset: 0x000A8476
		public global::Org.BouncyCastle.Crypto.Parameters.DHParameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x000AA27E File Offset: 0x000A847E
		internal static int GetStrength(global::Org.BouncyCastle.Crypto.Parameters.DHParameters parameters)
		{
			if (parameters.L == 0)
			{
				return parameters.P.BitLength;
			}
			return parameters.L;
		}

		// Token: 0x04000FDC RID: 4060
		private readonly global::Org.BouncyCastle.Crypto.Parameters.DHParameters parameters;
	}
}
