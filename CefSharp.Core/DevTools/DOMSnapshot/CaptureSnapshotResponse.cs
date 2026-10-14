using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x020002AA RID: 682
	[global::System.Runtime.Serialization.DataContract]
	public class CaptureSnapshotResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x000170E0 File Offset: 0x000152E0
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x000170E8 File Offset: 0x000152E8
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOMSnapshot.DocumentSnapshot> documents { get; set; }

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x000170F1 File Offset: 0x000152F1
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOMSnapshot.DocumentSnapshot> Documents
		{
			get
			{
				return this.documents;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x000170F9 File Offset: 0x000152F9
		// (set) Token: 0x06001508 RID: 5384 RVA: 0x00017101 File Offset: 0x00015301
		[global::System.Runtime.Serialization.DataMember]
		internal string[] strings { get; set; }

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x0001710A File Offset: 0x0001530A
		public string[] Strings
		{
			get
			{
				return this.strings;
			}
		}
	}
}
