using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x02000026 RID: 38
	[global::System.Runtime.Serialization.DataContract]
	internal class PerformanceLogElasticSearch
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00012F10 File Offset: 0x00011110
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00012FC0 File Offset: 0x000111C0
		[global::System.Runtime.Serialization.DataMember]
		public string OperationType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1665937889;
				short num2 = num;
				num = (short)1920020961;
				switch (num2 == num)
				{
				}
				num = (short)428081152;
				if (num != 0)
				{
				}
				num = (short)1168572417;
				if (num != 0)
				{
				}
				num = (short)1533018112;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)388669197;
				short num2 = num;
				num = (short)1256496909;
				switch (num2 == num)
				{
				}
				num = (short)826605568;
				if (num != 0)
				{
				}
				num = (short)1552351233;
				if (num != 0)
				{
				}
				num = (short)1372651520;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00013070 File Offset: 0x00011270
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0001311C File Offset: 0x0001131C
		[global::System.Runtime.Serialization.DataMember]
		public string OperationDetail
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)605556473;
				short num2 = num;
				num = (short)1853099769;
				switch (num2 == num)
				{
				}
				num = (short)58720257;
				if (num != 0)
				{
				}
				num = (short)432603136;
				if (num != 0)
				{
				}
				num = (short)1658847232;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)515787138;
				short num2 = num;
				num = (short)2068466050;
				switch (num2 == num)
				{
				}
				num = (short)82444288;
				if (num != 0)
				{
				}
				num = (short)1005387777;
				if (num != 0)
				{
				}
				num = (short)1773600768;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000131D0 File Offset: 0x000113D0
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0001327C File Offset: 0x0001147C
		[global::System.Runtime.Serialization.DataMember]
		public string Duration
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2089142089;
				short num2 = num;
				num = (short)387696457;
				switch (num2 == num)
				{
				}
				num = (short)1723138049;
				if (num != 0)
				{
				}
				num = (short)1639710720;
				if (num != 0)
				{
				}
				num = (short)2037907456;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1886126081;
				if (num != 0)
				{
				}
				num = (short)1189613728;
				short num2 = num;
				num = (short)1989611680;
				switch (num2 == num)
				{
				}
				num = (short)1265696768;
				if (num != 0)
				{
				}
				num = (short)1710161920;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0001332C File Offset: 0x0001152C
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000133DC File Offset: 0x000115DC
		[global::System.Runtime.Serialization.DataMember]
		public int ProcessID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1804032408;
				short num2 = num;
				num = (short)405232024;
				switch (num2 == num)
				{
				}
				num = (short)891551745;
				if (num != 0)
				{
				}
				num = (short)1483669504;
				if (num != 0)
				{
				}
				num = (short)1581252608;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1101780042;
				short num2 = num;
				num = (short)259904586;
				switch (num2 == num)
				{
				}
				num = (short)974979072;
				if (num != 0)
				{
				}
				num = (short)1787559937;
				if (num != 0)
				{
				}
				num = (short)2019098624;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0001348C File Offset: 0x0001168C
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0001353C File Offset: 0x0001173C
		[global::System.Runtime.Serialization.DataMember]
		public string OSVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)427369701;
				short num2 = num;
				num = (short)1063920869;
				switch (num2 == num)
				{
				}
				num = (short)1658519553;
				if (num != 0)
				{
				}
				num = (short)1751842816;
				if (num != 0)
				{
				}
				num = (short)957022208;
				short num3 = num;
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)679021007;
				short num2 = num;
				num = (short)341051855;
				switch (num2 == num)
				{
				}
				num = (short)1440677888;
				if (num != 0)
				{
				}
				num = (short)1280704513;
				if (num != 0)
				{
				}
				num = (short)101318656;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000135EC File Offset: 0x000117EC
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0001369C File Offset: 0x0001189C
		[global::System.Runtime.Serialization.DataMember]
		public string LocalTimeZone
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)760676352;
				short num2 = num;
				num = (short)225161397;
				short num3 = num;
				num = (short)544256181;
				switch (num3 == num)
				{
				}
				num = (short)206307329;
				if (num != 0)
				{
				}
				num = (short)694353920;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1706164224;
				short num2 = num;
				num = (short)1532624897;
				if (num != 0)
				{
				}
				num = (short)368753603;
				short num3 = num;
				num = (short)1944566723;
				switch (num3 == num)
				{
				}
				num = (short)406978560;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0001374C File Offset: 0x0001194C
		// (set) Token: 0x0600013B RID: 315 RVA: 0x000137FC File Offset: 0x000119FC
		[global::System.Runtime.Serialization.DataMember]
		public string Language
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1787559936;
				short num2 = num;
				num = (short)1039372379;
				short num3 = num;
				num = (short)1258262619;
				switch (num3 == num)
				{
				}
				num = (short)42532865;
				if (num != 0)
				{
				}
				num = (short)1245970432;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)12793331;
				short num2 = num;
				num = (short)1632908787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)245301248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2078408705;
				if (num != 0)
				{
				}
				num = (short)1787887616;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000138AC File Offset: 0x00011AAC
		// (set) Token: 0x0600013D RID: 317 RVA: 0x0001395C File Offset: 0x00011B5C
		[global::System.Runtime.Serialization.DataMember]
		public int ProcessorCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)919909336;
				short num2 = num;
				num = (short)1624355800;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1696792576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)444792833;
				if (num != 0)
				{
				}
				num = (short)1658978304;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)748748429;
				short num2 = num;
				num = (short)351796877;
				switch (num2 == num)
				{
				default:
				{
					num = (short)852951040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)831651840;
				if (num != 0)
				{
				}
				num = (short)70320129;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00013A0C File Offset: 0x00011C0C
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00013ABC File Offset: 0x00011CBC
		[global::System.Runtime.Serialization.DataMember]
		public string ComputerName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2132643575;
				short num2 = num;
				num = (short)145067767;
				switch (num2 == num)
				{
				default:
				{
					num = (short)523632640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1716781057;
				if (num != 0)
				{
				}
				num = (short)1427767296;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)145114099;
				short num2 = num;
				num = (short)803488755;
				switch (num2 == num)
				{
				default:
				{
					num = (short)556204032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1560018945;
				if (num != 0)
				{
				}
				num = (short)1746010112;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00013B6C File Offset: 0x00011D6C
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00013C20 File Offset: 0x00011E20
		[global::System.Runtime.Serialization.DataMember]
		public string CountryCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1096559522;
				short num2 = num;
				num = (short)1344088994;
				switch (num2 == num)
				{
				default:
				{
					num = (short)184090624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)888471553;
				if (num != 0)
				{
				}
				num = (short)1891827712;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1987344086;
				short num2 = num;
				num = (short)796882646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)320012288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)642187265;
				if (num != 0)
				{
				}
				num = (short)2079719424;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00013CD0 File Offset: 0x00011ED0
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00013D84 File Offset: 0x00011F84
		[global::System.Runtime.Serialization.DataMember]
		public string CPSVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1362258061;
				short num2 = num;
				num = (short)208496781;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1121714176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1360265217;
				if (num != 0)
				{
				}
				num = (short)1824653312;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)613958146;
				short num2 = num;
				num = (short)116146690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1338834944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)149225472;
				if (num != 0)
				{
				}
				num = (short)1040842753;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00013E34 File Offset: 0x00012034
		public global::System.Collections.Generic.IDictionary<string, string> Parameters
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)60179307;
				short num2 = num;
				num = (short)555959147;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1088946176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1430781953;
				if (num != 0)
				{
				}
				num = (short)605683712;
				if (num != 0)
				{
				}
				return this.l;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00013EE0 File Offset: 0x000120E0
		public global::System.Collections.Generic.IDictionary<string, string> SystemStateDetails
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)79602684;
				short num2 = num;
				num = (short)1006740476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)685309952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)343801856;
				if (num != 0)
				{
				}
				num = (short)280231937;
				if (num != 0)
				{
				}
				return this.m;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00013F90 File Offset: 0x00012190
		public global::System.Collections.Generic.IDictionary<string, string> OverallPerformanceDetails
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1048379393;
				if (num != 0)
				{
				}
				num = (short)1344995328;
				short num2 = num;
				num = (short)1938267571;
				short num3 = num;
				num = (short)1451924915;
				switch (num3 == num)
				{
				}
				num = (short)564723712;
				if (num != 0)
				{
				}
				return this.n;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00014040 File Offset: 0x00012240
		public PerformanceLogElasticSearch(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer result)
		{
			int a_ = 15;
			base..ctor();
			this.OperationType = result.OperationInfo.OperationType;
			this.OperationDetail = result.OperationInfo.StampName;
			this.Duration = result.Watch.Duration;
			this.m = result.Watch.SystemState;
			this.n = result.Watch.OverallState;
			this.l = result.OperationInfo.Parameters.ParaList;
			this.ProcessID = global::System.Diagnostics.Process.GetCurrentProcess().Id;
			this.LocalTimeZone = global::System.TimeZone.CurrentTimeZone.StandardName;
			this.ProcessorCount = global::System.Environment.ProcessorCount;
			this.ComputerName = global::System.Environment.MachineName;
			global::System.Globalization.CultureInfo installedUICulture = global::System.Globalization.CultureInfo.InstalledUICulture;
			this.Language = installedUICulture.DisplayName;
			this.CountryCode = new global::System.Globalization.RegionInfo(installedUICulture.Name).TwoLetterISORegionName;
			global::System.Diagnostics.FileVersionInfo versionInfo = global::System.Diagnostics.FileVersionInfo.GetVersionInfo(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
			this.CPSVersion = versionInfo.FileVersion;
			object obj = new global::System.Management.ManagementObjectSearcher(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ぢ⁤⭦ⱨ⡪㥬佮㉰ቲմͶၸᑺ፼彾잀톂쪄쪆ꦈ\udc8aꊐꆒ쪔\ud896ﺚﺞ햠쪢쮤삦直튪\udeac\udbae풰\udeb2", a_)).Get().Cast<global::System.Management.ManagementObject>().Select(delegate(global::System.Management.ManagementObject x)
			{
				int a_2 = 0;
				short num = (short)1479075140;
				short num2 = num;
				num = (short)1805706564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1096810496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1811742721;
				if (num != 0)
				{
				}
				num = (short)753598464;
				if (num != 0)
				{
				}
				return x.GetPropertyValue(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᝓ㝕⡗⹙㕛ㅝ๟", a_2));
			}).FirstOrDefault<object>();
			this.OSVersion = ((obj != null) ? obj.ToString() : null);
		}

		// Token: 0x040000AE RID: 174
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x040000AF RID: 175
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x040000B0 RID: 176
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x040000B1 RID: 177
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int d;

		// Token: 0x040000B2 RID: 178
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;

		// Token: 0x040000B3 RID: 179
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;

		// Token: 0x040000B4 RID: 180
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string g;

		// Token: 0x040000B5 RID: 181
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int h;

		// Token: 0x040000B6 RID: 182
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string i;

		// Token: 0x040000B7 RID: 183
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string j;

		// Token: 0x040000B8 RID: 184
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string k;

		// Token: 0x040000B9 RID: 185
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.Collections.Generic.IDictionary<string, string> l;

		// Token: 0x040000BA RID: 186
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.Collections.Generic.IDictionary<string, string> m;

		// Token: 0x040000BB RID: 187
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.Collections.Generic.IDictionary<string, string> n;
	}
}
