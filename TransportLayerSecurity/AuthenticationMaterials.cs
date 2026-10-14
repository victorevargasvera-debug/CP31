using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TLS.TlsPskForAstro;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x02000003 RID: 3
	public class AuthenticationMaterials
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000215C File Offset: 0x0000035C
		public AuthenticationMaterials(global::Motorola.Common.Communication.TLS.SecurityEndpointMode mode, string authMaterials1, string authMaterials2)
		{
			if (global::Motorola.Common.Communication.TLS.AuthenticationMaterials.IsPskValid(authMaterials1, authMaterials2))
			{
				this.a = global::System.Text.Encoding.UTF8.GetBytes(authMaterials1);
				this.b = global::Motorola.Common.Communication.CommonUtil.UtilityMethods.HexString2ByteArray(authMaterials2);
				this.Mode = mode;
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Initialize_Failed);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021AC File Offset: 0x000003AC
		public AuthenticationMaterials(global::Motorola.Common.Communication.TLS.SecurityEndpointMode mode, global::Motorola.Common.Communication.CommonUtil.AuthenticationType certType, string authMaterials1, string authMaterials2)
		{
			this.CERTTYPE = certType;
			this.a = global::System.Text.Encoding.ASCII.GetBytes(authMaterials1);
			this.b = global::System.Text.Encoding.ASCII.GetBytes(authMaterials2);
			this.Mode = mode;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021F0 File Offset: 0x000003F0
		public AuthenticationMaterials(global::Motorola.Common.Communication.TLS.SecurityEndpointMode mode, global::Motorola.Common.Communication.CommonUtil.AuthenticationType certType, global::Motorola.Common.Communication.CommonUtil.StreamType strType, string certFile, string publicKey, string pswd)
		{
			this.Mode = mode;
			this.CERTTYPE = certType;
			this.STREAMTYPE = strType;
			this.CERTIFICATE_FILE = certFile;
			this.PUBLIC_KEY = publicKey;
			this.PASSWORD = pswd;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002230 File Offset: 0x00000430
		public byte[] PSK_ID
		{
			get
			{
				short num = (short)1716937299;
				short num2 = num;
				num = (short)1900175955;
				switch (num2 == num)
				{
				}
				num = (short)1450180609;
				if (num != 0)
				{
				}
				num = (short)1226113024;
				short num3 = num;
				num = (short)1883373568;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1627090293;
				short num2 = num;
				num = (short)1518693749;
				switch (num2 == num)
				{
				}
				num = (short)75366401;
				if (num != 0)
				{
				}
				num = (short)1252524032;
				short num3 = num;
				num = (short)850984960;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002440 File Offset: 0x00000640
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002390 File Offset: 0x00000590
		public byte[] PSK_VALUE
		{
			get
			{
				short num = (short)1218616308;
				short num2 = num;
				num = (short)845650932;
				switch (num2 == num)
				{
				}
				num = (short)149618689;
				if (num != 0)
				{
				}
				num = (short)562364416;
				short num3 = num;
				num = (short)431489024;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1284720461;
				short num2 = num;
				num = (short)1781679949;
				switch (num2 == num)
				{
				}
				num = (short)1744502785;
				if (num != 0)
				{
				}
				num = (short)1951137792;
				short num3 = num;
				num = (short)517734400;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000024F0 File Offset: 0x000006F0
		public int KEY_ID_LEN
		{
			get
			{
				short num = (short)1397647456;
				short num2 = num;
				num = (short)1758816352;
				switch (num2 == num)
				{
				}
				num = (short)287309825;
				if (num != 0)
				{
				}
				num = (short)953942016;
				short num3 = num;
				num = (short)1922105344;
				if (num != 0)
				{
				}
				return this.a.Length;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000025A0 File Offset: 0x000007A0
		public int KEY_LEN
		{
			get
			{
				short num = (short)2019595081;
				short num2 = num;
				num = (short)2035454793;
				switch (num2 == num)
				{
				}
				num = (short)1686372352;
				if (num != 0)
				{
				}
				num = (short)816119808;
				short num3 = num;
				num = (short)1283063809;
				if (num != 0)
				{
				}
				return this.b.Length;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002700 File Offset: 0x00000900
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002650 File Offset: 0x00000850
		public byte[] CERT_FILE
		{
			get
			{
				short num = (short)1523477762;
				short num2 = num;
				num = (short)12217602;
				switch (num2 == num)
				{
				}
				num = (short)2014052353;
				if (num != 0)
				{
				}
				num = (short)344195072;
				short num3 = num;
				num = (short)209059840;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1538916353;
				if (num != 0)
				{
				}
				num = (short)424855087;
				short num2 = num;
				num = (short)383239727;
				switch (num2 == num)
				{
				}
				num = (short)2050424832;
				short num3 = num;
				num = (short)635699200;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002860 File Offset: 0x00000A60
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000027B0 File Offset: 0x000009B0
		public byte[] CERT_PSWD
		{
			get
			{
				short num = (short)1999634433;
				if (num != 0)
				{
				}
				num = (short)485432981;
				short num2 = num;
				num = (short)1905925781;
				switch (num2 == num)
				{
				}
				num = (short)2016149504;
				short num3 = num;
				num = (short)375848960;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1302599988;
				short num2 = num;
				num = (short)1124538676;
				switch (num2 == num)
				{
				}
				num = (short)322437120;
				if (num != 0)
				{
				}
				num = (short)2123956224;
				short num3 = num;
				num = (short)1168834561;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002910 File Offset: 0x00000B10
		public int CERT_FILE_LEN
		{
			get
			{
				short num = (short)515833857;
				if (num != 0)
				{
				}
				num = (short)260006162;
				short num2 = num;
				num = (short)870539538;
				switch (num2 == num)
				{
				}
				num = (short)561643520;
				short num3 = num;
				num = (short)1597440000;
				if (num != 0)
				{
				}
				return this.a.Length;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000029C0 File Offset: 0x00000BC0
		public int CERT_PSWD_LEN
		{
			get
			{
				short num = (short)478425447;
				short num2 = num;
				num = (short)273756519;
				switch (num2 == num)
				{
				}
				num = (short)33619969;
				if (num != 0)
				{
				}
				num = (short)1687027712;
				short num3 = num;
				num = (short)1325400064;
				if (num != 0)
				{
				}
				return this.b.Length;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002A74 File Offset: 0x00000C74
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002B24 File Offset: 0x00000D24
		public global::Motorola.Common.Communication.TLS.SecurityEndpointMode Mode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1209425895;
				short num2 = num;
				num = (short)997220327;
				switch (num2 == num)
				{
				}
				num = (short)1850605569;
				if (num != 0)
				{
				}
				num = (short)839778304;
				short num3 = num;
				num = (short)109117440;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1313858563;
				short num2 = num;
				num = (short)334488579;
				switch (num2 == num)
				{
				}
				num = (short)1034092544;
				if (num != 0)
				{
				}
				num = (short)2093678592;
				short num3 = num;
				num = (short)1170014209;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002BD4 File Offset: 0x00000DD4
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002C80 File Offset: 0x00000E80
		public global::Motorola.Common.Communication.CommonUtil.AuthenticationType CERTTYPE
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)527237121;
				if (num != 0)
				{
				}
				num = (short)942819265;
				short num2 = num;
				num = (short)1502103489;
				switch (num2 == num)
				{
				}
				num = (short)650510336;
				short num3 = num;
				num = (short)1731788800;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1178460302;
				short num2 = num;
				num = (short)746119310;
				switch (num2 == num)
				{
				}
				num = (short)1807679489;
				if (num != 0)
				{
				}
				num = (short)1244135424;
				short num3 = num;
				num = (short)1843134464;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002D30 File Offset: 0x00000F30
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public global::Motorola.Common.Communication.CommonUtil.StreamType STREAMTYPE
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)192567568;
				short num2 = num;
				num = (short)1679055120;
				switch (num2 == num)
				{
				}
				num = (short)2079981568;
				if (num != 0)
				{
				}
				num = (short)404488192;
				short num3 = num;
				num = (short)1333067777;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1488289819;
				short num2 = num;
				num = (short)1781432347;
				switch (num2 == num)
				{
				}
				num = (short)1756168192;
				if (num != 0)
				{
				}
				num = (short)701956097;
				if (num != 0)
				{
				}
				num = (short)507314176;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002E90 File Offset: 0x00001090
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002F40 File Offset: 0x00001140
		public string CERTIFICATE_FILE
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)324520401;
				short num2 = num;
				num = (short)479381969;
				switch (num2 == num)
				{
				}
				num = (short)639107073;
				if (num != 0)
				{
				}
				num = (short)496173056;
				if (num != 0)
				{
				}
				num = (short)1600061440;
				short num3 = num;
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1571960442;
				short num2 = num;
				num = (short)578696826;
				switch (num2 == num)
				{
				}
				num = (short)749010944;
				if (num != 0)
				{
				}
				num = (short)13500417;
				if (num != 0)
				{
				}
				num = (short)1614217216;
				short num3 = num;
				this.f = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002FF0 File Offset: 0x000011F0
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000030A0 File Offset: 0x000012A0
		public string PUBLIC_KEY
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)916643296;
				short num2 = num;
				num = (short)1524882912;
				switch (num2 == num)
				{
				}
				num = (short)1048117249;
				if (num != 0)
				{
				}
				num = (short)220200960;
				if (num != 0)
				{
				}
				num = (short)645857280;
				short num3 = num;
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1357347737;
				short num2 = num;
				num = (short)1380088729;
				switch (num2 == num)
				{
				}
				num = (short)615579648;
				if (num != 0)
				{
				}
				num = (short)1841364993;
				if (num != 0)
				{
				}
				num = (short)705822720;
				short num3 = num;
				this.g = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003154 File Offset: 0x00001354
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00003208 File Offset: 0x00001408
		public string PASSWORD
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2136763564;
				short num2 = num;
				num = (short)1724607660;
				switch (num2 == num)
				{
				}
				num = (short)222494720;
				if (num != 0)
				{
				}
				num = (short)59703297;
				if (num != 0)
				{
				}
				num = (short)2036006912;
				short num3 = num;
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)875734776;
				short num2 = num;
				num = (short)1517594360;
				switch (num2 == num)
				{
				}
				num = (short)542507008;
				if (num != 0)
				{
				}
				num = (short)611909633;
				if (num != 0)
				{
				}
				num = (short)205520896;
				short num3 = num;
				this.h = value;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000032B8 File Offset: 0x000014B8
		public static bool IsPskValid(string id, string value)
		{
			int a_ = 16;
			short num;
			if (id.Length > 0)
			{
				num = (short)1221122684;
				short num2 = num;
				num = (short)1812978300;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)416284672;
					if (num != 0)
					{
					}
					return global::System.Text.RegularExpressions.Regex.IsMatch(value, global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("怺഼ሾ础ɂ桄ņ⡈晊⭌቎⩐慒祔摖歘♚", a_));
				}
			}
			num = (short)553123841;
			if (num != 0)
			{
			}
			num = (short)318177280;
			short num3 = num;
			return false;
		}

		// Token: 0x04000003 RID: 3
		private byte[] a;

		// Token: 0x04000004 RID: 4
		private byte[] b;

		// Token: 0x04000005 RID: 5
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.TLS.SecurityEndpointMode c;

		// Token: 0x04000006 RID: 6
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.AuthenticationType d;

		// Token: 0x04000007 RID: 7
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.StreamType e;

		// Token: 0x04000008 RID: 8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;

		// Token: 0x04000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string g;

		// Token: 0x0400000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string h;
	}
}
