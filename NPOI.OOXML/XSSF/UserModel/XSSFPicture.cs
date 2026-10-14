using System;
using System.Drawing;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Dml.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000092 RID: 146
	public class XSSFPicture : global::NPOI.XSSF.UserModel.XSSFShape, global::NPOI.SS.UserModel.IPicture
	{
		// Token: 0x0600077F RID: 1919 RVA: 0x00019405 File Offset: 0x00017605
		public XSSFPicture(global::NPOI.XSSF.UserModel.XSSFDrawing drawing, global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture ctPicture)
		{
			this.drawing = drawing;
			this.ctPicture = ctPicture;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0001941B File Offset: 0x0001761B
		public XSSFPicture(global::NPOI.XSSF.UserModel.XSSFDrawing drawing, global::System.Xml.XmlNode ctPicture)
		{
			this.drawing = drawing;
			this.ctPicture = global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture.Parse(ctPicture, global::NPOI.POIXMLDocumentPart.NamespaceManager);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0001943C File Offset: 0x0001763C
		internal static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture Prototype()
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture ct_Picture = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_PictureNonVisual ct_PictureNonVisual = ct_Picture.AddNewNvPicPr();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps ct_NonVisualDrawingProps = ct_PictureNonVisual.AddNewCNvPr();
			ct_NonVisualDrawingProps.id = 1U;
			ct_NonVisualDrawingProps.name = "Picture 1";
			ct_NonVisualDrawingProps.descr = "Picture";
			ct_PictureNonVisual.AddNewCNvPicPr().AddNewPicLocks().noChangeAspect = true;
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties ct_BlipFillProperties = ct_Picture.AddNewBlipFill();
			ct_BlipFillProperties.AddNewBlip().embed = "";
			ct_BlipFillProperties.AddNewStretch().AddNewFillRect();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties ct_ShapeProperties = ct_Picture.AddNewSpPr();
			global::NPOI.OpenXmlFormats.Dml.CT_Transform2D ct_Transform2D = ct_ShapeProperties.AddNewXfrm();
			global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D ct_PositiveSize2D = ct_Transform2D.AddNewExt();
			ct_PositiveSize2D.cx = 0L;
			ct_PositiveSize2D.cy = 0L;
			global::NPOI.OpenXmlFormats.Dml.CT_Point2D ct_Point2D = ct_Transform2D.AddNewOff();
			ct_Point2D.x = 0L;
			ct_Point2D.y = 0L;
			global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D ct_PresetGeometry2D = ct_ShapeProperties.AddNewPrstGeom();
			ct_PresetGeometry2D.prst = global::NPOI.OpenXmlFormats.Dml.ST_ShapeType.rect;
			ct_PresetGeometry2D.AddNewAvLst();
			global::NPOI.XSSF.UserModel.XSSFPicture.prototype = ct_Picture;
			return global::NPOI.XSSF.UserModel.XSSFPicture.prototype;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x000194F8 File Offset: 0x000176F8
		internal void SetPictureReference(global::NPOI.OpenXml4Net.OPC.PackageRelationship rel)
		{
			this.ctPicture.blipFill.blip.embed = rel.Id;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00019515 File Offset: 0x00017715
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture GetCTPicture()
		{
			return this.ctPicture;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0001951D File Offset: 0x0001771D
		public void Resize()
		{
			this.Resize(double.MaxValue);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0001952E File Offset: 0x0001772E
		public void Resize(double scale)
		{
			this.Resize(scale, scale);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00019538 File Offset: 0x00017738
		public void Resize(double scaleX, double scaleY)
		{
			global::NPOI.XSSF.UserModel.XSSFClientAnchor xssfclientAnchor = (global::NPOI.XSSF.UserModel.XSSFClientAnchor)base.GetAnchor();
			global::NPOI.SS.UserModel.IClientAnchor preferredSize = this.GetPreferredSize(scaleX, scaleY);
			int row = ((global::NPOI.SS.UserModel.IClientAnchor)xssfclientAnchor).Row1 + (preferredSize.Row2 - preferredSize.Row1);
			int col = ((global::NPOI.SS.UserModel.IClientAnchor)xssfclientAnchor).Col1 + (preferredSize.Col2 - preferredSize.Col1);
			((global::NPOI.SS.UserModel.IClientAnchor)xssfclientAnchor).Col2 = col;
			((global::NPOI.SS.UserModel.IClientAnchor)xssfclientAnchor).Dx2 = preferredSize.Dx2;
			((global::NPOI.SS.UserModel.IClientAnchor)xssfclientAnchor).Row2 = row;
			((global::NPOI.SS.UserModel.IClientAnchor)xssfclientAnchor).Dy2 = preferredSize.Dy2;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x000195A8 File Offset: 0x000177A8
		public global::NPOI.SS.UserModel.IClientAnchor GetPreferredSize()
		{
			return this.GetPreferredSize(1.0);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000195B9 File Offset: 0x000177B9
		public global::NPOI.SS.UserModel.IClientAnchor GetPreferredSize(double scale)
		{
			return this.GetPreferredSize(scale, scale);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000195C4 File Offset: 0x000177C4
		public global::NPOI.SS.UserModel.IClientAnchor GetPreferredSize(double scaleX, double scaleY)
		{
			global::System.Drawing.Size size = global::NPOI.SS.Util.ImageUtils.SetPreferredSize(this, scaleX, scaleY);
			global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D ext = this.ctPicture.spPr.xfrm.ext;
			ext.cx = (long)size.Width;
			ext.cy = (long)size.Height;
			return this.ClientAnchor;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00019610 File Offset: 0x00017810
		protected static global::System.Drawing.Size GetImageDimension(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.SS.UserModel.PictureType type)
		{
			global::System.Drawing.Size result;
			try
			{
				result = global::NPOI.SS.Util.ImageUtils.GetImageDimension(part.GetInputStream());
			}
			catch (global::System.IO.IOException exception)
			{
				global::NPOI.XSSF.UserModel.XSSFPicture.logger.Log(5, exception);
				result = default(global::System.Drawing.Size);
			}
			return result;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00019658 File Offset: 0x00017858
		public global::System.Drawing.Size GetImageDimension()
		{
			global::NPOI.XSSF.UserModel.XSSFPictureData xssfpictureData = this.PictureData as global::NPOI.XSSF.UserModel.XSSFPictureData;
			return global::NPOI.XSSF.UserModel.XSSFPicture.GetImageDimension(xssfpictureData.GetPackagePart(), xssfpictureData.PictureType);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00019682 File Offset: 0x00017882
		protected internal override global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties GetShapeProperties()
		{
			return this.ctPicture.spPr;
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x000065E4 File Offset: 0x000047E4
		public new int CountOfAllChildren
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x000065E4 File Offset: 0x000047E4
		public new int FillColor
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x0001968F File Offset: 0x0001788F
		public new global::NPOI.SS.UserModel.LineStyle LineStyle
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				base.LineStyle = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x000065E4 File Offset: 0x000047E4
		public new int LineStyleColor
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00019698 File Offset: 0x00017898
		public new int LineWidth
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				base.LineWidth = (double)value;
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000065E4 File Offset: 0x000047E4
		public new void SetLineStyleColor(int lineStyleColor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x000196A4 File Offset: 0x000178A4
		public global::NPOI.SS.UserModel.IPictureData PictureData
		{
			get
			{
				string embed = this.ctPicture.blipFill.blip.embed;
				return (global::NPOI.XSSF.UserModel.XSSFPictureData)base.GetDrawing().GetRelationById(embed);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x000196D8 File Offset: 0x000178D8
		public global::NPOI.SS.UserModel.IClientAnchor ClientAnchor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFAnchor anchor = base.GetAnchor();
				if (!(anchor is global::NPOI.XSSF.UserModel.XSSFClientAnchor))
				{
					return null;
				}
				return (global::NPOI.XSSF.UserModel.XSSFClientAnchor)anchor;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x000196FC File Offset: 0x000178FC
		public global::NPOI.SS.UserModel.ISheet Sheet
		{
			get
			{
				return (global::NPOI.XSSF.UserModel.XSSFSheet)base.GetDrawing().GetParent();
			}
		}

		// Token: 0x040002F9 RID: 761
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.XSSF.UserModel.XSSFPicture));

		// Token: 0x040002FA RID: 762
		private static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture prototype = null;

		// Token: 0x040002FB RID: 763
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture ctPicture;
	}
}
