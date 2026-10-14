using System;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Dml.Spreadsheet;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000075 RID: 117
	public class XSSFConnector : global::NPOI.XSSF.UserModel.XSSFShape
	{
		// Token: 0x060005BF RID: 1471 RVA: 0x00015CB2 File Offset: 0x00013EB2
		public XSSFConnector(global::NPOI.XSSF.UserModel.XSSFDrawing drawing, global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector ctShape)
		{
			this.drawing = drawing;
			this.ctShape = ctShape;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00015CC8 File Offset: 0x00013EC8
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector Prototype()
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector ct_Connector = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ConnectorNonVisual ct_ConnectorNonVisual = ct_Connector.AddNewNvCxnSpPr();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps ct_NonVisualDrawingProps = ct_ConnectorNonVisual.AddNewCNvPr();
			ct_NonVisualDrawingProps.id = 1U;
			ct_NonVisualDrawingProps.name = "Shape 1";
			ct_ConnectorNonVisual.AddNewCNvCxnSpPr();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties ct_ShapeProperties = ct_Connector.AddNewSpPr();
			global::NPOI.OpenXmlFormats.Dml.CT_Transform2D ct_Transform2D = ct_ShapeProperties.AddNewXfrm();
			global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D ct_PositiveSize2D = ct_Transform2D.AddNewExt();
			ct_PositiveSize2D.cx = 0L;
			ct_PositiveSize2D.cy = 0L;
			global::NPOI.OpenXmlFormats.Dml.CT_Point2D ct_Point2D = ct_Transform2D.AddNewOff();
			ct_Point2D.x = 0L;
			ct_Point2D.y = 0L;
			global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D ct_PresetGeometry2D = ct_ShapeProperties.AddNewPrstGeom();
			ct_PresetGeometry2D.prst = global::NPOI.OpenXmlFormats.Dml.ST_ShapeType.line;
			ct_PresetGeometry2D.AddNewAvLst();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle ct_ShapeStyle = ct_Connector.AddNewStyle();
			ct_ShapeStyle.AddNewLnRef().AddNewSchemeClr().val = global::NPOI.OpenXmlFormats.Dml.ST_SchemeColorVal.accent1;
			ct_ShapeStyle.lnRef.idx = 1U;
			global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference ct_StyleMatrixReference = ct_ShapeStyle.AddNewFillRef();
			ct_StyleMatrixReference.idx = 0U;
			ct_StyleMatrixReference.AddNewSchemeClr().val = global::NPOI.OpenXmlFormats.Dml.ST_SchemeColorVal.accent1;
			global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference ct_StyleMatrixReference2 = ct_ShapeStyle.AddNewEffectRef();
			ct_StyleMatrixReference2.idx = 0U;
			ct_StyleMatrixReference2.AddNewSchemeClr().val = global::NPOI.OpenXmlFormats.Dml.ST_SchemeColorVal.accent1;
			global::NPOI.OpenXmlFormats.Dml.CT_FontReference ct_FontReference = ct_ShapeStyle.AddNewFontRef();
			ct_FontReference.idx = global::NPOI.OpenXmlFormats.Dml.ST_FontCollectionIndex.minor;
			ct_FontReference.AddNewSchemeClr().val = global::NPOI.OpenXmlFormats.Dml.ST_SchemeColorVal.tx1;
			global::NPOI.XSSF.UserModel.XSSFConnector.prototype = ct_Connector;
			return global::NPOI.XSSF.UserModel.XSSFConnector.prototype;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00015DB8 File Offset: 0x00013FB8
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector GetCTConnector()
		{
			return this.ctShape;
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00015DC0 File Offset: 0x00013FC0
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00015DD7 File Offset: 0x00013FD7
		public global::NPOI.OpenXmlFormats.Dml.ST_ShapeType ShapeType
		{
			get
			{
				return this.ctShape.spPr.prstGeom.prst;
			}
			set
			{
				this.ctShape.spPr.prstGeom.prst = value;
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00015DEF File Offset: 0x00013FEF
		protected internal override global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties GetShapeProperties()
		{
			return this.ctShape.spPr;
		}

		// Token: 0x040002BA RID: 698
		private static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector prototype;

		// Token: 0x040002BB RID: 699
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector ctShape;
	}
}
