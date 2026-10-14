using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000D4 RID: 212
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SdtCell
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x00011234 File Offset: 0x0000F434
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell ct_SdtCell = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell();
			ct_SdtCell.sdtEndPr = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sdtPr")
				{
					ct_SdtCell.sdtPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sdtContent")
				{
					ct_SdtCell.sdtContent = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentCell.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sdtEndPr")
				{
					ct_SdtCell.sdtEndPr.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SdtCell;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00011304 File Offset: 0x0000F504
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.sdtPr != null)
			{
				this.sdtPr.Write(sw, "sdtPr");
			}
			if (this.sdtContent != null)
			{
				this.sdtContent.Write(sw, "sdtContent");
			}
			if (this.sdtEndPr != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr in this.sdtEndPr)
				{
					ct_RPr.Write(sw, "sdtEndPr");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x000113C4 File Offset: 0x0000F5C4
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x000113CC File Offset: 0x0000F5CC
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr sdtPr
		{
			get
			{
				return this.sdtPrField;
			}
			set
			{
				this.sdtPrField = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x000113D5 File Offset: 0x0000F5D5
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x000113DD File Offset: 0x0000F5DD
		[global::System.Xml.Serialization.XmlArray(Order = 1)]
		[global::System.Xml.Serialization.XmlArrayItem("rPr", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr> sdtEndPr
		{
			get
			{
				return this.sdtEndPrField;
			}
			set
			{
				this.sdtEndPrField = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x000113E6 File Offset: 0x0000F5E6
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x000113EE File Offset: 0x0000F5EE
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentCell sdtContent
		{
			get
			{
				return this.sdtContentField;
			}
			set
			{
				this.sdtContentField = value;
			}
		}

		// Token: 0x04000520 RID: 1312
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr sdtPrField;

		// Token: 0x04000521 RID: 1313
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr> sdtEndPrField;

		// Token: 0x04000522 RID: 1314
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentCell sdtContentField;
	}
}
