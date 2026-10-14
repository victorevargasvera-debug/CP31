using System;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000083 RID: 131
	internal interface IComputer
	{
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000611 RID: 1553
		global::System.Guid Id { get; }

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000612 RID: 1554
		global::System.Uri Uri { get; }

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000613 RID: 1555
		string Caption { get; }

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000614 RID: 1556
		string DisplayCaption { get; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000615 RID: 1557
		string FullHostName { get; }

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000616 RID: 1558
		global::System.DateTimeOffset LastContactTimestamp { get; }

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000617 RID: 1559
		global::Loupe.Extensibility.Data.IEnvironment Environment { get; }

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000618 RID: 1560
		global::Loupe.Extensibility.Data.IPromotionLevel PromotionLevel { get; }

		// Token: 0x06000619 RID: 1561
		global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.ISessionSummary> GetSessions();
	}
}
