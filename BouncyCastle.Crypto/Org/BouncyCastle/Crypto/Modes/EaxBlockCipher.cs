using System;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000436 RID: 1078
	public class EaxBlockCipher : global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher, global::Org.BouncyCastle.Crypto.Modes.IAeadCipher
	{
		// Token: 0x06002988 RID: 10632 RVA: 0x000B0B94 File Offset: 0x000AED94
		public EaxBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher)
		{
			this.blockSize = cipher.GetBlockSize();
			this.mac = new global::Org.BouncyCastle.Crypto.Macs.CMac(cipher);
			this.macBlock = new byte[this.blockSize];
			this.associatedTextMac = new byte[this.mac.GetMacSize()];
			this.nonceMac = new byte[this.mac.GetMacSize()];
			this.cipher = new global::Org.BouncyCastle.Crypto.Modes.SicBlockCipher(cipher);
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06002989 RID: 10633 RVA: 0x000B0C08 File Offset: 0x000AEE08
		public virtual string AlgorithmName
		{
			get
			{
				return this.cipher.GetUnderlyingCipher().AlgorithmName + "/EAX";
			}
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x000B0C24 File Offset: 0x000AEE24
		public virtual global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
		{
			return this.cipher;
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x000B0C2C File Offset: 0x000AEE2C
		public virtual int GetBlockSize()
		{
			return this.cipher.GetBlockSize();
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x000B0C3C File Offset: 0x000AEE3C
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forEncryption = forEncryption;
			byte[] nonce;
			global::Org.BouncyCastle.Crypto.ICipherParameters keyParam;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.AeadParameters param = (global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)parameters;
				nonce = param.GetNonce();
				this.initialAssociatedText = param.GetAssociatedText();
				this.macSize = param.MacSize / 8;
				keyParam = param.Key;
			}
			else
			{
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV))
				{
					throw new global::System.ArgumentException("invalid parameters passed to EAX");
				}
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV parametersWithIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				nonce = parametersWithIV.GetIV();
				this.initialAssociatedText = null;
				this.macSize = this.mac.GetMacSize() / 2;
				keyParam = parametersWithIV.Parameters;
			}
			this.bufBlock = new byte[forEncryption ? this.blockSize : (this.blockSize + this.macSize)];
			byte[] tag = new byte[this.blockSize];
			this.mac.Init(keyParam);
			tag[this.blockSize - 1] = 0;
			this.mac.BlockUpdate(tag, 0, this.blockSize);
			this.mac.BlockUpdate(nonce, 0, nonce.Length);
			this.mac.DoFinal(this.nonceMac, 0);
			this.cipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(null, this.nonceMac));
			this.Reset();
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x000B0D68 File Offset: 0x000AEF68
		private void InitCipher()
		{
			if (this.cipherInitialized)
			{
				return;
			}
			this.cipherInitialized = true;
			this.mac.DoFinal(this.associatedTextMac, 0);
			byte[] tag = new byte[this.blockSize];
			tag[this.blockSize - 1] = 2;
			this.mac.BlockUpdate(tag, 0, this.blockSize);
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x000B0DC4 File Offset: 0x000AEFC4
		private void CalculateMac()
		{
			byte[] outC = new byte[this.blockSize];
			this.mac.DoFinal(outC, 0);
			for (int i = 0; i < this.macBlock.Length; i++)
			{
				this.macBlock[i] = (this.nonceMac[i] ^ this.associatedTextMac[i] ^ outC[i]);
			}
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x000B0E1C File Offset: 0x000AF01C
		public virtual void Reset()
		{
			this.Reset(true);
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x000B0E28 File Offset: 0x000AF028
		private void Reset(bool clearMac)
		{
			this.cipher.Reset();
			this.mac.Reset();
			this.bufOff = 0;
			global::System.Array.Clear(this.bufBlock, 0, this.bufBlock.Length);
			if (clearMac)
			{
				global::System.Array.Clear(this.macBlock, 0, this.macBlock.Length);
			}
			byte[] tag = new byte[this.blockSize];
			tag[this.blockSize - 1] = 1;
			this.mac.BlockUpdate(tag, 0, this.blockSize);
			this.cipherInitialized = false;
			if (this.initialAssociatedText != null)
			{
				this.ProcessAadBytes(this.initialAssociatedText, 0, this.initialAssociatedText.Length);
			}
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x000B0ECB File Offset: 0x000AF0CB
		public virtual void ProcessAadByte(byte input)
		{
			if (this.cipherInitialized)
			{
				throw new global::System.InvalidOperationException("AAD data cannot be added after encryption/decryption processing has begun.");
			}
			this.mac.Update(input);
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x000B0EEC File Offset: 0x000AF0EC
		public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
		{
			if (this.cipherInitialized)
			{
				throw new global::System.InvalidOperationException("AAD data cannot be added after encryption/decryption processing has begun.");
			}
			this.mac.BlockUpdate(inBytes, inOff, len);
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x000B0F0F File Offset: 0x000AF10F
		public virtual int ProcessByte(byte input, byte[] outBytes, int outOff)
		{
			this.InitCipher();
			return this.Process(input, outBytes, outOff);
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x000B0F20 File Offset: 0x000AF120
		public virtual int ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff)
		{
			this.InitCipher();
			int resultLen = 0;
			for (int i = 0; i != len; i++)
			{
				resultLen += this.Process(inBytes[inOff + i], outBytes, outOff + resultLen);
			}
			return resultLen;
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000B0F58 File Offset: 0x000AF158
		public virtual int DoFinal(byte[] outBytes, int outOff)
		{
			this.InitCipher();
			int extra = this.bufOff;
			byte[] tmp = new byte[this.bufBlock.Length];
			this.bufOff = 0;
			if (this.forEncryption)
			{
				global::Org.BouncyCastle.Crypto.Check.OutputLength(outBytes, outOff, extra + this.macSize, "Output buffer too short");
				this.cipher.ProcessBlock(this.bufBlock, 0, tmp, 0);
				global::System.Array.Copy(tmp, 0, outBytes, outOff, extra);
				this.mac.BlockUpdate(tmp, 0, extra);
				this.CalculateMac();
				global::System.Array.Copy(this.macBlock, 0, outBytes, outOff + extra, this.macSize);
				this.Reset(false);
				return extra + this.macSize;
			}
			if (extra < this.macSize)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("data too short");
			}
			global::Org.BouncyCastle.Crypto.Check.OutputLength(outBytes, outOff, extra - this.macSize, "Output buffer too short");
			if (extra > this.macSize)
			{
				this.mac.BlockUpdate(this.bufBlock, 0, extra - this.macSize);
				this.cipher.ProcessBlock(this.bufBlock, 0, tmp, 0);
				global::System.Array.Copy(tmp, 0, outBytes, outOff, extra - this.macSize);
			}
			this.CalculateMac();
			if (!this.VerifyMac(this.bufBlock, extra - this.macSize))
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("mac check in EAX failed");
			}
			this.Reset(false);
			return extra - this.macSize;
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000B10A4 File Offset: 0x000AF2A4
		public virtual byte[] GetMac()
		{
			byte[] mac = new byte[this.macSize];
			global::System.Array.Copy(this.macBlock, 0, mac, 0, this.macSize);
			return mac;
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000B10D4 File Offset: 0x000AF2D4
		public virtual int GetUpdateOutputSize(int len)
		{
			int totalData = len + this.bufOff;
			if (!this.forEncryption)
			{
				if (totalData < this.macSize)
				{
					return 0;
				}
				totalData -= this.macSize;
			}
			return totalData - totalData % this.blockSize;
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000B1110 File Offset: 0x000AF310
		public virtual int GetOutputSize(int len)
		{
			int totalData = len + this.bufOff;
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

		// Token: 0x06002999 RID: 10649 RVA: 0x000B114C File Offset: 0x000AF34C
		private int Process(byte b, byte[] outBytes, int outOff)
		{
			byte[] array = this.bufBlock;
			int num = this.bufOff;
			this.bufOff = num + 1;
			array[num] = b;
			if (this.bufOff == this.bufBlock.Length)
			{
				global::Org.BouncyCastle.Crypto.Check.OutputLength(outBytes, outOff, this.blockSize, "Output buffer is too short");
				int size;
				if (this.forEncryption)
				{
					size = this.cipher.ProcessBlock(this.bufBlock, 0, outBytes, outOff);
					this.mac.BlockUpdate(outBytes, outOff, this.blockSize);
				}
				else
				{
					this.mac.BlockUpdate(this.bufBlock, 0, this.blockSize);
					size = this.cipher.ProcessBlock(this.bufBlock, 0, outBytes, outOff);
				}
				this.bufOff = 0;
				if (!this.forEncryption)
				{
					global::System.Array.Copy(this.bufBlock, this.blockSize, this.bufBlock, 0, this.macSize);
					this.bufOff = this.macSize;
				}
				return size;
			}
			return 0;
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000B1234 File Offset: 0x000AF434
		private bool VerifyMac(byte[] mac, int off)
		{
			int nonEqual = 0;
			for (int i = 0; i < this.macSize; i++)
			{
				nonEqual |= (int)(this.macBlock[i] ^ mac[off + i]);
			}
			return nonEqual == 0;
		}

		// Token: 0x040010E2 RID: 4322
		private global::Org.BouncyCastle.Crypto.Modes.SicBlockCipher cipher;

		// Token: 0x040010E3 RID: 4323
		private bool forEncryption;

		// Token: 0x040010E4 RID: 4324
		private int blockSize;

		// Token: 0x040010E5 RID: 4325
		private global::Org.BouncyCastle.Crypto.IMac mac;

		// Token: 0x040010E6 RID: 4326
		private byte[] nonceMac;

		// Token: 0x040010E7 RID: 4327
		private byte[] associatedTextMac;

		// Token: 0x040010E8 RID: 4328
		private byte[] macBlock;

		// Token: 0x040010E9 RID: 4329
		private int macSize;

		// Token: 0x040010EA RID: 4330
		private byte[] bufBlock;

		// Token: 0x040010EB RID: 4331
		private int bufOff;

		// Token: 0x040010EC RID: 4332
		private bool cipherInitialized;

		// Token: 0x040010ED RID: 4333
		private byte[] initialAssociatedText;

		// Token: 0x0200080D RID: 2061
		private enum Tag : byte
		{
			// Token: 0x040024D4 RID: 9428
			N,
			// Token: 0x040024D5 RID: 9429
			H,
			// Token: 0x040024D6 RID: 9430
			C
		}
	}
}
