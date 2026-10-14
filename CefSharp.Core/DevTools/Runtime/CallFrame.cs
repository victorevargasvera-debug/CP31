using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000045 RID: 69
	[global::System.Runtime.Serialization.DataContract]
	public class CallFrame : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000576F File Offset: 0x0000396F
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00005777 File Offset: 0x00003977
		[global::System.Runtime.Serialization.DataMember(Name = "functionName", IsRequired = true)]
		public string FunctionName { get; set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00005780 File Offset: 0x00003980
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00005788 File Offset: 0x00003988
		[global::System.Runtime.Serialization.DataMember(Name = "scriptId", IsRequired = true)]
		public string ScriptId { get; set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00005791 File Offset: 0x00003991
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00005799 File Offset: 0x00003999
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000057A2 File Offset: 0x000039A2
		// (set) Token: 0x060002DB RID: 731 RVA: 0x000057AA File Offset: 0x000039AA
		[global::System.Runtime.Serialization.DataMember(Name = "lineNumber", IsRequired = true)]
		public int LineNumber { get; set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000057B3 File Offset: 0x000039B3
		// (set) Token: 0x060002DD RID: 733 RVA: 0x000057BB File Offset: 0x000039BB
		[global::System.Runtime.Serialization.DataMember(Name = "columnNumber", IsRequired = true)]
		public int ColumnNumber { get; set; }
	}
}
