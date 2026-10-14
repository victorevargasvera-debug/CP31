using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x0200019A RID: 410
	public sealed class UnpackAndpackExtProgmgSrc : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06004510 RID: 17680 RVA: 0x00400E60 File Offset: 0x003FF060
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_D8;
			}
			int num;
			int num2;
			string result;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_397;
				case 1:
					goto IL_279;
				case 2:
					goto IL_41D;
				case 3:
					goto IL_2BF;
				case 4:
					switch (num2)
					{
					case 0:
						result = global::CommonResources.AcgResources.ID_DEPOT;
						num3 = (short)772341788;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 1:
						result = global::CommonResources.AcgResources.ID_FACTORY;
						num3 = (short)1902247958;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 2:
						result = global::CommonResources.AcgResources.ID_DEBUGCPS;
						num3 = (short)1208025117;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 3:
						result = global::CommonResources.AcgResources.ID_CPS;
						num3 = (short)481755159;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 4:
						result = global::CommonResources.AcgResources.ID_DOSRSS;
						num3 = (short)1494482945;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 5:
						result = global::CommonResources.AcgResources.ID_LABTOOL;
						num3 = (short)1223163943;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 6:
						result = global::CommonResources.AcgResources.ID_BETACPS;
						num3 = (short)1876688932;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 7:
						result = global::CommonResources.AcgResources.ID_RADIOCLONING;
						num3 = (short)2129199151;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 8:
						result = global::CommonResources.AcgResources.ID_ASTS;
						num3 = (short)425918488;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 9:
						result = global::CommonResources.AcgResources.ID_DEVELOPMENTCPS;
						num3 = (short)1392050213;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 10:
						num3 = (short)1782775809;
						if (num3 != 0)
						{
						}
						result = global::CommonResources.AcgResources.ID_DEVELOPMENTDEPOT;
						num3 = (short)404291614;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 11:
						result = global::CommonResources.AcgResources.ID_DEVELOPMENTFACTORY;
						num3 = (short)42926087;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 12:
						result = global::CommonResources.AcgResources.ID_DEVELOPMENTLABTOOL;
						num3 = (short)242089986;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 13:
						result = global::CommonResources.AcgResources.ID_ALPHACPS;
						num3 = (short)2100101139;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 14:
						result = global::CommonResources.AcgResources.ID_ALPHADEPOT;
						num3 = (short)728956933;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 15:
						result = global::CommonResources.AcgResources.ID_ALPHAFACTORY;
						num3 = (short)311230482;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 16:
						result = global::CommonResources.AcgResources.ID_ALPHALABTOOL;
						num3 = (short)1065811979;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 17:
						result = global::CommonResources.AcgResources.ID_BETADEPOT;
						num3 = (short)797376518;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 18:
						result = global::CommonResources.AcgResources.ID_BETAFACTORY;
						num3 = (short)1939013632;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 19:
						result = global::CommonResources.AcgResources.ID_BETALABTOOL;
						num3 = (short)1132396586;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 20:
						result = global::CommonResources.AcgResources.ID_LAB;
						num3 = (short)471662605;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 21:
					{
						result = global::CommonResources.AcgResources.ID_DEBUGDEVELOPMENTCPS;
						num3 = (short)1037500416;
						short num4 = num3;
						num3 = (short)111280168;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					case 22:
						result = global::CommonResources.AcgResources.ID_DEBUGDEVELOPMENTDEPOT;
						num3 = (short)333053979;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 23:
						result = global::CommonResources.AcgResources.ID_DEBUGDEVELOPMENTFACTORY;
						num3 = (short)2102067225;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 24:
						result = global::CommonResources.AcgResources.ID_DEBUGDEVELOPMENTLABTOOL;
						num3 = (short)1200750638;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 25:
						result = global::CommonResources.AcgResources.ID_DEBUGALPHACPS;
						goto IL_2CA;
					case 26:
						result = global::CommonResources.AcgResources.ID_DEBUGALPHADEPOT;
						num3 = (short)522321928;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 27:
						result = global::CommonResources.AcgResources.ID_DEBUGALPHAFACTORY;
						num3 = (short)1146814498;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 28:
						result = global::CommonResources.AcgResources.ID_DEBUGALPHALABTOOL;
						num3 = (short)745472033;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 29:
						result = global::CommonResources.AcgResources.ID_DEBUGBETACPS;
						num3 = (short)1123811359;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 30:
						result = global::CommonResources.AcgResources.ID_DEBUGBETADEPOT;
						num3 = (short)65077257;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 31:
						result = global::CommonResources.AcgResources.ID_DEBUGBETAFACTORY;
						num3 = (short)307167247;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 32:
						result = global::CommonResources.AcgResources.ID_DEBUGBETALABTOOL;
						num3 = (short)1415512090;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 33:
						result = global::CommonResources.AcgResources.ID_DEBUGDEPOT;
						num3 = (short)1869807630;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 34:
						result = global::CommonResources.AcgResources.ID_DEBUGFACTORY;
						num3 = (short)977666092;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 35:
						result = global::CommonResources.AcgResources.ID_DEBUGLABTOOL;
						num3 = (short)985399334;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 36:
						result = global::CommonResources.AcgResources.ID_PROTOCPS;
						num3 = (short)936116267;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 37:
						result = global::CommonResources.AcgResources.ID_PROTODEPOT;
						num3 = (short)1760231469;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 38:
						result = global::CommonResources.AcgResources.ID_PROTOFACTORY;
						num3 = (short)365428748;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 39:
						result = global::CommonResources.AcgResources.ID_PROTOLABTOOL;
						num3 = (short)1501626389;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 40:
						result = global::CommonResources.AcgResources.ID_DEBUGPROTOCPS;
						num3 = (short)1360396305;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 41:
						result = global::CommonResources.AcgResources.ID_DEBUGPROTODEPOT;
						num3 = (short)655818784;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 42:
						result = global::CommonResources.AcgResources.ID_DEBUGPROTOFACTORY;
						num3 = (short)1594687491;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 43:
						result = global::CommonResources.AcgResources.ID_DEBUGPROTOLABTOOL;
						num3 = (short)1883832369;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 44:
						result = global::CommonResources.AcgResources.ID_HOSTEDDEPOT;
						num3 = (short)65470480;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 45:
						result = global::CommonResources.AcgResources.ID_RADIOCENTRAL;
						num3 = (short)1486487600;
						num = (int)((global::System.IntPtr)num3);
						continue;
					default:
						num3 = (short)2087190563;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				case 5:
					goto IL_4ED;
				case 6:
					goto IL_483;
				case 7:
					return result;
				case 8:
					goto IL_210;
				case 9:
					return result;
				case 10:
					result = global::CommonResources.AcgResources.ID_DEPOT;
					num3 = (short)1540030505;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 11:
					return result;
				case 12:
					goto IL_256;
				case 13:
					return result;
				case 14:
					return result;
				case 15:
					goto IL_29B;
				case 16:
					return result;
				case 17:
					goto IL_353;
				case 18:
					return result;
				case 19:
					return result;
				case 20:
					goto IL_2E3;
				case 21:
					return result;
				case 22:
					return result;
				case 23:
					return result;
				case 24:
					goto IL_234;
				case 25:
					return result;
				case 26:
					goto IL_1EE;
				case 27:
					return result;
				case 28:
					return result;
				case 29:
					return result;
				case 30:
					goto IL_32F;
				case 31:
					goto IL_4C9;
				case 32:
					goto IL_43F;
				case 33:
					return result;
				case 34:
					return result;
				case 35:
					num3 = (short)1523515402;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 36:
					goto IL_3FA;
				case 37:
					goto IL_511;
				case 38:
					goto IL_461;
				case 39:
					return result;
				case 40:
					return result;
				case 41:
					return result;
				case 42:
					goto IL_4A6;
				case 43:
					return result;
				case 44:
					return result;
				case 45:
				{
					num3 = (short)2007836063;
					short num5 = num3;
					num3 = (short)1622091167;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2CA;
					default:
						goto IL_568;
					}
					break;
				}
				case 46:
					return result;
				case 47:
					goto IL_3D8;
				case 48:
					goto IL_375;
				case 49:
					return result;
				}
				goto IL_D8;
				IL_2CA:
				num3 = (short)1323958292;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_1EE:
			IL_210:
			IL_234:
			IL_256:
			IL_279:
			IL_29B:
			IL_2BF:
			IL_2E3:
			IL_32F:
			IL_353:
			IL_375:
			IL_397:
			IL_3D8:
			IL_3FA:
			IL_41D:
			IL_43F:
			IL_461:
			IL_483:
			IL_4A6:
			IL_4C9:
			IL_4ED:
			IL_511:
			return result;
			IL_568:
			num3 = (short)899874816;
			if (num3 != 0)
			{
			}
			return result;
			IL_D8:
			num2 = global::System.Convert.ToInt32(value);
			num3 = (short)1842675716;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x00401754 File Offset: 0x003FF954
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_238;
			}
			int num;
			string a;
			short num2;
			int num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (a == global::CommonResources.AcgResources.ID_LAB)
					{
						num2 = (short)1258487910;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)312296844;
					short num3 = num2;
					num2 = (short)632702348;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AE8;
					default:
						num2 = (short)732626944;
						if (num2 != 0)
						{
						}
						num2 = (short)1769406512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num4 = 3;
					num2 = (short)407896158;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_136E;
				case 3:
					goto IL_7B8;
				case 4:
					if (a == global::CommonResources.AcgResources.ID_HOSTEDDEPOT)
					{
						num2 = (short)775880791;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1151270983;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_F5E;
				case 6:
					goto IL_110E;
				case 7:
					num4 = 25;
					num2 = (short)1994522657;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (a == global::CommonResources.AcgResources.ID_DEBUGPROTOLABTOOL)
					{
						num2 = (short)892010536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)453509124;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (a == global::CommonResources.AcgResources.ID_DEBUGCPS)
					{
						num2 = (short)2052390935;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1093664885;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (a == global::CommonResources.AcgResources.ID_PROTOLABTOOL)
					{
						num2 = (short)937361458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)67633271;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (a == global::CommonResources.AcgResources.ID_DEBUGDEVELOPMENTFACTORY)
					{
						num2 = (short)2134114349;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)347865151;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num4 = 6;
					num2 = (short)211746836;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_DE7;
				case 14:
					num4 = 16;
					num2 = (short)533004401;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (a == global::CommonResources.AcgResources.ID_DEBUGALPHALABTOOL)
					{
						num2 = (short)1273626738;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)247005256;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (a == global::CommonResources.AcgResources.ID_FACTORY)
					{
						num2 = (short)2066219064;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)413073417;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					num4 = 8;
					num2 = (short)1987051596;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num4 = 32;
					num2 = (short)383516678;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (a == global::CommonResources.AcgResources.ID_ALPHADEPOT)
					{
						num2 = (short)1897005099;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1113456758;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					goto IL_914;
				case 21:
					num4 = 7;
					num2 = (short)1721237538;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					goto IL_BAE;
				case 23:
					num4 = 2;
					num2 = (short)189792378;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					if (a == global::CommonResources.AcgResources.ID_DEBUGDEPOT)
					{
						num2 = (short)1934819354;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2032926800;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (a == global::CommonResources.AcgResources.ID_PROTOCPS)
					{
						num2 = (short)1548419113;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)187105388;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					num4 = 33;
					num2 = (short)1016660074;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					goto IL_6EF;
				case 28:
					if (a == global::CommonResources.AcgResources.ID_ALPHACPS)
					{
						num2 = (short)642449529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)80150547;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					goto IL_149E;
				case 30:
					goto IL_51F;
				case 31:
					num4 = 31;
					num2 = (short)9109579;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					if (a == global::CommonResources.AcgResources.ID_ALPHALABTOOL)
					{
						num2 = (short)478674958;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)975896645;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					goto IL_C99;
				case 34:
					goto IL_582;
				case 35:
					num4 = 9;
					num2 = (short)540999745;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
					goto IL_1065;
				case 37:
					goto IL_FE0;
				case 38:
					num4 = 0;
					num2 = (short)86638622;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 39:
					if (a == global::CommonResources.AcgResources.ID_ASTS)
					{
						num2 = (short)1031471121;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)407830592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					num4 = 43;
					num2 = (short)1294532737;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					num4 = 36;
					num2 = (short)58589312;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 42:
					if (a == global::CommonResources.AcgResources.ID_BETALABTOOL)
					{
						num2 = (short)399704162;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)418512896;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					num4 = 14;
					num2 = (short)124321819;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 44:
					num4 = 18;
					num2 = (short)1967915103;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 45:
					num4 = 23;
					num2 = (short)1137639555;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 46:
					goto IL_A1F;
				case 47:
					if (a == global::CommonResources.AcgResources.ID_PROTOFACTORY)
					{
						num2 = (short)1966997601;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1287585802;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 48:
					if (a == global::CommonResources.AcgResources.ID_DEBUGDEVELOPMENTCPS)
					{
						num2 = (short)678035524;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2048000054;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 49:
					goto IL_4BA;
				case 50:
					num4 = 39;
					num2 = (short)1468661872;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 51:
					num4 = 37;
					num2 = (short)1789132899;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 52:
					if (a == global::CommonResources.AcgResources.ID_DEBUGPROTODEPOT)
					{
						num2 = (short)454426747;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1251475513;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 53:
					goto IL_456;
				case 54:
					if (a == global::CommonResources.AcgResources.ID_DEBUGDEVELOPMENTDEPOT)
					{
						num2 = (short)1078526067;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2093219851;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 55:
					num4 = 29;
					num2 = (short)226754651;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 56:
					num4 = 1;
					num2 = (short)666435670;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 57:
					if (a == global::CommonResources.AcgResources.ID_DEBUGPROTOFACTORY)
					{
						num2 = (short)637861978;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)687734792;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 58:
					num4 = 40;
					num2 = (short)2063335446;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 59:
					num4 = 24;
					num2 = (short)1211105381;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 60:
					goto IL_B07;
				case 61:
					if (a == global::CommonResources.AcgResources.ID_DEBUGBETAFACTORY)
					{
						num2 = (short)1615790111;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1241710677;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 62:
					if (a == global::CommonResources.AcgResources.ID_DEBUGBETADEPOT)
					{
						num2 = (short)2031747196;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)520355901;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 63:
					if (a == global::CommonResources.AcgResources.ID_DEBUGDEVELOPMENTLABTOOL)
					{
						num2 = (short)1780940859;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1919025236;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 64:
					if (a == global::CommonResources.AcgResources.ID_DEVELOPMENTCPS)
					{
						num2 = (short)565051427;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)816119874;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 65:
					goto IL_F7D;
				case 66:
					if (a == global::CommonResources.AcgResources.ID_DEVELOPMENTDEPOT)
					{
						num2 = (short)1172504646;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)751173706;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 67:
					if (a == global::CommonResources.AcgResources.ID_DEBUGLABTOOL)
					{
						num2 = (short)1845952615;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1861156889;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 68:
					num4 = 21;
					num2 = (short)329252960;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 69:
					if (a == global::CommonResources.AcgResources.ID_BETADEPOT)
					{
						num2 = (short)870711369;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1400963188;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 70:
					num4 = 10;
					num2 = (short)494403684;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 71:
					if (a == global::CommonResources.AcgResources.ID_RADIOCENTRAL)
					{
						num2 = (short)1279852680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14BF;
				case 72:
					if (a == global::CommonResources.AcgResources.ID_DEBUGBETACPS)
					{
						num2 = (short)1464926263;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1925840958;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 73:
					num4 = 17;
					num2 = (short)791412847;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 74:
					if (a == global::CommonResources.AcgResources.ID_DEVELOPMENTFACTORY)
					{
						num2 = (short)65208398;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1696792685;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 75:
					goto IL_3D1;
				case 76:
					goto IL_A5D;
				case 77:
					if (a == global::CommonResources.AcgResources.ID_LABTOOL)
					{
						num2 = (short)411762813;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1130168457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 78:
					num4 = 11;
					num2 = (short)1472921653;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 79:
					goto IL_8B8;
				case 80:
					if (a == global::CommonResources.AcgResources.ID_DEBUGFACTORY)
					{
						num2 = (short)186843271;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)606928963;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 81:
					num4 = 4;
					num2 = (short)573898789;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 82:
					goto IL_AE8;
				case 83:
					if (a == global::CommonResources.AcgResources.ID_DEBUGALPHAFACTORY)
					{
						num2 = (short)980877422;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)210370575;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 84:
					if (a == global::CommonResources.AcgResources.ID_DEBUGALPHACPS)
					{
						num2 = (short)829882375;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1012859014;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 85:
					if (a == global::CommonResources.AcgResources.ID_DEBUGBETALABTOOL)
					{
						num2 = (short)1055064082;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)347340824;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 86:
					goto IL_85A;
				case 87:
					num4 = 44;
					num2 = (short)1896415281;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 88:
					goto IL_87A;
				case 89:
					if (a == global::CommonResources.AcgResources.ID_DOSRSS)
					{
						num2 = (short)85786705;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2054094925;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 90:
					num4 = 42;
					num2 = (short)1710882920;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 91:
					goto IL_6CE;
				case 92:
					goto IL_3F1;
				case 93:
					goto IL_D5C;
				case 94:
					goto IL_A3E;
				case 95:
					goto IL_66E;
				case 96:
					goto IL_D3C;
				case 97:
					num4 = 38;
					num2 = (short)1893335100;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 98:
					num4 = 19;
					num2 = (short)1540882468;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 99:
					goto IL_36C;
				case 100:
					goto IL_70E;
				case 101:
					goto IL_12A5;
				case 102:
					num4 = 20;
					num2 = (short)1180172381;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 103:
					num4 = 35;
					num2 = (short)144048174;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 104:
					goto IL_979;
				case 105:
					goto IL_14BA;
				case 106:
					goto IL_CFE;
				case 107:
				{
					num2 = (short)1961623552;
					short num5 = num2;
					num4 = 26;
					num2 = (short)1703608333;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 108:
					if (a == global::CommonResources.AcgResources.ID_PROTODEPOT)
					{
						num2 = (short)1204879411;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)570228783;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 109:
					if (a == global::CommonResources.AcgResources.ID_DEVELOPMENTLABTOOL)
					{
						num2 = (short)346816644;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1875312668;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 110:
					num4 = 27;
					num2 = (short)121438335;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 111:
					goto IL_8D7;
				case 112:
					goto IL_8F6;
				case 113:
					goto IL_899;
				case 114:
					num4 = 28;
					num2 = (short)1423704069;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 115:
					num4 = 22;
					num2 = (short)1347223640;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 116:
					if (a == global::CommonResources.AcgResources.ID_BETAFACTORY)
					{
						num2 = (short)1705508908;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)330563626;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 117:
					if (a == global::CommonResources.AcgResources.ID_CPS)
					{
						num2 = (short)934543361;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1300758617;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 118:
					if (a == global::CommonResources.AcgResources.ID_ALPHAFACTORY)
					{
						num2 = (short)1008140370;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)428474400;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 119:
					if (a == global::CommonResources.AcgResources.ID_DEBUGPROTOCPS)
					{
						num2 = (short)420085818;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1299120180;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 120:
					if (a == global::CommonResources.AcgResources.ID_RADIOCLONING)
					{
						num2 = (short)176357397;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2020999207;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 121:
					num4 = 13;
					num2 = (short)1799422085;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 122:
					goto IL_11FB;
				case 123:
					num4 = 41;
					num2 = (short)496762972;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 124:
					num4 = 30;
					num2 = (short)724238441;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 125:
					num4 = 5;
					num2 = (short)1261568130;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 126:
					if (a == global::CommonResources.AcgResources.ID_DEPOT)
					{
						num2 = (short)1845493798;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2036924432;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 127:
					goto IL_D1D;
				case 128:
					goto IL_F3E;
				case 129:
					goto IL_E06;
				case 130:
					goto IL_147F;
				case 131:
					goto IL_12C5;
				case 132:
					num4 = 12;
					num2 = (short)1629159427;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 133:
					goto IL_1045;
				case 134:
					if (a == global::CommonResources.AcgResources.ID_DEBUGALPHADEPOT)
					{
						num2 = (short)1393885291;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1477574739;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 135:
					num4 = 34;
					num2 = (short)918945871;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 136:
					num4 = 45;
					num2 = (short)130547741;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 137:
					if (a == global::CommonResources.AcgResources.ID_BETACPS)
					{
						num2 = (short)747831308;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)185204856;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_238;
				IL_AE8:
				num4 = 15;
				num2 = (short)78118914;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_36C:
			IL_3D1:
			IL_3F1:
			IL_456:
			IL_4BA:
			IL_51F:
			IL_582:
			IL_66E:
			IL_6CE:
			IL_6EF:
			IL_70E:
			IL_7B8:
			IL_85A:
			IL_87A:
			IL_899:
			IL_8B8:
			IL_8D7:
			IL_8F6:
			IL_914:
			IL_979:
			IL_A1F:
			IL_A3E:
			IL_A5D:
			IL_B07:
			IL_BAE:
			IL_C99:
			IL_CFE:
			IL_D1D:
			IL_D3C:
			IL_D5C:
			IL_DE7:
			IL_E06:
			IL_F3E:
			IL_F5E:
			IL_F7D:
			IL_FE0:
			IL_1045:
			IL_1065:
			IL_110E:
			IL_11FB:
			IL_12A5:
			IL_12C5:
			goto IL_14BF;
			IL_136E:
			num2 = (short)438960129;
			if (num2 != 0)
			{
			}
			IL_147F:
			IL_149E:
			IL_14BA:
			IL_14BF:
			return num4;
			IL_238:
			num4 = 0;
			a = global::System.Convert.ToString(value);
			num2 = (short)1496449150;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
