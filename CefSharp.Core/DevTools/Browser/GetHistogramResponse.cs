using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x0200033D RID: 829
	[global::System.Runtime.Serialization.DataContract]
	public class GetHistogramResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x0001B03F File Offset: 0x0001923F
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x0001B047 File Offset: 0x00019247
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Browser.Histogram histogram { get; set; }

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x0001B050 File Offset: 0x00019250
		public global::CefSharp.DevTools.Browser.Histogram Histogram
		{
			get
			{
				return this.histogram;
			}
		}
	}
}
