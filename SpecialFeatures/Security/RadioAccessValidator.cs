using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using AcpASKLib;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpSecurityLib;
using CommonResources;
using Motorola.Common.Communication.CommonUtil;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.Security
{
	// Token: 0x02000050 RID: 80
	public static class RadioAccessValidator
	{
		// Token: 0x060007FF RID: 2047 RVA: 0x000818FC File Offset: 0x0007FAFC
		public static bool IsHardwareAskLoaded(int currentTrkSysId, global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> loadedHardwareAdvancedKeys)
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
				{
					if (currentTrkSysId == 1)
					{
						num2 = (short)1432354819;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)405864448;
					short num3 = num2;
					num2 = (short)2055798786;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_D2;
				case 2:
					if (loadedHardwareAdvancedKeys != null)
					{
						num2 = (short)245235713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_125;
				case 3:
					return false;
				}
				goto IL_20;
			}
			return false;
			IL_D2:
			num2 = (short)1727225488;
			short num4 = num2;
			num2 = (short)558718608;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			default:
				num2 = (short)1670250496;
				if (num2 != 0)
				{
				}
				return loadedHardwareAdvancedKeys.Any(delegate(global::AcpASKLib.SystemKeyData s)
				{
					short num5 = (short)1783758849;
					int num6 = (int)((global::System.IntPtr)num5);
					for (;;)
					{
						switch (num6)
						{
						case 0:
							goto IL_136;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_35;
							}
							continue;
						case 2:
							if (s.SystemID == currentTrkSysId)
							{
								num5 = (short)1974992896;
								num6 = (int)((global::System.IntPtr)num5);
								continue;
							}
							return false;
						case 3:
							goto IL_F9;
						}
						IL_35:
						if (s == null)
						{
							return false;
						}
						num5 = (short)428343297;
						if (num5 != 0)
						{
						}
						num5 = (short)108722554;
						short num7 = num5;
						num5 = (short)86047098;
						switch ((num7 == num5) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num5 = (short)1560608768;
							if (num5 != 0)
							{
							}
							num5 = (short)2071330819;
							num6 = (int)((global::System.IntPtr)num5);
							continue;
						}
						IL_F9:
						num5 = (short)1696464898;
						num6 = (int)((global::System.IntPtr)num5);
					}
					IL_136:
					num5 = (short)93650944;
					short num8 = num5;
					return s.Type == global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
				});
			}
			IL_125:
			num2 = (short)2069037057;
			if (num2 != 0)
			{
			}
			return false;
			IL_20:
			num2 = (short)1814429696;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00081A58 File Offset: 0x0007FC58
		public static bool RadioWriteSecurityCheck(global::SpecialFeatures.Comms.COMMS_OP WriteType, global::SpecialFeatures.Security.RadioSecurityData radSecData, global::Motorola.Common.Communication.CommonUtil.IshItemCollection progHistoryItems, global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysBandPlan> radioTrkShuffledBandPlans, out string stsMsg, bool writeProtectWriteProtectedRadio = false, bool otapBatchProgramming = false, bool updateWriteProtect = false)
		{
			short num = (short)1179975680;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool result;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
							return result;
						case 1:
						{
							num = (short)1981939712;
							short num3 = num;
							global::SpecialFeatures.Security.RadioSecurityData cpgSecData = global::SpecialFeatures.Security.RadioAccessValidator.d();
							global::SpecialFeatures.Security.RadioAccessValidatorBase radioAccessValidatorBase = new global::SpecialFeatures.Security.CPSRadioAccessValidator(WriteType, radSecData, cpgSecData, progHistoryItems, radioTrkShuffledBandPlans, writeProtectWriteProtectedRadio, otapBatchProgramming, false);
							global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> collection = null;
							bool? flag = null;
							result = radioAccessValidatorBase.Validate(out stsMsg, ref collection, ref flag);
							num = (short)1130965293;
							short num4 = num;
							num = (short)1525426477;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_40;
							default:
								num = (short)1321009152;
								if (num != 0)
								{
								}
								num = (short)1207566337;
								if (num != 0)
								{
								}
								num = (short)1126891520;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							if (!updateWriteProtect)
							{
								num = (short)1208942593;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						goto IL_3A;
					}
					return result;
				}
				IL_3A:
				stsMsg = null;
				result = true;
				IL_40:
				num = (short)292225026;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00081BC0 File Offset: 0x0007FDC0
		internal static bool FileCloneSerialNumberEditabilityCheck()
		{
			short num = (short)924647424;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3F;
				}
				bool result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						if (global::AcpSecurityLib.SecurityManager.IsSpecialKeyLoaded)
						{
							num = (short)1226309635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1951137793;
						if (num != 0)
						{
						}
						bool flag = true;
						bool flag2 = false;
						global::SpecialFeatures.Security.RadioSecurityData cpgSecData = global::SpecialFeatures.Security.RadioAccessValidator.d();
						bool flag3;
						bool flag4;
						result = new global::SpecialFeatures.Security.CPSRadioAccessValidator(global::SpecialFeatures.Comms.CloneParameters.CloneWriteType, null, cpgSecData, null, null, false, false, false).CheckIfAllMatchingSysKeyAreLoaded(ref flag, ref flag2, out flag3, out flag4);
						num = (short)7606366;
						short num3 = num;
						num = (short)1562185822;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1804992512;
							if (num != 0)
							{
							}
							num = (short)1484390400;
							short num4 = num;
							num = (short)1097072642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						return result;
					case 2:
						return result;
					case 3:
						result = true;
						num = (short)1139736577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F;
				}
				return result;
				IL_3F:
				result = false;
				num = (short)525467648;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00081D44 File Offset: 0x0007FF44
		internal static global::SpecialFeatures.Security.ProtectionOption GetProtectionOption(string modelNumber, string flashCode, bool fromCodeplug)
		{
			int a_ = 12;
			short num = (short)1151860736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				global::SpecialFeatures.Security.ProtectionOption result;
				for (;;)
				{
					IL_31:
					global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
					bool flag5;
					switch (num2)
					{
					case 0:
						goto IL_303;
					case 1:
						if (modelNumber != null)
						{
							num = (short)998703109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						if (modelNumber.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잎", a_)))
						{
							num = (short)647168004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_303;
					case 3:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_C6;
							}
							bool flag;
							bool flag2;
							for (;;)
							{
								IL_93:
								switch (num2)
								{
								case 0:
									goto IL_192;
								case 1:
									goto IL_241;
								case 2:
									num = (short)1714159621;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1B1;
								case 4:
									num = (short)355729416;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (!flag)
									{
										num = (short)1865744394;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_226;
								case 6:
									if (flag)
									{
										num = (short)1624965124;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1EC;
								case 7:
									result = global::SpecialFeatures.Security.ProtectionOption.HARDWARE;
									num = (short)1702297603;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (!flag2)
									{
										num = (short)660602887;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1EC;
								case 9:
									if (flag2)
									{
										num = (short)739835906;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_226;
								case 10:
									result = global::SpecialFeatures.Security.ProtectionOption.LEGACY_SW;
									num = (short)575930368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_C6;
								IL_1EC:
								num = (short)1514864649;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_226:
								result = global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED;
								num = (short)1467219969;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_192:
							IL_1B1:
							IL_241:
							return result;
							IL_C6:
							flashcodeTable.InitTable(fromCodeplug, modelNumber, false);
							bool flag3 = false;
							bool flag4 = false;
							flag = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8e킐ꎒ꒔ꆖ궘ꎚ", a_), flashCode, ref flag3);
							flag2 = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8e킐ꎒ꒔ꂖ궘ꊚ", a_), flashCode, ref flag4);
							num = (short)1154088966;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_93;
						}
						finally
						{
							num = (short)1910374402;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_300;
								case 1:
									((global::System.IDisposable)flashcodeTable).Dispose();
									num = (short)1344798720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_27A;
									}
									continue;
								}
								IL_27A:
								if (flashcodeTable == null)
								{
									break;
								}
								num = (short)1663774127;
								short num3 = num;
								num = (short)450178479;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_300;
								default:
									num = (short)582156288;
									if (num != 0)
									{
									}
									num = (short)1158414337;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_300:;
						}
						goto IL_303;
					case 4:
						flag5 = false;
						num = (short)1167720449;
						if (num != 0)
						{
						}
						num = (short)1129119744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)7143424;
						short num4 = num;
						flag5 = true;
						num = (short)1253965826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_50;
					IL_303:
					flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable(!flag5, true);
					num = (short)263979011;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_50:
				result = global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED;
				num = (short)2096824321;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0008215C File Offset: 0x0008035C
		internal static global::SpecialFeatures.Security.ProtectionOption GetCodeplugProtectionOption()
		{
			short num = (short)1495793664;
			short num2 = num;
			num = (short)236397259;
			short num3 = num;
			num = (short)132588235;
			switch (num3 == num)
			{
			}
			num = (short)717225985;
			if (num != 0)
			{
			}
			num = (short)1393164288;
			if (num != 0)
			{
			}
			string modelNumber = global::SpecialFeatures.Security.RadioAccessValidator.c();
			string flashCode = global::SpecialFeatures.Security.RadioAccessValidator.b();
			return global::SpecialFeatures.Security.RadioAccessValidator.GetProtectionOption(modelNumber, flashCode, true);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00082218 File Offset: 0x00080418
		private static global::SpecialFeatures.Security.RadioSecurityData d()
		{
			short num = (short)1484849152;
			short num2 = num;
			num = (short)1132724225;
			if (num != 0)
			{
			}
			num = (short)1904545098;
			short num3 = num;
			num = (short)1328418122;
			switch (num3 == num)
			{
			}
			num = (short)1620115456;
			if (num != 0)
			{
			}
			int advKeyType = 0;
			int ownerSystemId = 0;
			int ownerWacnId = 0;
			bool bASKRequired = false;
			bool bConvnOnly = global::SpecialFeatures.Security.RadioAccessValidator.IsCpgConvOnly();
			global::SpecialFeatures.Security.ProtectionOption codeplugProtectionOption = global::SpecialFeatures.Security.RadioAccessValidator.GetCodeplugProtectionOption();
			if (codeplugProtectionOption == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
			{
				advKeyType = global::SpecialFeatures.Security.RadioAccessValidator.GetCodeplugOwnerKeyType();
				ownerWacnId = global::SpecialFeatures.Security.RadioAccessValidator.GetCodeplugOwnerWACNID();
				ownerSystemId = global::SpecialFeatures.Security.RadioAccessValidator.GetCodeplugOwnerSystemID();
				bASKRequired = global::SpecialFeatures.Security.RadioAccessValidator.GetCodeplugASKRequiredFlag();
			}
			bool bWriteProtected = global::SpecialFeatures.Security.RadioAccessValidator.a();
			return new global::SpecialFeatures.Security.RadioSecurityData(codeplugProtectionOption, advKeyType, ownerSystemId, ownerWacnId, bASKRequired, bWriteProtected, bConvnOnly, null, null);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0008230C File Offset: 0x0008050C
		private static string c()
		{
			short num = (short)223489377;
			short num2 = num;
			num = (short)991571297;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1636171777;
				if (num != 0)
				{
				}
				num = (short)864550912;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
				if (radioInformation != null)
				{
					return radioInformation.General.RadInfoGeneralModelNumber_A8539.ToString();
				}
				break;
			}
			}
			num = (short)764739584;
			short num3 = num;
			return string.Empty;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000823E4 File Offset: 0x000805E4
		private static string b()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			string result;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132Value;
					num2 = (short)1741029376;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1252040233;
					short num3 = num2;
					num2 = (short)288136745;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1086324736;
						if (num2 != 0)
						{
						}
						if (radioInformation != null)
						{
							num2 = (short)531562497;
							if (num2 != 0)
							{
							}
							num2 = (short)265355264;
							short num4 = num2;
							num2 = (short)2007891969;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = string.Empty;
			radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
			num2 = (short)1833172994;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00082520 File Offset: 0x00080720
		internal static int GetCodeplugOwnerKeyType()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			int result;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663Value;
					num2 = (short)1343881216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1312757873;
					short num3 = num2;
					num2 = (short)1138038897;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1906835457;
						if (num2 != 0)
						{
						}
						num2 = (short)340656128;
						if (num2 != 0)
						{
						}
						if (radioWide != null)
						{
							num2 = (short)600965120;
							short num4 = num2;
							num2 = (short)1808007169;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = 0;
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1874919426;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0008265C File Offset: 0x0008085C
		internal static int GetCodeplugOwnerSystemID()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			int result;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
				{
					num2 = (short)426049536;
					short num3 = num2;
					result = radioWide.General.RadWideGeneralOwnerSystemID_A37153Value;
					num2 = (short)2132410369;
					if (num2 != 0)
					{
					}
					num2 = (short)414056448;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)256123378;
					short num4 = num2;
					num2 = (short)1800086002;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)2093416448;
						if (num2 != 0)
						{
						}
						if (radioWide != null)
						{
							num2 = (short)1221722113;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = 0;
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1242300418;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00082798 File Offset: 0x00080998
		internal static int GetCodeplugOwnerWACNID()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			int result;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = radioWide.General.RadWideGeneralOwnerWACNID_A38656Value;
					num2 = (short)338231296;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1936820003;
					short num3 = num2;
					num2 = (short)40797987;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)239992833;
						if (num2 != 0)
						{
						}
						num2 = (short)470482944;
						if (num2 != 0)
						{
						}
						if (radioWide != null)
						{
							num2 = (short)1356922880;
							short num4 = num2;
							num2 = (short)254214145;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = 0;
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)887619586;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000828D0 File Offset: 0x00080AD0
		internal static bool GetCodeplugASKRequiredFlag()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = radioWide.General.RadWideGeneralASKRequired_A37152Value;
					num2 = (short)323747840;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)593362945;
					if (num2 != 0)
					{
					}
					num2 = (short)2006070289;
					short num3 = num2;
					num2 = (short)1709716497;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)43450368;
						if (num2 != 0)
						{
						}
						if (radioWide != null)
						{
							num2 = (short)1469906944;
							short num4 = num2;
							num2 = (short)1866596353;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = true;
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1830879234;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00082A04 File Offset: 0x00080C04
		private static bool a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = radioWide.Depot.AdvancedExternalMicOnlyValue;
					num2 = (short)426704896;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1956933864;
					short num3 = num2;
					num2 = (short)1980264680;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)685768704;
						if (num2 != 0)
						{
						}
						if (radioWide != null)
						{
							num2 = (short)831913984;
							short num4 = num2;
							num2 = (short)752549889;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = false;
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1823080449;
			if (num2 != 0)
			{
			}
			num2 = (short)554237954;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00082B3C File Offset: 0x00080D3C
		internal static bool IsCpgConvOnly()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			bool result;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset radioInformationRecset;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = false;
					num2 = (short)157155330;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (radioInformationRecset != null)
					{
						num2 = (short)752877573;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					goto IL_D2;
				case 4:
				{
					bool value = ((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation)radioInformationRecset[0]).Labtool.RadInfoLabtoolH37G50Smartnet_A8184.Value;
					bool value2 = ((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation)radioInformationRecset[0]).Labtool.RadInfoLabtoolH38G51Smartzone_A8185.Value;
					if (!value && !value2)
					{
						result = true;
						num2 = (short)359675182;
						short num3 = num2;
						num2 = (short)1921922350;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1373700096;
							if (num2 != 0)
							{
							}
							num2 = (short)1043398659;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
					}
					num2 = (short)60424192;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
				{
					num2 = (short)876347392;
					short num4 = num2;
					num2 = (short)767164420;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_28;
			}
			IL_D2:
			num2 = (short)470614017;
			if (num2 != 0)
			{
			}
			return result;
			IL_28:
			result = false;
			radioInformationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2049) as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset);
			num2 = (short)89980929;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00082D00 File Offset: 0x00080F00
		public static bool IsConvOnly(string modelNumber, string flashCode, bool fromCodeplug)
		{
			int a_ = 1;
			short num = (short)341966848;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				bool result;
				bool flag5;
				for (;;)
				{
					IL_30:
					global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
					switch (num2)
					{
					case 0:
						goto IL_2D9;
					case 1:
						if (modelNumber != null)
						{
							num = (short)2139750405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						if (modelNumber.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첃", a_)))
						{
							num = (short)480182276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D9;
					case 3:
					{
						num = (short)365494272;
						short num3 = num;
						try
						{
							switch (0)
							{
							case 0:
								goto IL_B9;
							}
							bool flag2;
							bool flag;
							bool flag4;
							bool flag3;
							for (;;)
							{
								IL_92:
								switch (num2)
								{
								case 0:
									goto IL_217;
								case 1:
									result = false;
									num = (short)1108213765;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									flag = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃뎅뢇", a_), flashCode, ref flag2);
									flag3 = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃뎅릇", a_), flashCode, ref flag4);
									num = (short)444399620;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (flag5)
									{
										num = (short)1286733826;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첃떅뾇", a_), flashCode, ref flag2);
									flag3 = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첃떅낇", a_), flashCode, ref flag4);
									num = (short)748421126;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_100;
								case 5:
									goto IL_158;
								case 6:
									goto IL_100;
								case 7:
									if (flag || flag3)
									{
										num = (short)1042677761;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									result = true;
									num = (short)488898560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_B9;
								IL_100:
								num = (short)1081606151;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_158:
							IL_217:
							return result;
							IL_B9:
							flag2 = false;
							flag = false;
							flag4 = false;
							flag3 = false;
							flashcodeTable.InitTable(fromCodeplug, modelNumber, false);
							num = (short)377815043;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_92;
						}
						finally
						{
							num = (short)1869742082;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2D6;
								case 1:
									((global::System.IDisposable)flashcodeTable).Dispose();
									num = (short)1475018752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_24E;
									}
									continue;
								}
								IL_24E:
								if (flashcodeTable == null)
								{
									break;
								}
								num = (short)1255517933;
								short num4 = num;
								num = (short)214478573;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2D6;
								default:
									num = (short)2032795648;
									if (num != 0)
									{
									}
									num = (short)1859977217;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_2D6:;
						}
						goto IL_2D9;
					}
					case 4:
						num = (short)803602433;
						if (num != 0)
						{
						}
						flag5 = false;
						num = (short)512950272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)288423938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4F;
					IL_2D9:
					flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable(!flag5, true);
					num = (short)1907097603;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_4F:
				result = false;
				flag5 = true;
				num = (short)548208641;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000830E4 File Offset: 0x000812E4
		internal static bool Is800MHzBandEnabled(string modelNumber, string flashCode)
		{
			int a_ = 3;
			short num = (short)1070741626;
			short num2 = num;
			num = (short)438253690;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)91226112;
				if (num != 0)
				{
				}
				num = (short)1794768896;
				num3 = (int)num;
				switch (num3)
				{
				}
				break;
			}
			switch (0)
			{
			case 0:
				goto IL_91;
			}
			bool result;
			bool flag4;
			for (;;)
			{
				IL_7A:
				global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
				switch (num3)
				{
				case 0:
					if (modelNumber.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캅", a_)))
					{
						num = (short)23789571;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3ED;
				case 1:
				{
					num = (short)1566310400;
					short num4 = num;
					goto IL_3ED;
				}
				case 2:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_12A;
						}
						bool flag;
						bool flag2;
						bool flag3;
						for (;;)
						{
							IL_E7:
							switch (num3)
							{
							case 0:
								result = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힅즇몉벋뮍ꞏꆑ", a_), flashCode, ref flag);
								num = (short)1355939854;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1AE;
							case 2:
								result = true;
								num = (short)651427848;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)1096286212;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솅즇몉벋벍꒏ꚑ", a_), flashCode, ref flag2))
								{
									num = (short)1516175362;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1074200581;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솅즇몉벋뮍ꞏꮑ", a_), flashCode, ref flag3))
								{
									num = (short)697106443;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_364;
							case 6:
								if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힅즇몉벋뮍ꚏꮑ", a_), flashCode, ref flag2))
								{
									num = (short)1037828109;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)550699020;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_218;
							case 8:
								goto IL_18E;
							case 9:
								goto IL_37D;
							case 10:
								if (flag4)
								{
									num = (short)1277755395;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)414449670;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								result = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솅즇몉벋벍ꊏꞑ", a_), flashCode, ref flag);
								num = (short)69009415;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힅즇몉벋뮍ꞏꮑ", a_), flashCode, ref flag3))
								{
									num = (short)890437632;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_364;
							case 13:
								result = true;
								num = (short)1130823681;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								goto IL_364;
							}
							goto IL_12A;
							IL_364:
							num = (short)1796407305;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_18E:
						IL_1AE:
						IL_218:
						IL_37D:
						return result;
						IL_12A:
						flashcodeTable.InitTable(false, modelNumber, false);
						flag3 = false;
						flag2 = false;
						flag = false;
						num = (short)677511178;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_E7;
					}
					finally
					{
						num = (short)310575104;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3B4;
								}
								continue;
							case 1:
								goto IL_3EA;
							case 2:
								((global::System.IDisposable)flashcodeTable).Dispose();
								num = (short)618790913;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_3B4:
							if (flashcodeTable == null)
							{
								break;
							}
							num = (short)21889026;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_3EA:;
					}
					goto IL_3ED;
				case 3:
					flag4 = false;
					num = (short)1833631745;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_91;
				IL_3ED:
				num = (short)1279393793;
				if (num != 0)
				{
				}
				flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable(!flag4, true);
				num = (short)1798701058;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_91:
			result = false;
			flag4 = true;
			num = (short)1036189696;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7A;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00083594 File Offset: 0x00081794
		public static bool IsCpgOwnerSystemIDValid(out string statusMsg)
		{
			short num = (short)1345978368;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.General.RadWideGeneralOwnerSystemID_A37153Value > radioWide.General.RadWideGeneralOwnerSystemID_A37153.Max)
						{
							num = (short)1750007821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)1015545876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.General.RadWideGeneralOwnerWACNID_A38656Value > radioWide.General.RadWideGeneralOwnerWACNID_A38656.Max)
						{
							num = (short)1364131847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 3:
						num = (short)1952972801;
						if (num != 0)
						{
						}
						num = (short)327352324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						int radWideGeneralOwnerAdvancedKeyType_A38663Value;
						if (radWideGeneralOwnerAdvancedKeyType_A38663Value != 1)
						{
							num = (short)1201209367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1555890181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.General.RadWideGeneralOwnerWACNID_A38656Value >= 1)
						{
							num = (short)1926823957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_222;
					}
					case 6:
						goto IL_15F;
					case 7:
						goto IL_222;
					case 8:
						if (radioInformation != null)
						{
							num = (short)593952777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						statusMsg = global::CommonResources.AppResources.Internal_Error_Could_Not_Validate_Codeplug_Owner_ID;
						num = (short)738394134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1009909777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						int radWideGeneralOwnerAdvancedKeyType_A38663Value = radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663Value;
						num = (short)1556217875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						return result;
					case 12:
						goto IL_244;
					case 13:
						goto IL_13D;
					case 14:
						statusMsg = global::CommonResources.AppResources.The_Value_Of_The_Owner_Advanced_Key_Type_field_Not_Valid;
						result = false;
						num = (short)324141074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)296615936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.General.RadWideGeneralOwnerSystemID_A37153Value >= 1)
						{
							num = (short)873070607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13D;
					}
					case 17:
						if (radioInformation.Labtool.RadInfoLabtoolQA01648ASKEnable_A37150Value)
						{
							num = (short)1175977985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 18:
						goto IL_1CC;
					case 19:
					{
						int radWideGeneralOwnerAdvancedKeyType_A38663Value;
						if (radWideGeneralOwnerAdvancedKeyType_A38663Value != 0)
						{
							num = (short)48103427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)545652752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide != null)
						{
							num = (short)1802567690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1293999315;
						short num3 = num;
						num = (short)898882771;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2097938432;
							if (num != 0)
							{
							}
							result = false;
							statusMsg = global::CommonResources.AppResources.Internal_Error_Could_Not_Validate_Codeplug_Owner_ID;
							num = (short)478478347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 21:
						num = (short)317456386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_26B;
					case 23:
						num = (short)1450442766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F;
					IL_13D:
					result = false;
					statusMsg = global::CommonResources.AppResources.The_value_of_the_Owner_System_ID_field_in_the_codeplug_is_not_valid;
					num = (short)1608908806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_222:
					result = false;
					statusMsg = global::CommonResources.AppResources.The_Value_Of_The_Owner_WACN_ID_Field_In_The_Codeplug_Not_Valid;
					num = (short)212008972;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_15F:
				IL_1CC:
				IL_244:
				return result;
				IL_26B:
				num = (short)1664614400;
				short num4 = num;
				return result;
				IL_8F:
				result = true;
				statusMsg = null;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)1834876936;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00083A60 File Offset: 0x00081C60
		public static bool IsAstroMSOtarEnabled(string modelNumber, string flashCode)
		{
			int a_ = 9;
			short num = (short)2097297129;
			short num2 = num;
			num = (short)1797601001;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1806630913;
				if (num != 0)
				{
				}
				num = (short)1397948416;
				if (num != 0)
				{
				}
				num = (short)181075968;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)1327759360;
					short num4 = num;
					bool flag = !modelNumber.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒋", a_));
					bool flag2 = false;
					global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable(!flag, true);
					try
					{
						switch (0)
						{
						case 0:
							goto IL_109;
						}
						for (;;)
						{
							IL_EE:
							bool flag3;
							switch (num3)
							{
							case 0:
								flag3 = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋쾍ꂏꎑꊓ꒕ꢗ", a_), flashCode, ref flag2);
								num = (short)63700995;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (flag)
								{
									num = (short)511574016;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								flag3 = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꖑꊓ꺕ꢗ", a_), flashCode, ref flag2);
								num = (short)1677524996;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1C5;
							case 3:
								goto IL_1A9;
							case 4:
								goto IL_1A9;
							}
							goto IL_109;
							IL_1A9:
							result = flag3;
							num = (short)334102530;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1C5:
						break;
						IL_109:
						flashcodeTable.InitTable(false, modelNumber, false);
						num = (short)1808269313;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_EE;
					}
					finally
					{
						num = (short)77856768;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1F9;
								}
								continue;
							case 1:
								goto IL_22F;
							case 2:
								((global::System.IDisposable)flashcodeTable).Dispose();
								num = (short)1905393665;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1F9:
							if (flashcodeTable == null)
							{
								break;
							}
							num = (short)406061058;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_22F:;
					}
					break;
				}
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00083CB4 File Offset: 0x00081EB4
		public static bool CacheCodeplugSecurityFields(out bool wp, out bool askReq, out int ownerKeyType, out int ownerSysId, out int ownerWacnId, out global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset askProgRecset, out int programmingPath)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (global::AcpCommonLib.FeatureManager.ActiveDocument.IsOpen)
					{
						num2 = (short)1595932677;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					if (radioInformation.AdvancedSystemKeyInfo != null)
					{
						num2 = (short)1482293256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BE;
				}
				case 2:
					goto IL_1D8;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					if (radioInformation != null)
					{
						num2 = (short)250609671;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BE;
				}
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					if (radioWide != null)
					{
						num2 = (short)360710153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 5:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
					num2 = (short)8060932;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					num2 = (short)95485953;
					if (num2 != 0)
					{
					}
					goto IL_1BE;
				case 7:
					num2 = (short)30408705;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					askProgRecset = (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset)radioInformation.AdvancedSystemKeyInfo.EmbeddedRecset;
					num2 = (short)1557200902;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
				{
					num2 = (short)281149440;
					short num3 = num2;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					wp = radioWide.Depot.AdvancedExternalMicOnlyValue;
					ownerKeyType = radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663Value;
					askReq = radioWide.General.RadWideGeneralASKRequired_A37152Value;
					ownerSysId = radioWide.General.RadWideGeneralOwnerSystemID_A37153Value;
					ownerWacnId = radioWide.General.RadWideGeneralOwnerWACNID_A38656Value;
					programmingPath = radioWide.General.RadWideGeneralProgrammingPath_44845Value;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
					num2 = (short)1740111875;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_38;
				IL_1BE:
				result = true;
				num2 = (short)1655111682;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1D8:
			return result;
			IL_38:
			result = false;
			wp = false;
			ownerKeyType = 0;
			askReq = false;
			ownerSysId = 0;
			ownerWacnId = 0;
			askProgRecset = null;
			programmingPath = 0;
			num2 = (short)2090246188;
			short num4 = num2;
			num2 = (short)2118361132;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
			{
				num2 = (short)216137728;
				if (num2 != 0)
				{
				}
				num2 = (short)2101411840;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00083F68 File Offset: 0x00082168
		public static bool RestoreCachedCodeplugSecurityFields(bool wp, bool askReq, int ownerKeyType, int ownerSysId, int ownerWacnId, global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset askProgRecset, int programmingPath)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				switch (num)
				{
				case 0:
					if (global::AcpCommonLib.FeatureManager.ActiveDocument.IsOpen)
					{
						goto IL_69;
					}
					return result;
				case 1:
					num2 = (short)2041184257;
					if (num2 != 0)
					{
					}
					goto IL_C1;
				case 2:
					goto IL_C1;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
					num2 = (short)2120679436;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					num2 = (short)423755784;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (radioInformation != null)
					{
						num2 = (short)611844100;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20D;
				case 6:
					return result;
				case 7:
					goto IL_20D;
				case 8:
					if (radioInformation.AdvancedSystemKeyInfo != null)
					{
						num2 = (short)916979721;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20D;
				case 9:
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset._Min = askProgRecset.Count;
					radioInformation.AdvancedSystemKeyInfo.EmbeddedRecset = askProgRecset;
					num2 = (short)1485176839;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
				{
					num2 = (short)984792443;
					short num3 = num2;
					num2 = (short)986103163;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_69;
					default:
					{
						num2 = (short)199163904;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						radioWide.Depot.AdvancedExternalMicOnly.SetValue(wp);
						radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663.SetValue(ownerKeyType);
						radioWide.General.RadWideGeneralASKRequired_A37152.SetValue(askReq);
						radioWide.General.RadWideGeneralOwnerSystemID_A37153.SetValue(ownerSysId);
						radioWide.General.RadWideGeneralOwnerWACNID_A38656.SetValue(ownerWacnId);
						num2 = (short)611581952;
						short num4 = num2;
						num2 = (short)1494155275;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 11:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::AcpBusinessLayer.AcpListField radWideGeneralProgrammingPath_ = radioWide.General.RadWideGeneralProgrammingPath_44845;
					if (radWideGeneralProgrammingPath_ == null)
					{
						num2 = (short)1497497602;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					radWideGeneralProgrammingPath_.SetValue(programmingPath);
					num2 = (short)76021761;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					if (radioWide != null)
					{
						num2 = (short)1474428938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				}
				goto IL_44;
				IL_69:
				num2 = (short)702218243;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_C1:
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num2 = (short)1050935301;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_20D:
				result = true;
				num2 = (short)1179975686;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_44:
			result = false;
			num2 = (short)1547304960;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00084290 File Offset: 0x00082490
		internal static bool CheckIfIsACK()
		{
			bool result;
			for (;;)
			{
				IL_00:
				short num = (short)1463746560;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_B8;
				}
				int num4;
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> loadedASKs;
				for (;;)
				{
					IL_34:
					num = (short)2131381068;
					short num3 = num;
					num = (short)529222476;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
					{
						num = (short)1490878465;
						if (num != 0)
						{
						}
						num = (short)439222272;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
						switch (num4)
						{
						case 0:
							if (loadedASKs != null)
							{
								num = (short)499187714;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 1:
							try
							{
								num = (short)1789722626;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										goto IL_1C6;
									case 1:
										num = (short)1449525252;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_13D;
										}
										continue;
									case 3:
										if (!enumerator.MoveNext())
										{
											num = (short)964886529;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1332477957;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_1E4;
									case 5:
										if (enumerator.Current.Type == global::AcpASKLib.KeyType.ADVANCED_CONV_SYSTEM_KEY)
										{
											num = (short)365101062;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 6:
										result = true;
										num = (short)431357952;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_13F:
									num = (short)983043;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_13D:
									goto IL_13F;
								}
								IL_1C6:
								IL_1E4:
								return result;
							}
							finally
							{
								num = (short)23855104;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_21A;
										}
										continue;
									case 1:
										goto IL_24F;
									case 2:
										enumerator.Dispose();
										num = (short)1901002753;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_21A:
									if (enumerator == null)
									{
										break;
									}
									num = (short)139329538;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_24F:;
							}
							goto IL_252;
						case 2:
							goto IL_252;
						}
						goto IL_B8;
						IL_252:
						enumerator = loadedASKs.GetEnumerator();
						num = (short)554696705;
						num4 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_B8:
				result = false;
				loadedASKs = global::AcpSecurityLib.SecurityManager.LoadedASKs;
				num = (short)1140981760;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_34;
			}
			return result;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00084524 File Offset: 0x00082724
		internal static bool CheckIfCustomerIDIsInACK(int customerID)
		{
			short num = (short)353304576;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> loadedASKs;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (loadedASKs != null)
						{
							num = (short)591200258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C4;
					case 1:
						goto IL_2BF;
					case 2:
						goto IL_C1;
					}
					goto IL_3B;
				}
				IL_2BF:
				bool result;
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
				try
				{
					num = (short)1182269440;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_13A;
							}
							continue;
						case 1:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (customerID == systemKeyData.SystemID)
							{
								num = (short)636157955;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Type == global::AcpASKLib.KeyType.ADVANCED_CONV_SYSTEM_KEY)
							{
								num = (short)640614407;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							result = true;
							num = (short)1167654920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)718012421;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.SystemKeyData systemKeyData = enumerator.Current;
							num = (short)2048131074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)406061062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_22E;
						case 7:
							num = (short)1286668289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_1D3;
						}
						IL_13C:
						num = (short)2036596740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_13A:
						goto IL_13C;
					}
					IL_1D3:
					IL_22E:
					goto IL_2C4;
				}
				finally
				{
					num = (short)1548550144;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_265;
							}
							continue;
						case 1:
							goto IL_29C;
						case 2:
							enumerator.Dispose();
							num = (short)844759041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_265:
						if (enumerator == null)
						{
							break;
						}
						num = (short)112918530;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_29C:;
				}
				goto IL_29F;
				IL_2C4:
				num = (short)426508289;
				if (num != 0)
				{
				}
				return result;
				IL_3B:
				result = false;
				loadedASKs = global::AcpSecurityLib.SecurityManager.LoadedASKs;
				num = (short)87632895;
				short num3 = num;
				num = (short)922758143;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_C1:
					num = (short)2097545216;
					short num4 = num;
					break;
				}
				default:
					num = (short)144637952;
					if (num != 0)
					{
					}
					num = (short)1037697024;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				IL_29F:
				enumerator = loadedASKs.GetEnumerator();
				num = (short)128319489;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
