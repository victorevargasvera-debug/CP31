using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002D7 RID: 727
	[global::System.Runtime.Serialization.DataContract]
	public class PerformSearchResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x00017DF5 File Offset: 0x00015FF5
		// (set) Token: 0x0600162A RID: 5674 RVA: 0x00017DFD File Offset: 0x00015FFD
		[global::System.Runtime.Serialization.DataMember]
		internal string searchId { get; set; }

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x00017E06 File Offset: 0x00016006
		public string SearchId
		{
			get
			{
				return this.searchId;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00017E0E File Offset: 0x0001600E
		// (set) Token: 0x0600162D RID: 5677 RVA: 0x00017E16 File Offset: 0x00016016
		[global::System.Runtime.Serialization.DataMember]
		internal int resultCount { get; set; }

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x00017E1F File Offset: 0x0001601F
		public int ResultCount
		{
			get
			{
				return this.resultCount;
			}
		}
	}
}
