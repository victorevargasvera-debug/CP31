using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002E7 RID: 743
	public class KeyGenerationParameters
	{
		// Token: 0x06001FDF RID: 8159 RVA: 0x000900F4 File Offset: 0x0008E2F4
		public KeyGenerationParameters(global::Org.BouncyCastle.Security.SecureRandom random, int strength)
		{
			if (random == null)
			{
				throw new global::System.ArgumentNullException("random");
			}
			if (strength < 1)
			{
				throw new global::System.ArgumentException("strength must be a positive value", "strength");
			}
			this.random = random;
			this.strength = strength;
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x0009012C File Offset: 0x0008E32C
		public global::Org.BouncyCastle.Security.SecureRandom Random
		{
			get
			{
				return this.random;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x00090134 File Offset: 0x0008E334
		public int Strength
		{
			get
			{
				return this.strength;
			}
		}

		// Token: 0x04000B2F RID: 2863
		private global::Org.BouncyCastle.Security.SecureRandom random;

		// Token: 0x04000B30 RID: 2864
		private int strength;
	}
}
