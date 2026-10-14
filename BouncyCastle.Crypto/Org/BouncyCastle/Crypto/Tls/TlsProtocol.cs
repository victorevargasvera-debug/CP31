using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200037A RID: 890
	public abstract class TlsProtocol : global::Org.BouncyCastle.Crypto.Tls.TlsCloseable
	{
		// Token: 0x0600241B RID: 9243 RVA: 0x0009CE64 File Offset: 0x0009B064
		public TlsProtocol(global::System.IO.Stream stream, global::Org.BouncyCastle.Security.SecureRandom secureRandom) : this(stream, stream, secureRandom)
		{
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x0009CE70 File Offset: 0x0009B070
		public TlsProtocol(global::System.IO.Stream input, global::System.IO.Stream output, global::Org.BouncyCastle.Security.SecureRandom secureRandom)
		{
			this.mApplicationDataQueue = new global::Org.BouncyCastle.Crypto.Tls.ByteQueue(0);
			this.mAlertQueue = new global::Org.BouncyCastle.Crypto.Tls.ByteQueue(2);
			this.mHandshakeQueue = new global::Org.BouncyCastle.Crypto.Tls.ByteQueue(0);
			this.mAppDataSplitEnabled = true;
			this.mBlocking = true;
			base..ctor();
			this.mRecordStream = new global::Org.BouncyCastle.Crypto.Tls.RecordStream(this, input, output);
			this.mSecureRandom = secureRandom;
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x0009CECC File Offset: 0x0009B0CC
		public TlsProtocol(global::Org.BouncyCastle.Security.SecureRandom secureRandom)
		{
			this.mApplicationDataQueue = new global::Org.BouncyCastle.Crypto.Tls.ByteQueue(0);
			this.mAlertQueue = new global::Org.BouncyCastle.Crypto.Tls.ByteQueue(2);
			this.mHandshakeQueue = new global::Org.BouncyCastle.Crypto.Tls.ByteQueue(0);
			this.mAppDataSplitEnabled = true;
			this.mBlocking = true;
			base..ctor();
			this.mBlocking = false;
			this.mInputBuffers = new global::Org.BouncyCastle.Crypto.Tls.ByteQueueStream();
			this.mOutputBuffer = new global::Org.BouncyCastle.Crypto.Tls.ByteQueueStream();
			this.mRecordStream = new global::Org.BouncyCastle.Crypto.Tls.RecordStream(this, this.mInputBuffers, this.mOutputBuffer);
			this.mSecureRandom = secureRandom;
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600241E RID: 9246
		protected abstract global::Org.BouncyCastle.Crypto.Tls.TlsContext Context { get; }

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600241F RID: 9247
		internal abstract global::Org.BouncyCastle.Crypto.Tls.AbstractTlsContext ContextAdmin { get; }

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06002420 RID: 9248
		protected abstract global::Org.BouncyCastle.Crypto.Tls.TlsPeer Peer { get; }

		// Token: 0x06002421 RID: 9249 RVA: 0x0009CF4F File Offset: 0x0009B14F
		protected virtual void HandleAlertMessage(byte alertLevel, byte alertDescription)
		{
			this.Peer.NotifyAlertReceived(alertLevel, alertDescription);
			if (alertLevel == 1)
			{
				this.HandleAlertWarningMessage(alertDescription);
				return;
			}
			this.HandleFailure();
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlertReceived(alertDescription);
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x0009CF76 File Offset: 0x0009B176
		protected virtual void HandleAlertWarningMessage(byte alertDescription)
		{
			if (alertDescription == 0)
			{
				if (!this.mAppDataReady)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
				}
				this.HandleClose(false);
			}
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0009CF94 File Offset: 0x0009B194
		protected virtual void HandleChangeCipherSpecMessage()
		{
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x0009CF98 File Offset: 0x0009B198
		protected virtual void HandleClose(bool user_canceled)
		{
			if (!this.mClosed)
			{
				this.mClosed = true;
				if (user_canceled && !this.mAppDataReady)
				{
					this.RaiseAlertWarning(90, "User canceled handshake");
				}
				this.RaiseAlertWarning(0, "Connection closed");
				this.mRecordStream.SafeClose();
				if (!this.mAppDataReady)
				{
					this.CleanupHandshake();
				}
			}
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x0009CFF9 File Offset: 0x0009B1F9
		protected virtual void HandleException(byte alertDescription, string message, global::System.Exception cause)
		{
			if (!this.mClosed)
			{
				this.RaiseAlertFatal(alertDescription, message, cause);
				this.HandleFailure();
			}
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x0009D014 File Offset: 0x0009B214
		protected virtual void HandleFailure()
		{
			this.mClosed = true;
			this.mFailedWithError = true;
			this.InvalidateSession();
			this.mRecordStream.SafeClose();
			if (!this.mAppDataReady)
			{
				this.CleanupHandshake();
			}
		}

		// Token: 0x06002427 RID: 9255
		protected abstract void HandleHandshakeMessage(byte type, global::System.IO.MemoryStream buf);

		// Token: 0x06002428 RID: 9256 RVA: 0x0009D04C File Offset: 0x0009B24C
		protected virtual void ApplyMaxFragmentLengthExtension()
		{
			if (this.mSecurityParameters.maxFragmentLength >= 0)
			{
				if (!global::Org.BouncyCastle.Crypto.Tls.MaxFragmentLength.IsValid((byte)this.mSecurityParameters.maxFragmentLength))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
				}
				int plainTextLimit = 1 << (int)(8 + this.mSecurityParameters.maxFragmentLength);
				this.mRecordStream.SetPlaintextLimit(plainTextLimit);
			}
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x0009D0A1 File Offset: 0x0009B2A1
		protected virtual void CheckReceivedChangeCipherSpec(bool expected)
		{
			if (expected != this.mReceivedChangeCipherSpec)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x0009D0B4 File Offset: 0x0009B2B4
		protected virtual void CleanupHandshake()
		{
			if (this.mExpectedVerifyData != null)
			{
				global::Org.BouncyCastle.Utilities.Arrays.Fill(this.mExpectedVerifyData, 0);
				this.mExpectedVerifyData = null;
			}
			this.mSecurityParameters.Clear();
			this.mPeerCertificate = null;
			this.mOfferedCipherSuites = null;
			this.mOfferedCompressionMethods = null;
			this.mClientExtensions = null;
			this.mServerExtensions = null;
			this.mResumedSession = false;
			this.mReceivedChangeCipherSpec = false;
			this.mSecureRenegotiation = false;
			this.mAllowCertificateStatus = false;
			this.mExpectSessionTicket = false;
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x0009D12D File Offset: 0x0009B32D
		protected virtual void BlockForHandshake()
		{
			if (this.mBlocking)
			{
				while (this.mConnectionState != 16)
				{
					if (this.mClosed)
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
					}
					this.SafeReadRecord();
				}
			}
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0009D15C File Offset: 0x0009B35C
		protected virtual void CompleteHandshake()
		{
			try
			{
				this.mConnectionState = 16;
				this.mAlertQueue.Shrink();
				this.mHandshakeQueue.Shrink();
				this.mRecordStream.FinaliseHandshake();
				this.mAppDataSplitEnabled = !global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV11(this.Context);
				if (!this.mAppDataReady)
				{
					this.mAppDataReady = true;
					if (this.mBlocking)
					{
						this.mTlsStream = new global::Org.BouncyCastle.Crypto.Tls.TlsStream(this);
					}
				}
				if (this.mTlsSession != null)
				{
					if (this.mSessionParameters == null)
					{
						this.mSessionParameters = new global::Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder().SetCipherSuite(this.mSecurityParameters.CipherSuite).SetCompressionAlgorithm(this.mSecurityParameters.CompressionAlgorithm).SetExtendedMasterSecret(this.mSecurityParameters.IsExtendedMasterSecret).SetMasterSecret(this.mSecurityParameters.MasterSecret).SetPeerCertificate(this.mPeerCertificate).SetPskIdentity(this.mSecurityParameters.PskIdentity).SetSrpIdentity(this.mSecurityParameters.SrpIdentity).SetServerExtensions(this.mServerExtensions).Build();
						this.mTlsSession = new global::Org.BouncyCastle.Crypto.Tls.TlsSessionImpl(this.mTlsSession.SessionID, this.mSessionParameters);
					}
					this.ContextAdmin.SetResumableSession(this.mTlsSession);
				}
				this.Peer.NotifyHandshakeComplete();
			}
			finally
			{
				this.CleanupHandshake();
			}
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x0009D2C8 File Offset: 0x0009B4C8
		protected internal void ProcessRecord(byte protocol, byte[] buf, int off, int len)
		{
			switch (protocol)
			{
			case 20:
				this.ProcessChangeCipherSpec(buf, off, len);
				return;
			case 21:
				this.mAlertQueue.AddData(buf, off, len);
				this.ProcessAlertQueue();
				return;
			case 22:
			{
				if (this.mHandshakeQueue.Available > 0)
				{
					this.mHandshakeQueue.AddData(buf, off, len);
					this.ProcessHandshakeQueue(this.mHandshakeQueue);
					return;
				}
				global::Org.BouncyCastle.Crypto.Tls.ByteQueue tmpQueue = new global::Org.BouncyCastle.Crypto.Tls.ByteQueue(buf, off, len);
				this.ProcessHandshakeQueue(tmpQueue);
				int remaining = tmpQueue.Available;
				if (remaining > 0)
				{
					this.mHandshakeQueue.AddData(buf, off + len - remaining, remaining);
					return;
				}
				return;
			}
			case 23:
				if (!this.mAppDataReady)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				this.mApplicationDataQueue.AddData(buf, off, len);
				this.ProcessApplicationDataQueue();
				return;
			default:
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x0009D3A0 File Offset: 0x0009B5A0
		private void ProcessHandshakeQueue(global::Org.BouncyCastle.Crypto.Tls.ByteQueue queue)
		{
			while (queue.Available >= 4)
			{
				byte[] beginning = new byte[4];
				queue.Read(beginning, 0, 4, 0);
				byte type = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(beginning, 0);
				int length = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(beginning, 1);
				int totalLength = 4 + length;
				if (queue.Available < totalLength)
				{
					break;
				}
				if (type != 0)
				{
					if (20 == type)
					{
						this.CheckReceivedChangeCipherSpec(true);
						global::Org.BouncyCastle.Crypto.Tls.TlsContext ctx = this.Context;
						if (this.mExpectedVerifyData == null && ctx.SecurityParameters.MasterSecret != null)
						{
							this.mExpectedVerifyData = this.CreateVerifyData(!ctx.IsServer);
						}
					}
					else
					{
						this.CheckReceivedChangeCipherSpec(this.mConnectionState == 16);
					}
					queue.CopyTo(this.mRecordStream.HandshakeHashUpdater, totalLength);
				}
				queue.RemoveData(4);
				global::System.IO.MemoryStream buf = queue.ReadFrom(length);
				this.HandleHandshakeMessage(type, buf);
			}
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x0009D46F File Offset: 0x0009B66F
		private void ProcessApplicationDataQueue()
		{
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x0009D474 File Offset: 0x0009B674
		private void ProcessAlertQueue()
		{
			while (this.mAlertQueue.Available >= 2)
			{
				byte[] array = this.mAlertQueue.RemoveData(2, 0);
				byte alertLevel = array[0];
				byte alertDescription = array[1];
				this.HandleAlertMessage(alertLevel, alertDescription);
			}
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x0009D4B0 File Offset: 0x0009B6B0
		private void ProcessChangeCipherSpec(byte[] buf, int off, int len)
		{
			for (int i = 0; i < len; i++)
			{
				if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf, off + i) != 1)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
				}
				if (this.mReceivedChangeCipherSpec || this.mAlertQueue.Available > 0 || this.mHandshakeQueue.Available > 0)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				this.mRecordStream.ReceivedReadCipherSpec();
				this.mReceivedChangeCipherSpec = true;
				this.HandleChangeCipherSpecMessage();
			}
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x0009D521 File Offset: 0x0009B721
		protected internal virtual int ApplicationDataAvailable()
		{
			return this.mApplicationDataQueue.Available;
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x0009D530 File Offset: 0x0009B730
		protected internal virtual int ReadApplicationData(byte[] buf, int offset, int len)
		{
			if (len < 1)
			{
				return 0;
			}
			while (this.mApplicationDataQueue.Available == 0)
			{
				if (this.mClosed)
				{
					if (this.mFailedWithError)
					{
						throw new global::System.IO.IOException("Cannot read application data on failed TLS connection");
					}
					if (!this.mAppDataReady)
					{
						throw new global::System.InvalidOperationException("Cannot read application data until initial handshake completed.");
					}
					return 0;
				}
				else
				{
					this.SafeReadRecord();
				}
			}
			len = global::System.Math.Min(len, this.mApplicationDataQueue.Available);
			this.mApplicationDataQueue.RemoveData(buf, offset, len, 0);
			return len;
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x0009D5B0 File Offset: 0x0009B7B0
		protected virtual void SafeCheckRecordHeader(byte[] recordHeader)
		{
			try
			{
				this.mRecordStream.CheckRecordHeader(recordHeader);
			}
			catch (global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert e)
			{
				this.HandleException(e.AlertDescription, "Failed to read record", e);
				throw e;
			}
			catch (global::System.IO.IOException e2)
			{
				this.HandleException(80, "Failed to read record", e2);
				throw e2;
			}
			catch (global::System.Exception e3)
			{
				this.HandleException(80, "Failed to read record", e3);
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80, e3);
			}
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x0009D634 File Offset: 0x0009B834
		protected virtual void SafeReadRecord()
		{
			try
			{
				if (this.mRecordStream.ReadRecord())
				{
					return;
				}
				if (!this.mAppDataReady)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
				}
			}
			catch (global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlertReceived tlsFatalAlertReceived)
			{
				throw tlsFatalAlertReceived;
			}
			catch (global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert e)
			{
				this.HandleException(e.AlertDescription, "Failed to read record", e);
				throw e;
			}
			catch (global::System.IO.IOException e2)
			{
				this.HandleException(80, "Failed to read record", e2);
				throw e2;
			}
			catch (global::System.Exception e3)
			{
				this.HandleException(80, "Failed to read record", e3);
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80, e3);
			}
			this.HandleFailure();
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsNoCloseNotifyException();
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x0009D6E4 File Offset: 0x0009B8E4
		protected virtual void SafeWriteRecord(byte type, byte[] buf, int offset, int len)
		{
			try
			{
				this.mRecordStream.WriteRecord(type, buf, offset, len);
			}
			catch (global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert e)
			{
				this.HandleException(e.AlertDescription, "Failed to write record", e);
				throw e;
			}
			catch (global::System.IO.IOException e2)
			{
				this.HandleException(80, "Failed to write record", e2);
				throw e2;
			}
			catch (global::System.Exception e3)
			{
				this.HandleException(80, "Failed to write record", e3);
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80, e3);
			}
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x0009D76C File Offset: 0x0009B96C
		protected internal virtual void WriteData(byte[] buf, int offset, int len)
		{
			if (this.mClosed)
			{
				throw new global::System.IO.IOException("Cannot write application data on closed/failed TLS connection");
			}
			while (len > 0)
			{
				if (this.mAppDataSplitEnabled)
				{
					switch (this.mAppDataSplitMode)
					{
					case 1:
						this.SafeWriteRecord(23, global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes, 0, 0);
						goto IL_7F;
					case 2:
						this.mAppDataSplitEnabled = false;
						this.SafeWriteRecord(23, global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes, 0, 0);
						goto IL_7F;
					}
					this.SafeWriteRecord(23, buf, offset, 1);
					offset++;
					len--;
				}
				IL_7F:
				if (len > 0)
				{
					int toWrite = global::System.Math.Min(len, this.mRecordStream.GetPlaintextLimit());
					this.SafeWriteRecord(23, buf, offset, toWrite);
					offset += toWrite;
					len -= toWrite;
				}
			}
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x0009D82A File Offset: 0x0009BA2A
		protected virtual void SetAppDataSplitMode(int appDataSplitMode)
		{
			if (appDataSplitMode < 0 || appDataSplitMode > 2)
			{
				throw new global::System.ArgumentException("Illegal appDataSplitMode mode: " + appDataSplitMode.ToString(), "appDataSplitMode");
			}
			this.mAppDataSplitMode = appDataSplitMode;
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x0009D85C File Offset: 0x0009BA5C
		protected virtual void WriteHandshakeMessage(byte[] buf, int off, int len)
		{
			if (len < 4)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf, off) != 0)
			{
				this.mRecordStream.HandshakeHashUpdater.Write(buf, off, len);
			}
			int total = 0;
			do
			{
				int toWrite = global::System.Math.Min(len - total, this.mRecordStream.GetPlaintextLimit());
				this.SafeWriteRecord(22, buf, off + total, toWrite);
				total += toWrite;
			}
			while (total < len);
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x0009D8BC File Offset: 0x0009BABC
		public virtual global::System.IO.Stream Stream
		{
			get
			{
				if (!this.mBlocking)
				{
					throw new global::System.InvalidOperationException("Cannot use Stream in non-blocking mode! Use OfferInput()/OfferOutput() instead.");
				}
				return this.mTlsStream;
			}
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x0009D8D8 File Offset: 0x0009BAD8
		public virtual void CloseInput()
		{
			if (this.mBlocking)
			{
				throw new global::System.InvalidOperationException("Cannot use CloseInput() in blocking mode!");
			}
			if (this.mClosed)
			{
				return;
			}
			if (this.mInputBuffers.Available > 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			if (!this.mAppDataReady)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsNoCloseNotifyException();
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x0009D92E File Offset: 0x0009BB2E
		public virtual void OfferInput(byte[] input)
		{
			this.OfferInput(input, 0, input.Length);
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x0009D93C File Offset: 0x0009BB3C
		public virtual void OfferInput(byte[] input, int inputOff, int inputLen)
		{
			if (this.mBlocking)
			{
				throw new global::System.InvalidOperationException("Cannot use OfferInput() in blocking mode! Use Stream instead.");
			}
			if (this.mClosed)
			{
				throw new global::System.IO.IOException("Connection is closed, cannot accept any more input");
			}
			this.mInputBuffers.Write(input, inputOff, inputLen);
			while (this.mInputBuffers.Available >= 5)
			{
				byte[] recordHeader = new byte[5];
				this.mInputBuffers.Peek(recordHeader);
				int totalLength = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(recordHeader, 3) + 5;
				if (this.mInputBuffers.Available < totalLength)
				{
					this.SafeCheckRecordHeader(recordHeader);
					return;
				}
				this.SafeReadRecord();
				if (this.mClosed)
				{
					if (this.mConnectionState != 16)
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
					}
					break;
				}
			}
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x0009D9E5 File Offset: 0x0009BBE5
		public virtual int GetAvailableInputBytes()
		{
			if (this.mBlocking)
			{
				throw new global::System.InvalidOperationException("Cannot use GetAvailableInputBytes() in blocking mode! Use ApplicationDataAvailable() instead.");
			}
			return this.ApplicationDataAvailable();
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x0009DA00 File Offset: 0x0009BC00
		public virtual int ReadInput(byte[] buffer, int offset, int length)
		{
			if (this.mBlocking)
			{
				throw new global::System.InvalidOperationException("Cannot use ReadInput() in blocking mode! Use Stream instead.");
			}
			return this.ReadApplicationData(buffer, offset, global::System.Math.Min(length, this.ApplicationDataAvailable()));
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x0009DA29 File Offset: 0x0009BC29
		public virtual void OfferOutput(byte[] buffer, int offset, int length)
		{
			if (this.mBlocking)
			{
				throw new global::System.InvalidOperationException("Cannot use OfferOutput() in blocking mode! Use Stream instead.");
			}
			if (!this.mAppDataReady)
			{
				throw new global::System.IO.IOException("Application data cannot be sent until the handshake is complete!");
			}
			this.WriteData(buffer, offset, length);
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x0009DA5C File Offset: 0x0009BC5C
		public virtual int GetAvailableOutputBytes()
		{
			if (this.mBlocking)
			{
				throw new global::System.InvalidOperationException("Cannot use GetAvailableOutputBytes() in blocking mode! Use Stream instead.");
			}
			return this.mOutputBuffer.Available;
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x0009DA7C File Offset: 0x0009BC7C
		public virtual int ReadOutput(byte[] buffer, int offset, int length)
		{
			if (this.mBlocking)
			{
				throw new global::System.InvalidOperationException("Cannot use ReadOutput() in blocking mode! Use Stream instead.");
			}
			return this.mOutputBuffer.Read(buffer, offset, length);
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x0009DA9F File Offset: 0x0009BC9F
		protected virtual void InvalidateSession()
		{
			if (this.mSessionParameters != null)
			{
				this.mSessionParameters.Clear();
				this.mSessionParameters = null;
			}
			if (this.mTlsSession != null)
			{
				this.mTlsSession.Invalidate();
				this.mTlsSession = null;
			}
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
		protected virtual void ProcessFinishedMessage(global::System.IO.MemoryStream buf)
		{
			if (this.mExpectedVerifyData == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			byte[] verify_data = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(this.mExpectedVerifyData.Length, buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
			if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.mExpectedVerifyData, verify_data))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(51);
			}
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x0009DB20 File Offset: 0x0009BD20
		protected virtual void RaiseAlertFatal(byte alertDescription, string message, global::System.Exception cause)
		{
			this.Peer.NotifyAlertRaised(2, alertDescription, message, cause);
			byte[] alert = new byte[]
			{
				2,
				alertDescription
			};
			try
			{
				this.mRecordStream.WriteRecord(21, alert, 0, 2);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x0009DB70 File Offset: 0x0009BD70
		protected virtual void RaiseAlertWarning(byte alertDescription, string message)
		{
			this.Peer.NotifyAlertRaised(1, alertDescription, message, null);
			byte[] alert = new byte[]
			{
				1,
				alertDescription
			};
			this.SafeWriteRecord(21, alert, 0, 2);
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x0009DBA8 File Offset: 0x0009BDA8
		protected virtual void SendCertificateMessage(global::Org.BouncyCastle.Crypto.Tls.Certificate certificate)
		{
			if (certificate == null)
			{
				certificate = global::Org.BouncyCastle.Crypto.Tls.Certificate.EmptyChain;
			}
			if (certificate.IsEmpty && !this.Context.IsServer)
			{
				global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion serverVersion = this.Context.ServerVersion;
				if (serverVersion.IsSsl)
				{
					string errorMessage = serverVersion.ToString() + " client didn't provide credentials";
					this.RaiseAlertWarning(41, errorMessage);
					return;
				}
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage message = new global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage(11);
			certificate.Encode(message);
			message.WriteToRecordStream(this);
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x0009DC1C File Offset: 0x0009BE1C
		protected virtual void SendChangeCipherSpecMessage()
		{
			byte[] message = new byte[]
			{
				1
			};
			this.SafeWriteRecord(20, message, 0, message.Length);
			this.mRecordStream.SentWriteCipherSpec();
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x0009DC4C File Offset: 0x0009BE4C
		protected virtual void SendFinishedMessage()
		{
			byte[] verify_data = this.CreateVerifyData(this.Context.IsServer);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage handshakeMessage = new global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage(20, verify_data.Length);
			handshakeMessage.Write(verify_data, 0, verify_data.Length);
			handshakeMessage.WriteToRecordStream(this);
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x0009DC86 File Offset: 0x0009BE86
		protected virtual void SendSupplementalDataMessage(global::System.Collections.IList supplementalData)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage handshakeMessage = new global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage(23);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteSupplementalData(handshakeMessage, supplementalData);
			handshakeMessage.WriteToRecordStream(this);
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x0009DC9C File Offset: 0x0009BE9C
		protected virtual byte[] CreateVerifyData(bool isServer)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsContext context = this.Context;
			string asciiLabel = isServer ? "server finished" : "client finished";
			byte[] sslSender = isServer ? global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.SSL_SERVER : global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.SSL_CLIENT;
			byte[] hash = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(context, this.mRecordStream.HandshakeHash, sslSender);
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateVerifyData(context, asciiLabel, hash);
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x0009DCE9 File Offset: 0x0009BEE9
		public virtual void Close()
		{
			this.HandleClose(true);
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x0009DCF2 File Offset: 0x0009BEF2
		protected internal virtual void Flush()
		{
			this.mRecordStream.Flush();
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x0009DCFF File Offset: 0x0009BEFF
		public virtual bool IsClosed
		{
			get
			{
				return this.mClosed;
			}
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x0009DD0C File Offset: 0x0009BF0C
		protected virtual short ProcessMaxFragmentLengthExtension(global::System.Collections.IDictionary clientExtensions, global::System.Collections.IDictionary serverExtensions, byte alertDescription)
		{
			short maxFragmentLength = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(serverExtensions);
			if (maxFragmentLength >= 0 && (!global::Org.BouncyCastle.Crypto.Tls.MaxFragmentLength.IsValid((byte)maxFragmentLength) || (!this.mResumedSession && maxFragmentLength != global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(clientExtensions))))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription);
			}
			return maxFragmentLength;
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x0009DD46 File Offset: 0x0009BF46
		protected virtual void RefuseRenegotiation()
		{
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(this.Context))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
			this.RaiseAlertWarning(100, "Renegotiation not supported");
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x0009DD6A File Offset: 0x0009BF6A
		protected internal static void AssertEmpty(global::System.IO.MemoryStream buf)
		{
			if (buf.Position < buf.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x0009DD84 File Offset: 0x0009BF84
		protected internal static byte[] CreateRandomBlock(bool useGmtUnixTime, global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator randomGenerator)
		{
			byte[] result = new byte[32];
			randomGenerator.NextBytes(result);
			if (useGmtUnixTime)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteGmtUnixTime(result, 0);
			}
			return result;
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x0009DDAB File Offset: 0x0009BFAB
		protected internal static byte[] CreateRenegotiationInfo(byte[] renegotiated_connection)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeOpaque8(renegotiated_connection);
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x0009DDB4 File Offset: 0x0009BFB4
		protected internal static void EstablishMasterSecret(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange keyExchange)
		{
			byte[] pre_master_secret = keyExchange.GeneratePremasterSecret();
			try
			{
				context.SecurityParameters.masterSecret = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateMasterSecret(context, pre_master_secret);
			}
			finally
			{
				if (pre_master_secret != null)
				{
					global::Org.BouncyCastle.Utilities.Arrays.Fill(pre_master_secret, 0);
				}
			}
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x0009DDF8 File Offset: 0x0009BFF8
		protected internal static byte[] GetCurrentPrfHash(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash handshakeHash, byte[] sslSender)
		{
			global::Org.BouncyCastle.Crypto.IDigest d = handshakeHash.ForkPrfHash();
			if (sslSender != null && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context))
			{
				d.BlockUpdate(sslSender, 0, sslSender.Length);
			}
			return global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(d);
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x0009DE28 File Offset: 0x0009C028
		protected internal static global::System.Collections.IDictionary ReadExtensions(global::System.IO.MemoryStream input)
		{
			if (input.Position >= input.Length)
			{
				return null;
			}
			byte[] buffer = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(input);
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(buffer, false);
			global::System.Collections.IDictionary extensions = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			while (buf.Position < buf.Length)
			{
				int extension_type = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(buf);
				byte[] extension_data = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(buf);
				if (extensions.Contains(extension_type))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
				extensions.Add(extension_type, extension_data);
			}
			return extensions;
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x0009DEA0 File Offset: 0x0009C0A0
		protected internal static global::System.Collections.IList ReadSupplementalDataMessage(global::System.IO.MemoryStream input)
		{
			byte[] buffer = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque24(input);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(input);
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(buffer, false);
			global::System.Collections.IList supplementalData = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (buf.Position < buf.Length)
			{
				int supp_data_type = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(buf);
				byte[] data = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(buf);
				supplementalData.Add(new global::Org.BouncyCastle.Crypto.Tls.SupplementalDataEntry(supp_data_type, data));
			}
			return supplementalData;
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x0009DEF3 File Offset: 0x0009C0F3
		protected internal static void WriteExtensions(global::System.IO.Stream output, global::System.Collections.IDictionary extensions)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteSelectedExtensions(memoryStream, extensions, true);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteSelectedExtensions(memoryStream, extensions, false);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(memoryStream.ToArray(), output);
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x0009DF18 File Offset: 0x0009C118
		protected internal static void WriteSelectedExtensions(global::System.IO.Stream output, global::System.Collections.IDictionary extensions, bool selectEmpty)
		{
			foreach (object obj in extensions.Keys)
			{
				int extension_type = (int)obj;
				byte[] extension_data = (byte[])extensions[extension_type];
				if (selectEmpty == (extension_data.Length == 0))
				{
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(extension_type);
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(extension_type, output);
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(extension_data, output);
				}
			}
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x0009DF98 File Offset: 0x0009C198
		protected internal static void WriteSupplementalData(global::System.IO.Stream output, global::System.Collections.IList supplementalData)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			foreach (object obj in supplementalData)
			{
				global::Org.BouncyCastle.Crypto.Tls.SupplementalDataEntry supplementalDataEntry = (global::Org.BouncyCastle.Crypto.Tls.SupplementalDataEntry)obj;
				int dataType = supplementalDataEntry.DataType;
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(dataType);
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(dataType, buf);
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(supplementalDataEntry.Data, buf);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque24(buf.ToArray(), output);
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x0009E014 File Offset: 0x0009C214
		protected internal static int GetPrfAlgorithm(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int ciphersuite)
		{
			bool isTLSv12 = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context);
			if (ciphersuite <= 197)
			{
				if (ciphersuite - 59 > 5 && ciphersuite - 103 > 6)
				{
					switch (ciphersuite)
					{
					case 156:
					case 158:
					case 160:
					case 162:
					case 164:
					case 166:
					case 168:
					case 170:
					case 172:
					case 186:
					case 187:
					case 188:
					case 189:
					case 190:
					case 191:
					case 192:
					case 193:
					case 194:
					case 195:
					case 196:
					case 197:
						break;
					case 157:
					case 159:
					case 161:
					case 163:
					case 165:
					case 167:
					case 169:
					case 171:
					case 173:
						goto IL_340;
					case 174:
					case 176:
					case 178:
					case 180:
					case 182:
					case 184:
						goto IL_354;
					case 175:
					case 177:
					case 179:
					case 181:
					case 183:
					case 185:
						goto IL_34D;
					default:
						goto IL_354;
					}
				}
			}
			else
			{
				switch (ciphersuite)
				{
				case 49187:
				case 49189:
				case 49191:
				case 49193:
				case 49195:
				case 49197:
				case 49199:
				case 49201:
				case 49266:
				case 49268:
				case 49270:
				case 49272:
				case 49274:
				case 49276:
				case 49278:
				case 49280:
				case 49282:
				case 49284:
				case 49286:
				case 49288:
				case 49290:
				case 49292:
				case 49294:
				case 49296:
				case 49298:
				case 49308:
				case 49309:
				case 49310:
				case 49311:
				case 49312:
				case 49313:
				case 49314:
				case 49315:
				case 49316:
				case 49317:
				case 49318:
				case 49319:
				case 49320:
				case 49321:
				case 49322:
				case 49323:
				case 49324:
				case 49325:
				case 49326:
				case 49327:
					break;
				case 49188:
				case 49190:
				case 49192:
				case 49194:
				case 49196:
				case 49198:
				case 49200:
				case 49202:
				case 49267:
				case 49269:
				case 49271:
				case 49273:
				case 49275:
				case 49277:
				case 49279:
				case 49281:
				case 49283:
				case 49285:
				case 49287:
				case 49289:
				case 49291:
				case 49293:
				case 49295:
				case 49297:
				case 49299:
					goto IL_340;
				case 49203:
				case 49204:
				case 49205:
				case 49206:
				case 49207:
				case 49209:
				case 49210:
				case 49212:
				case 49213:
				case 49214:
				case 49215:
				case 49216:
				case 49217:
				case 49218:
				case 49219:
				case 49220:
				case 49221:
				case 49222:
				case 49223:
				case 49224:
				case 49225:
				case 49226:
				case 49227:
				case 49228:
				case 49229:
				case 49230:
				case 49231:
				case 49232:
				case 49233:
				case 49234:
				case 49235:
				case 49236:
				case 49237:
				case 49238:
				case 49239:
				case 49240:
				case 49241:
				case 49242:
				case 49243:
				case 49244:
				case 49245:
				case 49246:
				case 49247:
				case 49248:
				case 49249:
				case 49250:
				case 49251:
				case 49252:
				case 49253:
				case 49254:
				case 49255:
				case 49256:
				case 49257:
				case 49258:
				case 49259:
				case 49260:
				case 49261:
				case 49262:
				case 49263:
				case 49264:
				case 49265:
				case 49300:
				case 49302:
				case 49304:
				case 49306:
					goto IL_354;
				case 49208:
				case 49211:
				case 49301:
				case 49303:
				case 49305:
				case 49307:
					goto IL_34D;
				default:
					if (ciphersuite - 52392 > 1 && ciphersuite - 52395 > 3)
					{
						goto IL_354;
					}
					break;
				}
			}
			if (isTLSv12)
			{
				return 1;
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			IL_340:
			if (isTLSv12)
			{
				return 2;
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			IL_34D:
			if (isTLSv12)
			{
				return 2;
			}
			return 0;
			IL_354:
			if (isTLSv12)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x04000E77 RID: 3703
		protected const short CS_START = 0;

		// Token: 0x04000E78 RID: 3704
		protected const short CS_CLIENT_HELLO = 1;

		// Token: 0x04000E79 RID: 3705
		protected const short CS_SERVER_HELLO = 2;

		// Token: 0x04000E7A RID: 3706
		protected const short CS_SERVER_SUPPLEMENTAL_DATA = 3;

		// Token: 0x04000E7B RID: 3707
		protected const short CS_SERVER_CERTIFICATE = 4;

		// Token: 0x04000E7C RID: 3708
		protected const short CS_CERTIFICATE_STATUS = 5;

		// Token: 0x04000E7D RID: 3709
		protected const short CS_SERVER_KEY_EXCHANGE = 6;

		// Token: 0x04000E7E RID: 3710
		protected const short CS_CERTIFICATE_REQUEST = 7;

		// Token: 0x04000E7F RID: 3711
		protected const short CS_SERVER_HELLO_DONE = 8;

		// Token: 0x04000E80 RID: 3712
		protected const short CS_CLIENT_SUPPLEMENTAL_DATA = 9;

		// Token: 0x04000E81 RID: 3713
		protected const short CS_CLIENT_CERTIFICATE = 10;

		// Token: 0x04000E82 RID: 3714
		protected const short CS_CLIENT_KEY_EXCHANGE = 11;

		// Token: 0x04000E83 RID: 3715
		protected const short CS_CERTIFICATE_VERIFY = 12;

		// Token: 0x04000E84 RID: 3716
		protected const short CS_CLIENT_FINISHED = 13;

		// Token: 0x04000E85 RID: 3717
		protected const short CS_SERVER_SESSION_TICKET = 14;

		// Token: 0x04000E86 RID: 3718
		protected const short CS_SERVER_FINISHED = 15;

		// Token: 0x04000E87 RID: 3719
		protected const short CS_END = 16;

		// Token: 0x04000E88 RID: 3720
		protected const short ADS_MODE_1_Nsub1 = 0;

		// Token: 0x04000E89 RID: 3721
		protected const short ADS_MODE_0_N = 1;

		// Token: 0x04000E8A RID: 3722
		protected const short ADS_MODE_0_N_FIRSTONLY = 2;

		// Token: 0x04000E8B RID: 3723
		private global::Org.BouncyCastle.Crypto.Tls.ByteQueue mApplicationDataQueue;

		// Token: 0x04000E8C RID: 3724
		private global::Org.BouncyCastle.Crypto.Tls.ByteQueue mAlertQueue;

		// Token: 0x04000E8D RID: 3725
		private global::Org.BouncyCastle.Crypto.Tls.ByteQueue mHandshakeQueue;

		// Token: 0x04000E8E RID: 3726
		internal global::Org.BouncyCastle.Crypto.Tls.RecordStream mRecordStream;

		// Token: 0x04000E8F RID: 3727
		protected global::Org.BouncyCastle.Security.SecureRandom mSecureRandom;

		// Token: 0x04000E90 RID: 3728
		private global::Org.BouncyCastle.Crypto.Tls.TlsStream mTlsStream;

		// Token: 0x04000E91 RID: 3729
		private volatile bool mClosed;

		// Token: 0x04000E92 RID: 3730
		private volatile bool mFailedWithError;

		// Token: 0x04000E93 RID: 3731
		private volatile bool mAppDataReady;

		// Token: 0x04000E94 RID: 3732
		private volatile bool mAppDataSplitEnabled;

		// Token: 0x04000E95 RID: 3733
		private volatile int mAppDataSplitMode;

		// Token: 0x04000E96 RID: 3734
		private byte[] mExpectedVerifyData;

		// Token: 0x04000E97 RID: 3735
		protected global::Org.BouncyCastle.Crypto.Tls.TlsSession mTlsSession;

		// Token: 0x04000E98 RID: 3736
		protected global::Org.BouncyCastle.Crypto.Tls.SessionParameters mSessionParameters;

		// Token: 0x04000E99 RID: 3737
		protected global::Org.BouncyCastle.Crypto.Tls.SecurityParameters mSecurityParameters;

		// Token: 0x04000E9A RID: 3738
		protected global::Org.BouncyCastle.Crypto.Tls.Certificate mPeerCertificate;

		// Token: 0x04000E9B RID: 3739
		protected int[] mOfferedCipherSuites;

		// Token: 0x04000E9C RID: 3740
		protected byte[] mOfferedCompressionMethods;

		// Token: 0x04000E9D RID: 3741
		protected global::System.Collections.IDictionary mClientExtensions;

		// Token: 0x04000E9E RID: 3742
		protected global::System.Collections.IDictionary mServerExtensions;

		// Token: 0x04000E9F RID: 3743
		protected short mConnectionState;

		// Token: 0x04000EA0 RID: 3744
		protected bool mResumedSession;

		// Token: 0x04000EA1 RID: 3745
		protected bool mReceivedChangeCipherSpec;

		// Token: 0x04000EA2 RID: 3746
		protected bool mSecureRenegotiation;

		// Token: 0x04000EA3 RID: 3747
		protected bool mAllowCertificateStatus;

		// Token: 0x04000EA4 RID: 3748
		protected bool mExpectSessionTicket;

		// Token: 0x04000EA5 RID: 3749
		protected bool mBlocking;

		// Token: 0x04000EA6 RID: 3750
		protected global::Org.BouncyCastle.Crypto.Tls.ByteQueueStream mInputBuffers;

		// Token: 0x04000EA7 RID: 3751
		protected global::Org.BouncyCastle.Crypto.Tls.ByteQueueStream mOutputBuffer;

		// Token: 0x02000801 RID: 2049
		internal class HandshakeMessage : global::System.IO.MemoryStream
		{
			// Token: 0x0600464F RID: 17999 RVA: 0x00136519 File Offset: 0x00134719
			internal HandshakeMessage(byte handshakeType) : this(handshakeType, 60)
			{
			}

			// Token: 0x06004650 RID: 18000 RVA: 0x00136524 File Offset: 0x00134724
			internal HandshakeMessage(byte handshakeType, int length) : base(length + 4)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(handshakeType, this);
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(0, this);
			}

			// Token: 0x06004651 RID: 18001 RVA: 0x0013653D File Offset: 0x0013473D
			internal void Write(byte[] data)
			{
				this.Write(data, 0, data.Length);
			}

			// Token: 0x06004652 RID: 18002 RVA: 0x0013654C File Offset: 0x0013474C
			internal void WriteToRecordStream(global::Org.BouncyCastle.Crypto.Tls.TlsProtocol protocol)
			{
				long num = this.Length - 4L;
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint24(num);
				this.Position = 1L;
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24((int)num, this);
				byte[] buf = this.GetBuffer();
				int bufLen = (int)this.Length;
				protocol.WriteHandshakeMessage(buf, 0, bufLen);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this);
			}
		}
	}
}
