using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000077 RID: 119
	[global::System.Runtime.Serialization.DataContract]
	public class ScriptPosition : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000723F File Offset: 0x0000543F
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00007247 File Offset: 0x00005447
		[global::System.Runtime.Serialization.DataMember(Name = "lineNumber", IsRequired = true)]
		public int LineNumber { get; set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00007250 File Offset: 0x00005450
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x00007258 File Offset: 0x00005458
		[global::System.Runtime.Serialization.DataMember(Name = "columnNumber", IsRequired = true)]
		public int ColumnNumber { get; set; }
	}
}
