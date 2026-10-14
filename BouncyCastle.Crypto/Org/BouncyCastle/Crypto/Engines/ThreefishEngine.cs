using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004BC RID: 1212
	public class ThreefishEngine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002EEC RID: 12012 RVA: 0x000D7144 File Offset: 0x000D5344
		static ThreefishEngine()
		{
			for (int i = 0; i < global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD9.Length; i++)
			{
				global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD17[i] = i % 17;
				global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD9[i] = i % 9;
				global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD5[i] = i % 5;
				global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD3[i] = i % 3;
			}
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x000D71CC File Offset: 0x000D53CC
		public ThreefishEngine(int blocksizeBits)
		{
			this.blocksizeBytes = blocksizeBits / 8;
			this.blocksizeWords = this.blocksizeBytes / 8;
			this.currentBlock = new ulong[this.blocksizeWords];
			this.kw = new ulong[2 * this.blocksizeWords + 1];
			if (blocksizeBits == 256)
			{
				this.cipher = new global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.Threefish256Cipher(this.kw, this.t);
				return;
			}
			if (blocksizeBits == 512)
			{
				this.cipher = new global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.Threefish512Cipher(this.kw, this.t);
				return;
			}
			if (blocksizeBits != 1024)
			{
				throw new global::System.ArgumentException("Invalid blocksize - Threefish is defined with block size of 256, 512, or 1024 bits");
			}
			this.cipher = new global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.Threefish1024Cipher(this.kw, this.t);
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x000D7294 File Offset: 0x000D5494
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			byte[] keyBytes;
			byte[] tweakBytes;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.TweakableBlockCipherParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.TweakableBlockCipherParameters tweakableBlockCipherParameters = (global::Org.BouncyCastle.Crypto.Parameters.TweakableBlockCipherParameters)parameters;
				keyBytes = tweakableBlockCipherParameters.Key.GetKey();
				tweakBytes = tweakableBlockCipherParameters.Tweak;
			}
			else
			{
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
				{
					throw new global::System.ArgumentException("Invalid parameter passed to Threefish init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
				}
				keyBytes = ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey();
				tweakBytes = null;
			}
			ulong[] keyWords = null;
			ulong[] tweakWords = null;
			if (keyBytes != null)
			{
				if (keyBytes.Length != this.blocksizeBytes)
				{
					throw new global::System.ArgumentException("Threefish key must be same size as block (" + this.blocksizeBytes.ToString() + " bytes)");
				}
				keyWords = new ulong[this.blocksizeWords];
				for (int i = 0; i < keyWords.Length; i++)
				{
					keyWords[i] = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.BytesToWord(keyBytes, i * 8);
				}
			}
			if (tweakBytes != null)
			{
				if (tweakBytes.Length != 16)
				{
					throw new global::System.ArgumentException("Threefish tweak must be " + 16.ToString() + " bytes");
				}
				tweakWords = new ulong[]
				{
					global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.BytesToWord(tweakBytes, 0),
					global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.BytesToWord(tweakBytes, 8)
				};
			}
			this.Init(forEncryption, keyWords, tweakWords);
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x000D73A1 File Offset: 0x000D55A1
		internal void Init(bool forEncryption, ulong[] key, ulong[] tweak)
		{
			this.forEncryption = forEncryption;
			if (key != null)
			{
				this.SetKey(key);
			}
			if (tweak != null)
			{
				this.SetTweak(tweak);
			}
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x000D73C0 File Offset: 0x000D55C0
		private void SetKey(ulong[] key)
		{
			if (key.Length != this.blocksizeWords)
			{
				throw new global::System.ArgumentException("Threefish key must be same size as block (" + this.blocksizeWords.ToString() + " words)");
			}
			ulong knw = 2004413935125273122UL;
			for (int i = 0; i < this.blocksizeWords; i++)
			{
				this.kw[i] = key[i];
				knw ^= this.kw[i];
			}
			this.kw[this.blocksizeWords] = knw;
			global::System.Array.Copy(this.kw, 0, this.kw, this.blocksizeWords + 1, this.blocksizeWords);
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x000D745C File Offset: 0x000D565C
		private void SetTweak(ulong[] tweak)
		{
			if (tweak.Length != 2)
			{
				throw new global::System.ArgumentException("Tweak must be " + 2.ToString() + " words.");
			}
			this.t[0] = tweak[0];
			this.t[1] = tweak[1];
			this.t[2] = (this.t[0] ^ this.t[1]);
			this.t[3] = this.t[0];
			this.t[4] = this.t[1];
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06002EF2 RID: 12018 RVA: 0x000D74DC File Offset: 0x000D56DC
		public virtual string AlgorithmName
		{
			get
			{
				return "Threefish-" + (this.blocksizeBytes * 8).ToString();
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x000D7503 File Offset: 0x000D5703
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x000D7506 File Offset: 0x000D5706
		public virtual int GetBlockSize()
		{
			return this.blocksizeBytes;
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x000D750E File Offset: 0x000D570E
		public virtual void Reset()
		{
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x000D7510 File Offset: 0x000D5710
		public virtual int ProcessBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			if (outOff + this.blocksizeBytes > outBytes.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Output buffer too short");
			}
			if (inOff + this.blocksizeBytes > inBytes.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Input buffer too short");
			}
			for (int i = 0; i < this.blocksizeBytes; i += 8)
			{
				this.currentBlock[i >> 3] = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.BytesToWord(inBytes, inOff + i);
			}
			this.ProcessBlock(this.currentBlock, this.currentBlock);
			for (int j = 0; j < this.blocksizeBytes; j += 8)
			{
				global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.WordToBytes(this.currentBlock[j >> 3], outBytes, outOff + j);
			}
			return this.blocksizeBytes;
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x000D75B0 File Offset: 0x000D57B0
		internal int ProcessBlock(ulong[] inWords, ulong[] outWords)
		{
			if (this.kw[this.blocksizeWords] == 0UL)
			{
				throw new global::System.InvalidOperationException("Threefish engine not initialised");
			}
			if (inWords.Length != this.blocksizeWords)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Input buffer too short");
			}
			if (outWords.Length != this.blocksizeWords)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Output buffer too short");
			}
			if (this.forEncryption)
			{
				this.cipher.EncryptBlock(inWords, outWords);
			}
			else
			{
				this.cipher.DecryptBlock(inWords, outWords);
			}
			return this.blocksizeWords;
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x000D7630 File Offset: 0x000D5830
		internal static ulong BytesToWord(byte[] bytes, int off)
		{
			if (off + 8 > bytes.Length)
			{
				throw new global::System.ArgumentException();
			}
			int index = off + 1;
			return ((ulong)bytes[off] & 255UL) | ((ulong)bytes[index++] & 255UL) << 8 | ((ulong)bytes[index++] & 255UL) << 16 | ((ulong)bytes[index++] & 255UL) << 24 | ((ulong)bytes[index++] & 255UL) << 32 | ((ulong)bytes[index++] & 255UL) << 40 | ((ulong)bytes[index++] & 255UL) << 48 | ((ulong)bytes[index++] & 255UL) << 56;
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x000D76E0 File Offset: 0x000D58E0
		internal static void WordToBytes(ulong word, byte[] bytes, int off)
		{
			if (off + 8 > bytes.Length)
			{
				throw new global::System.ArgumentException();
			}
			int index = off + 1;
			bytes[off] = (byte)word;
			bytes[index++] = (byte)(word >> 8);
			bytes[index++] = (byte)(word >> 16);
			bytes[index++] = (byte)(word >> 24);
			bytes[index++] = (byte)(word >> 32);
			bytes[index++] = (byte)(word >> 40);
			bytes[index++] = (byte)(word >> 48);
			bytes[index++] = (byte)(word >> 56);
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x000D7759 File Offset: 0x000D5959
		private static ulong RotlXor(ulong x, int n, ulong xor)
		{
			return (x << n | x >> 64 - n) ^ xor;
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x000D7770 File Offset: 0x000D5970
		private static ulong XorRotr(ulong x, int n, ulong xor)
		{
			ulong xored = x ^ xor;
			return xored >> n | xored << 64 - n;
		}

		// Token: 0x040013F4 RID: 5108
		public const int BLOCKSIZE_256 = 256;

		// Token: 0x040013F5 RID: 5109
		public const int BLOCKSIZE_512 = 512;

		// Token: 0x040013F6 RID: 5110
		public const int BLOCKSIZE_1024 = 1024;

		// Token: 0x040013F7 RID: 5111
		private const int TWEAK_SIZE_BYTES = 16;

		// Token: 0x040013F8 RID: 5112
		private const int TWEAK_SIZE_WORDS = 2;

		// Token: 0x040013F9 RID: 5113
		private const int ROUNDS_256 = 72;

		// Token: 0x040013FA RID: 5114
		private const int ROUNDS_512 = 72;

		// Token: 0x040013FB RID: 5115
		private const int ROUNDS_1024 = 80;

		// Token: 0x040013FC RID: 5116
		private const int MAX_ROUNDS = 80;

		// Token: 0x040013FD RID: 5117
		private const ulong C_240 = 2004413935125273122UL;

		// Token: 0x040013FE RID: 5118
		private static readonly int[] MOD9 = new int[80];

		// Token: 0x040013FF RID: 5119
		private static readonly int[] MOD17 = new int[global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD9.Length];

		// Token: 0x04001400 RID: 5120
		private static readonly int[] MOD5 = new int[global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD9.Length];

		// Token: 0x04001401 RID: 5121
		private static readonly int[] MOD3 = new int[global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD9.Length];

		// Token: 0x04001402 RID: 5122
		private readonly int blocksizeBytes;

		// Token: 0x04001403 RID: 5123
		private readonly int blocksizeWords;

		// Token: 0x04001404 RID: 5124
		private readonly ulong[] currentBlock;

		// Token: 0x04001405 RID: 5125
		private readonly ulong[] t = new ulong[5];

		// Token: 0x04001406 RID: 5126
		private readonly ulong[] kw;

		// Token: 0x04001407 RID: 5127
		private readonly global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.ThreefishCipher cipher;

		// Token: 0x04001408 RID: 5128
		private bool forEncryption;

		// Token: 0x02000810 RID: 2064
		private abstract class ThreefishCipher
		{
			// Token: 0x06004683 RID: 18051 RVA: 0x00136FC6 File Offset: 0x001351C6
			protected ThreefishCipher(ulong[] kw, ulong[] t)
			{
				this.kw = kw;
				this.t = t;
			}

			// Token: 0x06004684 RID: 18052
			internal abstract void EncryptBlock(ulong[] block, ulong[] outWords);

			// Token: 0x06004685 RID: 18053
			internal abstract void DecryptBlock(ulong[] block, ulong[] outWords);

			// Token: 0x040024DC RID: 9436
			protected readonly ulong[] t;

			// Token: 0x040024DD RID: 9437
			protected readonly ulong[] kw;
		}

		// Token: 0x02000811 RID: 2065
		private sealed class Threefish256Cipher : global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.ThreefishCipher
		{
			// Token: 0x06004686 RID: 18054 RVA: 0x00136FDC File Offset: 0x001351DC
			public Threefish256Cipher(ulong[] kw, ulong[] t) : base(kw, t)
			{
			}

			// Token: 0x06004687 RID: 18055 RVA: 0x00136FE8 File Offset: 0x001351E8
			internal override void EncryptBlock(ulong[] block, ulong[] outWords)
			{
				ulong[] kw = this.kw;
				ulong[] t = this.t;
				int[] mod5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD5;
				int[] mod6 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD3;
				if (kw.Length != 9)
				{
					throw new global::System.ArgumentException();
				}
				if (t.Length != 5)
				{
					throw new global::System.ArgumentException();
				}
				ulong b0 = block[0];
				ulong b = block[1];
				ulong b2 = block[2];
				ulong b3 = block[3];
				b0 += kw[0];
				b += kw[1] + t[0];
				b2 += kw[2] + t[1];
				b3 += kw[3];
				for (int d = 1; d < 18; d += 2)
				{
					int dm5 = mod5[d];
					int dm6 = mod6[d];
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 14, b0 += b);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 16, b2 += b3);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 52, b0 += b3);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 57, b2 += b);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 23, b0 += b);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 40, b2 += b3);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 5, b0 += b3);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 37, b2 += b);
					b0 += kw[dm5];
					b += kw[dm5 + 1] + t[dm6];
					b2 += kw[dm5 + 2] + t[dm6 + 1];
					b3 += kw[dm5 + 3] + (ulong)d;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 25, b0 += b);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 33, b2 += b3);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 46, b0 += b3);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 12, b2 += b);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 58, b0 += b);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 22, b2 += b3);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 32, b0 += b3);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 32, b2 += b);
					b0 += kw[dm5 + 1];
					b += kw[dm5 + 2] + t[dm6 + 1];
					b2 += kw[dm5 + 3] + t[dm6 + 2];
					b3 += kw[dm5 + 4] + (ulong)d + 1UL;
				}
				outWords[0] = b0;
				outWords[1] = b;
				outWords[2] = b2;
				outWords[3] = b3;
			}

			// Token: 0x06004688 RID: 18056 RVA: 0x00137248 File Offset: 0x00135448
			internal override void DecryptBlock(ulong[] block, ulong[] state)
			{
				ulong[] kw = this.kw;
				ulong[] t = this.t;
				int[] mod5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD5;
				int[] mod6 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD3;
				if (kw.Length != 9)
				{
					throw new global::System.ArgumentException();
				}
				if (t.Length != 5)
				{
					throw new global::System.ArgumentException();
				}
				ulong b0 = block[0];
				ulong b = block[1];
				ulong b2 = block[2];
				ulong b3 = block[3];
				for (int d = 17; d >= 1; d -= 2)
				{
					int dm5 = mod5[d];
					int dm6 = mod6[d];
					b0 -= kw[dm5 + 1];
					b -= kw[dm5 + 2] + t[dm6 + 1];
					b2 -= kw[dm5 + 3] + t[dm6 + 2];
					b3 -= kw[dm5 + 4] + (ulong)d + 1UL;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 32, b0);
					b0 -= b3;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 32, b2);
					b2 -= b;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 58, b0);
					b0 -= b;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 22, b2);
					b2 -= b3;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 46, b0);
					b0 -= b3;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 12, b2);
					b2 -= b;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 25, b0);
					b0 -= b;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 33, b2);
					b2 -= b3;
					b0 -= kw[dm5];
					b -= kw[dm5 + 1] + t[dm6];
					b2 -= kw[dm5 + 2] + t[dm6 + 1];
					b3 -= kw[dm5 + 3] + (ulong)d;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 5, b0);
					b0 -= b3;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 37, b2);
					b2 -= b;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 23, b0);
					b0 -= b;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 40, b2);
					b2 -= b3;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 52, b0);
					b0 -= b3;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 57, b2);
					b2 -= b;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 14, b0);
					b0 -= b;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 16, b2);
					b2 -= b3;
				}
				b0 -= kw[0];
				b -= kw[1] + t[0];
				b2 -= kw[2] + t[1];
				b3 -= kw[3];
				state[0] = b0;
				state[1] = b;
				state[2] = b2;
				state[3] = b3;
			}

			// Token: 0x040024DE RID: 9438
			private const int ROTATION_0_0 = 14;

			// Token: 0x040024DF RID: 9439
			private const int ROTATION_0_1 = 16;

			// Token: 0x040024E0 RID: 9440
			private const int ROTATION_1_0 = 52;

			// Token: 0x040024E1 RID: 9441
			private const int ROTATION_1_1 = 57;

			// Token: 0x040024E2 RID: 9442
			private const int ROTATION_2_0 = 23;

			// Token: 0x040024E3 RID: 9443
			private const int ROTATION_2_1 = 40;

			// Token: 0x040024E4 RID: 9444
			private const int ROTATION_3_0 = 5;

			// Token: 0x040024E5 RID: 9445
			private const int ROTATION_3_1 = 37;

			// Token: 0x040024E6 RID: 9446
			private const int ROTATION_4_0 = 25;

			// Token: 0x040024E7 RID: 9447
			private const int ROTATION_4_1 = 33;

			// Token: 0x040024E8 RID: 9448
			private const int ROTATION_5_0 = 46;

			// Token: 0x040024E9 RID: 9449
			private const int ROTATION_5_1 = 12;

			// Token: 0x040024EA RID: 9450
			private const int ROTATION_6_0 = 58;

			// Token: 0x040024EB RID: 9451
			private const int ROTATION_6_1 = 22;

			// Token: 0x040024EC RID: 9452
			private const int ROTATION_7_0 = 32;

			// Token: 0x040024ED RID: 9453
			private const int ROTATION_7_1 = 32;
		}

		// Token: 0x02000812 RID: 2066
		private sealed class Threefish512Cipher : global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.ThreefishCipher
		{
			// Token: 0x06004689 RID: 18057 RVA: 0x001374B5 File Offset: 0x001356B5
			internal Threefish512Cipher(ulong[] kw, ulong[] t) : base(kw, t)
			{
			}

			// Token: 0x0600468A RID: 18058 RVA: 0x001374C0 File Offset: 0x001356C0
			internal override void EncryptBlock(ulong[] block, ulong[] outWords)
			{
				ulong[] kw = this.kw;
				ulong[] t = this.t;
				int[] mod9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD9;
				int[] mod10 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD3;
				if (kw.Length != 17)
				{
					throw new global::System.ArgumentException();
				}
				if (t.Length != 5)
				{
					throw new global::System.ArgumentException();
				}
				ulong b0 = block[0];
				ulong b = block[1];
				ulong b2 = block[2];
				ulong b3 = block[3];
				ulong b4 = block[4];
				ulong b5 = block[5];
				ulong b6 = block[6];
				ulong b7 = block[7];
				b0 += kw[0];
				b += kw[1];
				b2 += kw[2];
				b3 += kw[3];
				b4 += kw[4];
				b5 += kw[5] + t[0];
				b6 += kw[6] + t[1];
				b7 += kw[7];
				for (int d = 1; d < 18; d += 2)
				{
					int dm9 = mod9[d];
					int dm10 = mod10[d];
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 46, b0 += b);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 36, b2 += b3);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 19, b4 += b5);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 37, b6 += b7);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 33, b2 += b);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 27, b4 += b7);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 14, b6 += b5);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 42, b0 += b3);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 17, b4 += b);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 49, b6 += b3);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 36, b0 += b5);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 39, b2 += b7);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 44, b6 += b);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 9, b0 += b7);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 54, b2 += b5);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 56, b4 += b3);
					b0 += kw[dm9];
					b += kw[dm9 + 1];
					b2 += kw[dm9 + 2];
					b3 += kw[dm9 + 3];
					b4 += kw[dm9 + 4];
					b5 += kw[dm9 + 5] + t[dm10];
					b6 += kw[dm9 + 6] + t[dm10 + 1];
					b7 += kw[dm9 + 7] + (ulong)d;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 39, b0 += b);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 30, b2 += b3);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 34, b4 += b5);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 24, b6 += b7);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 13, b2 += b);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 50, b4 += b7);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 10, b6 += b5);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 17, b0 += b3);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 25, b4 += b);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 29, b6 += b3);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 39, b0 += b5);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 43, b2 += b7);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 8, b6 += b);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 35, b0 += b7);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 56, b2 += b5);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 22, b4 += b3);
					b0 += kw[dm9 + 1];
					b += kw[dm9 + 2];
					b2 += kw[dm9 + 3];
					b3 += kw[dm9 + 4];
					b4 += kw[dm9 + 5];
					b5 += kw[dm9 + 6] + t[dm10 + 1];
					b6 += kw[dm9 + 7] + t[dm10 + 2];
					b7 += kw[dm9 + 8] + (ulong)d + 1UL;
				}
				outWords[0] = b0;
				outWords[1] = b;
				outWords[2] = b2;
				outWords[3] = b3;
				outWords[4] = b4;
				outWords[5] = b5;
				outWords[6] = b6;
				outWords[7] = b7;
			}

			// Token: 0x0600468B RID: 18059 RVA: 0x001378F0 File Offset: 0x00135AF0
			internal override void DecryptBlock(ulong[] block, ulong[] state)
			{
				ulong[] kw = this.kw;
				ulong[] t = this.t;
				int[] mod9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD9;
				int[] mod10 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD3;
				if (kw.Length != 17)
				{
					throw new global::System.ArgumentException();
				}
				if (t.Length != 5)
				{
					throw new global::System.ArgumentException();
				}
				ulong b0 = block[0];
				ulong b = block[1];
				ulong b2 = block[2];
				ulong b3 = block[3];
				ulong b4 = block[4];
				ulong b5 = block[5];
				ulong b6 = block[6];
				ulong b7 = block[7];
				for (int d = 17; d >= 1; d -= 2)
				{
					int dm9 = mod9[d];
					int dm10 = mod10[d];
					b0 -= kw[dm9 + 1];
					b -= kw[dm9 + 2];
					b2 -= kw[dm9 + 3];
					b3 -= kw[dm9 + 4];
					b4 -= kw[dm9 + 5];
					b5 -= kw[dm9 + 6] + t[dm10 + 1];
					b6 -= kw[dm9 + 7] + t[dm10 + 2];
					b7 -= kw[dm9 + 8] + (ulong)d + 1UL;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 8, b6);
					b6 -= b;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 35, b0);
					b0 -= b7;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 56, b2);
					b2 -= b5;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 22, b4);
					b4 -= b3;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 25, b4);
					b4 -= b;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 29, b6);
					b6 -= b3;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 39, b0);
					b0 -= b5;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 43, b2);
					b2 -= b7;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 13, b2);
					b2 -= b;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 50, b4);
					b4 -= b7;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 10, b6);
					b6 -= b5;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 17, b0);
					b0 -= b3;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 39, b0);
					b0 -= b;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 30, b2);
					b2 -= b3;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 34, b4);
					b4 -= b5;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 24, b6);
					b6 -= b7;
					b0 -= kw[dm9];
					b -= kw[dm9 + 1];
					b2 -= kw[dm9 + 2];
					b3 -= kw[dm9 + 3];
					b4 -= kw[dm9 + 4];
					b5 -= kw[dm9 + 5] + t[dm10];
					b6 -= kw[dm9 + 6] + t[dm10 + 1];
					b7 -= kw[dm9 + 7] + (ulong)d;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 44, b6);
					b6 -= b;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 9, b0);
					b0 -= b7;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 54, b2);
					b2 -= b5;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 56, b4);
					b4 -= b3;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 17, b4);
					b4 -= b;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 49, b6);
					b6 -= b3;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 36, b0);
					b0 -= b5;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 39, b2);
					b2 -= b7;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 33, b2);
					b2 -= b;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 27, b4);
					b4 -= b7;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 14, b6);
					b6 -= b5;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 42, b0);
					b0 -= b3;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 46, b0);
					b0 -= b;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 36, b2);
					b2 -= b3;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 19, b4);
					b4 -= b5;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 37, b6);
					b6 -= b7;
				}
				b0 -= kw[0];
				b -= kw[1];
				b2 -= kw[2];
				b3 -= kw[3];
				b4 -= kw[4];
				b5 -= kw[5] + t[0];
				b6 -= kw[6] + t[1];
				b7 -= kw[7];
				state[0] = b0;
				state[1] = b;
				state[2] = b2;
				state[3] = b3;
				state[4] = b4;
				state[5] = b5;
				state[6] = b6;
				state[7] = b7;
			}

			// Token: 0x040024EE RID: 9454
			private const int ROTATION_0_0 = 46;

			// Token: 0x040024EF RID: 9455
			private const int ROTATION_0_1 = 36;

			// Token: 0x040024F0 RID: 9456
			private const int ROTATION_0_2 = 19;

			// Token: 0x040024F1 RID: 9457
			private const int ROTATION_0_3 = 37;

			// Token: 0x040024F2 RID: 9458
			private const int ROTATION_1_0 = 33;

			// Token: 0x040024F3 RID: 9459
			private const int ROTATION_1_1 = 27;

			// Token: 0x040024F4 RID: 9460
			private const int ROTATION_1_2 = 14;

			// Token: 0x040024F5 RID: 9461
			private const int ROTATION_1_3 = 42;

			// Token: 0x040024F6 RID: 9462
			private const int ROTATION_2_0 = 17;

			// Token: 0x040024F7 RID: 9463
			private const int ROTATION_2_1 = 49;

			// Token: 0x040024F8 RID: 9464
			private const int ROTATION_2_2 = 36;

			// Token: 0x040024F9 RID: 9465
			private const int ROTATION_2_3 = 39;

			// Token: 0x040024FA RID: 9466
			private const int ROTATION_3_0 = 44;

			// Token: 0x040024FB RID: 9467
			private const int ROTATION_3_1 = 9;

			// Token: 0x040024FC RID: 9468
			private const int ROTATION_3_2 = 54;

			// Token: 0x040024FD RID: 9469
			private const int ROTATION_3_3 = 56;

			// Token: 0x040024FE RID: 9470
			private const int ROTATION_4_0 = 39;

			// Token: 0x040024FF RID: 9471
			private const int ROTATION_4_1 = 30;

			// Token: 0x04002500 RID: 9472
			private const int ROTATION_4_2 = 34;

			// Token: 0x04002501 RID: 9473
			private const int ROTATION_4_3 = 24;

			// Token: 0x04002502 RID: 9474
			private const int ROTATION_5_0 = 13;

			// Token: 0x04002503 RID: 9475
			private const int ROTATION_5_1 = 50;

			// Token: 0x04002504 RID: 9476
			private const int ROTATION_5_2 = 10;

			// Token: 0x04002505 RID: 9477
			private const int ROTATION_5_3 = 17;

			// Token: 0x04002506 RID: 9478
			private const int ROTATION_6_0 = 25;

			// Token: 0x04002507 RID: 9479
			private const int ROTATION_6_1 = 29;

			// Token: 0x04002508 RID: 9480
			private const int ROTATION_6_2 = 39;

			// Token: 0x04002509 RID: 9481
			private const int ROTATION_6_3 = 43;

			// Token: 0x0400250A RID: 9482
			private const int ROTATION_7_0 = 8;

			// Token: 0x0400250B RID: 9483
			private const int ROTATION_7_1 = 35;

			// Token: 0x0400250C RID: 9484
			private const int ROTATION_7_2 = 56;

			// Token: 0x0400250D RID: 9485
			private const int ROTATION_7_3 = 22;
		}

		// Token: 0x02000813 RID: 2067
		private sealed class Threefish1024Cipher : global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.ThreefishCipher
		{
			// Token: 0x0600468C RID: 18060 RVA: 0x00137D3D File Offset: 0x00135F3D
			public Threefish1024Cipher(ulong[] kw, ulong[] t) : base(kw, t)
			{
			}

			// Token: 0x0600468D RID: 18061 RVA: 0x00137D48 File Offset: 0x00135F48
			internal override void EncryptBlock(ulong[] block, ulong[] outWords)
			{
				ulong[] kw = this.kw;
				ulong[] t = this.t;
				int[] mod17 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD17;
				int[] mod18 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD3;
				if (kw.Length != 33)
				{
					throw new global::System.ArgumentException();
				}
				if (t.Length != 5)
				{
					throw new global::System.ArgumentException();
				}
				ulong b0 = block[0];
				ulong b = block[1];
				ulong b2 = block[2];
				ulong b3 = block[3];
				ulong b4 = block[4];
				ulong b5 = block[5];
				ulong b6 = block[6];
				ulong b7 = block[7];
				ulong b8 = block[8];
				ulong b9 = block[9];
				ulong b10 = block[10];
				ulong b11 = block[11];
				ulong b12 = block[12];
				ulong b13 = block[13];
				ulong b14 = block[14];
				ulong b15 = block[15];
				b0 += kw[0];
				b += kw[1];
				b2 += kw[2];
				b3 += kw[3];
				b4 += kw[4];
				b5 += kw[5];
				b6 += kw[6];
				b7 += kw[7];
				b8 += kw[8];
				b9 += kw[9];
				b10 += kw[10];
				b11 += kw[11];
				b12 += kw[12];
				b13 += kw[13] + t[0];
				b14 += kw[14] + t[1];
				b15 += kw[15];
				for (int d = 1; d < 20; d += 2)
				{
					int dm17 = mod17[d];
					int dm18 = mod18[d];
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 24, b0 += b);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 13, b2 += b3);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 8, b4 += b5);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 47, b6 += b7);
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b9, 8, b8 += b9);
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b11, 17, b10 += b11);
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b13, 22, b12 += b13);
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b15, 37, b14 += b15);
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b9, 38, b0 += b9);
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b13, 19, b2 += b13);
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b11, 10, b6 += b11);
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b15, 55, b4 += b15);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 49, b10 += b7);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 18, b12 += b3);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 23, b14 += b5);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 52, b8 += b);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 33, b0 += b7);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 4, b2 += b5);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 51, b4 += b3);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 13, b6 += b);
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b15, 34, b12 += b15);
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b13, 41, b14 += b13);
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b11, 59, b8 += b11);
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b9, 17, b10 += b9);
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b15, 5, b0 += b15);
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b11, 20, b2 += b11);
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b13, 48, b6 += b13);
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b9, 41, b4 += b9);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 47, b14 += b);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 28, b8 += b5);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 16, b10 += b3);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 25, b12 += b7);
					b0 += kw[dm17];
					b += kw[dm17 + 1];
					b2 += kw[dm17 + 2];
					b3 += kw[dm17 + 3];
					b4 += kw[dm17 + 4];
					b5 += kw[dm17 + 5];
					b6 += kw[dm17 + 6];
					b7 += kw[dm17 + 7];
					b8 += kw[dm17 + 8];
					b9 += kw[dm17 + 9];
					b10 += kw[dm17 + 10];
					b11 += kw[dm17 + 11];
					b12 += kw[dm17 + 12];
					b13 += kw[dm17 + 13] + t[dm18];
					b14 += kw[dm17 + 14] + t[dm18 + 1];
					b15 += kw[dm17 + 15] + (ulong)d;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 41, b0 += b);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 9, b2 += b3);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 37, b4 += b5);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 31, b6 += b7);
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b9, 12, b8 += b9);
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b11, 47, b10 += b11);
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b13, 44, b12 += b13);
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b15, 30, b14 += b15);
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b9, 16, b0 += b9);
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b13, 34, b2 += b13);
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b11, 56, b6 += b11);
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b15, 51, b4 += b15);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 4, b10 += b7);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 53, b12 += b3);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 42, b14 += b5);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 41, b8 += b);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 31, b0 += b7);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 44, b2 += b5);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 47, b4 += b3);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 46, b6 += b);
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b15, 19, b12 += b15);
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b13, 42, b14 += b13);
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b11, 44, b8 += b11);
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b9, 25, b10 += b9);
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b15, 9, b0 += b15);
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b11, 48, b2 += b11);
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b13, 35, b6 += b13);
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b9, 52, b4 += b9);
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b, 23, b14 += b);
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b5, 31, b8 += b5);
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b3, 37, b10 += b3);
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.RotlXor(b7, 20, b12 += b7);
					b0 += kw[dm17 + 1];
					b += kw[dm17 + 2];
					b2 += kw[dm17 + 3];
					b3 += kw[dm17 + 4];
					b4 += kw[dm17 + 5];
					b5 += kw[dm17 + 6];
					b6 += kw[dm17 + 7];
					b7 += kw[dm17 + 8];
					b8 += kw[dm17 + 9];
					b9 += kw[dm17 + 10];
					b10 += kw[dm17 + 11];
					b11 += kw[dm17 + 12];
					b12 += kw[dm17 + 13];
					b13 += kw[dm17 + 14] + t[dm18 + 1];
					b14 += kw[dm17 + 15] + t[dm18 + 2];
					b15 += kw[dm17 + 16] + (ulong)d + 1UL;
				}
				outWords[0] = b0;
				outWords[1] = b;
				outWords[2] = b2;
				outWords[3] = b3;
				outWords[4] = b4;
				outWords[5] = b5;
				outWords[6] = b6;
				outWords[7] = b7;
				outWords[8] = b8;
				outWords[9] = b9;
				outWords[10] = b10;
				outWords[11] = b11;
				outWords[12] = b12;
				outWords[13] = b13;
				outWords[14] = b14;
				outWords[15] = b15;
			}

			// Token: 0x0600468E RID: 18062 RVA: 0x00138538 File Offset: 0x00136738
			internal override void DecryptBlock(ulong[] block, ulong[] state)
			{
				ulong[] kw = this.kw;
				ulong[] t = this.t;
				int[] mod17 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD17;
				int[] mod18 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.MOD3;
				if (kw.Length != 33)
				{
					throw new global::System.ArgumentException();
				}
				if (t.Length != 5)
				{
					throw new global::System.ArgumentException();
				}
				ulong b0 = block[0];
				ulong b = block[1];
				ulong b2 = block[2];
				ulong b3 = block[3];
				ulong b4 = block[4];
				ulong b5 = block[5];
				ulong b6 = block[6];
				ulong b7 = block[7];
				ulong b8 = block[8];
				ulong b9 = block[9];
				ulong b10 = block[10];
				ulong b11 = block[11];
				ulong b12 = block[12];
				ulong b13 = block[13];
				ulong b14 = block[14];
				ulong b15 = block[15];
				for (int d = 19; d >= 1; d -= 2)
				{
					int dm17 = mod17[d];
					int dm18 = mod18[d];
					b0 -= kw[dm17 + 1];
					b -= kw[dm17 + 2];
					b2 -= kw[dm17 + 3];
					b3 -= kw[dm17 + 4];
					b4 -= kw[dm17 + 5];
					b5 -= kw[dm17 + 6];
					b6 -= kw[dm17 + 7];
					b7 -= kw[dm17 + 8];
					b8 -= kw[dm17 + 9];
					b9 -= kw[dm17 + 10];
					b10 -= kw[dm17 + 11];
					b11 -= kw[dm17 + 12];
					b12 -= kw[dm17 + 13];
					b13 -= kw[dm17 + 14] + t[dm18 + 1];
					b14 -= kw[dm17 + 15] + t[dm18 + 2];
					b15 -= kw[dm17 + 16] + (ulong)d + 1UL;
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b15, 9, b0);
					b0 -= b15;
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b11, 48, b2);
					b2 -= b11;
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b13, 35, b6);
					b6 -= b13;
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b9, 52, b4);
					b4 -= b9;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 23, b14);
					b14 -= b;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 31, b8);
					b8 -= b5;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 37, b10);
					b10 -= b3;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 20, b12);
					b12 -= b7;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 31, b0);
					b0 -= b7;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 44, b2);
					b2 -= b5;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 47, b4);
					b4 -= b3;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 46, b6);
					b6 -= b;
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b15, 19, b12);
					b12 -= b15;
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b13, 42, b14);
					b14 -= b13;
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b11, 44, b8);
					b8 -= b11;
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b9, 25, b10);
					b10 -= b9;
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b9, 16, b0);
					b0 -= b9;
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b13, 34, b2);
					b2 -= b13;
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b11, 56, b6);
					b6 -= b11;
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b15, 51, b4);
					b4 -= b15;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 4, b10);
					b10 -= b7;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 53, b12);
					b12 -= b3;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 42, b14);
					b14 -= b5;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 41, b8);
					b8 -= b;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 41, b0);
					b0 -= b;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 9, b2);
					b2 -= b3;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 37, b4);
					b4 -= b5;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 31, b6);
					b6 -= b7;
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b9, 12, b8);
					b8 -= b9;
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b11, 47, b10);
					b10 -= b11;
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b13, 44, b12);
					b12 -= b13;
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b15, 30, b14);
					b14 -= b15;
					b0 -= kw[dm17];
					b -= kw[dm17 + 1];
					b2 -= kw[dm17 + 2];
					b3 -= kw[dm17 + 3];
					b4 -= kw[dm17 + 4];
					b5 -= kw[dm17 + 5];
					b6 -= kw[dm17 + 6];
					b7 -= kw[dm17 + 7];
					b8 -= kw[dm17 + 8];
					b9 -= kw[dm17 + 9];
					b10 -= kw[dm17 + 10];
					b11 -= kw[dm17 + 11];
					b12 -= kw[dm17 + 12];
					b13 -= kw[dm17 + 13] + t[dm18];
					b14 -= kw[dm17 + 14] + t[dm18 + 1];
					b15 -= kw[dm17 + 15] + (ulong)d;
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b15, 5, b0);
					b0 -= b15;
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b11, 20, b2);
					b2 -= b11;
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b13, 48, b6);
					b6 -= b13;
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b9, 41, b4);
					b4 -= b9;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 47, b14);
					b14 -= b;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 28, b8);
					b8 -= b5;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 16, b10);
					b10 -= b3;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 25, b12);
					b12 -= b7;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 33, b0);
					b0 -= b7;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 4, b2);
					b2 -= b5;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 51, b4);
					b4 -= b3;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 13, b6);
					b6 -= b;
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b15, 34, b12);
					b12 -= b15;
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b13, 41, b14);
					b14 -= b13;
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b11, 59, b8);
					b8 -= b11;
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b9, 17, b10);
					b10 -= b9;
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b9, 38, b0);
					b0 -= b9;
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b13, 19, b2);
					b2 -= b13;
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b11, 10, b6);
					b6 -= b11;
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b15, 55, b4);
					b4 -= b15;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 49, b10);
					b10 -= b7;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 18, b12);
					b12 -= b3;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 23, b14);
					b14 -= b5;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 52, b8);
					b8 -= b;
					b = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b, 24, b0);
					b0 -= b;
					b3 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b3, 13, b2);
					b2 -= b3;
					b5 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b5, 8, b4);
					b4 -= b5;
					b7 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b7, 47, b6);
					b6 -= b7;
					b9 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b9, 8, b8);
					b8 -= b9;
					b11 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b11, 17, b10);
					b10 -= b11;
					b13 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b13, 22, b12);
					b12 -= b13;
					b15 = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.XorRotr(b15, 37, b14);
					b14 -= b15;
				}
				b0 -= kw[0];
				b -= kw[1];
				b2 -= kw[2];
				b3 -= kw[3];
				b4 -= kw[4];
				b5 -= kw[5];
				b6 -= kw[6];
				b7 -= kw[7];
				b8 -= kw[8];
				b9 -= kw[9];
				b10 -= kw[10];
				b11 -= kw[11];
				b12 -= kw[12];
				b13 -= kw[13] + t[0];
				b14 -= kw[14] + t[1];
				b15 -= kw[15];
				state[0] = b0;
				state[1] = b;
				state[2] = b2;
				state[3] = b3;
				state[4] = b4;
				state[5] = b5;
				state[6] = b6;
				state[7] = b7;
				state[8] = b8;
				state[9] = b9;
				state[10] = b10;
				state[11] = b11;
				state[12] = b12;
				state[13] = b13;
				state[14] = b14;
				state[15] = b15;
			}

			// Token: 0x0400250E RID: 9486
			private const int ROTATION_0_0 = 24;

			// Token: 0x0400250F RID: 9487
			private const int ROTATION_0_1 = 13;

			// Token: 0x04002510 RID: 9488
			private const int ROTATION_0_2 = 8;

			// Token: 0x04002511 RID: 9489
			private const int ROTATION_0_3 = 47;

			// Token: 0x04002512 RID: 9490
			private const int ROTATION_0_4 = 8;

			// Token: 0x04002513 RID: 9491
			private const int ROTATION_0_5 = 17;

			// Token: 0x04002514 RID: 9492
			private const int ROTATION_0_6 = 22;

			// Token: 0x04002515 RID: 9493
			private const int ROTATION_0_7 = 37;

			// Token: 0x04002516 RID: 9494
			private const int ROTATION_1_0 = 38;

			// Token: 0x04002517 RID: 9495
			private const int ROTATION_1_1 = 19;

			// Token: 0x04002518 RID: 9496
			private const int ROTATION_1_2 = 10;

			// Token: 0x04002519 RID: 9497
			private const int ROTATION_1_3 = 55;

			// Token: 0x0400251A RID: 9498
			private const int ROTATION_1_4 = 49;

			// Token: 0x0400251B RID: 9499
			private const int ROTATION_1_5 = 18;

			// Token: 0x0400251C RID: 9500
			private const int ROTATION_1_6 = 23;

			// Token: 0x0400251D RID: 9501
			private const int ROTATION_1_7 = 52;

			// Token: 0x0400251E RID: 9502
			private const int ROTATION_2_0 = 33;

			// Token: 0x0400251F RID: 9503
			private const int ROTATION_2_1 = 4;

			// Token: 0x04002520 RID: 9504
			private const int ROTATION_2_2 = 51;

			// Token: 0x04002521 RID: 9505
			private const int ROTATION_2_3 = 13;

			// Token: 0x04002522 RID: 9506
			private const int ROTATION_2_4 = 34;

			// Token: 0x04002523 RID: 9507
			private const int ROTATION_2_5 = 41;

			// Token: 0x04002524 RID: 9508
			private const int ROTATION_2_6 = 59;

			// Token: 0x04002525 RID: 9509
			private const int ROTATION_2_7 = 17;

			// Token: 0x04002526 RID: 9510
			private const int ROTATION_3_0 = 5;

			// Token: 0x04002527 RID: 9511
			private const int ROTATION_3_1 = 20;

			// Token: 0x04002528 RID: 9512
			private const int ROTATION_3_2 = 48;

			// Token: 0x04002529 RID: 9513
			private const int ROTATION_3_3 = 41;

			// Token: 0x0400252A RID: 9514
			private const int ROTATION_3_4 = 47;

			// Token: 0x0400252B RID: 9515
			private const int ROTATION_3_5 = 28;

			// Token: 0x0400252C RID: 9516
			private const int ROTATION_3_6 = 16;

			// Token: 0x0400252D RID: 9517
			private const int ROTATION_3_7 = 25;

			// Token: 0x0400252E RID: 9518
			private const int ROTATION_4_0 = 41;

			// Token: 0x0400252F RID: 9519
			private const int ROTATION_4_1 = 9;

			// Token: 0x04002530 RID: 9520
			private const int ROTATION_4_2 = 37;

			// Token: 0x04002531 RID: 9521
			private const int ROTATION_4_3 = 31;

			// Token: 0x04002532 RID: 9522
			private const int ROTATION_4_4 = 12;

			// Token: 0x04002533 RID: 9523
			private const int ROTATION_4_5 = 47;

			// Token: 0x04002534 RID: 9524
			private const int ROTATION_4_6 = 44;

			// Token: 0x04002535 RID: 9525
			private const int ROTATION_4_7 = 30;

			// Token: 0x04002536 RID: 9526
			private const int ROTATION_5_0 = 16;

			// Token: 0x04002537 RID: 9527
			private const int ROTATION_5_1 = 34;

			// Token: 0x04002538 RID: 9528
			private const int ROTATION_5_2 = 56;

			// Token: 0x04002539 RID: 9529
			private const int ROTATION_5_3 = 51;

			// Token: 0x0400253A RID: 9530
			private const int ROTATION_5_4 = 4;

			// Token: 0x0400253B RID: 9531
			private const int ROTATION_5_5 = 53;

			// Token: 0x0400253C RID: 9532
			private const int ROTATION_5_6 = 42;

			// Token: 0x0400253D RID: 9533
			private const int ROTATION_5_7 = 41;

			// Token: 0x0400253E RID: 9534
			private const int ROTATION_6_0 = 31;

			// Token: 0x0400253F RID: 9535
			private const int ROTATION_6_1 = 44;

			// Token: 0x04002540 RID: 9536
			private const int ROTATION_6_2 = 47;

			// Token: 0x04002541 RID: 9537
			private const int ROTATION_6_3 = 46;

			// Token: 0x04002542 RID: 9538
			private const int ROTATION_6_4 = 19;

			// Token: 0x04002543 RID: 9539
			private const int ROTATION_6_5 = 42;

			// Token: 0x04002544 RID: 9540
			private const int ROTATION_6_6 = 44;

			// Token: 0x04002545 RID: 9541
			private const int ROTATION_6_7 = 25;

			// Token: 0x04002546 RID: 9542
			private const int ROTATION_7_0 = 9;

			// Token: 0x04002547 RID: 9543
			private const int ROTATION_7_1 = 48;

			// Token: 0x04002548 RID: 9544
			private const int ROTATION_7_2 = 35;

			// Token: 0x04002549 RID: 9545
			private const int ROTATION_7_3 = 52;

			// Token: 0x0400254A RID: 9546
			private const int ROTATION_7_4 = 23;

			// Token: 0x0400254B RID: 9547
			private const int ROTATION_7_5 = 31;

			// Token: 0x0400254C RID: 9548
			private const int ROTATION_7_6 = 37;

			// Token: 0x0400254D RID: 9549
			private const int ROTATION_7_7 = 20;
		}
	}
}
