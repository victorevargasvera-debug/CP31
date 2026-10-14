using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000D6 RID: 214
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SdtDocPart
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x00011560 File Offset: 0x0000F760
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDocPart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDocPart ct_SdtDocPart = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDocPart();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "docPartGallery")
				{
					ct_SdtDocPart.docPartGallery = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "docPartCategory")
				{
					ct_SdtDocPart.docPartCategory = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "docPartUnique")
				{
					ct_SdtDocPart.docPartUnique = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_SdtDocPart;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00011620 File Offset: 0x0000F820
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.docPartGallery != null)
			{
				this.docPartGallery.Write(sw, "docPartGallery");
			}
			if (this.docPartCategory != null)
			{
				this.docPartCategory.Write(sw, "docPartCategory");
			}
			if (this.docPartUnique != null)
			{
				this.docPartUnique.Write(sw, "docPartUnique");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x000116A5 File Offset: 0x0000F8A5
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x000116AD File Offset: 0x0000F8AD
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String docPartGallery
		{
			get
			{
				return this.docPartGalleryField;
			}
			set
			{
				this.docPartGalleryField = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x000116B6 File Offset: 0x0000F8B6
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x000116BE File Offset: 0x0000F8BE
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String docPartCategory
		{
			get
			{
				return this.docPartCategoryField;
			}
			set
			{
				this.docPartCategoryField = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x000116C7 File Offset: 0x0000F8C7
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x000116CF File Offset: 0x0000F8CF
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff docPartUnique
		{
			get
			{
				return this.docPartUniqueField;
			}
			set
			{
				this.docPartUniqueField = value;
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x000116D8 File Offset: 0x0000F8D8
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String AddNewDocPartGallery()
		{
			if (this.docPartGalleryField == null)
			{
				this.docPartGalleryField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String();
			}
			return this.docPartGalleryField;
		}

		// Token: 0x04000525 RID: 1317
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String docPartGalleryField;

		// Token: 0x04000526 RID: 1318
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String docPartCategoryField;

		// Token: 0x04000527 RID: 1319
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff docPartUniqueField;
	}
}
