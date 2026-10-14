using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006CD RID: 1741
	public class Request : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F8D RID: 16269 RVA: 0x00120925 File Offset: 0x0011EB25
		public static global::Org.BouncyCastle.Asn1.Ocsp.Request GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Ocsp.Request.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x00120934 File Offset: 0x0011EB34
		public static global::Org.BouncyCastle.Asn1.Ocsp.Request GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.Request)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.Request)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.Request((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x00120981 File Offset: 0x0011EB81
		public Request(global::Org.BouncyCastle.Asn1.Ocsp.CertID reqCert, global::Org.BouncyCastle.Asn1.X509.X509Extensions singleRequestExtensions)
		{
			if (reqCert == null)
			{
				throw new global::System.ArgumentNullException("reqCert");
			}
			this.reqCert = reqCert;
			this.singleRequestExtensions = singleRequestExtensions;
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x001209A5 File Offset: 0x0011EBA5
		private Request(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.reqCert = global::Org.BouncyCastle.Asn1.Ocsp.CertID.GetInstance(seq[0]);
			if (seq.Count == 2)
			{
				this.singleRequestExtensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[1], true);
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06003F91 RID: 16273 RVA: 0x001209E0 File Offset: 0x0011EBE0
		public global::Org.BouncyCastle.Asn1.Ocsp.CertID ReqCert
		{
			get
			{
				return this.reqCert;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06003F92 RID: 16274 RVA: 0x001209E8 File Offset: 0x0011EBE8
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions SingleRequestExtensions
		{
			get
			{
				return this.singleRequestExtensions;
			}
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x001209F0 File Offset: 0x0011EBF0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.reqCert
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.singleRequestExtensions);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001D75 RID: 7541
		private readonly global::Org.BouncyCastle.Asn1.Ocsp.CertID reqCert;

		// Token: 0x04001D76 RID: 7542
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Extensions singleRequestExtensions;
	}
}
