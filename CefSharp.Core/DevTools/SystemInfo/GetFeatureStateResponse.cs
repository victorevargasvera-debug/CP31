using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.SystemInfo
{
	// Token: 0x0200011D RID: 285
	[global::System.Runtime.Serialization.DataContract]
	public class GetFeatureStateResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0000B9F6 File Offset: 0x00009BF6
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x0000B9FE File Offset: 0x00009BFE
		[global::System.Runtime.Serialization.DataMember]
		internal bool featureEnabled { get; set; }

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0000BA07 File Offset: 0x00009C07
		public bool FeatureEnabled
		{
			get
			{
				return this.featureEnabled;
			}
		}
	}
}
