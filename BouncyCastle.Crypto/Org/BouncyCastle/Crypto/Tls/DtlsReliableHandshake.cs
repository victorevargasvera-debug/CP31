using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000327 RID: 807
	internal class DtlsReliableHandshake
	{
		// Token: 0x060021E9 RID: 8681 RVA: 0x00095EAC File Offset: 0x000940AC
		internal DtlsReliableHandshake(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer transport, int timeoutMillis)
		{
			this.mRecordLayer = transport;
			this.mHandshakeTimeout = global::Org.BouncyCastle.Crypto.Tls.Timeout.ForWaitMillis(timeoutMillis);
			this.mHandshakeHash = new global::Org.BouncyCastle.Crypto.Tls.DeferredHash();
			this.mHandshakeHash.Init(context);
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00095F06 File Offset: 0x00094106
		internal void NotifyHelloComplete()
		{
			this.mHandshakeHash = this.mHandshakeHash.NotifyPrfDetermined();
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060021EB RID: 8683 RVA: 0x00095F19 File Offset: 0x00094119
		internal global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash HandshakeHash
		{
			get
			{
				return this.mHandshakeHash;
			}
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x00095F21 File Offset: 0x00094121
		internal global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash PrepareToFinish()
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash result = this.mHandshakeHash;
			this.mHandshakeHash = this.mHandshakeHash.StopTracking();
			return result;
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00095F3C File Offset: 0x0009413C
		internal void SendMessage(byte msg_type, byte[] body)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint24(body.Length);
			if (this.mResendTimeout != null)
			{
				this.CheckInboundFlight();
				this.mResendMillis = -1;
				this.mResendTimeout = null;
				this.mOutboundFlight.Clear();
			}
			int num = this.mMessageSeq;
			this.mMessageSeq = num + 1;
			global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message message = new global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message(num, msg_type, body);
			this.mOutboundFlight.Add(message);
			this.WriteMessage(message);
			this.UpdateHandshakeMessagesDigest(message);
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x00095FAD File Offset: 0x000941AD
		internal byte[] ReceiveMessageBody(byte msg_type)
		{
			global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message message = this.ReceiveMessage();
			if (message.Type != msg_type)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
			return message.Body;
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00095FCC File Offset: 0x000941CC
		internal global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message ReceiveMessage()
		{
			long currentTimeMillis = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs();
			if (this.mResendTimeout == null)
			{
				this.mResendMillis = 1000;
				this.mResendTimeout = new global::Org.BouncyCastle.Crypto.Tls.Timeout((long)this.mResendMillis, currentTimeMillis);
				this.PrepareInboundFlight(global::Org.BouncyCastle.Utilities.Platform.CreateHashtable());
			}
			byte[] buf = null;
			while (!this.mRecordLayer.IsClosed)
			{
				global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message pending = this.GetPendingMessage();
				if (pending != null)
				{
					return pending;
				}
				int handshakeMillis = global::Org.BouncyCastle.Crypto.Tls.Timeout.GetWaitMillis(this.mHandshakeTimeout, currentTimeMillis);
				if (handshakeMillis < 0)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
				}
				int waitMillis = global::System.Math.Max(1, global::Org.BouncyCastle.Crypto.Tls.Timeout.GetWaitMillis(this.mResendTimeout, currentTimeMillis));
				if (handshakeMillis > 0)
				{
					waitMillis = global::System.Math.Min(waitMillis, handshakeMillis);
				}
				int receiveLimit = this.mRecordLayer.GetReceiveLimit();
				if (buf == null || buf.Length < receiveLimit)
				{
					buf = new byte[receiveLimit];
				}
				int received = this.mRecordLayer.Receive(buf, 0, receiveLimit, waitMillis);
				if (received < 0)
				{
					this.ResendOutboundFlight();
				}
				else
				{
					this.ProcessRecord(16, this.mRecordLayer.ReadEpoch, buf, 0, received);
				}
				currentTimeMillis = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs();
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(90);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x000960D0 File Offset: 0x000942D0
		internal void Finish()
		{
			global::Org.BouncyCastle.Crypto.Tls.DtlsHandshakeRetransmit retransmit = null;
			if (this.mResendTimeout != null)
			{
				this.CheckInboundFlight();
			}
			else
			{
				this.PrepareInboundFlight(null);
				if (this.mPreviousInboundFlight != null)
				{
					retransmit = new global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Retransmit(this);
				}
			}
			this.mRecordLayer.HandshakeSuccessful(retransmit);
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x00096111 File Offset: 0x00094311
		internal void ResetHandshakeMessagesDigest()
		{
			this.mHandshakeHash.Reset();
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x0009611E File Offset: 0x0009431E
		private int BackOff(int timeoutMillis)
		{
			return global::System.Math.Min(timeoutMillis * 2, 60000);
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x00096130 File Offset: 0x00094330
		private void CheckInboundFlight()
		{
			foreach (object obj in this.mCurrentInboundFlight.Keys)
			{
				int num = (int)obj;
				int num2 = this.mNextReceiveSeq;
			}
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00096190 File Offset: 0x00094390
		private global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message GetPendingMessage()
		{
			global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler next = (global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler)this.mCurrentInboundFlight[this.mNextReceiveSeq];
			if (next != null)
			{
				byte[] body = next.GetBodyIfComplete();
				if (body != null)
				{
					this.mPreviousInboundFlight = null;
					int num = this.mNextReceiveSeq;
					this.mNextReceiveSeq = num + 1;
					return this.UpdateHandshakeMessagesDigest(new global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message(num, next.MsgType, body));
				}
			}
			return null;
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x000961F2 File Offset: 0x000943F2
		private void PrepareInboundFlight(global::System.Collections.IDictionary nextFlight)
		{
			global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.ResetAll(this.mCurrentInboundFlight);
			this.mPreviousInboundFlight = this.mCurrentInboundFlight;
			this.mCurrentInboundFlight = nextFlight;
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00096214 File Offset: 0x00094414
		private void ProcessRecord(int windowSize, int epoch, byte[] buf, int off, int len)
		{
			bool checkPreviousFlight = false;
			while (len >= 12)
			{
				int fragment_length = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(buf, off + 9);
				int message_length = fragment_length + 12;
				if (len < message_length)
				{
					break;
				}
				int length = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(buf, off + 1);
				int fragment_offset = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(buf, off + 6);
				if (fragment_offset + fragment_length > length)
				{
					break;
				}
				byte msg_type = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf, off);
				int expectedEpoch = (msg_type == 20) ? 1 : 0;
				if (epoch != expectedEpoch)
				{
					break;
				}
				int message_seq = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(buf, off + 4);
				if (message_seq < this.mNextReceiveSeq + windowSize)
				{
					if (message_seq >= this.mNextReceiveSeq)
					{
						global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler reassembler = (global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler)this.mCurrentInboundFlight[message_seq];
						if (reassembler == null)
						{
							reassembler = new global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler(msg_type, length);
							this.mCurrentInboundFlight[message_seq] = reassembler;
						}
						reassembler.ContributeFragment(msg_type, length, buf, off + 12, fragment_offset, fragment_length);
					}
					else if (this.mPreviousInboundFlight != null)
					{
						global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler reassembler2 = (global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler)this.mPreviousInboundFlight[message_seq];
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
			if (checkPreviousFlight && global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.CheckAll(this.mPreviousInboundFlight))
			{
				this.ResendOutboundFlight();
				global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.ResetAll(this.mPreviousInboundFlight);
			}
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00096368 File Offset: 0x00094568
		private void ResendOutboundFlight()
		{
			this.mRecordLayer.ResetWriteEpoch();
			for (int i = 0; i < this.mOutboundFlight.Count; i++)
			{
				this.WriteMessage((global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message)this.mOutboundFlight[i]);
			}
			this.mResendMillis = this.BackOff(this.mResendMillis);
			this.mResendTimeout = new global::Org.BouncyCastle.Crypto.Tls.Timeout((long)this.mResendMillis);
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x000963D4 File Offset: 0x000945D4
		private global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message UpdateHandshakeMessagesDigest(global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message message)
		{
			if (message.Type != 0)
			{
				byte[] body = message.Body;
				byte[] buf = new byte[12];
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(message.Type, buf, 0);
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(body.Length, buf, 1);
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(message.Seq, buf, 4);
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(0, buf, 6);
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(body.Length, buf, 9);
				this.mHandshakeHash.BlockUpdate(buf, 0, buf.Length);
				this.mHandshakeHash.BlockUpdate(body, 0, body.Length);
			}
			return message;
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x00096450 File Offset: 0x00094650
		private void WriteMessage(global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message message)
		{
			int fragmentLimit = this.mRecordLayer.GetSendLimit() - 12;
			if (fragmentLimit < 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
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

		// Token: 0x060021FA RID: 8698 RVA: 0x000964A0 File Offset: 0x000946A0
		private void WriteHandshakeFragment(global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message message, int fragment_offset, int fragment_length)
		{
			global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.RecordLayerBuffer fragment = new global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.RecordLayerBuffer(12 + fragment_length);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(message.Type, fragment);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(message.Body.Length, fragment);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(message.Seq, fragment);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(fragment_offset, fragment);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(fragment_length, fragment);
			fragment.Write(message.Body, fragment_offset, fragment_length);
			fragment.SendToRecordLayer(this.mRecordLayer);
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00096508 File Offset: 0x00094708
		private static bool CheckAll(global::System.Collections.IDictionary inboundFlight)
		{
			using (global::System.Collections.IEnumerator enumerator = inboundFlight.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler)enumerator.Current).GetBodyIfComplete() == null)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x00096568 File Offset: 0x00094768
		private static void ResetAll(global::System.Collections.IDictionary inboundFlight)
		{
			foreach (object obj in inboundFlight.Values)
			{
				((global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler)obj).Reset();
			}
		}

		// Token: 0x04000D02 RID: 3330
		private const int MaxReceiveAhead = 16;

		// Token: 0x04000D03 RID: 3331
		private const int MessageHeaderLength = 12;

		// Token: 0x04000D04 RID: 3332
		private const int InitialResendMillis = 1000;

		// Token: 0x04000D05 RID: 3333
		private const int MaxResendMillis = 60000;

		// Token: 0x04000D06 RID: 3334
		private readonly global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer mRecordLayer;

		// Token: 0x04000D07 RID: 3335
		private readonly global::Org.BouncyCastle.Crypto.Tls.Timeout mHandshakeTimeout;

		// Token: 0x04000D08 RID: 3336
		private global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash mHandshakeHash;

		// Token: 0x04000D09 RID: 3337
		private global::System.Collections.IDictionary mCurrentInboundFlight = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04000D0A RID: 3338
		private global::System.Collections.IDictionary mPreviousInboundFlight;

		// Token: 0x04000D0B RID: 3339
		private global::System.Collections.IList mOutboundFlight = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x04000D0C RID: 3340
		private int mResendMillis = -1;

		// Token: 0x04000D0D RID: 3341
		private global::Org.BouncyCastle.Crypto.Tls.Timeout mResendTimeout;

		// Token: 0x04000D0E RID: 3342
		private int mMessageSeq;

		// Token: 0x04000D0F RID: 3343
		private int mNextReceiveSeq;

		// Token: 0x020007F7 RID: 2039
		internal class Message
		{
			// Token: 0x06004630 RID: 17968 RVA: 0x0013626A File Offset: 0x0013446A
			internal Message(int message_seq, byte msg_type, byte[] body)
			{
				this.mMessageSeq = message_seq;
				this.mMsgType = msg_type;
				this.mBody = body;
			}

			// Token: 0x17000AA4 RID: 2724
			// (get) Token: 0x06004631 RID: 17969 RVA: 0x00136287 File Offset: 0x00134487
			public int Seq
			{
				get
				{
					return this.mMessageSeq;
				}
			}

			// Token: 0x17000AA5 RID: 2725
			// (get) Token: 0x06004632 RID: 17970 RVA: 0x0013628F File Offset: 0x0013448F
			public byte Type
			{
				get
				{
					return this.mMsgType;
				}
			}

			// Token: 0x17000AA6 RID: 2726
			// (get) Token: 0x06004633 RID: 17971 RVA: 0x00136297 File Offset: 0x00134497
			public byte[] Body
			{
				get
				{
					return this.mBody;
				}
			}

			// Token: 0x04002491 RID: 9361
			private readonly int mMessageSeq;

			// Token: 0x04002492 RID: 9362
			private readonly byte mMsgType;

			// Token: 0x04002493 RID: 9363
			private readonly byte[] mBody;
		}

		// Token: 0x020007F8 RID: 2040
		internal class RecordLayerBuffer : global::System.IO.MemoryStream
		{
			// Token: 0x06004634 RID: 17972 RVA: 0x0013629F File Offset: 0x0013449F
			internal RecordLayerBuffer(int size) : base(size)
			{
			}

			// Token: 0x06004635 RID: 17973 RVA: 0x001362A8 File Offset: 0x001344A8
			internal void SendToRecordLayer(global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer recordLayer)
			{
				byte[] buf = this.GetBuffer();
				int bufLen = (int)this.Length;
				recordLayer.Send(buf, 0, bufLen);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this);
			}
		}

		// Token: 0x020007F9 RID: 2041
		internal class Retransmit : global::Org.BouncyCastle.Crypto.Tls.DtlsHandshakeRetransmit
		{
			// Token: 0x06004636 RID: 17974 RVA: 0x001362D3 File Offset: 0x001344D3
			internal Retransmit(global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake outer)
			{
				this.mOuter = outer;
			}

			// Token: 0x06004637 RID: 17975 RVA: 0x001362E2 File Offset: 0x001344E2
			public void ReceivedHandshakeRecord(int epoch, byte[] buf, int off, int len)
			{
				this.mOuter.ProcessRecord(0, epoch, buf, off, len);
			}

			// Token: 0x04002494 RID: 9364
			private readonly global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake mOuter;
		}
	}
}
