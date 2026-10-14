using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004D0 RID: 1232
	public class KeccakDigest : global::Org.BouncyCastle.Crypto.IDigest, global::Org.BouncyCastle.Utilities.IMemoable
	{
		// Token: 0x06002FF4 RID: 12276 RVA: 0x000E0BAF File Offset: 0x000DEDAF
		public KeccakDigest() : this(288)
		{
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x000E0BBC File Offset: 0x000DEDBC
		public KeccakDigest(int bitLength)
		{
			this.state = new ulong[25];
			this.dataQueue = new byte[192];
			base..ctor();
			this.Init(bitLength);
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x000E0BE8 File Offset: 0x000DEDE8
		public KeccakDigest(global::Org.BouncyCastle.Crypto.Digests.KeccakDigest source)
		{
			this.state = new ulong[25];
			this.dataQueue = new byte[192];
			base..ctor();
			this.CopyIn(source);
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x000E0C14 File Offset: 0x000DEE14
		private void CopyIn(global::Org.BouncyCastle.Crypto.Digests.KeccakDigest source)
		{
			global::System.Array.Copy(source.state, 0, this.state, 0, source.state.Length);
			global::System.Array.Copy(source.dataQueue, 0, this.dataQueue, 0, source.dataQueue.Length);
			this.rate = source.rate;
			this.bitsInQueue = source.bitsInQueue;
			this.fixedOutputLength = source.fixedOutputLength;
			this.squeezing = source.squeezing;
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x000E0C87 File Offset: 0x000DEE87
		public virtual string AlgorithmName
		{
			get
			{
				return "Keccak-" + this.fixedOutputLength.ToString();
			}
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x000E0C9E File Offset: 0x000DEE9E
		public virtual int GetDigestSize()
		{
			return this.fixedOutputLength >> 3;
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x000E0CA8 File Offset: 0x000DEEA8
		public virtual void Update(byte input)
		{
			this.Absorb(input);
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x000E0CB1 File Offset: 0x000DEEB1
		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
			this.Absorb(input, inOff, len);
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x000E0CBC File Offset: 0x000DEEBC
		public virtual int DoFinal(byte[] output, int outOff)
		{
			this.Squeeze(output, outOff, (long)this.fixedOutputLength);
			this.Reset();
			return this.GetDigestSize();
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x000E0CD9 File Offset: 0x000DEED9
		protected virtual int DoFinal(byte[] output, int outOff, byte partialByte, int partialBits)
		{
			if (partialBits > 0)
			{
				this.AbsorbBits((int)partialByte, partialBits);
			}
			this.Squeeze(output, outOff, (long)this.fixedOutputLength);
			this.Reset();
			return this.GetDigestSize();
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x000E0D04 File Offset: 0x000DEF04
		public virtual void Reset()
		{
			this.Init(this.fixedOutputLength);
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x000E0D12 File Offset: 0x000DEF12
		public virtual int GetByteLength()
		{
			return this.rate >> 3;
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x000E0D1C File Offset: 0x000DEF1C
		private void Init(int bitLength)
		{
			if (bitLength <= 256)
			{
				if (bitLength != 128 && bitLength != 224 && bitLength != 256)
				{
					goto IL_4A;
				}
			}
			else if (bitLength != 288 && bitLength != 384 && bitLength != 512)
			{
				goto IL_4A;
			}
			this.InitSponge(1600 - (bitLength << 1));
			return;
			IL_4A:
			throw new global::System.ArgumentException("must be one of 128, 224, 256, 288, 384, or 512.", "bitLength");
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x000E0D84 File Offset: 0x000DEF84
		private void InitSponge(int rate)
		{
			if (rate <= 0 || rate >= 1600 || (rate & 63) != 0)
			{
				throw new global::System.InvalidOperationException("invalid rate value");
			}
			this.rate = rate;
			global::System.Array.Clear(this.state, 0, this.state.Length);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.dataQueue, 0);
			this.bitsInQueue = 0;
			this.squeezing = false;
			this.fixedOutputLength = 1600 - rate >> 1;
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x000E0DF4 File Offset: 0x000DEFF4
		protected void Absorb(byte data)
		{
			if ((this.bitsInQueue & 7) != 0)
			{
				throw new global::System.InvalidOperationException("attempt to absorb with odd length queue");
			}
			if (this.squeezing)
			{
				throw new global::System.InvalidOperationException("attempt to absorb while squeezing");
			}
			this.dataQueue[this.bitsInQueue >> 3] = data;
			if ((this.bitsInQueue += 8) == this.rate)
			{
				this.KeccakAbsorb(this.dataQueue, 0);
				this.bitsInQueue = 0;
			}
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x000E0E68 File Offset: 0x000DF068
		protected void Absorb(byte[] data, int off, int len)
		{
			if ((this.bitsInQueue & 7) != 0)
			{
				throw new global::System.InvalidOperationException("attempt to absorb with odd length queue");
			}
			if (this.squeezing)
			{
				throw new global::System.InvalidOperationException("attempt to absorb while squeezing");
			}
			int bytesInQueue = this.bitsInQueue >> 3;
			int rateBytes = this.rate >> 3;
			int available = rateBytes - bytesInQueue;
			if (len < available)
			{
				global::System.Array.Copy(data, off, this.dataQueue, bytesInQueue, len);
				this.bitsInQueue += len << 3;
				return;
			}
			int count = 0;
			if (bytesInQueue > 0)
			{
				global::System.Array.Copy(data, off, this.dataQueue, bytesInQueue, available);
				count += available;
				this.KeccakAbsorb(this.dataQueue, 0);
			}
			int remaining;
			while ((remaining = len - count) >= rateBytes)
			{
				this.KeccakAbsorb(data, off + count);
				count += rateBytes;
			}
			global::System.Array.Copy(data, off + count, this.dataQueue, 0, remaining);
			this.bitsInQueue = remaining << 3;
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x000E0F34 File Offset: 0x000DF134
		protected void AbsorbBits(int data, int bits)
		{
			if (bits < 1 || bits > 7)
			{
				throw new global::System.ArgumentException("must be in the range 1 to 7", "bits");
			}
			if ((this.bitsInQueue & 7) != 0)
			{
				throw new global::System.InvalidOperationException("attempt to absorb with odd length queue");
			}
			if (this.squeezing)
			{
				throw new global::System.InvalidOperationException("attempt to absorb while squeezing");
			}
			int mask = (1 << bits) - 1;
			this.dataQueue[this.bitsInQueue >> 3] = (byte)(data & mask);
			this.bitsInQueue += bits;
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x000E0FAC File Offset: 0x000DF1AC
		private void PadAndSwitchToSqueezingPhase()
		{
			byte[] array = this.dataQueue;
			int num = this.bitsInQueue >> 3;
			array[num] |= (byte)(1 << (this.bitsInQueue & 7));
			int num2 = this.bitsInQueue + 1;
			this.bitsInQueue = num2;
			if (num2 == this.rate)
			{
				this.KeccakAbsorb(this.dataQueue, 0);
			}
			else
			{
				int full = this.bitsInQueue >> 6;
				int partial = this.bitsInQueue & 63;
				int off = 0;
				for (int i = 0; i < full; i++)
				{
					this.state[i] ^= global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(this.dataQueue, off);
					off += 8;
				}
				if (partial > 0)
				{
					ulong mask = (1UL << partial) - 1UL;
					this.state[full] ^= (global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(this.dataQueue, off) & mask);
				}
			}
			this.state[this.rate - 1 >> 6] ^= 9223372036854775808UL;
			this.bitsInQueue = 0;
			this.squeezing = true;
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x000E10AC File Offset: 0x000DF2AC
		protected void Squeeze(byte[] output, int offset, long outputLength)
		{
			if (!this.squeezing)
			{
				this.PadAndSwitchToSqueezingPhase();
			}
			if ((outputLength & 7L) != 0L)
			{
				throw new global::System.InvalidOperationException("outputLength not a multiple of 8");
			}
			int partialBlock;
			for (long i = 0L; i < outputLength; i += (long)partialBlock)
			{
				if (this.bitsInQueue == 0)
				{
					this.KeccakExtract();
				}
				partialBlock = (int)global::System.Math.Min((long)this.bitsInQueue, outputLength - i);
				global::System.Array.Copy(this.dataQueue, this.rate - this.bitsInQueue >> 3, output, offset + (int)(i >> 3), partialBlock >> 3);
				this.bitsInQueue -= partialBlock;
			}
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x000E1138 File Offset: 0x000DF338
		private void KeccakAbsorb(byte[] data, int off)
		{
			int count = this.rate >> 6;
			for (int i = 0; i < count; i++)
			{
				this.state[i] ^= global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(data, off);
				off += 8;
			}
			this.KeccakPermutation();
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x000E117C File Offset: 0x000DF37C
		private void KeccakExtract()
		{
			this.KeccakPermutation();
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(this.state, 0, this.rate >> 6, this.dataQueue, 0);
			this.bitsInQueue = this.rate;
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x000E11AC File Offset: 0x000DF3AC
		private void KeccakPermutation()
		{
			ulong[] A = this.state;
			ulong a0 = A[0];
			ulong a = A[1];
			ulong a2 = A[2];
			ulong a3 = A[3];
			ulong a4 = A[4];
			ulong a5 = A[5];
			ulong a6 = A[6];
			ulong a7 = A[7];
			ulong a8 = A[8];
			ulong a9 = A[9];
			ulong a10 = A[10];
			ulong a11 = A[11];
			ulong a12 = A[12];
			ulong a13 = A[13];
			ulong a14 = A[14];
			ulong a15 = A[15];
			ulong a16 = A[16];
			ulong a17 = A[17];
			ulong a18 = A[18];
			ulong a19 = A[19];
			ulong a20 = A[20];
			ulong a21 = A[21];
			ulong a22 = A[22];
			ulong a23 = A[23];
			ulong a24 = A[24];
			for (int i = 0; i < 24; i++)
			{
				ulong c0 = a0 ^ a5 ^ a10 ^ a15 ^ a20;
				ulong c = a ^ a6 ^ a11 ^ a16 ^ a21;
				ulong c2 = a2 ^ a7 ^ a12 ^ a17 ^ a22;
				ulong c3 = a3 ^ a8 ^ a13 ^ a18 ^ a23;
				ulong c4 = a4 ^ a9 ^ a14 ^ a19 ^ a24;
				ulong d = (c << 1 | c >> 63) ^ c4;
				ulong d2 = (c2 << 1 | c2 >> 63) ^ c0;
				ulong d3 = (c3 << 1 | c3 >> 63) ^ c;
				ulong d4 = (c4 << 1 | c4 >> 63) ^ c2;
				ulong d5 = (c0 << 1 | c0 >> 63) ^ c3;
				a0 ^= d;
				a5 ^= d;
				a10 ^= d;
				a15 ^= d;
				a20 ^= d;
				a ^= d2;
				a6 ^= d2;
				a11 ^= d2;
				a16 ^= d2;
				a21 ^= d2;
				a2 ^= d3;
				a7 ^= d3;
				a12 ^= d3;
				a17 ^= d3;
				a22 ^= d3;
				a3 ^= d4;
				a8 ^= d4;
				a13 ^= d4;
				a18 ^= d4;
				a23 ^= d4;
				a4 ^= d5;
				a9 ^= d5;
				a14 ^= d5;
				a19 ^= d5;
				a24 ^= d5;
				c = (a << 1 | a >> 63);
				a = (a6 << 44 | a6 >> 20);
				a6 = (a9 << 20 | a9 >> 44);
				a9 = (a22 << 61 | a22 >> 3);
				a22 = (a14 << 39 | a14 >> 25);
				a14 = (a20 << 18 | a20 >> 46);
				a20 = (a2 << 62 | a2 >> 2);
				a2 = (a12 << 43 | a12 >> 21);
				a12 = (a13 << 25 | a13 >> 39);
				a13 = (a19 << 8 | a19 >> 56);
				a19 = (a23 << 56 | a23 >> 8);
				a23 = (a15 << 41 | a15 >> 23);
				a15 = (a4 << 27 | a4 >> 37);
				a4 = (a24 << 14 | a24 >> 50);
				a24 = (a21 << 2 | a21 >> 62);
				a21 = (a8 << 55 | a8 >> 9);
				a8 = (a16 << 45 | a16 >> 19);
				a16 = (a5 << 36 | a5 >> 28);
				a5 = (a3 << 28 | a3 >> 36);
				a3 = (a18 << 21 | a18 >> 43);
				a18 = (a17 << 15 | a17 >> 49);
				a17 = (a11 << 10 | a11 >> 54);
				a11 = (a7 << 6 | a7 >> 58);
				a7 = (a10 << 3 | a10 >> 61);
				a10 = c;
				c0 = (a0 ^ (~a & a2));
				c = (a ^ (~a2 & a3));
				a2 ^= (~a3 & a4);
				a3 ^= (~a4 & a0);
				a4 ^= (~a0 & a);
				a0 = c0;
				a = c;
				c0 = (a5 ^ (~a6 & a7));
				c = (a6 ^ (~a7 & a8));
				a7 ^= (~a8 & a9);
				a8 ^= (~a9 & a5);
				a9 ^= (~a5 & a6);
				a5 = c0;
				a6 = c;
				c0 = (a10 ^ (~a11 & a12));
				c = (a11 ^ (~a12 & a13));
				a12 ^= (~a13 & a14);
				a13 ^= (~a14 & a10);
				a14 ^= (~a10 & a11);
				a10 = c0;
				a11 = c;
				c0 = (a15 ^ (~a16 & a17));
				c = (a16 ^ (~a17 & a18));
				a17 ^= (~a18 & a19);
				a18 ^= (~a19 & a15);
				a19 ^= (~a15 & a16);
				a15 = c0;
				a16 = c;
				c0 = (a20 ^ (~a21 & a22));
				c = (a21 ^ (~a22 & a23));
				a22 ^= (~a23 & a24);
				a23 ^= (~a24 & a20);
				a24 ^= (~a20 & a21);
				a20 = c0;
				a21 = c;
				a0 ^= global::Org.BouncyCastle.Crypto.Digests.KeccakDigest.KeccakRoundConstants[i];
			}
			A[0] = a0;
			A[1] = a;
			A[2] = a2;
			A[3] = a3;
			A[4] = a4;
			A[5] = a5;
			A[6] = a6;
			A[7] = a7;
			A[8] = a8;
			A[9] = a9;
			A[10] = a10;
			A[11] = a11;
			A[12] = a12;
			A[13] = a13;
			A[14] = a14;
			A[15] = a15;
			A[16] = a16;
			A[17] = a17;
			A[18] = a18;
			A[19] = a19;
			A[20] = a20;
			A[21] = a21;
			A[22] = a22;
			A[23] = a23;
			A[24] = a24;
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x000E1694 File Offset: 0x000DF894
		public virtual global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.KeccakDigest(this);
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x000E169C File Offset: 0x000DF89C
		public virtual void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			this.CopyIn((global::Org.BouncyCastle.Crypto.Digests.KeccakDigest)other);
		}

		// Token: 0x040014BB RID: 5307
		private static readonly ulong[] KeccakRoundConstants = new ulong[]
		{
			1UL,
			32898UL,
			9223372036854808714UL,
			9223372039002292224UL,
			32907UL,
			2147483649UL,
			9223372039002292353UL,
			9223372036854808585UL,
			138UL,
			136UL,
			2147516425UL,
			2147483658UL,
			2147516555UL,
			9223372036854775947UL,
			9223372036854808713UL,
			9223372036854808579UL,
			9223372036854808578UL,
			9223372036854775936UL,
			32778UL,
			9223372039002259466UL,
			9223372039002292353UL,
			9223372036854808704UL,
			2147483649UL,
			9223372039002292232UL
		};

		// Token: 0x040014BC RID: 5308
		private ulong[] state;

		// Token: 0x040014BD RID: 5309
		protected byte[] dataQueue;

		// Token: 0x040014BE RID: 5310
		protected int rate;

		// Token: 0x040014BF RID: 5311
		protected int bitsInQueue;

		// Token: 0x040014C0 RID: 5312
		protected internal int fixedOutputLength;

		// Token: 0x040014C1 RID: 5313
		protected bool squeezing;
	}
}
