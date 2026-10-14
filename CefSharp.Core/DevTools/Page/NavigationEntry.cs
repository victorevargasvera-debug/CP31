using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000177 RID: 375
	[global::System.Runtime.Serialization.DataContract]
	public class NavigationEntry : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0000DC86 File Offset: 0x0000BE86
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x0000DC8E File Offset: 0x0000BE8E
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public int Id { get; set; }

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0000DC97 File Offset: 0x0000BE97
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x0000DC9F File Offset: 0x0000BE9F
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0000DCA8 File Offset: 0x0000BEA8
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		[global::System.Runtime.Serialization.DataMember(Name = "userTypedURL", IsRequired = true)]
		public string UserTypedURL { get; set; }

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0000DCB9 File Offset: 0x0000BEB9
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x0000DCC1 File Offset: 0x0000BEC1
		[global::System.Runtime.Serialization.DataMember(Name = "title", IsRequired = true)]
		public string Title { get; set; }

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0000DCCA File Offset: 0x0000BECA
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x0000DCE6 File Offset: 0x0000BEE6
		public global::CefSharp.DevTools.Page.TransitionType TransitionType
		{
			get
			{
				return (global::CefSharp.DevTools.Page.TransitionType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.TransitionType), this.transitionType);
			}
			set
			{
				this.transitionType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0000DCF9 File Offset: 0x0000BEF9
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x0000DD01 File Offset: 0x0000BF01
		[global::System.Runtime.Serialization.DataMember(Name = "transitionType", IsRequired = true)]
		internal string transitionType { get; set; }
	}
}
