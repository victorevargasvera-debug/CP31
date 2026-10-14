using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x0200036A RID: 874
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_GraphicalObjectFrameNonVisual
	{
		// Token: 0x060022B7 RID: 8887 RVA: 0x0005A8F0 File Offset: 0x00058AF0
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrameNonVisual Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrameNonVisual ct_GraphicalObjectFrameNonVisual = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrameNonVisual();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cNvPr")
				{
					ct_GraphicalObjectFrameNonVisual.cNvPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cNvGraphicFramePr")
				{
					ct_GraphicalObjectFrameNonVisual.cNvGraphicFramePr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualGraphicFrameProperties.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GraphicalObjectFrameNonVisual;
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0005A990 File Offset: 0x00058B90
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			sw.Write(">");
			if (this.cNvPr != null)
			{
				this.cNvPr.Write(sw, "cNvPr");
			}
			if (this.cNvGraphicFramePr != null)
			{
				this.cNvGraphicFramePr.Write(sw, "cNvGraphicFramePr");
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x0005A9FC File Offset: 0x00058BFC
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps AddNewCNvPr()
		{
			this.cNvPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps();
			return this.cNvPrField;
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x0005AA0F File Offset: 0x00058C0F
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualGraphicFrameProperties AddNewCNvGraphicFramePr()
		{
			this.cNvGraphicFramePrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualGraphicFrameProperties();
			return this.cNvGraphicFramePrField;
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x0005AA22 File Offset: 0x00058C22
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x0005AA2A File Offset: 0x00058C2A
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

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x0005AA33 File Offset: 0x00058C33
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x0005AA3B File Offset: 0x00058C3B
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualGraphicFrameProperties cNvGraphicFramePr
		{
			get
			{
				return this.cNvGraphicFramePrField;
			}
			set
			{
				this.cNvGraphicFramePrField = value;
			}
		}

		// Token: 0x04001A30 RID: 6704
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x04001A31 RID: 6705
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualGraphicFrameProperties cNvGraphicFramePrField;
	}
}
