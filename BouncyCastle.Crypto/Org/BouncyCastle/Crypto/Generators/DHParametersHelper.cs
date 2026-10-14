using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000469 RID: 1129
	internal class DHParametersHelper
	{
		// Token: 0x06002BA8 RID: 11176 RVA: 0x000BB0FC File Offset: 0x000B92FC
		private static global::Org.BouncyCastle.Math.BigInteger[] ConstructBigPrimeProducts(int[] primeProducts)
		{
			global::Org.BouncyCastle.Math.BigInteger[] bpp = new global::Org.BouncyCastle.Math.BigInteger[primeProducts.Length];
			for (int i = 0; i < bpp.Length; i++)
			{
				bpp[i] = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)primeProducts[i]);
			}
			return bpp;
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x000BB130 File Offset: 0x000B9330
		internal static global::Org.BouncyCastle.Math.BigInteger[] GenerateSafePrimes(int size, int certainty, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			int qLength = size - 1;
			int minWeight = size >> 2;
			global::Org.BouncyCastle.Math.BigInteger q;
			global::Org.BouncyCastle.Math.BigInteger p;
			if (size <= 32)
			{
				for (;;)
				{
					q = new global::Org.BouncyCastle.Math.BigInteger(qLength, 2, random);
					p = q.ShiftLeft(1).Add(global::Org.BouncyCastle.Math.BigInteger.One);
					if (p.IsProbablePrime(certainty, true))
					{
						if (certainty <= 2 || q.IsProbablePrime(certainty, true))
						{
							break;
						}
					}
				}
			}
			else
			{
				for (;;)
				{
					q = new global::Org.BouncyCastle.Math.BigInteger(qLength, 0, random);
					for (;;)
					{
						IL_51:
						for (int i = 0; i < global::Org.BouncyCastle.Crypto.Generators.DHParametersHelper.primeLists.Length; i++)
						{
							int test = q.Remainder(global::Org.BouncyCastle.Crypto.Generators.DHParametersHelper.BigPrimeProducts[i]).IntValue;
							if (i == 0)
							{
								int rem3 = test % 3;
								if (rem3 != 2)
								{
									int diff = 2 * rem3 + 2;
									q = q.Add(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)diff));
									test = (test + diff) % global::Org.BouncyCastle.Crypto.Generators.DHParametersHelper.primeProducts[i];
								}
							}
							foreach (int prime in global::Org.BouncyCastle.Crypto.Generators.DHParametersHelper.primeLists[i])
							{
								int qRem = test % prime;
								if (qRem == 0 || qRem == prime >> 1)
								{
									q = q.Add(global::Org.BouncyCastle.Crypto.Generators.DHParametersHelper.Six);
									goto IL_51;
								}
							}
						}
						break;
					}
					if (q.BitLength == qLength && q.RabinMillerTest(2, random, true))
					{
						p = q.ShiftLeft(1).Add(global::Org.BouncyCastle.Math.BigInteger.One);
						if (p.RabinMillerTest(certainty, random, true) && (certainty <= 2 || q.RabinMillerTest(certainty - 2, random, true)) && global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetNafWeight(p) >= minWeight)
						{
							break;
						}
					}
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger[]
			{
				p,
				q
			};
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x000BB2A8 File Offset: 0x000B94A8
		internal static global::Org.BouncyCastle.Math.BigInteger SelectGenerator(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			global::Org.BouncyCastle.Math.BigInteger pMinusTwo = p.Subtract(global::Org.BouncyCastle.Math.BigInteger.Two);
			global::Org.BouncyCastle.Math.BigInteger g;
			do
			{
				g = global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(global::Org.BouncyCastle.Math.BigInteger.Two, pMinusTwo, random).ModPow(global::Org.BouncyCastle.Math.BigInteger.Two, p);
			}
			while (g.Equals(global::Org.BouncyCastle.Math.BigInteger.One));
			return g;
		}

		// Token: 0x0400121B RID: 4635
		private static readonly global::Org.BouncyCastle.Math.BigInteger Six = global::Org.BouncyCastle.Math.BigInteger.ValueOf(6L);

		// Token: 0x0400121C RID: 4636
		private static readonly int[][] primeLists = global::Org.BouncyCastle.Math.BigInteger.primeLists;

		// Token: 0x0400121D RID: 4637
		private static readonly int[] primeProducts = global::Org.BouncyCastle.Math.BigInteger.primeProducts;

		// Token: 0x0400121E RID: 4638
		private static readonly global::Org.BouncyCastle.Math.BigInteger[] BigPrimeProducts = global::Org.BouncyCastle.Crypto.Generators.DHParametersHelper.ConstructBigPrimeProducts(global::Org.BouncyCastle.Crypto.Generators.DHParametersHelper.primeProducts);
	}
}
