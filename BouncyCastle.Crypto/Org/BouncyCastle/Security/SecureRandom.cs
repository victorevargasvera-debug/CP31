using System;
using System.Threading;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001CF RID: 463
	public class SecureRandom : global::System.Random
	{
		// Token: 0x0600114A RID: 4426 RVA: 0x0004B360 File Offset: 0x00049560
		private static long NextCounterValue()
		{
			return global::System.Threading.Interlocked.Increment(ref global::Org.BouncyCastle.Security.SecureRandom.counter);
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0004B36C File Offset: 0x0004956C
		private static global::Org.BouncyCastle.Security.SecureRandom Master
		{
			get
			{
				return global::Org.BouncyCastle.Security.SecureRandom.master;
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x0004B374 File Offset: 0x00049574
		private static global::Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator CreatePrng(string digestName, bool autoSeed)
		{
			global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(digestName);
			if (digest == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator prng = new global::Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator(digest);
			if (autoSeed)
			{
				prng.AddSeedMaterial(global::Org.BouncyCastle.Security.SecureRandom.NextCounterValue());
				prng.AddSeedMaterial(global::Org.BouncyCastle.Security.SecureRandom.GetNextBytes(global::Org.BouncyCastle.Security.SecureRandom.Master, digest.GetDigestSize()));
			}
			return prng;
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0004B3BC File Offset: 0x000495BC
		public static byte[] GetNextBytes(global::Org.BouncyCastle.Security.SecureRandom secureRandom, int length)
		{
			byte[] result = new byte[length];
			secureRandom.NextBytes(result);
			return result;
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0004B3D8 File Offset: 0x000495D8
		public static global::Org.BouncyCastle.Security.SecureRandom GetInstance(string algorithm)
		{
			return global::Org.BouncyCastle.Security.SecureRandom.GetInstance(algorithm, true);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0004B3E4 File Offset: 0x000495E4
		public static global::Org.BouncyCastle.Security.SecureRandom GetInstance(string algorithm, bool autoSeed)
		{
			string upper = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm);
			if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(upper, "PRNG"))
			{
				global::Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator prng = global::Org.BouncyCastle.Security.SecureRandom.CreatePrng(upper.Substring(0, upper.Length - "PRNG".Length), autoSeed);
				if (prng != null)
				{
					return new global::Org.BouncyCastle.Security.SecureRandom(prng);
				}
			}
			throw new global::System.ArgumentException("Unrecognised PRNG algorithm: " + algorithm, "algorithm");
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0004B443 File Offset: 0x00049643
		[global::System.Obsolete("Call GenerateSeed() on a SecureRandom instance instead")]
		public static byte[] GetSeed(int length)
		{
			return global::Org.BouncyCastle.Security.SecureRandom.GetNextBytes(global::Org.BouncyCastle.Security.SecureRandom.Master, length);
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0004B450 File Offset: 0x00049650
		public SecureRandom() : this(global::Org.BouncyCastle.Security.SecureRandom.CreatePrng("SHA256", true))
		{
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0004B463 File Offset: 0x00049663
		[global::System.Obsolete("Use GetInstance/SetSeed instead")]
		public SecureRandom(byte[] seed) : this(global::Org.BouncyCastle.Security.SecureRandom.CreatePrng("SHA1", false))
		{
			this.SetSeed(seed);
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0004B47D File Offset: 0x0004967D
		public SecureRandom(global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator generator) : base(0)
		{
			this.generator = generator;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0004B48D File Offset: 0x0004968D
		public virtual byte[] GenerateSeed(int length)
		{
			return global::Org.BouncyCastle.Security.SecureRandom.GetNextBytes(global::Org.BouncyCastle.Security.SecureRandom.Master, length);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0004B49A File Offset: 0x0004969A
		public virtual void SetSeed(byte[] seed)
		{
			this.generator.AddSeedMaterial(seed);
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0004B4A8 File Offset: 0x000496A8
		public virtual void SetSeed(long seed)
		{
			this.generator.AddSeedMaterial(seed);
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0004B4B6 File Offset: 0x000496B6
		public override int Next()
		{
			return this.NextInt() & int.MaxValue;
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0004B4C4 File Offset: 0x000496C4
		public override int Next(int maxValue)
		{
			if (maxValue < 2)
			{
				if (maxValue < 0)
				{
					throw new global::System.ArgumentOutOfRangeException("maxValue", "cannot be negative");
				}
				return 0;
			}
			else
			{
				int bits;
				if ((maxValue & maxValue - 1) == 0)
				{
					bits = (this.NextInt() & int.MaxValue);
					return (int)((long)bits * (long)maxValue >> 31);
				}
				int result;
				do
				{
					bits = (this.NextInt() & int.MaxValue);
					result = bits % maxValue;
				}
				while (bits - result + (maxValue - 1) < 0);
				return result;
			}
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x0004B528 File Offset: 0x00049728
		public override int Next(int minValue, int maxValue)
		{
			if (maxValue <= minValue)
			{
				if (maxValue == minValue)
				{
					return minValue;
				}
				throw new global::System.ArgumentException("maxValue cannot be less than minValue");
			}
			else
			{
				int diff = maxValue - minValue;
				if (diff > 0)
				{
					return minValue + this.Next(diff);
				}
				int i;
				do
				{
					i = this.NextInt();
				}
				while (i < minValue || i >= maxValue);
				return i;
			}
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0004B56C File Offset: 0x0004976C
		public override void NextBytes(byte[] buf)
		{
			this.generator.NextBytes(buf);
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0004B57A File Offset: 0x0004977A
		public virtual void NextBytes(byte[] buf, int off, int len)
		{
			this.generator.NextBytes(buf, off, len);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0004B58A File Offset: 0x0004978A
		public override double NextDouble()
		{
			return global::System.Convert.ToDouble((ulong)this.NextLong() >> 11) * global::Org.BouncyCastle.Security.SecureRandom.DoubleScale;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0004B5A0 File Offset: 0x000497A0
		public virtual int NextInt()
		{
			byte[] bytes = new byte[4];
			this.NextBytes(bytes);
			return (int)global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bytes, 0);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0004B5C4 File Offset: 0x000497C4
		public virtual long NextLong()
		{
			byte[] bytes = new byte[8];
			this.NextBytes(bytes);
			return (long)global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt64(bytes, 0);
		}

		// Token: 0x040008D9 RID: 2265
		private static long counter = global::Org.BouncyCastle.Utilities.Times.NanoTime();

		// Token: 0x040008DA RID: 2266
		private static readonly global::Org.BouncyCastle.Security.SecureRandom master = new global::Org.BouncyCastle.Security.SecureRandom(new global::Org.BouncyCastle.Crypto.Prng.CryptoApiRandomGenerator());

		// Token: 0x040008DB RID: 2267
		protected readonly global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator generator;

		// Token: 0x040008DC RID: 2268
		private static readonly double DoubleScale = 1.0 / global::System.Convert.ToDouble(9007199254740992L);
	}
}
