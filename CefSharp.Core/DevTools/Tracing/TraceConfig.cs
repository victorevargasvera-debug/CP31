using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Tracing
{
	// Token: 0x020000F0 RID: 240
	[global::System.Runtime.Serialization.DataContract]
	public class TraceConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0000A75C File Offset: 0x0000895C
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x0000A778 File Offset: 0x00008978
		public global::CefSharp.DevTools.Tracing.TraceConfigRecordMode? RecordMode
		{
			get
			{
				return (global::CefSharp.DevTools.Tracing.TraceConfigRecordMode?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Tracing.TraceConfigRecordMode?), this.recordMode);
			}
			set
			{
				this.recordMode = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0000A78B File Offset: 0x0000898B
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x0000A793 File Offset: 0x00008993
		[global::System.Runtime.Serialization.DataMember(Name = "recordMode", IsRequired = false)]
		internal string recordMode { get; set; }

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0000A79C File Offset: 0x0000899C
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x0000A7A4 File Offset: 0x000089A4
		[global::System.Runtime.Serialization.DataMember(Name = "traceBufferSizeInKb", IsRequired = false)]
		public double? TraceBufferSizeInKb { get; set; }

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0000A7AD File Offset: 0x000089AD
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x0000A7B5 File Offset: 0x000089B5
		[global::System.Runtime.Serialization.DataMember(Name = "enableSampling", IsRequired = false)]
		public bool? EnableSampling { get; set; }

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x0000A7BE File Offset: 0x000089BE
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x0000A7C6 File Offset: 0x000089C6
		[global::System.Runtime.Serialization.DataMember(Name = "enableSystrace", IsRequired = false)]
		public bool? EnableSystrace { get; set; }

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0000A7CF File Offset: 0x000089CF
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x0000A7D7 File Offset: 0x000089D7
		[global::System.Runtime.Serialization.DataMember(Name = "enableArgumentFilter", IsRequired = false)]
		public bool? EnableArgumentFilter { get; set; }

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x0000A7E0 File Offset: 0x000089E0
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x0000A7E8 File Offset: 0x000089E8
		[global::System.Runtime.Serialization.DataMember(Name = "includedCategories", IsRequired = false)]
		public string[] IncludedCategories { get; set; }

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0000A7F1 File Offset: 0x000089F1
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x0000A7F9 File Offset: 0x000089F9
		[global::System.Runtime.Serialization.DataMember(Name = "excludedCategories", IsRequired = false)]
		public string[] ExcludedCategories { get; set; }

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x0000A802 File Offset: 0x00008A02
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x0000A80A File Offset: 0x00008A0A
		[global::System.Runtime.Serialization.DataMember(Name = "syntheticDelays", IsRequired = false)]
		public string[] SyntheticDelays { get; set; }

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0000A813 File Offset: 0x00008A13
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x0000A81B File Offset: 0x00008A1B
		[global::System.Runtime.Serialization.DataMember(Name = "memoryDumpConfig", IsRequired = false)]
		public global::CefSharp.DevTools.Tracing.MemoryDumpConfig MemoryDumpConfig { get; set; }
	}
}
