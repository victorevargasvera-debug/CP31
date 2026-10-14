using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200023F RID: 575
	[global::System.Runtime.Serialization.DataContract]
	public class GetSecurityIsolationStatusResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00012B8E File Offset: 0x00010D8E
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x00012B96 File Offset: 0x00010D96
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Network.SecurityIsolationStatus status { get; set; }

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00012B9F File Offset: 0x00010D9F
		public global::CefSharp.DevTools.Network.SecurityIsolationStatus Status
		{
			get
			{
				return this.status;
			}
		}
	}
}
