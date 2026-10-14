using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000089 RID: 137
	[global::System.Runtime.Serialization.DataContract]
	public class EvaluateOnCallFrameResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x000078C4 File Offset: 0x00005AC4
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x000078CC File Offset: 0x00005ACC
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.RemoteObject result { get; set; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x000078D5 File Offset: 0x00005AD5
		public global::CefSharp.DevTools.Runtime.RemoteObject Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x000078DD File Offset: 0x00005ADD
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x000078E5 File Offset: 0x00005AE5
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.ExceptionDetails exceptionDetails { get; set; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x000078EE File Offset: 0x00005AEE
		public global::CefSharp.DevTools.Runtime.ExceptionDetails ExceptionDetails
		{
			get
			{
				return this.exceptionDetails;
			}
		}
	}
}
