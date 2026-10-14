using System;
using System.IO;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.Ocsp
{
	// Token: 0x020006F0 RID: 1776
	public class RequestedCertificate : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06004063 RID: 16483 RVA: 0x00124278 File Offset: 0x00122478
		public static global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate)
			{
				return (global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(obj));
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x001242D9 File Offset: 0x001224D9
		public static global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			if (!isExplicit)
			{
				throw new global::System.ArgumentException("choice item must be explicitly tagged");
			}
			return global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate.GetInstance(obj.GetObject());
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x001242F4 File Offset: 0x001224F4
		private RequestedCertificate(global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged)
		{
			global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate.Choice tagNo = (global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate.Choice)tagged.TagNo;
			if (tagNo == global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate.Choice.PublicKeyCertificate)
			{
				this.publicKeyCert = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(tagged, true).GetOctets();
				return;
			}
			if (tagNo == global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate.Choice.AttributeCertificate)
			{
				this.attributeCert = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(tagged, true).GetOctets();
				return;
			}
			throw new global::System.ArgumentException("unknown tag number: " + tagged.TagNo.ToString());
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x00124358 File Offset: 0x00122558
		public RequestedCertificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure certificate)
		{
			this.cert = certificate;
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x00124367 File Offset: 0x00122567
		public RequestedCertificate(global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate.Choice type, byte[] certificateOctets) : this(new global::Org.BouncyCastle.Asn1.DerTaggedObject((int)type, new global::Org.BouncyCastle.Asn1.DerOctetString(certificateOctets)))
		{
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x0012437B File Offset: 0x0012257B
		public global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate.Choice Type
		{
			get
			{
				if (this.cert != null)
				{
					return global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate.Choice.Certificate;
				}
				if (this.publicKeyCert != null)
				{
					return global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate.Choice.PublicKeyCertificate;
				}
				return global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.RequestedCertificate.Choice.AttributeCertificate;
			}
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x00124394 File Offset: 0x00122594
		public byte[] GetCertificateBytes()
		{
			if (this.cert != null)
			{
				try
				{
					return this.cert.GetEncoded();
				}
				catch (global::System.IO.IOException e)
				{
					string str = "can't decode certificate: ";
					global::System.IO.IOException ex = e;
					throw new global::System.InvalidOperationException(str + ((ex != null) ? ex.ToString() : null));
				}
			}
			if (this.publicKeyCert != null)
			{
				return this.publicKeyCert;
			}
			return this.attributeCert;
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x001243FC File Offset: 0x001225FC
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.publicKeyCert != null)
			{
				return new global::Org.BouncyCastle.Asn1.DerTaggedObject(0, new global::Org.BouncyCastle.Asn1.DerOctetString(this.publicKeyCert));
			}
			if (this.attributeCert != null)
			{
				return new global::Org.BouncyCastle.Asn1.DerTaggedObject(1, new global::Org.BouncyCastle.Asn1.DerOctetString(this.attributeCert));
			}
			return this.cert.ToAsn1Object();
		}

		// Token: 0x04001E86 RID: 7814
		private readonly global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure cert;

		// Token: 0x04001E87 RID: 7815
		private readonly byte[] publicKeyCert;

		// Token: 0x04001E88 RID: 7816
		private readonly byte[] attributeCert;

		// Token: 0x0200089A RID: 2202
		public enum Choice
		{
			// Token: 0x0400264F RID: 9807
			Certificate = -1,
			// Token: 0x04002650 RID: 9808
			PublicKeyCertificate,
			// Token: 0x04002651 RID: 9809
			AttributeCertificate
		}
	}
}
