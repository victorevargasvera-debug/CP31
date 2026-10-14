using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;
using AcpASKLib;
using AcpSecurityLib;
using CommonResources;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.Utilities;

namespace SpecialFeatures.Security
{
	// Token: 0x02000059 RID: 89
	public class RMCRadioAccessValidator : global::SpecialFeatures.Security.RadioAccessValidatorBase
	{
		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x000884E8 File Offset: 0x000866E8
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00088594 File Offset: 0x00086794
		internal bool IsRadioDeviceUpdated
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1398359413;
				short num2 = num;
				num = (short)1144014197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)678756352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1938161665;
				if (num != 0)
				{
				}
				num = (short)1055522816;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1963136782;
				short num2 = num;
				num = (short)1406473998;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2077229056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1560150017;
				if (num != 0)
				{
				}
				num = (short)632291328;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00088644 File Offset: 0x00086844
		public static bool AstroWritingEventHandler(global::Motorola.CommonCPS.Server.EntityModel.Radio dv, int transportPreference, out bool bUpdated, out string stsMsg, bool batchProgramming, bool writeProtectDevice, bool IsRestoreJob, ref global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> attachedASKs, ref bool? isSpecialKeyAttached)
		{
			short num = (short)198246400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9A;
				}
				bool result;
				bool isSkipWorkingCPParticularContentCheck;
				for (;;)
				{
					IL_27:
					int? num3;
					global::SpecialFeatures.Security.RadioSecurityData radSecData;
					global::SpecialFeatures.Security.RadioSecurityData cpgSecData;
					global::SpecialFeatures.Comms.COMMS_OP writeType;
					bool flashportFromCvnToTrk;
					int? changeIndicator;
					int? num6;
					int num7;
					switch (num2)
					{
					case 0:
					{
						int? num4;
						num3 = num4;
						goto IL_314;
					}
					case 1:
						if (dv.WorkingCodeplug != null)
						{
							num = (short)1210318857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F0;
					case 2:
						bUpdated = false;
						num = (short)1307377690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (dv.CurrentCodeplug != null)
						{
							num = (short)621871111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F0;
					case 4:
						goto IL_E4;
					case 5:
						goto IL_40A;
					case 6:
						goto IL_40A;
					case 7:
						num = (short)2092498945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (IsRestoreJob)
						{
							num = (short)461111298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 9:
						radSecData = global::SpecialFeatures.Security.RMCRadioAccessValidator.a(dv.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug, dv.ModelNumber);
						cpgSecData = global::SpecialFeatures.Security.RMCRadioAccessValidator.a(dv.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug, dv.ModelNumber);
						writeType = global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE;
						num = (short)1316552727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						flashportFromCvnToTrk = true;
						num = (short)1849688078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (dv != null)
						{
							goto IL_244;
						}
						goto IL_2F0;
					case 12:
						goto IL_40A;
					case 13:
					{
						num = (short)806617089;
						if (num != 0)
						{
						}
						num = (short)627965952;
						short num5 = num;
						num = (short)1902444547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_363;
					case 15:
						if (changeIndicator == null)
						{
							num = (short)874446868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2030043157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_E4;
					case 17:
						num = (short)1855717382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_40A;
					case 19:
						if (!(num6.GetValueOrDefault() == num7 & num6 != null))
						{
							num = (short)1160445962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_363;
					case 20:
					{
						int? num4 = null;
						num = (short)69337088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						num3 = new int?(changeIndicator.GetValueOrDefault() & 16);
						goto IL_314;
					case 22:
						isSkipWorkingCPParticularContentCheck = true;
						num = (short)1205469209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						switch (transportPreference)
						{
						case 0:
							writeType = global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE;
							num = (short)1713504274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							writeType = global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE;
							num = (short)762368095;
							short num8 = num;
							num = (short)273993823;
							switch ((num8 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_244;
							default:
								num = (short)1827078144;
								if (num != 0)
								{
								}
								num = (short)1347223564;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							writeType = global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE;
							num = (short)18087941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1647050769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 24:
						if (IsRestoreJob)
						{
							num = (short)1573519382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_225;
					case 25:
						goto IL_225;
					case 26:
						return result;
					}
					goto IL_9A;
					IL_E4:
					num = (short)154009608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_225:
					num = (short)98238475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_244:
					num = (short)369098765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F0:
					stsMsg = global::CommonResources.AppResources.Input_not_initialized;
					num = (short)1452212240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_314:
					num6 = num3;
					num7 = 0;
					num = (short)2016411667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_363:
					global::SpecialFeatures.Security.RMCRadioAccessValidator rmcradioAccessValidator = new global::SpecialFeatures.Security.RMCRadioAccessValidator(writeType, radSecData, cpgSecData, dv, writeProtectDevice, batchProgramming, flashportFromCvnToTrk, isSkipWorkingCPParticularContentCheck);
					result = rmcradioAccessValidator.Validate(out stsMsg, ref attachedASKs, ref isSpecialKeyAttached);
					bUpdated = rmcradioAccessValidator.IsRadioDeviceUpdated;
					num = (short)508690436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40A:
					flashportFromCvnToTrk = false;
					changeIndicator = dv.WorkingCodeplug.ChangeIndicator;
					num = (short)809566223;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_9A:
				bUpdated = false;
				result = false;
				stsMsg = string.Empty;
				isSkipWorkingCPParticularContentCheck = false;
				num = (short)778960920;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00088B88 File Offset: 0x00086D88
		public static bool AstroASKRequirementEventHandler(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug cpObj, string modelNumber, out string stsMsg)
		{
			short num = (short)1688731648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9A;
				}
				bool result;
				for (;;)
				{
					IL_27:
					global::AcpASKLib.SystemKeyData systemKeyData;
					global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> sysKeysFromLoadedAndAttachedASKs;
					switch (num2)
					{
					case 0:
						goto IL_201;
					case 1:
					{
						int? num3;
						if (num3 != null)
						{
							num = (short)558170121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CB;
					}
					case 2:
						goto IL_36C;
					case 3:
						num = (short)1423441932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return result;
					case 5:
						goto IL_4CB;
					case 6:
						num = (short)2119827464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return result;
					case 8:
						if (systemKeyData.AccessLevelType == global::AcpASKLib.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
						{
							num = (short)1127153666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18A;
					case 9:
					{
						int? num3 = cpObj.HomeSystemId;
						int homeSysId = num3.Value;
						num = (short)2071920645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)1793458193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						int? ownerAdvKeyType;
						int valueOrDefault = ownerAdvKeyType.GetValueOrDefault();
						num = (short)897646611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_4CB;
					case 13:
						if (systemKeyData.AccessLevelType != global::AcpASKLib.KeyAccessLevelType.UNLM_ACC)
						{
							num = (short)114491398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 14:
					{
						int? ownerAdvKeyType;
						if (ownerAdvKeyType != null)
						{
							num = (short)1598226443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CB;
					}
					case 15:
					{
						string flashCode = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(cpObj.AstroPurchasedFlashCode, cpObj.AstroPurchasedFlashCode.Length);
						if (global::SpecialFeatures.Security.RadioAccessValidator.GetProtectionOption(modelNumber, flashCode, false) == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
						{
							num = (short)881131540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						stsMsg = global::CommonResources.AppResources.Operation_not_applicable_for_codeplug;
						num = (short)864813060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						int? num3 = cpObj.OwnerWacnId;
						int homeSysId = num3.Value;
						num = (short)1500446743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						int valueOrDefault;
						if (valueOrDefault != 1)
						{
							num = (short)85262339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpASKLib.KeyType homeKeyType = global::AcpASKLib.KeyType.ADVANCED_WACN_KEY;
						int? num3 = cpObj.OwnerWacnId;
						num = (short)1440219154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						int? num3;
						if (num3 != null)
						{
							num = (short)78250000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CB;
					}
					case 19:
					{
						int valueOrDefault;
						if (valueOrDefault != 0)
						{
							num = (short)308281354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpASKLib.KeyType homeKeyType = global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
						int? num3 = cpObj.HomeSystemId;
						num = (short)555548673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						num = (short)803667968;
						short num4 = num;
						global::AcpASKLib.KeyType homeKeyType = global::AcpASKLib.KeyType.UNDEFINED_KEY;
						int homeSysId = 0;
						int? ownerAdvKeyType = cpObj.OwnerAdvKeyType;
						num = (short)23199758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						return result;
					case 22:
						num = (short)1827274767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_4CB;
					case 24:
					{
						if (cpObj != null)
						{
							num = (short)1610547222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						stsMsg = global::CommonResources.AppResources.Input_not_initialized;
						num = (short)135867008;
						short num5 = num;
						num = (short)1327835776;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_201;
						default:
							num = (short)522715136;
							if (num != 0)
							{
							}
							num = (short)897974293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 25:
					{
						int homeSysId;
						global::AcpASKLib.KeyType homeKeyType;
						if (global::SpecialFeatures.Security.RadioAccessValidatorBase.CheckIfOwnerASKIsAttached(homeSysId, homeKeyType, sysKeysFromLoadedAndAttachedASKs, out systemKeyData))
						{
							num = (short)1720516608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18A;
					}
					case 26:
						return result;
					}
					goto IL_9A;
					IL_18A:
					stsMsg = global::CommonResources.AppResources.Unlimited_Owner_System_Advanced_Key_must_be_loaded_and_attached;
					num = (short)272826375;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_201:
					num = (short)632553485;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36C:
					num = (short)974389249;
					if (num != 0)
					{
					}
					result = true;
					num = (short)99287066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CB:
					systemKeyData = null;
					sysKeysFromLoadedAndAttachedASKs = global::AcpSecurityLib.SecurityManager.GetSysKeysFromLoadedAndAttachedASKs();
					num = (short)1981808665;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_9A:
				result = false;
				stsMsg = null;
				num = (short)1024851992;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000890B4 File Offset: 0x000872B4
		public static bool AstrCheckIsConvOnlyEvtHandler(string flashcode, string modelNumber)
		{
			short num = (short)622404836;
			short num2 = num;
			num = (short)1680549092;
			switch (num2 == num)
			{
			}
			num = (short)1101791232;
			if (num != 0)
			{
			}
			num = (short)1961295872;
			short num3 = num;
			num = (short)283443201;
			if (num != 0)
			{
			}
			return global::SpecialFeatures.Security.RadioAccessValidator.IsConvOnly(modelNumber, flashcode, false);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00089164 File Offset: 0x00087364
		public static bool AstroHoptionEnableEventHandler(string flashcode, string hoption, string modelNumber)
		{
			int a_ = 14;
			short num = (short)2093481984;
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
				bool result;
				bool ordered;
				for (;;)
				{
					IL_31:
					global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
					switch (num2)
					{
					case 0:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_FD;
							}
							bool flag;
							bool flag2;
							for (;;)
							{
								IL_E6:
								switch (num2)
								{
								case 0:
									result = true;
									num = (short)2134638594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_17E;
								case 2:
									goto IL_15D;
								case 3:
									if (flag && flag2)
									{
										num = (short)1288962048;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									result = false;
									num = (short)158269441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_FD;
							}
							IL_15D:
							IL_17E:
							return result;
							IL_FD:
							flashcodeTable.InitTable(false, modelNumber, false);
							flag = false;
							flag2 = flashcodeTable.IsOptionEnabledInFlashcode(hoption, flashcode, ref flag);
							num = (short)1901002755;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_E6;
						}
						finally
						{
							num = (short)484114434;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_239;
								case 1:
									goto IL_219;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1B6;
									}
									continue;
								}
								IL_1B6:
								num = (short)1069228435;
								short num3 = num;
								num = (short)932520339;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_219:
									((global::System.IDisposable)flashcodeTable).Dispose();
									num = (short)2090205184;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)835649536;
									if (num != 0)
									{
									}
									if (flashcodeTable == null)
									{
										goto IL_23B;
									}
									num = (short)312279041;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_239:
							IL_23B:;
						}
						goto IL_23C;
					case 1:
						ordered = true;
						num = (short)1941045251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)947191809;
						if (num != 0)
						{
						}
						num = (short)1306460164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_23C;
					case 4:
						if (modelNumber.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud990", a_)))
						{
							num = (short)2013003777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23C;
					case 5:
					{
						num = (short)1474297856;
						short num4 = num;
						if (modelNumber != null)
						{
							num = (short)1811021826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23C;
					}
					}
					goto IL_50;
					IL_23C:
					flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable(ordered);
					num = (short)811859968;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_50:
				ordered = false;
				num = (short)660406277;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00089450 File Offset: 0x00087650
		public static bool AstroIndividualIdEditingEventHandler(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem radioSys, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug cpObj, out string stsMsg, string modelNumber)
		{
			int a_ = 17;
			short num = (short)806420480;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_134;
				}
				bool flag;
				for (;;)
				{
					IL_31:
					bool flag3;
					global::SpecialFeatures.Security.ProtectionOption protectionOption;
					bool bAskOnly;
					bool flag4;
					bool flag5;
					bool flag6;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType;
					switch (num2)
					{
					case 0:
						num = (short)1889599506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						int? num3;
						int num4;
						if (num3.GetValueOrDefault() == num4 & num3 != null)
						{
							num = (short)1763967025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpASKLib.KeyType keyType = global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
						num3 = radioSys.SystemId;
						int num5 = num3.Value;
						num = (short)1168048150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (cpObj.AstroPurchasedFlashCode != null)
						{
							num = (short)1821900832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 3:
						return flag;
					case 4:
						goto IL_A5A;
					case 5:
						goto IL_4D8;
					case 6:
					{
						int? num3 = radioSys.RadioId;
						string text = num3.Value.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첓", a_), global::System.Globalization.CultureInfo.CurrentCulture);
						num3 = radioSys.RadioId;
						int num4 = 1;
						num = (short)1731919917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)727318590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						flag = true;
						num = (short)2090860592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1047855131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_8AF;
					case 11:
						if (!flag)
						{
							num = (short)1336279065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 12:
					{
						if (global::AcpSecurityLib.SecurityManager.IsSpecialKeyLoaded)
						{
							num = (short)1852964890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpASKLib.KeyType keyType = global::AcpASKLib.KeyType.UNDEFINED_KEY;
						int num5 = 0;
						int? num3 = radioSys.CoverageType;
						int num4 = 5;
						num = (short)812646401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (radioSys != null)
						{
							num = (short)647233577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 14:
					{
						int? num3 = radioSys.RadioId;
						int num4 = 9999999;
						num = (short)460521523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						int? num3 = radioSys.RadioId;
						int num4 = 1;
						num = (short)839122988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						int? num3;
						int num4;
						if (num3.GetValueOrDefault() >= num4 & num3 != null)
						{
							num = (short)1992753166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1204617254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						num = (short)648347649;
						if (num != 0)
						{
						}
						goto IL_4D8;
					case 18:
					{
						if (!radioSys.ExpandedMDCIDRange)
						{
							num = (short)476381190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int? num3 = radioSys.RadioId;
						int num4 = 1;
						num = (short)807010344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						int? num3 = radioSys.RadioId;
						int num4 = 57070;
						num = (short)477429816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						num = (short)90308608;
						short num6 = num;
						bool? askRequired = cpObj.AskRequired;
						bool flag2 = true;
						num = (short)1128529944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						int? num3;
						int num4;
						flag3 = (num3.GetValueOrDefault() <= num4 & num3 != null);
						goto IL_BD0;
					}
					case 22:
						goto IL_76D;
					case 23:
						if (protectionOption == global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED)
						{
							num = (short)177405985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bAskOnly = false;
						num = (short)641925130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						bool? askRequired;
						bool flag2;
						if (!(askRequired.GetValueOrDefault() == flag2 & askRequired != null))
						{
							num = (short)1555824644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_557;
					}
					case 25:
						stsMsg = global::CommonResources.AppResources.Unit_ID_out_of_range;
						num = (short)779288628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						flag = true;
						num = (short)923992067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (cpObj != null)
						{
							num = (short)429129765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 28:
						num = (short)30408716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						global::AcpASKLib.AccessElementIDType id = global::AcpASKLib.AccessElementIDType.TRK_SYS_GEN_UNIT_ID_ELEMENT;
						global::AcpASKLib.KeyType keyType;
						global::AcpASKLib.KeyType type = keyType;
						int num5;
						int sysId = num5;
						int? num3 = radioSys.RadioId;
						if (global::AcpSecurityLib.SecurityManager.IsRangeValueValid(id, type, sysId, num3.Value, bAskOnly))
						{
							num = (short)1749942280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B4D;
					}
					case 30:
						goto IL_4D8;
					case 31:
					{
						int? num3;
						int num4;
						flag4 = (num3.GetValueOrDefault() <= num4 & num3 != null);
						goto IL_42A;
					}
					case 32:
						num = (short)1373569067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_557;
					case 34:
						goto IL_76D;
					case 35:
						flag5 = false;
						goto IL_489;
					case 36:
						flag3 = false;
						goto IL_BD0;
					case 37:
						num = (short)895221762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						flag6 = false;
						goto IL_514;
					case 39:
						goto IL_738;
					case 40:
					{
						int? num3;
						int num4;
						if (num3.GetValueOrDefault() >= num4 & num3 != null)
						{
							num = (short)1141243961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)117047356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						systemType = radioSys.SystemType;
						astroSystemType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
						num = (short)2032402486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
					{
						int? num3 = radioSys.RadioId;
						int num4 = 16777211;
						num = (short)1443692565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						if (global::SpecialFeatures.Security.RMCRadioAccessValidator.a(radioSys, cpObj))
						{
							num = (short)1470693404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 44:
					{
						int? num3;
						int num4;
						if (num3.GetValueOrDefault() >= num4 & num3 != null)
						{
							num = (short)1151664170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1802240036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
					{
						int? num3;
						int num4;
						if (num3.GetValueOrDefault() >= num4 & num3 != null)
						{
							num = (short)1259077651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_577;
					}
					case 46:
						goto IL_8AF;
					case 47:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
						if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
						{
							num = (short)1862270991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int? num3 = radioSys.RadioId;
						int num4 = 1;
						num = (short)422445072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						goto IL_5B0;
					case 49:
					{
						global::AcpASKLib.KeyType keyType = global::AcpASKLib.KeyType.ADVANCED_WACN_KEY;
						int? num3 = radioSys.WacnId;
						int num5 = num3.Value;
						num = (short)1141702690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
						if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
						{
							num = (short)944766976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						systemSubType = radioSys.SystemSubType;
						astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.DVRS;
						num = (short)1056702511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 51:
					{
						int? num3;
						int num4;
						flag6 = (num3.GetValueOrDefault() <= num4 & num3 != null);
						goto IL_514;
					}
					case 52:
						goto IL_6C5;
					case 53:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType = radioSys.SystemSubType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.MDC;
						num = (short)1386414130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
					{
						if (systemType.GetValueOrDefault() == astroSystemType & systemType != null)
						{
							num = (short)151126069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)198065818;
						short num7 = num;
						num = (short)1876573850;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_738;
						default:
							num = (short)1529413632;
							if (num != 0)
							{
							}
							systemType = radioSys.SystemType;
							astroSystemType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNCKING;
							num = (short)2005467175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 55:
						num = (short)344719389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
					{
						int? num3;
						int num4;
						if (num3.GetValueOrDefault() <= num4 & num3 != null)
						{
							num = (short)1851457543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_577;
					}
					case 57:
					{
						int? num3 = radioSys.RadioId;
						int num4 = 65534;
						num = (short)1568079903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 58:
						goto IL_4D8;
					case 59:
						if (protectionOption == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
						{
							num = (short)1331363860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A5A;
					case 60:
						flag4 = false;
						goto IL_42A;
					case 61:
					{
						global::AcpASKLib.KeyType keyType;
						int num5;
						if (global::AcpSecurityLib.SecurityManager.IsSystemKeyLoaded(num5, (byte)keyType, bAskOnly))
						{
							num = (short)1168638007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32D;
					}
					case 62:
					{
						string text;
						flag5 = !text.ToLower().Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
						goto IL_489;
					}
					}
					goto IL_134;
					IL_42A:
					flag = flag4;
					num = (short)712572986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_489:
					flag = flag5;
					num = (short)1449656350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D8:
					num = (short)1327235083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_514:
					flag = flag6;
					num = (short)1762983953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_557:
					bAskOnly = true;
					num = (short)722731054;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_577:
					num = (short)1229783075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_738:
					if (systemType.GetValueOrDefault() == astroSystemType & systemType != null)
					{
						num = (short)1122304009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return flag;
					IL_76D:
					string flashCode = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(cpObj.AstroPurchasedFlashCode, cpObj.AstroPurchasedFlashCode.Length);
					protectionOption = global::SpecialFeatures.Security.RadioAccessValidator.GetProtectionOption(modelNumber, flashCode, false);
					bAskOnly = true;
					num = (short)824180795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8AF:
					num = (short)56361021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A5A:
					num = (short)2035220503;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BD0:
					flag = flag3;
					num = (short)1589706757;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_32D:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_RadioID_NotLoadSystemKey);
				IL_5B0:
				IL_6C5:
				return flag;
				IL_B4D:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_RadioID_SystemKeyNotAllow);
				IL_134:
				flag = false;
				stsMsg = null;
				num = (short)774307853;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0008A04C File Offset: 0x0008824C
		private static bool a(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem A_0, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_1)
		{
			short num = (short)597032960;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_82;
				}
				int value;
				bool result;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)63504387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							num = (short)1594884099;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)359137282;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile = enumerator.Current;
									num = (short)902299652;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_2DF;
								case 2:
									num = (short)6750213;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_239;
									}
									continue;
								case 4:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
									if (apxdataProfile.Name == A_0.SelectedDataProfileName)
									{
										num = (short)1827274758;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_2FE;
								case 6:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile2 = apxdataProfile;
									num = (short)1829896193;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_285:
								num = (short)1013317632;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_239:
								goto IL_285;
							}
							IL_2DF:
							IL_2FE:
							goto IL_538;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_311;
					case 2:
						num = (short)1478819858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (value <= 16777211)
						{
							num = (short)1017249801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						if (value >= 1)
						{
							num = (short)1286340608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
						return result;
					case 6:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile2;
						global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Utilities.Astro25DataGroupID> enumerator2 = new global::SpecialFeatures.Utilities.AstroDataProfTrunkingGroupgIDs(apxdataProfile2.TrunkingGroupIds).Recset.GetEnumerator();
						num = (short)1799094280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (value <= 65534)
						{
							num = (short)706871306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 8:
						try
						{
							num = (short)1257439235;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									result = false;
									num = (short)1261568004;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)710672389;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Utilities.Astro25DataGroupID> enumerator2;
									if (!enumerator2.MoveNext())
									{
										goto IL_491;
									}
									global::SpecialFeatures.Utilities.Astro25DataGroupID astro25DataGroupID = enumerator2.Current;
									num = (short)1737752582;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_3BB;
									}
									continue;
								case 4:
									goto IL_3D8;
								case 5:
									goto IL_4C7;
								case 6:
								{
									global::SpecialFeatures.Utilities.Astro25DataGroupID astro25DataGroupID;
									if (value == astro25DataGroupID.DataGroupID)
									{
										num = (short)1566993902;
										short num3 = num;
										num = (short)1637641710;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_491;
										default:
											num = (short)2042101760;
											if (num != 0)
											{
											}
											num = (short)1817444352;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								}
								IL_46C:
								num = (short)2119958530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3BB:
								goto IL_46C;
								IL_491:
								num = (short)782237697;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3D8:
							IL_4C7:
							return result;
						}
						finally
						{
							num = (short)1868169217;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Utilities.Astro25DataGroupID> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_535;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4FE;
									}
									continue;
								case 2:
									enumerator2.Dispose();
									num = (short)928055296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4FE:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)977862658;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_535:;
						}
						goto IL_538;
					case 9:
						goto IL_311;
					case 10:
						result = true;
						num = (short)859832325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType = A_0.SystemSubType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.TYPEII;
						num = (short)685965324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
						if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
						{
							num = (short)614334479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)529596420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile2;
						if (apxdataProfile2 != null)
						{
							num = (short)1734344710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 14:
						if (value >= 1)
						{
							num = (short)1604780051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 15:
						num = (short)1939669006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						num = (short)222953473;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile2 = null;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator = A_1.APXDataProfiles.GetEnumerator();
						num = (short)2128871425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (systemType.GetValueOrDefault() == astroSystemType & systemType != null)
						{
							num = (short)1950351360;
							short num4 = num;
							num = (short)1966604299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 18:
						if (A_1.APXDataProfiles != null)
						{
							num = (short)9043984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 19:
						num = (short)996868103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (!string.IsNullOrWhiteSpace(A_0.SelectedDataProfileName))
						{
							num = (short)1269891074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_82;
					IL_311:
					result = true;
					num = (short)408158228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_538:
					num = (short)481099789;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_82:
				result = false;
				value = A_0.RadioId.Value;
				systemType = A_0.SystemType;
				astroSystemType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNCKING;
				num = (short)1895366673;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00002948 File Offset: 0x00000B48
		internal RMCRadioAccessValidator(global::SpecialFeatures.Comms.COMMS_OP WriteType, global::SpecialFeatures.Security.RadioSecurityData radSecData, global::SpecialFeatures.Security.RadioSecurityData cpgSecData, global::Motorola.CommonCPS.Server.EntityModel.Radio dv, bool writeProtectWriteProtectedRadio = false, bool otapBatchProgramming = false, bool flashportFromCvnToTrk = false, bool IsSkipWorkingCPParticularContentCheck = false) : base(WriteType, radSecData, cpgSecData, writeProtectWriteProtectedRadio, otapBatchProgramming, flashportFromCvnToTrk, IsSkipWorkingCPParticularContentCheck)
		{
			this.a = dv;
			this.IsRadioDeviceUpdated = false;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0008A740 File Offset: 0x00088940
		protected override void RestoreRadioWideSecurityData()
		{
			short num = (short)919011328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				bool? flag;
				bool? flag2;
				for (;;)
				{
					IL_27:
					int? num3;
					int? num4;
					switch (num2)
					{
					case 0:
						goto IL_18E;
					case 1:
						if (!(num3.GetValueOrDefault() == num4.GetValueOrDefault() & num3 != null == (num4 != null)))
						{
							num = (short)1490288649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_215;
					case 2:
					{
						(this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).DisableWriteProtect = (this.a.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).DisableWriteProtect;
						this.IsRadioDeviceUpdated = true;
						num = (short)905436638;
						short num5 = num;
						num = (short)2001001950;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_41C;
						default:
							num = (short)56688640;
							if (num != 0)
							{
							}
							num = (short)925564928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						(this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).AskRequired = (this.a.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).AskRequired;
						this.IsRadioDeviceUpdated = true;
						goto IL_41C;
					case 4:
						goto IL_215;
					case 5:
						goto IL_434;
					case 6:
						if (!(num4.GetValueOrDefault() == num3.GetValueOrDefault() & num4 != null == (num3 != null)))
						{
							num = (short)1800405002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_361;
					case 7:
					{
						num = (short)1828913152;
						short num6 = num;
						if (!(flag.GetValueOrDefault() == flag2.GetValueOrDefault() & flag != null == (flag2 != null)))
						{
							num = (short)1860698115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_510;
					}
					case 8:
						goto IL_361;
					case 9:
						(this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).HomeSystemId = (this.a.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).HomeSystemId;
						this.IsRadioDeviceUpdated = true;
						num = (short)1625161732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						(this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).OwnerWacnId = (this.a.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).OwnerWacnId;
						this.IsRadioDeviceUpdated = true;
						num = (short)17301512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (!(flag2.GetValueOrDefault() == flag.GetValueOrDefault() & flag2 != null == (flag != null)))
						{
							num = (short)176619522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18E;
					case 12:
						if (!(num3.GetValueOrDefault() == num4.GetValueOrDefault() & num3 != null == (num4 != null)))
						{
							num = (short)1171128334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_439;
					case 13:
						goto IL_439;
					case 14:
						(this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).OwnerAdvKeyType = (this.a.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).OwnerAdvKeyType;
						this.IsRadioDeviceUpdated = true;
						num = (short)784138253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A;
					IL_18E:
					num3 = (this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).OwnerAdvKeyType;
					num4 = (this.a.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).OwnerAdvKeyType;
					num = (short)1675558924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_215:
					flag = (this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).AskRequired;
					flag2 = (this.a.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).AskRequired;
					num = (short)456654855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_361:
					num3 = (this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).HomeSystemId;
					num4 = (this.a.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).HomeSystemId;
					num = (short)993525761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41C:
					num = (short)1918500869;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_439:
					num4 = (this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).OwnerWacnId;
					num3 = (this.a.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).OwnerWacnId;
					num = (short)49414150;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_434:
				IL_510:
				num = (short)968491009;
				if (num != 0)
				{
				}
				return;
				IL_6A:
				flag2 = (this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).DisableWriteProtect;
				flag = (this.a.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).DisableWriteProtect;
				num = (short)132841483;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0008AC84 File Offset: 0x00088E84
		protected override void RestoreOwnerSystemData()
		{
			short num = (short)414884167;
			short num2 = num;
			num = (short)1298047303;
			switch (num2 == num)
			{
			}
			num = (short)1101070337;
			if (num != 0)
			{
			}
			num = (short)1795686400;
			if (num != 0)
			{
			}
			num = (short)1891303424;
			short num3 = num;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0008AD2C File Offset: 0x00088F2C
		protected override bool RestoreASKRequiredFlag(bool bUnLimitedOwnASKAttached)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
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
					num2 = (short)21692427;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (this.a.WorkingCodeplug != null)
					{
						goto IL_16B;
					}
					return result;
				case 2:
				{
					bool? askRequired;
					bool? askRequired2;
					if (!(askRequired.GetValueOrDefault() == askRequired2.GetValueOrDefault() & askRequired != null == (askRequired2 != null)))
					{
						num2 = (short)1284440072;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_188;
				}
				case 3:
					num2 = (short)2032664582;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				case 5:
				{
					bool? askRequired = (this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).AskRequired;
					bool? askRequired2 = (this.a.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).AskRequired;
					num2 = (short)1141964802;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (this.a.CurrentCodeplug != null)
					{
						num2 = (short)1939603468;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 7:
					if (this.a != null)
					{
						num2 = (short)944570371;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 8:
					num2 = (short)1979318282;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)407786129;
					short num3 = num2;
					num2 = (short)52777617;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16B;
					default:
						num2 = (short)177995776;
						if (num2 != 0)
						{
						}
						goto IL_188;
					}
					break;
				}
				case 10:
					if (!this.isFlashport)
					{
						num2 = (short)622788621;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_188;
				case 11:
					if (!bUnLimitedOwnASKAttached)
					{
						num2 = (short)2062286853;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_188;
				case 12:
					num2 = (short)170655745;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
				{
					(this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).AskRequired = (this.a.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).AskRequired;
					this.IsRadioDeviceUpdated = true;
					num2 = (short)1634402305;
					if (num2 != 0)
					{
					}
					num2 = (short)488701952;
					short num4 = num2;
					num2 = (short)711262217;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_48;
				IL_16B:
				num2 = (short)102694912;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_188:
				result = true;
				num2 = (short)1178402820;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_48:
			result = false;
			num2 = (short)759955463;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0008B044 File Offset: 0x00089244
		protected override void RestoreWriteProtect()
		{
			short num = (short)1197485504;
			short num2 = num;
			num = (short)573582784;
			switch (num2 == num)
			{
			}
			num = (short)854720513;
			if (num != 0)
			{
			}
			num = (short)1698234368;
			if (num != 0)
			{
			}
			num = (short)199753728;
			short num3 = num;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0008B0F0 File Offset: 0x000892F0
		protected override bool HandleWriteProtect(out string stsMsg)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
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
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					apxcodeplug.DisableWriteProtect = new bool?(true);
					this.IsRadioDeviceUpdated = true;
					num2 = (short)459276296;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)1863974913;
					if (num2 != 0)
					{
					}
					bool? disableWriteProtect;
					bool flag;
					if (disableWriteProtect.GetValueOrDefault() == flag & disableWriteProtect != null)
					{
						num2 = (short)1879900160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 2:
					if (this.WriteProtectWriteProtectedRadio)
					{
						num2 = (short)77725701;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					bool? disableWriteProtect = apxcodeplug.DisableWriteProtect;
					bool flag = false;
					num2 = (short)2048917505;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (this.OtapBatchProgramming)
					{
						num2 = (short)1461190663;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D9;
				case 5:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
					num2 = (short)1025585697;
					short num3 = num2;
					num2 = (short)1727476257;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)772407296;
						if (num2 != 0)
						{
						}
						num2 = (short)460914692;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
				{
					bool? disableWriteProtect;
					if (disableWriteProtect != null)
					{
						num2 = (short)523239427;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 7:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					bool? disableWriteProtect = apxcodeplug.DisableWriteProtect;
					num2 = (short)393805830;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					goto IL_9A;
				}
				goto IL_34;
			}
			IL_9A:
			num2 = (short)1991507968;
			short num4 = num2;
			return true;
			IL_1D9:
			stsMsg = global::CommonResources.AppResources.Write_Radio_Operation_Aborted_WP_Canceled_by_User;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.OperationIsCancelled, stsMsg);
			IL_34:
			stsMsg = null;
			num2 = (short)1165426690;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0008B32C File Offset: 0x0008952C
		protected override global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> GetCodeplugTrkSystemIDs()
		{
			short num = (short)1334444032;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_60;
				}
				global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID> collection;
				for (;;)
				{
					IL_29:
					int num3;
					global::AcpASKLib.KeyType sysKeyType;
					int value;
					bool? askRequired;
					string systemName;
					switch (num2)
					{
					case 0:
						goto IL_1E5;
					case 1:
						goto IL_C3;
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array;
						if (num3 >= array.Length)
						{
							num = (short)1302659075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)529279233;
						short num4 = num;
						num = (short)38938881;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C8;
						default:
						{
							num = (short)1009713152;
							if (num != 0)
							{
							}
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = array[num3].SystemType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNCKING;
							num = (short)948961289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						goto IL_21E;
					case 4:
						goto IL_157;
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array = (this.a.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).APXRadioSystems.OrderBy(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem sys)
						{
							short num8 = (short)1798111233;
							if (num8 != 0)
							{
							}
							num8 = (short)1397882880;
							short num9 = num8;
							num8 = (short)293532496;
							short num10 = num8;
							num8 = (short)1217393488;
							switch (num10 == num8)
							{
							}
							num8 = (short)1430650880;
							if (num8 != 0)
							{
							}
							return sys.OrderId;
						}).ToArray<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>();
						num3 = 0;
						num = (short)693305344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_1E5;
					case 7:
					{
						num = (short)488964096;
						short num5 = num;
						sysKeyType = global::AcpASKLib.KeyType.ADVANCED_WACN_KEY;
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array;
						int? num6 = array[num3].WacnId;
						value = num6.Value;
						askRequired = null;
						num = (short)748683275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						systemName = null;
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array;
						int? num6 = array[num3].CoverageType;
						int num7 = 5;
						num = (short)1544683530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType;
						if (systemType.GetValueOrDefault() == astroSystemType & systemType != null)
						{
							num = (short)1334050824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_157;
					}
					case 10:
					{
						int? num6;
						int num7;
						if (num6.GetValueOrDefault() == num7 & num6 != null)
						{
							num = (short)43122695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						sysKeyType = global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array;
						num6 = array[num3].SystemId;
						value = num6.Value;
						askRequired = new bool?(array[num3].AskRequired.GetValueOrDefault());
						systemName = array[num3].SystemName;
						goto IL_1C8;
					}
					case 11:
						goto IL_C3;
					}
					goto IL_60;
					IL_C3:
					global::SpecialFeatures.Security.TrkSysID item = new global::SpecialFeatures.Security.TrkSysID(sysKeyType, value, askRequired, systemName);
					collection.Add(item);
					num = (short)1884684292;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_157:
					num3++;
					num = (short)141885446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C8:
					num = (short)1134362625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E5:
					num = (short)1026359298;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_21E:
				this.SetUnlimitedAskRequiredFlagForSystemsWithAskReqModified(collection);
				return collection;
				IL_60:
				num = (short)857014273;
				if (num != 0)
				{
				}
				collection = new global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysID>();
				num = (short)1823408133;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0008B694 File Offset: 0x00089894
		internal void SetUnlimitedAskRequiredFlagForSystemsWithAskReqModified(global::System.Collections.Generic.IEnumerable<global::SpecialFeatures.Security.TrkSysID> trkSystems)
		{
			short num = (short)1424687104;
			switch (num)
			{
			default:
			{
				num = (short)691732487;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					var array2;
					var array3;
					switch (num2)
					{
					case 0:
						goto IL_2FE;
					case 1:
					{
						global::SpecialFeatures.Security.TrkSysID[] array = trkSystems.Where(delegate(global::SpecialFeatures.Security.TrkSysID x)
						{
							short num6 = (short)314857732;
							short num7 = num6;
							num6 = (short)1715820804;
							switch (num7 == num6)
							{
							default:
							{
								num6 = (short)72876032;
								short num8 = num6;
								break;
							}
							case true:
								break;
							}
							num6 = (short)1993080833;
							if (num6 != 0)
							{
							}
							num6 = (short)1224212480;
							if (num6 != 0)
							{
							}
							return x.AskRequired != null;
						}).ToArray<global::SpecialFeatures.Security.TrkSysID>();
						num3 = 0;
						goto IL_1BD;
					}
					case 2:
						if (array2.Length == 0)
						{
							num = (short)1714487304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1324613633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						array3 = null;
						goto IL_105;
					case 4:
					{
						num = (short)1371807107;
						short num4 = num;
						num = (short)750329219;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1BD;
						default:
							num = (short)223739904;
							if (num != 0)
							{
							}
							if (array2.Any(delegate(x)
							{
								short num6 = (short)336003072;
								int num7 = (int)num6;
								switch (num7)
								{
								default:
								{
									num6 = (short)739966976;
									short num8 = num6;
									int? systemId;
									int id;
									switch (0)
									{
									case 0:
										break;
									default:
									{
										for (;;)
										{
											IL_50:
											switch (num7)
											{
											case 0:
											{
												num6 = (short)47355055;
												short num9 = num6;
												num6 = (short)19371183;
												switch ((num9 == num6) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_7A;
												default:
													num6 = (short)449708033;
													if (num6 != 0)
													{
													}
													num6 = (short)1721892864;
													if (num6 != 0)
													{
													}
													num6 = (short)1262157825;
													num7 = (int)((global::System.IntPtr)num6);
													continue;
												}
												break;
											}
											case 1:
												if (x.SystemName == CS$<>8__locals1.trkSys.SystemName)
												{
													num6 = (short)1746010115;
													num7 = (int)((global::System.IntPtr)num6);
													continue;
												}
												return false;
											case 2:
												if (systemId.GetValueOrDefault() == id & systemId != null)
												{
													num6 = (short)462618624;
													num7 = (int)((global::System.IntPtr)num6);
													continue;
												}
												return false;
											case 3:
												goto IL_1AB;
											}
											goto IL_67;
										}
										IL_1AB:
										bool value = x.AskRequired.Value;
										bool? askRequired = CS$<>8__locals1.trkSys.AskRequired;
										return !(value == askRequired.GetValueOrDefault() & askRequired != null);
									}
									}
									IL_67:
									systemId = x.SystemId;
									id = CS$<>8__locals1.trkSys.ID;
									IL_7A:
									num6 = (short)1095434242;
									num7 = (int)((global::System.IntPtr)num6);
									goto IL_50;
								}
								}
							}))
							{
								num = (short)2063400966;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2DF;
						}
						break;
					}
					case 5:
						goto IL_338;
					case 6:
						CS$<>8__locals1.trkSys.AskRequired = new bool?(CS$<>8__locals1.trkSys.UnlimitedAskRequired = true);
						num = (short)326041612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					case 8:
						return;
					case 9:
						goto IL_2FE;
					case 10:
						if (array2 != null)
						{
							num = (short)103677965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
					{
						global::SpecialFeatures.Security.TrkSysID[] array;
						if (num3 >= array.Length)
						{
							num = (short)1303707653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1153630209;
						if (num != 0)
						{
						}
						global::SpecialFeatures.Security.TrkSysID trkSys = array[num3];
						num = (short)618790916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_2DF;
					case 13:
						num = (short)693174274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7B:
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = this.a.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
					if (apxcodeplug == null)
					{
						num = (short)52625411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					array3 = apxcodeplug.APXRadioSystems.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem x)
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = x.SystemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNCKING;
						if (systemType.GetValueOrDefault() == astroSystemType & systemType != null)
						{
							short num6 = (short)724965066;
							short num7 = num6;
							num6 = (short)1971590858;
							switch ((num7 == num6) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num6 = (short)1695678464;
								short num8 = num6;
								num6 = (short)2033254400;
								if (num6 != 0)
								{
								}
								num6 = (short)366018561;
								if (num6 != 0)
								{
								}
								break;
							}
							}
							return x.AskRequired != null;
						}
						return false;
					}).Select(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem x)
					{
						short num6 = (short)347689810;
						short num7 = num6;
						num6 = (short)43144018;
						switch (num7 == num6)
						{
						default:
						{
							num6 = (short)423690240;
							short num8 = num6;
							break;
						}
						case true:
							break;
						}
						num6 = (short)1767112704;
						if (num6 != 0)
						{
						}
						num6 = (short)269287425;
						if (num6 != 0)
						{
						}
						return new
						{
							x.SystemId,
							x.SystemName,
							x.AskRequired
						};
					}).ToArray();
					IL_105:
					array2 = array3;
					num = (short)740294666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BD:
					num = (short)1073610752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DF:
					num3++;
					num = (short)418775049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FE:
					num = (short)1723596811;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_338:
				num = (short)1508507648;
				short num5 = num;
				return;
			}
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0008BA08 File Offset: 0x00089C08
		protected override bool IsCpgOwnerIDValid(out string stsMsg)
		{
			short num = (short)1228848710;
			short num2 = num;
			num = (short)1318829638;
			switch (num2 == num)
			{
			}
			num = (short)1425473537;
			if (num != 0)
			{
			}
			num = (short)1022492672;
			if (num != 0)
			{
			}
			num = (short)1243414528;
			short num3 = num;
			stsMsg = null;
			return true;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0008BAB8 File Offset: 0x00089CB8
		protected override void UpdateASKProgrammingHistory()
		{
			short num = (short)1805320192;
			switch (num)
			{
			default:
			{
				num = (short)1867251718;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::SpecialFeatures.Utilities.AstroASKProgrammingHistory astroASKProgrammingHistory;
					string text;
					int num3;
					string text2;
					global::System.Collections.Generic.SortedList<long, global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem> sortedList;
					global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem> enumerator;
					global::System.Xml.Serialization.XmlSerializer xmlSerializer;
					int num5;
					global::System.IO.StringWriter stringWriter;
					switch (num2)
					{
					case 0:
						goto IL_265;
					case 1:
						if (astroASKProgrammingHistory.Recset != null)
						{
							num = (short)1400045568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6EF;
					case 2:
						if (this.askSerialNumList.Count > 0)
						{
							num = (short)1958805523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)2069823499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9D8;
					case 4:
						goto IL_945;
					case 5:
						if (num3 < 0)
						{
							num = (short)2065104900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1395982359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_BA;
						}
						continue;
					case 7:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = (global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)this.a.WorkingCodeplug;
						if (apxcodeplug == null)
						{
							num = (short)632750096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text2 = apxcodeplug.AstroSysKeyLog;
						goto IL_7F8;
					}
					case 8:
						num = (short)1313210369;
						if (num != 0)
						{
						}
						sortedList.Remove(0L);
						num = (short)575012876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1005584386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						try
						{
							num = (short)1931608067;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1243611137;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1F3;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_126;
									}
									continue;
								case 4:
								{
									global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem askprogrammingHistoryItem;
									sortedList.Add(askprogrammingHistoryItem.LastProgramDateTime, askprogrammingHistoryItem);
									num = (short)1488322562;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem askprogrammingHistoryItem;
									if (!sortedList.ContainsKey(askprogrammingHistoryItem.LastProgramDateTime))
									{
										num = (short)97386500;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1706885120;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem askprogrammingHistoryItem = enumerator.Current;
									num = (short)732233733;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_128:
								num = (short)1197867014;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_126:
								goto IL_128;
							}
							IL_1F3:
							goto IL_71A;
						}
						finally
						{
							num = (short)1351614465;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_262;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_22A;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)199426048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_22A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)209649666;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_262:;
						}
						goto IL_265;
						IL_71A:
						int num4 = 0;
						global::System.Collections.Generic.IEnumerator<string> enumerator2 = this.askSerialNumList.GetEnumerator();
						num = (short)2082865176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						astroASKProgrammingHistory = (global::SpecialFeatures.Utilities.AstroASKProgrammingHistory)xmlSerializer.Deserialize(new global::System.IO.StringReader(text));
						num = (short)1460535322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_A22;
					case 13:
						if (sortedList.Count > 0)
						{
							num = (short)708509721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_945;
					case 14:
						astroASKProgrammingHistory.Recset.Add(sortedList.Values[num3]);
						num5++;
						num3--;
						num = (short)838139925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						num = (short)240386048;
						short num6 = num;
						if (sortedList.ContainsKey(0L))
						{
							num = (short)1801125896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A22;
					}
					case 16:
						text2 = null;
						goto IL_7F8;
					case 17:
						return;
					case 18:
					{
						int num4;
						if (num4 > 0)
						{
							num = (short)246480916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A22;
					}
					case 19:
						goto IL_6A0;
					case 20:
						goto IL_3CD;
					case 21:
						goto IL_87A;
					case 22:
						goto IL_6EF;
					case 23:
						if (num5 < 25)
						{
							num = (short)603783182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_945;
					case 24:
						try
						{
							num = (short)316801029;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int num4;
								switch (num2)
								{
								case 0:
									goto IL_5DF;
								case 1:
								{
									long num7;
									if (!sortedList.ContainsKey(num7))
									{
										num = (short)348127236;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4E5;
								}
								case 2:
									goto IL_4E5;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<string> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1098711046;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text3 = enumerator2.Current;
									global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem askprogrammingHistoryItem2 = new global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem();
									askprogrammingHistoryItem2.SerialNumber = text3.ToUpper();
									global::System.DateTime now = global::System.DateTime.Now;
									global::System.DateTime dateTime = new global::System.DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second, now.Millisecond);
									long num7 = dateTime.ToUniversalTime().Ticks + (long)num4;
									askprogrammingHistoryItem2.LastProgramDateTime = num7;
									num = (short)1031340033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									long num7;
									global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem askprogrammingHistoryItem2;
									sortedList.Add(num7, askprogrammingHistoryItem2);
									num = (short)643039234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_480;
									}
									continue;
								case 6:
									num = (short)441319424;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4A7:
								num = (short)1301544963;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_480:
								goto IL_4A7;
								IL_4E5:
								num4++;
								num = (short)380174343;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5DF:
							goto IL_76D;
						}
						finally
						{
							num = (short)850264065;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1613957361;
								short num8 = num;
								num = (short)950601969;
								switch ((num8 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num = (short)893386752;
									if (num != 0)
									{
									}
									global::System.Collections.Generic.IEnumerator<string> enumerator2;
									switch (num2)
									{
									case 0:
										goto IL_69D;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_661;
										}
										continue;
									case 2:
										enumerator2.Dispose();
										goto IL_684;
									}
									IL_661:
									if (enumerator2 != null)
									{
										num = (short)1735524354;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_69F;
								}
								}
								IL_684:
								num = (short)104398848;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_69D:
							IL_69F:;
						}
						goto IL_6A0;
						IL_76D:
						num = (short)712441874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)2114322433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_9D8;
					case 27:
						try
						{
							global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(stringWriter, new global::System.Xml.XmlWriterSettings
							{
								Indent = true,
								OmitXmlDeclaration = true
							});
							try
							{
								global::System.Xml.Serialization.XmlSerializerNamespaces namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces(new global::System.Xml.XmlQualifiedName[]
								{
									global::System.Xml.XmlQualifiedName.Empty
								});
								xmlSerializer.Serialize(xmlWriter, astroASKProgrammingHistory, namespaces);
								((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)this.a.WorkingCodeplug).AstroSysKeyLog = stringWriter.ToString();
								goto IL_748;
							}
							finally
							{
								num = (short)531103745;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_35E;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_325;
										}
										continue;
									case 2:
										((global::System.IDisposable)xmlWriter).Dispose();
										num = (short)1516109824;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_325:
									if (xmlWriter == null)
									{
										break;
									}
									num = (short)360316930;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_35E:;
							}
						}
						finally
						{
							num = (short)529203201;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3CA;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_393;
									}
									continue;
								case 2:
									((global::System.IDisposable)stringWriter).Dispose();
									num = (short)1486749696;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_393:
								if (stringWriter == null)
								{
									break;
								}
								num = (short)1742471170;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3CA:;
						}
						goto IL_3CD;
						IL_748:
						this.IsRadioDeviceUpdated = true;
						num = (short)261554193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_87A;
					}
					IL_BA:
					if (this.askSerialNumList != null)
					{
						num = (short)928120841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_265:
					astroASKProgrammingHistory.Recset.Clear();
					num = (short)207880214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CD:
					num = (short)919273487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6A0:
					xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::SpecialFeatures.Utilities.AstroASKProgrammingHistory));
					sortedList = new global::System.Collections.Generic.SortedList<long, global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem>();
					astroASKProgrammingHistory = new global::SpecialFeatures.Utilities.AstroASKProgrammingHistory();
					num = (short)1495597063;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6EF:
					num5 = 0;
					num3 = sortedList.Count - 1;
					num = (short)1774583836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F8:
					text = text2;
					num = (short)997064707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_87A:
					num = (short)1457258501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_945:
					stringWriter = new global::System.IO.StringWriter();
					num = (short)2089680923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9D8:
					enumerator = astroASKProgrammingHistory.Recset.GetEnumerator();
					num = (short)680722442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A22:
					num = (short)1515520013;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0008C590 File Offset: 0x0008A790
		protected override void UpdateTrkSysShuffledBandPlans()
		{
			short num = (short)1529282560;
			switch (num)
			{
			default:
			{
				num = (short)2021064727;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] a_;
					int num3;
					global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						apxradioSystem.ShuffeledBandPlan = new bool?(false);
						this.IsRadioDeviceUpdated = true;
						num = (short)1005125646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						int value;
						if (this.a(value, a_))
						{
							num = (short)2144927765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1882193945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_54E;
					case 3:
						return;
					case 4:
					{
						bool? shuffeledBandPlan;
						bool flag;
						if (shuffeledBandPlan.GetValueOrDefault() == flag & shuffeledBandPlan != null)
						{
							num = (short)314376192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_530;
					}
					case 5:
						num = (short)1931411471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						bool? shuffeledBandPlan;
						bool flag;
						if (!(shuffeledBandPlan.GetValueOrDefault() == flag & shuffeledBandPlan != null))
						{
							num = (short)1161035788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_530;
					}
					case 7:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType = apxradioSystem.SystemSubType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.TYPEII;
						num = (short)1828388881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						bool? shuffeledBandPlan = apxradioSystem.ShuffeledBandPlan;
						bool flag = true;
						num = (short)146931718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (this.a(this.a.CurrentCodeplug, this.a.ModelNumber))
						{
							num = (short)1923940357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						num = (short)1695219721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_530;
					case 12:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						apxradioSystem.ShuffeledBandPlan = new bool?(true);
						this.IsRadioDeviceUpdated = true;
						num = (short)17563659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						if (num3 >= array.Length)
						{
							num = (short)941359104;
							short num4 = num;
							num = (short)1600192515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem = array[num3];
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = apxradioSystem.SystemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNCKING;
						num = (short)1630076946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_530;
					case 15:
						goto IL_144;
					case 16:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						int value = apxradioSystem.SystemId.Value;
						num = (short)1410072577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
						if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
						{
							num = (short)1777664016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_530;
					}
					case 18:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType;
						if (systemType.GetValueOrDefault() == astroSystemType & systemType != null)
						{
							num = (short)484835335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_530;
					}
					case 19:
						num = (short)275316737;
						if (num != 0)
						{
						}
						goto IL_54E;
					case 20:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						apxradioSystem.ShuffeledBandPlan = new bool?(true);
						this.IsRadioDeviceUpdated = true;
						num = (short)1541341206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						bool? shuffeledBandPlan = apxradioSystem.ShuffeledBandPlan;
						bool flag = true;
						num = (short)843513880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						num = (short)1424705463;
						short num5 = num;
						num = (short)1804617655;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_144;
						default:
							num = (short)1624637440;
							if (num != 0)
							{
							}
							goto IL_530;
						}
						break;
					}
					case 23:
						switch (0)
						{
						case 0:
							goto IL_AD;
						}
						continue;
					case 24:
					{
						bool? shuffeledBandPlan;
						bool flag;
						if (!(shuffeledBandPlan.GetValueOrDefault() == flag & shuffeledBandPlan != null))
						{
							num = (short)1531641876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_530;
					}
					case 25:
					{
						int value;
						if (global::AcpSecurityLib.SecurityManager.IsSystemKeyLoaded(value, 0, true))
						{
							num = (short)577765384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						bool? shuffeledBandPlan = apxradioSystem.ShuffeledBandPlan;
						bool flag = true;
						num = (short)1696268292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_AD:
					if (!this.cpgSecData.IsConventionalOnly)
					{
						num = (short)1669595146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_144:
					global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array2 = ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)this.a.WorkingCodeplug).APXRadioSystems.OrderBy(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem sys)
					{
						short num6 = (short)519784007;
						short num7 = num6;
						num6 = (short)1744062023;
						switch (num7 == num6)
						{
						default:
						{
							num6 = (short)1743781888;
							short num8 = num6;
							break;
						}
						case true:
							break;
						}
						num6 = (short)1812594689;
						if (num6 != 0)
						{
						}
						num6 = (short)2114191360;
						if (num6 != 0)
						{
						}
						return sys.OrderId;
					}).ToArray<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>();
					a_ = ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)this.a.CurrentCodeplug).APXRadioSystems.OrderBy(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem sys)
					{
						short num6 = (short)537954202;
						short num7 = num6;
						num6 = (short)1218152346;
						switch (num7 == num6)
						{
						default:
						{
							num6 = (short)983629824;
							short num8 = num6;
							break;
						}
						case true:
							break;
						}
						num6 = (short)933429249;
						if (num6 != 0)
						{
						}
						num6 = (short)1146159104;
						if (num6 != 0)
						{
						}
						return sys.OrderId;
					}).ToArray<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>();
					array = array2;
					num3 = 0;
					num = (short)1311047699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_530:
					num3++;
					num = (short)154730498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54E:
					num = (short)863698957;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0008CB54 File Offset: 0x0008AD54
		private bool a(int A_0, global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] A_1)
		{
			short num = (short)1834745856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				bool result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						bool? shuffeledBandPlan = apxradioSystem.ShuffeledBandPlan;
						bool flag = true;
						num = (short)1752956934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						result = true;
						num = (short)175767553;
						if (num != 0)
						{
						}
						num = (short)1550057480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						int? systemId;
						if (systemId.GetValueOrDefault() == A_0 & systemId != null)
						{
							num = (short)1205207040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_233;
					}
					case 3:
						goto IL_1D2;
					case 4:
					{
						int num3 = 0;
						num = (short)354091013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_1D2;
					case 6:
					{
						bool? shuffeledBandPlan;
						bool flag;
						if (shuffeledBandPlan.GetValueOrDefault() == flag & shuffeledBandPlan != null)
						{
							num = (short)483590145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_233;
					}
					case 7:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						int? systemId = apxradioSystem.SystemId;
						num = (short)1651048450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						return result;
					case 9:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
						if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
						{
							goto IL_330;
						}
						goto IL_233;
					}
					case 10:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType;
						if (systemType.GetValueOrDefault() == astroSystemType & systemType != null)
						{
							num = (short)1421737997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_233;
					}
					case 11:
					{
						int num3;
						if (num3 >= A_1.Length)
						{
							num = (short)1633550350;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem = A_1[num3];
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = apxradioSystem.SystemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNCKING;
						num = (short)1120337930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (A_1 != null)
						{
							num = (short)470024196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 13:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType = apxradioSystem.SystemSubType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.TYPEII;
						num = (short)1951334409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						return result;
					}
					goto IL_6B;
					IL_1D2:
					num = (short)1955659787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_233:
					num = (short)1272594191;
					short num4 = num;
					num = (short)611729167;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_330:
						num = (short)265355271;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)1244200960;
						if (num != 0)
						{
						}
						int num3;
						num3++;
						num = (short)1148911619;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return result;
				IL_6B:
				result = false;
				num = (short)892469248;
				short num5 = num;
				num = (short)1440153612;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0008CEB0 File Offset: 0x0008B0B0
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.Codeplug A_0, string A_1)
		{
			short num = (short)1649527305;
			short num2 = num;
			num = (short)1564199433;
			switch (num2 == num)
			{
			}
			num = (short)923205633;
			if (num != 0)
			{
			}
			num = (short)1272053760;
			if (num != 0)
			{
			}
			num = (short)429457408;
			short num3 = num;
			string flashCode = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString((A_0 as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).AstroPurchasedFlashCode, (A_0 as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).AstroPurchasedFlashCode.Length);
			return global::SpecialFeatures.Security.RadioAccessValidator.Is800MHzBandEnabled(A_1, flashCode);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0008CF80 File Offset: 0x0008B180
		private static global::SpecialFeatures.Security.RadioSecurityData a(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_0, string A_1)
		{
			short num = (short)612564993;
			if (num != 0)
			{
			}
			num = (short)1391722496;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				string flashCode;
				bool bConvnOnly;
				for (;;)
				{
					IL_4D:
					switch (num2)
					{
					case 0:
					{
						num = (short)105891704;
						short num3 = num;
						num = (short)550750072;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_135;
						default:
							goto IL_187;
						}
						break;
					}
					case 1:
						goto IL_135;
					case 2:
						if (A_0.Template != null)
						{
							num = (short)16711683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bConvnOnly = global::SpecialFeatures.Security.RadioAccessValidator.IsConvOnly(A_1, flashCode, false);
						num = (short)2045837313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate = A_0.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate;
						string flashCode2 = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(apxtemplate.AstroPurchasedFlashCode, apxtemplate.AstroPurchasedFlashCode.Length);
						bConvnOnly = global::SpecialFeatures.Security.RadioAccessValidator.IsConvOnly(apxtemplate.ModelNumber, flashCode2, false);
						num = (short)1225326596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_137;
					}
					goto IL_68;
					IL_137:
					num = (short)1339686912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_135:
					goto IL_137;
				}
				IL_187:
				num = (short)1811283968;
				if (num != 0)
				{
				}
				num = (short)421920768;
				short num4 = num;
				global::SpecialFeatures.Security.ProtectionOption protectionOption = global::SpecialFeatures.Security.RadioAccessValidator.GetProtectionOption(A_1, flashCode, false);
				int advKeyType;
				int ownerWacnId;
				int ownerSystemId;
				bool bASKRequired;
				if (protectionOption == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
				{
					if (A_0.OwnerAdvKeyType != null)
					{
						advKeyType = A_0.OwnerAdvKeyType.Value;
					}
					if (A_0.OwnerWacnId != null)
					{
						ownerWacnId = A_0.OwnerWacnId.Value;
					}
					if (A_0.HomeSystemId != null)
					{
						ownerSystemId = A_0.HomeSystemId.Value;
					}
					if (A_0.AskRequired != null)
					{
						bASKRequired = A_0.AskRequired.Value;
					}
				}
				bool bWriteProtected;
				if (A_0.DisableWriteProtect != null)
				{
					bWriteProtected = A_0.DisableWriteProtect.Value;
				}
				return new global::SpecialFeatures.Security.RadioSecurityData(protectionOption, advKeyType, ownerSystemId, ownerWacnId, bASKRequired, bWriteProtected, bConvnOnly, null, null);
				IL_68:
				advKeyType = 0;
				ownerSystemId = 0;
				ownerWacnId = 0;
				bASKRequired = false;
				bWriteProtected = false;
				flashCode = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(A_0.AstroPurchasedFlashCode, A_0.AstroPurchasedFlashCode.Length);
				bConvnOnly = false;
				num = (short)524288002;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4D;
			}
			}
		}

		// Token: 0x04000339 RID: 825
		private global::Motorola.CommonCPS.Server.EntityModel.Radio a;

		// Token: 0x0400033A RID: 826
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;
	}
}
