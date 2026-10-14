using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000372 RID: 882
	public class TlsFatalAlertReceived : global::Org.BouncyCastle.Crypto.Tls.TlsException
	{
		// Token: 0x060023E8 RID: 9192 RVA: 0x0009CA3B File Offset: 0x0009AC3B
		public TlsFatalAlertReceived(byte alertDescription) : base(global::Org.BouncyCastle.Crypto.Tls.AlertDescription.GetText(alertDescription), null)
		{
			this.alertDescription = alertDescription;
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x0009CA51 File Offset: 0x0009AC51
		public virtual byte AlertDescription
		{
			get
			{
				return this.alertDescription;
			}
		}

		// Token: 0x04000E6D RID: 3693
		private readonly byte alertDescription;
	}
}
