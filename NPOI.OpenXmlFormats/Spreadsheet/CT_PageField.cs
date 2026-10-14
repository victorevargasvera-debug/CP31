using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004C9 RID: 1225
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PageField
	{
		// Token: 0x06003331 RID: 13105 RVA: 0x000805B0 File Offset: 0x0007E7B0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField ct_PageField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField();
			if (node.Attributes["fld"] != null)
			{
				ct_PageField.fld = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["fld"]);
			}
			if (node.Attributes["item"] != null)
			{
				ct_PageField.item = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["item"]);
			}
			if (node.Attributes["hier"] != null)
			{
				ct_PageField.hier = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["hier"]);
			}
			ct_PageField.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_PageField.cap = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["cap"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_PageField.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PageField;
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x000806EC File Offset: 0x0007E8EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fld", this.fld);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "item", this.item, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hier", this.hier);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cap", this.cap);
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00080795 File Offset: 0x0007E995
		public CT_PageField()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06003334 RID: 13108 RVA: 0x000807A8 File Offset: 0x0007E9A8
		// (set) Token: 0x06003335 RID: 13109 RVA: 0x000807B0 File Offset: 0x0007E9B0
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

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06003336 RID: 13110 RVA: 0x000807B9 File Offset: 0x0007E9B9
		// (set) Token: 0x06003337 RID: 13111 RVA: 0x000807C1 File Offset: 0x0007E9C1
		[global::System.Xml.Serialization.XmlAttribute]
		public int fld
		{
			get
			{
				return this.fldField;
			}
			set
			{
				this.fldField = value;
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06003338 RID: 13112 RVA: 0x000807CA File Offset: 0x0007E9CA
		// (set) Token: 0x06003339 RID: 13113 RVA: 0x000807D2 File Offset: 0x0007E9D2
		[global::System.Xml.Serialization.XmlAttribute]
		public uint item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x0600333A RID: 13114 RVA: 0x000807DB File Offset: 0x0007E9DB
		// (set) Token: 0x0600333B RID: 13115 RVA: 0x000807E3 File Offset: 0x0007E9E3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool itemSpecified
		{
			get
			{
				return this.itemFieldSpecified;
			}
			set
			{
				this.itemFieldSpecified = value;
			}
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x0600333C RID: 13116 RVA: 0x000807EC File Offset: 0x0007E9EC
		// (set) Token: 0x0600333D RID: 13117 RVA: 0x000807F4 File Offset: 0x0007E9F4
		[global::System.Xml.Serialization.XmlAttribute]
		public int hier
		{
			get
			{
				return this.hierField;
			}
			set
			{
				this.hierField = value;
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x0600333E RID: 13118 RVA: 0x000807FD File Offset: 0x0007E9FD
		// (set) Token: 0x0600333F RID: 13119 RVA: 0x00080805 File Offset: 0x0007EA05
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hierSpecified
		{
			get
			{
				return this.hierFieldSpecified;
			}
			set
			{
				this.hierFieldSpecified = value;
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06003340 RID: 13120 RVA: 0x0008080E File Offset: 0x0007EA0E
		// (set) Token: 0x06003341 RID: 13121 RVA: 0x00080816 File Offset: 0x0007EA16
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

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06003342 RID: 13122 RVA: 0x0008081F File Offset: 0x0007EA1F
		// (set) Token: 0x06003343 RID: 13123 RVA: 0x00080827 File Offset: 0x0007EA27
		[global::System.Xml.Serialization.XmlAttribute]
		public string cap
		{
			get
			{
				return this.capField;
			}
			set
			{
				this.capField = value;
			}
		}

		// Token: 0x04002225 RID: 8741
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002226 RID: 8742
		private int fldField;

		// Token: 0x04002227 RID: 8743
		private uint itemField;

		// Token: 0x04002228 RID: 8744
		private bool itemFieldSpecified;

		// Token: 0x04002229 RID: 8745
		private int hierField;

		// Token: 0x0400222A RID: 8746
		private bool hierFieldSpecified;

		// Token: 0x0400222B RID: 8747
		private string nameField;

		// Token: 0x0400222C RID: 8748
		private string capField;
	}
}
