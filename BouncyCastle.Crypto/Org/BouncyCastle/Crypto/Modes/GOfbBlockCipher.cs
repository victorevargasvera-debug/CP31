using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000439 RID: 1081
	public class GOfbBlockCipher : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x060029D6 RID: 10710 RVA: 0x000B2A74 File Offset: 0x000B0C74
		public GOfbBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher)
		{
			this.cipher = cipher;
			this.blockSize = cipher.GetBlockSize();
			if (this.blockSize != 8)
			{
				throw new global::System.ArgumentException("GCTR only for 64 bit block ciphers");
			}
			this.IV = new byte[cipher.GetBlockSize()];
			this.ofbV = new byte[cipher.GetBlockSize()];
			this.ofbOutV = new byte[cipher.GetBlockSize()];
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x000B2AE8 File Offset: 0x000B0CE8
		public global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
		{
			return this.cipher;
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x000B2AF0 File Offset: 0x000B0CF0
		public void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.firstStep = true;
			this.N3 = 0;
			this.N4 = 0;
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

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x000B2BA7 File Offset: 0x000B0DA7
		public string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName + "/GCTR";
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060029DA RID: 10714 RVA: 0x000B2BBE File Offset: 0x000B0DBE
		public bool IsPartialBlockOkay
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x000B2BC1 File Offset: 0x000B0DC1
		public int GetBlockSize()
		{
			return this.blockSize;
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x000B2BCC File Offset: 0x000B0DCC
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
			if (this.firstStep)
			{
				this.firstStep = false;
				this.cipher.ProcessBlock(this.ofbV, 0, this.ofbOutV, 0);
				this.N3 = this.bytesToint(this.ofbOutV, 0);
				this.N4 = this.bytesToint(this.ofbOutV, 4);
			}
			this.N3 += 16843009;
			this.N4 += 16843012;
			if (this.N4 < 16843012 && this.N4 > 0)
			{
				this.N4++;
			}
			this.intTobytes(this.N3, this.ofbV, 0);
			this.intTobytes(this.N4, this.ofbV, 4);
			this.cipher.ProcessBlock(this.ofbV, 0, this.ofbOutV, 0);
			for (int i = 0; i < this.blockSize; i++)
			{
				output[outOff + i] = (this.ofbOutV[i] ^ input[inOff + i]);
			}
			global::System.Array.Copy(this.ofbV, this.blockSize, this.ofbV, 0, this.ofbV.Length - this.blockSize);
			global::System.Array.Copy(this.ofbOutV, 0, this.ofbV, this.ofbV.Length - this.blockSize, this.blockSize);
			return this.blockSize;
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x000B2D5B File Offset: 0x000B0F5B
		public void Reset()
		{
			global::System.Array.Copy(this.IV, 0, this.ofbV, 0, this.IV.Length);
			this.cipher.Reset();
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000B2D83 File Offset: 0x000B0F83
		private int bytesToint(byte[] inBytes, int inOff)
		{
			return (int)((long)((long)inBytes[inOff + 3] << 24) & (long)((ulong)-16777216)) + ((int)inBytes[inOff + 2] << 16 & 16711680) + ((int)inBytes[inOff + 1] << 8 & 65280) + (int)(inBytes[inOff] & byte.MaxValue);
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x000B2DBD File Offset: 0x000B0FBD
		private void intTobytes(int num, byte[] outBytes, int outOff)
		{
			outBytes[outOff + 3] = (byte)(num >> 24);
			outBytes[outOff + 2] = (byte)(num >> 16);
			outBytes[outOff + 1] = (byte)(num >> 8);
			outBytes[outOff] = (byte)num;
		}

		// Token: 0x0400111B RID: 4379
		private byte[] IV;

		// Token: 0x0400111C RID: 4380
		private byte[] ofbV;

		// Token: 0x0400111D RID: 4381
		private byte[] ofbOutV;

		// Token: 0x0400111E RID: 4382
		private readonly int blockSize;

		// Token: 0x0400111F RID: 4383
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher cipher;

		// Token: 0x04001120 RID: 4384
		private bool firstStep = true;

		// Token: 0x04001121 RID: 4385
		private int N3;

		// Token: 0x04001122 RID: 4386
		private int N4;

		// Token: 0x04001123 RID: 4387
		private const int C1 = 16843012;

		// Token: 0x04001124 RID: 4388
		private const int C2 = 16843009;
	}
}
