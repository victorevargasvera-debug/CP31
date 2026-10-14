using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ASK.Interface;
using CommonASK;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000029 RID: 41
	public class UpdateRadioBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00020F4C File Offset: 0x0001F14C
		public UpdateRadioBatchOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radioList, int selectSystemKeyData, global::ASK.Interface.KeyType selectedkeyType, bool writeProtect, global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> attachedKeys)
		{
			base.SelectedItems = radioList;
			this.a = selectSystemKeyData;
			this.c = selectedkeyType;
			this.b = writeProtect;
			this.d = attachedKeys;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00020F84 File Offset: 0x0001F184
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1058324554;
				short num2 = num;
				num = (short)1632682058;
				switch (num2 == num)
				{
				}
				num = (short)631504896;
				short num3 = num;
				num = (short)1763901440;
				if (num != 0)
				{
				}
				num = (short)1158021121;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpdateRadio;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00021034 File Offset: 0x0001F234
		public override string JobName
		{
			get
			{
				short num = (short)1362532038;
				short num2 = num;
				num = (short)1876137670;
				switch (num2 == num)
				{
				}
				num = (short)759562240;
				short num3 = num;
				num = (short)1863974912;
				if (num != 0)
				{
				}
				num = (short)340459521;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.UpdateRadio;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000210E4 File Offset: 0x0001F2E4
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 2;
			short num = (short)1124597760;
			switch (num)
			{
			default:
			{
				num = (short)954531840;
				short num2 = num;
				num = (short)214499329;
				if (num != 0)
				{
				}
				int num3 = 0;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService iastroradioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService;
				global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary = null;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)802422795;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							if (radioSummary != null)
							{
								num = (short)155451400;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10F;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1275789315;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
							num = (short)1384448010;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_10F;
						case 3:
							goto IL_5E7;
						case 4:
							num = (short)1655635974;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_10A;
						case 7:
							try
							{
								num = (short)697958409;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
									switch (num4)
									{
									case 0:
									{
										global::ASK.Interface.ISystemKeyData systemKeyData;
										if (systemKeyData.AccessLevelType != global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
										{
											num = (short)2030960642;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_470;
									}
									case 1:
										num = (short)1825701888;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										num = (short)1020788741;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										global::CommonASK.SystemKeyData item = new global::CommonASK.SystemKeyData(global::ASK.Interface.KeyAccessLevelType.UNLM_ACC, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_), false, global::ASK.Interface.KeySource.HARDWARE, 1, global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_), false);
										this.d.Add(item);
										global::ASK.Interface.ISystemKeyData systemKeyData = new global::CommonASK.SystemKeyData(global::ASK.Interface.KeyAccessLevelType.UNLM_ACC, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_), false, global::ASK.Interface.KeySource.HARDWARE, 0, global::ASK.Interface.KeyType.NONE, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_), false);
										int? num5 = astroradio.OwnerAdvKeyType;
										global::ASK.Interface.KeyType value = (global::ASK.Interface.KeyType)num5.Value;
										num5 = astroradio.OwnerSystemId;
										num = (short)1742209032;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_470;
									case 5:
									{
										global::ASK.Interface.ISystemKeyData systemKeyData;
										if (systemKeyData.AccessLevelType == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
										{
											num = (short)623902724;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_4C2;
									}
									case 6:
										num = (short)2050686983;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_4FB;
									case 8:
									{
										int? num5;
										int value2 = num5.Value;
										astroradio.AskRequired = this.b;
										bool? disableWriteProtect = astroradio.DisableWriteProtect;
										bool flag = false;
										if ((disableWriteProtect.GetValueOrDefault() == flag & disableWriteProtect != null) && this.b)
										{
											astroradio.DisableWriteProtect = new bool?(this.b);
										}
										global::ASK.Interface.ISystemKeyData systemKeyData;
										global::ASK.Interface.KeyType value;
										if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ASKUtility.CheckIfOwnerASKIsAttached(value2, value, this.d, out systemKeyData))
										{
											num = (short)111280129;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_4CD;
									}
									case 9:
										switch (0)
										{
										case 0:
											goto IL_2AA;
										}
										continue;
									}
									IL_2AA:
									if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroCheckIsConvOnly(astroradio.AstroPurchasedFlashCode, astroradio.ModelNumber))
									{
										num = (short)1768947715;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4D8;
									IL_470:
									radioSummary = iastroradioService.QueryAndUpdateRadio(base.JobContainerGuid, astroradio.ToServerModel(), this.c, this.a, astroradio.DisableWriteProtect.Value, astroradio.AskRequired);
									num = (short)479133702;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_4C2:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Unlimited_key_check_for_radio_owner_system_ID);
								IL_4CD:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Unlimited_key_check_for_radio_owner_system_ID);
								IL_4D8:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Cnv_check_for_owner_system_ID);
								IL_4FB:
								goto IL_21F;
							}
							catch (global::System.Exception ex)
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
								global::Motorola.Common.CustomException.CommonException ex2;
								string[] paramters;
								if (ex is global::Motorola.Common.CustomException.CommonException)
								{
									ex2 = (ex as global::Motorola.Common.CustomException.CommonException);
									paramters = null;
									if (ex2.CommonExceptionData != null)
									{
										goto IL_5C2;
									}
								}
								else
								{
									num = (short)725096527;
									short num6 = num;
									num = (short)482351183;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_5C2;
									default:
									{
										num = (short)63766528;
										if (num != 0)
										{
										}
										global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpUtility.CreateFailureJob(base.JobContainerGuid, astroradio.SerialNumber, global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, null);
										iastroradioService.AddBatchOperationJob(job);
										goto IL_5D7;
									}
									}
								}
								IL_510:
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job2 = global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpUtility.CreateFailureJob(base.JobContainerGuid, astroradio.SerialNumber, ex2.ErrorCode, paramters);
								iastroradioService.AddBatchOperationJob(job2);
								goto IL_5D7;
								IL_5C2:
								paramters = ex2.CommonExceptionData.Paramters;
								goto IL_510;
								IL_5D7:
								num3++;
								base.ReportProgress(num3);
								break;
							}
							goto IL_5E7;
							IL_21F:
							num = (short)1242038272;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item2 = radioSummary.ToUiModel(true);
							base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
							{
								item2
							});
							num = (short)1808203778;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_5FF;
						case 10:
						{
							if (base.CancellationPending)
							{
								num = (short)616890372;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = radioBase as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
							num = (short)1754529799;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							switch (0)
							{
							case 0:
								goto IL_F0;
							}
							continue;
						}
						goto IL_F0;
						IL_10F:
						num3++;
						base.ReportProgress(num3);
						num = (short)1612578821;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BC:
						num = (short)346095617;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_F0:
						goto IL_1BC;
						IL_5E7:
						num = (short)913833993;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_10A:
					IL_5FF:;
				}
				finally
				{
					num = (short)76546050;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							enumerator.Dispose();
							num = (short)2072379393;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_66A;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_634;
							}
							continue;
						}
						IL_634:
						if (enumerator == null)
						{
							break;
						}
						num = (short)853999616;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_66A:;
				}
				return;
			}
			}
		}

		// Token: 0x04000059 RID: 89
		private int a;

		// Token: 0x0400005A RID: 90
		private bool b;

		// Token: 0x0400005B RID: 91
		private global::ASK.Interface.KeyType c;

		// Token: 0x0400005C RID: 92
		private global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> d;
	}
}
