using System;
using Org.BouncyCastle.Crypto.Modes.Gcm;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000437 RID: 1079
	public class GcmBlockCipher : global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher, global::Org.BouncyCastle.Crypto.Modes.IAeadCipher
	{
		// Token: 0x0600299B RID: 10651 RVA: 0x000B1269 File Offset: 0x000AF469
		public GcmBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher c) : this(c, null)
		{
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x000B1274 File Offset: 0x000AF474
		public GcmBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher c, global::Org.BouncyCastle.Crypto.Modes.Gcm.IGcmMultiplier m)
		{
			if (c.GetBlockSize() != 16)
			{
				throw new global::System.ArgumentException("cipher required with a block size of " + 16.ToString() + ".");
			}
			if (m == null)
			{
				m = new global::Org.BouncyCastle.Crypto.Modes.Gcm.Tables4kGcmMultiplier();
			}
			this.cipher = c;
			this.multiplier = m;
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x000B12C8 File Offset: 0x000AF4C8
		public virtual string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName + "/GCM";
			}
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x000B12DF File Offset: 0x000AF4DF
		public global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
		{
			return this.cipher;
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x000B12E7 File Offset: 0x000AF4E7
		public virtual int GetBlockSize()
		{
			return 16;
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x000B12EC File Offset: 0x000AF4EC
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forEncryption = forEncryption;
			this.macBlock = null;
			this.initialised = true;
			byte[] newNonce;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter keyParam;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.AeadParameters param = (global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)parameters;
				newNonce = param.GetNonce();
				this.initialAssociatedText = param.GetAssociatedText();
				int macSizeBits = param.MacSize;
				if (macSizeBits < 32 || macSizeBits > 128 || macSizeBits % 8 != 0)
				{
					throw new global::System.ArgumentException("Invalid value for MAC size: " + macSizeBits.ToString());
				}
				this.macSize = macSizeBits / 8;
				keyParam = param.Key;
			}
			else
			{
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV))
				{
					throw new global::System.ArgumentException("invalid parameters passed to GCM");
				}
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV parametersWithIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				newNonce = parametersWithIV.GetIV();
				this.initialAssociatedText = null;
				this.macSize = 16;
				keyParam = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parametersWithIV.Parameters;
			}
			int bufLength = forEncryption ? 16 : (16 + this.macSize);
			this.bufBlock = new byte[bufLength];
			if (newNonce == null || newNonce.Length < 1)
			{
				throw new global::System.ArgumentException("IV must be at least 1 byte");
			}
			if (forEncryption && this.nonce != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.nonce, newNonce))
			{
				if (keyParam == null)
				{
					throw new global::System.ArgumentException("cannot reuse nonce for GCM encryption");
				}
				if (this.lastKey != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.lastKey, keyParam.GetKey()))
				{
					throw new global::System.ArgumentException("cannot reuse nonce for GCM encryption");
				}
			}
			this.nonce = newNonce;
			if (keyParam != null)
			{
				this.lastKey = keyParam.GetKey();
			}
			if (keyParam != null)
			{
				this.cipher.Init(true, keyParam);
				this.H = new byte[16];
				this.cipher.ProcessBlock(this.H, 0, this.H, 0);
				this.multiplier.Init(this.H);
				this.exp = null;
			}
			else if (this.H == null)
			{
				throw new global::System.ArgumentException("Key must be specified in initial init");
			}
			this.J0 = new byte[16];
			if (this.nonce.Length == 12)
			{
				global::System.Array.Copy(this.nonce, 0, this.J0, 0, this.nonce.Length);
				this.J0[15] = 1;
			}
			else
			{
				this.gHASH(this.J0, this.nonce, this.nonce.Length);
				byte[] X = new byte[16];
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE((ulong)((long)this.nonce.Length * 8L), X, 8);
				this.gHASHBlock(this.J0, X);
			}
			this.S = new byte[16];
			this.S_at = new byte[16];
			this.S_atPre = new byte[16];
			this.atBlock = new byte[16];
			this.atBlockPos = 0;
			this.atLength = 0UL;
			this.atLengthPre = 0UL;
			this.counter = global::Org.BouncyCastle.Utilities.Arrays.Clone(this.J0);
			this.blocksRemaining = 4294967294U;
			this.bufOff = 0;
			this.totalLength = 0UL;
			if (this.initialAssociatedText != null)
			{
				this.ProcessAadBytes(this.initialAssociatedText, 0, this.initialAssociatedText.Length);
			}
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x000B15C2 File Offset: 0x000AF7C2
		public virtual byte[] GetMac()
		{
			if (this.macBlock != null)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.macBlock);
			}
			return new byte[this.macSize];
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x000B15E4 File Offset: 0x000AF7E4
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

		// Token: 0x060029A3 RID: 10659 RVA: 0x000B1620 File Offset: 0x000AF820
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
			return totalData - totalData % 16;
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x000B1658 File Offset: 0x000AF858
		public virtual void ProcessAadByte(byte input)
		{
			this.CheckStatus();
			this.atBlock[this.atBlockPos] = input;
			int num = this.atBlockPos + 1;
			this.atBlockPos = num;
			if (num == 16)
			{
				this.gHASHBlock(this.S_at, this.atBlock);
				this.atBlockPos = 0;
				this.atLength += 16UL;
			}
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000B16B8 File Offset: 0x000AF8B8
		public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
		{
			this.CheckStatus();
			for (int i = 0; i < len; i++)
			{
				this.atBlock[this.atBlockPos] = inBytes[inOff + i];
				int num = this.atBlockPos + 1;
				this.atBlockPos = num;
				if (num == 16)
				{
					this.gHASHBlock(this.S_at, this.atBlock);
					this.atBlockPos = 0;
					this.atLength += 16UL;
				}
			}
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000B1728 File Offset: 0x000AF928
		private void InitCipher()
		{
			if (this.atLength > 0UL)
			{
				global::System.Array.Copy(this.S_at, 0, this.S_atPre, 0, 16);
				this.atLengthPre = this.atLength;
			}
			if (this.atBlockPos > 0)
			{
				this.gHASHPartial(this.S_atPre, this.atBlock, 0, this.atBlockPos);
				this.atLengthPre += (ulong)this.atBlockPos;
			}
			if (this.atLengthPre > 0UL)
			{
				global::System.Array.Copy(this.S_atPre, 0, this.S, 0, 16);
			}
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x000B17B8 File Offset: 0x000AF9B8
		public virtual int ProcessByte(byte input, byte[] output, int outOff)
		{
			this.CheckStatus();
			this.bufBlock[this.bufOff] = input;
			int num = this.bufOff + 1;
			this.bufOff = num;
			if (num == this.bufBlock.Length)
			{
				this.ProcessBlock(this.bufBlock, 0, output, outOff);
				if (this.forEncryption)
				{
					this.bufOff = 0;
				}
				else
				{
					global::System.Array.Copy(this.bufBlock, 16, this.bufBlock, 0, this.macSize);
					this.bufOff = this.macSize;
				}
				return 16;
			}
			return 0;
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x000B1840 File Offset: 0x000AFA40
		public virtual int ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
			this.CheckStatus();
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, len, "input buffer too short");
			int resultLen = 0;
			if (this.forEncryption)
			{
				if (this.bufOff != 0)
				{
					while (len > 0)
					{
						len--;
						this.bufBlock[this.bufOff] = input[inOff++];
						int num = this.bufOff + 1;
						this.bufOff = num;
						if (num == 16)
						{
							this.ProcessBlock(this.bufBlock, 0, output, outOff);
							this.bufOff = 0;
							resultLen += 16;
							break;
						}
					}
				}
				while (len >= 16)
				{
					this.ProcessBlock(input, inOff, output, outOff + resultLen);
					inOff += 16;
					len -= 16;
					resultLen += 16;
				}
				if (len > 0)
				{
					global::System.Array.Copy(input, inOff, this.bufBlock, 0, len);
					this.bufOff = len;
				}
			}
			else
			{
				for (int i = 0; i < len; i++)
				{
					this.bufBlock[this.bufOff] = input[inOff + i];
					int num = this.bufOff + 1;
					this.bufOff = num;
					if (num == this.bufBlock.Length)
					{
						this.ProcessBlock(this.bufBlock, 0, output, outOff + resultLen);
						global::System.Array.Copy(this.bufBlock, 16, this.bufBlock, 0, this.macSize);
						this.bufOff = this.macSize;
						resultLen += 16;
					}
				}
			}
			return resultLen;
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x000B1988 File Offset: 0x000AFB88
		public int DoFinal(byte[] output, int outOff)
		{
			this.CheckStatus();
			if (this.totalLength == 0UL)
			{
				this.InitCipher();
			}
			int extra = this.bufOff;
			if (this.forEncryption)
			{
				global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, extra + this.macSize, "Output buffer too short");
			}
			else
			{
				if (extra < this.macSize)
				{
					throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("data too short");
				}
				extra -= this.macSize;
				global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, extra, "Output buffer too short");
			}
			if (extra > 0)
			{
				this.ProcessPartial(this.bufBlock, 0, extra, output, outOff);
			}
			this.atLength += (ulong)this.atBlockPos;
			if (this.atLength > this.atLengthPre)
			{
				if (this.atBlockPos > 0)
				{
					this.gHASHPartial(this.S_at, this.atBlock, 0, this.atBlockPos);
				}
				if (this.atLengthPre > 0UL)
				{
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(this.S_at, this.S_atPre);
				}
				long c = (long)(this.totalLength * 8UL + 127UL >> 7);
				byte[] H_c = new byte[16];
				if (this.exp == null)
				{
					this.exp = new global::Org.BouncyCastle.Crypto.Modes.Gcm.BasicGcmExponentiator();
					this.exp.Init(this.H);
				}
				this.exp.ExponentiateX(c, H_c);
				global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Multiply(this.S_at, H_c);
				global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(this.S, this.S_at);
			}
			byte[] X = new byte[16];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.atLength * 8UL, X, 0);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.totalLength * 8UL, X, 8);
			this.gHASHBlock(this.S, X);
			byte[] tag = new byte[16];
			this.cipher.ProcessBlock(this.J0, 0, tag, 0);
			global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(tag, this.S);
			int resultLen = extra;
			this.macBlock = new byte[this.macSize];
			global::System.Array.Copy(tag, 0, this.macBlock, 0, this.macSize);
			if (this.forEncryption)
			{
				global::System.Array.Copy(this.macBlock, 0, output, outOff + this.bufOff, this.macSize);
				resultLen += this.macSize;
			}
			else
			{
				byte[] msgMac = new byte[this.macSize];
				global::System.Array.Copy(this.bufBlock, extra, msgMac, 0, this.macSize);
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.macBlock, msgMac))
				{
					throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("mac check in GCM failed");
				}
			}
			this.Reset(false);
			return resultLen;
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x000B1BD0 File Offset: 0x000AFDD0
		public virtual void Reset()
		{
			this.Reset(true);
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x000B1BDC File Offset: 0x000AFDDC
		private void Reset(bool clearMac)
		{
			this.cipher.Reset();
			this.S = new byte[16];
			this.S_at = new byte[16];
			this.S_atPre = new byte[16];
			this.atBlock = new byte[16];
			this.atBlockPos = 0;
			this.atLength = 0UL;
			this.atLengthPre = 0UL;
			this.counter = global::Org.BouncyCastle.Utilities.Arrays.Clone(this.J0);
			this.blocksRemaining = 4294967294U;
			this.bufOff = 0;
			this.totalLength = 0UL;
			if (this.bufBlock != null)
			{
				global::Org.BouncyCastle.Utilities.Arrays.Fill(this.bufBlock, 0);
			}
			if (clearMac)
			{
				this.macBlock = null;
			}
			if (this.forEncryption)
			{
				this.initialised = false;
				return;
			}
			if (this.initialAssociatedText != null)
			{
				this.ProcessAadBytes(this.initialAssociatedText, 0, this.initialAssociatedText.Length);
			}
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x000B1CB4 File Offset: 0x000AFEB4
		private void ProcessBlock(byte[] buf, int bufOff, byte[] output, int outOff)
		{
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, 16, "Output buffer too short");
			if (this.totalLength == 0UL)
			{
				this.InitCipher();
			}
			byte[] ctrBlock = new byte[16];
			this.GetNextCtrBlock(ctrBlock);
			if (this.forEncryption)
			{
				global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(ctrBlock, buf, bufOff);
				this.gHASHBlock(this.S, ctrBlock);
				global::System.Array.Copy(ctrBlock, 0, output, outOff, 16);
			}
			else
			{
				this.gHASHBlock(this.S, buf, bufOff);
				global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(ctrBlock, 0, buf, bufOff, output, outOff);
			}
			this.totalLength += 16UL;
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x000B1D44 File Offset: 0x000AFF44
		private void ProcessPartial(byte[] buf, int off, int len, byte[] output, int outOff)
		{
			byte[] ctrBlock = new byte[16];
			this.GetNextCtrBlock(ctrBlock);
			if (this.forEncryption)
			{
				global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(buf, off, ctrBlock, 0, len);
				this.gHASHPartial(this.S, buf, off, len);
			}
			else
			{
				this.gHASHPartial(this.S, buf, off, len);
				global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(buf, off, ctrBlock, 0, len);
			}
			global::System.Array.Copy(buf, off, output, outOff, len);
			this.totalLength += (ulong)len;
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x000B1DB8 File Offset: 0x000AFFB8
		private void gHASH(byte[] Y, byte[] b, int len)
		{
			for (int pos = 0; pos < len; pos += 16)
			{
				int num = global::System.Math.Min(len - pos, 16);
				this.gHASHPartial(Y, b, pos, num);
			}
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x000B1DE7 File Offset: 0x000AFFE7
		private void gHASHBlock(byte[] Y, byte[] b)
		{
			global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(Y, b);
			this.multiplier.MultiplyH(Y);
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x000B1DFC File Offset: 0x000AFFFC
		private void gHASHBlock(byte[] Y, byte[] b, int off)
		{
			global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(Y, b, off);
			this.multiplier.MultiplyH(Y);
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x000B1E12 File Offset: 0x000B0012
		private void gHASHPartial(byte[] Y, byte[] b, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(Y, b, off, len);
			this.multiplier.MultiplyH(Y);
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x000B1E2C File Offset: 0x000B002C
		private void GetNextCtrBlock(byte[] block)
		{
			if (this.blocksRemaining == 0U)
			{
				throw new global::System.InvalidOperationException("Attempt to process too many blocks");
			}
			this.blocksRemaining -= 1U;
			uint c = 1U;
			c += (uint)this.counter[15];
			this.counter[15] = (byte)c;
			c >>= 8;
			c += (uint)this.counter[14];
			this.counter[14] = (byte)c;
			c >>= 8;
			c += (uint)this.counter[13];
			this.counter[13] = (byte)c;
			c >>= 8;
			c += (uint)this.counter[12];
			this.counter[12] = (byte)c;
			this.cipher.ProcessBlock(this.counter, 0, block, 0);
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x000B1ED9 File Offset: 0x000B00D9
		private void CheckStatus()
		{
			if (this.initialised)
			{
				return;
			}
			if (this.forEncryption)
			{
				throw new global::System.InvalidOperationException("GCM cipher cannot be reused for encryption");
			}
			throw new global::System.InvalidOperationException("GCM cipher needs to be initialised");
		}

		// Token: 0x040010EE RID: 4334
		private const int BlockSize = 16;

		// Token: 0x040010EF RID: 4335
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher cipher;

		// Token: 0x040010F0 RID: 4336
		private readonly global::Org.BouncyCastle.Crypto.Modes.Gcm.IGcmMultiplier multiplier;

		// Token: 0x040010F1 RID: 4337
		private global::Org.BouncyCastle.Crypto.Modes.Gcm.IGcmExponentiator exp;

		// Token: 0x040010F2 RID: 4338
		private bool forEncryption;

		// Token: 0x040010F3 RID: 4339
		private bool initialised;

		// Token: 0x040010F4 RID: 4340
		private int macSize;

		// Token: 0x040010F5 RID: 4341
		private byte[] lastKey;

		// Token: 0x040010F6 RID: 4342
		private byte[] nonce;

		// Token: 0x040010F7 RID: 4343
		private byte[] initialAssociatedText;

		// Token: 0x040010F8 RID: 4344
		private byte[] H;

		// Token: 0x040010F9 RID: 4345
		private byte[] J0;

		// Token: 0x040010FA RID: 4346
		private byte[] bufBlock;

		// Token: 0x040010FB RID: 4347
		private byte[] macBlock;

		// Token: 0x040010FC RID: 4348
		private byte[] S;

		// Token: 0x040010FD RID: 4349
		private byte[] S_at;

		// Token: 0x040010FE RID: 4350
		private byte[] S_atPre;

		// Token: 0x040010FF RID: 4351
		private byte[] counter;

		// Token: 0x04001100 RID: 4352
		private uint blocksRemaining;

		// Token: 0x04001101 RID: 4353
		private int bufOff;

		// Token: 0x04001102 RID: 4354
		private ulong totalLength;

		// Token: 0x04001103 RID: 4355
		private byte[] atBlock;

		// Token: 0x04001104 RID: 4356
		private int atBlockPos;

		// Token: 0x04001105 RID: 4357
		private ulong atLength;

		// Token: 0x04001106 RID: 4358
		private ulong atLengthPre;
	}
}
