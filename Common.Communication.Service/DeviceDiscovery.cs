using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using IACustomException;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager;
using Motorola.Common.CustomException;
using SSLMangrComp;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000044 RID: 68
	[global::System.ServiceModel.ServiceBehavior(ConcurrencyMode = global::System.ServiceModel.ConcurrencyMode.Multiple, InstanceContextMode = global::System.ServiceModel.InstanceContextMode.PerSession)]
	public class DeviceDiscovery : global::Motorola.Common.Communication.Service.IDeviceDiscovery, global::System.IDisposable
	{
		// Token: 0x0600025F RID: 607 RVA: 0x00015A98 File Offset: 0x00013C98
		public DeviceDiscovery(global::Motorola.Common.Communication.CommonUtil.ProductFamily deviceFamilySet, global::Motorola.Common.Communication.CommonUtil.WorkMode workMode, global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent discoveryServiceEventCallback, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommonUtil.TraceLogger traceLogger)
		{
			int a_ = 1;
			this.a = new global::SSLMangrComp.ConnectionManagerWatcher();
			this.e = new object();
			base..ctor();
			this.f = communicationManager;
			this.g = traceLogger;
			if (discoveryServiceEventCallback != null)
			{
				global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager2 = this.f;
				communicationManager2.DeviceConnectedEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Combine(communicationManager2.DeviceConnectedEventHandler, new global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>(this.b));
				global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager3 = this.f;
				communicationManager3.DeviceLostEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Combine(communicationManager3.DeviceLostEventHandler, new global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>(this.a));
				this.b = discoveryServiceEventCallback;
			}
			this.g.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("춂ꦈ쾊年랖\udd98ﲞ캠햢삤햦킨讪ﺬ쪮쎰얲\udcb4풶\udcb8鮺ﺼ춾꓀ꋂ뇄ꋆ귈", a_), global::System.Array.Empty<object>());
			this.c = deviceFamilySet;
			this.d = workMode;
			if (deviceFamilySet > global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
			{
				this.f.Start(deviceFamilySet, workMode);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00015B80 File Offset: 0x00013D80
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> ListConnectedDevices(int deviceConnectionType)
		{
			short num = (short)931361471;
			short num2 = num;
			num = (short)332886719;
			switch (num2 == num)
			{
			}
			num = (short)663486464;
			short num3 = num;
			num = (short)11599873;
			if (num != 0)
			{
			}
			num = (short)767623168;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> a_ = this.f.ListConnectedDevices(this.c, deviceConnectionType);
			return this.a(a_);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00015C44 File Offset: 0x00013E44
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> CheckForDevice(int deviceConnectionType, string identifier)
		{
			short num = (short)1247837796;
			short num2 = num;
			num = (short)823492196;
			switch (num2 == num)
			{
			}
			num = (short)1947926528;
			short num3 = num;
			num = (short)1812070401;
			if (num != 0)
			{
			}
			num = (short)436666368;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> a_ = this.f.CheckForDevice(this.c, deviceConnectionType, identifier);
			return this.a(a_);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00015D08 File Offset: 0x00013F08
		private void a(global::SSLMangrComp.PresenceNotification A_0)
		{
			int a_ = 4;
			short num;
			try
			{
				num = (short)1594097664;
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
					global::SSLMangrComp.PresenceState presenceState;
					for (;;)
					{
						IL_32:
						object obj;
						bool flag;
						switch (num2)
						{
						case 0:
							goto IL_389;
						case 1:
							goto IL_349;
						case 2:
							if (presenceState == global::SSLMangrComp.PresenceState.Absent)
							{
								num = (short)1090912257;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_370;
						case 3:
							if (presenceState != global::SSLMangrComp.PresenceState.Present)
							{
								num = (short)1468727300;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_349;
						case 4:
							num = (short)2094268418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_165;
								}
								for (;;)
								{
									IL_142:
									global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args;
									switch (num2)
									{
									case 0:
										if (presenceState == global::SSLMangrComp.PresenceState.Present)
										{
											num = (short)1058668550;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										this.b.OnDeviceLost(args);
										num = (short)395902979;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1D1;
									case 2:
									{
										num = (short)595293511;
										short num3 = num;
										num = (short)2124510535;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1D1;
										default:
											goto IL_2C1;
										}
										break;
									}
									case 3:
										goto IL_273;
									case 4:
										if (this.b != null)
										{
											num = (short)631046145;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_273;
									case 5:
										goto IL_273;
									case 6:
										this.b.OnDeviceConnected(args);
										num = (short)1186463749;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_165;
									IL_1D1:
									args = new global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs(new global::Motorola.Common.Communication.CommonUtil.DeviceInfo
									{
										ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo(),
										ConnectionInfo = 
										{
											ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap,
											UniqueAddress = A_0.IPAddr
										},
										RadioID = A_0.DeviceId
									});
									num = (short)1371406336;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_273:
									num = (short)1495728130;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2C1:
								num = (short)1156382720;
								if (num != 0)
								{
								}
								goto IL_370;
								IL_165:
								global::System.Threading.Monitor.Enter(obj, ref flag);
								num = (short)246546436;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_142;
							}
							finally
							{
								num = (short)1390280705;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										global::System.Threading.Monitor.Exit(obj);
										num = (short)2025390082;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_30F;
										}
										continue;
									case 2:
										goto IL_346;
									}
									IL_30F:
									if (!flag)
									{
										break;
									}
									num = (short)189071360;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_346:;
							}
							goto IL_349;
						}
						goto IL_51;
						IL_349:
						obj = this.e;
						flag = false;
						num = (short)393412613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_370:
						num = (short)896794624;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_389:
					break;
					IL_51:
					string deviceId = A_0.DeviceId;
					string subscriptionState = A_0.SubscriptionState;
					presenceState = A_0.PresenceState;
					global::System.Console.WriteLine(string.Concat(new string[]
					{
						global::Motorola.Common.Communication.Service.DeviceServiceManager.b("ﺉ憐뺝튟잡잣쎥솧\udca9즫쪭誯銱펵캷펹\udfbb\udbbd謹", a_),
						deviceId,
						global::Motorola.Common.Communication.Service.DeviceServiceManager.b("ꚅﮇﾉﶍﶓ骟芡", a_),
						subscriptionState,
						global::Motorola.Common.Communication.Service.DeviceServiceManager.b("ꚅ\ud887ﶍﲑꊗ몙", a_),
						presenceState.ToString()
					}));
					num = (short)639762435;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::IACustomException.IACommonException a_2)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.a(a_2);
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException);
			}
			num = (short)1968832512;
			short num4 = num;
			num = (short)460455937;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0001616C File Offset: 0x0001436C
		public void DeregisterForPresence(global::System.Collections.Generic.List<string> deviceIDs, global::SSLMangrComp.PNConnectionInfo connInfo)
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)1950364620;
				short num2 = num;
				num = (short)519320524;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)449249280;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("힒ﲘﲚ햠욢힤욨\ud9aaﶬ\uddae풰삲킴\ud9b6\udab8\udeba鎼醾ￂ뻄듈뛌ﻎ곐ﯔ淪裚꧜뻞鏠韢", a_), new object[]
					{
						connInfo.PNConnectionConfig.PnIp,
						connInfo.PNConnectionConfig.PnPort
					});
					object obj = this.e;
					bool flag = false;
					try
					{
						global::System.Threading.Monitor.Enter(obj, ref flag);
						this.a.ServerInfo = connInfo;
						this.a.DeregisterAsWatcher(deviceIDs);
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("힒ﲘﲚ햠욢힤욨\ud9aaﶬ\uddae풰삲킴\ud9b6\udab8\udeba鎼醾ￂ뻄듈뛌ﻎ곐ﯔ淪鿚닜뇞蓠", a_), new object[]
						{
							connInfo.PNConnectionConfig.PnIp,
							connInfo.PNConnectionConfig.PnPort
						});
					}
					finally
					{
						num = (short)1783889921;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)827064322;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_130;
								}
								continue;
							case 2:
								goto IL_165;
							}
							IL_130:
							if (!flag)
							{
								break;
							}
							num = (short)1776943104;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_165:;
					}
					break;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException);
			}
			num = (short)897056768;
			short num4 = num;
			num = (short)26542081;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0001638C File Offset: 0x0001458C
		public void RegisterForPresence(global::System.Collections.Generic.List<string> deviceIDs, global::SSLMangrComp.PNConnectionInfo connInfo)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)222061426;
				short num2 = num;
				num = (short)323576690;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)231931904;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("삑ﮝ튟쮣풥\ud8a9즫\uddad햯\udcb1ힳ펵隷钹銻芽뮿맃ﳅ돇﯉뇋ﻏﳑ䀘藕곗믙껛ꫝ", a_), new object[]
					{
						connInfo.PNConnectionConfig.PnIp,
						connInfo.PNConnectionConfig.PnPort
					});
					object obj = this.e;
					bool flag = false;
					try
					{
						global::System.Threading.Monitor.Enter(obj, ref flag);
						this.a.RadioFound -= this.a;
						this.a.RadioFound += this.a;
						connInfo.PNConnectionConfig.Expiration = 2144448000;
						this.a.ServerInfo = connInfo;
						this.a.RegisterAsWatcher(deviceIDs);
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("삑ﮝ튟쮣풥\ud8a9즫\uddad햯\udcb1ힳ펵隷钹銻芽뮿맃ﳅ돇﯉뇋ﻏﳑ䀘鋕럗듙맛", a_), new object[]
						{
							connInfo.PNConnectionConfig.PnIp,
							connInfo.PNConnectionConfig.PnPort
						});
					}
					finally
					{
						num = (short)622460929;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1946288130;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_16C;
								}
								continue;
							case 2:
								goto IL_1A1;
							}
							IL_16C:
							if (!flag)
							{
								break;
							}
							num = (short)1987444736;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1A1:;
					}
					break;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::IACustomException.IACommonException a_2)
			{
				global::Motorola.Common.Communication.Service.DeviceDiscovery.a(a_2);
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException);
			}
			num = (short)1649147904;
			short num4 = num;
			num = (short)155713537;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00016608 File Offset: 0x00014808
		public void ClosePN()
		{
			int a_ = 15;
			short num;
			try
			{
				num = (short)76445264;
				short num2 = num;
				num = (short)867464784;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1517551617;
					if (num != 0)
					{
					}
					num = (short)1806106624;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("튐ﾒ杖煮뾞认覦螨薪莬膮", a_), global::System.Array.Empty<object>());
					object obj = this.e;
					bool flag = false;
					try
					{
						global::System.Threading.Monitor.Enter(obj, ref flag);
						this.a.closePN();
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("튐ﾒ杖ﶘ뮚출톞辠", a_), global::System.Array.Empty<object>());
					}
					finally
					{
						num = (short)1986199553;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1367343106;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_105;
								}
								continue;
							case 2:
								goto IL_139;
							}
							IL_105:
							if (!flag)
							{
								break;
							}
							num = (short)1977483264;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_139:;
					}
					break;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException);
			}
			num = (short)1491992576;
			short num4 = num;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000167D8 File Offset: 0x000149D8
		public global::SSLMangrComp.PresenceNotification RetrievePresenceInfo(global::SSLMangrComp.PNConnectionInfo connInfo)
		{
			int a_ = 7;
			short num = (short)46530560;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)775749633;
				if (num != 0)
				{
				}
				global::SSLMangrComp.ConnectionManager connectionManager = null;
				global::SSLMangrComp.PresenceNotification result = new global::SSLMangrComp.PresenceNotification();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_77;
					}
					for (;;)
					{
						IL_60:
						switch (num2)
						{
						case 0:
							goto IL_1BB;
						case 1:
						{
							if (connInfo == null)
							{
								goto IL_163;
							}
							num = (short)679463738;
							short num3 = num;
							num = (short)51628858;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)535298048;
								if (num != 0)
								{
								}
								num = (short)1016004610;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							connectionManager = new global::SSLMangrComp.ConnectionManager(connInfo, false);
							connectionManager.InitiateConnection(ref result);
							num = (short)2124283907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_163;
						}
						goto IL_77;
						IL_163:
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\udb88歷ﶎ즘쒠춢욤슦얪쮬삮龰鶲鮴讶슸论삼薾뫀룄阮诎뻐뷒냔", a_), new object[]
						{
							connInfo.PNConnectionConfig.PnIp,
							connInfo.PNConnectionConfig.PnPort
						});
						num = (short)2023096320;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1BB:
					goto IL_236;
					IL_77:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\udb88歷ﶎ즘쒠춢욤슦얪쮬삮龰鶲鮴讶슸论삼薾뫀룄阮鳎ꗐ닒꟔ꏖ", a_), new object[]
					{
						connInfo.PNConnectionConfig.PnIp,
						connInfo.PNConnectionConfig.PnPort
					});
					num = (short)1098186753;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_60;
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					throw;
				}
				catch (global::IACustomException.IACommonException a_2)
				{
					global::Motorola.Common.Communication.Service.DeviceDiscovery.a(a_2);
				}
				catch (global::System.Exception systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException);
				}
				finally
				{
					if (connectionManager != null)
					{
						try
						{
							connectionManager.StopListener();
						}
						catch (global::System.AccessViolationException ex)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("좈쎔ﺖﲜ좠첢쮤톨좪좬\udfae얰\udab2\udab4\ud9b6馸튺펼龾鋀럂꫄럆藈ꋊ뻌믎듐뷒냔ꗖ律", a_) + ex.Message, global::System.Array.Empty<object>());
						}
						catch (global::System.Exception ex2)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("첈ﲔ뮚膠톤좦\ud9a8쒬\udcae얰횲\udbb4튶쮸鮺", a_) + ex2.Message, global::System.Array.Empty<object>());
						}
					}
				}
				IL_236:
				num = (short)1856962560;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00016ADC File Offset: 0x00014CDC
		private void b(object A_0, global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs A_1)
		{
			int a_ = 4;
			short num;
			for (;;)
			{
				num = (short)1807482880;
				switch (num)
				{
				default:
				{
					num = (short)1639818748;
					short num2 = num;
					num = (short)1784260092;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_5C;
					}
					break;
				}
				}
			}
			IL_5C:
			num = (short)432406528;
			short num3 = num;
			num = (short)913440768;
			if (num != 0)
			{
			}
			num = (short)500957185;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.DeviceDiscovery.a a = new global::Motorola.Common.Communication.Service.DeviceDiscovery.a();
			a.a = this;
			a.b = A_1;
			try
			{
				num = (short)780992517;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						this.g.WriteInfo(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("톅낏횑蓮鍊뺝쮡힣얥잧\udca9즫\udcad즯銱荒\ud9b5첷펹\udabbힽꎿꏁ냃꿅Ꟈ꓉ꯏ꧓믗뗙닛냝藟臡郣菥賧", a_), new object[]
						{
							a.b.DeviceInfo.RadioID
						});
						num = (short)1555431428;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							this.b.OnDeviceConnected(a.b);
						}
						catch (global::System.Exception ex)
						{
							this.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("쎅ﺍﮑﮓ뢗뺝쎟쎡좣쪥쪧쮩쾫얭邯\udbb3\udbb5햷쾹튻ힽꎿꏁ냃꿅Ꟈ꓉臋꿍뻏돑돓돕꫗藙飛믝雟诡蟣菥ꯧ藩苫胭闯釱胳鏵鳷\udaf9퇻\udefd", a_) + ex.Message, global::System.Array.Empty<object>());
						}
						goto IL_285;
					case 2:
						num = (short)888930311;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_29E;
					case 4:
						if ((a.b.DeviceInfo.Family & global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio) > global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
						{
							num = (short)1296957441;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Threading.Tasks.Task.Run(new global::System.Action(a.c));
						num = (short)1124990982;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_11C;
						}
						continue;
					case 6:
						goto IL_285;
					case 7:
						if ((a.b.DeviceInfo.Family & this.c) > global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
						{
							num = (short)662765568;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_285;
					}
					IL_11C:
					if (this.b != null)
					{
						num = (short)2032009218;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_285:
					num = (short)483524611;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_29E:;
			}
			catch (global::System.ServiceModel.CommunicationObjectAbortedException)
			{
				this.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("얅늑햓뺝춡쪣좥춧즩\ud8ab잭\udfaf\udcb1閳", a_), global::System.Array.Empty<object>());
				this.b = null;
			}
			catch (global::System.ServiceModel.CommunicationException)
			{
				this.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("얅늑햓뺝춡쪣좥춧즩\ud8ab잭\udfaf\udcb1閳", a_), global::System.Array.Empty<object>());
				this.b = null;
			}
			catch (global::System.ObjectDisposedException ex2)
			{
				this.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("얅늑햓뺝춡쪣좥춧즩\ud8ab잭\udfaf\udcb1讳隵閷骹", a_) + ex2.Message, global::System.Array.Empty<object>());
				this.b = null;
			}
			catch (global::System.Exception ex3)
			{
				this.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("얅ﮍﺏﮑ쎡쪣장쾧쾩\udeabힱ슳\udfb5\udbb7\udfb9ﾻ톽꺿곁ꇃꗅ볇꿉꣋뗏꫑럓돕꣗껙뗛뇝軟싡짣웥", a_) + ex3.Message, global::System.Array.Empty<object>());
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00016EBC File Offset: 0x000150BC
		private void a(object A_0, global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs A_1)
		{
			int a_ = 17;
			short num;
			for (;;)
			{
				num = (short)1821114369;
				if (num != 0)
				{
				}
				num = (short)1881341952;
				switch (num)
				{
				default:
				{
					num = (short)1191499222;
					short num2 = num;
					num = (short)1538577878;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_AE;
					}
					goto Block_1;
				}
				}
			}
			Block_1:
			num = (short)2088501248;
			short num3 = num;
			IL_AE:
			num = (short)1157627904;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.DeviceDiscovery.b b = new global::Motorola.Common.Communication.Service.DeviceDiscovery.b();
			b.a = this;
			b.b = A_1;
			try
			{
				num = (short)108920837;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						this.g.WriteInfo(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("쒒ﲔﲘﾚ붜\udb9e쒠햢첤쒦첨讪욮슰킲\udab4솶\udcb8즺쒼龾迀곂뇄껆꿈ꋊ껌껎ꗐ뫒뫔맖ﯚꛜ鳠쏢臤軦髨裪苬臮鿰雲雴菶鳸鿺", a_), new object[]
						{
							b.b.DeviceInfo.RadioID
						});
						num = (short)1235681284;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							this.b.OnDeviceLost(b.b);
						}
						catch (global::System.Exception ex)
						{
							this.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("횒ﲘ캠춢薤좦잨讪캬캮\uddb0\udfb2ힴ횶\udab8킺鶼ﲾ껀껂꣄닆ꟈꋊ껌껎ꗐ뫒뫔맖铘뫚돜뻞蛠蛢韤룦귨軪鯬蛮鋰雲맴飶諸迺\uddfc틾℀", a_) + ex.Message, global::System.Array.Empty<object>());
						}
						goto IL_287;
					case 2:
						num = (short)1466105863;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_29F;
					case 4:
						if ((b.b.DeviceInfo.Family & global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio) > global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
						{
							num = (short)1880424449;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Threading.Tasks.Task.Run(new global::System.Action(b.c));
						num = (short)270336006;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_120;
						}
						continue;
					case 6:
						goto IL_287;
					case 7:
						if ((b.b.DeviceInfo.Family & this.c) > global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
						{
							num = (short)1474691072;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_287;
					}
					IL_120:
					if (this.b != null)
					{
						num = (short)203161602;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_287:
					num = (short)1923547139;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_29F:;
			}
			catch (global::System.ServiceModel.CommunicationObjectAbortedException)
			{
				this.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("킒璉ﺖﲘ뾞솢쪤햦\udda8讪삮\udfb0\uddb2킴풶춸튺튼톾", a_), global::System.Array.Empty<object>());
				this.b = null;
			}
			catch (global::System.ServiceModel.CommunicationException)
			{
				this.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("킒璉ﺖﲘ뾞솢쪤햦\udda8讪삮\udfb0\uddb2킴풶춸튺튼톾", a_), global::System.Array.Empty<object>());
				this.b = null;
			}
			catch (global::System.ObjectDisposedException ex2)
			{
				this.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("킒璉ﺖﲘ뾞솢쪤햦\udda8讪삮\udfb0\uddb2킴풶춸튺튼톾ﻀ", a_) + ex2.Message, global::System.Array.Empty<object>());
				this.b = null;
			}
			catch (global::System.Exception ex3)
			{
				this.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("킒杖殺슠슢톤캦욨얪캮\udfb0튲튴튶쮸寮\udabe럀ꫂꛄꋆ藈꓊뻌믎뛒귔듖볘ꯚ꧜뛞軠跢엤쫦짨", a_) + ex3.Message, global::System.Array.Empty<object>());
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0001729C File Offset: 0x0001549C
		private void a(object A_0, global::Motorola.Common.Communication.CommonUtil.SwitchOverEventArgs A_1)
		{
			int a_ = 8;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_35;
				}
				int num;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						global::System.Diagnostics.Trace.WriteLine(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.Communication.Service.DeviceServiceManager.b("캉憐뚕ꪙ뺝펟잡힣향솧얩슫躭쮯莱즳隵쮷춹햻쪽ꎿ꫁ꯃ냅귇룉뷍꓏돑ꃓꏕꯗ龎ꟛ鷟", a_), (A_1.DeviceInfo == null) ? string.Empty : A_1.DeviceInfo.RadioID, A_1.SessionID, A_1.Status));
						this.b.OnDeviceSwitchOver(A_1);
						goto IL_13E;
					case 1:
						if (this.c.HasFlag(A_1.DeviceInfo.Family))
						{
							num2 = (short)568000514;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1AC;
					case 2:
						num2 = (short)966000640;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						num2 = (short)1490545407;
						short num3 = num2;
						num2 = (short)1265232639;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13E;
						default:
							num2 = (short)327876608;
							if (num2 != 0)
							{
							}
							goto IL_1AC;
						}
						break;
					}
					case 4:
						num2 = (short)1971585025;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_1C3;
					case 6:
						if (this.b != null)
						{
							num2 = (short)1387724804;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1AC;
					}
					goto IL_35;
					IL_13E:
					num2 = (short)1638531075;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1AC:
					num2 = (short)1962213381;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1C3:
				goto IL_24B;
				IL_35:
				global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.ReturnID(A_1.SessionID);
				num2 = (short)930021382;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch (global::System.ServiceModel.CommunicationObjectAbortedException)
			{
				this.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("즉ﲑ뚕\ud997풟芡즥욧쒩즫춭쒯\udbb1\udbb3\ud8b5馷", a_), global::System.Array.Empty<object>());
				this.b = null;
			}
			catch (global::System.ServiceModel.CommunicationException)
			{
				this.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("즉ﲑ뚕\ud997풟芡즥욧쒩즫춭쒯\udbb1\udbb3\ud8b5馷", a_), global::System.Array.Empty<object>());
				this.b = null;
			}
			catch (global::System.ObjectDisposedException ex)
			{
				this.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("즉ﲑ뚕\ud997풟芡즥욧쒩즫춭쒯\udbb1\udbb3\ud8b5螷骹醻麽", a_) + ex.Message, global::System.Array.Empty<object>());
				this.b = null;
			}
			IL_24B:
			num2 = (short)1862205441;
			if (num2 != 0)
			{
			}
			num2 = (short)1479999488;
			short num4 = num2;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00017590 File Offset: 0x00015790
		private static void a(global::IACustomException.IACommonException A_0)
		{
			short num = (short)1031983773;
			short num2 = num;
			num = (short)405263005;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1744371712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1094582273;
			if (num != 0)
			{
			}
			num = (short)1207173120;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException((global::Motorola.Common.CustomException.CommonErrorCode)A_0.ErrorCode);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00017644 File Offset: 0x00015844
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> a(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> A_0)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
			short num;
			using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>.Enumerator enumerator = A_0.GetEnumerator())
			{
				num = (short)371195910;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_2E:
					switch (num2)
					{
					case 0:
						num = (short)323944453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
						list.Add(deviceInfo);
						num = (short)1212284931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						while (enumerator.MoveNext())
						{
							global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = devInfo.Copy();
							num = (short)116024237;
							short num3 = num;
							num = (short)1178952621;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)168296448;
								if (num != 0)
								{
								}
								num = (short)513146884;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_2E;
							}
						}
						num = (short)364511232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
						if (deviceInfo != null)
						{
							num = (short)1585381377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_159;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					}
					IL_E3:
					num = (short)1161887746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_50:
					goto IL_E3;
				}
				IL_159:;
			}
			num = (short)325189632;
			short num4 = num;
			num = (short)1336344577;
			if (num != 0)
			{
			}
			return list;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00017828 File Offset: 0x00015A28
		public void UpdatePassword(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> passwords)
		{
			short num = (short)199828640;
			short num2 = num;
			num = (short)1948591264;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1877934080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1796472833;
			if (num != 0)
			{
			}
			num = (short)2051342336;
			if (num != 0)
			{
			}
			this.f.UpdatePasswords(passwords);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000178E0 File Offset: 0x00015AE0
		public void DetachDevice(string serialnumber)
		{
			short num = (short)111920323;
			short num2 = num;
			num = (short)2035729603;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1613824000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1433468929;
			if (num != 0)
			{
			}
			num = (short)370343936;
			if (num != 0)
			{
			}
			this.f.DetachDevice(serialnumber);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00017994 File Offset: 0x00015B94
		public void RemoveDevice(string radioId)
		{
			short num = (short)1347551233;
			if (num != 0)
			{
			}
			num = (short)250740736;
			short num2 = num;
			num = (short)1818809668;
			short num3 = num;
			num = (short)1774769476;
			switch (num3 == num)
			{
			}
			num = (short)1903034368;
			if (num != 0)
			{
			}
			this.f.RemoveDevice(radioId);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00017A4C File Offset: 0x00015C4C
		public void DetectWiFiDevices()
		{
			short num = (short)698394850;
			short num2 = num;
			num = (short)1984145634;
			switch (num2 == num)
			{
			default:
			{
				num = (short)797966336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)745603073;
			if (num != 0)
			{
			}
			num = (short)2135359488;
			if (num != 0)
			{
			}
			this.f.DetectWiFiDevices();
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00017B04 File Offset: 0x00015D04
		public void ChangeDeviceProcessorToAp(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device)
		{
			short num = (short)405984029;
			short num2 = num;
			num = (short)1933759261;
			switch (num2 == num)
			{
			default:
			{
				num = (short)211943424;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)639827969;
			if (num != 0)
			{
			}
			num = (short)1185021952;
			if (num != 0)
			{
			}
			this.f.ChangeFromBpToAp(device);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00017BB8 File Offset: 0x00015DB8
		public bool IsRadioInBpMode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device)
		{
			short num = (short)495839753;
			short num2 = num;
			num = (short)1510664713;
			switch (num2 == num)
			{
			default:
			{
				num = (short)113508352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)594739200;
			if (num != 0)
			{
			}
			num = (short)2074673153;
			if (num != 0)
			{
			}
			return this.f.IsRadioInBpMode(device);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00017C70 File Offset: 0x00015E70
		public bool EstablishSecureConnection(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device, string psk)
		{
			short num = (short)201320881;
			short num2 = num;
			num = (short)984738225;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1542324224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1821442048;
			if (num != 0)
			{
			}
			num = (short)15073281;
			if (num != 0)
			{
			}
			return this.f.EstablishSecureConnection(device, psk);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00017D2C File Offset: 0x00015F2C
		public string GetPskId(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device)
		{
			short num = (short)119194469;
			short num2 = num;
			num = (short)257672037;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1637154816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1454637057;
			if (num != 0)
			{
			}
			num = (short)1903165440;
			if (num != 0)
			{
			}
			return this.f.GetPskId(device);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00017DE0 File Offset: 0x00015FE0
		public void ChangeFromBpToAp(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)124994657;
			short num2 = num;
			num = (short)2006074465;
			switch (num2 == num)
			{
			default:
			{
				num = (short)601227264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)14024705;
			if (num != 0)
			{
			}
			num = (short)1930952704;
			if (num != 0)
			{
			}
			this.f.ChangeFromBpToAp(deviceInfo);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00017E98 File Offset: 0x00016098
		public void Dispose()
		{
			short num = (short)331087873;
			if (num != 0)
			{
			}
			num = (short)728432640;
			short num2 = num;
			num = (short)176474197;
			short num3 = num;
			num = (short)1187629141;
			switch (num3 == num)
			{
			}
			num = (short)437911552;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00017F50 File Offset: 0x00016150
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)141426689;
			if (num != 0)
			{
			}
			num = (short)1671888901;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.c > global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
					{
						num = (short)799145986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					this.f.Stop();
					num = (short)1376911361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					for (;;)
					{
						global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager = this.f;
						communicationManager.DeviceConnectedEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Remove(communicationManager.DeviceConnectedEventHandler, new global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>(this.b));
						global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager2 = this.f;
						communicationManager2.DeviceLostEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Remove(communicationManager2.DeviceLostEventHandler, new global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>(this.a));
						num = (short)1494280852;
						short num3 = num;
						num = (short)1914170004;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_165;
						}
					}
					IL_165:
					num = (short)2069233664;
					if (num != 0)
					{
					}
					num = (short)1290731524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)40566784;
					short num4 = num;
					goto IL_A7;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				}
				IL_63:
				if (this.b != null)
				{
					num = (short)1106509827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A7:
				num = (short)1771503616;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x040000D3 RID: 211
		private readonly global::SSLMangrComp.ConnectionManagerWatcher a;

		// Token: 0x040000D4 RID: 212
		private global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent b;

		// Token: 0x040000D5 RID: 213
		private readonly global::Motorola.Common.Communication.CommonUtil.ProductFamily c;

		// Token: 0x040000D6 RID: 214
		private global::Motorola.Common.Communication.CommonUtil.WorkMode d;

		// Token: 0x040000D7 RID: 215
		private readonly object e;

		// Token: 0x040000D8 RID: 216
		private readonly global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager f;

		// Token: 0x040000D9 RID: 217
		private readonly global::Motorola.Common.Communication.CommonUtil.TraceLogger g;

		// Token: 0x02000046 RID: 70
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000287 RID: 647 RVA: 0x00018134 File Offset: 0x00016334
			internal void c()
			{
				int a_ = 2;
				short num;
				try
				{
					num = (short)138497435;
					short num2 = num;
					num = (short)1568820635;
					switch (num2 == num)
					{
					}
					num = (short)2013790208;
					if (num != 0)
					{
					}
					this.a.b.OnDeviceConnected(this.b);
				}
				catch (global::System.Exception ex)
				{
					this.a.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("솃ﺅﲋ揄憐﶑望뚕벛ﶝ솟캡좣쒥즧즩잫躭\uddb1\ud9b3\udbb5춷풹햻\uddbdꆿ뛁귃꧅ꛇ蟉귋ꃍ뇏뗑뇓ꓕ蟗黙맛꣝觟臡臣ꗥ蟧蓩苫语鏯蛱釳鋵\ud8f7ퟹ\udcfb", a_) + ex.Message, global::System.Array.Empty<object>());
				}
				num = (short)1758527489;
				if (num != 0)
				{
				}
				num = (short)1904738304;
				short num3 = num;
			}

			// Token: 0x040000DA RID: 218
			public global::Motorola.Common.Communication.Service.DeviceDiscovery a;

			// Token: 0x040000DB RID: 219
			public global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs b;
		}

		// Token: 0x02000047 RID: 71
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x06000289 RID: 649 RVA: 0x00018254 File Offset: 0x00016454
			internal void c()
			{
				int a_ = 2;
				short num;
				try
				{
					num = (short)626952087;
					short num2 = num;
					num = (short)1979615127;
					switch (num2 == num)
					{
					}
					num = (short)1507655680;
					if (num != 0)
					{
					}
					this.a.b.OnDeviceLost(this.b);
				}
				catch (global::System.Exception ex)
				{
					this.a.g.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("솃ﺅﲋ揄憐﶑望뚕벛ﶝ솟캡좣쒥즧즩잫躭\uddb1\ud9b3\udbb5춷풹햻\uddbdꆿ뛁귃꧅ꛇ蟉귋ꃍ뇏뗑뇓ꓕ蟗黙맛꣝觟臡臣ꫥ蟧駩飫컭\uddef틱", a_) + ex.Message, global::System.Array.Empty<object>());
				}
				num = (short)1319698433;
				if (num != 0)
				{
				}
				num = (short)1352007680;
				short num3 = num;
			}

			// Token: 0x040000DC RID: 220
			public global::Motorola.Common.Communication.Service.DeviceDiscovery a;

			// Token: 0x040000DD RID: 221
			public global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs b;
		}
	}
}
