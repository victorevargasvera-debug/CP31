using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000D3 RID: 211
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SdtRun
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x00011070 File Offset: 0x0000F270
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun ct_SdtRun = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun();
			ct_SdtRun.sdtEndPr = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sdtPr")
				{
					ct_SdtRun.sdtPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sdtContent")
				{
					ct_SdtRun.sdtContent = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentRun.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sdtEndPr")
				{
					ct_SdtRun.sdtEndPr.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SdtRun;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00011140 File Offset: 0x0000F340
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

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00011200 File Offset: 0x0000F400
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00011208 File Offset: 0x0000F408
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

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00011211 File Offset: 0x0000F411
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00011219 File Offset: 0x0000F419
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

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00011222 File Offset: 0x0000F422
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x0001122A File Offset: 0x0000F42A
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentRun sdtContent
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

		// Token: 0x0400051D RID: 1309
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr sdtPrField;

		// Token: 0x0400051E RID: 1310
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr> sdtEndPrField;

		// Token: 0x0400051F RID: 1311
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentRun sdtContentField;
	}
}
