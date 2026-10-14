using System;
using Motorola.Common.Cryptography.Autofac;

namespace Motorola.Common.Cryptography.Exceptions
{
	// Token: 0x02000011 RID: 17
	public class CertificateGroupNotFoundException : global::Motorola.Common.Cryptography.Exceptions.CryptographyException
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00003E60 File Offset: 0x00002060
		public CertificateGroupNotFoundException(string groupName)
		{
			int a_ = 12;
			base..ctor(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("Ⅱţᑥᱧͩ੫ݭ፯፱s፵塷ᵹ๻ᅽꒃﺉ겋ﾏ望ꊗ몙", a_) + groupName);
		}
	}
}
