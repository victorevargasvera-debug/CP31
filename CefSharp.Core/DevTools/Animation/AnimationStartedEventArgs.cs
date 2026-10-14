using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Animation
{
	// Token: 0x0200037A RID: 890
	[global::System.Runtime.Serialization.DataContract]
	public class AnimationStartedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x0001C695 File Offset: 0x0001A895
		// (set) Token: 0x06001AE5 RID: 6885 RVA: 0x0001C69D File Offset: 0x0001A89D
		[global::System.Runtime.Serialization.DataMember(Name = "animation", IsRequired = true)]
		public global::CefSharp.DevTools.Animation.Animation Animation { get; private set; }
	}
}
