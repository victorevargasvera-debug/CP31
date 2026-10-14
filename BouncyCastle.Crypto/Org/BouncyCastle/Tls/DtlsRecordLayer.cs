using System;
using System.IO;
using System.Net.Sockets;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000BC RID: 188
	internal class DtlsRecordLayer : global::Org.BouncyCastle.Tls.DatagramTransport, global::Org.BouncyCastle.Tls.DatagramReceiver, global::Org.BouncyCastle.Tls.DatagramSender, global::Org.BouncyCastle.Tls.TlsCloseable
	{
		// Token: 0x06000709 RID: 1801 RVA: 0x0001D348 File Offset: 0x0001B548
		internal static byte[] ReceiveClientHelloRecord(byte[] data, int dataOff, int dataLen)
		{
			if (dataLen < 13)
			{
				return null;
			}
			short contentType = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(data, dataOff);
			if (22 != contentType)
			{
				return null;
			}
			global::Org.BouncyCastle.Tls.ProtocolVersion version = global::Org.BouncyCastle.Tls.TlsUtilities.ReadVersion(data, dataOff + 1);
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv10.IsEqualOrEarlierVersionOf(version))
			{
				return null;
			}
			int epoch = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(data, dataOff + 3);
			if (epoch != 0)
			{
				return null;
			}
			int length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(data, dataOff + 11);
			if (dataLen < 13 + length)
			{
				return null;
			}
			if (length > 16384)
			{
				return null;
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.CopyOfRangeExact(data, dataOff + 13, dataOff + 13 + length);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0001D3C4 File Offset: 0x0001B5C4
		internal static void SendHelloVerifyRequestRecord(global::Org.BouncyCastle.Tls.DatagramSender sender, long recordSeq, byte[] message)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(message.Length);
			byte[] record = new byte[13 + message.Length];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(22, record, 0);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteVersion(global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv10, record, 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(0, record, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint48(recordSeq, record, 5);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(message.Length, record, 11);
			global::System.Array.Copy(message, 0, record, 13, message.Length);
			global::Org.BouncyCastle.Tls.DtlsRecordLayer.SendDatagram(sender, record, 0, record.Length);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0001D42D File Offset: 0x0001B62D
		private static void SendDatagram(global::Org.BouncyCastle.Tls.DatagramSender sender, byte[] buf, int off, int len)
		{
			sender.Send(buf, off, len);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0001D438 File Offset: 0x0001B638
		internal DtlsRecordLayer(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.TlsPeer peer, global::Org.BouncyCastle.Tls.DatagramTransport transport)
		{
			this.m_context = context;
			this.m_peer = peer;
			this.m_transport = transport;
			this.m_inHandshake = true;
			this.m_currentEpoch = new global::Org.BouncyCastle.Tls.DtlsEpoch(0, global::Org.BouncyCastle.Tls.Crypto.TlsNullNullCipher.Instance);
			this.m_pendingEpoch = null;
			this.m_readEpoch = this.m_currentEpoch;
			this.m_writeEpoch = this.m_currentEpoch;
			this.SetPlaintextLimit(16384);
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x0001D4C1 File Offset: 0x0001B6C1
		internal virtual bool IsClosed
		{
			get
			{
				return this.m_closed;
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0001D4CB File Offset: 0x0001B6CB
		internal virtual void ResetAfterHelloVerifyRequestServer(long recordSeq)
		{
			this.m_inConnection = true;
			this.m_currentEpoch.SequenceNumber = recordSeq;
			this.m_currentEpoch.ReplayWindow.Reset(recordSeq);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0001D4F3 File Offset: 0x0001B6F3
		internal virtual void SetPlaintextLimit(int plaintextLimit)
		{
			this.m_plaintextLimit = plaintextLimit;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0001D4FE File Offset: 0x0001B6FE
		internal virtual int ReadEpoch
		{
			get
			{
				return this.m_readEpoch.Epoch;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x0001D50B File Offset: 0x0001B70B
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x0001D515 File Offset: 0x0001B715
		internal virtual global::Org.BouncyCastle.Tls.ProtocolVersion ReadVersion
		{
			get
			{
				return this.m_readVersion;
			}
			set
			{
				this.m_readVersion = value;
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0001D520 File Offset: 0x0001B720
		internal virtual void SetWriteVersion(global::Org.BouncyCastle.Tls.ProtocolVersion writeVersion)
		{
			this.m_writeVersion = writeVersion;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0001D52B File Offset: 0x0001B72B
		internal virtual void InitPendingEpoch(global::Org.BouncyCastle.Tls.Crypto.TlsCipher pendingCipher)
		{
			if (this.m_pendingEpoch != null)
			{
				throw new global::System.InvalidOperationException();
			}
			this.m_pendingEpoch = new global::Org.BouncyCastle.Tls.DtlsEpoch(this.m_writeEpoch.Epoch + 1, pendingCipher);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0001D554 File Offset: 0x0001B754
		internal virtual void HandshakeSuccessful(global::Org.BouncyCastle.Tls.DtlsHandshakeRetransmit retransmit)
		{
			if (this.m_readEpoch == this.m_currentEpoch || this.m_writeEpoch == this.m_currentEpoch)
			{
				throw new global::System.InvalidOperationException();
			}
			if (retransmit != null)
			{
				this.m_retransmit = retransmit;
				this.m_retransmitEpoch = this.m_currentEpoch;
				this.m_retransmitTimeout = new global::Org.BouncyCastle.Tls.Timeout(240000L);
			}
			this.m_inHandshake = false;
			this.m_currentEpoch = this.m_pendingEpoch;
			this.m_pendingEpoch = null;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0001D5C6 File Offset: 0x0001B7C6
		internal virtual void InitHeartbeat(global::Org.BouncyCastle.Tls.TlsHeartbeat heartbeat, bool heartbeatResponder)
		{
			if (this.m_inHandshake)
			{
				throw new global::System.InvalidOperationException();
			}
			this.m_heartbeat = heartbeat;
			this.m_heartBeatResponder = heartbeatResponder;
			if (heartbeat != null)
			{
				this.ResetHeartbeat();
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0001D5EF File Offset: 0x0001B7EF
		internal virtual void ResetWriteEpoch()
		{
			if (this.m_retransmitEpoch != null)
			{
				this.m_writeEpoch = this.m_retransmitEpoch;
				return;
			}
			this.m_writeEpoch = this.m_currentEpoch;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0001D612 File Offset: 0x0001B812
		public virtual int GetReceiveLimit()
		{
			return global::System.Math.Min(this.m_plaintextLimit, this.m_readEpoch.Cipher.GetPlaintextLimit(this.m_transport.GetReceiveLimit() - 13));
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0001D63F File Offset: 0x0001B83F
		public virtual int GetSendLimit()
		{
			return global::System.Math.Min(this.m_plaintextLimit, this.m_writeEpoch.Cipher.GetPlaintextLimit(this.m_transport.GetSendLimit() - 13));
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0001D66C File Offset: 0x0001B86C
		public virtual int Receive(byte[] buf, int off, int len, int waitMillis)
		{
			long currentTimeMillis = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs();
			global::Org.BouncyCastle.Tls.Timeout timeout = global::Org.BouncyCastle.Tls.Timeout.ForWaitMillis(waitMillis, currentTimeMillis);
			byte[] record = null;
			while (waitMillis >= 0)
			{
				if (this.m_retransmitTimeout != null && this.m_retransmitTimeout.RemainingMillis(currentTimeMillis) < 1L)
				{
					this.m_retransmit = null;
					this.m_retransmitEpoch = null;
					this.m_retransmitTimeout = null;
				}
				if (global::Org.BouncyCastle.Tls.Timeout.HasExpired(this.m_heartbeatTimeout, currentTimeMillis))
				{
					if (this.m_heartbeatInFlight != null)
					{
						throw new global::Org.BouncyCastle.Tls.TlsTimeoutException("Heartbeat timed out");
					}
					this.m_heartbeatInFlight = global::Org.BouncyCastle.Tls.HeartbeatMessage.Create(this.m_context, 1, this.m_heartbeat.GeneratePayload());
					this.m_heartbeatTimeout = new global::Org.BouncyCastle.Tls.Timeout((long)this.m_heartbeat.TimeoutMillis, currentTimeMillis);
					this.m_heartbeatResendMillis = 1000;
					this.m_heartbeatResendTimeout = new global::Org.BouncyCastle.Tls.Timeout((long)this.m_heartbeatResendMillis, currentTimeMillis);
					this.SendHeartbeatMessage(this.m_heartbeatInFlight);
				}
				else if (global::Org.BouncyCastle.Tls.Timeout.HasExpired(this.m_heartbeatResendTimeout, currentTimeMillis))
				{
					this.m_heartbeatResendMillis = global::Org.BouncyCastle.Tls.DtlsReliableHandshake.BackOff(this.m_heartbeatResendMillis);
					this.m_heartbeatResendTimeout = new global::Org.BouncyCastle.Tls.Timeout((long)this.m_heartbeatResendMillis, currentTimeMillis);
					this.SendHeartbeatMessage(this.m_heartbeatInFlight);
				}
				waitMillis = global::Org.BouncyCastle.Tls.Timeout.ConstrainWaitMillis(waitMillis, this.m_heartbeatTimeout, currentTimeMillis);
				waitMillis = global::Org.BouncyCastle.Tls.Timeout.ConstrainWaitMillis(waitMillis, this.m_heartbeatResendTimeout, currentTimeMillis);
				if (waitMillis < 0)
				{
					waitMillis = 1;
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
				waitMillis = global::Org.BouncyCastle.Tls.Timeout.GetWaitMillis(timeout, currentTimeMillis);
			}
			return -1;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0001D800 File Offset: 0x0001BA00
		public virtual void Send(byte[] buf, int off, int len)
		{
			short contentType = 23;
			if (this.m_inHandshake || this.m_writeEpoch == this.m_retransmitEpoch)
			{
				contentType = 22;
				if (global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(buf, off) == 20)
				{
					global::Org.BouncyCastle.Tls.DtlsEpoch nextEpoch = null;
					if (this.m_inHandshake)
					{
						nextEpoch = this.m_pendingEpoch;
					}
					else if (this.m_writeEpoch == this.m_retransmitEpoch)
					{
						nextEpoch = this.m_currentEpoch;
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
					this.m_writeEpoch = nextEpoch;
				}
			}
			this.SendRecord(contentType, buf, off, len);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0001D892 File Offset: 0x0001BA92
		public virtual void Close()
		{
			if (!this.m_closed)
			{
				if (this.m_inHandshake && this.m_inConnection)
				{
					this.Warn(90, "User canceled handshake");
				}
				this.CloseTransport();
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0001D8C8 File Offset: 0x0001BAC8
		internal virtual void Fail(short alertDescription)
		{
			if (!this.m_closed)
			{
				if (this.m_inConnection)
				{
					try
					{
						this.RaiseAlert(2, alertDescription, null, null);
					}
					catch (global::System.Exception)
					{
					}
				}
				this.m_failed = true;
				this.CloseTransport();
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0001D918 File Offset: 0x0001BB18
		internal virtual void Failed()
		{
			if (!this.m_closed)
			{
				this.m_failed = true;
				this.CloseTransport();
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0001D933 File Offset: 0x0001BB33
		internal virtual void Warn(short alertDescription, string message)
		{
			this.RaiseAlert(1, alertDescription, message, null);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0001D940 File Offset: 0x0001BB40
		private void CloseTransport()
		{
			if (!this.m_closed)
			{
				try
				{
					if (!this.m_failed)
					{
						this.Warn(0, null);
					}
					this.m_transport.Close();
				}
				catch (global::System.Exception)
				{
				}
				this.m_closed = true;
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0001D994 File Offset: 0x0001BB94
		private void RaiseAlert(short alertLevel, short alertDescription, string message, global::System.Exception cause)
		{
			this.m_peer.NotifyAlertRaised(alertLevel, alertDescription, message, cause);
			this.SendRecord(21, new byte[]
			{
				(byte)alertLevel,
				(byte)alertDescription
			}, 0, 2);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0001D9D0 File Offset: 0x0001BBD0
		private int ReceiveDatagram(byte[] buf, int off, int len, int waitMillis)
		{
			int result;
			try
			{
				result = this.m_transport.Receive(buf, off, len, waitMillis);
			}
			catch (global::Org.BouncyCastle.Tls.TlsTimeoutException)
			{
				result = -1;
			}
			catch (global::System.Net.Sockets.SocketException e)
			{
				if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsTimeout(e))
				{
					throw e;
				}
				result = -1;
			}
			return result;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0001DA24 File Offset: 0x0001BC24
		private int ProcessRecord(int received, byte[] record, byte[] buf, int off)
		{
			if (received < 13)
			{
				return -1;
			}
			int length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(record, 11);
			if (received != length + 13)
			{
				return -1;
			}
			short recordType = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(record, 0);
			if (recordType - 20 > 4)
			{
				return -1;
			}
			int epoch = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(record, 3);
			global::Org.BouncyCastle.Tls.DtlsEpoch recordEpoch = null;
			if (epoch == this.m_readEpoch.Epoch)
			{
				recordEpoch = this.m_readEpoch;
			}
			else if (recordType == 22 && this.m_retransmitEpoch != null && epoch == this.m_retransmitEpoch.Epoch)
			{
				recordEpoch = this.m_retransmitEpoch;
			}
			if (recordEpoch == null)
			{
				return -1;
			}
			long seq = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint48(record, 5);
			if (recordEpoch.ReplayWindow.ShouldDiscard(seq))
			{
				return -1;
			}
			global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion = global::Org.BouncyCastle.Tls.TlsUtilities.ReadVersion(record, 1);
			if (!recordVersion.IsDtls)
			{
				return -1;
			}
			if (this.m_readVersion != null && !this.m_readVersion.Equals(recordVersion) && (this.ReadEpoch != 0 || length <= 0 || 22 != recordType || 1 != global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(record, 13)))
			{
				return -1;
			}
			long macSeqNo = global::Org.BouncyCastle.Tls.DtlsRecordLayer.GetMacSequenceNumber(recordEpoch.Epoch, seq);
			global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult decoded = recordEpoch.Cipher.DecodeCiphertext(macSeqNo, recordType, recordVersion, record, 13, length);
			recordEpoch.ReplayWindow.ReportAuthenticated(seq);
			if (decoded.len > this.m_plaintextLimit)
			{
				return -1;
			}
			if (decoded.len < 1 && decoded.contentType != 23)
			{
				return -1;
			}
			if (this.m_readVersion == null)
			{
				if (this.ReadEpoch == 0 && length > 0 && 22 == recordType && 3 == global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(record, 13))
				{
					if (!global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12.IsEqualOrLaterVersionOf(recordVersion))
					{
						return -1;
					}
				}
				else
				{
					this.m_readVersion = recordVersion;
				}
			}
			switch (decoded.contentType)
			{
			case 20:
				for (int i = 0; i < decoded.len; i++)
				{
					if (global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(decoded.buf, decoded.off + i) == 1 && this.m_pendingEpoch != null)
					{
						this.m_readEpoch = this.m_pendingEpoch;
					}
				}
				return -1;
			case 21:
				if (decoded.len == 2)
				{
					short alertLevel = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(decoded.buf, decoded.off);
					short alertDescription = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(decoded.buf, decoded.off + 1);
					this.m_peer.NotifyAlertReceived(alertLevel, alertDescription);
					if (alertLevel == 2)
					{
						this.Failed();
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(alertDescription);
					}
					if (alertDescription == 0)
					{
						this.CloseTransport();
					}
				}
				return -1;
			case 22:
				if (!this.m_inHandshake)
				{
					if (this.m_retransmit != null)
					{
						this.m_retransmit.ReceivedHandshakeRecord(epoch, decoded.buf, decoded.off, decoded.len);
					}
					return -1;
				}
				break;
			case 23:
				if (this.m_inHandshake)
				{
					return -1;
				}
				break;
			case 24:
				if (this.m_heartbeatInFlight != null || this.m_heartBeatResponder)
				{
					try
					{
						global::Org.BouncyCastle.Tls.HeartbeatMessage heartbeatMessage = global::Org.BouncyCastle.Tls.HeartbeatMessage.Parse(new global::System.IO.MemoryStream(decoded.buf, decoded.off, decoded.len, false));
						if (heartbeatMessage != null)
						{
							short type = heartbeatMessage.Type;
							if (type != 1)
							{
								if (type == 2)
								{
									if (this.m_heartbeatInFlight != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(heartbeatMessage.Payload, this.m_heartbeatInFlight.Payload))
									{
										this.ResetHeartbeat();
									}
								}
							}
							else if (this.m_heartBeatResponder)
							{
								global::Org.BouncyCastle.Tls.HeartbeatMessage response = global::Org.BouncyCastle.Tls.HeartbeatMessage.Create(this.m_context, 2, heartbeatMessage.Payload);
								this.SendHeartbeatMessage(response);
							}
						}
					}
					catch (global::System.Exception)
					{
					}
				}
				return -1;
			default:
				return -1;
			}
			if (!this.m_inHandshake && this.m_retransmit != null)
			{
				this.m_retransmit = null;
				this.m_retransmitEpoch = null;
				this.m_retransmitTimeout = null;
			}
			global::System.Array.Copy(decoded.buf, decoded.off, buf, off, decoded.len);
			return decoded.len;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0001DDD0 File Offset: 0x0001BFD0
		private int ReceiveRecord(byte[] buf, int off, int len, int waitMillis)
		{
			if (this.m_recordQueue.Available > 0)
			{
				int length = 0;
				if (this.m_recordQueue.Available >= 13)
				{
					byte[] lengthBytes = new byte[2];
					this.m_recordQueue.Read(lengthBytes, 0, 2, 11);
					length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(lengthBytes, 0);
				}
				int received = global::System.Math.Min(this.m_recordQueue.Available, 13 + length);
				this.m_recordQueue.RemoveData(buf, off, received, 0);
				return received;
			}
			int received2 = this.ReceiveDatagram(buf, off, len, waitMillis);
			if (received2 >= 13)
			{
				this.m_inConnection = true;
				int fragmentLength = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf, off + 11);
				int recordLength = 13 + fragmentLength;
				if (received2 > recordLength)
				{
					this.m_recordQueue.AddData(buf, off + recordLength, received2 - recordLength);
					received2 = recordLength;
				}
			}
			return received2;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0001DE8B File Offset: 0x0001C08B
		private void ResetHeartbeat()
		{
			this.m_heartbeatInFlight = null;
			this.m_heartbeatResendMillis = -1;
			this.m_heartbeatResendTimeout = null;
			this.m_heartbeatTimeout = new global::Org.BouncyCastle.Tls.Timeout((long)this.m_heartbeat.IdleMillis);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0001DEBC File Offset: 0x0001C0BC
		private void SendHeartbeatMessage(global::Org.BouncyCastle.Tls.HeartbeatMessage heartbeatMessage)
		{
			global::System.IO.MemoryStream output = new global::System.IO.MemoryStream();
			heartbeatMessage.Encode(output);
			byte[] buf = output.ToArray();
			this.SendRecord(24, buf, 0, buf.Length);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0001DEEC File Offset: 0x0001C0EC
		private void SendRecord(short contentType, byte[] buf, int off, int len)
		{
			if (this.m_writeVersion == null)
			{
				return;
			}
			if (len > this.m_plaintextLimit)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			if (len < 1 && contentType != 23)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			object writeLock = this.m_writeLock;
			lock (writeLock)
			{
				int recordEpoch = this.m_writeEpoch.Epoch;
				long recordSequenceNumber = this.m_writeEpoch.AllocateSequenceNumber();
				long macSequenceNumber = global::Org.BouncyCastle.Tls.DtlsRecordLayer.GetMacSequenceNumber(recordEpoch, recordSequenceNumber);
				global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion = this.m_writeVersion;
				global::Org.BouncyCastle.Tls.Crypto.TlsEncodeResult encoded = this.m_writeEpoch.Cipher.EncodePlaintext(macSequenceNumber, contentType, recordVersion, 13, buf, off, len);
				int i = encoded.len - 13;
				global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(i);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(encoded.recordType, encoded.buf, encoded.off);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteVersion(recordVersion, encoded.buf, encoded.off + 1);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(recordEpoch, encoded.buf, encoded.off + 3);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint48(recordSequenceNumber, encoded.buf, encoded.off + 5);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(i, encoded.buf, encoded.off + 11);
				global::Org.BouncyCastle.Tls.DtlsRecordLayer.SendDatagram(this.m_transport, encoded.buf, encoded.off, encoded.len);
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0001E044 File Offset: 0x0001C244
		private static long GetMacSequenceNumber(int epoch, long sequence_number)
		{
			return ((long)epoch & (long)((ulong)-1)) << 48 | sequence_number;
		}

		// Token: 0x040004E3 RID: 1251
		private const int RECORD_HEADER_LENGTH = 13;

		// Token: 0x040004E4 RID: 1252
		private const int MAX_FRAGMENT_LENGTH = 16384;

		// Token: 0x040004E5 RID: 1253
		private const long TCP_MSL = 120000L;

		// Token: 0x040004E6 RID: 1254
		private const long RETRANSMIT_TIMEOUT = 240000L;

		// Token: 0x040004E7 RID: 1255
		private readonly global::Org.BouncyCastle.Tls.TlsContext m_context;

		// Token: 0x040004E8 RID: 1256
		private readonly global::Org.BouncyCastle.Tls.TlsPeer m_peer;

		// Token: 0x040004E9 RID: 1257
		private readonly global::Org.BouncyCastle.Tls.DatagramTransport m_transport;

		// Token: 0x040004EA RID: 1258
		private readonly global::Org.BouncyCastle.Tls.ByteQueue m_recordQueue = new global::Org.BouncyCastle.Tls.ByteQueue();

		// Token: 0x040004EB RID: 1259
		private readonly object m_writeLock = new object();

		// Token: 0x040004EC RID: 1260
		private volatile bool m_closed;

		// Token: 0x040004ED RID: 1261
		private volatile bool m_failed;

		// Token: 0x040004EE RID: 1262
		private volatile global::Org.BouncyCastle.Tls.ProtocolVersion m_readVersion;

		// Token: 0x040004EF RID: 1263
		private volatile global::Org.BouncyCastle.Tls.ProtocolVersion m_writeVersion;

		// Token: 0x040004F0 RID: 1264
		private volatile bool m_inConnection;

		// Token: 0x040004F1 RID: 1265
		private volatile bool m_inHandshake;

		// Token: 0x040004F2 RID: 1266
		private volatile int m_plaintextLimit;

		// Token: 0x040004F3 RID: 1267
		private global::Org.BouncyCastle.Tls.DtlsEpoch m_currentEpoch;

		// Token: 0x040004F4 RID: 1268
		private global::Org.BouncyCastle.Tls.DtlsEpoch m_pendingEpoch;

		// Token: 0x040004F5 RID: 1269
		private global::Org.BouncyCastle.Tls.DtlsEpoch m_readEpoch;

		// Token: 0x040004F6 RID: 1270
		private global::Org.BouncyCastle.Tls.DtlsEpoch m_writeEpoch;

		// Token: 0x040004F7 RID: 1271
		private global::Org.BouncyCastle.Tls.DtlsHandshakeRetransmit m_retransmit;

		// Token: 0x040004F8 RID: 1272
		private global::Org.BouncyCastle.Tls.DtlsEpoch m_retransmitEpoch;

		// Token: 0x040004F9 RID: 1273
		private global::Org.BouncyCastle.Tls.Timeout m_retransmitTimeout;

		// Token: 0x040004FA RID: 1274
		private global::Org.BouncyCastle.Tls.TlsHeartbeat m_heartbeat;

		// Token: 0x040004FB RID: 1275
		private bool m_heartBeatResponder;

		// Token: 0x040004FC RID: 1276
		private global::Org.BouncyCastle.Tls.HeartbeatMessage m_heartbeatInFlight;

		// Token: 0x040004FD RID: 1277
		private global::Org.BouncyCastle.Tls.Timeout m_heartbeatTimeout;

		// Token: 0x040004FE RID: 1278
		private int m_heartbeatResendMillis = -1;

		// Token: 0x040004FF RID: 1279
		private global::Org.BouncyCastle.Tls.Timeout m_heartbeatResendTimeout;
	}
}
