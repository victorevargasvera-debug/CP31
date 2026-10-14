using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000134 RID: 308
	[global::System.Runtime.Serialization.DataContract]
	public class StorageBucketCreatedOrUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0000C012 File Offset: 0x0000A212
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x0000C01A File Offset: 0x0000A21A
		[global::System.Runtime.Serialization.DataMember(Name = "bucket", IsRequired = true)]
		public global::CefSharp.DevTools.Storage.StorageBucketInfo Bucket { get; private set; }
	}
}
