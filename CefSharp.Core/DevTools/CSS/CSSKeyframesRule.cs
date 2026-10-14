using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000311 RID: 785
	[global::System.Runtime.Serialization.DataContract]
	public class CSSKeyframesRule : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x0001A089 File Offset: 0x00018289
		// (set) Token: 0x06001825 RID: 6181 RVA: 0x0001A091 File Offset: 0x00018291
		[global::System.Runtime.Serialization.DataMember(Name = "animationName", IsRequired = true)]
		public global::CefSharp.DevTools.CSS.Value AnimationName { get; set; }

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x0001A09A File Offset: 0x0001829A
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x0001A0A2 File Offset: 0x000182A2
		[global::System.Runtime.Serialization.DataMember(Name = "keyframes", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSKeyframeRule> Keyframes { get; set; }
	}
}
