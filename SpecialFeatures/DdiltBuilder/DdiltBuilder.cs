using System;
using System.Collections.Generic;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DdiltBuilder
{
	// Token: 0x02000145 RID: 325
	public class DdiltBuilder
	{
		// Token: 0x060010A5 RID: 4261 RVA: 0x00174170 File Offset: 0x00172370
		public byte[] DdiltBuild(ushort[] IshType, ushort[] UclLifeTimeMax)
		{
			int a_ = 13;
			short num = (short)2023882752;
			switch (num)
			{
			default:
			{
				num = (short)796000272;
				int num2 = (int)((global::System.IntPtr)num);
				global::SpecialFeatures.DdiltBuilder.DdiltContainer ddiltContainer;
				byte[] array;
				for (;;)
				{
					int num3;
					ushort num4;
					ushort num5;
					int num8;
					switch (num2)
					{
					case 0:
						num = (short)779550746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_327;
					case 2:
						goto IL_3DC;
					case 3:
					{
						if (num3 >= (int)(num4 + num5 * 2))
						{
							num = (short)558104609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num6 = IshType[num3];
						ushort num7 = IshType[num3 + 1];
						num = (short)443940891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup;
						global::System.Collections.Generic.SortedDictionary<ushort, ushort> multiInstanceEntries = ddiltGroup.MultiInstanceEntries;
						ushort num6;
						ushort key = num6;
						ushort num7;
						multiInstanceEntries[key] += num7;
						num = (short)683081741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_417;
					case 6:
					{
						if (num8 >= IshType.Length)
						{
							num = (short)1685520389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort partitionNum = IshType[num8];
						num5 = IshType[num8 + 1];
						num4 = (ushort)(num8 + 2);
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup = default(global::SpecialFeatures.DdiltBuilder.DdiltGroup);
						ddiltGroup.PartitionNum = partitionNum;
						ddiltGroup.MultiInstanceEntries = new global::System.Collections.Generic.SortedDictionary<ushort, ushort>(new global::SpecialFeatures.DdiltBuilder.DDILTComparer());
						ushort firstSingleInstance;
						ddiltGroup.FirstSingleInstance = firstSingleInstance;
						ushort num9 = 0;
						num3 = (int)num4;
						num = (short)445186069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup;
						if (ddiltGroup.PartitionNum == 208)
						{
							num = (short)1919942675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1133707279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_100;
					case 9:
					{
						ushort num6;
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup;
						if (num6 < ddiltGroup.FirstSingleInstance)
						{
							num = (short)660733982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_327;
					}
					case 10:
						goto IL_545;
					case 11:
					{
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup;
						ddiltGroup.MultiInstanceEntries.Add(999, 10);
						ddiltGroup.NumberTableEntries = (ushort)(ddiltGroup.MultiInstanceEntries.Count + 1);
						ddiltContainer.SecGroup = ddiltGroup;
						num = (short)1107099677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						if (IshType == null)
						{
							num = (short)649658402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort firstSingleInstance = 14745;
						array = new byte[16384];
						ddiltContainer = new global::SpecialFeatures.DdiltBuilder.DdiltContainer();
						ddiltContainer.LifeTimeMax = UclLifeTimeMax;
						ddiltContainer.MagicNumber = 1129530456U;
						ddiltContainer.Reserved = uint.MaxValue;
						ddiltContainer.ChecksumRange = 16384U;
						ddiltContainer.VersionNumber = 1375928576U;
						ddiltContainer.CodeplugGroupID = 1129334616U;
						ddiltContainer.UclGroupID = 1430473816U;
						ddiltContainer.SecGroupID = 1397048152U;
						num8 = 0;
						num = (short)987562006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_327;
					case 14:
						goto IL_301;
					case 15:
					{
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup;
						if (ddiltGroup.PartitionNum != 210)
						{
							num = (short)1936719872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_301;
					}
					case 16:
						switch (0)
						{
						case 0:
							goto IL_DD;
						}
						continue;
					case 17:
						goto IL_100;
					case 18:
						goto IL_FB;
					case 19:
					{
						ushort value = 2001;
						ushort[] array2 = new ushort[]
						{
							3974,
							3973,
							3972,
							3971,
							3970,
							3969,
							3968,
							3967
						};
						int num10 = 0;
						num = (short)363462664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						ushort num6;
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup;
						if (num6 > ddiltGroup.LastSingleInstance)
						{
							num = (short)319684640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_545;
					}
					case 21:
						goto IL_168;
					case 22:
						goto IL_3DC;
					case 23:
					{
						num = (short)1824522241;
						if (num != 0)
						{
						}
						ushort[] array2;
						int num10;
						if (num10 >= array2.Length)
						{
							num = (short)832634908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort key2 = array2[num10];
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup;
						ushort value;
						ddiltGroup.MultiInstanceEntries[key2] = value;
						num10++;
						num = (short)539361297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_168;
					case 25:
					{
						ushort num6;
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup;
						ushort num9;
						if (ddiltGroup.MultiInstanceEntries.TryGetValue(num6, out num9))
						{
							num = (short)721420292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num7;
						ddiltGroup.MultiInstanceEntries.Add(num6, num7);
						num = (short)604110849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup;
						if (ddiltGroup.PartitionNum != 212)
						{
							goto IL_762;
						}
						num = (short)1976888662;
						short num11 = num;
						num = (short)1912859990;
						switch ((num11 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_34A;
						default:
							num = (short)160890880;
							if (num != 0)
							{
							}
							num = (short)1919090699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 27:
					{
						ushort num6;
						if (num6 < 2000)
						{
							num = (short)1641807907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)408616985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
					{
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup;
						ddiltGroup.MultiInstanceEntries.Add(3762, 10);
						ddiltGroup.NumberTableEntries = (ushort)(ddiltGroup.MultiInstanceEntries.Count + 1);
						ddiltContainer.CodePlugGroup = ddiltGroup;
						num = (short)463077390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						goto IL_301;
					case 30:
					{
						ushort num6;
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup;
						ddiltGroup.FirstSingleInstance = num6;
						num = (short)352387103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_327;
					case 32:
					{
						ushort num6;
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup;
						ddiltGroup.LastSingleInstance = num6;
						num = (short)2064187402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						global::SpecialFeatures.DdiltBuilder.DdiltGroup ddiltGroup;
						ddiltGroup.Reserved = ushort.MaxValue;
						num = (short)1251409927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						goto IL_75D;
					case 35:
						goto IL_34A;
					}
					IL_DD:
					if (UclLifeTimeMax == null)
					{
						num = (short)1678049298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1125187596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_100:
					num = (short)702480407;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_168:
					num = (short)1662124035;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_301:
					num8 = (int)(num4 + num5 * 2);
					num = (short)8388610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_327:
					num3 += 2;
					num = (short)250544152;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34A:
					num = (short)2144010260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DC:
					num = (short)313131014;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_545:
					num = (short)1892548617;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FB:
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얏\uda95ﲙ鍊쪝즟쾡솣즧튩", a_));
				IL_417:
				ddiltContainer.VectorCount = 3U;
				ddiltContainer.CodeplugGroupVector = 48U;
				ddiltContainer.UclGroupVector = ddiltContainer.CodeplugGroupVector + 4U + (uint)(ddiltContainer.CodePlugGroup.NumberTableEntries * 4);
				ddiltContainer.SecGroupVector = ddiltContainer.UclGroupVector + 4U + (uint)((ddiltContainer.LifeTimeMax.Length + 2) * 2);
				ddiltContainer.Checksum = 0U;
				byte[] array3 = ddiltContainer.ConvertToBytes();
				uint a_2;
				uint a_3;
				global::SpecialFeatures.DdiltBuilder.DdiltBuilder.a(array3, array, out a_2, out a_3);
				uint num12 = this.a(array, a_2, a_3);
				array3[20] = (byte)(num12 >> 24);
				array3[21] = (byte)(num12 >> 16);
				array3[22] = (byte)(num12 >> 8);
				array3[23] = (byte)num12;
				return array3;
				IL_75D:
				num = (short)82182144;
				short num13 = num;
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98fﲓ슕鍊", a_));
				IL_762:
				throw new global::System.ArgumentOutOfRangeException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98fﲑ뺝쎡횣튥솧\udea9얫솭\udeaf銱荒쎵햷\ud8b9\ud9bb첽", a_));
			}
			}
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x001749F8 File Offset: 0x00172BF8
		private static void a(byte[] A_0, byte[] A_1, out uint A_2, out uint A_3)
		{
			int a_ = 16;
			short num = (short)177995781;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_1B8;
				case 1:
					if (A_0.Length < 15)
					{
						num = (short)2091384835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					A_2 = 8U;
					A_3 = (uint)A_1.Length;
					num3 = 0;
					num = (short)68157456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)2026242052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_15D;
				case 4:
					if ((long)num3 >= 24L)
					{
						num = (short)2084044820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C1;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_89;
					}
					continue;
				case 6:
					if ((long)num3 >= 24L)
					{
						num = (short)1613955079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C1;
				case 7:
					A_1[num3 - 4] = A_0[num3];
					num = (short)885260307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (A_0 == null)
					{
						num = (short)713359360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1424293889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_1FA;
				case 10:
				{
					num = (short)577830913;
					if (num != 0)
					{
					}
					num = (short)2102722560;
					short num4 = num;
					goto IL_2C1;
				}
				case 11:
					A_1[num3] = A_0[num3];
					num = (short)1174274061;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					num = (short)101382002;
					short num5 = num;
					num = (short)1982527346;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_239;
					default:
						goto IL_400;
					}
					break;
				}
				case 13:
					goto IL_2C1;
				case 14:
					if (num3 >= A_0.Length)
					{
						num = (short)1335820309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1459683350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_A5;
				case 16:
					goto IL_1FA;
				case 17:
					if ((long)num3 >= (long)((ulong)(A_3 + 4U)))
					{
						num = (short)2099249164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)52232206;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if ((long)num3 >= 20L)
					{
						num = (short)628686850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E2;
				case 19:
					goto IL_2C1;
				case 20:
					goto IL_2E2;
				case 21:
					goto IL_239;
				case 22:
					if ((long)num3 < 20L)
					{
						num = (short)1932197899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)148963346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_89:
				if (A_1 == null)
				{
					num = (short)962068495;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1466302472;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1FA:
				num = (short)1808662545;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_239:
				A_1[num3 - 4] = byte.MaxValue;
				num = (short)473104394;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C1:
				num3++;
				num = (short)959643657;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E2:
				num = (short)471990278;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A5:
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힒ﺖ출ﺞ펠힢", a_));
			IL_15D:
			throw new global::System.ArgumentOutOfRangeException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶒ톔튞튠쒢", a_));
			IL_1B8:
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶒ톔튞튠쒢", a_));
			IL_400:
			num = (short)1668743168;
			if (num != 0)
			{
			}
			A_3 -= A_2;
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00174E24 File Offset: 0x00173024
		private uint a(byte[] A_0, uint A_1, uint A_2)
		{
			int a_ = 8;
			short num = (short)1855651840;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				uint num3;
				for (;;)
				{
					IL_30:
					uint num5;
					switch (num2)
					{
					case 0:
					{
						num = (short)192479233;
						if (num != 0)
						{
						}
						uint num4;
						if (4294967295U - num3 < num4)
						{
							num = (short)982515716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 += num4;
						num = (short)848429071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						uint num6;
						if (num5 >= num6)
						{
							num = (short)1931018242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num4 = (uint)A_0[(int)num5];
						num = (short)844300294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_13C;
					case 3:
						goto IL_1A6;
					case 4:
					{
						num = (short)1740439552;
						short num7 = num;
						uint num4;
						num3 = num4 - (uint.MaxValue - num3 + 1U);
						num = (short)154468355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (A_0 == null)
						{
							num = (short)721813512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1650589705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						uint num4;
						if (4294967295U - num3 < num4)
						{
							num = (short)335413260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 += num4;
						num = (short)502005773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_101;
					case 8:
						goto IL_FC;
					case 9:
					{
						if ((ulong)A_2 > (ulong)((long)A_0.Length - (long)((ulong)A_1)))
						{
							num = (short)1322385418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num6 = A_1 + A_2;
						num5 = A_1;
						num = (short)2089615374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_1EA;
					case 11:
						goto IL_1EF;
					case 12:
					{
						uint num4;
						num3 = num4 - (uint.MaxValue - num3 + 1U);
						num = (short)152305675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_1EF;
					case 14:
						goto IL_101;
					case 15:
						goto IL_22E;
					}
					goto IL_77;
					IL_101:
					num = (short)1383137281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EF:
					num5 += 1U;
					num = (short)1453916167;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FC:
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
				IL_1A6:
				goto IL_369;
				IL_1EA:
				throw new global::System.ArgumentOutOfRangeException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮊﲎ뎒ﾖﲘ뮚ﾜ잠얢삤햦覨캪쎬쮮", a_));
				IL_22E:
				IL_369:
				num3 = uint.MaxValue - num3 + 1U;
				return num3;
				IL_77:
				num3 = 0U;
				num = (short)2032329280;
				short num8 = num;
				num = (short)588767808;
				switch ((num8 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_13C:
					uint num4 = 1020U;
					num = (short)1234632704;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				default:
					num = (short)115671040;
					if (num != 0)
					{
					}
					num = (short)942866437;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				break;
			}
			}
		}

		// Token: 0x040008EA RID: 2282
		private const uint a = 1375928576U;

		// Token: 0x040008EB RID: 2283
		private const uint b = 1129530456U;

		// Token: 0x040008EC RID: 2284
		private const uint c = 16384U;

		// Token: 0x040008ED RID: 2285
		private const uint d = 4294967295U;

		// Token: 0x040008EE RID: 2286
		private const ushort e = 65535;

		// Token: 0x040008EF RID: 2287
		private const uint f = 1129334616U;

		// Token: 0x040008F0 RID: 2288
		private const uint g = 1430473816U;

		// Token: 0x040008F1 RID: 2289
		private const uint h = 1397048152U;

		// Token: 0x040008F2 RID: 2290
		private const ushort i = 208;

		// Token: 0x040008F3 RID: 2291
		private const ushort j = 212;

		// Token: 0x040008F4 RID: 2292
		private const ushort k = 210;

		// Token: 0x040008F5 RID: 2293
		private const uint l = 4U;

		// Token: 0x040008F6 RID: 2294
		private const uint m = 20U;

		// Token: 0x040008F7 RID: 2295
		private const ushort n = 3762;

		// Token: 0x040008F8 RID: 2296
		private const ushort o = 999;

		// Token: 0x040008F9 RID: 2297
		private const ushort p = 10;

		// Token: 0x040008FA RID: 2298
		private const ushort q = 2000;
	}
}
