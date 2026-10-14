using System;
using System.Globalization;
using System.Reflection;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000216 RID: 534
	internal class MetricDefinitionPacket : global::Gibraltar.Monitor.Internal.GibraltarCachedPacket, global::Gibraltar.Serialization.IPacket, global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricDefinition, global::Gibraltar.Monitor.MetricDefinitionCollection>, global::System.IComparable<global::Gibraltar.Monitor.Internal.MetricDefinitionPacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.MetricDefinitionPacket>, global::Gibraltar.Monitor.Internal.IDisplayable
	{
		// Token: 0x06001A9B RID: 6811 RVA: 0x0005CE2C File Offset: 0x0005B02C
		public MetricDefinitionPacket(string metricTypeName, string categoryName, string counterName, global::Loupe.Extensibility.Data.SampleType sampleType, string description) : this(metricTypeName, categoryName, counterName, sampleType)
		{
			this.Description = description;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0005CE44 File Offset: 0x0005B044
		public MetricDefinitionPacket(string metricTypeName, string categoryName, string counterName, global::Loupe.Extensibility.Data.SampleType sampleType) : base(false)
		{
			if (string.IsNullOrEmpty(metricTypeName) || string.IsNullOrEmpty(metricTypeName.Trim()))
			{
				throw new global::System.ArgumentNullException("metricTypeName");
			}
			if (string.IsNullOrEmpty(categoryName) || string.IsNullOrEmpty(categoryName.Trim()))
			{
				throw new global::System.ArgumentNullException("categoryName");
			}
			if (string.IsNullOrEmpty(counterName) || string.IsNullOrEmpty(counterName.Trim()))
			{
				throw new global::System.ArgumentNullException("counterName");
			}
			this.MetricTypeName = metricTypeName.Trim();
			this.CategoryName = categoryName.Trim();
			this.CounterName = counterName.Trim();
			this.SampleType = sampleType;
			this.Name = global::Gibraltar.Monitor.MetricDefinition.GetKey(metricTypeName, categoryName, counterName);
			this.m_Caption = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "{0} - {1}", new object[]
			{
				categoryName,
				counterName
			});
			this.Interval = global::Loupe.Extensibility.Data.MetricSampleInterval.Minute;
			this.Persisted = false;
			this.IsLive = true;
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0005CF40 File Offset: 0x0005B140
		public MetricDefinitionPacket(global::Gibraltar.Monitor.Session session) : base(false)
		{
			if (session == null)
			{
				throw new global::System.ArgumentNullException("session");
			}
			this.m_Session = session;
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x0005CF68 File Offset: 0x0005B168
		// (set) Token: 0x06001A9F RID: 6815 RVA: 0x0005CF70 File Offset: 0x0005B170
		public string Name
		{
			get
			{
				return this.m_Name;
			}
			private set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0005CF7C File Offset: 0x0005B17C
		// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x0005CFA0 File Offset: 0x0005B1A0
		public string Caption
		{
			get
			{
				if (string.IsNullOrEmpty(this.m_Caption))
				{
					this.Caption = this.Name;
				}
				return this.m_Caption;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					this.m_Caption = value;
					return;
				}
				this.m_Caption = value.Trim();
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x0005CFC4 File Offset: 0x0005B1C4
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x0005CFCC File Offset: 0x0005B1CC
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					this.m_Description = value;
					return;
				}
				this.m_Description = value.Trim();
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x0005CFF0 File Offset: 0x0005B1F0
		// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x0005CFF8 File Offset: 0x0005B1F8
		public global::Loupe.Extensibility.Data.MetricSampleInterval Interval
		{
			get
			{
				return this.m_Interval;
			}
			set
			{
				this.m_Interval = value;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x0005D004 File Offset: 0x0005B204
		// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x0005D00C File Offset: 0x0005B20C
		public string MetricTypeName
		{
			get
			{
				return this.m_MetricTypeName;
			}
			private set
			{
				this.m_MetricTypeName = value;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x0005D018 File Offset: 0x0005B218
		// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x0005D020 File Offset: 0x0005B220
		public string CategoryName
		{
			get
			{
				return this.m_CategoryName;
			}
			private set
			{
				this.m_CategoryName = value;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x0005D02C File Offset: 0x0005B22C
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x0005D034 File Offset: 0x0005B234
		public string CounterName
		{
			get
			{
				return this.m_CounterName;
			}
			private set
			{
				this.m_CounterName = value;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x0005D040 File Offset: 0x0005B240
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x0005D048 File Offset: 0x0005B248
		public bool Persisted
		{
			get
			{
				return this.m_Persisted;
			}
			private set
			{
				this.m_Persisted = value;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x0005D054 File Offset: 0x0005B254
		// (set) Token: 0x06001AAF RID: 6831 RVA: 0x0005D05C File Offset: 0x0005B25C
		public bool IsReadOnly
		{
			get
			{
				return this.m_ReadOnly;
			}
			internal set
			{
				if (value)
				{
					this.m_ReadOnly = true;
				}
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0005D06C File Offset: 0x0005B26C
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x0005D074 File Offset: 0x0005B274
		public bool IsLive
		{
			get
			{
				return this.m_IsLive;
			}
			private set
			{
				this.m_IsLive = value;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x0005D080 File Offset: 0x0005B280
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x0005D088 File Offset: 0x0005B288
		public global::Loupe.Extensibility.Data.SampleType SampleType
		{
			get
			{
				return this.m_SampleType;
			}
			private set
			{
				this.m_SampleType = value;
			}
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0005D094 File Offset: 0x0005B294
		public int CompareTo(global::Gibraltar.Monitor.Internal.MetricDefinitionPacket other)
		{
			if (base.ID == other.ID)
			{
				return 0;
			}
			return string.Compare(this.Name, other.Name, global::System.StringComparison.InvariantCulture);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0005D0D0 File Offset: 0x0005B2D0
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.MetricDefinitionPacket);
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0005D0E0 File Offset: 0x0005B2E0
		public bool Equals(global::Gibraltar.Monitor.Internal.MetricDefinitionPacket other)
		{
			return other != null && (this.MetricTypeName == other.MetricTypeName && this.CategoryName == other.CategoryName && this.CounterName == other.CounterName && this.SampleType == other.SampleType && this.Caption == other.Caption && this.Description == other.Description && this.Interval == other.Interval) && base.Equals(other);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0005D194 File Offset: 0x0005B394
		public override int GetHashCode()
		{
			int num = base.GetHashCode();
			if (this.m_MetricTypeName != null)
			{
				num ^= this.m_MetricTypeName.GetHashCode();
			}
			if (this.m_CategoryName != null)
			{
				num ^= this.m_CategoryName.GetHashCode();
			}
			if (this.m_CounterName != null)
			{
				num ^= this.m_CounterName.GetHashCode();
			}
			if (this.m_Caption != null)
			{
				num ^= this.m_Caption.GetHashCode();
			}
			if (this.m_Description != null)
			{
				num ^= this.m_Description.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0005D22C File Offset: 0x0005B42C
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0005D230 File Offset: 0x0005B430
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"MetricTypeName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"CategoryName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"CounterName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"SampleType",
						global::Gibraltar.Serialization.FieldType.Int32
					},
					{
						"Caption",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Description",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Interval",
						global::Gibraltar.Serialization.FieldType.Int32
					}
				}
			};
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0005D2D0 File Offset: 0x0005B4D0
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("MetricTypeName", this.m_MetricTypeName);
			packet.SetField("CategoryName", this.m_CategoryName);
			packet.SetField("CounterName", this.m_CounterName);
			packet.SetField("SampleType", (int)this.m_SampleType);
			packet.SetField("Caption", this.m_Caption);
			packet.SetField("Description", this.m_Description);
			packet.SetField("Interval", (int)this.m_Interval);
			this.Persisted = true;
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0005D36C File Offset: 0x0005B56C
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("MetricTypeName", out this.m_MetricTypeName);
				packet.GetField("CategoryName", out this.m_CategoryName);
				packet.GetField("CounterName", out this.m_CounterName);
				int sampleType;
				packet.GetField("SampleType", out sampleType);
				this.m_SampleType = (global::Loupe.Extensibility.Data.SampleType)sampleType;
				packet.GetField("Caption", out this.m_Caption);
				packet.GetField("Description", out this.m_Description);
				int interval;
				packet.GetField("Interval", out interval);
				this.m_Interval = (global::Loupe.Extensibility.Data.MetricSampleInterval)interval;
				this.Name = global::Gibraltar.Monitor.MetricDefinition.GetKey(this.MetricTypeName, this.CategoryName, this.CounterName);
				this.m_ReadOnly = true;
				this.IsLive = false;
				return;
			}
			throw new global::Gibraltar.GibraltarPacketVersionException(definition.Version);
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x0005D444 File Offset: 0x0005B644
		protected global::Gibraltar.Monitor.Session Session
		{
			get
			{
				if (this.m_Session == null)
				{
					throw new global::System.InvalidOperationException("There is no session object available, it is only valid during rehydration.");
				}
				return this.m_Session;
			}
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0005D468 File Offset: 0x0005B668
		global::Gibraltar.Monitor.MetricDefinition global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricDefinition, global::Gibraltar.Monitor.MetricDefinitionCollection>.GetDataObject(global::Gibraltar.Monitor.MetricDefinitionCollection optionalParent)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x040009AD RID: 2477
		private const global::Loupe.Extensibility.Data.MetricSampleInterval DefaultInterval = global::Loupe.Extensibility.Data.MetricSampleInterval.Minute;

		// Token: 0x040009AE RID: 2478
		private string m_Name;

		// Token: 0x040009AF RID: 2479
		private global::Loupe.Extensibility.Data.MetricSampleInterval m_Interval;

		// Token: 0x040009B0 RID: 2480
		private string m_MetricTypeName;

		// Token: 0x040009B1 RID: 2481
		private string m_CategoryName;

		// Token: 0x040009B2 RID: 2482
		private string m_CounterName;

		// Token: 0x040009B3 RID: 2483
		private bool m_Persisted;

		// Token: 0x040009B4 RID: 2484
		private bool m_IsLive;

		// Token: 0x040009B5 RID: 2485
		private global::Loupe.Extensibility.Data.SampleType m_SampleType;

		// Token: 0x040009B6 RID: 2486
		private string m_Caption;

		// Token: 0x040009B7 RID: 2487
		private string m_Description;

		// Token: 0x040009B8 RID: 2488
		private global::Gibraltar.Monitor.Session m_Session;

		// Token: 0x040009B9 RID: 2489
		private bool m_ReadOnly;

		// Token: 0x040009BA RID: 2490
		private const int SerializationVersion = 1;
	}
}
