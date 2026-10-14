using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000D2 RID: 210
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SdtBlock
	{
		// Token: 0x060005F5 RID: 1525 RVA: 0x00010E54 File Offset: 0x0000F054
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock ct_SdtBlock = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock();
			ct_SdtBlock.sdtEndPr = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sdtPr")
				{
					ct_SdtBlock.sdtPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sdtContent")
				{
					ct_SdtBlock.sdtContent = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentBlock.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sdtEndPr")
				{
					ct_SdtBlock.sdtEndPr.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SdtBlock;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00010F24 File Offset: 0x0000F124
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

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00010FE4 File Offset: 0x0000F1E4
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00010FEC File Offset: 0x0000F1EC
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

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00010FF5 File Offset: 0x0000F1F5
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00010FFD File Offset: 0x0000F1FD
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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00011006 File Offset: 0x0000F206
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x0001100E File Offset: 0x0000F20E
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentBlock sdtContent
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

		// Token: 0x060005FD RID: 1533 RVA: 0x00011017 File Offset: 0x0000F217
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr AddNewSdtPr()
		{
			if (this.sdtPrField == null)
			{
				this.sdtPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr();
			}
			return this.sdtPrField;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00011034 File Offset: 0x0000F234
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtEndPr AddNewSdtEndPr()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtEndPr ct_SdtEndPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtEndPr();
			this.sdtEndPrField = ct_SdtEndPr.Items;
			return ct_SdtEndPr;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00011054 File Offset: 0x0000F254
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentBlock AddNewSdtContent()
		{
			if (this.sdtContentField == null)
			{
				this.sdtContentField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentBlock();
			}
			return this.sdtContentField;
		}

		// Token: 0x0400051A RID: 1306
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr sdtPrField;

		// Token: 0x0400051B RID: 1307
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr> sdtEndPrField;

		// Token: 0x0400051C RID: 1308
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentBlock sdtContentField;
	}
}
