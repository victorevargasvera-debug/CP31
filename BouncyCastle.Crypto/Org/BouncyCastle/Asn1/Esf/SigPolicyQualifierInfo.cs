using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x0200071B RID: 1819
	public class SigPolicyQualifierInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600417B RID: 16763 RVA: 0x0012852C File Offset: 0x0012672C
		public static global::Org.BouncyCastle.Asn1.Esf.SigPolicyQualifierInfo GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.SigPolicyQualifierInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.SigPolicyQualifierInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.SigPolicyQualifierInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'SigPolicyQualifierInfo' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x0012857C File Offset: 0x0012677C
		private SigPolicyQualifierInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.sigPolicyQualifierId = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0].ToAsn1Object();
			this.sigQualifier = seq[1].ToAsn1Object();
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x001285F2 File Offset: 0x001267F2
		public SigPolicyQualifierInfo(global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigPolicyQualifierId, global::Org.BouncyCastle.Asn1.Asn1Encodable sigQualifier)
		{
			this.sigPolicyQualifierId = sigPolicyQualifierId;
			this.sigQualifier = sigQualifier.ToAsn1Object();
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x0600417E RID: 16766 RVA: 0x0012860D File Offset: 0x0012680D
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier SigPolicyQualifierId
		{
			get
			{
				return this.sigPolicyQualifierId;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x0600417F RID: 16767 RVA: 0x00128615 File Offset: 0x00126815
		public global::Org.BouncyCastle.Asn1.Asn1Object SigQualifier
		{
			get
			{
				return this.sigQualifier;
			}
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x0012861D File Offset: 0x0012681D
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.sigPolicyQualifierId,
				this.sigQualifier
			});
		}

		// Token: 0x04001F52 RID: 8018
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigPolicyQualifierId;

		// Token: 0x04001F53 RID: 8019
		private readonly global::Org.BouncyCastle.Asn1.Asn1Object sigQualifier;
	}
}
