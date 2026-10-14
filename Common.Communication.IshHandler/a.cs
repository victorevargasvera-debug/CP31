using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x0200000C RID: 12
	internal class a
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00009F70 File Offset: 0x00008170
		public static string a(string A_0, byte[] A_1 = null, uint A_2 = 1U)
		{
			int a_ = 19;
			short num = (short)1108970756;
			short num2 = num;
			num = (short)394431748;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1889140736;
				if (num != 0)
				{
				}
				num = (short)258080768;
				switch (num)
				{
				default:
				{
					num = (short)1630994438;
					int num3 = (int)((global::System.IntPtr)num);
					global::System.Text.StringBuilder stringBuilder;
					for (;;)
					{
						byte[] bytes;
						byte[] array;
						switch (num3)
						{
						case 0:
							goto IL_1CC;
						case 1:
							goto IL_206;
						case 2:
							bytes = global::System.BitConverter.GetBytes(1U);
							num = (short)618332173;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (A_1 == null)
							{
								num = (short)2014314505;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B5;
						case 4:
							goto IL_2B5;
						case 5:
							goto IL_F0;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_D3;
							}
							continue;
						case 7:
							global::System.Array.Reverse(bytes);
							num = (short)817758216;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_20B;
						case 9:
							A_1 = global::Motorola.Common.Communication.IshHandler.a.a(24U);
							num = (short)815071236;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							int num4;
							if (num4 >= array.Length)
							{
								num = (short)1361313793;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							stringBuilder.Append(array[num4].ToString(global::Motorola.Common.Communication.IshHandler.Validator.b("貽", a_)));
							num4++;
							num = (short)1267400715;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_1CC;
						case 12:
						{
							num = (short)1458896897;
							if (num != 0)
							{
							}
							stringBuilder = new global::System.Text.StringBuilder();
							int num4 = 0;
							num = (short)1500839936;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							num = (short)21823488;
							short num5 = num;
							if (global::System.BitConverter.IsLittleEndian)
							{
								num = (short)38010887;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20B;
						}
						case 14:
							if (A_2 == 1U)
							{
								num = (short)790298626;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F5;
						}
						IL_D3:
						if (string.IsNullOrEmpty(A_0))
						{
							num = (short)782172165;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						array = null;
						num = (short)2071461902;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1CC:
						num = (short)580059146;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_20B:
						num = (short)1670774787;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2B5:
						byte[] second = global::Motorola.Common.Communication.IshHandler.a.a(A_0, A_1);
						array = bytes.Concat(A_1).Concat(second).ToArray<byte>();
						num = (short)1784021004;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_F0:
					break;
					IL_F5:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
					IL_206:
					return stringBuilder.ToString();
				}
				}
				break;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000A2C0 File Offset: 0x000084C0
		private static byte[] a(uint A_0 = 24U)
		{
			byte[] array = new byte[A_0];
			global::System.Security.Cryptography.RandomNumberGenerator randomNumberGenerator = global::System.Security.Cryptography.RandomNumberGenerator.Create();
			short num;
			try
			{
				num = (short)189399041;
				if (num != 0)
				{
				}
				randomNumberGenerator.GetBytes(array);
			}
			finally
			{
				for (;;)
				{
					num = (short)979697666;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_A8;
						case 1:
							((global::System.IDisposable)randomNumberGenerator).Dispose();
							num = (short)1632436224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_73;
							}
							continue;
						}
						IL_73:
						if (randomNumberGenerator == null)
						{
							break;
						}
						num = (short)1364000769;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_AA:
					num = (short)1455599136;
					short num3 = num;
					num = (short)1943645728;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_DF;
					}
					IL_A8:
					goto IL_AA;
				}
				IL_DF:
				num = (short)911409152;
				if (num != 0)
				{
				}
			}
			num = (short)1973682176;
			short num4 = num;
			return array;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000A400 File Offset: 0x00008600
		private static byte[] a(string A_0, byte[] A_1)
		{
			short num = (short)177209345;
			if (num != 0)
			{
			}
			byte[] buffer = A_1.Concat(global::System.Text.Encoding.UTF8.GetBytes(A_0)).ToArray<byte>();
			byte[] result = null;
			global::System.Security.Cryptography.SHA256 sha = global::System.Security.Cryptography.SHA256.Create();
			try
			{
				result = sha.ComputeHash(buffer);
			}
			finally
			{
				for (;;)
				{
					num = (short)1344995330;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_BA;
						case 1:
							((global::System.IDisposable)sha).Dispose();
							num = (short)262602752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_86;
							}
							continue;
						}
						IL_86:
						if (sha == null)
						{
							break;
						}
						num = (short)1360527361;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_BC:
					num = (short)2098141592;
					short num3 = num;
					num = (short)994122136;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_F0;
					}
					IL_BA:
					goto IL_BC;
				}
				IL_F0:
				num = (short)2019557376;
				if (num != 0)
				{
				}
			}
			num = (short)1736835072;
			short num4 = num;
			return result;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000A550 File Offset: 0x00008750
		private static string a(global::System.Security.Cryptography.SHA256 A_0, string A_1)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			int num2;
			byte[] array;
			global::System.Text.StringBuilder stringBuilder;
			short num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_5A;
				case 1:
					if (num2 >= array.Length)
					{
						goto IL_77;
					}
					stringBuilder.Append(array[num2].ToString(global::Motorola.Common.Communication.IshHandler.Validator.b("힮莰", a_)));
					num2++;
					num3 = (short)1384316928;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
				{
					num3 = (short)1748012275;
					short num4 = num3;
					num3 = (short)1098943731;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_77;
					default:
						goto IL_C1;
					}
					break;
				}
				case 3:
					goto IL_5A;
				}
				goto IL_29;
				IL_5A:
				num3 = (short)1328087041;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_77:
				num3 = (short)2066284546;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_C1:
			num3 = (short)374865921;
			if (num3 != 0)
			{
			}
			num3 = (short)370671616;
			if (num3 != 0)
			{
			}
			num3 = (short)1488453632;
			short num5 = num3;
			return stringBuilder.ToString();
			IL_29:
			array = A_0.ComputeHash(global::System.Text.Encoding.UTF8.GetBytes(A_1));
			stringBuilder = new global::System.Text.StringBuilder();
			num2 = 0;
			num3 = (short)1443627011;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000A6D0 File Offset: 0x000088D0
		private static string a(global::System.DateTime A_0, string A_1)
		{
			int a_ = 2;
			short num = (short)154206208;
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
				int num3;
				int day;
				string text;
				byte[] bytes;
				global::System.Text.ASCIIEncoding asciiencoding;
				string text2;
				short num6;
				int length;
				byte[] bytes3;
				for (;;)
				{
					IL_31:
					byte b;
					int num4;
					byte[] bytes2;
					char c2;
					switch (num2)
					{
					case 0:
						goto IL_5BF;
					case 1:
						if (num3 >= 40)
						{
							num = (short)1731264520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_68A;
					case 2:
						num = (short)918814721;
						if (num != 0)
						{
						}
						goto IL_624;
					case 3:
						if (b < 127)
						{
							num = (short)943259672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_624;
					case 4:
						goto IL_624;
					case 5:
						goto IL_2C4;
					case 6:
					{
						int num5;
						if (num4 == num5 - 2)
						{
							num = (short)1638596635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16E;
					}
					case 7:
						num = (short)198115342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num3 = day;
						num = (short)83820556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return text;
					case 10:
						goto IL_2C4;
					case 11:
					{
						char c = (char)bytes[2];
						text += c.ToString();
						num = (short)2075131904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_68A;
					case 13:
						if (num4 < 0)
						{
							num = (short)974192675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1999568927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (b != 79)
						{
							num = (short)1947074599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					case 15:
						goto IL_3BF;
					case 16:
					{
						bytes2 = asciiencoding.GetBytes(text2);
						int num5 = bytes2.Length;
						num4 = num5 - 1;
						num = (short)1066598438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						num = (short)1164181525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (text.Length > 12)
						{
							num = (short)1662582799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 19:
						if (b > 32)
						{
							num = (short)70647845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_624;
					case 20:
						if ((int)num6 >= length)
						{
							num = (short)2136997904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1376190465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (b != 73)
						{
							num = (short)571998215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					case 22:
					{
						if (b == 111)
						{
							num = (short)2123104292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string str = text2;
						c2 = (char)b;
						text2 = str + c2.ToString();
						num = (short)1291452420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						num = (short)737542170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)574160930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_580;
					case 26:
						if (b != 49)
						{
							num = (short)1032585233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					case 27:
					{
						num = (short)282591232;
						short num7 = num;
						char c = (char)bytes[3];
						text += c.ToString();
						num = (short)2120876065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						num = (short)934019078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (b != 108)
						{
							num = (short)1537015848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					case 30:
						try
						{
							global::System.Security.Cryptography.SHA256 sha;
							text = global::Motorola.Common.Communication.IshHandler.a.a(sha, text);
							goto IL_71D;
						}
						finally
						{
							num = (short)1107886080;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Security.Cryptography.SHA256 sha;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_384;
									}
									continue;
								case 1:
									goto IL_3BC;
								case 2:
									((global::System.IDisposable)sha).Dispose();
									num = (short)251330561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_384:
								if (sha == null)
								{
									break;
								}
								num = (short)888078338;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3BC:;
						}
						goto IL_3BF;
						IL_71D:
						num = (short)1324482578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						int num5;
						if (num5 < 6)
						{
							num = (short)1638006812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5BF;
					}
					case 32:
					{
						int num5;
						if (num4 == num5 - 1)
						{
							num = (short)62914571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5BF;
					}
					case 33:
						goto IL_16E;
					case 34:
						if (b != 48)
						{
							num = (short)508690455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					case 35:
					{
						IL_5BA:
						text = A_1 + text;
						global::System.Security.Cryptography.SHA256 sha = global::System.Security.Cryptography.SHA256.Create();
						num = (short)1479540766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						goto IL_3E7;
					case 37:
						num = (short)1140391939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_580;
					case 39:
						num = (short)158335005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						num = (short)1707868182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DC;
					IL_16E:
					num = (short)1716191264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C4:
					num = (short)161546260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BF:
					text = text.Remove(11);
					num = (short)35782665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E7:
					num = (short)103109224;
					short num8 = num;
					num = (short)1233539688;
					switch ((num8 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5BA;
					default:
						num = (short)1120600064;
						if (num != 0)
						{
						}
						text2 += global::Motorola.Common.Communication.IshHandler.Validator.b("펪", a_);
						num = (short)241106946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_580:
					num = (short)883163149;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5BF:
					string str2 = text;
					c2 = (char)bytes2[num4];
					text = str2 + c2.ToString();
					num4--;
					num = (short)1517617177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_624:
					num6 += 1;
					num = (short)1074003973;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_68A:
					b = (bytes3[num3++] ^ bytes[(int)num6]);
					num = (short)365035539;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				IL_DC:
				day = A_0.Day;
				int month = A_0.Month;
				int year = A_0.Year;
				string s = global::Motorola.Common.Communication.IshHandler.Validator.b("쪪\ud8ac\udeb0\udab2펴킶즸풼\udabe꓀諂꿄뗆ꛈ믊럌ﻎꏐ蓒뫔鯞諠铢韤韦黨\ud8ea\udfecꧮ髰铲藴鋶诸", a_);
				text2 = string.Empty;
				text = string.Empty;
				num3 = day + month;
				asciiencoding = new global::System.Text.ASCIIEncoding();
				bytes3 = asciiencoding.GetBytes(s);
				bytes = asciiencoding.GetBytes(A_0.ToString(global::Motorola.Common.Communication.IshHandler.Validator.b("쾪즬ﲰ쪲체캶삸", a_)));
				length = bytes.GetLength(0);
				num6 = 0;
				num = (short)1876951050;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000AF0C File Offset: 0x0000910C
		internal static bool a(string A_0, string A_1)
		{
			short num = (short)296943621;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					bool result;
					return result;
				}
				case 1:
					goto IL_DE;
				case 2:
				{
					global::System.DateTime now;
					if (global::Motorola.Common.Communication.IshHandler.a.a(now.AddDays(-1.0), A_1) == A_0)
					{
						num = (short)2023555078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					bool result;
					return result;
				}
				case 3:
				{
					global::System.DateTime now;
					if (global::Motorola.Common.Communication.IshHandler.a.a(now.Date, A_1) == A_0)
					{
						num = (short)768802820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					now = global::System.DateTime.Now;
					num = (short)465043458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					bool result = true;
					num = (short)388956167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 6:
				{
					bool result = true;
					num = (short)1861877760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					bool result;
					return result;
				}
				}
				IL_45:
				num = (short)486846294;
				short num3 = num;
				num = (short)2122952534;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)484769792;
					if (num != 0)
					{
					}
					if (!string.IsNullOrEmpty(A_1))
					{
						bool result = false;
						global::System.DateTime now = global::System.DateTime.Now;
						num = (short)1780285441;
						if (num != 0)
						{
						}
						num = (short)1583808515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				num = (short)1837760512;
				short num4 = num;
				num = (short)1817772033;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DE:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.COMMON_SECURITY_SERIAL_NUMBER_NULL);
		}

		// Token: 0x04000011 RID: 17
		private const uint a = 1U;

		// Token: 0x04000012 RID: 18
		private const uint b = 24U;
	}
}
