using System;

namespace NPOI.POIFS.Crypt.Dsig.Services
{
	// Token: 0x02000109 RID: 265
	public interface ITimeStampService : global::NPOI.POIFS.Crypt.Dsig.ISignatureConfigurable
	{
		// Token: 0x06000F77 RID: 3959
		byte[] TimeStamp(byte[] data, global::NPOI.POIFS.Crypt.Dsig.Services.RevocationData revocationData);
	}
}
