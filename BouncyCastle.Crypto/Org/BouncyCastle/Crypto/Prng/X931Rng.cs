using System;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003BD RID: 957
	internal class X931Rng
	{
		// Token: 0x060026B9 RID: 9913 RVA: 0x000A86DC File Offset: 0x000A68DC
		internal X931Rng(global::Org.BouncyCastle.Crypto.IBlockCipher engine, byte[] dateTimeVector, global::Org.BouncyCastle.Crypto.IEntropySource entropySource)
		{
			this.mEngine = engine;
			this.mEntropySource = entropySource;
			this.mDT = new byte[engine.GetBlockSize()];
			global::System.Array.Copy(dateTimeVector, 0, this.mDT, 0, this.mDT.Length);
			this.mI = new byte[engine.GetBlockSize()];
			this.mR = new byte[engine.GetBlockSize()];
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x000A8750 File Offset: 0x000A6950
		internal int Generate(byte[] output, bool predictionResistant)
		{
			if (this.mR.Length == 8)
			{
				if (this.mReseedCounter > 32768L)
				{
					return -1;
				}
				if (global::Org.BouncyCastle.Crypto.Prng.X931Rng.IsTooLarge(output, 512))
				{
					throw new global::System.ArgumentException("Number of bits per request limited to " + 4096.ToString(), "output");
				}
			}
			else
			{
				if (this.mReseedCounter > 8388608L)
				{
					return -1;
				}
				if (global::Org.BouncyCastle.Crypto.Prng.X931Rng.IsTooLarge(output, 32768))
				{
					throw new global::System.ArgumentException("Number of bits per request limited to " + 262144.ToString(), "output");
				}
			}
			if (predictionResistant || this.mV == null)
			{
				this.mV = this.mEntropySource.GetEntropy();
				if (this.mV.Length != this.mEngine.GetBlockSize())
				{
					throw new global::System.InvalidOperationException("Insufficient entropy returned");
				}
			}
			int i = output.Length / this.mR.Length;
			for (int j = 0; j < i; j++)
			{
				this.mEngine.ProcessBlock(this.mDT, 0, this.mI, 0);
				this.Process(this.mR, this.mI, this.mV);
				this.Process(this.mV, this.mR, this.mI);
				global::System.Array.Copy(this.mR, 0, output, j * this.mR.Length, this.mR.Length);
				this.Increment(this.mDT);
			}
			int bytesToCopy = output.Length - i * this.mR.Length;
			if (bytesToCopy > 0)
			{
				this.mEngine.ProcessBlock(this.mDT, 0, this.mI, 0);
				this.Process(this.mR, this.mI, this.mV);
				this.Process(this.mV, this.mR, this.mI);
				global::System.Array.Copy(this.mR, 0, output, i * this.mR.Length, bytesToCopy);
				this.Increment(this.mDT);
			}
			this.mReseedCounter += 1L;
			return output.Length;
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x000A8943 File Offset: 0x000A6B43
		internal void Reseed()
		{
			this.mV = this.mEntropySource.GetEntropy();
			if (this.mV.Length != this.mEngine.GetBlockSize())
			{
				throw new global::System.InvalidOperationException("Insufficient entropy returned");
			}
			this.mReseedCounter = 1L;
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x000A897E File Offset: 0x000A6B7E
		internal global::Org.BouncyCastle.Crypto.IEntropySource EntropySource
		{
			get
			{
				return this.mEntropySource;
			}
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x000A8988 File Offset: 0x000A6B88
		private void Process(byte[] res, byte[] a, byte[] b)
		{
			for (int i = 0; i != res.Length; i++)
			{
				res[i] = (a[i] ^ b[i]);
			}
			this.mEngine.ProcessBlock(res, 0, res, 0);
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000A89C0 File Offset: 0x000A6BC0
		private void Increment(byte[] val)
		{
			for (int i = val.Length - 1; i >= 0; i--)
			{
				int num = i;
				byte b = val[num] + 1;
				val[num] = b;
				if (b != 0)
				{
					break;
				}
			}
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x000A89EF File Offset: 0x000A6BEF
		private static bool IsTooLarge(byte[] bytes, int maxBytes)
		{
			return bytes != null && bytes.Length > maxBytes;
		}

		// Token: 0x04000FA1 RID: 4001
		private const long BLOCK64_RESEED_MAX = 32768L;

		// Token: 0x04000FA2 RID: 4002
		private const long BLOCK128_RESEED_MAX = 8388608L;

		// Token: 0x04000FA3 RID: 4003
		private const int BLOCK64_MAX_BITS_REQUEST = 4096;

		// Token: 0x04000FA4 RID: 4004
		private const int BLOCK128_MAX_BITS_REQUEST = 262144;

		// Token: 0x04000FA5 RID: 4005
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher mEngine;

		// Token: 0x04000FA6 RID: 4006
		private readonly global::Org.BouncyCastle.Crypto.IEntropySource mEntropySource;

		// Token: 0x04000FA7 RID: 4007
		private readonly byte[] mDT;

		// Token: 0x04000FA8 RID: 4008
		private readonly byte[] mI;

		// Token: 0x04000FA9 RID: 4009
		private readonly byte[] mR;

		// Token: 0x04000FAA RID: 4010
		private byte[] mV;

		// Token: 0x04000FAB RID: 4011
		private long mReseedCounter = 1L;
	}
}
