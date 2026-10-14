using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200022D RID: 557
	[global::System.Runtime.Serialization.DataContract]
	public class ResponseReceivedExtraInfoEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x00012792 File Offset: 0x00010992
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x0001279A File Offset: 0x0001099A
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x000127A3 File Offset: 0x000109A3
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x000127AB File Offset: 0x000109AB
		[global::System.Runtime.Serialization.DataMember(Name = "blockedCookies", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Network.BlockedSetCookieWithReason> BlockedCookies { get; private set; }

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x000127B4 File Offset: 0x000109B4
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x000127BC File Offset: 0x000109BC
		[global::System.Runtime.Serialization.DataMember(Name = "headers", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Headers Headers { get; private set; }

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x000127C5 File Offset: 0x000109C5
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x000127E1 File Offset: 0x000109E1
		public global::CefSharp.DevTools.Network.IPAddressSpace ResourceIPAddressSpace
		{
			get
			{
				return (global::CefSharp.DevTools.Network.IPAddressSpace)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.IPAddressSpace), this.resourceIPAddressSpace);
			}
			set
			{
				this.resourceIPAddressSpace = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x000127F4 File Offset: 0x000109F4
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x000127FC File Offset: 0x000109FC
		[global::System.Runtime.Serialization.DataMember(Name = "resourceIPAddressSpace", IsRequired = true)]
		internal string resourceIPAddressSpace { get; private set; }

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x00012805 File Offset: 0x00010A05
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x0001280D File Offset: 0x00010A0D
		[global::System.Runtime.Serialization.DataMember(Name = "statusCode", IsRequired = true)]
		public int StatusCode { get; private set; }

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x00012816 File Offset: 0x00010A16
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x0001281E File Offset: 0x00010A1E
		[global::System.Runtime.Serialization.DataMember(Name = "headersText", IsRequired = false)]
		public string HeadersText { get; private set; }

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x00012827 File Offset: 0x00010A27
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x0001282F File Offset: 0x00010A2F
		[global::System.Runtime.Serialization.DataMember(Name = "cookiePartitionKey", IsRequired = false)]
		public string CookiePartitionKey { get; private set; }

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x00012838 File Offset: 0x00010A38
		// (set) Token: 0x06001145 RID: 4421 RVA: 0x00012840 File Offset: 0x00010A40
		[global::System.Runtime.Serialization.DataMember(Name = "cookiePartitionKeyOpaque", IsRequired = false)]
		public bool? CookiePartitionKeyOpaque { get; private set; }
	}
}
