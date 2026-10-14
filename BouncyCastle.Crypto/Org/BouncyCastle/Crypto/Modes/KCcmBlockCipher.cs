using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x0200043C RID: 1084
	public class KCcmBlockCipher : global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher, global::Org.BouncyCastle.Crypto.Modes.IAeadCipher
	{
		// Token: 0x060029ED RID: 10733 RVA: 0x000B2DE1 File Offset: 0x000B0FE1
		private void setNb(int Nb)
		{
			if (Nb == 4 || Nb == 6 || Nb == 8)
			{
				this.Nb_ = Nb;
				return;
			}
			throw new global::System.ArgumentException("Nb = 4 is recommended by DSTU7624 but can be changed to only 6 or 8 in this implementation");
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x000B2E01 File Offset: 0x000B1001
		public KCcmBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher engine) : this(engine, 4)
		{
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x000B2E0C File Offset: 0x000B100C
		public KCcmBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher engine, int Nb)
		{
			this.engine = engine;
			this.macSize = engine.GetBlockSize();
			this.nonce = new byte[engine.GetBlockSize()];
			this.initialAssociatedText = new byte[engine.GetBlockSize()];
			this.mac = new byte[engine.GetBlockSize()];
			this.macBlock = new byte[engine.GetBlockSize()];
			this.G1 = new byte[engine.GetBlockSize()];
			this.buffer = new byte[engine.GetBlockSize()];
			this.s = new byte[engine.GetBlockSize()];
			this.counter = new byte[engine.GetBlockSize()];
			this.setNb(Nb);
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x000B2EE0 File Offset: 0x000B10E0
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.AeadParameters param = (global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)parameters;
				if (param.MacSize > global::Org.BouncyCastle.Crypto.Modes.KCcmBlockCipher.MAX_MAC_BIT_LENGTH || param.MacSize < global::Org.BouncyCastle.Crypto.Modes.KCcmBlockCipher.MIN_MAC_BIT_LENGTH || param.MacSize % 8 != 0)
				{
					throw new global::System.ArgumentException("Invalid mac size specified");
				}
				this.nonce = param.GetNonce();
				this.macSize = param.MacSize / global::Org.BouncyCastle.Crypto.Modes.KCcmBlockCipher.BITS_IN_BYTE;
				this.initialAssociatedText = param.GetAssociatedText();
				cipherParameters = param.Key;
			}
			else
			{
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV))
				{
					throw new global::System.ArgumentException("Invalid parameters specified");
				}
				this.nonce = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters).GetIV();
				this.macSize = this.engine.GetBlockSize();
				this.initialAssociatedText = null;
				cipherParameters = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters).Parameters;
			}
			this.mac = new byte[this.macSize];
			this.forEncryption = forEncryption;
			this.engine.Init(true, cipherParameters);
			this.counter[0] = 1;
			if (this.initialAssociatedText != null)
			{
				this.ProcessAadBytes(this.initialAssociatedText, 0, this.initialAssociatedText.Length);
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x000B2FF3 File Offset: 0x000B11F3
		public virtual string AlgorithmName
		{
			get
			{
				return this.engine.AlgorithmName + "/KCCM";
			}
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x000B300A File Offset: 0x000B120A
		public virtual int GetBlockSize()
		{
			return this.engine.GetBlockSize();
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x000B3017 File Offset: 0x000B1217
		public virtual global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
		{
			return this.engine;
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x000B301F File Offset: 0x000B121F
		public virtual void ProcessAadByte(byte input)
		{
			this.associatedText.WriteByte(input);
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x000B302D File Offset: 0x000B122D
		public virtual void ProcessAadBytes(byte[] input, int inOff, int len)
		{
			this.associatedText.Write(input, inOff, len);
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x000B3040 File Offset: 0x000B1240
		private void ProcessAAD(byte[] assocText, int assocOff, int assocLen, int dataLen)
		{
			if (assocLen - assocOff < this.engine.GetBlockSize())
			{
				throw new global::System.ArgumentException("authText buffer too short");
			}
			if (assocLen % this.engine.GetBlockSize() != 0)
			{
				throw new global::System.ArgumentException("padding not supported");
			}
			global::System.Array.Copy(this.nonce, 0, this.G1, 0, this.nonce.Length - this.Nb_ - 1);
			this.intToBytes(dataLen, this.buffer, 0);
			global::System.Array.Copy(this.buffer, 0, this.G1, this.nonce.Length - this.Nb_ - 1, global::Org.BouncyCastle.Crypto.Modes.KCcmBlockCipher.BYTES_IN_INT);
			this.G1[this.G1.Length - 1] = this.getFlag(true, this.macSize);
			this.engine.ProcessBlock(this.G1, 0, this.macBlock, 0);
			this.intToBytes(assocLen, this.buffer, 0);
			if (assocLen <= this.engine.GetBlockSize() - this.Nb_)
			{
				for (int byteIndex = 0; byteIndex < assocLen; byteIndex++)
				{
					byte[] array = this.buffer;
					int num = byteIndex + this.Nb_;
					array[num] ^= assocText[assocOff + byteIndex];
				}
				for (int byteIndex2 = 0; byteIndex2 < this.engine.GetBlockSize(); byteIndex2++)
				{
					byte[] array2 = this.macBlock;
					int num2 = byteIndex2;
					array2[num2] ^= this.buffer[byteIndex2];
				}
				this.engine.ProcessBlock(this.macBlock, 0, this.macBlock, 0);
				return;
			}
			for (int byteIndex3 = 0; byteIndex3 < this.engine.GetBlockSize(); byteIndex3++)
			{
				byte[] array3 = this.macBlock;
				int num3 = byteIndex3;
				array3[num3] ^= this.buffer[byteIndex3];
			}
			this.engine.ProcessBlock(this.macBlock, 0, this.macBlock, 0);
			for (int authLen = assocLen; authLen != 0; authLen -= this.engine.GetBlockSize())
			{
				for (int byteIndex4 = 0; byteIndex4 < this.engine.GetBlockSize(); byteIndex4++)
				{
					byte[] array4 = this.macBlock;
					int num4 = byteIndex4;
					array4[num4] ^= assocText[byteIndex4 + assocOff];
				}
				this.engine.ProcessBlock(this.macBlock, 0, this.macBlock, 0);
				assocOff += this.engine.GetBlockSize();
			}
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000B3264 File Offset: 0x000B1464
		public virtual int ProcessByte(byte input, byte[] output, int outOff)
		{
			this.data.WriteByte(input);
			return 0;
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x000B3273 File Offset: 0x000B1473
		public virtual int ProcessBytes(byte[] input, int inOff, int inLen, byte[] output, int outOff)
		{
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, inLen, "input buffer too short");
			this.data.Write(input, inOff, inLen);
			return 0;
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x000B3294 File Offset: 0x000B1494
		public int ProcessPacket(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, len, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, len, "output buffer too short");
			if (this.associatedText.Length > 0L)
			{
				byte[] aad = this.associatedText.GetBuffer();
				int aadLen = (int)this.associatedText.Length;
				int dataLen = this.forEncryption ? ((int)this.data.Length) : ((int)this.data.Length - this.macSize);
				this.ProcessAAD(aad, 0, aadLen, dataLen);
			}
			if (this.forEncryption)
			{
				global::Org.BouncyCastle.Crypto.Check.DataLength(len % this.engine.GetBlockSize() != 0, "partial blocks not supported");
				this.CalculateMac(input, inOff, len);
				this.engine.ProcessBlock(this.nonce, 0, this.s, 0);
				int totalLength = len;
				while (totalLength > 0)
				{
					this.ProcessBlock(input, inOff, len, output, outOff);
					totalLength -= this.engine.GetBlockSize();
					inOff += this.engine.GetBlockSize();
					outOff += this.engine.GetBlockSize();
				}
				for (int byteIndex = 0; byteIndex < this.counter.Length; byteIndex++)
				{
					byte[] array = this.s;
					int num = byteIndex;
					array[num] += this.counter[byteIndex];
				}
				this.engine.ProcessBlock(this.s, 0, this.buffer, 0);
				for (int byteIndex2 = 0; byteIndex2 < this.macSize; byteIndex2++)
				{
					output[outOff + byteIndex2] = (this.buffer[byteIndex2] ^ this.macBlock[byteIndex2]);
				}
				global::System.Array.Copy(this.macBlock, 0, this.mac, 0, this.macSize);
				this.Reset();
				return len + this.macSize;
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength((len - this.macSize) % this.engine.GetBlockSize() != 0, "partial blocks not supported");
			this.engine.ProcessBlock(this.nonce, 0, this.s, 0);
			int blocks = len / this.engine.GetBlockSize();
			for (int blockNum = 0; blockNum < blocks; blockNum++)
			{
				this.ProcessBlock(input, inOff, len, output, outOff);
				inOff += this.engine.GetBlockSize();
				outOff += this.engine.GetBlockSize();
			}
			if (len > inOff)
			{
				for (int byteIndex3 = 0; byteIndex3 < this.counter.Length; byteIndex3++)
				{
					byte[] array2 = this.s;
					int num2 = byteIndex3;
					array2[num2] += this.counter[byteIndex3];
				}
				this.engine.ProcessBlock(this.s, 0, this.buffer, 0);
				for (int byteIndex4 = 0; byteIndex4 < this.macSize; byteIndex4++)
				{
					output[outOff + byteIndex4] = (this.buffer[byteIndex4] ^ input[inOff + byteIndex4]);
				}
				outOff += this.macSize;
			}
			for (int byteIndex5 = 0; byteIndex5 < this.counter.Length; byteIndex5++)
			{
				byte[] array3 = this.s;
				int num3 = byteIndex5;
				array3[num3] += this.counter[byteIndex5];
			}
			this.engine.ProcessBlock(this.s, 0, this.buffer, 0);
			global::System.Array.Copy(output, outOff - this.macSize, this.buffer, 0, this.macSize);
			this.CalculateMac(output, 0, outOff - this.macSize);
			global::System.Array.Copy(this.macBlock, 0, this.mac, 0, this.macSize);
			byte[] calculatedMac = new byte[this.macSize];
			global::System.Array.Copy(this.buffer, 0, calculatedMac, 0, this.macSize);
			if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.mac, calculatedMac))
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("mac check failed");
			}
			this.Reset();
			return len - this.macSize;
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x000B363C File Offset: 0x000B183C
		private void ProcessBlock(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
			for (int byteIndex = 0; byteIndex < this.counter.Length; byteIndex++)
			{
				byte[] array = this.s;
				int num = byteIndex;
				array[num] += this.counter[byteIndex];
			}
			this.engine.ProcessBlock(this.s, 0, this.buffer, 0);
			for (int byteIndex2 = 0; byteIndex2 < this.engine.GetBlockSize(); byteIndex2++)
			{
				output[outOff + byteIndex2] = (this.buffer[byteIndex2] ^ input[inOff + byteIndex2]);
			}
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x000B36BC File Offset: 0x000B18BC
		private void CalculateMac(byte[] authText, int authOff, int len)
		{
			int totalLen = len;
			while (totalLen > 0)
			{
				for (int byteIndex = 0; byteIndex < this.engine.GetBlockSize(); byteIndex++)
				{
					byte[] array = this.macBlock;
					int num = byteIndex;
					array[num] ^= authText[authOff + byteIndex];
				}
				this.engine.ProcessBlock(this.macBlock, 0, this.macBlock, 0);
				totalLen -= this.engine.GetBlockSize();
				authOff += this.engine.GetBlockSize();
			}
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x000B3734 File Offset: 0x000B1934
		public virtual int DoFinal(byte[] output, int outOff)
		{
			byte[] buf = this.data.GetBuffer();
			int bufLen = (int)this.data.Length;
			int result = this.ProcessPacket(buf, 0, bufLen, output, outOff);
			this.Reset();
			return result;
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x000B376B File Offset: 0x000B196B
		public virtual byte[] GetMac()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.mac);
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x000B3778 File Offset: 0x000B1978
		public virtual int GetUpdateOutputSize(int len)
		{
			return len;
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x000B377B File Offset: 0x000B197B
		public virtual int GetOutputSize(int len)
		{
			return len + this.macSize;
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x000B3788 File Offset: 0x000B1988
		public virtual void Reset()
		{
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.G1, 0);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.buffer, 0);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.counter, 0);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.macBlock, 0);
			this.counter[0] = 1;
			this.data.SetLength(0L);
			this.associatedText.SetLength(0L);
			if (this.initialAssociatedText != null)
			{
				this.ProcessAadBytes(this.initialAssociatedText, 0, this.initialAssociatedText.Length);
			}
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x000B3805 File Offset: 0x000B1A05
		private void intToBytes(int num, byte[] outBytes, int outOff)
		{
			outBytes[outOff + 3] = (byte)(num >> 24);
			outBytes[outOff + 2] = (byte)(num >> 16);
			outBytes[outOff + 1] = (byte)(num >> 8);
			outBytes[outOff] = (byte)num;
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x000B382C File Offset: 0x000B1A2C
		private byte getFlag(bool authTextPresents, int macSize)
		{
			global::System.Text.StringBuilder flagByte = new global::System.Text.StringBuilder();
			if (authTextPresents)
			{
				flagByte.Append("1");
			}
			else
			{
				flagByte.Append("0");
			}
			if (macSize <= 16)
			{
				if (macSize != 8)
				{
					if (macSize == 16)
					{
						flagByte.Append("011");
					}
				}
				else
				{
					flagByte.Append("010");
				}
			}
			else if (macSize != 32)
			{
				if (macSize != 48)
				{
					if (macSize == 64)
					{
						flagByte.Append("110");
					}
				}
				else
				{
					flagByte.Append("101");
				}
			}
			else
			{
				flagByte.Append("100");
			}
			string binaryNb = global::System.Convert.ToString(this.Nb_ - 1, 2);
			while (binaryNb.Length < 4)
			{
				binaryNb = new global::System.Text.StringBuilder(binaryNb).Insert(0, "0").ToString();
			}
			flagByte.Append(binaryNb);
			return (byte)global::System.Convert.ToInt32(flagByte.ToString(), 2);
		}

		// Token: 0x04001125 RID: 4389
		private static readonly int BYTES_IN_INT = 4;

		// Token: 0x04001126 RID: 4390
		private static readonly int BITS_IN_BYTE = 8;

		// Token: 0x04001127 RID: 4391
		private static readonly int MAX_MAC_BIT_LENGTH = 512;

		// Token: 0x04001128 RID: 4392
		private static readonly int MIN_MAC_BIT_LENGTH = 64;

		// Token: 0x04001129 RID: 4393
		private global::Org.BouncyCastle.Crypto.IBlockCipher engine;

		// Token: 0x0400112A RID: 4394
		private int macSize;

		// Token: 0x0400112B RID: 4395
		private bool forEncryption;

		// Token: 0x0400112C RID: 4396
		private byte[] initialAssociatedText;

		// Token: 0x0400112D RID: 4397
		private byte[] mac;

		// Token: 0x0400112E RID: 4398
		private byte[] macBlock;

		// Token: 0x0400112F RID: 4399
		private byte[] nonce;

		// Token: 0x04001130 RID: 4400
		private byte[] G1;

		// Token: 0x04001131 RID: 4401
		private byte[] buffer;

		// Token: 0x04001132 RID: 4402
		private byte[] s;

		// Token: 0x04001133 RID: 4403
		private byte[] counter;

		// Token: 0x04001134 RID: 4404
		private readonly global::System.IO.MemoryStream associatedText = new global::System.IO.MemoryStream();

		// Token: 0x04001135 RID: 4405
		private readonly global::System.IO.MemoryStream data = new global::System.IO.MemoryStream();

		// Token: 0x04001136 RID: 4406
		private int Nb_ = 4;
	}
}
