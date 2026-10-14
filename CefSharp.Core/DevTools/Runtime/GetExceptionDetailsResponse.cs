using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200005A RID: 90
	[global::System.Runtime.Serialization.DataContract]
	public class GetExceptionDetailsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00005C17 File Offset: 0x00003E17
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00005C1F File Offset: 0x00003E1F
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.ExceptionDetails exceptionDetails { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00005C28 File Offset: 0x00003E28
		public global::CefSharp.DevTools.Runtime.ExceptionDetails ExceptionDetails
		{
			get
			{
				return this.exceptionDetails;
			}
		}
	}
}
