using System;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using Motorola.Common.Cryptography.Exceptions;

namespace Motorola.Common.Cryptography.Providers
{
	// Token: 0x0200000F RID: 15
	public class IdentityProvider : global::Motorola.Common.Cryptography.Providers.IIdentityProvider
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00003CC8 File Offset: 0x00001EC8
		public IdentityProvider(global::Motorola.Common.Cryptography.Providers.ICertificateProvider certificateProvider)
		{
			this.a = certificateProvider;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003CE4 File Offset: 0x00001EE4
		public global::System.ServiceModel.EndpointIdentity Get()
		{
			short num = (short)1990466369;
			short num2 = num;
			num = (short)359013185;
			switch (num2 == num)
			{
			}
			num = (short)1154285568;
			short num3 = num;
			num = (short)1100808193;
			if (num != 0)
			{
			}
			num = (short)440074240;
			if (num != 0)
			{
			}
			return global::System.ServiceModel.EndpointIdentity.CreateDnsIdentity(this.a());
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003D98 File Offset: 0x00001F98
		private string a()
		{
			short num = (short)2132606977;
			if (num != 0)
			{
			}
			num = (short)1616054385;
			short num2 = num;
			num = (short)741542001;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1848573952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1424097280;
			if (num != 0)
			{
			}
			global::System.Security.Cryptography.X509Certificates.X509Certificate2 selectedCertificate = this.a.SelectedCertificate;
			if (selectedCertificate == null)
			{
				throw new global::Motorola.Common.Cryptography.Exceptions.IdentityNotFoundException();
			}
			return selectedCertificate.GetNameInfo(global::System.Security.Cryptography.X509Certificates.X509NameType.DnsName, false);
		}

		// Token: 0x04000010 RID: 16
		private readonly global::Motorola.Common.Cryptography.Providers.ICertificateProvider a;
	}
}
