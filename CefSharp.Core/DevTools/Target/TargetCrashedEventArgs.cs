using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x02000107 RID: 263
	[global::System.Runtime.Serialization.DataContract]
	public class TargetCrashedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x0000AEAD File Offset: 0x000090AD
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x0000AEB5 File Offset: 0x000090B5
		[global::System.Runtime.Serialization.DataMember(Name = "targetId", IsRequired = true)]
		public string TargetId { get; private set; }

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x0000AEBE File Offset: 0x000090BE
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x0000AEC6 File Offset: 0x000090C6
		[global::System.Runtime.Serialization.DataMember(Name = "status", IsRequired = true)]
		public string Status { get; private set; }

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x0000AECF File Offset: 0x000090CF
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x0000AED7 File Offset: 0x000090D7
		[global::System.Runtime.Serialization.DataMember(Name = "errorCode", IsRequired = true)]
		public int ErrorCode { get; private set; }
	}
}
