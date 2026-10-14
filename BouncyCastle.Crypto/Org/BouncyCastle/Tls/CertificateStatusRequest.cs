using System;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200009A RID: 154
	public sealed class CertificateStatusRequest
	{
		// Token: 0x06000659 RID: 1625 RVA: 0x0001AA1A File Offset: 0x00018C1A
		public CertificateStatusRequest(short statusType, object request)
		{
			if (!global::Org.BouncyCastle.Tls.CertificateStatusRequest.IsCorrectType(statusType, request))
			{
				throw new global::System.ArgumentException("not an instance of the correct type", "request");
			}
			this.m_statusType = statusType;
			this.m_request = request;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0001AA49 File Offset: 0x00018C49
		public short StatusType
		{
			get
			{
				return this.m_statusType;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x0001AA51 File Offset: 0x00018C51
		public object Request
		{
			get
			{
				return this.m_request;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0001AA59 File Offset: 0x00018C59
		public global::Org.BouncyCastle.Tls.OcspStatusRequest OcspStatusRequest
		{
			get
			{
				if (!global::Org.BouncyCastle.Tls.CertificateStatusRequest.IsCorrectType(1, this.m_request))
				{
					throw new global::System.InvalidOperationException("'request' is not an OCSPStatusRequest");
				}
				return (global::Org.BouncyCastle.Tls.OcspStatusRequest)this.m_request;
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0001AA7F File Offset: 0x00018C7F
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(this.m_statusType, output);
			if (this.m_statusType == 1)
			{
				((global::Org.BouncyCastle.Tls.OcspStatusRequest)this.m_request).Encode(output);
				return;
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001AAB0 File Offset: 0x00018CB0
		public static global::Org.BouncyCastle.Tls.CertificateStatusRequest Parse(global::System.IO.Stream input)
		{
			short num = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			if (num == 1)
			{
				object request = global::Org.BouncyCastle.Tls.OcspStatusRequest.Parse(input);
				return new global::Org.BouncyCastle.Tls.CertificateStatusRequest(num, request);
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0001AADE File Offset: 0x00018CDE
		private static bool IsCorrectType(short statusType, object request)
		{
			if (statusType == 1)
			{
				return request is global::Org.BouncyCastle.Tls.OcspStatusRequest;
			}
			throw new global::System.ArgumentException("unsupported CertificateStatusType", "statusType");
		}

		// Token: 0x0400034A RID: 842
		private short m_statusType;

		// Token: 0x0400034B RID: 843
		private object m_request;
	}
}
