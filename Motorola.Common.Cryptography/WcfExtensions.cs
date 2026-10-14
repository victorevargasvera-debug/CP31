using System;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Discovery;
using Motorola.Common.Cryptography.Autofac;

namespace Motorola.Common.Cryptography
{
	// Token: 0x02000006 RID: 6
	public static class WcfExtensions
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002CFC File Offset: 0x00000EFC
		public static void SetCertificate(this global::System.ServiceModel.Discovery.DiscoveryClient discoveryClient)
		{
			short num = (short)811464381;
			short num2 = num;
			num = (short)840234685;
			switch (num2 == num)
			{
			}
			num = (short)617938945;
			if (num != 0)
			{
			}
			num = (short)370278400;
			short num3 = num;
			num = (short)986775552;
			if (num != 0)
			{
			}
			discoveryClient.ChannelFactory.SetCertificate();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002DB0 File Offset: 0x00000FB0
		public static void SetCertificate(this global::System.ServiceModel.ChannelFactory channelFactory)
		{
			int a_ = 13;
			short num = (short)1728734354;
			short num2 = num;
			num = (short)418735250;
			switch (num2 == num)
			{
			}
			num = (short)1953693696;
			if (num != 0)
			{
			}
			num = (short)1745616896;
			short num3 = num;
			num = (short)638910465;
			if (num != 0)
			{
			}
			channelFactory.Credentials.ClientCertificate.Certificate = global::Motorola.Common.Cryptography.CryptographyFacade.GetProvider(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("b।๦౨ժᥬ", a_)).SelectedCertificate;
			channelFactory.Credentials.ServiceCertificate.Authentication.RevocationMode = global::System.Security.Cryptography.X509Certificates.X509RevocationMode.NoCheck;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002EA0 File Offset: 0x000010A0
		public static void SetCertificate(this global::System.ServiceModel.Discovery.AnnouncementClient client)
		{
			int a_ = 17;
			short num = (short)223679873;
			short num2 = num;
			num = (short)1429804417;
			switch (num2 == num)
			{
			}
			num = (short)88932353;
			if (num != 0)
			{
			}
			num = (short)92471296;
			short num3 = num;
			num = (short)750387200;
			if (num != 0)
			{
			}
			client.ClientCredentials.ClientCertificate.Certificate = global::Motorola.Common.Cryptography.CryptographyFacade.GetProvider(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("Ѧըɪ࡬Ůհ", a_)).SelectedCertificate;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002F78 File Offset: 0x00001178
		public static void SetCertificates(this global::System.ServiceModel.ServiceHost host, bool includeKnownHosts = false)
		{
			int a_ = 2;
			short num = (short)1332936705;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num2;
			for (;;)
			{
				IL_3A:
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (includeKnownHosts)
					{
						num = (short)614137858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					num = (short)614696395;
					short num3 = num;
					num = (short)970884555;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4C;
					case 1:
						break;
					default:
					{
						num = (short)1073086464;
						short num4 = num;
						break;
					}
					}
					num = (short)512229376;
					if (num != 0)
					{
					}
					global::System.Security.Cryptography.X509Certificates.X509Certificate2 selectedCertificate = global::Motorola.Common.Cryptography.CryptographyFacade.GetProvider(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("㍗㑙㍛⥝๟Ⅱţᑥᱧͩ੫ݭ፯፱s፵୷", a_)).SelectedCertificate;
					host.Credentials.IssuedTokenAuthentication.KnownCertificates.Add(selectedCertificate);
					num = (short)300023808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_4C;
			}
			return;
			IL_4C:
			host.Credentials.ServiceCertificate.Certificate = global::Motorola.Common.Cryptography.CryptographyFacade.GetProvider(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("⭗㽙⹛⡝՟ၡ", a_)).SelectedCertificate;
			num = (short)1811283969;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_3A;
		}
	}
}
