using System;
using System.Collections.Generic;

namespace AcpASKLib
{
	// Token: 0x02000005 RID: 5
	public static class AccessDataConverter
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002710 File Offset: 0x00000910
		internal static global::AcpASKLib.AccessRecordData a(global::AcpASKLib.AccessRecordData A_0, bool A_1)
		{
			short num = (short)92012544;
			short num2 = num;
			num = (short)361129545;
			short num3 = num;
			num = (short)125724233;
			byte[] a_;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14A:
				a_ = global::AcpASKLib.AccessDataConverter.a(A_0.FieldCode);
				num = (short)336986115;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)833748992;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_9C;
				}
				break;
			}
			global::AcpASKLib.AccessRecordData result;
			for (;;)
			{
				IL_7E:
				switch (num4)
				{
				case 0:
					if (A_0 != null)
					{
						num = (short)508755972;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					global::AcpASKLib.AccessDataConverter.a(ref a_);
					num = (short)481427458;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_F6;
				case 3:
					if (A_1)
					{
						num = (short)1568538625;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F6;
				case 4:
					goto IL_F4;
				case 5:
					return result;
				}
				goto IL_9C;
				IL_F6:
				global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> a_2 = global::AcpASKLib.AccessDataConverter.a(A_0.Ranges);
				result = new global::AcpASKLib.AccessRecordData(A_0.PrimaryKey, a_, a_2);
				num = (short)884736005;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_F4:
			goto IL_14A;
			IL_9C:
			num = (short)1300234241;
			if (num != 0)
			{
			}
			result = null;
			num = (short)1577713664;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7E;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000028A8 File Offset: 0x00000AA8
		internal static byte[] a(byte[] A_0)
		{
			short num = (short)826736640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				byte[] array;
				global::System.Collections.Generic.Dictionary<global::AcpASKLib.AccessElementIDType, global::AcpASKLib.AccessElementIDType> dictionary;
				for (;;)
				{
					IL_28:
					int num3;
					int num4;
					switch (num2)
					{
					case 0:
						if (A_0 != null)
						{
							num = (short)2049703954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					case 1:
						goto IL_BB;
					case 2:
						goto IL_3A7;
					case 3:
						if (num3 >= A_0.Length)
						{
							num = (short)906690575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_255;
					case 4:
						return array;
					case 5:
						goto IL_27A;
					case 6:
						goto IL_BB;
					case 7:
					{
						global::AcpASKLib.AccessElementLegacyIDType accessElementLegacyIDType = (global::AcpASKLib.AccessElementLegacyIDType)num4;
						num = (short)1324548110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_124;
					case 9:
						goto IL_124;
					case 10:
					{
						global::AcpASKLib.AccessElementIDType accessElementIDType;
						dictionary.Add(accessElementIDType, accessElementIDType);
						num = (short)1898446850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (num4 > 8 * A_0.Length)
						{
							num = (short)746979333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1136656401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::AcpASKLib.AccessElementLegacyIDType accessElementLegacyIDType;
						global::AcpASKLib.AccessElementIDType accessElementIDType = global::AcpASKLib.LegacyAccessElementMap.LegacyFieldMap[accessElementLegacyIDType];
						num = (short)903151632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						IL_2E4:
						try
						{
							num = (short)1161232387;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.Dictionary<global::AcpASKLib.AccessElementIDType, global::AcpASKLib.AccessElementIDType>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1645805570;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::AcpASKLib.AccessElementIDType, global::AcpASKLib.AccessElementIDType> keyValuePair = enumerator.Current;
									global::AcpASKLib.AccessDataConverter.a(keyValuePair.Value, ref array);
									num = (short)1669595137;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)2128150532;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1C3;
									}
									continue;
								case 4:
									goto IL_242;
								}
								IL_1F4:
								num = (short)627703808;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C3:
								goto IL_1F4;
							}
							IL_242:
							goto IL_2E9;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<global::AcpASKLib.AccessElementIDType, global::AcpASKLib.AccessElementIDType>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_255;
						IL_2E9:
						global::AcpASKLib.AccessDataConverter.a(global::AcpASKLib.AccessElementIDType.TRK_SYS_ASTRO_25_CID_CHAN_TYPE_ELEMENT, ref array);
						num = (short)495255552;
						short num5 = num;
						num = (short)1756889092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::AcpASKLib.AccessElementLegacyIDType accessElementLegacyIDType;
						if (accessElementLegacyIDType <= global::AcpASKLib.AccessElementLegacyIDType.HOLDER_FOR_TRK_PER_GEN_TIME_OUT_TIMER_ELEMENT)
						{
							num = (short)1289551884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A;
					}
					case 15:
						num = (short)1048510465;
						if (num != 0)
						{
						}
						num4 = 1;
						num = (short)1677590534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::AcpASKLib.AccessElementIDType accessElementIDType;
						if (!dictionary.ContainsKey(accessElementIDType))
						{
							num = (short)124846090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A7;
					}
					case 17:
						if (global::AcpASKLib.AccessDataConverter.a(num4, A_0))
						{
							num = (short)1807745031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A7;
					case 18:
						array = new byte[24];
						num3 = 0;
						num = (short)105578505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B;
					IL_BB:
					num = (short)157024267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_124:
					num = (short)860487683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_255:
					array[num3] = 0;
					num3++;
					num = (short)2119565320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27A:
					num = (short)1671655172;
					short num6 = num;
					num = (short)1884974852;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2E4;
					default:
					{
						num = (short)214958080;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.Dictionary<global::AcpASKLib.AccessElementIDType, global::AcpASKLib.AccessElementIDType>.Enumerator enumerator = dictionary.GetEnumerator();
						num = (short)1615986701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_3A7:
					num4++;
					num = (short)310116353;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_7B:
				array = null;
				dictionary = new global::System.Collections.Generic.Dictionary<global::AcpASKLib.AccessElementIDType, global::AcpASKLib.AccessElementIDType>();
				num = (short)1783496704;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002D38 File Offset: 0x00000F38
		internal static global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> a(global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> A_0)
		{
			short num = (short)730267648;
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
				global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.ValueCollection.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)385810439;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)2100625411;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpASKLib.AccessElementIDType accessElementIDType;
									if (!dictionary.ContainsKey((ushort)accessElementIDType))
									{
										num = (short)1008205830;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_37A;
								case 4:
								{
									global::AcpASKLib.FieldValueRangeRecSet fieldValueRangeRecSet = enumerator.Current;
									global::AcpASKLib.AccessElementIDType accessElementIDType = global::AcpASKLib.AccessDataConverter.a((global::AcpASKLib.AccessElementLegacyIDType)fieldValueRangeRecSet.OwnerID);
									global::AcpASKLib.FieldValueRangeRecSet fieldValueRangeRecSet2 = null;
									if (!dictionary.ContainsKey((ushort)accessElementIDType))
									{
										fieldValueRangeRecSet2 = new global::AcpASKLib.FieldValueRangeRecSet((ushort)accessElementIDType);
									}
									else
									{
										fieldValueRangeRecSet2 = dictionary[(ushort)accessElementIDType];
									}
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessFieldValueRange> enumerator2 = fieldValueRangeRecSet.GetEnumerator();
									num = (short)52625413;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									try
									{
										num = (short)264372227;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_1F6;
											case 1:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessFieldValueRange> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)2016673794;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpASKLib.AccessFieldValueRange accessFieldValueRange = enumerator2.Current;
												global::AcpASKLib.AccessElementIDType accessElementIDType;
												global::AcpASKLib.AccessFieldValueRange item = new global::AcpASKLib.AccessFieldValueRange((int)accessElementIDType, accessFieldValueRange.Minimum, accessFieldValueRange.Maximum);
												global::AcpASKLib.FieldValueRangeRecSet fieldValueRangeRecSet2;
												fieldValueRangeRecSet2.Add(item);
												num = (short)1311047684;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												num = (short)897712128;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_164;
												}
												continue;
											}
											IL_1A5:
											num = (short)1854472193;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_164:
											goto IL_1A5;
										}
										IL_1F6:
										goto IL_322;
									}
									finally
									{
										num = (short)469368833;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_2B1;
											case 1:
											{
												num = (short)878839837;
												short num3 = num;
												num = (short)377489437;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_294;
												default:
													num = (short)1827995648;
													if (num != 0)
													{
													}
													switch (0)
													{
													case 0:
														goto IL_279;
													}
													continue;
												}
												break;
											}
											case 2:
												goto IL_294;
											}
											IL_279:
											global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessFieldValueRange> enumerator2;
											if (enumerator2 != null)
											{
												num = (short)1972699138;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
											IL_294:
											enumerator2.Dispose();
											num = (short)1196687360;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2B1:;
									}
									break;
									IL_322:
									num = (short)1855848450;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpASKLib.AccessElementIDType accessElementIDType;
									global::AcpASKLib.FieldValueRangeRecSet fieldValueRangeRecSet2;
									dictionary.Add((ushort)accessElementIDType, fieldValueRangeRecSet2);
									num = (short)268238848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_BD;
									}
									continue;
								case 8:
									if (!enumerator.MoveNext())
									{
										num = (short)422379521;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)602210308;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2B4:
								num = (short)149094408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BD:
								goto IL_2B4;
							}
							IL_37A:
							return dictionary;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_38D;
					case 1:
						if (A_0 != null)
						{
							num = (short)570490882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					case 2:
						goto IL_38D;
					}
					goto IL_3B;
					IL_38D:
					dictionary = new global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>();
					enumerator = A_0.Values.GetEnumerator();
					num = (short)933888000;
					short num4 = num;
					num = (short)117047297;
					if (num != 0)
					{
					}
					num = (short)2073427968;
					num2 = (int)((global::System.IntPtr)num);
				}
				return dictionary;
				IL_3B:
				dictionary = null;
				num = (short)1844838401;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003188 File Offset: 0x00001388
		private static bool a(int A_0, byte[] A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num4;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					int num2;
					int num3;
					if (((int)A_1[num2] & 1 << num3) > 0)
					{
						num4 = (short)1223163906;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					result = false;
					goto IL_1B0;
				}
				case 1:
					if (A_0 <= 8 * A_1.Length)
					{
						num4 = (short)2099970053;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					return result;
				case 2:
					result = true;
					num4 = (short)549650439;
					num = (int)((global::System.IntPtr)num4);
					continue;
				case 3:
					num4 = (short)866189313;
					num = (int)((global::System.IntPtr)num4);
					continue;
				case 4:
					return result;
				case 5:
				{
					num4 = (short)876675073;
					if (num4 != 0)
					{
					}
					int num5 = A_0 - 1;
					int num2 = num5 / 8;
					int num3 = num5 % 8;
					num4 = (short)148045824;
					num = (int)((global::System.IntPtr)num4);
					continue;
				}
				case 6:
				{
					if (A_0 <= 0)
					{
						return result;
					}
					num4 = (short)991950344;
					short num6 = num4;
					num4 = (short)1579742728;
					switch ((num6 == num4) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B0;
					default:
					{
						num4 = (short)231211008;
						short num7 = num4;
						num4 = (short)2107244544;
						if (num4 != 0)
						{
						}
						num4 = (short)423493635;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					}
					break;
				}
				case 7:
					return result;
				}
				goto IL_30;
				IL_1B0:
				num4 = (short)996868100;
				num = (int)((global::System.IntPtr)num4);
			}
			return result;
			IL_30:
			result = false;
			num4 = (short)1524170758;
			num = (int)((global::System.IntPtr)num4);
			goto IL_0A;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003360 File Offset: 0x00001560
		private static void a(global::AcpASKLib.AccessElementIDType A_0, ref byte[] A_1)
		{
			short num = (short)1652522512;
			short num2 = num;
			num = (short)769818128;
			switch (num2 == num)
			{
			}
			num = (short)1419509761;
			if (num != 0)
			{
			}
			num = (short)1570242560;
			if (num != 0)
			{
			}
			num = (short)491061248;
			short num3 = num;
			int num4 = A_0 - global::AcpASKLib.AccessElementIDType.TRK_SYS_GEN_SYS_ID_ELEMENT;
			int num5 = num4 / 8;
			int num6 = num4 % 8;
			byte[] array = A_1;
			int num7 = num5;
			array[num7] += (byte)(1 << num6);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000342C File Offset: 0x0000162C
		internal static void a(ref byte[] A_0)
		{
			short num = (short)1479350259;
			short num2 = num;
			num = (short)1842550771;
			switch (num2 == num)
			{
			}
			num = (short)1404895233;
			if (num != 0)
			{
			}
			num = (short)255393792;
			if (num != 0)
			{
			}
			num = (short)299565056;
			short num3 = num;
			global::AcpASKLib.AccessDataConverter.a(global::AcpASKLib.AccessElementIDType.OTAP_ELEMENT, ref A_0);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000034DC File Offset: 0x000016DC
		internal static global::AcpASKLib.AccessElementIDType a(global::AcpASKLib.AccessElementLegacyIDType A_0)
		{
			int a_ = 0;
			short num;
			if (!global::AcpASKLib.LegacyAccessElementMap.LegacyFieldMap.ContainsKey(A_0))
			{
				num = (short)1526573854;
				short num2 = num;
				num = (short)42052382;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)280428544;
					if (num != 0)
					{
					}
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᑜㅞᝠɢ।๦൨䭪Ⅼ੮ᙰቲᙴ๶奸㵺ᑼ᩾ꖄ캆춈", a_));
				}
			}
			num = (short)845086721;
			if (num != 0)
			{
			}
			num = (short)437256192;
			short num3 = num;
			return global::AcpASKLib.LegacyAccessElementMap.LegacyFieldMap[A_0];
		}
	}
}
