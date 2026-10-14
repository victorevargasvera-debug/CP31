using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004A9 RID: 1193
	public class RC532Engine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002E02 RID: 11778 RVA: 0x000CFF57 File Offset: 0x000CE157
		public RC532Engine()
		{
			this._noRounds = 12;
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x000CFF67 File Offset: 0x000CE167
		public virtual string AlgorithmName
		{
			get
			{
				return "RC5-32";
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06002E04 RID: 11780 RVA: 0x000CFF6E File Offset: 0x000CE16E
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x000CFF71 File Offset: 0x000CE171
		public virtual int GetBlockSize()
		{
			return 8;
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x000CFF74 File Offset: 0x000CE174
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (typeof(global::Org.BouncyCastle.Crypto.Parameters.RC5Parameters).IsInstanceOfType(parameters))
			{
				global::Org.BouncyCastle.Crypto.Parameters.RC5Parameters p = (global::Org.BouncyCastle.Crypto.Parameters.RC5Parameters)parameters;
				this._noRounds = p.Rounds;
				this.SetKey(p.GetKey());
			}
			else
			{
				if (!typeof(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter).IsInstanceOfType(parameters))
				{
					throw new global::System.ArgumentException("invalid parameter passed to RC532 init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
				}
				global::Org.BouncyCastle.Crypto.Parameters.KeyParameter p2 = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters;
				this.SetKey(p2.GetKey());
			}
			this.forEncryption = forEncryption;
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000CFFF8 File Offset: 0x000CE1F8
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (!this.forEncryption)
			{
				return this.DecryptBlock(input, inOff, output, outOff);
			}
			return this.EncryptBlock(input, inOff, output, outOff);
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x000D0019 File Offset: 0x000CE219
		public virtual void Reset()
		{
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x000D001C File Offset: 0x000CE21C
		private void SetKey(byte[] key)
		{
			int[] L = new int[(key.Length + 3) / 4];
			for (int i = 0; i != key.Length; i++)
			{
				L[i / 4] += (int)(key[i] & byte.MaxValue) << 8 * (i % 4);
			}
			this._S = new int[2 * (this._noRounds + 1)];
			this._S[0] = global::Org.BouncyCastle.Crypto.Engines.RC532Engine.P32;
			for (int j = 1; j < this._S.Length; j++)
			{
				this._S[j] = this._S[j - 1] + global::Org.BouncyCastle.Crypto.Engines.RC532Engine.Q32;
			}
			int iter;
			if (L.Length > this._S.Length)
			{
				iter = 3 * L.Length;
			}
			else
			{
				iter = 3 * this._S.Length;
			}
			int A = 0;
			int B = 0;
			int ii = 0;
			int jj = 0;
			for (int k = 0; k < iter; k++)
			{
				A = (this._S[ii] = this.RotateLeft(this._S[ii] + A + B, 3));
				B = (L[jj] = this.RotateLeft(L[jj] + A + B, A + B));
				ii = (ii + 1) % this._S.Length;
				jj = (jj + 1) % L.Length;
			}
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x000D0150 File Offset: 0x000CE350
		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			int A = this.BytesToWord(input, inOff) + this._S[0];
			int B = this.BytesToWord(input, inOff + 4) + this._S[1];
			for (int i = 1; i <= this._noRounds; i++)
			{
				A = this.RotateLeft(A ^ B, B) + this._S[2 * i];
				B = this.RotateLeft(B ^ A, A) + this._S[2 * i + 1];
			}
			this.WordToBytes(A, outBytes, outOff);
			this.WordToBytes(B, outBytes, outOff + 4);
			return 8;
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x000D01DC File Offset: 0x000CE3DC
		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			int A = this.BytesToWord(input, inOff);
			int B = this.BytesToWord(input, inOff + 4);
			for (int i = this._noRounds; i >= 1; i--)
			{
				B = (this.RotateRight(B - this._S[2 * i + 1], A) ^ A);
				A = (this.RotateRight(A - this._S[2 * i], B) ^ B);
			}
			this.WordToBytes(A - this._S[0], outBytes, outOff);
			this.WordToBytes(B - this._S[1], outBytes, outOff + 4);
			return 8;
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x000D0265 File Offset: 0x000CE465
		private int RotateLeft(int x, int y)
		{
			return x << y | (int)((uint)x >> 32 - (y & 31));
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x000D027D File Offset: 0x000CE47D
		private int RotateRight(int x, int y)
		{
			return (int)((uint)x >> y | (uint)((uint)x << 32 - (y & 31)));
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x000D0295 File Offset: 0x000CE495
		private int BytesToWord(byte[] src, int srcOff)
		{
			return (int)(src[srcOff] & byte.MaxValue) | (int)(src[srcOff + 1] & byte.MaxValue) << 8 | (int)(src[srcOff + 2] & byte.MaxValue) << 16 | (int)(src[srcOff + 3] & byte.MaxValue) << 24;
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x000D02CC File Offset: 0x000CE4CC
		private void WordToBytes(int word, byte[] dst, int dstOff)
		{
			dst[dstOff] = (byte)word;
			dst[dstOff + 1] = (byte)(word >> 8);
			dst[dstOff + 2] = (byte)(word >> 16);
			dst[dstOff + 3] = (byte)(word >> 24);
		}

		// Token: 0x0400137D RID: 4989
		private int _noRounds;

		// Token: 0x0400137E RID: 4990
		private int[] _S;

		// Token: 0x0400137F RID: 4991
		private static readonly int P32 = -1209970333;

		// Token: 0x04001380 RID: 4992
		private static readonly int Q32 = -1640531527;

		// Token: 0x04001381 RID: 4993
		private bool forEncryption;
	}
}
