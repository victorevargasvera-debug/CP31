using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Tracing
{
	// Token: 0x020000F8 RID: 248
	[global::System.Runtime.Serialization.DataContract]
	public class GetCategoriesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x0000A92A File Offset: 0x00008B2A
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x0000A932 File Offset: 0x00008B32
		[global::System.Runtime.Serialization.DataMember]
		internal string[] categories { get; set; }

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0000A93B File Offset: 0x00008B3B
		public string[] Categories
		{
			get
			{
				return this.categories;
			}
		}
	}
}
