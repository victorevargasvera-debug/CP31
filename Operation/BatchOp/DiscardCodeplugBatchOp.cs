using System;
using System.Collections.Generic;
using System.ComponentModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000038 RID: 56
	public class DiscardCodeplugBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00026D3C File Offset: 0x00024F3C
		public DiscardCodeplugBatchOp(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radioList)
		{
			base.SelectedItems = radioList;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00026D58 File Offset: 0x00024F58
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)747813261;
				short num2 = num;
				num = (short)501070221;
				switch (num2 == num)
				{
				}
				num = (short)1895432192;
				short num3 = num;
				num = (short)253689857;
				if (num != 0)
				{
				}
				num = (short)1576599552;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DiscardCodeplugChanges;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00026E04 File Offset: 0x00025004
		public override string JobName
		{
			get
			{
				short num = (short)467468289;
				if (num != 0)
				{
				}
				num = (short)1490059608;
				short num2 = num;
				num = (short)1657373016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)618856448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2133655552;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.DiscardCodeplugChanges;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00026EB4 File Offset: 0x000250B4
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)1099235328;
			switch (num)
			{
			default:
			{
				num = (short)366477312;
				short num2 = num;
				num = (short)1530724353;
				if (num != 0)
				{
				}
				int num3 = 0;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)2127233030;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService;
						switch (num4)
						{
						case 0:
							if (base.CancellationPending)
							{
								num = (short)673710085;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_332;
						case 2:
							goto IL_E3;
						case 3:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_1B4;
								}
								global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
								for (;;)
								{
									IL_19D:
									switch (num4)
									{
									case 0:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = radioSummary.ToUiModel(true);
										base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
										{
											item
										});
										num = (short)377487362;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										if (radioSummary != null)
										{
											goto IL_1E7;
										}
										goto IL_23B;
									case 2:
										goto IL_23B;
									case 3:
										goto IL_29E;
									}
									goto IL_1B4;
									IL_1E7:
									num = (short)1433010176;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_23B:
									num = (short)62116197;
									short num5 = num;
									num = (short)258920805;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1E7;
									default:
										num = (short)1423048704;
										if (num != 0)
										{
										}
										num = (short)1939275779;
										num4 = (int)((global::System.IntPtr)num);
										break;
									}
								}
								IL_29E:
								goto IL_E8;
								IL_1B4:
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
								radioSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.DiscardCodeplugChanges(base.JobContainerGuid, radioBase);
								num = (short)639107073;
								num4 = (int)((global::System.IntPtr)num);
								goto IL_19D;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
								batchOperationJob.JobDescription = radioBase.SerialNumber;
								batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
								batchOperationJob.ErrorMessage = ex.Message;
								if (ex.CommonExceptionData != null)
								{
									batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
								}
								batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
								batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
								radioService.AddBatchOperationJob(batchOperationJob);
								num3++;
								base.ReportProgress(num3);
								break;
							}
							goto IL_332;
							IL_E8:
							num3++;
							base.ReportProgress(num3);
							num = (short)1124466689;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)134742023;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
							num = (short)1496645632;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)1406205954;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_C7;
							}
							continue;
						case 7:
							num = (short)1139343368;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_376;
						}
						IL_153:
						num = (short)152043524;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_C7:
						goto IL_153;
						IL_332:
						radioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
						num = (short)2054422531;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_E3:
					IL_376:;
				}
				finally
				{
					num = (short)524681216;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_3AB;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1998061570;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_3E1;
						}
						IL_3AB:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2621441;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_3E1:;
				}
				return;
			}
			}
		}
	}
}
