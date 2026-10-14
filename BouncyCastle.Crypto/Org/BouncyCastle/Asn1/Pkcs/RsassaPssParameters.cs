using System;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006BF RID: 1727
	public class RsassaPssParameters : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F29 RID: 16169 RVA: 0x0011F814 File Offset: 0x0011DA14
		public static global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x0011F861 File Offset: 0x0011DA61
		public RsassaPssParameters()
		{
			this.hashAlgorithm = global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultHashAlgorithm;
			this.maskGenAlgorithm = global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultMaskGenFunction;
			this.saltLength = global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultSaltLength;
			this.trailerField = global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultTrailerField;
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x0011F895 File Offset: 0x0011DA95
		public RsassaPssParameters(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier maskGenAlgorithm, global::Org.BouncyCastle.Asn1.DerInteger saltLength, global::Org.BouncyCastle.Asn1.DerInteger trailerField)
		{
			this.hashAlgorithm = hashAlgorithm;
			this.maskGenAlgorithm = maskGenAlgorithm;
			this.saltLength = saltLength;
			this.trailerField = trailerField;
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x0011F8BC File Offset: 0x0011DABC
		public RsassaPssParameters(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.hashAlgorithm = global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultHashAlgorithm;
			this.maskGenAlgorithm = global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultMaskGenFunction;
			this.saltLength = global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultSaltLength;
			this.trailerField = global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultTrailerField;
			for (int i = 0; i != seq.Count; i++)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[i];
				switch (o.TagNo)
				{
				case 0:
					this.hashAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(o, true);
					break;
				case 1:
					this.maskGenAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(o, true);
					break;
				case 2:
					this.saltLength = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(o, true);
					break;
				case 3:
					this.trailerField = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(o, true);
					break;
				default:
					throw new global::System.ArgumentException("unknown tag");
				}
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06003F2D RID: 16173 RVA: 0x0011F97F File Offset: 0x0011DB7F
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm
		{
			get
			{
				return this.hashAlgorithm;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06003F2E RID: 16174 RVA: 0x0011F987 File Offset: 0x0011DB87
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier MaskGenAlgorithm
		{
			get
			{
				return this.maskGenAlgorithm;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06003F2F RID: 16175 RVA: 0x0011F98F File Offset: 0x0011DB8F
		public global::Org.BouncyCastle.Asn1.DerInteger SaltLength
		{
			get
			{
				return this.saltLength;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06003F30 RID: 16176 RVA: 0x0011F997 File Offset: 0x0011DB97
		public global::Org.BouncyCastle.Asn1.DerInteger TrailerField
		{
			get
			{
				return this.trailerField;
			}
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x0011F9A0 File Offset: 0x0011DBA0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (!this.hashAlgorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultHashAlgorithm))
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, this.hashAlgorithm));
			}
			if (!this.maskGenAlgorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultMaskGenFunction))
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 1, this.maskGenAlgorithm));
			}
			if (!this.saltLength.Equals(global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultSaltLength))
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 2, this.saltLength));
			}
			if (!this.trailerField.Equals(global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultTrailerField))
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 3, this.trailerField));
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001D2F RID: 7471
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm;

		// Token: 0x04001D30 RID: 7472
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier maskGenAlgorithm;

		// Token: 0x04001D31 RID: 7473
		private global::Org.BouncyCastle.Asn1.DerInteger saltLength;

		// Token: 0x04001D32 RID: 7474
		private global::Org.BouncyCastle.Asn1.DerInteger trailerField;

		// Token: 0x04001D33 RID: 7475
		public static readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultHashAlgorithm = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1, global::Org.BouncyCastle.Asn1.DerNull.Instance);

		// Token: 0x04001D34 RID: 7476
		public static readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultMaskGenFunction = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultHashAlgorithm);

		// Token: 0x04001D35 RID: 7477
		public static readonly global::Org.BouncyCastle.Asn1.DerInteger DefaultSaltLength = new global::Org.BouncyCastle.Asn1.DerInteger(20);

		// Token: 0x04001D36 RID: 7478
		public static readonly global::Org.BouncyCastle.Asn1.DerInteger DefaultTrailerField = new global::Org.BouncyCastle.Asn1.DerInteger(1);
	}
}
