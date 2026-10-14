using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000C0 RID: 192
	internal class PrepareImportPackagesCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600040B RID: 1035 RVA: 0x00043CA8 File Offset: 0x00041EA8
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1763802214;
			short num2 = num;
			num = (short)1750236262;
			switch (num2 == num)
			{
			}
			num = (short)550174720;
			if (num != 0)
			{
			}
			num = (short)1759641600;
			short num3 = num;
			num = (short)735707137;
			if (num != 0)
			{
			}
			return base.CanExecute(paras);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00043D5C File Offset: 0x00041F5C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)276103168;
			switch (num)
			{
			default:
			{
				num = (short)90177555;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						string[] array;
						global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportDVRSFilesPackageBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportDVRSFilesPackageBatchOp(new global::System.Collections.Generic.List<string>(array));
						base.ExecuteBatchOp<string>(op);
						num = (short)984023052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)794099763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_3FE;
					case 3:
					{
						string[] array2 = base.Interaction.ShowOpenFileDialogForImportVAFiles(global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportPackagesCommand.a);
						num = (short)953548843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_77B;
					case 5:
					{
						string[] array3 = base.Interaction.ShowOpenFileDialogForImportTTSFiles(global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportPackagesCommand.b);
						num = (short)1401946154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_A30;
					case 7:
					{
						string[] array;
						if (array != null)
						{
							num = (short)639238203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF9;
					}
					case 8:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType;
						switch (packageType)
						{
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.VoiceAnnouncement:
						{
							string[] array2 = null;
							num = (short)1041039399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.TextToSpeech:
						{
							string[] array3 = null;
							num = (short)438042660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.LanguagePack:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext importLanguagePackContext = base.LocalService.GetPackagesFromCPS(packageType) as global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext;
							num = (short)1832845345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						default:
							num = (short)1354170430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
					{
						if (paras.Length == 2)
						{
							num = (short)1761673271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array = base.Interaction.ShowOpenFileDialogForImportDVRSFiles(string.Empty);
						num = (short)297402384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						string[] array4;
						global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCACertificatesPackageBatchOp op2 = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCACertificatesPackageBatchOp(new global::System.Collections.Generic.List<string>(array4));
						base.ExecuteBatchOp<string>(op2);
						num = (short)907083807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)493027349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_AB8;
					case 13:
						global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportPackagesCommand.b = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.GetTTSInstallationPath();
						num = (short)152829976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						string[] array3;
						if (array3.Length != 0)
						{
							num = (short)1795751976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF9;
					}
					case 15:
					{
						if (!paras.Any<object>())
						{
							num = (short)111280180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType = (global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType)paras[0];
						num = (short)1039532040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_164;
					case 17:
						goto IL_164;
					case 18:
						goto IL_8AB;
					case 19:
						switch (0)
						{
						case 0:
							goto IL_140;
						}
						continue;
					case 20:
						goto IL_1A1;
					case 21:
					{
						string[] array2;
						if (array2.Length != 0)
						{
							num = (short)1353056286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF9;
					}
					case 22:
						num = (short)289210372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						string[] array4;
						if (array4 != null)
						{
							num = (short)77266945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF9;
					}
					case 24:
					{
						if (global::System.IO.Directory.Exists(global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportPackagesCommand.b))
						{
							num = (short)1452670981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array3 = base.Interaction.ShowOpenFileDialogForImportTTSFiles(string.Empty);
						num = (short)1636302866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext importLanguagePackContext;
						base.Interaction.ShowImportLanguagePackDialog(importLanguagePackContext);
						num = (short)1204355133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType;
						if (packageType != global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.DVRSFiles)
						{
							num = (short)1420754966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array = null;
						num = (short)1363148809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_20B;
					case 28:
						goto IL_3FE;
					case 29:
						goto IL_3FE;
					case 30:
					{
						string[] array2;
						global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportVAPackageBatchOp op3 = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportVAPackageBatchOp(new global::System.Collections.Generic.List<string>(array2));
						base.ExecuteBatchOp<string>(op3);
						num = (short)2007760902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_7AF;
					case 32:
						num = (short)1323958286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext importLanguagePackContext;
						if (importLanguagePackContext != null)
						{
							num = (short)1748434969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_RMCDidntFindPackageToImport, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_LoadLanguagePacksFromCPS_Error);
						num = (short)811991067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
					{
						string[] array2 = ((global::System.Collections.Generic.List<string>)paras[1]).ToArray();
						goto IL_692;
					}
					case 35:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType;
						if (packageType != global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.CACertificates)
						{
							num = (short)1105723449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array4 = null;
						num = (short)371195964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						if (paras.Length == 2)
						{
							num = (short)1159135290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)332202030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_3D1;
					case 38:
						goto IL_1A1;
					case 39:
						if (paras.Length == 2)
						{
							num = (short)399441954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)997261357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						string[] array3;
						global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportTTSPackageBatchOp op4 = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportTTSPackageBatchOp(new global::System.Collections.Generic.List<string>(array3));
						base.ExecuteBatchOp<string>(op4);
						num = (short)1564344357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
					{
						string[] array;
						if (array.Length != 0)
						{
							num = (short)1663107072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF9;
					}
					case 42:
						goto IL_8AB;
					case 43:
						goto IL_3FE;
					case 44:
					{
						string[] array2;
						if (array2 != null)
						{
							num = (short)816840715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF9;
					}
					case 45:
					{
						if (string.IsNullOrEmpty(global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportPackagesCommand.a))
						{
							num = (short)770048050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array2 = base.Interaction.ShowOpenFileDialogForImportVAFiles(global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportPackagesCommand.a);
						num = (short)327221277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
					{
						if (string.IsNullOrEmpty(global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportPackagesCommand.b))
						{
							num = (short)2015952909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array3 = base.Interaction.ShowOpenFileDialogForImportTTSFiles(global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportPackagesCommand.b);
						num = (short)587202609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						goto IL_8AB;
					case 48:
					{
						string[] array3;
						if (array3 != null)
						{
							num = (short)1524564000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF9;
					}
					case 49:
						goto IL_8AB;
					case 50:
						global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportPackagesCommand.a = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.GetVaInstallationPath();
						num = (short)862453813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
					{
						string[] array4;
						if (array4.Length != 0)
						{
							num = (short)1809776650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF9;
					}
					case 52:
						goto IL_477;
					case 53:
					{
						if (global::System.IO.Directory.Exists(global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportPackagesCommand.a))
						{
							num = (short)1135935491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array2 = base.Interaction.ShowOpenFileDialogForImportVAFiles(string.Empty);
						num = (short)1622147100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
					{
						string[] array4 = ((global::System.Collections.Generic.List<string>)paras[1]).ToArray();
						num = (short)476250150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
					{
						num = (short)1357840385;
						if (num != 0)
						{
						}
						string[] array = ((global::System.Collections.Generic.List<string>)paras[1]).ToArray();
						num = (short)1116274705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						num = (short)442892303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						num = (short)229703706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
					{
						string[] array3 = ((global::System.Collections.Generic.List<string>)paras[1]).ToArray();
						num = (short)2012479535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						num = (short)1855914025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
					{
						if (paras.Length == 2)
						{
							num = (short)338821174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array4 = base.Interaction.ShowOpenFileDialogForImportCACertificateFiles(string.Empty);
						num = (short)151519252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 61:
						goto IL_4A0;
					case 62:
					{
						num = (short)1841318425;
						short num3 = num;
						num = (short)524110361;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_692;
						default:
							num = (short)1496776704;
							if (num != 0)
							{
							}
							num = (short)1693515811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_140:
					if (paras != null)
					{
						num = (short)132317240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B4;
					IL_164:
					num = (short)1900806151;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A1:
					num = (short)176291863;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FE:
					num = (short)1353777196;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_692:
					num = (short)1810300930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8AB:
					num = (short)465174576;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_20B:
				goto IL_AF9;
				IL_3D1:
				num = (short)131923968;
				short num4 = num;
				goto IL_AF9;
				IL_477:
				goto IL_7B4;
				IL_4A0:
				IL_77B:
				IL_7AF:
				goto IL_AF9;
				IL_7B4:
				throw new global::System.ArgumentNullException();
				IL_A30:
				IL_AB8:
				IL_AF9:
				return true;
			}
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0004487C File Offset: 0x00042A7C
		// Note: this type is marked as 'beforefieldinit'.
		static PrepareImportPackagesCommand()
		{
			short num = (short)1226133860;
			short num2 = num;
			num = (short)263541092;
			switch (num2 == num)
			{
			default:
			{
				num = (short)228130816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1044774912;
			if (num != 0)
			{
			}
			num = (short)748093441;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportPackagesCommand.a = string.Empty;
			global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportPackagesCommand.b = string.Empty;
		}

		// Token: 0x040000C8 RID: 200
		private static string a;

		// Token: 0x040000C9 RID: 201
		private static string b;
	}
}
