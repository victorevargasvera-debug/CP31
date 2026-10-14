using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Mozilla
{
	// Token: 0x020006DC RID: 1756
	public class PublicKeyAndChallenge : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003FFA RID: 16378 RVA: 0x00122567 File Offset: 0x00120767
		public static global::Org.BouncyCastle.Asn1.Mozilla.PublicKeyAndChallenge GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Mozilla.PublicKeyAndChallenge)
			{
				return (global::Org.BouncyCastle.Asn1.Mozilla.PublicKeyAndChallenge)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Mozilla.PublicKeyAndChallenge((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in 'PublicKeyAndChallenge' factory : " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj) + ".");
		}

		// Token: 0x06003FFB RID: 16379 RVA: 0x001225A6 File Offset: 0x001207A6
		public PublicKeyAndChallenge(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.pkacSeq = seq;
			this.spki = global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo.GetInstance(seq[0]);
			this.challenge = global::Org.BouncyCastle.Asn1.DerIA5String.GetInstance(seq[1]);
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x001225D9 File Offset: 0x001207D9
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.pkacSeq;
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06003FFD RID: 16381 RVA: 0x001225E1 File Offset: 0x001207E1
		public global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo SubjectPublicKeyInfo
		{
			get
			{
				return this.spki;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06003FFE RID: 16382 RVA: 0x001225E9 File Offset: 0x001207E9
		public global::Org.BouncyCastle.Asn1.DerIA5String Challenge
		{
			get
			{
				return this.challenge;
			}
		}

		// Token: 0x04001E07 RID: 7687
		private global::Org.BouncyCastle.Asn1.Asn1Sequence pkacSeq;

		// Token: 0x04001E08 RID: 7688
		private global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo spki;

		// Token: 0x04001E09 RID: 7689
		private global::Org.BouncyCastle.Asn1.DerIA5String challenge;
	}
}
