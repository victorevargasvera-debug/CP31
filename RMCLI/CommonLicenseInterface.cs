using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using CommonLicenseInterfaceWrapper;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.Server.EntityModel;

namespace commonLicensing
{
	// Token: 0x02000007 RID: 7
	public class CommonLicenseInterface : global::System.IDisposable
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000026E4 File Offset: 0x000008E4
		public void Dispose()
		{
			short num = (short)1398800385;
			if (num != 0)
			{
			}
			num = (short)1610285056;
			short num2 = num;
			num = (short)1932299277;
			short num3 = num;
			num = (short)1893239821;
			switch (num3 == num)
			{
			}
			num = (short)689700864;
			if (num != 0)
			{
			}
			global::commonLicensing.a a = global::commonLicensing.CommonLicenseInterface.d;
			if (a == null)
			{
				return;
			}
			a.Dispose();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000027A0 File Offset: 0x000009A0
		public static void InitializeLicensing()
		{
			short num = (short)2011750543;
			short num2 = num;
			num = (short)470999183;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1627193344;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1917911041;
			if (num != 0)
			{
			}
			num = (short)2063335424;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002850 File Offset: 0x00000A50
		public static void InitializeLicensing(string hostIDValue, global::commonLicensing.ApplicationType applicationType, string logOutputDir, bool useTrustedStorage = false)
		{
			int a_ = 13;
			short num;
			try
			{
				num = (short)1768423424;
				switch (num)
				{
				default:
				{
					num = (short)754712604;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						bool authRequired;
						global::System.Uri proxy;
						string password;
						string userName;
						global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface commonClientLicensingInterface;
						global::CommonLicenseInterfaceWrapper.ConfigInfo configInfo;
						string folderPath;
						global::CommonLicenseInterfaceWrapper.DeviceInfo deviceInfo;
						string text;
						bool proxyRequired;
						string proxyServerURL;
						string proxyPort;
						string directoryName;
						switch (num2)
						{
						case 0:
							goto IL_6C1;
						case 1:
							global::commonLicensing.CommonLicenseInterface.d = new global::commonLicensing.a();
							num = (short)976093200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							authRequired = true;
							string[] array = proxy.UserInfo.Split(new char[]
							{
								':'
							});
							password = array[0];
							userName = array[1];
							num = (short)1581776918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (commonClientLicensingInterface == null)
							{
								num = (short)483590153;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6A7;
						case 4:
							goto IL_3F4;
						case 5:
							configInfo.trustedStoragePath = string.Empty;
							num = (short)613285894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_57F;
						case 7:
							if (!string.IsNullOrEmpty(proxy.UserInfo))
							{
								num = (short)254214146;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_23E;
						case 8:
							configInfo.trustedStoragePath = global::System.IO.Path.Combine(folderPath, global::commonLicensing.HostIDStoreInstaller.b("톛풟춡횣즥쒧쮩\udfaf\udfb1\ud9b3\ud9b5횷惡鲿郁觃闅귇룉뫋ꯍꋏ軑ꃓꗕ蓗", a_));
							num = (short)955908113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							global::commonLicensing.CommonLicenseInterface.b = hostIDValue;
							global::commonLicensing.CommonLicenseInterface.c = applicationType;
							configInfo = new global::CommonLicenseInterfaceWrapper.ConfigInfo();
							deviceInfo = new global::CommonLicenseInterfaceWrapper.DeviceInfo();
							configInfo.fnoUserName = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::commonLicensing.HostIDStoreInstaller.b("ﺛ증馟銡욣閥盛펩쎭覯쪱킳쎹\ud9bbﶿ￁", a_)));
							configInfo.fnoPassword = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::commonLicensing.HostIDStoreInstaller.b("춛햡좥킩嶺節쮱靈醴边", a_)));
							text = global::System.Environment.GetEnvironmentVariable(global::commonLicensing.HostIDStoreInstaller.b("캛펝ﾟﾫﺯﶷ﮽銿鷁藃苅資飉觋鷍菏", a_));
							num = (short)1328939019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num = (short)770244629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							if (string.IsNullOrEmpty(text))
							{
								num = (short)1177747468;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E9;
						case 12:
							text = global::commonLicensing.HostIDStoreInstaller.b("풟튡힣鲥螧薩삫잭펯ힱ\udab3억톷풹\udbbb邽궿귁냃꧅뫇ꗉꃋ꿍ꏏ뷑룓ꏕ곗동돛냝鏟쳡蟣觥藧", a_);
							num = (short)1313931277;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_E9;
						case 14:
							proxyRequired = true;
							proxyServerURL = proxy.DnsSafeHost;
							proxyPort = proxy.Port.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
							num = (short)1176502279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (global::commonLicensing.CommonLicenseInterface.c.Equals(global::commonLicensing.ApplicationType.RMServer))
							{
								num = (short)1562378248;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_500;
						case 16:
							goto IL_5F6;
						case 17:
							goto IL_57F;
						case 18:
							if (proxy != null)
							{
								num = (short)859111434;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_23E;
						case 19:
							if (global::commonLicensing.CommonLicenseInterface.a.Level == global::System.Diagnostics.TraceLevel.Off)
							{
								num = (short)1242562586;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							configInfo.configLogFilePath = global::System.IO.Path.Combine(directoryName, global::commonLicensing.HostIDStoreInstaller.b("킛잟隡잣\udea5킧쎫삭횯\udbb1펳颵삷ힹ킻", a_));
							configInfo.loggerOutputFilePath = logOutputDir;
							num = (short)124125204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							goto IL_38C;
						case 21:
							if (!string.Equals(proxy.OriginalString, text, global::System.StringComparison.Ordinal))
							{
								num = (short)668073998;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_23E;
						case 22:
							goto IL_23E;
						case 23:
							if (commonClientLicensingInterface.Error() != global::CommonLicenseInterfaceWrapper.CllCode.CLL_SUCCESS)
							{
								num = (short)1617494020;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::commonLicensing.CommonLicenseInterface.d.a(commonClientLicensingInterface, useTrustedStorage);
							num = (short)2044330011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							goto IL_38C;
						case 25:
							if (!useTrustedStorage)
							{
								num = (short)984612869;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)541327375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							configInfo.configLogFilePath = string.Empty;
							configInfo.loggerOutputFilePath = string.Empty;
							num = (short)2135949336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							goto IL_6A7;
						case 28:
							switch (0)
							{
							case 0:
								goto IL_C2;
							}
							continue;
						}
						IL_C2:
						if (global::commonLicensing.CommonLicenseInterface.d == null)
						{
							num = (short)1712390145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F6;
						IL_E9:
						configInfo.fneServerURL = string.Empty;
						configInfo.fnoServerURL = text;
						configInfo.batchResponsePath = string.Empty;
						folderPath = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
						num = (short)1638465561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_23E:
						configInfo.proxyInfo = new global::CommonLicenseInterfaceWrapper.ProxyInfo
						{
							proxyRequired = proxyRequired,
							proxyServerURL = proxyServerURL,
							proxyPort = proxyPort,
							authRequired = authRequired,
							password = password,
							userName = userName
						};
						directoryName = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetCallingAssembly().Location);
						configInfo.dllFilePath = directoryName;
						configInfo.sslRequired = global::CommonLicenseInterfaceWrapper.SSLTypeCode.SSLTYPE_SERVER_AUTH;
						configInfo.sslCertFileName = global::System.IO.Path.Combine(directoryName, global::commonLicensing.HostIDStoreInstaller.b("ꪛ꺝醟醡鲣銥馧鎩鲫骭", a_));
						configInfo.sslClientCertFileName = string.Empty;
						configInfo.sslPassphrase = string.Empty;
						num = (short)706543635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_38C:
						deviceInfo.deviceId = global::commonLicensing.CommonLicenseInterface.b;
						deviceInfo.deviceAlias = string.Empty;
						deviceInfo.deviceType = string.Empty;
						commonClientLicensingInterface = new global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface(configInfo, deviceInfo);
						commonClientLicensingInterface.Error();
						num = (short)174260247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_57F:
						proxyRequired = false;
						authRequired = false;
						proxyServerURL = string.Empty;
						proxyPort = string.Empty;
						password = string.Empty;
						userName = string.Empty;
						proxy = global::System.Net.WebRequest.DefaultWebProxy.GetProxy(new global::System.Uri(text));
						num = (short)1918107666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5F6:
						commonClientLicensingInterface = global::commonLicensing.CommonLicenseInterface.d.a(useTrustedStorage);
						num = (short)931725315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6A7:
						num = (short)780468224;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3F4:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_FAILED_INITIALIZE_LICENSING);
					IL_500:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_INITIALIZE_LICENSING);
					IL_6C1:
					break;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException e)
			{
				if (global::commonLicensing.CommonLicenseInterface.c.Equals(global::commonLicensing.ApplicationType.RMC))
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::commonLicensing.HostIDStoreInstaller.b("캛펝ﶡ즥쾧충즫\udcad", a_)).WriteEventEntry(e, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
				}
				throw;
			}
			catch (global::System.Exception e2)
			{
				if (!global::commonLicensing.CommonLicenseInterface.c.Equals(global::commonLicensing.ApplicationType.RMC))
				{
					goto IL_73A;
				}
				IL_71D:
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::commonLicensing.HostIDStoreInstaller.b("캛펝ﶡ즥쾧충즫\udcad", a_)).WriteEventEntry(e2, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
				IL_73A:
				num = (short)1024793917;
				short num3 = num;
				num = (short)1372986685;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_71D;
				default:
					num = (short)49938432;
					if (num != 0)
					{
					}
					num = (short)1463156737;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_INITIALIZE_LICENSING);
				}
			}
			num = (short)184418304;
			short num4 = num;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003074 File Offset: 0x00001274
		public static void CleanupLicensing(bool useTrustedStorage = false)
		{
			short num = (short)375783425;
			if (num != 0)
			{
			}
			num = (short)132579328;
			short num2 = num;
			num = (short)1672757110;
			short num3 = num;
			num = (short)1145847670;
			switch (num3 == num)
			{
			}
			num = (short)1606287360;
			if (num != 0)
			{
			}
			global::commonLicensing.a a = global::commonLicensing.CommonLicenseInterface.d;
			if (a == null)
			{
				return;
			}
			a.b(useTrustedStorage);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003130 File Offset: 0x00001330
		public static bool QueryFeaturesExists(bool useTrustedStorage = false)
		{
			short num;
			bool result;
			try
			{
				num = (short)1216086021;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::CommonLicenseInterfaceWrapper.QueryFeatureResponse queryFeatureResponse;
					switch (num2)
					{
					case 0:
						result = true;
						num = (short)1526071300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (new global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.FeatureProperties>(queryFeatureResponse.featurePropertiesList).Count > 0)
						{
							num = (short)526254080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)2069364738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_13B;
					case 3:
						goto IL_82;
					case 4:
						goto IL_C4;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_3E;
						}
						continue;
					}
					IL_3E:
					global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface commonClientLicensingInterface = global::commonLicensing.CommonLicenseInterface.d.a(useTrustedStorage);
					if (commonClientLicensingInterface == null)
					{
						break;
					}
					global::CommonLicenseInterfaceWrapper.FeatureInfo featureInfo = global::commonLicensing.c.a(string.Empty, string.Empty);
					queryFeatureResponse = commonClientLicensingInterface.queryFeatures(featureInfo);
					if (commonClientLicensingInterface.Error() != global::CommonLicenseInterfaceWrapper.CllCode.CLL_SUCCESS)
					{
						num = (short)1324941315;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)981598209;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_LICENSING_NOT_INITIALIZED);
				IL_82:
				num = (short)1364525057;
				if (num != 0)
				{
				}
				goto IL_117;
				IL_C4:
				goto IL_195;
				IL_117:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_FAILED_QUERY_FEATURES_FROM_TS);
				IL_13B:
				num = (short)1341237690;
				short num3 = num;
				num = (short)1546561978;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_117;
				default:
					num = (short)1453522944;
					if (num != 0)
					{
					}
					break;
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_FAILED_QUERY_FEATURES_FROM_TS);
			}
			IL_195:
			num = (short)699334656;
			short num4 = num;
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003330 File Offset: 0x00001530
		public static global::Motorola.CommonCPS.Server.EntityModel.EntitlementList GetEntitlementDetails(string entitlementID, out bool isFNP, bool supportFNP, bool useTrustedStorage = false)
		{
			int a_ = 15;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.EntitlementList result;
			try
			{
				num = (short)1786249216;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface commonClientLicensingInterface;
					global::CommonLicenseInterfaceWrapper.CllCode cllCode;
					for (;;)
					{
						IL_30:
						global::Motorola.CommonCPS.Server.EntityModel.EntitlementList entitlementList;
						switch (num2)
						{
						case 0:
							goto IL_9DA;
						case 1:
						{
							if (commonClientLicensingInterface.Error() != global::CommonLicenseInterfaceWrapper.CllCode.CLL_SUCCESS)
							{
								num = (short)49938438;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string prodName = string.Empty;
							string prodVersion = string.Empty;
							string currFlashCd = string.Empty;
							string modelNum = string.Empty;
							string newFlashCd = string.Empty;
							string noticeParam = string.Empty;
							global::CommonLicenseInterfaceWrapper.GetEntitlementResponse entitlementDetails;
							global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.EntitlementResponse> enumerator = entitlementDetails.entitlementResponseList.GetEnumerator();
							num = (short)2045378560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							if (cllCode - global::CommonLicenseInterfaceWrapper.CllCode.CLL_SERVER_ERROR <= 1)
							{
								goto IL_A85;
							}
							num = (short)1090743732;
							short num3 = num;
							num = (short)224226740;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_9DA;
							default:
								num = (short)1284243456;
								if (num != 0)
								{
								}
								num = (short)53084163;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_A80;
						case 4:
							goto IL_AAB;
						case 5:
							goto IL_92;
						case 6:
							cllCode = commonClientLicensingInterface.Error();
							num = (short)1591214082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							if (commonClientLicensingInterface == null)
							{
								num = (short)1709309957;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							isFNP = false;
							entitlementList = new global::Motorola.CommonCPS.Server.EntityModel.EntitlementList();
							global::CommonLicenseInterfaceWrapper.GetEntitlementResponse entitlementDetails = commonClientLicensingInterface.getEntitlementDetails(entitlementID);
							num = (short)1089339393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_57;
						IL_9DA:
						try
						{
							num = (short)1670119428;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.EntitlementResponse> enumerator;
								global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.LineItem> enumerator3;
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1758724099;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_8C4;
								case 1:
									try
									{
										num = (short)982384660;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											string modelNum;
											global::CommonLicenseInterfaceWrapper.LineItem lineItem;
											switch (num2)
											{
											case 0:
												try
												{
													num = (short)246939649;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
															isFNP = true;
															num = (short)182059011;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 1:
															switch (0)
															{
															case 0:
																goto IL_2F4;
															}
															continue;
														case 2:
														{
															global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.ProductInfo> enumerator2;
															if (!enumerator2.MoveNext())
															{
																num = (short)1924464644;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::CommonLicenseInterfaceWrapper.ProductInfo productInfo = enumerator2.Current;
															num = (short)1873346567;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 3:
															if (supportFNP)
															{
																num = (short)810156037;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														case 4:
															num = (short)1265500168;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 5:
														{
															global::CommonLicenseInterfaceWrapper.ProductInfo productInfo;
															string prodName = productInfo.productName;
															string prodVersion = productInfo.productVersion;
															string currFlashCd;
															string newFlashCd;
															string noticeParam;
															entitlementList.entitlementItems.Add(new global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem(lineItem.activationId, lineItem.expirationDate, lineItem.isPermanent, prodName, prodVersion, lineItem.availableCount, lineItem.totalCount, modelNum, currFlashCd, newFlashCd, lineItem.isTrustedType, noticeParam));
															num = (short)341770246;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 7:
														{
															if (lineItem.isTrustedType)
															{
																num = (short)2059534336;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::CommonLicenseInterfaceWrapper.ProductInfo productInfo;
															string prodName = productInfo.productName;
															string prodVersion = productInfo.productVersion;
															string currFlashCd;
															string newFlashCd;
															string noticeParam;
															entitlementList.entitlementItems.Add(new global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem(lineItem.activationId, lineItem.expirationDate, lineItem.isPermanent, prodName, prodVersion, lineItem.availableCount, lineItem.totalCount, modelNum, currFlashCd, newFlashCd, lineItem.isTrustedType, noticeParam));
															num = (short)526123017;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 8:
															goto IL_4C0;
														}
														IL_3A8:
														num = (short)405078018;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_2F4:
														goto IL_3A8;
													}
													IL_4C0:
													break;
												}
												finally
												{
													num = (short)1718878208;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.ProductInfo> enumerator2;
														switch (num2)
														{
														case 0:
															switch (0)
															{
															case 0:
																goto IL_4F7;
															}
															continue;
														case 1:
															enumerator2.Dispose();
															num = (short)1583349762;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 2:
															goto IL_52E;
														}
														IL_4F7:
														if (enumerator2 == null)
														{
															break;
														}
														num = (short)1675886593;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_52E:;
												}
												goto IL_531;
											case 1:
												goto IL_853;
											case 2:
												goto IL_6D5;
											case 3:
											{
												if (!enumerator3.MoveNext())
												{
													num = (short)1230438405;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												lineItem = enumerator3.Current;
												string currFlashCd = string.Empty;
												modelNum = string.Empty;
												string newFlashCd = string.Empty;
												string noticeParam = string.Empty;
												num = (short)1895038985;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												if (lineItem.dictionary[global::commonLicensing.HostIDStoreInstaller.b("킝", a_)] != null)
												{
													num = (short)42139664;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_5E0;
											case 5:
												num = (short)856948737;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
											{
												global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.ProductInfo> enumerator2 = lineItem.productInfoList.GetEnumerator();
												num = (short)1880948736;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
											{
												entitlementList.currentFlashCode = lineItem.dictionary[global::commonLicensing.HostIDStoreInstaller.b("\udd9dﺩﲯﺵ﮷﮽", a_)];
												string currFlashCd = lineItem.dictionary[global::commonLicensing.HostIDStoreInstaller.b("\udd9dﺩﲯﺵ﮷﮽", a_)];
												num = (short)555679761;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 8:
											{
												entitlementList.newFlashCode = lineItem.dictionary[global::commonLicensing.HostIDStoreInstaller.b("킝ﮣﾫﶱ", a_)];
												string newFlashCd = lineItem.dictionary[global::commonLicensing.HostIDStoreInstaller.b("킝ﮣﾫﶱ", a_)];
												num = (short)349241356;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 9:
												if (lineItem.dictionary.Count > 0)
												{
													num = (short)1017118734;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_5E0;
											case 10:
												goto IL_5E0;
											case 11:
												if (lineItem.dictionary[global::commonLicensing.HostIDStoreInstaller.b("펝嶺", a_)] != null)
												{
													num = (short)2052325389;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_6D5;
											case 12:
												goto IL_58A;
											case 13:
												goto IL_531;
											case 14:
												num = (short)4522003;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 15:
												if (lineItem.dictionary[global::commonLicensing.HostIDStoreInstaller.b("킝ﮣﾫﶱ", a_)] != null)
												{
													num = (short)490536968;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_58A;
											case 16:
											{
												string noticeParam = lineItem.dictionary[global::commonLicensing.HostIDStoreInstaller.b("킝", a_)];
												num = (short)1858863114;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 17:
												goto IL_629;
											case 18:
												if (lineItem.productInfoList.Count > 0)
												{
													num = (short)1294860294;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_29B;
											case 19:
												if (lineItem.dictionary[global::commonLicensing.HostIDStoreInstaller.b("\udd9dﺩﲯﺵ﮷﮽", a_)] != null)
												{
													num = (short)1493106695;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_629;
											case 20:
												switch (0)
												{
												case 0:
													goto IL_1E1;
												}
												continue;
											}
											goto IL_1E1;
											IL_531:
											entitlementList.modelNumber = lineItem.dictionary[global::commonLicensing.HostIDStoreInstaller.b("펝嶺", a_)];
											modelNum = lineItem.dictionary[global::commonLicensing.HostIDStoreInstaller.b("펝嶺", a_)];
											num = (short)171180034;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_58A:
											num = (short)612696075;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_5E0:
											num = (short)186908690;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_629:
											num = (short)278659087;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_6D5:
											num = (short)1985413124;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_7CD:
											num = (short)1461714947;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1E1:
											goto IL_7CD;
										}
										IL_29B:
										throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GET_ENTITLEMENT_DETAILS);
										IL_853:
										break;
									}
									finally
									{
										num = (short)2001207296;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_88A;
												}
												continue;
											case 1:
												enumerator3.Dispose();
												num = (short)302841858;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_8C1;
											}
											IL_88A:
											if (enumerator3 == null)
											{
												break;
											}
											num = (short)619642881;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_8C1:;
									}
									goto IL_8C4;
								case 2:
									goto IL_90E;
								case 3:
									num = (short)1199767554;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_125;
									}
									continue;
								}
								IL_12A:
								num = (short)1906769920;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_125:
								goto IL_12A;
								IL_8C4:
								enumerator3 = enumerator.Current.lineItemList.GetEnumerator();
								num = (short)1759313921;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_90E:
							goto IL_A90;
						}
						finally
						{
							num = (short)676134912;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.EntitlementResponse> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_945;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1329659906;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_97E;
								}
								IL_945:
								if (enumerator == null)
								{
									break;
								}
								num = (short)665976833;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_97E:;
						}
						break;
						IL_A90:
						result = entitlementList;
						num = (short)1657012228;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_92:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_LICENSING_NOT_INITIALIZED);
					IL_A80:
					int num4 = cllCode - global::CommonLicenseInterfaceWrapper.CllCode.CLL_NO_LICENSE_AVAILABLE;
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_FAILED_GET_ENTITLEMENT_DETAILS);
					IL_A85:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_NO_RESPONSE_FROM_SERVER);
					IL_AAB:
					break;
					IL_57:
					commonClientLicensingInterface = global::commonLicensing.CommonLicenseInterface.d.a(useTrustedStorage);
					num = (short)1236992007;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException e)
			{
				if (global::commonLicensing.CommonLicenseInterface.c.Equals(global::commonLicensing.ApplicationType.RMC))
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::commonLicensing.HostIDStoreInstaller.b("첝ﮣ잧충쮫쮭슯", a_)).WriteEventEntry(e, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
				}
				throw;
			}
			catch (global::System.Exception e2)
			{
				if (global::commonLicensing.CommonLicenseInterface.c.Equals(global::commonLicensing.ApplicationType.RMC))
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::commonLicensing.HostIDStoreInstaller.b("첝ﮣ잧충쮫쮭슯", a_)).WriteEventEntry(e2, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
				}
				num = (short)601030657;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GET_ENTITLEMENT_DETAILS);
			}
			num = (short)405798912;
			short num5 = num;
			return result;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003F3C File Offset: 0x0000213C
		public static global::System.Collections.Generic.List<string> GetDevicesQuery(string activationID, bool useTrustedStorage = false)
		{
			int a_ = 5;
			short num;
			global::System.Collections.Generic.List<string> result;
			try
			{
				num = (short)1129447424;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface commonClientLicensingInterface;
					global::CommonLicenseInterfaceWrapper.CllCode cllCode;
					for (;;)
					{
						IL_30:
						switch (num2)
						{
						case 0:
						{
							if (commonClientLicensingInterface == null)
							{
								num = (short)2083520516;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.ICollection<global::CommonLicenseInterfaceWrapper.Entry> devicesQuery = commonClientLicensingInterface.getDevicesQuery(activationID, string.Empty);
							num = (short)1943863299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							cllCode = commonClientLicensingInterface.Error();
							num = (short)962723842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (cllCode - global::CommonLicenseInterfaceWrapper.CllCode.CLL_SERVER_ERROR > 1)
							{
								num = (short)1135083527;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2E8;
						case 3:
						{
							if (commonClientLicensingInterface.Error() != global::CommonLicenseInterfaceWrapper.CllCode.CLL_SUCCESS)
							{
								num = (short)395575297;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
							global::System.Collections.Generic.ICollection<global::CommonLicenseInterfaceWrapper.Entry> devicesQuery;
							global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.Entry> enumerator = devicesQuery.GetEnumerator();
							num = (short)137101317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_91;
						case 5:
						{
							global::System.Collections.Generic.List<string> list;
							try
							{
								num = (short)1542651905;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.Entry> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1519631714;
											short num3 = num;
											num = (short)1918156130;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												num = (short)257949696;
												if (num != 0)
												{
												}
												num = (short)325779458;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
										}
										else
										{
											global::CommonLicenseInterfaceWrapper.Entry entry = enumerator.Current;
											list.Add(entry.deviceId);
										}
										num = (short)1036255235;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										switch (0)
										{
										case 0:
											goto IL_11F;
										}
										continue;
									case 2:
										num = (short)112918532;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_1F0;
									}
									IL_121:
									num = (short)1487011840;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_11F:
									goto IL_121;
								}
								IL_1F0:
								goto IL_2F3;
							}
							finally
							{
								num = (short)899350528;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.Entry> enumerator;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_227;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)1401421826;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_25E;
									}
									IL_227:
									if (enumerator == null)
									{
										break;
									}
									num = (short)477495297;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_25E:;
							}
							goto IL_261;
							IL_2F3:
							result = list;
							num = (short)1292369926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_30F;
						case 7:
							goto IL_2E6;
						}
						goto IL_57;
					}
					IL_91:
					IL_261:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_LICENSING_NOT_INITIALIZED);
					IL_2E6:
					int num4 = cllCode - global::CommonLicenseInterfaceWrapper.CllCode.CLL_NO_LICENSE_AVAILABLE;
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_FAILED_GET_DEVICE_QUERY);
					IL_2E8:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_NO_RESPONSE_FROM_SERVER);
					IL_30F:
					break;
					IL_57:
					commonClientLicensingInterface = global::commonLicensing.CommonLicenseInterface.d.a(useTrustedStorage);
					num = (short)1073479680;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException e)
			{
				if (global::commonLicensing.CommonLicenseInterface.c.Equals(global::commonLicensing.ApplicationType.RMC))
				{
					num = (short)1530134529;
					if (num != 0)
					{
					}
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::commonLicensing.HostIDStoreInstaller.b("욓\udb95\udb97얙킛잟얡솣풥", a_)).WriteEventEntry(e, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
				}
				throw;
			}
			catch (global::System.Exception e2)
			{
				if (global::commonLicensing.CommonLicenseInterface.c.Equals(global::commonLicensing.ApplicationType.RMC))
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::commonLicensing.HostIDStoreInstaller.b("욓\udb95\udb97얙킛잟얡솣풥", a_)).WriteEventEntry(e2, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GET_DEVICES_QUERY);
			}
			num = (short)1619591168;
			short num5 = num;
			return result;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000437C File Offset: 0x0000257C
		public static string GetHostID(string Apptype)
		{
			short num;
			string newHostID;
			try
			{
				num = (short)948402949;
				short num2 = num;
				num = (short)1274116869;
				switch (num2 == num)
				{
				}
				num = (short)786956288;
				if (num != 0)
				{
				}
				newHostID = global::commonLicensing.HostID.getNewHostID(Apptype);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GETHOSTID);
			}
			num = (short)705953792;
			short num3 = num;
			num = (short)1666908161;
			if (num != 0)
			{
			}
			return newHostID;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00004458 File Offset: 0x00002658
		public static global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest CreateActivationRequest(string deviceID, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation> activationInfo)
		{
			short num = (short)60096512;
			short num2 = num;
			num = (short)393224549;
			short num3 = num;
			num = (short)1625170277;
			switch (num3 == num)
			{
			}
			num = (short)908722176;
			if (num != 0)
			{
			}
			num = (short)1662779393;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest(activationInfo, deviceID);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000450C File Offset: 0x0000270C
		public static global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest CreateRecoverRequest(string deviceID)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1638137858;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_BA;
					case 1:
						deviceID = global::commonLicensing.CommonLicenseInterface.b;
						num = (short)836370432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)66909707;
						short num3 = num;
						num = (short)805959179;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)88473600;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_7C;
							}
							continue;
						}
						break;
					}
					}
					IL_7C:
					if (!string.IsNullOrEmpty(deviceID))
					{
						goto IL_10E;
					}
					num = (short)1874984961;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_BA:
			num = (short)301006848;
			short num4 = num;
			num = (short)2030895105;
			if (num != 0)
			{
			}
			IL_10E:
			return new global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation>(), deviceID);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00004634 File Offset: 0x00002834
		public static byte[] SendRequestToServer(global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest deviceRequest, bool useTrustedStorage = false)
		{
			short num;
			byte[] binaryResponse;
			try
			{
				num = (short)1485045760;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					for (;;)
					{
						IL_1D:
						switch (0)
						{
						case 0:
							goto IL_4E;
						}
						global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface commonClientLicensingInterface;
						for (;;)
						{
							IL_27:
							switch (num2)
							{
							case 0:
							{
								global::CommonLicenseInterfaceWrapper.CllCode cllCode = commonClientLicensingInterface.Error();
								num = (short)62128130;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								num = (short)1335754759;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								global::CommonLicenseInterfaceWrapper.CllCode cllCode;
								switch (cllCode)
								{
								case global::CommonLicenseInterfaceWrapper.CllCode.CLL_SERVER_ERROR:
								case global::CommonLicenseInterfaceWrapper.CllCode.CLL_NO_LICENSE_AVAILABLE:
								case global::CommonLicenseInterfaceWrapper.CllCode.CLL_ERROR:
									goto IL_138;
								case global::CommonLicenseInterfaceWrapper.CllCode.CLL_SERVER_DOWN:
									goto IL_122;
								default:
									num = (short)622919681;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								goto IL_1E6;
							case 4:
							{
								num = (short)1105065944;
								short num3 = num;
								num = (short)2085025752;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1D;
								default:
								{
									num = (short)237764608;
									if (num != 0)
									{
									}
									if (commonClientLicensingInterface == null)
									{
										num = (short)295501829;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::CommonLicenseInterfaceWrapper.DeviceRequest serverRequest = global::commonLicensing.c.a(deviceRequest);
									global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse deviceCapabilityResponse = commonClientLicensingInterface.sendRequestToFNOServer(serverRequest);
									num = (short)2060124166;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 5:
								goto IL_D4;
							case 6:
							{
								if (commonClientLicensingInterface.Error() != global::CommonLicenseInterfaceWrapper.CllCode.CLL_SUCCESS)
								{
									num = (short)947847168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse deviceCapabilityResponse;
								new byte[deviceCapabilityResponse.binaryResponseSize];
								binaryResponse = deviceCapabilityResponse.binaryResponse;
								num = (short)1096024067;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								goto IL_166;
							}
							break;
						}
						IL_4E:
						commonClientLicensingInterface = global::commonLicensing.CommonLicenseInterface.d.a(useTrustedStorage);
						num = (short)847249412;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_27;
					}
					IL_D4:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_LICENSING_NOT_INITIALIZED);
					IL_122:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_NO_RESPONSE_FROM_SERVER);
					IL_138:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_FAILED_SEND_REQUEST_TO_SERVER);
					IL_166:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_FAILED_SEND_REQUEST_TO_SERVER);
					IL_1E6:
					break;
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_FAILED_SEND_REQUEST_TO_SERVER);
			}
			num = (short)597098496;
			short num4 = num;
			num = (short)28377089;
			if (num != 0)
			{
			}
			return binaryResponse;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000048C0 File Offset: 0x00002AC0
		public static byte[] SendRefreshRequestToServer(global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest deviceRequest, bool useTrustedStorage = false)
		{
			short num;
			byte[] binaryResponse;
			try
			{
				num = (short)76087296;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					for (;;)
					{
						IL_1D:
						num = (short)2085224449;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_74;
						}
						global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface commonClientLicensingInterface;
						for (;;)
						{
							IL_4D:
							switch (num2)
							{
							case 0:
							{
								global::CommonLicenseInterfaceWrapper.CllCode cllCode = commonClientLicensingInterface.Error();
								num = (short)2127953922;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								num = (short)1163591687;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								global::CommonLicenseInterfaceWrapper.CllCode cllCode;
								switch (cllCode)
								{
								case global::CommonLicenseInterfaceWrapper.CllCode.CLL_SERVER_ERROR:
								case global::CommonLicenseInterfaceWrapper.CllCode.CLL_NO_LICENSE_AVAILABLE:
								case global::CommonLicenseInterfaceWrapper.CllCode.CLL_ERROR:
									goto IL_162;
								case global::CommonLicenseInterfaceWrapper.CllCode.CLL_SERVER_DOWN:
									goto IL_14C;
								default:
									num = (short)1051394049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								goto IL_213;
							case 4:
							{
								num = (short)625323136;
								short num3 = num;
								num = (short)1779084416;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1D;
								default:
								{
									num = (short)280625152;
									if (num != 0)
									{
									}
									if (commonClientLicensingInterface == null)
									{
										num = (short)1288634373;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::CommonLicenseInterfaceWrapper.DeviceRequest serverRequest = global::commonLicensing.c.a(deviceRequest);
									global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse deviceCapabilityResponse = commonClientLicensingInterface.sendRefreshRequestToFNOServer(serverRequest);
									num = (short)963706886;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 5:
								goto IL_FE;
							case 6:
							{
								if (commonClientLicensingInterface.Error() != global::CommonLicenseInterfaceWrapper.CllCode.CLL_SUCCESS)
								{
									num = (short)1503264768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse deviceCapabilityResponse;
								new byte[deviceCapabilityResponse.binaryResponseSize];
								binaryResponse = deviceCapabilityResponse.binaryResponse;
								num = (short)2050293763;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								goto IL_190;
							}
							break;
						}
						IL_74:
						commonClientLicensingInterface = global::commonLicensing.CommonLicenseInterface.d.a(useTrustedStorage);
						num = (short)1370292228;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_4D;
					}
					IL_FE:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_LICENSING_NOT_INITIALIZED);
					IL_14C:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_NO_RESPONSE_FROM_SERVER);
					IL_162:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_FAILED_SEND_RECOVER_REQUEST_TO_SERVER);
					IL_190:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_FAILED_SEND_RECOVER_REQUEST_TO_SERVER);
					IL_213:
					break;
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_FAILED_SEND_RECOVER_REQUEST_TO_SERVER);
			}
			num = (short)502530048;
			short num4 = num;
			return binaryResponse;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00004B54 File Offset: 0x00002D54
		public static global::Motorola.CommonCPS.Server.EntityModel.FeatureList QueryFeaturesFromResponse(byte[] response, string deviceID, string featureName, string featureVersion, bool useTrustedStorage = false)
		{
			int a_ = 3;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.FeatureList result;
			try
			{
				num = (short)622067712;
				switch (num)
				{
				default:
				{
					num = (short)348782605;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.Server.EntityModel.FeatureList featureList;
						global::CommonLicenseInterfaceWrapper.QueryFeatureResponse queryFeatureResponse;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.FeatureItem> list;
						int num3;
						global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.FeatureProperties> list2;
						switch (num2)
						{
						case 0:
							featureList.currentFlashCode = queryFeatureResponse.dictionary[global::commonLicensing.HostIDStoreInstaller.b("톑솓쒕쪗\udf99튛쪝ﾟﮧ", a_)];
							num = (short)1444741129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1874657286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							featureList.modelNumber = queryFeatureResponse.dictionary[global::commonLicensing.HostIDStoreInstaller.b("\udf91\udb93튕\udd97횙쎛킝", a_)];
							num = (short)2073493519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (queryFeatureResponse.dictionary[global::commonLicensing.HostIDStoreInstaller.b("톑솓쒕쪗\udf99튛쪝ﾟﮧ", a_)] != null)
							{
								num = (short)485163008;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19E;
						case 4:
							goto IL_392;
						case 5:
							featureList.features = list;
							result = featureList;
							num = (short)1657995274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (queryFeatureResponse.dictionary[global::commonLicensing.HostIDStoreInstaller.b("\udf91\udb93튕\udd97횙쎛킝", a_)] != null)
							{
								num = (short)1614675970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_462;
						case 7:
							goto IL_45D;
						case 8:
							featureList.newFlashCode = queryFeatureResponse.dictionary[global::commonLicensing.HostIDStoreInstaller.b("\udc91톓솕잗\udc99킛\udf9d", a_)];
							num = (short)373620753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_19E;
						case 10:
							goto IL_4DD;
						case 11:
							if (num3 >= list2.Count)
							{
								num = (short)2006056965;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							list.Add(new global::Motorola.CommonCPS.Server.EntityModel.FeatureItem
							{
								expirationDate = list2[num3].expirationDate,
								isPermanent = list2[num3].isPermanent,
								isUnlimited = list2[num3].isUnlimited,
								featureName = list2[num3].featureInfoCount.featureName,
								featureVersion = list2[num3].featureInfoCount.featureVersion,
								featureCount = list2[num3].featureInfoCount.featureCount,
								vendorString = list2[num3].vendorString,
								notice = list2[num3].notice
							});
							num3++;
							num = (short)1514995716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (queryFeatureResponse.dictionary.Count > 0)
							{
								num = (short)1869348865;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_BB;
						case 13:
							switch (0)
							{
							case 0:
								goto IL_97;
							}
							continue;
						case 14:
							goto IL_392;
						case 15:
							num = (short)873332737;
							if (num != 0)
							{
							}
							goto IL_462;
						case 16:
							if (queryFeatureResponse.dictionary[global::commonLicensing.HostIDStoreInstaller.b("\udc91톓솕잗\udc99킛\udf9d", a_)] != null)
							{
								num = (short)2081423368;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_BB;
						case 17:
							goto IL_BB;
						}
						goto IL_97;
						IL_BB:
						num3 = 0;
						num = (short)1019346958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_19E:
						num = (short)2143551504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_97:
						global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface commonClientLicensingInterface = global::commonLicensing.CommonLicenseInterface.d.a(useTrustedStorage);
						if (commonClientLicensingInterface == null)
						{
							break;
						}
						if (string.IsNullOrEmpty(deviceID))
						{
							deviceID = global::commonLicensing.CommonLicenseInterface.b;
						}
						if (response == null)
						{
							response = new byte[]
							{
								0
							};
						}
						global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse devResponse = global::commonLicensing.c.a(response, deviceID);
						global::CommonLicenseInterfaceWrapper.FeatureInfo featureInfo = new global::CommonLicenseInterfaceWrapper.FeatureInfo(featureName, featureVersion);
						queryFeatureResponse = commonClientLicensingInterface.queryFeaturesFromResponse(devResponse, featureInfo);
						if (commonClientLicensingInterface.Error() != global::CommonLicenseInterfaceWrapper.CllCode.CLL_SUCCESS)
						{
							num = (short)1020198919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list2 = new global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.FeatureProperties>(queryFeatureResponse.featurePropertiesList);
						featureList = new global::Motorola.CommonCPS.Server.EntityModel.FeatureList();
						list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.FeatureItem>();
						num = (short)1185742860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_392:
						num = (short)77070347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_462:
						num = (short)1338900483;
						num2 = (int)((global::System.IntPtr)num);
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_LICENSING_NOT_INITIALIZED);
					IL_45D:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CLI_FAILED_QUERY_FEATURES_FROM_RESPONSE);
					IL_4DD:
					break;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException e)
			{
				if (global::commonLicensing.CommonLicenseInterface.c.Equals(global::commonLicensing.ApplicationType.RMC))
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::commonLicensing.HostIDStoreInstaller.b("삑\ud993햕잗횙劣잟잡횣", a_)).WriteEventEntry(e, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
				}
				throw;
			}
			catch (global::System.Exception e2)
			{
				if (!global::commonLicensing.CommonLicenseInterface.c.Equals(global::commonLicensing.ApplicationType.RMC))
				{
					goto IL_556;
				}
				IL_537:
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::commonLicensing.HostIDStoreInstaller.b("삑\ud993햕잗횙劣잟잡횣", a_)).WriteEventEntry(e2, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
				IL_556:
				num = (short)1820290195;
				short num4 = num;
				num = (short)847801491;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_537;
				default:
					num = (short)1370554368;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FNE_FAILED_GET_FEATURECOLLECTION);
				}
			}
			num = (short)54132736;
			short num5 = num;
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000516C File Offset: 0x0000336C
		public static bool ValidateResponse(byte[] response, string radioID, string AID)
		{
			short num = (short)182976512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				bool result;
				for (;;)
				{
					IL_28:
					int num3;
					global::Motorola.CommonCPS.Server.EntityModel.FeatureList featureList;
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						goto IL_C8;
					case 2:
						goto IL_26F;
					case 3:
						if (num3 >= featureList.features.Count)
						{
							num = (short)54460416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)283836427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)710384130;
						short num4 = num;
						num = (short)552049154;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_190;
						default:
							num = (short)1168179200;
							if (num != 0)
							{
							}
							if (AID.Length == 0)
							{
								num = (short)1030815745;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BD;
						}
						break;
					}
					case 5:
						goto IL_190;
					case 6:
						goto IL_1B8;
					case 7:
						num = (short)1421410308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						if (response.Length == 0)
						{
							num = (short)939458560;
							short num5 = num;
							num = (short)1687814153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string empty = string.Empty;
						string empty2 = string.Empty;
						featureList = global::commonLicensing.CommonLicenseInterface.QueryFeaturesFromResponse(response, radioID, empty, empty2, false);
						num = (short)248250369;
						if (num != 0)
						{
						}
						num = (short)1865809925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						return result;
					case 10:
						goto IL_1BD;
					case 11:
						if (!global::commonLicensing.CommonLicenseInterface.GetAIDFromFeature(featureList.features[num3]).Equals(AID))
						{
							num = (short)1580990471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C8;
					case 12:
						goto IL_26F;
					}
					goto IL_63;
					IL_C8:
					result = true;
					num = (short)823263242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_190:
					if (featureList.features.Count == 0)
					{
						num = (short)1217265670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = 0;
					num = (short)513343490;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BD:
					num3++;
					num = (short)1806761996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26F:
					num = (short)1649475587;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_1B8:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SFC_RM_NO_FEATURE_ON_SERVER);
				IL_63:
				result = false;
				num = (short)545062920;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00005458 File Offset: 0x00003658
		public static bool ValidateResponse(byte[] response, string hostID, global::System.Collections.Generic.List<string> aidsToValidate)
		{
			short num = (short)345767936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				for (;;)
				{
					IL_28:
					string empty;
					string empty2;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.FeatureList featureList = global::commonLicensing.CommonLicenseInterface.QueryFeaturesFromResponse(response, hostID, empty, empty2, false);
						global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
						if (featureList.features.Count == 0)
						{
							goto Block_3;
						}
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.FeatureItem>.Enumerator enumerator = featureList.features.GetEnumerator();
						num = (short)741998593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)1313341440;
						short num3 = num;
						try
						{
							num = (short)2028797954;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_185;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_DA;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.FeatureItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)118095876;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.FeatureItem feature = enumerator.Current;
									global::System.Collections.Generic.List<string> list;
									list.Add(global::commonLicensing.CommonLicenseInterface.GetAIDFromFeature(feature));
									num = (short)1156644864;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1128988673;
									if (num != 0)
									{
									}
									num = (short)467795969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_DC:
								num = (short)1889337347;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DA:
								goto IL_DC;
							}
							IL_185:
							goto IL_7D;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.FeatureItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_198;
						IL_7D:
						global::System.Collections.Generic.List<string>.Enumerator enumerator2 = aidsToValidate.GetEnumerator();
						num = (short)949813252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (response.Length == 0)
						{
							num = (short)1516437507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_198;
					case 3:
						goto IL_78;
					case 4:
						goto IL_9B;
					}
					goto IL_43;
					IL_198:
					empty = string.Empty;
					empty2 = string.Empty;
					num = (short)114294784;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_78:
				return false;
				IL_9B:
				bool result;
				try
				{
					num = (short)244514820;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.List<string> list;
							string item;
							if (!list.Contains(item))
							{
								num = (short)1494351874;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							num = (short)1120470727;
							short num4 = num;
							num = (short)1105921735;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_248;
							default:
								num = (short)1616576512;
								if (num != 0)
								{
								}
								num = (short)394985475;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							result = false;
							num = (short)1147535365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_31E;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_224;
							}
							continue;
						case 6:
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator2;
							if (!enumerator2.MoveNext())
							{
								num = (short)583794689;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string item = enumerator2.Current;
							goto IL_248;
						}
						}
						goto IL_224;
						IL_248:
						num = (short)198508544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_27F:
						num = (short)334888966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_224:
						goto IL_27F;
					}
					IL_31E:
					return result;
				}
				finally
				{
					global::System.Collections.Generic.List<string>.Enumerator enumerator2;
					((global::System.IDisposable)enumerator2).Dispose();
				}
				return false;
				Block_3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SFC_RM_NO_FEATURE_ON_SERVER);
				IL_43:
				result = true;
				num = (short)744816642;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000582C File Offset: 0x00003A2C
		public static string GetAIDFromFeature(global::Motorola.CommonCPS.Server.EntityModel.FeatureItem feature)
		{
			int a_ = 4;
			int num;
			short num2;
			string text;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1353890634;
						short num3 = num2;
						num2 = (short)1951775562;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_34;
						default:
							num2 = (short)1385889792;
							if (num2 != 0)
							{
							}
							if (text.StartsWith(global::commonLicensing.HostIDStoreInstaller.b("솒\udc94펖꒘", a_), global::System.StringComparison.Ordinal))
							{
								num2 = (short)1687355393;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return text;
						}
						break;
					}
					case 1:
					{
						num2 = (short)1523122176;
						short num4 = num2;
						text = text.Substring(global::commonLicensing.HostIDStoreInstaller.b("솒\udc94펖꒘", a_).Length);
						num2 = (short)349437956;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						if (!string.IsNullOrEmpty(text))
						{
							num2 = (short)731119619;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return text;
					case 3:
						num2 = (short)1199636480;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_C8;
					}
					goto IL_2D;
				}
				IL_C8:
				num2 = (short)549453825;
				if (num2 != 0)
				{
				}
				return text;
			}
			IL_2D:
			text = feature.vendorString;
			IL_34:
			num2 = (short)721879042;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000059DC File Offset: 0x00003BDC
		// Note: this type is marked as 'beforefieldinit'.
		static CommonLicenseInterface()
		{
			int a_ = 19;
			short num = (short)398138106;
			short num2 = num;
			num = (short)1897732858;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1124073472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1255866369;
			if (num != 0)
			{
			}
			num = (short)316538880;
			if (num != 0)
			{
			}
			global::commonLicensing.CommonLicenseInterface.a = new global::System.Diagnostics.TraceSwitch(global::commonLicensing.HostIDStoreInstaller.b("춣얥춧쒩\udfab잭\udeaf햱쒵\ud9b7\ud9b9\ud9bb랿ꯁ냃ꗅꃇ", a_), global::commonLicensing.HostIDStoreInstaller.b("춣얥춧쒩\udfab잭\udeaf햱钳쪷\udbb9\udfbb\udbbd", a_), global::commonLicensing.HostIDStoreInstaller.b("슣삥", a_));
		}

		// Token: 0x0400001E RID: 30
		private static readonly global::System.Diagnostics.TraceSwitch a;

		// Token: 0x0400001F RID: 31
		private static string b;

		// Token: 0x04000020 RID: 32
		private static global::commonLicensing.ApplicationType c;

		// Token: 0x04000021 RID: 33
		private static global::commonLicensing.a d;
	}
}
