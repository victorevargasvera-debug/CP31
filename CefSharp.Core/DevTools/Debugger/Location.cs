using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000076 RID: 118
	[global::System.Runtime.Serialization.DataContract]
	public class Location : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00007204 File Offset: 0x00005404
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x0000720C File Offset: 0x0000540C
		[global::System.Runtime.Serialization.DataMember(Name = "scriptId", IsRequired = true)]
		public string ScriptId { get; set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00007215 File Offset: 0x00005415
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x0000721D File Offset: 0x0000541D
		[global::System.Runtime.Serialization.DataMember(Name = "lineNumber", IsRequired = true)]
		public int LineNumber { get; set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00007226 File Offset: 0x00005426
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0000722E File Offset: 0x0000542E
		[global::System.Runtime.Serialization.DataMember(Name = "columnNumber", IsRequired = false)]
		public int? ColumnNumber { get; set; }
	}
}
