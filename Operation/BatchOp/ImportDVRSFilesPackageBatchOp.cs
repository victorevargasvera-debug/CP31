using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
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
	// Token: 0x02000015 RID: 21
	public class ImportDVRSFilesPackageBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string>
	{
		// Token: 0x0600008D RID: 141 RVA: 0x0000A420 File Offset: 0x00008620
		public ImportDVRSFilesPackageBatchOp(global::System.Collections.Generic.List<string> vaFileList)
		{
			base.SelectedItems = vaFileList;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000A43C File Offset: 0x0000863C
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1912471553;
				if (num != 0)
				{
				}
				num = (short)292347964;
				short num2 = num;
				num = (short)173137980;
				switch (num2 == num)
				{
				default:
				{
					num = (short)863895552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1707671552;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportDVRSFilesPackage;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000A4E8 File Offset: 0x000086E8
		public override string JobName
		{
			get
			{
				short num = (short)1919123552;
				short num2 = num;
				num = (short)1067941984;
				switch (num2 == num)
				{
				}
				num = (short)44105728;
				short num3 = num;
				num = (short)490536960;
				if (num != 0)
				{
				}
				num = (short)1955397633;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ImportDVRSFilesPackage;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000A598 File Offset: 0x00008798
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 9;
			short num = (short)1770586112;
			switch (num)
			{
			default:
			{
				num = (short)753926144;
				short num2 = num;
				int num3 = 0;
				global::System.Collections.Generic.IEnumerator<string> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)808058888;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.Server.EntityModel.Package package;
						switch (num4)
						{
						case 0:
							try
							{
								num = (short)928579598;
								num4 = (int)((global::System.IntPtr)num);
								string text;
								for (;;)
								{
									switch (num4)
									{
									case 0:
									{
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
										global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles item = packageSummary.ToUiModel() as global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles;
										num = (short)1364066307;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_49D;
									case 2:
										goto IL_4B6;
									case 3:
									{
										num = (short)1401967192;
										short num5 = num;
										num = (short)1439519320;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
										{
											num = (short)580845568;
											if (num != 0)
											{
											}
											bool flag;
											if (flag)
											{
												num = (short)942211079;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles item;
											base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles>
											{
												item
											});
											break;
										}
										}
										num = (short)735641608;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
										if (packageSummary != null)
										{
											num = (short)1971453952;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_49D;
									}
									case 5:
										if (package.RMFile != null)
										{
											num = (short)1451556876;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_276;
									case 6:
									{
										if (package.RMFile.Url == null)
										{
											num = (short)1397358601;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										bool flag = false;
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.CheckAndImportBacthPackage(base.JobContainerGuid, package.RMFile.Url, package, text, out flag);
										num = (short)786300932;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles item;
										base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles>
										{
											item
										});
										num = (short)916979713;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										goto IL_49D;
									case 9:
										goto IL_364;
									case 10:
										if (package != null)
										{
											num = (short)875429901;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_276;
									case 11:
										package = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AnalysisPackageInfo(text);
										num = (short)1886978058;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 12:
										num = (short)1548550150;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 13:
										num = (short)387973125;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 14:
										switch (0)
										{
										case 0:
											goto IL_1DA;
										}
										continue;
									}
									IL_1DA:
									if (this.a(text))
									{
										num = (short)1246429195;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
									IL_49D:
									num = (short)1070989314;
									num4 = (int)((global::System.IntPtr)num);
								}
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DVRS_File_Error_Importing, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DVRS_File_Error_Importing + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_File0, text));
								IL_276:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_CpsDidntReturnInfo + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_File0, text));
								IL_364:
								goto IL_276;
								IL_4B6:
								goto IL_CA;
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
								goto IL_CA;
							}
							goto IL_543;
							IL_CA:
							num3++;
							base.ReportProgress(num3);
							num = (short)577896455;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1898971140;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1490354179;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text = enumerator.Current;
							num = (short)1055064070;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)711131141;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_C5;
						case 5:
							goto IL_57D;
						case 6:
							if (base.CancellationPending)
							{
								num = (short)1363083265;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_543;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_AB;
							}
							continue;
						}
						IL_134:
						num = (short)514981890;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_AB:
						goto IL_134;
						IL_543:
						package = null;
						num = (short)1264320512;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_C5:
					IL_57D:;
				}
				finally
				{
					num = (short)1526398978;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							enumerator.Dispose();
							num = (short)660799489;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_611;
						case 2:
							num = (short)1635188737;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_5DC;
							}
							continue;
						}
						IL_5DC:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1229717504;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_611:;
				}
				return;
			}
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		public bool ValidateFile(string file)
		{
			short num = (short)852516985;
			short num2 = num;
			num = (short)1355309177;
			switch (num2 == num)
			{
			}
			num = (short)1063911424;
			if (num != 0)
			{
			}
			num = (short)1476526080;
			short num3 = num;
			num = (short)386072577;
			if (num != 0)
			{
			}
			return this.a(file);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		private bool a(string A_0)
		{
			int a_ = 7;
			short num = (short)2099970052;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1492453332;
				short num3 = num;
				num = (short)2130380756;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1005191168;
					if (num != 0)
					{
					}
					num = (short)1778122752;
					short num4 = num;
					switch (num2)
					{
					case 0:
						if (!global::System.IO.File.ReadAllText(A_0).StartsWith(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("裋跍铏", a_)))
						{
							num = (short)219807747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1250033669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_149;
					case 2:
						return false;
					case 3:
						goto IL_21B;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_B8;
						}
						continue;
					case 5:
						num = (short)828047361;
						if (num != 0)
						{
						}
						if (new global::System.IO.FileInfo(A_0).Length > 524288L)
						{
							num = (short)477364225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					IL_B8:
					if (A_0 == null)
					{
						num = (short)1304494082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				num = (short)761266176;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_149:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DVRS_File_Invalid_Size, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DVRS_File_Invalid_Size + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_File0, A_0));
			IL_21B:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DVRS_File_Invalid_Format, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DVRS_File_Invalid_Format + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_File0, A_0));
		}
	}
}
