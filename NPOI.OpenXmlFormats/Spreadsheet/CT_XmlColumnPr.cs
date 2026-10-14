using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005E3 RID: 1507
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_XmlColumnPr
	{
		// Token: 0x06004231 RID: 16945 RVA: 0x0009F2DC File Offset: 0x0009D4DC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlColumnPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlColumnPr ct_XmlColumnPr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlColumnPr();
			if (node.Attributes["mapId"] != null)
			{
				ct_XmlColumnPr.mapId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["mapId"]);
			}
			ct_XmlColumnPr.xpath = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["xpath"]);
			if (node.Attributes["denormalized"] != null)
			{
				ct_XmlColumnPr.denormalized = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["denormalized"]);
			}
			if (node.Attributes["xmlDataType"] != null)
			{
				ct_XmlColumnPr.xmlDataType = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_XmlDataType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_XmlDataType), node.Attributes["xmlDataType"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_XmlColumnPr.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_XmlColumnPr;
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x0009F410 File Offset: 0x0009D610
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "mapId", this.mapId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "xpath", this.xpath);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "denormalized", this.denormalized);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "xmlDataType", this.xmlDataType.ToString());
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x0009F4B6 File Offset: 0x0009D6B6
		public CT_XmlColumnPr()
		{
			this.denormalizedField = false;
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06004234 RID: 16948 RVA: 0x0009F4C5 File Offset: 0x0009D6C5
		// (set) Token: 0x06004235 RID: 16949 RVA: 0x0009F4CD File Offset: 0x0009D6CD
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x06004236 RID: 16950 RVA: 0x0009F4D6 File Offset: 0x0009D6D6
		// (set) Token: 0x06004237 RID: 16951 RVA: 0x0009F4DE File Offset: 0x0009D6DE
		[global::System.Xml.Serialization.XmlAttribute]
		public uint mapId
		{
			get
			{
				return this.mapIdField;
			}
			set
			{
				this.mapIdField = value;
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x06004238 RID: 16952 RVA: 0x0009F4E7 File Offset: 0x0009D6E7
		// (set) Token: 0x06004239 RID: 16953 RVA: 0x0009F4EF File Offset: 0x0009D6EF
		[global::System.Xml.Serialization.XmlAttribute]
		public string xpath
		{
			get
			{
				return this.xpathField;
			}
			set
			{
				this.xpathField = value;
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x0600423A RID: 16954 RVA: 0x0009F4F8 File Offset: 0x0009D6F8
		// (set) Token: 0x0600423B RID: 16955 RVA: 0x0009F500 File Offset: 0x0009D700
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool denormalized
		{
			get
			{
				return this.denormalizedField;
			}
			set
			{
				this.denormalizedField = value;
			}
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x0600423C RID: 16956 RVA: 0x0009F509 File Offset: 0x0009D709
		// (set) Token: 0x0600423D RID: 16957 RVA: 0x0009F511 File Offset: 0x0009D711
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_XmlDataType xmlDataType
		{
			get
			{
				return this.xmlDataTypeField;
			}
			set
			{
				this.xmlDataTypeField = value;
			}
		}

		// Token: 0x040029B2 RID: 10674
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040029B3 RID: 10675
		private uint mapIdField;

		// Token: 0x040029B4 RID: 10676
		private string xpathField;

		// Token: 0x040029B5 RID: 10677
		private bool denormalizedField;

		// Token: 0x040029B6 RID: 10678
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_XmlDataType xmlDataTypeField;
	}
}
