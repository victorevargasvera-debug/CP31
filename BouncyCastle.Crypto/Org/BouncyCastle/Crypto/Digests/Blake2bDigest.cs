using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004C7 RID: 1223
	public class Blake2bDigest : global::Org.BouncyCastle.Crypto.IDigest
	{
		// Token: 0x06002F69 RID: 12137 RVA: 0x000DC832 File Offset: 0x000DAA32
		public Blake2bDigest() : this(512)
		{
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x000DC840 File Offset: 0x000DAA40
		public Blake2bDigest(global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest digest)
		{
			this.digestLength = 64;
			this.internalState = new ulong[16];
			base..ctor();
			this.bufferPos = digest.bufferPos;
			this.buffer = global::Org.BouncyCastle.Utilities.Arrays.Clone(digest.buffer);
			this.keyLength = digest.keyLength;
			this.key = global::Org.BouncyCastle.Utilities.Arrays.Clone(digest.key);
			this.digestLength = digest.digestLength;
			this.chainValue = global::Org.BouncyCastle.Utilities.Arrays.Clone(digest.chainValue);
			this.personalization = global::Org.BouncyCastle.Utilities.Arrays.Clone(digest.personalization);
			this.salt = global::Org.BouncyCastle.Utilities.Arrays.Clone(digest.salt);
			this.t0 = digest.t0;
			this.t1 = digest.t1;
			this.f0 = digest.f0;
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x000DC908 File Offset: 0x000DAB08
		public Blake2bDigest(int digestSize)
		{
			this.digestLength = 64;
			this.internalState = new ulong[16];
			base..ctor();
			if (digestSize < 8 || digestSize > 512 || digestSize % 8 != 0)
			{
				throw new global::System.ArgumentException("BLAKE2b digest bit length must be a multiple of 8 and not greater than 512");
			}
			this.buffer = new byte[128];
			this.keyLength = 0;
			this.digestLength = digestSize / 8;
			this.Init();
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x000DC974 File Offset: 0x000DAB74
		public Blake2bDigest(byte[] key)
		{
			this.digestLength = 64;
			this.internalState = new ulong[16];
			base..ctor();
			this.buffer = new byte[128];
			if (key != null)
			{
				this.key = new byte[key.Length];
				global::System.Array.Copy(key, 0, this.key, 0, key.Length);
				if (key.Length > 64)
				{
					throw new global::System.ArgumentException("Keys > 64 are not supported");
				}
				this.keyLength = key.Length;
				global::System.Array.Copy(key, 0, this.buffer, 0, key.Length);
				this.bufferPos = 128;
			}
			this.digestLength = 64;
			this.Init();
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x000DCA14 File Offset: 0x000DAC14
		public Blake2bDigest(byte[] key, int digestLength, byte[] salt, byte[] personalization)
		{
			this.digestLength = 64;
			this.internalState = new ulong[16];
			base..ctor();
			if (digestLength < 1 || digestLength > 64)
			{
				throw new global::System.ArgumentException("Invalid digest length (required: 1 - 64)");
			}
			this.digestLength = digestLength;
			this.buffer = new byte[128];
			if (salt != null)
			{
				if (salt.Length != 16)
				{
					throw new global::System.ArgumentException("salt length must be exactly 16 bytes");
				}
				this.salt = new byte[16];
				global::System.Array.Copy(salt, 0, this.salt, 0, salt.Length);
			}
			if (personalization != null)
			{
				if (personalization.Length != 16)
				{
					throw new global::System.ArgumentException("personalization length must be exactly 16 bytes");
				}
				this.personalization = new byte[16];
				global::System.Array.Copy(personalization, 0, this.personalization, 0, personalization.Length);
			}
			if (key != null)
			{
				if (key.Length > 64)
				{
					throw new global::System.ArgumentException("Keys > 64 are not supported");
				}
				this.key = new byte[key.Length];
				global::System.Array.Copy(key, 0, this.key, 0, key.Length);
				this.keyLength = key.Length;
				global::System.Array.Copy(key, 0, this.buffer, 0, key.Length);
				this.bufferPos = 128;
			}
			this.Init();
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x000DCB30 File Offset: 0x000DAD30
		private void Init()
		{
			if (this.chainValue == null)
			{
				this.chainValue = new ulong[8];
				this.chainValue[0] = (global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_IV[0] ^ (ulong)((long)(this.digestLength | this.keyLength << 8 | 16842752)));
				this.chainValue[1] = global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_IV[1];
				this.chainValue[2] = global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_IV[2];
				this.chainValue[3] = global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_IV[3];
				this.chainValue[4] = global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_IV[4];
				this.chainValue[5] = global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_IV[5];
				if (this.salt != null)
				{
					this.chainValue[4] ^= global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(this.salt, 0);
					this.chainValue[5] ^= global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(this.salt, 8);
				}
				this.chainValue[6] = global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_IV[6];
				this.chainValue[7] = global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_IV[7];
				if (this.personalization != null)
				{
					this.chainValue[6] ^= global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(this.personalization, 0);
					this.chainValue[7] ^= global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(this.personalization, 8);
				}
			}
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x000DCC64 File Offset: 0x000DAE64
		private void InitializeInternalState()
		{
			global::System.Array.Copy(this.chainValue, 0, this.internalState, 0, this.chainValue.Length);
			global::System.Array.Copy(global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_IV, 0, this.internalState, this.chainValue.Length, 4);
			this.internalState[12] = (this.t0 ^ global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_IV[4]);
			this.internalState[13] = (this.t1 ^ global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_IV[5]);
			this.internalState[14] = (this.f0 ^ global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_IV[6]);
			this.internalState[15] = global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_IV[7];
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x000DCCFC File Offset: 0x000DAEFC
		public virtual void Update(byte b)
		{
			if (128 - this.bufferPos == 0)
			{
				this.t0 += 128UL;
				if (this.t0 == 0UL)
				{
					this.t1 += 1UL;
				}
				this.Compress(this.buffer, 0);
				global::System.Array.Clear(this.buffer, 0, this.buffer.Length);
				this.buffer[0] = b;
				this.bufferPos = 1;
				return;
			}
			this.buffer[this.bufferPos] = b;
			this.bufferPos++;
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x000DCD90 File Offset: 0x000DAF90
		public virtual void BlockUpdate(byte[] message, int offset, int len)
		{
			if (message == null || len == 0)
			{
				return;
			}
			int remainingLength = 0;
			if (this.bufferPos != 0)
			{
				remainingLength = 128 - this.bufferPos;
				if (remainingLength >= len)
				{
					global::System.Array.Copy(message, offset, this.buffer, this.bufferPos, len);
					this.bufferPos += len;
					return;
				}
				global::System.Array.Copy(message, offset, this.buffer, this.bufferPos, remainingLength);
				this.t0 += 128UL;
				if (this.t0 == 0UL)
				{
					this.t1 += 1UL;
				}
				this.Compress(this.buffer, 0);
				this.bufferPos = 0;
				global::System.Array.Clear(this.buffer, 0, this.buffer.Length);
			}
			int blockWiseLastPos = offset + len - 128;
			int messagePos;
			for (messagePos = offset + remainingLength; messagePos < blockWiseLastPos; messagePos += 128)
			{
				this.t0 += 128UL;
				if (this.t0 == 0UL)
				{
					this.t1 += 1UL;
				}
				this.Compress(message, messagePos);
			}
			global::System.Array.Copy(message, messagePos, this.buffer, 0, offset + len - messagePos);
			this.bufferPos += offset + len - messagePos;
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x000DCEC0 File Offset: 0x000DB0C0
		public virtual int DoFinal(byte[] output, int outOffset)
		{
			this.f0 = ulong.MaxValue;
			this.t0 += (ulong)((long)this.bufferPos);
			if (this.bufferPos > 0 && this.t0 == 0UL)
			{
				this.t1 += 1UL;
			}
			this.Compress(this.buffer, 0);
			global::System.Array.Clear(this.buffer, 0, this.buffer.Length);
			global::System.Array.Clear(this.internalState, 0, this.internalState.Length);
			int i = 0;
			while (i < this.chainValue.Length && i * 8 < this.digestLength)
			{
				byte[] bytes = global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(this.chainValue[i]);
				if (i * 8 < this.digestLength - 8)
				{
					global::System.Array.Copy(bytes, 0, output, outOffset + i * 8, 8);
				}
				else
				{
					global::System.Array.Copy(bytes, 0, output, outOffset + i * 8, this.digestLength - i * 8);
				}
				i++;
			}
			global::System.Array.Clear(this.chainValue, 0, this.chainValue.Length);
			this.Reset();
			return this.digestLength;
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x000DCFC0 File Offset: 0x000DB1C0
		public virtual void Reset()
		{
			this.bufferPos = 0;
			this.f0 = 0UL;
			this.t0 = 0UL;
			this.t1 = 0UL;
			this.chainValue = null;
			global::System.Array.Clear(this.buffer, 0, this.buffer.Length);
			if (this.key != null)
			{
				global::System.Array.Copy(this.key, 0, this.buffer, 0, this.key.Length);
				this.bufferPos = 128;
			}
			this.Init();
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x000DD03C File Offset: 0x000DB23C
		private void Compress(byte[] message, int messagePos)
		{
			this.InitializeInternalState();
			ulong[] i = new ulong[16];
			for (int j = 0; j < 16; j++)
			{
				i[j] = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(message, messagePos + j * 8);
			}
			for (int round = 0; round < 12; round++)
			{
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 0]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 1]], 0, 4, 8, 12);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 2]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 3]], 1, 5, 9, 13);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 4]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 5]], 2, 6, 10, 14);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 6]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 7]], 3, 7, 11, 15);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 8]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 9]], 0, 5, 10, 15);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 10]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 11]], 1, 6, 11, 12);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 12]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 13]], 2, 7, 8, 13);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 14]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.blake2b_sigma[round, 15]], 3, 4, 9, 14);
			}
			for (int offset = 0; offset < this.chainValue.Length; offset++)
			{
				this.chainValue[offset] = (this.chainValue[offset] ^ this.internalState[offset] ^ this.internalState[offset + 8]);
			}
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x000DD204 File Offset: 0x000DB404
		private void G(ulong m1, ulong m2, int posA, int posB, int posC, int posD)
		{
			this.internalState[posA] = this.internalState[posA] + this.internalState[posB] + m1;
			this.internalState[posD] = global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.Rotr64(this.internalState[posD] ^ this.internalState[posA], 32);
			this.internalState[posC] = this.internalState[posC] + this.internalState[posD];
			this.internalState[posB] = global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.Rotr64(this.internalState[posB] ^ this.internalState[posC], 24);
			this.internalState[posA] = this.internalState[posA] + this.internalState[posB] + m2;
			this.internalState[posD] = global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.Rotr64(this.internalState[posD] ^ this.internalState[posA], 16);
			this.internalState[posC] = this.internalState[posC] + this.internalState[posD];
			this.internalState[posB] = global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest.Rotr64(this.internalState[posB] ^ this.internalState[posC], 63);
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x000DD30B File Offset: 0x000DB50B
		private static ulong Rotr64(ulong x, int rot)
		{
			return x >> rot | x << -rot;
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002F77 RID: 12151 RVA: 0x000DD31B File Offset: 0x000DB51B
		public virtual string AlgorithmName
		{
			get
			{
				return "BLAKE2b";
			}
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x000DD322 File Offset: 0x000DB522
		public virtual int GetDigestSize()
		{
			return this.digestLength;
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x000DD32A File Offset: 0x000DB52A
		public virtual int GetByteLength()
		{
			return 128;
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x000DD331 File Offset: 0x000DB531
		public virtual void ClearKey()
		{
			if (this.key != null)
			{
				global::System.Array.Clear(this.key, 0, this.key.Length);
				global::System.Array.Clear(this.buffer, 0, this.buffer.Length);
			}
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x000DD363 File Offset: 0x000DB563
		public virtual void ClearSalt()
		{
			if (this.salt != null)
			{
				global::System.Array.Clear(this.salt, 0, this.salt.Length);
			}
		}

		// Token: 0x04001461 RID: 5217
		private static readonly ulong[] blake2b_IV = new ulong[]
		{
			7640891576956012808UL,
			13503953896175478587UL,
			4354685564936845355UL,
			11912009170470909681UL,
			5840696475078001361UL,
			11170449401992604703UL,
			2270897969802886507UL,
			6620516959819538809UL
		};

		// Token: 0x04001462 RID: 5218
		private static readonly byte[,] blake2b_sigma = new byte[,]
		{
			{
				0,
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8,
				9,
				10,
				11,
				12,
				13,
				14,
				15
			},
			{
				14,
				10,
				4,
				8,
				9,
				15,
				13,
				6,
				1,
				12,
				0,
				2,
				11,
				7,
				5,
				3
			},
			{
				11,
				8,
				12,
				0,
				5,
				2,
				15,
				13,
				10,
				14,
				3,
				6,
				7,
				1,
				9,
				4
			},
			{
				7,
				9,
				3,
				1,
				13,
				12,
				11,
				14,
				2,
				6,
				5,
				10,
				4,
				0,
				15,
				8
			},
			{
				9,
				0,
				5,
				7,
				2,
				4,
				10,
				15,
				14,
				1,
				11,
				12,
				6,
				8,
				3,
				13
			},
			{
				2,
				12,
				6,
				10,
				0,
				11,
				8,
				3,
				4,
				13,
				7,
				5,
				15,
				14,
				1,
				9
			},
			{
				12,
				5,
				1,
				15,
				14,
				13,
				4,
				10,
				0,
				7,
				6,
				3,
				9,
				2,
				8,
				11
			},
			{
				13,
				11,
				7,
				14,
				12,
				1,
				3,
				9,
				5,
				0,
				15,
				4,
				8,
				6,
				2,
				10
			},
			{
				6,
				15,
				14,
				9,
				11,
				3,
				0,
				8,
				12,
				2,
				13,
				7,
				1,
				4,
				10,
				5
			},
			{
				10,
				2,
				8,
				4,
				7,
				6,
				1,
				5,
				15,
				11,
				9,
				14,
				3,
				12,
				13,
				0
			},
			{
				0,
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8,
				9,
				10,
				11,
				12,
				13,
				14,
				15
			},
			{
				14,
				10,
				4,
				8,
				9,
				15,
				13,
				6,
				1,
				12,
				0,
				2,
				11,
				7,
				5,
				3
			}
		};

		// Token: 0x04001463 RID: 5219
		private const int ROUNDS = 12;

		// Token: 0x04001464 RID: 5220
		private const int BLOCK_LENGTH_BYTES = 128;

		// Token: 0x04001465 RID: 5221
		private int digestLength;

		// Token: 0x04001466 RID: 5222
		private int keyLength;

		// Token: 0x04001467 RID: 5223
		private byte[] salt;

		// Token: 0x04001468 RID: 5224
		private byte[] personalization;

		// Token: 0x04001469 RID: 5225
		private byte[] key;

		// Token: 0x0400146A RID: 5226
		private byte[] buffer;

		// Token: 0x0400146B RID: 5227
		private int bufferPos;

		// Token: 0x0400146C RID: 5228
		private ulong[] internalState;

		// Token: 0x0400146D RID: 5229
		private ulong[] chainValue;

		// Token: 0x0400146E RID: 5230
		private ulong t0;

		// Token: 0x0400146F RID: 5231
		private ulong t1;

		// Token: 0x04001470 RID: 5232
		private ulong f0;
	}
}
