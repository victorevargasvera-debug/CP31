using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002B7 RID: 695
	[global::System.Runtime.Serialization.DataContract]
	public class Node : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x000175C3 File Offset: 0x000157C3
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x000175CB File Offset: 0x000157CB
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public int NodeId { get; set; }

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x000175D4 File Offset: 0x000157D4
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x000175DC File Offset: 0x000157DC
		[global::System.Runtime.Serialization.DataMember(Name = "parentId", IsRequired = false)]
		public int? ParentId { get; set; }

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x000175E5 File Offset: 0x000157E5
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x000175ED File Offset: 0x000157ED
		[global::System.Runtime.Serialization.DataMember(Name = "backendNodeId", IsRequired = true)]
		public int BackendNodeId { get; set; }

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x000175F6 File Offset: 0x000157F6
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x000175FE File Offset: 0x000157FE
		[global::System.Runtime.Serialization.DataMember(Name = "nodeType", IsRequired = true)]
		public int NodeType { get; set; }

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00017607 File Offset: 0x00015807
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x0001760F File Offset: 0x0001580F
		[global::System.Runtime.Serialization.DataMember(Name = "nodeName", IsRequired = true)]
		public string NodeName { get; set; }

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x00017618 File Offset: 0x00015818
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x00017620 File Offset: 0x00015820
		[global::System.Runtime.Serialization.DataMember(Name = "localName", IsRequired = true)]
		public string LocalName { get; set; }

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x00017629 File Offset: 0x00015829
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x00017631 File Offset: 0x00015831
		[global::System.Runtime.Serialization.DataMember(Name = "nodeValue", IsRequired = true)]
		public string NodeValue { get; set; }

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x0001763A File Offset: 0x0001583A
		// (set) Token: 0x06001549 RID: 5449 RVA: 0x00017642 File Offset: 0x00015842
		[global::System.Runtime.Serialization.DataMember(Name = "childNodeCount", IsRequired = false)]
		public int? ChildNodeCount { get; set; }

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x0001764B File Offset: 0x0001584B
		// (set) Token: 0x0600154B RID: 5451 RVA: 0x00017653 File Offset: 0x00015853
		[global::System.Runtime.Serialization.DataMember(Name = "children", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOM.Node> Children { get; set; }

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x0001765C File Offset: 0x0001585C
		// (set) Token: 0x0600154D RID: 5453 RVA: 0x00017664 File Offset: 0x00015864
		[global::System.Runtime.Serialization.DataMember(Name = "attributes", IsRequired = false)]
		public string[] Attributes { get; set; }

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x0001766D File Offset: 0x0001586D
		// (set) Token: 0x0600154F RID: 5455 RVA: 0x00017675 File Offset: 0x00015875
		[global::System.Runtime.Serialization.DataMember(Name = "documentURL", IsRequired = false)]
		public string DocumentURL { get; set; }

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x0001767E File Offset: 0x0001587E
		// (set) Token: 0x06001551 RID: 5457 RVA: 0x00017686 File Offset: 0x00015886
		[global::System.Runtime.Serialization.DataMember(Name = "baseURL", IsRequired = false)]
		public string BaseURL { get; set; }

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x0001768F File Offset: 0x0001588F
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x00017697 File Offset: 0x00015897
		[global::System.Runtime.Serialization.DataMember(Name = "publicId", IsRequired = false)]
		public string PublicId { get; set; }

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x000176A0 File Offset: 0x000158A0
		// (set) Token: 0x06001555 RID: 5461 RVA: 0x000176A8 File Offset: 0x000158A8
		[global::System.Runtime.Serialization.DataMember(Name = "systemId", IsRequired = false)]
		public string SystemId { get; set; }

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x000176B1 File Offset: 0x000158B1
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x000176B9 File Offset: 0x000158B9
		[global::System.Runtime.Serialization.DataMember(Name = "internalSubset", IsRequired = false)]
		public string InternalSubset { get; set; }

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x000176C2 File Offset: 0x000158C2
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x000176CA File Offset: 0x000158CA
		[global::System.Runtime.Serialization.DataMember(Name = "xmlVersion", IsRequired = false)]
		public string XmlVersion { get; set; }

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x000176D3 File Offset: 0x000158D3
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x000176DB File Offset: 0x000158DB
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = false)]
		public string Name { get; set; }

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x000176E4 File Offset: 0x000158E4
		// (set) Token: 0x0600155D RID: 5469 RVA: 0x000176EC File Offset: 0x000158EC
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = false)]
		public string Value { get; set; }

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x000176F5 File Offset: 0x000158F5
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x00017711 File Offset: 0x00015911
		public global::CefSharp.DevTools.DOM.PseudoType? PseudoType
		{
			get
			{
				return (global::CefSharp.DevTools.DOM.PseudoType?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.DOM.PseudoType?), this.pseudoType);
			}
			set
			{
				this.pseudoType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x00017724 File Offset: 0x00015924
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x0001772C File Offset: 0x0001592C
		[global::System.Runtime.Serialization.DataMember(Name = "pseudoType", IsRequired = false)]
		internal string pseudoType { get; set; }

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x00017735 File Offset: 0x00015935
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x0001773D File Offset: 0x0001593D
		[global::System.Runtime.Serialization.DataMember(Name = "pseudoIdentifier", IsRequired = false)]
		public string PseudoIdentifier { get; set; }

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x00017746 File Offset: 0x00015946
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x00017762 File Offset: 0x00015962
		public global::CefSharp.DevTools.DOM.ShadowRootType? ShadowRootType
		{
			get
			{
				return (global::CefSharp.DevTools.DOM.ShadowRootType?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.DOM.ShadowRootType?), this.shadowRootType);
			}
			set
			{
				this.shadowRootType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x00017775 File Offset: 0x00015975
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x0001777D File Offset: 0x0001597D
		[global::System.Runtime.Serialization.DataMember(Name = "shadowRootType", IsRequired = false)]
		internal string shadowRootType { get; set; }

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x00017786 File Offset: 0x00015986
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x0001778E File Offset: 0x0001598E
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = false)]
		public string FrameId { get; set; }

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x00017797 File Offset: 0x00015997
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x0001779F File Offset: 0x0001599F
		[global::System.Runtime.Serialization.DataMember(Name = "contentDocument", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.Node ContentDocument { get; set; }

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x000177A8 File Offset: 0x000159A8
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x000177B0 File Offset: 0x000159B0
		[global::System.Runtime.Serialization.DataMember(Name = "shadowRoots", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOM.Node> ShadowRoots { get; set; }

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x000177B9 File Offset: 0x000159B9
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x000177C1 File Offset: 0x000159C1
		[global::System.Runtime.Serialization.DataMember(Name = "templateContent", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.Node TemplateContent { get; set; }

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x000177CA File Offset: 0x000159CA
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x000177D2 File Offset: 0x000159D2
		[global::System.Runtime.Serialization.DataMember(Name = "pseudoElements", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOM.Node> PseudoElements { get; set; }

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x000177DB File Offset: 0x000159DB
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x000177E3 File Offset: 0x000159E3
		[global::System.Runtime.Serialization.DataMember(Name = "importedDocument", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.Node ImportedDocument { get; set; }

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x000177EC File Offset: 0x000159EC
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x000177F4 File Offset: 0x000159F4
		[global::System.Runtime.Serialization.DataMember(Name = "distributedNodes", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOM.BackendNode> DistributedNodes { get; set; }

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x000177FD File Offset: 0x000159FD
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x00017805 File Offset: 0x00015A05
		[global::System.Runtime.Serialization.DataMember(Name = "isSVG", IsRequired = false)]
		public bool? IsSVG { get; set; }

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x0001780E File Offset: 0x00015A0E
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x0001782A File Offset: 0x00015A2A
		public global::CefSharp.DevTools.DOM.CompatibilityMode? CompatibilityMode
		{
			get
			{
				return (global::CefSharp.DevTools.DOM.CompatibilityMode?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.DOM.CompatibilityMode?), this.compatibilityMode);
			}
			set
			{
				this.compatibilityMode = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x0001783D File Offset: 0x00015A3D
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x00017845 File Offset: 0x00015A45
		[global::System.Runtime.Serialization.DataMember(Name = "compatibilityMode", IsRequired = false)]
		internal string compatibilityMode { get; set; }

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x0001784E File Offset: 0x00015A4E
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x00017856 File Offset: 0x00015A56
		[global::System.Runtime.Serialization.DataMember(Name = "assignedSlot", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.BackendNode AssignedSlot { get; set; }
	}
}
