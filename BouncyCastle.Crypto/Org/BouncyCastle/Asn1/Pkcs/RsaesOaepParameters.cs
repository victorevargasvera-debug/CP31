using System;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006BD RID: 1725
	public class RsaesOaepParameters : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F12 RID: 16146 RVA: 0x0011F3B6 File Offset: 0x0011D5B6
		public static global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x0011F3F5 File Offset: 0x0011D5F5
		public RsaesOaepParameters() : this(global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.DefaultHashAlgorithm, global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.DefaultMaskGenFunction, global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.DefaultPSourceAlgorithm)
		{
		}

		// Token: 0x06003F14 RID: 16148 RVA: 0x0011F40C File Offset: 0x0011D60C
		public RsaesOaepParameters(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier maskGenAlgorithm) : this(hashAlgorithm, maskGenAlgorithm, global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.DefaultPSourceAlgorithm)
		{
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x0011F41B File Offset: 0x0011D61B
		public RsaesOaepParameters(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier maskGenAlgorithm, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier pSourceAlgorithm)
		{
			this.hashAlgorithm = hashAlgorithm;
			this.maskGenAlgorithm = maskGenAlgorithm;
			this.pSourceAlgorithm = pSourceAlgorithm;
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x0011F438 File Offset: 0x0011D638
		public RsaesOaepParameters(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.hashAlgorithm = global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.DefaultHashAlgorithm;
			this.maskGenAlgorithm = global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.DefaultMaskGenFunction;
			this.pSourceAlgorithm = global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.DefaultPSourceAlgorithm;
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
					this.pSourceAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(o, true);
					break;
				default:
					throw new global::System.ArgumentException("unknown tag");
				}
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06003F17 RID: 16151 RVA: 0x0011F4DD File Offset: 0x0011D6DD
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm
		{
			get
			{
				return this.hashAlgorithm;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06003F18 RID: 16152 RVA: 0x0011F4E5 File Offset: 0x0011D6E5
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier MaskGenAlgorithm
		{
			get
			{
				return this.maskGenAlgorithm;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06003F19 RID: 16153 RVA: 0x0011F4ED File Offset: 0x0011D6ED
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier PSourceAlgorithm
		{
			get
			{
				return this.pSourceAlgorithm;
			}
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x0011F4F8 File Offset: 0x0011D6F8
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (!this.hashAlgorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.DefaultHashAlgorithm))
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, this.hashAlgorithm));
			}
			if (!this.maskGenAlgorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.DefaultMaskGenFunction))
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 1, this.maskGenAlgorithm));
			}
			if (!this.pSourceAlgorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.DefaultPSourceAlgorithm))
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 2, this.pSourceAlgorithm));
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001D21 RID: 7457
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm;

		// Token: 0x04001D22 RID: 7458
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier maskGenAlgorithm;

		// Token: 0x04001D23 RID: 7459
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier pSourceAlgorithm;

		// Token: 0x04001D24 RID: 7460
		public static readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultHashAlgorithm = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1, global::Org.BouncyCastle.Asn1.DerNull.Instance);

		// Token: 0x04001D25 RID: 7461
		public static readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultMaskGenFunction = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.DefaultHashAlgorithm);

		// Token: 0x04001D26 RID: 7462
		public static readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultPSourceAlgorithm = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdPSpecified, new global::Org.BouncyCastle.Asn1.DerOctetString(new byte[0]));
	}
}
