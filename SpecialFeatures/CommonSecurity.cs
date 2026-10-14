using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Motorola.Common.CustomException;
using SpecialFeatures.AcpReportManagerLib;

// Token: 0x02000003 RID: 3
internal class CommonSecurity
{
	// Token: 0x06000004 RID: 4 RVA: 0x00004060 File Offset: 0x00002260
	public static string ComputeHash(string input, byte[] salt = null, uint algorithm = 1U)
	{
		int a_ = 8;
		short num = (short)1162412032;
		switch (num)
		{
		default:
		{
			num = (short)539885570;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				byte[] bytes;
				int num5;
				byte[] array;
				switch (num2)
				{
				case 0:
					goto IL_268;
				case 1:
					goto IL_AB;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_8A;
					}
					continue;
				case 3:
				{
					num = (short)880738304;
					short num3 = num;
					goto IL_2E1;
				}
				case 4:
				{
					num = (short)991262140;
					short num4 = num;
					num = (short)392328636;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1BC;
					default:
						num = (short)1032781824;
						if (num != 0)
						{
						}
						salt = global::CommonSecurity.a(24U);
						num = (short)781385729;
						if (num != 0)
						{
						}
						num = (short)1417674755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					global::System.Array.Reverse(bytes);
					num = (short)418119680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					stringBuilder = new global::System.Text.StringBuilder();
					num5 = 0;
					num = (short)318832654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_229;
				case 8:
					if (num5 >= array.Length)
					{
						num = (short)164888588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BC;
				case 9:
					bytes = global::System.BitConverter.GetBytes(1U);
					num = (short)775290893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (algorithm == 1U)
					{
						num = (short)934739977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B0;
				case 11:
					if (salt == null)
					{
						num = (short)1410007044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E1;
				case 12:
					goto IL_263;
				case 13:
					if (global::System.BitConverter.IsLittleEndian)
					{
						num = (short)1732837381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_268;
				case 14:
					goto IL_229;
				}
				IL_8A:
				if (string.IsNullOrEmpty(input))
				{
					num = (short)1233518593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				array = null;
				num = (short)310312970;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BC:
				stringBuilder.Append(array[num5].ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펊뾌", a_)));
				num5++;
				num = (short)349175815;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_229:
				num = (short)1267269640;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_268:
				num = (short)1142423563;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E1:
				byte[] second = global::CommonSecurity.a(input, salt);
				array = bytes.Concat(salt).Concat(second).ToArray<byte>();
				num = (short)292290566;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AB:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			IL_B0:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			IL_263:
			return stringBuilder.ToString();
		}
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000043B0 File Offset: 0x000025B0
	private static byte[] a(uint A_0 = 24U)
	{
		byte[] array = new byte[A_0];
		global::System.Security.Cryptography.RNGCryptoServiceProvider rngcryptoServiceProvider = new global::System.Security.Cryptography.RNGCryptoServiceProvider();
		short num;
		try
		{
			rngcryptoServiceProvider.GetBytes(array);
		}
		finally
		{
			num = (short)453281486;
			short num2 = num;
			num = (short)1606715086;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_9F:
				switch (0)
				{
				case 0:
					goto IL_BB;
				}
				break;
			default:
				num = (short)331677696;
				if (num != 0)
				{
				}
				num = (short)946339841;
				if (num != 0)
				{
				}
				num = (short)1041432576;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_A9:
				switch (num3)
				{
				case 0:
					goto IL_9F;
				case 1:
					goto IL_EE;
				case 2:
					((global::System.IDisposable)rngcryptoServiceProvider).Dispose();
					num = (short)1401749505;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_BB;
			}
			IL_EE:
			goto IL_F0;
			IL_BB:
			if (rngcryptoServiceProvider != null)
			{
				num = (short)322240514;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_A9;
			}
			IL_F0:;
		}
		num = (short)840368128;
		short num4 = num;
		return array;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000044E8 File Offset: 0x000026E8
	private static byte[] a(string A_0, byte[] A_1)
	{
		short num = (short)895680512;
		short num2 = num;
		byte[] buffer = A_1.Concat(global::System.Text.Encoding.UTF8.GetBytes(A_0)).ToArray<byte>();
		byte[] result = null;
		global::System.Security.Cryptography.SHA256 sha = global::System.Security.Cryptography.SHA256.Create();
		try
		{
			result = sha.ComputeHash(buffer);
		}
		finally
		{
			num = (short)805298146;
			short num3 = num;
			num = (short)325771234;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B6:
				switch (0)
				{
				case 0:
					goto IL_D2;
				}
				break;
			default:
				num = (short)294322176;
				if (num != 0)
				{
				}
				num = (short)1139998720;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_C0:
				switch (num4)
				{
				case 0:
					goto IL_B6;
				case 1:
					goto IL_107;
				case 2:
					((global::System.IDisposable)sha).Dispose();
					num = (short)616628225;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_D2;
			}
			IL_107:
			goto IL_109;
			IL_D2:
			if (sha != null)
			{
				num = (short)564133890;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_C0;
			}
			IL_109:;
		}
		num = (short)811204609;
		if (num != 0)
		{
		}
		return result;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00004638 File Offset: 0x00002838
	private static string a(global::System.Security.Cryptography.SHA256 A_0, string A_1)
	{
		int a_ = 11;
		short num = (short)508689267;
		short num2 = num;
		num = (short)297663347;
		switch ((num2 == num) ? 1 : 0)
		{
		case 0:
		case 2:
			break;
		default:
			num = (short)756940801;
			if (num != 0)
			{
			}
			num = (short)500826112;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_9C;
			}
			break;
		}
		int num3;
		int num4;
		byte[] array;
		global::System.Text.StringBuilder stringBuilder;
		for (;;)
		{
			IL_86:
			switch (num3)
			{
			case 0:
				goto IL_CE;
			case 1:
				goto IL_CE;
			case 2:
				goto IL_FC;
			case 3:
				if (num4 >= array.Length)
				{
					num = (short)352256002;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				stringBuilder.Append(array[num4].ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊏ", a_)));
				num4++;
				num = (short)1429340161;
				num3 = (int)((global::System.IntPtr)num);
				continue;
			}
			goto IL_9C;
			IL_CE:
			num = (short)236978179;
			num3 = (int)((global::System.IntPtr)num);
		}
		IL_FC:
		num = (short)101056512;
		short num5 = num;
		return stringBuilder.ToString();
		IL_9C:
		array = A_0.ComputeHash(global::System.Text.Encoding.UTF8.GetBytes(A_1));
		stringBuilder = new global::System.Text.StringBuilder();
		num4 = 0;
		num = (short)1757675520;
		num3 = (int)((global::System.IntPtr)num);
		goto IL_86;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000047B4 File Offset: 0x000029B4
	private static string a(global::System.DateTime A_0, string A_1)
	{
		int a_ = 11;
		short num = (short)428015616;
		int num2 = (int)num;
		switch (num2)
		{
		default:
		{
			switch (0)
			{
			case 0:
				goto IL_DC;
			}
			byte[] bytes;
			string text;
			global::System.Text.ASCIIEncoding asciiencoding;
			string text2;
			short num6;
			int length;
			int day;
			int num8;
			byte[] bytes3;
			for (;;)
			{
				IL_31:
				byte b;
				byte[] bytes2;
				int num4;
				char c2;
				switch (num2)
				{
				case 0:
					num = (short)1515716630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_5F0;
				case 2:
					if (b != 49)
					{
						num = (short)648871959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45C;
				case 3:
				{
					char c = (char)bytes[2];
					text += c.ToString();
					num = (short)2050097153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					bytes2 = asciiencoding.GetBytes(text2);
					int num3 = bytes2.Length;
					num4 = num3 - 1;
					num = (short)976814098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					num = (short)2060386321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (b < 127)
					{
						num = (short)860946437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_655;
				case 7:
					goto IL_5B2;
				case 8:
					goto IL_45C;
				case 9:
					goto IL_655;
				case 10:
					goto IL_2C4;
				case 11:
					goto IL_16F;
				case 12:
					goto IL_433;
				case 13:
					num = (short)29425666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)1172373543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)1335230470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					num = (short)1265303553;
					if (num != 0)
					{
					}
					if (b != 73)
					{
						num = (short)1923088420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45C;
				case 17:
				{
					num = (short)69664768;
					short num5 = num;
					if (b != 48)
					{
						num = (short)813170701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45C;
				}
				case 18:
					goto IL_5B2;
				case 19:
					if ((int)num6 >= length)
					{
						num = (short)1359937540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1776287784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
				{
					int num3;
					if (num4 == num3 - 1)
					{
						num = (short)859963395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5F0;
				}
				case 21:
				{
					text = A_1 + text;
					global::System.Security.Cryptography.SHA256 sha = global::System.Security.Cryptography.SHA256.Create();
					num = (short)425459737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 22:
					if (b != 108)
					{
						num = (short)178782222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45C;
				case 23:
					num = (short)239992848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (text.Length > 12)
					{
						num = (short)839974924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return text;
				case 25:
					try
					{
						global::System.Security.Cryptography.SHA256 sha;
						text = global::CommonSecurity.a(sha, text);
						goto IL_74C;
					}
					finally
					{
						num = (short)677561835;
						short num7 = num;
						num = (short)721733099;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_3DC:
							switch (0)
							{
							case 0:
								goto IL_3F9;
							}
							break;
						default:
							num = (short)1181417472;
							if (num != 0)
							{
							}
							num = (short)1049886720;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						global::System.Security.Cryptography.SHA256 sha;
						for (;;)
						{
							IL_3E6:
							switch (num2)
							{
							case 0:
								goto IL_3DC;
							case 1:
								goto IL_430;
							case 2:
								((global::System.IDisposable)sha).Dispose();
								num = (short)108658689;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3F9;
						}
						IL_430:
						goto IL_432;
						IL_3F9:
						if (sha != null)
						{
							num = (short)1778122754;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_3E6;
						}
						IL_432:;
					}
					goto IL_433;
					IL_74C:
					num = (short)834338840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_655;
				case 27:
					goto IL_6B9;
				case 28:
					goto IL_2C4;
				case 29:
					num8 = day;
					num = (short)1701773339;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					num = (short)1074069535;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
				{
					int num3;
					if (num4 == num3 - 2)
					{
						num = (short)476381218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16F;
				}
				case 32:
					if (b != 79)
					{
						num = (short)1825767424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45C;
				case 33:
				{
					int num3;
					if (num3 < 6)
					{
						num = (short)624885790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5F0;
				}
				case 34:
				{
					char c = (char)bytes[3];
					text += c.ToString();
					num = (short)2020474891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 35:
					return text;
				case 36:
					num = (short)1859059744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					if (b > 32)
					{
						num = (short)968622095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_655;
				case 38:
					if (num4 < 0)
					{
						num = (short)212074517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)897777697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
				{
					if (b == 111)
					{
						num = (short)1055916040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					string str = text2;
					c2 = (char)b;
					text2 = str + c2.ToString();
					num = (short)282918938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 40:
					if (num8 >= 40)
					{
						num = (short)1623523357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6B9;
				}
				goto IL_DC;
				IL_16F:
				num = (short)390987796;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C4:
				num = (short)1124663315;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_433:
				text = text.Remove(11);
				num = (short)115802147;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45C:
				text2 += global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_);
				num = (short)810090505;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5B2:
				num = (short)1419575334;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5F0:
				string str2 = text;
				c2 = (char)bytes2[num4];
				text = str2 + c2.ToString();
				num4--;
				num = (short)255197191;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_655:
				num6 += 1;
				num = (short)509345802;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6B9:
				b = (bytes3[num8++] ^ bytes[(int)num6]);
				num = (short)1116405797;
				num2 = (int)((global::System.IntPtr)num);
			}
			return text;
			IL_DC:
			day = A_0.Day;
			int month = A_0.Month;
			int year = A_0.Year;
			string s = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힑ﮓﾕﺗﶙ첝즟잡솣슧\ud8a9쎫\udead쪯莱욳ힷ躹覻趽蛁꿃뇅뫇뫉믋﷍铑뿓뇕꣗뿙껛", a_);
			text2 = string.Empty;
			text = string.Empty;
			num8 = day + month;
			asciiencoding = new global::System.Text.ASCIIEncoding();
			bytes3 = asciiencoding.GetBytes(s);
			bytes = asciiencoding.GetBytes(A_0.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf91\ud993", a_)));
			length = bytes.GetLength(0);
			num6 = 0;
			num = (short)107216924;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00004FF8 File Offset: 0x000031F8
	internal static bool isHiddenPwd(string testPwd, string serialNumber)
	{
		short num = (short)1661730817;
		int num2 = (int)((global::System.IntPtr)num);
		for (;;)
		{
			num = (short)1545469952;
			short num3 = num;
			switch (num2)
			{
			case 0:
			{
				bool result = true;
				num = (short)2084700165;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			case 1:
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				continue;
			case 2:
			{
				bool result;
				return result;
			}
			case 3:
			{
				global::System.DateTime now;
				if (global::CommonSecurity.a(now.AddDays(-1.0), serialNumber) == testPwd)
				{
					num = (short)357236742;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				bool result;
				return result;
			}
			case 4:
				goto IL_100;
			case 5:
			{
				bool result;
				return result;
			}
			case 6:
			{
				bool result = true;
				num = (short)182976514;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			case 7:
			{
				global::System.DateTime now;
				if (global::CommonSecurity.a(now.Date, serialNumber) == testPwd)
				{
					num = (short)2133065728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				now = global::System.DateTime.Now;
				num = (short)2101477379;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			}
			IL_6E:
			num = (short)796777076;
			short num4 = num;
			num = (short)934926964;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)371326976;
				if (num != 0)
				{
				}
				num = (short)510984193;
				if (num != 0)
				{
				}
				if (!string.IsNullOrEmpty(serialNumber))
				{
					bool result = false;
					global::System.DateTime now = global::System.DateTime.Now;
					num = (short)703528967;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
			}
			num = (short)1315110916;
			num2 = (int)((global::System.IntPtr)num);
		}
		IL_100:
		throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.COMMON_SECURITY_SERIAL_NUMBER_NULL);
	}

	// Token: 0x04000003 RID: 3
	private const uint a = 1U;

	// Token: 0x04000004 RID: 4
	private const uint b = 24U;
}
