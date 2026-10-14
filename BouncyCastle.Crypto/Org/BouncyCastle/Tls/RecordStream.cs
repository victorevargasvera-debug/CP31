using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000E5 RID: 229
	internal sealed class RecordStream
	{
		// Token: 0x0600082B RID: 2091 RVA: 0x00022040 File Offset: 0x00020240
		internal RecordStream(global::Org.BouncyCastle.Tls.TlsProtocol handler, global::System.IO.Stream input, global::System.IO.Stream output)
		{
			this.m_handler = handler;
			this.m_input = input;
			this.m_output = output;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000220B5 File Offset: 0x000202B5
		internal int PlaintextLimit
		{
			get
			{
				return this.m_plaintextLimit;
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000220BD File Offset: 0x000202BD
		internal void SetPlaintextLimit(int plaintextLimit)
		{
			this.m_plaintextLimit = plaintextLimit;
			this.m_ciphertextLimit = this.m_readCipher.GetCiphertextDecodeLimit(plaintextLimit);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000220D8 File Offset: 0x000202D8
		internal void SetWriteVersion(global::Org.BouncyCastle.Tls.ProtocolVersion writeVersion)
		{
			this.m_writeVersion = writeVersion;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x000220E1 File Offset: 0x000202E1
		internal void SetIgnoreChangeCipherSpec(bool ignoreChangeCipherSpec)
		{
			this.m_ignoreChangeCipherSpec = ignoreChangeCipherSpec;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000220EA File Offset: 0x000202EA
		internal void SetPendingCipher(global::Org.BouncyCastle.Tls.Crypto.TlsCipher tlsCipher)
		{
			this.m_pendingCipher = tlsCipher;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000220F3 File Offset: 0x000202F3
		internal void NotifyChangeCipherSpecReceived()
		{
			if (this.m_pendingCipher == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10, "No pending cipher");
			}
			this.EnablePendingCipherRead(false);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00022114 File Offset: 0x00020314
		internal void EnablePendingCipherRead(bool deferred)
		{
			if (this.m_pendingCipher == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			if (this.m_readCipherDeferred != null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			if (deferred)
			{
				this.m_readCipherDeferred = this.m_pendingCipher;
				return;
			}
			this.m_readCipher = this.m_pendingCipher;
			this.m_ciphertextLimit = this.m_readCipher.GetCiphertextDecodeLimit(this.m_plaintextLimit);
			this.m_readSeqNo.Reset();
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0002217F File Offset: 0x0002037F
		internal void EnablePendingCipherWrite()
		{
			if (this.m_pendingCipher == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			this.m_writeCipher = this.m_pendingCipher;
			this.m_writeSeqNo.Reset();
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x000221A8 File Offset: 0x000203A8
		internal void FinaliseHandshake()
		{
			if (this.m_readCipher != this.m_pendingCipher || this.m_writeCipher != this.m_pendingCipher)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
			}
			this.m_pendingCipher = null;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000221D5 File Offset: 0x000203D5
		internal bool NeedsKeyUpdate()
		{
			return this.m_writeSeqNo.CurrentValue >= 1048576L;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000221ED File Offset: 0x000203ED
		internal void NotifyKeyUpdateReceived()
		{
			this.m_readCipher.RekeyDecoder();
			this.m_readSeqNo.Reset();
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00022205 File Offset: 0x00020405
		internal void NotifyKeyUpdateSent()
		{
			this.m_writeCipher.RekeyEncoder();
			this.m_writeSeqNo.Reset();
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00022220 File Offset: 0x00020420
		internal global::Org.BouncyCastle.Tls.RecordPreview PreviewRecordHeader(byte[] recordHeader)
		{
			short recordType = this.CheckRecordType(recordHeader, 0);
			int length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(recordHeader, 3);
			global::Org.BouncyCastle.Tls.RecordStream.CheckLength(length, this.m_ciphertextLimit, 22);
			int recordSize = 5 + length;
			int applicationDataLimit = 0;
			if (23 == recordType && this.m_handler.IsApplicationDataReady)
			{
				applicationDataLimit = global::System.Math.Max(0, global::System.Math.Min(this.m_plaintextLimit, this.m_readCipher.GetPlaintextLimit(length)));
			}
			return new global::Org.BouncyCastle.Tls.RecordPreview(recordSize, applicationDataLimit);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00022288 File Offset: 0x00020488
		internal global::Org.BouncyCastle.Tls.RecordPreview PreviewOutputRecord(int contentLength)
		{
			int contentLimit = global::System.Math.Max(0, global::System.Math.Min(this.m_plaintextLimit, contentLength));
			return new global::Org.BouncyCastle.Tls.RecordPreview(this.PreviewOutputRecordSize(contentLimit), contentLimit);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000222B5 File Offset: 0x000204B5
		internal int PreviewOutputRecordSize(int contentLength)
		{
			return 5 + this.m_writeCipher.GetCiphertextEncodeLimit(contentLength, this.m_plaintextLimit);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000222CC File Offset: 0x000204CC
		internal bool ReadFullRecord(byte[] input, int inputOff, int inputLen)
		{
			if (inputLen < 5)
			{
				return false;
			}
			int length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(input, inputOff + 3);
			if (inputLen != 5 + length)
			{
				return false;
			}
			short recordType = this.CheckRecordType(input, inputOff);
			global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion = global::Org.BouncyCastle.Tls.TlsUtilities.ReadVersion(input, inputOff + 1);
			global::Org.BouncyCastle.Tls.RecordStream.CheckLength(length, this.m_ciphertextLimit, 22);
			if (this.m_ignoreChangeCipherSpec && 20 == recordType)
			{
				this.CheckChangeCipherSpec(input, inputOff + 5, length);
				return true;
			}
			global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult decoded = this.DecodeAndVerify(recordType, recordVersion, input, inputOff + 5, length);
			this.m_handler.ProcessRecord(decoded.contentType, decoded.buf, decoded.off, decoded.len);
			return true;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00022360 File Offset: 0x00020560
		internal bool ReadRecord()
		{
			if (!this.m_inputRecord.ReadHeader(this.m_input))
			{
				return false;
			}
			short recordType = this.CheckRecordType(this.m_inputRecord.m_buf, 0);
			global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion = global::Org.BouncyCastle.Tls.TlsUtilities.ReadVersion(this.m_inputRecord.m_buf, 1);
			int length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(this.m_inputRecord.m_buf, 3);
			global::Org.BouncyCastle.Tls.RecordStream.CheckLength(length, this.m_ciphertextLimit, 22);
			this.m_inputRecord.ReadFragment(this.m_input, length);
			global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult decoded;
			try
			{
				if (this.m_ignoreChangeCipherSpec && 20 == recordType)
				{
					this.CheckChangeCipherSpec(this.m_inputRecord.m_buf, 5, length);
					return true;
				}
				decoded = this.DecodeAndVerify(recordType, recordVersion, this.m_inputRecord.m_buf, 5, length);
			}
			finally
			{
				this.m_inputRecord.Reset();
			}
			this.m_handler.ProcessRecord(decoded.contentType, decoded.buf, decoded.off, decoded.len);
			return true;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00022464 File Offset: 0x00020664
		internal global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult DecodeAndVerify(short recordType, global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion, byte[] ciphertext, int off, int len)
		{
			long seqNo = this.m_readSeqNo.NextValue(10);
			global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult decoded = this.m_readCipher.DecodeCiphertext(seqNo, recordType, recordVersion, ciphertext, off, len);
			global::Org.BouncyCastle.Tls.RecordStream.CheckLength(decoded.len, this.m_plaintextLimit, 22);
			if (decoded.len < 1 && decoded.contentType != 23)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			return decoded;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000224C4 File Offset: 0x000206C4
		internal void WriteRecord(short contentType, byte[] plaintext, int plaintextOffset, int plaintextLength)
		{
			if (this.m_writeVersion == null)
			{
				return;
			}
			global::Org.BouncyCastle.Tls.RecordStream.CheckLength(plaintextLength, this.m_plaintextLimit, 80);
			if (plaintextLength < 1 && contentType != 23)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			long seqNo = this.m_writeSeqNo.NextValue(80);
			global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion = this.m_writeVersion;
			global::Org.BouncyCastle.Tls.Crypto.TlsEncodeResult encoded = this.m_writeCipher.EncodePlaintext(seqNo, contentType, recordVersion, 5, plaintext, plaintextOffset, plaintextLength);
			int i = encoded.len - 5;
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(i);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(encoded.recordType, encoded.buf, encoded.off);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteVersion(recordVersion, encoded.buf, encoded.off + 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(i, encoded.buf, encoded.off + 3);
			this.m_output.Write(encoded.buf, encoded.off, encoded.len);
			this.m_output.Flush();
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00022598 File Offset: 0x00020798
		internal void Close()
		{
			this.m_inputRecord.Reset();
			global::System.IO.IOException io = null;
			try
			{
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this.m_input);
			}
			catch (global::System.IO.IOException io)
			{
			}
			try
			{
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this.m_output);
			}
			catch (global::System.IO.IOException e)
			{
				if (io == null)
				{
					io = e;
				}
			}
			if (io != null)
			{
				throw io;
			}
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000225FC File Offset: 0x000207FC
		private void CheckChangeCipherSpec(byte[] buf, int off, int len)
		{
			if (1 != len || 1 != buf[off])
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10, "Malformed " + global::Org.BouncyCastle.Tls.ContentType.GetText(20));
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00022624 File Offset: 0x00020824
		private short CheckRecordType(byte[] buf, int off)
		{
			short recordType = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(buf, off);
			if (this.m_readCipherDeferred != null && recordType == 23)
			{
				this.m_readCipher = this.m_readCipherDeferred;
				this.m_readCipherDeferred = null;
				this.m_ciphertextLimit = this.m_readCipher.GetCiphertextDecodeLimit(this.m_plaintextLimit);
				this.m_readSeqNo.Reset();
			}
			else if (this.m_readCipher.UsesOpaqueRecordType)
			{
				if (23 != recordType && (!this.m_ignoreChangeCipherSpec || 20 != recordType))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10, "Opaque " + global::Org.BouncyCastle.Tls.ContentType.GetText(recordType));
				}
			}
			else if (recordType - 20 > 2)
			{
				if (recordType != 23)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10, "Unsupported " + global::Org.BouncyCastle.Tls.ContentType.GetText(recordType));
				}
				if (!this.m_handler.IsApplicationDataReady)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10, "Not ready for " + global::Org.BouncyCastle.Tls.ContentType.GetText(23));
				}
			}
			return recordType;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00022702 File Offset: 0x00020902
		private static void CheckLength(int length, int limit, short alertDescription)
		{
			if (length > limit)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(alertDescription);
			}
		}

		// Token: 0x04000635 RID: 1589
		private const int DefaultPlaintextLimit = 16384;

		// Token: 0x04000636 RID: 1590
		private readonly global::Org.BouncyCastle.Tls.RecordStream.Record m_inputRecord = new global::Org.BouncyCastle.Tls.RecordStream.Record();

		// Token: 0x04000637 RID: 1591
		private readonly global::Org.BouncyCastle.Tls.RecordStream.SequenceNumber m_readSeqNo = new global::Org.BouncyCastle.Tls.RecordStream.SequenceNumber();

		// Token: 0x04000638 RID: 1592
		private readonly global::Org.BouncyCastle.Tls.RecordStream.SequenceNumber m_writeSeqNo = new global::Org.BouncyCastle.Tls.RecordStream.SequenceNumber();

		// Token: 0x04000639 RID: 1593
		private readonly global::Org.BouncyCastle.Tls.TlsProtocol m_handler;

		// Token: 0x0400063A RID: 1594
		private readonly global::System.IO.Stream m_input;

		// Token: 0x0400063B RID: 1595
		private readonly global::System.IO.Stream m_output;

		// Token: 0x0400063C RID: 1596
		private global::Org.BouncyCastle.Tls.Crypto.TlsCipher m_pendingCipher;

		// Token: 0x0400063D RID: 1597
		private global::Org.BouncyCastle.Tls.Crypto.TlsCipher m_readCipher = global::Org.BouncyCastle.Tls.Crypto.TlsNullNullCipher.Instance;

		// Token: 0x0400063E RID: 1598
		private global::Org.BouncyCastle.Tls.Crypto.TlsCipher m_readCipherDeferred;

		// Token: 0x0400063F RID: 1599
		private global::Org.BouncyCastle.Tls.Crypto.TlsCipher m_writeCipher = global::Org.BouncyCastle.Tls.Crypto.TlsNullNullCipher.Instance;

		// Token: 0x04000640 RID: 1600
		private global::Org.BouncyCastle.Tls.ProtocolVersion m_writeVersion;

		// Token: 0x04000641 RID: 1601
		private int m_plaintextLimit = 16384;

		// Token: 0x04000642 RID: 1602
		private int m_ciphertextLimit = 16384;

		// Token: 0x04000643 RID: 1603
		private bool m_ignoreChangeCipherSpec;

		// Token: 0x020007AA RID: 1962
		private sealed class Record
		{
			// Token: 0x06004518 RID: 17688 RVA: 0x0013281E File Offset: 0x00130A1E
			internal Record()
			{
				this.m_buf = this.m_header;
				this.m_pos = 0;
			}

			// Token: 0x06004519 RID: 17689 RVA: 0x0013284C File Offset: 0x00130A4C
			internal void FillTo(global::System.IO.Stream input, int length)
			{
				while (this.m_pos < length)
				{
					int numRead = input.Read(this.m_buf, this.m_pos, length - this.m_pos);
					if (numRead < 1)
					{
						break;
					}
					this.m_pos += numRead;
				}
			}

			// Token: 0x0600451A RID: 17690 RVA: 0x001328A0 File Offset: 0x00130AA0
			internal void ReadFragment(global::System.IO.Stream input, int fragmentLength)
			{
				int recordLength = 5 + fragmentLength;
				this.Resize(recordLength);
				this.FillTo(input, recordLength);
				if (this.m_pos < recordLength)
				{
					throw new global::System.IO.EndOfStreamException();
				}
			}

			// Token: 0x0600451B RID: 17691 RVA: 0x001328D1 File Offset: 0x00130AD1
			internal bool ReadHeader(global::System.IO.Stream input)
			{
				this.FillTo(input, 5);
				if (this.m_pos == 0)
				{
					return false;
				}
				if (this.m_pos < 5)
				{
					throw new global::System.IO.EndOfStreamException();
				}
				return true;
			}

			// Token: 0x0600451C RID: 17692 RVA: 0x001328F9 File Offset: 0x00130AF9
			internal void Reset()
			{
				this.m_buf = this.m_header;
				this.m_pos = 0;
			}

			// Token: 0x0600451D RID: 17693 RVA: 0x00132914 File Offset: 0x00130B14
			private void Resize(int length)
			{
				if (this.m_buf.Length < length)
				{
					byte[] tmp = new byte[length];
					global::System.Array.Copy(this.m_buf, 0, tmp, 0, this.m_pos);
					this.m_buf = tmp;
				}
			}

			// Token: 0x0400231E RID: 8990
			private readonly byte[] m_header = new byte[5];

			// Token: 0x0400231F RID: 8991
			internal volatile byte[] m_buf;

			// Token: 0x04002320 RID: 8992
			internal volatile int m_pos;
		}

		// Token: 0x020007AB RID: 1963
		private sealed class SequenceNumber
		{
			// Token: 0x17000A71 RID: 2673
			// (get) Token: 0x0600451E RID: 17694 RVA: 0x00132958 File Offset: 0x00130B58
			internal long CurrentValue
			{
				get
				{
					long value;
					lock (this)
					{
						value = this.m_value;
					}
					return value;
				}
			}

			// Token: 0x0600451F RID: 17695 RVA: 0x00132998 File Offset: 0x00130B98
			internal long NextValue(short alertDescription)
			{
				long num;
				lock (this)
				{
					if (this.m_exhausted)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(alertDescription, "Sequence numbers exhausted");
					}
					long value = this.m_value;
					num = this.m_value + 1L;
					this.m_value = num;
					if (num == 0L)
					{
						this.m_exhausted = true;
					}
					num = value;
				}
				return num;
			}

			// Token: 0x06004520 RID: 17696 RVA: 0x00132A04 File Offset: 0x00130C04
			internal void Reset()
			{
				lock (this)
				{
					this.m_value = 0L;
					this.m_exhausted = false;
				}
			}

			// Token: 0x04002321 RID: 8993
			private long m_value;

			// Token: 0x04002322 RID: 8994
			private bool m_exhausted;
		}
	}
}
