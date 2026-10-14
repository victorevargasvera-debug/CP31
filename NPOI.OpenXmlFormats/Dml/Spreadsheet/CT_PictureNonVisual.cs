using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000367 RID: 871
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_PictureNonVisual
	{
		// Token: 0x06002294 RID: 8852 RVA: 0x0005A39C File Offset: 0x0005859C
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_PictureNonVisual Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_PictureNonVisual ct_PictureNonVisual = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_PictureNonVisual();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cNvPr")
				{
					ct_PictureNonVisual.cNvPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cNvPicPr")
				{
					ct_PictureNonVisual.cNvPicPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualPictureProperties.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PictureNonVisual;
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0005A43C File Offset: 0x0005863C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			sw.Write(">");
			if (this.cNvPr != null)
			{
				this.cNvPr.Write(sw, "cNvPr");
			}
			if (this.cNvPicPr != null)
			{
				this.cNvPicPr.Write(sw, "cNvPicPr");
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x0005A4A8 File Offset: 0x000586A8
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps AddNewCNvPr()
		{
			this.cNvPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps();
			return this.cNvPrField;
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0005A4BB File Offset: 0x000586BB
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualPictureProperties AddNewCNvPicPr()
		{
			this.cNvPicPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualPictureProperties();
			return this.cNvPicPrField;
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x0005A4CE File Offset: 0x000586CE
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x0005A4D6 File Offset: 0x000586D6
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps cNvPr
		{
			get
			{
				return this.cNvPrField;
			}
			set
			{
				this.cNvPrField = value;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x0005A4DF File Offset: 0x000586DF
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x0005A4E7 File Offset: 0x000586E7
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualPictureProperties cNvPicPr
		{
			get
			{
				return this.cNvPicPrField;
			}
			set
			{
				this.cNvPicPrField = value;
			}
		}

		// Token: 0x04001A25 RID: 6693
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps cNvPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps();

		// Token: 0x04001A26 RID: 6694
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualPictureProperties cNvPicPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualPictureProperties();
	}
}
