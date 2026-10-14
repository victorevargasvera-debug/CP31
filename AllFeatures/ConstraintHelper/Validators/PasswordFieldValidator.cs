using System;

namespace ConstraintHelper.Validators
{
	// Token: 0x02000600 RID: 1536
	internal class PasswordFieldValidator
	{
		// Token: 0x0600D110 RID: 53520 RVA: 0x00C3E06C File Offset: 0x00C3C26C
		public static bool IsWifiPasswordValid(ref string password, int securityType)
		{
			short num = (short)1731133445;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1395582828;
				short num3 = num;
				num = (short)1873799020;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2113863680;
					if (num != 0)
					{
					}
					num = (short)2047344641;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)111935494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (2 == securityType)
						{
							num = (short)498335744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
					{
						if (1 == securityType)
						{
							num = (short)446103562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1765474304;
						short num4 = num;
						num = (short)1072627713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						return true;
					case 4:
						if (password.Length >= 8)
						{
							num = (short)1737424903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_CE;
						}
						continue;
					case 6:
						if (global::ConstraintHelper.Validators.PasswordFieldValidator.a(ref password))
						{
							num = (short)1055260685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
						goto IL_261;
					case 8:
						goto IL_2A1;
					case 9:
						if (password.Length != 5)
						{
							goto IL_289;
						}
						return true;
					case 10:
						num = (short)833749003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (global::ConstraintHelper.Validators.PasswordFieldValidator.a(ref password))
						{
							num = (short)60293132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 12:
						num = (short)334888969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1074200580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CE:
					if (securityType == 0)
					{
						num = (short)2084438019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1677459458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_289:
				num = (short)1592328200;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_261:
			return password.Length <= 63;
			IL_2A1:
			return password.Length == 13;
		}

		// Token: 0x0600D111 RID: 53521 RVA: 0x00C3E320 File Offset: 0x00C3C520
		public static bool IsDataModemPasswordValid(ref string password)
		{
			short num;
			for (;;)
			{
				num = (short)135790592;
				short num2 = num;
				if (password.Length < 4)
				{
					return false;
				}
				num = (short)622490146;
				short num3 = num;
				num = (short)593719842;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6F;
				}
			}
			IL_6F:
			num = (short)135004161;
			if (num != 0)
			{
			}
			num = (short)2130706432;
			if (num != 0)
			{
			}
			return password.Length <= 32;
		}

		// Token: 0x0600D112 RID: 53522 RVA: 0x00C3E3EC File Offset: 0x00C3C5EC
		private static bool a(ref string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			int num2;
			string text;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_142;
				case 1:
					return false;
				case 2:
				{
					if (num2 >= text.Length)
					{
						num3 = (short)856489987;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)656631664;
					short num4 = num3;
					num3 = (short)1421502320;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num3 = (short)722927616;
						if (num3 != 0)
						{
						}
						num3 = (short)813891585;
						if (num3 != 0)
						{
						}
						num3 = (short)1635647492;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 3:
					return true;
				case 4:
					if (text[num2] > '\u007f')
					{
						num3 = (short)1825374208;
						short num5 = num3;
						num3 = (short)372178945;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num2++;
					num3 = (short)2080571397;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 5:
					goto IL_142;
				}
				goto IL_28;
				IL_142:
				num3 = (short)574619650;
				num = (int)((global::System.IntPtr)num3);
			}
			return false;
			IL_28:
			text = A_0;
			num2 = 0;
			num3 = (short)1961951232;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x02000601 RID: 1537
		private enum WifiPasswordLength : byte
		{
			// Token: 0x040065E5 RID: 26085
			For40BitWep = 5,
			// Token: 0x040065E6 RID: 26086
			For128BitWep = 13,
			// Token: 0x040065E7 RID: 26087
			MinForWpa2 = 8,
			// Token: 0x040065E8 RID: 26088
			MaxForWpa2 = 63
		}

		// Token: 0x02000602 RID: 1538
		private enum ModemPasswordLength : byte
		{
			// Token: 0x040065EA RID: 26090
			Min = 4,
			// Token: 0x040065EB RID: 26091
			Max = 32
		}
	}
}
