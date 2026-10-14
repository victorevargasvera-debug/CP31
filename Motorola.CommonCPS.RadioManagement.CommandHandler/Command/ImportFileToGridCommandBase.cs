using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility.CSV;
using Motorola.CommonCPS.Common.CommonUtility.ExcelFile;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000026 RID: 38
	public abstract class ImportFileToGridCommandBase : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060001F6 RID: 502 RVA: 0x00019528 File Offset: 0x00017728
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 12;
			short num = (short)2127036416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_61;
				}
				string text;
				for (;;)
				{
					IL_32:
					global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)213254148;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_1BA;
								case 2:
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1142489091;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string str = enumerator.Current;
									text = text + str + global::System.Environment.NewLine;
									num = (short)1898184704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1364656129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_13A;
									}
									continue;
								}
								IL_16C:
								num = (short)1179385858;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13A:
								goto IL_16C;
							}
							IL_1BA:
							goto IL_1FB;
						}
						finally
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1CA;
					case 1:
					{
						global::System.Collections.Generic.List<string> list;
						if (!this.ValidateFileFormateNew(csvFile, out list))
						{
							num = (short)1260978183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BF;
					}
					case 2:
						if (csvFile.RecordCount == 0)
						{
							num = (short)929366019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CA;
					case 3:
						goto IL_FB;
					case 4:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_30A;
							}
							bool hasHeaderAlias;
							for (;;)
							{
								IL_2EF:
								switch (num2)
								{
								case 0:
									csvFile = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile();
									csvFile.Populate(this.filePath, true, hasHeaderAlias, false);
									num = (short)1369702402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_41F;
								case 2:
									goto IL_406;
								case 3:
									goto IL_406;
								case 4:
									if (this.filePath.EndsWith(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("폼鳾爀甂", a_), global::System.StringComparison.CurrentCultureIgnoreCase))
									{
										goto IL_392;
									}
									csvFile = this.PopulateExcel2Csv(this.filePath, true, hasHeaderAlias, false);
									num = (short)586547203;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_30A;
								IL_406:
								num = (short)1141047297;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_41F:
							goto IL_263;
							IL_30A:
							hasHeaderAlias = this.HasHeaderAliasRow();
							num = (short)2061204732;
							short num3 = num;
							num = (short)277052668;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_392:
								num = (short)253100032;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_2EF;
							default:
								num = (short)993460224;
								if (num != 0)
								{
								}
								num = (short)1595801604;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_2EF;
							}
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null), global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
							return null;
						}
						catch (global::System.Exception)
						{
							string content = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ImportCsv_FileCantBeOpened, global::System.IO.Path.GetFileNameWithoutExtension(this.filePath));
							base.Interaction.ShowNotificationDialog(content, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
							return null;
						}
						goto IL_491;
						IL_263:
						num = (short)2142568449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1F9;
					case 6:
					{
						text = null;
						global::System.Collections.Generic.List<string> list;
						global::System.Collections.Generic.List<string>.Enumerator enumerator = list.GetEnumerator();
						num = (short)30343168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1076428801;
						if (num != 0)
						{
						}
						goto IL_491;
					case 8:
					{
						global::System.Collections.Generic.List<string> list;
						if (list.Count > 0)
						{
							num = (short)1367736326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BF;
					}
					case 9:
						if (!string.IsNullOrEmpty(this.filePath))
						{
							num = (short)178061316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20F;
					}
					goto IL_61;
					IL_BF:
					num = (short)687341570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CA:
					this.PreprocessImportData(csvFile);
					global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string> importBatchOp = this.GetImportBatchOp(csvFile);
					base.ExecuteBatchOp<string>(importBatchOp);
					num = (short)411828229;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_491:
					num = (short)2072641544;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FB:
				base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ImportCSV_Empty, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
				return null;
				IL_1F9:
				goto IL_20F;
				IL_1FB:
				base.Interaction.ShowNotificationDialog(text, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
				return null;
				IL_20F:
				num = (short)1867382784;
				short num4 = num;
				return null;
				IL_61:
				this.ProcessParameters(paras);
				this.filePath = base.Interaction.ShowOpenFileDialogForImportFromCSV(false);
				num = (short)223346697;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00019A58 File Offset: 0x00017C58
		protected virtual void ProcessParameters(params object[] paras)
		{
			short num = (short)1189216257;
			if (num != 0)
			{
			}
			num = (short)1972895744;
			short num2 = num;
			num = (short)1155657382;
			short num3 = num;
			num = (short)650309286;
			switch (num3 == num)
			{
			}
			num = (short)1909587968;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00019B04 File Offset: 0x00017D04
		protected virtual void PreprocessImportData(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile)
		{
			short num = (short)1126978448;
			short num2 = num;
			num = (short)197415824;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1749024768;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2023292929;
			if (num != 0)
			{
			}
			num = (short)1696006144;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001F9 RID: 505
		protected abstract bool HasHeaderAliasRow();

		// Token: 0x060001FA RID: 506
		protected abstract global::System.Collections.Generic.IEnumerable<string> GetRequiredHeadersList();

		// Token: 0x060001FB RID: 507
		protected abstract global::System.Collections.Generic.IEnumerable<string> GetValidHeadersList();

		// Token: 0x060001FC RID: 508
		protected abstract global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string> GetImportBatchOp(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile);

		// Token: 0x060001FD RID: 509 RVA: 0x00019BAC File Offset: 0x00017DAC
		protected global::System.Collections.Generic.List<string> GetFieldHeader(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile, string fieldName)
		{
			short num = (short)956669761;
			short num2 = num;
			num = (short)1630052161;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1723531264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1435631617;
			if (num != 0)
			{
			}
			num = (short)1232797696;
			if (num != 0)
			{
			}
			return csvFile.Headers.FindAll(delegate(string h)
			{
				short num4 = (short)244253844;
				short num5 = num4;
				num4 = (short)1222509716;
				switch (num5 == num4)
				{
				}
				num4 = (short)1142947840;
				short num6 = num4;
				num4 = (short)1605173249;
				if (num4 != 0)
				{
				}
				num4 = (short)1703739392;
				if (num4 != 0)
				{
				}
				return h.Trim().Equals(fieldName, global::System.StringComparison.OrdinalIgnoreCase);
			});
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00019C78 File Offset: 0x00017E78
		protected virtual bool ValidateFileFormateNew(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile, out global::System.Collections.Generic.List<string> errorList)
		{
			int a_ = 12;
			short num = (short)1172635648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::System.Collections.Generic.IEnumerator<string> enumerator;
				string text2;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_343;
					case 1:
						try
						{
							num = (short)227999753;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2074673153;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = enumerator.Current;
									global::System.Collections.Generic.List<string> fieldHeader = this.GetFieldHeader(csvFile, text);
									num = (short)1512177667;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1539768326;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<string> fieldHeader;
									int index = csvFile.Headers.IndexOf(fieldHeader[0]);
									csvFile.Headers.RemoveAt(index);
									string text;
									csvFile.Headers.Insert(index, text);
									num = (short)1363279879;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Collections.Generic.List<string> fieldHeader;
									if (fieldHeader.Count > 1)
									{
										num = (short)114360325;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)95354884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Collections.Generic.List<string> fieldHeader;
									if (fieldHeader.Count == 1)
									{
										num = (short)211484674;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									string text;
									text2 = text2 + text + global::Motorola.CommonCPS.ResourceRepository.Resources.STR_COMMA;
									num = (short)933953544;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_250;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_F5;
									}
									continue;
								}
								IL_186:
								num = (short)1523253248;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F5:
								goto IL_186;
							}
							IL_250:
							goto IL_4D4;
						}
						finally
						{
							for (;;)
							{
								IL_255:
								num = (short)108396546;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_30F;
									case 1:
									{
										num = (short)807744572;
										short num3 = num;
										num = (short)1430533180;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_255;
										default:
											num = (short)53739520;
											if (num != 0)
											{
											}
											enumerator.Dispose();
											num = (short)884146176;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_288;
										}
										continue;
									}
									IL_288:
									if (enumerator == null)
									{
										goto IL_311;
									}
									num = (short)1554644993;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_30F:
							IL_311:;
						}
						goto IL_312;
					case 2:
						if (text2 != global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ImportCsv_FileDuplicateHeadings)
						{
							num = (short)972095488;
							short num4 = num;
							num = (short)1882718211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56B;
					case 3:
						goto IL_312;
					case 4:
						try
						{
							num = (short)33357825;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1535508486;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text3 = enumerator.Current;
									num = (short)558694405;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_38A;
									}
									continue;
								case 3:
									goto IL_464;
								case 4:
								{
									string text3;
									errorList.Add(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ImportCsv_FileMissingHeadings + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("\uddfc", a_) + text3);
									num = (short)1920729090;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									string text3;
									if (this.GetFieldHeader(csvFile, text3).Count == 0)
									{
										num = (short)130940932;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)1996423171;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_40D:
								num = (short)533135360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_38A:
								goto IL_40D;
							}
							IL_464:
							goto IL_541;
						}
						finally
						{
							num = (short)1892220929;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)533725186;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_49B;
									}
									continue;
								case 2:
									goto IL_4D1;
								}
								IL_49B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1158676480;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4D1:;
						}
						goto IL_4D4;
						IL_541:
						enumerator = this.GetValidHeadersList().GetEnumerator();
						num = (short)292683777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B;
					IL_312:
					text2 = text2.Substring(0, text2.Length - 1);
					errorList.Add(text2);
					num = (short)812646400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D4:
					num = (short)581566466;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_343:
				IL_56B:
				return errorList.Count == 0;
				IL_4B:
				errorList = new global::System.Collections.Generic.List<string>();
				text2 = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ImportCsv_FileDuplicateHeadings;
				enumerator = this.GetRequiredHeadersList().GetEnumerator();
				num = (short)2066415617;
				if (num != 0)
				{
				}
				num = (short)1695023108;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0001A230 File Offset: 0x00018430
		protected virtual global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile PopulateExcel2Csv(string filePath, bool hasHeaderRow, bool hasHeaderAlias, bool hasRangeRow = false)
		{
			short num = (short)291481602;
			short num2 = num;
			num = (short)1977067522;
			switch (num2 == num)
			{
			}
			num = (short)1293484032;
			short num3 = num;
			num = (short)566820865;
			if (num != 0)
			{
			}
			num = (short)1656881152;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile().Excel2Csv(filePath, hasHeaderRow, hasHeaderAlias, hasRangeRow);
		}

		// Token: 0x0400002C RID: 44
		protected string filePath;
	}
}
