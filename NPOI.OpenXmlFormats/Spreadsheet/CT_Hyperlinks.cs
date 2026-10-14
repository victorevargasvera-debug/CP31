using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005C9 RID: 1481
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Hyperlinks
	{
		// Token: 0x06004161 RID: 16737 RVA: 0x0009E2F0 File Offset: 0x0009C4F0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlinks Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlinks ct_Hyperlinks = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlinks();
			ct_Hyperlinks.hyperlink = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "hyperlink")
				{
					ct_Hyperlinks.hyperlink.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Hyperlinks;
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x0009E380 File Offset: 0x0009C580
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.hyperlink != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink ct_Hyperlink in this.hyperlink)
				{
					ct_Hyperlink.Write(sw, "hyperlink");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x0009E40C File Offset: 0x0009C60C
		public void SetHyperlinkArray(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink[] array)
		{
			this.hyperlinkField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink>(array);
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x06004164 RID: 16740 RVA: 0x0009E41A File Offset: 0x0009C61A
		// (set) Token: 0x06004165 RID: 16741 RVA: 0x0009E422 File Offset: 0x0009C622
		[global::System.Xml.Serialization.XmlElement("hyperlink", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink> hyperlink
		{
			get
			{
				return this.hyperlinkField;
			}
			set
			{
				this.hyperlinkField = value;
			}
		}

		// Token: 0x04002946 RID: 10566
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink> hyperlinkField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink>();
	}
}
