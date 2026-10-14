using System;
using System.IO;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000432 RID: 1074
	public class CcmBlockCipher : global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher, global::Org.BouncyCastle.Crypto.Modes.IAeadCipher
	{
		// Token: 0x0600294C RID: 10572 RVA: 0x000AF2B4 File Offset: 0x000AD4B4
		public CcmBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher)
		{
			this.cipher = cipher;
			this.macBlock = new byte[global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize];
			if (cipher.GetBlockSize() != global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize)
			{
				throw new global::System.ArgumentException("cipher required with a block size of " + global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize.ToString() + ".");
			}
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x000AF323 File Offset: 0x000AD523
		public virtual global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
		{
			return this.cipher;
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x000AF32C File Offset: 0x000AD52C
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forEncryption = forEncryption;
			global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.AeadParameters param = (global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)parameters;
				this.nonce = param.GetNonce();
				this.initialAssociatedText = param.GetAssociatedText();
				this.macSize = this.GetMacSize(forEncryption, param.MacSize);
				cipherParameters = param.Key;
			}
			else
			{
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV))
				{
					throw new global::System.ArgumentException("invalid parameters passed to CCM");
				}
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV param2 = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				this.nonce = param2.GetIV();
				this.initialAssociatedText = null;
				this.macSize = this.GetMacSize(forEncryption, 64);
				cipherParameters = param2.Parameters;
			}
			if (cipherParameters != null)
			{
				this.keyParam = cipherParameters;
			}
			if (this.nonce == null || this.nonce.Length < 7 || this.nonce.Length > 13)
			{
				throw new global::System.ArgumentException("nonce must have length from 7 to 13 octets");
			}
			this.Reset();
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600294F RID: 10575 RVA: 0x000AF402 File Offset: 0x000AD602
		public virtual string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName + "/CCM";
			}
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x000AF419 File Offset: 0x000AD619
		public virtual int GetBlockSize()
		{
			return this.cipher.GetBlockSize();
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x000AF426 File Offset: 0x000AD626
		public virtual void ProcessAadByte(byte input)
		{
			this.associatedText.WriteByte(input);
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x000AF434 File Offset: 0x000AD634
		public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
		{
			this.associatedText.Write(inBytes, inOff, len);
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x000AF444 File Offset: 0x000AD644
		public virtual int ProcessByte(byte input, byte[] outBytes, int outOff)
		{
			this.data.WriteByte(input);
			return 0;
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x000AF453 File Offset: 0x000AD653
		public virtual int ProcessBytes(byte[] inBytes, int inOff, int inLen, byte[] outBytes, int outOff)
		{
			global::Org.BouncyCastle.Crypto.Check.DataLength(inBytes, inOff, inLen, "Input buffer too short");
			this.data.Write(inBytes, inOff, inLen);
			return 0;
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x000AF474 File Offset: 0x000AD674
		public virtual int DoFinal(byte[] outBytes, int outOff)
		{
			byte[] input = this.data.GetBuffer();
			int inLen = (int)this.data.Position;
			int result = this.ProcessPacket(input, 0, inLen, outBytes, outOff);
			this.Reset();
			return result;
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x000AF4AB File Offset: 0x000AD6AB
		public virtual void Reset()
		{
			this.cipher.Reset();
			this.associatedText.SetLength(0L);
			this.data.SetLength(0L);
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x000AF4D2 File Offset: 0x000AD6D2
		public virtual byte[] GetMac()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(this.macBlock, 0, this.macSize);
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x000AF4E6 File Offset: 0x000AD6E6
		public virtual int GetUpdateOutputSize(int len)
		{
			return 0;
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x000AF4EC File Offset: 0x000AD6EC
		public virtual int GetOutputSize(int len)
		{
			int totalData = (int)this.data.Length + len;
			if (this.forEncryption)
			{
				return totalData + this.macSize;
			}
			if (totalData >= this.macSize)
			{
				return totalData - this.macSize;
			}
			return 0;
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x000AF52C File Offset: 0x000AD72C
		public virtual byte[] ProcessPacket(byte[] input, int inOff, int inLen)
		{
			byte[] output;
			if (this.forEncryption)
			{
				output = new byte[inLen + this.macSize];
			}
			else
			{
				if (inLen < this.macSize)
				{
					throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("data too short");
				}
				output = new byte[inLen - this.macSize];
			}
			this.ProcessPacket(input, inOff, inLen, output, 0);
			return output;
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x000AF580 File Offset: 0x000AD780
		public virtual int ProcessPacket(byte[] input, int inOff, int inLen, byte[] output, int outOff)
		{
			if (this.keyParam == null)
			{
				throw new global::System.InvalidOperationException("CCM cipher unitialized.");
			}
			int i = this.nonce.Length;
			int q = 15 - i;
			if (q < 4)
			{
				int limitLen = 1 << 8 * q;
				if (inLen >= limitLen)
				{
					throw new global::System.InvalidOperationException("CCM packet too large for choice of q.");
				}
			}
			byte[] iv = new byte[global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize];
			iv[0] = (byte)(q - 1 & 7);
			this.nonce.CopyTo(iv, 1);
			global::Org.BouncyCastle.Crypto.IBlockCipher ctrCipher = new global::Org.BouncyCastle.Crypto.Modes.SicBlockCipher(this.cipher);
			ctrCipher.Init(this.forEncryption, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.keyParam, iv));
			int inIndex = inOff;
			int outIndex = outOff;
			int outputLen;
			if (this.forEncryption)
			{
				outputLen = inLen + this.macSize;
				global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, outputLen, "Output buffer too short.");
				this.CalculateMac(input, inOff, inLen, this.macBlock);
				byte[] encMac = new byte[global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize];
				ctrCipher.ProcessBlock(this.macBlock, 0, encMac, 0);
				while (inIndex < inOff + inLen - global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize)
				{
					ctrCipher.ProcessBlock(input, inIndex, output, outIndex);
					outIndex += global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize;
					inIndex += global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize;
				}
				byte[] block = new byte[global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize];
				global::System.Array.Copy(input, inIndex, block, 0, inLen + inOff - inIndex);
				ctrCipher.ProcessBlock(block, 0, block, 0);
				global::System.Array.Copy(block, 0, output, outIndex, inLen + inOff - inIndex);
				global::System.Array.Copy(encMac, 0, output, outOff + inLen, this.macSize);
			}
			else
			{
				if (inLen < this.macSize)
				{
					throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("data too short");
				}
				outputLen = inLen - this.macSize;
				global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, outputLen, "Output buffer too short.");
				global::System.Array.Copy(input, inOff + outputLen, this.macBlock, 0, this.macSize);
				ctrCipher.ProcessBlock(this.macBlock, 0, this.macBlock, 0);
				for (int j = this.macSize; j != this.macBlock.Length; j++)
				{
					this.macBlock[j] = 0;
				}
				while (inIndex < inOff + outputLen - global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize)
				{
					ctrCipher.ProcessBlock(input, inIndex, output, outIndex);
					outIndex += global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize;
					inIndex += global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize;
				}
				byte[] block2 = new byte[global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize];
				global::System.Array.Copy(input, inIndex, block2, 0, outputLen - (inIndex - inOff));
				ctrCipher.ProcessBlock(block2, 0, block2, 0);
				global::System.Array.Copy(block2, 0, output, outIndex, outputLen - (inIndex - inOff));
				byte[] calculatedMacBlock = new byte[global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize];
				this.CalculateMac(output, outOff, outputLen, calculatedMacBlock);
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.macBlock, calculatedMacBlock))
				{
					throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("mac check in CCM failed");
				}
			}
			return outputLen;
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x000AF818 File Offset: 0x000ADA18
		private int CalculateMac(byte[] data, int dataOff, int dataLen, byte[] macBlock)
		{
			global::Org.BouncyCastle.Crypto.IMac cMac = new global::Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(this.cipher, this.macSize * 8);
			cMac.Init(this.keyParam);
			byte[] b0 = new byte[16];
			if (this.HasAssociatedText())
			{
				byte[] array = b0;
				int num = 0;
				array[num] |= 64;
			}
			byte[] array2 = b0;
			int num2 = 0;
			array2[num2] |= (byte)(((cMac.GetMacSize() - 2) / 2 & 7) << 3);
			byte[] array3 = b0;
			int num3 = 0;
			array3[num3] |= (byte)(15 - this.nonce.Length - 1 & 7);
			global::System.Array.Copy(this.nonce, 0, b0, 1, this.nonce.Length);
			int q = dataLen;
			int count = 1;
			while (q > 0)
			{
				b0[b0.Length - count] = (byte)(q & 255);
				q >>= 8;
				count++;
			}
			cMac.BlockUpdate(b0, 0, b0.Length);
			if (this.HasAssociatedText())
			{
				int textLength = this.GetAssociatedTextLength();
				int extra;
				if (textLength < 65280)
				{
					cMac.Update((byte)(textLength >> 8));
					cMac.Update((byte)textLength);
					extra = 2;
				}
				else
				{
					cMac.Update(byte.MaxValue);
					cMac.Update(254);
					cMac.Update((byte)(textLength >> 24));
					cMac.Update((byte)(textLength >> 16));
					cMac.Update((byte)(textLength >> 8));
					cMac.Update((byte)textLength);
					extra = 6;
				}
				if (this.initialAssociatedText != null)
				{
					cMac.BlockUpdate(this.initialAssociatedText, 0, this.initialAssociatedText.Length);
				}
				if (this.associatedText.Position > 0L)
				{
					byte[] input = this.associatedText.GetBuffer();
					int len = (int)this.associatedText.Position;
					cMac.BlockUpdate(input, 0, len);
				}
				extra = (extra + textLength) % 16;
				if (extra != 0)
				{
					for (int i = extra; i < 16; i++)
					{
						cMac.Update(0);
					}
				}
			}
			cMac.BlockUpdate(data, dataOff, dataLen);
			return cMac.DoFinal(macBlock, 0);
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x000AF9E1 File Offset: 0x000ADBE1
		private int GetMacSize(bool forEncryption, int requestedMacBits)
		{
			if (forEncryption && (requestedMacBits < 32 || requestedMacBits > 128 || (requestedMacBits & 15) != 0))
			{
				throw new global::System.ArgumentException("tag length in octets must be one of {4,6,8,10,12,14,16}");
			}
			return requestedMacBits >> 3;
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x000AFA07 File Offset: 0x000ADC07
		private int GetAssociatedTextLength()
		{
			return (int)this.associatedText.Length + ((this.initialAssociatedText == null) ? 0 : this.initialAssociatedText.Length);
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x000AFA29 File Offset: 0x000ADC29
		private bool HasAssociatedText()
		{
			return this.GetAssociatedTextLength() > 0;
		}

		// Token: 0x040010BF RID: 4287
		private static readonly int BlockSize = 16;

		// Token: 0x040010C0 RID: 4288
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher cipher;

		// Token: 0x040010C1 RID: 4289
		private readonly byte[] macBlock;

		// Token: 0x040010C2 RID: 4290
		private bool forEncryption;

		// Token: 0x040010C3 RID: 4291
		private byte[] nonce;

		// Token: 0x040010C4 RID: 4292
		private byte[] initialAssociatedText;

		// Token: 0x040010C5 RID: 4293
		private int macSize;

		// Token: 0x040010C6 RID: 4294
		private global::Org.BouncyCastle.Crypto.ICipherParameters keyParam;

		// Token: 0x040010C7 RID: 4295
		private readonly global::System.IO.MemoryStream associatedText = new global::System.IO.MemoryStream();

		// Token: 0x040010C8 RID: 4296
		private readonly global::System.IO.MemoryStream data = new global::System.IO.MemoryStream();
	}
}
