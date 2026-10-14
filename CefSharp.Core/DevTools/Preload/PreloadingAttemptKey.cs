using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x020000A3 RID: 163
	[global::System.Runtime.Serialization.DataContract]
	public class PreloadingAttemptKey : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00008900 File Offset: 0x00006B00
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x00008908 File Offset: 0x00006B08
		[global::System.Runtime.Serialization.DataMember(Name = "loaderId", IsRequired = true)]
		public string LoaderId { get; set; }

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00008911 File Offset: 0x00006B11
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x0000892D File Offset: 0x00006B2D
		public global::CefSharp.DevTools.Preload.SpeculationAction Action
		{
			get
			{
				return (global::CefSharp.DevTools.Preload.SpeculationAction)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Preload.SpeculationAction), this.action);
			}
			set
			{
				this.action = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00008940 File Offset: 0x00006B40
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00008948 File Offset: 0x00006B48
		[global::System.Runtime.Serialization.DataMember(Name = "action", IsRequired = true)]
		internal string action { get; set; }

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x00008951 File Offset: 0x00006B51
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x00008959 File Offset: 0x00006B59
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00008962 File Offset: 0x00006B62
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x0000897E File Offset: 0x00006B7E
		public global::CefSharp.DevTools.Preload.SpeculationTargetHint? TargetHint
		{
			get
			{
				return (global::CefSharp.DevTools.Preload.SpeculationTargetHint?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Preload.SpeculationTargetHint?), this.targetHint);
			}
			set
			{
				this.targetHint = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00008991 File Offset: 0x00006B91
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00008999 File Offset: 0x00006B99
		[global::System.Runtime.Serialization.DataMember(Name = "targetHint", IsRequired = false)]
		internal string targetHint { get; set; }
	}
}
