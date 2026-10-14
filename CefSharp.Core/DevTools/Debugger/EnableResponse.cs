using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000088 RID: 136
	[global::System.Runtime.Serialization.DataContract]
	public class EnableResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x000078A3 File Offset: 0x00005AA3
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x000078AB File Offset: 0x00005AAB
		[global::System.Runtime.Serialization.DataMember]
		internal string debuggerId { get; set; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x000078B4 File Offset: 0x00005AB4
		public string DebuggerId
		{
			get
			{
				return this.debuggerId;
			}
		}
	}
}
