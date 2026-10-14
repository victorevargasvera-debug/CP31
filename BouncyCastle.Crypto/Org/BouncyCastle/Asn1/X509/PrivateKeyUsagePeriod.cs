using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000666 RID: 1638
	public class PrivateKeyUsagePeriod : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C7A RID: 15482 RVA: 0x00114CAC File Offset: 0x00112EAC
		public static global::Org.BouncyCastle.Asn1.X509.PrivateKeyUsagePeriod GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.PrivateKeyUsagePeriod)
			{
				return (global::Org.BouncyCastle.Asn1.X509.PrivateKeyUsagePeriod)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.PrivateKeyUsagePeriod((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			if (obj is global::Org.BouncyCastle.Asn1.X509.X509Extension)
			{
				return global::Org.BouncyCastle.Asn1.X509.PrivateKeyUsagePeriod.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extension.ConvertValueToObject((global::Org.BouncyCastle.Asn1.X509.X509Extension)obj));
			}
			throw new global::System.ArgumentException("unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x00114D10 File Offset: 0x00112F10
		private PrivateKeyUsagePeriod(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tObj = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
				if (tObj.TagNo == 0)
				{
					this._notBefore = global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(tObj, false);
				}
				else if (tObj.TagNo == 1)
				{
					this._notAfter = global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(tObj, false);
				}
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06003C7C RID: 15484 RVA: 0x00114D90 File Offset: 0x00112F90
		public global::Org.BouncyCastle.Asn1.DerGeneralizedTime NotBefore
		{
			get
			{
				return this._notBefore;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06003C7D RID: 15485 RVA: 0x00114D98 File Offset: 0x00112F98
		public global::Org.BouncyCastle.Asn1.DerGeneralizedTime NotAfter
		{
			get
			{
				return this._notAfter;
			}
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x00114DA0 File Offset: 0x00112FA0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(false, 0, this._notBefore);
			asn1EncodableVector.AddOptionalTagged(false, 1, this._notAfter);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001AB2 RID: 6834
		private global::Org.BouncyCastle.Asn1.DerGeneralizedTime _notBefore;

		// Token: 0x04001AB3 RID: 6835
		private global::Org.BouncyCastle.Asn1.DerGeneralizedTime _notAfter;
	}
}
