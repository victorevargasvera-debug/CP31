using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000214 RID: 532
	[global::System.Runtime.Serialization.DataContract]
	public class ReportingApiReport : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x00011DF3 File Offset: 0x0000FFF3
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x00011DFB File Offset: 0x0000FFFB
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; set; }

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x00011E04 File Offset: 0x00010004
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x00011E0C File Offset: 0x0001000C
		[global::System.Runtime.Serialization.DataMember(Name = "initiatorUrl", IsRequired = true)]
		public string InitiatorUrl { get; set; }

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00011E15 File Offset: 0x00010015
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x00011E1D File Offset: 0x0001001D
		[global::System.Runtime.Serialization.DataMember(Name = "destination", IsRequired = true)]
		public string Destination { get; set; }

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00011E26 File Offset: 0x00010026
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x00011E2E File Offset: 0x0001002E
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		public string Type { get; set; }

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x00011E37 File Offset: 0x00010037
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x00011E3F File Offset: 0x0001003F
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; set; }

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x00011E48 File Offset: 0x00010048
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x00011E50 File Offset: 0x00010050
		[global::System.Runtime.Serialization.DataMember(Name = "depth", IsRequired = true)]
		public int Depth { get; set; }

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x00011E59 File Offset: 0x00010059
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x00011E61 File Offset: 0x00010061
		[global::System.Runtime.Serialization.DataMember(Name = "completedAttempts", IsRequired = true)]
		public int CompletedAttempts { get; set; }

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x00011E6A File Offset: 0x0001006A
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x00011E72 File Offset: 0x00010072
		[global::System.Runtime.Serialization.DataMember(Name = "body", IsRequired = true)]
		public object Body { get; set; }

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x00011E7B File Offset: 0x0001007B
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x00011E97 File Offset: 0x00010097
		public global::CefSharp.DevTools.Network.ReportStatus Status
		{
			get
			{
				return (global::CefSharp.DevTools.Network.ReportStatus)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.ReportStatus), this.status);
			}
			set
			{
				this.status = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x00011EAA File Offset: 0x000100AA
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x00011EB2 File Offset: 0x000100B2
		[global::System.Runtime.Serialization.DataMember(Name = "status", IsRequired = true)]
		internal string status { get; set; }
	}
}
