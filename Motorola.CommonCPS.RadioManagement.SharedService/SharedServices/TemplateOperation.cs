using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ASK.Interface;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.GenericModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000018 RID: 24
	internal class TemplateOperation : global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation, global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioFeatureOperation
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00005CAC File Offset: 0x00003EAC
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00005D60 File Offset: 0x00003F60
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.SaveCodeplugToRMCDelegate SaveCodeplugDelegate
		{
			get
			{
				short num = (short)2124546048;
				short num2 = num;
				num = (short)359712521;
				short num3 = num;
				num = (short)1198638857;
				switch (num3 == num)
				{
				}
				num = (short)1554644993;
				if (num != 0)
				{
				}
				num = (short)402587648;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().SaveCodeplugDelegate;
			}
			set
			{
				short num = (short)1429864448;
				short num2 = num;
				num = (short)588531249;
				short num3 = num;
				num = (short)1621444145;
				switch (num3 == num)
				{
				}
				num = (short)420151297;
				if (num != 0)
				{
				}
				num = (short)494600192;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().SaveCodeplugDelegate = value;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005E14 File Offset: 0x00004014
		public global::Motorola.CommonCPS.Server.EntityModel.Radio ParseAchiveFile(string filePath, bool IgnorePassword, string password, out global::System.Collections.Generic.Dictionary<int, int> optionCount)
		{
			short num = (short)1416036352;
			short num2 = num;
			num = (short)1558735151;
			short num3 = num;
			num = (short)396912943;
			switch (num3 == num)
			{
			}
			num = (short)762380289;
			if (num != 0)
			{
			}
			num = (short)2092367872;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs openFileEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs(filePath, IgnorePassword, password);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().SendImportDeviceEvent(openFileEventArgs);
			optionCount = null;
			return openFileEventArgs.ImportingRadio;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005EDC File Offset: 0x000040DC
		public virtual byte[] ConvertArchiveToXpbaByteArray(string filePath)
		{
			short num = (short)141819904;
			short num2 = num;
			num = (short)139359927;
			short num3 = num;
			num = (short)1886877367;
			switch (num3 == num)
			{
			}
			num = (short)504758272;
			if (num != 0)
			{
			}
			num = (short)609943553;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005F88 File Offset: 0x00004188
		public void EditTemplateByCPS(byte[] fileContent, global::Motorola.CommonCPS.Server.EntityModel.Radio rd, global::Motorola.CommonCPS.Server.EntityModel.Template temp)
		{
			short num = (short)1956118528;
			short num2 = num;
			num = (short)476348453;
			short num3 = num;
			num = (short)1037074469;
			switch (num3 == num)
			{
			}
			num = (short)1236205568;
			if (num != 0)
			{
			}
			num = (short)320995329;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().SendEditTemplateEvent(fileContent, rd, temp);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00006040 File Offset: 0x00004240
		public global::Motorola.CommonCPS.Server.EntityModel.Template UpgradeTemplateByFeatures(global::Motorola.CommonCPS.Server.EntityModel.Template template, string sourceCFS, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> radioLicenses, out bool needUpgradeFirmware)
		{
			short num = (short)465305600;
			short num2 = num;
			num = (short)582557901;
			short num3 = num;
			num = (short)1371218125;
			switch (num3 == num)
			{
			}
			num = (short)763756544;
			if (num != 0)
			{
			}
			num = (short)1306394625;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().UpgradeTemplateByFeatures(template, sourceCFS, radioLicenses, out needUpgradeFirmware);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000060F8 File Offset: 0x000042F8
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> RadioCfsChangesInUpgrade(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug, global::Motorola.CommonCPS.Server.EntityModel.Template template)
		{
			short num = (short)187826176;
			short num2 = num;
			num = (short)641641536;
			short num3 = num;
			num = (short)723758144;
			switch (num3 == num)
			{
			}
			num = (short)1946091520;
			if (num != 0)
			{
			}
			num = (short)470286337;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().RadioCfsChangesInUpgrade(radio, codeplug, template);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000061AC File Offset: 0x000043AC
		public void ValidateAstroCompatibility(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug targetCP, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate sourceTempalte, string targetModelnumber)
		{
			short num = (short)1818777027;
			short num2 = num;
			num = (short)684086723;
			switch (num2 == num)
			{
			}
			num = (short)1354235905;
			if (num != 0)
			{
			}
			num = (short)1503199232;
			if (num != 0)
			{
			}
			num = (short)1178140672;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().ValidateAstroCompatibility(targetCP, sourceTempalte, targetModelnumber);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00006264 File Offset: 0x00004464
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs AstroUpgradeCodeplug(byte[] flashCode, string iButtonSerialNumber, string modelNumber, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate sourceTemplate, byte[] codeplugFileContent, string radioHostVersion, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware firmware, bool brefresh = false, global::ASK.Interface.ISystemKeyData systemID = null)
		{
			short num = (short)575430867;
			short num2 = num;
			num = (short)923164883;
			switch (num2 == num)
			{
			}
			num = (short)2046296065;
			if (num != 0)
			{
			}
			num = (short)769982464;
			if (num != 0)
			{
			}
			num = (short)613875712;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroUpgradeCodeplug(flashCode, iButtonSerialNumber, modelNumber, sourceTemplate, codeplugFileContent, radioHostVersion, firmware, brefresh, systemID);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00006328 File Offset: 0x00004528
		public string DownloadPackage(global::System.Guid packageUuids)
		{
			short num = (short)2103938971;
			short num2 = num;
			num = (short)1914081179;
			switch (num2 == num)
			{
			}
			num = (short)97910785;
			if (num != 0)
			{
			}
			num = (short)621084672;
			if (num != 0)
			{
			}
			num = (short)170524672;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().DownloadPackage(packageUuids);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000063DC File Offset: 0x000045DC
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> GetPackage(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType)
		{
			short num = (short)265148432;
			short num2 = num;
			num = (short)1177737232;
			switch (num2 == num)
			{
			}
			num = (short)185663489;
			if (num != 0)
			{
			}
			num = (short)622264320;
			if (num != 0)
			{
			}
			num = (short)424673280;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().GetPackage(packageType);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00006494 File Offset: 0x00004694
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> GetASTROPackagesByCompatibleVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, string compatibleVersion)
		{
			short num = (short)138669593;
			short num2 = num;
			num = (short)1918889497;
			switch (num2 == num)
			{
			}
			num = (short)619708416;
			if (num != 0)
			{
			}
			num = (short)1207894017;
			if (num != 0)
			{
			}
			num = (short)467992576;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().GetASTROPackagesByCompatibleVersion(packageType, compatibleVersion);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00006548 File Offset: 0x00004748
		public global::Motorola.CommonCPS.Server.EntityModel.Package UploadVAPackage(global::Motorola.CommonCPS.Server.EntityModel.Package package)
		{
			short num = (short)1002902366;
			short num2 = num;
			num = (short)553456478;
			switch (num2 == num)
			{
			}
			num = (short)1135738881;
			if (num != 0)
			{
			}
			num = (short)866385920;
			if (num != 0)
			{
			}
			num = (short)314507264;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().UploadVAPackage(package);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000065FC File Offset: 0x000047FC
		public global::Motorola.CommonCPS.Server.EntityModel.Package UploadCACertificatePackage(global::Motorola.CommonCPS.Server.EntityModel.Package package)
		{
			short num = (short)1105453192;
			short num2 = num;
			num = (short)730587272;
			switch (num2 == num)
			{
			}
			num = (short)1316487169;
			if (num != 0)
			{
			}
			num = (short)711589888;
			if (num != 0)
			{
			}
			num = (short)1984167936;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().UploadCACertificatePackage(package);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000066B4 File Offset: 0x000048B4
		public global::Motorola.CommonCPS.Server.EntityModel.Package UploadDVRSFilePackage(global::Motorola.CommonCPS.Server.EntityModel.Package package)
		{
			short num = (short)1274301436;
			short num2 = num;
			num = (short)1984842748;
			switch (num2 == num)
			{
			}
			num = (short)94240768;
			if (num != 0)
			{
			}
			num = (short)2011693057;
			if (num != 0)
			{
			}
			num = (short)518324224;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().UploadDVRSFilePackage(package);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000676C File Offset: 0x0000496C
		public bool CheckAstroUpgradeWithLanugagePackIsSupported(string radioFWVersion, string cvnFWVersion)
		{
			short num = (short)1942038264;
			short num2 = num;
			num = (short)1967597304;
			switch (num2 == num)
			{
			}
			num = (short)494927873;
			if (num != 0)
			{
			}
			num = (short)1381367808;
			if (num != 0)
			{
			}
			num = (short)1287389184;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().CheckAstroUpgradeWithLanugagePackIsSupported(radioFWVersion, cvnFWVersion);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00006820 File Offset: 0x00004A20
		public bool CheckIsSupportedLanguagePack(string fwVersion, int? templateLanguageIndex)
		{
			short num = (short)1445692664;
			short num2 = num;
			num = (short)576685304;
			switch (num2 == num)
			{
			}
			num = (short)175374337;
			if (num != 0)
			{
			}
			num = (short)1426063360;
			if (num != 0)
			{
			}
			num = (short)2004877312;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().CheckIsSupportedLanguagePack(fwVersion, templateLanguageIndex);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000068D8 File Offset: 0x00004AD8
		public string AstroDecodeLanguageIndexToLPID(int? languageIndex)
		{
			short num = (short)1679158661;
			short num2 = num;
			num = (short)80145797;
			switch (num2 == num)
			{
			}
			num = (short)2079784960;
			if (num != 0)
			{
			}
			num = (short)1707409409;
			if (num != 0)
			{
			}
			num = (short)149553152;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroDecodeLanguageIndexToLPID(languageIndex);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000698C File Offset: 0x00004B8C
		public global::Motorola.CommonCPS.Server.EntityModel.Template ParseTemplateFile(string filePath, string password, bool ignorPwdValidation = false)
		{
			short num = (short)1914057224;
			short num2 = num;
			num = (short)1982804488;
			switch (num2 == num)
			{
			}
			num = (short)668925952;
			if (num != 0)
			{
			}
			num = (short)660144129;
			if (num != 0)
			{
			}
			num = (short)1547567104;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs openFileEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs(filePath, ignorPwdValidation, password);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().SendImportTemplateEvent(openFileEventArgs);
			return openFileEventArgs.ImportingTemplate;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00006A4C File Offset: 0x00004C4C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> GetVAPackages(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug)
		{
			short num = (short)51183619;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_50;
				case 1:
					if (codeplug is global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug)
					{
						num = (short)1708785666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15C;
				case 2:
					goto IL_115;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				}
				IL_34:
				if (codeplug is global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)
				{
					num = (short)8978432;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1245052929;
					if (num != 0)
					{
					}
					num = (short)924991237;
					short num3 = num;
					num = (short)1875066629;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11A;
					default:
						num = (short)243728384;
						if (num != 0)
						{
						}
						num = (short)36896769;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_50:
			goto IL_11A;
			IL_115:
			return (codeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate).PCRVoiceAnnouncements.ToList<global::Motorola.CommonCPS.Server.EntityModel.Package>();
			IL_11A:
			num = (short)646512640;
			short num4 = num;
			return (codeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate).ASTROVoiceAnnouncements.ToList<global::Motorola.CommonCPS.Server.EntityModel.Package>();
			IL_15C:
			return null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00006BB8 File Offset: 0x00004DB8
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> GetCACertificatePackages(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug)
		{
			short num;
			if (codeplug is global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)
			{
				num = (short)886230493;
				short num2 = num;
				num = (short)1357237725;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2040987648;
					short num3 = num;
					num = (short)876478464;
					if (num != 0)
					{
					}
					break;
				}
				}
				return (codeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate).ASTROCACertificates.ToList<global::Motorola.CommonCPS.Server.EntityModel.Package>();
			}
			num = (short)1720909825;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00006C84 File Offset: 0x00004E84
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> GetDVRSFilePackages(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug)
		{
			if (codeplug is global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)
			{
				short num = (short)1853185484;
				short num2 = num;
				num = (short)257711564;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)415956992;
					short num3 = num;
					num = (short)1216872448;
					if (num != 0)
					{
					}
					num = (short)29818881;
					if (num != 0)
					{
					}
					break;
				}
				}
				return (codeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate).ASTRODVRSFiles.ToList<global::Motorola.CommonCPS.Server.EntityModel.Package>();
			}
			return null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00006D50 File Offset: 0x00004F50
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> GetTTSPackages(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug)
		{
			short num = (short)1205596799;
			short num2 = num;
			num = (short)663810687;
			switch (num2 == num)
			{
			}
			num = (short)1158938625;
			if (num != 0)
			{
			}
			num = (short)758120448;
			if (num != 0)
			{
			}
			num = (short)917569536;
			short num3 = num;
			return (codeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate).PCRTextToSpeechs.ToList<global::Motorola.CommonCPS.Server.EntityModel.Package>();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00006E10 File Offset: 0x00005010
		public void ExportDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, string filePathName, string fieldError)
		{
			short num = (short)2130968576;
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
				global::System.Guid? fileUuid;
				for (;;)
				{
					IL_27:
					bool flag;
					switch (num2)
					{
					case 0:
						flag = (fileUuid != null);
						goto IL_21C;
					case 1:
						flag = false;
						goto IL_21C;
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Template template = radio.CurrentCodeplug.Template;
						if (template == null)
						{
							num = (short)1160052736;
							short num3 = num;
							num = (short)902299649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						fileUuid = template.FileUuid;
						num = (short)2080702464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false);
						fileUuid = radio.CurrentCodeplug.Template.FileUuid;
						byte[] fileContent = instance.GetFileContent(fileUuid.Value);
						global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().SendExportDeviceFromTemplateEvent(fileContent, filePathName, radio);
						num = (short)196804612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return;
					case 5:
					{
						num = (short)1062862849;
						if (num != 0)
						{
						}
						num = (short)1150780876;
						short num4 = num;
						num = (short)207979980;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)2002124800;
							if (num != 0)
							{
							}
							if (fileUuid != null)
							{
								num = (short)600178694;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1258160130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_FE;
					}
					goto IL_4A;
					IL_21C:
					if (!flag)
					{
						goto IL_238;
					}
					num = (short)203030531;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FE:
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false);
				fileUuid = radio.CurrentCodeplug.FileUuid;
				byte[] fileContent2 = instance2.GetFileContent(fileUuid.Value);
				string firmwareVersion = radio.CurrentCodeplug.FirmwareVersion;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().SendExportDeviceEvent(fileContent2, firmwareVersion, filePathName, radio);
				return;
				IL_238:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_FileContentMissing);
				IL_4A:
				fileUuid = radio.CurrentCodeplug.FileUuid;
				num = (short)262799365;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00007060 File Offset: 0x00005260
		public void ExportDVRS(global::Motorola.CommonCPS.Server.EntityModel.Radio rd, string filePathName)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)894042113;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (apxcodeplug.Template != null)
					{
						goto IL_156;
					}
					goto IL_D2;
				case 2:
					goto IL_16D;
				case 3:
				{
					if (apxcodeplug == null)
					{
						goto IL_16F;
					}
					num2 = (short)1424890540;
					short num3 = num2;
					num2 = (short)1709709996;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_156;
					default:
						num2 = (short)16056320;
						if (num2 != 0)
						{
						}
						num2 = (short)220200960;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
				IL_156:
				num2 = (short)1636958210;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D2:
			num2 = (short)1272446976;
			short num4 = num2;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_FileContentMissing);
			IL_16D:
			byte[] fileContent = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetFileContent(apxcodeplug.Template.FileUuid.Value);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().SendExportDVRSEvent(fileContent, filePathName);
			return;
			IL_16F:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_CODEPLUG_NOT_FOUND, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportCodeplug_Error, null);
			IL_20:
			num2 = (short)2033319937;
			if (num2 != 0)
			{
			}
			apxcodeplug = (rd.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
			num2 = (short)102694915;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000071EC File Offset: 0x000053EC
		public void ExportDeviceToMNISXML(global::Motorola.CommonCPS.Server.EntityModel.Radio rd, string filePathName, string fieldError)
		{
			short num = (short)533098512;
			short num2 = num;
			num = (short)1839165456;
			switch (num2 == num)
			{
			}
			num = (short)1673068544;
			if (num != 0)
			{
			}
			num = (short)1555890177;
			if (num != 0)
			{
			}
			num = (short)1659699200;
			short num3 = num;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00007294 File Offset: 0x00005494
		public void ValidateAstroCompatibility(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug targetCP, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug sourceCP, string targetModelnumber)
		{
			short num = (short)1284767746;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					for (;;)
					{
						this.ValidateAstroCompatibility(targetCP, sourceCP.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate, targetModelnumber);
						num = (short)587497806;
						short num3 = num;
						num = (short)1327923534;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_C0;
						}
					}
					IL_C0:
					num = (short)98828288;
					if (num != 0)
					{
					}
					num = (short)1398341632;
					short num4 = num;
					num = (short)1684602881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (sourceCP.Template == null)
				{
					break;
				}
				num = (short)626130945;
				if (num != 0)
				{
				}
				num = (short)1254817792;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000073B8 File Offset: 0x000055B8
		public void ValidateAstroWriting(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio, bool enableWritingProtect, int transportPreference, bool isWriteProtected, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP)
		{
			short num = (short)2140641699;
			short num2 = num;
			num = (short)1397463459;
			switch (num2 == num)
			{
			}
			num = (short)1791164417;
			if (num != 0)
			{
			}
			num = (short)793837568;
			if (num != 0)
			{
			}
			num = (short)85262336;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().ValidateAstroWriting(radio, enableWritingProtect, transportPreference, isWriteProtected, isRestoreJob, out updatedCP);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00007474 File Offset: 0x00005674
		public bool CheckPcrLanguagePackCompatible(global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily languagePackFamily, string languagePackId, string codeplugVersion)
		{
			short num = (short)1890648065;
			if (num != 0)
			{
			}
			num = (short)2028359893;
			short num2 = num;
			num = (short)2010534101;
			switch (num2 == num)
			{
			}
			num = (short)1103626240;
			if (num != 0)
			{
			}
			num = (short)1871970304;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().CheckPcrLanguagePackCompatible(languagePackFamily, languagePackId, codeplugVersion);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000752C File Offset: 0x0000572C
		public string AstroPINPasswordConvert(string source, bool encrypt)
		{
			short num = (short)799261083;
			short num2 = num;
			num = (short)414499227;
			switch (num2 == num)
			{
			}
			num = (short)1126301696;
			if (num != 0)
			{
			}
			num = (short)1508835329;
			if (num != 0)
			{
			}
			num = (short)115474432;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroPINPasswordConvert(source, encrypt);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000075E4 File Offset: 0x000057E4
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.FlashKeyInfo ReadFlashKey(string OldModelNumber, byte[] OldFlashCode)
		{
			short num = (short)1140858915;
			short num2 = num;
			num = (short)1012670499;
			switch (num2 == num)
			{
			}
			num = (short)348323840;
			if (num != 0)
			{
			}
			num = (short)1640235009;
			if (num != 0)
			{
			}
			num = (short)970129408;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().ReadFlashKey(OldModelNumber, OldFlashCode);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000769C File Offset: 0x0000589C
		public bool ValidateFlashKey(string OldModelNumber, byte[] OldFlashCode)
		{
			short num = (short)1627378818;
			short num2 = num;
			num = (short)902812802;
			switch (num2 == num)
			{
			}
			num = (short)1677066241;
			if (num != 0)
			{
			}
			num = (short)55967744;
			if (num != 0)
			{
			}
			num = (short)1074921472;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().ValidateFlashKey(OldModelNumber, OldFlashCode);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007750 File Offset: 0x00005950
		public void AstroReleaseFlashKey()
		{
			short num = (short)1121904274;
			short num2 = num;
			num = (short)1295378066;
			switch (num2 == num)
			{
			}
			num = (short)564264960;
			if (num != 0)
			{
			}
			num = (short)1023606785;
			if (num != 0)
			{
			}
			num = (short)1309671424;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroReleaseFlashKey();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00007800 File Offset: 0x00005A00
		public void DecreaseFlashKeyCount(string oldModelNumber, byte[] oldFlashCode, int decreaseCount)
		{
			short num = (short)888893947;
			short num2 = num;
			num = (short)824603131;
			switch (num2 == num)
			{
			}
			num = (short)789446657;
			if (num != 0)
			{
			}
			num = (short)109445120;
			if (num != 0)
			{
			}
			num = (short)1859911680;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().DecreaseFlashKeyCount(oldModelNumber, oldFlashCode, decreaseCount);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000078B4 File Offset: 0x00005AB4
		public string AstroDecodeFlashCode(byte[] flashCode)
		{
			short num = (short)92336807;
			short num2 = num;
			num = (short)646574759;
			switch (num2 == num)
			{
			}
			num = (short)1756430336;
			if (num != 0)
			{
			}
			num = (short)75759617;
			if (num != 0)
			{
			}
			num = (short)1246887936;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroDecodeFlashCode(flashCode);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007968 File Offset: 0x00005B68
		public byte[] AstroEncodeFlashCode(string flashCode)
		{
			short num = (short)89280515;
			short num2 = num;
			num = (short)788942851;
			switch (num2 == num)
			{
			}
			num = (short)866975744;
			if (num != 0)
			{
			}
			num = (short)772341761;
			if (num != 0)
			{
			}
			num = (short)842727424;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroEncodeFlashCode(flashCode);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007A1C File Offset: 0x00005C1C
		public bool CheckAstroUpgradeFWIsSupported(string cvnFWVersion, string codeplugVersion = null)
		{
			short num = (short)251960077;
			short num2 = num;
			num = (short)1291098893;
			switch (num2 == num)
			{
			}
			num = (short)227606529;
			if (num != 0)
			{
			}
			num = (short)321847296;
			if (num != 0)
			{
			}
			num = (short)823656448;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().CheckAstroUpgradeFWIsSupported(cvnFWVersion, null);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00007AD4 File Offset: 0x00005CD4
		public bool CheckAstroFWIsSupportedCurrentLanguagePack(string fwVersion, string lpCompatibleVerion, int? templateLanguageIndex)
		{
			short num = (short)832034697;
			short num2 = num;
			num = (short)1251334025;
			switch (num2 == num)
			{
			}
			num = (short)746586113;
			if (num != 0)
			{
			}
			num = (short)2092105728;
			if (num != 0)
			{
			}
			num = (short)572653568;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().CheckAstroFWIsSupportedCurrentLanguagePack(fwVersion, lpCompatibleVerion, templateLanguageIndex);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00007B8C File Offset: 0x00005D8C
		public bool AnslysisPCRModelNumber(string modelNumber)
		{
			short num = (short)1411751451;
			short num2 = num;
			num = (short)941334043;
			switch (num2 == num)
			{
			}
			num = (short)1075970049;
			if (num != 0)
			{
			}
			num = (short)1385299968;
			if (num != 0)
			{
			}
			num = (short)1368653824;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AnslysisPCRModelNumber(modelNumber);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00007C40 File Offset: 0x00005E40
		public virtual global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Package> AnalysisListPackageInfo(string filePath)
		{
			short num = (short)303962948;
			short num2 = num;
			num = (short)1356864324;
			switch (num2 == num)
			{
			}
			num = (short)333840385;
			if (num != 0)
			{
			}
			num = (short)662306816;
			if (num != 0)
			{
			}
			num = (short)761397248;
			short num3 = num;
			return new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00007CEC File Offset: 0x00005EEC
		public global::Motorola.CommonCPS.Server.EntityModel.Package AnalysisPackageInfo(string filePath)
		{
			short num = (short)436993692;
			short num2 = num;
			num = (short)1901723292;
			switch (num2 == num)
			{
			}
			num = (short)502202369;
			if (num != 0)
			{
			}
			num = (short)388104192;
			if (num != 0)
			{
			}
			num = (short)714932224;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AnalysisPackageInfo(filePath);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00007DA0 File Offset: 0x00005FA0
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> LanguagePackInfos()
		{
			short num = (short)1711191691;
			short num2 = num;
			num = (short)1219278475;
			switch (num2 == num)
			{
			}
			num = (short)281870336;
			if (num != 0)
			{
			}
			num = (short)310378497;
			if (num != 0)
			{
			}
			num = (short)1664155648;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().LanguagePackInfos();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00007E58 File Offset: 0x00006058
		public string GetVaInstallationPath()
		{
			short num = (short)193788366;
			short num2 = num;
			num = (short)1783101902;
			switch (num2 == num)
			{
			}
			num = (short)568852481;
			if (num != 0)
			{
			}
			num = (short)141426688;
			if (num != 0)
			{
			}
			num = (short)1000931328;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().GetVaInstallationPath();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00007F0C File Offset: 0x0000610C
		public string GetTTSInstallationPath()
		{
			short num = (short)485425153;
			if (num != 0)
			{
			}
			num = (short)87110448;
			short num2 = num;
			num = (short)228406064;
			switch (num2 == num)
			{
			}
			num = (short)1655570432;
			if (num != 0)
			{
			}
			num = (short)2131361792;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().GetTTSInstallationPath();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00007FC0 File Offset: 0x000061C0
		public string UpdatePcrFwDescription(global::System.Collections.Generic.Dictionary<string, string> MapForDescription, string PcrFwDescription)
		{
			short num = (short)1392074774;
			short num2 = num;
			num = (short)1132421142;
			switch (num2 == num)
			{
			}
			num = (short)509083649;
			if (num != 0)
			{
			}
			num = (short)2089484288;
			if (num != 0)
			{
			}
			num = (short)1375272960;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().UpdatePcrFwDescription(MapForDescription, PcrFwDescription);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00008078 File Offset: 0x00006278
		public string GetLocalizedFeatureName(int featureNameTag)
		{
			short num = (short)553384200;
			short num2 = num;
			num = (short)363329800;
			switch (num2 == num)
			{
			}
			num = (short)889323521;
			if (num != 0)
			{
			}
			num = (short)1081475072;
			if (num != 0)
			{
			}
			num = (short)768147456;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().GetLocalizedFeatureName(featureNameTag);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000812C File Offset: 0x0000632C
		public string ParseFeatureCode(int featureCode, string modelNumber)
		{
			short num = (short)1391946570;
			short num2 = num;
			num = (short)54881098;
			switch (num2 == num)
			{
			}
			num = (short)2038366209;
			if (num != 0)
			{
			}
			num = (short)150994944;
			if (num != 0)
			{
			}
			num = (short)45547520;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().ParseFeatureCode(featureCode, modelNumber);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000081E0 File Offset: 0x000063E0
		public string ParseFeatureStatus(global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus fs)
		{
			short num = (short)1800105261;
			short num2 = num;
			num = (short)1242459437;
			switch (num2 == num)
			{
			}
			num = (short)1825243136;
			if (num != 0)
			{
			}
			num = (short)462815233;
			if (num != 0)
			{
			}
			num = (short)1313472512;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().ParseFeatureStatus(fs);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00008298 File Offset: 0x00006498
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> FilterLicenseList(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> originalLicenseList)
		{
			short num = (short)1470028217;
			short num2 = num;
			num = (short)1043257785;
			switch (num2 == num)
			{
			}
			num = (short)639434752;
			if (num != 0)
			{
			}
			num = (short)530317313;
			if (num != 0)
			{
			}
			num = (short)1392771072;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().FilterLicenseList(originalLicenseList);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00008348 File Offset: 0x00006548
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrRadioEntitledLicenseSummary> PCRFilterLicenseList(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> licenseList)
		{
			short num = (short)1948458035;
			short num2 = num;
			num = (short)577182771;
			switch (num2 == num)
			{
			}
			num = (short)709165057;
			if (num != 0)
			{
			}
			num = (short)1804926976;
			if (num != 0)
			{
			}
			num = (short)1867186176;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().PCRFilterLicenseList(licenseList);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000083FC File Offset: 0x000065FC
		public global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.Server.EntityModel.CpsFeatureItem> CpsPcrFilterLicenseList(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PcrFeatureDetail> licenseList)
		{
			short num = (short)985792513;
			if (num != 0)
			{
			}
			num = (short)8219078;
			short num2 = num;
			num = (short)874867142;
			switch (num2 == num)
			{
			}
			num = (short)852951040;
			if (num != 0)
			{
			}
			num = (short)879558656;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000084AC File Offset: 0x000066AC
		public global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter GenerateLicenseFilter(global::System.Collections.Generic.IList<string> selectedlicenseGroup, global::System.Collections.Generic.IList<string> newSelectedLicenseGroup, out global::System.Collections.Generic.IList<string> toUnselectedLicenseGroup)
		{
			short num = (short)476090983;
			short num2 = num;
			num = (short)1357812327;
			switch (num2 == num)
			{
			}
			num = (short)1012989952;
			if (num != 0)
			{
			}
			num = (short)364249089;
			if (num != 0)
			{
			}
			num = (short)136052736;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().GenerateLicenseFilter(selectedlicenseGroup, newSelectedLicenseGroup, out toUnselectedLicenseGroup);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00008560 File Offset: 0x00006760
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PcrFeatureDetail> CpsGetPcrFeatureDetail(global::Motorola.CommonCPS.Server.EntityModel.FeatureList featureNames)
		{
			short num = (short)1796534040;
			short num2 = num;
			num = (short)1915809560;
			switch (num2 == num)
			{
			}
			num = (short)1554317313;
			if (num != 0)
			{
			}
			num = (short)958332928;
			if (num != 0)
			{
			}
			num = (short)1587609600;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00008610 File Offset: 0x00006810
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> ApplyRadioWithFeatures(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> radioLicenses, out bool canUpgraded, out bool anyInvalid, out string warning)
		{
			short num = (short)1757441761;
			short num2 = num;
			num = (short)1709928161;
			switch (num2 == num)
			{
			}
			num = (short)92340224;
			if (num != 0)
			{
			}
			num = (short)754253825;
			if (num != 0)
			{
			}
			num = (short)66584576;
			short num3 = num;
			warning = string.Empty;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().ApplyRadioWithFeatures(radio, radioLicenses, out canUpgraded, out anyInvalid, out warning);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000086D0 File Offset: 0x000068D0
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> PopulateRadioFeaturesFromCodeplug(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Template targetTemplate, out int cfsModelType)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1196032001;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (radio.WorkingCodeplug.Template == null)
					{
						num2 = (short)1439956994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_146;
				case 2:
					goto IL_117;
				case 3:
					if (radio.WorkingCodeplug != null)
					{
						num2 = (short)900988929;
						if (num2 != 0)
						{
						}
						num2 = (short)1372913664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7C;
				}
				goto IL_20;
			}
			IL_7C:
			num2 = (short)545526016;
			short num3 = num2;
			num2 = (short)212275456;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_117:
				num2 = (short)449380352;
				short num4 = num2;
				goto IL_7C;
			}
			default:
				num2 = (short)80936960;
				if (num2 != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().PopulateRadioFeaturesFromCodeplug(radio.SerialNumber, targetTemplate, out cfsModelType);
			}
			IL_146:
			return null;
			IL_20:
			cfsModelType = 0;
			num2 = (short)1596129283;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00008824 File Offset: 0x00006A24
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs PopulateRadioFeaturesFromFlashCode(byte[] flashCode, string modelNumber)
		{
			short num = (short)1137862973;
			short num2 = num;
			num = (short)267938109;
			switch (num2 == num)
			{
			}
			num = (short)1035862017;
			if (num != 0)
			{
			}
			num = (short)1090781184;
			if (num != 0)
			{
			}
			num = (short)2016739328;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().PopulateRadioFeaturesFromFlashCode(flashCode, modelNumber);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000088D8 File Offset: 0x00006AD8
		public void ParseRadioFeature(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary featureSummary, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicense)
		{
			short num = (short)1544836017;
			short num2 = num;
			num = (short)2088326065;
			switch (num2 == num)
			{
			}
			num = (short)1355546625;
			if (num != 0)
			{
			}
			num = (short)1383071744;
			if (num != 0)
			{
			}
			num = (short)1454112768;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().ParseRadioFeature(featureSummary, radioLicense);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00008990 File Offset: 0x00006B90
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense> AstroParseFlashCode(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary rawRd, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio localRd)
		{
			short num = (short)1532428289;
			if (num != 0)
			{
			}
			num = (short)1253303138;
			short num2 = num;
			num = (short)1907549026;
			switch (num2 == num)
			{
			}
			num = (short)1174142976;
			if (num != 0)
			{
			}
			num = (short)2039742464;
			short num3 = num;
			return this.AstroParseFlashCode(localRd.AstroPurchasedFlashCode, localRd.ModelNumber).Values.Select(delegate(string option)
			{
				short num4 = (short)1989656553;
				short num5 = num4;
				num4 = (short)789102569;
				switch (num5 == num4)
				{
				}
				num4 = (short)1066598400;
				if (num4 != 0)
				{
				}
				num4 = (short)743964673;
				if (num4 != 0)
				{
				}
				num4 = (short)1540358144;
				short num6 = num4;
				return new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense
				{
					FeatureName = option
				};
			}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense>();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00008A7C File Offset: 0x00006C7C
		public global::System.Collections.Generic.Dictionary<int, string> AstroParseFlashCode(string flashCode, string modelNumber)
		{
			short num = (short)352934923;
			short num2 = num;
			num = (short)137649163;
			switch (num2 == num)
			{
			}
			num = (short)912654336;
			if (num != 0)
			{
			}
			num = (short)837419009;
			if (num != 0)
			{
			}
			num = (short)1212547072;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroParseFlashCode(flashCode, modelNumber);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00008B30 File Offset: 0x00006D30
		public bool CheckAstroPop25Enabled()
		{
			short num = (short)950468609;
			if (num != 0)
			{
			}
			num = (short)853282837;
			short num2 = num;
			num = (short)506073109;
			switch (num2 == num)
			{
			}
			num = (short)807141376;
			if (num != 0)
			{
			}
			num = (short)1800798208;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().CheckAstroPop25Enabled();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00008BE0 File Offset: 0x00006DE0
		public bool AstroCheckHoptionEnable(string flashcode, string hoption, string modelNumber)
		{
			short num = (short)1530699646;
			short num2 = num;
			num = (short)2124259198;
			switch (num2 == num)
			{
			}
			num = (short)292225025;
			if (num != 0)
			{
			}
			num = (short)1581842432;
			if (num != 0)
			{
			}
			num = (short)1618935808;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroCheckHoptionEnable(flashcode, hoption, modelNumber);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00008C94 File Offset: 0x00006E94
		public bool AstroCheckIsConvOnly(string flashcode, string modelNumber)
		{
			short num = (short)337777308;
			short num2 = num;
			num = (short)1036259996;
			switch (num2 == num)
			{
			}
			num = (short)1137967105;
			if (num != 0)
			{
			}
			num = (short)531431424;
			if (num != 0)
			{
			}
			num = (short)221577216;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroCheckIsConvOnly(flashcode, modelNumber);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00008D4C File Offset: 0x00006F4C
		public bool IsFirmwareUpgradeIncludeEqual(int productFamily, string ModelNumber, string CFS)
		{
			short num = (short)816055534;
			short num2 = num;
			num = (short)1383073006;
			switch (num2 == num)
			{
			}
			num = (short)803864577;
			if (num != 0)
			{
			}
			num = (short)1782120448;
			if (num != 0)
			{
			}
			num = (short)1895825408;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().IsFirmwareUpgradeIncludeEqual(productFamily, ModelNumber, CFS);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00008E04 File Offset: 0x00007004
		public bool CheckForUnlimited()
		{
			short num = (short)1126145848;
			short num2 = num;
			num = (short)631349048;
			switch (num2 == num)
			{
			}
			num = (short)738263040;
			if (num != 0)
			{
			}
			num = (short)821821441;
			if (num != 0)
			{
			}
			num = (short)935395328;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().CheckForUnlimited();
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00008EB8 File Offset: 0x000070B8
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult GetResultForImportWithNeverOverride(global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption option)
		{
			short num = (short)1042968439;
			short num2 = num;
			num = (short)751923063;
			switch (num2 == num)
			{
			}
			num = (short)1208942593;
			if (num != 0)
			{
			}
			num = (short)971374592;
			if (num != 0)
			{
			}
			num = (short)1382940672;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult.NeverOverride;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00008F64 File Offset: 0x00007164
		public global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile FindSelectedProfileInRadioSystem(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem sys, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> profiles)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile result;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> enumerator;
				switch (num)
				{
				case 0:
					goto IL_23A;
				case 1:
					if (profiles != null)
					{
						num2 = (short)270925824;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					num2 = (short)1680408577;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)858390529;
					if (num2 != 0)
					{
					}
					try
					{
						num2 = (short)496828422;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_182;
							case 1:
								goto IL_164;
							case 2:
							{
								global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
								if (apxdataProfile.Name == sys.SelectedDataProfileName)
								{
									num2 = (short)1719992324;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 3:
								num2 = (short)766967808;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
							{
								global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
								result = apxdataProfile;
								num2 = (short)76087297;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)1668808707;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile = enumerator.Current;
								num2 = (short)1338441730;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_CC;
								}
								continue;
							}
							IL_113:
							num2 = (short)1431109637;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_CC:
							goto IL_113;
						}
						IL_164:
						IL_182:
						return result;
					}
					finally
					{
						num2 = (short)2045509634;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_237;
							case 1:
								goto IL_21B;
							case 2:
							{
								num2 = (short)1095631757;
								short num3 = num2;
								num2 = (short)1674904461;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_21B;
								default:
									num2 = (short)173867008;
									if (num2 != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_201;
									}
									continue;
								}
								break;
							}
							}
							IL_201:
							if (enumerator != null)
							{
								num2 = (short)1718616065;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
							IL_21B:
							enumerator.Dispose();
							num2 = (short)753860608;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_237:;
					}
					goto IL_23A;
				case 4:
					if (!string.IsNullOrWhiteSpace(sys.SelectedDataProfileName))
					{
						num2 = (short)829358082;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_23A:
				enumerator = profiles.GetEnumerator();
				num2 = (short)1719861251;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			num2 = (short)558301184;
			short num4 = num2;
			result = null;
			num2 = (short)1176895492;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000923C File Offset: 0x0000743C
		public string AddFileSuffixForExportASTRORadio(string filePath)
		{
			int a_ = 4;
			short num = (short)1174339589;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_9C;
				case 1:
					filePath += global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("떚", a_);
					num = (short)20250624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1831143302;
					short num3 = num;
					num = (short)1190856582;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)959905792;
						short num4 = num;
						break;
					}
					}
					num = (short)358547456;
					if (num != 0)
					{
					}
					num = (short)737214467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (!filePath.EndsWith(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("떚", a_), global::System.StringComparison.CurrentCulture))
					{
						num = (short)1391984641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C;
				case 4:
					return filePath;
				case 5:
					num = (short)1530134529;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				}
				IL_6C:
				if (!filePath.EndsWith(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("떚ﲞ", a_), global::System.StringComparison.CurrentCultureIgnoreCase))
				{
					num = (short)2092105730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9C:
				filePath += global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﺜ", a_);
				num = (short)1729691652;
				num2 = (int)((global::System.IntPtr)num);
			}
			return filePath;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00009408 File Offset: 0x00007608
		public string AddFileSuffixForExportPCRRadio(string filePath)
		{
			int a_ = 1;
			short num = (short)2043281413;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_9F;
				case 1:
					filePath += global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("뚗", a_);
					num = (short)182517760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)903913827;
					short num3 = num;
					num = (short)132489571;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)93913088;
						short num4 = num;
						break;
					}
					}
					num = (short)1418592256;
					if (num != 0)
					{
					}
					num = (short)467599363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (!filePath.EndsWith(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("뚗", a_), global::System.StringComparison.CurrentCulture))
					{
						num = (short)149291009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9F;
				case 4:
					return filePath;
				case 5:
					num = (short)1506213889;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					continue;
				}
				IL_6F:
				if (!filePath.EndsWith(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("뚗蓮ﲝ", a_), global::System.StringComparison.CurrentCultureIgnoreCase))
				{
					num = (short)1565130754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9F:
				filePath += global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﮗﺛ", a_);
				num = (short)1867972612;
				num2 = (int)((global::System.IntPtr)num);
			}
			return filePath;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000095D8 File Offset: 0x000077D8
		public void ValidateForeignIP(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (transport == global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.WiredOrOTA)
					{
						num2 = (short)1153564676;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					num2 = (short)1189478400;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (string.IsNullOrEmpty(apxradio.ForeignIP))
					{
						num2 = (short)772866054;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_186;
				case 4:
				{
					num2 = (short)1579024385;
					if (num2 != 0)
					{
					}
					num2 = (short)2022108641;
					short num3 = num2;
					num2 = (short)1290464737;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_186;
					default:
						num2 = (short)1354498048;
						if (num2 != 0)
						{
						}
						goto IL_70;
					}
					break;
				}
				case 5:
					if (transport != global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.OTA)
					{
						num2 = (short)778502145;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_70;
				case 6:
					goto IL_AD;
				case 7:
					if (radio.RadioStatus == 0)
					{
						num2 = (short)719716355;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_30;
				IL_70:
				num2 = (short)1729495042;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_186:
				num2 = (short)2130509829;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_AD:
			num2 = (short)314441728;
			short num4 = num2;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidRadiosForOTAP);
			IL_30:
			apxradio = (radio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
			num2 = (short)87228423;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000097B0 File Offset: 0x000079B0
		public global::System.Collections.Generic.List<string> GetSupportedCodelugVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string maxCodeplugVersionOfRadio)
		{
			short num = (short)915931137;
			if (num != 0)
			{
			}
			num = (short)963116024;
			short num2 = num;
			num = (short)666958840;
			switch (num2 == num)
			{
			}
			num = (short)1811283968;
			if (num != 0)
			{
			}
			num = (short)119144448;
			short num3 = num;
			return null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00009858 File Offset: 0x00007A58
		public global::System.Collections.Generic.List<string> GetSupportedCodelugVersion_forUpgradeCPVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string maxCodeplugVersionOfRadio)
		{
			short num = (short)1367575530;
			short num2 = num;
			num = (short)925404138;
			switch (num2 == num)
			{
			}
			num = (short)1068892161;
			if (num != 0)
			{
			}
			num = (short)1430781952;
			if (num != 0)
			{
			}
			num = (short)1852964864;
			short num3 = num;
			return null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00009904 File Offset: 0x00007B04
		public bool IsRadioSupportWriteLPWhenUpgrade(global::System.Guid radioUuid, string packageVersion)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
					if (!string.IsNullOrEmpty(global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroDecodeLanguageIndexToLPID(apxtemplate.LanguageIndex)))
					{
						num2 = (short)402325508;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 1:
					num2 = (short)1771241473;
					if (num2 != 0)
					{
					}
					num2 = (short)1324548096;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().CheckIsSupportedLanguagePack(packageVersion, apxtemplate.LanguageIndex))
					{
						num2 = (short)361365510;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 3:
					goto IL_E7;
				case 4:
					num2 = (short)1773273090;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().CheckAstroUpgradeWithLanugagePackIsSupported(radioByDeviceUuid.CurrentCodeplug.FirmwareVersion, packageVersion))
					{
						num2 = (short)1580728321;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 6:
					return false;
				case 7:
				{
					num2 = (short)419364864;
					short num3 = num2;
					if (radioByDeviceUuid == null)
					{
						num2 = (short)489553923;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate = radioByDeviceUuid.WorkingCodeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate;
					num2 = (short)1831796741;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_30;
			}
			return false;
			IL_30:
			radioByDeviceUuid = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioByDeviceUuid(radioUuid, true);
			num2 = (short)1144106350;
			short num4 = num2;
			num2 = (short)138980718;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E7:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
			default:
			{
				num2 = (short)1724252160;
				if (num2 != 0)
				{
				}
				num2 = (short)1746862087;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00009B24 File Offset: 0x00007D24
		public global::Motorola.CommonCPS.Server.EntityModel.Radio ParsePBA(byte[] pbaData, out global::System.Collections.Generic.Dictionary<int, int> optionCount, out string ArchiveFilePath, out bool restoreJob_PbaCanNotBeDirectlyModified, bool IgnorePassword, string password)
		{
			short num = (short)728190826;
			short num2 = num;
			num = (short)1727418218;
			switch (num2 == num)
			{
			}
			num = (short)2070872065;
			if (num != 0)
			{
			}
			num = (short)1298202624;
			if (num != 0)
			{
			}
			num = (short)298450944;
			short num3 = num;
			restoreJob_PbaCanNotBeDirectlyModified = true;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
			string archieveFileTypeOfPAC = templateService.GetArchieveFileTypeOfPAC();
			string text = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.LocalApplicationData), global::System.Guid.NewGuid().ToString() + archieveFileTypeOfPAC);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().SendExportDeviceForRestoreEvent(pbaData, text);
			global::Motorola.CommonCPS.Server.EntityModel.Radio radio = radioService.ParseArchive(text, true, null, out optionCount);
			this.ExtractInfoToTemplate_Beyond_ParseArchive(pbaData, radio);
			ArchiveFilePath = text;
			return radio;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00009C38 File Offset: 0x00007E38
		public void UpdateRestoreJobzCodeplug(global::Motorola.CommonCPS.Server.EntityModel.Codeplug historical_Codeplug, global::Motorola.CommonCPS.Server.EntityModel.Radio radio_fromPBA)
		{
			short num = (short)1653348036;
			short num2 = num;
			num = (short)1001789124;
			switch (num2 == num)
			{
			}
			num = (short)1777074177;
			if (num != 0)
			{
			}
			num = (short)1760296960;
			if (num != 0)
			{
			}
			num = (short)1722417152;
			short num3 = num;
			historical_Codeplug.Template = radio_fromPBA.WorkingCodeplug.Template;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00009CF4 File Offset: 0x00007EF4
		public virtual void UploadPackageFileContentToServer(global::Motorola.CommonCPS.Server.EntityModel.Codeplug Historical_Codeplug, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> validateEntitySet)
		{
			short num = (short)1421885545;
			short num2 = num;
			num = (short)1533034601;
			switch (num2 == num)
			{
			}
			num = (short)1659830272;
			if (num != 0)
			{
			}
			num = (short)1166344193;
			if (num != 0)
			{
			}
			num = (short)734265344;
			short num3 = num;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00009DA0 File Offset: 0x00007FA0
		public void LoadSystemKeys()
		{
			short num = (short)821499730;
			short num2 = num;
			num = (short)1194334034;
			switch (num2 == num)
			{
			}
			num = (short)1639317504;
			if (num != 0)
			{
			}
			num = (short)629211137;
			if (num != 0)
			{
			}
			num = (short)1631453184;
			short num3 = num;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00009E4C File Offset: 0x0000804C
		public virtual bool IsFreon(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string modelNumber)
		{
			short num = (short)1418093565;
			short num2 = num;
			num = (short)1182163965;
			switch (num2 == num)
			{
			}
			num = (short)1970733057;
			if (num != 0)
			{
			}
			num = (short)344457216;
			if (num != 0)
			{
			}
			num = (short)818937856;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00009EFC File Offset: 0x000080FC
		protected virtual void ExtractInfoToTemplate_Beyond_ParseArchive(byte[] pbaData, global::Motorola.CommonCPS.Server.EntityModel.Radio importingRadio)
		{
			short num = (short)207798094;
			short num2 = num;
			num = (short)1232518990;
			switch (num2 == num)
			{
			}
			num = (short)1778712577;
			if (num != 0)
			{
			}
			num = (short)958726144;
			if (num != 0)
			{
			}
			num = (short)1214316544;
			short num3 = num;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00009FA8 File Offset: 0x000081A8
		public global::Motorola.CommonCPS.Server.GenericModel.ResultOfUpgradeCPVersion UpgradeCPVersion(global::Motorola.CommonCPS.Server.GenericModel.InputOfUpgradeCPVersion _InputOfUpgradeCPVersion)
		{
			short num = (short)272049590;
			short num2 = num;
			num = (short)113976758;
			switch (num2 == num)
			{
			}
			num = (short)1775960065;
			if (num != 0)
			{
			}
			num = (short)28377088;
			if (num != 0)
			{
			}
			num = (short)1266483200;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000A05C File Offset: 0x0000825C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.HOption> GetRadioOptionWithPCI(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug> EMRadio)
		{
			short num = (short)240263588;
			short num2 = num;
			num = (short)414917028;
			switch (num2 == num)
			{
			}
			num = (short)405405696;
			if (num != 0)
			{
			}
			num = (short)1855586305;
			if (num != 0)
			{
			}
			num = (short)1157300224;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000A10C File Offset: 0x0000830C
		public global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadioFromPBA(byte[] pbaData)
		{
			short num = (short)263455941;
			short num2 = num;
			num = (short)301991109;
			switch (num2 == num)
			{
			}
			num = (short)129826817;
			if (num != 0)
			{
			}
			num = (short)1240203264;
			if (num != 0)
			{
			}
			num = (short)675282944;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
