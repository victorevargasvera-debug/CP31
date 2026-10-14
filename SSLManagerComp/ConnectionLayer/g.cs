using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000043 RID: 67
	internal class g : global::SSLMangrComp.ConnectionLayer.ServerBase, global::SSLMangrComp.ConnectionLayer.f
	{
		// Token: 0x06000199 RID: 409 RVA: 0x0001849C File Offset: 0x0001669C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void c(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle A_0)
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
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
					if (packetRecivedHandle == packetRecivedHandle2)
					{
						num2 = (short)75366400;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_60;
				}
				case 2:
					num2 = (short)1278738433;
					if (num2 != 0)
					{
					}
					goto IL_60;
				}
				goto IL_1C;
				IL_60:
				num2 = (short)904056447;
				short num3 = num2;
				num2 = (short)2087243391;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)1269497856;
					if (num2 != 0)
					{
					}
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2 = packetRecivedHandle;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Combine(packetRecivedHandle2, A_0);
					packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.a, value, packetRecivedHandle2);
					break;
				}
				}
				num2 = (short)846331904;
				short num4 = num2;
				num2 = (short)871366657;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			packetRecivedHandle = this.a;
			num2 = (short)2037252098;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000185D4 File Offset: 0x000167D4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void d(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FF;
				case 1:
				{
					num2 = (short)287768576;
					short num3 = num2;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
					if (packetRecivedHandle == packetRecivedHandle2)
					{
						num2 = (short)1517682688;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_39;
				}
				case 2:
					goto IL_39;
				}
				goto IL_1C;
				IL_39:
				num2 = (short)170756467;
				short num4 = num2;
				num2 = (short)1638173043;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)1393295360;
					if (num2 != 0)
					{
					}
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2 = packetRecivedHandle;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Remove(packetRecivedHandle2, A_0);
					packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.a, value, packetRecivedHandle2);
					break;
				}
				}
				num2 = (short)1831731201;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FF:
			num2 = (short)863633409;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			packetRecivedHandle = this.a;
			num2 = (short)81461250;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001870C File Offset: 0x0001690C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void d(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
					if (errorReceivedHandle == errorReceivedHandle2)
					{
						num2 = (short)1122435072;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3A;
				}
				case 2:
					goto IL_3A;
				}
				goto IL_1C;
				IL_3A:
				num2 = (short)17084956;
				short num3 = num2;
				num2 = (short)225686044;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)726990848;
					if (num2 != 0)
					{
					}
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2 = errorReceivedHandle;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Combine(errorReceivedHandle2, A_0);
					errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.b, value, errorReceivedHandle2);
					break;
				}
				}
				num2 = (short)1872297985;
				if (num2 != 0)
				{
				}
				num2 = (short)1713373184;
				short num4 = num2;
				num2 = (short)1254031361;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			errorReceivedHandle = this.b;
			num2 = (short)1336213506;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00018844 File Offset: 0x00016A44
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void e(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
					if (errorReceivedHandle == errorReceivedHandle2)
					{
						num2 = (short)1642266624;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_62;
				}
				case 2:
					goto IL_62;
				}
				goto IL_1C;
				IL_62:
				num2 = (short)350735803;
				short num3 = num2;
				num2 = (short)1640680891;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)177799168;
					if (num2 != 0)
					{
					}
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2 = errorReceivedHandle;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Remove(errorReceivedHandle2, A_0);
					errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.b, value, errorReceivedHandle2);
					break;
				}
				}
				num2 = (short)178192384;
				short num4 = num2;
				num2 = (short)1239547905;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)1416036353;
			if (num2 != 0)
			{
			}
			errorReceivedHandle = this.b;
			num2 = (short)644677634;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00018980 File Offset: 0x00016B80
		public new void StartListener(int port)
		{
			short num = (short)188970114;
			short num2 = num;
			num = (short)739013762;
			switch (num2 == num)
			{
			}
			num = (short)1486094336;
			short num3 = num;
			num = (short)1143930881;
			if (num != 0)
			{
			}
			num = (short)1655439360;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00018A30 File Offset: 0x00016C30
		public void a(global::SSLMangrComp.PNConnectionInfo A_0)
		{
			short num = (short)518117360;
			short num2 = num;
			num = (short)852547568;
			switch (num2 == num)
			{
			}
			num = (short)423034880;
			short num3 = num;
			num = (short)425066497;
			if (num != 0)
			{
			}
			num = (short)664600576;
			if (num != 0)
			{
			}
			this.serverInfo = A_0;
			base.ShutdownServer();
			this._lsnrThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.c));
			this._lsnrThread.Start();
			global::System.Threading.Thread.Sleep(500);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00018B10 File Offset: 0x00016D10
		private void c()
		{
			short num = (short)183042048;
			short num2 = num;
			num = (short)50069504;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
				try
				{
					object listenLock = this.m_listenLock;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_83;
						}
						for (;;)
						{
							IL_68:
							switch (num3)
							{
							case 0:
							{
								if (!this.m_stop)
								{
									global::System.Net.Sockets.TcpClient client = this.m_listener.AcceptTcpClient();
									global::System.Threading.Thread.Sleep(500);
									global::SSLMangrComp.ConnectionLayer.TCPWorker tcpworker = new global::SSLMangrComp.ConnectionLayer.TCPWorker(client);
									tcpworker.ReadPacketReceived += this.c;
									new global::System.Threading.Thread(new global::System.Threading.ThreadStart(tcpworker.Read)).Start();
									this.readWorkers.Add(tcpworker);
									num = (short)1106247684;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1906257726;
								short num4 = num;
								num = (short)1226846014;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1DF;
								default:
									num = (short)1571946496;
									if (num != 0)
									{
									}
									num = (short)1676673027;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_132;
							case 2:
								goto IL_1DF;
							case 3:
								this.m_listener.Stop();
								num = (short)1843855362;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_132;
							}
							goto IL_83;
							IL_132:
							num = (short)334692352;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1DF:
						goto IL_24C;
						IL_83:
						global::System.Threading.Monitor.Enter(listenLock, ref flag);
						this.m_stop = false;
						this.m_listener = new global::System.Net.Sockets.TcpListener(global::System.Net.IPAddress.Any, 0);
						this.m_listener.Start(20);
						num = (short)420806657;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_68;
					}
					finally
					{
						num = (short)1399980034;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_249;
							case 1:
								global::System.Threading.Monitor.Exit(listenLock);
								num = (short)307822592;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_213;
								}
								continue;
							}
							IL_213:
							if (!flag)
							{
								break;
							}
							num = (short)782041089;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_249:;
					}
					IL_24C:;
				}
				catch (global::System.Exception ex)
				{
					if (!(ex is global::System.Net.Sockets.SocketException) || ((global::System.Net.Sockets.SocketException)ex).ErrorCode != 10004)
					{
						error.ErrCat = 200U;
						global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle = this.b;
						if (errorReceivedHandle != null)
						{
							errorReceivedHandle(error);
						}
						base.ShutdownServer();
					}
				}
				num = (short)242089985;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00018E14 File Offset: 0x00017014
		public void b(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle A_0)
		{
			short num = (short)702798270;
			short num2 = num;
			num = (short)552851902;
			switch (num2 == num)
			{
			}
			num = (short)1605763072;
			short num3 = num;
			num = (short)244645889;
			if (num != 0)
			{
			}
			num = (short)1258160128;
			if (num != 0)
			{
			}
			this.c(A_0);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00018EC8 File Offset: 0x000170C8
		public void c(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle A_0)
		{
			short num = (short)947710319;
			short num2 = num;
			num = (short)215279983;
			switch (num2 == num)
			{
			}
			num = (short)1258291200;
			short num3 = num;
			num = (short)1954545665;
			if (num != 0)
			{
			}
			num = (short)2129264640;
			if (num != 0)
			{
			}
			this.d(A_0);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00018F7C File Offset: 0x0001717C
		protected void c(global::SSLMangrComp.Packets.PacketBase A_0)
		{
			object packetLock = this.packetLock;
			bool flag = false;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_27;
				}
				int num;
				for (;;)
				{
					IL_15:
					switch (num)
					{
					case 0:
						goto IL_B0;
					case 1:
						goto IL_8D;
					case 2:
					{
						global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle = this.a;
						if (packetRecivedHandle == null)
						{
							num2 = (short)793247745;
							if (num2 != 0)
							{
							}
							num2 = (short)146735105;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						packetRecivedHandle(A_0);
						num2 = (short)2007695360;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_27;
				}
				IL_8D:
				IL_B0:
				goto IL_16E;
				IL_27:
				global::System.Threading.Monitor.Enter(packetLock, ref flag);
				num2 = (short)916062210;
				num = (int)((global::System.IntPtr)num2);
				goto IL_15;
			}
			finally
			{
				num2 = (short)2044002306;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_16B;
					case 1:
						for (;;)
						{
							global::System.Threading.Monitor.Exit(packetLock);
							num2 = (short)1779226444;
							short num3 = num2;
							num2 = (short)400283468;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_13E;
							}
						}
						IL_13E:
						num2 = (short)1995767808;
						if (num2 != 0)
						{
						}
						num2 = (short)1448738816;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_E6;
						}
						continue;
					}
					IL_E6:
					if (!flag)
					{
						break;
					}
					num2 = (short)870383617;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_16B:;
			}
			IL_16E:
			num2 = (short)1819213824;
			short num4 = num2;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00019130 File Offset: 0x00017330
		protected void c(global::SSLMangrComp.ErrorReport A_0)
		{
			short num = (short)1464336384;
			short num2 = num;
			object errorLock = this.errorLock;
			bool flag = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				int num3;
				for (;;)
				{
					IL_3E:
					switch (num3)
					{
					case 0:
						goto IL_D6;
					case 1:
						goto IL_8D;
					case 2:
					{
						global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle = this.b;
						if (errorReceivedHandle == null)
						{
							num = (short)385744897;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						errorReceivedHandle(A_0);
						num = (short)205848576;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_50;
				}
				IL_8D:
				num = (short)1673658369;
				if (num != 0)
				{
				}
				IL_D6:
				return;
				IL_50:
				global::System.Threading.Monitor.Enter(errorLock, ref flag);
				num = (short)285671426;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_3E;
			}
			finally
			{
				num = (short)581435394;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_191;
					case 1:
						for (;;)
						{
							global::System.Threading.Monitor.Exit(errorLock);
							num = (short)684098840;
							short num4 = num;
							num = (short)1517454616;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_163;
							}
						}
						IL_163:
						num = (short)880738304;
						if (num != 0)
						{
						}
						num = (short)1724973056;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_10C;
						}
						continue;
					}
					IL_10C:
					if (!flag)
					{
						break;
					}
					num = (short)1443561473;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_191:;
			}
		}

		// Token: 0x040000E3 RID: 227
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle a;

		// Token: 0x040000E4 RID: 228
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle b;
	}
}
