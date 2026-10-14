using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005AD RID: 1453
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CellWatch
	{
		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x0600400B RID: 16395 RVA: 0x0009B5B8 File Offset: 0x000997B8
		// (set) Token: 0x0600400C RID: 16396 RVA: 0x0009B5C0 File Offset: 0x000997C0
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

		// Token: 0x0600400D RID: 16397 RVA: 0x0009B5C9 File Offset: 0x000997C9
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellWatch Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellWatch
			{
				r = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r"])
			};
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x0009B5F0 File Offset: 0x000997F0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r", this.r);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040028B0 RID: 10416
		private string rField;
	}
}
