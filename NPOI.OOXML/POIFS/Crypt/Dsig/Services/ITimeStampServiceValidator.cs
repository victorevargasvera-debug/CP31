using System;
using System.Collections.Generic;
using Org.BouncyCastle.X509;

namespace NPOI.POIFS.Crypt.Dsig.Services
{
	// Token: 0x0200010A RID: 266
	public interface ITimeStampServiceValidator
	{
		// Token: 0x06000F78 RID: 3960
		void Validate(global::System.Collections.Generic.List<global::Org.BouncyCastle.X509.X509Certificate> certificateChain, global::NPOI.POIFS.Crypt.Dsig.Services.RevocationData revocationData);
	}
}
