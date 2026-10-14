using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000212 RID: 530
	[global::System.Runtime.Serialization.DataContract]
	public class SecurityIsolationStatus : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x00011DC9 File Offset: 0x0000FFC9
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x00011DD1 File Offset: 0x0000FFD1
		[global::System.Runtime.Serialization.DataMember(Name = "coop", IsRequired = false)]
		public global::CefSharp.DevTools.Network.CrossOriginOpenerPolicyStatus Coop { get; set; }

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x00011DDA File Offset: 0x0000FFDA
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x00011DE2 File Offset: 0x0000FFE2
		[global::System.Runtime.Serialization.DataMember(Name = "coep", IsRequired = false)]
		public global::CefSharp.DevTools.Network.CrossOriginEmbedderPolicyStatus Coep { get; set; }
	}
}
