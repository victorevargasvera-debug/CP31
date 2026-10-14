using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math
{
	// Token: 0x020001ED RID: 493
	public abstract class Primes
	{
		// Token: 0x06001274 RID: 4724 RVA: 0x000532B0 File Offset: 0x000514B0
		public static global::Org.BouncyCastle.Math.Primes.STOutput GenerateSTRandomPrime(global::Org.BouncyCastle.Crypto.IDigest hash, int length, byte[] inputSeed)
		{
			if (hash == null)
			{
				throw new global::System.ArgumentNullException("hash");
			}
			if (length < 2)
			{
				throw new global::System.ArgumentException("must be >= 2", "length");
			}
			if (inputSeed == null)
			{
				throw new global::System.ArgumentNullException("inputSeed");
			}
			if (inputSeed.Length == 0)
			{
				throw new global::System.ArgumentException("cannot be empty", "inputSeed");
			}
			return global::Org.BouncyCastle.Math.Primes.ImplSTRandomPrime(hash, length, global::Org.BouncyCastle.Utilities.Arrays.Clone(inputSeed));
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00053310 File Offset: 0x00051510
		public static global::Org.BouncyCastle.Math.Primes.MROutput EnhancedMRProbablePrimeTest(global::Org.BouncyCastle.Math.BigInteger candidate, global::Org.BouncyCastle.Security.SecureRandom random, int iterations)
		{
			global::Org.BouncyCastle.Math.Primes.CheckCandidate(candidate, "candidate");
			if (random == null)
			{
				throw new global::System.ArgumentNullException("random");
			}
			if (iterations < 1)
			{
				throw new global::System.ArgumentException("must be > 0", "iterations");
			}
			if (candidate.BitLength == 2)
			{
				return global::Org.BouncyCastle.Math.Primes.MROutput.ProbablyPrime();
			}
			if (!candidate.TestBit(0))
			{
				return global::Org.BouncyCastle.Math.Primes.MROutput.ProvablyCompositeWithFactor(global::Org.BouncyCastle.Math.Primes.Two);
			}
			global::Org.BouncyCastle.Math.BigInteger wSubOne = candidate.Subtract(global::Org.BouncyCastle.Math.Primes.One);
			global::Org.BouncyCastle.Math.BigInteger wSubTwo = candidate.Subtract(global::Org.BouncyCastle.Math.Primes.Two);
			int a = wSubOne.GetLowestSetBit();
			global::Org.BouncyCastle.Math.BigInteger i = wSubOne.ShiftRight(a);
			for (int j = 0; j < iterations; j++)
			{
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(global::Org.BouncyCastle.Math.Primes.Two, wSubTwo, random);
				global::Org.BouncyCastle.Math.BigInteger g = b.Gcd(candidate);
				if (g.CompareTo(global::Org.BouncyCastle.Math.Primes.One) > 0)
				{
					return global::Org.BouncyCastle.Math.Primes.MROutput.ProvablyCompositeWithFactor(g);
				}
				global::Org.BouncyCastle.Math.BigInteger z = b.ModPow(i, candidate);
				if (!z.Equals(global::Org.BouncyCastle.Math.Primes.One) && !z.Equals(wSubOne))
				{
					bool primeToBase = false;
					global::Org.BouncyCastle.Math.BigInteger x = z;
					for (int k = 1; k < a; k++)
					{
						z = z.ModPow(global::Org.BouncyCastle.Math.Primes.Two, candidate);
						if (z.Equals(wSubOne))
						{
							primeToBase = true;
							break;
						}
						if (z.Equals(global::Org.BouncyCastle.Math.Primes.One))
						{
							break;
						}
						x = z;
					}
					if (!primeToBase)
					{
						if (!z.Equals(global::Org.BouncyCastle.Math.Primes.One))
						{
							x = z;
							z = z.ModPow(global::Org.BouncyCastle.Math.Primes.Two, candidate);
							if (!z.Equals(global::Org.BouncyCastle.Math.Primes.One))
							{
								x = z;
							}
						}
						g = x.Subtract(global::Org.BouncyCastle.Math.Primes.One).Gcd(candidate);
						if (g.CompareTo(global::Org.BouncyCastle.Math.Primes.One) > 0)
						{
							return global::Org.BouncyCastle.Math.Primes.MROutput.ProvablyCompositeWithFactor(g);
						}
						return global::Org.BouncyCastle.Math.Primes.MROutput.ProvablyCompositeNotPrimePower();
					}
				}
			}
			return global::Org.BouncyCastle.Math.Primes.MROutput.ProbablyPrime();
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x000534BA File Offset: 0x000516BA
		public static bool HasAnySmallFactors(global::Org.BouncyCastle.Math.BigInteger candidate)
		{
			global::Org.BouncyCastle.Math.Primes.CheckCandidate(candidate, "candidate");
			return global::Org.BouncyCastle.Math.Primes.ImplHasAnySmallFactors(candidate);
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x000534D0 File Offset: 0x000516D0
		public static bool IsMRProbablePrime(global::Org.BouncyCastle.Math.BigInteger candidate, global::Org.BouncyCastle.Security.SecureRandom random, int iterations)
		{
			global::Org.BouncyCastle.Math.Primes.CheckCandidate(candidate, "candidate");
			if (random == null)
			{
				throw new global::System.ArgumentException("cannot be null", "random");
			}
			if (iterations < 1)
			{
				throw new global::System.ArgumentException("must be > 0", "iterations");
			}
			if (candidate.BitLength == 2)
			{
				return true;
			}
			if (!candidate.TestBit(0))
			{
				return false;
			}
			global::Org.BouncyCastle.Math.BigInteger wSubOne = candidate.Subtract(global::Org.BouncyCastle.Math.Primes.One);
			global::Org.BouncyCastle.Math.BigInteger wSubTwo = candidate.Subtract(global::Org.BouncyCastle.Math.Primes.Two);
			int a = wSubOne.GetLowestSetBit();
			global::Org.BouncyCastle.Math.BigInteger i = wSubOne.ShiftRight(a);
			for (int j = 0; j < iterations; j++)
			{
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(global::Org.BouncyCastle.Math.Primes.Two, wSubTwo, random);
				if (!global::Org.BouncyCastle.Math.Primes.ImplMRProbablePrimeToBase(candidate, wSubOne, i, a, b))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00053580 File Offset: 0x00051780
		public static bool IsMRProbablePrimeToBase(global::Org.BouncyCastle.Math.BigInteger candidate, global::Org.BouncyCastle.Math.BigInteger baseValue)
		{
			global::Org.BouncyCastle.Math.Primes.CheckCandidate(candidate, "candidate");
			global::Org.BouncyCastle.Math.Primes.CheckCandidate(baseValue, "baseValue");
			if (baseValue.CompareTo(candidate.Subtract(global::Org.BouncyCastle.Math.Primes.One)) >= 0)
			{
				throw new global::System.ArgumentException("must be < ('candidate' - 1)", "baseValue");
			}
			if (candidate.BitLength == 2)
			{
				return true;
			}
			global::Org.BouncyCastle.Math.BigInteger wSubOne = candidate.Subtract(global::Org.BouncyCastle.Math.Primes.One);
			int a = wSubOne.GetLowestSetBit();
			global::Org.BouncyCastle.Math.BigInteger i = wSubOne.ShiftRight(a);
			return global::Org.BouncyCastle.Math.Primes.ImplMRProbablePrimeToBase(candidate, wSubOne, i, a, baseValue);
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x000535F7 File Offset: 0x000517F7
		private static void CheckCandidate(global::Org.BouncyCastle.Math.BigInteger n, string name)
		{
			if (n == null || n.SignValue < 1 || n.BitLength < 2)
			{
				throw new global::System.ArgumentException("must be non-null and >= 2", name);
			}
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0005361C File Offset: 0x0005181C
		private static bool ImplHasAnySmallFactors(global::Org.BouncyCastle.Math.BigInteger x)
		{
			int i = 223092870;
			int r = x.Mod(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)i)).IntValue;
			if (r % 2 == 0 || r % 3 == 0 || r % 5 == 0 || r % 7 == 0 || r % 11 == 0 || r % 13 == 0 || r % 17 == 0 || r % 19 == 0 || r % 23 == 0)
			{
				return true;
			}
			i = 58642669;
			r = x.Mod(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)i)).IntValue;
			if (r % 29 == 0 || r % 31 == 0 || r % 37 == 0 || r % 41 == 0 || r % 43 == 0)
			{
				return true;
			}
			i = 600662303;
			r = x.Mod(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)i)).IntValue;
			if (r % 47 == 0 || r % 53 == 0 || r % 59 == 0 || r % 61 == 0 || r % 67 == 0)
			{
				return true;
			}
			i = 33984931;
			r = x.Mod(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)i)).IntValue;
			if (r % 71 == 0 || r % 73 == 0 || r % 79 == 0 || r % 83 == 0)
			{
				return true;
			}
			i = 89809099;
			r = x.Mod(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)i)).IntValue;
			if (r % 89 == 0 || r % 97 == 0 || r % 101 == 0 || r % 103 == 0)
			{
				return true;
			}
			i = 167375713;
			r = x.Mod(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)i)).IntValue;
			if (r % 107 == 0 || r % 109 == 0 || r % 113 == 0 || r % 127 == 0)
			{
				return true;
			}
			i = 371700317;
			r = x.Mod(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)i)).IntValue;
			if (r % 131 == 0 || r % 137 == 0 || r % 139 == 0 || r % 149 == 0)
			{
				return true;
			}
			i = 645328247;
			r = x.Mod(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)i)).IntValue;
			if (r % 151 == 0 || r % 157 == 0 || r % 163 == 0 || r % 167 == 0)
			{
				return true;
			}
			i = 1070560157;
			r = x.Mod(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)i)).IntValue;
			if (r % 173 == 0 || r % 179 == 0 || r % 181 == 0 || r % 191 == 0)
			{
				return true;
			}
			i = 1596463769;
			r = x.Mod(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)i)).IntValue;
			return r % 193 == 0 || r % 197 == 0 || r % 199 == 0 || r % 211 == 0;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00053880 File Offset: 0x00051A80
		private static bool ImplMRProbablePrimeToBase(global::Org.BouncyCastle.Math.BigInteger w, global::Org.BouncyCastle.Math.BigInteger wSubOne, global::Org.BouncyCastle.Math.BigInteger m, int a, global::Org.BouncyCastle.Math.BigInteger b)
		{
			global::Org.BouncyCastle.Math.BigInteger z = b.ModPow(m, w);
			if (z.Equals(global::Org.BouncyCastle.Math.Primes.One) || z.Equals(wSubOne))
			{
				return true;
			}
			bool result = false;
			for (int i = 1; i < a; i++)
			{
				z = z.ModPow(global::Org.BouncyCastle.Math.Primes.Two, w);
				if (z.Equals(wSubOne))
				{
					result = true;
					break;
				}
				if (z.Equals(global::Org.BouncyCastle.Math.Primes.One))
				{
					return false;
				}
			}
			return result;
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x000538E8 File Offset: 0x00051AE8
		private static global::Org.BouncyCastle.Math.Primes.STOutput ImplSTRandomPrime(global::Org.BouncyCastle.Crypto.IDigest d, int length, byte[] primeSeed)
		{
			int dLen = d.GetDigestSize();
			if (length < 33)
			{
				int primeGenCounter = 0;
				byte[] c0 = new byte[dLen];
				byte[] c = new byte[dLen];
				uint c2;
				for (;;)
				{
					global::Org.BouncyCastle.Math.Primes.Hash(d, primeSeed, c0, 0);
					global::Org.BouncyCastle.Math.Primes.Inc(primeSeed, 1);
					global::Org.BouncyCastle.Math.Primes.Hash(d, primeSeed, c, 0);
					global::Org.BouncyCastle.Math.Primes.Inc(primeSeed, 1);
					c2 = (global::Org.BouncyCastle.Math.Primes.Extract32(c0) ^ global::Org.BouncyCastle.Math.Primes.Extract32(c));
					c2 &= uint.MaxValue >> 32 - length;
					c2 |= (1U << length - 1 | 1U);
					primeGenCounter++;
					if (global::Org.BouncyCastle.Math.Primes.IsPrime32(c2))
					{
						break;
					}
					if (primeGenCounter > 4 * length)
					{
						goto Block_3;
					}
				}
				return new global::Org.BouncyCastle.Math.Primes.STOutput(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)((ulong)c2)), primeSeed, primeGenCounter);
				Block_3:
				throw new global::System.InvalidOperationException("Too many iterations in Shawe-Taylor Random_Prime Routine");
			}
			global::Org.BouncyCastle.Math.Primes.STOutput stoutput = global::Org.BouncyCastle.Math.Primes.ImplSTRandomPrime(d, (length + 3) / 2, primeSeed);
			global::Org.BouncyCastle.Math.BigInteger c3 = stoutput.Prime;
			primeSeed = stoutput.PrimeSeed;
			int primeGenCounter2 = stoutput.PrimeGenCounter;
			int outlen = 8 * dLen;
			int iterations = (length - 1) / outlen;
			int oldCounter = primeGenCounter2;
			global::Org.BouncyCastle.Math.BigInteger bigInteger = global::Org.BouncyCastle.Math.Primes.HashGen(d, primeSeed, iterations + 1).Mod(global::Org.BouncyCastle.Math.Primes.One.ShiftLeft(length - 1)).SetBit(length - 1);
			global::Org.BouncyCastle.Math.BigInteger c0x2 = c3.ShiftLeft(1);
			global::Org.BouncyCastle.Math.BigInteger tx2 = bigInteger.Subtract(global::Org.BouncyCastle.Math.Primes.One).Divide(c0x2).Add(global::Org.BouncyCastle.Math.Primes.One).ShiftLeft(1);
			int dt = 0;
			global::Org.BouncyCastle.Math.BigInteger c4 = tx2.Multiply(c3).Add(global::Org.BouncyCastle.Math.Primes.One);
			for (;;)
			{
				if (c4.BitLength > length)
				{
					tx2 = global::Org.BouncyCastle.Math.Primes.One.ShiftLeft(length - 1).Subtract(global::Org.BouncyCastle.Math.Primes.One).Divide(c0x2).Add(global::Org.BouncyCastle.Math.Primes.One).ShiftLeft(1);
					c4 = tx2.Multiply(c3).Add(global::Org.BouncyCastle.Math.Primes.One);
				}
				primeGenCounter2++;
				if (!global::Org.BouncyCastle.Math.Primes.ImplHasAnySmallFactors(c4))
				{
					global::Org.BouncyCastle.Math.BigInteger bigInteger2 = global::Org.BouncyCastle.Math.Primes.HashGen(d, primeSeed, iterations + 1).Mod(c4.Subtract(global::Org.BouncyCastle.Math.Primes.Three)).Add(global::Org.BouncyCastle.Math.Primes.Two);
					tx2 = tx2.Add(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)dt));
					dt = 0;
					global::Org.BouncyCastle.Math.BigInteger z = bigInteger2.ModPow(tx2, c4);
					if (c4.Gcd(z.Subtract(global::Org.BouncyCastle.Math.Primes.One)).Equals(global::Org.BouncyCastle.Math.Primes.One) && z.ModPow(c3, c4).Equals(global::Org.BouncyCastle.Math.Primes.One))
					{
						break;
					}
				}
				else
				{
					global::Org.BouncyCastle.Math.Primes.Inc(primeSeed, iterations + 1);
				}
				if (primeGenCounter2 >= 4 * length + oldCounter)
				{
					goto Block_8;
				}
				dt += 2;
				c4 = c4.Add(c0x2);
			}
			return new global::Org.BouncyCastle.Math.Primes.STOutput(c4, primeSeed, primeGenCounter2);
			Block_8:
			throw new global::System.InvalidOperationException("Too many iterations in Shawe-Taylor Random_Prime Routine");
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00053B48 File Offset: 0x00051D48
		private static uint Extract32(byte[] bs)
		{
			uint result = 0U;
			int count = global::System.Math.Min(4, bs.Length);
			for (int i = 0; i < count; i++)
			{
				uint b = (uint)bs[bs.Length - (i + 1)];
				result |= b << 8 * i;
			}
			return result;
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00053B83 File Offset: 0x00051D83
		private static void Hash(global::Org.BouncyCastle.Crypto.IDigest d, byte[] input, byte[] output, int outPos)
		{
			d.BlockUpdate(input, 0, input.Length);
			d.DoFinal(output, outPos);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00053B9C File Offset: 0x00051D9C
		private static global::Org.BouncyCastle.Math.BigInteger HashGen(global::Org.BouncyCastle.Crypto.IDigest d, byte[] seed, int count)
		{
			int dLen = d.GetDigestSize();
			int pos = count * dLen;
			byte[] buf = new byte[pos];
			for (int i = 0; i < count; i++)
			{
				pos -= dLen;
				global::Org.BouncyCastle.Math.Primes.Hash(d, seed, buf, pos);
				global::Org.BouncyCastle.Math.Primes.Inc(seed, 1);
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, buf);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00053BE4 File Offset: 0x00051DE4
		private static void Inc(byte[] seed, int c)
		{
			int pos = seed.Length;
			while (c > 0 && --pos >= 0)
			{
				c += (int)seed[pos];
				seed[pos] = (byte)c;
				c >>= 8;
			}
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00053C14 File Offset: 0x00051E14
		private static bool IsPrime32(uint x)
		{
			if (x <= 5U)
			{
				return x == 2U || x == 3U || x == 5U;
			}
			if ((x & 1U) == 0U || x % 3U == 0U || x % 5U == 0U)
			{
				return false;
			}
			uint[] ds = new uint[]
			{
				1U,
				7U,
				11U,
				13U,
				17U,
				19U,
				23U,
				29U
			};
			uint b = 0U;
			int pos = 1;
			for (;;)
			{
				if (pos >= ds.Length)
				{
					b += 30U;
					if (b >> 16 != 0U || b * b >= x)
					{
						return true;
					}
					pos = 0;
				}
				else
				{
					uint d = b + ds[pos];
					if (x % d == 0U)
					{
						break;
					}
					pos++;
				}
			}
			return x < 30U;
		}

		// Token: 0x04000925 RID: 2341
		public static readonly int SmallFactorLimit = 211;

		// Token: 0x04000926 RID: 2342
		private static readonly global::Org.BouncyCastle.Math.BigInteger One = global::Org.BouncyCastle.Math.BigInteger.One;

		// Token: 0x04000927 RID: 2343
		private static readonly global::Org.BouncyCastle.Math.BigInteger Two = global::Org.BouncyCastle.Math.BigInteger.Two;

		// Token: 0x04000928 RID: 2344
		private static readonly global::Org.BouncyCastle.Math.BigInteger Three = global::Org.BouncyCastle.Math.BigInteger.Three;

		// Token: 0x020007BB RID: 1979
		public class MROutput
		{
			// Token: 0x0600454D RID: 17741 RVA: 0x00132F6E File Offset: 0x0013116E
			internal static global::Org.BouncyCastle.Math.Primes.MROutput ProbablyPrime()
			{
				return new global::Org.BouncyCastle.Math.Primes.MROutput(false, null);
			}

			// Token: 0x0600454E RID: 17742 RVA: 0x00132F77 File Offset: 0x00131177
			internal static global::Org.BouncyCastle.Math.Primes.MROutput ProvablyCompositeWithFactor(global::Org.BouncyCastle.Math.BigInteger factor)
			{
				return new global::Org.BouncyCastle.Math.Primes.MROutput(true, factor);
			}

			// Token: 0x0600454F RID: 17743 RVA: 0x00132F80 File Offset: 0x00131180
			internal static global::Org.BouncyCastle.Math.Primes.MROutput ProvablyCompositeNotPrimePower()
			{
				return new global::Org.BouncyCastle.Math.Primes.MROutput(true, null);
			}

			// Token: 0x06004550 RID: 17744 RVA: 0x00132F89 File Offset: 0x00131189
			private MROutput(bool provablyComposite, global::Org.BouncyCastle.Math.BigInteger factor)
			{
				this.mProvablyComposite = provablyComposite;
				this.mFactor = factor;
			}

			// Token: 0x17000A7A RID: 2682
			// (get) Token: 0x06004551 RID: 17745 RVA: 0x00132F9F File Offset: 0x0013119F
			public global::Org.BouncyCastle.Math.BigInteger Factor
			{
				get
				{
					return this.mFactor;
				}
			}

			// Token: 0x17000A7B RID: 2683
			// (get) Token: 0x06004552 RID: 17746 RVA: 0x00132FA7 File Offset: 0x001311A7
			public bool IsProvablyComposite
			{
				get
				{
					return this.mProvablyComposite;
				}
			}

			// Token: 0x17000A7C RID: 2684
			// (get) Token: 0x06004553 RID: 17747 RVA: 0x00132FAF File Offset: 0x001311AF
			public bool IsNotPrimePower
			{
				get
				{
					return this.mProvablyComposite && this.mFactor == null;
				}
			}

			// Token: 0x040023E0 RID: 9184
			private readonly bool mProvablyComposite;

			// Token: 0x040023E1 RID: 9185
			private readonly global::Org.BouncyCastle.Math.BigInteger mFactor;
		}

		// Token: 0x020007BC RID: 1980
		public class STOutput
		{
			// Token: 0x06004554 RID: 17748 RVA: 0x00132FC4 File Offset: 0x001311C4
			internal STOutput(global::Org.BouncyCastle.Math.BigInteger prime, byte[] primeSeed, int primeGenCounter)
			{
				this.mPrime = prime;
				this.mPrimeSeed = primeSeed;
				this.mPrimeGenCounter = primeGenCounter;
			}

			// Token: 0x17000A7D RID: 2685
			// (get) Token: 0x06004555 RID: 17749 RVA: 0x00132FE1 File Offset: 0x001311E1
			public global::Org.BouncyCastle.Math.BigInteger Prime
			{
				get
				{
					return this.mPrime;
				}
			}

			// Token: 0x17000A7E RID: 2686
			// (get) Token: 0x06004556 RID: 17750 RVA: 0x00132FE9 File Offset: 0x001311E9
			public byte[] PrimeSeed
			{
				get
				{
					return this.mPrimeSeed;
				}
			}

			// Token: 0x17000A7F RID: 2687
			// (get) Token: 0x06004557 RID: 17751 RVA: 0x00132FF1 File Offset: 0x001311F1
			public int PrimeGenCounter
			{
				get
				{
					return this.mPrimeGenCounter;
				}
			}

			// Token: 0x040023E2 RID: 9186
			private readonly global::Org.BouncyCastle.Math.BigInteger mPrime;

			// Token: 0x040023E3 RID: 9187
			private readonly byte[] mPrimeSeed;

			// Token: 0x040023E4 RID: 9188
			private readonly int mPrimeGenCounter;
		}
	}
}
