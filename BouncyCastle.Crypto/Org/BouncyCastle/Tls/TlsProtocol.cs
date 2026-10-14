using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000117 RID: 279
	public abstract class TlsProtocol : global::Org.BouncyCastle.Tls.TlsCloseable
	{
		// Token: 0x06000A92 RID: 2706 RVA: 0x00027864 File Offset: 0x00025A64
		protected bool IsLegacyConnectionState()
		{
			switch (this.m_connectionState)
			{
			case 0:
			case 1:
			case 4:
			case 6:
			case 7:
			case 8:
			case 10:
			case 11:
			case 12:
			case 14:
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
			case 21:
				return true;
			}
			return false;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000278DC File Offset: 0x00025ADC
		protected bool IsTlsV13ConnectionState()
		{
			switch (this.m_connectionState)
			{
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 7:
			case 9:
			case 11:
			case 13:
			case 15:
			case 17:
			case 18:
			case 20:
			case 21:
				return true;
			}
			return false;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00027954 File Offset: 0x00025B54
		protected TlsProtocol()
		{
			this.m_blocking = false;
			this.m_inputBuffers = new global::Org.BouncyCastle.Tls.ByteQueueInputStream();
			this.m_outputBuffer = new global::Org.BouncyCastle.Tls.ByteQueueOutputStream();
			this.m_recordStream = new global::Org.BouncyCastle.Tls.RecordStream(this, this.m_inputBuffers, this.m_outputBuffer);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000279E2 File Offset: 0x00025BE2
		public TlsProtocol(global::System.IO.Stream stream) : this(stream, stream)
		{
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000279EC File Offset: 0x00025BEC
		public TlsProtocol(global::System.IO.Stream input, global::System.IO.Stream output)
		{
			this.m_blocking = true;
			this.m_inputBuffers = null;
			this.m_outputBuffer = null;
			this.m_recordStream = new global::Org.BouncyCastle.Tls.RecordStream(this, input, output);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00027A68 File Offset: 0x00025C68
		public virtual void ResumeHandshake()
		{
			if (!this.m_blocking)
			{
				throw new global::System.InvalidOperationException("Cannot use ResumeHandshake() in non-blocking mode!");
			}
			if (!this.IsHandshaking)
			{
				throw new global::System.InvalidOperationException("No handshake in progress");
			}
			this.BlockForHandshake();
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00027A96 File Offset: 0x00025C96
		protected virtual void CloseConnection()
		{
			this.m_recordStream.Close();
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000A99 RID: 2713
		protected abstract global::Org.BouncyCastle.Tls.TlsContext Context { get; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000A9A RID: 2714
		internal abstract global::Org.BouncyCastle.Tls.AbstractTlsContext ContextAdmin { get; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000A9B RID: 2715
		protected abstract global::Org.BouncyCastle.Tls.TlsPeer Peer { get; }

		// Token: 0x06000A9C RID: 2716 RVA: 0x00027AA3 File Offset: 0x00025CA3
		protected virtual void HandleAlertMessage(short alertLevel, short alertDescription)
		{
			this.Peer.NotifyAlertReceived(alertLevel, alertDescription);
			if (alertLevel == 1)
			{
				this.HandleAlertWarningMessage(alertDescription);
				return;
			}
			this.HandleFailure();
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlertReceived(alertDescription);
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00027ACA File Offset: 0x00025CCA
		protected virtual void HandleAlertWarningMessage(short alertDescription)
		{
			if (alertDescription != 0)
			{
				if (alertDescription == 41)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				if (alertDescription != 100)
				{
					return;
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
			}
			else
			{
				if (!this.m_appDataReady)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
				}
				this.HandleClose(false);
				return;
			}
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00027B03 File Offset: 0x00025D03
		protected virtual void HandleChangeCipherSpecMessage()
		{
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00027B08 File Offset: 0x00025D08
		protected virtual void HandleClose(bool user_canceled)
		{
			if (!this.m_closed)
			{
				this.m_closed = true;
				if (!this.m_appDataReady)
				{
					this.CleanupHandshake();
					if (user_canceled)
					{
						this.RaiseAlertWarning(90, "User canceled handshake");
					}
				}
				this.RaiseAlertWarning(0, "Connection closed");
				this.CloseConnection();
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00027B5A File Offset: 0x00025D5A
		protected virtual void HandleException(short alertDescription, string message, global::System.Exception e)
		{
			if (!this.m_closed)
			{
				this.RaiseAlertFatal(alertDescription, message, e);
				this.HandleFailure();
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00027B75 File Offset: 0x00025D75
		protected virtual void HandleFailure()
		{
			this.m_closed = true;
			this.m_failedWithError = true;
			this.InvalidateSession();
			if (!this.m_appDataReady)
			{
				this.CleanupHandshake();
			}
			this.CloseConnection();
		}

		// Token: 0x06000AA2 RID: 2722
		protected abstract void HandleHandshakeMessage(short type, global::Org.BouncyCastle.Tls.HandshakeMessageInput buf);

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00027BA8 File Offset: 0x00025DA8
		protected virtual void ApplyMaxFragmentLengthExtension(short maxFragmentLength)
		{
			if (maxFragmentLength >= 0)
			{
				if (!global::Org.BouncyCastle.Tls.MaxFragmentLength.IsValid(maxFragmentLength))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				int plainTextLimit = 1 << (int)(8 + maxFragmentLength);
				this.m_recordStream.SetPlaintextLimit(plainTextLimit);
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00027BDE File Offset: 0x00025DDE
		protected virtual void CheckReceivedChangeCipherSpec(bool expected)
		{
			if (expected != this.m_receivedChangeCipherSpec)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00027BF1 File Offset: 0x00025DF1
		protected virtual void BlockForHandshake()
		{
			while (this.m_connectionState != 21)
			{
				if (this.IsClosed)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				this.SafeReadRecord();
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00027C18 File Offset: 0x00025E18
		protected virtual void BeginHandshake()
		{
			global::Org.BouncyCastle.Tls.AbstractTlsContext context = this.ContextAdmin;
			global::Org.BouncyCastle.Tls.TlsPeer peer = this.Peer;
			this.m_maxHandshakeMessageSize = global::System.Math.Max(1024, peer.GetMaxHandshakeMessageSize());
			this.m_handshakeHash = new global::Org.BouncyCastle.Tls.DeferredHash(context);
			this.m_connectionState = 0;
			this.m_resumedSession = false;
			this.m_selectedPsk13 = false;
			context.HandshakeBeginning(peer);
			context.SecurityParameters.m_extendedPadding = peer.ShouldUseExtendedPadding();
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00027C84 File Offset: 0x00025E84
		protected virtual void CleanupHandshake()
		{
			global::Org.BouncyCastle.Tls.TlsContext context = this.Context;
			if (context != null)
			{
				global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
				if (securityParameters != null)
				{
					securityParameters.Clear();
				}
			}
			this.m_tlsSession = null;
			this.m_sessionParameters = null;
			this.m_sessionMasterSecret = null;
			this.m_retryCookie = null;
			this.m_retryGroup = -1;
			this.m_clientExtensions = null;
			this.m_serverExtensions = null;
			this.m_resumedSession = false;
			this.m_selectedPsk13 = false;
			this.m_receivedChangeCipherSpec = false;
			this.m_expectSessionTicket = false;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00027CF8 File Offset: 0x00025EF8
		protected virtual void CompleteHandshake()
		{
			try
			{
				global::Org.BouncyCastle.Tls.AbstractTlsContext context = this.ContextAdmin;
				global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
				if (!context.IsHandshaking || securityParameters.LocalVerifyData == null || securityParameters.PeerVerifyData == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				this.m_recordStream.FinaliseHandshake();
				this.m_connectionState = 21;
				this.m_handshakeHash = new global::Org.BouncyCastle.Tls.DeferredHash(context);
				this.m_alertQueue.Shrink();
				this.m_handshakeQueue.Shrink();
				global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
				this.m_appDataSplitEnabled = !global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV11(negotiatedVersion);
				this.m_appDataReady = true;
				this.m_keyUpdateEnabled = global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(negotiatedVersion);
				if (this.m_blocking)
				{
					this.m_tlsStream = new global::Org.BouncyCastle.Tls.TlsStream(this);
				}
				if (this.m_sessionParameters == null)
				{
					this.m_sessionMasterSecret = securityParameters.MasterSecret;
					this.m_sessionParameters = new global::Org.BouncyCastle.Tls.SessionParameters.Builder().SetCipherSuite(securityParameters.CipherSuite).SetExtendedMasterSecret(securityParameters.IsExtendedMasterSecret).SetLocalCertificate(securityParameters.LocalCertificate).SetMasterSecret(context.Crypto.AdoptSecret(this.m_sessionMasterSecret)).SetNegotiatedVersion(securityParameters.NegotiatedVersion).SetPeerCertificate(securityParameters.PeerCertificate).SetPskIdentity(securityParameters.PskIdentity).SetSrpIdentity(securityParameters.SrpIdentity).SetServerExtensions(this.m_serverExtensions).Build();
					this.m_tlsSession = global::Org.BouncyCastle.Tls.TlsUtilities.ImportSession(securityParameters.SessionID, this.m_sessionParameters);
				}
				else
				{
					securityParameters.m_localCertificate = this.m_sessionParameters.LocalCertificate;
					securityParameters.m_peerCertificate = this.m_sessionParameters.PeerCertificate;
					securityParameters.m_pskIdentity = this.m_sessionParameters.PskIdentity;
					securityParameters.m_srpIdentity = this.m_sessionParameters.SrpIdentity;
				}
				context.HandshakeComplete(this.Peer, this.m_tlsSession);
			}
			finally
			{
				this.CleanupHandshake();
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00027ED4 File Offset: 0x000260D4
		internal void ProcessRecord(short protocol, byte[] buf, int off, int len)
		{
			switch (protocol)
			{
			case 20:
				this.ProcessChangeCipherSpec(buf, off, len);
				return;
			case 21:
				this.m_alertQueue.AddData(buf, off, len);
				this.ProcessAlertQueue();
				return;
			case 22:
			{
				if (this.m_handshakeQueue.Available > 0)
				{
					this.m_handshakeQueue.AddData(buf, off, len);
					this.ProcessHandshakeQueue(this.m_handshakeQueue);
					return;
				}
				global::Org.BouncyCastle.Tls.ByteQueue tmpQueue = new global::Org.BouncyCastle.Tls.ByteQueue(buf, off, len);
				this.ProcessHandshakeQueue(tmpQueue);
				int remaining = tmpQueue.Available;
				if (remaining > 0)
				{
					this.m_handshakeQueue.AddData(buf, off + len - remaining, remaining);
					return;
				}
				return;
			}
			case 23:
				if (!this.m_appDataReady)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				this.m_applicationDataQueue.AddData(buf, off, len);
				this.ProcessApplicationDataQueue();
				return;
			default:
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00027FAC File Offset: 0x000261AC
		private void ProcessHandshakeQueue(global::Org.BouncyCastle.Tls.ByteQueue queue)
		{
			while (queue.Available >= 4)
			{
				int num = queue.ReadInt32();
				short type = (short)((uint)num >> 24);
				if (!global::Org.BouncyCastle.Tls.HandshakeType.IsRecognized(type))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10, "Handshake message of unrecognized type: " + type.ToString());
				}
				int length = num & 16777215;
				if (length > this.m_maxHandshakeMessageSize)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, string.Concat(new string[]
					{
						"Handshake message length exceeds the maximum: ",
						global::Org.BouncyCastle.Tls.HandshakeType.GetText(type),
						", ",
						length.ToString(),
						" > ",
						this.m_maxHandshakeMessageSize.ToString()
					}));
				}
				int totalLength = 4 + length;
				if (queue.Available >= totalLength)
				{
					if (type != 0)
					{
						global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = this.Context.ServerVersion;
						if (negotiatedVersion == null || !global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(negotiatedVersion))
						{
							this.CheckReceivedChangeCipherSpec(20 == type);
						}
					}
					global::Org.BouncyCastle.Tls.HandshakeMessageInput buf = queue.ReadHandshakeMessage(totalLength);
					if (type <= 15)
					{
						switch (type)
						{
						case 0:
						case 1:
						case 2:
							break;
						case 3:
							goto IL_129;
						case 4:
						{
							global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion2 = this.Context.ServerVersion;
							if (negotiatedVersion2 != null && !global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(negotiatedVersion2))
							{
								buf.UpdateHash(this.m_handshakeHash);
							}
							break;
						}
						default:
							if (type != 15)
							{
								goto IL_129;
							}
							break;
						}
					}
					else if (type != 20 && type != 24)
					{
						goto IL_129;
					}
					IL_135:
					buf.Seek(4L, global::System.IO.SeekOrigin.Current);
					this.HandleHandshakeMessage(type, buf);
					continue;
					IL_129:
					buf.UpdateHash(this.m_handshakeHash);
					goto IL_135;
				}
				break;
			}
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0002810C File Offset: 0x0002630C
		private void ProcessApplicationDataQueue()
		{
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00028110 File Offset: 0x00026310
		private void ProcessAlertQueue()
		{
			while (this.m_alertQueue.Available >= 2)
			{
				byte[] array = this.m_alertQueue.RemoveData(2, 0);
				short alertLevel = (short)array[0];
				short alertDescription = (short)array[1];
				this.HandleAlertMessage(alertLevel, alertDescription);
			}
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0002814C File Offset: 0x0002634C
		private void ProcessChangeCipherSpec(byte[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = this.Context.ServerVersion;
			if (negotiatedVersion == null || global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(negotiatedVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			for (int i = 0; i < len; i++)
			{
				if (global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(buf, off + i) != 1)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
				}
				if (this.m_receivedChangeCipherSpec || this.m_alertQueue.Available > 0 || this.m_handshakeQueue.Available > 0)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				this.m_recordStream.NotifyChangeCipherSpecReceived();
				this.m_receivedChangeCipherSpec = true;
				this.HandleChangeCipherSpecMessage();
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x000281DC File Offset: 0x000263DC
		public virtual int ApplicationDataAvailable
		{
			get
			{
				return this.m_applicationDataQueue.Available;
			}
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x000281EC File Offset: 0x000263EC
		public virtual int ReadApplicationData(byte[] buf, int off, int len)
		{
			if (len < 1)
			{
				return 0;
			}
			while (this.m_applicationDataQueue.Available == 0)
			{
				if (this.m_closed)
				{
					if (this.m_failedWithError)
					{
						throw new global::System.IO.IOException("Cannot read application data on failed TLS connection");
					}
					return -1;
				}
				else
				{
					if (!this.m_appDataReady)
					{
						throw new global::System.InvalidOperationException("Cannot read application data until initial handshake completed.");
					}
					this.SafeReadRecord();
				}
			}
			len = global::System.Math.Min(len, this.m_applicationDataQueue.Available);
			this.m_applicationDataQueue.RemoveData(buf, off, len, 0);
			return len;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0002826C File Offset: 0x0002646C
		protected virtual global::Org.BouncyCastle.Tls.RecordPreview SafePreviewRecordHeader(byte[] recordHeader)
		{
			global::Org.BouncyCastle.Tls.RecordPreview result;
			try
			{
				result = this.m_recordStream.PreviewRecordHeader(recordHeader);
			}
			catch (global::Org.BouncyCastle.Tls.TlsFatalAlert e)
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
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e3);
			}
			return result;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x000282F0 File Offset: 0x000264F0
		protected virtual void SafeReadRecord()
		{
			try
			{
				if (this.m_recordStream.ReadRecord())
				{
					return;
				}
				if (!this.m_appDataReady)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
				}
				if (!this.Peer.RequiresCloseNotify())
				{
					this.HandleClose(false);
					return;
				}
			}
			catch (global::Org.BouncyCastle.Tls.TlsFatalAlertReceived tlsFatalAlertReceived)
			{
				throw tlsFatalAlertReceived;
			}
			catch (global::Org.BouncyCastle.Tls.TlsFatalAlert e)
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
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e3);
			}
			this.HandleFailure();
			throw new global::Org.BouncyCastle.Tls.TlsNoCloseNotifyException();
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000283B8 File Offset: 0x000265B8
		protected virtual bool SafeReadFullRecord(byte[] input, int inputOff, int inputLen)
		{
			bool result;
			try
			{
				result = this.m_recordStream.ReadFullRecord(input, inputOff, inputLen);
			}
			catch (global::Org.BouncyCastle.Tls.TlsFatalAlert e)
			{
				this.HandleException(e.AlertDescription, "Failed to process record", e);
				throw e;
			}
			catch (global::System.IO.IOException e2)
			{
				this.HandleException(80, "Failed to process record", e2);
				throw e2;
			}
			catch (global::System.Exception e3)
			{
				this.HandleException(80, "Failed to process record", e3);
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e3);
			}
			return result;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00028440 File Offset: 0x00026640
		protected virtual void SafeWriteRecord(short type, byte[] buf, int offset, int len)
		{
			try
			{
				this.m_recordStream.WriteRecord(type, buf, offset, len);
			}
			catch (global::Org.BouncyCastle.Tls.TlsFatalAlert e)
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
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e3);
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x000284C8 File Offset: 0x000266C8
		public virtual void WriteApplicationData(byte[] buf, int off, int len)
		{
			if (!this.m_appDataReady)
			{
				throw new global::System.InvalidOperationException("Cannot write application data until initial handshake completed.");
			}
			object recordWriteLock = this.m_recordWriteLock;
			lock (recordWriteLock)
			{
				while (len > 0)
				{
					if (this.m_closed)
					{
						throw new global::System.IO.IOException("Cannot write application data on closed/failed TLS connection");
					}
					if (this.m_appDataSplitEnabled)
					{
						switch (this.m_appDataSplitMode)
						{
						case 1:
							this.SafeWriteRecord(23, global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes, 0, 0);
							goto IL_DE;
						case 2:
							this.m_appDataSplitEnabled = false;
							this.SafeWriteRecord(23, global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes, 0, 0);
							goto IL_DE;
						}
						if (len > 1)
						{
							this.SafeWriteRecord(23, buf, off, 1);
							off++;
							len--;
						}
					}
					else if (this.m_keyUpdateEnabled)
					{
						if (this.m_keyUpdatePendingSend)
						{
							this.Send13KeyUpdate(false);
						}
						else if (this.m_recordStream.NeedsKeyUpdate())
						{
							this.Send13KeyUpdate(true);
						}
					}
					IL_DE:
					int toWrite = global::System.Math.Min(len, this.m_recordStream.PlaintextLimit);
					this.SafeWriteRecord(23, buf, off, toWrite);
					off += toWrite;
					len -= toWrite;
				}
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00028600 File Offset: 0x00026800
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0002860A File Offset: 0x0002680A
		public virtual int AppDataSplitMode
		{
			get
			{
				return this.m_appDataSplitMode;
			}
			set
			{
				if (value < 0 || value > 2)
				{
					throw new global::System.InvalidOperationException("Illegal appDataSplitMode mode: " + value.ToString());
				}
				this.m_appDataSplitMode = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00028634 File Offset: 0x00026834
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0002863E File Offset: 0x0002683E
		public virtual bool IsResumableHandshake
		{
			get
			{
				return this.m_resumableHandshake;
			}
			set
			{
				this.m_resumableHandshake = value;
			}
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0002864C File Offset: 0x0002684C
		internal void WriteHandshakeMessage(byte[] buf, int off, int len)
		{
			if (len < 4)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			short type = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(buf, off);
			switch (type)
			{
			case 0:
			case 1:
				goto IL_6A;
			case 2:
			case 3:
				break;
			case 4:
			{
				global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = this.Context.ServerVersion;
				if (negotiatedVersion != null && !global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(negotiatedVersion))
				{
					this.m_handshakeHash.Update(buf, off, len);
					goto IL_6A;
				}
				goto IL_6A;
			}
			default:
				if (type == 24)
				{
					goto IL_6A;
				}
				break;
			}
			this.m_handshakeHash.Update(buf, off, len);
			IL_6A:
			int total = 0;
			do
			{
				int toWrite = global::System.Math.Min(len - total, this.m_recordStream.PlaintextLimit);
				this.SafeWriteRecord(22, buf, off + total, toWrite);
				total += toWrite;
			}
			while (total < len);
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x000286EE File Offset: 0x000268EE
		public virtual global::System.IO.Stream Stream
		{
			get
			{
				if (!this.m_blocking)
				{
					throw new global::System.InvalidOperationException("Cannot use Stream in non-blocking mode! Use OfferInput()/OfferOutput() instead.");
				}
				return this.m_tlsStream;
			}
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0002870C File Offset: 0x0002690C
		public virtual void CloseInput()
		{
			if (this.m_blocking)
			{
				throw new global::System.InvalidOperationException("Cannot use CloseInput() in blocking mode!");
			}
			if (this.m_closed)
			{
				return;
			}
			if (this.m_inputBuffers.Available > 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			if (!this.m_appDataReady)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
			}
			if (!this.Peer.RequiresCloseNotify())
			{
				this.HandleClose(false);
				return;
			}
			this.HandleFailure();
			throw new global::Org.BouncyCastle.Tls.TlsNoCloseNotifyException();
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00028780 File Offset: 0x00026980
		public virtual global::Org.BouncyCastle.Tls.RecordPreview PreviewInputRecord(byte[] recordHeader)
		{
			if (this.m_blocking)
			{
				throw new global::System.InvalidOperationException("Cannot use PreviewInputRecord() in blocking mode!");
			}
			if (this.m_inputBuffers.Available != 0)
			{
				throw new global::System.InvalidOperationException("Can only use PreviewInputRecord() for record-aligned input.");
			}
			if (this.m_closed)
			{
				throw new global::System.IO.IOException("Connection is closed, cannot accept any more input");
			}
			return this.SafePreviewRecordHeader(recordHeader);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x000287D4 File Offset: 0x000269D4
		public virtual global::Org.BouncyCastle.Tls.RecordPreview PreviewOutputRecord(int applicationDataSize)
		{
			if (!this.m_appDataReady)
			{
				throw new global::System.InvalidOperationException("Cannot use PreviewOutputRecord() until initial handshake completed.");
			}
			if (this.m_blocking)
			{
				throw new global::System.InvalidOperationException("Cannot use PreviewOutputRecord() in blocking mode!");
			}
			if (this.m_outputBuffer.Buffer.Available != 0)
			{
				throw new global::System.InvalidOperationException("Can only use PreviewOutputRecord() for record-aligned output.");
			}
			if (this.m_closed)
			{
				throw new global::System.IO.IOException("Connection is closed, cannot produce any more output");
			}
			if (applicationDataSize < 1)
			{
				return new global::Org.BouncyCastle.Tls.RecordPreview(0, 0);
			}
			if (!this.m_appDataSplitEnabled)
			{
				global::Org.BouncyCastle.Tls.RecordPreview a = this.m_recordStream.PreviewOutputRecord(applicationDataSize);
				if (this.m_keyUpdateEnabled && (this.m_keyUpdatePendingSend || this.m_recordStream.NeedsKeyUpdate()))
				{
					int keyUpdateLength = global::Org.BouncyCastle.Tls.HandshakeMessageOutput.GetLength(1);
					int recordSize = this.m_recordStream.PreviewOutputRecordSize(keyUpdateLength);
					a = global::Org.BouncyCastle.Tls.RecordPreview.ExtendRecordSize(a, recordSize);
				}
				return a;
			}
			int appDataSplitMode = this.m_appDataSplitMode;
			if (appDataSplitMode != 0 && appDataSplitMode - 1 <= 1)
			{
				global::Org.BouncyCastle.Tls.RecordPreview a3 = this.m_recordStream.PreviewOutputRecord(0);
				global::Org.BouncyCastle.Tls.RecordPreview b = this.m_recordStream.PreviewOutputRecord(applicationDataSize);
				return global::Org.BouncyCastle.Tls.RecordPreview.CombineAppData(a3, b);
			}
			global::Org.BouncyCastle.Tls.RecordPreview a2 = this.m_recordStream.PreviewOutputRecord(1);
			if (applicationDataSize > 1)
			{
				global::Org.BouncyCastle.Tls.RecordPreview b2 = this.m_recordStream.PreviewOutputRecord(applicationDataSize - 1);
				a2 = global::Org.BouncyCastle.Tls.RecordPreview.CombineAppData(a2, b2);
			}
			return a2;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00028900 File Offset: 0x00026B00
		public virtual void OfferInput(byte[] input)
		{
			this.OfferInput(input, 0, input.Length);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00028910 File Offset: 0x00026B10
		public virtual void OfferInput(byte[] input, int inputOff, int inputLen)
		{
			if (this.m_blocking)
			{
				throw new global::System.InvalidOperationException("Cannot use OfferInput() in blocking mode! Use Stream instead.");
			}
			if (this.m_closed)
			{
				throw new global::System.IO.IOException("Connection is closed, cannot accept any more input");
			}
			if (this.m_inputBuffers.Available != 0 || !this.SafeReadFullRecord(input, inputOff, inputLen))
			{
				this.m_inputBuffers.AddBytes(input, inputOff, inputLen);
				while (this.m_inputBuffers.Available >= 5)
				{
					byte[] recordHeader = new byte[5];
					if (5 != this.m_inputBuffers.Peek(recordHeader))
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
					}
					global::Org.BouncyCastle.Tls.RecordPreview preview = this.SafePreviewRecordHeader(recordHeader);
					if (this.m_inputBuffers.Available < preview.RecordSize)
					{
						break;
					}
					this.SafeReadRecord();
					if (this.m_closed)
					{
						if (!this.m_appDataReady)
						{
							throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
						}
						break;
					}
				}
				return;
			}
			if (this.m_closed && !this.m_appDataReady)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x000289F3 File Offset: 0x00026BF3
		public virtual int ApplicationDataLimit
		{
			get
			{
				return this.m_recordStream.PlaintextLimit;
			}
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00028A00 File Offset: 0x00026C00
		public virtual int GetAvailableInputBytes()
		{
			if (this.m_blocking)
			{
				throw new global::System.InvalidOperationException("Cannot use GetAvailableInputBytes() in blocking mode!");
			}
			return this.ApplicationDataAvailable;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00028A1B File Offset: 0x00026C1B
		public virtual int ReadInput(byte[] buf, int off, int len)
		{
			if (this.m_blocking)
			{
				throw new global::System.InvalidOperationException("Cannot use ReadInput() in blocking mode! Use Stream instead.");
			}
			len = global::System.Math.Min(len, this.ApplicationDataAvailable);
			if (len < 1)
			{
				return 0;
			}
			this.m_applicationDataQueue.RemoveData(buf, off, len, 0);
			return len;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00028A54 File Offset: 0x00026C54
		public virtual int GetAvailableOutputBytes()
		{
			if (this.m_blocking)
			{
				throw new global::System.InvalidOperationException("Cannot use GetAvailableOutputBytes() in blocking mode! Use Stream instead.");
			}
			return this.m_outputBuffer.Buffer.Available;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00028A7C File Offset: 0x00026C7C
		public virtual int ReadOutput(byte[] buffer, int offset, int length)
		{
			if (this.m_blocking)
			{
				throw new global::System.InvalidOperationException("Cannot use ReadOutput() in blocking mode! Use 'Stream() instead.");
			}
			int bytesToRead = global::System.Math.Min(this.GetAvailableOutputBytes(), length);
			this.m_outputBuffer.Buffer.RemoveData(buffer, offset, bytesToRead, 0);
			return bytesToRead;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00028AC0 File Offset: 0x00026CC0
		protected virtual bool EstablishSession(global::Org.BouncyCastle.Tls.TlsSession sessionToResume)
		{
			this.m_tlsSession = null;
			this.m_sessionParameters = null;
			this.m_sessionMasterSecret = null;
			if (sessionToResume == null || !sessionToResume.IsResumable)
			{
				return false;
			}
			global::Org.BouncyCastle.Tls.SessionParameters sessionParameters = sessionToResume.ExportSessionParameters();
			if (sessionParameters == null)
			{
				return false;
			}
			if (!sessionParameters.IsExtendedMasterSecret)
			{
				global::Org.BouncyCastle.Tls.TlsPeer peer = this.Peer;
				if (!peer.AllowLegacyResumption() || peer.RequiresExtendedMasterSecret())
				{
					return false;
				}
			}
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret sessionMasterSecret = global::Org.BouncyCastle.Tls.TlsUtilities.GetSessionMasterSecret(this.Context.Crypto, sessionParameters.MasterSecret);
			if (sessionMasterSecret == null)
			{
				return false;
			}
			this.m_tlsSession = sessionToResume;
			this.m_sessionParameters = sessionParameters;
			this.m_sessionMasterSecret = sessionMasterSecret;
			return true;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00028B50 File Offset: 0x00026D50
		protected virtual void InvalidateSession()
		{
			if (this.m_sessionMasterSecret != null)
			{
				this.m_sessionMasterSecret.Destroy();
				this.m_sessionMasterSecret = null;
			}
			if (this.m_sessionParameters != null)
			{
				this.m_sessionParameters.Clear();
				this.m_sessionParameters = null;
			}
			if (this.m_tlsSession != null)
			{
				this.m_tlsSession.Invalidate();
				this.m_tlsSession = null;
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00028BAC File Offset: 0x00026DAC
		protected virtual void ProcessFinishedMessage(global::System.IO.MemoryStream buf)
		{
			global::Org.BouncyCastle.Tls.TlsContext context = this.Context;
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			bool isServerContext = context.IsServer;
			byte[] verify_data = global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(securityParameters.VerifyDataLength, buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			byte[] expected_verify_data = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateVerifyData(context, this.m_handshakeHash, !isServerContext);
			if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(expected_verify_data, verify_data))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(51);
			}
			securityParameters.m_peerVerifyData = expected_verify_data;
			if ((!this.m_resumedSession || securityParameters.IsExtendedMasterSecret) && securityParameters.LocalVerifyData == null)
			{
				securityParameters.m_tlsUnique = expected_verify_data;
			}
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00028C28 File Offset: 0x00026E28
		protected virtual void Process13FinishedMessage(global::System.IO.MemoryStream buf)
		{
			global::Org.BouncyCastle.Tls.TlsContext context = this.Context;
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			bool isServerContext = context.IsServer;
			byte[] verify_data = global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(securityParameters.VerifyDataLength, buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			byte[] expected_verify_data = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateVerifyData(context, this.m_handshakeHash, !isServerContext);
			if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(expected_verify_data, verify_data))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(51);
			}
			securityParameters.m_peerVerifyData = expected_verify_data;
			securityParameters.m_tlsUnique = null;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00028C8C File Offset: 0x00026E8C
		protected virtual void RaiseAlertFatal(short alertDescription, string message, global::System.Exception cause)
		{
			this.Peer.NotifyAlertRaised(2, alertDescription, message, cause);
			byte[] alert = new byte[]
			{
				2,
				(byte)alertDescription
			};
			try
			{
				this.m_recordStream.WriteRecord(21, alert, 0, 2);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00028CE0 File Offset: 0x00026EE0
		protected virtual void RaiseAlertWarning(short alertDescription, string message)
		{
			this.Peer.NotifyAlertRaised(1, alertDescription, message, null);
			byte[] alert = new byte[]
			{
				1,
				(byte)alertDescription
			};
			this.SafeWriteRecord(21, alert, 0, 2);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00028D18 File Offset: 0x00026F18
		protected virtual void Receive13KeyUpdate(global::System.IO.MemoryStream buf)
		{
			if (!this.m_appDataReady || !this.m_keyUpdateEnabled)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			short requestUpdate = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			if (!global::Org.BouncyCastle.Tls.KeyUpdateRequest.IsValid(requestUpdate))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			bool updateRequested = 1 == requestUpdate;
			global::Org.BouncyCastle.Tls.TlsUtilities.Update13TrafficSecretPeer(this.Context);
			this.m_recordStream.NotifyKeyUpdateReceived();
			this.m_keyUpdatePendingSend = (this.m_keyUpdatePendingSend || updateRequested);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00028D8C File Offset: 0x00026F8C
		protected virtual void SendCertificateMessage(global::Org.BouncyCastle.Tls.Certificate certificate, global::System.IO.Stream endPointHash)
		{
			global::Org.BouncyCastle.Tls.TlsContext context = this.Context;
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			if (securityParameters.LocalCertificate != null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			if (certificate == null)
			{
				certificate = global::Org.BouncyCastle.Tls.Certificate.EmptyChain;
			}
			if (certificate.IsEmpty && !context.IsServer && securityParameters.NegotiatedVersion.IsSsl)
			{
				string message = "SSLv3 client didn't provide credentials";
				this.RaiseAlertWarning(41, message);
			}
			else
			{
				global::Org.BouncyCastle.Tls.HandshakeMessageOutput message2 = new global::Org.BouncyCastle.Tls.HandshakeMessageOutput(11);
				certificate.Encode(context, message2, endPointHash);
				message2.Send(this);
			}
			securityParameters.m_localCertificate = certificate;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00028E10 File Offset: 0x00027010
		protected virtual void Send13CertificateMessage(global::Org.BouncyCastle.Tls.Certificate certificate)
		{
			if (certificate == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.TlsContext context = this.Context;
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			if (securityParameters.LocalCertificate != null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput message = new global::Org.BouncyCastle.Tls.HandshakeMessageOutput(11);
			certificate.Encode(context, message, null);
			message.Send(this);
			securityParameters.m_localCertificate = certificate;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00028E68 File Offset: 0x00027068
		protected virtual void Send13CertificateVerifyMessage(global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify)
		{
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput message = new global::Org.BouncyCastle.Tls.HandshakeMessageOutput(15);
			certificateVerify.Encode(message);
			message.Send(this);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00028E8B File Offset: 0x0002708B
		protected virtual void SendChangeCipherSpec()
		{
			this.SendChangeCipherSpecMessage();
			this.m_recordStream.EnablePendingCipherWrite();
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00028EA0 File Offset: 0x000270A0
		protected virtual void SendChangeCipherSpecMessage()
		{
			byte[] message = new byte[]
			{
				1
			};
			this.SafeWriteRecord(20, message, 0, message.Length);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00028EC8 File Offset: 0x000270C8
		protected virtual void SendFinishedMessage()
		{
			global::Org.BouncyCastle.Tls.TlsContext context = this.Context;
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			bool isServerContext = context.IsServer;
			byte[] verify_data = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateVerifyData(context, this.m_handshakeHash, isServerContext);
			securityParameters.m_localVerifyData = verify_data;
			if ((!this.m_resumedSession || securityParameters.IsExtendedMasterSecret) && securityParameters.PeerVerifyData == null)
			{
				securityParameters.m_tlsUnique = verify_data;
			}
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput.Send(this, 20, verify_data);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00028F28 File Offset: 0x00027128
		protected virtual void Send13FinishedMessage()
		{
			global::Org.BouncyCastle.Tls.TlsContext context = this.Context;
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			bool isServerContext = context.IsServer;
			byte[] verify_data = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateVerifyData(context, this.m_handshakeHash, isServerContext);
			securityParameters.m_localVerifyData = verify_data;
			securityParameters.m_tlsUnique = null;
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput.Send(this, 20, verify_data);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00028F70 File Offset: 0x00027170
		protected virtual void Send13KeyUpdate(bool updateRequested)
		{
			if (!this.m_appDataReady || !this.m_keyUpdateEnabled)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			short requestUpdate = updateRequested ? 1 : 0;
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput.Send(this, 24, global::Org.BouncyCastle.Tls.TlsUtilities.EncodeUint8(requestUpdate));
			global::Org.BouncyCastle.Tls.TlsUtilities.Update13TrafficSecretLocal(this.Context);
			this.m_recordStream.NotifyKeyUpdateSent();
			this.m_keyUpdatePendingSend = (this.m_keyUpdatePendingSend && updateRequested);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00028FD7 File Offset: 0x000271D7
		protected virtual void SendSupplementalDataMessage(global::System.Collections.IList supplementalData)
		{
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput handshakeMessageOutput = new global::Org.BouncyCastle.Tls.HandshakeMessageOutput(23);
			global::Org.BouncyCastle.Tls.TlsProtocol.WriteSupplementalData(handshakeMessageOutput, supplementalData);
			handshakeMessageOutput.Send(this);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00028FED File Offset: 0x000271ED
		public virtual void Close()
		{
			this.HandleClose(true);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00028FF6 File Offset: 0x000271F6
		public virtual void Flush()
		{
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00028FF8 File Offset: 0x000271F8
		internal bool IsApplicationDataReady
		{
			get
			{
				return this.m_appDataReady;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x00029002 File Offset: 0x00027202
		public virtual bool IsClosed
		{
			get
			{
				return this.m_closed;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0002900C File Offset: 0x0002720C
		public virtual bool IsConnected
		{
			get
			{
				if (this.m_closed)
				{
					return false;
				}
				global::Org.BouncyCastle.Tls.AbstractTlsContext context = this.ContextAdmin;
				return context != null && context.IsConnected;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00029038 File Offset: 0x00027238
		public virtual bool IsHandshaking
		{
			get
			{
				if (this.m_closed)
				{
					return false;
				}
				global::Org.BouncyCastle.Tls.AbstractTlsContext context = this.ContextAdmin;
				return context != null && context.IsHandshaking;
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00029064 File Offset: 0x00027264
		protected virtual short ProcessMaxFragmentLengthExtension(global::System.Collections.IDictionary clientExtensions, global::System.Collections.IDictionary serverExtensions, short alertDescription)
		{
			short maxFragmentLength = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(serverExtensions);
			if (maxFragmentLength >= 0 && (!global::Org.BouncyCastle.Tls.MaxFragmentLength.IsValid(maxFragmentLength) || (!this.m_resumedSession && maxFragmentLength != global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(clientExtensions))))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(alertDescription);
			}
			return maxFragmentLength;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0002909D File Offset: 0x0002729D
		protected virtual void RefuseRenegotiation()
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsSsl(this.Context))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
			}
			this.RaiseAlertWarning(100, "Renegotiation not supported");
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x000290C1 File Offset: 0x000272C1
		internal static void AssertEmpty(global::System.IO.MemoryStream buf)
		{
			if (buf.Position < buf.Length)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x000290DC File Offset: 0x000272DC
		internal static byte[] CreateRandomBlock(bool useGmtUnixTime, global::Org.BouncyCastle.Tls.TlsContext context)
		{
			byte[] result = context.NonceGenerator.GenerateNonce(32);
			if (useGmtUnixTime)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteGmtUnixTime(result, 0);
			}
			return result;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00029102 File Offset: 0x00027302
		internal static byte[] CreateRenegotiationInfo(byte[] renegotiated_connection)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeOpaque8(renegotiated_connection);
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0002910C File Offset: 0x0002730C
		internal static void EstablishMasterSecret(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.TlsKeyExchange keyExchange)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret preMasterSecret = keyExchange.GeneratePreMasterSecret();
			if (preMasterSecret == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			try
			{
				context.SecurityParameters.m_masterSecret = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateMasterSecret(context, preMasterSecret);
			}
			finally
			{
				preMasterSecret.Destroy();
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00029158 File Offset: 0x00027358
		internal static global::System.Collections.IDictionary ReadExtensions(global::System.IO.MemoryStream input)
		{
			if (input.Position >= input.Length)
			{
				return null;
			}
			byte[] extBytes = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(input);
			return global::Org.BouncyCastle.Tls.TlsProtocol.ReadExtensionsData(extBytes);
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0002917C File Offset: 0x0002737C
		internal static global::System.Collections.IDictionary ReadExtensionsData(byte[] extBytes)
		{
			global::System.Collections.IDictionary extensions = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			if (extBytes.Length != 0)
			{
				global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(extBytes, false);
				int extension_type;
				for (;;)
				{
					extension_type = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf);
					byte[] extension_data = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(buf);
					int key = extension_type;
					if (extensions.Contains(key))
					{
						break;
					}
					extensions.Add(key, extension_data);
					if (buf.Position >= buf.Length)
					{
						return extensions;
					}
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47, "Repeated extension: " + global::Org.BouncyCastle.Tls.ExtensionType.GetText(extension_type));
			}
			return extensions;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x000291F0 File Offset: 0x000273F0
		internal static global::System.Collections.IDictionary ReadExtensionsData13(int handshakeType, byte[] extBytes)
		{
			global::System.Collections.IDictionary extensions = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			if (extBytes.Length != 0)
			{
				global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(extBytes, false);
				int extension_type;
				for (;;)
				{
					extension_type = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf);
					if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsPermittedExtensionType13(handshakeType, extension_type))
					{
						break;
					}
					byte[] extension_data = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(buf);
					int key = extension_type;
					if (extensions.Contains(key))
					{
						goto Block_3;
					}
					extensions.Add(key, extension_data);
					if (buf.Position >= buf.Length)
					{
						return extensions;
					}
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47, "Invalid extension: " + global::Org.BouncyCastle.Tls.ExtensionType.GetText(extension_type));
				Block_3:
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47, "Repeated extension: " + global::Org.BouncyCastle.Tls.ExtensionType.GetText(extension_type));
			}
			return extensions;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00029288 File Offset: 0x00027488
		internal static global::System.Collections.IDictionary ReadExtensionsDataClientHello(byte[] extBytes)
		{
			global::System.Collections.IDictionary extensions = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			if (extBytes.Length != 0)
			{
				global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(extBytes, false);
				bool pre_shared_key_found = false;
				int extension_type;
				for (;;)
				{
					extension_type = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf);
					byte[] extension_data = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(buf);
					int key = extension_type;
					if (extensions.Contains(key))
					{
						break;
					}
					extensions.Add(key, extension_data);
					pre_shared_key_found |= (41 == extension_type);
					if (buf.Position >= buf.Length)
					{
						goto Block_3;
					}
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47, "Repeated extension: " + global::Org.BouncyCastle.Tls.ExtensionType.GetText(extension_type));
				Block_3:
				if (pre_shared_key_found && 41 != extension_type)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47, "'pre_shared_key' MUST be last in ClientHello");
				}
			}
			return extensions;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00029320 File Offset: 0x00027520
		internal static global::System.Collections.IList ReadSupplementalDataMessage(global::System.IO.MemoryStream input)
		{
			byte[] buffer = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque24(input, 1);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(input);
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(buffer, false);
			global::System.Collections.IList supplementalData = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (buf.Position < buf.Length)
			{
				int supp_data_type = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf);
				byte[] data = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(buf);
				supplementalData.Add(new global::Org.BouncyCastle.Tls.SupplementalDataEntry(supp_data_type, data));
			}
			return supplementalData;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00029374 File Offset: 0x00027574
		internal static void WriteExtensions(global::System.IO.Stream output, global::System.Collections.IDictionary extensions)
		{
			global::Org.BouncyCastle.Tls.TlsProtocol.WriteExtensions(output, extensions, 0);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00029380 File Offset: 0x00027580
		internal static void WriteExtensions(global::System.IO.Stream output, global::System.Collections.IDictionary extensions, int bindersSize)
		{
			if (extensions == null || extensions.Count < 1)
			{
				return;
			}
			byte[] extBytes = global::Org.BouncyCastle.Tls.TlsProtocol.WriteExtensionsData(extensions, bindersSize);
			int i = extBytes.Length + bindersSize;
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(i);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(i, output);
			output.Write(extBytes, 0, extBytes.Length);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x000293BE File Offset: 0x000275BE
		internal static byte[] WriteExtensionsData(global::System.Collections.IDictionary extensions)
		{
			return global::Org.BouncyCastle.Tls.TlsProtocol.WriteExtensionsData(extensions, 0);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x000293C8 File Offset: 0x000275C8
		internal static byte[] WriteExtensionsData(global::System.Collections.IDictionary extensions, int bindersSize)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Tls.TlsProtocol.WriteExtensionsData(extensions, buf, bindersSize);
			return buf.ToArray();
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x000293E9 File Offset: 0x000275E9
		internal static void WriteExtensionsData(global::System.Collections.IDictionary extensions, global::System.IO.MemoryStream buf)
		{
			global::Org.BouncyCastle.Tls.TlsProtocol.WriteExtensionsData(extensions, buf, 0);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x000293F3 File Offset: 0x000275F3
		internal static void WriteExtensionsData(global::System.Collections.IDictionary extensions, global::System.IO.MemoryStream buf, int bindersSize)
		{
			global::Org.BouncyCastle.Tls.TlsProtocol.WriteSelectedExtensions(buf, extensions, true);
			global::Org.BouncyCastle.Tls.TlsProtocol.WriteSelectedExtensions(buf, extensions, false);
			global::Org.BouncyCastle.Tls.TlsProtocol.WritePreSharedKeyExtension(buf, extensions, bindersSize);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00029410 File Offset: 0x00027610
		internal static void WritePreSharedKeyExtension(global::System.IO.MemoryStream buf, global::System.Collections.IDictionary extensions, int bindersSize)
		{
			byte[] extension_data = (byte[])extensions[41];
			if (extension_data != null)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(41);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(41, buf);
				int i = extension_data.Length + bindersSize;
				global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(i);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(i, buf);
				buf.Write(extension_data, 0, extension_data.Length);
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00029460 File Offset: 0x00027660
		internal static void WriteSelectedExtensions(global::System.IO.Stream output, global::System.Collections.IDictionary extensions, bool selectEmpty)
		{
			foreach (object obj in extensions.Keys)
			{
				int key = (int)obj;
				int extension_type = key;
				if (41 != extension_type)
				{
					byte[] extension_data = (byte[])extensions[key];
					if (selectEmpty == (extension_data.Length == 0))
					{
						global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(extension_type);
						global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(extension_type, output);
						global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(extension_data, output);
					}
				}
			}
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000294EC File Offset: 0x000276EC
		internal static void WriteSupplementalData(global::System.IO.Stream output, global::System.Collections.IList supplementalData)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			foreach (object obj in supplementalData)
			{
				global::Org.BouncyCastle.Tls.SupplementalDataEntry supplementalDataEntry = (global::Org.BouncyCastle.Tls.SupplementalDataEntry)obj;
				int dataType = supplementalDataEntry.DataType;
				global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(dataType);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(dataType, buf);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(supplementalDataEntry.Data, buf);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque24(buf.ToArray(), output);
		}

		// Token: 0x040006F6 RID: 1782
		protected const short CS_START = 0;

		// Token: 0x040006F7 RID: 1783
		protected const short CS_CLIENT_HELLO = 1;

		// Token: 0x040006F8 RID: 1784
		protected const short CS_SERVER_HELLO_RETRY_REQUEST = 2;

		// Token: 0x040006F9 RID: 1785
		protected const short CS_CLIENT_HELLO_RETRY = 3;

		// Token: 0x040006FA RID: 1786
		protected const short CS_SERVER_HELLO = 4;

		// Token: 0x040006FB RID: 1787
		protected const short CS_SERVER_ENCRYPTED_EXTENSIONS = 5;

		// Token: 0x040006FC RID: 1788
		protected const short CS_SERVER_SUPPLEMENTAL_DATA = 6;

		// Token: 0x040006FD RID: 1789
		protected const short CS_SERVER_CERTIFICATE = 7;

		// Token: 0x040006FE RID: 1790
		protected const short CS_SERVER_CERTIFICATE_STATUS = 8;

		// Token: 0x040006FF RID: 1791
		protected const short CS_SERVER_CERTIFICATE_VERIFY = 9;

		// Token: 0x04000700 RID: 1792
		protected const short CS_SERVER_KEY_EXCHANGE = 10;

		// Token: 0x04000701 RID: 1793
		protected const short CS_SERVER_CERTIFICATE_REQUEST = 11;

		// Token: 0x04000702 RID: 1794
		protected const short CS_SERVER_HELLO_DONE = 12;

		// Token: 0x04000703 RID: 1795
		protected const short CS_CLIENT_END_OF_EARLY_DATA = 13;

		// Token: 0x04000704 RID: 1796
		protected const short CS_CLIENT_SUPPLEMENTAL_DATA = 14;

		// Token: 0x04000705 RID: 1797
		protected const short CS_CLIENT_CERTIFICATE = 15;

		// Token: 0x04000706 RID: 1798
		protected const short CS_CLIENT_KEY_EXCHANGE = 16;

		// Token: 0x04000707 RID: 1799
		protected const short CS_CLIENT_CERTIFICATE_VERIFY = 17;

		// Token: 0x04000708 RID: 1800
		protected const short CS_CLIENT_FINISHED = 18;

		// Token: 0x04000709 RID: 1801
		protected const short CS_SERVER_SESSION_TICKET = 19;

		// Token: 0x0400070A RID: 1802
		protected const short CS_SERVER_FINISHED = 20;

		// Token: 0x0400070B RID: 1803
		protected const short CS_END = 21;

		// Token: 0x0400070C RID: 1804
		protected const short ADS_MODE_1_Nsub1 = 0;

		// Token: 0x0400070D RID: 1805
		protected const short ADS_MODE_0_N = 1;

		// Token: 0x0400070E RID: 1806
		protected const short ADS_MODE_0_N_FIRSTONLY = 2;

		// Token: 0x0400070F RID: 1807
		private readonly global::Org.BouncyCastle.Tls.ByteQueue m_applicationDataQueue = new global::Org.BouncyCastle.Tls.ByteQueue(0);

		// Token: 0x04000710 RID: 1808
		private readonly global::Org.BouncyCastle.Tls.ByteQueue m_alertQueue = new global::Org.BouncyCastle.Tls.ByteQueue(2);

		// Token: 0x04000711 RID: 1809
		private readonly global::Org.BouncyCastle.Tls.ByteQueue m_handshakeQueue = new global::Org.BouncyCastle.Tls.ByteQueue(0);

		// Token: 0x04000712 RID: 1810
		internal readonly global::Org.BouncyCastle.Tls.RecordStream m_recordStream;

		// Token: 0x04000713 RID: 1811
		internal readonly object m_recordWriteLock = new object();

		// Token: 0x04000714 RID: 1812
		private int m_maxHandshakeMessageSize = -1;

		// Token: 0x04000715 RID: 1813
		internal global::Org.BouncyCastle.Tls.TlsHandshakeHash m_handshakeHash;

		// Token: 0x04000716 RID: 1814
		private global::Org.BouncyCastle.Tls.TlsStream m_tlsStream;

		// Token: 0x04000717 RID: 1815
		private volatile bool m_closed;

		// Token: 0x04000718 RID: 1816
		private volatile bool m_failedWithError;

		// Token: 0x04000719 RID: 1817
		private volatile bool m_appDataReady;

		// Token: 0x0400071A RID: 1818
		private volatile bool m_appDataSplitEnabled = true;

		// Token: 0x0400071B RID: 1819
		private volatile bool m_keyUpdateEnabled;

		// Token: 0x0400071C RID: 1820
		private volatile bool m_keyUpdatePendingSend;

		// Token: 0x0400071D RID: 1821
		private volatile bool m_resumableHandshake;

		// Token: 0x0400071E RID: 1822
		private volatile int m_appDataSplitMode;

		// Token: 0x0400071F RID: 1823
		protected global::Org.BouncyCastle.Tls.TlsSession m_tlsSession;

		// Token: 0x04000720 RID: 1824
		protected global::Org.BouncyCastle.Tls.SessionParameters m_sessionParameters;

		// Token: 0x04000721 RID: 1825
		protected global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_sessionMasterSecret;

		// Token: 0x04000722 RID: 1826
		protected byte[] m_retryCookie;

		// Token: 0x04000723 RID: 1827
		protected int m_retryGroup = -1;

		// Token: 0x04000724 RID: 1828
		protected global::System.Collections.IDictionary m_clientExtensions;

		// Token: 0x04000725 RID: 1829
		protected global::System.Collections.IDictionary m_serverExtensions;

		// Token: 0x04000726 RID: 1830
		protected short m_connectionState;

		// Token: 0x04000727 RID: 1831
		protected bool m_resumedSession;

		// Token: 0x04000728 RID: 1832
		protected bool m_selectedPsk13;

		// Token: 0x04000729 RID: 1833
		protected bool m_receivedChangeCipherSpec;

		// Token: 0x0400072A RID: 1834
		protected bool m_expectSessionTicket;

		// Token: 0x0400072B RID: 1835
		protected readonly bool m_blocking;

		// Token: 0x0400072C RID: 1836
		protected readonly global::Org.BouncyCastle.Tls.ByteQueueInputStream m_inputBuffers;

		// Token: 0x0400072D RID: 1837
		protected readonly global::Org.BouncyCastle.Tls.ByteQueueOutputStream m_outputBuffer;
	}
}
