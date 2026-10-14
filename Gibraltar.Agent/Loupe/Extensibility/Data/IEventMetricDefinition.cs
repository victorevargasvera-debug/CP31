using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000064 RID: 100
	internal interface IEventMetricDefinition : global::Loupe.Extensibility.Data.IMetricDefinition, global::System.IComparable<global::Loupe.Extensibility.Data.IMetricDefinition>, global::System.IEquatable<global::Loupe.Extensibility.Data.IMetricDefinition>, global::System.IComparable<global::Loupe.Extensibility.Data.IEventMetricDefinition>, global::System.IEquatable<global::Loupe.Extensibility.Data.IEventMetricDefinition>
	{
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000502 RID: 1282
		global::Loupe.Extensibility.Data.IEventMetricValueDefinition DefaultValue { get; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000503 RID: 1283
		global::Loupe.Extensibility.Data.IEventMetricValueDefinitionCollection Values { get; }
	}
}
