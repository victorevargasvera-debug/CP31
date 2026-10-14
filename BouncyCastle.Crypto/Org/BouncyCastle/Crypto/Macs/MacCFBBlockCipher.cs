using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x0200044C RID: 1100
	internal class MacCFBBlockCipher : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002A9A RID: 10906 RVA: 0x000B65D4 File Offset: 0x000B47D4
		public MacCFBBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int bitBlockSize)
		{
			this.cipher = cipher;
			this.blockSize = bitBlockSize / 8;
			this.IV = new byte[cipher.GetBlockSize()];
			this.cfbV = new byte[cipher.GetBlockSize()];
			this.cfbOutV = new byte[cipher.GetBlockSize()];
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x000B662C File Offset: 0x000B482C
		public void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV parametersWithIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				byte[] iv = parametersWithIV.GetIV();
				if (iv.Length < this.IV.Length)
				{
					global::System.Array.Copy(iv, 0, this.IV, this.IV.Length - iv.Length, iv.Length);
				}
				else
				{
					global::System.Array.Copy(iv, 0, this.IV, 0, this.IV.Length);
				}
				parameters = parametersWithIV.Parameters;
			}
			this.Reset();
			this.cipher.Init(true, parameters);
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x000B66AC File Offset: 0x000B48AC
		public string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName + "/CFB" + (this.blockSize * 8).ToString();
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06002A9D RID: 10909 RVA: 0x000B66DE File Offset: 0x000B48DE
		public bool IsPartialBlockOkay
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x000B66E1 File Offset: 0x000B48E1
		public int GetBlockSize()
		{
			return this.blockSize;
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x000B66EC File Offset: 0x000B48EC
		public int ProcessBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			if (inOff + this.blockSize > input.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("input buffer too short");
			}
			if (outOff + this.blockSize > outBytes.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too short");
			}
			this.cipher.ProcessBlock(this.cfbV, 0, this.cfbOutV, 0);
			for (int i = 0; i < this.blockSize; i++)
			{
				outBytes[outOff + i] = (this.cfbOutV[i] ^ input[inOff + i]);
			}
			global::System.Array.Copy(this.cfbV, this.blockSize, this.cfbV, 0, this.cfbV.Length - this.blockSize);
			global::System.Array.Copy(outBytes, outOff, this.cfbV, this.cfbV.Length - this.blockSize, this.blockSize);
			return this.blockSize;
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x000B67BA File Offset: 0x000B49BA
		public void Reset()
		{
			this.IV.CopyTo(this.cfbV, 0);
			this.cipher.Reset();
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x000B67D9 File Offset: 0x000B49D9
		public void GetMacBlock(byte[] mac)
		{
			this.cipher.ProcessBlock(this.cfbV, 0, mac, 0);
		}

		// Token: 0x04001176 RID: 4470
		private byte[] IV;

		// Token: 0x04001177 RID: 4471
		private byte[] cfbV;

		// Token: 0x04001178 RID: 4472
		private byte[] cfbOutV;

		// Token: 0x04001179 RID: 4473
		private readonly int blockSize;

		// Token: 0x0400117A RID: 4474
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher cipher;
	}
}
