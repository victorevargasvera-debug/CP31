using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004C8 RID: 1224
	public class Blake2sDigest : global::Org.BouncyCastle.Crypto.IDigest
	{
		// Token: 0x06002F7D RID: 12157 RVA: 0x000DD3B2 File Offset: 0x000DB5B2
		public Blake2sDigest() : this(256)
		{
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x000DD3C0 File Offset: 0x000DB5C0
		public Blake2sDigest(global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest digest)
		{
			this.digestLength = 32;
			this.internalState = new uint[16];
			base..ctor();
			this.bufferPos = digest.bufferPos;
			this.buffer = global::Org.BouncyCastle.Utilities.Arrays.Clone(digest.buffer);
			this.keyLength = digest.keyLength;
			this.key = global::Org.BouncyCastle.Utilities.Arrays.Clone(digest.key);
			this.digestLength = digest.digestLength;
			this.chainValue = global::Org.BouncyCastle.Utilities.Arrays.Clone(digest.chainValue);
			this.personalization = global::Org.BouncyCastle.Utilities.Arrays.Clone(digest.personalization);
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x000DD450 File Offset: 0x000DB650
		public Blake2sDigest(int digestBits)
		{
			this.digestLength = 32;
			this.internalState = new uint[16];
			base..ctor();
			if (digestBits < 8 || digestBits > 256 || digestBits % 8 != 0)
			{
				throw new global::System.ArgumentException("BLAKE2s digest bit length must be a multiple of 8 and not greater than 256");
			}
			this.buffer = new byte[64];
			this.keyLength = 0;
			this.digestLength = digestBits / 8;
			this.Init();
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x000DD4B8 File Offset: 0x000DB6B8
		public Blake2sDigest(byte[] key)
		{
			this.digestLength = 32;
			this.internalState = new uint[16];
			base..ctor();
			this.buffer = new byte[64];
			if (key != null)
			{
				if (key.Length > 32)
				{
					throw new global::System.ArgumentException("Keys > 32 are not supported");
				}
				this.key = new byte[key.Length];
				global::System.Array.Copy(key, 0, this.key, 0, key.Length);
				this.keyLength = key.Length;
				global::System.Array.Copy(key, 0, this.buffer, 0, key.Length);
				this.bufferPos = 64;
			}
			this.digestLength = 32;
			this.Init();
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x000DD554 File Offset: 0x000DB754
		public Blake2sDigest(byte[] key, int digestBytes, byte[] salt, byte[] personalization)
		{
			this.digestLength = 32;
			this.internalState = new uint[16];
			base..ctor();
			if (digestBytes < 1 || digestBytes > 32)
			{
				throw new global::System.ArgumentException("Invalid digest length (required: 1 - 32)");
			}
			this.digestLength = digestBytes;
			this.buffer = new byte[64];
			if (salt != null)
			{
				if (salt.Length != 8)
				{
					throw new global::System.ArgumentException("Salt length must be exactly 8 bytes");
				}
				this.salt = new byte[8];
				global::System.Array.Copy(salt, 0, this.salt, 0, salt.Length);
			}
			if (personalization != null)
			{
				if (personalization.Length != 8)
				{
					throw new global::System.ArgumentException("Personalization length must be exactly 8 bytes");
				}
				this.personalization = new byte[8];
				global::System.Array.Copy(personalization, 0, this.personalization, 0, personalization.Length);
			}
			if (key != null)
			{
				if (key.Length > 32)
				{
					throw new global::System.ArgumentException("Keys > 32 bytes are not supported");
				}
				this.key = new byte[key.Length];
				global::System.Array.Copy(key, 0, this.key, 0, key.Length);
				this.keyLength = key.Length;
				global::System.Array.Copy(key, 0, this.buffer, 0, key.Length);
				this.bufferPos = 64;
			}
			this.Init();
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x000DD668 File Offset: 0x000DB868
		private void Init()
		{
			if (this.chainValue == null)
			{
				this.chainValue = new uint[8];
				this.chainValue[0] = (global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_IV[0] ^ (uint)(this.digestLength | this.keyLength << 8 | 16842752));
				this.chainValue[1] = global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_IV[1];
				this.chainValue[2] = global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_IV[2];
				this.chainValue[3] = global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_IV[3];
				this.chainValue[4] = global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_IV[4];
				this.chainValue[5] = global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_IV[5];
				if (this.salt != null)
				{
					this.chainValue[4] ^= global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(this.salt, 0);
					this.chainValue[5] ^= global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(this.salt, 4);
				}
				this.chainValue[6] = global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_IV[6];
				this.chainValue[7] = global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_IV[7];
				if (this.personalization != null)
				{
					this.chainValue[6] ^= global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(this.personalization, 0);
					this.chainValue[7] ^= global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(this.personalization, 4);
				}
			}
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x000DD79C File Offset: 0x000DB99C
		private void InitializeInternalState()
		{
			global::System.Array.Copy(this.chainValue, 0, this.internalState, 0, this.chainValue.Length);
			global::System.Array.Copy(global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_IV, 0, this.internalState, this.chainValue.Length, 4);
			this.internalState[12] = (this.t0 ^ global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_IV[4]);
			this.internalState[13] = (this.t1 ^ global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_IV[5]);
			this.internalState[14] = (this.f0 ^ global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_IV[6]);
			this.internalState[15] = global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_IV[7];
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x000DD834 File Offset: 0x000DBA34
		public virtual void Update(byte b)
		{
			if (64 - this.bufferPos == 0)
			{
				this.t0 += 64U;
				if (this.t0 == 0U)
				{
					this.t1 += 1U;
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

		// Token: 0x06002F85 RID: 12165 RVA: 0x000DD8C0 File Offset: 0x000DBAC0
		public virtual void BlockUpdate(byte[] message, int offset, int len)
		{
			if (message == null || len == 0)
			{
				return;
			}
			int remainingLength = 0;
			if (this.bufferPos != 0)
			{
				remainingLength = 64 - this.bufferPos;
				if (remainingLength >= len)
				{
					global::System.Array.Copy(message, offset, this.buffer, this.bufferPos, len);
					this.bufferPos += len;
					return;
				}
				global::System.Array.Copy(message, offset, this.buffer, this.bufferPos, remainingLength);
				this.t0 += 64U;
				if (this.t0 == 0U)
				{
					this.t1 += 1U;
				}
				this.Compress(this.buffer, 0);
				this.bufferPos = 0;
				global::System.Array.Clear(this.buffer, 0, this.buffer.Length);
			}
			int blockWiseLastPos = offset + len - 64;
			int messagePos;
			for (messagePos = offset + remainingLength; messagePos < blockWiseLastPos; messagePos += 64)
			{
				this.t0 += 64U;
				if (this.t0 == 0U)
				{
					this.t1 += 1U;
				}
				this.Compress(message, messagePos);
			}
			global::System.Array.Copy(message, messagePos, this.buffer, 0, offset + len - messagePos);
			this.bufferPos += offset + len - messagePos;
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x000DD9E0 File Offset: 0x000DBBE0
		public virtual int DoFinal(byte[] output, int outOffset)
		{
			this.f0 = uint.MaxValue;
			this.t0 += (uint)this.bufferPos;
			if (this.t0 < 0U && (long)this.bufferPos > (long)(-(long)((ulong)this.t0)))
			{
				this.t1 += 1U;
			}
			this.Compress(this.buffer, 0);
			global::System.Array.Clear(this.buffer, 0, this.buffer.Length);
			global::System.Array.Clear(this.internalState, 0, this.internalState.Length);
			int i = 0;
			while (i < this.chainValue.Length && i * 4 < this.digestLength)
			{
				byte[] bytes = global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(this.chainValue[i]);
				if (i * 4 < this.digestLength - 4)
				{
					global::System.Array.Copy(bytes, 0, output, outOffset + i * 4, 4);
				}
				else
				{
					global::System.Array.Copy(bytes, 0, output, outOffset + i * 4, this.digestLength - i * 4);
				}
				i++;
			}
			global::System.Array.Clear(this.chainValue, 0, this.chainValue.Length);
			this.Reset();
			return this.digestLength;
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x000DDAE4 File Offset: 0x000DBCE4
		public virtual void Reset()
		{
			this.bufferPos = 0;
			this.f0 = 0U;
			this.t0 = 0U;
			this.t1 = 0U;
			this.chainValue = null;
			global::System.Array.Clear(this.buffer, 0, this.buffer.Length);
			if (this.key != null)
			{
				global::System.Array.Copy(this.key, 0, this.buffer, 0, this.key.Length);
				this.bufferPos = 64;
			}
			this.Init();
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x000DDB5C File Offset: 0x000DBD5C
		private void Compress(byte[] message, int messagePos)
		{
			this.InitializeInternalState();
			uint[] i = new uint[16];
			for (int j = 0; j < 16; j++)
			{
				i[j] = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(message, messagePos + j * 4);
			}
			for (int round = 0; round < 10; round++)
			{
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 0]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 1]], 0, 4, 8, 12);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 2]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 3]], 1, 5, 9, 13);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 4]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 5]], 2, 6, 10, 14);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 6]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 7]], 3, 7, 11, 15);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 8]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 9]], 0, 5, 10, 15);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 10]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 11]], 1, 6, 11, 12);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 12]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 13]], 2, 7, 8, 13);
				this.G(i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 14]], i[(int)global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest.blake2s_sigma[round, 15]], 3, 4, 9, 14);
			}
			for (int offset = 0; offset < this.chainValue.Length; offset++)
			{
				this.chainValue[offset] = (this.chainValue[offset] ^ this.internalState[offset] ^ this.internalState[offset + 8]);
			}
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x000DDD24 File Offset: 0x000DBF24
		private void G(uint m1, uint m2, int posA, int posB, int posC, int posD)
		{
			this.internalState[posA] = this.internalState[posA] + this.internalState[posB] + m1;
			this.internalState[posD] = this.rotr32(this.internalState[posD] ^ this.internalState[posA], 16);
			this.internalState[posC] = this.internalState[posC] + this.internalState[posD];
			this.internalState[posB] = this.rotr32(this.internalState[posB] ^ this.internalState[posC], 12);
			this.internalState[posA] = this.internalState[posA] + this.internalState[posB] + m2;
			this.internalState[posD] = this.rotr32(this.internalState[posD] ^ this.internalState[posA], 8);
			this.internalState[posC] = this.internalState[posC] + this.internalState[posD];
			this.internalState[posB] = this.rotr32(this.internalState[posB] ^ this.internalState[posC], 7);
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x000DDE2D File Offset: 0x000DC02D
		private uint rotr32(uint x, int rot)
		{
			return x >> rot | x << -rot;
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002F8B RID: 12171 RVA: 0x000DDE3D File Offset: 0x000DC03D
		public virtual string AlgorithmName
		{
			get
			{
				return "BLAKE2s";
			}
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x000DDE44 File Offset: 0x000DC044
		public virtual int GetDigestSize()
		{
			return this.digestLength;
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x000DDE4C File Offset: 0x000DC04C
		public virtual int GetByteLength()
		{
			return 64;
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x000DDE50 File Offset: 0x000DC050
		public virtual void ClearKey()
		{
			if (this.key != null)
			{
				global::System.Array.Clear(this.key, 0, this.key.Length);
				global::System.Array.Clear(this.buffer, 0, this.buffer.Length);
			}
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x000DDE82 File Offset: 0x000DC082
		public virtual void ClearSalt()
		{
			if (this.salt != null)
			{
				global::System.Array.Clear(this.salt, 0, this.salt.Length);
			}
		}

		// Token: 0x04001471 RID: 5233
		private static readonly uint[] blake2s_IV = new uint[]
		{
			1779033703U,
			3144134277U,
			1013904242U,
			2773480762U,
			1359893119U,
			2600822924U,
			528734635U,
			1541459225U
		};

		// Token: 0x04001472 RID: 5234
		private static readonly byte[,] blake2s_sigma = new byte[,]
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
			}
		};

		// Token: 0x04001473 RID: 5235
		private const int ROUNDS = 10;

		// Token: 0x04001474 RID: 5236
		private const int BLOCK_LENGTH_BYTES = 64;

		// Token: 0x04001475 RID: 5237
		private int digestLength;

		// Token: 0x04001476 RID: 5238
		private int keyLength;

		// Token: 0x04001477 RID: 5239
		private byte[] salt;

		// Token: 0x04001478 RID: 5240
		private byte[] personalization;

		// Token: 0x04001479 RID: 5241
		private byte[] key;

		// Token: 0x0400147A RID: 5242
		private byte[] buffer;

		// Token: 0x0400147B RID: 5243
		private int bufferPos;

		// Token: 0x0400147C RID: 5244
		private uint[] internalState;

		// Token: 0x0400147D RID: 5245
		private uint[] chainValue;

		// Token: 0x0400147E RID: 5246
		private uint t0;

		// Token: 0x0400147F RID: 5247
		private uint t1;

		// Token: 0x04001480 RID: 5248
		private uint f0;
	}
}
