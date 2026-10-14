using System;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Dml.Spreadsheet;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200009D RID: 157
	public class XSSFShapeGroup : global::NPOI.XSSF.UserModel.XSSFShape
	{
		// Token: 0x0600086F RID: 2159 RVA: 0x0001CC38 File Offset: 0x0001AE38
		public XSSFShapeGroup(global::NPOI.XSSF.UserModel.XSSFDrawing drawing, global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape ctGroup)
		{
			this.drawing = drawing;
			this.ctGroup = ctGroup;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0001CC50 File Offset: 0x0001AE50
		internal static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape Prototype()
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape ct_GroupShape = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShapeNonVisual ct_GroupShapeNonVisual = ct_GroupShape.AddNewNvGrpSpPr();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps ct_NonVisualDrawingProps = ct_GroupShapeNonVisual.AddNewCNvPr();
			ct_NonVisualDrawingProps.id = 0U;
			ct_NonVisualDrawingProps.name = "Group 0";
			ct_GroupShapeNonVisual.AddNewCNvGrpSpPr();
			global::NPOI.OpenXmlFormats.Dml.CT_GroupTransform2D ct_GroupTransform2D = ct_GroupShape.AddNewGrpSpPr().AddNewXfrm();
			global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D ct_PositiveSize2D = ct_GroupTransform2D.AddNewExt();
			ct_PositiveSize2D.cx = 0L;
			ct_PositiveSize2D.cy = 0L;
			global::NPOI.OpenXmlFormats.Dml.CT_Point2D ct_Point2D = ct_GroupTransform2D.AddNewOff();
			ct_Point2D.x = 0L;
			ct_Point2D.y = 0L;
			global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D ct_PositiveSize2D2 = ct_GroupTransform2D.AddNewChExt();
			ct_PositiveSize2D2.cx = 0L;
			ct_PositiveSize2D2.cy = 0L;
			global::NPOI.OpenXmlFormats.Dml.CT_Point2D ct_Point2D2 = ct_GroupTransform2D.AddNewChOff();
			ct_Point2D2.x = 0L;
			ct_Point2D2.y = 0L;
			global::NPOI.XSSF.UserModel.XSSFShapeGroup.prototype = ct_GroupShape;
			return global::NPOI.XSSF.UserModel.XSSFShapeGroup.prototype;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0001CCF0 File Offset: 0x0001AEF0
		public global::NPOI.XSSF.UserModel.XSSFTextBox CreateTextbox(global::NPOI.XSSF.UserModel.XSSFChildAnchor anchor)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape ct_Shape = this.ctGroup.AddNewSp();
			ct_Shape.Set(global::NPOI.XSSF.UserModel.XSSFSimpleShape.Prototype());
			global::NPOI.XSSF.UserModel.XSSFTextBox xssftextBox = new global::NPOI.XSSF.UserModel.XSSFTextBox(base.GetDrawing(), ct_Shape);
			xssftextBox.parent = this;
			xssftextBox.anchor = anchor;
			xssftextBox.GetCTShape().spPr.xfrm = anchor.GetCTTransform2D();
			return xssftextBox;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0001CD44 File Offset: 0x0001AF44
		public global::NPOI.XSSF.UserModel.XSSFSimpleShape CreateSimpleShape(global::NPOI.XSSF.UserModel.XSSFChildAnchor anchor)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape ct_Shape = this.ctGroup.AddNewSp();
			ct_Shape.Set(global::NPOI.XSSF.UserModel.XSSFSimpleShape.Prototype());
			global::NPOI.XSSF.UserModel.XSSFSimpleShape xssfsimpleShape = new global::NPOI.XSSF.UserModel.XSSFSimpleShape(base.GetDrawing(), ct_Shape);
			xssfsimpleShape.parent = this;
			xssfsimpleShape.anchor = anchor;
			xssfsimpleShape.GetCTShape().spPr.xfrm = anchor.GetCTTransform2D();
			return xssfsimpleShape;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0001CD98 File Offset: 0x0001AF98
		public global::NPOI.XSSF.UserModel.XSSFConnector CreateConnector(global::NPOI.XSSF.UserModel.XSSFChildAnchor anchor)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector ct_Connector = this.ctGroup.AddNewCxnSp();
			ct_Connector.Set(global::NPOI.XSSF.UserModel.XSSFConnector.Prototype());
			global::NPOI.XSSF.UserModel.XSSFConnector xssfconnector = new global::NPOI.XSSF.UserModel.XSSFConnector(base.GetDrawing(), ct_Connector);
			xssfconnector.parent = this;
			xssfconnector.anchor = anchor;
			xssfconnector.GetCTConnector().spPr.xfrm = anchor.GetCTTransform2D();
			return xssfconnector;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0001CDEC File Offset: 0x0001AFEC
		public global::NPOI.XSSF.UserModel.XSSFPicture CreatePicture(global::NPOI.XSSF.UserModel.XSSFClientAnchor anchor, int pictureIndex)
		{
			global::NPOI.OpenXml4Net.OPC.PackageRelationship pictureReference = base.GetDrawing().AddPictureReference(pictureIndex);
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture ct_Picture = this.ctGroup.AddNewPic();
			ct_Picture.Set(global::NPOI.XSSF.UserModel.XSSFPicture.Prototype());
			global::NPOI.XSSF.UserModel.XSSFPicture xssfpicture = new global::NPOI.XSSF.UserModel.XSSFPicture(base.GetDrawing(), ct_Picture);
			xssfpicture.parent = this;
			xssfpicture.anchor = anchor;
			xssfpicture.SetPictureReference(pictureReference);
			return xssfpicture;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0001CE3E File Offset: 0x0001B03E
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape GetCTGroupShape()
		{
			return this.ctGroup;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0001CE48 File Offset: 0x0001B048
		public void SetCoordinates(int x1, int y1, int x2, int y2)
		{
			global::NPOI.OpenXmlFormats.Dml.CT_GroupTransform2D xfrm = this.ctGroup.grpSpPr.xfrm;
			global::NPOI.OpenXmlFormats.Dml.CT_Point2D off = xfrm.off;
			off.x = (long)x1;
			off.y = (long)y1;
			global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D ext = xfrm.ext;
			ext.cx = (long)x2;
			ext.cy = (long)y2;
			global::NPOI.OpenXmlFormats.Dml.CT_Point2D chOff = xfrm.chOff;
			chOff.x = (long)x1;
			chOff.y = (long)y1;
			global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D chExt = xfrm.chExt;
			chExt.cx = (long)x2;
			chExt.cy = (long)y2;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0001CEBA File Offset: 0x0001B0BA
		protected internal override global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties GetShapeProperties()
		{
			throw new global::System.InvalidOperationException("Not supported for shape group");
		}

		// Token: 0x0400034B RID: 843
		private static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape prototype;

		// Token: 0x0400034C RID: 844
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape ctGroup;
	}
}
