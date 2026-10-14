using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using Motorola.Common.Cryptography.Autofac;

namespace Motorola.Common.Cryptography.Configuration.AppConfig
{
	// Token: 0x0200001E RID: 30
	public class CertificateElement : global::System.Configuration.ConfigurationElement
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00004D4C File Offset: 0x00002F4C
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00004E14 File Offset: 0x00003014
		[global::System.Configuration.ConfigurationProperty("StoreLocation", IsRequired = true)]
		public global::System.Security.Cryptography.X509Certificates.StoreLocation StoreLocation
		{
			get
			{
				int a_ = 1;
				short num = (short)660320225;
				short num2 = num;
				num = (short)709079009;
				switch (num2 == num)
				{
				}
				num = (short)284098560;
				short num3 = num;
				num = (short)1353056257;
				if (num != 0)
				{
				}
				num = (short)1933901824;
				if (num != 0)
				{
				}
				return (global::System.Security.Cryptography.X509Certificates.StoreLocation)base[global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("іⵘ㑚⽜㩞ⵠౢ٤٦ᵨɪɬŮ", a_)];
			}
			set
			{
				int a_ = 14;
				short num = (short)1704051590;
				short num2 = num;
				num = (short)2051457926;
				switch (num2 == num)
				{
				}
				num = (short)1626603520;
				short num3 = num;
				num = (short)1028718593;
				if (num != 0)
				{
				}
				num = (short)610664448;
				if (num != 0)
				{
				}
				base[global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("㝣ብݧᡩ५≭Ὧᅱᕳɵᅷᕹቻ", a_)] = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00004EE0 File Offset: 0x000030E0
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00004FAC File Offset: 0x000031AC
		[global::System.Configuration.ConfigurationProperty("StoreName", IsRequired = true)]
		public global::System.Security.Cryptography.X509Certificates.StoreName StoreName
		{
			get
			{
				int a_ = 18;
				short num = (short)1480390798;
				short num2 = num;
				num = (short)1604778126;
				switch (num2 == num)
				{
				}
				num = (short)308084736;
				short num3 = num;
				num = (short)1453785089;
				if (num != 0)
				{
				}
				num = (short)1518927872;
				if (num != 0)
				{
				}
				return (global::System.Security.Cryptography.X509Certificates.StoreName)base[global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("㭧ṩͫᱭᕯ㱱ᕳ᭵ᵷ", a_)];
			}
			set
			{
				int a_ = 5;
				short num = (short)1766129665;
				if (num != 0)
				{
				}
				num = (short)1020336687;
				short num2 = num;
				num = (short)382081583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)410189824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1188560896;
				if (num != 0)
				{
				}
				base[global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("࡚⥜ぞ፠٢⭤٦Ѩ๪", a_)] = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00005078 File Offset: 0x00003278
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00005144 File Offset: 0x00003344
		[global::System.Configuration.ConfigurationProperty("X509FindType", IsRequired = true)]
		public global::System.Security.Cryptography.X509Certificates.X509FindType X509FindType
		{
			get
			{
				int a_ = 9;
				short num = (short)1539934522;
				short num2 = num;
				num = (short)1858636090;
				switch (num2 == num)
				{
				}
				num = (short)454361088;
				short num3 = num;
				num = (short)858783745;
				if (num != 0)
				{
				}
				num = (short)1300037632;
				if (num != 0)
				{
				}
				return (global::System.Security.Cryptography.X509Certificates.X509FindType)base[global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("ݞ呠卢層Ⅶhժ६㭮ࡰͲၴ", a_)];
			}
			set
			{
				int a_ = 3;
				short num = (short)267628630;
				short num2 = num;
				num = (short)934457430;
				switch (num2 == num)
				{
				}
				num = (short)530644992;
				short num3 = num;
				num = (short)1716715521;
				if (num != 0)
				{
				}
				num = (short)148439040;
				if (num != 0)
				{
				}
				base[global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("Ř湚浜晞❠੢୤ͦ㵨ቪᵬ੮", a_)] = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00005214 File Offset: 0x00003414
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000052E0 File Offset: 0x000034E0
		[global::System.Configuration.ConfigurationProperty("Value", IsRequired = true)]
		public string Value
		{
			get
			{
				int a_ = 1;
				short num = (short)309283252;
				short num2 = num;
				num = (short)1846626740;
				switch (num2 == num)
				{
				}
				num = (short)317587456;
				short num3 = num;
				num = (short)95617024;
				if (num != 0)
				{
				}
				num = (short)402718721;
				if (num != 0)
				{
				}
				return (string)base[global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("Ŗ㡘㝚⡜㩞", a_)];
			}
			set
			{
				int a_ = 5;
				short num = (short)1262499499;
				short num2 = num;
				num = (short)173815467;
				switch (num2 == num)
				{
				}
				num = (short)101646336;
				short num3 = num;
				num = (short)1273036800;
				if (num != 0)
				{
				}
				num = (short)54525953;
				if (num != 0)
				{
				}
				base[global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("൚㱜㍞ᑠ٢", a_)] = value;
			}
		}
	}
}
