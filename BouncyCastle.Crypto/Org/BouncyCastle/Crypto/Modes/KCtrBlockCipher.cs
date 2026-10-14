using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x0200043D RID: 1085
	public class KCtrBlockCipher : global::Org.BouncyCastle.Crypto.IStreamCipher, global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002A04 RID: 10756 RVA: 0x000B3928 File Offset: 0x000B1B28
		public KCtrBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher)
		{
			this.cipher = cipher;
			this.IV = new byte[cipher.GetBlockSize()];
			this.blockSize = cipher.GetBlockSize();
			this.ofbV = new byte[cipher.GetBlockSize()];
			this.ofbOutV = new byte[cipher.GetBlockSize()];
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x000B3981 File Offset: 0x000B1B81
		public global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
		{
			return this.cipher;
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x000B398C File Offset: 0x000B1B8C
		public void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.initialised = true;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV parametersWithIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				byte[] iv = parametersWithIV.GetIV();
				int diff = this.IV.Length - iv.Length;
				global::System.Array.Clear(this.IV, 0, this.IV.Length);
				global::System.Array.Copy(iv, 0, this.IV, diff, iv.Length);
				parameters = parametersWithIV.Parameters;
				if (parameters != null)
				{
					this.cipher.Init(true, parameters);
				}
				this.Reset();
				return;
			}
			throw new global::System.ArgumentException("Invalid parameter passed");
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x000B3A11 File Offset: 0x000B1C11
		public string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName + "/KCTR";
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x000B3A28 File Offset: 0x000B1C28
		public bool IsPartialBlockOkay
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x000B3A2B File Offset: 0x000B1C2B
		public int GetBlockSize()
		{
			return this.cipher.GetBlockSize();
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x000B3A38 File Offset: 0x000B1C38
		public byte ReturnByte(byte input)
		{
			return this.CalculateByte(input);
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x000B3A44 File Offset: 0x000B1C44
		public void ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
			if (outOff + len > output.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Output buffer too short");
			}
			if (inOff + len > input.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Input buffer too small");
			}
			int inStart = inOff;
			int inEnd = inOff + len;
			int outStart = outOff;
			while (inStart < inEnd)
			{
				output[outStart++] = this.CalculateByte(input[inStart++]);
			}
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x000B3AA0 File Offset: 0x000B1CA0
		protected byte CalculateByte(byte b)
		{
			int num;
			if (this.byteCount == 0)
			{
				this.incrementCounterAt(0);
				this.checkCounter();
				this.cipher.ProcessBlock(this.ofbV, 0, this.ofbOutV, 0);
				byte[] array = this.ofbOutV;
				num = this.byteCount;
				this.byteCount = num + 1;
				return array[num] ^ b;
			}
			byte[] array2 = this.ofbOutV;
			num = this.byteCount;
			this.byteCount = num + 1;
			byte result = array2[num] ^ b;
			if (this.byteCount == this.ofbV.Length)
			{
				this.byteCount = 0;
			}
			return result;
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x000B3B2C File Offset: 0x000B1D2C
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (input.Length - inOff < this.GetBlockSize())
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Input buffer too short");
			}
			if (output.Length - outOff < this.GetBlockSize())
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Output buffer too short");
			}
			this.ProcessBytes(input, inOff, this.GetBlockSize(), output, outOff);
			return this.GetBlockSize();
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x000B3B81 File Offset: 0x000B1D81
		public void Reset()
		{
			if (this.initialised)
			{
				this.cipher.ProcessBlock(this.IV, 0, this.ofbV, 0);
			}
			this.cipher.Reset();
			this.byteCount = 0;
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x000B3BB8 File Offset: 0x000B1DB8
		private void incrementCounterAt(int pos)
		{
			int i = pos;
			while (i < this.ofbV.Length)
			{
				byte[] array = this.ofbV;
				int num = i++;
				byte b = array[num] + 1;
				array[num] = b;
				if (b != 0)
				{
					break;
				}
			}
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x000B3BEF File Offset: 0x000B1DEF
		private void checkCounter()
		{
		}

		// Token: 0x04001137 RID: 4407
		private byte[] IV;

		// Token: 0x04001138 RID: 4408
		private byte[] ofbV;

		// Token: 0x04001139 RID: 4409
		private byte[] ofbOutV;

		// Token: 0x0400113A RID: 4410
		private bool initialised;

		// Token: 0x0400113B RID: 4411
		private int byteCount;

		// Token: 0x0400113C RID: 4412
		private readonly int blockSize;

		// Token: 0x0400113D RID: 4413
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher cipher;
	}
}
