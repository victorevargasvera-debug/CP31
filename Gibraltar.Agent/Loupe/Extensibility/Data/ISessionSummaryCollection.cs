using System;
using System.Collections;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000079 RID: 121
	internal interface ISessionSummaryCollection : global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ISessionSummary>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.ISessionSummary>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.ISessionSummary>, global::System.Collections.IEnumerable
	{
		// Token: 0x170002C1 RID: 705
		global::Loupe.Extensibility.Data.ISessionSummary this[global::System.Guid key]
		{
			get;
		}

		// Token: 0x060005EA RID: 1514
		bool Contains(global::System.Guid key);

		// Token: 0x060005EB RID: 1515
		global::Loupe.Extensibility.Data.ISessionSummary Find(global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> match);

		// Token: 0x060005EC RID: 1516
		global::Loupe.Extensibility.Data.ISessionSummaryCollection FindAll(global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> match);

		// Token: 0x060005ED RID: 1517
		bool Remove(global::System.Guid key);

		// Token: 0x060005EE RID: 1518
		bool TryGetValue(global::System.Guid key, out global::Loupe.Extensibility.Data.ISessionSummary item);
	}
}
