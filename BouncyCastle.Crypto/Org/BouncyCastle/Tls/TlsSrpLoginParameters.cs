using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200012A RID: 298
	public class TlsSrpLoginParameters
	{
		// Token: 0x06000B72 RID: 2930 RVA: 0x0002B791 File Offset: 0x00029991
		public TlsSrpLoginParameters(byte[] identity, global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig, global::Org.BouncyCastle.Math.BigInteger verifier, byte[] salt)
		{
			this.m_identity = global::Org.BouncyCastle.Utilities.Arrays.Clone(identity);
			this.m_srpConfig = srpConfig;
			this.m_verifier = verifier;
			this.m_salt = global::Org.BouncyCastle.Utilities.Arrays.Clone(salt);
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0002B7C0 File Offset: 0x000299C0
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig Config
		{
			get
			{
				return this.m_srpConfig;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0002B7C8 File Offset: 0x000299C8
		public virtual byte[] Identity
		{
			get
			{
				return this.m_identity;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0002B7D0 File Offset: 0x000299D0
		public virtual byte[] Salt
		{
			get
			{
				return this.m_salt;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0002B7D8 File Offset: 0x000299D8
		public virtual global::Org.BouncyCastle.Math.BigInteger Verifier
		{
			get
			{
				return this.m_verifier;
			}
		}

		// Token: 0x0400074F RID: 1871
		protected byte[] m_identity;

		// Token: 0x04000750 RID: 1872
		protected global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig m_srpConfig;

		// Token: 0x04000751 RID: 1873
		protected global::Org.BouncyCastle.Math.BigInteger m_verifier;

		// Token: 0x04000752 RID: 1874
		protected byte[] m_salt;
	}
}
