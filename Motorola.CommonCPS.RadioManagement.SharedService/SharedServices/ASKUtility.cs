using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ASK.Interface;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200002C RID: 44
	public class ASKUtility
	{
		// Token: 0x06000537 RID: 1335 RVA: 0x00033CEC File Offset: 0x00031EEC
		public static global::ASK.Interface.ProtectionOption GetProtectionOption(string modelNumber, string flashCode, bool fromCodeplug)
		{
			short num = (short)1379897777;
			short num2 = num;
			num = (short)250122673;
			switch (num2 == num)
			{
			}
			num = (short)665714688;
			if (num != 0)
			{
			}
			num = (short)610729985;
			if (num != 0)
			{
			}
			num = (short)526909440;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.GetProtectionOption(modelNumber, flashCode, fromCodeplug);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00033DA0 File Offset: 0x00031FA0
		public static bool CheckIfOwnerASKIsAttached(int homeSysId, global::ASK.Interface.KeyType homeKeyType, global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> attachedASKs, out global::ASK.Interface.ISystemKeyData outASK)
		{
			short num = (short)161021952;
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
				global::ASK.Interface.ISystemKeyData systemKeyData;
				global::ASK.Interface.ISystemKeyData systemKeyData3;
				global::ASK.Interface.ISystemKeyData systemKeyData4;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (systemKeyData != null)
						{
							num = (short)736493572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)873136135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)338493440;
						short num3 = num;
						try
						{
							num = (short)49545223;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::ASK.Interface.ISystemKeyData systemKeyData2;
								switch (num2)
								{
								case 0:
									if (systemKeyData2.WriteProtectEnabled)
									{
										num = (short)1509163019;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									systemKeyData3 = systemKeyData2;
									num = (short)1445920778;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (homeKeyType == systemKeyData2.Type)
									{
										num = (short)1916338180;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									goto IL_2F5;
								case 3:
									goto IL_2D9;
								case 4:
								{
									global::ASK.Interface.KeyAccessLevelType accessLevelType = systemKeyData2.AccessLevelType;
									num = (short)2085486600;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									if (homeSysId == systemKeyData2.SystemID)
									{
										num = (short)348520457;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									goto IL_374;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_175;
									}
									continue;
								case 8:
								{
									global::ASK.Interface.KeyAccessLevelType accessLevelType;
									if (accessLevelType != global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
									{
										num = (short)803536908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D9;
								}
								case 9:
									num = (short)1347878913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									systemKeyData4 = systemKeyData2;
									num = (short)202702863;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									num = (short)25952272;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1503002638;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									systemKeyData2 = enumerator.Current;
									num = (short)1669922821;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									num = (short)864681990;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
								{
									global::ASK.Interface.KeyAccessLevelType accessLevelType;
									if (accessLevelType == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
									{
										num = (short)2005794819;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2060648448;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_192:
								num = (short)2134900749;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_175:
								goto IL_192;
								IL_2D9:
								systemKeyData = systemKeyData2;
								num = (short)1395195906;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2F5:
							IL_374:
							goto IL_51D;
						}
						finally
						{
							num = (short)1965359106;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_432;
								case 1:
								{
									num = (short)770124638;
									short num4 = num;
									num = (short)86977374;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1710161920;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)42139648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3AC;
									}
									continue;
								}
								IL_3AC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)875102209;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_432:;
						}
						goto IL_435;
						IL_51D:
						num = (short)789512192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (systemKeyData3 != null)
						{
							num = (short)770310147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_556;
					case 3:
						outASK = systemKeyData3;
						num = (short)1843527690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1362886657;
						if (num != 0)
						{
						}
						outASK = systemKeyData;
						num = (short)1054933003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (attachedASKs != null)
						{
							num = (short)1780547592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_556;
					case 6:
						outASK = systemKeyData4;
						num = (short)428539913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (systemKeyData4 != null)
						{
							num = (short)1180303366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_435;
					case 8:
					{
						global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = attachedASKs.GetEnumerator();
						num = (short)1582432257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_BC;
					case 10:
						goto IL_51B;
					case 11:
						goto IL_106;
					}
					goto IL_60;
					IL_435:
					num = (short)1502281730;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BC:
				IL_106:
				IL_51B:
				IL_556:
				return outASK != null;
				IL_60:
				outASK = null;
				systemKeyData = null;
				systemKeyData4 = null;
				systemKeyData3 = null;
				num = (short)1835401221;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00034324 File Offset: 0x00032524
		public static bool CheckForUnlimitedKeyLoaded(global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> attachedASKs)
		{
			short num;
			bool result;
			for (;;)
			{
				num = (short)156434432;
				switch (num)
				{
				default:
				{
					num = (short)1792016384;
					short num2 = num;
					global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = attachedASKs.GetEnumerator();
					try
					{
						num = (short)370278402;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								num = (short)1764491273;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								global::ASK.Interface.ISystemKeyData systemKeyData;
								if (systemKeyData.Type != global::ASK.Interface.KeyType.ADVANCED_CONV_SYSTEM_KEY)
								{
									num = (short)2066808846;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_B3;
								}
								continue;
							case 3:
							{
								global::ASK.Interface.ISystemKeyData systemKeyData;
								if (systemKeyData.Type != global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY)
								{
									num = (short)1872166924;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								num = (short)381222915;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								num = (short)1282473985;
								if (num != 0)
								{
								}
								global::ASK.Interface.ISystemKeyData systemKeyData;
								if (systemKeyData.SystemID == 1)
								{
									num = (short)1213988868;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_B8;
							}
							case 6:
								goto IL_296;
							case 7:
								goto IL_1A0;
							case 8:
							{
								global::ASK.Interface.KeyAccessLevelType accessLevelType;
								if (accessLevelType != global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
								{
									num = (short)81723392;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A0;
							}
							case 9:
							{
								global::ASK.Interface.KeyAccessLevelType accessLevelType;
								if (accessLevelType == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
								{
									num = (short)1523318791;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
								goto IL_D0;
							case 11:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2052259853;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::ASK.Interface.ISystemKeyData systemKeyData = enumerator.Current;
								global::ASK.Interface.KeyAccessLevelType accessLevelType = systemKeyData.AccessLevelType;
								num = (short)2114977800;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 12:
								goto IL_B8;
							case 13:
								num = (short)1921187846;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								num = (short)2621445;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B3;
							IL_B8:
							result = true;
							num = (short)1150943242;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_15E:
							num = (short)1828585483;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_B3:
							goto IL_15E;
							IL_1A0:
							num = (short)1913061377;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_D0:
						goto IL_309;
						IL_296:
						return false;
					}
					finally
					{
						num = (short)1812660224;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2CE;
								}
								continue;
							case 1:
								goto IL_306;
							case 2:
								enumerator.Dispose();
								num = (short)1060962305;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2CE:
							if (enumerator == null)
							{
								break;
							}
							num = (short)909836290;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_306:;
					}
					IL_309:
					num = (short)1895220934;
					short num4 = num;
					num = (short)28034758;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_33E;
					}
					break;
				}
				}
			}
			return false;
			IL_33E:
			num = (short)1308033024;
			if (num != 0)
			{
			}
			return result;
		}
	}
}
