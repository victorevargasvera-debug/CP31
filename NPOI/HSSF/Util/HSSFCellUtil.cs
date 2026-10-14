using System;
using System.Collections.Generic;
using NPOI.HSSF.Record;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.HSSF.Util
{
	// Token: 0x0200033E RID: 830
	[global::System.Obsolete("deprecated 3.15 beta2. Removed in 3.17. Use {@link org.apache.poi.ss.util.CellUtil} instead.")]
	public class HSSFCellUtil
	{
		// Token: 0x060018B0 RID: 6320 RVA: 0x0000253E File Offset: 0x0000073E
		private HSSFCellUtil()
		{
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0004B82C File Offset: 0x00049A2C
		[global::System.Obsolete("@deprecated 3.15 beta2. Removed in 3.17. Use {@link org.apache.poi.ss.util.CellUtil#getRow} instead.")]
		public static global::NPOI.SS.UserModel.IRow GetRow(int rowIndex, global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			return (global::NPOI.HSSF.UserModel.HSSFRow)global::NPOI.SS.Util.CellUtil.GetRow(rowIndex, sheet);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0004B83A File Offset: 0x00049A3A
		[global::System.Obsolete("@deprecated 3.15 beta2. Removed in 3.17. Use {@link org.apache.poi.ss.util.CellUtil#getCell} instead.")]
		public static global::NPOI.SS.UserModel.ICell GetCell(global::NPOI.SS.UserModel.IRow row, int columnIndex)
		{
			return (global::NPOI.HSSF.UserModel.HSSFCell)global::NPOI.SS.Util.CellUtil.GetCell(row, columnIndex);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0004B848 File Offset: 0x00049A48
		[global::System.Obsolete("@deprecated 3.15 beta2. Removed in 3.17. Use {@link org.apache.poi.ss.util.CellUtil#createCell} instead.")]
		public static global::NPOI.SS.UserModel.ICell CreateCell(global::NPOI.SS.UserModel.IRow row, int column, string value, global::NPOI.HSSF.UserModel.HSSFCellStyle style)
		{
			return (global::NPOI.HSSF.UserModel.HSSFCell)global::NPOI.SS.Util.CellUtil.CreateCell(row, column, value, style);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0004B858 File Offset: 0x00049A58
		[global::System.Obsolete("@deprecated 3.15 beta2. Removed in 3.17. Use {@link org.apache.poi.ss.util.CellUtil#createCell} instead.")]
		public static global::NPOI.SS.UserModel.ICell CreateCell(global::NPOI.SS.UserModel.IRow row, int column, string value)
		{
			return global::NPOI.HSSF.Util.HSSFCellUtil.CreateCell(row, column, value, null);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0004B863 File Offset: 0x00049A63
		[global::System.Obsolete("@deprecated 3.15 beta2. Removed in 3.17. Use {@link org.apache.poi.ss.util.CellUtil#setAlignment} instead.")]
		public static void SetAlignment(global::NPOI.SS.UserModel.ICell cell, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook, short align)
		{
			global::NPOI.SS.Util.CellUtil.SetAlignment(cell, (global::NPOI.SS.UserModel.HorizontalAlignment)align);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0004B86C File Offset: 0x00049A6C
		[global::System.Obsolete("@deprecated 3.15 beta2. Removed in 3.17. Use {@link org.apache.poi.ss.util.CellUtil#setFont} instead.")]
		public static void SetFont(global::NPOI.SS.UserModel.ICell cell, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook, global::NPOI.HSSF.UserModel.HSSFFont font)
		{
			global::NPOI.SS.Util.CellUtil.SetFont(cell, font);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0004B875 File Offset: 0x00049A75
		[global::System.Obsolete("@deprecated 3.15 beta2. Removed in 3.17. Use {@link org.apache.poi.ss.util.CellUtil#setCellStyleProperty} instead.")]
		public static void SetCellStyleProperty(global::NPOI.SS.UserModel.ICell cell, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook, string propertyName, object propertyValue)
		{
			global::NPOI.SS.Util.CellUtil.SetCellStyleProperty(cell, propertyName, propertyValue);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0004B87F File Offset: 0x00049A7F
		[global::System.Obsolete("@deprecated 3.15 beta2. Removed in 3.17. Use {@link org.apache.poi.ss.util.CellUtil#translateUnicodeValues} instead.")]
		public static global::NPOI.SS.UserModel.ICell TranslateUnicodeValues(global::NPOI.SS.UserModel.ICell cell)
		{
			global::NPOI.SS.Util.CellUtil.TranslateUnicodeValues(cell);
			return cell;
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0004B88C File Offset: 0x00049A8C
		private static void RemapCellStyle(global::NPOI.HSSF.UserModel.HSSFCellStyle stylish, global::System.Collections.Generic.Dictionary<short, short> paletteMap)
		{
			if (paletteMap.ContainsKey(stylish.BorderDiagonalColor))
			{
				stylish.BorderDiagonalColor = paletteMap[stylish.BorderDiagonalColor];
			}
			if (paletteMap.ContainsKey(stylish.BottomBorderColor))
			{
				stylish.BottomBorderColor = paletteMap[stylish.BottomBorderColor];
			}
			if (paletteMap.ContainsKey(stylish.FillBackgroundColor))
			{
				stylish.FillBackgroundColor = paletteMap[stylish.FillBackgroundColor];
			}
			if (paletteMap.ContainsKey(stylish.FillForegroundColor))
			{
				stylish.FillForegroundColor = paletteMap[stylish.FillForegroundColor];
			}
			if (paletteMap.ContainsKey(stylish.LeftBorderColor))
			{
				stylish.LeftBorderColor = paletteMap[stylish.LeftBorderColor];
			}
			if (paletteMap.ContainsKey(stylish.RightBorderColor))
			{
				stylish.RightBorderColor = paletteMap[stylish.RightBorderColor];
			}
			if (paletteMap.ContainsKey(stylish.TopBorderColor))
			{
				stylish.TopBorderColor = paletteMap[stylish.TopBorderColor];
			}
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0004B97C File Offset: 0x00049B7C
		public static void CopyCell(global::NPOI.HSSF.UserModel.HSSFCell oldCell, global::NPOI.HSSF.UserModel.HSSFCell newCell, global::System.Collections.Generic.IDictionary<int, global::NPOI.HSSF.UserModel.HSSFCellStyle> styleMap, global::System.Collections.Generic.Dictionary<short, short> paletteMap, bool keepFormulas)
		{
			if (styleMap != null)
			{
				if (oldCell.CellStyle != null)
				{
					if (oldCell.Sheet.Workbook == newCell.Sheet.Workbook)
					{
						newCell.CellStyle = oldCell.CellStyle;
					}
					else
					{
						int hashCode = oldCell.CellStyle.GetHashCode();
						if (styleMap.ContainsKey(hashCode))
						{
							newCell.CellStyle = styleMap[hashCode];
						}
						else
						{
							global::NPOI.HSSF.UserModel.HSSFCellStyle hssfcellStyle = (global::NPOI.HSSF.UserModel.HSSFCellStyle)newCell.Sheet.Workbook.CreateCellStyle();
							hssfcellStyle.CloneStyleFrom(oldCell.CellStyle);
							global::NPOI.HSSF.Util.HSSFCellUtil.RemapCellStyle(hssfcellStyle, paletteMap);
							newCell.CellStyle = hssfcellStyle;
							global::NPOI.SS.UserModel.IFont font = hssfcellStyle.GetFont(newCell.Sheet.Workbook);
							if (font.Color > 0 && paletteMap.ContainsKey(font.Color))
							{
								font.Color = paletteMap[font.Color];
							}
							styleMap.Add(hashCode, hssfcellStyle);
						}
					}
				}
				else
				{
					newCell.CellStyle = null;
				}
			}
			switch (oldCell.CellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				newCell.SetCellValue(oldCell.NumericCellValue);
				return;
			case global::NPOI.SS.UserModel.CellType.String:
			{
				global::NPOI.HSSF.UserModel.HSSFRichTextString hssfrichTextString = oldCell.RichStringCellValue as global::NPOI.HSSF.UserModel.HSSFRichTextString;
				newCell.SetCellValue(hssfrichTextString);
				if (hssfrichTextString != null)
				{
					for (int i = 0; i < hssfrichTextString.NumFormattingRuns; i++)
					{
						short fontOfFormattingRun = hssfrichTextString.GetFontOfFormattingRun(i);
						int indexOfFormattingRun = hssfrichTextString.GetIndexOfFormattingRun(i);
						int endIndex;
						if (i + 1 == hssfrichTextString.NumFormattingRuns)
						{
							endIndex = hssfrichTextString.Length;
						}
						else
						{
							endIndex = hssfrichTextString.GetIndexOfFormattingRun(i + 1);
						}
						global::NPOI.HSSF.Record.FontRecord fontRecord = newCell.BoundWorkbook.CreateNewFont();
						fontRecord.CloneStyleFrom(oldCell.BoundWorkbook.GetFontRecordAt((int)fontOfFormattingRun));
						global::NPOI.HSSF.UserModel.HSSFFont font2 = new global::NPOI.HSSF.UserModel.HSSFFont((short)newCell.BoundWorkbook.GetFontIndex(fontRecord), fontRecord);
						newCell.RichStringCellValue.ApplyFont(indexOfFormattingRun, endIndex, font2);
					}
					return;
				}
				break;
			}
			case global::NPOI.SS.UserModel.CellType.Formula:
				if (keepFormulas)
				{
					newCell.SetCellType(global::NPOI.SS.UserModel.CellType.Formula);
					newCell.CellFormula = oldCell.CellFormula;
					return;
				}
				try
				{
					newCell.SetCellType(global::NPOI.SS.UserModel.CellType.Numeric);
					newCell.SetCellValue(oldCell.NumericCellValue);
				}
				catch (global::System.Exception)
				{
					newCell.SetCellType(global::NPOI.SS.UserModel.CellType.String);
					newCell.SetCellValue(oldCell.ToString());
				}
				break;
			case global::NPOI.SS.UserModel.CellType.Blank:
				newCell.SetCellType(global::NPOI.SS.UserModel.CellType.Blank);
				return;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				newCell.SetCellValue(oldCell.BooleanCellValue);
				return;
			case global::NPOI.SS.UserModel.CellType.Error:
				newCell.SetCellValue((double)oldCell.ErrorCellValue);
				return;
			default:
				return;
			}
		}
	}
}
