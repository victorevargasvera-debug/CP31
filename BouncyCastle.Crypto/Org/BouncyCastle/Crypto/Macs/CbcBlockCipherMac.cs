using System;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x0200044B RID: 1099
	public class CbcBlockCipherMac : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x06002A8F RID: 10895 RVA: 0x000B631A File Offset: 0x000B451A
		public CbcBlockCipherMac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher) : this(cipher, cipher.GetBlockSize() * 8 / 2, null)
		{
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x000B632E File Offset: 0x000B452E
		public CbcBlockCipherMac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding) : this(cipher, cipher.GetBlockSize() * 8 / 2, padding)
		{
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x000B6342 File Offset: 0x000B4542
		public CbcBlockCipherMac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int macSizeInBits) : this(cipher, macSizeInBits, null)
		{
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x000B6350 File Offset: 0x000B4550
		public CbcBlockCipherMac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int macSizeInBits, global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding)
		{
			if (macSizeInBits % 8 != 0)
			{
				throw new global::System.ArgumentException("MAC size must be multiple of 8");
			}
			this.cipher = new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(cipher);
			this.padding = padding;
			this.macSize = macSizeInBits / 8;
			this.buf = new byte[cipher.GetBlockSize()];
			this.bufOff = 0;
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x000B63A7 File Offset: 0x000B45A7
		public string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName;
			}
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x000B63B4 File Offset: 0x000B45B4
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.Reset();
			this.cipher.Init(true, parameters);
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x000B63C9 File Offset: 0x000B45C9
		public int GetMacSize()
		{
			return this.macSize;
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x000B63D4 File Offset: 0x000B45D4
		public void Update(byte input)
		{
			if (this.bufOff == this.buf.Length)
			{
				this.cipher.ProcessBlock(this.buf, 0, this.buf, 0);
				this.bufOff = 0;
			}
			byte[] array = this.buf;
			int num = this.bufOff;
			this.bufOff = num + 1;
			array[num] = input;
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x000B642C File Offset: 0x000B462C
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
			if (len < 0)
			{
				throw new global::System.ArgumentException("Can't have a negative input length!");
			}
			int blockSize = this.cipher.GetBlockSize();
			int gapLen = blockSize - this.bufOff;
			if (len > gapLen)
			{
				global::System.Array.Copy(input, inOff, this.buf, this.bufOff, gapLen);
				this.cipher.ProcessBlock(this.buf, 0, this.buf, 0);
				this.bufOff = 0;
				len -= gapLen;
				inOff += gapLen;
				while (len > blockSize)
				{
					this.cipher.ProcessBlock(input, inOff, this.buf, 0);
					len -= blockSize;
					inOff += blockSize;
				}
			}
			global::System.Array.Copy(input, inOff, this.buf, this.bufOff, len);
			this.bufOff += len;
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x000B64E8 File Offset: 0x000B46E8
		public int DoFinal(byte[] output, int outOff)
		{
			int blockSize = this.cipher.GetBlockSize();
			if (this.padding == null)
			{
				while (this.bufOff < blockSize)
				{
					byte[] array = this.buf;
					int num = this.bufOff;
					this.bufOff = num + 1;
					array[num] = 0;
				}
			}
			else
			{
				if (this.bufOff == blockSize)
				{
					this.cipher.ProcessBlock(this.buf, 0, this.buf, 0);
					this.bufOff = 0;
				}
				this.padding.AddPadding(this.buf, this.bufOff);
			}
			this.cipher.ProcessBlock(this.buf, 0, this.buf, 0);
			global::System.Array.Copy(this.buf, 0, output, outOff, this.macSize);
			this.Reset();
			return this.macSize;
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x000B65AB File Offset: 0x000B47AB
		public void Reset()
		{
			global::System.Array.Clear(this.buf, 0, this.buf.Length);
			this.bufOff = 0;
			this.cipher.Reset();
		}

		// Token: 0x04001171 RID: 4465
		private byte[] buf;

		// Token: 0x04001172 RID: 4466
		private int bufOff;

		// Token: 0x04001173 RID: 4467
		private global::Org.BouncyCastle.Crypto.IBlockCipher cipher;

		// Token: 0x04001174 RID: 4468
		private global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding;

		// Token: 0x04001175 RID: 4469
		private int macSize;
	}
}
