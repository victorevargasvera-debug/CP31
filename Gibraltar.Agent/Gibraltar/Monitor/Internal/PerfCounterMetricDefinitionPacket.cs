using System;
using System.Diagnostics;
using System.Reflection;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x0200021C RID: 540
	internal class PerfCounterMetricDefinitionPacket : global::Gibraltar.Monitor.Internal.SampledMetricDefinitionPacket, global::Gibraltar.Serialization.IPacket, global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricDefinition, global::Gibraltar.Monitor.MetricDefinitionCollection>, global::System.IComparable<global::Gibraltar.Monitor.Internal.PerfCounterMetricDefinitionPacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.PerfCounterMetricDefinitionPacket>
	{
		// Token: 0x06001B4F RID: 6991 RVA: 0x0005F458 File Offset: 0x0005D658
		public PerfCounterMetricDefinitionPacket(global::System.Diagnostics.PerformanceCounter counter) : base(global::Gibraltar.Monitor.PerfCounterMetricDefinition.PerfCounterMetricType, counter.CategoryName, counter.CounterName)
		{
			if (counter == null)
			{
				throw new global::System.ArgumentNullException("counter", "No performance counter object was provided and one is required.");
			}
			this.CounterType = counter.CounterType;
			base.Caption = counter.CounterName;
			base.Description = counter.CounterHelp;
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0005F4BC File Offset: 0x0005D6BC
		public PerfCounterMetricDefinitionPacket(global::Gibraltar.Monitor.Session session) : base(session)
		{
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x0005F4C8 File Offset: 0x0005D6C8
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x0005F4D0 File Offset: 0x0005D6D0
		public global::System.Diagnostics.PerformanceCounterType CounterType { get; protected set; }

		// Token: 0x06001B53 RID: 6995 RVA: 0x0005F4DC File Offset: 0x0005D6DC
		public int CompareTo(global::Gibraltar.Monitor.Internal.PerfCounterMetricDefinitionPacket other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0005F4E8 File Offset: 0x0005D6E8
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.PerfCounterMetricDefinitionPacket);
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0005F4F8 File Offset: 0x0005D6F8
		public bool Equals(global::Gibraltar.Monitor.Internal.PerfCounterMetricDefinitionPacket other)
		{
			return base.Equals(other);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0005F504 File Offset: 0x0005D704
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x0005F50C File Offset: 0x0005D70C
		protected override string OnUnitCaptionGenerate()
		{
			string text = string.Empty;
			string counterName = base.CounterName;
			if (counterName.Contains("%"))
			{
				text = "%";
			}
			else if (counterName.Contains("Bytes"))
			{
				text = "Bytes";
			}
			else if (counterName.Contains("KBytes"))
			{
				text = "KBytes";
			}
			else if (counterName.Contains("MBytes"))
			{
				text = "MBytes";
			}
			else if (counterName.Contains("Time"))
			{
				text = "Time";
			}
			else if (counterName.Contains("Packets"))
			{
				text = "Count";
			}
			else if (counterName.Contains("Queue"))
			{
				text = "Count";
			}
			else if (counterName.Contains("Page"))
			{
				text = "Count";
			}
			else if (counterName.Contains("Thread"))
			{
				text = "Count";
			}
			else if (counterName.Contains("Connection"))
			{
				text = "Count";
			}
			if (counterName.EndsWith("/sec", global::System.StringComparison.OrdinalIgnoreCase))
			{
				text += "/sec";
			}
			return text;
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0005F654 File Offset: 0x0005D854
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0005F658 File Offset: 0x0005D858
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"counterType",
						global::Gibraltar.Serialization.FieldType.Int32
					}
				}
			};
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0005F690 File Offset: 0x0005D890
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("counterType", (int)this.CounterType);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0005F6A8 File Offset: 0x0005D8A8
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				int counterType;
				packet.GetField("counterType", out counterType);
				this.CounterType = (global::System.Diagnostics.PerformanceCounterType)counterType;
			}
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0005F6DC File Offset: 0x0005D8DC
		global::Gibraltar.Monitor.MetricDefinition global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricDefinition, global::Gibraltar.Monitor.MetricDefinitionCollection>.GetDataObject(global::Gibraltar.Monitor.MetricDefinitionCollection optionalParent)
		{
			return new global::Gibraltar.Monitor.PerfCounterMetricDefinition(optionalParent, this);
		}

		// Token: 0x040009E4 RID: 2532
		private const int SerializationVersion = 1;
	}
}
