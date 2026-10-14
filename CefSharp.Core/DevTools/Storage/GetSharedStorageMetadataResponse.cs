using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x0200013C RID: 316
	[global::System.Runtime.Serialization.DataContract]
	public class GetSharedStorageMetadataResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0000C155 File Offset: 0x0000A355
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x0000C15D File Offset: 0x0000A35D
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Storage.SharedStorageMetadata metadata { get; set; }

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x0000C166 File Offset: 0x0000A366
		public global::CefSharp.DevTools.Storage.SharedStorageMetadata Metadata
		{
			get
			{
				return this.metadata;
			}
		}
	}
}
