using System;
using System.Runtime.CompilerServices;
using System.Threading;
using IACustomException;
using SSLMangrComp.ConnectionLayer;
using SSLMangrComp.Packets;

namespace SSLMangrComp
{
	// Token: 0x0200000A RID: 10
	public class ConnectionManager
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000024 RID: 36 RVA: 0x00003D8C File Offset: 0x00001F8C
		// (remove) Token: 0x06000025 RID: 37 RVA: 0x00003EC0 File Offset: 0x000020C0
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle PacketReceived
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)775356416;
				short num2 = num;
				int num3;
				global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_32:
						global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
						switch (num3)
						{
						case 0:
							goto IL_D8;
						case 1:
							if (packetRecivedHandle == packetRecivedHandle2)
							{
								num = (short)1816133632;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_61;
						case 2:
							goto IL_61;
						}
						goto IL_44;
						IL_61:
						num = (short)2127757313;
						if (num != 0)
						{
						}
						packetRecivedHandle2 = packetRecivedHandle;
						global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Combine(packetRecivedHandle2, value);
						packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.a, value2, packetRecivedHandle2);
						num = (short)153354241;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_D8:
					num = (short)622741322;
					short num4 = num;
					num = (short)2029012810;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4B;
					default:
						num = (short)1684275200;
						if (num != 0)
						{
						}
						return;
					}
					break;
				}
				}
				IL_44:
				packetRecivedHandle = this.a;
				IL_4B:
				num = (short)1459027970;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)494272512;
				short num2 = num;
				int num3;
				global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_33:
						global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
						switch (num3)
						{
						case 0:
							goto IL_DA;
						case 1:
							if (packetRecivedHandle == packetRecivedHandle2)
							{
								num = (short)1551958016;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8A;
						case 2:
							num = (short)6619137;
							if (num != 0)
							{
							}
							goto IL_8A;
						}
						goto IL_45;
						IL_8A:
						packetRecivedHandle2 = packetRecivedHandle;
						global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Remove(packetRecivedHandle2, value);
						packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.a, value2, packetRecivedHandle2);
						num = (short)897712129;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_DA:
					num = (short)1753249900;
					short num4 = num;
					num = (short)2037676140;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4C;
					default:
						num = (short)1421344768;
						if (num != 0)
						{
						}
						return;
					}
					break;
				}
				}
				IL_45:
				packetRecivedHandle = this.a;
				IL_4C:
				num = (short)255262722;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000026 RID: 38 RVA: 0x00003FF4 File Offset: 0x000021F4
		// (remove) Token: 0x06000027 RID: 39 RVA: 0x00004128 File Offset: 0x00002328
		public event global::SSLMangrComp.ConnectionManager.ErrorReceivedHandle HandleError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1004666880;
				short num2 = num;
				int num3;
				global::SSLMangrComp.ConnectionManager.ErrorReceivedHandle errorReceivedHandle;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_32:
						global::SSLMangrComp.ConnectionManager.ErrorReceivedHandle errorReceivedHandle2;
						switch (num3)
						{
						case 0:
							goto IL_D8;
						case 1:
							if (errorReceivedHandle == errorReceivedHandle2)
							{
								num = (short)113246208;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_62;
						case 2:
							goto IL_62;
						}
						goto IL_44;
						IL_62:
						num = (short)710148097;
						if (num != 0)
						{
						}
						errorReceivedHandle2 = errorReceivedHandle;
						global::SSLMangrComp.ConnectionManager.ErrorReceivedHandle value2 = (global::SSLMangrComp.ConnectionManager.ErrorReceivedHandle)global::System.Delegate.Combine(errorReceivedHandle2, value);
						errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionManager.ErrorReceivedHandle>(ref this.b, value2, errorReceivedHandle2);
						num = (short)870383617;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_D8:
					num = (short)371138055;
					short num4 = num;
					num = (short)1097539079;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4B;
					default:
						num = (short)1256194048;
						if (num != 0)
						{
						}
						return;
					}
					break;
				}
				}
				IL_44:
				errorReceivedHandle = this.b;
				IL_4B:
				num = (short)762773506;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)652869632;
				short num2 = num;
				int num3;
				global::SSLMangrComp.ConnectionManager.ErrorReceivedHandle errorReceivedHandle;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_36:
						global::SSLMangrComp.ConnectionManager.ErrorReceivedHandle errorReceivedHandle2;
						switch (num3)
						{
						case 0:
							goto IL_B0;
						case 1:
							if (errorReceivedHandle == errorReceivedHandle2)
							{
								num = (short)1497825280;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_66;
						case 2:
							goto IL_66;
						}
						goto IL_48;
						IL_66:
						errorReceivedHandle2 = errorReceivedHandle;
						global::SSLMangrComp.ConnectionManager.ErrorReceivedHandle value2 = (global::SSLMangrComp.ConnectionManager.ErrorReceivedHandle)global::System.Delegate.Remove(errorReceivedHandle2, value);
						errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionManager.ErrorReceivedHandle>(ref this.b, value2, errorReceivedHandle2);
						num = (short)739639297;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_B0:
					num = (short)133950726;
					short num4 = num;
					num = (short)1205333254;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4F;
					default:
						num = (short)200015872;
						if (num != 0)
						{
						}
						num = (short)208076801;
						if (num != 0)
						{
						}
						return;
					}
					break;
				}
				}
				IL_48:
				errorReceivedHandle = this.b;
				IL_4F:
				num = (short)392953858;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_36;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000425C File Offset: 0x0000245C
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00004308 File Offset: 0x00002508
		public int Expire
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)473101948;
				short num2 = num;
				num = (short)1454241404;
				switch (num2 == num)
				{
				}
				num = (short)1912602625;
				if (num != 0)
				{
				}
				num = (short)1211498496;
				if (num != 0)
				{
				}
				num = (short)1397751808;
				short num3 = num;
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1223301211;
				short num2 = num;
				num = (short)1557665883;
				switch (num2 == num)
				{
				}
				num = (short)675479553;
				if (num != 0)
				{
				}
				num = (short)460193792;
				if (num != 0)
				{
				}
				num = (short)1283653632;
				short num3 = num;
				this.h = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000446C File Offset: 0x0000266C
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000043BC File Offset: 0x000025BC
		public global::SSLMangrComp.Packets.EntitiesTypes EntityType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)838516971;
				short num2 = num;
				num = (short)325828843;
				switch (num2 == num)
				{
				}
				num = (short)1598750721;
				if (num != 0)
				{
				}
				num = (short)1077215232;
				if (num != 0)
				{
				}
				num = (short)660930560;
				short num3 = num;
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)893767510;
				short num2 = num;
				num = (short)491048790;
				switch (num2 == num)
				{
				}
				num = (short)243335168;
				if (num != 0)
				{
				}
				num = (short)699858945;
				if (num != 0)
				{
				}
				num = (short)409206784;
				short num3 = num;
				this.i = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000045C8 File Offset: 0x000027C8
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00004518 File Offset: 0x00002718
		public string Entity
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1254586127;
				short num2 = num;
				num = (short)1189050127;
				switch (num2 == num)
				{
				}
				num = (short)1464008705;
				if (num != 0)
				{
				}
				num = (short)293732352;
				if (num != 0)
				{
				}
				num = (short)94765056;
				short num3 = num;
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)48444248;
				short num2 = num;
				num = (short)572928856;
				switch (num2 == num)
				{
				}
				num = (short)1106575360;
				if (num != 0)
				{
				}
				num = (short)1878065153;
				if (num != 0)
				{
				}
				num = (short)523304960;
				short num3 = num;
				this.j = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00004724 File Offset: 0x00002924
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00004674 File Offset: 0x00002874
		public string SubEvents
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1055426918;
				short num2 = num;
				num = (short)1808238950;
				switch (num2 == num)
				{
				}
				num = (short)1269235713;
				if (num != 0)
				{
				}
				num = (short)738000896;
				if (num != 0)
				{
				}
				num = (short)12124160;
				short num3 = num;
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1365049345;
				if (num != 0)
				{
				}
				num = (short)1883725509;
				short num2 = num;
				num = (short)577199813;
				switch (num2 == num)
				{
				}
				num = (short)1862467584;
				if (num != 0)
				{
				}
				num = (short)158793728;
				short num3 = num;
				this.k = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000047D4 File Offset: 0x000029D4
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00004884 File Offset: 0x00002A84
		public global::SSLMangrComp.Packets.SubscriptionType Mode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1426029262;
				short num2 = num;
				num = (short)542145230;
				switch (num2 == num)
				{
				}
				num = (short)1729822721;
				if (num != 0)
				{
				}
				num = (short)1347289088;
				if (num != 0)
				{
				}
				num = (short)695861248;
				short num3 = num;
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)851312641;
				if (num != 0)
				{
				}
				num = (short)1731658504;
				short num2 = num;
				num = (short)1810039560;
				switch (num2 == num)
				{
				}
				num = (short)1118044160;
				if (num != 0)
				{
				}
				num = (short)2061172736;
				short num3 = num;
				this.l = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00004934 File Offset: 0x00002B34
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000049E4 File Offset: 0x00002BE4
		public string Timeout
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)907931936;
				short num2 = num;
				num = (short)1533473056;
				switch (num2 == num)
				{
				}
				num = (short)92078081;
				if (num != 0)
				{
				}
				num = (short)946143232;
				if (num != 0)
				{
				}
				num = (short)1332543488;
				short num3 = num;
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1462889983;
				short num2 = num;
				num = (short)1332342271;
				switch (num2 == num)
				{
				}
				num = (short)1742733313;
				if (num != 0)
				{
				}
				num = (short)1463943168;
				if (num != 0)
				{
				}
				num = (short)1837367296;
				short num3 = num;
				this.m = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00004A98 File Offset: 0x00002C98
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00004B48 File Offset: 0x00002D48
		public global::SSLMangrComp.ConnectionConfig ConnConfig
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1361455805;
				short num2 = num;
				num = (short)189409981;
				switch (num2 == num)
				{
				}
				num = (short)1792933888;
				if (num != 0)
				{
				}
				num = (short)825819137;
				if (num != 0)
				{
				}
				num = (short)1839923200;
				short num3 = num;
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1452407640;
				short num2 = num;
				num = (short)111934296;
				switch (num2 == num)
				{
				}
				num = (short)230752256;
				if (num != 0)
				{
				}
				num = (short)1752039425;
				if (num != 0)
				{
				}
				num = (short)1511784448;
				short num3 = num;
				this.n = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00004BF4 File Offset: 0x00002DF4
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00004CA4 File Offset: 0x00002EA4
		public global::SSLMangrComp.SecureClientConfiguration SecureClientConfig
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1551171585;
				if (num != 0)
				{
				}
				num = (short)1994920785;
				short num2 = num;
				num = (short)763433809;
				switch (num2 == num)
				{
				}
				num = (short)1243021312;
				if (num != 0)
				{
				}
				num = (short)155713536;
				short num3 = num;
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1866193614;
				short num2 = num;
				num = (short)1201920718;
				switch (num2 == num)
				{
				}
				num = (short)1616576513;
				if (num != 0)
				{
				}
				num = (short)870449152;
				if (num != 0)
				{
				}
				num = (short)465043456;
				short num3 = num;
				this.o = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00004D58 File Offset: 0x00002F58
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00004E08 File Offset: 0x00003008
		public global::SSLMangrComp.SecureServerConfiguration SecureServerConfig
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)469958657;
				if (num != 0)
				{
				}
				num = (short)953583743;
				short num2 = num;
				num = (short)1048676479;
				switch (num2 == num)
				{
				}
				num = (short)1975975936;
				if (num != 0)
				{
				}
				num = (short)318308352;
				short num3 = num;
				return this.p;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1857335264;
				short num2 = num;
				num = (short)1496952800;
				switch (num2 == num)
				{
				}
				num = (short)1726480384;
				if (num != 0)
				{
				}
				num = (short)1848311809;
				if (num != 0)
				{
				}
				num = (short)1194590208;
				short num3 = num;
				this.p = value;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004EB8 File Offset: 0x000030B8
		private ConnectionManager()
		{
			int a_ = 19;
			this.d = global::SSLMangrComp.PresenceInfo.Instance;
			this.e = global::SSLMangrComp.ErrorReporter.Instance;
			this.StrRadIp = string.Empty;
			this.StrSubState = string.Empty;
			this.StrDeviceId = string.Empty;
			this.StrEntityType = string.Empty;
			this.ReEventValue = 2U;
			this.i = global::SSLMangrComp.Packets.EntitiesTypes.DeviceID;
			this.j = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("畄", a_);
			this.k = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("瑄畆", a_);
			base..ctor();
			this.PresenceInfoCallBack = new global::SSLMangrComp.PresenceInfo_CallBack(this.SetParentDataObjects);
			this.ErrorCallBack = new global::SSLMangrComp.ReportOnError_CallBack(this.SetErrorDataObjects);
			this.f = new global::SSLMangrComp.LinkManager();
			if (this.f != null)
			{
				this.f.PacketSentOrRecived += this.b;
				this.f.ErrorReceived += this.b;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004FB8 File Offset: 0x000031B8
		public ConnectionManager(global::SSLMangrComp.PNConnectionInfo pnConnectionInfo, bool disconnectFromClient) : this()
		{
			this.ConnConfig = pnConnectionInfo.PNConnectionConfig;
			this.SecureClientConfig = pnConnectionInfo.TLSClientConfig;
			this.SecureServerConfig = pnConnectionInfo.TLSServerConfig;
			this.g = disconnectFromClient;
			this.Mode = pnConnectionInfo.PNConnectionConfig.SubscriptionMode;
			this.Timeout = pnConnectionInfo.PNConnectionConfig.ConnectionAttemptTimeout.ToString();
			global::SSLMangrComp.ConnectionManager.c = new global::System.Threading.AutoResetEvent(false);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000502C File Offset: 0x0000322C
		private void b(global::SSLMangrComp.ErrorReport A_0)
		{
			short num = (short)2095044951;
			short num2 = num;
			num = (short)508614999;
			switch (num2 == num)
			{
			}
			num = (short)1095106561;
			if (num != 0)
			{
			}
			num = (short)969605120;
			if (num != 0)
			{
			}
			num = (short)1405485056;
			short num3 = num;
			this.NErrorCategory = (int)A_0.ErrCat;
			this.NErrorId = A_0.ErrorID;
			this.b();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000050F8 File Offset: 0x000032F8
		private void b(global::SSLMangrComp.Packets.PacketBase A_0)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			string packetDescription;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (packetDescription == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("洷吹主嬽ⰿ⭁╃⑅⑇⽉汋M㽏♑㵓さ⅗穙ᅛ㭝፟ᅡգť൧", a_))
					{
						num2 = (short)949026817;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_163;
				case 1:
					goto IL_A3;
				case 2:
					num2 = (short)1085407233;
					if (num2 != 0)
					{
					}
					if (!(packetDescription == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("樷弹倻圽ℿ⁁⡃⍅桇щ⍋㩍㥏㑑ⵓ癕ᕗ㽙⽛ⵝşաţ", a_)))
					{
						goto IL_8A;
					}
					goto IL_A3;
				case 3:
					goto IL_163;
				case 4:
					num2 = (short)1372585984;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					global::SSLMangrComp.PresenceInfo instance = global::SSLMangrComp.PresenceInfo.Instance;
					global::SSLMangrComp.PresenceNotification presenceNotification = instance.SendPresenceNotification(A_0);
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle = this.a;
					if (packetRecivedHandle != null)
					{
						packetRecivedHandle(A_0);
					}
					instance.SendPresenceInfo(this.PresenceInfoCallBack);
					instance.CallPresenceInfoCallback(ref presenceNotification);
					this.b();
					global::SSLMangrComp.ConnectionManager.c.Set();
					num2 = (short)1176109059;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_31;
				IL_8A:
				num2 = (short)1821573124;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_A3:
				num2 = (short)699072517;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_163:
				num2 = (short)840550868;
				short num3 = num2;
				num2 = (short)2008664532;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_8A;
				default:
					goto IL_199;
				}
			}
			IL_199:
			num2 = (short)131792896;
			short num4 = num2;
			num2 = (short)985268224;
			if (num2 != 0)
			{
			}
			return;
			IL_31:
			packetDescription = A_0.getPacketDescription();
			num2 = (short)2069102594;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000052E0 File Offset: 0x000034E0
		private void b()
		{
			short num = (short)1605369858;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					IL_C9:
					if (this.b != null)
					{
						num = (short)118489089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_145;
				case 1:
					this.HandleError -= this.a;
					num = (short)246415365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
					goto IL_89;
				case 4:
				{
					this.PacketReceived -= this.a;
					num = (short)1064501248;
					short num3 = num;
					num = (short)2045509635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_145;
				}
				IL_3C:
				if (this.a != null)
				{
					num = (short)1394999300;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_89:
				num = (short)2074935297;
				if (num != 0)
				{
				}
				num = (short)72548352;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_145:
				num = (short)219664618;
				short num4 = num;
				num = (short)106025194;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C9;
				default:
					goto IL_179;
				}
			}
			IL_179:
			num = (short)1636171776;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005480 File Offset: 0x00003680
		public void SetParentDataObjects(ref global::SSLMangrComp.PresenceNotification pn)
		{
			short num = (short)285869890;
			short num2 = num;
			num = (short)819267394;
			switch (num2 == num)
			{
			default:
			{
				num = (short)196542464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)373751809;
			if (num != 0)
			{
			}
			num = (short)1634467840;
			if (num != 0)
			{
			}
			this.StrRadIp = pn.IPAddr;
			this.StrSubState = pn.SubscriptionState;
			this.StrDeviceId = pn.DeviceId;
			this.StrEntityType = pn.EntityType;
			this.ReEventValue = (uint)pn.EventValue;
			this.PsPresenceState = (uint)pn.PresenceState;
			this.NErrorCategory = (int)this.e.ReportCategory;
			this.NErrorId = this.e.ReportId;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005598 File Offset: 0x00003798
		public void ResetParentDataObjects()
		{
			short num = (short)1614365504;
			short num2 = num;
			num = (short)925320000;
			switch (num2 == num)
			{
			default:
			{
				num = (short)952631296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1298071553;
			if (num != 0)
			{
			}
			num = (short)1412694016;
			if (num != 0)
			{
			}
			this.StrRadIp = string.Empty;
			this.StrSubState = string.Empty;
			this.StrDeviceId = string.Empty;
			this.StrEntityType = string.Empty;
			this.ReEventValue = 2U;
			this.PsPresenceState = 0U;
			this.NErrorCategory = 0;
			this.NErrorId = (global::IACustomException.IACommonErrorCode)0;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005688 File Offset: 0x00003888
		public void SetErrorDataObjects(ref global::SSLMangrComp.ErrorReport errorRep)
		{
			short num = (short)1767636993;
			if (num != 0)
			{
			}
			num = (short)88408064;
			short num2 = num;
			num = (short)162435132;
			short num3 = num;
			num = (short)1659015228;
			switch (num3 == num)
			{
			}
			num = (short)1425932288;
			if (num != 0)
			{
			}
			this.NErrorCategory = (int)errorRep.ErrCat;
			this.NErrorId = errorRep.ErrorID;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000574C File Offset: 0x0000394C
		public int InitiateConnection(ref global::SSLMangrComp.PresenceNotification presNot)
		{
			short num = (short)333185024;
			short num2 = num;
			num = (short)1223257643;
			short num3 = num;
			num = (short)1452568107;
			int result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)322961408;
				if (num != 0)
				{
				}
				num = (short)646381569;
				if (num != 0)
				{
				}
				result = 0;
				for (;;)
				{
					try
					{
						this.a();
					}
					catch (global::IACustomException.IACommonException)
					{
						throw;
					}
					catch (global::System.Exception)
					{
						throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_Unknown);
					}
					try
					{
						switch (0)
						{
						case 0:
							goto IL_C6;
						}
						int num4;
						for (;;)
						{
							IL_AC:
							switch (num4)
							{
							case 0:
								this.f.Subscribe(this.ConnConfig.Expiration, this.ConnConfig.EntityType, this.ConnConfig.EntityValue, this.SubEvents, this.ConnConfig.SubscriptionMode, this.ConnConfig.PnIp, this.ConnConfig.PnPort, this.g, this.SecureClientConfig, this.SecureServerConfig);
								num = (short)1571422212;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (this.Mode == global::SSLMangrComp.Packets.SubscriptionType.Secure)
								{
									num = (short)1978269696;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								this.f.Subscribe(this.ConnConfig.Expiration, this.ConnConfig.EntityType, this.ConnConfig.EntityValue, this.SubEvents, this.ConnConfig.SubscriptionMode, this.ConnConfig.PnIp, this.ConnConfig.PnPort);
								num = (short)1153564674;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_209;
							case 3:
								goto IL_229;
							case 4:
								goto IL_209;
							}
							goto IL_C6;
							IL_209:
							result = this.a(ref presNot);
							num = (short)1678704643;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_229:
						break;
						IL_C6:
						this.PacketReceived += this.a;
						this.HandleError += this.b;
						num = (short)1431633921;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_AC;
					}
					catch (global::System.Exception ex)
					{
						if (ex is global::IACustomException.IACommonException)
						{
							throw;
						}
						if (ex is global::System.TimeoutException)
						{
							throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_PackageTimeout, ex);
						}
						if (this.e.ReportCategory == 0U)
						{
							throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_UnhandledLinkMgrException, ex);
						}
						break;
					}
				}
				break;
			}
			return result;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005A30 File Offset: 0x00003C30
		public void StopListener()
		{
			short num = (short)551211141;
			short num2 = num;
			num = (short)1176948869;
			switch (num2 == num)
			{
			}
			num = (short)1451491329;
			if (num != 0)
			{
			}
			num = (short)224526336;
			if (num != 0)
			{
			}
			num = (short)839122944;
			short num3 = num;
			this.f.ShutDownListen(this.Mode);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005AEC File Offset: 0x00003CEC
		private void a()
		{
			short num = (short)1853021739;
			short num2 = num;
			num = (short)1910234667;
			switch (num2 == num)
			{
			}
			num = (short)1503723520;
			if (num != 0)
			{
			}
			num = (short)1137115137;
			if (num != 0)
			{
			}
			num = (short)895877120;
			short num3 = num;
			this.ResetParentDataObjects();
			this.f.SetTimeOut(this.ConnConfig.ConnectionAttemptTimeout, this.ErrorCallBack);
			this.d.ResetPresenceNotification();
			this.e.ResetErrorReport();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005BC8 File Offset: 0x00003DC8
		private void a(global::SSLMangrComp.Packets.PacketBase A_0)
		{
			short num = (short)2132753529;
			short num2 = num;
			num = (short)1681407097;
			switch (num2 == num)
			{
			}
			num = (short)1745092608;
			if (num != 0)
			{
			}
			num = (short)662634497;
			if (num != 0)
			{
			}
			num = (short)246284288;
			short num3 = num;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005C74 File Offset: 0x00003E74
		private void a(global::SSLMangrComp.ErrorReport A_0)
		{
			short num = (short)2107540199;
			short num2 = num;
			num = (short)52200167;
			switch (num2 == num)
			{
			}
			num = (short)568786945;
			if (num != 0)
			{
			}
			num = (short)712310784;
			if (num != 0)
			{
			}
			num = (short)769327104;
			short num3 = num;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005D20 File Offset: 0x00003F20
		private int a(ref global::SSLMangrComp.PresenceNotification A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.PsPresenceState == 1U)
					{
						num2 = (short)2033909772;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_196;
				case 1:
					if (this.b == null)
					{
						num2 = (short)2001862662;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_260;
				case 2:
					num2 = (short)1207173121;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_196;
				case 4:
					return num3;
				case 5:
					if (this.a != null)
					{
						num2 = (short)555220994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_220;
				case 6:
					goto IL_220;
				case 7:
					if (this.PsPresenceState == 2U)
					{
						goto IL_244;
					}
					goto IL_36C;
				case 8:
					goto IL_36C;
				case 9:
					goto IL_B8;
				case 10:
					num2 = (short)1578237953;
					if (num2 != 0)
					{
					}
					if (this.NErrorCategory != 0)
					{
						num2 = (short)634388496;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_260;
				case 11:
					num3 = 0;
					num2 = (short)287047689;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num3 = 1;
					num2 = (short)1883635715;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					num3 = 2;
					num2 = (short)1470234632;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					this.f.ShutDownListen(this.Mode);
					num2 = (short)1621688324;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
				{
					if (this.PsPresenceState != 0U)
					{
						goto IL_B8;
					}
					num2 = (short)361219999;
					short num4 = num2;
					num2 = (short)1594410911;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_244;
					default:
						num2 = (short)1829568512;
						if (num2 != 0)
						{
						}
						num2 = (short)488898571;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 16:
					goto IL_191;
				case 17:
					if (num3 == -7)
					{
						num2 = (short)1283981326;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return num3;
				}
				goto IL_58;
				IL_B8:
				A_0.DeviceId = this.StrDeviceId;
				A_0.EntityType = this.StrEntityType;
				A_0.EventValue = (global::SSLMangrComp.RequestEvent)this.ReEventValue;
				A_0.IPAddr = this.StrRadIp;
				A_0.PresenceState = (global::SSLMangrComp.PresenceState)this.PsPresenceState;
				A_0.SubscriptionState = this.StrSubState;
				num2 = (short)1956773888;
				short num5 = num2;
				num2 = (short)789315594;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_196:
				num2 = (short)1148715023;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_220:
				num2 = (short)1229848583;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_244:
				num2 = (short)1980432397;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_260:
				num2 = (short)62324753;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_36C:
				num2 = (short)69926912;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_191:
			throw new global::IACustomException.IACommonException(this.NErrorId);
			IL_58:
			num3 = -7;
			int num6 = int.Parse(this.Timeout);
			global::SSLMangrComp.ConnectionManager.c.WaitOne(num6 * 1000);
			num2 = (short)1741225989;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000060DC File Offset: 0x000042DC
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionManager()
		{
			short num = (short)2095768740;
			short num2 = num;
			num = (short)1529144484;
			switch (num2 == num)
			{
			}
			num = (short)1117257729;
			if (num != 0)
			{
			}
			num = (short)1137442816;
			if (num != 0)
			{
			}
			num = (short)440991744;
			short num3 = num;
			global::SSLMangrComp.ConnectionManager.c = new global::System.Threading.AutoResetEvent(false);
		}

		// Token: 0x0400000D RID: 13
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle a;

		// Token: 0x0400000E RID: 14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionManager.ErrorReceivedHandle b;

		// Token: 0x0400000F RID: 15
		private static global::System.Threading.AutoResetEvent c;

		// Token: 0x04000010 RID: 16
		public global::SSLMangrComp.PresenceInfo_CallBack PresenceInfoCallBack;

		// Token: 0x04000011 RID: 17
		public global::SSLMangrComp.ReportOnError_CallBack ErrorCallBack;

		// Token: 0x04000012 RID: 18
		private readonly global::SSLMangrComp.PresenceInfo d;

		// Token: 0x04000013 RID: 19
		private readonly global::SSLMangrComp.ErrorReporter e;

		// Token: 0x04000014 RID: 20
		public string StrRadIp;

		// Token: 0x04000015 RID: 21
		public string StrSubState;

		// Token: 0x04000016 RID: 22
		public string StrDeviceId;

		// Token: 0x04000017 RID: 23
		public string StrEntityType;

		// Token: 0x04000018 RID: 24
		public uint ReEventValue;

		// Token: 0x04000019 RID: 25
		public uint PsPresenceState;

		// Token: 0x0400001A RID: 26
		public int NErrorCategory;

		// Token: 0x0400001B RID: 27
		public global::IACustomException.IACommonErrorCode NErrorId;

		// Token: 0x0400001C RID: 28
		private readonly global::SSLMangrComp.LinkManager f;

		// Token: 0x0400001D RID: 29
		private readonly bool g;

		// Token: 0x0400001E RID: 30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int h;

		// Token: 0x0400001F RID: 31
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.Packets.EntitiesTypes i;

		// Token: 0x04000020 RID: 32
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string j;

		// Token: 0x04000021 RID: 33
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string k;

		// Token: 0x04000022 RID: 34
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.Packets.SubscriptionType l;

		// Token: 0x04000023 RID: 35
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string m;

		// Token: 0x04000024 RID: 36
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionConfig n;

		// Token: 0x04000025 RID: 37
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.SecureClientConfiguration o;

		// Token: 0x04000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.SecureServerConfiguration p;

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600004A RID: 74
		public delegate void ErrorReceivedHandle(global::SSLMangrComp.ErrorReport report);
	}
}
