using System;
using System.Collections.Generic;

namespace ASK.Core
{
	// Token: 0x02000018 RID: 24
	public static class Global
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00013E54 File Offset: 0x00012054
		internal static global::ASK.Core.PersistentData c()
		{
			short num = (short)2074345473;
			if (num != 0)
			{
			}
			num = (short)469632149;
			short num2 = num;
			num = (short)1002243221;
			switch (num2 == num)
			{
			default:
			{
				num = (short)617414656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1605763072;
			if (num != 0)
			{
			}
			return global::ASK.Core.Global.m_persistentData;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00013F04 File Offset: 0x00012104
		internal static void d(global::ASK.Core.AccessRecord A_0)
		{
			short num = (short)1069765590;
			short num2 = num;
			num = (short)376263638;
			switch (num2 == num)
			{
			}
			num = (short)439812096;
			short num3 = num;
			num = (short)1212940288;
			if (num != 0)
			{
			}
			num = (short)24707073;
			if (num != 0)
			{
			}
			global::ASK.Core.Global.m_persistentData.RadioWideACLRecSet.AddNewRecord(A_0);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00013FBC File Offset: 0x000121BC
		public static void AddSystemWideAccessLevel(global::ASK.Core.AccessRecord record)
		{
			short num = (short)1074383798;
			short num2 = num;
			num = (short)2077084598;
			switch (num2 == num)
			{
			}
			num = (short)1712455680;
			short num3 = num;
			num = (short)1976041473;
			if (num != 0)
			{
			}
			num = (short)741670912;
			if (num != 0)
			{
			}
			global::ASK.Core.Global.m_persistentData.SystemWideACLRecSet.AddNewRecord(record);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00014078 File Offset: 0x00012278
		internal static void c(global::ASK.Core.AccessRecord A_0)
		{
			short num = (short)2069281316;
			short num2 = num;
			num = (short)867744292;
			switch (num2 == num)
			{
			}
			num = (short)1992884224;
			short num3 = num;
			num = (short)314376193;
			if (num != 0)
			{
			}
			num = (short)1727725568;
			if (num != 0)
			{
			}
			global::ASK.Core.Global.m_persistentData.ConvSystemACLRecSet.AddNewRecord(A_0);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00014130 File Offset: 0x00012330
		internal static void b(global::ASK.Core.AccessRecord A_0)
		{
			short num = (short)140851569;
			short num2 = num;
			num = (short)1417034097;
			switch (num2 == num)
			{
			}
			num = (short)1015349248;
			short num3 = num;
			num = (short)830078977;
			if (num != 0)
			{
			}
			num = (short)1216675840;
			if (num != 0)
			{
			}
			global::ASK.Core.Global.m_persistentData.RadioWideACLRecSet.Remove(A_0);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000141EC File Offset: 0x000123EC
		public static void RemoveSystemWideAccessLevel(global::ASK.Core.AccessRecord record)
		{
			short num = (short)1999813629;
			short num2 = num;
			num = (short)1127726077;
			switch (num2 == num)
			{
			}
			num = (short)168624128;
			short num3 = num;
			num = (short)846397441;
			if (num != 0)
			{
			}
			num = (short)1711603712;
			if (num != 0)
			{
			}
			global::ASK.Core.Global.m_persistentData.SystemWideACLRecSet.Remove(record);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000142A8 File Offset: 0x000124A8
		internal static void a(global::ASK.Core.AccessRecord A_0)
		{
			short num = (short)1026770768;
			short num2 = num;
			num = (short)681396048;
			switch (num2 == num)
			{
			}
			num = (short)1806696448;
			short num3 = num;
			num = (short)611581953;
			if (num != 0)
			{
			}
			num = (short)779681792;
			if (num != 0)
			{
			}
			global::ASK.Core.Global.m_persistentData.ConvSystemACLRecSet.Remove(A_0);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00014364 File Offset: 0x00012564
		internal static global::ASK.Core.AccessLevelDataRecordSet b()
		{
			short num = (short)1761017857;
			if (num != 0)
			{
			}
			num = (short)1091583286;
			short num2 = num;
			num = (short)939867446;
			switch (num2 == num)
			{
			default:
			{
				num = (short)886898688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)575537152;
			if (num != 0)
			{
			}
			return global::ASK.Core.Global.m_persistentData.RadioWideACLRecSet;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00014418 File Offset: 0x00012618
		internal static global::ASK.Core.AccessRecord b(int A_0)
		{
			short num = (short)539820032;
			short num2 = num;
			global::ASK.Core.AccessRecord result = null;
			global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessRecord> enumerator = global::ASK.Core.Global.m_persistentData.RadioWideACLRecSet.GetEnumerator();
			try
			{
				num = (short)1975386113;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::ASK.Core.AccessRecord accessRecord;
					switch (num3)
					{
					case 0:
						num = (short)471531526;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 2:
						result = accessRecord;
						num = (short)16449540;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)474808320;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_80;
					case 4:
					{
						num = (short)1888585439;
						short num4 = num;
						num = (short)812746463;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_80;
						default:
							num = (short)770899968;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					case 5:
						num = (short)1002307585;
						if (num != 0)
						{
						}
						if (accessRecord.ID == A_0)
						{
							num = (short)773390338;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 6:
						goto IL_1A3;
					}
					goto IL_7E;
					IL_80:
					accessRecord = enumerator.Current;
					num = (short)127860741;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_E6:
					num = (short)468189187;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E:
					goto IL_E6;
				}
				IL_1A3:;
			}
			finally
			{
				num = (short)1304363009;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1434714114;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1D6;
						}
						continue;
					case 2:
						goto IL_20B;
					}
					IL_1D6:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1618804736;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_20B:;
			}
			return result;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00014650 File Offset: 0x00012850
		public static global::ASK.Core.AccessLevelDataRecordSet GetSysWideAccessLevels()
		{
			short num = (short)175185856;
			short num2 = num;
			num = (short)1084563392;
			switch (num2 == num)
			{
			}
			num = (short)67764224;
			short num3 = num;
			num = (short)1594621952;
			if (num != 0)
			{
			}
			num = (short)556335105;
			if (num != 0)
			{
			}
			return global::ASK.Core.Global.m_persistentData.SystemWideACLRecSet;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00014700 File Offset: 0x00012900
		public static global::ASK.Core.AccessRecord GetSysWideAccessLevel(int id)
		{
			global::ASK.Core.AccessRecord result = null;
			global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessRecord> enumerator = global::ASK.Core.Global.m_persistentData.SystemWideACLRecSet.GetEnumerator();
			short num;
			try
			{
				num = (short)720437249;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::ASK.Core.AccessRecord accessRecord;
					switch (num2)
					{
					case 0:
						num = (short)1609105414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_55;
						}
						continue;
					case 2:
						result = accessRecord;
						num = (short)1317994500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)1796145152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57;
					case 4:
					{
						num = (short)631129263;
						short num3 = num;
						num = (short)2068661423;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_57;
						default:
							num = (short)80805888;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					case 5:
						if (accessRecord.ID == id)
						{
							num = (short)1119551490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 6:
						goto IL_14A;
					}
					goto IL_55;
					IL_57:
					accessRecord = enumerator.Current;
					num = (short)2111504389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_91:
					num = (short)1230700547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_55:
					goto IL_91;
				}
				IL_14A:;
			}
			finally
			{
				num = (short)2117861377;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)336461826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_17C;
						}
						continue;
					case 2:
						goto IL_1AF;
					}
					IL_17C:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1204617216;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1AF:;
			}
			num = (short)1914241024;
			short num4 = num;
			num = (short)31457281;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0001492C File Offset: 0x00012B2C
		internal static global::ASK.Core.AccessLevelDataRecordSet a()
		{
			short num = (short)341284880;
			short num2 = num;
			num = (short)1078958096;
			switch (num2 == num)
			{
			}
			num = (short)771489792;
			short num3 = num;
			num = (short)261554177;
			if (num != 0)
			{
			}
			num = (short)1550909440;
			if (num != 0)
			{
			}
			return global::ASK.Core.Global.m_persistentData.ConvSystemACLRecSet;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000149E0 File Offset: 0x00012BE0
		internal static global::ASK.Core.AccessRecord a(int A_0)
		{
			short num = (short)1177092097;
			if (num != 0)
			{
			}
			num = (short)391380992;
			short num2 = num;
			global::ASK.Core.AccessRecord result = null;
			global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessRecord> enumerator = global::ASK.Core.Global.m_persistentData.ConvSystemACLRecSet.GetEnumerator();
			try
			{
				num = (short)923795457;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::ASK.Core.AccessRecord accessRecord;
					switch (num3)
					{
					case 0:
						num = (short)349962246;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					case 2:
						result = accessRecord;
						num = (short)1111162884;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)946143232;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A5;
					case 4:
					{
						num = (short)230842877;
						short num4 = num;
						num = (short)1182818813;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A5;
						default:
							num = (short)1367670784;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					case 5:
						if (accessRecord.ID == A_0)
						{
							num = (short)677183490;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 6:
						goto IL_196;
					}
					goto IL_A3;
					IL_A5:
					accessRecord = enumerator.Current;
					num = (short)1398341637;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_DF:
					num = (short)1878392835;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_A3:
					goto IL_DF;
				}
				IL_196:;
			}
			finally
			{
				num = (short)1708130305;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)2060386306;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1C9;
						}
						continue;
					case 2:
						goto IL_1FD;
					}
					IL_1C9:
					if (enumerator == null)
					{
						break;
					}
					num = (short)142737408;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1FD:;
			}
			return result;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00014C0C File Offset: 0x00012E0C
		internal static void a(byte[] A_0, byte[] A_1, byte[] A_2)
		{
			short num = (short)419513324;
			short num2 = num;
			num = (short)1763984364;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_233:
				if (A_0 == null)
				{
					goto IL_D3;
				}
				num = (short)552599560;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1210515456;
				if (num != 0)
				{
				}
				num = (short)1208352768;
				switch (num)
				{
				default:
					num = (short)2098659331;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			for (;;)
			{
				IL_88:
				switch (num3)
				{
				case 0:
				{
					int upperBound = A_2.GetUpperBound(0);
					byte b = 0;
					b = global::ASK.Core.Global.calculateCRC8(A_2, (short)upperBound, b);
					A_2.SetValue(b, upperBound);
					num = (short)548274177;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return;
				case 2:
					goto IL_233;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_B3;
					}
					continue;
				case 4:
					goto IL_21A;
				case 5:
					goto IL_170;
				case 6:
					if (A_2 != null)
					{
						num = (short)572522496;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
				{
					int upperBound2 = A_1.GetUpperBound(0);
					byte b2 = 0;
					b2 = global::ASK.Core.Global.calculateCRC8(A_1, (short)upperBound2, b2);
					A_1.SetValue(b2, upperBound2);
					num = (short)426246148;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
				{
					int upperBound3 = A_0.GetUpperBound(0);
					byte b3 = 0;
					b3 = global::ASK.Core.Global.calculateCRC8(A_0, (short)upperBound3, b3);
					A_0.SetValue(b3, upperBound3);
					num = (short)433782789;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_B3:
				if (A_1 != null)
				{
					num = (short)1636564999;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_21A:
				num = (short)1265041410;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_170:
			num = (short)2139226113;
			if (num != 0)
			{
			}
			IL_D3:
			num = (short)1973354496;
			short num4 = num;
			num = (short)1523318790;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_88;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00014E70 File Offset: 0x00013070
		public static byte CalculateCheckSum(byte[] byteArray)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			byte b;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					int upperBound = byteArray.GetUpperBound(0);
					b = global::ASK.Core.Global.calculateCRC8(byteArray, (short)upperBound, b);
					num2 = (short)179634178;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					if (byteArray == null)
					{
						return b;
					}
					num2 = (short)232645199;
					short num3 = num2;
					num2 = (short)384623183;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EC;
					default:
						num2 = (short)735838209;
						if (num2 != 0)
						{
						}
						num2 = (short)515571712;
						if (num2 != 0)
						{
						}
						num2 = (short)1211498496;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_EC;
				}
				goto IL_1C;
			}
			IL_EC:
			num2 = (short)2013528064;
			short num4 = num2;
			return b;
			IL_1C:
			b = 0;
			num2 = (short)552140801;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00014F98 File Offset: 0x00013198
		public static byte calculateCRC8(byte[] data, short sizeData, byte crc8)
		{
			short num = (short)1716076061;
			short num2 = num;
			num = (short)1067728413;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1284833280;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_89;
				}
				break;
			}
			int num3;
			byte b;
			short num5;
			for (;;)
			{
				IL_53:
				byte b2;
				switch (num3)
				{
				case 0:
					b = (byte)(b >> 1 | 128);
					b ^= byte.MaxValue;
					num = (short)284295171;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					if ((b2 & 128) != 0)
					{
						num = (short)390201352;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)227934208;
					short num4 = num;
					b2 = (byte)(b2 >> 1);
					num = (short)523829259;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (num5 >= sizeData)
					{
						num = (short)597032964;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					b2 = data[(int)num5];
					b2 ^= crc8;
					crc8 = b2;
					num = (short)1193934849;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1D3;
				case 4:
					goto IL_159;
				case 5:
					if ((b & 128) != 0)
					{
						num = (short)249364480;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					b = (byte)(b >> 1);
					num = (short)1239678986;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_120;
				case 7:
					goto IL_120;
				case 8:
					b2 = (byte)(b2 >> 1 | 128);
					num = (short)79757321;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_221;
				case 10:
					goto IL_1D3;
				case 11:
					goto IL_221;
				}
				goto IL_89;
				IL_120:
				num = (short)1804861442;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D3:
				b &= 15;
				b2 += b;
				b = crc8;
				b &= 7;
				global::ASK.Core.Global.a(ref b, ref b2);
				b2 = global::ASK.Core.Global.a[(int)b2];
				b ^= b2;
				crc8 = b;
				num5 += 1;
				num = (short)974520327;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_221:
				b2 = (byte)(b2 >> 1);
				b2 ^= crc8;
				b = b2;
				b2 = (byte)(b2 << 1);
				b2 &= 240;
				num = (short)220594181;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_159:
			num = (short)1038614529;
			if (num != 0)
			{
			}
			return b;
			IL_89:
			b = 0;
			num5 = 0;
			num = (short)2026569734;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_53;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0001526C File Offset: 0x0001346C
		private static void a(ref byte A_0, ref byte A_1)
		{
			short num = (short)281702741;
			short num2 = num;
			num = (short)2023387477;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1694367744;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)850460672;
			if (num != 0)
			{
			}
			num = (short)1468399617;
			if (num != 0)
			{
			}
			A_0 ^= A_1;
			A_1 ^= A_0;
			A_0 ^= A_1;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0001532C File Offset: 0x0001352C
		internal static bool a(char A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
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
				{
					num2 = (short)1195507712;
					short num3 = num2;
					num2 = (short)1125974020;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_1B7;
				case 2:
					goto IL_1B7;
				case 3:
					num2 = (short)460783617;
					if (num2 != 0)
					{
					}
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
						goto IL_113;
					case ':':
					case ';':
					case '<':
					case '=':
					case '>':
					case '?':
					case '@':
						goto IL_19C;
					default:
						num2 = (short)249888768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 4:
					switch (A_0)
					{
					case 'a':
					case 'b':
					case 'c':
					case 'd':
					case 'e':
					case 'f':
						goto IL_113;
					default:
						num2 = (short)1641938950;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 5:
					goto IL_19C;
				case 6:
					IL_19A:
					num2 = (short)143065093;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_113:
				result = true;
				num2 = (short)516751362;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1B7:
				num2 = (short)1090086435;
				short num4 = num2;
				num2 = (short)1743939107;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_19A;
				default:
					goto IL_1ED;
				}
				IL_19C:
				result = false;
				num2 = (short)429326337;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1ED:
			num2 = (short)1433927680;
			if (num2 != 0)
			{
			}
			return result;
			IL_2C:
			result = false;
			num2 = (short)386596867;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00015540 File Offset: 0x00013740
		// Note: this type is marked as 'beforefieldinit'.
		static Global()
		{
			short num = (short)1326344781;
			short num2 = num;
			num = (short)457992781;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1092681728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1005060097;
			if (num != 0)
			{
			}
			num = (short)1361575936;
			if (num != 0)
			{
			}
			global::ASK.Core.Global.m_persistentData = new global::ASK.Core.PersistentData();
			global::ASK.Core.Global.a = new byte[]
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

		// Token: 0x04000063 RID: 99
		public static global::ASK.Core.PersistentData m_persistentData;

		// Token: 0x04000064 RID: 100
		private static byte[] a;
	}
}
