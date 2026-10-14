using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000520 RID: 1312
	public class CmsAuthenticatedGenerator : global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator
	{
		// Token: 0x060032E8 RID: 13032 RVA: 0x000F33F7 File Offset: 0x000F15F7
		public CmsAuthenticatedGenerator()
		{
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x000F33FF File Offset: 0x000F15FF
		public CmsAuthenticatedGenerator(global::Org.BouncyCastle.Security.SecureRandom rand) : base(rand)
		{
		}
	}
}
