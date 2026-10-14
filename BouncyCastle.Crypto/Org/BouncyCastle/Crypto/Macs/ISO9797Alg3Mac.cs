using System;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000454 RID: 1108
	public class ISO9797Alg3Mac : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x06002AED RID: 10989 RVA: 0x000B7EB6 File Offset: 0x000B60B6
		public ISO9797Alg3Mac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher) : this(cipher, cipher.GetBlockSize() * 8, null)
		{
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x000B7EC8 File Offset: 0x000B60C8
		public ISO9797Alg3Mac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding) : this(cipher, cipher.GetBlockSize() * 8, padding)
		{
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x000B7EDA File Offset: 0x000B60DA
		public ISO9797Alg3Mac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int macSizeInBits) : this(cipher, macSizeInBits, null)
		{
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x000B7EE8 File Offset: 0x000B60E8
		public ISO9797Alg3Mac(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int macSizeInBits, global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding)
		{
			if (macSizeInBits % 8 != 0)
			{
				throw new global::System.ArgumentException("MAC size must be multiple of 8");
			}
			if (!(cipher is global::Org.BouncyCastle.Crypto.Engines.DesEngine))
			{
				throw new global::System.ArgumentException("cipher must be instance of DesEngine");
			}
			this.cipher = new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(cipher);
			this.padding = padding;
			this.macSize = macSizeInBits / 8;
			this.mac = new byte[cipher.GetBlockSize()];
			this.buf = new byte[cipher.GetBlockSize()];
			this.bufOff = 0;
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x000B7F63 File Offset: 0x000B6163
		public string AlgorithmName
		{
			get
			{
				return "ISO9797Alg3";
			}
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x000B7F6C File Offset: 0x000B616C
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.Reset();
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter) && !(parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV))
			{
				throw new global::System.ArgumentException("parameters must be an instance of KeyParameter or ParametersWithIV");
			}
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter kp;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)
			{
				kp = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters;
			}
			else
			{
				kp = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters).Parameters;
			}
			byte[] keyvalue = kp.GetKey();
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key;
			if (keyvalue.Length == 16)
			{
				key = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(keyvalue, 0, 8);
				this.lastKey2 = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(keyvalue, 8, 8);
				this.lastKey3 = key;
			}
			else
			{
				if (keyvalue.Length != 24)
				{
					throw new global::System.ArgumentException("Key must be either 112 or 168 bit long");
				}
				key = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(keyvalue, 0, 8);
				this.lastKey2 = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(keyvalue, 8, 8);
				this.lastKey3 = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(keyvalue, 16, 8);
			}
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)
			{
				this.cipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(key, ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters).GetIV()));
				return;
			}
			this.cipher.Init(true, key);
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x000B8057 File Offset: 0x000B6257
		public int GetMacSize()
		{
			return this.macSize;
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x000B8060 File Offset: 0x000B6260
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

		// Token: 0x06002AF5 RID: 10997 RVA: 0x000B80B8 File Offset: 0x000B62B8
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
				global::System.Array.Copy(input, inOff, this.buf, this.bufOff, gapLen);
				resultLen += this.cipher.ProcessBlock(this.buf, 0, this.mac, 0);
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
			global::System.Array.Copy(input, inOff, this.buf, this.bufOff, len);
			this.bufOff += len;
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x000B817C File Offset: 0x000B637C
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
					this.cipher.ProcessBlock(this.buf, 0, this.mac, 0);
					this.bufOff = 0;
				}
				this.padding.AddPadding(this.buf, this.bufOff);
			}
			this.cipher.ProcessBlock(this.buf, 0, this.mac, 0);
			global::Org.BouncyCastle.Crypto.Engines.DesEngine desEngine = new global::Org.BouncyCastle.Crypto.Engines.DesEngine();
			desEngine.Init(false, this.lastKey2);
			desEngine.ProcessBlock(this.mac, 0, this.mac, 0);
			desEngine.Init(true, this.lastKey3);
			desEngine.ProcessBlock(this.mac, 0, this.mac, 0);
			global::System.Array.Copy(this.mac, 0, output, outOff, this.macSize);
			this.Reset();
			return this.macSize;
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x000B8287 File Offset: 0x000B6487
		public void Reset()
		{
			global::System.Array.Clear(this.buf, 0, this.buf.Length);
			this.bufOff = 0;
			this.cipher.Reset();
		}

		// Token: 0x040011AD RID: 4525
		private byte[] mac;

		// Token: 0x040011AE RID: 4526
		private byte[] buf;

		// Token: 0x040011AF RID: 4527
		private int bufOff;

		// Token: 0x040011B0 RID: 4528
		private global::Org.BouncyCastle.Crypto.IBlockCipher cipher;

		// Token: 0x040011B1 RID: 4529
		private global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding;

		// Token: 0x040011B2 RID: 4530
		private int macSize;

		// Token: 0x040011B3 RID: 4531
		private global::Org.BouncyCastle.Crypto.Parameters.KeyParameter lastKey2;

		// Token: 0x040011B4 RID: 4532
		private global::Org.BouncyCastle.Crypto.Parameters.KeyParameter lastKey3;
	}
}
