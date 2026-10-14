using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000BD RID: 189
	internal class DtlsReliableHandshake
	{
		// Token: 0x06000729 RID: 1833 RVA: 0x0001E050 File Offset: 0x0001C250
		internal static global::Org.BouncyCastle.Tls.DtlsRequest ReadClientRequest(byte[] data, int dataOff, int dataLen, global::System.IO.Stream dtlsOutput)
		{
			byte[] message = global::Org.BouncyCastle.Tls.DtlsRecordLayer.ReceiveClientHelloRecord(data, dataOff, dataLen);
			if (message == null || message.Length < 12)
			{
				return null;
			}
			long recordSeq = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint48(data, dataOff + 5);
			short msgType = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(message, 0);
			if (1 != msgType)
			{
				return null;
			}
			int length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(message, 1);
			if (message.Length != 12 + length)
			{
				return null;
			}
			int fragmentOffset = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(message, 6);
			if (fragmentOffset != 0)
			{
				return null;
			}
			int fragmentLength = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(message, 9);
			if (length != fragmentLength)
			{
				return null;
			}
			global::Org.BouncyCastle.Tls.ClientHello clientHello = global::Org.BouncyCastle.Tls.ClientHello.Parse(new global::System.IO.MemoryStream(message, 12, length, false), dtlsOutput);
			return new global::Org.BouncyCastle.Tls.DtlsRequest(recordSeq, message, clientHello);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0001E0D8 File Offset: 0x0001C2D8
		internal static void SendHelloVerifyRequest(global::Org.BouncyCastle.Tls.DatagramSender sender, long recordSeq, byte[] cookie)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint8(cookie.Length);
			int length = 3 + cookie.Length;
			byte[] message = new byte[12 + length];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(3, message, 0);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(length, message, 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(length, message, 9);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteVersion(global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv10, message, 12);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(cookie, message, 14);
			global::Org.BouncyCastle.Tls.DtlsRecordLayer.SendHelloVerifyRequestRecord(sender, recordSeq, message);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0001E134 File Offset: 0x0001C334
		internal DtlsReliableHandshake(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.DtlsRecordLayer transport, int timeoutMillis, global::Org.BouncyCastle.Tls.DtlsRequest request)
		{
			this.m_recordLayer = transport;
			this.m_handshakeHash = new global::Org.BouncyCastle.Tls.DeferredHash(context);
			this.m_handshakeTimeout = global::Org.BouncyCastle.Tls.Timeout.ForWaitMillis(timeoutMillis);
			if (request != null)
			{
				this.m_resendMillis = 1000;
				this.m_resendTimeout = new global::Org.BouncyCastle.Tls.Timeout((long)this.m_resendMillis);
				long recordSeq = request.RecordSeq;
				int messageSeq = request.MessageSeq;
				byte[] message = request.Message;
				this.m_recordLayer.ResetAfterHelloVerifyRequestServer(recordSeq);
				global::Org.BouncyCastle.Tls.DtlsReassembler reassembler = new global::Org.BouncyCastle.Tls.DtlsReassembler(1, message.Length - 12);
				this.m_currentInboundFlight[messageSeq] = reassembler;
				this.m_next_send_seq = 1;
				this.m_next_receive_seq = messageSeq + 1;
				this.m_handshakeHash.Update(message, 0, message.Length);
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0001E20A File Offset: 0x0001C40A
		internal void ResetAfterHelloVerifyRequestClient()
		{
			this.m_currentInboundFlight = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			this.m_previousInboundFlight = null;
			this.m_outboundFlight = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			this.m_resendMillis = -1;
			this.m_resendTimeout = null;
			this.m_next_receive_seq = 1;
			this.m_handshakeHash.Reset();
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x0001E249 File Offset: 0x0001C449
		internal global::Org.BouncyCastle.Tls.TlsHandshakeHash HandshakeHash
		{
			get
			{
				return this.m_handshakeHash;
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0001E251 File Offset: 0x0001C451
		internal global::Org.BouncyCastle.Tls.TlsHandshakeHash PrepareToFinish()
		{
			global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash = this.m_handshakeHash;
			this.m_handshakeHash = this.m_handshakeHash.StopTracking();
			return handshakeHash;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0001E26C File Offset: 0x0001C46C
		internal void SendMessage(short msg_type, byte[] body)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint24(body.Length);
			if (this.m_resendTimeout != null)
			{
				this.CheckInboundFlight();
				this.m_resendMillis = -1;
				this.m_resendTimeout = null;
				this.m_outboundFlight.Clear();
			}
			int next_send_seq = this.m_next_send_seq;
			this.m_next_send_seq = next_send_seq + 1;
			global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message message = new global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message(next_send_seq, msg_type, body);
			this.m_outboundFlight.Add(message);
			this.WriteMessage(message);
			this.UpdateHandshakeMessagesDigest(message);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0001E2DD File Offset: 0x0001C4DD
		internal byte[] ReceiveMessageBody(short msg_type)
		{
			global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message message = this.ReceiveMessage();
			if (message.Type != msg_type)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			return message.Body;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0001E2FC File Offset: 0x0001C4FC
		internal global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message ReceiveMessage()
		{
			long currentTimeMillis = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs();
			if (this.m_resendTimeout == null)
			{
				this.m_resendMillis = 1000;
				this.m_resendTimeout = new global::Org.BouncyCastle.Tls.Timeout((long)this.m_resendMillis, currentTimeMillis);
				this.PrepareInboundFlight(global::Org.BouncyCastle.Utilities.Platform.CreateHashtable());
			}
			byte[] buf = null;
			while (!this.m_recordLayer.IsClosed)
			{
				global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message pending = this.GetPendingMessage();
				if (pending != null)
				{
					return pending;
				}
				if (global::Org.BouncyCastle.Tls.Timeout.HasExpired(this.m_handshakeTimeout, currentTimeMillis))
				{
					throw new global::Org.BouncyCastle.Tls.TlsTimeoutException("Handshake timed out");
				}
				int waitMillis = global::Org.BouncyCastle.Tls.Timeout.GetWaitMillis(this.m_handshakeTimeout, currentTimeMillis);
				waitMillis = global::Org.BouncyCastle.Tls.Timeout.ConstrainWaitMillis(waitMillis, this.m_resendTimeout, currentTimeMillis);
				if (waitMillis < 1)
				{
					waitMillis = 1;
				}
				int receiveLimit = this.m_recordLayer.GetReceiveLimit();
				if (buf == null || buf.Length < receiveLimit)
				{
					buf = new byte[receiveLimit];
				}
				int received = this.m_recordLayer.Receive(buf, 0, receiveLimit, waitMillis);
				if (received < 0)
				{
					this.ResendOutboundFlight();
				}
				else
				{
					this.ProcessRecord(16, this.m_recordLayer.ReadEpoch, buf, 0, received);
				}
				currentTimeMillis = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs();
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(90);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0001E3FC File Offset: 0x0001C5FC
		internal void Finish()
		{
			global::Org.BouncyCastle.Tls.DtlsHandshakeRetransmit retransmit = null;
			if (this.m_resendTimeout != null)
			{
				this.CheckInboundFlight();
			}
			else
			{
				this.PrepareInboundFlight(null);
				if (this.m_previousInboundFlight != null)
				{
					retransmit = new global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Retransmit(this);
				}
			}
			this.m_recordLayer.HandshakeSuccessful(retransmit);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0001E43D File Offset: 0x0001C63D
		internal static int BackOff(int timeoutMillis)
		{
			return global::System.Math.Min(timeoutMillis * 2, 60000);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001E44C File Offset: 0x0001C64C
		private void CheckInboundFlight()
		{
			foreach (object obj in this.m_currentInboundFlight.Keys)
			{
				int num = (int)obj;
				int next_receive_seq = this.m_next_receive_seq;
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0001E4AC File Offset: 0x0001C6AC
		private global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message GetPendingMessage()
		{
			global::Org.BouncyCastle.Tls.DtlsReassembler next = (global::Org.BouncyCastle.Tls.DtlsReassembler)this.m_currentInboundFlight[this.m_next_receive_seq];
			if (next != null)
			{
				byte[] body = next.GetBodyIfComplete();
				if (body != null)
				{
					this.m_previousInboundFlight = null;
					int next_receive_seq = this.m_next_receive_seq;
					this.m_next_receive_seq = next_receive_seq + 1;
					return this.UpdateHandshakeMessagesDigest(new global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message(next_receive_seq, next.MsgType, body));
				}
			}
			return null;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0001E50E File Offset: 0x0001C70E
		private void PrepareInboundFlight(global::System.Collections.IDictionary nextFlight)
		{
			global::Org.BouncyCastle.Tls.DtlsReliableHandshake.ResetAll(this.m_currentInboundFlight);
			this.m_previousInboundFlight = this.m_currentInboundFlight;
			this.m_currentInboundFlight = nextFlight;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0001E530 File Offset: 0x0001C730
		private void ProcessRecord(int windowSize, int epoch, byte[] buf, int off, int len)
		{
			bool checkPreviousFlight = false;
			while (len >= 12)
			{
				int fragment_length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(buf, off + 9);
				int message_length = fragment_length + 12;
				if (len < message_length)
				{
					break;
				}
				int length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(buf, off + 1);
				int fragment_offset = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(buf, off + 6);
				if (fragment_offset + fragment_length > length)
				{
					break;
				}
				short msg_type = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(buf, off);
				int expectedEpoch = (msg_type == 20) ? 1 : 0;
				if (epoch != expectedEpoch)
				{
					break;
				}
				int message_seq = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf, off + 4);
				if (message_seq < this.m_next_receive_seq + windowSize)
				{
					if (message_seq >= this.m_next_receive_seq)
					{
						global::Org.BouncyCastle.Tls.DtlsReassembler reassembler = (global::Org.BouncyCastle.Tls.DtlsReassembler)this.m_currentInboundFlight[message_seq];
						if (reassembler == null)
						{
							reassembler = new global::Org.BouncyCastle.Tls.DtlsReassembler(msg_type, length);
							this.m_currentInboundFlight[message_seq] = reassembler;
						}
						reassembler.ContributeFragment(msg_type, length, buf, off + 12, fragment_offset, fragment_length);
					}
					else if (this.m_previousInboundFlight != null)
					{
						global::Org.BouncyCastle.Tls.DtlsReassembler reassembler2 = (global::Org.BouncyCastle.Tls.DtlsReassembler)this.m_previousInboundFlight[message_seq];
						if (reassembler2 != null)
						{
							reassembler2.ContributeFragment(msg_type, length, buf, off + 12, fragment_offset, fragment_length);
							checkPreviousFlight = true;
						}
					}
				}
				off += message_length;
				len -= message_length;
			}
			if (checkPreviousFlight && global::Org.BouncyCastle.Tls.DtlsReliableHandshake.CheckAll(this.m_previousInboundFlight))
			{
				this.ResendOutboundFlight();
				global::Org.BouncyCastle.Tls.DtlsReliableHandshake.ResetAll(this.m_previousInboundFlight);
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0001E684 File Offset: 0x0001C884
		private void ResendOutboundFlight()
		{
			this.m_recordLayer.ResetWriteEpoch();
			foreach (object obj in this.m_outboundFlight)
			{
				global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message message = (global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message)obj;
				this.WriteMessage(message);
			}
			this.m_resendMillis = global::Org.BouncyCastle.Tls.DtlsReliableHandshake.BackOff(this.m_resendMillis);
			this.m_resendTimeout = new global::Org.BouncyCastle.Tls.Timeout((long)this.m_resendMillis);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0001E70C File Offset: 0x0001C90C
		private global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message UpdateHandshakeMessagesDigest(global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message message)
		{
			short msg_type = message.Type;
			switch (msg_type)
			{
			case 0:
			case 3:
				return message;
			case 1:
			case 2:
			case 4:
				break;
			default:
				if (msg_type == 24)
				{
					return message;
				}
				break;
			}
			byte[] body = message.Body;
			byte[] buf = new byte[12];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(msg_type, buf, 0);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(body.Length, buf, 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(message.Seq, buf, 4);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(0, buf, 6);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(body.Length, buf, 9);
			this.m_handshakeHash.Update(buf, 0, buf.Length);
			this.m_handshakeHash.Update(body, 0, body.Length);
			return message;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0001E7A4 File Offset: 0x0001C9A4
		private void WriteMessage(global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message message)
		{
			int fragmentLimit = this.m_recordLayer.GetSendLimit() - 12;
			if (fragmentLimit < 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			int length = message.Body.Length;
			int fragment_offset = 0;
			do
			{
				int fragment_length = global::System.Math.Min(length - fragment_offset, fragmentLimit);
				this.WriteHandshakeFragment(message, fragment_offset, fragment_length);
				fragment_offset += fragment_length;
			}
			while (fragment_offset < length);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0001E7F4 File Offset: 0x0001C9F4
		private void WriteHandshakeFragment(global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message message, int fragment_offset, int fragment_length)
		{
			global::Org.BouncyCastle.Tls.DtlsReliableHandshake.RecordLayerBuffer fragment = new global::Org.BouncyCastle.Tls.DtlsReliableHandshake.RecordLayerBuffer(12 + fragment_length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(message.Type, fragment);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(message.Body.Length, fragment);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(message.Seq, fragment);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(fragment_offset, fragment);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(fragment_length, fragment);
			fragment.Write(message.Body, fragment_offset, fragment_length);
			fragment.SendToRecordLayer(this.m_recordLayer);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0001E85C File Offset: 0x0001CA5C
		private static bool CheckAll(global::System.Collections.IDictionary inboundFlight)
		{
			using (global::System.Collections.IEnumerator enumerator = inboundFlight.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((global::Org.BouncyCastle.Tls.DtlsReassembler)enumerator.Current).GetBodyIfComplete() == null)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0001E8BC File Offset: 0x0001CABC
		private static void ResetAll(global::System.Collections.IDictionary inboundFlight)
		{
			foreach (object obj in inboundFlight.Values)
			{
				((global::Org.BouncyCastle.Tls.DtlsReassembler)obj).Reset();
			}
		}

		// Token: 0x04000500 RID: 1280
		private const int MAX_RECEIVE_AHEAD = 16;

		// Token: 0x04000501 RID: 1281
		private const int MESSAGE_HEADER_LENGTH = 12;

		// Token: 0x04000502 RID: 1282
		internal const int INITIAL_RESEND_MILLIS = 1000;

		// Token: 0x04000503 RID: 1283
		private const int MAX_RESEND_MILLIS = 60000;

		// Token: 0x04000504 RID: 1284
		private global::Org.BouncyCastle.Tls.DtlsRecordLayer m_recordLayer;

		// Token: 0x04000505 RID: 1285
		private global::Org.BouncyCastle.Tls.Timeout m_handshakeTimeout;

		// Token: 0x04000506 RID: 1286
		private global::Org.BouncyCastle.Tls.TlsHandshakeHash m_handshakeHash;

		// Token: 0x04000507 RID: 1287
		private global::System.Collections.IDictionary m_currentInboundFlight = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04000508 RID: 1288
		private global::System.Collections.IDictionary m_previousInboundFlight;

		// Token: 0x04000509 RID: 1289
		private global::System.Collections.IList m_outboundFlight = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x0400050A RID: 1290
		private int m_resendMillis = -1;

		// Token: 0x0400050B RID: 1291
		private global::Org.BouncyCastle.Tls.Timeout m_resendTimeout;

		// Token: 0x0400050C RID: 1292
		private int m_next_send_seq;

		// Token: 0x0400050D RID: 1293
		private int m_next_receive_seq;

		// Token: 0x020007A4 RID: 1956
		internal class Message
		{
			// Token: 0x0600450D RID: 17677 RVA: 0x00132739 File Offset: 0x00130939
			internal Message(int message_seq, short msg_type, byte[] body)
			{
				this.m_message_seq = message_seq;
				this.m_msg_type = msg_type;
				this.m_body = body;
			}

			// Token: 0x17000A6E RID: 2670
			// (get) Token: 0x0600450E RID: 17678 RVA: 0x00132756 File Offset: 0x00130956
			public int Seq
			{
				get
				{
					return this.m_message_seq;
				}
			}

			// Token: 0x17000A6F RID: 2671
			// (get) Token: 0x0600450F RID: 17679 RVA: 0x0013275E File Offset: 0x0013095E
			public short Type
			{
				get
				{
					return this.m_msg_type;
				}
			}

			// Token: 0x17000A70 RID: 2672
			// (get) Token: 0x06004510 RID: 17680 RVA: 0x00132766 File Offset: 0x00130966
			public byte[] Body
			{
				get
				{
					return this.m_body;
				}
			}

			// Token: 0x04002301 RID: 8961
			private readonly int m_message_seq;

			// Token: 0x04002302 RID: 8962
			private readonly short m_msg_type;

			// Token: 0x04002303 RID: 8963
			private readonly byte[] m_body;
		}

		// Token: 0x020007A5 RID: 1957
		internal class RecordLayerBuffer : global::System.IO.MemoryStream
		{
			// Token: 0x06004511 RID: 17681 RVA: 0x0013276E File Offset: 0x0013096E
			internal RecordLayerBuffer(int size) : base(size)
			{
			}

			// Token: 0x06004512 RID: 17682 RVA: 0x00132778 File Offset: 0x00130978
			internal void SendToRecordLayer(global::Org.BouncyCastle.Tls.DtlsRecordLayer recordLayer)
			{
				byte[] buf = this.GetBuffer();
				int bufLen = (int)this.Length;
				recordLayer.Send(buf, 0, bufLen);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this);
			}
		}

		// Token: 0x020007A6 RID: 1958
		internal class Retransmit : global::Org.BouncyCastle.Tls.DtlsHandshakeRetransmit
		{
			// Token: 0x06004513 RID: 17683 RVA: 0x001327A3 File Offset: 0x001309A3
			internal Retransmit(global::Org.BouncyCastle.Tls.DtlsReliableHandshake outer)
			{
				this.m_outer = outer;
			}

			// Token: 0x06004514 RID: 17684 RVA: 0x001327B2 File Offset: 0x001309B2
			public void ReceivedHandshakeRecord(int epoch, byte[] buf, int off, int len)
			{
				this.m_outer.ProcessRecord(0, epoch, buf, off, len);
			}

			// Token: 0x04002304 RID: 8964
			private readonly global::Org.BouncyCastle.Tls.DtlsReliableHandshake m_outer;
		}
	}
}
