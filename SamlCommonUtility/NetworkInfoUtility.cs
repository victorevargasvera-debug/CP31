using System;
using System.Net;
using System.Net.NetworkInformation;
using Motorola.Security.SamlCommonUtility.DMHttpClients;

namespace Motorola.Security.SamlCommonUtility
{
	// Token: 0x02000011 RID: 17
	public class NetworkInfoUtility
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00004548 File Offset: 0x00002748
		public static string GetLocalHostName()
		{
			short num = (short)1764847907;
			short num2 = num;
			num = (short)1932882211;
			switch (num2 == num)
			{
			}
			num = (short)666763265;
			if (num != 0)
			{
			}
			num = (short)919863296;
			if (num != 0)
			{
			}
			num = (short)1901330432;
			short num3 = num;
			return global::System.Net.Dns.GetHostName();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000045F4 File Offset: 0x000027F4
		public static string GetLocalHostFQDN()
		{
			int a_ = 12;
			short num = (short)1640169472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				string text;
				for (;;)
				{
					num = (short)1407451137;
					if (num != 0)
					{
					}
					num = (short)1066729472;
					short num3 = num;
					text = string.Empty;
					string text2 = string.Empty;
					try
					{
						text2 = global::System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
						goto IL_1B9;
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.Exception(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("얶쮸풺쾼龾돀ꛂ뇄뗆곈ꋊ믌ꛎ뿐듒ꏖ뇘뻚﷜닞胠胢跤軦蟨軪췬诮黰黲铴黶韸\udbfa鏼黾氀昂┄⨆⤈", a_) + ex.Message, ex);
					}
					goto IL_1ED;
					for (;;)
					{
						IL_1B9:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_B1;
							}
							for (;;)
							{
								IL_92:
								switch (num2)
								{
								case 0:
									num = (short)1588592642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_196;
								case 2:
									if (!text.ToUpperInvariant().EndsWith(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("鮴", a_) + text2.ToUpperInvariant(), global::System.StringComparison.Ordinal))
									{
										num = (short)959184901;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_17D;
								case 3:
									goto IL_17D;
								case 4:
									if (!string.IsNullOrEmpty(text2))
									{
										num = (short)1318912000;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_17D;
								case 5:
									text = text + global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("鮴", a_) + text2;
									num = (short)254279683;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_B1;
								IL_17D:
								num = (short)2075590657;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_196:
							break;
							IL_B1:
							text = global::System.Net.Dns.GetHostName();
							num = (short)2026045444;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_92;
						}
						catch (global::System.Exception ex2)
						{
							throw new global::System.Exception(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("얶쮸풺쾼龾뛀ꯂ계ꯆ곈뿌꫎ꗐꇒ냔뻖꿘닚돜룞쇠韢跤苦짨蟪苬賮郰鿲헴鿶雸裺觼\udffe最爂愄椆⤈☊ⴌ", a_) + ex2.Message, ex2);
						}
					}
					IL_1ED:
					num = (short)272153644;
					short num4 = num;
					num = (short)1852554284;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_222;
					}
				}
				IL_222:
				num = (short)1583677440;
				if (num != 0)
				{
				}
				return text;
			}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004870 File Offset: 0x00002A70
		public static bool IsLocalHost(string hostname)
		{
			int a_ = 16;
			short num = (short)335609856;
			switch (num)
			{
			default:
			{
				bool flag;
				for (;;)
				{
					flag = false;
					if (!string.IsNullOrEmpty(hostname))
					{
						num = (short)967245824;
						short num2 = num;
						try
						{
							num = (short)1737621517;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int num5;
								switch (num3)
								{
								case 0:
								{
									string hostName;
									if (!string.Equals(hostname, hostName, global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)1866399759;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag = true;
									num = (short)1456013315;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_1ED;
								case 2:
								{
									int num4;
									global::System.Net.IPAddress[] array;
									if (num4 >= array.Length)
									{
										num = (short)1052114961;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2132803592;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_4FA;
								case 4:
								{
									string localHostFQDN;
									if (!string.Equals(hostname, localHostFQDN, global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)1440219159;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag = true;
									num = (short)1864105990;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_3D4;
								case 6:
									goto IL_4FA;
								case 7:
									if (!flag)
									{
										num = (short)748879873;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4FA;
								case 8:
								{
									int num4;
									global::System.Net.IPAddress[] array;
									global::System.Net.IPAddress ipaddress;
									if (string.Equals(array[num4].ToString(), ipaddress.ToString(), global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)1936719882;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num4++;
									num = (short)750649363;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_4B8;
								case 10:
									flag = true;
									num = (short)406388758;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::System.Net.IPAddress ipaddress;
									if (global::System.Net.IPAddress.IsLoopback(ipaddress))
									{
										num = (short)1605042188;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)657129488;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									flag = true;
									num = (short)906297369;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									switch (0)
									{
									case 0:
										goto IL_102;
									}
									continue;
								case 14:
								{
									global::System.Net.IPAddress[] hostAddresses;
									global::System.Net.IPAddress[] array2 = hostAddresses;
									num5 = 0;
									num = (short)1401225234;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
								{
									string localHostFQDN = global::Motorola.Security.SamlCommonUtility.NetworkInfoUtility.GetLocalHostFQDN();
									num = (short)361627652;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
								{
									global::System.Net.IPAddress[] hostAddresses2;
									if (hostAddresses2 != null)
									{
										num = (short)808255516;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1ED;
								}
								case 17:
									goto IL_415;
								case 18:
									goto IL_3D4;
								case 19:
									goto IL_4B8;
								case 20:
								{
									global::System.Net.IPAddress[] array2;
									if (num5 >= array2.Length)
									{
										num = (short)567279646;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Net.IPAddress ipaddress = array2[num5];
									num = (short)1218117643;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 21:
									goto IL_4FA;
								case 22:
									goto IL_415;
								case 23:
								{
									string hostName;
									global::System.Net.IPAddress[] hostAddresses2 = global::System.Net.Dns.GetHostAddresses(hostName);
									global::System.Net.IPAddress[] hostAddresses = global::System.Net.Dns.GetHostAddresses(hostname);
									num = (short)820051997;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 24:
								{
									string hostName = global::System.Net.Dns.GetHostName();
									num = (short)668467200;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 25:
									goto IL_4FA;
								case 26:
									goto IL_4FA;
								case 27:
									goto IL_513;
								case 28:
								{
									global::System.Net.IPAddress[] hostAddresses2;
									global::System.Net.IPAddress[] array = hostAddresses2;
									int num4 = 0;
									num = (short)1219887113;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 29:
								{
									global::System.Net.IPAddress[] hostAddresses;
									if (hostAddresses != null)
									{
										num = (short)470351886;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4FA;
								}
								case 30:
									num = (short)217645082;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_102:
								if (!string.Equals(hostname, global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("햸풺\udebc\udebe귀ꯂ꫄듆뷈", a_), global::System.StringComparison.OrdinalIgnoreCase))
								{
									num = (short)1762525208;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								flag = true;
								num = (short)1978466325;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_1ED:
								num5++;
								num = (short)1297940485;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_3D4:
								num = (short)407306260;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_415:
								num = (short)1784414215;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_4B8:
								num = (short)368312322;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_4FA:
								num = (short)700907547;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_513:;
						}
						catch (global::System.Exception ex)
						{
							global::System.Console.WriteLine(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("풺\udebc\udebe귀귄꣆뫈뿊많냐뿒볔돖룘꿚드냞迠쏢胤鿦諨軪鷬鯮飰鳲鯴ퟶ퓸\udbfa볼賾爀瘂栄渆月氊ⴌ笎礐瘒㔔编瘘栚検㼞䠠倢Ԥ䤦䘨弪ബ䌮帰倲吴嬶᜸ᔺጼ", a_) + ex.Message, ex);
						}
					}
					num = (short)2023371208;
					short num6 = num;
					num = (short)1222324680;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_56F;
					}
				}
				IL_56F:
				num = (short)856555520;
				if (num != 0)
				{
				}
				num = (short)1866727425;
				if (num != 0)
				{
				}
				return flag;
			}
			}
		}
	}
}
