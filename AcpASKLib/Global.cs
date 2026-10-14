using System;
using System.Collections.Generic;

namespace AcpASKLib
{
	// Token: 0x02000026 RID: 38
	public static class Global
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00012FF0 File Offset: 0x000111F0
		internal static global::AcpASKLib.PersistentData c()
		{
			short num = (short)1437138944;
			short num2 = num;
			num = (short)477705467;
			short num3 = num;
			num = (short)1932014843;
			switch (num3 == num)
			{
			}
			num = (short)1532231681;
			if (num != 0)
			{
			}
			num = (short)1802305536;
			if (num != 0)
			{
			}
			return global::AcpASKLib.Global.m_persistentData;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000130A0 File Offset: 0x000112A0
		internal static void d(global::AcpASKLib.AccessRecord A_0)
		{
			short num = (short)1919221760;
			short num2 = num;
			num = (short)404488193;
			if (num != 0)
			{
			}
			num = (short)635710161;
			short num3 = num;
			num = (short)1446390481;
			switch (num3 == num)
			{
			}
			num = (short)1187971072;
			if (num != 0)
			{
			}
			global::AcpASKLib.Global.m_persistentData.RadioWideACLRecSet.AddNewRecord(A_0);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00013158 File Offset: 0x00011358
		public static void AddSystemWideAccessLevel(global::AcpASKLib.AccessRecord record)
		{
			short num = (short)1908277248;
			short num2 = num;
			num = (short)360412227;
			short num3 = num;
			num = (short)1279161411;
			switch (num3 == num)
			{
			}
			num = (short)43319296;
			if (num != 0)
			{
			}
			num = (short)1890582529;
			if (num != 0)
			{
			}
			global::AcpASKLib.Global.m_persistentData.SystemWideACLRecSet.AddNewRecord(record);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00013210 File Offset: 0x00011410
		internal static void c(global::AcpASKLib.AccessRecord A_0)
		{
			short num = (short)1474363392;
			short num2 = num;
			num = (short)59873776;
			short num3 = num;
			num = (short)1867880944;
			switch (num3 == num)
			{
			}
			num = (short)1559822337;
			if (num != 0)
			{
			}
			num = (short)1099235328;
			if (num != 0)
			{
			}
			global::AcpASKLib.Global.m_persistentData.ConvSystemACLRecSet.AddNewRecord(A_0);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000132CC File Offset: 0x000114CC
		internal static void b(global::AcpASKLib.AccessRecord A_0)
		{
			short num = (short)1965228032;
			short num2 = num;
			num = (short)328635390;
			short num3 = num;
			num = (short)412259326;
			switch (num3 == num)
			{
			}
			num = (short)343867393;
			if (num != 0)
			{
			}
			num = (short)856883200;
			if (num != 0)
			{
			}
			global::AcpASKLib.Global.m_persistentData.RadioWideACLRecSet.Remove(A_0);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00013388 File Offset: 0x00011588
		public static void RemoveSystemWideAccessLevel(global::AcpASKLib.AccessRecord record)
		{
			short num = (short)1559822336;
			short num2 = num;
			num = (short)1337104911;
			short num3 = num;
			num = (short)866294287;
			switch (num3 == num)
			{
			}
			num = (short)565837825;
			if (num != 0)
			{
			}
			num = (short)654573568;
			if (num != 0)
			{
			}
			global::AcpASKLib.Global.m_persistentData.SystemWideACLRecSet.Remove(record);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00013444 File Offset: 0x00011644
		internal static void a(global::AcpASKLib.AccessRecord A_0)
		{
			short num = (short)1032257536;
			short num2 = num;
			num = (short)406933289;
			short num3 = num;
			num = (short)9195305;
			switch (num3 == num)
			{
			}
			num = (short)593887233;
			if (num != 0)
			{
			}
			num = (short)1921777664;
			if (num != 0)
			{
			}
			global::AcpASKLib.Global.m_persistentData.ConvSystemACLRecSet.Remove(A_0);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000134FC File Offset: 0x000116FC
		internal static global::AcpASKLib.AccessLevelDataRecordSet b()
		{
			short num = (short)1582366720;
			short num2 = num;
			num = (short)876599244;
			short num3 = num;
			num = (short)692377548;
			switch (num3 == num)
			{
			}
			num = (short)1868431361;
			if (num != 0)
			{
			}
			num = (short)611123200;
			if (num != 0)
			{
			}
			return global::AcpASKLib.Global.m_persistentData.RadioWideACLRecSet;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000135B0 File Offset: 0x000117B0
		internal static global::AcpASKLib.AccessRecord b(int A_0)
		{
			short num = (short)277348353;
			if (num != 0)
			{
			}
			global::AcpASKLib.AccessRecord result = null;
			global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessRecord> enumerator = global::AcpASKLib.Global.m_persistentData.RadioWideACLRecSet.GetEnumerator();
			try
			{
				num = (short)1729101824;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					case 2:
						num = (short)934412291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_11E;
					case 4:
					{
						global::AcpASKLib.AccessRecord accessRecord;
						result = accessRecord;
						num = (short)2114519041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::AcpASKLib.AccessRecord accessRecord;
						if (accessRecord.ID == A_0)
						{
							num = (short)2046885892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)2062548994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpASKLib.AccessRecord accessRecord = enumerator.Current;
						num = (short)5242885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_B6:
					num = (short)1344143366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A:
					goto IL_B6;
				}
				IL_11E:;
			}
			finally
			{
				num = (short)997457921;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1D6;
					case 1:
						goto IL_137;
					case 2:
					{
						enumerator.Dispose();
						num = (short)798312810;
						short num3 = num;
						num = (short)2081704298;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_137;
						default:
							num = (short)649265152;
							if (num != 0)
							{
							}
							num = (short)1563295744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_153;
					IL_137:
					switch (0)
					{
					case 0:
						IL_153:
						if (enumerator == null)
						{
							goto IL_1D8;
						}
						num = (short)476053506;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_1D6:
				IL_1D8:;
			}
			num = (short)1024196608;
			short num4 = num;
			return result;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000137D0 File Offset: 0x000119D0
		public static global::AcpASKLib.AccessLevelDataRecordSet GetSysWideAccessLevels()
		{
			short num = (short)1470103552;
			short num2 = num;
			num = (short)2095385523;
			short num3 = num;
			num = (short)1131809715;
			switch (num3 == num)
			{
			}
			num = (short)366739457;
			if (num != 0)
			{
			}
			num = (short)909049856;
			if (num != 0)
			{
			}
			return global::AcpASKLib.Global.m_persistentData.SystemWideACLRecSet;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00013884 File Offset: 0x00011A84
		public static global::AcpASKLib.AccessRecord GetSysWideAccessLevel(int id)
		{
			short num = (short)1410531328;
			short num2 = num;
			global::AcpASKLib.AccessRecord result = null;
			global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessRecord> enumerator = global::AcpASKLib.Global.m_persistentData.SystemWideACLRecSet.GetEnumerator();
			try
			{
				num = (short)155516928;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					case 2:
						num = (short)1381040131;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_126;
					case 4:
					{
						global::AcpASKLib.AccessRecord accessRecord;
						result = accessRecord;
						num = (short)277020673;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::AcpASKLib.AccessRecord accessRecord;
						if (accessRecord.ID == id)
						{
							num = (short)1901461508;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1425276930;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpASKLib.AccessRecord accessRecord = enumerator.Current;
						num = (short)185204741;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_BC:
					num = (short)555286534;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_80:
					goto IL_BC;
				}
				IL_126:
				num = (short)496369665;
				if (num != 0)
				{
				}
			}
			finally
			{
				num = (short)1227620353;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_209;
					case 1:
						goto IL_168;
					case 2:
					{
						enumerator.Dispose();
						num = (short)1468722723;
						short num4 = num;
						num = (short)1128066595;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_168;
						default:
							num = (short)2083127296;
							if (num != 0)
							{
							}
							num = (short)1518403584;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_184;
					IL_168:
					switch (0)
					{
					case 0:
						IL_184:
						if (enumerator == null)
						{
							goto IL_20B;
						}
						num = (short)367001602;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_209:
				IL_20B:;
			}
			return result;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00013ABC File Offset: 0x00011CBC
		internal static global::AcpASKLib.AccessLevelDataRecordSet a()
		{
			short num = (short)2128281600;
			short num2 = num;
			num = (short)1281046078;
			short num3 = num;
			num = (short)631256638;
			switch (num3 == num)
			{
			}
			num = (short)190382080;
			if (num != 0)
			{
			}
			num = (short)715128833;
			if (num != 0)
			{
			}
			return global::AcpASKLib.Global.m_persistentData.ConvSystemACLRecSet;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00013B70 File Offset: 0x00011D70
		internal static global::AcpASKLib.AccessRecord a(int A_0)
		{
			short num = (short)866254848;
			short num2 = num;
			global::AcpASKLib.AccessRecord result = null;
			global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessRecord> enumerator = global::AcpASKLib.Global.m_persistentData.ConvSystemACLRecSet.GetEnumerator();
			try
			{
				num = (short)216334336;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 2:
						num = (short)415891459;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_125;
					case 4:
					{
						global::AcpASKLib.AccessRecord accessRecord;
						result = accessRecord;
						num = (short)1464401921;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::AcpASKLib.AccessRecord accessRecord;
						if (accessRecord.ID == A_0)
						{
							num = (short)1301479428;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)216072194;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpASKLib.AccessRecord accessRecord = enumerator.Current;
						num = (short)289800197;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_BA:
					num = (short)1975779334;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_7D:
					goto IL_BA;
				}
				IL_125:;
			}
			finally
			{
				num = (short)377421825;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)285147137;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_206;
					case 1:
						goto IL_13E;
					case 2:
					{
						enumerator.Dispose();
						num = (short)215863890;
						short num4 = num;
						num = (short)1446564434;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13E;
						default:
							num = (short)485949440;
							if (num != 0)
							{
							}
							num = (short)968097792;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_182;
					IL_13E:
					switch (0)
					{
					case 0:
						IL_182:
						if (enumerator == null)
						{
							goto IL_208;
						}
						num = (short)265748482;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_206:
				IL_208:;
			}
			return result;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00013D98 File Offset: 0x00011F98
		internal static void a(byte[] A_0, byte[] A_1, byte[] A_2)
		{
			short num = (short)1295319040;
			switch (num)
			{
			default:
			{
				num = (short)1561722881;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)642283568;
					short num3 = num;
					num = (short)627865648;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1807024128;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
						{
							int upperBound = A_1.GetUpperBound(0);
							byte b = 0;
							b = global::AcpASKLib.Global.a(A_1, (short)upperBound, b);
							A_1.SetValue(b, upperBound);
							num = (short)182321160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_B0;
							}
							continue;
						case 2:
						{
							int upperBound2 = A_2.GetUpperBound(0);
							byte b2 = 0;
							b2 = global::AcpASKLib.Global.a(A_2, (short)upperBound2, b2);
							A_2.SetValue(b2, upperBound2);
							num = (short)1784676357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (A_0 != null)
							{
								num = (short)1106640900;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D3;
						case 4:
						{
							num = (short)1792606208;
							short num4 = num;
							int upperBound3 = A_0.GetUpperBound(0);
							byte b3 = 0;
							b3 = global::AcpASKLib.Global.a(A_0, (short)upperBound3, b3);
							A_0.SetValue(b3, upperBound3);
							num = (short)2114387974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							return;
						case 6:
							num = (short)947650561;
							if (num != 0)
							{
							}
							goto IL_D3;
						case 7:
							if (A_2 != null)
							{
								num = (short)1083047938;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 8:
							goto IL_1F4;
						}
						IL_B0:
						if (A_1 != null)
						{
							break;
						}
						goto IL_1F4;
						IL_D3:
						num = (short)1920598023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F4:
						num = (short)1172111363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1119092736;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00014000 File Offset: 0x00012200
		internal static byte a(byte[] A_0)
		{
			short num = (short)920750741;
			short num2 = num;
			num = (short)1565821589;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_67;
			default:
				num = (short)696123392;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				break;
			}
			int num3;
			byte b;
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
					return b;
				case 1:
					if (A_0 != null)
					{
						num = (short)1269760002;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return b;
				case 2:
				{
					int upperBound = A_0.GetUpperBound(0);
					b = global::AcpASKLib.Global.a(A_0, (short)upperBound, b);
					num = (short)444792832;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_67;
			}
			return b;
			IL_67:
			b = 0;
			num = (short)535560192;
			short num4 = num;
			num = (short)1708982273;
			if (num != 0)
			{
			}
			num = (short)1489436673;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00014128 File Offset: 0x00012328
		internal static byte a(byte[] A_0, short A_1, byte A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			short num3;
			byte b2;
			for (;;)
			{
				IL_0A:
				byte b;
				switch (num)
				{
				case 0:
					if (num2 >= A_1)
					{
						num3 = (short)2014248969;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					b = A_0[(int)num2];
					b ^= A_2;
					A_2 = b;
					num3 = (short)56688651;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					goto IL_11E;
				case 2:
					goto IL_2B8;
				case 3:
					goto IL_1F4;
				case 4:
					goto IL_1F4;
				case 5:
					if ((b2 & 128) != 0)
					{
						num3 = (short)676724742;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					b2 = (byte)(b2 >> 1);
					num3 = (short)718012420;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 6:
					b2 = (byte)(b2 >> 1 | 128);
					b2 ^= byte.MaxValue;
					num3 = (short)1529020419;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
					goto IL_11E;
				case 8:
					b = (byte)(b >> 1 | 128);
					num3 = (short)845545482;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					goto IL_154;
				case 10:
				{
					num3 = (short)678217139;
					short num4 = num3;
					num3 = (short)1387775411;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B8;
					default:
						num3 = (short)2016477184;
						if (num3 != 0)
						{
						}
						goto IL_242;
					}
					break;
				}
				case 11:
				{
					num3 = (short)1681522688;
					short num5 = num3;
					if ((b & 128) != 0)
					{
						num3 = (short)2055929864;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					b = (byte)(b >> 1);
					num3 = (short)1983184898;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				}
				goto IL_40;
				IL_11E:
				num3 = (short)55312384;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1F4:
				b2 &= 15;
				b += b2;
				b2 = A_2;
				b2 &= 7;
				global::AcpASKLib.Global.a(ref b2, ref b);
				b = global::AcpASKLib.Global.a[(int)b];
				b2 ^= b;
				A_2 = b2;
				num2 += 1;
				num3 = (short)533331975;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_242:
				b = (byte)(b >> 1);
				b ^= A_2;
				b2 = b;
				b = (byte)(b << 1);
				b &= 240;
				num3 = (short)324665349;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_2B8:
				goto IL_242;
			}
			IL_154:
			num3 = (short)560005121;
			if (num3 != 0)
			{
			}
			return b2;
			IL_40:
			b2 = 0;
			num2 = 0;
			num3 = (short)1113849857;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000143F0 File Offset: 0x000125F0
		private static void a(ref byte A_0, ref byte A_1)
		{
			short num = (short)1915355136;
			short num2 = num;
			num = (short)2114944808;
			short num3 = num;
			num = (short)2012184360;
			switch (num3 == num)
			{
			}
			num = (short)1238827008;
			if (num != 0)
			{
			}
			num = (short)1652162561;
			if (num != 0)
			{
			}
			A_0 ^= A_1;
			A_1 ^= A_0;
			A_0 ^= A_1;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000144B0 File Offset: 0x000126B0
		internal static bool a(char A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_C7;
			}
			short num;
			int num4;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)1201510493;
				short num2 = num;
				num = (short)575641693;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C7;
				case 1:
					break;
				default:
				{
					num = (short)1786183680;
					short num3 = num;
					break;
				}
				}
				num = (short)2027552768;
				if (num != 0)
				{
				}
				num = (short)60162049;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					switch (A_0)
					{
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
					case 'A':
					case 'B':
					case 'C':
					case 'D':
					case 'E':
					case 'F':
						goto IL_15F;
					case ':':
					case ';':
					case '<':
					case '=':
					case '>':
					case '?':
					case '@':
						goto IL_1EB;
					default:
						num = (short)1385234437;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				case 1:
					num = (short)30867462;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (A_0)
					{
					case 'a':
					case 'b':
					case 'c':
					case 'd':
					case 'e':
					case 'f':
						goto IL_15F;
					default:
						num = (short)2121007105;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
					num = (short)1029767170;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1EB;
				}
				goto IL_C7;
				IL_15F:
				result = true;
				num = (short)180748292;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EB:
				result = false;
				num = (short)686096387;
				num4 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_C7:
			result = false;
			num = (short)2041249792;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000146C8 File Offset: 0x000128C8
		// Note: this type is marked as 'beforefieldinit'.
		static Global()
		{
			short num = (short)948436992;
			short num2 = num;
			num = (short)1332573344;
			short num3 = num;
			num = (short)1935963296;
			switch (num3 == num)
			{
			}
			num = (short)882769921;
			if (num != 0)
			{
			}
			num = (short)842596352;
			if (num != 0)
			{
			}
			global::AcpASKLib.Global.m_persistentData = new global::AcpASKLib.PersistentData();
			global::AcpASKLib.Global.a = new byte[]
			{
				0,
				153,
				172,
				53,
				199,
				94,
				107,
				242
			};
		}

		// Token: 0x04000171 RID: 369
		public static global::AcpASKLib.PersistentData m_persistentData;

		// Token: 0x04000172 RID: 370
		private static byte[] a;
	}
}
