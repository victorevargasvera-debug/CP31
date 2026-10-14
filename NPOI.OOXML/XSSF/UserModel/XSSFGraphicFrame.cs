using System;
using NPOI.OpenXmlFormats;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Dml.Spreadsheet;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000089 RID: 137
	public class XSSFGraphicFrame : global::NPOI.XSSF.UserModel.XSSFShape
	{
		// Token: 0x06000716 RID: 1814 RVA: 0x00018354 File Offset: 0x00016554
		public XSSFGraphicFrame(global::NPOI.XSSF.UserModel.XSSFDrawing Drawing, global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame ctGraphicFrame)
		{
			this.drawing = Drawing;
			this.graphicFrame = ctGraphicFrame;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0001836A File Offset: 0x0001656A
		internal global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame GetCTGraphicalObjectFrame()
		{
			return this.graphicFrame;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00018374 File Offset: 0x00016574
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame Prototype()
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame ct_GraphicalObjectFrame = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrameNonVisual ct_GraphicalObjectFrameNonVisual = ct_GraphicalObjectFrame.AddNewNvGraphicFramePr();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps ct_NonVisualDrawingProps = ct_GraphicalObjectFrameNonVisual.AddNewCNvPr();
			ct_NonVisualDrawingProps.id = 0U;
			ct_NonVisualDrawingProps.name = "Diagramm 1";
			ct_GraphicalObjectFrameNonVisual.AddNewCNvGraphicFramePr();
			global::NPOI.OpenXmlFormats.Dml.CT_Transform2D ct_Transform2D = ct_GraphicalObjectFrame.AddNewXfrm();
			global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D ct_PositiveSize2D = ct_Transform2D.AddNewExt();
			global::NPOI.OpenXmlFormats.Dml.CT_Point2D ct_Point2D = ct_Transform2D.AddNewOff();
			ct_PositiveSize2D.cx = 0L;
			ct_PositiveSize2D.cy = 0L;
			ct_Point2D.x = 0L;
			ct_Point2D.y = 0L;
			ct_GraphicalObjectFrame.AddNewGraphic();
			global::NPOI.XSSF.UserModel.XSSFGraphicFrame.prototype = ct_GraphicalObjectFrame;
			return global::NPOI.XSSF.UserModel.XSSFGraphicFrame.prototype;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x000183EB File Offset: 0x000165EB
		public void SetMacro(string macro)
		{
			this.graphicFrame.macro = macro;
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x000183F9 File Offset: 0x000165F9
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x00018406 File Offset: 0x00016606
		public string Name
		{
			get
			{
				return this.GetNonVisualProperties().name;
			}
			set
			{
				this.GetNonVisualProperties().name = value;
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00018414 File Offset: 0x00016614
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps GetNonVisualProperties()
		{
			return this.graphicFrame.nvGraphicFramePr.cNvPr;
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00018426 File Offset: 0x00016626
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x0001842E File Offset: 0x0001662E
		public global::NPOI.XSSF.UserModel.XSSFClientAnchor Anchor
		{
			get
			{
				return this.anchor;
			}
			set
			{
				this.anchor = value;
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00018438 File Offset: 0x00016638
		internal void SetChart(global::NPOI.XSSF.UserModel.XSSFChart chart, string relId)
		{
			global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData data = this.graphicFrame.graphic.AddNewGraphicData();
			this.AppendChartElement(data, relId);
			chart.SetGraphicFrame(this);
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00018465 File Offset: 0x00016665
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x0001847D File Offset: 0x0001667D
		public long Id
		{
			get
			{
				return (long)((ulong)this.graphicFrame.nvGraphicFramePr.cNvPr.id);
			}
			set
			{
				this.graphicFrame.nvGraphicFramePr.cNvPr.id = (uint)value;
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00018498 File Offset: 0x00016698
		private void AppendChartElement(global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData data, string id)
		{
			string namespaceURI = global::NPOI.OpenXmlFormats.ST_RelationshipId.NamespaceURI;
			string namespace_C = global::NPOI.XSSF.UserModel.XSSFDrawing.NAMESPACE_C;
			string el = string.Format("<c:chart xmlns:c=\"{1}\" xmlns:r=\"{2}\" r:id=\"{0}\"/>", id, namespace_C, namespaceURI);
			data.AddChartElement(el);
			data.uri = namespace_C;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00004FF8 File Offset: 0x000031F8
		protected internal override global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties GetShapeProperties()
		{
			return null;
		}

		// Token: 0x040002E3 RID: 739
		private static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame prototype;

		// Token: 0x040002E4 RID: 740
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame graphicFrame;

		// Token: 0x040002E5 RID: 741
		private new global::NPOI.XSSF.UserModel.XSSFClientAnchor anchor;
	}
}
