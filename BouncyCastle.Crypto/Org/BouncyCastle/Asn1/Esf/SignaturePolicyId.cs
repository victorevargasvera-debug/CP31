using System;
using System.Collections;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000717 RID: 1815
	public class SignaturePolicyId : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600415A RID: 16730 RVA: 0x00127EC0 File Offset: 0x001260C0
		public static global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyId GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyId)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyId)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyId((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'SignaturePolicyId' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x00127F10 File Offset: 0x00126110
		private SignaturePolicyId(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count < 2 || seq.Count > 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.sigPolicyIdentifier = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0].ToAsn1Object();
			this.sigPolicyHash = global::Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue.GetInstance(seq[1].ToAsn1Object());
			if (seq.Count > 2)
			{
				this.sigPolicyQualifiers = (global::Org.BouncyCastle.Asn1.Asn1Sequence)seq[2].ToAsn1Object();
			}
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x00127FB4 File Offset: 0x001261B4
		public SignaturePolicyId(global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigPolicyIdentifier, global::Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue sigPolicyHash) : this(sigPolicyIdentifier, sigPolicyHash, null)
		{
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x00127FC0 File Offset: 0x001261C0
		public SignaturePolicyId(global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigPolicyIdentifier, global::Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue sigPolicyHash, params global::Org.BouncyCastle.Asn1.Esf.SigPolicyQualifierInfo[] sigPolicyQualifiers)
		{
			if (sigPolicyIdentifier == null)
			{
				throw new global::System.ArgumentNullException("sigPolicyIdentifier");
			}
			if (sigPolicyHash == null)
			{
				throw new global::System.ArgumentNullException("sigPolicyHash");
			}
			this.sigPolicyIdentifier = sigPolicyIdentifier;
			this.sigPolicyHash = sigPolicyHash;
			if (sigPolicyQualifiers != null)
			{
				this.sigPolicyQualifiers = new global::Org.BouncyCastle.Asn1.DerSequence(sigPolicyQualifiers);
			}
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x00128010 File Offset: 0x00126210
		public SignaturePolicyId(global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigPolicyIdentifier, global::Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue sigPolicyHash, global::System.Collections.IEnumerable sigPolicyQualifiers)
		{
			if (sigPolicyIdentifier == null)
			{
				throw new global::System.ArgumentNullException("sigPolicyIdentifier");
			}
			if (sigPolicyHash == null)
			{
				throw new global::System.ArgumentNullException("sigPolicyHash");
			}
			this.sigPolicyIdentifier = sigPolicyIdentifier;
			this.sigPolicyHash = sigPolicyHash;
			if (sigPolicyQualifiers != null)
			{
				if (!global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.CheckElementsAreOfType(sigPolicyQualifiers, typeof(global::Org.BouncyCastle.Asn1.Esf.SigPolicyQualifierInfo)))
				{
					throw new global::System.ArgumentException("Must contain only 'SigPolicyQualifierInfo' objects", "sigPolicyQualifiers");
				}
				this.sigPolicyQualifiers = new global::Org.BouncyCastle.Asn1.DerSequence(global::Org.BouncyCastle.Asn1.Asn1EncodableVector.FromEnumerable(sigPolicyQualifiers));
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x00128083 File Offset: 0x00126283
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier SigPolicyIdentifier
		{
			get
			{
				return this.sigPolicyIdentifier;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06004160 RID: 16736 RVA: 0x0012808B File Offset: 0x0012628B
		public global::Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue SigPolicyHash
		{
			get
			{
				return this.sigPolicyHash;
			}
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x00128094 File Offset: 0x00126294
		public global::Org.BouncyCastle.Asn1.Esf.SigPolicyQualifierInfo[] GetSigPolicyQualifiers()
		{
			if (this.sigPolicyQualifiers == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Esf.SigPolicyQualifierInfo[] infos = new global::Org.BouncyCastle.Asn1.Esf.SigPolicyQualifierInfo[this.sigPolicyQualifiers.Count];
			for (int i = 0; i < this.sigPolicyQualifiers.Count; i++)
			{
				infos[i] = global::Org.BouncyCastle.Asn1.Esf.SigPolicyQualifierInfo.GetInstance(this.sigPolicyQualifiers[i]);
			}
			return infos;
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x001280E8 File Offset: 0x001262E8
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.sigPolicyIdentifier,
				this.sigPolicyHash.ToAsn1Object()
			});
			if (this.sigPolicyQualifiers != null)
			{
				v.Add(this.sigPolicyQualifiers.ToAsn1Object());
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F49 RID: 8009
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigPolicyIdentifier;

		// Token: 0x04001F4A RID: 8010
		private readonly global::Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue sigPolicyHash;

		// Token: 0x04001F4B RID: 8011
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence sigPolicyQualifiers;
	}
}
