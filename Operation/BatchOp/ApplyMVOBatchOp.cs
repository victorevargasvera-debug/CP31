using System;
using System.Collections.Generic;
using System.ComponentModel;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200001A RID: 26
	public class ApplyMVOBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0000E468 File Offset: 0x0000C668
		public ApplyMVOBatchOp(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug> radioCpPairFromBll, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> applyingRadios)
		{
			base.SelectedItems = applyingRadios;
			this.a = radioCpPairFromBll;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000E48C File Offset: 0x0000C68C
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)397976441;
				short num2 = num;
				num = (short)398107513;
				switch (num2 == num)
				{
				}
				num = (short)689963008;
				short num3 = num;
				num = (short)1944190977;
				if (num != 0)
				{
				}
				num = (short)2144141312;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ApplyMVO;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000E538 File Offset: 0x0000C738
		public override string JobName
		{
			get
			{
				short num = (short)834309423;
				short num2 = num;
				num = (short)1149340975;
				switch (num2 == num)
				{
				}
				num = (short)1257177088;
				short num3 = num;
				num = (short)984023041;
				if (num != 0)
				{
				}
				num = (short)794034176;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.ApplyMVO;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 17;
			short num = (short)623706112;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)279052289;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				int num4;
				for (;;)
				{
					IL_57:
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = (global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)this.a.Value;
						apxcodeplug.SubscriberIP = global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("훟\udae1쫣ퟥ\udae7틩싫\udfed", a_);
						apxcodeplug.PeerIP = global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("훟\udae1쫣ퟥ\udae7틩싫\udced", a_);
						apxcodeplug.BluetoothDUNSubscriberIP = global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("훟\udae1쫣ퟥ\udbe7\udae9싫\udfed", a_);
						apxcodeplug.BluetoothDUNPeerIP = global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("훟\udae1쫣ퟥ\udbe7\udae9싫\udced", a_);
						num = (short)234225666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)1448935432;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
								global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer4;
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
								switch (num2)
								{
								case 0:
									if (base.CancellationPending)
									{
										num = (short)1890451463;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1073938437;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)2087780358;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5B5;
								case 2:
									automaticPerformanceMeasurer = null;
									goto IL_1CF;
								case 3:
									goto IL_615;
								case 4:
									try
									{
										num = (short)1506934795;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
											global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer3;
											global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer5;
											switch (num2)
											{
											case 0:
											{
												num = (short)997788478;
												short num3 = num;
												num = (short)903809854;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_468;
												default:
													num = (short)2122973184;
													if (num != 0)
													{
													}
													try
													{
														global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item;
														base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
														{
															item
														});
														goto IL_521;
													}
													finally
													{
														num = (short)340787202;
														num2 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
																automaticPerformanceMeasurer2.Dispose();
																num = (short)1522466817;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 1:
																goto IL_330;
															case 2:
																switch (0)
																{
																case 0:
																	goto IL_2F6;
																}
																continue;
															}
															IL_2F6:
															if (automaticPerformanceMeasurer2 == null)
															{
																break;
															}
															num = (short)247463936;
															num2 = (int)((global::System.IntPtr)num);
														}
														IL_330:;
													}
													goto Block_10;
												}
												break;
											}
											case 1:
												goto IL_333;
											case 2:
												automaticPerformanceMeasurer3 = automaticPerformanceMeasurer4.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("飕럗껙뗛룝駟싡꟣蟥诧苩觫", a_));
												goto IL_3DF;
											case 3:
											{
												global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
												if (radioSummary != null)
												{
													goto IL_468;
												}
												goto IL_521;
											}
											case 4:
												automaticPerformanceMeasurer3 = null;
												goto IL_3DF;
											case 5:
											{
												global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
												global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = radioSummary.ToUiModel(true);
												num = (short)1684602892;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												goto IL_546;
											case 7:
												automaticPerformanceMeasurer5 = null;
												goto IL_4D1;
											case 8:
												goto IL_3C4;
											case 9:
												automaticPerformanceMeasurer5 = automaticPerformanceMeasurer4.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("韕꣗꫙냛꟝샟꿡닣ꧥ죧맩觫鳭蛯鯱音鏵", a_));
												goto IL_4D1;
											case 10:
												num = (short)2036203527;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 11:
												switch (0)
												{
												case 0:
													goto IL_244;
												}
												continue;
											case 12:
												if (automaticPerformanceMeasurer4 == null)
												{
													num = (short)1216413704;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)37617666;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_244:
											if (automaticPerformanceMeasurer4 == null)
											{
												num = (short)123797514;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1433600009;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_3C4:
											num = (short)743440388;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											Block_10:
											try
											{
												IL_333:
												global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.ApplyMVO(base.JobContainerGuid, radioBase, this.a);
												goto IL_449;
											}
											finally
											{
												num = (short)89456642;
												num2 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														automaticPerformanceMeasurer2.Dispose();
														num = (short)1916534785;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 1:
														goto IL_3C1;
													case 2:
														switch (0)
														{
														case 0:
															goto IL_389;
														}
														continue;
													}
													IL_389:
													if (automaticPerformanceMeasurer2 == null)
													{
														break;
													}
													num = (short)979566592;
													num2 = (int)((global::System.IntPtr)num);
												}
												IL_3C1:;
											}
											goto IL_3C4;
											IL_449:
											num = (short)1902772227;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_3DF:
											automaticPerformanceMeasurer2 = automaticPerformanceMeasurer3;
											num = (short)1405616128;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_468:
											num = (short)424411141;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4D1:
											automaticPerformanceMeasurer2 = automaticPerformanceMeasurer5;
											num = (short)1258356737;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_521:
											num4++;
											base.ReportProgress(num4);
											num = (short)902299654;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_546:
										break;
									}
									finally
									{
										num = (short)2080964610;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												automaticPerformanceMeasurer4.Dispose();
												num = (short)1002897409;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_5B2;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_57D;
												}
												continue;
											}
											IL_57D:
											if (automaticPerformanceMeasurer4 == null)
											{
												break;
											}
											num = (short)686686208;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_5B2:;
									}
									goto IL_5B5;
								case 5:
								{
									global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer = this.Measurer;
									if (measurer == null)
									{
										num = (short)282591234;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									automaticPerformanceMeasurer = measurer.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("韕꣗꫙냛꟝샟꿡닣ꧥ", a_), null).AddOrUpdateParameter(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("藕뷗꣙뗛뿝賟싡ꫣ鏥藧裩觫鳭", a_), radioBase.SerialNumber));
									goto IL_1CF;
								}
								case 6:
									num = (short)1576927235;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)1273757705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_FB;
									}
									continue;
								case 9:
									goto IL_117;
								}
								IL_15B:
								num = (short)614924289;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FB:
								goto IL_15B;
								IL_1CF:
								automaticPerformanceMeasurer4 = automaticPerformanceMeasurer;
								num = (short)158531588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5B5:
								radioBase = enumerator.Current;
								num = (short)340525056;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_117:
							IL_615:
							return;
						}
						finally
						{
							num = (short)789577730;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1588658177;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_683;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_64C;
									}
									continue;
								}
								IL_64C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1386020864;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_683:;
						}
						goto IL_686;
					case 2:
					{
						num = (short)131203072;
						short num5 = num;
						goto IL_686;
					}
					case 3:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
						{
							num = (short)1343225856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_686;
					}
					goto IL_6E;
					IL_686:
					enumerator = base.SelectedItems.GetEnumerator();
					num = (short)2113404929;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6E:
				num4 = 0;
				num = (short)123207683;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_57;
			}
			}
		}

		// Token: 0x0400002E RID: 46
		private global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug> a;
	}
}
