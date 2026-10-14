using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.Model;

namespace NPOI.XSSF.UserModel.Helpers
{
	// Token: 0x020000AF RID: 175
	public class XSSFSingleXmlCell
	{
		// Token: 0x06000B26 RID: 2854 RVA: 0x0002A460 File Offset: 0x00028660
		public XSSFSingleXmlCell(global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCell SingleXmlCell, global::NPOI.XSSF.Model.SingleXmlCells parent)
		{
			this.SingleXmlCell = SingleXmlCell;
			this.parent = parent;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0002A478 File Offset: 0x00028678
		public global::NPOI.SS.UserModel.ICell GetReferencedCell()
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(this.SingleXmlCell.r);
			global::NPOI.SS.UserModel.IRow row = this.parent.GetXSSFSheet().GetRow(cellReference.Row);
			if (row == null)
			{
				row = this.parent.GetXSSFSheet().CreateRow(cellReference.Row);
			}
			global::NPOI.SS.UserModel.ICell cell = row.GetCell((int)cellReference.Col);
			if (cell == null)
			{
				cell = row.CreateCell((int)cellReference.Col);
			}
			return cell;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0002A4E7 File Offset: 0x000286E7
		public string GetXpath()
		{
			return this.SingleXmlCell.xmlCellPr.xmlPr.xpath;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0002A4FE File Offset: 0x000286FE
		public long GetMapId()
		{
			return (long)((ulong)this.SingleXmlCell.xmlCellPr.xmlPr.mapId);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0002A516 File Offset: 0x00028716
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_XmlDataType GetXmlDataType()
		{
			return this.SingleXmlCell.xmlCellPr.xmlPr.xmlDataType;
		}

		// Token: 0x040003AB RID: 939
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCell SingleXmlCell;

		// Token: 0x040003AC RID: 940
		private global::NPOI.XSSF.Model.SingleXmlCells parent;
	}
}
