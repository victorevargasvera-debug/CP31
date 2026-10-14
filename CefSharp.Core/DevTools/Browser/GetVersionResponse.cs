using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x0200033A RID: 826
	[global::System.Runtime.Serialization.DataContract]
	public class GetVersionResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x0001AF78 File Offset: 0x00019178
		// (set) Token: 0x06001928 RID: 6440 RVA: 0x0001AF80 File Offset: 0x00019180
		[global::System.Runtime.Serialization.DataMember]
		internal string protocolVersion { get; set; }

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x0001AF89 File Offset: 0x00019189
		public string ProtocolVersion
		{
			get
			{
				return this.protocolVersion;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0001AF91 File Offset: 0x00019191
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x0001AF99 File Offset: 0x00019199
		[global::System.Runtime.Serialization.DataMember]
		internal string product { get; set; }

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0001AFA2 File Offset: 0x000191A2
		public string Product
		{
			get
			{
				return this.product;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x0001AFAA File Offset: 0x000191AA
		// (set) Token: 0x0600192E RID: 6446 RVA: 0x0001AFB2 File Offset: 0x000191B2
		[global::System.Runtime.Serialization.DataMember]
		internal string revision { get; set; }

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x0001AFBB File Offset: 0x000191BB
		public string Revision
		{
			get
			{
				return this.revision;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x0001AFC3 File Offset: 0x000191C3
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x0001AFCB File Offset: 0x000191CB
		[global::System.Runtime.Serialization.DataMember]
		internal string userAgent { get; set; }

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x0001AFD4 File Offset: 0x000191D4
		public string UserAgent
		{
			get
			{
				return this.userAgent;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x0001AFDC File Offset: 0x000191DC
		// (set) Token: 0x06001934 RID: 6452 RVA: 0x0001AFE4 File Offset: 0x000191E4
		[global::System.Runtime.Serialization.DataMember]
		internal string jsVersion { get; set; }

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x0001AFED File Offset: 0x000191ED
		public string JsVersion
		{
			get
			{
				return this.jsVersion;
			}
		}
	}
}
