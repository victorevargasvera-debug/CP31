using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000051 RID: 81
	[global::System.Runtime.Serialization.DataContract]
	public class CallFunctionOnResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00005A26 File Offset: 0x00003C26
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00005A2E File Offset: 0x00003C2E
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.RemoteObject result { get; set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00005A37 File Offset: 0x00003C37
		public global::CefSharp.DevTools.Runtime.RemoteObject Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00005A3F File Offset: 0x00003C3F
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00005A47 File Offset: 0x00003C47
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.ExceptionDetails exceptionDetails { get; set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00005A50 File Offset: 0x00003C50
		public global::CefSharp.DevTools.Runtime.ExceptionDetails ExceptionDetails
		{
			get
			{
				return this.exceptionDetails;
			}
		}
	}
}
