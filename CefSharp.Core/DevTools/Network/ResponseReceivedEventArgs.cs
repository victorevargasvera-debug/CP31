using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000221 RID: 545
	[global::System.Runtime.Serialization.DataContract]
	public class ResponseReceivedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x00012439 File Offset: 0x00010639
		// (set) Token: 0x060010D3 RID: 4307 RVA: 0x00012441 File Offset: 0x00010641
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x0001244A File Offset: 0x0001064A
		// (set) Token: 0x060010D5 RID: 4309 RVA: 0x00012452 File Offset: 0x00010652
		[global::System.Runtime.Serialization.DataMember(Name = "loaderId", IsRequired = true)]
		public string LoaderId { get; private set; }

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x0001245B File Offset: 0x0001065B
		// (set) Token: 0x060010D7 RID: 4311 RVA: 0x00012463 File Offset: 0x00010663
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x0001246C File Offset: 0x0001066C
		// (set) Token: 0x060010D9 RID: 4313 RVA: 0x00012488 File Offset: 0x00010688
		public global::CefSharp.DevTools.Network.ResourceType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Network.ResourceType)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.ResourceType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x0001249B File Offset: 0x0001069B
		// (set) Token: 0x060010DB RID: 4315 RVA: 0x000124A3 File Offset: 0x000106A3
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; private set; }

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x000124AC File Offset: 0x000106AC
		// (set) Token: 0x060010DD RID: 4317 RVA: 0x000124B4 File Offset: 0x000106B4
		[global::System.Runtime.Serialization.DataMember(Name = "response", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Response Response { get; private set; }

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x000124BD File Offset: 0x000106BD
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x000124C5 File Offset: 0x000106C5
		[global::System.Runtime.Serialization.DataMember(Name = "hasExtraInfo", IsRequired = true)]
		public bool HasExtraInfo { get; private set; }

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x000124CE File Offset: 0x000106CE
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x000124D6 File Offset: 0x000106D6
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = false)]
		public string FrameId { get; private set; }
	}
}
