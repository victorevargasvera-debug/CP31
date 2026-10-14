using System;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x0200018A RID: 394
	internal class DataMarker : global::Gibraltar.Monitor.Internal.IDisplayable
	{
		// Token: 0x0600108B RID: 4235 RVA: 0x0002DFC8 File Offset: 0x0002C1C8
		public DataMarker(global::Gibraltar.Monitor.Analysis analysis, global::Gibraltar.Monitor.Marker Marker)
		{
			this.m_Analysis = analysis;
			this.m_Marker = this.m_Analysis.Markers[Marker.Id];
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x0002E004 File Offset: 0x0002C204
		public global::Gibraltar.Monitor.Marker Marker
		{
			get
			{
				return this.m_Marker;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x0002E00C File Offset: 0x0002C20C
		public string Caption
		{
			get
			{
				return this.m_Marker.Caption;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x0002E01C File Offset: 0x0002C21C
		public string Description
		{
			get
			{
				return this.m_Marker.Description;
			}
		}

		// Token: 0x0400058A RID: 1418
		private readonly global::Gibraltar.Monitor.Analysis m_Analysis;

		// Token: 0x0400058B RID: 1419
		private readonly global::Gibraltar.Monitor.Marker m_Marker;
	}
}
