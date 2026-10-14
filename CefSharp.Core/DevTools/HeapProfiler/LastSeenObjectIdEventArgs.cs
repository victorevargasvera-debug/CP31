using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.HeapProfiler
{
	// Token: 0x0200006F RID: 111
	[global::System.Runtime.Serialization.DataContract]
	public class LastSeenObjectIdEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00006CF3 File Offset: 0x00004EF3
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00006CFB File Offset: 0x00004EFB
		[global::System.Runtime.Serialization.DataMember(Name = "lastSeenObjectId", IsRequired = true)]
		public int LastSeenObjectId { get; private set; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00006D04 File Offset: 0x00004F04
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00006D0C File Offset: 0x00004F0C
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }
	}
}
