using System;

namespace Motorola.Common.Cryptography.Configuration.Registry
{
	// Token: 0x0200002A RID: 42
	public interface IRegistryConfig
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000070 RID: 112
		// (set) Token: 0x06000071 RID: 113
		global::Motorola.Common.Cryptography.CertificateType? SelectedCertificateType { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000072 RID: 114
		// (set) Token: 0x06000073 RID: 115
		bool? WereSha1CertificatesRemoved { get; set; }
	}
}
