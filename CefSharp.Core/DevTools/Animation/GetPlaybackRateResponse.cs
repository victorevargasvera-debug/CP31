using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Animation
{
	// Token: 0x0200037C RID: 892
	[global::System.Runtime.Serialization.DataContract]
	public class GetPlaybackRateResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x0001C6CF File Offset: 0x0001A8CF
		// (set) Token: 0x06001AEC RID: 6892 RVA: 0x0001C6D7 File Offset: 0x0001A8D7
		[global::System.Runtime.Serialization.DataMember]
		internal double playbackRate { get; set; }

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x0001C6E0 File Offset: 0x0001A8E0
		public double PlaybackRate
		{
			get
			{
				return this.playbackRate;
			}
		}
	}
}
