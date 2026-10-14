using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001AB RID: 427
	[global::System.Runtime.Serialization.DataContract]
	public class CreateIsolatedWorldResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0000E7E7 File Offset: 0x0000C9E7
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x0000E7EF File Offset: 0x0000C9EF
		[global::System.Runtime.Serialization.DataMember]
		internal int executionContextId { get; set; }

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
		public int ExecutionContextId
		{
			get
			{
				return this.executionContextId;
			}
		}
	}
}
