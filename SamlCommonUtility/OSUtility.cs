using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Motorola.Security.SamlCommonUtility.DMHttpClients;

namespace Motorola.Security.SamlCommonUtility
{
	// Token: 0x02000018 RID: 24
	public static class OSUtility
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00006844 File Offset: 0x00004A44
		public static global::Motorola.Security.SamlCommonUtility.OSVersion GetOSVersion()
		{
			int a_ = 14;
			short num = (short)2080178176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_D5;
				}
				global::Motorola.Security.SamlCommonUtility.OSVersion result;
				global::System.Version version;
				global::System.OperatingSystem osversion;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
					{
						int revision;
						if (revision.ToString(global::System.Globalization.CultureInfo.InvariantCulture) == global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("薶许覺込ﺾ", a_))
						{
							num = (short)1668087843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_98;
						num = (short)352387091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						int num3 = version.Minor;
						num = (short)754712589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return result;
					case 3:
						return result;
					case 4:
						return result;
					case 5:
						result = global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_7_or_2008R2;
						num = (short)955187202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return result;
					case 7:
						if (osversion.Platform == global::System.PlatformID.Win32NT)
						{
							num = (short)1342504981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 8:
						result = global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_Vista_SP2_or_2008_SP2;
						num = (short)1295515651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return result;
					case 10:
						result = global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_2000;
						num = (short)1965096989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)1661268263;
						short num4 = num;
						num = (short)1700135;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4D0;
						default:
							num = (short)485621760;
							if (num != 0)
							{
							}
							num = (short)2062811152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						return result;
					case 13:
					{
						int num3;
						if (num3 != 0)
						{
							num = (short)2018574362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_95;
						num = (short)1080688663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						int num3;
						switch (num3)
						{
						case 3:
							result = global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_NT_3_51;
							num = (short)700383262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							result = global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_NT_4_0;
							num = (short)1573060623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)462159894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)1075642392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						case 8:
						case 9:
							return result;
						case 10:
							result = global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_8_or_2012_and_Above;
							num = (short)1670905868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1885208612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
						return result;
					case 16:
						return result;
					case 17:
						if (osversion.Platform == global::System.PlatformID.Win32Windows)
						{
							num = (short)1039728641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2099838983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (version.Minor == 1)
						{
							num = (short)351207429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1753022496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						return result;
					case 20:
						return result;
					case 21:
					{
						int num3 = version.Major;
						num = (short)772734990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if (version.Minor == 0)
						{
							num = (short)709033994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_XP_or_2003;
						num = (short)833028100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						return result;
					case 24:
						if (version.Minor == 0)
						{
							num = (short)57540642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2135752722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						return result;
					case 26:
						num = (short)186449957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						return result;
					case 28:
					{
						int num3;
						if (num3 != 90)
						{
							num = (short)85327883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_98_SE;
						goto IL_4D0;
					}
					case 29:
						return result;
					case 30:
						return result;
					case 31:
						result = global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_8_or_2012_and_Above;
						num = (short)813629460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (version.Minor >= 2)
						{
							num = (short)1613430815;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 33:
						num = (short)631308316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)116129830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						result = global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_98_SE;
						num = (short)1207500825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)1565261833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
					{
						int num3;
						if (num3 != 10)
						{
							num = (short)1611923489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int revision = version.Revision;
						num = (short)1077477377;
						if (num != 0)
						{
						}
						num = (short)696188928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						if (global::Motorola.Security.SamlCommonUtility.OSUtility.NativeMethods.GetServicePackLevel() > 1)
						{
							num = (short)817037320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_Vista_or_2008;
						num = (short)722403355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D5;
					IL_4D0:
					num = (short)2017132550;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_D5:
				result = global::Motorola.Security.SamlCommonUtility.OSVersion.Unknown;
				osversion = global::System.Environment.OSVersion;
				version = osversion.Version;
				num = (short)1125580800;
				short num5 = num;
				num = (short)28770321;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006EFC File Offset: 0x000050FC
		public static string GetHostIDHash(string currentStorePath, bool reviseBootSerialNumber = false)
		{
			int a_ = 12;
			short num = (short)1260650497;
			if (num != 0)
			{
			}
			num = (short)1095368704;
			switch (num)
			{
			default:
			{
				string result = string.Empty;
				global::System.Security.Cryptography.HMACSHA256 hmacsha = null;
				try
				{
					num = (short)479723533;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						int num3;
						switch (num2)
						{
						case 0:
						{
							string text2;
							string text = text + text2.Substring(num3 + 1, 1) + text2.Substring(num3, 1);
							num = (short)1258487826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (global::System.IO.File.Exists(currentStorePath))
							{
								num = (short)127729670;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_766;
						case 2:
							num = (short)1790640129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_766;
						case 4:
						{
							byte[] array;
							try
							{
								global::System.IO.FileStream fileStream;
								array = new byte[fileStream.Length];
								fileStream.Read(array, 0, (int)fileStream.Length);
								goto IL_23F;
							}
							finally
							{
								num = (short)1178861570;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.IO.FileStream fileStream;
									switch (num2)
									{
									case 0:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)697106433;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_424;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_3EC;
										}
										continue;
									}
									IL_3EC:
									if (fileStream == null)
									{
										break;
									}
									num = (short)735051776;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_424:;
							}
							goto Block_7;
							IL_23F:
							string text3;
							string text4;
							global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::System.Security.Cryptography.ProtectedData.Unprotect(array, global::System.Text.Encoding.UTF8.GetBytes(text3 + text4), global::System.Security.Cryptography.DataProtectionScope.LocalMachine));
							num = (short)497483791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							string text2;
							if (num3 < text2.Length - 1)
							{
								num = (short)2002124800;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text = text + global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("薴", a_) + text2.Substring(num3, 1);
							num = (short)1483276297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							string text3 = global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ﶴ\ud8b6쪸쾺﮾裀귂ꏄ꣆믈ꛊ곌믎룐볒믔", a_);
							string text4 = global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("\ud8b6횸쾺\udabe돀ꫂ꓄ꯆ蟈뻊ꃌ귎듐ꇒ", a_);
							string expandedName = global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ﺶ\udabe돀ꫂ꓄ꯆ蟈뻊ꃌ귎듐ꇒ", a_);
							string expandedName2 = global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ﾺ", a_);
							string text2 = string.Empty;
							string str = string.Empty;
							string str2 = string.Empty;
							byte[] array = null;
							global::System.Xml.Linq.XDocument xdocument = new global::System.Xml.Linq.XDocument();
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(currentStorePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
							num = (short)1599537156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_F0;
						case 8:
							goto IL_780;
						case 9:
							goto IL_27C;
						case 10:
							goto IL_F0;
						case 11:
						{
							string text;
							string text2 = text;
							num = (short)360775696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							if (reviseBootSerialNumber)
							{
								num = (short)1975189518;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_29F;
						case 13:
							switch (0)
							{
							case 0:
								goto IL_CA;
							}
							continue;
						case 14:
						{
							string text = string.Empty;
							num3 = 0;
							goto IL_221;
						}
						case 15:
							goto IL_427;
						case 16:
							goto IL_29F;
						case 17:
						{
							string text2;
							if (num3 >= text2.Length)
							{
								num = (short)522190859;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1396310021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
							goto IL_27C;
						}
						IL_CA:
						if (!string.IsNullOrEmpty(currentStorePath))
						{
							num = (short)454819842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_766;
						IL_F0:
						num = (short)196411409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_221:
						num = (short)843317255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_29F:
						num = (short)1848699741;
						short num4 = num;
						num = (short)293530461;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_221;
						default:
						{
							num = (short)1364000768;
							if (num != 0)
							{
							}
							string text2;
							string str;
							string str2;
							string s = text2 + str + str2;
							byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(s);
							hmacsha = new global::System.Security.Cryptography.HMACSHA256(global::System.Text.Encoding.UTF8.GetBytes(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("许了込料菀苂蓆裊诌雒雔鋖髚ꏠ컢ꛤꇦꫨ폪\udeec꯮죰닲쳴컶컸맺탼쳾䈀。㐄䔆伈㌊䠌∎‐倒∔☖㐘⼚堜⨞挠ยᴤጦḨἪᨬἮ࠰ز", a_)));
							hmacsha.ComputeHash(bytes);
							result = global::System.Convert.ToBase64String(bytes);
							num = (short)1398603779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_27C:
						num3 += 2;
						num = (short)2121728010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						Block_7:
						try
						{
							IL_427:
							switch (0)
							{
							case 0:
								goto IL_448;
							}
							global::System.Xml.Linq.XDocument xdocument;
							for (;;)
							{
								IL_431:
								global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_63A;
								case 1:
									try
									{
										num = (short)1791295491;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)2125135874;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)128909312;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Xml.Linq.XElement xelement = enumerator.Current;
												string text4;
												string text2 = xelement.Element(text4).Value;
												string expandedName2;
												string str = xelement.Element(expandedName2).Value;
												string expandedName;
												string str2 = xelement.Element(expandedName).Value;
												num = (short)337051652;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												goto IL_57B;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_4CC;
												}
												continue;
											}
											IL_527:
											num = (short)322568193;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4CC:
											goto IL_527;
										}
										IL_57B:
										goto IL_622;
									}
									finally
									{
										num = (short)519438338;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)651100161;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_5EC;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_5B3;
												}
												continue;
											}
											IL_5B3:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1406926848;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_5EC:;
									}
									goto IL_5EF;
								case 2:
									if (xdocument != null)
									{
										num = (short)1609039875;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_622;
								case 3:
									goto IL_5EF;
								}
								goto IL_448;
								IL_5EF:
								string text3;
								enumerator = xdocument.Elements(text3).GetEnumerator();
								num = (short)1860370433;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_622:
								num = (short)1891762176;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_63A:
							goto IL_6A8;
							IL_448:
							global::System.IO.MemoryStream memoryStream;
							xdocument = global::System.Xml.Linq.XDocument.Load(global::System.Xml.XmlReader.Create(memoryStream), global::System.Xml.Linq.LoadOptions.None);
							num = (short)1185415170;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_431;
						}
						finally
						{
							num = (short)80281602;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.IO.MemoryStream memoryStream;
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)1241317377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_6A5;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_66E;
									}
									continue;
								}
								IL_66E:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)1234305024;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6A5:;
						}
						IL_6A8:
						num = (short)568655884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_766:
						num = (short)323813384;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_780:;
				}
				catch
				{
					result = string.Empty;
				}
				finally
				{
					num = (short)553582594;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							hmacsha.Dispose();
							num = (short)1786839041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_7F7;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_7BE;
							}
							continue;
						}
						IL_7BE:
						if (hmacsha == null)
						{
							break;
						}
						num = (short)1240465408;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_7F7:;
				}
				num = (short)185794560;
				short num5 = num;
				return result;
			}
			}
		}

		// Token: 0x02000019 RID: 25
		public class NativeMethods
		{
			// Token: 0x06000053 RID: 83
			[global::System.Runtime.InteropServices.DllImport("kernel32.Dll")]
			private static extern short GetVersionEx(ref global::Motorola.Security.SamlCommonUtility.OSVERSIONINFO A_0);

			// Token: 0x06000054 RID: 84 RVA: 0x000077AC File Offset: 0x000059AC
			public static int GetServicePackLevel()
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.Security.SamlCommonUtility.OSVERSIONINFO osversioninfo;
				int result;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_116;
					case 1:
					{
						num2 = (short)364249088;
						short num3 = num2;
						if (!string.IsNullOrWhiteSpace(osversioninfo.szCSDVersion))
						{
							num2 = (short)1852440578;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					case 2:
					{
						num2 = (short)1359752760;
						short num4 = num2;
						num2 = (short)1462382136;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
							num2 = (short)43974656;
							if (num2 != 0)
							{
							}
							result = (int)osversioninfo.wServicePackMajor;
							num2 = (short)224985088;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
				}
				IL_116:
				num2 = (short)22609921;
				if (num2 != 0)
				{
				}
				return result;
				IL_1C:
				result = 0;
				osversioninfo = default(global::Motorola.Security.SamlCommonUtility.OSVERSIONINFO);
				osversioninfo.dwOSVersionInfoSize = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Security.SamlCommonUtility.OSVERSIONINFO));
				global::Motorola.Security.SamlCommonUtility.OSUtility.NativeMethods.GetVersionEx(ref osversioninfo);
				num2 = (short)1034813441;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}
	}
}
