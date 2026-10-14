using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x02000109 RID: 265
	[global::System.Runtime.Serialization.DataContract]
	public class AttachToTargetResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x0000AF01 File Offset: 0x00009101
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x0000AF09 File Offset: 0x00009109
		[global::System.Runtime.Serialization.DataMember]
		internal string sessionId { get; set; }

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x0000AF12 File Offset: 0x00009112
		public string SessionId
		{
			get
			{
				return this.sessionId;
			}
		}
	}
}
