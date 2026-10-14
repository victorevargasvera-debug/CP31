using System;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000434 RID: 1076
	public class ChaCha20Poly1305 : global::Org.BouncyCastle.Crypto.Modes.IAeadCipher
	{
		// Token: 0x0600296B RID: 10603 RVA: 0x000AFD61 File Offset: 0x000ADF61
		public ChaCha20Poly1305() : this(new global::Org.BouncyCastle.Crypto.Macs.Poly1305())
		{
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x000AFD70 File Offset: 0x000ADF70
		public ChaCha20Poly1305(global::Org.BouncyCastle.Crypto.IMac poly1305)
		{
			if (poly1305 == null)
			{
				throw new global::System.ArgumentNullException("poly1305");
			}
			if (16 != poly1305.GetMacSize())
			{
				throw new global::System.ArgumentException("must be a 128-bit MAC", "poly1305");
			}
			this.mChacha20 = new global::Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine();
			this.mPoly1305 = poly1305;
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600296D RID: 10605 RVA: 0x000AFDF1 File Offset: 0x000ADFF1
		public virtual string AlgorithmName
		{
			get
			{
				return "ChaCha20Poly1305";
			}
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x000AFDF8 File Offset: 0x000ADFF8
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter initKeyParam;
			byte[] initNonce;
			global::Org.BouncyCastle.Crypto.ICipherParameters chacha20Params;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.AeadParameters aeadParams = (global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)parameters;
				int macSizeBits = aeadParams.MacSize;
				if (128 != macSizeBits)
				{
					throw new global::System.ArgumentException("Invalid value for MAC size: " + macSizeBits.ToString());
				}
				initKeyParam = aeadParams.Key;
				initNonce = aeadParams.GetNonce();
				chacha20Params = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(initKeyParam, initNonce);
				this.mInitialAad = aeadParams.GetAssociatedText();
			}
			else
			{
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV))
				{
					throw new global::System.ArgumentException("invalid parameters passed to ChaCha20Poly1305", "parameters");
				}
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV parametersWithIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				initKeyParam = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parametersWithIV.Parameters;
				initNonce = parametersWithIV.GetIV();
				chacha20Params = parametersWithIV;
				this.mInitialAad = null;
			}
			if (initKeyParam == null)
			{
				if (this.mState == global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.Uninitialized)
				{
					throw new global::System.ArgumentException("Key must be specified in initial init");
				}
			}
			else if (32 != initKeyParam.GetKey().Length)
			{
				throw new global::System.ArgumentException("Key must be 256 bits");
			}
			if (initNonce == null || 12 != initNonce.Length)
			{
				throw new global::System.ArgumentException("Nonce must be 96 bits");
			}
			if (this.mState > global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.Uninitialized && forEncryption && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.mNonce, initNonce) && (initKeyParam == null || global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.mKey, initKeyParam.GetKey())))
			{
				throw new global::System.ArgumentException("cannot reuse nonce for ChaCha20Poly1305 encryption");
			}
			if (initKeyParam != null)
			{
				global::System.Array.Copy(initKeyParam.GetKey(), 0, this.mKey, 0, 32);
			}
			global::System.Array.Copy(initNonce, 0, this.mNonce, 0, 12);
			this.mChacha20.Init(true, chacha20Params);
			this.mState = (forEncryption ? global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncInit : global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecInit);
			this.Reset(true, false);
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x000AFF64 File Offset: 0x000AE164
		public virtual int GetOutputSize(int len)
		{
			int total = global::System.Math.Max(0, len) + this.mBufPos;
			global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State state = this.mState;
			if (state - global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncInit <= 2)
			{
				return total + 16;
			}
			if (state - global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecInit <= 2)
			{
				return global::System.Math.Max(0, total - 16);
			}
			throw new global::System.InvalidOperationException();
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x000AFFA8 File Offset: 0x000AE1A8
		public virtual int GetUpdateOutputSize(int len)
		{
			int total = global::System.Math.Max(0, len) + this.mBufPos;
			global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State state = this.mState;
			if (state - global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncInit > 2)
			{
				if (state - global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecInit > 2)
				{
					throw new global::System.InvalidOperationException();
				}
				total = global::System.Math.Max(0, total - 16);
			}
			return total - total % 64;
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x000AFFF0 File Offset: 0x000AE1F0
		public virtual void ProcessAadByte(byte input)
		{
			this.CheckAad();
			this.mAadCount = this.IncrementCount(this.mAadCount, 1U, ulong.MaxValue);
			this.mPoly1305.Update(input);
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x000B001C File Offset: 0x000AE21C
		public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
		{
			if (inBytes == null)
			{
				throw new global::System.ArgumentNullException("inBytes");
			}
			if (inOff < 0)
			{
				throw new global::System.ArgumentException("cannot be negative", "inOff");
			}
			if (len < 0)
			{
				throw new global::System.ArgumentException("cannot be negative", "len");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(inBytes, inOff, len, "input buffer too short");
			this.CheckAad();
			if (len > 0)
			{
				this.mAadCount = this.IncrementCount(this.mAadCount, (uint)len, ulong.MaxValue);
				this.mPoly1305.BlockUpdate(inBytes, inOff, len);
			}
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x000B009C File Offset: 0x000AE29C
		public virtual int ProcessByte(byte input, byte[] outBytes, int outOff)
		{
			this.CheckData();
			global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State state = this.mState;
			if (state != global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncData)
			{
				if (state != global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecData)
				{
					throw new global::System.InvalidOperationException();
				}
				this.mBuf[this.mBufPos] = input;
				int num = this.mBufPos + 1;
				this.mBufPos = num;
				if (num == this.mBuf.Length)
				{
					this.mPoly1305.BlockUpdate(this.mBuf, 0, 64);
					this.ProcessData(this.mBuf, 0, 64, outBytes, outOff);
					global::System.Array.Copy(this.mBuf, 64, this.mBuf, 0, 16);
					this.mBufPos = 16;
					return 64;
				}
				return 0;
			}
			else
			{
				this.mBuf[this.mBufPos] = input;
				int num = this.mBufPos + 1;
				this.mBufPos = num;
				if (num == 64)
				{
					this.ProcessData(this.mBuf, 0, 64, outBytes, outOff);
					this.mPoly1305.BlockUpdate(outBytes, outOff, 64);
					this.mBufPos = 0;
					return 64;
				}
				return 0;
			}
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x000B0188 File Offset: 0x000AE388
		public virtual int ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff)
		{
			if (inBytes == null)
			{
				throw new global::System.ArgumentNullException("inBytes");
			}
			if (inOff < 0)
			{
				throw new global::System.ArgumentException("cannot be negative", "inOff");
			}
			if (len < 0)
			{
				throw new global::System.ArgumentException("cannot be negative", "len");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(inBytes, inOff, len, "input buffer too short");
			if (outOff < 0)
			{
				throw new global::System.ArgumentException("cannot be negative", "outOff");
			}
			this.CheckData();
			int resultLen = 0;
			global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State state = this.mState;
			if (state != global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncData)
			{
				if (state != global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecData)
				{
					throw new global::System.InvalidOperationException();
				}
				for (int i = 0; i < len; i++)
				{
					this.mBuf[this.mBufPos] = inBytes[inOff + i];
					int num = this.mBufPos + 1;
					this.mBufPos = num;
					if (num == this.mBuf.Length)
					{
						this.mPoly1305.BlockUpdate(this.mBuf, 0, 64);
						this.ProcessData(this.mBuf, 0, 64, outBytes, outOff + resultLen);
						global::System.Array.Copy(this.mBuf, 64, this.mBuf, 0, 16);
						this.mBufPos = 16;
						resultLen += 64;
					}
				}
			}
			else
			{
				if (this.mBufPos != 0)
				{
					while (len > 0)
					{
						len--;
						this.mBuf[this.mBufPos] = inBytes[inOff++];
						int num = this.mBufPos + 1;
						this.mBufPos = num;
						if (num == 64)
						{
							this.ProcessData(this.mBuf, 0, 64, outBytes, outOff);
							this.mPoly1305.BlockUpdate(outBytes, outOff, 64);
							this.mBufPos = 0;
							resultLen = 64;
							break;
						}
					}
				}
				while (len >= 64)
				{
					this.ProcessData(inBytes, inOff, 64, outBytes, outOff + resultLen);
					this.mPoly1305.BlockUpdate(outBytes, outOff + resultLen, 64);
					inOff += 64;
					len -= 64;
					resultLen += 64;
				}
				if (len > 0)
				{
					global::System.Array.Copy(inBytes, inOff, this.mBuf, 0, len);
					this.mBufPos = len;
				}
			}
			return resultLen;
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x000B0368 File Offset: 0x000AE568
		public virtual int DoFinal(byte[] outBytes, int outOff)
		{
			if (outBytes == null)
			{
				throw new global::System.ArgumentNullException("outBytes");
			}
			if (outOff < 0)
			{
				throw new global::System.ArgumentException("cannot be negative", "outOff");
			}
			this.CheckData();
			global::System.Array.Clear(this.mMac, 0, 16);
			global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State state = this.mState;
			int resultLen;
			if (state != global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncData)
			{
				if (state != global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecData)
				{
					throw new global::System.InvalidOperationException();
				}
				if (this.mBufPos < 16)
				{
					throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("data too short");
				}
				resultLen = this.mBufPos - 16;
				global::Org.BouncyCastle.Crypto.Check.OutputLength(outBytes, outOff, resultLen, "output buffer too short");
				if (resultLen > 0)
				{
					this.mPoly1305.BlockUpdate(this.mBuf, 0, resultLen);
					this.ProcessData(this.mBuf, 0, resultLen, outBytes, outOff);
				}
				this.FinishData(global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecFinal);
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(16, this.mMac, 0, this.mBuf, resultLen))
				{
					throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("mac check in ChaCha20Poly1305 failed");
				}
			}
			else
			{
				resultLen = this.mBufPos + 16;
				global::Org.BouncyCastle.Crypto.Check.OutputLength(outBytes, outOff, resultLen, "output buffer too short");
				if (this.mBufPos > 0)
				{
					this.ProcessData(this.mBuf, 0, this.mBufPos, outBytes, outOff);
					this.mPoly1305.BlockUpdate(outBytes, outOff, this.mBufPos);
				}
				this.FinishData(global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncFinal);
				global::System.Array.Copy(this.mMac, 0, outBytes, outOff + this.mBufPos, 16);
			}
			this.Reset(false, true);
			return resultLen;
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x000B04B5 File Offset: 0x000AE6B5
		public virtual byte[] GetMac()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.mMac);
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000B04C2 File Offset: 0x000AE6C2
		public virtual void Reset()
		{
			this.Reset(true, true);
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000B04CC File Offset: 0x000AE6CC
		private void CheckAad()
		{
			switch (this.mState)
			{
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncInit:
				this.mState = global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncAad;
				return;
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncAad:
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecAad:
				return;
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncFinal:
				throw new global::System.InvalidOperationException("ChaCha20Poly1305 cannot be reused for encryption");
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecInit:
				this.mState = global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecAad;
				return;
			}
			throw new global::System.InvalidOperationException();
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000B0524 File Offset: 0x000AE724
		private void CheckData()
		{
			switch (this.mState)
			{
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncInit:
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncAad:
				this.FinishAad(global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncData);
				return;
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncData:
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecData:
				return;
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncFinal:
				throw new global::System.InvalidOperationException("ChaCha20Poly1305 cannot be reused for encryption");
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecInit:
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecAad:
				this.FinishAad(global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecData);
				return;
			default:
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000B057F File Offset: 0x000AE77F
		private void FinishAad(global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State nextState)
		{
			this.PadMac(this.mAadCount);
			this.mState = nextState;
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000B0594 File Offset: 0x000AE794
		private void FinishData(global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State nextState)
		{
			this.PadMac(this.mDataCount);
			byte[] lengths = new byte[16];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(this.mAadCount, lengths, 0);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(this.mDataCount, lengths, 8);
			this.mPoly1305.BlockUpdate(lengths, 0, 16);
			this.mPoly1305.DoFinal(this.mMac, 0);
			this.mState = nextState;
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000B05F8 File Offset: 0x000AE7F8
		private ulong IncrementCount(ulong count, uint increment, ulong limit)
		{
			if (count > limit - (ulong)increment)
			{
				throw new global::System.InvalidOperationException("Limit exceeded");
			}
			return count + (ulong)increment;
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x000B0610 File Offset: 0x000AE810
		private void InitMac()
		{
			byte[] firstBlock = new byte[64];
			try
			{
				this.mChacha20.ProcessBytes(firstBlock, 0, 64, firstBlock, 0);
				this.mPoly1305.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(firstBlock, 0, 32));
			}
			finally
			{
				global::System.Array.Clear(firstBlock, 0, 64);
			}
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x000B0668 File Offset: 0x000AE868
		private void PadMac(ulong count)
		{
			int partial = (int)count & 15;
			if (partial != 0)
			{
				this.mPoly1305.BlockUpdate(global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.Zeroes, 0, 16 - partial);
			}
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x000B0693 File Offset: 0x000AE893
		private void ProcessData(byte[] inBytes, int inOff, int inLen, byte[] outBytes, int outOff)
		{
			global::Org.BouncyCastle.Crypto.Check.OutputLength(outBytes, outOff, inLen, "output buffer too short");
			this.mChacha20.ProcessBytes(inBytes, inOff, inLen, outBytes, outOff);
			this.mDataCount = this.IncrementCount(this.mDataCount, (uint)inLen, 274877906880UL);
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x000B06D4 File Offset: 0x000AE8D4
		private void Reset(bool clearMac, bool resetCipher)
		{
			global::System.Array.Clear(this.mBuf, 0, this.mBuf.Length);
			if (clearMac)
			{
				global::System.Array.Clear(this.mMac, 0, this.mMac.Length);
			}
			this.mAadCount = 0UL;
			this.mDataCount = 0UL;
			this.mBufPos = 0;
			switch (this.mState)
			{
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncInit:
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecInit:
				break;
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncAad:
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncData:
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncFinal:
				this.mState = global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.EncFinal;
				return;
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecAad:
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecData:
			case global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecFinal:
				this.mState = global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State.DecInit;
				break;
			default:
				throw new global::System.InvalidOperationException();
			}
			if (resetCipher)
			{
				this.mChacha20.Reset();
			}
			this.InitMac();
			if (this.mInitialAad != null)
			{
				this.ProcessAadBytes(this.mInitialAad, 0, this.mInitialAad.Length);
			}
		}

		// Token: 0x040010CF RID: 4303
		private const int BufSize = 64;

		// Token: 0x040010D0 RID: 4304
		private const int KeySize = 32;

		// Token: 0x040010D1 RID: 4305
		private const int NonceSize = 12;

		// Token: 0x040010D2 RID: 4306
		private const int MacSize = 16;

		// Token: 0x040010D3 RID: 4307
		private static readonly byte[] Zeroes = new byte[15];

		// Token: 0x040010D4 RID: 4308
		private const ulong AadLimit = 18446744073709551615UL;

		// Token: 0x040010D5 RID: 4309
		private const ulong DataLimit = 274877906880UL;

		// Token: 0x040010D6 RID: 4310
		private readonly global::Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine mChacha20;

		// Token: 0x040010D7 RID: 4311
		private readonly global::Org.BouncyCastle.Crypto.IMac mPoly1305;

		// Token: 0x040010D8 RID: 4312
		private readonly byte[] mKey = new byte[32];

		// Token: 0x040010D9 RID: 4313
		private readonly byte[] mNonce = new byte[12];

		// Token: 0x040010DA RID: 4314
		private readonly byte[] mBuf = new byte[80];

		// Token: 0x040010DB RID: 4315
		private readonly byte[] mMac = new byte[16];

		// Token: 0x040010DC RID: 4316
		private byte[] mInitialAad;

		// Token: 0x040010DD RID: 4317
		private ulong mAadCount;

		// Token: 0x040010DE RID: 4318
		private ulong mDataCount;

		// Token: 0x040010DF RID: 4319
		private global::Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305.State mState;

		// Token: 0x040010E0 RID: 4320
		private int mBufPos;

		// Token: 0x0200080C RID: 2060
		private enum State
		{
			// Token: 0x040024CA RID: 9418
			Uninitialized,
			// Token: 0x040024CB RID: 9419
			EncInit,
			// Token: 0x040024CC RID: 9420
			EncAad,
			// Token: 0x040024CD RID: 9421
			EncData,
			// Token: 0x040024CE RID: 9422
			EncFinal,
			// Token: 0x040024CF RID: 9423
			DecInit,
			// Token: 0x040024D0 RID: 9424
			DecAad,
			// Token: 0x040024D1 RID: 9425
			DecData,
			// Token: 0x040024D2 RID: 9426
			DecFinal
		}
	}
}
