using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using Motorola.Common.CustomException;

namespace commonLicensing
{
	// Token: 0x0200000A RID: 10
	public class HostID
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00005F10 File Offset: 0x00004110
		public static string getNewHostID(string AppType)
		{
			int a_ = 4;
			string result = string.Empty;
			short num;
			try
			{
				num = (short)1210187777;
				if (num != 0)
				{
				}
				string empty = string.Empty;
				string a_2 = string.Empty;
				string a_3 = string.Empty;
				a_2 = global::commonLicensing.HostIDStoreEncrypt.getBIOSSerialNumber();
				a_3 = global::commonLicensing.HostIDStoreEncrypt.getUUID();
				result = global::commonLicensing.HostID.c(global::commonLicensing.HostID.GetBootDiskSerial(AppType), a_2, a_3);
			}
			catch (global::System.Exception ex)
			{
				if (!(ex.Message == global::commonLicensing.HostIDStoreInstaller.b("햒\udb94튖욘\udd9a\udc9c횞怜ﺰﺶﶸ黀郂胄闆鿈車鿌郎蓐鷒鳔駖諘迚鳜鏞균", a_)))
				{
					if (!(ex.Message == global::commonLicensing.HostIDStoreInstaller.b("햒\udb94튖욘\udd9a\udc9c횞怜ﺰﺶﶸﲾ鏀鳂郄视胈藊黌鯎郐鿒駔", a_)))
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GETHOSTID);
					}
					num = (short)466263375;
					short num2 = num;
					num = (short)783654223;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1702821888;
						if (num != 0)
						{
						}
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GETHOSTID_PCR_UNINSTALL);
					}
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GETHOSTID_RM_SERVER_UNINSTALL);
			}
			num = (short)1784741888;
			short num3 = num;
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00006068 File Offset: 0x00004268
		private static string c(string A_0, string A_1, string A_2)
		{
			string text;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_90;
				}
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)329965570;
					short num2 = num;
					num = (short)688644098;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)410976257;
						if (num != 0)
						{
						}
						num = (short)1058406400;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (text.Length > 99)
							{
								num = (short)213385219;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)178716674;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_13F;
						case 2:
							goto IL_FC;
						case 3:
						{
							num = (short)1703084032;
							short num4 = num;
							num = (short)1610416129;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_90;
					}
				}
				IL_90:
				string empty = string.Empty;
				text = string.Empty;
				text = global::commonLicensing.HostID.a(global::commonLicensing.HostID.a(A_0, A_1, A_2));
				num = (short)1826226176;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			IL_FC:
			string text2 = text;
			goto IL_14A;
			IL_13F:
			text2 = text.Substring(0, 99);
			IL_14A:
			text = text2;
			text += global::commonLicensing.HostID.b(A_0, A_1, A_2);
			return text;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000061D0 File Offset: 0x000043D0
		public static string CalculateLegacyHostID(string AppType)
		{
			int a_ = 5;
			short num = (short)1690697728;
			short num2 = num;
			num = (short)179603604;
			short num3 = num;
			num = (short)1459718292;
			string result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)881590273;
				if (num != 0)
				{
				}
				num = (short)1238368256;
				if (num != 0)
				{
				}
				num = (short)1761607680;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					string empty = string.Empty;
					string str = global::commonLicensing.HostIDStoreInstaller.b("", a_);
					string propertyName = global::commonLicensing.HostIDStoreInstaller.b("쒓蓮鍊펟춡횣첧", a_);
					string text = string.Empty;
					string text2 = string.Empty;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_121;
						}
						global::System.Collections.Generic.List<string> list;
						global::System.Management.ManagementObjectSearcher managementObjectSearcher;
						for (;;)
						{
							IL_102:
							int num5;
							switch (num4)
							{
							case 0:
								goto IL_15C;
							case 1:
								if (num5 >= list.Count)
								{
									num = (short)1217855493;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_413;
							case 2:
								try
								{
									global::System.Management.ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
									try
									{
										global::System.Management.ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection.GetEnumerator();
										try
										{
											num = (short)1283588096;
											num4 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num4)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_1F5;
													}
													continue;
												case 1:
													num = (short)2102394882;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													goto IL_2BF;
												case 4:
												{
													global::System.Management.ManagementObject managementObject;
													list.Add(managementObject[propertyName].ToString());
													num = (short)1003814915;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 5:
												{
													if (!enumerator.MoveNext())
													{
														num = (short)1309081601;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::System.Management.ManagementObject managementObject = (global::System.Management.ManagementObject)enumerator.Current;
													num = (short)1326055430;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 6:
												{
													global::System.Management.ManagementObject managementObject;
													if (managementObject[propertyName] != null)
													{
														num = (short)48431108;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												}
												IL_26B:
												num = (short)463994885;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_1F5:
												goto IL_26B;
											}
											IL_2BF:;
										}
										finally
										{
											num = (short)25165824;
											num4 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num4)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_2F3;
													}
													continue;
												case 1:
													goto IL_32B;
												case 2:
													((global::System.IDisposable)enumerator).Dispose();
													num = (short)681639937;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_2F3:
												if (enumerator == null)
												{
													break;
												}
												num = (short)177209346;
												num4 = (int)((global::System.IntPtr)num);
											}
											IL_32B:;
										}
									}
									finally
									{
										num = (short)405864448;
										num4 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num4)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_363;
												}
												continue;
											case 1:
												goto IL_39E;
											case 2:
												((global::System.IDisposable)managementObjectCollection).Dispose();
												num = (short)1956773889;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_363:
											if (managementObjectCollection == null)
											{
												break;
											}
											num = (short)2144075778;
											num4 = (int)((global::System.IntPtr)num);
										}
										IL_39E:;
									}
									goto IL_448;
								}
								finally
								{
									num = (short)814219264;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_3D8;
											}
											continue;
										case 1:
											goto IL_410;
										case 2:
											((global::System.IDisposable)managementObjectSearcher).Dispose();
											num = (short)1888550913;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_3D8:
										if (managementObjectSearcher == null)
										{
											break;
										}
										num = (short)373555202;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_410:;
								}
								goto IL_413;
								IL_448:
								list.Sort();
								num5 = 0;
								num = (short)326107136;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_49D;
							case 4:
								goto IL_15C;
							case 5:
								result = text2.Trim() + str + text.Trim();
								num = (short)1921318915;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_121;
							IL_15C:
							num = (short)1530200065;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_413:
							text += list[num5];
							num5++;
							num = (short)323158020;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_49D:
						break;
						IL_121:
						text2 = global::commonLicensing.HostID.GetBootDiskSerial(AppType);
						list = new global::System.Collections.Generic.List<string>();
						managementObjectSearcher = new global::System.Management.ManagementObjectSearcher(global::commonLicensing.HostIDStoreInstaller.b("잓ﾙﾛ肟袡蒣삥\udaa7얩솫躭\udbb1\udab3薵誷첽꾿ꇁꇃ뗅믇ꗉ뻋", a_));
						num = (short)1711996930;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_102;
					}
					catch (global::System.Exception ex)
					{
						if (ex.Message == global::commonLicensing.HostIDStoreInstaller.b("튓\ud895\udd97얙\uda9b\udf9d節ﶱﺹ趿鷁韃菅髇鳉觋鳍迏蟑髓鿕雗觙裛鿝곟껡", a_))
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GETHOSTID_RM_SERVER_UNINSTALL);
						}
						if (ex.Message == global::commonLicensing.HostIDStoreInstaller.b("튓\ud895\udd97얙\uda9b\udf9d節ﶱﺹ莿郁鯃鏅蛇菉苋鷍蓏鏑飓髕", a_))
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GETHOSTID_PCR_UNINSTALL);
						}
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GETHOSTID);
					}
					break;
				}
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00006744 File Offset: 0x00004944
		public static string GetBootDiskSerial(string AppType)
		{
			int a_ = 7;
			short num = (short)1519255552;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5C;
				}
				global::System.Xml.Linq.XDocument xdocument;
				string text;
				string text2;
				string text3;
				string text4;
				string text5;
				string text6;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
					switch (num2)
					{
					case 0:
						if (xdocument != null)
						{
							num = (short)46792709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FF;
					case 1:
						try
						{
							num = (short)1140654081;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1602486276;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.Linq.XElement xelement = enumerator.Current;
									text = xelement.Element(global::commonLicensing.HostIDStoreInstaller.b("풕춝얟킡춣장쒧\ud9ab쎭튯ힱ욳", a_)).Value;
									text2 = xelement.Element(global::commonLicensing.HostIDStoreInstaller.b("쎕춗펙\ud89b", a_)).Value;
									text3 = xelement.Element(global::commonLicensing.HostIDStoreInstaller.b("풕톗햙쾛춝얟킡춣장쒧\ud9ab쎭튯ힱ욳", a_)).Value;
									num = (short)1353777154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1C0;
									}
									continue;
								case 3:
									goto IL_297;
								case 4:
									num = (short)401604611;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1C2:
								num = (short)617545728;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C0:
								goto IL_1C2;
							}
							IL_297:
							goto IL_144;
						}
						finally
						{
							num = (short)973144064;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2CF;
									}
									continue;
								case 1:
									goto IL_308;
								case 2:
									enumerator.Dispose();
									num = (short)347078657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2CF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2040135682;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_308:;
						}
						goto IL_30B;
						IL_144:
						num = (short)1293877254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_3FD;
					case 3:
						if (text4 == text2)
						{
							num = (short)801832968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30B;
					case 4:
						goto IL_32A;
					case 5:
						goto IL_32F;
					case 6:
						if (text5 == text3)
						{
							num = (short)496107527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30B;
					case 7:
						num = (short)1553989633;
						if (num != 0)
						{
						}
						num = (short)822214659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)1393947439;
						short num3 = num;
						num = (short)668005167;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32F;
						default:
						{
							num = (short)1717633024;
							if (num != 0)
							{
							}
							text6 = text;
							num = (short)819920896;
							short num4 = num;
							num = (short)128647170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					goto IL_5C;
					IL_30B:
					global::commonLicensing.HostID.d(AppType);
					num = (short)1904345092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32F:
					enumerator = xdocument.Elements(global::commonLicensing.HostIDStoreInstaller.b("\ude95힝쪣삥잧\ud8a9솫쾭쒯\udbb1\udbb3\ud8b5", a_)).GetEnumerator();
					num = (short)303890433;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_32A:
				IL_3FD:
				IL_3FF:
				return text6.Trim();
				IL_5C:
				text6 = string.Empty;
				text3 = string.Empty;
				text2 = string.Empty;
				text = string.Empty;
				text5 = string.Empty;
				text4 = string.Empty;
				text5 = global::commonLicensing.HostIDStoreEncrypt.getBIOSSerialNumber();
				text4 = global::commonLicensing.HostIDStoreEncrypt.getUUID();
				global::commonLicensing.HostIDStoreEncrypt.setHostIDStoreLoc(AppType);
				xdocument = global::commonLicensing.HostID.b();
				num = (short)519897088;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00006B74 File Offset: 0x00004D74
		private static void d(string A_0)
		{
			int a_ = 2;
			short num = (short)446496768;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1316884403;
					short num3 = num;
					num = (short)1996885939;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_154;
					default:
						num = (short)916127744;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					}
					break;
				}
				case 1:
					goto IL_154;
				case 2:
					num = (short)1163657217;
					if (num != 0)
					{
					}
					if (A_0 == global::commonLicensing.HostIDStoreInstaller.b("\udc90\udc92솔\ud896춘즚\udf9c킞ﺠ", a_))
					{
						num = (short)2039087105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_156;
				case 3:
				{
					num = (short)64290816;
					short num4 = num;
					num = (short)171900930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_86:
				if (A_0 == global::commonLicensing.HostIDStoreInstaller.b("\udc90\udc92솔\ud896춘즚\udf9c킞ﺠ", a_))
				{
					break;
				}
				num = (short)417595395;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DC:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GETHOSTID_PCR_UNINSTALL);
			IL_154:
			goto IL_DC;
			IL_156:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GETHOSTID_RM_SERVER_UNINSTALL);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00006CE4 File Offset: 0x00004EE4
		private static global::System.Xml.Linq.XDocument b()
		{
			global::System.Xml.Linq.XDocument result = new global::System.Xml.Linq.XDocument();
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::commonLicensing.HostID.a());
			short num;
			try
			{
				result = global::System.Xml.Linq.XDocument.Load(global::System.Xml.XmlReader.Create(memoryStream), global::System.Xml.Linq.LoadOptions.None);
			}
			finally
			{
				num = (short)1167261697;
				if (num != 0)
				{
				}
				num = (short)1773734866;
				short num2 = num;
				num = (short)1683164114;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_E9:
					num = (short)576192513;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1362362368;
					if (num != 0)
					{
					}
					num = (short)1739128832;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_C9;
						}
						continue;
					case 1:
						goto IL_FD;
					case 2:
						goto IL_E1;
					}
					IL_C9:
					if (memoryStream == null)
					{
						goto IL_FF;
					}
					num = (short)714145794;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_E1:
				((global::System.IDisposable)memoryStream).Dispose();
				goto IL_E9;
				IL_FD:
				IL_FF:;
			}
			num = (short)1047003136;
			short num4 = num;
			return result;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00006E2C File Offset: 0x0000502C
		private static byte[] a()
		{
			int a_ = 8;
			short num = (short)2016935936;
			short num2 = num;
			num = (short)1324856813;
			short num3 = num;
			num = (short)1785771501;
			byte[] array;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)744161280;
				if (num != 0)
				{
				}
				array = null;
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(global::commonLicensing.HostIDStoreEncrypt.getHostIDStoreLoc(), global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				try
				{
					num = (short)818741249;
					if (num != 0)
					{
					}
					array = new byte[fileStream.Length];
					fileStream.Read(array, 0, (int)fileStream.Length);
				}
				finally
				{
					num = (short)885063681;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)1579745282;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_102;
							}
							continue;
						case 2:
							goto IL_137;
						}
						IL_102:
						if (fileStream == null)
						{
							break;
						}
						num = (short)190513152;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_137:;
				}
				break;
			}
			}
			return global::System.Security.Cryptography.ProtectedData.Unprotect(array, global::System.Text.Encoding.UTF8.GetBytes(global::commonLicensing.HostIDStoreInstaller.b("\udf96횞쮤솦욨\ud9aa사캮얰\udab2\udab4\ud9b6﮸풺튼쮾鋀ꛂ럄껆꣈ꟊ菌뫎볐뇒냔ꗖ", a_)), global::System.Security.Cryptography.DataProtectionScope.LocalMachine);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00006FA4 File Offset: 0x000051A4
		private static string c(string A_0)
		{
			int a_ = 1;
			short num = (short)1325596673;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_79;
			}
			int num3;
			string text;
			for (;;)
			{
				IL_39:
				num = (short)1294467072;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)1968382152;
					short num4 = num;
					num = (short)1545609416;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)458489856;
						if (num != 0)
						{
						}
						if (!string.IsNullOrWhiteSpace(A_0))
						{
							num = (short)313524226;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_156;
					}
					break;
				}
				case 1:
					if (!string.IsNullOrWhiteSpace(text))
					{
						num = (short)137035779;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_156;
				case 2:
					text = global::System.Text.RegularExpressions.Regex.Replace(A_0, global::commonLicensing.HostIDStoreInstaller.b("쮏첑좓쒗뒙몛슝蒟螣鲥薧", a_), string.Empty);
					num = (short)659881985;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return text;
				}
				goto IL_79;
			}
			return text;
			IL_156:
			return string.Empty;
			IL_79:
			text = string.Empty;
			num = (short)135200768;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_39;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000710C File Offset: 0x0000530C
		private static string b(string A_0, string A_1, string A_2)
		{
			int a_ = 0;
			short num = (short)1880555520;
			short num2 = num;
			num = (short)289548545;
			short num3 = num;
			num = (short)1345661185;
			switch (num3 == num)
			{
			}
			num = (short)486408193;
			if (num != 0)
			{
			}
			num = (short)322895872;
			if (num != 0)
			{
			}
			string empty = string.Empty;
			return global::System.Convert.ToInt32(global::commonLicensing.HostIDStoreInstaller.b("뾎", a_) + global::commonLicensing.HostID.b(A_0).ToString(global::System.Globalization.CultureInfo.InvariantCulture) + global::commonLicensing.HostID.b(A_1).ToString(global::System.Globalization.CultureInfo.InvariantCulture) + global::commonLicensing.HostID.b(A_2).ToString(global::System.Globalization.CultureInfo.InvariantCulture), 2).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00007224 File Offset: 0x00005424
		private static int b(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_B8;
			}
			short num;
			int num4;
			int result;
			for (;;)
			{
				IL_0A:
				num = (short)302004466;
				short num2 = num;
				num = (short)378419442;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)288882688;
					short num3 = num;
					num = (short)1240924160;
					if (num != 0)
					{
					}
					num = (short)634912769;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						goto IL_F9;
					case 1:
						if (!string.IsNullOrWhiteSpace(global::commonLicensing.HostID.c(A_0)))
						{
							num = (short)1742864384;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						return result;
					}
					goto IL_B8;
				}
				}
				IL_F9:
				result = 1;
				num = (short)370343938;
				num4 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_B8:
			result = 0;
			num = (short)329515009;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00007348 File Offset: 0x00005548
		private static string a(string A_0, string A_1, string A_2)
		{
			short num = (short)17170432;
			short num2 = num;
			num = (short)818872321;
			if (num != 0)
			{
			}
			num = (short)233482887;
			short num3 = num;
			num = (short)791849607;
			switch (num3 == num)
			{
			}
			num = (short)42074112;
			if (num != 0)
			{
			}
			return string.Empty + global::commonLicensing.HostID.c(A_0) + global::commonLicensing.HostID.c(A_1) + global::commonLicensing.HostID.c(A_2);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00007418 File Offset: 0x00005618
		private static string a(string A_0)
		{
			short num;
			string result;
			try
			{
				num = (short)1460011008;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					int num6;
					for (;;)
					{
						IL_27:
						int num5;
						switch (num2)
						{
						case 0:
							goto IL_209;
						case 1:
							goto IL_15F;
						case 2:
							goto IL_90;
						case 3:
						{
							int num3;
							num3++;
							int num4 = num3;
							num = (short)346161156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_95;
						case 5:
						{
							if (A_0.Length < 5)
							{
								num = (short)825491458;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
							int num4 = 0;
							int num3 = 0;
							num5 = 0;
							num = (short)1154351113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							IL_178:
							if (num5 >= A_0.Length)
							{
								num = (short)468254727;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num4;
							global::System.Text.StringBuilder stringBuilder;
							stringBuilder.Append(A_0.Substring(num4, 1));
							num4 += num6;
							num = (short)843776008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::System.Text.StringBuilder stringBuilder;
							result = stringBuilder.ToString();
							num = (short)791805952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							int num4;
							if (num4 >= A_0.Length)
							{
								num = (short)1302528003;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_95;
						}
						case 9:
							goto IL_15F;
						}
						goto IL_56;
						IL_95:
						num5++;
						num = (short)239949719;
						short num7 = num;
						num = (short)182671255;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_178;
						default:
							num = (short)1388249088;
							if (num != 0)
							{
							}
							num = (short)380698625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_15F:
						num = (short)1371275270;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_90:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GETHOSTID);
					IL_209:
					break;
					IL_56:
					num6 = 5;
					num = (short)1954414597;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GETHOSTID);
			}
			num = (short)209125376;
			short num8 = num;
			num = (short)1274871809;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x04000028 RID: 40
		private const string a = "HostIDInformation";

		// Token: 0x04000029 RID: 41
		private const string b = "BootSerialNumber";

		// Token: 0x0400002A RID: 42
		private const string c = "BIOSSerialNumber";

		// Token: 0x0400002B RID: 43
		private const string d = "UUID";

		// Token: 0x0400002C RID: 44
		private const string e = "NewHostID";

		// Token: 0x0400002D RID: 45
		private const int f = 99;
	}
}
