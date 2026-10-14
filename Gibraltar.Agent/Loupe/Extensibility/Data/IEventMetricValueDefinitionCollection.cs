using System;
using System.Collections;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000067 RID: 103
	internal interface IEventMetricValueDefinitionCollection : global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IEventMetricValueDefinition>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IEventMetricValueDefinition>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IEventMetricValueDefinition>, global::System.Collections.IEnumerable
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600050F RID: 1295
		global::Loupe.Extensibility.Data.IEventMetricDefinition Definition { get; }

		// Token: 0x06000510 RID: 1296
		bool ContainsKey(string name);

		// Token: 0x06000511 RID: 1297
		bool TryGetValue(string name, out global::Loupe.Extensibility.Data.IEventMetricValueDefinition value);

		// Token: 0x17000204 RID: 516
		global::Loupe.Extensibility.Data.IEventMetricValueDefinition this[string name]
		{
			get;
		}

		// Token: 0x06000513 RID: 1299
		int IndexOf(string name);
	}
}
