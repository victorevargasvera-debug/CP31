using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000364 RID: 868
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_GroupShape
	{
		// Token: 0x06002265 RID: 8805 RVA: 0x00059C01 File Offset: 0x00057E01
		public CT_GroupShape()
		{
			this.pictures = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture>();
			this.shapes = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape>();
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00059C1F File Offset: 0x00057E1F
		public void Set(global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape groupShape)
		{
			this.grpSpPrField = groupShape.grpSpPr;
			this.nvGrpSpPrField = groupShape.nvGrpSpPr;
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00059C39 File Offset: 0x00057E39
		public global::NPOI.OpenXmlFormats.Dml.CT_GroupShapeProperties AddNewGrpSpPr()
		{
			this.grpSpPrField = new global::NPOI.OpenXmlFormats.Dml.CT_GroupShapeProperties();
			return this.grpSpPrField;
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x00059C4C File Offset: 0x00057E4C
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShapeNonVisual AddNewNvGrpSpPr()
		{
			this.nvGrpSpPrField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShapeNonVisual();
			return this.nvGrpSpPrField;
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x00059C5F File Offset: 0x00057E5F
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector AddNewCxnSp()
		{
			this.connectorField = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector();
			return this.connectorField;
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x00059C74 File Offset: 0x00057E74
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape AddNewSp()
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape ct_Shape = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape();
			this.shapes.Add(ct_Shape);
			return ct_Shape;
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x00059C94 File Offset: 0x00057E94
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture AddNewPic()
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture ct_Picture = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture();
			this.pictures.Add(ct_Picture);
			return ct_Picture;
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x00059CB4 File Offset: 0x00057EB4
		// (set) Token: 0x0600226D RID: 8813 RVA: 0x00059CBC File Offset: 0x00057EBC
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShapeNonVisual nvGrpSpPr
		{
			get
			{
				return this.nvGrpSpPrField;
			}
			set
			{
				this.nvGrpSpPrField = value;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x00059CC5 File Offset: 0x00057EC5
		// (set) Token: 0x0600226F RID: 8815 RVA: 0x00059CCD File Offset: 0x00057ECD
		public global::NPOI.OpenXmlFormats.Dml.CT_GroupShapeProperties grpSpPr
		{
			get
			{
				return this.grpSpPrField;
			}
			set
			{
				this.grpSpPrField = value;
			}
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00059CD8 File Offset: 0x00057ED8
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape ct_GroupShape = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "nvGrpSpPr")
				{
					ct_GroupShape.nvGrpSpPr = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShapeNonVisual.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "grpSpPr")
				{
					ct_GroupShape.grpSpPr = global::NPOI.OpenXmlFormats.Dml.CT_GroupShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pic")
				{
					global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture item = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture.Parse(xmlNode, namespaceManager);
					ct_GroupShape.pictures.Add(item);
				}
				else if (xmlNode.LocalName == "sp")
				{
					global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape item2 = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape.Parse(xmlNode, namespaceManager);
					ct_GroupShape.shapes.Add(item2);
				}
			}
			return ct_GroupShape;
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00059DD4 File Offset: 0x00057FD4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			sw.Write(">");
			if (this.nvGrpSpPr != null)
			{
				this.nvGrpSpPr.Write(sw, "xdr:nvGrpSpPr");
			}
			if (this.grpSpPr != null)
			{
				this.grpSpPr.Write(sw, "xdr:grpSpPr");
			}
			if (this.shapes.Count > 0)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape ct_Shape in this.shapes)
				{
					ct_Shape.Write(sw, "sp");
				}
			}
			if (this.pictures.Count > 0)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture ct_Picture in this.pictures)
				{
					ct_Picture.Write(sw, "pic");
				}
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x04001A15 RID: 6677
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupShapeProperties grpSpPrField;

		// Token: 0x04001A16 RID: 6678
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShapeNonVisual nvGrpSpPrField;

		// Token: 0x04001A17 RID: 6679
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector connectorField;

		// Token: 0x04001A18 RID: 6680
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture> pictures;

		// Token: 0x04001A19 RID: 6681
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape> shapes;
	}
}
