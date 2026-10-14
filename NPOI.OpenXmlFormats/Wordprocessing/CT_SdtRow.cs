using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000E6 RID: 230
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SdtRow
	{
		// Token: 0x0600068C RID: 1676 RVA: 0x000150E0 File Offset: 0x000132E0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRow Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRow ct_SdtRow = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRow();
			ct_SdtRow.sdtEndPr = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sdtPr")
				{
					ct_SdtRow.sdtPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sdtContent")
				{
					ct_SdtRow.sdtContent = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentRow.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sdtEndPr")
				{
					ct_SdtRow.sdtEndPr.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SdtRow;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000151B0 File Offset: 0x000133B0
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

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00015270 File Offset: 0x00013470
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00015278 File Offset: 0x00013478
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

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00015281 File Offset: 0x00013481
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00015289 File Offset: 0x00013489
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

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00015292 File Offset: 0x00013492
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x0001529A File Offset: 0x0001349A
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentRow sdtContent
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

		// Token: 0x040005A3 RID: 1443
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr sdtPrField;

		// Token: 0x040005A4 RID: 1444
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr> sdtEndPrField;

		// Token: 0x040005A5 RID: 1445
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentRow sdtContentField;
	}
}
