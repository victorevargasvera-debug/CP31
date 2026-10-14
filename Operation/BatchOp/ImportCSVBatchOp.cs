using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.Common.CommonUtility.CSV;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200001E RID: 30
	public abstract class ImportCSVBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportFileToGridBatchOpBase
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CB RID: 203
		protected abstract global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier Pac { get; }

		// Token: 0x060000CC RID: 204 RVA: 0x00014748 File Offset: 0x00012948
		protected ImportCSVBatchOp(global::Motorola.CommonCPS.RadioManagement.UIModels.Group currentGroup, global::System.Globalization.CultureInfo cultureInfo, global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile) : base(csvFile, cultureInfo)
		{
			this.a = currentGroup;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00014764 File Offset: 0x00012964
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Group CurrentGroup
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1133140415;
				short num2 = num;
				num = (short)352410047;
				switch (num2 == num)
				{
				}
				num = (short)1293942784;
				short num3 = num;
				num = (short)1952317441;
				if (num != 0)
				{
				}
				num = (short)1024851968;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00014814 File Offset: 0x00012A14
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000148C4 File Offset: 0x00012AC4
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage> GeneralPackages
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)953769050;
				short num2 = num;
				num = (short)1512332378;
				switch (num2 == num)
				{
				}
				num = (short)1315045376;
				short num3 = num;
				num = (short)245563392;
				if (num != 0)
				{
				}
				num = (short)314048513;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1955719040;
				short num2 = num;
				num = (short)331409280;
				switch (num2 == num)
				{
				}
				num = (short)1109196800;
				short num3 = num;
				num = (short)184221697;
				if (num != 0)
				{
				}
				num = (short)660799488;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00014974 File Offset: 0x00012B74
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 19;
			short num = (short)1311375361;
			if (num != 0)
			{
			}
			num = (short)1130168320;
			switch (num)
			{
			default:
			{
				num = (short)1634992128;
				short num2 = num;
				int num3 = 0;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
				global::System.Threading.Thread.CurrentThread.CurrentCulture = this.cultureInfo;
				bool flag = false;
				try
				{
					flag = this.a();
					goto IL_16A4;
				}
				catch (global::System.Exception ex)
				{
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord>.Enumerator enumerator = this.csvFile.Records.GetEnumerator())
					{
						num = (short)1384185861;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							string text;
							switch (num4)
							{
							case 0:
								num = (short)191561736;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1360134144;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord = enumerator.Current;
								text = string.Empty;
								num = (short)758513671;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord;
								text = csvRecord.Fields[0];
								num = (short)906756099;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_172C;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_172A;
								}
								continue;
							case 6:
								num = (short)785317897;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord;
								if (csvRecord != null)
								{
									num = (short)968359942;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_172C;
							}
							case 8:
								goto IL_188B;
							case 9:
							{
								global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord;
								if (csvRecord.Fields.Count > 0)
								{
									num = (short)915603458;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_172C;
							}
							}
							goto IL_172A;
							IL_172C:
							global::Motorola.Common.CustomException.CommonException exp = new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ImportCsv_OneOperation_Fail, new string[]
							{
								text,
								ex.Message
							}));
							base.CreateFailJob(exp, text);
							num = (short)89325572;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_179B:
							num = (short)994836481;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_172A:
							goto IL_179B;
						}
						IL_188B:;
					}
					throw;
				}
				return;
				for (;;)
				{
					IL_16A4:
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord>.Enumerator enumerator = this.csvFile.Records.GetEnumerator())
					{
						num = (short)2080047107;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
							global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer3;
							switch (num4)
							{
							case 0:
								automaticPerformanceMeasurer = null;
								goto IL_1A4;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1630863366;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord2 = enumerator.Current;
								num = (short)1515061253;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_1691;
							case 3:
							{
								num = (short)1169759292;
								short num5 = num;
								num = (short)1158028348;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)28639232;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_129;
									}
									continue;
								}
								break;
							}
							case 4:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_229;
									}
									global::System.Collections.Generic.List<string> list;
									global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.<>c__DisplayClass10_0 CS$<>8__locals1;
									for (;;)
									{
										IL_20E:
										switch (num4)
										{
										case 0:
											try
											{
												num = (short)757989404;
												num4 = (int)((global::System.IntPtr)num);
												string text2;
												for (;;)
												{
													global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord2;
													global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
													global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer4;
													global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
													global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer5;
													global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer6;
													global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer7;
													global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer8;
													switch (num4)
													{
													case 0:
														if (flag)
														{
															num = (short)1211301911;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_6FD;
													case 1:
														automaticPerformanceMeasurer2 = automaticPerformanceMeasurer3.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportCsv, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("釗럙곛뇝鋟雡쓣雥髧迩迫蛭闯釱鿳", a_)));
														goto IL_13BA;
													case 2:
														num = (short)1717764107;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 3:
														if (list.Count > 0)
														{
															num = (short)627638325;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_E27;
													case 4:
														automaticPerformanceMeasurer4 = null;
														goto IL_D46;
													case 5:
													{
														try
														{
															global::Motorola.CommonCPS.RadioManagement.SharedServices.ImportCSVCache importCSVCache = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ImportCSVCache();
															try
															{
																string templateName;
																string configName;
																string copyFromRadio;
																CS$<>8__locals1.radioRq = radioService.HandleTemplateAndConfigForImportCSV(radio, templateName, configName, copyFromRadio, CS$<>8__locals1.radioRq, importCSVCache, ref list);
																string ipProgramSystemName;
																CS$<>8__locals1.radioRq = radioService.HandleIPProgramSystemForImportCSV(radio, ipProgramSystemName, copyFromRadio, CS$<>8__locals1.radioRq, importCSVCache, ref list);
															}
															finally
															{
																num = (short)337969154;
																num4 = (int)((global::System.IntPtr)num);
																for (;;)
																{
																	switch (num4)
																	{
																	case 0:
																		goto IL_B9A;
																	case 1:
																		((global::System.IDisposable)importCSVCache).Dispose();
																		num = (short)617938944;
																		num4 = (int)((global::System.IntPtr)num);
																		continue;
																	case 2:
																		switch (0)
																		{
																		case 0:
																			goto IL_B62;
																		}
																		continue;
																	}
																	IL_B62:
																	if (importCSVCache == null)
																	{
																		break;
																	}
																	num = (short)2080309249;
																	num4 = (int)((global::System.IntPtr)num);
																}
																IL_B9A:;
															}
															goto IL_EEE;
														}
														finally
														{
															num = (short)20905986;
															num4 = (int)((global::System.IntPtr)num);
															for (;;)
															{
																switch (num4)
																{
																case 0:
																	goto IL_C0C;
																case 1:
																	automaticPerformanceMeasurer5.Dispose();
																	num = (short)1615462400;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																case 2:
																	switch (0)
																	{
																	case 0:
																		goto IL_BD4;
																	}
																	continue;
																}
																IL_BD4:
																if (automaticPerformanceMeasurer5 == null)
																{
																	break;
																}
																num = (short)1353515009;
																num4 = (int)((global::System.IntPtr)num);
															}
															IL_C0C:;
														}
														goto IL_C0F;
														IL_EEE:
														global::System.Collections.Generic.IList<string> delCharFields;
														this.ValidateSpecialFields(CS$<>8__locals1.radioRq, radio, delCharFields);
														num = (short)489291810;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 6:
														if (!string.IsNullOrEmpty(text2))
														{
															num = (short)1103167514;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_80E;
													case 7:
														try
														{
															CS$<>8__locals1.radioRq.GroupName = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.CheckGroupNameBeforeImportingFromFile(CS$<>8__locals1.radioRq.GroupName, this.CurrentGroup);
															goto IL_1431;
														}
														finally
														{
															num = (short)505151490;
															num4 = (int)((global::System.IntPtr)num);
															for (;;)
															{
																switch (num4)
																{
																case 0:
																	goto IL_9C8;
																case 1:
																	automaticPerformanceMeasurer5.Dispose();
																	num = (short)826933248;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																case 2:
																	switch (0)
																	{
																	case 0:
																		goto IL_98F;
																	}
																	continue;
																}
																IL_98F:
																if (automaticPerformanceMeasurer5 == null)
																{
																	break;
																}
																num = (short)558432257;
																num4 = (int)((global::System.IntPtr)num);
															}
															IL_9C8:;
														}
														goto IL_9CB;
														IL_1431:
														num = (short)720568337;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 8:
														list.Add(CS$<>8__locals1.radioRq.WarningMsg);
														num = (short)403898386;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 9:
														if (csvRecord2.FieldCount >= this.csvFile.HeaderCount)
														{
															num = (short)277938209;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														csvRecord2.Fields.Add("");
														num = (short)1618608143;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 10:
														if (automaticPerformanceMeasurer3 == null)
														{
															num = (short)1036058665;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														num = (short)2049769512;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 11:
														automaticPerformanceMeasurer2 = null;
														goto IL_13BA;
													case 12:
														if (automaticPerformanceMeasurer3 == null)
														{
															num = (short)775421954;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														num = (short)1265238017;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 13:
														goto IL_1527;
													case 14:
													{
														bool flag2;
														if (!flag2)
														{
															num = (short)424083503;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_80E;
													}
													case 15:
														goto IL_A7A;
													case 16:
														goto IL_E27;
													case 17:
														if (!string.IsNullOrEmpty(CS$<>8__locals1.radioRq.Comments))
														{
															num = (short)1867448339;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														CS$<>8__locals1.radioRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.<>c__DisplayClass10_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.<>c__DisplayClass10_0.radioRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest.get_Comments())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
														num = (short)1045168163;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 18:
														goto IL_A29;
													case 19:
														goto IL_C0F;
													case 20:
														if (automaticPerformanceMeasurer3 == null)
														{
															num = (short)89587748;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														num = (short)635830293;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 21:
														automaticPerformanceMeasurer6 = automaticPerformanceMeasurer3.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportCsv, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鯗닙맛뷝诟싡ꏣ铥蟧鿩鳫컭뻯鏱駳鏵", a_)));
														goto IL_E63;
													case 22:
														goto IL_D65;
													case 23:
														goto IL_9CB;
													case 24:
														automaticPerformanceMeasurer4 = automaticPerformanceMeasurer3.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportCsv, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("軗믙냛럝蓟菡郣菥죧賩藫语鳯雱蟳", a_)));
														goto IL_D46;
													case 25:
														CS$<>8__locals1.radioRq.Comments = string.Empty;
														num = (short)1191510070;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 26:
														goto IL_88C;
													case 27:
														try
														{
															radio = this.AddDevice(CS$<>8__locals1.radioRq, radioService);
															goto IL_1013;
														}
														finally
														{
															num = (short)1403715584;
															num4 = (int)((global::System.IntPtr)num);
															for (;;)
															{
																switch (num4)
																{
																case 0:
																	switch (0)
																	{
																	case 0:
																		goto IL_DEC;
																	}
																	continue;
																case 1:
																	goto IL_E24;
																case 2:
																	automaticPerformanceMeasurer5.Dispose();
																	num = (short)167313409;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																IL_DEC:
																if (automaticPerformanceMeasurer5 == null)
																{
																	break;
																}
																num = (short)1899823106;
																num4 = (int)((global::System.IntPtr)num);
															}
															IL_E24:;
														}
														goto IL_E27;
														IL_1013:
														num = (short)669515776;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 28:
														switch (0)
														{
														case 0:
															goto IL_3A4;
														}
														continue;
													case 29:
														CS$<>8__locals1.radioRq.Comments = string.Empty;
														list.Add(global::Motorola.CommonCPS.Common.CommonUtility.WarningMessageConverter.OriginalToSource(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(null, methodof(global::Motorola.CommonCPS.ResourceRepository.Resources.get_RMC_CommentLength_Warning_For_ImportCSV())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())), 0));
														num = (short)892207126;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 30:
													{
														if (!string.IsNullOrEmpty(text2))
														{
															num = (short)1621491760;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														bool flag2 = false;
														num = (short)2141847590;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 31:
														automaticPerformanceMeasurer7 = null;
														goto IL_ECE;
													case 32:
														try
														{
															num = (short)1292173312;
															num4 = (int)((global::System.IntPtr)num);
															for (;;)
															{
																global::Motorola.CommonCPS.Server.EntityModel.Radio radio2;
																switch (num4)
																{
																case 0:
																	switch (0)
																	{
																	case 0:
																		goto IL_10E5;
																	}
																	continue;
																case 1:
																{
																	global::System.Collections.Generic.Dictionary<string, string> dictionary;
																	bool flag2 = base.ValidationServiceFactory.UIValidateService.ValidateRadioWithMVOForImportCSV(CS$<>8__locals1.radioRq, radio2, dictionary);
																	num = (short)533331974;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																case 2:
																	goto IL_132E;
																case 3:
																{
																	global::System.Collections.Generic.Dictionary<string, string> dictionary;
																	if (dictionary.Count > 0)
																	{
																		num = (short)1009516549;
																		num4 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	goto IL_132E;
																}
																case 4:
																	goto IL_132E;
																case 5:
																{
																	global::System.Collections.Generic.Dictionary<string, string> dictionary;
																	text2 = dictionary.First<global::System.Collections.Generic.KeyValuePair<string, string>>().Value;
																	num = (short)1385758722;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																case 6:
																	goto IL_115D;
																case 7:
																	goto IL_132E;
																case 8:
																{
																	global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
																	num = (short)629604365;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																case 9:
																	if (!this.IsFiveToneIdFormatValid(radio2))
																	{
																		num = (short)1114127;
																		num4 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	num = (short)42663948;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																case 10:
																	goto IL_132E;
																case 11:
																{
																	global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio3 = CS$<>8__locals1.radioRq.ToUiModel();
																	bool flag2 = base.ValidationServiceFactory.UIValidateService.ValidateNewRadio(radio3, out text2);
																	num = (short)2141323271;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																case 12:
																{
																	if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.HasMVO(radio2))
																	{
																		num = (short)578355208;
																		num4 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio4 = radio2.ToUiModel(true);
																	bool flag2 = base.ValidationServiceFactory.UIValidateService.ValidateNewRadio(radio4, out text2);
																	num = (short)141426692;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																case 13:
																	if (!flag)
																	{
																		num = (short)2126184449;
																		num4 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	goto IL_115D;
																case 14:
																	goto IL_1346;
																case 15:
																	text2 = global::Motorola.CommonCPS.ResourceRepository.Resources.Five_Tone_Id_Format_Error;
																	num = (short)427622410;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																IL_10E5:
																if (radio == null)
																{
																	num = (short)1660223499;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																radio2 = global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.UpdateRadioFromCSVRequest(CS$<>8__locals1.radioRq, radio);
																num = (short)707592201;
																num4 = (int)((global::System.IntPtr)num);
																continue;
																IL_115D:
																num = (short)1114898435;
																num4 = (int)((global::System.IntPtr)num);
																continue;
																IL_132E:
																num = (short)368246798;
																num4 = (int)((global::System.IntPtr)num);
															}
															IL_1346:
															goto IL_6BF;
														}
														finally
														{
															num = (short)53411840;
															num4 = (int)((global::System.IntPtr)num);
															for (;;)
															{
																switch (num4)
																{
																case 0:
																	switch (0)
																	{
																	case 0:
																		goto IL_137D;
																	}
																	continue;
																case 1:
																	goto IL_13B7;
																case 2:
																	automaticPerformanceMeasurer5.Dispose();
																	num = (short)365625345;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																IL_137D:
																if (automaticPerformanceMeasurer5 == null)
																{
																	break;
																}
																num = (short)968359938;
																num4 = (int)((global::System.IntPtr)num);
															}
															IL_13B7:;
														}
														goto IL_13BA;
													case 33:
													{
														global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.ResultForParsingRecord resultForParsingRecord = this.a(this.csvFile, csvRecord2);
														CS$<>8__locals1.radioRq = resultForParsingRecord.csvRequest;
														CS$<>8__locals1.radioRq.IgnoreColumns = new global::System.Collections.Generic.List<string>();
														string templateName = resultForParsingRecord.templateName;
														string configName = resultForParsingRecord.configName;
														string copyFromRadio = resultForParsingRecord.copyFromRadio;
														string ipProgramSystemName = resultForParsingRecord.ipProgramSystemName;
														global::System.Collections.Generic.IList<string> delCharFields = resultForParsingRecord.DelCharFields;
														num = (short)908656650;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 34:
														if (CS$<>8__locals1.radioRq.WarningMsg != null)
														{
															num = (short)56819720;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_A29;
													case 35:
														goto IL_D65;
													case 36:
														num = (short)1169096743;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 37:
														automaticPerformanceMeasurer8 = null;
														goto IL_FF2;
													case 38:
														if (automaticPerformanceMeasurer3 == null)
														{
															num = (short)1813053483;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														num = (short)798228504;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 39:
														automaticPerformanceMeasurer6 = null;
														goto IL_E63;
													case 40:
														automaticPerformanceMeasurer8 = automaticPerformanceMeasurer3.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportCsv, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("駗뻙룛ﻝ닟菡胣迥蟧", a_)));
														goto IL_FF2;
													case 41:
														num = (short)806682661;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 42:
														try
														{
															num = (short)1378942980;
															num4 = (int)((global::System.IntPtr)num);
															for (;;)
															{
																global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
																switch (num4)
																{
																case 0:
																	goto IL_634;
																case 1:
																	if (radioSummary != null)
																	{
																		num = (short)1120206850;
																		num4 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	goto IL_634;
																case 2:
																	base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
																	{
																		radioSummary.ToUiModel(true)
																	});
																	num = (short)1375141895;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																case 3:
																	num = (short)2135556101;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																case 4:
																	switch (0)
																	{
																	case 0:
																		goto IL_42F;
																	}
																	continue;
																case 5:
																{
																	if (this.CheckIsNeedUpdated(CS$<>8__locals1.radioRq, radio))
																	{
																		num = (short)1947336714;
																		num4 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
																	{
																		JobDescription = radio.SerialNumber,
																		JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED,
																		JobContainerUuid = new global::System.Guid?(base.JobContainerGuid),
																		ErrorCode = null,
																		WarningMessage = CS$<>8__locals1.radioRq.WarningMsg
																	};
																	global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddBatchOperationJob(job);
																	num = (short)1142423552;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																case 6:
																	goto IL_64C;
																case 7:
																	goto IL_634;
																case 8:
																{
																	global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary2;
																	base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
																	{
																		radioSummary2.ToUiModel(true)
																	});
																	num = (short)58654729;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																case 9:
																	goto IL_634;
																case 10:
																{
																	global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary2 = radioService.ImportRadioFromCSV(base.JobContainerGuid, CS$<>8__locals1.radioRq, this.a(radio));
																	num = (short)89128971;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																case 11:
																{
																	global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary2;
																	if (radioSummary2 != null)
																	{
																		num = (short)1538261000;
																		num4 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	goto IL_634;
																}
																}
																IL_42F:
																if (radio != null)
																{
																	num = (short)424476675;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																radioSummary = radioService.ImportRadioFromCSV(base.JobContainerGuid, CS$<>8__locals1.radioRq, null);
																num = (short)1231355905;
																num4 = (int)((global::System.IntPtr)num);
																continue;
																IL_634:
																num = (short)240975878;
																num4 = (int)((global::System.IntPtr)num);
															}
															IL_64C:
															goto IL_150D;
														}
														finally
														{
															num = (short)473890818;
															num4 = (int)((global::System.IntPtr)num);
															for (;;)
															{
																switch (num4)
																{
																case 0:
																	goto IL_6BC;
																case 1:
																	automaticPerformanceMeasurer5.Dispose();
																	num = (short)361758720;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																case 2:
																	switch (0)
																	{
																	case 0:
																		goto IL_683;
																	}
																	continue;
																}
																IL_683:
																if (automaticPerformanceMeasurer5 == null)
																{
																	break;
																}
																num = (short)1920663553;
																num4 = (int)((global::System.IntPtr)num);
															}
															IL_6BC:;
														}
														goto IL_6BF;
														IL_150D:
														num = (short)2145124365;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 43:
														num = (short)983695364;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 44:
														goto IL_6FD;
													case 45:
														if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.radioRq.Comments))
														{
															num = (short)1244528665;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_D65;
													case 46:
														if (CS$<>8__locals1.radioRq.Comments.Length > 1024)
														{
															num = (short)940965917;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														num = (short)1334706221;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 47:
														num = (short)879951878;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 48:
														goto IL_A75;
													case 49:
														automaticPerformanceMeasurer7 = automaticPerformanceMeasurer3.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportCsv, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("釗럙곛뇝鋟雡쓣铥觧軩藫臭", a_)));
														goto IL_ECE;
													case 50:
														num = (short)587726879;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 51:
														goto IL_3D3;
													case 52:
														if (automaticPerformanceMeasurer3 == null)
														{
															num = (short)234946610;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														num = (short)1408565297;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 53:
														CS$<>8__locals1.radioRq.WarningMsg = list[0];
														list.Clear();
														num = (short)1015545872;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 54:
														goto IL_D65;
													}
													IL_3A4:
													if (csvRecord2.FieldCount > this.csvFile.HeaderCount)
													{
														num = (short)445972531;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_A7A;
													IL_6BF:
													num = (short)1722351630;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_6FD:
													num = (short)906821652;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_80E:
													num = (short)572194819;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_9CB:
													this.ValidateRadioWithGeneralPackage(radio);
													num = (short)1586757676;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_A29:
													this.GenerateRelatedIPs(CS$<>8__locals1.radioRq, out text2);
													num = (short)1206452254;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_A7A:
													num = (short)1301741577;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_C0F:
													num = (short)2101280814;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_D46:
													automaticPerformanceMeasurer5 = automaticPerformanceMeasurer4;
													num = (short)1767309344;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_D65:
													num = (short)373489676;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_E27:
													num = (short)454295604;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_E63:
													automaticPerformanceMeasurer5 = automaticPerformanceMeasurer6;
													num = (short)1729101831;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_ECE:
													automaticPerformanceMeasurer5 = automaticPerformanceMeasurer7;
													num = (short)21364778;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_FF2:
													automaticPerformanceMeasurer5 = automaticPerformanceMeasurer8;
													num = (short)981860379;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_13BA:
													automaticPerformanceMeasurer5 = automaticPerformanceMeasurer2;
													num = (short)658178053;
													num4 = (int)((global::System.IntPtr)num);
												}
												IL_3D3:
												throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CSVFileFormat_Error);
												IL_88C:
												throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_InvalidField_For_ImportCSV, new string[]
												{
													text2
												}));
												IL_A75:
												throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_InvalidField_For_ImportCSV, new string[]
												{
													text2
												}));
												IL_1527:;
											}
											catch (global::Motorola.Common.CustomException.CommonException ex2)
											{
												if (ex2.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.SFC_RM_MAXLIMIT_LICENSE)
												{
													return;
												}
												string discription = string.Empty;
												global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord2;
												if (csvRecord2 != null && csvRecord2.Fields.Count > 0)
												{
													discription = csvRecord2.Fields[0];
												}
												base.CreateFailJob(ex2, discription);
											}
											catch (global::System.Exception ex3)
											{
												string text3 = string.Empty;
												global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord2;
												if (csvRecord2 != null && csvRecord2.Fields.Count > 0)
												{
													text3 = csvRecord2.Fields[0];
												}
												global::Motorola.Common.CustomException.CommonException exp2 = new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ImportCsv_OneOperation_Fail, new string[]
												{
													text3,
													ex3.Message
												}));
												base.CreateFailJob(exp2, text3);
											}
											num3++;
											base.ReportProgress(num3);
											num = (short)2100494340;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_29D;
										case 2:
											num = (short)220069889;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											if (base.CancellationPending)
											{
												num = (short)682622978;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1141768192;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											goto IL_1606;
										}
										goto IL_229;
									}
									IL_29D:
									return;
									IL_1606:
									break;
									IL_229:
									CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.<>c__DisplayClass10_0();
									list = new global::System.Collections.Generic.List<string>();
									num = (short)903479299;
									num4 = (int)((global::System.IntPtr)num);
									goto IL_20E;
								}
								finally
								{
									num = (short)1016463360;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_163D;
											}
											continue;
										case 1:
											goto IL_1675;
										case 2:
											automaticPerformanceMeasurer3.Dispose();
											num = (short)376635393;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_163D:
										if (automaticPerformanceMeasurer3 == null)
										{
											break;
										}
										num = (short)2130706434;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_1675:;
								}
								goto IL_1678;
							case 5:
							{
								global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer = this.Measurer;
								if (measurer == null)
								{
									num = (short)1382744064;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord2;
								automaticPerformanceMeasurer = measurer.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportCsv, null).AddOrUpdateParameter(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("裗믙꣛뛝", a_), csvRecord2.Fields[0]));
								goto IL_1A4;
							}
							case 6:
								goto IL_1678;
							}
							goto IL_129;
							IL_1A4:
							automaticPerformanceMeasurer3 = automaticPerformanceMeasurer;
							num = (short)585105412;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_1C1:
							num = (short)759037953;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_129:
							goto IL_1C1;
							IL_1678:
							num = (short)301268994;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_1691:
						break;
					}
				}
				return;
			}
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00016344 File Offset: 0x00014544
		protected virtual bool IsFiveToneIdFormatValid(global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadioClone)
		{
			short num = (short)1252220956;
			short num2 = num;
			num = (short)1867210780;
			switch (num2 == num)
			{
			}
			num = (short)322437121;
			if (num != 0)
			{
			}
			num = (short)1723006976;
			if (num != 0)
			{
			}
			num = (short)381878272;
			short num3 = num;
			return true;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000163EC File Offset: 0x000145EC
		private bool a()
		{
			int a_ = 5;
			short num = (short)278921221;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.csvFile.HeaderAlias.Count == 3)
					{
						num = (short)1508442119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					goto IL_16D;
				case 2:
				{
					num = (short)814621979;
					short num3 = num;
					num = (short)640558363;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E6;
					default:
						num = (short)848756736;
						if (num != 0)
						{
						}
						if (this.csvFile.HeaderAlias.Contains(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("髉귋귍믏돑돓돕", a_)))
						{
							num = (short)1369571329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				case 3:
					if (this.csvFile.HeaderAlias.Contains(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("飉귋꫍맏뷑鷓닕", a_)))
					{
						num = (short)310968326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					num = (short)1356136450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 6:
					goto IL_E1;
				case 7:
					num = (short)50003969;
					if (num != 0)
					{
					}
					num = (short)19070979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
					{
						num = (short)381943817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E6;
				case 9:
					goto IL_1A8;
				}
				IL_56:
				if (!this.csvFile.HeaderAlias.Contains(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("髉귋귍믏돑돓돕鳗뿙꿛뷝鋟诡铣鋥臧藩苫", a_)))
				{
					num = (short)1966735364;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_16D;
				IL_E6:
				this.GeneralPackages = base.LocalService.ListGeneralPackages().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage>();
				num = (short)1635188736;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16D:
				num = (short)438435848;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E1:
			return this.csvFile.HeaderAlias.Contains(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("駉꧋볍맏돑룓飕귗럙뻛믝鋟", a_));
			IL_1A8:
			num = (short)1488846848;
			short num4 = num;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Package_File_Mode_Mismatch, null);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000166A0 File Offset: 0x000148A0
		protected virtual void ValidateRadioWithGeneralPackage(global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio)
		{
			short num = (short)2060348136;
			short num2 = num;
			num = (short)1494706920;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)328400896;
				if (num != 0)
				{
				}
				if (existedRadio != null)
				{
					num = (short)1121714176;
					short num3 = num;
					return;
				}
				break;
			}
			num = (short)64421889;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0001675C File Offset: 0x0001495C
		protected virtual global::Motorola.CommonCPS.Server.EntityModel.Radio AddDevice(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest req, global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService service)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			string serialNumber;
			string text;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::Motorola.CommonCPS.Server.EntityModel.Radio radioBySerialNumber;
					req.Uuid = new global::System.Guid?(radioBySerialNumber.Uuid);
					service.CheckRadioWorkingCodeplugCanBeOverwrite(radioBySerialNumber);
					num2 = (short)1552351233;
					if (num2 != 0)
					{
					}
					num2 = (short)1391294388;
					short num3 = num2;
					num2 = (short)111179700;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14E;
					case 1:
						break;
					default:
					{
						num2 = (short)1476460544;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1935605760;
					if (num2 != 0)
					{
					}
					num2 = (short)1444610051;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					if (!this.a(ref serialNumber, out text))
					{
						num2 = (short)969342978;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					req.SerialNumber = serialNumber;
					req.DeviceID = serialNumber;
					global::Motorola.CommonCPS.Server.EntityModel.Radio radioBySerialNumber = service.GetRadioBySerialNumber(req.SerialNumber, true);
					goto IL_14E;
				}
				case 2:
					goto IL_63;
				case 3:
				{
					global::Motorola.CommonCPS.Server.EntityModel.Radio radioBySerialNumber;
					return radioBySerialNumber;
				}
				case 4:
				{
					global::Motorola.CommonCPS.Server.EntityModel.Radio radioBySerialNumber;
					if (radioBySerialNumber != null)
					{
						num2 = (short)1026293760;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return radioBySerialNumber;
				}
				}
				goto IL_24;
				IL_14E:
				num2 = (short)1840119812;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_63:
			throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_InvalidField_For_ImportCSV, new string[]
			{
				text
			}));
			IL_24:
			serialNumber = req.SerialNumber;
			num2 = (short)1915224065;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00016908 File Offset: 0x00014B08
		protected virtual bool ResetToDefault(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest req, string fieldName, string value)
		{
			short num = (short)170434454;
			short num2 = num;
			num = (short)1832034198;
			switch (num2 == num)
			{
			}
			num = (short)1456340993;
			if (num != 0)
			{
			}
			num = (short)1305739264;
			if (num != 0)
			{
			}
			num = (short)1158610944;
			short num3 = num;
			return false;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000169B4 File Offset: 0x00014BB4
		protected virtual void GenerateRelatedIPs(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, out string error)
		{
			short num = (short)1993712239;
			short num2 = num;
			num = (short)1632084591;
			switch (num2 == num)
			{
			}
			num = (short)1293680640;
			if (num != 0)
			{
			}
			num = (short)1346699265;
			if (num != 0)
			{
			}
			num = (short)1611792384;
			short num3 = num;
			error = null;
		}

		// Token: 0x060000D7 RID: 215
		protected abstract global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest CreateImportCSVRequest();

		// Token: 0x060000D8 RID: 216 RVA: 0x00016A60 File Offset: 0x00014C60
		protected virtual void ValidateSpecialFields(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio, global::System.Collections.Generic.IList<string> delCharFields)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					CS$<>8__locals1.radioRq.RadioAlias = null;
					num2 = (short)1530986503;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.radioRq.RadioAlias))
					{
						num2 = (short)749076480;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					goto IL_6D;
				case 3:
					if (CS$<>8__locals1.radioRq == null)
					{
						num2 = (short)383188994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)150208516;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (CS$<>8__locals1.radioRq.RadioAlias == null)
					{
						num2 = (short)1901395973;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)720371713;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1363869702;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_C3;
				case 7:
					return;
				}
				goto IL_30;
			}
			IL_6D:
			num2 = (short)283526073;
			short num3 = num2;
			num2 = (short)29180857;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_30:
				num2 = (short)459472899;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)911671297;
				if (num2 != 0)
				{
				}
				num2 = (short)1339359232;
				if (num2 != 0)
				{
				}
				num2 = (short)2137391104;
				short num4 = num2;
				return;
			}
			}
			IL_C3:
			global::System.Collections.Generic.List<string> ignoreColumns = CS$<>8__locals1.radioRq.IgnoreColumns;
			if (ignoreColumns == null)
			{
				return;
			}
			ignoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.<>c__DisplayClass18_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.<>c__DisplayClass18_0.radioRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest.get_RadioAlias())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00016C98 File Offset: 0x00014E98
		protected virtual int ConvertPasswordPolicy(string value)
		{
			short num = (short)1690238977;
			if (num != 0)
			{
			}
			num = (short)1236402190;
			short num2 = num;
			num = (short)1866989582;
			switch (num2 == num)
			{
			}
			num = (short)2034106368;
			if (num != 0)
			{
			}
			num = (short)493486080;
			short num3 = num;
			return 0;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00016D44 File Offset: 0x00014F44
		protected virtual bool CheckIsNeedUpdated(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio)
		{
			short num = (short)223936512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_16F;
				}
				global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug>? copiedRadio;
				bool result;
				global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.<>c__DisplayClass20_0 CS$<>8__locals1;
				for (;;)
				{
					IL_28:
					global::System.Guid? guid;
					global::System.Guid? guid2;
					string text;
					string text2;
					bool flag;
					string text3;
					bool flag2;
					bool flag3;
					string text4;
					switch (num2)
					{
					case 0:
					{
						num = (short)1134121824;
						short num3 = num;
						num = (short)916345696;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_838;
						default:
							num = (short)1151860736;
							if (num != 0)
							{
							}
							if (copiedRadio != null)
							{
								num = (short)1392115776;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)568066082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_C67;
					case 2:
						if (guid != null != (guid2 != null))
						{
							num = (short)13697053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2002452536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						result = true;
						num = (short)703397963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						text = string.Empty;
						goto IL_B8D;
					case 5:
					{
						num = (short)1611726848;
						short num4 = num;
						num = (short)1991180362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						string radioAlias = existedRadio.WorkingCodeplug.RadioAlias;
						if (radioAlias == null)
						{
							num = (short)167444523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text2 = radioAlias.Trim();
						goto IL_6CD;
					}
					case 7:
						flag = false;
						goto IL_DB2;
					case 8:
						result = true;
						num = (short)1879900161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						text3 = null;
						goto IL_717;
					case 10:
						result = true;
						num = (short)1806762008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)613089281;
						if (num != 0)
						{
						}
						num = (short)1101267004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						result = true;
						num = (short)618790925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_4D3;
					case 14:
						if ((text = CS$<>8__locals1.radioRq.Comments) == null)
						{
							num = (short)1969618948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B8D;
					case 15:
						if (guid2 != null)
						{
							num = (short)955056190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A22;
					case 16:
						goto IL_4D3;
					case 17:
						if (!CS$<>8__locals1.radioRq.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.<>c__DisplayClass20_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.<>c__DisplayClass20_0.radioRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest.get_Comments())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
						{
							num = (short)995950600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C67;
					case 18:
						if (!string.IsNullOrEmpty(CS$<>8__locals1.radioRq.GroupName))
						{
							num = (short)650248195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D3;
					case 19:
						flag2 = false;
						goto IL_865;
					case 20:
						if (guid == null)
						{
							num = (short)75956266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_661;
					case 21:
						result = true;
						num = (short)491716681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						return result;
					case 23:
						flag3 = true;
						goto IL_9E9;
					case 24:
						goto IL_4D3;
					case 25:
						num = (short)611909680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						result = true;
						num = (short)889258006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)1498873907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (!string.Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetGroupFullPath(existedRadio.ToUiModel(true).CurentGroup.ID), CS$<>8__locals1.radioRq.GroupName))
						{
							num = (short)2085224458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D3;
					case 29:
						num = (short)1453260833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						guid = CS$<>8__locals1.radioRq.ConfigUuid;
						num = (short)1688403988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						guid = CS$<>8__locals1.radioRq.TemplateUuid;
						guid2 = existedRadio.WorkingCodeplug.TemplateUuid;
						num = (short)824180738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						result = true;
						num = (short)1234239556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						flag2 = true;
						goto IL_865;
					case 34:
						if (existedRadio.Group == null)
						{
							num = (short)1247215674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1240924219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						flag2 = (guid.GetValueOrDefault() != guid2.GetValueOrDefault());
						goto IL_865;
					case 36:
						num = (short)1398472711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)1271791635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_661;
					case 39:
						flag = (guid.GetValueOrDefault() != guid2.GetValueOrDefault());
						goto IL_DB2;
					case 40:
						result = true;
						num = (short)70910007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)481230901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						guid = CS$<>8__locals1.radioRq.TemplateUuid;
						num = (short)1920139308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						text2 = null;
						goto IL_6CD;
					case 44:
						if (guid == null)
						{
							num = (short)1394212889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_661;
					case 45:
						guid = existedRadio.Group.ParentUuid;
						num = (short)1550778435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						flag3 = false;
						goto IL_9E9;
					case 47:
						if (guid2 == null)
						{
							num = (short)23789637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)317063246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (string.IsNullOrEmpty(CS$<>8__locals1.radioRq.RadioAlias))
						{
							num = (short)953221125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_661;
					case 49:
						if (existedRadio.WorkingCodeplug == null)
						{
							num = (short)2061369374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)973275142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						text4 = string.Empty;
						goto IL_A6B;
					case 51:
						flag = true;
						goto IL_DB2;
					case 52:
						if (guid != null != (guid2 != null))
						{
							num = (short)1391329307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)856162369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						if (!CS$<>8__locals1.radioRq.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.<>c__DisplayClass20_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.<>c__DisplayClass20_0.radioRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest.get_RadioAlias())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
						{
							num = (short)453574688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B44;
					case 54:
						if (!string.Equals(existedRadio.Group.Name, CS$<>8__locals1.radioRq.GroupName))
						{
							num = (short)1515454535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D3;
					case 55:
						goto IL_A22;
					case 56:
						if (guid == null)
						{
							num = (short)1799159845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_838;
					case 57:
						return result;
					case 58:
						num = (short)1124204562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						if (!string.IsNullOrEmpty(CS$<>8__locals1.radioRq.GroupName))
						{
							num = (short)539885579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_467;
					case 60:
						if (CS$<>8__locals1.radioRq.GroupName.Contains('/'))
						{
							num = (short)2076901421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_467;
					case 61:
						guid = CS$<>8__locals1.radioRq.ProvisioningUuid;
						guid2 = existedRadio.WorkingCodeplug.ProvisioningUuid;
						num = (short)949157940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						guid2 = CS$<>8__locals1.radioRq.ConfigUuid;
						guid = existedRadio.WorkingCodeplug.ConfigurationUuid;
						num = (short)383123528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
					{
						string comments = existedRadio.Comments;
						if (comments == null)
						{
							num = (short)824180745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text3 = comments.Trim();
						goto IL_717;
					}
					case 64:
						return true;
					case 65:
						if (guid == null)
						{
							num = (short)1709244452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1735327783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						num = (short)1897136145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						if (guid == null)
						{
							num = (short)1749745676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)546635804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						goto IL_B44;
					case 69:
						num = (short)930676782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (guid != null)
						{
							num = (short)2140078141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 71:
						result = true;
						num = (short)464125968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (guid2 != null != (guid != null))
						{
							num = (short)1739784269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1334247471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						goto IL_89E;
					case 74:
						if (!string.IsNullOrEmpty(CS$<>8__locals1.radioRq.Comments))
						{
							num = (short)1261043750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 75:
						goto IL_4D3;
					case 76:
						if (guid != null)
						{
							num = (short)250478623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89E;
					case 77:
						num = (short)408420375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						flag3 = (guid2.GetValueOrDefault() != guid.GetValueOrDefault());
						goto IL_9E9;
					case 79:
						if ((text4 = CS$<>8__locals1.radioRq.RadioAlias) == null)
						{
							num = (short)54460466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A6B;
					}
					goto IL_16F;
					IL_467:
					num = (short)54001718;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D3:
					num = (short)978059313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_661:
					result = true;
					num = (short)1777205305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6CD:
					string text5 = text2;
					num = (short)1573126207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_717:
					string text6 = text3;
					guid = CS$<>8__locals1.radioRq.TemplateUuid;
					num = (short)1744765004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_838:
					num = (short)924909603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_865:
					if (flag2)
					{
						num = (short)1239285781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_89E:
					guid2 = CS$<>8__locals1.radioRq.ConfigUuid;
					num = (short)1468137487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9E9:
					if (flag3)
					{
						num = (short)2085617704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A22:
					num = (short)970063951;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A6B:
					if (text4 != (text5 ?? string.Empty))
					{
						num = (short)832962601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B44:
					num = (short)568655886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B8D:
					if (text != (text6 ?? string.Empty))
					{
						num = (short)239009858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C67:
					guid = CS$<>8__locals1.radioRq.ProvisioningUuid;
					num = (short)596377670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DB2:
					if (!flag)
					{
						return result;
					}
					num = (short)1549467674;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_16F:
				CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.<>c__DisplayClass20_0();
				CS$<>8__locals1.radioRq = radioRq;
				result = false;
				copiedRadio = CS$<>8__locals1.radioRq.CopiedRadio;
				num = (short)1727922176;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00017B40 File Offset: 0x00015D40
		protected virtual bool ValidateASTROIPGroup(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase rd, out string error)
		{
			short num = (short)633356529;
			short num2 = num;
			num = (short)1485717745;
			switch (num2 == num)
			{
			}
			num = (short)1483210753;
			if (num != 0)
			{
			}
			num = (short)1271988224;
			short num3 = num;
			num = (short)1837170688;
			if (num != 0)
			{
			}
			error = string.Empty;
			return true;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00017BF0 File Offset: 0x00015DF0
		private global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_286;
				case 1:
					if (validatedField == null)
					{
						num2 = (short)1236598792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					validateEntitySet.ValidateEntityList.Add(validatedField);
					num2 = (short)898957316;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(A_0.WorkingCodeplug);
					num2 = (short)720371717;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (A_0.WorkingCodeplug != null)
					{
						num2 = (short)1127481346;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_288;
				case 4:
					if (A_0.LastJob != null)
					{
						num2 = (short)1701445643;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D8;
				case 5:
					if (validatedField == null)
					{
						num2 = (short)1027997696;
						short num3 = num2;
						num2 = (short)1857880074;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					validateEntitySet.ValidateEntityList.Add(validatedField);
					num2 = (short)815529993;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (validatedField == null)
					{
						num2 = (short)2058092544;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					validateEntitySet.ValidateEntityList.Add(validatedField);
					num2 = (short)1676017671;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_1D8;
				case 8:
				{
					num2 = (short)217267105;
					short num4 = num2;
					num2 = (short)2071411617;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_244;
					default:
						goto IL_1BD;
					}
					break;
				}
				case 9:
					goto IL_23C;
				case 10:
					goto IL_10F;
				case 11:
					goto IL_244;
				}
				goto IL_40;
				IL_1D8:
				num2 = (short)1518010371;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_244:
				validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(A_0.LastJob);
				num2 = (short)1476329478;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_10F:
			throw new global::System.Exception();
			IL_1BD:
			num2 = (short)313458688;
			if (num2 != 0)
			{
			}
			throw new global::System.Exception();
			IL_23C:
			goto IL_288;
			IL_286:
			throw new global::System.Exception();
			IL_288:
			num2 = (short)342032385;
			if (num2 != 0)
			{
			}
			return validateEntitySet;
			IL_40:
			validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet
			{
				RelatedObject = new global::System.Guid?(A_0.Uuid),
				Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio,
				ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>()
			};
			validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(A_0);
			num2 = (short)1707606017;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00017EB0 File Offset: 0x000160B0
		private bool a(ref string A_0, out string A_1)
		{
			short num2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_5A;
					case 1:
						if (string.IsNullOrEmpty(A_0))
						{
							num2 = (short)2003632128;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1636237313;
						if (num2 != 0)
						{
						}
						num2 = (short)2125725698;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						num2 = (short)247286935;
						short num3 = num2;
						num2 = (short)1017924759;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1745879040;
							if (num2 != 0)
							{
							}
							if (A_0.Length > 10)
							{
								num2 = (short)1002242051;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return true;
						}
						break;
					}
					case 3:
						goto IL_115;
					}
					break;
				}
				IL_20:
				A_1 = string.Empty;
				num2 = (short)1270218753;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_5A:
			A_1 = global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_SerialNumberBlank;
			return false;
			IL_115:
			num2 = (short)382402560;
			short num4 = num2;
			A_1 = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_SerialNumber_Length_Error;
			return false;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001800C File Offset: 0x0001620C
		private string a(string A_0)
		{
			short num = (short)226401652;
			short num2 = num;
			num = (short)1306959220;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_87;
			case 1:
				break;
			default:
			{
				num = (short)1199505408;
				short num3 = num;
				break;
			}
			}
			num = (short)476839936;
			if (num != 0)
			{
			}
			string fieldUIString;
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo>.Enumerator enumerator = base.DataGridInfo.Columns.GetEnumerator())
			{
				num = (short)787283972;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1935409155;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo rmdataGridColumnInfo = enumerator.Current;
						num = (short)881000450;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo rmdataGridColumnInfo;
						fieldUIString = rmdataGridColumnInfo.FieldUIString;
						num = (short)258408453;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo rmdataGridColumnInfo;
						if (string.Equals(rmdataGridColumnInfo.FieldName, A_0, global::System.StringComparison.Ordinal))
						{
							num = (short)844693505;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						num = (short)687013894;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_CD;
						}
						continue;
					case 5:
						goto IL_169;
					case 6:
						goto IL_183;
					}
					IL_CF:
					num = (short)1607925760;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_CD:
					goto IL_CF;
				}
				IL_169:
				goto IL_196;
				IL_183:
				goto IL_87;
			}
			IL_196:
			num = (short)2088697857;
			if (num != 0)
			{
			}
			return fieldUIString;
			IL_87:
			return string.Empty;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000181E8 File Offset: 0x000163E8
		private global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.ResultForParsingRecord a(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile A_0, global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord A_1)
		{
			int a_ = 14;
			short num = (short)1425473536;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_123;
				}
				global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest importRadioFromCSVRequest2;
				string text3;
				string templateName;
				string configName;
				int num3;
				global::System.Guid? provisioningUuid;
				string provisioningName;
				string ipProgramSystemName;
				global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.ResultForParsingRecord resultForParsingRecord;
				for (;;)
				{
					IL_30:
					string text;
					string text2;
					switch (num2)
					{
					case 0:
						if (string.Equals(text, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("郒뫔맖뿘닚뫜꫞鏠苢釤軦蛨藪ꏬ軮鳰雲", a_)))
						{
							num = (short)784859164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)680198174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest importRadioFromCSVRequest = importRadioFromCSVRequest2;
						string serialNumber = importRadioFromCSVRequest2.SerialNumber;
						importRadioFromCSVRequest.SerialNumber = ((serialNumber != null) ? serialNumber.ToUpper(global::System.Globalization.CultureInfo.CurrentCulture) : null);
						num = (short)1146552354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1C6;
					case 3:
						if (string.Equals(text, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("郒뫔Ꟗꃘ鷚꿜냞賠뇢蓤菦胨蓪", a_)))
						{
							num = (short)637534218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1706426384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!string.IsNullOrEmpty(CS$<>8__locals1.value))
						{
							num = (short)708706342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32C;
					case 5:
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)945094663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)166330374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (string.Equals(text, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蟒냔뫖꧘럚볜ꯞ蓠귢蓤諦賨", a_)))
						{
							num = (short)1470365714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1437335552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)8585257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!string.Equals(text, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("菒꟔룖뷘껚뻜ꯞ꣠蟢胤触鷨苪诬蛮铰臲", a_)))
						{
							num = (short)1797586968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32C;
					case 9:
						num = (short)571539495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						text3 = CS$<>8__locals1.value;
						num = (short)1910767652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (text.Equals(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("菒듔듖님뫚뫜뫞ꗠ蛢雤蓦鯨苪鷬鯮飰鳲鯴", a_)))
						{
							num = (short)1710620714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2143551508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_32C;
					case 13:
						goto IL_32C;
					case 14:
						num = (short)2016870401;
						if (num != 0)
						{
						}
						if (this.GeneralPackages != null)
						{
							num = (short)1382678537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_452;
					case 15:
						CS$<>8__locals1.value = CS$<>8__locals1.value.Trim();
						num = (short)1737818149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (!string.Equals(text, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("黒뫔돖볘럚鏜꫞賠臢胤闦", a_)))
						{
							num = (short)2142765073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32C;
					case 17:
						num = (short)2055798792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						templateName = CS$<>8__locals1.value;
						num = (short)1677787159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (!string.Equals(text, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("菒듔ꓖ꫘곚닜귞藠", a_)))
						{
							num = (short)1285619727;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B71;
					case 20:
						if (text.Equals(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("菒듔듖님뫚뫜뫞", a_)))
						{
							num = (short)7733275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9F0;
					case 21:
						if (text.Equals(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("菒듔듖님뫚뫜뫞", a_)))
						{
							num = (short)1418592282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32C;
					case 22:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage generalPackage;
						if (generalPackage != null)
						{
							num = (short)702480427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E3;
					}
					case 23:
						goto IL_32C;
					case 24:
						num = (short)944767030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)859635769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_45D;
					case 27:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage generalPackage = this.GeneralPackages.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage p)
						{
							short num6 = (short)746758626;
							short num7 = num6;
							num6 = (short)703373794;
							switch (num7 == num6)
							{
							}
							num6 = (short)975437824;
							short num8 = num6;
							num6 = (short)1341390849;
							if (num6 != 0)
							{
							}
							num6 = (short)702545920;
							if (num6 != 0)
							{
							}
							return p.Name.Equals(CS$<>8__locals1.value);
						});
						num = (short)1066074143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						configName = CS$<>8__locals1.value;
						num = (short)639959090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						if (num3 >= A_1.FieldCount)
						{
							num = (short)798490680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = A_0.Headers[num3];
						string value = A_1.Fields[num3];
						num = (short)1140326404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						if (string.Equals(text, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("髒藔蟖ꯘ듚뫜귞胠転뛤黦髨鿪裬苮냰鿲鳴零諸", a_)))
						{
							num = (short)855769136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1218576433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_9F0;
					case 32:
						num = (short)1596719151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (importRadioFromCSVRequest2 is global::Motorola.CommonCPS.Server.EntityModel.ImportPBBRadioFromCSVRequest)
						{
							num = (short)1223491616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C6;
					case 34:
						goto IL_2E2;
					case 35:
						goto IL_31E;
					case 36:
						goto IL_32C;
					case 37:
						goto IL_B71;
					case 38:
						goto IL_71A;
					case 39:
						if (this.GeneralPackages.Count > 0)
						{
							num = (short)951844917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_452;
					case 40:
						num = (short)1764163605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (!this.ResetToDefault(importRadioFromCSVRequest2, text2, CS$<>8__locals1.value))
						{
							num = (short)719847449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32C;
					case 42:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage generalPackage = this.GeneralPackages.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage p)
						{
							short num6 = (short)672202753;
							if (num6 != 0)
							{
							}
							num6 = (short)28322972;
							short num7 = num6;
							num6 = (short)1051405468;
							switch (num7 == num6)
							{
							default:
							{
								num6 = (short)564002816;
								short num8 = num6;
								break;
							}
							case true:
								break;
							}
							num6 = (short)421330944;
							if (num6 != 0)
							{
							}
							return p.Description.Equals(CS$<>8__locals1.value);
						});
						num = (short)1675034682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
					{
						num = (short)1614282752;
						short num4 = num;
						global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage generalPackage;
						provisioningUuid = new global::System.Guid?(generalPackage.Uuid);
						provisioningName = generalPackage.Name;
						num = (short)873070604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						goto IL_264;
					case 45:
						goto IL_844;
					case 46:
						goto IL_264;
					case 47:
						if (!((importRadioFromCSVRequest2 as global::Motorola.CommonCPS.Server.EntityModel.ImportPBBRadioFromCSVRequest).ProductIdentifier == global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鿒郔迖律鷚", a_)))
						{
							num = (short)836501506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E2;
					case 48:
						ipProgramSystemName = CS$<>8__locals1.value;
						num = (short)849281037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						if (!string.Equals(text, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("菒雔藖鷘뻚ꯜ뛞苠蛢ꛤ苦鯨鿪蓬觮飰郲铴菶鳸닺鏼駾渀", a_)))
						{
							num = (short)1391263795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32C;
					case 50:
						goto IL_32C;
					case 51:
						num = (short)245301251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						CS$<>8__locals1.value = this.ConvertPasswordPolicy(CS$<>8__locals1.value).ToString(global::System.Globalization.CultureInfo.CurrentCulture);
						num = (short)146931757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage generalPackage = null;
						num = (short)973996043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
						if (!text.Equals(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("菒듔듖님뫚뫜뫞ꗠ蛢雤蓦鯨苪鷬鯮飰鳲鯴", a_)))
						{
							num = (short)1157627944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45D;
					case 55:
						if (string.Equals(text, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("菒듔ꓖ꫘곚닜귞藠돢諤详胨裪铬", a_)))
						{
							num = (short)625147956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176;
					case 56:
					{
						num = (short)300515614;
						short num5 = num;
						num = (short)638550302;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_844;
						default:
							num = (short)1221853184;
							if (num != 0)
							{
							}
							num = (short)176816161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 57:
						try
						{
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.SetGeneralPropertyValue(text2, CS$<>8__locals1.value, importRadioFromCSVRequest2);
							goto IL_32C;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.RMC_CSVField_DelChar)
							{
								resultForParsingRecord.DelCharFields.Add(text);
								goto IL_32C;
							}
							throw;
						}
						catch (global::System.Exception)
						{
							string text4 = this.a(text);
							throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_InvalidField_For_ImportCSV, new string[]
							{
								text4
							}));
						}
						goto IL_71A;
					case 58:
						goto IL_9F0;
					}
					goto IL_123;
					IL_176:
					num = (short)154271763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C6:
					num = (short)448200705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_264:
					num = (short)1391460381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E2:
					importRadioFromCSVRequest2.ProvisioningUuid = provisioningUuid;
					importRadioFromCSVRequest2.ProvisioningName = provisioningName;
					resultForParsingRecord.csvRequest = importRadioFromCSVRequest2;
					resultForParsingRecord.templateName = templateName;
					num = (short)859635747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32C:
					num3++;
					num = (short)1765474350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45D:
					num = (short)157876238;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_71A:
					num = (short)473497655;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F0:
					num = (short)807993366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B71:
					text2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVHeaderConverter.ConvertHeaderToField(text, this.Pac);
					num = (short)1062338565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_844:
					goto IL_176;
				}
				IL_31E:
				resultForParsingRecord.copyFromRadio = ((text3 != null) ? text3.ToUpper(global::System.Globalization.CultureInfo.CurrentCulture) : null);
				resultForParsingRecord.configName = configName;
				resultForParsingRecord.ipProgramSystemName = ipProgramSystemName;
				return resultForParsingRecord;
				IL_452:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_PACKAGE_NOT_FOUND);
				IL_5E3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_PACKAGE_NOT_FOUND);
				IL_123:
				resultForParsingRecord = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp.ResultForParsingRecord
				{
					DelCharFields = new global::System.Collections.Generic.List<string>()
				};
				templateName = null;
				configName = null;
				ipProgramSystemName = null;
				provisioningUuid = null;
				provisioningName = null;
				text3 = null;
				importRadioFromCSVRequest2 = this.CreateImportCSVRequest();
				num3 = 0;
				num = (short)1679687724;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0400003B RID: 59
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.Group a;

		// Token: 0x0400003C RID: 60
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage> b;

		// Token: 0x02000039 RID: 57
		private struct ResultForParsingRecord
		{
			// Token: 0x04000071 RID: 113
			public global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest csvRequest;

			// Token: 0x04000072 RID: 114
			public string templateName;

			// Token: 0x04000073 RID: 115
			public global::System.Collections.Generic.IList<string> DelCharFields;

			// Token: 0x04000074 RID: 116
			public string copyFromRadio;

			// Token: 0x04000075 RID: 117
			public string configName;

			// Token: 0x04000076 RID: 118
			public string ipProgramSystemName;
		}
	}
}
