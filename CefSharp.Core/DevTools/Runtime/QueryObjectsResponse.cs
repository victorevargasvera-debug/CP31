using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000058 RID: 88
	[global::System.Runtime.Serialization.DataContract]
	public class QueryObjectsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00005BBC File Offset: 0x00003DBC
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00005BC4 File Offset: 0x00003DC4
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.RemoteObject objects { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00005BCD File Offset: 0x00003DCD
		public global::CefSharp.DevTools.Runtime.RemoteObject Objects
		{
			get
			{
				return this.objects;
			}
		}
	}
}
