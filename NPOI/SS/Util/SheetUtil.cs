using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using NPOI.SS.UserModel;

namespace NPOI.SS.Util
{
	// Token: 0x0200002D RID: 45
	public class SheetUtil
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x000080BC File Offset: 0x000062BC
		public static global::NPOI.SS.UserModel.IRow CopyRow(global::NPOI.SS.UserModel.ISheet sourceSheet, int sourceRowIndex, global::NPOI.SS.UserModel.ISheet targetSheet, int targetRowIndex)
		{
			global::NPOI.SS.UserModel.IRow row = targetSheet.GetRow(targetRowIndex);
			global::NPOI.SS.UserModel.IRow row2 = sourceSheet.GetRow(sourceRowIndex);
			if (row != null)
			{
				targetSheet.RemoveRow(row);
			}
			row = targetSheet.CreateRow(targetRowIndex);
			if (row2 == null)
			{
				throw new global::System.ArgumentNullException("source row doesn't exist");
			}
			for (int i = (int)row2.FirstCellNum; i < (int)row2.LastCellNum; i++)
			{
				global::NPOI.SS.UserModel.ICell cell = row2.GetCell(i);
				if (cell != null)
				{
					global::NPOI.SS.UserModel.ICell cell2 = row.CreateCell(i);
					if (cell.CellStyle != null)
					{
						cell2.CellStyle = cell.CellStyle;
					}
					if (cell.CellComment != null)
					{
						cell2.CellComment = cell.CellComment;
					}
					if (cell.Hyperlink != null)
					{
						cell2.Hyperlink = cell.Hyperlink;
					}
					cell2.SetCellType(cell.CellType);
					switch (cell.CellType)
					{
					case global::NPOI.SS.UserModel.CellType.Numeric:
						cell2.SetCellValue(cell.NumericCellValue);
						break;
					case global::NPOI.SS.UserModel.CellType.String:
						cell2.SetCellValue(cell.RichStringCellValue);
						break;
					case global::NPOI.SS.UserModel.CellType.Formula:
						cell2.SetCellFormula(cell.CellFormula);
						break;
					case global::NPOI.SS.UserModel.CellType.Blank:
						cell2.SetCellValue(cell.StringCellValue);
						break;
					case global::NPOI.SS.UserModel.CellType.Boolean:
						cell2.SetCellValue(cell.BooleanCellValue);
						break;
					case global::NPOI.SS.UserModel.CellType.Error:
						cell2.SetCellErrorValue(cell.ErrorCellValue);
						break;
					}
				}
			}
			for (int j = 0; j < sourceSheet.NumMergedRegions; j++)
			{
				global::NPOI.SS.Util.CellRangeAddress mergedRegion = sourceSheet.GetMergedRegion(j);
				if (mergedRegion != null && mergedRegion.FirstRow == row2.RowNum)
				{
					global::NPOI.SS.Util.CellRangeAddress region = new global::NPOI.SS.Util.CellRangeAddress(row.RowNum, row.RowNum + (mergedRegion.LastRow - mergedRegion.FirstRow), mergedRegion.FirstColumn, mergedRegion.LastColumn);
					targetSheet.AddMergedRegion(region);
				}
			}
			return row;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00008268 File Offset: 0x00006468
		public static global::NPOI.SS.UserModel.IRow CopyRow(global::NPOI.SS.UserModel.ISheet sheet, int sourceRowIndex, int targetRowIndex)
		{
			if (sourceRowIndex == targetRowIndex)
			{
				throw new global::System.ArgumentException("sourceIndex and targetIndex cannot be same");
			}
			global::NPOI.SS.UserModel.IRow row = sheet.GetRow(targetRowIndex);
			global::NPOI.SS.UserModel.IRow row2 = sheet.GetRow(sourceRowIndex);
			if (row != null)
			{
				sheet.ShiftRows(targetRowIndex, sheet.LastRowNum, 1);
			}
			row = sheet.CreateRow(targetRowIndex);
			row.Height = row2.Height;
			for (int i = (int)row2.FirstCellNum; i < (int)row2.LastCellNum; i++)
			{
				global::NPOI.SS.UserModel.ICell cell = row2.GetCell(i);
				if (cell != null)
				{
					global::NPOI.SS.UserModel.ICell cell2 = row.CreateCell(i);
					if (cell.CellStyle != null)
					{
						cell2.CellStyle = cell.CellStyle;
					}
					if (cell.CellComment != null)
					{
						cell2.CellComment = cell.CellComment;
					}
					if (cell.Hyperlink != null)
					{
						cell2.Hyperlink = cell.Hyperlink;
					}
					cell2.SetCellType(cell.CellType);
					switch (cell.CellType)
					{
					case global::NPOI.SS.UserModel.CellType.Numeric:
						cell2.SetCellValue(cell.NumericCellValue);
						break;
					case global::NPOI.SS.UserModel.CellType.String:
						cell2.SetCellValue(cell.RichStringCellValue);
						break;
					case global::NPOI.SS.UserModel.CellType.Formula:
						cell2.SetCellFormula(cell.CellFormula);
						break;
					case global::NPOI.SS.UserModel.CellType.Blank:
						cell2.SetCellValue(cell.StringCellValue);
						break;
					case global::NPOI.SS.UserModel.CellType.Boolean:
						cell2.SetCellValue(cell.BooleanCellValue);
						break;
					case global::NPOI.SS.UserModel.CellType.Error:
						cell2.SetCellErrorValue(cell.ErrorCellValue);
						break;
					}
				}
			}
			for (int j = 0; j < sheet.NumMergedRegions; j++)
			{
				global::NPOI.SS.Util.CellRangeAddress mergedRegion = sheet.GetMergedRegion(j);
				if (mergedRegion != null && mergedRegion.FirstRow == row2.RowNum)
				{
					global::NPOI.SS.Util.CellRangeAddress region = new global::NPOI.SS.Util.CellRangeAddress(row.RowNum, row.RowNum + (mergedRegion.LastRow - mergedRegion.FirstRow), mergedRegion.FirstColumn, mergedRegion.LastColumn);
					sheet.AddMergedRegion(region);
				}
			}
			return row;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00008428 File Offset: 0x00006628
		public static double GetCellWidth(global::NPOI.SS.UserModel.ICell cell, int defaultCharWidth, global::NPOI.SS.UserModel.DataFormatter formatter, bool useMergedCells)
		{
			global::NPOI.SS.UserModel.ISheet sheet = cell.Sheet;
			global::NPOI.SS.UserModel.IWorkbook workbook = sheet.Workbook;
			global::NPOI.SS.UserModel.IRow row = cell.Row;
			int columnIndex = cell.ColumnIndex;
			int colspan = 1;
			for (int i = 0; i < sheet.NumMergedRegions; i++)
			{
				global::NPOI.SS.Util.CellRangeAddress mergedRegion = sheet.GetMergedRegion(i);
				if (global::NPOI.SS.Util.SheetUtil.ContainsCell(mergedRegion, row.RowNum, columnIndex))
				{
					if (!useMergedCells)
					{
						return -1.0;
					}
					cell = row.GetCell(mergedRegion.FirstColumn);
					colspan = 1 + mergedRegion.LastColumn - mergedRegion.FirstColumn;
				}
			}
			global::NPOI.SS.UserModel.ICellStyle cellStyle = cell.CellStyle;
			global::NPOI.SS.UserModel.CellType cellType = cell.CellType;
			global::System.Drawing.Font windowsFont = global::NPOI.SS.Util.SheetUtil.IFont2Font(workbook.GetFontAt(0));
			if (cellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				cellType = cell.CachedFormulaResultType;
			}
			global::NPOI.SS.UserModel.IFont fontAt = workbook.GetFontAt(cellStyle.FontIndex);
			double num = -1.0;
			using (global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap(1, 1))
			{
				using (global::System.Drawing.Graphics graphics = global::System.Drawing.Graphics.FromImage(bitmap))
				{
					if (cellType == global::NPOI.SS.UserModel.CellType.String)
					{
						global::NPOI.SS.UserModel.IRichTextString richStringCellValue = cell.RichStringCellValue;
						string[] array = richStringCellValue.String.Split("\n".ToCharArray());
						for (int j = 0; j < array.Length; j++)
						{
							string str = array[j] + global::NPOI.SS.Util.SheetUtil.defaultChar.ToString();
							windowsFont = global::NPOI.SS.Util.SheetUtil.IFont2Font(fontAt);
							int numFormattingRuns = richStringCellValue.NumFormattingRuns;
							num = global::NPOI.SS.Util.SheetUtil.GetCellWidth(defaultCharWidth, colspan, cellStyle, num, str, graphics, windowsFont, cell);
						}
					}
					else
					{
						string text = null;
						if (cellType == global::NPOI.SS.UserModel.CellType.Numeric)
						{
							try
							{
								text = formatter.FormatCellValue(cell, global::NPOI.SS.Util.SheetUtil.dummyEvaluator);
								goto IL_195;
							}
							catch (global::System.Exception)
							{
								text = cell.NumericCellValue.ToString();
								goto IL_195;
							}
						}
						if (cellType == global::NPOI.SS.UserModel.CellType.Boolean)
						{
							text = cell.BooleanCellValue.ToString().ToUpper();
						}
						IL_195:
						if (text != null)
						{
							string str2 = text + global::NPOI.SS.Util.SheetUtil.defaultChar.ToString();
							windowsFont = global::NPOI.SS.Util.SheetUtil.IFont2Font(fontAt);
							num = global::NPOI.SS.Util.SheetUtil.GetCellWidth(defaultCharWidth, colspan, cellStyle, num, str2, graphics, windowsFont, cell);
						}
					}
				}
			}
			return num;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00008668 File Offset: 0x00006868
		private static double GetCellWidth(int defaultCharWidth, int colspan, global::NPOI.SS.UserModel.ICellStyle style, double width, string str, global::System.Drawing.Graphics g, global::System.Drawing.Font windowsFont, global::NPOI.SS.UserModel.ICell cell)
		{
			double num4;
			if (style.Rotation != 0)
			{
				double num = (double)style.Rotation * 2.0 * 3.141592653589793 / 360.0;
				global::System.Drawing.SizeF sizeF = g.MeasureString(str, windowsFont);
				double num2 = global::System.Math.Abs((double)sizeF.Height * global::System.Math.Sin(num));
				double num3 = global::System.Math.Abs((double)sizeF.Width * global::System.Math.Cos(num));
				num4 = global::System.Math.Round(num2 + num3, 0, global::System.MidpointRounding.ToEven);
			}
			else
			{
				num4 = global::System.Math.Round((double)g.MeasureString(str, windowsFont, int.MaxValue, global::System.Drawing.StringFormat.GenericTypographic).Width, 0, global::System.MidpointRounding.ToEven);
			}
			width = global::System.Math.Max(width, num4 / (double)colspan / (double)defaultCharWidth + (double)cell.CellStyle.Indention);
			return width;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00008729 File Offset: 0x00006929
		public static double GetColumnWidth(global::NPOI.SS.UserModel.ISheet sheet, int column, bool useMergedCells)
		{
			return global::NPOI.SS.Util.SheetUtil.GetColumnWidth(sheet, column, useMergedCells, sheet.FirstRowNum, sheet.LastRowNum, 0);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00008740 File Offset: 0x00006940
		public static double GetColumnWidth(global::NPOI.SS.UserModel.ISheet sheet, int column, bool useMergedCells, int firstRow, int lastRow, int maxRows = 0)
		{
			global::NPOI.SS.UserModel.DataFormatter formatter = new global::NPOI.SS.UserModel.DataFormatter();
			int defaultCharWidth = global::NPOI.SS.Util.SheetUtil.GetDefaultCharWidth(sheet.Workbook);
			if (maxRows > 0 && lastRow - firstRow > maxRows)
			{
				lastRow = firstRow + maxRows;
			}
			double num = -1.0;
			for (int i = firstRow; i <= lastRow; i++)
			{
				global::NPOI.SS.UserModel.IRow row = sheet.GetRow(i);
				if (row != null)
				{
					double columnWidthForRow = global::NPOI.SS.Util.SheetUtil.GetColumnWidthForRow(row, column, defaultCharWidth, formatter, useMergedCells);
					num = global::System.Math.Max(num, columnWidthForRow);
				}
			}
			return num;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000087B0 File Offset: 0x000069B0
		public static int GetDefaultCharWidth(global::NPOI.SS.UserModel.IWorkbook wb)
		{
			global::NPOI.SS.UserModel.IFont fontAt = wb.GetFontAt(0);
			int result = 0;
			global::System.Drawing.Font font = global::NPOI.SS.Util.SheetUtil.IFont2Font(fontAt);
			using (global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap(1, 1))
			{
				using (global::System.Drawing.Graphics graphics = global::System.Drawing.Graphics.FromImage(bitmap))
				{
					graphics.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.AntiAlias;
					result = (int)graphics.MeasureString(new string(global::NPOI.SS.Util.SheetUtil.defaultChar, 1), font, int.MaxValue, global::System.Drawing.StringFormat.GenericTypographic).Width;
				}
			}
			return result;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000883C File Offset: 0x00006A3C
		private static double GetColumnWidthForRow(global::NPOI.SS.UserModel.IRow row, int column, int defaultCharWidth, global::NPOI.SS.UserModel.DataFormatter formatter, bool useMergedCells)
		{
			if (row == null)
			{
				return -1.0;
			}
			global::NPOI.SS.UserModel.ICell cell = row.GetCell(column);
			if (cell == null)
			{
				return -1.0;
			}
			return global::NPOI.SS.Util.SheetUtil.GetCellWidth(cell, defaultCharWidth, formatter, useMergedCells);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00008875 File Offset: 0x00006A75
		public static bool CanComputeColumnWidth(global::NPOI.SS.UserModel.IFont font)
		{
			return true;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00008878 File Offset: 0x00006A78
		internal static global::System.Drawing.Font IFont2Font(global::NPOI.SS.UserModel.IFont font1)
		{
			global::System.Drawing.FontStyle fontStyle = global::System.Drawing.FontStyle.Regular;
			if (font1.IsBold)
			{
				fontStyle |= global::System.Drawing.FontStyle.Bold;
			}
			if (font1.IsItalic)
			{
				fontStyle |= global::System.Drawing.FontStyle.Italic;
			}
			if (font1.Underline == global::NPOI.SS.UserModel.FontUnderlineType.Single)
			{
				fontStyle |= global::System.Drawing.FontStyle.Underline;
			}
			return new global::System.Drawing.Font(font1.FontName, (float)font1.FontHeightInPoints, fontStyle, global::System.Drawing.GraphicsUnit.Point);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000088C0 File Offset: 0x00006AC0
		[global::System.Obsolete("deprecated 3.15 beta 2. Use {@link CellRangeAddressBase#isInRange(int, int)}.")]
		public static bool ContainsCell(global::NPOI.SS.Util.CellRangeAddress cr, int rowIx, int colIx)
		{
			return cr.IsInRange(rowIx, colIx);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000088CC File Offset: 0x00006ACC
		public static string GetUniqueSheetName(global::NPOI.SS.UserModel.IWorkbook wb, string srcName)
		{
			if (wb.GetSheetIndex(srcName) == -1)
			{
				return srcName;
			}
			int num = 2;
			string text = srcName;
			int num2 = srcName.LastIndexOf('(');
			if (num2 > 0 && srcName.EndsWith(")"))
			{
				string text2 = srcName.Substring(num2 + 1, srcName.Length - num2 - 2);
				try
				{
					num = int.Parse(text2.Trim());
					num++;
					text = srcName.Substring(0, num2).Trim();
				}
				catch (global::System.FormatException)
				{
				}
			}
			string text4;
			do
			{
				string text3 = num++.ToString();
				if (text.Length + text3.Length + 2 < 31)
				{
					text4 = text + " (" + text3 + ")";
				}
				else
				{
					text4 = text.Substring(0, 31 - text3.Length - 2) + "(" + text3 + ")";
				}
			}
			while (wb.GetSheetIndex(text4) != -1);
			return text4;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000089B8 File Offset: 0x00006BB8
		public static global::NPOI.SS.UserModel.ICell GetCellWithMerges(global::NPOI.SS.UserModel.ISheet sheet, int rowIx, int colIx)
		{
			global::NPOI.SS.UserModel.IRow row = sheet.GetRow(rowIx);
			if (row != null)
			{
				global::NPOI.SS.UserModel.ICell cell = row.GetCell(colIx);
				if (cell != null)
				{
					return cell;
				}
			}
			for (int i = 0; i < sheet.NumMergedRegions; i++)
			{
				global::NPOI.SS.Util.CellRangeAddress mergedRegion = sheet.GetMergedRegion(i);
				if (mergedRegion.IsInRange(rowIx, colIx))
				{
					row = sheet.GetRow(mergedRegion.FirstRow);
					if (row != null)
					{
						return row.GetCell(mergedRegion.FirstColumn);
					}
				}
			}
			return null;
		}

		// Token: 0x040000A5 RID: 165
		private static char defaultChar = '0';

		// Token: 0x040000A6 RID: 166
		private static global::NPOI.SS.UserModel.IFormulaEvaluator dummyEvaluator = new global::NPOI.SS.Util.SheetUtil.DummyEvaluator();

		// Token: 0x02000557 RID: 1367
		public class DummyEvaluator : global::NPOI.SS.UserModel.IFormulaEvaluator
		{
			// Token: 0x06003372 RID: 13170 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void ClearAllCachedResultValues()
			{
			}

			// Token: 0x06003373 RID: 13171 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void NotifySetFormula(global::NPOI.SS.UserModel.ICell cell)
			{
			}

			// Token: 0x06003374 RID: 13172 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void NotifyDeleteCell(global::NPOI.SS.UserModel.ICell cell)
			{
			}

			// Token: 0x06003375 RID: 13173 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void NotifyUpdateCell(global::NPOI.SS.UserModel.ICell cell)
			{
			}

			// Token: 0x06003376 RID: 13174 RVA: 0x0002BE0C File Offset: 0x0002A00C
			public global::NPOI.SS.UserModel.CellValue Evaluate(global::NPOI.SS.UserModel.ICell cell)
			{
				return null;
			}

			// Token: 0x06003377 RID: 13175 RVA: 0x0002BE0C File Offset: 0x0002A00C
			public global::NPOI.SS.UserModel.ICell EvaluateInCell(global::NPOI.SS.UserModel.ICell cell)
			{
				return null;
			}

			// Token: 0x17000D84 RID: 3460
			// (get) Token: 0x06003378 RID: 13176 RVA: 0x000A1183 File Offset: 0x0009F383
			// (set) Token: 0x06003379 RID: 13177 RVA: 0x000A118B File Offset: 0x0009F38B
			public bool IgnoreMissingWorkbooks { get; set; }

			// Token: 0x0600337A RID: 13178 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void SetupReferencedWorkbooks(global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.UserModel.IFormulaEvaluator> workbooks)
			{
			}

			// Token: 0x0600337B RID: 13179 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void EvaluateAll()
			{
			}

			// Token: 0x0600337C RID: 13180 RVA: 0x000A1194 File Offset: 0x0009F394
			public global::NPOI.SS.UserModel.CellType EvaluateFormulaCell(global::NPOI.SS.UserModel.ICell cell)
			{
				return cell.CachedFormulaResultType;
			}

			// Token: 0x17000D85 RID: 3461
			// (get) Token: 0x0600337D RID: 13181 RVA: 0x00008C75 File Offset: 0x00006E75
			// (set) Token: 0x0600337E RID: 13182 RVA: 0x00008C75 File Offset: 0x00006E75
			public bool DebugEvaluationOutputForNextEval
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
		}
	}
}
