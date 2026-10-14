using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x0200043F RID: 1087
	public class OfbBlockCipher : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002A2B RID: 10795 RVA: 0x000B47B0 File Offset: 0x000B29B0
		public OfbBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int blockSize)
		{
			this.cipher = cipher;
			this.blockSize = blockSize / 8;
			this.IV = new byte[cipher.GetBlockSize()];
			this.ofbV = new byte[cipher.GetBlockSize()];
			this.ofbOutV = new byte[cipher.GetBlockSize()];
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x000B4806 File Offset: 0x000B2A06
		public global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
		{
			return this.cipher;
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x000B4810 File Offset: 0x000B2A10
		public void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV ivParam = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				byte[] iv = ivParam.GetIV();
				if (iv.Length < this.IV.Length)
				{
					global::System.Array.Copy(iv, 0, this.IV, this.IV.Length - iv.Length, iv.Length);
					for (int i = 0; i < this.IV.Length - iv.Length; i++)
					{
						this.IV[i] = 0;
					}
				}
				else
				{
					global::System.Array.Copy(iv, 0, this.IV, 0, this.IV.Length);
				}
				parameters = ivParam.Parameters;
			}
			this.Reset();
			if (parameters != null)
			{
				this.cipher.Init(true, parameters);
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06002A2E RID: 10798 RVA: 0x000B48B4 File Offset: 0x000B2AB4
		public string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName + "/OFB" + (this.blockSize * 8).ToString();
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x000B48E6 File Offset: 0x000B2AE6
		public bool IsPartialBlockOkay
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x000B48E9 File Offset: 0x000B2AE9
		public int GetBlockSize()
		{
			return this.blockSize;
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x000B48F4 File Offset: 0x000B2AF4
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (inOff + this.blockSize > input.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("input buffer too short");
			}
			if (outOff + this.blockSize > output.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too short");
			}
			this.cipher.ProcessBlock(this.ofbV, 0, this.ofbOutV, 0);
			for (int i = 0; i < this.blockSize; i++)
			{
				output[outOff + i] = (this.ofbOutV[i] ^ input[inOff + i]);
			}
			global::System.Array.Copy(this.ofbV, this.blockSize, this.ofbV, 0, this.ofbV.Length - this.blockSize);
			global::System.Array.Copy(this.ofbOutV, 0, this.ofbV, this.ofbV.Length - this.blockSize, this.blockSize);
			return this.blockSize;
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x000B49C6 File Offset: 0x000B2BC6
		public void Reset()
		{
			global::System.Array.Copy(this.IV, 0, this.ofbV, 0, this.IV.Length);
			this.cipher.Reset();
		}

		// Token: 0x04001155 RID: 4437
		private byte[] IV;

		// Token: 0x04001156 RID: 4438
		private byte[] ofbV;

		// Token: 0x04001157 RID: 4439
		private byte[] ofbOutV;

		// Token: 0x04001158 RID: 4440
		private readonly int blockSize;

		// Token: 0x04001159 RID: 4441
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher cipher;
	}
}
