using System;
using System.IO;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000306 RID: 774
	public class CertificateStatus
	{
		// Token: 0x06002104 RID: 8452 RVA: 0x00092895 File Offset: 0x00090A95
		public CertificateStatus(byte statusType, object response)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.CertificateStatus.IsCorrectType(statusType, response))
			{
				throw new global::System.ArgumentException("not an instance of the correct type", "response");
			}
			this.mStatusType = statusType;
			this.mResponse = response;
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x000928C4 File Offset: 0x00090AC4
		public virtual byte StatusType
		{
			get
			{
				return this.mStatusType;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x000928CC File Offset: 0x00090ACC
		public virtual object Response
		{
			get
			{
				return this.mResponse;
			}
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x000928D4 File Offset: 0x00090AD4
		public virtual global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse GetOcspResponse()
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.CertificateStatus.IsCorrectType(1, this.mResponse))
			{
				throw new global::System.InvalidOperationException("'response' is not an OcspResponse");
			}
			return (global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse)this.mResponse;
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x000928FA File Offset: 0x00090AFA
		public virtual void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(this.mStatusType, output);
			if (this.mStatusType == 1)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque24(((global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse)this.mResponse).GetEncoded("DER"), output);
				return;
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00092934 File Offset: 0x00090B34
		public static global::Org.BouncyCastle.Crypto.Tls.CertificateStatus Parse(global::System.IO.Stream input)
		{
			byte b = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input);
			if (b == 1)
			{
				object response = global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse.GetInstance(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadDerObject(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque24(input)));
				return new global::Org.BouncyCastle.Crypto.Tls.CertificateStatus(b, response);
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x0009296C File Offset: 0x00090B6C
		protected static bool IsCorrectType(byte statusType, object response)
		{
			if (statusType == 1)
			{
				return response is global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse;
			}
			throw new global::System.ArgumentException("unsupported CertificateStatusType", "statusType");
		}

		// Token: 0x04000B9C RID: 2972
		protected readonly byte mStatusType;

		// Token: 0x04000B9D RID: 2973
		protected readonly object mResponse;
	}
}
