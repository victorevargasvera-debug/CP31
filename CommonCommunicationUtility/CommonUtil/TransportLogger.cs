using System;
using System.Text;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004C RID: 76
	public static class TransportLogger
	{
		// Token: 0x0600010D RID: 269 RVA: 0x0000DDA4 File Offset: 0x0000BFA4
		public static void WriteInfo(string logFileSuffix, string format, params object[] message)
		{
			short num = (short)1924512379;
			short num2 = num;
			num = (short)493664891;
			switch (num2 == num)
			{
			}
			num = (short)327221249;
			if (num != 0)
			{
			}
			num = (short)1304559616;
			if (num != 0)
			{
			}
			num = (short)1431044096;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.TransportLogger.MyLogger.UserOperationEx(logFileSuffix, format, message);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000DE58 File Offset: 0x0000C058
		public static void WriteInfo(string logFileSuffix, string log)
		{
			short num = (short)115939272;
			short num2 = num;
			num = (short)931665864;
			switch (num2 == num)
			{
			}
			num = (short)1319370753;
			if (num != 0)
			{
			}
			num = (short)828375040;
			if (num != 0)
			{
			}
			num = (short)560857088;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.TransportLogger.MyLogger.UserOperationEx(logFileSuffix, log, global::System.Array.Empty<object>());
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000DF14 File Offset: 0x0000C114
		public static void Error(global::System.Exception e, string logFileSuffix, string format, params object[] message)
		{
			short num = (short)265682945;
			if (num != 0)
			{
			}
			num = (short)1189597548;
			short num2 = num;
			num = (short)709153132;
			switch (num2 == num)
			{
			}
			num = (short)103088128;
			if (num != 0)
			{
			}
			num = (short)1356791808;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.TransportLogger.MyLogger.ErrorEx(e, logFileSuffix, format, message);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000DFCC File Offset: 0x0000C1CC
		private static global::Motorola.Common.LogUtility.ILog MyLogger
		{
			get
			{
				short num = (short)1553072778;
				short num2 = num;
				num = (short)2026635914;
				switch (num2 == num)
				{
				}
				num = (short)1611857921;
				if (num != 0)
				{
				}
				num = (short)787349504;
				if (num != 0)
				{
				}
				num = (short)1735327744;
				short num3 = num;
				return global::Motorola.Common.LogUtility.LogManager.GetLogger("Com_Raw_Data_Logger");
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000E080 File Offset: 0x0000C280
		private static string a(byte[] A_0, int A_1, int A_2)
		{
			short num = (short)2100166656;
			switch (num)
			{
			default:
			{
				num = (short)330694663;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Text.StringBuilder stringBuilder;
				global::System.Text.StringBuilder stringBuilder2;
				for (;;)
				{
					int num3;
					int num4;
					int num6;
					int num7;
					switch (num2)
					{
					case 0:
						if (num3 >= A_2 / 16)
						{
							num = (short)554696705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1032126475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_377;
					case 2:
					{
						if (num4 >= 16)
						{
							num = (short)85524488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = A_0[A_1 + num3 * 16 + num4];
						stringBuilder.AppendFormat("{0:X2} ", b);
						stringBuilder2.Append(global::Motorola.Common.Communication.CommonUtil.TransportLogger.a(b));
						num4++;
						num = (short)1621360656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)1171394627;
						short num5 = num;
						num = (short)136319043;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1CE;
						default:
							num = (short)658112512;
							if (num != 0)
							{
							}
							goto IL_AF;
						}
						break;
					}
					case 4:
						stringBuilder.AppendLine(global::Motorola.Common.Communication.CommonUtil.TransportLogger.FilterHeader + "...");
						stringBuilder.AppendLine(global::Motorola.Common.Communication.CommonUtil.TransportLogger.FilterHeader + "...");
						stringBuilder.AppendLine(global::Motorola.Common.Communication.CommonUtil.TransportLogger.FilterHeader + "...");
						num = (short)2055667724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1758920705;
						if (num != 0)
						{
						}
						goto IL_AF;
					case 6:
						goto IL_2D6;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_8F;
						}
						continue;
					case 8:
						stringBuilder.Append(stringBuilder2);
						stringBuilder.AppendLine();
						num3++;
						num = (short)705888261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1CE;
					case 10:
						goto IL_AA;
					case 11:
						if (global::Motorola.Common.Communication.CommonUtil.TransportLogger.TruncateData)
						{
							num = (short)880869390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DB;
					case 12:
						goto IL_377;
					case 13:
						if (num3 == 4)
						{
							num = (short)1891958788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DB;
					case 14:
						num = (short)834207757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_29D;
					case 16:
						goto IL_3BE;
					case 17:
					{
						if (num6 >= num7)
						{
							num = (short)1231159302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b2 = A_0[A_1 + A_2 / 16 * 16 + num6];
						stringBuilder.AppendFormat("{0:X2} ", b2);
						stringBuilder2.Append(global::Motorola.Common.Communication.CommonUtil.TransportLogger.a(b2));
						num6++;
						num = (short)1353515017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_3BE;
					}
					IL_8F:
					if (A_0 == null)
					{
						num = (short)656539658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					stringBuilder = new global::System.Text.StringBuilder();
					stringBuilder2 = null;
					num3 = 0;
					num = (short)104333315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AF:
					num = (short)605093888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29D:
					num = (short)856948753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CE:
					goto IL_29D;
					IL_2DB:
					num = (short)1690959872;
					short num8 = num;
					stringBuilder.Append(global::Motorola.Common.Communication.CommonUtil.TransportLogger.FilterHeader);
					stringBuilder2 = new global::System.Text.StringBuilder(new string(' ', 10));
					num4 = 0;
					num = (short)1100873746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_377:
					num7 = A_2 % 16;
					stringBuilder.Append(global::Motorola.Common.Communication.CommonUtil.TransportLogger.FilterHeader);
					stringBuilder2 = new global::System.Text.StringBuilder(new string(' ', 10 + (16 - num7) * 3));
					num6 = 0;
					num = (short)2069692431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BE:
					num = (short)1426522114;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AA:
				return string.Empty;
				IL_2D6:
				stringBuilder.Append(stringBuilder2);
				stringBuilder.AppendLine();
				return stringBuilder.ToString();
			}
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000E508 File Offset: 0x0000C708
		private static char a(byte A_0)
		{
			short num = (short)1546321921;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_122;
				case 1:
				{
					num = (short)206389464;
					short num3 = num;
					num = (short)722157784;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_124;
					default:
						num = (short)1095565312;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					}
					break;
				}
				case 2:
					num = (short)1515585537;
					if (num != 0)
					{
					}
					num = (short)866713603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (A_0 > 127)
					{
						num = (short)1912274944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_124;
				}
				IL_7F:
				if (A_0 < 32)
				{
					break;
				}
				num = (short)1338966016;
				short num4 = num;
				num = (short)563544066;
				num2 = (int)((global::System.IntPtr)num);
			}
			return '.';
			IL_122:
			return '.';
			IL_124:
			return global::System.Convert.ToChar(A_0);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000E640 File Offset: 0x0000C840
		private static string FilterHeader
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)944046080;
					short num2 = num;
					if (global::Motorola.Common.Communication.CommonUtil.TransportLogger.Filter != null)
					{
						break;
					}
					num = (short)399400140;
					short num3 = num;
					num = (short)1121475788;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_9B;
					}
				}
				num = (short)1940193281;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommonUtil.TransportLogger.Filter.Trim();
				IL_9B:
				num = (short)1721827328;
				if (num != 0)
				{
				}
				return string.Empty;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000E704 File Offset: 0x0000C904
		private static bool Enable
		{
			get
			{
				short num = (short)1273681671;
				short num2 = num;
				num = (short)1756616455;
				switch (num2 == num)
				{
				}
				num = (short)1451950081;
				if (num != 0)
				{
				}
				num = (short)274923520;
				if (num != 0)
				{
				}
				num = (short)1949630464;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
		private static bool TruncateData
		{
			get
			{
				short num = (short)1328156106;
				short num2 = num;
				num = (short)1594101194;
				switch (num2 == num)
				{
				}
				num = (short)985595904;
				if (num != 0)
				{
				}
				num = (short)1456472065;
				if (num != 0)
				{
				}
				num = (short)1547108352;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000E85C File Offset: 0x0000CA5C
		private static string Filter
		{
			get
			{
				short num = (short)495987347;
				short num2 = num;
				num = (short)1411721875;
				switch (num2 == num)
				{
				}
				num = (short)112132096;
				if (num != 0)
				{
				}
				num = (short)1010040833;
				if (num != 0)
				{
				}
				num = (short)1099825152;
				short num3 = num;
				return null;
			}
		}

		// Token: 0x04000235 RID: 565
		private const string a = "Com_Raw_Data_Log";

		// Token: 0x04000236 RID: 566
		private const string b = "Filter";

		// Token: 0x04000237 RID: 567
		private const string c = "Enable";

		// Token: 0x04000238 RID: 568
		private const string d = "Truncate";

		// Token: 0x04000239 RID: 569
		private const int e = 16;

		// Token: 0x0400023A RID: 570
		private const int f = 64;
	}
}
