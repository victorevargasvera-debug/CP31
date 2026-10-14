using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000050 RID: 80
	public class ImportASTROFrimwareBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string>
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x0002F058 File Offset: 0x0002D258
		public ImportASTROFrimwareBatchOp(global::System.Collections.Generic.List<string> fileList)
		{
			base.SelectedItems = fileList;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0002F074 File Offset: 0x0002D274
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)986770064;
				short num2 = num;
				num = (short)1949952656;
				switch (num2 == num)
				{
				}
				num = (short)240517121;
				if (num != 0)
				{
				}
				num = (short)1379074048;
				short num3 = num;
				num = (short)22282240;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportFirmwarePacks;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0002F120 File Offset: 0x0002D320
		public override string JobName
		{
			get
			{
				short num = (short)883446446;
				short num2 = num;
				num = (short)1001607854;
				switch (num2 == num)
				{
				}
				num = (short)1801715713;
				if (num != 0)
				{
				}
				num = (short)813170688;
				short num3 = num;
				num = (short)1162674176;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ImportFirmware;
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0002F1D0 File Offset: 0x0002D3D0
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 1;
			short num = (short)294637949;
			short num2 = num;
			num = (short)1055052157;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1437663233;
				if (num != 0)
				{
				}
				num = (short)1179910144;
				if (num != 0)
				{
				}
				num = (short)1247281152;
				short num3 = num;
				num = (short)975568896;
				switch (num)
				{
				}
				break;
			}
			}
			int num4 = 0;
			global::System.Collections.Generic.IEnumerator<string> enumerator = base.SelectedItems.GetEnumerator();
			try
			{
				num = (short)240254983;
				int num5 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IList<string> list;
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Package> list2;
					switch (num5)
					{
					case 0:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_23A;
							}
							string text;
							for (;;)
							{
								IL_1F3:
								global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
								global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware item2;
								switch (num5)
								{
								case 0:
								{
									list = new global::System.Collections.Generic.List<string>();
									global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerable;
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerator2 = enumerable.GetEnumerator();
									num = (short)77004806;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_BD9;
								case 2:
								{
									global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerable;
									if (enumerable != null)
									{
										num = (short)1389101059;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_CF1;
								}
								case 3:
									num = (short)1093926921;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerable = list2.Select(delegate(global::Motorola.CommonCPS.Server.EntityModel.Package x)
									{
										short num6 = (short)708563809;
										short num7 = num6;
										num6 = (short)641782625;
										switch (num7 == num6)
										{
										}
										num6 = (short)2124546048;
										short num8 = num6;
										num6 = (short)358154241;
										if (num6 != 0)
										{
										}
										num6 = (short)1219952640;
										if (num6 != 0)
										{
										}
										return (global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware)x;
									});
									num = (short)151912450;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									if (list2 != null)
									{
										num = (short)32112654;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_CF1;
								case 6:
								{
									try
									{
										num = (short)163840005;
										num5 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											bool? flag;
											bool flag2;
											global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware;
											switch (num5)
											{
											case 0:
												if (flag.GetValueOrDefault() == flag2 & flag != null)
												{
													num = (short)650706965;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_AB5;
											case 1:
												if (flag.GetValueOrDefault() == flag2 & flag != null)
												{
													num = (short)1482883081;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_A5B;
											case 2:
												num = (short)253493251;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												goto IL_B68;
											case 4:
												if (astrofirmware.RMFile.Url == null)
												{
													num = (short)995426319;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_AB5;
											case 5:
												switch (0)
												{
												case 0:
													goto IL_7FD;
												}
												continue;
											case 6:
												goto IL_AF3;
											case 7:
												if (astrofirmware != null)
												{
													num = (short)716046350;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_9E1;
											case 9:
												astrofirmware.PackageDescription = global::System.IO.Path.GetFileName(text);
												num = (short)2006581266;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											case 10:
												if (flag.GetValueOrDefault() == flag2 & flag != null)
												{
													num = (short)521535500;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_AF8;
											case 11:
												if (flag.GetValueOrDefault() == flag2 & flag != null)
												{
													num = (short)543227924;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 12:
												num = (short)1091371025;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											case 13:
												goto IL_AF8;
											case 14:
												flag = astrofirmware.IsSubFirmware;
												flag2 = true;
												num = (short)1755119626;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											case 15:
												goto IL_985;
											case 16:
											{
												global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)594608130;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												astrofirmware = enumerator2.Current;
												num = (short)925564935;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 17:
												if (astrofirmware.RMFile != null)
												{
													num = (short)1262157837;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_9E1;
											case 18:
												goto IL_A5B;
											case 19:
												if (!astrofirmware.IsCompatible)
												{
													num = (short)886833158;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												flag = astrofirmware.IsVirtualSummaryFirmware;
												flag2 = true;
												num = (short)165085185;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											case 20:
												list.Add(astrofirmware.RMFile.Url);
												num = (short)2005663752;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											case 21:
												num = (short)67960836;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_A0F:
											num = (short)767688720;
											num5 = (int)((global::System.IntPtr)num);
											continue;
											IL_7FD:
											goto IL_A0F;
											IL_A5B:
											flag = astrofirmware.IsSubFirmware;
											flag2 = true;
											num = (short)975831051;
											num5 = (int)((global::System.IntPtr)num);
											continue;
											IL_AB5:
											num = (short)1518403603;
											num5 = (int)((global::System.IntPtr)num);
											continue;
											IL_AF8:
											flag = astrofirmware.IsSubFirmware;
											flag2 = true;
											num = (short)1107558400;
											num5 = (int)((global::System.IntPtr)num);
										}
										IL_985:
										IL_9E1:
										throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_CpsDidntReturnInfo + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_File0, text));
										IL_AF3:
										throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.ASTRO_Invalid_Package_Version);
										IL_B68:
										goto IL_C90;
									}
									finally
									{
										num = (short)2020671488;
										num5 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerator2;
											switch (num5)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_B9F;
												}
												continue;
											case 1:
												enumerator2.Dispose();
												num = (short)683671554;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_BD6;
											}
											IL_B9F:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1527382017;
											num5 = (int)((global::System.IntPtr)num);
										}
										IL_BD6:;
									}
									goto IL_BD9;
									IL_C90:
									bool flag3 = false;
									global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerable;
									packageSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.CheckAndImportBatchAstroFirmware(base.JobContainerGuid, enumerable.ToList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware>(), text, out flag3);
									num = (short)594870282;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									try
									{
										num = (short)1569914887;
										num5 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num5)
											{
											case 1:
											{
												bool flag4;
												if (flag4)
												{
													num = (short)1674051588;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware item;
												base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>
												{
													item
												});
												num = (short)1970208783;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware2;
												if (!astrofirmware2.IsCompatible)
												{
													num = (short)1144782865;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												astrofirmware2.PackageDescription = global::System.IO.Path.GetFileName(text);
												astrofirmware2.RMFile = new global::Motorola.CommonCPS.Server.EntityModel.RMFile();
												astrofirmware2.RMFile.Url = global::System.IO.Path.GetFileName(text);
												bool flag4 = false;
												global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.CheckAndImportBacthPackage(base.JobContainerGuid, text, astrofirmware2, text, out flag4);
												num = (short)1246953477;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
											{
												global::Motorola.CommonCPS.Server.EntityModel.Package package;
												if (package != null)
												{
													num = (short)1408368651;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_43C;
											}
											case 4:
											{
												global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware item;
												base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>
												{
													item
												});
												num = (short)1846018048;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary2;
												if (packageSummary2 != null)
												{
													num = (short)2117533704;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
												num = (short)176750604;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												switch (0)
												{
												case 0:
													goto IL_3F6;
												}
												continue;
											case 8:
											{
												global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary2;
												global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware item = packageSummary2.ToUiModel() as global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware;
												num = (short)2118189057;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 9:
												goto IL_43A;
											case 10:
												num = (short)2109800464;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											case 11:
												num = (short)1624047630;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											case 12:
												goto IL_6D4;
											case 13:
											{
												global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.Package> enumerator3;
												if (!enumerator3.MoveNext())
												{
													num = (short)226033670;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.CommonCPS.Server.EntityModel.Package package = enumerator3.Current;
												num = (short)1457782787;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 14:
											{
												global::Motorola.CommonCPS.Server.EntityModel.Package package;
												if (package.RMFile != null)
												{
													num = (short)1992163338;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_43C;
											}
											case 16:
											{
												global::Motorola.CommonCPS.Server.EntityModel.Package package;
												if (package.RMFile.Url == null)
												{
													num = (short)1569587209;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware2 = package as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware;
												num = (short)2092105730;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 17:
												goto IL_5C3;
											}
											IL_603:
											num = (short)1993474061;
											num5 = (int)((global::System.IntPtr)num);
											continue;
											IL_3F6:
											goto IL_603;
										}
										IL_43A:
										IL_43C:
										throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_CpsDidntReturnInfo + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_File0, text));
										IL_5C3:
										throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.ASTRO_Invalid_Package_Version);
										IL_6D4:
										goto IL_CF1;
									}
									finally
									{
										num = (short)985268224;
										num5 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.Package> enumerator3;
											switch (num5)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_70C;
												}
												continue;
											case 1:
												enumerator3.Dispose();
												num = (short)934215682;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_745;
											}
											IL_70C:
											if (enumerator3 == null)
											{
												break;
											}
											num = (short)151584769;
											num5 = (int)((global::System.IntPtr)num);
										}
										IL_745:;
									}
									goto IL_748;
								case 8:
								{
									bool flag3;
									if (flag3)
									{
										num = (short)1227554827;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>
									{
										item2
									});
									num = (short)1967849484;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerable;
									if (enumerable.Any(delegate(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x)
									{
										switch (0)
										{
										case 0:
											goto IL_20;
										}
										int num6;
										bool? flag5;
										bool flag6;
										short num7;
										for (;;)
										{
											IL_0A:
											switch (num6)
											{
											case 0:
												while (flag5.GetValueOrDefault() == flag6 & flag5 != null)
												{
													num7 = (short)443769433;
													short num8 = num7;
													num7 = (short)765551193;
													switch ((num8 == num7) ? 1 : 0)
													{
													case 0:
													case 2:
														break;
													default:
														num7 = (short)2057961472;
														if (num7 != 0)
														{
														}
														num7 = (short)690421762;
														num6 = (int)((global::System.IntPtr)num7);
														goto IL_0A;
													}
												}
												goto IL_122;
											case 1:
												if (flag5.GetValueOrDefault() == flag6 & flag5 != null)
												{
													num7 = (short)2018508803;
													num6 = (int)((global::System.IntPtr)num7);
													continue;
												}
												goto IL_122;
											case 2:
												goto IL_11D;
											case 3:
												flag5 = x.IsFreonFirmwareUpgradeFile;
												flag6 = true;
												num7 = (short)391774208;
												num6 = (int)((global::System.IntPtr)num7);
												continue;
											}
											goto IL_20;
										}
										IL_11D:
										flag5 = x.IsVirtualSummaryFirmware;
										flag6 = true;
										return flag5.GetValueOrDefault() == flag6 & flag5 != null;
										IL_122:
										num7 = (short)845217792;
										short num9 = num7;
										num7 = (short)797310977;
										if (num7 != 0)
										{
										}
										return false;
										IL_20:
										flag5 = x.IsOMAPFirmwareUpgradeFile;
										flag6 = true;
										num7 = (short)736100353;
										num6 = (int)((global::System.IntPtr)num7);
										goto IL_0A;
									}))
									{
										num = (short)164954112;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.Package> enumerator3 = list2.GetEnumerator();
									num = (short)971309063;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									if (packageSummary != null)
									{
										num = (short)809238529;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_CF1;
								case 11:
									goto IL_748;
								case 12:
									goto IL_CF1;
								case 13:
									goto IL_D09;
								case 14:
									num = (short)952696836;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									goto IL_CF1;
								}
								goto IL_23A;
								IL_748:
								base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>
								{
									item2
								});
								num = (short)1343094799;
								num5 = (int)((global::System.IntPtr)num);
								continue;
								IL_BD9:
								item2 = (packageSummary.ToUiModel() as global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware);
								num = (short)174129160;
								num5 = (int)((global::System.IntPtr)num);
								continue;
								IL_CF1:
								num = (short)2138308621;
								num5 = (int)((global::System.IntPtr)num);
							}
							IL_D09:
							goto IL_13B;
							IL_23A:
							list2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AnalysisListPackageInfo(text);
							num = (short)1626472453;
							num5 = (int)((global::System.IntPtr)num);
							goto IL_1F3;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
							string text;
							batchOperationJob.JobDescription = text;
							batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
							batchOperationJob.ErrorMessage = ex.Message;
							if (ex.CommonExceptionData != null)
							{
								batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
							}
							batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
							batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
							global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddBatchOperationJob(batchOperationJob);
							goto IL_13B;
						}
						catch (global::System.Exception ex2)
						{
							global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(ex2.ToString());
							goto IL_13B;
						}
						finally
						{
							num = (short)1131872256;
							num5 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<string> enumerator4;
								switch (num5)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_DE6;
									}
									continue;
								case 1:
									goto IL_FB2;
								case 2:
									try
									{
										num = (short)588120067;
										num5 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num5)
											{
											case 0:
											{
												if (!enumerator4.MoveNext())
												{
													num = (short)106692609;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												string text2 = enumerator4.Current;
												num = (short)1586954244;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												num = (short)81920007;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_EEC;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_E4D;
												}
												continue;
											case 4:
											{
												string text2;
												if (!string.IsNullOrEmpty(text2))
												{
													num = (short)1908801538;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 5:
												try
												{
													string text2;
													global::System.IO.File.Delete(text2);
													break;
												}
												catch (global::System.Exception ex3)
												{
													global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(ex3.ToString());
													break;
												}
												goto IL_EEC;
											case 6:
											{
												string text2;
												if (global::System.IO.File.Exists(text2))
												{
													num = (short)150405125;
													num5 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 7:
												goto IL_F41;
											}
											IL_E8F:
											num = (short)1192034304;
											num5 = (int)((global::System.IntPtr)num);
											continue;
											IL_E4D:
											goto IL_E8F;
											IL_EEC:
											num = (short)167247878;
											num5 = (int)((global::System.IntPtr)num);
										}
										IL_F41:
										goto IL_FD9;
									}
									finally
									{
										num = (short)103940096;
										num5 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num5)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_F78;
												}
												continue;
											case 1:
												enumerator4.Dispose();
												num = (short)528875522;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_FAF;
											}
											IL_F78:
											if (enumerator4 == null)
											{
												break;
											}
											num = (short)1630470145;
											num5 = (int)((global::System.IntPtr)num);
										}
										IL_FAF:;
									}
									goto IL_FB2;
								}
								IL_DE6:
								if (list != null)
								{
									num = (short)1955201025;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
								IL_FB2:
								enumerator4 = list.GetEnumerator();
								num = (short)125501442;
								num5 = (int)((global::System.IntPtr)num);
							}
							IL_FD9:;
						}
						goto IL_FDA;
						IL_13B:
						num4++;
						base.ReportProgress(num4);
						num = (short)1260781569;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_136;
					case 3:
						if (base.CancellationPending)
						{
							num = (short)1578893318;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FDA;
					case 4:
						num = (short)1941241861;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1015;
					case 6:
						num = (short)644153346;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_11A;
						}
						continue;
					case 8:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)947191812;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = enumerator.Current;
						num = (short)1903427587;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_1A6:
					num = (short)329056264;
					num5 = (int)((global::System.IntPtr)num);
					continue;
					IL_11A:
					goto IL_1A6;
					IL_FDA:
					list2 = null;
					list = null;
					num = (short)1843396608;
					num5 = (int)((global::System.IntPtr)num);
				}
				IL_136:
				IL_1015:;
			}
			finally
			{
				num = (short)1963065344;
				int num5 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num5)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_104A;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)1356267522;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1081;
					}
					IL_104A:
					if (enumerator == null)
					{
						break;
					}
					num = (short)2122055681;
					num5 = (int)((global::System.IntPtr)num);
				}
				IL_1081:;
			}
		}
	}
}
