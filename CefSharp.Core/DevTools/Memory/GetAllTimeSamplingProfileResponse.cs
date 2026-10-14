using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Memory
{
	// Token: 0x02000248 RID: 584
	[global::System.Runtime.Serialization.DataContract]
	public class GetAllTimeSamplingProfileResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00013BA6 File Offset: 0x00011DA6
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x00013BAE File Offset: 0x00011DAE
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Memory.SamplingProfile profile { get; set; }

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x00013BB7 File Offset: 0x00011DB7
		public global::CefSharp.DevTools.Memory.SamplingProfile Profile
		{
			get
			{
				return this.profile;
			}
		}
	}
}
