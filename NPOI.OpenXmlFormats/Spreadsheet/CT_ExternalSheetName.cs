using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000602 RID: 1538
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ExternalSheetName
	{
		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x0600436A RID: 17258 RVA: 0x000A05A6 File Offset: 0x0009E7A6
		// (set) Token: 0x0600436B RID: 17259 RVA: 0x000A05AE File Offset: 0x0009E7AE
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

		// Token: 0x0600436C RID: 17260 RVA: 0x000A05B7 File Offset: 0x0009E7B7
		internal static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetName Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetName
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["val"])
			};
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x000A05D9 File Offset: 0x0009E7D9
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.valField);
			sw.Write("/>");
		}

		// Token: 0x04002A84 RID: 10884
		private string valField;
	}
}
