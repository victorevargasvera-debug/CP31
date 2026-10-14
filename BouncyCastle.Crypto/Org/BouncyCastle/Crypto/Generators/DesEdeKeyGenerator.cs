using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000463 RID: 1123
	public class DesEdeKeyGenerator : global::Org.BouncyCastle.Crypto.Generators.DesKeyGenerator
	{
		// Token: 0x06002B93 RID: 11155 RVA: 0x000BAD6A File Offset: 0x000B8F6A
		public DesEdeKeyGenerator()
		{
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x000BAD72 File Offset: 0x000B8F72
		internal DesEdeKeyGenerator(int defaultStrength) : base(defaultStrength)
		{
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x000BAD7C File Offset: 0x000B8F7C
		protected override void engineInit(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			this.random = parameters.Random;
			this.strength = (parameters.Strength + 7) / 8;
			if (this.strength == 0 || this.strength == 21)
			{
				this.strength = 24;
				return;
			}
			if (this.strength == 14)
			{
				this.strength = 16;
				return;
			}
			if (this.strength != 24 && this.strength != 16)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"DESede key must be ",
					192.ToString(),
					" or ",
					128.ToString(),
					" bits long."
				}));
			}
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x000BAE30 File Offset: 0x000B9030
		protected override byte[] engineGenerateKey()
		{
			byte[] newKey = new byte[this.strength];
			do
			{
				this.random.NextBytes(newKey);
				global::Org.BouncyCastle.Crypto.Parameters.DesParameters.SetOddParity(newKey);
			}
			while (global::Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.IsWeakKey(newKey, 0, newKey.Length) || !global::Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.IsRealEdeKey(newKey, 0));
			return newKey;
		}
	}
}
