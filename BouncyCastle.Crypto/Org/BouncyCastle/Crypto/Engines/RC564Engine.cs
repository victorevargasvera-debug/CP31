using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004AA RID: 1194
	public class RC564Engine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002E11 RID: 11793 RVA: 0x000D0306 File Offset: 0x000CE506
		public RC564Engine()
		{
			this._noRounds = 12;
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x000D0316 File Offset: 0x000CE516
		public virtual string AlgorithmName
		{
			get
			{
				return "RC5-64";
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06002E13 RID: 11795 RVA: 0x000D031D File Offset: 0x000CE51D
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x000D0320 File Offset: 0x000CE520
		public virtual int GetBlockSize()
		{
			return 2 * global::Org.BouncyCastle.Crypto.Engines.RC564Engine.bytesPerWord;
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x000D032C File Offset: 0x000CE52C
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!typeof(global::Org.BouncyCastle.Crypto.Parameters.RC5Parameters).IsInstanceOfType(parameters))
			{
				throw new global::System.ArgumentException("invalid parameter passed to RC564 init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
			}
			global::Org.BouncyCastle.Crypto.Parameters.RC5Parameters p = (global::Org.BouncyCastle.Crypto.Parameters.RC5Parameters)parameters;
			this.forEncryption = forEncryption;
			this._noRounds = p.Rounds;
			this.SetKey(p.GetKey());
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x000D0387 File Offset: 0x000CE587
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (!this.forEncryption)
			{
				return this.DecryptBlock(input, inOff, output, outOff);
			}
			return this.EncryptBlock(input, inOff, output, outOff);
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x000D03A8 File Offset: 0x000CE5A8
		public virtual void Reset()
		{
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x000D03AC File Offset: 0x000CE5AC
		private void SetKey(byte[] key)
		{
			long[] L = new long[(key.Length + (global::Org.BouncyCastle.Crypto.Engines.RC564Engine.bytesPerWord - 1)) / global::Org.BouncyCastle.Crypto.Engines.RC564Engine.bytesPerWord];
			for (int i = 0; i != key.Length; i++)
			{
				L[i / global::Org.BouncyCastle.Crypto.Engines.RC564Engine.bytesPerWord] += (long)(key[i] & byte.MaxValue) << 8 * (i % global::Org.BouncyCastle.Crypto.Engines.RC564Engine.bytesPerWord);
			}
			this._S = new long[2 * (this._noRounds + 1)];
			this._S[0] = global::Org.BouncyCastle.Crypto.Engines.RC564Engine.P64;
			for (int j = 1; j < this._S.Length; j++)
			{
				this._S[j] = this._S[j - 1] + global::Org.BouncyCastle.Crypto.Engines.RC564Engine.Q64;
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
			long A = 0L;
			long B = 0L;
			int ii = 0;
			int jj = 0;
			for (int k = 0; k < iter; k++)
			{
				A = (this._S[ii] = this.RotateLeft(this._S[ii] + A + B, 3L));
				B = (L[jj] = this.RotateLeft(L[jj] + A + B, A + B));
				ii = (ii + 1) % this._S.Length;
				jj = (jj + 1) % L.Length;
			}
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x000D04F4 File Offset: 0x000CE6F4
		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			long A = this.BytesToWord(input, inOff) + this._S[0];
			long B = this.BytesToWord(input, inOff + global::Org.BouncyCastle.Crypto.Engines.RC564Engine.bytesPerWord) + this._S[1];
			for (int i = 1; i <= this._noRounds; i++)
			{
				A = this.RotateLeft(A ^ B, B) + this._S[2 * i];
				B = this.RotateLeft(B ^ A, A) + this._S[2 * i + 1];
			}
			this.WordToBytes(A, outBytes, outOff);
			this.WordToBytes(B, outBytes, outOff + global::Org.BouncyCastle.Crypto.Engines.RC564Engine.bytesPerWord);
			return 2 * global::Org.BouncyCastle.Crypto.Engines.RC564Engine.bytesPerWord;
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x000D058C File Offset: 0x000CE78C
		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			long A = this.BytesToWord(input, inOff);
			long B = this.BytesToWord(input, inOff + global::Org.BouncyCastle.Crypto.Engines.RC564Engine.bytesPerWord);
			for (int i = this._noRounds; i >= 1; i--)
			{
				B = (this.RotateRight(B - this._S[2 * i + 1], A) ^ A);
				A = (this.RotateRight(A - this._S[2 * i], B) ^ B);
			}
			this.WordToBytes(A - this._S[0], outBytes, outOff);
			this.WordToBytes(B - this._S[1], outBytes, outOff + global::Org.BouncyCastle.Crypto.Engines.RC564Engine.bytesPerWord);
			return 2 * global::Org.BouncyCastle.Crypto.Engines.RC564Engine.bytesPerWord;
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x000D0623 File Offset: 0x000CE823
		private long RotateLeft(long x, long y)
		{
			return x << (int)(y & (long)(global::Org.BouncyCastle.Crypto.Engines.RC564Engine.wordSize - 1)) | (long)((ulong)x >> (int)((long)global::Org.BouncyCastle.Crypto.Engines.RC564Engine.wordSize - (y & (long)(global::Org.BouncyCastle.Crypto.Engines.RC564Engine.wordSize - 1))));
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x000D064D File Offset: 0x000CE84D
		private long RotateRight(long x, long y)
		{
			return (long)((ulong)x >> (int)(y & (long)(global::Org.BouncyCastle.Crypto.Engines.RC564Engine.wordSize - 1)) | (ulong)((ulong)x << (int)((long)global::Org.BouncyCastle.Crypto.Engines.RC564Engine.wordSize - (y & (long)(global::Org.BouncyCastle.Crypto.Engines.RC564Engine.wordSize - 1)))));
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x000D0678 File Offset: 0x000CE878
		private long BytesToWord(byte[] src, int srcOff)
		{
			long word = 0L;
			for (int i = global::Org.BouncyCastle.Crypto.Engines.RC564Engine.bytesPerWord - 1; i >= 0; i--)
			{
				word = (word << 8) + (long)(src[i + srcOff] & byte.MaxValue);
			}
			return word;
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x000D06AC File Offset: 0x000CE8AC
		private void WordToBytes(long word, byte[] dst, int dstOff)
		{
			for (int i = 0; i < global::Org.BouncyCastle.Crypto.Engines.RC564Engine.bytesPerWord; i++)
			{
				dst[i + dstOff] = (byte)word;
				word = (long)((ulong)word >> 8);
			}
		}

		// Token: 0x04001382 RID: 4994
		private static readonly int wordSize = 64;

		// Token: 0x04001383 RID: 4995
		private static readonly int bytesPerWord = global::Org.BouncyCastle.Crypto.Engines.RC564Engine.wordSize / 8;

		// Token: 0x04001384 RID: 4996
		private int _noRounds;

		// Token: 0x04001385 RID: 4997
		private long[] _S;

		// Token: 0x04001386 RID: 4998
		private static readonly long P64 = -5196783011329398165L;

		// Token: 0x04001387 RID: 4999
		private static readonly long Q64 = -7046029254386353131L;

		// Token: 0x04001388 RID: 5000
		private bool forEncryption;
	}
}
