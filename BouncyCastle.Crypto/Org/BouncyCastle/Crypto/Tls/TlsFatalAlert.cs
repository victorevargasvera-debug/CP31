using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000371 RID: 881
	public class TlsFatalAlert : global::Org.BouncyCastle.Crypto.Tls.TlsException
	{
		// Token: 0x060023E5 RID: 9189 RVA: 0x0009CA13 File Offset: 0x0009AC13
		public TlsFatalAlert(byte alertDescription) : this(alertDescription, null)
		{
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x0009CA1D File Offset: 0x0009AC1D
		public TlsFatalAlert(byte alertDescription, global::System.Exception alertCause) : base(global::Org.BouncyCastle.Crypto.Tls.AlertDescription.GetText(alertDescription), alertCause)
		{
			this.alertDescription = alertDescription;
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060023E7 RID: 9191 RVA: 0x0009CA33 File Offset: 0x0009AC33
		public virtual byte AlertDescription
		{
			get
			{
				return this.alertDescription;
			}
		}

		// Token: 0x04000E6C RID: 3692
		private readonly byte alertDescription;
	}
}
