using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Animation
{
	// Token: 0x02000379 RID: 889
	[global::System.Runtime.Serialization.DataContract]
	public class AnimationCreatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x0001C67C File Offset: 0x0001A87C
		// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x0001C684 File Offset: 0x0001A884
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; private set; }
	}
}
