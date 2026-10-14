using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000326 RID: 806
	[global::System.Runtime.Serialization.DataContract]
	public class SetContainerQueryTextResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x0001A4AE File Offset: 0x000186AE
		// (set) Token: 0x060018A1 RID: 6305 RVA: 0x0001A4B6 File Offset: 0x000186B6
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.CSS.CSSContainerQuery containerQuery { get; set; }

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x0001A4BF File Offset: 0x000186BF
		public global::CefSharp.DevTools.CSS.CSSContainerQuery ContainerQuery
		{
			get
			{
				return this.containerQuery;
			}
		}
	}
}
