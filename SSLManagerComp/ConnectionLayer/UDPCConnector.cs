using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using IACustomException;
using SSLMangrComp.Connectors;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x0200003F RID: 63
	public class UDPCConnector : global::SSLMangrComp.ConnectionLayer.c, global::SSLMangrComp.Connectors.b, global::SSLMangrComp.ConnectionLayer.IServerListener
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0001665C File Offset: 0x0001485C
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00016708 File Offset: 0x00014908
		public global::SSLMangrComp.ReportOnError_CallBack ErrorCallback
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1805792721;
				short num2 = num;
				num = (short)81343953;
				switch (num2 == num)
				{
				default:
				{
					num = (short)20119552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2145845248;
				if (num != 0)
				{
				}
				num = (short)1689124865;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1277756409;
				short num2 = num;
				num = (short)644613113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1085800448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)729350145;
				if (num != 0)
				{
				}
				num = (short)573046784;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000167B8 File Offset: 0x000149B8
		public void SetTimeOutVal(int secsTime)
		{
			short num = (short)1540298497;
			short num2 = num;
			num = (short)569317121;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1562247168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1029046273;
			if (num != 0)
			{
			}
			num = (short)75890688;
			if (num != 0)
			{
			}
			this.g = new global::System.TimeSpan(0, 0, secsTime);
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000177 RID: 375 RVA: 0x0001686C File Offset: 0x00014A6C
		// (remove) Token: 0x06000178 RID: 376 RVA: 0x000169A0 File Offset: 0x00014BA0
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle PacketRecived
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				short num;
				int num3;
				global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
				for (;;)
				{
					IL_0A:
					num = (short)174587904;
					short num2 = num;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
					switch (num3)
					{
					case 0:
						goto IL_62;
					case 1:
					{
						num = (short)88289841;
						short num4 = num;
						num = (short)1761030705;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9B;
						default:
							goto IL_E8;
						}
						break;
					}
					case 2:
						if (packetRecivedHandle == packetRecivedHandle2)
						{
							goto IL_9B;
						}
						goto IL_62;
					}
					goto IL_45;
					IL_62:
					packetRecivedHandle2 = packetRecivedHandle;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Combine(packetRecivedHandle2, value);
					packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.i, value2, packetRecivedHandle2);
					num = (short)1933574146;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_9B:
					num = (short)294191105;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_E8:
				num = (short)1977942017;
				if (num != 0)
				{
				}
				num = (short)773849088;
				if (num != 0)
				{
				}
				return;
				IL_45:
				packetRecivedHandle = this.i;
				num = (short)583663616;
				num3 = (int)((global::System.IntPtr)num);
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
				int num3;
				global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
				for (;;)
				{
					IL_0A:
					num = (short)318504960;
					short num2 = num;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
					switch (num3)
					{
					case 0:
						goto IL_62;
					case 1:
					{
						num = (short)1318129270;
						short num4 = num;
						num = (short)1595608694;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9B;
						default:
							goto IL_10D;
						}
						break;
					}
					case 2:
						if (packetRecivedHandle == packetRecivedHandle2)
						{
							goto IL_9B;
						}
						goto IL_62;
					}
					goto IL_45;
					IL_62:
					packetRecivedHandle2 = packetRecivedHandle;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Remove(packetRecivedHandle2, value);
					packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.i, value2, packetRecivedHandle2);
					num = (short)595132418;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_9B:
					num = (short)1774387201;
					if (num != 0)
					{
					}
					num = (short)1246429185;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_10D:
				num = (short)1581318144;
				if (num != 0)
				{
				}
				return;
				IL_45:
				packetRecivedHandle = this.i;
				num = (short)1219690496;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000179 RID: 377 RVA: 0x00016AD4 File Offset: 0x00014CD4
		// (remove) Token: 0x0600017A RID: 378 RVA: 0x00016C08 File Offset: 0x00014E08
		public event global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle ErrorReceived
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				short num;
				int num3;
				global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle;
				for (;;)
				{
					IL_0A:
					num = (short)1070071808;
					short num2 = num;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
					switch (num3)
					{
					case 0:
						goto IL_62;
					case 1:
					{
						num = (short)1338569222;
						short num4 = num;
						num = (short)1385755142;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9A;
						default:
							goto IL_E8;
						}
						break;
					}
					case 2:
						if (errorReceivedHandle == errorReceivedHandle2)
						{
							goto IL_9A;
						}
						goto IL_62;
					}
					goto IL_45;
					IL_62:
					errorReceivedHandle2 = errorReceivedHandle;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Combine(errorReceivedHandle2, value);
					errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.j, value2, errorReceivedHandle2);
					num = (short)1086783490;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A:
					num = (short)1046413313;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_E8:
				num = (short)984023041;
				if (num != 0)
				{
				}
				num = (short)1550188544;
				if (num != 0)
				{
				}
				return;
				IL_45:
				errorReceivedHandle = this.j;
				num = (short)522518528;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				short num;
				int num3;
				global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle;
				for (;;)
				{
					IL_0A:
					num = (short)1111949312;
					short num2 = num;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
					switch (num3)
					{
					case 0:
						goto IL_63;
					case 1:
					{
						num = (short)331582910;
						short num4 = num;
						num = (short)1768459710;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C2;
						default:
							goto IL_10D;
						}
						break;
					}
					case 2:
						if (errorReceivedHandle == errorReceivedHandle2)
						{
							goto IL_C2;
						}
						goto IL_63;
					}
					goto IL_46;
					IL_63:
					num = (short)662110209;
					if (num != 0)
					{
					}
					errorReceivedHandle2 = errorReceivedHandle;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Remove(errorReceivedHandle2, value);
					errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.j, value2, errorReceivedHandle2);
					num = (short)1002569730;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_C2:
					num = (short)1244069889;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_10D:
				num = (short)1571356672;
				if (num != 0)
				{
				}
				return;
				IL_46:
				errorReceivedHandle = this.j;
				num = (short)108134400;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00016D3C File Offset: 0x00014F3C
		public void ShutdownServer()
		{
			int num;
			short num2;
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
						global::System.Net.Sockets.UdpClient udpClient = this.a;
						if (udpClient == null)
						{
							num2 = (short)1816723457;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						udpClient.Close();
						num2 = (short)52690946;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						goto IL_77;
					case 2:
						goto IL_5C;
					}
					goto IL_1C;
				}
				IL_5C:
				goto IL_114;
				IL_77:
				num2 = (short)1523647033;
				short num3 = num2;
				num2 = (short)211223097;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23;
				default:
				{
					num2 = (short)15400960;
					short num4 = num2;
					num2 = (short)889061377;
					if (num2 != 0)
					{
					}
					num2 = (short)1959133184;
					if (num2 != 0)
					{
					}
					break;
				}
				}
				IL_114:
				this.f = null;
				return;
			}
			}
			IL_1C:
			this.e = true;
			IL_23:
			num2 = (short)117309440;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00016E64 File Offset: 0x00015064
		public void StartListner(global::System.Net.IPAddress pnIpAddress, global::SSLMangrComp.SecureServerConfiguration secureServerConfiguration, global::SSLMangrComp.Packets.SubscriptionType mode)
		{
			short num = (short)1780613121;
			if (num != 0)
			{
			}
			num = (short)1488584704;
			short num2 = num;
			num = (short)1171818521;
			short num3 = num;
			num = (short)801867801;
			switch (num3 == num)
			{
			}
			num = (short)1131085824;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00016F10 File Offset: 0x00015110
		public void StartListner(int portNo)
		{
			int a_ = 4;
			short num = (short)938695240;
			short num2 = num;
			num = (short)136141384;
			switch (num2 == num)
			{
			default:
			{
				num = (short)924975104;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1588854785;
			if (num != 0)
			{
			}
			num = (short)1403977728;
			if (num != 0)
			{
			}
			this.e = false;
			this.d = portNo;
			this.f = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.a));
			this.f.Start();
			this.f.Name = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("挵簷樹氻弽⌿⥁⅃㉅ч⍉㽋㩍㕏㱑ㅓ⑕౗㉙⹛㭝ş١", a_);
			global::System.Threading.Thread.Sleep(2000);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00017014 File Offset: 0x00015214
		public void HandlePackage(object o)
		{
			short num = (short)341704704;
			short num2 = num;
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			try
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				int num3;
				byte[] data;
				for (;;)
				{
					IL_3D:
					switch (num3)
					{
					case 0:
						goto IL_C4;
					case 1:
						if (this.i != null)
						{
							num = (short)1925513219;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4;
					case 2:
						goto IL_126;
					case 3:
					{
						global::SSLMangrComp.Packets.PacketBase packet = global::SSLMangrComp.Packets.PacketFactory.GetPacket(data, 0);
						packet.IsPacketRecived = true;
						this.i(packet);
						num = (short)1570897920;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_53;
					IL_C4:
					num = (short)1437936716;
					short num4 = num;
					num = (short)959917132;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_126;
					default:
						num = (short)1701183488;
						if (num != 0)
						{
						}
						num = (short)1989476354;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_126:
				goto IL_159;
				IL_53:
				data = (byte[])o;
				num = (short)94502913;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_3D;
			}
			catch
			{
				error.ErrCat = 300U;
				error.ErrorID = global::IACustomException.IACommonErrorCode.SSL_PE_UDPPackageError;
				global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle = this.j;
				if (errorReceivedHandle != null)
				{
					errorReceivedHandle(error);
				}
			}
			IL_159:
			num = (short)2053046273;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000171B4 File Offset: 0x000153B4
		private void a()
		{
			int a_ = 11;
			short num = (short)302907392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)79364096;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				global::System.DateTime now2;
				string text;
				global::System.Net.IPEndPoint ipendPoint;
				global::SSLMangrComp.ErrorReport error;
				for (;;)
				{
					IL_5B:
					switch (num2)
					{
					case 0:
						if (this.e)
						{
							num = (short)1916207106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240;
					case 1:
						goto IL_260;
					case 2:
						return;
					case 3:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_F6;
							}
							global::System.DateTime now;
							for (;;)
							{
								IL_E3:
								switch (num2)
								{
								case 0:
									if (now.Subtract(now2) >= this.g)
									{
										num = (short)1290928130;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									for (;;)
									{
										this.ShutdownServer();
										num = (short)1230072672;
										short num4 = num;
										num = (short)1392667488;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_1A4;
										}
									}
									IL_1A4:
									num = (short)2120286208;
									if (num != 0)
									{
									}
									num = (short)1665925121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1D2;
								case 2:
									goto IL_154;
								}
								goto IL_F6;
							}
							IL_154:
							throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_PackageTimeout)
							{
								Source = text
							};
							IL_1D2:
							goto IL_260;
							IL_F6:
							byte[] o = this.a.Receive(ref ipendPoint);
							this.HandlePackage(o);
							now = global::System.DateTime.Now;
							num = (short)545521664;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_E3;
						}
						catch (global::IACustomException.IACommonException)
						{
							error.ErrCat = 300U;
							error.ErrorID = global::IACustomException.IACommonErrorCode.SSL_PE_PackageTimeout;
							global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle = this.j;
							if (errorReceivedHandle != null)
							{
								errorReceivedHandle(error);
							}
							goto IL_260;
						}
						catch (global::System.Exception)
						{
							error.ErrCat = 300U;
							error.ErrorID = global::IACustomException.IACommonErrorCode.SSL_PE_UDPPackageError;
							global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2 = this.j;
							if (errorReceivedHandle2 != null)
							{
								errorReceivedHandle2(error);
							}
							goto IL_260;
						}
						finally
						{
							this.ShutdownServer();
						}
						goto IL_240;
					}
					goto IL_72;
					IL_240:
					num = (short)902561795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_260:
					num = (short)1640300545;
					if (num != 0)
					{
					}
					num = (short)972488704;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_72:
				error = default(global::SSLMangrComp.ErrorReport);
				text = base.GetType().ToString();
				text += global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ܼ猾⡀あㅄ≆❈", a_);
				now2 = global::System.DateTime.Now;
				this.a = new global::System.Net.Sockets.UdpClient(this.d);
				ipendPoint = new global::System.Net.IPEndPoint(global::System.Net.IPAddress.Any, 0);
				num = (short)1184825345;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5B;
			}
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000174D4 File Offset: 0x000156D4
		public void Connect(global::System.Net.IPAddress pnIpAddress, int portNumber, global::SSLMangrComp.SecureClientConfiguration clientConfig)
		{
			short num;
			for (;;)
			{
				global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
				try
				{
					this.Connect(pnIpAddress, portNumber);
				}
				catch (global::System.ArgumentException)
				{
					error.ErrCat = 200U;
					error.ErrorID = global::IACustomException.IACommonErrorCode.SSL_LE_UDPArgumentException;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle = this.j;
					if (errorReceivedHandle != null)
					{
						errorReceivedHandle(error);
					}
				}
				catch (global::System.Net.Sockets.SocketException)
				{
					error.ErrCat = 200U;
					error.ErrorID = global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2 = this.j;
					if (errorReceivedHandle2 != null)
					{
						errorReceivedHandle2(error);
					}
					num = (short)866058241;
					if (num != 0)
					{
					}
				}
				num = (short)461373440;
				short num2 = num;
				num = (short)1207821186;
				short num3 = num;
				num = (short)1733288834;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_FD;
				}
			}
			IL_FD:
			num = (short)1618214912;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00017610 File Offset: 0x00015810
		public void Connect(global::System.Net.IPAddress pnIpAddress, int portNumber)
		{
			short num = (short)1770651648;
			short num2 = num;
			num = (short)2132672513;
			if (num != 0)
			{
			}
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			try
			{
				switch (0)
				{
				case 0:
					goto IL_79;
				}
				int num3;
				for (;;)
				{
					IL_63:
					switch (num3)
					{
					case 0:
						goto IL_DB;
					case 1:
						if (this.a == null)
						{
							num = (short)440991747;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DB;
					case 2:
						goto IL_13D;
					case 3:
						this.a = new global::System.Net.Sockets.UdpClient(global::System.Net.Sockets.AddressFamily.InterNetwork);
						num = (short)340000768;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79;
					IL_DB:
					num = (short)1370720103;
					short num4 = num;
					num = (short)579962727;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13D;
					default:
						num = (short)1113063424;
						if (num != 0)
						{
						}
						num = (short)1317470210;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_13D:
				return;
				IL_79:
				this.b = pnIpAddress;
				this.c = portNumber;
				num = (short)992018433;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_63;
			}
			catch (global::System.ArgumentException)
			{
				error.ErrCat = 200U;
				error.ErrorID = global::IACustomException.IACommonErrorCode.SSL_LE_UDPArgumentException;
				global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle = this.j;
				if (errorReceivedHandle != null)
				{
					errorReceivedHandle(error);
				}
			}
			catch (global::System.Net.Sockets.SocketException)
			{
				error.ErrCat = 200U;
				error.ErrorID = global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket;
				global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2 = this.j;
				if (errorReceivedHandle2 != null)
				{
					errorReceivedHandle2(error);
				}
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000177DC File Offset: 0x000159DC
		public void WriteData(byte[] dataToWrite)
		{
			short num;
			try
			{
				num = (short)70430417;
				short num2 = num;
				num = (short)887926481;
				switch (num2 == num)
				{
				}
				num = (short)1304100865;
				if (num != 0)
				{
				}
				num = (short)459341824;
				if (num != 0)
				{
				}
				this.a.Send(dataToWrite, dataToWrite.Length, this.b.ToString(), this.c);
			}
			catch
			{
				global::SSLMangrComp.ErrorReport error = new global::SSLMangrComp.ErrorReport
				{
					ErrCat = 300U,
					ErrorID = global::IACustomException.IACommonErrorCode.SSL_PE_UDPDataSendFail
				};
				global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle = this.j;
				if (errorReceivedHandle != null)
				{
					errorReceivedHandle(error);
				}
			}
			num = (short)1102512128;
			short num3 = num;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000178F4 File Offset: 0x00015AF4
		public bool IsServerRunning()
		{
			short num = (short)99882573;
			short num2 = num;
			num = (short)1029772877;
			switch (num2 == num)
			{
			default:
			{
				num = (short)504430592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1062207489;
			if (num != 0)
			{
			}
			num = (short)1316028416;
			if (num != 0)
			{
			}
			return !this.e;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000179A4 File Offset: 0x00015BA4
		public int getPortNumber()
		{
			short num = (short)455459573;
			short num2 = num;
			num = (short)323732213;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1919942656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)379387904;
			if (num != 0)
			{
			}
			num = (short)1938620417;
			if (num != 0)
			{
			}
			return this.d;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00017A54 File Offset: 0x00015C54
		public void ShutdownClient()
		{
			short num = (short)1106657773;
			short num2 = num;
			num = (short)733233645;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1444413440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)616366080;
			if (num != 0)
			{
			}
			num = (short)1425801217;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00017B00 File Offset: 0x00015D00
		public void RegisterIncomingPacketHandler(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle hdl)
		{
			short num = (short)1064665192;
			short num2 = num;
			num = (short)1105625192;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1370750976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)41418753;
			if (num != 0)
			{
			}
			num = (short)2081030144;
			if (num != 0)
			{
			}
			this.PacketRecived += hdl;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00017BB0 File Offset: 0x00015DB0
		public void RegisterIncomingErrorHandler(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle hdl)
		{
			short num = (short)937914159;
			short num2 = num;
			num = (short)878538543;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1957756928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1300889601;
			if (num != 0)
			{
			}
			num = (short)191627264;
			if (num != 0)
			{
			}
			this.ErrorReceived += hdl;
		}

		// Token: 0x040000CD RID: 205
		private global::System.Net.Sockets.UdpClient a;

		// Token: 0x040000CE RID: 206
		private global::System.Net.IPAddress b;

		// Token: 0x040000CF RID: 207
		private int c;

		// Token: 0x040000D0 RID: 208
		private int d;

		// Token: 0x040000D1 RID: 209
		private bool e;

		// Token: 0x040000D2 RID: 210
		private global::System.Threading.Thread f;

		// Token: 0x040000D3 RID: 211
		private global::System.TimeSpan g;

		// Token: 0x040000D4 RID: 212
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ReportOnError_CallBack h;

		// Token: 0x040000D5 RID: 213
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle i;

		// Token: 0x040000D6 RID: 214
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle j;
	}
}
