using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using AcpUtility;
using ASK.Core;
using ASK.Interface;
using Motorola.CommonCPS.ResourceRepository;
using RMIBtnWrapperLib;
using RMKeyValidatorLib;

namespace ASKLib
{
	// Token: 0x0200000F RID: 15
	public class SystemKeyManager : global::ASK.Interface.ISystemKeyManager
	{
		// Token: 0x06000058 RID: 88 RVA: 0x0000BB6C File Offset: 0x00009D6C
		private SystemKeyManager()
		{
			int a_ = 2;
			base..ctor();
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
			this.b = new global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>();
			this.c = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::ASK.Interface.ISystemKeyData>(this.b);
			this.e = new global::ASK.Core.AccessRecord(global::Motorola.CommonCPS.ResourceRepository.Resources.Default_Unlimited, global::ASKLib.SystemKeyManager.b("뇖뿘뷚믜맞蟠藢菤臦迨跪诬觮韰闲鏴釶鿸鷺鯼駾最攂挄愆漈洊㨌椎眐甒猔焖缘級笜礞䜠䔢䌤䄦伨䴪䬬䤮地唲匴", a_), false, null);
			this.a();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000BBD4 File Offset: 0x00009DD4
		public static global::ASK.Interface.ISystemKeyManager GetInstance()
		{
			for (;;)
			{
				IL_00:
				short num = (short)2044329984;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)677773312;
					short num3 = num;
					switch (num2)
					{
					case 0:
					{
						num = (short)1203372033;
						if (num != 0)
						{
						}
						num = (short)1530421036;
						short num4 = num;
						num = (short)390094636;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1661272064;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_CC;
							}
							continue;
						}
						break;
					}
					case 1:
						goto IL_108;
					case 2:
						global::ASKLib.SystemKeyManager.a = new global::ASKLib.SystemKeyManager();
						num = (short)1551171585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CC:
					if (global::ASKLib.SystemKeyManager.a != null)
					{
						goto IL_10A;
					}
					num = (short)1981546498;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_108:
			IL_10A:
			return global::ASKLib.SystemKeyManager.a;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000BCF0 File Offset: 0x00009EF0
		public int LoadUserKeys(global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> userSysKeyPermissions)
		{
			int a_ = 12;
			short num;
			for (;;)
			{
				num = (short)1758003200;
				short num2 = num;
				if (userSysKeyPermissions != null)
				{
					goto IL_C1;
				}
				num = (short)522321921;
				if (num != 0)
				{
				}
				num = (short)1910368955;
				short num3 = num;
				num = (short)858516155;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_95;
				}
			}
			IL_95:
			num = (short)164560896;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::ASKLib.SystemKeyManager.b("铠郢胤闦뫨鋪黬ꓮ铰諲ꗴ鋶诸雺铼賾爀樂樄椆稈", a_));
			IL_C1:
			this.b.Clear();
			this.a();
			return this.a(userSysKeyPermissions, false);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		public void AddUserKeys(global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> userSysKeyPermissions)
		{
			int a_ = 19;
			short num;
			for (;;)
			{
				num = (short)31326208;
				short num2 = num;
				if (userSysKeyPermissions != null)
				{
					goto IL_C1;
				}
				num = (short)1946982508;
				short num3 = num;
				num = (short)1627428972;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6D;
				}
			}
			IL_6D:
			num = (short)124911617;
			if (num != 0)
			{
			}
			num = (short)1244069888;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::ASKLib.SystemKeyManager.b("鷧駩觫鳭ꏯ诱蟳뷵鷷菹곻鯽狿漁洃甅笇按挋怍挏", a_));
			IL_C1:
			this.a(userSysKeyPermissions, true);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		public void ClearUserKeys()
		{
			short num = (short)1517223936;
			short num2 = num;
			num = (short)1113777365;
			short num3 = num;
			num = (short)847963349;
			switch (num3 == num)
			{
			}
			num = (short)1365901312;
			if (num != 0)
			{
			}
			num = (short)2024996865;
			if (num != 0)
			{
			}
			this.b.Clear();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000BF64 File Offset: 0x0000A164
		public void ClearNonDefaultUserKeys()
		{
			short num = (short)83951616;
			short num2 = num;
			num = (short)1908784489;
			short num3 = num;
			num = (short)1164426601;
			switch (num3 == num)
			{
			}
			num = (short)1877344257;
			if (num != 0)
			{
			}
			num = (short)657588224;
			if (num != 0)
			{
			}
			this.b.Clear();
			this.a();
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000C020 File Offset: 0x0000A220
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::ASK.Interface.ISystemKeyData> LoadedUserSystemKeys
		{
			get
			{
				short num = (short)1071185920;
				short num2 = num;
				num = (short)1606539282;
				short num3 = num;
				num = (short)1700517906;
				switch (num3 == num)
				{
				}
				num = (short)1157234689;
				if (num != 0)
				{
				}
				num = (short)1518141440;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::ASK.Interface.ISystemKeyData> LoadedASKs
		{
			get
			{
				short num = (short)411232157;
				short num2 = num;
				num = (short)1478813597;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_207;
				case 1:
					break;
				default:
				{
					num = (short)76152832;
					short num3 = num;
					break;
				}
				}
				num = (short)1572929537;
				if (num != 0)
				{
				}
				num = (short)1212809216;
				if (num != 0)
				{
				}
				global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>();
				global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = this.b.GetEnumerator();
				try
				{
					num = (short)2068381696;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_EF;
							}
							continue;
						case 2:
						{
							global::ASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Source != global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
							{
								num = (short)1745485828;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)727056390;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASKLib.SystemKeyData systemKeyData = (global::ASKLib.SystemKeyData)enumerator.Current;
							num = (short)1359740930;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::ASKLib.SystemKeyData systemKeyData;
							observableCollection.Add(systemKeyData);
							num = (short)638779393;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_19E;
						case 6:
							num = (short)2021916677;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_130:
						num = (short)720437251;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_EF:
						goto IL_130;
					}
					IL_19E:;
				}
				finally
				{
					num = (short)2017460224;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1D1;
							}
							continue;
						case 1:
							goto IL_204;
						case 2:
							enumerator.Dispose();
							num = (short)1499725825;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1D1:
						if (enumerator == null)
						{
							break;
						}
						num = (short)203030530;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_204:;
				}
				IL_207:
				return new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::ASK.Interface.ISystemKeyData>(observableCollection);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000C2FC File Offset: 0x0000A4FC
		public bool IsSystemKeyLoaded(int systemId, global::ASK.Interface.KeyType keyType, bool bAskOnly)
		{
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = this.b.GetEnumerator();
			short num;
			try
			{
				num = (short)20054028;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Type == keyType)
						{
							num = (short)1883373574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)425000963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1077542913;
						if (num != 0)
						{
						}
						global::ASKLib.SystemKeyData systemKeyData = (global::ASKLib.SystemKeyData)enumerator.Current;
						num = (short)1753546765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.SystemID == systemId)
						{
							num = (short)342163463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						num = (short)401211403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Type == keyType)
						{
							num = (short)2047868945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_1E8;
					case 6:
						num = (short)1868496911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1411055620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)76873742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						result = true;
						num = (short)210436101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_D8;
					case 11:
						goto IL_2C0;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 13:
						if (bAskOnly)
						{
							num = (short)651296776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1165230082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.SystemID == systemId)
						{
							num = (short)2068250640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Source != global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
						{
							num = (short)2007760905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
						num = (short)1881014272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						result = true;
						num = (short)163643402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_18D:
					num = (short)92209153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7C:
					goto IL_18D;
				}
				IL_D8:
				IL_1E8:
				IL_2C0:;
			}
			finally
			{
				num = (short)505282561;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_37D;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_2F6;
						}
						continue;
					case 2:
					{
						num = (short)111098543;
						short num3 = num;
						num = (short)1676884655;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1869676544;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)403636224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_2F6:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1746862082;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_37D:;
			}
			num = (short)89128960;
			short num4 = num;
			return result;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000C6D0 File Offset: 0x0000A8D0
		public bool IsUnLimitedASKLoaded(int sysId, global::ASK.Interface.KeyType type, bool bSearchWriteProtectOnly)
		{
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = this.b.GetEnumerator();
			short num;
			try
			{
				num = (short)341966868;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)283836432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ASKLib.SystemKeyData systemKeyData = (global::ASKLib.SystemKeyData)enumerator.Current;
						num = (short)415694862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.AccessLevelType == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
						{
							num = (short)1313013766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)1057554450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_272;
					case 4:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.AccessLevelType != global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
						{
							num = (short)1623523337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_258;
					}
					case 5:
						goto IL_353;
					case 6:
						result = true;
						num = (short)938868741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_3AF;
					case 8:
						num = (short)1852112900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)35454991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1189937153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Source != global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
						{
							num = (short)513474570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Type == type)
						{
							num = (short)1489305624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Source != global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
						{
							num = (short)564002824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						if (bSearchWriteProtectOnly)
						{
							num = (short)397541378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)461963289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.AccessLevelType == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
						{
							num = (short)1381302289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
						num = (short)745144327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_258;
					case 18:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.SystemID == sysId)
						{
							num = (short)595066901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 19:
						num = (short)1119223831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						switch (0)
						{
						case 0:
							goto IL_9D;
						}
						continue;
					case 21:
						num = (short)1866268684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)1691418637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Type == type)
						{
							num = (short)714866710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 24:
						num = (short)2081882123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.SystemID == sysId)
						{
							num = (short)1934426131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_19C:
					num = (short)676986880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9D:
					goto IL_19C;
					IL_258:
					result = true;
					num = (short)1117650947;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_272:
				IL_353:
				IL_3AF:;
			}
			finally
			{
				num = (short)775618561;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_490;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3E4;
						}
						continue;
					case 2:
					{
						num = (short)436188629;
						short num3 = num;
						num = (short)317502933;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)999555072;
							if (num != 0)
							{
							}
							num = (short)1718484993;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)2109014016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_3E4:
					if (enumerator == null)
					{
						break;
					}
					num = (short)2033844226;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_490:;
			}
			num = (short)1219756032;
			short num4 = num;
			return result;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		public bool IsAnyUnLimitedASKLoaded()
		{
			short num = (short)1526333441;
			if (num != 0)
			{
			}
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = this.b.GetEnumerator();
			try
			{
				num = (short)1682046983;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)952565771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1271201798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ASKLib.SystemKeyData systemKeyData = (global::ASKLib.SystemKeyData)enumerator.Current;
						num = (short)671547404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_168;
					case 3:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.AccessLevelType == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
						{
							num = (short)702021637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_1FB;
					case 5:
						goto IL_14F;
					case 6:
						num = (short)1712717828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					case 8:
						num = (short)1752236042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)335085571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.AccessLevelType != global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
						{
							num = (short)190119945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14F;
					}
					case 11:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Source != global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
						{
							num = (short)829489160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.SystemID != 1)
						{
							num = (short)623640576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_C9:
					num = (short)1412300801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_90:
					goto IL_C9;
					IL_14F:
					result = true;
					num = (short)296353794;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_168:
				IL_1FB:;
			}
			finally
			{
				num = (short)847446017;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_2B5;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_232;
						}
						continue;
					case 2:
					{
						num = (short)452912432;
						short num3 = num;
						num = (short)924706096;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)488833024;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)460062720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_232:
					if (enumerator == null)
					{
						break;
					}
					num = (short)997261314;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2B5:;
			}
			num = (short)320339968;
			short num4 = num;
			return result;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000CEC4 File Offset: 0x0000B0C4
		public bool IsFieldEditable(global::ASK.Interface.AccessElementIDType id, global::ASK.Interface.KeyType type, int sysId, bool bAskOnly)
		{
			short num = (short)103917111;
			short num2 = num;
			num = (short)2144970295;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2003435521;
				if (num != 0)
				{
				}
				num = (short)2010513408;
				short num3 = num;
				num = (short)2059927552;
				if (num != 0)
				{
				}
				num = (short)397803520;
				switch (num)
				{
				}
				break;
			}
			}
			bool result = false;
			bool flag = false;
			global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = this.b.GetEnumerator();
			try
			{
				num = (short)2121203729;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)174129160;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_3FB;
					case 2:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Type == type)
						{
							num = (short)745930773;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_213;
					}
					case 3:
						if (flag)
						{
							num = (short)1643118605;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 4:
						goto IL_32B;
					case 5:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Source != global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
						{
							num = (short)1412300812;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_213;
					}
					case 6:
						flag = true;
						num = (short)1458962441;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_413;
					case 8:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.SystemID == sysId)
						{
							num = (short)1582759954;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_213;
					}
					case 9:
						goto IL_213;
					case 10:
						if (bAskOnly)
						{
							num = (short)1603076096;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1650655252;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_213;
					case 12:
						flag = true;
						num = (short)522780683;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						global::ASK.Core.AccessRecord accessLevel = systemKeyData.AccessLevel;
						num = (short)1070137358;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::ASK.Core.AccessRecord accessLevel;
						if (accessLevel != null)
						{
							num = (short)1830617103;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FB;
					}
					case 15:
					{
						global::ASK.Core.AccessRecord accessLevel;
						result = accessLevel.IsAccessElementEnabled(id);
						num = (short)529727492;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Type == type)
						{
							num = (short)1259601926;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_213;
					}
					case 17:
						switch (0)
						{
						case 0:
							goto IL_14B;
						}
						continue;
					case 18:
						num = (short)348389378;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1087635472;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.SystemID == sysId)
						{
							num = (short)196411411;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_213;
					}
					case 21:
						num = (short)1517944837;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)531628033;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ASKLib.SystemKeyData systemKeyData = (global::ASKLib.SystemKeyData)enumerator.Current;
						num = (short)399835146;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_14B;
					IL_213:
					num = (short)1392508931;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_24C:
					num = (short)1284309014;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_14B:
					goto IL_24C;
					IL_3FB:
					num = (short)13238279;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_32B:
				IL_413:;
			}
			finally
			{
				num = (short)2056585216;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_448;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)1545535490;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_47E;
					}
					IL_448:
					if (enumerator == null)
					{
						break;
					}
					num = (short)2084765697;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_47E:;
			}
			return result;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000D370 File Offset: 0x0000B570
		public bool IsRangeValueValid(global::ASK.Interface.AccessElementIDType id, global::ASK.Interface.KeyType type, int sysId, int value, bool bAskOnly)
		{
			short num = (short)981332872;
			short num2 = num;
			num = (short)1649537928;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2004680705;
				if (num != 0)
				{
				}
				num = (short)1912864768;
				short num3 = num;
				num = (short)1609236480;
				if (num != 0)
				{
				}
				num = (short)1842741248;
				switch (num)
				{
				}
				break;
			}
			}
			bool result = false;
			bool flag = false;
			global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = this.b.GetEnumerator();
			try
			{
				num = (short)1808597009;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)1289027600;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						global::ASK.Core.AccessRecord accessLevel = systemKeyData.AccessLevel;
						num = (short)1896284180;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						flag = true;
						num = (short)1750728725;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_334;
					case 4:
						goto IL_419;
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1658585107;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ASKLib.SystemKeyData systemKeyData = (global::ASKLib.SystemKeyData)enumerator.Current;
						num = (short)2001797142;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Type == type)
						{
							num = (short)1641807872;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					}
					case 7:
						flag = true;
						num = (short)1778057224;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_217;
					case 9:
					{
						global::ASK.Core.AccessRecord accessLevel;
						result = accessLevel.IsRangeValueValid(id, value);
						num = (short)484114435;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Type == type)
						{
							num = (short)422051847;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					}
					case 11:
						num = (short)1564082182;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1930297354;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (flag)
						{
							num = (short)1687617537;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 14:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.SystemID == sysId)
						{
							num = (short)1955397644;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					}
					case 15:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.SystemID == sysId)
						{
							num = (short)538837003;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					}
					case 16:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Source != global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
						{
							num = (short)1787101186;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					}
					case 17:
						switch (0)
						{
						case 0:
							goto IL_14F;
						}
						continue;
					case 18:
						num = (short)1117782031;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_400;
					case 20:
					{
						global::ASK.Core.AccessRecord accessLevel;
						if (accessLevel != null)
						{
							num = (short)235995145;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_400;
					}
					case 21:
						goto IL_217;
					case 22:
						if (bAskOnly)
						{
							num = (short)1513881618;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1282998286;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14F;
					IL_217:
					num = (short)1269891085;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_250:
					num = (short)1457455109;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_14F:
					goto IL_250;
					IL_400:
					num = (short)839712772;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_334:
				IL_419:;
			}
			finally
			{
				num = (short)583598080;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_44E;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)756154370;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_485;
					}
					IL_44E:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1456799745;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_485:;
			}
			return result;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000D824 File Offset: 0x0000BA24
		public bool IsRangeField(global::ASK.Interface.AccessElementIDType id)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
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
					if (global::ASK.Core.FeatureSchemaManager.GetAccessElement(id) is global::ASK.Core.AccessRangeField)
					{
						num2 = (short)810418177;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					goto IL_A5;
				case 2:
					return result;
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			num2 = (short)1940438377;
			short num3 = num2;
			num2 = (short)1929362793;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_A5:
				num2 = (short)898105344;
				short num4 = num2;
				result = true;
				num2 = (short)735510529;
				if (num2 != 0)
				{
				}
				num2 = (short)1088094210;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)45154304;
				if (num2 != 0)
				{
				}
				result = false;
				num2 = (short)1457913856;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000D944 File Offset: 0x0000BB44
		public global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> ReadHardwareKeys()
		{
			int a_ = 14;
			short num = (short)1009123328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)599523328;
				short num3 = num;
				num = (short)1710096385;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> list = new global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData>();
				global::System.Collections.ObjectModel.Collection<global::ASK.Core.StatusMsg> collection = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.StatusMsg>();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_B2;
					}
					global::ASK.Core.KeyRecordSet keyRecordSet;
					global::RMIBtnWrapperLib.MultiBtnWrapper spIBtn;
					global::ASK.Core.AccessLevelDataRecordSet systemWideACLRecSet;
					bool flag;
					bool flag2;
					string str;
					for (;;)
					{
						IL_8F:
						switch (num2)
						{
						case 0:
							goto IL_4F1;
						case 1:
							goto IL_558;
						case 2:
						{
							global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyRecord> enumerator = keyRecordSet.KeyList.GetEnumerator();
							num = (short)981794819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							try
							{
								num = (short)1410269188;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_3CF;
									case 1:
										goto IL_3E7;
									case 2:
										try
										{
											num = (short)2025979906;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_31B;
												case 1:
													goto IL_303;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_254;
													}
													continue;
												case 3:
													goto IL_35B;
												case 4:
													num = (short)396034051;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_254;
												IL_31B:
												global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyDataRecord> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1350434820;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::ASK.Core.KeyDataRecord keyDataRecord = (global::ASK.Core.KeyDataRecord)enumerator2.Current;
												global::ASK.Core.HardwareKey hardwareKey;
												global::ASK.Interface.SystemKeyPermissionData item = this.a(keyDataRecord.SystemID, (global::ASK.Interface.KeyType)keyDataRecord.KeyType, global::ASK.Interface.KeySource.HARDWARE, keyDataRecord.AccessLevel, hardwareKey.SerialNumber, false, new global::System.DateTime?(hardwareKey.ExpirationDate));
												list.Add(item);
												num = (short)1228537857;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_254:
												num = (short)97329915;
												short num4 = num;
												num = (short)575808251;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_31B;
												default:
													num = (short)494665728;
													if (num != 0)
													{
													}
													break;
												}
												IL_303:
												num = (short)529137664;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_35B:
											break;
										}
										finally
										{
											num = (short)1450115072;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyDataRecord> enumerator2;
												switch (num2)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_392;
													}
													continue;
												case 1:
													enumerator2.Dispose();
													num = (short)1884028930;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													goto IL_3CC;
												}
												IL_392:
												if (enumerator2 == null)
												{
													break;
												}
												num = (short)38928385;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_3CC:;
										}
										goto IL_3CF;
									case 3:
									{
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyRecord> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)787021824;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::ASK.Core.HardwareKey hardwareKey = (global::ASK.Core.HardwareKey)enumerator.Current;
										num = (short)780533765;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_15D;
										}
										continue;
									case 5:
									{
										global::ASK.Core.HardwareKey hardwareKey;
										if (hardwareKey.IsAdvancedSystemKey)
										{
											num = (short)2113732614;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
									{
										global::ASK.Core.HardwareKey hardwareKey;
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyDataRecord> enumerator2 = hardwareKey.KeyDataList.GetEnumerator();
										num = (short)1876033538;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_18A:
									num = (short)87031811;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_15D:
									goto IL_18A;
									IL_3CF:
									num = (short)872873985;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3E7:
								goto IL_53F;
							}
							finally
							{
								num = (short)849870848;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyRecord> enumerator;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_41E;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)947453954;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_456;
									}
									IL_41E:
									if (enumerator == null)
									{
										break;
									}
									num = (short)806748161;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_456:;
							}
							goto IL_459;
							IL_53F:
							num = (short)1753350145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (keyRecordSet.ReadAlliBtnKeys(spIBtn, global::RMKeyValidatorLib.HardwareKeyType.ADVANCED_SYSTEM_KEY, false, true, systemWideACLRecSet, ref flag, ref flag2, ref collection, true))
							{
								num = (short)1529610242;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							str = string.Empty;
							num = (short)461766661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (collection.Count > 0)
							{
								num = (short)1611857926;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_459;
						case 6:
							str = global::ASKLib.SystemKeyManager.b("쏢죤쟦", a_) + collection[0].Message;
							num = (short)1418985472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B2;
					}
					IL_459:
					throw new global::System.Exception(global::Motorola.CommonCPS.ResourceRepository.Resources.RMSU_Cannot_Read_Hardware_Key + str)
					{
						Data = 
						{
							{
								global::ASKLib.SystemKeyManager.b("ꛢ韤闦蛨駪껬胮闰雲", a_),
								1610645507U
							}
						}
					};
					IL_4F1:
					goto IL_459;
					IL_558:
					return list;
					IL_B2:
					keyRecordSet = new global::ASK.Core.KeyRecordSet();
					systemWideACLRecSet = global::ASK.Core.Global.m_persistentData.SystemWideACLRecSet;
					spIBtn = new global::RMIBtnWrapperLib.MultiBtnWrapper();
					flag = true;
					flag2 = true;
					num = (short)818479108;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_8F;
				}
				catch (global::System.AccessViolationException innerException)
				{
					throw new global::System.Exception(global::Motorola.CommonCPS.ResourceRepository.Resources.RMSU_Cannot_Read_Hardware_Key, innerException)
					{
						Data = 
						{
							{
								global::ASKLib.SystemKeyManager.b("ꛢ韤闦蛨駪껬胮闰雲", a_),
								1610645507U
							}
						}
					};
				}
				return list;
			}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000DF2C File Offset: 0x0000C12C
		public global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> ReadLegacySoftwareKeys(string[] keyFileNames)
		{
			int a_ = 8;
			short num = (short)954269696;
			switch (num)
			{
			default:
			{
				num = (short)484179975;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num4;
					switch (num2)
					{
					case 0:
					{
						int num3;
						if (num3 > 0)
						{
							num = (short)1265500168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_236;
					}
					case 1:
						goto IL_231;
					case 2:
					{
						if (keyFileNames.Length >= 1)
						{
							global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> list = new global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData>();
							global::System.Collections.ObjectModel.Collection<global::ASK.Core.StatusMsg> status = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.StatusMsg>();
							global::ASK.Core.LegacySoftwareKey legacySoftwareKey = new global::ASK.Core.LegacySoftwareKey();
							num4 = 0;
							num = (short)367525892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1270480896;
						short num5 = num;
						num = (short)1083625881;
						short num6 = num;
						num = (short)769773977;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_231;
						default:
							num = (short)2034499584;
							if (num != 0)
							{
							}
							num = (short)1587347457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
					{
						global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> list;
						return list;
					}
					case 4:
						goto IL_143;
					case 5:
						goto IL_236;
					case 6:
					{
						global::System.Collections.ObjectModel.Collection<global::ASK.Core.StatusMsg> status;
						global::ASK.Core.LegacySoftwareKey legacySoftwareKey;
						string text;
						int num3 = legacySoftwareKey.readASystemKey(text, status);
						num = (short)1169031168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					case 8:
					{
						int num3;
						global::ASK.Interface.SystemKeyPermissionData item = this.a(num3, global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY, global::ASK.Interface.KeySource.LEGACY_KEY_FILE, this.e, null, true, null);
						global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> list;
						list.Add(item);
						num = (short)2107113477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						if (num4 >= keyFileNames.Length)
						{
							num = (short)745668611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = keyFileNames[num4];
						num = (short)2122448908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)959184898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_143;
					case 12:
					{
						num = (short)388169729;
						if (num != 0)
						{
						}
						string text;
						if (global::System.IO.File.Exists(text))
						{
							num = (short)1107558406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_236;
					}
					}
					IL_80:
					if (keyFileNames != null)
					{
						num = (short)648609802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_143:
					num = (short)681377801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_236:
					num4++;
					num = (short)1633157131;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12F:
				throw new global::System.ArgumentNullException(global::ASKLib.SystemKeyManager.b("뛜뫞飠ꗢ賤详賨ꗪ賬苮铰胲", a_));
				IL_231:
				goto IL_12F;
			}
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000E238 File Offset: 0x0000C438
		private bool a()
		{
			short num = (short)969015296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				bool flag;
				global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
				bool result;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_2F8;
					case 1:
						if (!flag)
						{
							num = (short)597360643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FA;
					case 2:
						try
						{
							num = (short)265682947;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)336920582;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ASKLib.SystemKeyData systemKeyData = (global::ASKLib.SystemKeyData)enumerator.Current;
									num = (short)1061879815;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)915406853;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1FF;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_10C;
									}
									continue;
								case 4:
									flag = true;
									num = (short)115867656;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::ASKLib.SystemKeyData systemKeyData;
									if (systemKeyData.Type == global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY)
									{
										num = (short)2000551940;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)19136514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::ASKLib.SystemKeyData systemKeyData;
									if (systemKeyData.SystemID == 1)
									{
										num = (short)92405761;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_1A6;
								}
								IL_150:
								num = (short)1313210368;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10C:
								goto IL_150;
							}
							IL_1A6:
							IL_1FF:
							goto IL_66;
						}
						finally
						{
							num = (short)1770586113;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_26F;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_236;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1868562432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_236;
								IL_239:
								num = (short)67829762;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_26F:
								num = (short)943431978;
								short num3 = num;
								num = (short)1940496682;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_239;
								default:
									goto IL_2A4;
								}
								IL_236:
								if (enumerator != null)
								{
									goto IL_239;
								}
								goto IL_26F;
							}
							IL_2A4:
							num = (short)403177472;
							if (num != 0)
							{
							}
						}
						goto IL_2BA;
						IL_66:
						num = (short)96010241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)174456833;
						if (num != 0)
						{
						}
						goto IL_2BA;
					}
					goto IL_3E;
					IL_2BA:
					global::ASKLib.SystemKeyData item = new global::ASKLib.SystemKeyData(global::ASK.Interface.KeySource.HARDWARE, global::Motorola.CommonCPS.ResourceRepository.Resources.None_Id, 1, global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY, false, false, this.e);
					this.b.Add(item);
					result = true;
					num = (short)487129088;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2F8:
				IL_2FA:
				num = (short)1619787776;
				short num4 = num;
				return result;
				IL_3E:
				result = false;
				flag = false;
				enumerator = this.b.GetEnumerator();
				num = (short)815202306;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000E584 File Offset: 0x0000C784
		private int a(global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> A_0, bool A_1)
		{
			int a_ = 16;
			short num = (short)696909824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)567934976;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				int num4;
				for (;;)
				{
					IL_5A:
					global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1531052037;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.List<global::ASK.Interface.ISystemKeyData>.Enumerator enumerator;
								global::ASK.Interface.SystemKeyPermissionData systemKeyPermissionData;
								global::ASK.Core.AccessRecord accessRecord;
								bool flag;
								bool flag2;
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)110100485;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::ASK.Interface.ISystemKeyData systemKeyData;
											switch (num2)
											{
											case 0:
												num = (short)584581128;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												num4--;
												num = (short)1724383236;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												if (this.b.Remove(systemKeyData))
												{
													num = (short)1798438913;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 3:
												if (A_1)
												{
													num = (short)249823232;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_27D;
											case 5:
												switch (0)
												{
												case 0:
													goto IL_188;
												}
												continue;
											case 6:
												if (!(a2.a.iBtnSerialNum == systemKeyData.iBtnSerialNum))
												{
													num = (short)1954086923;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_2B1;
											case 7:
												num = (short)793378826;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
												if (!string.IsNullOrEmpty(a2.a.iBtnSerialNum))
												{
													num = (short)1781792780;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_27D;
											case 9:
												if (!enumerator.MoveNext())
												{
													num = (short)205914119;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_2F9;
											case 10:
											{
												num = (short)1295019663;
												short num5 = num;
												num = (short)876441231;
												switch ((num5 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_2F9;
												default:
													goto IL_38D;
												}
												break;
											}
											case 11:
												goto IL_27D;
											case 12:
												num = (short)944832518;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 13:
												goto IL_2B1;
											}
											IL_1CF:
											num = (short)1273757705;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_188:
											goto IL_1CF;
											IL_27D:
											a2.a = this.a(a2.a, (global::ASKLib.SystemKeyData)systemKeyData);
											num = (short)2031629;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_2B1:
											num = (short)146341890;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_2F9:
											systemKeyData = enumerator.Current;
											num = (short)473497603;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_38D:
										num = (short)2020278272;
										if (num != 0)
										{
										}
										goto IL_434;
									}
									finally
									{
										((global::System.IDisposable)enumerator).Dispose();
									}
									break;
									IL_434:
									this.b.Add(a2.a);
									num4++;
									num = (short)424280070;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)290455560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (systemKeyPermissionData.Source != 1)
									{
										num = (short)260046849;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)678166532;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									flag = accessRecord.IsWriteProtected();
									goto IL_53B;
								case 4:
									flag2 = false;
									goto IL_466;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_103;
									}
									continue;
								case 7:
									flag = false;
									goto IL_53B;
								case 8:
									flag2 = accessRecord.OPTAPState;
									goto IL_466;
								case 9:
									num = (short)112984074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_5BF;
								case 11:
									if (systemKeyPermissionData.Source != 1)
									{
										num = (short)1222246413;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)810024967;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1149042697;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									systemKeyPermissionData = enumerator2.Current;
									string accessLevel = systemKeyPermissionData.AccessLevel;
									global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
									xmlDocument.LoadXml(accessLevel);
									accessRecord = new global::ASK.Core.AccessRecord(xmlDocument.DocumentElement, false);
									num = (short)799342594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									num = (short)1979711491;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3B5:
								num = (short)673710092;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_103:
								goto IL_3B5;
								IL_466:
								bool otapEnabled = flag2;
								num = (short)469893131;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_53B:
								bool bWriteProtected = flag;
								a2.a = new global::ASKLib.SystemKeyData((global::ASK.Interface.KeySource)systemKeyPermissionData.Source, systemKeyPermissionData.SerialNumber, systemKeyPermissionData.SystemID, (global::ASK.Interface.KeyType)systemKeyPermissionData.Type, otapEnabled, bWriteProtected, accessRecord);
								enumerator = this.b.Where(new global::System.Func<global::ASK.Interface.ISystemKeyData, bool>(a2.b)).ToList<global::ASK.Interface.ISystemKeyData>().GetEnumerator();
								num = (short)1934557184;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5BF:
							return num4;
						}
						finally
						{
							num = (short)347013121;
							if (num != 0)
							{
							}
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_5F6;
					case 1:
						if (A_0 == null)
						{
							num = (short)1795293186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F6;
					case 2:
						goto IL_A0;
					}
					goto IL_6D;
					IL_5F6:
					enumerator2 = A_0.GetEnumerator();
					num = (short)1274216448;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A0:
				throw new global::System.ArgumentNullException(global::ASKLib.SystemKeyManager.b("郤铦賨駪뻬雮苰룲郴軶꧸黺迼鋾栀瀂瘄渆昈攊縌", a_));
				IL_6D:
				num4 = 0;
				num = (short)231407617;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000EBF4 File Offset: 0x0000CDF4
		private global::ASK.Interface.SystemKeyPermissionData a(int A_0, global::ASK.Interface.KeyType A_1, global::ASK.Interface.KeySource A_2, global::ASK.Core.AccessRecord A_3, string A_4, bool A_5, global::System.DateTime? A_6)
		{
			short num = (short)1370750976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1673707699;
				short num3 = num;
				num = (short)815775923;
				string accessLevel;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1543634944;
					if (num != 0)
					{
					}
					num = (short)1257308160;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_B0;
					}
					for (;;)
					{
						IL_9D:
						switch (num2)
						{
						case 0:
							goto IL_103;
						case 1:
							if (A_3 != null)
							{
								num = (short)1168113666;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12B;
						case 2:
							accessLevel = A_3.ToXMLString();
							num = (short)125173760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B0;
					}
					IL_103:
					num = (short)1389625345;
					if (num != 0)
					{
					}
					break;
					IL_B0:
					accessLevel = string.Empty;
					num = (short)1932394497;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_9D;
				}
				}
				IL_12B:
				global::ASK.Interface.SystemKeyPermissionData systemKeyPermissionData = new global::ASK.Interface.SystemKeyPermissionData
				{
					UuId = global::System.Guid.NewGuid(),
					SystemID = A_0,
					Type = (int)A_1,
					Source = (int)A_2,
					AccessLevel = accessLevel,
					SerialNumber = A_4,
					NeverExpires = A_5,
					ExpirationDate = A_6
				};
				systemKeyPermissionData.CheckSum = global::ASK.Core.AcpSecurity.CalculateCheckSum(new string[]
				{
					systemKeyPermissionData.UuId.ToString(),
					systemKeyPermissionData.SystemID.ToString(),
					systemKeyPermissionData.Type.ToString(),
					systemKeyPermissionData.Source.ToString(),
					systemKeyPermissionData.SerialNumber,
					systemKeyPermissionData.NeverExpires.ToString(),
					systemKeyPermissionData.ExpirationDate.ToString(),
					systemKeyPermissionData.AccessLevel
				});
				return systemKeyPermissionData;
			}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000EE0C File Offset: 0x0000D00C
		private global::ASKLib.SystemKeyData a(global::ASKLib.SystemKeyData A_0, global::ASKLib.SystemKeyData A_1)
		{
			short num = (short)167182336;
			switch (num)
			{
			default:
			{
				int systemID;
				global::ASK.Interface.KeyType type;
				bool otapEnabled;
				for (;;)
				{
					IL_1F:
					num = (short)412614671;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						bool flag;
						switch (num2)
						{
						case 0:
							num = (short)1910767639;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (A_0.Source == global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
							{
								num = (short)43843603;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_38C;
						case 2:
							if (!A_0.OtapEnabled)
							{
								num = (short)879362048;
								short num3 = num;
								num = (short)2112487431;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1895432210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_243;
						case 4:
							goto IL_386;
						case 5:
							if (!A_0.WriteProtectEnabled)
							{
								num = (short)1382678549;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)900857860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							return A_0;
						case 7:
							num = (short)2046951425;
							if (num != 0)
							{
							}
							num = (short)1502281741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (A_1.Source == global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
							{
								num = (short)2049179658;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_172;
						case 9:
							if (A_1.Source == global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
							{
								num = (short)625082374;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_134;
						case 10:
							return A_0;
						case 11:
							num = (short)784924681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (A_1.Source != global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
							{
								num = (short)141426710;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_38C;
						case 13:
							flag = A_1.OtapEnabled;
							goto IL_416;
						case 14:
						{
							num = (short)1758571774;
							short num4 = num;
							num = (short)635874558;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1F;
							default:
								num = (short)9633792;
								if (num != 0)
								{
								}
								if (A_0.Source != global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
								{
									num = (short)1501888528;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_172;
							}
							break;
						}
						case 15:
							switch (0)
							{
							case 0:
								goto IL_A5;
							}
							continue;
						case 16:
							num = (short)1476984840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (A_0.Source == global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
							{
								num = (short)479330315;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_134;
						case 18:
							flag = true;
							goto IL_416;
						case 19:
							num = (short)1010958348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							goto IL_2E1;
						case 21:
							num = (short)322502659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							return A_1;
						case 23:
							if (A_0.Type != A_1.Type)
							{
								num = (short)1892089876;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2035482641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A5:
						if (A_0.SystemID == A_1.SystemID)
						{
							num = (short)1201602560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_291;
						IL_134:
						num = (short)1270218753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_172:
						systemID = A_0.SystemID;
						type = A_0.Type;
						num = (short)1713307650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_38C:
						num = (short)591724558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_416:
						otapEnabled = flag;
						num = (short)100073477;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return A_1;
				IL_243:
				bool flag2 = A_1.WriteProtectEnabled;
				goto IL_459;
				IL_291:
				throw new global::System.Exception(global::Motorola.CommonCPS.ResourceRepository.Resources.RMSU_Error_Merge_System_Keys);
				IL_2E1:
				goto IL_291;
				IL_386:
				flag2 = true;
				IL_459:
				bool bWriteProtected = flag2;
				global::ASK.Core.AccessRecord aclvl = global::ASK.Core.AccessRecord.Union(A_0.AccessLevel, A_1.AccessLevel);
				return new global::ASKLib.SystemKeyData(global::ASK.Interface.KeySource.AZMAN, null, systemID, type, otapEnabled, bWriteProtected, aclvl);
			}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000F294 File Offset: 0x0000D494
		public int LoadKeysFromPath(string path)
		{
			int a_ = 9;
			short num;
			int count;
			for (;;)
			{
				string[] array = new string[0];
				try
				{
					num = (short)534577154;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_DE;
						case 1:
							goto IL_14B;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_56;
							}
							continue;
						case 3:
							goto IL_DE;
						case 4:
						{
							global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> list = global::ASKLib.SystemKeyManager.a.ReadLegacySoftwareKeys(array);
							global::ASKLib.SystemKeyManager.a.AddUserKeys(list);
							count = list.Count;
							num = (short)1823014917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_D9;
						case 6:
							array = global::System.IO.Directory.GetFiles(path, global::ASKLib.SystemKeyManager.b("컟ꧡꇣ뿥", a_));
							num = (short)936247296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (array.Length != 0)
							{
								num = (short)707067908;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)613220353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_56:
						if (global::System.IO.Directory.Exists(path))
						{
							num = (short)182321158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.IO.Directory.CreateDirectory(path);
						num = (short)1788346371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_DE:
						num = (short)912785415;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_D9:
					goto IL_17D;
					IL_14B:;
				}
				catch (global::System.IO.DirectoryNotFoundException)
				{
					global::System.Windows.Forms.MessageBox.Show(global::ASKLib.SystemKeyManager.b("鷝臟賡諣觥鳧쫩迫鳭闯鏱胳鏵\ud8f7黹駻飽懿省栃爅⠇渉攋簍甏焑怓礕樗挙㰛砝伟倡У唥䜧䰩堫夭儯䀱儳ᘵ匷弹䔻䴽渿扁ᑃ㑅ⵇ㥉㽋湍὏ᥑ瑓≕㝗穙㽛ㅝ๟ᙡൣࡥᵧཀྵ䉫", a_));
				}
				catch
				{
					global::System.Windows.Forms.MessageBox.Show(global::ASKLib.SystemKeyManager.b("鷝臟賡諣觥鳧쫩跫跭鏯韱蟳藵\ud8f7黹駻飽懿省栃爅⠇渉攋簍甏焑怓礕樗挙㰛砝伟倡У䨥䜧䬩䠫䜭帯唱ᐳ䔵圷尹䠻䤽ℿぁ⅃晅⍇⽉㕋㵍繏牑ѓ⑕㵗⥙⽛繝⽟⥡䑣ብݧ䩩ཫŭṯٱᵳᡵ൷ό剻", a_));
				}
				break;
				IL_17D:
				num = (short)2087252418;
				short num3 = num;
				num = (short)2051273154;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1B5;
				}
			}
			return -1;
			IL_1B5:
			num = (short)1940258816;
			if (num != 0)
			{
			}
			num = (short)1412825088;
			short num4 = num;
			num = (short)1194393601;
			if (num != 0)
			{
			}
			return count;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(600723158 + A_1) + (global::System.IntPtr)53 + (global::System.IntPtr)7 + (global::System.IntPtr)72 + (global::System.IntPtr)45 + (global::System.IntPtr)77);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
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
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}

		// Token: 0x0400002E RID: 46
		private static global::ASK.Interface.ISystemKeyManager a;

		// Token: 0x0400002F RID: 47
		private global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> b;

		// Token: 0x04000030 RID: 48
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::ASK.Interface.ISystemKeyData> c;

		// Token: 0x04000031 RID: 49
		private const int d = 1;

		// Token: 0x04000032 RID: 50
		private global::ASK.Core.AccessRecord e;

		// Token: 0x04000033 RID: 51
		private const string f = "fffffffffffffffffffffffffff7ffffffffffffffffffff";

		// Token: 0x02000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600006F RID: 111 RVA: 0x0000F594 File Offset: 0x0000D794
			internal bool b(global::ASK.Interface.ISystemKeyData A_0)
			{
				short num = (short)1048641537;
				if (num != 0)
				{
				}
				if (A_0.SystemID != this.a.SystemID)
				{
					num = (short)118649368;
					short num2 = num;
					num = (short)944140824;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)561250304;
						if (num != 0)
						{
						}
						return false;
					}
				}
				num = (short)1236533248;
				short num3 = num;
				return A_0.Type == this.a.Type;
			}

			// Token: 0x04000034 RID: 52
			public global::ASKLib.SystemKeyData a;
		}
	}
}
