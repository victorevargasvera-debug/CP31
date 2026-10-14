using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Discovery;
using System.ServiceModel.Security.Tokens;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Win32;
using Motorola.Common.Cryptography;
using Motorola.Common.Cryptography.Exceptions;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.Security.SamlCommonUtility;

namespace Motorola.Security.SamlTokenComponent
{
	// Token: 0x0200000A RID: 10
	public static class SamlTokenHelper
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00005FA8 File Offset: 0x000041A8
		static SamlTokenHelper()
		{
			short num = (short)2126141805;
			short num2 = num;
			num = (short)857954669;
			switch (num2 == num)
			{
			}
			num = (short)1801846784;
			short num3 = num;
			num = (short)847314945;
			if (num != 0)
			{
			}
			num = (short)1917059072;
			if (num != 0)
			{
			}
			global::System.Net.ServicePointManager.ServerCertificateValidationCallback = new global::System.Net.Security.RemoteCertificateValidationCallback(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006068 File Offset: 0x00004268
		private static bool a(object A_0, global::System.Security.Cryptography.X509Certificates.X509Certificate A_1, global::System.Security.Cryptography.X509Certificates.X509Chain A_2, global::System.Net.Security.SslPolicyErrors A_3)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			bool flag;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_6F;
				case 1:
					goto IL_6F;
				case 2:
					if (!flag)
					{
						num2 = (short)324730880;
						short num3 = num2;
						num2 = (short)2052063236;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 3:
				{
					flag = true;
					num2 = (short)1002793594;
					short num4 = num2;
					num2 = (short)2080336506;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						num2 = (short)1033306112;
						if (num2 != 0)
						{
						}
						num2 = (short)735707136;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_C9;
				case 5:
					flag = true;
					num2 = (short)1179910145;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if ((A_3 & global::System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors) == global::System.Net.Security.SslPolicyErrors.None)
					{
						num2 = (short)146997253;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6F;
				case 7:
					if (A_3 == global::System.Net.Security.SslPolicyErrors.None)
					{
						num2 = (short)683147267;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1828978694;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_39;
				IL_6F:
				num2 = (short)1739587586;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_C9:
			num2 = (short)1789853697;
			if (num2 != 0)
			{
			}
			throw new global::System.Security.SecurityException(string.Format(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("럳鏵諷軹闻飽槿愁攃爅洇⨉攋納』簑笓戕㠗氙紛爝䤟䘡ḣإ匧ᨩ儫อᴯሱ伳ܵ䔷", a_), A_3, A_1.Subject));
			IL_39:
			flag = false;
			num2 = (short)1276116999;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006254 File Offset: 0x00004454
		public static global::System.ServiceModel.ChannelFactory<TChannel> CreateClientChannel<TChannel>(string currentUserType, string authType, string targetHost, int targetPort, string tokenIssuerHost, string svcType, string federatedEndpointName, string pac = "", string userName = null, global::System.Security.SecureString pswd = null, bool activating = false, string oneTimePassword = "", string jwtToken = "") where TChannel : class
		{
			int a_ = 17;
			global::System.ServiceModel.ChannelFactory<TChannel> channelFactory = null;
			short num;
			try
			{
				num = (short)1920860169;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(channelFactory, userName, pswd);
						num = (short)1501626371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						channelFactory = new global::System.ServiceModel.ChannelFactory<TChannel>(federatedEndpointName);
						global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.AddCustomAttribute((global::System.ServiceModel.Channels.CustomBinding)channelFactory.Endpoint.Binding, currentUserType, authType, svcType, tokenIssuerHost, targetPort, pac, activating, oneTimePassword, false, jwtToken);
						num = (short)768212996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)567869447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_122;
					case 4:
						if (authType == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䄁愃琅簇按樋服猏猑怓猕", a_))
						{
							num = (short)849281030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)40435720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_122;
					case 6:
						channelFactory.SetCertificate();
						num = (short)1906966533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_1C7;
					case 8:
						if (authType == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("圁眃挅稇䐉洋挍甏", a_))
						{
							num = (short)1401683968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_122;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					IL_59:
					if (global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(currentUserType, federatedEndpointName))
					{
						num = (short)1141571585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_122:
					global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(channelFactory, targetHost, targetPort);
					num = (short)1822687234;
					num2 = (int)((global::System.IntPtr)num);
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䬁椃瘅稇攉簋欍戏縑洓㘕笗甙爛砝䤟䔡儣吥䴧丩ఫ䬭帯嘱䐳夵儷吹䠻ḽ愿", a_));
				IL_1C7:;
			}
			catch
			{
				if (channelFactory == null)
				{
					goto IL_1D7;
				}
				IL_1CF:
				((global::System.IDisposable)channelFactory).Dispose();
				IL_1D7:
				num = (short)1611120469;
				short num3 = num;
				num = (short)104775509;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1CF;
				default:
					num = (short)2029977600;
					if (num != 0)
					{
					}
					throw;
				}
			}
			num = (short)114556929;
			if (num != 0)
			{
			}
			num = (short)1492320256;
			short num4 = num;
			return channelFactory;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000064F4 File Offset: 0x000046F4
		public static global::System.ServiceModel.ChannelFactory<TChannel> CreateClientChannelEx2<TChannel>(string currentUserType, string authType, string discoveryHost, int discoveryPort, string svcType, string pac = "", string userName = null, global::System.Security.SecureString pswd = null, bool activating = false, int retryCount = 5, int retryInterval = 2000, string oneTimePassword = "", string jwtToken = "") where TChannel : class
		{
			int a_ = 8;
			global::System.ServiceModel.ChannelFactory<TChannel> channelFactory = null;
			global::System.ServiceModel.EndpointAddress endpointAddress = new global::System.ServiceModel.EndpointAddress(string.Concat(new string[]
			{
				global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("釸迺觼迾爀㤂⨄⠆", a_),
				discoveryHost,
				global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("쏸", a_),
				discoveryPort.ToString(),
				global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("훸뿺铼賾戀氂猄戆笈爊∌崎尐䀒瀔攖漘爚縜稞氠䈢䬤䘦丨个䀬䨮弰䜲", a_)
			}));
			global::System.ServiceModel.ChannelFactory<TChannel> result;
			short num;
			try
			{
				channelFactory = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a<TChannel>(currentUserType, authType, endpointAddress, discoveryHost, discoveryPort, svcType, pac, userName, pswd, activating, oneTimePassword, jwtToken);
				global::System.Console.WriteLine(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뫸鏺鳼釾漀昂椄✆漈樊渌笎縐愒气㜖稘椚砜縞唠䘢䄤ܦ娨帪丬䰮吰䀲䘴儶䰸场儼䘾筀捂㹄睆㑈", a_), endpointAddress.ToString());
				result = channelFactory;
			}
			catch (global::System.Exception ex)
			{
				if (channelFactory == null)
				{
					goto IL_A3;
				}
				IL_9B:
				((global::System.IDisposable)channelFactory).Dispose();
				IL_A3:
				num = (short)1852144336;
				short num2 = num;
				num = (short)178682576;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_9B;
				default:
					num = (short)92209152;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CANNOT_CONNECT_TO_TARGET_SERVER, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뫸髺鏼釾渀眂┄搆昈攊挌樎爐朒㔔挖瘘㬚検眞䐠̢儤䘦嬨䰪䠬嬮ᄰ怲倴䔶伸帺似", a_), ex);
				}
			}
			num = (short)1405288449;
			if (num != 0)
			{
			}
			num = (short)819986432;
			short num3 = num;
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000666C File Offset: 0x0000486C
		public static global::System.ServiceModel.ChannelFactory<TChannel> CreateClientChannelEx<TChannel>(string currentUserType, string authType, string discoveryHost, int discoveryPort, string svcType, string pac = "", string userName = null, global::System.Security.SecureString pswd = null, bool activating = false, int retryCount = 5, int retryInterval = 2000, string oneTimePassword = "", string jwtToken = "") where TChannel : class
		{
			int a_ = 19;
			short num = (short)116260864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A5;
				}
				global::System.ServiceModel.Discovery.DiscoveryClient discoveryClient;
				global::System.Collections.ObjectModel.Collection<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> collection;
				global::System.ServiceModel.ChannelFactory<TChannel> channelFactory;
				for (;;)
				{
					IL_32:
					global::System.Collections.Generic.IEnumerable<global::System.Uri> scopes;
					global::System.Func<global::System.Uri, bool> predicate;
					string a_2;
					switch (num2)
					{
					case 0:
						try
						{
							collection = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(discoveryClient, typeof(TChannel), svcType, 2);
							goto IL_856;
						}
						catch (global::System.Exception ex)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CANNOT_CONNECT_TO_DISCOVERYSERVER, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䜃朅昇搉挋稍』焑笓砕瘗缙缛樝\u001f嘡䬣إ尧䈩䤫อ琯嬱䜳唵圷䰹夻䰽㤿扁ᝃ⍅㩇㱉⥋㱍", a_), ex);
						}
						finally
						{
							try
							{
								num = (short)1003487241;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_41D;
									case 1:
									{
										num = (short)915939699;
										short num3 = num;
										num = (short)717300083;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_467;
										default:
											num = (short)1779957760;
											if (num != 0)
											{
											}
											num = (short)2101346307;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_41D;
									case 3:
										if (discoveryClient.InnerChannel.State == global::System.ServiceModel.CommunicationState.Opened)
										{
											num = (short)2074935304;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)273416196;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										if (discoveryClient.InnerChannel.State == global::System.ServiceModel.CommunicationState.Faulted)
										{
											goto IL_467;
										}
										goto IL_41D;
									case 5:
										goto IL_517;
									case 6:
										discoveryClient.InnerChannel.Abort();
										num = (short)988086272;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_52F;
									case 8:
										discoveryClient.InnerChannel.Close();
										num = (short)367591426;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										switch (0)
										{
										case 0:
											goto IL_3B1;
										}
										continue;
									}
									IL_3B1:
									if (discoveryClient != null)
									{
										num = (short)263192577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_517;
									IL_41D:
									discoveryClient.Close();
									num = (short)353501189;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_467:
									num = (short)1607794694;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_517:
									num = (short)1356922887;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_52F:;
							}
							catch
							{
							}
						}
						goto Block_8;
						IL_856:
						num = (short)1981284363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_2BB;
					case 2:
						if (discoveryClient == null)
						{
							num = (short)1433993225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1472856064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(collection, currentUserType);
						num = (short)824311831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)2105606154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						try
						{
							discoveryClient = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(currentUserType, authType, discoveryHost, discoveryPort, pac, userName, pswd, activating, oneTimePassword, false, jwtToken);
							goto IL_81A;
						}
						catch (global::System.Exception ex2)
						{
							try
							{
								num = (short)37552137;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_736;
									case 1:
										num = (short)518979586;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										if (discoveryClient.InnerChannel.State == global::System.ServiceModel.CommunicationState.Opened)
										{
											num = (short)1878392835;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1368326148;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										discoveryClient.InnerChannel.Close();
										num = (short)1626537992;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										if (discoveryClient.InnerChannel.State == global::System.ServiceModel.CommunicationState.Faulted)
										{
											num = (short)1131216902;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_715;
									case 5:
										goto IL_715;
									case 6:
										discoveryClient.InnerChannel.Abort();
										num = (short)505151493;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_74E;
									case 8:
										goto IL_715;
									case 9:
										switch (0)
										{
										case 0:
											goto IL_627;
										}
										continue;
									}
									IL_627:
									if (discoveryClient != null)
									{
										num = (short)935133185;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_736;
									IL_715:
									discoveryClient.Close();
									num = (short)1743847424;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_736:
									num = (short)18612231;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_74E:;
							}
							catch
							{
							}
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CANNOT_CONNECT_TO_DISCOVERYSERVER, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䜃朅昇搉挋稍』焑笓砕瘗缙缛樝\u001f嘡䬣إ尧䈩䤫อ琯嬱䜳唵圷䰹夻䰽㤿扁ᝃ⍅㩇㱉⥋㱍", a_), ex2);
						}
						goto IL_76D;
						IL_81A:
						num = (short)423297026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1305411598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)964624399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_938;
					case 9:
						goto IL_851;
					case 10:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						scopes = endpointDiscoveryMetadata.Scopes;
						if ((predicate = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c__4<TChannel>.<>9__4_0) == null)
						{
							goto IL_76D;
						}
						goto IL_2D4;
					}
					case 11:
						if (collection != null)
						{
							num = (short)680198164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9;
					case 12:
						goto IL_59B;
					case 13:
						if (collection.Count > 0)
						{
							num = (short)1274347523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9;
					case 14:
						goto IL_7E8;
					case 15:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						if (endpointDiscoveryMetadata.Scopes.Count > 0)
						{
							num = (short)1486225412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59B;
					}
					case 16:
						num = (short)278134809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_EA;
					case 18:
						if (collection.Count < 1)
						{
							num = (short)2139029512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return channelFactory;
					case 19:
						goto IL_535;
					case 20:
					{
						num = (short)1300299776;
						short num4 = num;
						num = (short)1948319757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						global::System.ServiceModel.EndpointAddress endpointAddress = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(endpointDiscoveryMetadata.Address, discoveryHost);
						a_2 = null;
						num = (short)206045206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						if (endpointDiscoveryMetadata.Scopes != null)
						{
							num = (short)78118919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59B;
					}
					case 23:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						if (endpointDiscoveryMetadata != null)
						{
							num = (short)1773273109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1945305089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_EA;
					case 25:
						if (collection == null)
						{
							num = (short)41025542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)44892178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (retryCount-- < 0)
						{
							num = (short)600899600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1278476293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A5;
					IL_C9:
					global::System.Threading.Thread.Sleep(retryInterval);
					num = (short)224526353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EA:
					num = (short)1497563162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_59B:
					num = (short)1631977491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_535:
						global::System.ServiceModel.EndpointAddress endpointAddress;
						channelFactory = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a<TChannel>(currentUserType, authType, endpointAddress, discoveryHost, discoveryPort, a_2, pac, userName, pswd, activating, oneTimePassword, jwtToken);
						global::System.Console.WriteLine(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䜃清椇搉戋欍簏㈑爓眕笗渙猛氝够ȡ䜣吥䴧䬩堫䬭启ሱ䜳䌵嬷夹夻䴽㌿⑁ㅃ⩅⑇㍉癋湍⭏扑⥓", a_), endpointAddress.ToString());
						return channelFactory;
					}
					catch (global::System.Exception ex3)
					{
						if (channelFactory != null)
						{
							((global::System.IDisposable)channelFactory).Dispose();
						}
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CANNOT_CONNECT_TO_TARGET_SERVER, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䜃朅昇搉挋稍』焑笓砕瘗缙缛樝\u001f嘡䬣إ尧䈩䤫อ䐯匱䘳儵崷丹᰻洽┿ぁ㉃⍅㩇", a_), ex3);
					}
					goto IL_59B;
					IL_2D4:
					a_2 = global::Motorola.Security.SamlCommonUtility.TypeConverter.GetServiceTypeFromServerScope(scopes.Where(predicate).Select(new global::System.Func<global::System.Uri, string>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c__4<TChannel>.<>9.b)).FirstOrDefault<string>());
					num = (short)44367884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_76D:
					predicate = (global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c__4<TChannel>.<>9__4_0 = new global::System.Func<global::System.Uri, bool>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c__4<TChannel>.<>9.a));
					goto IL_2D4;
				}
				return channelFactory;
				IL_2BB:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ServiceNotCompatibleWithClientVersion, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䜃樅愇漉戋稍』搑焓搕欗猙猛瀝\u001f䬡圣إ䄧䐩伫䄭崯䈱唳䈵儷堹倻嬽怿㕁ⵃ㉅⁇橉㡋♍㕏牑❓㍕⩗ⱙ㥛ⱝ也", a_));
				IL_7E8:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.TARGET_SERVER_NOT_AVAILABLE, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("倃清洇⨉砋漍戏甑焓戕㠗䤙礛氝嘟䜡嘣إ䄧天ఫ䀭弯䘱ᐳ圵丷嬹唻刽ℿ⁁⡃⍅", a_));
				IL_851:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CANNOT_CONNECT_TO_DISCOVERYSERVER, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䜃朅昇搉挋稍』焑笓砕瘗缙缛樝\u001f嘡䬣إ尧䈩䤫อ琯嬱䜳唵圷䰹夻䰽㤿扁ᝃ⍅㩇㱉⥋㱍", a_));
				IL_938:
				num = (short)36110337;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.TARGET_SERVER_NOT_AVAILABLE, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("倃清洇⨉砋漍戏甑焓戕㠗䤙礛氝嘟䜡嘣إ䄧天ఫ䀭弯䘱ᐳ圵丷嬹唻刽ℿ⁁⡃⍅", a_));
				IL_A5:
				channelFactory = null;
				collection = null;
				discoveryClient = null;
				num = (short)1400897560;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00007068 File Offset: 0x00005268
		private static global::System.ServiceModel.ChannelFactory<a> a<a>(string A_0, string A_1, global::System.ServiceModel.EndpointAddress A_2, string A_3, int A_4, string A_5, string A_6, string A_7, global::System.Security.SecureString A_8, bool A_9, string A_10 = "", string A_11 = "") where a : class
		{
			int a_ = 15;
			global::System.ServiceModel.ChannelFactory<a> channelFactory;
			short num2;
			for (;;)
			{
				channelFactory = null;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					int num;
					string text;
					for (;;)
					{
						IL_17:
						switch (num)
						{
						case 0:
							if (!(A_1 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䏿朁瘃爅愇氉攋洍焏昑焓", a_)))
							{
								num2 = (short)794886158;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_295;
						case 1:
							if (string.CompareOrdinal(A_2.Uri.Scheme, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("棿瘁瀃瘅笇", a_)) == 0)
							{
								num2 = (short)734461957;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							text = global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䛿朁怃挅稇欉砋欍琏圑稓爕栗甙甛瀝吟氡䔣䬥䴧", a_)];
							num2 = (short)390987793;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							goto IL_2B4;
						case 3:
							goto IL_2B4;
						case 4:
							global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(channelFactory, A_7, A_8);
							num2 = (short)1747451920;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 5:
							text = global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䛿朁怃挅稇欉砋欍琏䔑焓琕欗甙缛甝䔟嘡愣䠥䰧娩䌫䜭帯䘱稳圵唷弹", a_)];
							num2 = (short)557318146;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 6:
							if (A_2.Uri.ToString().Contains(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("勿企圃挅稇簉攋洍甏弑甓砕礗紙礛猝䔟䰡倣", a_)))
							{
								num2 = (short)563347471;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)56229889;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 7:
							if (A_1 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("嗿焁愃琅䘇欉愋欍", a_))
							{
								num2 = (short)1068302340;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_252;
						case 8:
							if (global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(A_0, text))
							{
								num2 = (short)1397030925;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_1C2;
						case 9:
							num2 = (short)46137354;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 10:
							goto IL_3B2;
						case 11:
							goto IL_295;
						case 12:
							goto IL_252;
						case 13:
							channelFactory = new global::System.ServiceModel.ChannelFactory<a>(text);
							global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.AddCustomAttribute((global::System.ServiceModel.Channels.CustomBinding)channelFactory.Endpoint.Binding, A_0, A_1, A_5, A_3, A_4, A_6, A_9, A_10, false, A_11);
							num2 = (short)1484128256;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 14:
							num2 = (short)1252655122;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 15:
							text = global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䛿朁怃挅稇欉砋欍琏䄑怓搕紗笙焛笝䐟朡䨣䈥堧䔩䔫䀭䐯簱唳嬵崷", a_)];
							num2 = (short)1785724931;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 16:
							goto IL_252;
						case 17:
							goto IL_2B4;
						case 18:
							if (A_1 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䫿甁瀃刅朇愉椋怍", a_))
							{
								num2 = (short)1099169803;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1372323847;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_69;
						IL_252:
						global::System.ServiceModel.EndpointIdentity identity = global::Motorola.Common.Cryptography.CryptographyFacade.GetServerIdentityProvider().Get();
						channelFactory.Endpoint.Address = new global::System.ServiceModel.EndpointAddress(A_2.Uri, identity, global::System.Array.Empty<global::System.ServiceModel.Channels.AddressHeader>());
						num2 = (short)659816457;
						num = (int)((global::System.IntPtr)num2);
						continue;
						IL_295:
						channelFactory.SetCertificate();
						num2 = (short)902692876;
						num = (int)((global::System.IntPtr)num2);
						continue;
						IL_2B4:
						num2 = (short)41549832;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C2:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䧿漁球琅朇稉椋簍簏欑㐓甕眗琙稛眝䜟圡嘣䌥䰧਩䤫䀭启䈱嬳張嘷丹᰻Ἵ", a_));
					IL_3B2:
					num2 = (short)1512636417;
					if (num2 != 0)
					{
					}
					goto IL_3EA;
					IL_69:
					text = string.Empty;
					num2 = (short)125042694;
					num = (int)((global::System.IntPtr)num2);
					goto IL_17;
				}
				catch
				{
					if (channelFactory != null)
					{
						((global::System.IDisposable)channelFactory).Dispose();
					}
					throw;
				}
				IL_3EA:
				num2 = (short)249102336;
				short num3 = num2;
				num2 = (short)1422444176;
				short num4 = num2;
				num2 = (short)807454352;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_449;
				}
			}
			IL_449:
			num2 = (short)185860096;
			if (num2 != 0)
			{
			}
			return channelFactory;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000074F0 File Offset: 0x000056F0
		public static global::System.ServiceModel.DuplexChannelFactory<TChannel> CreateClientChannel<TChannel>(string currentUserType, string authType, global::System.ServiceModel.InstanceContext context, string targetHost, int targetPort, string tokenIssuerHost, string svcType, string federatedEndpointName) where TChannel : class
		{
			int a_ = 10;
			global::System.ServiceModel.DuplexChannelFactory<TChannel> duplexChannelFactory;
			short num;
			for (;;)
			{
				duplexChannelFactory = null;
				try
				{
					num = (short)408682501;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)1024065539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1990000644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_156;
						case 3:
							if (authType == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뇺諼课唀氂渄戆月", a_))
							{
								num = (short)1479278600;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_156;
						case 4:
							goto IL_1B1;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_57;
							}
							continue;
						case 6:
							duplexChannelFactory = new global::System.ServiceModel.DuplexChannelFactory<TChannel>(federatedEndpointName);
							global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.AddCustomAttribute((global::System.ServiceModel.Channels.CustomBinding)duplexChannelFactory.Endpoint.Binding, currentUserType, authType, svcType, tokenIssuerHost, targetPort, "", false, "", false, "");
							num = (short)695336967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (!(authType == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("룺飼跾甀樂挄渆樈樊礌樎", a_)))
							{
								num = (short)489619456;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_179;
						case 8:
							goto IL_179;
						}
						IL_57:
						if (global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(currentUserType, federatedEndpointName))
						{
							num = (short)468123654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_156:
						global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(duplexChannelFactory, targetHost, targetPort);
						num = (short)14090241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_179:
						duplexChannelFactory.SetCertificate();
						num = (short)1279000578;
						num2 = (int)((global::System.IntPtr)num);
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("닺郼迾猀氂甄戆笈朊琌⼎爐簒笔焖瀘簚栜洞䐠䜢Ԥ䈦䜨伪崬䀮堰崲䄴᜶ᠸ", a_));
					IL_1B1:;
				}
				catch
				{
					if (duplexChannelFactory != null)
					{
						((global::System.IDisposable)duplexChannelFactory).Dispose();
					}
					throw;
				}
				num = (short)1470048069;
				short num3 = num;
				num = (short)1649289029;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1F7;
				}
			}
			IL_1F7:
			num = (short)156631041;
			if (num != 0)
			{
			}
			num = (short)1635844096;
			short num4 = num;
			num = (short)1347944448;
			if (num != 0)
			{
			}
			return duplexChannelFactory;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00007778 File Offset: 0x00005978
		public static global::System.ServiceModel.DuplexChannelFactory<TChannel> CreateClientChannelEx<TChannel>(string currentUserType, string authType, global::System.ServiceModel.InstanceContext context, string discoveryHost, int discoveryPort, string svcType, string pac = "", string userName = null, global::System.Security.SecureString pswd = null, bool activating = false, int retryCount = 5, int retryInterval = 2000, string oneTimePassword = "", string jwtToken = "") where TChannel : class
		{
			int a_ = 6;
			short num = (short)707592192;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9B;
				}
				global::System.ServiceModel.Discovery.DiscoveryClient discoveryClient;
				global::System.Collections.ObjectModel.Collection<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> collection;
				global::System.ServiceModel.DuplexChannelFactory<TChannel> duplexChannelFactory;
				bool flag;
				bool a_2;
				for (;;)
				{
					IL_30:
					string a_3;
					global::System.Collections.Generic.IEnumerable<global::System.Uri> source;
					global::System.Func<global::System.Uri, string> selector;
					switch (num2)
					{
					case 0:
						if (discoveryClient == null)
						{
							num = (short)1944322055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)998309892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						if (endpointDiscoveryMetadata.Scopes.Count > 0)
						{
							num = (short)1981743106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9EF;
					}
					case 2:
						num = (short)469106703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (collection.Count < 1)
						{
							num = (short)449904645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return duplexChannelFactory;
					case 4:
						try
						{
							collection = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(discoveryClient, typeof(TChannel), svcType, 2);
							global::System.Collections.Generic.IEnumerator<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> enumerator = collection.GetEnumerator();
							try
							{
								num = (short)892862465;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_506;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_458;
										}
										continue;
									case 2:
										num = (short)1501954048;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)376307714;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata2 = enumerator.Current;
										global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꗶ듸룺ꋼ돾渀搂戄戆笈", a_)).Error(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("釶郸闺駼\udffe搀洂愄眆昈戊挌笎ㄐ⤒㔔", a_) + endpointDiscoveryMetadata2.Address.ToString());
										num = (short)1798242307;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_45A:
									num = (short)1612775428;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_458:
									goto IL_45A;
								}
								IL_506:;
							}
							finally
							{
								num = (short)1888681986;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_5C6;
									case 1:
										enumerator.Dispose();
										num = (short)512491520;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_53D;
										}
										continue;
									}
									IL_53D:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1736908630;
									short num3 = num;
									num = (short)1586634582;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_5C6;
									default:
										num = (short)1199964160;
										if (num != 0)
										{
										}
										num = (short)1404764161;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
								}
								IL_5C6:;
							}
							goto IL_A74;
						}
						catch (global::System.Exception ex)
						{
							global::System.ServiceModel.FaultException ex2 = null;
							if (ex is global::System.ServiceModel.FaultException)
							{
								ex2 = (global::System.ServiceModel.FaultException)ex;
							}
							else if (ex.InnerException != null && ex.InnerException is global::System.ServiceModel.FaultException)
							{
								ex2 = (global::System.ServiceModel.FaultException)ex.InnerException;
							}
							if (ex2 != null)
							{
								if (ex2.Reason.ToString().Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꋶ꫸뻺꿼ꃾ伀䰂億堆䠈䠊夌䘎䜐划䄔刖崘", a_), global::System.StringComparison.Ordinal))
								{
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.USER_NOT_ACTIVATED, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꋶ諸黺迼\udffe栀瀂┄椆昈缊ⴌ渎爐朒簔愖砘漚砜笞", a_), ex2);
								}
								if (ex2.Reason.ToString() == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뫶룸룺뗼뛾伀䘂娄䤆䘈弊刌与刐䜒尔䄖堘会堜嬞", a_))
								{
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.MACHINE_NOT_ACTIVATED, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뫶飸飺闼雾漀昂┄渆稈⬊挌怎攐㌒琔琖洘爚欜縞唠䘢䄤", a_), ex2);
								}
								if (ex2.Reason.ToString() == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꓶ본룺꣼귾䠀圂射堆崈䐊䘌䨎弐䰒䜔刖䠘业堜䰞甠簢爤昦稨琪椬樮缰稲瀴猶", a_))
								{
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SECURITY_TOKEN_REQUEST_WAS_DENIED, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뫶飸飺闼雾漀昂┄渆稈⬊挌怎攐㌒琔琖洘爚欜縞唠䘢䄤", a_), ex2);
								}
								if (ex2.Reason.ToString() == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뻶韸跺鳼鏾栀朂┄䘆簈缊攌樎缐朒簔琖砘漚琜瀞传̢焤䠦䈨个䌬", a_))
								{
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ID_TOKEN_IS_INVALID, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꋶ諸黺迼\udffe䠀朂怄椆紈戊礌瘎ㄐ䜒稔簖簘甚㴜瘞删̢䰤䤦弨䨪䄬䘮唰ጲ", a_), ex2);
								}
								if (ex2.Reason.ToString().Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뇶냸뗺뫼뫾匀匂圄丆䜈弊刌夎倐弒尔化堘会堜䀞朠戢氤欦氨漪", a_), global::System.StringComparison.Ordinal))
								{
									if (!flag)
									{
										throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SECURITY_TOKEN_REQUEST_WAS_DENIED, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뇶郸闺髼髾猀匂眄渆月缊ⴌ礎瀐缒簔猖砘漚琜瀞传̢䌤䘦䀨䜪䠬䬮", a_), ex2);
									}
									flag = false;
									a_2 = true;
									retryCount = 5;
								}
								goto IL_A74;
							}
							else
							{
								if (ex is global::Motorola.Common.CustomException.CommonException && ((global::Motorola.Common.CustomException.CommonException)ex).ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.TARGET_DISCOVERYSERVER_NOT_AVAILABLE)
								{
									throw;
								}
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DISCOVERY_LOGIN_FAILED, ex);
							}
						}
						finally
						{
							try
							{
								num = (short)1537212418;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										if (discoveryClient.InnerChannel.State == global::System.ServiceModel.CommunicationState.Faulted)
										{
											num = (short)1019543556;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_8DB;
									case 1:
										discoveryClient.InnerChannel.Close();
										num = (short)1391329288;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_816;
										}
										continue;
									case 3:
										goto IL_922;
									case 4:
										discoveryClient.InnerChannel.Abort();
										num = (short)1442316297;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										goto IL_93A;
									case 6:
										num = (short)559677447;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										if (discoveryClient.InnerChannel.State == global::System.ServiceModel.CommunicationState.Opened)
										{
											num = (short)809107457;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1350434816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										goto IL_8DB;
									case 9:
										goto IL_8DB;
									}
									IL_816:
									if (discoveryClient != null)
									{
										num = (short)47251462;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_922;
									IL_8DB:
									discoveryClient.Close();
									num = (short)1362558979;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_922:
									num = (short)1828651013;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_93A:;
							}
							catch
							{
							}
						}
						goto IL_940;
						IL_A74:
						num = (short)933167127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_9E8;
					case 6:
						if (collection.Count > 0)
						{
							num = (short)895811606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A4;
					case 7:
						goto IL_113;
					case 8:
						goto IL_3E6;
					case 9:
						try
						{
							global::System.ServiceModel.EndpointAddress endpointAddress;
							duplexChannelFactory = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a<TChannel>(currentUserType, authType, context, endpointAddress, discoveryHost, discoveryPort, a_3, pac, userName, pswd, activating, oneTimePassword, jwtToken);
							global::System.Console.WriteLine(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("돶賸诺釼髾礀⌂昄漆栈攊挌樎紐㌒猔瘖稘漚爜洞堠̢䘤唦䰨䨪夬䨮唰ጲ䘴䈶娸堺堼䰾㉀╂い⭆╈㉊睌潎⩐捒⡔", a_), endpointAddress.ToString());
							return duplexChannelFactory;
						}
						catch (global::System.Exception ex3)
						{
							if (duplexChannelFactory != null)
							{
								((global::System.IDisposable)duplexChannelFactory).Dispose();
							}
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CANNOT_CONNECT_TO_TARGET_SERVER, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("듶飸闺鏼郾甀⌂昄栆月攊栌氎攐㌒愔砖㤘漚甜稞Ġ圢䐤唦丨个夬༮戰嘲䜴䄶尸䤺", a_), ex3);
						}
						goto IL_298;
					case 10:
					{
						num = (short)319750144;
						short num4 = num;
						if (collection == null)
						{
							num = (short)391053320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)446038019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_A0D;
					case 12:
						goto IL_9EF;
					case 13:
						if (retryCount-- < 0)
						{
							num = (short)930480147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_298;
					case 14:
						goto IL_A0D;
					case 15:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						source = endpointDiscoveryMetadata.Scopes.Where(new global::System.Func<global::System.Uri, bool>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c__7<TChannel>.<>9.a));
						if ((selector = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c__7<TChannel>.<>9__7_1) == null)
						{
							goto IL_CB9;
						}
						goto IL_982;
					}
					case 16:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						if (endpointDiscoveryMetadata.Scopes != null)
						{
							num = (short)190906386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9EF;
					}
					case 17:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						if (endpointDiscoveryMetadata != null)
						{
							num = (short)854523928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3;
					}
					case 18:
						num = (short)256049153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1916469258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						try
						{
							discoveryClient = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(currentUserType, authType, discoveryHost, discoveryPort, pac, userName, pswd, activating, oneTimePassword, a_2, jwtToken);
							goto IL_DC;
						}
						catch (global::Motorola.Common.CustomException.CommonException)
						{
							throw;
						}
						catch (global::System.Exception ex4)
						{
							try
							{
								num = (short)1484455938;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										if (discoveryClient.InnerChannel.State == global::System.ServiceModel.CommunicationState.Opened)
										{
											num = (short)1864171524;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)614596615;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										discoveryClient.InnerChannel.Abort();
										num = (short)224264195;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_B24;
										}
										continue;
									case 3:
										goto IL_C0F;
									case 4:
										discoveryClient.InnerChannel.Close();
										num = (short)942014473;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										goto IL_C49;
									case 6:
										num = (short)2090401792;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										if (discoveryClient.InnerChannel.State == global::System.ServiceModel.CommunicationState.Faulted)
										{
											num = (short)1975451649;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_C0F;
									case 8:
										goto IL_C31;
									case 9:
										goto IL_C0F;
									}
									IL_B24:
									if (discoveryClient != null)
									{
										num = (short)1943928838;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C31;
									IL_C0F:
									discoveryClient.Close();
									num = (short)739049480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_C31:
									num = (short)1297940485;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_C49:
								goto IL_C89;
							}
							catch
							{
								goto IL_C89;
							}
							IL_C4E:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidAppConfigCertificatesSection, ex4);
							IL_C89:
							if (ex4 is global::Motorola.Common.Cryptography.Exceptions.CryptographyException)
							{
								if (ex4 is global::Motorola.Common.Cryptography.Exceptions.CertificateGroupNotFoundException)
								{
									goto IL_C4E;
								}
								if (ex4 is global::Motorola.Common.Cryptography.Exceptions.ConfigSectionNotFoundException)
								{
									goto IL_C4E;
								}
								if (ex4 is global::Motorola.Common.Cryptography.Exceptions.NoCertificatesFoundException)
								{
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ConfiguredCertificateTypeNotFound, ex4);
								}
								if (ex4 is global::Motorola.Common.Cryptography.Exceptions.ToManyCertificatesException)
								{
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AmbiguousCertificatesFound, ex4);
								}
							}
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DISCOVERYCLIENT_SETTING_IS_INCORRECT, ex4);
						}
						goto IL_CB9;
						IL_DC:
						num = (short)461635584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_940;
					case 22:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(collection, currentUserType);
						num = (short)1306787857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						if (collection != null)
						{
							num = (short)957677589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A4;
					case 24:
					{
						num = (short)484507649;
						if (num != 0)
						{
						}
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꗶ듸룺ꋼ돾渀搂戄戆笈", a_)).Error(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꋶ諸黺\uddfc髾漀朂甄栆怈攊礌⼎⬐㌒", a_) + endpointDiscoveryMetadata.Address.ToString());
						global::System.ServiceModel.EndpointAddress endpointAddress = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(endpointDiscoveryMetadata.Address, discoveryHost);
						a_3 = null;
						num = (short)1012596752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_9B;
					IL_1A4:
					global::System.Threading.Thread.Sleep(retryInterval);
					num = (short)1179582475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_298:
					num = (short)1174208532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_940:
					num = (short)1622343686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_982:
					a_3 = global::Motorola.Security.SamlCommonUtility.TypeConverter.GetServiceTypeFromServerScope(source.Select(selector).FirstOrDefault<string>());
					num = (short)325582860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CB9:
					selector = (global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c__7<TChannel>.<>9__7_1 = new global::System.Func<global::System.Uri, string>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c__7<TChannel>.<>9.b));
					goto IL_982;
					IL_9EF:
					num = (short)350158857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A0D:
					num = (short)216530957;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ServiceNotCompatibleWithClientVersion, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꋶ韸髺鿼鏾搀⌂焄栆⤈栊戌愎缐瘒瘔挖㤘漚爜㼞猠渢Ԥ琦䰨太嬬䨮䌰ᴲᔴ愶尸䤺丼嘾⹀ⵂ敄⹆㩈歊⍌⁎═獒㙔㡖㑘⭚㱜⭞ࡠŢ।ɦ䥨ᱪѬ᭮ᥰ卲❴㩶奸ࡺ᡼ൾꦆ", a_));
				IL_113:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DISCOVERYCLIENT_SETTING_IS_INCORRECT);
				IL_3E6:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.TARGET_SERVER_NOT_AVAILABLE, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꏶ釸黺\uddfc课怀焂戄戆紈⬊希樎挐攒瀔攖㤘爚渜㼞传䰢儤ܦ䠨崪䰬䘮崰刲圴嬶尸", a_));
				IL_9E8:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.TARGET_SERVER_NOT_AVAILABLE, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꏶ釸黺\uddfc课怀焂戄戆紈⬊希樎挐攒瀔攖㤘爚渜㼞传䰢儤ܦ䠨崪䰬䘮崰刲圴嬶尸", a_));
				IL_9B:
				duplexChannelFactory = null;
				collection = null;
				discoveryClient = null;
				flag = true;
				a_2 = false;
				num = (short)1679097870;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00008520 File Offset: 0x00006720
		public static global::System.ServiceModel.DuplexChannelFactory<TChannel> CreateClientChannelForWebDM<TChannel>(string currentUserType, string authType, global::System.ServiceModel.InstanceContext context, string discoveryHost, int discoveryPort, string svcType, string pac = "", string userName = null, global::System.Security.SecureString pswd = null, bool activating = false, int retryCount = 5, int retryInterval = 2000, string oneTimePassword = "", string jwtToken = "") where TChannel : class
		{
			int a_ = 11;
			short num = (short)220659712;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A4;
				}
				bool a_2;
				global::System.ServiceModel.Discovery.DiscoveryClient discoveryClient;
				global::System.Collections.ObjectModel.Collection<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> collection;
				global::System.ServiceModel.DuplexChannelFactory<TChannel> duplexChannelFactory;
				bool flag;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.IEnumerable<global::System.Uri> scopes;
					global::System.Func<global::System.Uri, bool> predicate;
					string a_3;
					switch (num2)
					{
					case 0:
						goto IL_6CF;
					case 1:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						if (endpointDiscoveryMetadata.Scopes != null)
						{
							num = (short)1097400342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CF;
					}
					case 2:
						if (retryCount-- < 0)
						{
							num = (short)1702821907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)667680771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1857617921;
						if (num != 0)
						{
						}
						try
						{
							discoveryClient = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(currentUserType, authType, discoveryHost, discoveryPort, pac, userName, pswd, activating, oneTimePassword, a_2, jwtToken);
							goto IL_9B6;
						}
						catch (global::System.Exception systemException)
						{
							try
							{
								num = (short)287768585;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										discoveryClient.InnerChannel.Abort();
										num = (short)1716781057;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_79C;
									case 2:
										goto IL_8CF;
									case 3:
										goto IL_82C;
									case 4:
									{
										num = (short)701159426;
										short num3 = num;
										num = (short)952358914;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_79C;
										default:
											num = (short)1117782016;
											if (num != 0)
											{
											}
											num = (short)247660549;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										if (discoveryClient.InnerChannel.State == global::System.ServiceModel.CommunicationState.Opened)
										{
											num = (short)280035336;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)2057175047;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										goto IL_8B7;
									case 7:
										if (discoveryClient.InnerChannel.State == global::System.ServiceModel.CommunicationState.Faulted)
										{
											num = (short)690290688;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_82C;
									case 8:
										discoveryClient.InnerChannel.Close();
										num = (short)1851523075;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										switch (0)
										{
										case 0:
											goto IL_75E;
										}
										continue;
									}
									IL_75E:
									if (discoveryClient != null)
									{
										num = (short)2137128964;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_8B7;
									IL_82C:
									discoveryClient.Close();
									num = (short)1894645766;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_79C:
									goto IL_82C;
									IL_8B7:
									num = (short)2027028482;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_8CF:;
							}
							catch
							{
							}
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DISCOVERYCLIENT_SETTING_IS_INCORRECT, systemException);
						}
						goto IL_8E1;
						IL_9B6:
						num = (short)1470169102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						if (endpointDiscoveryMetadata != null)
						{
							num = (short)1796997120;
							short num4 = num;
							num = (short)918945800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1989410841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						scopes = endpointDiscoveryMetadata.Scopes;
						if ((predicate = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c__8<TChannel>.<>9__8_0) == null)
						{
							goto IL_8E1;
						}
						goto IL_2D8;
					}
					case 6:
						num = (short)83689493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_EE;
					case 8:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						global::System.ServiceModel.EndpointAddress endpointAddress = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(endpointDiscoveryMetadata.Address, discoveryHost);
						a_3 = null;
						num = (short)1690959873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_667;
					case 10:
						if (collection.Count < 1)
						{
							num = (short)321650704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return duplexChannelFactory;
					case 11:
						goto IL_984;
					case 12:
						try
						{
							collection = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(discoveryClient, typeof(TChannel), svcType, 2);
							goto IL_9F1;
						}
						catch (global::System.Exception ex)
						{
							global::System.ServiceModel.FaultException ex2 = null;
							if (ex is global::System.ServiceModel.FaultException)
							{
								ex2 = (global::System.ServiceModel.FaultException)ex;
							}
							else if (ex.InnerException != null && ex.InnerException is global::System.ServiceModel.FaultException)
							{
								ex2 = (global::System.ServiceModel.FaultException)ex.InnerException;
							}
							if (ex2 != null)
							{
								if (ex2.Reason.ToString().Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꧻ귽䗿倁嬃䠅䜇帉匋伍匏䘑崓䀕夗丙夛娝", a_), global::System.StringComparison.Ordinal))
								{
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.USER_NOT_ACTIVATED, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꧻ跽旿瀁␃漅笇⨉戋愍搏㈑甓甕気猙樛缝吟䜡䀣", a_), ex2);
								}
								if (ex2.Reason.ToString() == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뇻뿽䏿䨁䴃䠅䴇唉䈋䄍䐏䴑唓唕䰗匙䨛弝琟朡怣", a_))
								{
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.MACHINE_NOT_ACTIVATED, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뇻鿽揿樁洃栅洇⨉攋納』簑笓戕㠗笙缛樝䤟吡䔣別䴧丩", a_), ex2);
								}
								if (ex2.Reason.ToString() == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("꿻믽䏿圁嘃伅將匉匋娍式夑儓堕䜗䠙夛伝生朡眣爥眧紩洫紭漯瘱焳砵焷缹砻", a_))
								{
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SECURITY_TOKEN_REQUEST_WAS_DENIED, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뇻鿽揿樁洃栅洇⨉攋納』簑笓戕㠗笙缛樝䤟吡䔣別䴧丩", a_), ex2);
								}
								if (ex2.Reason.ToString().Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뫻럽仿䔁䄃吅堇堉䔋䀍䐏䴑䈓圕吗匙堛弝琟朡笣急椧挩怫欭琯", a_), global::System.StringComparison.Ordinal))
								{
									if (!flag)
									{
										throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SECURITY_TOKEN_REQUEST_WAS_DENIED, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뫻韽滿攁愃琅堇砉攋怍搏㈑戓眕琗猙砛缝吟䬡䬣䠥ࠧ䰩䴫䜭尯圱倳", a_), ex2);
									}
									flag = false;
									a_2 = true;
									retryCount = 5;
								}
								goto IL_9F1;
							}
							else
							{
								if (ex is global::Motorola.Common.CustomException.CommonException && ((global::Motorola.Common.CustomException.CommonException)ex).ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.TARGET_DISCOVERYSERVER_NOT_AVAILABLE)
								{
									throw;
								}
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DISCOVERY_LOGIN_FAILED, ex);
							}
						}
						finally
						{
							try
							{
								num = (short)1780875273;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										discoveryClient.InnerChannel.Close();
										num = (short)1531248641;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_5B8;
									case 2:
										goto IL_661;
									case 3:
										goto IL_5B8;
									case 4:
										num = (short)647561223;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										if (discoveryClient.InnerChannel.State == global::System.ServiceModel.CommunicationState.Faulted)
										{
											num = (short)86245384;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_5B8;
									case 6:
										goto IL_647;
									case 7:
										if (discoveryClient.InnerChannel.State == global::System.ServiceModel.CommunicationState.Opened)
										{
											num = (short)1218052096;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1125318661;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										discoveryClient.InnerChannel.Abort();
										num = (short)1908342787;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										switch (0)
										{
										case 0:
											goto IL_533;
										}
										continue;
									}
									IL_533:
									if (discoveryClient != null)
									{
										num = (short)369098756;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_647;
									IL_5B8:
									discoveryClient.Close();
									num = (short)912719878;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_647:
									num = (short)1057226754;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_661:;
							}
							catch
							{
							}
						}
						goto Block_8;
						IL_9F1:
						num = (short)1015218191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(collection, currentUserType);
						num = (short)951189508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (discoveryClient == null)
						{
							num = (short)8716311;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)612761612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (collection != null)
						{
							num = (short)1027538950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CD;
					case 16:
						goto IL_AD3;
					case 17:
						num = (short)1128792069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						if (endpointDiscoveryMetadata.Scopes.Count > 0)
						{
							num = (short)155975697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CF;
					}
					case 19:
						num = (short)868286484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (collection == null)
						{
							num = (short)133169176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1612709898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (collection.Count > 0)
						{
							num = (short)467402765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CD;
					case 22:
						num = (short)832438290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_9EC;
					case 24:
						num = (short)1495924747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_2BF;
					case 26:
						goto IL_EE;
					}
					goto IL_A4;
					IL_CD:
					global::System.Threading.Thread.Sleep(retryInterval);
					num = (short)1920335879;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EE:
					num = (short)2016149506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6CF:
					num = (short)1580072969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_667:
						global::System.ServiceModel.EndpointAddress endpointAddress;
						duplexChannelFactory = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a<TChannel>(currentUserType, authType, context, endpointAddress, discoveryHost, discoveryPort, a_3, pac, userName, pswd, activating, oneTimePassword, jwtToken);
						global::System.Console.WriteLine(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("룻诽烿渁愃縅⠇椉搋漍縏簑焓稕㠗簙紛紝吟䴡嘣弥ࠧ䤩師䬭儯䘱儳刵ᠷ䤹䤻崽⌿❁㝃㕅⹇㽉⁋≍⥏桑瑓ⵕ桗❙", a_), endpointAddress.ToString());
						return duplexChannelFactory;
					}
					catch (global::System.Exception ex3)
					{
						if (duplexChannelFactory != null)
						{
							((global::System.IDisposable)duplexChannelFactory).Dispose();
						}
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CANNOT_CONNECT_TO_TARGET_SERVER, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뿻鿽滿氁欃爅⠇椉挋怍縏眑眓戕㠗渙猛㸝吟䨡䄣إ尧䬩師䤭唯䘱ᐳ攵崷䠹䨻嬽㈿", a_), ex3);
					}
					goto IL_6CF;
					IL_2D8:
					a_3 = global::Motorola.Security.SamlCommonUtility.TypeConverter.GetServiceTypeFromServerScope(scopes.Where(predicate).Select(new global::System.Func<global::System.Uri, string>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c__8<TChannel>.<>9.b)).FirstOrDefault<string>());
					num = (short)1336410112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8E1:
					predicate = (global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c__8<TChannel>.<>9__8_0 = new global::System.Func<global::System.Uri, bool>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c__8<TChannel>.<>9.a));
					goto IL_2D8;
				}
				return duplexChannelFactory;
				IL_2BF:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ServiceNotCompatibleWithClientVersion, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꧻ都懿态栃挅⠇縉挋⸍猏紑稓砕紗礙栛㸝吟䴡У琥攧਩缫䬭䈯䐱儳䐵ᘷᨹ樻嬽㈿ㅁⵃ⥅♇橉╋㵍灏㱑㭓≕硗㥙㍛㍝ၟ͡ၣཥ੧٩५乭ݯ᭱sṵ塷⡹ㅻ幽ꊋ", a_));
				IL_984:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.TARGET_SERVER_NOT_AVAILABLE, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꣻ雽旿∁瀃朅稇洉椋稍』䄑焓搕渗缙減㸝䤟儡У䠥䜧帩ఫ伭䘯匱崳娵夷堹倻嬽", a_));
				IL_9EC:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DISCOVERYCLIENT_SETTING_IS_INCORRECT);
				IL_AD3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.TARGET_SERVER_NOT_AVAILABLE, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꣻ雽旿∁瀃朅稇洉椋稍』䄑焓搕渗缙減㸝䤟儡У䠥䜧帩ఫ伭䘯匱崳娵夷堹倻嬽", a_));
				IL_A4:
				duplexChannelFactory = null;
				collection = null;
				discoveryClient = null;
				flag = true;
				a_2 = false;
				num = (short)1385037850;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000090A8 File Offset: 0x000072A8
		private static global::System.ServiceModel.DuplexChannelFactory<a> a<a>(string A_0, string A_1, global::System.ServiceModel.InstanceContext A_2, global::System.ServiceModel.EndpointAddress A_3, string A_4, int A_5, string A_6, string A_7, string A_8, global::System.Security.SecureString A_9, bool A_10 = false, string A_11 = "", string A_12 = "") where a : class
		{
			int a_ = 6;
			short num = (short)1587806209;
			if (num != 0)
			{
			}
			global::System.ServiceModel.DuplexChannelFactory<a> duplexChannelFactory = null;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_84;
				}
				int num2;
				string text;
				for (;;)
				{
					IL_3E:
					switch (num2)
					{
					case 0:
						goto IL_DD;
					case 1:
						goto IL_11E;
					case 2:
						goto IL_11E;
					case 3:
						num = (short)852819973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (A_1 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뷶軸迺ꧼ郾樀昂欄", a_))
						{
							num = (short)430178313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1084096523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_356;
					case 6:
						num = (short)1569521668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(A_0, text))
						{
							num = (short)564330506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E6;
					case 8:
						text = global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뇶鳸鿺飼跾怀眂怄挆师渊漌簎縐瀒縔爖洘帚猜笞儠䰢䰤䤦崨攪䰬䈮吰", a_)];
						num = (short)459210764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_2A4;
					case 10:
						duplexChannelFactory = new global::System.ServiceModel.DuplexChannelFactory<a>(A_2, text);
						global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.AddCustomAttribute((global::System.ServiceModel.Channels.CustomBinding)duplexChannelFactory.Endpoint.Binding, A_0, A_1, A_6, A_4, A_5, A_7, A_10, A_11, false, A_12);
						num = (short)1181155341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (A_1 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꋶ諸黺迼뇾怀渂怄", a_))
						{
							num = (short)10944526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11E;
					case 12:
						goto IL_DD;
					case 13:
						if (!(A_1 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("듶鳸觺觼雾最樂昄昆紈渊", a_)))
						{
							num = (short)260833286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A4;
					case 14:
						global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(duplexChannelFactory, A_8, A_9);
						num = (short)1174274049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (string.CompareOrdinal(A_3.Uri.Scheme, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("鿶跸迺跼賾", a_)) == 0)
						{
							num = (short)2007040008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뇶鳸鿺飼跾怀眂怄挆䰈攊椌缎縐稒笔挖團稚瀜稞", a_)];
						num = (short)22347776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_84;
					IL_DD:
					num = (short)1851260935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11E:
					global::System.ServiceModel.EndpointIdentity identity = global::Motorola.Common.Cryptography.CryptographyFacade.GetServerIdentityProvider().Get();
					duplexChannelFactory.Endpoint.Address = new global::System.ServiceModel.EndpointAddress(A_3.Uri, identity, global::System.Array.Empty<global::System.ServiceModel.Channels.AddressHeader>());
					num = (short)419168259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A4:
					duplexChannelFactory.SetCertificate();
					num = (short)1080754178;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E6:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뻶铸诺迼郾焀昂眄欆瀈⬊渌怎缐甒簔瀖氘椚砜笞Ġ䘢䬤䌦夨䐪䐬䄮䔰ጲᐴ", a_));
				IL_356:
				goto IL_3B2;
				IL_84:
				text = string.Empty;
				num = (short)705036303;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_3E;
			}
			catch
			{
				if (duplexChannelFactory == null)
				{
					goto IL_366;
				}
				IL_35E:
				((global::System.IDisposable)duplexChannelFactory).Dispose();
				IL_366:
				num = (short)732949060;
				short num3 = num;
				num = (short)2097408580;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_35E;
				default:
					num = (short)540213248;
					if (num != 0)
					{
					}
					throw;
				}
			}
			IL_3B2:
			num = (short)949288960;
			short num4 = num;
			return duplexChannelFactory;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000094AC File Offset: 0x000076AC
		public static void AddCustomAttribute(global::System.ServiceModel.Channels.Binding binding, string currentUserType, string authType, string svcType, string tokenIssuerHost, int tokenIssuerPort, string pac = "", bool activating = false, string oneTimePassword = "", bool reviseBootSerialNumber = false, string jwtToken = "")
		{
			int a_ = 8;
			short num = (short)2118123520;
			switch (num)
			{
			default:
			{
				num = (short)904396803;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters issuedSecurityTokenParameters;
				global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo a_2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.ServiceModel.Channels.SecurityBindingElement securityBindingElement = ((global::System.ServiceModel.Channels.CustomBinding)binding).Elements.Find<global::System.ServiceModel.Channels.SecurityBindingElement>();
						num = (short)271843329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.ServiceModel.Channels.SecurityBindingElement securityBindingElement;
						if (securityBindingElement != null)
						{
							num = (short)200343558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
					{
						num = (short)1713111041;
						if (num != 0)
						{
						}
						global::System.ServiceModel.Channels.SecurityBindingElement securityBindingElement;
						issuedSecurityTokenParameters = (global::System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters)((global::System.ServiceModel.Security.Tokens.SecureConversationSecurityTokenParameters)securityBindingElement.EndpointSupportingTokenParameters.Endorsing[0]).BootstrapSecurityBindingElement.EndpointSupportingTokenParameters.Endorsing[0];
						a_2 = null;
						global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo>.Enumerator enumerator = ((global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo>)global::System.Configuration.ConfigurationManager.GetSection(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("그铺雼髾漀䨂瘄理簈渊缌導琐瀒愔縖瘘甚", a_))).GetEnumerator();
						num = (short)1864433669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_3C;
					case 4:
					{
						global::System.ServiceModel.Channels.SecurityBindingElement securityBindingElement;
						if (securityBindingElement.EndpointSupportingTokenParameters.Endorsing[0] is global::System.ServiceModel.Security.Tokens.SecureConversationSecurityTokenParameters)
						{
							num = (short)1781727234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_244;
					}
					case 5:
					{
						num = (short)895942656;
						short num3 = num;
						try
						{
							num = (short)320405507;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_13A;
								case 1:
								{
									global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1638793222;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo tokenIssuerInfo = enumerator.Current;
									num = (short)992477188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo tokenIssuerInfo;
									a_2 = tokenIssuerInfo;
									num = (short)750845952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_120;
									}
									continue;
								case 4:
								{
									global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo tokenIssuerInfo;
									if (string.Equals(tokenIssuerInfo.authenticationMethod, authType, global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)1664024578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_1DE;
								case 6:
									num = (short)1394016261;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_189:
								num = (short)1222967297;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_120:
								goto IL_189;
							}
							IL_13A:
							IL_1DE:
							goto IL_2A6;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1F1;
					}
					case 6:
						goto IL_1F1;
					}
					goto IL_69;
					IL_3C:
					switch (0)
					{
					case 0:
					{
						IL_69:
						num = (short)1993883256;
						short num4 = num;
						num = (short)1396129400;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C;
						default:
							num = (short)1014628352;
							if (num != 0)
							{
							}
							if (!(binding is global::System.ServiceModel.Channels.CustomBinding))
							{
								return;
							}
							num = (short)1777336320;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
					}
					continue;
					IL_1F1:
					num = (short)494469124;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_244:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("냸雺跼跾渀猂怄甆攈爊ⴌ氎縐紒猔縖縘渚漜稞䔠̢䀤䤦䴨嬪䈬䘮弰䜲ᔴᘶ", a_));
				IL_2A6:
				issuedSecurityTokenParameters.IssuerAddress = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(a_2, tokenIssuerHost, tokenIssuerPort);
				issuedSecurityTokenParameters.IssuerBinding = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(a_2);
				global::System.Xml.XmlElement item = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(currentUserType, authType, svcType, pac, oneTimePassword, activating, reviseBootSerialNumber, jwtToken);
				issuedSecurityTokenParameters.AdditionalRequestParameters.Add(item);
				return;
			}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00009878 File Offset: 0x00007A78
		private static void a(global::System.ServiceModel.ChannelFactory A_0, string A_1, global::System.Security.SecureString A_2)
		{
			short num = (short)1204004715;
			short num2 = num;
			num = (short)119187307;
			switch (num2 == num)
			{
			}
			num = (short)1072365568;
			short num3 = num;
			num = (short)499384320;
			if (num != 0)
			{
			}
			num = (short)1299316737;
			if (num != 0)
			{
			}
			A_0.Credentials.ServiceCertificate.Authentication.RevocationMode = global::System.Security.Cryptography.X509Certificates.X509RevocationMode.NoCheck;
			A_0.Credentials.UserName.UserName = A_1;
			A_0.Credentials.UserName.Password = A_2.a();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000995C File Offset: 0x00007B5C
		private static string a(this global::System.Security.SecureString A_0)
		{
			int a_ = 13;
			short num = (short)455016448;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.IntPtr intPtr;
				switch (num2)
				{
				case 0:
					goto IL_1E;
				case 1:
					goto IL_A2;
				case 2:
				{
					num = (short)2089968448;
					short num3 = num;
					num = (short)665674560;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E;
					default:
						num = (short)1877671936;
						if (num != 0)
						{
						}
						try
						{
							intPtr = global::System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(A_0);
							return global::System.Runtime.InteropServices.Marshal.PtrToStringUni(intPtr);
						}
						finally
						{
							global::System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
						}
						goto IL_C1;
					}
					break;
				}
				}
				goto IL_8A;
				IL_1E:
				num = (short)1923547137;
				if (num != 0)
				{
				}
				num = (short)873267200;
				short num4 = num;
				switch (0)
				{
				case 0:
					IL_8A:
					if (A_0 != null)
					{
						goto IL_C1;
					}
					num = (short)1773010945;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_C1:
				intPtr = global::System.IntPtr.Zero;
				num = (short)1673789442;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A2:
			throw new global::System.ArgumentNullException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("跽旿愁吃甅缇渉", a_));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00009ABC File Offset: 0x00007CBC
		public static global::Motorola.Security.SamlCommonUtility.UpgradePathInfo GetUpgradePathInfo(string currentUserType, string authType, string discoveryHost, int discoveryPort, string pac, string userName = null, global::System.Security.SecureString pswd = null, bool activating = false, string oneTimePassword = "", string jwtToken = "")
		{
			int a_ = 18;
			short num = (short)360120320;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7F;
				}
				global::System.Collections.ObjectModel.Collection<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> collection;
				global::Motorola.Security.SamlCommonUtility.UpgradePathInfo upgradePathInfo;
				for (;;)
				{
					IL_30:
					global::System.Xml.Linq.XAttribute xattribute;
					global::System.Xml.Linq.XElement xelement;
					switch (num2)
					{
					case 0:
						if (collection.Count > 0)
						{
							num = (short)789512200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return upgradePathInfo;
					case 1:
						upgradePathInfo.RMVersion = xattribute.Value.Trim();
						num = (short)560267268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return upgradePathInfo;
					case 3:
						upgradePathInfo.AutoUpdate = xattribute.Value.Trim();
						num = (short)1809973250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_13C;
					case 5:
						if (xelement.Name == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("嘂甄怆笈樊椌樎䄐爒愔编", a_))
						{
							num = (short)895287309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return upgradePathInfo;
					case 6:
						num = (short)592510987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (xelement != null)
						{
							num = (short)265289745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return upgradePathInfo;
					case 8:
						num = (short)1326776321;
						if (num != 0)
						{
						}
						num = (short)647692300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)924647424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (xattribute != null)
						{
							num = (short)66977793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E2;
					case 11:
						if (collection[0].Extensions.Count > 0)
						{
							num = (short)1732640784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return upgradePathInfo;
					case 12:
						if (collection[0].Extensions != null)
						{
							num = (short)2119565318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return upgradePathInfo;
					case 13:
						upgradePathInfo = new global::Motorola.Security.SamlCommonUtility.UpgradePathInfo();
						xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("焂栄焆氈礊縌明縐紒", a_));
						num = (short)2022965258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (collection != null)
						{
							num = (short)681050121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return upgradePathInfo;
					case 15:
						if (xattribute != null)
						{
							num = (short)1138425859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return upgradePathInfo;
					case 16:
					{
						num = (short)1475411968;
						short num3 = num;
						xelement = collection[0].Extensions[0];
						num = (short)1355994280;
						short num4 = num;
						num = (short)995153064;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13C;
						default:
							num = (short)2136604672;
							if (num != 0)
							{
							}
							num = (short)392757255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 17:
						num = (short)1505296389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F;
					IL_1E2:
					xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("戂瀄猆昈縊紌欎瀐朒瀔", a_));
					num = (short)897253391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13C:
					goto IL_1E2;
				}
				return upgradePathInfo;
				IL_7F:
				upgradePathInfo = null;
				collection = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(currentUserType, authType, discoveryHost, discoveryPort, pac, userName, pswd, activating, oneTimePassword, false, jwtToken), new global::System.Collections.ObjectModel.Collection<global::System.Uri>
				{
					new global::System.Uri(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("焂栄㴆☈␊椌明成瀒稔愖簘椚搜〞唠娢唤䈦ب礪怬欮堰䀲嘴堶伸帺似䘾ቀ♂㝄ㅆⱈ㥊", a_)),
					new global::System.Uri(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("焂栄㴆☈␊椌明成瀒稔愖簘椚搜〞䠠䴢䌤䠦ب縪崬䠮䌰刲儴制椸娺䤼圾", a_))
				}, 1);
				num = (short)622985230;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00009F0C File Offset: 0x0000810C
		public static global::Motorola.Security.SamlCommonUtility.RMDatabaseConnectionInfo GetRMDatabaseConnectionInfo(string currentUserType, string authType, string discoveryHost, int discoveryPort, string pac = "", string userName = null, global::System.Security.SecureString pswd = null, bool activating = false, string oneTimePassword = "", string jwtToken = "")
		{
			int a_ = 13;
			short num = (short)1602778520;
			short num2 = num;
			num = (short)1071216024;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)348258304;
				if (num != 0)
				{
				}
				num = (short)1338507264;
				short num3 = num;
				num = (short)1397161984;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			global::Motorola.Security.SamlCommonUtility.RMDatabaseConnectionInfo rmdatabaseConnectionInfo = null;
			global::System.ServiceModel.Discovery.DiscoveryClient discoveryClient = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(currentUserType, authType, discoveryHost, discoveryPort, pac, userName, pswd, activating, oneTimePassword, false, jwtToken);
			global::Motorola.Security.SamlCommonUtility.RMDatabaseConnectionInfo result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_12B;
				}
				int num4;
				global::System.Collections.ObjectModel.Collection<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> collection;
				for (;;)
				{
					IL_C0:
					global::System.Xml.Linq.XAttribute xattribute;
					global::System.Xml.Linq.XElement xelement;
					switch (num4)
					{
					case 0:
						rmdatabaseConnectionInfo.Host = xattribute.Value;
						num = (short)1971978252;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (xelement.Name == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뫽懿瘁攃搅椇礉椋䴍缏簑稓猕笗渙甛焝丟", a_))
						{
							num = (short)68157449;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57C;
					case 2:
						goto IL_37F;
					case 3:
						goto IL_598;
					case 4:
						goto IL_522;
					case 5:
						num = (short)1479868427;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						rmdatabaseConnectionInfo = new global::Motorola.Security.SamlCommonUtility.RMDatabaseConnectionInfo();
						xelement = collection[0].Extensions[0];
						num = (short)1934950422;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)151322625;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (xattribute != null)
						{
							num = (short)1008467981;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37F;
					case 9:
						xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("賽淿琁愃琅笇按挋怍", a_));
						num = (short)1878392856;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (collection[0].Extensions.Count > 0)
						{
							num = (short)604307462;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57C;
					case 11:
						if (collection[0].Extensions != null)
						{
							num = (short)2047934484;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57C;
					case 12:
						goto IL_3D9;
					case 13:
						rmdatabaseConnectionInfo.Instance = xattribute.Value;
						num = (short)1660420098;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						rmdatabaseConnectionInfo.RMVersion = xattribute.Value;
						num = (short)1469841412;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						rmdatabaseConnectionInfo.DBName = xattribute.Value;
						num = (short)458948627;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)2102329345;
						if (num != 0)
						{
						}
						num = (short)1549205521;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (collection.Count > 0)
						{
							num = (short)1529479173;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57C;
					case 18:
						if (xattribute != null)
						{
							num = (short)874971151;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57C;
					case 19:
						goto IL_57C;
					case 20:
						num = (short)1661206538;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (collection != null)
						{
							num = (short)1123352592;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57C;
					case 22:
						if (xelement != null)
						{
							num = (short)1039073287;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57C;
					case 23:
						if (xattribute != null)
						{
							num = (short)336068608;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D9;
					case 24:
						if (xattribute != null)
						{
							num = (short)283901966;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_522;
					}
					goto IL_12B;
					IL_37F:
					xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髽拿氁攃欅洇", a_));
					num = (short)488636434;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D9:
					xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("韽滿焁瀃朅昇椉椋", a_));
					num = (short)276824072;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_522:
					xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("雽濿焁瀃", a_));
					num = (short)1690566679;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_57C:
					result = rmdatabaseConnectionInfo;
					num = (short)1286275075;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_598:
				return result;
				IL_12B:
				collection = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(discoveryClient, new global::System.Collections.ObjectModel.Collection<global::System.Uri>
				{
					new global::System.Uri(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("賽淿㠁⬃⤅氇按缋洍缏搑焓搕愗㔙栛朝借䜡ଣ琥攧温䔫崭匯崱䈳匵䨷䌹漻嬽㈿㑁⅃㑅", a_)),
					new global::System.Uri(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("賽淿㠁⬃⤅氇按缋洍缏搑焓搕愗㔙栛朝借䜡ଣ琥攧温䴫娭儯愱儳䐵丷弹主", a_)),
					new global::System.Uri(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("賽淿㠁⬃⤅氇按缋洍缏搑焓搕愗㔙甛瀝䘟䴡ଣ戥䨧椩䌫䀭帯圱圳䈵儷唹刻眽⸿⑁⭃", a_))
				}, 1);
				num = (short)1347944469;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_C0;
			}
			finally
			{
				num = (short)770375680;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_5CD;
						}
						continue;
					case 1:
						((global::System.IDisposable)discoveryClient).Dispose();
						num = (short)92012546;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_603;
					}
					IL_5CD:
					if (discoveryClient == null)
					{
						break;
					}
					num = (short)2077097985;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_603:;
			}
			return result;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000A540 File Offset: 0x00008740
		public static global::Motorola.Security.SamlCommonUtility.RMSystemVersionInfo GetRMSystemVersionInfo(string currentUserType, string authType, string discoveryHost, int discoveryPort, string pac = "", string userName = null, global::System.Security.SecureString pswd = null, bool activating = false, string oneTimePassword = "", string jwtToken = "")
		{
			int a_ = 13;
			short num = (short)711065600;
			short num2 = num;
			num = (short)1726283776;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BD;
				}
				global::Motorola.Security.SamlCommonUtility.RMSystemVersionInfo rmsystemVersionInfo;
				global::System.Collections.ObjectModel.Collection<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> collection;
				for (;;)
				{
					IL_5A:
					global::System.Xml.Linq.XElement xelement;
					global::System.Xml.Linq.XAttribute xattribute;
					switch (num3)
					{
					case 0:
						if (xelement.Name == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("꯽烿攁瘃朅氇漉尋漍搏稑", a_))
						{
							num = (short)459997192;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return rmsystemVersionInfo;
					case 1:
						if (collection[0].Extensions != null)
						{
							num = (short)1889337350;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return rmsystemVersionInfo;
					case 2:
						if (collection[0].Scopes != null)
						{
							num = (short)1313079314;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_350;
					case 3:
						if (collection != null)
						{
							num = (short)991297550;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return rmsystemVersionInfo;
					case 4:
						num = (short)1707540482;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (xelement != null)
						{
							num = (short)1914961936;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return rmsystemVersionInfo;
					case 6:
						num = (short)1194459158;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						rmsystemVersionInfo.UpgradePath.RMVersion = xattribute.Value;
						num = (short)567214099;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						rmsystemVersionInfo.UpgradePath = new global::Motorola.Security.SamlCommonUtility.UpgradePathInfo();
						xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("賽淿琁愃琅笇按挋怍", a_));
						num = (short)180748303;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1394540545;
						if (num != 0)
						{
						}
						if (xattribute != null)
						{
							num = (short)290914317;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return rmsystemVersionInfo;
					case 10:
						if (collection[0].Scopes.Count > 0)
						{
							num = (short)466812945;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_350;
					case 11:
						xelement = collection[0].Extensions[0];
						num = (short)1542193157;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						try
						{
							num = (short)898433028;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::System.Uri> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)930873352;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Uri uri = enumerator.Current;
									num = (short)672399369;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_6B9;
								case 2:
								{
									global::System.Uri uri;
									if (uri.AbsolutePath != null)
									{
										num = (short)1177092099;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::System.Uri uri;
									string[] array = uri.AbsolutePath.Split(new char[]
									{
										'/'
									});
									num = (short)2138636299;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_4FA;
									}
									continue;
								case 5:
									goto IL_587;
								case 6:
								{
									string[] array;
									if (array[1].Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("賽淿琁愃琅笇按挋怍", a_), global::System.StringComparison.Ordinal))
									{
										num = (short)2116812807;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									string[] array;
									rmsystemVersionInfo.RMVersion = array[2];
									num = (short)1843789836;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1633943553;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::System.Uri uri;
									if (uri != null)
									{
										num = (short)547553290;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									num = (short)498073602;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									string[] array;
									if (array.Length < 3)
									{
										num = (short)1736572933;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1989672966;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									goto IL_5E9;
								}
								IL_589:
								num = (short)2010644480;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_4FA:
								goto IL_589;
							}
							IL_587:
							throw new global::System.UriFormatException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("럽滿琁攃樅愇渉Ⰻ嬍戏笑㐓瀕眗栙焛缝吟ȡ䴣䠥ࠧ礩伫䄭䀯圱", a_));
							IL_5E9:
							IL_6B9:
							goto IL_350;
						}
						finally
						{
							for (;;)
							{
								IL_6BE:
								num = (short)576323585;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::System.Uri> enumerator;
									switch (num3)
									{
									case 0:
										goto IL_770;
									case 1:
									{
										num = (short)635681234;
										short num4 = num;
										num = (short)628603346;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_6BE;
										default:
											num = (short)1111556096;
											if (num != 0)
											{
											}
											switch (0)
											{
											case 0:
												goto IL_73A;
											}
											continue;
										}
										break;
									}
									case 2:
										enumerator.Dispose();
										num = (short)1309999104;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_73A:
									if (enumerator == null)
									{
										goto IL_772;
									}
									num = (short)1023279106;
									num3 = (int)((global::System.IntPtr)num);
								}
							}
							IL_770:
							IL_772:;
						}
						goto IL_773;
					case 13:
						rmsystemVersionInfo.UpgradePath.AutoUpdate = xattribute.Value;
						num = (short)294846485;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_773;
					case 15:
						if (xattribute != null)
						{
							num = (short)552730631;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CE;
					case 16:
						num = (short)453378048;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						rmsystemVersionInfo = new global::Motorola.Security.SamlCommonUtility.RMSystemVersionInfo();
						global::System.Collections.Generic.IEnumerator<global::System.Uri> enumerator = collection[0].Scopes.GetEnumerator();
						num = (short)322764812;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						num = (short)1296171018;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_3CE;
					case 20:
						if (collection.Count > 0)
						{
							num = (short)1784741892;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return rmsystemVersionInfo;
					case 21:
						return rmsystemVersionInfo;
					case 22:
						if (collection[0].Extensions.Count > 0)
						{
							num = (short)2016739339;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return rmsystemVersionInfo;
					}
					goto IL_BD;
					IL_350:
					num = (short)846331905;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CE:
					xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("鿽痿瘁欃猅砇渉洋稍甏", a_));
					num = (short)626982921;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_773:
					num = (short)1345781780;
					num3 = (int)((global::System.IntPtr)num);
				}
				return rmsystemVersionInfo;
				IL_BD:
				rmsystemVersionInfo = null;
				collection = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(currentUserType, authType, discoveryHost, discoveryPort, pac, userName, pswd, activating, oneTimePassword, false, jwtToken), new global::System.Collections.ObjectModel.Collection<global::System.Uri>
				{
					new global::System.Uri(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("賽淿㠁⬃⤅氇按缋洍缏搑焓搕愗㔙栛朝借䜡ଣ琥攧温䔫崭匯崱䈳匵䨷䌹漻嬽㈿㑁⅃㑅", a_)),
					new global::System.Uri(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("賽淿㠁⬃⤅氇按缋洍缏搑焓搕愗㔙甛瀝䘟䴡ଣ瀥䴧堩弫䜭弯就紳堵帷唹", a_))
				}, 1);
				num = (short)1365770243;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000AD24 File Offset: 0x00008F24
		public static global::System.Collections.ObjectModel.Collection<global::Motorola.Security.SamlCommonUtility.ServiceEndpointInfo> GetServiceEndpointInfo(string currentUserType, string authType, string discoveryHost, int discoveryPort, string pac = "", string userName = null, global::System.Security.SecureString pswd = null, bool activating = false, string oneTimePassword = "", string jwtToken = "")
		{
			int a_ = 9;
			short num = (short)1628045312;
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
				global::System.Collections.ObjectModel.Collection<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> collection;
				global::System.Collections.ObjectModel.Collection<global::Motorola.Security.SamlCommonUtility.ServiceEndpointInfo> collection2;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (collection != null)
						{
							num = (short)2005467139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection2;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> enumerator = collection.GetEnumerator();
						num = (short)1071382530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)2083454979;
							num2 = (int)((global::System.IntPtr)num);
							global::System.Collections.ObjectModel.Collection<global::Motorola.Security.SamlCommonUtility.ServiceEndpointInfo> result;
							for (;;)
							{
								global::Motorola.Security.SamlCommonUtility.ServiceEndpointInfo serviceEndpointInfo;
								global::System.Xml.Linq.XAttribute xattribute;
								global::System.Xml.Linq.XElement xelement;
								string[] array2;
								switch (num2)
								{
								case 0:
									num = (short)1445396510;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1CC;
								case 2:
									serviceEndpointInfo.RMVersion = xattribute.Value;
									num = (short)1909260295;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1C7;
									}
									continue;
								case 4:
									serviceEndpointInfo.Status = xattribute.Value;
									num = (short)1063190529;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									string[] array;
									if (array[0].ToLower().Contains(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("鋹裻諽烿焁", a_)))
									{
										num = (short)458817560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2A1;
								}
								case 7:
									goto IL_4F0;
								case 8:
									xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("觹裻鿽瓿省眃", a_));
									num = (short)1547239440;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_466;
								case 10:
									if (xattribute != null)
									{
										num = (short)296222746;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_224;
								case 11:
								{
									global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
									if (endpointDiscoveryMetadata.Extensions != null)
									{
										num = (short)640090112;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_224;
								}
								case 12:
									if (xelement.Name == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("觹駻賽盿朁瘃", a_))
									{
										num = (short)913178632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_224;
								case 13:
									goto IL_224;
								case 14:
								{
									global::System.Collections.Generic.IEnumerator<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2085290013;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata = enumerator.Current;
									serviceEndpointInfo = new global::Motorola.Security.SamlCommonUtility.ServiceEndpointInfo();
									string text = endpointDiscoveryMetadata.Address.ToString();
									string[] separator = new string[]
									{
										global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("헹폻", a_)
									};
									string[] array = text.Split(separator, global::System.StringSplitOptions.RemoveEmptyEntries);
									array2 = array[1].Split(new char[]
									{
										'/'
									})[0].Split(new char[]
									{
										':'
									});
									serviceEndpointInfo.Host = array2[0];
									num = (short)62586895;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									if (array2.Length == 1)
									{
										num = (short)517931028;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2A1;
								case 16:
									if (xattribute != null)
									{
										num = (short)2016149508;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1CC;
								case 17:
									goto IL_590;
								case 18:
									result = null;
									num = (short)384761873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									num = (short)1259012121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									num = (short)1936195589;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									goto IL_466;
								case 22:
									if (xattribute != null)
									{
										num = (short)187957250;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4F0;
								case 23:
									goto IL_6D7;
								case 24:
									serviceEndpointInfo.Port = global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("컹죻췽", a_);
									num = (short)1313603605;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
								{
									global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
									if (endpointDiscoveryMetadata.Extensions.Count < 3)
									{
										num = (short)1032257554;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									xelement = endpointDiscoveryMetadata.Extensions[2];
									num = (short)231538715;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 26:
									serviceEndpointInfo.Type = xattribute.Value;
									num = (short)1213071373;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
									if (xelement != null)
									{
										num = (short)1102905372;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_224;
								case 28:
									num = (short)1141178380;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
									num = (short)1266155543;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
								{
									global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
									if (endpointDiscoveryMetadata.Extensions.Count > 0)
									{
										num = (short)781582355;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_224;
								}
								}
								goto IL_1C7;
								IL_1CC:
								xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("裹釻製旿瀁眃漅朇搉", a_));
								num = (short)1858142230;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_224:
								collection2.Add(serviceEndpointInfo);
								num = (short)506003462;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2A1:
								serviceEndpointInfo.Port = array2[1];
								num = (short)7733257;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2F4:
								num = (short)1462042638;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C7:
								goto IL_2F4;
								IL_466:
								num = (short)593625099;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4F0:
								xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("軹藻軽旿", a_));
								num = (short)453181450;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_590:
							return result;
							IL_6D7:
							return collection2;
						}
						finally
						{
							for (;;)
							{
								IL_6DC:
								num = (short)1823277057;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_796;
									case 1:
									{
										num = (short)241671014;
										short num3 = num;
										num = (short)1509727078;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_6DC;
										default:
											num = (short)1133051904;
											if (num != 0)
											{
											}
											switch (0)
											{
											case 0:
												goto IL_75D;
											}
											continue;
										}
										break;
									}
									case 2:
										enumerator.Dispose();
										num = (short)1613889536;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_75D:
									if (enumerator == null)
									{
										goto IL_798;
									}
									num = (short)30932994;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_796:
							IL_798:;
						}
						goto IL_799;
					case 3:
						num = (short)1702952961;
						if (num != 0)
						{
						}
						goto IL_799;
					case 4:
						if (collection.Count > 0)
						{
							num = (short)1182072833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection2;
					}
					goto IL_4B;
					IL_799:
					num = (short)894828548;
					num2 = (int)((global::System.IntPtr)num);
				}
				return collection2;
				IL_4B:
				collection2 = new global::System.Collections.ObjectModel.Collection<global::Motorola.Security.SamlCommonUtility.ServiceEndpointInfo>();
				global::System.ServiceModel.Discovery.DiscoveryClient a_2 = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(currentUserType, authType, discoveryHost, discoveryPort, pac, userName, pswd, activating, oneTimePassword, false, jwtToken);
				int a_3 = -1;
				global::System.Collections.ObjectModel.Collection<global::System.Uri> collection3 = new global::System.Collections.ObjectModel.Collection<global::System.Uri>();
				string uriString = global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("裹釻쓽⿿ⴁ怃漅笇椉挋砍甏怑洓㤕焗琙稛焝༟無䄣吥帧䌩伫䬭甯就倳䘵圷匹刻䨽", a_);
				collection3.Add(new global::System.Uri(uriString));
				collection = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(a_2, collection3, a_3);
				num = (short)876412928;
				short num4 = num;
				num = (short)1567490048;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000B550 File Offset: 0x00009750
		public static global::Motorola.Security.SamlCommonUtility.RMSystemDiscoveryInfo GetRMSystemDiscoveryInfo(string currentUserType, string authType, string discoveryHost, int discoveryPort, string pac = "", string userName = null, global::System.Security.SecureString pswd = null, bool activating = false, string oneTimePassword = "", string jwtToken = "")
		{
			int a_ = 14;
			short num = (short)1854865408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)2107441153;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_86;
				}
				global::Motorola.Security.SamlCommonUtility.RMSystemDiscoveryInfo rmsystemDiscoveryInfo;
				global::System.Collections.ObjectModel.Collection<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> collection;
				for (;;)
				{
					IL_57:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)755630093;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)517013507;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									string text;
									if (!(text == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("跾氀甂怄甆稈戊戌愎", a_)))
									{
										num = (short)1945763840;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string[] array;
									rmsystemDiscoveryInfo.RMVersion = array[2];
									num = (short)1813970948;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									string text;
									if (!(text == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("韾渀瀂焄", a_)))
									{
										num = (short)280035334;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string[] array;
									rmsystemDiscoveryInfo.DiscoveryServerHost = array[2];
									num = (short)683016200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Uri uri;
									if (uri.AbsolutePath != null)
									{
										num = (short)1404436494;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)1968177153;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									string[] array;
									if (array.Length < 3)
									{
										num = (short)1821179913;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = array[1];
									num = (short)1208877058;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_88F;
								case 10:
									num = (short)2017263627;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_A9F;
								case 12:
									num = (short)1282277381;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									switch (0)
									{
									case 0:
										goto IL_838;
									}
									continue;
								case 14:
								{
									global::System.Uri uri;
									string[] array = uri.AbsolutePath.Split(new char[]
									{
										'/'
									});
									num = (short)2102001671;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
								{
									global::System.Collections.Generic.IEnumerator<global::System.Uri> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1717239818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Uri uri = enumerator.Current;
									num = (short)87490576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
								{
									global::System.Uri uri;
									if (uri != null)
									{
										num = (short)1986789388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_9C4:
								num = (short)1063845903;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_838:
								goto IL_9C4;
							}
							IL_88F:
							throw new global::System.UriFormatException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뛾漀甂搄欆怈漊ⴌ娎挐稒㔔焖瘘椚瀜縞唠̢䰤䤦न砪丬䀮䄰嘲", a_));
							IL_A9F:
							goto IL_175;
						}
						finally
						{
							num = (short)861732864;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::System.Uri> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_ABB;
								case 1:
									goto IL_B5E;
								case 2:
								{
									num = (short)609431114;
									short num3 = num;
									num = (short)1231367754;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_ABB;
									default:
										num = (short)816054272;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)1476067329;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_AD8;
								IL_ABB:
								switch (0)
								{
								case 0:
									IL_AD8:
									if (enumerator == null)
									{
										goto IL_B60;
									}
									num = (short)1664745474;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_B5E:
							IL_B60:;
						}
						return rmsystemDiscoveryInfo;
						IL_175:
						num = (short)1655439369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_73F;
					case 2:
						if (collection[0].Extensions.Count > 0)
						{
							num = (short)881524741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return rmsystemDiscoveryInfo;
					case 3:
						num = (short)1280704514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						rmsystemDiscoveryInfo = new global::Motorola.Security.SamlCommonUtility.RMSystemDiscoveryInfo();
						global::System.Collections.Generic.IEnumerator<global::System.Uri> enumerator = collection[0].Scopes.GetEnumerator();
						num = (short)1307049984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2 = collection[0].Extensions.GetEnumerator();
						num = (short)1590165511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (collection != null)
						{
							num = (short)25559041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return rmsystemDiscoveryInfo;
					case 7:
						try
						{
							num = (short)1424556054;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Xml.Linq.XAttribute xattribute;
								global::System.Xml.Linq.XElement xelement;
								global::System.Xml.Linq.XAttribute xattribute2;
								switch (num2)
								{
								case 0:
									goto IL_468;
								case 1:
									if (xattribute != null)
									{
										num = (short)1744044050;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_51A;
								case 2:
									num = (short)444334100;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									rmsystemDiscoveryInfo.DBConnectionInfo.RMVersion = xattribute.Value;
									num = (short)185663513;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (xelement.Name == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("꫾焀搂眄昆洈渊崌渎攐笒", a_))
									{
										num = (short)301596687;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									rmsystemDiscoveryInfo.DBConnectionInfo.DBName = xattribute.Value;
									num = (short)2003042312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									rmsystemDiscoveryInfo.UpgradePathInfo.RMVersion = xattribute2.Value;
									num = (short)775684096;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (xelement.Name == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("믾怀眂搄攆栈砊栌䰎縐紒笔爖稘漚琜瀞传", a_))
									{
										num = (short)1769340951;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1677393924;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (xattribute != null)
									{
										num = (short)463732750;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2F5;
								case 10:
									rmsystemDiscoveryInfo.UpgradePathInfo.AutoUpdate = xattribute2.Value;
									num = (short)976420875;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_2F5;
								case 13:
									if (xattribute != null)
									{
										num = (short)1753415683;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B2;
								case 14:
									rmsystemDiscoveryInfo.DBConnectionInfo.Host = xattribute.Value;
									num = (short)208601100;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									xattribute2 = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("跾氀甂怄甆稈戊戌愎", a_));
									num = (short)770244627;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
								{
									global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)661389314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									xelement = enumerator2.Current;
									num = (short)453967879;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
									if (xattribute != null)
									{
										num = (short)2070151173;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 18:
									rmsystemDiscoveryInfo.DBConnectionInfo.Instance = xattribute.Value;
									num = (short)1288110104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									if (xattribute2 != null)
									{
										num = (short)239534086;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_468;
								case 20:
									goto IL_6CD;
								case 21:
									if (xattribute2 != null)
									{
										num = (short)711655434;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 22:
									switch (0)
									{
									case 0:
										goto IL_282;
									}
									continue;
								case 23:
									xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("跾氀甂怄甆稈戊戌愎", a_));
									num = (short)1982726157;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									goto IL_51A;
								case 25:
									goto IL_3B2;
								}
								IL_2B3:
								num = (short)2044919824;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_282:
								goto IL_2B3;
								IL_2F5:
								xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("雾漀瀂焄昆月栊栌", a_));
								num = (short)556924929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3B2:
								xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("韾渀瀂焄", a_));
								num = (short)2094465033;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_468:
								xattribute2 = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("黾琀眂樄爆礈漊氌笎琐", a_));
								num = (short)803864597;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_51A:
								xattribute = xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("鯾挀洂搄樆氈", a_));
								num = (short)500563985;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6CD:
							return rmsystemDiscoveryInfo;
						}
						finally
						{
							num = (short)1093533696;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_705;
									}
									continue;
								case 1:
									goto IL_73C;
								case 2:
									enumerator2.Dispose();
									num = (short)1234632705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_705:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1920008194;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_73C:;
						}
						goto IL_73F;
					case 8:
						if (collection.Count > 0)
						{
							num = (short)463732740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return rmsystemDiscoveryInfo;
					case 9:
						if (collection[0].Extensions != null)
						{
							num = (short)545193987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return rmsystemDiscoveryInfo;
					}
					goto IL_86;
					IL_73F:
					num = (short)676134920;
					num2 = (int)((global::System.IntPtr)num);
				}
				return rmsystemDiscoveryInfo;
				IL_86:
				num = (short)789446656;
				short num4 = num;
				rmsystemDiscoveryInfo = null;
				collection = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(currentUserType, authType, discoveryHost, discoveryPort, pac, userName, pswd, activating, oneTimePassword, false, jwtToken), new global::System.Collections.ObjectModel.Collection<global::System.Uri>
				{
					new global::System.Uri(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("跾氀㤂⨄⠆洈戊縌氎縐攒瀔攖怘㐚検昞儠䘢ਤ甦搨漪䐬尮到尲䌴制䬸䈺渼娾㍀㕂⁄㕆", a_)),
					new global::System.Uri(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("跾氀㤂⨄⠆洈戊縌氎縐攒瀔攖怘㐚琜焞䜠䰢ਤ琦䰨太嬬䨮䌰稲嬴儶嘸", a_))
				}, 1);
				num = (short)373817350;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_57;
			}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
		private static global::System.ServiceModel.Discovery.DiscoveryClient a(string A_0, string A_1, string A_2, int A_3, string A_4, string A_5, global::System.Security.SecureString A_6, bool A_7, string A_8, bool A_9 = false, string A_10 = "")
		{
			int a_ = 12;
			short num = (short)1412497408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				for (;;)
				{
					IL_31:
					global::Motorola.Security.SamlTokenComponent.DiscoveryEndpointInfo discoveryEndpointInfo;
					global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.DiscoveryEndpointInfo>.Enumerator enumerator;
					string text;
					switch (num2)
					{
					case 0:
						goto IL_5CD;
					case 1:
					{
						if (discoveryEndpointInfo == null)
						{
							num = (short)1858404352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.ServiceModel.Channels.CustomBinding binding = new global::System.ServiceModel.Channels.CustomBinding(discoveryEndpointInfo.bindingConfiguration);
						global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.AddCustomAttribute(binding, A_0, A_1, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("꿼닾䔀樂瘄搆昈紊栌紎栐䀒瀔攖漘縚漜", a_), A_2, A_3, A_4, A_7, A_8, A_9, A_10);
						global::System.ServiceModel.EndpointAddress endpointAddress = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(discoveryEndpointInfo, A_2, A_3);
						num = (short)390004740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.b())
						{
							num = (short)780468227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55B;
					case 3:
						goto IL_48D;
					case 4:
						goto IL_556;
					case 5:
						try
						{
							num = (short)1636958211;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1949663233;
									short num3 = num;
									num = (short)2106818561;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)939196416;
										if (num != 0)
										{
										}
										if (enumerator.MoveNext())
										{
											global::Motorola.Security.SamlTokenComponent.DiscoveryEndpointInfo discoveryEndpointInfo2 = enumerator.Current;
											num = (short)800915460;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									num = (short)1253179397;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_47A;
								case 2:
									goto IL_45D;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_36E;
									}
									continue;
								case 4:
								{
									global::Motorola.Security.SamlTokenComponent.DiscoveryEndpointInfo discoveryEndpointInfo2;
									if (string.Equals(discoveryEndpointInfo2.binding, text, global::System.StringComparison.Ordinal))
									{
										num = (short)1785135110;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)610336769;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.Security.SamlTokenComponent.DiscoveryEndpointInfo discoveryEndpointInfo2;
									discoveryEndpointInfo = discoveryEndpointInfo2;
									num = (short)1431437314;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_3B9:
								num = (short)76152832;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_36E:
								goto IL_3B9;
							}
							IL_45D:
							IL_47A:
							goto IL_595;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_48D;
						IL_595:
						num = (short)887947265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_50;
					IL_48D:
					text = global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("黼諾爀眂樄樆䬈戊挌欎砐紒爔", a_);
					discoveryEndpointInfo = null;
					enumerator = ((global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.DiscoveryEndpointInfo>)global::System.Configuration.ConfigurationManager.GetSection(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("맼雾爀怂樄焆氈礊琌導琐瀒愔縖瘘甚", a_))).GetEnumerator();
					num = (short)1364918272;
					short num4 = num;
					num = (short)776929285;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_318:
				throw new global::System.Exception(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("듼釾眀戂椄渆洈⬊䤌明成瀒稔愖簘椚搜娞传䜢唤䠦䀨䔪夬༮到尲嬴儶倸尺䠼䴾⁀㝂ⱄ⡆❈橊", a_));
				IL_556:
				global::System.ServiceModel.Discovery.DiscoveryClient discoveryClient;
				global::System.ServiceModel.Discovery.DiscoveryClient result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_D2;
					}
					for (;;)
					{
						IL_9F:
						switch (num2)
						{
						case 0:
							goto IL_2A7;
						case 1:
							goto IL_269;
						case 2:
							if (string.IsNullOrEmpty(A_5))
							{
								num = (short)1840513025;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(discoveryClient.ChannelFactory, A_5, A_6);
							num = (short)32964616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)1021050890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_173;
						case 5:
							if (A_1 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("꣼賾搀焂䬄昆搈渊", a_))
							{
								num = (short)2074935305;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_26E;
						case 6:
							goto IL_26E;
						case 7:
							if (!(A_1 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뻼髾猀眂氄愆怈栊氌笎琐", a_)))
							{
								num = (short)591134723;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_173;
						case 8:
							goto IL_26E;
						case 9:
							num = (short)1491402754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (A_1 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("럼裾甀圂樄氆氈攊", a_))
							{
								num = (short)1220214788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1095041029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2;
						IL_173:
						discoveryClient.SetCertificate();
						num = (short)1002176518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_26E:
						discoveryClient.ChannelFactory.Credentials.ServiceCertificate.Authentication.RevocationMode = global::System.Security.Cryptography.X509Certificates.X509RevocationMode.NoCheck;
						result = discoveryClient;
						discoveryClient = null;
						num = (short)1136852992;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_269:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DISCOVERY_LOGIN_FAILED, new global::System.ArgumentException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("裼賾搀焂䬄昆搈渊", a_)));
					IL_2A7:
					return result;
					IL_D2:
					global::System.ServiceModel.Channels.CustomBinding binding;
					global::System.ServiceModel.EndpointAddress endpointAddress;
					discoveryClient = new global::System.ServiceModel.Discovery.DiscoveryClient(new global::System.ServiceModel.Discovery.DiscoveryEndpoint(binding, endpointAddress));
					num = (short)1580138503;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_9F;
				}
				finally
				{
					num = (short)1627127808;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_2DE;
							}
							continue;
						case 1:
							goto IL_315;
						case 2:
							discoveryClient.Close();
							num = (short)1954021377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2DE:
						if (discoveryClient == null)
						{
							break;
						}
						num = (short)1009451010;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_315:;
				}
				goto IL_318;
				IL_55B:
				num = (short)867303425;
				if (num != 0)
				{
				}
				throw new global::System.PlatformNotSupportedException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꧼ韾栀瀂┄眆攈樊礌椎縐愒研㜖瀘栚㴜焞丠圢Ԥ否尨嬪崬䀮䌰䜲倴匶᜸", a_));
				IL_5CD:
				goto IL_318;
				IL_50:
				result = null;
				discoveryClient = null;
				global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.c(A_0);
				num = (short)220332034;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000C708 File Offset: 0x0000A908
		private static global::System.Collections.ObjectModel.Collection<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> a(global::System.ServiceModel.Discovery.DiscoveryClient A_0, global::System.Type A_1, string A_2, int A_3 = 2)
		{
			int a_ = 5;
			short num = (short)1415643136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)954138624;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				global::System.Collections.ObjectModel.Collection<global::System.Uri> collection;
				global::System.Collections.ObjectModel.Collection<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> result;
				for (;;)
				{
					IL_5A:
					switch (num2)
					{
					case 0:
					{
						num = (short)1352534827;
						short num4 = num;
						num = (short)1390021419;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)419299328;
							if (num != 0)
							{
							}
							collection = new global::System.Collections.ObjectModel.Collection<global::System.Uri>();
							string serverScopeFromServiceTypeName = global::Motorola.Security.SamlCommonUtility.TypeConverter.GetServerScopeFromServiceTypeName(A_2);
							string uriString = global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("蓵闷샹폻퇽擿欁眃攅朇簉椋簍椏㴑朓戕礗渙椛洝༟洡䨣䨥䄧䐩䤫", a_);
							string uriString2 = global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("蓵闷샹폻퇽擿欁眃攅朇簉椋簍椏㴑紓砕縗甙㌛䴝䔟倡刣伥䬧伩椫䀭启䈱嬳張嘷丹", a_);
							collection.Add(new global::System.Uri(serverScopeFromServiceTypeName));
							collection.Add(new global::System.Uri(uriString));
							collection.Add(new global::System.Uri(uriString2));
							num = (short)1831993346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						if (A_0 != null)
						{
							num = (short)545259520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						goto IL_156;
					}
					goto IL_6D;
				}
				IL_156:
				num = (short)855769089;
				if (num != 0)
				{
				}
				try
				{
					switch (0)
					{
					case 0:
						goto IL_1A0;
					}
					global::System.ServiceModel.Discovery.FindCriteria findCriteria;
					for (;;)
					{
						IL_189:
						global::System.Collections.Generic.IEnumerator<global::System.Uri> enumerator;
						switch (num2)
						{
						case 0:
							if (collection != null)
							{
								num = (short)1332346882;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_32F;
						case 1:
							try
							{
								num = (short)2146697217;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)795607042;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_218;
										}
										continue;
									case 2:
										goto IL_297;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1826095104;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Uri item = enumerator.Current;
										findCriteria.Scopes.Add(item);
										num = (short)2142699524;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_21A:
									num = (short)1915879427;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_218:
									goto IL_21A;
								}
								IL_297:
								goto IL_32F;
							}
							finally
							{
								num = (short)449642497;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)806027266;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_2CF;
										}
										continue;
									case 2:
										goto IL_307;
									}
									IL_2CF:
									if (enumerator == null)
									{
										break;
									}
									num = (short)2067595264;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_307:;
							}
							goto IL_30A;
						case 2:
							goto IL_30A;
						case 3:
							goto IL_35E;
						}
						goto IL_1A0;
						IL_30A:
						enumerator = collection.GetEnumerator();
						num = (short)950730753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_32F:
						findCriteria.MaxResults = A_3;
						result = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(A_0, findCriteria).Endpoints;
						num = (short)205324291;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_35E:
					return result;
					IL_1A0:
					findCriteria = new global::System.ServiceModel.Discovery.FindCriteria(A_1);
					num = (short)1966407680;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_189;
				}
				catch (global::System.ServiceModel.FaultException)
				{
					throw;
				}
				catch (global::System.ServiceModel.CommunicationObjectFaultedException)
				{
					throw;
				}
				catch (global::System.Reflection.TargetInvocationException ex)
				{
					if (ex.InnerException == null)
					{
						throw;
					}
					if (ex.InnerException is global::System.ServiceModel.FaultException && ((global::System.ServiceModel.FaultException)ex.InnerException).Reason.ToString() == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꏵ꯷뿹껻ꇽ仿䴁倃夅䤇䤉堋䜍䘏匑䀓匕尗", a_))
					{
						throw;
					}
					if (ex.InnerException is global::System.ServiceModel.FaultException && ((global::System.ServiceModel.FaultException)ex.InnerException).Reason.ToString() == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("믵맷맹듻럽仿䜁嬃䠅䜇帉匋伍匏䘑崓䀕夗丙夛娝", a_))
					{
						throw;
					}
					if (ex.InnerException is global::System.ServiceModel.FaultException && ((global::System.ServiceModel.FaultException)ex.InnerException).Reason.ToString() == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꗵ뷷맹ꧻ곽䧿嘁崃夅將䔉䜋䬍帏䴑䘓匕䤗伙夛䴝琟紡猣朥笧甩栫欭縯笱焳爵", a_))
					{
						throw;
					}
					if (ex.InnerException is global::System.ServiceModel.CommunicationObjectFaultedException)
					{
						throw;
					}
					if (ex.InnerException is global::System.ServiceModel.EndpointNotFoundException)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.TARGET_DISCOVERYSERVER_NOT_AVAILABLE, ex);
					}
					throw;
				}
				catch (global::System.Exception ex2)
				{
					global::System.Console.WriteLine(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꋵ郷鏹迻\udefd揿渁洃挅昇縉Ⰻ礍焏愑㐓挕瘗笙縛爝䔟ȡ倣䤥ࠧ䤩䌫䀭帯圱圳䈵ᠷ丹医ḽ㐿⩁⅃晅ే⍉㽋ⵍ㽏⑑ㅓ⑕⅗穙ཛ㭝቟ᑡൣե൧偩䱫ᕭ䁯ཱ", a_), ex2.Message);
					if (ex2.InnerException != null)
					{
						global::System.Console.WriteLine(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("훵뇷铹鋻鯽狿∁愃縅欇漉簋稍礏紑稓Ⱅ㠗愙Ⱋ挝", a_), ex2.InnerException.Message);
					}
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꗵ駷韹ꣻ釽毿朁樃丅洇昉簋欍戏", a_)).Error(ex2, ex2.Message);
				}
				return result;
				IL_6D:
				result = null;
				num = (short)480903169;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000CC80 File Offset: 0x0000AE80
		private static global::System.Collections.ObjectModel.Collection<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> a(global::System.ServiceModel.Discovery.DiscoveryClient A_0, global::System.Collections.ObjectModel.Collection<global::System.Uri> A_1, int A_2 = 1)
		{
			int a_ = 6;
			short num = (short)557580288;
			short num2 = num;
			num = (short)162008709;
			short num3 = num;
			num = (short)428478085;
			global::System.Collections.ObjectModel.Collection<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)773455873;
				if (num != 0)
				{
				}
				num = (short)969015296;
				if (num != 0)
				{
				}
				num = (short)76808192;
				int num4 = (int)num;
				switch (num4)
				{
				default:
					result = null;
					if (A_0 == null)
					{
						return result;
					}
					break;
				}
				break;
			}
			}
			try
			{
				switch (0)
				{
				case 0:
					goto IL_FA;
				}
				int num4;
				global::System.ServiceModel.Discovery.FindCriteria findCriteria;
				for (;;)
				{
					IL_D7:
					switch (num4)
					{
					case 0:
						if (A_2 > -1)
						{
							num = (short)81395714;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D8;
					case 1:
						if (A_1 != null)
						{
							num = (short)597491715;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_151;
					case 2:
						findCriteria.MaxResults = A_2;
						num = (short)283049990;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Collections.Generic.IEnumerator<global::System.Uri> enumerator = A_1.GetEnumerator();
						num = (short)167313413;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_2FF;
					case 5:
						try
						{
							num = (short)333709313;
							num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									num = (short)561577986;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1EB;
									}
									continue;
								case 2:
									goto IL_267;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::System.Uri> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1414397952;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Uri item = enumerator.Current;
									findCriteria.Scopes.Add(item);
									num = (short)909705220;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1ED:
								num = (short)2011693059;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_1EB:
								goto IL_1ED;
							}
							IL_267:
							goto IL_151;
						}
						finally
						{
							num = (short)866975745;
							num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::System.Uri> enumerator;
								switch (num4)
								{
								case 0:
									enumerator.Dispose();
									num = (short)22806530;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_29E;
									}
									continue;
								case 2:
									goto IL_2D5;
								}
								IL_29E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1267728384;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_2D5:;
						}
						goto IL_2D8;
					case 6:
						goto IL_2D8;
					}
					goto IL_FA;
					IL_151:
					num = (short)1106640896;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D8:
					result = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(A_0, findCriteria).Endpoints;
					num = (short)876806148;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_2FF:
				return result;
				IL_FA:
				findCriteria = new global::System.ServiceModel.Discovery.FindCriteria();
				num = (short)536018945;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_D7;
			}
			catch (global::System.ServiceModel.CommunicationObjectFaultedException)
			{
				throw;
			}
			catch (global::System.Reflection.TargetInvocationException ex)
			{
				if (ex.InnerException != null && ex.InnerException is global::System.ServiceModel.CommunicationObjectFaultedException)
				{
					throw;
				}
			}
			catch (global::System.Exception ex2)
			{
				global::System.Console.WriteLine(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꏶ釸鋺軼\udffe戀漂氄戆月缊ⴌ砎瀐怒㔔或眘稚缜猞䐠̢儤䠦न䠪䈬䄮弰嘲嘴䌶ᤸ伺刼Ἶ㕀⭂⁄杆ൈ≊㹌ⱎ㹐╒ご╖⁘筚๜㩞፠ᕢ౤Ѧ౨兪䵬ᑮ䅰๲", a_), ex2.Message);
				if (ex2.InnerException != null)
				{
					global::System.Console.WriteLine(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ퟶ냸闺鏼髾猀⌂怄缆樈渊紌笎砐簒笔ⴖ㤘怚ⴜ戞", a_), ex2.InnerException.Message);
				}
			}
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000D064 File Offset: 0x0000B264
		private static void a(string A_0, global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.CertificateObj> A_1)
		{
			int a_ = 0;
			short num = (short)1663107073;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Security.SamlTokenComponent.CertificateObj item;
			for (;;)
			{
				global::System.Collections.Generic.IEnumerable<global::Motorola.Security.SamlTokenComponent.CertificateObj> enumerable;
				switch (num2)
				{
				case 0:
					item = A_1.Find(new global::System.Predicate<global::Motorola.Security.SamlTokenComponent.CertificateObj>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c.<>9.h));
					num = (short)737804296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					continue;
				case 2:
					if (A_0 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("諰웲쓴샶컸뫺쿼쟾\u3000⸂㌄䐆㸈㼊‌㬎匐☒圔㨖堘弚⨜⨞ఠᐢ昤ሦḨ株欬ᴮ爰ز̴瘶ਸ䘺", a_))
					{
						num = (short)2076573727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1463025687;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_662;
				case 4:
					goto IL_306;
				case 5:
					goto IL_599;
				case 6:
					item = A_1.Find(new global::System.Predicate<global::Motorola.Security.SamlTokenComponent.CertificateObj>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c.<>9.g));
					num = (short)2076246021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)775946257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_642;
				case 9:
					num = (short)285605903;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					if (A_0 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("諰쏲돴샶컸싺쳼쿾㔀⸂㌄㔆〈㨊‌㬎✐ℒ␔㨖嬘⸚弜嬞ఠ攢挤ဦᬨ漪ᨬḮܰȲ焴༶缸䘺", a_))
					{
						num = (short)383713296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1097400320;
					short num3 = num;
					num = (short)89887422;
					short num4 = num;
					num = (short)343970494;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_426;
					default:
						num = (short)5570560;
						if (num != 0)
						{
						}
						num = (short)2130378754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					goto IL_1BC;
				case 12:
					item = A_1.Find(new global::System.Predicate<global::Motorola.Security.SamlTokenComponent.CertificateObj>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c.<>9.e));
					num = (short)415694867;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)1699151884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (A_0 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("諰엲웴뇶쿸쯺민볾㈀⸂〄㔆ㄈ㸊‌㬎ℐ┒✔㨖‘⤚⸜⼞ఠᐢᴤ搦漨ጪ氬椮԰в眴༶സ䘺", a_))
					{
						num = (short)987365406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)776732701;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					item = A_1.Find(new global::System.Predicate<global::Motorola.Security.SamlTokenComponent.CertificateObj>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c.<>9.c));
					num = (short)1639710741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_426;
				case 17:
					item = A_1.Find(new global::System.Predicate<global::Motorola.Security.SamlTokenComponent.CertificateObj>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c.<>9.b));
					num = (short)1663827979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (A_0 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("諰쯲쇴쏶쯸뫺룼뫾㠀⸂䘄ㄆ㠈㬊‌㬎圐嘒圔㨖℘⸚⨜⠞ఠᄢᰤဦḨ株ᐬᜮ爰Բ焴父ସ䘺", a_))
					{
						num = (short)1562902535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)35455000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_3B0;
				case 20:
					global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(enumerable);
					num = (short)2037907474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_261;
				case 22:
					if (enumerable.Count<global::Motorola.Security.SamlTokenComponent.CertificateObj>() > 1)
					{
						num = (short)249561108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					item = enumerable.First<global::Motorola.Security.SamlTokenComponent.CertificateObj>();
					num = (short)15663107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (A_0 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("諰싲냴뛶쇸죺쿼컾䀀⸂㘄〆㴈䨊‌㬎⤐⬒ⴔ㨖℘⌚ⴜ帞ఠᐢᔤ愦ᴨᴪᰬᠮ眰زش父༸䘺", a_))
					{
						num = (short)1027276826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_664;
				case 24:
					if (A_0 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("諰뗲럴닶쇸뿺볼뫾㐀⸂㜄㼆伈㴊‌㬎⤐☒℔㨖堘ⴚ帜⤞ఠ怢ᐤᐦᄨጪ欬樮爰甲猴Ķ砸䘺", a_))
					{
						num = (short)517275657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)938934286;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_480;
				case 26:
					num = (short)1209794560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					item = A_1.Find(new global::System.Predicate<global::Motorola.Security.SamlTokenComponent.CertificateObj>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c.<>9.f));
					num = (short)2029256729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					item = A_1.Find(new global::System.Predicate<global::Motorola.Security.SamlTokenComponent.CertificateObj>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c.<>9.d));
					num = (short)385744900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (A_0 == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("諰쫲뛴쟶째룺뿼볾㄀⸂㔄䘆㼈㈊‌㬎倐−∔㨖嬘⠚␜⤞ఠ怢ᴤ愦ဨᴪἬḮर瘲眴̶ସ䘺", a_))
					{
						num = (short)137101325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1721237514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					num = (short)1300037660;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					num = (short)1764622342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AF:
				enumerable = A_1.Where(new global::System.Func<global::Motorola.Security.SamlTokenComponent.CertificateObj, bool>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c.<>9.a));
				item = null;
				num = (short)1446051862;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_426:
				num = (short)1460928539;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1BC:
			IL_261:
			IL_306:
			goto IL_664;
			IL_3B0:
			num = (short)779878401;
			if (num != 0)
			{
			}
			IL_480:
			IL_599:
			IL_642:
			IL_662:
			IL_664:
			A_1.Clear();
			A_1.Add(item);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
		private static void a(global::System.Collections.Generic.IEnumerable<global::Motorola.Security.SamlTokenComponent.CertificateObj> A_0)
		{
			global::System.Collections.Generic.IEnumerator<global::Motorola.Security.SamlTokenComponent.CertificateObj> enumerator = A_0.GetEnumerator();
			short num;
			try
			{
				num = (short)20119552;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)874188579;
						short num3 = num;
						num = (short)1921716003;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1812201472;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_8F;
							}
							continue;
						}
						break;
					}
					case 1:
						if (!enumerator.MoveNext())
						{
							num = (short)1664548869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1501691906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (string.IsNullOrEmpty(enumerator.Current.clientType))
						{
							num = (short)490209284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 3:
						goto IL_127;
					case 4:
						goto IL_CD;
					case 5:
						num = (short)421199875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CF:
					num = (short)2099511297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8F:
					goto IL_CF;
				}
				IL_CD:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.X509ClientCertificateNameNotMatch);
				IL_127:;
			}
			finally
			{
				num = (short)1581842433;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1701314562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_15B;
						}
						continue;
					case 2:
						goto IL_190;
					}
					IL_15B:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1881407488;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_190:;
			}
			num = (short)1627193344;
			short num4 = num;
			num = (short)1013514241;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		public static void ValidateCertificate(string currentUserType)
		{
			int a_ = 12;
			short num = (short)1494024193;
			if (num != 0)
			{
			}
			num = (short)102055315;
			short num2 = num;
			num = (short)1406418323;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1958019072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)454819840;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.CertificateObj> list = new global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.CertificateObj>((global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.CertificateObj>)global::System.Configuration.ConfigurationManager.GetSection(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뻼髾猀眂氄愆怈栊氌笎琐䀒瀔琖洘爚爜焞", a_)));
			global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(currentUserType, list);
			global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(list, currentUserType);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
		private static void a(global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.CertificateObj> A_0, string A_1)
		{
			int a_ = 9;
			short num = (short)968097797;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Security.SamlTokenComponent.CertificateObj certificateObj;
			for (;;)
			{
				global::System.Security.Cryptography.X509Certificates.StoreLocation storeLocation;
				switch (num2)
				{
				case 0:
					if (A_1.Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("臹췻믽䇿㨁㜃㐅㤇䬉ℋ㴍✏☑唓㬕Ⱇ∙␛☝ടᨡᰣᘥ椧ܩᬫḭ瘯رȳ༷ܵ簹ऻഽԿ瑁㥃", a_)))
					{
						num = (short)1950810112;
						short num3 = num;
						num = (short)1399783431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D9;
				case 1:
					if (storeLocation.ToString().Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("맹觻賽狿朁樃爅崇礉椋簍", a_)))
					{
						num = (short)77856777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D9;
				case 2:
					if (!A_1.Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("臹뫻볽䗿㨁䀃䜅䴇㼉ℋ㰍⠏向∓㬕Ⱇ∙⤛⨝ട挡ሣ攥ḧܩ漫Ἥ̯਱ళ瀵紷礹稻砽瘿́㥃", a_)))
					{
						num = (short)1467875332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24D;
				case 3:
				{
					num = (short)871086076;
					short num4 = num;
					num = (short)2029500412;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_327;
					default:
						num = (short)320929792;
						if (num != 0)
						{
						}
						num = (short)2063925248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					num = (short)920649739;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					continue;
				case 6:
					num = (short)2027225090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_24D;
				case 8:
					if (!global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.IsCustomerCertificateInStore(certificateObj.storeLocation, certificateObj.storeName, certificateObj.value.ToString()))
					{
						num = (short)1601437706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					num = (short)988217358;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_29D;
				case 11:
					if (!A_1.Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("臹쫻췽䛿㐁㐃䀅䬇㤉ℋ㬍∏⨑ℓ㬕Ⱇ⨙⨛Ⱍടᬡᘣᔥᠧܩᬫᘭ猯琱ళ眵縷ู଻簽砿癁㥃", a_)))
					{
						num = (short)433455107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24D;
				case 12:
					goto IL_22F;
				case 13:
					if (!global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.IsCertificateInStore(certificateObj.storeLocation, certificateObj.storeName, certificateObj.findType, certificateObj.value.ToString()))
					{
						num = (short)1278279692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 14:
					if (!A_1.Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("臹쓻쫽㓿、䔃䌅䴇㌉ℋ䴍☏⌑␓㬕Ⱇ尙夛尝ടᨡᄣᄥἧܩḫᜭܯԱ眳༵7礹਻稽Կ灁㥃", a_)))
					{
						goto IL_327;
					}
					goto IL_24D;
				}
				IL_6A:
				num = (short)1235484673;
				if (num != 0)
				{
				}
				certificateObj = A_0.Find(new global::System.Predicate<global::Motorola.Security.SamlTokenComponent.CertificateObj>(global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.<>c.<>9.i));
				storeLocation = certificateObj.storeLocation;
				num = (short)1575747585;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D9:
				num = (short)1655308301;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_24D:
				num = (short)196542472;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_327:
				num = (short)1798832134;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_22F:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.X509ClientCertificateNotInstalled);
			IL_29D:
			global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.ImportClientCertificate(certificateObj.value.ToString(), false);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000DD70 File Offset: 0x0000BF70
		public static void ImportClientCertificate(string certificateName, bool forceReplace = false)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			string text;
			short num2;
			string text2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)382402560;
						short num3 = num2;
						num2 = (short)179372033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2FE;
				case 1:
					num2 = (short)1148125190;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_2F9;
				case 3:
				{
					num2 = (short)501084214;
					short num4 = num2;
					num2 = (short)129626166;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)831979520;
						if (num2 != 0)
						{
						}
						if (certificateName == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뇱鯳鯵闷闹鋻뷽烿焁㘃㌅㸇䤉怋服甏簑怓", a_))
						{
							num2 = (short)878247941;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_322;
					}
					break;
				}
				case 4:
					goto IL_322;
				case 5:
					text2 = global::System.IO.Path.Combine(text, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("釱蓳藵ꟷ駹郻韽旿氁瀃夅欇漉縋稍伏愑簓眕⨗⼙⨛〝借䐡尣", a_));
					num2 = (short)80871428;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (global::System.IO.Directory.Exists(text))
					{
						num2 = (short)1465516041;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2FE;
				case 7:
					goto IL_359;
				case 8:
				{
					if (!global::System.IO.File.Exists(text2))
					{
						num2 = (short)726990855;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Security.SecureString secureString = global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.c(text);
					num2 = (short)613548034;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					text2 = null;
					num2 = (short)1240268803;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_41;
				IL_322:
				num2 = (short)926351368;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1DD:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.X509ClientCertificatePathNotFound, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("釱釳蓵賷\udaf9賻鿽瓿樁␃瘅椇砉砋⸍縏紑怓㘕縗甙椛瀝䐟ȡ弣ᘥ唧", a_), text2));
			IL_2F9:
			try
			{
				num2 = (short)340918272;
				num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_F2;
						}
						continue;
					case 1:
						goto IL_171;
					case 2:
						goto IL_133;
					}
					IL_F2:
					global::System.Security.SecureString secureString;
					if (!certificateName.Equals(global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.ImportCertificateToStore(text2, secureString, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뇱至蓵諷鿹鋻諽嗿焁愃琅", a_), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뿱跳", a_), forceReplace)))
					{
						num2 = (short)1119813634;
						num = (int)((global::System.IntPtr)num2);
					}
					else
					{
						num2 = (short)749273089;
						num = (int)((global::System.IntPtr)num2);
					}
				}
				IL_133:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.X509ClientCertificateNameNotMatch, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("믱駳蛵韷裹裻\udefd揿朁瘃爅愇氉攋洍焏昑焓㘕挗⨙愛㸝䘟䌡䴣䨥䴧丩", a_), certificateName));
				IL_171:
				goto IL_38E;
			}
			finally
			{
				num2 = (short)2073952256;
				num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					global::System.Security.SecureString secureString;
					switch (num)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_1A7;
						}
						continue;
					case 1:
						goto IL_1DA;
					case 2:
						((global::System.IDisposable)secureString).Dispose();
						num2 = (short)1243283457;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					IL_1A7:
					if (secureString == null)
					{
						break;
					}
					num2 = (short)212008962;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1DA:;
			}
			goto IL_1DD;
			IL_38E:
			num2 = (short)1123942401;
			if (num2 != 0)
			{
			}
			return;
			IL_2FE:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.X509ClientCertificatePathNotFound, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("鯱髳闵韷裹軻鯽揿瘁␃攅洇砉砋䨍礏怑㐓洕⠗朙", a_), text));
			IL_359:
			goto IL_1DD;
			IL_41:
			text = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뿱鯳苵韷裹鏻鋽懿币䜃椅攇有挋怍匏䈑䜓", a_));
			num2 = (short)1698562048;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000E144 File Offset: 0x0000C344
		private static void c(string A_0)
		{
			short num = (short)2075656192;
			short num2 = num;
			num = (short)1226506241;
			if (num != 0)
			{
			}
			num = (short)224953077;
			short num3 = num;
			num = (short)1842774773;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)289341440;
				if (num != 0)
				{
				}
				if (global::Motorola.Security.SamlCommonUtility.EnvironmentUtility.GetUserTypeList().Contains(A_0))
				{
					return;
				}
				break;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000E204 File Offset: 0x0000C404
		private static bool b(string A_0)
		{
			int a_ = 10;
			short num = (short)517437530;
			short num2 = num;
			num = (short)305363034;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_98;
			default:
				num = (short)3342336;
				if (num != 0)
				{
				}
				num = (short)1715732481;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_98;
				}
				break;
			}
			int num3;
			bool result;
			for (;;)
			{
				IL_86:
				switch (num3)
				{
				case 0:
					if (A_0 == null)
					{
						num = (short)166526978;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F2;
				case 1:
					try
					{
						result = global::Motorola.Security.SamlCommonUtility.NetworkInfoUtility.IsLocalHost(A_0);
						goto IL_134;
					}
					catch (global::System.Exception ex)
					{
						global::System.Console.WriteLine(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뻺迼跾渀焂┄焆栈朊搌欎瀐朒簔礖縘㬚検眞䐠̢嘤䈦嬨崪䠬崮ᄰ刲儴匶䬸帺丼䰾潀捂ф㑆㩈㹊⁌♎㽐㑒畔⍖ㅘ㹚絜㹞ՠݢᝤɦᩨᡪ䵬ٮɰ卲᭴ᡶ൸孺ᅼၾꦆꞈꖊ권", a_) + ex.Message);
						goto IL_134;
					}
					goto IL_F2;
				case 2:
					goto IL_C6;
				}
				goto IL_98;
				IL_F2:
				num = (short)793247745;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_C6:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뗺鋼\udffe椀氂瘄猆月樊怌樎ㄐ簒朔㜖倘䬚尜笞䔠儢䀤否娨ପ崬崮帰䔲尴匶尸强", a_), new global::System.ArgumentNullException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("迺鳼跾昀昂焄伆昈砊礌", a_)));
			IL_134:
			num = (short)1019150336;
			short num4 = num;
			return result;
			IL_98:
			result = false;
			num = (short)1025638400;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_86;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000E380 File Offset: 0x0000C580
		private static bool a(string A_0)
		{
			int a_ = 8;
			short num = (short)1894449152;
			short num2 = num;
			num = (short)2051330809;
			short num3 = num;
			num = (short)231985913;
			bool result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1148452864;
				if (num != 0)
				{
				}
				num = (short)983171073;
				if (num != 0)
				{
				}
				num = (short)1446903808;
				int num4 = (int)num;
				switch (num4)
				{
				default:
					result = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_EE;
						}
						global::System.ServiceModel.Configuration.ClientSection clientSection;
						for (;;)
						{
							IL_CF:
							switch (num4)
							{
							case 0:
								if (clientSection != null)
								{
									num = (short)1579876354;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_370;
							case 1:
							{
								global::System.ServiceModel.Configuration.ChannelEndpointElementCollection endpoints;
								if (endpoints != null)
								{
									num = (short)1640300549;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_370;
							}
							case 2:
							{
								global::System.ServiceModel.Configuration.ChannelEndpointElementCollection endpoints = clientSection.Endpoints;
								num = (short)1789526017;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_389;
							case 4:
								try
								{
									num = (short)1175584768;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_1E8;
											}
											continue;
										case 1:
											goto IL_2F7;
										case 2:
										{
											global::System.Collections.IEnumerator enumerator;
											if (!enumerator.MoveNext())
											{
												num = (short)176291844;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement = (global::System.ServiceModel.Configuration.ChannelEndpointElement)enumerator.Current;
											num = (short)1558052872;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											result = true;
											num = (short)1614610438;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											goto IL_2DF;
										case 5:
										{
											global::System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement;
											if (!string.Equals(channelEndpointElement.Binding, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("韸黺觼뇾怀渂怄挆夈戊紌樎匐稒笔猖瀘甚稜", a_), global::System.StringComparison.Ordinal))
											{
												num = (short)296812547;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 6:
											goto IL_2DF;
										case 7:
											num = (short)868483077;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 8:
										{
											global::System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement;
											if (string.Equals(channelEndpointElement.Name, A_0, global::System.StringComparison.OrdinalIgnoreCase))
											{
												num = (short)1209794567;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										}
										IL_1EA:
										num = (short)1029963778;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_1E8:
										goto IL_1EA;
										IL_2DF:
										num = (short)115671041;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_2F7:;
								}
								finally
								{
									switch (0)
									{
									case 0:
										goto IL_316;
									}
									global::System.IDisposable disposable;
									for (;;)
									{
										IL_303:
										switch (num4)
										{
										case 0:
											if (disposable != null)
											{
												num = (short)925958146;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_36F;
										case 1:
											goto IL_36D;
										case 2:
											disposable.Dispose();
											num = (short)909901825;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_316;
									}
									IL_36D:
									IL_36F:
									goto EndFinally_11;
									IL_316:
									global::System.Collections.IEnumerator enumerator;
									disposable = (enumerator as global::System.IDisposable);
									num = (short)137822208;
									num4 = (int)((global::System.IntPtr)num);
									goto IL_303;
									EndFinally_11:;
								}
								goto IL_370;
							case 5:
							{
								global::System.ServiceModel.Configuration.ChannelEndpointElementCollection endpoints;
								global::System.Collections.IEnumerator enumerator = endpoints.GetEnumerator();
								num = (short)1097924612;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							goto IL_EE;
							IL_370:
							num = (short)1828388867;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_389:
						break;
						IL_EE:
						clientSection = (global::System.Configuration.ConfigurationManager.GetSection(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("諸苺軼课搀渂⬄理氈礊笌明爐瘒堔砖紘縚焜〞䈠伢䰤䈦䜨弪", a_)) as global::System.ServiceModel.Configuration.ClientSection);
						num = (short)378142720;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_CF;
					}
					catch (global::System.Configuration.ConfigurationErrorsException ex)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("본觺迼郾猀⌂氄椆⤈栊愌明琐紒愔㜖簘甚礜漞丠䨢䬤匦न䠪䈬䄮地娲刴䈶䬸娺䤼嘾⹀ⵂ", a_), ex);
					}
					break;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000E768 File Offset: 0x0000C968
		public static string GetDefaultAuthenticationMethod(string clientType)
		{
			int a_ = 3;
			short num = (short)251963924;
			short num2 = num;
			num = (short)1841867284;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1483669504;
				if (num != 0)
				{
				}
				num = (short)368574465;
				if (num != 0)
				{
				}
				num = (short)480051200;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_BF;
				}
				break;
			}
			}
			int num4;
			string result;
			for (;;)
			{
				IL_AD:
				switch (num4)
				{
				case 0:
					if (clientType == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("迳컵쳷컹컻뿽䗿䜁㴃⬅䬇㰉㴋㸍㴏☑刓匕娗㜙␛⬝ᜟᔡणᐥᄧᴩᬫ洭य਱眳5簷缹฻䌽", a_))
					{
						num = (short)692060162;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					return result;
				case 2:
					result = global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꏳ鿵雷黹鏻觽珿", a_);
					num = (short)2076573697;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_BF;
			}
			return result;
			IL_BF:
			result = global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("럳鏵諷軹闻飽槿愁攃爅洇", a_);
			num = (short)1368588288;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_AD;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		public static bool SaveAuthenticationMethod(string clientType, string methodValue)
		{
			int a_ = 16;
			short num = (short)606535680;
			short num2 = num;
			num = (short)1358932434;
			short num3 = num;
			num = (short)193046994;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)559677440;
				if (num != 0)
				{
				}
				num = (short)140967936;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			num = (short)325976065;
			if (num != 0)
			{
			}
			if (global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.ValidateAuthenticationMethod(methodValue))
			{
				bool result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_11D;
					}
					int num4;
					string text;
					global::Microsoft.Win32.RegistryKey registryKey;
					for (;;)
					{
						IL_D6:
						switch (num4)
						{
						case 0:
							goto IL_34D;
						case 1:
							num = (short)2063400975;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (text != null)
							{
								num = (short)208601093;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_335;
						case 3:
							if (registryKey != null)
							{
								num = (short)449380353;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_335;
						case 4:
							num = (short)1910439948;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							registryKey.SetValue(text, methodValue);
							result = true;
							num = (short)1932656648;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (!(clientType == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("稀䔂䜄䈆ㄈ伊䰌䨎␐㸒✔⼖弘ⴚ〜⬞ᤠᘢᄤਦ栨ᴪ測᤮ᰰ瀲джĸ̺笼稾ɀՂ̈́煆ࡈ㙊", a_)))
							{
								num = (short)353828873;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							text = global::Motorola.Security.SamlCommonUtility.ClientAuthMethodRegistryKey.PROXY;
							num = (short)1313931275;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)1242169350;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_234;
						case 9:
							num = (short)360316941;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_169;
						case 11:
							goto IL_169;
						case 12:
							goto IL_169;
						case 13:
							if (!(clientType == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("稀㔂㘄䄆㼈㬊䬌䰎∐㸒—┖℘⸚〜⬞ᄠᔢᜤਦဨᤪḬἮᰰвഴ琶缸̺簼社畀瑂݄罆絈㙊", a_)))
							{
								num = (short)1704919044;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							text = global::Motorola.Security.SamlCommonUtility.ClientAuthMethodRegistryKey.CRUNCHER;
							num = (short)1124925450;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_169;
						case 15:
							if (!(clientType == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("稀㬂㄄㌆㬈䨊䠌䨎⠐㸒嘔№⠘⬚〜⬞朠昢朤ਦᄨḪᨬᠮᰰĲఴ6ุ砺мܾɀ畂ńɆ筈㙊", a_)))
							{
								num = (short)95617031;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							text = global::Motorola.Security.SamlCommonUtility.ClientAuthMethodRegistryKey.CPS;
							num = (short)639369230;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11D;
						IL_169:
						num = (short)1546518530;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_335:
						num = (short)1601634304;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_234:
					return result;
					IL_34D:
					return false;
					IL_11D:
					text = null;
					registryKey = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(global::Motorola.Security.SamlCommonUtility.ClientAuthMethodRegistryKey.BasePath);
					num = (short)1297481731;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_D6;
				}
				catch (global::System.Exception ex)
				{
					global::System.Console.WriteLine(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䈀戂欄✆月搊礌⼎成瘒愔㜖砘渚検眞䐠䴢儤並䨨䨪夬䘮帰崲ᔴ娶尸伺唼倾╀祂敄", a_) + ex.Message);
					return false;
				}
				return result;
			}
			return false;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000EC50 File Offset: 0x0000CE50
		public static bool ValidateAuthenticationMethod(string authMethod)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)831979520;
					short num3 = num2;
					if (!string.IsNullOrEmpty(authMethod))
					{
						num2 = (short)1099235330;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 1:
					return result;
				case 2:
				{
					num2 = (short)834970426;
					short num4 = num2;
					num2 = (short)1898750778;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C7;
					default:
						num2 = (short)1073938432;
						if (num2 != 0)
						{
						}
						num2 = (short)1659043847;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					num2 = (short)534380545;
					if (num2 != 0)
					{
					}
					if (!authMethod.Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("곸裺飼跾伀戂栄戆", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						num2 = (short)1875902472;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1FA;
				case 4:
					if (authMethod.Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뫸黺迼课栀攂氄搆栈缊栌", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						num2 = (short)1505296389;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 5:
					goto IL_1FA;
				case 6:
					num2 = (short)1163657219;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_1C7;
				case 8:
					num2 = (short)461963268;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3D;
				IL_1C7:
				if (!authMethod.Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("껸鋺鏼鯾渀琂瘄", a_), global::System.StringComparison.OrdinalIgnoreCase))
				{
					num2 = (short)295174150;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_1FA:
				result = true;
				num2 = (short)1828585473;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_3D:
			result = false;
			num2 = (short)2029125632;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000EE74 File Offset: 0x0000D074
		private static global::System.ServiceModel.EndpointAddress a(global::Motorola.Security.SamlTokenComponent.DiscoveryEndpointInfo A_0, string A_1, int A_2)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num;
			short num2;
			global::System.ServiceModel.EndpointAddress result;
			for (;;)
			{
				IL_13:
				global::System.Uri uri;
				switch (num)
				{
				case 0:
					num2 = (short)2104950785;
					if (num2 != 0)
					{
					}
					if (A_0 != null)
					{
						num2 = (short)247136258;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_21D;
				case 1:
					num2 = (short)1710751749;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1354304388;
					short num3 = num2;
					num2 = (short)1683950468;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2D9;
					default:
						num2 = (short)2018115584;
						if (num2 != 0)
						{
						}
						num2 = (short)2089025545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_26F;
				case 4:
					goto IL_26F;
				case 5:
					if (uri.Port != A_2)
					{
						num2 = (short)824377350;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_26F;
				case 6:
					goto IL_2A3;
				case 7:
					return result;
				case 8:
					if (!(uri.Host != A_1))
					{
						num2 = (short)1963720705;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2A3;
				case 9:
					if (A_0.address != null)
					{
						num2 = (short)985268236;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_21D;
				case 10:
					uri = new global::System.Uri(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("臹쳻菽㫿ⴁ⬃紅㤇眉看㰍洏", a_), uri.Scheme, A_1, uri.AbsolutePath));
					num2 = (short)1808531460;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
				{
					if (uri.Scheme.Equals(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("铹駻諽⻿爁洃瘅洇", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						goto IL_2D9;
					}
					num2 = (short)91881472;
					short num4 = num2;
					uri = new global::System.Uri(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("臹쳻菽㫿ⴁ⬃紅㤇眉㘋甍∏漑漓┕攗", a_), new object[]
					{
						uri.Scheme,
						A_1,
						A_2,
						uri.AbsolutePath
					}));
					num2 = (short)1070399491;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
					uri = new global::System.Uri(A_0.address);
					num2 = (short)1731133448;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_4D;
				IL_26F:
				global::System.ServiceModel.EndpointIdentity identity = global::Motorola.Common.Cryptography.CryptographyFacade.GetServerIdentityProvider().Get();
				result = new global::System.ServiceModel.EndpointAddress(uri, identity, global::System.Array.Empty<global::System.ServiceModel.Channels.AddressHeader>());
				num2 = (short)2108620807;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2A3:
				num2 = (short)995753995;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2D9:
				num2 = (short)455147530;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_21D:
			throw new global::System.Exception(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("돹鋻製懿渁洃戅⠇三攋納猏紑戓猕樗挙㰛崝䰟䬡䄣䠥尧਩洫䨭启䀱儳䔵䬷ᬹ", a_));
			IL_4D:
			result = null;
			num2 = (short)741867520;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		private static global::System.ServiceModel.EndpointAddress a(global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo A_0, string A_1, int A_2)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num;
			short num2;
			global::System.ServiceModel.EndpointAddress result;
			for (;;)
			{
				IL_13:
				global::System.Uri uri;
				switch (num)
				{
				case 0:
					if (A_0 != null)
					{
						num2 = (short)805568514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_215;
				case 1:
					num2 = (short)1201733637;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1113568818;
					short num3 = num2;
					num2 = (short)246134322;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2C6;
					default:
						num2 = (short)1052966912;
						if (num2 != 0)
						{
						}
						num2 = (short)343212041;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					num2 = (short)315752449;
					if (num2 != 0)
					{
					}
					goto IL_268;
				case 4:
					goto IL_268;
				case 5:
					if (uri.Port != A_2)
					{
						num2 = (short)287703046;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_268;
				case 6:
					goto IL_290;
				case 7:
					return result;
				case 8:
					if (!(uri.Host != A_1))
					{
						num2 = (short)676069377;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_290;
				case 9:
					if (A_0.address != null)
					{
						num2 = (short)256507916;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_215;
				case 10:
					uri = new global::System.Uri(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("諰쏲裴췶훸퓺蛼컾簀砂㜄稆", a_), uri.Scheme, A_1, uri.AbsolutePath));
					num2 = (short)280428548;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
				{
					if (string.Equals(uri.Scheme, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("鿰雲致\ud9f6觸鋺跼髾", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						goto IL_2C6;
					}
					uri = new global::System.Uri(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("諰쏲裴췶훸퓺蛼컾簀㤂縄㔆琈瀊㸌爎", a_), new object[]
					{
						uri.Scheme,
						A_1,
						A_2,
						uri.AbsolutePath
					}));
					num2 = (short)1942618112;
					short num4 = num2;
					num2 = (short)1716060163;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
					uri = new global::System.Uri(A_0.address);
					num2 = (short)1538981896;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_4D;
				IL_268:
				result = new global::System.ServiceModel.EndpointAddress(uri, global::System.Array.Empty<global::System.ServiceModel.Channels.AddressHeader>());
				num2 = (short)1791819783;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_290:
				num2 = (short)209059851;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2C6:
				num2 = (short)937361418;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_215:
			throw new global::System.Exception(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("룰鷲菴零闸鋺駼\udffe唀氂渄戆月⬊䐌簎成昒瀔攖㤘娚礜笞匠䘢嘤否ࠨ", a_));
			IL_4D:
			result = null;
			num2 = (short)1723269120;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000F4EC File Offset: 0x0000D6EC
		private static global::System.ServiceModel.Channels.Binding a(global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo A_0)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_6D;
			}
			int num;
			global::System.ServiceModel.Channels.Binding result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					goto IL_1E4;
				case 2:
					num2 = (short)163840018;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (A_0 != null)
					{
						num2 = (short)685965314;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_27F;
				case 4:
					if (A_0.binding == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("軸裺쿼쿾㄀㐂䴄猆紈笊伌明缐眒簔礖縘", a_))
					{
						num2 = (short)902692874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1556611091;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_169;
				case 6:
					result = new global::System.ServiceModel.WS2007FederationHttpBinding(A_0.bindingConfiguration);
					num2 = (short)1298137089;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_330;
				case 8:
					goto IL_F6;
				case 9:
					if (A_0.binding == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("軸裺민髾攀昂眄昆紈戊戌愎夐朒愔朖嬘爚猜笞䠠䴢䈤", a_))
					{
						num2 = (short)1491337228;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)297598992;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					result = new global::System.ServiceModel.WS2007HttpBinding(A_0.bindingConfiguration);
					num2 = (short)560529415;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (!string.IsNullOrEmpty(A_0.bindingConfiguration))
					{
						num2 = (short)1438908430;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_27F;
				case 12:
					result = new global::System.ServiceModel.WSFederationHttpBinding(A_0.bindingConfiguration);
					num2 = (short)2070282248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					result = new global::System.ServiceModel.WSHttpBinding(A_0.bindingConfiguration);
					num2 = (short)1496907776;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)2003959812;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)1769996299;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (A_0.binding == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("軸裺쿼쿾㄀㐂䌄戆洈渊缌渎攐稒稔礖儘漚検漞挠䨢䬤䌦䀨䔪䨬", a_))
					{
						num2 = (short)1686831110;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_335;
				case 17:
					goto IL_2AA;
				case 18:
					if (!string.IsNullOrEmpty(A_0.binding))
					{
						num2 = (short)168165391;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_27F;
				case 19:
					if (A_0.binding == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("軸裺뗼课甀猂䜄渆月漊搌愎瘐", a_))
					{
						num2 = (short)149749773;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)968032273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
				{
					result = new global::System.ServiceModel.NetTcpBinding(A_0.bindingConfiguration);
					num2 = (short)380726943;
					short num3 = num2;
					num2 = (short)345730719;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2AA;
					default:
						num2 = (short)1889075200;
						if (num2 != 0)
						{
						}
						num2 = (short)463536133;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_6D;
				IL_2AA:
				num2 = (short)840695808;
				short num4 = num2;
				if (A_0.binding == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("韸黺觼꯾戀猂䜄渆月漊搌愎瘐", a_))
				{
					num2 = (short)655425556;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)1418592265;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_F6:
			IL_169:
			IL_1E4:
			return result;
			IL_27F:
			throw new global::System.Exception(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("냸闺诼黾洀樂愄✆崈搊昌樎缐㌒尔搖樘渚砜洞Ġ愢䰤䤦䴨䈪䌬䠮ူ", a_));
			IL_330:
			return result;
			IL_335:
			throw new global::System.Exception(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("그鏺飼\udffe䠀瀂瘄爆氈礊ⴌ䴎砐紒焔縖眘簚㴜㈞Ġ", a_) + A_0.binding + global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("\ud9f8鋺軼\udffe漀氂焄✆稈縊紌缎縐愒愔爖紘", a_));
			IL_6D:
			num2 = (short)411566081;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)1250820099;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000F96C File Offset: 0x0000DB6C
		private static global::System.Xml.XmlElement a(string A_0, string A_1, string A_2, string A_3, string A_4 = "", bool A_5 = false, bool A_6 = false, string A_7 = "")
		{
			int a_ = 1;
			short num = (short)1947172752;
			short num2 = num;
			num = (short)1719566224;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_121:
				num = (short)1306525697;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)843579392;
				if (num != 0)
				{
				}
				num = (short)2024275968;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_C5;
					}
					break;
				}
				break;
			}
			string value;
			string hostName;
			string value2;
			string value3;
			for (;;)
			{
				IL_7E:
				num = (short)736952320;
				short num4 = num;
				string text;
				switch (num3)
				{
				case 0:
					text = bool.FalseString;
					goto IL_27C;
				case 1:
					num = (short)1474560000;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					text = bool.TrueString;
					goto IL_27C;
				case 3:
					if (!A_5)
					{
						goto IL_121;
					}
					num = (short)1017053186;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_1BE;
						}
						global::System.Security.Principal.SecurityIdentifier securityIdentifier;
						for (;;)
						{
							IL_1A7:
							switch (num3)
							{
							case 0:
								goto IL_23B;
							case 1:
								if (securityIdentifier != null)
								{
									num = (short)1410334722;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_23B;
							case 2:
								value = securityIdentifier.Value;
								num = (short)1738276864;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_254;
							}
							goto IL_1BE;
							IL_23B:
							num = (short)2115239939;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_254:
						goto IL_2A9;
						IL_1BE:
						string empty = string.Empty;
						securityIdentifier = global::Motorola.Security.SamlCommonUtility.NameResolver.ResolveName(null, hostName + global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("훱", a_), out empty);
						num = (short)1571815425;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_1A7;
					}
					catch
					{
						value = string.Empty;
						goto IL_2A9;
					}
					goto Block_2;
				case 5:
					goto IL_25F;
				}
				goto IL_C5;
				Block_2:
				string currentStorePath;
				try
				{
					IL_25F:
					value2 = global::Motorola.Security.SamlCommonUtility.OSUtility.GetHostIDHash(currentStorePath, A_6);
					goto IL_13C;
				}
				catch
				{
					value2 = string.Empty;
					goto IL_13C;
				}
				goto IL_27C;
				IL_13C:
				num = (short)1833369604;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_27C:
				value3 = text;
				value2 = string.Empty;
				currentStorePath = global::Motorola.Security.SamlCommonUtility.EnvironmentUtility.GetCurrentStorePath(A_3, A_0);
				num = (short)1916731397;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_2A9:
			global::System.Xml.XmlElement xmlElement = new global::System.Xml.XmlDocument().CreateElement(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("釱蓳藵", a_), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뇱至藵賷闹釻", a_), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髱胳苵裷샹폻퇽揿洁椃欅朇搉漋縍挏㴑䘓嬕儗縙䰛ㄝ匟嘡圣थ䬧䘩䴫䜭崯䄱", a_));
			xmlElement.SetAttribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("돱蓳蛵뇷黹", a_), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髱胳苵裷샹폻퇽揿洁椃欅朇搉漋縍挏㴑䘓嬕儗縙䰛ㄝ匟嘡圣थ䬧䘩䴫䜭崯䄱ᬳ眵䠷䨹画娽", a_), A_0);
			xmlElement.SetAttribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뫱鯳藵賷铹鷻鏽旿", a_), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髱胳苵裷샹폻퇽揿洁椃欅朇搉漋縍挏㴑䘓嬕儗縙䰛ㄝ匟嘡圣थ䬧䘩䴫䜭崯䄱ᬳ縵圷䤹䠻倽ℿ⽁⅃", a_), hostName);
			string name;
			xmlElement.SetAttribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("꟱蟳鏵諷铹鷻鏽旿", a_), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髱胳苵裷샹폻퇽揿洁椃欅朇搉漋縍挏㴑䘓嬕儗縙䰛ㄝ匟嘡圣थ䬧䘩䴫䜭崯䄱ᬳ挵䬷弹主倽ℿ⽁⅃", a_), name);
			xmlElement.SetAttribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("돱至苵郷맹軻鯽擿朁樃爅愇欉怋娍椏我焓堕礗眙礛", a_), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髱胳苵裷샹폻퇽揿洁椃欅朇搉漋縍挏㴑䘓嬕儗縙䰛ㄝ匟嘡圣थ䬧䘩䴫䜭崯䄱ᬳ眵䴷丹吻紽㈿❁⁃⍅♇㹉╋⽍㱏ّⵓ♕㵗ᑙ㵛㍝՟", a_), A_1);
			xmlElement.SetAttribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뷱髳鏵곷鏹釻鯽僿持眃甅缇攉縋樍䐏欑搓猕嘗笙焛笝", a_), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髱胳苵裷샹폻퇽揿洁椃欅朇搉漋縍挏㴑䘓嬕儗縙䰛ㄝ匟嘡圣थ䬧䘩䴫䜭崯䄱ᬳ礵嘷弹栻圽ⴿ❁ᑃ❅㭇㥉㭋⅍≏㙑S⽕⡗㽙ቛ㽝ൟݡ", a_), A_4);
			xmlElement.SetAttribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꃱ釳髵臷鏹鋻駽僿持瘃爅焇帉甋縍甏", a_), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髱胳苵裷샹폻퇽揿洁椃欅朇搉漋縍挏㴑䘓嬕儗縙䰛ㄝ匟嘡圣थ䬧䘩䴫䜭崯䄱ᬳ搵崷嘹䔻圽⸿╁ᑃ❅㩇㹉㕋ᩍ⥏≑ㅓ", a_), A_2);
			xmlElement.SetAttribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뫱鯳藵賷꧹闻髽哿笁球挅䘇欉愋欍", a_), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髱胳苵裷샹폻퇽揿洁椃欅朇搉漋縍挏㴑䘓嬕儗縙䰛ㄝ匟嘡圣थ䬧䘩䴫䜭崯䄱ᬳ縵圷䤹䠻洽⤿♁၃㽅㡇⽉ɋ⽍㵏㝑", a_), value);
			xmlElement.SetAttribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("등鷳飵鿷鿹軻軽狿欁樃爅將猉簋欍帏猑礓猕", a_), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髱胳苵裷샹폻퇽揿洁椃欅朇搉漋縍挏㴑䘓嬕儗縙䰛ㄝ匟嘡圣थ䬧䘩䴫䜭崯䄱ᬳ瀵儷吹嬻嬽㈿㉁㙃⽅♇㹉ᡋ㝍⁏㝑ᩓ㝕㕗㽙", a_), value2);
			xmlElement.SetAttribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("돱音苵釷賹鷻諽槿氁挃䠅椇有椋", a_), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髱胳苵裷샹폻퇽揿洁椃欅朇搉漋縍挏㴑䘓嬕儗縙䰛ㄝ匟嘡圣थ䬧䘩䴫䜭崯䄱ᬳ眵嬷丹唻䠽ℿ㙁ⵃ⡅⽇щⵋ⍍㕏", a_), value3);
			xmlElement.SetAttribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("룱菳苵곷闹韻鯽滿䰁攃欅洇", a_), global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髱胳苵裷샹폻퇽揿洁椃欅朇搉漋縍挏㴑䘓嬕儗縙䰛ㄝ匟嘡圣थ䬧䘩䴫䜭崯䄱ᬳ簵伷丹栻儽⬿❁⩃ࡅ⥇❉⥋", a_), A_7);
			return xmlElement;
			IL_C5:
			num = (short)1149173761;
			if (num != 0)
			{
			}
			name = global::System.Security.Principal.WindowsIdentity.GetCurrent().Name;
			hostName = global::System.Net.Dns.GetHostName();
			value = string.Empty;
			num = (short)1102970883;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7E;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		private static void a(global::System.ServiceModel.ChannelFactory A_0, string A_1, int A_2)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			short num2;
			global::System.Uri uri;
			for (;;)
			{
				IL_13:
				global::System.Uri uri2;
				switch (num)
				{
				case 0:
					num2 = (short)1143668737;
					if (num2 != 0)
					{
					}
					goto IL_224;
				case 1:
					return;
				case 2:
				{
					num2 = (short)241041408;
					short num3 = num2;
					if (string.Equals(uri.Scheme, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("鋻鯽瓿Ⰱ球漅砇漉", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						num2 = (short)567476232;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					uri2 = new global::System.Uri(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("蟻컽緿㠁⬃⤅猇㬉焋㐍欏‑椓洕⬗朙", a_), new object[]
					{
						uri.Scheme,
						A_1,
						A_2,
						uri.AbsolutePath
					}));
					num2 = (short)998178819;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					IL_E9:
					goto IL_197;
				case 4:
					goto IL_197;
				case 5:
					if (!(uri.Host != A_1))
					{
						num2 = (short)1457127430;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_224;
				case 6:
					num2 = (short)847839239;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (uri.Port != A_2)
					{
						num2 = (short)2014707712;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
					uri2 = new global::System.Uri(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("蟻컽緿㠁⬃⤅猇㬉焋甍∏漑", a_), uri.Scheme, A_1, uri.AbsolutePath));
					num2 = (short)980549636;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3D;
				IL_197:
				num2 = (short)1085688622;
				short num4 = num2;
				num2 = (short)77548334;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E9;
				default:
					num2 = (short)713162752;
					if (num2 != 0)
					{
					}
					A_0.Endpoint.Address = new global::System.ServiceModel.EndpointAddress(uri2, A_0.Endpoint.Address.Identity, global::System.Array.Empty<global::System.ServiceModel.Channels.AddressHeader>());
					num2 = (short)1503068161;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_224:
				uri2 = null;
				num2 = (short)210173954;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_3D:
			uri = A_0.Endpoint.Address.Uri;
			num2 = (short)3932165;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00010090 File Offset: 0x0000E290
		private static global::System.ServiceModel.EndpointAddress a(global::System.ServiceModel.EndpointAddress A_0, string A_1)
		{
			int a_ = 7;
			short num = (short)1556668369;
			short num2 = num;
			num = (short)2090065873;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_211:
				num = (short)11993092;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1619525632;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_82;
				}
				break;
			}
			global::System.ServiceModel.EndpointAddress result;
			for (;;)
			{
				IL_60:
				global::System.Uri uri;
				switch (num3)
				{
				case 0:
					if (A_0 != null)
					{
						num = (short)1418395653;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					goto IL_22D;
				case 2:
					return result;
				case 3:
					if (string.Equals(A_0.Uri.Scheme, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("雷鿹裻탽烿欁球挅", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						goto IL_211;
					}
					num = (short)1915879425;
					if (num != 0)
					{
					}
					uri = new global::System.Uri(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("菷쫹臻쓽⿿ⴁ缃㜅甇〉看㰍洏椑✓欕", a_), new object[]
					{
						A_0.Uri.Scheme,
						A_1,
						A_0.Uri.Port,
						A_0.Uri.AbsolutePath
					}));
					num = (short)1822818310;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					uri = new global::System.Uri(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("菷쫹臻쓽⿿ⴁ缃㜅甇焉㸋猍", a_), A_0.Uri.Scheme, A_1, A_0.Uri.AbsolutePath));
					num = (short)752812032;
					short num4 = num;
					num = (short)1430388737;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					uri = null;
					num = (short)1436221443;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_22D;
				}
				goto IL_82;
				IL_22D:
				result = new global::System.ServiceModel.EndpointAddress(uri, A_0.Identity, global::System.Array.Empty<global::System.ServiceModel.Channels.AddressHeader>());
				num = (short)1804009474;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_82:
			result = null;
			num = (short)1252130816;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_60;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000102F8 File Offset: 0x0000E4F8
		private static bool b()
		{
			short num = (short)1291367882;
			short num2 = num;
			num = (short)431928778;
			switch (num2 == num)
			{
			}
			num = (short)1886191616;
			short num3 = num;
			num = (short)1313931265;
			if (num != 0)
			{
			}
			num = (short)638844928;
			if (num != 0)
			{
			}
			return global::Motorola.Security.SamlCommonUtility.OSUtility.GetOSVersion() >= global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_Vista_SP2_or_2008_SP2;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000103AC File Offset: 0x0000E5AC
		private static bool a()
		{
			short num = (short)930400822;
			short num2 = num;
			num = (short)174508598;
			switch (num2 == num)
			{
			}
			num = (short)1092878336;
			short num3 = num;
			num = (short)665976832;
			if (num != 0)
			{
			}
			num = (short)984481793;
			if (num != 0)
			{
			}
			return global::Motorola.Security.SamlCommonUtility.OSUtility.GetOSVersion() >= global::Motorola.Security.SamlCommonUtility.OSVersion.Windows_8_or_2012_and_Above;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00010460 File Offset: 0x0000E660
		private static bool a(string A_0, string A_1)
		{
			int a_ = 17;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				short num2;
				bool result;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1580031764;
						short num3 = num2;
						num2 = (short)2034654996;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num2 = (short)2058944512;
							if (num2 != 0)
							{
							}
							num2 = (short)192217088;
							short num4 = num2;
							global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.c(A_0);
							result = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(A_1);
							num2 = (short)2013528065;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return result;
					case 2:
						if (global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.b())
						{
							num2 = (short)519897088;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F8;
					}
					break;
				}
				IL_25:
				num2 = (short)233832449;
				if (num2 != 0)
				{
				}
				result = false;
				num2 = (short)19660802;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			IL_F8:
			throw new global::System.PlatformNotSupportedException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("嘁氃漅笇⨉簋戍焏昑爓礕樗眙㰛眝匟ȡ䨣䤥尧਩弫嬭䀯䈱嬳䐵䰷弹堻ွ", a_));
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000105A0 File Offset: 0x0000E7A0
		private static global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata a(global::System.Collections.ObjectModel.Collection<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> A_0, string A_1)
		{
			int a_ = 6;
			short num = (short)76152832;
			short num2 = num;
			num = (short)830406656;
			switch (num)
			{
			default:
			{
				global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata result = null;
				global::System.Version version = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
				string clientTypeFromCurrentUserTypeName = global::Motorola.Security.SamlCommonUtility.EnvironmentUtility.GetClientTypeFromCurrentUserTypeName(A_1);
				global::System.Collections.Generic.IEnumerator<global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata> enumerator = A_0.GetEnumerator();
				global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata result2;
				try
				{
					num = (short)1811808256;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata;
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator3;
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_B8;
							}
							continue;
						case 1:
							if (global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a(endpointDiscoveryMetadata))
							{
								num = (short)1391001603;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 2:
							goto IL_AF4;
						case 3:
							goto IL_AB0;
						case 4:
							try
							{
								num = (short)1813381120;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Xml.Linq.XElement xelement;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_185;
										}
										continue;
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2 = xelement.Elements(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("듶雸雺跼黾甀樂朄欆氈䠊愌明琐紒愔", a_)).GetEnumerator();
										num = (short)717029382;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										num = (short)1173946373;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										if (xelement.Name.LocalName == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("듶雸雺跼黾甀樂朄欆氈䠊愌明琐紒愔搖", a_))
										{
											num = (short)1557790722;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										result = endpointDiscoveryMetadata;
										num = (short)1897660417;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										goto IL_A3D;
									case 6:
										try
										{
											num = (short)1291124739;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												int num4;
												switch (num3)
												{
												case 0:
													num = (short)325910534;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
												{
													global::System.Xml.Linq.XElement xelement2;
													if (xelement2.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("菶胸诺飼", a_)) != null)
													{
														num = (short)1547436032;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 2:
													goto IL_448;
												case 3:
													switch (0)
													{
													case 0:
														goto IL_2B0;
													}
													continue;
												case 4:
												{
													global::System.Xml.Linq.XElement xelement2;
													if (!string.IsNullOrWhiteSpace(xelement2.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髶飸菺迼鋾眀昂眄理怈搊挌", a_)).Value))
													{
														num = (short)1019478033;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_7A4;
												}
												case 5:
													goto IL_335;
												case 6:
												{
													global::System.Xml.Linq.XElement xelement2;
													if (string.Equals(xelement2.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("菶胸诺飼", a_)).Value.Trim(), clientTypeFromCurrentUserTypeName, global::System.StringComparison.OrdinalIgnoreCase))
													{
														num = (short)1501364231;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 7:
													num = (short)103874583;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 8:
												{
													string[] array;
													if (num4 >= array.Length)
													{
														num = (short)2011889689;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													string text = array[num4];
													num = (short)477102098;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 9:
												{
													global::System.Xml.Linq.XElement xelement2;
													string[] array = xelement2.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("鋶臸飺釼諾攀昂愄甆搈紊栌紎成稒稔礖樘", a_)).Value.Trim().Split(new char[]
													{
														';'
													});
													num4 = 0;
													num = (short)388235269;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 10:
													try
													{
														num = (short)216399874;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
																goto IL_536;
															case 1:
																goto IL_51C;
															case 2:
																switch (0)
																{
																case 0:
																	goto IL_4DD;
																}
																continue;
															case 3:
																result2 = null;
																num = (short)1296629761;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_4DD:
															string text;
															if (new global::System.Version(text) == version)
															{
																num = (short)1805320195;
																num3 = (int)((global::System.IntPtr)num);
															}
															else
															{
																num = (short)2122186752;
																num3 = (int)((global::System.IntPtr)num);
															}
														}
														IL_51C:
														goto IL_B65;
														IL_536:
														goto IL_914;
													}
													catch (global::System.Exception)
													{
														throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뻶韸跺鳼鏾栀朂┄搆攈戊栌愎攐㌒挔爖欘栚琜瀞传̢䌤䠦嬨䘪䰬嬮ᄰ娲嬴᜶䴸区堼Ἶɀⱂ⡄㝆⡈㽊⑌ⵎ㵐㙒畔㑖㕘㉚㡜ㅞᕠ䍢।๦ᩨὪ", a_));
													}
													goto IL_550;
												case 11:
													goto IL_335;
												case 12:
													try
													{
														switch (0)
														{
														case 0:
															goto IL_585;
														}
														global::System.Version v;
														for (;;)
														{
															IL_56E:
															switch (num3)
															{
															case 0:
																goto IL_61E;
															case 1:
																goto IL_600;
															case 2:
																if (version < v)
																{
																	num = (short)651821059;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																num = (short)2147221504;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 3:
																result2 = null;
																num = (short)207224833;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_585;
														}
														IL_600:
														goto IL_B65;
														IL_61E:
														goto IL_652;
														IL_585:
														global::System.Xml.Linq.XElement xelement2;
														v = new global::System.Version(xelement2.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髶郸闺迼鋾眀昂眄理怈搊挌", a_)).Value);
														num = (short)2126905346;
														num3 = (int)((global::System.IntPtr)num);
														goto IL_56E;
													}
													catch (global::System.Exception)
													{
														throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뻶韸跺鳼鏾栀朂┄焆氈礊縌明縐紒㔔縖眘㬚検眞䐠̢昤䠦䐨嬪䰬嬮堰儲头制ᤸ堺儼嘾⑀ⵂㅄ杆╈≊㹌㭎", a_));
													}
													goto IL_635;
													IL_652:
													num = (short)2088697869;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 13:
												{
													global::System.Xml.Linq.XElement xelement2;
													if (xelement2.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髶飸菺迼鋾眀昂眄理怈搊挌", a_)) != null)
													{
														num = (short)1567031298;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_7A4;
												}
												case 14:
													goto IL_330;
												case 15:
												{
													global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
													if (!enumerator2.MoveNext())
													{
														num = (short)1143275542;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::System.Xml.Linq.XElement xelement2 = enumerator2.Current;
													num = (short)1889730561;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 16:
												{
													global::System.Xml.Linq.XElement xelement2;
													if (!string.IsNullOrWhiteSpace(xelement2.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髶郸闺迼鋾眀昂眄理怈搊挌", a_)).Value))
													{
														num = (short)1323040780;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_550;
												}
												case 17:
													try
													{
														switch (0)
														{
														case 0:
															goto IL_398;
														}
														global::System.Version v2;
														for (;;)
														{
															IL_381:
															switch (num3)
															{
															case 0:
																goto IL_42E;
															case 1:
																goto IL_411;
															case 2:
																if (version > v2)
																{
																	num = (short)2057502723;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																num = (short)241172480;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 3:
																result2 = null;
																num = (short)1662058497;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_398;
														}
														IL_411:
														goto IL_B65;
														IL_42E:
														goto IL_7A4;
														IL_398:
														global::System.Xml.Linq.XElement xelement2;
														v2 = new global::System.Version(xelement2.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髶飸菺迼鋾眀昂眄理怈搊挌", a_)).Value);
														num = (short)217186306;
														num3 = (int)((global::System.IntPtr)num);
														goto IL_381;
													}
													catch (global::System.Exception)
													{
														throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뻶韸跺鳼鏾栀朂┄搆攈戊栌愎攐㌒挔爖欘栚琜瀞传̢䌤䠦嬨䘪䰬嬮ᄰ娲嬴᜶䴸区堼Ἶɀⱂ⡄㝆⡈㽊⑌ⵎ㵐㙒畔㑖㕘㉚㡜ㅞᕠ䍢।๦ᩨὪ", a_));
													}
													goto IL_448;
												case 18:
												{
													string text;
													if (!string.IsNullOrWhiteSpace(text))
													{
														num = (short)1647771658;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_914;
												}
												case 19:
												{
													global::System.Xml.Linq.XElement xelement2;
													if (xelement2.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("鋶臸飺釼諾攀昂愄甆搈紊栌紎成稒稔礖樘", a_)) != null)
													{
														num = (short)1035534345;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_7F4;
												}
												case 20:
													goto IL_810;
												case 21:
													num = (short)732823568;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 22:
													num = (short)517668888;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 23:
												{
													global::System.Xml.Linq.XElement xelement2;
													if (xelement2.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髶郸闺迼鋾眀昂眄理怈搊挌", a_)) != null)
													{
														num = (short)199032853;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													result2 = null;
													num = (short)19333134;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 24:
													goto IL_950;
												case 25:
													goto IL_635;
												case 26:
													goto IL_7F4;
												}
												goto IL_2B0;
												IL_335:
												num = (short)462749704;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_448:
												num = (short)1492058116;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_635:
												num = (short)2123235354;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_7A4:
												num = (short)643956755;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_7F4:
												result = endpointDiscoveryMetadata;
												num = (short)456654868;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_86C:
												num = (short)256638991;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_2B0:
												goto IL_86C;
												IL_914:
												num4++;
												num = (short)488308747;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_330:
											goto IL_B65;
											IL_550:
											throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("髶郸闺迼鋾眀昂眄理怈搊挌⼎簐昒昔挖㤘礚砜㼞儠儢䨤儦䀨伪䠬䬮ᄰ唲娴䔶ᤸ砺刼刾ㅀ≂ㅄ⹆⭈❊⡌潎㉐㽒㱔㉖㝘⽚", a_));
											IL_810:
											IL_950:
											return result;
										}
										finally
										{
											num = (short)1770913794;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
												switch (num3)
												{
												case 0:
													enumerator2.Dispose();
													num = (short)19988481;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													goto IL_9BF;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_987;
													}
													continue;
												}
												IL_987:
												if (enumerator2 == null)
												{
													break;
												}
												num = (short)1220804608;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_9BF:;
										}
										goto IL_9C2;
									case 7:
										if (!enumerator3.MoveNext())
										{
											num = (short)225837059;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_9C2;
									}
									IL_1C2:
									num = (short)280887303;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_185:
									goto IL_1C2;
									IL_9C2:
									xelement = enumerator3.Current;
									num = (short)703463428;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_A3D:
								return result;
							}
							finally
							{
								num = (short)1047396354;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										enumerator3.Dispose();
										num = (short)743833601;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_AAD;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_A75;
										}
										continue;
									}
									IL_A75:
									if (enumerator3 == null)
									{
										break;
									}
									num = (short)1073938432;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_AAD:;
							}
							goto IL_AB0;
						case 5:
							if (!enumerator.MoveNext())
							{
								num = (short)502923270;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							endpointDiscoveryMetadata = enumerator.Current;
							num = (short)1642659841;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)964165634;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_BD:
						num = (short)1390280709;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_B8:
						goto IL_BD;
						IL_AB0:
						enumerator3 = endpointDiscoveryMetadata.Extensions.GetEnumerator();
						num = (short)1916600324;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_AF4:
					return result;
				}
				finally
				{
					num = (short)1886191618;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1612644353;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_B62;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_B2B;
							}
							continue;
						}
						IL_B2B:
						if (enumerator == null)
						{
							break;
						}
						num = (short)83689472;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_B62:;
				}
				IL_B65:
				num = (short)1981622870;
				short num5 = num;
				num = (short)1995844182;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
					num = (short)120651776;
					if (num != 0)
					{
					}
					num = (short)2059862017;
					if (num != 0)
					{
					}
					return result2;
				}
				break;
			}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00011218 File Offset: 0x0000F418
		private static global::System.ServiceModel.Discovery.FindResponse a(global::System.ServiceModel.Discovery.DiscoveryClient A_0, global::System.ServiceModel.Discovery.FindCriteria A_1)
		{
			global::System.ServiceModel.Discovery.FindResponse result = null;
			short num;
			try
			{
				num = (short)1212547073;
				if (num != 0)
				{
				}
				result = A_0.Find(A_1);
			}
			catch (global::System.Reflection.TargetInvocationException innerException)
			{
				while (innerException.InnerException != null)
				{
					num = (short)1361303682;
					short num2 = num;
					num = (short)706992258;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1889533952;
						if (num != 0)
						{
						}
						if (innerException is global::System.Security.Cryptography.CryptographicException)
						{
							goto IL_77;
						}
						innerException = innerException.InnerException;
						break;
					}
				}
				IL_77:
				if (innerException is global::System.Security.Cryptography.CryptographicException)
				{
					string empty = string.Empty;
					global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.ImportClientCertificate(global::Motorola.Security.SamlTokenComponent.SamlTokenCertificateUtility.GetCNfromDN(A_0.ClientCredentials.ClientCertificate.Certificate.SubjectName), true);
					throw;
				}
				throw;
			}
			num = (short)103284736;
			short num3 = num;
			return result;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00011338 File Offset: 0x0000F538
		private static bool a(global::System.ServiceModel.Discovery.EndpointDiscoveryMetadata A_0)
		{
			int a_ = 5;
			short num = (short)440860672;
			switch (num)
			{
			default:
			{
				bool result = true;
				global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator = A_0.Extensions.GetEnumerator();
				try
				{
					num = (short)397082625;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_445;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_BA;
							}
							continue;
						case 2:
							if (string.Compare(A_0.Address.Uri.Scheme, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("黵賷軹賻跽", a_), global::System.StringComparison.Ordinal) == 0)
							{
								num = (short)1866006550;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 3:
						{
							bool flag;
							if (flag)
							{
								num = (short)1959919632;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BC;
						}
						case 4:
							num = (short)317718530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							bool flag = true;
							num = (short)1838415881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)358678528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							result = false;
							num = (short)37748755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_1BC;
						case 9:
						{
							global::System.Xml.Linq.XElement xelement;
							if (xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("臵鷷飹迻釽揿椁愃爅䴇搉洋氍簏眑瀓", a_)) != null)
							{
								num = (short)2060976138;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_273;
						}
						case 10:
						{
							global::System.Xml.Linq.XElement xelement;
							bool flag = bool.Parse(xelement.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("臵鷷飹迻釽揿椁愃爅䴇搉洋氍簏眑瀓", a_)).Value.Trim());
							num = (short)1876361228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							if (string.Compare(A_0.Address.Uri.Scheme, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("飵鷷軹틻諽揿爁", a_), global::System.StringComparison.Ordinal) != 0)
							{
								num = (short)798031880;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2AC;
						case 12:
							goto IL_273;
						case 13:
						{
							num = (short)1698693121;
							if (num != 0)
							{
							}
							global::System.Xml.Linq.XElement xelement;
							if (xelement.Name.LocalName == global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("藵鷷裹諻鯽狿", a_))
							{
								num = (short)1780482053;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 14:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1125974022;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.Linq.XElement xelement = enumerator.Current;
							num = (short)1470038029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
						{
							bool flag;
							if (!flag)
							{
								num = (short)904265732;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 16:
							num = (short)1578041355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (!global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.a())
							{
								num = (short)1002831893;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1367146499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							goto IL_2C6;
						case 19:
							goto IL_428;
						case 20:
							if (string.Compare(A_0.Address.Uri.Scheme, global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("黵賷軹賻跽", a_), global::System.StringComparison.Ordinal) == 0)
							{
								num = (short)679084039;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 21:
							num = (short)1312030740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							goto IL_2AC;
						}
						goto IL_BA;
						IL_1BC:
						num = (short)203948047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F6:
						num = (short)1564016654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_BA:
						goto IL_1F6;
						IL_273:
						num = (short)1221722129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2AC:
						result = false;
						num = (short)696188946;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2C6:
					IL_428:
					IL_445:;
				}
				finally
				{
					num = (short)524704691;
					short num3 = num;
					num = (short)204299187;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)692060160;
						if (num != 0)
						{
						}
						num = (short)2140733442;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_4FF;
							case 1:
								enumerator.Dispose();
								num = (short)773193728;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_4C9;
								}
								continue;
							}
							IL_4C9:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1467678721;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
					}
					IL_4FF:;
				}
				num = (short)1974992896;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x04000014 RID: 20
		private const string a = "CommonCps256Client";

		// Token: 0x04000015 RID: 21
		private const string b = "cps_client_cert_sha256.pfx";

		// Token: 0x04000016 RID: 22
		private const int c = 2000;

		// Token: 0x04000017 RID: 23
		private const int d = 5;
	}
}
