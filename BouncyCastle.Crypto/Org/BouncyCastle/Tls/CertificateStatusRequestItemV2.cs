using System;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200009B RID: 155
	public sealed class CertificateStatusRequestItemV2
	{
		// Token: 0x06000660 RID: 1632 RVA: 0x0001AAFD File Offset: 0x00018CFD
		public CertificateStatusRequestItemV2(short statusType, object request)
		{
			if (!global::Org.BouncyCastle.Tls.CertificateStatusRequestItemV2.IsCorrectType(statusType, request))
			{
				throw new global::System.ArgumentException("not an instance of the correct type", "request");
			}
			this.m_statusType = statusType;
			this.m_request = request;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0001AB2C File Offset: 0x00018D2C
		public short StatusType
		{
			get
			{
				return this.m_statusType;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0001AB34 File Offset: 0x00018D34
		public object Request
		{
			get
			{
				return this.m_request;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0001AB3C File Offset: 0x00018D3C
		public global::Org.BouncyCastle.Tls.OcspStatusRequest OcspStatusRequest
		{
			get
			{
				if (!(this.m_request is global::Org.BouncyCastle.Tls.OcspStatusRequest))
				{
					throw new global::System.InvalidOperationException("'request' is not an OcspStatusRequest");
				}
				return (global::Org.BouncyCastle.Tls.OcspStatusRequest)this.m_request;
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0001AB64 File Offset: 0x00018D64
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(this.m_statusType, output);
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			short statusType = this.m_statusType;
			if (statusType - 1 <= 1)
			{
				((global::Org.BouncyCastle.Tls.OcspStatusRequest)this.m_request).Encode(buf);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(buf.ToArray(), output);
				return;
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0001ABB8 File Offset: 0x00018DB8
		public static global::Org.BouncyCastle.Tls.CertificateStatusRequestItemV2 Parse(global::System.IO.Stream input)
		{
			short status_type = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input), false);
			if (status_type - 1 <= 1)
			{
				object request = global::Org.BouncyCastle.Tls.OcspStatusRequest.Parse(buf);
				global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
				return new global::Org.BouncyCastle.Tls.CertificateStatusRequestItemV2(status_type, request);
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0001ABFD File Offset: 0x00018DFD
		private static bool IsCorrectType(short statusType, object request)
		{
			if (statusType - 1 <= 1)
			{
				return request is global::Org.BouncyCastle.Tls.OcspStatusRequest;
			}
			throw new global::System.ArgumentException("unsupported CertificateStatusType", "statusType");
		}

		// Token: 0x0400034C RID: 844
		private readonly short m_statusType;

		// Token: 0x0400034D RID: 845
		private readonly object m_request;
	}
}
