using System;
using System.IO;
using Gibraltar.Data;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x02000242 RID: 578
	internal class ClockDriftMessage : global::Gibraltar.Messaging.Net.NetworkMessage
	{
		// Token: 0x06001D20 RID: 7456 RVA: 0x000668FC File Offset: 0x00064AFC
		internal ClockDriftMessage()
		{
			base.TypeCode = global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.ClockDrift;
			base.Version = new global::System.Version(1, 0);
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0006691C File Offset: 0x00064B1C
		public ClockDriftMessage(global::System.Guid id) : this()
		{
			this.m_Id = id;
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x0006692C File Offset: 0x00064B2C
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x00066934 File Offset: 0x00064B34
		public global::System.Guid Id
		{
			get
			{
				return this.m_Id;
			}
			set
			{
				this.m_Id = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x00066940 File Offset: 0x00064B40
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x00066948 File Offset: 0x00064B48
		public global::System.DateTimeOffset? OriginatorTimestamp
		{
			get
			{
				return this.m_OriginatorTimestamp;
			}
			set
			{
				this.m_OriginatorTimestamp = value;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x00066954 File Offset: 0x00064B54
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x0006695C File Offset: 0x00064B5C
		public global::System.DateTimeOffset? DestinationTimestamp
		{
			get
			{
				return this.m_DestinationTimestamp;
			}
			set
			{
				this.m_DestinationTimestamp = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x00066968 File Offset: 0x00064B68
		public global::System.TimeSpan ClockDrift
		{
			get
			{
				return this.m_ClockDrift;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00066970 File Offset: 0x00064B70
		public global::System.TimeSpan Latency
		{
			get
			{
				return this.m_Latency;
			}
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x00066978 File Offset: 0x00064B78
		public void CalculateValues()
		{
			long num = (this.m_DeserializationTimestamp - this.m_OriginatorTimestamp.Value).Ticks;
			if (num < 0L)
			{
				num = 0L;
			}
			this.m_Latency = new global::System.TimeSpan(num / 2L);
			if (this.m_DestinationTimestamp != null)
			{
				this.m_ClockDrift = this.m_OriginatorTimestamp.Value - this.m_DestinationTimestamp.Value - this.m_Latency - this.m_Latency;
			}
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x00066A0C File Offset: 0x00064C0C
		protected override void OnWrite(global::System.IO.Stream stream)
		{
			if (this.OriginatorTimestamp == null)
			{
				this.OriginatorTimestamp = new global::System.DateTimeOffset?(global::System.DateTimeOffset.Now);
			}
			global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.Id);
			global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.OriginatorTimestamp.Value);
			global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.DestinationTimestamp ?? global::System.DateTimeOffset.MinValue);
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x00066A8C File Offset: 0x00064C8C
		protected override void OnRead(global::System.IO.Stream stream)
		{
			this.m_DeserializationTimestamp = global::System.DateTimeOffset.Now;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_Id);
			global::System.DateTimeOffset dateTimeOffset;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out dateTimeOffset);
			if (dateTimeOffset != global::System.DateTimeOffset.MinValue)
			{
				this.m_OriginatorTimestamp = new global::System.DateTimeOffset?(dateTimeOffset);
			}
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out dateTimeOffset);
			if (dateTimeOffset != global::System.DateTimeOffset.MinValue)
			{
				this.m_DestinationTimestamp = new global::System.DateTimeOffset?(dateTimeOffset);
			}
		}

		// Token: 0x04000ACD RID: 2765
		private global::System.Guid m_Id;

		// Token: 0x04000ACE RID: 2766
		private global::System.DateTimeOffset? m_OriginatorTimestamp;

		// Token: 0x04000ACF RID: 2767
		private global::System.DateTimeOffset? m_DestinationTimestamp;

		// Token: 0x04000AD0 RID: 2768
		private global::System.DateTimeOffset m_DeserializationTimestamp;

		// Token: 0x04000AD1 RID: 2769
		private global::System.TimeSpan m_ClockDrift;

		// Token: 0x04000AD2 RID: 2770
		private global::System.TimeSpan m_Latency;
	}
}
