using System;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.HSSF.Util
{
	// Token: 0x0200033F RID: 831
	public class HSSFRegionUtil
	{
		// Token: 0x060018BB RID: 6331 RVA: 0x0000253E File Offset: 0x0000073E
		private HSSFRegionUtil()
		{
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0004BBC8 File Offset: 0x00049DC8
		public static void SetBorderLeft(global::NPOI.SS.UserModel.BorderStyle border, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			int firstRow = region.FirstRow;
			int lastRow = region.LastRow;
			int firstColumn = region.FirstColumn;
			global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter(workbook, "borderLeft", (int)border);
			for (int i = firstRow; i <= lastRow; i++)
			{
				cellPropertySetter.SetProperty(global::NPOI.HSSF.Util.HSSFCellUtil.GetRow(i, sheet), firstColumn);
			}
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0004BC10 File Offset: 0x00049E10
		public static void SetLeftBorderColor(int color, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			int firstRow = region.FirstRow;
			int lastRow = region.LastRow;
			int firstColumn = region.FirstColumn;
			global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter(workbook, "leftBorderColor", color);
			for (int i = firstRow; i <= lastRow; i++)
			{
				cellPropertySetter.SetProperty(global::NPOI.HSSF.Util.HSSFCellUtil.GetRow(i, sheet), firstColumn);
			}
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0004BC58 File Offset: 0x00049E58
		public static void SetBorderRight(global::NPOI.SS.UserModel.BorderStyle border, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			int firstRow = region.FirstRow;
			int lastRow = region.LastRow;
			int lastColumn = region.LastColumn;
			global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter(workbook, "borderRight", (int)border);
			for (int i = firstRow; i <= lastRow; i++)
			{
				cellPropertySetter.SetProperty(global::NPOI.HSSF.Util.HSSFCellUtil.GetRow(i, sheet), lastColumn);
			}
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0004BCA0 File Offset: 0x00049EA0
		public static void SetRightBorderColor(int color, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			int firstRow = region.FirstRow;
			int lastRow = region.LastRow;
			int lastColumn = region.LastColumn;
			global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter(workbook, "rightBorderColor", color);
			for (int i = firstRow; i <= lastRow; i++)
			{
				cellPropertySetter.SetProperty(global::NPOI.HSSF.Util.HSSFCellUtil.GetRow(i, sheet), lastColumn);
			}
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0004BCE8 File Offset: 0x00049EE8
		public static void SetBorderBottom(global::NPOI.SS.UserModel.BorderStyle border, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			int firstColumn = region.FirstColumn;
			int lastColumn = region.LastColumn;
			int lastRow = region.LastRow;
			global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter(workbook, "borderBottom", (int)border);
			global::NPOI.SS.UserModel.IRow row = global::NPOI.HSSF.Util.HSSFCellUtil.GetRow(lastRow, sheet);
			for (int i = firstColumn; i <= lastColumn; i++)
			{
				cellPropertySetter.SetProperty(row, i);
			}
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0004BD30 File Offset: 0x00049F30
		public static void SetBottomBorderColor(int color, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			int firstColumn = region.FirstColumn;
			int lastColumn = region.LastColumn;
			int lastRow = region.LastRow;
			global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter(workbook, "bottomBorderColor", color);
			global::NPOI.SS.UserModel.IRow row = global::NPOI.HSSF.Util.HSSFCellUtil.GetRow(lastRow, sheet);
			for (int i = firstColumn; i <= lastColumn; i++)
			{
				cellPropertySetter.SetProperty(row, i);
			}
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0004BD78 File Offset: 0x00049F78
		public static void SetBorderTop(global::NPOI.SS.UserModel.BorderStyle border, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			int firstColumn = region.FirstColumn;
			int lastColumn = region.LastColumn;
			int firstRow = region.FirstRow;
			global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter(workbook, "borderTop", (int)border);
			global::NPOI.SS.UserModel.IRow row = global::NPOI.HSSF.Util.HSSFCellUtil.GetRow(firstRow, sheet);
			for (int i = firstColumn; i <= lastColumn; i++)
			{
				cellPropertySetter.SetProperty(row, i);
			}
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0004BDC0 File Offset: 0x00049FC0
		public static void SetTopBorderColor(int color, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			int firstColumn = region.FirstColumn;
			int lastColumn = region.LastColumn;
			int firstRow = region.FirstRow;
			global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.HSSF.Util.HSSFRegionUtil.CellPropertySetter(workbook, "topBorderColor", color);
			global::NPOI.SS.UserModel.IRow row = global::NPOI.HSSF.Util.HSSFCellUtil.GetRow(firstRow, sheet);
			for (int i = firstColumn; i <= lastColumn; i++)
			{
				cellPropertySetter.SetProperty(row, i);
			}
		}

		// Token: 0x020005C8 RID: 1480
		private class CellPropertySetter
		{
			// Token: 0x060034FD RID: 13565 RVA: 0x000A4BBD File Offset: 0x000A2DBD
			public CellPropertySetter(global::NPOI.HSSF.UserModel.HSSFWorkbook workbook, string propertyName, int value)
			{
				this._workbook = workbook;
				this._propertyName = propertyName;
				this._propertyValue = (short)value;
			}

			// Token: 0x060034FE RID: 13566 RVA: 0x000A4BDB File Offset: 0x000A2DDB
			public void SetProperty(global::NPOI.SS.UserModel.IRow row, int column)
			{
				global::NPOI.HSSF.Util.HSSFCellUtil.SetCellStyleProperty(global::NPOI.HSSF.Util.HSSFCellUtil.GetCell(row, column), this._workbook, this._propertyName, this._propertyValue);
			}

			// Token: 0x04001980 RID: 6528
			private global::NPOI.HSSF.UserModel.HSSFWorkbook _workbook;

			// Token: 0x04001981 RID: 6529
			private string _propertyName;

			// Token: 0x04001982 RID: 6530
			private short _propertyValue;
		}
	}
}
