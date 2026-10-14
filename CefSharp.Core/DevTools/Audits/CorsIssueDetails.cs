using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Network;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200035F RID: 863
	[global::System.Runtime.Serialization.DataContract]
	public class CorsIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x0001BE13 File Offset: 0x0001A013
		// (set) Token: 0x06001A1C RID: 6684 RVA: 0x0001BE1B File Offset: 0x0001A01B
		[global::System.Runtime.Serialization.DataMember(Name = "corsErrorStatus", IsRequired = true)]
		public global::CefSharp.DevTools.Network.CorsErrorStatus CorsErrorStatus { get; set; }

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x0001BE24 File Offset: 0x0001A024
		// (set) Token: 0x06001A1E RID: 6686 RVA: 0x0001BE2C File Offset: 0x0001A02C
		[global::System.Runtime.Serialization.DataMember(Name = "isWarning", IsRequired = true)]
		public bool IsWarning { get; set; }

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x0001BE35 File Offset: 0x0001A035
		// (set) Token: 0x06001A20 RID: 6688 RVA: 0x0001BE3D File Offset: 0x0001A03D
		[global::System.Runtime.Serialization.DataMember(Name = "request", IsRequired = true)]
		public global::CefSharp.DevTools.Audits.AffectedRequest Request { get; set; }

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x0001BE46 File Offset: 0x0001A046
		// (set) Token: 0x06001A22 RID: 6690 RVA: 0x0001BE4E File Offset: 0x0001A04E
		[global::System.Runtime.Serialization.DataMember(Name = "location", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.SourceCodeLocation Location { get; set; }

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x0001BE57 File Offset: 0x0001A057
		// (set) Token: 0x06001A24 RID: 6692 RVA: 0x0001BE5F File Offset: 0x0001A05F
		[global::System.Runtime.Serialization.DataMember(Name = "initiatorOrigin", IsRequired = false)]
		public string InitiatorOrigin { get; set; }

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x0001BE68 File Offset: 0x0001A068
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x0001BE84 File Offset: 0x0001A084
		public global::CefSharp.DevTools.Network.IPAddressSpace? ResourceIPAddressSpace
		{
			get
			{
				return (global::CefSharp.DevTools.Network.IPAddressSpace?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.IPAddressSpace?), this.resourceIPAddressSpace);
			}
			set
			{
				this.resourceIPAddressSpace = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x0001BE97 File Offset: 0x0001A097
		// (set) Token: 0x06001A28 RID: 6696 RVA: 0x0001BE9F File Offset: 0x0001A09F
		[global::System.Runtime.Serialization.DataMember(Name = "resourceIPAddressSpace", IsRequired = false)]
		internal string resourceIPAddressSpace { get; set; }

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x0001BEA8 File Offset: 0x0001A0A8
		// (set) Token: 0x06001A2A RID: 6698 RVA: 0x0001BEB0 File Offset: 0x0001A0B0
		[global::System.Runtime.Serialization.DataMember(Name = "clientSecurityState", IsRequired = false)]
		public global::CefSharp.DevTools.Network.ClientSecurityState ClientSecurityState { get; set; }
	}
}
