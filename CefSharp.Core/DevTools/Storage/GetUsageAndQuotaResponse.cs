using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000138 RID: 312
	[global::System.Runtime.Serialization.DataContract]
	public class GetUsageAndQuotaResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0000C086 File Offset: 0x0000A286
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x0000C08E File Offset: 0x0000A28E
		[global::System.Runtime.Serialization.DataMember]
		internal double usage { get; set; }

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0000C097 File Offset: 0x0000A297
		public double Usage
		{
			get
			{
				return this.usage;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0000C09F File Offset: 0x0000A29F
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x0000C0A7 File Offset: 0x0000A2A7
		[global::System.Runtime.Serialization.DataMember]
		internal double quota { get; set; }

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0000C0B0 File Offset: 0x0000A2B0
		public double Quota
		{
			get
			{
				return this.quota;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		[global::System.Runtime.Serialization.DataMember]
		internal bool overrideActive { get; set; }

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0000C0C9 File Offset: 0x0000A2C9
		public bool OverrideActive
		{
			get
			{
				return this.overrideActive;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0000C0D1 File Offset: 0x0000A2D1
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x0000C0D9 File Offset: 0x0000A2D9
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Storage.UsageForType> usageBreakdown { get; set; }

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0000C0E2 File Offset: 0x0000A2E2
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Storage.UsageForType> UsageBreakdown
		{
			get
			{
				return this.usageBreakdown;
			}
		}
	}
}
