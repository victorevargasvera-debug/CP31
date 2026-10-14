using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x02000387 RID: 903
	[global::System.Runtime.Serialization.DataContract]
	public class AXNode : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x0001CBA8 File Offset: 0x0001ADA8
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x0001CBB0 File Offset: 0x0001ADB0
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public string NodeId { get; set; }

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0001CBB9 File Offset: 0x0001ADB9
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x0001CBC1 File Offset: 0x0001ADC1
		[global::System.Runtime.Serialization.DataMember(Name = "ignored", IsRequired = true)]
		public bool Ignored { get; set; }

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x0001CBCA File Offset: 0x0001ADCA
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x0001CBD2 File Offset: 0x0001ADD2
		[global::System.Runtime.Serialization.DataMember(Name = "ignoredReasons", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXProperty> IgnoredReasons { get; set; }

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x0001CBDB File Offset: 0x0001ADDB
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x0001CBE3 File Offset: 0x0001ADE3
		[global::System.Runtime.Serialization.DataMember(Name = "role", IsRequired = false)]
		public global::CefSharp.DevTools.Accessibility.AXValue Role { get; set; }

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0001CBEC File Offset: 0x0001ADEC
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x0001CBF4 File Offset: 0x0001ADF4
		[global::System.Runtime.Serialization.DataMember(Name = "chromeRole", IsRequired = false)]
		public global::CefSharp.DevTools.Accessibility.AXValue ChromeRole { get; set; }

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x0001CBFD File Offset: 0x0001ADFD
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x0001CC05 File Offset: 0x0001AE05
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = false)]
		public global::CefSharp.DevTools.Accessibility.AXValue Name { get; set; }

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x0001CC0E File Offset: 0x0001AE0E
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x0001CC16 File Offset: 0x0001AE16
		[global::System.Runtime.Serialization.DataMember(Name = "description", IsRequired = false)]
		public global::CefSharp.DevTools.Accessibility.AXValue Description { get; set; }

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x0001CC1F File Offset: 0x0001AE1F
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x0001CC27 File Offset: 0x0001AE27
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = false)]
		public global::CefSharp.DevTools.Accessibility.AXValue Value { get; set; }

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x0001CC30 File Offset: 0x0001AE30
		// (set) Token: 0x06001B45 RID: 6981 RVA: 0x0001CC38 File Offset: 0x0001AE38
		[global::System.Runtime.Serialization.DataMember(Name = "properties", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXProperty> Properties { get; set; }

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x0001CC41 File Offset: 0x0001AE41
		// (set) Token: 0x06001B47 RID: 6983 RVA: 0x0001CC49 File Offset: 0x0001AE49
		[global::System.Runtime.Serialization.DataMember(Name = "parentId", IsRequired = false)]
		public string ParentId { get; set; }

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x0001CC52 File Offset: 0x0001AE52
		// (set) Token: 0x06001B49 RID: 6985 RVA: 0x0001CC5A File Offset: 0x0001AE5A
		[global::System.Runtime.Serialization.DataMember(Name = "childIds", IsRequired = false)]
		public string[] ChildIds { get; set; }

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x0001CC63 File Offset: 0x0001AE63
		// (set) Token: 0x06001B4B RID: 6987 RVA: 0x0001CC6B File Offset: 0x0001AE6B
		[global::System.Runtime.Serialization.DataMember(Name = "backendDOMNodeId", IsRequired = false)]
		public int? BackendDOMNodeId { get; set; }

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x0001CC74 File Offset: 0x0001AE74
		// (set) Token: 0x06001B4D RID: 6989 RVA: 0x0001CC7C File Offset: 0x0001AE7C
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = false)]
		public string FrameId { get; set; }
	}
}
