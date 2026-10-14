using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.IndexedDB
{
	// Token: 0x02000277 RID: 631
	[global::System.Runtime.Serialization.DataContract]
	public class DataEntry : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x000154AA File Offset: 0x000136AA
		// (set) Token: 0x0600134C RID: 4940 RVA: 0x000154B2 File Offset: 0x000136B2
		[global::System.Runtime.Serialization.DataMember(Name = "key", IsRequired = true)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Key { get; set; }

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x000154BB File Offset: 0x000136BB
		// (set) Token: 0x0600134E RID: 4942 RVA: 0x000154C3 File Offset: 0x000136C3
		[global::System.Runtime.Serialization.DataMember(Name = "primaryKey", IsRequired = true)]
		public global::CefSharp.DevTools.Runtime.RemoteObject PrimaryKey { get; set; }

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x000154CC File Offset: 0x000136CC
		// (set) Token: 0x06001350 RID: 4944 RVA: 0x000154D4 File Offset: 0x000136D4
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Value { get; set; }
	}
}
