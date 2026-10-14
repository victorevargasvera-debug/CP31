using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000054 RID: 84
	[global::System.Runtime.Serialization.DataContract]
	public class GetIsolateIdResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00005AD4 File Offset: 0x00003CD4
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00005ADC File Offset: 0x00003CDC
		[global::System.Runtime.Serialization.DataMember]
		internal string id { get; set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00005AE5 File Offset: 0x00003CE5
		public string Id
		{
			get
			{
				return this.id;
			}
		}
	}
}
