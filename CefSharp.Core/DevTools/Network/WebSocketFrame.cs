using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001F4 RID: 500
	[global::System.Runtime.Serialization.DataContract]
	public class WebSocketFrame : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x0001135D File Offset: 0x0000F55D
		// (set) Token: 0x06000F37 RID: 3895 RVA: 0x00011365 File Offset: 0x0000F565
		[global::System.Runtime.Serialization.DataMember(Name = "opcode", IsRequired = true)]
		public double Opcode { get; set; }

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x0001136E File Offset: 0x0000F56E
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x00011376 File Offset: 0x0000F576
		[global::System.Runtime.Serialization.DataMember(Name = "mask", IsRequired = true)]
		public bool Mask { get; set; }

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x0001137F File Offset: 0x0000F57F
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x00011387 File Offset: 0x0000F587
		[global::System.Runtime.Serialization.DataMember(Name = "payloadData", IsRequired = true)]
		public string PayloadData { get; set; }
	}
}
