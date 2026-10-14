using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004B2 RID: 1202
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_CalculatedMember
	{
		// Token: 0x06003127 RID: 12583 RVA: 0x0007B450 File Offset: 0x00079650
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMember Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMember ct_CalculatedMember = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMember();
			ct_CalculatedMember.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_CalculatedMember.mdx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["mdx"]);
			ct_CalculatedMember.memberName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["memberName"]);
			ct_CalculatedMember.hierarchy = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["hierarchy"]);
			ct_CalculatedMember.parent = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["parent"]);
			if (node.Attributes["solveOrder"] != null)
			{
				ct_CalculatedMember.solveOrder = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["solveOrder"]);
			}
			if (node.Attributes["set"] != null)
			{
				ct_CalculatedMember.set = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["set"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_CalculatedMember.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_CalculatedMember;
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x0007B5B0 File Offset: 0x000797B0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "mdx", this.mdx);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "memberName", this.memberName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hierarchy", this.hierarchy);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "parent", this.parent);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "solveOrder", this.solveOrder);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "set", this.set);
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x0007B67A File Offset: 0x0007987A
		public CT_CalculatedMember()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.solveOrderField = 0;
			this.setField = false;
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x0007B69B File Offset: 0x0007989B
		// (set) Token: 0x0600312B RID: 12587 RVA: 0x0007B6A3 File Offset: 0x000798A3
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x0007B6AC File Offset: 0x000798AC
		// (set) Token: 0x0600312D RID: 12589 RVA: 0x0007B6B4 File Offset: 0x000798B4
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x0600312E RID: 12590 RVA: 0x0007B6BD File Offset: 0x000798BD
		// (set) Token: 0x0600312F RID: 12591 RVA: 0x0007B6C5 File Offset: 0x000798C5
		[global::System.Xml.Serialization.XmlAttribute]
		public string mdx
		{
			get
			{
				return this.mdxField;
			}
			set
			{
				this.mdxField = value;
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06003130 RID: 12592 RVA: 0x0007B6CE File Offset: 0x000798CE
		// (set) Token: 0x06003131 RID: 12593 RVA: 0x0007B6D6 File Offset: 0x000798D6
		[global::System.Xml.Serialization.XmlAttribute]
		public string memberName
		{
			get
			{
				return this.memberNameField;
			}
			set
			{
				this.memberNameField = value;
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06003132 RID: 12594 RVA: 0x0007B6DF File Offset: 0x000798DF
		// (set) Token: 0x06003133 RID: 12595 RVA: 0x0007B6E7 File Offset: 0x000798E7
		[global::System.Xml.Serialization.XmlAttribute]
		public string hierarchy
		{
			get
			{
				return this.hierarchyField;
			}
			set
			{
				this.hierarchyField = value;
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06003134 RID: 12596 RVA: 0x0007B6F0 File Offset: 0x000798F0
		// (set) Token: 0x06003135 RID: 12597 RVA: 0x0007B6F8 File Offset: 0x000798F8
		[global::System.Xml.Serialization.XmlAttribute]
		public string parent
		{
			get
			{
				return this.parentField;
			}
			set
			{
				this.parentField = value;
			}
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06003136 RID: 12598 RVA: 0x0007B701 File Offset: 0x00079901
		// (set) Token: 0x06003137 RID: 12599 RVA: 0x0007B709 File Offset: 0x00079909
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int solveOrder
		{
			get
			{
				return this.solveOrderField;
			}
			set
			{
				this.solveOrderField = value;
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06003138 RID: 12600 RVA: 0x0007B712 File Offset: 0x00079912
		// (set) Token: 0x06003139 RID: 12601 RVA: 0x0007B71A File Offset: 0x0007991A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool set
		{
			get
			{
				return this.setField;
			}
			set
			{
				this.setField = value;
			}
		}

		// Token: 0x04002137 RID: 8503
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002138 RID: 8504
		private string nameField;

		// Token: 0x04002139 RID: 8505
		private string mdxField;

		// Token: 0x0400213A RID: 8506
		private string memberNameField;

		// Token: 0x0400213B RID: 8507
		private string hierarchyField;

		// Token: 0x0400213C RID: 8508
		private string parentField;

		// Token: 0x0400213D RID: 8509
		private int solveOrderField;

		// Token: 0x0400213E RID: 8510
		private bool setField;
	}
}
