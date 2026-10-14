using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
	// Token: 0x02000040 RID: 64
	public class ImportVAPackageBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string>
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00027C9C File Offset: 0x00025E9C
		public ImportVAPackageBatchOp(global::System.Collections.Generic.List<string> vaFileList)
		{
			base.SelectedItems = vaFileList;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00027CB8 File Offset: 0x00025EB8
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1967118475;
				short num2 = num;
				num = (short)823384203;
				switch (num2 == num)
				{
				}
				num = (short)1098776577;
				if (num != 0)
				{
				}
				num = (short)1530658816;
				short num3 = num;
				num = (short)1176240128;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportVAPackage;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00027D68 File Offset: 0x00025F68
		public override string JobName
		{
			get
			{
				short num = (short)709420909;
				short num2 = num;
				num = (short)474605421;
				switch (num2 == num)
				{
				}
				num = (short)892207104;
				if (num != 0)
				{
				}
				num = (short)1472921600;
				short num3 = num;
				num = (short)996278273;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ImportVAPackage;
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00027E18 File Offset: 0x00026018
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 18;
			short num = (short)1542914049;
			if (num != 0)
			{
			}
			num = (short)1861943296;
			switch (num)
			{
			default:
			{
				int num2 = 0;
				global::System.Collections.Generic.IEnumerator<string> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)76218372;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.Server.EntityModel.Package package;
						switch (num3)
						{
						case 0:
							num = (short)1536163843;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (base.CancellationPending)
							{
								num = (short)382730240;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4B3;
						case 2:
							num = (short)2140667910;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_C2;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_A8;
							}
							continue;
						case 5:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_1BB;
								}
								string text;
								for (;;)
								{
									IL_180:
									switch (num3)
									{
									case 0:
										if (package.RMFile != null)
										{
											num = (short)1337589766;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_269;
									case 1:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement item;
										base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement>
										{
											item
										});
										num = (short)527630348;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_3C1;
									case 3:
										num = (short)882180096;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										if (package.RMFile.Url == null)
										{
											num = (short)1604714501;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										bool flag = false;
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.CheckAndImportBacthPackage(base.JobContainerGuid, package.RMFile.Url, package, text, out flag);
										num = (short)1460469771;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_30E;
									case 6:
										num = (short)296615940;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										bool flag;
										if (flag)
										{
											num = (short)1933508609;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement item;
										base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement>
										{
											item
										});
										num = (short)883097602;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										if (package != null)
										{
											num = (short)2100166659;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_269;
									case 9:
									{
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
										global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement item = packageSummary.ToUiModel() as global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement;
										num = (short)712048647;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
										goto IL_3D9;
									case 11:
									{
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
										if (packageSummary != null)
										{
											num = (short)1398865929;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3C1;
									}
									case 12:
										goto IL_3C1;
									}
									goto IL_1BB;
									IL_3C1:
									num = (short)1993080842;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_269:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_CpsDidntReturnInfo + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_File0, text));
								IL_30E:
								goto IL_269;
								IL_3D9:
								goto IL_C7;
								IL_1BB:
								package = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AnalysisPackageInfo(text);
								num = (short)1228668936;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_180;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
								string text;
								batchOperationJob.JobDescription = text;
								batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
								batchOperationJob.ErrorMessage = ex.Message;
								if (ex.CommonExceptionData == null)
								{
									goto IL_435;
								}
								IL_41B:
								batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
								IL_435:
								num = (short)1708805438;
								short num4 = num;
								num = (short)1597263166;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_41B;
								default:
									num = (short)1932918784;
									if (num != 0)
									{
									}
									batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
									batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddBatchOperationJob(batchOperationJob);
									goto IL_C7;
								}
							}
							goto IL_4B3;
							IL_C7:
							num2++;
							base.ReportProgress(num2);
							num = (short)310837256;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_4EB;
						case 7:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)334299138;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text = enumerator.Current;
							num = (short)1067974657;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_134:
						num = (short)253100039;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A8:
						goto IL_134;
						IL_4B3:
						package = null;
						num = (short)563478533;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_C2:
					IL_4EB:;
				}
				finally
				{
					num = (short)1196556290;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_556;
						case 1:
							enumerator.Dispose();
							num = (short)1249443840;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_520;
							}
							continue;
						}
						IL_520:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1982267393;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_556:;
				}
				num = (short)388759552;
				short num5 = num;
				return;
			}
			}
		}
	}
}
