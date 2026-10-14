using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200023E RID: 574
	[global::System.Runtime.Serialization.DataContract]
	public class SetCookieResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x00012B6D File Offset: 0x00010D6D
		// (set) Token: 0x060011A0 RID: 4512 RVA: 0x00012B75 File Offset: 0x00010D75
		[global::System.Runtime.Serialization.DataMember]
		internal bool success { get; set; }

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00012B7E File Offset: 0x00010D7E
		public bool Success
		{
			get
			{
				return this.success;
			}
		}
	}
}
