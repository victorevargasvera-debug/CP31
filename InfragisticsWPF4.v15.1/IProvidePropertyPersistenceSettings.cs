using System;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x020000E2 RID: 226
	public interface IProvidePropertyPersistenceSettings
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600083B RID: 2107
		global::System.Collections.Generic.List<string> PropertiesToIgnore { get; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600083C RID: 2108
		global::System.Collections.Generic.List<string> PriorityProperties { get; }

		// Token: 0x0600083D RID: 2109
		void FinishedLoadingPersistence();
	}
}
