using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004BE RID: 1214
	public sealed class TwofishEngine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002F01 RID: 12033 RVA: 0x000D9BD4 File Offset: 0x000D7DD4
		public TwofishEngine()
		{
			int[] m = new int[2];
			int[] mX = new int[2];
			int[] mY = new int[2];
			for (int i = 0; i < 256; i++)
			{
				int j = (int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, i] & byte.MaxValue);
				m[0] = j;
				mX[0] = (this.Mx_X(j) & 255);
				mY[0] = (this.Mx_Y(j) & 255);
				j = (int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, i] & byte.MaxValue);
				m[1] = j;
				mX[1] = (this.Mx_X(j) & 255);
				mY[1] = (this.Mx_Y(j) & 255);
				this.gMDS0[i] = (m[1] | mX[1] << 8 | mY[1] << 16 | mY[1] << 24);
				this.gMDS1[i] = (mY[0] | mY[0] << 8 | mX[0] << 16 | m[0] << 24);
				this.gMDS2[i] = (mX[1] | mY[1] << 8 | m[1] << 16 | mY[1] << 24);
				this.gMDS3[i] = (mX[0] | m[0] << 8 | mY[0] << 16 | mX[0] << 24);
			}
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x000D9D48 File Offset: 0x000D7F48
		public void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("invalid parameter passed to Twofish init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
			}
			this.encrypting = forEncryption;
			this.workingKey = ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey();
			int keyBits = this.workingKey.Length * 8;
			if (keyBits != 128 && keyBits != 192 && keyBits != 256)
			{
				throw new global::System.ArgumentException("Key length not 128/192/256 bits.");
			}
			this.k64Cnt = this.workingKey.Length / 8;
			this.SetKey(this.workingKey);
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x000D9DD5 File Offset: 0x000D7FD5
		public string AlgorithmName
		{
			get
			{
				return "Twofish";
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06002F04 RID: 12036 RVA: 0x000D9DDC File Offset: 0x000D7FDC
		public bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x000D9DE0 File Offset: 0x000D7FE0
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (this.workingKey == null)
			{
				throw new global::System.InvalidOperationException("Twofish not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, 16, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, 16, "output buffer too short");
			if (this.encrypting)
			{
				this.EncryptBlock(input, inOff, output, outOff);
			}
			else
			{
				this.DecryptBlock(input, inOff, output, outOff);
			}
			return 16;
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x000D9E3F File Offset: 0x000D803F
		public void Reset()
		{
			if (this.workingKey != null)
			{
				this.SetKey(this.workingKey);
			}
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x000D9E55 File Offset: 0x000D8055
		public int GetBlockSize()
		{
			return 16;
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x000D9E5C File Offset: 0x000D805C
		private void SetKey(byte[] key)
		{
			int[] k32e = new int[4];
			int[] k32o = new int[4];
			int[] sBoxKeys = new int[4];
			this.gSubKeys = new int[40];
			for (int i = 0; i < this.k64Cnt; i++)
			{
				int p = i * 8;
				k32e[i] = (int)global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, p);
				k32o[i] = (int)global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, p + 4);
				sBoxKeys[this.k64Cnt - 1 - i] = this.RS_MDS_Encode(k32e[i], k32o[i]);
			}
			for (int j = 0; j < 20; j++)
			{
				int q = j * 33686018;
				int A = this.F32(q, k32e);
				int B = this.F32(q + 16843009, k32o);
				B = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(B, 8);
				A += B;
				this.gSubKeys[j * 2] = A;
				A += B;
				this.gSubKeys[j * 2 + 1] = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(A, 9);
			}
			int k0 = sBoxKeys[0];
			int k = sBoxKeys[1];
			int k2 = sBoxKeys[2];
			int k3 = sBoxKeys[3];
			this.gSBox = new int[1024];
			int l = 0;
			while (l < 256)
			{
				int b4;
				int b3;
				int b2;
				int b = b2 = (b3 = (b4 = l));
				switch (this.k64Cnt & 3)
				{
				case 0:
					b2 = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b2] & byte.MaxValue) ^ this.M_b0(k3));
					b = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b] & byte.MaxValue) ^ this.M_b1(k3));
					b3 = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b3] & byte.MaxValue) ^ this.M_b2(k3));
					b4 = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b4] & byte.MaxValue) ^ this.M_b3(k3));
					goto IL_283;
				case 1:
					this.gSBox[l * 2] = this.gMDS0[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b2] & byte.MaxValue) ^ this.M_b0(k0)];
					this.gSBox[l * 2 + 1] = this.gMDS1[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b] & byte.MaxValue) ^ this.M_b1(k0)];
					this.gSBox[l * 2 + 512] = this.gMDS2[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b3] & byte.MaxValue) ^ this.M_b2(k0)];
					this.gSBox[l * 2 + 513] = this.gMDS3[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b4] & byte.MaxValue) ^ this.M_b3(k0)];
					break;
				case 2:
					goto IL_2FB;
				case 3:
					goto IL_283;
				}
				IL_429:
				l++;
				continue;
				IL_2FB:
				this.gSBox[l * 2] = this.gMDS0[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, (int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b2] & byte.MaxValue) ^ this.M_b0(k)] & byte.MaxValue) ^ this.M_b0(k0)];
				this.gSBox[l * 2 + 1] = this.gMDS1[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, (int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b] & byte.MaxValue) ^ this.M_b1(k)] & byte.MaxValue) ^ this.M_b1(k0)];
				this.gSBox[l * 2 + 512] = this.gMDS2[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, (int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b3] & byte.MaxValue) ^ this.M_b2(k)] & byte.MaxValue) ^ this.M_b2(k0)];
				this.gSBox[l * 2 + 513] = this.gMDS3[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, (int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b4] & byte.MaxValue) ^ this.M_b3(k)] & byte.MaxValue) ^ this.M_b3(k0)];
				goto IL_429;
				IL_283:
				b2 = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b2] & byte.MaxValue) ^ this.M_b0(k2));
				b = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b] & byte.MaxValue) ^ this.M_b1(k2));
				b3 = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b3] & byte.MaxValue) ^ this.M_b2(k2));
				b4 = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b4] & byte.MaxValue) ^ this.M_b3(k2));
				goto IL_2FB;
			}
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x000DA2A4 File Offset: 0x000D84A4
		private void EncryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
			int x0 = (int)(global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(src, srcIndex) ^ (uint)this.gSubKeys[0]);
			int x = (int)(global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(src, srcIndex + 4) ^ (uint)this.gSubKeys[1]);
			int x2 = (int)(global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(src, srcIndex + 8) ^ (uint)this.gSubKeys[2]);
			int x3 = (int)(global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(src, srcIndex + 12) ^ (uint)this.gSubKeys[3]);
			int i = 8;
			for (int r = 0; r < 16; r += 2)
			{
				int t0 = this.Fe32_0(x0);
				int t = this.Fe32_3(x);
				x2 ^= t0 + t + this.gSubKeys[i++];
				x2 = global::Org.BouncyCastle.Utilities.Integers.RotateRight(x2, 1);
				x3 = (global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x3, 1) ^ t0 + 2 * t + this.gSubKeys[i++]);
				t0 = this.Fe32_0(x2);
				t = this.Fe32_3(x3);
				x0 ^= t0 + t + this.gSubKeys[i++];
				x0 = global::Org.BouncyCastle.Utilities.Integers.RotateRight(x0, 1);
				x = (global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x, 1) ^ t0 + 2 * t + this.gSubKeys[i++]);
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(x2 ^ this.gSubKeys[4]), dst, dstIndex);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(x3 ^ this.gSubKeys[5]), dst, dstIndex + 4);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(x0 ^ this.gSubKeys[6]), dst, dstIndex + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(x ^ this.gSubKeys[7]), dst, dstIndex + 12);
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x000DA408 File Offset: 0x000D8608
		private void DecryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
			int x2 = (int)(global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(src, srcIndex) ^ (uint)this.gSubKeys[4]);
			int x3 = (int)(global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(src, srcIndex + 4) ^ (uint)this.gSubKeys[5]);
			int x4 = (int)(global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(src, srcIndex + 8) ^ (uint)this.gSubKeys[6]);
			int x5 = (int)(global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(src, srcIndex + 12) ^ (uint)this.gSubKeys[7]);
			int i = 39;
			for (int r = 0; r < 16; r += 2)
			{
				int t0 = this.Fe32_0(x2);
				int t = this.Fe32_3(x3);
				x5 ^= t0 + 2 * t + this.gSubKeys[i--];
				x4 = (global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x4, 1) ^ t0 + t + this.gSubKeys[i--]);
				x5 = global::Org.BouncyCastle.Utilities.Integers.RotateRight(x5, 1);
				t0 = this.Fe32_0(x4);
				t = this.Fe32_3(x5);
				x3 ^= t0 + 2 * t + this.gSubKeys[i--];
				x2 = (global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x2, 1) ^ t0 + t + this.gSubKeys[i--]);
				x3 = global::Org.BouncyCastle.Utilities.Integers.RotateRight(x3, 1);
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(x4 ^ this.gSubKeys[0]), dst, dstIndex);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(x5 ^ this.gSubKeys[1]), dst, dstIndex + 4);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(x2 ^ this.gSubKeys[2]), dst, dstIndex + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(x3 ^ this.gSubKeys[3]), dst, dstIndex + 12);
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x000DA56C File Offset: 0x000D876C
		private int F32(int x, int[] k32)
		{
			int b0 = this.M_b0(x);
			int b = this.M_b1(x);
			int b2 = this.M_b2(x);
			int b3 = this.M_b3(x);
			int k33 = k32[0];
			int k34 = k32[1];
			int k35 = k32[2];
			int k36 = k32[3];
			int result = 0;
			switch (this.k64Cnt & 3)
			{
			case 0:
				b0 = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b0] & byte.MaxValue) ^ this.M_b0(k36));
				b = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b] & byte.MaxValue) ^ this.M_b1(k36));
				b2 = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b2] & byte.MaxValue) ^ this.M_b2(k36));
				b3 = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b3] & byte.MaxValue) ^ this.M_b3(k36));
				break;
			case 1:
				return this.gMDS0[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b0] & byte.MaxValue) ^ this.M_b0(k33)] ^ this.gMDS1[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b] & byte.MaxValue) ^ this.M_b1(k33)] ^ this.gMDS2[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b2] & byte.MaxValue) ^ this.M_b2(k33)] ^ this.gMDS3[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b3] & byte.MaxValue) ^ this.M_b3(k33)];
			case 2:
				goto IL_1CF;
			case 3:
				break;
			default:
				return result;
			}
			b0 = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b0] & byte.MaxValue) ^ this.M_b0(k35));
			b = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b] & byte.MaxValue) ^ this.M_b1(k35));
			b2 = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b2] & byte.MaxValue) ^ this.M_b2(k35));
			b3 = ((int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b3] & byte.MaxValue) ^ this.M_b3(k35));
			IL_1CF:
			result = (this.gMDS0[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, (int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b0] & byte.MaxValue) ^ this.M_b0(k34)] & byte.MaxValue) ^ this.M_b0(k33)] ^ this.gMDS1[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, (int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b] & byte.MaxValue) ^ this.M_b1(k34)] & byte.MaxValue) ^ this.M_b1(k33)] ^ this.gMDS2[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, (int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[0, b2] & byte.MaxValue) ^ this.M_b2(k34)] & byte.MaxValue) ^ this.M_b2(k33)] ^ this.gMDS3[(int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, (int)(global::Org.BouncyCastle.Crypto.Engines.TwofishEngine.P[1, b3] & byte.MaxValue) ^ this.M_b3(k34)] & byte.MaxValue) ^ this.M_b3(k33)]);
			return result;
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x000DA840 File Offset: 0x000D8A40
		private int RS_MDS_Encode(int k0, int k1)
		{
			int r = k1;
			for (int i = 0; i < 4; i++)
			{
				r = this.RS_rem(r);
			}
			r ^= k0;
			for (int j = 0; j < 4; j++)
			{
				r = this.RS_rem(r);
			}
			return r;
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x000DA87C File Offset: 0x000D8A7C
		private int RS_rem(int x)
		{
			int b = (int)((uint)x >> 24 & 255U);
			int g2 = (b << 1 ^ (((b & 128) != 0) ? 333 : 0)) & 255;
			int g3 = (int)((uint)b >> 1 ^ (((b & 1) != 0) ? 166U : 0U) ^ (uint)g2);
			return x << 8 ^ g3 << 24 ^ g2 << 16 ^ g3 << 8 ^ b;
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x000DA8D7 File Offset: 0x000D8AD7
		private int LFSR1(int x)
		{
			return x >> 1 ^ (((x & 1) != 0) ? 180 : 0);
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x000DA8EA File Offset: 0x000D8AEA
		private int LFSR2(int x)
		{
			return x >> 2 ^ (((x & 2) != 0) ? 180 : 0) ^ (((x & 1) != 0) ? 90 : 0);
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x000DA908 File Offset: 0x000D8B08
		private int Mx_X(int x)
		{
			return x ^ this.LFSR2(x);
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x000DA913 File Offset: 0x000D8B13
		private int Mx_Y(int x)
		{
			return x ^ this.LFSR1(x) ^ this.LFSR2(x);
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x000DA926 File Offset: 0x000D8B26
		private int M_b0(int x)
		{
			return x & 255;
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x000DA92F File Offset: 0x000D8B2F
		private int M_b1(int x)
		{
			return (int)((uint)x >> 8 & 255U);
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x000DA93A File Offset: 0x000D8B3A
		private int M_b2(int x)
		{
			return (int)((uint)x >> 16 & 255U);
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x000DA946 File Offset: 0x000D8B46
		private int M_b3(int x)
		{
			return (int)((uint)x >> 24 & 255U);
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x000DA954 File Offset: 0x000D8B54
		private int Fe32_0(int x)
		{
			return this.gSBox[2 * (x & 255)] ^ this.gSBox[(int)(1U + 2U * ((uint)x >> 8 & 255U))] ^ this.gSBox[(int)(512U + 2U * ((uint)x >> 16 & 255U))] ^ this.gSBox[(int)(513U + 2U * ((uint)x >> 24 & 255U))];
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x000DA9BC File Offset: 0x000D8BBC
		private int Fe32_3(int x)
		{
			return this.gSBox[(int)(2U * ((uint)x >> 24 & 255U))] ^ this.gSBox[1 + 2 * (x & 255)] ^ this.gSBox[(int)(512U + 2U * ((uint)x >> 8 & 255U))] ^ this.gSBox[(int)(513U + 2U * ((uint)x >> 16 & 255U))];
		}

		// Token: 0x04001409 RID: 5129
		private static readonly byte[,] P = new byte[,]
		{
			{
				169,
				103,
				179,
				232,
				4,
				253,
				163,
				118,
				154,
				146,
				128,
				120,
				228,
				221,
				209,
				56,
				13,
				198,
				53,
				152,
				24,
				247,
				236,
				108,
				67,
				117,
				55,
				38,
				250,
				19,
				148,
				72,
				242,
				208,
				139,
				48,
				132,
				84,
				223,
				35,
				25,
				91,
				61,
				89,
				243,
				174,
				162,
				130,
				99,
				1,
				131,
				46,
				217,
				81,
				155,
				124,
				166,
				235,
				165,
				190,
				22,
				12,
				227,
				97,
				192,
				140,
				58,
				245,
				115,
				44,
				37,
				11,
				187,
				78,
				137,
				107,
				83,
				106,
				180,
				241,
				225,
				230,
				189,
				69,
				226,
				244,
				182,
				102,
				204,
				149,
				3,
				86,
				212,
				28,
				30,
				215,
				251,
				195,
				142,
				181,
				233,
				207,
				191,
				186,
				234,
				119,
				57,
				175,
				51,
				201,
				98,
				113,
				129,
				121,
				9,
				173,
				36,
				205,
				249,
				216,
				229,
				197,
				185,
				77,
				68,
				8,
				134,
				231,
				161,
				29,
				170,
				237,
				6,
				112,
				178,
				210,
				65,
				123,
				160,
				17,
				49,
				194,
				39,
				144,
				32,
				246,
				96,
				byte.MaxValue,
				150,
				92,
				177,
				171,
				158,
				156,
				82,
				27,
				95,
				147,
				10,
				239,
				145,
				133,
				73,
				238,
				45,
				79,
				143,
				59,
				71,
				135,
				109,
				70,
				214,
				62,
				105,
				100,
				42,
				206,
				203,
				47,
				252,
				151,
				5,
				122,
				172,
				127,
				213,
				26,
				75,
				14,
				167,
				90,
				40,
				20,
				63,
				41,
				136,
				60,
				76,
				2,
				184,
				218,
				176,
				23,
				85,
				31,
				138,
				125,
				87,
				199,
				141,
				116,
				183,
				196,
				159,
				114,
				126,
				21,
				34,
				18,
				88,
				7,
				153,
				52,
				110,
				80,
				222,
				104,
				101,
				188,
				219,
				248,
				200,
				168,
				43,
				64,
				220,
				254,
				50,
				164,
				202,
				16,
				33,
				240,
				211,
				93,
				15,
				0,
				111,
				157,
				54,
				66,
				74,
				94,
				193,
				224
			},
			{
				117,
				243,
				198,
				244,
				219,
				123,
				251,
				200,
				74,
				211,
				230,
				107,
				69,
				125,
				232,
				75,
				214,
				50,
				216,
				253,
				55,
				113,
				241,
				225,
				48,
				15,
				248,
				27,
				135,
				250,
				6,
				63,
				94,
				186,
				174,
				91,
				138,
				0,
				188,
				157,
				109,
				193,
				177,
				14,
				128,
				93,
				210,
				213,
				160,
				132,
				7,
				20,
				181,
				144,
				44,
				163,
				178,
				115,
				76,
				84,
				146,
				116,
				54,
				81,
				56,
				176,
				189,
				90,
				252,
				96,
				98,
				150,
				108,
				66,
				247,
				16,
				124,
				40,
				39,
				140,
				19,
				149,
				156,
				199,
				36,
				70,
				59,
				112,
				202,
				227,
				133,
				203,
				17,
				208,
				147,
				184,
				166,
				131,
				32,
				byte.MaxValue,
				159,
				119,
				195,
				204,
				3,
				111,
				8,
				191,
				64,
				231,
				43,
				226,
				121,
				12,
				170,
				130,
				65,
				58,
				234,
				185,
				228,
				154,
				164,
				151,
				126,
				218,
				122,
				23,
				102,
				148,
				161,
				29,
				61,
				240,
				222,
				179,
				11,
				114,
				167,
				28,
				239,
				209,
				83,
				62,
				143,
				51,
				38,
				95,
				236,
				118,
				42,
				73,
				129,
				136,
				238,
				33,
				196,
				26,
				235,
				217,
				197,
				57,
				153,
				205,
				173,
				49,
				139,
				1,
				24,
				35,
				221,
				31,
				78,
				45,
				249,
				72,
				79,
				242,
				101,
				142,
				120,
				92,
				88,
				25,
				141,
				229,
				152,
				87,
				103,
				127,
				5,
				100,
				175,
				99,
				182,
				254,
				245,
				183,
				60,
				165,
				206,
				233,
				104,
				68,
				224,
				77,
				67,
				105,
				41,
				46,
				172,
				21,
				89,
				168,
				10,
				158,
				110,
				71,
				223,
				52,
				53,
				106,
				207,
				220,
				34,
				201,
				192,
				155,
				137,
				212,
				237,
				171,
				18,
				162,
				13,
				82,
				187,
				2,
				47,
				169,
				215,
				97,
				30,
				180,
				80,
				4,
				246,
				194,
				22,
				37,
				134,
				86,
				85,
				9,
				190,
				145
			}
		};

		// Token: 0x0400140A RID: 5130
		private const int P_00 = 1;

		// Token: 0x0400140B RID: 5131
		private const int P_01 = 0;

		// Token: 0x0400140C RID: 5132
		private const int P_02 = 0;

		// Token: 0x0400140D RID: 5133
		private const int P_03 = 1;

		// Token: 0x0400140E RID: 5134
		private const int P_04 = 1;

		// Token: 0x0400140F RID: 5135
		private const int P_10 = 0;

		// Token: 0x04001410 RID: 5136
		private const int P_11 = 0;

		// Token: 0x04001411 RID: 5137
		private const int P_12 = 1;

		// Token: 0x04001412 RID: 5138
		private const int P_13 = 1;

		// Token: 0x04001413 RID: 5139
		private const int P_14 = 0;

		// Token: 0x04001414 RID: 5140
		private const int P_20 = 1;

		// Token: 0x04001415 RID: 5141
		private const int P_21 = 1;

		// Token: 0x04001416 RID: 5142
		private const int P_22 = 0;

		// Token: 0x04001417 RID: 5143
		private const int P_23 = 0;

		// Token: 0x04001418 RID: 5144
		private const int P_24 = 0;

		// Token: 0x04001419 RID: 5145
		private const int P_30 = 0;

		// Token: 0x0400141A RID: 5146
		private const int P_31 = 1;

		// Token: 0x0400141B RID: 5147
		private const int P_32 = 1;

		// Token: 0x0400141C RID: 5148
		private const int P_33 = 0;

		// Token: 0x0400141D RID: 5149
		private const int P_34 = 1;

		// Token: 0x0400141E RID: 5150
		private const int GF256_FDBK = 361;

		// Token: 0x0400141F RID: 5151
		private const int GF256_FDBK_2 = 180;

		// Token: 0x04001420 RID: 5152
		private const int GF256_FDBK_4 = 90;

		// Token: 0x04001421 RID: 5153
		private const int RS_GF_FDBK = 333;

		// Token: 0x04001422 RID: 5154
		private const int ROUNDS = 16;

		// Token: 0x04001423 RID: 5155
		private const int MAX_ROUNDS = 16;

		// Token: 0x04001424 RID: 5156
		private const int BLOCK_SIZE = 16;

		// Token: 0x04001425 RID: 5157
		private const int MAX_KEY_BITS = 256;

		// Token: 0x04001426 RID: 5158
		private const int INPUT_WHITEN = 0;

		// Token: 0x04001427 RID: 5159
		private const int OUTPUT_WHITEN = 4;

		// Token: 0x04001428 RID: 5160
		private const int ROUND_SUBKEYS = 8;

		// Token: 0x04001429 RID: 5161
		private const int TOTAL_SUBKEYS = 40;

		// Token: 0x0400142A RID: 5162
		private const int SK_STEP = 33686018;

		// Token: 0x0400142B RID: 5163
		private const int SK_BUMP = 16843009;

		// Token: 0x0400142C RID: 5164
		private const int SK_ROTL = 9;

		// Token: 0x0400142D RID: 5165
		private bool encrypting;

		// Token: 0x0400142E RID: 5166
		private int[] gMDS0 = new int[256];

		// Token: 0x0400142F RID: 5167
		private int[] gMDS1 = new int[256];

		// Token: 0x04001430 RID: 5168
		private int[] gMDS2 = new int[256];

		// Token: 0x04001431 RID: 5169
		private int[] gMDS3 = new int[256];

		// Token: 0x04001432 RID: 5170
		private int[] gSubKeys;

		// Token: 0x04001433 RID: 5171
		private int[] gSBox;

		// Token: 0x04001434 RID: 5172
		private int k64Cnt;

		// Token: 0x04001435 RID: 5173
		private byte[] workingKey;
	}
}
