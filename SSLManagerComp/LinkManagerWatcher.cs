using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using IACustomException;
using SSLMangrComp.ConnectionLayer;
using SSLMangrComp.Connectors;
using SSLMangrComp.Packets;

namespace SSLMangrComp
{
	// Token: 0x02000016 RID: 22
	public class LinkManagerWatcher
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600009F RID: 159 RVA: 0x0000A53C File Offset: 0x0000873C
		// (remove) Token: 0x060000A0 RID: 160 RVA: 0x0000A670 File Offset: 0x00008870
		public event global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle PacketSentOrRecived
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
					global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle packetSendOrRecievedHandle;
					for (;;)
					{
						IL_0A:
						global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle packetSendOrRecievedHandle2;
						switch (num)
						{
						case 0:
							goto IL_D9;
						case 1:
							if (packetSendOrRecievedHandle == packetSendOrRecievedHandle2)
							{
								num2 = (short)2088108032;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_8A;
						case 2:
							num2 = (short)1460666369;
							if (num2 != 0)
							{
							}
							goto IL_8A;
						}
						goto IL_1C;
						IL_8A:
						packetSendOrRecievedHandle2 = packetSendOrRecievedHandle;
						global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle value2 = (global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle)global::System.Delegate.Combine(packetSendOrRecievedHandle2, value);
						packetSendOrRecievedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle>(ref this.a, value2, packetSendOrRecievedHandle2);
						num2 = (short)694222849;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_D9:
					num2 = (short)1898011109;
					short num3 = num2;
					num2 = (short)331700709;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_110;
					}
					IL_1C:
					packetSendOrRecievedHandle = this.a;
					num2 = (short)1128660992;
					short num4 = num2;
					num2 = (short)1118699522;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_110:
				num2 = (short)385810432;
				if (num2 != 0)
				{
				}
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
				global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle packetSendOrRecievedHandle;
				short num2;
				for (;;)
				{
					IL_0A:
					global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle packetSendOrRecievedHandle2;
					switch (num)
					{
					case 0:
						if (packetSendOrRecievedHandle == packetSendOrRecievedHandle2)
						{
							goto IL_113;
						}
						goto IL_8C;
					case 1:
						return;
					case 2:
						goto IL_8C;
					}
					goto IL_1C;
					IL_8C:
					packetSendOrRecievedHandle2 = packetSendOrRecievedHandle;
					global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle value2 = (global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle)global::System.Delegate.Remove(packetSendOrRecievedHandle2, value);
					packetSendOrRecievedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle>(ref this.a, value2, packetSendOrRecievedHandle2);
					num2 = (short)972313601;
					short num3 = num2;
					num2 = (short)1499747329;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_113:
						num2 = (short)62914561;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
						num2 = (short)716963840;
						if (num2 != 0)
						{
						}
						num2 = (short)1565327360;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				num2 = (short)1875116033;
				if (num2 != 0)
				{
				}
				num2 = (short)346554368;
				short num4 = num2;
				packetSendOrRecievedHandle = this.a;
				num2 = (short)1664352258;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060000A1 RID: 161 RVA: 0x0000A7AC File Offset: 0x000089AC
		// (remove) Token: 0x060000A2 RID: 162 RVA: 0x0000A8E4 File Offset: 0x00008AE4
		public event global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle ErrorReceived
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
				global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle errorRecievedHandle;
				short num2;
				for (;;)
				{
					IL_0A:
					global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle errorRecievedHandle2;
					switch (num)
					{
					case 0:
						if (errorRecievedHandle == errorRecievedHandle2)
						{
							goto IL_10F;
						}
						goto IL_62;
					case 1:
						return;
					case 2:
						goto IL_62;
					}
					goto IL_1C;
					IL_62:
					errorRecievedHandle2 = errorRecievedHandle;
					global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle value2 = (global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle)global::System.Delegate.Combine(errorRecievedHandle2, value);
					errorRecievedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle>(ref this.b, value2, errorRecievedHandle2);
					num2 = (short)1318362337;
					short num3 = num2;
					num2 = (short)114924769;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_10F:
						num2 = (short)1952120833;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
						num2 = (short)109707265;
						if (num2 != 0)
						{
						}
						num2 = (short)1182072832;
						if (num2 != 0)
						{
						}
						num2 = (short)1996750848;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				errorRecievedHandle = this.b;
				num2 = (short)1462435840;
				short num4 = num2;
				num2 = (short)53280770;
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
				short num2;
				global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle errorRecievedHandle;
				for (;;)
				{
					IL_0A:
					global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle errorRecievedHandle2;
					switch (num)
					{
					case 0:
						num2 = (short)734134273;
						if (num2 != 0)
						{
						}
						if (errorRecievedHandle == errorRecievedHandle2)
						{
							goto IL_111;
						}
						goto IL_63;
					case 1:
						return;
					case 2:
						goto IL_63;
					}
					goto IL_1C;
					IL_63:
					errorRecievedHandle2 = errorRecievedHandle;
					global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle value2 = (global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle)global::System.Delegate.Remove(errorRecievedHandle2, value);
					errorRecievedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle>(ref this.b, value2, errorRecievedHandle2);
					num2 = (short)2011237507;
					short num3 = num2;
					num2 = (short)560729219;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_111:
						num2 = (short)107741185;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
						num2 = (short)1836580864;
						if (num2 != 0)
						{
						}
						num2 = (short)1239154688;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				errorRecievedHandle = this.b;
				num2 = (short)1941962752;
				short num4 = num2;
				num2 = (short)798425090;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000AA1C File Offset: 0x00008C1C
		public global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase> ActiveSubscriptionList
		{
			get
			{
				short num = (short)1117533034;
				short num2 = num;
				num = (short)1763455850;
				switch (num2 == num)
				{
				}
				num = (short)1311244288;
				short num3 = num;
				num = (short)1216872449;
				if (num != 0)
				{
				}
				num = (short)347013120;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000AB80 File Offset: 0x00008D80
		public global::SSLMangrComp.PNConnectionInfo ServerInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1613496668;
				short num2 = num;
				num = (short)1557659996;
				switch (num2 == num)
				{
				}
				num = (short)488046592;
				short num3 = num;
				num = (short)2146304001;
				if (num != 0)
				{
				}
				num = (short)799145984;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)140148530;
				short num2 = num;
				num = (short)800554802;
				switch (num2 == num)
				{
				}
				num = (short)102498304;
				short num3 = num;
				num = (short)832634880;
				if (num != 0)
				{
				}
				num = (short)668794881;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000AC34 File Offset: 0x00008E34
		private global::SSLMangrComp.Packets.SubscriptionType Mode
		{
			get
			{
				short num = (short)1721856244;
				short num2 = num;
				num = (short)881815796;
				switch (num2 == num)
				{
				}
				num = (short)1367277568;
				short num3 = num;
				num = (short)1030094849;
				if (num != 0)
				{
				}
				num = (short)1217134592;
				if (num != 0)
				{
				}
				return this.ServerInfo.PNConnectionConfig.SubscriptionMode;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public void ShutDownListen()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return;
				case 1:
					num2 = (short)1306787841;
					if (num2 != 0)
					{
					}
					num2 = (short)863436802;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (global::SSLMangrComp.LinkManagerWatcher.e.IsServerRunning())
					{
						num2 = (short)586743811;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_163;
				case 4:
					if (global::SSLMangrComp.LinkManagerWatcher.e != null)
					{
						num2 = (short)1269432321;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_24;
			}
			return;
			IL_24:
			this.c.Clear();
			num2 = (short)103698583;
			short num3 = num2;
			num2 = (short)759713943;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_163:
				global::SSLMangrComp.LinkManagerWatcher.e.ShutdownServer();
				num2 = (short)983498752;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1861025792;
				short num4 = num2;
				num2 = (short)511574016;
				if (num2 != 0)
				{
				}
				num2 = (short)520224772;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000AE60 File Offset: 0x00009060
		public void Subscribe(string events)
		{
			short num;
			for (;;)
			{
				global::SSLMangrComp.ErrorReport errorReport = default(global::SSLMangrComp.ErrorReport);
				global::SSLMangrComp.Packets.SubscriptionPacket a_ = this.a(this.ServerInfo.PNConnectionConfig, events);
				try
				{
					this.a(a_);
				}
				catch (global::System.ArgumentException)
				{
					errorReport.ErrCat = 200U;
					errorReport.ErrorID = global::IACustomException.IACommonErrorCode.SSL_LE_UDPArgumentException;
					global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle errorRecievedHandle = this.b;
					if (errorRecievedHandle != null)
					{
						errorRecievedHandle(errorReport);
					}
				}
				catch (global::System.Net.Sockets.SocketException)
				{
					errorReport.ErrCat = 200U;
					errorReport.ErrorID = global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket;
					global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle errorRecievedHandle2 = this.b;
					if (errorRecievedHandle2 != null)
					{
						errorRecievedHandle2(errorReport);
					}
				}
				catch (global::System.Exception)
				{
					errorReport.ErrCat = 200U;
					errorReport.ErrorID = global::IACustomException.IACommonErrorCode.SSL_TLSClientInternalFailure;
					global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle errorRecievedHandle3 = this.b;
					if (errorRecievedHandle3 != null)
					{
						errorRecievedHandle3(errorReport);
					}
				}
				num = (short)496914120;
				short num2 = num;
				num = (short)630083272;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_F1;
				}
			}
			IL_F1:
			num = (short)2120220672;
			short num3 = num;
			num = (short)112394241;
			if (num != 0)
			{
			}
			num = (short)1589903360;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000AFF0 File Offset: 0x000091F0
		private global::SSLMangrComp.Packets.SubscriptionPacket a(global::SSLMangrComp.ConnectionConfig A_0, string A_1)
		{
			short num = (short)650772481;
			if (num != 0)
			{
			}
			num = (short)947962933;
			short num2 = num;
			num = (short)921420853;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2098921472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)995622912;
			if (num != 0)
			{
			}
			global::SSLMangrComp.Packets.SubscriptionPacket subscriptionPacket = new global::SSLMangrComp.Packets.ReliableSubscriptionPacket(this.a(), this.f, A_0.Expiration, A_0.EntityType, A_0.EntityValue, A_1)
			{
				Type = A_0.SubscriptionMode
			};
			this.c.Add(subscriptionPacket);
			return subscriptionPacket;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000B0D8 File Offset: 0x000092D8
		public void CancelAllSubscriptions()
		{
			short num = (short)1069744129;
			if (num != 0)
			{
			}
			num = (short)652804096;
			switch (num)
			{
			default:
			{
				num = (short)1829765120;
				short num2 = num;
				global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase> list = new global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase>();
				global::System.Collections.Generic.IEnumerator<global::SSLMangrComp.Packets.SubscriptionPacket> enumerator = this.c.OfType<global::SSLMangrComp.Packets.SubscriptionPacket>().GetEnumerator();
				try
				{
					num = (short)2047475716;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)472186883;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)374734848;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SSLMangrComp.Packets.SubscriptionPacket subscriptionPacket = enumerator.Current;
							global::SSLMangrComp.Packets.SubscriptionPacket a_ = subscriptionPacket.CreateCancelSubscription();
							this.a(a_);
							global::System.Threading.Thread.Sleep(1750);
							list.Add(subscriptionPacket);
							num = (short)44892162;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_2DB;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_24C;
							}
							continue;
						}
						IL_24E:
						num = (short)1206845441;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_24C:
						goto IL_24E;
					}
					IL_2DB:
					goto IL_1FF;
				}
				finally
				{
					num = (short)766246914;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)854523905;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_348;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_312;
							}
							continue;
						}
						IL_312:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1528954880;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_348:;
				}
				return;
				for (;;)
				{
					IL_1FF:
					enumerator = list.OfType<global::SSLMangrComp.Packets.SubscriptionPacket>().GetEnumerator();
					try
					{
						num = (short)67174404;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								num = (short)1826095107;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1933115392;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::SSLMangrComp.Packets.SubscriptionPacket item = enumerator.Current;
								this.c.Remove(item);
								num = (short)2046361602;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_13F;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_C2;
								}
								continue;
							}
							IL_C4:
							num = (short)1190592513;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_C2:
							goto IL_C4;
						}
						IL_13F:
						break;
					}
					finally
					{
						num = (short)986447874;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								enumerator.Dispose();
								num = (short)2075277725;
								short num4 = num;
								num = (short)269498781;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1FC;
								default:
									num = (short)725286912;
									if (num != 0)
									{
									}
									num = (short)1790377985;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_1FC;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_177;
								}
								continue;
							}
							IL_177:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1113915392;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1FC:;
					}
				}
				return;
			}
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000B44C File Offset: 0x0000964C
		public void CancelExistingSubscription(global::System.Collections.Generic.List<string> radioList)
		{
			short num = (short)1647640576;
			switch (num)
			{
			default:
			{
				num = (short)108462080;
				short num2 = num;
				global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase> list = new global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase>();
				global::System.Collections.Generic.IEnumerator<global::SSLMangrComp.Packets.SubscriptionPacket> enumerator = this.c.OfType<global::SSLMangrComp.Packets.SubscriptionPacket>().GetEnumerator();
				try
				{
					num = (short)270991366;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)772931588;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SSLMangrComp.Packets.SubscriptionPacket subscriptionPacket = enumerator.Current;
							num = (short)301793283;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::SSLMangrComp.Packets.SubscriptionPacket subscriptionPacket;
							global::SSLMangrComp.Packets.SubscriptionPacket a_ = ((global::SSLMangrComp.Packets.ReliableSubscriptionPacket)subscriptionPacket).CreateCancelSubscription();
							this.a(a_);
							global::System.Threading.Thread.Sleep(1750);
							list.Add(subscriptionPacket);
							num = (short)1902247937;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::SSLMangrComp.Packets.SubscriptionPacket subscriptionPacket;
							if (radioList.Contains(subscriptionPacket.EntityValue))
							{
								num = (short)1363345410;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							num = (short)1152450565;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_30A;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_22F;
							}
							continue;
						}
						IL_2B4:
						num = (short)1960837120;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_22F:
						goto IL_2B4;
					}
					IL_30A:
					goto IL_1DB;
				}
				finally
				{
					num = (short)776208385;
					if (num != 0)
					{
					}
					num = (short)1369964546;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1314127873;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_39F;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_369;
							}
							continue;
						}
						IL_369:
						if (enumerator == null)
						{
							break;
						}
						num = (short)615710720;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_39F:;
				}
				return;
				for (;;)
				{
					IL_1DB:
					enumerator = list.OfType<global::SSLMangrComp.Packets.SubscriptionPacket>().GetEnumerator();
					try
					{
						num = (short)1498939396;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								num = (short)393347075;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1010171904;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::SSLMangrComp.Packets.SubscriptionPacket item = enumerator.Current;
								this.c.Remove(item);
								num = (short)704643074;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_11B;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_9E;
								}
								continue;
							}
							IL_A0:
							num = (short)1055850497;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_9E:
							goto IL_A0;
						}
						IL_11B:
						break;
					}
					finally
					{
						num = (short)207355906;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								enumerator.Dispose();
								num = (short)2141354154;
								short num4 = num;
								num = (short)1502509226;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1D8;
								default:
									num = (short)2107768832;
									if (num != 0)
									{
									}
									num = (short)2137980929;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_1D8;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_153;
								}
								continue;
							}
							IL_153:
							if (enumerator == null)
							{
								break;
							}
							num = (short)290848768;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1D8:;
					}
				}
				return;
			}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000B830 File Offset: 0x00009A30
		public void ClientConnect()
		{
			short num = (short)729228958;
			short num2 = num;
			num = (short)384509598;
			switch (num2 == num)
			{
			}
			num = (short)811597825;
			if (num != 0)
			{
			}
			num = (short)400097280;
			if (num != 0)
			{
			}
			num = (short)2065825792;
			short num3 = num;
			this.d.Connect(this.ServerInfo);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000B8EC File Offset: 0x00009AEC
		public void ClientClose()
		{
			short num = (short)1983583520;
			short num2 = num;
			num = (short)2068124960;
			switch (num2 == num)
			{
			}
			num = (short)651034625;
			if (num != 0)
			{
			}
			num = (short)1429536768;
			if (num != 0)
			{
			}
			num = (short)62914560;
			short num3 = num;
			this.d.ShutdownClient();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		private void a(global::SSLMangrComp.Packets.SubscriptionPacket A_0)
		{
			short num = (short)774242305;
			if (num != 0)
			{
			}
			num = (short)1177288944;
			short num2 = num;
			num = (short)489619696;
			switch (num2 == num)
			{
			}
			num = (short)913244160;
			if (num != 0)
			{
			}
			num = (short)458031104;
			short num3 = num;
			this.d.WriteData(A_0.getData());
			A_0.IsPacketRecived = false;
			global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle packetSendOrRecievedHandle = this.a;
			if (packetSendOrRecievedHandle == null)
			{
				return;
			}
			packetSendOrRecievedHandle(A_0);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000BA74 File Offset: 0x00009C74
		private void a(global::SSLMangrComp.Packets.PacketBase A_0)
		{
			short num = (short)657984732;
			short num2 = num;
			num = (short)650906844;
			switch (num2 == num)
			{
			}
			num = (short)146866177;
			if (num != 0)
			{
			}
			num = (short)1322909696;
			if (num != 0)
			{
			}
			num = (short)494993408;
			short num3 = num;
			global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle packetSendOrRecievedHandle = this.a;
			if (packetSendOrRecievedHandle == null)
			{
				return;
			}
			packetSendOrRecievedHandle(A_0);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000BB30 File Offset: 0x00009D30
		private void a(global::SSLMangrComp.ErrorReport A_0)
		{
			short num = (short)536116679;
			short num2 = num;
			num = (short)695827911;
			switch (num2 == num)
			{
			}
			num = (short)239206401;
			if (num != 0)
			{
			}
			num = (short)837615616;
			if (num != 0)
			{
			}
			num = (short)1773600768;
			short num3 = num;
			global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle errorRecievedHandle = this.b;
			if (errorRecievedHandle == null)
			{
				return;
			}
			errorRecievedHandle(A_0);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000BBF0 File Offset: 0x00009DF0
		public void StartListener()
		{
			short num = (short)1922826254;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.Mode == global::SSLMangrComp.Packets.SubscriptionType.Reliable)
					{
						num = (short)596836356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BA;
				case 1:
					this.d = new global::SSLMangrComp.ConnectionLayer.h();
					num = (short)1271857161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_342;
				case 3:
					goto IL_DD;
				case 4:
					this.d = new global::SSLMangrComp.ConnectionLayer.UDPClientConnector();
					num = (short)9502727;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_2FE;
				case 6:
					if (!global::SSLMangrComp.LinkManagerWatcher.e.IsServerRunning())
					{
						num = (short)1508900867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BA;
				case 7:
					if (global::SSLMangrComp.LinkManagerWatcher.e != null)
					{
						num = (short)565772303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DD;
				case 8:
					if (!global::SSLMangrComp.LinkManagerWatcher.e.IsServerRunning())
					{
						num = (short)1590558736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_394;
				case 9:
					if (global::SSLMangrComp.LinkManagerWatcher.e != null)
					{
						num = (short)1420230667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_342;
				case 10:
					goto IL_1BA;
				case 11:
					num = (short)398196748;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (!global::SSLMangrComp.LinkManagerWatcher.e.IsServerRunning())
					{
						num = (short)527302658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BA;
				case 13:
					goto IL_1BA;
				case 14:
				{
					num = (short)197132289;
					if (num != 0)
					{
					}
					num = (short)1357840384;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_B8;
					}
					continue;
				}
				case 15:
					num = (short)1648427014;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
				{
					num = (short)564486141;
					short num4 = num;
					num = (short)739401725;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_378;
					default:
						num = (short)424345600;
						if (num != 0)
						{
						}
						global::SSLMangrComp.LinkManagerWatcher.e.a(this.ServerInfo);
						num = (short)446824453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_B8:
				if (this.Mode == global::SSLMangrComp.Packets.SubscriptionType.Secure)
				{
					num = (short)1557397505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)386203648;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DD:
				global::SSLMangrComp.LinkManagerWatcher.e = new global::SSLMangrComp.ConnectionLayer.g();
				global::SSLMangrComp.LinkManagerWatcher.e.b(new global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle(this.a));
				global::SSLMangrComp.LinkManagerWatcher.e.c(new global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle(this.a));
				num = (short)51838989;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BA:
				num = (short)1500315656;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_378:
				num = (short)784203786;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_342:
				global::SSLMangrComp.LinkManagerWatcher.e = new global::SSLMangrComp.ConnectionLayer.i();
				global::SSLMangrComp.LinkManagerWatcher.e.b(new global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle(this.a));
				global::SSLMangrComp.LinkManagerWatcher.e.c(new global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle(this.a));
				goto IL_378;
			}
			IL_2FE:
			IL_394:
			this.f = global::SSLMangrComp.LinkManagerWatcher.e.getPortNumber();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		private ushort a()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			ushort num2;
			short num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return num2;
				case 1:
					goto IL_84;
				case 2:
				{
					int num3;
					if (this.c[num3].DialogID == num2)
					{
						num4 = (short)233111553;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					num3++;
					num4 = (short)201195530;
					num = (int)((global::System.IntPtr)num4);
					continue;
				}
				case 3:
					goto IL_E6;
				case 4:
					return 0;
				case 5:
				{
					if (num2 >= 65535)
					{
						num4 = (short)85262340;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					int num3 = 0;
					num4 = (short)1906180107;
					num = (int)((global::System.IntPtr)num4);
					continue;
				}
				case 6:
				{
					num4 = (short)1837181917;
					short num5 = num4;
					num4 = (short)2019634141;
					switch ((num5 == num4) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_84;
					default:
						num4 = (short)1459421184;
						if (num4 != 0)
						{
						}
						num4 = (short)769392642;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					break;
				}
				case 7:
				{
					int num3;
					if (num3 < this.c.Count)
					{
						num4 = (short)1265827841;
						if (num4 != 0)
						{
						}
						num4 = (short)2027094022;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					goto IL_84;
				}
				case 8:
				{
					int num3;
					if (num3 >= this.c.Count)
					{
						num4 = (short)2052390912;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					num2 += 1;
					num4 = (short)1156055043;
					num = (int)((global::System.IntPtr)num4);
					continue;
				}
				case 9:
					goto IL_E6;
				case 10:
					goto IL_1A8;
				case 11:
					goto IL_1A8;
				}
				goto IL_40;
				IL_84:
				num4 = (short)1166213128;
				num = (int)((global::System.IntPtr)num4);
				continue;
				IL_E6:
				num4 = (short)1391394821;
				num = (int)((global::System.IntPtr)num4);
				continue;
				IL_1A8:
				num4 = (short)1166344199;
				num = (int)((global::System.IntPtr)num4);
			}
			return num2;
			IL_40:
			num4 = (short)1612775424;
			short num6 = num4;
			num2 = 1;
			num4 = (short)1294139401;
			num = (int)((global::System.IntPtr)num4);
			goto IL_0A;
		}

		// Token: 0x04000053 RID: 83
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.LinkManagerWatcher.PacketSendOrRecievedHandle a;

		// Token: 0x04000054 RID: 84
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.LinkManagerWatcher.ErrorRecievedHandle b;

		// Token: 0x04000055 RID: 85
		private readonly global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase> c = new global::System.Collections.Generic.List<global::SSLMangrComp.Packets.PacketBase>();

		// Token: 0x04000056 RID: 86
		private global::SSLMangrComp.Connectors.c d;

		// Token: 0x04000057 RID: 87
		private static global::SSLMangrComp.ConnectionLayer.f e;

		// Token: 0x04000058 RID: 88
		private int f;

		// Token: 0x04000059 RID: 89
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.PNConnectionInfo g;

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000B5 RID: 181
		public delegate void PacketSendOrRecievedHandle(global::SSLMangrComp.Packets.PacketBase packet);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000B9 RID: 185
		public delegate void ErrorRecievedHandle(global::SSLMangrComp.ErrorReport errorReport);
	}
}
