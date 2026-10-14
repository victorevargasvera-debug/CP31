using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools
{
	// Token: 0x02000023 RID: 35
	[global::System.Runtime.Serialization.DataContract]
	public class DevToolsDomainErrorResponse
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00004C80 File Offset: 0x00002E80
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00004C88 File Offset: 0x00002E88
		[global::System.Runtime.Serialization.IgnoreDataMember]
		public int MessageId { get; set; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00004C91 File Offset: 0x00002E91
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00004C99 File Offset: 0x00002E99
		[global::System.Runtime.Serialization.DataMember(Name = "code", IsRequired = true)]
		public int Code { get; set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00004CA2 File Offset: 0x00002EA2
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00004CAA File Offset: 0x00002EAA
		[global::System.Runtime.Serialization.DataMember(Name = "message", IsRequired = true)]
		public string Message { get; set; }
	}
}
