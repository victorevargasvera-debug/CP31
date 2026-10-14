using System;
using Org.BouncyCastle.Crypto.Prng.Drbg;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003B9 RID: 953
	public class SP800SecureRandom : global::Org.BouncyCastle.Security.SecureRandom
	{
		// Token: 0x060026A2 RID: 9890 RVA: 0x000A81B0 File Offset: 0x000A63B0
		internal SP800SecureRandom(global::Org.BouncyCastle.Security.SecureRandom randomSource, global::Org.BouncyCastle.Crypto.IEntropySource entropySource, global::Org.BouncyCastle.Crypto.Prng.IDrbgProvider drbgProvider, bool predictionResistant) : base(null)
		{
			this.mRandomSource = randomSource;
			this.mEntropySource = entropySource;
			this.mDrbgProvider = drbgProvider;
			this.mPredictionResistant = predictionResistant;
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x000A81D8 File Offset: 0x000A63D8
		public override void SetSeed(byte[] seed)
		{
			lock (this)
			{
				if (this.mRandomSource != null)
				{
					this.mRandomSource.SetSeed(seed);
				}
			}
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x000A8224 File Offset: 0x000A6424
		public override void SetSeed(long seed)
		{
			lock (this)
			{
				if (this.mRandomSource != null)
				{
					this.mRandomSource.SetSeed(seed);
				}
			}
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x000A8270 File Offset: 0x000A6470
		public override void NextBytes(byte[] bytes)
		{
			lock (this)
			{
				if (this.mDrbg == null)
				{
					this.mDrbg = this.mDrbgProvider.Get(this.mEntropySource);
				}
				if (this.mDrbg.Generate(bytes, null, this.mPredictionResistant) < 0)
				{
					this.mDrbg.Reseed(null);
					this.mDrbg.Generate(bytes, null, this.mPredictionResistant);
				}
			}
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x000A82FC File Offset: 0x000A64FC
		public override void NextBytes(byte[] buf, int off, int len)
		{
			byte[] bytes = new byte[len];
			this.NextBytes(bytes);
			global::System.Array.Copy(bytes, 0, buf, off, len);
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x000A8321 File Offset: 0x000A6521
		public override byte[] GenerateSeed(int numBytes)
		{
			return global::Org.BouncyCastle.Crypto.Prng.EntropyUtilities.GenerateSeed(this.mEntropySource, numBytes);
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x000A8330 File Offset: 0x000A6530
		public virtual void Reseed(byte[] additionalInput)
		{
			lock (this)
			{
				if (this.mDrbg == null)
				{
					this.mDrbg = this.mDrbgProvider.Get(this.mEntropySource);
				}
				this.mDrbg.Reseed(additionalInput);
			}
		}

		// Token: 0x04000F94 RID: 3988
		private readonly global::Org.BouncyCastle.Crypto.Prng.IDrbgProvider mDrbgProvider;

		// Token: 0x04000F95 RID: 3989
		private readonly bool mPredictionResistant;

		// Token: 0x04000F96 RID: 3990
		private readonly global::Org.BouncyCastle.Security.SecureRandom mRandomSource;

		// Token: 0x04000F97 RID: 3991
		private readonly global::Org.BouncyCastle.Crypto.IEntropySource mEntropySource;

		// Token: 0x04000F98 RID: 3992
		private global::Org.BouncyCastle.Crypto.Prng.Drbg.ISP80090Drbg mDrbg;
	}
}
