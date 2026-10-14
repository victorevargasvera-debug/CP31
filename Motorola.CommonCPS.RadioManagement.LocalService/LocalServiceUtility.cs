using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.ActivityBuilderLib;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Converters;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000046 RID: 70
	public static class LocalServiceUtility
	{
		// Token: 0x06000240 RID: 576 RVA: 0x000297C8 File Offset: 0x000279C8
		public static string SpecialFieldsConverterForCSV(string fieldName, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase rd)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus;
				switch (num)
				{
				case 0:
					num2 = (short)828375043;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					if (!(fieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("砬昮笰尲圴搶䴸娺䤼䨾㉀", a_)))
					{
						num2 = (short)894959616;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					uijobStatus = rd.UIJobStatus;
					num2 = (short)2054946822;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					uijobStatus = rd.UIJobStatus;
					result = uijobStatus.Value.ToResourceString();
					num2 = (short)978059265;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1820721154;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_D5;
				case 7:
					if (!(fieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("砬昮爰嬲吴夶常帺琼儾╀⩂♄♆㵈⑊㽌", a_)))
					{
						num2 = (short)1602682885;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::Motorola.CommonCPS.RadioManagement.Converters.ChangeIndivatorConverter.ConvertChangeIndicatorToString(rd.UIChangeIndicator);
					num2 = (short)1613234184;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					num2 = (short)1809324878;
					short num3 = num2;
					num2 = (short)1313545038;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D5;
					default:
						goto IL_17E;
					}
					break;
				}
				}
				goto IL_3D;
				IL_D5:
				if (uijobStatus == null)
				{
					return result;
				}
				num2 = (short)1894580224;
				short num4 = num2;
				num2 = (short)537133060;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_17E:
			num2 = (short)1622802432;
			if (num2 != 0)
			{
			}
			return result;
			IL_3D:
			num2 = (short)1218314241;
			if (num2 != 0)
			{
			}
			result = string.Empty;
			num2 = (short)32964615;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00029A04 File Offset: 0x00027C04
		public static global::System.Guid? ConvertGroupID(global::System.Guid? groupId)
		{
			short num = (short)1889468424;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Guid? result;
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					num = (short)1911947269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_B0;
				case 2:
					if (result == null)
					{
						num = (short)1004863492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)974913543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1D9;
				case 4:
					num = (short)19070977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)299696128;
					short num3 = num;
					flag = false;
					goto IL_1C0;
				}
				case 6:
				{
					num = (short)2056978433;
					if (num != 0)
					{
					}
					result = groupId;
					global::System.Guid empty = global::System.Guid.Empty;
					num = (short)965547578;
					short num4 = num;
					num = (short)1850676794;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B0;
					default:
						num = (short)307363840;
						if (num != 0)
						{
						}
						num = (short)1971912713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
				{
					global::System.Guid empty;
					flag = (result.GetValueOrDefault() == empty);
					goto IL_1C0;
				}
				case 8:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 9:
					if (result == null)
					{
						num = (short)2020278272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)789708802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4C:
				if (groupId != null)
				{
					num = (short)1466826758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return groupId;
				IL_1C0:
				if (flag)
				{
					num = (short)1718878211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return groupId;
				IL_B0:
				flag = true;
				goto IL_1C0;
			}
			IL_1D9:
			result = null;
			return result;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00029C34 File Offset: 0x00027E34
		public static bool IsIntegrated(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase validatedRadio)
		{
			short num = (short)1962041017;
			short num2 = num;
			num = (short)168058553;
			switch (num2 == num)
			{
			default:
			{
				num = (short)112852992;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)643432449;
			if (num != 0)
			{
			}
			num = (short)1988820992;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.HasMVO(validatedRadio);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00029CE4 File Offset: 0x00027EE4
		public static bool IsConfigurationMode()
		{
			short num = (short)2138825638;
			short num2 = num;
			num = (short)1696523174;
			switch (num2 == num)
			{
			default:
			{
				num = (short)412876800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)138936321;
			if (num != 0)
			{
			}
			num = (short)750845952;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00029D94 File Offset: 0x00027F94
		public static bool IsAllowDowngrade()
		{
			int a_ = 19;
			short num;
			bool result;
			try
			{
				num = (short)1551564802;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						result = true;
						num = (short)743440387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_FD;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3E;
						}
						continue;
					case 3:
					{
						num = (short)1454659053;
						short num3 = num;
						num = (short)1962956269;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E3;
						default:
							goto IL_CC;
						}
						break;
					}
					}
					IL_3E:
					if (string.Equals(global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("缬戮爰稲䘴瘶唸场刼䠾Հⱂ㉄⥆่㥊ⱌ⭎㑐", a_)], global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("夬崮䐰嘲", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						num = (short)1357971456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E3:
					result = false;
					num = (short)1994391553;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CC:
				num = (short)1200947200;
				if (num != 0)
				{
				}
				IL_FD:;
			}
			catch
			{
				result = false;
			}
			num = (short)1770389504;
			short num4 = num;
			num = (short)1519910913;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00029F08 File Offset: 0x00028108
		public static string CommonConstrainErrorCodeToResource(global::Motorola.Common.CustomException.CommonErrorCode CommonConstrainErrorCode)
		{
			int a_ = 13;
			short num = (short)759300096;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3B;
					}
					continue;
				case 1:
					num = (short)1946681346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_21D;
				}
				IL_3B:
				switch (CommonConstrainErrorCode)
				{
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNPeerIP_NoSame_PeerIP:
					goto IL_2F6;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNPeerIP_NoSame_SubIP:
					goto IL_2A3;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_BDUNPeerIP:
					goto IL_3AA;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_PeerIP:
					goto IL_3B0;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_SubIP:
					goto IL_314;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothName_Over14Chars:
					goto IL_35C;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_InvalidOTARId:
					goto IL_2F0;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_InvalidRadioAlias:
					goto IL_308;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_IP_NoStartZero:
					goto IL_24F;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_IP_NotProperFormat:
					goto IL_344;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_IPFirstPart_NotProperNumber:
					goto IL_249;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_IP_NotProperClassCFormat:
					goto IL_31A;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_IP_NotProperClassBFormat:
					goto IL_180;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_IP_NotProperClassAFormat:
					goto IL_27F;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_PeerIP_NoSame_AirInterfaceIP:
					goto IL_1EE;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNPeerIP_NoSame_ProfilePeerIP:
					goto IL_255;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNPeerIP_NoSame_ProfileSubIP:
					goto IL_291;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNSubIP_NoSame_ProfileBDUNPeerIP:
					goto IL_297;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNSubIP_NoSame_ProfilePeerIP:
					goto IL_28B;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNSubIP_NoSame_ProfileSubIP:
					goto IL_279;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfilePeerIP_NoSame_AirInterfaceIP:
					goto IL_302;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfilePeerIP_Same_DataWidePeerIP:
					goto IL_2DE;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubscriberIP_Same_DataWideSubscriberIP:
					goto IL_30E;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNPeerIP_Same_DataWideBluetoothDUNPeerIP:
					goto IL_261;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNSubIP_Same_DataWideBluetoothDUNSubIP:
					goto IL_39E;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_AirInterfaceIP:
					goto IL_392;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_AutomaticRegistrationServerAddressIP:
					goto IL_2D8;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_ProfilePeerIP:
					goto IL_326;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_AutomaticRegistrationServerAddressIP:
					goto IL_267;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_BlueToothDUNPeerIP:
					goto IL_26D;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_BlueToothDUNSubIP:
					goto IL_2E4;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_PeerIP:
					goto IL_200;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_ProfileBlueToothDUNPeerIP:
					goto IL_38C;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_ProfileBlueToothDUNSubIP:
					goto IL_350;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_ProfilePeerIP:
					goto IL_374;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_ProfileSubIP:
					goto IL_2D2;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_SubIP:
					goto IL_36E;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_AutomaticRegistrationServerAddressIP:
					goto IL_29D;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_LocationServerIPAddress:
					goto IL_37A;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_LocationServerIPAddress:
					goto IL_17A;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBlueToothDunSubIP_NoSame_LocationServerIPAddress:
					goto IL_1E8;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_LocationServerIPAddress:
					goto IL_356;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_LocationServerIPAddress:
					goto IL_368;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_PeerIP:
					goto IL_34A;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_ProfilePeerIP:
					goto IL_3A4;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserLoginUnitID_CannotAllWhiteSpace:
					goto IL_273;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserLoginUnitID_Exceed_User_Login_UnitID_Text_Size:
					goto IL_320;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserLoginUnitID_FormatError:
					goto IL_380;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserName_InvalidChars:
					goto IL_1DC;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserName_OverChars:
					goto IL_174;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserPin_FormatError:
					goto IL_398;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserPin_OverChars:
					goto IL_362;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_PCRSubScriberIP_NotProperFormat:
					goto IL_332;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch:
					goto IL_3BC;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_SubIPLink2:
					goto IL_285;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_PeerIP_NoSame_SubIPLink2:
					goto IL_32C;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_PeerIPLink2:
					goto IL_2EA;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_PeerIP_NoSame_PeerIPLink2:
					goto IL_186;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNPeerIP_NoSame_BluetoothPANNetworkBaseAddress:
					goto IL_1F4;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_BluetoothPANNetworkBaseAddress:
					goto IL_25B;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_PeerIP_NoSame_BluetoothPANNetworkBaseAddress:
					goto IL_338;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNPeerIP_NoSame_BluetoothPANNetworkBaseAddress:
					goto IL_1E2;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNSubIP_NoSame_BluetoothPANNetworkBaseAddress:
					goto IL_2FC;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfilePeerIP_NoSame_BluetoothPANNetworkBaseAddress:
					goto IL_33E;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_BluetoothPANNetworkBaseAddress:
					goto IL_386;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubscriberIP_NoSame_BluetoothPANNetworkBaseAddress:
					goto IL_1FA;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_BluetoothPANNetworkBaseAddress:
					goto IL_3B6;
				case global::Motorola.Common.CustomException.CommonErrorCode.Constrain_InvalidVRID:
					goto IL_18C;
				default:
					num = (short)462159873;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_174:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_UserName_OverChars;
			IL_17A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileSubIP_NoSame_LocationServerIPAddress;
			IL_180:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NotProperClassBFormat;
			IL_186:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Constrain_PeerIP_NoSame_PeerIPLink2;
			IL_18C:
			num = (short)1542521790;
			short num3 = num;
			num = (short)1749287870;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_2F6:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNPeerIP_NoSame_PeerIP;
			default:
				num = (short)1568866304;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.Error_InvalidVRID;
			}
			IL_1DC:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_UserName_InvalidChars;
			IL_1E2:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNPeerIP_NoSame_BluetoothPANNetworkBaseAddress;
			IL_1E8:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBlueToothDunSubIP_NoSame_LocationServerIPAddress;
			IL_1EE:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.PeerIP_NoSame_AirInterfaceIP;
			IL_1F4:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNPeerIP_NoSame_BluetoothPANNetworkBaseAddress;
			IL_1FA:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubscriberIP_NoSame_BluetoothPANNetworkBaseAddress;
			IL_200:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_PeerIP;
			IL_21D:
			num = (short)377159681;
			if (num != 0)
			{
			}
			goto IL_3BC;
			IL_249:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.IPFirstPart_NotProperNumber;
			IL_24F:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NoStartZero;
			IL_255:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNPeerIP_NoSame_ProfilePeerIP;
			IL_25B:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNSubIP_NoSame_BluetoothPANNetworkBaseAddress;
			IL_261:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNPeerIP_Same_DataWideBluetoothDUNPeerIP;
			IL_267:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_AutomaticRegistrationServerAddressIP;
			IL_26D:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_BlueToothDUNPeerIP;
			IL_273:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Wizard_Warning_UserLoginUnitID_CannotAllWhiteSpace;
			IL_279:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNSubIP_NoSame_ProfileSubIP;
			IL_27F:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NotProperClassAFormat;
			IL_285:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Constrain_SubIP_NoSame_SubIPLink2;
			IL_28B:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNSubIP_NoSame_ProfilePeerIP;
			IL_291:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNPeerIP_NoSame_ProfileSubIP;
			IL_297:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNSubIP_NoSame_ProfileBDUNPeerIP;
			IL_29D:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubIP_NoSame_AutomaticRegistrationServerAddressIP;
			IL_2A3:
			num = (short)1771044864;
			short num4 = num;
			return global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNPeerIP_NoSame_SubIP;
			IL_2D2:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_ProfileSubIP;
			IL_2D8:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileSubIP_NoSame_AutomaticRegistrationServerAddressIP;
			IL_2DE:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfilePeerIP_Same_DataWidePeerIP;
			IL_2E4:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_BlueToothDUNSubIP;
			IL_2EA:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Constrain_SubIP_NoSame_PeerIPLink2;
			IL_2F0:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Error_InvalidOTARId;
			IL_2FC:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNSubIP_NoSame_BluetoothPANNetworkBaseAddress;
			IL_302:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfilePeerIP_NoSame_AirInterfaceIP;
			IL_308:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Error_InvalidRadioAlias;
			IL_30E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileSubIP_Same_DataWideSubIP;
			IL_314:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNSubIP_NoSame_SubIP;
			IL_31A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NotProperClassCFormat;
			IL_320:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_UserLoginUnitID_Exceed_User_Login_UnitID_Text_Size;
			IL_326:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileSubIP_NoSame_ProfilePeerIP;
			IL_32C:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Constrain_PeerIP_NoSame_SubIPLink2;
			IL_332:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.PCRSubScriberIP_NotProperFormat;
			IL_338:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.PeerIP_NoSame_BluetoothPANNetworkBaseAddress;
			IL_33E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfilePeerIP_NoSame_BluetoothPANNetworkBaseAddress;
			IL_344:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NotProperFormat;
			IL_34A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubIP_NoSame_PeerIP;
			IL_350:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_ProfileBlueToothDUNSubIP;
			IL_356:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_LocationServerIPAddress;
			IL_35C:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_BluetoothName_Over14Chars;
			IL_362:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Wizard_Warning_Pin;
			IL_368:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.BlueToothDunSubIP_NoSame_LocationServerIPAddress;
			IL_36E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_SubIP;
			IL_374:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_ProfilePeerIP;
			IL_37A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubIP_NoSame_LocationServerIPAddress;
			IL_380:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Wizard_Warning_UserLoginUnitID;
			IL_386:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_BluetoothPANNetworkBaseAddress;
			IL_38C:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_ProfileBlueToothDUNPeerIP;
			IL_392:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileSubIP_NoSame_AirInterfaceIP;
			IL_398:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Wizard_Warning_PinFormatError;
			IL_39E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNSubIP_Same_DataWideBluetoothDUNSubIP;
			IL_3A4:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SubIP_NoSame_ProfilePeerIP;
			IL_3AA:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNSubIP_NoSame_BDUNPeerIP;
			IL_3B0:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNSubIP_NoSame_PeerIP;
			IL_3B6:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileSubIP_NoSame_BluetoothPANNetworkBaseAddress;
			IL_3BC:
			throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䈦嬨太䈬崮", a_));
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0002A2E4 File Offset: 0x000284E4
		public static bool HasMVO(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio)
		{
			short num;
			for (;;)
			{
				num = (short)1349844992;
				short num2 = num;
				if (!string.IsNullOrEmpty(radio.ModelNumber))
				{
					return true;
				}
				num = (short)349175809;
				if (num != 0)
				{
				}
				num = (short)815573537;
				short num3 = num;
				num = (short)1926933025;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_93;
				}
			}
			IL_93:
			num = (short)833290240;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0002A3A0 File Offset: 0x000285A0
		public static string GetMaximumCpWorkingVer(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> devList)
		{
			short num = (short)1811873795;
			int num2 = (int)((global::System.IntPtr)num);
			string codeplugVersion;
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					num = (short)1276641285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (num3 >= devList.Count)
					{
						num = (short)1172963337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1183645706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1BA;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 4:
					goto IL_71;
				case 5:
					if (devList.Count != 0)
					{
						num = (short)1474297862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24F;
				case 6:
					codeplugVersion = devList[0].CodeplugVersion;
					num3 = 1;
					num = (short)302252040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					codeplugVersion = devList[num3].CodeplugVersion;
					num = (short)993067008;
					short num4 = num;
					num = (short)807538399;
					short num5 = num;
					num = (short)1388973791;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_57;
					default:
						num = (short)558891009;
						if (num != 0)
						{
						}
						num = (short)1878261760;
						if (num != 0)
						{
						}
						num = (short)1889206276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					goto IL_1BA;
				case 9:
					return codeplugVersion;
				case 10:
					if (string.Compare(codeplugVersion.Substring(1), devList[num3].CodeplugVersion.Substring(1), global::System.StringComparison.CurrentCulture) < 0)
					{
						num = (short)1456930823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_71;
				}
				goto IL_51;
				IL_57:
				num = (short)375390208;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_51:
				if (devList != null)
				{
					goto IL_57;
				}
				goto IL_24F;
				IL_71:
				num3++;
				num = (short)582483970;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BA:
				num = (short)2119630849;
				num2 = (int)((global::System.IntPtr)num);
			}
			return codeplugVersion;
			IL_24F:
			return string.Empty;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0002A604 File Offset: 0x00028804
		public static string GetMaximumCpCurrentVer(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> devList)
		{
			short num = (short)285409280;
			short num2 = num;
			num = (short)1521221632;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B1;
				}
				string text;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService;
				for (;;)
				{
					IL_52:
					int num4;
					global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
					switch (num3)
					{
					case 0:
						if (num4 >= devList.Count)
						{
							num = (short)1252720658;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BF;
					case 1:
						if (string.Compare(text.Substring(1), radio.CurrentCodeplug.CodeplugVersion.Substring(1), global::System.StringComparison.CurrentCulture) < 0)
						{
							num = (short)925368328;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_222;
					case 2:
						if (devList.Count != 0)
						{
							num = (short)2098855952;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C2;
					case 3:
						goto IL_27B;
					case 4:
						goto IL_21D;
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Radio radio2;
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(radio2.Timestamp, devList[0].RadioTimestamp))
						{
							num = (short)1837301769;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = radio2.CurrentCodeplug.CodeplugVersion;
						num4 = 0;
						num = (short)145358861;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Radio radio2;
						if (radio2 == null)
						{
							num = (short)2007367684;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)8060933;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(radio.Timestamp, devList[num4].RadioTimestamp))
						{
							num = (short)247529493;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)588709889;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						text = radio.CurrentCodeplug.CodeplugVersion;
						num = (short)233832459;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1A2;
					case 10:
						if (string.Compare(text.Substring(1), radio.WorkingCodeplug.FirmwareVersion.Substring(1), global::System.StringComparison.CurrentCulture) < 0)
						{
							num = (short)517210131;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A7;
					case 11:
						goto IL_222;
					case 12:
						num = (short)223870978;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_27B;
					case 14:
						num = (short)1658912769;
						if (num != 0)
						{
						}
						if (devList != null)
						{
							num = (short)737673228;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C2;
					case 15:
						goto IL_1A7;
					case 16:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Radio radio2 = radioService.GetRadio(devList[0].ID.Value, true);
						num = (short)698875910;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_412;
					case 18:
					{
						num = (short)671526820;
						short num5 = num;
						num = (short)1238740900;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3BF;
						default:
							goto IL_32F;
						}
						break;
					}
					case 19:
						text = radio.WorkingCodeplug.FirmwareVersion;
						num = (short)403111951;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (radio == null)
						{
							num = (short)1224474641;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)697171975;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_462;
					}
					goto IL_B1;
					IL_1A7:
					num4++;
					num = (short)233701379;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_222:
					num = (short)1040384010;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_27B:
					num = (short)359333888;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BF:
					radio = radioService.GetRadio(devList[num4].ID.Value, true);
					num = (short)1302396948;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1A2:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_21D:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
				IL_32F:
				num = (short)713621504;
				if (num != 0)
				{
				}
				return text;
				IL_412:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
				IL_462:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_4C2:
				return string.Empty;
				IL_B1:
				radioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
				num = (short)1186594830;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_52;
			}
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0002AAD8 File Offset: 0x00028CD8
		public static global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivitySet CreateBlankActivitySet()
		{
			int a_ = 3;
			short num = (short)722993152;
			short num2 = num;
			num = (short)723255297;
			if (num != 0)
			{
			}
			num = (short)1433683824;
			short num3 = num;
			num = (short)1447970672;
			switch (num3 == num)
			{
			}
			num = (short)2014052352;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivitySet activitySet = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivitySet();
			activitySet.HomeLayout = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HomeLayout
			{
				Expanded = true,
				Selected = true,
				Name = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唜瀞䰠䘢Ԥ欦䠨刪䈬娮䔰", a_),
				LstHLPanel = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HLPanel>
				{
					new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HLPanel
					{
						height = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("⬜", a_),
						pagenum = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ⴜ", a_),
						Name = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䴜縞传䘢䤤ܦᠨ", a_),
						Widgets = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase>()
					}
				}
			};
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activities activities = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activities();
			activities.Expanded = true;
			activities.Selected = false;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>();
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity();
			activity.state_id = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant.GetDefaultActivityType();
			activities.Initial = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant.GetDefaultActivityType();
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityPanelSetting apsbyActivityType = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant.GetAPSByActivityType(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityBuilderLibCommonService.GetEventTriggerDataString(activity.state_id));
			if (apsbyActivityType != null)
			{
				activity.screen_focused = apsbyActivityType.Screen_focused;
				activity.screen_locked = apsbyActivityType.Screen_locked;
				activity.screen_show = apsbyActivityType.Screen_show;
			}
			activity.Name = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityBuilderLibCommonService.GetEventTriggerUIstring(activity.state_id);
			activity.Widgets = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase>();
			list.Add(activity);
			activities.LstActivity = list;
			activitySet.Activities = activities;
			return activitySet;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0002ACD4 File Offset: 0x00028ED4
		public static string IsActivitySetValid(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivitySet currentActivitySet)
		{
			int a_ = 10;
			short num = (short)1719402503;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				int num5;
				switch (num2)
				{
				case 0:
					goto IL_29A;
				case 1:
					goto IL_1AD;
				case 2:
					num3++;
					num = (short)1130233861;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)348373424;
					short num4 = num;
					num = (short)2010366384;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AD;
					default:
						num = (short)1905262592;
						if (num != 0)
						{
						}
						if (currentActivitySet.HomeLayout.LstHLPanel[num5].Widgets.Count == 0)
						{
							num = (short)534642690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8F;
					}
					break;
				}
				case 4:
					goto IL_8A;
				case 5:
					goto IL_8F;
				case 6:
					goto IL_29A;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					continue;
				case 8:
					goto IL_36B;
				case 9:
					goto IL_21B;
				case 10:
					if (num5 >= currentActivitySet.HomeLayout.LstHLPanel.Count)
					{
						num = (short)774242317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)868941827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (currentActivitySet.HomeLayout.LstHLPanel == null)
					{
						num = (short)1139408905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1642135566;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_1DA;
				case 13:
					num = (short)1761280001;
					if (num != 0)
					{
					}
					num = (short)1859256321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (currentActivitySet.HomeLayout.LstHLPanel.Count == 0)
					{
						num = (short)1270153224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = 0;
					num5 = 0;
					num = (short)166133766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6A:
				if (currentActivitySet.HomeLayout == null)
				{
					num = (short)1489895428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1713504267;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8F:
				num5++;
				num = (short)391643136;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AD:
				if (num3 == currentActivitySet.HomeLayout.LstHLPanel.Count)
				{
					num = (short)137756684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_370;
				IL_29A:
				num = (short)822804490;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Invalid_Home_Set + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("Уᰥࠧ", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Home_Layout_Missing;
			IL_1DA:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Invalid_Home_Set + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("Уᰥࠧ", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_All_Home_Layout_Panels_Are_Empty;
			IL_21B:
			num = (short)184483840;
			short num6 = num;
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Invalid_Home_Set + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("Уᰥࠧ", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Home_Layout_Missing;
			IL_36B:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Invalid_Home_Set + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("Уᰥࠧ", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_No_Home_Layout_Panel;
			IL_370:
			return "";
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0002B058 File Offset: 0x00029258
		public static bool IsActivitySetChanged(object primaryActivitySet, object currentActivitySet)
		{
			int a_ = 18;
			short num = (short)1115095040;
			switch (num)
			{
			default:
			{
				num = (short)1399521304;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Reflection.PropertyInfo[] properties;
					global::System.Reflection.PropertyInfo propertyInfo;
					switch (num2)
					{
					case 0:
					{
						object value;
						if (value is global::System.Collections.IEnumerable)
						{
							num = (short)211484744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)834732071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)106627183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::System.Collections.IEnumerator enumerator;
						if (enumerator.MoveNext())
						{
							num = (short)1936326733;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					}
					case 3:
						goto IL_CA8;
					case 4:
					{
						global::System.Reflection.PropertyInfo[] a = primaryActivitySet.GetType().GetProperties();
						properties = currentActivitySet.GetType().GetProperties();
						num = (short)1428422766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						object value2;
						if (value2.GetType() == typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase>))
						{
							num = (short)640417879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)604438631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1078657079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::System.Collections.IEnumerator enumerator2;
						if (!enumerator2.MoveNext())
						{
							num = (short)168296449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)202834010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)1366884381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return true;
					case 10:
					{
						object value2;
						if (value2 != null)
						{
							num = (short)1251868720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					}
					case 11:
					{
						object value;
						if (!(value.GetType() == typeof(int)))
						{
							num = (short)307101812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE1;
					}
					case 12:
						return true;
					case 13:
						num = (short)1228144704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (currentActivitySet == null)
						{
							num = (short)106823753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4F;
					case 15:
						num = (short)867762176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_A57;
					case 17:
						if (!(propertyInfo.Name == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("椫嘭䀯匱娳刵崷帹", a_)))
						{
							num = (short)1073086565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					case 18:
						goto IL_7AB;
					case 19:
						return true;
					case 20:
						num = (short)2118254623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)586547285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)1895825512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						object value;
						if (!(value is bool))
						{
							num = (short)1401028623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					}
					case 24:
						switch (0)
						{
						case 0:
							goto IL_222;
						}
						continue;
					case 25:
					{
						object value;
						if (!(value.GetType() == typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>)))
						{
							num = (short)936050733;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A57;
					}
					case 26:
					{
						num = (short)783417344;
						short num3 = num;
						if (a2.a.Length == properties.Length)
						{
							num = (short)1211629659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 27:
						num = (short)251133962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						return true;
					case 29:
					{
						object value;
						if (!(value.GetType() == typeof(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetType)))
						{
							num = (short)1877671942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE1;
					}
					case 30:
					{
						object value;
						if (!(value.GetType() == typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HLPanel>)))
						{
							num = (short)758448206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CFC;
					}
					case 31:
						return true;
					case 32:
					{
						global::System.Collections.IEnumerator enumerator3;
						if (enumerator3.MoveNext())
						{
							num = (short)1448476735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					}
					case 33:
						return false;
					case 34:
						goto IL_CFC;
					case 35:
						goto IL_AE1;
					case 36:
						if (properties != null)
						{
							num = (short)342229097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 37:
						if (!(propertyInfo.Name == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("缫䬭尯圱圳䈵崷帹", a_)))
						{
							num = (short)767426628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					case 38:
					{
						object value;
						object value2;
						if (value.ToString() != value2.ToString())
						{
							num = (short)1575092273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					}
					case 39:
					{
						object value;
						if (!(value.GetType() == typeof(double)))
						{
							num = (short)616104022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE1;
					}
					case 40:
						num = (short)1889927182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
					{
						object value;
						if (!(value.GetType() == typeof(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType)))
						{
							num = (short)65798152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE1;
					}
					case 42:
					{
						object value;
						object value2;
						if (((global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HLPanel>)value).Count != ((global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HLPanel>)value2).Count)
						{
							num = (short)1184432181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.IEnumerator enumerator4 = ((global::System.Collections.IEnumerable)value).GetEnumerator();
						global::System.Collections.IEnumerator enumerator5 = ((global::System.Collections.IEnumerable)value2).GetEnumerator();
						num = (short)356384815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
					{
						object value;
						if (value == null)
						{
							num = (short)417923179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C52;
					}
					case 44:
						return true;
					case 45:
						num = (short)494665810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						num = (short)1929904164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_98E;
					case 48:
						num = (short)2133721111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						return true;
					case 50:
						goto IL_F63;
					case 51:
						return true;
					case 52:
					{
						global::System.Collections.IEnumerator enumerator6;
						if (enumerator6.MoveNext())
						{
							num = (short)1549271133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					}
					case 53:
						return true;
					case 54:
					{
						global::System.Collections.IEnumerator enumerator4;
						object primaryActivitySet2 = enumerator4.Current;
						global::System.Collections.IEnumerator enumerator5;
						object currentActivitySet2 = enumerator5.Current;
						if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsActivitySetChanged(primaryActivitySet2, currentActivitySet2))
						{
							num = (short)924647521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_98E;
					}
					case 55:
					{
						object value;
						if (value.GetType() == typeof(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType))
						{
							num = (short)1829306403;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)251658319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						goto IL_95E;
					case 57:
						goto IL_F63;
					case 58:
						goto IL_1124;
					case 59:
						num = (short)681181185;
						if (num != 0)
						{
						}
						num = (short)1554841650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						num = (short)192741414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
					{
						global::System.Collections.IEnumerator enumerator4;
						if (enumerator4.MoveNext())
						{
							num = (short)761331812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					}
					case 62:
					{
						object value2;
						if (value2 == null)
						{
							num = (short)1618935896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 63:
						num = (short)49479794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						if (currentActivitySet == null)
						{
							num = (short)1567162439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 65:
					{
						object value;
						if (value != null)
						{
							num = (short)8192022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					}
					case 66:
						num = (short)1496449081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						num = (short)837943411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						num = (short)1671823377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
					{
						global::System.Collections.IEnumerator enumerator3;
						object primaryActivitySet3 = enumerator3.Current;
						global::System.Collections.IEnumerator enumerator7;
						object currentActivitySet3 = enumerator7.Current;
						if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsActivitySetChanged(primaryActivitySet3, currentActivitySet3))
						{
							num = (short)1971322892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7AB;
					}
					case 70:
					{
						object value;
						object value2;
						if (value.ToString() != value2.ToString())
						{
							num = (short)356319276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					}
					case 71:
						goto IL_B66;
					case 72:
						num = (short)1257635942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						goto IL_4CD;
					case 74:
					{
						object value2 = propertyInfo.GetValue(currentActivitySet, null);
						num = (short)984285227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 75:
						goto IL_3E0;
					case 76:
						goto IL_1124;
					case 77:
						num = (short)1350238215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						num = (short)1464336497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
					{
						object value;
						object value2;
						if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsActivitySetChanged(value, value2))
						{
							num = (short)582877203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					}
					case 80:
					{
						object value;
						if (value != null)
						{
							num = (short)652279835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					}
					case 81:
						if (primaryActivitySet != null)
						{
							num = (short)258211880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4F;
					case 82:
					{
						object value2;
						if (value2.GetType() == typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>))
						{
							num = (short)190185488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2040922221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 83:
						if (primaryActivitySet != null)
						{
							num = (short)1497628739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 84:
					{
						object value;
						object value2;
						if (((global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase>)value).Count != ((global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase>)value2).Count)
						{
							num = (short)187170844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.IEnumerator enumerator6 = ((global::System.Collections.IEnumerable)value).GetEnumerator();
						global::System.Collections.IEnumerator enumerator8 = ((global::System.Collections.IEnumerable)value2).GetEnumerator();
						num = (short)877068363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
						goto IL_F63;
					case 86:
						num = (short)154927115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						goto IL_1311;
					case 88:
						goto IL_C52;
					case 89:
					{
						global::System.Collections.IEnumerator enumerator5;
						if (!enumerator5.MoveNext())
						{
							num = (short)2137915413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1138491446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 90:
					{
						global::System.Collections.IEnumerator enumerator;
						object primaryActivitySet4 = enumerator.Current;
						global::System.Collections.IEnumerator enumerator2;
						object currentActivitySet4 = enumerator2.Current;
						if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsActivitySetChanged(primaryActivitySet4, currentActivitySet4))
						{
							num = (short)754909235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9D0;
					}
					case 91:
						a2.b = 0;
						num = (short)794034234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						num = (short)915865603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						num = (short)2034106480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 94:
					{
						num = (short)1668811795;
						short num4 = num;
						num = (short)371002387;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_95E;
						default:
						{
							num = (short)268500992;
							if (num != 0)
							{
							}
							global::System.Collections.IEnumerator enumerator6;
							object primaryActivitySet5 = enumerator6.Current;
							global::System.Collections.IEnumerator enumerator8;
							object currentActivitySet5 = enumerator8.Current;
							if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsActivitySetChanged(primaryActivitySet5, currentActivitySet5))
							{
								num = (short)928972809;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3E0;
						}
						}
						break;
					}
					case 95:
						num = (short)2126446597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
					{
						object value;
						object value2;
						if (((global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>)value).Count != ((global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>)value2).Count)
						{
							num = (short)1135869972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)value).GetEnumerator();
						global::System.Collections.IEnumerator enumerator2 = ((global::System.Collections.IEnumerable)value2).GetEnumerator();
						num = (short)170328170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 97:
						return true;
					case 98:
					{
						if (a2.b >= a2.a.Length)
						{
							num = (short)1103429724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object value = a2.a[a2.b].GetValue(primaryActivitySet, null);
						num = (short)1580924984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 99:
						goto IL_89F;
					case 100:
						num = (short)2036203609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						num = (short)215089260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
					{
						object value;
						if (value.GetType() == typeof(string))
						{
							num = (short)1693253692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1812332574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 103:
					{
						object value;
						if (value.GetType() == typeof(global::System.ComponentModel.PropertyChangedEventHandler))
						{
							num = (short)1552416801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.IEnumerator enumerator3 = ((global::System.Collections.IEnumerable)value).GetEnumerator();
						object value2;
						global::System.Collections.IEnumerator enumerator7 = ((global::System.Collections.IEnumerable)value2).GetEnumerator();
						num = (short)26804242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 104:
					{
						object value2;
						if (value2 == null)
						{
							num = (short)382599267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					}
					case 105:
						num = (short)1098383386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						goto IL_9D0;
					case 107:
						num = (short)789053502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						if (propertyInfo != null)
						{
							num = (short)399048778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F63;
					case 109:
					{
						object value;
						if (!(value.GetType() == typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase>)))
						{
							num = (short)1879310431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1311;
					}
					case 110:
						if (a2.a != null)
						{
							num = (short)532021294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 111:
						goto IL_F63;
					case 112:
					{
						global::System.Collections.IEnumerator enumerator8;
						if (!enumerator8.MoveNext())
						{
							num = (short)1404633147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1985216606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 113:
					{
						object value2;
						if (value2.GetType() == typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HLPanel>))
						{
							num = (short)987430946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1378353177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 114:
					{
						global::System.Collections.IEnumerator enumerator7;
						if (!enumerator7.MoveNext())
						{
							num = (short)2023489602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)183959621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 115:
						if (currentActivitySet != null)
						{
							num = (short)1499594756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 116:
						num = (short)655360041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_222:
					if (primaryActivitySet == null)
					{
						num = (short)2143223821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B66;
					IL_3E0:
					num = (short)2092892212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_730:
					num = (short)170655824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7AB:
					num = (short)474546208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_98E:
					num = (short)719323197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9D0:
					num = (short)928382978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A57:
					num = (short)38862944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AE1:
					num = (short)37683270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B66:
					num = (short)1601372241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C52:
					num = (short)1611202625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CFC:
					num = (short)614400042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D4F:
					num = (short)1233322067;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F63:
					int b2 = a2.b;
					a2.b = b2 + 1;
					num = (short)1152450636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1124:
					num = (short)1950089314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1311:
					num = (short)2094399572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_95E:
					global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> source = properties;
					global::System.Func<global::System.Reflection.PropertyInfo, bool> predicate;
					if ((predicate = a2.c) == null)
					{
						predicate = (a2.c = new global::System.Func<global::System.Reflection.PropertyInfo, bool>(a2.d));
					}
					propertyInfo = source.FirstOrDefault(predicate);
					num = (short)24903717;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_4CD:
				return true;
				IL_89F:
				return true;
				IL_CA8:
				return false;
			}
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0002C424 File Offset: 0x0002A624
		public static void CreateJarFolder(string folderPath)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				global::System.IO.FileStream fileStream;
				switch (num)
				{
				case 0:
					global::System.IO.File.Delete(text);
					num2 = (short)1586561025;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_196;
				case 2:
					try
					{
						global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(fileStream);
						streamWriter.WriteLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("匝䄟䰡䴣䀥䴧天堫̭是圱䘳䔵儷唹刻н怿獁橃癅", a_));
						streamWriter.WriteLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("崝刟䜡䔣別䴧丩ī氭䤯࠱ᐳܵᘷഹሻ฽Ἷ瑁獃晅恇Չ㹋⽍㍏㹑ㅓ癕᭗㕙⹛⹝ཟၡգብŧթɫ䝭", a_));
						streamWriter.Flush();
						return;
					}
					finally
					{
						num2 = (short)1399062530;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_14B;
							case 1:
								((global::System.IDisposable)fileStream).Dispose();
								num2 = (short)685572096;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_115;
								}
								continue;
							}
							IL_115:
							if (fileStream != null)
							{
								num2 = (short)120913921;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_14B:
							num2 = (short)1506591056;
							short num3 = num2;
							num2 = (short)1586020688;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_115;
							default:
								goto IL_180;
							}
						}
						IL_180:
						num2 = (short)362151936;
						if (num2 != 0)
						{
						}
					}
					goto IL_196;
				case 3:
					if (global::System.IO.File.Exists(text))
					{
						num2 = (short)1848246272;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_196;
				}
				goto IL_29;
				IL_196:
				num2 = (short)2111504384;
				short num4 = num2;
				fileStream = global::System.IO.File.Create(text);
				num2 = (short)904658945;
				if (num2 != 0)
				{
				}
				num2 = (short)967311362;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_29:
			text = global::System.IO.Path.Combine(folderPath, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("猝䠟娡䜣䤥䘧䰩", a_));
			text = global::System.IO.Path.Combine(text, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("匝攟瘡攣ଥ愧搩樫", a_));
			global::System.IO.Directory.CreateDirectory(text);
			string path = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("匝感氡洣急洧礩砫-累琱", a_);
			text = global::System.IO.Path.Combine(text, path);
			num2 = (short)363266051;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0002C670 File Offset: 0x0002A870
		public static void CreateScxmlFile(string filePath, global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivitySet CurrentActivitySet)
		{
			int a_ = 12;
			short num = (short)1814757376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_EF;
				}
				global::System.Xml.XmlElement xmlElement;
				global::System.Xml.XmlDocument xmlDocument;
				global::System.Xml.XmlElement xmlElement15;
				global::System.Xml.XmlElement xmlElement16;
				global::System.Xml.XmlNode xmlNode;
				global::System.Xml.XmlElement xmlElement17;
				for (;;)
				{
					IL_30:
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget mapWidget;
					int num3;
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase widgetBase;
					global::System.Xml.XmlElement xmlElement3;
					int num5;
					global::System.Xml.XmlElement xmlElement11;
					global::System.Xml.XmlElement xmlElement14;
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ScxmlParser scxmlParser4;
					switch (num2)
					{
					case 0:
						if (CurrentActivitySet.HomeLayout != null)
						{
							num = (short)500563991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1878;
					case 1:
						if (mapWidget.MapType != global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType.Unconfigured)
						{
							num = (short)1560608788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18BE;
					case 2:
						if (CurrentActivitySet != null)
						{
							num = (short)1009254441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1641;
					case 3:
						goto IL_103E;
					case 4:
						num3 = 0;
						num = (short)632029215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (CurrentActivitySet != null)
						{
							num = (short)390856747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1878;
					case 6:
						goto IL_1641;
					case 7:
						goto IL_2A1;
					case 8:
					{
						string text;
						try
						{
							num = (short)764936194;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1272446979;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4E2;
									}
									continue;
								case 3:
									goto IL_576;
								case 4:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)980811776;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity = enumerator.Current;
									text = text + activity._Event + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᴥ", a_);
									num = (short)536543233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_522:
								num = (short)315097092;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4E2:
								goto IL_522;
							}
							IL_576:
							goto IL_1304;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_589;
						IL_1304:
						xmlElement.InnerText = text;
						num = (short)1971126308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget webKitWidget = widgetBase as global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget;
						global::System.Xml.XmlElement xmlElement2 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetType.WebKitWidget.ToString().ToLower(global::System.Globalization.CultureInfo.CurrentCulture));
						xmlElement2.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("匥娧䘩", a_), webKitWidget.Url);
						xmlElement2.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥堧䬩䈫瘭", a_), webKitWidget.SpanX.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
						xmlElement2.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥堧䬩䈫眭", a_), webKitWidget.SpanY.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
						xmlElement2.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帥", a_), webKitWidget.X.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
						xmlElement2.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弥", a_), webKitWidget.Y.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
						xmlElement2.InnerText = "";
						xmlElement3.AppendChild(xmlElement2);
						num = (short)1522794521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)122093569;
						if (num != 0)
						{
						}
						if (widgetBase is global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget)
						{
							num = (short)1553596433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1478754343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)624033792;
						short num4 = num;
						if (CurrentActivitySet != null)
						{
							num = (short)772407331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_330;
					}
					case 12:
						if (num3 >= CurrentActivitySet.HomeLayout.LstHLPanel[num5].Widgets.Count)
						{
							num = (short)129499180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						widgetBase = CurrentActivitySet.HomeLayout.LstHLPanel[num5].Widgets[num3];
						num = (short)450363402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_17DB;
					case 14:
						goto IL_114C;
					case 15:
						goto IL_18BE;
					case 16:
						goto IL_15DC;
					case 17:
					{
						global::System.Xml.XmlElement xmlElement4 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetType.AppWidget.ToString().ToLower(global::System.Globalization.CultureInfo.CurrentCulture));
						global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget appWidget = widgetBase as global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget;
						global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ScxmlParser scxmlParser = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ScxmlParser();
						string classNameByWidgetItemTypeAndSize = scxmlParser.GetClassNameByWidgetItemTypeAndSize(appWidget.WidgetItemType, appWidget.SpanX, appWidget.SpanY);
						string packageNameByWidgetItemTypeAndSize = scxmlParser.GetPackageNameByWidgetItemTypeAndSize(appWidget.WidgetItemType, appWidget.SpanX, appWidget.SpanY);
						xmlElement4.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("嘥䤧䤩䜫伭圯圱稳圵唷弹", a_), packageNameByWidgetItemTypeAndSize);
						xmlElement4.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䔥䐧䬩弫崭縯匱夳匵", a_), classNameByWidgetItemTypeAndSize);
						xmlElement4.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥堧䬩䈫瘭", a_), appWidget.SpanX.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
						xmlElement4.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥堧䬩䈫眭", a_), appWidget.SpanY.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
						xmlElement4.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帥", a_), appWidget.X.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
						xmlElement4.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弥", a_), appWidget.Y.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
						xmlElement4.InnerText = "";
						xmlElement3.AppendChild(xmlElement4);
						num = (short)552468509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (num5 >= CurrentActivitySet.HomeLayout.LstHLPanel.Count)
						{
							num = (short)55115821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						xmlElement3 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥䬧堩䤫䬭帯", a_));
						xmlElement3.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("严䴧䌩䬫䘭䐯", a_), global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ဥ", a_));
						xmlElement3.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("嘥䤧䴩䤫䀭䔯弱", a_), num5.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
						xmlElement3.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帥䔧䘩䈫崭", a_), "");
						num = (short)1164378139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						try
						{
							num = (short)1696137217;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget mapWidget2;
								global::System.Xml.XmlElement xmlElement7;
								int num6;
								global::System.Xml.XmlElement xmlElement9;
								global::System.Xml.XmlElement xmlElement13;
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase widgetBase2;
									if (widgetBase2 is global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget)
									{
										num = (short)694288394;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)778960903;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_64D;
									}
									continue;
								case 2:
									num = (short)350093323;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									try
									{
										num = (short)1177550850;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 1:
											{
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition>.Enumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)2128740356;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition transition = enumerator2.Current;
												global::System.Xml.XmlElement xmlElement5 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("別娧䬩䈫崭夯䘱崳夵嘷", a_));
												xmlElement5.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䌥帧伩䈫娭", a_), transition._Event);
												xmlElement5.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("別䤧堩䬫䬭䐯", a_), transition.Target);
												xmlElement5.InnerText = "";
												global::System.Xml.XmlElement xmlElement6;
												xmlElement6.AppendChild(xmlElement5);
												num = (short)1591148544;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_B5A;
												}
												continue;
											case 3:
												goto IL_C37;
											case 4:
												num = (short)1194459139;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_B5C:
											num = (short)1025245185;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_B5A:
											goto IL_B5C;
										}
										IL_C37:
										break;
									}
									finally
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									goto IL_C4A;
								case 4:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase widgetBase2;
									mapWidget2 = (widgetBase2 as global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget);
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ScxmlParser scxmlParser2 = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ScxmlParser();
									xmlElement7 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetType.MapWidget.ToString().ToLower(global::System.Globalization.CultureInfo.CurrentCulture));
									num = (short)1731854354;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_D04;
								case 6:
									num6 = 0;
									num = (short)668401673;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase widgetBase2;
									if (widgetBase2 is global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget)
									{
										num = (short)801570831;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1757675540;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_AB6;
								case 9:
									goto IL_C4A;
								case 10:
								{
									global::System.Xml.XmlElement xmlElement8 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetType.AppWidget.ToString().ToLower(global::System.Globalization.CultureInfo.CurrentCulture));
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase widgetBase2;
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget appWidget2 = widgetBase2 as global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget;
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ScxmlParser scxmlParser3 = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ScxmlParser();
									string classNameByWidgetItemTypeAndSize2 = scxmlParser3.GetClassNameByWidgetItemTypeAndSize(appWidget2.WidgetItemType, appWidget2.SpanX, appWidget2.SpanY);
									string packageNameByWidgetItemTypeAndSize2 = scxmlParser3.GetPackageNameByWidgetItemTypeAndSize(appWidget2.WidgetItemType, appWidget2.SpanX, appWidget2.SpanY);
									xmlElement8.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("嘥䤧䤩䜫伭圯圱稳圵唷弹", a_), packageNameByWidgetItemTypeAndSize2);
									xmlElement8.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䔥䐧䬩弫崭縯匱夳匵", a_), classNameByWidgetItemTypeAndSize2);
									xmlElement8.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥堧䬩䈫瘭", a_), appWidget2.SpanX.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
									xmlElement8.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥堧䬩䈫眭", a_), appWidget2.SpanY.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
									xmlElement8.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帥", a_), appWidget2.X.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
									xmlElement8.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弥", a_), appWidget2.Y.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
									xmlElement8.InnerText = "";
									xmlElement9.AppendChild(xmlElement8);
									num = (short)1039597591;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									goto IL_102B;
								case 12:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity2;
									xmlElement9.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("嘥娧䌩䌫尭夯䘱䴳", a_), activity2.screen_priority);
									num = (short)278593541;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity2;
									if (!string.IsNullOrEmpty(activity2.screen_priority))
									{
										num = (short)500695052;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D04;
								}
								case 14:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity2;
									if (activity2.Widgets != null)
									{
										num = (short)1207435270;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9A5;
								}
								case 15:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase widgetBase2;
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget webKitWidget2 = widgetBase2 as global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget;
									global::System.Xml.XmlElement xmlElement10 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetType.WebKitWidget.ToString().ToLower(global::System.Globalization.CultureInfo.CurrentCulture));
									xmlElement10.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("匥娧䘩", a_), webKitWidget2.Url);
									xmlElement10.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥堧䬩䈫瘭", a_), webKitWidget2.SpanX.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
									xmlElement10.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥堧䬩䈫眭", a_), webKitWidget2.SpanY.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
									xmlElement10.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帥", a_), webKitWidget2.X.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
									xmlElement10.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弥", a_), webKitWidget2.Y.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
									xmlElement10.InnerText = "";
									xmlElement9.AppendChild(xmlElement10);
									num = (short)67436552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity2;
									if (activity2.Transitions != null)
									{
										num = (short)2125004825;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 17:
									goto IL_AB6;
								case 18:
									if (mapWidget2.MapType != global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType.Unconfigured)
									{
										num = (short)81788947;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_EC1;
								case 19:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ScxmlParser scxmlParser2;
									xmlElement7.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("別儧娩䤫", a_), scxmlParser2.GetMapTypeByMapItemType(mapWidget2.MapType));
									num = (short)550699030;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase widgetBase2;
									if (widgetBase2 is global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget)
									{
										num = (short)554696708;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_AB6;
								}
								case 21:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)675938306;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity2 = enumerator.Current;
									global::System.Xml.XmlElement xmlElement6 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥尧䬩堫䬭", a_));
									xmlElement6.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("伥䰧", a_), global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityBuilderLibCommonService.GetEventTriggerDataString(activity2.state_id));
									xmlElement11.AppendChild(xmlElement6);
									global::System.Xml.XmlElement xmlElement12 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䈥䤧帩䴫䌭弯嘱儳娵", a_));
									xmlElement6.AppendChild(xmlElement12);
									xmlElement13 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䈥䤧帩䴫", a_));
									xmlElement13.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帥䔧䘩䈫崭", a_), global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("严尧帩尫ᐭἯᴱ䌳䄵伷ᐹ䬻ഽ渿ⵁ㙃ⅅ杇硉籋繍敏絑摓慕睗⥙㽛♝ൟ๡", a_));
									xmlElement13.InnerText = "";
									xmlElement12.AppendChild(xmlElement13);
									xmlElement9 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥䬧堩䤫䬭帯", a_));
									xmlElement9.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䀥䜧䤩夫崭唯嘱", a_), activity2.screen_focused);
									xmlElement9.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥䀧䔩嬫", a_), activity2.screen_show);
									xmlElement9.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䨥䜧䤩䜫䬭启", a_), activity2.screen_locked);
									num = (short)1867579405;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									goto IL_EC1;
								case 23:
									goto IL_AB6;
								case 24:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity2;
									if (num6 >= activity2.Widgets.Count)
									{
										num = (short)672530458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase widgetBase2 = activity2.Widgets[num6];
									num = (short)704184320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 25:
								{
									num = (short)792786773;
									short num7 = num;
									num = (short)1139078997;
									switch ((num7 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_102B;
									default:
									{
										num = (short)852623360;
										if (num != 0)
										{
										}
										global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity2;
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition>.Enumerator enumerator2 = activity2.Transitions.GetEnumerator();
										num = (short)498991107;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 26:
									goto IL_9A5;
								case 27:
									goto IL_C4A;
								}
								goto IL_64D;
								IL_9A5:
								xmlElement13.AppendChild(xmlElement9);
								num = (short)1244856336;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AB6:
								num6++;
								num = (short)1028325403;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C4A:
								num = (short)488964120;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CC0:
								num = (short)1634598933;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_64D:
								goto IL_CC0;
								IL_D04:
								xmlElement9.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帥䔧䘩䈫崭", a_), "");
								num = (short)1285488654;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EC1:
								xmlElement7.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥堧䬩䈫瘭", a_), mapWidget2.SpanX.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
								xmlElement7.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥堧䬩䈫眭", a_), mapWidget2.SpanY.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
								xmlElement7.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帥", a_), mapWidget2.X.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
								xmlElement7.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弥", a_), mapWidget2.Y.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
								xmlElement7.InnerText = "";
								xmlElement9.AppendChild(xmlElement7);
								num = (short)614072337;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_102B:
							goto IL_1129;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_103E;
					case 20:
						xmlElement14.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("別儧娩䤫", a_), scxmlParser4.GetMapTypeByMapItemType(mapWidget.MapType));
						num = (short)740294671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (widgetBase is global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget)
						{
							num = (short)1292894211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15DC;
					case 22:
						if (CurrentActivitySet.Activities.LstActivity != null)
						{
							num = (short)1733427238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1129;
					case 23:
						num5 = 0;
						num = (short)1116864549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (CurrentActivitySet.Activities != null)
						{
							num = (short)2034303008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_330;
					case 25:
						goto IL_15DC;
					case 26:
					{
						string text = "";
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>.Enumerator enumerator = CurrentActivitySet.Activities.LstActivity.GetEnumerator();
						num = (short)1601699848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						if (CurrentActivitySet.HomeLayout.LstHLPanel[num5].Widgets != null)
						{
							num = (short)1079508996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_589;
					case 28:
						if (CurrentActivitySet != null)
						{
							num = (short)1083506722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1129;
					case 29:
						goto IL_15DC;
					case 30:
						if (CurrentActivitySet.Activities != null)
						{
							num = (short)182779946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1129;
					case 31:
						goto IL_17DB;
					case 32:
						num = (short)512491560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (CurrentActivitySet.Activities != null)
						{
							num = (short)1248788486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_199A;
					case 34:
						num = (short)1063780382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)362020888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_330;
					case 37:
						goto IL_2A1;
					case 38:
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.b(CurrentActivitySet);
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>.Enumerator enumerator = CurrentActivitySet.Activities.LstActivity.GetEnumerator();
						num = (short)1776287763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						if (widgetBase is global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget)
						{
							num = (short)456327177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2075721749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (CurrentActivitySet.Activities.LstActivity != null)
						{
							num = (short)346947610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_330;
					case 41:
						num = (short)1742929953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						num = (short)1616314390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						num = (short)1974009856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						goto IL_589;
					case 45:
						goto IL_1878;
					}
					goto IL_EF;
					IL_2A1:
					num = (short)1645084690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_330:
					xmlElement15.AppendChild(xmlElement);
					xmlElement16.AppendChild(xmlElement15);
					xmlNode.AppendChild(xmlElement16);
					xmlElement17 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("嘥䤧堩䴫䈭尯圱堳", a_));
					xmlElement17.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("伥䰧", a_), global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("嘥", a_));
					global::System.Xml.XmlElement xmlElement18 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥尧䬩堫䬭", a_));
					xmlElement18.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("伥䰧", a_), global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䐥䤧天䤫", a_));
					xmlElement17.AppendChild(xmlElement18);
					global::System.Xml.XmlElement xmlElement19 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䈥䤧帩䴫䌭弯嘱儳娵", a_));
					xmlElement18.AppendChild(xmlElement19);
					global::System.Xml.XmlElement xmlElement20 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䈥䤧帩䴫", a_));
					xmlElement20.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帥䔧䘩䈫崭", a_), global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("严尧帩尫ᐭἯᴱ䌳䄵伷ᐹ䬻ഽ渿ⵁ㙃ⅅ杇硉籋繍敏絑摓慕睗⥙㽛♝ൟ๡", a_));
					xmlElement20.InnerText = "";
					num = (short)1681981445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_589:
					xmlElement20.AppendChild(xmlElement3);
					num5++;
					num = (short)1277165575;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_103E:
					mapWidget = (widgetBase as global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget);
					scxmlParser4 = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ScxmlParser();
					xmlElement14 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetType.MapWidget.ToString().ToLower(global::System.Globalization.CultureInfo.CurrentCulture));
					num = (short)884998145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1129:
					xmlElement17.AppendChild(xmlElement11);
					num = (short)1789001742;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15DC:
					num3++;
					num = (short)1984167949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1641:
					xmlElement11 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥尧䬩堫䬭", a_));
					xmlElement11.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("伥䰧", a_), CurrentActivitySet.Activities.Name);
					xmlElement11.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("伥䘧䌩堫䜭儯帱", a_), global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityBuilderLibCommonService.GetEventTriggerDataString(CurrentActivitySet.Activities.Initial));
					num = (short)1796866076;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17DB:
					num = (short)591003660;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1878:
					xmlElement19.AppendChild(xmlElement20);
					num = (short)396099586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18BE:
					xmlElement14.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥堧䬩䈫瘭", a_), mapWidget.SpanX.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
					xmlElement14.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥堧䬩䈫眭", a_), mapWidget.SpanY.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
					xmlElement14.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帥", a_), mapWidget.X.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
					xmlElement14.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弥", a_), mapWidget.Y.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
					xmlElement14.InnerText = "";
					xmlElement3.AppendChild(xmlElement14);
					num = (short)671547408;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_114C:
				IL_199A:
				global::System.Xml.XmlElement xmlElement21;
				xmlElement21.AppendChild(xmlNode);
				xmlElement21.AppendChild(xmlElement17);
				xmlDocument.Save(filePath);
				return;
				IL_EF:
				xmlDocument = new global::System.Xml.XmlDocument();
				xmlElement21 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("唥䬧利䄫䈭", a_));
				xmlElement21.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("伥䘧䌩堫䜭儯帱", a_), global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("嘥", a_));
				xmlElement21.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("倥䴧堩弫䜭弯就", a_), global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᘥاጩ", a_));
				xmlElement21.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帥䔧䘩䈫崭", a_), global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("严尧帩尫ᐭἯᴱ䌳䄵伷ᐹ䬻ഽ渿ⵁ㙃ⅅ杇硉籋繍敏絑摓慕睗⥙㽛♝ൟ๡", a_));
				xmlDocument.AppendChild(xmlElement21);
				xmlNode = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䈥䤧帩䴫䌭弯嘱儳娵", a_));
				xmlElement16 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䈥䤧帩䴫", a_));
				xmlElement16.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䠥䤧䜩䤫", a_), global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䌥帧伩䈫娭䌯戱儳䐵唷匹䠻", a_));
				xmlElement16.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帥䔧䘩䈫崭", a_), global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("严尧帩尫ᐭἯᴱ䌳䄵伷ᐹ䬻ഽ渿ⵁ㙃ⅅ杇硉籋繍敏絑摓慕睗⥙㽛♝ൟ๡", a_));
				xmlElement15 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䌥帧伩䈫娭䌯", a_));
				xmlElement15.SetAttribute(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帥䔧䘩䈫崭", a_), "");
				xmlElement = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䌥帧伩䈫娭䌯圱䀳", a_));
				xmlElement.InnerText = "";
				global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.a(CurrentActivitySet);
				num = (short)251461643;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0002E07C File Offset: 0x0002C27C
		private static void b(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivitySet A_0)
		{
			short num = (short)1428881408;
			switch (num)
			{
			default:
			{
				num = (short)1086324737;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
						goto IL_3B6;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 2:
						try
						{
							num = (short)370868226;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3A3;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_C8;
									}
									continue;
								case 3:
									goto IL_38B;
								case 4:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity;
									if (activity.Transitions.Count == 0)
									{
										num = (short)463732742;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									try
									{
										num = (short)788070401;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity;
											global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity2;
											switch (num2)
											{
											case 0:
											{
												num = (short)671414534;
												short num3 = num;
												num = (short)300939526;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_230;
												default:
													goto IL_363;
												}
												break;
											}
											case 1:
												switch (0)
												{
												case 0:
													goto IL_22B;
												}
												continue;
											case 2:
												if (activity.state_id != activity2.state_id)
												{
													num = (short)738656259;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 3:
												goto IL_230;
											case 4:
											{
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>.Enumerator enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1331298309;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												activity2 = enumerator.Current;
												num = (short)357498882;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
												num = (short)1902837760;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_22B;
											IL_230:
											string activityEventByActivityType = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant.GetActivityEventByActivityType(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityBuilderLibCommonService.GetEventTriggerDataString(activity2.state_id));
											global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition transition = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition();
											transition._Event = activityEventByActivityType;
											transition.Target = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityBuilderLibCommonService.GetEventTriggerDataString(activity2.state_id);
											activity.Transitions.Add(transition);
											num = (short)980549638;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_2DB:
											num = (short)23724036;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_22B:
											goto IL_2DB;
										}
										IL_363:
										num = (short)624164864;
										if (num != 0)
										{
										}
										goto IL_1A4;
									}
									finally
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>.Enumerator enumerator;
										((global::System.IDisposable)enumerator).Dispose();
									}
									goto IL_38B;
									IL_1A4:
									num = (short)626393092;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition transition2 = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition();
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity;
									transition2.Target = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityBuilderLibCommonService.GetEventTriggerDataString(activity.state_id);
									transition2._Event = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant.GetActivityEventByActivityType(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityBuilderLibCommonService.GetEventTriggerDataString(activity.state_id));
									activity.Transitions.Add(transition2);
									num = (short)335413249;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)449249283;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity = enumerator2.Current;
									activity.Transitions = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition>();
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>.Enumerator enumerator = A_0.Activities.LstActivity.GetEnumerator();
									num = (short)439549957;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_121:
								num = (short)930676743;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C8:
								goto IL_121;
								IL_38B:
								num = (short)1377370112;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3A3:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_3B6;
					case 3:
					{
						num = (short)1951531008;
						short num4 = num;
						if (A_0.Activities != null)
						{
							num = (short)1167720452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						num = (short)1092157441;
						if (num != 0)
						{
						}
						num = (short)1102708741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (A_0.Activities.LstActivity != null)
						{
							num = (short)201457664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						num = (short)1605107715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_61:
					if (A_0 != null)
					{
						num = (short)1625227270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_3B6:
					enumerator2 = A_0.Activities.LstActivity.GetEnumerator();
					num = (short)1186791426;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0002E578 File Offset: 0x0002C778
		private static void a(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivitySet A_0)
		{
			short num = (short)118030337;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					goto IL_1D3;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 2:
					try
					{
						num = (short)829882369;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)1335135047;
								short num3 = num;
								num = (short)248941383;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_1AB;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_A1;
								}
								continue;
							case 2:
								num = (short)2046427136;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity;
								if (string.IsNullOrEmpty(activity._Event))
								{
									num = (short)297926661;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity;
								string activityEventByActivityType = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant.GetActivityEventByActivityType(activity.state_id);
								activity._Event = activityEventByActivityType;
								activity.Target = activity.state_id;
								num = (short)13959171;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1754464258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity = enumerator.Current;
								num = (short)136773636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_A3:
							num = (short)1623851014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A1:
							goto IL_A3;
						}
						IL_1AB:
						num = (short)1647837184;
						if (num != 0)
						{
						}
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1D3;
				case 3:
					if (A_0.Activities != null)
					{
						num = (short)275054593;
						if (num != 0)
						{
						}
						num = (short)1726742532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					num = (short)1676738565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (A_0.Activities.LstActivity != null)
					{
						num = (short)1788608512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					num = (short)951779331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_40:
				if (A_0 != null)
				{
					num = (short)752812038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1D3:
				num = (short)392822784;
				short num4 = num;
				enumerator = A_0.Activities.LstActivity.GetEnumerator();
				num = (short)1154940930;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x02000047 RID: 71
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000251 RID: 593 RVA: 0x0002E888 File Offset: 0x0002CA88
			internal bool d(global::System.Reflection.PropertyInfo A_0)
			{
				short num = (short)915865600;
				short num2 = num;
				num = (short)2048981231;
				short num3 = num;
				num = (short)556792047;
				switch (num3 == num)
				{
				}
				num = (short)430964737;
				if (num != 0)
				{
				}
				num = (short)1798569984;
				if (num != 0)
				{
				}
				return A_0.Name == this.a[this.b].Name;
			}

			// Token: 0x0400006C RID: 108
			public global::System.Reflection.PropertyInfo[] a;

			// Token: 0x0400006D RID: 109
			public int b;

			// Token: 0x0400006E RID: 110
			public global::System.Func<global::System.Reflection.PropertyInfo, bool> c;
		}
	}
}
