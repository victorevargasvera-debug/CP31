using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000615 RID: 1557
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_VerticalAlignFontProperty
	{
		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x060043F0 RID: 17392 RVA: 0x000A1A2B File Offset: 0x0009FC2B
		// (set) Token: 0x060043F1 RID: 17393 RVA: 0x000A1A33 File Offset: 0x0009FC33
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignRun val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x000A1A3C File Offset: 0x0009FC3C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty ct_VerticalAlignFontProperty = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty();
			if (node.Attributes["val"] != null)
			{
				ct_VerticalAlignFontProperty.val = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignRun)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignRun), node.Attributes["val"].Value);
			}
			return ct_VerticalAlignFontProperty;
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x000A1A98 File Offset: 0x0009FC98
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x04002AB7 RID: 10935
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignRun valField;
	}
}
