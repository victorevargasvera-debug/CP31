using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000164 RID: 356
	[global::System.Runtime.Serialization.DataContract]
	public class AdScriptId : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0000D797 File Offset: 0x0000B997
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x0000D79F File Offset: 0x0000B99F
		[global::System.Runtime.Serialization.DataMember(Name = "scriptId", IsRequired = true)]
		public string ScriptId { get; set; }

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0000D7A8 File Offset: 0x0000B9A8
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
		[global::System.Runtime.Serialization.DataMember(Name = "debuggerId", IsRequired = true)]
		public string DebuggerId { get; set; }
	}
}
