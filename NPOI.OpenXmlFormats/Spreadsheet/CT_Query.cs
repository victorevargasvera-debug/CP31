using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004AC RID: 1196
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Query
	{
		// Token: 0x060030F1 RID: 12529 RVA: 0x0007AB74 File Offset: 0x00078D74
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Query Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Query ct_Query = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Query();
			ct_Query.mdx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["mdx"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tpls")
				{
					ct_Query.tpls = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Query;
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x0007AC0C File Offset: 0x00078E0C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "mdx", this.mdx);
			sw.Write(">");
			if (this.tpls != null)
			{
				this.tpls.Write(sw, "tpls");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x0007AC70 File Offset: 0x00078E70
		public CT_Query()
		{
			this.tplsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples();
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x0007AC83 File Offset: 0x00078E83
		// (set) Token: 0x060030F5 RID: 12533 RVA: 0x0007AC8B File Offset: 0x00078E8B
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples tpls
		{
			get
			{
				return this.tplsField;
			}
			set
			{
				this.tplsField = value;
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x0007AC94 File Offset: 0x00078E94
		// (set) Token: 0x060030F7 RID: 12535 RVA: 0x0007AC9C File Offset: 0x00078E9C
		[global::System.Xml.Serialization.XmlAttribute]
		public string mdx
		{
			get
			{
				return this.mdxField;
			}
			set
			{
				this.mdxField = value;
			}
		}

		// Token: 0x04002125 RID: 8485
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples tplsField;

		// Token: 0x04002126 RID: 8486
		private string mdxField;
	}
}
