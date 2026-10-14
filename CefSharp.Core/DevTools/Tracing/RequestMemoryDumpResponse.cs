using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Tracing
{
	// Token: 0x020000F9 RID: 249
	[global::System.Runtime.Serialization.DataContract]
	public class RequestMemoryDumpResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x0000A94B File Offset: 0x00008B4B
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x0000A953 File Offset: 0x00008B53
		[global::System.Runtime.Serialization.DataMember]
		internal string dumpGuid { get; set; }

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x0000A95C File Offset: 0x00008B5C
		public string DumpGuid
		{
			get
			{
				return this.dumpGuid;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x0000A964 File Offset: 0x00008B64
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x0000A96C File Offset: 0x00008B6C
		[global::System.Runtime.Serialization.DataMember]
		internal bool success { get; set; }

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x0000A975 File Offset: 0x00008B75
		public bool Success
		{
			get
			{
				return this.success;
			}
		}
	}
}
