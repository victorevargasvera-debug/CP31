using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Motorola.Security.SamlCommonUtility.DMHttpClients
{
	// Token: 0x0200002C RID: 44
	public class DMHttpClientFactory<T> where T : class
	{
		// Token: 0x06000083 RID: 131 RVA: 0x0000A2C4 File Offset: 0x000084C4
		private DMHttpClientFactory()
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000A2D8 File Offset: 0x000084D8
		public static T Create(string accessToken = null, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<string, string>> headers = null)
		{
			int a_ = 13;
			short num = (short)1731000437;
			short num2 = num;
			num = (short)2123626613;
			global::System.Net.Http.HttpClient httpClient;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_258:
				num = (short)1472921601;
				if (num != 0)
				{
				}
				httpClient.DefaultRequestHeaders.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("\uddb7\udbb9캻\udbbd늿", a_), accessToken);
				num = (short)1331036161;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)62980096;
				if (num != 0)
				{
				}
				num = (short)1862533120;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_A0;
					}
					break;
				}
				break;
			}
			for (;;)
			{
				IL_79:
				switch (num3)
				{
				case 0:
					if (headers != null)
					{
						num = (short)1384054784;
						short num4 = num;
						num = (short)776994823;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_340;
				case 1:
					goto IL_2B8;
				case 2:
				{
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator = headers.GetEnumerator();
					num = (short)2093023238;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (!string.IsNullOrEmpty(accessToken))
					{
						num = (short)216334341;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B8;
				case 4:
					if (headers.Count > 0)
					{
						num = (short)2147287042;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_340;
				case 5:
					goto IL_DC;
				case 6:
					try
					{
						num = (short)1842675714;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								num = (short)608632836;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)972750848;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator.Current;
								httpClient.DefaultRequestHeaders.Add(keyValuePair.Key, keyValuePair.Value);
								num = (short)865533955;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_11B;
								}
								continue;
							case 4:
								goto IL_1A5;
							}
							IL_11D:
							num = (short)1390542849;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_11B:
							goto IL_11D;
						}
						IL_1A5:
						goto IL_340;
					}
					finally
					{
						num = (short)350224384;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator;
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1DD;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)587530242;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_214;
							}
							IL_1DD:
							if (enumerator == null)
							{
								break;
							}
							num = (short)918749185;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_214:;
					}
					goto IL_217;
				case 7:
					goto IL_217;
				}
				goto IL_A0;
				IL_217:
				num = (short)1759969284;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B8:
				num = (short)105840640;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_DC:
			goto IL_258;
			IL_340:
			global::Motorola.Security.SamlCommonUtility.DMHttpClients.CommonHttpClientHandler commonHttpClientHandler = new global::Motorola.Security.SamlCommonUtility.DMHttpClients.CommonHttpClientHandler(httpClient);
			return (T)((object)global::System.Activator.CreateInstance(global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMHttpClientFactory<T>.a(), new object[]
			{
				commonHttpClientHandler
			}));
			IL_A0:
			httpClient = new global::System.Net.Http.HttpClient();
			num = (short)1083179011;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_79;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000A658 File Offset: 0x00008858
		private static global::System.Type a()
		{
			int a_ = 17;
			short num = (short)1655504898;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_151;
				case 1:
					goto IL_1A4;
				case 2:
					num = (short)1479999489;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_74;
					}
					continue;
				case 3:
					goto IL_206;
				case 4:
					if (typeof(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMStorageServiceClient).IsAssignableFrom(typeof(T)))
					{
						num = (short)1964834819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23B;
				case 5:
					if (typeof(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMAgencyAdminServiceClient).IsAssignableFrom(typeof(T)))
					{
						num = (short)23527424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1976762372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					if (typeof(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMAuthorizationServiceClient).IsAssignableFrom(typeof(T)))
					{
						num = (short)1646723073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1381631571;
					short num3 = num;
					num = (short)1221854803;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B1;
					default:
						num = (short)976158720;
						if (num != 0)
						{
						}
						num = (short)385810437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_A6;
				}
				IL_74:
				if (typeof(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMIdPDiscoveryClient).IsAssignableFrom(typeof(T)))
				{
					num = (short)1644494855;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)30539782;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_A6:
			goto IL_1B1;
			IL_151:
			return typeof(global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMAgencyAdminServiceClient);
			IL_1A4:
			num = (short)501940224;
			short num4 = num;
			return typeof(global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMAuthorizationServiceClient);
			IL_1B1:
			return typeof(global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMIdPDiscoveryClient);
			IL_206:
			return typeof(global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMStorageServiceClient);
			IL_23B:
			throw new global::System.NotSupportedException(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("풻ힽ뎿냃뿅룇꿉ꟍꏏ뫓맕곗龎꿛ꯝ郟鋡诣铥鳧迩裫샭", a_));
		}
	}
}
