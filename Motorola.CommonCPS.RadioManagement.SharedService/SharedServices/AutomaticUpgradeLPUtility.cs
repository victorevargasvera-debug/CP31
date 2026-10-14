using System;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000B2 RID: 178
	public class AutomaticUpgradeLPUtility
	{
		// Token: 0x06000A71 RID: 2673 RVA: 0x0007EA0C File Offset: 0x0007CC0C
		public static bool ValidateLanguagePackForApplyTemplateToRadio(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxTemplate, string radioFirmwareVer)
		{
			int a_ = 13;
			short num = (short)915472384;
			switch (num)
			{
			default:
			{
				num = (short)1120403467;
				int num2 = (int)((global::System.IntPtr)num);
				string text;
				for (;;)
				{
					global::System.Text.RegularExpressions.Match match;
					string text2;
					switch (num2)
					{
					case 0:
					{
						if (global::Motorola.Common.Communication.CommonUtil.ModelNumber.IsAmp(apxTemplate.ModelNumber))
						{
							num = (short)346357765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = ((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).AstroDecodeLanguageIndexToLPID(apxTemplate.LanguageIndex);
						num = (short)1679972361;
						short num3 = num;
						num = (short)306468873;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B5;
						default:
							num = (short)1138425856;
							if (num != 0)
							{
							}
							num = (short)1466171408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						int? languageIndex = apxTemplate.LanguageIndex;
						int num4 = 0;
						num = (short)232128531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1122304012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (apxTemplate.ASTROLanguagePack != null)
						{
							num = (short)1558183940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1289879574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1152909321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return true;
					case 6:
						goto IL_255;
					case 7:
						if (match.Success)
						{
							num = (short)673972245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 8:
						if (global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().CheckIsSupportedLanguagePack(radioFirmwareVer, apxTemplate.LanguageIndex, ref text2))
						{
							num = (short)856948742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 9:
						if (!string.Equals(apxTemplate.ASTROLanguagePack.LpID, text, global::System.StringComparison.CurrentCultureIgnoreCase))
						{
							num = (short)1080950799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)405078034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_4E6;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_B4;
						}
						continue;
					case 12:
						if (global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().IsNeedBindingServerLanguagePack(radioFirmwareVer))
						{
							num = (short)1529282574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_264;
					case 13:
						goto IL_48F;
					case 14:
						goto IL_44E;
					case 15:
						goto IL_2FA;
					case 16:
						if (((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).CheckIsSupportedLanguagePack(radioFirmwareVer, apxTemplate.LanguageIndex))
						{
							num = (short)1808924673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1540358161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (apxTemplate.ASTROLanguagePack != null)
						{
							num = (short)1738145805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B5;
					case 18:
						if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().CheckAstroFWIsSupportedCurrentLanguagePack(radioFirmwareVer, apxTemplate.ASTROLanguagePack.CompatibleVersion, apxTemplate.LanguageIndex))
						{
							num = (short)1473904650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 19:
					{
						int? languageIndex;
						int num4;
						if (languageIndex.GetValueOrDefault() == num4 & languageIndex != null)
						{
							num = (short)1564409879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)680460291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (match.Success)
						{
							num = (short)2142240770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_264;
					case 21:
						num = (short)1131216904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)238747649;
						if (num != 0)
						{
						}
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1645150233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 23:
						return true;
					case 24:
						goto IL_D3;
					case 25:
						goto IL_14A;
					}
					IL_B4:
					if (apxTemplate == null)
					{
						num = (short)2117140504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1536491520;
					short num5 = num;
					num = (short)758579200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B5:
					match = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("貣瘟첧膩肭횱龳隷\ud8bb閽", a_)).Match(radioFirmwareVer);
					num = (short)1377239060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_264:
					text2 = null;
					num = (short)58130439;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D3:
				throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_TemplateNotExist, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_TemplateNotExist, null);
				IL_14A:
				throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.AstroPost7_12Radio_Need_TemplateContainLP, new string[]
				{
					text
				}));
				IL_255:
				throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateDirectMessageCommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_LP_Not_Supported_By_this_radio);
				IL_2FA:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_AstroLanguagePackMismatch);
				IL_44E:
				throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateDirectMessageCommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_LP_Not_Supported_By_this_radio);
				IL_48F:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_LP_Not_Supported_By_this_radio);
				IL_4E6:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CannotApplyTemplateWithLP_To_ImcompatibleDevice);
			}
			}
		}
	}
}
