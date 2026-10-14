using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000136 RID: 310
	[global::System.Runtime.Serialization.DataContract]
	public class GetStorageKeyForFrameResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0000C044 File Offset: 0x0000A244
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x0000C04C File Offset: 0x0000A24C
		[global::System.Runtime.Serialization.DataMember]
		internal string storageKey { get; set; }

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0000C055 File Offset: 0x0000A255
		public string StorageKey
		{
			get
			{
				return this.storageKey;
			}
		}
	}
}
