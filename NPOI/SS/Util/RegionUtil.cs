using System;
using NPOI.SS.UserModel;

namespace NPOI.SS.Util
{
	// Token: 0x0200002A RID: 42
	public class RegionUtil
	{
		// Token: 0x060001AF RID: 431 RVA: 0x0000253E File Offset: 0x0000073E
		private RegionUtil()
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00007CC4 File Offset: 0x00005EC4
		public static void SetBorderLeft(int border, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.SS.UserModel.ISheet sheet)
		{
			int firstRow = region.FirstRow;
			int lastRow = region.LastRow;
			int firstColumn = region.FirstColumn;
			global::NPOI.SS.Util.RegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.SS.Util.RegionUtil.CellPropertySetter("borderLeft", border);
			for (int i = firstRow; i <= lastRow; i++)
			{
				cellPropertySetter.SetProperty(global::NPOI.SS.Util.CellUtil.GetRow(i, sheet), firstColumn);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00007D0C File Offset: 0x00005F0C
		public static void SetLeftBorderColor(int color, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.SS.UserModel.ISheet sheet)
		{
			int firstRow = region.FirstRow;
			int lastRow = region.LastRow;
			int firstColumn = region.FirstColumn;
			global::NPOI.SS.Util.RegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.SS.Util.RegionUtil.CellPropertySetter("leftBorderColor", color);
			for (int i = firstRow; i <= lastRow; i++)
			{
				cellPropertySetter.SetProperty(global::NPOI.SS.Util.CellUtil.GetRow(i, sheet), firstColumn);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00007D54 File Offset: 0x00005F54
		public static void SetBorderRight(int border, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.SS.UserModel.ISheet sheet)
		{
			int firstRow = region.FirstRow;
			int lastRow = region.LastRow;
			int lastColumn = region.LastColumn;
			global::NPOI.SS.Util.RegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.SS.Util.RegionUtil.CellPropertySetter("borderRight", border);
			for (int i = firstRow; i <= lastRow; i++)
			{
				cellPropertySetter.SetProperty(global::NPOI.SS.Util.CellUtil.GetRow(i, sheet), lastColumn);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00007D9C File Offset: 0x00005F9C
		public static void SetRightBorderColor(int color, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.SS.UserModel.ISheet sheet)
		{
			int firstRow = region.FirstRow;
			int lastRow = region.LastRow;
			int lastColumn = region.LastColumn;
			global::NPOI.SS.Util.RegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.SS.Util.RegionUtil.CellPropertySetter("rightBorderColor", color);
			for (int i = firstRow; i <= lastRow; i++)
			{
				cellPropertySetter.SetProperty(global::NPOI.SS.Util.CellUtil.GetRow(i, sheet), lastColumn);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00007DE4 File Offset: 0x00005FE4
		public static void SetBorderBottom(int border, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.SS.UserModel.ISheet sheet)
		{
			int firstColumn = region.FirstColumn;
			int lastColumn = region.LastColumn;
			int lastRow = region.LastRow;
			global::NPOI.SS.Util.RegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.SS.Util.RegionUtil.CellPropertySetter("borderBottom", border);
			global::NPOI.SS.UserModel.IRow row = global::NPOI.SS.Util.CellUtil.GetRow(lastRow, sheet);
			for (int i = firstColumn; i <= lastColumn; i++)
			{
				cellPropertySetter.SetProperty(row, i);
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00007E2C File Offset: 0x0000602C
		public static void SetBottomBorderColor(int color, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.SS.UserModel.ISheet sheet)
		{
			int firstColumn = region.FirstColumn;
			int lastColumn = region.LastColumn;
			int lastRow = region.LastRow;
			global::NPOI.SS.Util.RegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.SS.Util.RegionUtil.CellPropertySetter("bottomBorderColor", color);
			global::NPOI.SS.UserModel.IRow row = global::NPOI.SS.Util.CellUtil.GetRow(lastRow, sheet);
			for (int i = firstColumn; i <= lastColumn; i++)
			{
				cellPropertySetter.SetProperty(row, i);
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00007E74 File Offset: 0x00006074
		public static void SetBorderTop(int border, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.SS.UserModel.ISheet sheet)
		{
			int firstColumn = region.FirstColumn;
			int lastColumn = region.LastColumn;
			int firstRow = region.FirstRow;
			global::NPOI.SS.Util.RegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.SS.Util.RegionUtil.CellPropertySetter("borderTop", border);
			global::NPOI.SS.UserModel.IRow row = global::NPOI.SS.Util.CellUtil.GetRow(firstRow, sheet);
			for (int i = firstColumn; i <= lastColumn; i++)
			{
				cellPropertySetter.SetProperty(row, i);
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00007EBC File Offset: 0x000060BC
		public static void SetTopBorderColor(int color, global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.SS.UserModel.ISheet sheet)
		{
			int firstColumn = region.FirstColumn;
			int lastColumn = region.LastColumn;
			int firstRow = region.FirstRow;
			global::NPOI.SS.Util.RegionUtil.CellPropertySetter cellPropertySetter = new global::NPOI.SS.Util.RegionUtil.CellPropertySetter("topBorderColor", color);
			global::NPOI.SS.UserModel.IRow row = global::NPOI.SS.Util.CellUtil.GetRow(firstRow, sheet);
			for (int i = firstColumn; i <= lastColumn; i++)
			{
				cellPropertySetter.SetProperty(row, i);
			}
		}

		// Token: 0x02000556 RID: 1366
		private class CellPropertySetter
		{
			// Token: 0x06003370 RID: 13168 RVA: 0x000A114D File Offset: 0x0009F34D
			public CellPropertySetter(string propertyName, int value)
			{
				this._propertyName = propertyName;
				this._propertyValue = (short)value;
			}

			// Token: 0x06003371 RID: 13169 RVA: 0x000A1164 File Offset: 0x0009F364
			public void SetProperty(global::NPOI.SS.UserModel.IRow row, int column)
			{
				global::NPOI.SS.Util.CellUtil.SetCellStyleProperty(global::NPOI.SS.Util.CellUtil.GetCell(row, column), this._propertyName, this._propertyValue);
			}

			// Token: 0x0400186F RID: 6255
			private string _propertyName;

			// Token: 0x04001870 RID: 6256
			private short _propertyValue;
		}
	}
}
