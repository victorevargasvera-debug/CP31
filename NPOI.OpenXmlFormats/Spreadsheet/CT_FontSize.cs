using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000611 RID: 1553
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_FontSize
	{
		// Token: 0x060043E5 RID: 17381 RVA: 0x000A18D3 File Offset: 0x0009FAD3
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["val"])
			};
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x000A18FA File Offset: 0x0009FAFA
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			sw.Write("/>");
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x060043E7 RID: 17383 RVA: 0x000A1929 File Offset: 0x0009FB29
		// (set) Token: 0x060043E8 RID: 17384 RVA: 0x000A1931 File Offset: 0x0009FB31
		[global::System.Xml.Serialization.XmlAttribute]
		public double val
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

		// Token: 0x04002AAB RID: 10923
		private double valField;
	}
}
