using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000491 RID: 1169
	public class CamelliaLightEngine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002CF3 RID: 11507 RVA: 0x000C61D4 File Offset: 0x000C43D4
		private static uint rightRotate(uint x, int s)
		{
			return (x >> s) + (x << 32 - s);
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x000C61E6 File Offset: 0x000C43E6
		private static uint leftRotate(uint x, int s)
		{
			return (x << s) + (x >> 32 - s);
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x000C61F8 File Offset: 0x000C43F8
		private static void roldq(int rot, uint[] ki, int ioff, uint[] ko, int ooff)
		{
			ko[ooff] = (ki[ioff] << rot | ki[1 + ioff] >> 32 - rot);
			ko[1 + ooff] = (ki[1 + ioff] << rot | ki[2 + ioff] >> 32 - rot);
			ko[2 + ooff] = (ki[2 + ioff] << rot | ki[3 + ioff] >> 32 - rot);
			ko[3 + ooff] = (ki[3 + ioff] << rot | ki[ioff] >> 32 - rot);
			ki[ioff] = ko[ooff];
			ki[1 + ioff] = ko[1 + ooff];
			ki[2 + ioff] = ko[2 + ooff];
			ki[3 + ioff] = ko[3 + ooff];
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x000C62A0 File Offset: 0x000C44A0
		private static void decroldq(int rot, uint[] ki, int ioff, uint[] ko, int ooff)
		{
			ko[2 + ooff] = (ki[ioff] << rot | ki[1 + ioff] >> 32 - rot);
			ko[3 + ooff] = (ki[1 + ioff] << rot | ki[2 + ioff] >> 32 - rot);
			ko[ooff] = (ki[2 + ioff] << rot | ki[3 + ioff] >> 32 - rot);
			ko[1 + ooff] = (ki[3 + ioff] << rot | ki[ioff] >> 32 - rot);
			ki[ioff] = ko[2 + ooff];
			ki[1 + ioff] = ko[3 + ooff];
			ki[2 + ioff] = ko[ooff];
			ki[3 + ioff] = ko[1 + ooff];
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x000C6348 File Offset: 0x000C4548
		private static void roldqo32(int rot, uint[] ki, int ioff, uint[] ko, int ooff)
		{
			ko[ooff] = (ki[1 + ioff] << rot - 32 | ki[2 + ioff] >> 64 - rot);
			ko[1 + ooff] = (ki[2 + ioff] << rot - 32 | ki[3 + ioff] >> 64 - rot);
			ko[2 + ooff] = (ki[3 + ioff] << rot - 32 | ki[ioff] >> 64 - rot);
			ko[3 + ooff] = (ki[ioff] << rot - 32 | ki[1 + ioff] >> 64 - rot);
			ki[ioff] = ko[ooff];
			ki[1 + ioff] = ko[1 + ooff];
			ki[2 + ioff] = ko[2 + ooff];
			ki[3 + ioff] = ko[3 + ooff];
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x000C63FC File Offset: 0x000C45FC
		private static void decroldqo32(int rot, uint[] ki, int ioff, uint[] ko, int ooff)
		{
			ko[2 + ooff] = (ki[1 + ioff] << rot - 32 | ki[2 + ioff] >> 64 - rot);
			ko[3 + ooff] = (ki[2 + ioff] << rot - 32 | ki[3 + ioff] >> 64 - rot);
			ko[ooff] = (ki[3 + ioff] << rot - 32 | ki[ioff] >> 64 - rot);
			ko[1 + ooff] = (ki[ioff] << rot - 32 | ki[1 + ioff] >> 64 - rot);
			ki[ioff] = ko[2 + ooff];
			ki[1 + ioff] = ko[3 + ooff];
			ki[2 + ioff] = ko[ooff];
			ki[3 + ioff] = ko[1 + ooff];
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x000C64B0 File Offset: 0x000C46B0
		private static uint bytes2uint(byte[] src, int offset)
		{
			uint word = 0U;
			for (int i = 0; i < 4; i++)
			{
				word = (word << 8) + (uint)src[i + offset];
			}
			return word;
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x000C64D8 File Offset: 0x000C46D8
		private static void uint2bytes(uint word, byte[] dst, int offset)
		{
			for (int i = 0; i < 4; i++)
			{
				dst[3 - i + offset] = (byte)word;
				word >>= 8;
			}
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x000C64FF File Offset: 0x000C46FF
		private byte lRot8(byte v, int rot)
		{
			return (byte)((int)v << rot | (int)((uint)v >> 8 - rot));
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x000C6511 File Offset: 0x000C4711
		private uint sbox2(int x)
		{
			return (uint)this.lRot8(global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.SBOX1[x], 1);
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x000C6521 File Offset: 0x000C4721
		private uint sbox3(int x)
		{
			return (uint)this.lRot8(global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.SBOX1[x], 7);
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x000C6531 File Offset: 0x000C4731
		private uint sbox4(int x)
		{
			return (uint)global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.SBOX1[(int)this.lRot8((byte)x, 1)];
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x000C6544 File Offset: 0x000C4744
		private void camelliaF2(uint[] s, uint[] skey, int keyoff)
		{
			uint t = s[0] ^ skey[keyoff];
			uint u = this.sbox4((int)((byte)t));
			u |= this.sbox3((int)((byte)(t >> 8))) << 8;
			u |= this.sbox2((int)((byte)(t >> 16))) << 16;
			u |= (uint)((uint)global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.SBOX1[(int)((byte)(t >> 24))] << 24);
			uint t2 = s[1] ^ skey[1 + keyoff];
			uint v = (uint)global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.SBOX1[(int)((byte)t2)];
			v |= this.sbox4((int)((byte)(t2 >> 8))) << 8;
			v |= this.sbox3((int)((byte)(t2 >> 16))) << 16;
			v |= this.sbox2((int)((byte)(t2 >> 24))) << 24;
			v = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.leftRotate(v, 8);
			u ^= v;
			v = (global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.leftRotate(v, 8) ^ u);
			u = (global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.rightRotate(u, 8) ^ v);
			s[2] ^= (global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.leftRotate(v, 16) ^ u);
			s[3] ^= global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.leftRotate(u, 8);
			t = (s[2] ^ skey[2 + keyoff]);
			u = this.sbox4((int)((byte)t));
			u |= this.sbox3((int)((byte)(t >> 8))) << 8;
			u |= this.sbox2((int)((byte)(t >> 16))) << 16;
			u |= (uint)((uint)global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.SBOX1[(int)((byte)(t >> 24))] << 24);
			t2 = (s[3] ^ skey[3 + keyoff]);
			v = (uint)global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.SBOX1[(int)((byte)t2)];
			v |= this.sbox4((int)((byte)(t2 >> 8))) << 8;
			v |= this.sbox3((int)((byte)(t2 >> 16))) << 16;
			v |= this.sbox2((int)((byte)(t2 >> 24))) << 24;
			v = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.leftRotate(v, 8);
			u ^= v;
			v = (global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.leftRotate(v, 8) ^ u);
			u = (global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.rightRotate(u, 8) ^ v);
			s[0] ^= (global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.leftRotate(v, 16) ^ u);
			s[1] ^= global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.leftRotate(u, 8);
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x000C66F0 File Offset: 0x000C48F0
		private void camelliaFLs(uint[] s, uint[] fkey, int keyoff)
		{
			s[1] ^= global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.leftRotate(s[0] & fkey[keyoff], 1);
			s[0] ^= (fkey[1 + keyoff] | s[1]);
			s[2] ^= (fkey[3 + keyoff] | s[3]);
			s[3] ^= global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.leftRotate(fkey[2 + keyoff] & s[2], 1);
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x000C6758 File Offset: 0x000C4958
		private void setKey(bool forEncryption, byte[] key)
		{
			uint[] i = new uint[8];
			uint[] ka = new uint[4];
			uint[] kb = new uint[4];
			uint[] t = new uint[4];
			int num = key.Length;
			if (num != 16)
			{
				if (num != 24)
				{
					if (num != 32)
					{
						throw new global::System.ArgumentException("key sizes are only 16/24/32 bytes.");
					}
					i[0] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 0);
					i[1] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 4);
					i[2] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 8);
					i[3] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 12);
					i[4] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 16);
					i[5] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 20);
					i[6] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 24);
					i[7] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 28);
					this._keyis128 = false;
				}
				else
				{
					i[0] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 0);
					i[1] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 4);
					i[2] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 8);
					i[3] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 12);
					i[4] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 16);
					i[5] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 20);
					i[6] = ~i[4];
					i[7] = ~i[5];
					this._keyis128 = false;
				}
			}
			else
			{
				this._keyis128 = true;
				i[0] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 0);
				i[1] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 4);
				i[2] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 8);
				i[3] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(key, 12);
				i[4] = (i[5] = (i[6] = (i[7] = 0U)));
			}
			for (int j = 0; j < 4; j++)
			{
				ka[j] = (i[j] ^ i[j + 4]);
			}
			this.camelliaF2(ka, global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.SIGMA, 0);
			for (int k = 0; k < 4; k++)
			{
				ka[k] ^= i[k];
			}
			this.camelliaF2(ka, global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.SIGMA, 4);
			if (this._keyis128)
			{
				if (forEncryption)
				{
					this.kw[0] = i[0];
					this.kw[1] = i[1];
					this.kw[2] = i[2];
					this.kw[3] = i[3];
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(15, i, 0, this.subkey, 4);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(30, i, 0, this.subkey, 12);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(15, i, 0, t, 0);
					this.subkey[18] = t[2];
					this.subkey[19] = t[3];
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(17, i, 0, this.ke, 4);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(17, i, 0, this.subkey, 24);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(17, i, 0, this.subkey, 32);
					this.subkey[0] = ka[0];
					this.subkey[1] = ka[1];
					this.subkey[2] = ka[2];
					this.subkey[3] = ka[3];
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(15, ka, 0, this.subkey, 8);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(15, ka, 0, this.ke, 0);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(15, ka, 0, t, 0);
					this.subkey[16] = t[0];
					this.subkey[17] = t[1];
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(15, ka, 0, this.subkey, 20);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldqo32(34, ka, 0, this.subkey, 28);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(17, ka, 0, this.kw, 4);
					return;
				}
				this.kw[4] = i[0];
				this.kw[5] = i[1];
				this.kw[6] = i[2];
				this.kw[7] = i[3];
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(15, i, 0, this.subkey, 28);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(30, i, 0, this.subkey, 20);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(15, i, 0, t, 0);
				this.subkey[16] = t[0];
				this.subkey[17] = t[1];
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(17, i, 0, this.ke, 0);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(17, i, 0, this.subkey, 8);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(17, i, 0, this.subkey, 0);
				this.subkey[34] = ka[0];
				this.subkey[35] = ka[1];
				this.subkey[32] = ka[2];
				this.subkey[33] = ka[3];
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(15, ka, 0, this.subkey, 24);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(15, ka, 0, this.ke, 4);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(15, ka, 0, t, 0);
				this.subkey[18] = t[2];
				this.subkey[19] = t[3];
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(15, ka, 0, this.subkey, 12);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldqo32(34, ka, 0, this.subkey, 4);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(17, ka, 0, this.kw, 0);
				return;
			}
			else
			{
				for (int l = 0; l < 4; l++)
				{
					kb[l] = (ka[l] ^ i[l + 4]);
				}
				this.camelliaF2(kb, global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.SIGMA, 8);
				if (forEncryption)
				{
					this.kw[0] = i[0];
					this.kw[1] = i[1];
					this.kw[2] = i[2];
					this.kw[3] = i[3];
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldqo32(45, i, 0, this.subkey, 16);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(15, i, 0, this.ke, 4);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(17, i, 0, this.subkey, 32);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldqo32(34, i, 0, this.subkey, 44);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(15, i, 4, this.subkey, 4);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(15, i, 4, this.ke, 0);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(30, i, 4, this.subkey, 24);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldqo32(34, i, 4, this.subkey, 36);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(15, ka, 0, this.subkey, 8);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(30, ka, 0, this.subkey, 20);
					this.ke[8] = ka[1];
					this.ke[9] = ka[2];
					this.ke[10] = ka[3];
					this.ke[11] = ka[0];
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldqo32(49, ka, 0, this.subkey, 40);
					this.subkey[0] = kb[0];
					this.subkey[1] = kb[1];
					this.subkey[2] = kb[2];
					this.subkey[3] = kb[3];
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(30, kb, 0, this.subkey, 12);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldq(30, kb, 0, this.subkey, 28);
					global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldqo32(51, kb, 0, this.kw, 4);
					return;
				}
				this.kw[4] = i[0];
				this.kw[5] = i[1];
				this.kw[6] = i[2];
				this.kw[7] = i[3];
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldqo32(45, i, 0, this.subkey, 28);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(15, i, 0, this.ke, 4);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(17, i, 0, this.subkey, 12);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldqo32(34, i, 0, this.subkey, 0);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(15, i, 4, this.subkey, 40);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(15, i, 4, this.ke, 8);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(30, i, 4, this.subkey, 20);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldqo32(34, i, 4, this.subkey, 8);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(15, ka, 0, this.subkey, 36);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(30, ka, 0, this.subkey, 24);
				this.ke[2] = ka[1];
				this.ke[3] = ka[2];
				this.ke[0] = ka[3];
				this.ke[1] = ka[0];
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldqo32(49, ka, 0, this.subkey, 4);
				this.subkey[46] = kb[0];
				this.subkey[47] = kb[1];
				this.subkey[44] = kb[2];
				this.subkey[45] = kb[3];
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(30, kb, 0, this.subkey, 32);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.decroldq(30, kb, 0, this.subkey, 16);
				global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.roldqo32(51, kb, 0, this.kw, 0);
				return;
			}
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x000C6EB8 File Offset: 0x000C50B8
		private int processBlock128(byte[] input, int inOff, byte[] output, int outOff)
		{
			for (int i = 0; i < 4; i++)
			{
				this.state[i] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(input, inOff + i * 4);
				this.state[i] ^= this.kw[i];
			}
			this.camelliaF2(this.state, this.subkey, 0);
			this.camelliaF2(this.state, this.subkey, 4);
			this.camelliaF2(this.state, this.subkey, 8);
			this.camelliaFLs(this.state, this.ke, 0);
			this.camelliaF2(this.state, this.subkey, 12);
			this.camelliaF2(this.state, this.subkey, 16);
			this.camelliaF2(this.state, this.subkey, 20);
			this.camelliaFLs(this.state, this.ke, 4);
			this.camelliaF2(this.state, this.subkey, 24);
			this.camelliaF2(this.state, this.subkey, 28);
			this.camelliaF2(this.state, this.subkey, 32);
			this.state[2] ^= this.kw[4];
			this.state[3] ^= this.kw[5];
			this.state[0] ^= this.kw[6];
			this.state[1] ^= this.kw[7];
			global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.uint2bytes(this.state[2], output, outOff);
			global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.uint2bytes(this.state[3], output, outOff + 4);
			global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.uint2bytes(this.state[0], output, outOff + 8);
			global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.uint2bytes(this.state[1], output, outOff + 12);
			return 16;
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x000C707C File Offset: 0x000C527C
		private int processBlock192or256(byte[] input, int inOff, byte[] output, int outOff)
		{
			for (int i = 0; i < 4; i++)
			{
				this.state[i] = global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.bytes2uint(input, inOff + i * 4);
				this.state[i] ^= this.kw[i];
			}
			this.camelliaF2(this.state, this.subkey, 0);
			this.camelliaF2(this.state, this.subkey, 4);
			this.camelliaF2(this.state, this.subkey, 8);
			this.camelliaFLs(this.state, this.ke, 0);
			this.camelliaF2(this.state, this.subkey, 12);
			this.camelliaF2(this.state, this.subkey, 16);
			this.camelliaF2(this.state, this.subkey, 20);
			this.camelliaFLs(this.state, this.ke, 4);
			this.camelliaF2(this.state, this.subkey, 24);
			this.camelliaF2(this.state, this.subkey, 28);
			this.camelliaF2(this.state, this.subkey, 32);
			this.camelliaFLs(this.state, this.ke, 8);
			this.camelliaF2(this.state, this.subkey, 36);
			this.camelliaF2(this.state, this.subkey, 40);
			this.camelliaF2(this.state, this.subkey, 44);
			this.state[2] ^= this.kw[4];
			this.state[3] ^= this.kw[5];
			this.state[0] ^= this.kw[6];
			this.state[1] ^= this.kw[7];
			global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.uint2bytes(this.state[2], output, outOff);
			global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.uint2bytes(this.state[3], output, outOff + 4);
			global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.uint2bytes(this.state[0], output, outOff + 8);
			global::Org.BouncyCastle.Crypto.Engines.CamelliaLightEngine.uint2bytes(this.state[1], output, outOff + 12);
			return 16;
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x000C7290 File Offset: 0x000C5490
		public CamelliaLightEngine()
		{
			this.initialised = false;
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x000C72DC File Offset: 0x000C54DC
		public virtual string AlgorithmName
		{
			get
			{
				return "Camellia";
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x000C72E3 File Offset: 0x000C54E3
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x000C72E6 File Offset: 0x000C54E6
		public virtual int GetBlockSize()
		{
			return 16;
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x000C72EA File Offset: 0x000C54EA
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("only simple KeyParameter expected.");
			}
			this.setKey(forEncryption, ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey());
			this.initialised = true;
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x000C7318 File Offset: 0x000C5518
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (!this.initialised)
			{
				throw new global::System.InvalidOperationException("Camellia engine not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, 16, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, 16, "output buffer too short");
			if (this._keyis128)
			{
				return this.processBlock128(input, inOff, output, outOff);
			}
			return this.processBlock192or256(input, inOff, output, outOff);
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x000C7374 File Offset: 0x000C5574
		public virtual void Reset()
		{
		}

		// Token: 0x040012D5 RID: 4821
		private const int BLOCK_SIZE = 16;

		// Token: 0x040012D6 RID: 4822
		private bool initialised;

		// Token: 0x040012D7 RID: 4823
		private bool _keyis128;

		// Token: 0x040012D8 RID: 4824
		private uint[] subkey = new uint[96];

		// Token: 0x040012D9 RID: 4825
		private uint[] kw = new uint[8];

		// Token: 0x040012DA RID: 4826
		private uint[] ke = new uint[12];

		// Token: 0x040012DB RID: 4827
		private uint[] state = new uint[4];

		// Token: 0x040012DC RID: 4828
		private static readonly uint[] SIGMA = new uint[]
		{
			2694735487U,
			1003262091U,
			3061508184U,
			1286239154U,
			3337565999U,
			3914302142U,
			1426019237U,
			4057165596U,
			283453434U,
			3731369245U,
			2958461122U,
			3018244605U
		};

		// Token: 0x040012DD RID: 4829
		private static readonly byte[] SBOX1 = new byte[]
		{
			112,
			130,
			44,
			236,
			179,
			39,
			192,
			229,
			228,
			133,
			87,
			53,
			234,
			12,
			174,
			65,
			35,
			239,
			107,
			147,
			69,
			25,
			165,
			33,
			237,
			14,
			79,
			78,
			29,
			101,
			146,
			189,
			134,
			184,
			175,
			143,
			124,
			235,
			31,
			206,
			62,
			48,
			220,
			95,
			94,
			197,
			11,
			26,
			166,
			225,
			57,
			202,
			213,
			71,
			93,
			61,
			217,
			1,
			90,
			214,
			81,
			86,
			108,
			77,
			139,
			13,
			154,
			102,
			251,
			204,
			176,
			45,
			116,
			18,
			43,
			32,
			240,
			177,
			132,
			153,
			223,
			76,
			203,
			194,
			52,
			126,
			118,
			5,
			109,
			183,
			169,
			49,
			209,
			23,
			4,
			215,
			20,
			88,
			58,
			97,
			222,
			27,
			17,
			28,
			50,
			15,
			156,
			22,
			83,
			24,
			242,
			34,
			254,
			68,
			207,
			178,
			195,
			181,
			122,
			145,
			36,
			8,
			232,
			168,
			96,
			252,
			105,
			80,
			170,
			208,
			160,
			125,
			161,
			137,
			98,
			151,
			84,
			91,
			30,
			149,
			224,
			byte.MaxValue,
			100,
			210,
			16,
			196,
			0,
			72,
			163,
			247,
			117,
			219,
			138,
			3,
			230,
			218,
			9,
			63,
			221,
			148,
			135,
			92,
			131,
			2,
			205,
			74,
			144,
			51,
			115,
			103,
			246,
			243,
			157,
			127,
			191,
			226,
			82,
			155,
			216,
			38,
			200,
			55,
			198,
			59,
			129,
			150,
			111,
			75,
			19,
			190,
			99,
			46,
			233,
			121,
			167,
			140,
			159,
			110,
			188,
			142,
			41,
			245,
			249,
			182,
			47,
			253,
			180,
			89,
			120,
			152,
			6,
			106,
			231,
			70,
			113,
			186,
			212,
			37,
			171,
			66,
			136,
			162,
			141,
			250,
			114,
			7,
			185,
			85,
			248,
			238,
			172,
			10,
			54,
			73,
			42,
			104,
			60,
			56,
			241,
			164,
			64,
			40,
			211,
			123,
			187,
			201,
			67,
			193,
			21,
			227,
			173,
			244,
			119,
			199,
			128,
			158
		};
	}
}
