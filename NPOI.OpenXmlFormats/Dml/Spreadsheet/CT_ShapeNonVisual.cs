using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000362 RID: 866
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_ShapeNonVisual
	{
		// Token: 0x06002253 RID: 8787 RVA: 0x0005993E File Offset: 0x00057B3E
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps AddNewCNvPr()
		{
			this.cNvPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps();
			return this.cNvPrField;
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00059951 File Offset: 0x00057B51
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingShapeProps AddNewCNvSpPr()
		{
			this.cNvSpPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingShapeProps();
			return this.cNvSpPrField;
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x00059964 File Offset: 0x00057B64
		// (set) Token: 0x06002256 RID: 8790 RVA: 0x0005996C File Offset: 0x00057B6C
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

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x00059975 File Offset: 0x00057B75
		// (set) Token: 0x06002258 RID: 8792 RVA: 0x0005997D File Offset: 0x00057B7D
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingShapeProps cNvSpPr
		{
			get
			{
				return this.cNvSpPrField;
			}
			set
			{
				this.cNvSpPrField = value;
			}
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00059988 File Offset: 0x00057B88
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeNonVisual Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeNonVisual ct_ShapeNonVisual = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeNonVisual();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cNvPr")
				{
					ct_ShapeNonVisual.cNvPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cNvSpPr")
				{
					ct_ShapeNonVisual.cNvSpPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingShapeProps.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ShapeNonVisual;
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00059A28 File Offset: 0x00057C28
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			sw.Write(">");
			if (this.cNvPr != null)
			{
				this.cNvPr.Write(sw, "cNvPr");
			}
			if (this.cNvSpPr != null)
			{
				this.cNvSpPr.Write(sw, "cNvSpPr");
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x04001A10 RID: 6672
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps cNvPrField;

		// Token: 0x04001A11 RID: 6673
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingShapeProps cNvSpPrField;
	}
}
