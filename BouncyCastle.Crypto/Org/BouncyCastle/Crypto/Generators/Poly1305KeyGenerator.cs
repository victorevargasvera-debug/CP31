using System;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000480 RID: 1152
	public class Poly1305KeyGenerator : global::Org.BouncyCastle.Crypto.CipherKeyGenerator
	{
		// Token: 0x06002C32 RID: 11314 RVA: 0x000BEDA7 File Offset: 0x000BCFA7
		protected override void engineInit(global::Org.BouncyCastle.Crypto.KeyGenerationParameters param)
		{
			this.random = param.Random;
			this.strength = 32;
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000BEDBD File Offset: 0x000BCFBD
		protected override byte[] engineGenerateKey()
		{
			byte[] array = base.engineGenerateKey();
			global::Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.Clamp(array);
			return array;
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x000BEDCC File Offset: 0x000BCFCC
		public static void Clamp(byte[] key)
		{
			if (key.Length != 32)
			{
				throw new global::System.ArgumentException("Poly1305 key must be 256 bits.");
			}
			int num = 3;
			key[num] &= 15;
			int num2 = 7;
			key[num2] &= 15;
			int num3 = 11;
			key[num3] &= 15;
			int num4 = 15;
			key[num4] &= 15;
			int num5 = 4;
			key[num5] &= 252;
			int num6 = 8;
			key[num6] &= 252;
			int num7 = 12;
			key[num7] &= 252;
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x000BEE5C File Offset: 0x000BD05C
		public static void CheckKey(byte[] key)
		{
			if (key.Length != 32)
			{
				throw new global::System.ArgumentException("Poly1305 key must be 256 bits.");
			}
			global::Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(key[3], 15);
			global::Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(key[7], 15);
			global::Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(key[11], 15);
			global::Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(key[15], 15);
			global::Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(key[4], 252);
			global::Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(key[8], 252);
			global::Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(key[12], 252);
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x000BEECD File Offset: 0x000BD0CD
		private static void CheckMask(byte b, byte mask)
		{
			if ((b & ~(mask != 0)) != 0)
			{
				throw new global::System.ArgumentException("Invalid format for r portion of Poly1305 key.");
			}
		}

		// Token: 0x0400126E RID: 4718
		private const byte R_MASK_LOW_2 = 252;

		// Token: 0x0400126F RID: 4719
		private const byte R_MASK_HIGH_4 = 15;
	}
}
