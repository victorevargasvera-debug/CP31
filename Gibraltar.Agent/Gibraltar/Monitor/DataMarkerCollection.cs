using System;
using System.Collections;
using System.Collections.Generic;

namespace Gibraltar.Monitor
{
	// Token: 0x0200018B RID: 395
	[global::System.Serializable]
	internal class DataMarkerCollection : global::System.Collections.Generic.Dictionary<global::Gibraltar.Monitor.Marker, global::Gibraltar.Monitor.DataMarker>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.DataMarker>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600108F RID: 4239 RVA: 0x0002E02C File Offset: 0x0002C22C
		public DataMarkerCollection(global::Gibraltar.Monitor.Analysis analysis)
		{
			this.m_Analysis = analysis;
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0002E03C File Offset: 0x0002C23C
		global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.DataMarker> global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.DataMarker>.GetEnumerator()
		{
			return base.Values.GetEnumerator();
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0002E050 File Offset: 0x0002C250
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return base.Values.GetEnumerator();
		}

		// Token: 0x0400058C RID: 1420
		private readonly global::Gibraltar.Monitor.Analysis m_Analysis;
	}
}
