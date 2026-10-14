using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000440 RID: 1088
	public class OpenPgpCfbBlockCipher : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002A33 RID: 10803 RVA: 0x000B49F0 File Offset: 0x000B2BF0
		public OpenPgpCfbBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher)
		{
			this.cipher = cipher;
			this.blockSize = cipher.GetBlockSize();
			this.IV = new byte[this.blockSize];
			this.FR = new byte[this.blockSize];
			this.FRE = new byte[this.blockSize];
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x000B4A49 File Offset: 0x000B2C49
		public global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
		{
			return this.cipher;
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06002A35 RID: 10805 RVA: 0x000B4A51 File Offset: 0x000B2C51
		public string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName + "/OpenPGPCFB";
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06002A36 RID: 10806 RVA: 0x000B4A68 File Offset: 0x000B2C68
		public bool IsPartialBlockOkay
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000B4A6B File Offset: 0x000B2C6B
		public int GetBlockSize()
		{
			return this.cipher.GetBlockSize();
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000B4A78 File Offset: 0x000B2C78
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (!this.forEncryption)
			{
				return this.DecryptBlock(input, inOff, output, outOff);
			}
			return this.EncryptBlock(input, inOff, output, outOff);
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000B4A99 File Offset: 0x000B2C99
		public void Reset()
		{
			this.count = 0;
			global::System.Array.Copy(this.IV, 0, this.FR, 0, this.FR.Length);
			this.cipher.Reset();
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000B4AC8 File Offset: 0x000B2CC8
		public void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forEncryption = forEncryption;
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
			this.cipher.Init(true, parameters);
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x000B4B6E File Offset: 0x000B2D6E
		private byte EncryptByte(byte data, int blockOff)
		{
			return this.FRE[blockOff] ^ data;
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x000B4B7C File Offset: 0x000B2D7C
		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			if (inOff + this.blockSize > input.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("input buffer too short");
			}
			if (outOff + this.blockSize > outBytes.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too short");
			}
			if (this.count > this.blockSize)
			{
				this.FR[this.blockSize - 2] = (outBytes[outOff] = this.EncryptByte(input[inOff], this.blockSize - 2));
				this.FR[this.blockSize - 1] = (outBytes[outOff + 1] = this.EncryptByte(input[inOff + 1], this.blockSize - 1));
				this.cipher.ProcessBlock(this.FR, 0, this.FRE, 0);
				for (int i = 2; i < this.blockSize; i++)
				{
					this.FR[i - 2] = (outBytes[outOff + i] = this.EncryptByte(input[inOff + i], i - 2));
				}
			}
			else if (this.count == 0)
			{
				this.cipher.ProcessBlock(this.FR, 0, this.FRE, 0);
				for (int j = 0; j < this.blockSize; j++)
				{
					this.FR[j] = (outBytes[outOff + j] = this.EncryptByte(input[inOff + j], j));
				}
				this.count += this.blockSize;
			}
			else if (this.count == this.blockSize)
			{
				this.cipher.ProcessBlock(this.FR, 0, this.FRE, 0);
				outBytes[outOff] = this.EncryptByte(input[inOff], 0);
				outBytes[outOff + 1] = this.EncryptByte(input[inOff + 1], 1);
				global::System.Array.Copy(this.FR, 2, this.FR, 0, this.blockSize - 2);
				global::System.Array.Copy(outBytes, outOff, this.FR, this.blockSize - 2, 2);
				this.cipher.ProcessBlock(this.FR, 0, this.FRE, 0);
				for (int k = 2; k < this.blockSize; k++)
				{
					this.FR[k - 2] = (outBytes[outOff + k] = this.EncryptByte(input[inOff + k], k - 2));
				}
				this.count += this.blockSize;
			}
			return this.blockSize;
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x000B4DB8 File Offset: 0x000B2FB8
		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			if (inOff + this.blockSize > input.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("input buffer too short");
			}
			if (outOff + this.blockSize > outBytes.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too short");
			}
			if (this.count > this.blockSize)
			{
				byte inVal = input[inOff];
				this.FR[this.blockSize - 2] = inVal;
				outBytes[outOff] = this.EncryptByte(inVal, this.blockSize - 2);
				inVal = input[inOff + 1];
				this.FR[this.blockSize - 1] = inVal;
				outBytes[outOff + 1] = this.EncryptByte(inVal, this.blockSize - 1);
				this.cipher.ProcessBlock(this.FR, 0, this.FRE, 0);
				for (int i = 2; i < this.blockSize; i++)
				{
					inVal = input[inOff + i];
					this.FR[i - 2] = inVal;
					outBytes[outOff + i] = this.EncryptByte(inVal, i - 2);
				}
			}
			else if (this.count == 0)
			{
				this.cipher.ProcessBlock(this.FR, 0, this.FRE, 0);
				for (int j = 0; j < this.blockSize; j++)
				{
					this.FR[j] = input[inOff + j];
					outBytes[j] = this.EncryptByte(input[inOff + j], j);
				}
				this.count += this.blockSize;
			}
			else if (this.count == this.blockSize)
			{
				this.cipher.ProcessBlock(this.FR, 0, this.FRE, 0);
				byte inVal2 = input[inOff];
				byte inVal3 = input[inOff + 1];
				outBytes[outOff] = this.EncryptByte(inVal2, 0);
				outBytes[outOff + 1] = this.EncryptByte(inVal3, 1);
				global::System.Array.Copy(this.FR, 2, this.FR, 0, this.blockSize - 2);
				this.FR[this.blockSize - 2] = inVal2;
				this.FR[this.blockSize - 1] = inVal3;
				this.cipher.ProcessBlock(this.FR, 0, this.FRE, 0);
				for (int k = 2; k < this.blockSize; k++)
				{
					byte inVal4 = input[inOff + k];
					this.FR[k - 2] = inVal4;
					outBytes[outOff + k] = this.EncryptByte(inVal4, k - 2);
				}
				this.count += this.blockSize;
			}
			return this.blockSize;
		}

		// Token: 0x0400115A RID: 4442
		private byte[] IV;

		// Token: 0x0400115B RID: 4443
		private byte[] FR;

		// Token: 0x0400115C RID: 4444
		private byte[] FRE;

		// Token: 0x0400115D RID: 4445
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher cipher;

		// Token: 0x0400115E RID: 4446
		private readonly int blockSize;

		// Token: 0x0400115F RID: 4447
		private int count;

		// Token: 0x04001160 RID: 4448
		private bool forEncryption;
	}
}
