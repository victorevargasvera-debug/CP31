using System;
using System.Collections.Generic;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200000A RID: 10
	internal abstract class PackageManagementServiceBase : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00003880 File Offset: 0x00001A80
		public PackageManagementServiceBase(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor) : base(serverAccessor)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003894 File Offset: 0x00001A94
		public bool DeletePackages(global::System.Guid? jobContainerGuid, global::Motorola.CommonCPS.Server.EntityModel.Package package, string packageName)
		{
			short num = (short)1387642631;
			short num2 = num;
			num = (short)1761459975;
			switch (num2 == num)
			{
			}
			num = (short)2020671489;
			if (num != 0)
			{
			}
			num = (short)776536064;
			short num3 = num;
			num = (short)2029584384;
			if (num != 0)
			{
			}
			global::System.Guid uuid = package.Uuid;
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			validateEntitySet.RelatedObject = new global::System.Guid?(package.Uuid);
			validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Package;
			global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
			validatedField.Uuid = package.Uuid;
			validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Package;
			validatedField.Timestamp = package.Timestamp;
			validateEntitySet.ValidateEntityList.Add(validatedField);
			global::Motorola.CommonCPS.Server.EntityModel.EntitySummary entitySummary = new global::Motorola.CommonCPS.Server.EntityModel.EntitySummary();
			entitySummary.Uuid = package.Uuid;
			entitySummary.Name = packageName;
			return base.ServerAccessor.DeletePackage(jobContainerGuid.Value, entitySummary, validateEntitySet);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000039CC File Offset: 0x00001BCC
		public global::Motorola.CommonCPS.Server.EntityModel.PackageSummary ImportPCRFwCpPairGroupBatchOp(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Package software)
		{
			short num = (short)1685322047;
			short num2 = num;
			num = (short)686094655;
			switch (num2 == num)
			{
			}
			num = (short)490209281;
			if (num != 0)
			{
			}
			num = (short)530120704;
			short num3 = num;
			num = (short)284688384;
			if (num != 0)
			{
			}
			return base.ServerAccessor.ImportBatchPackage(batchJobContainerUuid, software, (software as global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroup).PackageName);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003A90 File Offset: 0x00001C90
		public virtual global::Motorola.CommonCPS.Server.EntityModel.PackageSummary CheckAndImportBatchAstroFirmware(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> astroFirmwares, string jobDescription, out bool isOverwrite)
		{
			int a_ = 16;
			short num = (short)1300902742;
			short num2 = num;
			num = (short)838939478;
			switch (num2 == num)
			{
			}
			num = (short)71630849;
			if (num != 0)
			{
			}
			num = (short)1616707584;
			short num3 = num;
			num = (short)1917386752;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춦\udca8\ud8aa\ud9ac辮\udeb0\uddb2\ud9b4캶馸캺캼\udabeꗂ꫄뗆꫊뻌믎ꏐ볒ꗖ냘볚뗜ꯞ쇠跢諤郦쟨", a_));
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003B54 File Offset: 0x00001D54
		public global::Motorola.CommonCPS.Server.EntityModel.PackageSummary CheckAndImportBacthPackage(global::System.Guid batchJobContainerUuid, string filePath, global::Motorola.CommonCPS.Server.EntityModel.Package package, string jobDescription, out bool isOverwrite)
		{
			short num = (short)1654390784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				global::Motorola.CommonCPS.Server.EntityModel.Package package2;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						num = (short)1557911065;
						short num3 = num;
						num = (short)1684657689;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3A8;
						default:
							goto IL_25D;
						}
						break;
					}
					case 1:
						goto IL_3A8;
					case 2:
						goto IL_ED;
					case 3:
						num = (short)785842186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)135659521;
						if (num != 0)
						{
						}
						if (!string.IsNullOrEmpty(filePath))
						{
							num = (short)1074397197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FA;
					case 5:
					{
						global::System.Guid uuid = package2.RMFile.Uuid;
						num = (short)441384971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if ((package2 = base.ServerAccessor.PackageExist(package)) == null)
						{
							num = (short)973275139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1692860417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_34D;
					case 8:
						num = (short)1993932809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (package2.RMFile != null)
						{
							num = (short)652738565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B1;
					case 10:
						if (!string.IsNullOrEmpty(filePath))
						{
							num = (short)881983488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FA;
					case 11:
						goto IL_B1;
					case 12:
					{
						if (package is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack)
						{
							num = (short)1454833666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
						{
							JobDescription = jobDescription,
							ErrorCode = new int?(2186),
							ErrorMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_Duplicate,
							JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED,
							JobContainerUuid = new global::System.Guid?(batchJobContainerUuid)
						};
						global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddBatchOperationJob(job);
						num = (short)157351943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_156;
					}
					goto IL_66;
					IL_B1:
					num = (short)1177813004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A8:
					if (package2.RMFile != null)
					{
						num = (short)1113980936;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)777256964;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_ED:
				global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile = package2.RMFile;
				package.FileUuid = new global::System.Guid?(rmfile.Uuid);
				package.RMFile = rmfile;
				package.ModifiedDate = new global::System.DateTime?(global::System.DateTime.UtcNow);
				isOverwrite = true;
				return base.ServerAccessor.ImportBatchPackage(batchJobContainerUuid, package, jobDescription);
				IL_156:
				global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile2 = base.AddFileToServer(filePath);
				package.FileUuid = new global::System.Guid?(rmfile2.Uuid);
				package.RMFile = rmfile2;
				package2.ModifiedDate = new global::System.DateTime?(global::System.DateTime.UtcNow);
				isOverwrite = true;
				return base.ServerAccessor.ImportBatchPackage(batchJobContainerUuid, package, jobDescription);
				IL_25D:
				num = (short)1662976000;
				if (num != 0)
				{
				}
				num = (short)1747124224;
				short num4 = num;
				global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile3 = base.AddFileToServer(filePath);
				package.FileUuid = new global::System.Guid?(rmfile3.Uuid);
				package.RMFile = rmfile3;
				global::System.DateTime? dateTime = new global::System.DateTime?(global::System.DateTime.UtcNow);
				package.ModifiedDate = dateTime;
				package.CreatedDate = dateTime;
				return base.ServerAccessor.ImportBatchPackage(batchJobContainerUuid, package, jobDescription);
				IL_34D:
				IL_3FA:
				return null;
				IL_66:
				isOverwrite = false;
				num = (short)870383622;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003F5C File Offset: 0x0000215C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> GetLanguagePackInfos()
		{
			short num = (short)1582783816;
			short num2 = num;
			num = (short)1453546824;
			switch (num2 == num)
			{
			}
			num = (short)843382785;
			if (num != 0)
			{
			}
			num = (short)344195072;
			short num3 = num;
			num = (short)1252065280;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().LanguagePackInfos();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004010 File Offset: 0x00002210
		public string GetVaInstallationPath()
		{
			short num = (short)315359232;
			short num2 = num;
			num = (short)1515831907;
			short num3 = num;
			num = (short)510181987;
			switch (num3 == num)
			{
			}
			num = (short)399376385;
			if (num != 0)
			{
			}
			num = (short)1494024192;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().GetVaInstallationPath();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000040C4 File Offset: 0x000022C4
		public string GetTTSInstallationPath()
		{
			short num = (short)2072182784;
			short num2 = num;
			num = (short)165958001;
			short num3 = num;
			num = (short)493638001;
			switch (num3 == num)
			{
			}
			num = (short)73203713;
			if (num != 0)
			{
			}
			num = (short)495583232;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().GetTTSInstallationPath();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004178 File Offset: 0x00002378
		public string GetCpsVaImportPath()
		{
			short num = (short)76873728;
			short num2 = num;
			num = (short)1349677419;
			short num3 = num;
			num = (short)1725788523;
			switch (num3 == num)
			{
			}
			num = (short)639762433;
			if (num != 0)
			{
			}
			num = (short)718405632;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004228 File Offset: 0x00002428
		public global::Motorola.CommonCPS.Server.EntityModel.PackageSummary EditPackageColumn(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary)
		{
			short num = (short)705560576;
			short num2 = num;
			num = (short)736980932;
			short num3 = num;
			num = (short)1539010500;
			switch (num3 == num)
			{
			}
			num = (short)1839857665;
			if (num != 0)
			{
			}
			num = (short)1648754688;
			if (num != 0)
			{
			}
			return base.ServerAccessor.UpdatePackage(summary, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageColumns.Comments);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000042DC File Offset: 0x000024DC
		public global::Motorola.CommonCPS.Server.EntityModel.Package CheckPackageExist(global::Motorola.CommonCPS.Server.EntityModel.Package package)
		{
			short num = (short)807403520;
			short num2 = num;
			num = (short)1010325078;
			short num3 = num;
			num = (short)527193686;
			switch (num3 == num)
			{
			}
			num = (short)794165249;
			if (num != 0)
			{
			}
			num = (short)411435008;
			if (num != 0)
			{
			}
			return base.ServerAccessor.PackageExist(package);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004390 File Offset: 0x00002590
		public global::Motorola.CommonCPS.Server.EntityModel.Package GetPackage(global::System.Guid packageUuid)
		{
			short num = (short)1379598336;
			short num2 = num;
			num = (short)1822383343;
			short num3 = num;
			num = (short)1959091439;
			switch (num3 == num)
			{
			}
			num = (short)1704329217;
			if (num != 0)
			{
			}
			num = (short)302383104;
			if (num != 0)
			{
			}
			return base.ServerAccessor.GetPackage(packageUuid);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000444C File Offset: 0x0000264C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> ListGeneralPackages(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, string modelNumber = null)
		{
			short num = (short)431816704;
			short num2 = num;
			num = (short)2128822235;
			short num3 = num;
			num = (short)1163476955;
			switch (num3 == num)
			{
			}
			num = (short)1646460928;
			if (num != 0)
			{
			}
			num = (short)1893859329;
			if (num != 0)
			{
			}
			return base.ServerAccessor.ListPackage(packageType, modelNumber);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004504 File Offset: 0x00002704
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> GetPackageSummaries(int startIndex, int length, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, int? region)
		{
			short num = (short)1758199808;
			short num2 = num;
			num = (short)1889859974;
			short num3 = num;
			num = (short)60094854;
			switch (num3 == num)
			{
			}
			num = (short)1757609985;
			if (num != 0)
			{
			}
			num = (short)1357709312;
			if (num != 0)
			{
			}
			return base.ServerAccessor.GetPackageSummaries(startIndex, length, type, region);
		}
	}
}
