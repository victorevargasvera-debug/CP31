using System;
using System.Globalization;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Motorola.Common.CustomException;

namespace Motorola.Security.SamlTokenComponent
{
	// Token: 0x02000007 RID: 7
	public class SamlTokenCertificateUtility
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00003378 File Offset: 0x00001578
		internal static global::System.Security.SecureString c(string A_0)
		{
			int a_ = 8;
			short num = (short)1227096064;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				string text;
				string text2;
				byte[] array;
				byte[] array2;
				byte[] array3;
				byte[] array4;
				byte[] array5;
				global::System.Security.SecureString secureString;
				byte[] array7;
				byte[] array8;
				byte[] array9;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (A_0[A_0.Length - 1] != '\\')
						{
							num = (short)1590689802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = A_0 + global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("飸诺觼믾焀䀂挄怆✈戊挌椎縐", a_);
						text2 = A_0 + global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("飸诺觼믾焀ⴂ氄椆漈搊", a_);
						num = (short)1469120516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_524;
					case 2:
						if (global::System.IO.Directory.Exists(A_0))
						{
							num = (short)1371996161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AC;
					case 3:
						goto IL_614;
					case 4:
						goto IL_614;
					case 5:
						num = (short)812187650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_5A7;
					case 7:
						if (!global::System.IO.File.Exists(text2))
						{
							num = (short)1020723206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1512767499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!global::System.IO.File.Exists(text))
						{
							num = (short)1259077644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)66191367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (!string.IsNullOrEmpty(A_0))
						{
							num = (short)768606213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AC;
					case 10:
						text = A_0 + global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꗸ髺跼课䔀猂䘄愆済┊搌愎眐簒", a_);
						text2 = A_0 + global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꗸ髺跼课䔀猂⬄渆月洊戌", a_);
						num = (short)1396703235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						try
						{
							num = (short)1446998518;
							short num3 = num;
							num = (short)1591439862;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)1482555392;
								if (num != 0)
								{
								}
								array = global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.b(text2);
								array2 = global::System.Security.Cryptography.ProtectedData.Unprotect(array, null, global::System.Security.Cryptography.DataProtectionScope.LocalMachine);
								array3 = global::System.Text.Encoding.UTF8.GetBytes(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("苸뻺컼웾䜀㨂㐄㔆ㄈ☊㸌㼎☐嘒㠔⌖ⴘ帚堜㈞挠昢ጤ挦Шᨪ᤬Ἦ爰زఴ̶砸稺଼฾@㹂", a_));
								global::System.Security.Cryptography.HMACSHA256 hmacsha = new global::System.Security.Cryptography.HMACSHA256(array2);
								try
								{
									switch (0)
									{
									case 0:
										goto IL_21B;
									}
									int num5;
									for (;;)
									{
										IL_1E0:
										switch (num2)
										{
										case 0:
											goto IL_35E;
										case 1:
										{
											int num4;
											if (num4 >= array4.Length)
											{
												num = (short)1800339467;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											array4[num4] = (array4[num4] | array5[num4 - array5.Length] | 2);
											num4++;
											num = (short)1171062786;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
											goto IL_35E;
										case 3:
										{
											int num4 = array5.Length;
											num = (short)1293484032;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 4:
											goto IL_453;
										case 5:
											if (num5 >= array5.Length)
											{
												num = (short)2093940739;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											array4[num5] = (array5[num5] | array4[num5] | 1);
											num5++;
											num = (short)1290928140;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
											goto IL_2B9;
										case 7:
										{
											secureString.MakeReadOnly();
											char[] chars;
											global::System.Array.Clear(chars, 0, chars.Length);
											num = (short)2048720900;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 8:
											goto IL_2B9;
										case 9:
											goto IL_258;
										case 10:
										{
											int num6;
											char[] array6;
											if (num6 >= array6.Length)
											{
												num = (short)136052743;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											char c = array6[num6];
											secureString.AppendChar(c);
											num6++;
											num = (short)1554186246;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 11:
										{
											array7 = hmacsha.ComputeHash(array4);
											array8 = global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.b(text);
											array9 = global::System.Security.Cryptography.ProtectedData.Unprotect(array8, array7, global::System.Security.Cryptography.DataProtectionScope.LocalMachine);
											char[] chars = global::System.Text.Encoding.UTF8.GetChars(array9);
											secureString = new global::System.Security.SecureString();
											char[] array6 = chars;
											int num6 = 0;
											num = (short)1449459720;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 12:
											goto IL_258;
										}
										goto IL_21B;
										IL_258:
										num = (short)11927557;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_2B9:
										num = (short)1499201546;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_35E:
										num = (short)1874591745;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_453:
									break;
									IL_21B:
									array5 = hmacsha.ComputeHash(array3);
									array4 = new byte[array2.Length];
									global::System.Array.Copy(array2, array4, array2.Length);
									num5 = 0;
									num = (short)584515593;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_1E0;
								}
								finally
								{
									num = (short)325189632;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_487;
											}
											continue;
										case 1:
											((global::System.IDisposable)hmacsha).Dispose();
											num = (short)191168514;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_4BE;
										}
										IL_487:
										if (hmacsha == null)
										{
											break;
										}
										num = (short)594214913;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_4BE:;
								}
								break;
							}
							}
							goto IL_69C;
						}
						catch (global::System.Exception ex)
						{
							global::System.Console.WriteLine(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("본觺迼郾猀⌂圄戆紈礊搌樎朐稒笔瀖㤘缚簜欞䀠ᤢԤ", a_) + ex.Message);
							goto IL_69C;
						}
						finally
						{
							global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.a(array);
							global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.a(array2);
							global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.a(array3);
							global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.a(array5);
							global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.a(array4);
							global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.a(array7);
							global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.a(array8);
							global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.a(array9);
						}
						goto IL_524;
					case 12:
						goto IL_650;
					}
					goto IL_6C;
					IL_524:
					num = (short)427687936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_614:
					num = (short)569966600;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_5A7:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.X509ClientCertificatePathNotFound, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("諸黺飼鯾℀攂氄欆氈⬊挌怎攐㌒猔砖氘甚礜㼞娠ጢ堤", a_), text2));
				IL_5AC:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.X509ClientCertificatePathNotFound);
				IL_650:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.X509ClientCertificatePathNotFound, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("鳸闺黼\udffe攀戂焄昆⤈笊氌笎礐㌒笔砖洘㬚笜瀞吠䴢䄤ᴦन倪ᴬ刮", a_), text));
				IL_69C:
				num = (short)1943666689;
				if (num != 0)
				{
				}
				num = (short)457179136;
				short num7 = num;
				return secureString;
				IL_6C:
				secureString = null;
				text = null;
				text2 = null;
				array = null;
				array2 = null;
				array3 = null;
				array5 = null;
				array4 = null;
				array7 = null;
				array8 = null;
				array9 = null;
				num = (short)2131623945;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003AC0 File Offset: 0x00001CC0
		private static void a(global::System.Array A_0)
		{
			short num = (short)1178533889;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1417150465;
				if (num != 0)
				{
				}
				num = (short)64028672;
				short num3 = num;
				num = (short)688753459;
				short num4 = num;
				num = (short)815500083;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)647495680;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_D3;
						}
						continue;
					case 2:
						num = (short)1369243651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (A_0.Length > 0)
						{
							goto IL_136;
						}
						return;
					case 4:
						global::System.Array.Clear(A_0, 0, A_0.Length);
						num = (short)2059010048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D3:
					if (A_0 != null)
					{
						num = (short)1680539650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_136:
				num = (short)1699282948;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003C1C File Offset: 0x00001E1C
		private static byte[] b(string A_0)
		{
			int a_ = 6;
			short num = (short)1560608768;
			switch (num)
			{
			default:
			{
				byte[] result = null;
				if (global::System.IO.File.Exists(A_0))
				{
					num = (short)1408630784;
					short num2 = num;
					try
					{
						global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
						try
						{
							num = (short)1456759267;
							short num3 = num;
							num = (short)548430307;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)656736256;
								if (num != 0)
								{
								}
								global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(fileStream);
								try
								{
									result = binaryReader.ReadBytes((int)fileStream.Length);
								}
								finally
								{
									num = (short)645398528;
									int num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_112;
											}
											continue;
										case 1:
											((global::System.IDisposable)binaryReader).Dispose();
											num = (short)1099300866;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_148;
										}
										IL_112:
										if (binaryReader == null)
										{
											break;
										}
										num = (short)1013186561;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_148:;
								}
								break;
							}
							}
						}
						finally
						{
							num = (short)1593376768;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_180;
									}
									continue;
								case 1:
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)1879441410;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1B6;
								}
								IL_180:
								if (fileStream == null)
								{
									break;
								}
								num = (short)1389428737;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_1B6:;
						}
						num = (short)2001207297;
						if (num != 0)
						{
						}
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.Exception(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("닶诸觺鋼跾℀琂洄渆攈渊ⴌ缎挐簒瘔爖樘栚琜焞䘠̢䘤䈦嬨弪䐬䤮堰倲吴䌶尸ᬺ嬼嘾ⵀ♂罄杆", a_) + ex.Message);
					}
					return result;
				}
				throw new global::System.Exception(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꏶ釸黺\uddfc駾栀漂怄✆礈樊礌朎ㄐ眒稔爖樘㬚猜瀞唠̢䀤弦䀨堪夬ฮ", a_));
			}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003E78 File Offset: 0x00002078
		private static bool a(global::System.Security.Cryptography.X509Certificates.StoreLocation A_0, global::System.Security.Cryptography.X509Certificates.StoreName A_1, global::System.Security.Cryptography.X509Certificates.X509Certificate2 A_2, bool A_3)
		{
			int a_ = 17;
			short num = (short)551419904;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_90;
				}
				global::System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificatesFromStore;
				string cnfromDN;
				bool result;
				for (;;)
				{
					IL_31:
					global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate;
					switch (num2)
					{
					case 0:
						num = (short)989462546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)1433600013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						x509Certificate = enumerator.Current;
						num = (short)1637548039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)2085486608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (x509Certificate.Thumbprint != A_2.Thumbprint)
						{
							num = (short)564330516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AA;
					case 4:
						goto IL_262;
					case 5:
						goto IL_3CB;
					case 6:
					{
						global::System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator enumerator = certificatesFromStore.GetEnumerator();
						num = (short)1598226442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.GetCNfromDN(x509Certificate.SubjectName) == cnfromDN)
						{
							num = (short)226885632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_262;
					case 8:
						num = (short)646643733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (certificatesFromStore != null)
						{
							num = (short)610598920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 10:
						goto IL_262;
					case 11:
						goto IL_402;
					case 12:
						goto IL_262;
					case 13:
						return result;
					case 14:
						goto IL_10A;
					case 15:
						if (x509Certificate.NotBefore < A_2.NotBefore)
						{
							num = (short)2044592142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AA;
					case 16:
					{
						num = (short)1811418292;
						short num3 = num;
						num = (short)1118309556;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_402;
						default:
						{
							num = (short)1354039296;
							if (num != 0)
							{
							}
							num = (short)958398464;
							short num4 = num;
							if (x509Certificate.Issuer == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䄁㤃包嬇☉Ⰻ䄍ⴏ弑笓戕眗栙猛爝䄟紡眣䤥䐧弩堫䜭弯就䜳椵琷眹渻ሽ怿Ł੃筅Շ╉㡋⅍≏㵑㡓㝕ݗख़㍛㉝ᕟᙡൣ॥٧ᥩ㍫⩭ᕯᑱᕳ͵ᑷ๹⍻㵽콿쾁즃즅욇행쾋\ude8d쎏춑\udd93\udb95잗\ud999\udd9b", a_))
							{
								num = (short)319029253;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = false;
							num = (short)1418199044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 17:
						if (!A_3)
						{
							num = (short)862453771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10A;
					case 18:
						if (!(x509Certificate.Issuer == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䄁䨃㬅䔇攉砋愍戏紑砓眕䜗䤙猛爝唟嘡䴣䤥䘧天猫樭唯吱唳䌵吷丹挻紽༿ཁृॅهᕉཋṍ͏൑ᝓ᝕瑗穙፛捝ⵟൡၣ॥ᩧթk཭⽯ⅱ᭳᩵൷๹ᕻᅽꒃ쾅ꂋ꺍펏꾑솓얕", a_)))
						{
							num = (short)1661075458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CB;
					case 19:
						goto IL_262;
					case 20:
						num = (short)1948909583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (certificatesFromStore.Count > 0)
						{
							num = (short)1859321862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_90;
					IL_10A:
					global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.RemoveCertificateToStore(A_0, A_1, x509Certificate);
					num = (short)1617821708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_262:
					num = (short)1385627649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AA:
					result = false;
					num = (short)1625292819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CB:
					num = (short)1819082769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_402:
					num = (short)1975189507;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_90:
				num = (short)891682817;
				if (num != 0)
				{
				}
				result = true;
				cnfromDN = global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.GetCNfromDN(A_2.SubjectName);
				certificatesFromStore = global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.GetCertificatesFromStore(A_0, A_1, global::System.Security.Cryptography.X509Certificates.X509FindType.FindBySubjectName, cnfromDN);
				num = (short)15138825;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000042E4 File Offset: 0x000024E4
		public static global::System.Security.Cryptography.X509Certificates.X509Certificate2Collection GetCertificatesFromStore(global::System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, global::System.Security.Cryptography.X509Certificates.StoreName storeName, global::System.Security.Cryptography.X509Certificates.X509FindType findType, string findValue)
		{
			short num = (short)1998124318;
			short num2 = num;
			num = (short)1827337502;
			global::System.Security.Cryptography.X509Certificates.X509Certificate2Collection result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)1329266688;
				short num3 = num;
				break;
			}
			}
			num = (short)704315392;
			if (num != 0)
			{
			}
			result = null;
			global::System.Security.Cryptography.X509Certificates.X509Store x509Store = new global::System.Security.Cryptography.X509Certificates.X509Store(storeName, storeLocation);
			try
			{
				num = (short)1347944449;
				if (num != 0)
				{
				}
				x509Store.Open(global::System.Security.Cryptography.X509Certificates.OpenFlags.ReadOnly);
				result = x509Store.Certificates.Find(findType, findValue, false);
			}
			finally
			{
				x509Store.Close();
			}
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000043C8 File Offset: 0x000025C8
		public static string GetCNfromDN(global::System.Security.Cryptography.X509Certificates.X500DistinguishedName dn)
		{
			int a_ = 18;
			short num = (short)80084992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				string[] array;
				string result;
				for (;;)
				{
					IL_30:
					int num5;
					switch (num2)
					{
					case 0:
						if (array != null)
						{
							num = (short)472383495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						goto IL_152;
					case 2:
						goto IL_152;
					case 3:
						goto IL_A9;
					case 4:
					{
						string text;
						int num3 = text.IndexOf(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("㸂", a_), global::System.StringComparison.Ordinal);
						result = text.Substring(num3 + 1).Trim();
						num = (short)449445891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)673564684;
						short num4 = num;
						num = (short)890357772;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_137;
						default:
						{
							num = (short)715915264;
							if (num != 0)
							{
							}
							num = (short)1678311425;
							if (num != 0)
							{
							}
							string text;
							if (text.StartsWith(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䀂䬄", a_), global::System.StringComparison.Ordinal))
							{
								num = (short)2115567620;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A9;
						}
						}
						break;
					}
					case 6:
					{
						if (num5 >= array.Length)
						{
							num = (short)1985347592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = array[num5].Trim();
						num = (short)2115371013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num5 = 0;
						goto IL_137;
					case 8:
						return result;
					}
					goto IL_5B;
					IL_A9:
					num5++;
					num = (short)1051656192;
					short num6 = num;
					num = (short)1303248897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_137:
					num = (short)58130434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_152:
					num = (short)612106246;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_5B:
				result = null;
				array = dn.Name.Split(new char[]
				{
					','
				});
				num = (short)1470431232;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004630 File Offset: 0x00002830
		public static string ImportCertificateToStore(string fileName, global::System.Security.SecureString psw, string strStoreLocation, string strStoreName, bool forceReplace)
		{
			short num = (short)39583744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				string result;
				object obj;
				object obj2;
				for (;;)
				{
					IL_27:
					global::System.Security.Cryptography.X509Certificates.StoreLocation storeLocation;
					global::System.Security.Cryptography.X509Certificates.StoreName storeName;
					global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate;
					switch (num2)
					{
					case 0:
					{
						num = (short)1024851968;
						short num3 = num;
						num = (short)734855172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_279;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_15D;
							}
							for (;;)
							{
								IL_FB:
								num = (short)611772938;
								short num4 = num;
								num = (short)490203658;
								global::System.Security.Cryptography.X509Certificates.X509Store x509Store;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)154533888;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_205;
									case 1:
										goto IL_1AA;
									case 2:
										if (global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.a(storeLocation, storeName, x509Certificate, forceReplace))
										{
											num = (short)473104385;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1EC;
									case 3:
										try
										{
											x509Store.Open(global::System.Security.Cryptography.X509Certificates.OpenFlags.ReadWrite);
											x509Store.Add(x509Certificate);
											return result;
										}
										finally
										{
											x509Store.Close();
										}
										goto IL_1EC;
									}
									goto IL_15D;
									IL_1EC:
									num = (short)1344012288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1AA:
								x509Store = new global::System.Security.Cryptography.X509Certificates.X509Store(storeName, storeLocation);
								num = (short)208273411;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_205:
							return result;
							IL_15D:
							result = global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.GetCNfromDN(x509Certificate.SubjectName);
							num = (short)1296629762;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_FB;
						}
						finally
						{
							num = (short)620691457;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)x509Certificate).Dispose();
									num = (short)2012807170;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_23D;
									}
									continue;
								case 2:
									goto IL_276;
								}
								IL_23D:
								if (x509Certificate == null)
								{
									break;
								}
								num = (short)414908416;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_276:;
						}
						goto IL_279;
					case 3:
						num = (short)2111307777;
						if (num != 0)
						{
						}
						if (obj != null)
						{
							num = (short)1974665216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						if (obj2 != null)
						{
							num = (short)2127888385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_42;
					IL_279:
					storeLocation = (global::System.Security.Cryptography.X509Certificates.StoreLocation)obj;
					storeName = (global::System.Security.Cryptography.X509Certificates.StoreName)obj2;
					global::System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags = global::System.Security.Cryptography.X509Certificates.X509KeyStorageFlags.PersistKeySet;
					x509Certificate = new global::System.Security.Cryptography.X509Certificates.X509Certificate2(fileName, psw, keyStorageFlags);
					num = (short)840302594;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_42:
				obj = global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.ParseEnum(typeof(global::System.Security.Cryptography.X509Certificates.StoreLocation), strStoreLocation);
				obj2 = global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.ParseEnum(typeof(global::System.Security.Cryptography.X509Certificates.StoreName), strStoreName);
				result = string.Empty;
				num = (short)309395459;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000495C File Offset: 0x00002B5C
		private static string a(string A_0)
		{
			int a_ = 13;
			short num = (short)213975040;
			short num2 = num;
			global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(A_0, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뷽仿㼁弃䜅┇倉洋⌍樏休㼓", a_));
			if (!match.Success)
			{
				num = (short)876350083;
				short num3 = num;
				num = (short)1833241219;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1012858881;
					if (num != 0)
					{
					}
					num = (short)1568931840;
					if (num != 0)
					{
					}
					return "";
				}
			}
			return match.Value.Replace(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뷽仿㼁", a_), "");
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004A54 File Offset: 0x00002C54
		public static bool IsCustomerCertificateInStore(global::System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, global::System.Security.Cryptography.X509Certificates.StoreName storeName, string commonName)
		{
			int a_ = 6;
			short num;
			for (;;)
			{
				num = (short)659161088;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)595918848;
					short num3 = num;
					num = (short)1236621986;
					short num4 = num;
					num = (short)1225939618;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_86;
					}
					break;
				}
				}
			}
			IL_86:
			num = (short)1054474240;
			if (num != 0)
			{
			}
			bool result = false;
			global::System.Security.Cryptography.X509Certificates.X509Store x509Store = new global::System.Security.Cryptography.X509Certificates.X509Store(storeName, storeLocation);
			try
			{
				switch (0)
				{
				case 0:
					goto IL_F5;
				}
				int num2;
				global::System.Security.Cryptography.X509Certificates.X509Certificate2Collection x509Certificate2Collection;
				for (;;)
				{
					IL_B2:
					switch (num2)
					{
					case 0:
						goto IL_32A;
					case 1:
						if (x509Certificate2Collection.Count > 0)
						{
							num = (short)1853685768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32A;
					case 2:
						if (x509Certificate2Collection != null)
						{
							num = (short)1153630213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32A;
					case 3:
						goto IL_342;
					case 4:
					{
						global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate;
						if (global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.GetCNfromDN(x509Certificate.SubjectName) == commonName)
						{
							num = (short)1040711691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_244;
					}
					case 5:
						num = (short)762183681;
						if (num != 0)
						{
						}
						num = (short)1053556737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate;
						if (x509Certificate.Issuer != global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("듶쓸껺껼폾℀䰂㠄䨆昈缊戌紎縐缒琔䠖䨘琚焜樞唠䨢䨤䤦娨琪愬戮挰ἲᔴ琶眸غ瀼倾㕀ⱂ㝄⡆╈⩊ቌᱎ㹐㽒⁔⍖じ㑚㍜ⱞ㹠❢dŦࡨṪŬ᭮⹰ひ㩴㩶㑸㑺㍼⁾슀펂횄\ud886삈욊튌첎킐", a_))
						{
							num = (short)1969618953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_244;
					}
					case 7:
					{
						global::System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)2107637760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate = enumerator.Current;
						num = (short)2054029316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator enumerator = x509Certificate2Collection.GetEnumerator();
						num = (short)818741261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						result = true;
						num = (short)703266826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_244;
					case 11:
						num = (short)1897594894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)895418374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_244;
					case 14:
					{
						global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate;
						if (x509Certificate.Issuer != global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("듶럸웺냼郾甀氂眄栆攈樊刌導縐缒怔挖瀘琚猜氞縠朢䀤䄦䠨帪䄬嬮渰瀲稴稶琸琺猼怾ɀፂᙄᡆੈ੊慌潎Ṑ湒ᡔ㡖ⵘ㑚⽜ぞൠɢ㩤㑦٨ݪᡬ᭮ᡰᱲ᭴Ѷ奸㉺፼᱾궀ꎂ욄몆\udc88\ud88a", a_))
						{
							num = (short)1859452940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_244;
					}
					}
					goto IL_F5;
					IL_244:
					num = (short)806223879;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32A:
					num = (short)1236926467;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_342:
				return result;
				IL_F5:
				x509Store.Open(global::System.Security.Cryptography.X509Certificates.OpenFlags.ReadOnly);
				x509Certificate2Collection = x509Store.Certificates.Find(global::System.Security.Cryptography.X509Certificates.X509FindType.FindBySubjectName, commonName, false);
				num = (short)649658370;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_B2;
			}
			finally
			{
				x509Store.Close();
			}
			return result;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004DCC File Offset: 0x00002FCC
		public static bool IsCertificateInStore(global::System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, global::System.Security.Cryptography.X509Certificates.StoreName storeName, global::System.Security.Cryptography.X509Certificates.X509FindType findType, string findValue)
		{
			int a_ = 7;
			short num = (short)1508048897;
			if (num != 0)
			{
			}
			num = (short)772341760;
			short num2 = num;
			num = (short)582014781;
			short num3 = num;
			num = (short)532338493;
			bool result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)310575104;
				if (num != 0)
				{
				}
				result = false;
				global::System.Security.Cryptography.X509Certificates.X509Store x509Store = new global::System.Security.Cryptography.X509Certificates.X509Store(storeName, storeLocation);
				try
				{
					x509Store.Open(global::System.Security.Cryptography.X509Certificates.OpenFlags.ReadOnly);
					result = (x509Store.Certificates.Find(findType, findValue, false).Count > 0);
				}
				catch (global::System.Exception ex)
				{
					global::System.Console.WriteLine(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("엷쟹뗻跽䏿朁瘃爅愇氉攋洍焏昑焓引瘗䤙栛焝刟䜡ᤣᬥ", a_) + ex.Message);
					throw;
				}
				finally
				{
					x509Store.Close();
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004EF4 File Offset: 0x000030F4
		public static void RemoveCertificateToStore(global::System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, global::System.Security.Cryptography.X509Certificates.StoreName storeName, global::System.Security.Cryptography.X509Certificates.X509Certificate2 cert)
		{
			short num = (short)245797062;
			short num2 = num;
			num = (short)1675661510;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_BB:
				num = (short)1242038273;
				if (num != 0)
				{
				}
				goto IL_FB;
			default:
			{
				num = (short)1495990272;
				if (num != 0)
				{
				}
				num = (short)1398013952;
				short num3 = num;
				num = (short)210632705;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				IL_92:
				switch (num4)
				{
				case 0:
					goto IL_BB;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_A4;
					}
					continue;
				case 2:
					goto IL_11C;
				}
				IL_A4:
				if (cert == null)
				{
					return;
				}
				num = (short)574226432;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_11C:
			global::System.Security.Cryptography.X509Certificates.X509Store x509Store;
			try
			{
				x509Store.Open(global::System.Security.Cryptography.X509Certificates.OpenFlags.ReadWrite);
				x509Store.Remove(cert);
				return;
			}
			finally
			{
				x509Store.Close();
			}
			IL_FB:
			x509Store = new global::System.Security.Cryptography.X509Certificates.X509Store(storeName, storeLocation);
			num = (short)900530178;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_92;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005030 File Offset: 0x00003230
		public static object ParseEnum(global::System.Type T, string name)
		{
			short num = (short)1486487552;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				object result;
				int num3;
				string[] names;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						IL_123:
						goto IL_70;
					case 1:
						goto IL_1A4;
					case 2:
					{
						string value;
						if (string.Equals(value, name, global::System.StringComparison.OrdinalIgnoreCase))
						{
							num = (short)1521352708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_70;
					}
					case 3:
						goto IL_16C;
					case 4:
					{
						string value;
						result = global::System.Enum.Parse(T, value);
						num = (short)681771008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_16C;
					case 6:
					{
						if (num3 >= names.Length)
						{
							num = (short)550305793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string value = names[num3];
						num = (short)2118189058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_4B;
					IL_70:
					num = (short)551847514;
					short num4 = num;
					num = (short)1847428698;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_123;
					default:
						num = (short)501415937;
						if (num != 0)
						{
						}
						num = (short)1823277056;
						if (num != 0)
						{
						}
						num3++;
						num = (short)204341253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_16C:
					num = (short)621412358;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A4:
				num = (short)1954283520;
				short num5 = num;
				return result;
				IL_4B:
				result = null;
				names = global::System.Enum.GetNames(T);
				num3 = 0;
				num = (short)123469827;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0400000A RID: 10
		private const string a = "CN=Motorola_Solutions_Default_COMMON_CPS_CA, O=Motorola_Solutions Inc, C=US";

		// Token: 0x0400000B RID: 11
		private const string b = "C=US, O=Motorola_Solutions_LMR, CN=Motorola_Solutions_Default_COMMON_CPS_IM_CA";

		// Token: 0x0400000C RID: 12
		private const string c = "aptDpCfg.info";

		// Token: 0x0400000D RID: 13
		private const string d = "aptDp.info";
	}
}
