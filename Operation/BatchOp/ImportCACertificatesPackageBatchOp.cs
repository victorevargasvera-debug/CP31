using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
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
	// Token: 0x02000014 RID: 20
	public class ImportCACertificatesPackageBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string>
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00009920 File Offset: 0x00007B20
		public ImportCACertificatesPackageBatchOp(global::System.Collections.Generic.List<string> vaFileList)
		{
			base.SelectedItems = vaFileList;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000993C File Offset: 0x00007B3C
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)155385857;
				if (num != 0)
				{
				}
				num = (short)2146274952;
				short num2 = num;
				num = (short)1374916232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)388497408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1187250176;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportCACertificatesPackage;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000099E4 File Offset: 0x00007BE4
		public override string JobName
		{
			get
			{
				short num = (short)1088024231;
				short num2 = num;
				num = (short)1289285287;
				switch (num2 == num)
				{
				}
				num = (short)1207894016;
				short num3 = num;
				num = (short)1501691905;
				if (num != 0)
				{
				}
				num = (short)215416832;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ImportCACertificatesPackage;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00009A94 File Offset: 0x00007C94
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 16;
			short num = (short)1370882048;
			switch (num)
			{
			default:
			{
				num = (short)2125070337;
				if (num != 0)
				{
				}
				num = (short)27525120;
				short num2 = num;
				int num3 = 0;
				global::System.Collections.Generic.IEnumerator<string> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)1659502600;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.Server.EntityModel.Package package;
						switch (num4)
						{
						case 0:
							try
							{
								num = (short)1473249294;
								num4 = (int)((global::System.IntPtr)num);
								string text;
								for (;;)
								{
									switch (num4)
									{
									case 0:
									{
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
										global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates item = packageSummary.ToUiModel() as global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates;
										num = (short)727121923;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_4B8;
									case 2:
										goto IL_4D0;
									case 3:
									{
										num = (short)1624865809;
										short num5 = num;
										num = (short)1488550929;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
										{
											num = (short)1516306432;
											if (num != 0)
											{
											}
											bool flag;
											if (flag)
											{
												num = (short)1939603463;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates item;
											base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates>
											{
												item
											});
											break;
										}
										}
										num = (short)177602568;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
										if (packageSummary != null)
										{
											num = (short)813563904;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_4B8;
									}
									case 5:
										if (package.RMFile != null)
										{
											num = (short)1331822604;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_29B;
									case 6:
									{
										if (package.RMFile.Url == null)
										{
											num = (short)1461911561;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										bool flag = false;
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.CheckAndImportBacthPackage(base.JobContainerGuid, package.RMFile.Url, package, text, out flag);
										num = (short)1203109892;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates item;
										base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates>
										{
											item
										});
										num = (short)1065025537;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										goto IL_4B8;
									case 9:
										goto IL_384;
									case 10:
										if (package != null)
										{
											num = (short)1908736013;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_29B;
									case 11:
										package = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AnalysisPackageInfo(text);
										num = (short)2030239754;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 12:
										num = (short)1519124486;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 13:
										num = (short)1609695237;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 14:
										switch (0)
										{
										case 0:
											goto IL_1FD;
										}
										continue;
									}
									IL_1FD:
									if (this.a(text))
									{
										num = (short)1015545867;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
									IL_4B8:
									num = (short)219611138;
									num4 = (int)((global::System.IntPtr)num);
								}
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Certificate_Error_Importing, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Certificate_Error_Importing + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_File0, text));
								IL_29B:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_CpsDidntReturnInfo + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_File0, text));
								IL_384:
								goto IL_29B;
								IL_4D0:
								goto IL_EF;
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
								goto IL_EF;
							}
							goto IL_55D;
							IL_EF:
							num3++;
							base.ReportProgress(num3);
							num = (short)1363410951;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1811939332;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)436862979;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text = enumerator.Current;
							num = (short)1030029318;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)962854917;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_EA;
						case 5:
							goto IL_595;
						case 6:
							if (base.CancellationPending)
							{
								num = (short)1870069761;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_55D;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_D0;
							}
							continue;
						}
						IL_15B:
						num = (short)2012348418;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_D0:
						goto IL_15B;
						IL_55D:
						package = null;
						num = (short)1271726080;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_EA:
					IL_595:;
				}
				finally
				{
					num = (short)163184642;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1287127041;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_5FE;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_5C9;
							}
							continue;
						}
						IL_5C9:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1639710720;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_5FE:;
				}
				return;
			}
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000A0D8 File Offset: 0x000082D8
		public bool ValidateCertificates(string file)
		{
			short num = (short)1076308511;
			short num2 = num;
			num = (short)1655646751;
			switch (num2 == num)
			{
			}
			num = (short)210698240;
			short num3 = num;
			num = (short)182845441;
			if (num != 0)
			{
			}
			num = (short)1401356288;
			if (num != 0)
			{
			}
			return this.a(file);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000A18C File Offset: 0x0000838C
		private bool a(string A_0)
		{
			int a_ = 14;
			short num = (short)178585607;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1332856561;
				short num3 = num;
				num = (short)1744881393;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1006305280;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_1A0;
					case 1:
						if (!global::System.IO.File.ReadAllText(A_0).Contains(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("雒鯔鏖律飚飜跞뗠ꫢꏤ껦ꫨꫪ맬ꫮ", a_)))
						{
							num = (short)316866560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E5;
					case 2:
						if (!global::System.IO.File.ReadAllText(A_0).Contains(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("釒郔郖郘闚﷜鳞ꓠ뇢뇤껦꿨ꋪ껬껮ꗰ뛲", a_)))
						{
							num = (short)940769284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E5;
					case 3:
						return false;
					case 4:
						num = (short)1688469505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_12A;
					case 6:
						if (new global::System.IO.FileInfo(A_0).Length > 10000L)
						{
							num = (short)1339490309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_98;
						}
						continue;
					}
					IL_98:
					num = (short)893648896;
					short num4 = num;
					if (A_0 == null)
					{
						num = (short)436207619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					new global::System.Security.Cryptography.X509Certificates.X509Certificate2().Import(A_0);
					break;
					IL_E5:
					num = (short)819986438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				num = (short)1636171778;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_12A:
			num = (short)1219166209;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Certificate_Invalid_Size, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Certificate_Invalid_Size + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_File0, A_0));
			IL_1A0:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Certificate_Invalid_Format, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Certificate_Invalid_Format + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_File0, A_0));
		}
	}
}
