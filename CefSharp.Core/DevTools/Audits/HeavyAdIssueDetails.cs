using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000356 RID: 854
	[global::System.Runtime.Serialization.DataContract]
	public class HeavyAdIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x0001BB0B File Offset: 0x00019D0B
		// (set) Token: 0x060019D2 RID: 6610 RVA: 0x0001BB27 File Offset: 0x00019D27
		public global::CefSharp.DevTools.Audits.HeavyAdResolutionStatus Resolution
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.HeavyAdResolutionStatus)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.HeavyAdResolutionStatus), this.resolution);
			}
			set
			{
				this.resolution = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x0001BB3A File Offset: 0x00019D3A
		// (set) Token: 0x060019D4 RID: 6612 RVA: 0x0001BB42 File Offset: 0x00019D42
		[global::System.Runtime.Serialization.DataMember(Name = "resolution", IsRequired = true)]
		internal string resolution { get; set; }

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x0001BB4B File Offset: 0x00019D4B
		// (set) Token: 0x060019D6 RID: 6614 RVA: 0x0001BB67 File Offset: 0x00019D67
		public global::CefSharp.DevTools.Audits.HeavyAdReason Reason
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.HeavyAdReason)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.HeavyAdReason), this.reason);
			}
			set
			{
				this.reason = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x0001BB7A File Offset: 0x00019D7A
		// (set) Token: 0x060019D8 RID: 6616 RVA: 0x0001BB82 File Offset: 0x00019D82
		[global::System.Runtime.Serialization.DataMember(Name = "reason", IsRequired = true)]
		internal string reason { get; set; }

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x0001BB8B File Offset: 0x00019D8B
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x0001BB93 File Offset: 0x00019D93
		[global::System.Runtime.Serialization.DataMember(Name = "frame", IsRequired = true)]
		public global::CefSharp.DevTools.Audits.AffectedFrame Frame { get; set; }
	}
}
