using System;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200008E RID: 142
	public class BasicTlsPskExternal : global::Org.BouncyCastle.Tls.TlsPskExternal, global::Org.BouncyCastle.Tls.TlsPsk
	{
		// Token: 0x060005FE RID: 1534 RVA: 0x0001980A File Offset: 0x00017A0A
		public BasicTlsPskExternal(byte[] identity, global::Org.BouncyCastle.Tls.Crypto.TlsSecret key) : this(identity, key, 4)
		{
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00019815 File Offset: 0x00017A15
		public BasicTlsPskExternal(byte[] identity, global::Org.BouncyCastle.Tls.Crypto.TlsSecret key, int prfAlgorithm)
		{
			this.m_identity = global::Org.BouncyCastle.Utilities.Arrays.Clone(identity);
			this.m_key = key;
			this.m_prfAlgorithm = prfAlgorithm;
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00019837 File Offset: 0x00017A37
		public virtual byte[] Identity
		{
			get
			{
				return this.m_identity;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x0001983F File Offset: 0x00017A3F
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsSecret Key
		{
			get
			{
				return this.m_key;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00019847 File Offset: 0x00017A47
		public virtual int PrfAlgorithm
		{
			get
			{
				return this.m_prfAlgorithm;
			}
		}

		// Token: 0x0400032A RID: 810
		protected readonly byte[] m_identity;

		// Token: 0x0400032B RID: 811
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_key;

		// Token: 0x0400032C RID: 812
		protected readonly int m_prfAlgorithm;
	}
}
