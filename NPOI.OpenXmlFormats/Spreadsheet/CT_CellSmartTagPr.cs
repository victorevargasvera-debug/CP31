using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005B2 RID: 1458
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CellSmartTagPr
	{
		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06004042 RID: 16450 RVA: 0x0009BEBC File Offset: 0x0009A0BC
		// (set) Token: 0x06004043 RID: 16451 RVA: 0x0009BEC4 File Offset: 0x0009A0C4
		public string key
		{
			get
			{
				return this.keyField;
			}
			set
			{
				this.keyField = value;
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06004044 RID: 16452 RVA: 0x0009BECD File Offset: 0x0009A0CD
		// (set) Token: 0x06004045 RID: 16453 RVA: 0x0009BED5 File Offset: 0x0009A0D5
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

		// Token: 0x06004046 RID: 16454 RVA: 0x0009BEE0 File Offset: 0x0009A0E0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTagPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTagPr
			{
				key = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["key"]),
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["val"])
			};
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x0009BF30 File Offset: 0x0009A130
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "key", this.key);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040028C3 RID: 10435
		private string keyField;

		// Token: 0x040028C4 RID: 10436
		private string valField;
	}
}
