using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Memory
{
	// Token: 0x02000249 RID: 585
	[global::System.Runtime.Serialization.DataContract]
	public class GetBrowserSamplingProfileResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x00013BC7 File Offset: 0x00011DC7
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x00013BCF File Offset: 0x00011DCF
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Memory.SamplingProfile profile { get; set; }

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00013BD8 File Offset: 0x00011DD8
		public global::CefSharp.DevTools.Memory.SamplingProfile Profile
		{
			get
			{
				return this.profile;
			}
		}
	}
}
