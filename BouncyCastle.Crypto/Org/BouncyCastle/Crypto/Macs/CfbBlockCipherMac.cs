using System;
using Org.BouncyCastle.Crypto.Paddings;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x0200044D RID: 1101
	public class CfbBlockCipherMac : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x06002AA2 RID: 10914 RVA: 0x000B67F0 File Offset: 0x000B49F0
		public CfbBlockCipherMac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher) : this(cipher, 8, cipher.GetBlockSize() * 8 / 2, null)
		{
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x000B6805 File Offset: 0x000B4A05
		public CfbBlockCipherMac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding) : this(cipher, 8, cipher.GetBlockSize() * 8 / 2, padding)
		{
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x000B681A File Offset: 0x000B4A1A
		public CfbBlockCipherMac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int cfbBitSize, int macSizeInBits) : this(cipher, cfbBitSize, macSizeInBits, null)
		{
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x000B6828 File Offset: 0x000B4A28
		public CfbBlockCipherMac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int cfbBitSize, int macSizeInBits, global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding)
		{
			if (macSizeInBits % 8 != 0)
			{
				throw new global::System.ArgumentException("MAC size must be multiple of 8");
			}
			this.mac = new byte[cipher.GetBlockSize()];
			this.cipher = new global::Org.BouncyCastle.Crypto.Macs.MacCFBBlockCipher(cipher, cfbBitSize);
			this.padding = padding;
			this.macSize = macSizeInBits / 8;
			this.Buffer = new byte[this.cipher.GetBlockSize()];
			this.bufOff = 0;
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06002AA6 RID: 10918 RVA: 0x000B6897 File Offset: 0x000B4A97
		public string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName;
			}
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x000B68A4 File Offset: 0x000B4AA4
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.Reset();
			this.cipher.Init(true, parameters);
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x000B68B9 File Offset: 0x000B4AB9
		public int GetMacSize()
		{
			return this.macSize;
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x000B68C4 File Offset: 0x000B4AC4
		public void Update(byte input)
		{
			if (this.bufOff == this.Buffer.Length)
			{
				this.cipher.ProcessBlock(this.Buffer, 0, this.mac, 0);
				this.bufOff = 0;
			}
			byte[] buffer = this.Buffer;
			int num = this.bufOff;
			this.bufOff = num + 1;
			buffer[num] = input;
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x000B691C File Offset: 0x000B4B1C
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
			if (len < 0)
			{
				throw new global::System.ArgumentException("Can't have a negative input length!");
			}
			int blockSize = this.cipher.GetBlockSize();
			int resultLen = 0;
			int gapLen = blockSize - this.bufOff;
			if (len > gapLen)
			{
				global::System.Array.Copy(input, inOff, this.Buffer, this.bufOff, gapLen);
				resultLen += this.cipher.ProcessBlock(this.Buffer, 0, this.mac, 0);
				this.bufOff = 0;
				len -= gapLen;
				inOff += gapLen;
				while (len > blockSize)
				{
					resultLen += this.cipher.ProcessBlock(input, inOff, this.mac, 0);
					len -= blockSize;
					inOff += blockSize;
				}
			}
			global::System.Array.Copy(input, inOff, this.Buffer, this.bufOff, len);
			this.bufOff += len;
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x000B69E0 File Offset: 0x000B4BE0
		public int DoFinal(byte[] output, int outOff)
		{
			int blockSize = this.cipher.GetBlockSize();
			if (this.padding == null)
			{
				while (this.bufOff < blockSize)
				{
					byte[] buffer = this.Buffer;
					int num = this.bufOff;
					this.bufOff = num + 1;
					buffer[num] = 0;
				}
			}
			else
			{
				this.padding.AddPadding(this.Buffer, this.bufOff);
			}
			this.cipher.ProcessBlock(this.Buffer, 0, this.mac, 0);
			this.cipher.GetMacBlock(this.mac);
			global::System.Array.Copy(this.mac, 0, output, outOff, this.macSize);
			this.Reset();
			return this.macSize;
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x000B6A8A File Offset: 0x000B4C8A
		public void Reset()
		{
			global::System.Array.Clear(this.Buffer, 0, this.Buffer.Length);
			this.bufOff = 0;
			this.cipher.Reset();
		}

		// Token: 0x0400117B RID: 4475
		private byte[] mac;

		// Token: 0x0400117C RID: 4476
		private byte[] Buffer;

		// Token: 0x0400117D RID: 4477
		private int bufOff;

		// Token: 0x0400117E RID: 4478
		private global::Org.BouncyCastle.Crypto.Macs.MacCFBBlockCipher cipher;

		// Token: 0x0400117F RID: 4479
		private global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding;

		// Token: 0x04001180 RID: 4480
		private int macSize;
	}
}
