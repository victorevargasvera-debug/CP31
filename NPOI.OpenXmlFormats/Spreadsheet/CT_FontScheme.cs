using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200060F RID: 1551
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_FontScheme
	{
		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x000A17B7 File Offset: 0x0009F9B7
		// (set) Token: 0x060043DC RID: 17372 RVA: 0x000A17BF File Offset: 0x0009F9BF
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_FontScheme val
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

		// Token: 0x060043DD RID: 17373 RVA: 0x000A17C8 File Offset: 0x0009F9C8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme ct_FontScheme = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme();
			if (node.Attributes["val"] != null)
			{
				ct_FontScheme.val = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_FontScheme)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_FontScheme), node.Attributes["val"].Value);
			}
			return ct_FontScheme;
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x000A1824 File Offset: 0x0009FA24
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x04002AA9 RID: 10921
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_FontScheme valField;
	}
}
