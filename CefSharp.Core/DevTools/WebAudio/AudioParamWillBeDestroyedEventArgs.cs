using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000DC RID: 220
	[global::System.Runtime.Serialization.DataContract]
	public class AudioParamWillBeDestroyedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00009B87 File Offset: 0x00007D87
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00009B8F File Offset: 0x00007D8F
		[global::System.Runtime.Serialization.DataMember(Name = "contextId", IsRequired = true)]
		public string ContextId { get; private set; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00009B98 File Offset: 0x00007D98
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00009BA0 File Offset: 0x00007DA0
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public string NodeId { get; private set; }

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00009BA9 File Offset: 0x00007DA9
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00009BB1 File Offset: 0x00007DB1
		[global::System.Runtime.Serialization.DataMember(Name = "paramId", IsRequired = true)]
		public string ParamId { get; private set; }
	}
}
