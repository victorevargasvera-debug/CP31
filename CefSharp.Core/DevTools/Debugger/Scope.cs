using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x0200007B RID: 123
	[global::System.Runtime.Serialization.DataContract]
	public class Scope : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00007345 File Offset: 0x00005545
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00007361 File Offset: 0x00005561
		public global::CefSharp.DevTools.Debugger.ScopeType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Debugger.ScopeType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Debugger.ScopeType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00007374 File Offset: 0x00005574
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x0000737C File Offset: 0x0000557C
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00007385 File Offset: 0x00005585
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x0000738D File Offset: 0x0000558D
		[global::System.Runtime.Serialization.DataMember(Name = "object", IsRequired = true)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Object { get; set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00007396 File Offset: 0x00005596
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x0000739E File Offset: 0x0000559E
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = false)]
		public string Name { get; set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x000073A7 File Offset: 0x000055A7
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x000073AF File Offset: 0x000055AF
		[global::System.Runtime.Serialization.DataMember(Name = "startLocation", IsRequired = false)]
		public global::CefSharp.DevTools.Debugger.Location StartLocation { get; set; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x000073B8 File Offset: 0x000055B8
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x000073C0 File Offset: 0x000055C0
		[global::System.Runtime.Serialization.DataMember(Name = "endLocation", IsRequired = false)]
		public global::CefSharp.DevTools.Debugger.Location EndLocation { get; set; }
	}
}
