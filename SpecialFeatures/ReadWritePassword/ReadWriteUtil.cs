using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.ReadWritePassword
{
	// Token: 0x02000067 RID: 103
	public class ReadWriteUtil
	{
		// Token: 0x060008B8 RID: 2232 RVA: 0x00093BAC File Offset: 0x00091DAC
		public string encryptMesg(string messg)
		{
			string result;
			short num;
			for (;;)
			{
				result = null;
				try
				{
					result = global::System.Convert.ToBase64String(this.a(messg));
				}
				catch (global::System.Exception)
				{
				}
				num = (short)223949331;
				short num2 = num;
				num = (short)684798483;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_4A;
				}
			}
			IL_4A:
			num = (short)267845632;
			if (num != 0)
			{
			}
			num = (short)799735809;
			if (num != 0)
			{
			}
			num = (short)758120448;
			short num3 = num;
			return result;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00093C7C File Offset: 0x00091E7C
		public string decryptMesg(string messg)
		{
			string result;
			short num;
			for (;;)
			{
				result = null;
				try
				{
					byte[] a_ = global::System.Convert.FromBase64String(messg);
					result = this.a(a_);
				}
				catch (global::System.Exception)
				{
				}
				num = (short)1302900525;
				short num2 = num;
				num = (short)175917;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_4C;
				}
			}
			IL_4C:
			num = (short)47644673;
			if (num != 0)
			{
			}
			num = (short)1357643776;
			if (num != 0)
			{
			}
			num = (short)388497408;
			short num3 = num;
			return result;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00093D4C File Offset: 0x00091F4C
		private static string a(global::System.Security.Cryptography.SHA256 A_0, string A_1)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			int num3;
			byte[] array;
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)2067333121;
					if (num2 != 0)
					{
					}
					goto IL_A5;
				case 1:
					if (num3 >= array.Length)
					{
						num2 = (short)167247874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					stringBuilder.Append(array[num3].ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꒕", a_)));
					num3++;
					num2 = (short)727842816;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_103;
				case 3:
				{
					num2 = (short)578603319;
					short num4 = num2;
					num2 = (short)1744357687;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)32178176;
						if (num2 != 0)
						{
						}
						goto IL_A5;
					}
					break;
				}
				}
				goto IL_29;
				IL_A5:
				num2 = (short)241369088;
				short num5 = num2;
				num2 = (short)1434976257;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_103:
			return stringBuilder.ToString();
			IL_29:
			array = A_0.ComputeHash(global::System.Text.Encoding.UTF8.GetBytes(A_1));
			stringBuilder = new global::System.Text.StringBuilder();
			num3 = 0;
			num2 = (short)1789984771;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00093ED0 File Offset: 0x000920D0
		internal string CalculatePassword(global::System.DateTime date, string serialNumber)
		{
			int a_ = 18;
			short num = (short)1550581760;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_E7;
				}
				global::System.Text.ASCIIEncoding asciiencoding;
				string text;
				string text2;
				int num5;
				int day;
				short num8;
				int length;
				byte[] bytes2;
				byte[] bytes3;
				for (;;)
				{
					IL_30:
					byte b;
					byte[] bytes;
					int num4;
					global::System.Security.Cryptography.SHA256 sha;
					char c;
					switch (num2)
					{
					case 0:
						goto IL_237;
					case 1:
						if (b != 79)
						{
							num = (short)450101284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_66E;
					case 2:
					{
						bytes = asciiencoding.GetBytes(text);
						int num3 = bytes.Length;
						num4 = num3 - 1;
						num = (short)775421955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_5BB;
					case 4:
						num = (short)1644757004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (b > 32)
						{
							num = (short)975044648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64A;
					case 6:
						if (text2.Length > 12)
						{
							num = (short)1161232403;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text2;
					case 7:
						if (num5 >= 40)
						{
							num = (short)1237778460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_712;
					case 8:
						num = (short)858718240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_7A2;
					case 10:
					{
						int num3;
						if (num4 == num3 - 1)
						{
							num = (short)1325727778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_179;
					}
					case 11:
						return text2;
					case 12:
						if (b != 49)
						{
							num = (short)1889533960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_66E;
					case 13:
					{
						num = (short)1844707329;
						if (num != 0)
						{
						}
						num = (short)1089142784;
						short num6 = num;
						num = (short)1446379549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_179;
					case 15:
						num = (short)1541996561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_64A;
					case 17:
						if (b != 48)
						{
							num = (short)1391263748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_66E;
					case 18:
						goto IL_5BB;
					case 19:
						goto IL_422;
					case 20:
						num = (short)1999634462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						try
						{
							text2 = global::SpecialFeatures.ReadWritePassword.ReadWriteUtil.a(sha, text2);
							goto IL_836;
						}
						finally
						{
							num = (short)1919156226;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3D4;
								case 1:
									((global::System.IDisposable)sha).Dispose();
									num = (short)1866072064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_39B;
									}
									continue;
								}
								IL_39B:
								if (sha != null)
								{
									num = (short)1578762241;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3D4:
								num = (short)922912358;
								short num7 = num;
								num = (short)277120614;
								switch ((num7 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_39B;
								default:
									goto IL_40A;
								}
							}
							IL_40A:
							num = (short)368443392;
							if (num != 0)
							{
							}
						}
						goto IL_422;
						IL_836:
						num = (short)357564422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_877;
					case 23:
						goto IL_7A2;
					case 24:
						if (b < 127)
						{
							num = (short)869859343;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64A;
					case 25:
						if (b != 108)
						{
							num = (short)190447655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_66E;
					case 26:
						goto IL_64A;
					case 27:
					{
						if (b == 111)
						{
							num = (short)2124677153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string str = text;
						c = (char)b;
						text = str + c.ToString();
						num = (short)337575952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						num5 = day;
						num = (short)1824718890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (serialNumber == null)
						{
							num = (short)1020723241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_237;
					case 30:
					{
						int num3;
						if (num4 == num3 - 2)
						{
							num = (short)770965547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_877;
					}
					case 31:
						if ((int)num8 >= length)
						{
							num = (short)823853058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2010841095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (b != 73)
						{
							num = (short)1405550629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_66E;
					case 33:
						goto IL_66E;
					case 34:
					{
						char c2 = (char)bytes2[2];
						text2 += c2.ToString();
						num = (short)356974606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						if (num4 < 0)
						{
							num = (short)41811981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)819068966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)1333329945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)373161985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						int num3;
						if (num3 < 6)
						{
							num = (short)1185415188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_179;
					}
					case 39:
						num = (short)1064108059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						num = (short)1337851928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						serialNumber = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralSerialNumber_A9122Value;
						num = (short)451674112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_712;
					case 43:
					{
						char c2 = (char)bytes2[3];
						text2 += c2.ToString();
						num = (short)2015887382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_E7;
					IL_179:
					string str2 = text2;
					c = (char)bytes[num4];
					text2 = str2 + c.ToString();
					num4--;
					num = (short)731316242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_237:
					text2 = serialNumber + text2;
					sha = global::System.Security.Cryptography.SHA256.Create();
					num = (short)1679097877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_422:
					text2 = text2.Remove(11);
					num = (short)1049165835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5BB:
					num = (short)929562659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64A:
					num8 += 1;
					num = (short)320602121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_66E:
					text += global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_);
					num = (short)78446618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_712:
					b = (bytes3[num5++] ^ bytes2[(int)num8]);
					num = (short)2097217541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A2:
					num = (short)419037215;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_877:
					num = (short)2021392394;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text2;
				IL_E7:
				day = date.Day;
				int month = date.Month;
				int year = date.Year;
				string s = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc98咽욠펢캦첨캪얮쎰\udcb2어춶袸즺킾跈ꃊ뫌뷎ꇐꓒ鿘냚뫜꿞蓠釢", a_);
				text = string.Empty;
				text2 = string.Empty;
				num5 = day + month;
				asciiencoding = new global::System.Text.ASCIIEncoding();
				bytes3 = asciiencoding.GetBytes(s);
				bytes2 = asciiencoding.GetBytes(date.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풘횚\ud8a0\udaa2", a_)));
				length = bytes2.GetLength(0);
				num8 = 0;
				num = (short)1277558807;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x000947A8 File Offset: 0x000929A8
		internal bool isHiddenPwd(string testPwd, string serialNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			bool result;
			short num2;
			global::System.DateTime date;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_182;
				case 1:
					result = true;
					num2 = (short)60424192;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_92;
				case 3:
					if (this.CalculatePassword(date, serialNumber) == testPwd)
					{
						num2 = (short)744292356;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					result = true;
					num2 = (short)1222180866;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					if (this.CalculatePassword(date, serialNumber) == testPwd)
					{
						num2 = (short)438829057;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1986876254;
					short num3 = num2;
					num2 = (short)1469338462;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_92;
					case 1:
						break;
					default:
					{
						num2 = (short)728039424;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)24969216;
					if (num2 != 0)
					{
					}
					date = global::System.DateTime.Now.AddDays(-1.0);
					num2 = (short)2005073923;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_28;
			}
			IL_92:
			return result;
			IL_182:
			num2 = (short)765722625;
			if (num2 != 0)
			{
			}
			return result;
			IL_28:
			result = false;
			date = global::System.DateTime.Now.Date;
			num2 = (short)356646917;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00094960 File Offset: 0x00092B60
		private byte[] a(string A_0)
		{
			short num;
			if (A_0 != null)
			{
				num = (short)1117774809;
				short num2 = num;
				num = (short)775087065;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1686765569;
					if (num != 0)
					{
					}
					num = (short)228261888;
					if (num != 0)
					{
					}
					byte[] result = new byte[8];
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
					global::System.Security.Cryptography.DESCryptoServiceProvider descryptoServiceProvider = new global::System.Security.Cryptography.DESCryptoServiceProvider();
					global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, descryptoServiceProvider.CreateEncryptor(global::SpecialFeatures.ReadWritePassword.ReadWriteUtil.b, global::SpecialFeatures.ReadWritePassword.ReadWriteUtil.a), global::System.Security.Cryptography.CryptoStreamMode.Write);
					global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(cryptoStream);
					streamWriter.WriteLine(A_0);
					streamWriter.Close();
					cryptoStream.Close();
					result = memoryStream.ToArray();
					memoryStream.Close();
					return result;
				}
				}
			}
			num = (short)1501691904;
			short num3 = num;
			throw new global::System.ArgumentNullException(global::CommonResources.AppResources.Input_data_is_a_null_reference);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00094A68 File Offset: 0x00092C68
		private string a(byte[] A_0)
		{
			short num;
			if (A_0 != null)
			{
				num = (short)1265374292;
				short num2 = num;
				num = (short)1737495636;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)381222913;
					if (num != 0)
					{
					}
					num = (short)22609920;
					if (num != 0)
					{
					}
					string result = string.Empty;
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(A_0);
					global::System.Security.Cryptography.DESCryptoServiceProvider descryptoServiceProvider = new global::System.Security.Cryptography.DESCryptoServiceProvider();
					global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, descryptoServiceProvider.CreateDecryptor(global::SpecialFeatures.ReadWritePassword.ReadWriteUtil.b, global::SpecialFeatures.ReadWritePassword.ReadWriteUtil.a), global::System.Security.Cryptography.CryptoStreamMode.Read);
					global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(cryptoStream);
					result = streamReader.ReadLine();
					streamReader.Close();
					cryptoStream.Close();
					memoryStream.Close();
					return result;
				}
				}
			}
			num = (short)186515456;
			short num3 = num;
			throw new global::System.ArgumentNullException(global::CommonResources.AppResources.Input_data_is_a_null_reference);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00094B68 File Offset: 0x00092D68
		// Note: this type is marked as 'beforefieldinit'.
		static ReadWriteUtil()
		{
			short num = (short)673926891;
			short num2 = num;
			num = (short)1724993259;
			switch (num2 == num)
			{
			}
			num = (short)989593600;
			if (num != 0)
			{
			}
			num = (short)1281687553;
			if (num != 0)
			{
			}
			num = (short)1895432192;
			short num3 = num;
			global::SpecialFeatures.ReadWritePassword.ReadWriteUtil.a = new byte[]
			{
				12,
				137,
				98,
				65,
				6,
				95,
				175,
				121
			};
			global::SpecialFeatures.ReadWritePassword.ReadWriteUtil.b = new byte[]
			{
				185,
				41,
				200,
				122,
				134,
				218,
				196,
				152
			};
		}

		// Token: 0x0400038B RID: 907
		private static readonly byte[] a;

		// Token: 0x0400038C RID: 908
		private static readonly byte[] b;
	}
}
