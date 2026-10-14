using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using AcpUtility;
using Motorola.Common.Communication.CommonUtil.Extensions;
using Motorola.Common.CustomException;

// Token: 0x02000003 RID: 3
internal class b
{
	// Token: 0x06000004 RID: 4 RVA: 0x000021BC File Offset: 0x000003BC
	public static void a(string A_0, global::b.b A_1, ref string A_2)
	{
		int a_ = 6;
		short num;
		try
		{
			num = (short)202768384;
			switch (num)
			{
			default:
			{
				num = (short)703725574;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate;
					byte[] rgbHash;
					int num3;
					switch (num2)
					{
					case 0:
					{
						byte[] value;
						string text;
						try
						{
							global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = (global::System.Security.Cryptography.RSACryptoServiceProvider)x509Certificate.PrivateKey;
							value = rsacryptoServiceProvider.SignHash(rgbHash, null);
							text = rsacryptoServiceProvider.ToXmlString(false);
							goto IL_2F9;
						}
						finally
						{
							num = (short)1577648130;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1BA;
								case 1:
									((global::System.IDisposable)x509Certificate).Dispose();
									num = (short)1815150592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_181;
									}
									continue;
								}
								IL_181:
								if (x509Certificate == null)
								{
									break;
								}
								num = (short)525139969;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1BA:;
						}
						goto Block_6;
						IL_2F9:
						string text2 = global::System.BitConverter.ToString(value);
						string text3 = global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㘉娋䬍䈏䄑崓夕嘗␙ⴛ〝ဟḡଣ瀥洧砩缫札缯簱ਲ਼", a_);
						string text4 = global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㘉䠋䜍圏圑䜓䈕☗", a_) + text2.Replace(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("✉", a_), "") + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㘉⌋䨍夏唑儓䔕䰗␙", a_);
						A_2 = string.Concat(new string[]
						{
							A_2,
							global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㘉弋䜍圏少唓䈕䴗䠙夛”", a_),
							text3,
							text4,
							text,
							global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㘉⌋崍夏唑娓圕䰗伙丛嬝ḟ", a_)
						});
						num = (short)710279171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1615659013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1BD;
					case 3:
						goto IL_3AB;
					case 4:
						goto IL_127;
					case 5:
						if (num3 != -1)
						{
							num = (short)718864388;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29B;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					}
					IL_69:
					int num4 = A_2.IndexOf(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㘉弋䜍圏少唓䈕䴗䠙夛”", a_), global::System.StringComparison.Ordinal);
					num3 = A_2.IndexOf(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㘉⌋崍夏唑娓圕䰗伙丛嬝ḟ", a_), global::System.StringComparison.Ordinal);
					if (num4 != -1)
					{
						num = (short)277151745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29B;
					Block_6:
					global::System.Security.Cryptography.SHA1Managed sha1Managed;
					try
					{
						IL_1BD:
						byte[] bytes = new global::System.Text.UnicodeEncoding().GetBytes(A_2);
						rgbHash = sha1Managed.ComputeHash(bytes);
						goto IL_B3;
					}
					finally
					{
						num = (short)1193410562;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_298;
							case 1:
							{
								num = (short)1564498423;
								short num5 = num;
								num = (short)57760247;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)150208512;
									if (num != 0)
									{
									}
									((global::System.IDisposable)sha1Managed).Dispose();
									break;
								}
								num = (short)1167589376;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_20F;
								}
								continue;
							}
							IL_20F:
							if (sha1Managed == null)
							{
								break;
							}
							num = (short)1041694721;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_298:;
					}
					goto IL_29B;
					IL_B3:
					string str;
					string text5;
					x509Certificate = new global::System.Security.Cryptography.X509Certificates.X509Certificate2(A_0 + str, text5);
					num = (short)1695744000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29B:
					str = global::b.ab[(int)A_1];
					text5 = global::b.ac[(int)A_1];
					byte[] bytes2 = global::System.Convert.FromBase64String(text5 + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㜉ㄋ", a_));
					text5 = global::System.Text.Encoding.ASCII.GetString(bytes2);
					rgbHash = null;
					sha1Managed = new global::System.Security.Cryptography.SHA1Managed();
					num = (short)437452802;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_127:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("変攋植縏猑怓挕樗缙㰛缝䰟倡䄣䜥䰧匩ఫ䬭䠯嬱䜳䈵䬷", a_));
				IL_3AB:
				break;
			}
			}
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
		num = (short)2030567425;
		if (num != 0)
		{
		}
		num = (short)1899429888;
		short num6 = num;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002618 File Offset: 0x00000818
	public static global::b.c a(global::b.b A_0, ref string A_1)
	{
		int a_ = 1;
		short num = (short)1961754624;
		int num2 = (int)num;
		switch (num2)
		{
		default:
		{
			num = (short)110034945;
			if (num != 0)
			{
			}
			global::b.c result = global::b.c.b;
			try
			{
				int num3;
				int num4;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_5B:
						string text;
						byte[] array;
						int num5;
						switch (num2)
						{
						case 0:
							if (num3 != -1)
							{
								num = (short)820051972;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_51E;
						case 1:
							if (num4 != -1)
							{
								num = (short)1804140556;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_51E;
						case 2:
							try
							{
								byte[] bytes = new global::System.Text.UnicodeEncoding().GetBytes(A_1);
								global::System.Security.Cryptography.SHA1Managed sha1Managed;
								byte[] rgbHash = sha1Managed.ComputeHash(bytes);
								goto IL_28C;
							}
							finally
							{
								num = (short)1347878914;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Security.Cryptography.SHA1Managed sha1Managed;
									switch (num2)
									{
									case 0:
										goto IL_4DD;
									case 1:
										((global::System.IDisposable)sha1Managed).Dispose();
										num = (short)1372258304;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_4A4;
										}
										continue;
									}
									IL_4A4:
									if (sha1Managed == null)
									{
										break;
									}
									num = (short)1038417921;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_4DD:;
							}
							goto IL_4E0;
							IL_28C:
							array = new byte[text.Length / 2];
							num5 = 0;
							num = (short)1939275783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							string xmlString;
							if (xmlString != global::b.ad[(int)A_0])
							{
								num = (short)417857542;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_1 = A_1.Remove(num4);
							byte[] rgbHash = null;
							global::System.Security.Cryptography.SHA1Managed sha1Managed = new global::System.Security.Cryptography.SHA1Managed();
							num = (short)1848901634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							int num6 = A_1.IndexOf(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㤄䌆䀈䰊䠌導䔐ⴒ", a_), global::System.StringComparison.Ordinal);
							int num7 = A_1.IndexOf(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㤄⠆䴈䈊䨌䨎䈐䜒⬔", a_), global::System.StringComparison.Ordinal);
							int num8 = num6 + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㤄䌆䀈䰊䠌導䔐ⴒ", a_).Length;
							int length = num7 - num8;
							text = A_1.Substring(num8, length);
							num8 = num7 + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㤄⠆䴈䈊䨌䨎䈐䜒⬔", a_).Length;
							length = num3 - num8;
							string xmlString = A_1.Substring(num8, length);
							num = (short)1497759747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							if (num5 >= array.Length)
							{
								num = (short)169738251;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_419;
						case 6:
							goto IL_1FC;
						case 7:
							goto IL_201;
						case 8:
							goto IL_536;
						case 9:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_312;
								}
								global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
								for (;;)
								{
									IL_2F7:
									switch (num2)
									{
									case 0:
										result = global::b.c.c;
										num = (short)465108995;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_3A6;
									case 2:
										goto IL_38E;
									case 3:
										goto IL_38E;
									case 4:
									{
										byte[] rgbHash;
										if (rsacryptoServiceProvider.VerifyHash(rgbHash, null, array))
										{
											num = (short)1747517440;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										result = global::b.c.a;
										num = (short)833617922;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_312;
									IL_38E:
									num = (short)822607873;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3A6:
								goto IL_51E;
								IL_312:
								string xmlString;
								rsacryptoServiceProvider.FromXmlString(xmlString);
								num = (short)1835991044;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_2F7;
							}
							finally
							{
								num = (short)1264451586;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
									switch (num2)
									{
									case 0:
										goto IL_416;
									case 1:
										((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
										num = (short)1080754176;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_3DD;
										}
										continue;
									}
									IL_3DD:
									if (rsacryptoServiceProvider == null)
									{
										break;
									}
									num = (short)1910833153;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_416:;
							}
							goto IL_419;
						case 10:
							goto IL_201;
						case 11:
						{
							num = (short)1754707527;
							short num9 = num;
							num = (short)1346090567;
							switch ((num9 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_C4;
							default:
							{
								num = (short)785186816;
								if (num != 0)
								{
								}
								global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider();
								num = (short)1015742473;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 12:
							goto IL_4E0;
						}
						goto IL_96;
						IL_201:
						num = (short)1381433349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_419:
						array[num5] = global::System.Convert.ToByte(text.Substring(num5 * 2, 2), 16);
						num5++;
						num = (short)1180893194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4E0:
						num = (short)1179189248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_51E:
						num = (short)1773862920;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1FC:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("嘄渆済攊氌笎搐愒瀔㜖眘琚検㼞䜠䰢値䤦䴨", a_));
					IL_536:
					goto IL_539;
				}
				IL_96:
				num4 = A_1.IndexOf(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㤄吆䀈䰊䌌与䔐䘒䜔刖✘", a_), global::System.StringComparison.Ordinal);
				num3 = A_1.IndexOf(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㤄⠆娈䈊䨌䄎倐䜒䀔䔖尘┚", a_), global::System.StringComparison.Ordinal);
				IL_C4:
				num = (short)304218113;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5B;
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			IL_539:
			num = (short)348585984;
			short num10 = num;
			return result;
		}
		}
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002BD4 File Offset: 0x00000DD4
	public static void b(string A_0, string A_1, bool A_2, global::b.a A_3)
	{
		int a_ = 15;
		short num;
		try
		{
			num = (short)1853095936;
			switch (num)
			{
			default:
			{
				num = (short)978976771;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_3F7;
					case 1:
						goto IL_11A;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_139;
							}
							global::System.IO.FileStream fileStream;
							byte[] array;
							byte[] array2;
							global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm;
							for (;;)
							{
								IL_126:
								switch (num2)
								{
								case 0:
									goto IL_347;
								case 1:
									goto IL_21C;
								case 2:
								{
									try
									{
										array = new byte[fileStream.Length];
										fileStream.Read(array, 0, array.Length);
										goto IL_1A1;
									}
									finally
									{
										num = (short)1323696130;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_2AD;
											case 1:
												((global::System.IDisposable)fileStream).Dispose();
												num = (short)1939210240;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_273;
												}
												continue;
											}
											IL_273:
											if (fileStream == null)
											{
												break;
											}
											num = (short)903806977;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2AD:;
									}
									goto Block_8;
									IL_1A1:
									num = (short)533789839;
									short num3 = num;
									num = (short)1655241871;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_21C;
									default:
									{
										num = (short)1985347584;
										if (num != 0)
										{
										}
										global::b.a(array, ref array2, A_2, symmetricAlgorithm.CreateEncryptor());
										global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
										num = (short)420872193;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								}
								goto IL_139;
								Block_8:
								try
								{
									IL_2B0:
									global::System.IO.FileStream fileStream2;
									fileStream2.Write(array2, 0, array2.Length);
								}
								finally
								{
									num = (short)664731650;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.IO.FileStream fileStream2;
										switch (num2)
										{
										case 0:
											goto IL_32B;
										case 1:
											((global::System.IDisposable)fileStream2).Dispose();
											num = (short)101384192;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_2F3;
											}
											continue;
										}
										IL_2F3:
										if (fileStream2 == null)
										{
											break;
										}
										num = (short)69664769;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_32B:;
								}
								num = (short)1848836096;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_21C:
								goto IL_2B0;
							}
							IL_347:
							goto IL_3FC;
							IL_139:
							string str;
							symmetricAlgorithm.Key = global::System.Convert.FromBase64String(str + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⸒", a_));
							string str2;
							symmetricAlgorithm.IV = global::System.Convert.FromBase64String(str2 + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⸒⠔", a_));
							array = null;
							array2 = null;
							fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
							num = (short)589103106;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_126;
						}
						finally
						{
							num = (short)1688862722;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm;
								switch (num2)
								{
								case 0:
									goto IL_3B3;
								case 1:
									((global::System.IDisposable)symmetricAlgorithm).Dispose();
									num = (short)479330304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_37E;
									}
									continue;
								}
								IL_37E:
								if (symmetricAlgorithm == null)
								{
									break;
								}
								num = (short)1487208449;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3B3:;
						}
						goto IL_3B6;
						IL_3FC:
						num = (short)1988296708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_6F;
						}
						continue;
					case 4:
						goto IL_414;
					case 5:
					{
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = (short)901578752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string str;
						string str2;
						global::b.a(A_3, out str, out str2);
						global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = global::System.Security.Cryptography.Aes.Create();
						num = (short)267059202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (string.IsNullOrEmpty(A_1))
						{
							num = (short)398917633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B6;
					case 7:
						num = (short)1689780230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6F:
					if (!string.IsNullOrEmpty(A_0))
					{
						num = (short)614596615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_3B6:
					num = (short)524353541;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CB:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀒簔瀖眘稚検樞匠䘢Ԥ䘦䔨太䠬丮唰䨲ᔴ制䄸刺丼䬾㉀", a_));
				IL_11A:
				goto IL_CB;
				IL_3F7:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀒簔瀖眘稚検樞匠䘢Ԥ䘦䔨太䠬丮唰䨲ᔴ制䄸刺丼䬾㉀", a_));
				IL_414:
				break;
			}
			}
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
		num = (short)1879441409;
		if (num != 0)
		{
		}
		num = (short)1294139392;
		short num4 = num;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000030AC File Offset: 0x000012AC
	public static void b(byte[] A_0, ref byte[] A_1, bool A_2, global::b.a A_3)
	{
		int a_ = 17;
		short num;
		try
		{
			num = (short)1486553088;
			switch (num)
			{
			default:
			{
				string str;
				string str2;
				global::b.a(A_3, out str, out str2);
				global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = global::System.Security.Cryptography.Aes.Create();
				try
				{
					num = (short)837615617;
					if (num != 0)
					{
					}
					symmetricAlgorithm.Key = global::System.Convert.FromBase64String(str + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⠔", a_));
					symmetricAlgorithm.IV = global::System.Convert.FromBase64String(str2 + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⠔⨖", a_));
					byte[] array = new byte[A_0.Length + 3];
					array[0] = 239;
					array[1] = 187;
					array[2] = 191;
					global::System.Array.Copy(A_0, 0, array, 3, A_0.Length);
					global::b.a(array, ref A_1, A_2, symmetricAlgorithm.CreateEncryptor());
				}
				finally
				{
					num = (short)1239678978;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_19A;
						case 1:
						{
							num = (short)1715679972;
							short num3 = num;
							num = (short)2027041508;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)2082144256;
								if (num != 0)
								{
								}
								((global::System.IDisposable)symmetricAlgorithm).Dispose();
								break;
							}
							num = (short)361431040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_113;
							}
							continue;
						}
						IL_113:
						if (symmetricAlgorithm == null)
						{
							break;
						}
						num = (short)863567873;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_19A:;
				}
				break;
			}
			}
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
		num = (short)992083968;
		short num4 = num;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000032B8 File Offset: 0x000014B8
	public static void b(string A_0, ref string A_1, bool A_2, global::b.a A_3)
	{
		int a_ = 6;
		short num;
		try
		{
			num = (short)1368784896;
			switch (num)
			{
			default:
			{
				num = (short)1482817536;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_68;
						}
						continue;
					case 1:
					{
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = (short)2127626242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string str;
						string str2;
						global::b.a(A_3, out str, out str2);
						global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = global::System.Security.Cryptography.Aes.Create();
						num = (short)1569914884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_2CA;
					case 3:
						goto IL_88;
					case 4:
						try
						{
							num = (short)1320832008;
							short num3 = num;
							num = (short)44321800;
							global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm;
							byte[] array;
							byte[] bytes;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)749469696;
								if (num != 0)
								{
								}
								string str;
								symmetricAlgorithm.Key = global::System.Convert.FromBase64String(str + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㜉", a_));
								string str2;
								symmetricAlgorithm.IV = global::System.Convert.FromBase64String(str2 + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㜉ㄋ", a_));
								array = null;
								bytes = null;
								global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
								try
								{
									array = new byte[fileStream.Length + 3L];
									array[0] = 239;
									array[1] = 187;
									array[2] = 191;
									fileStream.Read(array, 3, (int)fileStream.Length);
								}
								finally
								{
									num = (short)285802496;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_198;
											}
											continue;
										case 1:
											((global::System.IDisposable)fileStream).Dispose();
											num = (short)1802633218;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_1D0;
										}
										IL_198:
										if (fileStream == null)
										{
											break;
										}
										num = (short)1961951233;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_1D0:;
								}
								break;
							}
							}
							global::b.a(array, ref bytes, A_2, symmetricAlgorithm.CreateEncryptor());
							A_1 = global::System.Text.Encoding.UTF8.GetString(bytes);
							goto IL_2FA;
						}
						finally
						{
							num = (short)1011089408;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_229;
									}
									continue;
								case 1:
									((global::System.IDisposable)symmetricAlgorithm).Dispose();
									num = (short)1621360642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_260;
								}
								IL_229:
								if (symmetricAlgorithm == null)
								{
									break;
								}
								num = (short)1560150017;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_260:;
						}
						goto IL_263;
						IL_2FA:
						num = (short)270729221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_312;
					}
					IL_68:
					if (string.IsNullOrEmpty(A_0))
					{
						num = (short)1459093507;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)458489857;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_88:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("変攋植縏猑怓挕樗缙㰛缝䰟倡䄣䜥䰧匩ఫ䬭䠯嬱䜳䈵䬷", a_));
				IL_263:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("変攋植縏猑怓挕樗缙㰛缝䰟倡䄣䜥䰧匩ఫ䬭䠯嬱䜳䈵䬷", a_));
				IL_2CA:
				goto IL_263;
				IL_312:
				break;
			}
			}
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
		num = (short)1028390912;
		short num4 = num;
		num = (short)2038497281;
		if (num != 0)
		{
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00003678 File Offset: 0x00001878
	public static void b(string A_0, string A_1, bool A_2)
	{
		int a_ = 2;
		short num;
		try
		{
			num = (short)145620993;
			if (num != 0)
			{
			}
			num = (short)1153761280;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					global::System.IO.FileStream fileStream;
					byte[] array;
					byte[] array2;
					for (;;)
					{
						IL_5E:
						switch (num2)
						{
						case 0:
							try
							{
								array = new byte[fileStream.Length];
								fileStream.Read(array, 0, array.Length);
								goto IL_224;
							}
							finally
							{
								num = (short)703839449;
								short num3 = num;
								num = (short)108969177;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_188:
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)1340604418;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)2126184448;
									if (num != 0)
									{
									}
									num = (short)897056768;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_16D;
										}
										continue;
									case 1:
										goto IL_186;
									case 2:
										goto IL_1A3;
									}
									IL_16D:
									if (fileStream == null)
									{
										goto IL_1A5;
									}
									num = (short)1879965697;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_186:
								goto IL_188;
								IL_1A3:
								IL_1A5:;
							}
							goto Block_5;
						case 1:
							goto IL_1A6;
						case 2:
							goto IL_273;
						}
						goto IL_71;
						IL_224:
						global::b.a(array, ref array2, A_2, tripleDESCryptoServiceProvider.CreateEncryptor());
						global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
						num = (short)2069757953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						Block_5:
						try
						{
							IL_1A6:
							fileStream2.Write(array2, 0, array2.Length);
							goto IL_25A;
						}
						finally
						{
							num = (short)1965293568;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1E9;
									}
									continue;
								case 1:
									((global::System.IDisposable)fileStream2).Dispose();
									num = (short)468123650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_221;
								}
								IL_1E9:
								if (fileStream2 == null)
								{
									break;
								}
								num = (short)532611073;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_221:;
						}
						goto IL_224;
						IL_25A:
						num = (short)1803550722;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_273:
					break;
					IL_71:
					tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("丅䤇尉䈋䴍䀏䄑堓䈕尗丙䤛倝攟瀡攣漥稧縩縫漭猯眱昳", a_));
					tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("倅䴇三䜋䨍娏䄑䐓", a_));
					array = null;
					array2 = null;
					fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					num = (short)402784256;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_5E;
				}
				finally
				{
					num = (short)1558708224;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_2A8;
							}
							continue;
						case 1:
							((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
							num = (short)1314652162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_2DD;
						}
						IL_2A8:
						if (tripleDESCryptoServiceProvider == null)
						{
							break;
						}
						num = (short)239403009;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2DD:;
				}
				break;
			}
			}
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
		num = (short)1632567296;
		short num4 = num;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000039F8 File Offset: 0x00001BF8
	public static void a(byte[] A_0, ref byte[] A_1)
	{
		int a_ = 17;
		short num = (short)408485888;
		short num2 = num;
		num = (short)1443758080;
		switch (num)
		{
		default:
		{
			global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
			try
			{
				tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("崔嘖优唚帜伞爠漢焤挦紨縪挬樮挰爲簴收洸椺簼簾рᅂ", a_));
				tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌔刖崘倚夜唞爠猢", a_));
				try
				{
					num = (short)1571946497;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						long num4;
						long num5;
						global::System.IO.MemoryStream memoryStream;
						byte[] buffer;
						global::System.Security.Cryptography.CryptoStream cryptoStream;
						global::System.IO.MemoryStream memoryStream2;
						switch (num3)
						{
						case 0:
							num = (short)254017538;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_DB;
							}
							continue;
						case 2:
							if (A_1 != null)
							{
								num = (short)1245577220;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_38E;
						case 3:
							goto IL_129;
						case 4:
							num = (short)428802053;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (tripleDESCryptoServiceProvider == null)
							{
								num = (short)660537347;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2FE;
						case 6:
							try
							{
								num = (short)449249281;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										if (num4 >= num5)
										{
											num = (short)1613365251;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										int num6 = memoryStream.Read(buffer, 0, 1024);
										cryptoStream.Write(buffer, 0, num6);
										num4 += (long)num6;
										num = (short)1274085378;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1A3;
										}
										continue;
									case 3:
										cryptoStream.FlushFinalBlock();
										A_1 = memoryStream2.ToArray();
										num = (short)286720004;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_28B;
									}
									IL_1DC:
									num = (short)696313887;
									short num7 = num;
									num = (short)1176627231;
									switch ((num7 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)932380672;
										if (num != 0)
										{
										}
										num = (short)972750848;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1A3:
									goto IL_1DC;
								}
								IL_28B:
								goto IL_3A2;
							}
							finally
							{
								num = (short)407306240;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_2C4;
										}
										continue;
									case 1:
										((global::System.IDisposable)cryptoStream).Dispose();
										num = (short)1759903746;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_2FB;
									}
									IL_2C4:
									if (cryptoStream == null)
									{
										break;
									}
									num = (short)1985216513;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_2FB:;
							}
							goto IL_2FE;
							IL_3A2:
							num = (short)601161735;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_3BA;
						}
						IL_DB:
						if (A_0 != null)
						{
							num = (short)1402798080;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_2FE:
						num4 = 0L;
						num5 = (long)(A_0.Length + 3);
						buffer = new byte[1024];
						byte[] array = new byte[num5];
						array[0] = 239;
						array[1] = 187;
						array[2] = 191;
						global::System.Array.Copy(A_0, 0, array, 3, A_0.Length);
						memoryStream = new global::System.IO.MemoryStream(array);
						memoryStream2 = new global::System.IO.MemoryStream();
						memoryStream2.SetLength((long)array.Length);
						cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream2, tripleDESCryptoServiceProvider.CreateEncryptor(), global::System.Security.Cryptography.CryptoStreamMode.Write);
						num = (short)1042284550;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_129:
					IL_38E:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䘔縖縘甚簜欞吠儢䀤ܦ䠨䜪弬䨮倰圲䰴᜶尸䌺吼䰾㕀あ", a_));
					IL_3BA:;
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
			}
			finally
			{
				num = (short)308805632;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3F3;
						}
						continue;
					case 1:
						((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
						num = (short)1951006722;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_452;
					}
					IL_3F3:
					num = (short)197918721;
					if (num != 0)
					{
					}
					if (tripleDESCryptoServiceProvider == null)
					{
						break;
					}
					num = (short)51904513;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_452:;
			}
			return;
		}
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00003EA8 File Offset: 0x000020A8
	public static void a(string A_0, string A_1, bool A_2, global::b.a A_3)
	{
		int a_ = 17;
		short num;
		try
		{
			num = (short)552665088;
			switch (num)
			{
			default:
			{
				num = (short)1970798593;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)982450179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					case 2:
						goto IL_118;
					case 3:
						if (string.IsNullOrEmpty(A_1))
						{
							num = (short)2118254594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36B;
					case 4:
					{
						if (global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							string str;
							string str2;
							global::b.a(A_3, out str, out str2);
							global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = global::System.Security.Cryptography.Aes.Create();
							num = (short)1519779845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)782273355;
						short num3 = num;
						num = (short)1906674507;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3FC;
						default:
							num = (short)1603993600;
							if (num != 0)
							{
							}
							num = (short)1716322310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_137;
							}
							global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm;
							global::System.IO.FileStream fileStream;
							byte[] array;
							byte[] array2;
							for (;;)
							{
								IL_124:
								switch (num2)
								{
								case 0:
								{
									try
									{
										array = new byte[fileStream.Length];
										fileStream.Read(array, 0, array.Length);
										goto IL_19D;
									}
									finally
									{
										num = (short)988741632;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_225;
												}
												continue;
											case 1:
												((global::System.IDisposable)fileStream).Dispose();
												num = (short)6488066;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_25F;
											}
											IL_225:
											if (fileStream == null)
											{
												break;
											}
											num = (short)673644545;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_25F:;
									}
									goto Block_8;
									IL_19D:
									global::b.a(array, ref array2, A_2, A_3, symmetricAlgorithm.CreateDecryptor());
									global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
									num = (short)1239351297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_262;
								case 2:
									goto IL_2FA;
								}
								goto IL_137;
								Block_8:
								try
								{
									IL_262:
									global::System.IO.FileStream fileStream2;
									fileStream2.Write(array2, 0, array2.Length);
								}
								finally
								{
									num = (short)1999306752;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.IO.FileStream fileStream2;
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_2A6;
											}
											continue;
										case 1:
											((global::System.IDisposable)fileStream2).Dispose();
											num = (short)578486274;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_2DF;
										}
										IL_2A6:
										if (fileStream2 == null)
										{
											break;
										}
										num = (short)187564033;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_2DF:;
								}
								num = (short)542638082;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2FA:
							goto IL_3FC;
							IL_137:
							string str;
							symmetricAlgorithm.Key = global::System.Convert.FromBase64String(str + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⠔", a_));
							string str2;
							symmetricAlgorithm.IV = global::System.Convert.FromBase64String(str2 + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⠔⨖", a_));
							array = null;
							array2 = null;
							fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
							num = (short)497221632;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_124;
						}
						finally
						{
							num = (short)892207104;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_331;
									}
									continue;
								case 1:
									((global::System.IDisposable)symmetricAlgorithm).Dispose();
									num = (short)167903234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_368;
								}
								IL_331:
								if (symmetricAlgorithm == null)
								{
									break;
								}
								num = (short)770441217;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_368:;
						}
						goto IL_36B;
					case 6:
						goto IL_3F7;
					case 7:
						goto IL_414;
					}
					IL_6C:
					if (!string.IsNullOrEmpty(A_0))
					{
						num = (short)101908480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_36B:
					num = (short)1605238788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FC:
					num = (short)1840185351;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C8:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䘔縖縘甚簜欞吠儢䀤ܦ䠨䜪弬䨮倰圲䰴᜶尸䌺吼䰾㕀あ", a_));
				IL_118:
				goto IL_C8;
				IL_3F7:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䘔縖縘甚簜欞吠儢䀤ܦ䠨䜪弬䨮倰圲䰴᜶尸䌺吼䰾㕀あ", a_));
				IL_414:
				break;
			}
			}
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
		num = (short)1029373953;
		if (num != 0)
		{
		}
		num = (short)659750912;
		short num4 = num;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00004380 File Offset: 0x00002580
	public static void a(byte[] A_0, ref byte[] A_1, bool A_2, global::b.a A_3)
	{
		int a_ = 18;
		short num;
		try
		{
			num = (short)1720647681;
			if (num != 0)
			{
			}
			string str;
			string str2;
			global::b.a(A_3, out str, out str2);
			global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = global::System.Security.Cryptography.Aes.Create();
			try
			{
				symmetricAlgorithm.Key = global::System.Convert.FromBase64String(str + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⬕", a_));
				symmetricAlgorithm.IV = global::System.Convert.FromBase64String(str2 + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⬕┗", a_));
				global::b.a(A_0, ref A_1, A_2, A_3, symmetricAlgorithm.CreateDecryptor());
			}
			finally
			{
				num = (short)723386368;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_C6;
						}
						continue;
					case 1:
						goto IL_14C;
					case 2:
					{
						num = (short)828187969;
						short num3 = num;
						num = (short)577971521;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14E;
						default:
							num = (short)771162112;
							if (num != 0)
							{
							}
							((global::System.IDisposable)symmetricAlgorithm).Dispose();
							num = (short)1348993025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_C6:
					if (symmetricAlgorithm == null)
					{
						break;
					}
					num = (short)1804599298;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_14C:
				IL_14E:;
			}
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
		num = (short)1278607360;
		short num4 = num;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00004540 File Offset: 0x00002740
	public static void a(string A_0, ref string A_1, bool A_2, global::b.a A_3)
	{
		int a_ = 19;
		short num;
		try
		{
			num = (short)1996664723;
			short num2 = num;
			num = (short)533573523;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_28B:
				num = (short)1363148804;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)521469952;
				if (num != 0)
				{
				}
				num = (short)340983808;
				switch (num)
				{
				default:
					num = (short)2124480513;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_CF;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_AE;
					}
					continue;
				case 2:
					try
					{
						global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm;
						string str;
						symmetricAlgorithm.Key = global::System.Convert.FromBase64String(str + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⨖", a_));
						string str2;
						symmetricAlgorithm.IV = global::System.Convert.FromBase64String(str2 + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⨖␘", a_));
						byte[] array = null;
						byte[] bytes = null;
						global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
						try
						{
							array = new byte[fileStream.Length];
							fileStream.Read(array, 0, array.Length);
						}
						finally
						{
							num = (short)1244004352;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_173;
									}
									continue;
								case 1:
									goto IL_1AB;
								case 2:
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)1994719233;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_173:
								if (fileStream == null)
								{
									break;
								}
								num = (short)1804664834;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_1AB:;
						}
						global::System.Text.Encoding encoding = global::b.a(array, ref bytes, A_2, A_3, symmetricAlgorithm.CreateDecryptor());
						A_1 = encoding.GetString(bytes);
						goto IL_2D4;
					}
					finally
					{
						num = (short)1091436544;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm;
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_203;
								}
								continue;
							case 1:
								goto IL_23A;
							case 2:
								((global::System.IDisposable)symmetricAlgorithm).Dispose();
								num = (short)1953431553;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_203:
							if (symmetricAlgorithm == null)
							{
								break;
							}
							num = (short)2118909954;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_23A:;
					}
					goto IL_23D;
					IL_2D4:
					num = (short)988872707;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_2EC;
				case 4:
					goto IL_2A4;
				case 5:
				{
					if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
					{
						goto IL_28B;
					}
					string str;
					string str2;
					global::b.a(A_3, out str, out str2);
					global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = global::System.Security.Cryptography.Aes.Create();
					num = (short)1799553026;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_AE:
				if (string.IsNullOrEmpty(A_0))
				{
					num = (short)1350041600;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1274871813;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_CF:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䐖瀘簚猜縞唠嘢圤䈦न䨪䄬崮吰刲儴丶ᤸ帺䔼嘾㉀㝂㙄", a_));
			IL_23D:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䐖瀘簚猜縞唠嘢圤䈦न䨪䄬崮吰刲儴丶ᤸ帺䔼嘾㉀㝂㙄", a_));
			IL_2A4:
			goto IL_23D;
			IL_2EC:;
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
		num = (short)1478426625;
		if (num != 0)
		{
		}
		num = (short)984023040;
		short num4 = num;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000048DC File Offset: 0x00002ADC
	public static void a(string A_0, string A_1, bool A_2)
	{
		int a_ = 13;
		short num;
		try
		{
			num = (short)802750464;
			switch (num)
			{
			default:
			{
				num = (short)800325635;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
							num = (short)372703239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1750332911;
						short num3 = num;
						num = (short)47707631;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3E5;
						default:
							num = (short)2098462720;
							if (num != 0)
							{
							}
							num = (short)1760165892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)118489093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_3FE;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 4:
						goto IL_3E0;
					case 5:
						if (string.IsNullOrEmpty(A_1))
						{
							num = (short)871301126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_356;
					case 6:
						goto IL_110;
					case 7:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_12F;
							}
							global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider;
							global::System.IO.FileStream fileStream;
							byte[] array;
							byte[] array2;
							for (;;)
							{
								IL_11C:
								switch (num2)
								{
								case 0:
								{
									try
									{
										array = new byte[fileStream.Length];
										fileStream.Read(array, 0, array.Length);
										goto IL_191;
									}
									finally
									{
										num = (short)1444610048;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_217;
												}
												continue;
											case 1:
												goto IL_24F;
											case 2:
												((global::System.IDisposable)fileStream).Dispose();
												num = (short)2007367681;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_217:
											if (fileStream == null)
											{
												break;
											}
											num = (short)1665662978;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_24F:;
									}
									goto Block_8;
									IL_191:
									global::b.a(array, ref array2, A_2, global::b.a.a, tripleDESCryptoServiceProvider.CreateDecryptor());
									global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
									num = (short)2114650114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_2E7;
								case 2:
									goto IL_252;
								}
								goto IL_12F;
								Block_8:
								try
								{
									IL_252:
									global::System.IO.FileStream fileStream2;
									fileStream2.Write(array2, 0, array2.Length);
								}
								finally
								{
									num = (short)665387008;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.IO.FileStream fileStream2;
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_292;
											}
											continue;
										case 1:
											goto IL_2CC;
										case 2:
											((global::System.IDisposable)fileStream2).Dispose();
											num = (short)2030829569;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_292:
										if (fileStream2 == null)
										{
											break;
										}
										num = (short)1378484226;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_2CC:;
								}
								num = (short)1566572545;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E7:
							goto IL_3E5;
							IL_12F:
							tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("夐划䌔外娘䬚东匞甠朢焤爦木渪缬渮砰愲愴收砸砺砼派", a_));
							tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䜐嘒儔尖崘儚东伞", a_));
							array = null;
							array2 = null;
							fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
							num = (short)1724907520;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_11C;
						}
						finally
						{
							num = (short)1147666432;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_31E;
									}
									continue;
								case 1:
									goto IL_353;
								case 2:
									((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
									num = (short)637730817;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_31E:
								if (tripleDESCryptoServiceProvider == null)
								{
									break;
								}
								num = (short)1349320706;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_353:;
						}
						goto IL_356;
					}
					IL_6D:
					if (!string.IsNullOrEmpty(A_0))
					{
						num = (short)2061041665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_356:
					num = (short)746127360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E5:
					num = (short)1262813186;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BF:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䈐稒爔礖砘漚栜洞䐠̢䐤䬦嬨个䰬䬮䠰ጲ倴伶倸䠺䤼䰾", a_));
				IL_110:
				goto IL_BF;
				IL_3E0:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䈐稒爔礖砘漚栜洞䐠̢䐤䬦嬨个䰬䬮䠰ጲ倴伶倸䠺䤼䰾", a_));
				IL_3FE:
				break;
			}
			}
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
		num = (short)822542337;
		if (num != 0)
		{
		}
		num = (short)2003697664;
		short num4 = num;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00004DA0 File Offset: 0x00002FA0
	public static void a(byte[] A_0, ref byte[] A_1, bool A_2)
	{
		int a_ = 13;
		short num;
		try
		{
			global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
			try
			{
				tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("夐划䌔外娘䬚东匞甠朢焤爦木渪缬渮砰愲愴收砸砺砼派", a_));
				tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䜐嘒儔尖崘儚东伞", a_));
				global::b.a(A_0, ref A_1, A_2, global::b.a.a, tripleDESCryptoServiceProvider.CreateDecryptor());
			}
			finally
			{
				num = (short)1819738112;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_93;
						}
						continue;
					case 1:
						goto IL_117;
					case 2:
					{
						num = (short)1765174506;
						short num3 = num;
						num = (short)1025076458;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_119;
						default:
							num = (short)1606287360;
							if (num != 0)
							{
							}
							((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
							num = (short)379191297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_93:
					if (tripleDESCryptoServiceProvider == null)
					{
						break;
					}
					num = (short)489619458;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_117:
				IL_119:;
			}
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
		num = (short)861011969;
		if (num != 0)
		{
		}
		num = (short)802816000;
		short num4 = num;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00004F50 File Offset: 0x00003150
	public static void a(string A_0, ref string A_1, bool A_2)
	{
		int a_ = 0;
		short num;
		try
		{
			num = (short)29386391;
			short num2 = num;
			num = (short)1000826519;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)318308352;
				if (num != 0)
				{
				}
				num = (short)379191296;
				switch (num)
				{
				default:
				{
					global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
					try
					{
						tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䰃䜅帇䐉伋帍䌏帑䀓刕䰗伙创嬝爟挡洣琥簧砩洫洭甯怱", a_));
						tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("刃䌅䰇䄉䠋䐍䌏䈑", a_));
						byte[] array = null;
						byte[] bytes = null;
						global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
						try
						{
							array = new byte[fileStream.Length];
							fileStream.Read(array, 0, array.Length);
						}
						finally
						{
							num = (short)1973026816;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_114;
									}
									continue;
								case 1:
									goto IL_14C;
								case 2:
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)286064641;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_114:
								if (fileStream == null)
								{
									break;
								}
								num = (short)1854603266;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_14C:;
						}
						global::System.Text.Encoding encoding = global::b.a(array, ref bytes, A_2, global::b.a.a, tripleDESCryptoServiceProvider.CreateDecryptor());
						A_1 = encoding.GetString(bytes);
					}
					finally
					{
						num = (short)2042363904;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_19D;
								}
								continue;
							case 1:
								goto IL_1D4;
							case 2:
								((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
								num = (short)751239169;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_19D:
							if (tripleDESCryptoServiceProvider == null)
							{
								break;
							}
							num = (short)2139029506;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1D4:;
					}
					break;
				}
				}
				break;
			}
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
		num = (short)1126825985;
		if (num != 0)
		{
		}
		num = (short)371523584;
		short num4 = num;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000051D4 File Offset: 0x000033D4
	private static void a(byte[] A_0, ref byte[] A_1, bool A_2, global::System.Security.Cryptography.ICryptoTransform A_3)
	{
		int a_ = 9;
		short num;
		try
		{
			num = (short)183894016;
			switch (num)
			{
			default:
			{
				num = (short)1521811460;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream;
					switch (num2)
					{
					case 0:
						goto IL_1C3;
						try
						{
							for (;;)
							{
								IL_1C3:
								global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, A_3, global::System.Security.Cryptography.CryptoStreamMode.Write);
								try
								{
									cryptoStream.Write(A_0, 0, A_0.Length);
									cryptoStream.FlushFinalBlock();
								}
								finally
								{
									num = (short)1317732352;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_213;
											}
											continue;
										case 1:
											goto IL_249;
										case 2:
											((global::System.IDisposable)cryptoStream).Dispose();
											num = (short)1742209025;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_213:
										if (cryptoStream == null)
										{
											break;
										}
										num = (short)285868034;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_249:;
								}
								num = (short)525812729;
								short num3 = num;
								num = (short)1064453113;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_280;
								}
							}
							IL_280:
							num = (short)825294848;
							if (num != 0)
							{
							}
							A_1 = memoryStream.ToArray();
							goto IL_3A3;
						}
						finally
						{
							num = (short)1227685888;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2D5;
									}
									continue;
								case 1:
									goto IL_30B;
								case 2:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)1797324801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2D5:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)550633474;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_30B:;
						}
						goto IL_30E;
						IL_3A3:
						num = (short)1724252166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_342;
					case 2:
						goto IL_30E;
					case 3:
						if (A_2)
						{
							num = (short)166789125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_90;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_70;
						}
						continue;
					case 5:
					{
						global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream();
						num = (short)1474953223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_3BB;
					case 7:
						try
						{
							global::System.IO.MemoryStream memoryStream2;
							global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream2, global::System.IO.Compression.CompressionMode.Compress, true);
							try
							{
								gzipStream.Write(A_0, 0, A_0.Length);
							}
							finally
							{
								num = (short)282132480;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_FC;
										}
										continue;
									case 1:
										goto IL_133;
									case 2:
										((global::System.IDisposable)gzipStream).Dispose();
										num = (short)417923073;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_FC:
									if (gzipStream == null)
									{
										break;
									}
									num = (short)1774845954;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_133:;
							}
							A_0 = memoryStream2.ToArray();
							goto IL_90;
						}
						finally
						{
							num = (short)876806144;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.IO.MemoryStream memoryStream2;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_176;
									}
									continue;
								case 1:
									goto IL_1AC;
								case 2:
									((global::System.IDisposable)memoryStream2).Dispose();
									num = (short)1086390273;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_176:
								if (memoryStream2 == null)
								{
									break;
								}
								num = (short)1273233410;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1AC:;
						}
						goto IL_1AF;
					case 8:
						if (A_0.Length == 0)
						{
							num = (short)1608318977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1839398915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_70:
					if (A_0 != null)
					{
						num = (short)1383333890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_90:
					memoryStream = new global::System.IO.MemoryStream();
					num = (short)1336999936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30E:
					num = (short)483983368;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1AF:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("希明瘐紒琔挖氘椚砜㼞䀠伢圤䈦䠨伪听༮吰䬲尴䐶䴸䠺", a_));
				IL_342:
				goto IL_1AF;
				IL_3BB:
				break;
			}
			}
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
		num = (short)1444151297;
		if (num != 0)
		{
		}
		num = (short)867827712;
		short num4 = num;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x0000566C File Offset: 0x0000386C
	private static global::System.Text.Encoding a(byte[] A_0, ref byte[] A_1, bool A_2, global::b.a A_3, global::System.Security.Cryptography.ICryptoTransform A_4)
	{
		int a_ = 15;
		short num = (short)2100101121;
		if (num != 0)
		{
		}
		num = (short)104202240;
		short num2 = num;
		num = (short)469696512;
		switch (num)
		{
		default:
		{
			global::System.Text.Encoding encoding = null;
			try
			{
				num = (short)1762000922;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte[] array;
					byte b;
					global::System.IO.MemoryStream memoryStream;
					switch (num3)
					{
					case 0:
						if (array[1].Equals(187))
						{
							num = (short)1322516497;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C9;
					case 1:
						if (array[1].Equals(254))
						{
							num = (short)1562443787;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E3;
					case 2:
						if (b != 239)
						{
							num = (short)866254863;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1939800064;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_4B8;
					case 4:
						goto IL_83C;
					case 5:
						if (array[1].Equals(255))
						{
							num = (short)769982483;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CF;
					case 6:
						try
						{
							memoryStream = new global::System.IO.MemoryStream(array);
							global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Decompress, false);
							try
							{
								memoryStream = null;
								byte[] array2 = new byte[4096];
								global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream();
								try
								{
									switch (0)
									{
									case 0:
										goto IL_187;
									}
									for (;;)
									{
										IL_16C:
										switch (num3)
										{
										case 0:
										{
											int count;
											if ((count = gzipStream.Read(array2, 0, array2.Length)) <= 0)
											{
												num = (short)290979841;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											memoryStream2.Write(array2, 0, count);
											num = (short)1078132738;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
											array = memoryStream2.ToArray();
											num = (short)312213507;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_1A2;
										case 3:
											goto IL_22A;
										case 4:
											goto IL_1A2;
										}
										goto IL_187;
										IL_1A2:
										num = (short)1873412096;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_22A:
									goto IL_2EE;
									IL_187:
									num = (short)512884740;
									num3 = (int)((global::System.IntPtr)num);
									goto IL_16C;
								}
								finally
								{
									num = (short)27656194;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										IL_24F:
										switch (num3)
										{
										case 0:
											((global::System.IDisposable)memoryStream2).Dispose();
											num = (short)1957822465;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_2EB;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_262;
											}
											continue;
										}
										IL_262:
										while (memoryStream2 != null)
										{
											num = (short)1727711516;
											short num4 = num;
											num = (short)765446428;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												num = (short)1689518080;
												if (num != 0)
												{
												}
												num = (short)980746240;
												num3 = (int)((global::System.IntPtr)num);
												goto IL_24F;
											}
										}
										break;
									}
									IL_2EB:;
								}
								IL_2EE:;
							}
							finally
							{
								num = (short)1498873858;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										((global::System.IDisposable)gzipStream).Dispose();
										num = (short)799014913;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_35A;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_323;
										}
										continue;
									}
									IL_323:
									if (gzipStream == null)
									{
										break;
									}
									num = (short)1294532608;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_35A:;
							}
							goto IL_547;
						}
						finally
						{
							num = (short)1151270914;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									memoryStream.Dispose();
									num = (short)660340737;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3CC;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_394;
									}
									continue;
								}
								IL_394:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)1231683584;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_3CC:;
						}
						goto IL_3CF;
					case 7:
						goto IL_922;
					case 8:
						if (array[2].Equals(191))
						{
							num = (short)176554005;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C9;
					case 9:
						if (A_2)
						{
							num = (short)385875974;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_547;
					case 10:
						if (A_3 == global::b.a.e)
						{
							num = (short)560529436;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						encoding = new global::System.Text.UTF8Encoding();
						num = (short)960823299;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						A_1 = new byte[array.Length - 2];
						global::System.Array.Copy(array, 2, A_1, 0, array.Length - 2);
						encoding = new global::System.Text.UnicodeEncoding();
						global::b.a(ref A_1, encoding);
						num = (short)1497038871;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_4B8;
					case 13:
						num = (short)19070998;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_922;
					case 15:
						num = (short)1730936848;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (b != 254)
						{
							num = (short)125566980;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)77135877;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)131727368;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_93B;
					case 19:
						A_1 = new byte[array.Length - 2];
						global::System.Array.Copy(array, 2, A_1, 0, array.Length - 2);
						encoding = new global::System.Text.UnicodeEncoding();
						global::b.a(ref A_1, encoding);
						num = (short)1553858580;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_922;
					case 21:
						A_1 = new byte[array.Length - 3];
						global::System.Array.Copy(array, 3, A_1, 0, array.Length - 3);
						encoding = new global::System.Text.UTF8Encoding();
						global::b.a(ref A_1, encoding);
						num = (short)616890375;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						A_1 = new byte[array.Length];
						global::System.Array.Copy(array, 0, A_1, 0, array.Length);
						num = (short)545062922;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_922;
					case 24:
						if (b != 255)
						{
							num = (short)88211469;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1193607169;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						try
						{
							memoryStream = new global::System.IO.MemoryStream(A_0);
							global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, A_4, global::System.Security.Cryptography.CryptoStreamMode.Read);
							try
							{
								memoryStream = null;
								array = cryptoStream.ReadRequestedBytes(A_0.Length);
							}
							finally
							{
								num = (short)791347202;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										((global::System.IDisposable)cryptoStream).Dispose();
										num = (short)95551489;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_7C7;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_791;
										}
										continue;
									}
									IL_791:
									if (cryptoStream == null)
									{
										break;
									}
									num = (short)664338432;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_7C7:;
							}
							goto IL_50D;
						}
						finally
						{
							num = (short)379846658;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									memoryStream.Dispose();
									num = (short)870055937;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_839;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_802;
									}
									continue;
								}
								IL_802:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)635895808;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_839:;
						}
						goto IL_83C;
						IL_50D:
						num = (short)677969929;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						switch (0)
						{
						case 0:
							goto IL_114;
						}
						continue;
					case 27:
						goto IL_133;
					case 28:
						encoding = global::System.Text.Encoding.GetEncoding(1252);
						num = (short)1481310220;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_114:
					if (A_0 == null)
					{
						num = (short)2117402651;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					array = new byte[A_0.Length];
					memoryStream = null;
					num = (short)1615855641;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B8:
					global::b.a(ref A_1, encoding);
					num = (short)671744014;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_547:
					b = array[0];
					num = (short)613154818;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_83C:
					num = (short)134021144;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_922:
					num = (short)1022951442;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_133:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀒簔瀖眘稚検樞匠䘢Ԥ䘦䔨太䠬丮唰䨲ᔴ制䄸刺丼䬾㉀", a_));
				IL_3CF:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀒簔瀖眘稚検樞匠䘢Ԥ䘦䔨太䠬丮唰䨲ᔴ制䄸刺丼䬾㉀", a_));
				IL_3E3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀒簔瀖眘稚検樞匠䘢Ԥ䘦䔨太䠬丮唰䨲ᔴ制䄸刺丼䬾㉀", a_));
				IL_8C9:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀒簔瀖眘稚検樞匠䘢Ԥ䘦䔨太䠬丮唰䨲ᔴ制䄸刺丼䬾㉀", a_));
				IL_93B:;
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			return encoding;
		}
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0000604C File Offset: 0x0000424C
	public static void a(string A_0, ref uint A_1, ref byte[] A_2)
	{
		int a_ = 1;
		short num = (short)1255014403;
		int num2 = (int)((global::System.IntPtr)num);
		for (;;)
		{
			switch (num2)
			{
			case 0:
			{
				num = (short)585797381;
				short num3 = num;
				num = (short)1033080581;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D3;
				default:
					num = (short)1797652480;
					if (num != 0)
					{
					}
					num = (short)2071068673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
			}
			case 1:
				if (A_0.Length % 2 != 0)
				{
					num = (short)1266155522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_149;
			case 2:
				goto IL_120;
			case 3:
				switch (0)
				{
				case 0:
					goto IL_3D;
				}
				continue;
			}
			IL_3D:
			if (string.IsNullOrEmpty(A_0))
			{
				goto IL_149;
			}
			num = (short)111345664;
			short num4 = num;
			num = (short)873136128;
			num2 = (int)((global::System.IntPtr)num);
		}
		IL_D3:
		throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("嘄渆済攊氌笎搐愒瀔㜖砘眚漜稞䀠䜢尤ܦ䰨匪䐬尮䔰䀲", a_));
		IL_120:
		num = (short)2032336897;
		if (num != 0)
		{
		}
		goto IL_D3;
		IL_149:
		A_1 = global::b.a(A_0);
		A_2 = global::b.a(A_0, A_1);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000061B4 File Offset: 0x000043B4
	private static uint a(string A_0)
	{
		int a_ = 5;
		short num = (short)1187512321;
		if (num != 0)
		{
		}
		num = (short)1111949315;
		int num2 = (int)((global::System.IntPtr)num);
		for (;;)
		{
			switch (num2)
			{
			case 0:
			{
				num = (short)975274423;
				short num3 = num;
				num = (short)996508087;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F7;
				default:
					num = (short)235798528;
					if (num != 0)
					{
					}
					num = (short)41549825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
			}
			case 1:
				if (A_0.Length % 2 != 0)
				{
					num = (short)1115619330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_146;
			case 2:
				goto IL_144;
			case 3:
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				continue;
			}
			IL_63:
			num = (short)115539968;
			short num4 = num;
			if (string.IsNullOrEmpty(A_0))
			{
				goto IL_146;
			}
			num = (short)1536819200;
			num2 = (int)((global::System.IntPtr)num);
		}
		IL_F7:
		throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("娈戊樌愎瀐朒怔攖簘㬚簜猞匠䘢䐤䌦倨ପ䠬圮堰䀲䄴䐶", a_));
		IL_144:
		goto IL_F7;
		IL_146:
		return uint.Parse(A_0.Substring(0, 8), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00006320 File Offset: 0x00004520
	private static byte[] a(string A_0, uint A_1)
	{
		int a_ = 4;
		short num = (short)1864826891;
		int num2 = (int)((global::System.IntPtr)num);
		byte[] array;
		for (;;)
		{
			string text;
			switch (num2)
			{
			case 0:
				num = (short)2045378561;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			case 1:
				if (A_0.Length % 2 != 0)
				{
					goto IL_15E;
				}
				goto IL_215;
			case 2:
				goto IL_176;
			case 3:
				goto IL_86;
			case 4:
				num = (short)107020289;
				if (num != 0)
				{
				}
				num = (short)996278277;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			case 5:
				goto IL_135;
			case 6:
				num = (short)1150287879;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			case 7:
				if ((long)A_0.Length >= 56L)
				{
					num = (short)314769417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return array;
			case 8:
				goto IL_86;
			case 9:
			{
				array = new byte[24];
				int num3 = 0;
				num = (short)1839005699;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			case 10:
			{
				if (A_1 != 1U)
				{
					goto IL_1BE;
				}
				num = (short)1181433100;
				short num4 = num;
				num = (short)39140620;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_15E;
				default:
				{
					num = (short)1143144448;
					if (num != 0)
					{
					}
					num = (short)229048320;
					short num5 = num;
					num = (short)720371718;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				break;
			}
			case 11:
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				continue;
			case 12:
			{
				int num3;
				if ((long)num3 >= 24L)
				{
					num = (short)809172996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				text = A_0.Substring((int)((4L + (long)num3) * 2L), 2);
				array[num3] = byte.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
				num3++;
				num = (short)1676345352;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			}
			IL_62:
			if (!string.IsNullOrEmpty(A_0))
			{
				num = (short)898760704;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			goto IL_215;
			IL_86:
			num = (short)648347660;
			num2 = (int)((global::System.IntPtr)num);
			continue;
			IL_15E:
			num = (short)1791033346;
			num2 = (int)((global::System.IntPtr)num);
			continue;
			IL_215:
			array = null;
			text = string.Empty;
			num = (short)691929098;
			num2 = (int)((global::System.IntPtr)num);
		}
		IL_135:
		return array;
		IL_176:
		throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("嬇按欋怍焏昑愓搕紗㨙紛爝刟䜡䔣䈥儧਩䤫嘭夯䄱䀳䔵", a_));
		IL_1BE:
		throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("嬇按欋怍焏昑愓搕紗㨙紛爝刟䜡䔣䈥儧਩䤫嘭夯䄱䀳䔵", a_));
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000065FC File Offset: 0x000047FC
	private static void a(ref byte[] A_0, global::System.Text.Encoding A_1)
	{
		short num;
		try
		{
			num = (short)1702598467;
			short num2 = num;
			num = (short)1844287299;
			switch (num2 == num)
			{
			}
			num = (short)1521287168;
			if (num != 0)
			{
			}
			num = (short)966197249;
			if (num != 0)
			{
			}
			string text = A_1.GetString(A_0);
			text = text.TrimEnd(new char[1]);
			A_0 = A_1.GetBytes(text);
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
		num = (short)1078984704;
		short num3 = num;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000066DC File Offset: 0x000048DC
	private static void a(global::b.a A_0, out string A_1, out string A_2)
	{
		short num;
		if (A_0 == global::b.a.e)
		{
			num = (short)1442512897;
			if (num != 0)
			{
			}
			num = (short)1006250037;
			short num2 = num;
			num = (short)2122197045;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1406992384;
				if (num != 0)
				{
				}
				break;
			}
			A_1 = global::b.z[1];
			A_2 = global::b.aa[1];
			return;
		}
		num = (short)1563492352;
		short num3 = num;
		A_1 = global::b.z[(int)A_0];
		A_2 = global::b.aa[(int)A_0];
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000067C8 File Offset: 0x000049C8
	// Note: this type is marked as 'beforefieldinit'.
	static b()
	{
		int a_ = 15;
		short num = (short)1382977250;
		short num2 = num;
		num = (short)960597730;
		switch (num2 == num)
		{
		default:
		{
			num = (short)7602176;
			short num3 = num;
			break;
		}
		case true:
			break;
		}
		num = (short)412549121;
		if (num != 0)
		{
		}
		num = (short)621740032;
		if (num != 0)
		{
		}
		global::b.z = new string[]
		{
			global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䄒研儖堘业眜朞䰠䄢爤圦攨攪䀬䐮䀰昲怴愶游崺格圾⹀ቂ瑄ቆ㩈⽊籌ൎṐ͒敔ൖ⥘᝚ଡ଼㡞噠㙢㙤㙦", a_),
			global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌒␔帖愘缚⸜氞嘠栢怤ሦᴨ昪圬種䘰簲洴弶丸氺甼䬾рᕂ⽄੆祈⥊⑌Ŏᵐ੒摔㭖᝘ၚ❜ᅞ㍠ݢ୤⹦", a_),
			global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("帒笔挖渘䤚夜眞瘠瀢愤弦愨昪ᴬ樮帰圲Դ渶唸氺䜼ਾ╀❂ᅄ㽆ፈ⹊⁌⍎ݐْ⽔捖⍘㥚ぜ⽞፠Ɫ≤㹦", a_)
		};
		global::b.aa = new string[]
		{
			global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("瀒演朖℘倚䬜欞瀠䔢猤爦ب䤪䜬ᘮ猰儲挴甶圸爺䨼", a_),
			global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䈒礔瀖⨘䴚东朞怠椢爤ሦ䴨搪䜬戮а倲紴紶瀸瘺䨼", a_),
			global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䈒䄔笖焘吚嬜䔞ᠠ䀢䬤縦ᠨ愪礬樮0刲д渶ସ椺氼", a_)
		};
		global::b.ab = new string[]
		{
			global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("瀒攔搖⬘", a_),
			global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("挒朔爖紘縚笜瘞传䘢䄤", a_)
		};
		global::b.ac = new string[]
		{
			global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("瘒笔刖⨘礚琜䤞倠猢瀤弦ᄨ怪䌬渮а縲ش嬶伸渺氼", a_),
			global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("堒礔帖爘縚眜儞䠠渢䤤ἦ崨愪縬愮İ愲爴䌶匸瘺氼", a_)
		};
		global::b.ad = new string[]
		{
			global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⼒䜔䐖堘倚砜昞眠䈢䤤刦䰨ᔪᄬ戮帰圲䀴嬶䰸䠺̼ਾ@≂ไፆ罈͊㭌❎桐硒є╖क़ౚ⽜橞ᙠᙢɤѦᡨ⵪ݬ㕮♰ᙲ䁴䍶xⱺ䥼偾뎀놆슈쪊얌쒎\ud890\udf9aꪜ햞鎠\udba2躤슦얨춪ﮮ쎰쪲貴ﲸ쎺趼Ꟃ뗄ꯆ軈﯊黌軎ꗐ黒鯔믖臘闚诜뇠믢냤탦\udbe8뇪裬샮裰鳲郴돶훸鳺鯼賾䘀䄂䈄欆搈挊紌夎刐欒縔猖⤘䰚欜礞爠䴢瘤䬦ᰨ匪䠬.昰倲瘴愶猸唺䐼䴾⭀ੂᑄⵆᭈɊ祌硎ၐ㱒㹔恖ᅘ桚⥜㕞ᕠၢ൤ᅦᡨ䑪Ⅼ⍮㩰♲Ŵ⁶Ÿ୺ռپ떀슄麗歷年ꎐꎒꢔꮖ뚘횚ﮞ풠쾢키풦鞨鞪힮솰\udcb2\udbb4튶ힸ쾺莼ﺾ郀苂蟄﯆車뗌뿎뻐뷒냔맖귘돠냢ꓤ곦賨鋪믬軮鷰蛲郴짶", a_),
			global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⼒䜔䐖堘倚砜昞眠䈢䤤刦䰨ᔪᄬ戮帰圲䀴嬶䰸䠺̼举ᭀ㥂၄⽆穈ొ⑌❎㍐⥒ㅔṖ湘ⱚ᝜❞ɠ⩢ὤᅦ╨㍪婬㝮幰䑲ٴ⍶ⱸ⡺᩼ᕾ임ﺆﮊ욎슐ﲒ풔\udf98뚜ꪞ펠햤욦\udda8肪\udbac삲슴\ud8b8ﲼ諀귄돆꫈鳊髌﷎룐铒뇔鏖뗘ꋚ飜跞ꫠ쳢냤틦菨蛪裬\uddee룰뇲쳴웶뫸뷺韼链㠀愂嘄理搈崊甌㨎䌐唒☔砖䴘愚匜爞夠戢䴤ࠦ䨨稪ᨬ帮瀰䐲瀴帶ᘸ࠺嬼夾㑀桂ᙄ㵆཈ᡊⱌᕎ㵐॒ὔ籖桘ずᙜ౞ᙠౢ⡤䡦ᡨᵪ㭬㽮⥰≲ὴᙶ⁸ᙺࡼ乾잀랂\udc84\ude86춈몊뮎ꊐꎒꢔꮖ뚘횚ﮞ풠쾢키풦鞨鞪힮솰\udcb2\udbb4튶ힸ쾺莼ﺾ郀苂蟄﯆車뗌뿎뻐뷒냔맖귘돠냢ꓤ곦賨鋪믬軮鷰蛲郴짶", a_)
		};
	}

	// Token: 0x04000003 RID: 3
	private const int a = 0;

	// Token: 0x04000004 RID: 4
	public const int b = 3;

	// Token: 0x04000005 RID: 5
	private const int c = 2;

	// Token: 0x04000006 RID: 6
	private const int d = 1024;

	// Token: 0x04000007 RID: 7
	public const byte e = 239;

	// Token: 0x04000008 RID: 8
	public const byte f = 187;

	// Token: 0x04000009 RID: 9
	public const byte g = 191;

	// Token: 0x0400000A RID: 10
	private const byte h = 254;

	// Token: 0x0400000B RID: 11
	private const byte i = 255;

	// Token: 0x0400000C RID: 12
	private const byte j = 255;

	// Token: 0x0400000D RID: 13
	private const byte k = 254;

	// Token: 0x0400000E RID: 14
	private const string l = "|";

	// Token: 0x0400000F RID: 15
	private const string m = "Secure";

	// Token: 0x04000010 RID: 16
	private const string n = ", ";

	// Token: 0x04000011 RID: 17
	private const char o = '\0';

	// Token: 0x04000012 RID: 18
	private const string p = "<SIGNATURE>";

	// Token: 0x04000013 RID: 19
	private const string q = "</SIGNATURE>";

	// Token: 0x04000014 RID: 20
	private const string r = "<VERSION>";

	// Token: 0x04000015 RID: 21
	private const string s = "</VERSION>";

	// Token: 0x04000016 RID: 22
	private const string t = "1.0";

	// Token: 0x04000017 RID: 23
	private const string u = "<DIGEST>";

	// Token: 0x04000018 RID: 24
	private const string v = "</DIGEST>";

	// Token: 0x04000019 RID: 25
	public const uint w = 4U;

	// Token: 0x0400001A RID: 26
	public const uint x = 1U;

	// Token: 0x0400001B RID: 27
	public const uint y = 24U;

	// Token: 0x0400001C RID: 28
	private static string[] z;

	// Token: 0x0400001D RID: 29
	private static string[] aa;

	// Token: 0x0400001E RID: 30
	private static string[] ab;

	// Token: 0x0400001F RID: 31
	private static string[] ac;

	// Token: 0x04000020 RID: 32
	private static string[] ad;

	// Token: 0x02000005 RID: 5
	public enum a
	{
		// Token: 0x04000025 RID: 37
		a = -1,
		// Token: 0x04000026 RID: 38
		b,
		// Token: 0x04000027 RID: 39
		c,
		// Token: 0x04000028 RID: 40
		d,
		// Token: 0x04000029 RID: 41
		e = 25
	}

	// Token: 0x02000006 RID: 6
	public enum b
	{
		// Token: 0x0400002B RID: 43
		a,
		// Token: 0x0400002C RID: 44
		b
	}

	// Token: 0x02000007 RID: 7
	public enum c
	{
		// Token: 0x0400002E RID: 46
		a,
		// Token: 0x0400002F RID: 47
		b,
		// Token: 0x04000030 RID: 48
		c
	}
}
