using System;
using MSI;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x0200000B RID: 11
	public class DeviceInfo
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00005420 File Offset: 0x00003620
		public static implicit operator global::MSI.DeviceInfo(global::CommonLicenseInterfaceWrapper.DeviceInfo parameter)
		{
			short num = (short)435245602;
			short num2 = num;
			num = (short)298603042;
			switch (num2 == num)
			{
			}
			num = (short)373358593;
			if (num != 0)
			{
			}
			num = (short)1939079168;
			if (num != 0)
			{
			}
			num = (short)956956672;
			short num3 = num;
			return parameter.a;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000054D0 File Offset: 0x000036D0
		public static implicit operator global::CommonLicenseInterfaceWrapper.DeviceInfo(global::MSI.DeviceInfo parameter)
		{
			short num = (short)618528768;
			short num2 = num;
			num = (short)2143682561;
			if (num != 0)
			{
			}
			num = (short)1917359068;
			short num3 = num;
			num = (short)1495569372;
			switch (num3 == num)
			{
			}
			num = (short)1795948544;
			if (num != 0)
			{
			}
			return new global::CommonLicenseInterfaceWrapper.DeviceInfo
			{
				a = parameter
			};
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00005584 File Offset: 0x00003784
		static DeviceInfo()
		{
			short num = (short)1051328512;
			short num2 = num;
			num = (short)884732900;
			short num3 = num;
			num = (short)1788670948;
			switch (num3 == num)
			{
			}
			num = (short)991952896;
			if (num != 0)
			{
			}
			num = (short)1624506369;
			if (num != 0)
			{
			}
			global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b();
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00005638 File Offset: 0x00003838
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000056EC File Offset: 0x000038EC
		public string deviceId
		{
			get
			{
				short num = (short)55902208;
				short num2 = num;
				num = (short)1059201354;
				short num3 = num;
				num = (short)1421091146;
				switch (num3 == num)
				{
				}
				num = (short)1572601856;
				if (num != 0)
				{
				}
				num = (short)790691841;
				if (num != 0)
				{
				}
				return this.a.deviceId;
			}
			set
			{
				short num = (short)1632567296;
				short num2 = num;
				num = (short)1834287298;
				short num3 = num;
				num = (short)1449853122;
				switch (num3 == num)
				{
				}
				num = (short)1225916417;
				if (num != 0)
				{
				}
				num = (short)719454208;
				if (num != 0)
				{
				}
				this.a.deviceId = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000057A0 File Offset: 0x000039A0
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00005858 File Offset: 0x00003A58
		public string deviceAlias
		{
			get
			{
				short num = (short)761724928;
				short num2 = num;
				num = (short)504392473;
				short num3 = num;
				num = (short)1516137241;
				switch (num3 == num)
				{
				}
				num = (short)584384513;
				if (num != 0)
				{
				}
				num = (short)1283784704;
				if (num != 0)
				{
				}
				return this.a.deviceAlias;
			}
			set
			{
				short num = (short)629014528;
				short num2 = num;
				num = (short)1964878363;
				short num3 = num;
				num = (short)556771867;
				switch (num3 == num)
				{
				}
				num = (short)331612160;
				if (num != 0)
				{
				}
				num = (short)1396834305;
				if (num != 0)
				{
				}
				this.a.deviceAlias = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00005910 File Offset: 0x00003B10
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000059C4 File Offset: 0x00003BC4
		public string deviceType
		{
			get
			{
				short num = (short)1631059968;
				short num2 = num;
				num = (short)1673986049;
				if (num != 0)
				{
				}
				num = (short)633751660;
				short num3 = num;
				num = (short)857229420;
				switch (num3 == num)
				{
				}
				num = (short)2018115584;
				if (num != 0)
				{
				}
				return this.a.deviceType;
			}
			set
			{
				short num = (short)1239220224;
				short num2 = num;
				num = (short)732037121;
				if (num != 0)
				{
				}
				num = (short)833805938;
				short num3 = num;
				num = (short)1570627186;
				switch (num3 == num)
				{
				}
				num = (short)1863909376;
				if (num != 0)
				{
				}
				this.a.deviceType = value;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005A78 File Offset: 0x00003C78
		public DeviceInfo()
		{
			this.a = new global::MSI.DeviceInfo();
		}

		// Token: 0x0400001A RID: 26
		private global::MSI.DeviceInfo a = new global::MSI.DeviceInfo();
	}
}
