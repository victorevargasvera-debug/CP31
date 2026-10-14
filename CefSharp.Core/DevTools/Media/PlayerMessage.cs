using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Media
{
	// Token: 0x020000B4 RID: 180
	[global::System.Runtime.Serialization.DataContract]
	public class PlayerMessage : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00008EA4 File Offset: 0x000070A4
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00008EC0 File Offset: 0x000070C0
		public global::CefSharp.DevTools.Media.PlayerMessageLevel Level
		{
			get
			{
				return (global::CefSharp.DevTools.Media.PlayerMessageLevel)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Media.PlayerMessageLevel), this.level);
			}
			set
			{
				this.level = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00008ED3 File Offset: 0x000070D3
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00008EDB File Offset: 0x000070DB
		[global::System.Runtime.Serialization.DataMember(Name = "level", IsRequired = true)]
		internal string level { get; set; }

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00008EE4 File Offset: 0x000070E4
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00008EEC File Offset: 0x000070EC
		[global::System.Runtime.Serialization.DataMember(Name = "message", IsRequired = true)]
		public string Message { get; set; }
	}
}
