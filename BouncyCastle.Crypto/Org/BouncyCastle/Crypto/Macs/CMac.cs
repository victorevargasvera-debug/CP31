using System;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x0200044E RID: 1102
	public class CMac : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x06002AAD RID: 10925 RVA: 0x000B6AB2 File Offset: 0x000B4CB2
		public CMac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher) : this(cipher, cipher.GetBlockSize() * 8)
		{
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x000B6AC4 File Offset: 0x000B4CC4
		public CMac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int macSizeInBits)
		{
			if (macSizeInBits % 8 != 0)
			{
				throw new global::System.ArgumentException("MAC size must be multiple of 8");
			}
			if (macSizeInBits > cipher.GetBlockSize() * 8)
			{
				throw new global::System.ArgumentException("MAC size must be less or equal to " + (cipher.GetBlockSize() * 8).ToString());
			}
			if (cipher.GetBlockSize() != 8 && cipher.GetBlockSize() != 16)
			{
				throw new global::System.ArgumentException("Block size must be either 64 or 128 bits");
			}
			this.cipher = new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(cipher);
			this.macSize = macSizeInBits / 8;
			this.mac = new byte[cipher.GetBlockSize()];
			this.buf = new byte[cipher.GetBlockSize()];
			this.ZEROES = new byte[cipher.GetBlockSize()];
			this.bufOff = 0;
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x000B6B7F File Offset: 0x000B4D7F
		public string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName;
			}
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x000B6B8C File Offset: 0x000B4D8C
		private static int ShiftLeft(byte[] block, byte[] output)
		{
			int i = block.Length;
			uint bit = 0U;
			while (--i >= 0)
			{
				uint b = (uint)block[i];
				output[i] = (byte)(b << 1 | bit);
				bit = (b >> 7 & 1U);
			}
			return (int)bit;
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x000B6BC0 File Offset: 0x000B4DC0
		private static byte[] DoubleLu(byte[] input)
		{
			byte[] ret = new byte[input.Length];
			int carry = global::Org.BouncyCastle.Crypto.Macs.CMac.ShiftLeft(input, ret);
			int xor = (input.Length == 16) ? 135 : 27;
			byte[] array = ret;
			int num = input.Length - 1;
			array[num] ^= (byte)(xor >> (1 - carry << 3));
			return ret;
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x000B6C0C File Offset: 0x000B4E0C
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)
			{
				this.cipher.Init(true, parameters);
				this.L = new byte[this.ZEROES.Length];
				this.cipher.ProcessBlock(this.ZEROES, 0, this.L, 0);
				this.Lu = global::Org.BouncyCastle.Crypto.Macs.CMac.DoubleLu(this.L);
				this.Lu2 = global::Org.BouncyCastle.Crypto.Macs.CMac.DoubleLu(this.Lu);
			}
			else if (parameters != null)
			{
				throw new global::System.ArgumentException("CMac mode only permits key to be set.", "parameters");
			}
			this.Reset();
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x000B6C98 File Offset: 0x000B4E98
		public int GetMacSize()
		{
			return this.macSize;
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x000B6CA0 File Offset: 0x000B4EA0
		public void Update(byte input)
		{
			if (this.bufOff == this.buf.Length)
			{
				this.cipher.ProcessBlock(this.buf, 0, this.mac, 0);
				this.bufOff = 0;
			}
			byte[] array = this.buf;
			int num = this.bufOff;
			this.bufOff = num + 1;
			array[num] = input;
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x000B6CF8 File Offset: 0x000B4EF8
		public void BlockUpdate(byte[] inBytes, int inOff, int len)
		{
			if (len < 0)
			{
				throw new global::System.ArgumentException("Can't have a negative input length!");
			}
			int blockSize = this.cipher.GetBlockSize();
			int gapLen = blockSize - this.bufOff;
			if (len > gapLen)
			{
				global::System.Array.Copy(inBytes, inOff, this.buf, this.bufOff, gapLen);
				this.cipher.ProcessBlock(this.buf, 0, this.mac, 0);
				this.bufOff = 0;
				len -= gapLen;
				inOff += gapLen;
				while (len > blockSize)
				{
					this.cipher.ProcessBlock(inBytes, inOff, this.mac, 0);
					len -= blockSize;
					inOff += blockSize;
				}
			}
			global::System.Array.Copy(inBytes, inOff, this.buf, this.bufOff, len);
			this.bufOff += len;
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x000B6DB4 File Offset: 0x000B4FB4
		public int DoFinal(byte[] outBytes, int outOff)
		{
			int blockSize = this.cipher.GetBlockSize();
			byte[] lu;
			if (this.bufOff == blockSize)
			{
				lu = this.Lu;
			}
			else
			{
				new global::Org.BouncyCastle.Crypto.Paddings.ISO7816d4Padding().AddPadding(this.buf, this.bufOff);
				lu = this.Lu2;
			}
			for (int i = 0; i < this.mac.Length; i++)
			{
				byte[] array = this.buf;
				int num = i;
				array[num] ^= lu[i];
			}
			this.cipher.ProcessBlock(this.buf, 0, this.mac, 0);
			global::System.Array.Copy(this.mac, 0, outBytes, outOff, this.macSize);
			this.Reset();
			return this.macSize;
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x000B6E5E File Offset: 0x000B505E
		public void Reset()
		{
			global::System.Array.Clear(this.buf, 0, this.buf.Length);
			this.bufOff = 0;
			this.cipher.Reset();
		}

		// Token: 0x04001181 RID: 4481
		private const byte CONSTANT_128 = 135;

		// Token: 0x04001182 RID: 4482
		private const byte CONSTANT_64 = 27;

		// Token: 0x04001183 RID: 4483
		private byte[] ZEROES;

		// Token: 0x04001184 RID: 4484
		private byte[] mac;

		// Token: 0x04001185 RID: 4485
		private byte[] buf;

		// Token: 0x04001186 RID: 4486
		private int bufOff;

		// Token: 0x04001187 RID: 4487
		private global::Org.BouncyCastle.Crypto.IBlockCipher cipher;

		// Token: 0x04001188 RID: 4488
		private int macSize;

		// Token: 0x04001189 RID: 4489
		private byte[] L;

		// Token: 0x0400118A RID: 4490
		private byte[] Lu;

		// Token: 0x0400118B RID: 4491
		private byte[] Lu2;
	}
}
