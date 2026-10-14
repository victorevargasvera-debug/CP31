using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000082 RID: 130
	[global::System.Runtime.Serialization.DataContract]
	public class DebugSymbols : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x000074A0 File Offset: 0x000056A0
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x000074BC File Offset: 0x000056BC
		public global::CefSharp.DevTools.Debugger.DebugSymbolsType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Debugger.DebugSymbolsType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Debugger.DebugSymbolsType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x000074CF File Offset: 0x000056CF
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x000074D7 File Offset: 0x000056D7
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x000074E0 File Offset: 0x000056E0
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x000074E8 File Offset: 0x000056E8
		[global::System.Runtime.Serialization.DataMember(Name = "externalURL", IsRequired = false)]
		public string ExternalURL { get; set; }
	}
}
