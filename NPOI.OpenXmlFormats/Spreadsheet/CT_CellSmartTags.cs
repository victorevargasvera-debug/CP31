using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005B0 RID: 1456
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CellSmartTags
	{
		// Token: 0x06004030 RID: 16432 RVA: 0x0009BB39 File Offset: 0x00099D39
		public CT_CellSmartTags()
		{
			this.cellSmartTagField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTag>();
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06004031 RID: 16433 RVA: 0x0009BB4C File Offset: 0x00099D4C
		// (set) Token: 0x06004032 RID: 16434 RVA: 0x0009BB54 File Offset: 0x00099D54
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTag> cellSmartTag
		{
			get
			{
				return this.cellSmartTagField;
			}
			set
			{
				this.cellSmartTagField = value;
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06004033 RID: 16435 RVA: 0x0009BB5D File Offset: 0x00099D5D
		// (set) Token: 0x06004034 RID: 16436 RVA: 0x0009BB65 File Offset: 0x00099D65
		public string r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x0009BB70 File Offset: 0x00099D70
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTags Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTags ct_CellSmartTags = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTags();
			ct_CellSmartTags.r = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r"]);
			ct_CellSmartTags.cellSmartTag = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTag>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cellSmartTag")
				{
					ct_CellSmartTags.cellSmartTag.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTag.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CellSmartTags;
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x0009BC18 File Offset: 0x00099E18
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r", this.r);
			sw.Write(">");
			if (this.cellSmartTag != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTag ct_CellSmartTag in this.cellSmartTag)
				{
					ct_CellSmartTag.Write(sw, "cellSmartTag");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040028BD RID: 10429
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTag> cellSmartTagField;

		// Token: 0x040028BE RID: 10430
		private string rField;
	}
}
