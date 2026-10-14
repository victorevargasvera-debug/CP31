using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200010F RID: 271
	public class TlsFatalAlertReceived : global::Org.BouncyCastle.Tls.TlsException
	{
		// Token: 0x06000A4C RID: 2636 RVA: 0x0002781C File Offset: 0x00025A1C
		public TlsFatalAlertReceived(short alertDescription) : base(global::Org.BouncyCastle.Tls.AlertDescription.GetText(alertDescription))
		{
			this.m_alertDescription = alertDescription;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00027831 File Offset: 0x00025A31
		public virtual short AlertDescription
		{
			get
			{
				return this.m_alertDescription;
			}
		}

		// Token: 0x040006F4 RID: 1780
		protected readonly short m_alertDescription;
	}
}
