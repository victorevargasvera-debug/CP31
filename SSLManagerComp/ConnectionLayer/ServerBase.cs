using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000042 RID: 66
	public class ServerBase
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00017C74 File Offset: 0x00015E74
		public void StartListener(int port)
		{
			short num = (short)1106028593;
			short num2 = num;
			num = (short)577546289;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1232011264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)19398657;
			if (num != 0)
			{
			}
			num = (short)194772992;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00017D24 File Offset: 0x00015F24
		public bool IsServerRunning()
		{
			short num = (short)818347228;
			short num2 = num;
			num = (short)511311068;
			switch (num2 == num)
			{
			}
			num = (short)631963648;
			short num3 = num;
			num = (short)788463617;
			if (num != 0)
			{
			}
			num = (short)1640497152;
			if (num != 0)
			{
			}
			return !this.m_stop;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00017DD8 File Offset: 0x00015FD8
		public void SignalCloseStream()
		{
			object shutdownLock = this.m_shutdownLock;
			bool flag = false;
			short num;
			try
			{
				global::System.Threading.Monitor.Enter(shutdownLock, ref flag);
				this._signalCloseStream = true;
			}
			finally
			{
				num = (short)860684290;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_FD;
					case 1:
						for (;;)
						{
							global::System.Threading.Monitor.Exit(shutdownLock);
							num = (short)270263785;
							short num3 = num;
							num = (short)268690921;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_A7;
							}
						}
						IL_A7:
						num = (short)1056833536;
						if (num != 0)
						{
						}
						num = (short)1852440577;
						if (num != 0)
						{
						}
						num = (short)366739456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					}
					IL_50:
					if (!flag)
					{
						break;
					}
					num = (short)1679491073;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FD:;
			}
			num = (short)1209466880;
			short num4 = num;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00017F20 File Offset: 0x00016120
		public int getPortNumber()
		{
			short num = (short)916193281;
			if (num != 0)
			{
			}
			num = (short)1671102464;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				case 1:
					goto IL_138;
				case 2:
					if (!(this.m_listener.LocalEndpoint is global::System.Net.IPEndPoint))
					{
						num = (short)1609170945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13F;
				case 3:
					return 0;
				}
				IL_5E:
				if (!this.IsServerRunning())
				{
					num = (short)42598403;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)679548028;
					short num3 = num;
					num = (short)689378428;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return 0;
					case 1:
						break;
					default:
					{
						num = (short)898826240;
						short num4 = num;
						break;
					}
					}
					num = (short)534970368;
					if (num != 0)
					{
					}
					num = (short)1549467650;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return 0;
			IL_138:
			return 0;
			IL_13F:
			return ((global::System.Net.IPEndPoint)this.m_listener.LocalEndpoint).Port;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00018084 File Offset: 0x00016284
		public void ShutdownServer()
		{
			short num = (short)436600832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				for (;;)
				{
					object shutdownLock = this.m_shutdownLock;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						for (;;)
						{
							IL_33:
							switch (num2)
							{
							case 0:
							{
								this.m_stop = true;
								global::System.Collections.Generic.List<global::SSLMangrComp.ConnectionLayer.IServerWorker>.Enumerator enumerator = this.readWorkers.GetEnumerator();
								num = (short)982450181;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								if (this.m_listener != null)
								{
									num = (short)1989541894;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_19E;
							case 2:
								goto IL_19E;
							case 3:
								if (this.IsServerRunning())
								{
									num = (short)1451753472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_260;
							case 4:
								goto IL_278;
							case 5:
								try
								{
									num = (short)244187138;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											num = (short)1258356740;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
										{
											global::System.Collections.Generic.List<global::SSLMangrComp.ConnectionLayer.IServerWorker>.Enumerator enumerator;
											if (!enumerator.MoveNext())
											{
												num = (short)266076160;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::SSLMangrComp.ConnectionLayer.IServerWorker serverWorker = enumerator.Current;
											num = (short)1192886275;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
											switch (0)
											{
											case 0:
												goto IL_DF;
											}
											continue;
										case 3:
										{
											global::SSLMangrComp.ConnectionLayer.IServerWorker serverWorker;
											if (serverWorker != null)
											{
												num = (short)1143537670;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 4:
											goto IL_18B;
										case 6:
										{
											global::SSLMangrComp.ConnectionLayer.IServerWorker serverWorker;
											serverWorker.Close();
											num = (short)338886661;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_118:
										num = (short)1587609601;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_DF:
										goto IL_118;
									}
									IL_18B:
									goto IL_219;
								}
								finally
								{
									global::System.Collections.Generic.List<global::SSLMangrComp.ConnectionLayer.IServerWorker>.Enumerator enumerator;
									((global::System.IDisposable)enumerator).Dispose();
								}
								goto IL_19E;
								IL_219:
								global::System.Threading.Thread.Sleep(500);
								num = (short)258342913;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								this.m_listener.Stop();
								num = (short)653590530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_260;
							}
							goto IL_5A;
							IL_19E:
							this._lsnrThread = null;
							num = (short)1031798791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_260:
							num = (short)1116012548;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_278:
						goto IL_2E7;
						IL_5A:
						global::System.Threading.Monitor.Enter(shutdownLock, ref flag);
						num = (short)308871171;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_33;
					}
					finally
					{
						num = (short)2064121858;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_2E4;
							case 1:
								global::System.Threading.Monitor.Exit(shutdownLock);
								num = (short)1874132992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_2AD;
								}
								continue;
							}
							IL_2AD:
							if (!flag)
							{
								break;
							}
							num = (short)404946945;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2E4:;
					}
					IL_2E7:
					num = (short)337627354;
					short num3 = num;
					num = (short)1451870426;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_31C;
					}
				}
				IL_31C:
				num = (short)750780416;
				short num4 = num;
				num = (short)1739718657;
				if (num != 0)
				{
				}
				num = (short)697958400;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x040000D7 RID: 215
		protected bool m_stop = true;

		// Token: 0x040000D8 RID: 216
		protected bool _signalCloseStream;

		// Token: 0x040000D9 RID: 217
		protected global::System.Threading.Thread _lsnrThread;

		// Token: 0x040000DA RID: 218
		protected global::System.Net.Sockets.TcpListener m_listener;

		// Token: 0x040000DB RID: 219
		protected global::System.Net.IPAddress m_pnIPAddress;

		// Token: 0x040000DC RID: 220
		protected global::SSLMangrComp.Packets.SubscriptionType m_LMode;

		// Token: 0x040000DD RID: 221
		protected object m_shutdownLock = new object();

		// Token: 0x040000DE RID: 222
		protected object m_listenLock = new object();

		// Token: 0x040000DF RID: 223
		protected object packetLock = new object();

		// Token: 0x040000E0 RID: 224
		protected object errorLock = new object();

		// Token: 0x040000E1 RID: 225
		protected global::SSLMangrComp.PNConnectionInfo serverInfo;

		// Token: 0x040000E2 RID: 226
		protected global::System.Collections.Generic.List<global::SSLMangrComp.ConnectionLayer.IServerWorker> readWorkers = new global::System.Collections.Generic.List<global::SSLMangrComp.ConnectionLayer.IServerWorker>();
	}
}
