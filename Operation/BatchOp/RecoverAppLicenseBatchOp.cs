using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200002B RID: 43
	public class RecoverAppLicenseBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string>
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00021E58 File Offset: 0x00020058
		public RecoverAppLicenseBatchOp()
		{
			int a_ = 19;
			base..ctor();
			base.SelectedItems = new global::System.Collections.Generic.List<string>
			{
				global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("諗뿙뿛뇝雟蟡難웥ꧧ髩鳫苭駯釱闳苵釷闹鋻\udefd䳿欁會挅昇礉椋", a_)
			};
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00021E94 File Offset: 0x00020094
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)998113281;
				if (num != 0)
				{
				}
				num = (short)1446519428;
				short num2 = num;
				num = (short)973021828;
				switch (num2 == num)
				{
				}
				num = (short)500957184;
				short num3 = num;
				num = (short)1287323648;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.RecoverAppLicense;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00021F40 File Offset: 0x00020140
		public override string JobName
		{
			get
			{
				short num = (short)121277200;
				short num2 = num;
				num = (short)687311632;
				switch (num2 == num)
				{
				}
				num = (short)234684417;
				if (num != 0)
				{
				}
				num = (short)620953600;
				short num3 = num;
				num = (short)1767178240;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_RecoverAppLicense;
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00021FF0 File Offset: 0x000201F0
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)2144600064;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						string text;
						batchOperationJob.WarningMessage = text;
						num = (short)1763377152;
						short num3 = num;
						num = (short)1781792771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)2019950592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_317;
					}
					case 2:
						return;
					case 3:
						goto IL_317;
					case 4:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_139;
							}
							for (;;)
							{
								IL_11A:
								switch (num2)
								{
								case 0:
									goto IL_242;
								case 1:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo> list;
									if (list.Count > 0)
									{
										num = (short)1784283138;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_242;
								}
								case 2:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo> list;
									base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo>(list);
									num = (short)862322688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_25A;
								case 4:
									num = (short)269746177;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo> list;
									if (list != null)
									{
										num = (short)839450628;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_242;
								}
								}
								goto IL_139;
								IL_242:
								num = (short)1029308419;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_25A:
							goto IL_AB;
							for (;;)
							{
								IL_139:
								string text;
								global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.RecoverAppLicense(out text, true);
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo> list = base.LocalService.ListAppLicenses();
								num = (short)1471116190;
								short num4 = num;
								num = (short)536114078;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_18D;
								}
							}
							IL_18D:
							num = (short)833355776;
							if (num != 0)
							{
							}
							num = (short)494665733;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_11A;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
							batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
							batchOperationJob.ErrorMessage = ex.Message;
							if (ex.CommonExceptionData != null)
							{
								batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
							}
							batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
							batchOperationJob.JobDescription = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_AppLicense;
							global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.AddBatchOperationJob(batchOperationJob);
							return;
						}
						finally
						{
							num = (short)2128019457;
							if (num != 0)
							{
							}
							global::System.Threading.Thread.Sleep(100);
							global::System.GC.Collect();
							global::System.GC.WaitForPendingFinalizers();
							base.ReportProgress(1);
						}
						goto IL_317;
						IL_AB:
						batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED;
						batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
						batchOperationJob.JobDescription = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_AppLicense;
						num = (short)1243283457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42;
					IL_317:
					global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.AddBatchOperationJob(batchOperationJob);
					num = (short)1573257218;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_42:
				batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
				num = (short)1958215684;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
