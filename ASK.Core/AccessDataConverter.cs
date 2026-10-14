using System;
using System.Collections.Generic;
using ASK.Interface;

namespace ASK.Core
{
	// Token: 0x02000005 RID: 5
	public static class AccessDataConverter
	{
		// Token: 0x0600000E RID: 14 RVA: 0x0000270C File Offset: 0x0000090C
		public static global::ASK.Core.AccessRecordData ConvertLegacyAccessRecordData(global::ASK.Core.AccessRecordData legacyAccRecData, bool otapEnabled, global::ASK.Interface.KeyAccessLevelType aclType = global::ASK.Interface.KeyAccessLevelType.LIMITED_ACC)
		{
			short num = (short)1972699136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				global::ASK.Core.AccessRecordData result;
				for (;;)
				{
					IL_27:
					byte[] fc;
					switch (num2)
					{
					case 0:
						global::ASK.Core.AccessDataConverter.a(ref fc);
						num = (short)262406148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1B4;
					case 2:
						if (legacyAccRecData != null)
						{
							num = (short)523370505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
					{
						byte[] fc2 = global::ASK.Core.AccessDataConverter.b(legacyAccRecData.FieldCode);
						result = new global::ASK.Core.AccessRecordData(legacyAccRecData.PrimaryKey, fc2, null);
						num = (short)724566024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)10585560;
						short num3 = num;
						num = (short)1698661848;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B4;
						default:
							num = (short)1650524160;
							if (num != 0)
							{
							}
							goto IL_13A;
						}
						break;
					}
					case 5:
						num = (short)578289665;
						if (num != 0)
						{
						}
						if (otapEnabled)
						{
							num = (short)1082851328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13A;
					case 6:
						if (aclType == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
						{
							num = (short)999620611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						fc = global::ASK.Core.AccessDataConverter.a(legacyAccRecData.FieldCode);
						num = (short)1842413573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_16E;
					case 8:
						goto IL_133;
					case 9:
						num = (short)1511653377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return legacyAccRecData;
					}
					goto IL_5A;
					IL_13A:
					global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> rg = global::ASK.Core.AccessDataConverter.a(legacyAccRecData.Ranges);
					result = new global::ASK.Core.AccessRecordData(legacyAccRecData.PrimaryKey, fc, rg);
					num = (short)1832714247;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B4:
					if (aclType == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
					{
						num = (short)796131338;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)2047148038;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_133:
				return result;
				IL_16E:
				num = (short)189857792;
				short num4 = num;
				return result;
				IL_5A:
				result = null;
				num = (short)1547108354;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000029A0 File Offset: 0x00000BA0
		internal static byte[] b(byte[] A_0)
		{
			short num = (short)1583022080;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_56;
			}
			int num3;
			byte[] array;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
					if (A_0 != null)
					{
						num = (short)341114885;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_167;
				case 1:
					global::ASK.Core.AccessDataConverter.a(global::ASK.Core.LegacyAccessElementMap.LegacyFieldMap[global::ASK.Interface.AccessElementLegacyIDType.WRITE_PROTECT_RADIO_ELEMENT], ref array);
					goto IL_14E;
				case 2:
					goto IL_167;
				case 3:
					goto IL_95;
				case 4:
				{
					num = (short)1859321857;
					if (num != 0)
					{
					}
					int num4;
					if (num4 >= A_0.Length)
					{
						num = (short)1821114369;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					array[num4] = byte.MaxValue;
					num4++;
					num = (short)1810956294;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					array = new byte[24];
					int num4 = 0;
					num = (short)359727107;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_95;
				}
				goto IL_56;
				IL_95:
				num = (short)873332740;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_14E:
				num = (short)2017525762;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_167:
				num = (short)1308686698;
				short num5 = num;
				num = (short)42727786;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14E;
				default:
					goto IL_19C;
				}
			}
			IL_19C:
			num = (short)2883584;
			if (num != 0)
			{
			}
			return array;
			IL_56:
			array = null;
			new global::System.Collections.Generic.Dictionary<global::ASK.Interface.AccessElementIDType, global::ASK.Interface.AccessElementIDType>();
			num = (short)1745158144;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002B60 File Offset: 0x00000D60
		internal static byte[] a(byte[] A_0)
		{
			short num = (short)1802960896;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7C;
				}
				byte[] array;
				global::System.Collections.Generic.Dictionary<global::ASK.Interface.AccessElementIDType, global::ASK.Interface.AccessElementIDType> dictionary;
				for (;;)
				{
					IL_29:
					int num3;
					int num5;
					global::System.Collections.Generic.Dictionary<global::ASK.Interface.AccessElementIDType, global::ASK.Interface.AccessElementIDType>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_381;
					case 1:
					{
						global::ASK.Interface.AccessElementLegacyIDType accessElementLegacyIDType;
						if (accessElementLegacyIDType <= global::ASK.Interface.AccessElementLegacyIDType.HOLDER_FOR_TRK_PER_GEN_TIME_OUT_TIMER_ELEMENT)
						{
							num = (short)1378484231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C8;
					}
					case 2:
					{
						num = (short)244973569;
						if (num != 0)
						{
						}
						global::ASK.Interface.AccessElementLegacyIDType accessElementLegacyIDType = (global::ASK.Interface.AccessElementLegacyIDType)num3;
						num = (short)1580793857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)18415616;
						short num4 = num;
						if (A_0 != null)
						{
							num = (short)594870283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					}
					case 4:
						if (num5 >= A_0.Length)
						{
							num = (short)1705902094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3;
					case 5:
						goto IL_E8;
					case 6:
						try
						{
							num = (short)2059665409;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)2056891285;
									short num6 = num;
									num = (short)2020256661;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_218;
									default:
										num = (short)103809024;
										if (num != 0)
										{
										}
										num = (short)487325698;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1CA;
									}
									continue;
								case 2:
									goto IL_293;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										goto IL_218;
									}
									global::System.Collections.Generic.KeyValuePair<global::ASK.Interface.AccessElementIDType, global::ASK.Interface.AccessElementIDType> keyValuePair = enumerator.Current;
									global::ASK.Core.AccessDataConverter.b(keyValuePair.Value, ref array);
									num = (short)1768292355;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1FA:
								num = (short)1449590788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1CA:
								goto IL_1FA;
								IL_218:
								num = (short)1708326912;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_293:
							goto IL_2EE;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2A3;
						IL_2EE:
						global::ASK.Core.AccessDataConverter.b(global::ASK.Interface.AccessElementIDType.TRK_SYS_ASTRO_25_CID_CHAN_TYPE_ELEMENT, ref array);
						num = (short)133365778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::ASK.Interface.AccessElementLegacyIDType accessElementLegacyIDType;
						global::ASK.Interface.AccessElementIDType accessElementIDType = global::ASK.Core.LegacyAccessElementMap.LegacyFieldMap[accessElementLegacyIDType];
						num = (short)1383661577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_151;
					case 9:
					{
						global::ASK.Interface.AccessElementIDType accessElementIDType;
						if (!dictionary.ContainsKey(accessElementIDType))
						{
							num = (short)519634960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_381;
					}
					case 10:
						if (num3 > 8 * A_0.Length)
						{
							num = (short)546963471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1160904717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						array = new byte[24];
						num5 = 0;
						num = (short)1418657800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_E8;
					case 13:
						if (global::ASK.Core.AccessDataConverter.a(num3, A_0))
						{
							num = (short)908787714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_381;
					case 14:
						num3 = 1;
						num = (short)1620639749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_2C8;
					case 16:
					{
						global::ASK.Interface.AccessElementIDType accessElementIDType;
						dictionary.Add(accessElementIDType, accessElementIDType);
						num = (short)130547712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_151;
					case 18:
						return array;
					}
					goto IL_7C;
					IL_E8:
					num = (short)467271690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_151:
					num = (short)29425668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A3:
					array[num5] = 0;
					num5++;
					num = (short)631046161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C8:
					enumerator = dictionary.GetEnumerator();
					num = (short)569966598;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_381:
					num3++;
					num = (short)1111752716;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_7C:
				array = null;
				dictionary = new global::System.Collections.Generic.Dictionary<global::ASK.Interface.AccessElementIDType, global::ASK.Interface.AccessElementIDType>();
				num = (short)1507328003;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002FFC File Offset: 0x000011FC
		internal static global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> a(global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> A_0)
		{
			short num = (short)535363584;
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
				global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.ValueCollection.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1488650241;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::ASK.Interface.AccessElementIDType accessElementIDType;
									if (!dictionary.ContainsKey((ushort)accessElementIDType))
									{
										num = (short)1161691138;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_BD;
									}
									continue;
								case 2:
								{
									global::ASK.Interface.AccessElementIDType accessElementIDType;
									global::ASK.Core.FieldValueRangeRecSet fieldValueRangeRecSet;
									dictionary.Add((ushort)accessElementIDType, fieldValueRangeRecSet);
									num = (short)875823107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									try
									{
										num = (short)1675821057;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)1439367170;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_163;
												}
												continue;
											case 2:
												goto IL_1F5;
											case 4:
											{
												global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)867500032;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::ASK.Core.AccessFieldValueRange accessFieldValueRange = enumerator.Current;
												global::ASK.Interface.AccessElementIDType accessElementIDType;
												global::ASK.Core.AccessFieldValueRange item = new global::ASK.Core.AccessFieldValueRange((int)accessElementIDType, accessFieldValueRange.Minimum, accessFieldValueRange.Maximum);
												global::ASK.Core.FieldValueRangeRecSet fieldValueRangeRecSet;
												fieldValueRangeRecSet.Add(item);
												num = (short)302514179;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_1A4:
											num = (short)1634861060;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_163:
											goto IL_1A4;
										}
										IL_1F5:
										goto IL_2D7;
									}
									finally
									{
										num = (short)782041089;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator;
											switch (num2)
											{
											case 0:
												goto IL_265;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_22D;
												}
												continue;
											case 2:
												enumerator.Dispose();
												num = (short)1470889984;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_22D:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1313865730;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_265:;
									}
									break;
									IL_2D7:
									num = (short)494796800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::ASK.Core.FieldValueRangeRecSet fieldValueRangeRecSet2 = enumerator2.Current;
									global::ASK.Interface.AccessElementIDType accessElementIDType = global::ASK.Core.AccessDataConverter.a((global::ASK.Interface.AccessElementLegacyIDType)fieldValueRangeRecSet2.OwnerID);
									global::ASK.Core.FieldValueRangeRecSet fieldValueRangeRecSet = null;
									if (!dictionary.ContainsKey((ushort)accessElementIDType))
									{
										fieldValueRangeRecSet = new global::ASK.Core.FieldValueRangeRecSet((ushort)accessElementIDType);
									}
									else
									{
										fieldValueRangeRecSet = dictionary[(ushort)accessElementIDType];
									}
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator = fieldValueRangeRecSet2.GetEnumerator();
									num = (short)2000093188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_32E;
								case 7:
									if (!enumerator2.MoveNext())
									{
										num = (short)1307770888;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)253952005;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1784676358;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_268:
								num = (short)88735751;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BD:
								goto IL_268;
							}
							IL_32E:
							goto IL_36E;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_33E;
					case 1:
						if (A_0 != null)
						{
							num = (short)63045634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36E;
					case 2:
						goto IL_33E;
					}
					goto IL_3B;
					IL_33E:
					dictionary = new global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>();
					enumerator2 = A_0.Values.GetEnumerator();
					num = (short)1161953280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36E:
					num = (short)941096960;
					short num3 = num;
					num = (short)625032385;
					short num4 = num;
					num = (short)1313160385;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_33E;
					default:
						goto IL_3CC;
					}
				}
				IL_3CC:
				num = (short)2016346113;
				if (num != 0)
				{
				}
				num = (short)1003880448;
				if (num != 0)
				{
				}
				return dictionary;
				IL_3B:
				dictionary = null;
				num = (short)840171521;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003448 File Offset: 0x00001648
		private static bool a(int A_0, byte[] A_1)
		{
			short num = (short)1225037675;
			short num2 = num;
			num = (short)1068537707;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AD:
				num = (short)768802819;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)56033280;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_7C;
				}
				break;
			}
			bool result;
			for (;;)
			{
				IL_56:
				switch (num3)
				{
				case 0:
					if (A_0 > 0)
					{
						num = (short)2140143620;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
				{
					int num4 = A_0 - 1;
					int num5 = num4 / 8;
					int num6 = num4 % 8;
					num = (short)428408832;
					short num7 = num;
					num = (short)1761935367;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return result;
				case 3:
					if (A_0 <= 8 * A_1.Length)
					{
						num = (short)415825921;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					goto IL_AD;
				case 5:
					num = (short)4915201;
					if (num != 0)
					{
					}
					result = true;
					num = (short)458096646;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return result;
				case 7:
				{
					int num5;
					int num6;
					if (((int)A_1[num5] & 1 << num6) > 0)
					{
						num = (short)2002321413;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = false;
					num = (short)698613762;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_7C;
			}
			return result;
			IL_7C:
			result = false;
			num = (short)1446117376;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_56;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003618 File Offset: 0x00001818
		private static void b(global::ASK.Interface.AccessElementIDType A_0, ref byte[] A_1)
		{
			short num = (short)1854704768;
			short num2 = num;
			num = (short)1265011840;
			switch (num2 == num)
			{
			}
			num = (short)1058668545;
			if (num != 0)
			{
			}
			num = (short)1442185216;
			short num3 = num;
			num = (short)508821504;
			if (num != 0)
			{
			}
			int num4 = A_0 - global::ASK.Interface.AccessElementIDType.TRK_SYS_GEN_SYS_ID_ELEMENT;
			int num5 = num4 / 8;
			int num6 = num4 % 8;
			byte[] array = A_1;
			int num7 = num5;
			array[num7] += (byte)(1 << num6);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000036DC File Offset: 0x000018DC
		private static void a(global::ASK.Interface.AccessElementIDType A_0, ref byte[] A_1)
		{
			short num = (short)1010889479;
			short num2 = num;
			num = (short)627634951;
			switch (num2 == num)
			{
			}
			num = (short)563412993;
			if (num != 0)
			{
			}
			num = (short)1462960128;
			if (num != 0)
			{
			}
			num = (short)1690042368;
			short num3 = num;
			int num4 = A_0 - global::ASK.Interface.AccessElementIDType.TRK_SYS_GEN_SYS_ID_ELEMENT;
			int num5 = num4 / 8;
			int num6 = num4 % 8;
			byte[] array = A_1;
			int num7 = num5;
			array[num7] &= (byte)(~(byte)(1 << num6));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000037A4 File Offset: 0x000019A4
		internal static void a(ref byte[] A_0)
		{
			short num = (short)1060380670;
			short num2 = num;
			num = (short)1148133374;
			switch (num2 == num)
			{
			}
			num = (short)605356033;
			if (num != 0)
			{
			}
			num = (short)312213504;
			if (num != 0)
			{
			}
			num = (short)338296832;
			short num3 = num;
			global::ASK.Core.AccessDataConverter.b(global::ASK.Interface.AccessElementIDType.OTAP_ELEMENT, ref A_0);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003854 File Offset: 0x00001A54
		internal static global::ASK.Interface.AccessElementIDType a(global::ASK.Interface.AccessElementLegacyIDType A_0)
		{
			int a_ = 15;
			short num;
			while (!global::ASK.Core.LegacyAccessElementMap.LegacyFieldMap.ContainsKey(A_0))
			{
				num = (short)519110656;
				short num2 = num;
				num = (short)772632838;
				short num3 = num;
				num = (short)1469018374;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1404895232;
					if (num != 0)
					{
					}
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("Ɋ⍌㥎ぐ㽒㱔㍖祘᝚㡜㡞`bᱤ䝦⽨ɪ࡬ͮᕰ卲㱴㍶", a_));
				}
			}
			num = (short)2106523649;
			if (num != 0)
			{
			}
			return global::ASK.Core.LegacyAccessElementMap.LegacyFieldMap[A_0];
		}
	}
}
