using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006CB RID: 1739
	public class OcspResponse : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F84 RID: 16260 RVA: 0x00120815 File Offset: 0x0011EA15
		public static global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x00120824 File Offset: 0x0011EA24
		public static global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x00120871 File Offset: 0x0011EA71
		public OcspResponse(global::Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus responseStatus, global::Org.BouncyCastle.Asn1.Ocsp.ResponseBytes responseBytes)
		{
			if (responseStatus == null)
			{
				throw new global::System.ArgumentNullException("responseStatus");
			}
			this.responseStatus = responseStatus;
			this.responseBytes = responseBytes;
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x00120895 File Offset: 0x0011EA95
		private OcspResponse(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.responseStatus = new global::Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus(global::Org.BouncyCastle.Asn1.DerEnumerated.GetInstance(seq[0]));
			if (seq.Count == 2)
			{
				this.responseBytes = global::Org.BouncyCastle.Asn1.Ocsp.ResponseBytes.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[1], true);
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06003F88 RID: 16264 RVA: 0x001208D5 File Offset: 0x0011EAD5
		public global::Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus ResponseStatus
		{
			get
			{
				return this.responseStatus;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06003F89 RID: 16265 RVA: 0x001208DD File Offset: 0x0011EADD
		public global::Org.BouncyCastle.Asn1.Ocsp.ResponseBytes ResponseBytes
		{
			get
			{
				return this.responseBytes;
			}
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x001208E5 File Offset: 0x0011EAE5
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.responseStatus
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.responseBytes);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001D6D RID: 7533
		private readonly global::Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus responseStatus;

		// Token: 0x04001D6E RID: 7534
		private readonly global::Org.BouncyCastle.Asn1.Ocsp.ResponseBytes responseBytes;
	}
}
