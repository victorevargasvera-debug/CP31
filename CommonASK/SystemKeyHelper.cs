using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ASK.Interface;
using ASKLib;

namespace CommonASK
{
	// Token: 0x0200000B RID: 11
	public class SystemKeyHelper
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00005BAC File Offset: 0x00003DAC
		public static global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> GetSystemKeyList()
		{
			global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>();
			global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = global::CommonASK.SystemKeyManagerFactory.Instance.GetSystemKeyManager().LoadedUserSystemKeys.GetEnumerator();
			short num;
			try
			{
				num = (short)797629526;
				short num2 = num;
				num = (short)1052367958;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_7C:
					switch (0)
					{
					case 0:
						goto IL_A0;
					}
					break;
				default:
					num = (short)599457792;
					if (num != 0)
					{
					}
					num = (short)1010630660;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					IL_86:
					switch (num3)
					{
					case 0:
						goto IL_113;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)686620674;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ASK.Interface.ISystemKeyData item = enumerator.Current;
						observableCollection.Add(item);
						num = (short)301531139;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)295370752;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_7C;
					}
					break;
				}
				goto IL_C6;
				IL_113:
				goto IL_17D;
				IL_A0:
				IL_C6:
				num = (short)265682945;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_86;
			}
			finally
			{
				num = (short)345767938;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1546059777;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_17A;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_145;
						}
						continue;
					}
					IL_145:
					if (enumerator == null)
					{
						break;
					}
					num = (short)2070544384;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_17A:;
			}
			IL_17D:
			num = (short)1856700416;
			short num4 = num;
			num = (short)1614544897;
			if (num != 0)
			{
			}
			return observableCollection;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005D98 File Offset: 0x00003F98
		public static bool IsSystemKeyLoaded(int dwSystemId, global::ASK.Interface.KeyType uKeyType, bool bAskOnly)
		{
			short num = (short)858040828;
			short num2 = num;
			num = (short)1335470588;
			switch (num2 == num)
			{
			}
			num = (short)23724033;
			if (num != 0)
			{
			}
			num = (short)2086797312;
			if (num != 0)
			{
			}
			num = (short)1393229824;
			short num3 = num;
			return global::CommonASK.SystemKeyManagerFactory.Instance.GetSystemKeyManager().IsSystemKeyLoaded(dwSystemId, uKeyType, bAskOnly);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005E54 File Offset: 0x00004054
		public static bool IsRangeValueValid(global::ASK.Interface.AccessElementIDType id, global::ASK.Interface.KeyType type, int sysId, int value, bool bAskOnly)
		{
			short num = (short)1984614416;
			short num2 = num;
			num = (short)1209389072;
			switch (num2 == num)
			{
			}
			num = (short)1503264768;
			if (num != 0)
			{
			}
			num = (short)625737729;
			if (num != 0)
			{
			}
			num = (short)478085120;
			short num3 = num;
			return global::CommonASK.SystemKeyManagerFactory.Instance.GetSystemKeyManager().IsRangeValueValid(id, type, sysId, value, bAskOnly);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00005F14 File Offset: 0x00004114
		public static global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> GetSysKeysFromLoadedAndAttachedASKs()
		{
			short num = (short)1183541528;
			short num2 = num;
			num = (short)830236952;
			switch (num2 == num)
			{
			}
			num = (short)1119944705;
			if (num != 0)
			{
			}
			num = (short)622264320;
			if (num != 0)
			{
			}
			num = (short)1853423616;
			short num3 = num;
			return global::CommonASK.SystemKeyHelper.GetSystemKeyList();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00005FC0 File Offset: 0x000041C0
		public static global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> LoadedUserSystemKeys()
		{
			short num = (short)893178519;
			short num2 = num;
			num = (short)1570230935;
			switch (num2 == num)
			{
			}
			num = (short)10551297;
			if (num != 0)
			{
			}
			num = (short)1838219264;
			if (num != 0)
			{
			}
			num = (short)1095892992;
			short num3 = num;
			return global::CommonASK.SystemKeyHelper.GetSystemKeyList();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00006070 File Offset: 0x00004270
		public static global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> LoadedASKs()
		{
			short num = (short)1626797587;
			short num2 = num;
			num = (short)60421651;
			switch (num2 == num)
			{
			}
			num = (short)384696321;
			if (num != 0)
			{
			}
			num = (short)448987136;
			if (num != 0)
			{
			}
			num = (short)455213056;
			short num3 = num;
			return global::CommonASK.SystemKeyHelper.GetSystemKeyList();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000611C File Offset: 0x0000431C
		public static global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> GetLoadedASKWithDefault()
		{
			short num = (short)815354688;
			short num2 = num;
			num = (short)726684480;
			switch (num2 == num)
			{
			}
			num = (short)1489174529;
			if (num != 0)
			{
			}
			num = (short)1226244096;
			if (num != 0)
			{
			}
			num = (short)955908096;
			short num3 = num;
			return global::CommonASK.SystemKeyHelper.GetSystemKeyList();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000061C8 File Offset: 0x000043C8
		public static global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> GetLoadedASKWithoutDefault()
		{
			short num = (short)1435902883;
			short num2 = num;
			num = (short)1435313059;
			switch (num2 == num)
			{
			}
			num = (short)2033713152;
			if (num != 0)
			{
			}
			num = (short)1563033601;
			if (num != 0)
			{
			}
			num = (short)1023213568;
			short num3 = num;
			return new global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>(global::CommonASK.SystemKeyHelper.GetSystemKeyList().Where(new global::System.Func<global::ASK.Interface.ISystemKeyData, bool>(global::CommonASK.SystemKeyHelper.<>c.<>9.a)).ToList<global::ASK.Interface.ISystemKeyData>());
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000062A8 File Offset: 0x000044A8
		public static bool CheckASKComabilityWhenRadioApplyConfiguration(bool AllowLegacySoftwareKey, bool RadWideGeneralASKRequired_A37152, bool QA01749LegacySWEnable, bool QA01648ASKEnable)
		{
			short num = (short)289710934;
			short num2 = num;
			num = (short)1681761110;
			switch (num2 == num)
			{
			default:
			{
				num = (short)432865280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1234173953;
			if (num != 0)
			{
			}
			num = (short)231604224;
			if (num != 0)
			{
			}
			return global::CommonASK.SystemKeyHelper.a(AllowLegacySoftwareKey, RadWideGeneralASKRequired_A37152, QA01749LegacySWEnable, QA01648ASKEnable);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000635C File Offset: 0x0000455C
		public static bool CheckASKRuleWhenScheduleWriteJob(global::ASK.Interface.KeyType keyType, int SystemId, bool AllowLegacySoftwareKey, bool RadWideGeneralASKRequired_A37152, bool QA01749LegacySWEnable_A37151, bool QA01648ASKEnable_A37150, string CurrentVersion, bool RadioInhibitValue)
		{
			int a_ = 11;
			short num = (short)1965498041;
			short num2 = num;
			num = (short)1110974137;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1659305984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)164429825;
			if (num != 0)
			{
			}
			num = (short)2086076416;
			if (num != 0)
			{
			}
			bool flag = global::CommonASK.SystemKeyHelper.a(AllowLegacySoftwareKey, RadWideGeneralASKRequired_A37152, QA01749LegacySWEnable_A37151, QA01648ASKEnable_A37150);
			global::CommonASK.SystemKeyHelper.CaculatebASKOnly(true, AllowLegacySoftwareKey, RadWideGeneralASKRequired_A37152, QA01648ASKEnable_A37150);
			bool flag2 = true;
			if (CurrentVersion == global::CommonASK.SystemKeyHelper.b("ᘦᨨ", a_))
			{
				flag2 = global::CommonASK.SystemKeyHelper.ValidateRadioInhibit(RadioInhibitValue, QA01648ASKEnable_A37150, QA01749LegacySWEnable_A37151, RadWideGeneralASKRequired_A37152, SystemId, keyType);
			}
			return flag && flag2;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00006454 File Offset: 0x00004654
		private static bool a(bool A_0, bool A_1, bool A_2, bool A_3)
		{
			short num = (short)1652817933;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_1)
					{
						num = (short)427294739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_94;
				case 1:
					num = (short)695730182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (!A_2)
					{
						num = (short)55902212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EE;
				case 3:
					return true;
				case 4:
					return true;
				case 5:
					num = (short)553713681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (A_2)
					{
						num = (short)873398284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 7:
					if (!A_2)
					{
						num = (short)256966657;
						if (num != 0)
						{
						}
						num = (short)802619406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_94;
				case 8:
					if (!A_1)
					{
						num = (short)1983774723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 9:
					num = (short)161742855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)2045771778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (A_3)
					{
						num = (short)375324682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EE;
				case 12:
					return true;
				case 13:
					switch (0)
					{
					case 0:
						goto IL_74;
					}
					continue;
				case 14:
					goto IL_2F9;
				case 15:
					if (!A_1)
					{
						num = (short)33161216;
						short num3 = num;
						num = (short)821035013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 16:
					if (!A_3)
					{
						num = (short)1884618761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_94;
				case 17:
					if (!A_3)
					{
						num = (short)1209663489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 18:
					num = (short)1186398216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)319488016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_74:
				if (A_0)
				{
					num = (short)270925842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1117454347;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_94:
				num = (short)579731471;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EE:
				num = (short)781123584;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_2F9:
			num = (short)568806750;
			short num4 = num;
			num = (short)839732574;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
				num = (short)700514304;
				if (num != 0)
				{
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000679C File Offset: 0x0000499C
		public static bool CheckAllowLegacySoftwareKeyWithOptionAccessor(bool AllowLegacySoftwareKey, bool RadWideGeneralASKRequired_A37152, bool QA01749LegacySWEnable, bool QA01648ASKEnable)
		{
			short num = (short)233726488;
			short num2 = num;
			num = (short)118972952;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1690042368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)186318849;
			if (num != 0)
			{
			}
			num = (short)1614413824;
			if (num != 0)
			{
			}
			return global::CommonASK.SystemKeyHelper.a(AllowLegacySoftwareKey, RadWideGeneralASKRequired_A37152, QA01749LegacySWEnable, QA01648ASKEnable);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000684C File Offset: 0x00004A4C
		public static bool CaculatebASKOnly(bool IsUnknownMVO, bool AllowLegacySoftwareKey, bool RadWideGeneralASKRequired_A37152, bool QA01648ASKEnable)
		{
			short num = (short)617676806;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)172949507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_10B;
				case 2:
					goto IL_C7;
				case 3:
					num = (short)1111031809;
					if (num != 0)
					{
					}
					if (RadWideGeneralASKRequired_A37152)
					{
						num = (short)271122437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					num = (short)33095687;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)2012676098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 7:
					if (AllowLegacySoftwareKey)
					{
						num = (short)1608843264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_45:
				num = (short)413714452;
				short num3 = num;
				num = (short)2061092884;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_C7:
					if (!QA01648ASKEnable)
					{
						return false;
					}
					num = (short)50593792;
					short num4 = num;
					num = (short)572456961;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)875298816;
					if (num != 0)
					{
					}
					if (!IsUnknownMVO)
					{
						goto IL_1A2;
					}
					num = (short)1890451460;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return true;
			IL_10B:
			return true;
			IL_1A2:
			return !AllowLegacySoftwareKey;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006A00 File Offset: 0x00004C00
		public static bool ValidateRadioInhibit(bool radioInhibitValue, bool QA01648ASKEnable_A37150, bool QA01749LegacySWEnable_A37151, bool ASKRequired_A37152, int systemId, global::ASK.Interface.KeyType keyType)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			bool flag;
			short num2;
			bool flag2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					flag = global::CommonASK.SystemKeyHelper.IsSystemKeyLoaded(systemId, keyType, false);
					num2 = (short)767754243;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1102587501;
					short num3 = num2;
					num2 = (short)1325409901;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_244;
					default:
						num2 = (short)1417674752;
						if (num2 != 0)
						{
						}
						num2 = (short)652214282;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					num2 = (short)352714757;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_A2;
				case 4:
					goto IL_176;
				case 5:
					goto IL_244;
				case 6:
					goto IL_14E;
				case 7:
					if (QA01749LegacySWEnable_A37151)
					{
						num2 = (short)1104609292;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_268;
				case 8:
					flag2 = global::CommonASK.SystemKeyHelper.IsSystemKeyLoaded(systemId, keyType, false);
					num2 = (short)2012938246;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (!QA01749LegacySWEnable_A37151)
					{
						num2 = (short)509476866;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_153;
				case 10:
					if (!ASKRequired_A37152)
					{
						num2 = (short)1429078016;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					flag = global::CommonASK.SystemKeyHelper.IsSystemKeyLoaded(systemId, keyType, true);
					num2 = (short)678559755;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_1D8;
				case 12:
					num2 = (short)2132082701;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (!QA01648ASKEnable_A37150)
					{
						num2 = (short)1812529160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_268;
				}
				goto IL_48;
				IL_153:
				flag = global::CommonASK.SystemKeyHelper.IsSystemKeyLoaded(systemId, keyType, true);
				num2 = (short)1421410308;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_244:
				if (QA01648ASKEnable_A37150)
				{
					num2 = (short)1936195585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_153;
				IL_268:
				num2 = (short)1947861001;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_A2:
			IL_14E:
			IL_176:
			goto IL_29F;
			IL_1D8:
			num2 = (short)1622999041;
			if (num2 != 0)
			{
			}
			num2 = (short)1447690240;
			short num4 = num2;
			IL_29F:
			return radioInhibitValue || flag2 || flag;
			IL_48:
			flag2 = false;
			flag = false;
			num2 = (short)923533319;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00006CB4 File Offset: 0x00004EB4
		public static void SetTestMode(bool isTestMode)
		{
			short num = (short)1155072001;
			if (num != 0)
			{
			}
			num = (short)1407123456;
			short num2 = num;
			num = (short)1416588228;
			short num3 = num;
			num = (short)709585860;
			switch (num3 == num)
			{
			}
			num = (short)1080557568;
			if (num != 0)
			{
			}
			global::CommonASK.SystemKeyManagerFactory.Instance.SetTestMode(isTestMode);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006D68 File Offset: 0x00004F68
		public static bool GetTestMode()
		{
			short num = (short)2011487509;
			short num2 = num;
			num = (short)2083118357;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1729953792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2042953729;
			if (num != 0)
			{
			}
			num = (short)798294016;
			if (num != 0)
			{
			}
			return global::CommonASK.SystemKeyManagerFactory.Instance.GetTestMode();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00006E18 File Offset: 0x00005018
		public static global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> AddMockKeyWithLimitedKeyForTestcase(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::ASK.Interface.KeyType, int>> inputKeyList, bool otapEnabled, bool isWriteProtected)
		{
			short num = (short)356270533;
			short num2 = num;
			num = (short)408371653;
			switch (num2 == num)
			{
			default:
			{
				num = (short)548143104;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)980811777;
			if (num != 0)
			{
			}
			num = (short)2015494144;
			if (num != 0)
			{
			}
			return global::CommonASK.SystemKeyHelper.AddMockKeyForTestcase(inputKeyList, otapEnabled, isWriteProtected, global::ASK.Interface.KeyAccessLevelType.LIMITED_ACC);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00006EC8 File Offset: 0x000050C8
		public static global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> AddMockKeyForTestcase(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::ASK.Interface.KeyType, int>> inputKeyList, bool otapEnabled, bool isWriteProtected, global::ASK.Interface.KeyAccessLevelType keyAccessLevelType = global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
		{
			int a_ = 6;
			short num = (short)1225326592;
			switch (num)
			{
			default:
			{
				num = (short)1159987200;
				short num2 = num;
				num = (short)536084481;
				if (num != 0)
				{
				}
				global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>();
				global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
				global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = global::CommonASK.SystemKeyHelper.GetSystemKeyList().GetEnumerator();
				try
				{
					num = (short)872611845;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::ASK.Interface.ISystemKeyData systemKeyData;
							observableCollection.Add(systemKeyData);
							list.Add(systemKeyData.SystemID);
							num = (short)1941045250;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)815529988;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::ASK.Interface.ISystemKeyData systemKeyData;
							if (!list.Contains(systemKeyData.SystemID))
							{
								num = (short)1468399616;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_301;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_23F;
							}
							continue;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1959133185;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASK.Interface.ISystemKeyData systemKeyData = enumerator.Current;
							num = (short)1202716675;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_283:
						num = (short)1962999814;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_23F:
						goto IL_283;
					}
					IL_301:
					goto IL_1EF;
				}
				finally
				{
					num = (short)937033729;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_3C1;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_339;
							}
							continue;
						case 2:
							enumerator.Dispose();
							goto IL_3A7;
						}
						IL_339:
						num = (short)1277186830;
						short num4 = num;
						num = (short)2129154830;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_3A7:
							num = (short)1248657408;
							num3 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)793444352;
							if (num != 0)
							{
							}
							if (enumerator == null)
							{
								goto IL_3C3;
							}
							num = (short)18087938;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_3C1:
					IL_3C3:;
				}
				goto IL_3C4;
				for (;;)
				{
					IL_1EF:
					using (global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::ASK.Interface.KeyType, int>>.Enumerator enumerator2 = inputKeyList.GetEnumerator())
					{
						num = (short)1078067205;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								num = (short)1070268420;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								global::System.Collections.Generic.KeyValuePair<global::ASK.Interface.KeyType, int> keyValuePair;
								if (!list.Contains(keyValuePair.Value))
								{
									num = (short)1097072642;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
							{
								global::System.Collections.Generic.KeyValuePair<global::ASK.Interface.KeyType, int> keyValuePair;
								global::ASK.Interface.KeyType key = keyValuePair.Key;
								global::CommonASK.MockSystemKeyData item = new global::CommonASK.MockSystemKeyData(keyAccessLevelType, global::CommonASK.SystemKeyHelper.b("ሡᐣᘥᠧᨩᰫḭ/ȱгص࠷ਹ఻฽瀿", a_), otapEnabled, global::ASK.Interface.KeySource.HARDWARE, keyValuePair.Value, key, global::CommonASK.SystemKeyHelper.b("圡儣伥䰧ᨩ", a_), isWriteProtected);
								observableCollection.Add(item);
								num = (short)1125908486;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)1073217536;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::ASK.Interface.KeyType, int> keyValuePair = enumerator2.Current;
								num = (short)1224736769;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_1DC;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_D7;
								}
								continue;
							}
							IL_D9:
							num = (short)118685699;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_D7:
							goto IL_D9;
						}
						IL_1DC:
						break;
					}
				}
				IL_3C4:
				(global::CommonASK.SystemKeyManagerFactory.Instance.GetSystemKeyManager() as global::CommonASK.MockSystemKeyManager).LoadMockSystemKey(observableCollection);
				return observableCollection;
			}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000072E4 File Offset: 0x000054E4
		public static void DeleteAllKeysForTestcase()
		{
			int num;
			short num2;
			global::ASK.Interface.ISystemKeyManager systemKeyManager;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						num2 = (short)1329659904;
						short num3 = num2;
						num2 = (short)2070521794;
						short num4 = num2;
						num2 = (short)1869653954;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_27;
						default:
							num2 = (short)787218432;
							if (num2 != 0)
							{
							}
							num2 = (short)1632501761;
							if (num2 != 0)
							{
							}
							if (systemKeyManager is global::CommonASK.MockSystemKeyManager)
							{
								num2 = (short)64880642;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						break;
					}
					case 2:
						(systemKeyManager as global::CommonASK.MockSystemKeyManager).RemoveAllMockKeys();
						num2 = (short)911081472;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				return;
			}
			IL_1C:
			systemKeyManager = global::CommonASK.SystemKeyManagerFactory.Instance.GetSystemKeyManager();
			IL_27:
			num2 = (short)793575425;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007410 File Offset: 0x00005610
		public static bool IsUnLimitedASKLoaded(int systemId, global::ASK.Interface.KeyType keytype, bool bSearchWriteProtectOnly)
		{
			short num = (short)1993906318;
			short num2 = num;
			num = (short)2096273550;
			switch (num2 == num)
			{
			default:
			{
				num = (short)698220544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)76087297;
			if (num != 0)
			{
			}
			num = (short)2019033088;
			if (num != 0)
			{
			}
			return global::CommonASK.SystemKeyManagerFactory.Instance.GetSystemKeyManager().IsUnLimitedASKLoaded(systemId, keytype, bSearchWriteProtectOnly);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000074D0 File Offset: 0x000056D0
		public static bool IsRangeField(global::ASK.Interface.AccessElementIDType id)
		{
			short num = (short)1737311298;
			short num2 = num;
			num = (short)1013138498;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1029373952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1265696769;
			if (num != 0)
			{
			}
			num = (short)1722941440;
			if (num != 0)
			{
			}
			return global::CommonASK.SystemKeyManagerFactory.Instance.GetSystemKeyManager().IsRangeField(id);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007588 File Offset: 0x00005788
		public static bool IsFieldEditable(global::ASK.Interface.AccessElementIDType id, global::ASK.Interface.KeyType type, int sysId, bool bAskOnly)
		{
			short num = (short)1826093634;
			short num2 = num;
			num = (short)1391655490;
			switch (num2 == num)
			{
			default:
			{
				num = (short)762314752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)176226305;
			if (num != 0)
			{
			}
			num = (short)813891584;
			if (num != 0)
			{
			}
			return global::CommonASK.SystemKeyManagerFactory.Instance.GetSystemKeyManager().IsFieldEditable(id, type, sysId, bAskOnly);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007640 File Offset: 0x00005840
		public static bool IsWACNKeyLoaded(int wacnkeyid)
		{
			global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = global::CommonASK.SystemKeyHelper.GetSystemKeyList().GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)706215943;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)902168582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::ASK.Interface.ISystemKeyData systemKeyData;
						if (wacnkeyid == systemKeyData.SystemID)
						{
							num = (short)1965490180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)749469697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::ASK.Interface.ISystemKeyData systemKeyData;
						if (systemKeyData.Type == global::ASK.Interface.KeyType.ADVANCED_WACN_KEY)
						{
							num = (short)2137063426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						result = true;
						num = (short)1914306568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)302383104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ASK.Interface.ISystemKeyData systemKeyData = enumerator.Current;
						num = (short)1308557315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_168;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 8:
						goto IL_10F;
					}
					IL_80:
					num = (short)862453765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E:
					goto IL_80;
				}
				IL_10F:
				goto IL_223;
				IL_168:
				goto IL_0D;
			}
			finally
			{
				num = (short)510132225;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_220;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_19D;
						}
						continue;
					case 2:
						enumerator.Dispose();
						goto IL_209;
					}
					IL_19D:
					num = (short)1174134709;
					short num3 = num;
					num = (short)1566236597;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_209:
						num = (short)592314368;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1462697984;
						if (num != 0)
						{
						}
						if (enumerator == null)
						{
							goto IL_222;
						}
						num = (short)1373569026;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_220:
				IL_222:;
			}
			goto IL_223;
			IL_0D:
			num = (short)275906561;
			if (num != 0)
			{
			}
			return false;
			IL_223:
			num = (short)792461312;
			short num4 = num;
			return result;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000078B8 File Offset: 0x00005AB8
		public static bool CheckIfIsACK()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool result;
			global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> systemKeyList;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
				switch (num)
				{
				case 0:
					try
					{
						num2 = (short)358285317;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								num2 = (short)614858756;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								result = true;
								num2 = (short)1435828226;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_14F;
							case 3:
								if (!enumerator.MoveNext())
								{
									num2 = (short)613154816;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)1255014406;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								goto IL_16C;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_C4;
								}
								continue;
							case 6:
								if (enumerator.Current.Type == global::ASK.Interface.KeyType.ADVANCED_CONV_SYSTEM_KEY)
								{
									num2 = (short)1940783105;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							IL_C6:
							num2 = (short)1480196099;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_C4:
							goto IL_C6;
						}
						IL_14F:
						IL_16C:
						return result;
					}
					finally
					{
						num2 = (short)1169555457;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_224;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1A1;
								}
								continue;
							case 2:
								enumerator.Dispose();
								goto IL_20B;
							}
							IL_1A1:
							num2 = (short)1209713021;
							short num3 = num2;
							num2 = (short)1179304317;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_20B:
								num2 = (short)1459421184;
								num = (int)((global::System.IntPtr)num2);
								break;
							default:
								num2 = (short)1350172672;
								if (num2 != 0)
								{
								}
								if (enumerator == null)
								{
									goto IL_226;
								}
								num2 = (short)802684930;
								num = (int)((global::System.IntPtr)num2);
								break;
							}
						}
						IL_224:
						IL_226:;
					}
					goto IL_227;
				case 1:
					if (systemKeyList != null)
					{
						num2 = (short)485294080;
						short num4 = num2;
						num2 = (short)1826881538;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					goto IL_227;
				}
				goto IL_1C;
				IL_227:
				enumerator = systemKeyList.GetEnumerator();
				num2 = (short)2029780993;
				if (num2 != 0)
				{
				}
				num2 = (short)757268480;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_1C:
			result = false;
			systemKeyList = global::CommonASK.SystemKeyHelper.GetSystemKeyList();
			num2 = (short)2028142593;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007B48 File Offset: 0x00005D48
		public static bool CheckIfCustomerIDIsInACK(int customerID_hex)
		{
			short num = (short)1698889728;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				bool result;
				global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> systemKeyList;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
					switch (num2)
					{
					case 0:
						result = true;
						num = (short)257097733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1579220993;
						if (num != 0)
						{
						}
						try
						{
							num = (short)19333127;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1566900227;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ASK.Interface.ISystemKeyData systemKeyData = enumerator.Current;
									num = (short)2078146561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::ASK.Interface.ISystemKeyData systemKeyData;
									if (systemKeyData.Type == global::ASK.Interface.KeyType.ADVANCED_CONV_SYSTEM_KEY)
									{
										num = (short)1564868612;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::ASK.Interface.ISystemKeyData systemKeyData;
									if (customerID_hex == systemKeyData.SystemID)
									{
										num = (short)920190984;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)280231942;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)602669058;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_EA;
								case 6:
									goto IL_1C9;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_D0;
									}
									continue;
								case 8:
									result = true;
									num = (short)885653509;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_EF:
								num = (short)1352728576;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D0:
								goto IL_EF;
							}
							IL_EA:
							IL_1C9:
							return result;
						}
						finally
						{
							num = (short)711786497;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_280;
								case 1:
								{
									num = (short)472897786;
									short num3 = num;
									num = (short)360110330;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_26B;
									default:
										num = (short)17498112;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_24B;
										}
										continue;
									}
									break;
								}
								case 2:
									enumerator.Dispose();
									goto IL_26B;
								}
								IL_24B:
								if (enumerator != null)
								{
									num = (short)229244930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
								IL_26B:
								num = (short)1658388480;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_280:;
						}
						goto IL_283;
					case 2:
						if (systemKeyList != null)
						{
							num = (short)597950467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
						goto IL_283;
					case 4:
					{
						if (customerID_hex == 0)
						{
							num = (short)1955397632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2050162688;
						short num4 = num;
						num = (short)452657154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						return result;
					}
					goto IL_46;
					IL_283:
					enumerator = systemKeyList.GetEnumerator();
					num = (short)110297089;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_46:
				result = false;
				systemKeyList = global::CommonASK.SystemKeyHelper.GetSystemKeyList();
				num = (short)1682898948;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007EC0 File Offset: 0x000060C0
		public static bool ValidateAstroASKRequirement(int ownerAdvKeyType, int ownerId, global::ASK.Interface.ProtectionOption protectionOptn, bool askRequired, out string stsMsg)
		{
			short num = (short)1298316416;
			short num2 = num;
			num = (short)762625152;
			switch (num2 == num)
			{
			}
			num = (short)702676992;
			if (num != 0)
			{
			}
			num = (short)397279232;
			short num3 = num;
			num = (short)232456193;
			if (num != 0)
			{
			}
			stsMsg = string.Empty;
			return new global::ASKLib.RMCRadioAccessValidator().ValidateAstroASKRequirement(ownerAdvKeyType, ownerId, protectionOptn, askRequired, out stsMsg);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007F80 File Offset: 0x00006180
		public static bool ValidateAstroIndividualId(global::ASK.Interface.IAskSystem radioSys, bool askRequired, out string stsMsg)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (radioSys.CoverageType != global::ASK.Interface.AskTrkSysCoverageType.IntraWACNRoaming)
					{
						num2 = (short)2139226113;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D0;
				case 1:
				{
					num2 = (short)1780678656;
					short num3 = num2;
					num2 = (short)1507786756;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)434559377;
					short num4 = num2;
					num2 = (short)848812433;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num2 = (short)952107009;
						if (num2 != 0)
						{
						}
						num2 = (short)1665204224;
						if (num2 != 0)
						{
						}
						if (radioSys.CoverageType == global::ASK.Interface.AskTrkSysCoverageType.IntraWACNRoaming)
						{
							num2 = (short)1449328645;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_129;
					}
					break;
				}
				case 3:
					if (radioSys.WacnId != 1)
					{
						num2 = (short)302907398;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					if (radioSys.SystemId == 1)
					{
						num2 = (short)1335230471;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D0;
				case 5:
					num2 = (short)1141833731;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_129;
				case 7:
					return true;
				}
				goto IL_30;
				IL_129:
				num2 = (short)1683619840;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_1D0:
			global::ASKLib.RMCRadioAccessValidator rmcradioAccessValidator;
			return rmcradioAccessValidator.ValidateAstroIndividualId(radioSys, askRequired, out stsMsg);
			IL_30:
			stsMsg = string.Empty;
			rmcradioAccessValidator = new global::ASKLib.RMCRadioAccessValidator();
			num2 = (short)2103574530;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008168 File Offset: 0x00006368
		public static bool ValidateAstroRadioWrite(global::ASK.Interface.IRadioSecurityData radSecData, global::ASK.Interface.IRadioSecurityData cpgSecurityData, int transportPreference, out bool bUpdated, out string stsMsg, bool batchProgramming = false, bool writeProtectDevice = false, bool isFlashportFromCvnToTrk = false, bool isRestoreJob = false)
		{
			short num = (short)815838904;
			short num2 = num;
			num = (short)238073528;
			switch (num2 == num)
			{
			}
			num = (short)1592721409;
			if (num != 0)
			{
			}
			num = (short)639893504;
			short num3 = num;
			num = (short)324730880;
			if (num != 0)
			{
			}
			stsMsg = string.Empty;
			return new global::ASKLib.RMCRadioAccessValidator().ValidateAstroRadioWrite(radSecData, cpgSecurityData, transportPreference, out bUpdated, out stsMsg, batchProgramming, writeProtectDevice, isFlashportFromCvnToTrk, isRestoreJob);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00008244 File Offset: 0x00006444
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(224496284 + A_1) + (global::System.IntPtr)77 + (global::System.IntPtr)50);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}
	}
}
