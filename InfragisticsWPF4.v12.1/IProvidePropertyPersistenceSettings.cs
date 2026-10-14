using System;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x020000C5 RID: 197
	public interface IProvidePropertyPersistenceSettings
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600073D RID: 1853
		global::System.Collections.Generic.List<string> PropertiesToIgnore { get; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600073E RID: 1854
		global::System.Collections.Generic.List<string> PriorityProperties { get; }

		// Token: 0x0600073F RID: 1855
		void FinishedLoadingPersistence();
	}
}
