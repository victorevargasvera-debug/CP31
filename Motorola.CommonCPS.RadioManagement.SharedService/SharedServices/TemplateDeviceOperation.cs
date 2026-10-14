using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Xml;
using ASK.Interface;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase.Enums;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;
using SharedUtility.Arguments;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200006B RID: 107
	internal class TemplateDeviceOperation : global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceOperation, global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateDeviceOperation, global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceOperation
	{
		// Token: 0x06000744 RID: 1860 RVA: 0x0004EAA8 File Offset: 0x0004CCA8
		public global::Motorola.CommonCPS.Server.EntityModel.Template PreImportTemplateToServer(string filePath, global::Motorola.CommonCPS.Server.EntityModel.Template template)
		{
			short num = (short)1669922817;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)444923904;
					short num3 = num;
					num = (short)1551237121;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).AddFile(filePath, global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.CpdFile);
					template.RMFile = rmfile;
					template.FileUuid = new global::System.Guid?(rmfile.Uuid);
					string fileBaseName = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.GetFileBaseName(filePath, 320);
					template.TemplateBaseName = fileBaseName;
					template.Name = null;
					num = (short)1695612930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					return template;
				}
				IL_30:
				if (string.IsNullOrEmpty(filePath))
				{
					break;
				}
				num = (short)133643516;
				short num4 = num;
				num = (short)951270652;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return template;
				default:
					num = (short)652083200;
					if (num != 0)
					{
					}
					num = (short)2119172096;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return template;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0004EC00 File Offset: 0x0004CE00
		public override bool IsSerialNumberValid(string serialNumber)
		{
			int a_ = 16;
			global::System.Text.RegularExpressions.Regex regex;
			global::System.Text.RegularExpressions.Regex regex2;
			for (;;)
			{
				IL_09:
				short num = (short)1387397121;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				int num2;
				for (;;)
				{
					IL_3A:
					switch (num2)
					{
					case 0:
					{
						if (!char.IsUpper(serialNumber[9]))
						{
							goto IL_173;
						}
						num = (short)776798208;
						short num3 = num;
						num = (short)219303993;
						short num4 = num;
						num = (short)1207717945;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)1883111424;
							if (num != 0)
							{
							}
							num = (short)1107820547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)1572470784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!char.IsUpper(serialNumber[8]))
						{
							num = (short)631046145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B0;
					case 3:
						goto IL_16E;
					}
					break;
				}
				IL_50:
				regex = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﲦ馨蚪钬莲颴躶趼銾黂黄賌诐ﻒ軔飖蓘蛚蛜點쳠맢죤볦ꃨꓪ냬닮꫰닲\ud8f4귶퓸ꃺ듼냾尀市帄㜆␈㈊䰌∎䬐㸒且嘖尘刚刜䨞砠縢砤簦ᤨتᐬ渮ᰰ椲ᠴ氶砸縺琼瀾ᑀᩂᡄᩆቈ筊恌癎ၐ繒པ穖ɘᩚᡜᙞ⹠㙢㱤㩦㑨な嵬䉮䡰㉲塴⵶呸⁺㱼㩾좀첂킄\ude86품횊", a_));
				regex2 = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﲦ馨蚪钬莲颴躶趼銾黂黄賌诐ﻒ軔飖蓘蛚蛜點쳠맢죤볦ꃨꓪ냬닮꫰닲\ud8f4귶퓸ꃺ듼냾尀市帄㜆␈㈊䰌∎䬐㸒且帖嘘䘚䀜䐞ᄠยᰤ昦Ш焪,琮砰簲栴樶戸଺ြؾ@湂ὄ橆ቈ੊ࡌَṐْ౔੖јZ浜牞塠≢䡤㵦䑨なⱬ⩮㡰㱲⁴⹶⑸♺", a_));
				num = (short)916062210;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_3A;
			}
			IL_B0:
			return regex.IsMatch(serialNumber);
			IL_16E:
			goto IL_B0;
			IL_173:
			return regex2.IsMatch(serialNumber);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0004ED88 File Offset: 0x0004CF88
		public override void ValidateLanguagePackForApplyTemplateToRadio(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug codeplug, string radioFirmwareVer)
		{
			short num = (short)2094792705;
			if (num != 0)
			{
			}
			num = (short)2142028740;
			short num2 = num;
			num = (short)1732625348;
			switch (num2 == num)
			{
			}
			num = (short)2127167488;
			if (num != 0)
			{
			}
			num = (short)1061224448;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AutomaticUpgradeLPUtility.ValidateLanguagePackForApplyTemplateToRadio(codeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate, radioFirmwareVer);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0004EE44 File Offset: 0x0004D044
		public override void ValidateIsAllowWriteLanguage(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type)
		{
			short num = (short)1267204097;
			if (num != 0)
			{
			}
			num = (short)123207683;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_15F;
				case 1:
				{
					num = (short)2107047936;
					short num3 = num;
					num = (short)985039529;
					short num4 = num;
					num = (short)1715569321;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15F;
					default:
						num = (short)691863552;
						if (num != 0)
						{
						}
						num = (short)829095940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 4:
					if (type == global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteWithSwitchover)
					{
						num = (short)586088448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_60:
				if (type != global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteNoSwitchover)
				{
					num = (short)734199809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A4:
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug codeplug = radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
				this.ValidateLanguagePackForApplyTemplateToRadio(codeplug, radio.CurrentCodeplug.FirmwareVersion);
				num = (short)579600386;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15F:
				goto IL_A4;
			}
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0004EFB8 File Offset: 0x0004D1B8
		public override void BuildValidateSetForASTROScheduleJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug currentCodeplug, global::Motorola.CommonCPS.Server.EntityModel.Codeplug workingCodeplug, ref global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			short num = (short)1799159812;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					flag = (workingCodeplug.Template != null);
					goto IL_13B;
				case 1:
					num = (short)951713795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
					flag = (null != null);
					goto IL_13B;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
				{
					for (;;)
					{
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(set.ValidateEntityList, workingCodeplug.Template);
						num = (short)1421627374;
						short num3 = num;
						num = (short)1163939822;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_E5;
						}
						goto Block_2;
					}
					IL_E5:
					num = (short)612433921;
					if (num != 0)
					{
					}
					num = (short)1695285248;
					if (num != 0)
					{
					}
					num = (short)212992002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_2:
					num = (short)1462697984;
					short num4 = num;
					goto IL_E5;
				}
				}
				IL_3C:
				if (workingCodeplug == null)
				{
					num = (short)868417537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1874329600;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13B:
				if (!flag)
				{
					break;
				}
				num = (short)1428815877;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0004F140 File Offset: 0x0004D340
		public override void PreImportRadioToServer(string filePath, global::Motorola.CommonCPS.Server.EntityModel.Radio deviceToImport, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption option)
		{
			short num = (short)1043988483;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.PreImportTemplateToServer(filePath, deviceToImport.WorkingCodeplug.Template);
					num = (short)2079653890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_7A;
				case 2:
					goto IL_A6;
				case 3:
				{
					num = (short)1996161024;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				}
				case 4:
					if (deviceToImport.WorkingCodeplug.Template != null)
					{
						num = (short)1234042880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_61:
				if (option == global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption.RadioOnly)
				{
					num = (short)612040705;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1190985732;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7A:
			num = (short)1434557385;
			short num4 = num;
			num = (short)934124489;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A6:
				num = (short)1992097793;
				if (num != 0)
				{
				}
				break;
			default:
				num = (short)955187200;
				if (num != 0)
				{
				}
				return;
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0004F2AC File Offset: 0x0004D4AC
		public override void GetSyncDataForUpgrade(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware firmware, byte[] flashCode, string iButtonSerialNumber, global::System.Collections.Generic.IList<global::System.Guid> cross712Radios, int allRadioCount, bool isRefresh, global::ASK.Interface.ISystemKeyData systemID, out global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData, string codeplugVersion = null)
		{
			short num = (short)296550400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9C;
				}
				global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
				string firmwareVersion;
				for (;;)
				{
					IL_29:
					int? productFamily;
					int num3;
					bool? isPortable;
					global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile;
					switch (num2)
					{
					case 0:
						goto IL_113;
					case 1:
						if (productFamily.GetValueOrDefault() == num3 & productFamily != null)
						{
							num = (short)659947524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						apxtemplate.BBFBundleVersion = firmware.PackageVersion;
						num = (short)1324023826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)414515201;
						if (num != 0)
						{
						}
						num = (short)449444608;
						short num4 = num;
						num = (short)290781952;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_113;
						default:
							num = (short)918421504;
							if (num != 0)
							{
							}
							if (productFamily.GetValueOrDefault() == num3 & productFamily != null)
							{
								num = (short)1144193038;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							apxtemplate.BBFBundleVersion = firmware.PackageVersion;
							num = (short)101318676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
					{
						apxtemplate.Uuid = global::System.Guid.Empty;
						apxtemplate.Name = null;
						apxtemplate.FirmwareVersion = firmware.PackageVersion;
						bool? flag = firmware.IsFreonFirmwareUpgradeFile;
						bool flag2 = true;
						num = (short)1817640981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						apxtemplate.BBFBundleVersion = firmware.BPSoftwareVersion;
						num = (short)498991126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (radio.ModelNumber.Substring(0, 1)[0] != 'H')
						{
							num = (short)791478282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FE;
					case 6:
						goto IL_54B;
					case 7:
						if (cross712Radios.Count > 0)
						{
							num = (short)594804747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_73D;
					case 8:
					{
						bool? flag;
						bool flag2;
						if (!(flag.GetValueOrDefault() == flag2 & flag != null))
						{
							num = (short)593690649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47B;
					}
					case 9:
						goto IL_6E2;
					case 10:
						isPortable = new bool?(false);
						num = (short)1584660503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						apxtemplate.FirmwareVersion = firmware.PackageVersion;
						bool? flag = firmware.IsFreonFirmwareUpgradeFile;
						bool flag2 = true;
						num = (short)1696989192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1779957777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54B;
					}
					case 13:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)2109931546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17D;
					}
					case 14:
						apxtemplate.BBFBundleVersion = firmware.BPSoftwareVersion;
						num = (short)310181894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						if (apxtemplate == null)
						{
							num = (short)1902903296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] fileContent = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetFileContent(apxtemplate.FileUuid.Value);
						global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs astroUpgradeCodeplugEventArgs = ((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).AstroUpgradeCodeplug(flashCode, iButtonSerialNumber, apxtemplate.ModelNumber, apxtemplate, fileContent, firmwareVersion, firmware, isRefresh, systemID);
						byte[] cpFileContent = astroUpgradeCodeplugEventArgs.Syncdata.CpFileContent;
						syncData = astroUpgradeCodeplugEventArgs.Syncdata;
						rmfile = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).AddFileContent(cpFileContent);
						isPortable = new bool?(true);
						num = (short)1988100101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						num = (short)2101149696;
						short num5 = num;
						bool? flag = firmware.IsOMAPFirmwareUpgradeFile;
						bool flag2 = true;
						num = (short)1312686093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_47B;
					case 18:
						goto IL_17D;
					case 19:
						if (allRadioCount > cross712Radios.Count)
						{
							num = (short)1906704387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E2;
					case 20:
						goto IL_54B;
					case 21:
					{
						bool? flag;
						bool flag2;
						if (!(flag.GetValueOrDefault() == flag2 & flag != null))
						{
							num = (short)1070989328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65F;
					}
					case 22:
						goto IL_17D;
					case 23:
						goto IL_1FE;
					case 24:
						goto IL_5D3;
					case 25:
					{
						bool? flag = firmware.IsOMAPFirmwareUpgradeFile;
						bool flag2 = true;
						num = (short)1364983820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_65F;
					}
					goto IL_9C;
					IL_17D:
					apxtemplate.RMFile = rmfile;
					apxtemplate.FileUuid = new global::System.Guid?(rmfile.Uuid);
					string lpIDUpgradeTo = ((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).AstroDecodeLanguageIndexToLPID(apxtemplate.LanguageIndex);
					global::Motorola.CommonCPS.Server.EntityModel.Template template = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ImportTemplate(apxtemplate, radio.CurrentCodeplug.FirmwareVersion, isPortable, lpIDUpgradeTo);
					(syncData as global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode).TargetTemplate = (template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
					num = (short)1955069961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FE:
					num = (short)1114374163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47B:
					productFamily = radio.ProductFamily;
					num3 = 4096;
					num = (short)666763266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54B:
					apxtemplate.RMFile = rmfile;
					apxtemplate.FileUuid = new global::System.Guid?(rmfile.Uuid);
					apxtemplate.ASTROLanguagePack = null;
					apxtemplate.LanguageIndex = new int?(0);
					apxtemplate.Name = null;
					apxtemplate.Uuid = global::System.Guid.Empty;
					global::Motorola.CommonCPS.Server.EntityModel.Template template2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ImportTemplate(apxtemplate, radio.CurrentCodeplug.FirmwareVersion, isPortable, null);
					(syncData as global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode).TargetTemplateCross712Upgrade = (template2 as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
					num = (short)770703384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_65F:
					productFamily = radio.ProductFamily;
					num3 = 4096;
					num = (short)855703553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6E2:
					global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateDeviceOperation.a(radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug, firmware, syncData);
					num = (short)1961754631;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_113:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_TemplateNotExist);
				IL_5D3:
				IL_73D:
				global::System.Guid value;
				(syncData as global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode).SourceTemplate = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetTemplate(value, true) as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
				return;
				IL_9C:
				firmwareVersion = radio.CurrentCodeplug.FirmwareVersion;
				value = radio.WorkingCodeplug.TemplateUuid.Value;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService;
				apxtemplate = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetTemplate(value, true) as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
				num = (short)99090447;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0004FA18 File Offset: 0x0004DC18
		public override global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet BuildValidateEntitySetForASTRORadioUpgrade(global::Motorola.CommonCPS.Server.EntityModel.APXRadio updatedRadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncRadioForUpgrade)
		{
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode syncDataForASTROUpgradeForTemplateMode;
			for (;;)
			{
				IL_0A:
				global::System.Guid? guid;
				switch (num)
				{
				case 0:
					if (guid != null)
					{
						num2 = (short)1389428747;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_362;
				case 1:
					return validateEntitySet;
				case 2:
					if (guid != null)
					{
						num2 = (short)192544782;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_163;
				case 3:
					goto IL_1A5;
				case 4:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, updatedRadio.LastJob);
					num2 = (short)2003566595;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (updatedRadio.WorkingCodeplug.Template != null)
					{
						num2 = (short)2093809672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_123;
				case 6:
					if (updatedRadio.LastJob != null)
					{
						num2 = (short)585170948;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A5;
				case 7:
					goto IL_123;
				case 8:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, updatedRadio.WorkingCodeplug.Template);
					num2 = (short)1859715079;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_227;
				case 10:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, syncDataForASTROUpgradeForTemplateMode.SourceTemplate);
					num2 = (short)1836253199;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, updatedRadio.CurrentCodeplug);
					num2 = (short)1483276300;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_362;
				case 13:
					if (syncDataForASTROUpgradeForTemplateMode.Firmware != null)
					{
						num2 = (short)67764233;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return validateEntitySet;
				case 14:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, updatedRadio.WorkingCodeplug);
					num2 = (short)965607441;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_1ED;
				case 16:
					if (syncDataForASTROUpgradeForTemplateMode.SourceTemplate != null)
					{
						num2 = (short)1005518858;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1ED;
				case 17:
					num2 = (short)1121583105;
					if (num2 != 0)
					{
					}
					goto IL_163;
				}
				goto IL_58;
				IL_123:
				num2 = (short)1870594064;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_163:
				num2 = (short)833683461;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1A5:
				guid = updatedRadio.CurrentCodeplugUuid;
				num2 = (short)1678770176;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1ED:
				num2 = (short)2101739533;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_362:
				guid = updatedRadio.WorkingCodeplugUuid;
				num2 = (short)331874306;
				num = (int)((global::System.IntPtr)num2);
			}
			return validateEntitySet;
			IL_58:
			num2 = (short)564368173;
			short num3 = num2;
			num2 = (short)1557107501;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_227:
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, syncDataForASTROUpgradeForTemplateMode.Firmware);
				num2 = (short)1814102017;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			case 1:
				break;
			default:
			{
				num2 = (short)1741881344;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)1782317056;
			if (num2 != 0)
			{
			}
			validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, updatedRadio);
			syncDataForASTROUpgradeForTemplateMode = (syncRadioForUpgrade as global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode);
			num2 = (short)2058485766;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0004FDD0 File Offset: 0x0004DFD0
		public override global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradeASTRORadioBatch(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio radioToUpgrdae, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData, global::Motorola.CommonCPS.RadioManagement.SharedServices.FlashKeyInfo flashKeyInfo, global::System.Collections.Generic.IList<global::System.Guid> cross712Radios)
		{
			short num = (short)363659264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_76;
				}
				global::Motorola.CommonCPS.Server.EntityModel.APXRadioUpgradeRequest apxradioUpgradeRequest;
				for (;;)
				{
					IL_27:
					global::Motorola.CommonCPS.Server.EntityModel.Template template;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode syncDataForASTROUpgradeForTemplateMode;
						apxradioUpgradeRequest.BBFBundleVersion = syncDataForASTROUpgradeForTemplateMode.Firmware.BPSoftwareVersion;
						num = (short)114950151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_3E4;
					case 2:
						goto IL_1C2;
					case 3:
						goto IL_230;
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode syncDataForASTROUpgradeForTemplateMode;
						bool? flag = syncDataForASTROUpgradeForTemplateMode.Firmware.IsOMAPFirmwareUpgradeFile;
						bool flag2 = true;
						num = (short)1223360521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_1C2;
					case 6:
					{
						bool? flag;
						bool flag2;
						if (!(flag.GetValueOrDefault() == flag2 & flag != null))
						{
							num = (short)57933828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_230;
					}
					case 7:
						goto IL_3E9;
					case 8:
						goto IL_258;
					case 9:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)851312643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E9;
					}
					case 10:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASKRelatedFields askrelatedFields = new global::Motorola.CommonCPS.Server.EntityModel.ASKRelatedFields();
						global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode syncDataForASTROUpgradeForTemplateMode;
						askrelatedFields.OwnerAdvancedKeyType = syncDataForASTROUpgradeForTemplateMode.hOptionAdvancedKeyIDS.OwnerAdvancedKeyType;
						askrelatedFields.OwnerSystemID = syncDataForASTROUpgradeForTemplateMode.hOptionAdvancedKeyIDS.OwnerSystemID;
						askrelatedFields.OwnerWACNID = syncDataForASTROUpgradeForTemplateMode.hOptionAdvancedKeyIDS.OwnerWACNID;
						bool? flag = syncDataForASTROUpgradeForTemplateMode.hOptionAdvancedKeyIDS.WriteProtect;
						askrelatedFields.WriteProtect = flag.Value;
						flag = syncDataForASTROUpgradeForTemplateMode.hOptionAdvancedKeyIDS.ASKRequired;
						askrelatedFields.ASKRequired = flag.Value;
						global::Motorola.CommonCPS.Server.EntityModel.ASKRelatedFields askrelatedFields2 = askrelatedFields;
						apxradioUpgradeRequest.ASKRelatedFields = askrelatedFields2;
						num = (short)68485135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (flashKeyInfo != null)
						{
							num = (short)1654390797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D9;
					case 12:
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode syncDataForASTROUpgradeForTemplateMode;
						template = syncDataForASTROUpgradeForTemplateMode.TargetTemplateCross712Upgrade;
						num = (short)1269760005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						apxradioUpgradeRequest.IButtonSerialNumber = flashKeyInfo.iButtonSerialNumber;
						num = (short)2069233665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)780992512;
						short num3 = num;
						goto IL_3E9;
					}
					case 15:
						goto IL_28E;
					case 16:
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode syncDataForASTROUpgradeForTemplateMode;
						if (syncDataForASTROUpgradeForTemplateMode.hOptionAdvancedKeyIDS != null)
						{
							num = (short)1746075658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28E;
					}
					case 17:
					{
						if (cross712Radios.Contains(radioToUpgrdae.Uuid))
						{
							num = (short)379453452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode syncDataForASTROUpgradeForTemplateMode;
						template = syncDataForASTROUpgradeForTemplateMode.TargetTemplate;
						num = (short)1525874690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_76;
					IL_1C2:
					apxradioUpgradeRequest.TemplateUuid = template.Uuid;
					num = (short)106823696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_230:
					int? productFamily = radioToUpgrdae.ProductFamily;
					int num4 = 4096;
					num = (short)178061320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28E:
					num = (short)1433010187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E9:
					template = null;
					num = (short)726401041;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3E4:
				IL_4D9:
				global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet = this.BuildValidateEntitySetForASTRORadioUpgrade(radioToUpgrdae as global::Motorola.CommonCPS.Server.EntityModel.APXRadio, syncData);
				apxradioUpgradeRequest.ValidateSet = validateSet;
				return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).UpgradeRadio(new global::System.Guid?(batchJobContainerUuid), apxradioUpgradeRequest, radioToUpgrdae.SerialNumber);
				IL_76:
				num = (short)883850587;
				short num5 = num;
				num = (short)635665755;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_258:
					int? productFamily;
					int num4;
					if (productFamily.GetValueOrDefault() == num4 & productFamily != null)
					{
						num = (short)982843392;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_27;
					}
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode syncDataForASTROUpgradeForTemplateMode;
					apxradioUpgradeRequest.BBFBundleVersion = syncDataForASTROUpgradeForTemplateMode.Firmware.PackageVersion;
					num = (short)698220558;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				default:
				{
					num = (short)1618804737;
					if (num != 0)
					{
					}
					num = (short)1015021568;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode syncDataForASTROUpgradeForTemplateMode = syncData as global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode;
					apxradioUpgradeRequest = new global::Motorola.CommonCPS.Server.EntityModel.APXRadioUpgradeRequest
					{
						Features = syncDataForASTROUpgradeForTemplateMode.RadioFeaturesRequest,
						FWUuid = new global::System.Guid?(syncDataForASTROUpgradeForTemplateMode.Firmware.Uuid),
						LicenseFrom = new global::Motorola.CommonCPS.Server.CommonDBConstants.LicenseFrom?(global::Motorola.CommonCPS.Server.CommonDBConstants.LicenseFrom.Dongle),
						IsFlashUpgrade = !syncDataForASTROUpgradeForTemplateMode.bRefresh,
						RadioUuid = radioToUpgrdae.Uuid,
						Flashcode = syncDataForASTROUpgradeForTemplateMode.FlashCode,
						FirmwareVersion = syncDataForASTROUpgradeForTemplateMode.Firmware.PackageVersion,
						DeviceInfoFields = syncDataForASTROUpgradeForTemplateMode.DeviceInfoFields
					};
					bool? flag = syncDataForASTROUpgradeForTemplateMode.Firmware.IsFreonFirmwareUpgradeFile;
					bool flag2 = true;
					num = (short)1444085766;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
				break;
			}
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000502E4 File Offset: 0x0004E4E4
		public override void CleanForUpgrade(global::System.Collections.Generic.IList<global::System.Guid> upgradeSuccessfulRadios, global::System.Collections.Generic.IList<global::System.Guid> cross712Radios, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData)
		{
			short num = (short)2072444928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_96;
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode syncDataForASTROUpgradeForTemplateMode;
				for (;;)
				{
					IL_27:
					bool flag;
					int num3;
					global::System.Collections.Generic.IEnumerator<global::System.Guid> enumerator;
					bool flag2;
					switch (num2)
					{
					case 0:
						goto IL_372;
					case 1:
						if (flag)
						{
							num = (short)1738276885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService.TryDeleteTemplate(syncDataForASTROUpgradeForTemplateMode.TargetTemplate.Uuid);
						num = (short)371392527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)645005317;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4AD;
								case 1:
									num3++;
									num = (short)946798595;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)546570246;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (cross712Radios != null)
									{
										num = (short)541523970;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_3C1;
									}
									continue;
								case 6:
								{
									global::System.Guid item;
									if (cross712Radios.Contains(item))
									{
										num = (short)499974145;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1027276808;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Guid item = enumerator.Current;
									num = (short)1610612740;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1357840384;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_416:
								num = (short)315949063;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3C1:
								goto IL_416;
							}
							IL_4AD:
							goto IL_2A3;
						}
						finally
						{
							num = (short)2068447232;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4E4;
									}
									continue;
								case 1:
									goto IL_51B;
								case 2:
									enumerator.Dispose();
									num = (short)33030145;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4E4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1097138178;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_51B:;
						}
						return;
						IL_2A3:
						num = (short)256442385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)231390275;
						short num4 = num;
						num = (short)276413507;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_224;
						default:
							num = (short)844234752;
							if (num != 0)
							{
							}
							if (syncDataForASTROUpgradeForTemplateMode == null)
							{
								num = (short)777715725;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag2 = false;
							flag = false;
							num = (short)1315176454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_12F;
					case 6:
						if (upgradeSuccessfulRadios != null)
						{
							goto IL_224;
						}
						goto IL_2E5;
					case 7:
						if (upgradeSuccessfulRadios.Count == 0)
						{
							num = (short)1225981971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57E;
					case 8:
						if (upgradeSuccessfulRadios != null)
						{
							num = (short)444989451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57E;
					case 9:
						if (num3 == 0)
						{
							num = (short)1822621714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F;
					case 10:
						if (syncDataForASTROUpgradeForTemplateMode.TargetTemplateCross712Upgrade != null)
						{
							num = (short)464060440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						num = (short)1518862337;
						if (num != 0)
						{
						}
						num = (short)790757383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (syncDataForASTROUpgradeForTemplateMode.TargetTemplate != null)
						{
							num = (short)584187904;
							short num5 = num;
							num = (short)710672386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C7;
					case 13:
						goto IL_12A;
					case 14:
						num = (short)911867912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_1C7;
					case 16:
						num = (short)109772812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (num3 == upgradeSuccessfulRadios.Count)
						{
							num = (short)1944846361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1113849865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						flag = true;
						num = (short)454950917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_2E5;
					case 20:
						goto IL_12F;
					case 21:
						num = (short)516227082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (flag2)
						{
							num = (short)1385562128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C7;
					case 23:
						goto IL_12F;
					case 24:
						global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService.TryDeleteTemplate(syncDataForASTROUpgradeForTemplateMode.TargetTemplateCross712Upgrade.Uuid);
						num = (short)992608256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						flag2 = true;
						num = (short)1796210711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_96;
					IL_12F:
					num = (short)1405485078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C7:
					num = (short)2044198913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_224:
					num = (short)195624974;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E5:
					flag2 = true;
					flag = true;
					num = (short)737017876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_57E:
					num3 = 0;
					enumerator = upgradeSuccessfulRadios.GetEnumerator();
					num = (short)967639043;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12A:
				return;
				IL_372:
				return;
				IL_96:
				global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroReleaseFlashKey();
				syncDataForASTROUpgradeForTemplateMode = (syncData as global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode);
				num = (short)1932132356;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0005095C File Offset: 0x0004EB5C
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption GetServerReadyJobtOption(bool generateTemplateOrConfig, bool applyToRadio)
		{
			short num = (short)445084093;
			short num2 = num;
			num = (short)1027174845;
			switch (num2 == num)
			{
			default:
			{
				num = (short)426049536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)393740289;
			if (num != 0)
			{
			}
			num = (short)1538916352;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption.BothWithApply;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00050A0C File Offset: 0x0004EC0C
		public override global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest HandleTemplateAndConfigForImportCSV(global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio, string templateName, string configName, string copiedRadioSN, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, global::Motorola.CommonCPS.RadioManagement.SharedServices.ImportCSVCache cache, ref global::System.Collections.Generic.List<string> warningList)
		{
			short num = (short)422379520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CA;
				}
				global::Motorola.CommonCPS.Server.EntityModel.Template template;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService;
				for (;;)
				{
					IL_27:
					global::System.Guid? templateUuid;
					bool flag2;
					switch (num2)
					{
					case 0:
						cache.TemplateCahce.Add(templateName, template);
						num = (short)1124663334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						int cfsModelType;
						(radioRq as global::Motorola.CommonCPS.Server.EntityModel.ImportMatrixRadioFromCSVRequest).CfsModelType = cfsModelType;
						num = (short)2098987028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(templateName))
						{
							num = (short)2010251280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)328597521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						bool flag;
						if (!flag)
						{
							num = (short)1705050142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3;
					}
					case 4:
						if (existedRadio.WorkingCodeplug != null)
						{
							num = (short)422314009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3;
					case 5:
						if (radioRq is global::Motorola.CommonCPS.Server.EntityModel.ImportMatrixRadioFromCSVRequest)
						{
							num = (short)1389887489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return radioRq;
					case 6:
						num = (short)2029977633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Radio radio = new global::Motorola.CommonCPS.Server.EntityModel.Radio();
						radio.SerialNumber = radioRq.SerialNumber;
						int cfsModelType = 0;
						radioRq.FeaturesList = (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest>)templateService.GetRadioLicenseFeatures(radio, template, out cfsModelType);
						num = (short)864878597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_247;
					case 9:
						if (!cache.TemplateCahce.ContainsKey(templateName))
						{
							num = (short)975962112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_625;
					case 10:
						num = (short)1092485154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (template != null)
						{
							num = (short)1956773895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return radioRq;
					case 12:
						goto IL_3A2;
					case 13:
					{
						num = (short)1920139264;
						short num3 = num;
						if (!string.IsNullOrEmpty(templateName))
						{
							num = (short)1426522127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C5;
					}
					case 14:
						template = cache.TemplateCahce[templateName];
						num = (short)1596784676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)642580482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_6C5;
					case 17:
						if (cache.TemplateCahce.ContainsKey(templateName))
						{
							num = (short)465895438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						template = templateService.GetTemplateByName(templateName);
						num = (short)405864485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (templateUuid == null)
						{
							num = (short)957349920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)854720539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						try
						{
							bool flag = templateService.CloneCheck(template, existedRadio, new global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType?(global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType.SelectTemplate));
							goto IL_509;
						}
						catch (global::Motorola.Common.CustomException.CommonException)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Failure_due_to_mismatch_of_Codeplug_Used_FLASHcode_and_Radio_FLASHcode);
						}
						goto IL_163;
						IL_509:
						num = (short)300810243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_39D;
					case 21:
						if (template != null)
						{
							num = (short)134807558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3;
					case 22:
					{
						if (template == null)
						{
							num = (short)1842282531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)584633472;
						short num4 = num;
						num = (short)425249920;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4FE;
						default:
							num = (short)852361216;
							if (num != 0)
							{
							}
							num = (short)280952841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 23:
					{
						bool flag = false;
						num = (short)1484324883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_3A2;
					case 25:
					{
						global::System.Guid uuid = template.Uuid;
						templateUuid = existedRadio.WorkingCodeplug.TemplateUuid;
						num = (short)1236533266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						flag2 = true;
						goto IL_5BB;
					case 27:
					{
						global::System.Guid uuid;
						flag2 = (uuid != templateUuid.GetValueOrDefault());
						goto IL_5BB;
					}
					case 28:
						num = (short)1103560708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (existedRadio != null)
						{
							num = (short)1002700810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_247;
					case 30:
						goto IL_540;
					case 31:
						goto IL_3A2;
					case 32:
						goto IL_163;
					case 33:
						if (existedRadio != null)
						{
							num = (short)1071448092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3;
					case 34:
						if (existedRadio.RadioStatus == 0)
						{
							num = (short)1876819976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return radioRq;
					case 35:
						templateUuid = null;
						radioRq.TemplateUuid = templateUuid;
						warningList.Add(global::Motorola.CommonCPS.Common.CommonUtility.WarningMessageConverter.OriginalToSource(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(null, methodof(global::Motorola.CommonCPS.ResourceRepository.Resources.get_RMC_TemplateNotExist_Warning_For_ImportCSV())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())), 0));
						num = (short)1309278220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_1A8;
					case 37:
						goto IL_1A8;
					case 38:
						goto IL_625;
					}
					goto IL_CA;
					IL_163:
					num = (short)524812289;
					if (num != 0)
					{
					}
					num = (short)1746927642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A8:
					num = (short)696713238;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E3:
					num = (short)1946746909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5BB:
					if (flag2)
					{
						num = (short)1530724375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E3;
					IL_247:
					num = (short)1538719755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A2:
					num = (short)1309081621;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_625:
					radioRq.TemplateUuid = new global::System.Guid?(template.Uuid);
					num = (short)539033631;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C5:
					templateUuid = null;
					radioRq.TemplateUuid = templateUuid;
					num = (short)657653784;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_39D:
				return radioRq;
				IL_4FE:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Failure_due_to_mismatch_of_Codeplug_Used_FLASHcode_and_Radio_FLASHcode);
				IL_540:
				goto IL_4FE;
				IL_CA:
				templateService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService;
				template = null;
				num = (short)685572109;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00051168 File Offset: 0x0004F368
		public override bool IsQualifiedRadio(global::Motorola.CommonCPS.Server.EntityModel.Radio rd, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest rq)
		{
			short num = (short)114753537;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.EntityModel.Codeplug workingCodeplug;
			global::System.Guid? guid;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_129;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_4C;
				case 3:
				{
					num = (short)1486946304;
					short num3 = num;
					workingCodeplug = rd.WorkingCodeplug;
					if (workingCodeplug != null)
					{
						goto IL_12C;
					}
					guid = null;
					num = (short)838696231;
					short num4 = num;
					num = (short)327777575;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_77;
					default:
						num = (short)178454528;
						if (num != 0)
						{
						}
						num = (short)1448476672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_34:
				if (rd == null)
				{
					num = (short)920387586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_77:
				num = (short)1724907523;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4C:
			num = (short)634781697;
			if (num != 0)
			{
			}
			return false;
			IL_129:
			global::System.Guid? guid2 = guid;
			goto IL_133;
			IL_12C:
			guid2 = workingCodeplug.TemplateUuid;
			IL_133:
			guid = guid2;
			return guid != null;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000512B0 File Offset: 0x0004F4B0
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? GetDefaultRegion()
		{
			short num = (short)2001464327;
			short num2 = num;
			num = (short)557968391;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1481834496;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1831665664;
			if (num != 0)
			{
			}
			num = (short)2059206657;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00051360 File Offset: 0x0004F560
		public override global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SharedServices.AppLicenseInfo> GetRegisteredAppLicenses()
		{
			short num = (short)1495942046;
			short num2 = num;
			num = (short)2044150686;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1947009024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)572981248;
			if (num != 0)
			{
			}
			num = (short)1735720961;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00051408 File Offset: 0x0004F608
		public override bool IsAppLicenseSupport_RRP(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?> regionList)
		{
			short num = (short)1953540769;
			short num2 = num;
			num = (short)506440353;
			switch (num2 == num)
			{
			}
			num = (short)1839661057;
			if (num != 0)
			{
			}
			num = (short)1079050240;
			short num3 = num;
			num = (short)1522270208;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x000514B4 File Offset: 0x0004F6B4
		public override bool ValidateAstroASKRequirement(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radioFromServer, out string error)
		{
			short num;
			for (;;)
			{
				num = (short)1599537152;
				short num2 = num;
				num = (short)656015360;
				switch (num)
				{
				default:
				{
					num = (short)1864695809;
					if (num != 0)
					{
					}
					num = (short)1398596234;
					short num3 = num;
					num = (short)1941889674;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A2;
					}
					break;
				}
				}
			}
			IL_A2:
			num = (short)1830682624;
			if (num != 0)
			{
			}
			bool result = true;
			error = string.Empty;
			try
			{
				num = (short)1531510784;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_102;
						}
						continue;
					case 1:
					{
						byte[] astroPurchasedFlashCode;
						if (base.CheckASKFieldApplicability(astroPurchasedFlashCode))
						{
							num = (short)203816962;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A8;
					}
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug cp = radioFromServer.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
						global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().ValidateAstroASKRequirementEditing(cp, radioFromServer.ModelNumber);
						num = (short)345899011;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1A8;
					case 4:
					{
						byte[] astroPurchasedFlashCode = (radioFromServer.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).AstroPurchasedFlashCode;
						num = (short)1005322241;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_1C1;
					}
					IL_102:
					if (radioFromServer.WorkingCodeplug != null)
					{
						num = (short)592510980;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1A8:
					num = (short)908525573;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1C1:;
			}
			catch (global::System.Exception ex)
			{
				error = ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x000516A4 File Offset: 0x0004F8A4
		public override bool ValidateRadioIdWithASK(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxRadioSystem, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxCpg, string modelnumber, out string error, bool checkASKOnly = false)
		{
			int a_ = 1;
			short num = (short)149291008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_58;
				}
				bool result;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (!checkASKOnly)
						{
							num = (short)1097531398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_164;
					case 1:
					{
						int? radioId = apxRadioSystem.RadioId;
						int num3 = 16777211;
						num = (short)599064578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						int? radioId;
						int num3;
						if (radioId.GetValueOrDefault() > num3 & radioId != null)
						{
							num = (short)734724099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_164;
					}
					case 3:
						goto IL_22A;
					case 4:
					{
						int? radioId;
						int num3;
						if (!(radioId.GetValueOrDefault() < num3 & radioId != null))
						{
							num = (short)1295450113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22A;
					}
					case 5:
						try
						{
							num = (short)871235586;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().ValidateASTROIndividualIdEditing(apxRadioSystem, apxCpg, modelnumber, checkASKOnly);
									num = (short)1437990913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_111;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_D0;
									}
									continue;
								case 3:
									goto IL_126;
								}
								IL_D0:
								if (apxCpg != null)
								{
									num = (short)1475280896;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_111:
								num = (short)2044592131;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_126:
							goto IL_2D8;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							error = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null);
							result = false;
							goto IL_2D8;
						}
						catch (global::System.Exception ex2)
						{
							error = ex2.Message;
							result = false;
							goto IL_2D8;
						}
						goto IL_164;
					case 6:
					{
						int? radioId = apxRadioSystem.RadioId;
						int num3 = 1;
						num = (short)716767236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_164;
					}
					goto IL_58;
					for (;;)
					{
						IL_22A:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udd97튟ﶡ좥\udea7쮩삫잭풯햳튵톷햹\udabd", a_));
						result = false;
						num = (short)2115764225;
						if (num != 0)
						{
						}
						num = (short)21069263;
						short num4 = num;
						num = (short)2086370767;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_2A5;
						}
					}
					IL_2A5:
					num = (short)1404370944;
					if (num != 0)
					{
					}
					num = (short)420347911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_164:
					num = (short)564658181;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2D8:
				num = (short)375521280;
				short num5 = num;
				return result;
				IL_58:
				error = string.Empty;
				result = true;
				num = (short)1676345344;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x000519D0 File Offset: 0x0004FBD0
		public override string GetFileNameForExportCodeplug(string serialNumber, string templateName, string configName, bool? hasPBA)
		{
			short num = (short)1331494912;
			short num2 = num;
			if (!string.IsNullOrEmpty(templateName))
			{
				num = (short)1992101124;
				short num3 = num;
				num = (short)964693252;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2034368513;
					if (num != 0)
					{
					}
					num = (short)925892608;
					if (num != 0)
					{
					}
					break;
				}
				return templateName;
			}
			return serialNumber;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00051A84 File Offset: 0x0004FC84
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption GetImportOption(bool isCreateRadio, bool isCreateTemplate, bool isCreateConfig, bool isApply)
		{
			short num = (short)1651900416;
			short num2 = num;
			if (!isCreateTemplate)
			{
				num = (short)352903044;
				short num3 = num;
				num = (short)1567350660;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)735117313;
					if (num != 0)
					{
					}
					num = (short)2036006912;
					if (num != 0)
					{
					}
					break;
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption.RadioOnly;
			}
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption.BothWithApply;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00051B38 File Offset: 0x0004FD38
		public override bool CanImportRadio(bool isCreateRadio, bool isCreateConfig)
		{
			short num = (short)1527559803;
			short num2 = num;
			num = (short)1798289019;
			switch (num2 == num)
			{
			}
			num = (short)1411121152;
			if (num != 0)
			{
			}
			num = (short)1183055872;
			short num3 = num;
			num = (short)2054750209;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00051BE4 File Offset: 0x0004FDE4
		public override bool IsInitializeImportRadio(out bool canOverride)
		{
			short num = (short)1455612433;
			short num2 = num;
			num = (short)1454301713;
			switch (num2 == num)
			{
			}
			num = (short)721616897;
			if (num != 0)
			{
			}
			num = (short)368836608;
			short num3 = num;
			num = (short)1894907904;
			if (num != 0)
			{
			}
			canOverride = true;
			return true;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00051C90 File Offset: 0x0004FE90
		public override bool IsValidAppLicense(string licenseName)
		{
			short num = (short)1185975443;
			short num2 = num;
			num = (short)139824275;
			switch (num2 == num)
			{
			}
			num = (short)999227393;
			if (num != 0)
			{
			}
			num = (short)777584640;
			short num3 = num;
			num = (short)1115488256;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsAppLicense_RadioManagement(licenseName);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00051D40 File Offset: 0x0004FF40
		public override bool CanExportCodeplug(global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus radioStatus, bool? hasPBA)
		{
			short num = (short)1752318091;
			short num2 = num;
			num = (short)1955086475;
			switch (num2 == num)
			{
			}
			num = (short)788201473;
			if (num != 0)
			{
			}
			num = (short)295763968;
			short num3 = num;
			num = (short)1366753280;
			if (num != 0)
			{
			}
			return radioStatus > global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.New;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00051DF0 File Offset: 0x0004FFF0
		public override void ValidateCodeplugVersion(global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			short num = (short)419985091;
			short num2 = num;
			num = (short)720139971;
			switch (num2 == num)
			{
			}
			num = (short)1379663873;
			if (num != 0)
			{
			}
			num = (short)1118568448;
			short num3 = num;
			num = (short)1613365248;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00051E98 File Offset: 0x00050098
		public override bool ValidateIPConflictWithLocalServerIPAddress(global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint arge, bool? locationEnable, bool? p25LocationReporting, int? arsMode, bool? directLocationRegistration, string locationServerIPAddress, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			short num = (short)299040768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B4;
				}
				bool? flag;
				bool flag2;
				int? num3;
				int num4;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (!string.IsNullOrEmpty(arge.DeviceSubscriberIP))
						{
							num = (short)816644121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B0A;
					case 1:
						flag = p25LocationReporting;
						flag2 = true;
						num = (short)775290884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_C61;
					case 3:
						num = (short)1752367105;
						if (num != 0)
						{
						}
						if (arge.DataProfileAirInterfaceIP.Equals(locationServerIPAddress))
						{
							num = (short)1135017989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FA;
					case 4:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)913047559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ABD;
					case 5:
						goto IL_BC6;
					case 6:
						num = (short)260308995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num3 = arsMode;
						num4 = 1;
						num = (short)314572818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!string.IsNullOrEmpty(arge.DataProfileSubscriberIP))
						{
							num = (short)381812745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_143;
					case 9:
						num = (short)1308229664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (arge.DeviceBluetoothDUNSubscriberIP.Equals(locationServerIPAddress))
						{
							num = (short)280363038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ABD;
					case 11:
						if (arge.APXDataProfile == null)
						{
							num = (short)215482388;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ABD;
					case 12:
						goto IL_1F5;
					case 13:
						if (!string.IsNullOrEmpty(arge.BluetoothDUNSubscriberIP))
						{
							num = (short)887160863;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A79;
					case 14:
						if (arge.APXDataProfile != null)
						{
							num = (short)633602063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 15:
						enumerator = arge.APXDataProfile.GetEnumerator();
						num = (short)1140064268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_2E6;
					case 17:
						num = (short)778633226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (!(num3.GetValueOrDefault() == num4 & num3 != null))
						{
							num = (short)609157139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ABD;
					case 19:
						flag = directLocationRegistration;
						flag2 = true;
						num = (short)2078933016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						flag = locationEnable;
						flag2 = true;
						num = (short)280166428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (!string.IsNullOrEmpty(arge.DataProfileAirInterfaceIP))
						{
							num = (short)183894022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FA;
					case 22:
						goto IL_9C3;
					case 23:
						if (!string.IsNullOrEmpty(arge.DeviceBluetoothDUNSubscriberIP))
						{
							num = (short)1199570961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ABD;
					case 24:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)590348315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ABD;
					case 25:
						num = (short)881917981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (arge.BluetoothDUNSubscriberIP.Equals(locationServerIPAddress))
						{
							num = (short)1413349392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A79;
					case 27:
						num = (short)835780621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1438973953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ABD;
					case 29:
					{
						num = (short)1647378432;
						short num5 = num;
						if (arge.DeviceSubscriberIP.Equals(locationServerIPAddress))
						{
							num = (short)1747320854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B0A;
					}
					case 30:
						goto IL_292;
					case 31:
						num = (short)117637146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (arge.DataProfileSubscriberIP.Equals(locationServerIPAddress))
						{
							num = (short)865206274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_143;
					}
					goto IL_B4;
					IL_FA:
					num = (short)256245783;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_143:
					num = (short)430702613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A79:
					num = (short)46661632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ABD:
					num = (short)1180434446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B0A:
					num = (short)1725562888;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F5:
				try
				{
					num = (short)1298006018;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
						switch (num2)
						{
						case 0:
							error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_LocationServerIPAddress;
							flag2 = false;
							num = (short)1338376216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							flag = p25LocationReporting;
							flag2 = true;
							num = (short)456982536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3A6;
							}
							continue;
						case 3:
							if (arge.DataProfileSubscriberIP.Equals(apxdataProfile.LocationServerIPAddress))
							{
								num = (short)1090912278;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_59A;
						case 4:
							num3 = apxdataProfile.ArsMode;
							num4 = 1;
							num = (short)463208467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_605;
						case 6:
							flag = apxdataProfile.DirectLocationRegistration;
							flag2 = true;
							num = (short)1127022601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (!string.IsNullOrEmpty(arge.DeviceBluetoothDUNSubscriberIP))
							{
								num = (short)1736114188;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_851;
						case 8:
						{
							num = (short)1079357594;
							short num6 = num;
							num = (short)593473690;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_4AF;
							default:
								num = (short)469041152;
								if (num != 0)
								{
								}
								if (flag.GetValueOrDefault() == flag2 & flag != null)
								{
									num = (short)1856241668;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							break;
						}
						case 9:
							if (flag.GetValueOrDefault() == flag2 & flag != null)
							{
								num = (short)292552738;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 10:
							if (arge.DeviceSubscriberIP.Equals(apxdataProfile.LocationServerIPAddress))
							{
								num = (short)1767637005;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_765;
						case 11:
							if (!enumerator.MoveNext())
							{
								num = (short)432537623;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4AF;
						case 12:
							num = (short)181010468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_LocationServerIPAddress;
							flag2 = false;
							num = (short)748224527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (!string.IsNullOrEmpty(arge.BluetoothDUNSubscriberIP))
							{
								num = (short)1531969556;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_50C;
						case 15:
							goto IL_45D;
						case 16:
							if (!string.IsNullOrEmpty(arge.DataProfileSubscriberIP))
							{
								num = (short)7536672;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_59A;
						case 17:
							goto IL_824;
						case 18:
							goto IL_84C;
						case 19:
							if (!(num3.GetValueOrDefault() == num4 & num3 != null))
							{
								num = (short)1875181574;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 20:
							num = (short)1187643418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							num = (short)1862664202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_LocationServerIPAddress;
							flag2 = false;
							num = (short)1160642577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
							num = (short)400162847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							goto IL_62C;
						case 25:
							error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_LocationServerIPAddress;
							flag2 = false;
							num = (short)1925054482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							if (arge.BluetoothDUNSubscriberIP.Equals(apxdataProfile.LocationServerIPAddress))
							{
								num = (short)721682459;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_50C;
						case 27:
							error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_LocationServerIPAddress;
							flag2 = false;
							num = (short)1955790853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							if (flag.GetValueOrDefault() == flag2 & flag != null)
							{
								num = (short)1066008577;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 29:
							num = (short)949551137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							if (!string.IsNullOrEmpty(arge.DataProfileAirInterfaceIP))
							{
								num = (short)1486946333;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 31:
							goto IL_945;
						case 32:
							num = (short)1281687555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							if (arge.DataProfileAirInterfaceIP.Equals(apxdataProfile.LocationServerIPAddress))
							{
								num = (short)1767505920;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 34:
							num = (short)534183971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 35:
							if (!string.IsNullOrEmpty(arge.DeviceSubscriberIP))
							{
								num = (short)1209794581;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_765;
						case 36:
							if (arge.DeviceBluetoothDUNSubscriberIP.Equals(apxdataProfile.LocationServerIPAddress))
							{
								num = (short)695599129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_851;
						}
						goto IL_3A6;
						IL_4AF:
						apxdataProfile = enumerator.Current;
						flag = locationEnable;
						flag2 = true;
						num = (short)2081882140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_50C:
						num = (short)152436743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_59A:
						num = (short)2017525790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_723:
						num = (short)730071051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3A6:
						goto IL_723;
						IL_765:
						num = (short)709754894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_851:
						num = (short)1507328016;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_45D:
					IL_605:
					IL_62C:
					IL_824:
					IL_84C:
					return flag2;
					IL_945:;
				}
				finally
				{
					((global::System.IDisposable)enumerator).Dispose();
				}
				return true;
				IL_292:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_LocationServerIPAddress;
				return false;
				IL_2E6:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBlueToothDunSubIP_NoSame_LocationServerIPAddress;
				return false;
				IL_9C3:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBlueToothDunSubIP_NoSame_LocationServerIPAddress;
				return false;
				IL_BC6:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_LocationServerIPAddress;
				return false;
				IL_C61:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_LocationServerIPAddress;
				return false;
				IL_B4:
				error = global::Motorola.Common.CustomException.CommonErrorCode.None;
				num = (short)364576779;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00052B34 File Offset: 0x00050D34
		public override bool ValidataIPConflictWithBluetoothPANNetworkBaseAddress(global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint arge, string bluetoothPANNetworkBaseAddress, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_A0;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_41E;
				case 1:
					num2 = (short)1983840263;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (!string.IsNullOrEmpty(arge.DataProfilePeerIP))
					{
						num2 = (short)1752760353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					if (!string.IsNullOrEmpty(arge.BluetoothDUNPeerIP))
					{
						num2 = (short)573636642;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5CC;
				case 4:
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateDeviceOperation.a(bluetoothPANNetworkBaseAddress, arge.BluetoothDUNSubscriberIP))
					{
						num2 = (short)342163485;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_153;
				case 5:
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateDeviceOperation.a(bluetoothPANNetworkBaseAddress, arge.DataProfilePeerIP))
					{
						num2 = (short)940572700;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 6:
					if (!string.IsNullOrEmpty(arge.DeviceSubscriberIP))
					{
						num2 = (short)1846607891;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_220;
				case 7:
					num2 = (short)975503361;
					if (num2 != 0)
					{
					}
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateDeviceOperation.a(bluetoothPANNetworkBaseAddress, arge.DataProfileAirInterfaceIP))
					{
						num2 = (short)1231814669;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4B0;
				case 8:
				{
					if (string.IsNullOrEmpty(arge.DeviceBluetoothDUNPeerIP))
					{
						goto IL_4FE;
					}
					num2 = (short)1548028994;
					short num3 = num2;
					num2 = (short)962399298;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5C3;
					default:
						num2 = (short)1596456960;
						if (num2 != 0)
						{
						}
						num2 = (short)1293811734;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
					goto IL_3D1;
				case 10:
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateDeviceOperation.a(bluetoothPANNetworkBaseAddress, arge.DevicePeerIP))
					{
						num2 = (short)1329070080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_197;
				case 11:
				{
					num2 = (short)124125184;
					short num4 = num2;
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateDeviceOperation.a(bluetoothPANNetworkBaseAddress, arge.DataProfileSubscriberIP))
					{
						num2 = (short)2016477214;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_263;
				}
				case 12:
					if (!string.IsNullOrEmpty(arge.DevicePeerIP))
					{
						num2 = (short)1665925136;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_197;
				case 13:
					goto IL_14E;
				case 14:
					goto IL_335;
				case 15:
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateDeviceOperation.a(bluetoothPANNetworkBaseAddress, arge.DeviceBluetoothDUNPeerIP))
					{
						num2 = (short)1786576931;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4FE;
				case 16:
					num2 = (short)863502346;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateDeviceOperation.a(bluetoothPANNetworkBaseAddress, arge.DeviceSubscriberIP))
					{
						num2 = (short)1263665161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_220;
				case 18:
					if (!string.IsNullOrEmpty(arge.BluetoothDUNSubscriberIP))
					{
						num2 = (short)344915992;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_153;
				case 19:
					num2 = (short)272957457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (!string.IsNullOrEmpty(arge.DataProfileSubscriberIP))
					{
						num2 = (short)614858783;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_263;
				case 21:
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateDeviceOperation.a(bluetoothPANNetworkBaseAddress, arge.BluetoothDUNPeerIP))
					{
						num2 = (short)1598816282;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5CC;
				case 22:
					num2 = (short)1847590927;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateDeviceOperation.a(bluetoothPANNetworkBaseAddress, arge.DeviceBluetoothDUNSubscriberIP))
					{
						num2 = (short)1759838222;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_420;
				case 24:
					num2 = (short)1376124932;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (!string.IsNullOrEmpty(arge.DeviceBluetoothDUNSubscriberIP))
					{
						num2 = (short)1084227611;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_420;
				case 26:
					goto IL_21B;
				case 27:
					num2 = (short)366739479;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					goto IL_2E7;
				case 29:
					goto IL_64C;
				case 30:
					goto IL_5B5;
				case 31:
					num2 = (short)1476395019;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					if (!string.IsNullOrEmpty(arge.DataProfileAirInterfaceIP))
					{
						num2 = (short)160825345;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4B0;
				case 33:
					num2 = (short)2127691781;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					num2 = (short)1846738965;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
					goto IL_38C;
				}
				goto IL_A0;
				IL_153:
				num2 = (short)1368719380;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_197:
				num2 = (short)272957465;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_220:
				num2 = (short)1259077644;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_263:
				num2 = (short)1002176544;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_420:
				num2 = (short)438108168;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4B0:
				num2 = (short)1853423619;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4FE:
				num2 = (short)699596818;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5CC:
				num2 = (short)163840002;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_14E:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_BluetoothPANNetworkBaseAddress;
			return false;
			IL_21B:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNPeerIP_NoSame_BluetoothPANNetworkBaseAddress;
			return false;
			IL_2E7:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfilePeerIP_NoSame_BluetoothPANNetworkBaseAddress;
			return false;
			IL_335:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_BluetoothPANNetworkBaseAddress;
			return false;
			IL_38C:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNPeerIP_NoSame_BluetoothPANNetworkBaseAddress;
			return false;
			IL_3D1:
			goto IL_5C3;
			IL_41E:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_PeerIP_NoSame_BluetoothPANNetworkBaseAddress;
			return false;
			IL_5B5:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_BluetoothPANNetworkBaseAddress;
			return false;
			IL_5C3:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubscriberIP_NoSame_BluetoothPANNetworkBaseAddress;
			return false;
			IL_64C:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNSubIP_NoSame_BluetoothPANNetworkBaseAddress;
			return false;
			IL_A0:
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)1608318982;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0005319C File Offset: 0x0005139C
		public override bool ValidataIPConflictLink2IPs(global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint arge, bool IsDVRSMSUOperation, string PeerIP_Link2, string SubscriberIP_Link2, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_9C;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_4CC;
				case 1:
					if (!string.IsNullOrEmpty(arge.DevicePeerIP))
					{
						num2 = (short)572129312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4CC;
				case 2:
					if (SubscriberIP_Link2 != null)
					{
						num2 = (short)642646038;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_29A;
				case 3:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_PeerIPLink2;
					num2 = (short)1711341575;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_PeerIP_NoSame_SubIPLink2;
					num2 = (short)1390346240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (IsDVRSMSUOperation)
					{
						num2 = (short)1269694482;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_553;
				case 6:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_SubIPLink2;
					num2 = (short)580714530;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_553;
				case 8:
					if (PeerIP_Link2.Trim().Equals(arge.DeviceSubscriberIP.Trim()))
					{
						num2 = (short)446824451;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_553;
				case 9:
					if (!string.IsNullOrEmpty(arge.DeviceSubscriberIP))
					{
						num2 = (short)240910365;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_29A;
				case 10:
					if (PeerIP_Link2 != null)
					{
						num2 = (short)2031812624;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_553;
				case 11:
					num2 = (short)1678508040;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)458358811;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 13:
				{
					num2 = (short)339410944;
					short num3 = num2;
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1448149011;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_29A;
				}
				case 14:
					goto IL_426;
				case 15:
					num2 = (short)1592328222;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					num2 = (short)1759969313;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					num2 = (short)6488089;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)1226702858;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					num2 = (short)1992491009;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (IsDVRSMSUOperation)
					{
						num2 = (short)956629020;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_29A;
				case 21:
					if (!string.IsNullOrEmpty(arge.DeviceSubscriberIP))
					{
						goto IL_44D;
					}
					goto IL_553;
				case 22:
					num2 = (short)615186433;
					if (num2 != 0)
					{
					}
					num2 = (short)1785266189;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					return result;
				case 24:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_PeerIP_NoSame_PeerIPLink2;
					num2 = (short)865271822;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (!string.IsNullOrEmpty(arge.DevicePeerIP))
					{
						num2 = (short)1145241615;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_426;
				case 26:
					if (SubscriberIP_Link2.Trim().Equals(arge.DeviceSubscriberIP.Trim()))
					{
						num2 = (short)117768198;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_29A;
				case 27:
					result = false;
					num2 = (short)1233387543;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
				{
					num2 = (short)416909421;
					short num4 = num2;
					num2 = (short)1795459181;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_44D;
					default:
						num2 = (short)193396736;
						if (num2 != 0)
						{
						}
						num2 = (short)179044354;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 29:
					num2 = (short)595787802;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					if (PeerIP_Link2.Trim().Equals(arge.DevicePeerIP.Trim()))
					{
						num2 = (short)469565464;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_426;
				case 31:
					if (SubscriberIP_Link2.Trim().Equals(arge.DevicePeerIP.Trim()))
					{
						num2 = (short)1489436676;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4CC;
				case 32:
					num2 = (short)1553268767;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1929773073;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_553;
				case 34:
					goto IL_29A;
				}
				goto IL_9C;
				IL_29A:
				num2 = (short)1730936844;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_426:
				num2 = (short)610992149;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_44D:
				num2 = (short)1552351243;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4CC:
				num2 = (short)595656713;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_553:
				num2 = (short)947453972;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_9C:
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			result = true;
			num2 = (short)1955004421;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00053788 File Offset: 0x00051988
		public override global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> GetLoadedASKWithoutDefault(bool isAttached = false)
		{
			short num = (short)2027101724;
			short num2 = num;
			num = (short)807542300;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1160380416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)420151296;
			if (num != 0)
			{
			}
			num = (short)1878327297;
			if (num != 0)
			{
			}
			return new global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>(global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().LoadedASKs(isAttached).Where(delegate(global::ASK.Interface.ISystemKeyData item)
			{
				short num4 = (short)1022572792;
				short num5 = num4;
				num4 = (short)273627384;
				switch (num5 == num4)
				{
				}
				num4 = (short)1986330624;
				if (num4 != 0)
				{
				}
				num4 = (short)1167130624;
				short num6 = num4;
				num4 = (short)1788936193;
				if (num4 != 0)
				{
				}
				return item.SystemID != 1;
			}).ToList<global::ASK.Interface.ISystemKeyData>());
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00053870 File Offset: 0x00051A70
		public override global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> GetLoadedASKWithDefault(bool isAttached = false)
		{
			short num = (short)262487308;
			short num2 = num;
			num = (short)1770667276;
			switch (num2 == num)
			{
			default:
			{
				num = (short)511967232;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2106851329;
			if (num != 0)
			{
			}
			num = (short)2068447232;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().LoadedASKs(isAttached);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00053924 File Offset: 0x00051B24
		public override void ResetRegionWithAppRegion(global::Motorola.CommonCPS.Server.EntityModel.Radio d)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? defaultRegion;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_40:
					if (defaultRegion != null)
					{
						num2 = (short)232718338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AB;
				case 1:
					goto IL_AB;
				case 2:
				{
					num2 = (short)1030619136;
					short num3 = num2;
					d.RegionName = defaultRegion;
					num2 = (short)1902510081;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
				IL_AB:
				num2 = (short)603303634;
				short num4 = num2;
				num2 = (short)1095872210;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_40;
				default:
					goto IL_E1;
				}
			}
			IL_E1:
			num2 = (short)473759744;
			if (num2 != 0)
			{
			}
			num2 = (short)2128019457;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			defaultRegion = global::Motorola.CommonCPS.RadioManagement.SharedServices.RegistryAndSettingProxy.GetInstance().RegistryAndSetting.GetDefaultRegion();
			num2 = (short)1256456192;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00053A50 File Offset: 0x00051C50
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_0, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware A_1, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData A_2)
		{
			int a_ = 14;
			short num = (short)206831616;
			switch (num)
			{
			default:
			{
				num = (short)1916993539;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML multipleFieldsXML;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)668991491;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue;
									nameAndValue.Value = A_1.DspVersion;
									num = (short)898564128;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									if (!string.IsNullOrEmpty(A_1.MaceFlashVersion))
									{
										num = (short)1651507222;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_729;
								case 2:
								{
									global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue;
									if (nameAndValue.Name == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욦춨쎬즮\udeb0킴\ud9b6\udcb8즺\udcbc펾铀胂裄釆곈맊뻌ꛎ뻐뷒諔雖", a_))
									{
										num = (short)294715421;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_729;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_2B7;
									}
									continue;
								case 6:
									num = (short)1286930456;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (!string.IsNullOrEmpty(A_1.LTEOptBrdHwHostVersion))
									{
										num = (short)284950539;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55D;
								case 8:
								{
									global::System.Collections.Generic.Dictionary<string, object> dictionary;
									if (!string.IsNullOrEmpty(dictionary[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욦춨쎬즮\udeb0ﲲ어쎶킸풺펼諭맀돂꓄꧆뫈ꋊꋌꇎ鏐볒듔ꗖ뷘駚닜뻞鏠蟢ꯤ蛦蓨軪달껮싰쓲샴쏶샸", a_)].ToString()))
									{
										num = (short)437256222;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::System.Collections.Generic.Dictionary<string, object> dictionary;
									if (!string.Equals(dictionary[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욦춨쎬즮\udeb0ﲲ어쎶킸풺펼諭맀돂꓄꧆뫈ꋊꋌꇎ鏐볒듔ꗖ뷘駚닜뻞鏠蟢ꯤ蛦蓨軪달껮싰쓲샴쏶샸", a_)].ToString(), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("", a_), global::System.StringComparison.Ordinal))
									{
										num = (short)113573894;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue;
									if (nameAndValue.Name == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욦춨쎬즮\udeb0ﲲ어쎶킸풺펼諭맀돂꓄꧆뫈ꋊꋌꇎ鏐볒듔ꗖ뷘駚닜뻞鏠蟢ꏤ軦鯨蛪髬軮菰雲ꏴ鋶诸裺铼郾漀専䐄㐆㸈㬊㤌㜎", a_))
									{
										num = (short)176029713;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
								{
									global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue;
									nameAndValue.Value = A_1.LTEOptBrdHwHostVersion;
									num = (short)914096143;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue;
									if (nameAndValue.Name == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욦춨쎬즮\udeb0킴\ud9b6\udcb8즺\udcbc펾釀郂臄鏆鿈껊뿌볎룐볒믔裖飘\ud9e0", a_))
									{
										num = (short)670629913;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_33A;
								}
								case 13:
									num = (short)510328858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue;
									if (nameAndValue.Name == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욦춨쎬즮\udeb0킴\ud9b6\udcb8즺\udcbc펾藀郂闄釆곈맊뻌ꛎ뻐뷒諔雖", a_))
									{
										num = (short)1065680924;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_415;
								}
								case 17:
									num = (short)19005471;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
								{
									global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue;
									nameAndValue.Value = A_1.OptBrdHwHostVersion;
									num = (short)2068578320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
									if (!string.IsNullOrEmpty(A_1.PsdtVersion))
									{
										num = (short)2060714011;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_33A;
								case 20:
									if (!string.IsNullOrEmpty(A_1.DspVersion))
									{
										num = (short)1165492224;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_415;
								case 21:
									num = (short)134283271;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
								{
									global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue;
									nameAndValue.Value = A_1.MaceFlashVersion;
									num = (short)94699524;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 23:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1536557069;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue = enumerator.Current;
									num = (short)492437516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 24:
									if (!string.IsNullOrEmpty(A_1.OptBrdHwHostVersion))
									{
										num = (short)1621491730;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 25:
									num = (short)442826771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									goto IL_7C5;
								case 27:
								{
									global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue;
									nameAndValue.Value = A_1.PsdtVersion;
									num = (short)1764425733;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 28:
									num = (short)85786644;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
									num = (short)122290177;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
									num = (short)1311244298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
								{
									global::System.Collections.Generic.Dictionary<string, object> dictionary;
									if (string.Equals(dictionary[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욦춨쎬즮\udeb0ﲲ어쎶킸풺펼諭맀돂꓄꧆뫈ꋊꋌꇎ鏐볒듔ꗖ뷘駚닜뻞鏠蟢ꯤ蛦蓨軪달껮싰쓲샴쏶샸", a_)].ToString(), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("", a_), global::System.StringComparison.Ordinal))
									{
										num = (short)1076363285;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55D;
								}
								}
								goto IL_2B7;
								IL_33A:
								num = (short)749207566;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3D2:
								num = (short)1182531607;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2B7:
								goto IL_3D2;
								IL_415:
								num = (short)1873084418;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_55D:
								num = (short)912326665;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_729:
								num = (short)67108872;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7C5:
							goto IL_174;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						return;
					case 1:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>.Enumerator enumerator = multipleFieldsXML.NameAndValueList.GetEnumerator();
						num = (short)1578041344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (multipleFieldsXML != null)
						{
							num = (short)86900743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_3D;
					case 4:
					{
						num = (short)1433091350;
						short num3 = num;
						num = (short)1552694550;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3D;
						default:
							num = (short)269680641;
							if (num != 0)
							{
							}
							num = (short)1304690688;
							if (num != 0)
							{
							}
							multipleFieldsXML = global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML.DeserializeFromXML(A_0.DeviceInfoFields);
							num = (short)905510914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
					{
						global::System.Collections.Generic.Dictionary<string, object> dictionary;
						if (dictionary != null)
						{
							num = (short)1593966593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_174;
					}
					case 6:
						return;
					case 7:
					{
						global::System.Collections.Generic.Dictionary<string, object> dictionary = multipleFieldsXML.ConvertToDictionary();
						num = (short)2024407045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6E;
					IL_3D:
					switch (0)
					{
					case 0:
						IL_6E:
						if (string.IsNullOrEmpty(A_0.DeviceInfoFields))
						{
							return;
						}
						num = (short)1423572996;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_174:
					num = (short)328663040;
					short num4 = num;
					A_2.DeviceInfoFields = multipleFieldsXML.SerializeToXML(true);
					num = (short)1598554118;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00054254 File Offset: 0x00052454
		private static void d(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_1)
		{
			short num = (short)1293484033;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0.WorkingCodeplug.Template != null)
					{
						num = (short)496566272;
						short num3 = num;
						num = (short)211288068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 2:
				{
					global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey matrixOTAPKey;
					if (matrixOTAPKey != null)
					{
						num = (short)1717960707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
				{
					A_1.OTAPKeys.Clear();
					global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey matrixOTAPKey;
					A_1.OTAPKeys.Add(matrixOTAPKey);
					num = (short)1923547142;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)1060381508;
					short num4 = num;
					num = (short)2084512580;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_85;
					default:
					{
						num = (short)1559887872;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey matrixOTAPKey = (A_0.WorkingCodeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate).MatrixOTAPKey;
						num = (short)1699086338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					goto IL_85;
				case 6:
					return;
				}
				IL_40:
				num = (short)457179137;
				if (num != 0)
				{
				}
				if (A_0.WorkingCodeplug != null)
				{
					num = (short)177340421;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_85:
				num = (short)772538368;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00054428 File Offset: 0x00052628
		private static void c(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_1)
		{
			short num = (short)612892673;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0.WorkingCodeplug.Template != null)
					{
						num = (short)1718091776;
						short num3 = num;
						num = (short)1575485444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 2:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey> matrixPrivacyKeys;
					if (matrixPrivacyKeys != null)
					{
						num = (short)763297795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey> matrixPrivacyKeys;
					A_1.PrivacyKeys = matrixPrivacyKeys;
					num = (short)86573057;
					if (num != 0)
					{
					}
					num = (short)953745414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)1744717721;
					short num4 = num;
					num = (short)473843609;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
					{
						num = (short)59310080;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey> matrixPrivacyKeys = (A_0.WorkingCodeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate).MatrixPrivacyKeys;
						num = (short)1337262082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					goto IL_60;
				case 6:
					return;
				}
				IL_40:
				if (A_0.WorkingCodeplug != null)
				{
					num = (short)1651834885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_60:
				num = (short)1990918144;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000545F4 File Offset: 0x000527F4
		private static void b(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_1)
		{
			short num = (short)2146107393;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0.WorkingCodeplug.Template != null)
					{
						num = (short)464191488;
						short num3 = num;
						num = (short)525795332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					num = (short)2063597569;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 2:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey> matrixRASKeys;
					if (matrixRASKeys != null)
					{
						num = (short)323551235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey> matrixRASKeys;
					A_1.RASKeys = matrixRASKeys;
					num = (short)163971078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)1619067986;
					short num4 = num;
					num = (short)165807186;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_85;
					default:
					{
						num = (short)492896256;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey> matrixRASKeys = (A_0.WorkingCodeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate).MatrixRASKeys;
						num = (short)876019714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					goto IL_85;
				case 6:
					return;
				}
				IL_66:
				if (A_0.WorkingCodeplug != null)
				{
					num = (short)1884553221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_85:
				num = (short)1721106432;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000547B0 File Offset: 0x000529B0
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_1)
		{
			short num = (short)1151533057;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0.WorkingCodeplug.Template != null)
					{
						num = (short)301203460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 2:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey> matrixSymmetricKeys;
					if (matrixSymmetricKeys != null)
					{
						num = (short)1987837955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey> matrixSymmetricKeys;
					A_1.SymmetricKeys = matrixSymmetricKeys;
					num = (short)730202118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)842465280;
					short num3 = num;
					num = (short)5080889;
					short num4 = num;
					num = (short)67536697;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
					{
						num = (short)1371275265;
						if (num != 0)
						{
						}
						num = (short)1677590528;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey> matrixSymmetricKeys = (A_0.WorkingCodeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate).MatrixSymmetricKeys;
						num = (short)1520500738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					goto IL_60;
				case 6:
					return;
				}
				IL_41:
				if (A_0.WorkingCodeplug != null)
				{
					num = (short)1200357381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_60:
				num = (short)1341652992;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00054974 File Offset: 0x00052B74
		private static void a(string A_0, string A_1, out global::System.Xml.XmlNode A_2, out global::System.Xml.XmlNode A_3)
		{
			int a_ = 15;
			short num = (short)2119041024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				global::System.Xml.XmlDocument xmlDocument;
				global::System.Xml.XmlDocument xmlDocument2;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						goto IL_2C3;
					case 1:
						goto IL_20F;
					case 2:
						goto IL_20F;
					case 3:
						xmlDocument.LoadXml(A_0);
						num = (short)1174470656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_2C3;
					case 5:
						return;
					case 6:
					{
						if (A_0.Contains(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﲧ蝹", a_)))
						{
							num = (short)850919427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string xml = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("骥ﺩﺿ", a_) + A_0 + global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("骥螧钿ﳁ", a_);
						xmlDocument.LoadXml(xml);
						num = (short)952238084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (!A_2.Name.Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﲧ蝹", a_)))
						{
							num = (short)1599012873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18C;
					case 8:
					{
						if (!A_1.Contains(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﲧ蝹", a_)))
						{
							string xml2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("骥ﺩﺿ", a_) + A_1 + global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("骥螧钿ﳁ", a_);
							xmlDocument2.LoadXml(xml2);
							num = (short)664272898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1811825151;
						short num3 = num;
						num = (short)1868710399;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2A6;
						default:
						{
							num = (short)1517420544;
							short num4 = num;
							num = (short)941621248;
							if (num != 0)
							{
							}
							num = (short)17039371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 9:
						A_2 = A_2.SelectSingleNode(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("覥螧钿", a_));
						num = (short)1584463884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						A_3 = A_3.SelectSingleNode(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("覥螧钿", a_));
						num = (short)316145669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						xmlDocument2.LoadXml(A_1);
						goto IL_2A6;
					case 12:
						goto IL_18C;
					case 13:
						if (!A_3.Name.Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﲧ蝹", a_)))
						{
							num = (short)1951072266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_70;
					IL_18C:
					A_3 = xmlDocument2.DocumentElement;
					num = (short)2018312205;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20F:
					A_2 = xmlDocument.DocumentElement;
					num = (short)110493703;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A6:
					num = (short)1118109697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C3:
					num = (short)2068250625;
					if (num != 0)
					{
					}
					num = (short)494927880;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_70:
				xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument2 = new global::System.Xml.XmlDocument();
				num = (short)735444998;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00054D34 File Offset: 0x00052F34
		private static bool a(string bluetoothPANNetworkBaseAddress, string address)
		{
			int a_ = 2;
			short num = (short)1961623552;
			switch (num)
			{
			default:
			{
				num = (short)1609498627;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (address == null)
						{
							num = (short)2086207490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1405616129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_93;
					case 2:
						goto IL_C4;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 4:
						num = (short)246611968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_61:
					if (bluetoothPANNetworkBaseAddress == null)
					{
						goto IL_C8;
					}
					num = (short)833683460;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_93:
				bool result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_125;
					}
					int num3;
					string[] array;
					for (;;)
					{
						IL_FE:
						switch (num2)
						{
						case 0:
							goto IL_150;
						case 1:
						{
							string text;
							if (address.Trim().Equals(text.Trim()))
							{
								num = (short)1184104452;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num3++;
							num = (short)816578560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_150;
						case 3:
							goto IL_2E8;
						case 4:
							result = true;
							num = (short)324468743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)571277315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							if (num3 > 10)
							{
								num = (short)1413993811;
								short num4 = num;
								num = (short)889181523;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)436469760;
									if (num != 0)
									{
									}
									num = (short)1669595141;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
							}
							string text = string.Concat(new string[]
							{
								array[0],
								global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("래", a_),
								array[1],
								global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("래", a_),
								array[2],
								global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("래", a_),
								(global::System.Convert.ToInt32(array[3], global::System.Globalization.CultureInfo.CurrentCulture) + num3).ToString(global::System.Globalization.CultureInfo.CurrentCulture)
							});
							num = (short)1339228161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_1EF;
						}
						goto IL_125;
						IL_150:
						num = (short)550109190;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1EF:
					goto IL_2F3;
					IL_2E8:
					return false;
					IL_125:
					array = bluetoothPANNetworkBaseAddress.Split(new char[]
					{
						'.'
					});
					num3 = 0;
					num = (short)199491586;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_FE;
				}
				catch
				{
					result = true;
				}
				IL_2F3:
				num = (short)1075773441;
				if (num != 0)
				{
				}
				return result;
				IL_C4:
				IL_C8:
				num = (short)933625856;
				short num5 = num;
				return false;
			}
			}
		}
	}
}
