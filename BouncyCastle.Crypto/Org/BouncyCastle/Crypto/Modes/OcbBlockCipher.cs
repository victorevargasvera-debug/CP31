using System;
using System.Collections;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x0200043E RID: 1086
	public class OcbBlockCipher : global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher, global::Org.BouncyCastle.Crypto.Modes.IAeadCipher
	{
		// Token: 0x06002A11 RID: 10769 RVA: 0x000B3BF4 File Offset: 0x000B1DF4
		public OcbBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher hashCipher, global::Org.BouncyCastle.Crypto.IBlockCipher mainCipher)
		{
			if (hashCipher == null)
			{
				throw new global::System.ArgumentNullException("hashCipher");
			}
			if (hashCipher.GetBlockSize() != 16)
			{
				throw new global::System.ArgumentException("must have a block size of " + 16.ToString(), "hashCipher");
			}
			if (mainCipher == null)
			{
				throw new global::System.ArgumentNullException("mainCipher");
			}
			if (mainCipher.GetBlockSize() != 16)
			{
				throw new global::System.ArgumentException("must have a block size of " + 16.ToString(), "mainCipher");
			}
			if (!hashCipher.AlgorithmName.Equals(mainCipher.AlgorithmName))
			{
				throw new global::System.ArgumentException("'hashCipher' and 'mainCipher' must be the same algorithm");
			}
			this.hashCipher = hashCipher;
			this.mainCipher = mainCipher;
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x000B3CC8 File Offset: 0x000B1EC8
		public virtual global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
		{
			return this.mainCipher;
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x000B3CD0 File Offset: 0x000B1ED0
		public virtual string AlgorithmName
		{
			get
			{
				return this.mainCipher.AlgorithmName + "/OCB";
			}
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x000B3CE8 File Offset: 0x000B1EE8
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			bool oldForEncryption = this.forEncryption;
			this.forEncryption = forEncryption;
			this.macBlock = null;
			byte[] N;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter keyParameter;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.AeadParameters aeadParameters = (global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)parameters;
				N = aeadParameters.GetNonce();
				this.initialAssociatedText = aeadParameters.GetAssociatedText();
				int macSizeBits = aeadParameters.MacSize;
				if (macSizeBits < 64 || macSizeBits > 128 || macSizeBits % 8 != 0)
				{
					throw new global::System.ArgumentException("Invalid value for MAC size: " + macSizeBits.ToString());
				}
				this.macSize = macSizeBits / 8;
				keyParameter = aeadParameters.Key;
			}
			else
			{
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV))
				{
					throw new global::System.ArgumentException("invalid parameters passed to OCB");
				}
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV parametersWithIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				N = parametersWithIV.GetIV();
				this.initialAssociatedText = null;
				this.macSize = 16;
				keyParameter = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parametersWithIV.Parameters;
			}
			this.hashBlock = new byte[16];
			this.mainBlock = new byte[forEncryption ? 16 : (16 + this.macSize)];
			if (N == null)
			{
				N = new byte[0];
			}
			if (N.Length > 15)
			{
				throw new global::System.ArgumentException("IV must be no more than 15 bytes");
			}
			if (keyParameter != null)
			{
				this.hashCipher.Init(true, keyParameter);
				this.mainCipher.Init(forEncryption, keyParameter);
				this.KtopInput = null;
			}
			else if (oldForEncryption != forEncryption)
			{
				throw new global::System.ArgumentException("cannot change encrypting state without providing key.");
			}
			this.L_Asterisk = new byte[16];
			this.hashCipher.ProcessBlock(this.L_Asterisk, 0, this.L_Asterisk, 0);
			this.L_Dollar = global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_double(this.L_Asterisk);
			this.L = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			this.L.Add(global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_double(this.L_Dollar));
			int num = this.ProcessNonce(N);
			int bits = num % 8;
			int bytes = num / 8;
			if (bits == 0)
			{
				global::System.Array.Copy(this.Stretch, bytes, this.OffsetMAIN_0, 0, 16);
			}
			else
			{
				for (int i = 0; i < 16; i++)
				{
					uint b = (uint)this.Stretch[bytes];
					uint b2 = (uint)this.Stretch[++bytes];
					this.OffsetMAIN_0[i] = (byte)(b << bits | b2 >> 8 - bits);
				}
			}
			this.hashBlockPos = 0;
			this.mainBlockPos = 0;
			this.hashBlockCount = 0L;
			this.mainBlockCount = 0L;
			this.OffsetHASH = new byte[16];
			this.Sum = new byte[16];
			global::System.Array.Copy(this.OffsetMAIN_0, 0, this.OffsetMAIN, 0, 16);
			this.Checksum = new byte[16];
			if (this.initialAssociatedText != null)
			{
				this.ProcessAadBytes(this.initialAssociatedText, 0, this.initialAssociatedText.Length);
			}
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x000B3F70 File Offset: 0x000B2170
		protected virtual int ProcessNonce(byte[] N)
		{
			byte[] nonce = new byte[16];
			global::System.Array.Copy(N, 0, nonce, nonce.Length - N.Length, N.Length);
			nonce[0] = (byte)(this.macSize << 4);
			byte[] array = nonce;
			int num = 15 - N.Length;
			array[num] |= 1;
			int bottom = (int)(nonce[15] & 63);
			byte[] array2 = nonce;
			int num2 = 15;
			array2[num2] &= 192;
			if (this.KtopInput == null || !global::Org.BouncyCastle.Utilities.Arrays.AreEqual(nonce, this.KtopInput))
			{
				byte[] Ktop = new byte[16];
				this.KtopInput = nonce;
				this.hashCipher.ProcessBlock(this.KtopInput, 0, Ktop, 0);
				global::System.Array.Copy(Ktop, 0, this.Stretch, 0, 16);
				for (int i = 0; i < 8; i++)
				{
					this.Stretch[16 + i] = (Ktop[i] ^ Ktop[i + 1]);
				}
			}
			return bottom;
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x000B403B File Offset: 0x000B223B
		public virtual int GetBlockSize()
		{
			return 16;
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x000B403F File Offset: 0x000B223F
		public virtual byte[] GetMac()
		{
			if (this.macBlock != null)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.macBlock);
			}
			return new byte[this.macSize];
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x000B4060 File Offset: 0x000B2260
		public virtual int GetOutputSize(int len)
		{
			int totalData = len + this.mainBlockPos;
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

		// Token: 0x06002A19 RID: 10777 RVA: 0x000B409C File Offset: 0x000B229C
		public virtual int GetUpdateOutputSize(int len)
		{
			int totalData = len + this.mainBlockPos;
			if (!this.forEncryption)
			{
				if (totalData < this.macSize)
				{
					return 0;
				}
				totalData -= this.macSize;
			}
			return totalData - totalData % 16;
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x000B40D4 File Offset: 0x000B22D4
		public virtual void ProcessAadByte(byte input)
		{
			this.hashBlock[this.hashBlockPos] = input;
			int num = this.hashBlockPos + 1;
			this.hashBlockPos = num;
			if (num == this.hashBlock.Length)
			{
				this.ProcessHashBlock();
			}
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000B4110 File Offset: 0x000B2310
		public virtual void ProcessAadBytes(byte[] input, int off, int len)
		{
			for (int i = 0; i < len; i++)
			{
				this.hashBlock[this.hashBlockPos] = input[off + i];
				int num = this.hashBlockPos + 1;
				this.hashBlockPos = num;
				if (num == this.hashBlock.Length)
				{
					this.ProcessHashBlock();
				}
			}
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000B415C File Offset: 0x000B235C
		public virtual int ProcessByte(byte input, byte[] output, int outOff)
		{
			this.mainBlock[this.mainBlockPos] = input;
			int num = this.mainBlockPos + 1;
			this.mainBlockPos = num;
			if (num == this.mainBlock.Length)
			{
				this.ProcessMainBlock(output, outOff);
				return 16;
			}
			return 0;
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x000B41A0 File Offset: 0x000B23A0
		public virtual int ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
			int resultLen = 0;
			for (int i = 0; i < len; i++)
			{
				this.mainBlock[this.mainBlockPos] = input[inOff + i];
				int num = this.mainBlockPos + 1;
				this.mainBlockPos = num;
				if (num == this.mainBlock.Length)
				{
					this.ProcessMainBlock(output, outOff + resultLen);
					resultLen += 16;
				}
			}
			return resultLen;
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x000B41FC File Offset: 0x000B23FC
		public virtual int DoFinal(byte[] output, int outOff)
		{
			byte[] tag = null;
			if (!this.forEncryption)
			{
				if (this.mainBlockPos < this.macSize)
				{
					throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("data too short");
				}
				this.mainBlockPos -= this.macSize;
				tag = new byte[this.macSize];
				global::System.Array.Copy(this.mainBlock, this.mainBlockPos, tag, 0, this.macSize);
			}
			if (this.hashBlockPos > 0)
			{
				global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_extend(this.hashBlock, this.hashBlockPos);
				this.UpdateHASH(this.L_Asterisk);
			}
			if (this.mainBlockPos > 0)
			{
				if (this.forEncryption)
				{
					global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_extend(this.mainBlock, this.mainBlockPos);
					global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.Checksum, this.mainBlock);
				}
				global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.OffsetMAIN, this.L_Asterisk);
				byte[] Pad = new byte[16];
				this.hashCipher.ProcessBlock(this.OffsetMAIN, 0, Pad, 0);
				global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.mainBlock, Pad);
				global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, this.mainBlockPos, "Output buffer too short");
				global::System.Array.Copy(this.mainBlock, 0, output, outOff, this.mainBlockPos);
				if (!this.forEncryption)
				{
					global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_extend(this.mainBlock, this.mainBlockPos);
					global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.Checksum, this.mainBlock);
				}
			}
			global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.Checksum, this.OffsetMAIN);
			global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.Checksum, this.L_Dollar);
			this.hashCipher.ProcessBlock(this.Checksum, 0, this.Checksum, 0);
			global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.Checksum, this.Sum);
			this.macBlock = new byte[this.macSize];
			global::System.Array.Copy(this.Checksum, 0, this.macBlock, 0, this.macSize);
			int resultLen = this.mainBlockPos;
			if (this.forEncryption)
			{
				global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, resultLen + this.macSize, "Output buffer too short");
				global::System.Array.Copy(this.macBlock, 0, output, outOff + resultLen, this.macSize);
				resultLen += this.macSize;
			}
			else if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.macBlock, tag))
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("mac check in OCB failed");
			}
			this.Reset(false);
			return resultLen;
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x000B4426 File Offset: 0x000B2626
		public virtual void Reset()
		{
			this.Reset(true);
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x000B442F File Offset: 0x000B262F
		protected virtual void Clear(byte[] bs)
		{
			if (bs != null)
			{
				global::System.Array.Clear(bs, 0, bs.Length);
			}
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x000B4440 File Offset: 0x000B2640
		protected virtual byte[] GetLSub(int n)
		{
			while (n >= this.L.Count)
			{
				this.L.Add(global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_double((byte[])this.L[this.L.Count - 1]));
			}
			return (byte[])this.L[n];
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x000B449C File Offset: 0x000B269C
		protected virtual void ProcessHashBlock()
		{
			long x = this.hashBlockCount + 1L;
			this.hashBlockCount = x;
			this.UpdateHASH(this.GetLSub(global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_ntz(x)));
			this.hashBlockPos = 0;
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x000B44D4 File Offset: 0x000B26D4
		protected virtual void ProcessMainBlock(byte[] output, int outOff)
		{
			global::Org.BouncyCastle.Crypto.Check.DataLength(output, outOff, 16, "Output buffer too short");
			if (this.forEncryption)
			{
				global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.Checksum, this.mainBlock);
				this.mainBlockPos = 0;
			}
			byte[] offsetMAIN = this.OffsetMAIN;
			long x = this.mainBlockCount + 1L;
			this.mainBlockCount = x;
			global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(offsetMAIN, this.GetLSub(global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_ntz(x)));
			global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.mainBlock, this.OffsetMAIN);
			this.mainCipher.ProcessBlock(this.mainBlock, 0, this.mainBlock, 0);
			global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.mainBlock, this.OffsetMAIN);
			global::System.Array.Copy(this.mainBlock, 0, output, outOff, 16);
			if (!this.forEncryption)
			{
				global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.Checksum, this.mainBlock);
				global::System.Array.Copy(this.mainBlock, 16, this.mainBlock, 0, this.macSize);
				this.mainBlockPos = this.macSize;
			}
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x000B45C4 File Offset: 0x000B27C4
		protected virtual void Reset(bool clearMac)
		{
			this.hashCipher.Reset();
			this.mainCipher.Reset();
			this.Clear(this.hashBlock);
			this.Clear(this.mainBlock);
			this.hashBlockPos = 0;
			this.mainBlockPos = 0;
			this.hashBlockCount = 0L;
			this.mainBlockCount = 0L;
			this.Clear(this.OffsetHASH);
			this.Clear(this.Sum);
			global::System.Array.Copy(this.OffsetMAIN_0, 0, this.OffsetMAIN, 0, 16);
			this.Clear(this.Checksum);
			if (clearMac)
			{
				this.macBlock = null;
			}
			if (this.initialAssociatedText != null)
			{
				this.ProcessAadBytes(this.initialAssociatedText, 0, this.initialAssociatedText.Length);
			}
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x000B4680 File Offset: 0x000B2880
		protected virtual void UpdateHASH(byte[] LSub)
		{
			global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.OffsetHASH, LSub);
			global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.hashBlock, this.OffsetHASH);
			this.hashCipher.ProcessBlock(this.hashBlock, 0, this.hashBlock, 0);
			global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(this.Sum, this.hashBlock);
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x000B46D8 File Offset: 0x000B28D8
		protected static byte[] OCB_double(byte[] block)
		{
			byte[] result = new byte[16];
			int carry = global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.ShiftLeft(block, result);
			byte[] array = result;
			int num = 15;
			array[num] ^= (byte)(135 >> (1 - carry << 3));
			return result;
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x000B4712 File Offset: 0x000B2912
		protected static void OCB_extend(byte[] block, int pos)
		{
			block[pos] = 128;
			while (++pos < 16)
			{
				block[pos] = 0;
			}
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x000B472C File Offset: 0x000B292C
		protected static int OCB_ntz(long x)
		{
			if (x == 0L)
			{
				return 64;
			}
			int i = 0;
			ulong ux = (ulong)x;
			while ((ux & 1UL) == 0UL)
			{
				i++;
				ux >>= 1;
			}
			return i;
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x000B4754 File Offset: 0x000B2954
		protected static int ShiftLeft(byte[] block, byte[] output)
		{
			int i = 16;
			uint bit = 0U;
			while (--i >= 0)
			{
				uint b = (uint)block[i];
				output[i] = (byte)(b << 1 | bit);
				bit = (b >> 7 & 1U);
			}
			return (int)bit;
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x000B4784 File Offset: 0x000B2984
		protected static void Xor(byte[] block, byte[] val)
		{
			for (int i = 15; i >= 0; i--)
			{
				int num = i;
				block[num] ^= val[i];
			}
		}

		// Token: 0x0400113E RID: 4414
		private const int BLOCK_SIZE = 16;

		// Token: 0x0400113F RID: 4415
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher hashCipher;

		// Token: 0x04001140 RID: 4416
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher mainCipher;

		// Token: 0x04001141 RID: 4417
		private bool forEncryption;

		// Token: 0x04001142 RID: 4418
		private int macSize;

		// Token: 0x04001143 RID: 4419
		private byte[] initialAssociatedText;

		// Token: 0x04001144 RID: 4420
		private global::System.Collections.IList L;

		// Token: 0x04001145 RID: 4421
		private byte[] L_Asterisk;

		// Token: 0x04001146 RID: 4422
		private byte[] L_Dollar;

		// Token: 0x04001147 RID: 4423
		private byte[] KtopInput;

		// Token: 0x04001148 RID: 4424
		private byte[] Stretch = new byte[24];

		// Token: 0x04001149 RID: 4425
		private byte[] OffsetMAIN_0 = new byte[16];

		// Token: 0x0400114A RID: 4426
		private byte[] hashBlock;

		// Token: 0x0400114B RID: 4427
		private byte[] mainBlock;

		// Token: 0x0400114C RID: 4428
		private int hashBlockPos;

		// Token: 0x0400114D RID: 4429
		private int mainBlockPos;

		// Token: 0x0400114E RID: 4430
		private long hashBlockCount;

		// Token: 0x0400114F RID: 4431
		private long mainBlockCount;

		// Token: 0x04001150 RID: 4432
		private byte[] OffsetHASH;

		// Token: 0x04001151 RID: 4433
		private byte[] Sum;

		// Token: 0x04001152 RID: 4434
		private byte[] OffsetMAIN = new byte[16];

		// Token: 0x04001153 RID: 4435
		private byte[] Checksum;

		// Token: 0x04001154 RID: 4436
		private byte[] macBlock;
	}
}
