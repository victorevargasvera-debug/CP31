using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005CD RID: 1485
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CustomProperties
	{
		// Token: 0x06004176 RID: 16758 RVA: 0x0009E7CC File Offset: 0x0009C9CC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperties ct_CustomProperties = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperties();
			ct_CustomProperties.customPr = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperty>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "customPr")
				{
					ct_CustomProperties.customPr.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperty.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CustomProperties;
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x0009E85C File Offset: 0x0009CA5C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.customPr != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperty ct_CustomProperty in this.customPr)
				{
					ct_CustomProperty.Write(sw, "customPr");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06004179 RID: 16761 RVA: 0x0009E8E8 File Offset: 0x0009CAE8
		// (set) Token: 0x0600417A RID: 16762 RVA: 0x0009E8F0 File Offset: 0x0009CAF0
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperty> customPr
		{
			get
			{
				return this.customPrField;
			}
			set
			{
				this.customPrField = value;
			}
		}

		// Token: 0x0400294A RID: 10570
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperty> customPrField;
	}
}
