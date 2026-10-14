using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200048C RID: 1164
	public class AesLightEngine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002CAA RID: 11434 RVA: 0x000C2EE0 File Offset: 0x000C10E0
		private static uint Shift(uint r, int shift)
		{
			return r >> shift | r << 32 - shift;
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x000C2EF2 File Offset: 0x000C10F2
		private static uint FFmulX(uint x)
		{
			return (x & 2139062143U) << 1 ^ ((x & 2155905152U) >> 7) * 27U;
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x000C2F0C File Offset: 0x000C110C
		private static uint FFmulX2(uint x)
		{
			uint num = (x & 1061109567U) << 2;
			uint t = x & 3233857728U;
			t ^= t >> 1;
			return num ^ t >> 2 ^ t >> 5;
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x000C2F38 File Offset: 0x000C1138
		private static uint Mcol(uint x)
		{
			uint t0 = global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Shift(x, 8);
			uint t = x ^ t0;
			return global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Shift(t, 16) ^ t0 ^ global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.FFmulX(t);
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x000C2F64 File Offset: 0x000C1164
		private static uint Inv_Mcol(uint x)
		{
			uint t = x ^ global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Shift(x, 8);
			uint t2 = x ^ global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.FFmulX(t);
			t ^= global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.FFmulX2(t2);
			return t2 ^ (t ^ global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Shift(t, 16));
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x000C2FA0 File Offset: 0x000C11A0
		private static uint SubWord(uint x)
		{
			return (uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(x & 255U)] | (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(x >> 8 & 255U)] << 8 | (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(x >> 16 & 255U)] << 16 | (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(x >> 24 & 255U)] << 24);
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x000C2FF4 File Offset: 0x000C11F4
		private uint[][] GenerateWorkingKey(byte[] key, bool forEncryption)
		{
			int keyLen = key.Length;
			if (keyLen < 16 || keyLen > 32 || (keyLen & 7) != 0)
			{
				throw new global::System.ArgumentException("Key length not 128/192/256 bits.");
			}
			int KC = keyLen >> 2;
			this.ROUNDS = KC + 6;
			uint[][] W = new uint[this.ROUNDS + 1][];
			for (int i = 0; i <= this.ROUNDS; i++)
			{
				W[i] = new uint[4];
			}
			switch (KC)
			{
			case 4:
			{
				uint t0 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 0);
				W[0][0] = t0;
				uint t = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 4);
				W[0][1] = t;
				uint t2 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 8);
				W[0][2] = t2;
				uint t3 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 12);
				W[0][3] = t3;
				for (int j = 1; j <= 10; j++)
				{
					uint u = global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.SubWord(global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Shift(t3, 8)) ^ (uint)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.rcon[j - 1];
					t0 ^= u;
					W[j][0] = t0;
					t ^= t0;
					W[j][1] = t;
					t2 ^= t;
					W[j][2] = t2;
					t3 ^= t2;
					W[j][3] = t3;
				}
				goto IL_4EC;
			}
			case 6:
			{
				uint t4 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 0);
				W[0][0] = t4;
				uint t5 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 4);
				W[0][1] = t5;
				uint t6 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 8);
				W[0][2] = t6;
				uint t7 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 12);
				W[0][3] = t7;
				uint t8 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 16);
				W[1][0] = t8;
				uint t9 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 20);
				W[1][1] = t9;
				uint rcon = 1U;
				uint u2 = global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.SubWord(global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Shift(t9, 8)) ^ rcon;
				rcon <<= 1;
				t4 ^= u2;
				W[1][2] = t4;
				t5 ^= t4;
				W[1][3] = t5;
				t6 ^= t5;
				W[2][0] = t6;
				t7 ^= t6;
				W[2][1] = t7;
				t8 ^= t7;
				W[2][2] = t8;
				t9 ^= t8;
				W[2][3] = t9;
				for (int k = 3; k < 12; k += 3)
				{
					u2 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.SubWord(global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Shift(t9, 8)) ^ rcon);
					rcon <<= 1;
					t4 ^= u2;
					W[k][0] = t4;
					t5 ^= t4;
					W[k][1] = t5;
					t6 ^= t5;
					W[k][2] = t6;
					t7 ^= t6;
					W[k][3] = t7;
					t8 ^= t7;
					W[k + 1][0] = t8;
					t9 ^= t8;
					W[k + 1][1] = t9;
					u2 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.SubWord(global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Shift(t9, 8)) ^ rcon);
					rcon <<= 1;
					t4 ^= u2;
					W[k + 1][2] = t4;
					t5 ^= t4;
					W[k + 1][3] = t5;
					t6 ^= t5;
					W[k + 2][0] = t6;
					t7 ^= t6;
					W[k + 2][1] = t7;
					t8 ^= t7;
					W[k + 2][2] = t8;
					t9 ^= t8;
					W[k + 2][3] = t9;
				}
				u2 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.SubWord(global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Shift(t9, 8)) ^ rcon);
				t4 ^= u2;
				W[12][0] = t4;
				t5 ^= t4;
				W[12][1] = t5;
				t6 ^= t5;
				W[12][2] = t6;
				t7 ^= t6;
				W[12][3] = t7;
				goto IL_4EC;
			}
			case 8:
			{
				uint t10 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 0);
				W[0][0] = t10;
				uint t11 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 4);
				W[0][1] = t11;
				uint t12 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 8);
				W[0][2] = t12;
				uint t13 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 12);
				W[0][3] = t13;
				uint t14 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 16);
				W[1][0] = t14;
				uint t15 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 20);
				W[1][1] = t15;
				uint t16 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 24);
				W[1][2] = t16;
				uint t17 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 28);
				W[1][3] = t17;
				uint rcon2 = 1U;
				uint u3;
				for (int l = 2; l < 14; l += 2)
				{
					u3 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.SubWord(global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Shift(t17, 8)) ^ rcon2);
					rcon2 <<= 1;
					t10 ^= u3;
					W[l][0] = t10;
					t11 ^= t10;
					W[l][1] = t11;
					t12 ^= t11;
					W[l][2] = t12;
					t13 ^= t12;
					W[l][3] = t13;
					u3 = global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.SubWord(t13);
					t14 ^= u3;
					W[l + 1][0] = t14;
					t15 ^= t14;
					W[l + 1][1] = t15;
					t16 ^= t15;
					W[l + 1][2] = t16;
					t17 ^= t16;
					W[l + 1][3] = t17;
				}
				u3 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.SubWord(global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Shift(t17, 8)) ^ rcon2);
				t10 ^= u3;
				W[14][0] = t10;
				t11 ^= t10;
				W[14][1] = t11;
				t12 ^= t11;
				W[14][2] = t12;
				t13 ^= t12;
				W[14][3] = t13;
				goto IL_4EC;
			}
			}
			throw new global::System.InvalidOperationException("Should never get here");
			IL_4EC:
			if (!forEncryption)
			{
				for (int m = 1; m < this.ROUNDS; m++)
				{
					uint[] w = W[m];
					for (int n = 0; n < 4; n++)
					{
						w[n] = global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Inv_Mcol(w[n]);
					}
				}
			}
			return W;
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x000C3534 File Offset: 0x000C1734
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter keyParameter = parameters as global::Org.BouncyCastle.Crypto.Parameters.KeyParameter;
			if (keyParameter == null)
			{
				throw new global::System.ArgumentException("invalid parameter passed to AES init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
			}
			this.WorkingKey = this.GenerateWorkingKey(keyParameter.GetKey(), forEncryption);
			this.forEncryption = forEncryption;
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x000C357B File Offset: 0x000C177B
		public virtual string AlgorithmName
		{
			get
			{
				return "AES";
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x000C3582 File Offset: 0x000C1782
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x000C3585 File Offset: 0x000C1785
		public virtual int GetBlockSize()
		{
			return 16;
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x000C358C File Offset: 0x000C178C
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (this.WorkingKey == null)
			{
				throw new global::System.InvalidOperationException("AES engine not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, 16, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, 16, "output buffer too short");
			if (this.forEncryption)
			{
				this.EncryptBlock(input, inOff, output, outOff, this.WorkingKey);
			}
			else
			{
				this.DecryptBlock(input, inOff, output, outOff, this.WorkingKey);
			}
			return 16;
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x000C35F7 File Offset: 0x000C17F7
		public virtual void Reset()
		{
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x000C35FC File Offset: 0x000C17FC
		private void EncryptBlock(byte[] input, int inOff, byte[] output, int outOff, uint[][] KW)
		{
			uint C0 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(input, inOff);
			uint C = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(input, inOff + 4);
			uint C2 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(input, inOff + 8);
			uint num = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(input, inOff + 12);
			uint[] kw = KW[0];
			uint t0 = C0 ^ kw[0];
			uint t = C ^ kw[1];
			uint t2 = C2 ^ kw[2];
			uint r3 = num ^ kw[3];
			int r4 = 1;
			uint r5;
			uint r6;
			uint r7;
			while (r4 < this.ROUNDS - 1)
			{
				kw = KW[r4++];
				r5 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t0 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t2 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 >> 24 & 255U)] << 24)) ^ kw[0]);
				r6 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t2 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t0 >> 24 & 255U)] << 24)) ^ kw[1]);
				r7 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t2 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t0 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t >> 24 & 255U)] << 24)) ^ kw[2]);
				r3 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t0 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t2 >> 24 & 255U)] << 24)) ^ kw[3]);
				kw = KW[r4++];
				t0 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r5 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r6 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r7 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 >> 24 & 255U)] << 24)) ^ kw[0]);
				t = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r6 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r7 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r5 >> 24 & 255U)] << 24)) ^ kw[1]);
				t2 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r7 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r5 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r6 >> 24 & 255U)] << 24)) ^ kw[2]);
				r3 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r5 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r6 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r7 >> 24 & 255U)] << 24)) ^ kw[3]);
			}
			kw = KW[r4++];
			r5 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t0 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t2 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 >> 24 & 255U)] << 24)) ^ kw[0]);
			r6 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t2 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t0 >> 24 & 255U)] << 24)) ^ kw[1]);
			r7 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t2 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t0 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t >> 24 & 255U)] << 24)) ^ kw[2]);
			r3 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t0 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(t2 >> 24 & 255U)] << 24)) ^ kw[3]);
			kw = KW[r4];
			C0 = (uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r5 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r6 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r7 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 >> 24 & 255U)] << 24 ^ (int)kw[0]);
			C = (uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r6 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r7 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r5 >> 24 & 255U)] << 24 ^ (int)kw[1]);
			C2 = (uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r7 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r5 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r6 >> 24 & 255U)] << 24 ^ (int)kw[2]);
			uint n = (uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r3 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r5 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r6 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.S[(int)(r7 >> 24 & 255U)] << 24 ^ (int)kw[3]);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(C0, output, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(C, output, outOff + 4);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(C2, output, outOff + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n, output, outOff + 12);
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x000C3C00 File Offset: 0x000C1E00
		private void DecryptBlock(byte[] input, int inOff, byte[] output, int outOff, uint[][] KW)
		{
			uint C0 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(input, inOff);
			uint C = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(input, inOff + 4);
			uint C2 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(input, inOff + 8);
			uint num = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(input, inOff + 12);
			uint[] kw = KW[this.ROUNDS];
			uint t0 = C0 ^ kw[0];
			uint t = C ^ kw[1];
			uint t2 = C2 ^ kw[2];
			uint r3 = num ^ kw[3];
			int r4 = this.ROUNDS - 1;
			uint r5;
			uint r6;
			uint r7;
			while (r4 > 1)
			{
				kw = KW[r4--];
				r5 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Inv_Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t0 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t2 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t >> 24 & 255U)] << 24)) ^ kw[0]);
				r6 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Inv_Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t0 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t2 >> 24 & 255U)] << 24)) ^ kw[1]);
				r7 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Inv_Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t2 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t0 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 >> 24 & 255U)] << 24)) ^ kw[2]);
				r3 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Inv_Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t2 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t0 >> 24 & 255U)] << 24)) ^ kw[3]);
				kw = KW[r4--];
				t0 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Inv_Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r5 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r7 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r6 >> 24 & 255U)] << 24)) ^ kw[0]);
				t = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Inv_Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r6 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r5 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r7 >> 24 & 255U)] << 24)) ^ kw[1]);
				t2 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Inv_Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r7 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r6 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r5 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 >> 24 & 255U)] << 24)) ^ kw[2]);
				r3 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Inv_Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r7 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r6 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r5 >> 24 & 255U)] << 24)) ^ kw[3]);
			}
			kw = KW[1];
			r5 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Inv_Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t0 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t2 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t >> 24 & 255U)] << 24)) ^ kw[0]);
			r6 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Inv_Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t0 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t2 >> 24 & 255U)] << 24)) ^ kw[1]);
			r7 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Inv_Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t2 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t0 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 >> 24 & 255U)] << 24)) ^ kw[2]);
			r3 = (global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Inv_Mcol((uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t2 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(t0 >> 24 & 255U)] << 24)) ^ kw[3]);
			kw = KW[0];
			C0 = (uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r5 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r7 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r6 >> 24 & 255U)] << 24 ^ (int)kw[0]);
			C = (uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r6 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r5 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r7 >> 24 & 255U)] << 24 ^ (int)kw[1]);
			C2 = (uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r7 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r6 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r5 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 >> 24 & 255U)] << 24 ^ (int)kw[2]);
			uint n = (uint)((int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r3 & 255U)] ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r7 >> 8 & 255U)] << 8 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r6 >> 16 & 255U)] << 16 ^ (int)global::Org.BouncyCastle.Crypto.Engines.AesLightEngine.Si[(int)(r5 >> 24 & 255U)] << 24 ^ (int)kw[3]);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(C0, output, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(C, output, outOff + 4);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(C2, output, outOff + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n, output, outOff + 12);
		}

		// Token: 0x040012A6 RID: 4774
		private static readonly byte[] S = new byte[]
		{
			99,
			124,
			119,
			123,
			242,
			107,
			111,
			197,
			48,
			1,
			103,
			43,
			254,
			215,
			171,
			118,
			202,
			130,
			201,
			125,
			250,
			89,
			71,
			240,
			173,
			212,
			162,
			175,
			156,
			164,
			114,
			192,
			183,
			253,
			147,
			38,
			54,
			63,
			247,
			204,
			52,
			165,
			229,
			241,
			113,
			216,
			49,
			21,
			4,
			199,
			35,
			195,
			24,
			150,
			5,
			154,
			7,
			18,
			128,
			226,
			235,
			39,
			178,
			117,
			9,
			131,
			44,
			26,
			27,
			110,
			90,
			160,
			82,
			59,
			214,
			179,
			41,
			227,
			47,
			132,
			83,
			209,
			0,
			237,
			32,
			252,
			177,
			91,
			106,
			203,
			190,
			57,
			74,
			76,
			88,
			207,
			208,
			239,
			170,
			251,
			67,
			77,
			51,
			133,
			69,
			249,
			2,
			127,
			80,
			60,
			159,
			168,
			81,
			163,
			64,
			143,
			146,
			157,
			56,
			245,
			188,
			182,
			218,
			33,
			16,
			byte.MaxValue,
			243,
			210,
			205,
			12,
			19,
			236,
			95,
			151,
			68,
			23,
			196,
			167,
			126,
			61,
			100,
			93,
			25,
			115,
			96,
			129,
			79,
			220,
			34,
			42,
			144,
			136,
			70,
			238,
			184,
			20,
			222,
			94,
			11,
			219,
			224,
			50,
			58,
			10,
			73,
			6,
			36,
			92,
			194,
			211,
			172,
			98,
			145,
			149,
			228,
			121,
			231,
			200,
			55,
			109,
			141,
			213,
			78,
			169,
			108,
			86,
			244,
			234,
			101,
			122,
			174,
			8,
			186,
			120,
			37,
			46,
			28,
			166,
			180,
			198,
			232,
			221,
			116,
			31,
			75,
			189,
			139,
			138,
			112,
			62,
			181,
			102,
			72,
			3,
			246,
			14,
			97,
			53,
			87,
			185,
			134,
			193,
			29,
			158,
			225,
			248,
			152,
			17,
			105,
			217,
			142,
			148,
			155,
			30,
			135,
			233,
			206,
			85,
			40,
			223,
			140,
			161,
			137,
			13,
			191,
			230,
			66,
			104,
			65,
			153,
			45,
			15,
			176,
			84,
			187,
			22
		};

		// Token: 0x040012A7 RID: 4775
		private static readonly byte[] Si = new byte[]
		{
			82,
			9,
			106,
			213,
			48,
			54,
			165,
			56,
			191,
			64,
			163,
			158,
			129,
			243,
			215,
			251,
			124,
			227,
			57,
			130,
			155,
			47,
			byte.MaxValue,
			135,
			52,
			142,
			67,
			68,
			196,
			222,
			233,
			203,
			84,
			123,
			148,
			50,
			166,
			194,
			35,
			61,
			238,
			76,
			149,
			11,
			66,
			250,
			195,
			78,
			8,
			46,
			161,
			102,
			40,
			217,
			36,
			178,
			118,
			91,
			162,
			73,
			109,
			139,
			209,
			37,
			114,
			248,
			246,
			100,
			134,
			104,
			152,
			22,
			212,
			164,
			92,
			204,
			93,
			101,
			182,
			146,
			108,
			112,
			72,
			80,
			253,
			237,
			185,
			218,
			94,
			21,
			70,
			87,
			167,
			141,
			157,
			132,
			144,
			216,
			171,
			0,
			140,
			188,
			211,
			10,
			247,
			228,
			88,
			5,
			184,
			179,
			69,
			6,
			208,
			44,
			30,
			143,
			202,
			63,
			15,
			2,
			193,
			175,
			189,
			3,
			1,
			19,
			138,
			107,
			58,
			145,
			17,
			65,
			79,
			103,
			220,
			234,
			151,
			242,
			207,
			206,
			240,
			180,
			230,
			115,
			150,
			172,
			116,
			34,
			231,
			173,
			53,
			133,
			226,
			249,
			55,
			232,
			28,
			117,
			223,
			110,
			71,
			241,
			26,
			113,
			29,
			41,
			197,
			137,
			111,
			183,
			98,
			14,
			170,
			24,
			190,
			27,
			252,
			86,
			62,
			75,
			198,
			210,
			121,
			32,
			154,
			219,
			192,
			254,
			120,
			205,
			90,
			244,
			31,
			221,
			168,
			51,
			136,
			7,
			199,
			49,
			177,
			18,
			16,
			89,
			39,
			128,
			236,
			95,
			96,
			81,
			127,
			169,
			25,
			181,
			74,
			13,
			45,
			229,
			122,
			159,
			147,
			201,
			156,
			239,
			160,
			224,
			59,
			77,
			174,
			42,
			245,
			176,
			200,
			235,
			187,
			60,
			131,
			83,
			153,
			97,
			23,
			43,
			4,
			126,
			186,
			119,
			214,
			38,
			225,
			105,
			20,
			99,
			85,
			33,
			12,
			125
		};

		// Token: 0x040012A8 RID: 4776
		private static readonly byte[] rcon = new byte[]
		{
			1,
			2,
			4,
			8,
			16,
			32,
			64,
			128,
			27,
			54,
			108,
			216,
			171,
			77,
			154,
			47,
			94,
			188,
			99,
			198,
			151,
			53,
			106,
			212,
			179,
			125,
			250,
			239,
			197,
			145
		};

		// Token: 0x040012A9 RID: 4777
		private const uint m1 = 2155905152U;

		// Token: 0x040012AA RID: 4778
		private const uint m2 = 2139062143U;

		// Token: 0x040012AB RID: 4779
		private const uint m3 = 27U;

		// Token: 0x040012AC RID: 4780
		private const uint m4 = 3233857728U;

		// Token: 0x040012AD RID: 4781
		private const uint m5 = 1061109567U;

		// Token: 0x040012AE RID: 4782
		private int ROUNDS;

		// Token: 0x040012AF RID: 4783
		private uint[][] WorkingKey;

		// Token: 0x040012B0 RID: 4784
		private bool forEncryption;

		// Token: 0x040012B1 RID: 4785
		private const int BLOCK_SIZE = 16;
	}
}
