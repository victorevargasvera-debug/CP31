using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000033 RID: 51
	[global::System.Runtime.Serialization.DataContract]
	public class WebDriverValue : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600023E RID: 574 RVA: 0x000051A8 File Offset: 0x000033A8
		// (set) Token: 0x0600023F RID: 575 RVA: 0x000051C4 File Offset: 0x000033C4
		public global::CefSharp.DevTools.Runtime.WebDriverValueType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Runtime.WebDriverValueType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Runtime.WebDriverValueType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000240 RID: 576 RVA: 0x000051D7 File Offset: 0x000033D7
		// (set) Token: 0x06000241 RID: 577 RVA: 0x000051DF File Offset: 0x000033DF
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000242 RID: 578 RVA: 0x000051E8 File Offset: 0x000033E8
		// (set) Token: 0x06000243 RID: 579 RVA: 0x000051F0 File Offset: 0x000033F0
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = false)]
		public object Value { get; set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000244 RID: 580 RVA: 0x000051F9 File Offset: 0x000033F9
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00005201 File Offset: 0x00003401
		[global::System.Runtime.Serialization.DataMember(Name = "objectId", IsRequired = false)]
		public string ObjectId { get; set; }
	}
}
