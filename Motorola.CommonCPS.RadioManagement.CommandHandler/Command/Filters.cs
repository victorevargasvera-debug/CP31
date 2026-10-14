using System;
using System.Globalization;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200001C RID: 28
	public static class Filters
	{
		// Token: 0x06000180 RID: 384 RVA: 0x0000DFCC File Offset: 0x0000C1CC
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile A_0, string A_1)
		{
			short num = (short)1204682753;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.TemplateName.a(A_1))
					{
						num = (short)1573519368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 2:
					if (!A_0.RadioAlias.a(A_1))
					{
						num = (short)1364525062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					goto IL_73;
				case 4:
				{
					num = (short)1089966354;
					short num3 = num;
					num = (short)1014337810;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_73;
					default:
						goto IL_EA;
					}
					break;
				}
				case 5:
					if (!A_0.OtarProfileName.a(A_1))
					{
						num = (short)2136539145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					num = (short)2030239745;
					if (num != 0)
					{
					}
					num = (short)178847749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (!A_0.IndependentList.a(A_1))
					{
						num = (short)914751492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 8:
					num = (short)2006188034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					num = (short)209321984;
					short num4 = num;
					num = (short)110231559;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4C:
				if (!A_0.SerialNumber.a(A_1))
				{
					num = (short)166395907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_73:
				num = (short)31653888;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EA:
			num = (short)480182272;
			if (num != 0)
			{
			}
			return A_0.OtarID.a(A_1);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000E204 File Offset: 0x0000C404
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo A_0, string A_1)
		{
			short num = (short)781189121;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.TemplateName.a(A_1))
					{
						num = (short)1111162888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 2:
					if (!A_0.RadioAlias.a(A_1))
					{
						num = (short)1692729350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					goto IL_97;
				case 4:
				{
					num = (short)652208367;
					short num3 = num;
					num = (short)1214114031;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_97;
					default:
						goto IL_112;
					}
					break;
				}
				case 5:
					if (!A_0.OtarProfileName.a(A_1))
					{
						num = (short)1197277184;
						short num4 = num;
						num = (short)656605193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					num = (short)1214578693;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (!A_0.IndependentList.a(A_1))
					{
						num = (short)1910636548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 8:
					num = (short)1911685122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1898381319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4C:
				num = (short)1693384705;
				if (num != 0)
				{
				}
				if (!A_0.SerialNumber.a(A_1))
				{
					num = (short)881655811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_97:
				num = (short)1988100096;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_112:
			num = (short)1200750592;
			if (num != 0)
			{
			}
			return A_0.OtarID.a(A_1);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000E43C File Offset: 0x0000C63C
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo A_0, string A_1)
		{
			short num = (short)669777921;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.TemplateName.a(A_1))
					{
						num = (short)2105475080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 2:
					if (!A_0.RadioAlias.a(A_1))
					{
						num = (short)1412759558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					goto IL_72;
				case 4:
				{
					num = (short)444836143;
					short num3 = num;
					num = (short)214608175;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_72;
					default:
						goto IL_E7;
					}
					break;
				}
				case 5:
					if (!A_0.OtarProfileName.a(A_1))
					{
						num = (short)897974272;
						short num4 = num;
						num = (short)1494417417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					num = (short)1678573573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (!A_0.IndependentList.a(A_1))
					{
						num = (short)1689649156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 8:
					num = (short)1786183682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1877082119;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4C:
				if (!A_0.SerialNumber.a(A_1))
				{
					num = (short)1152712707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_72:
				num = (short)1860501504;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E7:
			num = (short)139657216;
			if (num != 0)
			{
			}
			num = (short)1793720321;
			if (num != 0)
			{
			}
			return A_0.OtarID.a(A_1);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000E670 File Offset: 0x0000C870
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo A_0, string A_1)
		{
			short num = (short)1699079626;
			short num2 = num;
			num = (short)736552394;
			switch (num2 == num)
			{
			}
			num = (short)329056256;
			if (num != 0)
			{
			}
			num = (short)20709377;
			if (num != 0)
			{
			}
			num = (short)1938489344;
			short num3 = num;
			return A_0.TemplateName.a(A_1);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000E724 File Offset: 0x0000C924
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo A_0, string A_1)
		{
			short num;
			for (;;)
			{
				num = (short)1452081153;
				if (num != 0)
				{
				}
				if (A_0.FieldName.a(A_1))
				{
					return true;
				}
				num = (short)1458630828;
				short num2 = num;
				num = (short)1538257068;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6C;
				}
			}
			IL_6C:
			num = (short)1359544320;
			if (num != 0)
			{
			}
			num = (short)1321336832;
			short num3 = num;
			return A_0.Reason.a(A_1);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000E7EC File Offset: 0x0000C9EC
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_0, string A_1)
		{
			short num = (short)616038402;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1EE;
				case 1:
					num = (short)1805189143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					continue;
				case 3:
					if (!A_0.ConfigurationName.a(A_1))
					{
						num = (short)646905872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)1666318356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1720188943;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1563820033;
					if (num != 0)
					{
					}
					num = (short)1149304835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (!A_0.AirInterfaceIP.a(A_1))
					{
						num = (short)299499520;
						short num3 = num;
						num = (short)1979121664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 8:
					if (!A_0.SubscriberIP.a(A_1))
					{
						num = (short)928382977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 9:
					num = (short)1644691474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)187301895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)1372979212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (!A_0.BluetoothDUNPeerIP.a(A_1))
					{
						num = (short)1649803274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 13:
					if (!A_0.RadioAlias.a(A_1))
					{
						num = (short)1898315797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 14:
				{
					if (A_0.ProfileName.a(A_1))
					{
						return true;
					}
					num = (short)623272904;
					short num4 = num;
					num = (short)1916691400;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)341311488;
						if (num != 0)
						{
						}
						num = (short)1912012809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 15:
					if (!A_0.BluetoothDUNSubscriberIP.a(A_1))
					{
						num = (short)1525481483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 16:
					num = (short)24903693;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)575209480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (!A_0.SystemType.a(A_1))
					{
						num = (short)655949843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 19:
					num = (short)588316694;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (!A_0.TemplateName.a(A_1))
					{
						num = (short)713752582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 21:
					num = (short)1988493326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (!A_0.AutoGenerateIPs.a(A_1))
					{
						num = (short)610926609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 23:
					if (!A_0.PeerIP.a(A_1))
					{
						num = (short)65077253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_84:
				if (A_0.SerialNumber.a(A_1))
				{
					return true;
				}
				num = (short)371392516;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1EE:
			return A_0.ProfileName.a(A_1);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000EC54 File Offset: 0x0000CE54
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo A_0, string A_1)
		{
			short num = (short)1786576898;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_210;
				case 1:
					num = (short)45023255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					continue;
				case 3:
					if (!A_0.ConfigurationName.a(A_1))
					{
						num = (short)705298448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)401866772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1340735503;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1073414147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)615514112;
					short num3 = num;
					if (!A_0.AirInterfaceIP.a(A_1))
					{
						num = (short)1569456128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 8:
					if (!A_0.SubscriberIP.a(A_1))
					{
						num = (short)1694498817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 9:
					num = (short)960036882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)107020295;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)1021181953;
					if (num != 0)
					{
					}
					num = (short)497680396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (!A_0.BluetoothDUNPeerIP.a(A_1))
					{
						num = (short)350552074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 13:
					if (!A_0.RadioAlias.a(A_1))
					{
						num = (short)2078933013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 14:
				{
					if (A_0.ProfileName.a(A_1))
					{
						return true;
					}
					num = (short)1965593238;
					short num4 = num;
					num = (short)974492310;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)130285568;
						if (num != 0)
						{
						}
						num = (short)161611785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 15:
					if (!A_0.BluetoothDUNSubscriberIP.a(A_1))
					{
						num = (short)1139539979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 16:
					num = (short)1344995341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)1502543880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (!A_0.SystemType.a(A_1))
					{
						num = (short)626524179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 19:
					num = (short)107872278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (!A_0.TemplateName.a(A_1))
					{
						num = (short)263389190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 21:
					num = (short)1345585166;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (!A_0.AutoGenerateIPs.a(A_1))
					{
						num = (short)1411776529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 23:
					if (!A_0.PeerIP.a(A_1))
					{
						num = (short)1508704261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_84:
				if (A_0.SerialNumber.a(A_1))
				{
					return true;
				}
				num = (short)1585119236;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_210:
			return A_0.ProfileName.a(A_1);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000F0B4 File Offset: 0x0000D2B4
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo A_0, string A_1)
		{
			short num = (short)206700563;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.AirInterfaceIP.a(A_1))
					{
						num = (short)1918631937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					goto IL_20F;
				case 2:
					num = (short)1769930752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!A_0.RadioAlias.a(A_1))
					{
						num = (short)553058308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)1037697035;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)428408840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)776994816;
					short num3 = num;
					num = (short)1180499986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					if (A_0.BluetoothDUNSubscriberIP.a(A_1))
					{
						return true;
					}
					num = (short)403620421;
					short num4 = num;
					num = (short)835699269;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2A9;
					default:
						num = (short)1018888192;
						if (num != 0)
						{
						}
						num = (short)1642856461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					if (!A_0.AutoGenerateIPs.a(A_1))
					{
						num = (short)1338441751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 9:
					if (!A_0.BluetoothDUNPeerIP.a(A_1))
					{
						num = (short)1902837762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 10:
					if (!A_0.TemplateName.a(A_1))
					{
						num = (short)22413326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 11:
					if (!A_0.ProfileName.a(A_1))
					{
						num = (short)1566834694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 12:
					num = (short)1427963920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)575406089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)826736657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)547749898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (!A_0.PeerIP.a(A_1))
					{
						goto IL_2A9;
					}
					return true;
				case 17:
					if (!A_0.ConfigurationName.a(A_1))
					{
						num = (short)1362755605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 18:
					if (!A_0.SystemType.a(A_1))
					{
						num = (short)1003880453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 19:
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					continue;
				case 20:
					if (!A_0.SubscriberIP.a(A_1))
					{
						num = (short)326828044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 21:
					num = (short)1919025153;
					if (num != 0)
					{
					}
					num = (short)1098252291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					num = (short)1709703175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					num = (short)1280311316;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_84:
				if (!A_0.SerialNumber.a(A_1))
				{
					num = (short)1582628879;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_2A9:
				num = (short)1553989654;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_20F:
			return A_0.ProfileName.a(A_1);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000F518 File Offset: 0x0000D718
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware A_0, string A_1)
		{
			short num = (short)201523207;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.Size.a(A_1))
					{
						num = (short)1574961158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
				{
					num = (short)1829175296;
					short num3 = num;
					if (!A_0.ImportTime.a(A_1))
					{
						num = (short)1750532105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 2:
					if (!A_0.TargetModel.a(A_1))
					{
						num = (short)518062085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					num = (short)1823080448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_26B;
				case 5:
					goto IL_BA;
				case 6:
				{
					num = (short)1692367045;
					short num4 = num;
					num = (short)1978562757;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_26B;
					default:
						num = (short)1603534848;
						if (num != 0)
						{
						}
						num = (short)209518593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 8:
					num = (short)788463626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)961019905;
					if (num != 0)
					{
					}
					num = (short)230490123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (!A_0.Version.a(A_1))
					{
						num = (short)887816195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 11:
					if (!A_0.MACE.a(A_1))
					{
						num = (short)1267204100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_54:
				if (!A_0.Name.a(A_1))
				{
					num = (short)1199112200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_26B:
				num = (short)434176002;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BA:
			return A_0.Comments.a(A_1);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000F798 File Offset: 0x0000D998
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob A_0, string A_1)
		{
			short num = (short)1047265281;
			if (num != 0)
			{
			}
			num = (short)504758285;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.CreateDate.a(A_1))
					{
						goto IL_303;
					}
					return true;
				case 1:
					num = (short)761593863;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)2130706437;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!A_0.StartDateTime.a(A_1))
					{
						num = (short)2039283714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)1628241920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!A_0.EndDateTime.a(A_1))
					{
						num = (short)2081685505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					if (!A_0.ExecutedDate.a(A_1))
					{
						num = (short)1754988554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 7:
					if (!A_0.CodeplugFileName.a(A_1))
					{
						num = (short)712441870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 8:
					if (!A_0.JobStatus.a(A_1))
					{
						num = (short)262012939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 9:
					num = (short)1936326662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)350289928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)482869260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (!A_0.JobType.a(A_1))
					{
						num = (short)2057895940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 13:
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					continue;
				case 14:
					num = (short)546308111;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (!A_0.SoftwareVersion.a(A_1))
					{
						num = (short)1378680848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 16:
					goto IL_217;
				case 17:
				{
					num = (short)1932928898;
					short num3 = num;
					num = (short)1096951682;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_303;
					default:
						num = (short)1894318080;
						if (num != 0)
						{
						}
						num = (short)43122691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_95:
				if (!A_0.SuperJobName.a(A_1))
				{
					num = (short)1266745353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_303:
				num = (short)151650321;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_217:
			num = (short)1320550400;
			short num4 = num;
			return A_0.CodeplugVersion.a(A_1);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000FB0C File Offset: 0x0000DD0C
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack A_0, string A_1)
		{
			short num = (short)217645058;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1109262339;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_DD;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
				{
					if (A_0.Locale.a(A_1))
					{
						return true;
					}
					num = (short)1486028801;
					if (num != 0)
					{
					}
					num = (short)224401955;
					short num3 = num;
					num = (short)1327700515;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DD;
					default:
						num = (short)886439936;
						if (num != 0)
						{
						}
						num = (short)1559625733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (!A_0.Version.a(A_1))
					{
						num = (short)958464001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					num = (short)1586167812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3D:
				if (A_0.Name.a(A_1))
				{
					return true;
				}
				num = (short)2070282240;
				short num4 = num;
				num = (short)690814976;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DD:
			return A_0.Size.a(A_1);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000FCB0 File Offset: 0x0000DEB0
		private static bool b(this global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer A_0, string A_1)
		{
			short num = (short)1796866057;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.TotalCount.a(A_1))
					{
						num = (short)752615432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					num = (short)1644625930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (!A_0.Type.a(A_1))
					{
						num = (short)2100101125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					num = (short)1239351298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)903282688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)983498752;
					short num3 = num;
					num = (short)320237455;
					short num4 = num;
					num = (short)2097311631;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E5;
					default:
						num = (short)638517248;
						if (num != 0)
						{
						}
						num = (short)2068512779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					num = (short)787480583;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_E5;
				case 8:
					goto IL_282;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 10:
					if (!A_0.Status.a(A_1))
					{
						num = (short)1303183364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 11:
					if (!A_0.CreatedTime.a(A_1))
					{
						num = (short)1295384588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 12:
					num = (short)146997249;
					if (num != 0)
					{
					}
					num = (short)1596194829;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (!A_0.StartTime.a(A_1))
					{
						num = (short)625475590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_5C:
				if (!A_0.ContainerName.a(A_1))
				{
					num = (short)316801027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_E5:
				if (A_0.EndTime.a(A_1))
				{
					return true;
				}
				num = (short)2065629185;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_282:
			return A_0.ItemsCompleted.a(A_1);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000FF88 File Offset: 0x0000E188
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer A_0, string A_1)
		{
			short num = (short)872564353;
			short num2 = num;
			num = (short)90195585;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)206176256;
				if (num != 0)
				{
				}
				num = (short)1688207361;
				if (num != 0)
				{
				}
				if (A_0.ContainerName.a(A_1))
				{
					return true;
				}
				num = (short)622592000;
				short num3 = num;
				break;
			}
			}
			return A_0.Status.a(A_1);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0001004C File Offset: 0x0000E24C
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.OpJob A_0, string A_1)
		{
			short num = (short)1194983426;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1724252161;
					if (num != 0)
					{
					}
					num = (short)415301635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_DD;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
				{
					if (A_0.UIJobStatus.a(A_1))
					{
						return true;
					}
					num = (short)504311835;
					short num3 = num;
					num = (short)407973915;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DD;
					default:
						num = (short)1793851392;
						if (num != 0)
						{
						}
						num = (short)281477125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (!A_0.ExecutedDate.a(A_1))
					{
						num = (short)1289420801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					num = (short)1184694276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3D:
				if (A_0.Name.a(A_1))
				{
					return true;
				}
				num = (short)717750272;
				short num4 = num;
				num = (short)1127612416;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DD:
			return A_0.Reason.a(A_1);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000101F0 File Offset: 0x0000E3F0
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ReadWriteDeviceJob A_0, string A_1)
		{
			short num = (short)1923285005;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.ConfigurationName.a(A_1))
					{
						num = (short)22872081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					num = (short)2131755020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)521535494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!A_0.ExecutedDate.a(A_1))
					{
						num = (short)181403650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)1102446595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!A_0.RadioAlias.a(A_1))
					{
						num = (short)528482305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					num = (short)1011286017;
					if (num != 0)
					{
					}
					if (!A_0.Reason.a(A_1))
					{
						goto IL_277;
					}
					return true;
				case 7:
					if (A_0.ProductIdentifier != null)
					{
						num = (short)1321926670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 8:
					if (!A_0.TemplateName.a(A_1))
					{
						num = (short)1979514891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 9:
					num = (short)1590624271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)62586880;
					short num3 = num;
					num = (short)1995505671;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
				{
					num = (short)2136664584;
					short num4 = num;
					num = (short)1141041672;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_277;
					default:
						num = (short)318046208;
						if (num != 0)
						{
						}
						num = (short)1951268864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 12:
					if (!A_0.UIJobStatus.a(A_1))
					{
						num = (short)550699012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 13:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 14:
					goto IL_FB;
				case 15:
					if (!A_0.SerialNumber.a(A_1))
					{
						num = (short)1125908496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 16:
					num = (short)1657274376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)585760773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6C:
				if (!A_0.ModelNumber.a(A_1))
				{
					num = (short)1677328393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_277:
				num = (short)400490506;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FB:
			return A_0.ProductIdentifier.a(A_1);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0001055C File Offset: 0x0000E75C
		private static bool b(this global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack A_0, string A_1)
		{
			short num = (short)1002307592;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					num = (short)827850763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					flag = A_0.Comments.a(A_1);
					goto IL_1F4;
				case 2:
					num = (short)559808513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!A_0.ImportTime.a(A_1))
					{
						num = (short)1448804354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CB;
				case 4:
					goto IL_211;
				case 5:
				{
					num = (short)1357774848;
					short num3 = num;
					num = (short)1230897158;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (!A_0.Version.a(A_1))
					{
						num = (short)703987713;
						if (num != 0)
						{
						}
						num = (short)1746272266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CB;
				case 7:
					num = (short)597884931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)287070714;
					short num4 = num;
					num = (short)1428773370;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D7;
					default:
						num = (short)1145241600;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					break;
				}
				case 9:
					flag = true;
					goto IL_1F4;
				case 10:
					num = (short)1920794636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (!A_0.Locale.a(A_1))
					{
						goto IL_1D7;
					}
					goto IL_CB;
				case 12:
					if (!A_0.Size.a(A_1))
					{
						num = (short)1067712519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CB;
				}
				IL_A3:
				if (!A_0.Name.a(A_1))
				{
					num = (short)1565720576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CB:
				num = (short)568721417;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D7:
				num = (short)1128923141;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F4:
				if (flag)
				{
					return true;
				}
				num = (short)402325508;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_211:
			return A_0.References.a(A_1);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00010808 File Offset: 0x0000EA08
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack A_0, string A_1)
		{
			short num = (short)402849793;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_FB;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
				{
					num = (short)1292238848;
					short num3 = num;
					if (!A_0.Locale.a(A_1))
					{
						num = (short)2136670209;
						if (num != 0)
						{
						}
						num = (short)1849229316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 3:
					if (!A_0.Version.a(A_1))
					{
						num = (short)1511981056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)1706754051;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)771049384;
					short num4 = num;
					num = (short)1973569448;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)50397184;
						if (num != 0)
						{
						}
						num = (short)1287651330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_3C:
				if (A_0.Name.a(A_1))
				{
					return true;
				}
				num = (short)1679556613;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FB:
			return A_0.Size.a(A_1);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000109A8 File Offset: 0x0000EBA8
		private static bool d(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0, string A_1)
		{
			short num = (short)1126563886;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1292697663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1305673762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1762459674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1645740081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)773370089;
					short num3 = num;
					num = (short)897364201;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60A;
					default:
						num = (short)544538624;
						if (num != 0)
						{
						}
						num = (short)100925477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					num = (short)1584726080;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)345505850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1692336146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)111149118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (!A_0.UserLoginUnitID.a(A_1))
					{
						num = (short)1768620091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 10:
					num = (short)1712259081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (!A_0.CodeplugVersion.a(A_1))
					{
						num = (short)560070661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 12:
					num = (short)999620646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)2100756530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)141819905;
					if (num != 0)
					{
					}
					num = (short)1944453140;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)1661009931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (!A_0.UserPIN.a(A_1))
					{
						num = (short)773062666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 17:
					if (!A_0.BluetoothDUNSubscriberIP.a(A_1))
					{
						num = (short)788135949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 18:
					if (!A_0.BluetoothDUNPeerIP.a(A_1))
					{
						num = (short)816513071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 19:
					num = (short)581304360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (!A_0.BBFBundleVersion.a(A_1))
					{
						num = (short)1130364951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 21:
					if (!A_0.ModelNumber.a(A_1))
					{
						num = (short)2035023916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 22:
					num = (short)2055995427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					num = (short)2047410232;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)155844636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus;
					if (uijobStatus != null)
					{
						num = (short)1094844458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C0;
				}
				case 26:
					if (!A_0.OwnerSystemIdForGUI.a(A_1))
					{
						num = (short)94437384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 27:
					goto IL_A8D;
				case 28:
					if (!A_0.GroupName.a(A_1))
					{
						num = (short)1552941085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 29:
				{
					int? otarID = A_0.OtarID;
					num = (short)1649737728;
					short num4 = num;
					num = (short)83230772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 30:
					if (!A_0.AstroPurchasedFlashCode.a(A_1))
					{
						num = (short)2097807405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 31:
					num = (short)1852440597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					if (!A_0.Comments.a(A_1))
					{
						num = (short)732037126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 33:
					num = (short)1401290800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					if (!A_0.TemplateName.a(A_1))
					{
						num = (short)1244332063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 35:
					if (!A_0.VAFiles.a(A_1))
					{
						num = (short)1967587331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 36:
					if (!A_0.ConfigurationName.a(A_1))
					{
						num = (short)78250008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 37:
					if (!A_0.RadioAlias.a(A_1))
					{
						num = (short)741343233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 38:
					if (!A_0.SubscriberIP.a(A_1))
					{
						num = (short)1715929121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 39:
					num = (short)656998466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					if (!A_0.UserName.a(A_1))
					{
						num = (short)447545385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 41:
					num = (short)1432092688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus = A_0.UIJobStatus;
					num = (short)138870835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 43:
					if (!A_0.LanguagePacksInfo.a(A_1))
					{
						num = (short)1146552342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 44:
					num = (short)1567293500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					num = (short)234815524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 46:
					switch (0)
					{
					case 0:
						goto IL_134;
					}
					continue;
				case 47:
					num = (short)755564561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					goto IL_60A;
				case 49:
					if (!A_0.PasswordPerDevice.a(A_1))
					{
						num = (short)1280901120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 50:
					if (!A_0.FirmwareVersion.a(A_1))
					{
						num = (short)1061027854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 51:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus;
					if (!uijobStatus.Value.ToResourceString().a(A_1))
					{
						num = (short)1518796857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 52:
				{
					int? otarID;
					if (!otarID.ToString().a(A_1))
					{
						num = (short)820379687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 53:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus = A_0.UIJobStatus;
					num = (short)229048345;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 54:
					if (!A_0.DisableWriteProtect.a(A_1))
					{
						num = (short)949157915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 55:
					if (!A_0.GroupDataJobId.a(A_1))
					{
						num = (short)963379215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 56:
					if (!A_0.BluetoothFriendlyName.a(A_1))
					{
						num = (short)1044512787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 57:
					goto IL_9C0;
				case 58:
					if (!A_0.OwnerAdvKeyTypeForGUI.a(A_1))
					{
						num = (short)306708482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 59:
					num = (short)1544290359;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 60:
					if (!A_0.TuningVersion.a(A_1))
					{
						num = (short)414384193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 61:
					num = (short)467664939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 62:
					if (!A_0.PasswordPolicy.ToResourceString().a(A_1))
					{
						num = (short)789184573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 63:
					if (!A_0.AskRequired.a(A_1))
					{
						num = (short)391708739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 64:
					if (!A_0.JobName.a(A_1))
					{
						num = (short)371982389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 65:
					num = (short)1137180702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 66:
					if (!A_0.ForeignIP.a(A_1))
					{
						num = (short)736165900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 67:
					num = (short)1369964598;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_134:
				if (!A_0.SerialNumber.a(A_1))
				{
					num = (short)34799620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_60A:
				if (!A_0.PeerIP.a(A_1))
				{
					num = (short)973799431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_9C0:
				num = (short)1894121504;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A8D:
			return A_0.VRID.c(A_1);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000114D0 File Offset: 0x0000F6D0
		private static bool c(this int? A_0, string A_1)
		{
			int a_ = 15;
			short num = (short)589168643;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROVRIDEntryFormat.Equals(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䣿", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						num = (short)2023227394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18E;
				case 1:
				{
					num = (short)626784560;
					short num3 = num;
					num = (short)2137389360;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						goto IL_177;
					}
					break;
				}
				case 2:
					goto IL_13E;
				case 3:
					goto IL_1D;
				}
				goto IL_3D;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_3D:
					if (A_0 == null)
					{
						num = (short)1969553409;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1053556736;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_13E:
			num = (short)256835584;
			short num4 = num;
			num = (short)165150721;
			if (num != 0)
			{
			}
			return (global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ヿ稁", a_) + A_0.Value.ToString(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("壿", a_), global::System.Globalization.CultureInfo.InvariantCulture)).a(A_1);
			IL_177:
			num = (short)18808832;
			if (num != 0)
			{
			}
			return false;
			IL_18E:
			return A_0.a(A_1);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00011674 File Offset: 0x0000F874
		private static bool c(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0, string A_1)
		{
			short num = (short)2055471105;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_FD;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
					if (!A_0.RadioAlias.a(A_1))
					{
						num = (short)1507000324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					if (!A_0.GroupName.a(A_1))
					{
						num = (short)995098624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)2083586051;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)114983932;
					short num3 = num;
					num = (short)1389528060;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
					{
						num = (short)1917452288;
						if (num != 0)
						{
						}
						num = (short)623378432;
						short num4 = num;
						num = (short)296615938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				IL_3C:
				if (A_0.SerialNumber.a(A_1))
				{
					return true;
				}
				num = (short)132907013;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FD:
			num = (short)338100225;
			if (num != 0)
			{
			}
			return A_0.Comments.a(A_1);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00011814 File Offset: 0x0000FA14
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo A_0, string A_1)
		{
			short num = (short)1101922305;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_120;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
					if (!A_0.PackageName.a(A_1))
					{
						num = (short)927137796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					if (!A_0.PackageSize.a(A_1))
					{
						num = (short)1074855936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)76152835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)2104492033;
					if (num != 0)
					{
					}
					num = (short)1109843816;
					short num3 = num;
					num = (short)222748520;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
					{
						num = (short)114229248;
						if (num != 0)
						{
						}
						num = (short)1792147456;
						short num4 = num;
						num = (short)1222508546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				IL_3C:
				if (A_0.PackageID.a(A_1))
				{
					return true;
				}
				num = (short)2118451205;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_120:
			return A_0.PackageVersion.a(A_1);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000119B0 File Offset: 0x0000FBB0
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo A_0, string A_1)
		{
			if (!A_0.PackageName.a(A_1))
			{
				short num;
				for (;;)
				{
					num = (short)287899649;
					if (num != 0)
					{
					}
					num = (short)169883634;
					short num2 = num;
					num = (short)1593718770;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6F;
					}
				}
				IL_6F:
				num = (short)2004353024;
				short num3 = num;
				num = (short)1261895680;
				if (num != 0)
				{
				}
				return A_0.PackageSize.a(A_1);
			}
			return true;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00011A7C File Offset: 0x0000FC7C
		private static bool b(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0, string A_1)
		{
			short num = (short)1277558785;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1474625537;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_121;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 2:
					if (!A_0.ModelNumber.a(A_1))
					{
						num = (short)1650524164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					if (!A_0.CodeplugVersion.a(A_1))
					{
						num = (short)216989696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)481689603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)580936186;
					short num3 = num;
					num = (short)1536582138;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
					{
						num = (short)83361792;
						if (num != 0)
						{
						}
						num = (short)73465856;
						short num4 = num;
						num = (short)1811021826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				IL_63:
				if (A_0.SerialNumber.a(A_1))
				{
					return true;
				}
				num = (short)579665925;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_121:
			return A_0.AstroPurchasedFlashCode.a(A_1);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00011C1C File Offset: 0x0000FE1C
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio A_0, string A_1)
		{
			short num = (short)624099331;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1512439809;
					if (num != 0)
					{
					}
					if (!A_0.Reason.a(A_1))
					{
						goto IL_E1;
					}
					return true;
				case 1:
				{
					num = (short)221577216;
					short num3 = num;
					num = (short)1366294528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					num = (short)263752806;
					short num4 = num;
					num = (short)1197771878;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E1;
					default:
						goto IL_12C;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (!A_0.SerialNumber.a(A_1))
				{
					num = (short)1462042625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_E1:
				num = (short)1952514050;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12C:
			num = (short)2051473408;
			if (num != 0)
			{
			}
			return A_0.DeviceID.a(A_1);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00011D70 File Offset: 0x0000FF70
		private static bool b(this global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0, string A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)539426819;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)617545729;
						if (num != 0)
						{
						}
						num = (short)230883328;
						short num3 = num;
						num = (short)472973314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (!A_0.RadioAlias.a(A_1))
						{
							num = (short)134676486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
						if (!A_0.JobName.a(A_1))
						{
							num = (short)295698436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					case 4:
						goto IL_D8;
					case 5:
						if (!A_0.UIJobStatus.a(A_1))
						{
							num = (short)1291321344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 6:
						num = (short)1742536709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)981783232;
						short num4 = num;
						num = (short)1792791232;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1828585472;
							if (num != 0)
							{
							}
							num = (short)224854017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_44:
					if (A_0.SerialNumber.a(A_1))
					{
						return true;
					}
					num = (short)1842937863;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_D8:
			return A_0.ModelNumber.a(A_1);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00011F68 File Offset: 0x00010168
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair A_0, string A_1)
		{
			if (!A_0.SerialNumber.a(A_1))
			{
				short num = (short)64320635;
				short num2 = num;
				num = (short)1820619899;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1984561152;
					if (num != 0)
					{
					}
					num = (short)1506148352;
					short num3 = num;
					num = (short)412811265;
					if (num != 0)
					{
					}
					return A_0.Reason.a(A_1);
				}
				}
			}
			return true;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00012034 File Offset: 0x00010234
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0, string A_1)
		{
			short num = (short)1910259357;
			short num2 = num;
			num = (short)2135965341;
			switch (num2 == num)
			{
			}
			num = (short)434372609;
			if (num != 0)
			{
			}
			num = (short)354615296;
			short num3 = num;
			num = (short)2099642368;
			if (num != 0)
			{
			}
			return A_0.SerialNumber.a(A_1);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000120EC File Offset: 0x000102EC
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem A_0, string A_1)
		{
			short num = (short)1146683399;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.ConfigurationName.a(A_1))
					{
						num = (short)1601110017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					num = (short)68681740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)553196564;
					short num3 = num;
					num = (short)184687636;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_135;
					default:
						num = (short)2022899712;
						if (num != 0)
						{
						}
						if (!A_0.TemplateName.a(A_1))
						{
							num = (short)824705040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 3:
					if (!A_0.RadioID.b(A_1))
					{
						num = (short)213712905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					if (!A_0.SystemType.a(A_1))
					{
						num = (short)3538954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					num = (short)2050424835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (!A_0.SubSystemType.a(A_1))
					{
						goto IL_135;
					}
					return true;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 8:
				{
					num = (short)663814144;
					short num4 = num;
					num = (short)16121860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					goto IL_1D7;
				case 10:
					num = (short)1364983814;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)543490062;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (!A_0.RadioAlias.a(A_1))
					{
						num = (short)1918304264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 13:
					num = (short)237568015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (!A_0.SystemName.a(A_1))
					{
						num = (short)598605837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 15:
					if (!A_0.SystemId.a(A_1))
					{
						num = (short)2019622917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 16:
					num = (short)1184235520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)1906180098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6E:
				if (!A_0.SerialNumber.a(A_1))
				{
					num = (short)1487077377;
					if (num != 0)
					{
					}
					num = (short)923009041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_135:
				num = (short)134217739;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1D7:
			return A_0.AskRequired.a(A_1);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00012468 File Offset: 0x00010668
		private static bool b(this int? A_0, string A_1)
		{
			int a_ = 7;
			short num = (short)1170341891;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1673236232;
				short num3 = num;
				num = (short)1104318216;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
					num = (short)350552064;
					if (num != 0)
					{
					}
					num = (short)853475329;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						goto IL_188;
					case 2:
						if (global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROMDCEntryFormat.Equals(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("냷", a_), global::System.StringComparison.OrdinalIgnoreCase))
						{
							num = (short)2026962944;
							short num4 = num;
							num = (short)686424065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18F;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_AE;
						}
						continue;
					}
					IL_AE:
					if (A_0 == null)
					{
						num = (short)2092498944;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1358757890;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			return false;
			IL_188:
			return (global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("죷苹", a_) + A_0.Value.ToString(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꃷ", a_), global::System.Globalization.CultureInfo.InvariantCulture)).a(A_1);
			IL_18F:
			return A_0.a(A_1);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001260C File Offset: 0x0001080C
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo A_0, string A_1)
		{
			short num = (short)704315399;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.ConfigurationName.a(A_1))
					{
						num = (short)503185409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					num = (short)1792999436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1420088643;
					short num3 = num;
					num = (short)1118295363;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_105;
					default:
						num = (short)1781465088;
						if (num != 0)
						{
						}
						if (!A_0.TemplateName.a(A_1))
						{
							num = (short)724238352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 3:
					if (!A_0.RadioID.a(A_1))
					{
						num = (short)1232994313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					if (!A_0.SystemType.a(A_1))
					{
						num = (short)1430454282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					num = (short)1496121347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (!A_0.SubSystemType.a(A_1))
					{
						goto IL_105;
					}
					return true;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 8:
				{
					num = (short)86310912;
					short num4 = num;
					num = (short)67698692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					goto IL_1D0;
				case 10:
					num = (short)774635526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)1902116865;
					if (num != 0)
					{
					}
					num = (short)1196752910;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (!A_0.RadioAlias.a(A_1))
					{
						num = (short)1895628808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 13:
					num = (short)518979599;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (!A_0.SystemName.a(A_1))
					{
						num = (short)1210777613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 15:
					if (!A_0.SystemId.a(A_1))
					{
						num = (short)756482053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 16:
					num = (short)1997012992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)6225922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6C:
				if (!A_0.SerialNumber.a(A_1))
				{
					num = (short)283246609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_105:
				num = (short)431816715;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1D0:
			return A_0.AskRequired.a(A_1);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00012988 File Offset: 0x00010B88
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo A_0, string A_1)
		{
			short num = (short)11993094;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.SystemType.a(A_1))
					{
						num = (short)68091912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					num = (short)1748762637;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1869676544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!A_0.TemplateName.a(A_1))
					{
						num = (short)1899622255;
						short num3 = num;
						num = (short)1525673839;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_76;
						case 1:
							break;
						default:
						{
							num = (short)1391525888;
							short num4 = num;
							break;
						}
						}
						num = (short)301334528;
						if (num != 0)
						{
						}
						num = (short)1495859210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)370409486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!A_0.ConfigurationName.a(A_1))
					{
						num = (short)1538326535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 7:
					num = (short)1305411585;
					if (num != 0)
					{
					}
					num = (short)607125516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)1333133321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (!A_0.SubSystemType.a(A_1))
					{
						num = (short)1843855361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 10:
					num = (short)1579679749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_28E;
				case 12:
					if (!A_0.RadioAlias.a(A_1))
					{
						num = (short)1965621250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 13:
					if (!A_0.SystemName.a(A_1))
					{
						num = (short)840761348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 14:
					if (!A_0.SystemId.a(A_1))
					{
						num = (short)1607663627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 15:
					num = (short)1733820419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_65;
				IL_76:
				num = (short)763428879;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_65:
				if (!A_0.SerialNumber.a(A_1))
				{
					goto IL_76;
				}
				return true;
			}
			IL_28E:
			return A_0.RadioID.a(A_1);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00012CB0 File Offset: 0x00010EB0
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate A_0, string A_1)
		{
			short num = (short)1021116417;
			if (num != 0)
			{
			}
			num = (short)1266352135;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.FirmwareVersion.a(A_1))
					{
						num = (short)966262785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					num = (short)1317470220;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)949547481;
					short num3 = num;
					num = (short)217248217;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12A;
					default:
						num = (short)340197376;
						if (num != 0)
						{
						}
						if (!A_0.ModelNumber.a(A_1))
						{
							num = (short)1943339024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 3:
					if (!A_0.RadioReferencedCount.a(A_1))
					{
						num = (short)1279459337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					if (!A_0.LanguagePacksInfo.a(A_1))
					{
						num = (short)1473970186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					num = (short)1160511491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (!A_0.VAFiles.a(A_1))
					{
						goto IL_12A;
					}
					return true;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_92;
					}
					continue;
				case 8:
				{
					num = (short)1078853632;
					short num4 = num;
					num = (short)1870004228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					goto IL_1CD;
				case 10:
					num = (short)74252294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)2059665422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (!A_0.BBFBundleVersion.a(A_1))
					{
						num = (short)163315720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 13:
					num = (short)1422065679;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (!A_0.CodeplugVersion.a(A_1))
					{
						num = (short)383451149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 15:
					if (!A_0.Comments.a(A_1))
					{
						num = (short)1942880261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 16:
					num = (short)1918042112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)1417543682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_92:
				if (!A_0.Name.a(A_1))
				{
					num = (short)1891500049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_12A:
				num = (short)605487115;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1CD:
			return A_0.ModifiedDate.a(A_1);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00013024 File Offset: 0x00011224
		private static bool b(this global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement A_0, string A_1)
		{
			short num = (short)1819344903;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.References.a(A_1))
					{
						num = (short)213516289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					goto IL_182;
				case 2:
					if (!A_0.Size.a(A_1))
					{
						num = (short)895090704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					if (!A_0.Name.a(A_1))
					{
						num = (short)255262729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					if (!A_0.Name.a(A_1))
					{
						num = (short)1395261450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					num = (short)1348075522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)600244225;
					if (num != 0)
					{
					}
					if (!A_0.ImportTime.a(A_1))
					{
						num = (short)775094283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 8:
					goto IL_2F2;
				case 9:
					num = (short)2062548998;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)404553743;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)619249678;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (!A_0.ConfigurationReferences.a(A_1))
					{
						num = (short)588709896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 13:
					num = (short)1529217036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (!A_0.Size.a(A_1))
					{
						num = (short)956104717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 15:
					if (!A_0.ImportTime.a(A_1))
					{
						num = (short)1035665413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 16:
					num = (short)1094975488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)681050115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6C:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
				{
					num = (short)1077936145;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1574240260;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
			IL_182:
			return A_0.Comments.a(A_1);
			IL_2F2:
			num = (short)2132024973;
			short num3 = num;
			num = (short)1176051341;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
			{
				num = (short)1682309120;
				if (num != 0)
				{
				}
				num = (short)60948480;
				short num4 = num;
				return A_0.Comments.a(A_1);
			}
			}
			return true;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000133A0 File Offset: 0x000115A0
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement A_0, string A_1)
		{
			short num = (short)29360131;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1447362562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_146;
				case 2:
				{
					num = (short)1678049280;
					short num3 = num;
					if (!A_0.Size.a(A_1))
					{
						num = (short)678297601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				}
				IL_34:
				if (A_0.Name.a(A_1))
				{
					return true;
				}
				num = (short)1712652289;
				if (num != 0)
				{
				}
				num = (short)311397492;
				short num4 = num;
				num = (short)1940098164;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D3;
				default:
					num = (short)1231945728;
					if (num != 0)
					{
					}
					num = (short)2033778688;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_D3:
			return A_0.Comments.a(A_1);
			IL_146:
			goto IL_D3;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000134F8 File Offset: 0x000116F8
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase A_0, string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				bool flag;
				bool flag2;
				switch (num)
				{
				case 0:
					num2 = (short)1207631877;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_121;
				case 2:
					flag = true;
					goto IL_1FB;
				case 3:
					if (!A_0.FeatureName.a(A_1))
					{
						num2 = (short)993132544;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1241841668;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					flag2 = true;
					goto IL_109;
				case 5:
					flag2 = A_0.RadioCount.a(A_1);
					goto IL_109;
				case 6:
					flag = A_0.RadioCount.a(A_1);
					goto IL_1FB;
				case 7:
					num2 = (short)840826886;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_213;
				case 9:
				{
					num2 = (short)1354432512;
					short num3 = num2;
					num2 = (short)972189759;
					short num4 = num2;
					num2 = (short)1560899647;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_213;
					default:
						num2 = (short)1669136384;
						if (num2 != 0)
						{
						}
						num2 = (short)1898184714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 10:
					if (!A_0.FeatureName.a(A_1))
					{
						num2 = (short)649658375;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)839319554;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (!A_0.CapacityMaxLicense)
					{
						num2 = (short)1831862281;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1872822275;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_109:
				result = flag2;
				num2 = (short)948240385;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1FB:
				result = flag;
				num2 = (short)1204158472;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_121:
			IL_213:
			num2 = (short)539754497;
			if (num2 != 0)
			{
			}
			return result;
			IL_40:
			result = false;
			num2 = (short)1715077131;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00013760 File Offset: 0x00011960
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense A_0, string A_1)
		{
			short num = (short)865861643;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.FeatureName.a(A_1))
					{
						num = (short)1330511878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					if (!A_0.RadioAlias.a(A_1))
					{
						num = (short)861798410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					num = (short)163840001;
					if (num != 0)
					{
					}
					num = (short)1412759557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_BA;
				case 4:
					num = (short)1763901440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!A_0.FlashCode.a(A_1))
					{
						num = (short)770899971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					num = (short)431554568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (!A_0.ModelNumber.a(A_1))
					{
						num = (short)2146697220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 8:
					goto IL_227;
				case 9:
					num = (short)1495400449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)1604386816;
					short num3 = num;
					num = (short)810238000;
					short num4 = num;
					num = (short)1593524272;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_227;
					default:
						num = (short)1229651968;
						if (num != 0)
						{
						}
						num = (short)592969735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				}
				IL_54:
				if (!A_0.SerialNumber.a(A_1))
				{
					num = (short)1627717641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_227:
				if (A_0.FeatureStatus.a(A_1))
				{
					return true;
				}
				num = (short)588185602;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BA:
			return A_0.Comments.a(A_1);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000139E8 File Offset: 0x00011BE8
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicenseRadioView A_0, string A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1333264391;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1232732162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)491388929;
						if (num != 0)
						{
						}
						num = (short)476774406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!A_0.FlashCode.a(A_1))
						{
							num = (short)1669267459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						goto IL_D8;
					case 4:
						if (!A_0.RadioAlias.a(A_1))
						{
							num = (short)967442433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
					{
						num = (short)639565824;
						short num3 = num;
						num = (short)1048241308;
						short num4 = num;
						num = (short)1929569436;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)668729344;
							if (num != 0)
							{
							}
							num = (short)1083244548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						if (!A_0.ModelNumber.a(A_1))
						{
							num = (short)2048000000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					}
					IL_44:
					if (A_0.SerialNumber.a(A_1))
					{
						return true;
					}
					num = (short)1111228421;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_D8:
			return A_0.FeatureCount.a(A_1);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00013BD8 File Offset: 0x00011DD8
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail A_0, string A_1)
		{
			short num = (short)1740177410;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.SourceFlashcode.a(A_1))
					{
						num = (short)952762372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					goto IL_113;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 3:
					num = (short)377487360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1463877641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!A_0.SourceModelNumber.a(A_1))
					{
						num = (short)425263107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
				{
					num = (short)712627930;
					short num3 = num;
					num = (short)461690586;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_113;
					default:
					{
						num = (short)1935671297;
						if (num != 0)
						{
						}
						num = (short)2086076416;
						short num4 = num;
						num = (short)1125515264;
						if (num != 0)
						{
						}
						num = (short)714801157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 7:
					if (!A_0.AvailableCount.a(A_1))
					{
						num = (short)335609864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 8:
					goto IL_152;
				case 9:
					if (!A_0.TargetFlashcode.a(A_1))
					{
						num = (short)120913921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_4C:
				if (!A_0.EntitlementID.a(A_1))
				{
					num = (short)2080702470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_113:
				num = (short)1480851463;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_152:
			return A_0.PurchasedCount.a(A_1);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00013E14 File Offset: 0x00012014
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo A_0, string A_1)
		{
			short num = (short)686751748;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1204513555;
					short num3 = num;
					num = (short)1216572179;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_187;
					default:
						num = (short)1011417088;
						if (num != 0)
						{
						}
						num = (short)709689353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
				{
					num = (short)862060545;
					if (num != 0)
					{
					}
					num = (short)1853947904;
					short num4 = num;
					num = (short)1680801797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					region = A_0.Region;
					num = (short)2115502092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_FF;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 5:
					if (!A_0.FeatureName.a(A_1))
					{
						num = (short)882638854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					num = (short)1584005133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					region = A_0.Region;
					global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName regionName = global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NULL;
					num = (short)1947861002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_187;
				case 9:
					if (!A_0.RadioCountUpdates.a(A_1))
					{
						num = (short)1626996738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 10:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName regionName;
					if (!(region.GetValueOrDefault() == regionName & region != null))
					{
						num = (short)1262288899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 11:
					if (!A_0.Available.a(A_1))
					{
						num = (short)845479936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 12:
					if (region != null)
					{
						num = (short)239206407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 13:
					if (!A_0.QtyPurchased.a(A_1))
					{
						num = (short)155451400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_5D:
				if (!A_0.Entitlement.a(A_1))
				{
					num = (short)1381826561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_187:
				num = (short)695861259;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FF:
			region = A_0.Region;
			return region.Value.a(A_1);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00014104 File Offset: 0x00012304
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus A_0, string A_1)
		{
			short num;
			while (!A_0.FeatureName.a(A_1))
			{
				num = (short)1843449514;
				short num2 = num;
				num = (short)402640554;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)68747264;
					if (num != 0)
					{
					}
					num = (short)1400504321;
					if (num != 0)
					{
					}
					return A_0.FeatureStatus.a(A_1);
				}
			}
			num = (short)776273920;
			short num3 = num;
			return true;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000141D0 File Offset: 0x000123D0
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0, string A_1)
		{
			short num;
			while (!A_0.SerialNumber.a(A_1))
			{
				num = (short)787677185;
				if (num != 0)
				{
				}
				num = (short)480290172;
				short num2 = num;
				num = (short)731489660;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)718667776;
					if (num != 0)
					{
					}
					return A_0.RadioAlias.a(A_1);
				}
			}
			num = (short)9568256;
			short num3 = num;
			return true;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001429C File Offset: 0x0001249C
		static Filters()
		{
			short num = (short)1250444662;
			short num2 = num;
			num = (short)132531574;
			switch (num2 == num)
			{
			}
			num = (short)1852702720;
			if (num != 0)
			{
			}
			num = (short)1164312577;
			if (num != 0)
			{
			}
			num = (short)558563328;
			short num3 = num;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00014348 File Offset: 0x00012548
		public static bool Filter(object obj, string searchString, string viewInfo = null)
		{
			switch (0)
			{
			case 0:
				goto IL_53;
			}
			short num;
			for (;;)
			{
				IL_0A:
				num = (short)1750728705;
				if (num != 0)
				{
				}
				int num2;
				switch (num2)
				{
				case 0:
				{
					global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition searchCondition;
					if (searchCondition == null)
					{
						num = (short)1063583746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_113;
				}
				case 1:
					goto IL_113;
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition searchCondition = new global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition(searchString);
					num = (short)1187643393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					if (CS$<>8__locals1.matchFunc == null)
					{
						num = (short)481361924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition searchCondition = global::Motorola.CommonCPS.RadioManagement.Command.Filters.a(searchString);
					num = (short)216203264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return false;
				case 5:
				{
					global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition searchCondition;
					if (searchCondition.MatchConditions.Any(delegate(string condition)
					{
						short num5 = (short)736907522;
						short num6 = num5;
						num5 = (short)66932994;
						switch (num6 == num5)
						{
						default:
						{
							num5 = (short)563675136;
							short num7 = num5;
							break;
						}
						case true:
							break;
						}
						num5 = (short)58261505;
						if (num5 != 0)
						{
						}
						num5 = (short)122617856;
						if (num5 != 0)
						{
						}
						return !CS$<>8__locals1.matchFunc(condition);
					}))
					{
						num = (short)1210974214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BF;
				}
				case 6:
					return false;
				}
				goto IL_53;
				IL_113:
				num = (short)681115653;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_53:
			num = (short)500831928;
			short num3 = num;
			num = (short)431167160;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1BF:
				global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition searchCondition;
				return searchCondition.ExcludeConditions.All(delegate(string condition)
				{
					short num5 = (short)1508817420;
					short num6 = num5;
					num5 = (short)983349772;
					switch (num6 == num5)
					{
					default:
					{
						num5 = (short)1360658432;
						short num7 = num5;
						break;
					}
					case true:
						break;
					}
					num5 = (short)1965031425;
					if (num5 != 0)
					{
					}
					num5 = (short)150536192;
					if (num5 != 0)
					{
					}
					return !CS$<>8__locals1.matchFunc(condition);
				});
			}
			default:
			{
				num = (short)521207808;
				if (num != 0)
				{
				}
				num = (short)659685376;
				short num4 = num;
				global::System.Func<string, bool> matchFunc = global::Motorola.CommonCPS.RadioManagement.Command.Filters.a(obj, viewInfo);
				num = (short)1054146563;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001452C File Offset: 0x0001272C
		private static global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition a(string A_0)
		{
			int a_ = 11;
			short num = (short)96731136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_80;
				}
				global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition searchCondition;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						string[] array;
						if (array.Length != 0)
						{
							num = (short)1417150465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return searchCondition;
					}
					case 1:
						num = (short)395378698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_2E6;
					case 3:
						goto IL_BA;
					case 4:
					{
						string[] array;
						if (array != null)
						{
							num = (short)109641743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return searchCondition;
					}
					case 5:
						return searchCondition;
					case 6:
					{
						string[] array = A_0.Split(new string[]
						{
							global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꟻ\udafd◿℁䐃Ⰵ∇⬉䰋ⴍ丏㜑〓〕䔗", a_)
						}, global::System.StringSplitOptions.RemoveEmptyEntries);
						num = (short)605421572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						int num3;
						if (num3 >= searchCondition.MatchConditions.Count)
						{
							num = (short)629473285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array;
						searchCondition.MatchConditions[num3] = array[0] + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꟻ\udafd◿℁䐃Ⰵ∇⬉䰋ⴍ丏㜑〓〕䔗", a_) + searchCondition.MatchConditions[num3];
						num3++;
						num = (short)486801424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (!string.IsNullOrEmpty(A_0))
						{
							num = (short)1516699651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return searchCondition;
					case 9:
					{
						int num4;
						if (num4 < searchCondition.ExcludeConditions.Count)
						{
							string[] array;
							searchCondition.ExcludeConditions[num4] = array[0] + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꟻ\udafd◿℁䐃Ⰵ∇⬉䰋ⴍ丏㜑〓〕䔗", a_) + searchCondition.ExcludeConditions[num4];
							num4++;
							num = (short)1466368014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1773426690;
						short num5 = num;
						num = (short)932075522;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BA;
						default:
							num = (short)338821120;
							if (num != 0)
							{
							}
							num = (short)317587468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
					{
						string[] array;
						if (array.Length == 2)
						{
							num = (short)1774845965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return searchCondition;
					}
					case 11:
						goto IL_256;
					case 12:
					{
						int num3 = 0;
						num = (short)1515782146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						string[] array;
						searchCondition = new global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition(array[1]);
						int num4 = 0;
						num = (short)1546649601;
						if (num != 0)
						{
						}
						num = (short)480706571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_256;
					case 15:
						num = (short)1282211840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_2E6;
					case 17:
					{
						num = (short)404094976;
						short num6 = num;
						if (A_0.Contains(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꟻ\udafd◿℁䐃Ⰵ∇⬉䰋ⴍ丏㜑〓〕䔗", a_)))
						{
							num = (short)1883045894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return searchCondition;
					}
					}
					goto IL_80;
					IL_BA:
					num = (short)123994129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_256:
					num = (short)655949833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E6:
					num = (short)1576271879;
					num2 = (int)((global::System.IntPtr)num);
				}
				return searchCondition;
				IL_80:
				searchCondition = null;
				num = (short)1579221000;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00014930 File Offset: 0x00012B30
		private static global::System.Func<string, bool> a(object A_0, string A_1)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_275;
			}
			int num;
			short num2;
			global::System.Func<string, bool> result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)
					{
						num2 = (short)433651854;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1801388167;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack)
					{
						num2 = (short)323354630;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1521418384;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_61A;
				case 3:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption).a);
					num2 = (short)435617932;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair)
					{
						num2 = (short)755236931;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1753743433;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_7BF;
				case 6:
					num2 = (short)1328676980;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo)
					{
						num2 = (short)382140549;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)152502387;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.OpJob).a);
					num2 = (short)1656356922;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (A_1 == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꇱ釳髵鷷駹裻닽懿氁挃猅椇洉椋帍焏焑缓攕", a_))
					{
						num2 = (short)726204511;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 10:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo).a);
					num2 = (short)1041432724;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense)
					{
						num2 = (short)1089732620;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)10682446;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense).a);
					num2 = (short)802488446;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_3B9;
				case 14:
					return result;
				case 15:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).a);
					num2 = (short)637272146;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (A_1 == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꛱闳藵鏷觹", a_))
					{
						num2 = (short)2014969980;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 17:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo)
					{
						num2 = (short)266338339;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1083965567;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					goto IL_34D;
				case 19:
					goto IL_5AE;
				case 20:
					return result;
				case 21:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo)
					{
						num2 = (short)902103050;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1622016062;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware)
					{
						num2 = (short)1490223135;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1596588076;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.Group).a);
					num2 = (short)1090584713;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					return result;
				case 25:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicenseRadioView).a);
					num2 = (short)633733240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					goto IL_147D;
				case 27:
					goto IL_FE3;
				case 28:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo).a);
					num2 = (short)1002242122;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile).a);
					num2 = (short)513343524;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					if (A_1 == null)
					{
						num2 = (short)357957730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1473904656;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					num2 = (short)1209860179;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					goto IL_50F;
				case 33:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).a);
					num2 = (short)1626603560;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail).a);
					num2 = (short)1031864425;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo).a);
					num2 = (short)1419575310;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
					goto IL_162E;
				case 37:
					goto IL_1411;
				case 38:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem).a);
					num2 = (short)1210646642;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 39:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).b);
					num2 = (short)171901062;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					goto IL_B6A;
				case 41:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).c);
					num2 = (short)1086980109;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 42:
					num2 = (short)693174411;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo).a);
					num2 = (short)712507394;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 44:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack)
					{
						num2 = (short)2115371100;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)193069057;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 45:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile).a);
					num2 = (short)1784610871;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 46:
					goto IL_97A;
				case 47:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo).a);
					num2 = (short)2034106514;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 48:
					goto IL_F49;
				case 49:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack).b);
					num2 = (short)336396347;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 50:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.OpJob)
					{
						num2 = (short)1195114504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)833421457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 51:
					goto IL_1088;
				case 52:
					goto IL_6F4;
				case 53:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ReadWriteDeviceJob).a);
					num2 = (short)264831033;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 54:
					if (A_1 == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꇱ鳳駵迷꣹駻鋽懿瘁愃戅娇欉栋服缏愑", a_))
					{
						num2 = (short)1578434601;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)827654293;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 55:
					goto IL_DF1;
				case 56:
					if (A_1 == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("뿱鯳胵鷷뷹軻釽痿爁", a_))
					{
						num2 = (short)310902807;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 57:
					goto IL_10B8;
				case 58:
					goto IL_FB4;
				case 59:
					goto IL_31E;
				case 60:
					goto IL_E62;
				case 61:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement).a);
					num2 = (short)318373939;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 62:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)
					{
						num2 = (short)1859977254;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1629487111;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 63:
					if (A_1 != null)
					{
						num2 = (short)852010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1454;
				case 64:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo).a);
					num2 = (short)384761966;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 65:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware).a);
					num2 = (short)1300299813;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 66:
					goto IL_1454;
				case 67:
					num2 = (short)759693450;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 68:
					return result;
				case 69:
					return result;
				case 70:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo)
					{
						num2 = (short)1761411222;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)527237195;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 71:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage).a);
					num2 = (short)153157725;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 72:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.Group)
					{
						num2 = (short)1424687184;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)595656721;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 73:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption)
					{
						num2 = (short)976617475;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)452395127;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 74:
					goto IL_1374;
				case 75:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo)
					{
						num2 = (short)1532821551;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 76:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack).a);
					num2 = (short)221511797;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 77:
					if (A_1 == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꇱ釳髵鷷駹裻뿽叿䤁", a_))
					{
						num2 = (short)199491599;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1884094518;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 78:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicenseRadioView)
					{
						num2 = (short)1430978585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1749680216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 79:
					num2 = (short)1342373972;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 80:
					num2 = (short)1256325176;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 81:
					goto IL_723;
				case 82:
					goto IL_ECF;
				case 83:
					if (A_1 == null)
					{
						num2 = (short)361431105;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 84:
					if (A_1 != null)
					{
						num2 = (short)1723662397;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement).b);
					num2 = (short)219611242;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 85:
					goto IL_751;
				case 86:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate)
					{
						num2 = (short)720044141;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2104295567;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 87:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo)
					{
						num2 = (short)1564803115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1384316949;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 88:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail)
					{
						num2 = (short)1156382754;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)837681260;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 89:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair).a);
					num2 = (short)442892399;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 90:
					num2 = (short)463536158;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 91:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)
					{
						num2 = (short)324010013;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1064435799;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 92:
					num2 = (short)97189985;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 93:
					goto IL_57F;
				case 94:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo).a);
					num2 = (short)508559429;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 95:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack).a);
					num2 = (short)1122762800;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 96:
					if (A_1 == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꇱ釳髵鷷駹裻곽痿氁樃漅昇洉帋漍琏笑笓攕", a_))
					{
						num2 = (short)1444610170;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1506345037;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 97:
					if (A_1 == null)
					{
						num2 = (short)944308273;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)564789257;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 98:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer).b);
					num2 = (short)1418330164;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 99:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob)
					{
						num2 = (short)212795533;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1616445565;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 100:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword).a);
					num2 = (short)1770192977;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 101:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair).a);
					num2 = (short)735051796;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 102:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase)
					{
						num2 = (short)1719337083;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)137822219;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 103:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo)
					{
						num2 = (short)180813936;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1366687872;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 104:
					if (A_1 == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꇱ釳髵鷷駹裻돽囿䴁", a_))
					{
						num2 = (short)1022361639;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1512177760;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 105:
					goto IL_426;
				case 106:
					goto IL_157F;
				case 107:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo).a);
					num2 = (short)1170079762;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 108:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo)
					{
						num2 = (short)1411186819;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)113377398;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 109:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate).a);
					num2 = (short)368443438;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 110:
					return result;
				case 111:
					return result;
				case 112:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo).a);
					num2 = (short)949354515;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 113:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus).a);
					num2 = (short)2080178297;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 114:
					goto IL_7EE;
				case 115:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo)
					{
						num2 = (short)1400963166;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2053570646;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 116:
					if (A_1 == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("믱駳蛵韷裹裻닽懿氁挃猅椇洉椋帍焏焑缓", a_))
					{
						num2 = (short)1991966796;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 117:
					goto IL_C63;
				case 118:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo)
					{
						num2 = (short)406454336;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)969474118;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 119:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio)
					{
						num2 = (short)25100417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1846804612;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 120:
					goto IL_649;
				case 121:
					goto IL_D56;
				case 122:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).b);
					num2 = (short)37421124;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 123:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase).a);
					num2 = (short)1114964104;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 124:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer).a);
					num2 = (short)303366204;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 125:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement)
					{
						num2 = (short)1384710223;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)188612630;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 126:
					goto IL_4E0;
				case 127:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo)
					{
						num2 = (short)1763770396;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)836829314;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 128:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo)
					{
						num2 = (short)1743126635;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1556545627;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 129:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio).a);
					num2 = (short)138674181;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 130:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus)
					{
						num2 = (short)1565458545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)861798404;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 131:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo).a);
					num2 = (short)1722548248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 132:
				{
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair)
					{
						num2 = (short)941621337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1024351812;
					short num3 = num2;
					num2 = (short)419323460;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1411;
					default:
						num2 = (short)1249378304;
						if (num2 != 0)
						{
						}
						num2 = (short)664141926;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 133:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo).a);
					num2 = (short)737542229;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 134:
					goto IL_11EF;
				case 135:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)
					{
						num2 = (short)1617297453;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1700331623;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 136:
					goto IL_D85;
				case 137:
					goto IL_13A3;
				case 138:
					if (A_1 == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("돱蓳蛵铷菹ꣻ鯽淿爁栃朅簇漉砋愍䈏眑砓眕気缙砛䰝䄟䘡䴣䤥嬧", a_))
					{
						num2 = (short)852164709;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 139:
					if (A_1 == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꃱ闳鋵釷闹뿻釽滿琁愃琅笇按挋怍", a_))
					{
						num2 = (short)39714882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1953955944;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 140:
					goto IL_678;
				case 141:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob).a);
					num2 = (short)363724827;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 142:
					num2 = (short)153157695;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 143:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)
					{
						num2 = (short)1423310938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)295698482;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 144:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword)
					{
						num2 = (short)223936612;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)251592776;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 145:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ReadWriteDeviceJob)
					{
						num2 = (short)1880686645;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1896874083;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 146:
					return result;
				case 147:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage)
					{
						num2 = (short)728825927;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1099104256;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 148:
					goto IL_846;
				case 149:
					if (A_1 == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꇱ闳胵鷷믹迻뷽濿氁戃漅漇缉縋漍搏笑笓砕", a_))
					{
						num2 = (short)1407123489;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 150:
					result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo).a);
					num2 = (short)132448288;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_275;
				IL_1454:
				result = new global::System.Func<string, bool>((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).d);
				num2 = (short)369557530;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_31E:
			IL_34D:
			IL_3B9:
			IL_426:
			IL_4E0:
			IL_50F:
			IL_57F:
			IL_5AE:
			IL_61A:
			IL_649:
			IL_678:
			IL_6F4:
			IL_723:
			IL_751:
			IL_7BF:
			return result;
			IL_7EE:
			num2 = (short)85000192;
			short num4 = num2;
			IL_846:
			IL_97A:
			IL_B6A:
			IL_C63:
			IL_D56:
			IL_D85:
			IL_DF1:
			IL_E62:
			IL_ECF:
			IL_F49:
			IL_FB4:
			IL_FE3:
			IL_1088:
			IL_10B8:
			IL_11EF:
			IL_1374:
			IL_13A3:
			IL_1411:
			IL_147D:
			IL_157F:
			return result;
			IL_162E:
			num2 = (short)843120641;
			if (num2 != 0)
			{
			}
			return result;
			IL_275:
			result = null;
			num2 = (short)451870867;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00016204 File Offset: 0x00014404
		private static bool a(this string A_0, string A_1)
		{
			short num = (short)7471105;
			if (num != 0)
			{
			}
			if (!string.IsNullOrWhiteSpace(A_0))
			{
				num = (short)774705991;
				short num2 = num;
				num = (short)769725255;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)672923648;
					if (num != 0)
					{
					}
					num = (short)1762459648;
					short num3 = num;
					return global::System.Globalization.CultureInfo.CurrentCulture.CompareInfo.IndexOf(A_0, A_1, global::System.Globalization.CompareOptions.IgnoreCase) >= 0;
				}
				}
			}
			return false;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000162D4 File Offset: 0x000144D4
		private static bool a(this bool A_0, string A_1)
		{
			short num = (short)866516996;
			int num2 = (int)((global::System.IntPtr)num);
			string text2;
			for (;;)
			{
				string text;
				switch (num2)
				{
				case 0:
					text = global::Motorola.CommonCPS.ResourceRepository.Resources.General_Yes;
					goto IL_9F;
				case 1:
					num = (short)848625669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_B8;
				case 3:
					return false;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
					num = (short)1442643969;
					if (num != 0)
					{
					}
					text = global::Motorola.CommonCPS.ResourceRepository.Resources.General_No;
					goto IL_9F;
				}
				IL_3C:
				if (!A_0)
				{
					num = (short)1198718977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1982201856;
				short num3 = num;
				num = (short)1160812427;
				short num4 = num;
				num = (short)1446221707;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B8;
				default:
					num = (short)165085184;
					if (num != 0)
					{
					}
					num = (short)956039168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9F:
				text2 = text;
				num = (short)1971453954;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B8:
				if (!string.IsNullOrWhiteSpace(text2))
				{
					goto IL_172;
				}
				num = (short)349765635;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_172:
			return global::System.Globalization.CultureInfo.CurrentCulture.CompareInfo.IndexOf(text2, A_1, global::System.Globalization.CompareOptions.IgnoreCase) >= 0;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0001646C File Offset: 0x0001466C
		private static bool a(this bool? A_0, string A_1)
		{
			short num = (short)541917185;
			if (num != 0)
			{
			}
			if (A_0 != null)
			{
				num = (short)625495472;
				short num2 = num;
				num = (short)1167478192;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1028390912;
					if (num != 0)
					{
					}
					num = (short)188088320;
					short num3 = num;
					return A_0.Value.a(A_1);
				}
				}
			}
			return false;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00016530 File Offset: 0x00014730
		private static bool a(this int? A_0, string A_1)
		{
			if (A_0 == null)
			{
				short num = (short)1496075668;
				short num2 = num;
				num = (short)2121485716;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)183435265;
					if (num != 0)
					{
					}
					num = (short)344719360;
					if (num != 0)
					{
					}
					num = (short)1763639296;
					short num3 = num;
					return false;
				}
				}
			}
			return A_0.Value.a(A_1);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000165F4 File Offset: 0x000147F4
		private static bool a(this int A_0, string A_1)
		{
			short num = (short)1381130336;
			short num2 = num;
			num = (short)388980832;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1798242304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)885784576;
			if (num != 0)
			{
			}
			num = (short)747569153;
			if (num != 0)
			{
			}
			return A_0.ToString(global::System.Globalization.CultureInfo.CurrentCulture).a(A_1);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000166B0 File Offset: 0x000148B0
		private static bool a(this global::System.DateTime? A_0, string A_1)
		{
			short num;
			if (A_0 == null)
			{
				num = (short)1054503995;
				short num2 = num;
				num = (short)1284600891;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)909377536;
					if (num != 0)
					{
					}
					num = (short)1796079616;
					short num3 = num;
					return false;
				}
				}
			}
			num = (short)446693377;
			if (num != 0)
			{
			}
			return A_0.Value.a(A_1);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00016774 File Offset: 0x00014974
		private static bool a(this global::System.DateTime A_0, string A_1)
		{
			int a_ = 13;
			short num = (short)904696204;
			short num2 = num;
			num = (short)906334604;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1623982080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1599864833;
			if (num != 0)
			{
			}
			num = (short)1843855360;
			if (num != 0)
			{
			}
			return A_0.ToString(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("맽", a_), global::System.Globalization.CultureInfo.InvariantCulture).a(A_1);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00016848 File Offset: 0x00014A48
		private static bool a(this global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? A_0, string A_1)
		{
			if (A_0 != null)
			{
				short num = (short)166338741;
				short num2 = num;
				num = (short)1071128757;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1204879360;
					if (num != 0)
					{
					}
					num = (short)2037055489;
					if (num != 0)
					{
					}
					num = (short)939261952;
					short num3 = num;
					return A_0.ToResourceString().a(A_1);
				}
				}
			}
			return false;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00016908 File Offset: 0x00014B08
		private static bool a(this global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? A_0, string A_1)
		{
			if (A_0 == null)
			{
				short num = (short)567148545;
				if (num != 0)
				{
				}
			}
			else
			{
				short num = (short)1883156362;
				short num2 = num;
				num = (short)1997909898;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1189150720;
					if (num != 0)
					{
					}
					num = (short)978059264;
					short num3 = num;
					return A_0.ToResourceString().a(A_1);
				}
				}
			}
			return false;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000169CC File Offset: 0x00014BCC
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? A_0, string A_1)
		{
			short num = (short)1406402561;
			if (num != 0)
			{
			}
			if (A_0 != null)
			{
				num = (short)459358701;
				short num2 = num;
				num = (short)564871661;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)239599616;
					if (num != 0)
					{
					}
					num = (short)276496384;
					short num3 = num;
					return A_0.Value.ToResourceString().a(A_1);
				}
				}
			}
			return false;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00016A94 File Offset: 0x00014C94
		private static bool a(this global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus A_0, string A_1)
		{
			short num = (short)1786009888;
			short num2 = num;
			num = (short)316234016;
			switch (num2 == num)
			{
			default:
			{
				num = (short)353370112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1709637633;
			if (num != 0)
			{
			}
			num = (short)1130168320;
			if (num != 0)
			{
			}
			return A_0.ToResourceString().a(A_1);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00016B4C File Offset: 0x00014D4C
		private static bool a(this global::Motorola.CommonCPS.Server.CommonDBConstants.JobType A_0, string A_1)
		{
			short num = (short)191299585;
			if (num != 0)
			{
			}
			num = (short)1144455168;
			short num2 = num;
			num = (short)1215792884;
			short num3 = num;
			num = (short)868648692;
			switch (num3 == num)
			{
			}
			num = (short)1209008128;
			if (num != 0)
			{
			}
			return A_0.ToResourceString().a(A_1);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00016C04 File Offset: 0x00014E04
		private static bool a(this global::Motorola.CommonCPS.Server.CommonDBConstants.JobType? A_0, string A_1)
		{
			if (A_0 != null)
			{
				short num = (short)917183688;
				short num2 = num;
				num = (short)314449096;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1421344768;
					if (num != 0)
					{
					}
					num = (short)1669595137;
					if (num != 0)
					{
					}
					num = (short)202506240;
					short num3 = num;
					return A_0.Value.a(A_1);
				}
				}
			}
			return false;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00016CC8 File Offset: 0x00014EC8
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword A_0, string A_1)
		{
			if (A_0.FileName.a(A_1))
			{
				short num = (short)1351614465;
				if (num != 0)
				{
				}
				num = (short)1518932745;
				short num2 = num;
				num = (short)2145653513;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1184169984;
					if (num != 0)
					{
					}
					num = (short)1738604544;
					short num3 = num;
					return true;
				}
				}
			}
			return A_0.Password.a(A_1);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00016D90 File Offset: 0x00014F90
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo A_0, string A_1)
		{
			short num = (short)1212612615;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!A_0.AppComments.a(A_1))
					{
						num = (short)1269039110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					num = (short)1554186240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_240;
				case 3:
					goto IL_D2;
				case 4:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName regionName;
					if (!(region.GetValueOrDefault() == regionName & region != null))
					{
						num = (short)222953474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 5:
				{
					num = (short)378339328;
					short num3 = num;
					region = A_0.Region;
					global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName regionName = global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NULL;
					num = (short)2053570564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					region = A_0.Region;
					num = (short)56754179;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 8:
					num = (short)633536513;
					if (num != 0)
					{
					}
					num = (short)1615003657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					if (A_0.UIStatus.a(A_1))
					{
						return true;
					}
					num = (short)1144028209;
					short num4 = num;
					num = (short)1123384369;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D2;
					default:
						num = (short)1712390144;
						if (num != 0)
						{
						}
						num = (short)945881089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_4C:
				if (!A_0.FeatureName.a(A_1))
				{
					num = (short)1438253064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_D2:
				if (region == null)
				{
					break;
				}
				num = (short)883949573;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_240:
			region = A_0.Region;
			return region.Value.a(A_1);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00016FE4 File Offset: 0x000151E4
		private static bool a(this global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName A_0, string A_1)
		{
			short num = (short)1449665834;
			short num2 = num;
			num = (short)309273898;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1016987648;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)766771200;
			if (num != 0)
			{
			}
			num = (short)1592262657;
			if (num != 0)
			{
			}
			return A_0.ToResourceString().a(A_1);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00017098 File Offset: 0x00015298
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.Group A_0, string A_1)
		{
			short num = (short)571473921;
			if (num != 0)
			{
			}
			num = (short)1632043008;
			short num2 = num;
			num = (short)5535362;
			short num3 = num;
			num = (short)1183282818;
			switch (num3 == num)
			{
			}
			num = (short)176095232;
			if (num != 0)
			{
			}
			return A_0.Name.a(A_1);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0001714C File Offset: 0x0001534C
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage A_0, string A_1)
		{
			short num = (short)2076062524;
			short num2 = num;
			num = (short)1145254716;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_246:
				num = (short)2102394880;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)486998016;
				if (num != 0)
				{
				}
				num = (short)474546186;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					if (!A_0.ImportTime.a(A_1))
					{
						num = (short)1902772232;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					if (!A_0.Description.a(A_1))
					{
						num = (short)1323696135;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					num = (short)29032452;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)461307915;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!A_0.Size.a(A_1))
					{
						num = (short)137297929;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					goto IL_166;
				case 6:
					if (!A_0.References.a(A_1))
					{
						num = (short)597622789;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 7:
					num = (short)210108429;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_284;
				case 9:
					num = (short)1682767878;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)1227030529;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_D0;
					}
					continue;
				case 11:
					if (!A_0.Version.a(A_1))
					{
						num = (short)1361313794;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 12:
					num = (short)425328641;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (!A_0.ManifestVersion.a(A_1))
					{
						num = (short)2001731587;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_D0:
				num = (short)846528512;
				short num4 = num;
				if (A_0.Name.a(A_1))
				{
					return true;
				}
				num = (short)1750335500;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_166:
			goto IL_246;
			IL_284:
			return A_0.Comments.a(A_1);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00017424 File Offset: 0x00015624
		private static bool b(this global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair A_0, string A_1)
		{
			short num = (short)127270914;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_151;
				case 1:
				{
					num = (short)1465099137;
					short num3 = num;
					num = (short)361669505;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)446496768;
						if (num != 0)
						{
						}
						if (!A_0.Radio.RadioAlias.a(A_1))
						{
							num = (short)758185984;
							short num4 = num;
							num = (short)1495662592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					num = (short)675086337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				num = (short)2019622913;
				if (num != 0)
				{
				}
				if (A_0.Radio.SerialNumber.a(A_1))
				{
					return true;
				}
				num = (short)1354760195;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_151:
			return A_0.Radio.Comments.a(A_1);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00017588 File Offset: 0x00015788
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair A_0, string A_1)
		{
			if (A_0.Radio.SerialNumber.a(A_1))
			{
				short num = (short)2000238611;
				short num2 = num;
				num = (short)381237267;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)6881281;
					if (num != 0)
					{
					}
					num = (short)1577975808;
					if (num != 0)
					{
					}
					num = (short)1606287360;
					short num3 = num;
					return true;
				}
				}
			}
			return A_0.TemplateName.a(A_1);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0001765C File Offset: 0x0001585C
		private static bool a(this global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption A_0, string A_1)
		{
			short num = (short)444727298;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_151;
				case 1:
				{
					num = (short)352921673;
					short num3 = num;
					num = (short)841689161;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)1641480193;
						if (num != 0)
						{
						}
						num = (short)660996096;
						if (num != 0)
						{
						}
						if (!A_0.InnerRadio.RadioAlias.a(A_1))
						{
							num = (short)1050476544;
							short num4 = num;
							num = (short)2099838976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					num = (short)981401601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				if (A_0.InnerRadio.SerialNumber.a(A_1))
				{
					return true;
				}
				num = (short)1047855107;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_151:
			return A_0.InnerRadio.Comments.a(A_1);
		}

		// Token: 0x0400001E RID: 30
		public const string KSeparator = "[$%#@**!@#^%$&]";
	}
}
