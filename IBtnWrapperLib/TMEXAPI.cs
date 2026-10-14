using System;
using System.Runtime.InteropServices;

namespace IBtnWrapperLib
{
	// Token: 0x02000015 RID: 21
	public class TMEXAPI
	{
		// Token: 0x0600007B RID: 123
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMReadFile", SetLastError = true)]
		private static extern short d(int A_0, byte[] A_1, short A_2, byte[] A_3, short A_4);

		// Token: 0x0600007C RID: 124
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMReadFile", SetLastError = true)]
		private static extern short c(int A_0, byte[] A_1, short A_2, byte[] A_3, short A_4);

		// Token: 0x0600007D RID: 125 RVA: 0x0001597C File Offset: 0x00013B7C
		public static short TMReadFile(int session_handle, byte[] state_buffer, short file_handle, byte[] read_buffer, short buff_size)
		{
			short num;
			for (;;)
			{
				num = (short)1568342016;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_B4;
				}
				num = (short)1878544765;
				short num3 = num;
				num = (short)221401469;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_68;
				}
			}
			IL_68:
			num = (short)2029780993;
			if (num != 0)
			{
			}
			num = (short)1491206144;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.c(session_handle, state_buffer, file_handle, read_buffer, buff_size);
			IL_B4:
			return global::IBtnWrapperLib.TMEXAPI.d(session_handle, state_buffer, file_handle, read_buffer, buff_size);
		}

		// Token: 0x0600007E RID: 126
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMExtendedStartSession", SetLastError = true)]
		private static extern int b(short A_0, short A_1, int[] A_2);

		// Token: 0x0600007F RID: 127
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMExtendedStartSession", SetLastError = true)]
		private static extern int a(short A_0, short A_1, int[] A_2);

		// Token: 0x06000080 RID: 128 RVA: 0x00015A48 File Offset: 0x00013C48
		public static int TMExtendedStartSession(short PortNum, short PortType, int[] EnhancedOptions)
		{
			short num;
			for (;;)
			{
				num = (short)1177223168;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_AE;
				}
				num = (short)1182361484;
				short num3 = num;
				num = (short)364996492;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_66;
				}
			}
			IL_66:
			num = (short)762052608;
			if (num != 0)
			{
			}
			num = (short)693764097;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.a(PortNum, PortType, EnhancedOptions);
			IL_AE:
			return global::IBtnWrapperLib.TMEXAPI.b(PortNum, PortType, EnhancedOptions);
		}

		// Token: 0x06000081 RID: 129
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMEndSession", SetLastError = true)]
		private static extern short h(int A_0);

		// Token: 0x06000082 RID: 130
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMEndSession", SetLastError = true)]
		private static extern short g(int A_0);

		// Token: 0x06000083 RID: 131 RVA: 0x00015B0C File Offset: 0x00013D0C
		public static short TMEndSession(int sessionHandle)
		{
			short num;
			for (;;)
			{
				num = (short)2142109696;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_AE;
				}
				num = (short)99454793;
				short num3 = num;
				num = (short)1489145673;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_68;
				}
			}
			IL_68:
			num = (short)807075840;
			if (num != 0)
			{
			}
			num = (short)766771201;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.g(sessionHandle);
			IL_AE:
			return global::IBtnWrapperLib.TMEXAPI.h(sessionHandle);
		}

		// Token: 0x06000084 RID: 132
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMValidSession", SetLastError = true)]
		private static extern short f(int A_0);

		// Token: 0x06000085 RID: 133
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMValidSession", SetLastError = true)]
		private static extern short e(int A_0);

		// Token: 0x06000086 RID: 134 RVA: 0x00015BD0 File Offset: 0x00013DD0
		public static short TMValidSession(int sessionHandle)
		{
			short num;
			for (;;)
			{
				num = (short)1481310208;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_A9;
				}
				num = (short)754148864;
				short num3 = num;
				num = (short)1906533888;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_65;
				}
			}
			IL_65:
			num = (short)275251201;
			if (num != 0)
			{
			}
			num = (short)32505856;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.e(sessionHandle);
			IL_A9:
			return global::IBtnWrapperLib.TMEXAPI.f(sessionHandle);
		}

		// Token: 0x06000087 RID: 135
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMSetup", SetLastError = true)]
		private static extern short d(int A_0);

		// Token: 0x06000088 RID: 136
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMSetup", SetLastError = true)]
		private static extern short c(int A_0);

		// Token: 0x06000089 RID: 137 RVA: 0x00015C8C File Offset: 0x00013E8C
		public static short TMSetup(int sessionHandle)
		{
			short num;
			for (;;)
			{
				num = (short)1951793152;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_AE;
				}
				num = (short)1860811792;
				short num3 = num;
				num = (short)818789392;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_66;
				}
			}
			IL_66:
			num = (short)656080897;
			if (num != 0)
			{
			}
			num = (short)37945344;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.c(sessionHandle);
			IL_AE:
			return global::IBtnWrapperLib.TMEXAPI.d(sessionHandle);
		}

		// Token: 0x0600008A RID: 138
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMFamilySearchSetup", SetLastError = true)]
		private static extern short f(int A_0, byte[] A_1, short A_2);

		// Token: 0x0600008B RID: 139
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMFamilySearchSetup", SetLastError = true)]
		private static extern short e(int A_0, byte[] A_1, short A_2);

		// Token: 0x0600008C RID: 140 RVA: 0x00015D50 File Offset: 0x00013F50
		public static short TMFamilySearchSetup(int session_handle, byte[] state_buffer, short family_type)
		{
			short num;
			for (;;)
			{
				num = (short)1693908992;
				short num2 = num;
				num = (short)472121345;
				if (num != 0)
				{
				}
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_AF;
				}
				num = (short)1059910989;
				short num3 = num;
				num = (short)579532109;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8F;
				}
			}
			IL_8F:
			num = (short)463929344;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.e(session_handle, state_buffer, family_type);
			IL_AF:
			return global::IBtnWrapperLib.TMEXAPI.f(session_handle, state_buffer, family_type);
		}

		// Token: 0x0600008D RID: 141
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMCreateFile", SetLastError = true)]
		private static extern short b(int A_0, byte[] A_1, out short A_2, byte[] A_3);

		// Token: 0x0600008E RID: 142
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMCreateFile", SetLastError = true)]
		private static extern short a(int A_0, byte[] A_1, out short A_2, byte[] A_3);

		// Token: 0x0600008F RID: 143 RVA: 0x00015E14 File Offset: 0x00014014
		public static short TMCreateFile(int session_handle, byte[] state_buffer, out short maxwrite, byte[] fentry)
		{
			short num;
			for (;;)
			{
				num = (short)1009057792;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_AE;
				}
				num = (short)1901172176;
				short num3 = num;
				num = (short)215979472;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_66;
				}
			}
			IL_66:
			num = (short)2031617;
			if (num != 0)
			{
			}
			num = (short)1043857408;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.a(session_handle, state_buffer, out maxwrite, fentry);
			IL_AE:
			return global::IBtnWrapperLib.TMEXAPI.b(session_handle, state_buffer, out maxwrite, fentry);
		}

		// Token: 0x06000090 RID: 144
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMWriteFile", SetLastError = true)]
		private static extern short b(int A_0, byte[] A_1, short A_2, byte[] A_3, short A_4);

		// Token: 0x06000091 RID: 145
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMWriteFile", SetLastError = true)]
		private static extern short a(int A_0, byte[] A_1, short A_2, byte[] A_3, short A_4);

		// Token: 0x06000092 RID: 146 RVA: 0x00015ED8 File Offset: 0x000140D8
		public static short TMWriteFile(int session_handle, byte[] state_buffer, short file_handle, byte[] write_buffer, short num_write)
		{
			short num;
			for (;;)
			{
				num = (short)287113216;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_B4;
				}
				num = (short)1554231844;
				short num3 = num;
				num = (short)1827189284;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_69;
				}
			}
			IL_69:
			num = (short)1519583233;
			if (num != 0)
			{
			}
			num = (short)2133000192;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.a(session_handle, state_buffer, file_handle, write_buffer, num_write);
			IL_B4:
			return global::IBtnWrapperLib.TMEXAPI.b(session_handle, state_buffer, file_handle, write_buffer, num_write);
		}

		// Token: 0x06000093 RID: 147
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMFirst", SetLastError = true)]
		private static extern short h(int A_0, byte[] A_1);

		// Token: 0x06000094 RID: 148
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMFirst", SetLastError = true)]
		private static extern short g(int A_0, byte[] A_1);

		// Token: 0x06000095 RID: 149 RVA: 0x00015FA4 File Offset: 0x000141A4
		public static short TMFirst(int session_handle, byte[] state_buffer)
		{
			short num;
			for (;;)
			{
				num = (short)1996357632;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_AD;
				}
				num = (short)1902295714;
				short num3 = num;
				num = (short)1222752930;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_66;
				}
			}
			IL_66:
			num = (short)552796161;
			if (num != 0)
			{
			}
			num = (short)1811021824;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.g(session_handle, state_buffer);
			IL_AD:
			return global::IBtnWrapperLib.TMEXAPI.h(session_handle, state_buffer);
		}

		// Token: 0x06000096 RID: 150
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMNext", SetLastError = true)]
		private static extern short f(int A_0, byte[] A_1);

		// Token: 0x06000097 RID: 151
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMNext", SetLastError = true)]
		private static extern short e(int A_0, byte[] A_1);

		// Token: 0x06000098 RID: 152 RVA: 0x00016068 File Offset: 0x00014268
		public static short TMNext(int session_handle, byte[] state_buffer)
		{
			short num;
			for (;;)
			{
				num = (short)627245056;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_B2;
				}
				num = (short)851704046;
				short num3 = num;
				num = (short)1119746286;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6A;
				}
			}
			IL_6A:
			num = (short)927793152;
			if (num != 0)
			{
			}
			num = (short)828768257;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.e(session_handle, state_buffer);
			IL_B2:
			return global::IBtnWrapperLib.TMEXAPI.f(session_handle, state_buffer);
		}

		// Token: 0x06000099 RID: 153
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMRom", SetLastError = true)]
		private static extern short b(int A_0, byte[] A_1, short[] A_2);

		// Token: 0x0600009A RID: 154
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMRom", SetLastError = true)]
		private static extern short a(int A_0, byte[] A_1, short[] A_2);

		// Token: 0x0600009B RID: 155 RVA: 0x00016130 File Offset: 0x00014330
		public static short TMRom(int session_handle, byte[] state_buffer, short[] ROM)
		{
			short num;
			for (;;)
			{
				num = (short)839581696;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_AC;
				}
				num = (short)1047270706;
				short num3 = num;
				num = (short)1202656562;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_65;
				}
			}
			IL_65:
			num = (short)698023936;
			if (num != 0)
			{
			}
			num = (short)579534849;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.a(session_handle, state_buffer, ROM);
			IL_AC:
			return global::IBtnWrapperLib.TMEXAPI.b(session_handle, state_buffer, ROM);
		}

		// Token: 0x0600009C RID: 156
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMOpenFile", SetLastError = true)]
		private static extern short h(int A_0, byte[] A_1, byte[] A_2);

		// Token: 0x0600009D RID: 157
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMOpenFile", SetLastError = true)]
		private static extern short g(int A_0, byte[] A_1, byte[] A_2);

		// Token: 0x0600009E RID: 158 RVA: 0x000161F4 File Offset: 0x000143F4
		public static short TMOpenFile(int session_handle, byte[] state_buffer, byte[] fentry)
		{
			short num;
			for (;;)
			{
				num = (short)1317797888;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_B2;
				}
				num = (short)1726044260;
				short num3 = num;
				num = (short)1668438116;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_67;
				}
			}
			IL_67:
			num = (short)1254555648;
			if (num != 0)
			{
			}
			num = (short)686489601;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.g(session_handle, state_buffer, fentry);
			IL_B2:
			return global::IBtnWrapperLib.TMEXAPI.h(session_handle, state_buffer, fentry);
		}

		// Token: 0x0600009F RID: 159
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMCloseFile", SetLastError = true)]
		private static extern short d(int A_0, byte[] A_1, short A_2);

		// Token: 0x060000A0 RID: 160
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMCloseFile", SetLastError = true)]
		private static extern short c(int A_0, byte[] A_1, short A_2);

		// Token: 0x060000A1 RID: 161 RVA: 0x000162BC File Offset: 0x000144BC
		public static short TMCloseFile(int session_handle, byte[] state_buffer, short file_handle)
		{
			short num;
			for (;;)
			{
				num = (short)855310336;
				short num2 = num;
				num = (short)855769089;
				if (num != 0)
				{
				}
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_AF;
				}
				num = (short)106082609;
				short num3 = num;
				num = (short)882159921;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8F;
				}
			}
			IL_8F:
			num = (short)1671757824;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.c(session_handle, state_buffer, file_handle);
			IL_AF:
			return global::IBtnWrapperLib.TMEXAPI.d(session_handle, state_buffer, file_handle);
		}

		// Token: 0x060000A2 RID: 162
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMDeleteFile", SetLastError = true)]
		private static extern short f(int A_0, byte[] A_1, byte[] A_2);

		// Token: 0x060000A3 RID: 163
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMDeleteFile", SetLastError = true)]
		private static extern short e(int A_0, byte[] A_1, byte[] A_2);

		// Token: 0x060000A4 RID: 164 RVA: 0x00016380 File Offset: 0x00014580
		public static short TMDeleteFile(int session_handle, byte[] state_buffer, byte[] fentry)
		{
			short num;
			for (;;)
			{
				num = (short)1179648000;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_B0;
				}
				num = (short)1727043800;
				short num3 = num;
				num = (short)2097715416;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_68;
				}
			}
			IL_68:
			num = (short)2101346305;
			if (num != 0)
			{
			}
			num = (short)1002176512;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.e(session_handle, state_buffer, fentry);
			IL_B0:
			return global::IBtnWrapperLib.TMEXAPI.f(session_handle, state_buffer, fentry);
		}

		// Token: 0x060000A5 RID: 165
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMFormat", SetLastError = true)]
		private static extern short d(int A_0, byte[] A_1);

		// Token: 0x060000A6 RID: 166
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMFormat", SetLastError = true)]
		private static extern short c(int A_0, byte[] A_1);

		// Token: 0x060000A7 RID: 167 RVA: 0x00016448 File Offset: 0x00014648
		public static short TMFormat(int session_handle, byte[] state_buffer)
		{
			short num;
			for (;;)
			{
				num = (short)1009123328;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_B2;
				}
				num = (short)1430505419;
				short num3 = num;
				num = (short)357091275;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6A;
				}
			}
			IL_6A:
			num = (short)762118145;
			if (num != 0)
			{
			}
			num = (short)1624637440;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.c(session_handle, state_buffer);
			IL_B2:
			return global::IBtnWrapperLib.TMEXAPI.d(session_handle, state_buffer);
		}

		// Token: 0x060000A8 RID: 168
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMFirstFile", SetLastError = true)]
		private static extern short d(int A_0, byte[] A_1, byte[] A_2);

		// Token: 0x060000A9 RID: 169
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMFirstFile", SetLastError = true)]
		private static extern short c(int A_0, byte[] A_1, byte[] A_2);

		// Token: 0x060000AA RID: 170 RVA: 0x00016510 File Offset: 0x00014710
		public static short TMFirstFile(int session_handle, byte[] state_buffer, byte[] fentry)
		{
			short num;
			for (;;)
			{
				num = (short)1597046784;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_B4;
				}
				num = (short)354121550;
				short num3 = num;
				num = (short)1650947918;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_69;
				}
			}
			IL_69:
			num = (short)727515137;
			if (num != 0)
			{
			}
			num = (short)2134835200;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.c(session_handle, state_buffer, fentry);
			IL_B4:
			return global::IBtnWrapperLib.TMEXAPI.d(session_handle, state_buffer, fentry);
		}

		// Token: 0x060000AB RID: 171
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMNextFile", SetLastError = true)]
		private static extern short b(int A_0, byte[] A_1, byte[] A_2);

		// Token: 0x060000AC RID: 172
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMNextFile", SetLastError = true)]
		private static extern short a(int A_0, byte[] A_1, byte[] A_2);

		// Token: 0x060000AD RID: 173 RVA: 0x000165DC File Offset: 0x000147DC
		public static short TMNextFile(int session_handle, byte[] state_buffer, byte[] fentry)
		{
			short num;
			for (;;)
			{
				num = (short)1415970816;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_AD;
				}
				num = (short)1456996353;
				if (num != 0)
				{
				}
				num = (short)1680017463;
				short num3 = num;
				num = (short)884410423;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8B;
				}
			}
			IL_8B:
			num = (short)1993998336;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.a(session_handle, state_buffer, fentry);
			IL_AD:
			return global::IBtnWrapperLib.TMEXAPI.b(session_handle, state_buffer, fentry);
		}

		// Token: 0x060000AE RID: 174
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMStrongAccess", SetLastError = true)]
		private static extern short b(int A_0, byte[] A_1);

		// Token: 0x060000AF RID: 175
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMStrongAccess", SetLastError = true)]
		private static extern short a(int A_0, byte[] A_1);

		// Token: 0x060000B0 RID: 176 RVA: 0x000166A0 File Offset: 0x000148A0
		public static short TMStrongAccess(int session_handle, byte[] state_buffer)
		{
			short num;
			for (;;)
			{
				num = (short)554762240;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_AE;
				}
				num = (short)1246322202;
				short num3 = num;
				num = (short)710893082;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_67;
				}
			}
			IL_67:
			num = (short)845676545;
			if (num != 0)
			{
			}
			num = (short)609812480;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.a(session_handle, state_buffer);
			IL_AE:
			return global::IBtnWrapperLib.TMEXAPI.b(session_handle, state_buffer);
		}

		// Token: 0x060000B1 RID: 177
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMBlockStream", SetLastError = true)]
		private static extern short b(int A_0, byte[] A_1, short A_2);

		// Token: 0x060000B2 RID: 178
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMBlockStream", SetLastError = true)]
		private static extern short a(int A_0, byte[] A_1, short A_2);

		// Token: 0x060000B3 RID: 179 RVA: 0x00016764 File Offset: 0x00014964
		public static short TMBlockStream(int sessionHandle, byte[] dataBlock, short len)
		{
			short num;
			for (;;)
			{
				num = (short)1629683712;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_AC;
				}
				num = (short)2072522972;
				short num3 = num;
				num = (short)942551260;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_66;
				}
			}
			IL_66:
			num = (short)1870987264;
			if (num != 0)
			{
			}
			num = (short)1589641217;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.a(sessionHandle, dataBlock, len);
			IL_AC:
			return global::IBtnWrapperLib.TMEXAPI.b(sessionHandle, dataBlock, len);
		}

		// Token: 0x060000B4 RID: 180
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMOneWireCom", SetLastError = true)]
		private static extern short b(int A_0, short A_1, short A_2);

		// Token: 0x060000B5 RID: 181
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMOneWireCom", SetLastError = true)]
		private static extern short a(int A_0, short A_1, short A_2);

		// Token: 0x060000B6 RID: 182 RVA: 0x00016828 File Offset: 0x00014A28
		public static short TMOneWireCom(int sessionHandle, short command, short argument)
		{
			short num;
			for (;;)
			{
				num = (short)1979645952;
				short num2 = num;
				num = (short)1235091457;
				if (num != 0)
				{
				}
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_AF;
				}
				num = (short)1312893836;
				short num3 = num;
				num = (short)1284713356;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8D;
				}
			}
			IL_8D:
			num = (short)1327759360;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.a(sessionHandle, command, argument);
			IL_AF:
			return global::IBtnWrapperLib.TMEXAPI.b(sessionHandle, command, argument);
		}

		// Token: 0x060000B7 RID: 183
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMTouchReset", SetLastError = true)]
		private static extern short b(int A_0);

		// Token: 0x060000B8 RID: 184
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMTouchReset", SetLastError = true)]
		private static extern short a(int A_0);

		// Token: 0x060000B9 RID: 185 RVA: 0x000168EC File Offset: 0x00014AEC
		public static short TMTouchReset(int session_handle)
		{
			short num;
			for (;;)
			{
				num = (short)1948319744;
				short num2 = num;
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_87;
				}
				num = (short)1888824536;
				short num3 = num;
				num = (short)1543908568;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_68;
				}
			}
			IL_68:
			num = (short)1076101120;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.a(session_handle);
			IL_87:
			num = (short)2120220673;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.b(session_handle);
		}

		// Token: 0x060000BA RID: 186
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMTouchByte", SetLastError = true)]
		private static extern short b(int A_0, short A_1);

		// Token: 0x060000BB RID: 187
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMTouchByte", SetLastError = true)]
		private static extern short a(int A_0, short A_1);

		// Token: 0x060000BC RID: 188 RVA: 0x000169B0 File Offset: 0x00014BB0
		public static short TMTouchByte(int session_handle, short outbyte)
		{
			short num;
			for (;;)
			{
				num = (short)785055744;
				short num2 = num;
				num = (short)400162817;
				if (num != 0)
				{
				}
				if (!global::System.Environment.Is64BitProcess)
				{
					goto IL_AB;
				}
				num = (short)405500757;
				short num3 = num;
				num = (short)1268806485;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8C;
				}
			}
			IL_8C:
			num = (short)366215168;
			if (num != 0)
			{
			}
			return global::IBtnWrapperLib.TMEXAPI.a(session_handle, outbyte);
			IL_AB:
			return global::IBtnWrapperLib.TMEXAPI.b(session_handle, outbyte);
		}

		// Token: 0x060000BD RID: 189
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", EntryPoint = "TMCRC", SetLastError = true)]
		private static extern short b(short A_0, byte[] A_1, ushort A_2, short A_3);

		// Token: 0x060000BE RID: 190
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", EntryPoint = "TMCRC", SetLastError = true)]
		private static extern short a(short A_0, byte[] A_1, ushort A_2, short A_3);

		// Token: 0x060000BF RID: 191 RVA: 0x00016A70 File Offset: 0x00014C70
		public static short TMCRC(short length, byte[] buf, ushort seed, short Type)
		{
			if (!global::System.Environment.Is64BitProcess)
			{
				short num = (short)1086886739;
				short num2 = num;
				num = (short)1882559315;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1032060928;
					if (num != 0)
					{
					}
					num = (short)57475073;
					if (num != 0)
					{
					}
					num = (short)2117533696;
					short num3 = num;
					return global::IBtnWrapperLib.TMEXAPI.b(length, buf, seed, Type);
				}
				}
			}
			return global::IBtnWrapperLib.TMEXAPI.a(length, buf, seed, Type);
		}

		// Token: 0x040000BB RID: 187
		public const string tmexapi32 = "ibfs32.dll";

		// Token: 0x040000BC RID: 188
		public const string tmexapi64 = "ibfs64.dll";
	}
}
