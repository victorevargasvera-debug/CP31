using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004D8 RID: 1240
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PivotHierarchy
	{
		// Token: 0x060033B0 RID: 13232 RVA: 0x00081C4C File Offset: 0x0007FE4C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchy Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchy ct_PivotHierarchy = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchy();
			if (node.Attributes["outline"] != null)
			{
				ct_PivotHierarchy.outline = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["outline"]);
			}
			if (node.Attributes["multipleItemSelectionAllowed"] != null)
			{
				ct_PivotHierarchy.multipleItemSelectionAllowed = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["multipleItemSelectionAllowed"]);
			}
			if (node.Attributes["subtotalTop"] != null)
			{
				ct_PivotHierarchy.subtotalTop = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["subtotalTop"]);
			}
			if (node.Attributes["showInFieldList"] != null)
			{
				ct_PivotHierarchy.showInFieldList = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showInFieldList"]);
			}
			if (node.Attributes["dragToRow"] != null)
			{
				ct_PivotHierarchy.dragToRow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dragToRow"]);
			}
			if (node.Attributes["dragToCol"] != null)
			{
				ct_PivotHierarchy.dragToCol = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dragToCol"]);
			}
			if (node.Attributes["dragToPage"] != null)
			{
				ct_PivotHierarchy.dragToPage = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dragToPage"]);
			}
			if (node.Attributes["dragToData"] != null)
			{
				ct_PivotHierarchy.dragToData = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dragToData"]);
			}
			if (node.Attributes["dragOff"] != null)
			{
				ct_PivotHierarchy.dragOff = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dragOff"]);
			}
			if (node.Attributes["includeNewItemsInFilter"] != null)
			{
				ct_PivotHierarchy.includeNewItemsInFilter = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["includeNewItemsInFilter"]);
			}
			ct_PivotHierarchy.caption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["caption"]);
			ct_PivotHierarchy.members = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Members>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "mps")
				{
					ct_PivotHierarchy.mps = global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_PivotHierarchy.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "members")
				{
					ct_PivotHierarchy.members.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Members.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PivotHierarchy;
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x00081EF8 File Offset: 0x000800F8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "outline", this.outline);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "multipleItemSelectionAllowed", this.multipleItemSelectionAllowed);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "subtotalTop", this.subtotalTop);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showInFieldList", this.showInFieldList);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dragToRow", this.dragToRow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dragToCol", this.dragToCol);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dragToPage", this.dragToPage);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dragToData", this.dragToData);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dragOff", this.dragOff);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "includeNewItemsInFilter", this.includeNewItemsInFilter);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "caption", this.caption);
			sw.Write(">");
			if (this.mps != null)
			{
				this.mps.Write(sw, "mps");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			if (this.members != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Members ct_Members in this.members)
				{
					ct_Members.Write(sw, "members");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x00082070 File Offset: 0x00080270
		public CT_PivotHierarchy()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.membersField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Members>();
			this.mpsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperties();
			this.outlineField = false;
			this.multipleItemSelectionAllowedField = false;
			this.subtotalTopField = false;
			this.showInFieldListField = true;
			this.dragToRowField = true;
			this.dragToColField = true;
			this.dragToPageField = true;
			this.dragToDataField = false;
			this.dragOffField = true;
			this.includeNewItemsInFilterField = false;
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x060033B3 RID: 13235 RVA: 0x000820EA File Offset: 0x000802EA
		// (set) Token: 0x060033B4 RID: 13236 RVA: 0x000820F2 File Offset: 0x000802F2
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperties mps
		{
			get
			{
				return this.mpsField;
			}
			set
			{
				this.mpsField = value;
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x060033B5 RID: 13237 RVA: 0x000820FB File Offset: 0x000802FB
		// (set) Token: 0x060033B6 RID: 13238 RVA: 0x00082103 File Offset: 0x00080303
		[global::System.Xml.Serialization.XmlElement("members", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Members> members
		{
			get
			{
				return this.membersField;
			}
			set
			{
				this.membersField = value;
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x060033B7 RID: 13239 RVA: 0x0008210C File Offset: 0x0008030C
		// (set) Token: 0x060033B8 RID: 13240 RVA: 0x00082114 File Offset: 0x00080314
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x0008211D File Offset: 0x0008031D
		// (set) Token: 0x060033BA RID: 13242 RVA: 0x00082125 File Offset: 0x00080325
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool outline
		{
			get
			{
				return this.outlineField;
			}
			set
			{
				this.outlineField = value;
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x060033BB RID: 13243 RVA: 0x0008212E File Offset: 0x0008032E
		// (set) Token: 0x060033BC RID: 13244 RVA: 0x00082136 File Offset: 0x00080336
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool multipleItemSelectionAllowed
		{
			get
			{
				return this.multipleItemSelectionAllowedField;
			}
			set
			{
				this.multipleItemSelectionAllowedField = value;
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x060033BD RID: 13245 RVA: 0x0008213F File Offset: 0x0008033F
		// (set) Token: 0x060033BE RID: 13246 RVA: 0x00082147 File Offset: 0x00080347
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool subtotalTop
		{
			get
			{
				return this.subtotalTopField;
			}
			set
			{
				this.subtotalTopField = value;
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x060033BF RID: 13247 RVA: 0x00082150 File Offset: 0x00080350
		// (set) Token: 0x060033C0 RID: 13248 RVA: 0x00082158 File Offset: 0x00080358
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showInFieldList
		{
			get
			{
				return this.showInFieldListField;
			}
			set
			{
				this.showInFieldListField = value;
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x060033C1 RID: 13249 RVA: 0x00082161 File Offset: 0x00080361
		// (set) Token: 0x060033C2 RID: 13250 RVA: 0x00082169 File Offset: 0x00080369
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool dragToRow
		{
			get
			{
				return this.dragToRowField;
			}
			set
			{
				this.dragToRowField = value;
			}
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x060033C3 RID: 13251 RVA: 0x00082172 File Offset: 0x00080372
		// (set) Token: 0x060033C4 RID: 13252 RVA: 0x0008217A File Offset: 0x0008037A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool dragToCol
		{
			get
			{
				return this.dragToColField;
			}
			set
			{
				this.dragToColField = value;
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x060033C5 RID: 13253 RVA: 0x00082183 File Offset: 0x00080383
		// (set) Token: 0x060033C6 RID: 13254 RVA: 0x0008218B File Offset: 0x0008038B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool dragToPage
		{
			get
			{
				return this.dragToPageField;
			}
			set
			{
				this.dragToPageField = value;
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x060033C7 RID: 13255 RVA: 0x00082194 File Offset: 0x00080394
		// (set) Token: 0x060033C8 RID: 13256 RVA: 0x0008219C File Offset: 0x0008039C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool dragToData
		{
			get
			{
				return this.dragToDataField;
			}
			set
			{
				this.dragToDataField = value;
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x060033C9 RID: 13257 RVA: 0x000821A5 File Offset: 0x000803A5
		// (set) Token: 0x060033CA RID: 13258 RVA: 0x000821AD File Offset: 0x000803AD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool dragOff
		{
			get
			{
				return this.dragOffField;
			}
			set
			{
				this.dragOffField = value;
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x060033CB RID: 13259 RVA: 0x000821B6 File Offset: 0x000803B6
		// (set) Token: 0x060033CC RID: 13260 RVA: 0x000821BE File Offset: 0x000803BE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool includeNewItemsInFilter
		{
			get
			{
				return this.includeNewItemsInFilterField;
			}
			set
			{
				this.includeNewItemsInFilterField = value;
			}
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x000821C7 File Offset: 0x000803C7
		// (set) Token: 0x060033CE RID: 13262 RVA: 0x000821CF File Offset: 0x000803CF
		[global::System.Xml.Serialization.XmlAttribute]
		public string caption
		{
			get
			{
				return this.captionField;
			}
			set
			{
				this.captionField = value;
			}
		}

		// Token: 0x0400226B RID: 8811
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperties mpsField;

		// Token: 0x0400226C RID: 8812
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Members> membersField;

		// Token: 0x0400226D RID: 8813
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x0400226E RID: 8814
		private bool outlineField;

		// Token: 0x0400226F RID: 8815
		private bool multipleItemSelectionAllowedField;

		// Token: 0x04002270 RID: 8816
		private bool subtotalTopField;

		// Token: 0x04002271 RID: 8817
		private bool showInFieldListField;

		// Token: 0x04002272 RID: 8818
		private bool dragToRowField;

		// Token: 0x04002273 RID: 8819
		private bool dragToColField;

		// Token: 0x04002274 RID: 8820
		private bool dragToPageField;

		// Token: 0x04002275 RID: 8821
		private bool dragToDataField;

		// Token: 0x04002276 RID: 8822
		private bool dragOffField;

		// Token: 0x04002277 RID: 8823
		private bool includeNewItemsInFilterField;

		// Token: 0x04002278 RID: 8824
		private string captionField;
	}
}
