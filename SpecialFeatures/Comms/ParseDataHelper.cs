using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using AcpCommonLib;
using Common;
using CommonResources;
using Motorola.Acp.PackUnpack.Ish.Layouts;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.Security;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000175 RID: 373
	public static class ParseDataHelper
	{
		// Token: 0x0600128B RID: 4747 RVA: 0x001985F4 File Offset: 0x001967F4
		internal static string[] ReadRadioTrkSysNames(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection)
		{
			short num;
			string[] array2;
			for (;;)
			{
				num = (short)291176448;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)958726144;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					for (;;)
					{
						IL_51:
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
						switch (num2)
						{
						case 0:
							if (ishItemCollection != null)
							{
								num = (short)1058013185;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_46B;
						case 1:
							num = (short)1729363969;
							if (num != 0)
							{
							}
							num = (short)763035652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							try
							{
								num = (short)1933115394;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)56688648;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
										global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
										num = (short)714735620;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
									{
										global::Motorola.Common.Communication.CommonUtil.IshItem value;
										if (value.Data != null)
										{
											num = (short)1072365578;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_12E;
										}
										continue;
									case 3:
									{
										int num4;
										int num5;
										if (num4 >= num5)
										{
											num = (short)1847590918;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string[] array = array2;
										int num6 = num4;
										global::System.Text.Encoding bigEndianUnicode = global::System.Text.Encoding.BigEndianUnicode;
										global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
										global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
										int num7;
										int num8;
										array[num6] = bigEndianUnicode.GetString(value.Data, num7, num8);
										num7 += num8;
										num4++;
										num = (short)1382350860;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::Motorola.Common.Communication.CommonUtil.IshHeader key;
										if (key.IshType == 1080)
										{
											num = (short)1859125262;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										goto IL_133;
									case 6:
										num = (short)556597259;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_398;
									case 8:
										num = (short)25690119;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
									{
										int num5;
										array2 = new string[num5];
										int num7 = 19;
										global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
										global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
										int num9 = (int)value.Data[1] << 8;
										value = keyValuePair.Value;
										int num8 = num9 | (int)value.Data[2];
										int num4 = 0;
										num = (short)420151301;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
									{
										global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
										global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
										int num10 = (int)value.Data[5];
										value = keyValuePair.Value;
										byte b = value.Data[6];
										int num5 = num10 << 8 | (int)b;
										num = (short)1991311373;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
										goto IL_268;
									case 12:
										goto IL_133;
									case 13:
									{
										int num5;
										if (num5 < 255)
										{
											num = (short)752484361;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 14:
									{
										global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
										global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
										num = (short)801898497;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_12E;
									IL_133:
									num = (short)64487427;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_16C:
									num = (short)561643520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_12E:
									goto IL_16C;
								}
								IL_268:
								IL_398:
								goto IL_46D;
							}
							finally
							{
								num = (short)1715535872;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_3D0;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)567345154;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_408;
									}
									IL_3D0:
									if (enumerator == null)
									{
										break;
									}
									num = (short)942145537;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_408:;
							}
							goto IL_40B;
						case 3:
							goto IL_469;
						case 4:
							if (!ishItemCollection.Any<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>())
							{
								num = (short)1261895683;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_40B;
						}
						goto IL_6C;
						IL_40B:
						enumerator = ishItemCollection.GetEnumerator();
						num = (short)1419247618;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_46D:
					num = (short)893998868;
					short num11 = num;
					num = (short)2107070228;
					switch ((num11 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_4A2;
					}
					IL_6C:
					array2 = null;
					num = (short)18743296;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_51;
				}
				}
			}
			IL_469:
			IL_46B:
			return null;
			IL_4A2:
			num = (short)1272709120;
			if (num != 0)
			{
			}
			return array2;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00198AD8 File Offset: 0x00196CD8
		internal static void ReadRadioTrkSystemNamesAndIds(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection, out global::System.Collections.Generic.Dictionary<string, int> radioTrkSysNamesAndIdsWithAskReqOn, out global::System.Collections.Generic.Dictionary<string, int> radioTrkSysNamesAndIdsWithAskReqOff)
		{
			short num = (short)1610122059;
			short num2 = num;
			num = (short)243172171;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_121:
				num = (short)161742852;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)843382784;
				if (num != 0)
				{
				}
				num = (short)272498688;
				num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)665583616;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_B7;
					}
					break;
				}
				}
				break;
			}
			int num5;
			for (;;)
			{
				IL_9C:
				string[] array;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
				switch (num3)
				{
				case 0:
					if (ishItemCollection != null)
					{
						num = (short)123207681;
						if (num != 0)
						{
						}
						num = (short)2016477185;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_121;
				case 2:
					try
					{
						num = (short)409665536;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_17E;
								}
								continue;
							case 1:
								num = (short)100990979;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)602341382;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (array != null)
								{
									num = (short)2125398020;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 4:
								goto IL_3CD;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2102394882;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								keyValuePair = enumerator.Current;
								global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
								num = (short)1855651849;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_42F;
							case 7:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_2E5;
									}
									for (;;)
									{
										IL_2CA:
										switch (num3)
										{
										case 0:
										{
											if ((value.Data[130] & 4) > 0)
											{
												num = (short)752091137;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											int num6;
											radioTrkSysNamesAndIdsWithAskReqOff.Add(array[num5].TrimEnd(new char[1]), num6);
											num = (short)1017446404;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
										{
											int num6;
											radioTrkSysNamesAndIdsWithAskReqOn.Add(array[num5].TrimEnd(new char[1]), num6);
											num = (short)875757570;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
											goto IL_391;
										case 3:
											goto IL_3AA;
										case 4:
											goto IL_391;
										}
										goto IL_2E5;
										IL_391:
										num = (short)1380188163;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_3AA:
									goto IL_29F;
									IL_2E5:
									value = keyValuePair.Value;
									num = (short)2127757312;
									num3 = (int)((global::System.IntPtr)num);
									goto IL_2CA;
								}
								catch (global::System.Exception ex)
								{
									global::SpecialFeatures.Comms.Comms.DispalyUpdateStatusChanged(0.0, global::CommonResources.AppResources.Duplicate_Trunking_System_Strings);
									global::System.Exception innerException = ex.InnerException;
									return;
								}
								goto IL_3CD;
								IL_29F:
								num5++;
								num = (short)2040791051;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								value = keyValuePair.Value;
								int num7 = (int)value.Data[59];
								value = keyValuePair.Value;
								byte b = value.Data[60];
								int num6 = num7 << 8;
								num6 |= (int)b;
								num = (short)1131413511;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
							{
								global::Motorola.Common.Communication.CommonUtil.IshHeader key;
								if (key.IshType == 3852)
								{
									num = (short)76349441;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
								if (value.Data != null)
								{
									num = (short)1393426440;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							IL_1BA:
							num = (short)2146107397;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_17E:
							goto IL_1BA;
							IL_3CD:
							value = keyValuePair.Value;
							num = (short)264241162;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_42F:
						return;
					}
					finally
					{
						num = (short)1478295552;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_467;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)139788290;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_49E;
							}
							IL_467:
							if (enumerator == null)
							{
								break;
							}
							num = (short)119275521;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_49E:;
					}
					goto IL_4A1;
				case 3:
					goto IL_4A1;
				case 4:
					if (ishItemCollection.Count > 0)
					{
						num = (short)1531904003;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_B7;
				IL_4A1:
				array = global::SpecialFeatures.Comms.ParseDataHelper.ReadRadioTrkSysNames(ishItemCollection);
				enumerator = ishItemCollection.GetEnumerator();
				num = (short)2016542722;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_B7:
			radioTrkSysNamesAndIdsWithAskReqOff = new global::System.Collections.Generic.Dictionary<string, int>();
			radioTrkSysNamesAndIdsWithAskReqOn = new global::System.Collections.Generic.Dictionary<string, int>();
			num5 = 0;
			num = (short)2075983872;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_9C;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00199024 File Offset: 0x00197224
		internal static global::System.Collections.Generic.Dictionary<string, int[]> ReadRadioTrkSystemNamesTypesAndUnitIds(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection)
		{
			short num = (short)187970048;
			short num2 = num;
			num = (short)1706111488;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EF:
				num = (short)118226945;
				if (num != 0)
				{
				}
				num = (short)1808924676;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)737673216;
				if (num != 0)
				{
				}
				num = (short)895156224;
				num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)213319680;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_B7;
					}
					break;
				}
				}
				break;
			}
			global::System.Collections.Generic.Dictionary<string, int[]> dictionary;
			int num6;
			for (;;)
			{
				IL_9C:
				string[] array;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
				switch (num3)
				{
				case 0:
					if (ishItemCollection != null)
					{
						num = (short)496107521;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return dictionary;
				case 1:
					goto IL_EF;
				case 2:
					try
					{
						num = (short)1001652224;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value2;
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_172;
								}
								continue;
							case 1:
								num = (short)68091907;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)1799290886;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (array != null)
								{
									num = (short)2130051076;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 4:
								goto IL_346;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)71696386;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								keyValuePair = enumerator.Current;
								global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
								num = (short)529793033;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_3A9;
							case 7:
								try
								{
									byte b;
									int num5;
									int[] value = new int[]
									{
										(int)b,
										num5
									};
									dictionary.Add(array[num6], value);
									goto IL_2E6;
								}
								catch (global::System.Exception ex)
								{
									global::SpecialFeatures.Comms.Comms.DispalyUpdateStatusChanged(0.0, global::CommonResources.AppResources.Duplicate_Trunking_System_Strings);
									global::System.Exception innerException = ex.InnerException;
									return dictionary;
								}
								goto IL_346;
								IL_2E6:
								num6++;
								num = (short)1894973451;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								value2 = keyValuePair.Value;
								byte b = value2.Data[1];
								value2 = keyValuePair.Value;
								int num7 = (int)value2.Data[63];
								value2 = keyValuePair.Value;
								byte b2 = value2.Data[64];
								value2 = keyValuePair.Value;
								byte b3 = value2.Data[65];
								value2 = keyValuePair.Value;
								byte b4 = value2.Data[66];
								int num5 = num7 << 24;
								num5 |= (int)b2 << 16;
								num5 |= (int)b3 << 8;
								num5 |= (int)b4;
								num = (short)2114519047;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
							{
								global::Motorola.Common.Communication.CommonUtil.IshHeader key;
								if (key.IshType == 3852)
								{
									num = (short)1786445825;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
								if (value2.Data != null)
								{
									num = (short)1835008008;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							IL_1AC:
							num = (short)986513413;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_172:
							goto IL_1AC;
							IL_346:
							value2 = keyValuePair.Value;
							num = (short)565772298;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_3A9:
						return dictionary;
					}
					finally
					{
						num = (short)2089484288;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3E0;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)791412738;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_419;
							}
							IL_3E0:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1684275201;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_419:;
					}
					goto IL_41C;
				case 3:
					goto IL_41C;
				case 4:
					if (ishItemCollection.Count > 0)
					{
						num = (short)46399491;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return dictionary;
				}
				goto IL_B7;
				IL_41C:
				array = global::SpecialFeatures.Comms.ParseDataHelper.ReadRadioTrkSysNames(ishItemCollection);
				enumerator = ishItemCollection.GetEnumerator();
				num = (short)1795162114;
				num3 = (int)((global::System.IntPtr)num);
			}
			return dictionary;
			IL_B7:
			dictionary = new global::System.Collections.Generic.Dictionary<string, int[]>();
			num6 = 0;
			num = (short)845348864;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_9C;
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x001994EC File Offset: 0x001976EC
		internal static global::System.Collections.Generic.Dictionary<string, int[]> ReadConvSysIds(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)778895360;
			short num2 = num;
			num = (short)1837301760;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_69;
				}
				global::System.Collections.Generic.Dictionary<string, int[]> dictionary;
				string[] array;
				int num4;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_52:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num3)
					{
					case 0:
						try
						{
							num = (short)1905524736;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int[] value;
								byte b;
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_14F;
									}
									continue;
								case 1:
									try
									{
										dictionary.Add(array[num4], value);
										goto IL_154;
									}
									catch (global::System.Exception ex)
									{
										if (b == 0)
										{
											global::SpecialFeatures.Comms.Comms.DispalyUpdateStatusChanged(0.0, global::CommonResources.AppResources.Duplicate_ASTRO_Conventional_System_Strings);
										}
										else if (b == 2)
										{
											global::SpecialFeatures.Comms.Comms.DispalyUpdateStatusChanged(0.0, global::CommonResources.AppResources.Duplicate_DVRS_Conventional_System_Strings);
										}
										global::System.Exception innerException = ex.InnerException;
										return dictionary;
									}
									goto Block_10;
								case 2:
									if (b == 3)
									{
										num = (short)884932623;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_154;
								case 3:
									num = (short)763232270;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1087963152;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (b != 0)
									{
										num = (short)409403396;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_19E;
								case 6:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == 3868)
									{
										num = (short)1649999883;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									if (b == 1)
									{
										num = (short)428212234;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)948174850;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_19E;
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1603338243;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									keyValuePair = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									num = (short)2016804870;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									int num5 = (int)keyValuePair.Value.Data[20];
									byte b2 = keyValuePair.Value.Data[21];
									int num6 = num5 << 8;
									num6 |= (int)b2;
									int[] value2 = new int[]
									{
										(int)b,
										num6
									};
									num = (short)924975117;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									b = keyValuePair.Value.Data[1];
									num = (short)23527429;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_3DC;
								case 13:
									try
									{
										int[] value2;
										dictionary.Add(array[num4], value2);
										goto IL_154;
									}
									catch (global::System.Exception ex2)
									{
										global::SpecialFeatures.Comms.Comms.DispalyUpdateStatusChanged(0.0, global::CommonResources.AppResources.Duplicate_MDC_Conventional_System_Strings);
										global::System.Exception innerException2 = ex2.InnerException;
										return dictionary;
									}
									goto IL_19E;
								case 14:
									goto IL_544;
								case 15:
									goto IL_40A;
								case 16:
								{
									if (b != 2)
									{
										num = (short)57802759;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)787512731;
									short num7 = num;
									num = (short)945192347;
									switch ((num7 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_544;
									default:
										num = (short)1485045760;
										if (num != 0)
										{
										}
										num = (short)1794899976;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_14F;
								IL_154:
								num4++;
								num = (short)443088913;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_19E:
								int num8 = (int)keyValuePair.Value.Data[17];
								byte b3 = keyValuePair.Value.Data[18];
								byte b4 = keyValuePair.Value.Data[19];
								int num9 = num8 << 16;
								num9 |= (int)b3 << 8;
								num9 |= (int)b4;
								value = new int[]
								{
									(int)b,
									num9
								};
								num = (short)2085552129;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_222:
								num = (short)1328742409;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_14F:
								goto IL_222;
								IL_40A:
								int[] value3 = new int[]
								{
									(int)b,
									0
								};
								num = (short)646119436;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								Block_10:
								try
								{
									IL_3DC:
									dictionary.Add(array[num4], value3);
									goto IL_154;
								}
								catch (global::System.Exception ex3)
								{
									global::SpecialFeatures.Comms.Comms.DispalyUpdateStatusChanged(0.0, global::CommonResources.AppResources.Duplicate_MDC_Conventional_System_Strings);
									global::System.Exception innerException3 = ex3.InnerException;
									break;
								}
								goto IL_40A;
							}
							IL_544:
							return dictionary;
						}
						finally
						{
							num = (short)258080770;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_5B2;
								case 1:
									enumerator.Dispose();
									num = (short)1000275968;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_57B;
									}
									continue;
								}
								IL_57B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1961689089;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_5B2:;
						}
						goto IL_5B5;
					case 1:
						try
						{
							num = (short)1138229248;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_633;
									}
									continue;
								case 1:
									goto IL_749;
								case 2:
								{
									int num10;
									array = new string[num10];
									int num11 = 19;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair2;
									int num12 = (int)keyValuePair2.Value.Data[1] << 8;
									num12 |= (int)keyValuePair2.Value.Data[2];
									int num13 = 0;
									num = (short)1951989766;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair2;
									int num14 = (int)keyValuePair2.Value.Data[5];
									byte b5 = keyValuePair2.Value.Data[6];
									int num10 = num14 << 8;
									num10 |= (int)b5;
									num = (short)1747845124;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									int num10;
									if (num10 < 255)
									{
										num = (short)1525088258;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_74E;
								case 6:
									goto IL_74E;
								case 7:
									num = (short)1669922817;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1693843466;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair2 = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair2.Key;
									num = (short)593231884;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_857;
								case 10:
									num = (short)2070937609;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									int num10;
									int num13;
									if (num13 >= num10)
									{
										num = (short)156631047;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num11;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair2;
									int num12;
									array[num13] = global::System.Text.Encoding.BigEndianUnicode.GetString(keyValuePair2.Value.Data, num11, num12);
									num11 += num12;
									num13++;
									num = (short)56098821;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == 1076)
									{
										num = (short)1767309315;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_633;
								IL_74E:
								num = (short)448462859;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_78B:
								num = (short)1078263816;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_633:
								goto IL_78B;
							}
							IL_749:
							IL_857:;
						}
						finally
						{
							num = (short)1482948610;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_8C3;
								case 1:
									enumerator.Dispose();
									num = (short)817102848;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_88B;
									}
									continue;
								}
								IL_88B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)129957889;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_8C3:;
						}
						enumerator = codeplugInIshItemCollection.GetEnumerator();
						num = (short)194117632;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)772079617;
						if (num != 0)
						{
						}
						goto IL_5B5;
					case 3:
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)527564802;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					}
					goto IL_69;
					IL_5B5:
					enumerator = codeplugInIshItemCollection.GetEnumerator();
					num = (short)1194655745;
					num3 = (int)((global::System.IntPtr)num);
				}
				return dictionary;
				IL_69:
				dictionary = new global::System.Collections.Generic.Dictionary<string, int[]>();
				codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				array = new string[1];
				num4 = 0;
				num = (short)2085421059;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_52;
			}
			}
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00199E64 File Offset: 0x00198064
		internal static global::System.Collections.Generic.Dictionary<string, int> ReadAstroOtarRadioIds(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)100728832;
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
				global::System.Collections.Generic.Dictionary<string, int> dictionary;
				string[] array;
				int num5;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)1151860736;
						short num3 = num;
						try
						{
							num = (short)1273561095;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int num6;
								global::Motorola.Common.Communication.CommonUtil.IshHeader key;
								switch (num2)
								{
								case 0:
								{
									num = (short)2045977498;
									short num4 = num;
									num = (short)1571824538;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_198;
									default:
										num = (short)1378942976;
										if (num != 0)
										{
										}
										try
										{
											dictionary.Add(array[num5], num6);
											goto IL_19A;
										}
										catch (global::System.Exception ex)
										{
											global::SpecialFeatures.Comms.Comms.DispalyUpdateStatusChanged(0.0, global::CommonResources.AppResources.Duplicate_Secure_Kmf_Profile_Strings);
											global::System.Exception innerException = ex.InnerException;
											return dictionary;
										}
										goto IL_145;
										IL_19A:
										num5++;
										num = (short)1086455809;
										if (num != 0)
										{
										}
										num = (short)1500839941;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)2140209154;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_145;
								case 2:
									num = (short)1906704388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (key.IshType == 3859)
									{
										num = (short)937623558;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_30C;
								case 6:
									goto IL_198;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_DA;
									}
									continue;
								}
								IL_DF:
								num = (short)1553661953;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DA:
								goto IL_DF;
								IL_145:
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
								key = keyValuePair.Key;
								num = (short)397017091;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_198:
								int num7 = (int)keyValuePair.Value.Data[11] << 8;
								byte b = keyValuePair.Value.Data[12];
								int num8 = 18;
								int num9 = (int)keyValuePair.Value.Data[17] << 8;
								byte b2 = keyValuePair.Value.Data[18];
								num6 = (int)keyValuePair.Value.Data[num8 + 5] << 16;
								num6 |= (int)keyValuePair.Value.Data[num8 + 6] << 8;
								num6 |= (int)keyValuePair.Value.Data[num8 + 7];
								num = (short)2131427328;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_30C:
							return dictionary;
						}
						finally
						{
							num = (short)737476610;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_37D;
								case 1:
									enumerator.Dispose();
									num = (short)2134900736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_343;
									}
									continue;
								}
								IL_343:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1142751233;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_37D:;
						}
						goto IL_380;
					}
					case 1:
						try
						{
							num = (short)382140416;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3FC;
									}
									continue;
								case 1:
								{
									int num10;
									array = new string[num10];
									int num11 = 19;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair2;
									int num12 = (int)keyValuePair2.Value.Data[1] << 8;
									num12 |= (int)keyValuePair2.Value.Data[2];
									int num13 = 0;
									num = (short)763166725;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)2094268426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair2;
									int num14 = (int)keyValuePair2.Value.Data[5];
									byte b3 = keyValuePair2.Value.Data[6];
									int num10 = num14 << 8;
									num10 |= (int)b3;
									num = (short)1475477510;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									int num10;
									int num13;
									if (num13 >= num10)
									{
										num = (short)522125314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num11;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair2;
									int num12;
									array[num13] = global::System.Text.Encoding.BigEndianUnicode.GetString(keyValuePair2.Value.Data, num11, num12);
									num11 += num12;
									num13++;
									num = (short)1732509707;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_5C9;
								case 6:
								{
									int num10;
									if (num10 < 255)
									{
										num = (short)1073348609;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)446824456;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair2 = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair2.Key;
									num = (short)2041184268;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1201733641;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_61F;
								case 10:
									goto IL_5C4;
								case 11:
									goto IL_5C9;
								case 12:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == 1084)
									{
										num = (short)420937731;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_56C:
								num = (short)679411719;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3FC:
								goto IL_56C;
								IL_5C9:
								num = (short)690814980;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5C4:
							IL_61F:;
						}
						finally
						{
							num = (short)138084354;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_68C;
								case 1:
									enumerator.Dispose();
									num = (short)1695023104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_653;
									}
									continue;
								}
								IL_653:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1596391425;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_68C:;
						}
						enumerator = codeplugInIshItemCollection.GetEnumerator();
						num = (short)1496449024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_380;
					case 3:
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)1029767170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					}
					goto IL_3F;
					IL_380:
					enumerator = codeplugInIshItemCollection.GetEnumerator();
					num = (short)535101441;
					num2 = (int)((global::System.IntPtr)num);
				}
				return dictionary;
				IL_3F:
				dictionary = new global::System.Collections.Generic.Dictionary<string, int>();
				codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				array = new string[1];
				num5 = 0;
				num = (short)2097283075;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0019A59C File Offset: 0x0019879C
		internal static global::System.Collections.Generic.Dictionary<string, bool> IsRadioKilled(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			int a_ = 4;
			short num = (short)1708589056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				global::System.Collections.Generic.Dictionary<string, bool> dictionary;
				int num5;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_30:
					num = (short)1437138944;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1479081993;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == 1026)
									{
										num = (short)937754628;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)537788419;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									num = (short)611647488;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)301465606;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									num = (short)83886087;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									string key2;
									dictionary.Add(key2, true);
									num = (short)969146369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_27B;
								case 7:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItem value;
									int num4 = (value.Data[num5] & 2) >> 1;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									string key2 = key.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꮆꦈ슊ꢔꚖꆘ", a_);
									if (num4 == 1)
									{
										num = (short)171245573;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									dictionary.Add(key2, false);
									num = (short)605224968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_10C;
									}
									continue;
								}
								IL_10E:
								num = (short)629669890;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10C:
								goto IL_10E;
							}
							IL_27B:
							return dictionary;
						}
						finally
						{
							num = (short)1107492866;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_363;
								case 1:
									goto IL_344;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2B3;
									}
									continue;
								}
								IL_2B3:
								num = (short)1117882994;
								short num6 = num;
								num = (short)751864434;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_344:
									enumerator.Dispose();
									num = (short)473169920;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)1620639745;
									if (num != 0)
									{
									}
									num = (short)1738670080;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_365;
									}
									num = (short)543883265;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_363:
							IL_365:;
						}
						goto IL_366;
					case 1:
						goto IL_366;
					case 2:
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)888078337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					}
					goto IL_6C;
					IL_366:
					enumerator = codeplugInIshItemCollection.GetEnumerator();
					num = (short)1083834368;
					num2 = (int)((global::System.IntPtr)num);
				}
				return dictionary;
				IL_6C:
				num5 = 19;
				dictionary = new global::System.Collections.Generic.Dictionary<string, bool>();
				codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				num = (short)1780416514;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0019A954 File Offset: 0x00198B54
		internal static global::System.Collections.Generic.Dictionary<string, int> ReadCustomerID(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			int a_ = 18;
			short num = (short)512098304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::System.Collections.Generic.Dictionary<string, int> dictionary;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1477181446;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_27D;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)316080135;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									num = (short)1849229317;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									int num3 = (int)value.Data[14];
									value = keyValuePair.Value;
									byte b = value.Data[15];
									int num4 = num3 << 8;
									num4 |= (int)b;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									string key2 = key.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릔랖킘列爵\ud9a0麢钤钦", a_);
									dictionary.Add(key2, num4);
									num = (short)752222211;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItem value;
									if (value.Data != null)
									{
										num = (short)980221954;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == 1030)
									{
										num = (short)993918984;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_100;
									}
									continue;
								case 7:
									num = (short)990314496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									num = (short)1531969540;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_105:
								num = (short)1370554369;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_100:
								goto IL_105;
							}
							IL_27D:
							return dictionary;
						}
						finally
						{
							num = (short)552599553;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1808918747;
									short num5 = num;
									num = (short)1711991003;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2D1;
									default:
										goto IL_324;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2B6;
									}
									continue;
								case 2:
									goto IL_2D1;
								}
								IL_2B6:
								if (enumerator != null)
								{
									num = (short)1525219330;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_33C;
								IL_2D1:
								enumerator.Dispose();
								num = (short)272171008;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_324:
							num = (short)2144272384;
							if (num != 0)
							{
							}
							IL_33C:;
						}
						goto IL_33D;
					case 1:
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)981532673;
							if (num != 0)
							{
							}
							num = (short)1496514562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					case 2:
						goto IL_33D;
					}
					goto IL_43;
					IL_33D:
					num = (short)283705344;
					short num6 = num;
					enumerator = codeplugInIshItemCollection.GetEnumerator();
					num = (short)463405056;
					num2 = (int)((global::System.IntPtr)num);
				}
				return dictionary;
				IL_43:
				dictionary = new global::System.Collections.Generic.Dictionary<string, int>();
				codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				num = (short)1367146497;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0019AD0C File Offset: 0x00198F0C
		internal static global::System.Collections.Generic.Dictionary<string, bool> IsRadioInhibitedTrunking(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			int a_ = 17;
			short num = (short)91881472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::System.Collections.Generic.Dictionary<string, bool> dictionary;
				int num3;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1119354887;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									string key;
									dictionary.Add(key, true);
									num = (short)16711683;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1583677448;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key2 = keyValuePair.Key;
									num = (short)301203462;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_271;
								case 5:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItem value;
									bool flag = (value.Data[num3] & 16) >> 4 != 0;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key2 = keyValuePair.Key;
									string key = key2.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢓뚕톗ﮝ\ud89f龡隣隥", a_);
									if (flag)
									{
										num = (short)448987136;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									dictionary.Add(key, false);
									num = (short)465436673;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key2;
									if (key2.IshType == 1026)
									{
										num = (short)289144841;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_103;
									}
									continue;
								case 8:
									num = (short)1923678212;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									num = (short)227016709;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_105:
								num = (short)1708064770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_103:
								goto IL_105;
							}
							IL_271:
							return dictionary;
						}
						finally
						{
							num = (short)2039676929;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)78641226;
									short num4 = num;
									num = (short)519698506;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2C4;
									default:
										goto IL_319;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2A8;
									}
									continue;
								case 2:
									goto IL_2C4;
								}
								IL_2A8:
								if (enumerator != null)
								{
									num = (short)781058050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_331;
								IL_2C4:
								enumerator.Dispose();
								num = (short)1390018560;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_319:
							num = (short)287244288;
							if (num != 0)
							{
							}
							IL_331:;
						}
						goto IL_332;
					case 1:
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)122683394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					case 2:
						num = (short)1214119937;
						if (num != 0)
						{
						}
						goto IL_332;
					}
					goto IL_43;
					IL_332:
					num = (short)1751908352;
					short num5 = num;
					enumerator = codeplugInIshItemCollection.GetEnumerator();
					num = (short)858390528;
					num2 = (int)((global::System.IntPtr)num);
				}
				return dictionary;
				IL_43:
				num3 = 21;
				dictionary = new global::System.Collections.Generic.Dictionary<string, bool>();
				codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				num = (short)796983297;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0019B0B8 File Offset: 0x001992B8
		internal static global::SpecialFeatures.Comms.DataProfIP[] ReadDataProfIPaddr(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			int a_ = 14;
			short num = (short)1419771904;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				string[] array2;
				global::Motorola.Common.Communication.CommonUtil.IshHeader key;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1218576394;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									int num3;
									int num4;
									if (num3 >= num4)
									{
										num = (short)2015166465;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string[] array = array2;
									int num5 = num3;
									global::System.Text.Encoding bigEndianUnicode = global::System.Text.Encoding.BigEndianUnicode;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									int num6;
									int num7;
									array[num5] = bigEndianUnicode.GetString(value.Data, num6, num7);
									num6 += num7;
									num3++;
									num = (short)97648644;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)535953413;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (key.IshType == 1073)
									{
										num = (short)997982220;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									num = (short)1327038473;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_347;
								case 5:
									goto IL_398;
								case 6:
								{
									int num4;
									if (num4 < 255)
									{
										num = (short)62455815;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									int num4;
									array2 = new string[num4];
									int num6 = 19;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									int num7 = (int)value.Data[1] << 8;
									int num8 = num7;
									value = keyValuePair.Value;
									num7 = (num8 | (int)value.Data[2]);
									int num3 = 0;
									num = (short)85458955;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1427505155;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									key = keyValuePair.Key;
									num = (short)377028610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_3B5;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_196;
									}
									continue;
								case 11:
									goto IL_347;
								case 12:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									int num9 = (int)value.Data[5];
									value = keyValuePair.Value;
									byte b = value.Data[6];
									int num4 = num9 << 8;
									num4 |= (int)b;
									num = (short)1918828550;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_19B:
								num = (short)732364808;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_196:
								goto IL_19B;
								IL_347:
								num = (short)474808320;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_398:
							IL_3B5:
							goto IL_115;
						}
						finally
						{
							num = (short)1966342145;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_426;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3ED;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1116667904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3ED:
								if (enumerator == null)
								{
									break;
								}
								num = (short)976355330;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_426:;
						}
						goto Block_3;
						IL_115:
						enumerator = codeplugInIshItemCollection.GetEnumerator();
						num = (short)362283011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						enumerator = codeplugInIshItemCollection.GetEnumerator();
						num = (short)1027670016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)1105395713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10B4;
					case 3:
						goto IL_136;
					case 4:
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)1035206661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1037;
					case 5:
						goto IL_110;
					case 6:
						goto IL_1032;
					}
					goto IL_53;
				}
				IL_110:
				goto IL_1011;
				IL_136:
				goto IL_5FA;
				IL_53:
				num = (short)80694583;
				short num10 = num;
				num = (short)650661175;
				int num11;
				switch ((num10 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1032:
					break;
				default:
					num = (short)619905024;
					if (num != 0)
					{
					}
					num = (short)1564016641;
					if (num != 0)
					{
					}
					codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
					num11 = 0;
					num = (short)1027407876;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				Block_3:
				try
				{
					num = (short)848756742;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_588;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)828506119;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair2 = enumerator.Current;
							key = keyValuePair2.Key;
							num = (short)1090060291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (key.IshType != 3923)
							{
								num = (short)633667588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_54D;
						case 4:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair2;
							key = keyValuePair2.Key;
							num = (short)67502085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							if (key.IshType == 1027)
							{
								num = (short)1848573960;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_473;
							}
							continue;
						case 7:
							num = (short)861470720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_54D;
						}
						IL_475:
						num = (short)1709572097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_473:
						goto IL_475;
						IL_54D:
						num11++;
						num = (short)1548615682;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_588:
					goto IL_1037;
				}
				finally
				{
					num = (short)491847681;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_5F7;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_5BF;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)347799552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_5BF:
						if (enumerator == null)
						{
							break;
						}
						num = (short)744357890;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5F7:;
				}
				int num12;
				ulong num13;
				global::SpecialFeatures.Comms.DataProfIP[] array3;
				int num14;
				try
				{
					IL_5FA:
					num = (short)630980646;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.Communication.CommonUtil.IshItem value;
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair3;
						switch (num2)
						{
						case 0:
							goto IL_A45;
						case 1:
							goto IL_E3E;
						case 2:
							if (num12 == 2)
							{
								num = (short)1187381281;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)568655882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::System.Net.IPAddress subIP = new global::System.Net.IPAddress((long)num13);
							array3[num11 - 1].SubIP = subIP;
							num12 = 20;
							num13 = 0UL;
							array3[num11 - 1].DataProfName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햐캘列爵", a_);
							num = (short)1695875113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							if (num12 >= 206)
							{
								num = (short)1179713580;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B28;
						case 6:
							goto IL_F9E;
						case 7:
							if (value.Data.Length > 189)
							{
								num = (short)2082340889;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num12 = 206;
							num = (short)1397293070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (num12 == 135)
							{
								num = (short)304414749;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1650130978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							num = (short)2070282246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (num12 == 18)
							{
								num = (short)1667891219;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)192937992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_B28;
						case 12:
						{
							global::System.Net.IPAddress btpeerIP = new global::System.Net.IPAddress((long)num13);
							array3[num11 - 1].BTPeerIP = btpeerIP;
							num12 = 108;
							num13 = 0UL;
							num = (short)1112932352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							goto IL_E3E;
						case 14:
							goto IL_792;
						case 15:
							goto IL_949;
						case 16:
							if (num12 == 205)
							{
								num = (short)1280901142;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E3E;
						case 17:
							if (num12 == 20)
							{
								num = (short)1799815194;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1479082011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							goto IL_A45;
						case 19:
						{
							global::System.Net.IPAddress peerIP = new global::System.Net.IPAddress((long)num13);
							array3[num14].PeerIP = peerIP;
							num12 = 135;
							num13 = 0UL;
							num = (short)961871873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
							if (value.Data.Length > 91)
							{
								num = (short)1521418288;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num12 = 108;
							num = (short)1278607384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
						{
							global::System.Net.IPAddress btpeerIP2 = new global::System.Net.IPAddress((long)num13);
							array3[num14].BTPeerIP = btpeerIP2;
							num12 = 206;
							num13 = 0UL;
							num = (short)1755840551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							goto IL_A45;
						case 24:
							goto IL_949;
						case 25:
							num12 = 189;
							num = (short)188022824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
						{
							global::System.Net.IPAddress peerIP2 = new global::System.Net.IPAddress((long)num13);
							array3[num11 - 1].PeerIP = peerIP2;
							value = keyValuePair3.Value;
							num = (short)643170324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 27:
							if (num12 == 91)
							{
								num = (short)961675306;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2132344878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							if (key.IshType == 3923)
							{
								num = (short)1377828895;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							key = keyValuePair3.Key;
							num = (short)1470234654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
						{
							global::System.Net.IPAddress subIP2 = new global::System.Net.IPAddress((long)num13);
							array3[num14].SubIP = subIP2;
							value = keyValuePair3.Value;
							num = (short)1549205511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 30:
							if (key.IshType == 1027)
							{
								num = (short)425852977;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 31:
							num12 = 2;
							num = (short)527302667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							goto IL_EC0;
						case 33:
						{
							global::System.Net.IPAddress subAirInterfaceIP = new global::System.Net.IPAddress((long)num13);
							array3[num14].SubAirInterfaceIP = subAirInterfaceIP;
							num12 = 18;
							num13 = 0UL;
							array3[num14].DataProfName = array2[num14];
							num = (short)1949040685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 34:
							if (num12 == 189)
							{
								num = (short)2042822703;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)702152720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 35:
							if (!enumerator.MoveNext())
							{
								num = (short)1758593033;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							keyValuePair3 = enumerator.Current;
							key = keyValuePair3.Key;
							num = (short)1833762844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							goto IL_E3E;
						case 37:
							if (num12 >= 108)
							{
								num = (short)1495007253;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EC0;
						case 38:
							switch (0)
							{
							case 0:
								goto IL_6E9;
							}
							continue;
						case 39:
							goto IL_E3E;
						case 40:
							goto IL_792;
						case 41:
							goto IL_A45;
						case 42:
						{
							global::System.Net.IPAddress btsubIP = new global::System.Net.IPAddress((long)num13);
							array3[num11 - 1].BTSubIP = btsubIP;
							num12 = 107;
							num13 = 0UL;
							num = (short)1698299922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 43:
							if (num12 == 4)
							{
								num = (short)1713176579;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1260257297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
							num14++;
							num = (short)1842741252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 45:
							goto IL_E3E;
						case 46:
							if (num12 == 107)
							{
								num = (short)1586626572;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A45;
						case 47:
						{
							global::System.Net.IPAddress btsubIP2 = new global::System.Net.IPAddress((long)num13);
							array3[num14].BTSubIP = btsubIP2;
							num12 = 205;
							num13 = 0UL;
							num = (short)597360676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 48:
							num12 = 91;
							num = (short)1841299471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 49:
							num12 = 4;
							num = (short)627114016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E9;
						IL_792:
						num13 = 0UL;
						num = (short)1569456141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_949:
						num13 = 0UL;
						num = (short)1035141143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A45:
						num = (short)1239023653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B28:
						value = keyValuePair3.Value;
						byte b2 = value.Data[num12 + 12];
						value = keyValuePair3.Value;
						byte b3 = value.Data[num12 + 13];
						value = keyValuePair3.Value;
						byte b4 = value.Data[num12 + 14];
						value = keyValuePair3.Value;
						byte b5 = value.Data[num12 + 15];
						num13 |= (ulong)b5 << 24;
						num13 |= (ulong)b4 << 16;
						num13 |= (ulong)b3 << 8;
						num13 |= (ulong)b2;
						num = (short)1760952322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D53:
						num = (short)189661219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6E9:
						goto IL_D53;
						IL_E3E:
						num = (short)1393295365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_EC0:
						value = keyValuePair3.Value;
						byte b6 = value.Data[num12 + 12];
						value = keyValuePair3.Value;
						byte b7 = value.Data[num12 + 13];
						value = keyValuePair3.Value;
						byte b8 = value.Data[num12 + 14];
						value = keyValuePair3.Value;
						byte b9 = value.Data[num12 + 15];
						num13 |= (ulong)b9 << 24;
						num13 |= (ulong)b8 << 16;
						num13 |= (ulong)b7 << 8;
						num13 |= (ulong)b6;
						num = (short)800456747;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_F9E:
					goto IL_10B4;
				}
				finally
				{
					num = (short)515047426;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_100E;
						case 1:
							enumerator.Dispose();
							num = (short)1206714368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_FD5;
							}
							continue;
						}
						IL_FD5:
						if (enumerator == null)
						{
							break;
						}
						num = (short)818020353;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_100E:;
				}
				IL_1011:
				enumerator = codeplugInIshItemCollection.GetEnumerator();
				num = (short)815988742;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
				IL_1037:
				array3 = new global::SpecialFeatures.Comms.DataProfIP[num11];
				num14 = 0;
				num12 = 2;
				array2 = new string[1];
				num13 = 0UL;
				num = (short)778895362;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
				IL_10B4:
				num = (short)374669312;
				short num15 = num;
				return array3;
			}
			}
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0019C1F0 File Offset: 0x0019A3F0
		internal static string[] ReadSoftId(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)1748959232;
			short num2 = num;
			num = (short)1840709632;
			switch (num)
			{
			default:
			{
				num = (short)157483009;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				string[] array = new string[4];
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)1596129286;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1093)
							{
								num = (short)384237570;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							key = keyValuePair.Key;
							num = (short)1013186570;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							int index = 2;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							int count = (int)value.Data[1];
							string[] array2 = array;
							int num4 = 0;
							global::System.Text.Encoding ascii = global::System.Text.Encoding.ASCII;
							value = keyValuePair.Value;
							array2[num4] = ascii.GetString(value.Data, index, count);
							num = (short)1688403979;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1313079301;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)1063321600;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)521011212;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_EB;
							}
							continue;
						case 7:
						{
							string[] array3 = array;
							int num5 = 2;
							global::System.Text.Encoding bigEndianUnicode = global::System.Text.Encoding.BigEndianUnicode;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							int num6;
							int num7;
							array3[num5] = bigEndianUnicode.GetString(value.Data, num6, num7);
							num = (short)709099521;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							int index2 = 3;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							int count2 = (int)(value.Data[2] * 2);
							string[] array4 = array;
							int num8 = 3;
							global::System.Text.Encoding bigEndianUnicode2 = global::System.Text.Encoding.BigEndianUnicode;
							value = keyValuePair.Value;
							array4[num8] = bigEndianUnicode2.GetString(value.Data, index2, count2);
							num = (short)1333854211;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							int num6 = 103;
							int num7 = 32;
							string[] array5 = array;
							int num9 = 1;
							global::System.Text.Encoding bigEndianUnicode3 = global::System.Text.Encoding.BigEndianUnicode;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							array5[num9] = bigEndianUnicode3.GetString(value.Data, num6, num7);
							num6 = 155;
							num7 = 32;
							value = keyValuePair.Value;
							num = (short)65798158;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1028)
							{
								num = (short)1777729545;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							key = keyValuePair.Key;
							num = (short)2083717133;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							goto IL_3AA;
						case 13:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1146)
							{
								num = (short)1782906888;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 14:
						{
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							int num6;
							int num7;
							if (value.Data.Length > num6 + num7)
							{
								num = (short)1194393607;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_240:
						num = (short)1015939076;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_EB:
						goto IL_240;
					}
					IL_3AA:;
				}
				finally
				{
					num = (short)888537089;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_419;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_3E1;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)1309343744;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_3E1:
						if (enumerator != null)
						{
							num = (short)282656770;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_419:
						num = (short)294384824;
						short num10 = num;
						num = (short)1070527672;
						switch ((num10 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_44F;
						}
					}
					IL_44F:
					num = (short)2049769472;
					if (num != 0)
					{
					}
				}
				return array;
			}
			}
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0019C680 File Offset: 0x0019A880
		internal static string ReadBluetoothFriendlyName(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)1765474304;
			switch (num)
			{
			default:
			{
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				string result = null;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)1598029830;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_204;
						case 1:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							num = (short)289013763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)1638006784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							if (value.Data.Length > 7)
							{
								num = (short)598081540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							int index = 6;
							int count = 28;
							global::System.Text.Encoding encoding = new global::System.Text.UnicodeEncoding(true, true, true);
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							result = encoding.GetString(value.Data, index, count);
							num = (short)1207697418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							if (value.Data != null)
							{
								num = (short)928251912;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_80;
							}
							continue;
						case 7:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1137)
							{
								num = (short)1072824321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)1906114567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)844496898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							num = (short)188350469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_C9:
						num = (short)1022033929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_80:
						goto IL_C9;
					}
					IL_204:;
				}
				finally
				{
					num = (short)1649737729;
					if (num != 0)
					{
					}
					num = (short)578945025;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_299;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_261;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)918552576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_261:
						if (enumerator != null)
						{
							num = (short)2057699330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_299:
						num = (short)418161950;
						short num3 = num;
						num = (short)1146594590;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_2CD;
						}
					}
					IL_2CD:
					num = (short)1441398784;
					if (num != 0)
					{
					}
				}
				num = (short)220790784;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0019C9B8 File Offset: 0x0019ABB8
		public static bool ReadEncryptPasswordFlag(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)390463488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1301151745;
				if (num != 0)
				{
				}
				num = (short)617545728;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				bool result;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_79:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)384761861;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_251;
								case 1:
									num = (short)47775744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItem value;
									int num4;
									if ((value.Data[num4] & 1) != 0)
									{
										num = (short)220397571;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									result = false;
									num = (short)202702855;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									result = true;
									num = (short)1503002633;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									int num4 = 1;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									num = (short)680722434;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_11F;
									}
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1793654785;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									num = (short)1711144968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_1C5;
								case 8:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == 903)
									{
										num = (short)1141243908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									goto IL_1E5;
								}
								IL_121:
								num = (short)1659174918;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11F:
								goto IL_121;
							}
							IL_1C5:
							IL_1E5:
							IL_251:
							return result;
						}
						finally
						{
							num = (short)539754497;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2C1;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_288;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1121583104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_288:
								if (enumerator != null)
								{
									num = (short)978321410;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2C1:
								num = (short)578015625;
								short num5 = num;
								num = (short)1134612873;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_2F5;
								}
							}
							IL_2F5:
							num = (short)126877696;
							if (num != 0)
							{
							}
						}
						goto IL_30B;
					case 1:
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)1132789762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						goto IL_30B;
					}
					goto IL_8C;
					IL_30B:
					enumerator = codeplugInIshItemCollection.GetEnumerator();
					num = (short)454754304;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_8C:
				codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				result = false;
				num = (short)644612097;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_79;
			}
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0019CD14 File Offset: 0x0019AF14
		internal static string ReadEncryptPassword(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)2111373312;
			short num2 = num;
			num = (short)664731648;
			switch (num)
			{
			default:
			{
				num = (short)1055981569;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				string result = string.Empty;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)1416429571;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_19A;
						case 1:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1150)
							{
								num = (short)49348613;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_1B8;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_C5;
							}
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)800718854;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)1173094401;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							int sourceIndex = 1;
							int num4 = 48;
							byte[] array = new byte[num4];
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex, array, 0, num4);
							result = global::Common.AESCryptoUtil.HEXString(array);
							num = (short)1449984000;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)1678770178;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_110:
						num = (short)1558315012;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C5:
						goto IL_110;
					}
					IL_19A:
					IL_1B8:;
				}
				finally
				{
					num = (short)587333633;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_229;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1EF;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)796065792;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1EF:
						if (enumerator != null)
						{
							num = (short)1598488578;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_229:
						num = (short)1585837944;
						short num5 = num;
						num = (short)1885730680;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_25F;
						}
					}
					IL_25F:
					num = (short)573964288;
					if (num != 0)
					{
					}
				}
				return result;
			}
			}
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0019CFB4 File Offset: 0x0019B1B4
		internal static int ReadTxPowerLevelsCFGType(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)206110720;
			short num2 = num;
			num = (short)624885760;
			switch (num)
			{
			default:
			{
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				int result = -1;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)1789984771;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_153;
						case 1:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1026)
							{
								num = (short)1842806789;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_170;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_97;
							}
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1900675078;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)488439809;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							int num4 = 129;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							result = (int)keyValuePair.Value.Data[num4];
							num = (short)2101673984;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)2009464834;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E3:
						num = (short)1990000644;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_97:
						goto IL_E3;
					}
					IL_153:
					IL_170:;
				}
				finally
				{
					num = (short)2088763393;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_1DF;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1A7;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)1151270912;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1A7:
						if (enumerator != null)
						{
							num = (short)635043842;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1DF:
						num = (short)2146451215;
						short num5 = num;
						num = (short)1971404559;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_216;
						}
					}
					IL_216:
					num = (short)610205696;
					if (num != 0)
					{
					}
				}
				num = (short)878837761;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0019D234 File Offset: 0x0019B434
		internal static bool GetIshItemPCICapable(global::Motorola.Common.Communication.Pba.PbaObject pba, int nOffset, int nValue)
		{
			short num = (short)795017216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)34340865;
				if (num != 0)
				{
				}
				num = (short)743047168;
				short num3 = num;
				int num4 = 2;
				bool result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_93;
					}
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
					for (;;)
					{
						IL_7C:
						switch (num2)
						{
						case 0:
							if (codeplugInIshItemCollection.Count > 0)
							{
								num = (short)742653954;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_346;
						case 1:
							goto IL_361;
						case 2:
						{
							global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
							num = (short)797114371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							try
							{
								num = (short)251985925;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_2D9;
									case 1:
									{
										global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1789198344;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
										global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
										num = (short)75563017;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										num = (short)1524957188;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										num = (short)1493881805;
										short num5 = num;
										num = (short)1338758093;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											continue;
										default:
											goto IL_2A5;
										}
										break;
									}
									case 4:
									{
										global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
										if (nOffset + num4 >= keyValuePair.Value.Data.Length)
										{
											num = (short)1710751751;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										result = (((int)keyValuePair.Value.Data[nOffset] & nValue) != 0);
										num = (short)726532102;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										switch (0)
										{
										case 0:
											goto IL_140;
										}
										continue;
									case 6:
										goto IL_170;
									case 7:
										result = false;
										num = (short)897712131;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										num = (short)458096640;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
									{
										global::Motorola.Common.Communication.CommonUtil.IshHeader key;
										if (key.IshType == 903)
										{
											num = (short)223477762;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_175:
									num = (short)862912513;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_140:
									goto IL_175;
								}
								IL_170:
								return result;
								IL_2A5:
								num = (short)1329070080;
								if (num != 0)
								{
								}
								return result;
								IL_2D9:;
							}
							finally
							{
								num = (short)1742405634;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1421672449;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_343;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_30E;
										}
										continue;
									}
									IL_30E:
									if (enumerator == null)
									{
										break;
									}
									num = (short)497745920;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_343:;
							}
							goto IL_346;
						}
						goto IL_93;
						IL_346:
						result = false;
						num = (short)277807105;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_361:
					return result;
					IL_93:
					codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
					num = (short)621084672;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_7C;
				}
				catch
				{
					result = false;
				}
				return result;
			}
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0019D5E0 File Offset: 0x0019B7E0
		internal static byte[] GetFDB(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)1423114240;
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
				byte[] result;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_27E;
					case 1:
						try
						{
							num = (short)1449721862;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1A6;
								case 1:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == 901)
									{
										num = (short)965607428;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										goto IL_10F;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									num = (short)1489305601;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									num = (short)1699898568;
									short num3 = num;
									num = (short)1731421384;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_10F;
									default:
										num = (short)1274150912;
										if (num != 0)
										{
										}
										num = (short)1505034245;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									result = keyValuePair.Value.Data;
									num = (short)548929536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_20E;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_EF;
									}
									continue;
								}
								IL_F1:
								num = (short)1562181634;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EF:
								goto IL_F1;
								IL_10F:
								num = (short)1343619075;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1A6:
							IL_20E:
							return result;
						}
						finally
						{
							num = (short)703987714;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1561985025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_27B;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_245;
									}
									continue;
								}
								IL_245:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1926561792;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_27B:;
						}
						goto IL_27E;
					case 2:
						num = (short)939196417;
						if (num != 0)
						{
						}
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)757727232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_3B;
					IL_27E:
					num = (short)467795968;
					short num4 = num;
					enumerator = codeplugInIshItemCollection.GetEnumerator();
					num = (short)909639681;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_3B:
				result = new byte[0];
				codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				num = (short)1648558082;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0019D8D8 File Offset: 0x0019BAD8
		internal static global::Motorola.Common.Communication.CommonUtil.IshItem GetBlockIshItem(global::Motorola.Common.Communication.Pba.PbaObject pba, ushort itemID)
		{
			short num = (short)1878917120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::Motorola.Common.Communication.CommonUtil.IshItem result;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_243;
					case 1:
						num = (short)2015232001;
						if (num != 0)
						{
						}
						try
						{
							num = (short)225050630;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_16A;
								case 1:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == itemID)
									{
										num = (short)1836056580;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										goto IL_E7;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									num = (short)2034040833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									num = (short)1029691604;
									short num3 = num;
									num = (short)1525078228;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_E7;
									default:
										num = (short)1940586496;
										if (num != 0)
										{
										}
										num = (short)751501317;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									result = keyValuePair.Value;
									num = (short)31064064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_1D4;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_C8;
									}
									continue;
								}
								IL_CA:
								num = (short)1591279618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C8:
								goto IL_CA;
								IL_E7:
								num = (short)928645123;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_16A:
							IL_1D4:
							return result;
						}
						finally
						{
							num = (short)1560674306;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1995702273;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_240;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_20B;
									}
									continue;
								}
								IL_20B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)784924672;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_240:;
						}
						goto IL_243;
					case 2:
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)1065811968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_3A;
					IL_243:
					enumerator = codeplugInIshItemCollection.GetEnumerator();
					num = (short)1000865792;
					short num4 = num;
					num = (short)1125318657;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_3A:
				result = default(global::Motorola.Common.Communication.CommonUtil.IshItem);
				codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				num = (short)1473904642;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0019DBBC File Offset: 0x0019BDBC
		internal static global::Motorola.Common.Communication.CommonUtil.IshItemCollection UpdateBlockIshItem(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItems, global::Motorola.Common.Communication.CommonUtil.IshItem blockItem, byte partition, ushort blockType)
		{
			short num = (short)1740832768;
			switch (num)
			{
			default:
			{
				num = (short)1104150538;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						bool flag;
						if (flag)
						{
							num = (short)1277296644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return ishItems;
					}
					case 1:
						num = (short)53805063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return ishItems;
					case 3:
						if (ishItems.Count > 0)
						{
							num = (short)222167049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return ishItems;
					case 4:
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, blockType, 0);
						ishItems.Remove(ishHeader);
						ishItems.Add(ishHeader, blockItem);
						num = (short)850526210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)177602560;
						short num3 = num;
						goto IL_256;
					}
					case 6:
						return ishItems;
					case 7:
						if (ishItems.Count > 0)
						{
							num = (short)16384005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return ishItems;
					case 8:
						try
						{
							num = (short)104726534;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.Communication.CommonUtil.IshHeader key;
								switch (num2)
								{
								case 0:
									goto IL_17C;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1542389764;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									key = keyValuePair.Key;
									num = (short)349962242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_103;
								case 3:
								{
									bool flag = true;
									num = (short)1596194816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									num = (short)355297103;
									short num4 = num;
									num = (short)1673422671;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_103;
									default:
										num = (short)920846336;
										if (num != 0)
										{
										}
										num = (short)165478405;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_1E5;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_DA;
									}
									continue;
								}
								goto IL_DA;
								IL_103:
								if (key.IshType == blockType)
								{
									num = (short)1844707331;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_124:
								num = (short)353763329;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DA:
								goto IL_124;
							}
							IL_17C:
							IL_1E5:
							goto IL_32F;
						}
						finally
						{
							num = (short)1114636290;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)421920769;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_253;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_21D;
									}
									continue;
								}
								IL_21D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)32964608;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_253:;
						}
						goto IL_256;
						IL_32F:
						num = (short)1125187584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						bool flag = false;
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = ishItems.GetEnumerator();
						num = (short)1641545729;
						if (num != 0)
						{
						}
						num = (short)671612936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					}
					IL_71:
					if (blockItem.ItemSize == 0)
					{
						num = (short)93257729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2027749379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_256:
					global::Motorola.Common.Communication.CommonUtil.IshHeader header = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, blockType, 0);
					ishItems.Remove(header);
					num = (short)695271430;
					num2 = (int)((global::System.IntPtr)num);
				}
				return ishItems;
			}
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0019DFDC File Offset: 0x0019C1DC
		public static string RadioSNToString(string radSN)
		{
			short num;
			string result;
			try
			{
				num = (short)216907792;
				short num2 = num;
				num = (short)2113060880;
				switch (num2 == num)
				{
				}
				num = (short)567214081;
				if (num != 0)
				{
				}
				num = (short)1354170368;
				if (num != 0)
				{
				}
				byte[] bytes = global::System.Convert.FromBase64String(radSN);
				result = global::System.Text.Encoding.ASCII.GetString(bytes);
			}
			catch
			{
				result = string.Empty;
			}
			num = (short)1389363200;
			short num3 = num;
			return result;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0019E0B4 File Offset: 0x0019C2B4
		internal static global::SpecialFeatures.Security.RadioSecurityData GetRadioSecurityData(global::SpecialFeatures.Comms.RadioParams curRadioParms, global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			global::SpecialFeatures.Security.RadioSecurityData result;
			short num;
			for (;;)
			{
				result = null;
				int advKeyType = 0;
				int ownerSystemId = 0;
				int ownerWacnId = 0;
				bool bASKRequired = false;
				bool bWriteProtected = false;
				try
				{
					string radioFlashcodeFromFBD = global::SpecialFeatures.Comms.ParseDataHelper.GetRadioFlashcodeFromFBD(global::SpecialFeatures.Comms.ParseDataHelper.GetFDB(pba));
					global::System.Collections.Generic.Dictionary<string, int> radioTrkSysNamesAndIdsWithAskReqOn;
					global::System.Collections.Generic.Dictionary<string, int> radioTrkSysNamesAndIdsWithAskReqOff;
					global::SpecialFeatures.Comms.ParseDataHelper.ReadRadioTrkSystemNamesAndIds(pba.GetCodeplugInIshItemCollection(), out radioTrkSysNamesAndIdsWithAskReqOn, out radioTrkSysNamesAndIdsWithAskReqOff);
					bool bConvnOnly = global::SpecialFeatures.Comms.RadioOperationValidator.IsRadioConvOnly(curRadioParms.ModelNumber, radioFlashcodeFromFBD, false);
					global::SpecialFeatures.Security.ProtectionOption protectionOption = global::SpecialFeatures.Security.RadioAccessValidator.GetProtectionOption(curRadioParms.ModelNumber, radioFlashcodeFromFBD, false);
					global::SpecialFeatures.Comms.ParseDataHelper.GetRadioSecurityConfigurationData(curRadioParms.CodeplugVersion, protectionOption, out advKeyType, out ownerSystemId, out ownerWacnId, out bASKRequired, out bWriteProtected, pba);
					result = new global::SpecialFeatures.Security.RadioSecurityData(protectionOption, advKeyType, ownerSystemId, ownerWacnId, bASKRequired, bWriteProtected, bConvnOnly, radioTrkSysNamesAndIdsWithAskReqOn, radioTrkSysNamesAndIdsWithAskReqOff);
				}
				catch (global::System.Exception)
				{
					result = null;
				}
				num = (short)1261250413;
				short num2 = num;
				num = (short)2006787949;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_B8;
				}
			}
			IL_B8:
			num = (short)836304896;
			if (num != 0)
			{
			}
			num = (short)581697536;
			short num3 = num;
			num = (short)616759297;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0019E1F0 File Offset: 0x0019C3F0
		internal static string GetRadioFlashcodeFromFBD(byte[] featDescBlk)
		{
			int a_ = 3;
			short num = (short)1864630278;
			int num2 = (int)((global::System.IntPtr)num);
			byte[] array;
			for (;;)
			{
				int sourceIndex;
				int num4;
				switch (num2)
				{
				case 0:
					goto IL_14A;
				case 1:
				{
					num = (short)202170886;
					short num3 = num;
					num = (short)1620369926;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10F;
					case 1:
						goto IL_F3;
					}
					goto Block_2;
				}
				case 2:
					if (featDescBlk.Length == 16)
					{
						num = (short)1518862339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Array.Copy(featDescBlk, sourceIndex, array, 0, 24);
					num = (short)1886912519;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					global::System.Array.Copy(featDescBlk, sourceIndex, array, 0, 12);
					num = (short)1517748228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_205;
				case 5:
					goto IL_10F;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 7:
					goto IL_1CC;
				case 8:
					goto IL_14A;
				case 9:
					if (num4 >= 24)
					{
						num = (short)478347269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					array[num4] = 0;
					num4++;
					num = (short)1432813576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				num = (short)807796737;
				if (num != 0)
				{
				}
				if (featDescBlk == null)
				{
					num = (short)1002373121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				sourceIndex = 2;
				array = new byte[24];
				num4 = 0;
				num = (short)978059264;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10F:
				num = (short)2013396994;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14A:
				num = (short)828375049;
				num2 = (int)((global::System.IntPtr)num);
			}
			Block_2:
			num = (short)547618816;
			short num5 = num;
			IL_F3:
			num = (short)1516503040;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪍풕", a_));
			IL_1CC:
			IL_205:
			return global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(array, array.Length);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0019E434 File Offset: 0x0019C634
		internal static void GetRadioSecurityConfigurationData(string curRadioCpgVersion, global::SpecialFeatures.Security.ProtectionOption opt, out int ownerAdvKeyType, out int ownerSysId, out int ownerWacnId, out bool bAskReq, out bool bWriteProtected, global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)481492992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_83;
				}
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
				int num12;
				int num14;
				int bitOffset;
				int num15;
				int bitOffset2;
				int num16;
				int num17;
				for (;;)
				{
					IL_28:
					global::Motorola.Common.Communication.CommonUtil.IshItem ishItem;
					switch (num2)
					{
					case 0:
					{
						int num3 = 5;
						int num4 = 1;
						int num5 = 0;
						int num6 = 0;
						int num7 = 0;
						int num8 = 0;
						num = (short)496717366;
						short num9 = num;
						num = (short)2033012278;
						switch ((num9 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_418;
						default:
							num = (short)1379008512;
							if (num != 0)
							{
							}
							num = (short)1635516434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)2004811793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_32E;
					case 3:
					{
						num = (short)158662656;
						short num10 = num;
						ishItem = codeplugInIshItemCollection[ishHeader];
						num = (short)186581011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (codeplugInIshItemCollection.ContainsHeader(ishHeader))
						{
							num = (short)1918107651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
					{
						int num3;
						int num6;
						if (num6 == num3)
						{
							num = (short)1645674497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41D;
					}
					case 6:
					{
						int num5;
						int num8;
						if (num8 >= num5)
						{
							num = (short)136708107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C4;
					}
					case 7:
						goto IL_418;
					case 8:
						return;
					case 9:
					{
						int num3;
						int num6;
						if (num6 >= num3)
						{
							num = (short)1594163213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C4;
					}
					case 10:
					{
						int num4;
						int num7;
						if (num7 == num4)
						{
							num = (short)1928462352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AF;
					}
					case 11:
						goto IL_3AF;
					case 12:
						try
						{
							int num6 = (int)global::System.Convert.ToInt16(curRadioCpgVersion.Substring(1, 2), 10);
							int num7 = (int)global::System.Convert.ToInt16(curRadioCpgVersion.Substring(4, 2), 10);
							int num8 = (int)global::System.Convert.ToInt16(curRadioCpgVersion.Substring(7, 2), 10);
							goto IL_4CD;
						}
						catch (global::System.Exception)
						{
							goto IL_4CD;
						}
						goto IL_1C4;
					case 13:
						num = (short)1986330629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)38404106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						int num3;
						int num6;
						if (num6 == num3)
						{
							num = (short)538050574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AF;
					}
					case 16:
						num = (short)600702982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						int num4;
						int num7;
						if (num7 >= num4)
						{
							num = (short)2096693268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C4;
					}
					case 18:
						if (!string.IsNullOrEmpty(curRadioCpgVersion))
						{
							num = (short)1551106060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CD;
					case 19:
						if (opt == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
						{
							num = (short)1988493312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32E;
					case 20:
						goto IL_41D;
					}
					goto IL_83;
					IL_1C4:
					num = (short)160038913;
					if (num != 0)
					{
					}
					int num11 = (int)ishItem.Data[num12];
					byte b = ishItem.Data[num12 + 1];
					int num13 = num11 << 8;
					num13 |= (int)b;
					ownerSysId = num13;
					byte value = ishItem.Data[num14];
					global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask intMask = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask(bitOffset, 1);
					bAskReq = (intMask.Apply((int)value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack) > 0);
					num = (short)1522008066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_418:
					goto IL_1C4;
					IL_32E:
					byte value2 = ishItem.Data[num15];
					global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask intMask2 = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask(bitOffset2, 1);
					bWriteProtected = (intMask2.Apply((int)value2, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack) > 0);
					num = (short)1321730056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AF:
					ownerAdvKeyType = (int)ishItem.Data[num16];
					byte b2 = ishItem.Data[num17];
					byte b3 = ishItem.Data[num17 + 1];
					byte b4 = ishItem.Data[num17 + 2];
					ownerWacnId |= (int)b2 << 16;
					ownerWacnId |= (int)b3 << 8;
					ownerWacnId |= (int)b4;
					num = (short)333840391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41D:
					num = (short)104267791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CD:
					num = (short)14745609;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_83:
				ushort ishType = 1026;
				ownerAdvKeyType = 0;
				num16 = 124;
				ownerSysId = 0;
				num12 = 106;
				ownerWacnId = 0;
				num17 = 121;
				bAskReq = false;
				num14 = 97;
				bitOffset = 3;
				bWriteProtected = false;
				num15 = 19;
				bitOffset2 = 6;
				codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, ishType, 0);
				num = (short)433979396;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0019E960 File Offset: 0x0019CB60
		internal static string getCodeplugFlashCode()
		{
			string text;
			for (;;)
			{
				IL_00:
				short num = (short)1861025792;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num3;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
						return text;
					case 1:
					{
						num = (short)771221247;
						short num4 = num;
						num = (short)280880895;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1196883968;
							if (num != 0)
							{
							}
							text = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132Value;
							text = global::System.Convert.ToBase64String(global::System.Text.Encoding.ASCII.GetBytes(text));
							num = (short)401670144;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						if (radioInformation != null)
						{
							num = (short)1583022081;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					}
					break;
				}
				IL_45:
				text = string.Empty;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)53018625;
				if (num != 0)
				{
				}
				num = (short)673710082;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			return text;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0019EAAC File Offset: 0x0019CCAC
		internal static global::Motorola.Common.Communication.CommonUtil.IshItemCollection GetRadioASKProgrammingHistoryList(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)1386086400;
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
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)2008547331;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == 1062)
									{
										num = (short)992018434;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)531300356;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									ishItemCollection.Add(keyValuePair.Key, keyValuePair.Value);
									num = (short)1853292549;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_11B;
									}
									continue;
								case 4:
									goto IL_1F0;
								case 5:
									goto IL_1D2;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)175046657;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									num = (short)260636672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_11D:
								num = (short)1249312774;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11B:
								goto IL_11D;
							}
							IL_1D2:
							IL_1F0:
							return ishItemCollection;
						}
						finally
						{
							num = (short)391910713;
							short num3 = num;
							num = (short)1636767033;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_28B:
								enumerator.Dispose();
								num = (short)976617472;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)187760640;
								if (num != 0)
								{
								}
								num = (short)779485186;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2A9;
								case 1:
									goto IL_28B;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_273;
									}
									continue;
								}
								IL_273:
								if (enumerator == null)
								{
									break;
								}
								num = (short)144900097;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2A9:;
						}
						goto IL_2AC;
					case 1:
						goto IL_2AC;
					case 2:
					{
						num = (short)1252786176;
						short num4 = num;
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)1595146241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return ishItemCollection;
					}
					}
					goto IL_3B;
					IL_2AC:
					enumerator = codeplugInIshItemCollection.GetEnumerator();
					num = (short)926613504;
					num2 = (int)((global::System.IntPtr)num);
				}
				return ishItemCollection;
				IL_3B:
				num = (short)1057554433;
				if (num != 0)
				{
				}
				codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
				num = (short)292356098;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0019EDA8 File Offset: 0x0019CFA8
		internal static global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysBandPlan> GetRadioTrkSystemShuffledBandPlans(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)666501120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysBandPlan> collection;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1503592449;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_11D;
									}
									continue;
								case 2:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItem value;
									if (value.Data != null)
									{
										num = (short)1645150215;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									num = (short)256573442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == 3852)
									{
										num = (short)1428815875;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)125763592;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									num = (short)1012531204;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_2B7;
								case 7:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									byte sysType = value.Data[1];
									value = keyValuePair.Value;
									int num3 = (int)value.Data[59];
									value = keyValuePair.Value;
									byte b = value.Data[60];
									int num4 = num3 << 8;
									num4 |= (int)b;
									value = keyValuePair.Value;
									byte value2 = value.Data[70];
									bool shuffledBandPlan = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask(2, 1).Apply((int)value2, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack) > 0;
									collection.Add(new global::SpecialFeatures.Security.TrkSysBandPlan((int)sysType, num4, shuffledBandPlan));
									num = (short)1666383872;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)2133524486;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_122:
								num = (short)1018757125;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11D:
								goto IL_122;
							}
							IL_2B7:
							return collection;
						}
						finally
						{
							num = (short)640587077;
							short num5 = num;
							num = (short)335516997;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_352:
								enumerator.Dispose();
								num = (short)1223098368;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1581711360;
								if (num != 0)
								{
								}
								num = (short)1243545602;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_370;
								case 1:
									goto IL_352;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_339;
									}
									continue;
								}
								IL_339:
								if (enumerator == null)
								{
									break;
								}
								num = (short)547291137;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_370:;
						}
						goto IL_373;
					case 1:
						num = (short)719454209;
						if (num != 0)
						{
						}
						goto IL_373;
					case 2:
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)438632448;
							short num6 = num;
							num = (short)791609345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					}
					goto IL_3A;
					IL_373:
					enumerator = codeplugInIshItemCollection.GetEnumerator();
					num = (short)1665466368;
					num2 = (int)((global::System.IntPtr)num);
				}
				return collection;
				IL_3A:
				collection = new global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysBandPlan>();
				codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				num = (short)2098331650;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0019F16C File Offset: 0x0019D36C
		internal static global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReplaceSecurityPartition(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItems, global::Motorola.Common.Communication.Pba.DataPartition oldSecurityPartition)
		{
			short num = (short)1577779200;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator2;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1940914177;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1887436802;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F2;
									}
									continue;
								case 2:
									goto IL_1B0;
								case 4:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)551550976;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.DataBlock dataBlock = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader headers = new global::Motorola.Common.Communication.CommonUtil.IshHeader(oldSecurityPartition.PartitionID, dataBlock.BlockType, dataBlock.BlockID);
									global::Motorola.Common.Communication.CommonUtil.IshItem item = new global::Motorola.Common.Communication.CommonUtil.IshItem(dataBlock.LegthInBits / 8, dataBlock.PacketValue, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined);
									ishItems.Add(headers, item);
									num = (short)2132606979;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_F4:
								num = (short)1880227844;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F2:
								goto IL_F4;
							}
							IL_1B0:
							goto IL_41A;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1C3;
					case 1:
						num = (short)1045495809;
						if (num != 0)
						{
						}
						if (ishItems.Count > 0)
						{
							num = (short)827654147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41A;
					case 2:
					{
						try
						{
							num = (short)1103036419;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1236795394;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator2.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									num = (short)1185939462;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									list.Add(keyValuePair.Key);
									num = (short)2004090885;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1560805380;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_25B;
									}
									continue;
								case 4:
									goto IL_323;
								case 6:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.PartitionNumber == 212)
									{
										num = (short)1023475713;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_2A8:
								num = (short)682164224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_25B:
								goto IL_2A8;
							}
							IL_323:;
						}
						finally
						{
							num = (short)1015867212;
							short num3 = num;
							num = (short)654370636;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_3BD:
								enumerator2.Dispose();
								num = (short)1389232128;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1808924672;
								if (num != 0)
								{
								}
								num = (short)1650786306;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3DA;
								case 1:
									goto IL_3BD;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3A5;
									}
									continue;
								}
								IL_3A5:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)997195777;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3DA:;
						}
						list.ForEach(delegate(global::Motorola.Common.Communication.CommonUtil.IshHeader s)
						{
							short num5 = (short)1935730435;
							short num6 = num5;
							num5 = (short)119006979;
							switch (num6 == num5)
							{
							}
							num5 = (short)343080960;
							short num7 = num5;
							num5 = (short)547880961;
							if (num5 != 0)
							{
							}
							num5 = (short)994443264;
							if (num5 != 0)
							{
							}
							ishItems.Remove(s);
						});
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator = oldSecurityPartition.DataBlocks.GetEnumerator();
						num = (short)1068630016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1C3;
					}
					goto IL_3E;
					IL_1C3:
					num = (short)145424384;
					short num4 = num;
					list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
					enumerator2 = ishItems.GetEnumerator();
					num = (short)1081868290;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_41A:
				return ishItems;
				IL_3E:
				num = (short)1579220993;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0019F5D0 File Offset: 0x0019D7D0
		internal static int ReadProgrammingPathValue(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)1438908417;
			if (num != 0)
			{
			}
			num = (short)1586036736;
			switch (num)
			{
			default:
			{
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				int result = -1;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)196870147;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)962592770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)715522054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							int num3 = 294;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							result = (int)(keyValuePair.Value.Data[num3] & 15);
							num = (short)196613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)2088108036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_96;
							}
							continue;
						case 4:
							goto IL_172;
						case 5:
							goto IL_154;
						case 6:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1173)
							{
								num = (short)529661953;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_E3:
						num = (short)914751488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_96:
						goto IL_E3;
					}
					IL_154:
					IL_172:;
				}
				finally
				{
					num = (short)5748101;
					short num4 = num;
					num = (short)1526052229;
					int num2;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_20C:
						enumerator.Dispose();
						num = (short)534904832;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1163264000;
						if (num != 0)
						{
						}
						num = (short)1450180610;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_22B;
						case 1:
							goto IL_20C;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1F4;
							}
							continue;
						}
						IL_1F4:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1634140161;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_22B:;
				}
				num = (short)950272000;
				short num5 = num;
				return result;
			}
			}
		}

		// Token: 0x04000A03 RID: 2563
		internal const int TRUNKING_SYSTEM_COUNT_MSB_INDEX = 5;

		// Token: 0x04000A04 RID: 2564
		internal const int TRUNKING_SYSTEM_COUNT_LSB_INDEX = 6;

		// Token: 0x04000A05 RID: 2565
		internal const int TRUNKING_SYSTEM_NAME_SIZE_MSB_INDEX = 1;

		// Token: 0x04000A06 RID: 2566
		internal const int TRUNKING_SYSTEM_NAME_SIZE_LSB_INDEX = 2;

		// Token: 0x04000A07 RID: 2567
		internal const int TRUNKING_SYSTEM_NAME_STRING_START_INDEX = 19;

		// Token: 0x04000A08 RID: 2568
		internal const int TRUNKING_SYSTEM_ID_MSB_INDEX = 59;

		// Token: 0x04000A09 RID: 2569
		internal const int TRUNKING_SYSTEM_ID_LSB_INDEX = 60;

		// Token: 0x04000A0A RID: 2570
		internal const int TRUNKING_SYSTEM_ASK_REQUIRED_BYTE_INDEX = 130;

		// Token: 0x04000A0B RID: 2571
		internal const int TRUNKING_SYSTEM_UNIT_ID_MSB_INDEX = 63;

		// Token: 0x04000A0C RID: 2572
		internal const int TRUNKING_SYSTEM_UNIT_ID_BYTE_3_INDEX = 64;

		// Token: 0x04000A0D RID: 2573
		internal const int TRUNKING_SYSTEM_UNIT_ID_BYTE_2_INDEX = 65;

		// Token: 0x04000A0E RID: 2574
		internal const int TRUNKING_SYSTEM_UNIT_ID_LSB_INDEX = 66;

		// Token: 0x04000A0F RID: 2575
		internal const int TRUNKING_SYSTEM_SYSTEM_TYPE_BYTE_INDEX = 1;
	}
}
