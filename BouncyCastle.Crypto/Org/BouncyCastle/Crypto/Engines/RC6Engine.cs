using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004AB RID: 1195
	public class RC6Engine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x000D070E File Offset: 0x000CE90E
		public virtual string AlgorithmName
		{
			get
			{
				return "RC6";
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x000D0715 File Offset: 0x000CE915
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x000D0718 File Offset: 0x000CE918
		public virtual int GetBlockSize()
		{
			return 4 * global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord;
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x000D0724 File Offset: 0x000CE924
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("invalid parameter passed to RC6 init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
			}
			this.forEncryption = forEncryption;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter p = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters;
			this.SetKey(p.GetKey());
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x000D076C File Offset: 0x000CE96C
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			int blockSize = this.GetBlockSize();
			if (this._S == null)
			{
				throw new global::System.InvalidOperationException("RC6 engine not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, blockSize, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, blockSize, "output buffer too short");
			if (!this.forEncryption)
			{
				return this.DecryptBlock(input, inOff, output, outOff);
			}
			return this.EncryptBlock(input, inOff, output, outOff);
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x000D07CD File Offset: 0x000CE9CD
		public virtual void Reset()
		{
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x000D07D0 File Offset: 0x000CE9D0
		private void SetKey(byte[] key)
		{
			int num = (key.Length + (global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord - 1)) / global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord;
			int[] L = new int[(key.Length + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord - 1) / global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord];
			for (int i = key.Length - 1; i >= 0; i--)
			{
				L[i / global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord] = (L[i / global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord] << 8) + (int)(key[i] & byte.MaxValue);
			}
			this._S = new int[2 + 2 * global::Org.BouncyCastle.Crypto.Engines.RC6Engine._noRounds + 2];
			this._S[0] = global::Org.BouncyCastle.Crypto.Engines.RC6Engine.P32;
			for (int j = 1; j < this._S.Length; j++)
			{
				this._S[j] = this._S[j - 1] + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.Q32;
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

		// Token: 0x06002E28 RID: 11816 RVA: 0x000D0920 File Offset: 0x000CEB20
		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			int A = this.BytesToWord(input, inOff);
			int B = this.BytesToWord(input, inOff + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord);
			int C = this.BytesToWord(input, inOff + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord * 2);
			int D = this.BytesToWord(input, inOff + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord * 3);
			B += this._S[0];
			D += this._S[1];
			for (int i = 1; i <= global::Org.BouncyCastle.Crypto.Engines.RC6Engine._noRounds; i++)
			{
				int t = B * (2 * B + 1);
				t = this.RotateLeft(t, 5);
				int u = D * (2 * D + 1);
				u = this.RotateLeft(u, 5);
				A ^= t;
				A = this.RotateLeft(A, u);
				A += this._S[2 * i];
				C ^= u;
				C = this.RotateLeft(C, t);
				C += this._S[2 * i + 1];
				int num = A;
				A = B;
				B = C;
				C = D;
				D = num;
			}
			A += this._S[2 * global::Org.BouncyCastle.Crypto.Engines.RC6Engine._noRounds + 2];
			C += this._S[2 * global::Org.BouncyCastle.Crypto.Engines.RC6Engine._noRounds + 3];
			this.WordToBytes(A, outBytes, outOff);
			this.WordToBytes(B, outBytes, outOff + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord);
			this.WordToBytes(C, outBytes, outOff + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord * 2);
			this.WordToBytes(D, outBytes, outOff + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord * 3);
			return 4 * global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord;
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x000D0A74 File Offset: 0x000CEC74
		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			int A = this.BytesToWord(input, inOff);
			int B = this.BytesToWord(input, inOff + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord);
			int C = this.BytesToWord(input, inOff + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord * 2);
			int D = this.BytesToWord(input, inOff + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord * 3);
			C -= this._S[2 * global::Org.BouncyCastle.Crypto.Engines.RC6Engine._noRounds + 3];
			A -= this._S[2 * global::Org.BouncyCastle.Crypto.Engines.RC6Engine._noRounds + 2];
			for (int i = global::Org.BouncyCastle.Crypto.Engines.RC6Engine._noRounds; i >= 1; i--)
			{
				int num = D;
				D = C;
				C = B;
				B = A;
				A = num;
				int t = B * (2 * B + 1);
				t = this.RotateLeft(t, global::Org.BouncyCastle.Crypto.Engines.RC6Engine.LGW);
				int u = D * (2 * D + 1);
				u = this.RotateLeft(u, global::Org.BouncyCastle.Crypto.Engines.RC6Engine.LGW);
				C -= this._S[2 * i + 1];
				C = this.RotateRight(C, t);
				C ^= u;
				A -= this._S[2 * i];
				A = this.RotateRight(A, u);
				A ^= t;
			}
			D -= this._S[1];
			B -= this._S[0];
			this.WordToBytes(A, outBytes, outOff);
			this.WordToBytes(B, outBytes, outOff + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord);
			this.WordToBytes(C, outBytes, outOff + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord * 2);
			this.WordToBytes(D, outBytes, outOff + global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord * 3);
			return 4 * global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord;
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x000D0BD0 File Offset: 0x000CEDD0
		private int RotateLeft(int x, int y)
		{
			return x << (y & global::Org.BouncyCastle.Crypto.Engines.RC6Engine.wordSize - 1) | (int)((uint)x >> global::Org.BouncyCastle.Crypto.Engines.RC6Engine.wordSize - (y & global::Org.BouncyCastle.Crypto.Engines.RC6Engine.wordSize - 1));
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x000D0BF5 File Offset: 0x000CEDF5
		private int RotateRight(int x, int y)
		{
			return (int)((uint)x >> (y & global::Org.BouncyCastle.Crypto.Engines.RC6Engine.wordSize - 1) | (uint)((uint)x << global::Org.BouncyCastle.Crypto.Engines.RC6Engine.wordSize - (y & global::Org.BouncyCastle.Crypto.Engines.RC6Engine.wordSize - 1)));
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x000D0C1C File Offset: 0x000CEE1C
		private int BytesToWord(byte[] src, int srcOff)
		{
			int word = 0;
			for (int i = global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord - 1; i >= 0; i--)
			{
				word = (word << 8) + (int)(src[i + srcOff] & byte.MaxValue);
			}
			return word;
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x000D0C50 File Offset: 0x000CEE50
		private void WordToBytes(int word, byte[] dst, int dstOff)
		{
			for (int i = 0; i < global::Org.BouncyCastle.Crypto.Engines.RC6Engine.bytesPerWord; i++)
			{
				dst[i + dstOff] = (byte)word;
				word = (int)((uint)word >> 8);
			}
		}

		// Token: 0x04001389 RID: 5001
		private static readonly int wordSize = 32;

		// Token: 0x0400138A RID: 5002
		private static readonly int bytesPerWord = global::Org.BouncyCastle.Crypto.Engines.RC6Engine.wordSize / 8;

		// Token: 0x0400138B RID: 5003
		private static readonly int _noRounds = 20;

		// Token: 0x0400138C RID: 5004
		private int[] _S;

		// Token: 0x0400138D RID: 5005
		private static readonly int P32 = -1209970333;

		// Token: 0x0400138E RID: 5006
		private static readonly int Q32 = -1640531527;

		// Token: 0x0400138F RID: 5007
		private static readonly int LGW = 5;

		// Token: 0x04001390 RID: 5008
		private bool forEncryption;
	}
}
