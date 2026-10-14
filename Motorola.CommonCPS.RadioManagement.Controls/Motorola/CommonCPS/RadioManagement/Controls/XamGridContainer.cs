using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows;
using Infragistics.Controls.Grids;
using Microsoft.Win32;
using Motorola.CommonCPS.Common.CommonUtility.CSV;
using Motorola.CommonCPS.Common.CommonUtility.ExcelFile;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000B3 RID: 179
	public class XamGridContainer : global::Motorola.CommonCPS.RadioManagement.Controls.RMRelocatableFieldEditor
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x0004A8E8 File Offset: 0x00048AE8
		protected void Export(global::Infragistics.Controls.Grids.XamGrid xamGrid)
		{
			int a_ = 13;
			short num = (short)1781137408;
			short num2 = num;
			num = (short)144375808;
			switch (num)
			{
			default:
			{
				num = (short)1062862848;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					case 1:
						goto IL_75A;
					case 2:
						return;
					}
					IL_82:
					if (xamGrid.Rows.Count == 0)
					{
						num = (short)8978433;
						if (num != 0)
						{
						}
						num = (short)1205731330;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						string text = string.Empty;
						num = (short)1066270721;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				return;
				IL_75A:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_164;
					}
					int num5;
					global::System.Collections.Generic.IList<string> list3;
					for (;;)
					{
						IL_DD:
						int num6;
						switch (num3)
						{
						case 0:
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> list;
							global::System.Collections.Generic.List<string> list2;
							list.Add(list2);
							int num4;
							num4++;
							num = (short)983695382;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_296;
						case 2:
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>();
							int num4 = 0;
							num = (short)816775173;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							string text;
							global::Microsoft.Win32.SaveFileDialog saveFileDialog = new global::Microsoft.Win32.SaveFileDialog
							{
								FileName = text,
								Filter = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_CSV_Excel,
								Title = global::Motorola.CommonCPS.ResourceRepository.Resources.ActionBar_Classical_Tooltip_Export,
								RestoreDirectory = true
							};
							bool? flag = saveFileDialog.ShowDialog();
							num = (short)1121779738;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_1B7;
						case 5:
							goto IL_66E;
						case 6:
						{
							global::Microsoft.Win32.SaveFileDialog saveFileDialog;
							string text = saveFileDialog.FileName;
							num = (short)1053753353;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							if (!string.IsNullOrEmpty(xamGrid.Columns[num5].HeaderText))
							{
								num = (short)1580400670;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_361;
						case 8:
							goto IL_1B7;
						case 9:
						{
							string text;
							if (!string.IsNullOrEmpty(text))
							{
								num = (short)2037973007;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6B5;
						}
						case 10:
							goto IL_6B5;
						case 11:
						{
							global::Infragistics.Controls.Grids.ColumnBase columnBase;
							if (columnBase.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)722337820;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_64A;
						}
						case 12:
							goto IL_1FE;
						case 13:
						{
							if (num6 >= xamGrid.Columns.Count)
							{
								num = (short)836763648;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Controls.Grids.ColumnBase columnBase = xamGrid.Columns[num6];
							num = (short)1930362891;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
						{
							int num4;
							if (num4 >= xamGrid.Rows.Count)
							{
								num = (short)1506279427;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							for (;;)
							{
								global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
								num6 = 0;
								num = (short)1760377290;
								short num7 = num;
								num = (short)1159018954;
								switch ((num7 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_3F4;
								}
							}
							IL_3F4:
							num = (short)2037972992;
							if (num != 0)
							{
							}
							num = (short)781713412;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							num = (short)626589720;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							if (num5 >= xamGrid.Columns.Count)
							{
								num = (short)820903938;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1495924756;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
						{
							string text;
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> list;
							this.ExportToCSV(text, list3, list);
							num = (short)1369571347;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
							goto IL_64A;
						case 19:
							goto IL_296;
						case 20:
							if (xamGrid.Columns[num5].Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)2116812825;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_361;
						case 21:
						{
							global::Infragistics.Controls.Grids.ColumnBase columnBase;
							if (!string.IsNullOrEmpty(columnBase.HeaderText))
							{
								num = (short)1279262743;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_64A;
						}
						case 22:
							goto IL_66E;
						case 23:
						{
							int num4;
							global::Infragistics.Controls.Grids.ColumnBase columnBase;
							global::Infragistics.Controls.Grids.CellBase a_2 = xamGrid.Rows[num4].Cells[columnBase.Key];
							string item = this.a(columnBase, a_2);
							global::System.Collections.Generic.List<string> list2;
							list2.Add(item);
							num = (short)1655504914;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
						{
							string text;
							if (text.EndsWith(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("认쒦\udaa8\uddaa", a_), global::System.StringComparison.CurrentCulture))
							{
								num = (short)407830545;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile excelFile = new global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile();
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> list;
							excelFile.ExportToExcel(text, list3, list, null);
							num = (short)737017857;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							num = (short)767361031;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
						{
							bool? flag;
							if (flag.Value)
							{
								num = (short)1105264646;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6B5;
						}
						case 27:
							goto IL_6CD;
						case 28:
							num = (short)1225785365;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
							goto IL_361;
						case 30:
							list3.Add(xamGrid.Columns[num5].HeaderText);
							num = (short)409534493;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							goto IL_1FE;
						}
						goto IL_164;
						IL_1B7:
						num = (short)90439693;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1FE:
						num = (short)960167952;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_296:
						global::System.Windows.MessageBox.Show(global::Motorola.CommonCPS.ResourceRepository.Resources.Message_Export_successful, global::Motorola.CommonCPS.ResourceRepository.Resources.ExportDevicesAction_Title, global::System.Windows.MessageBoxButton.OK);
						num = (short)1461452810;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_361:
						num5++;
						num = (short)231079967;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_64A:
						num6++;
						num = (short)2056323080;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_66E:
						num = (short)1433534478;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_6B5:
						num = (short)219086875;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_6CD:
					return;
					IL_164:
					list3 = new global::System.Collections.Generic.List<string>();
					num5 = 0;
					num = (short)852819980;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_DD;
				}
				catch (global::System.IO.IOException)
				{
					string text;
					string messageBoxText = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.The_Process_Cannot_Access_File, text);
					global::System.Windows.MessageBox.Show(messageBoxText, global::Motorola.CommonCPS.ResourceRepository.Resources.ExportDevicesAction_Title, global::System.Windows.MessageBoxButton.OK);
					return;
				}
				catch (global::System.UnauthorizedAccessException)
				{
					string text;
					string messageBoxText2 = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportFile_Access_Error, text);
					global::System.Windows.MessageBox.Show(messageBoxText2, global::Motorola.CommonCPS.ResourceRepository.Resources.ExportDevicesAction_Title, global::System.Windows.MessageBoxButton.OK);
					return;
				}
				catch (global::System.Exception ex)
				{
					global::System.Windows.MessageBox.Show(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportGrid_Fail + ex.Message, global::Motorola.CommonCPS.ResourceRepository.Resources.ExportDevicesAction_Title, global::System.Windows.MessageBoxButton.OK);
					return;
				}
				return;
			}
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0004B0A0 File Offset: 0x000492A0
		protected void ExportToCSV(string fileName, global::System.Collections.Generic.IList<string> headerList, global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> dataRecords)
		{
			short num = (short)164102144;
			short num2 = num;
			num = (short)566660926;
			short num3 = num;
			num = (short)822775614;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)228655105;
				if (num != 0)
				{
				}
				num = (short)775618560;
				if (num != 0)
				{
				}
				num = (short)788135936;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvWriter csvWriter = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvWriter();
					try
					{
						switch (0)
						{
						case 0:
							goto IL_DE;
						}
						global::System.Collections.Generic.IEnumerator<string> enumerator;
						global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile;
						for (;;)
						{
							IL_CB:
							switch (num4)
							{
							case 0:
								try
								{
									num = (short)2133131265;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											goto IL_1BA;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_13E;
											}
											continue;
										case 2:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)1646133252;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											string item = enumerator.Current;
											csvFile.Headers.Add(item);
											num = (short)632291331;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 4:
											num = (short)23068672;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_140:
										num = (short)846921730;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_13E:
										goto IL_140;
									}
									IL_1BA:
									goto IL_3FA;
								}
								finally
								{
									num = (short)598016000;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_1F1;
											}
											continue;
										case 1:
											goto IL_226;
										case 2:
											enumerator.Dispose();
											num = (short)1477509121;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_1F1:
										if (enumerator == null)
										{
											break;
										}
										num = (short)1327431682;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_226:;
								}
								goto Block_3;
							case 1:
								goto IL_440;
							case 2:
								goto IL_229;
							}
							goto IL_DE;
							IL_3FA:
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>.Enumerator enumerator2 = dataRecords.GetEnumerator();
							num = (short)1041104898;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							Block_3:
							try
							{
								IL_229:
								num = (short)1789919233;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator3;
									global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord;
									switch (num4)
									{
									case 0:
										goto IL_3EA;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_267;
										}
										continue;
									case 3:
										if (!enumerator2.MoveNext())
										{
											num = (short)1626603525;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_39A;
									case 4:
										try
										{
											num = (short)2025521153;
											num4 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num4)
												{
												case 0:
													goto IL_387;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_308;
													}
													continue;
												case 3:
													num = (short)786104320;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 4:
												{
													if (!enumerator3.MoveNext())
													{
														num = (short)1529479171;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													string item2 = enumerator3.Current;
													csvRecord.Fields.Add(item2);
													num = (short)2072248322;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_339:
												num = (short)980025348;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_308:
												goto IL_339;
											}
											IL_387:
											goto IL_2A6;
										}
										finally
										{
											((global::System.IDisposable)enumerator3).Dispose();
										}
										goto IL_39A;
										IL_2A6:
										csvFile.Records.Add(csvRecord);
										num = (short)230817794;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										num = (short)137232384;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_269:
									num = (short)2001338371;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_267:
									goto IL_269;
									IL_39A:
									global::System.Collections.Generic.List<string> list = enumerator2.Current;
									csvRecord = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord();
									enumerator3 = list.GetEnumerator();
									num = (short)1101529092;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_3EA:
								goto IL_41F;
							}
							finally
							{
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_3FA;
							IL_41F:
							csvWriter.WriteCsv(csvFile, fileName);
							num = (short)392953857;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_440:
						break;
						IL_DE:
						csvFile = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile();
						enumerator = headerList.GetEnumerator();
						num = (short)926416896;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_CB;
					}
					finally
					{
						num = (short)1546518528;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_475;
								}
								continue;
							case 1:
								goto IL_4AB;
							case 2:
								csvWriter.Dispose();
								num = (short)2035023873;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_475:
							if (csvWriter == null)
							{
								break;
							}
							num = (short)2023489538;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_4AB:;
					}
					break;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0004B5C0 File Offset: 0x000497C0
		private string a(global::Infragistics.Controls.Grids.ColumnBase A_0, global::Infragistics.Controls.Grids.CellBase A_1)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
				switch (num)
				{
				case 0:
					if (A_1.Value != null)
					{
						num2 = (short)176750594;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					result = fieldBase.ToString();
					num2 = (short)1236467717;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					fieldBase = (A_1.Value as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase);
					num2 = (short)300285956;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
				{
					num2 = (short)928941245;
					short num3 = num2;
					num2 = (short)1609794749;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2A2;
					default:
						num2 = (short)1659371520;
						if (num2 != 0)
						{
						}
						if (fieldBase != null)
						{
							num2 = (short)632815622;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 5:
					return result;
				case 6:
				{
					num2 = (short)1339686912;
					short num4 = num2;
					num2 = (short)235929610;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					if (fieldBase.IsVisible)
					{
						num2 = (short)961937409;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = string.Empty;
					num2 = (short)623247363;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (A_0.Key == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud89c쎠욢솤쎦첨쾪ﺬ쪮얰\udab4쒶킸쾺풼킾꿀", a_))
					{
						num2 = (short)1379139596;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1316618247;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					result = ((fieldBase.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.Set).Position + 1).ToString(global::System.Globalization.CultureInfo.CurrentCulture);
					num2 = (short)482869259;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)1035337729;
					if (num2 != 0)
					{
					}
					if (!(A_0.Key == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("출튠쪢톤캦욨얪", a_)))
					{
						num2 = (short)1516109838;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28B;
				case 11:
					return result;
				case 12:
					goto IL_28B;
				case 13:
					goto IL_2A2;
				case 14:
					num2 = (short)134807560;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_55;
				IL_28B:
				num2 = (short)31064077;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2A2:
				if (fieldBase.Parent == null)
				{
					break;
				}
				num2 = (short)815398921;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_55:
			result = string.Empty;
			num2 = (short)331874304;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
