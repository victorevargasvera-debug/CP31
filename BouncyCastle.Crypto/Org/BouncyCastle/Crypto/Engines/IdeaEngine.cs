using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004A0 RID: 1184
	public class IdeaEngine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002DA9 RID: 11689 RVA: 0x000CD4F2 File Offset: 0x000CB6F2
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("invalid parameter passed to IDEA init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
			}
			this.workingKey = this.GenerateWorkingKey(forEncryption, ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey());
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x000CD52A File Offset: 0x000CB72A
		public virtual string AlgorithmName
		{
			get
			{
				return "IDEA";
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06002DAB RID: 11691 RVA: 0x000CD531 File Offset: 0x000CB731
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x000CD534 File Offset: 0x000CB734
		public virtual int GetBlockSize()
		{
			return 8;
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x000CD538 File Offset: 0x000CB738
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (this.workingKey == null)
			{
				throw new global::System.InvalidOperationException("IDEA engine not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, 8, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, 8, "output buffer too short");
			this.IdeaFunc(this.workingKey, input, inOff, output, outOff);
			return 8;
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x000CD585 File Offset: 0x000CB785
		public virtual void Reset()
		{
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x000CD587 File Offset: 0x000CB787
		private int BytesToWord(byte[] input, int inOff)
		{
			return ((int)input[inOff] << 8 & 65280) + (int)(input[inOff + 1] & byte.MaxValue);
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x000CD5A0 File Offset: 0x000CB7A0
		private void WordToBytes(int word, byte[] outBytes, int outOff)
		{
			outBytes[outOff] = (byte)((uint)word >> 8);
			outBytes[outOff + 1] = (byte)word;
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x000CD5B0 File Offset: 0x000CB7B0
		private int Mul(int x, int y)
		{
			if (x == 0)
			{
				x = global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.BASE - y;
			}
			else if (y == 0)
			{
				x = global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.BASE - x;
			}
			else
			{
				int num = x * y;
				y = (num & global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK);
				x = (int)((uint)num >> 16);
				x = y - x + ((y < x) ? 1 : 0);
			}
			return x & global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK;
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x000CD600 File Offset: 0x000CB800
		private void IdeaFunc(int[] workingKey, byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			int keyOff = 0;
			int x0 = this.BytesToWord(input, inOff);
			int x = this.BytesToWord(input, inOff + 2);
			int x2 = this.BytesToWord(input, inOff + 4);
			int x3 = this.BytesToWord(input, inOff + 6);
			for (int round = 0; round < 8; round++)
			{
				x0 = this.Mul(x0, workingKey[keyOff++]);
				x += workingKey[keyOff++];
				x &= global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK;
				x2 += workingKey[keyOff++];
				x2 &= global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK;
				x3 = this.Mul(x3, workingKey[keyOff++]);
				int t0 = x;
				int t = x2;
				x2 ^= x0;
				x ^= x3;
				x2 = this.Mul(x2, workingKey[keyOff++]);
				x += x2;
				x &= global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK;
				x = this.Mul(x, workingKey[keyOff++]);
				x2 += x;
				x2 &= global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK;
				x0 ^= x;
				x3 ^= x2;
				x ^= t;
				x2 ^= t0;
			}
			this.WordToBytes(this.Mul(x0, workingKey[keyOff++]), outBytes, outOff);
			this.WordToBytes(x2 + workingKey[keyOff++], outBytes, outOff + 2);
			this.WordToBytes(x + workingKey[keyOff++], outBytes, outOff + 4);
			this.WordToBytes(this.Mul(x3, workingKey[keyOff]), outBytes, outOff + 6);
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x000CD754 File Offset: 0x000CB954
		private int[] ExpandKey(byte[] uKey)
		{
			int[] key = new int[52];
			if (uKey.Length < 16)
			{
				byte[] tmp = new byte[16];
				global::System.Array.Copy(uKey, 0, tmp, tmp.Length - uKey.Length, uKey.Length);
				uKey = tmp;
			}
			for (int i = 0; i < 8; i++)
			{
				key[i] = this.BytesToWord(uKey, i * 2);
			}
			for (int j = 8; j < 52; j++)
			{
				if ((j & 7) < 6)
				{
					key[j] = (((key[j - 7] & 127) << 9 | key[j - 6] >> 7) & global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK);
				}
				else if ((j & 7) == 6)
				{
					key[j] = (((key[j - 7] & 127) << 9 | key[j - 14] >> 7) & global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK);
				}
				else
				{
					key[j] = (((key[j - 15] & 127) << 9 | key[j - 14] >> 7) & global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK);
				}
			}
			return key;
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x000CD81C File Offset: 0x000CBA1C
		private int MulInv(int x)
		{
			if (x < 2)
			{
				return x;
			}
			int t0 = 1;
			int t = global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.BASE / x;
			int y = global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.BASE % x;
			while (y != 1)
			{
				int q = x / y;
				x %= y;
				t0 = (t0 + t * q & global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK);
				if (x == 1)
				{
					return t0;
				}
				q = y / x;
				y %= x;
				t = (t + t0 * q & global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK);
			}
			return 1 - t & global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK;
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x000CD87F File Offset: 0x000CBA7F
		private int AddInv(int x)
		{
			return 0 - x & global::Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK;
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x000CD88C File Offset: 0x000CBA8C
		private int[] InvertKey(int[] inKey)
		{
			int p = 52;
			int[] key = new int[52];
			int inOff = 0;
			int t = this.MulInv(inKey[inOff++]);
			int t2 = this.AddInv(inKey[inOff++]);
			int t3 = this.AddInv(inKey[inOff++]);
			int t4 = this.MulInv(inKey[inOff++]);
			key[--p] = t4;
			key[--p] = t3;
			key[--p] = t2;
			key[--p] = t;
			for (int round = 1; round < 8; round++)
			{
				t = inKey[inOff++];
				t2 = inKey[inOff++];
				key[--p] = t2;
				key[--p] = t;
				t = this.MulInv(inKey[inOff++]);
				t2 = this.AddInv(inKey[inOff++]);
				t3 = this.AddInv(inKey[inOff++]);
				t4 = this.MulInv(inKey[inOff++]);
				key[--p] = t4;
				key[--p] = t2;
				key[--p] = t3;
				key[--p] = t;
			}
			t = inKey[inOff++];
			t2 = inKey[inOff++];
			key[--p] = t2;
			key[--p] = t;
			t = this.MulInv(inKey[inOff++]);
			t2 = this.AddInv(inKey[inOff++]);
			t3 = this.AddInv(inKey[inOff++]);
			t4 = this.MulInv(inKey[inOff]);
			key[--p] = t4;
			key[--p] = t3;
			key[--p] = t2;
			key[p - 1] = t;
			return key;
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x000CDA54 File Offset: 0x000CBC54
		private int[] GenerateWorkingKey(bool forEncryption, byte[] userKey)
		{
			if (forEncryption)
			{
				return this.ExpandKey(userKey);
			}
			return this.InvertKey(this.ExpandKey(userKey));
		}

		// Token: 0x04001349 RID: 4937
		private const int BLOCK_SIZE = 8;

		// Token: 0x0400134A RID: 4938
		private int[] workingKey;

		// Token: 0x0400134B RID: 4939
		private static readonly int MASK = 65535;

		// Token: 0x0400134C RID: 4940
		private static readonly int BASE = 65537;
	}
}
