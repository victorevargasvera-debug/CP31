using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000343 RID: 835
	internal class RecordStream
	{
		// Token: 0x06002269 RID: 8809 RVA: 0x00097E88 File Offset: 0x00096088
		internal RecordStream(global::Org.BouncyCastle.Crypto.Tls.TlsProtocol handler, global::System.IO.Stream input, global::System.IO.Stream output)
		{
			this.mHandler = handler;
			this.mInput = input;
			this.mOutput = output;
			this.mReadCompression = new global::Org.BouncyCastle.Crypto.Tls.TlsNullCompression();
			this.mWriteCompression = this.mReadCompression;
			this.mHandshakeHashUpdater = new global::Org.BouncyCastle.Crypto.Tls.RecordStream.HandshakeHashUpdateStream(this);
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x00097EFB File Offset: 0x000960FB
		internal virtual void Init(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			this.mReadCipher = new global::Org.BouncyCastle.Crypto.Tls.TlsNullCipher(context);
			this.mWriteCipher = this.mReadCipher;
			this.mHandshakeHash = new global::Org.BouncyCastle.Crypto.Tls.DeferredHash();
			this.mHandshakeHash.Init(context);
			this.SetPlaintextLimit(16384);
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x00097F37 File Offset: 0x00096137
		internal virtual int GetPlaintextLimit()
		{
			return this.mPlaintextLimit;
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x00097F3F File Offset: 0x0009613F
		internal virtual void SetPlaintextLimit(int plaintextLimit)
		{
			this.mPlaintextLimit = plaintextLimit;
			this.mCompressedLimit = this.mPlaintextLimit + 1024;
			this.mCiphertextLimit = this.mCompressedLimit + 1024;
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x00097F6C File Offset: 0x0009616C
		// (set) Token: 0x0600226E RID: 8814 RVA: 0x00097F74 File Offset: 0x00096174
		internal virtual global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ReadVersion
		{
			get
			{
				return this.mReadVersion;
			}
			set
			{
				this.mReadVersion = value;
			}
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00097F7D File Offset: 0x0009617D
		internal virtual void SetWriteVersion(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion writeVersion)
		{
			this.mWriteVersion = writeVersion;
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00097F86 File Offset: 0x00096186
		internal virtual void SetRestrictReadVersion(bool enabled)
		{
			this.mRestrictReadVersion = enabled;
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00097F8F File Offset: 0x0009618F
		internal virtual void SetPendingConnectionState(global::Org.BouncyCastle.Crypto.Tls.TlsCompression tlsCompression, global::Org.BouncyCastle.Crypto.Tls.TlsCipher tlsCipher)
		{
			this.mPendingCompression = tlsCompression;
			this.mPendingCipher = tlsCipher;
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x00097F9F File Offset: 0x0009619F
		internal virtual void SentWriteCipherSpec()
		{
			if (this.mPendingCompression == null || this.mPendingCipher == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
			this.mWriteCompression = this.mPendingCompression;
			this.mWriteCipher = this.mPendingCipher;
			this.mWriteSeqNo = new global::Org.BouncyCastle.Crypto.Tls.RecordStream.SequenceNumber();
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00097FDC File Offset: 0x000961DC
		internal virtual void ReceivedReadCipherSpec()
		{
			if (this.mPendingCompression == null || this.mPendingCipher == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
			this.mReadCompression = this.mPendingCompression;
			this.mReadCipher = this.mPendingCipher;
			this.mReadSeqNo = new global::Org.BouncyCastle.Crypto.Tls.RecordStream.SequenceNumber();
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x0009801C File Offset: 0x0009621C
		internal virtual void FinaliseHandshake()
		{
			if (this.mReadCompression != this.mPendingCompression || this.mWriteCompression != this.mPendingCompression || this.mReadCipher != this.mPendingCipher || this.mWriteCipher != this.mPendingCipher)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
			this.mPendingCompression = null;
			this.mPendingCipher = null;
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x00098078 File Offset: 0x00096278
		internal virtual void CheckRecordHeader(byte[] recordHeader)
		{
			global::Org.BouncyCastle.Crypto.Tls.RecordStream.CheckType(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(recordHeader, 0), 10);
			if (!this.mRestrictReadVersion)
			{
				if (((long)global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadVersionRaw(recordHeader, 1) & (long)((ulong)-256)) != 768L)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
			}
			else
			{
				global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadVersion(recordHeader, 1);
				if (this.mReadVersion != null && !version.Equals(this.mReadVersion))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
			}
			global::Org.BouncyCastle.Crypto.Tls.RecordStream.CheckLength(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(recordHeader, 3), this.mCiphertextLimit, 22);
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x000980F4 File Offset: 0x000962F4
		internal virtual bool ReadRecord()
		{
			byte[] recordHeader = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadAllOrNothing(5, this.mInput);
			if (recordHeader == null)
			{
				return false;
			}
			byte type = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(recordHeader, 0);
			global::Org.BouncyCastle.Crypto.Tls.RecordStream.CheckType(type, 10);
			if (!this.mRestrictReadVersion)
			{
				if (((long)global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadVersionRaw(recordHeader, 1) & (long)((ulong)-256)) != 768L)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
			}
			else
			{
				global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadVersion(recordHeader, 1);
				if (this.mReadVersion == null)
				{
					this.mReadVersion = version;
				}
				else if (!version.Equals(this.mReadVersion))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
			}
			int length = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(recordHeader, 3);
			global::Org.BouncyCastle.Crypto.Tls.RecordStream.CheckLength(length, this.mCiphertextLimit, 22);
			byte[] plaintext = this.DecodeAndVerify(type, this.mInput, length);
			this.mHandler.ProcessRecord(type, plaintext, 0, plaintext.Length);
			return true;
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x000981B4 File Offset: 0x000963B4
		internal virtual byte[] DecodeAndVerify(byte type, global::System.IO.Stream input, int len)
		{
			byte[] buf = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(len, input);
			long seqNo = this.mReadSeqNo.NextValue(10);
			byte[] decoded = this.mReadCipher.DecodeCiphertext(seqNo, type, buf, 0, buf.Length);
			global::Org.BouncyCastle.Crypto.Tls.RecordStream.CheckLength(decoded.Length, this.mCompressedLimit, 22);
			global::System.IO.Stream cOut = this.mReadCompression.Decompress(this.mBuffer);
			if (cOut != this.mBuffer)
			{
				cOut.Write(decoded, 0, decoded.Length);
				cOut.Flush();
				decoded = this.GetBufferContents();
			}
			global::Org.BouncyCastle.Crypto.Tls.RecordStream.CheckLength(decoded.Length, this.mPlaintextLimit, 30);
			if (decoded.Length < 1 && type != 23)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			return decoded;
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00098254 File Offset: 0x00096454
		internal virtual void WriteRecord(byte type, byte[] plaintext, int plaintextOffset, int plaintextLength)
		{
			if (this.mWriteVersion == null)
			{
				return;
			}
			global::Org.BouncyCastle.Crypto.Tls.RecordStream.CheckType(type, 80);
			global::Org.BouncyCastle.Crypto.Tls.RecordStream.CheckLength(plaintextLength, this.mPlaintextLimit, 80);
			if (plaintextLength < 1 && type != 23)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::System.IO.Stream cOut = this.mWriteCompression.Compress(this.mBuffer);
			long seqNo = this.mWriteSeqNo.NextValue(80);
			byte[] ciphertext;
			if (cOut == this.mBuffer)
			{
				ciphertext = this.mWriteCipher.EncodePlaintext(seqNo, type, plaintext, plaintextOffset, plaintextLength);
			}
			else
			{
				cOut.Write(plaintext, plaintextOffset, plaintextLength);
				cOut.Flush();
				byte[] compressed = this.GetBufferContents();
				global::Org.BouncyCastle.Crypto.Tls.RecordStream.CheckLength(compressed.Length, plaintextLength + 1024, 80);
				ciphertext = this.mWriteCipher.EncodePlaintext(seqNo, type, compressed, 0, compressed.Length);
			}
			global::Org.BouncyCastle.Crypto.Tls.RecordStream.CheckLength(ciphertext.Length, this.mCiphertextLimit, 80);
			byte[] record = new byte[ciphertext.Length + 5];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(type, record, 0);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(this.mWriteVersion, record, 1);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(ciphertext.Length, record, 3);
			global::System.Array.Copy(ciphertext, 0, record, 5, ciphertext.Length);
			this.mOutput.Write(record, 0, record.Length);
			this.mOutput.Flush();
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x00098371 File Offset: 0x00096571
		internal virtual void NotifyHelloComplete()
		{
			this.mHandshakeHash = this.mHandshakeHash.NotifyPrfDetermined();
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600227A RID: 8826 RVA: 0x00098384 File Offset: 0x00096584
		internal virtual global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash HandshakeHash
		{
			get
			{
				return this.mHandshakeHash;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x0009838C File Offset: 0x0009658C
		internal virtual global::System.IO.Stream HandshakeHashUpdater
		{
			get
			{
				return this.mHandshakeHashUpdater;
			}
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x00098394 File Offset: 0x00096594
		internal virtual global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash PrepareToFinish()
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash result = this.mHandshakeHash;
			this.mHandshakeHash = this.mHandshakeHash.StopTracking();
			return result;
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x000983B0 File Offset: 0x000965B0
		internal virtual void SafeClose()
		{
			try
			{
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this.mInput);
			}
			catch (global::System.IO.IOException)
			{
			}
			try
			{
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this.mOutput);
			}
			catch (global::System.IO.IOException)
			{
			}
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x000983FC File Offset: 0x000965FC
		internal virtual void Flush()
		{
			this.mOutput.Flush();
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00098409 File Offset: 0x00096609
		private byte[] GetBufferContents()
		{
			byte[] result = this.mBuffer.ToArray();
			this.mBuffer.SetLength(0L);
			return result;
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x00098423 File Offset: 0x00096623
		private static void CheckType(byte type, byte alertDescription)
		{
			if (type - 20 > 3)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription);
			}
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00098433 File Offset: 0x00096633
		private static void CheckLength(int length, int limit, byte alertDescription)
		{
			if (length > limit)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription);
			}
		}

		// Token: 0x04000DD6 RID: 3542
		private const int DEFAULT_PLAINTEXT_LIMIT = 16384;

		// Token: 0x04000DD7 RID: 3543
		internal const int TLS_HEADER_SIZE = 5;

		// Token: 0x04000DD8 RID: 3544
		internal const int TLS_HEADER_TYPE_OFFSET = 0;

		// Token: 0x04000DD9 RID: 3545
		internal const int TLS_HEADER_VERSION_OFFSET = 1;

		// Token: 0x04000DDA RID: 3546
		internal const int TLS_HEADER_LENGTH_OFFSET = 3;

		// Token: 0x04000DDB RID: 3547
		private global::Org.BouncyCastle.Crypto.Tls.TlsProtocol mHandler;

		// Token: 0x04000DDC RID: 3548
		private global::System.IO.Stream mInput;

		// Token: 0x04000DDD RID: 3549
		private global::System.IO.Stream mOutput;

		// Token: 0x04000DDE RID: 3550
		private global::Org.BouncyCastle.Crypto.Tls.TlsCompression mPendingCompression;

		// Token: 0x04000DDF RID: 3551
		private global::Org.BouncyCastle.Crypto.Tls.TlsCompression mReadCompression;

		// Token: 0x04000DE0 RID: 3552
		private global::Org.BouncyCastle.Crypto.Tls.TlsCompression mWriteCompression;

		// Token: 0x04000DE1 RID: 3553
		private global::Org.BouncyCastle.Crypto.Tls.TlsCipher mPendingCipher;

		// Token: 0x04000DE2 RID: 3554
		private global::Org.BouncyCastle.Crypto.Tls.TlsCipher mReadCipher;

		// Token: 0x04000DE3 RID: 3555
		private global::Org.BouncyCastle.Crypto.Tls.TlsCipher mWriteCipher;

		// Token: 0x04000DE4 RID: 3556
		private global::Org.BouncyCastle.Crypto.Tls.RecordStream.SequenceNumber mReadSeqNo = new global::Org.BouncyCastle.Crypto.Tls.RecordStream.SequenceNumber();

		// Token: 0x04000DE5 RID: 3557
		private global::Org.BouncyCastle.Crypto.Tls.RecordStream.SequenceNumber mWriteSeqNo = new global::Org.BouncyCastle.Crypto.Tls.RecordStream.SequenceNumber();

		// Token: 0x04000DE6 RID: 3558
		private global::System.IO.MemoryStream mBuffer = new global::System.IO.MemoryStream();

		// Token: 0x04000DE7 RID: 3559
		private global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash mHandshakeHash;

		// Token: 0x04000DE8 RID: 3560
		private readonly global::Org.BouncyCastle.Utilities.IO.BaseOutputStream mHandshakeHashUpdater;

		// Token: 0x04000DE9 RID: 3561
		private global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion mReadVersion;

		// Token: 0x04000DEA RID: 3562
		private global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion mWriteVersion;

		// Token: 0x04000DEB RID: 3563
		private bool mRestrictReadVersion = true;

		// Token: 0x04000DEC RID: 3564
		private int mPlaintextLimit;

		// Token: 0x04000DED RID: 3565
		private int mCompressedLimit;

		// Token: 0x04000DEE RID: 3566
		private int mCiphertextLimit;

		// Token: 0x020007FC RID: 2044
		private class HandshakeHashUpdateStream : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
		{
			// Token: 0x0600463B RID: 17979 RVA: 0x00136336 File Offset: 0x00134536
			public HandshakeHashUpdateStream(global::Org.BouncyCastle.Crypto.Tls.RecordStream mOuter)
			{
				this.mOuter = mOuter;
			}

			// Token: 0x0600463C RID: 17980 RVA: 0x00136345 File Offset: 0x00134545
			public override void Write(byte[] buf, int off, int len)
			{
				this.mOuter.mHandshakeHash.BlockUpdate(buf, off, len);
			}

			// Token: 0x040024A7 RID: 9383
			private readonly global::Org.BouncyCastle.Crypto.Tls.RecordStream mOuter;
		}

		// Token: 0x020007FD RID: 2045
		private class SequenceNumber
		{
			// Token: 0x0600463D RID: 17981 RVA: 0x0013635C File Offset: 0x0013455C
			internal long NextValue(byte alertDescription)
			{
				if (this.exhausted)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription);
				}
				long result = this.value;
				long num = this.value + 1L;
				this.value = num;
				if (num == 0L)
				{
					this.exhausted = true;
				}
				return result;
			}

			// Token: 0x040024A8 RID: 9384
			private long value;

			// Token: 0x040024A9 RID: 9385
			private bool exhausted;
		}
	}
}
