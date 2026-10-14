using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000053 RID: 83
	[global::System.Runtime.Serialization.DataContract]
	public class EvaluateResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000331 RID: 817 RVA: 0x00005A9A File Offset: 0x00003C9A
		// (set) Token: 0x06000332 RID: 818 RVA: 0x00005AA2 File Offset: 0x00003CA2
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.RemoteObject result { get; set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00005AAB File Offset: 0x00003CAB
		public global::CefSharp.DevTools.Runtime.RemoteObject Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00005AB3 File Offset: 0x00003CB3
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00005ABB File Offset: 0x00003CBB
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.ExceptionDetails exceptionDetails { get; set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00005AC4 File Offset: 0x00003CC4
		public global::CefSharp.DevTools.Runtime.ExceptionDetails ExceptionDetails
		{
			get
			{
				return this.exceptionDetails;
			}
		}
	}
}
