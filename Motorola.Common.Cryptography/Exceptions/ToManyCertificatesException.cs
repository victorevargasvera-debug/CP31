using System;
using Motorola.Common.Cryptography.Autofac;

namespace Motorola.Common.Cryptography.Exceptions
{
	// Token: 0x02000017 RID: 23
	public class ToManyCertificatesException : global::Motorola.Common.Cryptography.Exceptions.CryptographyException
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00003FE4 File Offset: 0x000021E4
		public ToManyCertificatesException(global::Motorola.Common.Cryptography.CertificateType? registryType)
		{
			int a_ = 16;
			base..ctor(string.Format(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("㉥ݧ䩩ū཭ṯୱ味ᕵᵷࡹࡻ᝽ﲇﾋ꺍﶑望ﶙ얟욡蒣삥잧\ud8a9隫躭쮯花즳", a_), registryType));
		}
	}
}
