using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002DF RID: 735
	[global::System.Runtime.Serialization.DataContract]
	public class GetNodeStackTracesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x00017F16 File Offset: 0x00016116
		// (set) Token: 0x0600164D RID: 5709 RVA: 0x00017F1E File Offset: 0x0001611E
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.StackTrace creation { get; set; }

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00017F27 File Offset: 0x00016127
		public global::CefSharp.DevTools.Runtime.StackTrace Creation
		{
			get
			{
				return this.creation;
			}
		}
	}
}
