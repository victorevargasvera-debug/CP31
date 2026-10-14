using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003B1 RID: 945
	public class BasicEntropySourceProvider : global::Org.BouncyCastle.Crypto.IEntropySourceProvider
	{
		// Token: 0x06002680 RID: 9856 RVA: 0x000A7C88 File Offset: 0x000A5E88
		public BasicEntropySourceProvider(global::Org.BouncyCastle.Security.SecureRandom secureRandom, bool isPredictionResistant)
		{
			this.mSecureRandom = secureRandom;
			this.mPredictionResistant = isPredictionResistant;
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x000A7C9E File Offset: 0x000A5E9E
		public global::Org.BouncyCastle.Crypto.IEntropySource Get(int bitsRequired)
		{
			return new global::Org.BouncyCastle.Crypto.Prng.BasicEntropySourceProvider.BasicEntropySource(this.mSecureRandom, this.mPredictionResistant, bitsRequired);
		}

		// Token: 0x04000F86 RID: 3974
		private readonly global::Org.BouncyCastle.Security.SecureRandom mSecureRandom;

		// Token: 0x04000F87 RID: 3975
		private readonly bool mPredictionResistant;

		// Token: 0x02000805 RID: 2053
		private class BasicEntropySource : global::Org.BouncyCastle.Crypto.IEntropySource
		{
			// Token: 0x0600465F RID: 18015 RVA: 0x00136958 File Offset: 0x00134B58
			internal BasicEntropySource(global::Org.BouncyCastle.Security.SecureRandom secureRandom, bool predictionResistant, int entropySize)
			{
				this.mSecureRandom = secureRandom;
				this.mPredictionResistant = predictionResistant;
				this.mEntropySize = entropySize;
			}

			// Token: 0x17000AA7 RID: 2727
			// (get) Token: 0x06004660 RID: 18016 RVA: 0x00136975 File Offset: 0x00134B75
			bool global::Org.BouncyCastle.Crypto.IEntropySource.IsPredictionResistant
			{
				get
				{
					return this.mPredictionResistant;
				}
			}

			// Token: 0x06004661 RID: 18017 RVA: 0x0013697D File Offset: 0x00134B7D
			byte[] global::Org.BouncyCastle.Crypto.IEntropySource.GetEntropy()
			{
				return global::Org.BouncyCastle.Security.SecureRandom.GetNextBytes(this.mSecureRandom, (this.mEntropySize + 7) / 8);
			}

			// Token: 0x17000AA8 RID: 2728
			// (get) Token: 0x06004662 RID: 18018 RVA: 0x00136994 File Offset: 0x00134B94
			int global::Org.BouncyCastle.Crypto.IEntropySource.EntropySize
			{
				get
				{
					return this.mEntropySize;
				}
			}

			// Token: 0x040024B3 RID: 9395
			private readonly global::Org.BouncyCastle.Security.SecureRandom mSecureRandom;

			// Token: 0x040024B4 RID: 9396
			private readonly bool mPredictionResistant;

			// Token: 0x040024B5 RID: 9397
			private readonly int mEntropySize;
		}
	}
}
