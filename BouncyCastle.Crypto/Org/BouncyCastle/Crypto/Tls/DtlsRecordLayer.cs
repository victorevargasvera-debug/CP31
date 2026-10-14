using System;
using System.Net.Sockets;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000326 RID: 806
	internal class DtlsRecordLayer : global::Org.BouncyCastle.Crypto.Tls.DatagramTransport, global::Org.BouncyCastle.Crypto.Tls.TlsCloseable
	{
		// Token: 0x060021CF RID: 8655 RVA: 0x00095662 File Offset: 0x00093862
		private static void SendDatagram(global::Org.BouncyCastle.Crypto.Tls.DatagramTransport sender, byte[] buf, int off, int len)
		{
			sender.Send(buf, off, len);
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00095670 File Offset: 0x00093870
		internal DtlsRecordLayer(global::Org.BouncyCastle.Crypto.Tls.DatagramTransport transport, global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.Tls.TlsPeer peer, byte contentType)
		{
			this.mTransport = transport;
			this.mContext = context;
			this.mPeer = peer;
			this.mInHandshake = true;
			this.mCurrentEpoch = new global::Org.BouncyCastle.Crypto.Tls.DtlsEpoch(0, new global::Org.BouncyCastle.Crypto.Tls.TlsNullCipher(context));
			this.mPendingEpoch = null;
			this.mReadEpoch = this.mCurrentEpoch;
			this.mWriteEpoch = this.mCurrentEpoch;
			this.SetPlaintextLimit(16384);
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x000956E8 File Offset: 0x000938E8
		internal bool IsClosed
		{
			get
			{
				return this.mClosed;
			}
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x000956F2 File Offset: 0x000938F2
		internal virtual void SetPlaintextLimit(int plaintextLimit)
		{
			this.mPlaintextLimit = plaintextLimit;
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x000956FD File Offset: 0x000938FD
		internal virtual int ReadEpoch
		{
			get
			{
				return this.mReadEpoch.Epoch;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x0009570A File Offset: 0x0009390A
		// (set) Token: 0x060021D5 RID: 8661 RVA: 0x00095714 File Offset: 0x00093914
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

		// Token: 0x060021D6 RID: 8662 RVA: 0x0009571F File Offset: 0x0009391F
		internal virtual void SetWriteVersion(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion writeVersion)
		{
			this.mWriteVersion = writeVersion;
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0009572A File Offset: 0x0009392A
		internal virtual void InitPendingEpoch(global::Org.BouncyCastle.Crypto.Tls.TlsCipher pendingCipher)
		{
			if (this.mPendingEpoch != null)
			{
				throw new global::System.InvalidOperationException();
			}
			this.mPendingEpoch = new global::Org.BouncyCastle.Crypto.Tls.DtlsEpoch(this.mWriteEpoch.Epoch + 1, pendingCipher);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x00095754 File Offset: 0x00093954
		internal virtual void HandshakeSuccessful(global::Org.BouncyCastle.Crypto.Tls.DtlsHandshakeRetransmit retransmit)
		{
			if (this.mReadEpoch == this.mCurrentEpoch || this.mWriteEpoch == this.mCurrentEpoch)
			{
				throw new global::System.InvalidOperationException();
			}
			if (retransmit != null)
			{
				this.mRetransmit = retransmit;
				this.mRetransmitEpoch = this.mCurrentEpoch;
				this.mRetransmitTimeout = new global::Org.BouncyCastle.Crypto.Tls.Timeout(240000L);
			}
			this.mInHandshake = false;
			this.mCurrentEpoch = this.mPendingEpoch;
			this.mPendingEpoch = null;
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x000957C6 File Offset: 0x000939C6
		internal virtual void ResetWriteEpoch()
		{
			if (this.mRetransmitEpoch != null)
			{
				this.mWriteEpoch = this.mRetransmitEpoch;
				return;
			}
			this.mWriteEpoch = this.mCurrentEpoch;
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x000957E9 File Offset: 0x000939E9
		public virtual int GetReceiveLimit()
		{
			return global::System.Math.Min(this.mPlaintextLimit, this.mReadEpoch.Cipher.GetPlaintextLimit(this.mTransport.GetReceiveLimit() - 13));
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x00095816 File Offset: 0x00093A16
		public virtual int GetSendLimit()
		{
			return global::System.Math.Min(this.mPlaintextLimit, this.mWriteEpoch.Cipher.GetPlaintextLimit(this.mTransport.GetSendLimit() - 13));
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x00095844 File Offset: 0x00093A44
		public virtual int Receive(byte[] buf, int off, int len, int waitMillis)
		{
			long currentTimeMillis = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs();
			global::Org.BouncyCastle.Crypto.Tls.Timeout timeout = global::Org.BouncyCastle.Crypto.Tls.Timeout.ForWaitMillis(waitMillis, currentTimeMillis);
			byte[] record = null;
			while (waitMillis >= 0)
			{
				if (this.mRetransmitTimeout != null && this.mRetransmitTimeout.RemainingMillis(currentTimeMillis) < 1L)
				{
					this.mRetransmit = null;
					this.mRetransmitEpoch = null;
					this.mRetransmitTimeout = null;
				}
				int receiveLimit = global::System.Math.Min(len, this.GetReceiveLimit()) + 13;
				if (record == null || record.Length < receiveLimit)
				{
					record = new byte[receiveLimit];
				}
				int received = this.ReceiveRecord(record, 0, receiveLimit, waitMillis);
				int processed = this.ProcessRecord(received, record, buf, off);
				if (processed >= 0)
				{
					return processed;
				}
				currentTimeMillis = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs();
				waitMillis = global::Org.BouncyCastle.Crypto.Tls.Timeout.GetWaitMillis(timeout, currentTimeMillis);
			}
			return -1;
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x000958EC File Offset: 0x00093AEC
		public virtual void Send(byte[] buf, int off, int len)
		{
			byte contentType = 23;
			if (this.mInHandshake || this.mWriteEpoch == this.mRetransmitEpoch)
			{
				contentType = 22;
				if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf, off) == 20)
				{
					global::Org.BouncyCastle.Crypto.Tls.DtlsEpoch nextEpoch = null;
					if (this.mInHandshake)
					{
						nextEpoch = this.mPendingEpoch;
					}
					else if (this.mWriteEpoch == this.mRetransmitEpoch)
					{
						nextEpoch = this.mCurrentEpoch;
					}
					if (nextEpoch == null)
					{
						throw new global::System.InvalidOperationException();
					}
					byte[] data = new byte[]
					{
						1
					};
					this.SendRecord(20, data, 0, data.Length);
					this.mWriteEpoch = nextEpoch;
				}
			}
			this.SendRecord(contentType, buf, off, len);
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x0009597E File Offset: 0x00093B7E
		public virtual void Close()
		{
			if (!this.mClosed)
			{
				if (this.mInHandshake)
				{
					this.Warn(90, "User canceled handshake");
				}
				this.CloseTransport();
			}
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x000959A7 File Offset: 0x00093BA7
		internal virtual void Failed()
		{
			if (!this.mClosed)
			{
				this.mFailed = true;
				this.CloseTransport();
			}
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000959C4 File Offset: 0x00093BC4
		internal virtual void Fail(byte alertDescription)
		{
			if (!this.mClosed)
			{
				try
				{
					this.RaiseAlert(2, alertDescription, null, null);
				}
				catch (global::System.Exception)
				{
				}
				this.mFailed = true;
				this.CloseTransport();
			}
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x00095A0C File Offset: 0x00093C0C
		internal virtual void Warn(byte alertDescription, string message)
		{
			this.RaiseAlert(1, alertDescription, message, null);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00095A18 File Offset: 0x00093C18
		private void CloseTransport()
		{
			if (!this.mClosed)
			{
				try
				{
					if (!this.mFailed)
					{
						this.Warn(0, null);
					}
					this.mTransport.Close();
				}
				catch (global::System.Exception)
				{
				}
				this.mClosed = true;
			}
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x00095A6C File Offset: 0x00093C6C
		private void RaiseAlert(byte alertLevel, byte alertDescription, string message, global::System.Exception cause)
		{
			this.mPeer.NotifyAlertRaised(alertLevel, alertDescription, message, cause);
			this.SendRecord(21, new byte[]
			{
				alertLevel,
				alertDescription
			}, 0, 2);
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x00095AA4 File Offset: 0x00093CA4
		private int ReceiveDatagram(byte[] buf, int off, int len, int waitMillis)
		{
			int result;
			try
			{
				result = this.mTransport.Receive(buf, off, len, waitMillis);
			}
			catch (global::Org.BouncyCastle.Crypto.Tls.TlsTimeoutException)
			{
				result = -1;
			}
			catch (global::System.Net.Sockets.SocketException e)
			{
				if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTimeout(e))
				{
					throw e;
				}
				result = -1;
			}
			return result;
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x00095AF8 File Offset: 0x00093CF8
		private int ProcessRecord(int received, byte[] record, byte[] buf, int off)
		{
			if (received < 13)
			{
				return -1;
			}
			int length = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(record, 11);
			if (received != length + 13)
			{
				return -1;
			}
			byte type = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(record, 0);
			if (type - 20 > 4)
			{
				return -1;
			}
			int epoch = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(record, 3);
			global::Org.BouncyCastle.Crypto.Tls.DtlsEpoch recordEpoch = null;
			if (epoch == this.mReadEpoch.Epoch)
			{
				recordEpoch = this.mReadEpoch;
			}
			else if (type == 22 && this.mRetransmitEpoch != null && epoch == this.mRetransmitEpoch.Epoch)
			{
				recordEpoch = this.mRetransmitEpoch;
			}
			if (recordEpoch == null)
			{
				return -1;
			}
			long seq = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint48(record, 5);
			if (recordEpoch.ReplayWindow.ShouldDiscard(seq))
			{
				return -1;
			}
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadVersion(record, 1);
			if (!version.IsDtls)
			{
				return -1;
			}
			if (this.mReadVersion != null && !this.mReadVersion.Equals(version))
			{
				return -1;
			}
			byte[] plaintext = recordEpoch.Cipher.DecodeCiphertext(global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer.GetMacSequenceNumber(recordEpoch.Epoch, seq), type, record, 13, received - 13);
			recordEpoch.ReplayWindow.ReportAuthenticated(seq);
			if (plaintext.Length > this.mPlaintextLimit)
			{
				return -1;
			}
			if (this.mReadVersion == null)
			{
				this.mReadVersion = version;
			}
			switch (type)
			{
			case 20:
				for (int i = 0; i < plaintext.Length; i++)
				{
					if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(plaintext, i) == 1 && this.mPendingEpoch != null)
					{
						this.mReadEpoch = this.mPendingEpoch;
					}
				}
				return -1;
			case 21:
				if (plaintext.Length == 2)
				{
					byte alertLevel = plaintext[0];
					byte alertDescription = plaintext[1];
					this.mPeer.NotifyAlertReceived(alertLevel, alertDescription);
					if (alertLevel == 2)
					{
						this.Failed();
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription);
					}
					if (alertDescription == 0)
					{
						this.CloseTransport();
					}
				}
				return -1;
			case 22:
				if (!this.mInHandshake)
				{
					if (this.mRetransmit != null)
					{
						this.mRetransmit.ReceivedHandshakeRecord(epoch, plaintext, 0, plaintext.Length);
					}
					return -1;
				}
				break;
			case 23:
				if (this.mInHandshake)
				{
					return -1;
				}
				break;
			case 24:
				return -1;
			}
			if (!this.mInHandshake && this.mRetransmit != null)
			{
				this.mRetransmit = null;
				this.mRetransmitEpoch = null;
				this.mRetransmitTimeout = null;
			}
			global::System.Array.Copy(plaintext, 0, buf, off, plaintext.Length);
			return plaintext.Length;
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x00095D1C File Offset: 0x00093F1C
		private int ReceiveRecord(byte[] buf, int off, int len, int waitMillis)
		{
			if (this.mRecordQueue.Available > 0)
			{
				int length = 0;
				if (this.mRecordQueue.Available >= 13)
				{
					byte[] lengthBytes = new byte[2];
					this.mRecordQueue.Read(lengthBytes, 0, 2, 11);
					length = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(lengthBytes, 0);
				}
				int received = global::System.Math.Min(this.mRecordQueue.Available, 13 + length);
				this.mRecordQueue.RemoveData(buf, off, received, 0);
				return received;
			}
			int received2 = this.ReceiveDatagram(buf, off, len, waitMillis);
			if (received2 >= 13)
			{
				int fragmentLength = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(buf, off + 11);
				int recordLength = 13 + fragmentLength;
				if (received2 > recordLength)
				{
					this.mRecordQueue.AddData(buf, off + recordLength, received2 - recordLength);
					received2 = recordLength;
				}
			}
			return received2;
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00095DD0 File Offset: 0x00093FD0
		private void SendRecord(byte contentType, byte[] buf, int off, int len)
		{
			if (this.mWriteVersion == null)
			{
				return;
			}
			if (len > this.mPlaintextLimit)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			if (len < 1 && contentType != 23)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			int recordEpoch = this.mWriteEpoch.Epoch;
			long recordSequenceNumber = this.mWriteEpoch.AllocateSequenceNumber();
			byte[] ciphertext = this.mWriteEpoch.Cipher.EncodePlaintext(global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer.GetMacSequenceNumber(recordEpoch, recordSequenceNumber), contentType, buf, off, len);
			byte[] record = new byte[ciphertext.Length + 13];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(contentType, record, 0);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(this.mWriteVersion, record, 1);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(recordEpoch, record, 3);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint48(recordSequenceNumber, record, 5);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(ciphertext.Length, record, 11);
			global::System.Array.Copy(ciphertext, 0, record, 13, ciphertext.Length);
			global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer.SendDatagram(this.mTransport, record, 0, record.Length);
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00095E9E File Offset: 0x0009409E
		private static long GetMacSequenceNumber(int epoch, long sequence_number)
		{
			return ((long)epoch & (long)((ulong)-1)) << 48 | sequence_number;
		}

		// Token: 0x04000CED RID: 3309
		private const int RECORD_HEADER_LENGTH = 13;

		// Token: 0x04000CEE RID: 3310
		private const int MAX_FRAGMENT_LENGTH = 16384;

		// Token: 0x04000CEF RID: 3311
		private const long TCP_MSL = 120000L;

		// Token: 0x04000CF0 RID: 3312
		private const long RETRANSMIT_TIMEOUT = 240000L;

		// Token: 0x04000CF1 RID: 3313
		private readonly global::Org.BouncyCastle.Crypto.Tls.DatagramTransport mTransport;

		// Token: 0x04000CF2 RID: 3314
		private readonly global::Org.BouncyCastle.Crypto.Tls.TlsContext mContext;

		// Token: 0x04000CF3 RID: 3315
		private readonly global::Org.BouncyCastle.Crypto.Tls.TlsPeer mPeer;

		// Token: 0x04000CF4 RID: 3316
		private readonly global::Org.BouncyCastle.Crypto.Tls.ByteQueue mRecordQueue = new global::Org.BouncyCastle.Crypto.Tls.ByteQueue();

		// Token: 0x04000CF5 RID: 3317
		private volatile bool mClosed;

		// Token: 0x04000CF6 RID: 3318
		private volatile bool mFailed;

		// Token: 0x04000CF7 RID: 3319
		private volatile global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion mReadVersion;

		// Token: 0x04000CF8 RID: 3320
		private volatile global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion mWriteVersion;

		// Token: 0x04000CF9 RID: 3321
		private volatile bool mInHandshake;

		// Token: 0x04000CFA RID: 3322
		private volatile int mPlaintextLimit;

		// Token: 0x04000CFB RID: 3323
		private global::Org.BouncyCastle.Crypto.Tls.DtlsEpoch mCurrentEpoch;

		// Token: 0x04000CFC RID: 3324
		private global::Org.BouncyCastle.Crypto.Tls.DtlsEpoch mPendingEpoch;

		// Token: 0x04000CFD RID: 3325
		private global::Org.BouncyCastle.Crypto.Tls.DtlsEpoch mReadEpoch;

		// Token: 0x04000CFE RID: 3326
		private global::Org.BouncyCastle.Crypto.Tls.DtlsEpoch mWriteEpoch;

		// Token: 0x04000CFF RID: 3327
		private global::Org.BouncyCastle.Crypto.Tls.DtlsHandshakeRetransmit mRetransmit;

		// Token: 0x04000D00 RID: 3328
		private global::Org.BouncyCastle.Crypto.Tls.DtlsEpoch mRetransmitEpoch;

		// Token: 0x04000D01 RID: 3329
		private global::Org.BouncyCastle.Crypto.Tls.Timeout mRetransmitTimeout;
	}
}
