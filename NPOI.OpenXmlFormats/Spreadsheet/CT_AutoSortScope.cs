using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004C0 RID: 1216
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_AutoSortScope
	{
		// Token: 0x060032EB RID: 13035 RVA: 0x0007F8BC File Offset: 0x0007DABC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoSortScope Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoSortScope ct_AutoSortScope = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoSortScope();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pivotArea")
				{
					ct_AutoSortScope.pivotArea = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_AutoSortScope;
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x0007F93C File Offset: 0x0007DB3C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.pivotArea != null)
			{
				this.pivotArea.Write(sw, "pivotArea");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x0007F98F File Offset: 0x0007DB8F
		public CT_AutoSortScope()
		{
			this.pivotAreaField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea();
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x0007F9A2 File Offset: 0x0007DBA2
		// (set) Token: 0x060032EF RID: 13039 RVA: 0x0007F9AA File Offset: 0x0007DBAA
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea pivotArea
		{
			get
			{
				return this.pivotAreaField;
			}
			set
			{
				this.pivotAreaField = value;
			}
		}

		// Token: 0x0400220E RID: 8718
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea pivotAreaField;
	}
}
