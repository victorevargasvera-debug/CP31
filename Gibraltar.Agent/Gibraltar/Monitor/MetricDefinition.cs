using System;
using System.Diagnostics;
using System.Globalization;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001BD RID: 445
	[global::System.Diagnostics.DebuggerDisplay("Name: {Name}, Id: {Id}, Caption: {Caption}")]
	internal class MetricDefinition : global::Loupe.Extensibility.Data.IMetricDefinition, global::System.IComparable<global::Loupe.Extensibility.Data.IMetricDefinition>, global::System.IEquatable<global::Loupe.Extensibility.Data.IMetricDefinition>, global::Gibraltar.Monitor.Internal.IDisplayable
	{
		// Token: 0x06001476 RID: 5238 RVA: 0x0003C7CC File Offset: 0x0003A9CC
		public MetricDefinition(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, string metricType, string categoryName, string counterName, global::Loupe.Extensibility.Data.SampleType sampleType) : this(definitions, new global::Gibraltar.Monitor.Internal.MetricDefinitionPacket(metricType, categoryName, counterName, sampleType))
		{
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0003C7E0 File Offset: 0x0003A9E0
		internal MetricDefinition(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, global::Gibraltar.Monitor.Internal.MetricDefinitionPacket packet)
		{
			if (definitions == null)
			{
				throw new global::System.ArgumentNullException("definitions");
			}
			if (packet == null)
			{
				throw new global::System.ArgumentNullException("packet");
			}
			this.m_Definitions = definitions;
			this.m_Packet = packet;
			this.m_Metrics = this.OnMetricDictionaryCreate();
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x0003C840 File Offset: 0x0003AA40
		public global::System.Guid Id
		{
			get
			{
				return this.m_Packet.ID;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0003C850 File Offset: 0x0003AA50
		public string Name
		{
			get
			{
				return this.m_Packet.Name;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x0003C860 File Offset: 0x0003AA60
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x0003C870 File Offset: 0x0003AA70
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

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x0003C880 File Offset: 0x0003AA80
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x0003C890 File Offset: 0x0003AA90
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

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x0003C8A0 File Offset: 0x0003AAA0
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x0003C8B0 File Offset: 0x0003AAB0
		public global::Loupe.Extensibility.Data.MetricSampleInterval Interval
		{
			get
			{
				return this.m_Packet.Interval;
			}
			protected set
			{
				this.m_Packet.Interval = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0003C8C0 File Offset: 0x0003AAC0
		public string MetricTypeName
		{
			get
			{
				return this.m_Packet.MetricTypeName;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0003C8D0 File Offset: 0x0003AAD0
		public global::Loupe.Extensibility.Data.IMetricDefinitionCollection Definitions
		{
			get
			{
				return this.m_Definitions;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0003C8D8 File Offset: 0x0003AAD8
		public global::Loupe.Extensibility.Data.IMetricCollection Metrics
		{
			get
			{
				return this.m_Metrics;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0003C8E0 File Offset: 0x0003AAE0
		public string CategoryName
		{
			get
			{
				return this.m_Packet.CategoryName;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x0003C8F0 File Offset: 0x0003AAF0
		public string[] CategoryNames
		{
			get
			{
				if (this.m_CategoryNames == null)
				{
					this.m_CategoryNames = global::Gibraltar.Monitor.TextParse.CategoryName(this.CategoryName);
				}
				return this.m_CategoryNames;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0003C914 File Offset: 0x0003AB14
		public string CounterName
		{
			get
			{
				return this.m_Packet.CounterName;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0003C924 File Offset: 0x0003AB24
		public global::Loupe.Extensibility.Data.SampleType SampleType
		{
			get
			{
				return this.m_Packet.SampleType;
			}
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0003C934 File Offset: 0x0003AB34
		public int CompareTo(global::Loupe.Extensibility.Data.IMetricDefinition other)
		{
			return this.m_Packet.CompareTo(((global::Gibraltar.Monitor.MetricDefinition)other).Packet);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0003C94C File Offset: 0x0003AB4C
		public bool Equals(global::Loupe.Extensibility.Data.IMetricDefinition other)
		{
			return other != null && this.Id == other.Id;
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0003C968 File Offset: 0x0003AB68
		public override bool Equals(object obj)
		{
			global::Gibraltar.Monitor.MetricDefinition other = obj as global::Gibraltar.Monitor.MetricDefinition;
			return this.Equals(other);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0003C988 File Offset: 0x0003AB88
		public override int GetHashCode()
		{
			return this.Id.GetHashCode();
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x0003C9B0 File Offset: 0x0003ABB0
		public static bool operator ==(global::Gibraltar.Monitor.MetricDefinition left, global::Gibraltar.Monitor.MetricDefinition right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x0003C9C4 File Offset: 0x0003ABC4
		public static bool operator !=(global::Gibraltar.Monitor.MetricDefinition left, global::Gibraltar.Monitor.MetricDefinition right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0003C9DC File Offset: 0x0003ABDC
		public static bool operator <(global::Gibraltar.Monitor.MetricDefinition left, global::Gibraltar.Monitor.MetricDefinition right)
		{
			return left.CompareTo(right) < 0;
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0003C9E8 File Offset: 0x0003ABE8
		public static bool operator >(global::Gibraltar.Monitor.MetricDefinition left, global::Gibraltar.Monitor.MetricDefinition right)
		{
			return left.CompareTo(right) > 0;
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x0003C9F4 File Offset: 0x0003ABF4
		public bool IsLive
		{
			get
			{
				return this.m_Packet.IsLive;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0003CA04 File Offset: 0x0003AC04
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x0003CA14 File Offset: 0x0003AC14
		public bool IsReadOnly
		{
			get
			{
				return this.m_Packet.IsReadOnly;
			}
			internal set
			{
				this.m_Packet.IsReadOnly = value;
			}
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0003CA24 File Offset: 0x0003AC24
		public virtual void SetReadOnly()
		{
			this.IsReadOnly = true;
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x0003CA30 File Offset: 0x0003AC30
		public object Lock
		{
			get
			{
				return this.m_Lock;
			}
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0003CA38 File Offset: 0x0003AC38
		protected virtual global::Gibraltar.Monitor.MetricCollection OnMetricDictionaryCreate()
		{
			return new global::Gibraltar.Monitor.MetricCollection(this);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0003CA40 File Offset: 0x0003AC40
		public static string GetKey(global::Loupe.Extensibility.Data.IMetric metric)
		{
			if (metric == null)
			{
				throw new global::System.ArgumentNullException("metric");
			}
			return global::Gibraltar.Monitor.MetricDefinition.GetKey(metric.MetricTypeName, metric.CategoryName, metric.CounterName);
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0003CA7C File Offset: 0x0003AC7C
		public static string GetKey(global::Gibraltar.Monitor.MetricDefinition metricDefinition)
		{
			if (metricDefinition == null)
			{
				throw new global::System.ArgumentNullException("metricDefinition");
			}
			return global::Gibraltar.Monitor.MetricDefinition.GetKey(metricDefinition.MetricTypeName, metricDefinition.CategoryName, metricDefinition.CounterName);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0003CABC File Offset: 0x0003ACBC
		public static string GetKey(global::Gibraltar.Monitor.MetricDefinition metricDefinition, string instanceName)
		{
			if (metricDefinition == null)
			{
				throw new global::System.ArgumentNullException("metricDefinition");
			}
			return global::Gibraltar.Monitor.MetricDefinition.GetKey(metricDefinition.MetricTypeName, metricDefinition.CategoryName, metricDefinition.CounterName, instanceName);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0003CAFC File Offset: 0x0003ACFC
		public static string GetKey(string metricTypeName, string categoryName, string counterName)
		{
			return global::Gibraltar.Monitor.MetricDefinition.GetKey(metricTypeName, categoryName, counterName, null);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0003CB08 File Offset: 0x0003AD08
		public static string GetKey(string metricTypeName, string categoryName, string counterName, string instanceName)
		{
			if (string.IsNullOrEmpty(metricTypeName))
			{
				throw new global::System.ArgumentNullException("metricTypeName");
			}
			if (string.IsNullOrEmpty(categoryName))
			{
				throw new global::System.ArgumentNullException("categoryName");
			}
			if (string.IsNullOrEmpty(counterName))
			{
				throw new global::System.ArgumentNullException("counterName");
			}
			string result;
			if (string.IsNullOrEmpty(instanceName) || string.IsNullOrEmpty(instanceName.Trim()))
			{
				result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}~{1}~{2}", new object[]
				{
					metricTypeName.Trim(),
					categoryName.Trim(),
					counterName.Trim()
				});
			}
			else
			{
				result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}~{1}~{2}~{3}", new object[]
				{
					metricTypeName.Trim(),
					categoryName.Trim(),
					counterName.Trim(),
					instanceName.Trim()
				});
			}
			return result;
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0003CBE8 File Offset: 0x0003ADE8
		internal static string NormalizeKey(global::Gibraltar.Monitor.MetricDefinition metricDefinition, string metricKey)
		{
			bool flag = false;
			string text;
			if (metricKey == null)
			{
				flag = true;
				text = null;
			}
			else
			{
				text = metricKey.Trim();
				if (string.IsNullOrEmpty(text))
				{
					flag = true;
				}
				else if (text.Length < metricDefinition.Name.Length)
				{
					flag = true;
				}
				else if (!text.StartsWith(metricDefinition.Name, global::System.StringComparison.Ordinal))
				{
					flag = true;
				}
			}
			string result;
			if (flag)
			{
				result = global::Gibraltar.Monitor.MetricDefinition.GetKey(metricDefinition, text);
			}
			else
			{
				result = text;
			}
			return result;
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0003CC6C File Offset: 0x0003AE6C
		internal global::Gibraltar.Monitor.Internal.MetricDefinitionPacket Packet
		{
			get
			{
				return this.m_Packet;
			}
		}

		// Token: 0x040006B0 RID: 1712
		private readonly global::Gibraltar.Monitor.MetricDefinitionCollection m_Definitions;

		// Token: 0x040006B1 RID: 1713
		private readonly global::Gibraltar.Monitor.Internal.MetricDefinitionPacket m_Packet;

		// Token: 0x040006B2 RID: 1714
		private readonly global::Gibraltar.Monitor.MetricCollection m_Metrics;

		// Token: 0x040006B3 RID: 1715
		private readonly object m_Lock = new object();

		// Token: 0x040006B4 RID: 1716
		private string[] m_CategoryNames;
	}
}
