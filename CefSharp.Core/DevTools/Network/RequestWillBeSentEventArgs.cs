using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200021E RID: 542
	[global::System.Runtime.Serialization.DataContract]
	public class RequestWillBeSentEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x000122A2 File Offset: 0x000104A2
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x000122AA File Offset: 0x000104AA
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x000122B3 File Offset: 0x000104B3
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x000122BB File Offset: 0x000104BB
		[global::System.Runtime.Serialization.DataMember(Name = "loaderId", IsRequired = true)]
		public string LoaderId { get; private set; }

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x000122C4 File Offset: 0x000104C4
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x000122CC File Offset: 0x000104CC
		[global::System.Runtime.Serialization.DataMember(Name = "documentURL", IsRequired = true)]
		public string DocumentURL { get; private set; }

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x000122D5 File Offset: 0x000104D5
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x000122DD File Offset: 0x000104DD
		[global::System.Runtime.Serialization.DataMember(Name = "request", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Request Request { get; private set; }

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x000122E6 File Offset: 0x000104E6
		// (set) Token: 0x060010B2 RID: 4274 RVA: 0x000122EE File Offset: 0x000104EE
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x000122F7 File Offset: 0x000104F7
		// (set) Token: 0x060010B4 RID: 4276 RVA: 0x000122FF File Offset: 0x000104FF
		[global::System.Runtime.Serialization.DataMember(Name = "wallTime", IsRequired = true)]
		public double WallTime { get; private set; }

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00012308 File Offset: 0x00010508
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x00012310 File Offset: 0x00010510
		[global::System.Runtime.Serialization.DataMember(Name = "initiator", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Initiator Initiator { get; private set; }

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00012319 File Offset: 0x00010519
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x00012321 File Offset: 0x00010521
		[global::System.Runtime.Serialization.DataMember(Name = "redirectHasExtraInfo", IsRequired = true)]
		public bool RedirectHasExtraInfo { get; private set; }

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x0001232A File Offset: 0x0001052A
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x00012332 File Offset: 0x00010532
		[global::System.Runtime.Serialization.DataMember(Name = "redirectResponse", IsRequired = false)]
		public global::CefSharp.DevTools.Network.Response RedirectResponse { get; private set; }

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x0001233B File Offset: 0x0001053B
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x00012357 File Offset: 0x00010557
		public global::CefSharp.DevTools.Network.ResourceType? Type
		{
			get
			{
				return (global::CefSharp.DevTools.Network.ResourceType?)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.ResourceType?), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x0001236A File Offset: 0x0001056A
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x00012372 File Offset: 0x00010572
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = false)]
		internal string type { get; private set; }

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x0001237B File Offset: 0x0001057B
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x00012383 File Offset: 0x00010583
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = false)]
		public string FrameId { get; private set; }

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x0001238C File Offset: 0x0001058C
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x00012394 File Offset: 0x00010594
		[global::System.Runtime.Serialization.DataMember(Name = "hasUserGesture", IsRequired = false)]
		public bool? HasUserGesture { get; private set; }
	}
}
