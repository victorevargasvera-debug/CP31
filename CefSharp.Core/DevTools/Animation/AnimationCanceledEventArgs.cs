using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Animation
{
	// Token: 0x02000378 RID: 888
	[global::System.Runtime.Serialization.DataContract]
	public class AnimationCanceledEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x0001C663 File Offset: 0x0001A863
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x0001C66B File Offset: 0x0001A86B
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; private set; }
	}
}
