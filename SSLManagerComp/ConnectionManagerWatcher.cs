using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using IACustomException;
using SSLMangrComp.ConnectionLayer;
using SSLMangrComp.Packets;

namespace SSLMangrComp
{
	// Token: 0x0200000C RID: 12
	public class ConnectionManagerWatcher
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600004D RID: 77 RVA: 0x00006190 File Offset: 0x00004390
		// (remove) Token: 0x0600004E RID: 78 RVA: 0x000062C8 File Offset: 0x000044C8
		private event global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify radioFound
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
				global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify radioPresenceNotify;
				short num2;
				for (;;)
				{
					IL_0A:
					global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify radioPresenceNotify2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_62;
					case 2:
						IL_106:
						if (radioPresenceNotify == radioPresenceNotify2)
						{
							num2 = (short)145752064;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_62;
					}
					goto IL_1C;
					IL_62:
					radioPresenceNotify2 = radioPresenceNotify;
					global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify value2 = (global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify)global::System.Delegate.Combine(radioPresenceNotify2, value);
					radioPresenceNotify = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify>(ref this.a, value2, radioPresenceNotify2);
					num2 = (short)495618549;
					short num3 = num2;
					num2 = (short)1710197237;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_106;
					default:
						num2 = (short)972161025;
						if (num2 != 0)
						{
						}
						num2 = (short)231407616;
						if (num2 != 0)
						{
						}
						num2 = (short)766705666;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				num2 = (short)2146304000;
				short num4 = num2;
				radioPresenceNotify = this.a;
				num2 = (short)1298071553;
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
				global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify radioPresenceNotify;
				short num2;
				for (;;)
				{
					IL_0A:
					global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify radioPresenceNotify2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_66;
					case 2:
						IL_10A:
						if (radioPresenceNotify == radioPresenceNotify2)
						{
							num2 = (short)690028544;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_66;
					}
					goto IL_1C;
					IL_66:
					radioPresenceNotify2 = radioPresenceNotify;
					global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify value2 = (global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify)global::System.Delegate.Remove(radioPresenceNotify2, value);
					radioPresenceNotify = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify>(ref this.a, value2, radioPresenceNotify2);
					num2 = (short)916994400;
					short num3 = num2;
					num2 = (short)934885728;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10A;
					default:
						num2 = (short)12058625;
						if (num2 != 0)
						{
						}
						num2 = (short)1284571136;
						if (num2 != 0)
						{
						}
						num2 = (short)562036738;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				num2 = (short)1739915264;
				short num4 = num2;
				radioPresenceNotify = this.a;
				num2 = (short)1744371713;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600004F RID: 79 RVA: 0x00006400 File Offset: 0x00004600
		// (remove) Token: 0x06000050 RID: 80 RVA: 0x00006538 File Offset: 0x00004738
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle PacketReceived
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
				short num2;
				global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
				for (;;)
				{
					IL_0A:
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_63;
					case 2:
						IL_E1:
						num2 = (short)37879809;
						if (num2 != 0)
						{
						}
						if (packetRecivedHandle == packetRecivedHandle2)
						{
							num2 = (short)1323696128;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_63;
					}
					goto IL_1C;
					IL_63:
					packetRecivedHandle2 = packetRecivedHandle;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Combine(packetRecivedHandle2, value);
					packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.b, value2, packetRecivedHandle2);
					num2 = (short)500357637;
					short num3 = num2;
					num2 = (short)1535040005;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E1;
					default:
						num2 = (short)905576448;
						if (num2 != 0)
						{
						}
						num2 = (short)104792066;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				num2 = (short)47579136;
				short num4 = num2;
				packetRecivedHandle = this.b;
				num2 = (short)1325006849;
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
						return;
					case 1:
						goto IL_90;
					case 2:
						IL_110:
						if (packetRecivedHandle == packetRecivedHandle2)
						{
							num2 = (short)124583936;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_90;
					}
					goto IL_1C;
					IL_90:
					packetRecivedHandle2 = packetRecivedHandle;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Remove(packetRecivedHandle2, value);
					packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.b, value2, packetRecivedHandle2);
					num2 = (short)447039775;
					short num3 = num2;
					num2 = (short)856967455;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_110;
					default:
						num2 = (short)490143744;
						if (num2 != 0)
						{
						}
						num2 = (short)194707458;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				num2 = (short)777256960;
				short num4 = num2;
				packetRecivedHandle = this.b;
				num2 = (short)1963130881;
				if (num2 != 0)
				{
				}
				num2 = (short)1493106689;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000051 RID: 81 RVA: 0x00006678 File Offset: 0x00004878
		// (remove) Token: 0x06000052 RID: 82 RVA: 0x000067B0 File Offset: 0x000049B0
		public event global::SSLMangrComp.ConnectionManagerWatcher.ErrorReceivedHandle HandleError
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
				global::SSLMangrComp.ConnectionManagerWatcher.ErrorReceivedHandle errorReceivedHandle;
				short num2;
				for (;;)
				{
					IL_0A:
					global::SSLMangrComp.ConnectionManagerWatcher.ErrorReceivedHandle errorReceivedHandle2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_63;
					case 2:
						IL_10A:
						if (errorReceivedHandle == errorReceivedHandle2)
						{
							num2 = (short)1839529984;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_63;
					}
					goto IL_1C;
					IL_63:
					errorReceivedHandle2 = errorReceivedHandle;
					global::SSLMangrComp.ConnectionManagerWatcher.ErrorReceivedHandle value2 = (global::SSLMangrComp.ConnectionManagerWatcher.ErrorReceivedHandle)global::System.Delegate.Combine(errorReceivedHandle2, value);
					errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionManagerWatcher.ErrorReceivedHandle>(ref this.c, value2, errorReceivedHandle2);
					num2 = (short)476971009;
					if (num2 != 0)
					{
					}
					num2 = (short)1702242589;
					short num3 = num2;
					num2 = (short)1723476253;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10A;
					default:
						num2 = (short)715980800;
						if (num2 != 0)
						{
						}
						num2 = (short)1849163778;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				num2 = (short)1260716032;
				short num4 = num2;
				errorReceivedHandle = this.c;
				num2 = (short)1917779969;
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
				global::SSLMangrComp.ConnectionManagerWatcher.ErrorReceivedHandle errorReceivedHandle;
				global::SSLMangrComp.ConnectionManagerWatcher.ErrorReceivedHandle errorReceivedHandle2;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_AE;
					case 1:
						if (errorReceivedHandle == errorReceivedHandle2)
						{
							num2 = (short)1747779585;
							if (num2 != 0)
							{
							}
							num2 = (short)690946050;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B0;
					case 2:
						return;
					}
					goto IL_1C;
				}
				IL_AE:
				IL_B0:
				errorReceivedHandle2 = errorReceivedHandle;
				global::SSLMangrComp.ConnectionManagerWatcher.ErrorReceivedHandle value2 = (global::SSLMangrComp.ConnectionManagerWatcher.ErrorReceivedHandle)global::System.Delegate.Remove(errorReceivedHandle2, value);
				errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionManagerWatcher.ErrorReceivedHandle>(ref this.c, value2, errorReceivedHandle2);
				goto IL_CD;
				IL_1C:
				num2 = (short)927390715;
				short num3 = num2;
				num2 = (short)1156832251;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_CD:
					num2 = (short)2124873729;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				case 1:
					break;
				default:
				{
					num2 = (short)354025472;
					short num4 = num2;
					break;
				}
				}
				num2 = (short)641073152;
				if (num2 != 0)
				{
				}
				errorReceivedHandle = this.c;
				num2 = (short)427360256;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000068E8 File Offset: 0x00004AE8
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00006998 File Offset: 0x00004B98
		public int Expire
		{
			get
			{
				short num = (short)1752653635;
				short num2 = num;
				num = (short)1822318403;
				switch (num2 == num)
				{
				}
				num = (short)1425342464;
				short num3 = num;
				num = (short)529465345;
				if (num != 0)
				{
				}
				num = (short)1699807232;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1439602238;
				short num2 = num;
				num = (short)1383503422;
				switch (num2 == num)
				{
				}
				num = (short)840630272;
				short num3 = num;
				num = (short)2043346945;
				if (num != 0)
				{
				}
				num = (short)38207488;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00006AF8 File Offset: 0x00004CF8
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00006A44 File Offset: 0x00004C44
		public global::SSLMangrComp.Packets.EntitiesTypes EntityType
		{
			get
			{
				short num = (short)2130616703;
				short num2 = num;
				num = (short)775463295;
				switch (num2 == num)
				{
				}
				num = (short)1296695296;
				short num3 = num;
				num = (short)1346633729;
				if (num != 0)
				{
				}
				num = (short)891289600;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)678756353;
				if (num != 0)
				{
				}
				num = (short)1104845376;
				short num2 = num;
				num = (short)1050450496;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1035862016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1415380992;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00006C5C File Offset: 0x00004E5C
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00006BA8 File Offset: 0x00004DA8
		public string Entity
		{
			get
			{
				short num = (short)1535312838;
				short num2 = num;
				num = (short)911082438;
				switch (num2 == num)
				{
				}
				num = (short)1251606528;
				short num3 = num;
				num = (short)396951552;
				if (num != 0)
				{
				}
				num = (short)603783169;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)815661057;
				if (num != 0)
				{
				}
				num = (short)769619827;
				short num2 = num;
				num = (short)79853427;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1611530240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)91029504;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00006DB8 File Offset: 0x00004FB8
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00006D0C File Offset: 0x00004F0C
		public string subEvents
		{
			get
			{
				short num = (short)170339168;
				short num2 = num;
				num = (short)50146144;
				switch (num2 == num)
				{
				}
				num = (short)453902336;
				short num3 = num;
				num = (short)1029308417;
				if (num != 0)
				{
				}
				num = (short)89915392;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)1839398913;
				if (num != 0)
				{
				}
				num = (short)148139308;
				short num2 = num;
				num = (short)881945900;
				switch (num2 == num)
				{
				default:
				{
					num = (short)748421120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)571408384;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00006E68 File Offset: 0x00005068
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00006F18 File Offset: 0x00005118
		public global::SSLMangrComp.Packets.SubscriptionType Mode
		{
			get
			{
				short num = (short)50589243;
				short num2 = num;
				num = (short)1654779451;
				switch (num2 == num)
				{
				}
				num = (short)1230831616;
				short num3 = num;
				num = (short)1714880513;
				if (num != 0)
				{
				}
				num = (short)731512832;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)91605345;
				short num2 = num;
				num = (short)1434831201;
				switch (num2 == num)
				{
				}
				num = (short)1877082112;
				short num3 = num;
				num = (short)257818624;
				if (num != 0)
				{
				}
				num = (short)384827393;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00006FCC File Offset: 0x000051CC
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00007080 File Offset: 0x00005280
		public string Timeout
		{
			get
			{
				short num = (short)1841813719;
				short num2 = num;
				num = (short)543086807;
				switch (num2 == num)
				{
				}
				num = (short)1706164224;
				short num3 = num;
				num = (short)1628045313;
				if (num != 0)
				{
				}
				num = (short)1633288192;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				short num = (short)1354104660;
				short num2 = num;
				num = (short)2121072468;
				switch (num2 == num)
				{
				}
				num = (short)826474496;
				short num3 = num;
				num = (short)223608833;
				if (num != 0)
				{
				}
				num = (short)588382208;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00007130 File Offset: 0x00005330
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000071E0 File Offset: 0x000053E0
		public global::SSLMangrComp.PNConnectionInfo ServerInfo
		{
			get
			{
				short num = (short)1925185475;
				short num2 = num;
				num = (short)1610481603;
				switch (num2 == num)
				{
				}
				num = (short)1998585856;
				short num3 = num;
				num = (short)1192558592;
				if (num != 0)
				{
				}
				num = (short)963051521;
				if (num != 0)
				{
				}
				return this.l;
			}
			set
			{
				short num = (short)1662844929;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				int num2;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (value.PNConnectionConfig != null)
						{
							num = (short)870318084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						if (this.m == null)
						{
							goto IL_156;
						}
						num = (short)11089433;
						short num3 = num;
						num = (short)793851417;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_103;
						default:
						{
							num = (short)67502080;
							short num4 = num;
							num = (short)1206910976;
							if (num != 0)
							{
							}
							num = (short)269680643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						goto IL_103;
					case 4:
						this.j = this.l.PNConnectionConfig.SubscriptionMode;
						this.k = this.l.PNConnectionConfig.ConnectionAttemptTimeout.ToString();
						num = (short)1858600960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_156;
					}
					goto IL_50;
					IL_103:
					this.m.ServerInfo = value;
					num = (short)1147600901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_156:
					num = (short)104726529;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_50:
				this.l = value;
				num = (short)2124218370;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000061 RID: 97 RVA: 0x000073A4 File Offset: 0x000055A4
		// (remove) Token: 0x06000062 RID: 98 RVA: 0x00007460 File Offset: 0x00005660
		public event global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify RadioFound
		{
			add
			{
				short num = (short)2115147625;
				short num2 = num;
				num = (short)546477929;
				switch (num2 == num)
				{
				}
				num = (short)602144768;
				short num3 = num;
				num = (short)1225785345;
				if (num != 0)
				{
				}
				num = (short)1702232064;
				if (num != 0)
				{
				}
				this.a = null;
				global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareDelegate(value);
				this.radioFound += value;
			}
			remove
			{
				short num = (short)99327765;
				short num2 = num;
				num = (short)891789077;
				switch (num2 == num)
				{
				}
				num = (short)1926955008;
				short num3 = num;
				num = (short)1618608129;
				if (num != 0)
				{
				}
				num = (short)1316683776;
				if (num != 0)
				{
				}
				this.radioFound -= value;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007510 File Offset: 0x00005710
		public ConnectionManagerWatcher()
		{
			int a_ = 13;
			this.d = global::SSLMangrComp.PresenceInfo.Instance;
			this.e = global::SSLMangrComp.ErrorReporter.Instance;
			this.g = global::SSLMangrComp.Packets.EntitiesTypes.DeviceID;
			this.h = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("༾", a_);
			this.i = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("฾獀", a_);
			this.k = string.Empty;
			this.strRadIP = string.Empty;
			this.strSubState = string.Empty;
			this.strDeviceId = string.Empty;
			this.strEntityType = string.Empty;
			this.reEventValue = 2U;
			base..ctor();
			this.m_pCB = new global::SSLMangrComp.PresenceInfo_CallBack(this.SetParentDataObjects);
			this.m_eCB = new global::SSLMangrComp.ReportOnError_CallBack(this.SetErrorDataObjects);
			this.m = new global::SSLMangrComp.LinkManagerWatcher();
			this.n = new global::SSLMangrComp.LinkManagerWatcher();
			this.PacketReceived += this.a;
			this.HandleError += this.b;
			if (this.m != null)
			{
				this.m.PacketSentOrRecived += this.b;
				this.m.ErrorReceived += this.b;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00007648 File Offset: 0x00005848
		private void b(global::SSLMangrComp.ErrorReport A_0)
		{
			short num = (short)1504968705;
			if (num != 0)
			{
			}
			num = (short)369906738;
			short num2 = num;
			num = (short)9131058;
			switch (num2 == num)
			{
			default:
			{
				num = (short)266076160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)89128960;
			if (num != 0)
			{
			}
			this.nErrorCategory = (int)A_0.ErrCat;
			this.nErrorId = A_0.ErrorID;
			this.p = true;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007714 File Offset: 0x00005914
		private void b(global::SSLMangrComp.Packets.PacketBase A_0)
		{
			int a_ = 17;
			global::SSLMangrComp.PresenceNotification presenceNotification;
			for (;;)
			{
				IL_09:
				short num = (short)352976896;
				switch (num)
				{
				default:
				{
					num = (short)1181941773;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string packetDescription;
						switch (num2)
						{
						case 0:
							goto IL_3A5;
						case 1:
							if (this.a != null)
							{
								num = (short)1289682954;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 2:
						{
							global::SSLMangrComp.PresenceNotification deviceId;
							this.a(deviceId);
							num = (short)1556611087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							num = (short)1045823488;
							short num3 = num;
							num = (short)1077215239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::SSLMangrComp.PresenceInfo instance = global::SSLMangrComp.PresenceInfo.Instance;
							global::SSLMangrComp.PresenceNotification deviceId = new global::SSLMangrComp.PresenceNotification();
							deviceId = instance.SendPresenceNotification(A_0);
							if (this.b != null)
							{
								this.b(A_0);
							}
							instance.SendPresenceInfo(this.m_pCB);
							instance.CallPresenceInfoCallback(ref deviceId);
							this.p = true;
							num = (short)460324880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)1751449609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::SSLMangrComp.PresenceInfo instance2 = global::SSLMangrComp.PresenceInfo.Instance;
							presenceNotification = new global::SSLMangrComp.PresenceNotification();
							presenceNotification.DeviceId = this.l.PNConnectionConfig.EntityValue;
							presenceNotification.EntityType = this.l.PNConnectionConfig.EntityType.ToString();
							presenceNotification.PresenceState = global::SSLMangrComp.PresenceState.Absent;
							presenceNotification.EventValue = global::SSLMangrComp.RequestEvent.Unknown;
							if (this.b != null)
							{
								this.b(A_0);
							}
							instance2.SendPresenceInfo(this.m_pCB);
							instance2.CallPresenceInfoCallback(ref presenceNotification);
							this.p = true;
							num = (short)2041839617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							num = (short)802888731;
							short num4 = num;
							num = (short)1508449307;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)11599872;
								if (num != 0)
								{
								}
								if (packetDescription.Contains(global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("B⑄⥆⩈⹊⅌", a_)))
								{
									num = (short)476643328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return;
							}
							break;
						}
						case 8:
							num = (short)1450967046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (A_0.MessageID == 255)
							{
								num = (short)746979336;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EA;
						case 10:
							goto IL_1DB;
						case 11:
							num = (short)956629004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (!(packetDescription == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ᙂ⭄㕆ⱈ❊⑌⹎㍐㽒ご睖᝘㑚⥜㙞ݠᩢ䕤⩦౨ᡪṬ๮ᙰᙲ", a_)))
							{
								num = (short)1138032643;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3A5;
						case 13:
							switch (0)
							{
							case 0:
								goto IL_91;
							}
							continue;
						case 14:
							if (!(packetDescription == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ᅂ⁄⭆⁈⩊⽌⍎㑐獒᭔㡖ⵘ㉚㭜♞䅠⹢dᑦᩨ੪੬੮", a_)))
							{
								num = (short)124911627;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3A5;
						case 15:
							return;
						case 16:
							if (this.a != null)
							{
								num = (short)1868627970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						IL_91:
						if (this.m.ActiveSubscriptionList.Count == 1)
						{
							num = (short)1801584645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1EA:
						num = (short)693305345;
						if (num != 0)
						{
						}
						string[] array = new string[]
						{
							A_0.PacketDataTime.ToLongTimeString(),
							A_0.DialogID.ToString(),
							A_0.getPacketDescription()
						};
						packetDescription = A_0.getPacketDescription();
						num = (short)832045070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3A5:
						num = (short)1067646980;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_1DB:
			this.a(presenceNotification);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007B88 File Offset: 0x00005D88
		private void c()
		{
			short num = (short)318570498;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_86;
				case 1:
					if (this.c != null)
					{
						num = (short)1551433732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_144;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 3:
					goto IL_5B;
				case 4:
				{
					num = (short)1660284730;
					short num3 = num;
					num = (short)226357050;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B;
					default:
						num = (short)1274871808;
						if (num != 0)
						{
						}
						this.HandleError -= this.a;
						num = (short)1319698432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					goto IL_8B;
				}
				IL_3E:
				if (this.b != null)
				{
					num = (short)1916338179;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_8B;
				IL_5B:
				this.PacketReceived -= this.a;
				num = (short)337838085;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8B:
				num = (short)1098121217;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_86:
			IL_144:
			num = (short)533200896;
			short num4 = num;
			num = (short)1452867585;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007D2C File Offset: 0x00005F2C
		public void SetParentDataObjects(ref global::SSLMangrComp.PresenceNotification Pn)
		{
			short num = (short)349503489;
			if (num != 0)
			{
			}
			num = (short)483054875;
			short num2 = num;
			num = (short)1358550299;
			switch (num2 == num)
			{
			default:
			{
				num = (short)125435904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1003094016;
			if (num != 0)
			{
			}
			this.strRadIP = Pn.IPAddr;
			this.strSubState = Pn.SubscriptionState;
			this.strDeviceId = Pn.DeviceId;
			this.strEntityType = Pn.EntityType;
			this.reEventValue = (uint)Pn.EventValue;
			this.psPresenceState = (uint)Pn.PresenceState;
			this.nErrorCategory = (int)this.e.ReportCategory;
			this.nErrorId = this.e.ReportId;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007E44 File Offset: 0x00006044
		public void ResetParentDataObjects()
		{
			short num = (short)1403076378;
			short num2 = num;
			num = (short)147210010;
			switch (num2 == num)
			{
			}
			num = (short)2125987840;
			short num3 = num;
			num = (short)1179058177;
			if (num != 0)
			{
			}
			num = (short)921042944;
			if (num != 0)
			{
			}
			this.strRadIP = string.Empty;
			this.strSubState = string.Empty;
			this.strDeviceId = string.Empty;
			this.strEntityType = string.Empty;
			this.reEventValue = 2U;
			this.psPresenceState = 0U;
			this.nErrorCategory = 0;
			this.nErrorId = (global::IACustomException.IACommonErrorCode)0;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007F38 File Offset: 0x00006138
		public void SetErrorDataObjects(ref global::SSLMangrComp.ErrorReport ErrorRep)
		{
			short num = (short)678384320;
			short num2 = num;
			num = (short)801067712;
			switch (num2 == num)
			{
			}
			num = (short)1406205952;
			short num3 = num;
			num = (short)1157824513;
			if (num != 0)
			{
			}
			num = (short)256507904;
			if (num != 0)
			{
			}
			this.nErrorCategory = (int)ErrorRep.ErrCat;
			this.nErrorId = ErrorRep.ErrorID;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007FFC File Offset: 0x000061FC
		private void b()
		{
			short num = (short)790061779;
			short num2 = num;
			num = (short)14770899;
			switch (num2 == num)
			{
			}
			num = (short)76480512;
			short num3 = num;
			num = (short)1869348865;
			if (num != 0)
			{
			}
			num = (short)399179776;
			if (num != 0)
			{
			}
			this.ResetParentDataObjects();
			this.d.ResetPresenceNotification();
			this.e.ResetErrorReport();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000080C4 File Offset: 0x000062C4
		private void a(global::SSLMangrComp.Packets.PacketBase A_0)
		{
			short num = (short)1933678820;
			short num2 = num;
			num = (short)1477941476;
			switch (num2 == num)
			{
			}
			num = (short)556924928;
			short num3 = num;
			num = (short)190447617;
			if (num != 0)
			{
			}
			num = (short)928055296;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000816C File Offset: 0x0000636C
		private void a(global::SSLMangrComp.ErrorReport A_0)
		{
			short num = (short)1280638977;
			if (num != 0)
			{
			}
			num = (short)601629260;
			short num2 = num;
			num = (short)1095705164;
			switch (num2 == num)
			{
			default:
			{
				num = (short)687013888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1334837248;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008218 File Offset: 0x00006418
		public void RegisterAsWatcher(global::System.Collections.Generic.List<string> RadioList)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					global::System.Collections.Generic.List<string>.Enumerator enumerator;
					switch (num)
					{
					case 0:
						this.m.CancelExistingSubscription(RadioList);
						global::System.Threading.Thread.Sleep(4000);
						num2 = (short)1479933955;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
					{
						num2 = (short)1153564672;
						short num3 = num2;
						if (this.m.ActiveSubscriptionList.Count > 0)
						{
							num2 = (short)1396506624;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1C1;
					}
					case 2:
						try
						{
							num2 = (short)1884160001;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num2 = (short)906952707;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									string entityValue = enumerator.Current;
									this.ServerInfo.PNConnectionConfig.EntityValue = entityValue;
									this.b();
									this.a();
									global::System.Threading.Thread.Sleep(1750);
									num2 = (short)1667235842;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_118;
									}
									continue;
								case 3:
									num2 = (short)373620740;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 4:
									goto IL_1AE;
								}
								IL_15F:
								num2 = (short)940769280;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_118:
								goto IL_15F;
							}
							IL_1AE:
							goto IL_263;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1C1;
					case 3:
						goto IL_1C1;
					}
					goto IL_20;
					IL_1C1:
					enumerator = RadioList.GetEnumerator();
					num2 = (short)351929982;
					short num4 = num2;
					num2 = (short)799213182;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						num2 = (short)1537277952;
						if (num2 != 0)
						{
						}
						num2 = (short)851050498;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				IL_263:
				this.m.ClientClose();
				return;
			}
			IL_20:
			num2 = (short)1658454017;
			if (num2 != 0)
			{
			}
			this.m.ServerInfo = this.ServerInfo;
			this.m.StartListener();
			this.m.ClientConnect();
			IL_6F:
			num2 = (short)777388033;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000084A4 File Offset: 0x000066A4
		public void closePN()
		{
			short num = (short)299237379;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)558674734;
					short num3 = num;
					num = (short)170636078;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16F;
					default:
						goto IL_98;
					}
					break;
				}
				case 1:
					num = (short)234422274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.m.ServerInfo != null)
					{
						goto IL_16F;
					}
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 4:
					if (this.m.ActiveSubscriptionList.Count > 0)
					{
						num = (short)1942683648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.m.ShutDownListen();
					num = (short)244776965;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
					num = (short)741015556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_40:
				if (this.l != null)
				{
					num = (short)2108227585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_16F:
				num = (short)1979318272;
				short num4 = num;
				num = (short)321191942;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_98:
			num = (short)1022296064;
			if (num != 0)
			{
			}
			num = (short)1628241921;
			if (num != 0)
			{
			}
			this.m.StartListener();
			this.m.ClientConnect();
			this.m.CancelAllSubscriptions();
			this.m.ClientClose();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000868C File Offset: 0x0000688C
		public void DeregisterAsWatcher(global::System.Collections.Generic.List<string> RadioList)
		{
			short num = (short)885719042;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					this.m.ServerInfo = this.ServerInfo;
					this.m.StartListener();
					this.m.ClientConnect();
					this.m.CancelExistingSubscription(RadioList);
					global::System.Threading.Thread.Sleep(4000);
					this.m.ClientClose();
					num = (short)649068544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)504241763;
					short num3 = num;
					num = (short)485105251;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1313210368;
						short num4 = num;
						num = (short)1252786176;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					}
					break;
				}
				}
				IL_A3:
				num = (short)1002831873;
				if (num != 0)
				{
				}
				if (this.m.ActiveSubscriptionList.Count <= 0)
				{
					break;
				}
				num = (short)482148353;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000087F0 File Offset: 0x000069F0
		private void a()
		{
			short num = (short)204668929;
			if (num != 0)
			{
			}
			num = (short)58418987;
			short num2 = num;
			num = (short)273508139;
			switch (num2 == num)
			{
			}
			num = (short)1211498496;
			short num3 = num;
			num = (short)774701056;
			if (num != 0)
			{
			}
			this.m.Subscribe(this.i);
		}

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionManagerWatcher.RadioPresenceNotify a;

		// Token: 0x04000028 RID: 40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle b;

		// Token: 0x04000029 RID: 41
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionManagerWatcher.ErrorReceivedHandle c;

		// Token: 0x0400002A RID: 42
		public global::SSLMangrComp.PresenceInfo_CallBack m_pCB;

		// Token: 0x0400002B RID: 43
		public global::SSLMangrComp.ReportOnError_CallBack m_eCB;

		// Token: 0x0400002C RID: 44
		private readonly global::SSLMangrComp.PresenceInfo d;

		// Token: 0x0400002D RID: 45
		private readonly global::SSLMangrComp.ErrorReporter e;

		// Token: 0x0400002E RID: 46
		private int f;

		// Token: 0x0400002F RID: 47
		private global::SSLMangrComp.Packets.EntitiesTypes g;

		// Token: 0x04000030 RID: 48
		private string h;

		// Token: 0x04000031 RID: 49
		private string i;

		// Token: 0x04000032 RID: 50
		private global::SSLMangrComp.Packets.SubscriptionType j;

		// Token: 0x04000033 RID: 51
		private string k;

		// Token: 0x04000034 RID: 52
		public string strRadIP;

		// Token: 0x04000035 RID: 53
		public string strSubState;

		// Token: 0x04000036 RID: 54
		public string strDeviceId;

		// Token: 0x04000037 RID: 55
		public string strEntityType;

		// Token: 0x04000038 RID: 56
		public uint reEventValue;

		// Token: 0x04000039 RID: 57
		public uint psPresenceState;

		// Token: 0x0400003A RID: 58
		public int nErrorCategory;

		// Token: 0x0400003B RID: 59
		public global::IACustomException.IACommonErrorCode nErrorId;

		// Token: 0x0400003C RID: 60
		private global::SSLMangrComp.PNConnectionInfo l;

		// Token: 0x0400003D RID: 61
		private readonly global::SSLMangrComp.LinkManagerWatcher m;

		// Token: 0x0400003E RID: 62
		private global::SSLMangrComp.LinkManagerWatcher n;

		// Token: 0x0400003F RID: 63
		private bool o;

		// Token: 0x04000040 RID: 64
		private bool p;

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000072 RID: 114
		public delegate void RadioPresenceNotify(global::SSLMangrComp.PresenceNotification DeviceId);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000076 RID: 118
		public delegate void ErrorReceivedHandle(global::SSLMangrComp.ErrorReport report);
	}
}
