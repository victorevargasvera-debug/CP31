using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.Security.SamlCommonUtility.DMHttpClients;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000019 RID: 25
	public class DMServiceAccessor : global::Motorola.CommonCPS.RadioManagement.SharedServices.IDMServiceAccessor
	{
		// Token: 0x0600012E RID: 302 RVA: 0x0000A1D0 File Offset: 0x000083D0
		public DMServiceAccessor()
		{
			this.a = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.CustomCertificateValidator.ValidatorCertificate();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000A214 File Offset: 0x00008414
		public global::Motorola.Security.SamlCommonUtility.DMHttpClients.OAuthApplicationInfo GetOAuthApplicationInfo(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMIdPDiscoveryClient dmIdpDiscoverySvcClient)
		{
			int a_ = 6;
			for (;;)
			{
				IL_09:
				short num = (short)1651638272;
				switch (num)
				{
				default:
				{
					num = (short)351404035;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1B6;
						case 1:
							try
							{
								num = (short)1470693377;
								if (num != 0)
								{
								}
								string requestUri = string.Format(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햠펢횤鶦蚨蒪횬龮첰鲲캴蚶쒸", a_), global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾜튞슢톤슦\udea8쪪풬햰ힲ잴튶쪸좺", a_)].TrimEnd(new char[]
								{
									'/'
								}), global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud99c튞잢햤삨\ud8aa캬삮잰횲잴캶\udeba쾼즾ꣀꃂꃄ韆꣈뿊ꗌ", a_)].Trim(new char[]
								{
									'/'
								}));
								return dmIdpDiscoverySvcClient.GetApplicationInfo(requestUri);
							}
							catch (global::System.Exception ex)
							{
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨좬\udbaeﺰ살쎶톸諸춼쾾귀ꫂꛄꛆ뷈ꋊꋌꇎ飐뷒돔룖", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.a);
							}
							goto IL_1B6;
						case 2:
						{
							global::Motorola.Common.CustomException.CommonException ex2 = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull, global::Motorola.CommonCPS.ResourceRepository.Resources.ArgumentNull);
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨좬\udbaeﺰ살쎶톸諸춼쾾귀ꫂꛄꛆ뷈ꋊꋌꇎ飐뷒돔룖", a_), ex2, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex2);
							num = (short)614531072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_5D;
							}
							continue;
						}
						IL_5D:
						if (dmIdpDiscoverySvcClient == null)
						{
							num = (short)1835789106;
							short num3 = num;
							num = (short)161213234;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							case 1:
								break;
							default:
							{
								num = (short)589430784;
								short num4 = num;
								break;
							}
							}
							num = (short)794230784;
							if (num != 0)
							{
							}
							num = (short)531824642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1B6:
						num = (short)664403969;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			global::Motorola.Security.SamlCommonUtility.DMHttpClients.OAuthApplicationInfo result;
			return result;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000A448 File Offset: 0x00008648
		public global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyId> GetAgencyIdsForUser(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMAuthorizationServiceClient dmAuthSvcClient, string username)
		{
			int a_ = 13;
			short num = (short)1923940352;
			switch (num)
			{
			default:
			{
				num = (short)993067010;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)220044783;
						short num3 = num;
						num = (short)574201327;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_177;
						default:
							num = (short)1346437120;
							if (num != 0)
							{
							}
							goto IL_21D;
						}
						break;
					}
					case 1:
						if (string.IsNullOrEmpty(username))
						{
							num = (short)1117454336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_66;
						}
						continue;
					case 3:
						try
						{
							num = (short)237633537;
							if (num != 0)
							{
							}
							string requestUri = string.Format(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첣튥\udca7\udaa9\udfab钭龯鶱쾳蚵얷閹잻辽붿뿃뗇", a_), global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쮩\ud8ab쮭잯펱춳\udcb7\udeb9캻\udbbd뎿뇁", a_)].TrimEnd(new char[]
							{
								'/'
							}), global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udfa9\ud8ab욭\udfaf삱\uddb3첵\ud9b7캹햻톽꺿釁ꇃ듅뻇ꏉ꿋ꯍ胏돑ꃓ뻕", a_)].Trim(new char[]
							{
								'/'
							}), username);
							return dmAuthSvcClient.GetAgencyIds(requestUri);
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯톳습醴\uddb9\ud9bb킽ꎿ믁跃ꋅ믇賉ꏋ볍藏ꇑ뇓ꓕ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.a);
						}
						goto IL_176;
					case 4:
						goto IL_176;
					case 5:
					{
						num = (short)1574109184;
						short num4 = num;
						num = (short)546177025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_66:
					if (dmAuthSvcClient != null)
					{
						num = (short)556007429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21D;
					IL_177:
					num = (short)1675558915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_176:
					goto IL_177;
					IL_21D:
					global::Motorola.Common.CustomException.CommonException ex2 = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull, global::Motorola.CommonCPS.ResourceRepository.Resources.ArgumentNull);
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯톳습醴\uddb9\ud9bb킽ꎿ믁跃ꋅ믇賉ꏋ볍藏ꇑ뇓ꓕ", a_), ex2, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex2);
					num = (short)1691680772;
					num2 = (int)((global::System.IntPtr)num);
				}
				global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyId> result;
				return result;
			}
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000A6C8 File Offset: 0x000088C8
		public global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo> GetAgencyInfoById(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMAgencyAdminServiceClient dmAgencyAdminSvcClient, global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyId> agencyIds, out bool lookupErrorFound)
		{
			int a_ = 7;
			short num = (short)197197824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_51;
				}
				global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo> list;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
					{
						num = (short)76021760;
						short num3 = num;
						goto IL_36D;
					}
					case 1:
						if (agencyIds == null)
						{
							num = (short)881000448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CA;
					case 2:
						if (dmAgencyAdminSvcClient != null)
						{
							num = (short)1658781701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36D;
					case 3:
						goto IL_8C;
						try
						{
							for (;;)
							{
								IL_8C:
								lookupErrorFound = false;
								using (global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyId>.Enumerator enumerator = agencyIds.GetEnumerator())
								{
									num = (short)195362818;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 1:
											goto IL_223;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_D7;
											}
											continue;
										case 3:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)1897922561;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyId agencyId = enumerator.Current;
											global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo item = null;
											num = (short)2130051077;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 4:
											goto IL_23B;
										case 5:
										{
											global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo item;
											try
											{
												global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyId agencyId;
												string requestUri = string.Format(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풟횡풣향銧薩莫햭肯쾱鮳춵覷잹鎻얽뿁", a_), global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첝얣튥춧\udda9춫힭횱킳쒵\uddb7즹쾻", a_)].TrimEnd(new char[]
												{
													'/'
												}), global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda9d쎣쎥욧즩햫풯\udfb1\uddb3\ud8b5\udfb9캻좽ꦿꇁꇃ雅꧇뻉꓋", a_)].Trim(new char[]
												{
													'/'
												}), agencyId.provAgencyId);
												item = dmAgencyAdminSvcClient.GetAgencyInfo(requestUri);
												goto IL_13B;
											}
											catch (global::System.Exception exp)
											{
												lookupErrorFound = true;
												global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyId agencyId;
												global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(string.Format(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udb9d튟킡쮣풥袧첩얫삭풯\udbb1\udab3통颷캹풻\udbbd곁ꗃꯅ귇ꏋ꣍鏑돓돕뛗맙ꗛﻝ鯟틡駣", a_), agencyId.provAgencyId), exp, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Warning);
												item = new global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo
												{
													provAgencyId = agencyId.provAgencyId,
													provAgencyName = agencyId.provAgencyId
												};
												goto IL_13B;
											}
											goto IL_223;
											IL_13B:
											list.Add(item);
											num = (short)1170472960;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_FF:
										num = (short)1738735619;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_D7:
										goto IL_FF;
										IL_223:
										num = (short)2007105540;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_23B:;
								}
								num = (short)120358026;
								short num4 = num;
								num = (short)754025610;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_280;
								}
							}
							IL_280:
							num = (short)386531328;
							if (num != 0)
							{
							}
							return list;
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭쒯펳펵횷\ud9b9얻꺿꓁ꯃ蓅뇇菉꣋", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.a);
						}
						goto IL_2CA;
					case 4:
						goto IL_2CA;
					case 5:
						num = (short)1628897281;
						if (num != 0)
						{
						}
						num = (short)910163969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_51;
					IL_2CA:
					num = (short)1904934915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36D:
					global::Motorola.Common.CustomException.CommonException ex2 = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull, global::Motorola.CommonCPS.ResourceRepository.Resources.ArgumentNull);
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭쒯펳펵횷\ud9b9얻꺿꓁ꯃ蓅뇇菉꣋", a_), ex2, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex2);
					num = (short)70254596;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_51:
				list = new global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo>();
				num = (short)930349058;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		public bool UploadMotorolaCodeplug(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMStorageServiceClient dmStorageServiceClient, string codeplugFilePath)
		{
			int a_ = 0;
			short num = (short)1803419648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)268234153;
				short num3 = num;
				num = (short)310898089;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_B2:
					switch (0)
					{
					case 0:
						goto IL_EF;
					}
					break;
				default:
				{
					num = (short)2069364736;
					short num4 = num;
					num = (short)1870987264;
					if (num != 0)
					{
					}
					num = (short)1418461188;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					IL_BC:
					switch (num2)
					{
					case 0:
						goto IL_321;
					case 1:
					{
						string preferredUsernameFromToken;
						if (string.IsNullOrEmpty(preferredUsernameFromToken))
						{
							num = (short)1545469957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2136277000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						string fileName;
						if (string.IsNullOrEmpty(fileName))
						{
							num = (short)1012727808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string preferredUsernameFromToken = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.PreferredUsernameFromToken;
						num = (short)60817409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)1740505089;
						if (num != 0)
						{
						}
						if (codeplugFilePath == "")
						{
							num = (short)1362886663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string fileName = global::System.IO.Path.GetFileName(codeplugFilePath);
						num = (short)1972568066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_B2;
					case 5:
						goto IL_286;
					case 6:
						goto IL_10A;
					case 7:
						goto IL_38E;
					case 8:
						goto IL_2DA;
					case 9:
						goto IL_243;
					case 10:
						if (codeplugFilePath == null)
						{
							num = (short)929431561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)374210563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EF;
				}
				IL_10A:
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("좚펠슢스슦直캪\udfac\ud9ae\ud8b0킲킴햸튺\ud8bc톾뗀", a_));
				IL_243:
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﾚ춠횢스삨잪좬ﾮ킰잲\uddb4", a_));
				IL_286:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("漢膠쪢횤螦잨\udeaa솬쎮醰\udcb2잴鞶\udcb8횺춼쮾룀", a_));
				IL_2DA:
				try
				{
					string preferredUsernameFromToken;
					string fileName;
					return dmStorageServiceClient.UploadCodeplug(new global::System.UriBuilder
					{
						Scheme = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﾖ", a_),
						Host = global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("얖풘\udc9aﲜ쒠풢쒤\udea6쾪즬\uddae풰삲운", a_)],
						Path = string.Concat(new string[]
						{
							global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펖풘좚펠슢스슦", a_)],
							global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("뢖", a_),
							preferredUsernameFromToken,
							global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("뢖", a_),
							fileName
						})
					}.Uri, codeplugFilePath);
				}
				catch (global::System.Exception exp)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튖햠쪢쪤즦覨캪쎬첮\udeb0욲\udbb4쎶\udcb8즺\ud8bc\udbbe듂귄껆ꗈ껊뫎ꇐ뿒뫔뛖뷘닚돜룞쇠胢諤菦賨鯪臬髮雰폲致飶\ud9f8裺觼郾猀戂戄戆⤈砊栌紎朐稒瘔爖", a_), exp, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
					return false;
				}
				goto IL_20B;
				IL_321:
				throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﾚ춠횢스螦쾨슪솬쪮醰쎲풴쎶톸鮺킼쪾닀럂ꋆꟈ꿊룎룐꟒뷔룘ﯚ믜뛞跠蛢엤触裨蛪裬", a_));
				IL_38E:
				throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﾚ춠횢스螦쾨슪솬쪮醰쎲풴쎶톸鮺\udebc\udebe꿀귂꫄돆꧊꣌듐뻒ꗔꏖꃘ", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﾚ춠횢스삨잪좬ﾮ킰잲\uddb4", a_));
				IL_EF:
				if (dmStorageServiceClient == null)
				{
					num = (short)496959494;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_BC;
				}
				IL_20B:
				num = (short)517996554;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_BC;
			}
			}
		}

		// Token: 0x0400001D RID: 29
		private string a = string.Empty;
	}
}
