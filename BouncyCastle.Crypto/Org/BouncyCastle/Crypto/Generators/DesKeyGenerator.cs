using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000464 RID: 1124
	public class DesKeyGenerator : global::Org.BouncyCastle.Crypto.CipherKeyGenerator
	{
		// Token: 0x06002B97 RID: 11159 RVA: 0x000BAE71 File Offset: 0x000B9071
		public DesKeyGenerator()
		{
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x000BAE79 File Offset: 0x000B9079
		internal DesKeyGenerator(int defaultStrength) : base(defaultStrength)
		{
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x000BAE84 File Offset: 0x000B9084
		protected override void engineInit(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			base.engineInit(parameters);
			if (this.strength == 0 || this.strength == 7)
			{
				this.strength = 8;
				return;
			}
			if (this.strength != 8)
			{
				throw new global::System.ArgumentException("DES key must be " + 64.ToString() + " bits long.");
			}
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x000BAEDC File Offset: 0x000B90DC
		protected override byte[] engineGenerateKey()
		{
			byte[] newKey = new byte[8];
			do
			{
				this.random.NextBytes(newKey);
				global::Org.BouncyCastle.Crypto.Parameters.DesParameters.SetOddParity(newKey);
			}
			while (global::Org.BouncyCastle.Crypto.Parameters.DesParameters.IsWeakKey(newKey, 0));
			return newKey;
		}
	}
}
