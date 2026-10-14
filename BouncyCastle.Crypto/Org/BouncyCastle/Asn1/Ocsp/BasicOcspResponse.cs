using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006C5 RID: 1733
	public class BasicOcspResponse : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F57 RID: 16215 RVA: 0x00120119 File Offset: 0x0011E319
		public static global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x00120128 File Offset: 0x0011E328
		public static global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x00120175 File Offset: 0x0011E375
		public BasicOcspResponse(global::Org.BouncyCastle.Asn1.Ocsp.ResponseData tbsResponseData, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signatureAlgorithm, global::Org.BouncyCastle.Asn1.DerBitString signature, global::Org.BouncyCastle.Asn1.Asn1Sequence certs)
		{
			this.tbsResponseData = tbsResponseData;
			this.signatureAlgorithm = signatureAlgorithm;
			this.signature = signature;
			this.certs = certs;
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x0012019C File Offset: 0x0011E39C
		private BasicOcspResponse(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.tbsResponseData = global::Org.BouncyCastle.Asn1.Ocsp.ResponseData.GetInstance(seq[0]);
			this.signatureAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[1]);
			this.signature = (global::Org.BouncyCastle.Asn1.DerBitString)seq[2];
			if (seq.Count > 3)
			{
				this.certs = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[3], true);
			}
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x00120206 File Offset: 0x0011E406
		[global::System.Obsolete("Use TbsResponseData property instead")]
		public global::Org.BouncyCastle.Asn1.Ocsp.ResponseData GetTbsResponseData()
		{
			return this.tbsResponseData;
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06003F5C RID: 16220 RVA: 0x0012020E File Offset: 0x0011E40E
		public global::Org.BouncyCastle.Asn1.Ocsp.ResponseData TbsResponseData
		{
			get
			{
				return this.tbsResponseData;
			}
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x00120216 File Offset: 0x0011E416
		[global::System.Obsolete("Use SignatureAlgorithm property instead")]
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetSignatureAlgorithm()
		{
			return this.signatureAlgorithm;
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06003F5E RID: 16222 RVA: 0x0012021E File Offset: 0x0011E41E
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SignatureAlgorithm
		{
			get
			{
				return this.signatureAlgorithm;
			}
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x00120226 File Offset: 0x0011E426
		[global::System.Obsolete("Use Signature property instead")]
		public global::Org.BouncyCastle.Asn1.DerBitString GetSignature()
		{
			return this.signature;
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06003F60 RID: 16224 RVA: 0x0012022E File Offset: 0x0011E42E
		public global::Org.BouncyCastle.Asn1.DerBitString Signature
		{
			get
			{
				return this.signature;
			}
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x00120236 File Offset: 0x0011E436
		public byte[] GetSignatureOctets()
		{
			return this.signature.GetOctets();
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x00120243 File Offset: 0x0011E443
		[global::System.Obsolete("Use Certs property instead")]
		public global::Org.BouncyCastle.Asn1.Asn1Sequence GetCerts()
		{
			return this.certs;
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06003F63 RID: 16227 RVA: 0x0012024B File Offset: 0x0011E44B
		public global::Org.BouncyCastle.Asn1.Asn1Sequence Certs
		{
			get
			{
				return this.certs;
			}
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x00120253 File Offset: 0x0011E453
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.tbsResponseData,
				this.signatureAlgorithm,
				this.signature
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.certs);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001D55 RID: 7509
		private readonly global::Org.BouncyCastle.Asn1.Ocsp.ResponseData tbsResponseData;

		// Token: 0x04001D56 RID: 7510
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signatureAlgorithm;

		// Token: 0x04001D57 RID: 7511
		private readonly global::Org.BouncyCastle.Asn1.DerBitString signature;

		// Token: 0x04001D58 RID: 7512
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence certs;
	}
}
