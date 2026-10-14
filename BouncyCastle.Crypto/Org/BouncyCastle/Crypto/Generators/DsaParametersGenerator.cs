using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200046B RID: 1131
	public class DsaParametersGenerator
	{
		// Token: 0x06002BB3 RID: 11187 RVA: 0x000BB3E5 File Offset: 0x000B95E5
		public DsaParametersGenerator() : this(new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest())
		{
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x000BB3F2 File Offset: 0x000B95F2
		public DsaParametersGenerator(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.digest = digest;
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x000BB404 File Offset: 0x000B9604
		public virtual void Init(int size, int certainty, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			if (!global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.IsValidDsaStrength(size))
			{
				throw new global::System.ArgumentException("size must be from 512 - 1024 and a multiple of 64", "size");
			}
			this.use186_3 = false;
			this.L = size;
			this.N = global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.GetDefaultN(size);
			this.certainty = certainty;
			this.random = random;
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x000BB454 File Offset: 0x000B9654
		public virtual void Init(global::Org.BouncyCastle.Crypto.Parameters.DsaParameterGenerationParameters parameters)
		{
			this.use186_3 = true;
			this.L = parameters.L;
			this.N = parameters.N;
			this.certainty = parameters.Certainty;
			this.random = parameters.Random;
			this.usageIndex = parameters.UsageIndex;
			if (this.L < 1024 || this.L > 3072 || this.L % 1024 != 0)
			{
				throw new global::System.ArgumentException("Values must be between 1024 and 3072 and a multiple of 1024", "L");
			}
			if (this.L == 1024 && this.N != 160)
			{
				throw new global::System.ArgumentException("N must be 160 for L = 1024");
			}
			if (this.L == 2048 && this.N != 224 && this.N != 256)
			{
				throw new global::System.ArgumentException("N must be 224 or 256 for L = 2048");
			}
			if (this.L == 3072 && this.N != 256)
			{
				throw new global::System.ArgumentException("N must be 256 for L = 3072");
			}
			if (this.digest.GetDigestSize() * 8 < this.N)
			{
				throw new global::System.InvalidOperationException("Digest output size too small for value of N");
			}
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x000BB578 File Offset: 0x000B9778
		public virtual global::Org.BouncyCastle.Crypto.Parameters.DsaParameters GenerateParameters()
		{
			if (!this.use186_3)
			{
				return this.GenerateParameters_FIPS186_2();
			}
			return this.GenerateParameters_FIPS186_3();
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x000BB590 File Offset: 0x000B9790
		protected virtual global::Org.BouncyCastle.Crypto.Parameters.DsaParameters GenerateParameters_FIPS186_2()
		{
			byte[] seed = new byte[20];
			byte[] part = new byte[20];
			byte[] part2 = new byte[20];
			byte[] u = new byte[20];
			int i = (this.L - 1) / 160;
			byte[] w = new byte[this.L / 8];
			if (!(this.digest is global::Org.BouncyCastle.Crypto.Digests.Sha1Digest))
			{
				throw new global::System.InvalidOperationException("can only use SHA-1 for generating FIPS 186-2 parameters");
			}
			global::Org.BouncyCastle.Math.BigInteger q;
			int counter;
			global::Org.BouncyCastle.Math.BigInteger p;
			for (;;)
			{
				this.random.NextBytes(seed);
				global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.Hash(this.digest, seed, part);
				global::System.Array.Copy(seed, 0, part2, 0, seed.Length);
				global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.Inc(part2);
				global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.Hash(this.digest, part2, part2);
				for (int j = 0; j != u.Length; j++)
				{
					u[j] = (part[j] ^ part2[j]);
				}
				byte[] array = u;
				int num = 0;
				array[num] |= 128;
				byte[] array2 = u;
				int num2 = 19;
				array2[num2] |= 1;
				q = new global::Org.BouncyCastle.Math.BigInteger(1, u);
				if (q.IsProbablePrime(this.certainty))
				{
					byte[] offset = global::Org.BouncyCastle.Utilities.Arrays.Clone(seed);
					global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.Inc(offset);
					for (counter = 0; counter < 4096; counter++)
					{
						for (int k = 0; k < i; k++)
						{
							global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.Inc(offset);
							global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.Hash(this.digest, offset, part);
							global::System.Array.Copy(part, 0, w, w.Length - (k + 1) * part.Length, part.Length);
						}
						global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.Inc(offset);
						global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.Hash(this.digest, offset, part);
						global::System.Array.Copy(part, part.Length - (w.Length - i * part.Length), w, 0, w.Length - i * part.Length);
						byte[] array3 = w;
						int num3 = 0;
						array3[num3] |= 128;
						global::Org.BouncyCastle.Math.BigInteger bigInteger = new global::Org.BouncyCastle.Math.BigInteger(1, w);
						global::Org.BouncyCastle.Math.BigInteger c = bigInteger.Mod(q.ShiftLeft(1));
						p = bigInteger.Subtract(c.Subtract(global::Org.BouncyCastle.Math.BigInteger.One));
						if (p.BitLength == this.L && p.IsProbablePrime(this.certainty))
						{
							goto Block_6;
						}
					}
				}
			}
			Block_6:
			global::Org.BouncyCastle.Math.BigInteger g = this.CalculateGenerator_FIPS186_2(p, q, this.random);
			return new global::Org.BouncyCastle.Crypto.Parameters.DsaParameters(p, q, g, new global::Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters(seed, counter));
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x000BB7AC File Offset: 0x000B99AC
		protected virtual global::Org.BouncyCastle.Math.BigInteger CalculateGenerator_FIPS186_2(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Security.SecureRandom r)
		{
			global::Org.BouncyCastle.Math.BigInteger e = p.Subtract(global::Org.BouncyCastle.Math.BigInteger.One).Divide(q);
			global::Org.BouncyCastle.Math.BigInteger pSub2 = p.Subtract(global::Org.BouncyCastle.Math.BigInteger.Two);
			global::Org.BouncyCastle.Math.BigInteger g;
			do
			{
				g = global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(global::Org.BouncyCastle.Math.BigInteger.Two, pSub2, r).ModPow(e, p);
			}
			while (g.BitLength <= 1);
			return g;
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x000BB7F8 File Offset: 0x000B99F8
		protected virtual global::Org.BouncyCastle.Crypto.Parameters.DsaParameters GenerateParameters_FIPS186_3()
		{
			global::Org.BouncyCastle.Crypto.IDigest d = this.digest;
			int outlen = d.GetDigestSize() * 8;
			byte[] seed = new byte[this.N / 8];
			int i = (this.L - 1) / outlen;
			int b = (this.L - 1) % outlen;
			byte[] output = new byte[d.GetDigestSize()];
			global::Org.BouncyCastle.Math.BigInteger q;
			int counter;
			global::Org.BouncyCastle.Math.BigInteger p;
			for (;;)
			{
				this.random.NextBytes(seed);
				global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.Hash(d, seed, output);
				q = new global::Org.BouncyCastle.Math.BigInteger(1, output).Mod(global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(this.N - 1)).SetBit(0).SetBit(this.N - 1);
				if (q.IsProbablePrime(this.certainty))
				{
					byte[] offset = global::Org.BouncyCastle.Utilities.Arrays.Clone(seed);
					int counterLimit = 4 * this.L;
					for (counter = 0; counter < counterLimit; counter++)
					{
						global::Org.BouncyCastle.Math.BigInteger W = global::Org.BouncyCastle.Math.BigInteger.Zero;
						int j = 0;
						int exp = 0;
						while (j <= i)
						{
							global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.Inc(offset);
							global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.Hash(d, offset, output);
							global::Org.BouncyCastle.Math.BigInteger Vj = new global::Org.BouncyCastle.Math.BigInteger(1, output);
							if (j == i)
							{
								Vj = Vj.Mod(global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(b));
							}
							W = W.Add(Vj.ShiftLeft(exp));
							j++;
							exp += outlen;
						}
						global::Org.BouncyCastle.Math.BigInteger bigInteger = W.Add(global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(this.L - 1));
						global::Org.BouncyCastle.Math.BigInteger c = bigInteger.Mod(q.ShiftLeft(1));
						p = bigInteger.Subtract(c.Subtract(global::Org.BouncyCastle.Math.BigInteger.One));
						if (p.BitLength == this.L && p.IsProbablePrime(this.certainty))
						{
							goto Block_5;
						}
					}
				}
			}
			Block_5:
			if (this.usageIndex >= 0)
			{
				global::Org.BouncyCastle.Math.BigInteger g = this.CalculateGenerator_FIPS186_3_Verifiable(d, p, q, seed, this.usageIndex);
				if (g != null)
				{
					return new global::Org.BouncyCastle.Crypto.Parameters.DsaParameters(p, q, g, new global::Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters(seed, counter, this.usageIndex));
				}
			}
			global::Org.BouncyCastle.Math.BigInteger g2 = this.CalculateGenerator_FIPS186_3_Unverifiable(p, q, this.random);
			return new global::Org.BouncyCastle.Crypto.Parameters.DsaParameters(p, q, g2, new global::Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters(seed, counter));
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x000BB9EE File Offset: 0x000B9BEE
		protected virtual global::Org.BouncyCastle.Math.BigInteger CalculateGenerator_FIPS186_3_Unverifiable(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Security.SecureRandom r)
		{
			return this.CalculateGenerator_FIPS186_2(p, q, r);
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x000BB9FC File Offset: 0x000B9BFC
		protected virtual global::Org.BouncyCastle.Math.BigInteger CalculateGenerator_FIPS186_3_Verifiable(global::Org.BouncyCastle.Crypto.IDigest d, global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, byte[] seed, int index)
		{
			global::Org.BouncyCastle.Math.BigInteger e = p.Subtract(global::Org.BouncyCastle.Math.BigInteger.One).Divide(q);
			byte[] ggen = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("6767656E");
			byte[] U = new byte[seed.Length + ggen.Length + 1 + 2];
			global::System.Array.Copy(seed, 0, U, 0, seed.Length);
			global::System.Array.Copy(ggen, 0, U, seed.Length, ggen.Length);
			U[U.Length - 3] = (byte)index;
			byte[] w = new byte[d.GetDigestSize()];
			for (int count = 1; count < 65536; count++)
			{
				global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.Inc(U);
				global::Org.BouncyCastle.Crypto.Generators.DsaParametersGenerator.Hash(d, U, w);
				global::Org.BouncyCastle.Math.BigInteger g = new global::Org.BouncyCastle.Math.BigInteger(1, w).ModPow(e, p);
				if (g.CompareTo(global::Org.BouncyCastle.Math.BigInteger.Two) >= 0)
				{
					return g;
				}
			}
			return null;
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x000BBAB0 File Offset: 0x000B9CB0
		private static bool IsValidDsaStrength(int strength)
		{
			return strength >= 512 && strength <= 1024 && strength % 64 == 0;
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x000BBACB File Offset: 0x000B9CCB
		protected static void Hash(global::Org.BouncyCastle.Crypto.IDigest d, byte[] input, byte[] output)
		{
			d.BlockUpdate(input, 0, input.Length);
			d.DoFinal(output, 0);
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x000BBAE1 File Offset: 0x000B9CE1
		private static int GetDefaultN(int L)
		{
			if (L <= 1024)
			{
				return 160;
			}
			return 256;
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x000BBAF8 File Offset: 0x000B9CF8
		protected static void Inc(byte[] buf)
		{
			for (int i = buf.Length - 1; i >= 0; i--)
			{
				byte b = buf[i] + 1;
				buf[i] = b;
				if (b != 0)
				{
					break;
				}
			}
		}

		// Token: 0x04001221 RID: 4641
		private global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04001222 RID: 4642
		private int L;

		// Token: 0x04001223 RID: 4643
		private int N;

		// Token: 0x04001224 RID: 4644
		private int certainty;

		// Token: 0x04001225 RID: 4645
		private global::Org.BouncyCastle.Security.SecureRandom random;

		// Token: 0x04001226 RID: 4646
		private bool use186_3;

		// Token: 0x04001227 RID: 4647
		private int usageIndex;
	}
}
