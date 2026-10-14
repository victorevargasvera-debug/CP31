using System;
using System.Security.Cryptography;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003B2 RID: 946
	public class CryptoApiEntropySourceProvider : global::Org.BouncyCastle.Crypto.IEntropySourceProvider
	{
		// Token: 0x06002682 RID: 9858 RVA: 0x000A7CB2 File Offset: 0x000A5EB2
		public CryptoApiEntropySourceProvider() : this(global::System.Security.Cryptography.RandomNumberGenerator.Create(), true)
		{
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x000A7CC0 File Offset: 0x000A5EC0
		public CryptoApiEntropySourceProvider(global::System.Security.Cryptography.RandomNumberGenerator rng, bool isPredictionResistant)
		{
			if (rng == null)
			{
				throw new global::System.ArgumentNullException("rng");
			}
			this.mRng = rng;
			this.mPredictionResistant = isPredictionResistant;
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x000A7CE4 File Offset: 0x000A5EE4
		public global::Org.BouncyCastle.Crypto.IEntropySource Get(int bitsRequired)
		{
			return new global::Org.BouncyCastle.Crypto.Prng.CryptoApiEntropySourceProvider.CryptoApiEntropySource(this.mRng, this.mPredictionResistant, bitsRequired);
		}

		// Token: 0x04000F88 RID: 3976
		private readonly global::System.Security.Cryptography.RandomNumberGenerator mRng;

		// Token: 0x04000F89 RID: 3977
		private readonly bool mPredictionResistant;

		// Token: 0x02000806 RID: 2054
		private class CryptoApiEntropySource : global::Org.BouncyCastle.Crypto.IEntropySource
		{
			// Token: 0x06004663 RID: 18019 RVA: 0x0013699C File Offset: 0x00134B9C
			internal CryptoApiEntropySource(global::System.Security.Cryptography.RandomNumberGenerator rng, bool predictionResistant, int entropySize)
			{
				this.mRng = rng;
				this.mPredictionResistant = predictionResistant;
				this.mEntropySize = entropySize;
			}

			// Token: 0x17000AA9 RID: 2729
			// (get) Token: 0x06004664 RID: 18020 RVA: 0x001369B9 File Offset: 0x00134BB9
			bool global::Org.BouncyCastle.Crypto.IEntropySource.IsPredictionResistant
			{
				get
				{
					return this.mPredictionResistant;
				}
			}

			// Token: 0x06004665 RID: 18021 RVA: 0x001369C4 File Offset: 0x00134BC4
			byte[] global::Org.BouncyCastle.Crypto.IEntropySource.GetEntropy()
			{
				byte[] result = new byte[(this.mEntropySize + 7) / 8];
				this.mRng.GetBytes(result);
				return result;
			}

			// Token: 0x17000AAA RID: 2730
			// (get) Token: 0x06004666 RID: 18022 RVA: 0x001369EE File Offset: 0x00134BEE
			int global::Org.BouncyCastle.Crypto.IEntropySource.EntropySize
			{
				get
				{
					return this.mEntropySize;
				}
			}

			// Token: 0x040024B6 RID: 9398
			private readonly global::System.Security.Cryptography.RandomNumberGenerator mRng;

			// Token: 0x040024B7 RID: 9399
			private readonly bool mPredictionResistant;

			// Token: 0x040024B8 RID: 9400
			private readonly int mEntropySize;
		}
	}
}
