using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000203 RID: 515
	[global::System.Runtime.Serialization.DataContract]
	public class RequestPattern : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00011976 File Offset: 0x0000FB76
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x0001197E File Offset: 0x0000FB7E
		[global::System.Runtime.Serialization.DataMember(Name = "urlPattern", IsRequired = false)]
		public string UrlPattern { get; set; }

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x00011987 File Offset: 0x0000FB87
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x000119A3 File Offset: 0x0000FBA3
		public global::CefSharp.DevTools.Network.ResourceType? ResourceType
		{
			get
			{
				return (global::CefSharp.DevTools.Network.ResourceType?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.ResourceType?), this.resourceType);
			}
			set
			{
				this.resourceType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x000119B6 File Offset: 0x0000FBB6
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x000119BE File Offset: 0x0000FBBE
		[global::System.Runtime.Serialization.DataMember(Name = "resourceType", IsRequired = false)]
		internal string resourceType { get; set; }

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x000119C7 File Offset: 0x0000FBC7
		// (set) Token: 0x06000FCC RID: 4044 RVA: 0x000119E3 File Offset: 0x0000FBE3
		public global::CefSharp.DevTools.Network.InterceptionStage? InterceptionStage
		{
			get
			{
				return (global::CefSharp.DevTools.Network.InterceptionStage?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.InterceptionStage?), this.interceptionStage);
			}
			set
			{
				this.interceptionStage = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x000119F6 File Offset: 0x0000FBF6
		// (set) Token: 0x06000FCE RID: 4046 RVA: 0x000119FE File Offset: 0x0000FBFE
		[global::System.Runtime.Serialization.DataMember(Name = "interceptionStage", IsRequired = false)]
		internal string interceptionStage { get; set; }
	}
}
