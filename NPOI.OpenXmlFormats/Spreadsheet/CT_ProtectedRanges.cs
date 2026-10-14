using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005CA RID: 1482
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_ProtectedRanges
	{
		// Token: 0x06004167 RID: 16743 RVA: 0x0009E440 File Offset: 0x0009C640
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ProtectedRanges Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ProtectedRanges ct_ProtectedRanges = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ProtectedRanges();
			ct_ProtectedRanges.protectedRange = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ProtectedRange>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "protectedRange")
				{
					ct_ProtectedRanges.protectedRange.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ProtectedRange.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ProtectedRanges;
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x0009E4D0 File Offset: 0x0009C6D0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.protectedRange != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ProtectedRange ct_ProtectedRange in this.protectedRange)
				{
					ct_ProtectedRange.Write(sw, "protectedRange");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x0600416A RID: 16746 RVA: 0x0009E55C File Offset: 0x0009C75C
		// (set) Token: 0x0600416B RID: 16747 RVA: 0x0009E564 File Offset: 0x0009C764
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ProtectedRange> protectedRange
		{
			get
			{
				return this.protectedRangeField;
			}
			set
			{
				this.protectedRangeField = value;
			}
		}

		// Token: 0x04002947 RID: 10567
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ProtectedRange> protectedRangeField;
	}
}
