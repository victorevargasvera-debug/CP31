using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004AE RID: 1198
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_ServerFormat
	{
		// Token: 0x06003101 RID: 12545 RVA: 0x0007AE4C File Offset: 0x0007904C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormat Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ServerFormat
			{
				culture = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["culture"]),
				format = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["format"])
			};
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x0007AE9C File Offset: 0x0007909C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "culture", this.culture);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "format", this.format);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x0007AEF8 File Offset: 0x000790F8
		// (set) Token: 0x06003104 RID: 12548 RVA: 0x0007AF00 File Offset: 0x00079100
		[global::System.Xml.Serialization.XmlAttribute]
		public string culture
		{
			get
			{
				return this.cultureField;
			}
			set
			{
				this.cultureField = value;
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x0007AF09 File Offset: 0x00079109
		// (set) Token: 0x06003106 RID: 12550 RVA: 0x0007AF11 File Offset: 0x00079111
		[global::System.Xml.Serialization.XmlAttribute]
		public string format
		{
			get
			{
				return this.formatField;
			}
			set
			{
				this.formatField = value;
			}
		}

		// Token: 0x0400212A RID: 8490
		private string cultureField;

		// Token: 0x0400212B RID: 8491
		private string formatField;
	}
}
