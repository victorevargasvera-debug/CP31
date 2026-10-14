using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003E3 RID: 995
	public class ElGamalKeyGenerationParameters : global::Org.BouncyCastle.Crypto.KeyGenerationParameters
	{
		// Token: 0x060027CA RID: 10186 RVA: 0x000ABAD6 File Offset: 0x000A9CD6
		public ElGamalKeyGenerationParameters(global::Org.BouncyCastle.Security.SecureRandom random, global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters) : base(random, global::Org.BouncyCastle.Crypto.Parameters.ElGamalKeyGenerationParameters.GetStrength(parameters))
		{
			this.parameters = parameters;
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060027CB RID: 10187 RVA: 0x000ABAEC File Offset: 0x000A9CEC
		public global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x000ABAF4 File Offset: 0x000A9CF4
		internal static int GetStrength(global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters)
		{
			if (parameters.L == 0)
			{
				return parameters.P.BitLength;
			}
			return parameters.L;
		}

		// Token: 0x0400101B RID: 4123
		private readonly global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters;
	}
}
