using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ASK.Interface;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200001B RID: 27
	public class ASTROFlashportBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x0000EDB0 File Offset: 0x0000CFB0
		public ASTROFlashportBatchOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedAllRadios, global::System.Collections.Generic.IList<global::System.Guid> cross712Radios, global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware selectedFirmware, global::ASK.Interface.ISystemKeyData systemID, string codeplugVersion = null)
		{
			base.SelectedItems = selectedAllRadios;
			this.Cross712Radios = cross712Radios;
			this.Firmware = selectedFirmware;
			this.SystemID = systemID;
			this.CodeplugVersion = codeplugVersion;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000EDE8 File Offset: 0x0000CFE8
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000EE98 File Offset: 0x0000D098
		private global::System.Collections.Generic.IList<global::System.Guid> Cross712Radios
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)255870609;
				short num2 = num;
				num = (short)1760708241;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1039138816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)802160641;
				if (num != 0)
				{
				}
				num = (short)1417084928;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)558375523;
				short num2 = num;
				num = (short)1335763555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1140457472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1241055233;
				if (num != 0)
				{
				}
				num = (short)682557440;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000EF48 File Offset: 0x0000D148
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000EFF8 File Offset: 0x0000D1F8
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware Firmware
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2030993820;
				short num2 = num;
				num = (short)1743028636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1142554624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1237712896;
				if (num != 0)
				{
				}
				num = (short)958332929;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)609776883;
				short num2 = num;
				num = (short)1701344499;
				switch (num2 == num)
				{
				default:
				{
					num = (short)897843200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)86376448;
				if (num != 0)
				{
				}
				num = (short)1978793985;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000F158 File Offset: 0x0000D358
		private global::ASK.Interface.ISystemKeyData SystemID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2123419535;
				short num2 = num;
				num = (short)1349439375;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1523056640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1581449217;
				if (num != 0)
				{
				}
				num = (short)1750335488;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)473075778;
				short num2 = num;
				num = (short)515412034;
				switch (num2 == num)
				{
				default:
				{
					num = (short)280821760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1223098368;
				if (num != 0)
				{
				}
				num = (short)477233153;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000F208 File Offset: 0x0000D408
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		private string CodeplugVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)581463989;
				short num2 = num;
				num = (short)162361269;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2011824128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1868890113;
				if (num != 0)
				{
				}
				num = (short)892272640;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1896220745;
				short num2 = num;
				num = (short)579799113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2028339200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1836646400;
				if (num != 0)
				{
				}
				num = (short)1972436993;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000F364 File Offset: 0x0000D564
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1028881790;
				short num2 = num;
				num = (short)992836990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)177602560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)777781249;
				if (num != 0)
				{
				}
				num = (short)1169227776;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Flashport;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000F414 File Offset: 0x0000D614
		public override string JobName
		{
			get
			{
				short num = (short)900239641;
				short num2 = num;
				num = (short)1548456217;
				switch (num2 == num)
				{
				default:
				{
					num = (short)602341376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)432799744;
				if (num != 0)
				{
				}
				num = (short)820903937;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.FLASHPortUpgrade;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 16;
			short num = (short)890306560;
			short num2 = num;
			num = (short)96940107;
			short num3 = num;
			num = (short)596652107;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1440808960;
				if (num != 0)
				{
				}
				num = (short)1037172736;
				num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			switch (0)
			{
			case 0:
				goto IL_C1;
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService iastroradioService;
			global::System.Collections.Generic.IList<global::System.Guid> list;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.FlashKeyInfo flashKeyInfo;
			byte[] oldFlashCode;
			global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware;
			for (;;)
			{
				IL_A6:
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
				switch (num4)
				{
				case 0:
					try
					{
						num = (short)710344704;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_16E;
								}
								continue;
							case 1:
								iastroradioService.CleanForUpgrade(list, this.Cross712Radios, syncData);
								num = (short)1735262213;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_5BF;
							case 3:
							{
								int num5;
								try
								{
									switch (0)
									{
									case 0:
										goto IL_2A4;
									}
									global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									for (;;)
									{
										IL_27D:
										global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
										switch (num4)
										{
										case 0:
											goto IL_33F;
										case 1:
										{
											if (radio == null)
											{
												num = (short)1669595141;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> list2 = radio.RadioFeatures;
											num = (short)465829891;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
											goto IL_548;
										case 3:
											if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(radio.Timestamp, radioBase.RadioTimestamp))
											{
												num = (short)1472593920;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											radioSummary = iastroradioService.UpgradeASTRORadioBatch(base.JobContainerGuid, radio, syncData, flashKeyInfo, this.Cross712Radios);
											num = (short)802816006;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											try
											{
												global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().DecreaseFlashKeyCount(base.SelectedItems[0].ModelNumber, oldFlashCode, 1);
												goto IL_4C8;
											}
											catch (global::System.Exception ex)
											{
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> list2;
												list2.ForEach(delegate(global::Motorola.CommonCPS.Server.EntityModel.RadioFeature item)
												{
													short num6 = (short)449839104;
													short num7 = num6;
													num6 = (short)1216180741;
													short num8 = num6;
													num6 = (short)344945157;
													switch (num8 == num6)
													{
													}
													num6 = (short)1806368768;
													if (num6 != 0)
													{
													}
													num6 = (short)467271681;
													if (num6 != 0)
													{
													}
													item.Radio = null;
												});
												global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item3 = iastroradioService.TryDiscardCodeplugAndRadioFeature(radioSummary.Uuid, radioSummary.SerialNumber, list2).ToUiModel(true);
												base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
												{
													item3
												});
												iastroradioService.CleanForUpgrade(list, this.Cross712Radios, syncData);
												if (ex is global::Motorola.Common.CustomException.CommonException)
												{
													throw;
												}
												throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_FlashKeyDecraseFailed);
											}
											goto IL_4A0;
										case 5:
											goto IL_2EC;
										case 6:
											if (radioSummary != null)
											{
												num = (short)1901002756;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蛔닖ꯘ귚룜귞쇠釢胤鏦鳨駪菬쿮鿰蛲駴鯶쏸\udbfa꣼迾昀焂搄挆氈䨊希嬎䌐尒䜔瘖紘爚爜崞䀠圢䘤伦", a_));
											num = (short)1631649799;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 7:
											goto IL_4C8;
										}
										goto IL_2A4;
										IL_4C8:
										list.Add(radioSummary.Uuid);
										iastroradioService.AddBatchOperationJob(new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
										{
											JobDescription = radioBase.SerialNumber,
											JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED,
											JobContainerUuid = new global::System.Guid?(base.JobContainerGuid)
										});
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item2 = radioSummary.ToUiModel(true);
										base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
										{
											item2
										});
										num = (short)641990658;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_2EC:
									goto IL_4A0;
									IL_33F:
									global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蟔髖高蓚釜냞苠苢觤룦귨諪駬軮껰볲胴菶雸鷺ꋼ믾怀眂怄", a_));
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
									IL_4A0:
									global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蟔髖高蓚駜뫞韠諢蛤苦꟨蓪駬ꫮ觰髲蛴菶", a_));
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
									IL_548:
									goto IL_1DE;
									IL_2A4:
									radio = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioByDeviceUuid(radioBase.DeviceUuid, true);
									num = (short)1931608065;
									num4 = (int)((global::System.IntPtr)num);
									goto IL_27D;
								}
								catch (global::Motorola.Common.CustomException.CommonException ex2)
								{
									string[] paramters = null;
									if (ex2.CommonExceptionData != null)
									{
										paramters = ex2.CommonExceptionData.Paramters;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpUtility.CreateFailureJob(base.JobContainerGuid, radioBase.SerialNumber, ex2.ErrorCode, paramters);
									iastroradioService.AddBatchOperationJob(job);
									num5++;
									base.ReportProgress(num5);
									break;
								}
								goto IL_5A6;
								IL_1DE:
								num5++;
								base.ReportProgress(num5);
								num = (short)1123024904;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_5A6;
							case 5:
								goto IL_198;
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1962999812;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
								num = (short)1477967879;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								if (base.CancellationPending)
								{
									num = (short)1676083201;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								int num5 = 0;
								global::Motorola.CommonCPS.Server.EntityModel.Radio radio = null;
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> list2 = null;
								num = (short)1910308867;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_19D:
							num = (short)1302069254;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_16E:
							goto IL_19D;
							IL_5A6:
							num = (short)97648642;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_198:
						return;
						IL_5BF:
						goto IL_65D;
					}
					finally
					{
						num = (short)1653997568;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_5F6;
								}
								continue;
							case 1:
								goto IL_62F;
							case 2:
								enumerator.Dispose();
								num = (short)1227620353;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_5F6:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1668087810;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_62F:;
					}
					goto IL_632;
					IL_65D:
					iastroradioService.CleanForUpgrade(list, this.Cross712Radios, syncData);
					num = (short)816447492;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1309;
				case 2:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_6EF;
						}
						for (;;)
						{
							IL_694:
							global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid;
							switch (num4)
							{
							case 0:
								iastroradioService.CleanForUpgrade(list, this.Cross712Radios, syncData);
								num = (short)288620554;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (flashKeyInfo == null)
								{
									num = (short)1656815618;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1425801232;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_765;
							case 3:
							{
								if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(astrofirmware.Timestamp, this.Firmware.Timestamp))
								{
									num = (short)1332871175;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								bool? isVirtualSummaryFirmware = astrofirmware.IsVirtualSummaryFirmware;
								bool flag = true;
								num = (short)1689190415;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								try
								{
									num = (short)172687360;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_BA0;
											}
											continue;
										case 1:
										{
											global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase2;
											if (radioBase2 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)
											{
												num = (short)288030722;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 2:
										{
											global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase2;
											global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = radioBase2 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
											bool flag2 = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).IsFreon(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX, astroradio.ModelNumber);
											num = (short)1712848906;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
										{
											global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
											if (astroradio.ModelNumber.Substring(0, 1)[0] == 'H')
											{
												num = (short)955645964;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_D0A;
										}
										case 5:
										{
											global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
											if (astroradio.ModelNumber.Substring(0, 1)[0] != 'H')
											{
												num = (short)399704082;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_E05;
										}
										case 6:
										{
											global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> subFirmwares;
											global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware2 = subFirmwares.SingleOrDefault(delegate(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x)
											{
												int a_2 = 15;
												int num6;
												bool? flag3;
												bool flag4;
												short num7;
												switch (0)
												{
												case 0:
													break;
												default:
												{
													for (;;)
													{
														IL_13:
														switch (num6)
														{
														case 0:
															if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
															{
																num7 = (short)2125529089;
																num6 = (int)((global::System.IntPtr)num7);
																continue;
															}
															goto IL_1B5;
														case 1:
															flag3 = x.IsOMAPFirmwareUpgradeFile;
															flag4 = true;
															num7 = (short)909312005;
															num6 = (int)((global::System.IntPtr)num7);
															continue;
														case 2:
															if (!(flag3.GetValueOrDefault() == flag4 & flag3 != null))
															{
																num7 = (short)2039545859;
																num6 = (int)((global::System.IntPtr)num7);
																continue;
															}
															goto IL_1B5;
														case 3:
															goto IL_15E;
														case 4:
														{
															num7 = (short)1440390938;
															short num8 = num7;
															num7 = (short)568041242;
															switch ((num8 == num7) ? 1 : 0)
															{
															case 0:
															case 2:
																goto IL_3A;
															default:
																num7 = (short)432340993;
																if (num7 != 0)
																{
																}
																num7 = (short)798621696;
																if (num7 != 0)
																{
																}
																flag3 = x.IsFreonFirmwareUpgradeFile;
																flag4 = true;
																num7 = (short)847708162;
																num6 = (int)((global::System.IntPtr)num7);
																continue;
															}
															break;
														}
														case 5:
															if (!(flag3.GetValueOrDefault() == flag4 & flag3 != null))
															{
																num7 = (short)1987379204;
																num6 = (int)((global::System.IntPtr)num7);
																continue;
															}
															goto IL_1B5;
														}
														goto IL_31;
													}
													IL_15E:
													return x.TargetModel.Substring(0, 1) == global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鳓", a_2);
													IL_1B5:
													num7 = (short)1281622016;
													short num9 = num7;
													return false;
												}
												}
												IL_31:
												flag3 = x.IsSubFirmware;
												flag4 = true;
												IL_3A:
												num7 = (short)768278528;
												num6 = (int)((global::System.IntPtr)num7);
												goto IL_13;
											});
											if (astrofirmware2 == null)
											{
												goto Block_40;
											}
											astrofirmware = astrofirmware2;
											num = (short)792199172;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 7:
										{
											bool flag2;
											if (flag2)
											{
												num = (short)668532760;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_E05;
										}
										case 8:
											num = (short)1369309198;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 9:
										{
											global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
											if (astroradio.ModelNumber.Substring(0, 1)[0] != 'H')
											{
												num = (short)1022689288;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 10:
										{
											bool flag2;
											if (flag2)
											{
												num = (short)247332875;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_D0A;
										}
										case 11:
											num = (short)2085289987;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 12:
											num = (short)840106000;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 14:
										{
											global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> subFirmwares;
											global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware3 = subFirmwares.SingleOrDefault(delegate(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x)
											{
												int a_2 = 7;
												int num6;
												bool? flag3;
												bool flag4;
												short num7;
												switch (0)
												{
												case 0:
													break;
												default:
												{
													for (;;)
													{
														IL_13:
														switch (num6)
														{
														case 0:
															if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
															{
																num7 = (short)1836646401;
																num6 = (int)((global::System.IntPtr)num7);
																continue;
															}
															goto IL_1B7;
														case 1:
															flag3 = x.IsOMAPFirmwareUpgradeFile;
															flag4 = true;
															num7 = (short)786563077;
															num6 = (int)((global::System.IntPtr)num7);
															continue;
														case 2:
															if (!(flag3.GetValueOrDefault() == flag4 & flag3 != null))
															{
																num7 = (short)1721827331;
																num6 = (int)((global::System.IntPtr)num7);
																continue;
															}
															goto IL_1B7;
														case 3:
															goto IL_160;
														case 4:
														{
															num7 = (short)1331957285;
															short num8 = num7;
															num7 = (short)1572605477;
															switch ((num8 == num7) ? 1 : 0)
															{
															case 0:
															case 2:
																goto IL_3A;
															default:
																num7 = (short)1058078721;
																if (num7 != 0)
																{
																}
																num7 = (short)1743781888;
																if (num7 != 0)
																{
																}
																flag3 = x.IsFreonFirmwareUpgradeFile;
																flag4 = true;
																num7 = (short)502988802;
																num6 = (int)((global::System.IntPtr)num7);
																continue;
															}
															break;
														}
														case 5:
															if (!(flag3.GetValueOrDefault() == flag4 & flag3 != null))
															{
																num7 = (short)139001860;
																num6 = (int)((global::System.IntPtr)num7);
																continue;
															}
															goto IL_1B7;
														}
														goto IL_31;
													}
													IL_160:
													return x.TargetModel.Substring(0, 1) != global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蓋", a_2);
													IL_1B7:
													num7 = (short)1529741312;
													short num9 = num7;
													return false;
												}
												}
												IL_31:
												flag3 = x.IsSubFirmware;
												flag4 = true;
												IL_3A:
												num7 = (short)83951616;
												num6 = (int)((global::System.IntPtr)num7);
												goto IL_13;
											});
											if (astrofirmware3 == null)
											{
												goto Block_44;
											}
											astrofirmware = astrofirmware3;
											num = (short)88801309;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 15:
										{
											global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
											if (astroradio.ModelNumber.Substring(0, 1)[0] == 'H')
											{
												num = (short)776077338;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_EFE;
										}
										case 16:
										{
											global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> subFirmwares;
											global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware4 = subFirmwares.SingleOrDefault(delegate(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x)
											{
												int a_2 = 18;
												switch (0)
												{
												case 0:
													goto IL_29;
												}
												int num6;
												bool? flag3;
												bool flag4;
												short num7;
												for (;;)
												{
													IL_13:
													switch (num6)
													{
													case 0:
														if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
														{
															num7 = (short)1243217921;
															num6 = (int)((global::System.IntPtr)num7);
															continue;
														}
														goto IL_108;
													case 1:
														flag3 = x.IsFreonFirmwareUpgradeFile;
														flag4 = true;
														num7 = (short)2082471939;
														num6 = (int)((global::System.IntPtr)num7);
														continue;
													case 2:
														goto IL_106;
													case 3:
														if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
														{
															num7 = (short)50921474;
															num6 = (int)((global::System.IntPtr)num7);
															continue;
														}
														goto IL_108;
													}
													goto IL_29;
												}
												IL_A0:
												return x.TargetModel == global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("돖냘꣚뻜胞釠賢韤", a_2);
												IL_106:
												goto IL_A0;
												IL_108:
												num7 = (short)1073907017;
												short num8 = num7;
												num7 = (short)672695625;
												switch ((num8 == num7) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_A0;
												default:
													num7 = (short)2064121857;
													if (num7 != 0)
													{
													}
													num7 = (short)205848576;
													if (num7 != 0)
													{
													}
													return false;
												}
												IL_29:
												flag3 = x.IsSubFirmware;
												flag4 = true;
												num7 = (short)1094385664;
												short num9 = num7;
												num7 = (short)2136014848;
												num6 = (int)((global::System.IntPtr)num7);
												goto IL_13;
											});
											if (astrofirmware4 == null)
											{
												goto Block_32;
											}
											astrofirmware = astrofirmware4;
											num = (short)707854356;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 17:
										{
											bool flag2;
											if (!flag2)
											{
												num = (short)340394009;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 18:
											num = (short)1756561436;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 19:
											num = (short)1082654735;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 21:
											goto IL_104E;
										case 22:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)1330577435;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase2 = enumerator.Current;
											num = (short)930807809;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 23:
										{
											bool flag2;
											if (!flag2)
											{
												num = (short)741867539;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_EFE;
										}
										case 24:
											num = (short)1183383557;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 25:
											num = (short)457179145;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 26:
											num = (short)483328006;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 27:
											num = (short)29818901;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 28:
										{
											global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> subFirmwares;
											global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware5 = subFirmwares.SingleOrDefault(delegate(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x)
											{
												int a_2 = 17;
												switch (0)
												{
												case 0:
													goto IL_29;
												}
												int num6;
												bool? flag3;
												bool flag4;
												short num7;
												for (;;)
												{
													IL_13:
													switch (num6)
													{
													case 0:
														if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
														{
															num7 = (short)1116536833;
															num6 = (int)((global::System.IntPtr)num7);
															continue;
														}
														goto IL_107;
													case 1:
														flag3 = x.IsFreonFirmwareUpgradeFile;
														flag4 = true;
														num7 = (short)987234307;
														num6 = (int)((global::System.IntPtr)num7);
														continue;
													case 2:
														goto IL_105;
													case 3:
														if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
														{
															num7 = (short)909705218;
															num6 = (int)((global::System.IntPtr)num7);
															continue;
														}
														goto IL_107;
													}
													goto IL_29;
												}
												IL_9E:
												return x.TargetModel == global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("닕뇗꧙뿛臝跟跡蛣", a_2);
												IL_105:
												goto IL_9E;
												IL_107:
												num7 = (short)1757282305;
												if (num7 != 0)
												{
												}
												num7 = (short)1748376197;
												short num8 = num7;
												num7 = (short)1075714693;
												switch ((num8 == num7) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_9E;
												default:
													num7 = (short)1927479296;
													if (num7 != 0)
													{
													}
													return false;
												}
												IL_29:
												flag3 = x.IsSubFirmware;
												flag4 = true;
												num7 = (short)2020409344;
												short num9 = num7;
												num7 = (short)548864000;
												num6 = (int)((global::System.IntPtr)num7);
												goto IL_13;
											});
											if (astrofirmware5 == null)
											{
												goto Block_36;
											}
											astrofirmware = astrofirmware5;
											num = (short)926810125;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										goto IL_BA0;
										IL_D0A:
										num = (short)1193869319;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_E05:
										num = (short)1251344407;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_EFE:
										num = (short)108920849;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_FF5:
										num = (short)323158038;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_BA0:
										goto IL_FF5;
									}
									Block_32:
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Firmware_NotExist);
									Block_36:
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Firmware_NotExist);
									Block_40:
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Firmware_NotExist);
									Block_44:
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Firmware_NotExist);
									IL_104E:
									goto IL_8CF;
								}
								finally
								{
									num = (short)1280704513;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											enumerator.Dispose();
											num = (short)158007298;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_1087;
											}
											continue;
										case 2:
											goto IL_10BE;
										}
										IL_1087:
										if (enumerator == null)
										{
											break;
										}
										num = (short)1577451520;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_10BE:;
								}
								goto IL_10C1;
							case 5:
								goto IL_925;
							case 6:
								num = (short)1573257227;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_7DD;
							case 8:
							{
								global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> subFirmwares;
								if (subFirmwares != null)
								{
									num = (short)165085190;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_10C1;
							}
							case 9:
								enumerator = base.SelectedItems.GetEnumerator();
								num = (short)1961623556;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								goto IL_9D0;
							case 11:
							{
								global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> subFirmwares;
								if (subFirmwares.Count<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware>() > 0)
								{
									num = (short)2129920009;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_10C1;
							}
							case 12:
								if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(radioByDeviceUuid.Timestamp, base.SelectedItems[0].RadioTimestamp))
								{
									num = (short)1593114641;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								iastroradioService.GetSyncDataForUpgrade(radioByDeviceUuid, astrofirmware, flashKeyInfo.NewFlashCode, flashKeyInfo.iButtonSerialNumber, this.Cross712Radios, base.SelectedItems.Count<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(), false, this.SystemID, out syncData, this.CodeplugVersion);
								num = (short)1373569038;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
							{
								global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> subFirmwares = astrofirmware.SubFirmwares;
								num = (short)224788488;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 14:
								goto IL_111A;
							case 15:
							{
								bool? isVirtualSummaryFirmware;
								bool flag;
								if (isVirtualSummaryFirmware.GetValueOrDefault() == flag & isVirtualSummaryFirmware != null)
								{
									num = (short)753336333;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_8CF;
							}
							case 16:
								if (base.CancellationPending)
								{
									num = (short)312672256;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								astrofirmware = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetPackage(this.Firmware.Uuid) as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware);
								num = (short)291569684;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 17:
								goto IL_9A5;
							case 18:
								goto IL_AD3;
							case 19:
								if (radioByDeviceUuid == null)
								{
									num = (short)1394802693;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1192493068;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 20:
								if (astrofirmware == null)
								{
									num = (short)1703346194;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)507445251;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6EF;
							IL_8CF:
							radioByDeviceUuid = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioByDeviceUuid(base.SelectedItems[0].DeviceUuid, true);
							num = (short)1157103635;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_765:
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蟔髖高蓚鯜돞胠郢跤곦賨鋪달ꇮ黰蟲돴飶賸闺駼", a_));
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_FlashKey_NotFound);
						IL_7DD:
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蟔髖高蓚釜냞苠苢觤룦귨諪駬軮껰볲胴菶雸鷺ꋼ믾怀眂怄", a_));
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
						IL_925:
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蟔髖高蓚远뻞藠諢諤ꧦ蛨鿪꣬韮飰胲致", a_));
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_RadioNotExist);
						IL_9A5:
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蟔髖高蓚釜냞苠苢觤룦귨諪駬軮껰볲胴菶雸鷺ꋼ믾怀眂怄", a_));
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
						IL_9D0:
						return;
						IL_AD3:
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蟔髖高蓚鯜뛞鏠転鋤蛦鯨軪달ꇮ黰蟲냴迶郸裺觼", a_));
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Firmware_NotExist);
						IL_10C1:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Firmware_NotExist);
						IL_111A:
						goto IL_12CC;
						IL_6EF:
						oldFlashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroEncodeFlashCode((base.SelectedItems[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).AstroPurchasedFlashCode);
						flashKeyInfo = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().ReadFlashKey(base.SelectedItems[0].ModelNumber, oldFlashCode);
						num = (short)370147329;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_694;
					}
					catch (global::Motorola.Common.CustomException.CommonException ex3)
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroReleaseFlashKey();
						string[] paramters2 = null;
						if (ex3.CommonExceptionData != null)
						{
							paramters2 = ex3.CommonExceptionData.Paramters;
						}
						for (;;)
						{
							enumerator = base.SelectedItems.GetEnumerator();
							try
							{
								num = (short)538181632;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_1179;
										}
										continue;
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1219821570;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase3 = enumerator.Current;
										global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job2 = global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpUtility.CreateFailureJob(base.JobContainerGuid, radioBase3.SerialNumber, ex3.ErrorCode, paramters2);
										iastroradioService.AddBatchOperationJob(job2);
										num = (short)14221315;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										num = (short)409468932;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_1214;
									}
									IL_11C2:
									num = (short)24182785;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_1179:
									goto IL_11C2;
								}
								IL_1214:
								break;
							}
							finally
							{
								num = (short)1106182145;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1163001858;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_124B;
										}
										continue;
									case 2:
										goto IL_1283;
									}
									IL_124B:
									if (enumerator == null)
									{
										break;
									}
									num = (short)77004800;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_1283:;
							}
						}
						iastroradioService.CleanForUpgrade(null, this.Cross712Radios, syncData);
						return;
					}
					goto IL_12BC;
					IL_12CC:
					num = (short)2093285379;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (base.CancellationPending)
					{
						num = (short)1683619841;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_632;
				case 4:
					goto IL_685;
				}
				goto IL_C1;
				IL_632:
				enumerator = base.SelectedItems.GetEnumerator();
				num = (short)818544640;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_685:
			return;
			IL_12BC:
			iastroradioService.CleanForUpgrade(null, this.Cross712Radios, syncData);
			return;
			IL_1309:
			goto IL_12BC;
			IL_C1:
			iastroradioService = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService);
			flashKeyInfo = null;
			astrofirmware = null;
			oldFlashCode = null;
			syncData = null;
			list = new global::System.Collections.Generic.List<global::System.Guid>();
			num = (short)862781441;
			if (num != 0)
			{
			}
			num = (short)328531970;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A6;
		}

		// Token: 0x0400002F RID: 47
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.IList<global::System.Guid> a;

		// Token: 0x04000030 RID: 48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware b;

		// Token: 0x04000031 RID: 49
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::ASK.Interface.ISystemKeyData c;

		// Token: 0x04000032 RID: 50
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;
	}
}
