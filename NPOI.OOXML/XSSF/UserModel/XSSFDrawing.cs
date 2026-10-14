using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Dml.Spreadsheet;
using NPOI.OpenXmlFormats.Vml;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;
using NPOI.XSSF.Model;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200007D RID: 125
	public class XSSFDrawing : global::NPOI.POIXMLDocumentPart, global::NPOI.SS.UserModel.IDrawing
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x00016AAB File Offset: 0x00014CAB
		public XSSFDrawing()
		{
			this.drawing = global::NPOI.XSSF.UserModel.XSSFDrawing.NewDrawing();
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00016ACC File Offset: 0x00014CCC
		internal XSSFDrawing(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			global::System.Xml.XmlDocument xmldoc = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(part.GetInputStream());
			this.drawing = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Drawing.Parse(xmldoc, global::NPOI.POIXMLDocumentPart.NamespaceManager);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00016B08 File Offset: 0x00014D08
		public XSSFDrawing(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00016B11 File Offset: 0x00014D11
		private static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Drawing NewDrawing()
		{
			return new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Drawing();
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00016B18 File Offset: 0x00014D18
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Drawing GetCTDrawing()
		{
			return this.drawing;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00016B20 File Offset: 0x00014D20
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.drawing.Save(outputStream);
			outputStream.Close();
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00016B4B File Offset: 0x00014D4B
		public global::NPOI.SS.UserModel.IClientAnchor CreateAnchor(int dx1, int dy1, int dx2, int dy2, int col1, int row1, int col2, int row2)
		{
			return new global::NPOI.XSSF.UserModel.XSSFClientAnchor(dx1, dy1, dx2, dy2, col1, row1, col2, row2);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00016B60 File Offset: 0x00014D60
		public global::NPOI.XSSF.UserModel.XSSFTextBox CreateTextbox(global::NPOI.SS.UserModel.IClientAnchor anchor)
		{
			long num = this.newShapeId();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape ct_Shape = this.CreateTwoCellAnchor(anchor).AddNewSp();
			ct_Shape.Set(global::NPOI.XSSF.UserModel.XSSFSimpleShape.Prototype());
			ct_Shape.nvSpPr.cNvPr.id = (uint)num;
			return new global::NPOI.XSSF.UserModel.XSSFTextBox(this, ct_Shape)
			{
				anchor = (global::NPOI.XSSF.UserModel.XSSFClientAnchor)anchor
			};
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00016BB4 File Offset: 0x00014DB4
		public global::NPOI.SS.UserModel.IPicture CreatePicture(global::NPOI.XSSF.UserModel.XSSFClientAnchor anchor, int pictureIndex)
		{
			global::NPOI.OpenXml4Net.OPC.PackageRelationship pictureReference = this.AddPictureReference(pictureIndex);
			long num = this.newShapeId();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture ct_Picture = this.CreateTwoCellAnchor(anchor).AddNewPic();
			ct_Picture.Set(global::NPOI.XSSF.UserModel.XSSFPicture.Prototype());
			ct_Picture.nvPicPr.cNvPr.id = (uint)num;
			ct_Picture.nvPicPr.cNvPr.name = "Picture " + num.ToString();
			global::NPOI.XSSF.UserModel.XSSFPicture xssfpicture = new global::NPOI.XSSF.UserModel.XSSFPicture(this, ct_Picture);
			xssfpicture.anchor = anchor;
			xssfpicture.SetPictureReference(pictureReference);
			return xssfpicture;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00016C30 File Offset: 0x00014E30
		public global::NPOI.SS.UserModel.IPicture CreatePicture(global::NPOI.SS.UserModel.IClientAnchor anchor, int pictureIndex)
		{
			return this.CreatePicture((global::NPOI.XSSF.UserModel.XSSFClientAnchor)anchor, pictureIndex);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00016C40 File Offset: 0x00014E40
		public global::NPOI.SS.UserModel.IChart CreateChart(global::NPOI.SS.UserModel.IClientAnchor anchor)
		{
			int idx = base.GetPackagePart().Package.GetPartsByContentType(global::NPOI.XSSF.UserModel.XSSFRelation.CHART.ContentType).Count + 1;
			global::NPOI.POIXMLDocumentPart.RelationPart relationPart = base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.CHART, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance(), idx, false);
			global::NPOI.XSSF.UserModel.XSSFChart xssfchart = relationPart.DocumentPart as global::NPOI.XSSF.UserModel.XSSFChart;
			string id = relationPart.Relationship.Id;
			this.CreateGraphicFrame((global::NPOI.XSSF.UserModel.XSSFClientAnchor)anchor).SetChart(xssfchart, id);
			return xssfchart;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00016CAC File Offset: 0x00014EAC
		internal global::NPOI.OpenXml4Net.OPC.PackageRelationship AddPictureReference(int pictureIndex)
		{
			global::NPOI.XSSF.UserModel.XSSFPictureData part = new global::NPOI.XSSF.UserModel.XSSFPictureData(((global::NPOI.XSSF.UserModel.XSSFPictureData)((global::NPOI.XSSF.UserModel.XSSFWorkbook)base.GetParent().GetParent()).GetAllPictures()[pictureIndex]).GetPackagePart());
			return base.AddRelation(null, global::NPOI.XSSF.UserModel.XSSFRelation.IMAGES, part).Relationship;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00016CF8 File Offset: 0x00014EF8
		public global::NPOI.XSSF.UserModel.XSSFSimpleShape CreateSimpleShape(global::NPOI.XSSF.UserModel.XSSFClientAnchor anchor)
		{
			long num = this.newShapeId();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape ct_Shape = this.CreateTwoCellAnchor(anchor).AddNewSp();
			ct_Shape.Set(global::NPOI.XSSF.UserModel.XSSFSimpleShape.Prototype());
			ct_Shape.nvSpPr.cNvPr.id = (uint)num;
			return new global::NPOI.XSSF.UserModel.XSSFSimpleShape(this, ct_Shape)
			{
				anchor = anchor
			};
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00016D44 File Offset: 0x00014F44
		public global::NPOI.XSSF.UserModel.XSSFConnector CreateConnector(global::NPOI.XSSF.UserModel.XSSFClientAnchor anchor)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector ct_Connector = this.CreateTwoCellAnchor(anchor).AddNewCxnSp();
			ct_Connector.Set(global::NPOI.XSSF.UserModel.XSSFConnector.Prototype());
			return new global::NPOI.XSSF.UserModel.XSSFConnector(this, ct_Connector)
			{
				anchor = anchor
			};
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00016D78 File Offset: 0x00014F78
		public global::NPOI.XSSF.UserModel.XSSFShapeGroup CreateGroup(global::NPOI.XSSF.UserModel.XSSFClientAnchor anchor)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape ct_GroupShape = this.CreateTwoCellAnchor(anchor).AddNewGrpSp();
			ct_GroupShape.Set(global::NPOI.XSSF.UserModel.XSSFShapeGroup.Prototype());
			return new global::NPOI.XSSF.UserModel.XSSFShapeGroup(this, ct_GroupShape)
			{
				anchor = anchor
			};
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00016DAC File Offset: 0x00014FAC
		public global::NPOI.SS.UserModel.IComment CreateCellComment(global::NPOI.SS.UserModel.IClientAnchor anchor)
		{
			global::NPOI.XSSF.UserModel.XSSFClientAnchor xssfclientAnchor = (global::NPOI.XSSF.UserModel.XSSFClientAnchor)anchor;
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = (global::NPOI.XSSF.UserModel.XSSFSheet)base.GetParent();
			global::NPOI.XSSF.Model.CommentsTable commentsTable = xssfsheet.GetCommentsTable(true);
			global::NPOI.OpenXmlFormats.Vml.CT_Shape ct_Shape = xssfsheet.GetVMLDrawing(true).newCommentShape();
			if (xssfclientAnchor.IsSet())
			{
				int num = xssfclientAnchor.Dx1 / global::NPOI.Util.Units.EMU_PER_PIXEL;
				int num2 = xssfclientAnchor.Dy1 / global::NPOI.Util.Units.EMU_PER_PIXEL;
				int num3 = xssfclientAnchor.Dx2 / global::NPOI.Util.Units.EMU_PER_PIXEL;
				int num4 = xssfclientAnchor.Dy2 / global::NPOI.Util.Units.EMU_PER_PIXEL;
				string value = string.Concat(new string[]
				{
					xssfclientAnchor.Col1.ToString(),
					", ",
					num.ToString(),
					", ",
					xssfclientAnchor.Row1.ToString(),
					", ",
					num2.ToString(),
					", ",
					xssfclientAnchor.Col2.ToString(),
					", ",
					num3.ToString(),
					", ",
					xssfclientAnchor.Row2.ToString(),
					", ",
					num4.ToString()
				});
				ct_Shape.GetClientDataArray(0).SetAnchorArray(0, value);
			}
			global::NPOI.SS.Util.CellAddress cellAddress = new global::NPOI.SS.Util.CellAddress(xssfclientAnchor.Row1, xssfclientAnchor.Col1);
			if (commentsTable.FindCellComment(cellAddress) != null)
			{
				string str = "Multiple cell comments in one cell are not allowed, cell: ";
				global::NPOI.SS.Util.CellAddress cellAddress2 = cellAddress;
				throw new global::System.ArgumentException(str + ((cellAddress2 != null) ? cellAddress2.ToString() : null));
			}
			return new global::NPOI.XSSF.UserModel.XSSFComment(commentsTable, commentsTable.NewComment(cellAddress), ct_Shape);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00016F34 File Offset: 0x00015134
		private global::NPOI.XSSF.UserModel.XSSFGraphicFrame CreateGraphicFrame(global::NPOI.XSSF.UserModel.XSSFClientAnchor anchor)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame ct_GraphicalObjectFrame = this.CreateTwoCellAnchor(anchor).AddNewGraphicFrame();
			ct_GraphicalObjectFrame.Set(global::NPOI.XSSF.UserModel.XSSFGraphicFrame.Prototype());
			long num = this.numOfGraphicFrames;
			this.numOfGraphicFrames = num + 1L;
			long id = num;
			return new global::NPOI.XSSF.UserModel.XSSFGraphicFrame(this, ct_GraphicalObjectFrame)
			{
				Anchor = anchor,
				Id = id,
				Name = "Diagramm" + id.ToString()
			};
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00016F98 File Offset: 0x00015198
		public global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFChart> GetCharts()
		{
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFChart> list = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFChart>();
			foreach (global::NPOI.POIXMLDocumentPart poixmldocumentPart in base.GetRelations())
			{
				if (poixmldocumentPart is global::NPOI.XSSF.UserModel.XSSFChart)
				{
					list.Add((global::NPOI.XSSF.UserModel.XSSFChart)poixmldocumentPart);
				}
			}
			return list;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00017000 File Offset: 0x00015200
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor CreateTwoCellAnchor(global::NPOI.SS.UserModel.IClientAnchor anchor)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor ct_TwoCellAnchor = this.drawing.AddNewTwoCellAnchor();
			global::NPOI.XSSF.UserModel.XSSFClientAnchor xssfclientAnchor = (global::NPOI.XSSF.UserModel.XSSFClientAnchor)anchor;
			ct_TwoCellAnchor.from = xssfclientAnchor.From;
			ct_TwoCellAnchor.to = xssfclientAnchor.To;
			ct_TwoCellAnchor.AddNewClientData();
			xssfclientAnchor.To = ct_TwoCellAnchor.to;
			xssfclientAnchor.From = ct_TwoCellAnchor.from;
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.ST_EditAs editAs;
			switch (anchor.AnchorType)
			{
			case global::NPOI.SS.UserModel.AnchorType.MoveAndResize:
				editAs = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.ST_EditAs.twoCell;
				goto IL_77;
			case global::NPOI.SS.UserModel.AnchorType.MoveDontResize:
				editAs = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.ST_EditAs.oneCell;
				goto IL_77;
			case global::NPOI.SS.UserModel.AnchorType.DontMoveAndResize:
				editAs = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.ST_EditAs.absolute;
				goto IL_77;
			}
			editAs = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.ST_EditAs.oneCell;
			IL_77:
			ct_TwoCellAnchor.editAs = editAs;
			ct_TwoCellAnchor.editAsSpecified = true;
			return ct_TwoCellAnchor;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00017093 File Offset: 0x00015293
		private long newShapeId()
		{
			return (long)(this.drawing.SizeOfTwoCellAnchorArray() + 1);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000065E4 File Offset: 0x000047E4
		public bool ContainsChart()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000170A4 File Offset: 0x000152A4
		public global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFShape> GetShapes()
		{
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFShape> list = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFShape>();
			foreach (global::NPOI.OpenXmlFormats.Dml.Spreadsheet.IEG_Anchor ieg_Anchor in this.drawing.CellAnchors)
			{
				global::NPOI.XSSF.UserModel.XSSFShape xssfshape = null;
				if (ieg_Anchor.picture != null)
				{
					xssfshape = new global::NPOI.XSSF.UserModel.XSSFPicture(this, ieg_Anchor.picture);
				}
				else if (ieg_Anchor.connector != null)
				{
					xssfshape = new global::NPOI.XSSF.UserModel.XSSFConnector(this, ieg_Anchor.connector);
				}
				else if (ieg_Anchor.groupShape != null)
				{
					xssfshape = new global::NPOI.XSSF.UserModel.XSSFShapeGroup(this, ieg_Anchor.groupShape);
				}
				else if (ieg_Anchor.graphicFrame != null)
				{
					xssfshape = new global::NPOI.XSSF.UserModel.XSSFGraphicFrame(this, ieg_Anchor.graphicFrame);
				}
				else if (ieg_Anchor.sp != null)
				{
					xssfshape = new global::NPOI.XSSF.UserModel.XSSFSimpleShape(this, ieg_Anchor.sp);
				}
				if (xssfshape != null)
				{
					xssfshape.anchor = this.GetAnchorFromIEGAnchor(ieg_Anchor);
					list.Add(xssfshape);
				}
			}
			return list;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0001718C File Offset: 0x0001538C
		private global::NPOI.XSSF.UserModel.XSSFAnchor GetAnchorFromIEGAnchor(global::NPOI.OpenXmlFormats.Dml.Spreadsheet.IEG_Anchor ctAnchor)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker cell = null;
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker cell2 = null;
			if (ctAnchor is global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor)
			{
				cell = ((global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor)ctAnchor).from;
				cell2 = ((global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor)ctAnchor).to;
			}
			else if (ctAnchor is global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_OneCellAnchor)
			{
				cell = ((global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_OneCellAnchor)ctAnchor).from;
			}
			return new global::NPOI.XSSF.UserModel.XSSFClientAnchor(cell, cell2);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000171DC File Offset: 0x000153DC
		private global::NPOI.XSSF.UserModel.XSSFAnchor GetAnchorFromParent(global::System.Xml.XmlNode obj)
		{
			global::System.Xml.XmlNode parentNode = obj.ParentNode;
			global::System.Xml.XmlNode xmlNode = parentNode.SelectSingleNode("xdr:from", global::NPOI.POIXMLDocumentPart.NamespaceManager);
			if (xmlNode == null)
			{
				throw new global::System.IO.InvalidDataException("xdr:from node is missing");
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker cell = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker.Parse(xmlNode, global::NPOI.POIXMLDocumentPart.NamespaceManager);
			global::System.Xml.XmlNode xmlNode2 = parentNode.SelectSingleNode("xdr:to", global::NPOI.POIXMLDocumentPart.NamespaceManager);
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker cell2 = null;
			if (xmlNode2 != null)
			{
				cell2 = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker.Parse(xmlNode2, global::NPOI.POIXMLDocumentPart.NamespaceManager);
			}
			return new global::NPOI.XSSF.UserModel.XSSFClientAnchor(cell, cell2);
		}

		// Token: 0x040002D0 RID: 720
		public static string NAMESPACE_A = global::NPOI.XSSF.UserModel.XSSFRelation.NS_DRAWINGML;

		// Token: 0x040002D1 RID: 721
		public static string NAMESPACE_C = global::NPOI.XSSF.UserModel.XSSFRelation.NS_CHART;

		// Token: 0x040002D2 RID: 722
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Drawing drawing = global::NPOI.XSSF.UserModel.XSSFDrawing.NewDrawing();

		// Token: 0x040002D3 RID: 723
		private long numOfGraphicFrames;
	}
}
