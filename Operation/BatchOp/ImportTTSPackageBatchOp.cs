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
	// Token: 0x0200003F RID: 63
	public class ImportTTSPackageBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string>
	{
		// Token: 0x0600017C RID: 380 RVA: 0x0002756C File Offset: 0x0002576C
		public ImportTTSPackageBatchOp(global::System.Collections.Generic.List<string> ttsFileList)
		{
			base.SelectedItems = ttsFileList;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00027588 File Offset: 0x00025788
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)12289726;
				short num2 = num;
				num = (short)1373537982;
				switch (num2 == num)
				{
				}
				num = (short)1357447168;
				short num3 = num;
				num = (short)1361051649;
				if (num != 0)
				{
				}
				num = (short)255590400;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportTTSPackage;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00027630 File Offset: 0x00025830
		public override string JobName
		{
			get
			{
				short num = (short)861473231;
				short num2 = num;
				num = (short)152832463;
				switch (num2 == num)
				{
				}
				num = (short)246480896;
				short num3 = num;
				num = (short)414646272;
				if (num != 0)
				{
				}
				num = (short)847052801;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ImportTTSPackage;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000276E0 File Offset: 0x000258E0
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 17;
			short num = (short)707526656;
			switch (num)
			{
			default:
			{
				int num2 = 0;
				global::System.Collections.Generic.IEnumerator<string> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)1157365764;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.Server.EntityModel.Package package;
						switch (num3)
						{
						case 0:
							num = (short)732954627;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (base.CancellationPending)
							{
								num = (short)363397120;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_480;
						case 2:
							num = (short)1071972358;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_9B;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_81;
							}
							continue;
						case 5:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_18F;
								}
								string text;
								for (;;)
								{
									IL_154:
									switch (num3)
									{
									case 0:
										if (package.RMFile != null)
										{
											num = (short)2093285382;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_23D;
									case 1:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech item;
										base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech>
										{
											item
										});
										num = (short)1072627724;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_394;
									case 3:
										num = (short)782958592;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										if (package.RMFile.Url == null)
										{
											num = (short)577634309;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										bool flag = false;
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.CheckAndImportBacthPackage(base.JobContainerGuid, package.RMFile.Url, package, text, out flag);
										num = (short)321912843;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_2E3;
									case 6:
										num = (short)405864452;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										bool flag;
										if (flag)
										{
											num = (short)22216705;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech item;
										base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech>
										{
											item
										});
										num = (short)154992642;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										if (package != null)
										{
											num = (short)338690051;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_23D;
									case 9:
									{
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
										global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech item = packageSummary.ToUiModel() as global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech;
										num = (short)502202375;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
										goto IL_3AD;
									case 11:
									{
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
										if (packageSummary != null)
										{
											num = (short)1229193225;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_394;
									}
									case 12:
										goto IL_394;
									}
									goto IL_18F;
									IL_394:
									num = (short)1465319434;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_23D:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_CpsDidntReturnInfo + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_File0, text));
								IL_2E3:
								goto IL_23D;
								IL_3AD:
								goto IL_A0;
								IL_18F:
								package = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AnalysisPackageInfo(text);
								num = (short)486473736;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_154;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
								string text;
								batchOperationJob.JobDescription = text;
								batchOperationJob.ErrorCode = new int?(2181);
								batchOperationJob.ErrorMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_InvalidTTSFile;
								if (ex.CommonExceptionData == null)
								{
									goto IL_405;
								}
								IL_3EB:
								batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
								IL_405:
								num = (short)2014399410;
								short num4 = num;
								num = (short)1724730290;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_3EB;
								default:
									num = (short)73531392;
									if (num != 0)
									{
									}
									batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
									batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddBatchOperationJob(batchOperationJob);
									goto IL_A0;
								}
							}
							goto IL_480;
							IL_A0:
							num2++;
							base.ReportProgress(num2);
							num = (short)1903230984;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_4B8;
						case 7:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1080819714;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text = enumerator.Current;
							num = (short)999489537;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_10A:
						num = (short)626262023;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_81:
						goto IL_10A;
						IL_480:
						package = null;
						num = (short)1177354245;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_9B:
					IL_4B8:;
				}
				finally
				{
					num = (short)1825243138;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_525;
						case 1:
							enumerator.Dispose();
							num = (short)1890844672;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_4ED;
							}
							continue;
						}
						IL_4ED:
						if (enumerator == null)
						{
							break;
						}
						num = (short)570359809;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_525:;
				}
				num = (short)1532952577;
				if (num != 0)
				{
				}
				num = (short)875495424;
				short num5 = num;
				return;
			}
			}
		}
	}
}
