using System;
using System.IO;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes.Gcm;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000438 RID: 1080
	public class GcmSivBlockCipher : global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher, global::Org.BouncyCastle.Crypto.Modes.IAeadCipher
	{
		// Token: 0x060029B4 RID: 10676 RVA: 0x000B1F01 File Offset: 0x000B0101
		public GcmSivBlockCipher() : this(new global::Org.BouncyCastle.Crypto.Engines.AesEngine())
		{
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000B1F0E File Offset: 0x000B010E
		public GcmSivBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher pCipher) : this(pCipher, new global::Org.BouncyCastle.Crypto.Modes.Gcm.Tables4kGcmMultiplier())
		{
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000B1F1C File Offset: 0x000B011C
		public GcmSivBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher pCipher, global::Org.BouncyCastle.Crypto.Modes.Gcm.IGcmMultiplier pMultiplier)
		{
			if (pCipher.GetBlockSize() != global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN)
			{
				throw new global::System.ArgumentException("Cipher required with a block size of " + global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN.ToString() + ".");
			}
			this.theCipher = pCipher;
			this.theMultiplier = pMultiplier;
			this.theAEADHasher = new global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.GcmSivHasher(this);
			this.theDataHasher = new global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.GcmSivHasher(this);
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000B1FA4 File Offset: 0x000B01A4
		public virtual global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
		{
			return this.theCipher;
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000B1FAC File Offset: 0x000B01AC
		public virtual int GetBlockSize()
		{
			return this.theCipher.GetBlockSize();
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x000B1FBC File Offset: 0x000B01BC
		public virtual void Init(bool pEncrypt, global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters)
		{
			byte[] myInitialAEAD = null;
			byte[] myNonce;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter myKey;
			if (cipherParameters is global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.AeadParameters aeadParameters = (global::Org.BouncyCastle.Crypto.Parameters.AeadParameters)cipherParameters;
				myInitialAEAD = aeadParameters.GetAssociatedText();
				myNonce = aeadParameters.GetNonce();
				myKey = aeadParameters.Key;
			}
			else
			{
				if (!(cipherParameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV))
				{
					throw new global::System.ArgumentException("invalid parameters passed to GCM_SIV");
				}
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV parametersWithIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)cipherParameters;
				myNonce = parametersWithIV.GetIV();
				myKey = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parametersWithIV.Parameters;
			}
			if (myNonce == null || myNonce.Length != global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.NONCELEN)
			{
				throw new global::System.ArgumentException("Invalid nonce");
			}
			if (myKey == null)
			{
				throw new global::System.ArgumentException("Invalid key");
			}
			byte[] i = myKey.GetKey();
			if (i.Length != global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN && i.Length != global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN << 1)
			{
				throw new global::System.ArgumentException("Invalid key");
			}
			this.forEncryption = pEncrypt;
			this.theInitialAEAD = myInitialAEAD;
			this.theNonce = myNonce;
			this.deriveKeys(myKey);
			this.ResetStreams();
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x000B2090 File Offset: 0x000B0290
		public virtual string AlgorithmName
		{
			get
			{
				return this.theCipher.AlgorithmName + "-GCM-SIV";
			}
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x000B20A8 File Offset: 0x000B02A8
		private void CheckAeadStatus(int pLen)
		{
			if ((this.theFlags & global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.INIT) == 0)
			{
				throw new global::System.InvalidOperationException("Cipher is not initialised");
			}
			if ((this.theFlags & global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.AEAD_COMPLETE) != 0)
			{
				throw new global::System.InvalidOperationException("AEAD data cannot be processed after ordinary data");
			}
			if (this.theAEADHasher.getBytesProcessed() + 9223372036854775808UL > (ulong)((long)(global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.MAX_DATALEN - pLen) + -9223372036854775808L))
			{
				throw new global::System.InvalidOperationException("AEAD byte count exceeded");
			}
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x000B211C File Offset: 0x000B031C
		private void CheckStatus(int pLen)
		{
			if ((this.theFlags & global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.INIT) == 0)
			{
				throw new global::System.InvalidOperationException("Cipher is not initialised");
			}
			if ((this.theFlags & global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.AEAD_COMPLETE) == 0)
			{
				this.theAEADHasher.completeHash();
				this.theFlags |= global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.AEAD_COMPLETE;
			}
			long dataLimit = (long)global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.MAX_DATALEN;
			long currBytes = this.thePlain.Length;
			if (!this.forEncryption)
			{
				dataLimit += (long)global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN;
				currBytes = this.theEncData.Length;
			}
			if (currBytes + -9223372036854775808L > dataLimit - (long)pLen + -9223372036854775808L)
			{
				throw new global::System.InvalidOperationException("byte count exceeded");
			}
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x000B21C3 File Offset: 0x000B03C3
		public virtual void ProcessAadByte(byte pByte)
		{
			this.CheckAeadStatus(1);
			this.theAEADHasher.updateHash(pByte);
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x000B21D8 File Offset: 0x000B03D8
		public virtual void ProcessAadBytes(byte[] pData, int pOffset, int pLen)
		{
			this.CheckAeadStatus(pLen);
			global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.CheckBuffer(pData, pOffset, pLen, false);
			this.theAEADHasher.updateHash(pData, pOffset, pLen);
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x000B21F8 File Offset: 0x000B03F8
		public virtual int ProcessByte(byte pByte, byte[] pOutput, int pOutOffset)
		{
			this.CheckStatus(1);
			if (this.forEncryption)
			{
				this.thePlain.WriteByte(pByte);
				this.theDataHasher.updateHash(pByte);
			}
			else
			{
				this.theEncData.WriteByte(pByte);
			}
			return 0;
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x000B2230 File Offset: 0x000B0430
		public virtual int ProcessBytes(byte[] pData, int pOffset, int pLen, byte[] pOutput, int pOutOffset)
		{
			this.CheckStatus(pLen);
			global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.CheckBuffer(pData, pOffset, pLen, false);
			if (this.forEncryption)
			{
				this.thePlain.Write(pData, pOffset, pLen);
				this.theDataHasher.updateHash(pData, pOffset, pLen);
			}
			else
			{
				this.theEncData.Write(pData, pOffset, pLen);
			}
			return 0;
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000B2284 File Offset: 0x000B0484
		public virtual int DoFinal(byte[] pOutput, int pOffset)
		{
			this.CheckStatus(0);
			global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.CheckBuffer(pOutput, pOffset, this.GetOutputSize(0), true);
			if (this.forEncryption)
			{
				byte[] myTag = this.calculateTag();
				int result = global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN + this.encryptPlain(myTag, pOutput, pOffset);
				global::System.Array.Copy(myTag, 0, pOutput, pOffset + (int)this.thePlain.Length, global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN);
				this.ResetStreams();
				return result;
			}
			this.decryptPlain();
			int result2 = global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(this.thePlain, pOutput, pOffset);
			this.ResetStreams();
			return result2;
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x000B2300 File Offset: 0x000B0500
		public virtual byte[] GetMac()
		{
			throw new global::System.InvalidOperationException();
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x000B2307 File Offset: 0x000B0507
		public virtual int GetUpdateOutputSize(int pLen)
		{
			return 0;
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x000B230C File Offset: 0x000B050C
		public virtual int GetOutputSize(int pLen)
		{
			if (this.forEncryption)
			{
				return (int)((long)pLen + this.thePlain.Length + (long)global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN);
			}
			int myCurr = (int)((long)pLen + this.theEncData.Length);
			if (myCurr <= global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN)
			{
				return 0;
			}
			return myCurr - global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN;
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000B2359 File Offset: 0x000B0559
		public virtual void Reset()
		{
			this.ResetStreams();
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x000B2364 File Offset: 0x000B0564
		private void ResetStreams()
		{
			if (this.thePlain != null)
			{
				this.thePlain.Position = 0L;
				global::Org.BouncyCastle.Utilities.IO.Streams.WriteZeroes(this.thePlain, (long)this.thePlain.Capacity);
			}
			this.theAEADHasher.Reset();
			this.theDataHasher.Reset();
			this.thePlain = new global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.GcmSivCache();
			this.theEncData = (this.forEncryption ? null : new global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.GcmSivCache());
			this.theFlags &= ~global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.AEAD_COMPLETE;
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.theGHash, 0);
			if (this.theInitialAEAD != null)
			{
				this.theAEADHasher.updateHash(this.theInitialAEAD, 0, this.theInitialAEAD.Length);
			}
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x000B2415 File Offset: 0x000B0615
		private static int bufLength(byte[] pBuffer)
		{
			if (pBuffer != null)
			{
				return pBuffer.Length;
			}
			return 0;
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x000B2420 File Offset: 0x000B0620
		private static void CheckBuffer(byte[] pBuffer, int pOffset, int pLen, bool pOutput)
		{
			int myBufLen = global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.bufLength(pBuffer);
			int myLast = pOffset + pLen;
			if (pLen < 0 || pOffset < 0 || myLast < 0 || myLast > myBufLen)
			{
				throw pOutput ? new global::Org.BouncyCastle.Crypto.OutputLengthException("Output buffer too short.") : new global::Org.BouncyCastle.Crypto.DataLengthException("Input buffer too short.");
			}
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000B2468 File Offset: 0x000B0668
		private int encryptPlain(byte[] pCounter, byte[] pTarget, int pOffset)
		{
			byte[] buffer = this.thePlain.GetBuffer();
			int thePlainLen = (int)this.thePlain.Length;
			byte[] mySrc = buffer;
			byte[] myCounter = global::Org.BouncyCastle.Utilities.Arrays.Clone(pCounter);
			byte[] array = myCounter;
			int num = global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN - 1;
			array[num] |= global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.MASK;
			byte[] myMask = new byte[global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN];
			long myRemaining = (long)thePlainLen;
			int myOff = 0;
			while (myRemaining > 0L)
			{
				this.theCipher.ProcessBlock(myCounter, 0, myMask, 0);
				int myLen = (int)global::System.Math.Min((long)global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN, myRemaining);
				global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.xorBlock(myMask, mySrc, myOff, myLen);
				global::System.Array.Copy(myMask, 0, pTarget, pOffset + myOff, myLen);
				myRemaining -= (long)myLen;
				myOff += myLen;
				global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.incrementCounter(myCounter);
			}
			return thePlainLen;
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x000B2518 File Offset: 0x000B0718
		private void decryptPlain()
		{
			byte[] theEncDataBuf = this.theEncData.GetBuffer();
			int num = (int)this.theEncData.Length;
			byte[] mySrc = theEncDataBuf;
			int myRemaining = num - global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN;
			if (myRemaining < 0)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("Data too short");
			}
			byte[] myExpected = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(mySrc, myRemaining, myRemaining + global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN);
			byte[] myCounter = global::Org.BouncyCastle.Utilities.Arrays.Clone(myExpected);
			byte[] array = myCounter;
			int num2 = global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN - 1;
			array[num2] |= global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.MASK;
			byte[] myMask = new byte[global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN];
			int myOff = 0;
			while (myRemaining > 0)
			{
				this.theCipher.ProcessBlock(myCounter, 0, myMask, 0);
				int myLen = global::System.Math.Min(global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN, myRemaining);
				global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.xorBlock(myMask, mySrc, myOff, myLen);
				this.thePlain.Write(myMask, 0, myLen);
				this.theDataHasher.updateHash(myMask, 0, myLen);
				myRemaining -= myLen;
				myOff += myLen;
				global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.incrementCounter(myCounter);
			}
			if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.calculateTag(), myExpected))
			{
				this.Reset();
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("mac check failed");
			}
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x000B2618 File Offset: 0x000B0818
		private byte[] calculateTag()
		{
			this.theDataHasher.completeHash();
			byte[] myPolyVal = this.completePolyVal();
			byte[] myResult = new byte[global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN];
			for (int i = 0; i < global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.NONCELEN; i++)
			{
				byte[] array = myPolyVal;
				int num = i;
				array[num] ^= this.theNonce[i];
			}
			byte[] array2 = myPolyVal;
			int num2 = global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN - 1;
			array2[num2] &= global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.MASK - 1;
			this.theCipher.ProcessBlock(myPolyVal, 0, myResult, 0);
			return myResult;
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x000B2694 File Offset: 0x000B0894
		private byte[] completePolyVal()
		{
			byte[] myResult = new byte[global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN];
			this.gHashLengths();
			global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.fillReverse(this.theGHash, 0, global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN, myResult);
			return myResult;
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x000B26C8 File Offset: 0x000B08C8
		private void gHashLengths()
		{
			byte[] myIn = new byte[global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(8UL * this.theDataHasher.getBytesProcessed(), myIn, 0);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(8UL * this.theAEADHasher.getBytesProcessed(), myIn, 8);
			this.gHASH(myIn);
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000B2711 File Offset: 0x000B0911
		private void gHASH(byte[] pNext)
		{
			global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.xorBlock(this.theGHash, pNext);
			this.theMultiplier.MultiplyH(this.theGHash);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000B2730 File Offset: 0x000B0930
		private static void fillReverse(byte[] pInput, int pOffset, int pLength, byte[] pOutput)
		{
			int i = 0;
			int j = global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN - 1;
			while (i < pLength)
			{
				pOutput[j] = pInput[pOffset + i];
				i++;
				j--;
			}
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000B2760 File Offset: 0x000B0960
		private static void xorBlock(byte[] pLeft, byte[] pRight)
		{
			for (int i = 0; i < global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN; i++)
			{
				int num = i;
				pLeft[num] ^= pRight[i];
			}
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000B278C File Offset: 0x000B098C
		private static void xorBlock(byte[] pLeft, byte[] pRight, int pOffset, int pLength)
		{
			for (int i = 0; i < pLength; i++)
			{
				int num = i;
				pLeft[num] ^= pRight[i + pOffset];
			}
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000B27B8 File Offset: 0x000B09B8
		private static void incrementCounter(byte[] pCounter)
		{
			for (int i = 0; i < 4; i++)
			{
				int num = i;
				byte b = pCounter[num] + 1;
				pCounter[num] = b;
				if (b != 0)
				{
					break;
				}
			}
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000B27E4 File Offset: 0x000B09E4
		private static void mulX(byte[] pValue)
		{
			byte myMask = 0;
			for (int i = 0; i < global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN; i++)
			{
				byte myValue = pValue[i];
				pValue[i] = (byte)((myValue >> 1 & (int)(~(int)global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.MASK)) | (int)myMask);
				myMask = (((myValue & 1) == 0) ? 0 : global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.MASK);
			}
			if (myMask != 0)
			{
				int num = 0;
				pValue[num] ^= global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.ADD;
			}
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x000B283C File Offset: 0x000B0A3C
		private void deriveKeys(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter pKey)
		{
			byte[] myIn = new byte[global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN];
			byte[] myOut = new byte[global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN];
			byte[] myResult = new byte[global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN];
			byte[] myEncKey = new byte[pKey.GetKey().Length];
			global::System.Array.Copy(this.theNonce, 0, myIn, global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN - global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.NONCELEN, global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.NONCELEN);
			this.theCipher.Init(true, pKey);
			int myOff = 0;
			this.theCipher.ProcessBlock(myIn, 0, myOut, 0);
			global::System.Array.Copy(myOut, 0, myResult, myOff, global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.HALFBUFLEN);
			byte[] array = myIn;
			int num = 0;
			array[num] += 1;
			myOff += global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.HALFBUFLEN;
			this.theCipher.ProcessBlock(myIn, 0, myOut, 0);
			global::System.Array.Copy(myOut, 0, myResult, myOff, global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.HALFBUFLEN);
			byte[] array2 = myIn;
			int num2 = 0;
			array2[num2] += 1;
			myOff = 0;
			this.theCipher.ProcessBlock(myIn, 0, myOut, 0);
			global::System.Array.Copy(myOut, 0, myEncKey, myOff, global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.HALFBUFLEN);
			byte[] array3 = myIn;
			int num3 = 0;
			array3[num3] += 1;
			myOff += global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.HALFBUFLEN;
			this.theCipher.ProcessBlock(myIn, 0, myOut, 0);
			global::System.Array.Copy(myOut, 0, myEncKey, myOff, global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.HALFBUFLEN);
			if (myEncKey.Length == global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN << 1)
			{
				byte[] array4 = myIn;
				int num4 = 0;
				array4[num4] += 1;
				myOff += global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.HALFBUFLEN;
				this.theCipher.ProcessBlock(myIn, 0, myOut, 0);
				global::System.Array.Copy(myOut, 0, myEncKey, myOff, global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.HALFBUFLEN);
				byte[] array5 = myIn;
				int num5 = 0;
				array5[num5] += 1;
				myOff += global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.HALFBUFLEN;
				this.theCipher.ProcessBlock(myIn, 0, myOut, 0);
				global::System.Array.Copy(myOut, 0, myEncKey, myOff, global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.HALFBUFLEN);
			}
			this.theCipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(myEncKey));
			global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.fillReverse(myResult, 0, global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN, myOut);
			global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.mulX(myOut);
			this.theMultiplier.Init(myOut);
			this.theFlags |= global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.INIT;
		}

		// Token: 0x04001107 RID: 4359
		private static readonly int BUFLEN = 16;

		// Token: 0x04001108 RID: 4360
		private static readonly int HALFBUFLEN = global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN >> 1;

		// Token: 0x04001109 RID: 4361
		private static readonly int NONCELEN = 12;

		// Token: 0x0400110A RID: 4362
		private static readonly int MAX_DATALEN = 2147483639 - global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN;

		// Token: 0x0400110B RID: 4363
		private static readonly byte MASK = 128;

		// Token: 0x0400110C RID: 4364
		private static readonly byte ADD = 225;

		// Token: 0x0400110D RID: 4365
		private static readonly int INIT = 1;

		// Token: 0x0400110E RID: 4366
		private static readonly int AEAD_COMPLETE = 2;

		// Token: 0x0400110F RID: 4367
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher theCipher;

		// Token: 0x04001110 RID: 4368
		private readonly global::Org.BouncyCastle.Crypto.Modes.Gcm.IGcmMultiplier theMultiplier;

		// Token: 0x04001111 RID: 4369
		internal readonly byte[] theGHash = new byte[global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN];

		// Token: 0x04001112 RID: 4370
		internal readonly byte[] theReverse = new byte[global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN];

		// Token: 0x04001113 RID: 4371
		private readonly global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.GcmSivHasher theAEADHasher;

		// Token: 0x04001114 RID: 4372
		private readonly global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.GcmSivHasher theDataHasher;

		// Token: 0x04001115 RID: 4373
		private global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.GcmSivCache thePlain;

		// Token: 0x04001116 RID: 4374
		private global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.GcmSivCache theEncData;

		// Token: 0x04001117 RID: 4375
		private bool forEncryption;

		// Token: 0x04001118 RID: 4376
		private byte[] theInitialAEAD;

		// Token: 0x04001119 RID: 4377
		private byte[] theNonce;

		// Token: 0x0400111A RID: 4378
		private int theFlags;

		// Token: 0x0200080E RID: 2062
		private class GcmSivCache : global::System.IO.MemoryStream
		{
			// Token: 0x0600467C RID: 18044 RVA: 0x00136E06 File Offset: 0x00135006
			internal GcmSivCache()
			{
			}
		}

		// Token: 0x0200080F RID: 2063
		private class GcmSivHasher
		{
			// Token: 0x0600467D RID: 18045 RVA: 0x00136E0E File Offset: 0x0013500E
			internal GcmSivHasher(global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher parent)
			{
				this.parent = parent;
			}

			// Token: 0x0600467E RID: 18046 RVA: 0x00136E39 File Offset: 0x00135039
			internal ulong getBytesProcessed()
			{
				return this.numHashed;
			}

			// Token: 0x0600467F RID: 18047 RVA: 0x00136E41 File Offset: 0x00135041
			internal void Reset()
			{
				this.numActive = 0;
				this.numHashed = 0UL;
			}

			// Token: 0x06004680 RID: 18048 RVA: 0x00136E52 File Offset: 0x00135052
			internal void updateHash(byte pByte)
			{
				this.theByte[0] = pByte;
				this.updateHash(this.theByte, 0, 1);
			}

			// Token: 0x06004681 RID: 18049 RVA: 0x00136E6C File Offset: 0x0013506C
			internal void updateHash(byte[] pBuffer, int pOffset, int pLen)
			{
				int mySpace = global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN - this.numActive;
				int numProcessed = 0;
				int myRemaining = pLen;
				if (this.numActive > 0 && pLen >= mySpace)
				{
					global::System.Array.Copy(pBuffer, pOffset, this.theBuffer, this.numActive, mySpace);
					global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.fillReverse(this.theBuffer, 0, global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN, this.parent.theReverse);
					this.parent.gHASH(this.parent.theReverse);
					numProcessed += mySpace;
					myRemaining -= mySpace;
					this.numActive = 0;
				}
				while (myRemaining >= global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN)
				{
					global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.fillReverse(pBuffer, pOffset + numProcessed, global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN, this.parent.theReverse);
					this.parent.gHASH(this.parent.theReverse);
					numProcessed += mySpace;
					myRemaining -= mySpace;
				}
				if (myRemaining > 0)
				{
					global::System.Array.Copy(pBuffer, pOffset + numProcessed, this.theBuffer, this.numActive, myRemaining);
					this.numActive += myRemaining;
				}
				this.numHashed += (ulong)((long)pLen);
			}

			// Token: 0x06004682 RID: 18050 RVA: 0x00136F6C File Offset: 0x0013516C
			internal void completeHash()
			{
				if (this.numActive > 0)
				{
					global::Org.BouncyCastle.Utilities.Arrays.Fill(this.parent.theReverse, 0);
					global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.fillReverse(this.theBuffer, 0, this.numActive, this.parent.theReverse);
					this.parent.gHASH(this.parent.theReverse);
				}
			}

			// Token: 0x040024D7 RID: 9431
			private readonly byte[] theBuffer = new byte[global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher.BUFLEN];

			// Token: 0x040024D8 RID: 9432
			private readonly byte[] theByte = new byte[1];

			// Token: 0x040024D9 RID: 9433
			private int numActive;

			// Token: 0x040024DA RID: 9434
			private ulong numHashed;

			// Token: 0x040024DB RID: 9435
			private readonly global::Org.BouncyCastle.Crypto.Modes.GcmSivBlockCipher parent;
		}
	}
}
