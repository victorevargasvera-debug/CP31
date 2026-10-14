using System;

namespace NPOI.POIFS.Crypt.Dsig.Services
{
	// Token: 0x02000108 RID: 264
	public interface ISignaturePolicyService
	{
		// Token: 0x06000F73 RID: 3955
		string GetSignaturePolicyIdentifier();

		// Token: 0x06000F74 RID: 3956
		string GetSignaturePolicyDescription();

		// Token: 0x06000F75 RID: 3957
		string GetSignaturePolicyDownloadUrl();

		// Token: 0x06000F76 RID: 3958
		byte[] GetSignaturePolicyDocument();
	}
}
