using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000088 RID: 136
	public abstract class AbstractTlsKeyExchange : global::Org.BouncyCastle.Tls.TlsKeyExchange
	{
		// Token: 0x0600058D RID: 1421 RVA: 0x00018C56 File Offset: 0x00016E56
		protected AbstractTlsKeyExchange(int keyExchange)
		{
			this.m_keyExchange = keyExchange;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00018C65 File Offset: 0x00016E65
		public virtual void Init(global::Org.BouncyCastle.Tls.TlsContext context)
		{
			this.m_context = context;
		}

		// Token: 0x0600058F RID: 1423
		public abstract void SkipServerCredentials();

		// Token: 0x06000590 RID: 1424
		public abstract void ProcessServerCredentials(global::Org.BouncyCastle.Tls.TlsCredentials serverCredentials);

		// Token: 0x06000591 RID: 1425 RVA: 0x00018C6E File Offset: 0x00016E6E
		public virtual void ProcessServerCertificate(global::Org.BouncyCastle.Tls.Certificate serverCertificate)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00018C77 File Offset: 0x00016E77
		public virtual bool RequiresServerKeyExchange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00018C7A File Offset: 0x00016E7A
		public virtual byte[] GenerateServerKeyExchange()
		{
			if (this.RequiresServerKeyExchange)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return null;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00018C8D File Offset: 0x00016E8D
		public virtual void SkipServerKeyExchange()
		{
			if (this.RequiresServerKeyExchange)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00018C9F File Offset: 0x00016E9F
		public virtual void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			if (!this.RequiresServerKeyExchange)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00018CB1 File Offset: 0x00016EB1
		public virtual short[] GetClientCertificateTypes()
		{
			return null;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00018CB4 File Offset: 0x00016EB4
		public virtual void SkipClientCredentials()
		{
		}

		// Token: 0x06000598 RID: 1432
		public abstract void ProcessClientCredentials(global::Org.BouncyCastle.Tls.TlsCredentials clientCredentials);

		// Token: 0x06000599 RID: 1433 RVA: 0x00018CB6 File Offset: 0x00016EB6
		public virtual void ProcessClientCertificate(global::Org.BouncyCastle.Tls.Certificate clientCertificate)
		{
		}

		// Token: 0x0600059A RID: 1434
		public abstract void GenerateClientKeyExchange(global::System.IO.Stream output);

		// Token: 0x0600059B RID: 1435 RVA: 0x00018CB8 File Offset: 0x00016EB8
		public virtual void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00018CC1 File Offset: 0x00016EC1
		public virtual bool RequiresCertificateVerify
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600059D RID: 1437
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsSecret GeneratePreMasterSecret();

		// Token: 0x040002F2 RID: 754
		protected readonly int m_keyExchange;

		// Token: 0x040002F3 RID: 755
		protected global::Org.BouncyCastle.Tls.TlsContext m_context;
	}
}
