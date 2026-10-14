using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000050 RID: 80
	[global::System.Runtime.Serialization.DataContract]
	public class AwaitPromiseResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600031C RID: 796 RVA: 0x000059EC File Offset: 0x00003BEC
		// (set) Token: 0x0600031D RID: 797 RVA: 0x000059F4 File Offset: 0x00003BF4
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.RemoteObject result { get; set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600031E RID: 798 RVA: 0x000059FD File Offset: 0x00003BFD
		public global::CefSharp.DevTools.Runtime.RemoteObject Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00005A05 File Offset: 0x00003C05
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00005A0D File Offset: 0x00003C0D
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.ExceptionDetails exceptionDetails { get; set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00005A16 File Offset: 0x00003C16
		public global::CefSharp.DevTools.Runtime.ExceptionDetails ExceptionDetails
		{
			get
			{
				return this.exceptionDetails;
			}
		}
	}
}
