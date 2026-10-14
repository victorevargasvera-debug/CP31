using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001E2 RID: 482
	public class OCSPRespGenerator
	{
		// Token: 0x060011DE RID: 4574 RVA: 0x0004EAF8 File Offset: 0x0004CCF8
		public global::Org.BouncyCastle.Ocsp.OcspResp Generate(int status, object response)
		{
			if (response == null)
			{
				return new global::Org.BouncyCastle.Ocsp.OcspResp(new global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse(new global::Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus(status), null));
			}
			if (response is global::Org.BouncyCastle.Ocsp.BasicOcspResp)
			{
				global::Org.BouncyCastle.Ocsp.BasicOcspResp r = (global::Org.BouncyCastle.Ocsp.BasicOcspResp)response;
				global::Org.BouncyCastle.Asn1.Asn1OctetString octs;
				try
				{
					octs = new global::Org.BouncyCastle.Asn1.DerOctetString(r.GetEncoded());
				}
				catch (global::System.Exception e)
				{
					throw new global::Org.BouncyCastle.Ocsp.OcspException("can't encode object.", e);
				}
				global::Org.BouncyCastle.Asn1.Ocsp.ResponseBytes rb = new global::Org.BouncyCastle.Asn1.Ocsp.ResponseBytes(global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcspBasic, octs);
				return new global::Org.BouncyCastle.Ocsp.OcspResp(new global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse(new global::Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus(status), rb));
			}
			throw new global::Org.BouncyCastle.Ocsp.OcspException("unknown response object");
		}

		// Token: 0x040008ED RID: 2285
		public const int Successful = 0;

		// Token: 0x040008EE RID: 2286
		public const int MalformedRequest = 1;

		// Token: 0x040008EF RID: 2287
		public const int InternalError = 2;

		// Token: 0x040008F0 RID: 2288
		public const int TryLater = 3;

		// Token: 0x040008F1 RID: 2289
		public const int SigRequired = 5;

		// Token: 0x040008F2 RID: 2290
		public const int Unauthorized = 6;
	}
}
