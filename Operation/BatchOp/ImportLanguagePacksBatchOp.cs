using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	// Token: 0x02000052 RID: 82
	public class ImportLanguagePacksBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.Server.EntityModel.Package>
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x00030628 File Offset: 0x0002E828
		public ImportLanguagePacksBatchOp(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> lpList)
		{
			base.SelectedItems = lpList;
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00030644 File Offset: 0x0002E844
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1207929654;
				short num2 = num;
				num = (short)68979510;
				switch (num2 == num)
				{
				}
				num = (short)1668415488;
				short num3 = num;
				num = (short)1847328769;
				if (num != 0)
				{
				}
				num = (short)1312096256;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportLanguagePacks;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000306EC File Offset: 0x0002E8EC
		public override string JobName
		{
			get
			{
				short num = (short)143938537;
				short num2 = num;
				num = (short)890852329;
				switch (num2 == num)
				{
				}
				num = (short)358285312;
				short num3 = num;
				num = (short)1078067200;
				if (num != 0)
				{
				}
				num = (short)1400766465;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ImportLanguagePacks;
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0003079C File Offset: 0x0002E99C
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 9;
			short num = (short)2027159553;
			if (num != 0)
			{
			}
			num = (short)1802633216;
			switch (num)
			{
			default:
			{
				num = (short)154402816;
				short num2 = num;
				int num3 = 0;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.Package> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)778240012;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::Motorola.CommonCPS.Server.EntityModel.Package package;
							global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack pcrlanguagePack = package as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack;
							string name;
							string jobDescription = string.Concat(new string[]
							{
								name,
								global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_),
								pcrlanguagePack.PackageName,
								global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("重", a_),
								pcrlanguagePack.PackageVersion,
								global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_)
							});
							num = (short)1667235843;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (base.CancellationPending)
							{
								num = (short)1661796357;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)703922187;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)241434637;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.Package package = enumerator.Current;
							string jobDescription = string.Empty;
							string name = new global::System.IO.FileInfo(package.RMFile.Url).Name;
							num = (short)865337351;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_55C;
						case 5:
							num = (short)380436489;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::Motorola.CommonCPS.Server.EntityModel.Package package;
							if (package is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack)
							{
								num = (short)291766272;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_55C;
						}
						case 7:
						{
							global::Motorola.CommonCPS.Server.EntityModel.Package package;
							if (package is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack)
							{
								num = (short)626327560;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)445317126;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::Motorola.CommonCPS.Server.EntityModel.Package package;
							global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack = package as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack;
							string name;
							string jobDescription = string.Concat(new string[]
							{
								name,
								global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_),
								astrolanguagePack.PackageLanguage,
								global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("重", a_),
								astrolanguagePack.PackageVersion,
								global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_)
							});
							num = (short)138084366;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_453;
						case 10:
							goto IL_5B5;
						case 11:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_1FE;
								}
								global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
								bool flag;
								for (;;)
								{
									IL_1DB:
									switch (num4)
									{
									case 0:
										goto IL_354;
									case 1:
										goto IL_354;
									case 2:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack item = packageSummary.ToUiModel() as global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack;
										num = (short)248119302;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack item;
										base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack>
										{
											item
										});
										num = (short)1376714752;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										if (packageSummary != null)
										{
											num = (short)2024013826;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_354;
									case 5:
										goto IL_36E;
									case 6:
									{
										if (flag)
										{
											num = (short)1755185155;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)432278417;
										short num5 = num;
										num = (short)704449425;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
										{
											num = (short)1000341504;
											if (num != 0)
											{
											}
											global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack item;
											base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack>
											{
												item
											});
											num = (short)2078081025;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										break;
									}
									}
									goto IL_1FE;
									IL_354:
									num = (short)863961093;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_36E:
								goto IL_12A;
								IL_1FE:
								flag = false;
								global::Motorola.CommonCPS.Server.EntityModel.Package package;
								string jobDescription;
								packageSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.CheckAndImportBacthPackage(base.JobContainerGuid, package.RMFile.Url, package, jobDescription, out flag);
								num = (short)1589182468;
								num4 = (int)((global::System.IntPtr)num);
								goto IL_1DB;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
								string jobDescription;
								batchOperationJob.JobDescription = jobDescription;
								batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
								batchOperationJob.ErrorMessage = ex.Message;
								if (ex.CommonExceptionData != null)
								{
									batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
								}
								batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
								batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
								global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddBatchOperationJob(batchOperationJob);
								goto IL_12A;
							}
							break;
							IL_12A:
							num3++;
							base.ReportProgress(num3);
							num = (short)907411460;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							switch (0)
							{
							case 0:
								goto IL_E9;
							}
							continue;
						case 13:
							num = (short)698155018;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_55C;
						}
						IL_3FB:
						num = (short)2142437378;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E9:
						goto IL_3FB;
						IL_55C:
						num = (short)21037057;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_453:
					IL_5B5:;
				}
				finally
				{
					num = (short)1664417794;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1623261185;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_621;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_5EA;
							}
							continue;
						}
						IL_5EA:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1371930624;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_621:;
				}
				return;
			}
			}
		}
	}
}
