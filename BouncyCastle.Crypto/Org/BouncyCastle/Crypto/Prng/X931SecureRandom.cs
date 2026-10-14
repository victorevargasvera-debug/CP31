using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003BE RID: 958
	public class X931SecureRandom : global::Org.BouncyCastle.Security.SecureRandom
	{
		// Token: 0x060026C0 RID: 9920 RVA: 0x000A89FC File Offset: 0x000A6BFC
		internal X931SecureRandom(global::Org.BouncyCastle.Security.SecureRandom randomSource, global::Org.BouncyCastle.Crypto.Prng.X931Rng drbg, bool predictionResistant) : base(null)
		{
			this.mRandomSource = randomSource;
			this.mDrbg = drbg;
			this.mPredictionResistant = predictionResistant;
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x000A8A1C File Offset: 0x000A6C1C
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

		// Token: 0x060026C2 RID: 9922 RVA: 0x000A8A68 File Offset: 0x000A6C68
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

		// Token: 0x060026C3 RID: 9923 RVA: 0x000A8AB4 File Offset: 0x000A6CB4
		public override void NextBytes(byte[] bytes)
		{
			lock (this)
			{
				if (this.mDrbg.Generate(bytes, this.mPredictionResistant) < 0)
				{
					this.mDrbg.Reseed();
					this.mDrbg.Generate(bytes, this.mPredictionResistant);
				}
			}
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x000A8B1C File Offset: 0x000A6D1C
		public override void NextBytes(byte[] buf, int off, int len)
		{
			byte[] bytes = new byte[len];
			this.NextBytes(bytes);
			global::System.Array.Copy(bytes, 0, buf, off, len);
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x000A8B41 File Offset: 0x000A6D41
		public override byte[] GenerateSeed(int numBytes)
		{
			return global::Org.BouncyCastle.Crypto.Prng.EntropyUtilities.GenerateSeed(this.mDrbg.EntropySource, numBytes);
		}

		// Token: 0x04000FAC RID: 4012
		private readonly bool mPredictionResistant;

		// Token: 0x04000FAD RID: 4013
		private readonly global::Org.BouncyCastle.Security.SecureRandom mRandomSource;

		// Token: 0x04000FAE RID: 4014
		private readonly global::Org.BouncyCastle.Crypto.Prng.X931Rng mDrbg;
	}
}
