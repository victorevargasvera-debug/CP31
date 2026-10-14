using System;
using System.Collections;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200037E RID: 894
	public class HSSFOptimiser
	{
		// Token: 0x06001C74 RID: 7284 RVA: 0x000563AC File Offset: 0x000545AC
		public static void OptimiseFonts(global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			short[] array = new short[workbook.Workbook.NumberOfFontRecords + 1];
			bool[] array2 = new bool[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (short)i;
				array2[i] = false;
			}
			global::NPOI.HSSF.Record.FontRecord[] array3 = new global::NPOI.HSSF.Record.FontRecord[array.Length];
			for (int j = 0; j < array.Length; j++)
			{
				if (j != 4)
				{
					array3[j] = workbook.Workbook.GetFontRecordAt(j);
				}
			}
			for (int k = 5; k < array.Length; k++)
			{
				int num = -1;
				int num2 = 0;
				while (num2 < k && num == -1)
				{
					if (num2 != 4 && workbook.Workbook.GetFontRecordAt(num2).SameProperties(array3[k]))
					{
						num = num2;
					}
					num2++;
				}
				if (num != -1)
				{
					array[k] = (short)num;
					array2[k] = true;
				}
			}
			for (int l = 5; l < array.Length; l++)
			{
				short num3 = array[l];
				short num4 = num3;
				for (int m = 0; m < (int)num3; m++)
				{
					if (array2[m])
					{
						num4 -= 1;
					}
				}
				array[l] = num4;
			}
			for (int n = 5; n < array.Length; n++)
			{
				if (array2[n])
				{
					workbook.Workbook.RemoveFontRecord(array3[n]);
				}
			}
			workbook.ResetFontCache();
			for (int num5 = 0; num5 < workbook.Workbook.NumExFormats; num5++)
			{
				global::NPOI.HSSF.Record.ExtendedFormatRecord exFormatAt = workbook.Workbook.GetExFormatAt(num5);
				exFormatAt.FontIndex = array[(int)exFormatAt.FontIndex];
			}
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			for (int num6 = 0; num6 < workbook.NumberOfSheets; num6++)
			{
				foreach (object obj in workbook.GetSheetAt(num6))
				{
					foreach (global::NPOI.SS.UserModel.ICell cell in ((global::NPOI.SS.UserModel.IRow)obj))
					{
						if (cell.CellType == global::NPOI.SS.UserModel.CellType.String)
						{
							global::NPOI.HSSF.Record.UnicodeString rawUnicodeString = ((global::NPOI.HSSF.UserModel.HSSFRichTextString)cell.RichStringCellValue).RawUnicodeString;
							if (!arrayList.Contains(rawUnicodeString))
							{
								short num7 = 5;
								while ((int)num7 < array.Length)
								{
									if (num7 != array[(int)num7])
									{
										rawUnicodeString.SwapFontUse(num7, array[(int)num7]);
									}
									num7 += 1;
								}
								arrayList.Add(rawUnicodeString);
							}
						}
					}
				}
			}
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00056628 File Offset: 0x00054828
		public static void OptimiseCellStyles(global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			short[] array = new short[workbook.Workbook.NumExFormats];
			bool[] array2 = new bool[array.Length];
			bool[] array3 = new bool[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = false;
				array[i] = (short)i;
				array3[i] = false;
			}
			global::NPOI.HSSF.Record.ExtendedFormatRecord[] array4 = new global::NPOI.HSSF.Record.ExtendedFormatRecord[array.Length];
			for (int j = 0; j < array.Length; j++)
			{
				array4[j] = workbook.Workbook.GetExFormatAt(j);
			}
			for (int k = 21; k < array.Length; k++)
			{
				int num = -1;
				int num2 = 0;
				while (num2 < k && num == -1)
				{
					if (workbook.Workbook.GetExFormatAt(num2).Equals(array4[k]))
					{
						num = num2;
					}
					num2++;
				}
				if (num != -1)
				{
					array[k] = (short)num;
					array3[k] = true;
				}
				if (num != -1)
				{
					array2[num] = true;
				}
			}
			for (int l = 0; l < workbook.NumberOfSheets; l++)
			{
				foreach (object obj in ((global::NPOI.HSSF.UserModel.HSSFSheet)workbook.GetSheetAt(l)))
				{
					foreach (global::NPOI.SS.UserModel.ICell cell in ((global::NPOI.SS.UserModel.IRow)obj))
					{
						short xfindex = ((global::NPOI.HSSF.UserModel.HSSFCell)cell).CellValueRecord.XFIndex;
						array2[(int)xfindex] = true;
					}
				}
			}
			for (int m = 21; m < array2.Length; m++)
			{
				if (!array2[m])
				{
					array3[m] = true;
					array[m] = 0;
				}
			}
			for (int n = 21; n < array.Length; n++)
			{
				short num3 = array[n];
				short num4 = num3;
				for (int num5 = 0; num5 < (int)num3; num5++)
				{
					if (array3[num5])
					{
						num4 -= 1;
					}
				}
				array[n] = num4;
			}
			int num6 = array.Length;
			int num7 = 0;
			for (int num8 = 21; num8 < num6; num8++)
			{
				if (array3[num8 + num7])
				{
					workbook.Workbook.RemoveExFormatRecord(num8);
					num8--;
					num6--;
					num7++;
				}
			}
			for (int num9 = 0; num9 < workbook.NumberOfSheets; num9++)
			{
				foreach (object obj2 in ((global::NPOI.HSSF.UserModel.HSSFSheet)workbook.GetSheetAt(num9)))
				{
					foreach (global::NPOI.SS.UserModel.ICell cell2 in ((global::NPOI.SS.UserModel.IRow)obj2))
					{
						short xfindex2 = ((global::NPOI.HSSF.UserModel.HSSFCell)cell2).CellValueRecord.XFIndex;
						global::NPOI.SS.UserModel.ICellStyle cellStyleAt = workbook.GetCellStyleAt((int)array[(int)xfindex2]);
						cell2.CellStyle = cellStyleAt;
					}
				}
			}
		}
	}
}
