using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000145 RID: 325
	public class TlsECConfig
	{
		// Token: 0x06000D2D RID: 3373 RVA: 0x0003245D File Offset: 0x0003065D
		public TlsECConfig(int namedGroup)
		{
			this.m_namedGroup = namedGroup;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x0003246C File Offset: 0x0003066C
		public virtual int NamedGroup
		{
			get
			{
				return this.m_namedGroup;
			}
		}

		// Token: 0x040007CD RID: 1997
		protected readonly int m_namedGroup;
	}
}
