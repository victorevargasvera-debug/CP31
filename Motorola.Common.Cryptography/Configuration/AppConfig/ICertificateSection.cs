using System;
using System.Collections.Generic;

namespace Motorola.Common.Cryptography.Configuration.AppConfig
{
	// Token: 0x02000024 RID: 36
	public interface ICertificateSection
	{
		// Token: 0x06000061 RID: 97
		global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement> GetCertificates(string group);
	}
}
