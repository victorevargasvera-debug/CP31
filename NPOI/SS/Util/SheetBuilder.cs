using System;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.SS.Util
{
	// Token: 0x0200002B RID: 43
	public class SheetBuilder
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x00007F02 File Offset: 0x00006102
		public SheetBuilder(global::NPOI.SS.UserModel.IWorkbook workbook, object[][] cells)
		{
			this.workbook = workbook;
			this.cells = (object[][])cells.Clone();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00007F22 File Offset: 0x00006122
		public bool GetCreateEmptyCells()
		{
			return this.shouldCreateEmptyCells;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00007F2A File Offset: 0x0000612A
		public global::NPOI.SS.Util.SheetBuilder SetCreateEmptyCells(bool shouldCreateEmptyCells)
		{
			this.shouldCreateEmptyCells = shouldCreateEmptyCells;
			return this;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00007F34 File Offset: 0x00006134
		public global::NPOI.SS.Util.SheetBuilder SetSheetName(string sheetName)
		{
			this.sheetName = sheetName;
			return this;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00007F40 File Offset: 0x00006140
		public global::NPOI.SS.UserModel.ISheet Build()
		{
			global::NPOI.SS.UserModel.ISheet sheet = (this.sheetName == null) ? this.workbook.CreateSheet() : this.workbook.CreateSheet(this.sheetName);
			for (int i = 0; i < this.cells.Length; i++)
			{
				object[] array = this.cells[i];
				global::NPOI.SS.UserModel.IRow row = sheet.CreateRow(i);
				for (int j = 0; j < array.Length; j++)
				{
					object obj = array[j];
					if (obj != null || this.shouldCreateEmptyCells)
					{
						global::NPOI.SS.UserModel.ICell cell = row.CreateCell(j);
						this.SetCellValue(cell, obj);
					}
				}
			}
			return sheet;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00007FD8 File Offset: 0x000061D8
		private void SetCellValue(global::NPOI.SS.UserModel.ICell cell, object value)
		{
			if (value == null || cell == null)
			{
				return;
			}
			if (global::NPOI.Util.Number.IsNumber(value))
			{
				double cellValue;
				double.TryParse(value.ToString(), out cellValue);
				cell.SetCellValue(cellValue);
				return;
			}
			if (value is global::System.DateTime)
			{
				cell.SetCellValue((global::System.DateTime)value);
				return;
			}
			if (this.IsFormulaDefinition(value))
			{
				cell.CellFormula = this.GetFormula(value);
				return;
			}
			cell.SetCellValue(value.ToString());
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00008042 File Offset: 0x00006242
		private bool IsFormulaDefinition(object obj)
		{
			return obj is string && ((string)obj).Length >= 2 && ((string)obj)[0] == '=';
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000806E File Offset: 0x0000626E
		private string GetFormula(object obj)
		{
			return ((string)obj).Substring(1);
		}

		// Token: 0x040000A0 RID: 160
		private global::NPOI.SS.UserModel.IWorkbook workbook;

		// Token: 0x040000A1 RID: 161
		private object[][] cells;

		// Token: 0x040000A2 RID: 162
		private bool shouldCreateEmptyCells;

		// Token: 0x040000A3 RID: 163
		private string sheetName;
	}
}
