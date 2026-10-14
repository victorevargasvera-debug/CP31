using System;
using MSI;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x02000015 RID: 21
	public class ProxyInfo
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x0000A148 File Offset: 0x00008348
		public static implicit operator global::MSI.ProxyInfo(global::CommonLicenseInterfaceWrapper.ProxyInfo parameter)
		{
			short num = (short)219786801;
			short num2 = num;
			num = (short)1759227441;
			switch (num2 == num)
			{
			}
			num = (short)543162369;
			if (num != 0)
			{
			}
			num = (short)1566048256;
			short num3 = num;
			num = (short)1104281600;
			if (num != 0)
			{
			}
			return parameter.a;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000A1F8 File Offset: 0x000083F8
		public static implicit operator global::CommonLicenseInterfaceWrapper.ProxyInfo(global::MSI.ProxyInfo parameter)
		{
			short num = (short)1980039169;
			if (num != 0)
			{
			}
			num = (short)1757619337;
			short num2 = num;
			num = (short)1433150601;
			switch (num2 == num)
			{
			}
			num = (short)1777270784;
			short num3 = num;
			num = (short)833093632;
			if (num != 0)
			{
			}
			return new global::CommonLicenseInterfaceWrapper.ProxyInfo
			{
				a = parameter
			};
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000A2AC File Offset: 0x000084AC
		static ProxyInfo()
		{
			short num = (short)1570609604;
			short num2 = num;
			num = (short)1798609348;
			switch (num2 == num)
			{
			}
			num = (short)2065432576;
			if (num != 0)
			{
			}
			num = (short)1220149248;
			short num3 = num;
			num = (short)1733361665;
			if (num != 0)
			{
			}
			global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b();
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000A35C File Offset: 0x0000855C
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000A410 File Offset: 0x00008610
		public bool proxyRequired
		{
			get
			{
				short num = (short)302343905;
				short num2 = num;
				num = (short)193029857;
				switch (num2 == num)
				{
				}
				num = (short)29097985;
				if (num != 0)
				{
				}
				num = (short)1467023360;
				short num3 = num;
				num = (short)906821632;
				if (num != 0)
				{
				}
				return this.a.proxyRequired;
			}
			set
			{
				short num = (short)992285252;
				short num2 = num;
				num = (short)1980699204;
				switch (num2 == num)
				{
				}
				num = (short)977272833;
				if (num != 0)
				{
				}
				num = (short)131596288;
				short num3 = num;
				num = (short)1474560000;
				if (num != 0)
				{
				}
				this.a.proxyRequired = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000A4C8 File Offset: 0x000086C8
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000A57C File Offset: 0x0000877C
		public string proxyServerURL
		{
			get
			{
				short num = (short)656411067;
				short num2 = num;
				num = (short)1249708475;
				switch (num2 == num)
				{
				}
				num = (short)1034682369;
				if (num != 0)
				{
				}
				num = (short)696647680;
				short num3 = num;
				num = (short)1448083456;
				if (num != 0)
				{
				}
				return this.a.proxyServerURL;
			}
			set
			{
				short num = (short)1899856482;
				short num2 = num;
				num = (short)74416738;
				switch (num2 == num)
				{
				}
				num = (short)756744193;
				if (num != 0)
				{
				}
				num = (short)1077477376;
				short num3 = num;
				num = (short)1899298816;
				if (num != 0)
				{
				}
				this.a.proxyServerURL = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000A630 File Offset: 0x00008830
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000A6E4 File Offset: 0x000088E4
		public string proxyPort
		{
			get
			{
				short num = (short)866099359;
				short num2 = num;
				num = (short)810131615;
				switch (num2 == num)
				{
				}
				num = (short)1073676289;
				if (num != 0)
				{
				}
				num = (short)531890176;
				short num3 = num;
				num = (short)870842368;
				if (num != 0)
				{
				}
				return this.a.proxyPort;
			}
			set
			{
				short num = (short)1986265089;
				if (num != 0)
				{
				}
				num = (short)319996340;
				short num2 = num;
				num = (short)1192149428;
				switch (num2 == num)
				{
				}
				num = (short)1842085888;
				short num3 = num;
				num = (short)1135149056;
				if (num != 0)
				{
				}
				this.a.proxyPort = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000A79C File Offset: 0x0000899C
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000A850 File Offset: 0x00008A50
		public bool authRequired
		{
			get
			{
				short num = (short)69827493;
				short num2 = num;
				num = (short)1197177765;
				switch (num2 == num)
				{
				}
				num = (short)706805761;
				if (num != 0)
				{
				}
				num = (short)302055424;
				short num3 = num;
				num = (short)1677197312;
				if (num != 0)
				{
				}
				return this.a.authRequired;
			}
			set
			{
				short num = (short)903362260;
				short num2 = num;
				num = (short)2051880660;
				switch (num2 == num)
				{
				}
				num = (short)1844903937;
				if (num != 0)
				{
				}
				num = (short)114098176;
				short num3 = num;
				num = (short)1058537472;
				if (num != 0)
				{
				}
				this.a.authRequired = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000A908 File Offset: 0x00008B08
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000A9BC File Offset: 0x00008BBC
		public string password
		{
			get
			{
				short num = (short)1794317411;
				short num2 = num;
				num = (short)1386486883;
				switch (num2 == num)
				{
				}
				num = (short)511377408;
				if (num != 0)
				{
				}
				num = (short)661258240;
				short num3 = num;
				num = (short)32112641;
				if (num != 0)
				{
				}
				return this.a.password;
			}
			set
			{
				short num = (short)700576353;
				short num2 = num;
				num = (short)655749729;
				switch (num2 == num)
				{
				}
				num = (short)1562050560;
				if (num != 0)
				{
				}
				num = (short)200540160;
				short num3 = num;
				num = (short)705888257;
				if (num != 0)
				{
				}
				this.a.password = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000AA74 File Offset: 0x00008C74
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000AB28 File Offset: 0x00008D28
		public string userName
		{
			get
			{
				short num = (short)460329627;
				short num2 = num;
				num = (short)819597979;
				switch (num2 == num)
				{
				}
				num = (short)781320193;
				if (num != 0)
				{
				}
				num = (short)1263927296;
				short num3 = num;
				num = (short)950009856;
				if (num != 0)
				{
				}
				return this.a.userName;
			}
			set
			{
				short num = (short)1833101636;
				short num2 = num;
				num = (short)815065412;
				switch (num2 == num)
				{
				}
				num = (short)309854209;
				if (num != 0)
				{
				}
				num = (short)783351808;
				short num3 = num;
				num = (short)878641152;
				if (num != 0)
				{
				}
				this.a.userName = value;
			}
		}

		// Token: 0x04000024 RID: 36
		private global::MSI.ProxyInfo a = new global::MSI.ProxyInfo();
	}
}
