using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000431 RID: 1073
	public class CbcBlockCipher : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002942 RID: 10562 RVA: 0x000AF034 File Offset: 0x000AD234
		public CbcBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher)
		{
			this.cipher = cipher;
			this.blockSize = cipher.GetBlockSize();
			this.IV = new byte[this.blockSize];
			this.cbcV = new byte[this.blockSize];
			this.cbcNextV = new byte[this.blockSize];
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x000AF08D File Offset: 0x000AD28D
		public global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
		{
			return this.cipher;
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x000AF098 File Offset: 0x000AD298
		public void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			bool oldEncrypting = this.encrypting;
			this.encrypting = forEncryption;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV parametersWithIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				byte[] iv = parametersWithIV.GetIV();
				if (iv.Length != this.blockSize)
				{
					throw new global::System.ArgumentException("initialisation vector must be the same length as block size");
				}
				global::System.Array.Copy(iv, 0, this.IV, 0, iv.Length);
				parameters = parametersWithIV.Parameters;
			}
			this.Reset();
			if (parameters != null)
			{
				this.cipher.Init(this.encrypting, parameters);
				return;
			}
			if (oldEncrypting != this.encrypting)
			{
				throw new global::System.ArgumentException("cannot change encrypting state without providing key.");
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x000AF126 File Offset: 0x000AD326
		public string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName + "/CBC";
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x000AF13D File Offset: 0x000AD33D
		public bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x000AF140 File Offset: 0x000AD340
		public int GetBlockSize()
		{
			return this.cipher.GetBlockSize();
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x000AF14D File Offset: 0x000AD34D
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (!this.encrypting)
			{
				return this.DecryptBlock(input, inOff, output, outOff);
			}
			return this.EncryptBlock(input, inOff, output, outOff);
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x000AF16E File Offset: 0x000AD36E
		public void Reset()
		{
			global::System.Array.Copy(this.IV, 0, this.cbcV, 0, this.IV.Length);
			global::System.Array.Clear(this.cbcNextV, 0, this.cbcNextV.Length);
			this.cipher.Reset();
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x000AF1AC File Offset: 0x000AD3AC
		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			if (inOff + this.blockSize > input.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("input buffer too short");
			}
			for (int i = 0; i < this.blockSize; i++)
			{
				byte[] array = this.cbcV;
				int num = i;
				array[num] ^= input[inOff + i];
			}
			int result = this.cipher.ProcessBlock(this.cbcV, 0, outBytes, outOff);
			global::System.Array.Copy(outBytes, outOff, this.cbcV, 0, this.cbcV.Length);
			return result;
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x000AF224 File Offset: 0x000AD424
		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			if (inOff + this.blockSize > input.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("input buffer too short");
			}
			global::System.Array.Copy(input, inOff, this.cbcNextV, 0, this.blockSize);
			int length = this.cipher.ProcessBlock(input, inOff, outBytes, outOff);
			for (int i = 0; i < this.blockSize; i++)
			{
				int num = outOff + i;
				outBytes[num] ^= this.cbcV[i];
			}
			byte[] tmp = this.cbcV;
			this.cbcV = this.cbcNextV;
			this.cbcNextV = tmp;
			return length;
		}

		// Token: 0x040010B9 RID: 4281
		private byte[] IV;

		// Token: 0x040010BA RID: 4282
		private byte[] cbcV;

		// Token: 0x040010BB RID: 4283
		private byte[] cbcNextV;

		// Token: 0x040010BC RID: 4284
		private int blockSize;

		// Token: 0x040010BD RID: 4285
		private global::Org.BouncyCastle.Crypto.IBlockCipher cipher;

		// Token: 0x040010BE RID: 4286
		private bool encrypting;
	}
}
