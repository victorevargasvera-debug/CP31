using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000441 RID: 1089
	public class SicBlockCipher : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002A3E RID: 10814 RVA: 0x000B5010 File Offset: 0x000B3210
		public SicBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher)
		{
			this.cipher = cipher;
			this.blockSize = cipher.GetBlockSize();
			this.counter = new byte[this.blockSize];
			this.counterOut = new byte[this.blockSize];
			this.IV = new byte[this.blockSize];
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x000B5069 File Offset: 0x000B3269
		public virtual global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
		{
			return this.cipher;
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x000B5074 File Offset: 0x000B3274
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV ivParam = parameters as global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV;
			if (ivParam == null)
			{
				throw new global::System.ArgumentException("CTR/SIC mode requires ParametersWithIV", "parameters");
			}
			this.IV = global::Org.BouncyCastle.Utilities.Arrays.Clone(ivParam.GetIV());
			if (this.blockSize < this.IV.Length)
			{
				throw new global::System.ArgumentException("CTR/SIC mode requires IV no greater than: " + this.blockSize.ToString() + " bytes.");
			}
			int maxCounterSize = global::System.Math.Min(8, this.blockSize / 2);
			if (this.blockSize - this.IV.Length > maxCounterSize)
			{
				throw new global::System.ArgumentException("CTR/SIC mode requires IV of at least: " + (this.blockSize - maxCounterSize).ToString() + " bytes.");
			}
			if (ivParam.Parameters != null)
			{
				this.cipher.Init(true, ivParam.Parameters);
			}
			this.Reset();
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x000B5145 File Offset: 0x000B3345
		public virtual string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName + "/SIC";
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x000B515C File Offset: 0x000B335C
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x000B515F File Offset: 0x000B335F
		public virtual int GetBlockSize()
		{
			return this.cipher.GetBlockSize();
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x000B516C File Offset: 0x000B336C
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			this.cipher.ProcessBlock(this.counter, 0, this.counterOut, 0);
			for (int i = 0; i < this.counterOut.Length; i++)
			{
				output[outOff + i] = (this.counterOut[i] ^ input[inOff + i]);
			}
			int j = this.counter.Length;
			while (--j >= 0)
			{
				byte[] array = this.counter;
				int num = j;
				byte b = array[num] + 1;
				array[num] = b;
				if (b != 0)
				{
					break;
				}
			}
			return this.counter.Length;
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x000B51EB File Offset: 0x000B33EB
		public virtual void Reset()
		{
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.counter, 0);
			global::System.Array.Copy(this.IV, 0, this.counter, 0, this.IV.Length);
			this.cipher.Reset();
		}

		// Token: 0x04001161 RID: 4449
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher cipher;

		// Token: 0x04001162 RID: 4450
		private readonly int blockSize;

		// Token: 0x04001163 RID: 4451
		private readonly byte[] counter;

		// Token: 0x04001164 RID: 4452
		private readonly byte[] counterOut;

		// Token: 0x04001165 RID: 4453
		private byte[] IV;
	}
}
