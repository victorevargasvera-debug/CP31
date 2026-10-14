using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using IACustomException;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.Security;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x0200003E RID: 62
	public sealed class TLSServerListener : global::SSLMangrComp.ConnectionLayer.IServerListener
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000163 RID: 355 RVA: 0x00014BF4 File Offset: 0x00012DF4
		// (remove) Token: 0x06000164 RID: 356 RVA: 0x00014D2C File Offset: 0x00012F2C
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle PacketRecived
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
				short num2;
				for (;;)
				{
					IL_0A:
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
					switch (num)
					{
					case 0:
						IL_38:
						goto IL_3A;
					case 1:
						if (packetRecivedHandle == packetRecivedHandle2)
						{
							num2 = (short)1570242562;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					case 2:
						return;
					}
					goto IL_1C;
					IL_3A:
					num2 = (short)485733604;
					short num3 = num2;
					num2 = (short)1020507364;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_38;
					case 1:
						break;
					default:
					{
						num2 = (short)51249152;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)548864001;
					if (num2 != 0)
					{
					}
					num2 = (short)1405353984;
					if (num2 != 0)
					{
					}
					packetRecivedHandle2 = packetRecivedHandle;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Combine(packetRecivedHandle2, value);
					packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.i, value2, packetRecivedHandle2);
					num2 = (short)1853095937;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				packetRecivedHandle = this.i;
				num2 = (short)427294720;
				num = (int)((global::System.IntPtr)num2);
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
				global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
				short num2;
				for (;;)
				{
					IL_0A:
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
					switch (num)
					{
					case 0:
						IL_38:
						goto IL_3A;
					case 1:
						if (packetRecivedHandle == packetRecivedHandle2)
						{
							num2 = (short)944570370;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					case 2:
						goto IL_104;
					}
					goto IL_1C;
					IL_3A:
					num2 = (short)123235856;
					short num3 = num2;
					num2 = (short)664170000;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_38;
					case 1:
						break;
					default:
					{
						num2 = (short)1834418176;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)291569664;
					if (num2 != 0)
					{
					}
					packetRecivedHandle2 = packetRecivedHandle;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Remove(packetRecivedHandle2, value);
					packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.i, value2, packetRecivedHandle2);
					num2 = (short)483852289;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_104:
				num2 = (short)704643073;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				packetRecivedHandle = this.i;
				num2 = (short)1191903232;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000165 RID: 357 RVA: 0x00014E68 File Offset: 0x00013068
		// (remove) Token: 0x06000166 RID: 358 RVA: 0x00014FA0 File Offset: 0x000131A0
		public event global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle ErrorReceived
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
				global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle;
				for (;;)
				{
					IL_0A:
					num = (short)290062337;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						IL_5E:
						goto IL_60;
					case 1:
					{
						global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
						if (errorReceivedHandle == errorReceivedHandle2)
						{
							num = (short)980353026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_60;
					}
					case 2:
						return;
					}
					goto IL_43;
					IL_60:
					num = (short)1307377664;
					short num3 = num;
					num = (short)632479962;
					short num4 = num;
					num = (short)2058346714;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5E;
					default:
					{
						num = (short)781254656;
						if (num != 0)
						{
						}
						global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2 = errorReceivedHandle;
						global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Combine(errorReceivedHandle2, value);
						errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.j, value2, errorReceivedHandle2);
						num = (short)1517289473;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_43:
				errorReceivedHandle = this.j;
				num = (short)7471104;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				short num;
				int num2;
				global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle;
				for (;;)
				{
					IL_0A:
					num = (short)1813512193;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						IL_60:
						goto IL_62;
					case 1:
					{
						global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
						if (errorReceivedHandle == errorReceivedHandle2)
						{
							num = (short)1874132994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62;
					}
					case 2:
						return;
					}
					goto IL_45;
					IL_62:
					num = (short)2046164992;
					short num3 = num;
					num = (short)263630936;
					short num4 = num;
					num = (short)1692840024;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
					{
						num = (short)1644625920;
						if (num != 0)
						{
						}
						global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2 = errorReceivedHandle;
						global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Remove(errorReceivedHandle2, value);
						errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.j, value2, errorReceivedHandle2);
						num = (short)1235156993;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_45:
				errorReceivedHandle = this.j;
				num = (short)958201856;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000150D8 File Offset: 0x000132D8
		public void StartListner(global::System.Net.IPAddress pnIpAddress, global::SSLMangrComp.SecureServerConfiguration secureServerConfig, global::SSLMangrComp.Packets.SubscriptionType lMode)
		{
			short num = (short)1753153537;
			if (num != 0)
			{
			}
			num = (short)631504896;
			short num2 = num;
			num = (short)30680218;
			short num3 = num;
			num = (short)689644698;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1288503296;
				if (num != 0)
				{
				}
				object obj = this.h;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					this.a();
					this.c = false;
					this.f = secureServerConfig;
					this.g = lMode;
					this.b = new global::System.Net.Sockets.TcpListener(global::System.Net.IPAddress.Any, 0);
					this.b.Start(5);
					global::System.Net.IPEndPoint ipendPoint = this.b.LocalEndpoint as global::System.Net.IPEndPoint;
					this.d = ((ipendPoint != null) ? ipendPoint.Port : 0);
					this.a = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.b));
					this.a.Start();
				}
				finally
				{
					num = (short)1577582592;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_160;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)98762754;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_195;
						}
						IL_160:
						if (!flag)
						{
							break;
						}
						num = (short)837812225;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_195:;
				}
				break;
			}
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00015290 File Offset: 0x00013490
		public void StartListner(int port)
		{
			short num = (short)23134209;
			if (num != 0)
			{
			}
			num = (short)640090112;
			short num2 = num;
			num = (short)174302321;
			short num3 = num;
			num = (short)1469555825;
			switch (num3 == num)
			{
			}
			num = (short)1740242944;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00015340 File Offset: 0x00013540
		private void b()
		{
			short num = (short)1658650624;
			switch (num)
			{
			default:
			{
				num = (short)1908801536;
				short num2 = num;
				num = (short)547094529;
				if (num != 0)
				{
				}
				global::Org.BouncyCastle.Crypto.Tls.Certificate a_ = null;
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter a_2 = null;
				global::Org.BouncyCastle.Crypto.Tls.Certificate a_3 = null;
				global::Org.BouncyCastle.Crypto.Parameters.DHParameters a_4 = null;
				global::System.IO.Stream stream = null;
				try
				{
					num = (short)171114496;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Net.Sockets.TcpClient tcpClient;
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_C5;
							}
							continue;
						case 1:
							num = (short)2114322439;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_E5;
						case 3:
							if (!this.c)
							{
								num = (short)476315649;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3EE;
						case 4:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_16E;
								}
								for (;;)
								{
									IL_157:
									switch (num3)
									{
									case 0:
										try
										{
											global::SSLMangrComp.ConnectionLayer.a tlsServer = new global::SSLMangrComp.ConnectionLayer.a(a_, a_3, a_2, a_4);
											global::SSLMangrComp.a a = new global::SSLMangrComp.a(stream, this.e);
											a.Accept(tlsServer);
											stream = a.Stream;
											this.a(stream);
											a.Close();
											goto IL_2ED;
										}
										catch (global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert tlsFatalAlert)
										{
											byte alertDescription = tlsFatalAlert.AlertDescription;
											switch (alertDescription)
											{
											case 41:
												this.a(global::SSLMangrComp.ErrorCategory.CertificateError, global::IACustomException.IACommonErrorCode.GenericError);
												return;
											case 42:
											case 45:
											case 46:
												break;
											case 43:
											case 44:
												goto IL_2B9;
											default:
												if (alertDescription == 80)
												{
													this.a(global::SSLMangrComp.ErrorCategory.ProtocolError, global::IACustomException.IACommonErrorCode.SSL_PE_TLSProtocolFailed);
													return;
												}
												if (alertDescription != 111)
												{
													goto IL_2B9;
												}
												break;
											}
											this.a(global::SSLMangrComp.ErrorCategory.ProtocolError, global::IACustomException.IACommonErrorCode.SSL_PE_MutualAuthenticationFail);
											return;
											IL_2B9:
											this.a(global::SSLMangrComp.ErrorCategory.ProtocolError, global::IACustomException.IACommonErrorCode.GenericError);
											return;
										}
										goto IL_2CA;
									case 1:
									{
										num = (short)664015884;
										short num4 = num;
										num = (short)1015813132;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_2CA;
										default:
											num = (short)1794899968;
											if (num != 0)
											{
											}
											if (this.g == global::SSLMangrComp.Packets.SubscriptionType.Secure)
											{
												num = (short)334626816;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_2CA;
										}
										break;
									}
									case 2:
										goto IL_2ED;
									case 3:
										goto IL_306;
									}
									goto IL_16E;
									IL_2CA:
									this.a(stream);
									num = (short)315031554;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_2ED:
									num = (short)1445330947;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_306:
								goto IL_E5;
								IL_16E:
								stream = new global::SSLMangrComp.ConnectionLayer.e(tcpClient.GetStream(), false);
								num = (short)383778817;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_157;
							}
							finally
							{
								num = (short)342425600;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_33E;
										}
										continue;
									case 1:
										((global::System.IDisposable)tcpClient).Dispose();
										num = (short)168034306;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_379;
									}
									IL_33E:
									if (tcpClient == null)
									{
										break;
									}
									num = (short)1804664833;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_379:;
							}
							goto IL_37C;
						case 5:
							goto IL_37C;
						case 6:
							this.a(out a_, out a_2, out a_3, out a_4);
							num = (short)54198274;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (this.b.Server.LocalEndPoint != null)
							{
								num = (short)1647640581;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3EE;
						case 8:
							goto IL_407;
						}
						IL_C5:
						if (this.g == global::SSLMangrComp.Packets.SubscriptionType.Secure)
						{
							num = (short)2138898438;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E5:
						num = (short)1532821507;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_37C:
						tcpClient = this.b.AcceptTcpClient();
						num = (short)1807810564;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_3EE:
						num = (short)428343304;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_407:;
				}
				catch (global::System.Exception)
				{
					if (!this.c)
					{
						this.a(global::SSLMangrComp.ErrorCategory.LinkEstablishmentError, global::IACustomException.IACommonErrorCode.SSL_LE_LinkShutdownFail);
					}
				}
				finally
				{
					num = (short)1034616832;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_45E;
							}
							continue;
						case 1:
							stream.Close();
							num = (short)527368194;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_496;
						}
						IL_45E:
						if (stream == null)
						{
							break;
						}
						num = (short)1169620993;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_496:;
				}
				return;
			}
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0001584C File Offset: 0x00013A4C
		private void a(global::System.IO.Stream A_0)
		{
			short num;
			try
			{
				num = (short)943521792;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					byte[] array;
					global::SSLMangrComp.ConnectionLayer.b b;
					for (;;)
					{
						IL_27:
						byte[] data;
						switch (num2)
						{
						case 0:
							goto IL_1C9;
						case 1:
							goto IL_14C;
						case 2:
							goto IL_189;
						case 3:
							goto IL_130;
						case 4:
							try
							{
								int num3 = A_0.Read(array, 0, array.Length);
								goto IL_20B;
							}
							catch (global::System.Exception)
							{
								goto IL_279;
							}
							goto IL_14C;
							IL_20B:
							num = (short)2083323914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							num = (short)412491250;
							short num4 = num;
							num = (short)145628658;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_14C;
							default:
								num = (short)2041118720;
								if (num != 0)
								{
								}
								num = (short)952303619;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_184;
						case 7:
							goto IL_189;
						case 8:
							if ((data = b.b()) == null)
							{
								num = (short)1899036681;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1584594955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							num = (short)180158471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							int num3;
							if (num3 <= 0)
							{
								num = (short)985989125;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							b.a(array, num3);
							data = null;
							num = (short)1235156992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							if (this.i != null)
							{
								num = (short)1887436801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1C9;
						}
						goto IL_5E;
						IL_14C:
						global::SSLMangrComp.Packets.PacketBase packet = global::SSLMangrComp.Packets.PacketFactory.GetPacket(data, 2);
						packet.IsPacketRecived = true;
						this.i(packet);
						num = (short)342360070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_189:
						num = (short)523960324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1C9:
						num = (short)294584328;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_130:
					IL_184:
					break;
					IL_5E:
					array = new byte[1024];
					b = new global::SSLMangrComp.ConnectionLayer.b(2048);
					num = (short)1688141826;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			catch (global::System.Exception)
			{
				this.a(global::SSLMangrComp.ErrorCategory.ProtocolError, global::IACustomException.IACommonErrorCode.SSL_PE_TLSProtocolFailed);
			}
			IL_279:
			num = (short)608829441;
			if (num != 0)
			{
			}
			num = (short)1098776576;
			short num5 = num;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00015B58 File Offset: 0x00013D58
		public bool IsServerRunning()
		{
			short num = (short)971374593;
			if (num != 0)
			{
			}
			object obj = this.h;
			bool flag = false;
			bool result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_55;
				}
				int num2;
				for (;;)
				{
					IL_3B:
					bool flag2;
					switch (num2)
					{
					case 0:
						goto IL_E6;
					case 1:
						num = (short)1903755266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						flag2 = this.a.IsAlive;
						goto IL_CE;
					case 3:
						flag2 = false;
						goto IL_CE;
					case 4:
						if (this.a != null)
						{
							num = (short)78446593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)613810179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_55;
					IL_CE:
					result = flag2;
					num = (short)933363712;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E6:
				goto IL_1A3;
				IL_55:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num = (short)689111044;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_3B;
			}
			finally
			{
				num = (short)2033254402;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2132019322;
					short num3 = num;
					num = (short)59771002;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)563544064;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_1A0;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)900857856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_169;
							}
							continue;
						}
						IL_169:
						if (!flag)
						{
							goto IL_1A2;
						}
						break;
					}
					num = (short)558563329;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A0:
				IL_1A2:;
			}
			IL_1A3:
			num = (short)1664811008;
			short num4 = num;
			return result;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00015D44 File Offset: 0x00013F44
		private void a()
		{
			short num = (short)141492226;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)2106982401;
						if (num != 0)
						{
						}
						this.c = true;
						this.d = 0;
						this.b.Stop();
						this.a.Join();
						return;
					}
					catch (global::System.Exception)
					{
						return;
					}
					finally
					{
						num = (short)1942355972;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							IL_F4:
							switch (num2)
							{
							case 0:
								goto IL_1E1;
							case 1:
								num = (short)234749954;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (!this.a.IsAlive)
								{
									num = (short)1891434499;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E3;
							case 3:
								goto IL_1C2;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_10E;
								}
								continue;
							}
							IL_10E:
							while (this.a.ThreadState != global::System.Threading.ThreadState.Stopped)
							{
								num = (short)812829136;
								short num3 = num;
								num = (short)1839319504;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)547815424;
									if (num != 0)
									{
									}
									num = (short)1474691073;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_F4;
								}
							}
							IL_1C2:
							this.a = null;
							num = (short)1853882368;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1E1:
						IL_1E3:;
					}
					goto IL_1E4;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (this.a == null)
				{
					num = (short)834469888;
					short num4 = num;
					num = (short)291897345;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1E4:
				num = (short)1775501312;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00015F88 File Offset: 0x00014188
		public void ShutdownServer()
		{
			short num = (short)1052377088;
			short num2 = num;
			object obj = this.h;
			bool flag = false;
			try
			{
				global::System.Threading.Monitor.Enter(obj, ref flag);
				this.a();
			}
			finally
			{
				num = (short)1595408384;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_78;
						}
						continue;
					case 1:
					{
						num = (short)442206407;
						short num4 = num;
						num = (short)69830855;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_E5;
						}
						break;
					}
					case 2:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)28246017;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_78:
					if (!flag)
					{
						goto IL_FD;
					}
					num = (short)2007302146;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_E5:
				num = (short)469303296;
				if (num != 0)
				{
				}
				IL_FD:;
			}
			num = (short)1346830337;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000160CC File Offset: 0x000142CC
		private void a(global::SSLMangrComp.ErrorCategory A_0, global::IACustomException.IACommonErrorCode A_1)
		{
			int num;
			short num2;
			global::SSLMangrComp.ErrorReport error;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle = this.j;
						if (errorReceivedHandle == null)
						{
							num2 = (short)531628033;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						errorReceivedHandle(error);
						num2 = (short)1204158466;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						goto IL_8A;
					case 2:
						goto IL_70;
					}
					goto IL_1C;
				}
				IL_70:
				goto IL_128;
				IL_8A:
				num2 = (short)610590601;
				short num3 = num2;
				num2 = (short)2056445833;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_36;
				default:
				{
					num2 = (short)401014784;
					short num4 = num2;
					num2 = (short)394264576;
					if (num2 != 0)
					{
					}
					num2 = (short)317980673;
					if (num2 != 0)
					{
					}
					break;
				}
				}
				IL_128:
				this.ShutdownServer();
				return;
			}
			}
			IL_1C:
			error = new global::SSLMangrComp.ErrorReport
			{
				ErrCat = (uint)A_0,
				ErrorID = A_1
			};
			IL_36:
			num2 = (short)1443823616;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00016208 File Offset: 0x00014408
		private void a(out global::Org.BouncyCastle.Crypto.Tls.Certificate A_0, out global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter A_1, out global::Org.BouncyCastle.Crypto.Tls.Certificate A_2, out global::Org.BouncyCastle.Crypto.Parameters.DHParameters A_3)
		{
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			short num;
			int num3;
			global::SSLMangrComp.b b;
			for (;;)
			{
				IL_0A:
				num = (short)614268928;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_1D2;
				case 1:
				{
					byte[] certBytes;
					try
					{
						certBytes = global::System.Convert.FromBase64String(this.f.ClientCertificate);
						global::SSLMangrComp.CertificateLoader.LoadPfxCertificate(certBytes, b, out A_0, out A_1);
						goto IL_76;
					}
					finally
					{
						num = (short)202768384;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_14D;
								}
								continue;
							case 1:
							{
								num = (short)707688035;
								short num4 = num;
								num = (short)657880675;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_1BA;
								}
								break;
							}
							case 2:
								((global::System.IDisposable)b).Dispose();
								num = (short)1036845057;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_14D:
							if (b == null)
							{
								goto IL_1D1;
							}
							num = (short)1449263106;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1BA:
						num = (short)1445462016;
						if (num != 0)
						{
						}
						IL_1D1:;
					}
					goto IL_1D2;
					IL_76:
					certBytes = global::System.Convert.FromBase64String(this.f.CACertificate);
					A_2 = global::SSLMangrComp.CertificateLoader.LoadBcCertificate(certBytes);
					A_3 = null;
					num = (short)2023882755;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return;
				case 3:
					num = (short)1247281153;
					if (num != 0)
					{
					}
					if (this.f.DHParameters != null)
					{
						num = (short)269287424;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_4B;
				IL_1D2:
				A_3 = global::SSLMangrComp.CertificateLoader.LoadDhParams(this.f.DHParameters);
				num = (short)43319298;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_4B:
			b = new global::SSLMangrComp.b(this.f.ClientKeyPassphrase);
			num = (short)2094661633;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00016424 File Offset: 0x00014624
		public int getPortNumber()
		{
			short num = (short)1074312415;
			short num2 = num;
			num = (short)93041887;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2049441792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)664469505;
			if (num != 0)
			{
			}
			num = (short)1974140928;
			if (num != 0)
			{
			}
			return this.d;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000164D0 File Offset: 0x000146D0
		public void RegisterIncomingPacketHandler(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle hdl)
		{
			short num = (short)1885299703;
			short num2 = num;
			num = (short)396846071;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1699807232;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)928317440;
			if (num != 0)
			{
			}
			num = (short)690552833;
			if (num != 0)
			{
			}
			this.PacketRecived += hdl;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00016580 File Offset: 0x00014780
		public void RegisterIncomingErrorHandler(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle hdl)
		{
			short num = (short)387782209;
			short num2 = num;
			num = (short)1153373761;
			switch (num2 == num)
			{
			default:
			{
				num = (short)397410304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)778174465;
			if (num != 0)
			{
			}
			num = (short)1822228480;
			if (num != 0)
			{
			}
			this.ErrorReceived += hdl;
		}

		// Token: 0x040000C3 RID: 195
		private global::System.Threading.Thread a;

		// Token: 0x040000C4 RID: 196
		private global::System.Net.Sockets.TcpListener b;

		// Token: 0x040000C5 RID: 197
		private bool c;

		// Token: 0x040000C6 RID: 198
		private int d;

		// Token: 0x040000C7 RID: 199
		private readonly global::Org.BouncyCastle.Security.SecureRandom e = new global::Org.BouncyCastle.Security.SecureRandom();

		// Token: 0x040000C8 RID: 200
		private global::SSLMangrComp.SecureServerConfiguration f;

		// Token: 0x040000C9 RID: 201
		private global::SSLMangrComp.Packets.SubscriptionType g;

		// Token: 0x040000CA RID: 202
		private readonly object h = new object();

		// Token: 0x040000CB RID: 203
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle i;

		// Token: 0x040000CC RID: 204
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle j;
	}
}
