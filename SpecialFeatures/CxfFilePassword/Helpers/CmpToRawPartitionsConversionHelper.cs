using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.CxfFilePassword.Helpers
{
	// Token: 0x02000150 RID: 336
	internal static class CmpToRawPartitionsConversionHelper
	{
		// Token: 0x06001124 RID: 4388 RVA: 0x0017C394 File Offset: 0x0017A594
		internal static global::System.Collections.Generic.Dictionary<int, byte[]> ConvertIshItemCollectionToRawPartitions(global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug)
		{
			short num = (short)701038592;
			short num2 = num;
			num = (short)1689190400;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.Dictionary<int, byte[]> dictionary = new global::System.Collections.Generic.Dictionary<int, byte[]>();
				global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
				global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>, byte> keySelector = delegate(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> x)
				{
					short num5 = (short)434507961;
					short num6 = num5;
					num5 = (short)1712656569;
					switch (num6 == num5)
					{
					default:
					{
						num5 = (short)1086980096;
						short num7 = num5;
						break;
					}
					case true:
						break;
					}
					num5 = (short)22937600;
					if (num5 != 0)
					{
					}
					num5 = (short)1717108737;
					if (num5 != 0)
					{
					}
					return x.Key.PartitionNumber;
				};
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::System.Linq.IGrouping<byte, global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>> enumerator = codeplug.GroupBy(keySelector).GetEnumerator();
					try
					{
						num = (short)1736966146;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1985347588;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Linq.IGrouping<byte, global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> grouping = enumerator.Current;
								int key = global::SpecialFeatures.CxfFilePassword.Helpers.CmpToRawPartitionsConversionHelper.a(grouping.Key);
								global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator2 = grouping.GetEnumerator();
								num = (short)1316225025;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								try
								{
									num = (short)605159425;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
										{
											global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)1834680322;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator2.Current;
											global::Motorola.Common.Communication.CommonUtil.IshHeader key2 = keyValuePair.Key;
											global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
											list.Add((byte)(key2.IshType >> 8));
											list.Add((byte)key2.IshType);
											list.Add((byte)(key2.IshID >> 8));
											list.Add((byte)key2.IshID);
											list.Add((byte)(value.Data.Length >> 8));
											list.Add((byte)value.Data.Length);
											list.AddRange(value.Data);
											num = (short)434962435;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
											switch (0)
											{
											case 0:
												goto IL_1CD;
											}
											continue;
										case 2:
											num = (short)208601092;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											goto IL_2CD;
										}
										IL_1D2:
										num = (short)206372864;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_1CD:
										goto IL_1D2;
									}
									IL_2CD:
									goto IL_DB;
								}
								finally
								{
									num = (short)1102970880;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator2;
										switch (num3)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_304;
											}
											continue;
										case 1:
											enumerator2.Dispose();
											num = (short)1127743490;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_33C;
										}
										IL_304:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)1786773505;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_33C:;
								}
								goto IL_33F;
								IL_DB:
								num = (short)1644487288;
								short num4 = num;
								num = (short)201515640;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num = (short)423624704;
									if (num != 0)
									{
									}
									int key;
									dictionary.Add(key, list.ToArray());
									list.Clear();
									num = (short)556007427;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_A3;
								}
								continue;
							case 4:
								goto IL_33F;
							case 5:
								goto IL_359;
							}
							IL_153:
							num = (short)2033909760;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_A3:
							goto IL_153;
							IL_33F:
							num = (short)959119365;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_359:
						break;
					}
					finally
					{
						num = (short)236191744;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_392;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)2108817410;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_3C9;
							}
							IL_392:
							if (enumerator == null)
							{
								goto IL_3F1;
							}
							num = (short)950075393;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_3C9:
						num = (short)747503617;
						if (num != 0)
						{
						}
						IL_3F1:;
					}
				}
				return dictionary;
			}
			}
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0017C7F4 File Offset: 0x0017A9F4
		internal static string GetModelNumber(global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug)
		{
			short num;
			string result;
			try
			{
				num = (short)1409071103;
				short num2 = num;
				num = (short)2083960831;
				switch (num2 == num)
				{
				}
				num = (short)827392000;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.IshItem ishItem = codeplug[212, 900, 0];
				result = global::System.Text.Encoding.BigEndianUnicode.GetString(ishItem.Data, 23, 34).TrimEnd(new char[1]);
			}
			catch (global::System.Collections.Generic.KeyNotFoundException)
			{
				result = string.Empty;
			}
			num = (short)909967360;
			short num3 = num;
			num = (short)791478273;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0017C8EC File Offset: 0x0017AAEC
		private static int a(byte A_0)
		{
			int a_ = 13;
			short num = (short)1285816322;
			int num2 = (int)((global::System.IntPtr)num);
			int result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_129;
				case 1:
					num = (short)1584857092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1608777729;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 3:
					goto IL_10A;
				case 4:
					goto IL_142;
				case 5:
					return result;
				}
				IL_6D:
				switch (A_0)
				{
				case 208:
					result = 0;
					num = (short)2144665605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 209:
				case 211:
					goto IL_16D;
				case 210:
					result = 1;
					break;
				case 212:
					result = 2;
					num = (short)201129987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
				{
					num = (short)1692171062;
					short num3 = num;
					num = (short)1559132982;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)729153536;
						if (num != 0)
						{
						}
						num = (short)720764929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				num = (short)589168640;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10A:
			IL_129:
			return result;
			IL_142:
			num = (short)2096168960;
			short num4 = num;
			IL_16D:
			throw new global::System.InvalidOperationException(string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏캟芡킣\udfa5\ud8a7쾩貫覭쮯花즳醵颷펹쾻麽꺿귁냃뫇꿉꿋ꇍ럏병뷓곕뷗뻙﷛", a_), A_0));
		}

		// Token: 0x04000937 RID: 2359
		private const int a = 900;
	}
}
