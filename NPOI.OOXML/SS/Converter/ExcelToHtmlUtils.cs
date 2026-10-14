using System;
using System.IO;
using System.Text;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;

namespace NPOI.SS.Converter
{
	// Token: 0x020000F3 RID: 243
	public class ExcelToHtmlUtils
	{
		// Token: 0x06000EEE RID: 3822 RVA: 0x00035454 File Offset: 0x00033654
		public static void AppendAlign(global::System.Text.StringBuilder style, global::NPOI.SS.UserModel.HorizontalAlignment alignment)
		{
			switch (alignment)
			{
			case global::NPOI.SS.UserModel.HorizontalAlignment.General:
			case global::NPOI.SS.UserModel.HorizontalAlignment.Fill:
				break;
			case global::NPOI.SS.UserModel.HorizontalAlignment.Left:
				style.Append("text-align: left; ");
				return;
			case global::NPOI.SS.UserModel.HorizontalAlignment.Center:
				style.Append("text-align: center; ");
				return;
			case global::NPOI.SS.UserModel.HorizontalAlignment.Right:
				style.Append("text-align: right; ");
				break;
			case global::NPOI.SS.UserModel.HorizontalAlignment.Justify:
				style.Append("text-align: justify; ");
				return;
			case global::NPOI.SS.UserModel.HorizontalAlignment.CenterSelection:
				style.Append("text-align: center; ");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x000354C4 File Offset: 0x000336C4
		public static global::NPOI.SS.Util.CellRangeAddress[][] BuildMergedRangesMap(global::NPOI.SS.UserModel.ISheet sheet)
		{
			global::NPOI.SS.Util.CellRangeAddress[][] array = new global::NPOI.SS.Util.CellRangeAddress[1][];
			for (int i = 0; i < sheet.NumMergedRegions; i++)
			{
				global::NPOI.SS.Util.CellRangeAddress mergedRegion = sheet.GetMergedRegion(i);
				int num = mergedRegion.LastRow + 1;
				if (array.Length < num)
				{
					global::NPOI.SS.Util.CellRangeAddress[][] array2 = new global::NPOI.SS.Util.CellRangeAddress[num][];
					global::System.Array.Copy(array, 0, array2, 0, array.Length);
					array = array2;
				}
				for (int j = mergedRegion.FirstRow; j <= mergedRegion.LastRow; j++)
				{
					int num2 = mergedRegion.LastColumn + 1;
					global::NPOI.SS.Util.CellRangeAddress[] array3 = array[j];
					if (array3 == null)
					{
						array3 = new global::NPOI.SS.Util.CellRangeAddress[num2];
						array[j] = array3;
					}
					else
					{
						int num3 = array3.Length;
						if (num3 < num2)
						{
							global::NPOI.SS.Util.CellRangeAddress[] array4 = new global::NPOI.SS.Util.CellRangeAddress[num2];
							global::System.Array.Copy(array3, 0, array4, 0, num3);
							array[j] = array4;
							array3 = array4;
						}
					}
					for (int k = mergedRegion.FirstColumn; k < mergedRegion.LastColumn + 1; k++)
					{
						array3[k] = mergedRegion;
					}
				}
			}
			return array;
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x000355B0 File Offset: 0x000337B0
		public static string GetBorderStyle(global::NPOI.SS.UserModel.BorderStyle xlsBorder)
		{
			switch (xlsBorder)
			{
			case global::NPOI.SS.UserModel.BorderStyle.None:
				return "none";
			case global::NPOI.SS.UserModel.BorderStyle.Dashed:
			case global::NPOI.SS.UserModel.BorderStyle.MediumDashed:
				return "dashed";
			case global::NPOI.SS.UserModel.BorderStyle.Dotted:
			case global::NPOI.SS.UserModel.BorderStyle.Hair:
			case global::NPOI.SS.UserModel.BorderStyle.DashDot:
			case global::NPOI.SS.UserModel.BorderStyle.MediumDashDot:
			case global::NPOI.SS.UserModel.BorderStyle.DashDotDot:
			case global::NPOI.SS.UserModel.BorderStyle.MediumDashDotDot:
			case global::NPOI.SS.UserModel.BorderStyle.SlantedDashDot:
				return "dotted";
			case global::NPOI.SS.UserModel.BorderStyle.Double:
				return "double";
			}
			return "solid";
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00035624 File Offset: 0x00033824
		public static string GetBorderWidth(global::NPOI.SS.UserModel.BorderStyle xlsBorder)
		{
			string result;
			if (xlsBorder != global::NPOI.SS.UserModel.BorderStyle.Thick)
			{
				switch (xlsBorder)
				{
				case global::NPOI.SS.UserModel.BorderStyle.MediumDashed:
				case global::NPOI.SS.UserModel.BorderStyle.MediumDashDot:
				case global::NPOI.SS.UserModel.BorderStyle.MediumDashDotDot:
					return "2pt";
				}
				result = "thin";
			}
			else
			{
				result = "thick";
			}
			return result;
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0003566C File Offset: 0x0003386C
		public static string GetColor(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(7);
			stringBuilder.Append('#');
			foreach (byte b in color.RGB)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			string text = stringBuilder.ToString();
			if (text.Equals("#ffffff"))
			{
				return "white";
			}
			if (text.Equals("#c0c0c0"))
			{
				return "silver";
			}
			if (text.Equals("#808080"))
			{
				return "gray";
			}
			if (text.Equals("#000000"))
			{
				return "black";
			}
			return text;
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0003570C File Offset: 0x0003390C
		public static string GetColor(global::NPOI.HSSF.Util.HSSFColor color)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(7);
			stringBuilder.Append('#');
			foreach (byte b in color.RGB)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			string text = stringBuilder.ToString();
			if (text.Equals("#ffffff"))
			{
				return "white";
			}
			if (text.Equals("#c0c0c0"))
			{
				return "silver";
			}
			if (text.Equals("#808080"))
			{
				return "gray";
			}
			if (text.Equals("#000000"))
			{
				return "black";
			}
			return text;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000357AC File Offset: 0x000339AC
		public static int GetColumnWidthInPx(int widthUnits)
		{
			int num = widthUnits / 256 * 7;
			int num2 = widthUnits % 256;
			return num + (int)global::System.Math.Round((double)((float)num2 / 36.57143f));
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x000357DC File Offset: 0x000339DC
		public static global::NPOI.SS.Util.CellRangeAddress GetMergedRange(global::NPOI.SS.Util.CellRangeAddress[][] mergedRanges, int rowNumber, int columnNumber)
		{
			global::NPOI.SS.Util.CellRangeAddress[] array = (rowNumber < mergedRanges.Length) ? mergedRanges[rowNumber] : null;
			if (array == null || columnNumber >= array.Length)
			{
				return null;
			}
			return array[columnNumber];
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00035804 File Offset: 0x00033A04
		public static global::NPOI.HSSF.UserModel.HSSFWorkbook LoadXls(string xlsFile)
		{
			global::System.IO.FileStream fileStream = global::System.IO.File.Open(xlsFile, global::System.IO.FileMode.Open);
			global::NPOI.HSSF.UserModel.HSSFWorkbook result;
			try
			{
				result = new global::NPOI.HSSF.UserModel.HSSFWorkbook(fileStream);
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
				}
				fileStream = null;
			}
			return result;
		}

		// Token: 0x04000473 RID: 1139
		private const short EXCEL_COLUMN_WIDTH_FACTOR = 256;

		// Token: 0x04000474 RID: 1140
		private const int UNIT_OFFSET_LENGTH = 7;
	}
}
