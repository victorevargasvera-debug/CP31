using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Memory
{
	// Token: 0x0200024A RID: 586
	[global::System.Runtime.Serialization.DataContract]
	public class GetSamplingProfileResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00013BE8 File Offset: 0x00011DE8
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x00013BF0 File Offset: 0x00011DF0
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Memory.SamplingProfile profile { get; set; }

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00013BF9 File Offset: 0x00011DF9
		public global::CefSharp.DevTools.Memory.SamplingProfile Profile
		{
			get
			{
				return this.profile;
			}
		}
	}
}
