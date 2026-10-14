using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200022C RID: 556
	[global::System.Runtime.Serialization.DataContract]
	public class RequestWillBeSentExtraInfoEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x00012724 File Offset: 0x00010924
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x0001272C File Offset: 0x0001092C
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x00012735 File Offset: 0x00010935
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x0001273D File Offset: 0x0001093D
		[global::System.Runtime.Serialization.DataMember(Name = "associatedCookies", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Network.BlockedCookieWithReason> AssociatedCookies { get; private set; }

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x00012746 File Offset: 0x00010946
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x0001274E File Offset: 0x0001094E
		[global::System.Runtime.Serialization.DataMember(Name = "headers", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Headers Headers { get; private set; }

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x00012757 File Offset: 0x00010957
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x0001275F File Offset: 0x0001095F
		[global::System.Runtime.Serialization.DataMember(Name = "connectTiming", IsRequired = true)]
		public global::CefSharp.DevTools.Network.ConnectTiming ConnectTiming { get; private set; }

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x00012768 File Offset: 0x00010968
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x00012770 File Offset: 0x00010970
		[global::System.Runtime.Serialization.DataMember(Name = "clientSecurityState", IsRequired = false)]
		public global::CefSharp.DevTools.Network.ClientSecurityState ClientSecurityState { get; private set; }

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x00012779 File Offset: 0x00010979
		// (set) Token: 0x06001132 RID: 4402 RVA: 0x00012781 File Offset: 0x00010981
		[global::System.Runtime.Serialization.DataMember(Name = "siteHasCookieInOtherPartition", IsRequired = false)]
		public bool? SiteHasCookieInOtherPartition { get; private set; }
	}
}
