using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace NPOI.POIFS.Crypt.Dsig.Services
{
	// Token: 0x02000107 RID: 263
	public interface IRevocationDataService
	{
		// Token: 0x06000F72 RID: 3954
		global::NPOI.POIFS.Crypt.Dsig.Services.RevocationData GetRevocationData(global::System.Collections.Generic.List<global::System.Security.Cryptography.X509Certificates.X509Certificate> certificateChain);
	}
}
