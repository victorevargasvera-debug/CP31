using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Animation
{
	// Token: 0x02000376 RID: 886
	[global::System.Runtime.Serialization.DataContract]
	public class KeyframesRule : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x0001C60F File Offset: 0x0001A80F
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x0001C617 File Offset: 0x0001A817
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = false)]
		public string Name { get; set; }

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x0001C620 File Offset: 0x0001A820
		// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x0001C628 File Offset: 0x0001A828
		[global::System.Runtime.Serialization.DataMember(Name = "keyframes", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Animation.KeyframeStyle> Keyframes { get; set; }
	}
}
