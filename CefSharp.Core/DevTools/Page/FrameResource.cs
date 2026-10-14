using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Network;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000173 RID: 371
	[global::System.Runtime.Serialization.DataContract]
	public class FrameResource : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x0000DB73 File Offset: 0x0000BD73
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x0000DB7B File Offset: 0x0000BD7B
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x0000DB84 File Offset: 0x0000BD84
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x0000DBA0 File Offset: 0x0000BDA0
		public global::CefSharp.DevTools.Network.ResourceType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Network.ResourceType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.ResourceType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0000DBB3 File Offset: 0x0000BDB3
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x0000DBBB File Offset: 0x0000BDBB
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0000DBC4 File Offset: 0x0000BDC4
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x0000DBCC File Offset: 0x0000BDCC
		[global::System.Runtime.Serialization.DataMember(Name = "mimeType", IsRequired = true)]
		public string MimeType { get; set; }

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x0000DBD5 File Offset: 0x0000BDD5
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x0000DBDD File Offset: 0x0000BDDD
		[global::System.Runtime.Serialization.DataMember(Name = "lastModified", IsRequired = false)]
		public double? LastModified { get; set; }

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0000DBE6 File Offset: 0x0000BDE6
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x0000DBEE File Offset: 0x0000BDEE
		[global::System.Runtime.Serialization.DataMember(Name = "contentSize", IsRequired = false)]
		public double? ContentSize { get; set; }

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0000DBF7 File Offset: 0x0000BDF7
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x0000DBFF File Offset: 0x0000BDFF
		[global::System.Runtime.Serialization.DataMember(Name = "failed", IsRequired = false)]
		public bool? Failed { get; set; }

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0000DC08 File Offset: 0x0000BE08
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x0000DC10 File Offset: 0x0000BE10
		[global::System.Runtime.Serialization.DataMember(Name = "canceled", IsRequired = false)]
		public bool? Canceled { get; set; }
	}
}
