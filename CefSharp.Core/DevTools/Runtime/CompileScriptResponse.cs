using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000052 RID: 82
	[global::System.Runtime.Serialization.DataContract]
	public class CompileScriptResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00005A60 File Offset: 0x00003C60
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00005A68 File Offset: 0x00003C68
		[global::System.Runtime.Serialization.DataMember]
		internal string scriptId { get; set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00005A71 File Offset: 0x00003C71
		public string ScriptId
		{
			get
			{
				return this.scriptId;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00005A79 File Offset: 0x00003C79
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00005A81 File Offset: 0x00003C81
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.ExceptionDetails exceptionDetails { get; set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00005A8A File Offset: 0x00003C8A
		public global::CefSharp.DevTools.Runtime.ExceptionDetails ExceptionDetails
		{
			get
			{
				return this.exceptionDetails;
			}
		}
	}
}
