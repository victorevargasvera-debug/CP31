using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000307 RID: 775
	public class CertificateStatusRequest
	{
		// Token: 0x0600210B RID: 8459 RVA: 0x0009298B File Offset: 0x00090B8B
		public CertificateStatusRequest(byte statusType, object request)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest.IsCorrectType(statusType, request))
			{
				throw new global::System.ArgumentException("not an instance of the correct type", "request");
			}
			this.mStatusType = statusType;
			this.mRequest = request;
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x000929BA File Offset: 0x00090BBA
		public virtual byte StatusType
		{
			get
			{
				return this.mStatusType;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600210D RID: 8461 RVA: 0x000929C2 File Offset: 0x00090BC2
		public virtual object Request
		{
			get
			{
				return this.mRequest;
			}
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x000929CA File Offset: 0x00090BCA
		public virtual global::Org.BouncyCastle.Crypto.Tls.OcspStatusRequest GetOcspStatusRequest()
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest.IsCorrectType(1, this.mRequest))
			{
				throw new global::System.InvalidOperationException("'request' is not an OCSPStatusRequest");
			}
			return (global::Org.BouncyCastle.Crypto.Tls.OcspStatusRequest)this.mRequest;
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x000929F0 File Offset: 0x00090BF0
		public virtual void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(this.mStatusType, output);
			if (this.mStatusType == 1)
			{
				((global::Org.BouncyCastle.Crypto.Tls.OcspStatusRequest)this.mRequest).Encode(output);
				return;
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x00092A20 File Offset: 0x00090C20
		public static global::Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest Parse(global::System.IO.Stream input)
		{
			byte b = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input);
			if (b == 1)
			{
				object result = global::Org.BouncyCastle.Crypto.Tls.OcspStatusRequest.Parse(input);
				return new global::Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest(b, result);
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x00092A4E File Offset: 0x00090C4E
		protected static bool IsCorrectType(byte statusType, object request)
		{
			if (statusType == 1)
			{
				return request is global::Org.BouncyCastle.Crypto.Tls.OcspStatusRequest;
			}
			throw new global::System.ArgumentException("unsupported CertificateStatusType", "statusType");
		}

		// Token: 0x04000B9E RID: 2974
		protected readonly byte mStatusType;

		// Token: 0x04000B9F RID: 2975
		protected readonly object mRequest;
	}
}
