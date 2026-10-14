using System;
using System.IO;
using Gibraltar.Data;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x02000252 RID: 594
	internal class SessionHeaderMessage : global::Gibraltar.Messaging.Net.NetworkMessage
	{
		// Token: 0x06001DB3 RID: 7603 RVA: 0x00068B3C File Offset: 0x00066D3C
		internal SessionHeaderMessage()
		{
			base.TypeCode = global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.SessionHeader;
			base.Version = new global::System.Version(1, 0);
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00068B58 File Offset: 0x00066D58
		public SessionHeaderMessage(global::Gibraltar.Data.SessionHeader sessionHeader) : this(sessionHeader, global::System.TimeSpan.Zero)
		{
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00068B68 File Offset: 0x00066D68
		public SessionHeaderMessage(global::Gibraltar.Data.SessionHeader sessionHeader, global::System.TimeSpan clockDrift) : this()
		{
			this.m_SessionHeader = sessionHeader;
			this.m_ClockDrift = clockDrift;
			this.m_Timestamp = global::System.DateTimeOffset.Now;
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x00068B8C File Offset: 0x00066D8C
		public global::Gibraltar.Data.SessionHeader SessionHeader
		{
			get
			{
				return this.m_SessionHeader;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x00068B94 File Offset: 0x00066D94
		public global::System.DateTimeOffset Timestamp
		{
			get
			{
				return this.m_Timestamp;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00068B9C File Offset: 0x00066D9C
		public global::System.TimeSpan ClockDrift
		{
			get
			{
				return this.m_ClockDrift;
			}
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00068BA4 File Offset: 0x00066DA4
		protected override void OnRead(global::System.IO.Stream stream)
		{
			long position = stream.Position;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_Timestamp);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_ClockDrift);
			int length = base.Length - this.BaseLength - (int)(stream.Position - position);
			this.m_SessionHeader = new global::Gibraltar.Data.SessionHeader(stream, length);
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00068BFC File Offset: 0x00066DFC
		protected override void OnWrite(global::System.IO.Stream stream)
		{
			global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_Timestamp);
			global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_ClockDrift);
			byte[] array = this.m_SessionHeader.RawData();
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x04000B0E RID: 2830
		private global::Gibraltar.Data.SessionHeader m_SessionHeader;

		// Token: 0x04000B0F RID: 2831
		private global::System.DateTimeOffset m_Timestamp;

		// Token: 0x04000B10 RID: 2832
		private global::System.TimeSpan m_ClockDrift;
	}
}
