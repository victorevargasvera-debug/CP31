using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000135 RID: 309
	[global::System.Runtime.Serialization.DataContract]
	public class StorageBucketDeletedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x0000C02B File Offset: 0x0000A22B
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x0000C033 File Offset: 0x0000A233
		[global::System.Runtime.Serialization.DataMember(Name = "bucketId", IsRequired = true)]
		public string BucketId { get; private set; }
	}
}
