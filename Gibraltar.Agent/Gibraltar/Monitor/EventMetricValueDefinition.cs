using System;
using System.Diagnostics;
using System.Reflection;
using Gibraltar.Monitor.Internal;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001B9 RID: 441
	[global::System.Diagnostics.DebuggerDisplay("Name: {Name}, Index: {Index}")]
	internal class EventMetricValueDefinition : global::Loupe.Extensibility.Data.IEventMetricValueDefinition, global::System.IEquatable<global::Loupe.Extensibility.Data.IEventMetricValueDefinition>
	{
		// Token: 0x06001404 RID: 5124 RVA: 0x0003B170 File Offset: 0x00039370
		internal EventMetricValueDefinition(global::Gibraltar.Monitor.EventMetricDefinition definition, global::Gibraltar.Monitor.Internal.EventMetricValueDefinitionPacket packet)
		{
			this.m_Definition = definition;
			this.m_Packet = packet;
			this.m_Trendable = global::Gibraltar.Monitor.EventMetricDefinition.IsTrendableValueType(this.m_Packet.Type);
			this.MyIndex = -1;
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x0003B1A4 File Offset: 0x000393A4
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x0003B1B4 File Offset: 0x000393B4
		public global::Loupe.Extensibility.Data.EventMetricValueTrend DefaultTrend
		{
			get
			{
				return this.m_Packet.DefaultTrend;
			}
			set
			{
				this.m_Packet.DefaultTrend = value;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x0003B1C4 File Offset: 0x000393C4
		public global::Loupe.Extensibility.Data.IEventMetricDefinition Definition
		{
			get
			{
				return this.m_Definition;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0003B1CC File Offset: 0x000393CC
		public string Name
		{
			get
			{
				return this.m_Packet.Name;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x0003B1DC File Offset: 0x000393DC
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x0003B1EC File Offset: 0x000393EC
		public string Caption
		{
			get
			{
				return this.m_Packet.Caption;
			}
			set
			{
				this.m_Packet.Caption = value;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x0003B1FC File Offset: 0x000393FC
		// (set) Token: 0x0600140C RID: 5132 RVA: 0x0003B20C File Offset: 0x0003940C
		public string Description
		{
			get
			{
				return this.m_Packet.Description;
			}
			set
			{
				this.m_Packet.Description = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x0003B21C File Offset: 0x0003941C
		public global::System.Type Type
		{
			get
			{
				return this.m_Packet.Type;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0003B22C File Offset: 0x0003942C
		public global::System.Type SerializedType
		{
			get
			{
				return this.m_Packet.SerializedType;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x0003B23C File Offset: 0x0003943C
		public bool IsTrendable
		{
			get
			{
				return this.m_Trendable;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0003B244 File Offset: 0x00039444
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x0003B254 File Offset: 0x00039454
		public string UnitCaption
		{
			get
			{
				return this.m_Packet.UnitCaption;
			}
			set
			{
				this.m_Packet.UnitCaption = value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0003B264 File Offset: 0x00039464
		public int Index
		{
			get
			{
				return this.MyIndex;
			}
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0003B26C File Offset: 0x0003946C
		public bool Equals(global::Loupe.Extensibility.Data.IEventMetricValueDefinition other)
		{
			return other != null && (this == other || this.m_Packet == ((global::Gibraltar.Monitor.EventMetricValueDefinition)other).Packet || this.m_Packet.Name.Equals(other.Name));
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0003B2AC File Offset: 0x000394AC
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x0003B2B4 File Offset: 0x000394B4
		public bool Bound { get; set; }

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0003B2C0 File Offset: 0x000394C0
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x0003B2C8 File Offset: 0x000394C8
		public global::System.Reflection.MemberTypes MemberType { get; set; }

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0003B2D4 File Offset: 0x000394D4
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x0003B2DC File Offset: 0x000394DC
		public string MemberName { get; set; }

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x0003B2E8 File Offset: 0x000394E8
		internal global::Gibraltar.Monitor.Internal.EventMetricValueDefinitionPacket Packet
		{
			get
			{
				return this.m_Packet;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0003B2F0 File Offset: 0x000394F0
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x0003B2F8 File Offset: 0x000394F8
		internal int MyIndex { get; set; }

		// Token: 0x0600141D RID: 5149 RVA: 0x0003B304 File Offset: 0x00039504
		internal void AddField(global::Gibraltar.Serialization.PacketDefinition definition)
		{
			definition.Fields.Add(this.Name, this.m_Packet.SerializedType);
		}

		// Token: 0x0400069B RID: 1691
		private readonly global::Gibraltar.Monitor.EventMetricDefinition m_Definition;

		// Token: 0x0400069C RID: 1692
		private readonly global::Gibraltar.Monitor.Internal.EventMetricValueDefinitionPacket m_Packet;

		// Token: 0x0400069D RID: 1693
		private readonly bool m_Trendable;
	}
}
