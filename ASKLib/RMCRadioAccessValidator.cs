using System;
using ASK.Interface;
using Motorola.CommonCPS.ResourceRepository;

namespace ASKLib
{
	// Token: 0x0200000A RID: 10
	public class RMCRadioAccessValidator : global::ASK.Interface.IRadioAccessValidator
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00003FF8 File Offset: 0x000021F8
		public bool ValidateAstroRadioWrite(global::ASK.Interface.IRadioSecurityData radSecData, global::ASK.Interface.IRadioSecurityData cpgSecurityData, int transportPreference, out bool bUpdated, out string stsMsg, bool isRMCWriteProtectChecked = false, bool writeProtectDevice = false, bool isFlashportFromCvnToTrk = false, bool isRestoreJob = false)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			global::ASK.Interface.ASK_COMMS_OP a_;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)485556229;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_116;
				case 2:
					goto IL_174;
				case 3:
					goto IL_FB;
				case 4:
					switch (transportPreference)
					{
					case 0:
						a_ = global::ASK.Interface.ASK_COMMS_OP.USB_CLONE;
						num2 = (short)1113128961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
					{
						a_ = global::ASK.Interface.ASK_COMMS_OP.OTAP_CLONE;
						num2 = (short)1882783744;
						short num3 = num2;
						num2 = (short)1544224771;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						a_ = global::ASK.Interface.ASK_COMMS_OP.OTAP_CLONE;
						num2 = (short)1462632450;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_176;
					default:
						num2 = (short)1221066752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 5:
					goto IL_12F;
				}
				goto IL_28;
			}
			IL_116:
			goto IL_176;
			IL_12F:
			num2 = (short)1514209281;
			if (num2 != 0)
			{
			}
			IL_174:
			goto IL_176;
			IL_28:
			num2 = (short)1678199934;
			short num4 = num2;
			num2 = (short)2134723710;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FB:
				break;
			default:
			{
				num2 = (short)807010304;
				if (num2 != 0)
				{
				}
				a_ = global::ASK.Interface.ASK_COMMS_OP.USB_CLONE;
				num2 = (short)2026176516;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			IL_176:
			global::ASKLib.a a = new global::ASKLib.a(radSecData, cpgSecurityData, a_, writeProtectDevice, isRMCWriteProtectChecked, isFlashportFromCvnToTrk, isRestoreJob);
			bool result = a.b(out stsMsg);
			bUpdated = a.g();
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000041A0 File Offset: 0x000023A0
		public bool ValidateAstroASKRequirement(int ownerAdvKeyType, int ownerId, global::ASK.Interface.ProtectionOption protectionOptn, bool askRequired, out string stsMsg)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			bool flag;
			global::ASK.Interface.ISystemKeyManager instance;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_73;
				case 1:
					stsMsg = global::Motorola.CommonCPS.ResourceRepository.Resources.Unlimited_Owner_System_Advanced_Key_must_be_loaded;
					num2 = (short)1136525317;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (askRequired)
					{
						num2 = (short)170524679;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 3:
					return flag;
				case 4:
					num2 = (short)2116878338;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return flag;
				case 6:
				{
					if (flag)
					{
						return flag;
					}
					num2 = (short)1933106594;
					short num3 = num2;
					num2 = (short)1020911010;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_163;
					default:
						num2 = (short)62390273;
						if (num2 != 0)
						{
						}
						num2 = (short)428736512;
						if (num2 != 0)
						{
						}
						num2 = (short)276955137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					goto IL_163;
				case 8:
					if (instance == null)
					{
						num2 = (short)1622999040;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1459945481;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (protectionOptn == global::ASK.Interface.ProtectionOption.HARDWARE)
					{
						num2 = (short)1453588484;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					stsMsg = global::Motorola.CommonCPS.ResourceRepository.Resources.Operation_not_applicable_for_codeplug;
					num2 = (short)51314691;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_163:
				flag = instance.IsUnLimitedASKLoaded(ownerId, (global::ASK.Interface.KeyType)ownerAdvKeyType, false);
				num2 = (short)484048902;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_73:
			num2 = (short)521863168;
			short num4 = num2;
			throw new global::System.NullReferenceException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMSU_Error_System_Key_Manager);
			IL_38:
			flag = false;
			stsMsg = null;
			instance = global::ASKLib.SystemKeyManager.GetInstance();
			num2 = (short)1628438536;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000043CC File Offset: 0x000025CC
		public bool ValidateAstroIndividualId(global::ASK.Interface.IAskSystem radioSys, bool askRequired, out string stsMsg)
		{
			short num = (short)114753536;
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
				bool result;
				global::ASK.Interface.ISystemKeyManager instance;
				for (;;)
				{
					IL_29:
					global::ASK.Interface.KeyType keyType;
					int num3;
					switch (num2)
					{
					case 0:
						stsMsg = global::Motorola.CommonCPS.ResourceRepository.Resources.Operation_not_applicable_for_codeplug;
						num = (short)772341773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_F8;
					case 2:
						result = true;
						num = (short)1084293128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (radioSys.CoverageType == global::ASK.Interface.AskTrkSysCoverageType.IntraWACNRoaming)
						{
							num = (short)1535705095;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						keyType = global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY;
						num3 = radioSys.SystemId;
						num = (short)859030106;
						short num4 = num;
						num = (short)1922679386;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F8;
						default:
							num = (short)1095696384;
							if (num != 0)
							{
							}
							num = (short)512294918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)1016791041;
						if (num != 0)
						{
						}
						if (instance.IsSystemKeyLoaded(num3, keyType, askRequired))
						{
							num = (short)1796931593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						stsMsg = global::Motorola.CommonCPS.ResourceRepository.Resources.System_Key_must_be_loaded_for_the_System;
						num = (short)1975123978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_DB;
					case 6:
						goto IL_298;
					case 7:
						keyType = global::ASK.Interface.KeyType.ADVANCED_WACN_KEY;
						num3 = radioSys.WacnId;
						num = (short)1448869902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						return result;
					case 9:
						num = (short)394002433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return result;
					case 11:
						return result;
					case 12:
						if (radioSys.SystemType != global::ASK.Interface.AskSystemType.TRUNCKING)
						{
							num = (short)1543241728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = 0;
						keyType = global::ASK.Interface.KeyType.UNDEFINED_KEY;
						num = (short)1195376643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						return result;
					case 14:
						goto IL_298;
					case 15:
					{
						num = (short)284033024;
						short num5 = num;
						if (instance == null)
						{
							num = (short)1149829125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1805254668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_70;
					IL_F8:
					if (instance.IsRangeValueValid(global::ASK.Interface.AccessElementIDType.TRK_SYS_GEN_UNIT_ID_ELEMENT, keyType, num3, radioSys.RadioId, askRequired))
					{
						num = (short)549781506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					stsMsg = global::Motorola.CommonCPS.ResourceRepository.Resources.Loaded_System_Key_does_not_grant_access_to_Unit_ID_value;
					num = (short)1330315275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_298:
					num = (short)743440388;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DB:
				throw new global::System.NullReferenceException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMSU_Error_System_Key_Manager);
				IL_70:
				result = false;
				stsMsg = null;
				instance = global::ASKLib.SystemKeyManager.GetInstance();
				num = (short)1810759695;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}
	}
}
