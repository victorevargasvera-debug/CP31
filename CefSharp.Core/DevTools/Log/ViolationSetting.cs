using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Log
{
	// Token: 0x02000251 RID: 593
	[global::System.Runtime.Serialization.DataContract]
	public class ViolationSetting : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x00013F20 File Offset: 0x00012120
		// (set) Token: 0x0600125D RID: 4701 RVA: 0x00013F3C File Offset: 0x0001213C
		public global::CefSharp.DevTools.Log.ViolationSettingName Name
		{
			get
			{
				return (global::CefSharp.DevTools.Log.ViolationSettingName)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Log.ViolationSettingName), this.name);
			}
			set
			{
				this.name = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x00013F4F File Offset: 0x0001214F
		// (set) Token: 0x0600125F RID: 4703 RVA: 0x00013F57 File Offset: 0x00012157
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		internal string name { get; set; }

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x00013F60 File Offset: 0x00012160
		// (set) Token: 0x06001261 RID: 4705 RVA: 0x00013F68 File Offset: 0x00012168
		[global::System.Runtime.Serialization.DataMember(Name = "threshold", IsRequired = true)]
		public double Threshold { get; set; }
	}
}
