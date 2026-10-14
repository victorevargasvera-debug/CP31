using System;

namespace Motorola.Common.Cryptography.Configuration
{
	// Token: 0x02000019 RID: 25
	public interface ICertificateConfiguration
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000037 RID: 55
		// (set) Token: 0x06000038 RID: 56
		global::Motorola.Common.Cryptography.CertificateType SelectedCertificateType { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000039 RID: 57
		// (set) Token: 0x0600003A RID: 58
		bool WereSha1CertificatesRemoved { get; set; }

		// Token: 0x0600003B RID: 59
		void RemoveCertificates();
	}
}
