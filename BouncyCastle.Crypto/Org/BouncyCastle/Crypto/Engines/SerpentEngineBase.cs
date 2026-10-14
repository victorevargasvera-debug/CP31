using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004B7 RID: 1207
	public abstract class SerpentEngineBase : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002E9E RID: 11934 RVA: 0x000D57F4 File Offset: 0x000D39F4
		public virtual void Init(bool encrypting, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("invalid parameter passed to " + this.AlgorithmName + " init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
			}
			this.encrypting = encrypting;
			this.wKey = this.MakeWorkingKey(((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey());
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x000D5848 File Offset: 0x000D3A48
		public virtual string AlgorithmName
		{
			get
			{
				return "Serpent";
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06002EA0 RID: 11936 RVA: 0x000D584F File Offset: 0x000D3A4F
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x000D5852 File Offset: 0x000D3A52
		public virtual int GetBlockSize()
		{
			return global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.BlockSize;
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x000D585C File Offset: 0x000D3A5C
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (this.wKey == null)
			{
				throw new global::System.InvalidOperationException(this.AlgorithmName + " not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.BlockSize, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.BlockSize, "output buffer too short");
			if (this.encrypting)
			{
				this.EncryptBlock(input, inOff, output, outOff);
			}
			else
			{
				this.DecryptBlock(input, inOff, output, outOff);
			}
			return global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.BlockSize;
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x000D58CF File Offset: 0x000D3ACF
		public virtual void Reset()
		{
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000D58D1 File Offset: 0x000D3AD1
		protected static int RotateLeft(int x, int bits)
		{
			return x << bits | (int)((uint)x >> 32 - bits);
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x000D58E3 File Offset: 0x000D3AE3
		private static int RotateRight(int x, int bits)
		{
			return (int)((uint)x >> bits | (uint)((uint)x << 32 - bits));
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x000D58F8 File Offset: 0x000D3AF8
		protected void Sb0(int a, int b, int c, int d)
		{
			int t = a ^ d;
			int t2 = c ^ t;
			int t3 = b ^ t2;
			this.X3 = ((a & d) ^ t3);
			int t4 = a ^ (b & t);
			this.X2 = (t3 ^ (c | t4));
			int t5 = this.X3 & (t2 ^ t4);
			this.X1 = (~t2 ^ t5);
			this.X0 = (t5 ^ ~t4);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x000D5954 File Offset: 0x000D3B54
		protected void Ib0(int a, int b, int c, int d)
		{
			int t = ~a;
			int t2 = a ^ b;
			int t3 = d ^ (t | t2);
			int t4 = c ^ t3;
			this.X2 = (t2 ^ t4);
			int t5 = t ^ (d & t2);
			this.X1 = (t3 ^ (this.X2 & t5));
			this.X3 = ((a & t3) ^ (t4 | this.X1));
			this.X0 = (this.X3 ^ (t4 ^ t5));
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x000D59B8 File Offset: 0x000D3BB8
		protected void Sb1(int a, int b, int c, int d)
		{
			int t2 = b ^ ~a;
			int t3 = c ^ (a | t2);
			this.X2 = (d ^ t3);
			int t4 = b ^ (d | t2);
			int t5 = t2 ^ this.X2;
			this.X3 = (t5 ^ (t3 & t4));
			int t6 = t3 ^ t4;
			this.X1 = (this.X3 ^ t6);
			this.X0 = (t3 ^ (t5 & t6));
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x000D5A18 File Offset: 0x000D3C18
		protected void Ib1(int a, int b, int c, int d)
		{
			int t = b ^ d;
			int t2 = a ^ (b & t);
			int t3 = t ^ t2;
			this.X3 = (c ^ t3);
			int t4 = b ^ (t & t2);
			int t5 = this.X3 | t4;
			this.X1 = (t2 ^ t5);
			int t6 = ~this.X1;
			int t7 = this.X3 ^ t4;
			this.X0 = (t6 ^ t7);
			this.X2 = (t3 ^ (t6 | t7));
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x000D5A84 File Offset: 0x000D3C84
		protected void Sb2(int a, int b, int c, int d)
		{
			int t = ~a;
			int t2 = b ^ d;
			int t3 = c & t;
			this.X0 = (t2 ^ t3);
			int t4 = c ^ t;
			int t5 = c ^ this.X0;
			int t6 = b & t5;
			this.X3 = (t4 ^ t6);
			this.X2 = (a ^ ((d | t6) & (this.X0 | t4)));
			this.X1 = (t2 ^ this.X3 ^ (this.X2 ^ (d | t)));
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x000D5AF4 File Offset: 0x000D3CF4
		protected void Ib2(int a, int b, int c, int d)
		{
			int t = b ^ d;
			int t2 = ~t;
			int t3 = a ^ c;
			int t4 = c ^ t;
			int t5 = b & t4;
			this.X0 = (t3 ^ t5);
			int t6 = a | t2;
			int t7 = d ^ t6;
			int t8 = t3 | t7;
			this.X3 = (t ^ t8);
			int t9 = ~t4;
			int t10 = this.X0 | this.X3;
			this.X1 = (t9 ^ t10);
			this.X2 = ((d & t9) ^ (t3 ^ t10));
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x000D5B6C File Offset: 0x000D3D6C
		protected void Sb3(int a, int b, int c, int d)
		{
			int t = a ^ b;
			int num = a & c;
			int t2 = a | d;
			int t3 = c ^ d;
			int t4 = t & t2;
			int t5 = num | t4;
			this.X2 = (t3 ^ t5);
			int t6 = b ^ t2;
			int t7 = t5 ^ t6;
			int t8 = t3 & t7;
			this.X0 = (t ^ t8);
			int t9 = this.X2 & this.X0;
			this.X1 = (t7 ^ t9);
			this.X3 = ((b | d) ^ (t3 ^ t9));
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x000D5BE4 File Offset: 0x000D3DE4
		protected void Ib3(int a, int b, int c, int d)
		{
			int num = a | b;
			int t2 = b ^ c;
			int t3 = b & t2;
			int t4 = a ^ t3;
			int t5 = c ^ t4;
			int t6 = d | t4;
			this.X0 = (t2 ^ t6);
			int t7 = t2 | t6;
			int t8 = d ^ t7;
			this.X2 = (t5 ^ t8);
			int t9 = num ^ t8;
			int t10 = this.X0 & t9;
			this.X3 = (t4 ^ t10);
			this.X1 = (this.X3 ^ (this.X0 ^ t9));
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x000D5C5C File Offset: 0x000D3E5C
		protected void Sb4(int a, int b, int c, int d)
		{
			int t = a ^ d;
			int t2 = d & t;
			int t3 = c ^ t2;
			int t4 = b | t3;
			this.X3 = (t ^ t4);
			int t5 = ~b;
			int t6 = t | t5;
			this.X0 = (t3 ^ t6);
			int t7 = a & this.X0;
			int t8 = t ^ t5;
			int t9 = t4 & t8;
			this.X2 = (t7 ^ t9);
			this.X1 = (a ^ t3 ^ (t8 & this.X2));
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x000D5CCC File Offset: 0x000D3ECC
		protected void Ib4(int a, int b, int c, int d)
		{
			int t = c | d;
			int t2 = a & t;
			int t3 = b ^ t2;
			int t4 = a & t3;
			int t5 = c ^ t4;
			this.X1 = (d ^ t5);
			int t6 = ~a;
			int t7 = t5 & this.X1;
			this.X3 = (t3 ^ t7);
			int t8 = this.X1 | t6;
			int t9 = d ^ t8;
			this.X0 = (this.X3 ^ t9);
			this.X2 = ((t3 & t9) ^ (this.X1 ^ t6));
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x000D5D48 File Offset: 0x000D3F48
		protected void Sb5(int a, int b, int c, int d)
		{
			int t = ~a;
			int num = a ^ b;
			int t2 = a ^ d;
			int t3 = c ^ t;
			int t4 = num | t2;
			this.X0 = (t3 ^ t4);
			int t5 = d & this.X0;
			int t6 = num ^ this.X0;
			this.X1 = (t5 ^ t6);
			int t7 = t | this.X0;
			int t8 = num | t5;
			int t9 = t2 ^ t7;
			this.X2 = (t8 ^ t9);
			this.X3 = (b ^ t5 ^ (this.X1 & t9));
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x000D5DC8 File Offset: 0x000D3FC8
		protected void Ib5(int a, int b, int c, int d)
		{
			int t = ~c;
			int t2 = b & t;
			int t3 = d ^ t2;
			int t4 = a & t3;
			int t5 = b ^ t;
			this.X3 = (t4 ^ t5);
			int t6 = b | this.X3;
			int t7 = a & t6;
			this.X1 = (t3 ^ t7);
			int t8 = a | d;
			int t9 = t ^ t6;
			this.X0 = (t8 ^ t9);
			this.X2 = ((b & t8) ^ (t4 | (a ^ c)));
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x000D5E38 File Offset: 0x000D4038
		protected void Sb6(int a, int b, int c, int d)
		{
			int num = ~a;
			int t2 = a ^ d;
			int t3 = b ^ t2;
			int t4 = num | t2;
			int t5 = c ^ t4;
			this.X1 = (b ^ t5);
			int t6 = t2 | this.X1;
			int t7 = d ^ t6;
			int t8 = t5 & t7;
			this.X2 = (t3 ^ t8);
			int t9 = t5 ^ t7;
			this.X0 = (this.X2 ^ t9);
			this.X3 = (~t5 ^ (t3 & t9));
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x000D5EA4 File Offset: 0x000D40A4
		protected void Ib6(int a, int b, int c, int d)
		{
			int t = ~a;
			int t2 = a ^ b;
			int t3 = c ^ t2;
			int t4 = c | t;
			int t5 = d ^ t4;
			this.X1 = (t3 ^ t5);
			int t6 = t3 & t5;
			int t7 = t2 ^ t6;
			int t8 = b | t7;
			this.X3 = (t5 ^ t8);
			int t9 = b | this.X3;
			this.X0 = (t7 ^ t9);
			this.X2 = ((d & t) ^ (t3 ^ t9));
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x000D5F14 File Offset: 0x000D4114
		protected void Sb7(int a, int b, int c, int d)
		{
			int t = b ^ c;
			int t2 = c & t;
			int t3 = d ^ t2;
			int t4 = a ^ t3;
			int t5 = d | t;
			int t6 = t4 & t5;
			this.X1 = (b ^ t6);
			int t7 = t3 | this.X1;
			int t8 = a & t4;
			this.X3 = (t ^ t8);
			int t9 = t4 ^ t7;
			int t10 = this.X3 & t9;
			this.X2 = (t3 ^ t10);
			this.X0 = (~t9 ^ (this.X3 & this.X2));
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x000D5F94 File Offset: 0x000D4194
		protected void Ib7(int a, int b, int c, int d)
		{
			int t3 = c | (a & b);
			int t4 = d & (a | b);
			this.X3 = (t3 ^ t4);
			int t5 = ~d;
			int t6 = b ^ t4;
			int t7 = t6 | (this.X3 ^ t5);
			this.X1 = (a ^ t7);
			this.X0 = (c ^ t6 ^ (d | this.X1));
			this.X2 = (t3 ^ this.X1 ^ (this.X0 ^ (a & this.X3)));
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x000D6008 File Offset: 0x000D4208
		protected void LT()
		{
			int x0 = global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.RotateLeft(this.X0, 13);
			int x = global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.RotateLeft(this.X2, 3);
			int x2 = this.X1 ^ x0 ^ x;
			int x3 = this.X3 ^ x ^ x0 << 3;
			this.X1 = global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.RotateLeft(x2, 1);
			this.X3 = global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.RotateLeft(x3, 7);
			this.X0 = global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.RotateLeft(x0 ^ this.X1 ^ this.X3, 5);
			this.X2 = global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.RotateLeft(x ^ this.X3 ^ this.X1 << 7, 22);
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x000D609C File Offset: 0x000D429C
		protected void InverseLT()
		{
			int x2 = global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.RotateRight(this.X2, 22) ^ this.X3 ^ this.X1 << 7;
			int x3 = global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.RotateRight(this.X0, 5) ^ this.X1 ^ this.X3;
			int x4 = global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.RotateRight(this.X3, 7);
			int x5 = global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.RotateRight(this.X1, 1);
			this.X3 = (x4 ^ x2 ^ x3 << 3);
			this.X1 = (x5 ^ x3 ^ x2);
			this.X2 = global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.RotateRight(x2, 3);
			this.X0 = global::Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.RotateRight(x3, 13);
		}

		// Token: 0x06002EB8 RID: 11960
		protected abstract int[] MakeWorkingKey(byte[] key);

		// Token: 0x06002EB9 RID: 11961
		protected abstract void EncryptBlock(byte[] input, int inOff, byte[] output, int outOff);

		// Token: 0x06002EBA RID: 11962
		protected abstract void DecryptBlock(byte[] input, int inOff, byte[] output, int outOff);

		// Token: 0x040013CF RID: 5071
		protected static readonly int BlockSize = 16;

		// Token: 0x040013D0 RID: 5072
		internal const int ROUNDS = 32;

		// Token: 0x040013D1 RID: 5073
		internal const int PHI = -1640531527;

		// Token: 0x040013D2 RID: 5074
		protected bool encrypting;

		// Token: 0x040013D3 RID: 5075
		protected int[] wKey;

		// Token: 0x040013D4 RID: 5076
		protected int X0;

		// Token: 0x040013D5 RID: 5077
		protected int X1;

		// Token: 0x040013D6 RID: 5078
		protected int X2;

		// Token: 0x040013D7 RID: 5079
		protected int X3;
	}
}
