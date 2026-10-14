using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Security
{
	// Token: 0x0200014D RID: 333
	[global::System.Runtime.Serialization.DataContract]
	public class SafetyTipInfo : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0000CFD6 File Offset: 0x0000B1D6
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x0000CFF2 File Offset: 0x0000B1F2
		public global::CefSharp.DevTools.Security.SafetyTipStatus SafetyTipStatus
		{
			get
			{
				return (global::CefSharp.DevTools.Security.SafetyTipStatus)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Security.SafetyTipStatus), this.safetyTipStatus);
			}
			set
			{
				this.safetyTipStatus = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x0000D005 File Offset: 0x0000B205
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x0000D00D File Offset: 0x0000B20D
		[global::System.Runtime.Serialization.DataMember(Name = "safetyTipStatus", IsRequired = true)]
		internal string safetyTipStatus { get; set; }

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x0000D016 File Offset: 0x0000B216
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x0000D01E File Offset: 0x0000B21E
		[global::System.Runtime.Serialization.DataMember(Name = "safeUrl", IsRequired = false)]
		public string SafeUrl { get; set; }
	}
}
