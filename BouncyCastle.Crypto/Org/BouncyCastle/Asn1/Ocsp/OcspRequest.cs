using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006CA RID: 1738
	public class OcspRequest : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F7D RID: 16253 RVA: 0x00120721 File Offset: 0x0011E921
		public static global::Org.BouncyCastle.Asn1.Ocsp.OcspRequest GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Ocsp.OcspRequest.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x00120730 File Offset: 0x0011E930
		public static global::Org.BouncyCastle.Asn1.Ocsp.OcspRequest GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.OcspRequest)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.OcspRequest)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.OcspRequest((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x0012077D File Offset: 0x0011E97D
		public OcspRequest(global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest tbsRequest, global::Org.BouncyCastle.Asn1.Ocsp.Signature optionalSignature)
		{
			if (tbsRequest == null)
			{
				throw new global::System.ArgumentNullException("tbsRequest");
			}
			this.tbsRequest = tbsRequest;
			this.optionalSignature = optionalSignature;
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x001207A1 File Offset: 0x0011E9A1
		private OcspRequest(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.tbsRequest = global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest.GetInstance(seq[0]);
			if (seq.Count == 2)
			{
				this.optionalSignature = global::Org.BouncyCastle.Asn1.Ocsp.Signature.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[1], true);
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06003F81 RID: 16257 RVA: 0x001207DC File Offset: 0x0011E9DC
		public global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest TbsRequest
		{
			get
			{
				return this.tbsRequest;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06003F82 RID: 16258 RVA: 0x001207E4 File Offset: 0x0011E9E4
		public global::Org.BouncyCastle.Asn1.Ocsp.Signature OptionalSignature
		{
			get
			{
				return this.optionalSignature;
			}
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x001207EC File Offset: 0x0011E9EC
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.tbsRequest
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.optionalSignature);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001D6B RID: 7531
		private readonly global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest tbsRequest;

		// Token: 0x04001D6C RID: 7532
		private readonly global::Org.BouncyCastle.Asn1.Ocsp.Signature optionalSignature;
	}
}
