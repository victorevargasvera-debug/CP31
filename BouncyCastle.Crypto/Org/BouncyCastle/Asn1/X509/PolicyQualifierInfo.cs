using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000665 RID: 1637
	public class PolicyQualifierInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C73 RID: 15475 RVA: 0x00114BC5 File Offset: 0x00112DC5
		public PolicyQualifierInfo(global::Org.BouncyCastle.Asn1.DerObjectIdentifier policyQualifierId, global::Org.BouncyCastle.Asn1.Asn1Encodable qualifier)
		{
			this.policyQualifierId = policyQualifierId;
			this.qualifier = qualifier;
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x00114BDB File Offset: 0x00112DDB
		public PolicyQualifierInfo(string cps)
		{
			this.policyQualifierId = global::Org.BouncyCastle.Asn1.X509.PolicyQualifierID.IdQtCps;
			this.qualifier = new global::Org.BouncyCastle.Asn1.DerIA5String(cps);
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x00114BFC File Offset: 0x00112DFC
		private PolicyQualifierInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.policyQualifierId = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			this.qualifier = seq[1];
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x00114C5A File Offset: 0x00112E5A
		public static global::Org.BouncyCastle.Asn1.X509.PolicyQualifierInfo GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.PolicyQualifierInfo)
			{
				return (global::Org.BouncyCastle.Asn1.X509.PolicyQualifierInfo)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.PolicyQualifierInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06003C77 RID: 15479 RVA: 0x00114C7B File Offset: 0x00112E7B
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier PolicyQualifierId
		{
			get
			{
				return this.policyQualifierId;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06003C78 RID: 15480 RVA: 0x00114C83 File Offset: 0x00112E83
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable Qualifier
		{
			get
			{
				return this.qualifier;
			}
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x00114C8B File Offset: 0x00112E8B
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.policyQualifierId,
				this.qualifier
			});
		}

		// Token: 0x04001AB0 RID: 6832
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier policyQualifierId;

		// Token: 0x04001AB1 RID: 6833
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable qualifier;
	}
}
