using System;
using System.Collections;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200047A RID: 1146
	public class NaccacheSternKeyPairGenerator : global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06002C01 RID: 11265 RVA: 0x000BD97C File Offset: 0x000BBB7C
		public void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			this.param = (global::Org.BouncyCastle.Crypto.Parameters.NaccacheSternKeyGenerationParameters)parameters;
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x000BD98C File Offset: 0x000BBB8C
		public global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			int strength = this.param.Strength;
			global::Org.BouncyCastle.Security.SecureRandom rand = this.param.Random;
			int certainty = this.param.Certainty;
			global::System.Collections.IList smallPrimes = global::Org.BouncyCastle.Crypto.Generators.NaccacheSternKeyPairGenerator.findFirstPrimes(this.param.CountSmallPrimes);
			smallPrimes = global::Org.BouncyCastle.Crypto.Generators.NaccacheSternKeyPairGenerator.permuteList(smallPrimes, rand);
			global::Org.BouncyCastle.Math.BigInteger u = global::Org.BouncyCastle.Math.BigInteger.One;
			global::Org.BouncyCastle.Math.BigInteger v = global::Org.BouncyCastle.Math.BigInteger.One;
			for (int i = 0; i < smallPrimes.Count / 2; i++)
			{
				u = u.Multiply((global::Org.BouncyCastle.Math.BigInteger)smallPrimes[i]);
			}
			for (int j = smallPrimes.Count / 2; j < smallPrimes.Count; j++)
			{
				v = v.Multiply((global::Org.BouncyCastle.Math.BigInteger)smallPrimes[j]);
			}
			global::Org.BouncyCastle.Math.BigInteger sigma = u.Multiply(v);
			int num = strength - sigma.BitLength - 48;
			global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Crypto.Generators.NaccacheSternKeyPairGenerator.generatePrime(num / 2 + 1, certainty, rand);
			global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Crypto.Generators.NaccacheSternKeyPairGenerator.generatePrime(num / 2 + 1, certainty, rand);
			long tries = 0L;
			global::Org.BouncyCastle.Math.BigInteger _2au = a.Multiply(u).ShiftLeft(1);
			global::Org.BouncyCastle.Math.BigInteger _2bv = b.Multiply(v).ShiftLeft(1);
			global::Org.BouncyCastle.Math.BigInteger _p;
			global::Org.BouncyCastle.Math.BigInteger p;
			global::Org.BouncyCastle.Math.BigInteger _q;
			global::Org.BouncyCastle.Math.BigInteger q;
			for (;;)
			{
				tries += 1L;
				_p = global::Org.BouncyCastle.Crypto.Generators.NaccacheSternKeyPairGenerator.generatePrime(24, certainty, rand);
				p = _p.Multiply(_2au).Add(global::Org.BouncyCastle.Math.BigInteger.One);
				if (p.IsProbablePrime(certainty, true))
				{
					for (;;)
					{
						_q = global::Org.BouncyCastle.Crypto.Generators.NaccacheSternKeyPairGenerator.generatePrime(24, certainty, rand);
						if (!_p.Equals(_q))
						{
							q = _q.Multiply(_2bv).Add(global::Org.BouncyCastle.Math.BigInteger.One);
							if (q.IsProbablePrime(certainty, true))
							{
								break;
							}
						}
					}
					if (sigma.Gcd(_p.Multiply(_q)).Equals(global::Org.BouncyCastle.Math.BigInteger.One) && p.Multiply(q).BitLength >= strength)
					{
						break;
					}
				}
			}
			global::Org.BouncyCastle.Math.BigInteger k = p.Multiply(q);
			global::Org.BouncyCastle.Math.BigInteger phi_n = p.Subtract(global::Org.BouncyCastle.Math.BigInteger.One).Multiply(q.Subtract(global::Org.BouncyCastle.Math.BigInteger.One));
			tries = 0L;
			global::Org.BouncyCastle.Math.BigInteger g;
			bool divisible;
			do
			{
				global::System.Collections.IList gParts = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				for (int ind = 0; ind != smallPrimes.Count; ind++)
				{
					global::Org.BouncyCastle.Math.BigInteger l = (global::Org.BouncyCastle.Math.BigInteger)smallPrimes[ind];
					global::Org.BouncyCastle.Math.BigInteger e = phi_n.Divide(l);
					do
					{
						tries += 1L;
						g = global::Org.BouncyCastle.Crypto.Generators.NaccacheSternKeyPairGenerator.generatePrime(strength, certainty, rand);
					}
					while (g.ModPow(e, k).Equals(global::Org.BouncyCastle.Math.BigInteger.One));
					gParts.Add(g);
				}
				g = global::Org.BouncyCastle.Math.BigInteger.One;
				for (int m = 0; m < smallPrimes.Count; m++)
				{
					global::Org.BouncyCastle.Math.BigInteger gPart = (global::Org.BouncyCastle.Math.BigInteger)gParts[m];
					global::Org.BouncyCastle.Math.BigInteger smallPrime = (global::Org.BouncyCastle.Math.BigInteger)smallPrimes[m];
					g = g.Multiply(gPart.ModPow(sigma.Divide(smallPrime), k)).Mod(k);
				}
				divisible = false;
				for (int n = 0; n < smallPrimes.Count; n++)
				{
					if (g.ModPow(phi_n.Divide((global::Org.BouncyCastle.Math.BigInteger)smallPrimes[n]), k).Equals(global::Org.BouncyCastle.Math.BigInteger.One))
					{
						divisible = true;
						break;
					}
				}
			}
			while (divisible || g.ModPow(phi_n.ShiftRight(2), k).Equals(global::Org.BouncyCastle.Math.BigInteger.One) || g.ModPow(phi_n.Divide(_p), k).Equals(global::Org.BouncyCastle.Math.BigInteger.One) || g.ModPow(phi_n.Divide(_q), k).Equals(global::Org.BouncyCastle.Math.BigInteger.One) || g.ModPow(phi_n.Divide(a), k).Equals(global::Org.BouncyCastle.Math.BigInteger.One) || g.ModPow(phi_n.Divide(b), k).Equals(global::Org.BouncyCastle.Math.BigInteger.One));
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(new global::Org.BouncyCastle.Crypto.Parameters.NaccacheSternKeyParameters(false, g, k, sigma.BitLength), new global::Org.BouncyCastle.Crypto.Parameters.NaccacheSternPrivateKeyParameters(g, k, sigma.BitLength, smallPrimes, phi_n));
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x000BDD43 File Offset: 0x000BBF43
		private static global::Org.BouncyCastle.Math.BigInteger generatePrime(int bitLength, int certainty, global::Org.BouncyCastle.Security.SecureRandom rand)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(bitLength, certainty, rand);
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x000BDD50 File Offset: 0x000BBF50
		private static global::System.Collections.IList permuteList(global::System.Collections.IList arr, global::Org.BouncyCastle.Security.SecureRandom rand)
		{
			global::System.Collections.IList retval = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(arr.Count);
			foreach (object element in arr)
			{
				int index = rand.Next(retval.Count + 1);
				retval.Insert(index, element);
			}
			return retval;
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x000BDDC0 File Offset: 0x000BBFC0
		private static global::System.Collections.IList findFirstPrimes(int count)
		{
			global::System.Collections.IList primes = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(count);
			for (int i = 0; i != count; i++)
			{
				primes.Add(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)global::Org.BouncyCastle.Crypto.Generators.NaccacheSternKeyPairGenerator.smallPrimes[i]));
			}
			return primes;
		}

		// Token: 0x0400125E RID: 4702
		private static readonly int[] smallPrimes = new int[]
		{
			3,
			5,
			7,
			11,
			13,
			17,
			19,
			23,
			29,
			31,
			37,
			41,
			43,
			47,
			53,
			59,
			61,
			67,
			71,
			73,
			79,
			83,
			89,
			97,
			101,
			103,
			107,
			109,
			113,
			127,
			131,
			137,
			139,
			149,
			151,
			157,
			163,
			167,
			173,
			179,
			181,
			191,
			193,
			197,
			199,
			211,
			223,
			227,
			229,
			233,
			239,
			241,
			251,
			257,
			263,
			269,
			271,
			277,
			281,
			283,
			293,
			307,
			311,
			313,
			317,
			331,
			337,
			347,
			349,
			353,
			359,
			367,
			373,
			379,
			383,
			389,
			397,
			401,
			409,
			419,
			421,
			431,
			433,
			439,
			443,
			449,
			457,
			461,
			463,
			467,
			479,
			487,
			491,
			499,
			503,
			509,
			521,
			523,
			541,
			547,
			557
		};

		// Token: 0x0400125F RID: 4703
		private global::Org.BouncyCastle.Crypto.Parameters.NaccacheSternKeyGenerationParameters param;
	}
}
