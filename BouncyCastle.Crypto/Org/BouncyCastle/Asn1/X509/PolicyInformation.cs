using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000662 RID: 1634
	public class PolicyInformation : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C66 RID: 15462 RVA: 0x001149D8 File Offset: 0x00112BD8
		private PolicyInformation(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 1 || seq.Count > 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.policyIdentifier = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			if (seq.Count > 1)
			{
				this.policyQualifiers = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[1]);
			}
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x00114A48 File Offset: 0x00112C48
		public PolicyInformation(global::Org.BouncyCastle.Asn1.DerObjectIdentifier policyIdentifier)
		{
			this.policyIdentifier = policyIdentifier;
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x00114A57 File Offset: 0x00112C57
		public PolicyInformation(global::Org.BouncyCastle.Asn1.DerObjectIdentifier policyIdentifier, global::Org.BouncyCastle.Asn1.Asn1Sequence policyQualifiers)
		{
			this.policyIdentifier = policyIdentifier;
			this.policyQualifiers = policyQualifiers;
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x00114A6D File Offset: 0x00112C6D
		public static global::Org.BouncyCastle.Asn1.X509.PolicyInformation GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.PolicyInformation)
			{
				return (global::Org.BouncyCastle.Asn1.X509.PolicyInformation)obj;
			}
			return new global::Org.BouncyCastle.Asn1.X509.PolicyInformation(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06003C6A RID: 15466 RVA: 0x00114A8C File Offset: 0x00112C8C
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier PolicyIdentifier
		{
			get
			{
				return this.policyIdentifier;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06003C6B RID: 15467 RVA: 0x00114A94 File Offset: 0x00112C94
		public global::Org.BouncyCastle.Asn1.Asn1Sequence PolicyQualifiers
		{
			get
			{
				return this.policyQualifiers;
			}
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x00114A9C File Offset: 0x00112C9C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.policyIdentifier
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.policyQualifiers
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001AAA RID: 6826
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier policyIdentifier;

		// Token: 0x04001AAB RID: 6827
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence policyQualifiers;
	}
}
