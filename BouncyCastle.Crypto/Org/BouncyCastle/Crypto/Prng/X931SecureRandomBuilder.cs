using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003BF RID: 959
	public class X931SecureRandomBuilder
	{
		// Token: 0x060026C6 RID: 9926 RVA: 0x000A8B54 File Offset: 0x000A6D54
		public X931SecureRandomBuilder() : this(new global::Org.BouncyCastle.Security.SecureRandom(), false)
		{
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x000A8B62 File Offset: 0x000A6D62
		public X931SecureRandomBuilder(global::Org.BouncyCastle.Security.SecureRandom entropySource, bool predictionResistant)
		{
			this.mRandom = entropySource;
			this.mEntropySourceProvider = new global::Org.BouncyCastle.Crypto.Prng.BasicEntropySourceProvider(this.mRandom, predictionResistant);
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x000A8B83 File Offset: 0x000A6D83
		public X931SecureRandomBuilder(global::Org.BouncyCastle.Crypto.IEntropySourceProvider entropySourceProvider)
		{
			this.mRandom = null;
			this.mEntropySourceProvider = entropySourceProvider;
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x000A8B99 File Offset: 0x000A6D99
		public global::Org.BouncyCastle.Crypto.Prng.X931SecureRandomBuilder SetDateTimeVector(byte[] dateTimeVector)
		{
			this.mDateTimeVector = dateTimeVector;
			return this;
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x000A8BA4 File Offset: 0x000A6DA4
		public global::Org.BouncyCastle.Crypto.Prng.X931SecureRandom Build(global::Org.BouncyCastle.Crypto.IBlockCipher engine, global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key, bool predictionResistant)
		{
			if (this.mDateTimeVector == null)
			{
				this.mDateTimeVector = new byte[engine.GetBlockSize()];
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE((ulong)global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs(), this.mDateTimeVector, 0);
			}
			engine.Init(true, key);
			return new global::Org.BouncyCastle.Crypto.Prng.X931SecureRandom(this.mRandom, new global::Org.BouncyCastle.Crypto.Prng.X931Rng(engine, this.mDateTimeVector, this.mEntropySourceProvider.Get(engine.GetBlockSize() * 8)), predictionResistant);
		}

		// Token: 0x04000FAF RID: 4015
		private readonly global::Org.BouncyCastle.Security.SecureRandom mRandom;

		// Token: 0x04000FB0 RID: 4016
		private global::Org.BouncyCastle.Crypto.IEntropySourceProvider mEntropySourceProvider;

		// Token: 0x04000FB1 RID: 4017
		private byte[] mDateTimeVector;
	}
}
