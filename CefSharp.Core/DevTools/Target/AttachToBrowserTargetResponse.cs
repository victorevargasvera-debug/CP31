using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x0200010A RID: 266
	[global::System.Runtime.Serialization.DataContract]
	public class AttachToBrowserTargetResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x0000AF22 File Offset: 0x00009122
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x0000AF2A File Offset: 0x0000912A
		[global::System.Runtime.Serialization.DataMember]
		internal string sessionId { get; set; }

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x0000AF33 File Offset: 0x00009133
		public string SessionId
		{
			get
			{
				return this.sessionId;
			}
		}
	}
}
