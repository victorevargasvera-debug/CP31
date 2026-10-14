using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000052 RID: 82
	internal class ASTROFirmwarePackageService : global::Motorola.CommonCPS.RadioManagement.SharedServices.PackageManagementServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROFirmwarePackageService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x0600069A RID: 1690 RVA: 0x0003E75C File Offset: 0x0003C95C
		public ASTROFirmwarePackageService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor) : base(serverAccessor)
		{
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0003E770 File Offset: 0x0003C970
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.EntityModel.Package> LoadAvailablePackages(string model, string maxVer, bool isFreon, bool isEqual = true, string codeplugVersion = null)
		{
			short num = (short)1267646821;
			short num2 = num;
			num = (short)1129890149;
			global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.EntityModel.Package> observableCollection;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return observableCollection;
			case 1:
				break;
			default:
			{
				num = (short)522256384;
				short num3 = num;
				break;
			}
			}
			num = (short)147652608;
			if (num != 0)
			{
			}
			observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.EntityModel.Package>();
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>.Enumerator enumerator = base.ServerAccessor.GetASTROPackagesByTargetModelVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Firmware, model, maxVer, isFreon, isEqual).ToList<global::Motorola.CommonCPS.Server.EntityModel.Package>().GetEnumerator())
			{
				num = (short)1793785856;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_DA;
						}
						continue;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)636813316;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.Package package = enumerator.Current;
						num = (short)2025324547;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Package package;
						observableCollection.Add(package);
						num = (short)750452742;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Package package;
						if (global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().CheckAstroUpgradeFWIsSupported((package as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware).PackageVersion, codeplugVersion))
						{
							num = (short)544473090;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)2133917701;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_19E;
					}
					IL_12A:
					num = (short)290652161;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_DA:
					goto IL_12A;
				}
				IL_19E:
				num = (short)988610561;
				if (num != 0)
				{
				}
			}
			return observableCollection;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0003E970 File Offset: 0x0003CB70
		public override global::Motorola.CommonCPS.Server.EntityModel.PackageSummary CheckAndImportBatchAstroFirmware(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> astroFirmwares, string jobDescription, out bool isOverwrite)
		{
			short num = (short)1037893632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (astroFirmwares != null)
						{
							num = (short)53411843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61E;
					case 1:
						try
						{
							num = (short)958791680;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_EF;
								case 1:
									goto IL_199;
								case 2:
									num = (short)1926496257;
									if (num != 0)
									{
									}
									num = (short)1848246277;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1374683138;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware software = enumerator.Current;
									num = (short)1545469956;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									num = (short)2069404413;
									short num3 = num;
									num = (short)1466145533;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_EF;
									default:
									{
										num = (short)1942355968;
										if (num != 0)
										{
										}
										global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware software;
										if (base.ServerAccessor.PackageExist(software) != null)
										{
											num = (short)1186529286;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								case 5:
									goto IL_252;
								case 6:
								{
									bool flag = true;
									num = (short)984219649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_11C;
								IL_EF:
								switch (0)
								{
								case 0:
									IL_11C:
									goto IL_11E;
								}
								continue;
								IL_11E:
								num = (short)305528835;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_199:
							IL_252:
							goto IL_5E2;
						}
						finally
						{
							num = (short)499122176;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_289;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1607663618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2C1;
								}
								IL_289:
								if (enumerator == null)
								{
									break;
								}
								num = (short)83558401;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2C1:;
						}
						goto IL_2C4;
						IL_5E2:
						num = (short)353239046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)1552154628;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware;
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile = base.AddFileToServer(astrofirmware.RMFile.Url);
									astrofirmware.FileUuid = new global::System.Guid?(rmfile.Uuid);
									astrofirmware.RMFile = rmfile;
									num = (short)1832976391;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									if (!string.IsNullOrEmpty(astrofirmware.RMFile.Url))
									{
										num = (short)1066074112;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4BA;
								case 2:
									goto IL_508;
								case 3:
								{
									bool? isSubFirmware;
									bool flag2;
									if (isSubFirmware.GetValueOrDefault() == flag2 & isSubFirmware != null)
									{
										num = (short)1432879109;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4BA;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_34F;
									}
									continue;
								case 5:
									num = (short)797900808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1575550977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_4BA;
								case 8:
									if (astrofirmware.RMFile != null)
									{
										num = (short)1997275142;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4BA;
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1846083595;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									astrofirmware = enumerator.Current;
									bool? isSubFirmware = astrofirmware.IsSubFirmware;
									bool flag2 = true;
									num = (short)951189507;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)1042481154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_47C:
								num = (short)938278921;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_34F:
								goto IL_47C;
								IL_4BA:
								astrofirmware.CreatedDate = (astrofirmware.ModifiedDate = new global::System.DateTime?(global::System.DateTime.UtcNow));
								num = (short)1240793098;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_508:
							goto IL_2C4;
						}
						finally
						{
							num = (short)1079312384;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_541;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)520421378;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_577;
								}
								IL_541:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1742667777;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_577:;
						}
						goto IL_57A;
					case 3:
					{
						bool flag = false;
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerator = astroFirmwares.GetEnumerator();
						num = (short)732823553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_5E0;
					case 5:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> enumerator = astroFirmwares.GetEnumerator();
						num = (short)361627650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						bool flag;
						if (!flag)
						{
							num = (short)995950597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57A;
					}
					}
					goto IL_4A;
					IL_57A:
					global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
					{
						JobDescription = jobDescription,
						ErrorCode = new int?(2186),
						ErrorMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_Duplicate,
						JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED,
						JobContainerUuid = new global::System.Guid?(batchJobContainerUuid)
					};
					global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddBatchOperationJob(job);
					num = (short)276430852;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2C4:
				return base.ServerAccessor.ImportBatchAstroFirmware(batchJobContainerUuid, astroFirmwares, jobDescription);
				IL_5E0:
				IL_61E:
				return null;
				IL_4A:
				num = (short)1043791872;
				short num4 = num;
				isOverwrite = false;
				num = (short)2049769472;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
