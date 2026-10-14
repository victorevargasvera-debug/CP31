using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000094 RID: 148
	[global::System.Runtime.Serialization.DataContract]
	public class SetBreakpointOnFunctionCallResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00007B16 File Offset: 0x00005D16
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00007B1E File Offset: 0x00005D1E
		[global::System.Runtime.Serialization.DataMember]
		internal string breakpointId { get; set; }

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00007B27 File Offset: 0x00005D27
		public string BreakpointId
		{
			get
			{
				return this.breakpointId;
			}
		}
	}
}
