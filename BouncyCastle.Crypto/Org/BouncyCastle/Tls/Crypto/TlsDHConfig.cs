using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000143 RID: 323
	public class TlsDHConfig
	{
		// Token: 0x06000D27 RID: 3367 RVA: 0x0003240B File Offset: 0x0003060B
		public TlsDHConfig(global::Org.BouncyCastle.Tls.Crypto.DHGroup explicitGroup)
		{
			this.m_explicitGroup = explicitGroup;
			this.m_namedGroup = -1;
			this.m_padded = false;
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00032428 File Offset: 0x00030628
		public TlsDHConfig(int namedGroup, bool padded)
		{
			this.m_explicitGroup = null;
			this.m_namedGroup = namedGroup;
			this.m_padded = padded;
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x00032445 File Offset: 0x00030645
		public virtual global::Org.BouncyCastle.Tls.Crypto.DHGroup ExplicitGroup
		{
			get
			{
				return this.m_explicitGroup;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x0003244D File Offset: 0x0003064D
		public virtual int NamedGroup
		{
			get
			{
				return this.m_namedGroup;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00032455 File Offset: 0x00030655
		public virtual bool IsPadded
		{
			get
			{
				return this.m_padded;
			}
		}

		// Token: 0x040007CA RID: 1994
		protected readonly global::Org.BouncyCastle.Tls.Crypto.DHGroup m_explicitGroup;

		// Token: 0x040007CB RID: 1995
		protected readonly int m_namedGroup;

		// Token: 0x040007CC RID: 1996
		protected readonly bool m_padded;
	}
}
