using System;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace SSLAdminTool
{
	// Token: 0x02000005 RID: 5
	public sealed class PNServer
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00003A28 File Offset: 0x00001C28
		public PNServer()
		{
			int a_ = 13;
			this.a = global::SSLAdminTool.RawData.b("蓓飕觙맛곝雟蟡難웥\ud9e7", a_);
			this.b = string.Empty;
			this.c = global::SSLAdminTool.RawData.b("闓鏕诗髝ꗟ뇡\udee3쟥곧맩뿫퓭ꏯ뫱뗳쳵\ud9f7鯹닻꯽䳿丁㸃✅洇䐉夋䈍小⠑㔓刕崗䤙☛㼝洟昡ᄣᰥध挩栫欭焯࠱ᔳ搵笷࠹ػἽሿŁ灃籅ࡇ᥉ᡋᱍᕏ᱑ፓɕၗ", a_);
			this.d = new global::System.Net.IPAddress(new byte[]
			{
				127,
				0,
				0,
				1
			});
			this.e = global::SSLAdminTool.RawData.b("", a_);
			this.f = global::SSLAdminTool.RawData.b("", a_);
			this.g = global::SSLAdminTool.RawData.b("", a_);
			this.h = global::SSLAdminTool.RawData.b("", a_);
			this.k = global::SSLAdminTool.RecordType.UNS;
			this.m = string.Empty;
			this.n = string.Empty;
			this.o = string.Empty;
			this.p = string.Empty;
			this.q = string.Empty;
			this.r = string.Empty;
			this.s = string.Empty;
			this.t = string.Empty;
			this.u = string.Empty;
			this.v = string.Empty;
			base..ctor();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003B58 File Offset: 0x00001D58
		public PNServer(string Name, string PWPhrase, string CipherSuite, global::System.Net.IPAddress PNServerIP, bool UdpConn, bool SecConn, global::System.Enum RType, ushort PNum, string CACert, string ClientCert, string Hostname, string imwHostname, string imwPort, string imwMgmPort, string imwOAuthHostname, string imwOAuthPort, string imwOAuthCid, string imwOAuthCSec)
		{
			int a_ = 18;
			this.a = global::SSLAdminTool.RawData.b("觘闚﷜賞蓠釢鏤苦鯨쯪\udcec", a_);
			this.b = string.Empty;
			this.c = global::SSLAdminTool.RawData.b("飘黚軜틠꟢ꃤ듦폨쫪ꧬ볮ꋰ짲꛴뿶룸쇺\udcfc黾伀嘂䤄䬆㌈⨊栌䄎䐐弒夔ⴖ㠘弚堜䰞ᬠȢ栤挦ᰨᄪబ昮田瘲琴ശᠸ椺縼ാ筀扂ᝄц絈煊ൌᱎՐŒၔᥖṘཚᕜ", a_);
			this.d = new global::System.Net.IPAddress(new byte[]
			{
				127,
				0,
				0,
				1
			});
			this.e = global::SSLAdminTool.RawData.b("", a_);
			this.f = global::SSLAdminTool.RawData.b("", a_);
			this.g = global::SSLAdminTool.RawData.b("", a_);
			this.h = global::SSLAdminTool.RawData.b("", a_);
			this.k = global::SSLAdminTool.RecordType.UNS;
			this.m = string.Empty;
			this.n = string.Empty;
			this.o = string.Empty;
			this.p = string.Empty;
			this.q = string.Empty;
			this.r = string.Empty;
			this.s = string.Empty;
			this.t = string.Empty;
			this.u = string.Empty;
			this.v = string.Empty;
			base..ctor();
			this.PNSName = Name;
			this.PassWordPhrase = PWPhrase;
			this.CipherSuite = CipherSuite;
			this.PNServerIP = PNServerIP;
			this.UDPConn = UdpConn;
			this.SecureConn = SecConn;
			this.RecType = (global::SSLAdminTool.RecordType)RType;
			this.PortNum = PNum;
			this.PNSIp1 = this.PNServerIP.GetAddressBytes().ElementAt(0).ToString();
			this.PNSIp2 = this.PNServerIP.GetAddressBytes().ElementAt(1).ToString();
			this.PNSIp3 = this.PNServerIP.GetAddressBytes().ElementAt(2).ToString();
			this.PNSIp4 = this.PNServerIP.GetAddressBytes().ElementAt(3).ToString();
			this.CACert = CACert;
			this.ClientCert = ClientCert;
			this.Hostname = Hostname;
			this.IMWHostname = imwHostname;
			this.IMWPort = imwPort;
			this.IMWMGMPort = imwMgmPort;
			this.IMWOAuthHostname = imwOAuthHostname;
			this.IMWOAuthPort = imwOAuthPort;
			this.IMWOAuthCID = imwOAuthCid;
			this.IMWOAuthCSec = imwOAuthCSec;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00003D94 File Offset: 0x00001F94
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00003E44 File Offset: 0x00002044
		public string PNSName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)288620545;
				if (num != 0)
				{
				}
				num = (short)575363350;
				short num2 = num;
				num = (short)1850038550;
				switch (num2 == num)
				{
				}
				num = (short)1620901888;
				if (num != 0)
				{
				}
				num = (short)1648230400;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1132389909;
				short num2 = num;
				num = (short)690415125;
				switch (num2 == num)
				{
				}
				num = (short)37748737;
				if (num != 0)
				{
				}
				num = (short)64028672;
				if (num != 0)
				{
				}
				num = (short)867893248;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00003EF4 File Offset: 0x000020F4
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00003FA4 File Offset: 0x000021A4
		public string PassWordPhrase
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1236629638;
				short num2 = num;
				num = (short)1722841222;
				switch (num2 == num)
				{
				}
				num = (short)1952120833;
				if (num != 0)
				{
				}
				num = (short)552534016;
				if (num != 0)
				{
				}
				num = (short)1238892544;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1845856163;
				short num2 = num;
				num = (short)1486849955;
				switch (num2 == num)
				{
				}
				num = (short)1220739073;
				if (num != 0)
				{
				}
				num = (short)1887305728;
				if (num != 0)
				{
				}
				num = (short)647299072;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00004054 File Offset: 0x00002254
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00004104 File Offset: 0x00002304
		public string CipherSuite
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2049246716;
				short num2 = num;
				num = (short)1093797372;
				switch (num2 == num)
				{
				}
				num = (short)1302528001;
				if (num != 0)
				{
				}
				num = (short)1256456192;
				if (num != 0)
				{
				}
				num = (short)291307520;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1882390529;
				if (num != 0)
				{
				}
				num = (short)1170743433;
				short num2 = num;
				num = (short)1110057097;
				switch (num2 == num)
				{
				}
				num = (short)1209073664;
				if (num != 0)
				{
				}
				num = (short)689242112;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000041B8 File Offset: 0x000023B8
		// (set) Token: 0x0600001E RID: 30 RVA: 0x0000426C File Offset: 0x0000246C
		public global::System.Net.IPAddress PNServerIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1776785921;
				short num2 = num;
				num = (short)2002557441;
				switch (num2 == num)
				{
				}
				num = (short)800915456;
				if (num != 0)
				{
				}
				num = (short)526778369;
				if (num != 0)
				{
				}
				num = (short)643497984;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)703034675;
				short num2 = num;
				num = (short)121402675;
				switch (num2 == num)
				{
				}
				num = (short)1302200321;
				if (num != 0)
				{
				}
				num = (short)1980825600;
				if (num != 0)
				{
				}
				num = (short)1089994752;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000431C File Offset: 0x0000251C
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000043CC File Offset: 0x000025CC
		public string PNSIp1
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1697996594;
				short num2 = num;
				num = (short)897474354;
				switch (num2 == num)
				{
				}
				num = (short)941031424;
				if (num != 0)
				{
				}
				num = (short)774897665;
				if (num != 0)
				{
				}
				num = (short)1979842560;
				short num3 = num;
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)274575702;
				short num2 = num;
				num = (short)1756934486;
				switch (num2 == num)
				{
				}
				num = (short)2014117889;
				if (num != 0)
				{
				}
				num = (short)2089353216;
				if (num != 0)
				{
				}
				num = (short)1887436800;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00004480 File Offset: 0x00002680
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00004530 File Offset: 0x00002730
		public string PNSIp2
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)63650414;
				short num2 = num;
				num = (short)406796910;
				switch (num2 == num)
				{
				}
				num = (short)356777985;
				if (num != 0)
				{
				}
				num = (short)2104295424;
				if (num != 0)
				{
				}
				num = (short)1703215104;
				short num3 = num;
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1996166423;
				short num2 = num;
				num = (short)1313084695;
				switch (num2 == num)
				{
				}
				num = (short)938082304;
				if (num != 0)
				{
				}
				num = (short)1351221249;
				if (num != 0)
				{
				}
				num = (short)260833280;
				short num3 = num;
				this.f = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000045E0 File Offset: 0x000027E0
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00004690 File Offset: 0x00002890
		public string PNSIp3
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1227882497;
				if (num != 0)
				{
				}
				num = (short)435315150;
				short num2 = num;
				num = (short)1747608014;
				switch (num2 == num)
				{
				}
				num = (short)1142095872;
				if (num != 0)
				{
				}
				num = (short)1577910272;
				short num3 = num;
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1232840373;
				short num2 = num;
				num = (short)1093904053;
				switch (num2 == num)
				{
				}
				num = (short)923860992;
				if (num != 0)
				{
				}
				num = (short)1812660225;
				if (num != 0)
				{
				}
				num = (short)273809408;
				short num3 = num;
				this.g = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00004740 File Offset: 0x00002940
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000047F0 File Offset: 0x000029F0
		public string PNSIp4
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1324498134;
				short num2 = num;
				num = (short)1498954966;
				switch (num2 == num)
				{
				}
				num = (short)596180992;
				if (num != 0)
				{
				}
				num = (short)1717895169;
				if (num != 0)
				{
				}
				num = (short)1116405760;
				short num3 = num;
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1640606893;
				short num2 = num;
				num = (short)1829612717;
				switch (num2 == num)
				{
				}
				num = (short)326696960;
				if (num != 0)
				{
				}
				num = (short)256114689;
				if (num != 0)
				{
				}
				num = (short)976027648;
				short num3 = num;
				this.h = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000048A0 File Offset: 0x00002AA0
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00004950 File Offset: 0x00002B50
		public bool UDPConn
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1627542941;
				short num2 = num;
				num = (short)29709725;
				switch (num2 == num)
				{
				}
				num = (short)253034497;
				if (num != 0)
				{
				}
				num = (short)1161166848;
				if (num != 0)
				{
				}
				num = (short)1945567232;
				short num3 = num;
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)353511;
				short num2 = num;
				num = (short)1727685863;
				switch (num2 == num)
				{
				}
				num = (short)323289088;
				if (num != 0)
				{
				}
				num = (short)1435762689;
				if (num != 0)
				{
				}
				num = (short)1369964544;
				short num3 = num;
				this.i = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00004A00 File Offset: 0x00002C00
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00004AB0 File Offset: 0x00002CB0
		public bool SecureConn
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1240469815;
				short num2 = num;
				num = (short)817566007;
				switch (num2 == num)
				{
				}
				num = (short)415301632;
				if (num != 0)
				{
				}
				num = (short)2116550657;
				if (num != 0)
				{
				}
				num = (short)186515456;
				short num3 = num;
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1647464436;
				short num2 = num;
				num = (short)1379356660;
				switch (num2 == num)
				{
				}
				num = (short)1597767681;
				if (num != 0)
				{
				}
				num = (short)1823604736;
				if (num != 0)
				{
				}
				num = (short)917635072;
				short num3 = num;
				this.j = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00004B60 File Offset: 0x00002D60
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00004C0C File Offset: 0x00002E0C
		public global::SSLAdminTool.RecordType RecType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)718471169;
				if (num != 0)
				{
				}
				num = (short)318914872;
				short num2 = num;
				num = (short)1223639352;
				switch (num2 == num)
				{
				}
				num = (short)687931392;
				if (num != 0)
				{
				}
				num = (short)1142882304;
				short num3 = num;
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1710478775;
				short num2 = num;
				num = (short)1837946295;
				switch (num2 == num)
				{
				}
				num = (short)540082177;
				if (num != 0)
				{
				}
				num = (short)1813905408;
				if (num != 0)
				{
				}
				num = (short)438435840;
				short num3 = num;
				this.k = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00004CBC File Offset: 0x00002EBC
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00004D6C File Offset: 0x00002F6C
		public ushort PortNum
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1552299246;
				short num2 = num;
				num = (short)10237166;
				switch (num2 == num)
				{
				}
				num = (short)1723269121;
				if (num != 0)
				{
				}
				num = (short)1648885760;
				if (num != 0)
				{
				}
				num = (short)779747328;
				short num3 = num;
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)834159372;
				short num2 = num;
				num = (short)1362903820;
				switch (num2 == num)
				{
				}
				num = (short)1456865281;
				if (num != 0)
				{
				}
				num = (short)1449787392;
				if (num != 0)
				{
				}
				num = (short)1068367872;
				short num3 = num;
				this.l = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00004E1C File Offset: 0x0000301C
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00004ECC File Offset: 0x000030CC
		public string CACert
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)925703887;
				short num2 = num;
				num = (short)15802063;
				switch (num2 == num)
				{
				}
				num = (short)8585217;
				if (num != 0)
				{
				}
				num = (short)457048064;
				if (num != 0)
				{
				}
				num = (short)1503002624;
				short num3 = num;
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)824141565;
				short num2 = num;
				num = (short)464545533;
				switch (num2 == num)
				{
				}
				num = (short)1920008193;
				if (num != 0)
				{
				}
				num = (short)1677066240;
				if (num != 0)
				{
				}
				num = (short)353894400;
				short num3 = num;
				this.m = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00004F7C File Offset: 0x0000317C
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00005028 File Offset: 0x00003228
		public string ClientCert
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)137456466;
				short num2 = num;
				num = (short)1719036754;
				switch (num2 == num)
				{
				}
				num = (short)1802240001;
				if (num != 0)
				{
				}
				num = (short)656146432;
				if (num != 0)
				{
				}
				num = (short)607846400;
				short num3 = num;
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2133590017;
				if (num != 0)
				{
				}
				num = (short)2060290050;
				short num2 = num;
				num = (short)869107714;
				switch (num2 == num)
				{
				}
				num = (short)692191232;
				if (num != 0)
				{
				}
				num = (short)1262485504;
				short num3 = num;
				this.n = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000050DC File Offset: 0x000032DC
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00005188 File Offset: 0x00003388
		public string Hostname
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1297385658;
				short num2 = num;
				num = (short)273320122;
				switch (num2 == num)
				{
				}
				num = (short)704249857;
				if (num != 0)
				{
				}
				num = (short)960167936;
				if (num != 0)
				{
				}
				num = (short)1649016832;
				short num3 = num;
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1050776287;
				short num2 = num;
				num = (short)1923912415;
				switch (num2 == num)
				{
				}
				num = (short)1683881984;
				if (num != 0)
				{
				}
				num = (short)433192961;
				if (num != 0)
				{
				}
				num = (short)1925185536;
				short num3 = num;
				this.o = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00005238 File Offset: 0x00003438
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000052E8 File Offset: 0x000034E8
		public string IMWHostname
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)713300711;
				short num2 = num;
				num = (short)580655847;
				switch (num2 == num)
				{
				}
				num = (short)2046164993;
				if (num != 0)
				{
				}
				num = (short)469958656;
				if (num != 0)
				{
				}
				num = (short)1951072256;
				short num3 = num;
				return this.p;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)639925923;
				short num2 = num;
				num = (short)1574076067;
				switch (num2 == num)
				{
				}
				num = (short)590413825;
				if (num != 0)
				{
				}
				num = (short)371326976;
				if (num != 0)
				{
				}
				num = (short)1929052160;
				short num3 = num;
				this.p = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000539C File Offset: 0x0000359C
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00005448 File Offset: 0x00003648
		public string IMWPort
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)487305828;
				short num2 = num;
				num = (short)1709552228;
				switch (num2 == num)
				{
				}
				num = (short)585170945;
				if (num != 0)
				{
				}
				num = (short)396165120;
				if (num != 0)
				{
				}
				num = (short)103350272;
				short num3 = num;
				return this.q;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)81209723;
				short num2 = num;
				num = (short)1323116923;
				switch (num2 == num)
				{
				}
				num = (short)658374657;
				if (num != 0)
				{
				}
				num = (short)1877016576;
				if (num != 0)
				{
				}
				num = (short)1901723648;
				short num3 = num;
				this.q = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000054F8 File Offset: 0x000036F8
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000055A8 File Offset: 0x000037A8
		public string IMWMGMPort
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)756249034;
				short num2 = num;
				num = (short)1300853194;
				switch (num2 == num)
				{
				}
				num = (short)1620115457;
				if (num != 0)
				{
				}
				num = (short)1826095104;
				if (num != 0)
				{
				}
				num = (short)1471938560;
				short num3 = num;
				return this.r;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)166130048;
				short num2 = num;
				num = (short)1074459008;
				switch (num2 == num)
				{
				}
				num = (short)475922433;
				if (num != 0)
				{
				}
				num = (short)118882304;
				if (num != 0)
				{
				}
				num = (short)1119551488;
				short num3 = num;
				this.r = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00005658 File Offset: 0x00003858
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00005704 File Offset: 0x00003904
		public string IMWOAuthHostname
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1040953086;
				short num2 = num;
				num = (short)161132286;
				switch (num2 == num)
				{
				}
				num = (short)675479553;
				if (num != 0)
				{
				}
				num = (short)1915748352;
				if (num != 0)
				{
				}
				num = (short)1477050368;
				short num3 = num;
				return this.s;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)691602842;
				short num2 = num;
				num = (short)378668442;
				switch (num2 == num)
				{
				}
				num = (short)1139146753;
				if (num != 0)
				{
				}
				num = (short)248381440;
				if (num != 0)
				{
				}
				num = (short)615186432;
				short num3 = num;
				this.s = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000057B4 File Offset: 0x000039B4
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00005868 File Offset: 0x00003A68
		public string IMWOAuthPort
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)908064377;
				short num2 = num;
				num = (short)1817900665;
				switch (num2 == num)
				{
				}
				num = (short)560594945;
				if (num != 0)
				{
				}
				num = (short)481820672;
				if (num != 0)
				{
				}
				num = (short)1265500160;
				short num3 = num;
				return this.t;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)829076402;
				short num2 = num;
				num = (short)2099360690;
				switch (num2 == num)
				{
				}
				num = (short)1016004608;
				if (num != 0)
				{
				}
				num = (short)1276510209;
				if (num != 0)
				{
				}
				num = (short)518586368;
				short num3 = num;
				this.t = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00005918 File Offset: 0x00003B18
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000059C4 File Offset: 0x00003BC4
		public string IMWOAuthCID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)844300915;
				short num2 = num;
				num = (short)1333789299;
				switch (num2 == num)
				{
				}
				num = (short)1336475648;
				if (num != 0)
				{
				}
				num = (short)1950547969;
				if (num != 0)
				{
				}
				num = (short)1651441664;
				short num3 = num;
				return this.u;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)19780070;
				short num2 = num;
				num = (short)1628361190;
				switch (num2 == num)
				{
				}
				num = (short)1429012481;
				if (num != 0)
				{
				}
				num = (short)1869152256;
				if (num != 0)
				{
				}
				num = (short)196476928;
				short num3 = num;
				this.u = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00005A74 File Offset: 0x00003C74
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00005B28 File Offset: 0x00003D28
		public string IMWOAuthCSec
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1943193585;
				short num2 = num;
				num = (short)156026865;
				switch (num2 == num)
				{
				}
				num = (short)1743192065;
				if (num != 0)
				{
				}
				num = (short)3473408;
				if (num != 0)
				{
				}
				num = (short)1864040448;
				short num3 = num;
				return this.v;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)415606065;
				short num2 = num;
				num = (short)528131377;
				switch (num2 == num)
				{
				}
				num = (short)241238016;
				if (num != 0)
				{
				}
				num = (short)697303041;
				if (num != 0)
				{
				}
				num = (short)2144796672;
				short num3 = num;
				this.v = value;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005BD8 File Offset: 0x00003DD8
		public override string ToString()
		{
			short num = (short)135569068;
			short num2 = num;
			num = (short)2056887980;
			switch (num2 == num)
			{
			default:
			{
				num = (short)643760128;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)438960129;
			if (num != 0)
			{
			}
			num = (short)2131427328;
			if (num != 0)
			{
			}
			return this.PNSName;
		}

		// Token: 0x0400001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x0400001E RID: 30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x0400001F RID: 31
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x04000020 RID: 32
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Net.IPAddress d;

		// Token: 0x04000021 RID: 33
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;

		// Token: 0x04000022 RID: 34
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;

		// Token: 0x04000023 RID: 35
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string g;

		// Token: 0x04000024 RID: 36
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string h;

		// Token: 0x04000025 RID: 37
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool i;

		// Token: 0x04000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool j;

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLAdminTool.RecordType k;

		// Token: 0x04000028 RID: 40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort l;

		// Token: 0x04000029 RID: 41
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string m;

		// Token: 0x0400002A RID: 42
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string n;

		// Token: 0x0400002B RID: 43
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string o;

		// Token: 0x0400002C RID: 44
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string p;

		// Token: 0x0400002D RID: 45
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string q;

		// Token: 0x0400002E RID: 46
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string r;

		// Token: 0x0400002F RID: 47
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string s;

		// Token: 0x04000030 RID: 48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string t;

		// Token: 0x04000031 RID: 49
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string u;

		// Token: 0x04000032 RID: 50
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string v;
	}
}
