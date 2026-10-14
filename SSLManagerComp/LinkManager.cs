using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using IACustomException;
using SSLMangrComp.ConnectionLayer;
using SSLMangrComp.Connectors;
using SSLMangrComp.Packets;

namespace SSLMangrComp
{
	// Token: 0x02000013 RID: 19
	public class LinkManager
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000087 RID: 135 RVA: 0x00008FDC File Offset: 0x000071DC
		// (remove) Token: 0x06000088 RID: 136 RVA: 0x00009108 File Offset: 0x00007308
		public event global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle PacketSentOrRecived
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num2;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle packetSendOrRecievedHandle;
					for (;;)
					{
						IL_0A:
						global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle packetSendOrRecievedHandle2;
						switch (num)
						{
						case 0:
							goto IL_83;
						case 1:
							if (packetSendOrRecievedHandle == packetSendOrRecievedHandle2)
							{
								num2 = (short)190382080;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_39;
						case 2:
							goto IL_39;
						}
						goto IL_1C;
						IL_39:
						packetSendOrRecievedHandle2 = packetSendOrRecievedHandle;
						global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle value2 = (global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle)global::System.Delegate.Combine(packetSendOrRecievedHandle2, value);
						packetSendOrRecievedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle>(ref this.a, value2, packetSendOrRecievedHandle2);
						num2 = (short)929890305;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_83:
					num2 = (short)1427253333;
					short num3 = num2;
					num2 = (short)990390357;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_E4;
					}
					break;
					IL_1C:
					packetSendOrRecievedHandle = this.a;
					num2 = (short)677117954;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				num2 = (short)1060110336;
				short num4 = num2;
				IL_E4:
				num2 = (short)462290945;
				if (num2 != 0)
				{
				}
				num2 = (short)562561024;
				if (num2 != 0)
				{
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num2;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle packetSendOrRecievedHandle;
					for (;;)
					{
						IL_0A:
						global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle packetSendOrRecievedHandle2;
						switch (num)
						{
						case 0:
							goto IL_B1;
						case 1:
							if (packetSendOrRecievedHandle == packetSendOrRecievedHandle2)
							{
								num2 = (short)286654464;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_39;
						case 2:
							goto IL_39;
						}
						goto IL_1C;
						IL_39:
						num2 = (short)423624705;
						if (num2 != 0)
						{
						}
						packetSendOrRecievedHandle2 = packetSendOrRecievedHandle;
						global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle value2 = (global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle)global::System.Delegate.Remove(packetSendOrRecievedHandle2, value);
						packetSendOrRecievedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle>(ref this.a, value2, packetSendOrRecievedHandle2);
						num2 = (short)1880948737;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_B1:
					num2 = (short)2066022400;
					short num3 = num2;
					num2 = (short)1177901431;
					short num4 = num2;
					num2 = (short)273111415;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_112;
					}
					IL_1C:
					packetSendOrRecievedHandle = this.a;
					num2 = (short)661454850;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_112:
				num2 = (short)95944704;
				if (num2 != 0)
				{
				}
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000089 RID: 137 RVA: 0x00009240 File Offset: 0x00007440
		// (remove) Token: 0x0600008A RID: 138 RVA: 0x00009378 File Offset: 0x00007578
		public event global::SSLMangrComp.LinkManager.ErrorRecievedHandle ErrorReceived
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num2;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::SSLMangrComp.LinkManager.ErrorRecievedHandle errorRecievedHandle;
					for (;;)
					{
						IL_0A:
						global::SSLMangrComp.LinkManager.ErrorRecievedHandle errorRecievedHandle2;
						switch (num)
						{
						case 0:
							goto IL_B3;
						case 1:
							if (errorRecievedHandle == errorRecievedHandle2)
							{
								num2 = (short)571736064;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_63;
						case 2:
							goto IL_63;
						}
						goto IL_1C;
						IL_63:
						errorRecievedHandle2 = errorRecievedHandle;
						global::SSLMangrComp.LinkManager.ErrorRecievedHandle value2 = (global::SSLMangrComp.LinkManager.ErrorRecievedHandle)global::System.Delegate.Combine(errorRecievedHandle2, value);
						errorRecievedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.LinkManager.ErrorRecievedHandle>(ref this.b, value2, errorRecievedHandle2);
						num2 = (short)643497985;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_B3:
					num2 = (short)1318322176;
					short num3 = num2;
					num2 = (short)1692271483;
					short num4 = num2;
					num2 = (short)1414333307;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_114;
					}
					IL_1C:
					num2 = (short)195493889;
					if (num2 != 0)
					{
					}
					errorRecievedHandle = this.b;
					num2 = (short)1262747650;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_114:
				num2 = (short)905904128;
				if (num2 != 0)
				{
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num2;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::SSLMangrComp.LinkManager.ErrorRecievedHandle errorRecievedHandle;
					for (;;)
					{
						IL_0A:
						global::SSLMangrComp.LinkManager.ErrorRecievedHandle errorRecievedHandle2;
						switch (num)
						{
						case 0:
							goto IL_B0;
						case 1:
							num2 = (short)1947860993;
							if (num2 != 0)
							{
							}
							if (errorRecievedHandle == errorRecievedHandle2)
							{
								num2 = (short)2113470464;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_39;
						case 2:
							goto IL_39;
						}
						goto IL_1C;
						IL_39:
						errorRecievedHandle2 = errorRecievedHandle;
						global::SSLMangrComp.LinkManager.ErrorRecievedHandle value2 = (global::SSLMangrComp.LinkManager.ErrorRecievedHandle)global::System.Delegate.Remove(errorRecievedHandle2, value);
						errorRecievedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.LinkManager.ErrorRecievedHandle>(ref this.b, value2, errorRecievedHandle2);
						num2 = (short)1923284993;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_B0:
					num2 = (short)171114496;
					short num3 = num2;
					num2 = (short)1348458004;
					short num4 = num2;
					num2 = (short)184014356;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_113;
					}
					IL_1C:
					errorRecievedHandle = this.b;
					num2 = (short)1675755522;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_113:
				num2 = (short)1625423872;
				if (num2 != 0)
				{
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000094B0 File Offset: 0x000076B0
		public global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase> ActiveSubscriptionList
		{
			get
			{
				short num = (short)1919116508;
				short num2 = num;
				num = (short)777086172;
				switch (num2 == num)
				{
				}
				num = (short)2143158273;
				if (num != 0)
				{
				}
				num = (short)997392384;
				short num3 = num;
				num = (short)1461190656;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00009560 File Offset: 0x00007760
		public LinkManager()
		{
			this.f.RegisterIncomingPacketHandler(new global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle(this.a));
			this.f.RegisterIncomingErrorHandler(new global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle(this.a));
			this.e.RegisterIncomingPacketHandler(new global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle(this.a));
			this.e.RegisterIncomingErrorHandler(new global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle(this.a));
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00009618 File Offset: 0x00007818
		public void SetTimeOut(int timeoutDurationInSeconds, global::SSLMangrComp.ReportOnError_CallBack errorCallBack)
		{
			short num = (short)394559471;
			short num2 = num;
			num = (short)1742372847;
			switch (num2 == num)
			{
			}
			num = (short)1109131265;
			if (num != 0)
			{
			}
			num = (short)469762048;
			short num3 = num;
			num = (short)961806336;
			if (num != 0)
			{
			}
			((global::SSLMangrComp.ConnectionLayer.UDPCConnector)this.f).ErrorCallback = errorCallBack;
			this.f.SetTimeOutVal(timeoutDurationInSeconds);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000096E0 File Offset: 0x000078E0
		public void Subscribe(int expiry, global::SSLMangrComp.Packets.EntitiesTypes entitiesType, string entitieValues, string events, global::SSLMangrComp.Packets.SubscriptionType type, global::System.Net.IPAddress ipAddress, int udpPort)
		{
			short num = (short)810680320;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3F;
				}
				global::SSLMangrComp.Packets.SubscriptionPacket subscriptionPacket;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_1B6;
					case 1:
						subscriptionPacket.Type = type;
						this.c.Add(subscriptionPacket);
						goto IL_19E;
					case 2:
						this.f.StartListner(0);
						subscriptionPacket = new global::SSLMangrComp.Packets.UnreliableSubscriptionPacket(this.a(), expiry, entitiesType, entitieValues, events);
						num = (short)1727791105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)532547363;
						short num3 = num;
						num = (short)1143473955;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_19E;
						default:
						{
							num = (short)819986433;
							if (num != 0)
							{
							}
							num = (short)869531648;
							short num4 = num;
							num = (short)1905393664;
							if (num != 0)
							{
							}
							if (type == global::SSLMangrComp.Packets.SubscriptionType.Unreliable)
							{
								num = (short)2017263618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_147;
						}
						}
						break;
					}
					}
					goto IL_3F;
					IL_19E:
					num = (short)396492800;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_147:
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_InvalidSubscriptionType);
				IL_1B6:
				try
				{
					this.a(subscriptionPacket, ipAddress, udpPort);
					return;
				}
				catch (global::System.ArgumentException systemException)
				{
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UDPArgumentException, systemException);
				}
				catch (global::System.Net.Sockets.SocketException systemException2)
				{
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket, systemException2);
				}
				catch (global::System.Exception systemException3)
				{
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_TLSClientInternalFailure, systemException3);
				}
				goto IL_147;
				IL_3F:
				subscriptionPacket = null;
				num = (short)249102339;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000098D0 File Offset: 0x00007AD0
		public void ShutDownListen(global::SSLMangrComp.Packets.SubscriptionType type)
		{
			short num = (short)280166401;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1229258753;
					if (num != 0)
					{
					}
					if (type != global::SSLMangrComp.Packets.SubscriptionType.Unreliable)
					{
						return;
					}
					num = (short)1697776979;
					short num3 = num;
					num = (short)1387332947;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B;
					default:
					{
						num = (short)1506541568;
						if (num != 0)
						{
						}
						num = (short)445579264;
						short num4 = num;
						num = (short)1908211714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 2:
					this.f.ShutdownServer();
					num = (short)1161035779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					goto IL_4F;
				}
				goto IL_38;
				IL_3B:
				num = (short)498925572;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_38:
				if (type == global::SSLMangrComp.Packets.SubscriptionType.Secure)
				{
					goto IL_3B;
				}
				num = (short)117178368;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4F:
			this.e.ShutdownServer();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00009A38 File Offset: 0x00007C38
		public void Subscribe(int expiry, global::SSLMangrComp.Packets.EntitiesTypes entitiesType, string entitieValues, string events, global::SSLMangrComp.Packets.SubscriptionType type, global::System.Net.IPAddress ipAddress, int port, bool isDisconnectClient, global::SSLMangrComp.SecureClientConfiguration secureClientConfig, global::SSLMangrComp.SecureServerConfiguration secureServerConfig)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_5F;
			}
			short num;
			int num3;
			global::SSLMangrComp.Packets.SubscriptionPacket subscriptionPacket;
			for (;;)
			{
				IL_13:
				num = (short)1540882432;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (type == global::SSLMangrComp.Packets.SubscriptionType.Secure)
					{
						num = (short)242286598;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20F;
				case 1:
					if (!this.e.IsServerRunning())
					{
						num = (short)481427460;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21A;
				case 2:
					goto IL_156;
				case 3:
					subscriptionPacket.Type = type;
					this.c.Add(subscriptionPacket);
					num = (short)2003828738;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.a(type, secureServerConfig);
					num = (short)422772741;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_21A;
				case 6:
				{
					num = (short)1417281537;
					if (num != 0)
					{
					}
					num = (short)1495022884;
					short num4 = num;
					num = (short)1223703844;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2000879616;
						if (num != 0)
						{
						}
						this.h = ipAddress;
						num = (short)49872897;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_5F;
				IL_21A:
				subscriptionPacket = new global::SSLMangrComp.Packets.ReliableSubscriptionPacket(this.a(), this.g, expiry, entitiesType, entitieValues, events);
				num = (short)1865547779;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_156:
			string text;
			try
			{
				this.a(subscriptionPacket, ipAddress, port, secureClientConfig, isDisconnectClient);
				return;
			}
			catch (global::System.ArgumentException)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UDPArgumentException)
				{
					Source = text
				};
			}
			catch (global::System.Net.Sockets.SocketException)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket)
				{
					Source = text
				};
			}
			catch (global::System.Exception)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_TLSClientInternalFailure)
				{
					Source = text
				};
			}
			IL_20F:
			throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_InvalidSubscriptionType);
			IL_5F:
			text = base.GetType().ToString();
			text += global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ำ攵䴷堹伻崽㈿⭁♃⍅", a_);
			subscriptionPacket = null;
			num = (short)1329922048;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00009CBC File Offset: 0x00007EBC
		private void a(global::SSLMangrComp.Packets.SubscriptionPacket A_0, global::System.Net.IPAddress A_1, int A_2)
		{
			int a_ = 8;
			short num;
			for (;;)
			{
				string text = base.GetType().ToString();
				text += global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("9漻嬽⸿♁ᝃ㍅⩇㥉⽋㱍㥏≑⁓㽕㝗㑙", a_);
				try
				{
					this.f.Connect(A_1, A_2);
					this.f.WriteData(A_0.getData());
					goto IL_2F;
				}
				catch (global::System.ArgumentException)
				{
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UDPArgumentException)
					{
						Source = text
					};
				}
				catch (global::System.Net.Sockets.SocketException)
				{
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket)
					{
						Source = text
					};
				}
				finally
				{
					num = (short)543293441;
					if (num != 0)
					{
					}
					this.f.ShutdownClient();
				}
				return;
				IL_2F:
				num = (short)632193828;
				short num2 = num;
				num = (short)646087460;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_65;
				}
			}
			IL_65:
			num = (short)887947264;
			short num3 = num;
			num = (short)970784768;
			if (num != 0)
			{
			}
			A_0.IsPacketRecived = false;
			global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle packetSendOrRecievedHandle = this.a;
			if (packetSendOrRecievedHandle != null)
			{
				packetSendOrRecievedHandle(A_0);
				return;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00009E30 File Offset: 0x00008030
		private void a(global::SSLMangrComp.Packets.SubscriptionPacket A_0, global::System.Net.IPAddress A_1, int A_2, global::SSLMangrComp.SecureClientConfiguration A_3, bool A_4)
		{
			int a_ = 13;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_2D;
				}
				short num2;
				string text;
				for (;;)
				{
					IL_13:
					int num;
					switch (num)
					{
					case 0:
						if (A_3 != null)
						{
							num2 = (short)2018246658;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_11F;
					case 1:
						if (A_0.Type == global::SSLMangrComp.Packets.SubscriptionType.Secure)
						{
							num2 = (short)1907818500;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_11F;
					case 2:
						try
						{
							this.d.Connect(A_1, A_2, A_3);
							this.d.WriteData(A_0.getData());
							goto IL_11F;
						}
						catch (global::System.Exception)
						{
							throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_TLSClientInternalFailure)
							{
								Source = text
							};
						}
						finally
						{
							this.d.ShutdownClient();
						}
						goto IL_1C4;
					case 3:
						goto IL_13E;
					case 4:
						num2 = (short)1162543104;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
					IL_11F:
					A_0.IsPacketRecived = false;
					num2 = (short)1007550467;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_2D:
				num2 = (short)947322881;
				if (num2 != 0)
				{
				}
				text = base.GetType().ToString();
				text += global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("Ծቀ♂⭄⍆ᩈ㹊⽌㱎㉐⅒㱔❖ⵘ㉚㉜ㅞ", a_);
				num2 = (short)1237188608;
				short num3 = num2;
				num2 = (short)1126470021;
				short num4 = num2;
				num2 = (short)1896321413;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)202702848;
					if (num2 != 0)
					{
					}
					num2 = (short)1219231745;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				}
			}
			IL_13E:
			global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle packetSendOrRecievedHandle = this.a;
			if (packetSendOrRecievedHandle == null)
			{
				return;
			}
			IL_1C4:
			packetSendOrRecievedHandle(A_0);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000A024 File Offset: 0x00008224
		private void a(global::SSLMangrComp.Packets.PacketBase A_0)
		{
			short num = (short)2084831233;
			if (num != 0)
			{
			}
			num = (short)587287867;
			short num2 = num;
			num = (short)1805667643;
			switch (num2 == num)
			{
			}
			num = (short)1815609344;
			short num3 = num;
			num = (short)681115648;
			if (num != 0)
			{
			}
			global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle packetSendOrRecievedHandle = this.a;
			if (packetSendOrRecievedHandle == null)
			{
				return;
			}
			packetSendOrRecievedHandle(A_0);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000A0E0 File Offset: 0x000082E0
		private void a(global::SSLMangrComp.ErrorReport A_0)
		{
			short num = (short)646179552;
			short num2 = num;
			num = (short)535161568;
			switch (num2 == num)
			{
			}
			num = (short)831455233;
			if (num != 0)
			{
			}
			num = (short)646250496;
			short num3 = num;
			num = (short)345047040;
			if (num != 0)
			{
			}
			global::SSLMangrComp.LinkManager.ErrorRecievedHandle errorRecievedHandle = this.b;
			if (errorRecievedHandle == null)
			{
				return;
			}
			errorRecievedHandle(A_0);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000A19C File Offset: 0x0000839C
		private void a(global::SSLMangrComp.Packets.SubscriptionType A_0, global::SSLMangrComp.SecureServerConfiguration A_1)
		{
			short num = (short)1346764802;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_10F;
				case 1:
					this.e.StartListner(this.h, A_1, A_0);
					num = (short)1539112960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1328604461;
					short num3 = num;
					num = (short)1712776493;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_111;
					default:
					{
						num = (short)1057357824;
						short num4 = num;
						num = (short)580190208;
						if (num != 0)
						{
						}
						num = (short)1940193281;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_CD;
						}
						continue;
					}
					}
					break;
				}
				}
				IL_CD:
				if (A_1 == null)
				{
					break;
				}
				num = (short)1763377153;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			IL_111:
			this.g = this.e.getPortNumber();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000A2CC File Offset: 0x000084CC
		private ushort a()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			short num2;
			ushort num4;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)425525254;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_130;
				case 2:
					goto IL_1F3;
				case 3:
					return 0;
				case 4:
				{
					int num3;
					if (num3 >= this.c.Count)
					{
						num2 = (short)359333899;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num4 += 1;
					num2 = (short)1052966919;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_CF;
				case 6:
				{
					int num3;
					if (this.c[num3].DialogID == num4)
					{
						num2 = (short)1734737925;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3++;
					num2 = (short)1927741442;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_130;
				case 8:
				{
					if (num4 >= 65535)
					{
						goto IL_150;
					}
					int num3 = 0;
					num2 = (short)2017394698;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
				{
					num2 = (short)77135872;
					short num5 = num2;
					int num3;
					if (num3 < this.c.Count)
					{
						num2 = (short)922615808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CF;
				}
				case 10:
					goto IL_1F3;
				case 11:
					return num4;
				}
				goto IL_40;
				IL_CF:
				num2 = (short)1268252676;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_130:
				num2 = (short)1956446216;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F3:
				num2 = (short)831848457;
				num = (int)((global::System.IntPtr)num2);
			}
			return num4;
			IL_40:
			num2 = (short)909753833;
			short num6 = num2;
			num2 = (short)1661124073;
			switch ((num6 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_150:
				num2 = (short)1223622659;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1703084032;
				if (num2 != 0)
				{
				}
				num4 = 1;
				num2 = (short)68419585;
				if (num2 != 0)
				{
				}
				num2 = (short)1346043905;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0400004B RID: 75
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.LinkManager.PacketSendOrRecievedHandle a;

		// Token: 0x0400004C RID: 76
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.LinkManager.ErrorRecievedHandle b;

		// Token: 0x0400004D RID: 77
		private readonly global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase> c = new global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase>();

		// Token: 0x0400004E RID: 78
		private readonly global::SSLMangrComp.Connectors.b d = new global::SSLMangrComp.ConnectionLayer.TlsClientConnector();

		// Token: 0x0400004F RID: 79
		private readonly global::SSLMangrComp.ConnectionLayer.IServerListener e = new global::SSLMangrComp.ConnectionLayer.TLSServerListener();

		// Token: 0x04000050 RID: 80
		private readonly global::SSLMangrComp.ConnectionLayer.c f = new global::SSLMangrComp.ConnectionLayer.UDPCConnector();

		// Token: 0x04000051 RID: 81
		private int g;

		// Token: 0x04000052 RID: 82
		private global::System.Net.IPAddress h = new global::System.Net.IPAddress(new byte[]
		{
			127,
			0,
			0,
			1
		});

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000098 RID: 152
		public delegate void PacketSendOrRecievedHandle(global::SSLMangrComp.Packets.PacketBase packet);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x0600009C RID: 156
		public delegate void ErrorRecievedHandle(global::SSLMangrComp.ErrorReport errorReport);
	}
}
