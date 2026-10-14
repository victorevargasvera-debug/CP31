using System;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x020001CE RID: 462
	internal abstract class SampledMetricDefinition : global::Gibraltar.Monitor.MetricDefinition
	{
		// Token: 0x060015FA RID: 5626 RVA: 0x000425F0 File Offset: 0x000407F0
		internal SampledMetricDefinition(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, global::Gibraltar.Monitor.Internal.SampledMetricDefinitionPacket packet) : base(definitions, packet)
		{
			this.SetReadOnly();
			definitions.Add(this);
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x00042608 File Offset: 0x00040808
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x0004261C File Offset: 0x0004081C
		public string UnitCaption
		{
			get
			{
				return ((global::Gibraltar.Monitor.Internal.SampledMetricDefinitionPacket)base.Packet).UnitCaption;
			}
			set
			{
				((global::Gibraltar.Monitor.Internal.SampledMetricDefinitionPacket)base.Packet).UnitCaption = value;
			}
		}
	}
}
