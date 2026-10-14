using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200021A RID: 538
	[global::System.Runtime.Serialization.DataContract]
	public class LoadingFailedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x0001202E File Offset: 0x0001022E
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x00012036 File Offset: 0x00010236
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x0001203F File Offset: 0x0001023F
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x00012047 File Offset: 0x00010247
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x00012050 File Offset: 0x00010250
		// (set) Token: 0x06001072 RID: 4210 RVA: 0x0001206C File Offset: 0x0001026C
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

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0001207F File Offset: 0x0001027F
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x00012087 File Offset: 0x00010287
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; private set; }

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x00012090 File Offset: 0x00010290
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x00012098 File Offset: 0x00010298
		[global::System.Runtime.Serialization.DataMember(Name = "errorText", IsRequired = true)]
		public string ErrorText { get; private set; }

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x000120A1 File Offset: 0x000102A1
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x000120A9 File Offset: 0x000102A9
		[global::System.Runtime.Serialization.DataMember(Name = "canceled", IsRequired = false)]
		public bool? Canceled { get; private set; }

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x000120B2 File Offset: 0x000102B2
		// (set) Token: 0x0600107A RID: 4218 RVA: 0x000120CE File Offset: 0x000102CE
		public global::CefSharp.DevTools.Network.BlockedReason? BlockedReason
		{
			get
			{
				return (global::CefSharp.DevTools.Network.BlockedReason?)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.BlockedReason?), this.blockedReason);
			}
			set
			{
				this.blockedReason = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x000120E1 File Offset: 0x000102E1
		// (set) Token: 0x0600107C RID: 4220 RVA: 0x000120E9 File Offset: 0x000102E9
		[global::System.Runtime.Serialization.DataMember(Name = "blockedReason", IsRequired = false)]
		internal string blockedReason { get; private set; }

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x000120F2 File Offset: 0x000102F2
		// (set) Token: 0x0600107E RID: 4222 RVA: 0x000120FA File Offset: 0x000102FA
		[global::System.Runtime.Serialization.DataMember(Name = "corsErrorStatus", IsRequired = false)]
		public global::CefSharp.DevTools.Network.CorsErrorStatus CorsErrorStatus { get; private set; }
	}
}
