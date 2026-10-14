using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000482 RID: 1154
	public class RsaKeyPairGenerator : global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06002C3B RID: 11323 RVA: 0x000BEFC9 File Offset: 0x000BD1C9
		public virtual void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyGenerationParameters)
			{
				this.parameters = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyGenerationParameters)parameters;
				return;
			}
			this.parameters = new global::Org.BouncyCastle.Crypto.Parameters.RsaKeyGenerationParameters(global::Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.DefaultPublicExponent, parameters.Random, parameters.Strength, 100);
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x000BF000 File Offset: 0x000BD200
		public virtual global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			int qBitlength;
			global::Org.BouncyCastle.Math.BigInteger e;
			global::Org.BouncyCastle.Math.BigInteger p;
			global::Org.BouncyCastle.Math.BigInteger q;
			global::Org.BouncyCastle.Math.BigInteger i;
			global::Org.BouncyCastle.Math.BigInteger pSub;
			global::Org.BouncyCastle.Math.BigInteger qSub;
			global::Org.BouncyCastle.Math.BigInteger d;
			do
			{
				int strength = this.parameters.Strength;
				int pBitlength = (strength + 1) / 2;
				qBitlength = strength - pBitlength;
				int mindiffbits = strength / 3;
				int minWeight = strength >> 2;
				e = this.parameters.PublicExponent;
				p = this.ChooseRandomPrime(pBitlength, e);
				for (;;)
				{
					q = this.ChooseRandomPrime(qBitlength, e);
					if (q.Subtract(p).Abs().BitLength >= mindiffbits)
					{
						i = p.Multiply(q);
						if (i.BitLength != strength)
						{
							p = p.Max(q);
						}
						else
						{
							if (global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetNafWeight(i) >= minWeight)
							{
								break;
							}
							p = this.ChooseRandomPrime(pBitlength, e);
						}
					}
				}
				if (p.CompareTo(q) < 0)
				{
					global::Org.BouncyCastle.Math.BigInteger bigInteger = p;
					p = q;
					q = bigInteger;
				}
				pSub = p.Subtract(global::Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.One);
				qSub = q.Subtract(global::Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.One);
				global::Org.BouncyCastle.Math.BigInteger gcd = pSub.Gcd(qSub);
				global::Org.BouncyCastle.Math.BigInteger lcm = pSub.Divide(gcd).Multiply(qSub);
				d = e.ModInverse(lcm);
			}
			while (d.BitLength <= qBitlength);
			global::Org.BouncyCastle.Math.BigInteger dP = d.Remainder(pSub);
			global::Org.BouncyCastle.Math.BigInteger dQ = d.Remainder(qSub);
			global::Org.BouncyCastle.Math.BigInteger qInv = global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverse(p, q);
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(new global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(false, i, e), new global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters(i, e, d, p, q, dP, dQ, qInv));
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x000BF14C File Offset: 0x000BD34C
		protected virtual global::Org.BouncyCastle.Math.BigInteger ChooseRandomPrime(int bitlength, global::Org.BouncyCastle.Math.BigInteger e)
		{
			bool eIsKnownOddPrime = e.BitLength <= global::Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.SPECIAL_E_BITS && global::Org.BouncyCastle.Utilities.Arrays.Contains(global::Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.SPECIAL_E_VALUES, e.IntValue);
			global::Org.BouncyCastle.Math.BigInteger p;
			do
			{
				p = new global::Org.BouncyCastle.Math.BigInteger(bitlength, 1, this.parameters.Random);
			}
			while (p.Mod(e).Equals(global::Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.One) || !p.IsProbablePrime(this.parameters.Certainty, true) || (!eIsKnownOddPrime && !e.Gcd(p.Subtract(global::Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.One)).Equals(global::Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.One)));
			return p;
		}

		// Token: 0x04001272 RID: 4722
		private static readonly int[] SPECIAL_E_VALUES = new int[]
		{
			3,
			5,
			17,
			257,
			65537
		};

		// Token: 0x04001273 RID: 4723
		private static readonly int SPECIAL_E_HIGHEST = global::Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.SPECIAL_E_VALUES[global::Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.SPECIAL_E_VALUES.Length - 1];

		// Token: 0x04001274 RID: 4724
		private static readonly int SPECIAL_E_BITS = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)global::Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.SPECIAL_E_HIGHEST).BitLength;

		// Token: 0x04001275 RID: 4725
		protected static readonly global::Org.BouncyCastle.Math.BigInteger One = global::Org.BouncyCastle.Math.BigInteger.One;

		// Token: 0x04001276 RID: 4726
		protected static readonly global::Org.BouncyCastle.Math.BigInteger DefaultPublicExponent = global::Org.BouncyCastle.Math.BigInteger.ValueOf(65537L);

		// Token: 0x04001277 RID: 4727
		protected const int DefaultTests = 100;

		// Token: 0x04001278 RID: 4728
		protected global::Org.BouncyCastle.Crypto.Parameters.RsaKeyGenerationParameters parameters;
	}
}
