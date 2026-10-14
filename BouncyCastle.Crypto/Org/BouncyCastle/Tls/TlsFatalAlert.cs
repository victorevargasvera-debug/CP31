using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200010E RID: 270
	public class TlsFatalAlert : global::Org.BouncyCastle.Tls.TlsException
	{
		// Token: 0x06000A46 RID: 2630 RVA: 0x000277B8 File Offset: 0x000259B8
		private static string GetMessage(short alertDescription, string detailMessage)
		{
			string msg = global::Org.BouncyCastle.Tls.AlertDescription.GetText(alertDescription);
			if (detailMessage != null)
			{
				msg = msg + "; " + detailMessage;
			}
			return msg;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000277DD File Offset: 0x000259DD
		public TlsFatalAlert(short alertDescription) : this(alertDescription, null)
		{
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000277E7 File Offset: 0x000259E7
		public TlsFatalAlert(short alertDescription, string detailMessage) : this(alertDescription, detailMessage, null)
		{
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000277F2 File Offset: 0x000259F2
		public TlsFatalAlert(short alertDescription, global::System.Exception alertCause) : this(alertDescription, null, alertCause)
		{
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x000277FD File Offset: 0x000259FD
		public TlsFatalAlert(short alertDescription, string detailMessage, global::System.Exception alertCause) : base(global::Org.BouncyCastle.Tls.TlsFatalAlert.GetMessage(alertDescription, detailMessage), alertCause)
		{
			this.m_alertDescription = alertDescription;
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00027814 File Offset: 0x00025A14
		public virtual short AlertDescription
		{
			get
			{
				return this.m_alertDescription;
			}
		}

		// Token: 0x040006F3 RID: 1779
		protected readonly short m_alertDescription;
	}
}
