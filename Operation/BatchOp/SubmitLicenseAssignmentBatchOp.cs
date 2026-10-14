using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ASK.Interface;
using EntityModel.GenericModel;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000035 RID: 53
	public class SubmitLicenseAssignmentBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x0600015E RID: 350 RVA: 0x000252FC File Offset: 0x000234FC
		public SubmitLicenseAssignmentBatchOp(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> targetRadios, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selectedEidDetail, global::System.Collections.Generic.Dictionary<string, global::ASK.Interface.ISystemKeyData> userSelectedKeys = null, int featureType = 0)
		{
			this.d = targetRadios;
			this.e = selectedEidDetail;
			base.SelectedItems = targetRadios;
			this.a = userSelectedKeys;
			this.b = featureType;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00025334 File Offset: 0x00023534
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> TargetRadios
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1307502918;
				short num2 = num;
				num = (short)1304815942;
				switch (num2 == num)
				{
				default:
				{
					num = (short)106954752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1223622657;
				if (num != 0)
				{
				}
				num = (short)2143813632;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000253E4 File Offset: 0x000235E4
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> SelectedEidDetail
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)571012792;
				short num2 = num;
				num = (short)137492152;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1362821120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)270729216;
				if (num != 0)
				{
				}
				num = (short)1198129153;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00025494 File Offset: 0x00023694
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1919756638;
				short num2 = num;
				num = (short)1245718878;
				switch (num2 == num)
				{
				default:
				{
					num = (short)9961472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)188809216;
				if (num != 0)
				{
				}
				num = (short)542244865;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SubmitLicenseAssignment;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00025540 File Offset: 0x00023740
		public override string JobName
		{
			get
			{
				short num = (short)757202945;
				if (num != 0)
				{
				}
				num = (short)908984320;
				short num2 = num;
				num = (short)1001257758;
				short num3 = num;
				num = (short)1827404574;
				switch (num3 == num)
				{
				}
				num = (short)1063714816;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SubmitLicenseAssignment;
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000255EC File Offset: 0x000237EC
		public global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer DoWork()
		{
			short num = (short)399404745;
			short num2 = num;
			num = (short)1719103177;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1677000704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)735313921;
			if (num != 0)
			{
			}
			num = (short)1962606592;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer result = base.AddBatchJobContainer();
			this.OnDoWork(null);
			return result;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000256A4 File Offset: 0x000238A4
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 16;
			short num = (short)596705281;
			if (num != 0)
			{
			}
			num = (short)1972568064;
			short num2 = num;
			num = (short)1212153856;
			switch (num)
			{
			default:
			{
				this.c = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.Dictionary<string, global::System.Guid>>();
				int num3 = 0;
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.Enumerator enumerator = this.TargetRadios.GetEnumerator())
				{
					num = (short)383123461;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer3;
						switch (num4)
						{
						case 0:
							automaticPerformanceMeasurer = null;
							goto IL_143;
						case 1:
							num = (short)1034354692;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							try
							{
								num = (short)214302723;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									num = (short)63157553;
									short num5 = num;
									num = (short)495498545;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1321009152;
										if (num != 0)
										{
										}
										switch (num4)
										{
										case 0:
											num = (short)2104819716;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_609;
										case 2:
											try
											{
												switch (0)
												{
												case 0:
													goto IL_249;
												}
												global::EntityModel.GenericModel.CFSUpdateResult cfsUpdatedResult;
												for (;;)
												{
													IL_216:
													global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
													global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer4;
													global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer5;
													switch (num4)
													{
													case 0:
														automaticPerformanceMeasurer2 = null;
														goto IL_47D;
													case 1:
														if (automaticPerformanceMeasurer3 == null)
														{
															num = (short)1506279433;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														num = (short)488046600;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 2:
														automaticPerformanceMeasurer4 = automaticPerformanceMeasurer3.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.AssignLicense, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鯔룖귘닚믜ꛞ쇠뗢賤苦黨", a_)));
														goto IL_390;
													case 3:
														goto IL_4B6;
													case 4:
														automaticPerformanceMeasurer4 = null;
														goto IL_390;
													case 5:
														try
														{
															global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
															cfsUpdatedResult = this.a(radioBase);
															goto IL_321;
														}
														finally
														{
															num = (short)2020016129;
															num4 = (int)((global::System.IntPtr)num);
															for (;;)
															{
																switch (num4)
																{
																case 0:
																	goto IL_47A;
																case 1:
																	switch (0)
																	{
																	case 0:
																		goto IL_443;
																	}
																	continue;
																case 2:
																	automaticPerformanceMeasurer5.Dispose();
																	num = (short)1908539392;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																IL_443:
																if (automaticPerformanceMeasurer5 == null)
																{
																	break;
																}
																num = (short)1139539970;
																num4 = (int)((global::System.IntPtr)num);
															}
															IL_47A:;
														}
														goto IL_47D;
													case 6:
														num = (short)217317380;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 7:
														if (automaticPerformanceMeasurer3 == null)
														{
															num = (short)798228486;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														num = (short)1905655810;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 8:
														automaticPerformanceMeasurer2 = automaticPerformanceMeasurer3.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.AssignLicense, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蛔ꋖ믘뛚드ꯞ쇠迢賤蓦賨藪黬諮", a_)));
														goto IL_47D;
													case 9:
														num = (short)784334848;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 10:
														try
														{
															base.ViewCacheNotifier.CFSNotifyViewCacheLicenseChanged(cfsUpdatedResult, true);
															goto IL_49E;
														}
														finally
														{
															num = (short)1588985857;
															num4 = (int)((global::System.IntPtr)num);
															for (;;)
															{
																switch (num4)
																{
																case 0:
																	goto IL_31E;
																case 1:
																	switch (0)
																	{
																	case 0:
																		goto IL_2E7;
																	}
																	continue;
																case 2:
																	automaticPerformanceMeasurer5.Dispose();
																	num = (short)1621491712;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																IL_2E7:
																if (automaticPerformanceMeasurer5 == null)
																{
																	break;
																}
																num = (short)801308674;
																num4 = (int)((global::System.IntPtr)num);
															}
															IL_31E:;
														}
														goto IL_321;
														IL_49E:
														num = (short)327811075;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_249;
													IL_321:
													num = (short)1748041735;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_390:
													automaticPerformanceMeasurer5 = automaticPerformanceMeasurer4;
													num = (short)2135949322;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_47D:
													automaticPerformanceMeasurer5 = automaticPerformanceMeasurer2;
													num = (short)1741488133;
													num4 = (int)((global::System.IntPtr)num);
												}
												IL_4B6:
												goto IL_5E5;
												IL_249:
												cfsUpdatedResult = null;
												num = (short)1646264321;
												num4 = (int)((global::System.IntPtr)num);
												goto IL_216;
											}
											catch (global::Motorola.Common.CustomException.CommonException ex)
											{
												global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
												global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
												{
													JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED,
													ErrorCode = new int?((int)ex.ErrorCode),
													ErrorMessage = ex.Message,
													JobContainerUuid = new global::System.Guid?(base.JobContainerGuid),
													JobDescription = radioBase.SerialNumber
												};
												if (ex.CommonExceptionData != null)
												{
													batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
												}
												global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioLicenseService.AddBatchOperationJob(batchOperationJob);
												goto IL_5E5;
											}
											catch (global::System.Exception ex2)
											{
												global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
												global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
												{
													ErrorCode = new int?(1),
													ErrorMessage = ex2.Message,
													Parameters = string.Empty,
													JobDescription = radioBase.SerialNumber,
													JobContainerUuid = new global::System.Guid?(base.JobContainerGuid),
													JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED
												};
												global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.ManageRadioLicenseService.AddBatchOperationJob(job);
												goto IL_5E5;
											}
											goto IL_5A8;
											IL_5E5:
											num3++;
											base.ReportProgress(num3);
											num = (short)25034753;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											switch (0)
											{
											case 0:
												goto IL_1E4;
											}
											continue;
										case 4:
											goto IL_5E0;
										}
										IL_1E4:
										if (base.CancellationPending)
										{
											num = (short)1636368384;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_5A8:
										break;
									}
									num = (short)1458503682;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_5E0:
								return;
								IL_609:;
							}
							finally
							{
								num = (short)1173749761;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										goto IL_673;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_63D;
										}
										continue;
									case 2:
										automaticPerformanceMeasurer3.Dispose();
										num = (short)426704896;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_63D:
									if (automaticPerformanceMeasurer3 == null)
									{
										break;
									}
									num = (short)1533607938;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_673:;
							}
							break;
						case 3:
						{
							global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer = this.Measurer;
							if (measurer == null)
							{
								num = (short)786104320;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							automaticPerformanceMeasurer = measurer.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.AssignLicense, null).AddOrUpdateParameter(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蛔닖ꯘ닚볜돞쇠귢郤諦诨軪鿬", a_), radioBase.SerialNumber));
							goto IL_143;
						}
						case 4:
							goto IL_6CC;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_D5;
							}
							continue;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1255342081;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
							num = (short)841220099;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_D5;
						IL_143:
						automaticPerformanceMeasurer3 = automaticPerformanceMeasurer;
						num = (short)2090926082;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_676:
						num = (short)2084962310;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_D5:
						goto IL_676;
					}
					IL_6CC:;
				}
				return;
			}
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00025E24 File Offset: 0x00024024
		private global::EntityModel.GenericModel.CFSUpdateResult a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::EntityModel.GenericModel.CFSUpdateResult result;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IManageRadioLicenseService manageRadioLicenseService;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.a.Keys.Contains(A_0.SerialNumber))
					{
						num2 = (short)297074693;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_94;
				case 1:
				{
					num2 = (short)988741632;
					short num3 = num2;
					num2 = (short)1325334528;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return result;
				case 3:
					goto IL_70;
				case 4:
					return result;
				case 5:
				{
					result = manageRadioLicenseService.SubmitLicenseAssignment(this.SelectedEidDetail, A_0, this.c, base.JobContainerGuid, this.a[A_0.SerialNumber]);
					num2 = (short)1004217048;
					short num4 = num2;
					num2 = (short)1780425432;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_70;
					default:
						num2 = (short)570949632;
						if (num2 != 0)
						{
						}
						num2 = (short)187891716;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_28;
				IL_70:
				if (this.a != null)
				{
					num2 = (short)1010368513;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_94:
				result = manageRadioLicenseService.SubmitLicenseAssignment(this.SelectedEidDetail, A_0, this.c, base.JobContainerGuid, null);
				num2 = (short)1507393538;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_28:
			num2 = (short)1525350401;
			if (num2 != 0)
			{
			}
			manageRadioLicenseService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.ManageRadioLicenseService;
			num2 = (short)1171390467;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00026008 File Offset: 0x00024208
		private static bool a(string A_0, global::System.Guid? A_1, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> A_2, int A_3 = 0)
		{
			short num = (short)1562345619;
			short num2 = num;
			num = (short)44138643;
			switch (num2 == num)
			{
			}
			num = (short)1056571392;
			short num3 = num;
			num = (short)1112276993;
			if (num != 0)
			{
			}
			num = (short)479920128;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.ManageRadioLicenseService.GetAvailableDevicesCount(A_1, A_2, new global::System.Collections.Generic.List<string>
			{
				A_0
			}, A_3) == 1;
		}

		// Token: 0x0400006C RID: 108
		private readonly global::System.Collections.Generic.Dictionary<string, global::ASK.Interface.ISystemKeyData> a;

		// Token: 0x0400006D RID: 109
		private readonly int b;

		// Token: 0x0400006E RID: 110
		private global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.Dictionary<string, global::System.Guid>> c;

		// Token: 0x0400006F RID: 111
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> d;

		// Token: 0x04000070 RID: 112
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> e;
	}
}
