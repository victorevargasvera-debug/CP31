using System;
using Org.BouncyCastle.Crypto.Prng.Drbg;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003BA RID: 954
	public class SP800SecureRandomBuilder
	{
		// Token: 0x060026A9 RID: 9897 RVA: 0x000A8390 File Offset: 0x000A6590
		public SP800SecureRandomBuilder() : this(new global::Org.BouncyCastle.Security.SecureRandom(), false)
		{
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x000A839E File Offset: 0x000A659E
		public SP800SecureRandomBuilder(global::Org.BouncyCastle.Security.SecureRandom entropySource, bool predictionResistant)
		{
			this.mSecurityStrength = 256;
			this.mEntropyBitsRequired = 256;
			base..ctor();
			this.mRandom = entropySource;
			this.mEntropySourceProvider = new global::Org.BouncyCastle.Crypto.Prng.BasicEntropySourceProvider(entropySource, predictionResistant);
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x000A83D0 File Offset: 0x000A65D0
		public SP800SecureRandomBuilder(global::Org.BouncyCastle.Crypto.IEntropySourceProvider entropySourceProvider)
		{
			this.mSecurityStrength = 256;
			this.mEntropyBitsRequired = 256;
			base..ctor();
			this.mRandom = null;
			this.mEntropySourceProvider = entropySourceProvider;
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x000A83FC File Offset: 0x000A65FC
		public global::Org.BouncyCastle.Crypto.Prng.SP800SecureRandomBuilder SetPersonalizationString(byte[] personalizationString)
		{
			this.mPersonalizationString = personalizationString;
			return this;
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x000A8406 File Offset: 0x000A6606
		public global::Org.BouncyCastle.Crypto.Prng.SP800SecureRandomBuilder SetSecurityStrength(int securityStrength)
		{
			this.mSecurityStrength = securityStrength;
			return this;
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x000A8410 File Offset: 0x000A6610
		public global::Org.BouncyCastle.Crypto.Prng.SP800SecureRandomBuilder SetEntropyBitsRequired(int entropyBitsRequired)
		{
			this.mEntropyBitsRequired = entropyBitsRequired;
			return this;
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x000A841A File Offset: 0x000A661A
		public global::Org.BouncyCastle.Crypto.Prng.SP800SecureRandom BuildHash(global::Org.BouncyCastle.Crypto.IDigest digest, byte[] nonce, bool predictionResistant)
		{
			return new global::Org.BouncyCastle.Crypto.Prng.SP800SecureRandom(this.mRandom, this.mEntropySourceProvider.Get(this.mEntropyBitsRequired), new global::Org.BouncyCastle.Crypto.Prng.SP800SecureRandomBuilder.HashDrbgProvider(digest, nonce, this.mPersonalizationString, this.mSecurityStrength), predictionResistant);
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x000A844C File Offset: 0x000A664C
		public global::Org.BouncyCastle.Crypto.Prng.SP800SecureRandom BuildCtr(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int keySizeInBits, byte[] nonce, bool predictionResistant)
		{
			return new global::Org.BouncyCastle.Crypto.Prng.SP800SecureRandom(this.mRandom, this.mEntropySourceProvider.Get(this.mEntropyBitsRequired), new global::Org.BouncyCastle.Crypto.Prng.SP800SecureRandomBuilder.CtrDrbgProvider(cipher, keySizeInBits, nonce, this.mPersonalizationString, this.mSecurityStrength), predictionResistant);
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x000A8480 File Offset: 0x000A6680
		public global::Org.BouncyCastle.Crypto.Prng.SP800SecureRandom BuildHMac(global::Org.BouncyCastle.Crypto.IMac hMac, byte[] nonce, bool predictionResistant)
		{
			return new global::Org.BouncyCastle.Crypto.Prng.SP800SecureRandom(this.mRandom, this.mEntropySourceProvider.Get(this.mEntropyBitsRequired), new global::Org.BouncyCastle.Crypto.Prng.SP800SecureRandomBuilder.HMacDrbgProvider(hMac, nonce, this.mPersonalizationString, this.mSecurityStrength), predictionResistant);
		}

		// Token: 0x04000F99 RID: 3993
		private readonly global::Org.BouncyCastle.Security.SecureRandom mRandom;

		// Token: 0x04000F9A RID: 3994
		private readonly global::Org.BouncyCastle.Crypto.IEntropySourceProvider mEntropySourceProvider;

		// Token: 0x04000F9B RID: 3995
		private byte[] mPersonalizationString;

		// Token: 0x04000F9C RID: 3996
		private int mSecurityStrength;

		// Token: 0x04000F9D RID: 3997
		private int mEntropyBitsRequired;

		// Token: 0x02000807 RID: 2055
		private class HashDrbgProvider : global::Org.BouncyCastle.Crypto.Prng.IDrbgProvider
		{
			// Token: 0x06004667 RID: 18023 RVA: 0x001369F6 File Offset: 0x00134BF6
			public HashDrbgProvider(global::Org.BouncyCastle.Crypto.IDigest digest, byte[] nonce, byte[] personalizationString, int securityStrength)
			{
				this.mDigest = digest;
				this.mNonce = nonce;
				this.mPersonalizationString = personalizationString;
				this.mSecurityStrength = securityStrength;
			}

			// Token: 0x06004668 RID: 18024 RVA: 0x00136A1B File Offset: 0x00134C1B
			public global::Org.BouncyCastle.Crypto.Prng.Drbg.ISP80090Drbg Get(global::Org.BouncyCastle.Crypto.IEntropySource entropySource)
			{
				return new global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg(this.mDigest, this.mSecurityStrength, entropySource, this.mPersonalizationString, this.mNonce);
			}

			// Token: 0x040024B9 RID: 9401
			private readonly global::Org.BouncyCastle.Crypto.IDigest mDigest;

			// Token: 0x040024BA RID: 9402
			private readonly byte[] mNonce;

			// Token: 0x040024BB RID: 9403
			private readonly byte[] mPersonalizationString;

			// Token: 0x040024BC RID: 9404
			private readonly int mSecurityStrength;
		}

		// Token: 0x02000808 RID: 2056
		private class HMacDrbgProvider : global::Org.BouncyCastle.Crypto.Prng.IDrbgProvider
		{
			// Token: 0x06004669 RID: 18025 RVA: 0x00136A3B File Offset: 0x00134C3B
			public HMacDrbgProvider(global::Org.BouncyCastle.Crypto.IMac hMac, byte[] nonce, byte[] personalizationString, int securityStrength)
			{
				this.mHMac = hMac;
				this.mNonce = nonce;
				this.mPersonalizationString = personalizationString;
				this.mSecurityStrength = securityStrength;
			}

			// Token: 0x0600466A RID: 18026 RVA: 0x00136A60 File Offset: 0x00134C60
			public global::Org.BouncyCastle.Crypto.Prng.Drbg.ISP80090Drbg Get(global::Org.BouncyCastle.Crypto.IEntropySource entropySource)
			{
				return new global::Org.BouncyCastle.Crypto.Prng.Drbg.HMacSP800Drbg(this.mHMac, this.mSecurityStrength, entropySource, this.mPersonalizationString, this.mNonce);
			}

			// Token: 0x040024BD RID: 9405
			private readonly global::Org.BouncyCastle.Crypto.IMac mHMac;

			// Token: 0x040024BE RID: 9406
			private readonly byte[] mNonce;

			// Token: 0x040024BF RID: 9407
			private readonly byte[] mPersonalizationString;

			// Token: 0x040024C0 RID: 9408
			private readonly int mSecurityStrength;
		}

		// Token: 0x02000809 RID: 2057
		private class CtrDrbgProvider : global::Org.BouncyCastle.Crypto.Prng.IDrbgProvider
		{
			// Token: 0x0600466B RID: 18027 RVA: 0x00136A80 File Offset: 0x00134C80
			public CtrDrbgProvider(global::Org.BouncyCastle.Crypto.IBlockCipher blockCipher, int keySizeInBits, byte[] nonce, byte[] personalizationString, int securityStrength)
			{
				this.mBlockCipher = blockCipher;
				this.mKeySizeInBits = keySizeInBits;
				this.mNonce = nonce;
				this.mPersonalizationString = personalizationString;
				this.mSecurityStrength = securityStrength;
			}

			// Token: 0x0600466C RID: 18028 RVA: 0x00136AAD File Offset: 0x00134CAD
			public global::Org.BouncyCastle.Crypto.Prng.Drbg.ISP80090Drbg Get(global::Org.BouncyCastle.Crypto.IEntropySource entropySource)
			{
				return new global::Org.BouncyCastle.Crypto.Prng.Drbg.CtrSP800Drbg(this.mBlockCipher, this.mKeySizeInBits, this.mSecurityStrength, entropySource, this.mPersonalizationString, this.mNonce);
			}

			// Token: 0x040024C1 RID: 9409
			private readonly global::Org.BouncyCastle.Crypto.IBlockCipher mBlockCipher;

			// Token: 0x040024C2 RID: 9410
			private readonly int mKeySizeInBits;

			// Token: 0x040024C3 RID: 9411
			private readonly byte[] mNonce;

			// Token: 0x040024C4 RID: 9412
			private readonly byte[] mPersonalizationString;

			// Token: 0x040024C5 RID: 9413
			private readonly int mSecurityStrength;
		}
	}
}
