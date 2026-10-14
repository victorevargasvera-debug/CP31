using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using IACustomException;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000044 RID: 68
	public class TCPWorker : global::SSLMangrComp.ConnectionLayer.IServerWorker
	{
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060001A5 RID: 421 RVA: 0x000192F8 File Offset: 0x000174F8
		// (remove) Token: 0x060001A6 RID: 422 RVA: 0x00019430 File Offset: 0x00017630
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle ReadPacketReceived
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_39;
						case 1:
							goto IL_FF;
						case 2:
						{
							global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
							if (packetRecivedHandle == packetRecivedHandle2)
							{
								num2 = (short)2127822849;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_39;
						}
						}
						break;
						IL_39:
						num2 = (short)971914065;
						short num3 = num2;
						num2 = (short)51198801;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)217645056;
							if (num2 != 0)
							{
							}
							global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2 = packetRecivedHandle;
							global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Combine(packetRecivedHandle2, value);
							packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.a, value2, packetRecivedHandle2);
							num2 = (short)285999105;
							if (num2 != 0)
							{
							}
							num2 = (short)1751842818;
							num = (int)((global::System.IntPtr)num2);
							break;
						}
						}
					}
					IL_1C:
					packetRecivedHandle = this.a;
					num2 = (short)7864320;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_FF:
				num2 = (short)1504444416;
				short num4 = num2;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_60;
						case 1:
							goto IL_100;
						case 2:
						{
							global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
							if (packetRecivedHandle == packetRecivedHandle2)
							{
								num2 = (short)1241251841;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_60;
						}
						}
						break;
						IL_60:
						num2 = (short)1212432751;
						short num3 = num2;
						num2 = (short)1546994031;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)1490550784;
							if (num2 != 0)
							{
							}
							global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2 = packetRecivedHandle;
							global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Remove(packetRecivedHandle2, value);
							packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.a, value2, packetRecivedHandle2);
							num2 = (short)1438973954;
							num = (int)((global::System.IntPtr)num2);
							break;
						}
						}
					}
					IL_1C:
					packetRecivedHandle = this.a;
					num2 = (short)810876929;
					if (num2 != 0)
					{
					}
					num2 = (short)435486720;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_100:
				num2 = (short)293339136;
				short num4 = num2;
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060001A7 RID: 423 RVA: 0x00019568 File Offset: 0x00017768
		// (remove) Token: 0x060001A8 RID: 424 RVA: 0x000196A0 File Offset: 0x000178A0
		public event global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle ErrorReceived
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_61;
						case 1:
							goto IL_FD;
						case 2:
						{
							global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
							if (errorReceivedHandle == errorReceivedHandle2)
							{
								num2 = (short)959709185;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_61;
						}
						}
						break;
						IL_61:
						num2 = (short)1825689792;
						short num3 = num2;
						num2 = (short)668324032;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)318963712;
							if (num2 != 0)
							{
							}
							global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2 = errorReceivedHandle;
							global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Combine(errorReceivedHandle2, value);
							errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.b, value2, errorReceivedHandle2);
							num2 = (short)162594818;
							num = (int)((global::System.IntPtr)num2);
							break;
						}
						}
					}
					IL_1C:
					num2 = (short)1230635009;
					if (num2 != 0)
					{
					}
					errorReceivedHandle = this.b;
					num2 = (short)1657733120;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_FD:
				num2 = (short)1268449280;
				short num4 = num2;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_60;
						case 1:
							goto IL_FD;
						case 2:
						{
							global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
							if (errorReceivedHandle == errorReceivedHandle2)
							{
								num2 = (short)395771905;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_60;
						}
						}
						break;
						IL_60:
						num2 = (short)662356701;
						short num3 = num2;
						num2 = (short)393331421;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)1685192704;
							if (num2 != 0)
							{
							}
							global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2 = errorReceivedHandle;
							global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Remove(errorReceivedHandle2, value);
							errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.b, value2, errorReceivedHandle2);
							num2 = (short)1642725378;
							num = (int)((global::System.IntPtr)num2);
							break;
						}
						}
					}
					IL_1C:
					errorReceivedHandle = this.b;
					num2 = (short)1351155713;
					if (num2 != 0)
					{
					}
					num2 = (short)1270153216;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_FD:
				num2 = (short)1675886592;
				short num4 = num2;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000197D8 File Offset: 0x000179D8
		public TCPWorker(global::System.Net.Sockets.TcpClient client)
		{
			this.TcpClient = client;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000197F4 File Offset: 0x000179F4
		public void Read()
		{
			short num = (short)833282130;
			short num2 = num;
			num = (short)532275282;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1784807424;
				short num3 = num;
				break;
			}
			}
			num = (short)269025280;
			if (num != 0)
			{
			}
			num = (short)2067333120;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
				byte[] array = new byte[1024];
				global::SSLMangrComp.ConnectionLayer.b b = new global::SSLMangrComp.ConnectionLayer.b(2048);
				global::System.Net.Sockets.NetworkStream stream = this.TcpClient.GetStream();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_10A;
					}
					int num5;
					for (;;)
					{
						IL_C7:
						byte[] data;
						switch (num4)
						{
						case 0:
							b.a(array, num5);
							data = null;
							num = (short)610009097;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							try
							{
								num5 = stream.Read(array, 0, array.Length);
								goto IL_2B4;
							}
							catch (global::System.Exception)
							{
								goto IL_2F0;
							}
							goto IL_179;
							IL_2B4:
							num = (short)1238892551;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_128;
						case 3:
							if (num5 > 0)
							{
								num = (short)703397893;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F0;
						case 4:
							if ((data = b.b()) == null)
							{
								num = (short)836370445;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1449459726;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)799277062;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (this.c)
							{
								num = (short)1648820234;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1381695489;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (num5 > 0)
							{
								num = (short)1148846080;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F0;
						case 8:
							goto IL_218;
						case 9:
							goto IL_218;
						case 10:
							goto IL_2F0;
						case 11:
							goto IL_179;
						case 12:
							goto IL_319;
						case 13:
							goto IL_128;
						case 14:
							if (this.a != null)
							{
								num = (short)1913389067;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_218;
						}
						goto IL_10A;
						IL_128:
						num = (short)2023292931;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_179:
						global::SSLMangrComp.Packets.PacketBase packet = global::SSLMangrComp.Packets.PacketFactory.GetPacket(data, 2);
						packet.IsPacketRecived = true;
						this.a(packet);
						num = (short)614793224;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_218:
						num = (short)276496388;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_2F0:
						stream.Close();
						this.TcpClient.Close();
						num = (short)567476236;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_319:
					break;
					IL_10A:
					num5 = 10000;
					num = (short)297992194;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_C7;
				}
				catch (global::IACustomException.IACommonException)
				{
					error.ErrCat = 300U;
					error.ErrorID = global::IACustomException.IACommonErrorCode.SSL_PE_TLSProtocolFailed;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle = this.b;
					if (errorReceivedHandle != null)
					{
						errorReceivedHandle(error);
					}
					stream.Close();
					this.TcpClient.Close();
				}
				catch (global::System.Exception)
				{
					error.ErrCat = 300U;
					error.ErrorID = global::IACustomException.IACommonErrorCode.SSL_PE_TLSProtocolFailed;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2 = this.b;
					if (errorReceivedHandle2 != null)
					{
						errorReceivedHandle2(error);
					}
					num = (short)1614938113;
					if (num != 0)
					{
					}
					stream.Close();
					this.TcpClient.Close();
				}
				break;
			}
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00019C18 File Offset: 0x00017E18
		public void Close()
		{
			short num = (short)1955126945;
			short num2 = num;
			num = (short)1297079969;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_60:
				switch (0)
				{
				case 0:
					goto IL_94;
				}
				break;
			default:
				num = (short)413138944;
				if (num != 0)
				{
				}
				num = (short)1518272512;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_6A:
				switch (num3)
				{
				case 0:
					goto IL_60;
				case 1:
					this.TcpClient.GetStream().Close();
					num = (short)32833539;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)494534662;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_161;
				case 4:
					if (this.TcpClient.Connected)
					{
						num = (short)973996033;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					if (this.TcpClient.Available > 0)
					{
						num = (short)238551047;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B5;
				case 6:
					if (this.TcpClient.Connected)
					{
						num = (short)1140916232;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B5;
				case 7:
					goto IL_1F8;
				case 8:
				{
					num = (short)1450180608;
					short num4 = num;
					num = (short)552665089;
					if (num != 0)
					{
					}
					num = (short)222363653;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_94;
				IL_B5:
				num = (short)343801860;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_161:
			return;
			IL_1F8:
			this.c = true;
			return;
			IL_94:
			if (this.TcpClient != null)
			{
				num = (short)490405890;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_6A;
			}
		}

		// Token: 0x040000E5 RID: 229
		public global::System.Net.Sockets.TcpClient TcpClient;

		// Token: 0x040000E6 RID: 230
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle a;

		// Token: 0x040000E7 RID: 231
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle b;

		// Token: 0x040000E8 RID: 232
		private bool c;
	}
}
