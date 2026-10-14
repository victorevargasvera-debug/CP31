using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using RFResourceRepository;
using SharedUtility;
using SharedUtility.Arguments;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000053 RID: 83
	public class ASTROValidationService : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x0600069D RID: 1693 RVA: 0x0003EFD0 File Offset: 0x0003D1D0
		public ASTROValidationService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor) : base(serverAccessor)
		{
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0003EFE4 File Offset: 0x0003D1E4
		public bool ValidateAllRadioFields(global::Motorola.CommonCPS.Server.EntityModel.Radio RadioFromServer, global::System.Collections.Generic.Dictionary<string, string> errorList)
		{
			short num = (short)184177769;
			short num2 = num;
			num = (short)517166185;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1221918720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1505886209;
			if (num != 0)
			{
			}
			num = (short)1636761600;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0003F090 File Offset: 0x0003D290
		public bool IsPasswordValid(string pw)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num3;
			bool result;
			for (;;)
			{
				IL_0A:
				int num2;
				switch (num)
				{
				case 0:
				{
					char[] array = pw.ToCharArray();
					num2 = 0;
					num3 = (short)1358888967;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 1:
				{
					num3 = (short)1680434614;
					short num4 = num3;
					num3 = (short)1014064566;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_29D;
					case 1:
						break;
					default:
					{
						num3 = (short)639959040;
						short num5 = num3;
						break;
					}
					}
					num3 = (short)1479540736;
					if (num3 != 0)
					{
					}
					num3 = (short)1113718794;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 2:
					goto IL_224;
				case 3:
					num3 = (short)1877671945;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 4:
					goto IL_181;
				case 5:
				{
					char[] array;
					if (num2 >= array.Length)
					{
						num3 = (short)665976847;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1976500230;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 6:
				{
					char[] array;
					if (array[num2] >= '\u0080')
					{
						num3 = (short)2112815115;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_181;
				}
				case 7:
					goto IL_224;
				case 8:
					if (!string.IsNullOrEmpty(pw))
					{
						num3 = (short)858390529;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_25E;
				case 9:
					if (pw.Length < 6)
					{
						num3 = (short)1205075980;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_25E;
				case 10:
					if (pw.Length <= 16)
					{
						num3 = (short)682426371;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_29B;
				case 11:
					result = false;
					num3 = (short)373293060;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 12:
					goto IL_29B;
				case 13:
					return result;
				case 14:
					if (!string.IsNullOrEmpty(pw))
					{
						num3 = (short)1162084352;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return result;
				case 15:
					return result;
				}
				goto IL_50;
				IL_181:
				num2++;
				num3 = (short)523304962;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_224:
				num3 = (short)885784581;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_25E:
				num3 = (short)744488974;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_29D:
				num3 = (short)1025638401;
				if (num3 != 0)
				{
				}
				num3 = (short)32309261;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_29B:
				result = false;
				goto IL_29D;
			}
			return result;
			IL_50:
			result = true;
			num3 = (short)1251147784;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0003F37C File Offset: 0x0003D57C
		public bool ValidatePassWord(string Password, out string err)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
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
					if (!this.IsPasswordValid(Password))
					{
						goto IL_44;
					}
					goto IL_A6;
				case 1:
					num2 = (short)1588658177;
					if (num2 != 0)
					{
					}
					err = global::Motorola.CommonCPS.ResourceRepository.Resources.Error_InvalidPassword;
					result = false;
					num2 = (short)1990262786;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_A6;
				}
				goto IL_1C;
				IL_44:
				num2 = (short)1100480513;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_A6:
				num2 = (short)991103334;
				short num3 = num2;
				num2 = (short)1828325734;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_44;
				default:
					goto IL_DD;
				}
			}
			IL_DD:
			num2 = (short)2003959808;
			short num4 = num2;
			num2 = (short)484245504;
			if (num2 != 0)
			{
			}
			return result;
			IL_1C:
			err = string.Empty;
			result = true;
			num2 = (short)540016640;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0003F4A8 File Offset: 0x0003D6A8
		public bool ValidateRadioIdRange(int? systemRadioId, global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType systemType, global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType systemSubType, bool expandedMDCIDRange, string codeplugVerion, out string error)
		{
			int a_ = 3;
			short num = (short)340066304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				global::Motorola.Common.CustomException.CommonErrorCode a_2;
				bool flag;
				global::System.Collections.Generic.List<int> trunkingGroupIDsOfDataProfile;
				global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily inProduct;
				for (;;)
				{
					IL_30:
					global::SharedUtility.Arguments.ArgOfConIndividualIDRangeCheck argOfConIndividualIDRangeCheck;
					switch (num2)
					{
					case 0:
					{
						global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII argOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII;
						this.a(argOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.Min, argOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.Max, a_2, out error);
						num = (short)795672583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (!flag)
						{
							num = (short)1878654976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 2:
						if (!flag)
						{
							num = (short)873005059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 3:
					{
						global::SharedUtility.Arguments.ArgOfConAddtionalMDCIDChecked argOfConAddtionalMDCIDChecked;
						this.a(argOfConAddtionalMDCIDChecked.Min, argOfConAddtionalMDCIDChecked.Max, a_2, out error);
						num = (short)1290141710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (systemType == global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNCKING)
						{
							num = (short)332201990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2ED;
					case 5:
						num = (short)1582432272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)2126446605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_2E8;
					case 8:
					{
						num = (short)896925696;
						short num3 = num;
						if (systemSubType == global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.DVRS)
						{
							num = (short)1832321036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F6;
					}
					case 9:
						if (!flag)
						{
							num = (short)1684930578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 10:
						goto IL_3E0;
					case 11:
						if (!flag)
						{
							num = (short)1854865427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 12:
						argOfConIndividualIDRangeCheck.IsSystemTypeDVRS = true;
						num = (short)390922260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)1281686421;
						short num4 = num;
						num = (short)53607317;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1686175744;
							if (num != 0)
							{
							}
							if (systemSubType == global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.TYPEII)
							{
								num = (short)1736376342;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO25 argOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO = new global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO25();
							argOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO.UnitID_A12651 = systemRadioId.ToString();
							argOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO.TrunkingGroupIDsOfDataProfile = trunkingGroupIDsOfDataProfile;
							flag = global::SharedUtility.SharedConstrainsAdapter.CallConstraint(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud999첡춣튥솭쒯얳쎵\ud9b7횹ﶻ钿郁诃ﷇ跉뻋ꇍꗏꋑ鷓鋕駗듙룛賝臟賡菣菥ꯧ苩觫跭鯯냱闳藵鷷黹돻都叿笁眃爅洇有堋眍怏眑䬓圕䬗丙丛儝ሟᜡ", a_), inProduct, codeplugVerion, argOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO, out a_2);
							break;
						}
						}
						num = (short)1612120075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_1BE;
					case 15:
						if (systemType == global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL)
						{
							num = (short)496173061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1529348100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (systemSubType == global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.MDC)
						{
							num = (short)1447886869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						argOfConIndividualIDRangeCheck = new global::SharedUtility.Arguments.ArgOfConIndividualIDRangeCheck();
						argOfConIndividualIDRangeCheck.IndividualID_A8287 = systemRadioId.ToString();
						argOfConIndividualIDRangeCheck.IsSystemTypeDVRS = false;
						num = (short)1515847688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_322;
					case 18:
						this.a(argOfConIndividualIDRangeCheck.Min, argOfConIndividualIDRangeCheck.Max, a_2, out error);
						num = (short)735707153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO25 argOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO;
						this.a(argOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO.Min, argOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO.Max, a_2, out error);
						num = (short)906035210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_4F6;
					case 21:
					{
						global::SharedUtility.Arguments.ArgOfConAddtionalMDCIDChecked argOfConAddtionalMDCIDChecked = new global::SharedUtility.Arguments.ArgOfConAddtionalMDCIDChecked();
						argOfConAddtionalMDCIDChecked.ExpandedMDCIDRange_A41761 = expandedMDCIDRange;
						argOfConAddtionalMDCIDChecked.MDCPrimaryIDhex_A8744 = systemRadioId.ToString();
						flag = global::SharedUtility.SharedConstrainsAdapter.CallConstraint(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud999욡삣튥솧얩슫쾭\udcafﾱﺹﾻ횽ꖿꇁ꿃ꏅ곇", a_), inProduct, codeplugVerion, argOfConAddtionalMDCIDChecked, out a_2);
						num = (short)600899586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII argOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII = new global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII();
						argOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.UnitID_A12651 = systemRadioId.ToString();
						flag = global::SharedUtility.SharedConstrainsAdapter.CallConstraint(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud999첡춣튥솭쒯얳쎵\ud9b7횹ﶻ钿郁诃ﷇ跉뻋ꇍꗏꋑ鷓鋕駗듙룛賝臟賡菣菥ꯧ苩觫跭鯯냱闳藵鷷黹돻都叿笁眃爅洇有堋眍怏眑䬓䈕愗標礛圝椟", a_), inProduct, codeplugVerion, argOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII, out a_2);
						num = (short)1928527873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_93;
					IL_4F6:
					flag = global::SharedUtility.SharedConstrainsAdapter.CallConstraint(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud999첡삣쾥\udea7쎩좫\udbad톯\udeb1ﶳ\udbb9튻\ud9bdꖿ臁곃ꏅꯇꇉ", a_), inProduct, codeplugVerion, argOfConIndividualIDRangeCheck, out a_2);
					num = (short)584318985;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1BE:
				IL_2E8:
				return flag;
				IL_2ED:
				throw new global::System.ArgumentException();
				IL_322:
				return flag;
				IL_3E0:
				num = (short)1599406081;
				if (num != 0)
				{
				}
				return flag;
				IL_93:
				a_2 = global::Motorola.Common.CustomException.CommonErrorCode.None;
				error = string.Empty;
				inProduct = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX;
				trunkingGroupIDsOfDataProfile = null;
				num = (short)852951055;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0003FA04 File Offset: 0x0003DC04
		public bool ValidateDateProfileValue(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxDataProfile, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug cp, out string error)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_6E;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.Server.EntityModel.APXRadio radioFromServer;
			bool result;
			for (;;)
			{
				IL_13:
				num = (short)1567817728;
				short num2 = num;
				switch (num3)
				{
				case 0:
					num = (short)633470981;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)2047279108;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1450311686;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)297730049;
					if (num != 0)
					{
					}
					if (!this.ValidatePeerIP(apxDataProfile, radioFromServer, out error))
					{
						goto IL_1ED;
					}
					num = (short)619235629;
					short num4 = num;
					num = (short)215271725;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1164115968;
						if (num != 0)
						{
						}
						num = (short)845479938;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (!this.ValidateAirInterfaceIP(apxDataProfile, radioFromServer, out error))
					{
						num = (short)643104775;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 5:
					if (this.ValidateBluetoothDUNSubscriberIP(apxDataProfile, radioFromServer, out error))
					{
						num = (short)1937768449;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1ED;
				case 6:
					if (this.ValidateSubscriberIP(apxDataProfile, radioFromServer, out error))
					{
						num = (short)498466824;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1ED;
				case 7:
					goto IL_1ED;
				case 8:
					num = (short)4784137;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (this.ValidateBluetoothDUNPeerIP(apxDataProfile, radioFromServer, out error))
					{
						num = (short)303235072;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1ED;
				case 10:
					return result;
				}
				goto IL_6E;
				IL_1ED:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튚출삞첢톤\udba8쒪\uddac쪮쎰\udab4얶풸\udaba즼", a_));
				result = false;
				num = (short)808714250;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_6E:
			error = string.Empty;
			result = true;
			radioFromServer = new global::Motorola.CommonCPS.Server.EntityModel.APXRadio
			{
				WorkingCodeplug = cp
			};
			num = (short)1215234051;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0003FC74 File Offset: 0x0003DE74
		public bool ValidatePeerIP(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxDataProfile, global::Motorola.CommonCPS.Server.EntityModel.APXRadio radioFromServer, out string error)
		{
			int a_ = 6;
			short num = (short)768737280;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_170;
				}
				string peerIP;
				bool result;
				int? num3;
				bool? inheritFlag;
				for (;;)
				{
					IL_31:
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2;
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
					string astroBluetoothDunSubscriberIp;
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType3;
					string astroBluetoothDunPeerIp;
					string[] array2;
					global::System.Text.RegularExpressions.Regex regex;
					bool? natEnable;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType4;
					global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode3;
					string airInterfaceAddress;
					bool? bluetoothEnable;
					global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode4;
					string subscriberIP;
					switch (num2)
					{
					case 0:
						goto IL_9E1;
					case 1:
						goto IL_9E1;
					case 2:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)2068709381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E1;
					}
					case 3:
					{
						string[] array;
						if (array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("궜꾞醠", a_)))
						{
							num = (short)2042429479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1973616712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_9E1;
					case 5:
					{
						num = (short)926416897;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType = astroSystemType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3 = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
						num = (short)563085383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2;
						bluetoothDunPeerIpAssignmentType = bluetoothDunPeerIpAssignmentType2;
						goto IL_D92;
					}
					case 7:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1288437828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array = peerIP.Split(new char[]
						{
							'.'
						});
						num = (short)1681850438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						if (peerIP.Trim().Equals(astroBluetoothDunSubscriberIp))
						{
							num = (short)1456930867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2 = bluetoothDunPeerIpAssignmentType3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType4 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
						num = (short)1104150582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (peerIP.Trim().Equals(astroBluetoothDunPeerIp))
						{
							num = (short)1621491747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56E;
					case 10:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
						if (peerIP.Trim().Equals(apxcodeplug.SubscriberIP))
						{
							num = (short)972423189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)575078449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)1369899035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)2121400385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2 = null;
						num = (short)739573766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfilePeerIP_NoSame_AirInterfaceIP;
						num = (short)1733230596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_9E1;
					case 16:
						num = (short)1492713491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						result = false;
						num = (short)633274399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_9E1;
					case 19:
						if (!array2[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("궜꾞", a_)))
						{
							num = (short)555810827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E34;
					case 20:
						if (regex.IsMatch(peerIP, 0))
						{
							num = (short)846594060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_687;
					case 21:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubIP_NoSame_ProfilePeerIP;
						num = (short)1140457514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode;
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode packetDataMode2;
						if (packetDataMode.GetValueOrDefault() == packetDataMode2 & packetDataMode != null)
						{
							num = (short)1138098251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_624;
					}
					case 23:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode = null;
						num = (short)300941371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						bool? flag = natEnable;
						bool flag2 = true;
						num = (short)1146093594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IPValidateHelper(peerIP, out error);
						num = (short)1874395137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)212074541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_624;
					}
					case 27:
						if (array2[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("궜꾞醠", a_)))
						{
							num = (short)1388314684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)77660194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_9E1;
					case 29:
						astroSystemType4 = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType)num3.GetValueOrDefault());
						goto IL_6AC;
					case 30:
						num = (short)444858371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_682;
					case 32:
						goto IL_92C;
					case 33:
						if (num3 == null)
						{
							num = (short)171573309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)539426845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)361955390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E1;
					case 35:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNPeerIP_NoSame_ProfilePeerIP;
						num = (short)639762432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
					{
						string[] array;
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("궜꾞", a_)))
						{
							num = (short)740032542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9BE;
					}
					case 37:
						goto IL_9E1;
					case 38:
						bluetoothDunPeerIpAssignmentType = new global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType?((global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType)num3.GetValueOrDefault());
						goto IL_D92;
					case 39:
						goto IL_9BE;
					case 40:
						if (radioFromServer.RadioStatus != 0)
						{
							num = (short)732495904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E1;
					case 41:
						goto IL_9E1;
					case 42:
					{
						num = (short)1707081728;
						short num4 = num;
						goto IL_9E1;
					}
					case 43:
						goto IL_624;
					case 44:
						if (radioFromServer.WorkingCodeplug != null)
						{
							num = (short)1370030130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)208076840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode = packetDataMode3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode packetDataMode2 = global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode.FNE;
						num = (short)375193622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
						num = (short)1451819044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						num = (short)713162805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						num = (short)705232905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
					{
						if (peerIP.Trim().Equals(airInterfaceAddress.Trim()))
						{
							num = (short)1014890510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool? flag = bluetoothEnable;
						bool flag2 = true;
						num = (short)1772683271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = radioFromServer.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
						bool? flag = inheritFlag;
						bool flag2 = false;
						num = (short)2018836482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 51:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNSubIP_NoSame_ProfilePeerIP;
						num = (short)2018050063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						IL_753:
						if (num3 == null)
						{
							num = (short)1382350861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)516096038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						if (peerIP.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("꾜ꪞ钠趢鞤銦鲨薪龬骮蒰鶲螴芶貸", a_)))
						{
							num = (short)160628802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)519700557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType4;
						if (bluetoothDunPeerIpAssignmentType2.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType4 & bluetoothDunPeerIpAssignmentType2 != null)
						{
							num = (short)1779302448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56E;
					}
					case 55:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3;
						if (!(astroSystemType.GetValueOrDefault() == astroSystemType3 & astroSystemType != null))
						{
							num = (short)241303595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E1;
					}
					case 56:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
						astroSystemType4 = astroSystemType;
						goto IL_6AC;
					}
					case 57:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
						num = (short)1375141906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						if (!string.IsNullOrEmpty(error))
						{
							num = (short)1660944401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 59:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode;
						packetDataMode4 = packetDataMode;
						goto IL_6FE;
					}
					case 60:
						goto IL_E34;
					case 61:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType = null;
						num = (short)1402535992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IPValidateHelper(peerIP, out error);
						num = (short)1545207836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						if (string.IsNullOrEmpty(peerIP))
						{
							num = (short)1654784057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)492503084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						if (num3 == null)
						{
							num = (short)1185284119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)348389443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						if (!peerIP.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("궜놞醠趢閤覦馨", a_)))
						{
							num = (short)830603311;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_687;
					case 66:
						goto IL_687;
					case 67:
						packetDataMode4 = new global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode?((global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode)num3.GetValueOrDefault());
						goto IL_6FE;
					case 68:
						num = (short)920911880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						goto IL_9E1;
					case 70:
					{
						string[] array;
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("궜", a_)))
						{
							num = (short)1263599662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9BE;
					}
					case 71:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3;
						if (astroSystemType.GetValueOrDefault() == astroSystemType3 & astroSystemType != null)
						{
							num = (short)1077936152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E1;
					}
					case 72:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)1119485977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E1;
					case 73:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileSubIP_NoSame_ProfilePeerIP;
						num = (short)1704656965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						goto IL_9E1;
					case 75:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType = astroSystemType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3 = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
						num = (short)1170669623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 76:
						if (!array2[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("궜", a_)))
						{
							num = (short)1439629328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E34;
					case 77:
						if (peerIP.Trim().Equals(subscriberIP.Trim()))
						{
							num = (short)710213705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1353908234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_170;
					IL_56E:
					array2 = peerIP.Split(new char[]
					{
						'.'
					});
					num = (short)1748893772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_624:
					num = (short)1045364756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_687:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfilePeerIP_NotProperFormat;
					num = (short)893714469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6AC:
					astroSystemType2 = astroSystemType4;
					natEnable = apxDataProfile.NatEnable;
					num3 = apxDataProfile.PacketDataMode;
					num = (short)1887699008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6FE:
					packetDataMode3 = packetDataMode4;
					subscriberIP = apxDataProfile.SubscriberIP;
					airInterfaceAddress = apxDataProfile.AirInterfaceAddress;
					astroBluetoothDunSubscriberIp = apxDataProfile.AstroBluetoothDunSubscriberIp;
					astroBluetoothDunPeerIp = apxDataProfile.AstroBluetoothDunPeerIp;
					bluetoothEnable = (radioFromServer.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).BluetoothEnable;
					num3 = apxDataProfile.BluetoothDunPeerIpAssignmentType;
					num = (short)1492254772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D92:
					bluetoothDunPeerIpAssignmentType3 = bluetoothDunPeerIpAssignmentType;
					regex = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎜랞覠閤誦邨톬肰麲貴论邼蚾鳀뿂鳆杻鋎꫐꣔ꯖ胚헠뻢뻤ퟦ쓨틪냬鏮쏰웲껴쟶퓸컺ꃼ훾崀ⴂⰄ簆㨈瘊┌后ℐ㸒Ⱄ䨖攘䀚Ⱌ㈞ᠠ縢縤ᜦШሪ瀬匮0栲Դᨶ8昺䘼ാ㱀㽂睄᱆祈晊祌቎੐捒硔湖ј❚潜橞㩠卢䡤剦㑨䉪䥬", a_));
					num = (short)624373793;
					short num5 = num;
					num = (short)1333604385;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_753;
					default:
						num = (short)1095041024;
						if (num != 0)
						{
						}
						num = (short)1723859007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_9BE:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NoStartZero;
					num = (short)597688361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9E1:
					result = true;
					num = (short)1208942650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E34:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NoStartZero;
					num = (short)382402634;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_682:
				return result;
				IL_92C:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CodeplugNotExist);
				IL_170:
				error = string.Empty;
				peerIP = apxDataProfile.PeerIP;
				inheritFlag = apxDataProfile.InheritFlag;
				num3 = apxDataProfile.SystemType;
				num = (short)705101857;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00040AE0 File Offset: 0x0003ECE0
		public bool ValidateBluetoothDUNSubscriberIP(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxDataProfile, global::Motorola.CommonCPS.Server.EntityModel.APXRadio radioFromServer, out string error)
		{
			int a_ = 13;
			short num = (short)1636958208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_12F;
				}
				bool result;
				for (;;)
				{
					IL_30:
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
					string airInterfaceAddress;
					global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode2;
					bool? natEnable;
					int? num3;
					global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode4;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType3;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2;
						astroSystemType = astroSystemType2;
						goto IL_277;
					}
					case 1:
					{
						bool? inheritFlag;
						bool? flag = inheritFlag;
						bool flag2 = false;
						num = (short)1397489675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						string astroBluetoothDunSubscriberIp;
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IPValidateHelper(astroBluetoothDunSubscriberIp, out error);
						num = (short)282460189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)173998085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_577;
					}
					case 4:
					{
						string astroBluetoothDunSubscriberIp;
						if (astroBluetoothDunSubscriberIp.Trim().Equals(airInterfaceAddress.Trim()))
						{
							num = (short)30474290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = bluetoothDunPeerIpAssignmentType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType3 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
						num = (short)2041380894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode = packetDataMode2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode packetDataMode3 = global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode.FNE;
						num = (short)507510835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						bool? flag = natEnable;
						bool flag2 = true;
						num = (short)1572867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						string astroBluetoothDunSubscriberIp = apxDataProfile.AstroBluetoothDunSubscriberIp;
						string astroBluetoothDunPeerIp = apxDataProfile.AstroBluetoothDunPeerIp;
						string subscriberIP = apxDataProfile.SubscriberIP;
						string peerIP = apxDataProfile.PeerIP;
						bool? inheritFlag = apxDataProfile.InheritFlag;
						num3 = apxDataProfile.SystemType;
						num = (short)410386433;
						if (num != 0)
						{
						}
						num = (short)688586794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						packetDataMode4 = new global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode?((global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode)num3.GetValueOrDefault());
						goto IL_30F;
					case 9:
						if (radioFromServer.RadioStatus != 0)
						{
							num = (short)2101674023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A98;
					case 10:
						astroSystemType = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType)num3.GetValueOrDefault());
						goto IL_277;
					case 11:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)153288757;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A98;
					}
					case 12:
						goto IL_A98;
					case 13:
						num = (short)1432551480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_A98;
					case 15:
						num = (short)48627745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						bool? bluetoothEnable = (radioFromServer.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).BluetoothEnable;
						num3 = apxDataProfile.BluetoothDunPeerIpAssignmentType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType4;
						if (num3 == null)
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = null;
							bluetoothDunPeerIpAssignmentType4 = bluetoothDunPeerIpAssignmentType;
						}
						else
						{
							bluetoothDunPeerIpAssignmentType4 = new global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType?((global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType)num3.GetValueOrDefault());
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2 = bluetoothDunPeerIpAssignmentType4;
						global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("画躥肧鲫莭覯좳覷鞹薻鮿ￅ闇뛉﷋闍￑试ꏗꇛꋝ틟맡퓣쯥\udce7럩럫\udeed\uddef쯱꧳諵쫷쿹ꟻ컽ⷿ㜁夃⼅吇␉┋甍⌏漑㰓䴕⠗㜙┛䌝尟礡ᔣଥᄧ眩眫ḭᴯ଱椳䨵ष愹఻ጽ礿ὁ㽃瑅㕇㙉繋ᕍ恏网恓୕͗橙煛杝㵟ṡ噣卥㍧婩䅫孭ⵯ孱偳", a_));
						bool? flag = bluetoothEnable;
						bool flag2 = true;
						num = (short)658047007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode = null;
						num = (short)1417543720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_A98;
					case 19:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNSubIP_NoSame_ProfilePeerIP;
						num = (short)782762009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_6B3;
					case 21:
					{
						string astroBluetoothDunSubscriberIp;
						if (string.IsNullOrEmpty(astroBluetoothDunSubscriberIp))
						{
							num = (short)659226668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)878510117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_9C9;
					case 23:
					{
						string[] array;
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("钣", a_)))
						{
							num = (short)1924333600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C9;
					}
					case 24:
						goto IL_A98;
					case 25:
						goto IL_A98;
					case 26:
					{
						string astroBluetoothDunSubscriberIp;
						string subscriberIP;
						if (astroBluetoothDunSubscriberIp.Trim().Equals(subscriberIP))
						{
							num = (short)539885613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)898170923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						if (num3 == null)
						{
							num = (short)1411055633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1152450568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)1200422914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A98;
					case 29:
						goto IL_A98;
					case 30:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType3;
						if (bluetoothDunPeerIpAssignmentType.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType3 & bluetoothDunPeerIpAssignmentType != null)
						{
							num = (short)1917911053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A98;
					}
					case 31:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1850081281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A98;
					}
					case 32:
						num = (short)1085341742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						string astroBluetoothDunSubscriberIp;
						if (!astroBluetoothDunSubscriberIp.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("钣袥颧蒩鲫肭肯", a_)))
						{
							num = (short)372113442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B3;
					}
					case 34:
						num = (short)1638334511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2 = astroSystemType3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType4 = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
						num = (short)536084535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNSubIP_NoSame_ProfileBDUNPeerIP;
						num = (short)1322582030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
					{
						string astroBluetoothDunSubscriberIp;
						global::System.Text.RegularExpressions.Regex regex;
						if (regex.IsMatch(astroBluetoothDunSubscriberIp, 0))
						{
							num = (short)1548550159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B3;
					}
					case 38:
						goto IL_A98;
					case 39:
						goto IL_A8B;
					case 40:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode;
						packetDataMode4 = packetDataMode;
						goto IL_30F;
					}
					case 41:
						goto IL_577;
					case 42:
						if (num3 == null)
						{
							num = (short)586874938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)225837066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						string astroBluetoothDunSubscriberIp;
						string peerIP;
						if (astroBluetoothDunSubscriberIp.Trim().Equals(peerIP.Trim()))
						{
							num = (short)683802643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1517355012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
						num = (short)1243283468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNSubIP_NoSame_ProfileSubIP;
						num = (short)661520422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
					{
						string[] array;
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("钣隥", a_)))
						{
							num = (short)2086797360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C9;
					}
					case 47:
					{
						string astroBluetoothDunSubscriberIp;
						if (astroBluetoothDunSubscriberIp.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("隣鎥鶧蒩麫鮭薯鲱蚳莵趷钹躻讽", a_)))
						{
							num = (short)1348599828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1072889882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						num = (short)1509490745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType4;
						if (astroSystemType2.GetValueOrDefault() == astroSystemType4 & astroSystemType2 != null)
						{
							num = (short)645529606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A98;
					}
					case 50:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_ProfileBlueToothDUNSubIP;
						num = (short)669253656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode;
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode packetDataMode3;
						if (packetDataMode.GetValueOrDefault() == packetDataMode3 & packetDataMode != null)
						{
							num = (short)1393098787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_577;
					}
					case 52:
						return result;
					case 53:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2 = astroSystemType3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType4 = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
						num = (short)256639025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
						if (!string.IsNullOrEmpty(error))
						{
							num = (short)2022768701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 55:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType4;
						if (!(astroSystemType2.GetValueOrDefault() == astroSystemType4 & astroSystemType2 != null))
						{
							num = (short)1227489321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A98;
					}
					case 56:
					{
						string astroBluetoothDunSubscriberIp;
						string astroBluetoothDunPeerIp;
						if (astroBluetoothDunSubscriberIp.Trim().Equals(astroBluetoothDunPeerIp.Trim()))
						{
							num = (short)1497759780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array = astroBluetoothDunSubscriberIp.Split(new char[]
						{
							'.'
						});
						num = (short)563675159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 57:
					{
						string[] array;
						if (array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("钣隥颧", a_)))
						{
							num = (short)1373765654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)834666524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 58:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2 = null;
						num = (short)739770368;
						short num4 = num;
						num = (short)1364983808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						goto IL_A98;
					case 60:
						if (radioFromServer.WorkingCodeplug != null)
						{
							num = (short)1388642311;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)370212873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
					{
						result = false;
						num = (short)769145565;
						short num5 = num;
						num = (short)414137053;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6B3;
						default:
							num = (short)464060416;
							if (num != 0)
							{
							}
							num = (short)502464564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_12F;
					IL_277:
					astroSystemType3 = astroSystemType;
					natEnable = apxDataProfile.NatEnable;
					num3 = apxDataProfile.PacketDataMode;
					num = (short)1104740379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30F:
					packetDataMode2 = packetDataMode4;
					airInterfaceAddress = apxDataProfile.AirInterfaceAddress;
					string automaticRegistrationServerAddress = apxDataProfile.AutomaticRegistrationServerAddress;
					num = (short)166330384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_577:
					num = (short)1564278805;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B3:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNSubscriberIP_IP_NotProperFormat;
					num = (short)2004549691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9C9:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NoStartZero;
					num = (short)1734279186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A98:
					num = (short)1620443190;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A8B:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CodeplugNotExist);
				IL_12F:
				result = true;
				error = string.Empty;
				num = (short)367853628;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00041630 File Offset: 0x0003F830
		public bool ValidateBluetoothDUNPeerIP(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxDataProfile, global::Motorola.CommonCPS.Server.EntityModel.APXRadio radioFromServer, out string error)
		{
			int a_ = 11;
			short num = (short)1757937664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_13B;
				}
				bool result;
				for (;;)
				{
					IL_30:
					int? num3;
					global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType4;
					global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode3;
					string airInterfaceAddress;
					bool? natEnable;
					switch (num2)
					{
					case 0:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)2001600561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A0;
					case 1:
						goto IL_9A0;
					case 2:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNPeerIP_NoSame_ProfilePeerIP;
						num = (short)1705902116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						string astroBluetoothDunPeerIp;
						if (astroBluetoothDunPeerIp.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("邡醣鎥蚧颩馫鮭麯肱膳莵隷袹覻讽", a_)))
						{
							num = (short)2041446440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1773338641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						string astroBluetoothDunPeerIp = apxDataProfile.AstroBluetoothDunPeerIp;
						string astroBluetoothDunSubscriberIp = apxDataProfile.AstroBluetoothDunSubscriberIp;
						string subscriberIP = apxDataProfile.SubscriberIP;
						string peerIP = apxDataProfile.PeerIP;
						bool? inheritFlag = apxDataProfile.InheritFlag;
						num3 = apxDataProfile.SystemType;
						num = (short)1573557461;
						short num4 = num;
						num = (short)1034851541;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_31C;
						default:
							num = (short)271450112;
							if (num != 0)
							{
							}
							num = (short)503316538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
					{
						string astroBluetoothDunPeerIp;
						string peerIP;
						if (astroBluetoothDunPeerIp.Trim().Equals(peerIP.Trim()))
						{
							num = (short)125304834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2034761754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNPeerIP_NoSame_ProfileSubIP;
						num = (short)377225257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)486735917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_A5D;
					case 9:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode2;
						packetDataMode = packetDataMode2;
						goto IL_577;
					}
					case 10:
						goto IL_9A0;
					case 11:
						goto IL_9A0;
					case 12:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType = astroSystemType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3 = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
						num = (short)38535227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (!string.IsNullOrEmpty(error))
						{
							num = (short)1416560661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C1D;
					case 14:
						num = (short)1212153885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_9A0;
					case 16:
					{
						string astroBluetoothDunPeerIp;
						if (string.IsNullOrEmpty(astroBluetoothDunPeerIp))
						{
							num = (short)1444020271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)578420760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						string astroBluetoothDunPeerIp;
						string subscriberIP;
						if (astroBluetoothDunPeerIp.Trim().Equals(subscriberIP.Trim()))
						{
							num = (short)1361969158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1477705733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						num = (short)35258388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
						astroSystemType4 = astroSystemType;
						goto IL_38F;
					}
					case 20:
					{
						string[] array;
						if (array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("銡钣隥", a_)))
						{
							num = (short)615055411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1016266752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						result = false;
						num = (short)1195442184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)280166464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode2 = packetDataMode3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode packetDataMode4 = global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode.FNE;
						num = (short)103350307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						string astroBluetoothDunPeerIp;
						global::System.Text.RegularExpressions.Regex regex;
						if (regex.IsMatch(astroBluetoothDunPeerIp, 0))
						{
							num = (short)1811480598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36B;
					}
					case 25:
					{
						bool? inheritFlag;
						bool? flag = inheritFlag;
						bool flag2 = false;
						num = (short)1389232167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						string astroBluetoothDunPeerIp;
						if (astroBluetoothDunPeerIp.Trim().Equals(airInterfaceAddress.Trim()))
						{
							num = (short)698810406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = bluetoothDunPeerIpAssignmentType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType3 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
						num = (short)1727791146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
					{
						bool? flag = natEnable;
						bool flag2 = true;
						goto IL_31C;
					}
					case 28:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType = null;
						num = (short)1620770835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						goto IL_6D2;
					case 30:
					{
						string[] array;
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("銡钣", a_)))
						{
							num = (short)1067909138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB9;
					}
					case 31:
						num = (short)1048379422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_5D7;
					case 33:
						packetDataMode = new global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode?((global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode)num3.GetValueOrDefault());
						goto IL_577;
					case 34:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1785200663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D7;
					}
					case 35:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode packetDataMode4;
						if (packetDataMode2.GetValueOrDefault() == packetDataMode4 & packetDataMode2 != null)
						{
							num = (short)2046820364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D7;
					}
					case 36:
						goto IL_9A0;
					case 37:
						goto IL_9A0;
					case 38:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_ProfileBlueToothDUNPeerIP;
						num = (short)2047737904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1562902574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A0;
					}
					case 40:
						goto IL_36B;
					case 41:
						goto IL_9A0;
					case 42:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType3;
						if (bluetoothDunPeerIpAssignmentType.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType3 & bluetoothDunPeerIpAssignmentType != null)
						{
							num = (short)596115463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A0;
					}
					case 43:
						astroSystemType4 = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType)num3.GetValueOrDefault());
						goto IL_38F;
					case 44:
					{
						bool? bluetoothEnable = (radioFromServer.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).BluetoothEnable;
						num3 = apxDataProfile.BluetoothDunPeerIpAssignmentType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType4;
						if (num3 == null)
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = null;
							bluetoothDunPeerIpAssignmentType4 = bluetoothDunPeerIpAssignmentType;
						}
						else
						{
							bluetoothDunPeerIpAssignmentType4 = new global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType?((global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType)num3.GetValueOrDefault());
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2 = bluetoothDunPeerIpAssignmentType4;
						global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﲡ貣躥骩膫鞭캱螵閷莹ﷃ鯅듇﯉韋ﻍ﷏觓귕ꟙꃛ믟틡짣틥뗧뇩\udceb쏭짯꿱裳쓵췷ꇹ쳻폽㗿弁ⴃ娅☇⌉看㴍洏㨑伓☕㔗⌙䄛戝笟ጡणἥ甧焩ᰫ̭य漱䠳ܵ挷ਹᄻܽᴿ㥁癃㭅㑇硉ᝋ繍絏晑॓ൕ桗睙敛͝ᱟ偡兣㵥塧䝩奫㍭奯噱", a_));
						bool? flag = bluetoothEnable;
						bool flag2 = true;
						num = (short)1977483314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
					{
						string astroBluetoothDunPeerIp;
						string astroBluetoothDunSubscriberIp;
						if (astroBluetoothDunPeerIp.Trim().Equals(astroBluetoothDunSubscriberIp))
						{
							num = (short)1353842749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array = astroBluetoothDunPeerIp.Split(new char[]
						{
							'.'
						});
						num = (short)1140850750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType = astroSystemType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3 = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
						num = (short)298385461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
						num = (short)250478603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						goto IL_9A0;
					case 49:
					{
						string astroBluetoothDunPeerIp;
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IPValidateHelper(astroBluetoothDunPeerIp, out error);
						num = (short)879558693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1051394105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A0;
					}
					case 51:
						goto IL_AB9;
					case 52:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode2 = null;
						num = (short)1957822473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3;
						if (astroSystemType.GetValueOrDefault() == astroSystemType3 & astroSystemType != null)
						{
							num = (short)1910243355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A0;
					}
					case 54:
						if (radioFromServer.RadioStatus != 0)
						{
							num = (short)2035810318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A0;
					case 55:
						num = (short)1130954755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (num3 == null)
						{
							num = (short)299499572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1290010657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = bluetoothDunPeerIpAssignmentType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType3 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
						num = (short)2051997756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 58:
					{
						num = (short)458620928;
						short num5 = num;
						if (num3 == null)
						{
							num = (short)879296540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)313983019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3;
						if (!(astroSystemType.GetValueOrDefault() == astroSystemType3 & astroSystemType != null))
						{
							num = (short)633864224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A0;
					}
					case 60:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType3;
						if (bluetoothDunPeerIpAssignmentType.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType3 & bluetoothDunPeerIpAssignmentType != null)
						{
							num = (short)209715225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A0;
					}
					case 61:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNSubIP_NoSame_ProfileBDUNPeerIP;
						num = (short)746192906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
					{
						string[] array;
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("銡", a_)))
						{
							num = (short)382337055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB9;
					}
					case 63:
						if (radioFromServer.WorkingCodeplug != null)
						{
							num = (short)1786314756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)339279926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
					{
						string astroBluetoothDunPeerIp;
						if (!astroBluetoothDunPeerIp.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("銡誣隥蚧骩芫麭", a_)))
						{
							num = (short)956497975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36B;
					}
					}
					goto IL_13B;
					IL_31C:
					num = (short)1858404386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36B:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNPeerIP_IP_NotProperFormat;
					num = (short)971505679;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38F:
					astroSystemType2 = astroSystemType4;
					natEnable = apxDataProfile.NatEnable;
					num3 = apxDataProfile.PacketDataMode;
					num = (short)2076966968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_577:
					packetDataMode3 = packetDataMode;
					airInterfaceAddress = apxDataProfile.AirInterfaceAddress;
					string automaticRegistrationServerAddress = apxDataProfile.AutomaticRegistrationServerAddress;
					num = (short)296878124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D7:
					num = (short)1513029648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A0:
					num = (short)1287716877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB9:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NoStartZero;
					num = (short)1251213313;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_6D2:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CodeplugNotExist);
				IL_A5D:
				IL_C1D:
				num = (short)1666252801;
				if (num != 0)
				{
				}
				return result;
				IL_13B:
				result = true;
				error = string.Empty;
				num = (short)1910243391;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00042284 File Offset: 0x00040484
		public bool ValidateSubscriberIP(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxDataProfile, global::Motorola.CommonCPS.Server.EntityModel.APXRadio radioFromServer, out string error)
		{
			int a_ = 18;
			short num = (short)1156579328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_167;
				}
				int? num3;
				string subscriberIP;
				bool? inheritFlag;
				bool result;
				string peerIP;
				for (;;)
				{
					IL_30:
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
					global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode;
					string automaticRegistrationServerAddress;
					string[] array;
					global::System.Text.RegularExpressions.Regex regex;
					global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode3;
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
					string astroBluetoothDunSubscriberIp;
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType3;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType4;
					bool? natEnable;
					string airInterfaceAddress;
					bool? bluetoothEnable;
					string astroBluetoothDunPeerIp;
					switch (num2)
					{
					case 0:
						goto IL_B02;
					case 1:
						goto IL_B02;
					case 2:
						astroSystemType = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType)num3.GetValueOrDefault());
						goto IL_877;
					case 3:
						goto IL_B02;
					case 4:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)777453643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B02;
					}
					case 5:
						packetDataMode = new global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode?((global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode)num3.GetValueOrDefault());
						goto IL_D5C;
					case 6:
						if (subscriberIP.Trim().Equals(automaticRegistrationServerAddress))
						{
							num = (short)1722810402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1115488323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("馨", a_)))
						{
							num = (short)752156708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF1;
					case 8:
						num = (short)137166878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						if (string.IsNullOrEmpty(subscriberIP))
						{
							num = (short)380829770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool? flag = inheritFlag;
						bool flag2 = false;
						num = (short)1944911876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (regex.IsMatch(subscriberIP, 0))
						{
							num = (short)1998061568;
							short num4 = num;
							num = (short)1925644357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_852;
					case 11:
						num = (short)543358986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_287;
					case 13:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode2 = packetDataMode3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode packetDataMode4 = global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode.FNE;
						num = (short)1592655889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_CF1;
					case 15:
						if (array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("馨鮪鶬", a_)))
						{
							num = (short)2059272206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1622605867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)263716935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode packetDataMode4;
						if (packetDataMode2.GetValueOrDefault() == packetDataMode4 & packetDataMode2 != null)
						{
							num = (short)411303991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_287;
					}
					case 18:
						goto IL_B02;
					case 19:
						goto IL_B02;
					case 20:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3;
						if (!(astroSystemType2.GetValueOrDefault() == astroSystemType3 & astroSystemType2 != null))
						{
							num = (short)1559298060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B02;
					}
					case 21:
						bluetoothDunPeerIpAssignmentType = new global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType?((global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType)num3.GetValueOrDefault());
						goto IL_A02;
					case 22:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1947598861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_287;
					}
					case 23:
						goto IL_B02;
					case 24:
						if (!string.IsNullOrEmpty(error))
						{
							num = (short)1868496927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 25:
						goto IL_AAF;
					case 26:
						return result;
					case 27:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileSubIP_NoSame_AirInterfaceIP;
						num = (short)1034092545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (!subscriberIP.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("馨薪鶬膮膰鶲薴", a_)))
						{
							num = (short)1394737193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_852;
					case 29:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2;
						astroSystemType = astroSystemType2;
						goto IL_877;
					}
					case 30:
					{
						string[] array2;
						if (!array2[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("馨鮪", a_)))
						{
							num = (short)320536601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9DD;
					}
					case 31:
						result = false;
						num = (short)183566362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_B02;
					case 33:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3;
						if (astroSystemType2.GetValueOrDefault() == astroSystemType3 & astroSystemType2 != null)
						{
							num = (short)705757250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B02;
					}
					case 34:
						num = (short)346816513;
						if (num != 0)
						{
						}
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileSubIP_NoSame_AutomaticRegistrationServerAddressIP;
						num = (short)1043988498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IPValidateHelper(subscriberIP, out error);
						num = (short)1610219539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)1763442748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileSubIP_NoSame_ProfilePeerIP;
						num = (short)1861615663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (subscriberIP.Trim().Equals(peerIP.Trim()))
						{
							num = (short)1035403301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1117388806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2 = null;
						num = (short)144244765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						if (num3 == null)
						{
							num = (short)1804206119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1549860866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)851181641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IPValidateHelper(subscriberIP, out error);
						num = (short)1808465952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)1665007651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B02;
					case 44:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2;
						bluetoothDunPeerIpAssignmentType = bluetoothDunPeerIpAssignmentType2;
						goto IL_A02;
					}
					case 45:
					{
						string[] array2;
						if (!array2[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("馨", a_)))
						{
							num = (short)1351417864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9DD;
					}
					case 46:
						if (num3 == null)
						{
							num = (short)2077818950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1213661205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_B02;
					case 48:
						goto IL_852;
					case 49:
						goto IL_B02;
					case 50:
						num = (short)802029620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
					{
						string[] array2;
						if (array2[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("馨鮪鶬", a_)))
						{
							num = (short)729219128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)841809979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
					{
						if (subscriberIP.Trim().Equals(astroBluetoothDunSubscriberIp))
						{
							num = (short)1982726202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2 = bluetoothDunPeerIpAssignmentType3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType4 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
						num = (short)497811513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode2 = null;
						num = (short)899219528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)1703149579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B02;
					case 55:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2 = astroSystemType4;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3 = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
						num = (short)1128792084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						goto IL_9DD;
					case 57:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType4;
						if (bluetoothDunPeerIpAssignmentType2.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType4 & bluetoothDunPeerIpAssignmentType2 != null)
						{
							num = (short)625606672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D1;
					}
					case 58:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNSubIP_NoSame_SubIP;
						num = (short)218890304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)1166868522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B02;
					case 60:
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("馨鮪", a_)))
						{
							num = (short)1509949503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF1;
					case 61:
						goto IL_B02;
					case 62:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileBluetoothDUNPeerIP_NoSame_ProfileSubIP;
						num = (short)189595651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						num = (short)1549991951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						goto IL_B02;
					case 65:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1108344882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array2 = subscriberIP.Split(new char[]
						{
							'.'
						});
						num = (short)1209532461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 66:
					{
						bool? flag = natEnable;
						bool flag2 = true;
						num = (short)1545535510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 67:
					{
						if (subscriberIP.Trim().Equals(airInterfaceAddress))
						{
							num = (short)1026490395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool? flag = bluetoothEnable;
						bool flag2 = true;
						num = (short)715194433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 68:
						if (num3 == null)
						{
							num = (short)864550965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1579745285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
					{
						num = (short)18276904;
						short num5 = num;
						num = (short)1568530984;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AAF;
						default:
							num = (short)1385431040;
							if (num != 0)
							{
							}
							num = (short)1197211676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 70:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2 = null;
						num = (short)1539440684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
						if (subscriberIP.Trim().Equals(astroBluetoothDunPeerIp))
						{
							num = (short)1767178302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D1;
					case 72:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode2;
						packetDataMode = packetDataMode2;
						goto IL_D5C;
					}
					case 73:
						if (subscriberIP.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("鮨麪颬膮莰蚲肴馶许躺袼醾", a_)))
						{
							num = (short)1308753968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)654573606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
						num = (short)1753612337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2 = astroSystemType4;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3 = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
						num = (short)1628700705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_167;
					IL_1D1:
					array = subscriberIP.Split(new char[]
					{
						'.'
					});
					num = (short)1279721479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_287:
					num = (short)1519452214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_852:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileSubIP_NotProperFormat;
					num = (short)314376192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_877:
					astroSystemType4 = astroSystemType;
					natEnable = apxDataProfile.NatEnable;
					num3 = apxDataProfile.PacketDataMode;
					num = (short)513671236;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9DD:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NoStartZero;
					num = (short)1887633469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A02:
					bluetoothDunPeerIpAssignmentType3 = bluetoothDunPeerIpAssignmentType;
					regex = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("莪薬膰麲貴언貼銾黂黄郌돎裒𥳐蛚ꛜ鳠鿢ퟤ볦\ud9e8웪\ud9ec닮꫰쏲\ud8f4컶ꓸ蟺쿼쫾娀㌂⠄㈆合∊儌ℎ㠐栒☔樖ㄘ䀚ⴜ㈞ᠠ縢夤簦ᠨتᐬ爮樰̲ᠴึ搸䜺఼搾煀湂籄ᩆ㉈祊が㍎捐ࡒ敔穖浘ٜٚ潞䱠婢㡤᭦孨幪㙬彮屰䙲⡴并嵸", a_));
					num = (short)1421672457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AAF:
					num = (short)1614020659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B02:
					num = (short)1256325144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CF1:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NoStartZero;
					num = (short)1852768279;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D5C:
					packetDataMode3 = packetDataMode;
					airInterfaceAddress = apxDataProfile.AirInterfaceAddress;
					automaticRegistrationServerAddress = apxDataProfile.AutomaticRegistrationServerAddress;
					astroBluetoothDunSubscriberIp = apxDataProfile.AstroBluetoothDunSubscriberIp;
					astroBluetoothDunPeerIp = apxDataProfile.AstroBluetoothDunPeerIp;
					bluetoothEnable = (radioFromServer.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).BluetoothEnable;
					num3 = apxDataProfile.BluetoothDunPeerIpAssignmentType;
					num = (short)1130692654;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_167:
				result = true;
				error = string.Empty;
				subscriberIP = apxDataProfile.SubscriberIP;
				peerIP = apxDataProfile.PeerIP;
				inheritFlag = apxDataProfile.InheritFlag;
				num3 = apxDataProfile.SystemType;
				num = (short)1754005544;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00043094 File Offset: 0x00041294
		public bool ValidateAirInterfaceIP(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxDataProfile, global::Motorola.CommonCPS.Server.EntityModel.APXRadio radioFromServer, out string error)
		{
			int a_ = 3;
			short num = (short)1136721920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1A8;
				}
				bool result;
				for (;;)
				{
					IL_31:
					int? num4;
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType2;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType4;
					bool? natEnable;
					global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode3;
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType4;
					bool? bluetoothEnable;
					global::System.Text.RegularExpressions.Regex regex;
					string automaticRegistrationServerAddress;
					global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode4;
					int? arsMode;
					switch (num2)
					{
					case 0:
						num = (short)1518075911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_B9C;
					case 2:
					{
						num = (short)234923097;
						short num3 = num;
						num = (short)137208921;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B84;
						default:
							num = (short)270401536;
							if (num != 0)
							{
							}
							num = (short)1014562847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
					{
						int num5;
						if (num4.GetValueOrDefault() == num5 & num4 != null)
						{
							num = (short)1267728417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC;
					}
					case 4:
					{
						string[] array;
						if (array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꪙ겛꺝", a_)))
						{
							num = (short)1786904588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string airInterfaceAddress;
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IPValidateHelper(airInterfaceAddress, out error);
						num = (short)1977024596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						string airInterfaceAddress;
						if (airInterfaceAddress.Contains(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("뒙늛", a_)))
						{
							num = (short)1294925854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool? inheritFlag;
						bool? flag = inheritFlag;
						bool flag2 = false;
						num = (short)183435329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = bluetoothDunPeerIpAssignmentType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType3 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
						num = (short)460652596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						string airInterfaceAddress;
						if (airInterfaceAddress.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꢙꦛꮝ躟邡醣鎥蚧颩馫鮭麯肱膳莵", a_)))
						{
							num = (short)2102394897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)7667769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)1715667025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_47E;
					case 10:
						num = (short)76480561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType = astroSystemType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3 = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
						num = (short)47841347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_AE8;
					case 13:
						if (num4 == null)
						{
							num = (short)1134100538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1799487529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						string airInterfaceAddress = apxDataProfile.AirInterfaceAddress;
						string astroBluetoothDunSubscriberIp = apxDataProfile.AstroBluetoothDunSubscriberIp;
						string astroBluetoothDunPeerIp = apxDataProfile.AstroBluetoothDunPeerIp;
						string subscriberIP = apxDataProfile.SubscriberIP;
						string peerIP = apxDataProfile.PeerIP;
						bool? inheritFlag = apxDataProfile.InheritFlag;
						num4 = apxDataProfile.SystemType;
						num = (short)1950547997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_2BC;
					case 16:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
						astroSystemType4 = astroSystemType;
						goto IL_FA7;
					}
					case 17:
						goto IL_328;
					case 18:
						goto IL_2BC;
					case 19:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)1135804499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47E;
					case 20:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)855113734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F12;
					}
					case 21:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_AutomaticRegistrationServerAddressIP;
						num = (short)17432604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_ProfilePeerIP;
						num = (short)2621512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_2BC;
					case 24:
						num = (short)1041301583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						bool? flag = natEnable;
						bool flag2 = true;
						num = (short)1305804877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_BlueToothDUNSubIP;
						num = (short)127926323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)1723334660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_2BC;
					case 29:
						if (num4 == null)
						{
							num = (short)406782021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1779761218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterface_IP_NotProperFormat;
						num = (short)1055457324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						string airInterfaceAddress;
						string astroBluetoothDunPeerIp;
						if (airInterfaceAddress.Trim().Equals(astroBluetoothDunPeerIp.Trim()))
						{
							num = (short)1649868853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A9B;
					}
					case 32:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode;
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode packetDataMode2;
						if (!(packetDataMode.GetValueOrDefault() == packetDataMode2 & packetDataMode != null))
						{
							num = (short)957218887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_372;
					}
					case 33:
					{
						num = (short)966066176;
						short num6 = num;
						num = (short)523960380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						goto IL_F12;
					case 35:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode = packetDataMode3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode packetDataMode2 = global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode.FNE;
						num = (short)1419313184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						num = (short)2095317038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode = null;
						num = (short)807338045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
					{
						string airInterfaceAddress;
						string peerIP;
						if (airInterfaceAddress.Trim().Equals(peerIP.Trim()))
						{
							num = (short)296222742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_372;
					}
					case 39:
						goto IL_CCE;
					case 40:
						if (!string.IsNullOrEmpty(error))
						{
							num = (short)112394329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 41:
						bluetoothDunPeerIpAssignmentType4 = new global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType?((global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType)num4.GetValueOrDefault());
						goto IL_E5D;
					case 42:
					{
						string airInterfaceAddress;
						string astroBluetoothDunSubscriberIp;
						if (airInterfaceAddress.Trim().Equals(astroBluetoothDunSubscriberIp.Trim()))
						{
							num = (short)147783706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F12;
					}
					case 43:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_SubIP;
						num = (short)776339474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						goto IL_47E;
					case 45:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3;
						if (astroSystemType.GetValueOrDefault() == astroSystemType3 & astroSystemType != null)
						{
							num = (short)1308295193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_372;
					}
					case 46:
					{
						string airInterfaceAddress;
						if (!airInterfaceAddress.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꪙ늛꺝躟銡誣隥", a_)))
						{
							num = (short)735903754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CCE;
					}
					case 47:
						num = (short)63242315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)1392574526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47E;
					case 49:
					{
						string airInterfaceAddress;
						if (airInterfaceAddress.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꢙꦛꮝ躟邡醣鎥蚧颩馫鮭麯肱膳莵", a_)))
						{
							num = (short)438829095;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool? flag = bluetoothEnable;
						bool flag2 = true;
						num = (short)1349845012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1783496715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47E;
					}
					case 51:
						goto IL_F12;
					case 52:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType3;
						if (bluetoothDunPeerIpAssignmentType.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType3 & bluetoothDunPeerIpAssignmentType != null)
						{
							num = (short)484311042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A9B;
					}
					case 53:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_BlueToothDUNPeerIP;
						num = (short)1286078540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						num = (short)1957953618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
					{
						string airInterfaceAddress;
						if (string.IsNullOrEmpty(airInterfaceAddress))
						{
							num = (short)1892941911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1799028741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
					{
						string airInterfaceAddress;
						if (regex.IsMatch(airInterfaceAddress, 0))
						{
							num = (short)1440940068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CCE;
					}
					case 57:
					{
						string airInterfaceAddress;
						if (airInterfaceAddress.Trim().Equals((radioFromServer.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).SubscriberIP))
						{
							num = (short)1430061099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)531890254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 58:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = null;
						num = (short)817299546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)2070544408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_372;
					case 60:
					{
						string airInterfaceAddress;
						if (airInterfaceAddress.Trim().Equals(automaticRegistrationServerAddress.Trim()))
						{
							num = (short)883425301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC;
					}
					case 61:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode;
						packetDataMode4 = packetDataMode;
						goto IL_BF4;
					}
					case 62:
					{
						bool? inheritFlag;
						bool? flag = inheritFlag;
						bool flag2 = false;
						num = (short)719847474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 63:
						if (num4 == null)
						{
							num = (short)259194917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1481441354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
					{
						string[] array;
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꪙ", a_)))
						{
							num = (short)1985609736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE8;
					}
					case 65:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)772276315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_372;
					}
					case 66:
						astroSystemType4 = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType)num4.GetValueOrDefault());
						goto IL_FA7;
					case 67:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3;
						if (astroSystemType.GetValueOrDefault() == astroSystemType3 & astroSystemType != null)
						{
							num = (short)208535606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47E;
					}
					case 68:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_ProfileSubIP;
						num = (short)505479241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType = null;
						num = (short)1476919312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 70:
						return result;
					case 71:
						goto IL_831;
					case 72:
						goto IL_372;
					case 73:
						goto IL_372;
					case 74:
						packetDataMode4 = new global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode?((global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode)num4.GetValueOrDefault());
						goto IL_BF4;
					case 75:
					{
						string airInterfaceAddress;
						if (!airInterfaceAddress.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꪙ늛꺝躟銡誣隥", a_)))
						{
							num = (short)326631424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_328;
					}
					case 76:
						goto IL_F12;
					case 77:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1243086883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_831;
					}
					case 78:
					{
						string airInterfaceAddress;
						if (airInterfaceAddress.Trim().Equals((radioFromServer.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).PeerIP))
						{
							num = (short)635437142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = arsMode;
						int num5 = 1;
						num = (short)790757379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 79:
					{
						string airInterfaceAddress;
						string subscriberIP;
						if (airInterfaceAddress.Trim().Equals(subscriberIP.Trim()))
						{
							num = (short)703070276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1369112614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 80:
						if (radioFromServer.WorkingCodeplug != null)
						{
							num = (short)1504706574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1130692696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
					{
						num = (short)393543681;
						if (num != 0)
						{
						}
						string[] array;
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꪙ겛", a_)))
						{
							num = (short)1220214811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE8;
					}
					case 82:
					{
						string airInterfaceAddress;
						if (regex.IsMatch(airInterfaceAddress, 0))
						{
							num = (short)1664876591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_328;
					}
					case 83:
					{
						string airInterfaceAddress;
						string[] array = airInterfaceAddress.Split(new char[]
						{
							'.'
						});
						new byte[4];
						num = (short)2099511360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 84:
						goto IL_47E;
					case 85:
						goto IL_47E;
					case 86:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterfaceIP_NoSame_PeerIP;
						num = (short)606142487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
						num = (short)119537749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						if (radioFromServer.RadioStatus != 0)
						{
							goto IL_B84;
						}
						goto IL_47E;
					case 89:
						result = false;
						num = (short)243990598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
						bluetoothDunPeerIpAssignmentType4 = bluetoothDunPeerIpAssignmentType;
						goto IL_E5D;
					}
					case 91:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType = astroSystemType2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType3 = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
						num = (short)241565741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_1A8;
					IL_2BC:
					num = (short)184614931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_328:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterface_IP_NotProperFormat;
					num = (short)919601167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_372:
					num = (short)1984692272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47E:
					num = (short)1831731240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_831:
					num = (short)602406968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A9B:
					num = (short)1768947754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AE8:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NoStartZero;
					num = (short)134479881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B84:
					num = (short)1125711873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BF4:
					packetDataMode3 = packetDataMode4;
					automaticRegistrationServerAddress = apxDataProfile.AutomaticRegistrationServerAddress;
					bluetoothEnable = (radioFromServer.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).BluetoothEnable;
					num4 = apxDataProfile.BluetoothDunPeerIpAssignmentType;
					num = (short)1389625357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CCE:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterface_IP_NotProperFormat;
					num = (short)1707278370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E5D:
					bluetoothDunPeerIpAssignmentType2 = bluetoothDunPeerIpAssignmentType4;
					arsMode = apxDataProfile.ArsMode;
					regex = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쒙뒛뚝ﮟ銡覣龥횩龭鶯讱袷鞹薻벿鿃釋뗍꿑꣓菗뷟맡퓣쯥퇧럩郫\udced엯꧱쓳\udbf5췷ꟹ헻ꋽ⻿⬁缃㔅甇∉國㸍㴏⬑䤓樕䌗⬙ㄛ✝紟礡ᐣଥᄧ眩倫Ἥ欯ȱᤳ༵攷䄹฻䌽㰿灁ὃ癅敇繉ᅋᕍ恏网浓୕⑗桙楛՝偟佡兣㭥䅧乩", a_));
					num = (short)1442775095;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F12:
					num = (short)1528102971;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FA7:
					astroSystemType2 = astroSystemType4;
					natEnable = apxDataProfile.NatEnable;
					num4 = apxDataProfile.PacketDataMode;
					num = (short)1492320319;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B9C:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CodeplugNotExist);
				IL_1A8:
				result = true;
				error = string.Empty;
				num = (short)123076688;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00044160 File Offset: 0x00042360
		private void a(int A_0, int A_1, global::Motorola.Common.CustomException.CommonErrorCode A_2, out string A_3)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_79;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				string @string;
				switch (num)
				{
				case 0:
					goto IL_41A;
				case 1:
				{
					num2 = (short)1170997248;
					short num3 = num2;
					if (A_2 == global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_DupWithTgIDs)
					{
						num2 = (short)1463615510;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					goto IL_366;
				case 3:
					goto IL_3A5;
				case 4:
					num2 = (short)1702494216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					A_3 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, @string, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꪙ邟\udfa1", a_), A_0.ToString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슙", a_), global::System.Globalization.CultureInfo.InvariantCulture)), string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꪙ邟\udfa1", a_), A_1.ToString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슙", a_), global::System.Globalization.CultureInfo.InvariantCulture)), string.Empty);
					num2 = (short)523894786;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_361;
				case 7:
					if (A_2 == global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_Contain_F)
					{
						num2 = (short)510001155;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_41A;
				case 8:
					if (A_2 == global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_OutOfRange)
					{
						num2 = (short)396820485;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_366;
				case 9:
				{
					string string2 = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udf99쾟킡ﮣ즧캩얫솭羚햷쪹좻잽", a_));
					A_3 = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, string2, global::System.Array.Empty<object>());
					num2 = (short)1249509396;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					A_3 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, @string, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꪙ邟\udfa1", a_), A_0.ToString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슙", a_), global::System.Globalization.CultureInfo.InvariantCulture)), string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꪙ邟\udfa1", a_), A_1.ToString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슙", a_), global::System.Globalization.CultureInfo.InvariantCulture)), global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udf99쾟킡ﮣ즧캩얫솭羚ힷ풹좻\udfbdꦿ곁鯃胅", a_)));
					num2 = (short)1021050901;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROMDCEntryFormat.ToUpperInvariant() == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튙", a_))
					{
						num2 = (short)806223876;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)632094739;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (A_2 == global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_Contain_F)
					{
						num2 = (short)1143144458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_41A;
				case 13:
					if (A_2 == global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_Empty)
					{
						num2 = (short)396689417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_29D;
				case 14:
					A_3 = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, @string, A_0, A_1, global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udf99쾟킡ﮣ즧캩얫솭羚ힷ풹좻\udfbdꦿ곁鯃胅", a_)));
					num2 = (short)924778496;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_4BC;
				case 16:
					if (A_2 == global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_Contain_F)
					{
						num2 = (short)306315278;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_41A;
				case 17:
					if (A_2 != global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_OutOfRange)
					{
						num2 = (short)71368722;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3A5;
				case 18:
					num2 = (short)2055864327;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (A_2 == global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_OutOfRange)
					{
						num2 = (short)1910046735;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DD;
				case 20:
					goto IL_29D;
				case 21:
					goto IL_41A;
				case 22:
				{
					string string3 = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udf99쾟킡ﮣ즧캩얫솭羚춷쪹ힽ뒿꫁郃ꇅ臇軉뿋", a_));
					A_3 = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, string3, global::System.Array.Empty<object>());
					num2 = (short)1521614854;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 23:
					goto IL_2DD;
				}
				goto IL_79;
				IL_29D:
				num2 = (short)1686044689;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2DD:
				num2 = (short)289210384;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_366:
				num2 = (short)1314455564;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3A5:
				@string = global::RFResourceRepository.RFErrorResources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udf99쾟킡ﮣ즧캩얫솭羚例춷캹\ud8bd銿ꏁ꫃ꇅ귇", a_));
				num2 = (short)1465384971;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_41A:
				num2 = (short)972881921;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_361:
			return;
			IL_4BC:
			goto IL_12F;
			IL_79:
			A_3 = string.Empty;
			num2 = (short)1325570941;
			short num4 = num2;
			num2 = (short)279485309;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_12F:
				string @string;
				A_3 = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, @string, A_0, A_1, string.Empty);
				num2 = (short)356712471;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)1112211457;
				if (num2 != 0)
				{
				}
				num2 = (short)1639317504;
				if (num2 != 0)
				{
				}
				num2 = (short)2098855949;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}
	}
}
