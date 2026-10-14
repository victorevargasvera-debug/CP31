using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000013 RID: 19
	public class SubmitAppLicenseFileOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string>
	{
		// Token: 0x06000081 RID: 129 RVA: 0x000092E0 File Offset: 0x000074E0
		public SubmitAppLicenseFileOp(byte[] licenseFile)
		{
			int a_ = 1;
			base..ctor();
			this.LicenseFileContent = licenseFile;
			base.SelectedItems = new global::System.Collections.Generic.List<string>
			{
				global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("胅ꇇꛉ꧋", a_)
			};
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00009324 File Offset: 0x00007524
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000093D0 File Offset: 0x000075D0
		public byte[] LicenseFileContent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)21245014;
				short num2 = num;
				num = (short)1619536982;
				switch (num2 == num)
				{
				}
				num = (short)1949302784;
				short num3 = num;
				num = (short)158203905;
				if (num != 0)
				{
				}
				num = (short)1579024384;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)835040028;
				short num2 = num;
				num = (short)1549841180;
				switch (num2 == num)
				{
				}
				num = (short)447348736;
				short num3 = num;
				num = (short)266207232;
				if (num != 0)
				{
				}
				num = (short)1835532289;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00009484 File Offset: 0x00007684
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1517138578;
				short num2 = num;
				num = (short)1175827090;
				switch (num2 == num)
				{
				}
				num = (short)458620928;
				short num3 = num;
				num = (short)881065985;
				if (num != 0)
				{
				}
				num = (short)539885568;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SubmitAppLicenseFile;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00009530 File Offset: 0x00007730
		public override string JobName
		{
			get
			{
				short num = (short)172172765;
				short num2 = num;
				num = (short)1419060701;
				switch (num2 == num)
				{
				}
				num = (short)773586944;
				short num3 = num;
				num = (short)1406664705;
				if (num != 0)
				{
				}
				num = (short)1041301504;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SubmitAppLicenseFile;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000095E0 File Offset: 0x000077E0
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)1088225280;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<string> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)1395654659;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.ILicenseService appLicenseService;
						switch (num2)
						{
						case 0:
							try
							{
								appLicenseService.SubmitAppLicenseFile(this.LicenseFileContent);
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
								{
									JobContainerUuid = new global::System.Guid?(base.JobContainerGuid),
									JobDescription = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_AppLicense,
									JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED
								};
								appLicenseService.AddBatchOperationJob(job);
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo> items = base.LocalService.ListAppLicenses();
								base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo>(items);
								goto IL_22D;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
								{
									JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED,
									ErrorCode = new int?((int)ex.ErrorCode),
									ErrorMessage = ex.Message
								};
								if (ex.CommonExceptionData != null)
								{
									batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
								}
								batchOperationJob.JobDescription = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_AppLicense;
								batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
								appLicenseService.AddBatchOperationJob(batchOperationJob);
								goto IL_22D;
							}
							break;
							IL_22D:
							base.ReportProgress(1);
							num = (short)1881538564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_269;
						case 2:
							num = (short)1540685825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							num = (short)1391590131;
							short num3 = num;
							num = (short)559217395;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D5;
							default:
								num = (short)399900672;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_B7;
								}
								continue;
							}
							break;
						}
						case 5:
							if (!enumerator.MoveNext())
							{
								num = (short)1567162370;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1D5;
						}
						IL_196:
						num = (short)307167237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B7:
						goto IL_196;
						IL_1D5:
						string text = enumerator.Current;
						appLicenseService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService;
						num = (short)845152257;
						if (num != 0)
						{
						}
						num = (short)27656192;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_269:;
				}
				finally
				{
					num = (short)1932984322;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_2D4;
						case 1:
							enumerator.Dispose();
							num = (short)1474166784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_29D;
							}
							continue;
						}
						IL_29D:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1399390209;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2D4:;
				}
				num = (short)1429340160;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x04000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte[] a;
	}
}
