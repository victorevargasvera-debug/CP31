using System;
using System.Collections.Generic;
using System.IO;
using CommonUtility;
using Motorola.CommonCPS.Common.CommonUtility.CSV;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Motorola.CommonCPS.Common.CommonUtility.ExcelFile
{
	// Token: 0x02000018 RID: 24
	public sealed class ExcelFile
	{
		// Token: 0x06000073 RID: 115 RVA: 0x0000C11C File Offset: 0x0000A31C
		public void ExportToExcel(string fileName, global::System.Collections.Generic.IList<string> headerList, global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> dataRecords, global::System.Collections.Generic.List<string> headerListAlias = null)
		{
			int a_ = 15;
			short num = (short)905904128;
			switch (num)
			{
			default:
			{
				num = (short)1001521152;
				short num2 = num;
				num = (short)1200160769;
				if (num != 0)
				{
				}
				num = (short)1122959365;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1603489884;
					short num4 = num;
					num = (short)504909916;
					global::NPOI.SS.UserModel.IWorkbook workbook2;
					global::NPOI.SS.UserModel.IWorkbook workbook3;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)435945472;
						if (num != 0)
						{
						}
						global::NPOI.SS.UserModel.IWorkbook workbook;
						switch (num3)
						{
						case 0:
							workbook = workbook2;
							goto IL_69A;
						case 1:
							workbook3 = (workbook2 = new global::NPOI.HSSF.UserModel.HSSFWorkbook());
							num = (short)170786819;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_126;
						case 3:
							workbook = workbook2;
							goto IL_69A;
						case 4:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_214;
								}
								global::NPOI.SS.UserModel.ISheet sheet;
								int num6;
								for (;;)
								{
									IL_1A9:
									global::NPOI.SS.UserModel.IRow row;
									int num7;
									int num8;
									global::NPOI.SS.UserModel.ICell cell;
									switch (num3)
									{
									case 0:
									{
										int num5;
										if (num5 >= dataRecords.Count)
										{
											num = (short)1840775182;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										row = sheet.CreateRow(num5 + num6);
										global::System.Collections.Generic.List<string> list = dataRecords[num5];
										global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile.ApplyRowStyle(workbook3, row, false);
										num7 = 0;
										num = (short)1030422551;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
									{
										int num5 = 0;
										num = (short)348782607;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_298;
									case 3:
										goto IL_4B1;
									case 4:
										if (dataRecords != null)
										{
											num = (short)1683226625;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_63C;
									case 5:
										goto IL_4B1;
									case 6:
										goto IL_2D4;
									case 7:
									{
										global::System.IO.FileStream fileStream = global::System.IO.File.Create(fileName);
										num = (short)245956619;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										if (num8 >= sheet.GetRow(0).PhysicalNumberOfCells)
										{
											num = (short)1583677447;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										sheet.AutoSizeColumn(num8);
										num8++;
										num = (short)1974861830;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										goto IL_419;
									case 10:
									{
										global::NPOI.SS.UserModel.IRow row2 = sheet.CreateRow(num6);
										global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile.ApplyRowStyle(workbook3, row2, true);
										global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile.a(headerList, row2);
										num6++;
										num = (short)2051080214;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
										try
										{
											global::System.IO.FileStream fileStream;
											workbook3.Write(fileStream);
											return;
										}
										finally
										{
											num = (short)1040384002;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.IO.FileStream fileStream;
												switch (num3)
												{
												case 0:
													((global::System.IDisposable)fileStream).Dispose();
													num = (short)521273345;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													goto IL_55C;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_524;
													}
													continue;
												}
												IL_524:
												if (fileStream == null)
												{
													break;
												}
												num = (short)1219624960;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_55C:;
										}
										goto IL_55F;
									case 12:
										if (headerList != null)
										{
											num = (short)1684078602;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_55F;
									case 13:
									{
										global::NPOI.SS.UserModel.IRow row3 = sheet.CreateRow(num6);
										global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile.ApplyRowStyle(workbook3, row3, true);
										global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile.a(headerListAlias, row3);
										num6++;
										num = (short)186712066;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 14:
										goto IL_63C;
									case 15:
										goto IL_5FB;
									case 16:
										goto IL_2D4;
									case 17:
									{
										global::System.Collections.Generic.List<string> list;
										if (num7 >= list.Count)
										{
											num = (short)1948844050;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										cell = row.CreateCell(num7, global::NPOI.SS.UserModel.CellType.Numeric);
										num = (short)279183384;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 18:
									{
										int num5;
										num5++;
										num = (short)1900150805;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 19:
										if (headerListAlias != null)
										{
											num = (short)1842610189;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_298;
									case 20:
										cell.SetCellValue(string.Empty);
										num = (short)381091845;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 21:
										goto IL_5FB;
									case 22:
										goto IL_55F;
									case 23:
										goto IL_419;
									case 24:
									{
										global::System.Collections.Generic.List<string> list;
										if (string.IsNullOrEmpty(list[num7]))
										{
											num = (short)632487956;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										cell.SetCellValue(list[num7]);
										num = (short)709099523;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
									IL_298:
									num = (short)1064828932;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_2D4:
									num = (short)1472200712;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_419:
									num = (short)1417019409;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_4B1:
									cell.CellStyle = row.RowStyle;
									num7++;
									num = (short)1853161481;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_55F:
									num = (short)265814035;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_5FB:
									num = (short)744292352;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_63C:
									num8 = 0;
									num = (short)1757413392;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_214:
								sheet = workbook3.CreateSheet();
								num6 = 0;
								num = (short)274792460;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_1A9;
							}
							finally
							{
								workbook3.Close();
							}
							goto IL_663;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_104;
							}
							continue;
						case 6:
							goto IL_143;
						}
						IL_104:
						if (!this.a(fileName))
						{
							num = (short)462094338;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1705967622;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_69A:
						workbook3 = workbook;
						num = (short)923729924;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_143:
					if (!fileName.EndsWith(global::CommonUtility.VersionUtility.b("渿㩁⡃㕅ぇ", a_)))
					{
						num = (short)236650497;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_663:
					workbook3 = (workbook2 = new global::NPOI.XSSF.UserModel.XSSFWorkbook());
					num = (short)592642048;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_126:
				throw new global::System.IO.FileFormatException(global::CommonUtility.VersionUtility.b("ؿ⭁⡃⍅桇⍉㽋湍㹏㵑⁓癕㥗穙⩛㽝౟ୡc䙥ⵧቩཫ୭ᱯ剱ታ᥵੷᝹ᵻ੽", a_));
			}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000C818 File Offset: 0x0000AA18
		private static void a(global::System.Collections.Generic.IList<string> A_0, global::NPOI.SS.UserModel.IRow A_1)
		{
			short num = (short)883118821;
			short num2 = num;
			num = (short)1459639013;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_BE:
				num = (short)64421888;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)306642945;
				if (num != 0)
				{
				}
				num = (short)622919680;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_BC;
				}
				break;
			}
			int num5;
			for (;;)
			{
				num = (short)1274871808;
				short num4 = num;
				switch (num3)
				{
				case 0:
					goto IL_D5;
				case 1:
				{
					if (num5 >= A_0.Count)
					{
						num = (short)417267715;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::NPOI.SS.UserModel.ICell cell = A_1.CreateCell(num5, global::NPOI.SS.UserModel.CellType.Numeric);
					cell.SetCellValue(A_0[num5]);
					cell.CellStyle = A_1.RowStyle;
					num5++;
					num = (short)1019084802;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_D5;
				case 3:
					return;
				}
				goto IL_BC;
				IL_D5:
				num = (short)2071003137;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_BC:
			num5 = 0;
			goto IL_BE;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000C970 File Offset: 0x0000AB70
		public static void ApplyRowStyle(global::NPOI.SS.UserModel.IWorkbook workbook, global::NPOI.SS.UserModel.IRow row, bool isHeader = false)
		{
			int a_ = 18;
			short num;
			int num4;
			global::NPOI.SS.UserModel.ICellStyle cellStyle;
			global::NPOI.SS.UserModel.IFont font;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					num = (short)390619744;
					short num2 = num;
					num = (short)1760125536;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B0;
					case 1:
						break;
					default:
					{
						num = (short)1587150848;
						short num3 = num;
						break;
					}
					}
					num = (short)1715011584;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (isHeader)
						{
							num = (short)672006145;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1359806466;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1966211073;
						if (num != 0)
						{
						}
						cellStyle.FillForegroundColor = global::NPOI.SS.UserModel.IndexedColors.Grey50Percent.Index;
						cellStyle.FillPattern = global::NPOI.SS.UserModel.FillPattern.SolidForeground;
						cellStyle.BorderBottom = global::NPOI.SS.UserModel.BorderStyle.Thin;
						cellStyle.BorderLeft = global::NPOI.SS.UserModel.BorderStyle.Thin;
						cellStyle.BorderRight = global::NPOI.SS.UserModel.BorderStyle.Thin;
						cellStyle.BorderTop = global::NPOI.SS.UserModel.BorderStyle.Thin;
						cellStyle.BottomBorderColor = global::NPOI.SS.UserModel.IndexedColors.Black.Index;
						cellStyle.LeftBorderColor = global::NPOI.SS.UserModel.IndexedColors.Black.Index;
						cellStyle.RightBorderColor = global::NPOI.SS.UserModel.IndexedColors.Black.Index;
						cellStyle.TopBorderColor = global::NPOI.SS.UserModel.IndexedColors.Black.Index;
						font.Color = global::NPOI.SS.UserModel.IndexedColors.White.Index;
						num = (short)981139460;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						cellStyle.FillForegroundColor = ((row.RowNum % 2 == 0) ? global::NPOI.SS.UserModel.IndexedColors.White.Index : global::NPOI.SS.UserModel.IndexedColors.Grey25Percent.Index);
						cellStyle.BorderRight = global::NPOI.SS.UserModel.BorderStyle.Thin;
						cellStyle.RightBorderColor = global::NPOI.SS.UserModel.IndexedColors.Grey25Percent.Index;
						cellStyle.FillPattern = global::NPOI.SS.UserModel.FillPattern.SolidForeground;
						num = (short)31260675;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_227;
					case 4:
						goto IL_1D3;
					}
					goto IL_A2;
				}
				IL_1D3:
				IL_227:
				font.FontName = global::CommonUtility.VersionUtility.b("B⑄⭆⁈⥊㽌♎", a_);
				cellStyle.SetFont(font);
				row.RowStyle = cellStyle;
				return;
			}
			IL_A2:
			cellStyle = workbook.CreateCellStyle();
			font = workbook.CreateFont();
			IL_B0:
			num = (short)1429405696;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
		public void Populate(string filePath, bool hasHeaderRow, bool hasHeaderAlias, bool hasRangeRow, out global::System.Collections.Generic.List<string> headerList, out global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> dataRecords, out global::System.Collections.Generic.List<string> headerAliasList, out global::System.Collections.Generic.List<string> headerRangesList)
		{
			int a_ = 4;
			short num = (short)509355666;
			short num2 = num;
			num = (short)1909597842;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B0:
				switch (0)
				{
				case 0:
					goto IL_CD;
				}
				goto IL_BA;
			case 1:
				break;
			default:
			{
				num = (short)361299968;
				short num3 = num;
				break;
			}
			}
			num = (short)265748480;
			if (num != 0)
			{
			}
			num = (short)22478848;
			int num4 = (int)num;
			switch (num4)
			{
			default:
				num = (short)1264189440;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			IL_BA:
			global::NPOI.SS.UserModel.IWorkbook workbook;
			switch (num4)
			{
			case 0:
				goto IL_B0;
			case 1:
				num = (short)1354498049;
				if (num != 0)
				{
				}
				throw new global::System.IO.FileFormatException(global::CommonUtility.VersionUtility.b("猴帶唸帺ᴼ嘾㉀捂⭄⡆㵈歊ⱌ潎❐㉒㥔㹖㵘筚ᡜ❞ɠ٢।䝦ཨѪὬɮၰݲ", a_));
			case 2:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_157;
					}
					global::System.IO.FileStream fileStream;
					for (;;)
					{
						IL_124:
						global::NPOI.SS.UserModel.ISheet sheetAt;
						int num5;
						switch (num4)
						{
						case 0:
							if (sheetAt.GetRow(num5) == null)
							{
								num = (short)472842243;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_349;
						case 1:
							try
							{
								num = (short)2005336064;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::NPOI.SS.UserModel.IWorkbook workbook2;
									global::NPOI.SS.UserModel.IWorkbook workbook3;
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_248;
										}
										continue;
									case 1:
										workbook = (workbook2 = new global::NPOI.HSSF.UserModel.HSSFWorkbook(fileStream));
										num = (short)678100994;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										workbook3 = workbook2;
										goto IL_2C0;
									case 3:
										goto IL_2D9;
									case 4:
										workbook3 = workbook2;
										goto IL_2C0;
									}
									IL_248:
									if (!filePath.EndsWith(global::CommonUtility.VersionUtility.b("᬴伶唸䠺䔼", a_)))
									{
										num = (short)1277100033;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									workbook = (workbook2 = new global::NPOI.XSSF.UserModel.XSSFWorkbook(fileStream));
									num = (short)1060569092;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_2C0:
									workbook = workbook3;
									num = (short)273219587;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_2D9:
								goto IL_3C1;
							}
							finally
							{
								num = (short)1894776832;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_310;
										}
										continue;
									case 1:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)1508704258;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_346;
									}
									IL_310:
									if (fileStream == null)
									{
										break;
									}
									num = (short)1246822401;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_346:;
							}
							goto IL_349;
							IL_3C1:
							headerList = new global::System.Collections.Generic.List<string>();
							headerAliasList = new global::System.Collections.Generic.List<string>();
							headerRangesList = new global::System.Collections.Generic.List<string>();
							dataRecords = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>();
							sheetAt = workbook.GetSheetAt(0);
							num5 = 0;
							num = (short)1257570313;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_19E;
						case 3:
							num = (short)1420427271;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile.a(headerList, sheetAt, num5);
							num5++;
							num = (short)1487667206;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_19E;
						case 6:
							goto IL_385;
						case 7:
							goto IL_43F;
						case 8:
							if (hasHeaderAlias)
							{
								num = (short)1925251082;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19E;
						case 9:
							if (hasHeaderRow)
							{
								num = (short)1893203972;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_385;
						case 10:
							global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile.a(headerAliasList, sheetAt, num5);
							num5++;
							num = (short)583335938;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_157;
						IL_19E:
						num = (short)1931870208;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_349:
						global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
						global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile.a(list, sheetAt, num5);
						num5++;
						dataRecords.Add(list);
						num = (short)1764491269;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_385:
						num = (short)854065160;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_43F:
					return;
					IL_157:
					fileStream = global::System.IO.File.OpenRead(filePath);
					num = (short)404226049;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_124;
				}
				finally
				{
					workbook.Close();
				}
				goto IL_448;
			}
			IL_CD:
			if (!this.a(filePath))
			{
				num = (short)1503723521;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_BA;
			}
			IL_448:
			workbook = null;
			num = (short)2120482818;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_BA;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000D088 File Offset: 0x0000B288
		private static void a(global::System.Collections.Generic.List<string> A_0, global::NPOI.SS.UserModel.ISheet A_1, int A_2)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			int count;
			short num2;
			for (;;)
			{
				IL_13:
				int num3;
				switch (num)
				{
				case 0:
					goto IL_BE;
				case 1:
				{
					if (A_1.GetRow(A_2).Cells.Count != count)
					{
						num2 = (short)949878784;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::NPOI.SS.UserModel.IRow row = A_1.GetRow(A_2);
					num3 = 0;
					num2 = (short)1244332036;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_1F6;
				case 3:
				{
					global::NPOI.SS.UserModel.IRow row;
					if (row.GetCell(num3) == null)
					{
						num2 = (short)1790050310;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)256638976;
					short num4 = num2;
					num2 = (short)1961053013;
					short num5 = num2;
					num2 = (short)1262111573;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_250;
					default:
						num2 = (short)297861120;
						if (num2 != 0)
						{
						}
						A_0.Add(row.GetCell(num3).ToString());
						num2 = (short)1431633922;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_1AC;
				case 5:
					goto IL_1F6;
				case 6:
					goto IL_250;
				case 7:
					if (num3 >= count)
					{
						num2 = (short)630194185;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1503526915;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_1AC;
				case 9:
					return;
				}
				goto IL_41;
				IL_1AC:
				num2 = (short)301268999;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F6:
				num3++;
				num2 = (short)1196228616;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_250:
				A_0.Add(string.Empty);
				num2 = (short)1128202245;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_BE:
			throw new global::System.FormatException(global::CommonUtility.VersionUtility.b("稲場䜶䬸吺䴼娾㍀⽂㱄杆⽈⑊㽌≎ぐ❒⅔㉖㵘筚㥜ぞɠᙢࡤɦݨὪ䅬佮ተቲ᭴᥶ᙸེ嵼ᙾﶈ", a_));
			IL_41:
			count = A_1.GetRow(0).Cells.Count;
			num2 = (short)1520107521;
			if (num2 != 0)
			{
			}
			num2 = (short)215285761;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000D2EC File Offset: 0x0000B4EC
		private bool a(string A_0)
		{
			int a_ = 7;
			short num = (short)356712448;
			short num2 = num;
			num = (short)1834057007;
			short num3 = num;
			num = (short)227769647;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)317456385;
				if (num != 0)
				{
				}
				num = (short)2087583744;
				if (num != 0)
				{
				}
				if (A_0.EndsWith(global::CommonUtility.VersionUtility.b("ᘷ䈹倻䴽", a_)))
				{
					return true;
				}
				break;
			}
			return A_0.EndsWith(global::CommonUtility.VersionUtility.b("ᘷ䈹倻䴽㠿", a_));
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000D3CC File Offset: 0x0000B5CC
		public global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile Excel2Csv(string filePath, bool hasHeaderRow, bool hasHeaderAlias, bool hasRangeRow = false)
		{
			short num = (short)843776000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				global::System.Collections.Generic.List<string> list;
				global::System.Collections.Generic.List<string> list2;
				global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile;
				global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> list4;
				global::System.Collections.Generic.List<string> list5;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (list != null)
						{
							num = (short)1645740035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E5;
					case 1:
						goto IL_213;
					case 2:
						if (list2 != null)
						{
							num = (short)669843463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64A;
					case 3:
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator = list.GetEnumerator();
						num = (short)844169221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						try
						{
							num = (short)1497235456;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_35F;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1121124357;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.List<string> list3 = enumerator2.Current;
									global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord();
									global::System.Collections.Generic.List<string>.Enumerator enumerator = list3.GetEnumerator();
									num = (short)2140209155;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord;
									try
									{
										num = (short)1937309696;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_39F;
												}
												continue;
											case 2:
											{
												global::System.Collections.Generic.List<string>.Enumerator enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1552023556;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												string item = enumerator.Current;
												csvRecord.Fields.Add(item);
												num = (short)280166401;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												goto IL_424;
											case 4:
												num = (short)1202323459;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_3CF:
											num = (short)335347714;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_39F:
											goto IL_3CF;
										}
										IL_424:;
									}
									finally
									{
										global::System.Collections.Generic.List<string>.Enumerator enumerator;
										((global::System.IDisposable)enumerator).Dispose();
									}
									csvFile.Records.Add(csvRecord);
									num = (short)2041839617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_4E4;
								case 5:
									num = (short)1626013700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_48F:
								num = (short)794230786;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_35F:
								goto IL_48F;
							}
							IL_4E4:
							return csvFile;
						}
						finally
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_4F7;
					case 5:
						try
						{
							num = (short)1945370624;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_182;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1665073156;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string item2 = enumerator.Current;
									csvFile.Headers.Add(item2);
									num = (short)1675034625;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_200;
								case 4:
									num = (short)587005955;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1B2:
								num = (short)1690697730;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_182:
								goto IL_1B2;
							}
							IL_200:
							goto IL_2E5;
						}
						finally
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_3;
					case 6:
						if (list4 != null)
						{
							goto IL_516;
						}
						return csvFile;
					case 7:
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator = list2.GetEnumerator();
						num = (short)215285771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (list5 != null)
						{
							num = (short)279248906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F7;
					case 9:
					{
						global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>.Enumerator enumerator2 = list4.GetEnumerator();
						num = (short)309067780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						num = (short)373227521;
						if (num != 0)
						{
						}
						num = (short)1058341151;
						short num3 = num;
						num = (short)257098015;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_516;
						default:
						{
							num = (short)1650262016;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.List<string>.Enumerator enumerator = list5.GetEnumerator();
							num = (short)1010958337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 11:
						try
						{
							num = (short)1669201920;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5B7;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1570635780;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string item3 = enumerator.Current;
									csvFile.HeaderAlias.Add(item3);
									num = (short)1948319745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_63A;
								case 4:
									num = (short)1745354755;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5E8:
								num = (short)1715601410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5B7:
								goto IL_5E8;
							}
							IL_63A:;
						}
						finally
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_64A;
					}
					goto IL_5F;
					IL_2E5:
					num = (short)2049245186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_213:
						num = (short)1966080;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_24E;
								}
								continue;
							case 1:
							{
								global::System.Collections.Generic.List<string>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1176305666;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string item4 = enumerator.Current;
								csvFile.HeaderValidation.Add(item4);
								num = (short)229441540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								num = (short)587726851;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_2D2;
							}
							IL_250:
							num = (short)380829697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_24E:
							goto IL_250;
						}
						IL_2D2:
						goto IL_4F7;
					}
					finally
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_2E5;
					IL_4F7:
					num = (short)1072824326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_516:
					num = (short)1608712201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64A:
					num = (short)1382416384;
					short num4 = num;
					num = (short)877854728;
					num2 = (int)((global::System.IntPtr)num);
				}
				return csvFile;
				IL_5F:
				this.Populate(filePath, hasHeaderRow, hasHeaderAlias, hasRangeRow, out list, out list4, out list2, out list5);
				csvFile = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile();
				num = (short)995229696;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
