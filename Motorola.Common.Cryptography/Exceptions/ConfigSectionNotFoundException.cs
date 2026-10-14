using System;
using Motorola.Common.Cryptography.Autofac;

namespace Motorola.Common.Cryptography.Exceptions
{
	// Token: 0x02000013 RID: 19
	public class ConfigSectionNotFoundException : global::Motorola.Common.Cryptography.Exceptions.CryptographyException
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00003EA4 File Offset: 0x000020A4
		public ConfigSectionNotFoundException(string sectionName)
		{
			int a_ = 7;
			base..ctor(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("Ṝぞའբ౤f䥨ᡪ࡬౮հᩲᩴ᥶奸ᕺቼ୾ꆀ람꾎", a_) + sectionName);
		}
	}
}
