using System;

namespace Motorola.Common.Cryptography.Configuration.Registry
{
	// Token: 0x02000029 RID: 41
	public static class RegistryConfigExtensions
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00006370 File Offset: 0x00004570
		public static global::Motorola.Common.Cryptography.CertificateType SelectedCertificateTypeOrDefault(this global::Motorola.Common.Cryptography.Configuration.Registry.IRegistryConfig registry)
		{
			global::Motorola.Common.Cryptography.CertificateType? selectedCertificateType = registry.SelectedCertificateType;
			if (selectedCertificateType != null)
			{
				short num = (short)763419575;
				short num2 = num;
				num = (short)404741047;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return global::Motorola.Common.Cryptography.CertificateType.Sha256Rsa;
				case 1:
					break;
				default:
				{
					num = (short)405995520;
					short num3 = num;
					break;
				}
				}
				num = (short)1267007489;
				if (num != 0)
				{
				}
				num = (short)606404608;
				if (num != 0)
				{
				}
				return selectedCertificateType.GetValueOrDefault();
			}
			return global::Motorola.Common.Cryptography.CertificateType.Sha256Rsa;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00006434 File Offset: 0x00004634
		public static bool WereSha1CertificatesRemovedOrDefault(this global::Motorola.Common.Cryptography.Configuration.Registry.IRegistryConfig reg)
		{
			short num = (short)936430484;
			short num2 = num;
			num = (short)414698388;
			switch (num2 == num)
			{
			}
			num = (short)1522991104;
			short num3 = num;
			num = (short)2107244544;
			if (num != 0)
			{
			}
			num = (short)222887937;
			if (num != 0)
			{
			}
			return reg.WereSha1CertificatesRemoved.GetValueOrDefault();
		}

		// Token: 0x04000024 RID: 36
		private const global::Motorola.Common.Cryptography.CertificateType a = global::Motorola.Common.Cryptography.CertificateType.Sha256Rsa;

		// Token: 0x04000025 RID: 37
		private const bool b = false;
	}
}
