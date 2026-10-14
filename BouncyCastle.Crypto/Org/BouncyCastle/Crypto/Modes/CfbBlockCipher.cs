using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000433 RID: 1075
	public class CfbBlockCipher : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002961 RID: 10593 RVA: 0x000AFA40 File Offset: 0x000ADC40
		public CfbBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int bitBlockSize)
		{
			if (bitBlockSize < 8 || (bitBlockSize & 7) != 0)
			{
				throw new global::System.ArgumentException("CFB" + bitBlockSize.ToString() + " not supported", "bitBlockSize");
			}
			this.cipher = cipher;
			this.blockSize = bitBlockSize / 8;
			this.IV = new byte[cipher.GetBlockSize()];
			this.cfbV = new byte[cipher.GetBlockSize()];
			this.cfbOutV = new byte[cipher.GetBlockSize()];
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000AFAC0 File Offset: 0x000ADCC0
		public global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
		{
			return this.cipher;
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x000AFAC8 File Offset: 0x000ADCC8
		public void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.encrypting = forEncryption;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV parametersWithIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				byte[] iv = parametersWithIV.GetIV();
				int diff = this.IV.Length - iv.Length;
				global::System.Array.Copy(iv, 0, this.IV, diff, iv.Length);
				global::System.Array.Clear(this.IV, 0, diff);
				parameters = parametersWithIV.Parameters;
			}
			this.Reset();
			if (parameters != null)
			{
				this.cipher.Init(true, parameters);
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x000AFB3C File Offset: 0x000ADD3C
		public string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName + "/CFB" + (this.blockSize * 8).ToString();
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06002965 RID: 10597 RVA: 0x000AFB6E File Offset: 0x000ADD6E
		public bool IsPartialBlockOkay
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x000AFB71 File Offset: 0x000ADD71
		public int GetBlockSize()
		{
			return this.blockSize;
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x000AFB79 File Offset: 0x000ADD79
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (!this.encrypting)
			{
				return this.DecryptBlock(input, inOff, output, outOff);
			}
			return this.EncryptBlock(input, inOff, output, outOff);
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x000AFB9C File Offset: 0x000ADD9C
		public int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
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

		// Token: 0x06002969 RID: 10601 RVA: 0x000AFC6C File Offset: 0x000ADE6C
		public int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
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
			global::System.Array.Copy(this.cfbV, this.blockSize, this.cfbV, 0, this.cfbV.Length - this.blockSize);
			global::System.Array.Copy(input, inOff, this.cfbV, this.cfbV.Length - this.blockSize, this.blockSize);
			for (int i = 0; i < this.blockSize; i++)
			{
				outBytes[outOff + i] = (this.cfbOutV[i] ^ input[inOff + i]);
			}
			return this.blockSize;
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x000AFD39 File Offset: 0x000ADF39
		public void Reset()
		{
			global::System.Array.Copy(this.IV, 0, this.cfbV, 0, this.IV.Length);
			this.cipher.Reset();
		}

		// Token: 0x040010C9 RID: 4297
		private byte[] IV;

		// Token: 0x040010CA RID: 4298
		private byte[] cfbV;

		// Token: 0x040010CB RID: 4299
		private byte[] cfbOutV;

		// Token: 0x040010CC RID: 4300
		private bool encrypting;

		// Token: 0x040010CD RID: 4301
		private readonly int blockSize;

		// Token: 0x040010CE RID: 4302
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher cipher;
	}
}
