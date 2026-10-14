using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x0200033C RID: 828
	[global::System.Runtime.Serialization.DataContract]
	public class GetHistogramsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x0001B01E File Offset: 0x0001921E
		// (set) Token: 0x0600193C RID: 6460 RVA: 0x0001B026 File Offset: 0x00019226
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Browser.Histogram> histograms { get; set; }

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x0001B02F File Offset: 0x0001922F
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Browser.Histogram> Histograms
		{
			get
			{
				return this.histograms;
			}
		}
	}
}
