using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000059 RID: 89
	[global::System.Runtime.Serialization.DataContract]
	public class RunScriptResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00005BDD File Offset: 0x00003DDD
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00005BE5 File Offset: 0x00003DE5
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.RemoteObject result { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00005BEE File Offset: 0x00003DEE
		public global::CefSharp.DevTools.Runtime.RemoteObject Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00005BF6 File Offset: 0x00003DF6
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00005BFE File Offset: 0x00003DFE
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.ExceptionDetails exceptionDetails { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00005C07 File Offset: 0x00003E07
		public global::CefSharp.DevTools.Runtime.ExceptionDetails ExceptionDetails
		{
			get
			{
				return this.exceptionDetails;
			}
		}
	}
}
