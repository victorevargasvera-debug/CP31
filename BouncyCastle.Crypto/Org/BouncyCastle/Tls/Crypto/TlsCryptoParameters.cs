using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000140 RID: 320
	public class TlsCryptoParameters
	{
		// Token: 0x06000D17 RID: 3351 RVA: 0x00032100 File Offset: 0x00030300
		public TlsCryptoParameters(global::Org.BouncyCastle.Tls.TlsContext context)
		{
			this.m_context = context;
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0003210F File Offset: 0x0003030F
		public global::Org.BouncyCastle.Tls.SecurityParameters SecurityParameters
		{
			get
			{
				return this.m_context.SecurityParameters;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x0003211C File Offset: 0x0003031C
		public global::Org.BouncyCastle.Tls.ProtocolVersion ClientVersion
		{
			get
			{
				return this.m_context.ClientVersion;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00032129 File Offset: 0x00030329
		public global::Org.BouncyCastle.Tls.ProtocolVersion RsaPreMasterSecretVersion
		{
			get
			{
				return this.m_context.RsaPreMasterSecretVersion;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00032136 File Offset: 0x00030336
		public virtual global::Org.BouncyCastle.Tls.ProtocolVersion ServerVersion
		{
			get
			{
				return this.m_context.ServerVersion;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x00032143 File Offset: 0x00030343
		public bool IsServer
		{
			get
			{
				return this.m_context.IsServer;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x00032150 File Offset: 0x00030350
		public global::Org.BouncyCastle.Tls.Crypto.TlsNonceGenerator NonceGenerator
		{
			get
			{
				return this.m_context.NonceGenerator;
			}
		}

		// Token: 0x040007C4 RID: 1988
		private readonly global::Org.BouncyCastle.Tls.TlsContext m_context;
	}
}
