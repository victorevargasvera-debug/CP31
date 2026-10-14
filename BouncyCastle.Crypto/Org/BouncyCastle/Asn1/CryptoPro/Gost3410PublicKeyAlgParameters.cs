using System;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
	// Token: 0x02000724 RID: 1828
	public class Gost3410PublicKeyAlgParameters : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060041AD RID: 16813 RVA: 0x00129742 File Offset: 0x00127942
		public static global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x060041AE RID: 16814 RVA: 0x00129750 File Offset: 0x00127950
		public static global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters)
			{
				return (global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters)obj;
			}
			return new global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x0012976F File Offset: 0x0012796F
		public Gost3410PublicKeyAlgParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet, global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestParamSet) : this(publicKeyParamSet, digestParamSet, null)
		{
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x0012977A File Offset: 0x0012797A
		public Gost3410PublicKeyAlgParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet, global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestParamSet, global::Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionParamSet)
		{
			if (publicKeyParamSet == null)
			{
				throw new global::System.ArgumentNullException("publicKeyParamSet");
			}
			if (digestParamSet == null)
			{
				throw new global::System.ArgumentNullException("digestParamSet");
			}
			this.publicKeyParamSet = publicKeyParamSet;
			this.digestParamSet = digestParamSet;
			this.encryptionParamSet = encryptionParamSet;
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x001297B4 File Offset: 0x001279B4
		[global::System.Obsolete("Use 'GetInstance' instead")]
		public Gost3410PublicKeyAlgParameters(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.publicKeyParamSet = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0];
			this.digestParamSet = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[1];
			if (seq.Count > 2)
			{
				this.encryptionParamSet = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[2];
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060041B2 RID: 16818 RVA: 0x00129806 File Offset: 0x00127A06
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet
		{
			get
			{
				return this.publicKeyParamSet;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060041B3 RID: 16819 RVA: 0x0012980E File Offset: 0x00127A0E
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier DigestParamSet
		{
			get
			{
				return this.digestParamSet;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060041B4 RID: 16820 RVA: 0x00129816 File Offset: 0x00127A16
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier EncryptionParamSet
		{
			get
			{
				return this.encryptionParamSet;
			}
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x00129820 File Offset: 0x00127A20
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.publicKeyParamSet,
				this.digestParamSet
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.encryptionParamSet
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F9A RID: 8090
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet;

		// Token: 0x04001F9B RID: 8091
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestParamSet;

		// Token: 0x04001F9C RID: 8092
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionParamSet;
	}
}
