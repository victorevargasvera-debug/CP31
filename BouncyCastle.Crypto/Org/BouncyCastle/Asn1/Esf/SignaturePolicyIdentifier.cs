using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000718 RID: 1816
	public class SignaturePolicyIdentifier : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06004163 RID: 16739 RVA: 0x00128138 File Offset: 0x00126338
		public static global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyIdentifier GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyIdentifier)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyIdentifier)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyId)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyIdentifier((global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyId)obj);
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Null)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyIdentifier();
			}
			throw new global::System.ArgumentException("Unknown object in 'SignaturePolicyIdentifier' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x00128193 File Offset: 0x00126393
		public SignaturePolicyIdentifier()
		{
			this.sigPolicy = null;
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x001281A2 File Offset: 0x001263A2
		public SignaturePolicyIdentifier(global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyId signaturePolicyId)
		{
			if (signaturePolicyId == null)
			{
				throw new global::System.ArgumentNullException("signaturePolicyId");
			}
			this.sigPolicy = signaturePolicyId;
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06004166 RID: 16742 RVA: 0x001281BF File Offset: 0x001263BF
		public global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyId SignaturePolicyId
		{
			get
			{
				return this.sigPolicy;
			}
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x001281C7 File Offset: 0x001263C7
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.sigPolicy != null)
			{
				return this.sigPolicy.ToAsn1Object();
			}
			return global::Org.BouncyCastle.Asn1.DerNull.Instance;
		}

		// Token: 0x04001F4C RID: 8012
		private readonly global::Org.BouncyCastle.Asn1.Esf.SignaturePolicyId sigPolicy;
	}
}
