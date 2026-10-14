using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using AcpASKLib;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpKeyValidatorLib;
using AcpUtility;

namespace AcpSecurityLib
{
	// Token: 0x02000009 RID: 9
	public static class SecurityManager
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000017 RID: 23 RVA: 0x00003244 File Offset: 0x00001444
		// (remove) Token: 0x06000018 RID: 24 RVA: 0x00003378 File Offset: 0x00001578
		public static event global::AcpASKLib.SystemKeyLoadedEventHandler SystemKeyLoadedEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				short num;
				int num2;
				global::AcpASKLib.SystemKeyLoadedEventHandler systemKeyLoadedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)867565569;
					if (num != 0)
					{
					}
					global::AcpASKLib.SystemKeyLoadedEventHandler systemKeyLoadedEventHandler2;
					switch (num2)
					{
					case 0:
					{
						num = (short)368282434;
						short num3 = num;
						num = (short)1357220674;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_111;
						}
						break;
					}
					case 1:
						goto IL_8A;
					case 2:
						if (systemKeyLoadedEventHandler == systemKeyLoadedEventHandler2)
						{
							num = (short)1179451392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8A;
					}
					goto IL_43;
					IL_8A:
					systemKeyLoadedEventHandler2 = systemKeyLoadedEventHandler;
					global::AcpASKLib.SystemKeyLoadedEventHandler value2 = (global::AcpASKLib.SystemKeyLoadedEventHandler)global::System.Delegate.Combine(systemKeyLoadedEventHandler2, value);
					systemKeyLoadedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpASKLib.SystemKeyLoadedEventHandler>(ref global::AcpSecurityLib.SecurityManager.b, value2, systemKeyLoadedEventHandler2);
					num = (short)1240203266;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_111:
				num = (short)2058616832;
				if (num != 0)
				{
				}
				return;
				IL_43:
				num = (short)990773248;
				short num4 = num;
				systemKeyLoadedEventHandler = global::AcpSecurityLib.SecurityManager.b;
				num = (short)2075525121;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::AcpASKLib.SystemKeyLoadedEventHandler systemKeyLoadedEventHandler;
				for (;;)
				{
					IL_0A:
					global::AcpASKLib.SystemKeyLoadedEventHandler systemKeyLoadedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)730557631;
						short num3 = num2;
						num2 = (short)2136501439;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_E7;
						}
						break;
					}
					case 1:
						goto IL_61;
					case 2:
						if (systemKeyLoadedEventHandler == systemKeyLoadedEventHandler2)
						{
							num2 = (short)1515978752;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_61;
					}
					goto IL_1C;
					IL_61:
					systemKeyLoadedEventHandler2 = systemKeyLoadedEventHandler;
					global::AcpASKLib.SystemKeyLoadedEventHandler value2 = (global::AcpASKLib.SystemKeyLoadedEventHandler)global::System.Delegate.Remove(systemKeyLoadedEventHandler2, value);
					systemKeyLoadedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpASKLib.SystemKeyLoadedEventHandler>(ref global::AcpSecurityLib.SecurityManager.b, value2, systemKeyLoadedEventHandler2);
					num2 = (short)1517617154;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E7:
				num2 = (short)1128529921;
				if (num2 != 0)
				{
				}
				num2 = (short)1926365184;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				systemKeyLoadedEventHandler = global::AcpSecurityLib.SecurityManager.b;
				num2 = (short)1643905024;
				short num4 = num2;
				num2 = (short)1261961217;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000034A8 File Offset: 0x000016A8
		static SecurityManager()
		{
			int a_ = 10;
			short num = (short)1182728193;
			if (num != 0)
			{
			}
			num = (short)121831424;
			short num2 = num;
			num = (short)499817440;
			short num3 = num;
			num = (short)2099813344;
			switch (num3 == num)
			{
			}
			num = (short)323682304;
			if (num != 0)
			{
			}
			global::AcpSecurityLib.SecurityManager.a = null;
			global::AcpSecurityLib.SecurityManager.SecurityEnabled = new global::System.Diagnostics.BooleanSwitch(global::AcpSecurityLib.KeyWriteProtectEnabledConverter.b("ꖿꇁ뇃듅ꇇ뻉뗋词뻏돑뛓뫕뷗뻙", a_), global::AcpSecurityLib.KeyWriteProtectEnabledConverter.b("꺿ꛁ귃ꗅ꧇뻉꧋뷍ꗑ볓돕곗닙맛곝샟跡難웥蛧藩飫컭뇯ꇱ뿳훵请鿹鿻诽狿欁瀃缅⠇按缋⸍甏簑甓琕琗缙砛", a_), global::AcpSecurityLib.KeyWriteProtectEnabledConverter.b("\ud8bdꆿ껁럃ꏅ", a_));
			global::AcpSecurityLib.SecurityManager.c = false;
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
			global::AcpBusinessLayer.TrunkingSystemData.SystemKeyManager = (global::AcpSecurityLib.SecurityManager.a = new global::AcpASKLib.SystemKeyMgr());
			global::AcpSecurityLib.SecurityManager.a.SystemKeyLoadedEvent += global::AcpSecurityLib.SecurityManager.a;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000035C8 File Offset: 0x000017C8
		public static int LoadAllKeys(string swKeyDirectory, bool bSupressMessage)
		{
			int a_ = 18;
			short num = (short)510001152;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg> collection;
				int result;
				global::AcpKeyValidatorLib.HardwareKeyType keyTypeToLoad;
				bool bLoadSwKeys;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
						goto IL_422;
					case 1:
						if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.DEPOT)
						{
							num = (short)983049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collection.Add(new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, global::AcpSecurityLib.KeyWriteProtectEnabledConverter.b("菅뫇룉ꏋ볍黑믓럕볗동닛망샟诡ꛣ鏥鳧黩菫胭華틱\ud9f3훵귷铹迻诽烿爁欃琅簇漉栋⸍儏我搓稕焗礙紛樝䤟䴡䨣", a_), 1610645507U));
						num = (short)1522335752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpASKLib.StatusMsg> enumerator = collection.GetEnumerator();
						num = (short)913178627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						try
						{
							num = (short)1605107722;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpASKLib.StatusMsg statusMsg;
								global::AcpCommonLib.StatusMsgType type2;
								switch (num2)
								{
								case 0:
									goto IL_2DF;
								case 1:
									goto IL_345;
								case 2:
									num = (short)1431568385;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.StatusMsg> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)131006466;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									statusMsg = enumerator.Current;
									global::AcpASKLib.AskStatusType type = statusMsg.Type;
									num = (short)1163853835;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)385220614;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_2DF;
								case 6:
									type2 = global::AcpCommonLib.StatusMsgType.Error;
									num = (short)853213193;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_2DF;
								case 9:
									goto IL_2DF;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_1D4;
									}
									continue;
								case 11:
								{
									global::AcpASKLib.AskStatusType type;
									switch (type)
									{
									case global::AcpASKLib.AskStatusType.Error:
										type2 = global::AcpCommonLib.StatusMsgType.Error;
										num = (short)1481179141;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::AcpASKLib.AskStatusType.Warning:
										type2 = global::AcpCommonLib.StatusMsgType.Warning;
										num = (short)695599111;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::AcpASKLib.AskStatusType.Info:
										type2 = global::AcpCommonLib.StatusMsgType.Info;
										num = (short)1902706688;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									default:
										num = (short)220004356;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1D6:
								num = (short)160694275;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D4:
								goto IL_1D6;
								IL_2DF:
								global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(type2, statusMsg.Message);
								num = (short)469958664;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_345:
							return result;
						}
						finally
						{
							num = (short)714932225;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_401;
								case 1:
								{
									num = (short)2065156173;
									short num3 = num;
									num = (short)1905641549;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3E4;
									default:
										num = (short)1316552704;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_3C8;
										}
										continue;
									}
									break;
								}
								case 2:
									goto IL_3E4;
								}
								IL_3C8:
								global::System.Collections.Generic.IEnumerator<global::AcpASKLib.StatusMsg> enumerator;
								if (enumerator != null)
								{
									num = (short)1285488642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
								IL_3E4:
								enumerator.Dispose();
								num = (short)2070675456;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_401:;
						}
						goto IL_404;
					case 4:
						goto IL_404;
					case 5:
						goto IL_422;
					case 6:
						if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
						{
							num = (short)82706444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)433389569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!bSupressMessage)
						{
							num = (short)573571074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 8:
						goto IL_422;
					case 9:
						keyTypeToLoad = global::AcpKeyValidatorLib.HardwareKeyType.DEPOT_KEY;
						bLoadSwKeys = false;
						num = (short)467664896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)654901249;
						if (num != 0)
						{
						}
						goto IL_422;
					case 11:
					{
						if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.CPS)
						{
							num = (short)89849860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)600702976;
						short num4 = num;
						num = (short)1763377158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						keyTypeToLoad = (global::AcpKeyValidatorLib.HardwareKeyType)12;
						num = (short)1907490826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6D;
					IL_404:
					keyTypeToLoad = (global::AcpKeyValidatorLib.HardwareKeyType)12;
					num = (short)1830486021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_422:
					result = global::AcpSecurityLib.SecurityManager.a.LoadAllKeys(swKeyDirectory, keyTypeToLoad, bLoadSwKeys, collection);
					num = (short)637861895;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_6D:
				result = 0;
				collection = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg>();
				bLoadSwKeys = true;
				keyTypeToLoad = global::AcpKeyValidatorLib.HardwareKeyType.ADVANCED_SYSTEM_KEY;
				num = (short)1855651851;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003B08 File Offset: 0x00001D08
		public static int LoadAllAttachedKeys(bool bSupressMessage)
		{
			int a_ = 14;
			short num = (short)2092761088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1414332417;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				int result;
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg> collection;
				for (;;)
				{
					IL_57:
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.StatusMsg> enumerator;
					switch (num2)
					{
					case 0:
						if (!bSupressMessage)
						{
							num = (short)71565314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						try
						{
							num = (short)151257090;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_545;
								case 1:
									result = global::AcpSecurityLib.SecurityManager.a.LoadHardwareKeys((global::AcpKeyValidatorLib.HardwareKeyType)12, collection);
									num = (short)935919624;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3CD;
									}
									continue;
								case 3:
									if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
									{
										num = (short)1199439881;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1512964106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									result = global::AcpSecurityLib.SecurityManager.a.LoadHardwareKeys(global::AcpKeyValidatorLib.HardwareKeyType.DEPOT_KEY, collection);
									num = (short)214958085;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_52D;
								case 6:
									goto IL_52D;
								case 7:
									goto IL_52D;
								case 8:
									goto IL_52D;
								case 9:
									result = global::AcpSecurityLib.SecurityManager.a.LoadHardwareKeys((global::AcpKeyValidatorLib.HardwareKeyType)12, collection);
									num = (short)1137246215;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.DEPOT)
									{
										num = (short)2034499588;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									collection.Add(new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, global::AcpSecurityLib.KeyWriteProtectEnabledConverter.b("蟁뛃듅Ꟈ룉苍뿏돑냓뿕뛗뷙ﳛ럝ꋟ韡郣鋥蟧蓩鿫컭\uddef틱ꇳ飵请迹賻軽濿瀁瀃挅氇⨉䴋縍怏縑紓甕礗渙甛焝丟", a_), 1610645507U));
									num = (short)779550726;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3CD:
								if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.CPS)
								{
									num = (short)357236737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1565065219;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_52D:
								num = (short)747438080;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_545:
							goto IL_316;
						}
						catch (global::System.AccessViolationException ex)
						{
							throw ex;
						}
						goto IL_54B;
					case 2:
						goto IL_54B;
					case 3:
						try
						{
							num = (short)803799043;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpASKLib.StatusMsg statusMsg;
								global::AcpCommonLib.StatusMsgType type2;
								switch (num2)
								{
								case 0:
									goto IL_15D;
								case 1:
									goto IL_2A5;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2109931529;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									statusMsg = enumerator.Current;
									global::AcpASKLib.AskStatusType type = statusMsg.Type;
									num = (short)432996362;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_E8;
									}
									continue;
								case 5:
									goto IL_15D;
								case 6:
									goto IL_15D;
								case 7:
									goto IL_15D;
								case 8:
									type2 = global::AcpCommonLib.StatusMsgType.Error;
									num = (short)1163067398;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)1540685825;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::AcpASKLib.AskStatusType type;
									switch (type)
									{
									case global::AcpASKLib.AskStatusType.Error:
										type2 = global::AcpCommonLib.StatusMsgType.Error;
										num = (short)860880901;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::AcpASKLib.AskStatusType.Warning:
									{
										num = (short)200214757;
										short num3 = num;
										num = (short)634390757;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)1117388800;
											if (num != 0)
											{
											}
											type2 = global::AcpCommonLib.StatusMsgType.Warning;
											num = (short)424738823;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case global::AcpASKLib.AskStatusType.Info:
										type2 = global::AcpCommonLib.StatusMsgType.Info;
										break;
									default:
										num = (short)38928395;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)457637888;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)1370292232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_EA:
								num = (short)1996816386;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E8:
								goto IL_EA;
								IL_15D:
								global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(type2, statusMsg.Message);
								num = (short)2144862212;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2A5:
							return result;
						}
						finally
						{
							num = (short)1844969472;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2DD;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1561198594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_313;
								}
								IL_2DD:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1284374529;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_313:;
						}
						goto IL_316;
					}
					goto IL_6E;
					IL_316:
					num = (short)1475280896;
					short num4 = num;
					num = (short)2084438016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54B:
					enumerator = collection.GetEnumerator();
					num = (short)1779826691;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_6E:
				result = 0;
				collection = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg>();
				num = (short)1882521601;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_57;
			}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000040BC File Offset: 0x000022BC
		public static int LoadSelectedSwKeyFiles(string[] selectedFileNames, bool bSupressMessage)
		{
			short num = (short)2055733248;
			short num2 = num;
			num = (short)2104164352;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				int result;
				for (;;)
				{
					IL_53:
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.StatusMsg> enumerator;
					switch (num3)
					{
					case 0:
						if (!bSupressMessage)
						{
							num = (short)1607860225;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						goto IL_36E;
					case 2:
						try
						{
							num = (short)642121731;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpASKLib.StatusMsg statusMsg;
								global::AcpCommonLib.StatusMsgType type2;
								switch (num3)
								{
								case 0:
									num = (short)2043412490;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2FF;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_180;
									}
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)886636550;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									statusMsg = enumerator.Current;
									global::AcpASKLib.AskStatusType type = statusMsg.Type;
									num = (short)2121662473;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_185;
								case 6:
									num = (short)1621491713;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_185;
								case 8:
									goto IL_185;
								case 9:
								{
									global::AcpASKLib.AskStatusType type;
									switch (type)
									{
									case global::AcpASKLib.AskStatusType.Error:
										type2 = global::AcpCommonLib.StatusMsgType.Error;
										num = (short)846135303;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case global::AcpASKLib.AskStatusType.Warning:
										type2 = global::AcpCommonLib.StatusMsgType.Warning;
										num = (short)436338693;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case global::AcpASKLib.AskStatusType.Info:
										type2 = global::AcpCommonLib.StatusMsgType.Info;
										num = (short)1715798027;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									default:
										num = (short)758775808;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									type2 = global::AcpCommonLib.StatusMsgType.Error;
									num = (short)1137901576;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_185;
								}
								goto IL_180;
								IL_185:
								global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(type2, statusMsg.Message);
								num = (short)1509490690;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_228:
								num = (short)1392771076;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_180:
								goto IL_228;
							}
							IL_2FF:
							return result;
						}
						finally
						{
							num = (short)926285824;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_336;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)978124802;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_36B;
								}
								IL_336:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1243807745;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_36B:;
						}
						goto IL_36E;
					}
					break;
					IL_36E:
					global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg> collection;
					enumerator = collection.GetEnumerator();
					num = (short)711589890;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_66:
				num = (short)1002512012;
				short num4 = num;
				num = (short)1116872332;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
				{
					num = (short)415170561;
					if (num != 0)
					{
					}
					num = (short)1225129984;
					if (num != 0)
					{
					}
					result = 0;
					global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg> collection = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg>();
					result = global::AcpSecurityLib.SecurityManager.a.LoadSelectedSwKeyFiles(selectedFileNames, collection);
					num = (short)2091122688;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_53;
				}
				}
				break;
			}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004478 File Offset: 0x00002678
		private static void a(object A_0, global::AcpASKLib.SystemKeyLoadedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (global::AcpSecurityLib.SecurityManager.b != null)
					{
						num2 = (short)897908737;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D7;
				case 1:
				{
					num2 = (short)781254657;
					if (num2 != 0)
					{
					}
					num2 = (short)407830528;
					short num3 = num2;
					global::AcpSecurityLib.SecurityManager.b(A_0, A_1);
					num2 = (short)137035778;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_D7;
				}
				goto IL_1C;
				IL_D7:
				num2 = (short)1547973057;
				short num4 = num2;
				num2 = (short)97202625;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_10C;
				}
			}
			IL_10C:
			num2 = (short)397344768;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			global::AcpSecurityLib.SecurityManager.c = global::AcpSecurityLib.SecurityManager.a.IsSpecialKeyLoaded();
			num2 = (short)38338560;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000045A8 File Offset: 0x000027A8
		public static bool IsSystemKeyLoaded(int dwSystemId, byte uKeyType, bool bAskOnly)
		{
			short num = (short)118560854;
			short num2 = num;
			num = (short)1842813014;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1885995008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2145386497;
			if (num != 0)
			{
			}
			num = (short)280821760;
			if (num != 0)
			{
			}
			return global::AcpSecurityLib.SecurityManager.a.IsSystemKeyLoaded(dwSystemId, uKeyType, bAskOnly);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004660 File Offset: 0x00002860
		public static bool IsASKAttachedForGivenSysIdAndType(int dwSystemId, byte uKeyType)
		{
			short num = (short)1198287268;
			short num2 = num;
			num = (short)140077476;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1686568960;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1083899904;
			if (num != 0)
			{
			}
			num = (short)1250099201;
			if (num != 0)
			{
			}
			return global::AcpSecurityLib.SecurityManager.a.IsASKAttachedForGivenSysIdAndType(dwSystemId, uKeyType);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004718 File Offset: 0x00002918
		public static global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> GetSysKeysFromAttachedASKs()
		{
			short num = (short)301153692;
			short num2 = num;
			num = (short)1048853916;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1015939072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1511849985;
			if (num != 0)
			{
			}
			num = (short)1323499520;
			if (num != 0)
			{
			}
			return global::AcpSecurityLib.SecurityManager.a.GetSysKeysFromAttachedASKs(true);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000047CC File Offset: 0x000029CC
		public static global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> GetSysKeysFromLoadedAndAttachedASKs()
		{
			short num = (short)753270784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> collection;
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> sysKeysFromAttachedASKs;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator2;
					switch (num2)
					{
					case 0:
						num = (short)1695088641;
						if (num != 0)
						{
						}
						num = (short)391118852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							num = (short)215220226;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)1637679107;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::AcpASKLib.SystemKeyData systemKeyData2;
											switch (num2)
											{
											case 0:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1248067592;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpASKLib.SystemKeyData systemKeyData = enumerator.Current;
												num = (short)1643511818;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												goto IL_2E5;
											case 2:
											{
												global::AcpASKLib.SystemKeyData systemKeyData;
												if (systemKeyData2.SystemID == systemKeyData.SystemID)
												{
													num = (short)104202249;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
												switch (0)
												{
												case 0:
													goto IL_17D;
												}
												continue;
											case 5:
												collection = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData>();
												num = (short)1044381703;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												if (collection == null)
												{
													num = (short)1500577797;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_1FC;
											case 7:
												goto IL_1FC;
											case 8:
												num = (short)1004535809;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
												num = (short)1061421062;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 10:
											{
												global::AcpASKLib.SystemKeyData systemKeyData;
												if (systemKeyData2.iBtnSerialNum == systemKeyData.iBtnSerialNum)
												{
													num = (short)914751499;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 11:
												num = (short)110166018;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_1BC:
											num = (short)710279168;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_17D:
											goto IL_1BC;
											IL_1FC:
											collection.Add(systemKeyData2);
											num = (short)1908801540;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2E5:
										break;
									}
									finally
									{
										num = (short)651231232;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_31D;
												}
												continue;
											case 1:
												enumerator.Dispose();
												num = (short)441057282;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_355;
											}
											IL_31D:
											if (enumerator == null)
											{
												break;
											}
											num = (short)133955585;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_355:;
									}
									goto IL_358;
								case 1:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1193476100;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpASKLib.SystemKeyData systemKeyData2 = enumerator2.Current;
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator = global::AcpSecurityLib.SecurityManager.LoadedASKs.GetEnumerator();
									num = (short)1122566144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_C2;
									}
									continue;
								case 3:
									goto IL_370;
								case 4:
									goto IL_358;
								}
								IL_F0:
								num = (short)2091778049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C2:
								goto IL_F0;
								IL_358:
								num = (short)1610416131;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_370:
							return collection;
						}
						finally
						{
							num = (short)888995841;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_42A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3A7;
									}
									continue;
								case 2:
									enumerator2.Dispose();
									goto IL_412;
								}
								IL_3A7:
								num = (short)236888642;
								short num3 = num;
								num = (short)496542274;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_412:
									num = (short)1883635712;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)1173159936;
									if (num != 0)
									{
									}
									if (enumerator2 == null)
									{
										goto IL_42C;
									}
									num = (short)844431362;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_42A:
							IL_42C:;
						}
						goto IL_42D;
					case 2:
						if (sysKeysFromAttachedASKs != null)
						{
							num = (short)483917824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 3:
					{
						num = (short)611975168;
						short num4 = num;
						goto IL_42D;
					}
					case 4:
						if (global::AcpSecurityLib.SecurityManager.LoadedASKs != null)
						{
							num = (short)1766719491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					}
					goto IL_44;
					IL_42D:
					enumerator2 = sysKeysFromAttachedASKs.GetEnumerator();
					num = (short)1810563073;
					num2 = (int)((global::System.IntPtr)num);
				}
				return collection;
				IL_44:
				collection = null;
				sysKeysFromAttachedASKs = global::AcpSecurityLib.SecurityManager.a.GetSysKeysFromAttachedASKs(false);
				num = (short)2134966274;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00004CF0 File Offset: 0x00002EF0
		public static global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> LoadedUserSystemKeys
		{
			get
			{
				short num = (short)713377010;
				short num2 = num;
				num = (short)718292210;
				switch (num2 == num)
				{
				}
				num = (short)1290600448;
				if (num != 0)
				{
				}
				num = (short)905576449;
				if (num != 0)
				{
				}
				num = (short)372047872;
				short num3 = num;
				return global::AcpSecurityLib.SecurityManager.a.LoadedUserSystemKeys;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00004DA8 File Offset: 0x00002FA8
		public static global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> LoadedASKs
		{
			get
			{
				short num = (short)807309969;
				short num2 = num;
				num = (short)81695377;
				switch (num2 == num)
				{
				}
				num = (short)1199374337;
				if (num != 0)
				{
				}
				num = (short)9961472;
				if (num != 0)
				{
				}
				num = (short)682557440;
				short num3 = num;
				return global::AcpSecurityLib.SecurityManager.a.LoadedASKs;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00004E5C File Offset: 0x0000305C
		public static global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SpecialKeyData> LoadedSpecialKeys
		{
			get
			{
				short num = (short)1004863489;
				if (num != 0)
				{
				}
				num = (short)573035834;
				short num2 = num;
				num = (short)1390925114;
				switch (num2 == num)
				{
				}
				num = (short)2094465024;
				if (num != 0)
				{
				}
				num = (short)691208192;
				short num3 = num;
				return global::AcpSecurityLib.SecurityManager.a.LoadedSpecialKeys;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004F10 File Offset: 0x00003110
		public static bool IsFieldEditable(global::AcpASKLib.AccessElementIDType id, global::AcpASKLib.KeyType type, int sysId, bool bAskOnly)
		{
			short num = (short)1779258525;
			short num2 = num;
			num = (short)2060014749;
			switch (num2 == num)
			{
			}
			num = (short)83951617;
			if (num != 0)
			{
			}
			num = (short)863240192;
			if (num != 0)
			{
			}
			num = (short)394461184;
			short num3 = num;
			return global::AcpSecurityLib.SecurityManager.a.IsFieldEditable(id, type, sysId, bAskOnly);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004FC4 File Offset: 0x000031C4
		public static bool IsRangeValueValid(global::AcpASKLib.AccessElementIDType id, global::AcpASKLib.KeyType type, int sysId, int value, bool bAskOnly)
		{
			short num = (short)320982191;
			short num2 = num;
			num = (short)1332464815;
			switch (num2 == num)
			{
			}
			num = (short)835584000;
			if (num != 0)
			{
			}
			num = (short)1179975681;
			if (num != 0)
			{
			}
			num = (short)1829568512;
			short num3 = num;
			return global::AcpSecurityLib.SecurityManager.a.IsRangeValueValid(id, type, sysId, value, bAskOnly);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000507C File Offset: 0x0000327C
		public static bool IsRangeField(global::AcpASKLib.AccessElementIDType id)
		{
			short num = (short)265541135;
			short num2 = num;
			num = (short)366794255;
			switch (num2 == num)
			{
			}
			num = (short)2752513;
			if (num != 0)
			{
			}
			num = (short)999227392;
			if (num != 0)
			{
			}
			num = (short)1922826240;
			short num3 = num;
			return global::AcpSecurityLib.SecurityManager.a.IsRangeField(id);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005130 File Offset: 0x00003330
		public static bool IsUnLimitedASKLoaded(int sysId, global::AcpASKLib.KeyType type, bool bSearchWriteProtectOnly)
		{
			short num = (short)1347903210;
			short num2 = num;
			num = (short)1937661674;
			switch (num2 == num)
			{
			}
			num = (short)1146224640;
			if (num != 0)
			{
			}
			num = (short)172556289;
			if (num != 0)
			{
			}
			num = (short)832307200;
			short num3 = num;
			return global::AcpSecurityLib.SecurityManager.a.IsUnLimitedASKLoaded(sysId, (byte)type, bSearchWriteProtectOnly);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000051E8 File Offset: 0x000033E8
		public static global::AcpASKLib.AccessRecord GetSystemAccessLevel(int sysId, global::AcpASKLib.KeyType uKeyTpe)
		{
			short num = (short)309657601;
			if (num != 0)
			{
			}
			num = (short)1906955178;
			short num2 = num;
			num = (short)1741018026;
			switch (num2 == num)
			{
			}
			num = (short)932970496;
			if (num != 0)
			{
			}
			num = (short)596049920;
			short num3 = num;
			return global::AcpSecurityLib.SecurityManager.a.GetSystemAccessLevel(sysId, uKeyTpe);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000052A0 File Offset: 0x000034A0
		public static bool IsSpecialKeyLoaded
		{
			get
			{
				short num = (short)1131245873;
				short num2 = num;
				num = (short)1278439729;
				switch (num2 == num)
				{
				}
				num = (short)722075648;
				if (num != 0)
				{
				}
				num = (short)1716846593;
				if (num != 0)
				{
				}
				num = (short)2096496640;
				short num3 = num;
				return global::AcpSecurityLib.SecurityManager.c;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005350 File Offset: 0x00003550
		public static bool CheckIfSpecialKeyIsAttached()
		{
			short num = (short)613482496;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_5F;
			}
			int num3;
			bool result;
			for (;;)
			{
				IL_35:
				switch (num3)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.DEPOT)
					{
						num = (short)1561985025;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					result = global::AcpSecurityLib.SecurityManager.a.CheckIfSpecialKeyIsAttached(global::AcpKeyValidatorLib.HardwareKeyType.DEPOT_KEY);
					num = (short)648937474;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return result;
				case 3:
					num = (short)473890817;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.CPS)
					{
						num = (short)1330118663;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)877395972;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
					{
						num = (short)1754398726;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)441253888;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return result;
				case 6:
				{
					num = (short)726762621;
					short num4 = num;
					num = (short)52593789;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num = (short)294977536;
						if (num != 0)
						{
						}
						result = global::AcpSecurityLib.SecurityManager.a.CheckIfSpecialKeyIsAttached(global::AcpKeyValidatorLib.HardwareKeyType.FTR_KEY);
						num = (short)392626181;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					result = global::AcpSecurityLib.SecurityManager.a.CheckIfSpecialKeyIsAttached(global::AcpKeyValidatorLib.HardwareKeyType.FTR_KEY);
					num = (short)832372744;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					return result;
				}
				goto IL_5F;
			}
			return result;
			IL_5F:
			result = false;
			num = (short)1171718147;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_35;
		}

		// Token: 0x04000003 RID: 3
		internal static global::AcpASKLib.SystemKeyMgr a;

		// Token: 0x04000004 RID: 4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpASKLib.SystemKeyLoadedEventHandler b;

		// Token: 0x04000005 RID: 5
		public static global::System.Diagnostics.BooleanSwitch SecurityEnabled;

		// Token: 0x04000006 RID: 6
		private static bool c;
	}
}
