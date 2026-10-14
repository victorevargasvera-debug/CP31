using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000610 RID: 1552
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_FontName
	{
		// Token: 0x060043E0 RID: 17376 RVA: 0x000A186C File Offset: 0x0009FA6C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["val"])
			};
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x000A1893 File Offset: 0x0009FA93
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			sw.Write("/>");
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x060043E2 RID: 17378 RVA: 0x000A18C2 File Offset: 0x0009FAC2
		// (set) Token: 0x060043E3 RID: 17379 RVA: 0x000A18CA File Offset: 0x0009FACA
		[global::System.Xml.Serialization.XmlAttribute]
		public string val
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

		// Token: 0x04002AAA RID: 10922
		private string valField;
	}
}
